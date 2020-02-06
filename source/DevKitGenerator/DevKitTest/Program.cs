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
using Energistics.DataAccess.WITSML131;
using Energistics.DataAccess.WITSML141;
using Energistics.DataAccess.PRODML122;
using Energistics.DataAccess.PRODML131; 
using Energistics.DataAccess;
using System.IO.Packaging;
using Energistics.DataAccess.PRODML122.PROD_GenericDataAccess;
using Energistics.DataAccess.WITSML200.ComponentSchemas;
using Energistics.DataAccess.RESQML210;
using Energistics.DataAccess.RESQML200;
using Energistics.DataAccess.WITSML141.ComponentSchemas;
using Energistics.DataAccess.WITSML141.ReferenceData;

namespace DevkitTest
{
    class Program
    {
        static Boolean successs = true;
        static List<String> failureList = new List<string>();
        private static bool isAbstractObject(Type type)
        {
            Type parentType = type.BaseType;
            while ((parentType != null) || (parentType != typeof(System.Object)))
            {
                if (parentType.Name.Equals("AbstractObject"))
                {
                    return true;
                }

                parentType = parentType.BaseType;
            }
            return false;
        }


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

        static void MainEx(string[] args)
        {
            var document = new XmlDocument();
            var element = document.CreateElement("feed");
            element.InnerText = "1.0.0.0";
            element.SetAttribute("uom", "ft");

            var wellList = new Energistics.DataAccess.WITSML141.WellList();
            var well = new Energistics.DataAccess.WITSML141.Well
            {
                Name = "well",
                Uid = "uid",
                CommonData = new CommonData
                {
                    ExtensionNameValue = new List<Energistics.DataAccess.WITSML141.ComponentSchemas.ExtensionNameValue>
                    {
                        new Energistics.DataAccess.WITSML141.ComponentSchemas.ExtensionNameValue
                        {
                            Uid = "UWIWell",
                            Name = new Energistics.DataAccess.WITSML141.ExtensionName("EDMInstanceID"),
                            Value = new Extensionvalue("EmInstance", "unitless"),
                            DataType = PrimitiveType.@string
                        }
                    }
                },
                CustomData = new Energistics.DataAccess.WITSML141.ComponentSchemas.CustomData
                {
                    Any = new List<XmlElement> {element}
                }
            };

            wellList.Well = new List<Energistics.DataAccess.WITSML141.Well> {well};

            using (var file = new FileStream("./CustomData.dat", FileMode.Create))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(file, wellList);

                file.Position = 0;
                formatter.Deserialize(file);
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            String product = "";
            String assemblyName = "Energistics.DataAccess"; 

            product = "PRODML_v1.2.2";
            testDemoFile(assemblyName, "Energistics.DataAccess.PRODML122", product);
			
            product = "PRODML_v1.3";
            testDemoFile(assemblyName, "Energistics.DataAccess.PRODML131", product);

            product = "WITSML_v1.3.1.1";
            testDemoFile(assemblyName, "Energistics.DataAccess.WITSML131", product);


            product = "WITSML_v1.4.1.1";
            testDemoFile(assemblyName, "Energistics.DataAccess.WITSML141", product);


            product = "RESQML_v2.0";
            assemblyName = "Energistics.DataAccess";
            testDemoFile(assemblyName, "Energistics.DataAccess.RESQML200", product);

            product = "RESQML_v2.0.1";
            assemblyName = "Energistics.DataAccess";
            testDemoFile(assemblyName, "Energistics.DataAccess.RESQML201", product);
           
      
            product = "RESQML_v2.1";
            assemblyName = "Energistics.DataAccess";
            testDemoFile(assemblyName, "Energistics.DataAccess.RESQML210", product);

            product = "WITSML_v2.0";
            assemblyName = "Energistics.DataAccess";
            testDemoFile(assemblyName, "Energistics.DataAccess.WITSML200", product);

            product = "PRODML_v2.0";
            assemblyName = "Energistics.DataAccess";
            testDemoFile(assemblyName, "Energistics.DataAccess.PRODML200", product);

     
           
            if (successs == true)
                Console.WriteLine("test output class successfully!");
            else
            {
                Console.WriteLine("the following test class failed:");
                foreach (String f in failureList)
                {
                    Console.WriteLine(f);
                }
            }

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

        }

