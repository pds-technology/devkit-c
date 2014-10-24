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
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Energistics.DataAccess.EnumValue;

namespace Energistics.Generator.EnumValuesExtensionGenerator
{
    class EnumValuesExtensionGenerator
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                string fileName = args[0];
                string nameSpace = args[1];
                string setName = args[2];

                // Check to make sure the set name is valud
                if (setName == "WITSML131" || setName == "WITSML141" || setName == "PRODML120" || setName == "PRODML121")
                {
                    // Namespace must start with a capital letter, 
                    // followed by any number of word characters or dots, 
                    // and ending with a word character
                    if (Regex.IsMatch(nameSpace, @"^[A-Z][\w\.]*[\w]$"))
                    {
                        // File must exist
                        if (File.Exists(fileName))
                        {
                            try
                            {
                                string xml = EnumValuesXMLToClass.Convert(fileName, nameSpace, new List<string>(), true, setName);
                                CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
                                CompilerParameters cp = new CompilerParameters();
                                cp.ReferencedAssemblies.Add("Energistics.DataAccess.dll");
                                cp.GenerateInMemory = false;
                                cp.OutputAssembly = nameSpace + ".EnumValueExtensions.dll";

                                CompilerResults result = provider.CompileAssemblyFromSource(cp, xml);

                                if (result.Errors.Count > 0)
                                {
                                    foreach (string s in result.Output)
                                    {
                                        Console.Out.WriteLine(s);
                                    }
                                }
                                else
                                {
                                    Console.Out.WriteLine("Extension class created.");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Out.WriteLine("Unexpected error!");
                                Console.Out.WriteLine("Exception: {0}", e.Message);
                                if (e.InnerException != null)
                                {
                                    Console.Out.WriteLine("Inner Exception: {0}", e.InnerException.Message);
                                }
                            }
                        }
                        else
                        {
                            Console.Out.WriteLine("File '{0}' does not exist.", fileName);
                        }
                    }
                    else
                    {
                        Console.Out.WriteLine("Invalid namespace '{0}'.", nameSpace);
                    }
                }
                else
                {
                    Console.Out.WriteLine("Invalid set name '{0}'. Must be one of WITSML131, WITSML141, PRODML120 or PRODML121.", nameSpace);
                }
            }
            else
            {
                Console.Out.WriteLine("EnumValuesExtensionGenerator - Generates a extension class for a custom enumValues.xml file");
                Console.Out.WriteLine("");
                Console.Out.WriteLine("EnumValuesExtensionGenerator [enumValues filename] [namespace] [WITSML131 or WITSML141 or PRODML120 or PRODML121]");
            }
        }
    }
}
