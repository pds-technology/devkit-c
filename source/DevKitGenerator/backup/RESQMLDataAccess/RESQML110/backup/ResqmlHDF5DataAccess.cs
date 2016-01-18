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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Energistics.RESQMLDataAccess.RESQML110;
using HDF5DotNet;

namespace Energistics.DataAccess.RESQML110
{

    public partial class ResqmlDocument : IH5Document
    {
        private const string DefaultSuffix = ".resqml.h5_temp";
        private string _h5Filename = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + DefaultSuffix);

        /// <summary>
        /// Filename of the HDF5 file associated with this ResqmlDocument
        /// </summary>
        [XmlIgnore]
        public string H5Filename
        {
            get { return _h5Filename; }
            set
            {
                if (_h5Filename != value)
                {
                    if (File.Exists(_h5Filename))
                    {
                        if (File.Exists(value))
                        {
                            File.Delete(value);
                        }

                        if (_h5Filename.EndsWith(DefaultSuffix))
                        {
                            File.Move(_h5Filename, value);
                        }
                        else
                        {
                            File.Copy(_h5Filename, value);
                        }
                    }

                    _h5Filename = value;
                }
            }
        }
    }

    /// <summary>
    /// Represents the data stored in RESQML Property Values
    /// </summary>
    public struct PropertyValues
    {
        /// <summary>
        /// The Type of the Property Value
        /// </summary>
        public Type PropertyType { get; set; }

        /// <summary>
        /// The array of data (of type PropertyType)
        /// </summary>
        public Array DataArray { get; set; }

        /// <summary>
        /// The value in the Data Array that represents null
        /// </summary>
        public object NullValue { get; set; }
    }

    namespace ComponentSchemas
    {
        public abstract partial class ResqmlAbstractPropertyValues
        {
            /// <summary>
            /// Reads HDF5 data
            /// </summary>
            /// <param name="doc">Parent ResqmlDocument</param>
            /// <returns>The data returned from the HDF5 document</returns>
            public PropertyValues ReadPropertyValues(ResqmlDocument doc)
            {
                return ReadPropertyValues(doc, null, null);
            }

            /// <summary>
            /// Reads HDF5 data using hyperslabbing
            /// </summary>
            /// <param name="doc">Parent ResqmlDocument</param>
            /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
            /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
            /// <returns>The data returned from the HDF5 document</returns>
            public PropertyValues ReadPropertyValues(ResqmlDocument doc, long[] start, long[] count)
            {
                PropertyValues pv = new PropertyValues();

                ResqmlHdfGroup group = (ResqmlHdfGroup)this.GetType().GetProperty("HdfRepresentation").GetValue(this, null);
                pv.PropertyType = group.ReadType(doc, null);
                MethodInfo readMethodInfo = typeof(ResqmlHdfGroup).GetMethod("Read").MakeGenericMethod(new Type[] { pv.PropertyType });
                pv.DataArray = (Array)readMethodInfo.Invoke(group, new object[] {doc, start, count, null});

                try
                {
                    MethodInfo readAttributeMethodInfo =
                        typeof(ResqmlHdfGroup).GetMethod("ReadAttributeOnDataset").MakeGenericMethod(new Type[] { pv.PropertyType });
                    pv.NullValue = readAttributeMethodInfo.Invoke(group, new object[] { doc, null, "nullValue" });
                }
                catch (TargetInvocationException ex)
                {
                    // If we get a ResqmlException, that means we couldn't find the attribute.
                    // That can be ignored, otherwise we need to throw the exception
                    if (!(ex.InnerException is ResqmlException))
                    {
                        throw ex.InnerException;
                    }
                }

                return pv;
            }
            
            /// <summary>
            /// Writes HDF5 data using hyperslabbing
            /// </summary>
            /// <param name="doc">Parent ResqmlDocument</param>
            /// <param name="pv">PropertyValues to write to the HDF5 document</param>
            public void WritePropertyValues(ResqmlDocument doc, PropertyValues pv)
            {
                WritePropertyValues(doc, pv, null, null);
            }

            /// <summary>
            /// Writes HDF5 data using hyperslabbing
            /// </summary>
            /// <param name="doc">Parent ResqmlDocument</param>
            /// <param name="pv">PropertyValues to write to the HDF5 document</param>
            /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
            /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
            public void WritePropertyValues(ResqmlDocument doc, PropertyValues pv, long[] start, long[] filespace)
            {
                if (pv.PropertyType == null)
                {
                    pv.PropertyType = pv.DataArray.GetValue(0).GetType();
                }

                if (pv.PropertyType != pv.DataArray.GetValue(0).GetType())
                {
                    throw new ResqmlException("Type of elements in PropertyValues.DataArray does not match PropertyValues.PropertyType");
                }

                ResqmlHdfGroup group = (ResqmlHdfGroup)this.GetType().GetProperty("HdfRepresentation").GetValue(this, null);

                if (group == null)
                {
                    group = new ResqmlHdfGroup();
                }

                this.GetType().GetProperty("HdfRepresentation").SetValue(this, group, null);

                MethodInfo writeMethodInfo = typeof(ResqmlHdfGroup).GetMethod("Write").MakeGenericMethod(new Type[] { pv.PropertyType });
                writeMethodInfo.Invoke(group, new object[] { doc, pv.DataArray, start, filespace, null });

                if (pv.NullValue != null)
                {
                    MethodInfo writeAttrMethodInfo = typeof (ResqmlHdfGroup).GetMethod("WriteAttributeOnDataset").MakeGenericMethod(new Type[] {pv.PropertyType});
                    writeAttrMethodInfo.Invoke(group, new object[] { doc, null, "nullValue", pv.NullValue });
                }
            }
        }

        public partial class ResqmlHdfGroup
        {
            internal Type ReadType(ResqmlDocument doc, string datasetName)
            {
                Type readType = null;

                H5DataSetId dataSetId = this.GetDataSetId(doc, null, H5F.OpenMode.ACC_RDONLY);
                H5DataTypeId dtype = H5D.getType(dataSetId);

                if (H5T.equal(dtype, H5T.copy(H5T.H5Type.NATIVE_FLOAT)))
                {
                    readType = typeof(float);
                }
                else if (H5T.equal(dtype, H5T.copy(H5T.H5Type.NATIVE_INT)))
                {
                    readType = typeof(int);
                }
                else if (H5T.equal(dtype, H5T.copy(H5T.H5Type.NATIVE_SCHAR)))
                {
                    readType = typeof(char);
                }
                else if (H5T.equal(dtype, H5T.copy(H5T.H5Type.NATIVE_SHORT)))
                {
                    readType = typeof(short);
                }
                else if (H5T.equal(dtype, H5T.copy(H5T.H5Type.NATIVE_LLONG)))
                {
                    readType = typeof(long);
                }
                else if (H5T.equal(dtype, H5T.copy(H5T.H5Type.NATIVE_DOUBLE)))
                {
                    readType = typeof(double);
                }

                H5T.close(dtype);
                H5D.close(dataSetId);

                return readType;
            }

            /// <summary>
            /// Read an attribute from a dataset
            /// </summary>
            /// <typeparam name="T">Type of attribute to read</typeparam>
            /// <param name="doc">The root RESQML document to read</param>
            /// <param name="datasetName">Name of dataset to read</param>
            /// <param name="attributeName">Name of attribute</param>
            /// <returns>Value of attribute</returns>
            public T ReadAttributeOnDataset<T>(ResqmlDocument doc, string datasetName, string attributeName)
            {
                H5DataSetId dataSetID = GetDataSetId(doc, datasetName, H5F.OpenMode.ACC_RDONLY);

                try
                {
                    int numAttrs = H5A.getNumberOfAttributes(dataSetID);
                    for (int i = 0; i < numAttrs; i++)
                    {
                        H5AttributeId attr = H5A.openIndex(dataSetID, i);
                        string currentName = H5A.getName(attr);
                        if (currentName == attributeName)
                        {
                            T[] buffer = new T[1];
                            H5Array<T> data = new H5Array<T>(buffer);
                            H5DataTypeId memTypeId = H5A.getType(attr);
                            H5A.read<T>(attr, memTypeId, data);
                            H5T.close(memTypeId);
                            H5A.close(attr);
                            return buffer[0];
                        }

                        H5A.close(attr);
                    }
                }
                finally
                {
                    H5D.close(dataSetID);
                }

                throw new ResqmlException(String.Format("Cannot find attribute {0}", attributeName));
            }

            /// <summary>
            /// Write an attribute to a dataset
            /// </summary>
            /// <typeparam name="T">Type of attribute to write</typeparam>
            /// <param name="doc">The root RESQML document to write</param>
            /// <param name="datasetName">Name of dataset to write</param>
            /// <param name="attributeName">Name of attribute</param>
            /// <param name="attrValue">Value of attribute</param>
            public void WriteAttributeOnDataset<T>(ResqmlDocument doc, string datasetName, string attributeName, T attrValue)
            {
                H5DataSetId objID = GetDataSetId(doc, datasetName, H5F.OpenMode.ACC_RDWR);

                H5AttributeId attr;
                H5DataTypeId memTypeId = GetH5Type(typeof (T));
                try
                {
                    attr = H5A.open(objID, attributeName);
                }
                catch (H5AopenException)
                {
                    attr = H5A.create(objID, attributeName, memTypeId, H5S.create_simple(1, new long[] { 1 }));
                }
                
                H5D.close(objID);

                H5Array<T> data = CreateH5Array<T>(new T[] {attrValue});

                H5A.write<T>(attr, memTypeId, data);
                H5A.close(attr);
            }

            /// <summary>
            /// Writes an array of type T to this HDF representation
            /// </summary>
            /// <typeparam name="T">Datatype to write. For compound datatypes, use a struct</typeparam>
            /// <param name="doc">The root RESQML document to write</param>
            /// <param name="array">The array of data to be written</param>
            /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
            /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
            /// <param name="datasetName">The name of the dataset to write to within this HDF5 group. If null, then writes to a dataset named, "values"</param>
            public void Write<T>(ResqmlDocument doc, Array array, long[] start, long[] filespace, string datasetName)
            {
                if (datasetName == null)
                {
                    datasetName = "values";
                }
                if (String.IsNullOrEmpty(GroupPath))
                {
                    GroupPath = "RESQML/" + Guid.NewGuid().ToString("D");
                }
                string filename = doc.H5Filename;

                H5FileId resqmlFileId;
                try
                {
                     resqmlFileId = File.Exists(filename)
                                                ? H5F.open(filename, H5F.OpenMode.ACC_RDWR)
                                                : H5F.create(filename, H5F.CreateMode.ACC_TRUNC);

                }
                catch (Exception ex)
                {
                    throw new ResqmlException(string.Format("Unable to open/create file ({0}).", filename), ex);
                }
                H5GroupId resqmlGroupId;



                try
                {
                    resqmlGroupId = H5G.open(resqmlFileId, "RESQML");
                }
                catch (H5GopenException)
                {
                    resqmlGroupId = H5G.create(resqmlFileId, "RESQML");
                }

                string subgroupstring = GroupPath.Substring(GroupPath.IndexOf("/", StringComparison.Ordinal) + 1);
                H5GroupId subGroupId;


                bool subGroupExists = false;
                
                //remove the "RESQML/" part of a subgroup name
                string subGroupStringObjectName = subgroupstring.Replace("RESQML/", "");

                //long i = 0;
                long numberOfSubGroupStrings = H5G.getNumObjects(resqmlGroupId);
                
                //check all subgroup names in for this GroupId and see if the subgroup name exists
                //this is needed because the H5G.Open method returns the same error if the group doesn't
                //exist as it does if the group is corrupt
                for (long i = 0; i < numberOfSubGroupStrings && !subGroupExists; i++)
                {
                    string objectName = H5G.getObjectNameByIndex(resqmlGroupId, (ulong) i);

                    if (objectName == subGroupStringObjectName)
                        subGroupExists = true;
                }

                if (subGroupExists)
                {
                    try
                    {
                        subGroupId = H5G.open(resqmlGroupId, subgroupstring);
                    }
                    catch (H5GopenException ex)
                    {
                        throw new ResqmlException(string.Format("Group ({0}) cannot be opened. Check the H5 file and verify that this group is not corrupt.", subgroupstring), ex);

                    }
                }
                else
                {
                    subGroupId = H5G.create(resqmlGroupId, subgroupstring);
                }

                H5DataSetId dataSetId = null;
                H5DataSpaceId fileSpaceId = null;

                long numObj = H5G.getNumObjects(subGroupId);
                for (long j = 0; j < numObj; j++)
                {
                    string name = H5G.getObjectNameByIndex(subGroupId, (ulong)j);

                    ObjectInfo oi = H5G.getObjectInfo(subGroupId, name, false);
                    if (oi.objectType == H5GType.DATASET && datasetName == name)
                    {
                        dataSetId = H5D.open(subGroupId, name);
                        fileSpaceId = H5D.getSpace(dataSetId);
                        break;
                    }
                }

                H5DataTypeId memTypeId = GetH5Type(typeof(T));

                int numDim = array.Rank;
                var dims = new long[numDim];
                dims[0] = array.GetLength(0);
                if (numDim > 1) dims[1] = array.GetLength(1);
                if (numDim > 2) dims[2] = array.GetLength(2);

                H5Array<T> data = CreateH5Array<T>(array);

                // Check to see if we have the correct parameters for hyperslabbing
                if ((start != null) && (filespace != null) && (filespace.Length == array.Rank) && (start.Length == array.Rank))
                {
                    // Allocate enough space for the entire dataset
                    if (dataSetId == null)
                    {
                        fileSpaceId = H5S.create_simple(numDim, filespace);
                        dataSetId = H5D.create(subGroupId, datasetName, memTypeId, fileSpaceId);
                    }

                    H5DataSpaceId memSpaceId = H5D.getSpace(dataSetId);
                    H5S.selectHyperslab(fileSpaceId, H5S.SelectOperator.SET, start, dims);
                    H5PropertyListId xferPropListId = H5P.create(H5P.PropertyListClass.DATASET_XFER);
                    H5D.write(dataSetId, memTypeId, memSpaceId, fileSpaceId, xferPropListId, data);
                }
                else
                {
                    // The entire data set is already availalbe, just allocate dataspace for that
                    if (dataSetId == null)
                    {
                        fileSpaceId = H5S.create_simple(numDim, dims);
                        dataSetId = H5D.create(subGroupId, datasetName, memTypeId, fileSpaceId);
                    }
                    H5D.write(dataSetId, memTypeId, data);
                }


                H5D.close(dataSetId);
                H5G.close(subGroupId);
                H5G.close(resqmlGroupId);
                H5F.close(resqmlFileId);
            }

            private static H5Array<T> CreateH5Array<T>(Array array)
            {
                H5Array<T> data = null;

                if (array.Rank == 1)
                {
                    data = new H5Array<T>((T[])array);
                }
                else if (array.Rank == 2)
                {
                    data = new H5Array<T>((T[,])array);
                }
                else if (array.Rank == 3)
                {
                    data = new H5Array<T>((T[, ,])array);
                }

                return data;
            }

            private H5DataTypeId GetH5Type(Type type)
            {
                if (type == typeof(char))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_UCHAR);
                }
                if (type == typeof(Int16))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_SHORT);
                }
                if (type == typeof(UInt16))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_USHORT);
                }
                if (type == typeof(Int32) || type.IsEnum)
                {
                    return H5T.copy(H5T.H5Type.NATIVE_INT);
                }
                if (type == typeof(UInt32))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_UINT);
                }
                if (type == typeof(Int64))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_LONG);
                }
                if (type == typeof(UInt64))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_ULONG);
                }
                if (type == typeof(float))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_FLOAT);
                }
                if (type == typeof(double))
                {
                    return H5T.copy(H5T.H5Type.NATIVE_DOUBLE);
                }
                if (type == typeof(byte))
                {
                    return H5T.copy(H5T.H5Type.STD_U8LE);
                }
                //return null;
                H5DataTypeId typeid = H5T.create(H5T.CreateClass.COMPOUND, Marshal.SizeOf(type));
                int offset = 0;
                foreach (FieldInfo fi in type.GetFields())
                {
                    H5T.insert(typeid, fi.Name, offset, GetH5Type(fi.FieldType));
                    if (fi.FieldType.IsEnum)
                    {
                        offset += sizeof(int);
                    }
                    else
                    {
                        offset += Marshal.SizeOf(fi.FieldType);
                    }
                }
                //H5T.insert(typeid,)
                return typeid;
            }

            /// <summary>
            /// Gets the dimensions of the elements of the array
            /// </summary>
            /// <param name="doc">The root RESQML document to read</param>
            /// <param name="datasetName">The name of the dataset to read from within this HDF5 group. If null, then the first dataset encountered is returned</param>
            /// <returns>An array of the dimensions of the elements of the array</returns>
            public long[] GetSimpleExtentDims(ResqmlDocument doc, string datasetName)
            {
                H5DataSetId dataSetId = GetDataSetId(doc, datasetName, H5F.OpenMode.ACC_RDONLY);
                H5DataSpaceId spaceId = H5D.getSpace(dataSetId);

                long[] dims = H5S.getSimpleExtentDims(spaceId);

                H5S.close(spaceId);
                H5D.close(dataSetId);

                return dims;
            }

            /// <summary>
            /// Read an array of type T from this HDF representation
            /// </summary>
            /// <typeparam name="T">Datatype to read. For compound datatypes, use a struct</typeparam>
            /// <param name="doc">The root RESQML document to read</param>
            /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
            /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
            /// <param name="datasetName">The name of the dataset to read from within this HDF5 group. If null, then the first dataset encountered is returned</param>
            /// <returns></returns>
            public Array Read<T>(ResqmlDocument doc, long[] start, long[] count, string datasetName)
            {
                Array dataArray;

                H5DataSetId dataSetId = GetDataSetId(doc, datasetName, H5F.OpenMode.ACC_RDONLY);

                if (dataSetId == null)
                    throw new Exception(string.Format(@"Unable to retrieve the DataSetId for DataSetName:{0}",
                      datasetName));

                H5DataTypeId dataSetTypeId = H5D.getType(dataSetId);

                if (dataSetTypeId == null)
                    throw new Exception(string.Format(@"Unable to retrieve DataSetTypeId for DataSetId:{0}",
                      dataSetId.Id));

                H5DataSpaceId spaceId = H5D.getSpace(dataSetId);

                if (spaceId == null)
                    throw new Exception(string.Format(@"Unable to retrieve SpaceId for DataSetId:{0}",
                        dataSetId.Id));

                long[] dims = H5S.getSimpleExtentDims(spaceId);

                if (dims == null)
                    throw new Exception(string.Format(@"Unable to retrieve SimpleExtentDims for SpaceId:{0}",
                      spaceId.Id));

                bool hyperslabbing = (start != null) && (count != null) && (count.Length == dims.Length) && (start.Length == dims.Length);

                if (dims.Length == 3)
                {
                    dataArray = hyperslabbing ? new T[count[0], count[1], count[2]] : new T[dims[0], dims[1], dims[2]];
                }
                else if (dims.Length == 2)
                {
                    dataArray = hyperslabbing ? new T[count[0], count[1]] : new T[dims[0], dims[1]];
                }
                else if (dims.Length == 1)
                {
                    dataArray = hyperslabbing ? new T[count[0]] : new T[dims[0]];
                }
                else
                {
                    throw new Exception("Invalid number of dimensions found in HDF5");
                }

                H5Array<T> data = CreateH5Array<T>(dataArray);
                
                if (hyperslabbing)
                {

                    //H5S.selectStridedHyperslab selects a hyperslab region to add to the current selected region for the dataspace specified by space_id. 
                    //
                    //The start, stride, count, and block arrays must be the same size as the rank of the dataspace. 
                    //
                    //The selection operator op determines how the new selection is to be combined with the already existing selection for the dataspace. The following operators are supported: 
                    //
                    //•H5S_SELECT_SET - Replaces the existing selection with the parameters from this call. Overlapping blocks are not supported with this operator. 
                    //•H5S_SELECT_OR - Adds the new selection to the existing selection. (Binary OR) 
                    //•H5S_SELECT_AND - Retains only the overlapping portions of the new selection and the existing selection. (Binary AND) 
                    //•H5S_SELECT_XOR - Retains only the elements that are members of the new selection or the existing selection, excluding elements that are members of both selections. (Binary exclusive-OR, XOR) 
                    //•H5S_SELECT_NOTB - Retains only elements of the existing selection that are not in the new selection. 
                    //•H5S_SELECT_NOTA - Retains only elements of the new selection that are not in the existing selection. 
                    //The start array determines the starting coordinates of the hyperslab to select. 
                    //
                    //The stride array chooses array locations from the dataspace with each value in the stride array determining how many elements to move in each dimension. Setting a value in the stride array to 1 moves to each element in that dimension of the dataspace; setting a value of 2 in alocation in the stride array moves to every other element in that dimension of the dataspace. In other words, the stride determines the number of elements to move from the start location in each dimension. Stride values of 0 are not allowed. 
                    //
                    //The count array determines how many blocks to select from the dataspace, in each dimension. 
                    //
                    //The block array determines the size of the element block selected from the dataspace. If the block parameter is omitted, the block size defaults to a single element in each dimension (as if the block array were set to all 1's). 
                    //
                    //For example, in a 2-dimensional dataspace, setting start to [1,1], stride to [4,4], count to [3,7], and block to [2,2] selects 21 2x2 blocks of array elements starting with location (1,1) and selecting blocks at locations (1,1), (5,1), (9,1), (1,5), (5,5), etc. 
                    //
                    //Regions selected with this function call default to C order iteration when I/O is performed. 
                    H5S.selectHyperslab(spaceId, H5S.SelectOperator.SET, start, count);

                    H5DataSpaceId memSpaceId = H5S.create_simple(dims.Length, count);
                    H5PropertyListId xferPropListId = H5P.create(H5P.PropertyListClass.DATASET_XFER);

                    H5D.read(dataSetId, //dataSetId
                             dataSetTypeId, //memTypeId
                             memSpaceId, // memSpaceId
                             spaceId, //fileSpaceId
                             xferPropListId, // xferPropListId
                             data); //data

                    H5S.close(memSpaceId);
                    H5P.close(xferPropListId);
                }
                else
                {
                    H5D.read(dataSetId, dataSetTypeId, data);
                }

                H5S.close(spaceId);
                H5T.close(dataSetTypeId);
                H5D.close(dataSetId);

                return dataArray;
            }

            internal H5DataSetId GetDataSetId(ResqmlDocument doc, string datasetName, H5F.OpenMode openMode, bool supressException = false)
            {
                string filename = doc.H5Filename;
                H5FileId resqmlFileId = H5F.open(filename, openMode);
                H5GroupId groupId = H5G.open(resqmlFileId, GroupPath);
                H5F.close(resqmlFileId);

                H5DataSetId dataSetId = null;
                List<string> existingDataSetNames = new List<string>();
                long numObj = H5G.getNumObjects(groupId);
                for (long i = 0; i < numObj; i++)
                {
                    string name = H5G.getObjectNameByIndex(groupId, (ulong)i);
                    existingDataSetNames.Add(name);
                    ObjectInfo oi = H5G.getObjectInfo(groupId, name, false);
                    if (oi.objectType == H5GType.DATASET && (datasetName == null || datasetName == name))
                    {
                        dataSetId = H5D.open(groupId, name);
                        break;
                    }
                }
                H5G.close(groupId);

                if (!supressException)
                {
                    if (dataSetId == null)
                        throw new ResqmlException(
                            string.Format(
                                @"Unable to retrieve a DataSetId from ResqmlDocument({0}) for the specified DataSetName({1}). Does the Group({2}) contain this DataSetName? The following DataSetNames were found in this group ({3}).",
                                doc.Title, datasetName, GroupPath, String.Join(", ", existingDataSetNames)));
                }

                return dataSetId;
            }
        }
    }
}
