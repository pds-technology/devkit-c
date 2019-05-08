using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDF5DotNet;
namespace DevkitTest
{
    public class HDF5Reader
    {
        public HDF5GroupObject open(string file)
        {
            if (H5F.is_hdf5(file))
            {
                int result = H5.Open();
                if (result < 0)
                {
                    Console.WriteLine("can't open the file!");
                }
                // get fildID.
                H5FileId fileID = H5F.open(file, H5F.OpenMode.ACC_RDONLY);
                //get groupid
                H5GroupId rootid = H5G.open(fileID, "/");
                HDF5GroupObject hdf5Object = new HDF5GroupObject();
                createHD5GroupObject(rootid, "/", ref hdf5Object);
                return hdf5Object;
            }
            else
            {
                Console.WriteLine("this is not HDF5 file! please try open hdf5 file again.");
                return null;
            }
        }

        private void createHD5GroupObject(H5GroupId id, String name, ref HDF5GroupObject hdf5Obj)
        {
            hdf5Obj.GroupID = id;
            hdf5Obj.GroupName = name;
           
            long num = H5G.getNumObjects(hdf5Obj.GroupID);
            // the items under the group
            for (ulong i = 0; i < (ulong)num; i++)
            {         
                String objName = H5G.getObjectNameByIndex(hdf5Obj.GroupID, i);

                // get the link info.
                //linfo = H5L.getInfo(groupID, objName);

                ObjectInfo objInfo = H5G.getObjectInfo(hdf5Obj.GroupID, objName, true);
                if (objInfo.objectType == H5GType.GROUP)
                {
                    String pathName = "/"+name+"/"+objName;
                    if (name.CompareTo("/") == 0)
                        pathName = "/" + objName;
                    H5GroupId groupID = null;
                    try
                    {
                        groupID = H5G.open(hdf5Obj.GroupID, pathName);
                        HDF5GroupObject subObj = new HDF5GroupObject();
                        subObj.ShortName = objName;
                        createHD5GroupObject(groupID, pathName, ref subObj);
                        hdf5Obj.SubGroups.Add(subObj);    
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        if(groupID!=null)
                        {
                            H5G.close(groupID);
                        }
                    }             
                }
                else
                if (objInfo.objectType == H5GType.DATASET)
                {
                    String pathName = "/" + name + "/" + objName;
                    HD5DataSetObject dataObject = new HD5DataSetObject();
                    dataObject.ShortName = objName;
                    createHD5DataObject(hdf5Obj.GroupID, pathName, ref dataObject);
                    hdf5Obj.Datasets.Add(dataObject);
                }               
            }           
        }

        private void createHD5DataObject(H5GroupId h5GroupId, string pathName, ref HD5DataSetObject dataObject)
        {
          
            H5DataSetId datasetid = null;
            H5DataSpaceId spaceid = null;
            H5DataTypeId dataTypeid = null;
            try
            {
                dataObject.GroupId = h5GroupId;
                datasetid = H5D.open(h5GroupId, pathName);
                dataObject.DatasetID = datasetid;
                dataObject.DatasetName = pathName;
                spaceid = H5D.getSpace(datasetid);
                var dims = H5S.getSimpleExtentDims(spaceid);
                dataTypeid = H5D.getType(datasetid);                
                dataObject.Dim = dims.Length; 
                HDF5DotNet.H5T.H5TClass classType = H5T.getClass(dataTypeid);
                int size = H5T.getSize(dataTypeid);
                H5T.Sign sign = H5T.Sign.TWOS_COMPLEMENT;
                if(classType == H5T.H5TClass.INTEGER)
                    sign = H5T.getSign(dataTypeid);
                //var rank = H5S.getSimpleExtentNDims(space);
                //var statu = H5S.getSimpleExtentDims(space);
                Boolean bString = H5T.isVariableString(dataTypeid);
                //String name = H5T.getMemberName(dataType, 0);
                // var type2 = H5T.getNativeType(dataType, H5T.Direction.DEFAULT);
                Type type = getTypeof(classType,size,sign);
                dataObject.DataType = type;
                dataObject.Data = readData(dataObject);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                if (datasetid != null)
                {
                    H5D.close(datasetid);
                }
                if (spaceid != null)
                    H5S.close(spaceid);
                if (dataTypeid != null)
                    H5T.close(dataTypeid);
            }   
        }

