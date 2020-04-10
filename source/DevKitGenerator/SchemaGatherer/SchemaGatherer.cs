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

using Mono.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Energistics.SchemaGatherer
{
    public class SchemaGatherer
    {
        private static OptionSet options;

        static int Main(string[] args)
        {
            bool haveRootFolder = false;
            options = new OptionSet()
                .Add("?|help|h", "Displays this help", option => ShowHelp())
                .Add("r=|root-folder=", "The root folder for the schemas.  If not set, the ${{ROOT_FOLDER}} application configuration setting will be used.", option => { ConfigurationManager.AppSettings["ROOT_FOLDER"] = option; haveRootFolder = true; });

            // Hard code default to simplify debugging.
            if (!haveRootFolder && !ConfigurationManager.AppSettings.AllKeys.Contains("ROOT_FOLDER"))
                ConfigurationManager.AppSettings["ROOT_FOLDER"] = @"..\..\..\..\..\";

            try
            {
                options.Parse(args);
            }
            catch (OptionException)
            {
                ShowHelp();
            }

            try
            {
                VerifyAppConfig();
            }
            catch (Exception )
            {
                return 1;
            }

            foreach (string set in GetAppSetting("SETS").Split(','))
            {
                ProcessEnergisticsSchemas(set);
            }

            return 0;
        }

        private static void ShowHelp()
        {
            options.WriteOptionDescriptions(Console.Out);
        }

        public static void VerifyAppConfig()
        {
            VerifySetting("SETS");
            VerifyPath("ROOT_FOLDER");
            VerifyPath("ENERGISTICS_FOLDER");
            VerifyPath("SOLUTION_FOLDER");
            VerifyPath("ENERGY_ML_GENERATOR_PROJ_PATH");
            VerifyPath("MS_SDK");

            foreach (string setname in GetAppSetting("SETS").Split(','))
            {
                
                String set = setname.Trim();
                VerifyPath(set + "_XSD_PATH");
                VerifyPath(set + "_ABSTRACTXSD_PATH");
                
                if (set.Contains("RESQML201"))
                {
                    VerifyPath(set + "_ENUMVAL_PATH");
                }
                else
                {
                    if (!set.Contains("RESQML200"))
                    {
                        VerifyPath(set + "_ENUMVAL_PATH");
                        VerifyPath(set + "_ENUMVALPRODML_PATH");
                    }
                }
                VerifyPath(set + "_WSDL");
                VerifyPath(set + "_ENERGY_ML_DATA_ACCESS_PROJ_PATH");
                VerifySetting(set + "_VERSION_STRING");
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
            else if (!String.IsNullOrEmpty(value))
            {
                ConfigurationManager.AppSettings[settingName] = Path.GetFullPath(value);
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
            string sourceRasterFolder = GetAppSetting(setName + "_RASTERXSD_PATH");
            string sourceCompletionsFolder = GetAppSetting(setName + "_COMPLETIONSXSD_PATH");
            string nameSpace = "Energistics.Generator." + setName;
            string enumList = GetAppSetting(setName + "_ENUMVAL_PATH");
            string enumProdList = "";
            if (setName.Contains("PRODML"))
                enumProdList = GetAppSetting(setName + "_ENUMVALPRODML_PATH");
            string dataSchemaVersion = GetAppSetting(setName + "_VERSION_STRING");

            List<string> dataObjectSchemas = new List<string>();
            List<string> apiSchemas = new List<string>();
            List<string> supportingSchemas = new List<string>();     
            Dictionary<string, string> schemaSubstitutions = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            Dictionary<string, string> namespaceSubstitutions = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
            if (!Directory.Exists(sourceFolder))
            {
                Console.WriteLine("{0} doesn't exist", sourceFolder);
                return;
            }

            GetSchemas(setName, enumList, sourceFolder, dataObjectSchemas, apiSchemas, supportingSchemas, schemaSubstitutions);

            string targetXmlFile = targetFolder + @"\out2.xml";
            string newTypeCatalog = targetFolder + @"\new_typ_catalog.xsd";
            string newTypeCatalogProdml = targetFolder + @"\typ_catalogProdml.xsd";



            using (StreamWriter sw = new StreamWriter(targetXmlFile))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                sw.WriteLine("<xsd xmlns='http://microsoft.com/dotnet/tools/xsd/'>");
                sw.WriteLine("  <generateClasses language='CS' namespace='" + nameSpace + "'>");
                foreach (string schema in supportingSchemas)
                {
                    sw.WriteLine("    <schema>" + schema + "</schema>");
                }

                if (!string.IsNullOrEmpty(sourceRasterFolder))
                {
                    string newRasterTypeCatalog = targetFolder + @"\new_raster_typ_catalog.xsd";
                    ProcessEnumValuesXml(sourceRasterFolder + @"\typ_catalogRaster.xsd", newRasterTypeCatalog, enumList, sw);
                    schemaSubstitutions.Add(newRasterTypeCatalog, sourceRasterFolder + @"\typ_catalogRaster.xsd");
                }
                if (!string.IsNullOrEmpty(sourceCompletionsFolder))
                {
                    string newCompletionsTypeCatalog = targetFolder + @"\new_completions_typ_catalog.xsd";
                    string newEquipmentCatalog = targetFolder + @"\new_cs_equipmentCatalog.xsd";
                    ProcessEnumValuesXml(sourceCompletionsFolder + @"\typ_catalogCompletion.xsd", newCompletionsTypeCatalog, enumList, sw);
                    ProcessEnumValuesXml(sourceCompletionsFolder + @"\cs_equipmentCatalog.xsd", newEquipmentCatalog, enumList, sw);
                    schemaSubstitutions.Add(newCompletionsTypeCatalog, sourceCompletionsFolder + @"\typ_catalogCompletion.xsd");
                    schemaSubstitutions.Add(newEquipmentCatalog, sourceCompletionsFolder + @"\cs_equipmentCatalog.xsd");

                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\attgrp_objectUid.xsd", sourceFolder + @"\attgrp_objectUid.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\attgrp_uid.xsd", sourceFolder + @"\attgrp_uid.xsd");

                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_commonData.xsd", sourceFolder + @"\cs_commonData.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_connection.xsd", sourceFolder + @"\cs_connection.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_customData.xsd", sourceFolder + @"\cs_customData.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_dayCost.xsd", sourceFolder + @"\cs_dayCost.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_documentAudit.xsd", sourceFolder + @"\cs_documentAudit.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_documentEvent.xsd", sourceFolder + @"\cs_documentEvent.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_documentFileCreation.xsd", sourceFolder + @"\cs_documentFileCreation.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_documentInfo.xsd", sourceFolder + @"\cs_documentInfo.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_documentSecurityInfo.xsd", sourceFolder + @"\cs_documentSecurityInfo.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_extensionAny.xsd", sourceFolder + @"\cs_extensionAny.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_extensionNameValue.xsd", sourceFolder + @"\cs_extensionNameValue.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_memberObject.xsd", sourceFolder + @"\cs_memberObject.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\cs_nameTag.xsd", sourceFolder + @"\cs_nameTag.xsd");

                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\typ_baseType.xsd", sourceFolder + @"\typ_baseType.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\typ_catalog.xsd", newTypeCatalog);
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\typ_dataTypes.xsd", sourceFolder + @"\typ_dataTypes.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\typ_measureType.xsd", sourceFolder + @"\typ_measureType.xsd");
                    schemaSubstitutions.Add(sourceCompletionsFolder + @"\typ_quantityClass.xsd", sourceFolder + @"\typ_quantityClass.xsd");

                    if (setName.StartsWith("PRODML"))
                    {
                        namespaceSubstitutions.Add(@"http://www.witsml.org/schemas/1series", @"http://www.prodml.org/schemas/1series");
                    }
                }
                if (!setName.StartsWith("RESQML") && !setName.StartsWith("WITSML2"))
                {
                    ProcessEnumValuesXml(sourceFolder + @"\typ_catalog.xsd", newTypeCatalog, enumList, sw);
                    ProcessEnumValuesXml(sourceFolder + @"\typ_catalogProdml.xsd", newTypeCatalogProdml, enumProdList, sw);
                    schemaSubstitutions.Add(newTypeCatalog, sourceFolder + @"\typ_catalog.xsd");
                    schemaSubstitutions.Add(newTypeCatalogProdml, sourceFolder + @"\typ_catalogProdml.xsd");
                }

                foreach (string schema in apiSchemas)
                {
                    sw.WriteLine("    <schema>" + schema + "</schema>");
                }

                foreach (string schema in dataObjectSchemas)
                {
                    sw.WriteLine("    <schema>" + schema + "</schema>");
                }

                sw.WriteLine("  </generateClasses>");
                sw.WriteLine("</xsd>");

            }

            List<string> dataObjects = dataObjectSchemas.Select(Path.GetFileNameWithoutExtension).ToList();

            // Strip out numbers from the family name
            string standardFamily = Regex.Replace(setName, @"\d", string.Empty);

            // Strip out anything not a digit or a '.'
            dataSchemaVersion = Regex.Replace(dataSchemaVersion, @"[^\d.]", string.Empty);
			
            ValidationExtensions.GenerateDataObjectsWithCodeDom(targetFolder, targetXmlFile, nameSpace, sourceFolder, standardFamily, dataSchemaVersion, dataObjects, schemaSubstitutions, namespaceSubstitutions);
			
            if(File.Exists(targetXmlFile))
                File.Delete(targetXmlFile);
        }

        private static void GetSchemas(string setName, string enumList, string sourceFolder, List<string> dataObjectSchemas, List<string> apiSchemas, List<string> supportingSchemas, Dictionary<string, string> schemaSubstitutions)
        {
            string abstractXsd = GetAppSetting(setName + "_ABSTRACTXSD_PATH") + @"\sub_abstractSubstitutionGroup.xsd";
            string wsdlPath = GetAppSetting(setName + "_WSDL");
            string sourceRasterFolder = GetAppSetting(setName + "_RASTERXSD_PATH");
            string sourceCompletionsFolder = GetAppSetting(setName + "_COMPLETIONSXSD_PATH");

            if (!string.IsNullOrEmpty(abstractXsd) && File.Exists(abstractXsd))
            {
                supportingSchemas.Add(abstractXsd);
            }

            if (setName.StartsWith("RESQML1"))
            {
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_DUBLIN_PATH"), "dcterms.xsd"));
                if (enumList.Length > 0)
                {
                    supportingSchemas.Add(Path.Combine(Path.GetDirectoryName(enumList), "typ_catalog.xsd"));
                    schemaSubstitutions.Add(Path.Combine(Path.GetDirectoryName(enumList), "typ_catalog.xsd"), sourceFolder + @"\typ_catalog.xsd");
                }
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"xlink\1.0.0\xlinks.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"gml\3.2.1\gml.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gmd\gmd.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gco\gco.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gts\gts.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gsr\gsr.xsd"));
            }
            if (setName.Equals("WITSML141"))
            {
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"xlink\1.0.0\xlinks.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"gml\3.2.1\gml.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gmd\gmd.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gco\gco.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gts\gts.xsd"));
                supportingSchemas.Add(Path.Combine(GetAppSetting(setName + "_GML_PATH"), @"iso\19139\20070417\gsr\gsr.xsd"));
            }
            if (setName.Contains("ML2"))
            {
                // we also need to include all xsd file in common v2.
                foreach (string f in Directory.GetFiles(GetAppSetting(setName + "_COMMON_PATH"), "*.xsd", SearchOption.AllDirectories))
                {
                    supportingSchemas.Add(f);
                }

                foreach (string f in Directory.GetFiles(sourceFolder, "*.xsd", SearchOption.TopDirectoryOnly))
                {
                    dataObjectSchemas.Add(f);
                }
            }

            if (!string.IsNullOrEmpty(sourceRasterFolder))
            {
                foreach (string f in Directory.GetFiles(sourceRasterFolder, "obj*.xsd", SearchOption.TopDirectoryOnly))
                {
                    dataObjectSchemas.Add(f);
                }
            }

            if (!string.IsNullOrEmpty(sourceCompletionsFolder))
            {
                foreach (string f in Directory.GetFiles(sourceCompletionsFolder, "obj*.xsd", SearchOption.TopDirectoryOnly))
                {
                    dataObjectSchemas.Add(f);
                }
            }

            if (!string.IsNullOrEmpty(wsdlPath))
            {
                foreach (string f in Directory.GetFiles(wsdlPath, "obj*.xsd", SearchOption.AllDirectories))
                {
                    apiSchemas.Add(f);
                }
            }

            foreach (string f in Directory.GetFiles(sourceFolder, "obj*.xsd", SearchOption.TopDirectoryOnly))
            {
                if (!dataObjectSchemas.Contains(f))
                {
                    dataObjectSchemas.Add(f);
                }
            }
        }

        public static string CleanUpGeneratedText(string text)
        {
            // Normalize line endings
            text = Regex.Replace(text, @"\r?\n", Environment.NewLine);

            // Remove GeneratedCodeAttributes
            text = Regex.Replace(
                text, Environment.NewLine + @".*?System\.CodeDom\.Compiler\.GeneratedCodeAttribute.*?" + Environment.NewLine, Environment.NewLine);

            // Remove Runtime Version auto-generated comments
            text = Regex.Replace(
                text, Environment.NewLine + @".*?//     Runtime Version:.*?" + Environment.NewLine, Environment.NewLine);

            return text;
        }

        public static void CleanUpGeneratedCode(string path)
        {
            string contents = File.ReadAllText(path);

            contents = CleanUpGeneratedText(contents);

            File.WriteAllText(path, contents, Encoding.UTF8);
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
            if (!File.Exists(typeCatalog)) return;

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

                int xsSimpleTypeLoc = contents.IndexOf(String.Format("<xs:simpleType name=\"{0}\"", name));
                int xsdSimpleTypeLoc = contents.IndexOf(String.Format("<xsd:simpleType name=\"{0}\"", name));
                if (xsSimpleTypeLoc >= 0)
                {
                    int locRestrictString = contents.IndexOf(restrictString, xsSimpleTypeLoc);
                    contents = contents.Insert(locRestrictString + restrictString.Length + 2, restriction.ToString());
                }
                if (xsdSimpleTypeLoc >= 0)
                {
                    int locRestrictString = contents.IndexOf(restrictString, xsdSimpleTypeLoc);
                    contents = contents.Insert(locRestrictString + restrictString.Length + 2, restriction.ToString());
                }

            }

            File.WriteAllText(newTypeCatalog, contents);

            sw.WriteLine("    <schema>" + newTypeCatalog + "</schema>");
        }
    }
}
