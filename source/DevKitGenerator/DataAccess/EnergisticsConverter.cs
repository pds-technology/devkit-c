// 
// License notice 
// Standards DevKit, version 1.0 
// Copyright 2011 ExxonMobil Upstream Research Company
//  
// The following Energistics (c) products were used in the creation of this work: 
// 
// •	WITSML Data Schema Specifications, Version 1.4.1 
// •	WITSML API Specifications, version 1.4.1 
// •	WITSML Data Schema Specifications, Version 1.3.1.1 
// •	WITSML API Specifications, version 1.3.1 
// •	PRODML Data Schema Specifications, Version 1.2 
// •	PRODML Web Service Specifications, Version 2.0
// 
// All rights in the WITSML™ Standard and the PRODML™ Standard, or any portion thereof, which remain in the 
// Standards DevKitshall remain with Energistics or its suppliers and shall remain subject to the terms of 
// the Product License Agreement available at http://www.energistics.org/product-license-agreement. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in 
// compliance with the License. 
// 
// You may obtain a copy of the License at 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the License. 
// 
using System;
using System.IO;
using System.Text;
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
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="obj">The object to convert</param>
        /// <returns>The XML representation of the object</returns>
        public static string ObjectToXml<T>(T obj)
        {
            return ObjectToXml<T>(obj, Encoding.UTF8);
        }

        /// <summary>
        /// Convert an Energistics object to XML
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="obj">The object to convert</param>
        /// <param name="encoding">The encoding of the XML</param>
        /// <returns>The XML representation of the object</returns>
        public static string ObjectToXml<T>(T obj, Encoding encoding)
        {
            if (encoding != null)
            {
                Type t = typeof(T);
                XmlSerializer serializer = new XmlSerializer(t);

                using (MemoryStream memstream = new MemoryStream())
                {
                    serializer.Serialize(memstream, obj);
                    return encoding.GetString(memstream.ToArray());
                }
            }

            return null;
        }

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
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (MemoryStream memstream = new MemoryStream(encoding.GetBytes(xml)))
                {
                    object xmlobject = serializer.Deserialize(memstream);

                    if (xmlobject is T)
                    {
                        return (T)xmlobject;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
            return default(T);
        }
    }
}
