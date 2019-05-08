using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Packaging;
using System.IO;
using MS.Internal.IO.Packaging;
namespace DevkitTest
{
    /// <summary>
    /// thread safe 
    /// EPCReader reads the epc file, is able user to retrieve the objects.
    /// </summary>
    class EPCReader
    {
        //make thread safe due to the class loader are syn.
        private static EPCReader instance = new EPCReader();
        private static Object locker = new Object();
        // read file property in core.xml, find out the creator, datatime...
        // read [content_types].xml, find out the total file contains in the zip.
        // read _rels folder, find out the files relationship, find out the child of objects.
        // .rels contains define the ocreproperties.
        internal static EPCReader createInstance()
        {
            return instance;
        }

 
        public string getEPCFIleText(String epcPathFile,String partFileName)
        {
            String xmlcontent = "";
            using (ZipPackage package = (ZipPackage)Package.Open(epcPathFile, FileMode.Open, FileAccess.Read))
            {
                PackagePartCollection packageParts = package.GetParts();
                foreach (PackagePart packagepart in packageParts)
                {
                     if (packagepart.Uri.ToString().CompareTo(partFileName)==0)
                     {
                         Stream stream = null;
                         lock(locker)
                         {
                             try
                             {
                                 stream = packagepart.GetStream(FileMode.Open, FileAccess.Read);
                                 using (StreamReader reader = new StreamReader(stream))
                                 {
                                     xmlcontent = reader.ReadToEnd();
                                 }
                             }catch(Exception e)
                             {
                                 throw e;
                             }
                             finally
                             {
                                 
                                 stream.Close();
                             }
                         }
                         return xmlcontent;
                     }
                }
            }
            return null;
        }

