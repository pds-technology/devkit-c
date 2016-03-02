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
using System.Xml.Xsl;
using System.Xml;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
namespace Energistics.DataAccess
{
    /// <summary>
    /// Class that handles conversion between Energistics object and XML
    /// </summary>
    public static class EnergisticsConverter
    {
        
        /// <summary>
        /// Convert an Energistics object to XML
        /// </summary>
        /// <param name="obj">The object to convert</param>
        /// <returns>The XML representation of the object</returns>
        public static string ObjectToXml(object obj)
        {
            return ObjectToXml(obj, Encoding.UTF8);
        }

        /// <summary>
        /// Convert an Energistics object to XML
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="obj">The object to convert</param>
        /// <returns>The XML representation of the object</returns>
        [Obsolete("Use ObjectToXml(object obj) instead", false)] 
        public static string ObjectToXml<T>(object obj)
        {
            return ObjectToXml(obj, Encoding.UTF8);
        }

        /// <summary>
        /// Convert an Energistics object to XML
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="obj">The object to convert</param>
        /// <param name="encoding">The encoding of the XML</param>
        /// <returns>The XML representation of the object</returns>
        [Obsolete("Use ObjectToXml(object obj, Encoding encoding) instead", false)] 
        public static string ObjectToXml<T>(object obj, Encoding encoding)
        {
            return ObjectToXml(obj, encoding);
        }

        /// <summary>
        /// Convert an Energistics object to XML
        /// </summary>
        /// <param name="obj">The object to convert</param>
        /// <param name="encoding">The encoding of the XML</param>
        /// <returns>The XML representation of the object</returns>
        public static string ObjectToXml(object obj, Encoding encoding)
        {
            if (encoding != null)
            {
                Type type = obj.GetType();
                var serializer = new XmlSerializer(obj.GetType());
                //fixing memory leaks.
                //var serializer = new XmlSerializer(obj.GetType(), GetXmlRootAttribute(type));
                
                using (var memstream = new MemoryStream())
                {
                    XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
                    xsn.Add("dc", "http://purl.org/dc/terms/");
                    xsn.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                    xsn.Add("gml", "http://www.opengis.net/gml/3.2");
                    xsn.Add("xlink", "http://www.w3.org/1999/xlink");

                    serializer.Serialize(memstream, obj, xsn);
                    return encoding.GetString(memstream.ToArray());
                }
            }

            return null;
        }

        private static XmlRootAttribute GetXmlRootAttribute(Type type)
        {
            XmlRootAttribute xRoot = null;
            
            if (type.Name == "ResqmlDocument")
            {
                xRoot = new XmlRootAttribute("resqmlDocument");
                xRoot.Namespace = "http://www.resqml.org/schemas/1series";
            }
            else
            {
                foreach (
                    XmlRootAttribute xra in
                        type.GetCustomAttributes(typeof (XmlRootAttribute), false))
                {
                    xRoot = xra;
                    break;
                }
            }
            return xRoot;
        }

        /// <summary>
        /// Converts XML to an Energistics object
        /// </summary>
        /// <param name="xml">The XML to convert</param>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <returns>The Energistics object</returns>
        public static T XmlToObject<T>(string xml)
        {
            return XmlToObject<T>(xml, Encoding.UTF8);
        }

        /// <summary>
        /// Converts XML to an Energistics object
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="xml">The XML to convert</param>
        /// <param name="encoding">The encoding of the XML</param>
        /// <returns>The Energistics object</returns>
        public static T XmlToObject<T>(string xml, Encoding encoding)
        {
            if (encoding != null)
            {
                Type type = typeof(T);
                var serializer = new XmlSerializer(type, GetXmlRootAttribute(type));
               
                if (type.Name == "ResqmlDocument")
                {
                    // Find all arrays of numbers, and removes extra whitespace so that .net can parse
                    xml = Regex.Replace(xml, "\"([\\d\\. ]*?)\"", new MatchEvaluator(ArrayCleaner));

                    // Strip out any unnecessary xsi:type attributes
                    xml = Regex.Replace(xml, "xsi:type=\"(.*?)\"", new MatchEvaluator(XsiTypeCleaner));
                }

                using (var memstream = new MemoryStream(encoding.GetBytes(xml)))
                {
                    object xmlobject = serializer.Deserialize(memstream);

                    if (xmlobject is T)
                    {
                        return (T) xmlobject;
                    }
                }
            }
            return default(T);
        }

        internal static string XsiTypeCleaner(Match match)
        {
            string xsiType = match.Groups[1].Value;

            if (xsiType.Contains(":"))
            {
                xsiType = xsiType.Substring(xsiType.IndexOf(":") + 1);
            }
            if (xsiType == "W3CDTF")
            {
                return match.Groups[0].Value;
            }

            return String.Empty;
        }

        internal static string ArrayCleaner(Match match)
        {
            return String.Format("\"{0}\"", match.Groups[1].Value.Trim().Replace("  ", " "));
        }


        /// <summary>
        /// Upgrades Energistics object from one version to another
        /// </summary>
        /// <typeparam name="T">Type of original object</typeparam>
        /// <typeparam name="TU">Type of new object</typeparam>
        /// <param name="oldObject">Original object</param>
        /// <returns>New object</returns>
        public static TU UpgradeVersion<T, TU>(T oldObject)
        {
            string oldNamespace = typeof(T).Namespace;
            string newNamespace = typeof(TU).Namespace;

            if (oldNamespace == "Energistics.DataAccess.WITSML131" && newNamespace == "Energistics.DataAccess.WITSML141")
            {
                return UpgradeVersion<T, TU>(oldObject, "Energistics.DataAccess.WITSML141.WITSML_conversion_v1311-v141_vers07.xml");
            }
            throw new Exception(String.Format("No converters found from {0} to {1}", oldNamespace, newNamespace));
        }

        private static TU UpgradeVersion<T, TU>(T oldObject, string xsltStreamName)
        {
            using (Stream oldObjStream = new MemoryStream(),
                          newObjStream = new MemoryStream(),
                          xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(xsltStreamName))
            {
                if (xsltStream != null)
                {
                    // Convert old object to XmlReader
                    var oldSerializer = new XmlSerializer(typeof(T));
                    oldSerializer.Serialize(oldObjStream, oldObject);
                    oldObjStream.Position = 0;
                    var oldReader = XmlReader.Create(oldObjStream);

                    // Run Transform
                    var xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(xsltStream));
                    xslt.Transform(oldReader, new XsltArgumentList(), newObjStream);

                    // Deserialize new object
                    newObjStream.Position = 0;
                    var newSerializer = new XmlSerializer(typeof(TU));
                    object xmlobject = newSerializer.Deserialize(newObjStream);

                    if (xmlobject is TU)
                    {
                        return (TU)xmlobject;
                    }
                }

                return default(TU);
            }
        }

    }
}
