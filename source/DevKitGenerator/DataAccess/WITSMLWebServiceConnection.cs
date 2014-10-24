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
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;
using System.Security;
using System.Runtime.InteropServices;

namespace Energistics.DataAccess
{
    public class WITSMLWebServiceConnection
    {
        private string username;
        private SecureString password;
        private NetworkCredential networkCredential = null;
        private string capabilitiesIn = String.Empty;
        private WMLSVersion ver;

        /// <summary>
        /// Creates a new WITSMLWebServiceConnection
        /// </summary>
        /// <param name="url">The target URL of the WITSML web service</param>
        /// <param name="ver">The version of the WITSML server</param>
        public WITSMLWebServiceConnection(string url, WMLSVersion ver)
        {           
            this.Url = url;
            this.ver = ver;
            Timeout = 60000;
        }

        /// <summary>
        /// The target URL of the WITSML web service
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The username to use when authenticating with the WITSML web service
        /// </summary>
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                networkCredential = null;
            }
        }

        /// <summary>
        /// The domain that the username belongs to
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Indicates the time an XML Web service client waits for a synchronous XML Web service request to complete (in milliseconds).
        /// Default: 60000 ms
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// The password to use when authenticating with the WITSML web service
        /// </summary>
        public void SetSecurePassword(SecureString value)
        {
            password = value;
            password.MakeReadOnly();
            networkCredential = null;
        }

        /// <summary>
        /// The password to use when authenticating with the WITSML web service.
        /// Whenever possible, you should set SecurePassword instead.
        /// </summary>
        public void SetPassword(string value)
        {
            SecureString secureString = new SecureString();
            foreach (char c in value.ToCharArray())
            {
                secureString.AppendChar(c);
            }

            SetSecurePassword(secureString);
        }

        /// <summary>
        /// Optional web proxy to use when making connections.
        /// </summary>
        public WebProxy Proxy { get; set; }

        /// <summary>
        /// Reads an object of type T from the WITSML web service
        /// </summary>
        /// <typeparam name="T">The type of the Energistic object to read</typeparam>
        /// <param name="queryObject">An Energistics object of type T that contains the parameters of the query</param>
        /// <returns>The Energistics object of type T returned from the call to the WITSML web service</returns>
        public T Read<T>(T queryObject)
        {
            string queryXml = EnergisticsConverter.ObjectToXml<T>(queryObject);
            string optionsIn = "returnElements = all"; 
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
            string xmlIn = EnergisticsConverter.ObjectToXml<T>(energisticsObject);
            string optionsIn = String.Empty;
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
            string queryXml = EnergisticsConverter.ObjectToXml<T>(queryObject);
            string optionsIn = String.Empty;
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
            string xmlIn = EnergisticsConverter.ObjectToXml<T>(energisticsObject);
            string optionsIn = String.Empty;
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
            string capOut = String.Empty;
            string optionsIn = String.Empty;
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
            
            Type wmlsType = Type.GetType("Energistics.DataAccess." + Enum.GetName(typeof(WMLSVersion), ver) + ".WMLS.WMLS");
            SoapHttpClientProtocol service = (SoapHttpClientProtocol)wmlsType.GetConstructor(new Type[0]).Invoke(new object[] { });

            service.Url = Url;
            service.Timeout = Timeout;           
            service.Proxy = Proxy;
            service.Credentials = GetNetworkCredential();

            object statusCode = wmlsType.GetMethod(wmlsMethod).Invoke(service, methodParms);

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
        /// Gets the NetworkCredential from username/password
        /// </summary>
        private NetworkCredential GetNetworkCredential()
        {
            if (networkCredential == null)
            {
                if (password == null || String.IsNullOrEmpty(Username))
                {
                    return null;
                }

                // Need to convert our SecureString into a regular string to pass to NetworkCredential constructor
                IntPtr unmanagedString = IntPtr.Zero;
                try
                {
                    unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(password);
                    if (String.IsNullOrEmpty(Domain))
                    {
                        networkCredential = new NetworkCredential(Username, Marshal.PtrToStringUni(unmanagedString));
                    }
                    else
                    {
                        networkCredential = new NetworkCredential(Username, Marshal.PtrToStringUni(unmanagedString), Domain);
                    }
                }
                finally
                {
                    // Clean up our memory after conversion
                    Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
                }
            }

            return networkCredential;
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
    }

    /// <summary>
    /// The version of the WITSML web service
    /// </summary>
    public enum WMLSVersion
    {
        WITSML131,
        WITSML141
    }
}