        // read file property in core.xml, find out the creator, datatime...
        // read [content_types].xml, find out the total file contains in the zip.
        // read _rels folder, find out the files relationship, find out the child of objects.
        // .rels contains define the ocreproperties.
        public EPCDataView readEPCFile(String epcPathFile)
        {
            // must has [content_Types].xml
            // /_rels/.rels must contain at least the metadata/core-properties and target. which resqml example doesnt' following.
            // core properties should contains creator, created, version description, id, title
            Dictionary<string, EPCObject> TopObjectList = new Dictionary<string, EPCObject>();
            List<EPCObject> listObjects = new List<EPCObject>();
            EPCCoreProperty epcCore = new EPCCoreProperty();

            List<KeyValuePair<String, EPCObject>> parentChild = new List<KeyValuePair<String, EPCObject>>();
            try
            {
                using (ZipPackage package = (ZipPackage)Package.Open(epcPathFile, FileMode.Open, FileAccess.Read))
            {
                
                PackageRelationshipCollection packageRels = package.GetRelationships();
                //package Rels must contains id "CoreProperties" property. getTargetUri directory.
                String sourceURI = "";
                String coreURI = getCorePropertyURI(packageRels,ref sourceURI);
                PackagePartCollection packageParts = package.GetParts();
                foreach (PackagePart packagepart in packageParts)
                {
                    // match the coreURI. 
                    // find the coreProperty
                    if ((packagepart.Uri != null) && (packagepart.Uri.Equals(sourceURI + coreURI)))
                    {
                        epcCore.Creator = packagepart.Package.PackageProperties.Creator;
                        epcCore.Created = packagepart.Package.PackageProperties.Created;
                        epcCore.Version = packagepart.Package.PackageProperties.Version;
                        epcCore.Description = packagepart.Package.PackageProperties.Description;
                        epcCore.Identifier = packagepart.Package.PackageProperties.Identifier;
                        epcCore.Keywords = packagepart.Package.PackageProperties.Keywords;
                        epcCore.Title = packagepart.Package.PackageProperties.Title;                         
                    }
                    else
                    {
                        // create each epcobject for package part
                        if (isPart(packagepart))
                        {
                            EPCObject epcObject = new EPCObject(); 
                            String epcContentType = "";
                            String version = "";
                            String epcObjectType="";
                            EPCPartValidator.parseContentType(packagepart.ContentType, ref epcContentType, ref version, ref epcObjectType);
                            epcObject.EpcContentType = epcContentType;
                            epcObject.EPCObjectType = epcObjectType;
                            epcObject.SchemaVersion = version;
                            epcObject.PackageFile = epcPathFile;
                            epcObject.EpcFileName = this.getfilename(packagepart.Uri.ToString());
                            epcObject.Uuid = this.getuuid(packagepart.Uri.ToString());
                            epcObject.Uri = packagepart.Uri;
                            listObjects.Add(epcObject);
                            //get rest relationship items
                            PackageRelationshipCollection partRels = null;
                            try
                            {
                                if (packagepart != null)
                                    partRels = packagepart.GetRelationships();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("warning : " + e.Message);
                            }
                            if (partRels != null)
                            {
                                // create pair key for relationships parent and child
                                foreach (PackageRelationship partsRel in partRels)
                                {
                                    EPCRelationshipType epcrelType = EPCPartValidator.getRelationshipType(partsRel.RelationshipType);
                                    // conver the target and source into the parent and child table.
                                    if( (epcrelType == EPCRelationshipType.destinationObject)||
                                        (epcrelType == EPCRelationshipType.mlToExternalPartProxy)||
                                        (epcrelType == EPCRelationshipType.destinationMedia)||
                                        (epcrelType == EPCRelationshipType.externalResource) ||
                                        (epcrelType == EPCRelationshipType.chunkedPart)
                                      )
                                    {
                                        string name = getfilename(packagepart.Uri.ToString());
                                        //string childname =  getfilename(partsRel.TargetUri.ToString()); 
                                        EPCObject obj = new EPCObject();
                                        obj.TargetMode = partsRel.TargetMode; ;
                                        obj.EpcFileName = partsRel.TargetUri.ToString();
                                        if((obj.TargetMode == TargetMode.External)&&(obj.EpcFileName.EndsWith(".h5")))
                                        {
                                            obj.HDF5 = true;
                                            epcObject.EpcFileName = obj.EpcFileName;
                                            epcObject.HDF5 = true;
                                        }
                                        KeyValuePair<string, EPCObject> pair = new KeyValuePair<string, EPCObject>(name, obj);
                                        if (!isDuplicated(parentChild, pair))
                                            parentChild.Add(pair);
                                        //else
                                            //Console.WriteLine("source already add in. skip ...");
                                    }
                                    if ((epcrelType == EPCRelationshipType.sourceObject) ||
                                       (epcrelType == EPCRelationshipType.extenalPartProxyToMI) || 
                                       (epcrelType == EPCRelationshipType.sourceMedia))
                                    {
                                        string name = getfilename(partsRel.TargetUri.ToString());
                                        string childname = getfilename(packagepart.Uri.ToString());
                                        EPCObject obj = new EPCObject();
                                        obj.TargetMode = partsRel.TargetMode; ;
                                        obj.EpcFileName = childname;
                                        KeyValuePair<string, EPCObject> pair = new KeyValuePair<string, EPCObject>(name, obj);
                                        if (!isDuplicated(parentChild, pair))
                                            parentChild.Add(pair);
                                        //else 
                                            //Console.WriteLine("source already add in. skip ...");
                                    }
                                }
                            }
                        }
                    }
                }

                //sort the hierachy from the pair
                listObjects.Sort(new EPCObjectComparer());
                TopObjectList = sortHierarchy(parentChild,listObjects);
                // assign to dataviewer. 
                EPCDataView dataviewer = new EPCDataView();
                dataviewer.TopObjectList = TopObjectList;
                dataviewer.ListObjects = listObjects;
                dataviewer.EpcCoreProperty = epcCore;
                return dataviewer;
            } 
               
            }catch(Exception e)
            { 
                throw new Exception(String.Format("the file is not validate EPC file : {0} ", e.Message));
            }
        }

        private bool isDuplicated(List<KeyValuePair<string, EPCObject>> parentChild, KeyValuePair<string, EPCObject> pair)
        {
            foreach (KeyValuePair<string, EPCObject> pairA in parentChild)
            {
                if ((pairA.Key.CompareTo(pair.Key) == 0) && (pairA.Value.EpcFileName.CompareTo(pair.Value.EpcFileName) == 0))
                    return true;
            }
            return false;
        }

      
 
        /// <summary>
        /// base on the parant and child string pair, this function try to create the hiearchy structure 
        /// the topObjectList contains only root parent object.
        /// objList is dictionary that help speed the algorithm- if the parent -child already form, no longer need to reform again.
        /// </summary>
        /// <param name="parentChild"> key value pair with parent and child string</param>
        /// <param name="listObjects"> referencing epcobject collection </param>
        /// <returns>root hierarchy object collection.</returns> 
        private Dictionary<string, EPCObject> sortHierarchy(List<KeyValuePair<string, EPCObject>> parentChild, List<EPCObject> listObjects)
        {
            Dictionary<string, EPCObject> topObjectList = new Dictionary<string, EPCObject>();

            Dictionary<string, EPCObject> objList = new Dictionary<string, EPCObject>();
            for (int i = 0; i < parentChild.Count;i++)
            { 
                EPCObject top = regroup(i, parentChild,objList, listObjects);
                if (!topObjectList.ContainsKey(top.EpcFileName))
                {
                    topObjectList.Add(top.EpcFileName, top);
                }
                //parentChild.RemoveAt(i);
            }
            if (objList.Count > 0)
                objList.Clear();
            return topObjectList;
        }
 

