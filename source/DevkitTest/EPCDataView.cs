using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevkitTest
{
    class EPCDataView:IDisposable
    {
        /// <summary>
        /// list the top level objects
        /// </summary>
        public Dictionary<string, EPCObject> TopObjectList { get; set; }

        /// <summary>
        /// the core properties
        /// </summary>
        public EPCCoreProperty EpcCoreProperty { get; set; }

        /// <summary>
        /// the list of all objects, flat structure.
        /// </summary>
        public List<EPCObject> ListObjects { get; set; }


        public EPCObject getFilesbyUUID(string uuid)
        {
            foreach (EPCObject epcObj in ListObjects)
            {
                if (epcObj.Uuid.CompareTo(uuid)==0)
                {
                    return epcObj;
                }
            }
            return null;
        }

        /// <summary>
        /// return the object specified by the type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<EPCObject> getObjectbyType(Type type)
        {
            List<EPCObject> epcObjects = new List<EPCObject>();
            foreach(EPCObject epcObj in ListObjects)
            {
                if(epcObj.EPCObjectType.Contains(type.Name))
                {
                    epcObjects.Add(epcObj);
                }
            }
            return epcObjects;
        }

        /// <summary>
        /// dispose the object
        /// </summary>
        public void Dispose()
        {
            if(ListObjects!=null)
            {
                foreach(EPCObject epcObj in ListObjects)
                {
                    epcObj.Dispose();
                }
                ListObjects.Clear();
                if(TopObjectList!=null)
                TopObjectList.Clear();
            }
        }

        /// <summary>
        /// get the object instance by UUID
        /// </summary>
        /// <param name="uuid">the object uuid value</param>
        /// <param name="bloadAllChildInstance">the boolean value, load all child instance when the value is true.</param>
        /// <returns></returns>
        public EPCObject getObjectInstancebyUUID(string uuid, Boolean bloadAllChildInstance)
        {
            foreach (EPCObject epcObj in ListObjects)
            {
                if (epcObj.Uuid.Equals(uuid))
                {
                    if(epcObj.Instance == null)
                    {
                        epcObj.loadAllInstance(bloadAllChildInstance);
                    }
                    return epcObj;
                }
            }
            return null;
        }
    }
}
