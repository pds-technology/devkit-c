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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Energistics.DataAccess.EnumValue
{
    /// <summary>
    /// Converts enumValues XML file to a Class
    /// </summary>
    public static class EnumValuesXMLToClass
    {
        /// <summary>
        /// Converts enumValues XML file to a Class. To be used via EnumValuesExtensionGenerator.exe
        /// </summary>
        /// <param name="filename">Name of the XML file</param>
        /// <param name="nameSpace">Namespace to use</param>
        /// <param name="enumClassNames">enumClassNames</param>
        /// <param name="extensionClass">extensionClass</param>
        /// <param name="setName">setName</param>
        /// <returns></returns>
        public static string Convert(string filename, string nameSpace, List<string> enumClassNames, bool extensionClass, string setName)
        {
            if (filename.Length<=0) return "";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using Energistics.DataAccess.EnumValue;");
            sb.AppendLine("using System.Collections.Generic;");
            if (extensionClass)
            {
                sb.AppendLine("using Energistics.DataAccess." + setName + ";");
            }
            sb.AppendLine();
            sb.AppendLine("namespace " + nameSpace);
            sb.AppendLine("{");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(filename));

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("ns", xmlDoc.LastChild.NamespaceURI);

            foreach (XmlElement dataObj in xmlDoc.SelectNodes("//ns:enumList", nsmgr))
            {
                string inheritsFrom = "Energistics.DataAccess.EnumValue.EnumValue";
                if (dataObj.InnerXml.Contains("<lithoType>")) inheritsFrom = "Energistics.DataAccess.EnumValue.LithoTypeEnumValue";
                if (dataObj.InnerXml.Contains("<extensionDataType>")) inheritsFrom = "Energistics.DataAccess.EnumValue.ExtensionDataEnumValue";
                if (dataObj.InnerXml.Contains("<measureUom>")) inheritsFrom = "Energistics.DataAccess.EnumValue.MeasureUOMEnumValue";
                if (dataObj.InnerXml.Contains("<measureBaseForConversion>")) inheritsFrom = "Energistics.DataAccess.EnumValue.MeasureUOMEnumValue";
                if (dataObj.InnerXml.Contains("<realtimeDataType>")) inheritsFrom = "Energistics.DataAccess.EnumValue.RealtimeEnumValue";
                if (dataObj.InnerXml.Contains("<dimensionalClass>")) inheritsFrom = "Energistics.DataAccess.EnumValue.ResqmlPropertyKindEnumValue";
             
                string name = GetElementInnerText(dataObj, "name");
                string description = GetElementInnerText(dataObj, "description");
                //prevent the duplication element created.
                if (!enumClassNames.Contains(name))
                {
                    enumClassNames.Add(name);

                    sb.AppendLine("    /// <summary>");
                    sb.AppendLine("    /// " + description.Replace("\n", "\n    ///"));
                    sb.AppendLine("    /// </summary>");
                    sb.AppendLine("    [System.SerializableAttribute()]");
                    if (extensionClass)
                    {
                        sb.AppendLine("    public class " + name + "Extension : " + name);
                    }
                    else
                    {
                        sb.AppendLine("    public class " + name + " : " + inheritsFrom);
                    }
                    sb.AppendLine("    {");
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Protected constructor, should always pass in \"name\"");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        protected " + name + ((extensionClass) ? "Extension" : String.Empty) + "(): base() {}");
                    sb.AppendLine();
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Constructor");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        ///<param name=\"name\">Name of the " + name + "</param>");
                    sb.AppendLine("        public " + name + ((extensionClass) ? "Extension" : String.Empty) + "(string name) : base(name) {}");
                    sb.AppendLine();



                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Retrieves the complete list of " + name + "s");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        /// <returns>The complete list of " + name + "s</returns>");
                    sb.AppendLine("        public static List<" + name + "> GetList()");
                    sb.AppendLine("        {");
                    sb.AppendLine("            return GetList<" + name + ">();");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    Dictionary<string, XmlElement> usedValues = new Dictionary<string, XmlElement>();

                    foreach (XmlElement valueElement in dataObj.GetElementsByTagName("value"))
                    {
                        string valueName = GetElementInnerText(valueElement, "name");
                        string privPropName = RenameProperty(valueName, false);

                        // We shouldn't have to check for this, but there are duplicates in enumValuesProdml.xml
                        if (usedValues.ContainsKey(privPropName))
                        {
                            continue;
                        }
                        else
                        {
                            usedValues.Add(privPropName, valueElement);
                        }

                        string valueDescription = GetElementInnerText(valueElement, "description");
                        valueDescription = Regex.Replace(valueDescription, @"\s+", " ");
                        valueDescription = valueDescription.Replace("&", "&amp;");
                        valueDescription = valueDescription.Replace("<", "&lt;");
                        valueDescription = valueDescription.Replace("<", "&gt;");

                        sb.AppendLine("        private readonly static " + name + " " + privPropName + ";");

                        sb.AppendLine("        /// <summary>");
                        sb.AppendLine("        /// " + valueDescription);
                        sb.AppendLine("        /// </summary>");
                        sb.AppendLine("        [EnumValueNameAttribute(\"" + valueName + "\")]");
                        sb.AppendLine("        public static " + name + " " + RenameProperty(valueName, true));
                        sb.AppendLine("        {");
                        sb.AppendLine("            get ");
                        sb.AppendLine("            {");
                        //sb.AppendLine("                if (" + privPropName + " == null)");
                        //sb.AppendLine("                {");
                        //sb.AppendLine("                    " + privPropName + " = new " + name + "(\"" + GetElementInnerText(valueElement, "name") + "\");");




                        //sb.AppendLine("                }");
                        sb.AppendLine("                return " + privPropName + ";");
                        sb.AppendLine("            }");
                        sb.AppendLine("        }");
                        sb.AppendLine();
                    }

                    sb.AppendLine("        static " + name + "()");
                    sb.AppendLine("        {");

                    foreach (string usedValue in usedValues.Keys)
                    {
                        XmlElement valueElement = usedValues[usedValue];
                        sb.AppendLine("            " + usedValue + " = ");
                        sb.AppendLine("                new " + name + "(\"" + GetElementInnerText(valueElement, "name") + "\")");
                        sb.AppendLine("                {");
                        Type t = Assembly.GetExecutingAssembly().GetType(inheritsFrom);
                        string comma = "";
                        foreach (PropertyInfo pi in t.GetProperties())
                        {
                            object[] enumValNameAttrs = pi.GetCustomAttributes(typeof(EnumValueNameAttribute), false);
                            if (enumValNameAttrs.Length == 1)
                            {
                                EnumValueNameAttribute enumValNameAttr = (EnumValueNameAttribute)enumValNameAttrs[0];
                                if (enumValNameAttr.Name == "name")
                                {
                                    continue;
                                }
                                string propValue = GetElementInnerText(valueElement, enumValNameAttr.Name);
                                propValue = Regex.Replace(propValue, @"\s+", " ");
                                //propValue = propValue.Replace(Environment.NewLine, String.Empty);
                                propValue = propValue.Replace(@"\", @"\\");
                                propValue = propValue.Replace("\"", "\\\"");

                                if (!String.IsNullOrEmpty(propValue))
                                {
                                    if (pi.PropertyType == typeof(string))
                                    {
                                        sb.AppendLine(String.Format("                    {0}{1} = \"{2}\"", comma, pi.Name, propValue));
                                    }
                                    else if (pi.PropertyType == typeof(int) || pi.PropertyType == typeof(Boolean) || pi.PropertyType == typeof(Boolean?))
                                    {
                                        sb.AppendLine(String.Format("                    {0}{1} = {2}", comma, pi.Name, propValue));
                                    }
                                    else if (pi.PropertyType == typeof(Type))
                                    {
                                        sb.AppendLine(String.Format("                    {0}{1} = typeof({2})", comma, pi.Name, CapitalizeFirstLetter(propValue)));
                                    }
                                    else if (pi.PropertyType == typeof(EnumValue))
                                    {
                                        sb.AppendLine(String.Format("                    {0}{1} = {2}", comma, pi.Name, RenameProperty(propValue, true)));
                                    }
                                    else if (pi.PropertyType == typeof(EnumValueLithoType))
                                    {
                                        sb.AppendLine(String.Format("                    {0}{1} = EnumValueLithoType.{2}", comma, pi.Name, propValue));
                                    }
                                    else if (pi.PropertyType == typeof(EnumValueRealtimeType))
                                    {
                                        propValue = CapitalizeFirstLetter(propValue);
                                        sb.AppendLine(String.Format("                    {0}{1} = EnumValueRealtimeType.Realtime{2}", comma, pi.Name, propValue));
                                    }
                                    else
                                    {
                                        sb.AppendLine(String.Format("                    //UNK {0}{1} = \"{2}\"", comma, pi.Name, propValue));
                                    }
                                    comma = ",";
                                }
                            }
                        }
                        sb.AppendLine("            };");
                    }

                    sb.AppendLine("        }");
                    sb.AppendLine();
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Gets a " + name + " by name");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        /// <param name=\"name\">The name of the " + name + " to return</param>");
                    sb.AppendLine("        /// <returns>The " + name + " represented by 'name'</returns>");
                    sb.AppendLine("        public static " + name + " GetByName(string name)");
                    sb.AppendLine("        {");
                    sb.AppendLine("            if (enumValuesRegistry.ContainsKey(typeof(" + name + ")))");
                    sb.AppendLine("            {");
                    sb.AppendLine("                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(" + name + ")];");
                    sb.AppendLine("            ");
                    sb.AppendLine("                foreach (EnumValue.EnumValue ev in myList)");
                    sb.AppendLine("                {");
                    sb.AppendLine("                    if (ev.Name == name)");
                    sb.AppendLine("                    {");
                    sb.AppendLine("                        return (" + name + ")ev;");
                    sb.AppendLine("                    }");
                    sb.AppendLine("                }");
                    sb.AppendLine("            }");
                    sb.AppendLine("            ");
                    sb.AppendLine("            return null;");
                    sb.AppendLine("        }");

                    sb.AppendLine("    }");
                    sb.AppendLine();
                }
            }

            sb.AppendLine("}");

            string xml = sb.ToString();
            return xml;
        }

        private static string GetElementInnerText(XmlElement element, string name)
        {
            XmlNodeList childElements = element.GetElementsByTagName(name);
            if (childElements.Count > 0)
            {
                return childElements[0].InnerText;
            }

            return String.Empty;
        }

        private static string RenameProperty(string name, bool firstCharUppercase)
        {
            // Start with all chars lowercase            
            name = name.ToLower();
            if (name.EndsWith(" ") || name.StartsWith(" ")) name = name.Trim();

            if (name.Contains("1")) name = name.Replace("1", "One");
            if (name.Contains("2")) name = name.Replace("2", "Two");
            if (name.Contains("3")) name = name.Replace("3", "Three");
            if (name.Contains("4")) name = name.Replace("4", "Four");
            if (name.Contains("5")) name = name.Replace("5", "Five");
            if (name.Contains("6")) name = name.Replace("6", "Six");
            if (name.Contains("7")) name = name.Replace("7", "Seven");
            if (name.Contains("8")) name = name.Replace("8", "Eight");
            if (name.Contains("9")) name = name.Replace("9", "Nine");
            if (name.Contains("0")) name = name.Replace("0", "Zero");

            if (name.EndsWith("+")) name = name.Replace("+", "Plus");
            if (name.EndsWith("-")) name = name.Replace("-", "Minus");

            // Removes any character other than letters, number, and spaces
            Regex r = new Regex("(?:[^a-z ])", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled); 
            name = r.Replace(name, String.Empty); 

            
            name = Regex.Replace(name, @"\s+", " ");


            if (firstCharUppercase)
            {
                // Make the first char upper case
                name = CapitalizeFirstLetter(name);
            }
            else
            {
                name = LowercaseFirstLetter(name);
            }
            
            if (name == "fixed")
            {
                name = "@" + name;
            }

            while (name.Contains(' '))
            {
                int locSpac = name.IndexOf(' ');
                string nextChar = name[locSpac + 1].ToString().ToUpper();
                name = name.Remove(locSpac, 2);
                name = name.Insert(locSpac, nextChar);
            }

            string[] keywords = new string[] { "float", "double", "int", "long", "short", "event", "in", "string", "byte", "default", "fixed" ,"null"};

            if (keywords.Contains(name))
            {
                return "@" + name;
            }

            return name;
        }

        private static string CapitalizeFirstLetter(string name)
        {
            string firstChar = name[0].ToString().ToUpper();
            name = firstChar + name.Substring(1);
            return name;
        }
        private static string LowercaseFirstLetter(string name)
        {
            string firstChar = name[0].ToString().ToLower();
            name = firstChar + name.Substring(1);
            return name;
        }
    }
}
