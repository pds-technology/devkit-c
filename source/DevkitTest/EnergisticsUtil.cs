using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.IO;
using Energistics.DataAccess; 
namespace DevkitTest
{
    class EnergisticsUtil
    {
       static readonly string RESQML = "resqml";
       static readonly string WITSML = "witsml";
       static readonly string PRODML = "prodml";
        private static EnergisticsUtil instance = new EnergisticsUtil();
        public EnergisticsUtil Instance()
        {
            return instance;
        }
        /// <summary>
        /// loadInstance is to handle the energistcs data instance.
        /// </summary>
        /// <param name="epcObject"></param>
        /// <returns></returns>
        public static Object loadInstance(EPCObject epcObject)
        {
            if (epcObject == null)
                return null;
            ObjectHandle demoObject= createInance(epcObject);

            if (demoObject != null)
            {
                string xmlcontent = EPCReader.createInstance().getEPCFIleText(epcObject.PackageFile, epcObject.Uri.ToString());
                // only load the xml , we can confirm the uuid from real document , otherwise it derieves from the filename.
                epcObject.Uuid = getUuid(epcObject.EPCObjectType, xmlcontent);
                // convert the stream to the energistics object. 
                Type type = demoObject.Unwrap().GetType();
                Object partEnergisticsObject = EnergisticsConverter.XmlToObject(type, xmlcontent, Encoding.UTF8);
                return partEnergisticsObject;
            }
            else
                return null;
            
        }
        /// <summary>
        /// create the object bese on the contenttype "resqml, witsml, prodml" and version 
        /// </summary>
        /// <param name="epcObject"></param>
        /// <returns></returns>
        private static ObjectHandle createInance(EPCObject epcObject)
        {
            // the content type is energistcs standard
            // create the instance from the name.
            String assemblyName = "";
            String className = "";
            // resqml
            if (epcObject.EpcContentType.Equals(RESQML))
            {
                assemblyName = "Energistics.DataAccess";
                //here need to change in future.
                if (epcObject.SchemaVersion == "2.0")
                {
                    className = "Energistics.DataAccess.RESQML201";
                    epcObject.EPCObjectType = epcObject.EPCObjectType.Replace("obj_", "");
                }
                if (epcObject.SchemaVersion == "1.1")
                {
                    className = "Energistics.DataAccess.RESQML110";
                }
            }
            else //prodml
                if (epcObject.EpcContentType.Equals(PRODML))
                {
                    assemblyName = "Energistics.DataAccess";
                    if (epcObject.SchemaVersion == "2.0")
                    {
                        className = "Energistics.DataAccess.PRODML200";
                        epcObject.EPCObjectType = epcObject.EPCObjectType.Replace("obj_", "");
                    }
                    if (epcObject.SchemaVersion.Contains("1.2"))
                    {
                        className = "Energistics.DataAccess.PRODML122";
                    }
                    if (epcObject.SchemaVersion.Contains("1.3"))
                    {
                        className = "Energistics.DataAccess.PRODML131";
                    }
                }
                else //witsml
                    if (epcObject.EpcContentType.Equals(WITSML))
                    {
                        assemblyName = "Energistics.DataAccess";
                        if (epcObject.SchemaVersion == "2.0")
                        {
                            className = "Energistics.DataAccess.WITSML200";
                            epcObject.EPCObjectType = epcObject.EPCObjectType.Replace("obj_", "");
                        }
                        if (epcObject.SchemaVersion.Contains("1.3.1"))
                        {
                            className = "Energistics.DataAccess.WITSML131";
                        }
                        if (epcObject.SchemaVersion.Contains( "1.4.1"))
                        {
                            className = "Energistics.DataAccess.WITSML141";
                        }
                    }
                    else
                    {
                        Console.WriteLine("none -energistics object is defined." + epcObject.EPCObjectType);
                        return null;
                    }
            String objname = epcObject.EPCObjectType;
            ObjectHandle demoObject = createInstance(assemblyName, className, objname);
            if (demoObject == null)
            {
                throw new Exception("can't initialize the class.");
            }
            return demoObject;
        }

        private static string getUuid(string type, string xmlcontent)
        {
            String uidtemplate = "uuid=";
            //get line between start bracket of type
            // get the first appearce of uuid
            int pos = xmlcontent.IndexOf(":" + type);
            int endpos = xmlcontent.IndexOf(">",pos);
            if((pos >0) &&(endpos>0))
            {
                int stPos = xmlcontent.IndexOf(uidtemplate, pos)+ uidtemplate.Length+1;
                int epos = xmlcontent.IndexOf("\"",stPos);
                if(epos<endpos)
                {
                    String uuid = xmlcontent.Substring(stPos, epos -stPos);
                    return uuid;
                }
            }
            return "";
        }

        static ObjectHandle createInstance(String assemblyName, String className, String objname)
        {
            
            String objectListname = objname;
            ObjectHandle demoObject = null;
            try
            {
                //WellList
                String name = className + "." + objectListname.Substring(0, 1).ToUpper() + objectListname.Substring(1, objectListname.Length - 1);

                demoObject = Activator.CreateInstance(assemblyName, name);

            }
            catch (Exception)
            {
                //wellList
                String name = className + "." + objectListname +"List";
                try
                {
                    demoObject = Activator.CreateInstance(assemblyName, name);
                }
                catch (Exception)
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


    }
}
