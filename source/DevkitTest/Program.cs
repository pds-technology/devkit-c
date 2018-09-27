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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Reflection;
using System.Runtime.Remoting;
using Energistics.DataAccess.COMPLETION100;
using Energistics.DataAccess.WITSML131;
using Energistics.DataAccess.WITSML141;
using Energistics.DataAccess.PRODML122;
using Energistics.DataAccess.PRODML131; 
using Energistics.DataAccess;
using Energistics.DataAccess.PRODML122.PROD_GenericDataAccess;
namespace DevkitTest
{
    class Program
    {
        static Boolean successs = true;
        static List<String> failureList = new List<string>();



        private static void testWITSMLWebService()
        {
            string uid = "TestUID_1";
            WITSMLWebServiceConnection webconn = new WITSMLWebServiceConnection("http://localhost:56669/WITSML_DataService.svc", WMLSVersion.WITSML141);

            Console.WriteLine("test WMLS_GetVersion...");
            String version = webconn.GetVersion();
            if (version.CompareTo("WITSML1.4.1") == 0)
            {
                Console.WriteLine("successs");
            }
            else
                Console.WriteLine("failure");


            Console.WriteLine("test WMLS_GetCap...");
            Energistics.DataAccess.WITSML141.CapServers cap = webconn.GetCap<Energistics.DataAccess.WITSML141.CapServers>();
            if (cap.CapServer.ApiVers.CompareTo("WITSML1.4.1") == 0)
            {
                Console.WriteLine("successs");
            }
            else
                Console.WriteLine("failure");

            try
            {
                Console.WriteLine("test WMLS_AddtoStore...");
                Energistics.DataAccess.WITSML141.Well well = new Energistics.DataAccess.WITSML141.Well();
                well.Name = "well1";
                well.Uid = uid;

                webconn.Write<Energistics.DataAccess.WITSML141.Well>(well);

                Console.WriteLine("test WMLS_GetFromStore...");
                webconn.Read<Energistics.DataAccess.WITSML141.Well>(well);

                Console.WriteLine("test WMLS_UpdateInStore...");
                webconn.Update<Energistics.DataAccess.WITSML141.Well>(well);

                Console.WriteLine("test WMLS_DeleteFromStore...");
                webconn.Delete<Energistics.DataAccess.WITSML141.Well>(well);

                Console.WriteLine("successs!");
            }
            catch (Exception)
            {
                Console.WriteLine("failure!");
            }

        }

        static void Main(string[] args)
        {
            String product = "";
            String assemblyName = "Energistics.DataAccess"; 
           // if webservice is up, can use this line to test the webservice
            //Console.WriteLine("Test the WITSML WebServiceAPI ... ");
            //testWITSMLWebService();
         
            //Console.WriteLine("Test the PRODML WebServiceAPI ... ");
            //testProdmlWebService();


            product = "PRODML_v1.3";
            assemblyName = "Energistics.DataAccess";
            testDemoFile(assemblyName, "Energistics.DataAccess.PRODML131", product);

            //1. test the completion 1.0
            product = "Completion_v1.0";
            testDemoFile(assemblyName, "Energistics.DataAccess.COMPLETION100", product);


            product = "WITSML_v1.3.1.1";
            testDemoFile(assemblyName, "Energistics.DataAccess.WITSML131", product);


            product = "WITSML_v1.4.1.1";
            testDemoFile(assemblyName, "Energistics.DataAccess.WITSML141", product);


            product = "PRODML_v1.2.2";
            testDemoFile(assemblyName, "Energistics.DataAccess.PRODML122", product);
     
           

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

        }


