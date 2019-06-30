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
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Class that makes connection to a WITSML Web Service
    /// </summary>
    public class WITSMLWebServiceConnection : AbstractWebServiceConnection
    {
        private string capabilitiesIn = string.Empty;
        private WMLSVersion ver;

        /// <summary>
        /// Creates a new WITSMLWebServiceConnection
        /// </summary>
        /// <param name="url">The target URL of the WITSML web service</param>
        /// <param name="ver">The version of the WITSML server</param>
        public WITSMLWebServiceConnection(string url, WMLSVersion ver) : base(url)
        {
            this.ver = ver;
        }

        /// <summary>
        /// Gets or sets a value indicating whether server compression is enabled.
        /// </summary>
        /// <value><c>true</c> if server compression is enabled; otherwise, <c>false</c>.</value>
        [Obsolete("Use IsServerCompressionEnabled instead.")]
        public bool IsCompressionEnabled { get { return AcceptCompressedResponses; } set { AcceptCompressedResponses = value; } }

        /// <summary>
        /// Gets or sets a value indicating whether compressed responses from the server are accepted.
        /// </summary>
        /// <value><c>true</c> if compressed responses are accepted; otherwise, <c>false</c>.</value>
        /// <remarks>If enabled, WITSML API calls will inform the server that compressed responses are accepted and handle any compressed responses.</remarks>
        public bool AcceptCompressedResponses { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether requests from the client should be compressed.
        /// </summary>
        /// <value><c>true</c> if client requests should be compressed; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// If <c>true</c>, client applications should compress XML input sent to the server for GetFromStore, AddToStore and UpdateInStore.
        /// </remarks>
        public bool CompressRequests { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether pre-authentication is enabled.
        /// </summary>
        /// <value><c>true</c> if pre-authentication is enabled; otherwise, <c>false</c>.</value>
        public bool IsPreAuthenticationEnabled { get; set; }

        /// <summary>
        /// Gets or sets the collection of name/value pairs to include as HTTP headers.
        /// </summary>
        /// <value>The collection of name/value pairs.</value>
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Reads an object of type T from the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to read</typeparam>
        /// <param name="queryObject">An Energistics object of type T that contains the parameters of the query</param>
        /// <returns>The Energistics object of type T returned from the call to the WITSML web service</returns>
        public T Read<T>(T queryObject)
        {
            Dictionary<string, string> optionsIn = new Dictionary<string, string>();
            optionsIn.Add("returnElements", "all");

            return Read<T>(queryObject, optionsIn);
        }

        /// <summary>
        /// Reads an object of type T from the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to read</typeparam>
        /// <param name="queryObject">An Energistics object of type T that contains the parameters of the query</param>
        /// <param name="optionsInDictionary">A dictionary of keyword value pairs used to pass additional options to the server. See API documentation for more information</param>
        /// <returns>The Energistics object of type T returned from the call to the WITSML web service</returns>
        public T Read<T>(T queryObject, Dictionary<string, string> optionsInDictionary)
        {
            string queryXml = EnergisticsConverter.ObjectToXml(queryObject);
            string optionsIn = OptionsInDictionaryToString(optionsInDictionary);
            string responseXml = String.Empty;
            string message = String.Empty;

            string[] methodParms = new string[] { GetWmlTypeIn(typeof(T)), queryXml, optionsIn, capabilitiesIn, responseXml, message };
            WMLSCall("WMLS_GetFromStore", methodParms);

            responseXml = methodParms[4];
            responseXml = Regex.Replace(responseXml, @"\n", "");
            responseXml = Regex.Replace(responseXml, @">\s+", ">");
            responseXml = Regex.Replace(responseXml, @"\s+<", "<");

            return EnergisticsConverter.XmlToObject<T>(responseXml);
        }

        /// <summary>
        /// Writes an object of type T from the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to write</typeparam>
        /// <param name="energisticsObject">The Energistics object to write</param>
        public void Write<T>(T energisticsObject)
        {
            Dictionary<string, string> optionsIn = new Dictionary<string, string>();
            Write<T>(energisticsObject, optionsIn);
        }

        /// <summary>
        /// Writes an object of type T from the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to write</typeparam>
        /// <param name="energisticsObject">The Energistics object to write</param>
        /// <param name="optionsInDictionary">A dictionary of keyword value pairs used to pass additional options to the server. See API documentation for more information</param>
        public void Write<T>(T energisticsObject, Dictionary<string, string> optionsInDictionary)
        {
            string xmlIn = EnergisticsConverter.ObjectToXml(energisticsObject);
            string optionsIn = OptionsInDictionaryToString(optionsInDictionary);
            string message = String.Empty;

            string[] methodParms = new string[] { GetWmlTypeIn(typeof(T)), xmlIn, optionsIn, capabilitiesIn, message };
            WMLSCall("WMLS_AddToStore", methodParms);
        }

        /// <summary>
        /// Deletes an object of type T from the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to delete</typeparam>
        /// <param name="queryObject">An Energistics object of type T that contains the parameters of the query</param>
        public void Delete<T>(T queryObject)
        {
            Dictionary<string, string> optionsIn = new Dictionary<string, string>();
            Delete<T>(queryObject, optionsIn);
        }

        /// <summary>
        /// Deletes an object of type T from the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to delete</typeparam>
        /// <param name="queryObject">An Energistics object of type T that contains the parameters of the query</param>
        /// <param name="optionsInDictionary">A dictionary of keyword value pairs used to pass additional options to the server. See API documentation for more information</param>
        public void Delete<T>(T queryObject, Dictionary<string, string> optionsInDictionary)
        {
            string queryXml = EnergisticsConverter.ObjectToXml(queryObject);
            string optionsIn = OptionsInDictionaryToString(optionsInDictionary);
            string message = String.Empty;

            string[] methodParms = new string[] { GetWmlTypeIn(typeof(T)), queryXml, optionsIn, capabilitiesIn, message };
            WMLSCall("WMLS_DeleteFromStore", methodParms);
        }

        /// <summary>
        /// Updates an object of type T on the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to update</typeparam>
        /// <param name="energisticsObject">The Energistics object to update</param>
        public void Update<T>(T energisticsObject)
        {
            Dictionary<string, string> optionsIn = new Dictionary<string, string>();
            Update<T>(energisticsObject, optionsIn);
        }

        /// <summary>
        /// Updates an object of type T on the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to update</typeparam>
        /// <param name="energisticsObject">The Energistics object to update</param>
        /// <param name="optionsInDictionary">A dictionary of keyword value pairs used to pass additional options to the server. See API documentation for more information</param>
        public void Update<T>(T energisticsObject, Dictionary<string, string> optionsInDictionary)
        {
            string xmlIn = EnergisticsConverter.ObjectToXml(energisticsObject);
            string optionsIn = OptionsInDictionaryToString(optionsInDictionary);
            string message = String.Empty;

            string[] methodParms = new string[] { GetWmlTypeIn(typeof(T)), xmlIn, optionsIn, capabilitiesIn, message };
            WMLSCall("WMLS_UpdateInStore", methodParms);
        }

        /// <summary>
        /// Gets the version number supported by the WITSML web service
        /// </summary>
        /// <returns>Version number as a string</returns>
        public string GetVersion()
        {
            return (string) WMLSCall("WMLS_GetVersion", new string[] {});
        }

        /// <summary>
        /// Gets the capabilities of the WITSML server
        /// </summary>
        /// <typeparam name="T">A CapServers type from the appropriate namespace</typeparam>
        /// <returns>A CapServer object</returns>
        public T GetCap<T>()
        {
            Dictionary<string, string> optionsIn = new Dictionary<string, string>();
            return GetCap<T>(optionsIn);
        }

        /// <summary>
        /// Gets the capabilities of the WITSML server
        /// </summary>
        /// <typeparam name="T">A CapServers type from the appropriate namespace</typeparam>
        /// <param name="optionsInDictionary">A dictionary of keyword value pairs used to pass additional options to the server. See API documentation for more information</param>
        /// <returns>A CapServer object</returns>
        public T GetCap<T>(Dictionary<string, string> optionsInDictionary)
        {
            string capOut = String.Empty;
            string optionsIn = OptionsInDictionaryToString(optionsInDictionary);
            string message = String.Empty;

            string[] methodParms = new string[] { optionsIn, capOut, message };
            WMLSCall("WMLS_GetCap", methodParms);

            return EnergisticsConverter.XmlToObject<T>(methodParms[1]);
        }

        private static string GetWmlTypeIn(Type t)
        {
            // Find XmlElement name of the property that contains a collection of objects from the same namespace as T
            foreach (PropertyInfo p in t.GetProperties())
            {
                if (Regex.IsMatch(p.PropertyType.AssemblyQualifiedName, @"\[\[" + t.Namespace + @"\..*?]]"))
                {
                    XmlElementAttribute[] xmlRootAttrs = (XmlElementAttribute[])p.GetCustomAttributes(typeof(XmlElementAttribute), false);

                    return xmlRootAttrs[0].ElementName;
                }
            }

            return null;
        }

        /// <summary>
        /// Makes a generic WMLSCall
        /// </summary>
        /// <param name="wmlsMethod">The method name to call</param>
        /// <param name="methodParms">The array of parameters to pass to the method</param>
        /// <returns>Status code</returns>
        private object WMLSCall(string wmlsMethod, string[] methodParms)
        {
            var service = CreateClientProxy();
            object statusCode = service.GetType().GetMethod(wmlsMethod).Invoke(service, methodParms);

            if (statusCode is short)
            {
                if ((short)statusCode < 0)
                {
                    throw new Exception("WITSML server error " + statusCode + ": '" + methodParms[methodParms.Length - 1] + "'");
                }
            }

            return statusCode;
        }

        /// <summary>
        /// Initializes an instance of the WMLS client proxy for the specified <see cref="WMLSVersion"/>.
        /// </summary>
        /// <returns></returns>
        public SoapHttpClientProtocol CreateClientProxy()
        {
            Type wmlsType = Type.GetType("Energistics.DataAccess." + Enum.GetName(typeof(WMLSVersion), ver) + ".WMLS.WMLS");
            SoapHttpClientProtocol service = (SoapHttpClientProtocol)wmlsType.GetConstructor(new Type[0]).Invoke(new object[] { });

            service.Url = Url;
            service.Timeout = Timeout;
            service.Proxy = Proxy;
            service.Credentials = GetNetworkCredential();
            service.PreAuthenticate = IsPreAuthenticationEnabled;

            var client = service as IWitsmlClient;
            if (client != null)
            {
                client.AcceptCompressedResponses = AcceptCompressedResponses;
                client.CompressRequests = CompressRequests;
                client.Headers = Headers;
            }

            return service;
        }


        /// <summary>
        /// Build an empty query object of type T
        /// </summary>
        /// <returns>The empty query object</returns>
        public static T BuildEmptyQuery<T>()
        {
            if (typeof(T).GetInterface("IEnergisticsCollection") == null)
            {
                throw new Exception("IEnergisticsCollection not implemented");
            }

            T containerObject = (T)typeof(T).GetConstructor(new Type[] { }).Invoke(new object[] { });

            if (typeof(T).Namespace == "Energistics.DataAccess.WITSML141")
            {
                typeof(T).GetProperty("Version").SetValue(containerObject, "1.4.1.0", new object[] { });
            }
            else if (typeof(T).Namespace == "Energistics.DataAccess.WITSML131")
            {
                typeof(T).GetProperty("Version").SetValue(containerObject, "1.3.1.0", new object[] { });
            }

            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                if (pi.PropertyType.Name.StartsWith("List"))
                {
                    object listOfChildrenInstance = pi.PropertyType.GetConstructor(new Type[] { }).Invoke(new object[] { });
                    pi.SetValue(containerObject, listOfChildrenInstance, new object[] { });

                    string childTypeName = Regex.Match(pi.PropertyType.FullName,@"\[\[(.*?),").Groups[1].Value;


                    Type childType = typeof(T).Assembly.GetType(childTypeName);
                    
                    object childInstance = childType.GetConstructor(new Type[] { }).Invoke(new object[] { });
                    
                    listOfChildrenInstance.GetType().GetMethod("Add").Invoke(listOfChildrenInstance, new object[] { childInstance });

                    break;
                }
            }

            return containerObject;
        }

        /// <summary>
        /// Retruns a list of all Energistics object types that are supported by the WITSML web service
        /// </summary>
        /// <returns>A list of supported types</returns>
        public List<Type> GetAllSupportedTypes()
        {
            List<string> getFromStoreCap = new List<string>();
            List<Type> supportedTypes = new List<Type>();

            string[] methodParms = new string[] { String.Empty, String.Empty, String.Empty };            
            WMLSCall("WMLS_GetCap", methodParms);

            string xml = methodParms[1];
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("ns", xmlDoc.LastChild.NamespaceURI);

            foreach (XmlNode dataObj in xmlDoc.SelectNodes("//ns:function[@name='WMLS_GetFromStore']/ns:dataObject", nsmgr))
            {
                getFromStoreCap.Add(dataObj.InnerText);
            }            

            Assembly asy = Assembly.GetAssembly(this.GetType());
            foreach (Type t in asy.GetTypes())
            {
                if (t.Namespace == "Energistics.DataAccess." + Enum.GetName(typeof(WMLSVersion), ver) && t.GetInterface("Energistics.DataAccess.IEnergisticsCollection") != null)
                {
                    foreach (XmlRootAttribute xmlRoot in t.GetCustomAttributes(typeof(XmlRootAttribute), false))
                    {
                        string rootname = xmlRoot.ElementName;
                        rootname = rootname.Substring(0, rootname.Length - 1);
                        if (getFromStoreCap.Contains(rootname))
                        {
                            supportedTypes.Add(t);
                        }
                    }

                }
            }

            return supportedTypes;
        }

        private static string OptionsInDictionaryToString(Dictionary<string, string> readOptions)
        {
            StringBuilder optionsBuilder = new StringBuilder(String.Empty);
            foreach (string key in readOptions.Keys)
            {
                if (optionsBuilder.Length > 0)
                {
                    optionsBuilder.Append(";");
                }
                optionsBuilder.Append(key);
                optionsBuilder.Append("=");
                optionsBuilder.Append(readOptions[key]);
            }
            return optionsBuilder.ToString();
        }
    }

    /// <summary>
    /// The version of the WITSML web service
    /// </summary>
    public enum WMLSVersion
    {
        /// <summary>
        /// WITSML 1.3.1.x
        /// </summary>
        WITSML131,

        /// <summary>
        /// WITSML 1.4.1.x
        /// </summary>
        WITSML141
    }
}
