// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2018 Petrotechnical Data Systems
// 
// Third Party Software
// 
// Energistics 
// The following Energistics (c) products were used in the creation of this work: 
// 
// •             WITSML Data Schema Specifications, Version 1.4.1.1 
// •             WITSML API Specifications, version 1.4.1.1 
// •             WITSML Data Schema Specifications, Version 1.3.1.1 
// •             WITSML API Specifications, version 1.3.1 
// •             PRODML Data Schema Specifications, Version 1.2.2 
// •             PRODML Web Service Specifications, Version 2.1.0.1
// •             RESQML Data Schema Specifications, Version 1.1 
// 
// All rights in the WITSML™ Standard, the PRODML™ Standard, and the RESQML™ Standard, or
// any portion thereof, which remain in the Standards DevKit shall remain with Energistics
// or its suppliers and shall remain subject to the terms of the Product License Agreement
// available at http://www.energistics.org/product-license-agreement. 
// 
// Apache
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
// except in compliance with the License. 
// 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the
// License.
// 
// HDF5
// HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 2006-2012 by
// The HDF Group. 
// 
// NCSA HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 1998-2006
// by the Board of Trustees of the University of Illinois. 
// 
// All rights reserved. 
// 
// Redistribution and use in source and binary forms, with or without modification, are
// permitted for any purpose (including commercial purposes) provided that the following
// conditions are met: 
//    1. Redistributions of source code must retain the above copyright notice, this list
//       of conditions, and the following disclaimer. 
//    2. Redistributions in binary form must reproduce the above copyright notice, this
//       list of conditions, and the following disclaimer in the documentation and/or
// 	  materials provided with the distribution. 
//    3. In addition, redistributions of modified forms of the source or binary code must
//       carry prominent notices stating that the original code was changed and the date of
// 	  the change. 
//    4. All publications or advertising materials mentioning features or use of this
//       software are asked, but not required, to acknowledge that it was developed by The
// 	  HDF Group and by the National Center for Supercomputing Applications at the 
// 	  University of Illinois at Urbana-Champaign and credit the contributors. 
//    5. Neither the name of The HDF Group, the name of the University, nor the name of any
//       Contributor may be used to endorse or promote products derived from this software
// 	  without specific prior written permission from The HDF Group, the University, or
// 	  the Contributor, respectively. 
// 
// DISCLAIMER: THIS SOFTWARE IS PROVIDED BY THE HDF GROUP AND THE CONTRIBUTORS "AS IS" WITH
// NO WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED. In no event shall The HDF Group or
// the Contributors be liable for any damages suffered by the users arising out of the use
// of this software, even if advised of the possibility of such damage. 
// 
// Contributors: National Center for Supercomputing Applications (NCSA) at the University of
// Illinois, Fortner Software, Unidata Program Center (netCDF), The Independent JPEG Group
// (JPEG), Jean-loup Gailly and Mark Adler (gzip), and Digital Equipment Corporation (DEC). 
// 