        static void testDemoFile(String assemblyName, String className, String product)
        {
            Console.WriteLine("test the class {0}", className);
            // load all the demo xml. 
            String key = "demoFilePath";
            string dir = ConfigurationManager.AppSettings[key];
            String path = dir + "\\" + product;
            if (!Directory.Exists(path))
            {
                Console.WriteLine("{0} doesn't exist", path);
                return;
            }
            //read all validate xml to object.
            foreach (string f in Directory.GetFiles(path, "*.xml", SearchOption.TopDirectoryOnly))
            {
                StreamReader reader = new StreamReader(f);
                try
                {

                    //get the name from the string, required the name is same as the object.
                    Console.WriteLine("process the file {0}", f);
                    int startp = f.LastIndexOf("\\") + "\\".Length;
                    int length = f.IndexOf(".xml") - startp;
                    String objname = f.Substring(startp, length).Replace("obj_", "");
                    // create the instance from the name.
                    ObjectHandle demoObject = createInstance(assemblyName, className, objname);
                    if (demoObject == null)
                    {
                        successs = false;
                        failureList.Add("cann't found the class " + f);
                        continue;
                    }

                    // test the deserialize 
                    String xmlstr = reader.ReadToEnd();
                    reader.Close(); 
                    String xmloutput = ConverterOutput(demoObject.Unwrap().GetType(), xmlstr);
                   if( ValidXmlDoc(new StringReader(xmloutput), getNameSpace(demoObject.Unwrap().GetType().Namespace), getURI(demoObject.Unwrap().GetType().Namespace, objname)))
                   {
                        Console.WriteLine("validate the xml input successfully!");
                    }
                    else
                    {
                        Console.WriteLine("validate the xml input failed!");
                    } 
                    Console.WriteLine(xmloutput);

                }
                catch (Exception e)
                {
                    successs = false;
                    failureList.Add(f + " " + e.Message);
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }

            }

        }

        static void testWitsmlObject()
        {
            Energistics.DataAccess.WITSML141.WellList wells = new Energistics.DataAccess.WITSML141.WellList();
            Energistics.DataAccess.WITSML141.Well well = new Energistics.DataAccess.WITSML141.Well{ Name="well", TimeZone="-06:00", StatusWell= Energistics.DataAccess.WITSML141.ReferenceData.WellStatus.abandoned};
            wells.Well = new List<Energistics.DataAccess.WITSML141.Well>();
            wells.Well.Add(well);
            String xml = EnergisticsConverter.ObjectToXml(wells);
            if (ValidXmlDoc(new StringReader(xml), "WITSML1.4.1.1", "http://www.witsml.org/schemas/1series"))
            {
                Console.WriteLine("validate the xml input successfully!");
            }
            else
            {
                Console.WriteLine("validate the xml input failed!");
            }
            Console.WriteLine(xml);
        }

        static void testProdmlWebService()
        {
            string uid = "TestUID_1";
            Console.WriteLine("test DeleteData...");
            PRODMLWebServiceConnection webconn = new PRODMLWebServiceConnection("http://localhost:8080/Prodml_DataAccessService.svc");
            String[] d = new String[1];
            d[0] = uid;
            DeleteDataResult result = webconn.DeleteData(d);
            if (result.Count == 999)
                Console.WriteLine("deleteData successful!");
            else
                Console.WriteLine("deleteData executed but wrong return!");

            Console.WriteLine("test GetCapabilities...");
            GenericDataAccessCapabilities cap = webconn.GetCapabilities();
            if (cap.Properties[0].Value.CompareTo("PRODML1.2.2") == 0)
                Console.WriteLine("GetCapabilities successful!");
            else
                Console.WriteLine("GetCapabilities executed but wrong return!");

            Console.WriteLine("test GetData...");
            GetDataQuery query = new GetDataQuery();
            query.Uid = new String[1];
            query.Uid[0] = uid;
            Energistics.DataAccess.PRODML122.AbstractObject obj = webconn.GetData(query);
            if (obj is Energistics.DataAccess.PRODML122.FluidAnalysisList)
            {

                Console.WriteLine("GetData successful!");
            }
            else
                Console.WriteLine("GetData executed but wrong return!");


            Console.WriteLine("test PutData...");
            NameValuePair[] options = new NameValuePair[1];
            options[0] = new NameValuePair();
            options[0].Name = "OPTION_0";
            options[0].Value = "1";
            Energistics.DataAccess.PRODML122.FluidAnalysis fa = new Energistics.DataAccess.PRODML122.FluidAnalysis();
            fa.AnalysisCompany = "Energistics";
            fa.Uid = uid;
            Energistics.DataAccess.PRODML122.FluidAnalysisList falist = new Energistics.DataAccess.PRODML122.FluidAnalysisList();
            falist.FluidAnalysis = new List<Energistics.DataAccess.PRODML122.FluidAnalysis>();
            falist.FluidAnalysis.Add(fa);

            PutDataResult[] res = webconn.PutData((Energistics.DataAccess.PRODML122.AbstractObject)falist, options);
            if (res != null)
            {
                if (res[0].SuppMsg.CompareTo("Success!") == 0)
                {
                    Console.WriteLine("PutData successful!");
                }
                else
                    Console.WriteLine("PutData executed but wrong return!");
            }
        }