        private static void testHDF5File()
        {
            String key = "demoFilePath";
            HDF5Reader reader = new HDF5Reader();
            string dir = ConfigurationManager.AppSettings[key];
            String path = dir + "\\" + "testingPackageCpp.h5";
            HDF5GroupObject hdf5Object = reader.open(path);
            HDF5GroupObject obj = new HDF5GroupObject();
            hdf5Object.getHDF5GroupObject("ColumnsPerSplitCoordinateLine",ref obj);
            HD5DataSetObject dobj = hdf5Object.getHDF5DataObject("ColumnsPerSplitCoordinateLine", "cumulativeLength");
        }

        private static void testEPCFiles()
        { 
            String filename = "obj_DiscreteProperty_4ac4e90c-abb1-4e73-92d4-9ad903a11dec.xml";
            Boolean validFlag = EPCPartValidator.validateName(filename);
            if (validFlag == false)
                Console.Write("fail to validate the name.");

            string uuid = EPCPartValidator.getUUID(filename);
            if (uuid == null)
                Console.Write("fail to validate the uuid.");

            String objectName = EPCPartValidator.getEnergisticsObjectName(filename);
            if (objectName == null)
                Console.Write("fail to validate the objectName.");



            // test opc file
            String epcPathFile = "C:\\projects\\source\\demoXML\\testingPackageCpp.epc";
            EPCReader epcreader = EPCReader.createInstance();


            // read file property in core.xml, find out the creator, datatime...
            // read [content_types].xml, find out the total file contains in the zip.
            // read _rels folder, find out the files relationship, find out the child of objects.
            // .rels contains define the coreproperties. (not sure what to do with coreproperties
            EPCDataView dataviewer = epcreader.readEPCFile(epcPathFile);
            if (dataviewer.TopObjectList != null)
            {
                foreach (EPCObject obj in dataviewer.TopObjectList.Values)
                {
                    Object energisticsObj = obj.loadAllInstance(true); 
                }
            }

            //provide the search function 
            List<EPCObject> eeoList = dataviewer.getObjectbyType(typeof(Energistics.DataAccess.RESQML201.DiscreteProperty));
            if (eeoList == null)
            Console.Write("fail to retrieve the objects.");


            uuid = "4ac4e90c-abb1-4e73-92d4-9ad903a11dec";
            EPCObject eobject = dataviewer.getFilesbyUUID(uuid);
            if (eobject == null)
                Console.Write("fail to retrieve the object.");


            uuid = "4ac4e90c-abb1-4e73-92d4-9ad903a11dec";
            EPCObject instanceObject = dataviewer.getObjectInstancebyUUID(uuid, true);
            if (instanceObject == null)
                Console.Write("fail to retrieve the object.");
            dataviewer.Dispose();
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
                    if (objname.Equals("WellboreMarkers"))
                    {
                        objname = objname.Replace("s", "");
                    }
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
                    if(xmloutput.Length==0)
                    {
                        Console.WriteLine("serialize the xml input failed!");
                    }
                    if (ValidXmlDoc(new StringReader(xmloutput), className, objname, getNameSpace(demoObject.Unwrap().GetType().Namespace), getURI(className,demoObject.Unwrap().GetType().Namespace, objname)))
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
                    if (e.InnerException != null)
                    {
                        Console.WriteLine(e.InnerException.Message);

                        failureList.Add(f + " " + e.InnerException.Message);
                    }
                    else  
                    {
                        Console.WriteLine(e.Message);

                        failureList.Add(f + " " + e.Message);
                    }
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
            if (ValidXmlDoc(new StringReader(xml), "WITSML1.4.1.1", "http://www.witsml.org/schemas/1series",
                getNameSpace(wells.GetType().Namespace), getURI("Energistics.DataAccess.WITSML141", wells.GetType().Namespace, "well")))
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
          
            if (type.FullName.Contains("RESQML200"))
            {
                return converterRESQML200(type, xmlstr);
            }
            if (type.FullName.Contains("RESQML201"))
            {
                return converterRESQML201(type, xmlstr);
            }
            if (type.FullName.Contains("RESQML210"))
            {
                return converterRESQML210(type, xmlstr);
            }
            if (type.FullName.Contains("WITSML200"))
            {
                return converterWITSML(type, xmlstr);
            }
            if (type.FullName.Contains("PRODML200"))
            {
                return converterPRODML(type, xmlstr);
            } 
            throw new Exception("not implemented!"); 
        }

      
        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }



        static public bool ValidXmlDoc(StringReader xml, String name, String objName,
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
            if (name.Contains("WITSML2"))
            {
                return "http://www.energistics.org/energyml/data/witsmlv2";
            }
            if (name.Contains("PRODML2"))
            {
                return "http://www.energistics.org/energyml/data/prodmlv2";
            }
            if (name.Contains("RESQML2"))
            {
                return "http://www.energistics.org/energyml/data/resqmlv2";
            }
            return "";
        }
        


