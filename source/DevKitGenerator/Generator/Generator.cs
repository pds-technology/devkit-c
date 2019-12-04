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
//.             Completion Data schema specification, Version 1.0
// •             WITSML Data Schema Specifications, Version 1.4.1.1 
// •             WITSML API Specifications, version 1.4.1.1 
// •             WITSML Data Schema Specifications, Version 1.3.1.1 
// •             WITSML API Specifications, version 1.3.1 
// *             Completion , version 1.0.0
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
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Security.AccessControl;
using System.Configuration;
using System.Linq;

namespace Energistics.Generator
{   
    partial class EnergisticsTextTemplate
    {
        private string mlPath;
        private string mlVersion;
        private List<string> enumClassNames;
        private string versionString;

        public EnergisticsTextTemplate(string mlPath, string mlVersion, List<string> enumClassNames, string versionString)
        {
            this.mlPath = mlPath;
            this.mlVersion = mlVersion;
            this.enumClassNames = enumClassNames;
            this.versionString = versionString;
        }
    }

    class Generator
    {
        private static OptionSet options;

        [STAThread]
        static void Main(string[] args)        
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
                Energistics.SchemaGatherer.SchemaGatherer.VerifyAppConfig();
            }
            catch (Exception)
            {
                return;
            }

            string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string set in Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("SETS").Split(new Char[] { ',' }))
            { 
                GenerateClasses(set, currentPath);
            }
        }

        private static void ShowHelp()
        {
            options.WriteOptionDescriptions(Console.Out);
        }

        private static void GenerateClasses(string setName, string currentPath)
        {
            string mlPath = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_XSD_PATH");
            string targetFilename = String.Format(@"{0}\{1}\GeneratedEnumValues.cs", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName);
            List<string> enumClassNames = new List<string>();
            if (!setName.Contains("ML2"))
            {               
                string csCode = EnumValuesXMLToClass.Convert(Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENUMVAL_PATH"), "Energistics.DataAccess." + setName, enumClassNames, false, null);
                csCode = SchemaGatherer.SchemaGatherer.CleanUpGeneratedText(csCode);

                if (targetFilename.Contains(".cs"))
                {
                    DirectorySecurity securityRules = new DirectorySecurity();
                    String targetPath = targetFilename.Remove(targetFilename.LastIndexOf("\\"));
                    if (!Directory.Exists(targetPath))
                        Directory.CreateDirectory(targetPath);
                }
                File.WriteAllText(targetFilename, csCode);
            }
            if (setName.Contains("PRODML"))
            {
                string prodMLPath = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENUMVALPRODML_PATH");
                if (!String.IsNullOrEmpty(prodMLPath))
                {
                    targetFilename = String.Format(@"{0}\{1}\GeneratedProdmlEnumValues.cs", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName);
                    var text = EnumValuesXMLToClass.Convert(prodMLPath, "Energistics.DataAccess." + setName, enumClassNames, false, null);
                    text = SchemaGatherer.SchemaGatherer.CleanUpGeneratedText(text);
                    File.WriteAllText(targetFilename, text);
                }
            }

            /* HD5 previously was coded in RESQML 100, regards 200 strcuture has changed, and HD5 is not support at this moment */
            if (setName.StartsWith("RESQML100"))
            {
                ResqmlHD5Template resqmlTextTemplate = new ResqmlHD5Template();
                string resmltext = resqmlTextTemplate.TransformText(setName);
                resmltext = SchemaGatherer.SchemaGatherer.CleanUpGeneratedText(resmltext);
                File.WriteAllText(String.Format(@"{0}\{1}\GeneratedResqmlHDF5PartialClasses.cs", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName), resmltext);
            }

            string versionString = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_VERSION_STRING");
            
            EnergisticsTextTemplate textTemplate = new EnergisticsTextTemplate(mlPath, setName, enumClassNames, versionString);
            String contents = textTemplate.TransformText();
            contents = SchemaGatherer.SchemaGatherer.CleanUpGeneratedText(contents);
            String prjPath = String.Format("{0}\\{1}\\", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName);
            if (!Directory.Exists(prjPath)) Directory.CreateDirectory(prjPath);
            File.WriteAllText(String.Format("{0}\\DataObjects.cs", prjPath), contents);

            string wsdlPath = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_WSDL");
            if (!String.IsNullOrEmpty(wsdlPath))
            {
                foreach (string wsdlFile in Directory.GetFiles(wsdlPath, "*.wsdl"))
                {
                    ProcessWSDL(String.Format("\"{0}\" /out:\"{1}\\{2}\" /namespace:Energistics.DataAccess.{2}.{3}", wsdlFile, Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName, Path.GetFileNameWithoutExtension(wsdlFile)), setName);
                }
            }
        }

        private static void ProcessWSDL(string args, string setName)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("MS_SDK") + @"\wsdl.exe";
                p.StartInfo.Arguments = args;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();


                string output = p.StandardOutput.ReadToEnd();
                string error = p.StandardError.ReadToEnd();

                p.WaitForExit();

                if (!String.IsNullOrEmpty(error))
                {
                    if (setName != null)
                    {
                        if (error.Contains("The element 'http://www.energistics.org/schemas/abstract:abstractDataObject' is missing"))
                        {
                            args = args.Replace("/out:", String.Format("\"{0}\\sub_abstractSubstitutionGroup.xsd\" /out:", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ABSTRACTXSD_PATH")));
                            ProcessWSDL(args, null);
                        }
                    }
                }
                else
                {
                    Regex regex = new Regex("Writing file '(.*?PROD_GenericDataAccess.cs)'");
                    if (regex.IsMatch(output))
                    {
                        string filename = regex.Match(output).Groups[1].Value;

                        string prodGDAText = File.ReadAllText(filename);

                        prodGDAText = prodGDAText.Replace("public abstract partial class abstractObject", "public abstract partial class abstractUnusedObject");
                        prodGDAText = prodGDAText.Replace("abstractObject", "AbstractObject");

                        var crlf = Environment.NewLine;
                        var tabs = "        ";
                        prodGDAText = prodGDAText.Replace($";{crlf}{tabs}{crlf}{tabs}public ", $";{crlf}{tabs}{crlf}{tabs}/// <remarks/>{crlf}{tabs}public ");

                        File.WriteAllText(filename, prodGDAText);
                    }
                    foreach (Match m in Regex.Matches(output, @"Writing file '(.*?)'."))
                    {
                        string outputFile = m.Groups[1].Value;
                        SchemaGatherer.SchemaGatherer.CleanUpGeneratedCode(outputFile);
                    }
                }
            }
        }
    }
}
