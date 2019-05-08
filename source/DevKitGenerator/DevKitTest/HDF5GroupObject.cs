using HDF5DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevkitTest
{
    public class HDF5GroupObject : Object
    {
        public HDF5GroupObject() { ShortName = ""; GroupName = ""; }
        public HDF5GroupObject(H5GroupId id, String name)
        {
            this.groupName = name;
            this.groupID = id;
        }

        private List<HDF5GroupObject> subGroups;

        public List<HDF5GroupObject> SubGroups
        {
            get { if (subGroups == null) subGroups = new List<HDF5GroupObject>(); return subGroups; }
            set { subGroups = value; }
        }
        private List<HD5DataSetObject> datasets;

        public List<HD5DataSetObject> Datasets
        {
            get { if (datasets == null) datasets = new List<HD5DataSetObject>(); return datasets; }
            set { datasets = value; }
        }
        private H5GroupId groupID = null;

        public H5GroupId GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }
        private String groupName;

        public String GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }


        public string ShortName { get; set; }

        public void  getHDF5GroupObject(String groupName, ref HDF5GroupObject foundGroupObject)
        {
            if(subGroups!=null)
            {
                foreach(HDF5GroupObject hdf5Ojb in subGroups)
                {
                    if (hdf5Ojb.ShortName.CompareTo(groupName) == 0)
                        foundGroupObject= hdf5Ojb;
                    else
                        hdf5Ojb.getHDF5GroupObject(groupName, ref foundGroupObject);
                    if (foundGroupObject != null)
                        return;
                }
            } 
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentGroupName">immediate parent group/record name</param>
        /// <param name="dataName">the data/record/attribute name</param>
        /// <returns></returns>
        public HD5DataSetObject getHDF5DataObject(String parentGroupName, String dataName)
        {
            HDF5GroupObject parentObj = new HDF5GroupObject();
            getHDF5GroupObject(parentGroupName, ref parentObj);
            if ((parentObj != null) && (parentObj.datasets != null))
            {
                foreach (HD5DataSetObject hdf5Data in parentObj.datasets)
                {
                    if (hdf5Data.ShortName.CompareTo(dataName) == 0)
                        return hdf5Data;
                }
            }
            return null;
        }
    }
}
