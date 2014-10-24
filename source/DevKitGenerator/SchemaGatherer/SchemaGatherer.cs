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
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Energistics.SchemaGatherer
{
    public class SchemaGatherer
    {
        static int Main(string[] args)
        {
            try
            {
                VerifyAppConfig();
            }
            catch (Exception e)
            {
                return 1;
            }

            foreach (string set in GetAppSetting("SETS").Split(new Char[] { ',' }))
            {
                ProcessEnergisticsSchemas(set);
            }

            return 0;
        }

        private static void VerifyAppConfig()
        {
            VerifySetting("SETS");
            VerifyPath("ROOT_FOLDER");
            VerifyPath("ENERGISTICS_FOLDER");
            VerifyPath("SOLUTION_FOLDER");
            VerifyPath("ENERGY_ML_GENERATOR_PROJ_PATH");
            VerifyPath("ENERGY_ML_DATA_ACCESS_PROJ_PATH");
            VerifyPath("MS_SDK");

            foreach (string set in GetAppSetting("SETS").Split(new Char[] { ',' }))
            {
                VerifyPath(set + "_XSD_PATH");
                VerifyPath(set + "_ABSTRACTXSD_PATH");
                VerifyPath(set + "_ENUMVAL_PATH");
                VerifyPath(set + "_ENUMVALPRODML_PATH");
                VerifyPath(set + "_WSDL");
            }
        }

        private static void VerifyPath(string settingName)
        {
            string value = VerifySetting(settingName);

            if (!String.IsNullOrEmpty(value) && !Directory.Exists(value) && !File.Exists(value))
            {
                String message = String.Format("Path '{0}' defined by setting '{1}' in app.config does not exist. Please edit your app.config file.", value, settingName);
                MessageBox.Show(message, "BUILD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(message);
            }
        }

        private static string VerifySetting(string settingName)
        {
            string value = GetAppSetting(settingName);

            if (value == null)
            {
                String message = String.Format("Setting '{0}' not defined in app.config. Please edit your app.config file.", settingName);
                MessageBox.Show(message, "BUILD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(message);
            }
            return value;
        }

        /// <summary>
        /// Retrieves a settings value from app.config
        /// </summary>
        /// <param name="key">The key to read</param>
        /// <returns>The value of the setting</returns>
        public static string GetAppSetting(string key)
        {
            string value = ConfigurationManager.AppSettings[key];

            if (value != null)
            {
                string pattern = "{(.*?)}";

                while (Regex.IsMatch(value, pattern))
                {
                    GroupCollection groups = Regex.Matches(value, pattern)[0].Groups;
                    value = value.Replace(groups[0].Value, ConfigurationManager.AppSettings[groups[1].Value]);
                }
            }

            return value;
        }

        /// <summary>
        /// This method passes all .xsd schema files to xsd.exe for creation of the base classes
        /// </summary>
        /// <param name="setName">Set name to process as definied in app.config</param>
        private static void ProcessEnergisticsSchemas(string setName)
        {
            string targetFolder = GetAppSetting("ENERGY_ML_GENERATOR_PROJ_PATH") + @"\" + setName;
            string sourceFolder = GetAppSetting(setName + "_XSD_PATH");
            string nameSpace = "Energistics.Generator." + setName;
            string enumList = GetAppSetting(setName + "_ENUMVAL_PATH");
            string enumProdList = GetAppSetting(setName + "_ENUMVALPRODML_PATH");
            string abstractXsd = GetAppSetting(setName + "_ABSTRACTXSD_PATH") + @"\sub_abstractSubstitutionGroup.xsd";
            string wsdlPath = GetAppSetting(setName + "_WSDL");
        
            if (Directory.Exists(targetFolder) && Directory.Exists(sourceFolder))
            {

                string targetXmlFile = targetFolder + @"\out2.xml";                                                
                string newTypeCatalog = targetFolder + @"\new_typ_catalog.xsd";
                string newTypeCatalogProdml = targetFolder + @"\typ_catalogProdml.xsd";
                


                using (StreamWriter sw = new StreamWriter(targetXmlFile))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    sw.WriteLine("<xsd xmlns='http://microsoft.com/dotnet/tools/xsd/'>");
                    sw.WriteLine("  <generateClasses language='CS' namespace='" + nameSpace + "'>");
                    if (!String.IsNullOrEmpty(abstractXsd) && File.Exists(abstractXsd))
                    {
                        sw.WriteLine("    <schema>" + abstractXsd + "</schema>");
                    }

                    ProcessEnumValuesXml(sourceFolder + @"\typ_catalog.xsd", newTypeCatalog, enumList, sw);
                    ProcessEnumValuesXml(sourceFolder + @"\typ_catalogProdml.xsd", newTypeCatalogProdml, enumProdList, sw);

                    foreach (string f in Directory.GetFiles(wsdlPath, "obj*.xsd", SearchOption.AllDirectories))
                    {
                        sw.WriteLine("    <schema>" + f + "</schema>");
                    }

                    foreach (string f in Directory.GetFiles(sourceFolder, "obj*.xsd", SearchOption.TopDirectoryOnly))
                    {
                        if (!f.Contains("obj_coordinateReferenceSystem.xsd"))
                        {
                            sw.WriteLine("    <schema>" + f + "</schema>");
                        }
                    }

                    sw.WriteLine("  </generateClasses>");
                    sw.WriteLine("</xsd>");
                }



                using (Process p = new Process())
                {
                    p.StartInfo.FileName = GetAppSetting("MS_SDK") + @"\xsd.exe";
                    p.StartInfo.Arguments = String.Format("/parameters:\"{0}\" /out:\"{1}\"", targetXmlFile, targetFolder);
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.UseShellExecute = false;
                    p.Start();


                    string output = p.StandardOutput.ReadToEnd();
                    string error = p.StandardError.ReadToEnd();

                    p.WaitForExit();
                    if (!String.IsNullOrEmpty(error))
                    {
                        Debugger.Break();
                    }

                    foreach (Match m in Regex.Matches(output, @"Writing file '(" + targetFolder.Replace(@"\", @"\\") + ".*?)'."))
                    {
                        string sourceFile = m.Groups[1].Value;
                        string targetCSFile = String.Format(@"{0}\DataObject.cs", targetFolder);

                        if (File.Exists(sourceFile))
                        {
                            if (File.Exists(targetCSFile))
                            {
                                File.Delete(targetCSFile);
                            }
                            File.Move(sourceFile, targetCSFile);
                            File.Delete(targetXmlFile);
                            File.Delete(newTypeCatalog);
                            if (File.Exists(newTypeCatalogProdml))
                            {
                                File.Delete(newTypeCatalogProdml);
                            }
                        }

                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Parses enumValues.xml and inserts the values into typ_catalog.xsd
        /// </summary>
        /// <param name="typeCatalog">Original typ_catalog filename</param>
        /// <param name="newTypeCatalog">New (temporary) typ_catalog filename</param>
        /// <param name="enumList">Filename of EnumValues.xml</param>
        /// <param name="sw">StreamWriter to write results to</param>
        private static void ProcessEnumValuesXml(string typeCatalog, string newTypeCatalog, string enumList, StreamWriter sw)
        {
            if (File.Exists(typeCatalog))
            {
                string contents = File.ReadAllText(typeCatalog);

                string restrictString = "<xsd:restriction base=\"witsml:abstractTypeEnum\">";
                if (!contents.Contains(restrictString))
                {
                    restrictString = restrictString.Replace("witsml", "prodml");
                }

                contents = contents.Replace(restrictString.Substring(0, restrictString.Length - 1) + "/>", restrictString + "\n\t\t</xsd:restriction>");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(enumList);

                XmlNodeList nodes = xmlDoc.GetElementsByTagName("enumList");
                foreach (XmlNode node in nodes)
                {
                    string name = node["name"].InnerText;

                    StringBuilder restriction = new StringBuilder();
                    foreach (XmlNode attr in node.ChildNodes)
                    {
                        if (attr.Name == "value")
                        {
                            string valName = attr["name"].InnerText;
                            string valDesc = (attr["description"] != null) ? attr["description"].InnerText : String.Empty;
                            valDesc = valDesc.Replace("&", "&amp;");
                            valDesc = valDesc.Replace("<", "&lt;");
                            valDesc = valDesc.Replace(">", "&gt;");

                            restriction.AppendLine(String.Format("\t\t\t<xsd:enumeration value=\"{0}\">", valName));
                            restriction.AppendLine("\t\t\t\t<xsd:annotation>");
                            restriction.AppendLine(String.Format("\t\t\t\t\t<xsd:documentation>{0}</xsd:documentation>", valDesc));
                            restriction.AppendLine("\t\t\t\t</xsd:annotation>");
                            restriction.AppendLine("\t\t\t</xsd:enumeration>");
                        }
                    }

                    int simpleTypeLoc = contents.IndexOf(String.Format("<xsd:simpleType name=\"{0}\"", name));
                    int locRestrictString = contents.IndexOf(restrictString, simpleTypeLoc);
                    contents = contents.Insert(locRestrictString + restrictString.Length + 2, restriction.ToString());

                }

                File.WriteAllText(newTypeCatalog, contents);

                sw.WriteLine("    <schema>" + newTypeCatalog + "</schema>");
            }
        }
    }
}