        static ObjectHandle createInstance(String assemblyName, String className, String objname)
        {
            if (objname.StartsWith("wb"))
            {
                objname = objname.Replace("wb", "Wellbore");
            }
            String objectListname = objname + "List";
            ObjectHandle demoObject = null;
                try
                {
                    //WellList
                    String name = className + "." + objectListname.Substring(0, 1).ToUpper() + objectListname.Substring(1, objectListname.Length - 1);

                    demoObject = Activator.CreateInstance(assemblyName, name);   
                    
                }
                catch(Exception )
                {
                    //wellList
                    String name = className + "." + objectListname;
                    try
                    {
                        demoObject = Activator.CreateInstance(assemblyName, name);
                    }
                    catch(Exception)
                    {
                        try // Well
                        { 
                            name = className + "." + objname.Substring(0, 1).ToUpper() + objname.Substring(1, objname.Length - 1);
                            demoObject = Activator.CreateInstance(assemblyName, name);   
                        }
                        catch (Exception)
                        {
                            try //well
                            {
                                name = className + "." + objname;
                                demoObject = Activator.CreateInstance(assemblyName, name);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Can't find the class for {0}", objname);
                                return null;
                            }
                        }
                    }
                }
                return demoObject;
        }

        private static String ConverterOutput(Type type, string xmlstr)
        {
            if (type.FullName.Contains("COMPLETION100"))
            {
                return converterCompletion(type, xmlstr);
            }
            if (type.FullName.Contains("PRODML122"))
            {
                return converterProdml122(type, xmlstr);
            }

            if (type.FullName.Contains("PRODML131"))
            {

                return converterProdml131(type, xmlstr);
            }
            if (type.FullName.Contains("WITSML131"))
            {
                return converterWITSML1311(type, xmlstr);
            }
            if (type.FullName.Contains("WITSML141"))
            {
                return converterWITSML1411(type, xmlstr);
            }
          
            return "";
        }

      
        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }
        static public bool ValidXmlDoc(StringReader xml,
              string schemaNamespace, string schemaUri)
        {
            // Continue?
            if (xml == null || schemaNamespace == null || schemaUri == null)
            {
                return false;
            }

            Boolean isValidXml = true;
            XmlValidatingReader vr;
            XmlTextReader tr;
            XmlSchemaCollection schemaCol = new XmlSchemaCollection();
            schemaCol.Add(schemaNamespace, schemaUri);

            try
            {
                // Read the xml.
                tr = new XmlTextReader(xml);
                // Create the validator.
                vr = new XmlValidatingReader(tr);
                // Set the validation tyep.
                vr.ValidationType = ValidationType.Auto;
                // Add the schema.
                if (schemaCol != null)
                {
                    vr.Schemas.Add(schemaCol);
                }
                // Read the xml schema.
                while (vr.Read())
                {
                }

                vr.Close();

                return isValidXml;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                // Clean up...
                vr = null;
                tr = null;
            }
        }