using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Helper class for handling client compression.
    /// </summary>
    public static class ClientCompression
    {
        private static readonly Regex Base64Regex = new Regex(@"^[+/0-9A-Za-z]+={0,2}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static readonly string CompressionMethod = "compressionMethod";
        private static readonly string CompressionMethodGZip = "compressionMethod=gzip";
                    
        /// <summary>
        /// Sets GZip as the compression method to the options in.
        /// </summary>
        /// <param name="optionsIn">The options in</param>
        /// <returns>The options in with compressionMethod=gzip added.</returns>
        /// <remarks>If the options in already had compressionMethod set, it is replaced.</remarks>
        public static string SetCompressionMethodToGZip(string optionsIn)
        {
            if (string.IsNullOrEmpty(optionsIn))
                return CompressionMethodGZip;

            var allOptions = optionsIn.Split(';');
            for (int i = 0; i < allOptions.Length; i++)
            {
                if (allOptions[i].StartsWith(CompressionMethod))
                {
                    allOptions[i] = CompressionMethodGZip;
                    return string.Join(";", allOptions);
                }
            }

            return optionsIn + ";" + CompressionMethodGZip;
        }

        /// <summary>
        /// Checks if the options in have GZip set as the compression method.
        /// </summary>
        /// <param name="optionsIn">The options in.</param>
        /// <returns><c>true</c> if the compressionMethod is set to gzip; <c>false</c> otherwise.</returns>
        public static bool IsCompressionMethodSetToGZip(string optionsIn)
        {
            if (string.IsNullOrEmpty(optionsIn)) return false;

            return optionsIn.Contains(CompressionMethodGZip);
        }

        /// <summary>
        /// Compresses the input XML document and Base64 encodes it.
        /// </summary>
        /// <param name="xmlIn">The input XML to compress.</param>
        public static string GZipCompressAndBase64Encode(string xmlIn)
        {
            if (string.IsNullOrEmpty(xmlIn)) return xmlIn;

            using (var uncompressedStream = new MemoryStream(Encoding.UTF8.GetBytes(xmlIn)))
            {
                var compressedStream = new MemoryStream();
                using (var gzipStream = new GZipStream(compressedStream, CompressionMode.Compress))
                {
                    uncompressedStream.CopyTo(gzipStream);
                }

                return Convert.ToBase64String(compressedStream.ToArray());
            }
        }

        /// <summary>
        /// Checks if the input XML string is Base64 encoded.
        /// </summary>
        /// <param name="xmlIn">The input XML string to check.</param>
        /// <returns><c>true</c> if <paramref name="xmlIn"/> is Base64 encoded; <c>false</c> otherwise.</returns>
        /// <remarks>Based on comments from https://stackoverflow.com/a/475217/74601. </remarks>
        public static bool IsBase64Encoded(string xmlIn)
        {
            if (string.IsNullOrEmpty(xmlIn) || xmlIn.Length % 4 != 0)
                return false;

            return Base64Regex.IsMatch(xmlIn);
        }

        /// <summary>
        /// Checks if the byte array is gzipped.
        /// </summary>
        /// <param name="bytes">The input byte array.</param>
        /// <returns><c>true</c> if <paramref name="bytes"/> is gzipped; <c>false</c> otherwise.</returns>
        /// <remarks>Only checks if the byte array starts with the gzip magic number.</remarks>
        public static bool IsGZipCompressed(byte[] bytes)
        {
            if (bytes == null || bytes.Length < 2)
                return false;

            // Check if byte array starts with GZip magic numbers
            return bytes[0] == 0x1F && bytes[1] == 0x8B;
        }

        /// <summary>
        /// Checks if the input request is GZip compressed and Base64 encoded.
        /// </summary>
        /// <param name="xmlIn">The input XML string.</param>
        /// <returns><c>true</c> if <paramref name="xmlIn"/> is Base64 encoded and gzipped; <c>false</c> otherwise.</returns>
        public static bool IsBase64EncodedAndGZipCompressed(string xmlIn)
        {
            if (string.IsNullOrEmpty(xmlIn))
                return false;

            if (!IsBase64Encoded(xmlIn))
                return false;

            // Decode the first 4 characters into the first 3 bytes:
            var bytes = Convert.FromBase64String(xmlIn.Substring(0, 4));

            return IsGZipCompressed(bytes);
        }

        /// <summary>
        /// Decodes and decompresses the Base64 encoded, compressed input XML document.
        /// </summary>
        /// <param name="xmlIn">The compressed input XML to decompress.</param>
        /// <remarks>Does not check if the input string is actually compressed.</remarks>
        public static string Base64DecodeAndGZipDecompress(string xmlIn)
        {
            if (string.IsNullOrEmpty(xmlIn)) return xmlIn;

            using (var compressedStream = new MemoryStream(Convert.FromBase64String(xmlIn)))
            {
                var uncompressedStream = new MemoryStream();

                using (var gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    gzipStream.CopyTo(uncompressedStream);
                }

                uncompressedStream.Position = 0;
                using (var reader = new StreamReader(uncompressedStream, true))
                    return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Does an in-place update of the input strings to apply gzip compression.
        /// </summary>
        /// <param name="xmlIn">The input XML to compress.</param>
        /// <param name="optionsIn">The input optionsIn.</param>
        /// <remarks>
        /// Client compression is not defined in the 1.3.1 API.
        /// Client compression is only defined in the 1.4.1 API for GetFromStore, AddToStore and UpdateInStore.
        /// </remarks>
        public static void Compress(ref string xmlIn, ref string optionsIn)
        {
            if (string.IsNullOrEmpty(xmlIn)) return;

            optionsIn = SetCompressionMethodToGZip(optionsIn);
            xmlIn = GZipCompressAndBase64Encode(xmlIn);
        }

        /// <summary>
        /// Checks if the input string is compressed, and, if so, decompresses it.
        /// </summary>
        /// <param name="xmlIn">The potentially compressed input XML document.</param>
        /// <returns>The original input XML document if it was not compressed; the decompressed input XML document if it was compressed.</returns>
        public static string SafeDecompress(string xmlIn)
        {
            if (!IsBase64EncodedAndGZipCompressed(xmlIn))
                return xmlIn;

            return Base64DecodeAndGZipDecompress(xmlIn);
        }
    }
}
