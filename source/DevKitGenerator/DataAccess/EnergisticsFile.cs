// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2012 ExxonMobil Upstream Research Company
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
using System.Text;
using System.Xml.Serialization;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Class that handles reading and writing of Energistics XML files
    /// </summary>
    public static class EnergisticsFile
    {
        /// <summary>
        /// Reads an Energistics XML file
        /// </summary>
        /// <typeparam name="T">Type of the object that the file contains</typeparam>
        /// <param name="fileName">Name of the XML file</param>
        /// <returns>The object representation of the XML file</returns>
        public static T ReadFile<T>(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    T xmlobject = EnergisticsConverter.XmlToObject<T>(sr.ReadToEnd(), sr.CurrentEncoding);
                    var h5Doc = xmlobject as IH5Document;
                    if (h5Doc != null)
                    {
                        h5Doc.H5Filename = fileName + ".h5";
                    }

                    return xmlobject;
                }
            }
            throw new FileNotFoundException(String.Format("Cannot find file '{0}'", fileName));
        }

        /// <summary>
        /// Writes an Energistics object to an XML file. Does not overwrite existing file.
        /// </summary>
        /// <param name="fileName">The name of the XML file</param>
        /// <param name="energisticsObject">The object to write</param>
        public static void WriteFile(string fileName, object energisticsObject)
        {
            WriteFile(fileName, energisticsObject, false);
        }

        /// <summary>
        /// Writes an Energistics object to an XML file
        /// </summary>
        /// <param name="fileName">The name of the XML file</param>
        /// <param name="energisticsObject">The object to write</param>
        /// <param name="allowOverwrites">Overwrite existing file</param>
        public static void WriteFile(string fileName, object energisticsObject, bool allowOverwrites)
        {
            if (energisticsObject != null)
            {
                if (!allowOverwrites && File.Exists(fileName))
                {
                    throw new Exception("File already exists.");
                }

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(EnergisticsConverter.ObjectToXml(energisticsObject));
                }

                var h5Doc = energisticsObject as IH5Document;
                if (h5Doc != null)
                {
                    h5Doc.H5Filename = fileName + ".h5";
                }
            }
        }   
    }
}
