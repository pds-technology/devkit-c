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
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.Generator
{   
    partial class EnergisticsTextTemplate
    {
        private string mlPath;
        private string mlVersion;
        private List<string> enumClassNames;

        public EnergisticsTextTemplate(string mlPath, string mlVersion, List<string> enumClassNames)
        {
            this.mlPath = mlPath;
            this.mlVersion = mlVersion;
            this.enumClassNames = enumClassNames;
        }
    }

    class Generator
    {
        [STAThread]
        static void Main(string[] args)        
        {
            string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string set in Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("SETS").Split(new Char[] { ',' }))
            {
                GenerateClasses(set, currentPath);
            }
            string sets = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("SETS");
        }

        private static void GenerateClasses(string setName, string currentPath)
        {
            string mlPath = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_XSD_PATH");

            List<string> enumClassNames = new List<string>();
            string targetFilename = String.Format(@"{0}\{1}\GeneratedEnumValues.cs", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName);
            string csCode = EnumValuesXMLToClass.Convert(Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENUMVAL_PATH"), "Energistics.DataAccess." + setName, enumClassNames, false, null);
            File.WriteAllText(targetFilename, csCode);

            string prodMLPath = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_ENUMVALPRODML_PATH");
            if (!String.IsNullOrEmpty(prodMLPath))
            {
                targetFilename = String.Format(@"{0}\{1}\GeneratedProdmlEnumValues.cs", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName);
                File.WriteAllText(targetFilename, EnumValuesXMLToClass.Convert(prodMLPath, "Energistics.DataAccess." + setName, enumClassNames, false, null));
            }

            EnergisticsTextTemplate textTemplate = new EnergisticsTextTemplate(mlPath, setName, enumClassNames);
            String contents = textTemplate.TransformText();
            File.WriteAllText(String.Format("{0}\\{1}\\DataObjects.cs", Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName), contents);

            foreach (string wsdlFile in Directory.GetFiles(Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting(setName + "_WSDL"), "*.wsdl"))
            {
                ProcessWSDL(String.Format("\"{0}\" /out:\"{1}\\{2}\" /namespace:Energistics.DataAccess.{2}.{3}", wsdlFile, Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("ENERGY_ML_DATA_ACCESS_PROJ_PATH"), setName, Path.GetFileNameWithoutExtension(wsdlFile)), setName);
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
            }
        }
    }
}