        public static Object readData(HD5DataSetObject dataObject)
        {
            H5GroupId h5GroupId = dataObject.GroupId;
            string pathName = dataObject.DatasetName;
            int dimension = dataObject.Dim;
            Type type = dataObject.DataType;
            if (dimension == 1)
            {
                if (type == typeof(UInt16))
                    return Read1DArray<UInt16>(h5GroupId, pathName);
                if (type == typeof(UInt32))
                    return Read1DArray<UInt32>(h5GroupId, pathName);
                if (type == typeof(UInt64))
                    return Read1DArray<UInt64>(h5GroupId, pathName);
                if (type == typeof(Int16))
                    return Read1DArray<Int16>(h5GroupId, pathName);
                if (type == typeof(Int32))
                    return Read1DArray<Int32>(h5GroupId, pathName);
                if (type == typeof(Int64))
                    return Read1DArray<Int64>(h5GroupId, pathName);
                if (type == typeof(float))
                    return Read1DArray<float>(h5GroupId, pathName);
                if (type == typeof(double))
                    return Read1DArray<double>(h5GroupId, pathName);
            }
            if (dimension == 2)
            {
                if (type == typeof(UInt16))
                    return Read2DArray<UInt16>(h5GroupId, pathName);
                if (type == typeof(UInt32))
                    return Read2DArray<UInt32>(h5GroupId, pathName);
                if (type == typeof(UInt64))
                    return Read2DArray<UInt64>(h5GroupId, pathName);
                if (type == typeof(Int16))
                    return Read2DArray<Int16>(h5GroupId, pathName);
                if (type == typeof(Int32))
                    return Read2DArray<Int32>(h5GroupId, pathName);
                if (type == typeof(Int64))
                    return Read2DArray<Int64>(h5GroupId, pathName);
                if (type == typeof(float))
                    return Read2DArray<float>(h5GroupId, pathName);
                if (type == typeof(double))
                    return Read2DArray<double>(h5GroupId, pathName);
            }

            if (dimension == 3)
            {
                if (type == typeof(UInt16))
                    return Read3DArray<UInt16>(h5GroupId, pathName);
                if (type == typeof(UInt32))
                    return Read3DArray<UInt32>(h5GroupId, pathName);
                if (type == typeof(UInt64))
                    return Read3DArray<UInt64>(h5GroupId, pathName);

                if (type == typeof(Int16))
                    return Read3DArray<Int16>(h5GroupId, pathName);
                if (type == typeof(Int32))
                    return Read3DArray<Int32>(h5GroupId, pathName);
                if (type == typeof(Int64))
                    return Read3DArray<Int64>(h5GroupId, pathName);
                if (type == typeof(float))
                    return Read3DArray<float>(h5GroupId, pathName);
                if (type == typeof(double))
                   return  Read3DArray<double>(h5GroupId, pathName);
            }
            return null;
        } 

        /// <summary>
        /// this still need to improve later.
        /// </summary>
        /// <param name="classType"></param>
        /// <param name="size"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        private Type getTypeof(H5T.H5TClass classType,int size,H5T.Sign sign)
        {
            if (sign == H5T.Sign.UNSIGNED)
            {
                if (classType == H5T.H5TClass.INTEGER)
                    if (size == 2)
                        return typeof(UInt16);
                    else if (size == 4)
                        return typeof(UInt32);
                    else if (size == 8)
                        return typeof(UInt64);
                // remain the same
                if (classType == H5T.H5TClass.FLOAT)
                    if (size == 4)
                        return typeof(float);
                    else if (size == 8)
                        return typeof(double);
            }
            else
            {
                if (classType == H5T.H5TClass.INTEGER)
                    if (size == 2)
                        return typeof(Int16);
                    else if (size == 4)
                        return typeof(Int32);
                    else if (size == 8)
                        return typeof(Int64);
                if (classType == H5T.H5TClass.FLOAT)
                    if (size == 4)
                        return typeof(float);
                    else if (size == 8)
                        return typeof(double);
                if (classType == H5T.H5TClass.STRING)
                    return typeof(String);
                if (classType == H5T.H5TClass.ENUM)
                    return typeof(Enum);
                if (classType == H5T.H5TClass.BITFIELD)
                    return typeof(Boolean);
                if (classType == H5T.H5TClass.ARRAY)
                    return typeof(Array);
                if (classType == H5T.H5TClass.COMPOUND)
                    return typeof(Object);
            }
            return null;

        }

     
        private static T[] Read1DArray<T>(H5GroupId fileId, string dataSetName)
        {
            var dataset = H5D.open(fileId, dataSetName);
            var space = H5D.getSpace(dataset);
            var dims = H5S.getSimpleExtentDims(space);
            var dataType = H5D.getType(dataset);
             T[] dataArray = null;
            if (typeof(T) == typeof(string))
            {
                // this will also need a string hack...
                dataArray = new T[dims[0]];
             H5D.close(dataset);
                return dataArray;
            }
            else
            {
                dataArray = new T[dims[0]];
                var wrapArray = new H5Array<T>(dataArray);
                H5D.read(dataset, dataType, wrapArray);
                H5D.close(dataset);
                return dataArray;
            }

        }

        private static T[,] Read2DArray<T>(H5GroupId fileId, string dataSetName)
        {
            var dataset = H5D.open(fileId, dataSetName);
            var space = H5D.getSpace(dataset);
            var dims = H5S.getSimpleExtentDims(space);
            var dataType = H5D.getType(dataset);

            if (typeof(T) == typeof(string))
            {
                // this will also need a string hack...
                T[,] dataArray = new T[dims[0], 2];
                return dataArray;
            }
            else
            {
                T[,] dataArray = new T[dims[0], dims[1]];
                var wrapArray = new H5Array<T>(dataArray);
                H5D.read(dataset, dataType, wrapArray);
                return dataArray;
            }
        }

        private static T[, ,] Read3DArray<T>(H5GroupId groupID, string name)
        {
            var dataset = H5D.open(groupID, name);
            var space = H5D.getSpace(dataset);
            var dims = H5S.getSimpleExtentDims(space);
            var dataType = H5D.getType(dataset);


            if (typeof(T) == typeof(string))
            {
                // this will also need a string hack...
                T[, ,] dataArray = new T[dims[0], 0, 0];
                return dataArray;
            }
            else
            {
                T[, ,] dataArray = new T[dims[0], dims[1], dims[2]];
                var wrapArray = new H5Array<T>(dataArray);
                H5D.read(dataset, dataType, wrapArray);
                return dataArray;
            }
        }

    }
}