        static string getURI(string name, string objName, string classname)
        {
            string schemaFilePath = ConfigurationManager.AppSettings["schemaFilePath"];
            name = name.ToUpper().Trim();

            string ver = "2.0";

            if (name.Contains("WITSML2"))
            {
                if (classname.Contains("WITSML200"))
                {
                    ver = "2.0";
                }
                return schemaFilePath + "\\witsml\\v" + ver + "\\xsd_schemas\\";
            }

            if (name.Contains("PRODML2"))
            {
                if (classname.Contains("PRODML200"))
                {
                    ver = "2.0";
                }
                return schemaFilePath + "\\prodml\\v" + ver + "\\xsd_schemas\\";
            }
            if (name.Contains("RESQML2"))
            {
                if (classname.Contains("RESQML200"))
                {
                    ver = "2.0";
                }
                if (classname.Contains("RESQML201"))
                {
                    ver = "2.0.1";
                }
                if (classname.Contains("RESQML210"))
                {
                    ver = "2.1";
                }
                return schemaFilePath + "\\resqml\\v" + ver + "\\xsd_schemas\\";
            }

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
            if(name.Contains("RESQML11"))
            {
                schemaFilePath += "\\Resqml_v1.1\\resqml_v1.1.0_data\\xsd_schemas\\";
            }
            return schemaFilePath +"obj_"+ objName + ".xsd";

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
            if (type == typeof(Energistics.DataAccess.WITSML141.DownholeComponentList))
            {
                Energistics.DataAccess.WITSML141.DownholeComponentList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.DownholeComponentList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.WITSML141.WellboreCompletionList))
            {
                Energistics.DataAccess.WITSML141.WellboreCompletionList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.WellboreCompletionList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.WellCMLedgerList))
            {
                Energistics.DataAccess.WITSML141.WellCMLedgerList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.WellCMLedgerList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.WellCompletionList))
            {
                Energistics.DataAccess.WITSML141.WellCompletionList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.WellCompletionList>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML141.DepthRegImageList))
            {
                Energistics.DataAccess.WITSML141.DepthRegImageList obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML141.DepthRegImageList>(xmlstr);
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
        private static String converterPRODML(Type type, string xmlstr)
        {
            String xmloutput = "";
            if (type == typeof(Energistics.DataAccess.PRODML200.AssetProductionVolumes))
            {
                Energistics.DataAccess.PRODML200.AssetProductionVolumes obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.AssetProductionVolumes>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.DasAcquisition))
            {
                Energistics.DataAccess.PRODML200.DasAcquisition obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.DasAcquisition>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.PRODML200.DasInstrumentBox))
            {
                Energistics.DataAccess.PRODML200.DasInstrumentBox obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.DasInstrumentBox>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.PRODML200.DtsInstrumentBox))
            {
                Energistics.DataAccess.PRODML200.DtsInstrumentBox obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.DtsInstrumentBox>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.DtsInstalledSystem))
            {
                Energistics.DataAccess.PRODML200.DtsInstalledSystem obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.DtsInstalledSystem>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.DtsMeasurement))
            {
                Energistics.DataAccess.PRODML200.DtsMeasurement obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.DtsMeasurement>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.FluidAnalysis))
            {
                Energistics.DataAccess.PRODML200.FluidAnalysis obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.FluidAnalysis>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.FluidCharacterization))
            {
                Energistics.DataAccess.PRODML200.FluidCharacterization obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.FluidCharacterization>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.FluidSample))
            {
                Energistics.DataAccess.PRODML200.FluidSample obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.FluidSample>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.FluidSystem))
            {
                Energistics.DataAccess.PRODML200.FluidSystem obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.FluidSystem>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.FluidSampleContainer))
            {
                Energistics.DataAccess.PRODML200.FluidSampleContainer obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.FluidSampleContainer>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.FluidSampleAcquisitionJob))
            {
                Energistics.DataAccess.PRODML200.FluidSampleAcquisitionJob obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.FluidSampleAcquisitionJob>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.2
            if (type == typeof(Energistics.DataAccess.PRODML200.FiberOpticalPath))
            {
                Energistics.DataAccess.PRODML200.FiberOpticalPath obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.FiberOpticalPath>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
           

            if (type == typeof(Energistics.DataAccess.PRODML200.ProductFlowModel))
            {
                Energistics.DataAccess.PRODML200.ProductFlowModel obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.ProductFlowModel>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.ProductionOperation))
            {
                Energistics.DataAccess.PRODML200.ProductionOperation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.ProductionOperation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.ProductVolume))
            {
                Energistics.DataAccess.PRODML200.ProductVolume obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.ProductVolume>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            
            if (type == typeof(Energistics.DataAccess.PRODML200.ProductionWellTest))
            {
                Energistics.DataAccess.PRODML200.ProductionWellTest obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.ProductionWellTest>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
          

            if (type == typeof(Energistics.DataAccess.PRODML200.Report))
            {
                Energistics.DataAccess.PRODML200.Report obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.Report>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.ReportingEntity))
            {
                Energistics.DataAccess.PRODML200.ReportingEntity obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.ReportingEntity>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.ReportingHierarchy))
            {
                Energistics.DataAccess.PRODML200.ReportingHierarchy obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.ReportingHierarchy>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }


            if (type == typeof(Energistics.DataAccess.PRODML200.TerminalLifting))
            {
                Energistics.DataAccess.PRODML200.TerminalLifting obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.TerminalLifting>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.PRODML200.Transfer))
            {
                Energistics.DataAccess.PRODML200.Transfer obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.Transfer>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            
            if (type == typeof(Energistics.DataAccess.PRODML200.TimeSeriesData))
            {
                Energistics.DataAccess.PRODML200.TimeSeriesData obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.TimeSeriesData>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.TimeSeriesStatistic))
            {
                Energistics.DataAccess.PRODML200.TimeSeriesStatistic obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.TimeSeriesStatistic>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
 

            if (type == typeof(Energistics.DataAccess.PRODML200.WftRun))
            {
                Energistics.DataAccess.PRODML200.WftRun obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.WftRun>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.PRODML200.WellTest))
            {
                Energistics.DataAccess.PRODML200.WellTest obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.WellTest>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }


            if (type == typeof(Energistics.DataAccess.PRODML200.WellProductionParameters))
            {
                Energistics.DataAccess.PRODML200.WellProductionParameters obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.PRODML200.WellProductionParameters>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
 
            return xmloutput;
        }
        private static String converterWITSML(Type type, string xmlstr)
        {
          
            String xmloutput = "";
            if (type == typeof(Energistics.DataAccess.WITSML200.SurveyProgram))
            {
                Energistics.DataAccess.WITSML200.SurveyProgram obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.SurveyProgram>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.MudLogReport))
            {
                Energistics.DataAccess.WITSML200.MudLogReport obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.MudLogReport>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.DrillReport))
            {
                Energistics.DataAccess.WITSML200.DrillReport obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.DrillReport>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.DownholeComponent))
            {
                Energistics.DataAccess.WITSML200.DownholeComponent obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.DownholeComponent>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.WITSML200.Attachment))
            {
                Energistics.DataAccess.WITSML200.Attachment obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Attachment>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            } 
            if (type == typeof(Energistics.DataAccess.WITSML200.DepthRegImage))
            {
                Energistics.DataAccess.WITSML200.DepthRegImage obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.DepthRegImage>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.WITSML200.WellCompletion))
            { 
                Energistics.DataAccess.WITSML200.WellCompletion obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.WellCompletion>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.WellCMLedger))
            {
                Energistics.DataAccess.WITSML200.WellCMLedger obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.WellCMLedger>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.WellboreCompletion))
            {
                Energistics.DataAccess.WITSML200.WellboreCompletion obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.WellboreCompletion>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.WITSML200.StimJob))
            {
                Energistics.DataAccess.WITSML200.StimJob obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.StimJob>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.StimJobStage))
            {
                Energistics.DataAccess.WITSML200.StimJobStage obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.StimJobStage>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.ToolErrorModel))
            {
                Energistics.DataAccess.WITSML200.ToolErrorModel obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.ToolErrorModel>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.ToolErrorTermSet))
            {
                Energistics.DataAccess.WITSML200.ToolErrorTermSet obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.ToolErrorTermSet>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.WITSML200.FluidsReport))
            {
                Energistics.DataAccess.WITSML200.FluidsReport obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.FluidsReport>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            
            if (type == typeof(Energistics.DataAccess.WITSML200.OpsReport))
            {
                Energistics.DataAccess.WITSML200.OpsReport obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.OpsReport>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            
            if (type == typeof(Energistics.DataAccess.WITSML200.BhaRun))
            {
                Energistics.DataAccess.WITSML200.BhaRun obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.BhaRun>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.CementJob))
            {
                Energistics.DataAccess.WITSML200.CementJob obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.CementJob>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
           
            if (type == typeof(Energistics.DataAccess.WITSML200.WellboreMarker))
            {
                Energistics.DataAccess.WITSML200.WellboreMarker obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.WellboreMarker>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.Log))
            {
                Energistics.DataAccess.WITSML200.Log obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Log>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            
            if (type == typeof(Energistics.DataAccess.WITSML200.WellboreGeology))
            {
                Energistics.DataAccess.WITSML200.WellboreGeology obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.WellboreGeology>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
          
            if (type == typeof(Energistics.DataAccess.WITSML200.Rig))
            {
                Energistics.DataAccess.WITSML200.Rig obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Rig>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.Risk))
            {
                Energistics.DataAccess.WITSML200.Risk obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Risk>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }          
          
          
            if (type == typeof(Energistics.DataAccess.WITSML200.Trajectory))
            {
                Energistics.DataAccess.WITSML200.Trajectory obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Trajectory>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
           
            if (type == typeof(Energistics.DataAccess.WITSML200.Tubular))
            {
                Energistics.DataAccess.WITSML200.Tubular obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Tubular>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.WellboreGeometry))
            {
                Energistics.DataAccess.WITSML200.WellboreGeometry obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.WellboreGeometry>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.WITSML200.Well))
            {
                Energistics.DataAccess.WITSML200.Well obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Well>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            // addition to 1.
            if (type == typeof(Energistics.DataAccess.WITSML200.Wellbore))
            {
                Energistics.DataAccess.WITSML200.Wellbore obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.WITSML200.Wellbore>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            } 
            return xmloutput; 
        }



        private static String converterRESQML200(Type type, string xmlstr)
        {
            String xmloutput = "";



            if (type == typeof(Energistics.DataAccess.RESQML200.GeneticBoundaryFeature))
            {
                Energistics.DataAccess.RESQML200.GeneticBoundaryFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.GeneticBoundaryFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.OrganizationFeature))
            {
                Energistics.DataAccess.RESQML200.OrganizationFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.OrganizationFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.TectonicBoundaryFeature))
            {
                Energistics.DataAccess.RESQML200.TectonicBoundaryFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.TectonicBoundaryFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.PolylineRepresentation))
            {
                Energistics.DataAccess.RESQML200.PolylineRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.PolylineRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML200.BoundaryFeature))
            {
                Energistics.DataAccess.RESQML200.BoundaryFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.BoundaryFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.CategoricalProperty))
            {
                Energistics.DataAccess.RESQML200.CategoricalProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.CategoricalProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.ContinuousProperty))
            {
                Energistics.DataAccess.RESQML200.ContinuousProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.ContinuousProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.DeviationSurveyRepresentation))
            {
                Energistics.DataAccess.RESQML200.DeviationSurveyRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.DeviationSurveyRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.DiscreteProperty))
            {
                Energistics.DataAccess.RESQML200.DiscreteProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.DiscreteProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.EarthModelInterpretation))
            {
                Energistics.DataAccess.RESQML200.EarthModelInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.EarthModelInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.EpcExternalPartReference))
            {
                Energistics.DataAccess.RESQML200.EpcExternalPartReference obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.EpcExternalPartReference>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
          
            if (type == typeof(Energistics.DataAccess.RESQML200.FrontierFeature))
            {
                Energistics.DataAccess.RESQML200.FrontierFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.FrontierFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.FaultInterpretation))
            {
                Energistics.DataAccess.RESQML200.FaultInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.FaultInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }


            if (type == typeof(Energistics.DataAccess.RESQML200.GenericFeatureInterpretation))
            {
                Energistics.DataAccess.RESQML200.GenericFeatureInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.GenericFeatureInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.GeobodyBoundaryInterpretation))
            {
                Energistics.DataAccess.RESQML200.GeobodyBoundaryInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.GeobodyBoundaryInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.GpGridRepresentation))
            {
                Energistics.DataAccess.RESQML200.GpGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.GpGridRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.Grid2dRepresentation))
            {
                Energistics.DataAccess.RESQML200.Grid2dRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.Grid2dRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.HorizonInterpretation))
            {
                Energistics.DataAccess.RESQML200.HorizonInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.HorizonInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.IjkGridRepresentation))
            {
                Energistics.DataAccess.RESQML200.IjkGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.IjkGridRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.LocalDepth3dCrs))
            {
                Energistics.DataAccess.RESQML200.LocalDepth3dCrs obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.LocalDepth3dCrs>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.LocalTime3dCrs))
            {
                Energistics.DataAccess.RESQML200.LocalTime3dCrs obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.LocalTime3dCrs>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML200.MdDatum))
            {
                Energistics.DataAccess.RESQML200.MdDatum obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.MdDatum>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML200.PointSetRepresentation))
            {
                Energistics.DataAccess.RESQML200.PointSetRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.PointSetRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.PropertyKind))
            {
                Energistics.DataAccess.RESQML200.PropertyKind obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.PropertyKind>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
          
            if (type == typeof(Energistics.DataAccess.RESQML200.SealedSurfaceFrameworkRepresentation))
            {
                Energistics.DataAccess.RESQML200.SealedSurfaceFrameworkRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.SealedSurfaceFrameworkRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.SeismicLatticeFeature))
            {
                Energistics.DataAccess.RESQML200.SeismicLatticeFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.SeismicLatticeFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
           
            if (type == typeof(Energistics.DataAccess.RESQML200.StringTableLookup))
            {
                Energistics.DataAccess.RESQML200.StringTableLookup obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.StringTableLookup>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.StructuralOrganizationInterpretation))
            {
                Energistics.DataAccess.RESQML200.StructuralOrganizationInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.StructuralOrganizationInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML200.TriangulatedSetRepresentation))
            {
                Energistics.DataAccess.RESQML200.TriangulatedSetRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.TriangulatedSetRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.UnstructuredColumnLayerGridRepresentation))
            {
                Energistics.DataAccess.RESQML200.UnstructuredColumnLayerGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.UnstructuredColumnLayerGridRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.WellboreFeature))
            {
                Energistics.DataAccess.RESQML200.WellboreFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.WellboreFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.WellboreFrameRepresentation))
            {
                Energistics.DataAccess.RESQML200.WellboreFrameRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.WellboreFrameRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.WellboreInterpretation))
            {
                Energistics.DataAccess.RESQML200.WellboreInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.WellboreInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.WellboreMarkerFrameRepresentation))
            {
                Energistics.DataAccess.RESQML200.WellboreMarkerFrameRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.WellboreMarkerFrameRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML200.WellboreTrajectoryRepresentation))
            {
                Energistics.DataAccess.RESQML200.WellboreTrajectoryRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML200.WellboreTrajectoryRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            return xmloutput;
        }

        private static String converterRESQML201(Type type, string xmlstr)
        {
            String xmloutput = "";
            if (type == typeof(Energistics.DataAccess.RESQML201.GeneticBoundaryFeature))
            {
                Energistics.DataAccess.RESQML201.GeneticBoundaryFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.GeneticBoundaryFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.OrganizationFeature))
            {
                Energistics.DataAccess.RESQML201.OrganizationFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.OrganizationFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.TectonicBoundaryFeature))
            {
                Energistics.DataAccess.RESQML201.TectonicBoundaryFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.TectonicBoundaryFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.PolylineRepresentation))
            {
                Energistics.DataAccess.RESQML201.PolylineRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.PolylineRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.Activity))
            {
                Energistics.DataAccess.RESQML201.Activity obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.Activity>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML201.ActivityTemplate))
            {
                Energistics.DataAccess.RESQML201.ActivityTemplate obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.ActivityTemplate>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML201.BoundaryFeature))
            {
                Energistics.DataAccess.RESQML201.BoundaryFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.BoundaryFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.CategoricalProperty))
            {
                Energistics.DataAccess.RESQML201.CategoricalProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.CategoricalProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.ContinuousProperty))
            {
                Energistics.DataAccess.RESQML201.ContinuousProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.ContinuousProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.DeviationSurveyRepresentation))
            {
                Energistics.DataAccess.RESQML201.DeviationSurveyRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.DeviationSurveyRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.DiscreteProperty))
            {
                Energistics.DataAccess.RESQML201.DiscreteProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.DiscreteProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.EarthModelInterpretation))
            {
                Energistics.DataAccess.RESQML201.EarthModelInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.EarthModelInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.EpcExternalPartReference))
            {
                Energistics.DataAccess.RESQML201.EpcExternalPartReference obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.EpcExternalPartReference>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.FrontierFeature))
            {
                Energistics.DataAccess.RESQML201.FrontierFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.FrontierFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.FaultInterpretation))
            {
                Energistics.DataAccess.RESQML201.FaultInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.FaultInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }


            if (type == typeof(Energistics.DataAccess.RESQML201.GenericFeatureInterpretation))
            {
                Energistics.DataAccess.RESQML201.GenericFeatureInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.GenericFeatureInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.GeobodyBoundaryInterpretation))
            {
                Energistics.DataAccess.RESQML201.GeobodyBoundaryInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.GeobodyBoundaryInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.GpGridRepresentation))
            {
                Energistics.DataAccess.RESQML201.GpGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.GpGridRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.Grid2dRepresentation))
            {
                Energistics.DataAccess.RESQML201.Grid2dRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.Grid2dRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.HorizonInterpretation))
            {
                Energistics.DataAccess.RESQML201.HorizonInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.HorizonInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.IjkGridRepresentation))
            {
                Energistics.DataAccess.RESQML201.IjkGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.IjkGridRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.LocalDepth3dCrs))
            {
                Energistics.DataAccess.RESQML201.LocalDepth3dCrs obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.LocalDepth3dCrs>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.LocalTime3dCrs))
            {
                Energistics.DataAccess.RESQML201.LocalTime3dCrs obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.LocalTime3dCrs>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML201.MdDatum))
            {
                Energistics.DataAccess.RESQML201.MdDatum obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.MdDatum>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML201.PointSetRepresentation))
            {
                Energistics.DataAccess.RESQML201.PointSetRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.PointSetRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.PropertyKind))
            {
                Energistics.DataAccess.RESQML201.PropertyKind obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.PropertyKind>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
           
            if (type == typeof(Energistics.DataAccess.RESQML201.SealedSurfaceFrameworkRepresentation))
            {
                Energistics.DataAccess.RESQML201.SealedSurfaceFrameworkRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.SealedSurfaceFrameworkRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.SeismicLatticeFeature))
            {
                Energistics.DataAccess.RESQML201.SeismicLatticeFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.SeismicLatticeFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            
            if (type == typeof(Energistics.DataAccess.RESQML201.StringTableLookup))
            {
                Energistics.DataAccess.RESQML201.StringTableLookup obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.StringTableLookup>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.StructuralOrganizationInterpretation))
            {
                Energistics.DataAccess.RESQML201.StructuralOrganizationInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.StructuralOrganizationInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML201.TriangulatedSetRepresentation))
            {
                Energistics.DataAccess.RESQML201.TriangulatedSetRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.TriangulatedSetRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.UnstructuredColumnLayerGridRepresentation))
            {
                Energistics.DataAccess.RESQML201.UnstructuredColumnLayerGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.UnstructuredColumnLayerGridRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.WellboreFeature))
            {
                Energistics.DataAccess.RESQML201.WellboreFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.WellboreFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.WellboreFrameRepresentation))
            {
                Energistics.DataAccess.RESQML201.WellboreFrameRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.WellboreFrameRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.WellboreInterpretation))
            {
                Energistics.DataAccess.RESQML201.WellboreInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.WellboreInterpretation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.WellboreMarkerFrameRepresentation))
            {
                Energistics.DataAccess.RESQML201.WellboreMarkerFrameRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.WellboreMarkerFrameRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML201.WellboreTrajectoryRepresentation))
            {
                Energistics.DataAccess.RESQML201.WellboreTrajectoryRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML201.WellboreTrajectoryRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            return xmloutput;
        }

        private static String converterRESQML210(Type type, string xmlstr)
        {
            String xmloutput = "";



            if (type == typeof(Energistics.DataAccess.RESQML210.UnstructuredGridRepresentation))
            {
                Energistics.DataAccess.RESQML210.UnstructuredGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.UnstructuredGridRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }


            if (type == typeof(Energistics.DataAccess.RESQML210.Activity))
            {
                Energistics.DataAccess.RESQML210.Activity obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.Activity>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML210.ActivityTemplate))
            {
                Energistics.DataAccess.RESQML210.ActivityTemplate obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.ActivityTemplate>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }

            if (type == typeof(Energistics.DataAccess.RESQML210.BoundaryFeature))
            {
                Energistics.DataAccess.RESQML210.BoundaryFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.BoundaryFeature>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML210.CategoricalProperty))
            {
                Energistics.DataAccess.RESQML210.CategoricalProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.CategoricalProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML210.ContinuousProperty))
            {
                Energistics.DataAccess.RESQML210.ContinuousProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.ContinuousProperty>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
            if (type == typeof(Energistics.DataAccess.RESQML210.DeviationSurveyRepresentation))
            {
                Energistics.DataAccess.RESQML210.DeviationSurveyRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.DeviationSurveyRepresentation>(xmlstr);
                xmloutput = EnergisticsConverter.ObjectToXml(obj);
                return xmloutput;
            }
                if (type == typeof(Energistics.DataAccess.RESQML210.DiscreteProperty))
                {
                    Energistics.DataAccess.RESQML210.DiscreteProperty obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.DiscreteProperty>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.EarthModelInterpretation))
                {
                    Energistics.DataAccess.RESQML210.EarthModelInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.EarthModelInterpretation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.EpcExternalPartReference))
                {
                    Energistics.DataAccess.RESQML210.EpcExternalPartReference obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.EpcExternalPartReference>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.FrontierFeature))
                {
                    Energistics.DataAccess.RESQML210.FrontierFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.FrontierFeature>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.FaultInterpretation))
                {
                    Energistics.DataAccess.RESQML210.FaultInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.FaultInterpretation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }


                if (type == typeof(Energistics.DataAccess.RESQML210.GenericFeatureInterpretation))
                {
                    Energistics.DataAccess.RESQML210.GenericFeatureInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.GenericFeatureInterpretation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.GeobodyBoundaryInterpretation))
                {
                    Energistics.DataAccess.RESQML210.GeobodyBoundaryInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.GeobodyBoundaryInterpretation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.GpGridRepresentation))
                {
                    Energistics.DataAccess.RESQML210.GpGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.GpGridRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.Grid2dRepresentation))
                {
                    Energistics.DataAccess.RESQML210.Grid2dRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.Grid2dRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.HorizonInterpretation))
                {
                    Energistics.DataAccess.RESQML210.HorizonInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.HorizonInterpretation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.IjkGridRepresentation))
                {
                    Energistics.DataAccess.RESQML210.IjkGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.IjkGridRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.LocalDepth3dCrs))
                {
                    Energistics.DataAccess.RESQML210.LocalDepth3dCrs obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.LocalDepth3dCrs>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.LocalTime3dCrs))
                {
                    Energistics.DataAccess.RESQML210.LocalTime3dCrs obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.LocalTime3dCrs>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
               
                if (type == typeof(Energistics.DataAccess.RESQML210.MdDatum))
                {
                    Energistics.DataAccess.RESQML210.MdDatum obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.MdDatum>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                
                if (type == typeof(Energistics.DataAccess.RESQML210.PointSetRepresentation))
                {
                    Energistics.DataAccess.RESQML210.PointSetRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.PointSetRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.PropertyKind))
                {
                    Energistics.DataAccess.RESQML210.PropertyKind obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.PropertyKind>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.RockVolumeFeature))
                {
                    Energistics.DataAccess.RESQML210.RockVolumeFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.RockVolumeFeature>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.SealedSurfaceFrameworkRepresentation))
                {
                    Energistics.DataAccess.RESQML210.SealedSurfaceFrameworkRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.SealedSurfaceFrameworkRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.SeismicLatticeFeature))
                {
                    Energistics.DataAccess.RESQML210.SeismicLatticeFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.SeismicLatticeFeature>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.SeismicWellboreFrameRepresentation))
                {
                    Energistics.DataAccess.RESQML210.SeismicWellboreFrameRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.SeismicWellboreFrameRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.StringTableLookup))
                {
                    Energistics.DataAccess.RESQML210.StringTableLookup obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.StringTableLookup>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.StructuralOrganizationInterpretation))
                {
                    Energistics.DataAccess.RESQML210.StructuralOrganizationInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.StructuralOrganizationInterpretation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
               
                if (type == typeof(Energistics.DataAccess.RESQML210.TriangulatedSetRepresentation))
                {
                    Energistics.DataAccess.RESQML210.TriangulatedSetRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.TriangulatedSetRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.UnstructuredColumnLayerGridRepresentation))
                {
                    Energistics.DataAccess.RESQML210.UnstructuredColumnLayerGridRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.UnstructuredColumnLayerGridRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.WellboreFeature))
                {
                    Energistics.DataAccess.RESQML210.WellboreFeature obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.WellboreFeature>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.WellboreFrameRepresentation))
                {
                    Energistics.DataAccess.RESQML210.WellboreFrameRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.WellboreFrameRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.WellboreInterpretation))
                {
                    Energistics.DataAccess.RESQML210.WellboreInterpretation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.WellboreInterpretation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.WellboreMarkerFrameRepresentation))
                {
                    Energistics.DataAccess.RESQML210.WellboreMarkerFrameRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.WellboreMarkerFrameRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                }
                if (type == typeof(Energistics.DataAccess.RESQML210.WellboreTrajectoryRepresentation))
                {
                    Energistics.DataAccess.RESQML210.WellboreTrajectoryRepresentation obj = EnergisticsConverter.XmlToObject<Energistics.DataAccess.RESQML210.WellboreTrajectoryRepresentation>(xmlstr);
                    xmloutput = EnergisticsConverter.ObjectToXml(obj);
                    return xmloutput;
                } 
            return xmloutput;
        }


    }
}