        static String getNameSpace(String name)
        {
             if(name.Contains("PRODML122")|| (name.Contains("PRODML131")))
            {
                return "http://www.prodml.org/schemas/1series";
            }
            
            if(name.Contains("WITSML131"))
            {
                return "http://www.witsml.org/schemas/131";
            }
            if (name.Contains("WITSML141")||name.Contains("COMPLETION100"))
            {
                return "http://www.witsml.org/schemas/1series";
            }

            if (name.Contains("RESQML11"))
            {
                return "http://www.resqml.org/schemas/1series";
            }
            if (name.Contains("RESQML20"))
            {
                return "http://www.energistics.org/energyml/data/resqmlv2";
            }
            return "";
        }
        


        static String getURI(String name, String objName)
        {

            String schemaFilePath = ConfigurationManager.AppSettings["schemaFilePath"];
            name = name.ToUpper().Trim();
            if(name.Contains("PRODML122"))
            {
                schemaFilePath += "\\prodML_v1.2.2"+"\\prodml_v1.2.2_data\\xsd_schemas\\";
            }
            if (name.Contains("PRODML131"))
            {
                schemaFilePath += "\\prodML_v1.3" + "\\prodml_v1.3_data\\xsd_schemas\\";
            }
            if(name.Contains("WITSML131"))
            {
                schemaFilePath += "\\Witsml_v1.3.1.1\\";
            }
            if (name.Contains("WITSML141"))
            {
                schemaFilePath += "\\Witsml_v1.4.1.1" + "\\witsml_v1.4.1.1_data\\xsd_schemas\\";
            }
            if(name.Contains("COMPLETION100"))
            {
                schemaFilePath += "\\Completions_v1.0"+ "\\completions_v1.0\\xsd_schemas\\";
            }
            if(name.Contains("RESQML11"))
            {
                schemaFilePath += "\\Resqml_v1.1\\resqml_v1.1.0_data\\xsd_schemas\\";
            }
            if (name.Contains("RESQML20"))
            {
                schemaFilePath += "\\Resqml_v2.0\\energyml\\data\\resqmlv2\\v2.0\\xsd_schemas\\";
            }
            return schemaFilePath +"obj_"+ objName + ".xsd";
        }

