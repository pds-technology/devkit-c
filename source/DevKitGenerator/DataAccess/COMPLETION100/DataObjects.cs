
//This code was generated using the Energistics Generator tool.  Direct changes to this code will be lost
//during regeneration.

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using Energistics.DataAccess.COMPLETION100.ComponentSchemas;
using Energistics.DataAccess.COMPLETION100.ReferenceData;
using Energistics.DataAccess.Validation;

namespace Energistics.DataAccess.COMPLETION100
{
    #region Classes
    /// <summary>
    /// This class represents the abstractObject xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellCompletionList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellCMLedgerList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreCompletionList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DownholeComponentList))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
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

    /// <summary>
    /// The non-contextual content of a well completion object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_wellCompletion", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("The non-contextual content of a well completion object.")]
    public partial class WellCompletion : Object, IWellObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Human recognizable context for the well that contains the completion. 
        /// </summary>
		[Required]
		[StringLength(64)]
		[Description("Human recognizable context for the well that contains the completion.")]
		[XmlElement("nameWell")]
        public String NameWell {
            get {
                return nameWellField;
            } 
            set {
                nameWellField = value;
                NotifyPropertyChanged("NameWell");
            }
        }

        private String nameWellField; 

        /// <summary>
        /// Human recognizable context for the completion. 
        /// </summary>
		[Required]
		[StringLength(64)]
		[Description("Human recognizable context for the completion.")]
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// fieldID property
        /// </summary>
		[StringLength(64)]
		[Description("Field ID.")]
		[XmlElement("fieldID")]
        public String FieldID {
            get {
                return fieldIDField;
            } 
            set {
                fieldIDField = value;
                NotifyPropertyChanged("FieldID");
            }
        }

        private String fieldIDField; 

        /// <summary>
        /// fieldCode property
        /// </summary>
		[StringLength(64)]
		[Description("Field code.")]
		[XmlElement("fieldCode")]
        public String FieldCode {
            get {
                return fieldCodeField;
            } 
            set {
                fieldCodeField = value;
                NotifyPropertyChanged("FieldCode");
            }
        }

        private String fieldCodeField; 

        /// <summary>
        /// fieldType property
        /// </summary>
		[StringLength(64)]
		[Description("Field type.")]
		[XmlElement("fieldType")]
        public String FieldType {
            get {
                return fieldTypeField;
            } 
            set {
                fieldTypeField = value;
                NotifyPropertyChanged("FieldType");
            }
        }

        private String fieldTypeField; 

        /// <summary>
        /// effectiveDate property
        /// </summary>
		[Description("Field date.")]
		[XmlElement("effectiveDate")]
        public Timestamp? EffectiveDate {
            get {
                return effectiveDateField;
            } 
            set {
                effectiveDateField = value;
                this.EffectiveDateSpecified = true;
                NotifyPropertyChanged("EffectiveDate");
            }
        }

        private Timestamp? effectiveDateField; 

		/// <summary>
        /// effectiveDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EffectiveDateSpecified {
            get {
                return effectiveDateSpecifiedField;
            } 
            set {
                effectiveDateSpecifiedField = value;
                NotifyPropertyChanged("EffectiveDateSpecified");
            }
        }

        private Boolean effectiveDateSpecifiedField; 

        /// <summary>
        /// expiredDate property
        /// </summary>
		[Description("Expiration date")]
		[XmlElement("expiredDate")]
        public Timestamp? ExpiredDate {
            get {
                return expiredDateField;
            } 
            set {
                expiredDateField = value;
                this.ExpiredDateSpecified = true;
                NotifyPropertyChanged("ExpiredDate");
            }
        }

        private Timestamp? expiredDateField; 

		/// <summary>
        /// expiredDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ExpiredDateSpecified {
            get {
                return expiredDateSpecifiedField;
            } 
            set {
                expiredDateSpecifiedField = value;
                NotifyPropertyChanged("ExpiredDateSpecified");
            }
        }

        private Boolean expiredDateSpecifiedField; 

        /// <summary>
        /// E_P_RightsID property
        /// </summary>
		[StringLength(64)]
		[Description("Documents exploration and production rights")]
		[XmlElement("E_P_RightsID")]
        public String E_P_RightsID {
            get {
                return E_P_RightsIDField;
            } 
            set {
                E_P_RightsIDField = value;
                NotifyPropertyChanged("E_P_RightsID");
            }
        }

        private String E_P_RightsIDField; 

        /// <summary>
        /// currentStatus property
        /// </summary>
		
		[XmlElement("currentStatus")]
        public CompletionStatus? CurrentStatus {
            get {
                return currentStatusField;
            } 
            set {
                currentStatusField = value;
                this.CurrentStatusSpecified = true;
                NotifyPropertyChanged("CurrentStatus");
            }
        }

        private CompletionStatus? currentStatusField; 

		/// <summary>
        /// currentStatusSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CurrentStatusSpecified {
            get {
                return currentStatusSpecifiedField;
            } 
            set {
                currentStatusSpecifiedField = value;
                NotifyPropertyChanged("CurrentStatusSpecified");
            }
        }

        private Boolean currentStatusSpecifiedField; 

        /// <summary>
        /// statusDate property
        /// </summary>
		
		[XmlElement("statusDate")]
        public Timestamp? StatusDate {
            get {
                return statusDateField;
            } 
            set {
                statusDateField = value;
                this.StatusDateSpecified = true;
                NotifyPropertyChanged("StatusDate");
            }
        }

        private Timestamp? statusDateField; 

		/// <summary>
        /// statusDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusDateSpecified {
            get {
                return statusDateSpecifiedField;
            } 
            set {
                statusDateSpecifiedField = value;
                NotifyPropertyChanged("StatusDateSpecified");
            }
        }

        private Boolean statusDateSpecifiedField; 

        /// <summary>
        /// statusHistory property
        /// </summary>
		[RecurringElement]
		[XmlElement("statusHistory")]
        public List<CompletionStatusHistory> StatusHistory {
            get {
                return statusHistoryField;
            } 
            set {
                statusHistoryField = value;
                NotifyPropertyChanged("StatusHistory");
            }
        }

        private List<CompletionStatusHistory> statusHistoryField; 

        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
		[Description("A container element that contains elements that are common to all data  objects.")]
		[ComponentElement]
		[XmlElement("commonData")]
        public CommonData CommonData {
            get {
                return commonDataField;
            } 
            set {
                commonDataField = value;
                NotifyPropertyChanged("CommonData");
            }
        }

        private CommonData commonDataField; 

        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
		[Description("A container element that can contain custom or user defined  data elements.")]
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
        /// Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell. 
        /// </summary>
		[Description("Unique identifier for the well. This uniquely represents  the well referenced by the (possibly non-unique) nameWell.")]
        [XmlAttribute("uidWell")]
		
        public String UidWell {
            get {
                return uidWellField;
            } 
            set {
                uidWellField = value;
                NotifyPropertyChanged("UidWell");
            }
        }

        private String uidWellField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the CompletionStatusHistory xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CompletionStatusHistory", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the CompletionStatusHistory xsd type.")]
    public partial class CompletionStatusHistory : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Completion status
        /// </summary>
		[Description("Completion status")]
		[XmlElement("status")]
        public CompletionStatus? Status {
            get {
                return statusField;
            } 
            set {
                statusField = value;
                this.StatusSpecified = true;
                NotifyPropertyChanged("Status");
            }
        }

        private CompletionStatus? statusField; 

		/// <summary>
        /// statusSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified {
            get {
                return statusSpecifiedField;
            } 
            set {
                statusSpecifiedField = value;
                NotifyPropertyChanged("StatusSpecified");
            }
        }

        private Boolean statusSpecifiedField; 

        /// <summary>
        /// the start date of status
        /// </summary>
		[Description("the start date of status")]
		[XmlElement("startDate")]
        public Timestamp? StartDate {
            get {
                return startDateField;
            } 
            set {
                startDateField = value;
                this.StartDateSpecified = true;
                NotifyPropertyChanged("StartDate");
            }
        }

        private Timestamp? startDateField; 

		/// <summary>
        /// startDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StartDateSpecified {
            get {
                return startDateSpecifiedField;
            } 
            set {
                startDateSpecifiedField = value;
                NotifyPropertyChanged("StartDateSpecified");
            }
        }

        private Boolean startDateSpecifiedField; 

        /// <summary>
        /// the end date of status
        /// </summary>
		[Description("the end date of status")]
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
        public Boolean EndDateSpecified {
            get {
                return endDateSpecifiedField;
            } 
            set {
                endDateSpecifiedField = value;
                NotifyPropertyChanged("EndDateSpecified");
            }
        }

        private Boolean endDateSpecifiedField; 

        /// <summary>
        /// The measured bottom of perforation
        /// </summary>
		[Description("The measured bottom of perforation")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// The measured top of perforation
        /// </summary>
		[Description("The measured top of perforation")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// The description about the status
        /// </summary>
		[StringLength(4000)]
		[Description("The description about the status")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="measuredDepthCoord", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the measuredDepthCoord xsd type.")]
    public partial class MeasuredDepthCoord : AbstractMeasure, INotifyPropertyChanged
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
        public MeasuredDepthCoord(Double value, MeasuredDepthUom uom)
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
		[Description("The unit of measure of the quantity value.")]
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
		[Description("A pointer to the reference datum for this coordinate  value as defined in WellDatum. This value is assumed to match the uid value in a WellDatum. If not given then the default WellDatum must be assumed.")]
        [XmlAttribute("datum")]
		
        public String Datum {
            get {
                return datumField;
            } 
            set {
                datumField = value;
                NotifyPropertyChanged("Datum");
            }
        }

        private String datumField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the abstractMeasure xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FootageEastWest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FootageNorthSouth))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellElevationCoord))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellVerticalDepthCoord))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasuredDepthCoord))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RatioGenericMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasureOrQuantity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumePerVolumeMeasurePercent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(YAxisAzimuth))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumePerVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumePerLengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumeFlowRateMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VelocityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThermodynamicTemperatureMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThermalVolumetricExpansionMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThermalConductivityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StandardVolumePerTimeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StandardVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecificVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecificHeatCapacityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelativePowerMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PressureMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneAngleMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PermeabilityRockMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerLengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MomentOfForceMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MassPerLengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MassMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MassConcentrationMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MagneticInductionMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthPerLengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IlluminanceMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForcePerVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForcePerLengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForceMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EquivalentPerMassMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectricPotentialMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectricCurrentMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicViscosityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DimensionlessMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DensityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompressibilityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaPerAreaMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnglePerTimeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnglePerLengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccelerationLinearMeasure))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="abstractMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the abstractMeasure xsd type.")]
    public abstract partial class AbstractMeasure : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public Double Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private Double ValueField; 


        
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
    /// This class represents the footageEastWest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="footageEastWest", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the footageEastWest xsd type.")]
    public partial class FootageEastWest : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the FootageEastWest class.
        /// </summary>
        public FootageEastWest() {}

        /// <summary>
        /// Initializes a new instance of the FootageEastWest class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public FootageEastWest(Double value, LengthUom uom)
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
        /// The unit of measure of the distance value.
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public LengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private LengthUom uomField; 

		/// <summary>
        /// Specifies the reference line that is the origin of the distance.
        /// </summary>
		
        [XmlAttribute("ref")]
		
        public EastOrWest Ref {
            get {
                return refField;
            } 
            set {
                refField = value;
                NotifyPropertyChanged("Ref");
            }
        }

        private EastOrWest refField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the footageNorthSouth xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="footageNorthSouth", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the footageNorthSouth xsd type.")]
    public partial class FootageNorthSouth : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the FootageNorthSouth class.
        /// </summary>
        public FootageNorthSouth() {}

        /// <summary>
        /// Initializes a new instance of the FootageNorthSouth class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public FootageNorthSouth(Double value, LengthUom uom)
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
        /// The unit of measure of the distance value.
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public LengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private LengthUom uomField; 

		/// <summary>
        /// Specifies the reference line that is the origin of the distance.
        /// </summary>
		
        [XmlAttribute("ref")]
		
        public NorthOrSouth Ref {
            get {
                return refField;
            } 
            set {
                refField = value;
                NotifyPropertyChanged("Ref");
            }
        }

        private NorthOrSouth refField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the wellElevationCoord xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="wellElevationCoord", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the wellElevationCoord xsd type.")]
    public partial class WellElevationCoord : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the WellElevationCoord class.
        /// </summary>
        public WellElevationCoord() {}

        /// <summary>
        /// Initializes a new instance of the WellElevationCoord class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public WellElevationCoord(Double value, WellVerticalCoordinateUom uom)
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
        /// The unit of measure of the quantity value. If not given then the default unit of measure of the explicitly or implicitly given datum must be assumed.
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public WellVerticalCoordinateUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private WellVerticalCoordinateUom uomField; 

		/// <summary>
        /// A pointer to the reference datum for this coordinate value as defined in WellDatum. If not given then the default WellDatum must be assumed.
        /// </summary>
		
        [XmlAttribute("datum")]
		
        public String Datum {
            get {
                return datumField;
            } 
            set {
                datumField = value;
                NotifyPropertyChanged("Datum");
            }
        }

        private String datumField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the wellVerticalDepthCoord xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="wellVerticalDepthCoord", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the wellVerticalDepthCoord xsd type.")]
    public partial class WellVerticalDepthCoord : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the WellVerticalDepthCoord class.
        /// </summary>
        public WellVerticalDepthCoord() {}

        /// <summary>
        /// Initializes a new instance of the WellVerticalDepthCoord class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public WellVerticalDepthCoord(Double value, WellVerticalCoordinateUom uom)
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
		[Description("The unit of measure of the quantity value.")]
        [XmlAttribute("uom")]
		
        public WellVerticalCoordinateUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private WellVerticalCoordinateUom uomField; 

		/// <summary>
        /// A pointer to the reference datum for this coordinate value as defined in WellDatum. If not given then the default WellDatum must be assumed.
        /// </summary>
		[Description("A pointer to the reference datum for this coordinate  value as defined in WellDatum.  If not given then the default WellDatum must be assumed.")]
        [XmlAttribute("datum")]
		
        public String Datum {
            get {
                return datumField;
            } 
            set {
                datumField = value;
                NotifyPropertyChanged("Datum");
            }
        }

        private String datumField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the ratioGenericMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ratioGenericMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the ratioGenericMeasure xsd type.")]
    public partial class RatioGenericMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the RatioGenericMeasure class.
        /// </summary>
        public RatioGenericMeasure() {}

        /// <summary>
        /// Initializes a new instance of the RatioGenericMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public RatioGenericMeasure(Double value, String uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public String Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private String uomField; 

		/// <summary>
        /// numerator property
        /// </summary>
		
        [XmlAttribute("numerator")]
		
        public Double Numerator {
            get {
                return numeratorField;
            } 
            set {
                numeratorField = value;
                this.NumeratorSpecified = true;
                NotifyPropertyChanged("Numerator");
            }
        }

        private Double numeratorField; 

		/// <summary>
        /// numeratorSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean NumeratorSpecified {
            get {
                return numeratorSpecifiedField;
            } 
            set {
                numeratorSpecifiedField = value;
                NotifyPropertyChanged("NumeratorSpecified");
            }
        }

        private Boolean numeratorSpecifiedField; 

		/// <summary>
        /// denominator property
        /// </summary>
		
        [XmlAttribute("denominator")]
		
        public Double Denominator {
            get {
                return denominatorField;
            } 
            set {
                denominatorField = value;
                this.DenominatorSpecified = true;
                NotifyPropertyChanged("Denominator");
            }
        }

        private Double denominatorField; 

		/// <summary>
        /// denominatorSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DenominatorSpecified {
            get {
                return denominatorSpecifiedField;
            } 
            set {
                denominatorSpecifiedField = value;
                NotifyPropertyChanged("DenominatorSpecified");
            }
        }

        private Boolean denominatorSpecifiedField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the genericMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="genericMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the genericMeasure xsd type.")]
    public partial class GenericMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the GenericMeasure class.
        /// </summary>
        public GenericMeasure() {}

        /// <summary>
        /// Initializes a new instance of the GenericMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public GenericMeasure(Double value, String uom)
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
        /// The unit of measure for the quantity.
        /// </summary>
		[Description("The unit of measure for the quantity.")]
        [XmlAttribute("uom")]
		
        public String Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private String uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the measureOrQuantity xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="measureOrQuantity", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the measureOrQuantity xsd type.")]
    public partial class MeasureOrQuantity : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MeasureOrQuantity class.
        /// </summary>
        public MeasureOrQuantity() {}

        /// <summary>
        /// Initializes a new instance of the MeasureOrQuantity class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public MeasureOrQuantity(Double value, String uom)
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
        /// The unit of measure for the quantity. This value must conform to the values allowed by a measure class. If the value is a measure then the uom must be specified.
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public String Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private String uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumePerVolumeMeasurePercent xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumePerVolumeMeasurePercent", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the volumePerVolumeMeasurePercent xsd type.")]
    public partial class VolumePerVolumeMeasurePercent : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the VolumePerVolumeMeasurePercent class.
        /// </summary>
        public VolumePerVolumeMeasurePercent() {}

        /// <summary>
        /// Initializes a new instance of the VolumePerVolumeMeasurePercent class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public VolumePerVolumeMeasurePercent(Double value, PercentUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public PercentUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private PercentUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the yAxisAzimuth xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="yAxisAzimuth", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the yAxisAzimuth xsd type.")]
    public partial class YAxisAzimuth : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the YAxisAzimuth class.
        /// </summary>
        public YAxisAzimuth() {}

        /// <summary>
        /// Initializes a new instance of the YAxisAzimuth class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public YAxisAzimuth(Double value, PlaneAngleUom uom)
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
        /// The unit of measure of the azimuth value.
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public PlaneAngleUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private PlaneAngleUom uomField; 

		/// <summary>
        /// Specifies the direction to be considered North for the y axis.
        /// </summary>
		
        [XmlAttribute("northDirection")]
		
        public AziRef NorthDirection {
            get {
                return northDirectionField;
            } 
            set {
                northDirectionField = value;
                this.NorthDirectionSpecified = true;
                NotifyPropertyChanged("NorthDirection");
            }
        }

        private AziRef northDirectionField; 

		/// <summary>
        /// northDirectionSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean NorthDirectionSpecified {
            get {
                return northDirectionSpecifiedField;
            } 
            set {
                northDirectionSpecifiedField = value;
                NotifyPropertyChanged("NorthDirectionSpecified");
            }
        }

        private Boolean northDirectionSpecifiedField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumePerVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumePerVolumeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the volumePerVolumeMeasure xsd type.")]
    public partial class VolumePerVolumeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the VolumePerVolumeMeasure class.
        /// </summary>
        public VolumePerVolumeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the VolumePerVolumeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public VolumePerVolumeMeasure(Double value, VolumePerVolumeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public VolumePerVolumeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private VolumePerVolumeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumePerLengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumePerLengthMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the volumePerLengthMeasure xsd type.")]
    public partial class VolumePerLengthMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the VolumePerLengthMeasure class.
        /// </summary>
        public VolumePerLengthMeasure() {}

        /// <summary>
        /// Initializes a new instance of the VolumePerLengthMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public VolumePerLengthMeasure(Double value, VolumePerLengthUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public VolumePerLengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private VolumePerLengthUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumeFlowRateMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumeFlowRateMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the volumeFlowRateMeasure xsd type.")]
    public partial class VolumeFlowRateMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the VolumeFlowRateMeasure class.
        /// </summary>
        public VolumeFlowRateMeasure() {}

        /// <summary>
        /// Initializes a new instance of the VolumeFlowRateMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public VolumeFlowRateMeasure(Double value, VolumeFlowRateUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public VolumeFlowRateUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private VolumeFlowRateUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the volumeMeasure xsd type.")]
    public partial class VolumeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the VolumeMeasure class.
        /// </summary>
        public VolumeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the VolumeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public VolumeMeasure(Double value, VolumeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public VolumeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private VolumeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the velocityMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="velocityMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the velocityMeasure xsd type.")]
    public partial class VelocityMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the VelocityMeasure class.
        /// </summary>
        public VelocityMeasure() {}

        /// <summary>
        /// Initializes a new instance of the VelocityMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public VelocityMeasure(Double value, VelocityUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public VelocityUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private VelocityUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the timeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="timeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the timeMeasure xsd type.")]
    public partial class TimeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the TimeMeasure class.
        /// </summary>
        public TimeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the TimeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public TimeMeasure(Double value, TimeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public TimeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private TimeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the thermodynamicTemperatureMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="thermodynamicTemperatureMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the thermodynamicTemperatureMeasure xsd type.")]
    public partial class ThermodynamicTemperatureMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ThermodynamicTemperatureMeasure class.
        /// </summary>
        public ThermodynamicTemperatureMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ThermodynamicTemperatureMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ThermodynamicTemperatureMeasure(Double value, ThermodynamicTemperatureUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ThermodynamicTemperatureUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ThermodynamicTemperatureUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the thermalVolumetricExpansionMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="thermalVolumetricExpansionMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the thermalVolumetricExpansionMeasure xsd type.")]
    public partial class ThermalVolumetricExpansionMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ThermalVolumetricExpansionMeasure class.
        /// </summary>
        public ThermalVolumetricExpansionMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ThermalVolumetricExpansionMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ThermalVolumetricExpansionMeasure(Double value, ThermalVolumetricExpansionUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ThermalVolumetricExpansionUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ThermalVolumetricExpansionUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the thermalConductivityMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="thermalConductivityMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the thermalConductivityMeasure xsd type.")]
    public partial class ThermalConductivityMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ThermalConductivityMeasure class.
        /// </summary>
        public ThermalConductivityMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ThermalConductivityMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ThermalConductivityMeasure(Double value, ThermalConductivityUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ThermalConductivityUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ThermalConductivityUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the standardVolumePerTimeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="standardVolumePerTimeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the standardVolumePerTimeMeasure xsd type.")]
    public partial class StandardVolumePerTimeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the StandardVolumePerTimeMeasure class.
        /// </summary>
        public StandardVolumePerTimeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the StandardVolumePerTimeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public StandardVolumePerTimeMeasure(Double value, StandardVolumePerTimeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public StandardVolumePerTimeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private StandardVolumePerTimeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the standardVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="standardVolumeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the standardVolumeMeasure xsd type.")]
    public partial class StandardVolumeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the StandardVolumeMeasure class.
        /// </summary>
        public StandardVolumeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the StandardVolumeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public StandardVolumeMeasure(Double value, StandardVolumeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public StandardVolumeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private StandardVolumeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the specificVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="specificVolumeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the specificVolumeMeasure xsd type.")]
    public partial class SpecificVolumeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the SpecificVolumeMeasure class.
        /// </summary>
        public SpecificVolumeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the SpecificVolumeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public SpecificVolumeMeasure(Double value, SpecificVolumeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public SpecificVolumeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private SpecificVolumeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the specificHeatCapacityMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="specificHeatCapacityMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the specificHeatCapacityMeasure xsd type.")]
    public partial class SpecificHeatCapacityMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the SpecificHeatCapacityMeasure class.
        /// </summary>
        public SpecificHeatCapacityMeasure() {}

        /// <summary>
        /// Initializes a new instance of the SpecificHeatCapacityMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public SpecificHeatCapacityMeasure(Double value, SpecificHeatCapacityUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public SpecificHeatCapacityUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private SpecificHeatCapacityUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the relativePowerMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="relativePowerMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the relativePowerMeasure xsd type.")]
    public partial class RelativePowerMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the RelativePowerMeasure class.
        /// </summary>
        public RelativePowerMeasure() {}

        /// <summary>
        /// Initializes a new instance of the RelativePowerMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public RelativePowerMeasure(Double value, RelativePowerUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public RelativePowerUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private RelativePowerUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the pressureMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="pressureMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the pressureMeasure xsd type.")]
    public partial class PressureMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the PressureMeasure class.
        /// </summary>
        public PressureMeasure() {}

        /// <summary>
        /// Initializes a new instance of the PressureMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public PressureMeasure(Double value, PressureUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public PressureUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private PressureUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the powerMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="powerMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the powerMeasure xsd type.")]
    public partial class PowerMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the PowerMeasure class.
        /// </summary>
        public PowerMeasure() {}

        /// <summary>
        /// Initializes a new instance of the PowerMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public PowerMeasure(Double value, PowerUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public PowerUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private PowerUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the planeAngleMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="planeAngleMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the planeAngleMeasure xsd type.")]
    public partial class PlaneAngleMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the PlaneAngleMeasure class.
        /// </summary>
        public PlaneAngleMeasure() {}

        /// <summary>
        /// Initializes a new instance of the PlaneAngleMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public PlaneAngleMeasure(Double value, PlaneAngleUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public PlaneAngleUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private PlaneAngleUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the permeabilityRockMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="permeabilityRockMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the permeabilityRockMeasure xsd type.")]
    public partial class PermeabilityRockMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the PermeabilityRockMeasure class.
        /// </summary>
        public PermeabilityRockMeasure() {}

        /// <summary>
        /// Initializes a new instance of the PermeabilityRockMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public PermeabilityRockMeasure(Double value, PermeabilityRockUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public PermeabilityRockUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private PermeabilityRockUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the perLengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="perLengthMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the perLengthMeasure xsd type.")]
    public partial class PerLengthMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the PerLengthMeasure class.
        /// </summary>
        public PerLengthMeasure() {}

        /// <summary>
        /// Initializes a new instance of the PerLengthMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public PerLengthMeasure(Double value, PerLengthUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public PerLengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private PerLengthUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the momentOfForceMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="momentOfForceMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the momentOfForceMeasure xsd type.")]
    public partial class MomentOfForceMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MomentOfForceMeasure class.
        /// </summary>
        public MomentOfForceMeasure() {}

        /// <summary>
        /// Initializes a new instance of the MomentOfForceMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public MomentOfForceMeasure(Double value, MomentOfForceUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public MomentOfForceUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private MomentOfForceUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the massPerLengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massPerLengthMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the massPerLengthMeasure xsd type.")]
    public partial class MassPerLengthMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MassPerLengthMeasure class.
        /// </summary>
        public MassPerLengthMeasure() {}

        /// <summary>
        /// Initializes a new instance of the MassPerLengthMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public MassPerLengthMeasure(Double value, MassPerLengthUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public MassPerLengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private MassPerLengthUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the massMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the massMeasure xsd type.")]
    public partial class MassMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MassMeasure class.
        /// </summary>
        public MassMeasure() {}

        /// <summary>
        /// Initializes a new instance of the MassMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public MassMeasure(Double value, MassUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public MassUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private MassUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the massConcentrationMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massConcentrationMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the massConcentrationMeasure xsd type.")]
    public partial class MassConcentrationMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MassConcentrationMeasure class.
        /// </summary>
        public MassConcentrationMeasure() {}

        /// <summary>
        /// Initializes a new instance of the MassConcentrationMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public MassConcentrationMeasure(Double value, MassConcentrationUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public MassConcentrationUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private MassConcentrationUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the magneticInductionMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="magneticInductionMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the magneticInductionMeasure xsd type.")]
    public partial class MagneticInductionMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MagneticInductionMeasure class.
        /// </summary>
        public MagneticInductionMeasure() {}

        /// <summary>
        /// Initializes a new instance of the MagneticInductionMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public MagneticInductionMeasure(Double value, MagneticInductionUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public MagneticInductionUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private MagneticInductionUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the lengthPerLengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lengthPerLengthMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the lengthPerLengthMeasure xsd type.")]
    public partial class LengthPerLengthMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the LengthPerLengthMeasure class.
        /// </summary>
        public LengthPerLengthMeasure() {}

        /// <summary>
        /// Initializes a new instance of the LengthPerLengthMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public LengthPerLengthMeasure(Double value, LengthPerLengthUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public LengthPerLengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private LengthPerLengthUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the lengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lengthMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the lengthMeasure xsd type.")]
    public partial class LengthMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the LengthMeasure class.
        /// </summary>
        public LengthMeasure() {}

        /// <summary>
        /// Initializes a new instance of the LengthMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public LengthMeasure(Double value, LengthUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public LengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private LengthUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the illuminanceMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="illuminanceMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the illuminanceMeasure xsd type.")]
    public partial class IlluminanceMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the IlluminanceMeasure class.
        /// </summary>
        public IlluminanceMeasure() {}

        /// <summary>
        /// Initializes a new instance of the IlluminanceMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public IlluminanceMeasure(Double value, IlluminanceUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public IlluminanceUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private IlluminanceUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the forcePerVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="forcePerVolumeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the forcePerVolumeMeasure xsd type.")]
    public partial class ForcePerVolumeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ForcePerVolumeMeasure class.
        /// </summary>
        public ForcePerVolumeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ForcePerVolumeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ForcePerVolumeMeasure(Double value, ForcePerVolumeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ForcePerVolumeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ForcePerVolumeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the forcePerLengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="forcePerLengthMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the forcePerLengthMeasure xsd type.")]
    public partial class ForcePerLengthMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ForcePerLengthMeasure class.
        /// </summary>
        public ForcePerLengthMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ForcePerLengthMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ForcePerLengthMeasure(Double value, ForcePerLengthUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ForcePerLengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ForcePerLengthUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the forceMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="forceMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the forceMeasure xsd type.")]
    public partial class ForceMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ForceMeasure class.
        /// </summary>
        public ForceMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ForceMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ForceMeasure(Double value, ForceUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ForceUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ForceUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the equivalentPerMassMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="equivalentPerMassMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the equivalentPerMassMeasure xsd type.")]
    public partial class EquivalentPerMassMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the EquivalentPerMassMeasure class.
        /// </summary>
        public EquivalentPerMassMeasure() {}

        /// <summary>
        /// Initializes a new instance of the EquivalentPerMassMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public EquivalentPerMassMeasure(Double value, EquivalentPerMassUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public EquivalentPerMassUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private EquivalentPerMassUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the electricPotentialMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="electricPotentialMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the electricPotentialMeasure xsd type.")]
    public partial class ElectricPotentialMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ElectricPotentialMeasure class.
        /// </summary>
        public ElectricPotentialMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ElectricPotentialMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ElectricPotentialMeasure(Double value, ElectricPotentialUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ElectricPotentialUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ElectricPotentialUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the electricCurrentMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="electricCurrentMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the electricCurrentMeasure xsd type.")]
    public partial class ElectricCurrentMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ElectricCurrentMeasure class.
        /// </summary>
        public ElectricCurrentMeasure() {}

        /// <summary>
        /// Initializes a new instance of the ElectricCurrentMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public ElectricCurrentMeasure(Double value, ElectricCurrentUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public ElectricCurrentUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private ElectricCurrentUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the dynamicViscosityMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="dynamicViscosityMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the dynamicViscosityMeasure xsd type.")]
    public partial class DynamicViscosityMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the DynamicViscosityMeasure class.
        /// </summary>
        public DynamicViscosityMeasure() {}

        /// <summary>
        /// Initializes a new instance of the DynamicViscosityMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public DynamicViscosityMeasure(Double value, DynamicViscosityUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public DynamicViscosityUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private DynamicViscosityUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the dimensionlessMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="dimensionlessMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the dimensionlessMeasure xsd type.")]
    public partial class DimensionlessMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the DimensionlessMeasure class.
        /// </summary>
        public DimensionlessMeasure() {}

        /// <summary>
        /// Initializes a new instance of the DimensionlessMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public DimensionlessMeasure(Double value, DimensionlessUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public DimensionlessUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private DimensionlessUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the densityMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="densityMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the densityMeasure xsd type.")]
    public partial class DensityMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the DensityMeasure class.
        /// </summary>
        public DensityMeasure() {}

        /// <summary>
        /// Initializes a new instance of the DensityMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public DensityMeasure(Double value, DensityUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public DensityUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private DensityUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the compressibilityMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="compressibilityMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the compressibilityMeasure xsd type.")]
    public partial class CompressibilityMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the CompressibilityMeasure class.
        /// </summary>
        public CompressibilityMeasure() {}

        /// <summary>
        /// Initializes a new instance of the CompressibilityMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public CompressibilityMeasure(Double value, CompressibilityUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public CompressibilityUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private CompressibilityUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the areaPerAreaMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="areaPerAreaMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the areaPerAreaMeasure xsd type.")]
    public partial class AreaPerAreaMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the AreaPerAreaMeasure class.
        /// </summary>
        public AreaPerAreaMeasure() {}

        /// <summary>
        /// Initializes a new instance of the AreaPerAreaMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public AreaPerAreaMeasure(Double value, AreaPerAreaUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public AreaPerAreaUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private AreaPerAreaUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the areaMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="areaMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the areaMeasure xsd type.")]
    public partial class AreaMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the AreaMeasure class.
        /// </summary>
        public AreaMeasure() {}

        /// <summary>
        /// Initializes a new instance of the AreaMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public AreaMeasure(Double value, AreaUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public AreaUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private AreaUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the anglePerTimeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="anglePerTimeMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the anglePerTimeMeasure xsd type.")]
    public partial class AnglePerTimeMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the AnglePerTimeMeasure class.
        /// </summary>
        public AnglePerTimeMeasure() {}

        /// <summary>
        /// Initializes a new instance of the AnglePerTimeMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public AnglePerTimeMeasure(Double value, AnglePerTimeUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public AnglePerTimeUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private AnglePerTimeUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the anglePerLengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="anglePerLengthMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the anglePerLengthMeasure xsd type.")]
    public partial class AnglePerLengthMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the AnglePerLengthMeasure class.
        /// </summary>
        public AnglePerLengthMeasure() {}

        /// <summary>
        /// Initializes a new instance of the AnglePerLengthMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public AnglePerLengthMeasure(Double value, AnglePerLengthUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public AnglePerLengthUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private AnglePerLengthUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the accelerationLinearMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="accelerationLinearMeasure", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the accelerationLinearMeasure xsd type.")]
    public partial class AccelerationLinearMeasure : AbstractMeasure, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the AccelerationLinearMeasure class.
        /// </summary>
        public AccelerationLinearMeasure() {}

        /// <summary>
        /// Initializes a new instance of the AccelerationLinearMeasure class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public AccelerationLinearMeasure(Double value, AccelerationLinearUom uom)
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
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public AccelerationLinearUom Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private AccelerationLinearUom uomField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    ///  WITSML - Common Data Component Schema 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_commonData", Namespace="http://www.witsml.org/schemas/1series")]
    [Description(" WITSML - Common Data Component Schema ")]
    public partial class CommonData : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// An identifier to indicate the data originator. This identifies the server that originally created the object and thus most of the uids in the object (but not necessarily the uids of the parents). This is typically a url. 
        /// </summary>
		[StringLength(64)]
		[Description("An identifier to indicate the data originator. This identifies the server that originally created  the object and thus most of the uids in the object (but not  necessarily the uids of the parents). This is typically a url.")]
		[XmlElement("sourceName")]
        public String SourceName {
            get {
                return sourceNameField;
            } 
            set {
                sourceNameField = value;
                NotifyPropertyChanged("SourceName");
            }
        }

        private String sourceNameField; 

        /// <summary>
        /// When the data was created at the persistent data store. This is an API server parameter releted to the "Special Handling of Change Information" within a server. See the relevant API specification for the behavior related to this element.
        /// </summary>
		[Description("When the data was created at the persistent data store.  This is an API server parameter releted to the \"Special Handling of Change Information\" within a server.  See the relevant API specification for the  behavior related to this element.")]
		[XmlElement("dTimCreation")]
        public Timestamp? DateTimeCreation {
            get {
                return dTimCreationField;
            } 
            set {
                dTimCreationField = value;
                this.DateTimeCreationSpecified = true;
                NotifyPropertyChanged("DateTimeCreation");
            }
        }

        private Timestamp? dTimCreationField; 

		/// <summary>
        /// dTimCreationSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeCreationSpecified {
            get {
                return dTimCreationSpecifiedField;
            } 
            set {
                dTimCreationSpecifiedField = value;
                NotifyPropertyChanged("DateTimeCreationSpecified");
            }
        }

        private Boolean dTimCreationSpecifiedField; 

        /// <summary>
        /// Last change of any element of the data at the persistent data store. This is an API server parameter releted to the "Special Handling of Change Information" within a server. See the relevant API specification for the behavior related to this element.
        /// </summary>
		[Description("Last change of any element of the data at the persistent data store. This is an API server parameter releted to the \"Special Handling of Change Information\" within a server.  See the relevant API specification for the  behavior related to this element.")]
		[XmlElement("dTimLastChange")]
        public Timestamp? DateTimeLastChange {
            get {
                return dTimLastChangeField;
            } 
            set {
                dTimLastChangeField = value;
                this.DateTimeLastChangeSpecified = true;
                NotifyPropertyChanged("DateTimeLastChange");
            }
        }

        private Timestamp? dTimLastChangeField; 

		/// <summary>
        /// dTimLastChangeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeLastChangeSpecified {
            get {
                return dTimLastChangeSpecifiedField;
            } 
            set {
                dTimLastChangeSpecifiedField = value;
                NotifyPropertyChanged("DateTimeLastChangeSpecified");
            }
        }

        private Boolean dTimLastChangeSpecifiedField; 

        /// <summary>
        /// The item state for the data object. 
        /// </summary>
		[Description("The item state for the data object.")]
		[XmlElement("itemState")]
        public ItemState? ItemState {
            get {
                return itemStateField;
            } 
            set {
                itemStateField = value;
                this.ItemStateSpecified = true;
                NotifyPropertyChanged("ItemState");
            }
        }

        private ItemState? itemStateField; 

		/// <summary>
        /// itemStateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ItemStateSpecified {
            get {
                return itemStateSpecifiedField;
            } 
            set {
                itemStateSpecifiedField = value;
                NotifyPropertyChanged("ItemStateSpecified");
            }
        }

        private Boolean itemStateSpecifiedField; 

        /// <summary>
        /// The category of the service related to the creation of the object. For example, "mud log service", "cement service", "LWD service", "rig service", "drilling service". 
        /// </summary>
		[StringLength(40)]
		[Description("The category of the service related to the creation of the object.  For example, \"mud log service\", \"cement service\", \"LWD service\", \"rig service\", \"drilling service\".")]
		[XmlElement("serviceCategory")]
        public String ServiceCategory {
            get {
                return serviceCategoryField;
            } 
            set {
                serviceCategoryField = value;
                NotifyPropertyChanged("ServiceCategory");
            }
        }

        private String serviceCategoryField; 

        /// <summary>
        /// Comments and remarks. 
        /// </summary>
		[StringLength(4000)]
		[Description("Comments and remarks.")]
		[XmlElement("comments")]
        public String Comments {
            get {
                return commentsField;
            } 
            set {
                commentsField = value;
                NotifyPropertyChanged("Comments");
            }
        }

        private String commentsField; 

        /// <summary>
        /// The local time zone of the original acquisition date-time values. It is the deviation in hours and minutes from UTC. The first occurrence should be the actual local time zone at the start of acquisition and may represent a seasonally adjusted value such as daylight savings. The dTim attribute must be populated in the second and subsequent occurrences if the local time zone changes during acquisition. This knowledge is required because the original time zone in a dateTime value may be lost when software converts to a different time zone.
        /// </summary>
		[Description("The local time zone of the original acquisition date-time values.  It is the deviation in hours and minutes from UTC. The first occurrence should be the actual local time zone at the start of acquisition and may represent a seasonally adjusted value such as daylight savings. The dTim attribute must be populated in the second and subsequent occurrences  if the local time zone changes during acquisition. This knowledge is required because the original time zone in a dateTime value may be lost when software converts to a different time zone.")]
		[RecurringElement]
		[XmlElement("acquisitionTimeZone")]
        public List<TimestampedTimeZone> AcquisitionTimeZone {
            get {
                return acquisitionTimeZoneField;
            } 
            set {
                acquisitionTimeZoneField = value;
                NotifyPropertyChanged("AcquisitionTimeZone");
            }
        }

        private List<TimestampedTimeZone> acquisitionTimeZoneField; 

        /// <summary>
        /// A pointer to the default wellDatum for measured depth coordinates, vertical depth coordinates and elevation coordinates in this object. Depth coordinates that do not specify a datum attribute shall be assumed to be measured relative to this default vertical datum. The referenced wellDatum must be defined within the well object associated with this object.
        /// </summary>
		[Description("A pointer to the default wellDatum for measured depth coordinates, vertical depth coordinates and elevation coordinates in this object.  Depth coordinates that do not specify a datum attribute shall be  assumed to be measured relative to this default vertical datum. The referenced wellDatum must be defined within the well object associated with this object.")]
		[ComponentElement]
		[XmlElement("defaultDatum")]
        public RefNameString DefaultDatum {
            get {
                return defaultDatumField;
            } 
            set {
                defaultDatumField = value;
                NotifyPropertyChanged("DefaultDatum");
            }
        }

        private RefNameString defaultDatumField; 

        /// <summary>
        /// This is an API query parameter. See the API specification for the behavior related to this element.
        /// </summary>
		[Description("This is an API query parameter. See the API specification for the behavior related to this element.")]
		[XmlElement("privateGroupOnly")]
        public Boolean? PrivateGroupOnly {
            get {
                return privateGroupOnlyField;
            } 
            set {
                privateGroupOnlyField = value;
                this.PrivateGroupOnlySpecified = true;
                NotifyPropertyChanged("PrivateGroupOnly");
            }
        }

        private Boolean? privateGroupOnlyField; 

		/// <summary>
        /// privateGroupOnlySpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PrivateGroupOnlySpecified {
            get {
                return privateGroupOnlySpecifiedField;
            } 
            set {
                privateGroupOnlySpecifiedField = value;
                NotifyPropertyChanged("PrivateGroupOnlySpecified");
            }
        }

        private Boolean privateGroupOnlySpecifiedField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// This class represents the timestampedTimeZone xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="timestampedTimeZone", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the timestampedTimeZone xsd type.")]
    public partial class TimestampedTimeZone : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the TimestampedTimeZone class.
        /// </summary>
        public TimestampedTimeZone() {}

        /// <summary>
        /// Initializes a new instance of the TimestampedTimeZone class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public TimestampedTimeZone(String value)
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
        /// The date and time when this local time zone became active. This value must be defined on the second and subsequent occurrences.
        /// </summary>
		[Description("The date and time when this local time zone became active. This value must be defined on the second and subsequent occurrences.")]
        [XmlAttribute("dTim")]
		
        public DateTime DateTime {
            get {
                return dTimField;
            } 
            set {
                dTimField = value;
                this.DateTimeSpecified = true;
                NotifyPropertyChanged("DateTime");
            }
        }

        private DateTime dTimField; 

		/// <summary>
        /// dTimSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified {
            get {
                return dTimSpecifiedField;
            } 
            set {
                dTimSpecifiedField = value;
                NotifyPropertyChanged("DateTimeSpecified");
            }
        }

        private Boolean dTimSpecifiedField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public String Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private String ValueField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="refNameString", Namespace="http://www.witsml.org/schemas/1series")]
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
        public RefNameString(String value)
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
		[Description("A reference to the unique identifier (uid attribute) in the node referenced by the name value.  This attribute is required within the context of a WITSML server.")]
        [XmlAttribute("uidRef")]
		
        public String UidRef {
            get {
                return uidRefField;
            } 
            set {
                uidRefField = value;
                NotifyPropertyChanged("UidRef");
            }
        }

        private String uidRefField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public String Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private String ValueField; 


        
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
    /// WITSML - Extension Schema. The intent is to allow standard WITSML schema extensions which will validate in older clients or servers. A client or server can ignore any schema that it does not recognize. New versions will modify specific elements to replace this type with a type that adds new elements, including another element with this type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_extensionAny", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("WITSML - Extension Schema. The intent is to allow standard WITSML schema extensions which will validate in older clients or servers. A client or server can ignore any schema that it does not recognize. New versions will modify specific elements to replace this type with a type that adds new elements, including another element with this type.")]
    public partial class ExtensionAny : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Any property
        /// </summary>
		[RecurringElement]
		[XmlElement("Any")]
        public List<XmlElement> Any {
            get {
                return AnyField;
            } 
            set {
                AnyField = value;
                NotifyPropertyChanged("Any");
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
    /// WITSML - Extension values Schema. The intent is to allow standard WITSML "named" extensions without having to modify the schema. A client or server can ignore any name that it does not recognize but certain meta data is required in order to allow generic clients or servers to process the value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_extensionNameValue", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("WITSML - Extension values Schema. The intent is to allow standard WITSML named extensions without having to modify the schema. A client or server can ignore any name that it does not recognize but certain meta data is required in order to allow generic clients or servers to process the value.")]
    public partial class ExtensionNameValue : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The name of the extension. Each standard name should document the expected measure class. Each standard name should document the expected maximum size. For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the WITSML SIG Technical Team before use.
        /// </summary>
		[Required]
		[Description("The name of the extension. Each standard name should document the expected measure class. Each standard name should document the expected maximum size.  For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the  WITSML SIG Technical Team before use.")]
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
		[XmlElement("dataType")]
        public PrimitiveType? DataType {
            get {
                return dataTypeField;
            } 
            set {
                dataTypeField = value;
                NotifyPropertyChanged("DataType");
            }
        }

        private PrimitiveType? dataTypeField; 

        /// <summary>
        /// The date-time associated with the value.
        /// </summary>
		[Description("The date-time associated with the value.")]
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
        public Boolean DateTimeSpecified {
            get {
                return dTimSpecifiedField;
            } 
            set {
                dTimSpecifiedField = value;
                NotifyPropertyChanged("DateTimeSpecified");
            }
        }

        private Boolean dTimSpecifiedField; 

        /// <summary>
        /// The measured depth associated with the value.
        /// </summary>
		[Description("The measured depth associated with the value.")]
		[ComponentElement]
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
		[XmlElement("index")]
        public Int16? Index {
            get {
                return indexField;
            } 
            set {
                indexField = value;
                this.IndexSpecified = true;
                NotifyPropertyChanged("Index");
            }
        }

        private Int16? indexField; 

		/// <summary>
        /// indexSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IndexSpecified {
            get {
                return indexSpecifiedField;
            } 
            set {
                indexSpecifiedField = value;
                NotifyPropertyChanged("IndexSpecified");
            }
        }

        private Boolean indexSpecifiedField; 

        /// <summary>
        /// The kind of the measure. For example, "length". This should be specified if the value requires a unit of measure.
        /// </summary>
		[Description("The kind of the measure. For example, \"length\". This should be specified if the value requires a unit of measure.")]
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
        public Boolean MeasureClassSpecified {
            get {
                return measureClassSpecifiedField;
            } 
            set {
                measureClassSpecifiedField = value;
                NotifyPropertyChanged("MeasureClassSpecified");
            }
        }

        private Boolean measureClassSpecifiedField; 

        /// <summary>
        /// A textual description of the extension.
        /// </summary>
		[StringLength(256)]
		[Description("A textual description of the extension.")]
		[XmlElement("description")]
        public String Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private String descriptionField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="extensionvalue", Namespace="http://www.witsml.org/schemas/1series")]
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
        public Extensionvalue(String value, String uom)
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
		[Description("The unit of measure for the value. This value must conform to the values allowed by a measure class.")]
        [XmlAttribute("uom")]
		
        public String Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private String uomField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public String Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private String ValueField; 


        
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
    /// This class represents the cs_customData xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_customData", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_customData xsd type.")]
    public partial class CustomData : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Any property
        /// </summary>
		[RecurringElement]
		[XmlElement("Any")]
        public List<XmlElement> Any {
            get {
                return AnyField;
            } 
            set {
                AnyField = value;
                NotifyPropertyChanged("Any");
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
    /// This class represents the indexedObject xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="indexedObject", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the indexedObject xsd type.")]
    public partial class IndexedObject : Object, IDataObject, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the IndexedObject class.
        /// </summary>
        public IndexedObject() {}

        /// <summary>
        /// Initializes a new instance of the IndexedObject class.
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="uom">Initial unit of measure</param>
        public IndexedObject(String value, String uom)
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
        /// index property
        /// </summary>
		[Description("Indexes things with the same name.  That is the first one, the second one, etc.")]
        [XmlAttribute("index")]
		
        public Int16 Index {
            get {
                return indexField;
            } 
            set {
                indexField = value;
                NotifyPropertyChanged("Index");
            }
        }

        private Int16 indexField; 

		/// <summary>
        /// name property
        /// </summary>
		
        [XmlAttribute("name")]
		
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

		/// <summary>
        /// uom property
        /// </summary>
		
        [XmlAttribute("uom")]
		
        public String Uom {
            get {
                return uomField;
            } 
            set {
                uomField = value;
                NotifyPropertyChanged("Uom");
            }
        }

        private String uomField; 

		/// <summary>
        /// description property
        /// </summary>
		
        [XmlAttribute("description")]
		
        public String Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private String descriptionField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public String Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private String ValueField; 


        
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
    /// This class represents the refObjectString xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="refObjectString", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the refObjectString xsd type.")]
    public partial class RefObjectString : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the RefObjectString class.
        /// </summary>
        public RefObjectString() {}

        /// <summary>
        /// Initializes a new instance of the RefObjectString class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public RefObjectString(String value)
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
        /// The type of data-object being referenced (e.g., "well", "wellbore").
        /// </summary>
		[Description("The type of data-object being referenced (e.g., \"well\", \"wellbore\").")]
        [XmlAttribute("object")]
		
        public String Object {
            get {
                return objectField;
            } 
            set {
                objectField = value;
                NotifyPropertyChanged("Object");
            }
        }

        private String objectField; 

		/// <summary>
        /// A reference to the unique identifier (uid attribute) in the object referenced by the name value. This attribute is required within the context of a WITSML server.
        /// </summary>
		[Description("A reference to the unique identifier (uid attribute) in the object referenced by the name value.  This attribute is required within the context of a WITSML server.")]
        [XmlAttribute("uidRef")]
		
        public String UidRef {
            get {
                return uidRefField;
            } 
            set {
                uidRefField = value;
                NotifyPropertyChanged("UidRef");
            }
        }

        private String uidRefField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public String Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private String ValueField; 


        
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
    /// Defines a member of an objectGroup.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_memberObject", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Defines a member of an objectGroup.")]
    public partial class MemberObject : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A reference to an object that is defined within the context of the specified wellbore.
        /// </summary>
		[Required]
		[Description("A reference to an object that is defined within the  context of the specified wellbore.")]
		[ComponentElement]
		[XmlElement("objectReference")]
        public RefObjectString ObjectReference {
            get {
                return objectReferenceField;
            } 
            set {
                objectReferenceField = value;
                NotifyPropertyChanged("ObjectReference");
            }
        }

        private RefObjectString objectReferenceField; 

        /// <summary>
        /// For a log object, this specifies the kind of the index curve for the log. This is only relevant for a systematically growing object.
        /// </summary>
		[Description("For a log object, this specifies the kind of the index curve for the log. This is only relevant for a systematically growing object.")]
		[XmlElement("indexType")]
        public LogIndexType? IndexType {
            get {
                return indexTypeField;
            } 
            set {
                indexTypeField = value;
                this.IndexTypeSpecified = true;
                NotifyPropertyChanged("IndexType");
            }
        }

        private LogIndexType? indexTypeField; 

		/// <summary>
        /// indexTypeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IndexTypeSpecified {
            get {
                return indexTypeSpecifiedField;
            } 
            set {
                indexTypeSpecifiedField = value;
                NotifyPropertyChanged("IndexTypeSpecified");
            }
        }

        private Boolean indexTypeSpecifiedField; 

        /// <summary>
        /// Defines primary numeric ordering of this object within the group. The meaning of this order will be defined by the groupType.
        /// </summary>
		[Required]
		[Description("Defines primary numeric ordering of this object within the group. The meaning of this order will be defined by the groupType.")]
		[ComponentElement]
		[XmlElement("sequence1")]
        public ObjectSequence Sequence1 {
            get {
                return sequence1Field;
            } 
            set {
                sequence1Field = value;
                NotifyPropertyChanged("Sequence1");
            }
        }

        private ObjectSequence sequence1Field; 

        /// <summary>
        /// Defines secondary numeric ordering of this object within the group. The meaning of this order will be defined by the groupType. A value for sequence2 can only be given if a value is given for sequence1.
        /// </summary>
		[ComponentElement]
		[XmlElement("sequence2")]
        public ObjectSequence Sequence2 {
            get {
                return sequence2Field;
            } 
            set {
                sequence2Field = value;
                NotifyPropertyChanged("Sequence2");
            }
        }

        private ObjectSequence sequence2Field; 

        /// <summary>
        /// Defines tertiary numeric ordering of this object within the group. The meaning of this order will be defined by the groupType. A value for sequence3 can only be given if a value is given for sequence2.
        /// </summary>
		[ComponentElement]
		[XmlElement("sequence3")]
        public ObjectSequence Sequence3 {
            get {
                return sequence3Field;
            } 
            set {
                sequence3Field = value;
                NotifyPropertyChanged("Sequence3");
            }
        }

        private ObjectSequence sequence3Field; 

        /// <summary>
        /// The minimum growing-object index value that applies to this group. The significance of this range is defined by the groupType.
        /// </summary>
		[Description("The minimum growing-object index value that applies to this group. The significance of this range is defined by the groupType.")]
		[ComponentElement]
		[XmlElement("rangeMin")]
        public GenericMeasure RangeMin {
            get {
                return rangeMinField;
            } 
            set {
                rangeMinField = value;
                NotifyPropertyChanged("RangeMin");
            }
        }

        private GenericMeasure rangeMinField; 

        /// <summary>
        /// The maximum growing-object index value that applies to this group. The significance of this range is defined by the groupType.
        /// </summary>
		[Description("The maximum growing-object index value that applies to this group. The significance of this range is defined by the groupType.")]
		[ComponentElement]
		[XmlElement("rangeMax")]
        public GenericMeasure RangeMax {
            get {
                return rangeMaxField;
            } 
            set {
                rangeMaxField = value;
                NotifyPropertyChanged("RangeMax");
            }
        }

        private GenericMeasure rangeMaxField; 

        /// <summary>
        /// The minimum log date-time index value that applies to this group. The significance of this range is defined by the groupType.
        /// </summary>
		[Description("The minimum log date-time index value that applies to this group. The significance of this range is defined by the groupType.")]
		[XmlElement("rangeDateTimeMin")]
        public Timestamp? RangeDateTimeMin {
            get {
                return rangeDateTimeMinField;
            } 
            set {
                rangeDateTimeMinField = value;
                this.RangeDateTimeMinSpecified = true;
                NotifyPropertyChanged("RangeDateTimeMin");
            }
        }

        private Timestamp? rangeDateTimeMinField; 

		/// <summary>
        /// rangeDateTimeMinSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean RangeDateTimeMinSpecified {
            get {
                return rangeDateTimeMinSpecifiedField;
            } 
            set {
                rangeDateTimeMinSpecifiedField = value;
                NotifyPropertyChanged("RangeDateTimeMinSpecified");
            }
        }

        private Boolean rangeDateTimeMinSpecifiedField; 

        /// <summary>
        /// The maximum log date-time index value that applies to this group. The significance of this range is defined by the groupType.
        /// </summary>
		[Description("The maximum log date-time index value that applies to this group. The significance of this range is defined by the groupType.")]
		[XmlElement("rangeDateTimeMax")]
        public Timestamp? RangeDateTimeMax {
            get {
                return rangeDateTimeMaxField;
            } 
            set {
                rangeDateTimeMaxField = value;
                this.RangeDateTimeMaxSpecified = true;
                NotifyPropertyChanged("RangeDateTimeMax");
            }
        }

        private Timestamp? rangeDateTimeMaxField; 

		/// <summary>
        /// rangeDateTimeMaxSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean RangeDateTimeMaxSpecified {
            get {
                return rangeDateTimeMaxSpecifiedField;
            } 
            set {
                rangeDateTimeMaxSpecifiedField = value;
                NotifyPropertyChanged("RangeDateTimeMaxSpecified");
            }
        }

        private Boolean rangeDateTimeMaxSpecifiedField; 

        /// <summary>
        /// A comma delimited list of log curve mnemonics. Each mnemonic should only occur once in the list. If not specified then the group applies to all curves in the log.
        /// </summary>
		[Description("A comma delimited list of log curve mnemonics. Each mnemonic should only occur once in the list. If not specified then the group applies to all curves in the log.")]
		[XmlElement("mnemonicList")]
        public String MnemonicList {
            get {
                return mnemonicListField;
            } 
            set {
                mnemonicListField = value;
                NotifyPropertyChanged("MnemonicList");
            }
        }

        private String mnemonicListField; 

        /// <summary>
        /// A measured depth related to this group. This does not necessarily represent an actual depth within a growing-object. The significance of this depth is defined by the groupType.
        /// </summary>
		[Description("A measured depth related to this group.  This does not necessarily represent an actual depth within a growing-object. The significance of this depth is defined by the groupType.")]
		[ComponentElement]
		[XmlElement("referenceDepth")]
        public MeasuredDepthCoord ReferenceDepth {
            get {
                return referenceDepthField;
            } 
            set {
                referenceDepthField = value;
                NotifyPropertyChanged("ReferenceDepth");
            }
        }

        private MeasuredDepthCoord referenceDepthField; 

        /// <summary>
        /// A date and time related to this group. This does not necessarily represent an actual index within a growing-object. The significance of this time is defined by the groupType.
        /// </summary>
		[Description("A date and time related to this group.  This does not necessarily represent an actual index within a growing-object. The significance of this time is defined by the groupType.")]
		[XmlElement("referenceDateTime")]
        public Timestamp? ReferenceDateTime {
            get {
                return referenceDateTimeField;
            } 
            set {
                referenceDateTimeField = value;
                this.ReferenceDateTimeSpecified = true;
                NotifyPropertyChanged("ReferenceDateTime");
            }
        }

        private Timestamp? referenceDateTimeField; 

		/// <summary>
        /// referenceDateTimeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ReferenceDateTimeSpecified {
            get {
                return referenceDateTimeSpecifiedField;
            } 
            set {
                referenceDateTimeSpecifiedField = value;
                NotifyPropertyChanged("ReferenceDateTimeSpecified");
            }
        }

        private Boolean referenceDateTimeSpecifiedField; 

        /// <summary>
        /// Any extra parameter data related to the group. For this usage the name attribute MUST be specified because it represents the meaning of the data. While the index attribute is mandatory, it is only significant if the same name repeats.
        /// </summary>
		[Description("Any extra parameter data related to the group.  For this usage the name attribute MUST be specified because it represents the meaning of the data. While the index attribute is mandatory, it is only significant if the same name repeats.")]
		[RecurringElement]
		[XmlElement("param")]
        public List<IndexedObject> Param {
            get {
                return paramField;
            } 
            set {
                paramField = value;
                NotifyPropertyChanged("Param");
            }
        }

        private List<IndexedObject> paramField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the objectSequence xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="objectSequence", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the objectSequence xsd type.")]
    public partial class ObjectSequence : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ObjectSequence class.
        /// </summary>
        public ObjectSequence() {}

        /// <summary>
        /// Initializes a new instance of the ObjectSequence class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public ObjectSequence(Int16 value)
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
        /// A description related to the sequence number.
        /// </summary>
		[Description("A description related to the sequence number.")]
        [XmlAttribute("description")]
		
        public String Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private String descriptionField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public Int16 Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private Int16 ValueField; 


        
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
    /// Information on WITSML objects used
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_participant", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on WITSML objects used")]
    public partial class Participant : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// A collection of involved participants.
        /// </summary>
		[Description("A collection of involved participants.")]
		[RecurringElement]
		[XmlElement("participant")]
        public List<MemberObject> Participants {
            get {
                return participantField;
            } 
            set {
                participantField = value;
                NotifyPropertyChanged("Participants");
            }
        }

        private List<MemberObject> participantField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
		[XmlElement("extNameValues")]
        public List<ExtensionNameValue> ExtNameValues {
            get {
                return extNameValuesField;
            } 
            set {
                extNameValuesField = value;
                NotifyPropertyChanged("ExtNameValues");
            }
        }

        private List<ExtensionNameValue> extNameValuesField; 


        
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
    /// WITSML - Equipment NameTag Schema
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_nameTag", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("WITSML - Equipment NameTag Schema")]
    public partial class NameTag : Object, IDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// The physical identification string of the equipment tag.
        /// </summary>
		[Required]
		[StringLength(40)]
		[Description("The physical identification string of the equipment tag.")]
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// The format or encoding specification of the equipment tag. The tag may contain may different pieces of information and knowledge of that information is inherent in the specification. The "identification string" is a mandatory part of the information in a tag.
        /// </summary>
		[Required]
		[Description("The format or encoding specification of the equipment tag.  The tag may contain may different pieces of information and knowledge of that  information is inherent in the specification.  The \"identification string\" is a mandatory part of the information in a tag.")]
		[XmlElement("numberingScheme")]
        public NameTagNumberingScheme NumberingScheme {
            get {
                return numberingSchemeField;
            } 
            set {
                numberingSchemeField = value;
                NotifyPropertyChanged("NumberingScheme");
            }
        }

        private NameTagNumberingScheme numberingSchemeField; 

        /// <summary>
        /// Identifies the general type of identifier on an item. If multiple identifiers exist on an item, a separate description set for each identifier should be created. For example, a joint of casing may have a barcode label on it along with a painted-on code and an RFID tag attached or embedded into the coupling. The barcode label may in turn be an RFID equipped label. This particular scenario would require populating five nameTags to fully describe and decode all the possible identifiers as follows: 'tagged' - RFID tag embedded in the coupling, 'label' - Serial number printed on the label, 'tagged' - RFID tag embedded into the label, 'label' - Barcode printed on the label, 'painted'- Mill number painted on the pipe body.
        /// </summary>
		[Description("Identifies the general type of identifier on an item.  If multiple identifiers exist on an item, a separate description set for each identifier should be created.   For example, a joint of casing may have a barcode label on it along with a painted-on code and an RFID tag attached or embedded into the coupling.  The barcode label may in turn be an RFID equipped label. This particular scenario would require populating five nameTags to fully describe and decode all the possible identifiers as follows: 'tagged' - RFID tag embedded in the coupling, 'label'  - Serial number printed on the label, 'tagged' - RFID tag embedded into the label, 'label'  - Barcode printed on the label, 'painted'- Mill number painted on the pipe body.")]
		[XmlElement("technology")]
        public NameTagTechnology Technology {
            get {
                return technologyField;
            } 
            set {
                technologyField = value;
                this.TechnologySpecified = true;
                NotifyPropertyChanged("Technology");
            }
        }

        private NameTagTechnology technologyField; 

		/// <summary>
        /// technologySpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TechnologySpecified {
            get {
                return technologySpecifiedField;
            } 
            set {
                technologySpecifiedField = value;
                NotifyPropertyChanged("TechnologySpecified");
            }
        }

        private Boolean technologySpecifiedField; 

        /// <summary>
        /// An indicator of where the tag is attached to the item. This is used to assist the user in finding where an identifier is located on an item. This optional field also helps to differentiate where an identifier is located when multiple identifiers exist on an item. Most downhole components have a box (female thread) and pin (male thread) end as well as a pipe body in between the ends. Where multiple identifiers are used on an item, it is convenient to have a reference as to which end, or somewhere in the middle, an identifier may be closer to. Some items may have an identifier on a non-standard location, such as on the arm of a hole opener. 'other', by exclusion, tells a user to look elsewhere than on the body or near the ends of an item. Most non-downhole tools will use either 'body', 'other' or not specified as the location tends to lose value with smaller or non threaded items.
        /// </summary>
		[Description("An indicator of where the tag is attached to the item. This is used to assist the user in finding where an identifier is located on an item.  This optional field also helps to differentiate where an identifier is located when multiple identifiers exist on an item. Most downhole components have a box (female thread) and pin (male thread) end as well as a pipe body in between the ends. Where multiple identifiers are used on an item, it is convenient to have a reference as to which end, or somewhere in the middle, an identifier may be closer to. Some items may have an identifier on a non-standard location, such as on the arm of a hole opener.  'other', by exclusion, tells a user to look elsewhere than on the body or near the ends of an item.  Most non-downhole tools will use either 'body', 'other' or not specified as the location tends to lose value with smaller or non threaded items.")]
		[XmlElement("location")]
        public NameTagLocation Location {
            get {
                return locationField;
            } 
            set {
                locationField = value;
                this.LocationSpecified = true;
                NotifyPropertyChanged("Location");
            }
        }

        private NameTagLocation locationField; 

		/// <summary>
        /// locationSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean LocationSpecified {
            get {
                return locationSpecifiedField;
            } 
            set {
                locationSpecifiedField = value;
                NotifyPropertyChanged("LocationSpecified");
            }
        }

        private Boolean locationSpecifiedField; 

        /// <summary>
        /// When the tag was installed in or on the item. 
        /// </summary>
		[Description("When the tag was installed in or on the item.")]
		[XmlElement("installationDate")]
        public Timestamp? InstallationDate {
            get {
                return installationDateField;
            } 
            set {
                installationDateField = value;
                this.InstallationDateSpecified = true;
                NotifyPropertyChanged("InstallationDate");
            }
        }

        private Timestamp? installationDateField; 

		/// <summary>
        /// installationDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean InstallationDateSpecified {
            get {
                return installationDateSpecifiedField;
            } 
            set {
                installationDateSpecifiedField = value;
                NotifyPropertyChanged("InstallationDateSpecified");
            }
        }

        private Boolean installationDateSpecifiedField; 

        /// <summary>
        /// The name of the company that installed the tag. 
        /// </summary>
		[StringLength(64)]
		[Description("The name of the company that installed the tag.")]
		[XmlElement("installationCompany")]
        public String InstallationCompany {
            get {
                return installationCompanyField;
            } 
            set {
                installationCompanyField = value;
                NotifyPropertyChanged("InstallationCompany");
            }
        }

        private String installationCompanyField; 

        /// <summary>
        /// Reference to a manufacturers or installers installation description, code, or method. 
        /// </summary>
		[StringLength(40)]
		[Description("Reference to a manufacturers or installers installation  description, code, or method.")]
		[XmlElement("mountingCode")]
        public String MountingCode {
            get {
                return mountingCodeField;
            } 
            set {
                mountingCodeField = value;
                NotifyPropertyChanged("MountingCode");
            }
        }

        private String mountingCodeField; 

        /// <summary>
        /// A comment or remark about the tag.
        /// </summary>
		[StringLength(4000)]
		[Description("A comment or remark about the tag.")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cost xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cost", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cost xsd type.")]
    public partial class Cost : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the Cost class.
        /// </summary>
        public Cost() {}

        /// <summary>
        /// Initializes a new instance of the Cost class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public Cost(Double value)
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
        /// currency property
        /// </summary>
		
        [XmlAttribute("currency")]
		
        public String Currency {
            get {
                return currencyField;
            } 
            set {
                currencyField = value;
                NotifyPropertyChanged("Currency");
            }
        }

        private String currencyField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public Double Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private Double ValueField; 


        
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
    ///  WITSML - Day Cost Component Schema 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dayCost", Namespace="http://www.witsml.org/schemas/1series")]
    [Description(" WITSML - Day Cost Component Schema ")]
    public partial class DayCost : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AFE number that this cost item applies to. 
        /// </summary>
		[StringLength(32)]
		[Description("AFE number that this cost item applies to.")]
		[XmlElement("numAFE")]
        public String NumAFE {
            get {
                return numAFEField;
            } 
            set {
                numAFEField = value;
                NotifyPropertyChanged("NumAFE");
            }
        }

        private String numAFEField; 

        /// <summary>
        /// Cost group code. 
        /// </summary>
		[StringLength(16)]
		[Description("Cost group code.")]
		[XmlElement("costGroup")]
        public String CostGroup {
            get {
                return costGroupField;
            } 
            set {
                costGroupField = value;
                NotifyPropertyChanged("CostGroup");
            }
        }

        private String costGroupField; 

        /// <summary>
        /// Cost class code. 
        /// </summary>
		[Required]
		[StringLength(16)]
		[Description("Cost class code.")]
		[XmlElement("costClass")]
        public String CostClass {
            get {
                return costClassField;
            } 
            set {
                costClassField = value;
                NotifyPropertyChanged("CostClass");
            }
        }

        private String costClassField; 

        /// <summary>
        /// Cost code. 
        /// </summary>
		[Required]
		[StringLength(16)]
		[Description("Cost code.")]
		[XmlElement("costCode")]
        public String CostCode {
            get {
                return costCodeField;
            } 
            set {
                costCodeField = value;
                NotifyPropertyChanged("CostCode");
            }
        }

        private String costCodeField; 

        /// <summary>
        /// Cost subcode. 
        /// </summary>
		[StringLength(16)]
		[Description("Cost subcode.")]
		[XmlElement("costSubCode")]
        public String CostSubCode {
            get {
                return costSubCodeField;
            } 
            set {
                costSubCodeField = value;
                NotifyPropertyChanged("CostSubCode");
            }
        }

        private String costSubCodeField; 

        /// <summary>
        /// Description of cost item. 
        /// </summary>
		[StringLength(64)]
		[Description("Description of cost item.")]
		[XmlElement("costItemDescription")]
        public String CostItemDescription {
            get {
                return costItemDescriptionField;
            } 
            set {
                costItemDescriptionField = value;
                NotifyPropertyChanged("CostItemDescription");
            }
        }

        private String costItemDescriptionField; 

        /// <summary>
        /// Cost per cost item, assume same currency.
        /// </summary>
		[Description("Cost per cost item, assume same currency.")]
		[ComponentElement]
		[XmlElement("costPerItem")]
        public Cost CostPerItem {
            get {
                return costPerItemField;
            } 
            set {
                costPerItemField = value;
                NotifyPropertyChanged("CostPerItem");
            }
        }

        private Cost costPerItemField; 

        /// <summary>
        /// The kind of cost item specified (e.g., rig dayrate, joints casing). 
        /// </summary>
		[StringLength(24)]
		[Description("The kind of cost item specified (e.g., rig dayrate, joints casing).")]
		[XmlElement("itemKind")]
        public String ItemKind {
            get {
                return itemKindField;
            } 
            set {
                itemKindField = value;
                NotifyPropertyChanged("ItemKind");
            }
        }

        private String itemKindField; 

        /// <summary>
        /// Size of one cost item. 
        /// </summary>
		[Description("Size of one cost item.")]
		[XmlElement("itemSize")]
        public Double? ItemSize {
            get {
                return itemSizeField;
            } 
            set {
                itemSizeField = value;
                this.ItemSizeSpecified = true;
                NotifyPropertyChanged("ItemSize");
            }
        }

        private Double? itemSizeField; 

		/// <summary>
        /// itemSizeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ItemSizeSpecified {
            get {
                return itemSizeSpecifiedField;
            } 
            set {
                itemSizeSpecifiedField = value;
                NotifyPropertyChanged("ItemSizeSpecified");
            }
        }

        private Boolean itemSizeSpecifiedField; 

        /// <summary>
        /// Number of cost items used that day e.g. 1 rig dayrate, 30 joints casing. 
        /// </summary>
		[Description("Number of cost items used that day e.g. 1 rig dayrate, 30 joints casing.")]
		[XmlElement("qtyItem")]
        public Int16? QtyItem {
            get {
                return qtyItemField;
            } 
            set {
                qtyItemField = value;
                this.QtyItemSpecified = true;
                NotifyPropertyChanged("QtyItem");
            }
        }

        private Int16? qtyItemField; 

		/// <summary>
        /// qtyItemSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean QtyItemSpecified {
            get {
                return qtyItemSpecifiedField;
            } 
            set {
                qtyItemSpecifiedField = value;
                NotifyPropertyChanged("QtyItemSpecified");
            }
        }

        private Boolean qtyItemSpecifiedField; 

        /// <summary>
        /// Cost for the item for this record. 
        /// </summary>
		[Required]
		[Description("Cost for the item for this record.")]
		[ComponentElement]
		[XmlElement("costAmount")]
        public Cost CostAmount {
            get {
                return costAmountField;
            } 
            set {
                costAmountField = value;
                NotifyPropertyChanged("CostAmount");
            }
        }

        private Cost costAmountField; 

        /// <summary>
        /// Invoice number for cost item, bill sent to Operator. 
        /// </summary>
		[StringLength(32)]
		[Description("Invoice number for cost item, bill sent to Operator.")]
		[XmlElement("numInvoice")]
        public String NumInvoice {
            get {
                return numInvoiceField;
            } 
            set {
                numInvoiceField = value;
                NotifyPropertyChanged("NumInvoice");
            }
        }

        private String numInvoiceField; 

        /// <summary>
        /// Purchase order number, provided by Operator. 
        /// </summary>
		[StringLength(32)]
		[Description("Purchase order number, provided by Operator.")]
		[XmlElement("numPO")]
        public String NumPO {
            get {
                return numPOField;
            } 
            set {
                numPOField = value;
                NotifyPropertyChanged("NumPO");
            }
        }

        private String numPOField; 

        /// <summary>
        /// Field Ticket number, issued by service company on location. 
        /// </summary>
		[StringLength(32)]
		[Description("Field Ticket number, issued by service company on location.")]
		[XmlElement("numTicket")]
        public String NumTicket {
            get {
                return numTicketField;
            } 
            set {
                numTicketField = value;
                NotifyPropertyChanged("NumTicket");
            }
        }

        private String numTicketField; 

        /// <summary>
        /// Is this item carried from day to day? Values are "true" (or "1") and "false" (or "0").
        /// </summary>
		[Description("Is this item carried from day to day? Values are \"true\" (or \"1\") and \"false\" (or \"0\").")]
		[XmlElement("isCarryOver")]
        public Boolean? IsCarryOver {
            get {
                return isCarryOverField;
            } 
            set {
                isCarryOverField = value;
                this.IsCarryOverSpecified = true;
                NotifyPropertyChanged("IsCarryOver");
            }
        }

        private Boolean? isCarryOverField; 

		/// <summary>
        /// isCarryOverSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsCarryOverSpecified {
            get {
                return isCarryOverSpecifiedField;
            } 
            set {
                isCarryOverSpecifiedField = value;
                NotifyPropertyChanged("IsCarryOverSpecified");
            }
        }

        private Boolean isCarryOverSpecifiedField; 

        /// <summary>
        /// Is this item a rental? Values are "true" (or "1") and "false" (or "0").
        /// </summary>
		[Description("Is this item a rental? Values are \"true\" (or \"1\") and \"false\" (or \"0\").")]
		[XmlElement("isRental")]
        public Boolean? IsRental {
            get {
                return isRentalField;
            } 
            set {
                isRentalField = value;
                this.IsRentalSpecified = true;
                NotifyPropertyChanged("IsRental");
            }
        }

        private Boolean? isRentalField; 

		/// <summary>
        /// isRentalSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsRentalSpecified {
            get {
                return isRentalSpecifiedField;
            } 
            set {
                isRentalSpecifiedField = value;
                NotifyPropertyChanged("IsRentalSpecified");
            }
        }

        private Boolean isRentalSpecifiedField; 

        /// <summary>
        /// An identification tag for the item. A serial number is a type of identification tag however some tags contain many pieces of information. This structure just identifies the tag and does not describe the contents.
        /// </summary>
		[Description("An identification tag for the item. A serial number is a type of identification tag however some tags contain many pieces of information. This structure just identifies the tag and does not describe the contents.")]
		[RecurringElement]
		[XmlElement("nameTag")]
        public List<NameTag> NameTag {
            get {
                return nameTagField;
            } 
            set {
                nameTagField = value;
                NotifyPropertyChanged("NameTag");
            }
        }

        private List<NameTag> nameTagField; 

        /// <summary>
        /// Serial number. 
        /// </summary>
		[StringLength(32)]
		[Description("Serial number.")]
		[XmlElement("numSerial")]
        public String NumSerial {
            get {
                return numSerialField;
            } 
            set {
                numSerialField = value;
                NotifyPropertyChanged("NumSerial");
            }
        }

        private String numSerialField; 

        /// <summary>
        /// Name of vendor. 
        /// </summary>
		[StringLength(32)]
		[Description("Name of vendor.")]
		[XmlElement("nameVendor")]
        public String NameVendor {
            get {
                return nameVendorField;
            } 
            set {
                nameVendorField = value;
                NotifyPropertyChanged("NameVendor");
            }
        }

        private String nameVendorField; 

        /// <summary>
        /// Vendor number. 
        /// </summary>
		[StringLength(16)]
		[Description("Vendor number.")]
		[XmlElement("numVendor")]
        public String NumVendor {
            get {
                return numVendorField;
            } 
            set {
                numVendorField = value;
                NotifyPropertyChanged("NumVendor");
            }
        }

        private String numVendorField; 

        /// <summary>
        /// Name of pool/reservoir that this cost item can be accounted to. 
        /// </summary>
		[StringLength(64)]
		[Description("Name of pool/reservoir that this cost item can be accounted to.")]
		[XmlElement("pool")]
        public String Pool {
            get {
                return poolField;
            } 
            set {
                poolField = value;
                NotifyPropertyChanged("Pool");
            }
        }

        private String poolField; 

        /// <summary>
        /// Is this an estimated cost? Values are "true" (or "1") and "false" (or "0").
        /// </summary>
		[Description("Is this an estimated cost? Values are \"true\" (or \"1\") and \"false\" (or \"0\").")]
		[XmlElement("estimated")]
        public Boolean? Estimated {
            get {
                return estimatedField;
            } 
            set {
                estimatedField = value;
                this.EstimatedSpecified = true;
                NotifyPropertyChanged("Estimated");
            }
        }

        private Boolean? estimatedField; 

		/// <summary>
        /// estimatedSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EstimatedSpecified {
            get {
                return estimatedSpecifiedField;
            } 
            set {
                estimatedSpecifiedField = value;
                NotifyPropertyChanged("EstimatedSpecified");
            }
        }

        private Boolean estimatedSpecifiedField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// Information on downhole related to this event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_downholeExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on downhole related to this event.")]
    public partial class DownholeExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Reference to downhole component 
        /// </summary>
		
		[XmlElement("downholeComponentRefID")]
        public String DownholeComponentRefID {
            get {
                return downholeComponentRefIDField;
            } 
            set {
                downholeComponentRefIDField = value;
                NotifyPropertyChanged("DownholeComponentRefID");
            }
        }

        private String downholeComponentRefIDField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on fluid report event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidReportExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on fluid report event.")]
    public partial class FluidReportExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Reference to the fluid report
        /// </summary>
		
		[XmlElement("fluidReportRefID")]
        public String FluidReportRefID {
            get {
                return fluidReportRefIDField;
            } 
            set {
                fluidReportRefIDField = value;
                NotifyPropertyChanged("FluidReportRefID");
            }
        }

        private String fluidReportRefIDField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on the perforating job.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_perforating", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on the perforating job.")]
    public partial class Perforating : Object, INotifyPropertyChanged
    {

        /// <summary>
        ///  index number of stage
        /// </summary>
		
		[XmlElement("stageNumber")]
        public Int16? StageNumber {
            get {
                return stageNumberField;
            } 
            set {
                stageNumberField = value;
                this.StageNumberSpecified = true;
                NotifyPropertyChanged("StageNumber");
            }
        }

        private Int16? stageNumberField; 

		/// <summary>
        /// stageNumberSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StageNumberSpecified {
            get {
                return stageNumberSpecifiedField;
            } 
            set {
                stageNumberSpecifiedField = value;
                NotifyPropertyChanged("StageNumberSpecified");
            }
        }

        private Boolean stageNumberSpecifiedField; 

        /// <summary>
        /// Perf-Bottom of packer set depth 
        /// </summary>
		[ComponentElement]
		[XmlElement("bottomPackerSet")]
        public MeasuredDepthCoord BottomPackerSet {
            get {
                return bottomPackerSetField;
            } 
            set {
                bottomPackerSetField = value;
                NotifyPropertyChanged("BottomPackerSet");
            }
        }

        private MeasuredDepthCoord bottomPackerSetField; 

        /// <summary>
        /// Perforation fluid type
        /// </summary>
		
		[XmlElement("perforationFluidType")]
        public String PerforationFluidType {
            get {
                return perforationFluidTypeField;
            } 
            set {
                perforationFluidTypeField = value;
                NotifyPropertyChanged("PerforationFluidType");
            }
        }

        private String perforationFluidTypeField; 

        /// <summary>
        /// hydrostaticPressure
        /// </summary>
		[ComponentElement]
		[XmlElement("hydrostaticPressure")]
        public PressureMeasure HydrostaticPressure {
            get {
                return hydrostaticPressureField;
            } 
            set {
                hydrostaticPressureField = value;
                NotifyPropertyChanged("HydrostaticPressure");
            }
        }

        private PressureMeasure hydrostaticPressureField; 

        /// <summary>
        /// Surface pressure
        /// </summary>
		[ComponentElement]
		[XmlElement("surfacePressure")]
        public PressureMeasure SurfacePressure {
            get {
                return surfacePressureField;
            } 
            set {
                surfacePressureField = value;
                NotifyPropertyChanged("SurfacePressure");
            }
        }

        private PressureMeasure surfacePressureField; 

        /// <summary>
        /// Reservoir pressure
        /// </summary>
		[ComponentElement]
		[XmlElement("reservoirPressure")]
        public PressureMeasure ReservoirPressure {
            get {
                return reservoirPressureField;
            } 
            set {
                reservoirPressureField = value;
                NotifyPropertyChanged("ReservoirPressure");
            }
        }

        private PressureMeasure reservoirPressureField; 

        /// <summary>
        /// The density of fluid
        /// </summary>
		[ComponentElement]
		[XmlElement("fluidDensity")]
        public DensityMeasure FluidDensity {
            get {
                return fluidDensityField;
            } 
            set {
                fluidDensityField = value;
                NotifyPropertyChanged("FluidDensity");
            }
        }

        private DensityMeasure fluidDensityField; 

        /// <summary>
        /// Fluid level.
        /// </summary>
		[ComponentElement]
		[XmlElement("fluidLevel")]
        public MeasuredDepthCoord FluidLevel {
            get {
                return fluidLevelField;
            } 
            set {
                fluidLevelField = value;
                NotifyPropertyChanged("FluidLevel");
            }
        }

        private MeasuredDepthCoord fluidLevelField; 

        /// <summary>
        /// The conveyance method
        /// </summary>
		
		[XmlElement("conveyanceMethod")]
        public PerfConveyanceMethod? ConveyanceMethod {
            get {
                return conveyanceMethodField;
            } 
            set {
                conveyanceMethodField = value;
                this.ConveyanceMethodSpecified = true;
                NotifyPropertyChanged("ConveyanceMethod");
            }
        }

        private PerfConveyanceMethod? conveyanceMethodField; 

		/// <summary>
        /// conveyanceMethodSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ConveyanceMethodSpecified {
            get {
                return conveyanceMethodSpecifiedField;
            } 
            set {
                conveyanceMethodSpecifiedField = value;
                NotifyPropertyChanged("ConveyanceMethodSpecified");
            }
        }

        private Boolean conveyanceMethodSpecifiedField; 

        /// <summary>
        /// Number of shots planned
        /// </summary>
		
		[XmlElement("shotsPlanned")]
        public Int16? ShotsPlanned {
            get {
                return shotsPlannedField;
            } 
            set {
                shotsPlannedField = value;
                this.ShotsPlannedSpecified = true;
                NotifyPropertyChanged("ShotsPlanned");
            }
        }

        private Int16? shotsPlannedField; 

		/// <summary>
        /// shotsPlannedSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ShotsPlannedSpecified {
            get {
                return shotsPlannedSpecifiedField;
            } 
            set {
                shotsPlannedSpecifiedField = value;
                NotifyPropertyChanged("ShotsPlannedSpecified");
            }
        }

        private Boolean shotsPlannedSpecifiedField; 

        /// <summary>
        /// Number of shots per unit length (ft, m)
        /// </summary>
		[ComponentElement]
		[XmlElement("shotsDensity")]
        public PerLengthMeasure ShotsDensity {
            get {
                return shotsDensityField;
            } 
            set {
                shotsDensityField = value;
                NotifyPropertyChanged("ShotsDensity");
            }
        }

        private PerLengthMeasure shotsDensityField; 

        /// <summary>
        /// The number of missed firings from the gun.
        /// </summary>
		
		[XmlElement("shotsMisfired")]
        public Int16? ShotsMisfired {
            get {
                return shotsMisfiredField;
            } 
            set {
                shotsMisfiredField = value;
                this.ShotsMisfiredSpecified = true;
                NotifyPropertyChanged("ShotsMisfired");
            }
        }

        private Int16? shotsMisfiredField; 

		/// <summary>
        /// shotsMisfiredSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ShotsMisfiredSpecified {
            get {
                return shotsMisfiredSpecifiedField;
            } 
            set {
                shotsMisfiredSpecifiedField = value;
                NotifyPropertyChanged("ShotsMisfiredSpecified");
            }
        }

        private Boolean shotsMisfiredSpecifiedField; 

        /// <summary>
        /// orientaton
        /// </summary>
		
		[XmlElement("orientation")]
        public String Orientation {
            get {
                return orientationField;
            } 
            set {
                orientationField = value;
                NotifyPropertyChanged("Orientation");
            }
        }

        private String orientationField; 

        /// <summary>
        /// Description of orientaton method
        /// </summary>
		
		[XmlElement("orientationMethod")]
        public String OrientationMethod {
            get {
                return orientationMethodField;
            } 
            set {
                orientationMethodField = value;
                NotifyPropertyChanged("OrientationMethod");
            }
        }

        private String orientationMethodField; 

        /// <summary>
        /// The name of company providing the perforation.
        /// </summary>
		
		[XmlElement("perforationCompany")]
        public String PerforationCompany {
            get {
                return perforationCompanyField;
            } 
            set {
                perforationCompanyField = value;
                NotifyPropertyChanged("PerforationCompany");
            }
        }

        private String perforationCompanyField; 

        /// <summary>
        /// The manufacturer of the carrier.
        /// </summary>
		
		[XmlElement("carrierManufacturer")]
        public String CarrierManufacturer {
            get {
                return carrierManufacturerField;
            } 
            set {
                carrierManufacturerField = value;
                NotifyPropertyChanged("CarrierManufacturer");
            }
        }

        private String carrierManufacturerField; 

        /// <summary>
        /// Size of the carrier.
        /// </summary>
		[ComponentElement]
		[XmlElement("carrierSize")]
        public LengthMeasure CarrierSize {
            get {
                return carrierSizeField;
            } 
            set {
                carrierSizeField = value;
                NotifyPropertyChanged("CarrierSize");
            }
        }

        private LengthMeasure carrierSizeField; 

        /// <summary>
        /// Description from carrier
        /// </summary>
		
		[XmlElement("carrierDescription")]
        public String CarrierDescription {
            get {
                return carrierDescriptionField;
            } 
            set {
                carrierDescriptionField = value;
                NotifyPropertyChanged("CarrierDescription");
            }
        }

        private String carrierDescriptionField; 

        /// <summary>
        /// The manufacturer of the charge.
        /// </summary>
		
		[XmlElement("chargeManufacturer")]
        public String ChargeManufacturer {
            get {
                return chargeManufacturerField;
            } 
            set {
                chargeManufacturerField = value;
                NotifyPropertyChanged("ChargeManufacturer");
            }
        }

        private String chargeManufacturerField; 

        /// <summary>
        /// The size of the charge.
        /// </summary>
		[ComponentElement]
		[XmlElement("chargeSize")]
        public LengthMeasure ChargeSize {
            get {
                return chargeSizeField;
            } 
            set {
                chargeSizeField = value;
                NotifyPropertyChanged("ChargeSize");
            }
        }

        private LengthMeasure chargeSizeField; 

        /// <summary>
        /// The weight of the charge.
        /// </summary>
		[ComponentElement]
		[XmlElement("chargeWeight")]
        public MassMeasure ChargeWeight {
            get {
                return chargeWeightField;
            } 
            set {
                chargeWeightField = value;
                NotifyPropertyChanged("ChargeWeight");
            }
        }

        private MassMeasure chargeWeightField; 

        /// <summary>
        /// The type of the charge.
        /// </summary>
		
		[XmlElement("chargeType")]
        public String ChargeType {
            get {
                return chargeTypeField;
            } 
            set {
                chargeTypeField = value;
                NotifyPropertyChanged("ChargeType");
            }
        }

        private String chargeTypeField; 

        /// <summary>
        /// Reference to the log
        /// </summary>
		
		[XmlElement("refLog")]
        public String RefLog {
            get {
                return refLogField;
            } 
            set {
                refLogField = value;
                NotifyPropertyChanged("RefLog");
            }
        }

        private String refLogField; 

        /// <summary>
        /// True if centralized, else decentralized.
        /// </summary>
		
		[XmlElement("gunCentralized")]
        public String GunCentralized {
            get {
                return gunCentralizedField;
            } 
            set {
                gunCentralizedField = value;
                NotifyPropertyChanged("GunCentralized");
            }
        }

        private String gunCentralizedField; 

        /// <summary>
        /// The size of the perforation gun.
        /// </summary>
		[ComponentElement]
		[XmlElement("gunSize")]
        public LengthMeasure GunSize {
            get {
                return gunSizeField;
            } 
            set {
                gunSizeField = value;
                NotifyPropertyChanged("GunSize");
            }
        }

        private LengthMeasure gunSizeField; 

        /// <summary>
        /// Description about the perforating gun.
        /// </summary>
		
		[XmlElement("gunDesciption")]
        public String GunDesciption {
            get {
                return gunDesciptionField;
            } 
            set {
                gunDesciptionField = value;
                NotifyPropertyChanged("GunDesciption");
            }
        }

        private String gunDesciptionField; 

        /// <summary>
        /// Flag indicating whether the gun is left in hole or not.
        /// </summary>
		
		[XmlElement("gunLeftInHole")]
        public Boolean? GunLeftInHole {
            get {
                return gunLeftInHoleField;
            } 
            set {
                gunLeftInHoleField = value;
                this.GunLeftInHoleSpecified = true;
                NotifyPropertyChanged("GunLeftInHole");
            }
        }

        private Boolean? gunLeftInHoleField; 

		/// <summary>
        /// gunLeftInHoleSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GunLeftInHoleSpecified {
            get {
                return gunLeftInHoleSpecifiedField;
            } 
            set {
                gunLeftInHoleSpecifiedField = value;
                NotifyPropertyChanged("GunLeftInHoleSpecified");
            }
        }

        private Boolean gunLeftInHoleSpecifiedField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on the perforating event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_perforatingExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on the perforating event.")]
    public partial class PerforatingExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The perforationSet reference ID.
        /// </summary>
		
		[XmlElement("perforationSetRefID")]
        public String PerforationSetRefID {
            get {
                return perforationSetRefIDField;
            } 
            set {
                perforationSetRefIDField = value;
                NotifyPropertyChanged("PerforationSetRefID");
            }
        }

        private String perforationSetRefIDField; 

        /// <summary>
        /// Information on perforating event.
        /// </summary>
		[RecurringElement]
		[XmlElement("perforating")]
        public List<Perforating> Perforating {
            get {
                return perforatingField;
            } 
            set {
                perforatingField = value;
                NotifyPropertyChanged("Perforating");
            }
        }

        private List<Perforating> perforatingField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
    /// Information on waiting event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_waitingOnExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on waiting event.")]
    public partial class WaitingOnExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Sub category
        /// </summary>
		
		[XmlElement("subCategory")]
        public String SubCategory {
            get {
                return subCategoryField;
            } 
            set {
                subCategoryField = value;
                NotifyPropertyChanged("SubCategory");
            }
        }

        private String subCategoryField; 

        /// <summary>
        /// Code for charge type
        /// </summary>
		
		[XmlElement("chargeTypeCode")]
        public String ChargeTypeCode {
            get {
                return chargeTypeCodeField;
            } 
            set {
                chargeTypeCodeField = value;
                NotifyPropertyChanged("ChargeTypeCode");
            }
        }

        private String chargeTypeCodeField; 

        /// <summary>
        /// Business organization waiting on 
        /// </summary>
		
		[XmlElement("businessOrgWaitingOn")]
        public String BusinessOrgWaitingOn {
            get {
                return businessOrgWaitingOnField;
            } 
            set {
                businessOrgWaitingOnField = value;
                NotifyPropertyChanged("BusinessOrgWaitingOn");
            }
        }

        private String businessOrgWaitingOnField; 

        /// <summary>
        /// Flag indicating whether producer is charged or not
        /// </summary>
		
		[XmlElement("isNoChargeToProducer")]
        public Boolean? IsNoChargeToProducer {
            get {
                return isNoChargeToProducerField;
            } 
            set {
                isNoChargeToProducerField = value;
                this.IsNoChargeToProducerSpecified = true;
                NotifyPropertyChanged("IsNoChargeToProducer");
            }
        }

        private Boolean? isNoChargeToProducerField; 

		/// <summary>
        /// isNoChargeToProducerSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsNoChargeToProducerSpecified {
            get {
                return isNoChargeToProducerSpecifiedField;
            } 
            set {
                isNoChargeToProducerSpecifiedField = value;
                NotifyPropertyChanged("IsNoChargeToProducerSpecified");
            }
        }

        private Boolean isNoChargeToProducerSpecifiedField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on pressure test event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_pressureTestExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on pressure test event.")]
    public partial class PressureTestExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Orifice Size
        /// </summary>
		[ComponentElement]
		[XmlElement("diaOrificeSize")]
        public LengthMeasure DiaOrificeSize {
            get {
                return diaOrificeSizeField;
            } 
            set {
                diaOrificeSizeField = value;
                NotifyPropertyChanged("DiaOrificeSize");
            }
        }

        private LengthMeasure diaOrificeSizeField; 

        /// <summary>
        /// Next Test Date
        /// </summary>
		
		[XmlElement("dTimeNextTestDate")]
        public DateTime? DTimeNextTestDate {
            get {
                return dTimeNextTestDateField;
            } 
            set {
                dTimeNextTestDateField = value;
                this.DTimeNextTestDateSpecified = true;
                NotifyPropertyChanged("DTimeNextTestDate");
            }
        }

        private DateTime? dTimeNextTestDateField; 

		/// <summary>
        /// dTimeNextTestDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DTimeNextTestDateSpecified {
            get {
                return dTimeNextTestDateSpecifiedField;
            } 
            set {
                dTimeNextTestDateSpecifiedField = value;
                NotifyPropertyChanged("DTimeNextTestDateSpecified");
            }
        }

        private Boolean dTimeNextTestDateSpecifiedField; 

        /// <summary>
        /// Rate Bled
        /// </summary>
		[ComponentElement]
		[XmlElement("flowrateRateBled")]
        public VolumeFlowRateMeasure FlowrateRateBled {
            get {
                return flowrateRateBledField;
            } 
            set {
                flowrateRateBledField = value;
                NotifyPropertyChanged("FlowrateRateBled");
            }
        }

        private VolumeFlowRateMeasure flowrateRateBledField; 

        /// <summary>
        /// String Being Tested
        /// </summary>
		
		[XmlElement("identifierJob")]
        public String IdentifierJob {
            get {
                return identifierJobField;
            } 
            set {
                identifierJobField = value;
                NotifyPropertyChanged("IdentifierJob");
            }
        }

        private String identifierJobField; 

        /// <summary>
        /// True if successful
        /// </summary>
		
		[XmlElement("isSuccess")]
        public Boolean? IsSuccess {
            get {
                return isSuccessField;
            } 
            set {
                isSuccessField = value;
                this.IsSuccessSpecified = true;
                NotifyPropertyChanged("IsSuccess");
            }
        }

        private Boolean? isSuccessField; 

		/// <summary>
        /// isSuccessSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsSuccessSpecified {
            get {
                return isSuccessSpecifiedField;
            } 
            set {
                isSuccessSpecifiedField = value;
                NotifyPropertyChanged("IsSuccessSpecified");
            }
        }

        private Boolean isSuccessSpecifiedField; 

        /// <summary>
        /// Maximum pressure held during test
        /// </summary>
		[ComponentElement]
		[XmlElement("maxPressureDuration")]
        public PressureMeasure MaxPressureDuration {
            get {
                return maxPressureDurationField;
            } 
            set {
                maxPressureDurationField = value;
                NotifyPropertyChanged("MaxPressureDuration");
            }
        }

        private PressureMeasure maxPressureDurationField; 

        /// <summary>
        /// Circulating position
        /// </summary>
		
		[XmlElement("circulatingPosition")]
        public String CirculatingPosition {
            get {
                return circulatingPositionField;
            } 
            set {
                circulatingPositionField = value;
                NotifyPropertyChanged("CirculatingPosition");
            }
        }

        private String circulatingPositionField; 

        /// <summary>
        /// Fluid bled type
        /// </summary>
		
		[XmlElement("fluidBledType")]
        public String FluidBledType {
            get {
                return fluidBledTypeField;
            } 
            set {
                fluidBledTypeField = value;
                NotifyPropertyChanged("FluidBledType");
            }
        }

        private String fluidBledTypeField; 

        /// <summary>
        /// Description of orientaton method
        /// </summary>
		
		[XmlElement("orientationMethod")]
        public String OrientationMethod {
            get {
                return orientationMethodField;
            } 
            set {
                orientationMethodField = value;
                NotifyPropertyChanged("OrientationMethod");
            }
        }

        private String orientationMethodField; 

        /// <summary>
        /// Test fluid type
        /// </summary>
		
		[XmlElement("testFluidType")]
        public String TestFluidType {
            get {
                return testFluidTypeField;
            } 
            set {
                testFluidTypeField = value;
                NotifyPropertyChanged("TestFluidType");
            }
        }

        private String testFluidTypeField; 

        /// <summary>
        /// Test sub type
        /// </summary>
		
		[XmlElement("testSubType")]
        public String TestSubType {
            get {
                return testSubTypeField;
            } 
            set {
                testSubTypeField = value;
                NotifyPropertyChanged("TestSubType");
            }
        }

        private String testSubTypeField; 

        /// <summary>
        /// Test type
        /// </summary>
		
		[XmlElement("testType")]
        public String TestType {
            get {
                return testTypeField;
            } 
            set {
                testTypeField = value;
                NotifyPropertyChanged("TestType");
            }
        }

        private String testTypeField; 

        /// <summary>
        /// Annulus pressure
        /// </summary>
		[ComponentElement]
		[XmlElement("annulusPressure")]
        public PressureMeasure AnnulusPressure {
            get {
                return annulusPressureField;
            } 
            set {
                annulusPressureField = value;
                NotifyPropertyChanged("AnnulusPressure");
            }
        }

        private PressureMeasure annulusPressureField; 

        /// <summary>
        /// Well pressure used 
        /// </summary>
		
		[XmlElement("wellPressureUsed")]
        public String WellPressureUsed {
            get {
                return wellPressureUsedField;
            } 
            set {
                wellPressureUsedField = value;
                NotifyPropertyChanged("WellPressureUsed");
            }
        }

        private String wellPressureUsedField; 

        /// <summary>
        /// Reference #
        /// </summary>
		
		[XmlElement("str10Reference")]
        public String Str10Reference {
            get {
                return str10ReferenceField;
            } 
            set {
                str10ReferenceField = value;
                NotifyPropertyChanged("Str10Reference");
            }
        }

        private String str10ReferenceField; 

        /// <summary>
        /// Well (Assembly)
        /// </summary>
		
		[XmlElement("uidAssembly")]
        public String UidAssembly {
            get {
                return uidAssemblyField;
            } 
            set {
                uidAssemblyField = value;
                NotifyPropertyChanged("UidAssembly");
            }
        }

        private String uidAssemblyField; 

        /// <summary>
        /// Volume Bled
        /// </summary>
		[ComponentElement]
		[XmlElement("volumeBled")]
        public VolumeMeasure VolumeBled {
            get {
                return volumeBledField;
            } 
            set {
                volumeBledField = value;
                NotifyPropertyChanged("VolumeBled");
            }
        }

        private VolumeMeasure volumeBledField; 

        /// <summary>
        /// Volume Lost
        /// </summary>
		[ComponentElement]
		[XmlElement("volumeLost")]
        public VolumeMeasure VolumeLost {
            get {
                return volumeLostField;
            } 
            set {
                volumeLostField = value;
                NotifyPropertyChanged("VolumeLost");
            }
        }

        private VolumeMeasure volumeLostField; 

        /// <summary>
        /// Volume Pumped
        /// </summary>
		[ComponentElement]
		[XmlElement("volumePumped")]
        public VolumeMeasure VolumePumped {
            get {
                return volumePumpedField;
            } 
            set {
                volumePumpedField = value;
                NotifyPropertyChanged("VolumePumped");
            }
        }

        private VolumeMeasure volumePumpedField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on the job event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_jobExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on the job event.")]
    public partial class JobExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Comment on the reason for the job
        /// </summary>
		
		[XmlElement("jobReason")]
        public String JobReason {
            get {
                return jobReasonField;
            } 
            set {
                jobReasonField = value;
                NotifyPropertyChanged("JobReason");
            }
        }

        private String jobReasonField; 

        /// <summary>
        /// Status of job
        /// </summary>
		
		[XmlElement("jobStatus")]
        public String JobStatus {
            get {
                return jobStatusField;
            } 
            set {
                jobStatusField = value;
                NotifyPropertyChanged("JobStatus");
            }
        }

        private String jobStatusField; 

        /// <summary>
        /// The primary reason for doing this job.
        /// </summary>
		
		[XmlElement("primaryMotivationForJob")]
        public String PrimaryMotivationForJob {
            get {
                return primaryMotivationForJobField;
            } 
            set {
                primaryMotivationForJobField = value;
                NotifyPropertyChanged("PrimaryMotivationForJob");
            }
        }

        private String primaryMotivationForJobField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on fractionation event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_acidizefracExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on fractionation event.")]
    public partial class AcidizefracExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Reference to stimJob
        /// </summary>
		
		[XmlElement("stimJobID")]
        public String StimJobID {
            get {
                return stimJobIDField;
            } 
            set {
                stimJobIDField = value;
                NotifyPropertyChanged("StimJobID");
            }
        }

        private String stimJobIDField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
    /// Information on bottom hole pressure during this event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_BHPExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on bottom hole pressure during this event.")]
    public partial class BHPExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Reference to bottom hole pressure 
        /// </summary>
		
		[XmlElement("BHPRefID")]
        public String BHPRefID {
            get {
                return BHPRefIDField;
            } 
            set {
                BHPRefIDField = value;
                NotifyPropertyChanged("BHPRefID");
            }
        }

        private String BHPRefIDField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on lost circulation event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_lostCirculationExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on lost circulation event.")]
    public partial class LostCirculationExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Volume lost
        /// </summary>
		[ComponentElement]
		[XmlElement("volumeLost")]
        public VolumeMeasure VolumeLost {
            get {
                return volumeLostField;
            } 
            set {
                volumeLostField = value;
                NotifyPropertyChanged("VolumeLost");
            }
        }

        private VolumeMeasure volumeLostField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on directional survey event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_directionalSurveyExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on directional survey event.")]
    public partial class DirectionalSurveyExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// trajectory reference id.
        /// </summary>
		
		[XmlElement("trajectoryRefID")]
        public String TrajectoryRefID {
            get {
                return trajectoryRefIDField;
            } 
            set {
                trajectoryRefIDField = value;
                NotifyPropertyChanged("TrajectoryRefID");
            }
        }

        private String trajectoryRefIDField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on clean fill event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_cleanFillExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on clean fill event.")]
    public partial class CleanFillExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// method of fill and cleaning
        /// </summary>
		
		[XmlElement("fillCleaningMethod")]
        public String FillCleaningMethod {
            get {
                return fillCleaningMethodField;
            } 
            set {
                fillCleaningMethodField = value;
                NotifyPropertyChanged("FillCleaningMethod");
            }
        }

        private String fillCleaningMethodField; 

        /// <summary>
        /// the size of the tool 
        /// </summary>
		[ComponentElement]
		[XmlElement("toolSize")]
        public LengthMeasure ToolSize {
            get {
                return toolSizeField;
            } 
            set {
                toolSizeField = value;
                NotifyPropertyChanged("ToolSize");
            }
        }

        private LengthMeasure toolSizeField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on cement job event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_cementExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on cement job event.")]
    public partial class CementExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// unique id of cementJob
        /// </summary>
		
		[XmlElement("cementJobRefID")]
        public String CementJobRefID {
            get {
                return cementJobRefIDField;
            } 
            set {
                cementJobRefIDField = value;
                NotifyPropertyChanged("CementJobRefID");
            }
        }

        private String cementJobRefIDField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
    /// WITSML - event extension schema
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_eventExtension", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("WITSML - event extension schema")]
    public partial class EventExtension : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Extension event for cement
        /// </summary>
        [XmlElement("cementExtension")]
        public CementExtension CementExtension {
            get {
                return cementExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property CementExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property CementExtension when property AcidizeFracExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property CementExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property CementExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property CementExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property CementExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property CementExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property CementExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property CementExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property CementExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property CementExtension when property WaitingOnExtension is already set");
                cementExtensionField = value;
                CementExtensionSpecified = (value!=null);
                NotifyPropertyChanged("CementExtension");
            }
        }

        private CementExtension cementExtensionField; 
        /// <summary>
        /// Boolean to indicate if CementExtension has been set. Used for serialization.
        /// </summary>
        private Boolean CementExtensionSpecified = false; 

        /// <summary>
        /// Extension event for clean fill
        /// </summary>
        [XmlElement("cleanFillExtension")]
        public CleanFillExtension CleanFillExtension {
            get {
                return cleanFillExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property CementExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property CleanFillExtension when property WaitingOnExtension is already set");
                cleanFillExtensionField = value;
                CleanFillExtensionSpecified = (value!=null);
                NotifyPropertyChanged("CleanFillExtension");
            }
        }

        private CleanFillExtension cleanFillExtensionField; 
        /// <summary>
        /// Boolean to indicate if CleanFillExtension has been set. Used for serialization.
        /// </summary>
        private Boolean CleanFillExtensionSpecified = false; 

        /// <summary>
        /// Extension event for directional survey
        /// </summary>
        [XmlElement("directionalSurveyExtension")]
        public DirectionalSurveyExtension DirectionalSurveyExtension {
            get {
                return directionalSurveyExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property CleanFillExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property DirectionalSurveyExtension when property WaitingOnExtension is already set");
                directionalSurveyExtensionField = value;
                DirectionalSurveyExtensionSpecified = (value!=null);
                NotifyPropertyChanged("DirectionalSurveyExtension");
            }
        }

        private DirectionalSurveyExtension directionalSurveyExtensionField; 
        /// <summary>
        /// Boolean to indicate if DirectionalSurveyExtension has been set. Used for serialization.
        /// </summary>
        private Boolean DirectionalSurveyExtensionSpecified = false; 

        /// <summary>
        /// Extension event for lost circulation
        /// </summary>
        [XmlElement("lostCirculationExtension")]
        public LostCirculationExtension LostCirculationExtension {
            get {
                return lostCirculationExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property JobExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property LostCirculationExtension when property WaitingOnExtension is already set");
                lostCirculationExtensionField = value;
                LostCirculationExtensionSpecified = (value!=null);
                NotifyPropertyChanged("LostCirculationExtension");
            }
        }

        private LostCirculationExtension lostCirculationExtensionField; 
        /// <summary>
        /// Boolean to indicate if LostCirculationExtension has been set. Used for serialization.
        /// </summary>
        private Boolean LostCirculationExtensionSpecified = false; 

        /// <summary>
        /// Extension event for bottom hole pressure
        /// </summary>
        [XmlElement("BHPExtension")]
        public BHPExtension BHPExtension {
            get {
                return BHPExtensionField;
            } 
            set {
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property BHPExtension when property WaitingOnExtension is already set");
                BHPExtensionField = value;
                BHPExtensionSpecified = (value!=null);
                NotifyPropertyChanged("BHPExtension");
            }
        }

        private BHPExtension BHPExtensionField; 
        /// <summary>
        /// Boolean to indicate if BHPExtension has been set. Used for serialization.
        /// </summary>
        private Boolean BHPExtensionSpecified = false; 

        /// <summary>
        /// Extension event for acidizing and fracturing
        /// </summary>
        [XmlElement("acidizeFracExtension")]
        public AcidizefracExtension AcidizeFracExtension {
            get {
                return acidizeFracExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property BHPExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property AcidizeFracExtension when property WaitingOnExtension is already set");
                acidizeFracExtensionField = value;
                AcidizeFracExtensionSpecified = (value!=null);
                NotifyPropertyChanged("AcidizeFracExtension");
            }
        }

        private AcidizefracExtension acidizeFracExtensionField; 
        /// <summary>
        /// Boolean to indicate if AcidizeFracExtension has been set. Used for serialization.
        /// </summary>
        private Boolean AcidizeFracExtensionSpecified = false; 

        /// <summary>
        /// Extension event for job
        /// </summary>
        [XmlElement("jobExtension")]
        public JobExtension JobExtension {
            get {
                return jobExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property JobExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property JobExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property JobExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property JobExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property JobExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property JobExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property JobExtension when property FluidReportExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property JobExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property JobExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property JobExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property JobExtension when property WaitingOnExtension is already set");
                jobExtensionField = value;
                JobExtensionSpecified = (value!=null);
                NotifyPropertyChanged("JobExtension");
            }
        }

        private JobExtension jobExtensionField; 
        /// <summary>
        /// Boolean to indicate if JobExtension has been set. Used for serialization.
        /// </summary>
        private Boolean JobExtensionSpecified = false; 

        /// <summary>
        /// Extension event for pressure test
        /// </summary>
        [XmlElement("pressureTestExtension")]
        public PressureTestExtension PressureTestExtension {
            get {
                return pressureTestExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property PerforationExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property PressureTestExtension when property WaitingOnExtension is already set");
                pressureTestExtensionField = value;
                PressureTestExtensionSpecified = (value!=null);
                NotifyPropertyChanged("PressureTestExtension");
            }
        }

        private PressureTestExtension pressureTestExtensionField; 
        /// <summary>
        /// Boolean to indicate if PressureTestExtension has been set. Used for serialization.
        /// </summary>
        private Boolean PressureTestExtensionSpecified = false; 

        /// <summary>
        /// Extension event for waiting on
        /// </summary>
        [XmlElement("waitingOnExtension")]
        public WaitingOnExtension WaitingOnExtension {
            get {
                return waitingOnExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property WaitingOnExtension when property PressureTestExtension is already set");
                waitingOnExtensionField = value;
                WaitingOnExtensionSpecified = (value!=null);
                NotifyPropertyChanged("WaitingOnExtension");
            }
        }

        private WaitingOnExtension waitingOnExtensionField; 
        /// <summary>
        /// Boolean to indicate if WaitingOnExtension has been set. Used for serialization.
        /// </summary>
        private Boolean WaitingOnExtensionSpecified = false; 

        /// <summary>
        /// Extension event for perforating event
        /// </summary>
        [XmlElement("perforationExtension")]
        public PerforatingExtension PerforationExtension {
            get {
                return perforationExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property DownholeExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property LostCirculationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property PerforationExtension when property WaitingOnExtension is already set");
                perforationExtensionField = value;
                PerforationExtensionSpecified = (value!=null);
                NotifyPropertyChanged("PerforationExtension");
            }
        }

        private PerforatingExtension perforationExtensionField; 
        /// <summary>
        /// Boolean to indicate if PerforationExtension has been set. Used for serialization.
        /// </summary>
        private Boolean PerforationExtensionSpecified = false; 

        /// <summary>
        /// Extension event for fluid report
        /// </summary>
        [XmlElement("fluidReportExtension")]
        public FluidReportExtension FluidReportExtension {
            get {
                return fluidReportExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property DirectionalSurveyExtension is already set");
                if (value != null && DownholeExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property DownholeExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property FluidReportExtension when property WaitingOnExtension is already set");
                fluidReportExtensionField = value;
                FluidReportExtensionSpecified = (value!=null);
                NotifyPropertyChanged("FluidReportExtension");
            }
        }

        private FluidReportExtension fluidReportExtensionField; 
        /// <summary>
        /// Boolean to indicate if FluidReportExtension has been set. Used for serialization.
        /// </summary>
        private Boolean FluidReportExtensionSpecified = false; 

        /// <summary>
        /// Extension event for downhole component
        /// </summary>
        [XmlElement("downholeExtension")]
        public DownholeExtension DownholeExtension {
            get {
                return downholeExtensionField;
            } 
            set {
                if (value != null && BHPExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property BHPExtension is already set");
                if (value != null && AcidizeFracExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property AcidizeFracExtension is already set");
                if (value != null && CementExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property CementExtension is already set");
                if (value != null && CleanFillExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property CleanFillExtension is already set");
                if (value != null && DirectionalSurveyExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property DirectionalSurveyExtension is already set");
                if (value != null && FluidReportExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property FluidReportExtension is already set");
                if (value != null && JobExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property JobExtension is already set");
                if (value != null && LostCirculationExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property LostCirculationExtension is already set");
                if (value != null && PerforationExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property PerforationExtension is already set");
                if (value != null && PressureTestExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property PressureTestExtension is already set");
                if (value != null && WaitingOnExtensionSpecified) throw new Exception("Cannot set property DownholeExtension when property WaitingOnExtension is already set");
                downholeExtensionField = value;
                DownholeExtensionSpecified = (value!=null);
                NotifyPropertyChanged("DownholeExtension");
            }
        }

        private DownholeExtension downholeExtensionField; 
        /// <summary>
        /// Boolean to indicate if DownholeExtension has been set. Used for serialization.
        /// </summary>
        private Boolean DownholeExtensionSpecified = false; 



        
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
    /// This class represents the downholeStringRef xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="downholeStringRef", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the downholeStringRef xsd type.")]
    public partial class DownholeStringRef : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// stringEquipmentRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("stringEquipmentRefID")]
        public List<String> StringEquipmentRefID {
            get {
                return stringEquipmentRefIDField;
            } 
            set {
                stringEquipmentRefIDField = value;
                NotifyPropertyChanged("StringEquipmentRefID");
            }
        }

        private List<String> stringEquipmentRefIDField; 

		/// <summary>
        /// downholeStringRefID property
        /// </summary>
		
        [XmlAttribute("downholeStringRefID")]
		
        public String DownholeStringRefID {
            get {
                return downholeStringRefIDField;
            } 
            set {
                downholeStringRefIDField = value;
                NotifyPropertyChanged("DownholeStringRefID");
            }
        }

        private String downholeStringRefIDField; 


        
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
    /// This class represents the boreholeStringRef xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="boreholeStringRef", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the boreholeStringRef xsd type.")]
    public partial class BoreholeStringRef : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// stringEquipmentRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("stringEquipmentRefID")]
        public List<String> StringEquipmentRefID {
            get {
                return stringEquipmentRefIDField;
            } 
            set {
                stringEquipmentRefIDField = value;
                NotifyPropertyChanged("StringEquipmentRefID");
            }
        }

        private List<String> stringEquipmentRefIDField; 

		/// <summary>
        /// boreholeStringRefID property
        /// </summary>
		
        [XmlAttribute("boreholeStringRefID")]
		
        public String BoreholeStringRefID {
            get {
                return boreholeStringRefIDField;
            } 
            set {
                boreholeStringRefIDField = value;
                NotifyPropertyChanged("BoreholeStringRefID");
            }
        }

        private String boreholeStringRefIDField; 


        
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
    /// This class represents the downholeComponentRef xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="downholeComponentRef", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the downholeComponentRef xsd type.")]
    public partial class DownholeComponentRef : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// stringEquipmentRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("stringEquipmentRefID")]
        public List<String> StringEquipmentRefID {
            get {
                return stringEquipmentRefIDField;
            } 
            set {
                stringEquipmentRefIDField = value;
                NotifyPropertyChanged("StringEquipmentRefID");
            }
        }

        private List<String> stringEquipmentRefIDField; 

        /// <summary>
        /// boreholeStringRef property
        /// </summary>
		[RecurringElement]
		[XmlElement("boreholeStringRef")]
        public List<BoreholeStringRef> BoreholeStringRef {
            get {
                return boreholeStringRefField;
            } 
            set {
                boreholeStringRefField = value;
                NotifyPropertyChanged("BoreholeStringRef");
            }
        }

        private List<BoreholeStringRef> boreholeStringRefField; 

        /// <summary>
        /// downholeStringsRef property
        /// </summary>
		[RecurringElement]
		[XmlElement("downholeStringsRef")]
        public List<DownholeStringRef> DownholeStringsRef {
            get {
                return downholeStringsRefField;
            } 
            set {
                downholeStringsRefField = value;
                NotifyPropertyChanged("DownholeStringsRef");
            }
        }

        private List<DownholeStringRef> downholeStringsRefField; 

        /// <summary>
        /// perforationSetRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("perforationSetRefID")]
        public List<String> PerforationSetRefID {
            get {
                return perforationSetRefIDField;
            } 
            set {
                perforationSetRefIDField = value;
                NotifyPropertyChanged("PerforationSetRefID");
            }
        }

        private List<String> perforationSetRefIDField; 


        
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
    /// This class represents the eventType xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="eventType", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the eventType xsd type.")]
    public partial class EventType : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the EventType class.
        /// </summary>
        public EventType() {}

        /// <summary>
        /// Initializes a new instance of the EventType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public EventType(String value)
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
        /// Class of the event type (job, daily report, etc.)
        /// </summary>
		[Description("Class of the event type (job, daily report, etc.)")]
        [XmlAttribute("class")]
		
        public EventClassType Class {
            get {
                return classField;
            } 
            set {
                classField = value;
                this.ClassSpecified = true;
                NotifyPropertyChanged("Class");
            }
        }

        private EventClassType classField; 

		/// <summary>
        /// classSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ClassSpecified {
            get {
                return classSpecifiedField;
            } 
            set {
                classSpecifiedField = value;
                NotifyPropertyChanged("ClassSpecified");
            }
        }

        private Boolean classSpecifiedField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public String Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private String ValueField; 


        
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
    /// This class represents the obj_wellCMLedger xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_wellCMLedger", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the obj_wellCMLedger xsd type.")]
    public partial class WellCMLedger : Object, IWellboreObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Well name.
        /// </summary>
		[StringLength(64)]
		[Description("Well name.")]
		[XmlElement("nameWell")]
        public String NameWell {
            get {
                return nameWellField;
            } 
            set {
                nameWellField = value;
                NotifyPropertyChanged("NameWell");
            }
        }

        private String nameWellField; 

        /// <summary>
        /// Wellbore name.
        /// </summary>
		[StringLength(64)]
		[Description("Wellbore name.")]
		[XmlElement("nameWellbore")]
        public String NameWellbore {
            get {
                return nameWellboreField;
            } 
            set {
                nameWellboreField = value;
                NotifyPropertyChanged("NameWellbore");
            }
        }

        private String nameWellboreField; 

        /// <summary>
        /// Ledger name.
        /// </summary>
		[StringLength(64)]
		[Description("Ledger name.")]
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// Parent event reference id.
        /// </summary>
		[RegularExpression("[^ ]*")]
		[StringLength(64)]
		[Description("Parent event reference id.")]
		[XmlElement("parentEventID")]
        public String ParentEventID {
            get {
                return parentEventIDField;
            } 
            set {
                parentEventIDField = value;
                NotifyPropertyChanged("ParentEventID");
            }
        }

        private String parentEventIDField; 

        /// <summary>
        /// Date and time that activities started.
        /// </summary>
		[Description("Date and time that activities started.")]
		[XmlElement("dTimStart")]
        public Timestamp? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set {
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
                NotifyPropertyChanged("DateTimeStart");
            }
        }

        private Timestamp? dTimStartField; 

		/// <summary>
        /// dTimStartSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified {
            get {
                return dTimStartSpecifiedField;
            } 
            set {
                dTimStartSpecifiedField = value;
                NotifyPropertyChanged("DateTimeStartSpecified");
            }
        }

        private Boolean dTimStartSpecifiedField; 

        /// <summary>
        /// Date and time that activities were completed.
        /// </summary>
		[Description("Date and time that activities were completed.")]
		[XmlElement("dTimEnd")]
        public Timestamp? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set {
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
                NotifyPropertyChanged("DateTimeEnd");
            }
        }

        private Timestamp? dTimEndField; 

		/// <summary>
        /// dTimEndSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified {
            get {
                return dTimEndSpecifiedField;
            } 
            set {
                dTimEndSpecifiedField = value;
                NotifyPropertyChanged("DateTimeEndSpecified");
            }
        }

        private Boolean dTimEndSpecifiedField; 

        /// <summary>
        /// The activity duration (commonly in hours).
        /// </summary>
		[Description("The activity duration (commonly in hours).")]
		[ComponentElement]
		[XmlElement("duration")]
        public TimeMeasure Duration {
            get {
                return durationField;
            } 
            set {
                durationField = value;
                NotifyPropertyChanged("Duration");
            }
        }

        private TimeMeasure durationField; 

        /// <summary>
        /// Measured depth at Top of Interval.
        /// </summary>
		[Description("Measured depth at Top of Interval.")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// Measured depth at bottom of the section.
        /// </summary>
		[Description("Measured depth at bottom of the section.")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// Order number of event.
        /// </summary>
		[Description("Order number of event.")]
		[XmlElement("eventOrder")]
        public Int16? EventOrder {
            get {
                return eventOrderField;
            } 
            set {
                eventOrderField = value;
                this.EventOrderSpecified = true;
                NotifyPropertyChanged("EventOrder");
            }
        }

        private Int16? eventOrderField; 

		/// <summary>
        /// eventOrderSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EventOrderSpecified {
            get {
                return eventOrderSpecifiedField;
            } 
            set {
                eventOrderSpecifiedField = value;
                NotifyPropertyChanged("EventOrderSpecified");
            }
        }

        private Boolean eventOrderSpecifiedField; 

        /// <summary>
        /// Rig reference id.
        /// </summary>
		[StringLength(64)]
		[Description("Rig reference id.")]
		[RecurringElement]
		[XmlElement("rigID")]
        public List<String> RigID {
            get {
                return rigIDField;
            } 
            set {
                rigIDField = value;
                NotifyPropertyChanged("RigID");
            }
        }

        private List<String> rigIDField; 

        /// <summary>
        /// Activity code
        /// </summary>
		[Description("Activity code")]
		[XmlElement("activityCode")]
        public ActivityCode ActivityCode {
            get {
                return activityCodeField;
            } 
            set {
                activityCodeField = value;
                this.ActivityCodeSpecified = true;
                NotifyPropertyChanged("ActivityCode");
            }
        }

        private ActivityCode activityCodeField; 

		/// <summary>
        /// activityCodeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ActivityCodeSpecified {
            get {
                return activityCodeSpecifiedField;
            } 
            set {
                activityCodeSpecifiedField = value;
                NotifyPropertyChanged("ActivityCodeSpecified");
            }
        }

        private Boolean activityCodeSpecifiedField; 

        /// <summary>
        /// Comment on type of this event, either referring to a job type or an activity type e.g. a safety meeting. 
        /// </summary>
		[Description("Comment on type of this event, either referring to a job type or an  activity type e.g. a safety meeting.")]
		[ComponentElement]
		[XmlElement("type")]
        public EventType Type {
            get {
                return typeField;
            } 
            set {
                typeField = value;
                NotifyPropertyChanged("Type");
            }
        }

        private EventType typeField; 

        /// <summary>
        /// True if planned.
        /// </summary>
		[Description("True if planned.")]
		[XmlElement("isPlan")]
        public Boolean? IsPlan {
            get {
                return isPlanField;
            } 
            set {
                isPlanField = value;
                this.IsPlanSpecified = true;
                NotifyPropertyChanged("IsPlan");
            }
        }

        private Boolean? isPlanField; 

		/// <summary>
        /// isPlanSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsPlanSpecified {
            get {
                return isPlanSpecifiedField;
            } 
            set {
                isPlanSpecifiedField = value;
                NotifyPropertyChanged("IsPlanSpecified");
            }
        }

        private Boolean isPlanSpecifiedField; 

        /// <summary>
        /// Extension event for work order id.
        /// </summary>
		[StringLength(64)]
		[Description("Extension event for work order id.")]
		[XmlElement("workOrderID")]
        public String WorkOrderID {
            get {
                return workOrderIDField;
            } 
            set {
                workOrderIDField = value;
                NotifyPropertyChanged("WorkOrderID");
            }
        }

        private String workOrderIDField; 

        /// <summary>
        /// this is to associate with verb(Event) and noun (downholeEquipment). to refer to the whole downholeComponent using downholeComponentExtension.
        /// </summary>
		[Description("this is to associate with verb(Event) and noun (downholeEquipment). to refer to the whole downholeComponent using downholeComponentExtension.")]
		[ComponentElement]
		[XmlElement("downholeComponentRef")]
        public DownholeComponentRef DownholeComponentRef {
            get {
                return downholeComponentRefField;
            } 
            set {
                downholeComponentRefField = value;
                NotifyPropertyChanged("DownholeComponentRef");
            }
        }

        private DownholeComponentRef downholeComponentRefField; 

        /// <summary>
        /// Event extensions
        /// </summary>
		[Description("Event extensions")]
		[RecurringElement]
		[XmlElement("eventExtension")]
        public List<EventExtension> EventExtension {
            get {
                return eventExtensionField;
            } 
            set {
                eventExtensionField = value;
                NotifyPropertyChanged("EventExtension");
            }
        }

        private List<EventExtension> eventExtensionField; 

        /// <summary>
        /// Service company or business
        /// </summary>
		[StringLength(64)]
		[Description("Service company or business")]
		[XmlElement("businessAssociate")]
        public String BusinessAssociate {
            get {
                return businessAssociateField;
            } 
            set {
                businessAssociateField = value;
                NotifyPropertyChanged("BusinessAssociate");
            }
        }

        private String businessAssociateField; 

        /// <summary>
        /// Name or information about person responsible who is implementing the service or job.
        /// </summary>
		[StringLength(64)]
		[Description("Name or information about person responsible who is implementing the service or job.")]
		[XmlElement("responsiblePerson")]
        public String ResponsiblePerson {
            get {
                return responsiblePersonField;
            } 
            set {
                responsiblePersonField = value;
                NotifyPropertyChanged("ResponsiblePerson");
            }
        }

        private String responsiblePersonField; 

        /// <summary>
        /// Contact name or person to get in touch with. Might not necessarily be the person responsible.
        /// </summary>
		[StringLength(64)]
		[Description("Contact name or person to get in touch with. Might not necessarily be the person responsible.")]
		[XmlElement("contact")]
        public String Contact {
            get {
                return contactField;
            } 
            set {
                contactField = value;
                NotifyPropertyChanged("Contact");
            }
        }

        private String contactField; 

        /// <summary>
        /// The job or event cost detail.
        /// </summary>
		[Description("The job or event cost detail.")]
		[RecurringElement]
		[XmlElement("cost")]
        public List<DayCost> Cost {
            get {
                return costField;
            } 
            set {
                costField = value;
                NotifyPropertyChanged("Cost");
            }
        }

        private List<DayCost> costField; 

        /// <summary>
        /// True if event is not productive.
        /// </summary>
		[Description("True if event is not productive.")]
		[XmlElement("nonproductive")]
        public Boolean? Nonproductive {
            get {
                return nonproductiveField;
            } 
            set {
                nonproductiveField = value;
                this.NonproductiveSpecified = true;
                NotifyPropertyChanged("Nonproductive");
            }
        }

        private Boolean? nonproductiveField; 

		/// <summary>
        /// nonproductiveSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean NonproductiveSpecified {
            get {
                return nonproductiveSpecifiedField;
            } 
            set {
                nonproductiveSpecifiedField = value;
                NotifyPropertyChanged("NonproductiveSpecified");
            }
        }

        private Boolean nonproductiveSpecifiedField; 

        /// <summary>
        /// True if event implies is in-trouble
        /// </summary>
		[Description("True if event implies is in-trouble")]
		[XmlElement("trouble")]
        public Boolean? Trouble {
            get {
                return troubleField;
            } 
            set {
                troubleField = value;
                this.TroubleSpecified = true;
                NotifyPropertyChanged("Trouble");
            }
        }

        private Boolean? troubleField; 

		/// <summary>
        /// troubleSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TroubleSpecified {
            get {
                return troubleSpecifiedField;
            } 
            set {
                troubleSpecifiedField = value;
                NotifyPropertyChanged("TroubleSpecified");
            }
        }

        private Boolean troubleSpecifiedField; 

        /// <summary>
        /// True of event is for preventive maintenance
        /// </summary>
		[Description("True of event is for preventive maintenance")]
		[XmlElement("preventiveMaintenance")]
        public Boolean? PreventiveMaintenance {
            get {
                return preventiveMaintenanceField;
            } 
            set {
                preventiveMaintenanceField = value;
                this.PreventiveMaintenanceSpecified = true;
                NotifyPropertyChanged("PreventiveMaintenance");
            }
        }

        private Boolean? preventiveMaintenanceField; 

		/// <summary>
        /// preventiveMaintenanceSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PreventiveMaintenanceSpecified {
            get {
                return preventiveMaintenanceSpecifiedField;
            } 
            set {
                preventiveMaintenanceSpecifiedField = value;
                NotifyPropertyChanged("PreventiveMaintenanceSpecified");
            }
        }

        private Boolean preventiveMaintenanceSpecifiedField; 

        /// <summary>
        /// True if there is no planning infomation for this activity.
        /// </summary>
		[Description("True if there is no planning infomation for this activity.")]
		[XmlElement("unplanned")]
        public Boolean? Unplanned {
            get {
                return unplannedField;
            } 
            set {
                unplannedField = value;
                this.UnplannedSpecified = true;
                NotifyPropertyChanged("Unplanned");
            }
        }

        private Boolean? unplannedField; 

		/// <summary>
        /// unplannedSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean UnplannedSpecified {
            get {
                return unplannedSpecifiedField;
            } 
            set {
                unplannedSpecifiedField = value;
                NotifyPropertyChanged("UnplannedSpecified");
            }
        }

        private Boolean unplannedSpecifiedField; 

        /// <summary>
        /// Phase (large activity classification) e.g. Drill Surface Hole.
        /// </summary>
		[StringLength(40)]
		[Description("Phase (large activity classification) e.g. Drill Surface Hole.")]
		[XmlElement("phase")]
        public String Phase {
            get {
                return phaseField;
            } 
            set {
                phaseField = value;
                NotifyPropertyChanged("Phase");
            }
        }

        private String phaseField; 

        /// <summary>
        /// Participant points to the involved witsmlobjects
        /// </summary>
		[Description("Participant points to the involved witsmlobjects")]
		[ComponentElement]
		[XmlElement("participant")]
        public Participant Participants {
            get {
                return participantField;
            } 
            set {
                participantField = value;
                NotifyPropertyChanged("Participants");
            }
        }

        private Participant participantField; 

        /// <summary>
        /// Comment on this ledger
        /// </summary>
		[StringLength(4000)]
		[Description("Comment on this ledger")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

        /// <summary>
        /// A container element that contains elements that are common to all data objects.
        /// </summary>
		[Description("A container element that contains elements that are common to all data objects.")]
		[ComponentElement]
		[XmlElement("commonData")]
        public CommonData CommonData {
            get {
                return commonDataField;
            } 
            set {
                commonDataField = value;
                NotifyPropertyChanged("CommonData");
            }
        }

        private CommonData commonDataField; 

        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
		[Description("A container element that can contain custom or user defined data elements.")]
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
        /// Description of this ledger
        /// </summary>
		[StringLength(4000)]
		[Description("Description of this ledger")]
		[XmlElement("description")]
        public String Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private String descriptionField; 

		/// <summary>
        /// Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell. 
        /// </summary>
		[Description("Unique identifier for the well. This uniquely represents  the well referenced by the (possibly non-unique) nameWell.")]
        [XmlAttribute("uidWell")]
		
        public String UidWell {
            get {
                return uidWellField;
            } 
            set {
                uidWellField = value;
                NotifyPropertyChanged("UidWell");
            }
        }

        private String uidWellField; 

		/// <summary>
        /// Unique identifier for the wellbore. This uniquely represents the wellbore referenced by the (possibly non-unique) nameWellbore. 
        /// </summary>
		[Description("Unique identifier for the wellbore. This uniquely represents  the wellbore referenced by the (possibly non-unique) nameWellbore.")]
        [XmlAttribute("uidWellbore")]
		
        public String UidWellbore {
            get {
                return uidWellboreField;
            } 
            set {
                uidWellboreField = value;
                NotifyPropertyChanged("UidWellbore");
            }
        }

        private String uidWellboreField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_slotsInterval xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_slotsInterval", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_slotsInterval xsd type.")]
    public partial class SlotsInterval : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// stringEquipmentRefUID property
        /// </summary>
		[RegularExpression("[^ ]*")]
		[StringLength(64)]
		[XmlElement("stringEquipmentRefUID")]
        public String StringEquipmentRefUID {
            get {
                return stringEquipmentRefUIDField;
            } 
            set {
                stringEquipmentRefUIDField = value;
                NotifyPropertyChanged("StringEquipmentRefUID");
            }
        }

        private String stringEquipmentRefUIDField; 

        /// <summary>
        /// mdTop property
        /// </summary>
		[Description("Measured depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// mdBottom property
        /// </summary>
		[Description("Measured depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// tvdTop property
        /// </summary>
		[Description("True vertical depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// tvdBottom property
        /// </summary>
		[Description("True vertical depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// intervalStatusHistory property
        /// </summary>
		[Description("The contactInterval history information")]
		[RecurringElement]
		[XmlElement("intervalStatusHistory")]
        public List<IntervalStatusHistory> IntervalStatusHistory {
            get {
                return intervalStatusHistoryField;
            } 
            set {
                intervalStatusHistoryField = value;
                NotifyPropertyChanged("IntervalStatusHistory");
            }
        }

        private List<IntervalStatusHistory> intervalStatusHistoryField; 

        /// <summary>
        /// eventHistory property
        /// </summary>
		[Description("The contactInterval event information")]
		[ComponentElement]
		[XmlElement("eventHistory")]
        public EventInfo EventHistory {
            get {
                return eventHistoryField;
            } 
            set {
                eventHistoryField = value;
                NotifyPropertyChanged("EventHistory");
            }
        }

        private EventInfo eventHistoryField; 

        /// <summary>
        /// geologyFeatureRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("geologyFeatureRefID")]
        public List<String> GeologyFeatureRefID {
            get {
                return geologyFeatureRefIDField;
            } 
            set {
                geologyFeatureRefIDField = value;
                NotifyPropertyChanged("GeologyFeatureRefID");
            }
        }

        private List<String> geologyFeatureRefIDField; 

        /// <summary>
        /// extensionNameValue property
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// Information on the status history in the interval
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_intervalStatusHistory", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on the status history in the interval")]
    public partial class IntervalStatusHistory : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The physical status of an interval (e.g., open, closed, proposed)
        /// </summary>
		[Description("The physical status of an interval (e.g., open, closed, proposed)")]
		[XmlElement("physicalStatus")]
        public PhysicalStatus? PhysicalStatus {
            get {
                return physicalStatusField;
            } 
            set {
                physicalStatusField = value;
                this.PhysicalStatusSpecified = true;
                NotifyPropertyChanged("PhysicalStatus");
            }
        }

        private PhysicalStatus? physicalStatusField; 

		/// <summary>
        /// physicalStatusSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PhysicalStatusSpecified {
            get {
                return physicalStatusSpecifiedField;
            } 
            set {
                physicalStatusSpecifiedField = value;
                NotifyPropertyChanged("PhysicalStatusSpecified");
            }
        }

        private Boolean physicalStatusSpecifiedField; 

        /// <summary>
        /// The start date of status and allocation factor
        /// </summary>
		[Description("The start date of status and allocation factor")]
		[XmlElement("startDate")]
        public Timestamp? StartDate {
            get {
                return startDateField;
            } 
            set {
                startDateField = value;
                this.StartDateSpecified = true;
                NotifyPropertyChanged("StartDate");
            }
        }

        private Timestamp? startDateField; 

		/// <summary>
        /// startDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StartDateSpecified {
            get {
                return startDateSpecifiedField;
            } 
            set {
                startDateSpecifiedField = value;
                NotifyPropertyChanged("StartDateSpecified");
            }
        }

        private Boolean startDateSpecifiedField; 

        /// <summary>
        /// The end date of status and allocation factor
        /// </summary>
		[Description("The end date of status and allocation factor")]
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
        public Boolean EndDateSpecified {
            get {
                return endDateSpecifiedField;
            } 
            set {
                endDateSpecifiedField = value;
                NotifyPropertyChanged("EndDateSpecified");
            }
        }

        private Boolean endDateSpecifiedField; 

        /// <summary>
        /// The measured top depth of the interval
        /// </summary>
		[Description("The measured top depth of the interval")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// The measured bottom depth of the interval
        /// </summary>
		[Description("The measured bottom depth of the interval")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// defines the proportional amount of fluid from the well completion that is flowing through this interval whithin a wellbore
        /// </summary>
		[Range(0, 1)]
		[Description("defines the proportional amount of fluid from the well completion  that is flowing through this interval whithin a wellbore")]
		[XmlElement("allocationFactor")]
        public Double? AllocationFactor {
            get {
                return allocationFactorField;
            } 
            set {
                allocationFactorField = value;
                this.AllocationFactorSpecified = true;
                NotifyPropertyChanged("AllocationFactor");
            }
        }

        private Double? allocationFactorField; 

		/// <summary>
        /// allocationFactorSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AllocationFactorSpecified {
            get {
                return allocationFactorSpecifiedField;
            } 
            set {
                allocationFactorSpecifiedField = value;
                NotifyPropertyChanged("AllocationFactorSpecified");
            }
        }

        private Boolean allocationFactorSpecifiedField; 

        /// <summary>
        /// A remark about the interval over this period of time
        /// </summary>
		[StringLength(4000)]
		[Description("A remark about the interval over this period of time")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// Event information type
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_eventInfo", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Event information type")]
    public partial class EventInfo : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The referencing event was initailized
        /// </summary>
		[Description("The referencing event was initailized")]
		[ComponentElement]
		[XmlElement("beginEvent")]
        public EventRefInfo BeginEvent {
            get {
                return beginEventField;
            } 
            set {
                beginEventField = value;
                NotifyPropertyChanged("BeginEvent");
            }
        }

        private EventRefInfo beginEventField; 

        /// <summary>
        /// The referencing event when the even was end
        /// </summary>
		[Description("The referencing event when the even was end")]
		[ComponentElement]
		[XmlElement("endEvent")]
        public EventRefInfo EndEvent {
            get {
                return endEventField;
            } 
            set {
                endEventField = value;
                NotifyPropertyChanged("EndEvent");
            }
        }

        private EventRefInfo endEventField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Event reference collection
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_eventRefInfo", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Event reference collection")]
    public partial class EventRefInfo : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The referencing eventledger ID
        /// </summary>
		[RegularExpression("[^ ]*")]
		[StringLength(64)]
		[Description("The referencing eventledger ID")]
		[XmlElement("eventRefID")]
        public String EventRefID {
            get {
                return eventRefIDField;
            } 
            set {
                eventRefIDField = value;
                NotifyPropertyChanged("EventRefID");
            }
        }

        private String eventRefIDField; 

        /// <summary>
        /// install/pull date
        /// </summary>
		[Description("install/pull date")]
		[XmlElement("eventDate")]
        public Timestamp? EventDate {
            get {
                return eventDateField;
            } 
            set {
                eventDateField = value;
                this.EventDateSpecified = true;
                NotifyPropertyChanged("EventDate");
            }
        }

        private Timestamp? eventDateField; 

		/// <summary>
        /// eventDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EventDateSpecified {
            get {
                return eventDateSpecifiedField;
            } 
            set {
                eventDateSpecifiedField = value;
                NotifyPropertyChanged("EventDateSpecified");
            }
        }

        private Boolean eventDateSpecifiedField; 


        
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
    /// Information on collection of perforation status history
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_perforationStatusHistory", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on collection of perforation status history")]
    public partial class PerforationStatusHistory : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// perforation status
        /// </summary>
		[Description("perforation status")]
		[XmlElement("perforationStatus")]
        public PerforationStatus? PerforationStatus {
            get {
                return perforationStatusField;
            } 
            set {
                perforationStatusField = value;
                this.PerforationStatusSpecified = true;
                NotifyPropertyChanged("PerforationStatus");
            }
        }

        private PerforationStatus? perforationStatusField; 

		/// <summary>
        /// perforationStatusSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PerforationStatusSpecified {
            get {
                return perforationStatusSpecifiedField;
            } 
            set {
                perforationStatusSpecifiedField = value;
                NotifyPropertyChanged("PerforationStatusSpecified");
            }
        }

        private Boolean perforationStatusSpecifiedField; 

        /// <summary>
        /// the start date of status
        /// </summary>
		[Description("the start date of status")]
		[XmlElement("startDate")]
        public Timestamp? StartDate {
            get {
                return startDateField;
            } 
            set {
                startDateField = value;
                this.StartDateSpecified = true;
                NotifyPropertyChanged("StartDate");
            }
        }

        private Timestamp? startDateField; 

		/// <summary>
        /// startDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StartDateSpecified {
            get {
                return startDateSpecifiedField;
            } 
            set {
                startDateSpecifiedField = value;
                NotifyPropertyChanged("StartDateSpecified");
            }
        }

        private Boolean startDateSpecifiedField; 

        /// <summary>
        /// the end date of status
        /// </summary>
		[Description("the end date of status")]
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
        public Boolean EndDateSpecified {
            get {
                return endDateSpecifiedField;
            } 
            set {
                endDateSpecifiedField = value;
                NotifyPropertyChanged("EndDateSpecified");
            }
        }

        private Boolean endDateSpecifiedField; 

        /// <summary>
        /// The measured top of perforation
        /// </summary>
		[Description("The measured top of perforation")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// The measured bottom of perforation
        /// </summary>
		[Description("The measured bottom of perforation")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// defines the proportional amount of fluid from the well completion that is flowing through this interval whithin a wellbore
        /// </summary>
		[Range(0, 1)]
		[Description("defines the proportional amount of fluid from the well completion  that is flowing through this interval whithin a wellbore")]
		[XmlElement("allocationFactor")]
        public Double? AllocationFactor {
            get {
                return allocationFactorField;
            } 
            set {
                allocationFactorField = value;
                this.AllocationFactorSpecified = true;
                NotifyPropertyChanged("AllocationFactor");
            }
        }

        private Double? allocationFactorField; 

		/// <summary>
        /// allocationFactorSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AllocationFactorSpecified {
            get {
                return allocationFactorSpecifiedField;
            } 
            set {
                allocationFactorSpecifiedField = value;
                NotifyPropertyChanged("AllocationFactorSpecified");
            }
        }

        private Boolean allocationFactorSpecifiedField; 

        /// <summary>
        /// The description about the status
        /// </summary>
		[StringLength(4000)]
		[Description("The description about the status")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_perforationSetInterval xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_perforationSetInterval", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_perforationSetInterval xsd type.")]
    public partial class PerforationSetInterval : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// perforationSetRefID property
        /// </summary>
		[RegularExpression("[^ ]*")]
		[StringLength(64)]
		[XmlElement("perforationSetRefID")]
        public String PerforationSetRefID {
            get {
                return perforationSetRefIDField;
            } 
            set {
                perforationSetRefIDField = value;
                NotifyPropertyChanged("PerforationSetRefID");
            }
        }

        private String perforationSetRefIDField; 

        /// <summary>
        /// mdTop property
        /// </summary>
		[Description("Measured depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// mdBottom property
        /// </summary>
		[Description("Measured depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// tvdTop property
        /// </summary>
		[Description("True vertical depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// tvdBottom property
        /// </summary>
		[Description("True vertical depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// perforationStatusHistory property
        /// </summary>
		[Description("The contactInterval history information")]
		[RecurringElement]
		[XmlElement("perforationStatusHistory")]
        public List<PerforationStatusHistory> PerforationStatusHistory {
            get {
                return perforationStatusHistoryField;
            } 
            set {
                perforationStatusHistoryField = value;
                NotifyPropertyChanged("PerforationStatusHistory");
            }
        }

        private List<PerforationStatusHistory> perforationStatusHistoryField; 

        /// <summary>
        /// eventHistory property
        /// </summary>
		[Description("The contactInterval event information")]
		[ComponentElement]
		[XmlElement("eventHistory")]
        public EventInfo EventHistory {
            get {
                return eventHistoryField;
            } 
            set {
                eventHistoryField = value;
                NotifyPropertyChanged("EventHistory");
            }
        }

        private EventInfo eventHistoryField; 

        /// <summary>
        /// geologyFeatureRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("geologyFeatureRefID")]
        public List<String> GeologyFeatureRefID {
            get {
                return geologyFeatureRefIDField;
            } 
            set {
                geologyFeatureRefIDField = value;
                NotifyPropertyChanged("GeologyFeatureRefID");
            }
        }

        private List<String> geologyFeatureRefIDField; 

        /// <summary>
        /// extensionNameValue property
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_openHoleInterval xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_openHoleInterval", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_openHoleInterval xsd type.")]
    public partial class OpenHoleInterval : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// boreholeStringRefID property
        /// </summary>
		[RegularExpression("[^ ]*")]
		[StringLength(64)]
		[XmlElement("boreholeStringRefID")]
        public String BoreholeStringRefID {
            get {
                return boreholeStringRefIDField;
            } 
            set {
                boreholeStringRefIDField = value;
                NotifyPropertyChanged("BoreholeStringRefID");
            }
        }

        private String boreholeStringRefIDField; 

        /// <summary>
        /// mdTop property
        /// </summary>
		[Description("Measured depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// mdBottom property
        /// </summary>
		[Description("Measured depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// tvdTop property
        /// </summary>
		[Description("True vertical depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// tvdBottom property
        /// </summary>
		[Description("True vertical depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// intervalStatusHistory property
        /// </summary>
		[Description("The contactInterval history information")]
		[RecurringElement]
		[XmlElement("intervalStatusHistory")]
        public List<IntervalStatusHistory> IntervalStatusHistory {
            get {
                return intervalStatusHistoryField;
            } 
            set {
                intervalStatusHistoryField = value;
                NotifyPropertyChanged("IntervalStatusHistory");
            }
        }

        private List<IntervalStatusHistory> intervalStatusHistoryField; 

        /// <summary>
        /// eventHistory property
        /// </summary>
		[Description("The contactInterval event information")]
		[ComponentElement]
		[XmlElement("eventHistory")]
        public EventInfo EventHistory {
            get {
                return eventHistoryField;
            } 
            set {
                eventHistoryField = value;
                NotifyPropertyChanged("EventHistory");
            }
        }

        private EventInfo eventHistoryField; 

        /// <summary>
        /// geologyFeatureRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("geologyFeatureRefID")]
        public List<String> GeologyFeatureRefID {
            get {
                return geologyFeatureRefIDField;
            } 
            set {
                geologyFeatureRefIDField = value;
                NotifyPropertyChanged("GeologyFeatureRefID");
            }
        }

        private List<String> geologyFeatureRefIDField; 

        /// <summary>
        /// extensionNameValue property
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_gravelPackInterval xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_gravelPackInterval", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_gravelPackInterval xsd type.")]
    public partial class GravelPackInterval : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// downholeStringRefID property
        /// </summary>
		[RegularExpression("[^ ]*")]
		[StringLength(64)]
		[XmlElement("downholeStringRefID")]
        public String DownholeStringRefID {
            get {
                return downholeStringRefIDField;
            } 
            set {
                downholeStringRefIDField = value;
                NotifyPropertyChanged("DownholeStringRefID");
            }
        }

        private String downholeStringRefIDField; 

        /// <summary>
        /// mdTop property
        /// </summary>
		[Description("Measured depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// mdBottom property
        /// </summary>
		[Description("Measured depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// tvdTop property
        /// </summary>
		[Description("True vertical depth of the top perforation.")]
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// tvdBottom property
        /// </summary>
		[Description("True vertical depth of the bottom perforation.")]
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// intervalStatusHistory property
        /// </summary>
		[Description("The contactInterval history information")]
		[RecurringElement]
		[XmlElement("intervalStatusHistory")]
        public List<IntervalStatusHistory> IntervalStatusHistory {
            get {
                return intervalStatusHistoryField;
            } 
            set {
                intervalStatusHistoryField = value;
                NotifyPropertyChanged("IntervalStatusHistory");
            }
        }

        private List<IntervalStatusHistory> intervalStatusHistoryField; 

        /// <summary>
        /// eventHistory property
        /// </summary>
		[Description("The contactInterval event information")]
		[ComponentElement]
		[XmlElement("eventHistory")]
        public EventInfo EventHistory {
            get {
                return eventHistoryField;
            } 
            set {
                eventHistoryField = value;
                NotifyPropertyChanged("EventHistory");
            }
        }

        private EventInfo eventHistoryField; 

        /// <summary>
        /// geologyFeatureRefID property
        /// </summary>
		[StringLength(64)]
		[RecurringElement]
		[XmlElement("geologyFeatureRefID")]
        public List<String> GeologyFeatureRefID {
            get {
                return geologyFeatureRefIDField;
            } 
            set {
                geologyFeatureRefIDField = value;
                NotifyPropertyChanged("GeologyFeatureRefID");
            }
        }

        private List<String> geologyFeatureRefIDField; 

        /// <summary>
        /// extensionNameValue property
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// Information on collection of contact intervals
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_contactIntervalSet", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on collection of contact intervals")]
    public partial class ContactIntervalSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// gravelPack interval 
        /// </summary>
		[Description("gravelPack interval")]
		[RecurringElement]
		[XmlElement("gravelPackInterval")]
        public List<GravelPackInterval> GravelPackInterval {
            get {
                return gravelPackIntervalField;
            } 
            set {
                gravelPackIntervalField = value;
                NotifyPropertyChanged("GravelPackInterval");
            }
        }

        private List<GravelPackInterval> gravelPackIntervalField; 

        /// <summary>
        /// cs_openHole interval 
        /// </summary>
		[Description("cs_openHole interval")]
		[RecurringElement]
		[XmlElement("openHoleInterval")]
        public List<OpenHoleInterval> OpenHoleInterval {
            get {
                return openHoleIntervalField;
            } 
            set {
                openHoleIntervalField = value;
                NotifyPropertyChanged("OpenHoleInterval");
            }
        }

        private List<OpenHoleInterval> openHoleIntervalField; 

        /// <summary>
        /// perforation interval 
        /// </summary>
		[Description("perforation interval")]
		[RecurringElement]
		[XmlElement("perforationSetInterval")]
        public List<PerforationSetInterval> PerforationSetInterval {
            get {
                return perforationSetIntervalField;
            } 
            set {
                perforationSetIntervalField = value;
                NotifyPropertyChanged("PerforationSetInterval");
            }
        }

        private List<PerforationSetInterval> perforationSetIntervalField; 

        /// <summary>
        /// cs_slots interval 
        /// </summary>
		[Description("cs_slots interval")]
		[RecurringElement]
		[XmlElement("slotsInterval")]
        public List<SlotsInterval> SlotsInterval {
            get {
                return slotsIntervalField;
            } 
            set {
                slotsIntervalField = value;
                NotifyPropertyChanged("SlotsInterval");
            }
        }

        private List<SlotsInterval> slotsIntervalField; 


        
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
    /// This class represents the obj_wellboreCompletion xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_wellboreCompletion", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the obj_wellboreCompletion xsd type.")]
    public partial class WellboreCompletion : Object, IWellboreObject, INotifyPropertyChanged
    {

        /// <summary>
        /// nameWell property
        /// </summary>
		[Required]
		[StringLength(64)]
		[Description("Human recognizable context for the well that contains the completion.")]
		[XmlElement("nameWell")]
        public String NameWell {
            get {
                return nameWellField;
            } 
            set {
                nameWellField = value;
                NotifyPropertyChanged("NameWell");
            }
        }

        private String nameWellField; 

        /// <summary>
        /// nameWellbore property
        /// </summary>
		[Required]
		[StringLength(64)]
		[Description("Human recognizable context for the wellbore that contains the completion.")]
		[XmlElement("nameWellbore")]
        public String NameWellbore {
            get {
                return nameWellboreField;
            } 
            set {
                nameWellboreField = value;
                NotifyPropertyChanged("NameWellbore");
            }
        }

        private String nameWellboreField; 

        /// <summary>
        /// nameWellCompletion property
        /// </summary>
		[Required]
		[StringLength(64)]
		[Description("Human recognizable context for the well completion that contains the completion.")]
		[XmlElement("nameWellCompletion")]
        public String NameWellCompletion {
            get {
                return nameWellCompletionField;
            } 
            set {
                nameWellCompletionField = value;
                NotifyPropertyChanged("NameWellCompletion");
            }
        }

        private String nameWellCompletionField; 

        /// <summary>
        /// name property
        /// </summary>
		[StringLength(64)]
		[Description("Preferred name")]
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// wellboreCompletionNo property
        /// </summary>
		[StringLength(64)]
		[Description("CompletionNo, etc API14")]
		[XmlElement("wellboreCompletionNo")]
        public String WellboreCompletionNo {
            get {
                return wellboreCompletionNoField;
            } 
            set {
                wellboreCompletionNoField = value;
                NotifyPropertyChanged("WellboreCompletionNo");
            }
        }

        private String wellboreCompletionNoField; 

        /// <summary>
        /// wellboreCompletionAlias property
        /// </summary>
		[StringLength(64)]
		[Description("Preferred alias name")]
		[XmlElement("wellboreCompletionAlias")]
        public String WellboreCompletionAlias {
            get {
                return wellboreCompletionAliasField;
            } 
            set {
                wellboreCompletionAliasField = value;
                NotifyPropertyChanged("WellboreCompletionAlias");
            }
        }

        private String wellboreCompletionAliasField; 

        /// <summary>
        /// evenHistory property
        /// </summary>
		[RecurringElement]
		[XmlElement("evenHistory")]
        public List<EventInfo> EvenHistory {
            get {
                return evenHistoryField;
            } 
            set {
                evenHistoryField = value;
                NotifyPropertyChanged("EvenHistory");
            }
        }

        private List<EventInfo> evenHistoryField; 

        /// <summary>
        /// wellboreCompletionDate property
        /// </summary>
		[Description("Completion Date")]
		[XmlElement("wellboreCompletionDate")]
        public Timestamp? WellboreCompletionDate {
            get {
                return wellboreCompletionDateField;
            } 
            set {
                wellboreCompletionDateField = value;
                this.WellboreCompletionDateSpecified = true;
                NotifyPropertyChanged("WellboreCompletionDate");
            }
        }

        private Timestamp? wellboreCompletionDateField; 

		/// <summary>
        /// wellboreCompletionDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean WellboreCompletionDateSpecified {
            get {
                return wellboreCompletionDateSpecifiedField;
            } 
            set {
                wellboreCompletionDateSpecifiedField = value;
                NotifyPropertyChanged("WellboreCompletionDateSpecified");
            }
        }

        private Boolean wellboreCompletionDateSpecifiedField; 

        /// <summary>
        /// suffixAPI property
        /// </summary>
		[StringLength(64)]
		[Description("API suffix.")]
		[XmlElement("suffixAPI")]
        public String SuffixAPI {
            get {
                return suffixAPIField;
            } 
            set {
                suffixAPIField = value;
                NotifyPropertyChanged("SuffixAPI");
            }
        }

        private String suffixAPIField; 

        /// <summary>
        /// mdTop property
        /// </summary>
		[Description("Measured depth at top of interval.")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// mdBottom property
        /// </summary>
		[Description("Measured depth at base of interval.")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// tvdTop property
        /// </summary>
		[Description("True vertical depth at top of the section.")]
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// tvdBottom property
        /// </summary>
		[Description("True vertical depth at bottom of the section.")]
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// currentStatus property
        /// </summary>
		
		[XmlElement("currentStatus")]
        public CompletionStatus? CurrentStatus {
            get {
                return currentStatusField;
            } 
            set {
                currentStatusField = value;
                this.CurrentStatusSpecified = true;
                NotifyPropertyChanged("CurrentStatus");
            }
        }

        private CompletionStatus? currentStatusField; 

		/// <summary>
        /// currentStatusSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CurrentStatusSpecified {
            get {
                return currentStatusSpecifiedField;
            } 
            set {
                currentStatusSpecifiedField = value;
                NotifyPropertyChanged("CurrentStatusSpecified");
            }
        }

        private Boolean currentStatusSpecifiedField; 

        /// <summary>
        /// statusDate property
        /// </summary>
		
		[XmlElement("statusDate")]
        public Timestamp? StatusDate {
            get {
                return statusDateField;
            } 
            set {
                statusDateField = value;
                this.StatusDateSpecified = true;
                NotifyPropertyChanged("StatusDate");
            }
        }

        private Timestamp? statusDateField; 

		/// <summary>
        /// statusDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusDateSpecified {
            get {
                return statusDateSpecifiedField;
            } 
            set {
                statusDateSpecifiedField = value;
                NotifyPropertyChanged("StatusDateSpecified");
            }
        }

        private Boolean statusDateSpecifiedField; 

        /// <summary>
        /// statusHistory property
        /// </summary>
		[RecurringElement]
		[XmlElement("statusHistory")]
        public List<CompletionStatusHistory> StatusHistory {
            get {
                return statusHistoryField;
            } 
            set {
                statusHistoryField = value;
                NotifyPropertyChanged("StatusHistory");
            }
        }

        private List<CompletionStatusHistory> statusHistoryField; 

        /// <summary>
        /// contactIntervalSet property
        /// </summary>
		[Description("A collection of contact interval information")]
		[ComponentElement]
		[XmlElement("contactIntervalSet")]
        public ContactIntervalSet ContactIntervalSet {
            get {
                return contactIntervalSetField;
            } 
            set {
                contactIntervalSetField = value;
                NotifyPropertyChanged("ContactIntervalSet");
            }
        }

        private ContactIntervalSet contactIntervalSetField; 

        /// <summary>
        /// A container element that contains elements that are common to all data objects.
        /// </summary>
		[Description("A container element that contains elements that are common to all data objects.")]
		[ComponentElement]
		[XmlElement("commonData")]
        public CommonData CommonData {
            get {
                return commonDataField;
            } 
            set {
                commonDataField = value;
                NotifyPropertyChanged("CommonData");
            }
        }

        private CommonData commonDataField; 

        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
		[Description("A container element that can contain custom or user defined data elements.")]
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
        /// Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell. 
        /// </summary>
		[Description("Unique identifier for the well. This uniquely represents  the well referenced by the (possibly non-unique) nameWell.")]
        [XmlAttribute("uidWell")]
		
        public String UidWell {
            get {
                return uidWellField;
            } 
            set {
                uidWellField = value;
                NotifyPropertyChanged("UidWell");
            }
        }

        private String uidWellField; 

		/// <summary>
        /// Unique identifier for the wellbore.. 
        /// </summary>
		[Description("Unique identifier for the wellbore..")]
        [XmlAttribute("uidWellbore")]
		
        public String UidWellbore {
            get {
                return uidWellboreField;
            } 
            set {
                uidWellboreField = value;
                NotifyPropertyChanged("UidWellbore");
            }
        }

        private String uidWellboreField; 

		/// <summary>
        /// Unique identifier for the well completion. 
        /// </summary>
		[Description("Unique identifier for the well completion.")]
        [XmlAttribute("uidWellCompletion")]
		
        public String UidWellCompletion {
            get {
                return uidWellCompletionField;
            } 
            set {
                uidWellCompletionField = value;
                NotifyPropertyChanged("UidWellCompletion");
            }
        }

        private String uidWellCompletionField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_perforationSet xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_perforationSet", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_perforationSet xsd type.")]
    public partial class PerforationSet : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// perforation on borehole String
        /// </summary>
		[RecurringElement]
		[XmlElement("boreholeStringRefID")]
        public List<String> BoreholeStringRefID {
            get {
                return boreholeStringRefIDField;
            } 
            set {
                boreholeStringRefIDField = value;
                NotifyPropertyChanged("BoreholeStringRefID");
            }
        }

        private List<String> boreholeStringRefIDField; 

        /// <summary>
        /// perforation on downholeStringRefID
        /// </summary>
		[RecurringElement]
		[XmlElement("downholeStringRefID")]
        public List<String> DownholeStringRefID {
            get {
                return downholeStringRefIDField;
            } 
            set {
                downholeStringRefIDField = value;
                NotifyPropertyChanged("DownholeStringRefID");
            }
        }

        private List<String> downholeStringRefIDField; 

        /// <summary>
        /// The contactInterval event information
        /// </summary>
		[ComponentElement]
		[XmlElement("eventHistory")]
        public EventInfo EventHistory {
            get {
                return eventHistoryField;
            } 
            set {
                eventHistoryField = value;
                NotifyPropertyChanged("EventHistory");
            }
        }

        private EventInfo eventHistoryField; 

        /// <summary>
        /// The measured top depth of the hole
        /// </summary>
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// The measured bottom of the hole
        /// </summary>
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// True vertical depth of the top perforation.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// True vertical depth of the bottom perforation.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// The diameter of the hole
        /// </summary>
		[ComponentElement]
		[XmlElement("holeDiameter")]
        public LengthMeasure HoleDiameter {
            get {
                return holeDiameterField;
            } 
            set {
                holeDiameterField = value;
                NotifyPropertyChanged("HoleDiameter");
            }
        }

        private LengthMeasure holeDiameterField; 

        /// <summary>
        /// The angle of the holes
        /// </summary>
		[ComponentElement]
		[XmlElement("holeAngle")]
        public PlaneAngleMeasure HoleAngle {
            get {
                return holeAngleField;
            } 
            set {
                holeAngleField = value;
                NotifyPropertyChanged("HoleAngle");
            }
        }

        private PlaneAngleMeasure holeAngleField; 

        /// <summary>
        /// The pattern of the holes
        /// </summary>
		
		[XmlElement("holePattern")]
        public String HolePattern {
            get {
                return holePatternField;
            } 
            set {
                holePatternField = value;
                NotifyPropertyChanged("HolePattern");
            }
        }

        private String holePatternField; 

        /// <summary>
        /// The density of the holes
        /// </summary>
		[ComponentElement]
		[XmlElement("holeDensity")]
        public PerLengthMeasure HoleDensity {
            get {
                return holeDensityField;
            } 
            set {
                holeDensityField = value;
                NotifyPropertyChanged("HoleDensity");
            }
        }

        private PerLengthMeasure holeDensityField; 

        /// <summary>
        /// The number of holes
        /// </summary>
		
		[XmlElement("holeCount")]
        public Int16? HoleCount {
            get {
                return holeCountField;
            } 
            set {
                holeCountField = value;
                this.HoleCountSpecified = true;
                NotifyPropertyChanged("HoleCount");
            }
        }

        private Int16? holeCountField; 

		/// <summary>
        /// holeCountSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean HoleCountSpecified {
            get {
                return holeCountSpecifiedField;
            } 
            set {
                holeCountSpecifiedField = value;
                NotifyPropertyChanged("HoleCountSpecified");
            }
        }

        private Boolean holeCountSpecifiedField; 

        /// <summary>
        /// The friction factor of each perforation set.
        /// </summary>
		
		[XmlElement("frictionFactor")]
        public Double? FrictionFactor {
            get {
                return frictionFactorField;
            } 
            set {
                frictionFactorField = value;
                this.FrictionFactorSpecified = true;
                NotifyPropertyChanged("FrictionFactor");
            }
        }

        private Double? frictionFactorField; 

		/// <summary>
        /// frictionFactorSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean FrictionFactorSpecified {
            get {
                return frictionFactorSpecifiedField;
            } 
            set {
                frictionFactorSpecifiedField = value;
                NotifyPropertyChanged("FrictionFactorSpecified");
            }
        }

        private Boolean frictionFactorSpecifiedField; 

        /// <summary>
        /// The friction pressure for the perforation set.
        /// </summary>
		[ComponentElement]
		[XmlElement("frictionPres")]
        public PressureMeasure FrictionPres {
            get {
                return frictionPresField;
            } 
            set {
                frictionPresField = value;
                NotifyPropertyChanged("FrictionPres");
            }
        }

        private PressureMeasure frictionPresField; 

        /// <summary>
        /// A coefficient used in the equation for calculation of pressure drop across a perforation set.
        /// </summary>
		
		[XmlElement("dischargeCoefficient")]
        public Double? DischargeCoefficient {
            get {
                return dischargeCoefficientField;
            } 
            set {
                dischargeCoefficientField = value;
                this.DischargeCoefficientSpecified = true;
                NotifyPropertyChanged("DischargeCoefficient");
            }
        }

        private Double? dischargeCoefficientField; 

		/// <summary>
        /// dischargeCoefficientSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DischargeCoefficientSpecified {
            get {
                return dischargeCoefficientSpecifiedField;
            } 
            set {
                dischargeCoefficientSpecifiedField = value;
                NotifyPropertyChanged("DischargeCoefficientSpecified");
            }
        }

        private Boolean dischargeCoefficientSpecifiedField; 

        /// <summary>
        ///  The type of perforation tool.
        /// </summary>
		
		[XmlElement("perforationTool")]
        public PerforationToolType? PerforationTool {
            get {
                return perforationToolField;
            } 
            set {
                perforationToolField = value;
                this.PerforationToolSpecified = true;
                NotifyPropertyChanged("PerforationTool");
            }
        }

        private PerforationToolType? perforationToolField; 

		/// <summary>
        /// perforationToolSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PerforationToolSpecified {
            get {
                return perforationToolSpecifiedField;
            } 
            set {
                perforationToolSpecifiedField = value;
                NotifyPropertyChanged("PerforationToolSpecified");
            }
        }

        private Boolean perforationToolSpecifiedField; 

        /// <summary>
        /// The Penetration length of perforation.
        /// </summary>
		[ComponentElement]
		[XmlElement("perforationPenetration")]
        public LengthMeasure PerforationPenetration {
            get {
                return perforationPenetrationField;
            } 
            set {
                perforationPenetrationField = value;
                NotifyPropertyChanged("PerforationPenetration");
            }
        }

        private LengthMeasure perforationPenetrationField; 

        /// <summary>
        /// The diameter of crushed zone
        /// </summary>
		[ComponentElement]
		[XmlElement("crushZoneDiameter")]
        public LengthMeasure CrushZoneDiameter {
            get {
                return crushZoneDiameterField;
            } 
            set {
                crushZoneDiameterField = value;
                NotifyPropertyChanged("CrushZoneDiameter");
            }
        }

        private LengthMeasure crushZoneDiameterField; 

        /// <summary>
        /// The ratio value of cursh damage
        /// </summary>
		
		[XmlElement("crushDamageRatio")]
        public String CrushDamageRatio {
            get {
                return crushDamageRatioField;
            } 
            set {
                crushDamageRatioField = value;
                NotifyPropertyChanged("CrushDamageRatio");
            }
        }

        private String crushDamageRatioField; 

        /// <summary>
        /// The original perforation date
        /// </summary>
		
		[XmlElement("perforationDate")]
        public DateTime? PerforationDate {
            get {
                return perforationDateField;
            } 
            set {
                perforationDateField = value;
                this.PerforationDateSpecified = true;
                NotifyPropertyChanged("PerforationDate");
            }
        }

        private DateTime? perforationDateField; 

		/// <summary>
        /// perforationDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PerforationDateSpecified {
            get {
                return perforationDateSpecifiedField;
            } 
            set {
                perforationDateSpecifiedField = value;
                NotifyPropertyChanged("PerforationDateSpecified");
            }
        }

        private Boolean perforationDateSpecifiedField; 

        /// <summary>
        /// Remarks regarding this perforationSet
        /// </summary>
		
		[XmlElement("permanentRemarks")]
        public String PermanentRemarks {
            get {
                return permanentRemarksField;
            } 
            set {
                permanentRemarksField = value;
                NotifyPropertyChanged("PermanentRemarks");
            }
        }

        private String permanentRemarksField; 

		/// <summary>
        /// uid property
        /// </summary>
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// Information on the perforated hole
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_perfHole", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on the perforated hole")]
    public partial class PerfHole : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The measured top depth of the hole
        /// </summary>
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// The measured bottom of the hole
        /// </summary>
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// True vertical depth of the top perforation.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// True vertical depth of the bottom perforation.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// The diameter of the hole
        /// </summary>
		[ComponentElement]
		[XmlElement("holeDiameter")]
        public LengthMeasure HoleDiameter {
            get {
                return holeDiameterField;
            } 
            set {
                holeDiameterField = value;
                NotifyPropertyChanged("HoleDiameter");
            }
        }

        private LengthMeasure holeDiameterField; 

        /// <summary>
        /// The angle of the holes
        /// </summary>
		[ComponentElement]
		[XmlElement("holeAngle")]
        public PlaneAngleMeasure HoleAngle {
            get {
                return holeAngleField;
            } 
            set {
                holeAngleField = value;
                NotifyPropertyChanged("HoleAngle");
            }
        }

        private PlaneAngleMeasure holeAngleField; 

        /// <summary>
        /// The pattern of the holes
        /// </summary>
		
		[XmlElement("holePattern")]
        public String HolePattern {
            get {
                return holePatternField;
            } 
            set {
                holePatternField = value;
                NotifyPropertyChanged("HolePattern");
            }
        }

        private String holePatternField; 

        /// <summary>
        /// The density of the holes
        /// </summary>
		[ComponentElement]
		[XmlElement("holeDensity")]
        public PerLengthMeasure HoleDensity {
            get {
                return holeDensityField;
            } 
            set {
                holeDensityField = value;
                NotifyPropertyChanged("HoleDensity");
            }
        }

        private PerLengthMeasure holeDensityField; 

        /// <summary>
        /// The number of holes
        /// </summary>
		
		[XmlElement("holeCount")]
        public Int16? HoleCount {
            get {
                return holeCountField;
            } 
            set {
                holeCountField = value;
                this.HoleCountSpecified = true;
                NotifyPropertyChanged("HoleCount");
            }
        }

        private Int16? holeCountField; 

		/// <summary>
        /// holeCountSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean HoleCountSpecified {
            get {
                return holeCountSpecifiedField;
            } 
            set {
                holeCountSpecifiedField = value;
                NotifyPropertyChanged("HoleCountSpecified");
            }
        }

        private Boolean holeCountSpecifiedField; 

        /// <summary>
        /// Remarks regarding this perforated hole
        /// </summary>
		
		[XmlElement("remarks")]
        public String Remarks {
            get {
                return remarksField;
            } 
            set {
                remarksField = value;
                NotifyPropertyChanged("Remarks");
            }
        }

        private String remarksField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Information on slot resulting from perforation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_perfSlot", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on slot resulting from perforation")]
    public partial class PerfSlot : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The height of slot
        /// </summary>
		[ComponentElement]
		[XmlElement("slotHeight")]
        public LengthMeasure SlotHeight {
            get {
                return slotHeightField;
            } 
            set {
                slotHeightField = value;
                NotifyPropertyChanged("SlotHeight");
            }
        }

        private LengthMeasure slotHeightField; 

        /// <summary>
        /// The width of the slot
        /// </summary>
		[ComponentElement]
		[XmlElement("slotWidth")]
        public LengthMeasure SlotWidth {
            get {
                return slotWidthField;
            } 
            set {
                slotWidthField = value;
                NotifyPropertyChanged("SlotWidth");
            }
        }

        private LengthMeasure slotWidthField; 

        /// <summary>
        /// Distance from center point
        /// </summary>
		[ComponentElement]
		[XmlElement("slotCenterDistance")]
        public LengthMeasure SlotCenterDistance {
            get {
                return slotCenterDistanceField;
            } 
            set {
                slotCenterDistanceField = value;
                NotifyPropertyChanged("SlotCenterDistance");
            }
        }

        private LengthMeasure slotCenterDistanceField; 

        /// <summary>
        /// The number of the slot
        /// </summary>
		
		[XmlElement("slotCount")]
        public Int16? SlotCount {
            get {
                return slotCountField;
            } 
            set {
                slotCountField = value;
                this.SlotCountSpecified = true;
                NotifyPropertyChanged("SlotCount");
            }
        }

        private Int16? slotCountField; 

		/// <summary>
        /// slotCountSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SlotCountSpecified {
            get {
                return slotCountSpecifiedField;
            } 
            set {
                slotCountSpecifiedField = value;
                NotifyPropertyChanged("SlotCountSpecified");
            }
        }

        private Boolean slotCountSpecifiedField; 

        /// <summary>
        /// Remarks regarding this perforation slot
        /// </summary>
		
		[XmlElement("remarks")]
        public String Remarks {
            get {
                return remarksField;
            } 
            set {
                remarksField = value;
                NotifyPropertyChanged("Remarks");
            }
        }

        private String remarksField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 


        
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
    /// Name-value extensions for the equipment property
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_extPropNameValue", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Name-value extensions for the equipment property")]
    public partial class ExtPropNameValue : Object, INotifyPropertyChanged
    {

        /// <summary>
        ///  A string representing the name of property.
        /// </summary>
		
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        ///  A value string representing the units of measure of the value.
        /// </summary>
		[ComponentElement]
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
    /// This class represents the cs_equipment xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_equipment", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_equipment xsd type.")]
    public partial class Equipment : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The name of the piece of equipment.
        /// </summary>
		
		[XmlElement("equipmentName")]
        public String EquipmentName {
            get {
                return equipmentNameField;
            } 
            set {
                equipmentNameField = value;
                NotifyPropertyChanged("EquipmentName");
            }
        }

        private String equipmentNameField; 

        /// <summary>
        /// The equipment type etc. bridge plug, bull plug. capillary tubing..
        /// </summary>
		
		[XmlElement("equipmentType")]
        public EquipmentType? EquipmentType {
            get {
                return equipmentTypeField;
            } 
            set {
                equipmentTypeField = value;
                NotifyPropertyChanged("EquipmentType");
            }
        }

        private EquipmentType? equipmentTypeField; 

        /// <summary>
        /// manufacturer property
        /// </summary>
		
		[XmlElement("manufacturer")]
        public String Manufacturer {
            get {
                return manufacturerField;
            } 
            set {
                manufacturerField = value;
                NotifyPropertyChanged("Manufacturer");
            }
        }

        private String manufacturerField; 

        /// <summary>
        /// model property
        /// </summary>
		
		[XmlElement("model")]
        public String Model {
            get {
                return modelField;
            } 
            set {
                modelField = value;
                NotifyPropertyChanged("Model");
            }
        }

        private String modelField; 

        /// <summary>
        /// catalogID property
        /// </summary>
		
		[XmlElement("catalogID")]
        public String CatalogID {
            get {
                return catalogIDField;
            } 
            set {
                catalogIDField = value;
                NotifyPropertyChanged("CatalogID");
            }
        }

        private String catalogIDField; 

        /// <summary>
        /// catalogName property
        /// </summary>
		
		[XmlElement("catalogName")]
        public String CatalogName {
            get {
                return catalogNameField;
            } 
            set {
                catalogNameField = value;
                NotifyPropertyChanged("CatalogName");
            }
        }

        private String catalogNameField; 

        /// <summary>
        /// brandName property
        /// </summary>
		
		[XmlElement("brandName")]
        public String BrandName {
            get {
                return brandNameField;
            } 
            set {
                brandNameField = value;
                NotifyPropertyChanged("BrandName");
            }
        }

        private String brandNameField; 

        /// <summary>
        /// modelType property
        /// </summary>
		
		[XmlElement("modelType")]
        public String ModelType {
            get {
                return modelTypeField;
            } 
            set {
                modelTypeField = value;
                NotifyPropertyChanged("ModelType");
            }
        }

        private String modelTypeField; 

        /// <summary>
        /// series property
        /// </summary>
		
		[XmlElement("series")]
        public String Series {
            get {
                return seriesField;
            } 
            set {
                seriesField = value;
                NotifyPropertyChanged("Series");
            }
        }

        private String seriesField; 

        /// <summary>
        /// isSerialized property
        /// </summary>
		
		[XmlElement("isSerialized")]
        public Boolean? IsSerialized {
            get {
                return isSerializedField;
            } 
            set {
                isSerializedField = value;
                this.IsSerializedSpecified = true;
                NotifyPropertyChanged("IsSerialized");
            }
        }

        private Boolean? isSerializedField; 

		/// <summary>
        /// isSerializedSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsSerializedSpecified {
            get {
                return isSerializedSpecifiedField;
            } 
            set {
                isSerializedSpecifiedField = value;
                NotifyPropertyChanged("IsSerializedSpecified");
            }
        }

        private Boolean isSerializedSpecifiedField; 

        /// <summary>
        /// serialNumber property
        /// </summary>
		
		[XmlElement("serialNumber")]
        public String SerialNumber {
            get {
                return serialNumberField;
            } 
            set {
                serialNumberField = value;
                NotifyPropertyChanged("SerialNumber");
            }
        }

        private String serialNumberField; 

        /// <summary>
        /// partNo property
        /// </summary>
		
		[XmlElement("partNo")]
        public String PartNo {
            get {
                return partNoField;
            } 
            set {
                partNoField = value;
                NotifyPropertyChanged("PartNo");
            }
        }

        private String partNoField; 

        /// <summary>
        /// surfaceCondition property
        /// </summary>
		
		[XmlElement("surfaceCondition")]
        public String SurfaceCondition {
            get {
                return surfaceConditionField;
            } 
            set {
                surfaceConditionField = value;
                NotifyPropertyChanged("SurfaceCondition");
            }
        }

        private String surfaceConditionField; 

        /// <summary>
        /// material property
        /// </summary>
		
		[XmlElement("material")]
        public String Material {
            get {
                return materialField;
            } 
            set {
                materialField = value;
                NotifyPropertyChanged("Material");
            }
        }

        private String materialField; 

        /// <summary>
        /// grade property
        /// </summary>
		
		[XmlElement("grade")]
        public GradeType? Grade {
            get {
                return gradeField;
            } 
            set {
                gradeField = value;
                this.GradeSpecified = true;
                NotifyPropertyChanged("Grade");
            }
        }

        private GradeType? gradeField; 

		/// <summary>
        /// gradeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GradeSpecified {
            get {
                return gradeSpecifiedField;
            } 
            set {
                gradeSpecifiedField = value;
                NotifyPropertyChanged("GradeSpecified");
            }
        }

        private Boolean gradeSpecifiedField; 

        /// <summary>
        /// unitWeight property
        /// </summary>
		[ComponentElement]
		[XmlElement("unitWeight")]
        public MassPerLengthMeasure UnitWeight {
            get {
                return unitWeightField;
            } 
            set {
                unitWeightField = value;
                NotifyPropertyChanged("UnitWeight");
            }
        }

        private MassPerLengthMeasure unitWeightField; 

        /// <summary>
        /// coatingLinerapplied property
        /// </summary>
		
		[XmlElement("coatingLinerapplied")]
        public Boolean? CoatingLinerapplied {
            get {
                return coatingLinerappliedField;
            } 
            set {
                coatingLinerappliedField = value;
                this.CoatingLinerappliedSpecified = true;
                NotifyPropertyChanged("CoatingLinerapplied");
            }
        }

        private Boolean? coatingLinerappliedField; 

		/// <summary>
        /// coatingLinerappliedSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CoatingLinerappliedSpecified {
            get {
                return coatingLinerappliedSpecifiedField;
            } 
            set {
                coatingLinerappliedSpecifiedField = value;
                NotifyPropertyChanged("CoatingLinerappliedSpecified");
            }
        }

        private Boolean coatingLinerappliedSpecifiedField; 

        /// <summary>
        /// outsideCoating property
        /// </summary>
		
		[XmlElement("outsideCoating")]
        public Coating? OutsideCoating {
            get {
                return outsideCoatingField;
            } 
            set {
                outsideCoatingField = value;
                this.OutsideCoatingSpecified = true;
                NotifyPropertyChanged("OutsideCoating");
            }
        }

        private Coating? outsideCoatingField; 

		/// <summary>
        /// outsideCoatingSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean OutsideCoatingSpecified {
            get {
                return outsideCoatingSpecifiedField;
            } 
            set {
                outsideCoatingSpecifiedField = value;
                NotifyPropertyChanged("OutsideCoatingSpecified");
            }
        }

        private Boolean outsideCoatingSpecifiedField; 

        /// <summary>
        /// insideCoating property
        /// </summary>
		
		[XmlElement("insideCoating")]
        public Coating? InsideCoating {
            get {
                return insideCoatingField;
            } 
            set {
                insideCoatingField = value;
                this.InsideCoatingSpecified = true;
                NotifyPropertyChanged("InsideCoating");
            }
        }

        private Coating? insideCoatingField; 

		/// <summary>
        /// insideCoatingSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean InsideCoatingSpecified {
            get {
                return insideCoatingSpecifiedField;
            } 
            set {
                insideCoatingSpecifiedField = value;
                NotifyPropertyChanged("InsideCoatingSpecified");
            }
        }

        private Boolean insideCoatingSpecifiedField; 

        /// <summary>
        /// unitLength property
        /// </summary>
		[ComponentElement]
		[XmlElement("unitLength")]
        public LengthMeasure UnitLength {
            get {
                return unitLengthField;
            } 
            set {
                unitLengthField = value;
                NotifyPropertyChanged("UnitLength");
            }
        }

        private LengthMeasure unitLengthField; 

        /// <summary>
        /// majorOD property
        /// </summary>
		[ComponentElement]
		[XmlElement("majorOD")]
        public LengthMeasure MajorOD {
            get {
                return majorODField;
            } 
            set {
                majorODField = value;
                NotifyPropertyChanged("MajorOD");
            }
        }

        private LengthMeasure majorODField; 

        /// <summary>
        /// minorOD property
        /// </summary>
		[ComponentElement]
		[XmlElement("minorOD")]
        public LengthMeasure MinorOD {
            get {
                return minorODField;
            } 
            set {
                minorODField = value;
                NotifyPropertyChanged("MinorOD");
            }
        }

        private LengthMeasure minorODField; 

        /// <summary>
        /// OD property
        /// </summary>
		[ComponentElement]
		[XmlElement("OD")]
        public LengthMeasure OD {
            get {
                return ODField;
            } 
            set {
                ODField = value;
                NotifyPropertyChanged("OD");
            }
        }

        private LengthMeasure ODField; 

        /// <summary>
        /// MaxOD property
        /// </summary>
		[ComponentElement]
		[XmlElement("MaxOD")]
        public LengthMeasure MaxOD {
            get {
                return MaxODField;
            } 
            set {
                MaxODField = value;
                NotifyPropertyChanged("MaxOD");
            }
        }

        private LengthMeasure MaxODField; 

        /// <summary>
        /// MinOD property
        /// </summary>
		[ComponentElement]
		[XmlElement("MinOD")]
        public LengthMeasure MinOD {
            get {
                return MinODField;
            } 
            set {
                MinODField = value;
                NotifyPropertyChanged("MinOD");
            }
        }

        private LengthMeasure MinODField; 

        /// <summary>
        /// majorID property
        /// </summary>
		[ComponentElement]
		[XmlElement("majorID")]
        public LengthMeasure MajorID {
            get {
                return majorIDField;
            } 
            set {
                majorIDField = value;
                NotifyPropertyChanged("MajorID");
            }
        }

        private LengthMeasure majorIDField; 

        /// <summary>
        /// minorID property
        /// </summary>
		[ComponentElement]
		[XmlElement("minorID")]
        public LengthMeasure MinorID {
            get {
                return minorIDField;
            } 
            set {
                minorIDField = value;
                NotifyPropertyChanged("MinorID");
            }
        }

        private LengthMeasure minorIDField; 

        /// <summary>
        /// ID property
        /// </summary>
		[ComponentElement]
		[XmlElement("ID")]
        public LengthMeasure ID {
            get {
                return IDField;
            } 
            set {
                IDField = value;
                NotifyPropertyChanged("ID");
            }
        }

        private LengthMeasure IDField; 

        /// <summary>
        /// MaxID property
        /// </summary>
		[ComponentElement]
		[XmlElement("MaxID")]
        public LengthMeasure MaxID {
            get {
                return MaxIDField;
            } 
            set {
                MaxIDField = value;
                NotifyPropertyChanged("MaxID");
            }
        }

        private LengthMeasure MaxIDField; 

        /// <summary>
        /// MinID property
        /// </summary>
		[ComponentElement]
		[XmlElement("MinID")]
        public LengthMeasure MinID {
            get {
                return MinIDField;
            } 
            set {
                MinIDField = value;
                NotifyPropertyChanged("MinID");
            }
        }

        private LengthMeasure MinIDField; 

        /// <summary>
        /// drift property
        /// </summary>
		[ComponentElement]
		[XmlElement("drift")]
        public LengthMeasure Drift {
            get {
                return driftField;
            } 
            set {
                driftField = value;
                NotifyPropertyChanged("Drift");
            }
        }

        private LengthMeasure driftField; 

        /// <summary>
        /// nominalSize property
        /// </summary>
		[ComponentElement]
		[XmlElement("nominalSize")]
        public LengthMeasure NominalSize {
            get {
                return nominalSizeField;
            } 
            set {
                nominalSizeField = value;
                NotifyPropertyChanged("NominalSize");
            }
        }

        private LengthMeasure nominalSizeField; 

        /// <summary>
        /// nameService property
        /// </summary>
		
		[XmlElement("nameService")]
        public String NameService {
            get {
                return nameServiceField;
            } 
            set {
                nameServiceField = value;
                NotifyPropertyChanged("NameService");
            }
        }

        private String nameServiceField; 

        /// <summary>
        /// description property
        /// </summary>
		
		[XmlElement("description")]
        public String Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private String descriptionField; 

        /// <summary>
        /// descriptionPermanent property
        /// </summary>
		
		[XmlElement("descriptionPermanent")]
        public String DescriptionPermanent {
            get {
                return descriptionPermanentField;
            } 
            set {
                descriptionPermanentField = value;
                NotifyPropertyChanged("DescriptionPermanent");
            }
        }

        private String descriptionPermanentField; 

        /// <summary>
        /// remark property
        /// </summary>
		
		[XmlElement("remark")]
        public String Remark {
            get {
                return remarkField;
            } 
            set {
                remarkField = value;
                NotifyPropertyChanged("Remark");
            }
        }

        private String remarkField; 

        /// <summary>
        /// Property description
        /// </summary>
		[RecurringElement]
		[XmlElement("property")]
        public List<ExtPropNameValue> Property {
            get {
                return propertyField;
            } 
            set {
                propertyField = value;
                NotifyPropertyChanged("Property");
            }
        }

        private List<ExtPropNameValue> propertyField; 

        /// <summary>
        /// Describes the slot in equipment.
        /// </summary>
		[RecurringElement]
		[XmlElement("slotAsManufactured")]
        public List<PerfSlot> SlotAsManufactured {
            get {
                return slotAsManufacturedField;
            } 
            set {
                slotAsManufacturedField = value;
                NotifyPropertyChanged("SlotAsManufactured");
            }
        }

        private List<PerfSlot> slotAsManufacturedField; 

        /// <summary>
        /// Describes the hole in equipment.
        /// </summary>
		[RecurringElement]
		[XmlElement("holeAsManufactured")]
        public List<PerfHole> HoleAsManufactured {
            get {
                return holeAsManufacturedField;
            } 
            set {
                holeAsManufacturedField = value;
                NotifyPropertyChanged("HoleAsManufactured");
            }
        }

        private List<PerfHole> holeAsManufacturedField; 

        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// Geology features found in the location of the borehole string.  
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_geologyFeature", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Geology features found in the location of the borehole string.  ")]
    public partial class GeologyFeature : Object, IDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Name of the feature
        /// </summary>
		
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// Aquifer or reservoir
        /// </summary>
		
		[XmlElement("geologyType")]
        public GeologyType? GeologyType {
            get {
                return geologyTypeField;
            } 
            set {
                geologyTypeField = value;
                this.GeologyTypeSpecified = true;
                NotifyPropertyChanged("GeologyType");
            }
        }

        private GeologyType? geologyTypeField; 

		/// <summary>
        /// geologyTypeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GeologyTypeSpecified {
            get {
                return geologyTypeSpecifiedField;
            } 
            set {
                geologyTypeSpecifiedField = value;
                NotifyPropertyChanged("GeologyTypeSpecified");
            }
        }

        private Boolean geologyTypeSpecifiedField; 

        /// <summary>
        /// Measured depth at top of interval.
        /// </summary>
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// Measured depth at base of interval.
        /// </summary>
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// True vertical depth at top of the section.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// True vertical depth at bottom of the section.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// True vertical depth at base of interval.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdBase")]
        public WellVerticalDepthCoord TvdBase {
            get {
                return tvdBaseField;
            } 
            set {
                tvdBaseField = value;
                NotifyPropertyChanged("TvdBase");
            }
        }

        private WellVerticalDepthCoord tvdBaseField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// Information on the borehole
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_borehole", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on the borehole")]
    public partial class Borehole : Object, IDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// The name of borehole
        /// </summary>
		
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// Type of borehole. etc. Cavern, cavity, NormalBorehole,UnderReam
        /// </summary>
		
		[XmlElement("typeBorehole")]
        public BoreholeType? TypeBorehole {
            get {
                return typeBoreholeField;
            } 
            set {
                typeBoreholeField = value;
                this.TypeBoreholeSpecified = true;
                NotifyPropertyChanged("TypeBorehole");
            }
        }

        private BoreholeType? typeBoreholeField; 

		/// <summary>
        /// typeBoreholeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TypeBoreholeSpecified {
            get {
                return typeBoreholeSpecifiedField;
            } 
            set {
                typeBoreholeSpecifiedField = value;
                NotifyPropertyChanged("TypeBoreholeSpecified");
            }
        }

        private Boolean typeBoreholeSpecifiedField; 

        /// <summary>
        /// Event reference pointing to the eventledger.
        /// </summary>
		[ComponentElement]
		[XmlElement("equipmentEventHistory")]
        public EventInfo EquipmentEventHistory {
            get {
                return equipmentEventHistoryField;
            } 
            set {
                equipmentEventHistoryField = value;
                NotifyPropertyChanged("EquipmentEventHistory");
            }
        }

        private EventInfo equipmentEventHistoryField; 

        /// <summary>
        /// Measured depth at Top of Interval
        /// </summary>
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// Measured depth at bottom of the section
        /// </summary>
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// True vertical depth at top of the section
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// True vertical depth at bottom of the section
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// Borehole diameter
        /// </summary>
		[ComponentElement]
		[XmlElement("diaBorehole")]
        public LengthMeasure DiaBorehole {
            get {
                return diaBoreholeField;
            } 
            set {
                diaBoreholeField = value;
                NotifyPropertyChanged("DiaBorehole");
            }
        }

        private LengthMeasure diaBoreholeField; 

        /// <summary>
        /// The description of this equipment to be permanently kept.
        /// </summary>
		
		[XmlElement("descriptionPermanent")]
        public String DescriptionPermanent {
            get {
                return descriptionPermanentField;
            } 
            set {
                descriptionPermanentField = value;
                NotifyPropertyChanged("DescriptionPermanent");
            }
        }

        private String descriptionPermanentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_boreholeString xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_boreholeString", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_boreholeString xsd type.")]
    public partial class BoreholeString : Object, IDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Human recognizable context for the downhole equipment.
        /// </summary>
		
		[XmlElement("nameWellbore")]
        public String NameWellbore {
            get {
                return nameWellboreField;
            } 
            set {
                nameWellboreField = value;
                NotifyPropertyChanged("NameWellbore");
            }
        }

        private String nameWellboreField; 

        /// <summary>
        ///  The name of the borehole String 
        /// </summary>
		
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        ///  The collection of boreholes 
        /// </summary>
		[RecurringElement]
		[XmlElement("borehole")]
        public List<Borehole> Borehole {
            get {
                return boreholeField;
            } 
            set {
                boreholeField = value;
                NotifyPropertyChanged("Borehole");
            }
        }

        private List<Borehole> boreholeField; 

        /// <summary>
        /// Geology feature information 
        /// </summary>
		[RecurringElement]
		[XmlElement("geologyFeature")]
        public List<GeologyFeature> GeologyFeature {
            get {
                return geologyFeatureField;
            } 
            set {
                geologyFeatureField = value;
                NotifyPropertyChanged("GeologyFeature");
            }
        }

        private List<GeologyFeature> geologyFeatureField; 

        /// <summary>
        ///  The borehole accessories. 
        /// </summary>
		[RecurringElement]
		[XmlArrayItem("accessory")]
        [XmlArray("accessories")]
        public List<StringEquipment> Accessories {
            get {
                return accessoriesField;
            } 
            set {
                accessoriesField = value;
                NotifyPropertyChanged("Accessories");
            }
        }

        private List<StringEquipment> accessoriesField; 

		/// <summary>
        /// Unique identifier for the wellbore.
        /// </summary>
		
        [XmlAttribute("uidWellbore")]
		
        public String UidWellbore {
            get {
                return uidWellboreField;
            } 
            set {
                uidWellboreField = value;
                NotifyPropertyChanged("UidWellbore");
            }
        }

        private String uidWellboreField; 

		/// <summary>
        /// uid property
        /// </summary>
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_stringEquipment xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_stringEquipment", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_stringEquipment xsd type.")]
    public partial class StringEquipment : Object, IDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// The type of the equipment. Enumeration is defined in cs_equipmentCatalog.xsd. "Optional" is for expansion purpose, strong suggest that only ignore it if the equipment type could not found from equipmentType definition.
        /// </summary>
		
		[XmlElement("equipmentType")]
        public EquipmentType? EquipmentType {
            get {
                return equipmentTypeField;
            } 
            set {
                equipmentTypeField = value;
                this.EquipmentTypeSpecified = true;
                NotifyPropertyChanged("EquipmentType");
            }
        }

        private EquipmentType? equipmentTypeField; 

		/// <summary>
        /// equipmentTypeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EquipmentTypeSpecified {
            get {
                return equipmentTypeSpecifiedField;
            } 
            set {
                equipmentTypeSpecifiedField = value;
                NotifyPropertyChanged("EquipmentTypeSpecified");
            }
        }

        private Boolean equipmentTypeSpecifiedField; 

        /// <summary>
        /// The name of the equipment. Length of this element is 256 characters.
        /// </summary>
		
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// History of event tied to this equipment
        /// </summary>
		[RecurringElement]
		[XmlElement("equipmentEventHistory")]
        public List<EventInfo> EquipmentEventHistory {
            get {
                return equipmentEventHistoryField;
            } 
            set {
                equipmentEventHistoryField = value;
                NotifyPropertyChanged("EquipmentEventHistory");
            }
        }

        private List<EventInfo> equipmentEventHistoryField; 

        /// <summary>
        /// Defines a sequence number and with an optional description attribute
        /// </summary>
		[ComponentElement]
		[XmlElement("orderOfObject")]
        public ObjectSequence OrderOfObject {
            get {
                return orderOfObjectField;
            } 
            set {
                orderOfObjectField = value;
                NotifyPropertyChanged("OrderOfObject");
            }
        }

        private ObjectSequence orderOfObjectField; 

        /// <summary>
        /// The status of the piece of equipment.
        /// </summary>
		
		[XmlElement("status")]
        public String Status {
            get {
                return statusField;
            } 
            set {
                statusField = value;
                NotifyPropertyChanged("Status");
            }
        }

        private String statusField; 

        /// <summary>
        /// The well run No
        /// </summary>
		
		[XmlElement("runNo")]
        public String RunNo {
            get {
                return runNoField;
            } 
            set {
                runNoField = value;
                NotifyPropertyChanged("RunNo");
            }
        }

        private String runNoField; 

        /// <summary>
        /// The days that the equipment has run.
        /// </summary>
		[ComponentElement]
		[XmlElement("previousRunDays")]
        public TimeMeasure PreviousRunDays {
            get {
                return previousRunDaysField;
            } 
            set {
                previousRunDaysField = value;
                NotifyPropertyChanged("PreviousRunDays");
            }
        }

        private TimeMeasure previousRunDaysField; 

        /// <summary>
        /// Object condition at installation
        /// </summary>
		
		[XmlElement("objectCondition")]
        public String ObjectCondition {
            get {
                return objectConditionField;
            } 
            set {
                objectConditionField = value;
                NotifyPropertyChanged("ObjectCondition");
            }
        }

        private String objectConditionField; 

        /// <summary>
        /// Object surface condition
        /// </summary>
		
		[XmlElement("surfaceCondition")]
        public String SurfaceCondition {
            get {
                return surfaceConditionField;
            } 
            set {
                surfaceConditionField = value;
                NotifyPropertyChanged("SurfaceCondition");
            }
        }

        private String surfaceConditionField; 

        /// <summary>
        /// The count number of the same equipment. The default is 1. In some cases, multiple pieces group into one component.
        /// </summary>
		
		[XmlElement("count")]
        public Int16? Count {
            get {
                return countField;
            } 
            set {
                countField = value;
                this.CountSpecified = true;
                NotifyPropertyChanged("Count");
            }
        }

        private Int16? countField; 

		/// <summary>
        /// countSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CountSpecified {
            get {
                return countSpecifiedField;
            } 
            set {
                countSpecifiedField = value;
                NotifyPropertyChanged("CountSpecified");
            }
        }

        private Boolean countSpecifiedField; 

        /// <summary>
        /// The total length of the equipment. This is NOT length per unit. This is the length of unit stored at equipmentset's equipment information section. 
        /// </summary>
		[ComponentElement]
		[XmlElement("length")]
        public LengthMeasure Length {
            get {
                return lengthField;
            } 
            set {
                lengthField = value;
                NotifyPropertyChanged("Length");
            }
        }

        private LengthMeasure lengthField; 

        /// <summary>
        /// Measured depth at top of interval.
        /// </summary>
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// Measured depth at base of interval.
        /// </summary>
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// True vertical depth at top of the section.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdTop")]
        public WellVerticalDepthCoord TvdTop {
            get {
                return tvdTopField;
            } 
            set {
                tvdTopField = value;
                NotifyPropertyChanged("TvdTop");
            }
        }

        private WellVerticalDepthCoord tvdTopField; 

        /// <summary>
        /// True vertical depth at bottom of the section.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdBottom")]
        public WellVerticalDepthCoord TvdBottom {
            get {
                return tvdBottomField;
            } 
            set {
                tvdBottomField = value;
                NotifyPropertyChanged("TvdBottom");
            }
        }

        private WellVerticalDepthCoord tvdBottomField; 

        /// <summary>
        /// True vertical depth at base of interval.
        /// </summary>
		[ComponentElement]
		[XmlElement("tvdBase")]
        public WellVerticalDepthCoord TvdBase {
            get {
                return tvdBaseField;
            } 
            set {
                tvdBaseField = value;
                NotifyPropertyChanged("TvdBase");
            }
        }

        private WellVerticalDepthCoord tvdBaseField; 

        /// <summary>
        /// Flag indicating whether this component is inside the string or not .
        /// </summary>
		
		[XmlElement("outsideString")]
        public Boolean? OutsideString {
            get {
                return outsideStringField;
            } 
            set {
                outsideStringField = value;
                this.OutsideStringSpecified = true;
                NotifyPropertyChanged("OutsideString");
            }
        }

        private Boolean? outsideStringField; 

		/// <summary>
        /// outsideStringSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean OutsideStringSpecified {
            get {
                return outsideStringSpecifiedField;
            } 
            set {
                outsideStringSpecifiedField = value;
                NotifyPropertyChanged("OutsideStringSpecified");
            }
        }

        private Boolean outsideStringSpecifiedField; 

        /// <summary>
        /// The list of components contained in the equipment
        /// </summary>
		[RecurringElement]
		[XmlElement("insideComponent")]
        public List<RefContainer> InsideComponent {
            get {
                return insideComponentField;
            } 
            set {
                insideComponentField = value;
                NotifyPropertyChanged("InsideComponent");
            }
        }

        private List<RefContainer> insideComponentField; 

        /// <summary>
        /// The list of components outside of this piece of equipment
        /// </summary>
		[RecurringElement]
		[XmlElement("outsideComponent")]
        public List<RefContainer> OutsideComponent {
            get {
                return outsideComponentField;
            } 
            set {
                outsideComponentField = value;
                NotifyPropertyChanged("OutsideComponent");
            }
        }

        private List<RefContainer> outsideComponentField; 

        /// <summary>
        /// Max Tensile Strength 
        /// </summary>
		[ComponentElement]
		[XmlElement("tensileMax")]
        public ForceMeasure TensileMax {
            get {
                return tensileMaxField;
            } 
            set {
                tensileMaxField = value;
                NotifyPropertyChanged("TensileMax");
            }
        }

        private ForceMeasure tensileMaxField; 

        /// <summary>
        /// Pressure Rating
        /// </summary>
		[ComponentElement]
		[XmlElement("presRating")]
        public PressureMeasure PresRating {
            get {
                return presRatingField;
            } 
            set {
                presRatingField = value;
                NotifyPropertyChanged("PresRating");
            }
        }

        private PressureMeasure presRatingField; 

        /// <summary>
        /// Collapse Pressure 
        /// </summary>
		[ComponentElement]
		[XmlElement("presCollapse")]
        public PressureMeasure PresCollapse {
            get {
                return presCollapseField;
            } 
            set {
                presCollapseField = value;
                NotifyPropertyChanged("PresCollapse");
            }
        }

        private PressureMeasure presCollapseField; 

        /// <summary>
        /// Burst Pressure 
        /// </summary>
		[ComponentElement]
		[XmlElement("presBurst")]
        public PressureMeasure PresBurst {
            get {
                return presBurstField;
            } 
            set {
                presBurstField = value;
                NotifyPropertyChanged("PresBurst");
            }
        }

        private PressureMeasure presBurstField; 

        /// <summary>
        /// heat rating 
        /// </summary>
		[ComponentElement]
		[XmlElement("heatRating")]
        public ThermodynamicTemperatureMeasure HeatRating {
            get {
                return heatRatingField;
            } 
            set {
                heatRatingField = value;
                NotifyPropertyChanged("HeatRating");
            }
        }

        private ThermodynamicTemperatureMeasure heatRatingField; 

        /// <summary>
        ///  Flag indicating the equipment has line connected to surface. 
        /// </summary>
		
		[XmlElement("isLinetoSurface")]
        public Boolean? IsLinetoSurface {
            get {
                return isLinetoSurfaceField;
            } 
            set {
                isLinetoSurfaceField = value;
                this.IsLinetoSurfaceSpecified = true;
                NotifyPropertyChanged("IsLinetoSurface");
            }
        }

        private Boolean? isLinetoSurfaceField; 

		/// <summary>
        /// isLinetoSurfaceSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsLinetoSurfaceSpecified {
            get {
                return isLinetoSurfaceSpecifiedField;
            } 
            set {
                isLinetoSurfaceSpecifiedField = value;
                NotifyPropertyChanged("IsLinetoSurfaceSpecified");
            }
        }

        private Boolean isLinetoSurfaceSpecifiedField; 

        /// <summary>
        ///  Flag indicating equipment is centralized 
        /// </summary>
		
		[XmlElement("isCentralized")]
        public Boolean? IsCentralized {
            get {
                return isCentralizedField;
            } 
            set {
                isCentralizedField = value;
                this.IsCentralizedSpecified = true;
                NotifyPropertyChanged("IsCentralized");
            }
        }

        private Boolean? isCentralizedField; 

		/// <summary>
        /// isCentralizedSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsCentralizedSpecified {
            get {
                return isCentralizedSpecifiedField;
            } 
            set {
                isCentralizedSpecifiedField = value;
                NotifyPropertyChanged("IsCentralizedSpecified");
            }
        }

        private Boolean isCentralizedSpecifiedField; 

        /// <summary>
        ///  Flag indicating scratchers have been added to the equipment. 
        /// </summary>
		
		[XmlElement("hasScratchers")]
        public Boolean? HasScratchers {
            get {
                return hasScratchersField;
            } 
            set {
                hasScratchersField = value;
                this.HasScratchersSpecified = true;
                NotifyPropertyChanged("HasScratchers");
            }
        }

        private Boolean? hasScratchersField; 

		/// <summary>
        /// hasScratchersSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean HasScratchersSpecified {
            get {
                return hasScratchersSpecifiedField;
            } 
            set {
                hasScratchersSpecifiedField = value;
                NotifyPropertyChanged("HasScratchersSpecified");
            }
        }

        private Boolean hasScratchersSpecifiedField; 

        /// <summary>
        ///  Describes the next component connected. 
        /// </summary>
		[RecurringElement]
		[XmlElement("connectionNext")]
        public List<EquipmentConnection> ConnectionNext {
            get {
                return connectionNextField;
            } 
            set {
                connectionNextField = value;
                NotifyPropertyChanged("ConnectionNext");
            }
        }

        private List<EquipmentConnection> connectionNextField; 

        /// <summary>
        ///  Describes the assembly connected. 
        /// </summary>
		[RecurringElement]
		[XmlArrayItem("part")]
        [XmlArray("assembly")]
        public List<StringEquipment> Assembly {
            get {
                return assemblyField;
            } 
            set {
                assemblyField = value;
                NotifyPropertyChanged("Assembly");
            }
        }

        private List<StringEquipment> assemblyField; 

        /// <summary>
        /// reference the perforated hole in equipment after perforation event.
        /// </summary>
		[RecurringElement]
		[XmlElement("perforationSetRefID")]
        public List<String> PerforationSetRefID {
            get {
                return perforationSetRefIDField;
            } 
            set {
                perforationSetRefIDField = value;
                NotifyPropertyChanged("PerforationSetRefID");
            }
        }

        private List<String> perforationSetRefIDField; 

        /// <summary>
        /// Remarks on the equipment stored permanently.
        /// </summary>
		
		[XmlElement("permanentRemarks")]
        public String PermanentRemarks {
            get {
                return permanentRemarksField;
            } 
            set {
                permanentRemarksField = value;
                NotifyPropertyChanged("PermanentRemarks");
            }
        }

        private String permanentRemarksField; 

        /// <summary>
        /// Remarks on usage of this equipment.
        /// </summary>
		
		[XmlElement("usageComment")]
        public String UsageComment {
            get {
                return usageCommentField;
            } 
            set {
                usageCommentField = value;
                NotifyPropertyChanged("UsageComment");
            }
        }

        private String usageCommentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

        /// <summary>
        /// A container element that contains elements that are common to all data objects.
        /// </summary>
		[ComponentElement]
		[XmlElement("commonData")]
        public CommonData CommonData {
            get {
                return commonDataField;
            } 
            set {
                commonDataField = value;
                NotifyPropertyChanged("CommonData");
            }
        }

        private CommonData commonDataField; 

        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
		
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
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 

		/// <summary>
        /// Unique reference for the equipment.
        /// </summary>
		
        [XmlAttribute("equipmentRefUID")]
		
        public String EquipmentRefUID {
            get {
                return equipmentRefUIDField;
            } 
            set {
                equipmentRefUIDField = value;
                NotifyPropertyChanged("EquipmentRefUID");
            }
        }

        private String equipmentRefUIDField; 


        
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
    /// Information on containing or contained component  
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_refContainer", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information on containing or contained component  ")]
    public partial class RefContainer : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// DownholeString reference id 
        /// </summary>
		
		[XmlElement("stringRefID")]
        public String StringRefID {
            get {
                return stringRefIDField;
            } 
            set {
                stringRefIDField = value;
                NotifyPropertyChanged("StringRefID");
            }
        }

        private String stringRefIDField; 

        /// <summary>
        /// Equipment reference id 
        /// </summary>
		
		[XmlElement("equipmentRefID")]
        public String EquipmentRefID {
            get {
                return equipmentRefIDField;
            } 
            set {
                equipmentRefIDField = value;
                NotifyPropertyChanged("EquipmentRefID");
            }
        }

        private String equipmentRefIDField; 

        /// <summary>
        /// Reference to the equipment for this accessory 
        /// </summary>
		
		[XmlElement("accesoryEquipmentRefID")]
        public String AccesoryEquipmentRefID {
            get {
                return accesoryEquipmentRefIDField;
            } 
            set {
                accesoryEquipmentRefIDField = value;
                NotifyPropertyChanged("AccesoryEquipmentRefID");
            }
        }

        private String accesoryEquipmentRefIDField; 

        /// <summary>
        /// Comment on this container reference
        /// </summary>
		
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 


        
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
    /// Information detailing the connection between 2 components
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_equipmentConnection", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information detailing the connection between 2 components")]
    public partial class EquipmentConnection : Connection, INotifyPropertyChanged
    {

        /// <summary>
        /// measurement of radial offset 
        /// </summary>
		[ComponentElement]
		[XmlElement("radialOffset")]
        public LengthMeasure RadialOffset {
            get {
                return radialOffsetField;
            } 
            set {
                radialOffsetField = value;
                NotifyPropertyChanged("RadialOffset");
            }
        }

        private LengthMeasure radialOffsetField; 

        /// <summary>
        /// The connection type of casing
        /// </summary>
        [XmlElement("casingConnectionType")]
        public CasingConnectionType? CasingConnectionType {
            get {
                return casingConnectionTypeField;
            } 
            set {
                casingConnectionTypeField = value;
                CasingConnectionTypeSpecified = (value!=null);
                NotifyPropertyChanged("CasingConnectionType");
            }
        }

        private CasingConnectionType? casingConnectionTypeField; 
        /// <summary>
        /// Boolean to indicate if CasingConnectionType has been set. Used for serialization.
        /// </summary>
        private Boolean CasingConnectionTypeSpecified = false; 

        /// <summary>
        /// The other connection type which is used for other tools
        /// </summary>
        [XmlElement("otherConnectionType")]
        public OtherConnectionType? OtherConnectionType {
            get {
                return otherConnectionTypeField;
            } 
            set {
                otherConnectionTypeField = value;
                OtherConnectionTypeSpecified = (value!=null);
                NotifyPropertyChanged("OtherConnectionType");
            }
        }

        private OtherConnectionType? otherConnectionTypeField; 
        /// <summary>
        /// Boolean to indicate if OtherConnectionType has been set. Used for serialization.
        /// </summary>
        private Boolean OtherConnectionTypeSpecified = false; 

        /// <summary>
        /// The connection type of rod
        /// </summary>
        [XmlElement("rodConnectionType")]
        public RodConnectionType? RodConnectionType {
            get {
                return rodConnectionTypeField;
            } 
            set {
                rodConnectionTypeField = value;
                RodConnectionTypeSpecified = (value!=null);
                NotifyPropertyChanged("RodConnectionType");
            }
        }

        private RodConnectionType? rodConnectionTypeField; 
        /// <summary>
        /// Boolean to indicate if RodConnectionType has been set. Used for serialization.
        /// </summary>
        private Boolean RodConnectionTypeSpecified = false; 

        /// <summary>
        /// The connection type of tubing
        /// </summary>
        [XmlElement("tubingConnectionType")]
        public TubingConnectionType? TubingConnectionType {
            get {
                return tubingConnectionTypeField;
            } 
            set {
                tubingConnectionTypeField = value;
                TubingConnectionTypeSpecified = (value!=null);
                NotifyPropertyChanged("TubingConnectionType");
            }
        }

        private TubingConnectionType? tubingConnectionTypeField; 
        /// <summary>
        /// Boolean to indicate if TubingConnectionType has been set. Used for serialization.
        /// </summary>
        private Boolean TubingConnectionTypeSpecified = false; 


        /// <summary>
        /// The form of connection: Box or Pin 
        /// </summary>
		
		[XmlElement("connectionForm")]
        public ConnectionFormType? ConnectionForm {
            get {
                return connectionFormField;
            } 
            set {
                connectionFormField = value;
                this.ConnectionFormSpecified = true;
                NotifyPropertyChanged("ConnectionForm");
            }
        }

        private ConnectionFormType? connectionFormField; 

		/// <summary>
        /// connectionFormSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ConnectionFormSpecified {
            get {
                return connectionFormSpecifiedField;
            } 
            set {
                connectionFormSpecifiedField = value;
                NotifyPropertyChanged("ConnectionFormSpecified");
            }
        }

        private Boolean connectionFormSpecifiedField; 

        /// <summary>
        /// Connection upset
        /// </summary>
		
		[XmlElement("connectionUpset")]
        public String ConnectionUpset {
            get {
                return connectionUpsetField;
            } 
            set {
                connectionUpsetField = value;
                NotifyPropertyChanged("ConnectionUpset");
            }
        }

        private String connectionUpsetField; 

		/// <summary>
        /// Reference to the string equipment
        /// </summary>
		
        [XmlAttribute("stringEquipmentRefUID")]
		
        public String StringEquipmentRefUID {
            get {
                return stringEquipmentRefUIDField;
            } 
            set {
                stringEquipmentRefUIDField = value;
                NotifyPropertyChanged("StringEquipmentRefUID");
            }
        }

        private String stringEquipmentRefUIDField; 


    } //here
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    ///  WITSML - Tubular Connection Component Schema 
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EquipmentConnection))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_connection", Namespace="http://www.witsml.org/schemas/1series")]
    [Description(" WITSML - Tubular Connection Component Schema ")]
    public partial class Connection : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Internal diameter of object. 
        /// </summary>
		[ComponentElement]
		[XmlElement("id")]
        public LengthMeasure InnerDiameter {
            get {
                return idField;
            } 
            set {
                idField = value;
                NotifyPropertyChanged("InnerDiameter");
            }
        }

        private LengthMeasure idField; 

        /// <summary>
        /// Outside diameter of the body of the item. 
        /// </summary>
		[ComponentElement]
		[XmlElement("od")]
        public LengthMeasure OuterDiameter {
            get {
                return odField;
            } 
            set {
                odField = value;
                NotifyPropertyChanged("OuterDiameter");
            }
        }

        private LengthMeasure odField; 

        /// <summary>
        /// Length of the item. 
        /// </summary>
		[ComponentElement]
		[XmlElement("len")]
        public LengthMeasure Len {
            get {
                return lenField;
            } 
            set {
                lenField = value;
                NotifyPropertyChanged("Len");
            }
        }

        private LengthMeasure lenField; 

        /// <summary>
        /// Thread type from API RP7G, 5CT. 
        /// </summary>
		
		[XmlElement("typeThread")]
        public String TypeThread {
            get {
                return typeThreadField;
            } 
            set {
                typeThreadField = value;
                NotifyPropertyChanged("TypeThread");
            }
        }

        private String typeThreadField; 

        /// <summary>
        /// Thread size. 
        /// </summary>
		[ComponentElement]
		[XmlElement("sizeThread")]
        public LengthMeasure SizeThread {
            get {
                return sizeThreadField;
            } 
            set {
                sizeThreadField = value;
                NotifyPropertyChanged("SizeThread");
            }
        }

        private LengthMeasure sizeThreadField; 

        /// <summary>
        /// Yield stress of steel - worn stress. 
        /// </summary>
		[ComponentElement]
		[XmlElement("tensYield")]
        public PressureMeasure TensYield {
            get {
                return tensYieldField;
            } 
            set {
                tensYieldField = value;
                NotifyPropertyChanged("TensYield");
            }
        }

        private PressureMeasure tensYieldField; 

        /// <summary>
        /// Torque at which yield occurs.
        /// </summary>
		[ComponentElement]
		[XmlElement("tqYield")]
        public MomentOfForceMeasure TorqueYield {
            get {
                return tqYieldField;
            } 
            set {
                tqYieldField = value;
                NotifyPropertyChanged("TorqueYield");
            }
        }

        private MomentOfForceMeasure tqYieldField; 

        /// <summary>
        /// Where connected. 
        /// </summary>
		
		[XmlElement("position")]
        public ConnectionPosition? Position {
            get {
                return positionField;
            } 
            set {
                positionField = value;
                this.PositionSpecified = true;
                NotifyPropertyChanged("Position");
            }
        }

        private ConnectionPosition? positionField; 

		/// <summary>
        /// positionSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PositionSpecified {
            get {
                return positionSpecifiedField;
            } 
            set {
                positionSpecifiedField = value;
                NotifyPropertyChanged("PositionSpecified");
            }
        }

        private Boolean positionSpecifiedField; 

        /// <summary>
        /// For bending stiffness ratio. 
        /// </summary>
		[ComponentElement]
		[XmlElement("criticalCrossSection")]
        public AreaMeasure CriticalCrossSection {
            get {
                return criticalCrossSectionField;
            } 
            set {
                criticalCrossSectionField = value;
                NotifyPropertyChanged("CriticalCrossSection");
            }
        }

        private AreaMeasure criticalCrossSectionField; 

        /// <summary>
        /// Leak pressure rating. 
        /// </summary>
		[ComponentElement]
		[XmlElement("presLeak")]
        public PressureMeasure PresLeak {
            get {
                return presLeakField;
            } 
            set {
                presLeakField = value;
                NotifyPropertyChanged("PresLeak");
            }
        }

        private PressureMeasure presLeakField; 

        /// <summary>
        /// Make up torque. 
        /// </summary>
		[ComponentElement]
		[XmlElement("tqMakeup")]
        public MomentOfForceMeasure TorqueMakeup {
            get {
                return tqMakeupField;
            } 
            set {
                tqMakeupField = value;
                NotifyPropertyChanged("TorqueMakeup");
            }
        }

        private MomentOfForceMeasure tqMakeupField; 

        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
		
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
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
		
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
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    /// This class represents the cs_downholeString xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_downholeString", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("This class represents the cs_downholeString xsd type.")]
    public partial class DownholeString : Object, IDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// stringType property
        /// </summary>
		[Required]
		[Description("An enumeration type defined in equipmentCatelog, the \"DownholeStringEnum\"                     contains valid option of \"case\",\"rod\",\"tubing\", \"otherString\".")]
		[XmlElement("stringType")]
        public DownholeStringType? StringType {
            get {
                return stringTypeField;
            } 
            set {
                stringTypeField = value;
                NotifyPropertyChanged("StringType");
            }
        }

        private DownholeStringType? stringTypeField; 

        /// <summary>
        /// subStringType property
        /// </summary>
		[Description("An enumeration type define for express further string type etc. \"SurfaceCasing\", \"IntermediaCasing\", \"productionCasing\".")]
		[XmlElement("subStringType")]
        public SubStringType? SubStringType {
            get {
                return subStringTypeField;
            } 
            set {
                subStringTypeField = value;
                this.SubStringTypeSpecified = true;
                NotifyPropertyChanged("SubStringType");
            }
        }

        private SubStringType? subStringTypeField; 

		/// <summary>
        /// subStringTypeSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SubStringTypeSpecified {
            get {
                return subStringTypeSpecifiedField;
            } 
            set {
                subStringTypeSpecifiedField = value;
                NotifyPropertyChanged("SubStringTypeSpecified");
            }
        }

        private Boolean subStringTypeSpecifiedField; 

        /// <summary>
        /// name property
        /// </summary>
		[StringLength(64)]
		[Description("The name of downhole string.")]
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// stringInstallDate property
        /// </summary>
		[Description("The install date of downhole string.")]
		[XmlElement("stringInstallDate")]
        public Timestamp? StringInstallDate {
            get {
                return stringInstallDateField;
            } 
            set {
                stringInstallDateField = value;
                this.StringInstallDateSpecified = true;
                NotifyPropertyChanged("StringInstallDate");
            }
        }

        private Timestamp? stringInstallDateField; 

		/// <summary>
        /// stringInstallDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StringInstallDateSpecified {
            get {
                return stringInstallDateSpecifiedField;
            } 
            set {
                stringInstallDateSpecifiedField = value;
                NotifyPropertyChanged("StringInstallDateSpecified");
            }
        }

        private Boolean stringInstallDateSpecifiedField; 

        /// <summary>
        /// parentStringsName property
        /// </summary>
		[RegularExpression("[^ ]*")]
		[StringLength(64)]
		[Description("The name of parent string.")]
		[XmlElement("parentStringsName")]
        public String ParentStringsName {
            get {
                return parentStringsNameField;
            } 
            set {
                parentStringsNameField = value;
                NotifyPropertyChanged("ParentStringsName");
            }
        }

        private String parentStringsNameField; 

        /// <summary>
        /// mdTop property
        /// </summary>
		[Description("Measured depth at Top of Interval")]
		[ComponentElement]
		[XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop {
            get {
                return mdTopField;
            } 
            set {
                mdTopField = value;
                NotifyPropertyChanged("MDTop");
            }
        }

        private MeasuredDepthCoord mdTopField; 

        /// <summary>
        /// mdBottom property
        /// </summary>
		[Description("Measured depth at bottom of the section")]
		[ComponentElement]
		[XmlElement("mdBottom")]
        public MeasuredDepthCoord MDBottom {
            get {
                return mdBottomField;
            } 
            set {
                mdBottomField = value;
                NotifyPropertyChanged("MDBottom");
            }
        }

        private MeasuredDepthCoord mdBottomField; 

        /// <summary>
        /// axisOffset property
        /// </summary>
		[Description("the distance from the sibling string.")]
		[ComponentElement]
		[XmlElement("axisOffset")]
        public LengthMeasure AxisOffset {
            get {
                return axisOffsetField;
            } 
            set {
                axisOffsetField = value;
                NotifyPropertyChanged("AxisOffset");
            }
        }

        private LengthMeasure axisOffsetField; 

        /// <summary>
        /// stringEquipmentSet property
        /// </summary>
		[Description("the list of equipment in the string. each equipment is liner connected and carry the rest of weight")]
		[RecurringElement]
		[XmlArrayItem("stringEquipment")]
        [XmlArray("stringEquipmentSet")]
        public List<StringEquipment> StringEquipmentSet {
            get {
                return stringEquipmentSetField;
            } 
            set {
                stringEquipmentSetField = value;
                NotifyPropertyChanged("StringEquipmentSet");
            }
        }

        private List<StringEquipment> stringEquipmentSetField; 

        /// <summary>
        /// accessories property
        /// </summary>
		[Description("the accessories equipment of the string. It locates in the downhole string, but it is not equipment which liner connected in string (from top to down), and it is not carraying the weight of string")]
		[RecurringElement]
		[XmlArrayItem("accessory")]
        [XmlArray("accessories")]
        public List<StringEquipment> Accessories {
            get {
                return accessoriesField;
            } 
            set {
                accessoriesField = value;
                NotifyPropertyChanged("Accessories");
            }
        }

        private List<StringEquipment> accessoriesField; 

        /// <summary>
        /// extensionAny property
        /// </summary>
		[Description("Extensions to the schema using an xsd:any construct.")]
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
        /// extensionNameValue property
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 

		/// <summary>
        /// uidParentString property
        /// </summary>
		[Description("The uidParentString points to the parent string. Even if the string is not physically connected together, this string is             still considered as a continuation of the parent string.")]
        [XmlAttribute("uidParentString")]
		
        public String UidParentString {
            get {
                return uidParentStringField;
            } 
            set {
                uidParentStringField = value;
                NotifyPropertyChanged("UidParentString");
            }
        }

        private String uidParentStringField; 

		/// <summary>
        /// uidWellbore property
        /// </summary>
		[Description("Unique identifier for the wellbore. This uniquely represents  the wellbore referenced by the (possibly non-unique) nameWellbore.")]
        [XmlAttribute("uidWellbore")]
		
        public String UidWellbore {
            get {
                return uidWellboreField;
            } 
            set {
                uidWellboreField = value;
                NotifyPropertyChanged("UidWellbore");
            }
        }

        private String uidWellboreField; 


        
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
    /// The non-contextual content of a WITSML downhole component object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_downholeComponent", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("The non-contextual content of a WITSML downhole component object.")]
    public partial class DownholeComponent : Object, IWellObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Human recognizable context for the well.
        /// </summary>
		[Required]
		[StringLength(64)]
		[Description("Human recognizable context for the well.")]
		[XmlElement("nameWell")]
        public String NameWell {
            get {
                return nameWellField;
            } 
            set {
                nameWellField = value;
                NotifyPropertyChanged("NameWell");
            }
        }

        private String nameWellField; 

        /// <summary>
        /// Human recognizable context for the downhole equipment.
        /// </summary>
		[Required]
		[StringLength(64)]
		[Description("Human recognizable context for the downhole equipment.")]
		[XmlElement("name")]
        public String Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private String nameField; 

        /// <summary>
        /// The date range specification: start date
        /// </summary>
		[Description("The date range specification: start date")]
		[XmlElement("startDate")]
        public Timestamp? StartDate {
            get {
                return startDateField;
            } 
            set {
                startDateField = value;
                this.StartDateSpecified = true;
                NotifyPropertyChanged("StartDate");
            }
        }

        private Timestamp? startDateField; 

		/// <summary>
        /// startDateSpecified property
        /// </summary>
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StartDateSpecified {
            get {
                return startDateSpecifiedField;
            } 
            set {
                startDateSpecifiedField = value;
                NotifyPropertyChanged("StartDateSpecified");
            }
        }

        private Boolean startDateSpecifiedField; 

        /// <summary>
        /// The date range specification: end date
        /// </summary>
		[Description("The date range specification: end date")]
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
        public Boolean EndDateSpecified {
            get {
                return endDateSpecifiedField;
            } 
            set {
                endDateSpecifiedField = value;
                NotifyPropertyChanged("EndDateSpecified");
            }
        }

        private Boolean endDateSpecifiedField; 

        /// <summary>
        /// This section contains wellhead information, and is composed of string equipment
        /// </summary>
		[Description("This section contains wellhead information, and is composed of string equipment")]
		[ComponentElement]
		[XmlElement("wellHead")]
        public DownholeString WellHead {
            get {
                return wellHeadField;
            } 
            set {
                wellHeadField = value;
                NotifyPropertyChanged("WellHead");
            }
        }

        private DownholeString wellHeadField; 

        /// <summary>
        /// This section contains bore hole string information including flow interval 
        /// </summary>
		[Description("This section contains bore hole string information including flow interval")]
		[RecurringElement]
		[XmlArrayItem("boreholeString")]
        [XmlArray("boreholeStringSet")]
        public List<BoreholeString> BoreholeStringSet {
            get {
                return boreholeStringSetField;
            } 
            set {
                boreholeStringSetField = value;
                NotifyPropertyChanged("BoreholeStringSet");
            }
        }

        private List<BoreholeString> boreholeStringSetField; 

        /// <summary>
        /// The linear downhole string equipment
        /// </summary>
		[Description("The linear downhole string equipment")]
		[RecurringElement]
		[XmlArrayItem("downholeString")]
        [XmlArray("downholeStringSet")]
        public List<DownholeString> DownholeStringSet {
            get {
                return downholeStringSetField;
            } 
            set {
                downholeStringSetField = value;
                NotifyPropertyChanged("DownholeStringSet");
            }
        }

        private List<DownholeString> downholeStringSetField; 

        /// <summary>
        /// A collection of equipment / component
        /// </summary>
		[Description("A collection of equipment / component")]
		[RecurringElement]
		[XmlArrayItem("equipment")]
        [XmlArray("equipmentSet")]
        public List<Equipment> EquipmentSet {
            get {
                return equipmentSetField;
            } 
            set {
                equipmentSetField = value;
                NotifyPropertyChanged("EquipmentSet");
            }
        }

        private List<Equipment> equipmentSetField; 

        /// <summary>
        /// A collection of contact interval information
        /// </summary>
		[Description("A collection of contact interval information")]
		[RecurringElement]
		[XmlArrayItem("perforationSet")]
        [XmlArray("perforationSets")]
        public List<PerforationSet> PerforationSets {
            get {
                return perforationSetsField;
            } 
            set {
                perforationSetsField = value;
                NotifyPropertyChanged("PerforationSets");
            }
        }

        private List<PerforationSet> perforationSetsField; 

        /// <summary>
        /// A container element that contains elements that are common to all data objects.
        /// </summary>
		[Description("A container element that contains elements that are common to all data objects.")]
		[ComponentElement]
		[XmlElement("commonData")]
        public CommonData CommonData {
            get {
                return commonDataField;
            } 
            set {
                commonDataField = value;
                NotifyPropertyChanged("CommonData");
            }
        }

        private CommonData commonDataField; 

        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
		[Description("A container element that can contain custom or user defined data elements.")]
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
        /// Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell.
        /// </summary>
		[Description("Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell.")]
        [XmlAttribute("uidWell")]
		
        public String UidWell {
            get {
                return uidWellField;
            } 
            set {
                uidWellField = value;
                NotifyPropertyChanged("UidWell");
            }
        }

        private String uidWellField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of an object. This should not be used for child nodes within an object. For an independent object, the value may be globally unique. For a dependent object, the value must be unique (for the same object type) within the context of the parent object. There should be no assumption as to the semantic content of this attribute. The purpose of this type is to facilitate modifying the optionality in derived schemas.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentEvent", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("An event type captures the basic information about an event that has affected the data.")]
    public partial class DocumentEvent : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The date on which the event took place.
        /// </summary>
		
		[XmlElement("eventDate")]
        public DateTime? EventDate {
            get {
                return eventDateField;
            } 
            set {
                eventDateField = value;
                NotifyPropertyChanged("EventDate");
            }
        }

        private DateTime? eventDateField; 

        /// <summary>
        /// The kind of event event.
        /// </summary>
		
		[XmlElement("eventType")]
        public String EventType {
            get {
                return eventTypeField;
            } 
            set {
                eventTypeField = value;
                NotifyPropertyChanged("EventType");
            }
        }

        private String eventTypeField; 

        /// <summary>
        /// The party responsible for the event.
        /// </summary>
		
		[XmlElement("responsibleParty")]
        public String ResponsibleParty {
            get {
                return responsiblePartyField;
            } 
            set {
                responsiblePartyField = value;
                NotifyPropertyChanged("ResponsibleParty");
            }
        }

        private String responsiblePartyField; 

        /// <summary>
        /// A free form comment that can further define the event that occurred.
        /// </summary>
		
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentSecurityInfo", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("Information about the security classification of the document. This is intended as a documentation of the security so that the file will not inadvertently be sent to someone who is not allowed access to the data. This block also carries a date that the security classification expires. For example, a well log is confidential for a period of time, and then becomes open. All security classes are characterized by their classification systems.")]
    public partial class DocumentSecurityInfo : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The security class in which this document is classified. Examples would be confidential, partner confidential, tight. The meaning of the class is determined by the System in which it is defined.
        /// </summary>
		[StringLength(40)]
		[Description("The security class in which this document is  classified. Examples would be confidential, partner confidential,  tight. The meaning of the class is determined by the System in which  it is defined.")]
		[XmlElement("class")]
        public String Class {
            get {
                return classField;
            } 
            set {
                classField = value;
                NotifyPropertyChanged("Class");
            }
        }

        private String classField; 

        /// <summary>
        /// The security classification system. This gives context to the meaning of the Class value.
        /// </summary>
		[StringLength(40)]
		[Description("The security classification system.  This gives context to the meaning of the Class value.")]
		[XmlElement("securitySystem")]
        public String SecuritySystem {
            get {
                return securitySystemField;
            } 
            set {
                securitySystemField = value;
                NotifyPropertyChanged("SecuritySystem");
            }
        }

        private String securitySystemField; 

        /// <summary>
        /// The date on which this security class is no longer applicable.
        /// </summary>
		[Description("The date on which this security class is no  longer applicable.")]
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
        public Boolean EndDateSpecified {
            get {
                return endDateSpecifiedField;
            } 
            set {
                endDateSpecifiedField = value;
                NotifyPropertyChanged("EndDateSpecified");
            }
        }

        private Boolean endDateSpecifiedField; 

        /// <summary>
        /// A general comment to further define the security class.
        /// </summary>
		[StringLength(4000)]
		[Description("A general comment to further define the security  class.")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 

        /// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
		[Description("Extensions to the schema based on a name-value construct.")]
		[RecurringElement]
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

        private List<ExtensionNameValue> extensionNameValueField; 

		/// <summary>
        /// uid property
        /// </summary>
		[Description("The unique identifier of a container element. This attribute is generally required within the context of a WITSML server. There should be no assumption as to the semantic content of this attribute. This should only be used with recurring container types (i.e., maxOccurs greater than one). The value is only required to be unique within the context of the nearest recurring parent element.")]
        [XmlAttribute("uid")]
		
        public String Uid {
            get {
                return uidField;
            } 
            set {
                uidField = value;
                NotifyPropertyChanged("Uid");
            }
        }

        private String uidField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentFileCreation", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("A block of information about the creation of the XML file. This is different than the creation of the data that is included within the file.")]
    public partial class DocumentFileCreation : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// The date and time that the file was created.
        /// </summary>
		[Required]
		[Description("The date and time that the file was created.")]
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
		[XmlElement("softwareName")]
        public String SoftwareName {
            get {
                return softwareNameField;
            } 
            set {
                softwareNameField = value;
                NotifyPropertyChanged("SoftwareName");
            }
        }

        private String softwareNameField; 

        /// <summary>
        /// The person or business associate that created the file.
        /// </summary>
		[StringLength(64)]
		[Description("The person or business associate that created  the file.")]
		[XmlElement("fileCreator")]
        public String FileCreator {
            get {
                return fileCreatorField;
            } 
            set {
                fileCreatorField = value;
                NotifyPropertyChanged("FileCreator");
            }
        }

        private String fileCreatorField; 

        /// <summary>
        /// Any comment that would be useful to further explain the creation of this instance document.
        /// </summary>
		[StringLength(4000)]
		[Description("Any comment that would be useful to further  explain the creation of this instance document.")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="nameStruct", Namespace="http://www.witsml.org/schemas/1series")]
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
        public NameStruct(String value)
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
		[Description("The naming system within the name is (hopefully) unique.")]
        [XmlAttribute("namingSystem")]
		
        public String NamingSystem {
            get {
                return namingSystemField;
            } 
            set {
                namingSystemField = value;
                NotifyPropertyChanged("NamingSystem");
            }
        }

        private String namingSystemField; 

		/// <summary>
        /// Value property
        /// </summary>
		
        [XmlText]
        public String Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

        private String ValueField; 


        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentInfo", Namespace="http://www.witsml.org/schemas/1series")]
    [Description("A schema to capture a set of data that is relevant for many exchange documents. It includes information about the file that was created, and high-level information about the data that is being exchanged within the file.")]
    public partial class DocumentInfo : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// An identifier for the document. This is intended to be unique within the context of the NamingSystem.
        /// </summary>
		[Required]
		[Description("An identifier for the document. This is  intended to be unique within the context of the NamingSystem.")]
		[ComponentElement]
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

        private List<NameStruct> documentAliasField; 

        /// <summary>
        /// The date of the creation of the document. This is not the same as the date that the file was created. For this date, the document is considered to be the set of information associated with this document information. For example, the document may be a seismic binset. This represents the date that the binset was created. The FileCreation information would capture the date that the XML file was created to send or exchange the binset.
        /// </summary>
		[Description("The date of the creation of the document.  This is not the same as the date that the file was created.  For this date, the document is considered to be the set of  information associated with this document information.  For example, the document may be a seismic binset.  This represents the date that the binset was created.  The FileCreation information would capture the date that  the XML file was created to send or exchange the binset.")]
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
        public Boolean DocumentDateSpecified {
            get {
                return documentDateSpecifiedField;
            } 
            set {
                documentDateSpecifiedField = value;
                NotifyPropertyChanged("DocumentDateSpecified");
            }
        }

        private Boolean documentDateSpecifiedField; 

        /// <summary>
        /// A document class. Examples of classes would be a metadata classification or a set of keywords. 
        /// </summary>
		[Description("A document class. Examples of classes would be a  metadata classification or a set of keywords.")]
		[RecurringElement]
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

        private List<NameStruct> documentClassField; 

        /// <summary>
        /// The information about the creation of the exchange file. This is not about the creation of the data within the file, but the creation of the file itself.
        /// </summary>
		[Description("The information about the creation of the  exchange file. This is not about the creation of the data within  the file, but the creation of the file itself.")]
		[ComponentElement]
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

        private List<DocumentSecurityInfo> securityInformationField; 

        /// <summary>
        /// A free-form string that allows a disclaimer to accompany the information.
        /// </summary>
		[StringLength(4000)]
		[Description("A free-form string that allows a disclaimer to  accompany the information.")]
		[XmlElement("disclaimer")]
        public String Disclaimer {
            get {
                return disclaimerField;
            } 
            set {
                disclaimerField = value;
                NotifyPropertyChanged("Disclaimer");
            }
        }

        private String disclaimerField; 

        /// <summary>
        /// A collection of events that can document the history of the data.
        /// </summary>
		[Description("A collection of events that can document the  history of the data.")]
		[RecurringElement]
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

        private List<DocumentEvent> auditTrailField; 

        /// <summary>
        /// The owner of the data.
        /// </summary>
		[StringLength(64)]
		[Description("The owner of the data.")]
		[XmlElement("owner")]
        public String Owner {
            get {
                return ownerField;
            } 
            set {
                ownerField = value;
                NotifyPropertyChanged("Owner");
            }
        }

        private String ownerField; 

        /// <summary>
        /// An optional comment about the document.
        /// </summary>
		[StringLength(4000)]
		[Description("An optional comment about the document.")]
		[XmlElement("comment")]
        public String Comment {
            get {
                return commentField;
            } 
            set {
                commentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private String commentField; 


        
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
    /// The WITSML API mandated plural root element which allows multiple singular objects to be sent. The plural name is formed by adding an "s" to the singular name.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("wellCompletions", Namespace="http://www.witsml.org/schemas/1series", IsNullable=false)]
    [Description("The WITSML API mandated plural root element which allows multiple singular objects to be sent. The plural name is formed by adding an s to the singular name.")]
    public partial class WellCompletionList : AbstractObject, IEnergisticsCollection, INotifyPropertyChanged
    {

        /// <summary>
        /// Information about the well completion.
        /// </summary>
		[Description("Information about the well completion.")]
		[ComponentElement]
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
        /// Information about a wellbore completion.
        /// </summary>
		[Required]
		[Description("Information about a wellbore completion.")]
		[RecurringElement]
		[XmlElement("wellCompletion")]
        public List<WellCompletion> WellCompletion {
            get {
                return wellCompletionField;
            } 
            set {
                wellCompletionField = value;
                NotifyPropertyChanged("WellCompletion");
            }
        }

        private List<WellCompletion> wellCompletionField; 

        /// <summary>
        /// Information about a wellbore completion.
        /// </summary>
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return WellCompletion;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
		[Description("Data object schema version.  The fourth level must match the  version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.")]
        [XmlAttribute("version")]
		
        public String Version {
            get {
                return versionField;
            } 
            set {
                versionField = value;
                NotifyPropertyChanged("Version");
            }
        }

        private String versionField = "1.0"; 


    } //here

    /// <summary>
    /// This class represents the obj_wellCMLedgers xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("wellCMLedgers", Namespace="http://www.witsml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_wellCMLedgers xsd type.")]
    public partial class WellCMLedgerList : AbstractObject, IEnergisticsCollection, INotifyPropertyChanged
    {

        /// <summary>
        /// Information about the event ledger instance.
        /// </summary>
		[Description("Information about the event ledger instance.")]
		[ComponentElement]
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
        /// The non-contextual elements for general event ledger information.
        /// </summary>
		[Required]
		[Description("The non-contextual elements for general event ledger information.")]
		[RecurringElement]
		[XmlElement("wellCMLedger")]
        public List<WellCMLedger> WellCMLedger {
            get {
                return wellCMLedgerField;
            } 
            set {
                wellCMLedgerField = value;
                NotifyPropertyChanged("WellCMLedger");
            }
        }

        private List<WellCMLedger> wellCMLedgerField; 

        /// <summary>
        /// The non-contextual elements for general event ledger information.
        /// </summary>
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return WellCMLedger;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
		[Description("Data object schema version.  The fourth level must match the  version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.")]
        [XmlAttribute("version")]
		
        public String Version {
            get {
                return versionField;
            } 
            set {
                versionField = value;
                NotifyPropertyChanged("Version");
            }
        }

        private String versionField = "1.0"; 


    } //here

    /// <summary>
    /// Information on wellbore completion collection.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("wellboreCompletions", Namespace="http://www.witsml.org/schemas/1series", IsNullable=false)]
    [Description("Information on wellbore completion collection.")]
    public partial class WellboreCompletionList : AbstractObject, IEnergisticsCollection, INotifyPropertyChanged
    {

        /// <summary>
        /// Information about the downhole component.
        /// </summary>
		[Description("Information about the downhole component.")]
		[ComponentElement]
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
        /// Wellbore completion type
        /// </summary>
		[Required]
		[Description("Wellbore completion type")]
		[RecurringElement]
		[XmlElement("wellboreCompletion")]
        public List<WellboreCompletion> WellboreCompletion {
            get {
                return wellboreCompletionField;
            } 
            set {
                wellboreCompletionField = value;
                NotifyPropertyChanged("WellboreCompletion");
            }
        }

        private List<WellboreCompletion> wellboreCompletionField; 

        /// <summary>
        /// Wellbore completion type
        /// </summary>
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return WellboreCompletion;
			}
        }
		/// <summary>
        /// Data object schema version.
        /// </summary>
		[Description("Data object schema version.")]
        [XmlAttribute("version")]
		
        public String Version {
            get {
                return versionField;
            } 
            set {
                versionField = value;
                NotifyPropertyChanged("Version");
            }
        }

        private String versionField = "1.0"; 


    } //here

    /// <summary>
    /// This class represents the obj_downholeComponents xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("downholeComponents", Namespace="http://www.witsml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_downholeComponents xsd type.")]
    public partial class DownholeComponentList : AbstractObject, IEnergisticsCollection, INotifyPropertyChanged
    {

        /// <summary>
        /// Information about the downhole component.
        /// </summary>
		[Description("Information about the downhole component.")]
		[ComponentElement]
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
        /// Information about a downhole equipment
        /// </summary>
		[Required]
		[Description("Information about a downhole equipment")]
		[RecurringElement]
		[XmlElement("downholeComponent")]
        public List<DownholeComponent> DownholeComponent {
            get {
                return downholeComponentField;
            } 
            set {
                downholeComponentField = value;
                NotifyPropertyChanged("DownholeComponent");
            }
        }

        private List<DownholeComponent> downholeComponentField; 

        /// <summary>
        /// Information about a downhole equipment
        /// </summary>
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return DownholeComponent;
			}
        }
		/// <summary>
        /// Data object schema version.
        /// </summary>
		[Description("Data object schema version.")]
        [XmlAttribute("version")]
		
        public String Version {
            get {
                return versionField;
            } 
            set {
                versionField = value;
                NotifyPropertyChanged("Version");
            }
        }

        private String versionField = "1.0"; 


    } //here

    #endregion

    #region Enumerations
    namespace ReferenceData {
        /// <summary>
        /// This class represents the CompletionStatus xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the CompletionStatus xsd enumeration.")]
        public enum CompletionStatus 
        {
        /// <summary>
        /// Planned property
        /// </summary>
          Planned,
        /// <summary>
        /// Active property
        /// </summary>
          Active,
        /// <summary>
        /// Inactive property
        /// </summary>
          Inactive,
        /// <summary>
        /// PermanentAbandoned property
        /// </summary>
          [XmlEnum("Permanent Abandoned")]
          PermanentAbandoned,
        /// <summary>
        /// Suspended property
        /// </summary>
          Suspended,
        /// <summary>
        /// TemporaryAbandoned property
        /// </summary>
          [XmlEnum("Temporary Abandoned")]
          TemporaryAbandoned,
        /// <summary>
        /// Testing property
        /// </summary>
          Testing
        }
        /// <summary>
        /// This class represents the MeasuredDepthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
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
        /// This class represents the LengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the LengthUom xsd enumeration.")]
        public enum LengthUom 
        {
        /// <summary>
        /// m property
        /// </summary>
          m,
        /// <summary>
        /// angstrom property
        /// </summary>
          angstrom,
        /// <summary>
        /// chBnA property
        /// </summary>
          chBnA,
        /// <summary>
        /// chBnB property
        /// </summary>
          chBnB,
        /// <summary>
        /// chCla property
        /// </summary>
          chCla,
        /// <summary>
        /// chSe property
        /// </summary>
          chSe,
        /// <summary>
        /// chUS property
        /// </summary>
          chUS,
        /// <summary>
        /// cm property
        /// </summary>
          cm,
        /// <summary>
        /// dm property
        /// </summary>
          dm,
        /// <summary>
        /// fathom property
        /// </summary>
          fathom,
        /// <summary>
        /// fm property
        /// </summary>
          fm,
        /// <summary>
        /// ft property
        /// </summary>
          ft,
        /// <summary>
        /// ftBnA property
        /// </summary>
          ftBnA,
        /// <summary>
        /// ftBnB property
        /// </summary>
          ftBnB,
        /// <summary>
        /// ftBr65 property
        /// </summary>
          [XmlEnum("ftBr(65)")]
          ftBr65,
        /// <summary>
        /// ftCla property
        /// </summary>
          ftCla,
        /// <summary>
        /// ftGC property
        /// </summary>
          ftGC,
        /// <summary>
        /// ftInd property
        /// </summary>
          ftInd,
        /// <summary>
        /// ftInd37 property
        /// </summary>
          [XmlEnum("ftInd(37)")]
          ftInd37,
        /// <summary>
        /// ftInd62 property
        /// </summary>
          [XmlEnum("ftInd(62)")]
          ftInd62,
        /// <summary>
        /// ftInd75 property
        /// </summary>
          [XmlEnum("ftInd(75)")]
          ftInd75,
        /// <summary>
        /// ftMA property
        /// </summary>
          ftMA,
        /// <summary>
        /// ftSe property
        /// </summary>
          ftSe,
        /// <summary>
        /// ftUS property
        /// </summary>
          ftUS,
        /// <summary>
        /// in property
        /// </summary>
          @in,
        /// <summary>
        /// in10 property
        /// </summary>
          [XmlEnum("in/10")]
          in10,
        /// <summary>
        /// in16 property
        /// </summary>
          [XmlEnum("in/16")]
          in16,
        /// <summary>
        /// in32 property
        /// </summary>
          [XmlEnum("in/32")]
          in32,
        /// <summary>
        /// in64 property
        /// </summary>
          [XmlEnum("in/64")]
          in64,
        /// <summary>
        /// inUS property
        /// </summary>
          inUS,
        /// <summary>
        /// km property
        /// </summary>
          km,
        /// <summary>
        /// lkBnA property
        /// </summary>
          lkBnA,
        /// <summary>
        /// lkBnB property
        /// </summary>
          lkBnB,
        /// <summary>
        /// lkCla property
        /// </summary>
          lkCla,
        /// <summary>
        /// lkSe property
        /// </summary>
          lkSe,
        /// <summary>
        /// lkUS property
        /// </summary>
          lkUS,
        /// <summary>
        /// mGer property
        /// </summary>
          mGer,
        /// <summary>
        /// mi property
        /// </summary>
          mi,
        /// <summary>
        /// mil property
        /// </summary>
          mil,
        /// <summary>
        /// miUS property
        /// </summary>
          miUS,
        /// <summary>
        /// mm property
        /// </summary>
          mm,
        /// <summary>
        /// Mm property
        /// </summary>
          Mm,
        /// <summary>
        /// nautmi property
        /// </summary>
          nautmi,
        /// <summary>
        /// nm property
        /// </summary>
          nm,
        /// <summary>
        /// pm property
        /// </summary>
          pm,
        /// <summary>
        /// um property
        /// </summary>
          um,
        /// <summary>
        /// yd property
        /// </summary>
          yd,
        /// <summary>
        /// ydBnA property
        /// </summary>
          ydBnA,
        /// <summary>
        /// ydBnB property
        /// </summary>
          ydBnB,
        /// <summary>
        /// ydCla property
        /// </summary>
          ydCla,
        /// <summary>
        /// ydIm property
        /// </summary>
          ydIm,
        /// <summary>
        /// ydInd property
        /// </summary>
          ydInd,
        /// <summary>
        /// ydInd37 property
        /// </summary>
          [XmlEnum("ydInd(37)")]
          ydInd37,
        /// <summary>
        /// ydInd62 property
        /// </summary>
          [XmlEnum("ydInd(62)")]
          ydInd62,
        /// <summary>
        /// ydInd75 property
        /// </summary>
          [XmlEnum("ydInd(75)")]
          ydInd75,
        /// <summary>
        /// ydSe property
        /// </summary>
          ydSe
        }
        /// <summary>
        /// This class represents the EastOrWest xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the EastOrWest xsd enumeration.")]
        public enum EastOrWest 
        {
        /// <summary>
        /// East of something.
        /// </summary>
          east,
        /// <summary>
        /// West of something.
        /// </summary>
          west,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the NorthOrSouth xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the NorthOrSouth xsd enumeration.")]
        public enum NorthOrSouth 
        {
        /// <summary>
        /// North of something.
        /// </summary>
          north,
        /// <summary>
        /// South of something.
        /// </summary>
          south,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the WellVerticalCoordinateUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
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
        /// This class represents the PercentUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PercentUom xsd enumeration.")]
        public enum PercentUom 
        {
        /// <summary>
        /// Item property
        /// </summary>
          [XmlEnum("%")]
          Item
        }
        /// <summary>
        /// This class represents the PlaneAngleUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PlaneAngleUom xsd enumeration.")]
        public enum PlaneAngleUom 
        {
        /// <summary>
        /// rad property
        /// </summary>
          rad,
        /// <summary>
        /// c property
        /// </summary>
          c,
        /// <summary>
        /// ccgr property
        /// </summary>
          ccgr,
        /// <summary>
        /// cgr property
        /// </summary>
          cgr,
        /// <summary>
        /// dega property
        /// </summary>
          dega,
        /// <summary>
        /// gon property
        /// </summary>
          gon,
        /// <summary>
        /// gr property
        /// </summary>
          gr,
        /// <summary>
        /// Grad property
        /// </summary>
          Grad,
        /// <summary>
        /// krad property
        /// </summary>
          krad,
        /// <summary>
        /// mila property
        /// </summary>
          mila,
        /// <summary>
        /// mina property
        /// </summary>
          mina,
        /// <summary>
        /// mrad property
        /// </summary>
          mrad,
        /// <summary>
        /// Mrad property
        /// </summary>
          Mrad,
        /// <summary>
        /// mseca property
        /// </summary>
          mseca,
        /// <summary>
        /// seca property
        /// </summary>
          seca,
        /// <summary>
        /// urad property
        /// </summary>
          urad
        }
        /// <summary>
        /// This class represents the AziRef xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the AziRef xsd enumeration.")]
        public enum AziRef 
        {
        /// <summary>
        /// magneticnorth property
        /// </summary>
          [XmlEnum("magnetic north")]
          magneticnorth,
        /// <summary>
        /// gridnorth property
        /// </summary>
          [XmlEnum("grid north")]
          gridnorth,
        /// <summary>
        /// truenorth property
        /// </summary>
          [XmlEnum("true north")]
          truenorth,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the VolumePerVolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the VolumePerVolumeUom xsd enumeration.")]
        public enum VolumePerVolumeUom 
        {
        /// <summary>
        /// Euc property
        /// </summary>
          Euc,
        /// <summary>
        /// Item property
        /// </summary>
          [XmlEnum("%")]
          Item,
        /// <summary>
        /// permil property
        /// </summary>
          permil,
        /// <summary>
        /// ppdk property
        /// </summary>
          ppdk,
        /// <summary>
        /// ppk property
        /// </summary>
          ppk,
        /// <summary>
        /// ppm property
        /// </summary>
          ppm,
        /// <summary>
        /// bblacreft property
        /// </summary>
          [XmlEnum("bbl/acre.ft")]
          bblacreft,
        /// <summary>
        /// bblbbl property
        /// </summary>
          [XmlEnum("bbl/bbl")]
          bblbbl,
        /// <summary>
        /// bblft3 property
        /// </summary>
          [XmlEnum("bbl/ft3")]
          bblft3,
        /// <summary>
        /// bbl100bbl property
        /// </summary>
          [XmlEnum("bbl/100bbl")]
          bbl100bbl,
        /// <summary>
        /// bblkft3 property
        /// </summary>
          [XmlEnum("bbl/k(ft3)")]
          bblkft3,
        /// <summary>
        /// bblMft3 property
        /// </summary>
          [XmlEnum("bbl/M(ft3)")]
          bblMft3,
        /// <summary>
        /// cm3cm3 property
        /// </summary>
          [XmlEnum("cm3/cm3")]
          cm3cm3,
        /// <summary>
        /// cm3m3 property
        /// </summary>
          [XmlEnum("cm3/m3")]
          cm3m3,
        /// <summary>
        /// dm3m3 property
        /// </summary>
          [XmlEnum("dm3/m3")]
          dm3m3,
        /// <summary>
        /// ft3bbl property
        /// </summary>
          [XmlEnum("ft3/bbl")]
          ft3bbl,
        /// <summary>
        /// ft3ft3 property
        /// </summary>
          [XmlEnum("ft3/ft3")]
          ft3ft3,
        /// <summary>
        /// galUSkgalUS property
        /// </summary>
          [XmlEnum("galUS/kgalUS")]
          galUSkgalUS,
        /// <summary>
        /// galUKkgalUK property
        /// </summary>
          [XmlEnum("galUK/kgalUK")]
          galUKkgalUK,
        /// <summary>
        /// galUKft3 property
        /// </summary>
          [XmlEnum("galUK/ft3")]
          galUKft3,
        /// <summary>
        /// galUKMbbl property
        /// </summary>
          [XmlEnum("galUK/Mbbl")]
          galUKMbbl,
        /// <summary>
        /// galUSbbl property
        /// </summary>
          [XmlEnum("galUS/bbl")]
          galUSbbl,
        /// <summary>
        /// galUS10bbl property
        /// </summary>
          [XmlEnum("galUS/10bbl")]
          galUS10bbl,
        /// <summary>
        /// galUSft3 property
        /// </summary>
          [XmlEnum("galUS/ft3")]
          galUSft3,
        /// <summary>
        /// galUSMbbl property
        /// </summary>
          [XmlEnum("galUS/Mbbl")]
          galUSMbbl,
        /// <summary>
        /// Item1000ft3bbl property
        /// </summary>
          [XmlEnum("1000ft3/bbl")]
          Item1000ft3bbl,
        /// <summary>
        /// ksm3sm3 property
        /// </summary>
          [XmlEnum("ksm3/sm3")]
          ksm3sm3,
        /// <summary>
        /// L10bbl property
        /// </summary>
          [XmlEnum("L/10bbl")]
          L10bbl,
        /// <summary>
        /// Lm3 property
        /// </summary>
          [XmlEnum("L/m3")]
          Lm3,
        /// <summary>
        /// m3ham property
        /// </summary>
          [XmlEnum("m3/ha.m")]
          m3ham,
        /// <summary>
        /// m3m3 property
        /// </summary>
          [XmlEnum("m3/m3")]
          m3m3,
        /// <summary>
        /// Mft3acreft property
        /// </summary>
          [XmlEnum("M(ft3)/acre.ft")]
          Mft3acreft,
        /// <summary>
        /// mLgalUK property
        /// </summary>
          [XmlEnum("mL/galUK")]
          mLgalUK,
        /// <summary>
        /// mLgalUS property
        /// </summary>
          [XmlEnum("mL/galUS")]
          mLgalUS,
        /// <summary>
        /// mLmL property
        /// </summary>
          [XmlEnum("mL/mL")]
          mLmL,
        /// <summary>
        /// MMbblacreft property
        /// </summary>
          [XmlEnum("MMbbl/acre.ft")]
          MMbblacreft,
        /// <summary>
        /// MMscf60stb60 property
        /// </summary>
          [XmlEnum("MMscf60/stb60")]
          MMscf60stb60,
        /// <summary>
        /// Mscf60stb60 property
        /// </summary>
          [XmlEnum("Mscf60/stb60")]
          Mscf60stb60,
        /// <summary>
        /// ptUKMbbl property
        /// </summary>
          [XmlEnum("ptUK/Mbbl")]
          ptUKMbbl,
        /// <summary>
        /// ptUS10bbl property
        /// </summary>
          [XmlEnum("ptUS/10bbl")]
          ptUS10bbl,
        /// <summary>
        /// pu property
        /// </summary>
          pu,
        /// <summary>
        /// scm15stb60 property
        /// </summary>
          [XmlEnum("scm15/stb60")]
          scm15stb60,
        /// <summary>
        /// sm3ksm3 property
        /// </summary>
          [XmlEnum("sm3/ksm3")]
          sm3ksm3,
        /// <summary>
        /// sm3sm3 property
        /// </summary>
          [XmlEnum("sm3/sm3")]
          sm3sm3,
        /// <summary>
        /// stb60MMscf60 property
        /// </summary>
          [XmlEnum("stb60/MMscf60")]
          stb60MMscf60,
        /// <summary>
        /// stb60MMscm15 property
        /// </summary>
          [XmlEnum("stb60/MMscm15")]
          stb60MMscm15,
        /// <summary>
        /// stb60Mscf60 property
        /// </summary>
          [XmlEnum("stb60/Mscf60")]
          stb60Mscf60,
        /// <summary>
        /// stb60Mscm15 property
        /// </summary>
          [XmlEnum("stb60/Mscm15")]
          stb60Mscm15,
        /// <summary>
        /// stb60scm15 property
        /// </summary>
          [XmlEnum("stb60/scm15")]
          stb60scm15
        }
        /// <summary>
        /// This class represents the VolumePerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the VolumePerLengthUom xsd enumeration.")]
        public enum VolumePerLengthUom 
        {
        /// <summary>
        /// bblPft property
        /// </summary>
          bblPft,
        /// <summary>
        /// bblPin property
        /// </summary>
          bblPin,
        /// <summary>
        /// bblPmi property
        /// </summary>
          bblPmi,
        /// <summary>
        /// dm3P100km property
        /// </summary>
          dm3P100km,
        /// <summary>
        /// dm3Pkm100 property
        /// </summary>
          [XmlEnum("dm3Pkm(100)")]
          dm3Pkm100,
        /// <summary>
        /// dm3Pm property
        /// </summary>
          dm3Pm,
        /// <summary>
        /// ft3Pft property
        /// </summary>
          ft3Pft,
        /// <summary>
        /// galUKPmi property
        /// </summary>
          galUKPmi,
        /// <summary>
        /// galUSPft property
        /// </summary>
          galUSPft,
        /// <summary>
        /// galUSPmi property
        /// </summary>
          galUSPmi,
        /// <summary>
        /// in3Pft property
        /// </summary>
          in3Pft,
        /// <summary>
        /// LP100km property
        /// </summary>
          LP100km,
        /// <summary>
        /// LPkm100 property
        /// </summary>
          [XmlEnum("LPkm(100)")]
          LPkm100,
        /// <summary>
        /// LPm property
        /// </summary>
          LPm,
        /// <summary>
        /// m3Pkm property
        /// </summary>
          m3Pkm,
        /// <summary>
        /// m3Pm property
        /// </summary>
          m3Pm
        }
        /// <summary>
        /// This class represents the VolumeFlowRateUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the VolumeFlowRateUom xsd enumeration.")]
        public enum VolumeFlowRateUom 
        {
        /// <summary>
        /// m3s property
        /// </summary>
          [XmlEnum("m3/s")]
          m3s,
        /// <summary>
        /// bbld property
        /// </summary>
          [XmlEnum("bbl/d")]
          bbld,
        /// <summary>
        /// bblhr property
        /// </summary>
          [XmlEnum("bbl/hr")]
          bblhr,
        /// <summary>
        /// bblmin property
        /// </summary>
          [XmlEnum("bbl/min")]
          bblmin,
        /// <summary>
        /// cm330min property
        /// </summary>
          [XmlEnum("cm3/30min")]
          cm330min,
        /// <summary>
        /// cm3h property
        /// </summary>
          [XmlEnum("cm3/h")]
          cm3h,
        /// <summary>
        /// cm3min property
        /// </summary>
          [XmlEnum("cm3/min")]
          cm3min,
        /// <summary>
        /// cm3s property
        /// </summary>
          [XmlEnum("cm3/s")]
          cm3s,
        /// <summary>
        /// dm3s property
        /// </summary>
          [XmlEnum("dm3/s")]
          dm3s,
        /// <summary>
        /// ft3d property
        /// </summary>
          [XmlEnum("ft3/d")]
          ft3d,
        /// <summary>
        /// ft3h property
        /// </summary>
          [XmlEnum("ft3/h")]
          ft3h,
        /// <summary>
        /// ft3min property
        /// </summary>
          [XmlEnum("ft3/min")]
          ft3min,
        /// <summary>
        /// ft3s property
        /// </summary>
          [XmlEnum("ft3/s")]
          ft3s,
        /// <summary>
        /// galUKd property
        /// </summary>
          [XmlEnum("galUK/d")]
          galUKd,
        /// <summary>
        /// galUKhr property
        /// </summary>
          [XmlEnum("galUK/hr")]
          galUKhr,
        /// <summary>
        /// galUKmin property
        /// </summary>
          [XmlEnum("galUK/min")]
          galUKmin,
        /// <summary>
        /// galUSd property
        /// </summary>
          [XmlEnum("galUS/d")]
          galUSd,
        /// <summary>
        /// galUShr property
        /// </summary>
          [XmlEnum("galUS/hr")]
          galUShr,
        /// <summary>
        /// galUSmin property
        /// </summary>
          [XmlEnum("galUS/min")]
          galUSmin,
        /// <summary>
        /// kbbld property
        /// </summary>
          [XmlEnum("kbbl/d")]
          kbbld,
        /// <summary>
        /// Item1000ft3d property
        /// </summary>
          [XmlEnum("1000ft3/d")]
          Item1000ft3d,
        /// <summary>
        /// Item1000m3d property
        /// </summary>
          [XmlEnum("1000m3/d")]
          Item1000m3d,
        /// <summary>
        /// Item1000m3h property
        /// </summary>
          [XmlEnum("1000m3/h")]
          Item1000m3h,
        /// <summary>
        /// Lh property
        /// </summary>
          [XmlEnum("L/h")]
          Lh,
        /// <summary>
        /// Lmin property
        /// </summary>
          [XmlEnum("L/min")]
          Lmin,
        /// <summary>
        /// Ls property
        /// </summary>
          [XmlEnum("L/s")]
          Ls,
        /// <summary>
        /// m3d property
        /// </summary>
          [XmlEnum("m3/d")]
          m3d,
        /// <summary>
        /// m3h property
        /// </summary>
          [XmlEnum("m3/h")]
          m3h,
        /// <summary>
        /// m3min property
        /// </summary>
          [XmlEnum("m3/min")]
          m3min,
        /// <summary>
        /// Mbbld property
        /// </summary>
          [XmlEnum("Mbbl/d")]
          Mbbld,
        /// <summary>
        /// Mft3d property
        /// </summary>
          [XmlEnum("M(ft3)/d")]
          Mft3d,
        /// <summary>
        /// Mm3d property
        /// </summary>
          [XmlEnum("M(m3)/d")]
          Mm3d
        }
        /// <summary>
        /// This class represents the VolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the VolumeUom xsd enumeration.")]
        public enum VolumeUom 
        {
        /// <summary>
        /// m3 property
        /// </summary>
          m3,
        /// <summary>
        /// acreft property
        /// </summary>
          [XmlEnum("acre.ft")]
          acreft,
        /// <summary>
        /// bbl property
        /// </summary>
          bbl,
        /// <summary>
        /// bcf property
        /// </summary>
          bcf,
        /// <summary>
        /// cm3 property
        /// </summary>
          cm3,
        /// <summary>
        /// dm3 property
        /// </summary>
          dm3,
        /// <summary>
        /// flozUK property
        /// </summary>
          flozUK,
        /// <summary>
        /// flozUS property
        /// </summary>
          flozUS,
        /// <summary>
        /// ft3 property
        /// </summary>
          ft3,
        /// <summary>
        /// galUK property
        /// </summary>
          galUK,
        /// <summary>
        /// galUS property
        /// </summary>
          galUS,
        /// <summary>
        /// ham property
        /// </summary>
          [XmlEnum("ha.m")]
          ham,
        /// <summary>
        /// hL property
        /// </summary>
          hL,
        /// <summary>
        /// in3 property
        /// </summary>
          in3,
        /// <summary>
        /// Item1000ft3 property
        /// </summary>
          [XmlEnum("1000ft3")]
          Item1000ft3,
        /// <summary>
        /// km3 property
        /// </summary>
          km3,
        /// <summary>
        /// L property
        /// </summary>
          L,
        /// <summary>
        /// Mbbl property
        /// </summary>
          Mbbl,
        /// <summary>
        /// Mcf property
        /// </summary>
          Mcf,
        /// <summary>
        /// Mft3 property
        /// </summary>
          [XmlEnum("M(ft3)")]
          Mft3,
        /// <summary>
        /// mi3 property
        /// </summary>
          mi3,
        /// <summary>
        /// mL property
        /// </summary>
          mL,
        /// <summary>
        /// Mm3 property
        /// </summary>
          [XmlEnum("M(m3)")]
          Mm3,
        /// <summary>
        /// mm3 property
        /// </summary>
          mm3,
        /// <summary>
        /// MMbbl property
        /// </summary>
          MMbbl,
        /// <summary>
        /// ptUK property
        /// </summary>
          ptUK,
        /// <summary>
        /// ptUS property
        /// </summary>
          ptUS,
        /// <summary>
        /// qtUK property
        /// </summary>
          qtUK,
        /// <summary>
        /// qtUS property
        /// </summary>
          qtUS,
        /// <summary>
        /// tcf property
        /// </summary>
          tcf,
        /// <summary>
        /// um2m property
        /// </summary>
          [XmlEnum("um2.m")]
          um2m,
        /// <summary>
        /// yd3 property
        /// </summary>
          yd3
        }
        /// <summary>
        /// This class represents the VelocityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the VelocityUom xsd enumeration.")]
        public enum VelocityUom 
        {
        /// <summary>
        /// ms property
        /// </summary>
          [XmlEnum("m/s")]
          ms,
        /// <summary>
        /// cma property
        /// </summary>
          [XmlEnum("cm/a")]
          cma,
        /// <summary>
        /// cms property
        /// </summary>
          [XmlEnum("cm/s")]
          cms,
        /// <summary>
        /// dms property
        /// </summary>
          [XmlEnum("dm/s")]
          dms,
        /// <summary>
        /// ftd property
        /// </summary>
          [XmlEnum("ft/d")]
          ftd,
        /// <summary>
        /// fth property
        /// </summary>
          [XmlEnum("ft/h")]
          fth,
        /// <summary>
        /// ftmin property
        /// </summary>
          [XmlEnum("ft/min")]
          ftmin,
        /// <summary>
        /// ftms property
        /// </summary>
          [XmlEnum("ft/ms")]
          ftms,
        /// <summary>
        /// fts property
        /// </summary>
          [XmlEnum("ft/s")]
          fts,
        /// <summary>
        /// ftus property
        /// </summary>
          [XmlEnum("ft/us")]
          ftus,
        /// <summary>
        /// ina property
        /// </summary>
          [XmlEnum("in/a")]
          ina,
        /// <summary>
        /// inmin property
        /// </summary>
          [XmlEnum("in/min")]
          inmin,
        /// <summary>
        /// ins property
        /// </summary>
          [XmlEnum("in/s")]
          ins,
        /// <summary>
        /// kfth property
        /// </summary>
          [XmlEnum("kft/h")]
          kfth,
        /// <summary>
        /// kfts property
        /// </summary>
          [XmlEnum("kft/s")]
          kfts,
        /// <summary>
        /// kmh property
        /// </summary>
          [XmlEnum("km/h")]
          kmh,
        /// <summary>
        /// kms property
        /// </summary>
          [XmlEnum("km/s")]
          kms,
        /// <summary>
        /// knot property
        /// </summary>
          knot,
        /// <summary>
        /// md property
        /// </summary>
          [XmlEnum("m/d")]
          md,
        /// <summary>
        /// mh property
        /// </summary>
          [XmlEnum("m/h")]
          mh,
        /// <summary>
        /// mmin property
        /// </summary>
          [XmlEnum("m/min")]
          mmin,
        /// <summary>
        /// mms property
        /// </summary>
          [XmlEnum("m/ms")]
          mms,
        /// <summary>
        /// mih property
        /// </summary>
          [XmlEnum("mi/h")]
          mih,
        /// <summary>
        /// milyr property
        /// </summary>
          [XmlEnum("mil/yr")]
          milyr,
        /// <summary>
        /// mma property
        /// </summary>
          [XmlEnum("mm/a")]
          mma,
        /// <summary>
        /// mms1 property
        /// </summary>
          [XmlEnum("mm/s")]
          mms1,
        /// <summary>
        /// nms property
        /// </summary>
          [XmlEnum("nm/s")]
          nms,
        /// <summary>
        /// ums property
        /// </summary>
          [XmlEnum("um/s")]
          ums
        }
        /// <summary>
        /// This class represents the TimeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the TimeUom xsd enumeration.")]
        public enum TimeUom 
        {
        /// <summary>
        /// s property
        /// </summary>
          s,
        /// <summary>
        /// a property
        /// </summary>
          a,
        /// <summary>
        /// cs property
        /// </summary>
          cs,
        /// <summary>
        /// d property
        /// </summary>
          d,
        /// <summary>
        /// Ga property
        /// </summary>
          Ga,
        /// <summary>
        /// h property
        /// </summary>
          h,
        /// <summary>
        /// Item100s property
        /// </summary>
          [XmlEnum("100s")]
          Item100s,
        /// <summary>
        /// Ma property
        /// </summary>
          Ma,
        /// <summary>
        /// min property
        /// </summary>
          min,
        /// <summary>
        /// ms property
        /// </summary>
          ms,
        /// <summary>
        /// ms2 property
        /// </summary>
          [XmlEnum("ms/2")]
          ms2,
        /// <summary>
        /// ns property
        /// </summary>
          ns,
        /// <summary>
        /// ps property
        /// </summary>
          ps,
        /// <summary>
        /// us property
        /// </summary>
          us,
        /// <summary>
        /// wk property
        /// </summary>
          wk,
        /// <summary>
        /// Item100ka property
        /// </summary>
          [XmlEnum("100ka")]
          Item100ka
        }
        /// <summary>
        /// This class represents the ThermodynamicTemperatureUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ThermodynamicTemperatureUom xsd enumeration.")]
        public enum ThermodynamicTemperatureUom 
        {
        /// <summary>
        /// K property
        /// </summary>
          K,
        /// <summary>
        /// degC property
        /// </summary>
          degC,
        /// <summary>
        /// degF property
        /// </summary>
          degF,
        /// <summary>
        /// degR property
        /// </summary>
          degR
        }
        /// <summary>
        /// This class represents the ThermalVolumetricExpansionUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ThermalVolumetricExpansionUom xsd enumeration.")]
        public enum ThermalVolumetricExpansionUom 
        {
        /// <summary>
        /// Item1K property
        /// </summary>
          [XmlEnum("1/K")]
          Item1K,
        /// <summary>
        /// ppmdegC property
        /// </summary>
          [XmlEnum("ppm/degC")]
          ppmdegC,
        /// <summary>
        /// ppmdegF property
        /// </summary>
          [XmlEnum("ppm/degF")]
          ppmdegF,
        /// <summary>
        /// Item1degC property
        /// </summary>
          [XmlEnum("1/degC")]
          Item1degC,
        /// <summary>
        /// Item1degF property
        /// </summary>
          [XmlEnum("1/degF")]
          Item1degF,
        /// <summary>
        /// Item1degR property
        /// </summary>
          [XmlEnum("1/degR")]
          Item1degR
        }
        /// <summary>
        /// This class represents the ThermalConductivityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ThermalConductivityUom xsd enumeration.")]
        public enum ThermalConductivityUom 
        {
        /// <summary>
        /// WmK property
        /// </summary>
          [XmlEnum("W/m.K")]
          WmK,
        /// <summary>
        /// BtuhrftdegF property
        /// </summary>
          [XmlEnum("Btu/hr.ft.degF")]
          BtuhrftdegF,
        /// <summary>
        /// calhcmdegC property
        /// </summary>
          [XmlEnum("cal/h.cm.degC")]
          calhcmdegC,
        /// <summary>
        /// kcalhmdegC property
        /// </summary>
          [XmlEnum("kcal/h.m.degC")]
          kcalhmdegC,
        /// <summary>
        /// calscmdegC property
        /// </summary>
          [XmlEnum("cal/s.cm.degC")]
          calscmdegC
        }
        /// <summary>
        /// This class represents the StandardVolumePerTimeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the StandardVolumePerTimeUom xsd enumeration.")]
        public enum StandardVolumePerTimeUom 
        {
        /// <summary>
        /// scf60Fd property
        /// </summary>
          [XmlEnum("scf(60F)/d")]
          scf60Fd,
        /// <summary>
        /// scm15Cs property
        /// </summary>
          [XmlEnum("scm(15C)/s")]
          scm15Cs,
        /// <summary>
        /// scm15Cd property
        /// </summary>
          [XmlEnum("scm(15C)/d")]
          scm15Cd,
        /// <summary>
        /// stb60Fd property
        /// </summary>
          [XmlEnum("stb(60F)/d")]
          stb60Fd,
        /// <summary>
        /// ksm3d property
        /// </summary>
          [XmlEnum("ksm3/d")]
          ksm3d,
        /// <summary>
        /// Mscm15Cd property
        /// </summary>
          [XmlEnum("Mscm(15C)/d")]
          Mscm15Cd,
        /// <summary>
        /// MMscm15Cd property
        /// </summary>
          [XmlEnum("MMscm(15C)/d")]
          MMscm15Cd,
        /// <summary>
        /// Mstb60Fd property
        /// </summary>
          [XmlEnum("Mstb(60F)/d")]
          Mstb60Fd,
        /// <summary>
        /// MMstb60Fd property
        /// </summary>
          [XmlEnum("MMstb(60F)/d")]
          MMstb60Fd,
        /// <summary>
        /// Mscf60Fd property
        /// </summary>
          [XmlEnum("Mscf(60F)/d")]
          Mscf60Fd,
        /// <summary>
        /// MMscf60Fd property
        /// </summary>
          [XmlEnum("MMscf(60F)/d")]
          MMscf60Fd
        }
        /// <summary>
        /// This class represents the StandardVolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the StandardVolumeUom xsd enumeration.")]
        public enum StandardVolumeUom 
        {
        /// <summary>
        /// scm15C property
        /// </summary>
          [XmlEnum("scm(15C)")]
          scm15C,
        /// <summary>
        /// scm0C property
        /// </summary>
          [XmlEnum("scm(0C)")]
          scm0C,
        /// <summary>
        /// Gsm3 property
        /// </summary>
          Gsm3,
        /// <summary>
        /// ksm3 property
        /// </summary>
          ksm3,
        /// <summary>
        /// MMscf60F property
        /// </summary>
          [XmlEnum("MMscf(60F)")]
          MMscf60F,
        /// <summary>
        /// MMscm15C property
        /// </summary>
          [XmlEnum("MMscm(15C)")]
          MMscm15C,
        /// <summary>
        /// MMstb60F property
        /// </summary>
          [XmlEnum("MMstb(60F)")]
          MMstb60F,
        /// <summary>
        /// Mscf60F property
        /// </summary>
          [XmlEnum("Mscf(60F)")]
          Mscf60F,
        /// <summary>
        /// Mstb60F property
        /// </summary>
          [XmlEnum("Mstb(60F)")]
          Mstb60F,
        /// <summary>
        /// scf60F property
        /// </summary>
          [XmlEnum("scf(60F)")]
          scf60F,
        /// <summary>
        /// stb60F property
        /// </summary>
          [XmlEnum("stb(60F)")]
          stb60F
        }
        /// <summary>
        /// This class represents the SpecificVolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the SpecificVolumeUom xsd enumeration.")]
        public enum SpecificVolumeUom 
        {
        /// <summary>
        /// m3kg property
        /// </summary>
          [XmlEnum("m3/kg")]
          m3kg,
        /// <summary>
        /// bbltonUK property
        /// </summary>
          [XmlEnum("bbl/tonUK")]
          bbltonUK,
        /// <summary>
        /// bbltonUS property
        /// </summary>
          [XmlEnum("bbl/tonUS")]
          bbltonUS,
        /// <summary>
        /// cm3g property
        /// </summary>
          [XmlEnum("cm3/g")]
          cm3g,
        /// <summary>
        /// dm3kg property
        /// </summary>
          [XmlEnum("dm3/kg")]
          dm3kg,
        /// <summary>
        /// dm3t property
        /// </summary>
          [XmlEnum("dm3/t")]
          dm3t,
        /// <summary>
        /// ft3kg property
        /// </summary>
          [XmlEnum("ft3/kg")]
          ft3kg,
        /// <summary>
        /// ft3lbm property
        /// </summary>
          [XmlEnum("ft3/lbm")]
          ft3lbm,
        /// <summary>
        /// ft3sack94 property
        /// </summary>
          [XmlEnum("ft3/sack94")]
          ft3sack94,
        /// <summary>
        /// galUSsack94 property
        /// </summary>
          [XmlEnum("galUS/sack94")]
          galUSsack94,
        /// <summary>
        /// galUKlbm property
        /// </summary>
          [XmlEnum("galUK/lbm")]
          galUKlbm,
        /// <summary>
        /// galUSlbm property
        /// </summary>
          [XmlEnum("galUS/lbm")]
          galUSlbm,
        /// <summary>
        /// galUStonUK property
        /// </summary>
          [XmlEnum("galUS/tonUK")]
          galUStonUK,
        /// <summary>
        /// galUStonUS property
        /// </summary>
          [XmlEnum("galUS/tonUS")]
          galUStonUS,
        /// <summary>
        /// L100kg property
        /// </summary>
          [XmlEnum("L/100kg")]
          L100kg,
        /// <summary>
        /// Lkg property
        /// </summary>
          [XmlEnum("L/kg")]
          Lkg,
        /// <summary>
        /// Lt property
        /// </summary>
          [XmlEnum("L/t")]
          Lt,
        /// <summary>
        /// LtonUK property
        /// </summary>
          [XmlEnum("L/tonUK")]
          LtonUK,
        /// <summary>
        /// m3g property
        /// </summary>
          [XmlEnum("m3/g")]
          m3g,
        /// <summary>
        /// m3t property
        /// </summary>
          [XmlEnum("m3/t")]
          m3t,
        /// <summary>
        /// m3tonUK property
        /// </summary>
          [XmlEnum("m3/tonUK")]
          m3tonUK,
        /// <summary>
        /// m3tonUS property
        /// </summary>
          [XmlEnum("m3/tonUS")]
          m3tonUS
        }
        /// <summary>
        /// This class represents the SpecificHeatCapacityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the SpecificHeatCapacityUom xsd enumeration.")]
        public enum SpecificHeatCapacityUom 
        {
        /// <summary>
        /// JkgK property
        /// </summary>
          [XmlEnum("J/kg.K")]
          JkgK,
        /// <summary>
        /// BtulbmdegF property
        /// </summary>
          [XmlEnum("Btu/lbm.degF")]
          BtulbmdegF,
        /// <summary>
        /// BtulbmdegR property
        /// </summary>
          [XmlEnum("Btu/lbm.degR")]
          BtulbmdegR,
        /// <summary>
        /// calgK property
        /// </summary>
          [XmlEnum("cal/g.K")]
          calgK,
        /// <summary>
        /// JgK property
        /// </summary>
          [XmlEnum("J/g.K")]
          JgK,
        /// <summary>
        /// kcalkgdegC property
        /// </summary>
          [XmlEnum("kcal/kg.degC")]
          kcalkgdegC,
        /// <summary>
        /// kJkgK property
        /// </summary>
          [XmlEnum("kJ/kg.K")]
          kJkgK,
        /// <summary>
        /// kWhkgdegC property
        /// </summary>
          [XmlEnum("kW.h/kg.degC")]
          kWhkgdegC
        }
        /// <summary>
        /// This class represents the RelativePowerUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the RelativePowerUom xsd enumeration.")]
        public enum RelativePowerUom 
        {
        /// <summary>
        /// Item property
        /// </summary>
          [XmlEnum("%")]
          Item,
        /// <summary>
        /// Btubhphr property
        /// </summary>
          [XmlEnum("Btu/bhp.hr")]
          Btubhphr,
        /// <summary>
        /// WkW property
        /// </summary>
          [XmlEnum("W/kW")]
          WkW,
        /// <summary>
        /// WW property
        /// </summary>
          [XmlEnum("W/W")]
          WW
        }
        /// <summary>
        /// This class represents the PressureUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PressureUom xsd enumeration.")]
        public enum PressureUom 
        {
        /// <summary>
        /// Pa property
        /// </summary>
          Pa,
        /// <summary>
        /// at property
        /// </summary>
          at,
        /// <summary>
        /// atm property
        /// </summary>
          atm,
        /// <summary>
        /// bar property
        /// </summary>
          bar,
        /// <summary>
        /// cmH2O4degC property
        /// </summary>
          [XmlEnum("cmH2O(4degC)")]
          cmH2O4degC,
        /// <summary>
        /// dynecm2 property
        /// </summary>
          [XmlEnum("dyne/cm2")]
          dynecm2,
        /// <summary>
        /// GPa property
        /// </summary>
          GPa,
        /// <summary>
        /// hbar property
        /// </summary>
          hbar,
        /// <summary>
        /// inH2O392F property
        /// </summary>
          [XmlEnum("inH2O(39.2F)")]
          inH2O392F,
        /// <summary>
        /// inH2O60F property
        /// </summary>
          [XmlEnum("inH2O(60F)")]
          inH2O60F,
        /// <summary>
        /// inHg32F property
        /// </summary>
          [XmlEnum("inHg(32F)")]
          inHg32F,
        /// <summary>
        /// inHg60F property
        /// </summary>
          [XmlEnum("inHg(60F)")]
          inHg60F,
        /// <summary>
        /// kgfcm2 property
        /// </summary>
          [XmlEnum("kgf/cm2")]
          kgfcm2,
        /// <summary>
        /// kgfmm2 property
        /// </summary>
          [XmlEnum("kgf/mm2")]
          kgfmm2,
        /// <summary>
        /// kNm2 property
        /// </summary>
          [XmlEnum("kN/m2")]
          kNm2,
        /// <summary>
        /// kPa property
        /// </summary>
          kPa,
        /// <summary>
        /// kpsi property
        /// </summary>
          kpsi,
        /// <summary>
        /// lbfft2 property
        /// </summary>
          [XmlEnum("lbf/ft2")]
          lbfft2,
        /// <summary>
        /// lbf100ft2 property
        /// </summary>
          [XmlEnum("lbf/100ft2")]
          lbf100ft2,
        /// <summary>
        /// lbfin2 property
        /// </summary>
          [XmlEnum("lbf/in2")]
          lbfin2,
        /// <summary>
        /// mbar property
        /// </summary>
          mbar,
        /// <summary>
        /// mmHg0C property
        /// </summary>
          [XmlEnum("mmHg(0C)")]
          mmHg0C,
        /// <summary>
        /// mPa property
        /// </summary>
          mPa,
        /// <summary>
        /// MPa property
        /// </summary>
          MPa,
        /// <summary>
        /// Mpsi property
        /// </summary>
          Mpsi,
        /// <summary>
        /// Nm2 property
        /// </summary>
          [XmlEnum("N/m2")]
          Nm2,
        /// <summary>
        /// Nmm2 property
        /// </summary>
          [XmlEnum("N/mm2")]
          Nmm2,
        /// <summary>
        /// Pag property
        /// </summary>
          [XmlEnum("Pa(g)")]
          Pag,
        /// <summary>
        /// pPa property
        /// </summary>
          pPa,
        /// <summary>
        /// psi property
        /// </summary>
          psi,
        /// <summary>
        /// psia property
        /// </summary>
          psia,
        /// <summary>
        /// psig property
        /// </summary>
          psig,
        /// <summary>
        /// tonfUSft2 property
        /// </summary>
          [XmlEnum("tonfUS/ft2")]
          tonfUSft2,
        /// <summary>
        /// tonfUSin2 property
        /// </summary>
          [XmlEnum("tonfUS/in2")]
          tonfUSin2,
        /// <summary>
        /// torr property
        /// </summary>
          torr,
        /// <summary>
        /// ubar property
        /// </summary>
          ubar,
        /// <summary>
        /// umHg0C property
        /// </summary>
          [XmlEnum("umHg(0C)")]
          umHg0C,
        /// <summary>
        /// uPa property
        /// </summary>
          uPa,
        /// <summary>
        /// upsi property
        /// </summary>
          upsi
        }
        /// <summary>
        /// This class represents the PowerUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PowerUom xsd enumeration.")]
        public enum PowerUom 
        {
        /// <summary>
        /// W property
        /// </summary>
          W,
        /// <summary>
        /// ch property
        /// </summary>
          ch,
        /// <summary>
        /// CV property
        /// </summary>
          CV,
        /// <summary>
        /// ehp property
        /// </summary>
          ehp,
        /// <summary>
        /// GW property
        /// </summary>
          GW,
        /// <summary>
        /// hhp property
        /// </summary>
          hhp,
        /// <summary>
        /// hp property
        /// </summary>
          hp,
        /// <summary>
        /// kcalh property
        /// </summary>
          [XmlEnum("kcal/h")]
          kcalh,
        /// <summary>
        /// kW property
        /// </summary>
          kW,
        /// <summary>
        /// MJa property
        /// </summary>
          [XmlEnum("MJ/a")]
          MJa,
        /// <summary>
        /// MW property
        /// </summary>
          MW,
        /// <summary>
        /// mW property
        /// </summary>
          mW,
        /// <summary>
        /// nW property
        /// </summary>
          nW,
        /// <summary>
        /// tonofrefrig property
        /// </summary>
          [XmlEnum("ton of refrig")]
          tonofrefrig,
        /// <summary>
        /// TW property
        /// </summary>
          TW,
        /// <summary>
        /// uW property
        /// </summary>
          uW
        }
        /// <summary>
        /// This class represents the PermeabilityRockUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PermeabilityRockUom xsd enumeration.")]
        public enum PermeabilityRockUom 
        {
        /// <summary>
        /// D property
        /// </summary>
          D,
        /// <summary>
        /// mD property
        /// </summary>
          mD
        }
        /// <summary>
        /// This class represents the PerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PerLengthUom xsd enumeration.")]
        public enum PerLengthUom 
        {
        /// <summary>
        /// Item1m property
        /// </summary>
          [XmlEnum("1/m")]
          Item1m,
        /// <summary>
        /// Item1angstrom property
        /// </summary>
          [XmlEnum("1/angstrom")]
          Item1angstrom,
        /// <summary>
        /// Item1cm property
        /// </summary>
          [XmlEnum("1/cm")]
          Item1cm,
        /// <summary>
        /// Item1ft property
        /// </summary>
          [XmlEnum("1/ft")]
          Item1ft,
        /// <summary>
        /// Item1in property
        /// </summary>
          [XmlEnum("1/in")]
          Item1in,
        /// <summary>
        /// Item1mi property
        /// </summary>
          [XmlEnum("1/mi")]
          Item1mi,
        /// <summary>
        /// Item1mm property
        /// </summary>
          [XmlEnum("1/mm")]
          Item1mm,
        /// <summary>
        /// Item1nm property
        /// </summary>
          [XmlEnum("1/nm")]
          Item1nm,
        /// <summary>
        /// Item1yd property
        /// </summary>
          [XmlEnum("1/yd")]
          Item1yd
        }
        /// <summary>
        /// This class represents the MomentOfForceUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the MomentOfForceUom xsd enumeration.")]
        public enum MomentOfForceUom 
        {
        /// <summary>
        /// J property
        /// </summary>
          J,
        /// <summary>
        /// dNm property
        /// </summary>
          [XmlEnum("dN.m")]
          dNm,
        /// <summary>
        /// daNm property
        /// </summary>
          [XmlEnum("daN.m")]
          daNm,
        /// <summary>
        /// ftlbf property
        /// </summary>
          [XmlEnum("ft.lbf")]
          ftlbf,
        /// <summary>
        /// kftlbf property
        /// </summary>
          [XmlEnum("kft.lbf")]
          kftlbf,
        /// <summary>
        /// kgfm property
        /// </summary>
          [XmlEnum("kgf.m")]
          kgfm,
        /// <summary>
        /// kNm property
        /// </summary>
          [XmlEnum("kN.m")]
          kNm,
        /// <summary>
        /// lbfft property
        /// </summary>
          [XmlEnum("lbf.ft")]
          lbfft,
        /// <summary>
        /// lbfin property
        /// </summary>
          [XmlEnum("lbf.in")]
          lbfin,
        /// <summary>
        /// lbmft2s2 property
        /// </summary>
          [XmlEnum("lbm.ft2/s2")]
          lbmft2s2,
        /// <summary>
        /// Nm property
        /// </summary>
          [XmlEnum("N.m")]
          Nm,
        /// <summary>
        /// pdlft property
        /// </summary>
          [XmlEnum("pdl.ft")]
          pdlft,
        /// <summary>
        /// tonfUSft property
        /// </summary>
          [XmlEnum("tonfUS.ft")]
          tonfUSft,
        /// <summary>
        /// tonfUSmi property
        /// </summary>
          [XmlEnum("tonfUS.mi")]
          tonfUSmi
        }
        /// <summary>
        /// This class represents the MassPerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the MassPerLengthUom xsd enumeration.")]
        public enum MassPerLengthUom 
        {
        /// <summary>
        /// kgm property
        /// </summary>
          [XmlEnum("kg/m")]
          kgm,
        /// <summary>
        /// klbmin property
        /// </summary>
          [XmlEnum("klbm/in")]
          klbmin,
        /// <summary>
        /// lbmft property
        /// </summary>
          [XmlEnum("lbm/ft")]
          lbmft,
        /// <summary>
        /// Mgin property
        /// </summary>
          [XmlEnum("Mg/in")]
          Mgin,
        /// <summary>
        /// kgmcm2 property
        /// </summary>
          [XmlEnum("kg.m/cm2")]
          kgmcm2
        }
        /// <summary>
        /// This class represents the MassUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the MassUom xsd enumeration.")]
        public enum MassUom 
        {
        /// <summary>
        /// kg property
        /// </summary>
          kg,
        /// <summary>
        /// ag property
        /// </summary>
          ag,
        /// <summary>
        /// ct property
        /// </summary>
          ct,
        /// <summary>
        /// cwtUK property
        /// </summary>
          cwtUK,
        /// <summary>
        /// cwtUS property
        /// </summary>
          cwtUS,
        /// <summary>
        /// g property
        /// </summary>
          g,
        /// <summary>
        /// grain property
        /// </summary>
          grain,
        /// <summary>
        /// klbm property
        /// </summary>
          klbm,
        /// <summary>
        /// lbm property
        /// </summary>
          lbm,
        /// <summary>
        /// Mg property
        /// </summary>
          Mg,
        /// <summary>
        /// mg property
        /// </summary>
          mg,
        /// <summary>
        /// ozav property
        /// </summary>
          [XmlEnum("oz(av)")]
          ozav,
        /// <summary>
        /// oztroy property
        /// </summary>
          [XmlEnum("oz(troy)")]
          oztroy,
        /// <summary>
        /// ozm property
        /// </summary>
          ozm,
        /// <summary>
        /// sack94 property
        /// </summary>
          sack94,
        /// <summary>
        /// t property
        /// </summary>
          t,
        /// <summary>
        /// tonUK property
        /// </summary>
          tonUK,
        /// <summary>
        /// tonUS property
        /// </summary>
          tonUS,
        /// <summary>
        /// ug property
        /// </summary>
          ug
        }
        /// <summary>
        /// This class represents the MassConcentrationUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the MassConcentrationUom xsd enumeration.")]
        public enum MassConcentrationUom 
        {
        /// <summary>
        /// Euc property
        /// </summary>
          Euc,
        /// <summary>
        /// Item property
        /// </summary>
          [XmlEnum("%")]
          Item,
        /// <summary>
        /// gkg property
        /// </summary>
          [XmlEnum("g/kg")]
          gkg,
        /// <summary>
        /// kgkg property
        /// </summary>
          [XmlEnum("kg/kg")]
          kgkg,
        /// <summary>
        /// kgsack94 property
        /// </summary>
          [XmlEnum("kg/sack94")]
          kgsack94,
        /// <summary>
        /// mgkg property
        /// </summary>
          [XmlEnum("mg/kg")]
          mgkg,
        /// <summary>
        /// permil property
        /// </summary>
          permil,
        /// <summary>
        /// ppdk property
        /// </summary>
          ppdk,
        /// <summary>
        /// ppk property
        /// </summary>
          ppk,
        /// <summary>
        /// ppm property
        /// </summary>
          ppm
        }
        /// <summary>
        /// This class represents the MagneticInductionUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the MagneticInductionUom xsd enumeration.")]
        public enum MagneticInductionUom 
        {
        /// <summary>
        /// T property
        /// </summary>
          T,
        /// <summary>
        /// gauss property
        /// </summary>
          gauss,
        /// <summary>
        /// mT property
        /// </summary>
          mT,
        /// <summary>
        /// mgauss property
        /// </summary>
          mgauss,
        /// <summary>
        /// nT property
        /// </summary>
          nT,
        /// <summary>
        /// uT property
        /// </summary>
          uT
        }
        /// <summary>
        /// This class represents the LengthPerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the LengthPerLengthUom xsd enumeration.")]
        public enum LengthPerLengthUom 
        {
        /// <summary>
        /// Item property
        /// </summary>
          [XmlEnum("%")]
          Item,
        /// <summary>
        /// ft100ft property
        /// </summary>
          [XmlEnum("ft/100ft")]
          ft100ft,
        /// <summary>
        /// ftft property
        /// </summary>
          [XmlEnum("ft/ft")]
          ftft,
        /// <summary>
        /// ftin property
        /// </summary>
          [XmlEnum("ft/in")]
          ftin,
        /// <summary>
        /// ftm property
        /// </summary>
          [XmlEnum("ft/m")]
          ftm,
        /// <summary>
        /// ftmi property
        /// </summary>
          [XmlEnum("ft/mi")]
          ftmi,
        /// <summary>
        /// kmcm property
        /// </summary>
          [XmlEnum("km/cm")]
          kmcm,
        /// <summary>
        /// m30m property
        /// </summary>
          [XmlEnum("m/30m")]
          m30m,
        /// <summary>
        /// mcm property
        /// </summary>
          [XmlEnum("m/cm")]
          mcm,
        /// <summary>
        /// mkm property
        /// </summary>
          [XmlEnum("m/km")]
          mkm,
        /// <summary>
        /// mm property
        /// </summary>
          [XmlEnum("m/m")]
          mm,
        /// <summary>
        /// miin property
        /// </summary>
          [XmlEnum("mi/in")]
          miin
        }
        /// <summary>
        /// This class represents the IlluminanceUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the IlluminanceUom xsd enumeration.")]
        public enum IlluminanceUom 
        {
        /// <summary>
        /// lx property
        /// </summary>
          lx,
        /// <summary>
        /// lmm2 property
        /// </summary>
          [XmlEnum("lm/m2")]
          lmm2,
        /// <summary>
        /// footcandle property
        /// </summary>
          footcandle,
        /// <summary>
        /// klx property
        /// </summary>
          klx
        }
        /// <summary>
        /// This class represents the ForcePerVolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ForcePerVolumeUom xsd enumeration.")]
        public enum ForcePerVolumeUom 
        {
        /// <summary>
        /// Nm3 property
        /// </summary>
          [XmlEnum("N/m3")]
          Nm3,
        /// <summary>
        /// atm100m property
        /// </summary>
          [XmlEnum("atm/100m")]
          atm100m,
        /// <summary>
        /// atmm property
        /// </summary>
          [XmlEnum("atm/m")]
          atmm,
        /// <summary>
        /// barkm property
        /// </summary>
          [XmlEnum("bar/km")]
          barkm,
        /// <summary>
        /// barm property
        /// </summary>
          [XmlEnum("bar/m")]
          barm,
        /// <summary>
        /// GPacm property
        /// </summary>
          [XmlEnum("GPa/cm")]
          GPacm,
        /// <summary>
        /// kPa100m property
        /// </summary>
          [XmlEnum("kPa/100m")]
          kPa100m,
        /// <summary>
        /// kPam property
        /// </summary>
          [XmlEnum("kPa/m")]
          kPam,
        /// <summary>
        /// lbfft3 property
        /// </summary>
          [XmlEnum("lbf/ft3")]
          lbfft3,
        /// <summary>
        /// lbfgalUS property
        /// </summary>
          [XmlEnum("lbf/galUS")]
          lbfgalUS,
        /// <summary>
        /// MPam property
        /// </summary>
          [XmlEnum("MPa/m")]
          MPam,
        /// <summary>
        /// psift property
        /// </summary>
          [XmlEnum("psi/ft")]
          psift,
        /// <summary>
        /// psi100ft property
        /// </summary>
          [XmlEnum("psi/100ft")]
          psi100ft,
        /// <summary>
        /// psikft property
        /// </summary>
          [XmlEnum("psi/kft")]
          psikft,
        /// <summary>
        /// psim property
        /// </summary>
          [XmlEnum("psi/m")]
          psim,
        /// <summary>
        /// Pam property
        /// </summary>
          [XmlEnum("Pa/m")]
          Pam,
        /// <summary>
        /// atmft property
        /// </summary>
          [XmlEnum("atm/ft")]
          atmft
        }
        /// <summary>
        /// This class represents the ForcePerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ForcePerLengthUom xsd enumeration.")]
        public enum ForcePerLengthUom 
        {
        /// <summary>
        /// N30m property
        /// </summary>
          [XmlEnum("N/30m")]
          N30m,
        /// <summary>
        /// Nm property
        /// </summary>
          [XmlEnum("N/m")]
          Nm,
        /// <summary>
        /// dynecm property
        /// </summary>
          [XmlEnum("dyne/cm")]
          dynecm,
        /// <summary>
        /// kNm property
        /// </summary>
          [XmlEnum("kN/m")]
          kNm,
        /// <summary>
        /// kgfcm property
        /// </summary>
          [XmlEnum("kgf/cm")]
          kgfcm,
        /// <summary>
        /// lbf100ft property
        /// </summary>
          [XmlEnum("lbf/100ft")]
          lbf100ft,
        /// <summary>
        /// lbf30m property
        /// </summary>
          [XmlEnum("lbf/30m")]
          lbf30m,
        /// <summary>
        /// lbfft property
        /// </summary>
          [XmlEnum("lbf/ft")]
          lbfft,
        /// <summary>
        /// lbfin property
        /// </summary>
          [XmlEnum("lbf/in")]
          lbfin,
        /// <summary>
        /// mNkm property
        /// </summary>
          [XmlEnum("mN/km")]
          mNkm,
        /// <summary>
        /// mNm property
        /// </summary>
          [XmlEnum("mN/m")]
          mNm,
        /// <summary>
        /// pdlcm property
        /// </summary>
          [XmlEnum("pdl/cm")]
          pdlcm,
        /// <summary>
        /// tonfUKft property
        /// </summary>
          [XmlEnum("tonfUK/ft")]
          tonfUKft,
        /// <summary>
        /// tonfUSft property
        /// </summary>
          [XmlEnum("tonfUS/ft")]
          tonfUSft
        }
        /// <summary>
        /// This class represents the ForceUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ForceUom xsd enumeration.")]
        public enum ForceUom 
        {
        /// <summary>
        /// N property
        /// </summary>
          N,
        /// <summary>
        /// daN property
        /// </summary>
          daN,
        /// <summary>
        /// dyne property
        /// </summary>
          dyne,
        /// <summary>
        /// gf property
        /// </summary>
          gf,
        /// <summary>
        /// kdyne property
        /// </summary>
          kdyne,
        /// <summary>
        /// kgf property
        /// </summary>
          kgf,
        /// <summary>
        /// klbf property
        /// </summary>
          klbf,
        /// <summary>
        /// kN property
        /// </summary>
          kN,
        /// <summary>
        /// lbf property
        /// </summary>
          lbf,
        /// <summary>
        /// Mgf property
        /// </summary>
          Mgf,
        /// <summary>
        /// mN property
        /// </summary>
          mN,
        /// <summary>
        /// MN property
        /// </summary>
          MN,
        /// <summary>
        /// ozf property
        /// </summary>
          ozf,
        /// <summary>
        /// pdl property
        /// </summary>
          pdl,
        /// <summary>
        /// tonfUK property
        /// </summary>
          tonfUK,
        /// <summary>
        /// tonfUS property
        /// </summary>
          tonfUS,
        /// <summary>
        /// uN property
        /// </summary>
          uN
        }
        /// <summary>
        /// This class represents the EquivalentPerMassUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the EquivalentPerMassUom xsd enumeration.")]
        public enum EquivalentPerMassUom 
        {
        /// <summary>
        /// eqkg property
        /// </summary>
          [XmlEnum("eq/kg")]
          eqkg,
        /// <summary>
        /// meqg property
        /// </summary>
          [XmlEnum("meq/g")]
          meqg,
        /// <summary>
        /// meq100g property
        /// </summary>
          [XmlEnum("meq/100g")]
          meq100g
        }
        /// <summary>
        /// This class represents the ElectricPotentialUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ElectricPotentialUom xsd enumeration.")]
        public enum ElectricPotentialUom 
        {
        /// <summary>
        /// V property
        /// </summary>
          V,
        /// <summary>
        /// kV property
        /// </summary>
          kV,
        /// <summary>
        /// mV property
        /// </summary>
          mV,
        /// <summary>
        /// MV property
        /// </summary>
          MV,
        /// <summary>
        /// uV property
        /// </summary>
          uV
        }
        /// <summary>
        /// This class represents the ElectricCurrentUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ElectricCurrentUom xsd enumeration.")]
        public enum ElectricCurrentUom 
        {
        /// <summary>
        /// A property
        /// </summary>
          A,
        /// <summary>
        /// MA property
        /// </summary>
          MA,
        /// <summary>
        /// kA property
        /// </summary>
          kA,
        /// <summary>
        /// mA property
        /// </summary>
          mA,
        /// <summary>
        /// nA property
        /// </summary>
          nA,
        /// <summary>
        /// pA property
        /// </summary>
          pA,
        /// <summary>
        /// uA property
        /// </summary>
          uA
        }
        /// <summary>
        /// This class represents the DynamicViscosityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the DynamicViscosityUom xsd enumeration.")]
        public enum DynamicViscosityUom 
        {
        /// <summary>
        /// Pas property
        /// </summary>
          [XmlEnum("Pa.s")]
          Pas,
        /// <summary>
        /// cP property
        /// </summary>
          cP,
        /// <summary>
        /// P property
        /// </summary>
          P,
        /// <summary>
        /// psis property
        /// </summary>
          [XmlEnum("psi.s")]
          psis,
        /// <summary>
        /// dynescm2 property
        /// </summary>
          [XmlEnum("dyne.s/cm2")]
          dynescm2,
        /// <summary>
        /// kgfsm2 property
        /// </summary>
          [XmlEnum("kgf.s/m2")]
          kgfsm2,
        /// <summary>
        /// lbfsft2 property
        /// </summary>
          [XmlEnum("lbf.s/ft2")]
          lbfsft2,
        /// <summary>
        /// lbfsin2 property
        /// </summary>
          [XmlEnum("lbf.s/in2")]
          lbfsin2,
        /// <summary>
        /// mPas property
        /// </summary>
          [XmlEnum("mPa.s")]
          mPas,
        /// <summary>
        /// Nsm2 property
        /// </summary>
          [XmlEnum("N.s/m2")]
          Nsm2
        }
        /// <summary>
        /// This class represents the DimensionlessUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the DimensionlessUom xsd enumeration.")]
        public enum DimensionlessUom 
        {
        /// <summary>
        /// Euc property
        /// </summary>
          Euc,
        /// <summary>
        /// Item property
        /// </summary>
          [XmlEnum("%")]
          Item,
        /// <summary>
        /// cEuc property
        /// </summary>
          cEuc,
        /// <summary>
        /// mEuc property
        /// </summary>
          mEuc,
        /// <summary>
        /// nEuc property
        /// </summary>
          nEuc,
        /// <summary>
        /// uEuc property
        /// </summary>
          uEuc
        }
        /// <summary>
        /// This class represents the DensityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the DensityUom xsd enumeration.")]
        public enum DensityUom 
        {
        /// <summary>
        /// kgm3 property
        /// </summary>
          [XmlEnum("kg/m3")]
          kgm3,
        /// <summary>
        /// Item10Mgm3 property
        /// </summary>
          [XmlEnum("10Mg/m3")]
          Item10Mgm3,
        /// <summary>
        /// dAPI property
        /// </summary>
          dAPI,
        /// <summary>
        /// gcm3 property
        /// </summary>
          [XmlEnum("g/cm3")]
          gcm3,
        /// <summary>
        /// gdm3 property
        /// </summary>
          [XmlEnum("g/dm3")]
          gdm3,
        /// <summary>
        /// ggalUK property
        /// </summary>
          [XmlEnum("g/galUK")]
          ggalUK,
        /// <summary>
        /// ggalUS property
        /// </summary>
          [XmlEnum("g/galUS")]
          ggalUS,
        /// <summary>
        /// gL property
        /// </summary>
          [XmlEnum("g/L")]
          gL,
        /// <summary>
        /// gm3 property
        /// </summary>
          [XmlEnum("g/m3")]
          gm3,
        /// <summary>
        /// grainft3 property
        /// </summary>
          [XmlEnum("grain/ft3")]
          grainft3,
        /// <summary>
        /// graingalUS property
        /// </summary>
          [XmlEnum("grain/galUS")]
          graingalUS,
        /// <summary>
        /// grain100ft3 property
        /// </summary>
          [XmlEnum("grain/100ft3")]
          grain100ft3,
        /// <summary>
        /// kgdm3 property
        /// </summary>
          [XmlEnum("kg/dm3")]
          kgdm3,
        /// <summary>
        /// kgL property
        /// </summary>
          [XmlEnum("kg/L")]
          kgL,
        /// <summary>
        /// Mgm3 property
        /// </summary>
          [XmlEnum("Mg/m3")]
          Mgm3,
        /// <summary>
        /// lbm10bbl property
        /// </summary>
          [XmlEnum("lbm/10bbl")]
          lbm10bbl,
        /// <summary>
        /// lbmbbl property
        /// </summary>
          [XmlEnum("lbm/bbl")]
          lbmbbl,
        /// <summary>
        /// lbmft3 property
        /// </summary>
          [XmlEnum("lbm/ft3")]
          lbmft3,
        /// <summary>
        /// lbmgalUK property
        /// </summary>
          [XmlEnum("lbm/galUK")]
          lbmgalUK,
        /// <summary>
        /// lbm1000galUK property
        /// </summary>
          [XmlEnum("lbm/1000galUK")]
          lbm1000galUK,
        /// <summary>
        /// lbmgalUS property
        /// </summary>
          [XmlEnum("lbm/galUS")]
          lbmgalUS,
        /// <summary>
        /// lbm1000galUS property
        /// </summary>
          [XmlEnum("lbm/1000galUS")]
          lbm1000galUS,
        /// <summary>
        /// lbmin3 property
        /// </summary>
          [XmlEnum("lbm/in3")]
          lbmin3,
        /// <summary>
        /// lbmMbbl property
        /// </summary>
          [XmlEnum("lbm/Mbbl")]
          lbmMbbl,
        /// <summary>
        /// mgdm3 property
        /// </summary>
          [XmlEnum("mg/dm3")]
          mgdm3,
        /// <summary>
        /// mggalUS property
        /// </summary>
          [XmlEnum("mg/galUS")]
          mggalUS,
        /// <summary>
        /// mgL property
        /// </summary>
          [XmlEnum("mg/L")]
          mgL,
        /// <summary>
        /// mgm3 property
        /// </summary>
          [XmlEnum("mg/m3")]
          mgm3,
        /// <summary>
        /// ugcm3 property
        /// </summary>
          [XmlEnum("ug/cm3")]
          ugcm3
        }
        /// <summary>
        /// This class represents the CompressibilityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the CompressibilityUom xsd enumeration.")]
        public enum CompressibilityUom 
        {
        /// <summary>
        /// Item1psi property
        /// </summary>
          [XmlEnum("1/psi")]
          Item1psi,
        /// <summary>
        /// Item1upsi property
        /// </summary>
          [XmlEnum("1/upsi")]
          Item1upsi,
        /// <summary>
        /// Item1Pa property
        /// </summary>
          [XmlEnum("1/Pa")]
          Item1Pa,
        /// <summary>
        /// Item1bar property
        /// </summary>
          [XmlEnum("1/bar")]
          Item1bar,
        /// <summary>
        /// Item1kPa property
        /// </summary>
          [XmlEnum("1/kPa")]
          Item1kPa,
        /// <summary>
        /// Item1pPa property
        /// </summary>
          [XmlEnum("1/pPa")]
          Item1pPa
        }
        /// <summary>
        /// This class represents the AreaPerAreaUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the AreaPerAreaUom xsd enumeration.")]
        public enum AreaPerAreaUom 
        {
        /// <summary>
        /// Euc property
        /// </summary>
          Euc,
        /// <summary>
        /// Item property
        /// </summary>
          [XmlEnum("%")]
          Item,
        /// <summary>
        /// in2ft2 property
        /// </summary>
          [XmlEnum("in2/ft2")]
          in2ft2,
        /// <summary>
        /// in2in2 property
        /// </summary>
          [XmlEnum("in2/in2")]
          in2in2,
        /// <summary>
        /// m2m2 property
        /// </summary>
          [XmlEnum("m2/m2")]
          m2m2,
        /// <summary>
        /// mm2mm2 property
        /// </summary>
          [XmlEnum("mm2/mm2")]
          mm2mm2
        }
        /// <summary>
        /// This class represents the AreaUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the AreaUom xsd enumeration.")]
        public enum AreaUom 
        {
        /// <summary>
        /// m2 property
        /// </summary>
          m2,
        /// <summary>
        /// acre property
        /// </summary>
          acre,
        /// <summary>
        /// b property
        /// </summary>
          b,
        /// <summary>
        /// cm2 property
        /// </summary>
          cm2,
        /// <summary>
        /// ft2 property
        /// </summary>
          ft2,
        /// <summary>
        /// ha property
        /// </summary>
          ha,
        /// <summary>
        /// in2 property
        /// </summary>
          in2,
        /// <summary>
        /// km2 property
        /// </summary>
          km2,
        /// <summary>
        /// mi2 property
        /// </summary>
          mi2,
        /// <summary>
        /// miUS2 property
        /// </summary>
          miUS2,
        /// <summary>
        /// mm2 property
        /// </summary>
          mm2,
        /// <summary>
        /// um2 property
        /// </summary>
          um2,
        /// <summary>
        /// yd2 property
        /// </summary>
          yd2
        }
        /// <summary>
        /// This class represents the AnglePerTimeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the AnglePerTimeUom xsd enumeration.")]
        public enum AnglePerTimeUom 
        {
        /// <summary>
        /// rads property
        /// </summary>
          [XmlEnum("rad/s")]
          rads,
        /// <summary>
        /// cs property
        /// </summary>
          [XmlEnum("c/s")]
          cs,
        /// <summary>
        /// degah property
        /// </summary>
          [XmlEnum("dega/h")]
          degah,
        /// <summary>
        /// degamin property
        /// </summary>
          [XmlEnum("dega/min")]
          degamin,
        /// <summary>
        /// degas property
        /// </summary>
          [XmlEnum("dega/s")]
          degas,
        /// <summary>
        /// revs property
        /// </summary>
          [XmlEnum("rev/s")]
          revs,
        /// <summary>
        /// rpm property
        /// </summary>
          rpm
        }
        /// <summary>
        /// This class represents the AnglePerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the AnglePerLengthUom xsd enumeration.")]
        public enum AnglePerLengthUom 
        {
        /// <summary>
        /// radm property
        /// </summary>
          [XmlEnum("rad/m")]
          radm,
        /// <summary>
        /// dega30ft property
        /// </summary>
          [XmlEnum("dega/30ft")]
          dega30ft,
        /// <summary>
        /// degaft property
        /// </summary>
          [XmlEnum("dega/ft")]
          degaft,
        /// <summary>
        /// dega100ft property
        /// </summary>
          [XmlEnum("dega/100ft")]
          dega100ft,
        /// <summary>
        /// degam property
        /// </summary>
          [XmlEnum("dega/m")]
          degam,
        /// <summary>
        /// dega30m property
        /// </summary>
          [XmlEnum("dega/30m")]
          dega30m,
        /// <summary>
        /// radft property
        /// </summary>
          [XmlEnum("rad/ft")]
          radft
        }
        /// <summary>
        /// This class represents the AccelerationLinearUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the AccelerationLinearUom xsd enumeration.")]
        public enum AccelerationLinearUom 
        {
        /// <summary>
        /// ms2 property
        /// </summary>
          [XmlEnum("m/s2")]
          ms2,
        /// <summary>
        /// cms2 property
        /// </summary>
          [XmlEnum("cm/s2")]
          cms2,
        /// <summary>
        /// fts2 property
        /// </summary>
          [XmlEnum("ft/s2")]
          fts2,
        /// <summary>
        /// Gal property
        /// </summary>
          Gal,
        /// <summary>
        /// mgn property
        /// </summary>
          mgn,
        /// <summary>
        /// gn property
        /// </summary>
          gn,
        /// <summary>
        /// mGal property
        /// </summary>
          mGal
        }
        /// <summary>
        /// This class represents the ItemState xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ItemState xsd enumeration.")]
        public enum ItemState 
        {
        /// <summary>
        /// Actual data measured or entered at the well site.
        /// </summary>
          actual,
        /// <summary>
        /// Model data used for "what if" calculations.
        /// </summary>
          model,
        /// <summary>
        /// A planned object. That is, one which is expected to be executed in the future.
        /// </summary>
          plan,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the PrimitiveType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
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
        /// This class represents the LogIndexType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the LogIndexType xsd enumeration.")]
        public enum LogIndexType 
        {
        /// <summary>
        /// datetime property
        /// </summary>
          [XmlEnum("date time")]
          datetime,
        /// <summary>
        /// elapsedtime property
        /// </summary>
          [XmlEnum("elapsed time")]
          elapsedtime,
        /// <summary>
        /// Log is indexed on length (not a depth).
        /// </summary>
          length,
        /// <summary>
        /// measureddepth property
        /// </summary>
          [XmlEnum("measured depth")]
          measureddepth,
        /// <summary>
        /// verticaldepth property
        /// </summary>
          [XmlEnum("vertical depth")]
          verticaldepth,
        /// <summary>
        /// Any other index type for a log.
        /// </summary>
          other,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the PerfConveyanceMethod xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PerfConveyanceMethod xsd enumeration.")]
        public enum PerfConveyanceMethod 
        {
        /// <summary>
        /// NA property
        /// </summary>
          [XmlEnum("N/A")]
          NA,
        /// <summary>
        /// SlickLine property
        /// </summary>
          [XmlEnum("Slick Line")]
          SlickLine,
        /// <summary>
        /// TubingConveyed property
        /// </summary>
          [XmlEnum("Tubing Conveyed")]
          TubingConveyed,
        /// <summary>
        /// Wireline property
        /// </summary>
          Wireline
        }
        /// <summary>
        /// This class represents the EventClassType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the EventClassType xsd enumeration.")]
        public enum EventClassType 
        {
        /// <summary>
        /// Job property
        /// </summary>
          Job,
        /// <summary>
        /// DailyReport property
        /// </summary>
          [XmlEnum("Daily Report")]
          DailyReport,
        /// <summary>
        /// TimeLogTimeMeasure property
        /// </summary>
          [XmlEnum("Time Log (Time Measure)")]
          TimeLogTimeMeasure,
        /// <summary>
        /// DailyCost property
        /// </summary>
          [XmlEnum("Daily Cost")]
          DailyCost,
        /// <summary>
        /// NPTlosttimeevent property
        /// </summary>
          [XmlEnum("NPT (lost time event)")]
          NPTlosttimeevent,
        /// <summary>
        /// Failuredownholeequipmentonly property
        /// </summary>
          [XmlEnum("Failure (downhole equipment only)")]
          Failuredownholeequipmentonly,
        /// <summary>
        /// MudAttributes property
        /// </summary>
          [XmlEnum("Mud Attributes")]
          MudAttributes,
        /// <summary>
        /// JobPlanphases property
        /// </summary>
          [XmlEnum("Job Plan (phases)")]
          JobPlanphases
        }
        /// <summary>
        /// This class represents the PhysicalStatus xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PhysicalStatus xsd enumeration.")]
        public enum PhysicalStatus 
        {
        /// <summary>
        /// The open physical status the interval.
        /// </summary>
          open,
        /// <summary>
        /// The squeezed physical status the interval.
        /// </summary>
          closed,
        /// <summary>
        /// The proposed physical status the interval.
        /// </summary>
          proposed
        }
        /// <summary>
        /// This class represents the PerforationStatus xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PerforationStatus xsd enumeration.")]
        public enum PerforationStatus 
        {
        /// <summary>
        /// open property
        /// </summary>
          open,
        /// <summary>
        /// squeezed property
        /// </summary>
          squeezed,
        /// <summary>
        /// proposed property
        /// </summary>
          proposed
        }
        /// <summary>
        /// This class represents the PerforationToolType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the PerforationToolType xsd enumeration.")]
        public enum PerforationToolType 
        {
        /// <summary>
        /// NA property
        /// </summary>
          [XmlEnum("N/A")]
          NA,
        /// <summary>
        /// CasingGun property
        /// </summary>
          [XmlEnum("Casing Gun")]
          CasingGun,
        /// <summary>
        /// ThroughTubingGun property
        /// </summary>
          [XmlEnum("Through Tubing Gun")]
          ThroughTubingGun,
        /// <summary>
        /// SlotsMachineCut property
        /// </summary>
          [XmlEnum("Slots-Machine Cut")]
          SlotsMachineCut,
        /// <summary>
        /// SlotsUndercut property
        /// </summary>
          [XmlEnum("Slots-Undercut")]
          SlotsUndercut,
        /// <summary>
        /// TCPGun property
        /// </summary>
          [XmlEnum("TCP Gun")]
          TCPGun,
        /// <summary>
        /// StripGun property
        /// </summary>
          [XmlEnum("Strip Gun")]
          StripGun,
        /// <summary>
        /// Drilled property
        /// </summary>
          Drilled,
        /// <summary>
        /// Mandrel property
        /// </summary>
          Mandrel,
        /// <summary>
        /// CoiledTubingJetTool property
        /// </summary>
          [XmlEnum("Coiled Tubing Jet Tool")]
          CoiledTubingJetTool
        }
        /// <summary>
        /// This class represents the EquipmentType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the EquipmentType xsd enumeration.")]
        public enum EquipmentType 
        {
        /// <summary>
        /// BridgePlug property
        /// </summary>
          [XmlEnum("Bridge Plug")]
          BridgePlug,
        /// <summary>
        /// BullPlug property
        /// </summary>
          [XmlEnum("Bull Plug")]
          BullPlug,
        /// <summary>
        /// CapillaryTubing property
        /// </summary>
          [XmlEnum("Capillary Tubing")]
          CapillaryTubing,
        /// <summary>
        /// CasingCrossover property
        /// </summary>
          [XmlEnum("Casing Crossover")]
          CasingCrossover,
        /// <summary>
        /// CasingHanger property
        /// </summary>
          [XmlEnum("Casing Hanger")]
          CasingHanger,
        /// <summary>
        /// CasingHead property
        /// </summary>
          [XmlEnum("Casing Head")]
          CasingHead,
        /// <summary>
        /// CasingLinerExpandable property
        /// </summary>
          [XmlEnum("Casing Liner-Expandable")]
          CasingLinerExpandable,
        /// <summary>
        /// CasingShoe property
        /// </summary>
          [XmlEnum("Casing Shoe")]
          CasingShoe,
        /// <summary>
        /// CasingSpool property
        /// </summary>
          [XmlEnum("Casing Spool")]
          CasingSpool,
        /// <summary>
        /// CasingCasingLiner property
        /// </summary>
          [XmlEnum("Casing/Casing Liner")]
          CasingCasingLiner,
        /// <summary>
        /// CementbehindCasing property
        /// </summary>
          [XmlEnum("Cement (behind Casing)")]
          CementbehindCasing,
        /// <summary>
        /// CementBasket property
        /// </summary>
          [XmlEnum("Cement Basket")]
          CementBasket,
        /// <summary>
        /// CementRetainer property
        /// </summary>
          [XmlEnum("Cement Retainer")]
          CementRetainer,
        /// <summary>
        /// CementSqueeze property
        /// </summary>
          [XmlEnum("Cement Squeeze")]
          CementSqueeze,
        /// <summary>
        /// CementStageTool property
        /// </summary>
          [XmlEnum("Cement Stage Tool")]
          CementStageTool,
        /// <summary>
        /// ChemicalInjectionMandrel property
        /// </summary>
          [XmlEnum("Chemical Injection Mandrel")]
          ChemicalInjectionMandrel,
        /// <summary>
        /// ChemicalInjectionValve property
        /// </summary>
          [XmlEnum("Chemical Injection Valve")]
          ChemicalInjectionValve,
        /// <summary>
        /// CorrosionCouponCarrier property
        /// </summary>
          [XmlEnum("Corrosion Coupon Carrier")]
          CorrosionCouponCarrier,
        /// <summary>
        /// DipTube property
        /// </summary>
          [XmlEnum("Dip Tube")]
          DipTube,
        /// <summary>
        /// DownholeChoke property
        /// </summary>
          [XmlEnum("Downhole Choke")]
          DownholeChoke,
        /// <summary>
        /// DownholeSensor property
        /// </summary>
          [XmlEnum("Downhole Sensor")]
          DownholeSensor,
        /// <summary>
        /// ESPAssembly property
        /// </summary>
          [XmlEnum("ESP Assembly")]
          ESPAssembly,
        /// <summary>
        /// ESPBoltonDischarge property
        /// </summary>
          [XmlEnum("ESP Bolt on Discharge")]
          ESPBoltonDischarge,
        /// <summary>
        /// ESPBoltonIntake property
        /// </summary>
          [XmlEnum("ESP Bolt on Intake")]
          ESPBoltonIntake,
        /// <summary>
        /// ESPBoltonMotorBase property
        /// </summary>
          [XmlEnum("ESP Bolt on Motor Base")]
          ESPBoltonMotorBase,
        /// <summary>
        /// ESPBoltonMotorHead property
        /// </summary>
          [XmlEnum("ESP Bolt on Motor Head")]
          ESPBoltonMotorHead,
        /// <summary>
        /// ESPCable property
        /// </summary>
          [XmlEnum("ESP Cable")]
          ESPCable,
        /// <summary>
        /// ESPGasHandler property
        /// </summary>
          [XmlEnum("ESP Gas Handler")]
          ESPGasHandler,
        /// <summary>
        /// ESPGasSeparator property
        /// </summary>
          [XmlEnum("ESP Gas Separator")]
          ESPGasSeparator,
        /// <summary>
        /// ESPLowerPigtail property
        /// </summary>
          [XmlEnum("ESP Lower Pigtail")]
          ESPLowerPigtail,
        /// <summary>
        /// ESPMotor property
        /// </summary>
          [XmlEnum("ESP Motor")]
          ESPMotor,
        /// <summary>
        /// ESPMotorBaseCentralizer property
        /// </summary>
          [XmlEnum("ESP Motor Base Centralizer")]
          ESPMotorBaseCentralizer,
        /// <summary>
        /// ESPMotorFlatCable property
        /// </summary>
          [XmlEnum("ESP Motor Flat Cable")]
          ESPMotorFlatCable,
        /// <summary>
        /// ESPMotorShroud property
        /// </summary>
          [XmlEnum("ESP Motor Shroud")]
          ESPMotorShroud,
        /// <summary>
        /// ESPPromotor property
        /// </summary>
          [XmlEnum("ESP Promotor")]
          ESPPromotor,
        /// <summary>
        /// ESPPump property
        /// </summary>
          [XmlEnum("ESP Pump")]
          ESPPump,
        /// <summary>
        /// ESPPumpDischargeSensorSub property
        /// </summary>
          [XmlEnum("ESP Pump Discharge Sensor Sub")]
          ESPPumpDischargeSensorSub,
        /// <summary>
        /// ESPSeal property
        /// </summary>
          [XmlEnum("ESP Seal")]
          ESPSeal,
        /// <summary>
        /// ExpansionJoint property
        /// </summary>
          [XmlEnum("Expansion Joint")]
          ExpansionJoint,
        /// <summary>
        /// ExternalCementingPort property
        /// </summary>
          [XmlEnum("External Cementing Port")]
          ExternalCementingPort,
        /// <summary>
        /// Fill property
        /// </summary>
          Fill,
        /// <summary>
        /// Fish property
        /// </summary>
          Fish,
        /// <summary>
        /// FloatCollar property
        /// </summary>
          [XmlEnum("Float Collar")]
          FloatCollar,
        /// <summary>
        /// FloatShoeGuideShoe property
        /// </summary>
          [XmlEnum("Float Shoe/Guide Shoe")]
          FloatShoeGuideShoe,
        /// <summary>
        /// GasAnchor property
        /// </summary>
          [XmlEnum("Gas Anchor")]
          GasAnchor,
        /// <summary>
        /// GasLiftMandrel property
        /// </summary>
          [XmlEnum("Gas Lift Mandrel")]
          GasLiftMandrel,
        /// <summary>
        /// GasLiftValve property
        /// </summary>
          [XmlEnum("Gas Lift Valve")]
          GasLiftValve,
        /// <summary>
        /// GravelPackScreen property
        /// </summary>
          [XmlEnum("Gravel Pack Screen")]
          GravelPackScreen,
        /// <summary>
        /// HydraulicPump property
        /// </summary>
          [XmlEnum("Hydraulic Pump")]
          HydraulicPump,
        /// <summary>
        /// InjectionMandrel property
        /// </summary>
          [XmlEnum("Injection Mandrel")]
          InjectionMandrel,
        /// <summary>
        /// InjectionValve property
        /// </summary>
          [XmlEnum("Injection Valve")]
          InjectionValve,
        /// <summary>
        /// JunkinWellbore property
        /// </summary>
          [XmlEnum("Junk in Wellbore")]
          JunkinWellbore,
        /// <summary>
        /// LandingCollar property
        /// </summary>
          [XmlEnum("Landing Collar")]
          LandingCollar,
        /// <summary>
        /// LinerEntryGuide property
        /// </summary>
          [XmlEnum("Liner Entry Guide")]
          LinerEntryGuide,
        /// <summary>
        /// LinerHanger property
        /// </summary>
          [XmlEnum("Liner Hanger")]
          LinerHanger,
        /// <summary>
        /// MuleShoe property
        /// </summary>
          [XmlEnum("Mule Shoe")]
          MuleShoe,
        /// <summary>
        /// NotchedCollar property
        /// </summary>
          [XmlEnum("Notched Collar")]
          NotchedCollar,
        /// <summary>
        /// OnOffTool property
        /// </summary>
          [XmlEnum("On-Off Tool")]
          OnOffTool,
        /// <summary>
        /// Overshot property
        /// </summary>
          Overshot,
        /// <summary>
        /// Packer property
        /// </summary>
          Packer,
        /// <summary>
        /// PackerMultipleStrings property
        /// </summary>
          [XmlEnum("Packer-Multiple Strings")]
          PackerMultipleStrings,
        /// <summary>
        /// PackerPlug property
        /// </summary>
          [XmlEnum("Packer Plug")]
          PackerPlug,
        /// <summary>
        /// PackoffTubing property
        /// </summary>
          [XmlEnum("Packoff (Tubing)")]
          PackoffTubing,
        /// <summary>
        /// PCPFlexshaftIntake property
        /// </summary>
          [XmlEnum("PCP-Flex shaft Intake")]
          PCPFlexshaftIntake,
        /// <summary>
        /// PCPGearReducerSubsurface property
        /// </summary>
          [XmlEnum("PCP-Gear Reducer (Subsurface)")]
          PCPGearReducerSubsurface,
        /// <summary>
        /// PCPNoTurnToolTorqueAnchor property
        /// </summary>
          [XmlEnum("PCP-No Turn Tool/Torque Anchor")]
          PCPNoTurnToolTorqueAnchor,
        /// <summary>
        /// PCPRotor property
        /// </summary>
          [XmlEnum("PCP-Rotor")]
          PCPRotor,
        /// <summary>
        /// PCPStator property
        /// </summary>
          [XmlEnum("PCP-Stator")]
          PCPStator,
        /// <summary>
        /// PCPTagBar property
        /// </summary>
          [XmlEnum("PCP-Tag Bar")]
          PCPTagBar,
        /// <summary>
        /// PlugCement property
        /// </summary>
          [XmlEnum("Plug - Cement")]
          PlugCement,
        /// <summary>
        /// PlugMud property
        /// </summary>
          [XmlEnum("Plug - Mud")]
          PlugMud,
        /// <summary>
        /// PlungerLiftBall property
        /// </summary>
          [XmlEnum("Plunger Lift Ball")]
          PlungerLiftBall,
        /// <summary>
        /// PlungerLiftBottomHoleBumperAssembly property
        /// </summary>
          [XmlEnum("Plunger Lift Bottom Hole Bumper Assembly")]
          PlungerLiftBottomHoleBumperAssembly,
        /// <summary>
        /// PlungerLiftBumperSpring property
        /// </summary>
          [XmlEnum("Plunger Lift Bumper Spring")]
          PlungerLiftBumperSpring,
        /// <summary>
        /// PlungerLiftCollarStop property
        /// </summary>
          [XmlEnum("Plunger Lift Collar Stop")]
          PlungerLiftCollarStop,
        /// <summary>
        /// PlungerLiftPlunger property
        /// </summary>
          [XmlEnum("Plunger Lift Plunger")]
          PlungerLiftPlunger,
        /// <summary>
        /// PolishedRod property
        /// </summary>
          [XmlEnum("Polished Rod")]
          PolishedRod,
        /// <summary>
        /// PolishedRodLiner property
        /// </summary>
          [XmlEnum("Polished Rod Liner")]
          PolishedRodLiner,
        /// <summary>
        /// PortedCollar property
        /// </summary>
          [XmlEnum("Ported Collar")]
          PortedCollar,
        /// <summary>
        /// ProfileNipple property
        /// </summary>
          [XmlEnum("Profile Nipple")]
          ProfileNipple,
        /// <summary>
        /// ProfileNipplePlug property
        /// </summary>
          [XmlEnum("Profile Nipple Plug")]
          ProfileNipplePlug,
        /// <summary>
        /// PumpOutPlug property
        /// </summary>
          [XmlEnum("Pump-Out Plug")]
          PumpOutPlug,
        /// <summary>
        /// SealAssembly property
        /// </summary>
          [XmlEnum("Seal Assembly")]
          SealAssembly,
        /// <summary>
        /// SuckerRod property
        /// </summary>
          [XmlEnum("Sucker Rod")]
          SuckerRod,
        /// <summary>
        /// SuckerRodBackoffCoupling property
        /// </summary>
          [XmlEnum("Sucker Rod Backoff Coupling")]
          SuckerRodBackoffCoupling,
        /// <summary>
        /// SuckerRodContinuous property
        /// </summary>
          [XmlEnum("Sucker Rod-Continuous")]
          SuckerRodContinuous,
        /// <summary>
        /// SuckerRodPumpInsert property
        /// </summary>
          [XmlEnum("Sucker Rod Pump-Insert")]
          SuckerRodPumpInsert,
        /// <summary>
        /// SuckerRodPumpJacket property
        /// </summary>
          [XmlEnum("Sucker Rod Pump-Jacket")]
          SuckerRodPumpJacket,
        /// <summary>
        /// SuckerRodPumpTubingPumpBarrel property
        /// </summary>
          [XmlEnum("Sucker Rod Pump-Tubing Pump Barrel")]
          SuckerRodPumpTubingPumpBarrel,
        /// <summary>
        /// SuckerRodPumpTubingPumpPlunger property
        /// </summary>
          [XmlEnum("Sucker Rod Pump-Tubing Pump Plunger")]
          SuckerRodPumpTubingPumpPlunger,
        /// <summary>
        /// SuckerRodRibbon property
        /// </summary>
          [XmlEnum("Sucker Rod-Ribbon")]
          SuckerRodRibbon,
        /// <summary>
        /// SuckerRodSinkerBar property
        /// </summary>
          [XmlEnum("Sucker Rod-Sinker Bar")]
          SuckerRodSinkerBar,
        /// <summary>
        /// SuckerRodSub property
        /// </summary>
          [XmlEnum("Sucker Rod Sub")]
          SuckerRodSub,
        /// <summary>
        /// SandScreenTubing property
        /// </summary>
          [XmlEnum("Sand Screen-Tubing")]
          SandScreenTubing,
        /// <summary>
        /// SandSeparator property
        /// </summary>
          [XmlEnum("Sand Separator")]
          SandSeparator,
        /// <summary>
        /// ScreenLinerInsert property
        /// </summary>
          [XmlEnum("Screen Liner/Insert")]
          ScreenLinerInsert,
        /// <summary>
        /// SealBoreExtension property
        /// </summary>
          [XmlEnum("Seal Bore Extension")]
          SealBoreExtension,
        /// <summary>
        /// SeatNippleShoe property
        /// </summary>
          [XmlEnum("Seat Nipple/Shoe")]
          SeatNippleShoe,
        /// <summary>
        /// ShearTool property
        /// </summary>
          [XmlEnum("Shear Tool")]
          ShearTool,
        /// <summary>
        /// SlidingSleeve property
        /// </summary>
          [XmlEnum("Sliding Sleeve")]
          SlidingSleeve,
        /// <summary>
        /// SteamCupMandrel property
        /// </summary>
          [XmlEnum("Steam Cup Mandrel")]
          SteamCupMandrel,
        /// <summary>
        /// SteamDeflectors property
        /// </summary>
          [XmlEnum("Steam Deflectors")]
          SteamDeflectors,
        /// <summary>
        /// StrainerNipple property
        /// </summary>
          [XmlEnum("Strainer Nipple")]
          StrainerNipple,
        /// <summary>
        /// SubsurfaceSafetyValve property
        /// </summary>
          [XmlEnum("Subsurface Safety Valve")]
          SubsurfaceSafetyValve,
        /// <summary>
        /// TCPGun property
        /// </summary>
          [XmlEnum("TCP Gun")]
          TCPGun,
        /// <summary>
        /// Tubing property
        /// </summary>
          Tubing,
        /// <summary>
        /// TubingCoiled property
        /// </summary>
          [XmlEnum("Tubing (Coiled)")]
          TubingCoiled,
        /// <summary>
        /// TubingAnchorCatcher property
        /// </summary>
          [XmlEnum("Tubing Anchor/Catcher")]
          TubingAnchorCatcher,
        /// <summary>
        /// TubingCrossover property
        /// </summary>
          [XmlEnum("Tubing Crossover")]
          TubingCrossover,
        /// <summary>
        /// TubingDrain property
        /// </summary>
          [XmlEnum("Tubing Drain")]
          TubingDrain,
        /// <summary>
        /// TubingHanger property
        /// </summary>
          [XmlEnum("Tubing Hanger")]
          TubingHanger,
        /// <summary>
        /// TubingHeadSpool property
        /// </summary>
          [XmlEnum("Tubing Head (Spool)")]
          TubingHeadSpool,
        /// <summary>
        /// TubingPurgeCheckValve property
        /// </summary>
          [XmlEnum("Tubing Purge Check Valve")]
          TubingPurgeCheckValve,
        /// <summary>
        /// TubingSub property
        /// </summary>
          [XmlEnum("Tubing Sub")]
          TubingSub,
        /// <summary>
        /// Whipstock property
        /// </summary>
          Whipstock,
        /// <summary>
        /// WirelineReEntryGuideBellCollar property
        /// </summary>
          [XmlEnum("Wireline Re-Entry Guide (Bell Collar)")]
          WirelineReEntryGuideBellCollar,
        /// <summary>
        /// WellboreNotes property
        /// </summary>
          [XmlEnum("Wellbore Notes")]
          WellboreNotes,
        /// <summary>
        /// YTool property
        /// </summary>
          [XmlEnum("Y-Tool")]
          YTool
        }
        /// <summary>
        /// This class represents the GradeType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the GradeType xsd enumeration.")]
        public enum GradeType 
        {
        /// <summary>
        /// DE property
        /// </summary>
          DE,
        /// <summary>
        /// DER property
        /// </summary>
          DER,
        /// <summary>
        /// DR property
        /// </summary>
          DR,
        /// <summary>
        /// FG property
        /// </summary>
          FG,
        /// <summary>
        /// SE property
        /// </summary>
          SE,
        /// <summary>
        /// SER property
        /// </summary>
          SER,
        /// <summary>
        /// T66 property
        /// </summary>
          [XmlEnum("T-66")]
          T66,
        /// <summary>
        /// HS property
        /// </summary>
          HS,
        /// <summary>
        /// KD property
        /// </summary>
          KD,
        /// <summary>
        /// N97 property
        /// </summary>
          [XmlEnum("N-97")]
          N97,
        /// <summary>
        /// C property
        /// </summary>
          C,
        /// <summary>
        /// K property
        /// </summary>
          K,
        /// <summary>
        /// D property
        /// </summary>
          D,
        /// <summary>
        /// E property
        /// </summary>
          E,
        /// <summary>
        /// E75 property
        /// </summary>
          [XmlEnum("E-75")]
          E75,
        /// <summary>
        /// G105 property
        /// </summary>
          [XmlEnum("G-105")]
          G105,
        /// <summary>
        /// S135 property
        /// </summary>
          [XmlEnum("S-135")]
          S135,
        /// <summary>
        /// V150 property
        /// </summary>
          [XmlEnum("V-150")]
          V150,
        /// <summary>
        /// X95 property
        /// </summary>
          [XmlEnum("X-95")]
          X95,
        /// <summary>
        /// Armco95 property
        /// </summary>
          [XmlEnum("Armco-95")]
          Armco95,
        /// <summary>
        /// C110 property
        /// </summary>
          [XmlEnum("C-110")]
          C110,
        /// <summary>
        /// C75 property
        /// </summary>
          [XmlEnum("C-75")]
          C75,
        /// <summary>
        /// C90 property
        /// </summary>
          [XmlEnum("C-90")]
          C90,
        /// <summary>
        /// C95 property
        /// </summary>
          [XmlEnum("C-95")]
          C95,
        /// <summary>
        /// F25 property
        /// </summary>
          [XmlEnum("F-25")]
          F25,
        /// <summary>
        /// H40 property
        /// </summary>
          [XmlEnum("H-40")]
          H40,
        /// <summary>
        /// HC95 property
        /// </summary>
          [XmlEnum("HC-95")]
          HC95,
        /// <summary>
        /// J20 property
        /// </summary>
          [XmlEnum("J-20")]
          J20,
        /// <summary>
        /// J55 property
        /// </summary>
          [XmlEnum("J-55")]
          J55,
        /// <summary>
        /// K40 property
        /// </summary>
          [XmlEnum("K-40")]
          K40,
        /// <summary>
        /// K55 property
        /// </summary>
          [XmlEnum("K-55")]
          K55,
        /// <summary>
        /// L80 property
        /// </summary>
          [XmlEnum("L-80")]
          L80,
        /// <summary>
        /// LS50 property
        /// </summary>
          [XmlEnum("LS-50")]
          LS50,
        /// <summary>
        /// LS65 property
        /// </summary>
          [XmlEnum("LS-65")]
          LS65,
        /// <summary>
        /// M65 property
        /// </summary>
          [XmlEnum("M-65")]
          M65,
        /// <summary>
        /// M90 property
        /// </summary>
          [XmlEnum("M-90")]
          M90,
        /// <summary>
        /// M95 property
        /// </summary>
          [XmlEnum("M-95")]
          M95,
        /// <summary>
        /// MAV50 property
        /// </summary>
          [XmlEnum("MAV-50")]
          MAV50,
        /// <summary>
        /// N105 property
        /// </summary>
          [XmlEnum("N-105")]
          N105,
        /// <summary>
        /// N23 property
        /// </summary>
          [XmlEnum("N-23")]
          N23,
        /// <summary>
        /// N80 property
        /// </summary>
          [XmlEnum("N-80")]
          N80,
        /// <summary>
        /// P105 property
        /// </summary>
          [XmlEnum("P-105")]
          P105,
        /// <summary>
        /// P110 property
        /// </summary>
          [XmlEnum("P-110")]
          P110,
        /// <summary>
        /// Q125 property
        /// </summary>
          [XmlEnum("Q-125")]
          Q125,
        /// <summary>
        /// S80 property
        /// </summary>
          [XmlEnum("S-80")]
          S80,
        /// <summary>
        /// S95 property
        /// </summary>
          [XmlEnum("S-95")]
          S95,
        /// <summary>
        /// T95 property
        /// </summary>
          [XmlEnum("T-95")]
          T95,
        /// <summary>
        /// X140 property
        /// </summary>
          [XmlEnum("X-140")]
          X140,
        /// <summary>
        /// Unknown property
        /// </summary>
          Unknown,
        /// <summary>
        /// EL property
        /// </summary>
          EL,
        /// <summary>
        /// MD56 property
        /// </summary>
          [XmlEnum("MD-56")]
          MD56,
        /// <summary>
        /// S60 property
        /// </summary>
          [XmlEnum("S-60")]
          S60,
        /// <summary>
        /// S67 property
        /// </summary>
          [XmlEnum("S-67")]
          S67,
        /// <summary>
        /// S87 property
        /// </summary>
          [XmlEnum("S-87")]
          S87,
        /// <summary>
        /// S88 property
        /// </summary>
          [XmlEnum("S-88")]
          S88,
        /// <summary>
        /// XD property
        /// </summary>
          XD,
        /// <summary>
        /// S59 property
        /// </summary>
          [XmlEnum("S-59")]
          S59,
        /// <summary>
        /// KD63 property
        /// </summary>
          [XmlEnum("KD-63")]
          KD63,
        /// <summary>
        /// N30 property
        /// </summary>
          [XmlEnum("N-30")]
          N30,
        /// <summary>
        /// N40 property
        /// </summary>
          [XmlEnum("N-40")]
          N40,
        /// <summary>
        /// N54 property
        /// </summary>
          [XmlEnum("N-54")]
          N54,
        /// <summary>
        /// N78 property
        /// </summary>
          [XmlEnum("N-78")]
          N78,
        /// <summary>
        /// N75 property
        /// </summary>
          [XmlEnum("N-75")]
          N75,
        /// <summary>
        /// N90 property
        /// </summary>
          [XmlEnum("N-90")]
          N90,
        /// <summary>
        /// N96 property
        /// </summary>
          [XmlEnum("N-96")]
          N96,
        /// <summary>
        /// Item35 property
        /// </summary>
          [XmlEnum("35")]
          Item35,
        /// <summary>
        /// Item50 property
        /// </summary>
          [XmlEnum("50")]
          Item50,
        /// <summary>
        /// Item45 property
        /// </summary>
          [XmlEnum("45")]
          Item45,
        /// <summary>
        /// TK65 property
        /// </summary>
          [XmlEnum("T-K65")]
          TK65,
        /// <summary>
        /// Item46 property
        /// </summary>
          [XmlEnum("46")]
          Item46,
        /// <summary>
        /// TD61 property
        /// </summary>
          [XmlEnum("T-D61")]
          TD61,
        /// <summary>
        /// TD63 property
        /// </summary>
          [XmlEnum("T-D63")]
          TD63,
        /// <summary>
        /// Item75 property
        /// </summary>
          [XmlEnum("75")]
          Item75,
        /// <summary>
        /// Item75A property
        /// </summary>
          [XmlEnum("75A")]
          Item75A,
        /// <summary>
        /// Item95 property
        /// </summary>
          [XmlEnum("95")]
          Item95,
        /// <summary>
        /// PH6 property
        /// </summary>
          [XmlEnum("PH-6")]
          PH6,
        /// <summary>
        /// WC50 property
        /// </summary>
          [XmlEnum("WC-50")]
          WC50,
        /// <summary>
        /// SOO95 property
        /// </summary>
          [XmlEnum("SOO-95")]
          SOO95,
        /// <summary>
        /// A53B property
        /// </summary>
          A53B,
        /// <summary>
        /// FS80 property
        /// </summary>
          [XmlEnum("FS-80")]
          FS80,
        /// <summary>
        /// FSS95 property
        /// </summary>
          [XmlEnum("FSS-95")]
          FSS95,
        /// <summary>
        /// SC90 property
        /// </summary>
          [XmlEnum("SC-90")]
          SC90,
        /// <summary>
        /// USS95 property
        /// </summary>
          [XmlEnum("USS-95")]
          USS95,
        /// <summary>
        /// USS125 property
        /// </summary>
          [XmlEnum("USS-125")]
          USS125,
        /// <summary>
        /// USS140 property
        /// </summary>
          [XmlEnum("USS-140")]
          USS140,
        /// <summary>
        /// GT80S property
        /// </summary>
          [XmlEnum("GT-80S")]
          GT80S,
        /// <summary>
        /// USS50 property
        /// </summary>
          [XmlEnum("USS-50")]
          USS50,
        /// <summary>
        /// LS140 property
        /// </summary>
          [XmlEnum("LS-140")]
          LS140,
        /// <summary>
        /// HCL80 property
        /// </summary>
          [XmlEnum("HCL-80")]
          HCL80,
        /// <summary>
        /// HCN80 property
        /// </summary>
          [XmlEnum("HCN-80")]
          HCN80,
        /// <summary>
        /// HCP110 property
        /// </summary>
          [XmlEnum("HCP-110")]
          HCP110,
        /// <summary>
        /// HCQ125 property
        /// </summary>
          [XmlEnum("HCQ-125")]
          HCQ125,
        /// <summary>
        /// H2S90 property
        /// </summary>
          [XmlEnum("H2S-90")]
          H2S90,
        /// <summary>
        /// QT700 property
        /// </summary>
          [XmlEnum("QT-700")]
          QT700,
        /// <summary>
        /// QT800 property
        /// </summary>
          [XmlEnum("QT-800")]
          QT800,
        /// <summary>
        /// QT900 property
        /// </summary>
          [XmlEnum("QT-900")]
          QT900,
        /// <summary>
        /// QT1000 property
        /// </summary>
          [XmlEnum("QT-1000")]
          QT1000,
        /// <summary>
        /// QT1200 property
        /// </summary>
          [XmlEnum("QT-1200")]
          QT1200,
        /// <summary>
        /// HO70 property
        /// </summary>
          [XmlEnum("HO-70")]
          HO70,
        /// <summary>
        /// A53 property
        /// </summary>
          A53,
        /// <summary>
        /// A53A property
        /// </summary>
          A53A,
        /// <summary>
        /// H2S95 property
        /// </summary>
          [XmlEnum("H2S-95")]
          H2S95,
        /// <summary>
        /// HCK55 property
        /// </summary>
          [XmlEnum("HCK-55")]
          HCK55,
        /// <summary>
        /// B property
        /// </summary>
          B,
        /// <summary>
        /// X42 property
        /// </summary>
          [XmlEnum("X-42")]
          X42,
        /// <summary>
        /// X52 property
        /// </summary>
          [XmlEnum("X-52")]
          X52,
        /// <summary>
        /// X56 property
        /// </summary>
          [XmlEnum("X-56")]
          X56,
        /// <summary>
        /// Item13CR property
        /// </summary>
          [XmlEnum("13CR")]
          Item13CR,
        /// <summary>
        /// Item13CR80 property
        /// </summary>
          [XmlEnum("13CR- 80")]
          Item13CR80,
        /// <summary>
        /// Item13CR85 property
        /// </summary>
          [XmlEnum("13CR- 85")]
          Item13CR85,
        /// <summary>
        /// Item13CR95 property
        /// </summary>
          [XmlEnum("13CR- 95")]
          Item13CR95,
        /// <summary>
        /// Item13CR110 property
        /// </summary>
          [XmlEnum("13CR-110")]
          Item13CR110,
        /// <summary>
        /// X46 property
        /// </summary>
          [XmlEnum("X-46")]
          X46,
        /// <summary>
        /// X60 property
        /// </summary>
          [XmlEnum("X-60")]
          X60,
        /// <summary>
        /// X70 property
        /// </summary>
          [XmlEnum("X-70")]
          X70,
        /// <summary>
        /// X property
        /// </summary>
          X,
        /// <summary>
        /// G property
        /// </summary>
          G,
        /// <summary>
        /// S property
        /// </summary>
          S,
        /// <summary>
        /// Stainless property
        /// </summary>
          Stainless,
        /// <summary>
        /// SWR property
        /// </summary>
          SWR,
        /// <summary>
        /// DWR property
        /// </summary>
          DWR,
        /// <summary>
        /// T property
        /// </summary>
          T,
        /// <summary>
        /// SM property
        /// </summary>
          SM,
        /// <summary>
        /// UHS property
        /// </summary>
          UHS,
        /// <summary>
        /// MMS property
        /// </summary>
          MMS,
        /// <summary>
        /// PCP900 property
        /// </summary>
          [XmlEnum("PCP  900")]
          PCP900,
        /// <summary>
        /// PCP1000 property
        /// </summary>
          [XmlEnum("PCP 1000")]
          PCP1000,
        /// <summary>
        /// PCP1500 property
        /// </summary>
          [XmlEnum("PCP 1500")]
          PCP1500,
        /// <summary>
        /// PCP2500 property
        /// </summary>
          [XmlEnum("PCP 2500")]
          PCP2500,
        /// <summary>
        /// Plus property
        /// </summary>
          Plus,
        /// <summary>
        /// Item620C property
        /// </summary>
          [XmlEnum("620C")]
          Item620C,
        /// <summary>
        /// Item780M property
        /// </summary>
          [XmlEnum("780M")]
          Item780M,
        /// <summary>
        /// Item750N property
        /// </summary>
          [XmlEnum("750N")]
          Item750N,
        /// <summary>
        /// Item960M property
        /// </summary>
          [XmlEnum("960M")]
          Item960M,
        /// <summary>
        /// Item970N property
        /// </summary>
          [XmlEnum("970N")]
          Item970N
        }
        /// <summary>
        /// This class represents the Coating xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the Coating xsd enumeration.")]
        public enum Coating 
        {
        /// <summary>
        /// NA property
        /// </summary>
          [XmlEnum("N/A")]
          NA,
        /// <summary>
        /// SPRAYMETALMONEL property
        /// </summary>
          [XmlEnum("SPRAY-METAL-MONEL")]
          SPRAYMETALMONEL,
        /// <summary>
        /// "TUFFR"
        /// </summary>
          TUFFR,
        /// <summary>
        /// CORROSIONCOATING property
        /// </summary>
          [XmlEnum("CORROSION COATING")]
          CORROSIONCOATING,
        /// <summary>
        /// CARBURIZEDHARDENED property
        /// </summary>
          [XmlEnum("CARBURIZED-HARDENED")]
          CARBURIZEDHARDENED,
        /// <summary>
        /// "Carburized"
        /// </summary>
          CARBURIZED,
        /// <summary>
        /// "Carbonnitrided"
        /// </summary>
          CARBONNITRIDED,
        /// <summary>
        /// CHROMEPLATEDGROOVED property
        /// </summary>
          [XmlEnum("CHROMEPLATED-GROOVED")]
          CHROMEPLATEDGROOVED,
        /// <summary>
        /// CHROMEPLATEDHEAVY property
        /// </summary>
          [XmlEnum("CHROMEPLATED-HEAVY")]
          CHROMEPLATEDHEAVY,
        /// <summary>
        /// HARDLINED property
        /// </summary>
          [XmlEnum("HARD-LINED")]
          HARDLINED,
        /// <summary>
        /// "Hardened"
        /// </summary>
          HARDENED,
        /// <summary>
        /// "Insert Guided Cage (OBSOLETE)"
        /// </summary>
          INS,
        /// <summary>
        /// "Lubri-Pump Plunger (OBSOLETE)"
        /// </summary>
          LP,
        /// <summary>
        /// IPCS505 property
        /// </summary>
          [XmlEnum("IPC-S505")]
          IPCS505,
        /// <summary>
        /// IPCS650 property
        /// </summary>
          [XmlEnum("IPC-S650")]
          IPCS650,
        /// <summary>
        /// IPCTK70 property
        /// </summary>
          [XmlEnum("IPC-TK70")]
          IPCTK70,
        /// <summary>
        /// CHROMEPLATED property
        /// </summary>
          [XmlEnum("CHROME-PLATED")]
          CHROMEPLATED,
        /// <summary>
        /// NICKELCARBIDE property
        /// </summary>
          [XmlEnum("NICKEL-CARBIDE")]
          NICKELCARBIDE,
        /// <summary>
        /// SPRAYMETAL property
        /// </summary>
          [XmlEnum("SPRAY-METAL")]
          SPRAYMETAL,
        /// <summary>
        /// PLUNGERLUBRICANT property
        /// </summary>
          [XmlEnum("PLUNGER-LUBRICANT")]
          PLUNGERLUBRICANT,
        /// <summary>
        /// "Moly-Coated"
        /// </summary>
          MOLY,
        /// <summary>
        /// "Martin Ring Plunger (OBSOLETE)"
        /// </summary>
          MTR,
        /// <summary>
        /// "Nitrided"
        /// </summary>
          NITRIDED,
        /// <summary>
        /// NICKELPLATED property
        /// </summary>
          [XmlEnum("NICKEL-PLATED")]
          NICKELPLATED,
        /// <summary>
        /// "Pressure Actuated Plunger (OBSOLETE"
        /// </summary>
          PAP,
        /// <summary>
        /// "Phosphorus Coating"
        /// </summary>
          PHOSPHORUS,
        /// <summary>
        /// "Plastic Coated"
        /// </summary>
          PLASTIC,
        /// <summary>
        /// TEFLONRED property
        /// </summary>
          [XmlEnum("TEFLON-RED")]
          TEFLONRED,
        /// <summary>
        /// SPRAYMETALODNICKELPLATEDID property
        /// </summary>
          [XmlEnum("SPRAYMETAL-OD/NICKELPLATED-ID")]
          SPRAYMETALODNICKELPLATEDID,
        /// <summary>
        /// SPRAYMETALTHICK property
        /// </summary>
          [XmlEnum("SPRAYMETAL-THICK")]
          SPRAYMETALTHICK,
        /// <summary>
        /// TEFLONTAN property
        /// </summary>
          [XmlEnum("TEFLON-TAN")]
          TEFLONTAN,
        /// <summary>
        /// TEFLONYELLOW property
        /// </summary>
          [XmlEnum("TEFLON-YELLOW")]
          TEFLONYELLOW,
        /// <summary>
        /// "Double Galvanized"
        /// </summary>
          DBLGALV,
        /// <summary>
        /// IPCNYLON property
        /// </summary>
          [XmlEnum("IPC-NYLON")]
          IPCNYLON,
        /// <summary>
        /// IPCEPXTHK property
        /// </summary>
          [XmlEnum("IPC-EPXTHK")]
          IPCEPXTHK,
        /// <summary>
        /// IPCEPXTHN property
        /// </summary>
          [XmlEnum("IPC-EPXTHN")]
          IPCEPXTHN,
        /// <summary>
        /// FIBERGLASSLINED property
        /// </summary>
          [XmlEnum("FIBERGLASS-LINED")]
          FIBERGLASSLINED,
        /// <summary>
        /// "Cement Lined"
        /// </summary>
          CEMENTLINED,
        /// <summary>
        /// "PVC Lined"
        /// </summary>
          PVCLINED,
        /// <summary>
        /// "Polyethylene Lined"
        /// </summary>
          PELINED,
        /// <summary>
        /// "Stainless Steel Lined"
        /// </summary>
          SSLINED,
        /// <summary>
        /// IPCEPOXY property
        /// </summary>
          [XmlEnum("IPC-EPOXY")]
          IPCEPOXY,
        /// <summary>
        /// "Bare"
        /// </summary>
          BARE,
        /// <summary>
        /// "Duoline"
        /// </summary>
          DUOLINE,
        /// <summary>
        /// RODGUIDE1 property
        /// </summary>
          [XmlEnum("RODGUIDE-1")]
          RODGUIDE1,
        /// <summary>
        /// RODGUIDE2 property
        /// </summary>
          [XmlEnum("RODGUIDE-2")]
          RODGUIDE2,
        /// <summary>
        /// RODGUIDE21 property
        /// </summary>
          [XmlEnum("RODGUIDE-2.")]
          RODGUIDE21,
        /// <summary>
        /// RODGUIDE3 property
        /// </summary>
          [XmlEnum("RODGUIDE-3")]
          RODGUIDE3,
        /// <summary>
        /// RODGUIDE4 property
        /// </summary>
          [XmlEnum("RODGUIDE-4")]
          RODGUIDE4,
        /// <summary>
        /// RODGUIDE5 property
        /// </summary>
          [XmlEnum("RODGUIDE-5")]
          RODGUIDE5,
        /// <summary>
        /// RODGUIDE6 property
        /// </summary>
          [XmlEnum("RODGUIDE-6")]
          RODGUIDE6,
        /// <summary>
        /// RODGUIDE7 property
        /// </summary>
          [XmlEnum("RODGUIDE-7")]
          RODGUIDE7,
        /// <summary>
        /// RODGUIDESO property
        /// </summary>
          [XmlEnum("RODGUIDE-SO")]
          RODGUIDESO,
        /// <summary>
        /// RODGUIDESp property
        /// </summary>
          [XmlEnum("RODGUIDE-Sp")]
          RODGUIDESp,
        /// <summary>
        /// RODGUIDEFx property
        /// </summary>
          [XmlEnum("RODGUIDE-Fx")]
          RODGUIDEFx,
        /// <summary>
        /// RODGUIDESO1 property
        /// </summary>
          [XmlEnum("RODGUIDE-SO1")]
          RODGUIDESO1,
        /// <summary>
        /// RODGUIDESO2 property
        /// </summary>
          [XmlEnum("RODGUIDE-SO2")]
          RODGUIDESO2,
        /// <summary>
        /// RODGUIDESO3 property
        /// </summary>
          [XmlEnum("RODGUIDE-SO3")]
          RODGUIDESO3,
        /// <summary>
        /// RODGUIDESO4 property
        /// </summary>
          [XmlEnum("RODGUIDE-SO4")]
          RODGUIDESO4,
        /// <summary>
        /// RODGUIDESO5 property
        /// </summary>
          [XmlEnum("RODGUIDE-SO5")]
          RODGUIDESO5,
        /// <summary>
        /// RODGUIDESO6 property
        /// </summary>
          [XmlEnum("RODGUIDE-SO6")]
          RODGUIDESO6,
        /// <summary>
        /// RODGUIDESO8 property
        /// </summary>
          [XmlEnum("RODGUIDE-SO8")]
          RODGUIDESO8,
        /// <summary>
        /// "Polypropylene"
        /// </summary>
          POLYPROPYLENE,
        /// <summary>
        /// "EPDM (ESP Cable Insulation)"
        /// </summary>
          EPDM,
        /// <summary>
        /// "Nitrile"
        /// </summary>
          NITRILE,
        /// <summary>
        /// "Teflon"
        /// </summary>
          TEFLON,
        /// <summary>
        /// PPWNitrl property
        /// </summary>
          [XmlEnum("PPW/Nitrl")]
          PPWNitrl,
        /// <summary>
        /// TK99 property
        /// </summary>
          [XmlEnum("TK-99")]
          TK99,
        /// <summary>
        /// IPCRWrap property
        /// </summary>
          [XmlEnum("IPC-RWrap")]
          IPCRWrap,
        /// <summary>
        /// "Internal Plastic Ctg"
        /// </summary>
          IPC,
        /// <summary>
        /// "Thermo-Cased"
        /// </summary>
          THERMO,
        /// <summary>
        /// TK4 property
        /// </summary>
          [XmlEnum("TK-4")]
          TK4,
        /// <summary>
        /// POLISHEDRODLINER property
        /// </summary>
          [XmlEnum("POLISHED-RODLINER")]
          POLISHEDRODLINER,
        /// <summary>
        /// "Zinc Plated (ASTM B633)"
        /// </summary>
          ZINCPLATED,
        /// <summary>
        /// "Phosphate Coating"
        /// </summary>
          PHOSPHATE,
        /// <summary>
        /// "Galvanized (Hot Dipped) (ASTM A153)"
        /// </summary>
          GALVANIZED,
        /// <summary>
        /// "Duoline 10"
        /// </summary>
          DUOLINE10,
        /// <summary>
        /// "Duoline 20"
        /// </summary>
          DUOLINE20,
        /// <summary>
        /// IPCTK75 property
        /// </summary>
          [XmlEnum("IPC-TK75")]
          IPCTK75,
        /// <summary>
        /// SPRAYMETALMONEL1 property
        /// </summary>
          [XmlEnum("SPRAYMETAL-MONEL")]
          SPRAYMETALMONEL1,
        /// <summary>
        /// SPRAYMETALNICKEL property
        /// </summary>
          [XmlEnum("SPRAYMETAL-NICKEL")]
          SPRAYMETALNICKEL,
        /// <summary>
        /// SPRAYMETALSTEEL property
        /// </summary>
          [XmlEnum("SPRAYMETAL-STEEL")]
          SPRAYMETALSTEEL,
        /// <summary>
        /// "Duoline 20 with Rice Wrap"
        /// </summary>
          DUOLIN20WR,
        /// <summary>
        /// "Chrome"
        /// </summary>
          CHROME,
        /// <summary>
        /// TUNGSTENPLATED property
        /// </summary>
          [XmlEnum("TUNGSTEN PLATED")]
          TUNGSTENPLATED
        }
        /// <summary>
        /// This class represents the GeologyType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the GeologyType xsd enumeration.")]
        public enum GeologyType 
        {
        /// <summary>
        /// Aquifer property
        /// </summary>
          Aquifer,
        /// <summary>
        /// Reservoir property
        /// </summary>
          Reservoir
        }
        /// <summary>
        /// This class represents the BoreholeType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the BoreholeType xsd enumeration.")]
        public enum BoreholeType 
        {
        /// <summary>
        /// Cavern property
        /// </summary>
          Cavern,
        /// <summary>
        /// Cavity property
        /// </summary>
          Cavity,
        /// <summary>
        /// NormalBorehole property
        /// </summary>
          NormalBorehole,
        /// <summary>
        /// UnderReam property
        /// </summary>
          UnderReam
        }
        /// <summary>
        /// This class represents the CasingConnectionType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the CasingConnectionType xsd enumeration.")]
        public enum CasingConnectionType 
        {
        /// <summary>
        /// Landed property
        /// </summary>
          Landed,
        /// <summary>
        /// SelfSealingThreaded property
        /// </summary>
          [XmlEnum("SelfSealing-Threaded")]
          SelfSealingThreaded,
        /// <summary>
        /// Welded property
        /// </summary>
          Welded
        }
        /// <summary>
        /// This class represents the OtherConnectionType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the OtherConnectionType xsd enumeration.")]
        public enum OtherConnectionType 
        {
        /// <summary>
        /// DogsCompressionFitSealed property
        /// </summary>
          [XmlEnum("DogsCompressionFit-Sealed")]
          DogsCompressionFitSealed,
        /// <summary>
        /// Cementedinplace property
        /// </summary>
          [XmlEnum("Cemented-in-place")]
          Cementedinplace
        }
        /// <summary>
        /// This class represents the RodConnectionType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the RodConnectionType xsd enumeration.")]
        public enum RodConnectionType 
        {
        /// <summary>
        /// Latched property
        /// </summary>
          Latched,
        /// <summary>
        /// SeatingNippleCup property
        /// </summary>
          [XmlEnum("Seating Nipple-Cup")]
          SeatingNippleCup,
        /// <summary>
        /// SeatingNippleMechanical property
        /// </summary>
          [XmlEnum("SeatingNipple-Mechanical")]
          SeatingNippleMechanical,
        /// <summary>
        /// SlipFitSealed property
        /// </summary>
          [XmlEnum("SlipFit-Sealed")]
          SlipFitSealed,
        /// <summary>
        /// Threaded property
        /// </summary>
          Threaded,
        /// <summary>
        /// Welded property
        /// </summary>
          Welded
        }
        /// <summary>
        /// This class represents the TubingConnectionType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the TubingConnectionType xsd enumeration.")]
        public enum TubingConnectionType 
        {
        /// <summary>
        /// DogsCompressionFitNotSealed property
        /// </summary>
          [XmlEnum("DogsCompressionFit-NotSealed")]
          DogsCompressionFitNotSealed,
        /// <summary>
        /// Latched property
        /// </summary>
          Latched,
        /// <summary>
        /// Landed property
        /// </summary>
          Landed,
        /// <summary>
        /// SelfSealingThreaded property
        /// </summary>
          [XmlEnum("SelfSealing-Threaded")]
          SelfSealingThreaded,
        /// <summary>
        /// SlipFitSealed property
        /// </summary>
          [XmlEnum("SlipFit-Sealed")]
          SlipFitSealed,
        /// <summary>
        /// Threaded property
        /// </summary>
          Threaded,
        /// <summary>
        /// Radial property
        /// </summary>
          Radial,
        /// <summary>
        /// Unknown property
        /// </summary>
          Unknown
        }
        /// <summary>
        /// This class represents the ConnectionFormType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ConnectionFormType xsd enumeration.")]
        public enum ConnectionFormType 
        {
        /// <summary>
        /// Flange property
        /// </summary>
          Flange,
        /// <summary>
        /// Mandrel property
        /// </summary>
          Mandrel,
        /// <summary>
        /// Welded property
        /// </summary>
          Welded,
        /// <summary>
        /// Pin property
        /// </summary>
          Pin,
        /// <summary>
        /// Box property
        /// </summary>
          Box
        }
        /// <summary>
        /// This class represents the ConnectionPosition xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the ConnectionPosition xsd enumeration.")]
        public enum ConnectionPosition 
        {
        /// <summary>
        /// The connection is the same at both ends of the component
        /// </summary>
          both,
        /// <summary>
        /// This connection is only at the bottom of the component
        /// </summary>
          bottom,
        /// <summary>
        /// This connection is only at the top of the component
        /// </summary>
          top,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the DownholeStringType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the DownholeStringType xsd enumeration.")]
        public enum DownholeStringType 
        {
        /// <summary>
        /// Casing property
        /// </summary>
          Casing,
        /// <summary>
        /// Rod property
        /// </summary>
          Rod,
        /// <summary>
        /// Tubing property
        /// </summary>
          Tubing,
        /// <summary>
        /// Wellhead property
        /// </summary>
          Wellhead,
        /// <summary>
        /// Others property
        /// </summary>
          Others
        }
        /// <summary>
        /// This class represents the SubStringType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.witsml.org/schemas/1series")]
        [Description("This class represents the SubStringType xsd enumeration.")]
        public enum SubStringType 
        {
        /// <summary>
        /// AbandonedJunkFish property
        /// </summary>
          [XmlEnum("Abandoned Junk/Fish")]
          AbandonedJunkFish,
        /// <summary>
        /// CapillaryStringinsideTubing property
        /// </summary>
          [XmlEnum("Capillary String (inside Tubing)")]
          CapillaryStringinsideTubing,
        /// <summary>
        /// CapillaryStringTubingCasingAnnulus property
        /// </summary>
          [XmlEnum(" Capillary String (Tubing/Casing Annulus)")]
          CapillaryStringTubingCasingAnnulus,
        /// <summary>
        /// SurfaceCasing property
        /// </summary>
          [XmlEnum("Surface Casing")]
          SurfaceCasing,
        /// <summary>
        /// ConductorCasing property
        /// </summary>
          [XmlEnum("Conductor Casing")]
          ConductorCasing,
        /// <summary>
        /// IntermediateCasing property
        /// </summary>
          [XmlEnum("Intermediate Casing")]
          IntermediateCasing,
        /// <summary>
        /// ProductionCasing property
        /// </summary>
          [XmlEnum("Production Casing")]
          ProductionCasing,
        /// <summary>
        /// ProtectiveCasing property
        /// </summary>
          [XmlEnum(" Protective Casing")]
          ProtectiveCasing,
        /// <summary>
        /// DrillString property
        /// </summary>
          [XmlEnum("Drill String")]
          DrillString,
        /// <summary>
        /// ProductionLiner property
        /// </summary>
          [XmlEnum("Production Liner ")]
          ProductionLiner,
        /// <summary>
        /// WellboreNotes property
        /// </summary>
          [XmlEnum("Wellbore Notes")]
          WellboreNotes,
        /// <summary>
        /// YToolString property
        /// </summary>
          [XmlEnum("Y-Tool String")]
          YToolString,
        /// <summary>
        /// InnerLiner property
        /// </summary>
          [XmlEnum("Inner Liner ")]
          InnerLiner,
        /// <summary>
        /// GeologicalObjects property
        /// </summary>
          [XmlEnum("Geological Objects")]
          GeologicalObjects,
        /// <summary>
        /// Flowline property
        /// </summary>
          Flowline
        }
    }
    #endregion
}