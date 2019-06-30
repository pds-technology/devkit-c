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
                if (setName == "WITSML131" || setName == "WITSML141" || setName == "PRODML122" ||setName=="RESQML201")
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
                    Console.Out.WriteLine("Invalid set name '{0}'. Must be one of WITSML131, WITSML141, or PRODML122.", nameSpace);
                }
            }
            else
            {
                Console.Out.WriteLine("EnumValuesExtensionGenerator - Generates a extension class for a custom enumValues.xml file");
                Console.Out.WriteLine("");
                Console.Out.WriteLine("EnumValuesExtensionGenerator [enumValues filename] [namespace] [WITSML131 or WITSML141 or PRODML122]");
            }
        }
    }
}