        private static String converterCompletion(Type type, string xmlstr)
        {
                String xmloutput = "";   
                if (type == typeof(Energistics.DataAccess.COMPLETION100.DownholeComponentList))
                {
                    Energistics.DataAccess.COMPLETION100.DownholeComponentList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.COMPLETION100.DownholeComponentList>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }

                if (type == typeof(Energistics.DataAccess.COMPLETION100.WellboreCompletionList))
                {
                    Energistics.DataAccess.COMPLETION100.WellboreCompletionList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.COMPLETION100.WellboreCompletionList>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.COMPLETION100.WellCMLedgerList))
                {
                    Energistics.DataAccess.COMPLETION100.WellCMLedgerList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.COMPLETION100.WellCMLedgerList>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.COMPLETION100.WellCompletionList))
                {
                    Energistics.DataAccess.COMPLETION100.WellCompletionList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.COMPLETION100.WellCompletionList>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                return xmloutput;
        }

        private static String converterProdml122(Type type, string xmlstr)
        {
            String xmloutput = "";

            if (type == typeof(Energistics.DataAccess.PRODML122.DtsInstalledSystemList))
            {
                Energistics.DataAccess.PRODML122.DtsInstalledSystemList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.DtsInstalledSystemList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.PRODML122.DtsMeasurementList))
            {
                Energistics.DataAccess.PRODML122.DtsMeasurementList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.DtsMeasurementList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.FluidAnalysisList))
            {
                Energistics.DataAccess.PRODML122.FluidAnalysisList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.FluidAnalysisList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.FluidAnalysisResultList))
            {
                Energistics.DataAccess.PRODML122.FluidAnalysisResultList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.FluidAnalysisResultList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.FluidSampleList))
            {
                Energistics.DataAccess.PRODML122.FluidSampleList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.FluidSampleList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.ProductFlowModelList))
            {
                Energistics.DataAccess.PRODML122.ProductFlowModelList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.ProductFlowModelList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.ProductionOperationList))
            {
                Energistics.DataAccess.PRODML122.ProductionOperationList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.ProductionOperationList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.ProductVolumeList))
            {
                Energistics.DataAccess.PRODML122.ProductVolumeList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.ProductVolumeList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.Report))
            {
                Energistics.DataAccess.PRODML122.Report obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.Report>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.TimeSeriesDataList))
            {
                Energistics.DataAccess.PRODML122.TimeSeriesDataList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.TimeSeriesDataList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.TimeSeriesStatisticList))
            {
                Energistics.DataAccess.PRODML122.TimeSeriesStatisticList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.TimeSeriesStatisticList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.WftRunList))
            {
                Energistics.DataAccess.PRODML122.WftRunList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.WftRunList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML122.WellTestList))
            {
                Energistics.DataAccess.PRODML122.WellTestList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML122.WellTestList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            return xmloutput;
        }

        private static String converterProdml131(Type type, string xmlstr)
        {
            String xmloutput = "";


            if (type == typeof(Energistics.DataAccess.PRODML131.DtsInstalledSystemList))
            {
                Energistics.DataAccess.PRODML131.DtsInstalledSystemList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.DtsInstalledSystemList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.DtsMeasurementList))
            {
                Energistics.DataAccess.PRODML131.DtsMeasurementList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.DtsMeasurementList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.FluidAnalysisList))
            {
                Energistics.DataAccess.PRODML131.FluidAnalysisList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.FluidAnalysisList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.FluidAnalysisResultList))
            {
                Energistics.DataAccess.PRODML131.FluidAnalysisResultList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.FluidAnalysisResultList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.FluidSampleList))
            {
                Energistics.DataAccess.PRODML131.FluidSampleList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.FluidSampleList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.ProductFlowModelList))
            {
                Energistics.DataAccess.PRODML131.ProductFlowModelList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.ProductFlowModelList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.ProductionOperationList))
            {
                Energistics.DataAccess.PRODML131.ProductionOperationList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.ProductionOperationList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.ProductVolumeList))
            {
                Energistics.DataAccess.PRODML131.ProductVolumeList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.ProductVolumeList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.Report))
            {
                Energistics.DataAccess.PRODML131.Report obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.Report>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.TimeSeriesDataList))
            {
                Energistics.DataAccess.PRODML131.TimeSeriesDataList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.TimeSeriesDataList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.TimeSeriesStatisticList))
            {
                Energistics.DataAccess.PRODML131.TimeSeriesStatisticList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.TimeSeriesStatisticList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.WftRunList))
            {
                Energistics.DataAccess.PRODML131.WftRunList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.WftRunList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.WellTestList))
            {
                Energistics.DataAccess.PRODML131.WellTestList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.WellTestList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.2
            if (type == typeof(Energistics.DataAccess.PRODML131.FiberOpticalPathList))
            {
                Energistics.DataAccess.PRODML131.FiberOpticalPathList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.FiberOpticalPathList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML131.DtsInstrumentBoxeList))
            {
                Energistics.DataAccess.PRODML131.DtsInstrumentBoxeList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML131.DtsInstrumentBoxeList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            return xmloutput;
        }

        private static String converterWITSML1411(Type type, string xmlstr)
        {

            String xmloutput = "";
            if (type == typeof(Energistics.DataAccess.WITSML141.AttachmentList))
            {
                Energistics.DataAccess.WITSML141.AttachmentList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.AttachmentList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.ChangeLogList))
            {
                Energistics.DataAccess.WITSML141.ChangeLogList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.ChangeLogList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.DrillReportList))
            {
                Energistics.DataAccess.WITSML141.DrillReportList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.DrillReportList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.ObjectGroupList))
            {
                Energistics.DataAccess.WITSML141.ObjectGroupList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.ObjectGroupList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.StimJobList))
            {
                Energistics.DataAccess.WITSML141.StimJobList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.StimJobList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.ToolErrorModelList))
            {
                Energistics.DataAccess.WITSML141.ToolErrorModelList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.ToolErrorModelList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.ToolErrorTermSetList))
            {
                Energistics.DataAccess.WITSML141.ToolErrorTermSetList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.ToolErrorTermSetList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.OpsReportList))
            {
                Energistics.DataAccess.WITSML141.OpsReportList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.OpsReportList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.BhaRunList))
            {
                Energistics.DataAccess.WITSML141.BhaRunList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.BhaRunList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.CementJobList))
            {
                Energistics.DataAccess.WITSML141.CementJobList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.CementJobList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.ConvCoreList))
            {
                Energistics.DataAccess.WITSML141.ConvCoreList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.ConvCoreList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.FluidsReportList))
            {
                Energistics.DataAccess.WITSML141.FluidsReportList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.FluidsReportList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.FormationMarkerList))
            {
                Energistics.DataAccess.WITSML141.FormationMarkerList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.FormationMarkerList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.LogList))
            {
                Energistics.DataAccess.WITSML141.LogList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.LogList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.MessageList))
            {
                Energistics.DataAccess.WITSML141.MessageList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.MessageList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.MudLogList))
            {
                Energistics.DataAccess.WITSML141.MudLogList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.MudLogList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
          
            if (type == typeof(Energistics.DataAccess.WITSML141.RigList))
            {
                Energistics.DataAccess.WITSML141.RigList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.RigList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.RiskList))
            {
                Energistics.DataAccess.WITSML141.RiskList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.RiskList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.2
            if (type == typeof(Energistics.DataAccess.WITSML141.SidewallCoreList))
            {
                Energistics.DataAccess.WITSML141.SidewallCoreList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.SidewallCoreList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            } 
            if (type == typeof(Energistics.DataAccess.WITSML141.SurveyProgramList))
            {
                Energistics.DataAccess.WITSML141.SurveyProgramList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.SurveyProgramList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.TargetList))
            {
                Energistics.DataAccess.WITSML141.TargetList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.TargetList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.TrajectoryList))
            {
                Energistics.DataAccess.WITSML141.TrajectoryList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.TrajectoryList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            
            if (type == typeof(Energistics.DataAccess.WITSML141.TubularList))
            {
                Energistics.DataAccess.WITSML141.TubularList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.TubularList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.WellboreGeometryList))
            {
                Energistics.DataAccess.WITSML141.WellboreGeometryList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.WellboreGeometryList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.WellList))
            {
                Energistics.DataAccess.WITSML141.WellList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.WellList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.2
            if (type == typeof(Energistics.DataAccess.WITSML141.WellboreList))
            {
                Energistics.DataAccess.WITSML141.WellboreList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.WellboreList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
          
            return xmloutput;
        }

        private static String converterWITSML1311(Type type, string xmlstr)
        {
            String xmloutput = "";
            
            if (type == typeof(Energistics.DataAccess.WITSML131.OpsReportList))
            {
                Energistics.DataAccess.WITSML131.OpsReportList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.OpsReportList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.DtsInstalledSystemList))
            {
                Energistics.DataAccess.WITSML131.DtsInstalledSystemList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.DtsInstalledSystemList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.DtsMeasurementList))
            {
                Energistics.DataAccess.WITSML131.DtsMeasurementList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.DtsMeasurementList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.BhaRunList))
            {
                Energistics.DataAccess.WITSML131.BhaRunList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.BhaRunList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.CementJobList))
            {
                Energistics.DataAccess.WITSML131.CementJobList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.CementJobList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.ConvCoreList))
            {
                Energistics.DataAccess.WITSML131.ConvCoreList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.ConvCoreList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.FluidsReportList))
            {
                Energistics.DataAccess.WITSML131.FluidsReportList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.FluidsReportList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.FormationMarkerList))
            {
                Energistics.DataAccess.WITSML131.FormationMarkerList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.FormationMarkerList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.LogList))
            {
                Energistics.DataAccess.WITSML131.LogList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.LogList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.MessageList))
            {
                Energistics.DataAccess.WITSML131.MessageList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.MessageList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.MudLogList))
            {
                Energistics.DataAccess.WITSML131.MudLogList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.MudLogList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.RealtimeList))
            {
                Energistics.DataAccess.WITSML131.RealtimeList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.RealtimeList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.RigList))
            {
                Energistics.DataAccess.WITSML131.RigList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.RigList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.RiskList))
            {
                Energistics.DataAccess.WITSML131.RiskList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.RiskList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.2
            if (type == typeof(Energistics.DataAccess.WITSML131.SidewallCoreList))
            {
                Energistics.DataAccess.WITSML131.SidewallCoreList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.SidewallCoreList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.SurveyProgramList))
            {
                Energistics.DataAccess.WITSML131.SurveyProgramList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.SurveyProgramList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.TargetList))
            {
                Energistics.DataAccess.WITSML131.TargetList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.TargetList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.TrajectoryList))
            {
                Energistics.DataAccess.WITSML131.TrajectoryList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.TrajectoryList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.2
            if (type == typeof(Energistics.DataAccess.WITSML131.TrajectoryStationList))
            {
                Energistics.DataAccess.WITSML131.TrajectoryStationList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.TrajectoryStationList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.TubularList))
            {
                Energistics.DataAccess.WITSML131.TubularList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.TubularList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.WellboreGeometryList))
            {
                Energistics.DataAccess.WITSML131.WellboreGeometryList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.WellboreGeometryList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.WellList))
            {
                Energistics.DataAccess.WITSML131.WellList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.WellList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.2
            if (type == typeof(Energistics.DataAccess.WITSML131.WellboreList))
            {
                Energistics.DataAccess.WITSML131.WellboreList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.WellboreList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML131.WellLogList))
            {
                Energistics.DataAccess.WITSML131.WellLogList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML131.WellLogList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            return xmloutput;
        }


        static Boolean ComparationOutput(String outputPrev, String xmloutput)
        {
            Boolean result = true;
            // format the string, remove \r\n\t "prodml:" and space. 
            outputPrev = outputPrev.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("prodml:", "").Replace("witsml:", "").Replace(" ", "").Replace(".000", "").Replace(".00", "");
            xmloutput = xmloutput.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("prodml:", "").Replace("witsml:", "").Replace(" ", "").Replace(".000", "").Replace(".00", ""); ;

            //need to remove the comment
            while (outputPrev.Contains("<!--"))
            {
                int stp = outputPrev.IndexOf("<!--");
                int endp = outputPrev.IndexOf("-->", stp);
                outputPrev = outputPrev.Remove(stp, endp - stp + 3);
            }
            int startP = outputPrev.IndexOf("name");
            String FormatStr = outputPrev;
            if (startP > 0)
            {
                FormatStr = outputPrev.Substring(startP, outputPrev.Length - startP);
            }
            String FormatStr2 = xmloutput;
            int startP2 = xmloutput.IndexOf("name");
            if (startP2 > 0)
                FormatStr2 = xmloutput.Substring(startP2, xmloutput.Length - startP2);
            // there is Deprecated item existing in evaluation xml, so cause the evaluation not accurate.
            // if (FormatStr2.Length < FormatStr.Length)
            //   result = false;
            //if (((Math.Abs(FormatStr.Length - FormatStr2.Length) / (float)FormatStr.Length) > 0.02) &&(FormatStr2.Length < FormatStr.Length))
            //        result = false;
            return result;
        }



    }
}
