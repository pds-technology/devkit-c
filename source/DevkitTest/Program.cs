using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;
using Energistics.DataAccess.COMPLETION100;
using Energistics.DataAccess.WITSML131;
using Energistics.DataAccess.WITSML141;
using Energistics.DataAccess.PRODML122;
using Energistics.DataAccess.PRODML131;
using Energistics.DataAccess.RESQML200;
using Energistics.DataAccess;
using Energistics.DataAccess.PRODML122.PROD_GenericDataAccess;
namespace DevkitTest
{
    class Program
    {
        static Boolean successs = true;
        static List<String> failureList = new List<string>();
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


        static Boolean ComparationOutput(String outputPrev, String xmloutput)
        { 
            Boolean result = true;
            // format the string, remove \r\n\t "prodml:" and space.
            outputPrev = outputPrev.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("prodml:", "").Replace("witsml:","").Replace(" ", "");
            xmloutput = xmloutput.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("prodml:", "").Replace("witsml:","").Replace(" ", "");
            int startP= outputPrev.IndexOf("name");
            String FormatStr = outputPrev;
            if (startP > 0)
            {
                FormatStr = outputPrev.Substring(startP, outputPrev.Length - startP);
            }
            String FormatStr2 = xmloutput;
            int startP2 = xmloutput.IndexOf("name");
            if(startP2>0)
                FormatStr2 = xmloutput.Substring(startP2, xmloutput.Length - startP2);

            if (((Math.Abs(FormatStr.Length - FormatStr2.Length) / (float)FormatStr.Length) > 0.02) &&(FormatStr2.Length < FormatStr.Length))
                    result = false;
            return result;
        }
        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }

        static void testDemoFile(String assemblyName, String className,String product)
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
                //get the name from the string, required the name is same as the object.
                Console.WriteLine("process the file {0}", f);
                int startp = f.LastIndexOf("\\") + "\\".Length;
                int length = f.IndexOf(".xml") - startp;
                String objname = f.Substring(startp, length).Replace("obj_","");
                ObjectHandle demoObject = createInstance(assemblyName,className, objname);

                if (demoObject == null)
                {
                    successs = false;
                    failureList.Add("cann't found the class "+ f);
                    continue;
                }  
                // test the deserialize
                XmlSerializer x = new XmlSerializer(demoObject.Unwrap().GetType());
                StreamReader reader = new StreamReader(f);
                String outputPrev = reader.ReadToEnd();
                reader.Close();
                // reopen.
                reader = new StreamReader(f);
               
                Object result = null;
                try
                {
                    result = x.Deserialize(reader);
                    if (result != null)
                    {
                        Console.WriteLine("validate the xml input successfully!");
                        Console.WriteLine("test output sample  ...");
                    }
                    else
                    {
                        Console.WriteLine("validate the xml input failed!");

                    }
                   
                    reader.Close();
                    // now we test the serialize 
                    StringWriter writer = new Utf8StringWriter();
                    x.Serialize(writer, result);
                    String xmloutput = writer.ToString();
                   if (!ComparationOutput(outputPrev, xmloutput))
                    {
                        Console.WriteLine("failure!");
                        failureList.Add("output has differences: " + f);
                        successs = false;
                    }
                    //if(xmloutput.Length>0)
                    //    Console.WriteLine("success!");
                    
                }
                catch(Exception e)
                {
                    successs = false;
                    failureList.Add(f + " " + e.Message);
                    if(reader!=null)
                    {
                        reader.Close();
                    }
                }
               
            }
           
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


        private static void testWITSMLWebService()
        {
            string uid = "TestUID_1";
            WITSMLWebServiceConnection webconn = new WITSMLWebServiceConnection("http://localhost:56669/WITSML_DataService.svc",WMLSVersion.WITSML141);
 
            Console.WriteLine("test WMLS_GetVersion...");
            String version = webconn.GetVersion();
            if(version.CompareTo("WITSML1.4.1")==0)
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
           catch(Exception ){
               Console.WriteLine("failure!");
           }

        }

        static void Main(string[] args)
        {
            String assemblyName = "Energistics.DataAccess";
            // if webservice is up, can use this line to test the webservice
            //Console.WriteLine("Test the WITSML WebServiceAPI ... ");
            //testWITSMLWebService();

            //Console.WriteLine("Test the PRODML WebServiceAPI ... ");
            //testProdmlWebService();
           
            String product = "";

            product = "PRODML_v1.3"; 
            assemblyName = "Energistics.DataAccess";
            testDemoFile(assemblyName,"Energistics.DataAccess.PRODML131",product);
           
            //1. test the completion 1.0
             product = "Completion_v1.0";
             testDemoFile(assemblyName, "Energistics.DataAccess.COMPLETION100", product);

            
            product = "WITSML_v1.3.1.1";
            testDemoFile(assemblyName, "Energistics.DataAccess.WITSML131", product);


            product = "WITSML_v1.4.1.1";
            testDemoFile(assemblyName, "Energistics.DataAccess.WITSML141", product);


            product = "PRODML_v1.2.2";
            testDemoFile(assemblyName, "Energistics.DataAccess.PRODML122", product);
           
            product = "RESQML_v2.0";
            assemblyName = "Energistics.RESQMLDataAccess";
            testDemoFile(assemblyName, "Energistics.DataAccess.RESQML200", product);

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
    }
}
