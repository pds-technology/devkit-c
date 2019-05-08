using HDF5DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevkitTest
{
    public class HD5DataSetObject
    {
        private H5DataSetId datasetID = null;

        public H5DataSetId DatasetID
        {
            get { return datasetID; }
            set { datasetID = value; }
        }
        private String datasetName;

        public String DatasetName
        {
            get { return datasetName; }
            set { datasetName = value; }
        }

        public H5GroupId GroupId { get; set; }
        public int Dim { get; set; }

        public Type DataType { get; set; }

        public string ShortName { get; set; } 
        private Object dataValue = null;
        public Object Data
        {
            get
            {
                if ((datasetID == null) || (datasetName == null) || (DataType == null)) return null;
                if (dataValue == null)
                {
                    dataValue = HDF5Reader.readData(this);
                }
                return dataValue;
            }
            set
            {
                dataValue = value;
            }
        }
    }
}
