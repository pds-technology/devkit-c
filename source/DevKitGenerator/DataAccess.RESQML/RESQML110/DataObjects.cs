
//This code was generated using the Energistics Generator tool.  Direct changes to this code will be lost
//during regeneration.

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using Energistics.DataAccess.RESQML110.ComponentSchemas;
using Energistics.DataAccess.RESQML110.ReferenceData;
using Energistics.DataAccess.Reflection;
using Energistics.DataAccess.Validation;

namespace Energistics.DataAccess.RESQML110
{
    #region Classes
    /// <summary>
    /// This class represents the abstractObject xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlDocumentList))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/schemas/abstract")]
    [System.Xml.Serialization.XmlRootAttribute("abstractDataObject", Namespace="http://www.energistics.org/schemas/abstract", IsNullable=false)]
	[Description("This class represents the abstractObject xsd type.")]
    public abstract partial class AbstractObject : Object, INotifyPropertyChanged
    {


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_customData xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_customData", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the cs_customData xsd type.")]
    public partial class CustomData : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Any property
        /// </summary>
		[RecurringElement]
		[XmlAnyElement]
        public List<XmlElement> Any {
            get {
                return AnyField;
            } 
            set {
                AnyField = value;
                NotifyPropertyChanged("Any");
            }
        }

         /// <summary>
         /// bool to indicate if Any has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AnySpecified
         {
             get {
             if(AnyField!=null)
                 return AnyField.Count>0?true:false;
             else return false;
             }
         }
        private List<XmlElement> AnyField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A single split node index description. The node is at one corner of a cell.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlSplitNodeReference", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A single split node index description. The node is at one corner of a cell.")]
    public partial class ResqmlSplitNodeReference : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The I direction cell coordinate for a column of cells. Minimum value of startIndexI. Maximum value of ni+startIndexI-1.
        /// </summary>
		[Required]
        [Description("The I direction cell coordinate for a column of cells.  Minimum value of startIndexI.  Maximum value of ni+startIndexI-1.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("i")]
        public int? I {
            get {
                return iField;
            } 
            set {
                iField = value;
                NotifyPropertyChanged("I");
            }
        }

        private int? iField; 

        /// <summary>
        /// The I direction cell coordinate for a column of cells. Minimum value of startIndexJ. Maximum value of nj+startIndexJ-1.
        /// </summary>
		[Required]
        [Description("The I direction cell coordinate for a column of cells. Minimum value of startIndexJ.  Maximum value of nj+startIndexJ-1.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("j")]
        public int? J {
            get {
                return jField;
            } 
            set {
                jField = value;
                NotifyPropertyChanged("J");
            }
        }

        private int? jField; 

        /// <summary>
        /// The K direction cell coordinate for a column of cells. Minimum value of startIndexK. Maximum value of nj+startIndexK-1.
        /// </summary>
		[Required]
        [Description("The K direction cell coordinate for a column of cells. Minimum value of startIndexK.  Maximum value of nj+startIndexK-1.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("k")]
        public int? K {
            get {
                return kField;
            } 
            set {
                kField = value;
                NotifyPropertyChanged("K");
            }
        }

        private int? kField; 

        /// <summary>
        /// The I direction corner coordinate for a node within a column of cells.
        /// </summary>
		[Required]
        [Range(0, 1)]
        [Description("The I direction corner coordinate for a node within a column of cells.")]
        [EnergisticsDataTypeAttribute(DataType = "zeroOrOneShort")]
		[XmlElement("iCorn")]
        public short? ICorn {
            get {
                return iCornField;
            } 
            set {
                iCornField = value;
                NotifyPropertyChanged("ICorn");
            }
        }

        private short? iCornField; 

        /// <summary>
        /// The J direction corner coordinate for a node within a column of cells.
        /// </summary>
		[Required]
        [Range(0, 1)]
        [Description("The J direction corner coordinate for a node within a column of cells.")]
        [EnergisticsDataTypeAttribute(DataType = "zeroOrOneShort")]
		[XmlElement("jCorn")]
        public short? JCorn {
            get {
                return jCornField;
            } 
            set {
                jCornField = value;
                NotifyPropertyChanged("JCorn");
            }
        }

        private short? jCornField; 

        /// <summary>
        /// The K direction corner coordinate for a node within a column of cells.
        /// </summary>
		[Required]
        [Range(0, 1)]
        [Description("The K direction corner coordinate for a node within a column of cells.")]
        [EnergisticsDataTypeAttribute(DataType = "zeroOrOneShort")]
		[XmlElement("kCorn")]
        public short? KCorn {
            get {
                return kCornField;
            } 
            set {
                kCornField = value;
                NotifyPropertyChanged("KCorn");
            }
        }

        private short? kCornField; 

        /// <summary>
        /// A 0-based index into the additional split node list. A value of zero represents the first additional node.
        /// </summary>
		[Required]
        [Description("A 0-based index into the additional split node list. A value of zero represents the first additional node.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("reference")]
        public int? Reference {
            get {
                return referenceField;
            } 
            set {
                referenceField = value;
                NotifyPropertyChanged("Reference");
            }
        }

        private int? referenceField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the 3D coordinates for each split node. Each node may represent part of an 8-way split.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlSplitNodeSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the 3D coordinates for each split node. Each node may represent part of an 8-way split.")]
    public partial class ResqmlSplitNodeSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the index locations of one referenced split node. The reference value refers to the order in point3dSet. If you set this property, you must also set SplitNodeSet.
        /// </summary>
        [ComponentElement]
        [XmlElement("splitNodeReference")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlSplitNodeReference")]
        public ResqmlSplitNodeReference[] SplitNodeReference {
            get {
                return splitNodeReferenceField;
            } 
            set {
                if (value != null && IjkGridHdfGroupSpecified) throw new Exception("Cannot set property SplitNodeReference when property IjkGridHdfGroup is already set");
                splitNodeReferenceField = value;
                SplitNodeReferenceSpecified = (value!=null);
                NotifyPropertyChanged("SplitNodeReference");
            }
        }

        private ResqmlSplitNodeReference[] splitNodeReferenceField; 
        private bool splitNodeReferenceSpecified = false; 

        /// <summary>
        /// bool to indicate if SplitNodeReference has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SplitNodeReferenceSpecified
        {
            get {
                return splitNodeReferenceSpecified;
            }
            set {
                splitNodeReferenceSpecified= value;
            }
        }

        /// <summary>
        /// A set of points that are split. There must be splitNodeCount points in the aggregate. If you set this property, you must also set SplitNodeReference.
        /// </summary>
        [ComponentElement]
        [XmlElement("splitNodeSet")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPoint3dSet")]
        public ResqmlPoint3dSet SplitNodeSet {
            get {
                return splitNodeSetField;
            } 
            set {
                if (value != null && IjkGridHdfGroupSpecified) throw new Exception("Cannot set property SplitNodeSet when property IjkGridHdfGroup is already set");
                splitNodeSetField = value;
                SplitNodeSetSpecified = (value!=null);
                NotifyPropertyChanged("SplitNodeSet");
            }
        }

        private ResqmlPoint3dSet splitNodeSetField; 
        private bool splitNodeSetSpecified = false; 

        /// <summary>
        /// bool to indicate if SplitNodeSet has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SplitNodeSetSpecified
        {
            get {
                return splitNodeSetSpecified;
            }
            set {
                splitNodeSetSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("ijkGridHdfGroup")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup IjkGridHdfGroup {
            get {
                return ijkGridHdfGroupField;
            } 
            set {
                if (value != null && SplitNodeReferenceSpecified) throw new Exception("Cannot set property IjkGridHdfGroup when property SplitNodeReference is already set");
                if (value != null && SplitNodeSetSpecified) throw new Exception("Cannot set property IjkGridHdfGroup when property SplitNodeSet is already set");
                ijkGridHdfGroupField = value;
                IjkGridHdfGroupSpecified = (value!=null);
                NotifyPropertyChanged("IjkGridHdfGroup");
            }
        }

        private ResqmlHdfGroup ijkGridHdfGroupField; 
        private bool ijkGridHdfGroupSpecified = false; 

        /// <summary>
        /// bool to indicate if IjkGridHdfGroup has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IjkGridHdfGroupSpecified
        {
            get {
                return ijkGridHdfGroupSpecified;
            }
            set {
                ijkGridHdfGroupSpecified= value;
            }
        }



        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines information relative to the array values in an HDF file.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlHdfGroup", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines information relative to the array values in an HDF file.")]
    public partial class ResqmlHdfGroup : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the internal path to data group inside an HDF5 formatted file. The hdf file name is the name of the XML message file (including extension) with an extension of ".h5". in the same folder with the XML message file.
        /// </summary>
		[Required]
        [StringLength(4000)]
        [Description("Defines the internal path to data group inside an HDF5 formatted file. The hdf file name is the name of the XML message file (including extension) with an extension of \".h5\". in the same folder with the XML message file.")]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
		[XmlElement("groupPath", DataType="anyURI")]
        public string GroupPath {
            get {
                return groupPathField;
            } 
            set {
                groupPathField = value;
                NotifyPropertyChanged("GroupPath");
            }
        }

        private string groupPathField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of points defined in 3 dimensional space.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPoint3dSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of points defined in 3 dimensional space.")]
    public partial class ResqmlPoint3dSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the x,y,z coordinates of one vertex.
        /// </summary>
		[Required]
        [Description("Defines the x,y,z coordinates of one vertex.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "point3d")]
		[XmlElement("vrtx")]
        public List<Point3d> Vrtx {
            get {
                return vrtxField;
            } 
            set {
                vrtxField = value;
                NotifyPropertyChanged("Vrtx");
            }
        }

         /// <summary>
         /// bool to indicate if Vrtx has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool VrtxSpecified
         {
             get {
             if(vrtxField!=null)
                 return vrtxField.Count>0?true:false;
             else return false;
             }
         }
        private List<Point3d> vrtxField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the point3d xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="point3d", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the point3d xsd type.")]
    public partial class Point3d : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// x property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "double")]
        [XmlAttribute("x")]
		
        public double X {
            get {
                return xField;
            } 
            set {
                xField = value;
                NotifyPropertyChanged("X");
            }
        }

        private double xField; 

		/// <summary>
        /// y property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "double")]
        [XmlAttribute("y")]
		
        public double Y {
            get {
                return yField;
            } 
            set {
                yField = value;
                NotifyPropertyChanged("Y");
            }
        }

        private double yField; 

		/// <summary>
        /// z property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "double")]
        [XmlAttribute("z")]
		
        public double Z {
            get {
                return zField;
            } 
            set {
                zField = value;
                NotifyPropertyChanged("Z");
            }
        }

        private double zField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A single split line index description. The line is at one corner of a cell.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlSplitLineReference", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A single split line index description. The line is at one corner of a cell.")]
    public partial class ResqmlSplitLineReference : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The I direction cell coordinate for a column of cells. Minimum value of startIndexI. Maximum value of ni+startIndexI-1.
        /// </summary>
		[Required]
        [Description("The I direction cell coordinate for a column of cells.  Minimum value of startIndexI.  Maximum value of ni+startIndexI-1.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("i")]
        public int? I {
            get {
                return iField;
            } 
            set {
                iField = value;
                NotifyPropertyChanged("I");
            }
        }

        private int? iField; 

        /// <summary>
        /// The I direction cell coordinate for a column of cells. Minimum value of startIndexJ. Maximum value of nj+startIndexJ-1.
        /// </summary>
		[Required]
        [Description("The I direction cell coordinate for a column of cells. Minimum value of startIndexJ.  Maximum value of nj+startIndexJ-1.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("j")]
        public int? J {
            get {
                return jField;
            } 
            set {
                jField = value;
                NotifyPropertyChanged("J");
            }
        }

        private int? jField; 

        /// <summary>
        /// The I direction corner coordinate for a coordinate line within a column of cells.
        /// </summary>
		[Required]
        [Range(0, 1)]
        [Description("The I direction corner coordinate for a coordinate line within a column of cells.")]
        [EnergisticsDataTypeAttribute(DataType = "zeroOrOneShort")]
		[XmlElement("iCorn")]
        public short? ICorn {
            get {
                return iCornField;
            } 
            set {
                iCornField = value;
                NotifyPropertyChanged("ICorn");
            }
        }

        private short? iCornField; 

        /// <summary>
        /// The J direction corner coordinate for a coordinate line within a column of cells.
        /// </summary>
		[Required]
        [Range(0, 1)]
        [Description("The J direction corner coordinate for a coordinate line within a column of cells.")]
        [EnergisticsDataTypeAttribute(DataType = "zeroOrOneShort")]
		[XmlElement("jCorn")]
        public short? JCorn {
            get {
                return jCornField;
            } 
            set {
                jCornField = value;
                NotifyPropertyChanged("JCorn");
            }
        }

        private short? jCornField; 

        /// <summary>
        /// A 0-based index into the coordinate line list. A value of zero represents the first line in the line list.
        /// </summary>
		[Required]
        [Description("A 0-based index into the coordinate line list. A value of zero represents the first line in the line list.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("reference")]
        public int? Reference {
            get {
                return referenceField;
            } 
            set {
                referenceField = value;
                NotifyPropertyChanged("Reference");
            }
        }

        private int? referenceField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines explicit nodes on coordinate lines.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlExplicitNodeSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines explicit nodes on coordinate lines.")]
    public partial class ResqmlExplicitNodeSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the index locations of one additional (split) coordinate line. The reference value refers to the order in the lineSet aggregate. If you set this property, you must also set LineSet.
        /// </summary>
        [ComponentElement]
        [XmlElement("splitLineReference")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlSplitLineReference")]
        public ResqmlSplitLineReference[] SplitLineReference {
            get {
                return splitLineReferenceField;
            } 
            set {
                if (value != null && IjkGridHdfGroupSpecified) throw new Exception("Cannot set property SplitLineReference when property IjkGridHdfGroup is already set");
                splitLineReferenceField = value;
                SplitLineReferenceSpecified = (value!=null);
                NotifyPropertyChanged("SplitLineReference");
            }
        }

        private ResqmlSplitLineReference[] splitLineReferenceField; 
        private bool splitLineReferenceSpecified = false; 

        /// <summary>
        /// bool to indicate if SplitLineReference has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SplitLineReferenceSpecified
        {
            get {
                return splitLineReferenceSpecified;
            }
            set {
                splitLineReferenceSpecified= value;
            }
        }

        /// <summary>
        /// Defines a set of node points on coordinate lines, organized by layer. There are "nk+gapCount+1" layers of nodes. Each layer has "(NI+1)*(NJ+1)+splitLineCount" node points. Here gapCount is the number of k layer gaps and splitLineCount is the number of additional DISTINCT lines. This data ordering facilitates K-slabbing of data sets and is shared between the XML and the HDF representations. In a layer, the first "(NI+1)*(NJ+1)" nodes are shared between columns of adjacent cells unless otherwise indicated. The lines are ordered according to a zero-based line_index defined by: (I-startIndexI)+(NI+1)*(J-startIndexJ) where I = I direction line coordinate for a column of cells. Minimum value=startIndexI, count=NI+1. J = J direction line coordinate for a column of cells. Minimum value=startIndexJ, count=NJ+1. The line I corresponds to the ICORN=0 side of cell I, and so the count of I is NI+1; Similarly for J. The next splitLineCount nodes are placed on the additional lines as indicated by the splitLineReferences in the order defined by the reference element in splitLineReference. The first additional line will be located at (NI+1)*(NJ+1) (assuming a zero-based index). There must be nk+gapCount+1 nodes on each line. For a line whose kind is "null" the values should be "NaN". For the additional lines, the line kind will never be "null". . If you set this property, you must also set SplitLineReference.
        /// </summary>
        [ComponentElement]
        [XmlElement("lineSet")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPoint3dSet")]
        public ResqmlPoint3dSet LineSet {
            get {
                return lineSetField;
            } 
            set {
                if (value != null && IjkGridHdfGroupSpecified) throw new Exception("Cannot set property LineSet when property IjkGridHdfGroup is already set");
                lineSetField = value;
                LineSetSpecified = (value!=null);
                NotifyPropertyChanged("LineSet");
            }
        }

        private ResqmlPoint3dSet lineSetField; 
        private bool lineSetSpecified = false; 

        /// <summary>
        /// bool to indicate if LineSet has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool LineSetSpecified
        {
            get {
                return lineSetSpecified;
            }
            set {
                lineSetSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("ijkGridHdfGroup")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup IjkGridHdfGroup {
            get {
                return ijkGridHdfGroupField;
            } 
            set {
                if (value != null && LineSetSpecified) throw new Exception("Cannot set property IjkGridHdfGroup when property LineSet is already set");
                if (value != null && SplitLineReferenceSpecified) throw new Exception("Cannot set property IjkGridHdfGroup when property SplitLineReference is already set");
                ijkGridHdfGroupField = value;
                IjkGridHdfGroupSpecified = (value!=null);
                NotifyPropertyChanged("IjkGridHdfGroup");
            }
        }

        private ResqmlHdfGroup ijkGridHdfGroupField; 
        private bool ijkGridHdfGroupSpecified = false; 

        /// <summary>
        /// bool to indicate if IjkGridHdfGroup has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IjkGridHdfGroupSpecified
        {
            get {
                return ijkGridHdfGroupSpecified;
            }
            set {
                ijkGridHdfGroupSpecified= value;
            }
        }



        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// An i,j,k based corner point grid which uses i,j coordinate lines and k nodes to define the geometry. This may be used to define the overall geometry of a grid or may be used to define Local Grid Refinement.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlExplicitCornerPointGridRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("An i,j,k based corner point grid which uses i,j coordinate lines and k nodes to define the geometry. This may be used to define the overall geometry of a grid or may be used to define Local Grid Refinement.")]
    public partial class ResqmlExplicitCornerPointGridRepresentation : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A textual description of the grid.
        /// </summary>
		[StringLength(4000)]
        [Description("A textual description of the grid.")]
        [EnergisticsDataTypeAttribute(DataType = "commentString")]
		[XmlElement("description")]
        public string Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private string descriptionField; 

        /// <summary>
        /// A pointer to the localCRS which represents the 3D coordinates in this grid.
        /// </summary>
		[Required]
        [Description("A pointer to the localCRS which represents the 3D coordinates in this grid.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("local3dCRS")]
        public RefGlobalNameString Local3dCRS {
            get {
                return local3dCRSField;
            } 
            set {
                local3dCRSField = value;
                NotifyPropertyChanged("Local3dCRS");
            }
        }

        private RefGlobalNameString local3dCRSField; 

        /// <summary>
        /// Coordinate line node geometries.
        /// </summary>
		[Required]
        [Description("Coordinate line node geometries.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExplicitNodeSet")]
		[XmlElement("ijExplicitNodeSet")]
        public ResqmlExplicitNodeSet IjExplicitNodeSet {
            get {
                return ijExplicitNodeSetField;
            } 
            set {
                ijExplicitNodeSetField = value;
                NotifyPropertyChanged("IjExplicitNodeSet");
            }
        }

        private ResqmlExplicitNodeSet ijExplicitNodeSetField; 

        /// <summary>
        /// Defines the geometry of split nodes. The geometry is defined independent of coordinate lines.
        /// </summary>
		[Description("Defines the geometry of split nodes. The geometry is defined independent of coordinate lines.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlSplitNodeSet")]
		[XmlElement("ijkSplitNodeSet")]
        public ResqmlSplitNodeSet IjkSplitNodeSet {
            get {
                return ijkSplitNodeSetField;
            } 
            set {
                ijkSplitNodeSetField = value;
                NotifyPropertyChanged("IjkSplitNodeSet");
            }
        }

        private ResqmlSplitNodeSet ijkSplitNodeSetField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the refGlobalNameString xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="refGlobalNameString", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the refGlobalNameString xsd type.")]
    public partial class RefGlobalNameString : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the RefGlobalNameString class.
        /// </summary>
        public RefGlobalNameString() {}

        /// <summary>
        /// Initializes a new instance of the RefGlobalNameString class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public RefGlobalNameString(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// A reference to the globally unique identifier (uid attribute) in the node referenced by the name value. This attribute is required within the context of a WITSML server.
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("A reference to the globally unique identifier (uid attribute) in the node referenced by the name value.  This attribute is required within the context of a WITSML server.")]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalString")]
        [XmlAttribute("uidRef")]
		
        public string UidRef {
            get {
                return uidRefField;
            } 
            set {
                uidRefField = value;
                NotifyPropertyChanged("UidRef");
            }
        }

        private string uidRefField; 

        /// <summary>
        /// Value property
        /// </summary>
        [StringLength(64)]
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the indices for one cell in a 3D grid.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlCellIndex", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the indices for one cell in a 3D grid.")]
    public partial class ResqmlCellIndex : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The I index of the cell.
        /// </summary>
		[Required]
        [Description("The I index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("i")]
        public int? I {
            get {
                return iField;
            } 
            set {
                iField = value;
                NotifyPropertyChanged("I");
            }
        }

        private int? iField; 

        /// <summary>
        /// The J index of the cell.
        /// </summary>
		[Required]
        [Description("The J index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("j")]
        public int? J {
            get {
                return jField;
            } 
            set {
                jField = value;
                NotifyPropertyChanged("J");
            }
        }

        private int? jField; 

        /// <summary>
        /// The K index of the cell.
        /// </summary>
		[Required]
        [Description("The K index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("k")]
        public int? K {
            get {
                return kField;
            } 
            set {
                kField = value;
                NotifyPropertyChanged("K");
            }
        }

        private int? kField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the local grid refinement (LGR) by dividing the individual cells.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlCellDivisionWeight", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the local grid refinement (LGR) by dividing the individual cells.")]
    public partial class ResqmlCellDivisionWeight : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// A list that defines the number of refined cells within each target cell. The length of the list must be equal to the number of target cells in the specified direction (i.e., maxIndex-minIndex+1). The target cells are defined by a target cell window (i.e., by a minimum index and maximum index) in the parent grid. The order in the aggregate is significant. The first value represents the number of refined cells in the first target cell. The next value represents the number of refined cells in the second target cell. The number of resulting cells in specified direction is equal to the sum of this list of counts. 
        /// </summary>
		[Required]
        [Description("A list that defines the number of refined cells within each target cell. The length of the list must be equal to the number of target cells in the specified direction (i.e., maxIndex-minIndex+1). The target cells are defined by a target cell window (i.e., by a minimum index and maximum index) in the parent grid. The order in the aggregate is significant. The first value represents the number of refined cells in the first target cell.  The next value represents the number of refined cells in the second target cell. The number of resulting cells in specified direction is equal to the sum of this list of counts.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfShort")]
        [XmlAttribute("count")]
		
        public List<short> Count {
            get {
                return countField;
            } 
            set {
                countField = value;
                NotifyPropertyChanged("Count");
            }
        }

         /// <summary>
         /// bool to indicate if Count has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool CountSpecified
         {
             get {
             if(countField!=null)
                 return countField.Count>0?true:false;
             else return false;
             }
         }
        private List<short> countField; 

		/// <summary>
        /// A list that defines the weight to apply to each refined cell within each target cell. The length of the array must be equal to the sum of the counts in the count list. The order in the aggregate is significant. The first count(1) values represent the list of refinements for the the first target cell. The next count(2) values represent the list of refinements for the second target cell. The first weight within each refinement list applies to the lower index side of the target cell. The width of each refined cell will be proportional to the weights within each refinement list. Readers are advised to normalize the weights within each refinement list.
        /// </summary>
		[Required]
        [Description("A list that defines the weight to apply to each refined cell within each target cell. The length of the array must be equal to the sum of the counts in the count list. The order in the aggregate is significant. The first count(1) values represent the list of refinements for the the first target cell.  The next count(2) values represent the list of refinements for the second target cell. The first weight within each refinement list applies to the lower index side of the target cell. The width of each refined cell will be proportional to the weights within each refinement list. Readers are advised to normalize the weights within each refinement list.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfFloat")]
        [XmlAttribute("weight")]
		
        public List<float> Weight {
            get {
                return weightField;
            } 
            set {
                weightField = value;
                NotifyPropertyChanged("Weight");
            }
        }

         /// <summary>
         /// bool to indicate if Weight has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool WeightSpecified
         {
             get {
             if(weightField!=null)
                 return weightField.Count>0?true:false;
             else return false;
             }
         }
        private List<float> weightField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines a local grid refinement (LGR).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlIJKGridRefinement", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines a local grid refinement (LGR).")]
    public partial class ResqmlIJKGridRefinement : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the refinement of the parent cells in the I direction.
        /// </summary>
		[Required]
        [Description("Defines the refinement of the parent cells in the I direction.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlCellDivisionWeight")]
		[XmlElement("iRefine")]
        public ResqmlCellDivisionWeight IRefine {
            get {
                return iRefineField;
            } 
            set {
                iRefineField = value;
                NotifyPropertyChanged("IRefine");
            }
        }

        private ResqmlCellDivisionWeight iRefineField; 

        /// <summary>
        /// Defines the refinement of the parent cells in the J direction.
        /// </summary>
		[Required]
        [Description("Defines the refinement of the parent cells in the J direction.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlCellDivisionWeight")]
		[XmlElement("jRefine")]
        public ResqmlCellDivisionWeight JRefine {
            get {
                return jRefineField;
            } 
            set {
                jRefineField = value;
                NotifyPropertyChanged("JRefine");
            }
        }

        private ResqmlCellDivisionWeight jRefineField; 

        /// <summary>
        /// Defines the refinement of the parent cells in the K direction.
        /// </summary>
		[Required]
        [Description("Defines the refinement of the parent cells in the K direction.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlCellDivisionWeight")]
		[XmlElement("kRefine")]
        public ResqmlCellDivisionWeight KRefine {
            get {
                return kRefineField;
            } 
            set {
                kRefineField = value;
                NotifyPropertyChanged("KRefine");
            }
        }

        private ResqmlCellDivisionWeight kRefineField; 

        /// <summary>
        /// A parent cell to omit from the refinement.
        /// </summary>
		[Description("A parent cell to omit from the refinement.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlCellIndex")]
		[XmlElement("omittedCell")]
        public List<ResqmlCellIndex> OmittedCell {
            get {
                return omittedCellField;
            } 
            set {
                omittedCellField = value;
                NotifyPropertyChanged("OmittedCell");
            }
        }

         /// <summary>
         /// bool to indicate if OmittedCell has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool OmittedCellSpecified
         {
             get {
             if(omittedCellField!=null)
                 return omittedCellField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlCellIndex> omittedCellField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_resqmlAbstractIJKGrid xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlRootIJKGrid))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlLocalIJKGrid))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlAbstractIJKGrid", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the cs_resqmlAbstractIJKGrid xsd type.")]
    public abstract partial class ResqmlAbstractIJKGrid : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// I indices lower bound. All "I" values will be greater than or equal to this value. May be negative.
        /// </summary>
		[Required]
        [Description("I indices lower bound. All \"I\" values will be greater than or equal to this value. May be negative.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("startIndexI")]
        public int? StartIndexI {
            get {
                return startIndexIField;
            } 
            set {
                startIndexIField = value;
                NotifyPropertyChanged("StartIndexI");
            }
        }

        private int? startIndexIField; 

        /// <summary>
        /// J indices lower bound. All "J" values will be greater than or equal to this value. May be negative.
        /// </summary>
		[Required]
        [Description("J indices lower bound. All \"J\" values will be greater than or equal to this value. May be negative.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("startIndexJ")]
        public int? StartIndexJ {
            get {
                return startIndexJField;
            } 
            set {
                startIndexJField = value;
                NotifyPropertyChanged("StartIndexJ");
            }
        }

        private int? startIndexJField; 

        /// <summary>
        /// K indices lower bound. All "K" values will be greater than or equal to this value. May be negative.
        /// </summary>
		[Required]
        [Description("K indices lower bound. All \"K\" values will be greater than or equal to this value. May be negative.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("startIndexK")]
        public int? StartIndexK {
            get {
                return startIndexKField;
            } 
            set {
                startIndexKField = value;
                NotifyPropertyChanged("StartIndexK");
            }
        }

        private int? startIndexKField; 

        /// <summary>
        /// Number of cells in the "I" direction. Minimum value = 1.
        /// </summary>
		[Required]
        [Description("Number of cells in the \"I\" direction. Minimum value = 1.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("ni")]
        public int? Ni {
            get {
                return niField;
            } 
            set {
                niField = value;
                NotifyPropertyChanged("Ni");
            }
        }

        private int? niField; 

        /// <summary>
        /// Number of cells in the "J" direction. Minimum value = 1.
        /// </summary>
		[Required]
        [Description("Number of cells in the \"J\" direction. Minimum value = 1.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("nj")]
        public int? Nj {
            get {
                return njField;
            } 
            set {
                njField = value;
                NotifyPropertyChanged("Nj");
            }
        }

        private int? njField; 

        /// <summary>
        /// Number of cells in the "K" direction. Minimum value = 1.
        /// </summary>
		[Required]
        [Description("Number of cells in the \"K\" direction. Minimum value = 1.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("nk")]
        public int? Nk {
            get {
                return nkField;
            } 
            set {
                nkField = value;
                NotifyPropertyChanged("Nk");
            }
        }

        private int? nkField; 

        /// <summary>
        /// An encoded array of boolean flags which indicate cell node identity without the need for any floating point comparison The underlying type of each item is an integer. Each integer value represents the sum of integer components where:: 1=cellGeometryDefined, 2=iPinch, 4=jPinch, 8=kPinch, 16=iStandardAdjacency, 32=jStandardAdjacency, 64=kStandardAdjacency. This creates a bit encoded array within one integer value. Example: A "standard" cell has a value of 1+16+32+64 = 113 (hex 0x71 binary 1110001). A non-zero value for cellGeometryDefined indicates that the apparent geometry in a cell is well defined. A non-zero value for kPinch indicates that the top four nodes of a cell are identical to the corresponding bottom four nodes of the same cell. Similar for iPinch and jPinch. A non-zero value for iStandardAdjacency indicates that the four "I+" face nodes of cell (I,J,K) are identical to the four corresponding "I-" face nodes of cell (I+1,J,K). iStandardAdjacency=0 indicates that the only kind of adjacency you can expect will be described in the nonStandardAdjacency list. Similar for jStandardAdjacency and kStandardAdjacency. Consistent with this definition, standardAdjacency=0 off the edge of a grid.
        /// </summary>
        [ComponentElement]
        [XmlElement("gridTopologyFlags")]
        [EnergisticsDataTypeAttribute(DataType = "shortValues")]
        public ShortValueList GridTopologyFlags {
            get {
                return gridTopologyFlagsField;
            } 
            set {
                if (value != null && IjkGridHdfGroupSpecified) throw new Exception("Cannot set property GridTopologyFlags when property IjkGridHdfGroup is already set");
                gridTopologyFlagsField = value;
                GridTopologyFlagsSpecified = (value!=null);
                NotifyPropertyChanged("GridTopologyFlags");
            }
        }

        private ShortValueList gridTopologyFlagsField; 
        private bool gridTopologyFlagsSpecified = false; 

        /// <summary>
        /// bool to indicate if GridTopologyFlags has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool GridTopologyFlagsSpecified
        {
            get {
                return gridTopologyFlagsSpecified;
            }
            set {
                gridTopologyFlagsSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the gridTopologyFlags array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("ijkGridHdfGroup")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup IjkGridHdfGroup {
            get {
                return ijkGridHdfGroupField;
            } 
            set {
                if (value != null && GridTopologyFlagsSpecified) throw new Exception("Cannot set property IjkGridHdfGroup when property GridTopologyFlags is already set");
                ijkGridHdfGroupField = value;
                IjkGridHdfGroupSpecified = (value!=null);
                NotifyPropertyChanged("IjkGridHdfGroup");
            }
        }

        private ResqmlHdfGroup ijkGridHdfGroupField; 
        private bool ijkGridHdfGroupSpecified = false; 

        /// <summary>
        /// bool to indicate if IjkGridHdfGroup has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IjkGridHdfGroupSpecified
        {
            get {
                return ijkGridHdfGroupSpecified;
            }
            set {
                ijkGridHdfGroupSpecified= value;
            }
        }


        /// <summary>
        /// Defines a K layer after which a gap exists in the K layering. For example, if gapAfterLayer=2 then the node arrays will contain an extra node for the top of layer 3. If there is no gap then each node (except the first and last) represents the bottom of one layer and the top of the next. The length of the aggregate specifies the number of gaps in the K layering.
        /// </summary>
		[Description("Defines a K layer after which a gap exists in the K layering.  For example, if gapAfterLayer=2 then the node arrays will contain an  extra node for the top of layer 3. If there is no gap then each node (except the first and last) represents  the bottom of one layer and the top of the next. The length of the aggregate specifies the number of gaps in the K layering.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "positiveShort")]
		[XmlElement("gapAfterLayer")]
        public List<short> GapAfterLayer {
            get {
                return gapAfterLayerField;
            } 
            set {
                gapAfterLayerField = value;
                NotifyPropertyChanged("GapAfterLayer");
            }
        }

         /// <summary>
         /// bool to indicate if GapAfterLayer has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool GapAfterLayerSpecified
         {
             get {
             if(gapAfterLayerField!=null)
                 return gapAfterLayerField.Count>0?true:false;
             else return false;
             }
         }
        private List<short> gapAfterLayerField; 

        /// <summary>
        /// Defines the shape of all grid cells.
        /// </summary>
		[Required]
        [Description("Defines the shape of all grid cells.")]
        [EnergisticsDataTypeAttribute(DataType = "CellShape")]
		[XmlElement("gridCellShape")]
        public CellShape? GridCellShape {
            get {
                return gridCellShapeField;
            } 
            set {
                gridCellShapeField = value;
                 this.GridCellShapeSpecified = true;
                NotifyPropertyChanged("GridCellShape");
            }
        }

        
        private bool GridCellShapeSpecifiedField = false;
        
        /// <summary>
        /// GridCellShapeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool GridCellShapeSpecified {
            get {
                return GridCellShapeSpecifiedField;
            } 
            set {
                GridCellShapeSpecifiedField = value;
                NotifyPropertyChanged("GridCellShapeSpecified");
            }
        }
        
        private CellShape? gridCellShapeField; 

        /// <summary>
        /// The grid parity is the sign of (I cross J dot K) where I, J, and K are vectors in the direction of increasing I, J, and K numbering. Positive parity means that the IJK cell numbering is right-handed. True ("true" or "1") indicates that the grid has positive parity. False ("false" or "0") indicates that the grid has negative parity.
        /// </summary>
		[Required]
        [Description("The grid parity is the sign of (I cross J dot K) where I, J, and K  are vectors in the direction of increasing I, J, and K numbering. Positive parity means that the IJK cell numbering is right-handed. True (\"true\" or \"1\") indicates that the grid has positive parity.  False (\"false\" or \"0\") indicates that the grid has negative parity.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("positiveGridParity")]
        public bool? PositiveGridParity {
            get {
                return positiveGridParityField;
            } 
            set {
                positiveGridParityField = value;
                NotifyPropertyChanged("PositiveGridParity");
            }
        }

        private bool? positiveGridParityField; 

        /// <summary>
        ///  True ("true" or "1") indicates that the grid does not deform in time. False ("false" or "0") indicates that the grid DOES deform in time.
        /// </summary>
		[Required]
        [Description("True (\"true\" or \"1\") indicates that the grid does not deform in time.  False (\"false\" or \"0\") indicates that the grid DOES deform in time.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("gridStatic")]
        public bool? GridStatic {
            get {
                return gridStaticField;
            } 
            set {
                gridStaticField = value;
                NotifyPropertyChanged("GridStatic");
            }
        }

        private bool? gridStaticField; 

        /// <summary>
        /// Asserts the most complex type of line used in the grid.
        /// </summary>
		[Required]
        [Description("Asserts the most complex type of line used in the grid.")]
        [EnergisticsDataTypeAttribute(DataType = "ResqmlMostComplexLineGeometry")]
		[XmlElement("mostComplexLineGeometry")]
        public ResqmlMostComplexLineGeometry? MostComplexLineGeometry {
            get {
                return mostComplexLineGeometryField;
            } 
            set {
                mostComplexLineGeometryField = value;
                 this.MostComplexLineGeometrySpecified = true;
                NotifyPropertyChanged("MostComplexLineGeometry");
            }
        }

        
        private bool MostComplexLineGeometrySpecifiedField = false;
        
        /// <summary>
        /// MostComplexLineGeometrySpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MostComplexLineGeometrySpecified {
            get {
                return MostComplexLineGeometrySpecifiedField;
            } 
            set {
                MostComplexLineGeometrySpecifiedField = value;
                NotifyPropertyChanged("MostComplexLineGeometrySpecified");
            }
        }
        
        private ResqmlMostComplexLineGeometry? mostComplexLineGeometryField; 

        /// <summary>
        ///  True ("true" or "1") indicates that the grid will have split lines with laterally separated geometry. False ("false" or "0") indicates that the grid will NOT have split lines with laterally separated geometry.
        /// </summary>
		[Required]
        [Description("True (\"true\" or \"1\") indicates that the grid will have split lines with laterally separated geometry.  False (\"false\" or \"0\") indicates that the grid will NOT have split lines with laterally separated geometry.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("anyIJGap")]
        public bool? AnyIJGap {
            get {
                return anyIJGapField;
            } 
            set {
                anyIJGapField = value;
                NotifyPropertyChanged("AnyIJGap");
            }
        }

        private bool? anyIJGapField; 

        /// <summary>
        ///  True ("true" or "1") indicates that the grid will have at least one cell with undefined geometry. False ("false" or "0") indicates that all cells in the grid have well-defined geometry.
        /// </summary>
		[Required]
        [Description("True (\"true\" or \"1\") indicates that the grid will have at least one cell with undefined geometry.  False (\"false\" or \"0\") indicates that all cells in the grid have well-defined geometry.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("anyGeometryUndefined")]
        public bool? AnyGeometryUndefined {
            get {
                return anyGeometryUndefinedField;
            } 
            set {
                anyGeometryUndefinedField = value;
                NotifyPropertyChanged("AnyGeometryUndefined");
            }
        }

        private bool? anyGeometryUndefinedField; 

        /// <summary>
        ///  True ("true" or "1") indicates that the grid will have at least one cell pinched in the I or J direction. False ("false" or "0") indicates that the grid has neither iPinch nor jPinch.
        /// </summary>
		[Required]
        [Description("True (\"true\" or \"1\") indicates that the grid will have at least one cell pinched in the I or J direction. False (\"false\" or \"0\") indicates that the grid has neither iPinch nor jPinch.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("anyIJPinch")]
        public bool? AnyIJPinch {
            get {
                return anyIJPinchField;
            } 
            set {
                anyIJPinchField = value;
                NotifyPropertyChanged("AnyIJPinch");
            }
        }

        private bool? anyIJPinchField; 

        /// <summary>
        ///  True ("true" or "1") indicates that the grid will have at least one cell pinched in the K direction. False ("false" or "0") indicates that the grid has no kPinch.
        /// </summary>
		[Required]
        [Description("True (\"true\" or \"1\") indicates that the grid will have at least one cell pinched in the K direction.  False (\"false\" or \"0\") indicates that the grid has no kPinch.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("anyKPinch")]
        public bool? AnyKPinch {
            get {
                return anyKPinchField;
            } 
            set {
                anyKPinchField = value;
                NotifyPropertyChanged("AnyKPinch");
            }
        }

        private bool? anyKPinchField; 

        /// <summary>
        ///  True ("true" or "1") indicates that at least one coordinate node list line has entirely undefined geometry. False ("false" or "0") indicates that all coordinate node lists are defined. Individual nodal values may still be undefined in this case.
        /// </summary>
		[Required]
        [Description("True (\"true\" or \"1\") indicates that at least one coordinate node list line has entirely undefined geometry.  False (\"false\" or \"0\") indicates that all coordinate node lists are defined. Individual nodal values may still be undefined in this case.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("anyLineNull")]
        public bool? AnyLineNull {
            get {
                return anyLineNullField;
            } 
            set {
                anyLineNullField = value;
                NotifyPropertyChanged("AnyLineNull");
            }
        }

        private bool? anyLineNullField; 

        /// <summary>
        /// Properties for this object.
        /// </summary>
		[Description("Properties for this object.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the dublinCoreString xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    [System.Xml.Serialization.XmlRootAttribute("title", Namespace="http://purl.org/dc/terms/", IsNullable=false)]
	[Description("This class represents the dublinCoreString xsd type.")]
    public partial class DublinCoreString : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the DublinCoreString class.
        /// </summary>
        public DublinCoreString() {}

        /// <summary>
        /// Initializes a new instance of the DublinCoreString class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public DublinCoreString(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// lang property
        /// </summary>
		
        [XmlAttribute("lang", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		
        public string Lang {
            get {
                return langField;
            } 
            set {
                langField = value;
                NotifyPropertyChanged("Lang");
            }
        }

        private string langField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the abstractW3CDTF xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(W3CDTF))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    [System.Xml.Serialization.XmlRootAttribute("date", Namespace="http://purl.org/dc/terms/", IsNullable=false)]
	[Description("This class represents the abstractW3CDTF xsd type.")]
    public abstract partial class AbstractW3CDTF : AbstractTimestamp, INotifyPropertyChanged
    {


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the abstractTimestamp xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractW3CDTF))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(W3CDTF))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="abstractTimestamp", Namespace="http://purl.org/dc/terms/")]
	[Description("This class represents the abstractTimestamp xsd type.")]
    public abstract partial class AbstractTimestamp : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public DateTime Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private DateTime ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the W3CDTF xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="W3CDTF", Namespace="http://purl.org/dc/terms/")]
	[Description("This class represents the W3CDTF xsd type.")]
    public partial class W3CDTF : AbstractW3CDTF, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the W3CDTF class.
        /// </summary>
        public W3CDTF() {}

        /// <summary>
        /// Initializes a new instance of the W3CDTF class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public W3CDTF(DateTime value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the shortValues xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="shortValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the shortValues xsd type.")]
    public partial class ShortValueList : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// nullValue property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "short")]
        [XmlAttribute("nullValue")]
		
        public short NullValue {
            get {
                return nullValueField;
            } 
            set {
                nullValueField = value;
                 this.NullValueSpecified = true;
                NotifyPropertyChanged("NullValue");
            }
        }

        private short nullValueField; 

        /// <summary>
        /// nullValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool NullValueSpecified {
            get {
                return nullValueSpecifiedField;
            } 
            set {
                nullValueSpecifiedField = value;
                NotifyPropertyChanged("NullValueSpecified");
            }
        }

        private bool nullValueSpecifiedField; 

		/// <summary>
        /// array property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfShort")]
        [XmlAttribute("array")]
		
        public List<short> Array {
            get {
                return arrayField;
            } 
            set {
                arrayField = value;
                NotifyPropertyChanged("Array");
            }
        }

         /// <summary>
         /// bool to indicate if Array has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ArraySpecified
         {
             get {
             if(arrayField!=null)
                 return arrayField.Count>0?true:false;
             else return false;
             }
         }
        private List<short> arrayField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Contains all property values.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPropertySet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Contains all property values.")]
    public partial class ResqmlPropertySet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the property values specific to one property for an object. This property has a unit of measure and may be defined as floating point values. At least one of continuousPropertyValues, discretePropertyValues and categoricalPropertyValues must be given.
        /// </summary>
		[Description("Defines the property values specific to one property for an object.  This property has a unit of measure and may be defined as floating point values.  At least one of continuousPropertyValues, discretePropertyValues and  categoricalPropertyValues must be given.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlContinuousPropertyValues")]
		[XmlElement("continuousPropertyValues")]
        public List<ResqmlContinuousPropertyValues> ContinuousPropertyValues {
            get {
                return continuousPropertyValuesField;
            } 
            set {
                continuousPropertyValuesField = value;
                NotifyPropertyChanged("ContinuousPropertyValues");
            }
        }

         /// <summary>
         /// bool to indicate if ContinuousPropertyValues has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ContinuousPropertyValuesSpecified
         {
             get {
             if(continuousPropertyValuesField!=null)
                 return continuousPropertyValuesField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlContinuousPropertyValues> continuousPropertyValuesField; 

        /// <summary>
        /// Defines the property values specific to one property for an object. This property has whole numbered values. At least one of continuousPropertyValues, discretePropertyValues and categoricalPropertyValues must be given.
        /// </summary>
		[Description("Defines the property values specific to one property for an object.  This property has whole numbered values.  At least one of continuousPropertyValues, discretePropertyValues and  categoricalPropertyValues must be given.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlDiscretePropertyValues")]
		[XmlElement("discretePropertyValues")]
        public List<ResqmlDiscretePropertyValues> DiscretePropertyValues {
            get {
                return discretePropertyValuesField;
            } 
            set {
                discretePropertyValuesField = value;
                NotifyPropertyChanged("DiscretePropertyValues");
            }
        }

         /// <summary>
         /// bool to indicate if DiscretePropertyValues has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DiscretePropertyValuesSpecified
         {
             get {
             if(discretePropertyValuesField!=null)
                 return discretePropertyValuesField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlDiscretePropertyValues> discretePropertyValuesField; 

        /// <summary>
        /// Defines the property values specific to one property for an object. This property has whole numbered values which represent a string. At least one of continuousPropertyValues, discretePropertyValues and categoricalPropertyValues must be given.
        /// </summary>
		[Description("Defines the property values specific to one property for an object.  This property has whole numbered values which represent a string.  At least one of continuousPropertyValues, discretePropertyValues and  categoricalPropertyValues must be given.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlCategoricalPropertyValues")]
		[XmlElement("categoricalPropertyValues")]
        public List<ResqmlCategoricalPropertyValues> CategoricalPropertyValues {
            get {
                return categoricalPropertyValuesField;
            } 
            set {
                categoricalPropertyValuesField = value;
                NotifyPropertyChanged("CategoricalPropertyValues");
            }
        }

         /// <summary>
         /// bool to indicate if CategoricalPropertyValues has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool CategoricalPropertyValuesSpecified
         {
             get {
             if(categoricalPropertyValuesField!=null)
                 return categoricalPropertyValuesField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlCategoricalPropertyValues> categoricalPropertyValuesField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Information specific to one continuous property. This type inherits the following items: grp_resqmlTraceabilityDublinCore resqmlKind localKind propertyAttachment timestamp timeStep attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlContinuousPropertyValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Information specific to one continuous property. This type inherits the following items: grp_resqmlTraceabilityDublinCore resqmlKind localKind propertyAttachment timestamp timeStep attgrp_uidGlobal ")]
    public partial class ResqmlContinuousPropertyValues : ResqmlAbstractPropertyValues, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The minimum of the associated property values. The unit of measure is defined by unit.
        /// </summary>
		[Required]
        [Description("The minimum of the associated property values. The unit of measure is defined by unit.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("minimumValue")]
        public double? MinimumValue {
            get {
                return minimumValueField;
            } 
            set {
                minimumValueField = value;
                NotifyPropertyChanged("MinimumValue");
            }
        }

        private double? minimumValueField; 

        /// <summary>
        /// The maximum of the associated property values. The unit of measure is defined by unit.
        /// </summary>
		[Required]
        [Description("The maximum of the associated property values. The unit of measure is defined by unit.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("maximumValue")]
        public double? MaximumValue {
            get {
                return maximumValueField;
            } 
            set {
                maximumValueField = value;
                NotifyPropertyChanged("MaximumValue");
            }
        }

        private double? maximumValueField; 

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("hdfRepresentation")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup HdfRepresentation {
            get {
                return hdfRepresentationField;
            } 
            set {
                hdfRepresentationField = value;
                HdfRepresentationSpecified = (value!=null);
                NotifyPropertyChanged("HdfRepresentation");
            }
        }

        private ResqmlHdfGroup hdfRepresentationField; 
        private bool hdfRepresentationSpecified = false; 

        /// <summary>
        /// bool to indicate if HdfRepresentation has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool HdfRepresentationSpecified
        {
            get {
                return hdfRepresentationSpecified;
            }
            set {
                hdfRepresentationSpecified= value;
            }
        }

        /// <summary>
        /// Captures the array of values in an XML representation.
        /// </summary>
        [ComponentElement]
        [XmlElement("xmlRepresentation")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlContinuousValues")]
        public ResqmlContinuousValues XmlRepresentation {
            get {
                return xmlRepresentationField;
            } 
            set {
                xmlRepresentationField = value;
                XmlRepresentationSpecified = (value!=null);
                NotifyPropertyChanged("XmlRepresentation");
            }
        }

        private ResqmlContinuousValues xmlRepresentationField; 
        private bool xmlRepresentationSpecified = false; 

        /// <summary>
        /// bool to indicate if XmlRepresentation has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool XmlRepresentationSpecified
        {
            get {
                return xmlRepresentationSpecified;
            }
            set {
                xmlRepresentationSpecified= value;
            }
        }



    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the numeric arrays whose values may represent a continuous numeric space.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlContinuousValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the numeric arrays whose values may represent a continuous numeric space.")]
    public partial class ResqmlContinuousValues : ResqmlAbstractValues, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines a space delimited list of byte values.
        /// </summary>
        [ComponentElement]
        [XmlElement("byteValues")]
        [EnergisticsDataTypeAttribute(DataType = "byteValues")]
        public ByteValueList ByteValues {
            get {
                return byteValuesField;
            } 
            set {
                byteValuesField = value;
                ByteValuesSpecified = (value!=null);
                NotifyPropertyChanged("ByteValues");
            }
        }

        private ByteValueList byteValuesField; 
        private bool byteValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if ByteValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ByteValuesSpecified
        {
            get {
                return byteValuesSpecified;
            }
            set {
                byteValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of double values.
        /// </summary>
        [ComponentElement]
        [XmlElement("doubleValues")]
        [EnergisticsDataTypeAttribute(DataType = "doubleValues")]
        public DoubleValueList DoubleValues {
            get {
                return doubleValuesField;
            } 
            set {
                doubleValuesField = value;
                DoubleValuesSpecified = (value!=null);
                NotifyPropertyChanged("DoubleValues");
            }
        }

        private DoubleValueList doubleValuesField; 
        private bool doubleValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if DoubleValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool DoubleValuesSpecified
        {
            get {
                return doubleValuesSpecified;
            }
            set {
                doubleValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of float values.
        /// </summary>
        [ComponentElement]
        [XmlElement("floatValues")]
        [EnergisticsDataTypeAttribute(DataType = "floatValues")]
        public FloatValueList FloatValues {
            get {
                return floatValuesField;
            } 
            set {
                floatValuesField = value;
                FloatValuesSpecified = (value!=null);
                NotifyPropertyChanged("FloatValues");
            }
        }

        private FloatValueList floatValuesField; 
        private bool floatValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if FloatValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool FloatValuesSpecified
        {
            get {
                return floatValuesSpecified;
            }
            set {
                floatValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of int values.
        /// </summary>
        [ComponentElement]
        [XmlElement("intValues")]
        [EnergisticsDataTypeAttribute(DataType = "intValues")]
        public IntValueList IntValues {
            get {
                return intValuesField;
            } 
            set {
                intValuesField = value;
                IntValuesSpecified = (value!=null);
                NotifyPropertyChanged("IntValues");
            }
        }

        private IntValueList intValuesField; 
        private bool intValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if IntValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IntValuesSpecified
        {
            get {
                return intValuesSpecified;
            }
            set {
                intValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of long values.
        /// </summary>
        [ComponentElement]
        [XmlElement("longValues")]
        [EnergisticsDataTypeAttribute(DataType = "longValues")]
        public LongValueList LongValues {
            get {
                return longValuesField;
            } 
            set {
                longValuesField = value;
                LongValuesSpecified = (value!=null);
                NotifyPropertyChanged("LongValues");
            }
        }

        private LongValueList longValuesField; 
        private bool longValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if LongValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool LongValuesSpecified
        {
            get {
                return longValuesSpecified;
            }
            set {
                longValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of short values.
        /// </summary>
        [ComponentElement]
        [XmlElement("shortValues")]
        [EnergisticsDataTypeAttribute(DataType = "shortValues")]
        public ShortValueList ShortValues {
            get {
                return shortValuesField;
            } 
            set {
                shortValuesField = value;
                ShortValuesSpecified = (value!=null);
                NotifyPropertyChanged("ShortValues");
            }
        }

        private ShortValueList shortValuesField; 
        private bool shortValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if ShortValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ShortValuesSpecified
        {
            get {
                return shortValuesSpecified;
            }
            set {
                shortValuesSpecified= value;
            }
        }



    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the byteValues xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="byteValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the byteValues xsd type.")]
    public partial class ByteValueList : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// nullValue property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "byte")]
        [XmlAttribute("nullValue")]
		
        public SByte NullValue {
            get {
                return nullValueField;
            } 
            set {
                nullValueField = value;
                 this.NullValueSpecified = true;
                NotifyPropertyChanged("NullValue");
            }
        }

        private SByte nullValueField; 

        /// <summary>
        /// nullValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool NullValueSpecified {
            get {
                return nullValueSpecifiedField;
            } 
            set {
                nullValueSpecifiedField = value;
                NotifyPropertyChanged("NullValueSpecified");
            }
        }

        private bool nullValueSpecifiedField; 

		/// <summary>
        /// array property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfByte")]
        [XmlAttribute("array")]
		
        public List<SByte> Array {
            get {
                return arrayField;
            } 
            set {
                arrayField = value;
                NotifyPropertyChanged("Array");
            }
        }

         /// <summary>
         /// bool to indicate if Array has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ArraySpecified
         {
             get {
             if(arrayField!=null)
                 return arrayField.Count>0?true:false;
             else return false;
             }
         }
        private List<SByte> arrayField; 

        /// <summary>
        /// array property
        /// </summary>
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return Array;
			}
        }

        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the doubleValues xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="doubleValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the doubleValues xsd type.")]
    public partial class DoubleValueList : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// array property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfDouble")]
        [XmlAttribute("array")]
		
        public List<double> Array {
            get {
                return arrayField;
            } 
            set {
                arrayField = value;
                NotifyPropertyChanged("Array");
            }
        }

         /// <summary>
         /// bool to indicate if Array has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ArraySpecified
         {
             get {
             if(arrayField!=null)
                 return arrayField.Count>0?true:false;
             else return false;
             }
         }
        private List<double> arrayField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the floatValues xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="floatValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the floatValues xsd type.")]
    public partial class FloatValueList : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// array property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfFloat")]
        [XmlAttribute("array")]
		
        public List<float> Array {
            get {
                return arrayField;
            } 
            set {
                arrayField = value;
                NotifyPropertyChanged("Array");
            }
        }

         /// <summary>
         /// bool to indicate if Array has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ArraySpecified
         {
             get {
             if(arrayField!=null)
                 return arrayField.Count>0?true:false;
             else return false;
             }
         }
        private List<float> arrayField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the intValues xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="intValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the intValues xsd type.")]
    public partial class IntValueList : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// nullValue property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "int")]
        [XmlAttribute("nullValue")]
		
        public int NullValue {
            get {
                return nullValueField;
            } 
            set {
                nullValueField = value;
                 this.NullValueSpecified = true;
                NotifyPropertyChanged("NullValue");
            }
        }

        private int nullValueField; 

        /// <summary>
        /// nullValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool NullValueSpecified {
            get {
                return nullValueSpecifiedField;
            } 
            set {
                nullValueSpecifiedField = value;
                NotifyPropertyChanged("NullValueSpecified");
            }
        }

        private bool nullValueSpecifiedField; 

		/// <summary>
        /// array property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfInt")]
        [XmlAttribute("array")]
		
        public List<int> Array {
            get {
                return arrayField;
            } 
            set {
                arrayField = value;
                NotifyPropertyChanged("Array");
            }
        }

         /// <summary>
         /// bool to indicate if Array has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ArraySpecified
         {
             get {
             if(arrayField!=null)
                 return arrayField.Count>0?true:false;
             else return false;
             }
         }
        private List<int> arrayField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the longValues xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="longValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the longValues xsd type.")]
    public partial class LongValueList : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// nullValue property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "long")]
        [XmlAttribute("nullValue")]
		
        public long NullValue {
            get {
                return nullValueField;
            } 
            set {
                nullValueField = value;
                 this.NullValueSpecified = true;
                NotifyPropertyChanged("NullValue");
            }
        }

        private long nullValueField; 

        /// <summary>
        /// nullValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool NullValueSpecified {
            get {
                return nullValueSpecifiedField;
            } 
            set {
                nullValueSpecifiedField = value;
                NotifyPropertyChanged("NullValueSpecified");
            }
        }

        private bool nullValueSpecifiedField; 

		/// <summary>
        /// array property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "listOfLong")]
        [XmlAttribute("array")]
		
        public List<long> Array {
            get {
                return arrayField;
            } 
            set {
                arrayField = value;
                NotifyPropertyChanged("Array");
            }
        }

         /// <summary>
         /// bool to indicate if Array has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ArraySpecified
         {
             get {
             if(arrayField!=null)
                 return arrayField.Count>0?true:false;
             else return false;
             }
         }
        private List<long> arrayField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_resqmlAbstractValues xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlDiscreteValues))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlContinuousValues))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlAbstractValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the cs_resqmlAbstractValues xsd type.")]
    public abstract partial class ResqmlAbstractValues : Object, INotifyPropertyChanged
    {


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the whole numbered arrays.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlDiscreteValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the whole numbered arrays.")]
    public partial class ResqmlDiscreteValues : ResqmlAbstractValues, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines a space delimited list of byte values.
        /// </summary>
        [ComponentElement]
        [XmlElement("byteValues")]
        [EnergisticsDataTypeAttribute(DataType = "byteValues")]
        public ByteValueList ByteValues {
            get {
                return byteValuesField;
            } 
            set {
                byteValuesField = value;
                ByteValuesSpecified = (value!=null);
                NotifyPropertyChanged("ByteValues");
            }
        }

        private ByteValueList byteValuesField; 
        private bool byteValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if ByteValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ByteValuesSpecified
        {
            get {
                return byteValuesSpecified;
            }
            set {
                byteValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of int values.
        /// </summary>
        [ComponentElement]
        [XmlElement("intValues")]
        [EnergisticsDataTypeAttribute(DataType = "intValues")]
        public IntValueList IntValues {
            get {
                return intValuesField;
            } 
            set {
                intValuesField = value;
                IntValuesSpecified = (value!=null);
                NotifyPropertyChanged("IntValues");
            }
        }

        private IntValueList intValuesField; 
        private bool intValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if IntValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IntValuesSpecified
        {
            get {
                return intValuesSpecified;
            }
            set {
                intValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of long values.
        /// </summary>
        [ComponentElement]
        [XmlElement("longValues")]
        [EnergisticsDataTypeAttribute(DataType = "longValues")]
        public LongValueList LongValues {
            get {
                return longValuesField;
            } 
            set {
                longValuesField = value;
                LongValuesSpecified = (value!=null);
                NotifyPropertyChanged("LongValues");
            }
        }

        private LongValueList longValuesField; 
        private bool longValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if LongValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool LongValuesSpecified
        {
            get {
                return longValuesSpecified;
            }
            set {
                longValuesSpecified= value;
            }
        }

        /// <summary>
        /// Defines a space delimited list of short values.
        /// </summary>
        [ComponentElement]
        [XmlElement("shortValues")]
        [EnergisticsDataTypeAttribute(DataType = "shortValues")]
        public ShortValueList ShortValues {
            get {
                return shortValuesField;
            } 
            set {
                shortValuesField = value;
                ShortValuesSpecified = (value!=null);
                NotifyPropertyChanged("ShortValues");
            }
        }

        private ShortValueList shortValuesField; 
        private bool shortValuesSpecified = false; 

        /// <summary>
        /// bool to indicate if ShortValues has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ShortValuesSpecified
        {
            get {
                return shortValuesSpecified;
            }
            set {
                shortValuesSpecified= value;
            }
        }



    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_resqmlAbstractPropertyValues xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlCategoricalPropertyValues))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlDiscretePropertyValues))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlContinuousPropertyValues))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlAbstractPropertyValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the cs_resqmlAbstractPropertyValues xsd type.")]
    public abstract partial class ResqmlAbstractPropertyValues : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// The standard RESQML property which represents these values. For properties which have a unit of measure, this kind will directly or indirectly specify the single unit of measure which must be utilized for the property values.
        /// </summary>
        [XmlElement("resqmlKind")]
        [EnergisticsDataTypeAttribute(DataType = "nameString")]
        public string ResqmlKind {
            get {
                return resqmlKindField;
            } 
            set {
                if (value != null && LocalKindSpecified) throw new Exception("Cannot set property ResqmlKind when property LocalKind is already set");
                resqmlKindField = value;
                ResqmlKindSpecified = (value!=null);
                NotifyPropertyChanged("ResqmlKind");
            }
        }

        private string resqmlKindField; 
        private bool resqmlKindSpecified = false; 

        /// <summary>
        /// bool to indicate if ResqmlKind has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ResqmlKindSpecified
        {
            get {
                return resqmlKindSpecified;
            }
            set {
                resqmlKindSpecified= value;
            }
        }

        /// <summary>
        /// A pointer to the locally defined property which represents these values. Note that all local kinds must directly or indirectly be specialized from a standard RESQML kind.
        /// </summary>
        [ComponentElement]
        [XmlElement("localKind")]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
        public RefGlobalNameString LocalKind {
            get {
                return localKindField;
            } 
            set {
                if (value != null && ResqmlKindSpecified) throw new Exception("Cannot set property LocalKind when property ResqmlKind is already set");
                localKindField = value;
                LocalKindSpecified = (value!=null);
                NotifyPropertyChanged("LocalKind");
            }
        }

        private RefGlobalNameString localKindField; 
        private bool localKindSpecified = false; 

        /// <summary>
        /// bool to indicate if LocalKind has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool LocalKindSpecified
        {
            get {
                return localKindSpecified;
            }
            set {
                localKindSpecified= value;
            }
        }


        /// <summary>
        /// Defines how the data values are associated with the object.
        /// </summary>
		[Required]
        [Description("Defines how the data values are associated with the object.")]
        [EnergisticsDataTypeAttribute(DataType = "PropertyAttachment")]
		[XmlElement("propertyAttachment")]
        public PropertyAttachment? PropertyAttachment {
            get {
                return propertyAttachmentField;
            } 
            set {
                propertyAttachmentField = value;
                 this.PropertyAttachmentSpecified = true;
                NotifyPropertyChanged("PropertyAttachment");
            }
        }

        
        private bool PropertyAttachmentSpecifiedField = false;
        
        /// <summary>
        /// PropertyAttachmentSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool PropertyAttachmentSpecified {
            get {
                return PropertyAttachmentSpecifiedField;
            } 
            set {
                PropertyAttachmentSpecifiedField = value;
                NotifyPropertyChanged("PropertyAttachmentSpecified");
            }
        }
        
        private PropertyAttachment? propertyAttachmentField; 

        /// <summary>
        /// The date and time related to the property.
        /// </summary>
        [XmlElement("timestamp")]
        [EnergisticsDataTypeAttribute(DataType = "timestamp")]
        public DateTime? Timestamp {
            get {
                return timestampField;
            } 
            set {
                if (value != null && TimeStepSpecified) throw new Exception("Cannot set property Timestamp when property TimeStep is already set");
                timestampField = value;
                TimestampSpecified = (value!=null);
                NotifyPropertyChanged("Timestamp");
            }
        }

        private DateTime? timestampField; 
        private bool timestampSpecified = false; 

        /// <summary>
        /// bool to indicate if Timestamp has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool TimestampSpecified
        {
            get {
                return timestampSpecified;
            }
            set {
                timestampSpecified= value;
            }
        }

        /// <summary>
        /// The date and time related to the property.
        /// </summary>
        [ComponentElement]
        [XmlElement("timeStep")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlRefTimeStep")]
        public ResqmlRefTimeStep TimeStep {
            get {
                return timeStepField;
            } 
            set {
                if (value != null && TimestampSpecified) throw new Exception("Cannot set property TimeStep when property Timestamp is already set");
                timeStepField = value;
                TimeStepSpecified = (value!=null);
                NotifyPropertyChanged("TimeStep");
            }
        }

        private ResqmlRefTimeStep timeStepField; 
        private bool timeStepSpecified = false; 

        /// <summary>
        /// bool to indicate if TimeStep has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool TimeStepSpecified
        {
            get {
                return timeStepSpecified;
            }
            set {
                timeStepSpecified= value;
            }
        }


        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Points to a single timestamp within a timestep list.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlRefTimeStep", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Points to a single timestamp within a timestep list.")]
    public partial class ResqmlRefTimeStep : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A pointer to a time step list.
        /// </summary>
		[Required]
        [Description("A pointer to a time step list.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("timeStepList")]
        public RefGlobalNameString TimeStepList {
            get {
                return timeStepListField;
            } 
            set {
                timeStepListField = value;
                NotifyPropertyChanged("TimeStepList");
            }
        }

        private RefGlobalNameString timeStepListField; 

        /// <summary>
        /// The zero-based index of the timestamp within the list.
        /// </summary>
		[Required]
        [Description("The zero-based index of the timestamp within the list.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeShort")]
		[XmlElement("timeIndex")]
        public short? TimeIndex {
            get {
                return timeIndexField;
            } 
            set {
                timeIndexField = value;
                NotifyPropertyChanged("TimeIndex");
            }
        }

        private short? timeIndexField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Extension Schema. The intent is to allow standard schema extensions which will validate in older software. Software can ignore any schema that it does not recognize except that it should be replicated in any modified copies.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_extensionAny", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Extension Schema. The intent is to allow standard schema extensions which will validate in older software. Software can ignore any schema that it does not recognize except that it should be replicated in any modified copies.")]
    public partial class ExtensionAny : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Any property
        /// </summary>
		[RecurringElement]
		[XmlAnyElement]
        public List<XmlElement> Any {
            get {
                return AnyField;
            } 
            set {
                AnyField = value;
                NotifyPropertyChanged("Any");
            }
        }

         /// <summary>
         /// bool to indicate if Any has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AnySpecified
         {
             get {
             if(AnyField!=null)
                 return AnyField.Count>0?true:false;
             else return false;
             }
         }
        private List<XmlElement> AnyField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Extension values Schema. The intent is to allow standard "named" extensions without having to modify the schema. Software can ignore any name that it does not recognize but certain meta data is required in order to allow generic clients or servers to process the value.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlExtensionNameValue", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Extension values Schema. The intent is to allow standard named extensions without having to modify the schema. Software can ignore any name that it does not recognize but certain meta data is required in order to allow generic clients or servers to process the value.")]
    public partial class ResqmlExtensionNameValue : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The name of the extension. Meta data about this name should be captured in the XML loader file. Each standard name should document the expected measure class (if appropriate). Each standard name should document the expected maximum size. For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the appropriate Energistics SIG before use. The intent is for approved extensions to be explicitly added in the next schema release.
        /// </summary>
		[Required]
        [Description("The name of the extension. Meta data about this name should be captured in the XML loader file. Each standard name should document the expected measure class (if appropriate). Each standard name should document the expected maximum size.  For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the  appropriate Energistics SIG before use. The intent is for approved extensions to be explicitly added in the next schema release.")]
        [EnergisticsDataTypeAttribute(DataType = "ExtensionName")]
		[XmlElement("name")]
        public ExtensionName Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private ExtensionName nameField; 

        /// <summary>
        /// The value associated with the extension name. This may also include a uom attribute which should conform to the SI unit allowed by the measure class. The value content should conform to constraints defined by the data type.
        /// </summary>
		[Required]
        [Description("The value associated with the extension name.  This may also include a uom attribute which should conform to the SI unit allowed by the measure class.  The value content should conform to constraints defined by the data type.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "extensionvalue")]
		[XmlElement("value")]
        public Extensionvalue Value {
            get {
                return valueField;
            } 
            set {
                valueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private Extensionvalue valueField; 

        /// <summary>
        /// The underlying XML type of the value.
        /// </summary>
		[Required]
        [Description("The underlying XML type of the value.")]
        [EnergisticsDataTypeAttribute(DataType = "PrimitiveType")]
		[XmlElement("dataType")]
        public PrimitiveType? DataType {
            get {
                return dataTypeField;
            } 
            set {
                dataTypeField = value;
                 this.DataTypeSpecified = true;
                NotifyPropertyChanged("DataType");
            }
        }

        
        private bool DataTypeSpecifiedField = false;
        
        /// <summary>
        /// DataTypeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DataTypeSpecified {
            get {
                return DataTypeSpecifiedField;
            } 
            set {
                DataTypeSpecifiedField = value;
                NotifyPropertyChanged("DataTypeSpecified");
            }
        }
        
        private PrimitiveType? dataTypeField; 

        /// <summary>
        /// The kind of the measure. For example, "length". This should be specified if the value requires a unit of measure.
        /// </summary>
		[Description("The kind of the measure. For example, \"length\". This should be specified if the value requires a unit of measure.")]
        [EnergisticsDataTypeAttribute(DataType = "MeasureClass")]
		[XmlElement("measureClass")]
        public MeasureClass MeasureClass {
            get {
                return measureClassField;
            } 
            set {
                measureClassField = value;
                 this.MeasureClassSpecified = true;
                NotifyPropertyChanged("MeasureClass");
            }
        }

        private MeasureClass measureClassField; 

        /// <summary>
        /// measureClassSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MeasureClassSpecified {
            get {
                return measureClassSpecifiedField;
            } 
            set {
                measureClassSpecifiedField = value;
                NotifyPropertyChanged("MeasureClassSpecified");
            }
        }

        private bool measureClassSpecifiedField; 

        /// <summary>
        /// A textual description of the extension.
        /// </summary>
		[StringLength(256)]
        [Description("A textual description of the extension.")]
        [EnergisticsDataTypeAttribute(DataType = "descriptionString")]
		[XmlElement("description")]
        public string Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private string descriptionField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the extensionvalue xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="extensionvalue", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the extensionvalue xsd type.")]
    public partial class Extensionvalue : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the Extensionvalue class.
        /// </summary>
        public Extensionvalue() {}

        /// <summary>
        /// Initializes a new instance of the Extensionvalue class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public Extensionvalue(string value, string uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure for the value. This value must conform to the values allowed by a measure class.
        /// </summary>
		[StringLength(24)]
        [Description("The unit of measure for the value. This value must conform to the values allowed by a measure class.")]
        [EnergisticsDataTypeAttribute(DataType = "uomString")]
        [XmlAttribute("uom")]
		
        public string Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private string uomField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Information specific to one categorical (i.e., string) property. This type inherits the following items: grp_resqmlTraceabilityDublinCore resqmlKind localKind propertyAttachment timestamp timeStep attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlCategoricalPropertyValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Information specific to one categorical (i.e., string) property. This type inherits the following items: grp_resqmlTraceabilityDublinCore resqmlKind localKind propertyAttachment timestamp timeStep attgrp_uidGlobal ")]
    public partial class ResqmlCategoricalPropertyValues : ResqmlAbstractPropertyValues, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines an integer equivalent for a string. The integer value must be used in the array.
        /// </summary>
		[Required]
        [Description("Defines an integer equivalent for a string.  The integer value must be used in the array.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlStringLookup")]
		[XmlElement("stringLookup")]
        public List<ResqmlStringLookup> StringLookup {
            get {
                return stringLookupField;
            } 
            set {
                stringLookupField = value;
                NotifyPropertyChanged("StringLookup");
            }
        }

         /// <summary>
         /// bool to indicate if StringLookup has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool StringLookupSpecified
         {
             get {
             if(stringLookupField!=null)
                 return stringLookupField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlStringLookup> stringLookupField; 

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("hdfRepresentation")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup HdfRepresentation {
            get {
                return hdfRepresentationField;
            } 
            set {
                hdfRepresentationField = value;
                HdfRepresentationSpecified = (value!=null);
                NotifyPropertyChanged("HdfRepresentation");
            }
        }

        private ResqmlHdfGroup hdfRepresentationField; 
        private bool hdfRepresentationSpecified = false; 

        /// <summary>
        /// bool to indicate if HdfRepresentation has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool HdfRepresentationSpecified
        {
            get {
                return hdfRepresentationSpecified;
            }
            set {
                hdfRepresentationSpecified= value;
            }
        }

        /// <summary>
        /// Captures the array of values in an XML representation.
        /// </summary>
        [ComponentElement]
        [XmlElement("xmlRepresentation")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlDiscreteValues")]
        public ResqmlDiscreteValues XmlRepresentation {
            get {
                return xmlRepresentationField;
            } 
            set {
                xmlRepresentationField = value;
                XmlRepresentationSpecified = (value!=null);
                NotifyPropertyChanged("XmlRepresentation");
            }
        }

        private ResqmlDiscreteValues xmlRepresentationField; 
        private bool xmlRepresentationSpecified = false; 

        /// <summary>
        /// bool to indicate if XmlRepresentation has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool XmlRepresentationSpecified
        {
            get {
                return xmlRepresentationSpecified;
            }
            set {
                xmlRepresentationSpecified= value;
            }
        }



    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines a string to integer lookup table.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlStringLookup", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines a string to integer lookup table.")]
    public partial class ResqmlStringLookup : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// A string value.
        /// </summary>
		[Required]
        [StringLength(40)]
        [Description("A string value.")]
        [EnergisticsDataTypeAttribute(DataType = "kindString")]
		[XmlElement("stringValue")]
        public string StringValue {
            get {
                return stringValueField;
            } 
            set {
                stringValueField = value;
                NotifyPropertyChanged("StringValue");
            }
        }

        private string stringValueField; 

        /// <summary>
        /// The corresponding integer value. This value will be used in HDF instead of the string value. The value of nullIntegerValue must be reserved for NULL. The size of this value is constrained by the size of the format used within HDF.
        /// </summary>
		[Required]
        [Description("The corresponding integer value. This value will be used in HDF instead of the string value. The value of nullIntegerValue must be reserved for NULL. The size of this value is constrained by the size of the format used within HDF.")]
        [EnergisticsDataTypeAttribute(DataType = "long")]
		[XmlElement("integerValue")]
        public long? IntegerValue {
            get {
                return integerValueField;
            } 
            set {
                integerValueField = value;
                NotifyPropertyChanged("IntegerValue");
            }
        }

        private long? integerValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Information specific to one discrete property. This type inherits the following items: grp_resqmlTraceabilityDublinCore resqmlKind localKind propertyAttachment timestamp timeStep attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlDiscretePropertyValues", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Information specific to one discrete property. This type inherits the following items: grp_resqmlTraceabilityDublinCore resqmlKind localKind propertyAttachment timestamp timeStep attgrp_uidGlobal ")]
    public partial class ResqmlDiscretePropertyValues : ResqmlAbstractPropertyValues, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The minimum of the associated property values.
        /// </summary>
		[Required]
        [Description("The minimum of the associated property values.")]
        [EnergisticsDataTypeAttribute(DataType = "long")]
		[XmlElement("minimumValue")]
        public long? MinimumValue {
            get {
                return minimumValueField;
            } 
            set {
                minimumValueField = value;
                NotifyPropertyChanged("MinimumValue");
            }
        }

        private long? minimumValueField; 

        /// <summary>
        /// The maximum of the associated property values.
        /// </summary>
		[Required]
        [Description("The maximum of the associated property values.")]
        [EnergisticsDataTypeAttribute(DataType = "long")]
		[XmlElement("maximumValue")]
        public long? MaximumValue {
            get {
                return maximumValueField;
            } 
            set {
                maximumValueField = value;
                NotifyPropertyChanged("MaximumValue");
            }
        }

        private long? maximumValueField; 

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("hdfRepresentation")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup HdfRepresentation {
            get {
                return hdfRepresentationField;
            } 
            set {
                hdfRepresentationField = value;
                HdfRepresentationSpecified = (value!=null);
                NotifyPropertyChanged("HdfRepresentation");
            }
        }

        private ResqmlHdfGroup hdfRepresentationField; 
        private bool hdfRepresentationSpecified = false; 

        /// <summary>
        /// bool to indicate if HdfRepresentation has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool HdfRepresentationSpecified
        {
            get {
                return hdfRepresentationSpecified;
            }
            set {
                hdfRepresentationSpecified= value;
            }
        }

        /// <summary>
        /// Captures the array of values in an XML representation.
        /// </summary>
        [ComponentElement]
        [XmlElement("xmlRepresentation")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlDiscreteValues")]
        public ResqmlDiscreteValues XmlRepresentation {
            get {
                return xmlRepresentationField;
            } 
            set {
                xmlRepresentationField = value;
                XmlRepresentationSpecified = (value!=null);
                NotifyPropertyChanged("XmlRepresentation");
            }
        }

        private ResqmlDiscreteValues xmlRepresentationField; 
        private bool xmlRepresentationSpecified = false; 

        /// <summary>
        /// bool to indicate if XmlRepresentation has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool XmlRepresentationSpecified
        {
            get {
                return xmlRepresentationSpecified;
            }
            set {
                xmlRepresentationSpecified= value;
            }
        }



    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// An IJK structured root geometry of a volume This type inherits the following: grp_resqmlTraceabilityDublinCore startIndexI startIndexJ startIndexK ni nj nk gridTopologyFlags gapAfterLayer gridCellShape positiveGridParity gridStatic mostComplexLineGeometry anyIJGap anyGeometryUndefined anyIJPinch anyKPinch anyLineNull attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlRootIJKGrid", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("An IJK structured root geometry of a volume This type inherits the following: grp_resqmlTraceabilityDublinCore startIndexI startIndexJ startIndexK ni nj nk gridTopologyFlags gapAfterLayer gridCellShape positiveGridParity gridStatic mostComplexLineGeometry anyIJGap anyGeometryUndefined anyIJPinch anyKPinch anyLineNull attgrp_uidGlobal ")]
    public partial class ResqmlRootIJKGrid : ResqmlAbstractIJKGrid, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines a Local Grid related to this root grid. A local grid may be defined from a root grid or another local grid.
        /// </summary>
		[Description("Defines a Local Grid related to this root grid.  A local grid may be defined from a root grid or another local grid.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlLocalIJKGrid")]
		[XmlElement("localIJKGrid")]
        public List<ResqmlLocalIJKGrid> LocalIJKGrid {
            get {
                return localIJKGridField;
            } 
            set {
                localIJKGridField = value;
                NotifyPropertyChanged("LocalIJKGrid");
            }
        }

         /// <summary>
         /// bool to indicate if LocalIJKGrid has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool LocalIJKGridSpecified
         {
             get {
             if(localIJKGridField!=null)
                 return localIJKGridField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlLocalIJKGrid> localIJKGridField; 

        /// <summary>
        /// A 3D corner point grid representation using explicit nodes on coordinate lines.
        /// </summary>
		[Required]
        [Description("A 3D corner point grid representation using explicit nodes on coordinate lines.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExplicitCornerPointGridRepresentation")]
		[XmlElement("explicitGridRepresentation")]
        public ResqmlExplicitCornerPointGridRepresentation ExplicitGridRepresentation {
            get {
                return explicitGridRepresentationField;
            } 
            set {
                explicitGridRepresentationField = value;
                NotifyPropertyChanged("ExplicitGridRepresentation");
            }
        }

        private ResqmlExplicitCornerPointGridRepresentation explicitGridRepresentationField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// An IJK structured local geometry of a volume. This type inherits the following: grp_resqmlTraceabilityDublinCore startIndexI startIndexJ startIndexK ni nj nk gridTopologyFlags gapAfterLayer gridCellShape positiveGridParity gridStatic mostComplexLineGeometry anyIJGap anyGeometryUndefined anyIJPinch anyKPinch anyLineNull attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlLocalIJKGrid", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("An IJK structured local geometry of a volume. This type inherits the following: grp_resqmlTraceabilityDublinCore startIndexI startIndexJ startIndexK ni nj nk gridTopologyFlags gapAfterLayer gridCellShape positiveGridParity gridStatic mostComplexLineGeometry anyIJGap anyGeometryUndefined anyIJPinch anyKPinch anyLineNull attgrp_uidGlobal ")]
    public partial class ResqmlLocalIJKGrid : ResqmlAbstractIJKGrid, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// A pointer to the parent grid that is being locally redefined.
        /// </summary>
		[Required]
        [Description("A pointer to the parent grid that is being locally redefined.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("parentGrid")]
        public RefGlobalNameString ParentGrid {
            get {
                return parentGridField;
            } 
            set {
                parentGridField = value;
                NotifyPropertyChanged("ParentGrid");
            }
        }

        private RefGlobalNameString parentGridField; 

        /// <summary>
        /// The beginning cell of the redefinition window in the I direction. The "redefinition window" defines the cells to be replaced in the parent grid.
        /// </summary>
		[Required]
        [Description("The beginning cell of the redefinition window in the I direction.  The \"redefinition window\" defines the cells to be replaced in the parent grid.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("parentIMin")]
        public int? ParentIMin {
            get {
                return parentIMinField;
            } 
            set {
                parentIMinField = value;
                NotifyPropertyChanged("ParentIMin");
            }
        }

        private int? parentIMinField; 

        /// <summary>
        /// The ending cell of the redefinition window in I direction.
        /// </summary>
		[Required]
        [Description("The ending cell of the redefinition window in I direction.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("parentIMax")]
        public int? ParentIMax {
            get {
                return parentIMaxField;
            } 
            set {
                parentIMaxField = value;
                NotifyPropertyChanged("ParentIMax");
            }
        }

        private int? parentIMaxField; 

        /// <summary>
        /// The beginning cell of the redefinition window in the J direction. The "redefinition window" defines the cells to be replaced in the parent grid.
        /// </summary>
		[Required]
        [Description("The beginning cell of the redefinition window in the J direction.  The \"redefinition window\" defines the cells to be replaced in the parent grid.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("parentJMin")]
        public int? ParentJMin {
            get {
                return parentJMinField;
            } 
            set {
                parentJMinField = value;
                NotifyPropertyChanged("ParentJMin");
            }
        }

        private int? parentJMinField; 

        /// <summary>
        /// The ending cell of the redefinition window in J direction.
        /// </summary>
		[Required]
        [Description("The ending cell of the redefinition window in J direction.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("parentJMax")]
        public int? ParentJMax {
            get {
                return parentJMaxField;
            } 
            set {
                parentJMaxField = value;
                NotifyPropertyChanged("ParentJMax");
            }
        }

        private int? parentJMaxField; 

        /// <summary>
        /// The beginning cell of the redefinition window in the K direction. The "redefinition window" defines the cells to be replaced in the parent grid.
        /// </summary>
		[Required]
        [Description("The beginning cell of the redefinition window in the K direction.  The \"redefinition window\" defines the cells to be replaced in the parent grid.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("parentKMin")]
        public int? ParentKMin {
            get {
                return parentKMinField;
            } 
            set {
                parentKMinField = value;
                NotifyPropertyChanged("ParentKMin");
            }
        }

        private int? parentKMinField; 

        /// <summary>
        /// The ending cell of the redefinition window in K direction.
        /// </summary>
		[Required]
        [Description("The ending cell of the redefinition window in K direction.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("parentKMax")]
        public int? ParentKMax {
            get {
                return parentKMaxField;
            } 
            set {
                parentKMaxField = value;
                NotifyPropertyChanged("ParentKMax");
            }
        }

        private int? parentKMaxField; 

        /// <summary>
        /// A 3D corner point grid representation using explicit nodes on coordinate lines.
        /// </summary>
        [ComponentElement]
        [XmlElement("explicitCornerPointGrid")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExplicitCornerPointGridRepresentation")]
        public ResqmlExplicitCornerPointGridRepresentation ExplicitCornerPointGrid {
            get {
                return explicitCornerPointGridField;
            } 
            set {
                explicitCornerPointGridField = value;
                ExplicitCornerPointGridSpecified = (value!=null);
                NotifyPropertyChanged("ExplicitCornerPointGrid");
            }
        }

        private ResqmlExplicitCornerPointGridRepresentation explicitCornerPointGridField; 
        private bool explicitCornerPointGridSpecified = false; 

        /// <summary>
        /// bool to indicate if ExplicitCornerPointGrid has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ExplicitCornerPointGridSpecified
        {
            get {
                return explicitCornerPointGridSpecified;
            }
            set {
                explicitCornerPointGridSpecified= value;
            }
        }

        /// <summary>
        /// Structured IJK grid refinement.
        /// </summary>
        [ComponentElement]
        [XmlElement("ijkGridRefinement")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlIJKGridRefinement")]
        public ResqmlIJKGridRefinement IjkGridRefinement {
            get {
                return ijkGridRefinementField;
            } 
            set {
                ijkGridRefinementField = value;
                IjkGridRefinementSpecified = (value!=null);
                NotifyPropertyChanged("IjkGridRefinement");
            }
        }

        private ResqmlIJKGridRefinement ijkGridRefinementField; 
        private bool ijkGridRefinementSpecified = false; 

        /// <summary>
        /// bool to indicate if IjkGridRefinement has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IjkGridRefinementSpecified
        {
            get {
                return ijkGridRefinementSpecified;
            }
            set {
                ijkGridRefinementSpecified= value;
            }
        }



    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A cell-face-pair that defines a non-standard-adjacency.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGridIJKCellFacePair", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A cell-face-pair that defines a non-standard-adjacency.")]
    public partial class ResqmlGridIJKCellFacePair : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A zero-based pointer to the grid that contains the cell-face. A value of zero represents the first grid in the grid3dGUID aggregate of the parent.
        /// </summary>
		[Required]
        [Description("A zero-based pointer to the grid that contains the cell-face. A value of zero represents the first grid in the grid3dGUID aggregate of the parent.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("gridID1")]
        public int? GridID1 {
            get {
                return gridID1Field;
            } 
            set {
                gridID1Field = value;
                NotifyPropertyChanged("GridID1");
            }
        }

        private int? gridID1Field; 

        /// <summary>
        /// The I index of the cell.
        /// </summary>
		[Required]
        [Description("The I index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("i1")]
        public int? I1 {
            get {
                return i1Field;
            } 
            set {
                i1Field = value;
                NotifyPropertyChanged("I1");
            }
        }

        private int? i1Field; 

        /// <summary>
        /// The J index of the cell.
        /// </summary>
		[Required]
        [Description("The J index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("j1")]
        public int? J1 {
            get {
                return j1Field;
            } 
            set {
                j1Field = value;
                NotifyPropertyChanged("J1");
            }
        }

        private int? j1Field; 

        /// <summary>
        /// The K index of the cell.
        /// </summary>
		[Required]
        [Description("The K index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("k1")]
        public int? K1 {
            get {
                return k1Field;
            } 
            set {
                k1Field = value;
                NotifyPropertyChanged("K1");
            }
        }

        private int? k1Field; 

        /// <summary>
        /// 0-based cell face index. The value must be from 0 to 5.
        /// </summary>
		[Required]
        [Range(0, 5)]
        [Description("0-based cell face index. The value must be from 0 to 5.")]
        [EnergisticsDataTypeAttribute(DataType = "faceIndex")]
		[XmlElement("face1")]
        public short? Face1 {
            get {
                return face1Field;
            } 
            set {
                face1Field = value;
                NotifyPropertyChanged("Face1");
            }
        }

        private short? face1Field; 

        /// <summary>
        /// A zero-based pointer to the grid that contains the cell-face. A value of zero represents the first grid in the grid3dGUID aggregate of the parent.
        /// </summary>
		[Required]
        [Description("A zero-based pointer to the grid that contains the cell-face. A value of zero represents the first grid in the grid3dGUID aggregate of the parent.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("gridID2")]
        public int? GridID2 {
            get {
                return gridID2Field;
            } 
            set {
                gridID2Field = value;
                NotifyPropertyChanged("GridID2");
            }
        }

        private int? gridID2Field; 

        /// <summary>
        /// The I index of the cell.
        /// </summary>
		[Required]
        [Description("The I index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("i2")]
        public int? I2 {
            get {
                return i2Field;
            } 
            set {
                i2Field = value;
                NotifyPropertyChanged("I2");
            }
        }

        private int? i2Field; 

        /// <summary>
        /// The J index of the cell.
        /// </summary>
		[Required]
        [Description("The J index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("j2")]
        public int? J2 {
            get {
                return j2Field;
            } 
            set {
                j2Field = value;
                NotifyPropertyChanged("J2");
            }
        }

        private int? j2Field; 

        /// <summary>
        /// The K index of the cell.
        /// </summary>
		[Required]
        [Description("The K index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("k2")]
        public int? K2 {
            get {
                return k2Field;
            } 
            set {
                k2Field = value;
                NotifyPropertyChanged("K2");
            }
        }

        private int? k2Field; 

        /// <summary>
        /// 0-based cell face index. The value must be from 0 to 5.
        /// </summary>
		[Required]
        [Range(0, 5)]
        [Description("0-based cell face index. The value must be from 0 to 5.")]
        [EnergisticsDataTypeAttribute(DataType = "faceIndex")]
		[XmlElement("face2")]
        public short? Face2 {
            get {
                return face2Field;
            } 
            set {
                face2Field = value;
                NotifyPropertyChanged("Face2");
            }
        }

        private short? face2Field; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Cell-face-pair non-standard adjacency geometry and properties for structured IJK grids.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlIJKNonStandardAdjacency", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Cell-face-pair non-standard adjacency geometry and properties for structured IJK grids.")]
    public partial class ResqmlIJKNonStandardAdjacency : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// Points to the fault associated with this non-standard-adjacency.
        /// </summary>
		[Description("Points to the fault associated with this non-standard-adjacency.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("faultName")]
        public RefGlobalNameString FaultName {
            get {
                return faultNameField;
            } 
            set {
                faultNameField = value;
                NotifyPropertyChanged("FaultName");
            }
        }

        private RefGlobalNameString faultNameField; 

        /// <summary>
        /// A cell-face-pair that defines non-standard-adjacency. The order of the aggregate must be retained. Properties will be assigned to the pair based on the order. An index of zero will represent the first pair.
        /// </summary>
        [ComponentElement]
        [XmlElement("gridIJKCellFacePair")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGridIJKCellFacePair")]
        public ResqmlGridIJKCellFacePair[] GridIJKCellFacePair {
            get {
                return gridIJKCellFacePairField;
            } 
            set {
                if (value != null && HdfRepresentationSpecified) throw new Exception("Cannot set property GridIJKCellFacePair when property HdfRepresentation is already set");
                gridIJKCellFacePairField = value;
                GridIJKCellFacePairSpecified = (value!=null);
                NotifyPropertyChanged("GridIJKCellFacePair");
            }
        }

        private ResqmlGridIJKCellFacePair[] gridIJKCellFacePairField; 
        private bool gridIJKCellFacePairSpecified = false; 

        /// <summary>
        /// bool to indicate if GridIJKCellFacePair has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool GridIJKCellFacePairSpecified
        {
            get {
                return gridIJKCellFacePairSpecified;
            }
            set {
                gridIJKCellFacePairSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the cell-face-pair array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("hdfRepresentation")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup HdfRepresentation {
            get {
                return hdfRepresentationField;
            } 
            set {
                if (value != null && GridIJKCellFacePairSpecified) throw new Exception("Cannot set property HdfRepresentation when property GridIJKCellFacePair is already set");
                hdfRepresentationField = value;
                HdfRepresentationSpecified = (value!=null);
                NotifyPropertyChanged("HdfRepresentation");
            }
        }

        private ResqmlHdfGroup hdfRepresentationField; 
        private bool hdfRepresentationSpecified = false; 

        /// <summary>
        /// bool to indicate if HdfRepresentation has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool HdfRepresentationSpecified
        {
            get {
                return hdfRepresentationSpecified;
            }
            set {
                hdfRepresentationSpecified= value;
            }
        }


        /// <summary>
        /// A pointer to a grid that contains a cell face. This logically points to the abstract supertype of the corner point and local grids such that the referenced grid may either be a root-grid or a child-grid. The aggregate of grids represents the 3D grids that are referenced in gridIJKCellFacePair. The order is significant and represents the gridID values in gridIJKCellFacePair. An index of zero will represent the first grid.
        /// </summary>
		[Required]
        [Description("A pointer to a grid that contains a cell face.  This logically points to the abstract supertype of the corner point and local grids such that  the referenced grid may either be a root-grid or a child-grid. The aggregate of grids represents the 3D grids that are referenced in gridIJKCellFacePair. The order is significant and represents the gridID values in gridIJKCellFacePair. An index of zero will represent the first grid.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("grid3dGUID")]
        public List<RefGlobalNameString> Grid3dGUID {
            get {
                return grid3dGUIDField;
            } 
            set {
                grid3dGUIDField = value;
                NotifyPropertyChanged("Grid3dGUID");
            }
        }

         /// <summary>
         /// bool to indicate if Grid3dGUID has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Grid3dGUIDSpecified
         {
             get {
             if(grid3dGUIDField!=null)
                 return grid3dGUIDField.Count>0?true:false;
             else return false;
             }
         }
        private List<RefGlobalNameString> grid3dGUIDField; 

        /// <summary>
        /// Properties for this object.
        /// </summary>
		[Description("Properties for this object.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A grid cell traversed by a wellbore.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGridIJKCell", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A grid cell traversed by a wellbore.")]
    public partial class ResqmlGridIJKCell : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A zero-based pointer to the grid that contains the traversed cell. A value of zero represents the first grid in the grid3dGUID aggregate of the parent.
        /// </summary>
		[Required]
        [Description("A zero-based pointer to the grid that contains the traversed cell. A value of zero represents the first grid in the grid3dGUID aggregate of the parent.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("gridID")]
        public int? GridID {
            get {
                return gridIDField;
            } 
            set {
                gridIDField = value;
                NotifyPropertyChanged("GridID");
            }
        }

        private int? gridIDField; 

        /// <summary>
        /// The I index of the cell.
        /// </summary>
		[Required]
        [Description("The I index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("i")]
        public int? I {
            get {
                return iField;
            } 
            set {
                iField = value;
                NotifyPropertyChanged("I");
            }
        }

        private int? iField; 

        /// <summary>
        /// The J index of the cell.
        /// </summary>
		[Required]
        [Description("The J index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("j")]
        public int? J {
            get {
                return jField;
            } 
            set {
                jField = value;
                NotifyPropertyChanged("J");
            }
        }

        private int? jField; 

        /// <summary>
        /// The K index of the cell.
        /// </summary>
		[Required]
        [Description("The K index of the cell.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("k")]
        public int? K {
            get {
                return kField;
            } 
            set {
                kField = value;
                NotifyPropertyChanged("K");
            }
        }

        private int? kField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This replaces an optional sequence of elements. The original purpose of the sequence was to insure that if one element was specified then both must be specified. This type was created in order to get around a "feature" of the MS xsd.exe utility. The utility does not look at the minOccurs of the sequence which results in the contents of the sequence being mandatory. See http://msdn.microsoft.com/en-us/library/zds0b35c%28v=vs.80%29.aspx
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlParentBlockedWellbore", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This replaces an optional sequence of elements. The original purpose of the sequence was to insure that if one element was specified then both must be specified. This type was created in order to get around a feature of the MS xsd.exe utility. The utility does not look at the minOccurs of the sequence which results in the contents of the sequence being mandatory. See http://msdn.microsoft.com/en-us/library/zds0b35c%28v=vs.80%29.aspx")]
    public partial class ResqmlParentBlockedWellbore : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Points to the blocked wellbore which contains the kickoff point cell.
        /// </summary>
		[Required]
        [Description("Points to the blocked wellbore which contains the kickoff point cell.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("parent")]
        public RefGlobalNameString Parent {
            get {
                return parentField;
            } 
            set {
                parentField = value;
                NotifyPropertyChanged("Parent");
            }
        }

        private RefGlobalNameString parentField; 

        /// <summary>
        /// A zero-based pointer to the kickoff point cell within parentBlockedWellbore.
        /// </summary>
		[Required]
        [Description("A zero-based pointer to the kickoff point cell within parentBlockedWellbore.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("parentIndex")]
        public int? ParentIndex {
            get {
                return parentIndexField;
            } 
            set {
                parentIndexField = value;
                NotifyPropertyChanged("ParentIndex");
            }
        }

        private int? parentIndexField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The (surface toward bottomhole) path of a wellbore defined as a list of grid cells. For sidetrack (lateral) wellbores the path starts at the kickoff point.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlIJKBlockedWellbore", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("The (surface toward bottomhole) path of a wellbore defined as a list of grid cells. For sidetrack (lateral) wellbores the path starts at the kickoff point.")]
    public partial class ResqmlIJKBlockedWellbore : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// Points to the well that contains the wellbore. This identifies well.
        /// </summary>
		[Description("Points to the well that contains the wellbore. This identifies well.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refNameString")]
		[XmlElement("wellName")]
        public RefNameString WellName {
            get {
                return wellNameField;
            } 
            set {
                wellNameField = value;
                NotifyPropertyChanged("WellName");
            }
        }

        private RefNameString wellNameField; 

        /// <summary>
        /// Points to the wellbore within the specified well. This identifies the wellbore.
        /// </summary>
		[Description("Points to the wellbore within the specified well. This identifies the wellbore.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refNameString")]
		[XmlElement("wellboreName")]
        public RefNameString WellboreName {
            get {
                return wellboreNameField;
            } 
            set {
                wellboreNameField = value;
                NotifyPropertyChanged("WellboreName");
            }
        }

        private RefNameString wellboreNameField; 

        /// <summary>
        /// Points to the parent blocked wellbore and the kickoff point cell.
        /// </summary>
		[Description("Points to the parent blocked wellbore and the kickoff point cell.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlParentBlockedWellbore")]
		[XmlElement("parentBlockedWellbore")]
        public ResqmlParentBlockedWellbore ParentBlockedWellbore {
            get {
                return parentBlockedWellboreField;
            } 
            set {
                parentBlockedWellboreField = value;
                NotifyPropertyChanged("ParentBlockedWellbore");
            }
        }

        private ResqmlParentBlockedWellbore parentBlockedWellboreField; 

        /// <summary>
        /// A pointer to a grid that contains a traversed cell. This logically points to the abstract supertype of the corner point and local grids such that the referenced grid may either be a root-grid or a child-grid. The aggregate of grids represents the 3D grids that are referenced in gridIJKCell. The order is significant and represents the gridID values in gridIJKCell. An index of zero will represent the first grid.
        /// </summary>
		[Required]
        [Description("A pointer to a grid that contains a traversed cell.  This logically points to the abstract supertype of the corner point and local grids such that  the referenced grid may either be a root-grid or a child-grid. The aggregate of grids represents the 3D grids that are referenced in gridIJKCell. The order is significant and represents the gridID values in gridIJKCell. An index of zero will represent the first grid.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("grid3dGUID")]
        public List<RefGlobalNameString> Grid3dGUID {
            get {
                return grid3dGUIDField;
            } 
            set {
                grid3dGUIDField = value;
                NotifyPropertyChanged("Grid3dGUID");
            }
        }

         /// <summary>
         /// bool to indicate if Grid3dGUID has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Grid3dGUIDSpecified
         {
             get {
             if(grid3dGUIDField!=null)
                 return grid3dGUIDField.Count>0?true:false;
             else return false;
             }
         }
        private List<RefGlobalNameString> grid3dGUIDField; 

        /// <summary>
        /// Points to a grid cell traversed by the wellbore. The aggregate of traversed cells represents the path of the wellbore through the related grids. The order of the cells in the aggregate is significant and represents the relative order from surface toward bottomhole. An index of zero will represent the first cell. Note that the full path of the wellbore may not be represented by the available grids. For the initial (or main) wellbore, the first cell represents the cell at the minimum measured depth. For sidetracks (laterals), the first cell represents the cell containing the kickoff point from the parent wellbore.
        /// </summary>
		[Required]
        [Description("Points to a grid cell traversed by the wellbore. The aggregate of traversed cells represents the path of the wellbore through the related grids. The order of the cells in the aggregate is significant and represents the relative order from surface toward bottomhole. An index of zero will represent the first cell. Note that the full path of the wellbore may not be represented by the available grids. For the initial (or main) wellbore, the first cell represents the cell at the minimum measured depth. For sidetracks (laterals), the first cell represents the cell containing the kickoff point from the parent wellbore.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGridIJKCell")]
		[XmlElement("gridIJKCell")]
        public List<ResqmlGridIJKCell> GridIJKCell {
            get {
                return gridIJKCellField;
            } 
            set {
                gridIJKCellField = value;
                NotifyPropertyChanged("GridIJKCell");
            }
        }

         /// <summary>
         /// bool to indicate if GridIJKCell has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool GridIJKCellSpecified
         {
             get {
             if(gridIJKCellField!=null)
                 return gridIJKCellField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlGridIJKCell> gridIJKCellField; 

        /// <summary>
        /// Properties for this object.
        /// </summary>
		[Description("Properties for this object.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the refNameString xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="refNameString", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the refNameString xsd type.")]
    public partial class RefNameString : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the RefNameString class.
        /// </summary>
        public RefNameString() {}

        /// <summary>
        /// Initializes a new instance of the RefNameString class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public RefNameString(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// A reference to the unique identifier (uid attribute) in the node referenced by the name value. This attribute is required within the context of a WITSML server.
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("A reference to the unique identifier (uid attribute) in the node referenced by the name value.  This attribute is required within the context of a WITSML server.")]
        [EnergisticsDataTypeAttribute(DataType = "refString")]
        [XmlAttribute("uidRef")]
		
        public string UidRef {
            get {
                return uidRefField;
            } 
            set {
                uidRefField = value;
                NotifyPropertyChanged("UidRef");
            }
        }

        private string uidRefField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the grids and properties for volumes.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGriddedVolumeSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the grids and properties for volumes.")]
    public partial class ResqmlGriddedVolumeSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines path of wellbores through the grids. May assign properties to each path.
        /// </summary>
		[Description("Defines path of wellbores through the grids. May assign properties to each path.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlBlockedWellboreSet")]
		[XmlArrayItem("ijkBlockedWellbore")]
        [XmlArray("blockedWellboreSet")]
        public List<ResqmlIJKBlockedWellbore> BlockedWellboreSet {
            get {
                return blockedWellboreSetField;
            } 
            set {
                blockedWellboreSetField = value;
                NotifyPropertyChanged("BlockedWellboreSet");
            }
        }

         /// <summary>
         /// bool to indicate if BlockedWellboreSet has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BlockedWellboreSetSpecified
         {
             get {
             if(blockedWellboreSetField!=null)
                 return blockedWellboreSetField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlIJKBlockedWellbore> blockedWellboreSetField; 

        /// <summary>
        /// Defines cell-face-pair non-standard adjacency geometry for the grids. May assign properties to each NSA geometry.
        /// </summary>
		[Description("Defines cell-face-pair non-standard adjacency geometry for the grids. May assign properties to each NSA geometry.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlNonStandardAdjacencySet")]
		[XmlArrayItem("ijkNonStandardAdjacency")]
        [XmlArray("nonStandardAdjacencySet")]
        public List<ResqmlIJKNonStandardAdjacency> NonStandardAdjacencySet {
            get {
                return nonStandardAdjacencySetField;
            } 
            set {
                nonStandardAdjacencySetField = value;
                NotifyPropertyChanged("NonStandardAdjacencySet");
            }
        }

         /// <summary>
         /// bool to indicate if NonStandardAdjacencySet has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool NonStandardAdjacencySetSpecified
         {
             get {
             if(nonStandardAdjacencySetField!=null)
                 return nonStandardAdjacencySetField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlIJKNonStandardAdjacency> nonStandardAdjacencySetField; 

        /// <summary>
        /// A container for 3D grids. May assign properties to each grid.
        /// </summary>
		[Description("A container for 3D grids. May assign properties to each grid.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGridSet")]
		[XmlArrayItem("rootIJKGrid")]
        [XmlArray("gridSet")]
        public List<ResqmlRootIJKGrid> GridSet {
            get {
                return gridSetField;
            } 
            set {
                gridSetField = value;
                NotifyPropertyChanged("GridSet");
            }
        }

         /// <summary>
         /// bool to indicate if GridSet has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool GridSetSpecified
         {
             get {
             if(gridSetField!=null)
                 return gridSetField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlRootIJKGrid> gridSetField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the relationship between the 2D grid coordinates and the bin grid.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlBinGrid", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the relationship between the 2D grid coordinates and the bin grid.")]
    public partial class ResqmlBinGrid : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// A pointer to the local 3D CRS which represents the coordinates. This must point to a child of spatialReferenceSet.
        /// </summary>
		[Required]
        [Description("A pointer to the local 3D CRS which represents the coordinates. This must point to a child of spatialReferenceSet.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("local3dCRS")]
        public RefGlobalNameString Local3dCRS {
            get {
                return local3dCRSField;
            } 
            set {
                local3dCRSField = value;
                NotifyPropertyChanged("Local3dCRS");
            }
        }

        private RefGlobalNameString local3dCRSField; 

        /// <summary>
        /// The number of nodes in the I dimension. This axis is parallel to the first axis in the local3dCRS.
        /// </summary>
		[Required]
        [Description("The number of nodes in the I dimension. This axis is parallel to the first axis in the local3dCRS.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("ni")]
        public int? Ni {
            get {
                return niField;
            } 
            set {
                niField = value;
                NotifyPropertyChanged("Ni");
            }
        }

        private int? niField; 

        /// <summary>
        /// The number of nodes in the J dimension. This axis is parallel to the second axis in the local2dCRS.
        /// </summary>
		[Required]
        [Description("The number of nodes in the J dimension. This axis is parallel to the second axis in the local2dCRS.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("nj")]
        public int? Nj {
            get {
                return njField;
            } 
            set {
                njField = value;
                NotifyPropertyChanged("Nj");
            }
        }

        private int? njField; 

        /// <summary>
        /// The inline/crossline value at the origin (namely at i=0, j=0).
        /// </summary>
		[Required]
        [Description("The inline/crossline value at the origin (namely at i=0, j=0).")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("originOrdinal1")]
        public double? OriginOrdinal1 {
            get {
                return originOrdinal1Field;
            } 
            set {
                originOrdinal1Field = value;
                NotifyPropertyChanged("OriginOrdinal1");
            }
        }

        private double? originOrdinal1Field; 

        /// <summary>
        /// The inline/crossline value at the origin (namely at i=0, j=0).
        /// </summary>
		[Required]
        [Description("The inline/crossline value at the origin (namely at i=0, j=0).")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("originOrdinal2")]
        public double? OriginOrdinal2 {
            get {
                return originOrdinal2Field;
            } 
            set {
                originOrdinal2Field = value;
                NotifyPropertyChanged("OriginOrdinal2");
            }
        }

        private double? originOrdinal2Field; 

        /// <summary>
        /// The constant distance between nodes along the I axis of the grid. The unit of measure is defined by the CRS.
        /// </summary>
		[Required]
        [Description("The constant distance between nodes along the I axis of the grid. The unit of measure is defined by the CRS.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("deltaI")]
        public double? DeltaI {
            get {
                return deltaIField;
            } 
            set {
                deltaIField = value;
                NotifyPropertyChanged("DeltaI");
            }
        }

        private double? deltaIField; 

        /// <summary>
        /// The constant distance between nodes along the J axis of the grid. The unit of measure is defined by arealUnit.
        /// </summary>
		[Required]
        [Description("The constant distance between nodes along the J axis of the grid. The unit of measure is defined by arealUnit.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("deltaJ")]
        public double? DeltaJ {
            get {
                return deltaJField;
            } 
            set {
                deltaJField = value;
                NotifyPropertyChanged("DeltaJ");
            }
        }

        private double? deltaJField; 

        /// <summary>
        /// True ("true" or "1") indicates that the inlines are parallel to the i-axis which means that each inline represents a constant value of j and each crossline represents a constant value of i. False ("false" or "0") indicates that the inlines are parallel to the j-axis which means that each inline represents a constant value of i and each crossline represents a constant value of j.
        /// </summary>
		[Description("True (\"true\" or \"1\") indicates that the inlines are parallel to the i-axis which means that each inline represents a constant value of j and  each crossline represents a constant value of i. False (\"false\" or \"0\") indicates that the inlines are parallel to the j-axis which means that each inline represents a constant value of i and  each crossline represents a constant value of j.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("inlineParallelToIAxis")]
        public bool? InlineParallelToIAxis {
            get {
                return inlineParallelToIAxisField;
            } 
            set {
                inlineParallelToIAxisField = value;
                NotifyPropertyChanged("InlineParallelToIAxis");
            }
        }

        private bool? inlineParallelToIAxisField; 

        /// <summary>
        /// The index of the first inline beginning at i=0, j=0.
        /// </summary>
		[Description("The index of the first inline beginning at i=0, j=0.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("originInline")]
        public int? OriginInline {
            get {
                return originInlineField;
            } 
            set {
                originInlineField = value;
                NotifyPropertyChanged("OriginInline");
            }
        }

        private int? originInlineField; 

        /// <summary>
        /// The index of the first crosslineline beginning at i=0, j=0.
        /// </summary>
		[Description("The index of the first crosslineline beginning at i=0, j=0.")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("originCrossline")]
        public int? OriginCrossline {
            get {
                return originCrosslineField;
            } 
            set {
                originCrosslineField = value;
                NotifyPropertyChanged("OriginCrossline");
            }
        }

        private int? originCrosslineField; 

        /// <summary>
        /// The inline increment increment. If inlines are parallel to the i-axis the inline increment will be the difference in the inline number from node i=0, j=0 to node i=1, j=0. If inlines are parallel to the j-axis the inline increment will be the difference in the inline number from node i=0, j=0 to node i=0, j=1. The increment can be a positive or negative integer, but not zero.
        /// </summary>
		[Description("The inline increment increment. If inlines are parallel to the i-axis the inline increment will be the difference  in the inline number from node i=0, j=0 to node i=1, j=0. If inlines are parallel to the j-axis the inline increment will be the difference  in the inline number from node i=0, j=0 to node i=0, j=1.  The increment can be a positive or negative integer, but not zero.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("inlineIncrement")]
        public int? InlineIncrement {
            get {
                return inlineIncrementField;
            } 
            set {
                inlineIncrementField = value;
                NotifyPropertyChanged("InlineIncrement");
            }
        }

        private int? inlineIncrementField; 

        /// <summary>
        /// The crossline increment. The increment can be a positive or negative integer, but not zero.
        /// </summary>
		[Description("The crossline increment. The increment can be a positive or negative integer, but not zero.")]
        [EnergisticsDataTypeAttribute(DataType = "int")]
		[XmlElement("crosslineIncrement")]
        public int? CrosslineIncrement {
            get {
                return crosslineIncrementField;
            } 
            set {
                crosslineIncrementField = value;
                NotifyPropertyChanged("CrosslineIncrement");
            }
        }

        private int? crosslineIncrementField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A gemetrical representation which is a set of pillar lines that approximate a surface. Note that that this does not fully represent a surface. It is just a list of lines (typically from seismic). More information is required to define an actual surface. All lines shall utilize the same CRS.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPillarSetPatch", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A gemetrical representation which is a set of pillar lines that approximate a surface. Note that that this does not fully represent a surface. It is just a list of lines (typically from seismic). More information is required to define an actual surface. All lines shall utilize the same CRS.")]
    public partial class ResqmlPillarSetPatch : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The number of nodes per pillar.
        /// </summary>
		[Required]
        [Description("The number of nodes per pillar.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("nodeCountPerPillar")]
        public int? NodeCountPerPillar {
            get {
                return nodeCountPerPillarField;
            } 
            set {
                nodeCountPerPillarField = value;
                NotifyPropertyChanged("NodeCountPerPillar");
            }
        }

        private int? nodeCountPerPillarField; 

        /// <summary>
        /// A list of points representing all the nodes of all the pillars. The first nodeCountPerPillar points represent the nodes of the first pillar, the second nodeCountPerPillar points represent the nodes of the second pillar, and so on. A point defined by with NaN values shall be ignored.
        /// </summary>
        [ComponentElement]
        [XmlElement("pillarSet")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPoint3dSet")]
        public ResqmlPoint3dSet PillarSet {
            get {
                return pillarSetField;
            } 
            set {
                if (value != null && PillarSetHdfGroupSpecified) throw new Exception("Cannot set property PillarSet when property PillarSetHdfGroup is already set");
                pillarSetField = value;
                PillarSetSpecified = (value!=null);
                NotifyPropertyChanged("PillarSet");
            }
        }

        private ResqmlPoint3dSet pillarSetField; 
        private bool pillarSetSpecified = false; 

        /// <summary>
        /// bool to indicate if PillarSet has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool PillarSetSpecified
        {
            get {
                return pillarSetSpecified;
            }
            set {
                pillarSetSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("pillarSetHdfGroup")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup PillarSetHdfGroup {
            get {
                return pillarSetHdfGroupField;
            } 
            set {
                if (value != null && PillarSetSpecified) throw new Exception("Cannot set property PillarSetHdfGroup when property PillarSet is already set");
                pillarSetHdfGroupField = value;
                PillarSetHdfGroupSpecified = (value!=null);
                NotifyPropertyChanged("PillarSetHdfGroup");
            }
        }

        private ResqmlHdfGroup pillarSetHdfGroupField; 
        private bool pillarSetHdfGroupSpecified = false; 

        /// <summary>
        /// bool to indicate if PillarSetHdfGroup has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool PillarSetHdfGroupSpecified
        {
            get {
                return pillarSetHdfGroupSpecified;
            }
            set {
                pillarSetHdfGroupSpecified= value;
            }
        }


        /// <summary>
        /// Properties for this patch.
        /// </summary>
		[Description("Properties for this patch.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of points defined in 3 dimensional space.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlWellMarker", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of points defined in 3 dimensional space.")]
    public partial class ResqmlWellMarker : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The name and uid of the well that contains the wellbore.
        /// </summary>
		[Description("The name and uid of the well that contains the wellbore.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refNameString")]
		[XmlElement("nameWell")]
        public RefNameString NameWell {
            get {
                return nameWellField;
            } 
            set {
                nameWellField = value;
                NotifyPropertyChanged("NameWell");
            }
        }

        private RefNameString nameWellField; 

        /// <summary>
        /// The name and uid of the wellbore that intersects the feature. If nameWellbore is specified then nameWell must also be specified.
        /// </summary>
		[Description("The name and uid of the wellbore that intersects the feature. If nameWellbore is specified then nameWell must also be specified.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refNameString")]
		[XmlElement("nameWellbore")]
        public RefNameString NameWellbore {
            get {
                return nameWellboreField;
            } 
            set {
                nameWellboreField = value;
                NotifyPropertyChanged("NameWellbore");
            }
        }

        private RefNameString nameWellboreField; 

        /// <summary>
        /// The name and uid of the formationMarker whose location is represented here. If nameMarker is specified then nameWellbore must also be specified.
        /// </summary>
		[Description("The name and uid of the formationMarker whose location is represented here. If nameMarker is specified then nameWellbore must also be specified.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refNameString")]
		[XmlElement("nameMarker")]
        public RefNameString NameMarker {
            get {
                return nameMarkerField;
            } 
            set {
                nameMarkerField = value;
                NotifyPropertyChanged("NameMarker");
            }
        }

        private RefNameString nameMarkerField; 

        /// <summary>
        /// The measured depth of the intersected point.
        /// </summary>
		[Description("The measured depth of the intersected point.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "measuredDepthCoord")]
		[XmlElement("md")]
        public MeasuredDepthCoord MD {
            get {
                return mdField;
            } 
            set {
                mdField = value;
                NotifyPropertyChanged("MD");
            }
        }

        private MeasuredDepthCoord mdField; 

        /// <summary>
        /// The x-coordinate of the intersected point.
        /// </summary>
		[Description("The x-coordinate of the intersected point.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("x")]
        public double? X {
            get {
                return xField;
            } 
            set {
                xField = value;
                 this.XSpecified = true;
                NotifyPropertyChanged("X");
            }
        }

        private double? xField; 

        /// <summary>
        /// xSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool XSpecified {
            get {
                return xSpecifiedField;
            } 
            set {
                xSpecifiedField = value;
                NotifyPropertyChanged("XSpecified");
            }
        }

        private bool xSpecifiedField; 

        /// <summary>
        /// The y-coordinate of the intersected point.
        /// </summary>
		[Description("The y-coordinate of the intersected point.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("y")]
        public double? Y {
            get {
                return yField;
            } 
            set {
                yField = value;
                 this.YSpecified = true;
                NotifyPropertyChanged("Y");
            }
        }

        private double? yField; 

        /// <summary>
        /// ySpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool YSpecified {
            get {
                return ySpecifiedField;
            } 
            set {
                ySpecifiedField = value;
                NotifyPropertyChanged("YSpecified");
            }
        }

        private bool ySpecifiedField; 

        /// <summary>
        /// The z-coordinate of the intersected point.
        /// </summary>
		[Description("The z-coordinate of the intersected point.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("z")]
        public double? Z {
            get {
                return zField;
            } 
            set {
                zField = value;
                 this.ZSpecified = true;
                NotifyPropertyChanged("Z");
            }
        }

        private double? zField; 

        /// <summary>
        /// zSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool ZSpecified {
            get {
                return zSpecifiedField;
            } 
            set {
                zSpecifiedField = value;
                NotifyPropertyChanged("ZSpecified");
            }
        }

        private bool zSpecifiedField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the measuredDepthCoord xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="measuredDepthCoord", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the measuredDepthCoord xsd type.")]
    public partial class MeasuredDepthCoord : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MeasuredDepthCoord class.
        /// </summary>
        public MeasuredDepthCoord() {}

        /// <summary>
        /// Initializes a new instance of the MeasuredDepthCoord class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public MeasuredDepthCoord(double value, MeasuredDepthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the quantity value.
        /// </summary>
		[Required]
        [Description("The unit of measure of the quantity value.")]
        [EnergisticsDataTypeAttribute(DataType = "MeasuredDepthUom")]
        [XmlAttribute("uom")]
		
        public MeasuredDepthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private MeasuredDepthUom uomField; 

		/// <summary>
        /// A pointer to the reference datum for this coordinate value as defined in WellDatum. This value is assumed to match the uid value in a WellDatum. If not given then the default WellDatum must be assumed.
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("A pointer to the reference datum for this coordinate  value as defined in WellDatum. This value is assumed to match the uid value in a WellDatum. If not given then the default WellDatum must be assumed.")]
        [EnergisticsDataTypeAttribute(DataType = "refWellDatum")]
        [XmlAttribute("datum")]
		
        public string Datum {
            get {
                return datumField;
            } 
            set {
                datumField = value;
                NotifyPropertyChanged("Datum");
            }
        }

        private string datumField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public double Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private double ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A gemetrical representation which is a set of points that approximates a surface. Note that that this does not fullly represent a surface. It is just a random set of points (typically from seismic). More information is required to define an actual surface. All points shall utilize the same CRS.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlWellMarkerPatch", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A gemetrical representation which is a set of points that approximates a surface. Note that that this does not fullly represent a surface. It is just a random set of points (typically from seismic). More information is required to define an actual surface. All points shall utilize the same CRS.")]
    public partial class ResqmlWellMarkerPatch : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the set of points that represents a nominal surface. The order of the points in the aggregate is not significant relative to the surface. The order represents the "point index" which is used for assigning properties.
        /// </summary>
		[Required]
        [Description("Defines the set of points that represents a nominal surface. The order of the points in the aggregate is not significant relative to the surface. The order represents the \"point index\" which is used for assigning properties.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlWellMarkerSet")]
		[XmlArrayItem("wellMarker")]
        [XmlArray("point3dSet")]
        public List<ResqmlWellMarker> Point3dSet {
            get {
                return point3dSetField;
            } 
            set {
                point3dSetField = value;
                NotifyPropertyChanged("Point3dSet");
            }
        }

         /// <summary>
         /// bool to indicate if Point3dSet has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Point3dSetSpecified
         {
             get {
             if(point3dSetField!=null)
                 return point3dSetField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlWellMarker> point3dSetField; 

        /// <summary>
        /// Properties for this patch.
        /// </summary>
		[Description("Properties for this patch.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A gemetrical representation which is a set of points that approximates a surface. Note that that this does not fullly represent a surface. It is just a random set of points (typically from seismic). More information is required to define an actual surface. All points shall utilize the same CRS.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPointSetPatch", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A gemetrical representation which is a set of points that approximates a surface. Note that that this does not fullly represent a surface. It is just a random set of points (typically from seismic). More information is required to define an actual surface. All points shall utilize the same CRS.")]
    public partial class ResqmlPointSetPatch : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the set of points that represents a nominal surface. The order of the points in the aggregate is not significant relative to the surface. The order represents the "point index" which is used for assigning properties.
        /// </summary>
        [ComponentElement]
        [XmlElement("point3dSet")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPoint3dSet")]
        public ResqmlPoint3dSet Point3dSet {
            get {
                return point3dSetField;
            } 
            set {
                if (value != null && PointSetHdfGroupSpecified) throw new Exception("Cannot set property Point3dSet when property PointSetHdfGroup is already set");
                point3dSetField = value;
                Point3dSetSpecified = (value!=null);
                NotifyPropertyChanged("Point3dSet");
            }
        }

        private ResqmlPoint3dSet point3dSetField; 
        private bool point3dSetSpecified = false; 

        /// <summary>
        /// bool to indicate if Point3dSet has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool Point3dSetSpecified
        {
            get {
                return point3dSetSpecified;
            }
            set {
                point3dSetSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("pointSetHdfGroup")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup PointSetHdfGroup {
            get {
                return pointSetHdfGroupField;
            } 
            set {
                if (value != null && Point3dSetSpecified) throw new Exception("Cannot set property PointSetHdfGroup when property Point3dSet is already set");
                pointSetHdfGroupField = value;
                PointSetHdfGroupSpecified = (value!=null);
                NotifyPropertyChanged("PointSetHdfGroup");
            }
        }

        private ResqmlHdfGroup pointSetHdfGroupField; 
        private bool pointSetHdfGroupSpecified = false; 

        /// <summary>
        /// bool to indicate if PointSetHdfGroup has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool PointSetHdfGroupSpecified
        {
            get {
                return pointSetHdfGroupSpecified;
            }
            set {
                pointSetHdfGroupSpecified= value;
            }
        }


        /// <summary>
        /// Properties for this patch.
        /// </summary>
		[Description("Properties for this patch.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of split edges.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlSplitEdgeSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of split edges.")]
    public partial class ResqmlSplitEdgeSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the 2 corner vertex of one edge.
        /// </summary>
		[Required]
        [Description("Defines the 2 corner vertex of one edge.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "splitEdge")]
		[XmlElement("splitEdge")]
        public List<SplitEdge> SplitEdge {
            get {
                return splitEdgeField;
            } 
            set {
                splitEdgeField = value;
                NotifyPropertyChanged("SplitEdge");
            }
        }

         /// <summary>
         /// bool to indicate if SplitEdge has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool SplitEdgeSpecified
         {
             get {
             if(splitEdgeField!=null)
                 return splitEdgeField.Count>0?true:false;
             else return false;
             }
         }
        private List<SplitEdge> splitEdgeField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the splitEdge xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="splitEdge", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the splitEdge xsd type.")]
    public partial class SplitEdge : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// ix1 property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
        [XmlAttribute("ix1")]
		
        public int Ix1 {
            get {
                return ix1Field;
            } 
            set {
                ix1Field = value;
                NotifyPropertyChanged("Ix1");
            }
        }

        private int ix1Field; 

		/// <summary>
        /// ix2 property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
        [XmlAttribute("ix2")]
		
        public int Ix2 {
            get {
                return ix2Field;
            } 
            set {
                ix2Field = value;
                NotifyPropertyChanged("Ix2");
            }
        }

        private int ix2Field; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of triangles.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlTriangleSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of triangles.")]
    public partial class ResqmlTriangleSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A single triangle defined by the index of each corner vertex.
        /// </summary>
		[Required]
        [Description("A single triangle defined by the index of each corner vertex.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "triangle")]
		[XmlElement("trgl")]
        public List<Triangle> Trgl {
            get {
                return trglField;
            } 
            set {
                trglField = value;
                NotifyPropertyChanged("Trgl");
            }
        }

         /// <summary>
         /// bool to indicate if Trgl has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TrglSpecified
         {
             get {
             if(trglField!=null)
                 return trglField.Count>0?true:false;
             else return false;
             }
         }
        private List<Triangle> trglField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the triangle xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="triangle", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the triangle xsd type.")]
    public partial class Triangle : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// ix1 property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
        [XmlAttribute("ix1")]
		
        public int Ix1 {
            get {
                return ix1Field;
            } 
            set {
                ix1Field = value;
                NotifyPropertyChanged("Ix1");
            }
        }

        private int ix1Field; 

		/// <summary>
        /// ix2 property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
        [XmlAttribute("ix2")]
		
        public int Ix2 {
            get {
                return ix2Field;
            } 
            set {
                ix2Field = value;
                NotifyPropertyChanged("Ix2");
            }
        }

        private int ix2Field; 

		/// <summary>
        /// ix3 property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
        [XmlAttribute("ix3")]
		
        public int Ix3 {
            get {
                return ix3Field;
            } 
            set {
                ix3Field = value;
                NotifyPropertyChanged("Ix3");
            }
        }

        private int ix3Field; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A gemetrical representation of a surface patch using a triangulated grid.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlTriangulatedPatch", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A gemetrical representation of a surface patch using a triangulated grid.")]
    public partial class ResqmlTriangulatedPatch : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// A set of coordinate triplets which locates the nodes in the mesh. A value of "NaN" shall NOT exist in any of the points. There is no semantic meaning to the point order except that properties are assigned to the vertices based on the order. This order is called the "vertex index". The first vertex has an index of zero. If you set this property, you must also set TriangleNodeIndexSet, SplitEdgeNodeIndexSet.
        /// </summary>
        [ComponentElement]
        [XmlElement("point3dSet")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPoint3dSet")]
        public ResqmlPoint3dSet Point3dSet {
            get {
                return point3dSetField;
            } 
            set {
                if (value != null && TriangulatedHdfGroupSpecified) throw new Exception("Cannot set property Point3dSet when property TriangulatedHdfGroup is already set");
                point3dSetField = value;
                Point3dSetSpecified = (value!=null);
                NotifyPropertyChanged("Point3dSet");
            }
        }

        private ResqmlPoint3dSet point3dSetField; 
        private bool point3dSetSpecified = false; 

        /// <summary>
        /// bool to indicate if Point3dSet has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool Point3dSetSpecified
        {
            get {
                return point3dSetSpecified;
            }
            set {
                point3dSetSpecified= value;
            }
        }

        /// <summary>
        /// A set of triangles in the mesh. A triangle is defined by specifying the "vertex index" of each corner. A corner shall not be defined as "NaN". The aggregate of triangles defines the mesh. There is no semantic meaning to the triangle sequence order except that properties are assigned to the triangles based on the order. This order is called the "face index". The first triangle has an index of zero. If you set this property, you must also set Point3dSet, SplitEdgeNodeIndexSet.
        /// </summary>
        [ComponentElement]
        [XmlElement("triangleNodeIndexSet")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlTriangleSet")]
        public ResqmlTriangleSet TriangleNodeIndexSet {
            get {
                return triangleNodeIndexSetField;
            } 
            set {
                if (value != null && TriangulatedHdfGroupSpecified) throw new Exception("Cannot set property TriangleNodeIndexSet when property TriangulatedHdfGroup is already set");
                triangleNodeIndexSetField = value;
                TriangleNodeIndexSetSpecified = (value!=null);
                NotifyPropertyChanged("TriangleNodeIndexSet");
            }
        }

        private ResqmlTriangleSet triangleNodeIndexSetField; 
        private bool triangleNodeIndexSetSpecified = false; 

        /// <summary>
        /// bool to indicate if TriangleNodeIndexSet has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool TriangleNodeIndexSetSpecified
        {
            get {
                return triangleNodeIndexSetSpecified;
            }
            set {
                triangleNodeIndexSetSpecified= value;
            }
        }

        /// <summary>
        /// A set of split edges. There is no semantics assigned to the order of the edges. If you set this property, you must also set Point3dSet, TriangleNodeIndexSet.
        /// </summary>
        [ComponentElement]
        [XmlElement("splitEdgeNodeIndexSet")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlSplitEdgeSet")]
        public ResqmlSplitEdgeSet SplitEdgeNodeIndexSet {
            get {
                return splitEdgeNodeIndexSetField;
            } 
            set {
                if (value != null && TriangulatedHdfGroupSpecified) throw new Exception("Cannot set property SplitEdgeNodeIndexSet when property TriangulatedHdfGroup is already set");
                splitEdgeNodeIndexSetField = value;
                SplitEdgeNodeIndexSetSpecified = (value!=null);
                NotifyPropertyChanged("SplitEdgeNodeIndexSet");
            }
        }

        private ResqmlSplitEdgeSet splitEdgeNodeIndexSetField; 
        private bool splitEdgeNodeIndexSetSpecified = false; 

        /// <summary>
        /// bool to indicate if SplitEdgeNodeIndexSet has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SplitEdgeNodeIndexSetSpecified
        {
            get {
                return splitEdgeNodeIndexSetSpecified;
            }
            set {
                splitEdgeNodeIndexSetSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("triangulatedHdfGroup")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup TriangulatedHdfGroup {
            get {
                return triangulatedHdfGroupField;
            } 
            set {
                if (value != null && Point3dSetSpecified) throw new Exception("Cannot set property TriangulatedHdfGroup when property Point3dSet is already set");
                if (value != null && SplitEdgeNodeIndexSetSpecified) throw new Exception("Cannot set property TriangulatedHdfGroup when property SplitEdgeNodeIndexSet is already set");
                if (value != null && TriangleNodeIndexSetSpecified) throw new Exception("Cannot set property TriangulatedHdfGroup when property TriangleNodeIndexSet is already set");
                triangulatedHdfGroupField = value;
                TriangulatedHdfGroupSpecified = (value!=null);
                NotifyPropertyChanged("TriangulatedHdfGroup");
            }
        }

        private ResqmlHdfGroup triangulatedHdfGroupField; 
        private bool triangulatedHdfGroupSpecified = false; 

        /// <summary>
        /// bool to indicate if TriangulatedHdfGroup has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool TriangulatedHdfGroupSpecified
        {
            get {
                return triangulatedHdfGroupSpecified;
            }
            set {
                triangulatedHdfGroupSpecified= value;
            }
        }


        /// <summary>
        /// Properties for this patch.
        /// </summary>
		[Description("Properties for this patch.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A gemetrical representation of a surface using a subset of a 2d binset grid.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGrid2dPatch", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A gemetrical representation of a surface using a subset of a 2d binset grid.")]
    public partial class ResqmlGrid2dPatch : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The number of patch nodes in the I dimension of the bin grid.
        /// </summary>
		[Required]
        [Description("The number of patch nodes in the I dimension of the bin grid.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("ni")]
        public int? Ni {
            get {
                return niField;
            } 
            set {
                niField = value;
                NotifyPropertyChanged("Ni");
            }
        }

        private int? niField; 

        /// <summary>
        /// The number of patch nodes in the J dimension of the bin grid.
        /// </summary>
		[Required]
        [Description("The number of patch nodes in the J dimension of the bin grid.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("nj")]
        public int? Nj {
            get {
                return njField;
            } 
            set {
                njField = value;
                NotifyPropertyChanged("Nj");
            }
        }

        private int? njField; 

        /// <summary>
        /// The location of the patch grid origin on the I dimension of the the binGrid/survey
        /// </summary>
		[Required]
        [Description("The location of the patch grid origin on the I dimension of the the binGrid/survey")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("iStart")]
        public int? IStart {
            get {
                return iStartField;
            } 
            set {
                iStartField = value;
                NotifyPropertyChanged("IStart");
            }
        }

        private int? iStartField; 

        /// <summary>
        /// The location of the patch grid origin on the J dimension of the the binGrid/survey
        /// </summary>
		[Required]
        [Description("The location of the patch grid origin on the J dimension of the the binGrid/survey")]
        [EnergisticsDataTypeAttribute(DataType = "nonNegativeInt")]
		[XmlElement("jStart")]
        public int? JStart {
            get {
                return jStartField;
            } 
            set {
                jStartField = value;
                NotifyPropertyChanged("JStart");
            }
        }

        private int? jStartField; 

        /// <summary>
        /// The constant increment between nodes along the I axis of the binGrid. An increment that is not equal to one represents a grid coarsening where a patch cell exactly overlays iIncrement*jIncrement of the binGrid cells.
        /// </summary>
		[Required]
        [Description("The constant increment between nodes along the I axis of the binGrid. An increment that is not equal to one represents a grid coarsening where a patch cell  exactly overlays iIncrement*jIncrement of the binGrid cells.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("iIncrement")]
        public int? IIncrement {
            get {
                return iIncrementField;
            } 
            set {
                iIncrementField = value;
                NotifyPropertyChanged("IIncrement");
            }
        }

        private int? iIncrementField; 

        /// <summary>
        /// The constant increment between nodes along the J axis of the binGrid. An increment that is not equal to one represents a grid coarsening where a patch cell exactly overlays iIncrement*jIncrement of the binGrid cells.
        /// </summary>
		[Required]
        [Description("The constant increment between nodes along the J axis of the binGrid. An increment that is not equal to one represents a grid coarsening where a patch cell  exactly overlays iIncrement*jIncrement of the binGrid cells.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveInt")]
		[XmlElement("jIncrement")]
        public int? JIncrement {
            get {
                return jIncrementField;
            } 
            set {
                jIncrementField = value;
                NotifyPropertyChanged("JIncrement");
            }
        }

        private int? jIncrementField; 

        /// <summary>
        /// Points to the bin grid for which this patch is a subset.
        /// </summary>
		[Required]
        [Description("Points to the bin grid for which this patch is a subset.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("binGrid")]
        public RefGlobalNameString BinGrid {
            get {
                return binGridField;
            } 
            set {
                binGridField = value;
                NotifyPropertyChanged("BinGrid");
            }
        }

        private RefGlobalNameString binGridField; 

        /// <summary>
        /// A space delimited list of ni*nj space delimited vertical coordinates which defines the vertical coordinate at each node of the grid. The order of the items in the list is I varies fastest. I=1,J=1 represents the first value while I=2,J=1 represents the second value, etc.
        /// </summary>
        [ComponentElement]
        [XmlElement("zValueDataset")]
        [EnergisticsDataTypeAttribute(DataType = "doubleValues")]
        public DoubleValueList ZValueDataset {
            get {
                return zValueDatasetField;
            } 
            set {
                if (value != null && Grid2dHdfGroupSpecified) throw new Exception("Cannot set property ZValueDataset when property Grid2dHdfGroup is already set");
                zValueDatasetField = value;
                ZValueDatasetSpecified = (value!=null);
                NotifyPropertyChanged("ZValueDataset");
            }
        }

        private DoubleValueList zValueDatasetField; 
        private bool zValueDatasetSpecified = false; 

        /// <summary>
        /// bool to indicate if ZValueDataset has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ZValueDatasetSpecified
        {
            get {
                return zValueDatasetSpecified;
            }
            set {
                zValueDatasetSpecified= value;
            }
        }

        /// <summary>
        /// Defines information related to capturing the array data in an HDF5 formatted file.
        /// </summary>
        [ComponentElement]
        [XmlElement("grid2dHdfGroup")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHdfGroup")]
        public ResqmlHdfGroup Grid2dHdfGroup {
            get {
                return grid2dHdfGroupField;
            } 
            set {
                if (value != null && ZValueDatasetSpecified) throw new Exception("Cannot set property Grid2dHdfGroup when property ZValueDataset is already set");
                grid2dHdfGroupField = value;
                Grid2dHdfGroupSpecified = (value!=null);
                NotifyPropertyChanged("Grid2dHdfGroup");
            }
        }

        private ResqmlHdfGroup grid2dHdfGroupField; 
        private bool grid2dHdfGroupSpecified = false; 

        /// <summary>
        /// bool to indicate if Grid2dHdfGroup has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool Grid2dHdfGroupSpecified
        {
            get {
                return grid2dHdfGroupSpecified;
            }
            set {
                grid2dHdfGroupSpecified= value;
            }
        }


        /// <summary>
        /// Properties for this patch.
        /// </summary>
		[Description("Properties for this patch.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertySet")]
		[XmlElement("propertyValues")]
        public ResqmlPropertySet PropertyValues {
            get {
                return propertyValuesField;
            } 
            set {
                propertyValuesField = value;
                NotifyPropertyChanged("PropertyValues");
            }
        }

        private ResqmlPropertySet propertyValuesField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_resqmlAbstractFeatureRepresentation xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlPillarSetRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlWellMarkerRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlHybridGridRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlPointSetRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlTriangulatedRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlGrid2dRepresentation))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlAbstractFeatureRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the cs_resqmlAbstractFeatureRepresentation xsd type.")]
    public abstract partial class ResqmlAbstractFeatureRepresentation : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// A pointer to the local 3D CRS which represents the coordinates in all patchs. This must point to a child of spatialReferenceSet.
        /// </summary>
		[Required]
        [Description("A pointer to the local 3D CRS which represents the coordinates in all patchs. This must point to a child of spatialReferenceSet.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("local3dCRS")]
        public RefGlobalNameString Local3dCRS {
            get {
                return local3dCRSField;
            } 
            set {
                local3dCRSField = value;
                NotifyPropertyChanged("Local3dCRS");
            }
        }

        private RefGlobalNameString local3dCRSField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of pillar (line) set patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPillarSetRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of pillar (line) set patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlPillarSetRepresentation : ResqmlAbstractFeatureRepresentation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One surface patch.
        /// </summary>
		[Required]
        [Description("One surface patch.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPillarSetPatch")]
		[XmlElement("pillarSetPatch")]
        public List<ResqmlPillarSetPatch> PillarSetPatch {
            get {
                return pillarSetPatchField;
            } 
            set {
                pillarSetPatchField = value;
                NotifyPropertyChanged("PillarSetPatch");
            }
        }

         /// <summary>
         /// bool to indicate if PillarSetPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PillarSetPatchSpecified
         {
             get {
             if(pillarSetPatchField!=null)
                 return pillarSetPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlPillarSetPatch> pillarSetPatchField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of well marker patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlWellMarkerRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of well marker patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlWellMarkerRepresentation : ResqmlAbstractFeatureRepresentation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One well marker patch. This logically a collection of points where each point represents the intersection of this feature with one wellbore centerline.
        /// </summary>
		[Required]
        [Description("One well marker patch.  This logically a collection of points where each point represents  the intersection of this feature with one wellbore centerline.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlWellMarkerPatch")]
		[XmlElement("wellMarkerPatch")]
        public ResqmlWellMarkerPatch WellMarkerPatch {
            get {
                return wellMarkerPatchField;
            } 
            set {
                wellMarkerPatchField = value;
                NotifyPropertyChanged("WellMarkerPatch");
            }
        }

        private ResqmlWellMarkerPatch wellMarkerPatchField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A hybrid surface composed of one 2D grid patch and one triangulated mesh patch. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlHybridGridRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A hybrid surface composed of one 2D grid patch and one triangulated mesh patch. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlHybridGridRepresentation : ResqmlAbstractFeatureRepresentation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One 2d grid surface patch.
        /// </summary>
		[Required]
        [Description("One 2d grid surface patch.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGrid2dPatch")]
		[XmlElement("grid2dPatch")]
        public ResqmlGrid2dPatch Grid2dPatch {
            get {
                return grid2dPatchField;
            } 
            set {
                grid2dPatchField = value;
                NotifyPropertyChanged("Grid2dPatch");
            }
        }

        private ResqmlGrid2dPatch grid2dPatchField; 

        /// <summary>
        /// One triangulated mesh surface patch.
        /// </summary>
		[Required]
        [Description("One triangulated mesh surface patch.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlTriangulatedPatch")]
		[XmlElement("triangulatedPatch")]
        public List<ResqmlTriangulatedPatch> TriangulatedPatch {
            get {
                return triangulatedPatchField;
            } 
            set {
                triangulatedPatchField = value;
                NotifyPropertyChanged("TriangulatedPatch");
            }
        }

         /// <summary>
         /// bool to indicate if TriangulatedPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TriangulatedPatchSpecified
         {
             get {
             if(triangulatedPatchField!=null)
                 return triangulatedPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlTriangulatedPatch> triangulatedPatchField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of point set patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPointSetRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of point set patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlPointSetRepresentation : ResqmlAbstractFeatureRepresentation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One surface patch.
        /// </summary>
		[Required]
        [Description("One surface patch.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPointSetPatch")]
		[XmlElement("pointSetPatch")]
        public List<ResqmlPointSetPatch> PointSetPatch {
            get {
                return pointSetPatchField;
            } 
            set {
                pointSetPatchField = value;
                NotifyPropertyChanged("PointSetPatch");
            }
        }

         /// <summary>
         /// bool to indicate if PointSetPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PointSetPatchSpecified
         {
             get {
             if(pointSetPatchField!=null)
                 return pointSetPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlPointSetPatch> pointSetPatchField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of triangulated mesh patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlTriangulatedRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of triangulated mesh patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlTriangulatedRepresentation : ResqmlAbstractFeatureRepresentation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One triangulated mesh surface patch.
        /// </summary>
		[Required]
        [Description("One triangulated mesh surface patch.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlTriangulatedPatch")]
		[XmlElement("triangulatedPatch")]
        public List<ResqmlTriangulatedPatch> TriangulatedPatch {
            get {
                return triangulatedPatchField;
            } 
            set {
                triangulatedPatchField = value;
                NotifyPropertyChanged("TriangulatedPatch");
            }
        }

         /// <summary>
         /// bool to indicate if TriangulatedPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TriangulatedPatchSpecified
         {
             get {
             if(triangulatedPatchField!=null)
                 return triangulatedPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlTriangulatedPatch> triangulatedPatchField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of 2D grid patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGrid2dRepresentation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A set of 2D grid patches. All patches shall utilize the same CRS. This type inherits the following items: grp_resqmlTraceabilityDublinCore local3dCRS extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlGrid2dRepresentation : ResqmlAbstractFeatureRepresentation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One 2d grid surface patch.
        /// </summary>
		[Required]
        [Description("One 2d grid surface patch.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGrid2dPatch")]
		[XmlElement("grid2dPatch")]
        public List<ResqmlGrid2dPatch> Grid2dPatch {
            get {
                return grid2dPatchField;
            } 
            set {
                grid2dPatchField = value;
                NotifyPropertyChanged("Grid2dPatch");
            }
        }

         /// <summary>
         /// bool to indicate if Grid2dPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Grid2dPatchSpecified
         {
             get {
             if(grid2dPatchField!=null)
                 return grid2dPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlGrid2dPatch> grid2dPatchField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_resqmlAbstractFeatureInterpretation xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlFaultInterpretation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlHorizonInterpretation))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlAbstractFeatureInterpretation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the cs_resqmlAbstractFeatureInterpretation xsd type.")]
    public abstract partial class ResqmlAbstractFeatureInterpretation : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// One interpretation of the geometry of a fault. Multiple representations are supported but all representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed. At least one representation is required. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlFaultInterpretation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("One interpretation of the geometry of a fault. Multiple representations are supported but all representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed. At least one representation is required. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlFaultInterpretation : ResqmlAbstractFeatureInterpretation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One 2D grid representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One 2D grid representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGrid2dRepresentation")]
		[XmlElement("grid2dRepresentation")]
        public List<ResqmlGrid2dRepresentation> Grid2dRepresentation {
            get {
                return grid2dRepresentationField;
            } 
            set {
                grid2dRepresentationField = value;
                NotifyPropertyChanged("Grid2dRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if Grid2dRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Grid2dRepresentationSpecified
         {
             get {
             if(grid2dRepresentationField!=null)
                 return grid2dRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlGrid2dRepresentation> grid2dRepresentationField; 

        /// <summary>
        /// One triangulated mesh representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One triangulated mesh representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlTriangulatedRepresentation")]
		[XmlElement("triangulatedRepresentation")]
        public List<ResqmlTriangulatedRepresentation> TriangulatedRepresentation {
            get {
                return triangulatedRepresentationField;
            } 
            set {
                triangulatedRepresentationField = value;
                NotifyPropertyChanged("TriangulatedRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if TriangulatedRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TriangulatedRepresentationSpecified
         {
             get {
             if(triangulatedRepresentationField!=null)
                 return triangulatedRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlTriangulatedRepresentation> triangulatedRepresentationField; 

        /// <summary>
        /// One pillar (line) set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One pillar (line) set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPillarSetRepresentation")]
		[XmlElement("pillarSetRepresentation")]
        public List<ResqmlPillarSetRepresentation> PillarSetRepresentation {
            get {
                return pillarSetRepresentationField;
            } 
            set {
                pillarSetRepresentationField = value;
                NotifyPropertyChanged("PillarSetRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if PillarSetRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PillarSetRepresentationSpecified
         {
             get {
             if(pillarSetRepresentationField!=null)
                 return pillarSetRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlPillarSetRepresentation> pillarSetRepresentationField; 

        /// <summary>
        /// One point set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One point set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPointSetRepresentation")]
		[XmlElement("pointSetRepresentation")]
        public List<ResqmlPointSetRepresentation> PointSetRepresentation {
            get {
                return pointSetRepresentationField;
            } 
            set {
                pointSetRepresentationField = value;
                NotifyPropertyChanged("PointSetRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if PointSetRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PointSetRepresentationSpecified
         {
             get {
             if(pointSetRepresentationField!=null)
                 return pointSetRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlPointSetRepresentation> pointSetRepresentationField; 

        /// <summary>
        /// One well marker representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One well marker representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlWellMarkerRepresentation")]
		[XmlElement("wellMarkerRepresentation")]
        public List<ResqmlWellMarkerRepresentation> WellMarkerRepresentation {
            get {
                return wellMarkerRepresentationField;
            } 
            set {
                wellMarkerRepresentationField = value;
                NotifyPropertyChanged("WellMarkerRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if WellMarkerRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool WellMarkerRepresentationSpecified
         {
             get {
             if(wellMarkerRepresentationField!=null)
                 return wellMarkerRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlWellMarkerRepresentation> wellMarkerRepresentationField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// One interpretation of the geometry of a horizon. Multiple representations are supported but all representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed. At least one representation is required. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlHorizonInterpretation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("One interpretation of the geometry of a horizon. Multiple representations are supported but all representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed. At least one representation is required. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlHorizonInterpretation : ResqmlAbstractFeatureInterpretation, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One 2D grid representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One 2D grid representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGrid2dRepresentation")]
		[XmlElement("grid2dRepresentation")]
        public List<ResqmlGrid2dRepresentation> Grid2dRepresentation {
            get {
                return grid2dRepresentationField;
            } 
            set {
                grid2dRepresentationField = value;
                NotifyPropertyChanged("Grid2dRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if Grid2dRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Grid2dRepresentationSpecified
         {
             get {
             if(grid2dRepresentationField!=null)
                 return grid2dRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlGrid2dRepresentation> grid2dRepresentationField; 

        /// <summary>
        /// One triangulated mesh representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One triangulated mesh representation of this interpretation of the horizon. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlTriangulatedRepresentation")]
		[XmlElement("triangulatedRepresentation")]
        public List<ResqmlTriangulatedRepresentation> TriangulatedRepresentation {
            get {
                return triangulatedRepresentationField;
            } 
            set {
                triangulatedRepresentationField = value;
                NotifyPropertyChanged("TriangulatedRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if TriangulatedRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TriangulatedRepresentationSpecified
         {
             get {
             if(triangulatedRepresentationField!=null)
                 return triangulatedRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlTriangulatedRepresentation> triangulatedRepresentationField; 

        /// <summary>
        /// One point set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One point set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPointSetRepresentation")]
		[XmlElement("pointSetRepresentation")]
        public List<ResqmlPointSetRepresentation> PointSetRepresentation {
            get {
                return pointSetRepresentationField;
            } 
            set {
                pointSetRepresentationField = value;
                NotifyPropertyChanged("PointSetRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if PointSetRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PointSetRepresentationSpecified
         {
             get {
             if(pointSetRepresentationField!=null)
                 return pointSetRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlPointSetRepresentation> pointSetRepresentationField; 

        /// <summary>
        /// One point set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One point set representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHybridGridRepresentation")]
		[XmlElement("hybridGridRepresentation")]
        public List<ResqmlHybridGridRepresentation> HybridGridRepresentation {
            get {
                return hybridGridRepresentationField;
            } 
            set {
                hybridGridRepresentationField = value;
                NotifyPropertyChanged("HybridGridRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if HybridGridRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool HybridGridRepresentationSpecified
         {
             get {
             if(hybridGridRepresentationField!=null)
                 return hybridGridRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlHybridGridRepresentation> hybridGridRepresentationField; 

        /// <summary>
        /// One well marker representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth. That is, a mixture of time and depth representations is not allowed.
        /// </summary>
		[Description("One well marker representation of this interpretation of the fault. Each representation must represent the same opinion of the geometry for this interpretation. All representations must be either in time or in depth.  That is, a mixture of time and depth representations is not allowed.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlWellMarkerRepresentation")]
		[XmlElement("wellMarkerRepresentation")]
        public List<ResqmlWellMarkerRepresentation> WellMarkerRepresentation {
            get {
                return wellMarkerRepresentationField;
            } 
            set {
                wellMarkerRepresentationField = value;
                NotifyPropertyChanged("WellMarkerRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if WellMarkerRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool WellMarkerRepresentationSpecified
         {
             get {
             if(wellMarkerRepresentationField!=null)
                 return wellMarkerRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlWellMarkerRepresentation> wellMarkerRepresentationField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_resqmlAbstractGeologicFeature xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlHorizon))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlAbstractGeologicFeature", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the cs_resqmlAbstractGeologicFeature xsd type.")]
    public abstract partial class ResqmlAbstractGeologicFeature : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Information specific to one geologic fault. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlFault", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Information specific to one geologic fault. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlFault : ResqmlAbstractGeologicFeature, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One interpretaion of the geometry of the fault.
        /// </summary>
		[Description("One interpretaion of the geometry of the fault.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlFaultInterpretation")]
		[XmlElement("faultInterpretation")]
        public List<ResqmlFaultInterpretation> FaultInterpretation {
            get {
                return faultInterpretationField;
            } 
            set {
                faultInterpretationField = value;
                NotifyPropertyChanged("FaultInterpretation");
            }
        }

         /// <summary>
         /// bool to indicate if FaultInterpretation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool FaultInterpretationSpecified
         {
             get {
             if(faultInterpretationField!=null)
                 return faultInterpretationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlFaultInterpretation> faultInterpretationField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Information specific to one geologic horizon. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlHorizon", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Information specific to one geologic horizon. This type inherits the following items: grp_resqmlTraceabilityDublinCore extensionAny extensionNameValue attgrp_uidGlobal ")]
    public partial class ResqmlHorizon : ResqmlAbstractGeologicFeature, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// One interpretation of the geometry of the horizon.
        /// </summary>
		[Description("One interpretation of the geometry of the horizon.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHorizonInterpretation")]
		[XmlElement("horizonInterpretation")]
        public List<ResqmlHorizonInterpretation> HorizonInterpretation {
            get {
                return horizonInterpretationField;
            } 
            set {
                horizonInterpretationField = value;
                NotifyPropertyChanged("HorizonInterpretation");
            }
        }

         /// <summary>
         /// bool to indicate if HorizonInterpretation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool HorizonInterpretationSpecified
         {
             get {
             if(horizonInterpretationField!=null)
                 return horizonInterpretationField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlHorizonInterpretation> horizonInterpretationField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A container for interface features.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlInterfaceFeatureSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A container for interface features.")]
    public partial class ResqmlInterfaceFeatureSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A horizon which is represented within a model.
        /// </summary>
		[Description("A horizon which is represented within a model.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlHorizon")]
		[XmlElement("horizon")]
        public List<ResqmlHorizon> Horizon {
            get {
                return horizonField;
            } 
            set {
                horizonField = value;
                NotifyPropertyChanged("Horizon");
            }
        }

         /// <summary>
         /// bool to indicate if Horizon has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool HorizonSpecified
         {
             get {
             if(horizonField!=null)
                 return horizonField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlHorizon> horizonField; 

        /// <summary>
        /// A fault which is represented within a model.
        /// </summary>
		[Description("A fault which is represented within a model.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlFault")]
		[XmlElement("fault")]
        public List<ResqmlFault> Fault {
            get {
                return faultField;
            } 
            set {
                faultField = value;
                NotifyPropertyChanged("Fault");
            }
        }

         /// <summary>
         /// bool to indicate if Fault has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool FaultSpecified
         {
             get {
             if(faultField!=null)
                 return faultField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlFault> faultField; 

        /// <summary>
        /// A bin grid that is utilized within a 2d grid patch.
        /// </summary>
		[Description("A bin grid that is utilized within a 2d grid patch.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlBinGrid")]
		[XmlElement("binGrid")]
        public List<ResqmlBinGrid> BinGrid {
            get {
                return binGridField;
            } 
            set {
                binGridField = value;
                NotifyPropertyChanged("BinGrid");
            }
        }

         /// <summary>
         /// bool to indicate if BinGrid has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BinGridSpecified
         {
             get {
             if(binGridField!=null)
                 return binGridField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlBinGrid> binGridField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A list of timesteps.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlTimeStepList", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A list of timesteps.")]
    public partial class ResqmlTimeStepList : Object, IEnergisticsCollection, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

        /// <summary>
        /// A timestamp. The order within the aggregate must be retained.
        /// </summary>
		[Description("A timestamp. The order within the aggregate must be retained.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "timestamp")]
		[XmlElement("timeStep")]
        public List<DateTime> TimeStep {
            get {
                return timeStepField;
            } 
            set {
                timeStepField = value;
                NotifyPropertyChanged("TimeStep");
            }
        }

         /// <summary>
         /// bool to indicate if TimeStep has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TimeStepSpecified
         {
             get {
             if(timeStepField!=null)
                 return timeStepField.Count>0?true:false;
             else return false;
             }
         }
        private List<DateTime> timeStepField; 

        /// <summary>
        /// A timestamp. The order within the aggregate must be retained.
        /// </summary>
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return TimeStep;
			}
        }
		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Group of properties used or created together.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPropertyGroup", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Group of properties used or created together.")]
    public partial class ResqmlPropertyGroup : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// A textual description of the property.
        /// </summary>
		[Description("A textual description of the property.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "commentString")]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// A pointer to the parent property group of this property group.
        /// </summary>
		[Description("A pointer to the parent property group of this property group.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("parentGroup")]
        public RefGlobalNameString ParentGroup {
            get {
                return parentGroupField;
            } 
            set {
                parentGroupField = value;
                NotifyPropertyChanged("ParentGroup");
            }
        }

        private RefGlobalNameString parentGroupField; 

        /// <summary>
        /// description1 property
        /// </summary>
		
		[XmlElement("description")]
        public string Description1 {
            get {
                return description1Field;
            } 
            set {
                description1Field = value;
                NotifyPropertyChanged("Description1");
            }
        }

        private string description1Field; 

        /// <summary>
        /// A pointer to a specific timestamp in a timestep list.
        /// </summary>
		[Description("A pointer to a specific timestamp in a timestep list.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlRefTimeStep")]
		[XmlElement("timeStep")]
        public ResqmlRefTimeStep TimeStep {
            get {
                return timeStepField;
            } 
            set {
                timeStepField = value;
                NotifyPropertyChanged("TimeStep");
            }
        }

        private ResqmlRefTimeStep timeStepField; 

        /// <summary>
        /// A pointer to a property that is a member of this group. This will point to either continuousPropertyValues, discretePropertyValues or categoricalPropertyValues (each has a type that is a specialization of cs_resqmlAbstractPropertyValues).
        /// </summary>
		[Required]
        [Description("A pointer to a property that is a member of this group. This will point to either continuousPropertyValues, discretePropertyValues or categoricalPropertyValues (each has a type that is a specialization of cs_resqmlAbstractPropertyValues).")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
		[XmlElement("memberProperty")]
        public List<RefGlobalNameString> MemberProperty {
            get {
                return memberPropertyField;
            } 
            set {
                memberPropertyField = value;
                NotifyPropertyChanged("MemberProperty");
            }
        }

         /// <summary>
         /// bool to indicate if MemberProperty has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool MemberPropertySpecified
         {
             get {
             if(memberPropertyField!=null)
                 return memberPropertyField.Count>0?true:false;
             else return false;
             }
         }
        private List<RefGlobalNameString> memberPropertyField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A container for property groups.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPropertyGroupSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A container for property groups.")]
    public partial class ResqmlPropertyGroupSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines a named group of properties.
        /// </summary>
		[Description("Defines a named group of properties.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertyGroup")]
		[XmlElement("propertyGroup")]
        public List<ResqmlPropertyGroup> PropertyGroup {
            get {
                return propertyGroupField;
            } 
            set {
                propertyGroupField = value;
                NotifyPropertyChanged("PropertyGroup");
            }
        }

         /// <summary>
         /// bool to indicate if PropertyGroup has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PropertyGroupSpecified
         {
             get {
             if(propertyGroupField!=null)
                 return propertyGroupField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlPropertyGroup> propertyGroupField; 

        /// <summary>
        /// Defines a named list of time steps.
        /// </summary>
		[Description("Defines a named list of time steps.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlTimeStepList")]
		[XmlElement("timeStepList")]
        public List<ResqmlTimeStepList> TimeStepList {
            get {
                return timeStepListField;
            } 
            set {
                timeStepListField = value;
                NotifyPropertyChanged("TimeStepList");
            }
        }

         /// <summary>
         /// bool to indicate if TimeStepList has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TimeStepListSpecified
         {
             get {
             if(timeStepListField!=null)
                 return timeStepListField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlTimeStepList> timeStepListField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A description of property name relative to a standard definition.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlPropertyKind", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A description of property name relative to a standard definition.")]
    public partial class StandAloneResqmlPropertyKind : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// The name of the dictionary within which the property is unique. This also defines the name of the controlling authority. A URN of the form "urn:x-resqml:domainOrEmail:dictionaryName" should be used for the namingSystem value. An example public dictionary, "urn:resqml:energistics.org:RESQML" assigned to values defined by ResqmlPropertyKind. An example corporate dictionary, "urn:resqml:slb.com:product-x". An example personal dictionary, "urn:resqml:first.last@mycompany.com:my.first.dictionary". The purpose of this scheme is to generate a unique name. Parsing for semantics is not intended.
        /// </summary>
		[Required]
        [StringLength(4000)]
        [Description("The name of the dictionary within which the property is unique. This also defines the name of the controlling authority. A URN of the form \"urn:x-resqml:domainOrEmail:dictionaryName\" should be used for the namingSystem value. An example public dictionary,    \"urn:resqml:energistics.org:RESQML\" assigned to values defined by ResqmlPropertyKind. An example corporate dictionary, \"urn:resqml:slb.com:product-x\". An example personal dictionary,  \"urn:resqml:first.last@mycompany.com:my.first.dictionary\". The purpose of this scheme is to generate a unique name. Parsing for semantics is not intended.")]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
		[XmlElement("namingSystem", DataType="anyURI")]
        public string NamingSystem {
            get {
                return namingSystemField;
            } 
            set {
                namingSystemField = value;
                NotifyPropertyChanged("NamingSystem");
            }
        }

        private string namingSystemField; 

        /// <summary>
        /// A value of True ("true" or "1") indicates that the property kind is abstract and an instance of property values must not represent this kind. A value of False ("false" or "0") indicates otherise (i.e., that an instance of property values may represent this kind). 
        /// </summary>
		[Required]
        [Description("A value of True (\"true\" or \"1\") indicates that the property kind is abstract and an instance of property values must not represent this kind. A value of False (\"false\" or \"0\") indicates otherise (i.e., that an instance of property values  may represent this kind).")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("isAbstract")]
        public bool? IsAbstract {
            get {
                return isAbstractField;
            } 
            set {
                isAbstractField = value;
                NotifyPropertyChanged("IsAbstract");
            }
        }

        private bool? isAbstractField; 

        /// <summary>
        /// The name of the RESQML standard property that this represents. For properties which have a unit of measure, the standard kind will directly or indirectly specify the single unit of measure which must be utilized for the property values.
        /// </summary>
        [XmlElement("resqmlKind")]
        [EnergisticsDataTypeAttribute(DataType = "ResqmlPropertyKind")]
        public ResqmlPropertyKind ResqmlKind {
            get {
                return resqmlKindField;
            } 
            set {
                if (value != null && ParentLocalKindSpecified) throw new Exception("Cannot set property ResqmlKind when property ParentLocalKind is already set");
                if (value != null && ParentResqmlKindSpecified) throw new Exception("Cannot set property ResqmlKind when property ParentResqmlKind is already set");
                resqmlKindField = value;
                ResqmlKindSpecified = (value!=null);
                NotifyPropertyChanged("ResqmlKind");
            }
        }

        private ResqmlPropertyKind resqmlKindField; 
        private bool resqmlKindSpecified = false; 

        /// <summary>
        /// bool to indicate if ResqmlKind has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ResqmlKindSpecified
        {
            get {
                return resqmlKindSpecified;
            }
            set {
                resqmlKindSpecified= value;
            }
        }

        /// <summary>
        /// The parent RESQML standard property which this specializes. The semantics of this property is a specialization of the specified standard property. For properties which have a unit of measure, the parent kind will indirectly specify the single unit of measure which must be utilized for the property values.
        /// </summary>
        [XmlElement("parentResqmlKind")]
        [EnergisticsDataTypeAttribute(DataType = "ResqmlPropertyKind")]
        public ResqmlPropertyKind ParentResqmlKind {
            get {
                return parentResqmlKindField;
            } 
            set {
                if (value != null && ParentLocalKindSpecified) throw new Exception("Cannot set property ParentResqmlKind when property ParentLocalKind is already set");
                if (value != null && ResqmlKindSpecified) throw new Exception("Cannot set property ParentResqmlKind when property ResqmlKind is already set");
                parentResqmlKindField = value;
                ParentResqmlKindSpecified = (value!=null);
                NotifyPropertyChanged("ParentResqmlKind");
            }
        }

        private ResqmlPropertyKind parentResqmlKindField; 
        private bool parentResqmlKindSpecified = false; 

        /// <summary>
        /// bool to indicate if ParentResqmlKind has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ParentResqmlKindSpecified
        {
            get {
                return parentResqmlKindSpecified;
            }
            set {
                parentResqmlKindSpecified= value;
            }
        }

        /// <summary>
        /// A pointer to parent locally defined property. The semantics of this property is a specialization of the specified local property. Note that all local kinds must directly or indirectly be related to a standard RESQML standard kind.
        /// </summary>
        [ComponentElement]
        [XmlElement("parentLocalKind")]
        [EnergisticsDataTypeAttribute(DataType = "refGlobalNameString")]
        public RefGlobalNameString ParentLocalKind {
            get {
                return parentLocalKindField;
            } 
            set {
                if (value != null && ParentResqmlKindSpecified) throw new Exception("Cannot set property ParentLocalKind when property ParentResqmlKind is already set");
                if (value != null && ResqmlKindSpecified) throw new Exception("Cannot set property ParentLocalKind when property ResqmlKind is already set");
                parentLocalKindField = value;
                ParentLocalKindSpecified = (value!=null);
                NotifyPropertyChanged("ParentLocalKind");
            }
        }

        private RefGlobalNameString parentLocalKindField; 
        private bool parentLocalKindSpecified = false; 

        /// <summary>
        /// bool to indicate if ParentLocalKind has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ParentLocalKindSpecified
        {
            get {
                return parentLocalKindSpecified;
            }
            set {
                parentLocalKindSpecified= value;
            }
        }


        /// <summary>
        /// ItemElementName property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public ItemChoiceType? ItemElementName {
            get {
                return ItemElementNameField;
            } 
            set {
                ItemElementNameField = value;
                 this.ItemElementNameSpecified = true;
                NotifyPropertyChanged("ItemElementName");
            }
        }

        
        private bool ItemElementNameSpecifiedField = false;
        
        /// <summary>
        /// ItemElementNameSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool ItemElementNameSpecified {
            get {
                return ItemElementNameSpecifiedField;
            } 
            set {
                ItemElementNameSpecifiedField = value;
                NotifyPropertyChanged("ItemElementNameSpecified");
            }
        }
        
        private ItemChoiceType? ItemElementNameField; 

        /// <summary>
        /// The allowed unit of measure for the continuous property. For a locally defined property, this must match the unit of the parent kind (and of its parent kind, etc). If you set this property, you must also set DimensionalClass.
        /// </summary>
        [XmlElement("unitOfMeasure")]
        [EnergisticsDataTypeAttribute(DataType = "ResqmlUnitOfMeasure")]
        public ResqmlUnitOfMeasure UnitOfMeasure {
            get {
                return unitOfMeasureField;
            } 
            set {
                if (value != null && EnumValueSpecified) throw new Exception("Cannot set property UnitOfMeasure when property EnumValue is already set");
                if (value != null && MaximumValueSpecified) throw new Exception("Cannot set property UnitOfMeasure when property MaximumValue is already set");
                if (value != null && MinimumValueSpecified) throw new Exception("Cannot set property UnitOfMeasure when property MinimumValue is already set");
                unitOfMeasureField = value;
                UnitOfMeasureSpecified = (value!=null);
                NotifyPropertyChanged("UnitOfMeasure");
            }
        }

        private ResqmlUnitOfMeasure unitOfMeasureField; 
        private bool unitOfMeasureSpecified = false; 

        /// <summary>
        /// bool to indicate if UnitOfMeasure has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool UnitOfMeasureSpecified
        {
            get {
                return unitOfMeasureSpecified;
            }
            set {
                unitOfMeasureSpecified= value;
            }
        }

        /// <summary>
        /// The dimensional analysis of the unit of measure. For example, a meter (m) would be of class "L", which represents length. Note that angle is considered to be dimensionless ratio of length. Note that solid angle is considered to be dimensionless ratio of area. The following nomenclature is used: A = angle (SI unit = radian) B = luminous intensity (SI unit = candela) C = electrical current (SI unit = ampere) K = thermodynamic temperature (SI unit = kelvin) L = length (SI unit = metre) M = mass (SI unit = kilogram) N = amount of substance (SI unit = mole) S = solid angle (SI unit = steradian) T = time (SI unit = second) 1 = dimensionless 2 = squared (e.g., "M2") 3 = cubed 4 = 4th power 5 = 5th power 6 = 6th power 7 = 7th power 8 = 8th power / = division ratio(X) = A dimensionless ratio of another dimension. For example, a dimensionless ratio of area would be indicated by "ratio(L2)" and represents the equivalent of "L2/L2". This is only used when the underlying dimension would otherwise be "1". The values may be broken into numerator and denominator separated by a slash "/" but multiple slashes must not be used. A slash must not terminate the string. For example, length per time would be indicated by "L/T" A number other than "1" will always follow a single dimensional character (e.g., "M2") and will represent the power of that component. The number "1" will only exist by itself or as the whole numerator (e.g., "1" or "1/T"). The number "1" must not be used as a denominator because it is implied (e.g., "M" impiles "M/1"). For consistency, the items within a numerator or denominator are listed in alphabetical order (e.g., LM - not ML). If you set this property, you must also set UnitOfMeasure.
        /// </summary>
        [XmlElement("dimensionalClass")]
        [EnergisticsDataTypeAttribute(DataType = "string")]
        public string DimensionalClass {
            get {
                return dimensionalClassField;
            } 
            set {
                if (value != null && EnumValueSpecified) throw new Exception("Cannot set property DimensionalClass when property EnumValue is already set");
                if (value != null && MaximumValueSpecified) throw new Exception("Cannot set property DimensionalClass when property MaximumValue is already set");
                if (value != null && MinimumValueSpecified) throw new Exception("Cannot set property DimensionalClass when property MinimumValue is already set");
                dimensionalClassField = value;
                DimensionalClassSpecified = (value!=null);
                NotifyPropertyChanged("DimensionalClass");
            }
        }

        private string dimensionalClassField; 
        private bool dimensionalClassSpecified = false; 

        /// <summary>
        /// bool to indicate if DimensionalClass has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool DimensionalClassSpecified
        {
            get {
                return dimensionalClassSpecified;
            }
            set {
                dimensionalClassSpecified= value;
            }
        }

        /// <summary>
        /// The minimum value allowed for the discrete property. If you set this property, you must also set MaximumValue.
        /// </summary>
        [XmlElement("minimumValue")]
        [EnergisticsDataTypeAttribute(DataType = "long")]
        public long? MinimumValue {
            get {
                return minimumValueField;
            } 
            set {
                if (value != null && DimensionalClassSpecified) throw new Exception("Cannot set property MinimumValue when property DimensionalClass is already set");
                if (value != null && EnumValueSpecified) throw new Exception("Cannot set property MinimumValue when property EnumValue is already set");
                if (value != null && UnitOfMeasureSpecified) throw new Exception("Cannot set property MinimumValue when property UnitOfMeasure is already set");
                minimumValueField = value;
                MinimumValueSpecified = (value!=null);
                NotifyPropertyChanged("MinimumValue");
            }
        }

        private long? minimumValueField; 
        private bool minimumValueSpecified = false; 

        /// <summary>
        /// bool to indicate if MinimumValue has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool MinimumValueSpecified
        {
            get {
                return minimumValueSpecified;
            }
            set {
                minimumValueSpecified= value;
            }
        }

        /// <summary>
        /// The maximum value allowed for the discrete property. If you set this property, you must also set MinimumValue.
        /// </summary>
        [XmlElement("maximumValue")]
        [EnergisticsDataTypeAttribute(DataType = "long")]
        public long? MaximumValue {
            get {
                return maximumValueField;
            } 
            set {
                if (value != null && DimensionalClassSpecified) throw new Exception("Cannot set property MaximumValue when property DimensionalClass is already set");
                if (value != null && EnumValueSpecified) throw new Exception("Cannot set property MaximumValue when property EnumValue is already set");
                if (value != null && UnitOfMeasureSpecified) throw new Exception("Cannot set property MaximumValue when property UnitOfMeasure is already set");
                maximumValueField = value;
                MaximumValueSpecified = (value!=null);
                NotifyPropertyChanged("MaximumValue");
            }
        }

        private long? maximumValueField; 
        private bool maximumValueSpecified = false; 

        /// <summary>
        /// bool to indicate if MaximumValue has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool MaximumValueSpecified
        {
            get {
                return maximumValueSpecified;
            }
            set {
                maximumValueSpecified= value;
            }
        }

        /// <summary>
        /// A value allowed for the categorical property.
        /// </summary>
        [XmlElement("enumValue")]
        [EnergisticsDataTypeAttribute(DataType = "string")]
        public string[] EnumValue {
            get {
                return enumValueField;
            } 
            set {
                if (value != null && DimensionalClassSpecified) throw new Exception("Cannot set property EnumValue when property DimensionalClass is already set");
                if (value != null && MaximumValueSpecified) throw new Exception("Cannot set property EnumValue when property MaximumValue is already set");
                if (value != null && MinimumValueSpecified) throw new Exception("Cannot set property EnumValue when property MinimumValue is already set");
                if (value != null && UnitOfMeasureSpecified) throw new Exception("Cannot set property EnumValue when property UnitOfMeasure is already set");
                enumValueField = value;
                EnumValueSpecified = (value!=null);
                NotifyPropertyChanged("EnumValue");
            }
        }

        private string[] enumValueField; 
        private bool enumValueSpecified = false; 

        /// <summary>
        /// bool to indicate if EnumValue has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool EnumValueSpecified
        {
            get {
                return enumValueSpecified;
            }
            set {
                enumValueSpecified= value;
            }
        }


        /// <summary>
        /// ItemsElementName property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public List<ItemsChoiceType1> ItemsElementName {
            get {
                return ItemsElementNameField;
            } 
            set {
                ItemsElementNameField = value;
                NotifyPropertyChanged("ItemsElementName");
            }
        }

         /// <summary>
         /// bool to indicate if ItemsElementName has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ItemsElementNameSpecified
         {
             get {
             if(ItemsElementNameField!=null)
                 return ItemsElementNameField.Count>0?true:false;
             else return false;
             }
         }
        private List<ItemsChoiceType1> ItemsElementNameField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines a local 3D Coordinate Reference System (CRS). The local CRS MUST form a cartesian system of axes. The local areal axes MUST be in the plane of the projected system. The local areal axes MUST be orthogonal to each other. The ordinals of the local system MUST be defined in units of meters. This 3D system is semantically equivalent to a Compound CRS composed of a local 2d areal system and a local 1d vertical system. The vertical axis is always positive when moving from the origin toward the center of the Earth. The ordinal of the vertical axis MUST be defined in units of meter (or second if offset from a time system). The labels associated with the axes on this local system are X, Y, Z. The Y axis is 90 degrees counter-clockwise from the X axis. If this local system 1) has an areal origin which coincides (0,0) with the origin of the projected system 2) and has a rotation of zero then the first two axes of the local system will coincide with the axes of the global 2D system. That is, the Y axis would coincide with the global axis which is 90 degrees from the other global axis.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlLocal3dCRS", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines a local 3D Coordinate Reference System (CRS). The local CRS MUST form a cartesian system of axes. The local areal axes MUST be in the plane of the projected system. The local areal axes MUST be orthogonal to each other. The ordinals of the local system MUST be defined in units of meters. This 3D system is semantically equivalent to a Compound CRS composed of a local 2d areal system and a local 1d vertical system. The vertical axis is always positive when moving from the origin toward the center of the Earth. The ordinal of the vertical axis MUST be defined in units of meter (or second if offset from a time system). The labels associated with the axes on this local system are X, Y, Z. The Y axis is 90 degrees counter-clockwise from the X axis. If this local system 1) has an areal origin which coincides (0,0) with the origin of the projected system 2) and has a rotation of zero then the first two axes of the local system will coincide with the axes of the global 2D system. That is, the Y axis would coincide with the global axis which is 90 degrees from the other global axis.")]
    public partial class ResqmlLocal3dCRS : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// contributor property
        /// </summary>
		[ComponentElement]
		[XmlElement("contributor", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Contributor {
            get {
                return contributorField;
            } 
            set {
                contributorField = value;
                NotifyPropertyChanged("Contributor");
            }
        }

        private DublinCoreString contributorField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// modified property
        /// </summary>
		
		[XmlElement("modified", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Modified {
            get {
                return modifiedField;
            } 
            set {
                modifiedField = value;
                NotifyPropertyChanged("Modified");
            }
        }

        private AbstractW3CDTF modifiedField; 

        /// <summary>
        /// source property
        /// </summary>
		
		[XmlElement("source", Namespace="http://purl.org/dc/terms/")]
        public string Source {
            get {
                return sourceField;
            } 
            set {
                sourceField = value;
                NotifyPropertyChanged("Source");
            }
        }

        private string sourceField; 

        /// <summary>
        /// bibliographicCitation property
        /// </summary>
		[RecurringElement]
		[XmlElement("bibliographicCitation", Namespace="http://purl.org/dc/terms/")]
        public List<DublinCoreString> BibliographicCitation {
            get {
                return bibliographicCitationField;
            } 
            set {
                bibliographicCitationField = value;
                NotifyPropertyChanged("BibliographicCitation");
            }
        }

         /// <summary>
         /// bool to indicate if BibliographicCitation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BibliographicCitationSpecified
         {
             get {
             if(bibliographicCitationField!=null)
                 return bibliographicCitationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DublinCoreString> bibliographicCitationField; 

        /// <summary>
        /// The first ordinal of the location of the origin of the local areal axes relative to the global projected CRS. The value MUST represent the first axis of the global system. The unit of measure is defined by the unit of measure for the global 2D CRS.
        /// </summary>
		[Required]
        [Description("The first ordinal of the location of the origin of the  local areal axes relative to the global projected CRS. The value MUST represent the first axis of the global system. The unit of measure is defined by the unit of measure for the global 2D CRS.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("originOrdinal1")]
        public double? OriginOrdinal1 {
            get {
                return originOrdinal1Field;
            } 
            set {
                originOrdinal1Field = value;
                NotifyPropertyChanged("OriginOrdinal1");
            }
        }

        private double? originOrdinal1Field; 

        /// <summary>
        /// The second ordinal of the location of the origin of the local areal axes relative to the global projected CRS. The value MUST represent the second axis of the global system. The unit of measure is defined by the unit of measure for the global 2D CRS.
        /// </summary>
		[Required]
        [Description("The second ordinal of the location of the origin of the  local areal axes relative to the global projected CRS. The value MUST represent the second axis of the global system. The unit of measure is defined by the unit of measure for the global 2D CRS.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("originOrdinal2")]
        public double? OriginOrdinal2 {
            get {
                return originOrdinal2Field;
            } 
            set {
                originOrdinal2Field = value;
                NotifyPropertyChanged("OriginOrdinal2");
            }
        }

        private double? originOrdinal2Field; 

        /// <summary>
        /// The rotation in radians of the the local Y axis relative to the global projected axis which is 90 degrees counter-clockwise from the other global axis. A positive value indicates a clockwise rotation from the global axis. A negative value indicates a counterclockwise rotation form the global axis. 
        /// </summary>
		[Required]
        [Description("The rotation in radians of the the local Y axis relative to the  global projected axis which is 90 degrees counter-clockwise from the other global axis. A positive value indicates a clockwise rotation from the global axis. A negative value indicates a counterclockwise rotation form the global axis.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("arealRotation")]
        public double? ArealRotation {
            get {
                return arealRotationField;
            } 
            set {
                arealRotationField = value;
                NotifyPropertyChanged("ArealRotation");
            }
        }

        private double? arealRotationField; 

        /// <summary>
        /// The vertical location of the origin of this local system in the global vertical CRS. The unit of measure is defined by the unit of measure for the global vertical CRS.
        /// </summary>
		[Required]
        [Description("The vertical location of the origin of this local system in the global vertical CRS. The unit of measure is defined by the unit of measure for the global vertical CRS.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("originOrdinal3")]
        public double? OriginOrdinal3 {
            get {
                return originOrdinal3Field;
            } 
            set {
                originOrdinal3Field = value;
                NotifyPropertyChanged("OriginOrdinal3");
            }
        }

        private double? originOrdinal3Field; 

        /// <summary>
        /// The vertical location of the origin of this local system in the global vertical CRS. The unit of measure is defined by the unit of measure for the global vertical time CRS. The vertical ordinal of the local system MUST be defined in units of second. If this element is not defined then the vertical ordinal of the local system MUST be defined in units of meter.
        /// </summary>
		[Description("The vertical location of the origin of this local system in the global vertical CRS. The unit of measure is defined by the unit of measure for the global vertical time CRS. The vertical ordinal of the local system MUST be defined in units of second. If this element is not defined then the vertical ordinal of the local system MUST be defined in units of meter.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("timeOrigin")]
        public double? TimeOrigin {
            get {
                return timeOriginField;
            } 
            set {
                timeOriginField = value;
                 this.TimeOriginSpecified = true;
                NotifyPropertyChanged("TimeOrigin");
            }
        }

        private double? timeOriginField; 

        /// <summary>
        /// timeOriginSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool TimeOriginSpecified {
            get {
                return timeOriginSpecifiedField;
            } 
            set {
                timeOriginSpecifiedField = value;
                NotifyPropertyChanged("TimeOriginSpecified");
            }
        }

        private bool timeOriginSpecifiedField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionAny")]
		[XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny {
            get {
                return extensionAnyField;
            } 
            set {
                extensionAnyField = value;
                NotifyPropertyChanged("ExtensionAny");
            }
        }

        private ExtensionAny extensionAnyField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlExtensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ResqmlExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Required]
        [RegularExpression("[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. The value must be globally unique.")]
        [EnergisticsDataTypeAttribute(DataType = "uuidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines a 1D Vertical Time Coordinate Reference System (CRS) relative to the global vertical (length) CRS. The label associated with the axis on this system is Z.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGlobalTimeCRS", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines a 1D Vertical Time Coordinate Reference System (CRS) relative to the global vertical (length) CRS. The label associated with the axis on this system is Z.")]
    public partial class ResqmlGlobalTimeCRS : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The vertical location of the origin of this local system in the global vertical (length) CRS. The unit of measure is defined by the unit of measure for the global vertical CRS.
        /// </summary>
		[Required]
        [Description("The vertical location of the origin of this local system in the global vertical (length) CRS. The unit of measure is defined by the unit of measure for the global vertical CRS.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("verticalOrigin")]
        public double? VerticalOrigin {
            get {
                return verticalOriginField;
            } 
            set {
                verticalOriginField = value;
                NotifyPropertyChanged("VerticalOrigin");
            }
        }

        private double? verticalOriginField; 

        /// <summary>
        /// Defines the unit of measure of all vertical (seismic two-way) time coordinates. The direction is positve when traveling toward the center of the Earth.
        /// </summary>
		[Required]
        [Description("Defines the unit of measure of all vertical (seismic two-way) time coordinates. The direction is positve when traveling toward the center of the Earth.")]
        [EnergisticsDataTypeAttribute(DataType = "VerticalTimeUnit")]
		[XmlElement("timeUnit")]
        public VerticalTimeUnit? TimeUnit {
            get {
                return timeUnitField;
            } 
            set {
                timeUnitField = value;
                 this.TimeUnitSpecified = true;
                NotifyPropertyChanged("TimeUnit");
            }
        }

        
        private bool TimeUnitSpecifiedField = false;
        
        /// <summary>
        /// TimeUnitSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool TimeUnitSpecified {
            get {
                return TimeUnitSpecifiedField;
            } 
            set {
                TimeUnitSpecifiedField = value;
                NotifyPropertyChanged("TimeUnitSpecified");
            }
        }
        
        private VerticalTimeUnit? timeUnitField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the global 1D Vertical Coordinate Reference System (CRS).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGlobal1dCRS", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the global 1D Vertical Coordinate Reference System (CRS).")]
    public partial class ResqmlGlobal1dCRS : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A URN to a well-known Vertical CRS.
        /// </summary>
        [XmlElement("srsName", DataType="anyURI")]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
        public string SrsName {
            get {
                return srsNameField;
            } 
            set {
                if (value != null && VerticalCRSSpecified) throw new Exception("Cannot set property SrsName when property VerticalCRS is already set");
                srsNameField = value;
                SrsNameSpecified = (value!=null);
                NotifyPropertyChanged("SrsName");
            }
        }

        private string srsNameField; 
        private bool srsNameSpecified = false; 

        /// <summary>
        /// bool to indicate if SrsName has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SrsNameSpecified
        {
            get {
                return srsNameSpecified;
            }
            set {
                srsNameSpecified= value;
            }
        }

        /// <summary>
        /// VerticalCRS property
        /// </summary>
        [ComponentElement]
        [XmlElement("VerticalCRS", Namespace="http://www.opengis.net/gml/3.2")]
        public VerticalCRSType VerticalCRS {
            get {
                return VerticalCRSField;
            } 
            set {
                VerticalCRSField = value;
                VerticalCRSSpecified = (value!=null);
                NotifyPropertyChanged("VerticalCRS");
            }
        }

        private VerticalCRSType VerticalCRSField; 
        private bool verticalCRSSpecified = false; 

        /// <summary>
        /// bool to indicate if VerticalCRS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool VerticalCRSSpecified
        {
            get {
                return verticalCRSSpecified;
            }
            set {
                verticalCRSSpecified= value;
            }
        }


        /// <summary>
        /// The unit of measure of the axis.
        /// </summary>
		[Required]
        [Description("The unit of measure of the axis.")]
        [EnergisticsDataTypeAttribute(DataType = "WellVerticalCoordinateUom")]
		[XmlElement("unit")]
        public WellVerticalCoordinateUom? Unit {
            get {
                return unitField;
            } 
            set {
                unitField = value;
                 this.UnitSpecified = true;
                NotifyPropertyChanged("Unit");
            }
        }

        
        private bool UnitSpecifiedField = false;
        
        /// <summary>
        /// UnitSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool UnitSpecified {
            get {
                return UnitSpecifiedField;
            } 
            set {
                UnitSpecifiedField = value;
                NotifyPropertyChanged("UnitSpecified");
            }
        }
        
        private WellVerticalCoordinateUom? unitField; 

        /// <summary>
        /// The direction of the positive axis.
        /// </summary>
		[Required]
        [Description("The direction of the positive axis.")]
        [EnergisticsDataTypeAttribute(DataType = "VerticalDirection")]
		[XmlElement("direction")]
        public VerticalDirection? Direction {
            get {
                return directionField;
            } 
            set {
                directionField = value;
                 this.DirectionSpecified = true;
                NotifyPropertyChanged("Direction");
            }
        }

        
        private bool DirectionSpecifiedField = false;
        
        /// <summary>
        /// DirectionSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DirectionSpecified {
            get {
                return DirectionSpecifiedField;
            } 
            set {
                DirectionSpecifiedField = value;
                NotifyPropertyChanged("DirectionSpecified");
            }
        }
        
        private VerticalDirection? directionField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the VerticalCRSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalCRSType xsd type.")]
    public partial class VerticalCRSType : AbstractCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// verticalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("verticalCS")]
        public VerticalCSPropertyType VerticalCS {
            get {
                return verticalCSField;
            } 
            set {
                verticalCSField = value;
                NotifyPropertyChanged("VerticalCS");
            }
        }

        private VerticalCSPropertyType verticalCSField; 

        /// <summary>
        /// verticalDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("verticalDatum")]
        public VerticalDatumPropertyType VerticalDatum {
            get {
                return verticalDatumField;
            } 
            set {
                verticalDatumField = value;
                NotifyPropertyChanged("VerticalDatum");
            }
        }

        private VerticalDatumPropertyType verticalDatumField; 


    } //here

    /// <summary>
    /// This class represents the VerticalCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("verticalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalCSPropertyType xsd type.")]
    public partial class VerticalCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// VerticalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("VerticalCS")]
        public VerticalCSType VerticalCS {
            get {
                return VerticalCSField;
            } 
            set {
                VerticalCSField = value;
                NotifyPropertyChanged("VerticalCS");
            }
        }

        private VerticalCSType VerticalCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the VerticalCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalCSType xsd type.")]
    public partial class VerticalCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the AbstractCoordinateSystemType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractCoordinateSystem", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractCoordinateSystemType xsd type.")]
    public abstract partial class AbstractCoordinateSystemType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// axis property
        /// </summary>
		[RecurringElement]
		[XmlElement("axis")]
        public List<CoordinateSystemAxisPropertyType> Axis {
            get {
                return axisField;
            } 
            set {
                axisField = value;
                NotifyPropertyChanged("Axis");
            }
        }

         /// <summary>
         /// bool to indicate if Axis has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AxisSpecified
         {
             get {
             if(axisField!=null)
                 return axisField.Count>0?true:false;
             else return false;
             }
         }
        private List<CoordinateSystemAxisPropertyType> axisField; 

		/// <summary>
        /// aggregationType property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "AggregationType")]
        [XmlAttribute("aggregationType")]
		
        public AggregationType AggregationType {
            get {
                return aggregationTypeField;
            } 
            set {
                aggregationTypeField = value;
                 this.AggregationTypeSpecified = true;
                NotifyPropertyChanged("AggregationType");
            }
        }

        private AggregationType aggregationTypeField; 

        /// <summary>
        /// aggregationTypeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool AggregationTypeSpecified {
            get {
                return aggregationTypeSpecifiedField;
            } 
            set {
                aggregationTypeSpecifiedField = value;
                NotifyPropertyChanged("AggregationTypeSpecified");
            }
        }

        private bool aggregationTypeSpecifiedField; 


    } //here

    /// <summary>
    /// This class represents the CoordinateSystemAxisPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("axis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CoordinateSystemAxisPropertyType xsd type.")]
    public partial class CoordinateSystemAxisPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CoordinateSystemAxis property
        /// </summary>
		[ComponentElement]
		[XmlElement("CoordinateSystemAxis")]
        public CoordinateSystemAxisType CoordinateSystemAxis {
            get {
                return CoordinateSystemAxisField;
            } 
            set {
                CoordinateSystemAxisField = value;
                NotifyPropertyChanged("CoordinateSystemAxis");
            }
        }

        private CoordinateSystemAxisType CoordinateSystemAxisField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the CoordinateSystemAxisType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CoordinateSystemAxis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CoordinateSystemAxisType xsd type.")]
    public partial class CoordinateSystemAxisType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// axisAbbrev property
        /// </summary>
		[ComponentElement]
		[XmlElement("axisAbbrev")]
        public CodeType AxisAbbrev {
            get {
                return axisAbbrevField;
            } 
            set {
                axisAbbrevField = value;
                NotifyPropertyChanged("AxisAbbrev");
            }
        }

        private CodeType axisAbbrevField; 

        /// <summary>
        /// axisDirection property
        /// </summary>
		[ComponentElement]
		[XmlElement("axisDirection")]
        public CodeWithAuthorityType AxisDirection {
            get {
                return axisDirectionField;
            } 
            set {
                axisDirectionField = value;
                NotifyPropertyChanged("AxisDirection");
            }
        }

        private CodeWithAuthorityType axisDirectionField; 

        /// <summary>
        /// minimumValue property
        /// </summary>
		
		[XmlElement("minimumValue")]
        public double? MinimumValue {
            get {
                return minimumValueField;
            } 
            set {
                minimumValueField = value;
                 this.MinimumValueSpecified = true;
                NotifyPropertyChanged("MinimumValue");
            }
        }

        private double? minimumValueField; 

        /// <summary>
        /// minimumValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MinimumValueSpecified {
            get {
                return minimumValueSpecifiedField;
            } 
            set {
                minimumValueSpecifiedField = value;
                NotifyPropertyChanged("MinimumValueSpecified");
            }
        }

        private bool minimumValueSpecifiedField; 

        /// <summary>
        /// maximumValue property
        /// </summary>
		
		[XmlElement("maximumValue")]
        public double? MaximumValue {
            get {
                return maximumValueField;
            } 
            set {
                maximumValueField = value;
                 this.MaximumValueSpecified = true;
                NotifyPropertyChanged("MaximumValue");
            }
        }

        private double? maximumValueField; 

        /// <summary>
        /// maximumValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MaximumValueSpecified {
            get {
                return maximumValueSpecifiedField;
            } 
            set {
                maximumValueSpecifiedField = value;
                NotifyPropertyChanged("MaximumValueSpecified");
            }
        }

        private bool maximumValueSpecifiedField; 

        /// <summary>
        /// rangeMeaning property
        /// </summary>
		[ComponentElement]
		[XmlElement("rangeMeaning")]
        public CodeWithAuthorityType RangeMeaning {
            get {
                return rangeMeaningField;
            } 
            set {
                rangeMeaningField = value;
                NotifyPropertyChanged("RangeMeaning");
            }
        }

        private CodeWithAuthorityType rangeMeaningField; 


    } //here

    /// <summary>
    /// This class represents the CodeType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeWithAuthorityType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("name", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CodeType xsd type.")]
    public partial class CodeType : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the CodeType class.
        /// </summary>
        public CodeType() {}

        /// <summary>
        /// Initializes a new instance of the CodeType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public CodeType(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// codeSpace property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeSpace")]
		
        public string CodeSpace {
            get {
                return codeSpaceField;
            } 
            set {
                codeSpaceField = value;
                NotifyPropertyChanged("CodeSpace");
            }
        }

        private string codeSpaceField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the CodeWithAuthorityType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("identifier", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CodeWithAuthorityType xsd type.")]
    public partial class CodeWithAuthorityType : CodeType, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the CodeWithAuthorityType class.
        /// </summary>
        public CodeWithAuthorityType() {}

        /// <summary>
        /// Initializes a new instance of the CodeWithAuthorityType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public CodeWithAuthorityType(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the IdentifiedObjectType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="IdentifiedObjectType", Namespace="http://www.opengis.net/gml/3.2")]
	[Description("This class represents the IdentifiedObjectType xsd type.")]
    public abstract partial class IdentifiedObjectType : DefinitionType, INotifyPropertyChanged
    {


    } //here
    }

    /// <summary>
    /// This class represents the DefinitionType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Definition", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the DefinitionType xsd type.")]
    public partial class DefinitionType : DefinitionBaseType, INotifyPropertyChanged
    {

        /// <summary>
        /// remarks property
        /// </summary>
		
		[XmlElement("remarks")]
        public string Remarks {
            get {
                return remarksField;
            } 
            set {
                remarksField = value;
                NotifyPropertyChanged("Remarks");
            }
        }

        private string remarksField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the DefinitionBaseType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DefinitionBaseType", Namespace="http://www.opengis.net/gml/3.2")]
	[Description("This class represents the DefinitionBaseType xsd type.")]
    public partial class DefinitionBaseType : AbstractGMLType, INotifyPropertyChanged
    {


    } //here
    }

    /// <summary>
    /// This class represents the AbstractGMLType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlAreaOfInterest))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGML", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGMLType xsd type.")]
    public abstract partial class AbstractGMLType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description")]
        public StringOrRefType Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private StringOrRefType descriptionField; 

        /// <summary>
        /// descriptionReference property
        /// </summary>
		[ComponentElement]
		[XmlElement("descriptionReference")]
        public ReferenceType DescriptionReference {
            get {
                return descriptionReferenceField;
            } 
            set {
                descriptionReferenceField = value;
                NotifyPropertyChanged("DescriptionReference");
            }
        }

        private ReferenceType descriptionReferenceField; 

        /// <summary>
        /// identifier property
        /// </summary>
		[ComponentElement]
		[XmlElement("identifier")]
        public CodeWithAuthorityType Identifier {
            get {
                return identifierField;
            } 
            set {
                identifierField = value;
                NotifyPropertyChanged("Identifier");
            }
        }

        private CodeWithAuthorityType identifierField; 

        /// <summary>
        /// name property
        /// </summary>
		[RecurringElement]
		[XmlElement("name")]
        public List<CodeType> Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

         /// <summary>
         /// bool to indicate if Name has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool NameSpecified
         {
             get {
             if(nameField!=null)
                 return nameField.Count>0?true:false;
             else return false;
             }
         }
        private List<CodeType> nameField; 

		/// <summary>
        /// id property
        /// </summary>
		
        [XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
		
        public string Id {
            get {
                return idField;
            } 
            set {
                idField = value;
                NotifyPropertyChanged("Id");
            }
        }

        private string idField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the StringOrRefType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("description", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the StringOrRefType xsd type.")]
    public partial class StringOrRefType : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the StringOrRefType class.
        /// </summary>
        public StringOrRefType() {}

        /// <summary>
        /// Initializes a new instance of the StringOrRefType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public StringOrRefType(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the ReferenceType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("descriptionReference", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the ReferenceType xsd type.")]
    public partial class ReferenceType : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// owns property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "boolean")]
        [XmlAttribute("owns")]
		
        public bool Owns {
            get {
                return ownsField;
            } 
            set {
                ownsField = value;
                NotifyPropertyChanged("Owns");
            }
        }

        private bool ownsField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the AbstractTimeObjectType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractTimeObject", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractTimeObjectType xsd type.")]
    public abstract partial class AbstractTimeObjectType : AbstractGMLType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the AbstractTimePrimitiveType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractTimePrimitive", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractTimePrimitiveType xsd type.")]
    public abstract partial class AbstractTimePrimitiveType : AbstractTimeObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// relatedTime property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "RelatedTimeType")]
		[XmlElement("relatedTime")]
        public List<RelatedTimeType> RelatedTime {
            get {
                return relatedTimeField;
            } 
            set {
                relatedTimeField = value;
                NotifyPropertyChanged("RelatedTime");
            }
        }

         /// <summary>
         /// bool to indicate if RelatedTime has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RelatedTimeSpecified
         {
             get {
             if(relatedTimeField!=null)
                 return relatedTimeField.Count>0?true:false;
             else return false;
             }
         }
        private List<RelatedTimeType> relatedTimeField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the RelatedTimeType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="RelatedTimeType", Namespace="http://www.opengis.net/gml/3.2")]
	[Description("This class represents the RelatedTimeType xsd type.")]
    public partial class RelatedTimeType : TimePrimitivePropertyType, INotifyPropertyChanged
    {

		/// <summary>
        /// relativePosition property
        /// </summary>
		
        [XmlAttribute("relativePosition")]
		
        public RelatedTimeTypeRelativePosition RelativePosition {
            get {
                return relativePositionField;
            } 
            set {
                relativePositionField = value;
                 this.RelativePositionSpecified = true;
                NotifyPropertyChanged("RelativePosition");
            }
        }

        private RelatedTimeTypeRelativePosition relativePositionField; 

        /// <summary>
        /// relativePositionSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool RelativePositionSpecified {
            get {
                return relativePositionSpecifiedField;
            } 
            set {
                relativePositionSpecifiedField = value;
                NotifyPropertyChanged("RelativePositionSpecified");
            }
        }

        private bool relativePositionSpecifiedField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the TimePrimitivePropertyType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedTimeType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="TimePrimitivePropertyType", Namespace="http://www.opengis.net/gml/3.2")]
	[Description("This class represents the TimePrimitivePropertyType xsd type.")]
    public partial class TimePrimitivePropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractTimePrimitive property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractTimePrimitive")]
        public AbstractTimePrimitiveType AbstractTimePrimitive {
            get {
                return AbstractTimePrimitiveField;
            } 
            set {
                AbstractTimePrimitiveField = value;
                NotifyPropertyChanged("AbstractTimePrimitive");
            }
        }

        private AbstractTimePrimitiveType AbstractTimePrimitiveField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 

		/// <summary>
        /// owns property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "boolean")]
        [XmlAttribute("owns")]
		
        public bool Owns {
            get {
                return ownsField;
            } 
            set {
                ownsField = value;
                NotifyPropertyChanged("Owns");
            }
        }

        private bool ownsField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the AbstractGeometryType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGeometry", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGeometryType xsd type.")]
    public abstract partial class AbstractGeometryType : AbstractGMLType, INotifyPropertyChanged
    {

		/// <summary>
        /// srsName property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("srsName")]
		
        public string SrsName {
            get {
                return srsNameField;
            } 
            set {
                srsNameField = value;
                NotifyPropertyChanged("SrsName");
            }
        }

        private string srsNameField; 

		/// <summary>
        /// srsDimension property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "positiveInteger")]
        [XmlAttribute("srsDimension")]
		
        public string SrsDimension {
            get {
                return srsDimensionField;
            } 
            set {
                srsDimensionField = value;
                NotifyPropertyChanged("SrsDimension");
            }
        }

        private string srsDimensionField; 


    } //here

    /// <summary>
    /// This class represents the AbstractGeometricPrimitiveType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGeometricPrimitive", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGeometricPrimitiveType xsd type.")]
    public abstract partial class AbstractGeometricPrimitiveType : AbstractGeometryType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the PointType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Point", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the PointType xsd type.")]
    public partial class PointType : AbstractGeometricPrimitiveType, INotifyPropertyChanged
    {

        /// <summary>
        /// Item property
        /// </summary>
		[ComponentElement]
		[XmlElement("pos")]
        public DirectPositionType Item {
            get {
                return ItemField;
            } 
            set {
                ItemField = value;
                NotifyPropertyChanged("Item");
            }
        }

        private DirectPositionType ItemField; 


    } //here

    /// <summary>
    /// This class represents the DirectPositionType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("pos", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the DirectPositionType xsd type.")]
    public partial class DirectPositionType : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// srsName property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("srsName")]
		
        public string SrsName {
            get {
                return srsNameField;
            } 
            set {
                srsNameField = value;
                NotifyPropertyChanged("SrsName");
            }
        }

        private string srsNameField; 

		/// <summary>
        /// srsDimension property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "positiveInteger")]
        [XmlAttribute("srsDimension")]
		
        public string SrsDimension {
            get {
                return srsDimensionField;
            } 
            set {
                srsDimensionField = value;
                NotifyPropertyChanged("SrsDimension");
            }
        }

        private string srsDimensionField; 

        /// <summary>
        /// Text property
        /// </summary>
        [RecurringElement]
        [XmlText]
        public List<string> Text {
            get {
                return TextField;
            } 
            set {
                TextField = value;
                NotifyPropertyChanged("Text");
            }
        }

         /// <summary>
         /// bool to indicate if Text has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TextSpecified
         {
             get {
             if(TextField!=null)
                 return TextField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> TextField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the AbstractSurfaceType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractSurface", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractSurfaceType xsd type.")]
    public abstract partial class AbstractSurfaceType : AbstractGeometricPrimitiveType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the PolygonType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Polygon", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the PolygonType xsd type.")]
    public partial class PolygonType : AbstractSurfaceType, INotifyPropertyChanged
    {

        /// <summary>
        /// exterior property
        /// </summary>
		[ComponentElement]
		[XmlElement("exterior")]
        public AbstractRingPropertyType Exterior {
            get {
                return exteriorField;
            } 
            set {
                exteriorField = value;
                NotifyPropertyChanged("Exterior");
            }
        }

        private AbstractRingPropertyType exteriorField; 

        /// <summary>
        /// interior property
        /// </summary>
		[RecurringElement]
		[XmlElement("interior")]
        public List<AbstractRingPropertyType> Interior {
            get {
                return interiorField;
            } 
            set {
                interiorField = value;
                NotifyPropertyChanged("Interior");
            }
        }

         /// <summary>
         /// bool to indicate if Interior has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool InteriorSpecified
         {
             get {
             if(interiorField!=null)
                 return interiorField.Count>0?true:false;
             else return false;
             }
         }
        private List<AbstractRingPropertyType> interiorField; 


    } //here

    /// <summary>
    /// This class represents the AbstractRingPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("exterior", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractRingPropertyType xsd type.")]
    public partial class AbstractRingPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Item property
        /// </summary>
		[ComponentElement]
		[XmlElement("LinearRing")]
        public LinearRingType Item {
            get {
                return ItemField;
            } 
            set {
                ItemField = value;
                NotifyPropertyChanged("Item");
            }
        }

        private LinearRingType ItemField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the LinearRingType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("LinearRing", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the LinearRingType xsd type.")]
    public partial class LinearRingType : AbstractRingType, INotifyPropertyChanged
    {

        /// <summary>
        /// pos property
        /// </summary>
        [ComponentElement]
        [XmlElement("pos")]
        public DirectPositionType Pos {
            get {
                return posField;
            } 
            set {
                posField = value;
                PosSpecified = (value!=null);
                NotifyPropertyChanged("Pos");
            }
        }

        private DirectPositionType posField; 
        private bool posSpecified = false; 

        /// <summary>
        /// bool to indicate if Pos has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool PosSpecified
        {
            get {
                return posSpecified;
            }
            set {
                posSpecified= value;
            }
        }

        /// <summary>
        /// posList property
        /// </summary>
        [ComponentElement]
        [XmlElement("posList")]
        public DirectPositionListType PosList {
            get {
                return posListField;
            } 
            set {
                posListField = value;
                PosListSpecified = (value!=null);
                NotifyPropertyChanged("PosList");
            }
        }

        private DirectPositionListType posListField; 
        private bool posListSpecified = false; 

        /// <summary>
        /// bool to indicate if PosList has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool PosListSpecified
        {
            get {
                return posListSpecified;
            }
            set {
                posListSpecified= value;
            }
        }



    } //here

    /// <summary>
    /// This class represents the DirectPositionListType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("posList", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the DirectPositionListType xsd type.")]
    public partial class DirectPositionListType : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// srsName property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("srsName")]
		
        public string SrsName {
            get {
                return srsNameField;
            } 
            set {
                srsNameField = value;
                NotifyPropertyChanged("SrsName");
            }
        }

        private string srsNameField; 

		/// <summary>
        /// srsDimension property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "positiveInteger")]
        [XmlAttribute("srsDimension")]
		
        public string SrsDimension {
            get {
                return srsDimensionField;
            } 
            set {
                srsDimensionField = value;
                NotifyPropertyChanged("SrsDimension");
            }
        }

        private string srsDimensionField; 

		/// <summary>
        /// count property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "positiveInteger")]
        [XmlAttribute("count")]
		
        public string Count {
            get {
                return countField;
            } 
            set {
                countField = value;
                NotifyPropertyChanged("Count");
            }
        }

        private string countField; 

        /// <summary>
        /// Text property
        /// </summary>
        [RecurringElement]
        [XmlText]
        public List<string> Text {
            get {
                return TextField;
            } 
            set {
                TextField = value;
                NotifyPropertyChanged("Text");
            }
        }

         /// <summary>
         /// bool to indicate if Text has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TextSpecified
         {
             get {
             if(TextField!=null)
                 return TextField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> TextField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the AbstractRingType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearRingType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractRing", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractRingType xsd type.")]
    public abstract partial class AbstractRingType : Object, INotifyPropertyChanged
    {


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the AbstractFeatureType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResqmlAreaOfInterest))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="AbstractFeatureType", Namespace="http://www.opengis.net/gml/3.2")]
	[Description("This class represents the AbstractFeatureType xsd type.")]
    public abstract partial class AbstractFeatureType : AbstractGMLType, INotifyPropertyChanged
    {

        /// <summary>
        /// boundedBy property
        /// </summary>
		[ComponentElement]
		[XmlElement("boundedBy")]
        public BoundingShapeType BoundedBy {
            get {
                return boundedByField;
            } 
            set {
                boundedByField = value;
                NotifyPropertyChanged("BoundedBy");
            }
        }

        private BoundingShapeType boundedByField; 


    } //here
    }

    /// <summary>
    /// This class represents the BoundingShapeType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("boundedBy", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the BoundingShapeType xsd type.")]
    public partial class BoundingShapeType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Item property
        /// </summary>
		[ComponentElement]
		[XmlElement("Envelope")]
        public EnvelopeType Item {
            get {
                return ItemField;
            } 
            set {
                ItemField = value;
                NotifyPropertyChanged("Item");
            }
        }

        private EnvelopeType ItemField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the EnvelopeType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Envelope", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EnvelopeType xsd type.")]
    public partial class EnvelopeType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// lowerCorner property
        /// </summary>
        [ComponentElement]
        [XmlElement("lowerCorner")]
        public DirectPositionType LowerCorner {
            get {
                return lowerCornerField;
            } 
            set {
                lowerCornerField = value;
                LowerCornerSpecified = (value!=null);
                NotifyPropertyChanged("LowerCorner");
            }
        }

        private DirectPositionType lowerCornerField; 
        private bool lowerCornerSpecified = false; 

        /// <summary>
        /// bool to indicate if LowerCorner has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool LowerCornerSpecified
        {
            get {
                return lowerCornerSpecified;
            }
            set {
                lowerCornerSpecified= value;
            }
        }

        /// <summary>
        /// pos property
        /// </summary>
        [ComponentElement]
        [XmlElement("pos")]
        public DirectPositionType Pos {
            get {
                return posField;
            } 
            set {
                posField = value;
                PosSpecified = (value!=null);
                NotifyPropertyChanged("Pos");
            }
        }

        private DirectPositionType posField; 
        private bool posSpecified = false; 

        /// <summary>
        /// bool to indicate if Pos has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool PosSpecified
        {
            get {
                return posSpecified;
            }
            set {
                posSpecified= value;
            }
        }

        /// <summary>
        /// upperCorner property
        /// </summary>
        [ComponentElement]
        [XmlElement("upperCorner")]
        public DirectPositionType UpperCorner {
            get {
                return upperCornerField;
            } 
            set {
                upperCornerField = value;
                UpperCornerSpecified = (value!=null);
                NotifyPropertyChanged("UpperCorner");
            }
        }

        private DirectPositionType upperCornerField; 
        private bool upperCornerSpecified = false; 

        /// <summary>
        /// bool to indicate if UpperCorner has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool UpperCornerSpecified
        {
            get {
                return upperCornerSpecified;
            }
            set {
                upperCornerSpecified= value;
            }
        }


        /// <summary>
        /// ItemsElementName property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public List<ItemsChoiceType> ItemsElementName {
            get {
                return ItemsElementNameField;
            } 
            set {
                ItemsElementNameField = value;
                NotifyPropertyChanged("ItemsElementName");
            }
        }

         /// <summary>
         /// bool to indicate if ItemsElementName has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ItemsElementNameSpecified
         {
             get {
             if(ItemsElementNameField!=null)
                 return ItemsElementNameField.Count>0?true:false;
             else return false;
             }
         }
        private List<ItemsChoiceType> ItemsElementNameField; 

		/// <summary>
        /// srsName property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("srsName")]
		
        public string SrsName {
            get {
                return srsNameField;
            } 
            set {
                srsNameField = value;
                NotifyPropertyChanged("SrsName");
            }
        }

        private string srsNameField; 

		/// <summary>
        /// srsDimension property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "positiveInteger")]
        [XmlAttribute("srsDimension")]
		
        public string SrsDimension {
            get {
                return srsDimensionField;
            } 
            set {
                srsDimensionField = value;
                NotifyPropertyChanged("SrsDimension");
            }
        }

        private string srsDimensionField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A GML feature representing the overall area of interest. The following are inherited from the normative GML schema. The RESQML profiled schema represents a subset of the normative GML schema. attributes: gml:id (required) gml:boundedBy (optional but profiled to be mandatory) gml:location (deprecated - eliminated from the profiled schema.) elements: gml:metaDataProperty (deprecated - eliminated from the profiled schema.) gml:description (optional) gml:descriptionReference(optional) gml:identifier (optional) gml:name (optional maxOccurs="unbounded") 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlAreaOfInterest", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A GML feature representing the overall area of interest. The following are inherited from the normative GML schema. The RESQML profiled schema represents a subset of the normative GML schema. attributes: gml:id (required) gml:boundedBy (optional but profiled to be mandatory) gml:location (deprecated - eliminated from the profiled schema.) elements: gml:metaDataProperty (deprecated - eliminated from the profiled schema.) gml:description (optional) gml:descriptionReference(optional) gml:identifier (optional) gml:name (optional maxOccurs=unbounded) ")]
    public partial class ResqmlAreaOfInterest : AbstractFeatureType, INotifyPropertyChanged
    {

        /// <summary>
        /// The CRS is defined by ../gml:boundedBy/gml:Envelope/@srsName unless it is overridden by ./gml:Polygon/gml:exterior/gml:LinearRing/gml:posList/@srsName.
        /// </summary>
		[Description("The CRS is defined by ../gml:boundedBy/gml:Envelope/@srsName unless it is overridden by ./gml:Polygon/gml:exterior/gml:LinearRing/gml:posList/@srsName.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "AreaOfInterestPropertyType")]
		[XmlElement("outline")]
        public AreaOfInterestPropertyType Outline {
            get {
                return outlineField;
            } 
            set {
                outlineField = value;
                NotifyPropertyChanged("Outline");
            }
        }

        private AreaOfInterestPropertyType outlineField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the AreaOfInterestPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="AreaOfInterestPropertyType", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the AreaOfInterestPropertyType xsd type.")]
    public partial class AreaOfInterestPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Polygon property
        /// </summary>
		[ComponentElement]
		[XmlElement("Polygon", Namespace="http://www.opengis.net/gml/3.2")]
        public PolygonType Polygon {
            get {
                return PolygonField;
            } 
            set {
                PolygonField = value;
                NotifyPropertyChanged("Polygon");
            }
        }

        private PolygonType PolygonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the EllipsoidType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Ellipsoid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidType xsd type.")]
    public partial class EllipsoidType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// semiMajorAxis property
        /// </summary>
		
		[XmlElement("semiMajorAxis")]
        public MeasureType SemiMajorAxis {
            get {
                return semiMajorAxisField;
            } 
            set {
                semiMajorAxisField = value;
                NotifyPropertyChanged("SemiMajorAxis");
            }
        }

        private MeasureType semiMajorAxisField; 

        /// <summary>
        /// secondDefiningParameter property
        /// </summary>
		[ComponentElement]
		[XmlElement("secondDefiningParameter")]
        public StandAloneSecondDefParameter SecondDefPara {
            get {
                return secondDefiningParameterField;
            } 
            set {
                secondDefiningParameterField = value;
                NotifyPropertyChanged("SecondDefPara");
            }
        }

        private StandAloneSecondDefParameter secondDefiningParameterField; 


    } //here

    /// <summary>
    /// This class represents the MeasureType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("semiMajorAxis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the MeasureType xsd type.")]
    public partial class MeasureType : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MeasureType class.
        /// </summary>
        public MeasureType() {}

        /// <summary>
        /// Initializes a new instance of the MeasureType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public MeasureType(double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public double Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private double ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the LengthType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="LengthType", Namespace="http://www.opengis.net/gml/3.2")]
	[Description("This class represents the LengthType xsd type.")]
    public partial class LengthType : MeasureType, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the LengthType class.
        /// </summary>
        public LengthType() {}

        /// <summary>
        /// Initializes a new instance of the LengthType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public LengthType(double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }


    } //here
    }

    /// <summary>
    /// This class represents the AngleType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("greenwichLongitude", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AngleType xsd type.")]
    public partial class AngleType : MeasureType, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the AngleType class.
        /// </summary>
        public AngleType() {}

        /// <summary>
        /// Initializes a new instance of the AngleType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public AngleType(double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }


    } //here

    /// <summary>
    /// This class represents the secondDefiningParameter xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the secondDefiningParameter xsd type.")]
    public partial class StandAloneSecondDefParameter : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// SecondDefiningParameter property
        /// </summary>
		[ComponentElement]
		[XmlElement("SecondDefiningParameter")]
        public SecondDefiningParameter SecondDefPara {
            get {
                return SecondDefiningParameterField;
            } 
            set {
                SecondDefiningParameterField = value;
                NotifyPropertyChanged("SecondDefPara");
            }
        }

        private SecondDefiningParameter SecondDefiningParameterField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the SecondDefiningParameter xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the SecondDefiningParameter xsd type.")]
    public partial class SecondDefiningParameter : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// inverseFlattening property
        /// </summary>
        [XmlElement("inverseFlattening")]
        public MeasureType InverseFlattening {
            get {
                return inverseFlatteningField;
            } 
            set {
                inverseFlatteningField = value;
                InverseFlatteningSpecified = (value!=null);
                NotifyPropertyChanged("InverseFlattening");
            }
        }

        private MeasureType inverseFlatteningField; 
        private bool inverseFlatteningSpecified = false; 

        /// <summary>
        /// bool to indicate if InverseFlattening has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool InverseFlatteningSpecified
        {
            get {
                return inverseFlatteningSpecified;
            }
            set {
                inverseFlatteningSpecified= value;
            }
        }

        /// <summary>
        /// isSphere property
        /// </summary>
        [XmlElement("isSphere")]
        public bool? IsSphere {
            get {
                return isSphereField;
            } 
            set {
                isSphereField = value;
                IsSphereSpecified = (value!=null);
                NotifyPropertyChanged("IsSphere");
            }
        }

        private bool? isSphereField; 
        private bool isSphereSpecified = false; 

        /// <summary>
        /// bool to indicate if IsSphere has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IsSphereSpecified
        {
            get {
                return isSphereSpecified;
            }
            set {
                isSphereSpecified= value;
            }
        }

        /// <summary>
        /// semiMinorAxis property
        /// </summary>
        [XmlElement("semiMinorAxis")]
        public LengthType SemiMinorAxis {
            get {
                return semiMinorAxisField;
            } 
            set {
                semiMinorAxisField = value;
                SemiMinorAxisSpecified = (value!=null);
                NotifyPropertyChanged("SemiMinorAxis");
            }
        }

        private LengthType semiMinorAxisField; 
        private bool semiMinorAxisSpecified = false; 

        /// <summary>
        /// bool to indicate if SemiMinorAxis has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SemiMinorAxisSpecified
        {
            get {
                return semiMinorAxisSpecified;
            }
            set {
                semiMinorAxisSpecified= value;
            }
        }



        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the PrimeMeridianType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("PrimeMeridian", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the PrimeMeridianType xsd type.")]
    public partial class PrimeMeridianType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// greenwichLongitude property
        /// </summary>
		
		[XmlElement("greenwichLongitude")]
        public AngleType GreenwichLongitude {
            get {
                return greenwichLongitudeField;
            } 
            set {
                greenwichLongitudeField = value;
                NotifyPropertyChanged("GreenwichLongitude");
            }
        }

        private AngleType greenwichLongitudeField; 


    } //here

    /// <summary>
    /// This class represents the AbstractDatumType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractDatumType xsd type.")]
    public abstract partial class AbstractDatumType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// domainOfValidity property
        /// </summary>
		[ComponentElement]
		[XmlElement("domainOfValidity")]
        public DomainOfValidity DomainOfValidity {
            get {
                return domainOfValidityField;
            } 
            set {
                domainOfValidityField = value;
                NotifyPropertyChanged("DomainOfValidity");
            }
        }

        private DomainOfValidity domainOfValidityField; 

        /// <summary>
        /// scope property
        /// </summary>
		[RecurringElement]
		[XmlElement("scope")]
        public List<string> Scope {
            get {
                return scopeField;
            } 
            set {
                scopeField = value;
                NotifyPropertyChanged("Scope");
            }
        }

         /// <summary>
         /// bool to indicate if Scope has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ScopeSpecified
         {
             get {
             if(scopeField!=null)
                 return scopeField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> scopeField; 

        /// <summary>
        /// anchorDefinition property
        /// </summary>
		[ComponentElement]
		[XmlElement("anchorDefinition")]
        public CodeType AnchorDefinition {
            get {
                return anchorDefinitionField;
            } 
            set {
                anchorDefinitionField = value;
                NotifyPropertyChanged("AnchorDefinition");
            }
        }

        private CodeType anchorDefinitionField; 

        /// <summary>
        /// realizationEpoch property
        /// </summary>
		
		[XmlElement("realizationEpoch", DataType="date")]
        public DateTime? RealizationEpoch {
            get {
                return realizationEpochField;
            } 
            set {
                realizationEpochField = value;
                 this.RealizationEpochSpecified = true;
                NotifyPropertyChanged("RealizationEpoch");
            }
        }

        private DateTime? realizationEpochField; 

        /// <summary>
        /// realizationEpochSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool RealizationEpochSpecified {
            get {
                return realizationEpochSpecifiedField;
            } 
            set {
                realizationEpochSpecifiedField = value;
                NotifyPropertyChanged("RealizationEpochSpecified");
            }
        }

        private bool realizationEpochSpecifiedField; 


    } //here

    /// <summary>
    /// This class represents the domainOfValidity xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the domainOfValidity xsd type.")]
    public partial class DomainOfValidity : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// EX_Extent property
        /// </summary>
		[ComponentElement]
		[XmlElement("EX_Extent", Namespace="http://www.isotc211.org/2005/gmd")]
        public EX_Extent_Type EX_Extent {
            get {
                return EX_ExtentField;
            } 
            set {
                EX_ExtentField = value;
                NotifyPropertyChanged("EX_Extent");
            }
        }

        private EX_Extent_Type EX_ExtentField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the EX_Extent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_Extent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the EX_Extent_Type xsd type.")]
    public partial class EX_Extent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("description")]
        public CharacterString_PropertyType Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private CharacterString_PropertyType descriptionField; 

        /// <summary>
        /// geographicElement property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "EX_GeographicExtent_PropertyType")]
		[XmlElement("geographicElement")]
        public List<EX_GeographicExtent_PropertyType> GeographicElement {
            get {
                return geographicElementField;
            } 
            set {
                geographicElementField = value;
                NotifyPropertyChanged("GeographicElement");
            }
        }

         /// <summary>
         /// bool to indicate if GeographicElement has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool GeographicElementSpecified
         {
             get {
             if(geographicElementField!=null)
                 return geographicElementField.Count>0?true:false;
             else return false;
             }
         }
        private List<EX_GeographicExtent_PropertyType> geographicElementField; 

        /// <summary>
        /// temporalElement property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "EX_TemporalExtent_PropertyType")]
		[XmlElement("temporalElement")]
        public List<EX_TemporalExtent_PropertyType> TemporalElement {
            get {
                return temporalElementField;
            } 
            set {
                temporalElementField = value;
                NotifyPropertyChanged("TemporalElement");
            }
        }

         /// <summary>
         /// bool to indicate if TemporalElement has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TemporalElementSpecified
         {
             get {
             if(temporalElementField!=null)
                 return temporalElementField.Count>0?true:false;
             else return false;
             }
         }
        private List<EX_TemporalExtent_PropertyType> temporalElementField; 

        /// <summary>
        /// verticalElement property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "EX_VerticalExtent_PropertyType")]
		[XmlElement("verticalElement")]
        public List<EX_VerticalExtent_PropertyType> VerticalElement {
            get {
                return verticalElementField;
            } 
            set {
                verticalElementField = value;
                NotifyPropertyChanged("VerticalElement");
            }
        }

         /// <summary>
         /// bool to indicate if VerticalElement has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool VerticalElementSpecified
         {
             get {
             if(verticalElementField!=null)
                 return verticalElementField.Count>0?true:false;
             else return false;
             }
         }
        private List<EX_VerticalExtent_PropertyType> verticalElementField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CharacterString_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CharacterString_PropertyType", Namespace="http://www.isotc211.org/2005/gco")]
	[Description("This class represents the CharacterString_PropertyType xsd type.")]
    public partial class CharacterString_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CharacterString property
        /// </summary>
		
		[XmlElement("CharacterString")]
        public string CharacterString {
            get {
                return CharacterStringField;
            } 
            set {
                CharacterStringField = value;
                NotifyPropertyChanged("CharacterString");
            }
        }

        private string CharacterStringField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the EX_GeographicExtent_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="EX_GeographicExtent_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the EX_GeographicExtent_PropertyType xsd type.")]
    public partial class EX_GeographicExtent_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractEX_GeographicExtent property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractEX_GeographicExtent")]
        public AbstractEX_GeographicExtent_Type AbstractEX_GeographicExtent {
            get {
                return AbstractEX_GeographicExtentField;
            } 
            set {
                AbstractEX_GeographicExtentField = value;
                NotifyPropertyChanged("AbstractEX_GeographicExtent");
            }
        }

        private AbstractEX_GeographicExtent_Type AbstractEX_GeographicExtentField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the AbstractEX_GeographicExtent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractEX_GeographicExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractEX_GeographicExtent_Type xsd type.")]
    public abstract partial class AbstractEX_GeographicExtent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// extentTypeCode property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Boolean_PropertyType")]
		[XmlElement("extentTypeCode")]
        public Boolean_PropertyType ExtentTypeCode {
            get {
                return extentTypeCodeField;
            } 
            set {
                extentTypeCodeField = value;
                NotifyPropertyChanged("ExtentTypeCode");
            }
        }

        private Boolean_PropertyType extentTypeCodeField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the Boolean_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Boolean_PropertyType", Namespace="http://www.isotc211.org/2005/gco")]
	[Description("This class represents the Boolean_PropertyType xsd type.")]
    public partial class Boolean_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Boolean property
        /// </summary>
		
		[XmlElement("Boolean")]
        public bool? Boolean {
            get {
                return BooleanField;
            } 
            set {
                BooleanField = value;
                NotifyPropertyChanged("Boolean");
            }
        }

        private bool? BooleanField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the AbstractObject_Type xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Result_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Series_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_OnlineResource_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Address_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Telephone_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Contact_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_ResponsibleParty_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Date_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Citation_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Identifier_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Element_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_PositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_VerticalExtent_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_TemporalExtent_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractEX_GeographicExtent_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_Extent_Type))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="AbstractObject_Type", Namespace="http://www.isotc211.org/2005/gco")]
	[Description("This class represents the AbstractObject_Type xsd type.")]
    public abstract partial class AbstractObject_Type : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// id property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "ID")]
        [XmlAttribute("id")]
		
        public string Id {
            get {
                return idField;
            } 
            set {
                idField = value;
                NotifyPropertyChanged("Id");
            }
        }

        private string idField; 

		/// <summary>
        /// uuid property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuid")]
		
        public string Uuid {
            get {
                return uuidField;
            } 
            set {
                uuidField = value;
                NotifyPropertyChanged("Uuid");
            }
        }

        private string uuidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the AbstractDQ_Result_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDQ_Result", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractDQ_Result_Type xsd type.")]
    public abstract partial class AbstractDQ_Result_Type : AbstractObject_Type, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the CI_Series_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Series", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Series_Type xsd type.")]
    public partial class CI_Series_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// name property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("name")]
        public CharacterString_PropertyType Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private CharacterString_PropertyType nameField; 

        /// <summary>
        /// issueIdentification property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("issueIdentification")]
        public CharacterString_PropertyType IssueIdentification {
            get {
                return issueIdentificationField;
            } 
            set {
                issueIdentificationField = value;
                NotifyPropertyChanged("IssueIdentification");
            }
        }

        private CharacterString_PropertyType issueIdentificationField; 

        /// <summary>
        /// page property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("page")]
        public CharacterString_PropertyType Page {
            get {
                return pageField;
            } 
            set {
                pageField = value;
                NotifyPropertyChanged("Page");
            }
        }

        private CharacterString_PropertyType pageField; 


    } //here

    /// <summary>
    /// This class represents the CI_OnlineResource_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_OnlineResource", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_OnlineResource_Type xsd type.")]
    public partial class CI_OnlineResource_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// linkage property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "URL_PropertyType")]
		[XmlElement("linkage")]
        public URL_PropertyType Linkage {
            get {
                return linkageField;
            } 
            set {
                linkageField = value;
                NotifyPropertyChanged("Linkage");
            }
        }

        private URL_PropertyType linkageField; 

        /// <summary>
        /// protocol property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("protocol")]
        public CharacterString_PropertyType Protocol {
            get {
                return protocolField;
            } 
            set {
                protocolField = value;
                NotifyPropertyChanged("Protocol");
            }
        }

        private CharacterString_PropertyType protocolField; 

        /// <summary>
        /// applicationProfile property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("applicationProfile")]
        public CharacterString_PropertyType ApplicationProfile {
            get {
                return applicationProfileField;
            } 
            set {
                applicationProfileField = value;
                NotifyPropertyChanged("ApplicationProfile");
            }
        }

        private CharacterString_PropertyType applicationProfileField; 

        /// <summary>
        /// name property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("name")]
        public CharacterString_PropertyType Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private CharacterString_PropertyType nameField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("description")]
        public CharacterString_PropertyType Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private CharacterString_PropertyType descriptionField; 

        /// <summary>
        /// function property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_OnLineFunctionCode_PropertyType")]
		[XmlElement("function")]
        public CI_OnLineFunctionCode_PropertyType Function {
            get {
                return functionField;
            } 
            set {
                functionField = value;
                NotifyPropertyChanged("Function");
            }
        }

        private CI_OnLineFunctionCode_PropertyType functionField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the URL_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="URL_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the URL_PropertyType xsd type.")]
    public partial class URL_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// URL property
        /// </summary>
		
		[XmlElement("URL", DataType="anyURI")]
        public string URL {
            get {
                return URLField;
            } 
            set {
                URLField = value;
                NotifyPropertyChanged("URL");
            }
        }

        private string URLField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_OnLineFunctionCode_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_OnLineFunctionCode_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_OnLineFunctionCode_PropertyType xsd type.")]
    public partial class CI_OnLineFunctionCode_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_OnLineFunctionCode property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_OnLineFunctionCode")]
        public CodeListValue_Type CI_OnLineFunctionCode {
            get {
                return CI_OnLineFunctionCodeField;
            } 
            set {
                CI_OnLineFunctionCodeField = value;
                NotifyPropertyChanged("CI_OnLineFunctionCode");
            }
        }

        private CodeListValue_Type CI_OnLineFunctionCodeField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the CodeListValue_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute("CI_DateTypeCode", Namespace="http://www.isotc211.org/2005/gco", IsNullable=false)]
	[Description("This class represents the CodeListValue_Type xsd type.")]
    public partial class CodeListValue_Type : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the CodeListValue_Type class.
        /// </summary>
        public CodeListValue_Type() {}

        /// <summary>
        /// Initializes a new instance of the CodeListValue_Type class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public CodeListValue_Type(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// codeList property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeList")]
		
        public string CodeList {
            get {
                return codeListField;
            } 
            set {
                codeListField = value;
                NotifyPropertyChanged("CodeList");
            }
        }

        private string codeListField; 

		/// <summary>
        /// codeListValue property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeListValue")]
		
        public string CodeListValue {
            get {
                return codeListValueField;
            } 
            set {
                codeListValueField = value;
                NotifyPropertyChanged("CodeListValue");
            }
        }

        private string codeListValueField; 

		/// <summary>
        /// codeSpace property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeSpace")]
		
        public string CodeSpace {
            get {
                return codeSpaceField;
            } 
            set {
                codeSpaceField = value;
                NotifyPropertyChanged("CodeSpace");
            }
        }

        private string codeSpaceField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the CI_Address_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Address", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Address_Type xsd type.")]
    public partial class CI_Address_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// deliveryPoint property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("deliveryPoint")]
        public List<CharacterString_PropertyType> DeliveryPoint {
            get {
                return deliveryPointField;
            } 
            set {
                deliveryPointField = value;
                NotifyPropertyChanged("DeliveryPoint");
            }
        }

         /// <summary>
         /// bool to indicate if DeliveryPoint has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DeliveryPointSpecified
         {
             get {
             if(deliveryPointField!=null)
                 return deliveryPointField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> deliveryPointField; 

        /// <summary>
        /// city property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("city")]
        public CharacterString_PropertyType City {
            get {
                return cityField;
            } 
            set {
                cityField = value;
                NotifyPropertyChanged("City");
            }
        }

        private CharacterString_PropertyType cityField; 

        /// <summary>
        /// administrativeArea property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("administrativeArea")]
        public CharacterString_PropertyType AdministrativeArea {
            get {
                return administrativeAreaField;
            } 
            set {
                administrativeAreaField = value;
                NotifyPropertyChanged("AdministrativeArea");
            }
        }

        private CharacterString_PropertyType administrativeAreaField; 

        /// <summary>
        /// postalCode property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("postalCode")]
        public CharacterString_PropertyType PostalCode {
            get {
                return postalCodeField;
            } 
            set {
                postalCodeField = value;
                NotifyPropertyChanged("PostalCode");
            }
        }

        private CharacterString_PropertyType postalCodeField; 

        /// <summary>
        /// country property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("country")]
        public CharacterString_PropertyType Country {
            get {
                return countryField;
            } 
            set {
                countryField = value;
                NotifyPropertyChanged("Country");
            }
        }

        private CharacterString_PropertyType countryField; 

        /// <summary>
        /// electronicMailAddress property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("electronicMailAddress")]
        public List<CharacterString_PropertyType> ElectronicMailAddress {
            get {
                return electronicMailAddressField;
            } 
            set {
                electronicMailAddressField = value;
                NotifyPropertyChanged("ElectronicMailAddress");
            }
        }

         /// <summary>
         /// bool to indicate if ElectronicMailAddress has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ElectronicMailAddressSpecified
         {
             get {
             if(electronicMailAddressField!=null)
                 return electronicMailAddressField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> electronicMailAddressField; 


    } //here

    /// <summary>
    /// This class represents the CI_Telephone_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Telephone", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Telephone_Type xsd type.")]
    public partial class CI_Telephone_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// voice property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("voice")]
        public List<CharacterString_PropertyType> Voice {
            get {
                return voiceField;
            } 
            set {
                voiceField = value;
                NotifyPropertyChanged("Voice");
            }
        }

         /// <summary>
         /// bool to indicate if Voice has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool VoiceSpecified
         {
             get {
             if(voiceField!=null)
                 return voiceField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> voiceField; 

        /// <summary>
        /// facsimile property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("facsimile")]
        public List<CharacterString_PropertyType> Facsimile {
            get {
                return facsimileField;
            } 
            set {
                facsimileField = value;
                NotifyPropertyChanged("Facsimile");
            }
        }

         /// <summary>
         /// bool to indicate if Facsimile has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool FacsimileSpecified
         {
             get {
             if(facsimileField!=null)
                 return facsimileField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> facsimileField; 


    } //here

    /// <summary>
    /// This class represents the CI_Contact_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Contact", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Contact_Type xsd type.")]
    public partial class CI_Contact_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// phone property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Telephone_PropertyType")]
		[XmlElement("phone")]
        public CI_Telephone_PropertyType Phone {
            get {
                return phoneField;
            } 
            set {
                phoneField = value;
                NotifyPropertyChanged("Phone");
            }
        }

        private CI_Telephone_PropertyType phoneField; 

        /// <summary>
        /// address property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Address_PropertyType")]
		[XmlElement("address")]
        public CI_Address_PropertyType Address {
            get {
                return addressField;
            } 
            set {
                addressField = value;
                NotifyPropertyChanged("Address");
            }
        }

        private CI_Address_PropertyType addressField; 

        /// <summary>
        /// onlineResource property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_OnlineResource_PropertyType")]
		[XmlElement("onlineResource")]
        public CI_OnlineResource_PropertyType OnlineResource {
            get {
                return onlineResourceField;
            } 
            set {
                onlineResourceField = value;
                NotifyPropertyChanged("OnlineResource");
            }
        }

        private CI_OnlineResource_PropertyType onlineResourceField; 

        /// <summary>
        /// hoursOfService property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("hoursOfService")]
        public CharacterString_PropertyType HoursOfService {
            get {
                return hoursOfServiceField;
            } 
            set {
                hoursOfServiceField = value;
                NotifyPropertyChanged("HoursOfService");
            }
        }

        private CharacterString_PropertyType hoursOfServiceField; 

        /// <summary>
        /// contactInstructions property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("contactInstructions")]
        public CharacterString_PropertyType ContactInstructions {
            get {
                return contactInstructionsField;
            } 
            set {
                contactInstructionsField = value;
                NotifyPropertyChanged("ContactInstructions");
            }
        }

        private CharacterString_PropertyType contactInstructionsField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_Telephone_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_Telephone_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_Telephone_PropertyType xsd type.")]
    public partial class CI_Telephone_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_Telephone property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_Telephone")]
        public CI_Telephone_Type CI_Telephone {
            get {
                return CI_TelephoneField;
            } 
            set {
                CI_TelephoneField = value;
                NotifyPropertyChanged("CI_Telephone");
            }
        }

        private CI_Telephone_Type CI_TelephoneField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_Address_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_Address_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_Address_PropertyType xsd type.")]
    public partial class CI_Address_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_Address property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_Address")]
        public CI_Address_Type CI_Address {
            get {
                return CI_AddressField;
            } 
            set {
                CI_AddressField = value;
                NotifyPropertyChanged("CI_Address");
            }
        }

        private CI_Address_Type CI_AddressField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_OnlineResource_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_OnlineResource_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_OnlineResource_PropertyType xsd type.")]
    public partial class CI_OnlineResource_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_OnlineResource property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_OnlineResource")]
        public CI_OnlineResource_Type CI_OnlineResource {
            get {
                return CI_OnlineResourceField;
            } 
            set {
                CI_OnlineResourceField = value;
                NotifyPropertyChanged("CI_OnlineResource");
            }
        }

        private CI_OnlineResource_Type CI_OnlineResourceField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the CI_ResponsibleParty_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_ResponsibleParty", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_ResponsibleParty_Type xsd type.")]
    public partial class CI_ResponsibleParty_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// individualName property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("individualName")]
        public CharacterString_PropertyType IndividualName {
            get {
                return individualNameField;
            } 
            set {
                individualNameField = value;
                NotifyPropertyChanged("IndividualName");
            }
        }

        private CharacterString_PropertyType individualNameField; 

        /// <summary>
        /// organisationName property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("organisationName")]
        public CharacterString_PropertyType OrganisationName {
            get {
                return organisationNameField;
            } 
            set {
                organisationNameField = value;
                NotifyPropertyChanged("OrganisationName");
            }
        }

        private CharacterString_PropertyType organisationNameField; 

        /// <summary>
        /// positionName property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("positionName")]
        public CharacterString_PropertyType PositionName {
            get {
                return positionNameField;
            } 
            set {
                positionNameField = value;
                NotifyPropertyChanged("PositionName");
            }
        }

        private CharacterString_PropertyType positionNameField; 

        /// <summary>
        /// contactInfo property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Contact_PropertyType")]
		[XmlElement("contactInfo")]
        public CI_Contact_PropertyType ContactInfo {
            get {
                return contactInfoField;
            } 
            set {
                contactInfoField = value;
                NotifyPropertyChanged("ContactInfo");
            }
        }

        private CI_Contact_PropertyType contactInfoField; 

        /// <summary>
        /// role property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_RoleCode_PropertyType")]
		[XmlElement("role")]
        public CI_RoleCode_PropertyType Role {
            get {
                return roleField;
            } 
            set {
                roleField = value;
                NotifyPropertyChanged("Role");
            }
        }

        private CI_RoleCode_PropertyType roleField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_Contact_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_Contact_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_Contact_PropertyType xsd type.")]
    public partial class CI_Contact_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_Contact property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_Contact")]
        public CI_Contact_Type CI_Contact {
            get {
                return CI_ContactField;
            } 
            set {
                CI_ContactField = value;
                NotifyPropertyChanged("CI_Contact");
            }
        }

        private CI_Contact_Type CI_ContactField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_RoleCode_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_RoleCode_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_RoleCode_PropertyType xsd type.")]
    public partial class CI_RoleCode_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_RoleCode property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_RoleCode")]
        public CodeListValue_Type CI_RoleCode {
            get {
                return CI_RoleCodeField;
            } 
            set {
                CI_RoleCodeField = value;
                NotifyPropertyChanged("CI_RoleCode");
            }
        }

        private CodeListValue_Type CI_RoleCodeField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the CI_Date_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Date", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Date_Type xsd type.")]
    public partial class CI_Date_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// date property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Date_PropertyType")]
		[XmlElement("date")]
        public Date_PropertyType Date {
            get {
                return dateField;
            } 
            set {
                dateField = value;
                NotifyPropertyChanged("Date");
            }
        }

        private Date_PropertyType dateField; 

        /// <summary>
        /// dateType property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_DateTypeCode_PropertyType")]
		[XmlElement("dateType")]
        public CI_DateTypeCode_PropertyType DateType {
            get {
                return dateTypeField;
            } 
            set {
                dateTypeField = value;
                NotifyPropertyChanged("DateType");
            }
        }

        private CI_DateTypeCode_PropertyType dateTypeField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the Date_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Date_PropertyType", Namespace="http://www.isotc211.org/2005/gco")]
	[Description("This class represents the Date_PropertyType xsd type.")]
    public partial class Date_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Date property
        /// </summary>
        [XmlElement("Date")]
        public string Date {
            get {
                return DateField;
            } 
            set {
                DateField = value;
                DateSpecified = (value!=null);
                NotifyPropertyChanged("Date");
            }
        }

        private string DateField; 
        private bool dateSpecified = false; 

        /// <summary>
        /// bool to indicate if Date has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool DateSpecified
        {
            get {
                return dateSpecified;
            }
            set {
                dateSpecified= value;
            }
        }

        /// <summary>
        /// DateTime property
        /// </summary>
        [XmlElement("DateTime")]
        public DateTime? DateTime {
            get {
                return DateTimeField;
            } 
            set {
                DateTimeField = value;
                DateTimeSpecified = (value!=null);
                NotifyPropertyChanged("DateTime");
            }
        }

        private DateTime? DateTimeField; 
        private bool dateTimeSpecified = false; 

        /// <summary>
        /// bool to indicate if DateTime has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool DateTimeSpecified
        {
            get {
                return dateTimeSpecified;
            }
            set {
                dateTimeSpecified= value;
            }
        }


		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_DateTypeCode_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_DateTypeCode_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_DateTypeCode_PropertyType xsd type.")]
    public partial class CI_DateTypeCode_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_DateTypeCode property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_DateTypeCode")]
        public CodeListValue_Type CI_DateTypeCode {
            get {
                return CI_DateTypeCodeField;
            } 
            set {
                CI_DateTypeCodeField = value;
                NotifyPropertyChanged("CI_DateTypeCode");
            }
        }

        private CodeListValue_Type CI_DateTypeCodeField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the CI_Citation_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Citation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Citation_Type xsd type.")]
    public partial class CI_Citation_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("title")]
        public CharacterString_PropertyType Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private CharacterString_PropertyType titleField; 

        /// <summary>
        /// alternateTitle property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("alternateTitle")]
        public List<CharacterString_PropertyType> AlternateTitle {
            get {
                return alternateTitleField;
            } 
            set {
                alternateTitleField = value;
                NotifyPropertyChanged("AlternateTitle");
            }
        }

         /// <summary>
         /// bool to indicate if AlternateTitle has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AlternateTitleSpecified
         {
             get {
             if(alternateTitleField!=null)
                 return alternateTitleField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> alternateTitleField; 

        /// <summary>
        /// date property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Date_PropertyType")]
		[XmlElement("date")]
        public List<CI_Date_PropertyType> Date {
            get {
                return dateField;
            } 
            set {
                dateField = value;
                NotifyPropertyChanged("Date");
            }
        }

         /// <summary>
         /// bool to indicate if Date has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DateSpecified
         {
             get {
             if(dateField!=null)
                 return dateField.Count>0?true:false;
             else return false;
             }
         }
        private List<CI_Date_PropertyType> dateField; 

        /// <summary>
        /// edition property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("edition")]
        public CharacterString_PropertyType Edition {
            get {
                return editionField;
            } 
            set {
                editionField = value;
                NotifyPropertyChanged("Edition");
            }
        }

        private CharacterString_PropertyType editionField; 

        /// <summary>
        /// editionDate property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Date_PropertyType")]
		[XmlElement("editionDate")]
        public Date_PropertyType EditionDate {
            get {
                return editionDateField;
            } 
            set {
                editionDateField = value;
                NotifyPropertyChanged("EditionDate");
            }
        }

        private Date_PropertyType editionDateField; 

        /// <summary>
        /// identifier property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "MD_Identifier_PropertyType")]
		[XmlElement("identifier")]
        public List<MD_Identifier_PropertyType> Identifier {
            get {
                return identifierField;
            } 
            set {
                identifierField = value;
                NotifyPropertyChanged("Identifier");
            }
        }

         /// <summary>
         /// bool to indicate if Identifier has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool IdentifierSpecified
         {
             get {
             if(identifierField!=null)
                 return identifierField.Count>0?true:false;
             else return false;
             }
         }
        private List<MD_Identifier_PropertyType> identifierField; 

        /// <summary>
        /// citedResponsibleParty property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_ResponsibleParty_PropertyType")]
		[XmlElement("citedResponsibleParty")]
        public List<CI_ResponsibleParty_PropertyType> CitedResponsibleParty {
            get {
                return citedResponsiblePartyField;
            } 
            set {
                citedResponsiblePartyField = value;
                NotifyPropertyChanged("CitedResponsibleParty");
            }
        }

         /// <summary>
         /// bool to indicate if CitedResponsibleParty has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool CitedResponsiblePartySpecified
         {
             get {
             if(citedResponsiblePartyField!=null)
                 return citedResponsiblePartyField.Count>0?true:false;
             else return false;
             }
         }
        private List<CI_ResponsibleParty_PropertyType> citedResponsiblePartyField; 

        /// <summary>
        /// presentationForm property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_PresentationFormCode_PropertyType")]
		[XmlElement("presentationForm")]
        public List<CI_PresentationFormCode_PropertyType> PresentationForm {
            get {
                return presentationFormField;
            } 
            set {
                presentationFormField = value;
                NotifyPropertyChanged("PresentationForm");
            }
        }

         /// <summary>
         /// bool to indicate if PresentationForm has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PresentationFormSpecified
         {
             get {
             if(presentationFormField!=null)
                 return presentationFormField.Count>0?true:false;
             else return false;
             }
         }
        private List<CI_PresentationFormCode_PropertyType> presentationFormField; 

        /// <summary>
        /// series property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Series_PropertyType")]
		[XmlElement("series")]
        public CI_Series_PropertyType Series {
            get {
                return seriesField;
            } 
            set {
                seriesField = value;
                NotifyPropertyChanged("Series");
            }
        }

        private CI_Series_PropertyType seriesField; 

        /// <summary>
        /// otherCitationDetails property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("otherCitationDetails")]
        public CharacterString_PropertyType OtherCitationDetails {
            get {
                return otherCitationDetailsField;
            } 
            set {
                otherCitationDetailsField = value;
                NotifyPropertyChanged("OtherCitationDetails");
            }
        }

        private CharacterString_PropertyType otherCitationDetailsField; 

        /// <summary>
        /// collectiveTitle property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("collectiveTitle")]
        public CharacterString_PropertyType CollectiveTitle {
            get {
                return collectiveTitleField;
            } 
            set {
                collectiveTitleField = value;
                NotifyPropertyChanged("CollectiveTitle");
            }
        }

        private CharacterString_PropertyType collectiveTitleField; 

        /// <summary>
        /// ISBN property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("ISBN")]
        public CharacterString_PropertyType ISBN {
            get {
                return ISBNField;
            } 
            set {
                ISBNField = value;
                NotifyPropertyChanged("ISBN");
            }
        }

        private CharacterString_PropertyType ISBNField; 

        /// <summary>
        /// ISSN property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("ISSN")]
        public CharacterString_PropertyType ISSN {
            get {
                return ISSNField;
            } 
            set {
                ISSNField = value;
                NotifyPropertyChanged("ISSN");
            }
        }

        private CharacterString_PropertyType ISSNField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_Date_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_Date_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_Date_PropertyType xsd type.")]
    public partial class CI_Date_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_Date property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_Date")]
        public CI_Date_Type CI_Date {
            get {
                return CI_DateField;
            } 
            set {
                CI_DateField = value;
                NotifyPropertyChanged("CI_Date");
            }
        }

        private CI_Date_Type CI_DateField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the MD_Identifier_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="MD_Identifier_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the MD_Identifier_PropertyType xsd type.")]
    public partial class MD_Identifier_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// MD_Identifier property
        /// </summary>
		[ComponentElement]
		[XmlElement("MD_Identifier")]
        public MD_Identifier_Type MD_Identifier {
            get {
                return MD_IdentifierField;
            } 
            set {
                MD_IdentifierField = value;
                NotifyPropertyChanged("MD_Identifier");
            }
        }

        private MD_Identifier_Type MD_IdentifierField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the MD_Identifier_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Identifier", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the MD_Identifier_Type xsd type.")]
    public partial class MD_Identifier_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// authority property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Citation_PropertyType")]
		[XmlElement("authority")]
        public CI_Citation_PropertyType Authority {
            get {
                return authorityField;
            } 
            set {
                authorityField = value;
                NotifyPropertyChanged("Authority");
            }
        }

        private CI_Citation_PropertyType authorityField; 

        /// <summary>
        /// code property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("code")]
        public CharacterString_PropertyType Code {
            get {
                return codeField;
            } 
            set {
                codeField = value;
                NotifyPropertyChanged("Code");
            }
        }

        private CharacterString_PropertyType codeField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_Citation_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_Citation_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_Citation_PropertyType xsd type.")]
    public partial class CI_Citation_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_Citation property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_Citation")]
        public CI_Citation_Type CI_Citation {
            get {
                return CI_CitationField;
            } 
            set {
                CI_CitationField = value;
                NotifyPropertyChanged("CI_Citation");
            }
        }

        private CI_Citation_Type CI_CitationField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_ResponsibleParty_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_ResponsibleParty_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_ResponsibleParty_PropertyType xsd type.")]
    public partial class CI_ResponsibleParty_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_ResponsibleParty property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_ResponsibleParty")]
        public CI_ResponsibleParty_Type CI_ResponsibleParty {
            get {
                return CI_ResponsiblePartyField;
            } 
            set {
                CI_ResponsiblePartyField = value;
                NotifyPropertyChanged("CI_ResponsibleParty");
            }
        }

        private CI_ResponsibleParty_Type CI_ResponsiblePartyField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_PresentationFormCode_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_PresentationFormCode_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_PresentationFormCode_PropertyType xsd type.")]
    public partial class CI_PresentationFormCode_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_PresentationFormCode property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_PresentationFormCode")]
        public CodeListValue_Type CI_PresentationFormCode {
            get {
                return CI_PresentationFormCodeField;
            } 
            set {
                CI_PresentationFormCodeField = value;
                NotifyPropertyChanged("CI_PresentationFormCode");
            }
        }

        private CodeListValue_Type CI_PresentationFormCodeField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the CI_Series_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CI_Series_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the CI_Series_PropertyType xsd type.")]
    public partial class CI_Series_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CI_Series property
        /// </summary>
		[ComponentElement]
		[XmlElement("CI_Series")]
        public CI_Series_Type CI_Series {
            get {
                return CI_SeriesField;
            } 
            set {
                CI_SeriesField = value;
                NotifyPropertyChanged("CI_Series");
            }
        }

        private CI_Series_Type CI_SeriesField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the AbstractDQ_Element_Type xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_PositionalAccuracy_Type))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDQ_Element", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractDQ_Element_Type xsd type.")]
    public abstract partial class AbstractDQ_Element_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// nameOfMeasure property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("nameOfMeasure")]
        public List<CharacterString_PropertyType> NameOfMeasure {
            get {
                return nameOfMeasureField;
            } 
            set {
                nameOfMeasureField = value;
                NotifyPropertyChanged("NameOfMeasure");
            }
        }

         /// <summary>
         /// bool to indicate if NameOfMeasure has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool NameOfMeasureSpecified
         {
             get {
             if(nameOfMeasureField!=null)
                 return nameOfMeasureField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> nameOfMeasureField; 

        /// <summary>
        /// measureIdentification property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "MD_Identifier_PropertyType")]
		[XmlElement("measureIdentification")]
        public MD_Identifier_PropertyType MeasureIdentification {
            get {
                return measureIdentificationField;
            } 
            set {
                measureIdentificationField = value;
                NotifyPropertyChanged("MeasureIdentification");
            }
        }

        private MD_Identifier_PropertyType measureIdentificationField; 

        /// <summary>
        /// measureDescription property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("measureDescription")]
        public CharacterString_PropertyType MeasureDescription {
            get {
                return measureDescriptionField;
            } 
            set {
                measureDescriptionField = value;
                NotifyPropertyChanged("MeasureDescription");
            }
        }

        private CharacterString_PropertyType measureDescriptionField; 

        /// <summary>
        /// evaluationMethodType property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DQ_EvaluationMethodTypeCode_PropertyType")]
		[XmlElement("evaluationMethodType")]
        public DQ_EvaluationMethodTypeCode_PropertyType EvaluationMethodType {
            get {
                return evaluationMethodTypeField;
            } 
            set {
                evaluationMethodTypeField = value;
                NotifyPropertyChanged("EvaluationMethodType");
            }
        }

        private DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodTypeField; 

        /// <summary>
        /// evaluationMethodDescription property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("evaluationMethodDescription")]
        public CharacterString_PropertyType EvaluationMethodDescription {
            get {
                return evaluationMethodDescriptionField;
            } 
            set {
                evaluationMethodDescriptionField = value;
                NotifyPropertyChanged("EvaluationMethodDescription");
            }
        }

        private CharacterString_PropertyType evaluationMethodDescriptionField; 

        /// <summary>
        /// evaluationProcedure property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Citation_PropertyType")]
		[XmlElement("evaluationProcedure")]
        public CI_Citation_PropertyType EvaluationProcedure {
            get {
                return evaluationProcedureField;
            } 
            set {
                evaluationProcedureField = value;
                NotifyPropertyChanged("EvaluationProcedure");
            }
        }

        private CI_Citation_PropertyType evaluationProcedureField; 

        /// <summary>
        /// dateTime property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DateTime_PropertyType")]
		[XmlElement("dateTime")]
        public List<DateTime_PropertyType> DateTime {
            get {
                return dateTimeField;
            } 
            set {
                dateTimeField = value;
                NotifyPropertyChanged("DateTime");
            }
        }

         /// <summary>
         /// bool to indicate if DateTime has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DateTimeSpecified
         {
             get {
             if(dateTimeField!=null)
                 return dateTimeField.Count>0?true:false;
             else return false;
             }
         }
        private List<DateTime_PropertyType> dateTimeField; 

        /// <summary>
        /// result property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DQ_Result_PropertyType")]
		[XmlElement("result")]
        public List<DQ_Result_PropertyType> Result {
            get {
                return resultField;
            } 
            set {
                resultField = value;
                NotifyPropertyChanged("Result");
            }
        }

         /// <summary>
         /// bool to indicate if Result has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ResultSpecified
         {
             get {
             if(resultField!=null)
                 return resultField.Count>0?true:false;
             else return false;
             }
         }
        private List<DQ_Result_PropertyType> resultField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the DQ_EvaluationMethodTypeCode_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DQ_EvaluationMethodTypeCode_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the DQ_EvaluationMethodTypeCode_PropertyType xsd type.")]
    public partial class DQ_EvaluationMethodTypeCode_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// DQ_EvaluationMethodTypeCode property
        /// </summary>
		[ComponentElement]
		[XmlElement("DQ_EvaluationMethodTypeCode")]
        public CodeListValue_Type DQ_EvaluationMethodTypeCode {
            get {
                return DQ_EvaluationMethodTypeCodeField;
            } 
            set {
                DQ_EvaluationMethodTypeCodeField = value;
                NotifyPropertyChanged("DQ_EvaluationMethodTypeCode");
            }
        }

        private CodeListValue_Type DQ_EvaluationMethodTypeCodeField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the DateTime_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DateTime_PropertyType", Namespace="http://www.isotc211.org/2005/gco")]
	[Description("This class represents the DateTime_PropertyType xsd type.")]
    public partial class DateTime_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// DateTime property
        /// </summary>
		
		[XmlElement("DateTime")]
        public DateTime? DateTime {
            get {
                return DateTimeField;
            } 
            set {
                DateTimeField = value;
                NotifyPropertyChanged("DateTime");
            }
        }

        private DateTime? DateTimeField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the DQ_Result_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DQ_Result_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the DQ_Result_PropertyType xsd type.")]
    public partial class DQ_Result_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractDQ_Result property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractDQ_Result")]
        public AbstractDQ_Result_Type AbstractDQ_Result {
            get {
                return AbstractDQ_ResultField;
            } 
            set {
                AbstractDQ_ResultField = value;
                NotifyPropertyChanged("AbstractDQ_Result");
            }
        }

        private AbstractDQ_Result_Type AbstractDQ_ResultField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the AbstractDQ_PositionalAccuracy_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDQ_PositionalAccuracy", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractDQ_PositionalAccuracy_Type xsd type.")]
    public abstract partial class AbstractDQ_PositionalAccuracy_Type : AbstractDQ_Element_Type, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the EX_VerticalExtent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_VerticalExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the EX_VerticalExtent_Type xsd type.")]
    public partial class EX_VerticalExtent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// minimumValue property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Real_PropertyType")]
		[XmlElement("minimumValue")]
        public Real_PropertyType MinimumValue {
            get {
                return minimumValueField;
            } 
            set {
                minimumValueField = value;
                NotifyPropertyChanged("MinimumValue");
            }
        }

        private Real_PropertyType minimumValueField; 

        /// <summary>
        /// maximumValue property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Real_PropertyType")]
		[XmlElement("maximumValue")]
        public Real_PropertyType MaximumValue {
            get {
                return maximumValueField;
            } 
            set {
                maximumValueField = value;
                NotifyPropertyChanged("MaximumValue");
            }
        }

        private Real_PropertyType maximumValueField; 

        /// <summary>
        /// verticalCRS property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "SC_CRS_PropertyType")]
		[XmlElement("verticalCRS")]
        public SC_CRS_PropertyType VerticalCRS {
            get {
                return verticalCRSField;
            } 
            set {
                verticalCRSField = value;
                NotifyPropertyChanged("VerticalCRS");
            }
        }

        private SC_CRS_PropertyType verticalCRSField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the Real_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Real_PropertyType", Namespace="http://www.isotc211.org/2005/gco")]
	[Description("This class represents the Real_PropertyType xsd type.")]
    public partial class Real_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Real property
        /// </summary>
		
		[XmlElement("Real")]
        public double? Real {
            get {
                return RealField;
            } 
            set {
                RealField = value;
                NotifyPropertyChanged("Real");
            }
        }

        private double? RealField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the SC_CRS_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="SC_CRS_PropertyType", Namespace="http://www.isotc211.org/2005/gsr")]
	[Description("This class represents the SC_CRS_PropertyType xsd type.")]
    public partial class SC_CRS_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractCRS", Namespace="http://www.opengis.net/gml/3.2")]
        public AbstractCRSType AbstractCRS {
            get {
                return AbstractCRSField;
            } 
            set {
                AbstractCRSField = value;
                NotifyPropertyChanged("AbstractCRS");
            }
        }

        private AbstractCRSType AbstractCRSField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the AbstractCRSType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractCRSType xsd type.")]
    public abstract partial class AbstractCRSType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// domainOfValidity property
        /// </summary>
		[RecurringElement]
		[XmlElement("domainOfValidity")]
        public List<DomainOfValidity> DomainOfValidity {
            get {
                return domainOfValidityField;
            } 
            set {
                domainOfValidityField = value;
                NotifyPropertyChanged("DomainOfValidity");
            }
        }

         /// <summary>
         /// bool to indicate if DomainOfValidity has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DomainOfValiditySpecified
         {
             get {
             if(domainOfValidityField!=null)
                 return domainOfValidityField.Count>0?true:false;
             else return false;
             }
         }
        private List<DomainOfValidity> domainOfValidityField; 

        /// <summary>
        /// scope property
        /// </summary>
		[RecurringElement]
		[XmlElement("scope")]
        public List<string> Scope {
            get {
                return scopeField;
            } 
            set {
                scopeField = value;
                NotifyPropertyChanged("Scope");
            }
        }

         /// <summary>
         /// bool to indicate if Scope has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ScopeSpecified
         {
             get {
             if(scopeField!=null)
                 return scopeField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> scopeField; 


    } //here

    /// <summary>
    /// This class represents the GeodeticCRSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticCRSType xsd type.")]
    public partial class GeodeticCRSType : AbstractCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// cartesianCS property
        /// </summary>
        [ComponentElement]
        [XmlElement("cartesianCS")]
        public CartesianCSPropertyType CartesianCS {
            get {
                return cartesianCSField;
            } 
            set {
                cartesianCSField = value;
                CartesianCSSpecified = (value!=null);
                NotifyPropertyChanged("CartesianCS");
            }
        }

        private CartesianCSPropertyType cartesianCSField; 
        private bool cartesianCSSpecified = false; 

        /// <summary>
        /// bool to indicate if CartesianCS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool CartesianCSSpecified
        {
            get {
                return cartesianCSSpecified;
            }
            set {
                cartesianCSSpecified= value;
            }
        }

        /// <summary>
        /// ellipsoidalCS property
        /// </summary>
        [ComponentElement]
        [XmlElement("ellipsoidalCS")]
        public EllipsoidalCSPropertyType EllipsoidalCS {
            get {
                return ellipsoidalCSField;
            } 
            set {
                ellipsoidalCSField = value;
                EllipsoidalCSSpecified = (value!=null);
                NotifyPropertyChanged("EllipsoidalCS");
            }
        }

        private EllipsoidalCSPropertyType ellipsoidalCSField; 
        private bool ellipsoidalCSSpecified = false; 

        /// <summary>
        /// bool to indicate if EllipsoidalCS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool EllipsoidalCSSpecified
        {
            get {
                return ellipsoidalCSSpecified;
            }
            set {
                ellipsoidalCSSpecified= value;
            }
        }

        /// <summary>
        /// sphericalCS property
        /// </summary>
        [ComponentElement]
        [XmlElement("sphericalCS")]
        public SphericalCSPropertyType SphericalCS {
            get {
                return sphericalCSField;
            } 
            set {
                sphericalCSField = value;
                SphericalCSSpecified = (value!=null);
                NotifyPropertyChanged("SphericalCS");
            }
        }

        private SphericalCSPropertyType sphericalCSField; 
        private bool sphericalCSSpecified = false; 

        /// <summary>
        /// bool to indicate if SphericalCS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SphericalCSSpecified
        {
            get {
                return sphericalCSSpecified;
            }
            set {
                sphericalCSSpecified= value;
            }
        }


        /// <summary>
        /// geodeticDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("geodeticDatum")]
        public GeodeticDatumPropertyType GeodeticDatum {
            get {
                return geodeticDatumField;
            } 
            set {
                geodeticDatumField = value;
                NotifyPropertyChanged("GeodeticDatum");
            }
        }

        private GeodeticDatumPropertyType geodeticDatumField; 


    } //here

    /// <summary>
    /// This class represents the CartesianCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("cartesianCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CartesianCSPropertyType xsd type.")]
    public partial class CartesianCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CartesianCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("CartesianCS")]
        public CartesianCSType CartesianCS {
            get {
                return CartesianCSField;
            } 
            set {
                CartesianCSField = value;
                NotifyPropertyChanged("CartesianCS");
            }
        }

        private CartesianCSType CartesianCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the CartesianCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CartesianCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CartesianCSType xsd type.")]
    public partial class CartesianCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the EllipsoidalCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ellipsoidalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidalCSPropertyType xsd type.")]
    public partial class EllipsoidalCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// EllipsoidalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("EllipsoidalCS")]
        public EllipsoidalCSType EllipsoidalCS {
            get {
                return EllipsoidalCSField;
            } 
            set {
                EllipsoidalCSField = value;
                NotifyPropertyChanged("EllipsoidalCS");
            }
        }

        private EllipsoidalCSType EllipsoidalCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the EllipsoidalCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("EllipsoidalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidalCSType xsd type.")]
    public partial class EllipsoidalCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the SphericalCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("sphericalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the SphericalCSPropertyType xsd type.")]
    public partial class SphericalCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// SphericalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("SphericalCS")]
        public SphericalCSType SphericalCS {
            get {
                return SphericalCSField;
            } 
            set {
                SphericalCSField = value;
                NotifyPropertyChanged("SphericalCS");
            }
        }

        private SphericalCSType SphericalCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the SphericalCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("SphericalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the SphericalCSType xsd type.")]
    public partial class SphericalCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the GeodeticDatumPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("geodeticDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticDatumPropertyType xsd type.")]
    public partial class GeodeticDatumPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// GeodeticDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("GeodeticDatum")]
        public GeodeticDatumType GeodeticDatum {
            get {
                return GeodeticDatumField;
            } 
            set {
                GeodeticDatumField = value;
                NotifyPropertyChanged("GeodeticDatum");
            }
        }

        private GeodeticDatumType GeodeticDatumField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the GeodeticDatumType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticDatumType xsd type.")]
    public partial class GeodeticDatumType : AbstractDatumType, INotifyPropertyChanged
    {

        /// <summary>
        /// primeMeridian property
        /// </summary>
		[ComponentElement]
		[XmlElement("primeMeridian")]
        public PrimeMeridianPropertyType PrimeMeridian {
            get {
                return primeMeridianField;
            } 
            set {
                primeMeridianField = value;
                NotifyPropertyChanged("PrimeMeridian");
            }
        }

        private PrimeMeridianPropertyType primeMeridianField; 

        /// <summary>
        /// ellipsoid property
        /// </summary>
		[ComponentElement]
		[XmlElement("ellipsoid")]
        public EllipsoidPropertyType Ellipsoid {
            get {
                return ellipsoidField;
            } 
            set {
                ellipsoidField = value;
                NotifyPropertyChanged("Ellipsoid");
            }
        }

        private EllipsoidPropertyType ellipsoidField; 


    } //here

    /// <summary>
    /// This class represents the PrimeMeridianPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("primeMeridian", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the PrimeMeridianPropertyType xsd type.")]
    public partial class PrimeMeridianPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// PrimeMeridian property
        /// </summary>
		[ComponentElement]
		[XmlElement("PrimeMeridian")]
        public PrimeMeridianType PrimeMeridian {
            get {
                return PrimeMeridianField;
            } 
            set {
                PrimeMeridianField = value;
                NotifyPropertyChanged("PrimeMeridian");
            }
        }

        private PrimeMeridianType PrimeMeridianField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the EllipsoidPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ellipsoid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidPropertyType xsd type.")]
    public partial class EllipsoidPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Ellipsoid property
        /// </summary>
		[ComponentElement]
		[XmlElement("Ellipsoid")]
        public EllipsoidType Ellipsoid {
            get {
                return EllipsoidField;
            } 
            set {
                EllipsoidField = value;
                NotifyPropertyChanged("Ellipsoid");
            }
        }

        private EllipsoidType EllipsoidField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the AbstractGeneralDerivedCRSType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGeneralDerivedCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGeneralDerivedCRSType xsd type.")]
    public abstract partial class AbstractGeneralDerivedCRSType : AbstractCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// conversion property
        /// </summary>
		[ComponentElement]
		[XmlElement("conversion")]
        public GeneralConversionPropertyType Conversion {
            get {
                return conversionField;
            } 
            set {
                conversionField = value;
                NotifyPropertyChanged("Conversion");
            }
        }

        private GeneralConversionPropertyType conversionField; 


    } //here

    /// <summary>
    /// This class represents the GeneralConversionPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("conversion", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeneralConversionPropertyType xsd type.")]
    public partial class GeneralConversionPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractGeneralConversion property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractGeneralConversion")]
        public AbstractGeneralConversionType AbstractGeneralConversion {
            get {
                return AbstractGeneralConversionField;
            } 
            set {
                AbstractGeneralConversionField = value;
                NotifyPropertyChanged("AbstractGeneralConversion");
            }
        }

        private AbstractGeneralConversionType AbstractGeneralConversionField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the AbstractGeneralConversionType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGeneralConversion", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGeneralConversionType xsd type.")]
    public abstract partial class AbstractGeneralConversionType : AbstractCoordinateOperationType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the AbstractCoordinateOperationType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractOperation", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractCoordinateOperationType xsd type.")]
    public abstract partial class AbstractCoordinateOperationType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// domainOfValidity property
        /// </summary>
		[ComponentElement]
		[XmlElement("domainOfValidity")]
        public DomainOfValidity DomainOfValidity {
            get {
                return domainOfValidityField;
            } 
            set {
                domainOfValidityField = value;
                NotifyPropertyChanged("DomainOfValidity");
            }
        }

        private DomainOfValidity domainOfValidityField; 

        /// <summary>
        /// scope property
        /// </summary>
		[RecurringElement]
		[XmlElement("scope")]
        public List<string> Scope {
            get {
                return scopeField;
            } 
            set {
                scopeField = value;
                NotifyPropertyChanged("Scope");
            }
        }

         /// <summary>
         /// bool to indicate if Scope has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ScopeSpecified
         {
             get {
             if(scopeField!=null)
                 return scopeField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> scopeField; 

        /// <summary>
        /// operationVersion property
        /// </summary>
		
		[XmlElement("operationVersion")]
        public string OperationVersion {
            get {
                return operationVersionField;
            } 
            set {
                operationVersionField = value;
                NotifyPropertyChanged("OperationVersion");
            }
        }

        private string operationVersionField; 

        /// <summary>
        /// coordinateOperationAccuracy property
        /// </summary>
		[RecurringElement]
		[XmlElement("coordinateOperationAccuracy")]
        public List<CoordinateOperationAccuracy> CoordinateOperationAccuracy {
            get {
                return coordinateOperationAccuracyField;
            } 
            set {
                coordinateOperationAccuracyField = value;
                NotifyPropertyChanged("CoordinateOperationAccuracy");
            }
        }

         /// <summary>
         /// bool to indicate if CoordinateOperationAccuracy has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool CoordinateOperationAccuracySpecified
         {
             get {
             if(coordinateOperationAccuracyField!=null)
                 return coordinateOperationAccuracyField.Count>0?true:false;
             else return false;
             }
         }
        private List<CoordinateOperationAccuracy> coordinateOperationAccuracyField; 

        /// <summary>
        /// sourceCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("sourceCRS")]
        public CRSPropertyType SourceCRS {
            get {
                return sourceCRSField;
            } 
            set {
                sourceCRSField = value;
                NotifyPropertyChanged("SourceCRS");
            }
        }

        private CRSPropertyType sourceCRSField; 

        /// <summary>
        /// targetCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("targetCRS")]
        public CRSPropertyType TargetCRS {
            get {
                return targetCRSField;
            } 
            set {
                targetCRSField = value;
                NotifyPropertyChanged("TargetCRS");
            }
        }

        private CRSPropertyType targetCRSField; 


    } //here

    /// <summary>
    /// This class represents the coordinateOperationAccuracy xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the coordinateOperationAccuracy xsd type.")]
    public partial class CoordinateOperationAccuracy : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractDQ_PositionalAccuracy property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractDQ_PositionalAccuracy", Namespace="http://www.isotc211.org/2005/gmd")]
        public AbstractDQ_PositionalAccuracy_Type AbstractDQ_PositionalAccuracy {
            get {
                return AbstractDQ_PositionalAccuracyField;
            } 
            set {
                AbstractDQ_PositionalAccuracyField = value;
                NotifyPropertyChanged("AbstractDQ_PositionalAccuracy");
            }
        }

        private AbstractDQ_PositionalAccuracy_Type AbstractDQ_PositionalAccuracyField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the CRSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("sourceCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CRSPropertyType xsd type.")]
    public partial class CRSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractCRS")]
        public AbstractCRSType AbstractCRS {
            get {
                return AbstractCRSField;
            } 
            set {
                AbstractCRSField = value;
                NotifyPropertyChanged("AbstractCRS");
            }
        }

        private AbstractCRSType AbstractCRSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the ProjectedCRSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ProjectedCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the ProjectedCRSType xsd type.")]
    public partial class ProjectedCRSType : AbstractGeneralDerivedCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// Item property
        /// </summary>
		[ComponentElement]
		[XmlElement("baseGeodeticCRS")]
        public GeodeticCRSPropertyType Item {
            get {
                return ItemField;
            } 
            set {
                ItemField = value;
                NotifyPropertyChanged("Item");
            }
        }

        private GeodeticCRSPropertyType ItemField; 

        /// <summary>
        /// cartesianCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("cartesianCS")]
        public CartesianCSPropertyType CartesianCS {
            get {
                return cartesianCSField;
            } 
            set {
                cartesianCSField = value;
                NotifyPropertyChanged("CartesianCS");
            }
        }

        private CartesianCSPropertyType cartesianCSField; 


    } //here

    /// <summary>
    /// This class represents the GeodeticCRSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("baseGeodeticCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticCRSPropertyType xsd type.")]
    public partial class GeodeticCRSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// GeodeticCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("GeodeticCRS")]
        public GeodeticCRSType GeodeticCRS {
            get {
                return GeodeticCRSField;
            } 
            set {
                GeodeticCRSField = value;
                NotifyPropertyChanged("GeodeticCRS");
            }
        }

        private GeodeticCRSType GeodeticCRSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    /// <summary>
    /// This class represents the EX_TemporalExtent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_TemporalExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the EX_TemporalExtent_Type xsd type.")]
    public partial class EX_TemporalExtent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// extent property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "TM_Primitive_PropertyType")]
		[XmlElement("extent")]
        public TM_Primitive_PropertyType Extent {
            get {
                return extentField;
            } 
            set {
                extentField = value;
                NotifyPropertyChanged("Extent");
            }
        }

        private TM_Primitive_PropertyType extentField; 


    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the TM_Primitive_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="TM_Primitive_PropertyType", Namespace="http://www.isotc211.org/2005/gts")]
	[Description("This class represents the TM_Primitive_PropertyType xsd type.")]
    public partial class TM_Primitive_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractTimePrimitive property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractTimePrimitive", Namespace="http://www.opengis.net/gml/3.2")]
        public AbstractTimePrimitiveType AbstractTimePrimitive {
            get {
                return AbstractTimePrimitiveField;
            } 
            set {
                AbstractTimePrimitiveField = value;
                NotifyPropertyChanged("AbstractTimePrimitive");
            }
        }

        private AbstractTimePrimitiveType AbstractTimePrimitiveField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the EX_TemporalExtent_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="EX_TemporalExtent_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the EX_TemporalExtent_PropertyType xsd type.")]
    public partial class EX_TemporalExtent_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// EX_TemporalExtent property
        /// </summary>
		[ComponentElement]
		[XmlElement("EX_TemporalExtent")]
        public EX_TemporalExtent_Type EX_TemporalExtent {
            get {
                return EX_TemporalExtentField;
            } 
            set {
                EX_TemporalExtentField = value;
                NotifyPropertyChanged("EX_TemporalExtent");
            }
        }

        private EX_TemporalExtent_Type EX_TemporalExtentField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the EX_VerticalExtent_PropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="EX_VerticalExtent_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
	[Description("This class represents the EX_VerticalExtent_PropertyType xsd type.")]
    public partial class EX_VerticalExtent_PropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// EX_VerticalExtent property
        /// </summary>
		[ComponentElement]
		[XmlElement("EX_VerticalExtent")]
        public EX_VerticalExtent_Type EX_VerticalExtent {
            get {
                return EX_VerticalExtentField;
            } 
            set {
                EX_VerticalExtentField = value;
                NotifyPropertyChanged("EX_VerticalExtent");
            }
        }

        private EX_VerticalExtent_Type EX_VerticalExtentField; 

		/// <summary>
        /// uuidref property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
        [XmlAttribute("uuidref")]
		
        public string Uuidref {
            get {
                return uuidrefField;
            } 
            set {
                uuidrefField = value;
                NotifyPropertyChanged("Uuidref");
            }
        }

        private string uuidrefField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the VerticalDatumType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalDatumType xsd type.")]
    public partial class VerticalDatumType : AbstractDatumType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the VerticalDatumPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("verticalDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalDatumPropertyType xsd type.")]
    public partial class VerticalDatumPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// VerticalDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("VerticalDatum")]
        public VerticalDatumType VerticalDatum {
            get {
                return VerticalDatumField;
            } 
            set {
                VerticalDatumField = value;
                NotifyPropertyChanged("VerticalDatum");
            }
        }

        private VerticalDatumType VerticalDatumField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the global 2D CRS. 
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlGlobal2dCRS", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Defines the global 2D CRS. ")]
    public partial class ResqmlGlobal2dCRS : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A URN to a well-known Projected CRS.
        /// </summary>
        [XmlElement("srsName", DataType="anyURI")]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
        public string SrsName {
            get {
                return srsNameField;
            } 
            set {
                if (value != null && ProjectedCRSSpecified) throw new Exception("Cannot set property SrsName when property ProjectedCRS is already set");
                srsNameField = value;
                SrsNameSpecified = (value!=null);
                NotifyPropertyChanged("SrsName");
            }
        }

        private string srsNameField; 
        private bool srsNameSpecified = false; 

        /// <summary>
        /// bool to indicate if SrsName has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SrsNameSpecified
        {
            get {
                return srsNameSpecified;
            }
            set {
                srsNameSpecified= value;
            }
        }

        /// <summary>
        /// ProjectedCRS property
        /// </summary>
        [ComponentElement]
        [XmlElement("ProjectedCRS", Namespace="http://www.opengis.net/gml/3.2")]
        public ProjectedCRSType ProjectedCRS {
            get {
                return ProjectedCRSField;
            } 
            set {
                ProjectedCRSField = value;
                ProjectedCRSSpecified = (value!=null);
                NotifyPropertyChanged("ProjectedCRS");
            }
        }

        private ProjectedCRSType ProjectedCRSField; 
        private bool projectedCRSSpecified = false; 

        /// <summary>
        /// bool to indicate if ProjectedCRS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool ProjectedCRSSpecified
        {
            get {
                return projectedCRSSpecified;
            }
            set {
                projectedCRSSpecified= value;
            }
        }


        /// <summary>
        /// The unit of measure of the CRS axes. This must match the unit for the each axis on the CRS.
        /// </summary>
		[Required]
        [Description("The unit of measure of the CRS axes. This must match the unit for the each axis on the CRS.")]
        [EnergisticsDataTypeAttribute(DataType = "ProjectedCoordinateUom")]
		[XmlElement("unit")]
        public ProjectedCoordinateUom? Unit {
            get {
                return unitField;
            } 
            set {
                unitField = value;
                 this.UnitSpecified = true;
                NotifyPropertyChanged("Unit");
            }
        }

        
        private bool UnitSpecifiedField = false;
        
        /// <summary>
        /// UnitSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool UnitSpecified {
            get {
                return UnitSpecifiedField;
            } 
            set {
                UnitSpecifiedField = value;
                NotifyPropertyChanged("UnitSpecified");
            }
        }
        
        private ProjectedCoordinateUom? unitField; 

        /// <summary>
        /// This describes the axis order of the 2D CRS. The order is defined using the EPSG axis names.
        /// </summary>
		[Required]
        [Description("This describes the axis order of the 2D CRS. The order is defined using the EPSG axis names.")]
        [EnergisticsDataTypeAttribute(DataType = "GlobalAxisOrder")]
		[XmlElement("axisOrder")]
        public GlobalAxisOrder? AxisOrder {
            get {
                return axisOrderField;
            } 
            set {
                axisOrderField = value;
                 this.AxisOrderSpecified = true;
                NotifyPropertyChanged("AxisOrder");
            }
        }

        
        private bool AxisOrderSpecifiedField = false;
        
        /// <summary>
        /// AxisOrderSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool AxisOrderSpecified {
            get {
                return AxisOrderSpecifiedField;
            } 
            set {
                AxisOrderSpecifiedField = value;
                NotifyPropertyChanged("AxisOrderSpecified");
            }
        }
        
        private GlobalAxisOrder? axisOrderField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A container for Coordinate Reference System (CRS) information.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_resqmlSpatialReferenceSet", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A container for Coordinate Reference System (CRS) information.")]
    public partial class ResqmlSpatialReferenceSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the projected CRS which represents the global horizontal 2D CRS for the model.
        /// </summary>
		[Required]
        [Description("Defines the projected CRS which represents the  global horizontal 2D CRS for the model.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGlobal2dCRS")]
		[XmlElement("global2dCRS")]
        public ResqmlGlobal2dCRS Global2dCRS {
            get {
                return global2dCRSField;
            } 
            set {
                global2dCRSField = value;
                NotifyPropertyChanged("Global2dCRS");
            }
        }

        private ResqmlGlobal2dCRS global2dCRSField; 

        /// <summary>
        /// Defines the global vertical (length) CRS for the model. All local vertical 1d systems will be defined relative to this system.
        /// </summary>
		[Required]
        [Description("Defines the global vertical (length) CRS for the model. All local vertical 1d systems will be defined relative to this system.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGlobal1dCRS")]
		[XmlElement("globalVerticalCRS")]
        public ResqmlGlobal1dCRS GlobalVerticalCRS {
            get {
                return globalVerticalCRSField;
            } 
            set {
                globalVerticalCRSField = value;
                NotifyPropertyChanged("GlobalVerticalCRS");
            }
        }

        private ResqmlGlobal1dCRS globalVerticalCRSField; 

        /// <summary>
        /// A definition of the global vertical (seismic two-way) time CRS for the model. This will be defined relative to the global vertical (length) CRS. All local vertical time systems will be defined relative to this system.
        /// </summary>
		[Description("A definition of the global vertical (seismic two-way) time CRS for the model. This will be defined relative to the global vertical (length) CRS. All local vertical time systems will be defined relative to this system.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGlobalTimeCRS")]
		[XmlElement("globalTimeCRS")]
        public ResqmlGlobalTimeCRS GlobalTimeCRS {
            get {
                return globalTimeCRSField;
            } 
            set {
                globalTimeCRSField = value;
                NotifyPropertyChanged("GlobalTimeCRS");
            }
        }

        private ResqmlGlobalTimeCRS globalTimeCRSField; 

        /// <summary>
        /// A local 3D Coordinate Reference System (CRS) used in this model. All coordinates will point to a local 3D system.
        /// </summary>
		[Required]
        [Description("A local 3D Coordinate Reference System (CRS) used in this model. All coordinates will point to a local 3D system.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlLocal3dCRS")]
		[XmlElement("local3dCRS")]
        public List<ResqmlLocal3dCRS> Local3dCRS {
            get {
                return local3dCRSField;
            } 
            set {
                local3dCRSField = value;
                NotifyPropertyChanged("Local3dCRS");
            }
        }

         /// <summary>
         /// bool to indicate if Local3dCRS has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Local3dCRSSpecified
         {
             get {
             if(local3dCRSField!=null)
                 return local3dCRSField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlLocal3dCRS> local3dCRSField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// The non-contextual content of a RESQML document object.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_resqmlDocument", Namespace="http://www.resqml.org/schemas/1series")]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "1.1.0.0")]
    [Description("The non-contextual content of a RESQML document object.")]
    public partial class ResqmlDocument : Object, IResqmlDataObject, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[ComponentElement]
		[XmlElement("title", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DublinCoreString titleField; 

        /// <summary>
        /// creator property
        /// </summary>
		[ComponentElement]
		[XmlElement("creator", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Creator {
            get {
                return creatorField;
            } 
            set {
                creatorField = value;
                NotifyPropertyChanged("Creator");
            }
        }

        private DublinCoreString creatorField; 

        /// <summary>
        /// subject property
        /// </summary>
		[ComponentElement]
		[XmlElement("subject", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Subject {
            get {
                return subjectField;
            } 
            set {
                subjectField = value;
                NotifyPropertyChanged("Subject");
            }
        }

        private DublinCoreString subjectField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private DublinCoreString descriptionField; 

        /// <summary>
        /// publisher property
        /// </summary>
		[ComponentElement]
		[XmlElement("publisher", Namespace="http://purl.org/dc/terms/")]
        public DublinCoreString Publisher {
            get {
                return publisherField;
            } 
            set {
                publisherField = value;
                NotifyPropertyChanged("Publisher");
            }
        }

        private DublinCoreString publisherField; 

        /// <summary>
        /// created property
        /// </summary>
		
		[XmlElement("created", Namespace="http://purl.org/dc/terms/")]
        public AbstractW3CDTF Created {
            get {
                return createdField;
            } 
            set {
                createdField = value;
                NotifyPropertyChanged("Created");
            }
        }

        private AbstractW3CDTF createdField; 

        /// <summary>
        /// format property
        /// </summary>
		
		[XmlElement("format", Namespace="http://purl.org/dc/terms/")]
        public ResqmlFormat? Format {
            get {
                return formatField;
            } 
            set {
                formatField = value;
                 this.FormatSpecified = true;
                NotifyPropertyChanged("Format");
            }
        }

        
        private bool FormatSpecifiedField = false;
        
        /// <summary>
        /// FormatSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool FormatSpecified {
            get {
                return FormatSpecifiedField;
            } 
            set {
                FormatSpecifiedField = value;
                NotifyPropertyChanged("FormatSpecified");
            }
        }
        
        private ResqmlFormat? formatField; 

        /// <summary>
        /// A GML based feature representing the area of interest. This contains a mandatory bounding box and an optional polygon outline.
        /// </summary>
		[Description("A GML based feature representing the area of interest. This contains a mandatory bounding box and an optional polygon outline.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlAreaOfInterest")]
		[XmlElement("areaOfInterest")]
        public ResqmlAreaOfInterest AreaOfInterest {
            get {
                return areaOfInterestField;
            } 
            set {
                areaOfInterestField = value;
                NotifyPropertyChanged("AreaOfInterest");
            }
        }

        private ResqmlAreaOfInterest areaOfInterestField; 

        /// <summary>
        /// The set of CRS definitions that are utilized within this message. Any referenced well-known systems will not be included in this set.
        /// </summary>
		[Required]
        [Description("The set of CRS definitions that are utilized within this message. Any referenced well-known systems will not be included in this set.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlSpatialReferenceSet")]
		[XmlElement("spatialReferenceSet")]
        public ResqmlSpatialReferenceSet SpatialReferenceSet {
            get {
                return spatialReferenceSetField;
            } 
            set {
                spatialReferenceSetField = value;
                NotifyPropertyChanged("SpatialReferenceSet");
            }
        }

        private ResqmlSpatialReferenceSet spatialReferenceSetField; 

        /// <summary>
        /// A container for property kind definitions used in this document.
        /// </summary>
		[Description("A container for property kind definitions used in this document.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertyKindSet")]
		[XmlArrayItem("propertyKind")]
        [XmlArray("propertyKindSet")]
        public List<StandAloneResqmlPropertyKind> PropertyKindSet {
            get {
                return propertyKindSetField;
            } 
            set {
                propertyKindSetField = value;
                NotifyPropertyChanged("PropertyKindSet");
            }
        }

         /// <summary>
         /// bool to indicate if PropertyKindSet has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PropertyKindSetSpecified
         {
             get {
             if(propertyKindSetField!=null)
                 return propertyKindSetField.Count>0?true:false;
             else return false;
             }
         }
        private List<StandAloneResqmlPropertyKind> propertyKindSetField; 

        /// <summary>
        /// A container for property groups.
        /// </summary>
		[Description("A container for property groups.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlPropertyGroupSet")]
		[XmlElement("propertyGroupSet")]
        public ResqmlPropertyGroupSet PropertyGroupSet {
            get {
                return propertyGroupSetField;
            } 
            set {
                propertyGroupSetField = value;
                NotifyPropertyChanged("PropertyGroupSet");
            }
        }

        private ResqmlPropertyGroupSet propertyGroupSetField; 

        /// <summary>
        /// A set of interface features and their geometry. These by themselves do not represent a coherent model. They are building blocks which can be used to create a model.
        /// </summary>
		[Description("A set of interface features and their geometry.  These by themselves do not represent a coherent model.  They are building blocks which can be used to create a model.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlInterfaceFeatureSet")]
		[XmlElement("interfaceFeatureSet")]
        public ResqmlInterfaceFeatureSet InterfaceFeatureSet {
            get {
                return interfaceFeatureSetField;
            } 
            set {
                interfaceFeatureSetField = value;
                NotifyPropertyChanged("InterfaceFeatureSet");
            }
        }

        private ResqmlInterfaceFeatureSet interfaceFeatureSetField; 

        /// <summary>
        /// A container for 3D grids and related properties.
        /// </summary>
		[Description("A container for 3D grids and related properties.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_resqmlGriddedVolumeSet")]
		[XmlElement("griddedVolumeSet")]
        public ResqmlGriddedVolumeSet GriddedVolumeSet {
            get {
                return griddedVolumeSetField;
            } 
            set {
                griddedVolumeSetField = value;
                NotifyPropertyChanged("GriddedVolumeSet");
            }
        }

        private ResqmlGriddedVolumeSet griddedVolumeSetField; 

        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
		[Description("A container element that can contain custom or user defined  data elements.")]
        [EnergisticsDataTypeAttribute(DataType = "cs_customData")]
		[XmlElement("customData")]
        public CustomData CustomData {
            get {
                return customDataField;
            } 
            set {
                customDataField = value;
                NotifyPropertyChanged("CustomData");
            }
        }

        private CustomData customDataField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here

    namespace ComponentSchemas 
    {
    /// <summary>
    /// An event type captures the basic information about an event that has affected the data.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentEvent", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("An event type captures the basic information about an event that has affected the data.")]
    public partial class DocumentEvent : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The date on which the event took place.
        /// </summary>
		[Required]
        [Description("The date on which the event took place.")]
        [EnergisticsDataTypeAttribute(DataType = "timestamp")]
		[XmlElement("eventDate")]
        public Timestamp? EventDate {
            get {
                return eventDateField;
            } 
            set {
                eventDateField = value;
                NotifyPropertyChanged("EventDate");
            }
        }

        private Timestamp? eventDateField; 

        /// <summary>
        /// The kind of event event.
        /// </summary>
		[StringLength(64)]
        [Description("The kind of event event.")]
        [EnergisticsDataTypeAttribute(DataType = "nameString")]
		[XmlElement("eventType")]
        public string EventType {
            get {
                return eventTypeField;
            } 
            set {
                eventTypeField = value;
                NotifyPropertyChanged("EventType");
            }
        }

        private string eventTypeField; 

        /// <summary>
        /// The party responsible for the event.
        /// </summary>
		[StringLength(64)]
        [Description("The party responsible for the event.")]
        [EnergisticsDataTypeAttribute(DataType = "nameString")]
		[XmlElement("responsibleParty")]
        public string ResponsibleParty {
            get {
                return responsiblePartyField;
            } 
            set {
                responsiblePartyField = value;
                NotifyPropertyChanged("ResponsibleParty");
            }
        }

        private string responsiblePartyField; 

        /// <summary>
        /// A free form comment that can further define the event that occurred.
        /// </summary>
		[StringLength(4000)]
        [Description("A free form comment that can further  define the event that occurred.")]
        [EnergisticsDataTypeAttribute(DataType = "commentString")]
		[XmlElement("comment")]
        public string Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private string commentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Extension values Schema. The intent is to allow standard WITSML "named" extensions without having to modify the schema. A client or server can ignore any name that it does not recognize but certain meta data is required in order to allow generic clients or servers to process the value.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_extensionNameValue", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("WITSML - Extension values Schema. The intent is to allow standard WITSML named extensions without having to modify the schema. A client or server can ignore any name that it does not recognize but certain meta data is required in order to allow generic clients or servers to process the value.")]
    public partial class ExtensionNameValue : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The name of the extension. Each standard name should document the expected measure class. Each standard name should document the expected maximum size. For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the WITSML SIG Technical Team before use.
        /// </summary>
		[Required]
        [Description("The name of the extension. Each standard name should document the expected measure class. Each standard name should document the expected maximum size.  For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the  WITSML SIG Technical Team before use.")]
        [EnergisticsDataTypeAttribute(DataType = "ExtensionName")]
		[XmlElement("name")]
        public ExtensionName Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private ExtensionName nameField; 

        /// <summary>
        /// The value of the extension. This may also include a uom attribute. The content should conform to constraints defined by the data type.
        /// </summary>
		[Required]
        [Description("The value of the extension.  This may also include a uom attribute.  The content should conform to constraints defined by the data type.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "extensionvalue")]
		[XmlElement("value")]
        public Extensionvalue Value {
            get {
                return valueField;
            } 
            set {
                valueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private Extensionvalue valueField; 

        /// <summary>
        /// The underlying XML type of the value.
        /// </summary>
		[Required]
        [Description("The underlying XML type of the value.")]
        [EnergisticsDataTypeAttribute(DataType = "PrimitiveType")]
		[XmlElement("dataType")]
        public PrimitiveType? DataType {
            get {
                return dataTypeField;
            } 
            set {
                dataTypeField = value;
                 this.DataTypeSpecified = true;
                NotifyPropertyChanged("DataType");
            }
        }

        
        private bool DataTypeSpecifiedField = false;
        
        /// <summary>
        /// DataTypeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DataTypeSpecified {
            get {
                return DataTypeSpecifiedField;
            } 
            set {
                DataTypeSpecifiedField = value;
                NotifyPropertyChanged("DataTypeSpecified");
            }
        }
        
        private PrimitiveType? dataTypeField; 

        /// <summary>
        /// The date-time associated with the value.
        /// </summary>
		[Description("The date-time associated with the value.")]
        [EnergisticsDataTypeAttribute(DataType = "timestamp")]
		[XmlElement("dTim")]
        public Timestamp? DateTime {
            get {
                return dTimField;
            } 
            set {
                dTimField = value;
                 this.DateTimeSpecified = true;
                NotifyPropertyChanged("DateTime");
            }
        }

        private Timestamp? dTimField; 

        /// <summary>
        /// dTimSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DateTimeSpecified {
            get {
                return dTimSpecifiedField;
            } 
            set {
                dTimSpecifiedField = value;
                NotifyPropertyChanged("DateTimeSpecified");
            }
        }

        private bool dTimSpecifiedField; 

        /// <summary>
        /// The measured depth associated with the value.
        /// </summary>
		[Description("The measured depth associated with the value.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "measuredDepthCoord")]
		[XmlElement("md")]
        public MeasuredDepthCoord MD {
            get {
                return mdField;
            } 
            set {
                mdField = value;
                NotifyPropertyChanged("MD");
            }
        }

        private MeasuredDepthCoord mdField; 

        /// <summary>
        /// Indexes things with the same name. That is, 1 indicates the first one, 2 incidates the second one, etc.
        /// </summary>
		[Description("Indexes things with the same name.  That is, 1 indicates the first one, 2 incidates the second one, etc.")]
        [EnergisticsDataTypeAttribute(DataType = "positiveCount")]
		[XmlElement("index")]
        public short? Index {
            get {
                return indexField;
            } 
            set {
                indexField = value;
                 this.IndexSpecified = true;
                NotifyPropertyChanged("Index");
            }
        }

        private short? indexField; 

        /// <summary>
        /// indexSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool IndexSpecified {
            get {
                return indexSpecifiedField;
            } 
            set {
                indexSpecifiedField = value;
                NotifyPropertyChanged("IndexSpecified");
            }
        }

        private bool indexSpecifiedField; 

        /// <summary>
        /// The kind of the measure. For example, "length". This should be specified if the value requires a unit of measure.
        /// </summary>
		[Description("The kind of the measure. For example, \"length\". This should be specified if the value requires a unit of measure.")]
        [EnergisticsDataTypeAttribute(DataType = "MeasureClass")]
		[XmlElement("measureClass")]
        public MeasureClass MeasureClass {
            get {
                return measureClassField;
            } 
            set {
                measureClassField = value;
                 this.MeasureClassSpecified = true;
                NotifyPropertyChanged("MeasureClass");
            }
        }

        private MeasureClass measureClassField; 

        /// <summary>
        /// measureClassSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MeasureClassSpecified {
            get {
                return measureClassSpecifiedField;
            } 
            set {
                measureClassSpecifiedField = value;
                NotifyPropertyChanged("MeasureClassSpecified");
            }
        }

        private bool measureClassSpecifiedField; 

        /// <summary>
        /// A textual description of the extension.
        /// </summary>
		[StringLength(256)]
        [Description("A textual description of the extension.")]
        [EnergisticsDataTypeAttribute(DataType = "descriptionString")]
		[XmlElement("description")]
        public string Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private string descriptionField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Information about the security classification of the document. This is intended as a documentation of the security so that the file will not inadvertently be sent to someone who is not allowed access to the data. This block also carries a date that the security classification expires. For example, a well log is confidential for a period of time, and then becomes open. All security classes are characterized by their classification systems.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentSecurityInfo", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("Information about the security classification of the document. This is intended as a documentation of the security so that the file will not inadvertently be sent to someone who is not allowed access to the data. This block also carries a date that the security classification expires. For example, a well log is confidential for a period of time, and then becomes open. All security classes are characterized by their classification systems.")]
    public partial class DocumentSecurityInfo : Object, IUniqueId, INotifyPropertyChanged
    {

        /// <summary>
        /// The security class in which this document is classified. Examples would be confidential, partner confidential, tight. The meaning of the class is determined by the System in which it is defined.
        /// </summary>
		[StringLength(40)]
        [Description("The security class in which this document is  classified. Examples would be confidential, partner confidential,  tight. The meaning of the class is determined by the System in which  it is defined.")]
        [EnergisticsDataTypeAttribute(DataType = "kindString")]
		[XmlElement("class")]
        public string Class {
            get {
                return classField;
            } 
            set {
                classField = value;
                NotifyPropertyChanged("Class");
            }
        }

        private string classField; 

        /// <summary>
        /// The security classification system. This gives context to the meaning of the Class value.
        /// </summary>
		[StringLength(40)]
        [Description("The security classification system.  This gives context to the meaning of the Class value.")]
        [EnergisticsDataTypeAttribute(DataType = "kindString")]
		[XmlElement("securitySystem")]
        public string SecuritySystem {
            get {
                return securitySystemField;
            } 
            set {
                securitySystemField = value;
                NotifyPropertyChanged("SecuritySystem");
            }
        }

        private string securitySystemField; 

        /// <summary>
        /// The date on which this security class is no longer applicable.
        /// </summary>
		[Description("The date on which this security class is no  longer applicable.")]
        [EnergisticsDataTypeAttribute(DataType = "timestamp")]
		[XmlElement("endDate")]
        public Timestamp? EndDate {
            get {
                return endDateField;
            } 
            set {
                endDateField = value;
                 this.EndDateSpecified = true;
                NotifyPropertyChanged("EndDate");
            }
        }

        private Timestamp? endDateField; 

        /// <summary>
        /// endDateSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool EndDateSpecified {
            get {
                return endDateSpecifiedField;
            } 
            set {
                endDateSpecifiedField = value;
                NotifyPropertyChanged("EndDateSpecified");
            }
        }

        private bool endDateSpecifiedField; 

        /// <summary>
        /// A general comment to further define the security class.
        /// </summary>
		[StringLength(4000)]
        [Description("A general comment to further define the security  class.")]
        [EnergisticsDataTypeAttribute(DataType = "commentString")]
		[XmlElement("comment")]
        public string Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private string commentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_extensionNameValue")]
		[XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue {
            get {
                return extensionNameValueField;
            } 
            set {
                extensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(extensionNameValueField!=null)
                 return extensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[RegularExpression("[^ ]*")]
        [StringLength(64)]
        [Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [EnergisticsDataTypeAttribute(DataType = "uidString")]
        [XmlAttribute("uid")]
		
        public string Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private string uidField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A block of information about the creation of the XML file. This is different than the creation of the data that is included within the file.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentFileCreation", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A block of information about the creation of the XML file. This is different than the creation of the data that is included within the file.")]
    public partial class DocumentFileCreation : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The date and time that the file was created.
        /// </summary>
		[Required]
        [Description("The date and time that the file was created.")]
        [EnergisticsDataTypeAttribute(DataType = "timestamp")]
		[XmlElement("fileCreationDate")]
        public Timestamp? FileCreationDate {
            get {
                return fileCreationDateField;
            } 
            set {
                fileCreationDateField = value;
                NotifyPropertyChanged("FileCreationDate");
            }
        }

        private Timestamp? fileCreationDateField; 

        /// <summary>
        /// If appropriate, the software that created the file. This is a free form string, and may include whatever information is deemed relevant.
        /// </summary>
		[StringLength(64)]
        [Description("If appropriate, the software that created the file.  This is a free form string, and may include whatever information  is deemed relevant.")]
        [EnergisticsDataTypeAttribute(DataType = "nameString")]
		[XmlElement("softwareName")]
        public string SoftwareName {
            get {
                return softwareNameField;
            } 
            set {
                softwareNameField = value;
                NotifyPropertyChanged("SoftwareName");
            }
        }

        private string softwareNameField; 

        /// <summary>
        /// The person or business associate that created the file.
        /// </summary>
		[StringLength(64)]
        [Description("The person or business associate that created  the file.")]
        [EnergisticsDataTypeAttribute(DataType = "nameString")]
		[XmlElement("fileCreator")]
        public string FileCreator {
            get {
                return fileCreatorField;
            } 
            set {
                fileCreatorField = value;
                NotifyPropertyChanged("FileCreator");
            }
        }

        private string fileCreatorField; 

        /// <summary>
        /// Any comment that would be useful to further explain the creation of this instance document.
        /// </summary>
		[StringLength(4000)]
        [Description("Any comment that would be useful to further  explain the creation of this instance document.")]
        [EnergisticsDataTypeAttribute(DataType = "commentString")]
		[XmlElement("comment")]
        public string Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private string commentField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the nameStruct xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="nameStruct", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("This class represents the nameStruct xsd type.")]
    public partial class NameStruct : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the NameStruct class.
        /// </summary>
        public NameStruct() {}

        /// <summary>
        /// Initializes a new instance of the NameStruct class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public NameStruct(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The naming system within the name is (hopefully) unique.
        /// </summary>
		[StringLength(64)]
        [Description("The naming system within the name is (hopefully) unique.")]
        [EnergisticsDataTypeAttribute(DataType = "nameString")]
        [XmlAttribute("namingSystem")]
		
        public string NamingSystem {
            get {
                return namingSystemField;
            } 
            set {
                namingSystemField = value;
                NotifyPropertyChanged("NamingSystem");
            }
        }

        private string namingSystemField; 

        /// <summary>
        /// Value property
        /// </summary>
        [StringLength(64)]
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private string ValueField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A schema to capture a set of data that is relevant for many exchange documents. It includes information about the file that was created, and high-level information about the data that is being exchanged within the file.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentInfo", Namespace="http://www.resqml.org/schemas/1series")]
	[Description("A schema to capture a set of data that is relevant for many exchange documents. It includes information about the file that was created, and high-level information about the data that is being exchanged within the file.")]
    public partial class DocumentInfo : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// An identifier for the document. This is intended to be unique within the context of the NamingSystem.
        /// </summary>
		[Required]
        [Description("An identifier for the document. This is  intended to be unique within the context of the NamingSystem.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "nameStruct")]
		[XmlElement("documentName")]
        public NameStruct DocumentName {
            get {
                return documentNameField;
            } 
            set {
                documentNameField = value;
                NotifyPropertyChanged("DocumentName");
            }
        }

        private NameStruct documentNameField; 

        /// <summary>
        /// Zero or more alternate names for the document. These names do not need to be unique within the naming system.
        /// </summary>
		[Description("Zero or more alternate names for the document.  These names do not need to be unique within the naming system.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "nameStruct")]
		[XmlElement("documentAlias")]
        public List<NameStruct> DocumentAlias {
            get {
                return documentAliasField;
            } 
            set {
                documentAliasField = value;
                NotifyPropertyChanged("DocumentAlias");
            }
        }

         /// <summary>
         /// bool to indicate if DocumentAlias has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DocumentAliasSpecified
         {
             get {
             if(documentAliasField!=null)
                 return documentAliasField.Count>0?true:false;
             else return false;
             }
         }
        private List<NameStruct> documentAliasField; 

        /// <summary>
        /// The date of the creation of the document. This is not the same as the date that the file was created. For this date, the document is considered to be the set of information associated with this document information. For example, the document may be a seismic binset. This represents the date that the binset was created. The FileCreation information would capture the date that the XML file was created to send or exchange the binset.
        /// </summary>
		[Description("The date of the creation of the document.  This is not the same as the date that the file was created.  For this date, the document is considered to be the set of  information associated with this document information.  For example, the document may be a seismic binset.  This represents the date that the binset was created.  The FileCreation information would capture the date that  the XML file was created to send or exchange the binset.")]
        [EnergisticsDataTypeAttribute(DataType = "timestamp")]
		[XmlElement("documentDate")]
        public Timestamp? DocumentDate {
            get {
                return documentDateField;
            } 
            set {
                documentDateField = value;
                 this.DocumentDateSpecified = true;
                NotifyPropertyChanged("DocumentDate");
            }
        }

        private Timestamp? documentDateField; 

        /// <summary>
        /// documentDateSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DocumentDateSpecified {
            get {
                return documentDateSpecifiedField;
            } 
            set {
                documentDateSpecifiedField = value;
                NotifyPropertyChanged("DocumentDateSpecified");
            }
        }

        private bool documentDateSpecifiedField; 

        /// <summary>
        /// A document class. Examples of classes would be a metadata classification or a set of keywords. 
        /// </summary>
		[Description("A document class. Examples of classes would be a  metadata classification or a set of keywords.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "nameStruct")]
		[XmlElement("documentClass")]
        public List<NameStruct> DocumentClass {
            get {
                return documentClassField;
            } 
            set {
                documentClassField = value;
                NotifyPropertyChanged("DocumentClass");
            }
        }

         /// <summary>
         /// bool to indicate if DocumentClass has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DocumentClassSpecified
         {
             get {
             if(documentClassField!=null)
                 return documentClassField.Count>0?true:false;
             else return false;
             }
         }
        private List<NameStruct> documentClassField; 

        /// <summary>
        /// The information about the creation of the exchange file. This is not about the creation of the data within the file, but the creation of the file itself.
        /// </summary>
		[Description("The information about the creation of the  exchange file. This is not about the creation of the data within  the file, but the creation of the file itself.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_documentFileCreation")]
		[XmlElement("fileCreationInformation")]
        public DocumentFileCreation FileCreationInformation {
            get {
                return fileCreationInformationField;
            } 
            set {
                fileCreationInformationField = value;
                NotifyPropertyChanged("FileCreationInformation");
            }
        }

        private DocumentFileCreation fileCreationInformationField; 

        /// <summary>
        /// Information about the security to be applied to this file. More than one classification can be given.
        /// </summary>
		[Description("Information about the security to be applied to  this file. More than one classification can be given.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_documentSecurityInfo")]
		[XmlElement("securityInformation")]
        public List<DocumentSecurityInfo> SecurityInformation {
            get {
                return securityInformationField;
            } 
            set {
                securityInformationField = value;
                NotifyPropertyChanged("SecurityInformation");
            }
        }

         /// <summary>
         /// bool to indicate if SecurityInformation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool SecurityInformationSpecified
         {
             get {
             if(securityInformationField!=null)
                 return securityInformationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DocumentSecurityInfo> securityInformationField; 

        /// <summary>
        /// A free-form string that allows a disclaimer to accompany the information.
        /// </summary>
		[StringLength(4000)]
        [Description("A free-form string that allows a disclaimer to  accompany the information.")]
        [EnergisticsDataTypeAttribute(DataType = "commentString")]
		[XmlElement("disclaimer")]
        public string Disclaimer {
            get {
                return disclaimerField;
            } 
            set {
                disclaimerField = value;
                NotifyPropertyChanged("Disclaimer");
            }
        }

        private string disclaimerField; 

        /// <summary>
        /// A collection of events that can document the history of the data.
        /// </summary>
		[Description("A collection of events that can document the  history of the data.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_documentAudit")]
		[XmlArrayItem("event")]
        [XmlArray("auditTrail")]
        public List<DocumentEvent> AuditTrail {
            get {
                return auditTrailField;
            } 
            set {
                auditTrailField = value;
                NotifyPropertyChanged("AuditTrail");
            }
        }

         /// <summary>
         /// bool to indicate if AuditTrail has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AuditTrailSpecified
         {
             get {
             if(auditTrailField!=null)
                 return auditTrailField.Count>0?true:false;
             else return false;
             }
         }
        private List<DocumentEvent> auditTrailField; 

        /// <summary>
        /// The owner of the data.
        /// </summary>
		[StringLength(64)]
        [Description("The owner of the data.")]
        [EnergisticsDataTypeAttribute(DataType = "nameString")]
		[XmlElement("owner")]
        public string Owner {
            get {
                return ownerField;
            } 
            set {
                ownerField = value;
                NotifyPropertyChanged("Owner");
            }
        }

        private string ownerField; 

        /// <summary>
        /// An optional comment about the document.
        /// </summary>
		[StringLength(4000)]
        [Description("An optional comment about the document.")]
        [EnergisticsDataTypeAttribute(DataType = "commentString")]
		[XmlElement("comment")]
        public string Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private string commentField; 


        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name="info">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
    } //here
    }

    /// <summary>
    /// This class represents the obj_resqmlDocuments xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("resqmlDocuments", Namespace="http://www.resqml.org/schemas/1series", IsNullable=false)]
	[Description("This class represents the obj_resqmlDocuments xsd type.")]
    public partial class ResqmlDocumentList : AbstractObject, IEnergisticsCollection, INotifyPropertyChanged
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
		[Description("Information about the XML message instance.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "cs_documentInfo")]
		[XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo {
            get {
                return documentInfoField;
            } 
            set {
                documentInfoField = value;
                NotifyPropertyChanged("DocumentInfo");
            }
        }

        private DocumentInfo documentInfoField; 

        /// <summary>
        /// Information about a single resqmlDocument.
        /// </summary>
		[Required]
        [Description("Information about a single resqmlDocument.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "obj_resqmlDocument")]
		[XmlElement("resqmlDocument")]
        public List<ResqmlDocument> ResqmlDocument {
            get {
                return resqmlDocumentField;
            } 
            set {
                resqmlDocumentField = value;
                NotifyPropertyChanged("ResqmlDocument");
            }
        }

         /// <summary>
         /// bool to indicate if ResqmlDocument has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ResqmlDocumentSpecified
         {
             get {
             if(resqmlDocumentField!=null)
                 return resqmlDocumentField.Count>0?true:false;
             else return false;
             }
         }
        private List<ResqmlDocument> resqmlDocumentField; 

        /// <summary>
        /// Information about a single resqmlDocument.
        /// </summary>
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return ResqmlDocument;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
		[Required]
        [RegularExpression("1\\.([1-9][0-9]|[1-9])\\.[1-9]?[0-9]\\.[1-9]?[0-9]\\(RESQML\\)")]
        [StringLength(16)]
        [Description("Data object schema version.  The fourth level must match the  version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.")]
        [EnergisticsDataTypeAttribute(DataType = "schemaVersionStringResqml")]
        [XmlAttribute("version")]
		
        public string Version {
            get {
                return versionField;
            } 
            set {
                versionField = value;
                NotifyPropertyChanged("Version");
            }
        }

        private string versionField = "1.1.0.0(RESQML)"; 


    } //here

    #endregion

    #region Enumerations
    namespace ReferenceData {
        /// <summary>
        /// This class represents the CellShape xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the CellShape xsd enumeration.")]
        public enum CellShape 
        {
        /// <summary>
        /// Cells defined by the tri-linear isoparametric mapping from the unit cube.
        /// </summary>
          cartesian
        }
        /// <summary>
        /// This class represents the ResqmlMostComplexLineGeometry xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the ResqmlMostComplexLineGeometry xsd enumeration.")]
        public enum ResqmlMostComplexLineGeometry 
        {
        /// <summary>
        /// This is the less complex than straight.
        /// </summary>
          vertical,
        /// <summary>
        /// This is less complex than curved and more complex than vertical.
        /// </summary>
          straight,
        /// <summary>
        /// This is more complex than straight or vertical.
        /// </summary>
          curved
        }
        /// <summary>
        /// This class represents the PropertyAttachment xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the PropertyAttachment xsd enumeration.")]
        public enum PropertyAttachment 
        {
        /// <summary>
        /// Properties are associated with the nodes of the object.
        /// </summary>
          nodes,
        /// <summary>
        /// Properties are associated with the edges of the object.
        /// </summary>
          edges,
        /// <summary>
        /// Properties are associated with the faces of the object.
        /// </summary>
          faces,
        /// <summary>
        /// Properties are associated with the cells of the object.
        /// </summary>
          cells
        }
        /// <summary>
        /// This class represents the PrimitiveType xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the PrimitiveType xsd enumeration.")]
        public enum PrimitiveType 
        {
        /// <summary>
        /// string property
        /// </summary>
          @string,
        /// <summary>
        /// boolean property
        /// </summary>
          boolean,
        /// <summary>
        /// float property
        /// </summary>
          @float,
        /// <summary>
        /// double property
        /// </summary>
          @double,
        /// <summary>
        /// duration property
        /// </summary>
          duration,
        /// <summary>
        /// dateTime property
        /// </summary>
          dateTime,
        /// <summary>
        /// time property
        /// </summary>
          time,
        /// <summary>
        /// date property
        /// </summary>
          date,
        /// <summary>
        /// gYearMonth property
        /// </summary>
          gYearMonth,
        /// <summary>
        /// gYear property
        /// </summary>
          gYear,
        /// <summary>
        /// gMonthDay property
        /// </summary>
          gMonthDay,
        /// <summary>
        /// gDay property
        /// </summary>
          gDay,
        /// <summary>
        /// gMonth property
        /// </summary>
          gMonth,
        /// <summary>
        /// base64Binary property
        /// </summary>
          base64Binary,
        /// <summary>
        /// anyURI property
        /// </summary>
          anyURI,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the MeasuredDepthUom xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the MeasuredDepthUom xsd enumeration.")]
        public enum MeasuredDepthUom 
        {
        /// <summary>
        /// meter
        /// </summary>
          m,
        /// <summary>
        /// International Foot
        /// </summary>
          ft,
        /// <summary>
        /// US Survey Foot
        /// </summary>
          ftUS
        }
        /// <summary>
        /// This class represents the ItemChoiceType xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType xsd enumeration.")]
        public enum ItemChoiceType 
        {
        /// <summary>
        /// parentLocalKind property
        /// </summary>
          parentLocalKind,
        /// <summary>
        /// parentResqmlKind property
        /// </summary>
          parentResqmlKind,
        /// <summary>
        /// resqmlKind property
        /// </summary>
          resqmlKind
        }
        /// <summary>
        /// This class represents the ItemsChoiceType1 xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType1 xsd enumeration.")]
        public enum ItemsChoiceType1 
        {
        /// <summary>
        /// dimensionalClass property
        /// </summary>
          dimensionalClass,
        /// <summary>
        /// enumValue property
        /// </summary>
          enumValue,
        /// <summary>
        /// maximumValue property
        /// </summary>
          maximumValue,
        /// <summary>
        /// minimumValue property
        /// </summary>
          minimumValue,
        /// <summary>
        /// unitOfMeasure property
        /// </summary>
          unitOfMeasure
        }
        /// <summary>
        /// This class represents the VerticalTimeUnit xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the VerticalTimeUnit xsd enumeration.")]
        public enum VerticalTimeUnit 
        {
        /// <summary>
        /// Second. This is only valid when the domain is time.
        /// </summary>
          s,
        /// <summary>
        /// Milliseconds. This is only valid when the domain is time.
        /// </summary>
          ms
        }
        /// <summary>
        /// This class represents the RelatedTimeTypeRelativePosition xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        [Description("This class represents the RelatedTimeTypeRelativePosition xsd enumeration.")]
        public enum RelatedTimeTypeRelativePosition 
        {
        /// <summary>
        /// Before property
        /// </summary>
          Before,
        /// <summary>
        /// After property
        /// </summary>
          After,
        /// <summary>
        /// Begins property
        /// </summary>
          Begins,
        /// <summary>
        /// Ends property
        /// </summary>
          Ends,
        /// <summary>
        /// During property
        /// </summary>
          During,
        /// <summary>
        /// Equals property
        /// </summary>
          Equals,
        /// <summary>
        /// Contains property
        /// </summary>
          Contains,
        /// <summary>
        /// Overlaps property
        /// </summary>
          Overlaps,
        /// <summary>
        /// Meets property
        /// </summary>
          Meets,
        /// <summary>
        /// OverlappedBy property
        /// </summary>
          OverlappedBy,
        /// <summary>
        /// MetBy property
        /// </summary>
          MetBy,
        /// <summary>
        /// BegunBy property
        /// </summary>
          BegunBy,
        /// <summary>
        /// EndedBy property
        /// </summary>
          EndedBy
        }
        /// <summary>
        /// This class represents the ItemsChoiceType xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        [Description("This class represents the ItemsChoiceType xsd enumeration.")]
        public enum ItemsChoiceType 
        {
        /// <summary>
        /// lowerCorner property
        /// </summary>
          lowerCorner,
        /// <summary>
        /// pos property
        /// </summary>
          pos,
        /// <summary>
        /// upperCorner property
        /// </summary>
          upperCorner
        }
        /// <summary>
        /// This class represents the AggregationType xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        [Description("This class represents the AggregationType xsd enumeration.")]
        public enum AggregationType 
        {
        /// <summary>
        /// set property
        /// </summary>
          set,
        /// <summary>
        /// bag property
        /// </summary>
          bag,
        /// <summary>
        /// sequence property
        /// </summary>
          sequence,
        /// <summary>
        /// array property
        /// </summary>
          array,
        /// <summary>
        /// record property
        /// </summary>
          record,
        /// <summary>
        /// table property
        /// </summary>
          table
        }
        /// <summary>
        /// This class represents the WellVerticalCoordinateUom xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the WellVerticalCoordinateUom xsd enumeration.")]
        public enum WellVerticalCoordinateUom 
        {
        /// <summary>
        /// meter
        /// </summary>
          m,
        /// <summary>
        /// International Foot
        /// </summary>
          ft,
        /// <summary>
        /// US Survey Foot
        /// </summary>
          ftUS,
        /// <summary>
        /// ftBr65 property
        /// </summary>
          [XmlEnum("ftBr(65)")]
          ftBr65
        }
        /// <summary>
        /// This class represents the VerticalDirection xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the VerticalDirection xsd enumeration.")]
        public enum VerticalDirection 
        {
        /// <summary>
        /// Values are positive when moving away from the center of the Earth.
        /// </summary>
          up,
        /// <summary>
        /// Values are positive when moving toward the center of the Earth.
        /// </summary>
          down
        }
        /// <summary>
        /// This class represents the ProjectedCoordinateUom xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the ProjectedCoordinateUom xsd enumeration.")]
        public enum ProjectedCoordinateUom 
        {
        /// <summary>
        /// meter
        /// </summary>
          m,
        /// <summary>
        /// International Foot
        /// </summary>
          ft,
        /// <summary>
        /// US Survey Foot
        /// </summary>
          ftUS,
        /// <summary>
        /// ftBr65 property
        /// </summary>
          [XmlEnum("ftBr(65)")]
          ftBr65,
        /// <summary>
        /// Benoit chain (1895 B)
        /// </summary>
          chBnB,
        /// <summary>
        /// Sears chain
        /// </summary>
          chSe,
        /// <summary>
        /// Sears Foot
        /// </summary>
          ftSe,
        /// <summary>
        /// Sears yard
        /// </summary>
          ydSe,
        /// <summary>
        /// Imperial Foot. Same as EPSG "Clarke foot".
        /// </summary>
          ftCla,
        /// <summary>
        /// Clarke link
        /// </summary>
          lkCla,
        /// <summary>
        /// Gold Coast Foot
        /// </summary>
          ftGC,
        /// <summary>
        /// Indian yard
        /// </summary>
          ydInd,
        /// <summary>
        /// kilometre
        /// </summary>
          km
        }
        /// <summary>
        /// This class represents the GlobalAxisOrder xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.resqml.org/schemas/1series")]
        [Description("This class represents the GlobalAxisOrder xsd enumeration.")]
        public enum GlobalAxisOrder 
        {
        /// <summary>
        /// eastingnorthing property
        /// </summary>
          [XmlEnum("easting northing")]
          eastingnorthing,
        /// <summary>
        /// northingeasting property
        /// </summary>
          [XmlEnum("northing easting")]
          northingeasting,
        /// <summary>
        /// westingsouthing property
        /// </summary>
          [XmlEnum("westing southing")]
          westingsouthing,
        /// <summary>
        /// southingwesting property
        /// </summary>
          [XmlEnum("southing westing")]
          southingwesting,
        /// <summary>
        /// northingwesting property
        /// </summary>
          [XmlEnum("northing westing")]
          northingwesting,
        /// <summary>
        /// westingnorthing property
        /// </summary>
          [XmlEnum("westing northing")]
          westingnorthing
        }
        /// <summary>
        /// This class represents the ResqmlFormat xsd enumeration.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
        [Description("This class represents the ResqmlFormat xsd enumeration.")]
        public enum ResqmlFormat 
        {
        /// <summary>
        /// RESQMLXMLonly property
        /// </summary>
          [XmlEnum("RESQML XML only")]
          RESQMLXMLonly,
        /// <summary>
        /// RESQMLXMLHDF property
        /// </summary>
          [XmlEnum("RESQML XML/HDF")]
          RESQMLXMLHDF
        }
    }
    #endregion
}