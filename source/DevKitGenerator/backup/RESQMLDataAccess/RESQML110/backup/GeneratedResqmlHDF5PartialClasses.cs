

using System;

namespace Energistics.DataAccess.RESQML110.ComponentSchemas
{
    public partial class ResqmlSplitNodeSet : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadIjkGridHdfGroup(ResqmlDocument doc)
        {
            return this.ReadIjkGridHdfGroup(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadIjkGridHdfGroup(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Point3D[])this.IjkGridHdfGroup.Read<Point3D>(doc, start, count, null);
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteIjkGridHdfGroup(ResqmlDocument doc, Point3D[] obj)
        {
            this.WriteIjkGridHdfGroup(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteIjkGridHdfGroup(ResqmlDocument doc, Point3D[] obj, long[] start, long[] filespace)
        {
		    if (this.IjkGridHdfGroup == null) 
			{
			    this.IjkGridHdfGroup = new ResqmlHdfGroup();
			}
            this.IjkGridHdfGroup.Write<Point3D>(doc, obj, start, filespace, null);
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistIjkGridHdfGroup(ResqmlDocument doc)
        {
            if (this.IjkGridHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.IjkGridHdfGroup.GetDataSetId(doc, null, HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlTriangulatedPatch : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadPoint3dSet(ResqmlDocument doc)
        {
            return this.ReadPoint3dSet(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadPoint3dSet(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Point3D[])this.TriangulatedHdfGroup.Read<Point3D>(doc, start, count, "point3dSet");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WritePoint3dSet(ResqmlDocument doc, Point3D[] obj)
        {
            this.WritePoint3dSet(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WritePoint3dSet(ResqmlDocument doc, Point3D[] obj, long[] start, long[] filespace)
        {
		    if (this.TriangulatedHdfGroup == null) 
			{
			    this.TriangulatedHdfGroup = new ResqmlHdfGroup();
			}
            this.TriangulatedHdfGroup.Write<Point3D>(doc, obj, start, filespace, "point3dSet");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistPoint3dSet(ResqmlDocument doc)
        {
            if (this.TriangulatedHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.TriangulatedHdfGroup.GetDataSetId(doc, "point3dSet", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlTriangulatedPatch : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Triangle[] ReadTriangleNodeIndexSet(ResqmlDocument doc)
        {
            return this.ReadTriangleNodeIndexSet(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Triangle[] ReadTriangleNodeIndexSet(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Triangle[])this.TriangulatedHdfGroup.Read<Triangle>(doc, start, count, "triangleNodeIndexSet");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteTriangleNodeIndexSet(ResqmlDocument doc, Triangle[] obj)
        {
            this.WriteTriangleNodeIndexSet(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteTriangleNodeIndexSet(ResqmlDocument doc, Triangle[] obj, long[] start, long[] filespace)
        {
		    if (this.TriangulatedHdfGroup == null) 
			{
			    this.TriangulatedHdfGroup = new ResqmlHdfGroup();
			}
            this.TriangulatedHdfGroup.Write<Triangle>(doc, obj, start, filespace, "triangleNodeIndexSet");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistTriangleNodeIndexSet(ResqmlDocument doc)
        {
            if (this.TriangulatedHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.TriangulatedHdfGroup.GetDataSetId(doc, "triangleNodeIndexSet", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlTriangulatedPatch : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Edge[] ReadSplitEdgeNodeIndexSet(ResqmlDocument doc)
        {
            return this.ReadSplitEdgeNodeIndexSet(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Edge[] ReadSplitEdgeNodeIndexSet(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Edge[])this.TriangulatedHdfGroup.Read<Edge>(doc, start, count, "splitEdgeNodeIndexSet");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteSplitEdgeNodeIndexSet(ResqmlDocument doc, Edge[] obj)
        {
            this.WriteSplitEdgeNodeIndexSet(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteSplitEdgeNodeIndexSet(ResqmlDocument doc, Edge[] obj, long[] start, long[] filespace)
        {
		    if (this.TriangulatedHdfGroup == null) 
			{
			    this.TriangulatedHdfGroup = new ResqmlHdfGroup();
			}
            this.TriangulatedHdfGroup.Write<Edge>(doc, obj, start, filespace, "splitEdgeNodeIndexSet");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistSplitEdgeNodeIndexSet(ResqmlDocument doc)
        {
            if (this.TriangulatedHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.TriangulatedHdfGroup.GetDataSetId(doc, "splitEdgeNodeIndexSet", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlPointSetPatch : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadPointSetHdfGroup(ResqmlDocument doc)
        {
            return this.ReadPointSetHdfGroup(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadPointSetHdfGroup(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Point3D[])this.PointSetHdfGroup.Read<Point3D>(doc, start, count, null);
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WritePointSetHdfGroup(ResqmlDocument doc, Point3D[] obj)
        {
            this.WritePointSetHdfGroup(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WritePointSetHdfGroup(ResqmlDocument doc, Point3D[] obj, long[] start, long[] filespace)
        {
		    if (this.PointSetHdfGroup == null) 
			{
			    this.PointSetHdfGroup = new ResqmlHdfGroup();
			}
            this.PointSetHdfGroup.Write<Point3D>(doc, obj, start, filespace, null);
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistPointSetHdfGroup(ResqmlDocument doc)
        {
            if (this.PointSetHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.PointSetHdfGroup.GetDataSetId(doc, null, HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlAbstractIJKGrid : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[,] ReadExplicitNodeList(ResqmlDocument doc)
        {
            return this.ReadExplicitNodeList(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[,] ReadExplicitNodeList(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Point3D[,])this.IjkGridHdfGroup.Read<Point3D>(doc, start, count, "explicitNodeList");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteExplicitNodeList(ResqmlDocument doc, Point3D[,] obj)
        {
            this.WriteExplicitNodeList(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteExplicitNodeList(ResqmlDocument doc, Point3D[,] obj, long[] start, long[] filespace)
        {
		    if (this.IjkGridHdfGroup == null) 
			{
			    this.IjkGridHdfGroup = new ResqmlHdfGroup();
			}
            this.IjkGridHdfGroup.Write<Point3D>(doc, obj, start, filespace, "explicitNodeList");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistExplicitNodeList(ResqmlDocument doc)
        {
            if (this.IjkGridHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.IjkGridHdfGroup.GetDataSetId(doc, "explicitNodeList", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlAbstractIJKGrid : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public SplitLineReference[] ReadSplitLineReferences(ResqmlDocument doc)
        {
            return this.ReadSplitLineReferences(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public SplitLineReference[] ReadSplitLineReferences(ResqmlDocument doc, long[] start, long[] count)
        {
            return (SplitLineReference[])this.IjkGridHdfGroup.Read<SplitLineReference>(doc, start, count, "splitLineReferences");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteSplitLineReferences(ResqmlDocument doc, SplitLineReference[] obj)
        {
            this.WriteSplitLineReferences(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteSplitLineReferences(ResqmlDocument doc, SplitLineReference[] obj, long[] start, long[] filespace)
        {
		    if (this.IjkGridHdfGroup == null) 
			{
			    this.IjkGridHdfGroup = new ResqmlHdfGroup();
			}
            this.IjkGridHdfGroup.Write<SplitLineReference>(doc, obj, start, filespace, "splitLineReferences");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistSplitLineReferences(ResqmlDocument doc)
        {
            if (this.IjkGridHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.IjkGridHdfGroup.GetDataSetId(doc, "splitLineReferences", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlAbstractIJKGrid : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public byte[,,] ReadTopologyFlags(ResqmlDocument doc)
        {
            return this.ReadTopologyFlags(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public byte[,,] ReadTopologyFlags(ResqmlDocument doc, long[] start, long[] count)
        {
            return (byte[,,])this.IjkGridHdfGroup.Read<byte>(doc, start, count, "topologyFlags");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteTopologyFlags(ResqmlDocument doc, byte[,,] obj)
        {
            this.WriteTopologyFlags(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteTopologyFlags(ResqmlDocument doc, byte[,,] obj, long[] start, long[] filespace)
        {
		    if (this.IjkGridHdfGroup == null) 
			{
			    this.IjkGridHdfGroup = new ResqmlHdfGroup();
			}
            this.IjkGridHdfGroup.Write<byte>(doc, obj, start, filespace, "topologyFlags");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistTopologyFlags(ResqmlDocument doc)
        {
            if (this.IjkGridHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.IjkGridHdfGroup.GetDataSetId(doc, "topologyFlags", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlAbstractIJKGrid : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public SplitNodeReference[] ReadSplitNodeReferences(ResqmlDocument doc)
        {
            return this.ReadSplitNodeReferences(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public SplitNodeReference[] ReadSplitNodeReferences(ResqmlDocument doc, long[] start, long[] count)
        {
            return (SplitNodeReference[])this.IjkGridHdfGroup.Read<SplitNodeReference>(doc, start, count, "splitNodeReferences");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteSplitNodeReferences(ResqmlDocument doc, SplitNodeReference[] obj)
        {
            this.WriteSplitNodeReferences(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteSplitNodeReferences(ResqmlDocument doc, SplitNodeReference[] obj, long[] start, long[] filespace)
        {
		    if (this.IjkGridHdfGroup == null) 
			{
			    this.IjkGridHdfGroup = new ResqmlHdfGroup();
			}
            this.IjkGridHdfGroup.Write<SplitNodeReference>(doc, obj, start, filespace, "splitNodeReferences");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistSplitNodeReferences(ResqmlDocument doc)
        {
            if (this.IjkGridHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.IjkGridHdfGroup.GetDataSetId(doc, "splitNodeReferences", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlAbstractIJKGrid : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadSplitNodes(ResqmlDocument doc)
        {
            return this.ReadSplitNodes(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[] ReadSplitNodes(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Point3D[])this.IjkGridHdfGroup.Read<Point3D>(doc, start, count, "splitNodes");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteSplitNodes(ResqmlDocument doc, Point3D[] obj)
        {
            this.WriteSplitNodes(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteSplitNodes(ResqmlDocument doc, Point3D[] obj, long[] start, long[] filespace)
        {
		    if (this.IjkGridHdfGroup == null) 
			{
			    this.IjkGridHdfGroup = new ResqmlHdfGroup();
			}
            this.IjkGridHdfGroup.Write<Point3D>(doc, obj, start, filespace, "splitNodes");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistSplitNodes(ResqmlDocument doc)
        {
            if (this.IjkGridHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.IjkGridHdfGroup.GetDataSetId(doc, "splitNodes", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlPillarSetPatch : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[,] ReadPillarSet(ResqmlDocument doc)
        {
            return this.ReadPillarSet(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public Point3D[,] ReadPillarSet(ResqmlDocument doc, long[] start, long[] count)
        {
            return (Point3D[,])this.PillarSetHdfGroup.Read<Point3D>(doc, start, count, "pillarSet");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WritePillarSet(ResqmlDocument doc, Point3D[,] obj)
        {
            this.WritePillarSet(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WritePillarSet(ResqmlDocument doc, Point3D[,] obj, long[] start, long[] filespace)
        {
		    if (this.PillarSetHdfGroup == null) 
			{
			    this.PillarSetHdfGroup = new ResqmlHdfGroup();
			}
            this.PillarSetHdfGroup.Write<Point3D>(doc, obj, start, filespace, "pillarSet");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistPillarSet(ResqmlDocument doc)
        {
            if (this.PillarSetHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.PillarSetHdfGroup.GetDataSetId(doc, "pillarSet", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlIJKNonStandardAdjacency : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public GridIJKCellFacePair[] ReadHdfRepresentation(ResqmlDocument doc)
        {
            return this.ReadHdfRepresentation(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public GridIJKCellFacePair[] ReadHdfRepresentation(ResqmlDocument doc, long[] start, long[] count)
        {
            return (GridIJKCellFacePair[])this.HdfRepresentation.Read<GridIJKCellFacePair>(doc, start, count, null);
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteHdfRepresentation(ResqmlDocument doc, GridIJKCellFacePair[] obj)
        {
            this.WriteHdfRepresentation(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteHdfRepresentation(ResqmlDocument doc, GridIJKCellFacePair[] obj, long[] start, long[] filespace)
        {
		    if (this.HdfRepresentation == null) 
			{
			    this.HdfRepresentation = new ResqmlHdfGroup();
			}
            this.HdfRepresentation.Write<GridIJKCellFacePair>(doc, obj, start, filespace, null);
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistHdfRepresentation(ResqmlDocument doc)
        {
            if (this.HdfRepresentation == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.HdfRepresentation.GetDataSetId(doc, null, HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlGrid2dPatch : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public double[,] ReadZValueSet(ResqmlDocument doc)
        {
            return this.ReadZValueSet(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public double[,] ReadZValueSet(ResqmlDocument doc, long[] start, long[] count)
        {
            return (double[,])this.Grid2dHdfGroup.Read<double>(doc, start, count, "zValueSet");
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteZValueSet(ResqmlDocument doc, double[,] obj)
        {
            this.WriteZValueSet(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteZValueSet(ResqmlDocument doc, double[,] obj, long[] start, long[] filespace)
        {
		    if (this.Grid2dHdfGroup == null) 
			{
			    this.Grid2dHdfGroup = new ResqmlHdfGroup();
			}
            this.Grid2dHdfGroup.Write<double>(doc, obj, start, filespace, "zValueSet");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistZValueSet(ResqmlDocument doc)
        {
            if (this.Grid2dHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.Grid2dHdfGroup.GetDataSetId(doc, "zValueSet", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
    public partial class ResqmlExplicitNodeSet : Object
    {
        /// <summary>
        /// Reads HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public int[,,] ReadIjkGridHdfGroup(ResqmlDocument doc)
        {
            return this.ReadIjkGridHdfGroup(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
		/// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="count">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public int[,,] ReadIjkGridHdfGroup(ResqmlDocument doc, long[] start, long[] count)
        {
            return (int[,,])this.IjkGridHdfGroup.Read<int>(doc, start, count, null);
        }

		/// <summary>
        /// Writes HDF5 data
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>        
		public void WriteIjkGridHdfGroup(ResqmlDocument doc, int[,,] obj)
        {
            this.WriteIjkGridHdfGroup(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <param name="obj">Object to write</param>
        /// <param name="start">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name="filespace">Total size to allot for the data within the HDF5 file</param>
		public void WriteIjkGridHdfGroup(ResqmlDocument doc, int[,,] obj, long[] start, long[] filespace)
        {
		    if (this.IjkGridHdfGroup == null) 
			{
			    this.IjkGridHdfGroup = new ResqmlHdfGroup();
			}
            this.IjkGridHdfGroup.Write<int>(doc, obj, start, filespace, null);
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name="doc">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExistIjkGridHdfGroup(ResqmlDocument doc)
        {
            if (this.IjkGridHdfGroup == null) return false;
            HDF5DotNet.H5DataSetId dataId = this.IjkGridHdfGroup.GetDataSetId(doc, null, HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);

			if (dataId == null) 
			{
			    return false;
			}
			else
			{
				HDF5DotNet.H5D.close(dataId);
			    return true;
			}
        }
    }
}