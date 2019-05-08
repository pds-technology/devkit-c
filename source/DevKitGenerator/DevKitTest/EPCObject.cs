using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DevkitTest
{
    class EPCObject :IComparable,IDisposable
    {
       
        public EPCObject() { Children = new List<EPCObject>(); }

        public EPCObject(string key)
        {
            // TODO: Complete member initialization
            this.EpcFileName = key;
        }
        public String Uuid { get; set; }
        public List<EPCObject> Children{get;set;}
        //public EPCObject Parent { get; set; }
        public String EpcContentType { get; set; }
        public string EpcFileName { get; set; }
        public String EPCObjectType { get; set; }
        // this is energistics schema version 
        public string SchemaVersion { get; set; }
        public Boolean HDF5{get;set;}
        public Uri Uri { get; set; }
        public int CompareTo(object other)
        {
            return this.EpcFileName.CompareTo(((EPCObject)other).EpcFileName);
        }
        private Object instanceMLObject = null;
        public Object Instance 
        {
            get
            {
                if(instanceMLObject == null)
                {
                    instanceMLObject = loadInstance();
                }
                return instanceMLObject;
            }
            set
            {
                instanceMLObject = value;
            }
        } 

        private Object loadInstance()
        {
            Instance = EnergisticsUtil.loadInstance(this);
            return Instance;
        }

        internal Object loadAllInstance(Boolean bloadChildInstances)
        {
            if (Instance == null)
            {
                Instance = EnergisticsUtil.loadInstance(this);
                this.Uuid = "";
            }
            if (bloadChildInstances)
            {
                foreach (EPCObject epcObj in Children)
                {
                    epcObj.Instance = epcObj.loadAllInstance(true);
                }
            }
            return Instance;
        }
        public String PackageFile { get; set; }

        public void Dispose()
        {
            if (this.instanceMLObject != null)
                this.instanceMLObject = null;
            if((Children!=null)&&(Children.Count > 0))
                Children.Clear();
        }

        public System.IO.Packaging.TargetMode TargetMode { get; set; }
    }
}
