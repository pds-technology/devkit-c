﻿using System;
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
namespace DevkitTest
{
    class Program
    {
        static Boolean successs = true;
        static List<String> failureList = new List<string>();
        static ObjectHandle createInstance(String className, String objname)
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

                    demoObject = Activator.CreateInstance("Energistics.DataAccess", name);   
                    
                }
                catch(Exception )
                {
                    //wellList
                    String name = className + "." + objectListname;
                    try
                    {
                        demoObject = Activator.CreateInstance("Energistics.DataAccess", name);
                    }
                    catch(Exception)
                    {
                        try // Well
                        { 
                            name = className + "." + objname.Substring(0, 1).ToUpper() + objname.Substring(1, objname.Length - 1);
                            demoObject = Activator.CreateInstance("Energistics.DataAccess", name);   
                        }
                        catch (Exception)
                        {
                            try //well
                            {
                                name = className + "." + objname;
                                demoObject = Activator.CreateInstance("Energistics.DataAccess", name);
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

            if ((Math.Abs(FormatStr.Length - FormatStr2.Length) / (float)FormatStr.Length) > 0.1)
                    result = false;
            return result;
        }


        static void testDemoFile(String className,String product)
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
                String objname = f.Substring(startp, length);
                ObjectHandle demoObject = createInstance(className, objname);

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
                    StringWriter writer = new StringWriter();
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
                catch(Exception)
                {
                    successs = false;
                    failureList.Add(f);
                    if(reader!=null)
                    {
                        reader.Close();
                    }
                }
               
            }
           
        }

        static void Main(string[] args)
        {
            String product = "";
            product = "PRODML_v1.3";
            testDemoFile("Energistics.DataAccess.PRODML131",product);
           
            //1. test the completion 1.0
             product = "Completion_v1.0";
            testDemoFile("Energistics.DataAccess.COMPLETION100",product);

            
            product = "WITSML_v1.3.1.1";
            testDemoFile("Energistics.DataAccess.WITSML131",product);


            product = "WITSML_v1.4.1.1";
            testDemoFile("Energistics.DataAccess.WITSML141",product);


            product = "PRODML_v1.2.2";
            testDemoFile("Energistics.DataAccess.PRODML122", product);

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
            // validate the xml using the devkit
            // generate the xml using devkit.
            //test web kit?
        }
    }
}