        private EPCObject regroup(int index, List<KeyValuePair<string, EPCObject>> parentChild, Dictionary<string, EPCObject> objList, List<EPCObject> listObjects)
        {
            EPCObject topObject = null;
            EPCObject epcObj = null;
            bool loop = false;
            if (index > parentChild.Count-1)
                return topObject;
            String key = parentChild[index].Key;
            epcObj = getEPCObject(key,listObjects);
            // prevent the loop that key exist in chain of values.

            // find child value when the key is same
            findChild( key, ref parentChild, ref epcObj, objList, listObjects);
            // find the value is the key of parent.
            topObject = findParent( key, ref parentChild, ref epcObj, objList, listObjects);
            if (loop)
                throw new Exception("the parent child relationship in EPC file has loop recurrence!");
            return topObject;
        }

        private EPCObject getEPCObject(string key, List<EPCObject> listObjects)
        {
            int i = listObjects.BinarySearch(new EPCObject(key));
            if (i < 0) return null;
            return listObjects[i];
        }



        private EPCObject findParent(string key, ref List<KeyValuePair<string, EPCObject>> parentChild, ref EPCObject epcObj, Dictionary<string, EPCObject> objList, List<EPCObject> listObjects)
        { 
            // match the key to the value 
          
                for (int i = 0; i < parentChild.Count;) 
                {
                    if (parentChild[i].Value.Equals(key))
                    { 
                        String name = parentChild[i].Key; ;
                        EPCObject parent = getEPCObject(name, listObjects);
                       
                        parent.EpcFileName = name;
                        parent.Children.Add(epcObj);
                        parentChild.RemoveAt(i);
                        findParent(name, ref parentChild, ref parent,objList,listObjects);
                        if (!objList.ContainsKey(key))
                            objList.Add(key, epcObj);
                        // return the new created object.
                        return parent;
                    } 
                    else
                        i++;
                }
                if (!objList.ContainsKey(key))
                    objList.Add(key, epcObj);
            return epcObj;
        }

        private void findChild( string key, ref List<KeyValuePair<string, EPCObject>> parentChild, ref EPCObject epcObj, Dictionary<string, EPCObject> objList, List<EPCObject> listObjects)
        {
            if (objList.ContainsKey(key))
                epcObj = objList[key];
            else
            {
            for (int i = 0; i < parentChild.Count;)
            {               
                // if key match
                if (parentChild[i].Key.Equals(key))
                {
                    if (epcObj.Children == null)
                        epcObj.Children = new List<EPCObject>();
                    //create sub level object child  
                    String name = parentChild[i].Value.EpcFileName; ;
                    //child.EpcFileName = name;
                    EPCObject child = getEPCObject(name,listObjects);
                    if (child != null)
                    {
                        // prevent duplicate item and add the child object to epcobject.
                        if (!isExists(epcObj.Children, name))
                            epcObj.Children.Add(child);
                        // remove from parentchild list.
                        parentChild.RemoveAt(i);
                        // build the child heiarchy structure.
                        findChild(child.EpcFileName, ref parentChild, ref child, objList, listObjects); 
                    
                        // if store doesn't contain, add 
                        if (!objList.ContainsKey(child.EpcFileName))
                            objList.Add(child.EpcFileName, child);
                    }
                    else
                        break;
                }
                else
                    i++;
                }
            }
            // add the epcobject back.
            if (!objList.ContainsKey(key))
                objList.Add(key,epcObj); 
        }

        private bool isExists(List<EPCObject> list, string name)
        {
            foreach(EPCObject eo in list)
            {
                if (eo.EpcFileName.CompareTo(name)==0)
                    return true;
            }
            return false;
        }

       
        private string getfilename(string str)
        {
            int pos = str.LastIndexOf('/');
            string name= str.Substring(pos + 1, str.Length - pos - 1).Trim();
            return name;
        }
        public string getuuid(string str)
        {
            //find ".xml"; 
            string[] names = str.Split('_');
            if(names!=null)
            {
                str = names[names.Length - 1];
            }
            int ep = str.IndexOf('.');
            string name = str.Substring(0, ep).Trim();
            return name;
        }

        private bool isPart(PackagePart packagepart)
        {
            String type = packagepart.ContentType;
            if (type.Contains("witsml") ||(type.Contains("prodml"))||type.Contains("resqml"))
                return true;
            return false;
        }

        private String getCorePropertyURI(PackageRelationshipCollection packageRels, ref String sourceURI)
        {
            foreach(PackageRelationship packrel in packageRels)
            {
                if(packrel.Id.Equals("CoreProperties"))
                {
                    sourceURI = packrel.SourceUri.ToString();
                    return packrel.TargetUri.ToString();
                }
            }
            throw new FormatException("Core properties is missing from the package!");
        }


    }
}
