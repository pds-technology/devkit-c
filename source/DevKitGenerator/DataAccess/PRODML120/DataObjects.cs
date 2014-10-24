// 
// License notice 
// Standards DevKit, version 1.0 
// Copyright 2011 ExxonMobil Upstream Research Company
//  
// The following Energistics (c) products were used in the creation of this work: 
// 
// •	WITSML Data Schema Specifications, Version 1.4.1 
// •	WITSML API Specifications, version 1.4.1 
// •	WITSML Data Schema Specifications, Version 1.3.1.1 
// •	WITSML API Specifications, version 1.3.1 
// •	PRODML Data Schema Specifications, Version 1.2 
// •	PRODML Web Service Specifications, Version 2.0
// 
// All rights in the WITSML™ Standard and the PRODML™ Standard, or any portion thereof, which remain in the 
// Standards DevKitshall remain with Energistics or its suppliers and shall remain subject to the terms of 
// the Product License Agreement available at http://www.energistics.org/product-license-agreement. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in 
// compliance with the License. 
// 
// You may obtain a copy of the License at 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the License. 
// 

//This code was generated using the Energistics Generator tool.  Direct changes to this code will be lost
//during regeneration.

using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using Energistics.DataAccess.PRODML120.ComponentSchemas;
using Energistics.DataAccess.PRODML120.ReferenceData;

namespace Energistics.DataAccess.PRODML120
{
    #region Classes
    /// <summary>
    /// This class represents the abstractObject xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellTestList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeriesStatisticList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FluidSampleList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Report))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductVolumeList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductionOperationList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductFlowModelList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeriesDataList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FluidAnalysisResultList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FluidAnalysisList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DtsMeasurementList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DtsInstalledSystemList))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="abstractObject", Namespace="http://www.energistics.org/schemas/abstract")]
    [Description("This class represents the abstractObject xsd type.")]
    public abstract partial class AbstractObject : Object 
    {

    }

    /// <summary>
    /// This class represents the obj_dtsInstalledSystems xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("dtsInstalledSystems", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_dtsInstalledSystems xsd type.")]
    public partial class DtsInstalledSystemList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance.
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Main wrapper for all the distributed temperature survey information about the installed system. Note that this can serve as a standalone object for messages that are not part of the WITSML server architecture.
        /// </summary>
        [XmlElement("dtsInstalledSystem")]
        public List<DtsInstalledSystem> DtsInstalledSystem { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return DtsInstalledSystem;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentInfo", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A schema to capture a set of data that is relevant for many exchange documents. It includes information about the file that was created, and high-level information about the data that is being exchanged within the file.")]
    public partial class DocumentInfo : Object 
    {

        /// <summary>
        /// An identifier for the document. This is intended to be unique within the context of the NamingSystem.
        /// </summary>
        [XmlElement("documentName")]
        public NameStruct DocumentName { get; set; }
		/// <summary>
        /// Zero or more alternate names for the document. These names do not need to be unique within the naming system.
        /// </summary>
        [XmlElement("documentAlias")]
        public List<NameStruct> DocumentAlias { get; set; }
        /// <summary>
        /// The date of the creation of the document. This is not the same as the date that the file was created. For this date, the document is considered to be the set of information associated with this document information. For example, the document may be a seismic binset. This represents the date that the binset was created. The FileCreation information would capture the date that the XML file was created to send or exchange the binset.
        /// </summary>
        [XmlElement("documentDate")]
        public DateTime? DocumentDate {
            get {
                return documentDateField;
            } 
            set { 
                documentDateField = value;
                this.DocumentDateSpecified = true;
            }
        }

        private DateTime? documentDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DocumentDateSpecified { get; set; }
		/// <summary>
        /// A document class. Examples of classes would be a metadata classification or a set of keywords. 
        /// </summary>
        [XmlElement("documentClass")]
        public List<NameStruct> DocumentClass { get; set; }
        /// <summary>
        /// The information about the creation of the exchange file. This is not about the creation of the data within the file, but the creation of the file itself.
        /// </summary>
        [XmlElement("fileCreationInformation")]
        public DocumentFileCreation FileCreationInformation { get; set; }
		/// <summary>
        /// Information about the security to be applied to this file. More than one classification can be given.
        /// </summary>
        [XmlElement("securityInformation")]
        public List<DocumentSecurityInfo> SecurityInformation { get; set; }
        /// <summary>
        /// A free-form string that allows a disclaimer to accompany the information.
        /// </summary>
        [XmlElement("disclaimer")]
        public String Disclaimer { get; set; }
        /// <summary>
        /// A collection of events that can document the history of the data.
        /// </summary>
        [XmlElement("auditTrail")]
        public List<DocumentEvent> AuditTrail { get; set; }
        /// <summary>
        /// The owner of the data.
        /// </summary>
        [XmlElement("owner")]
        public String Owner { get; set; }
        /// <summary>
        /// WITSML query parameters.
        /// </summary>
        [XmlElement("queryParam")]
        public DocumentInfoQueryParam QueryPluggedAndAbandonedram { get; set; }
        /// <summary>
        /// An optional comment about the document.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="nameStruct", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the nameStruct xsd type.")]
    public partial class NameStruct : Object 
    {
        public NameStruct() {}
        public NameStruct(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The naming system within the name is (hopefully) unique.
        /// </summary>
        [XmlAttribute("namingSystem")]
        public String NamingSystem { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Oil, gas, and water volumes and rates measured during the well test. The volumes allow either actual volumes or standard (corrected) volumes. The densities are also recorded with the volumes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestInjectionTestResults", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Oil, gas, and water volumes and rates measured during the well test. The volumes allow either actual volumes or standard (corrected) volumes. The densities are also recorded with the volumes.")]
    public partial class WellTestInjectionTestResults : Object 
    {

        /// <summary>
        /// Oil volumes measured during the well test.
        /// </summary>
        [XmlElement("oilVolume")]
        public WellTestTestVolume OilVolume { get; set; }
        /// <summary>
        /// Oil rates measured during the well test.
        /// </summary>
        [XmlElement("oilRate")]
        public WellTestFluidRate OilRate { get; set; }
        /// <summary>
        /// Gas volumes measured during the well test.
        /// </summary>
        [XmlElement("gasVolume")]
        public WellTestTestVolume GasVolume { get; set; }
        /// <summary>
        /// Gas rates measured during the well test.
        /// </summary>
        [XmlElement("gasRate")]
        public WellTestFluidRate GasRate { get; set; }
        /// <summary>
        /// Water volumes measured during the well test.
        /// </summary>
        [XmlElement("waterVolume")]
        public WellTestTestVolume WaterVolume { get; set; }
        /// <summary>
        /// Water rates measured during the well test.
        /// </summary>
        [XmlElement("waterRate")]
        public WellTestFluidRate WaterRate { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The following sequence of four elements can be used for reporting of most production fluids.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestTestVolume", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The following sequence of four elements can be used for reporting of most production fluids.")]
    public partial class WellTestTestVolume : Object 
    {

        /// <summary>
        /// The volume is the fluid, corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("volumeStdTempPres")]
        public VolumeMeasure VolumeStdTempPres { get; set; }
        /// <summary>
        /// The volume, uncorrected. This volume is generally reported at reservoir conditions.
        /// </summary>
        [XmlElement("volume")]
        public VolumeMeasure Volume { get; set; }
        /// <summary>
        /// The density of the fluid, corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("densityStdTempPres")]
        public DensityMeasure DensityStdTempPres { get; set; }
        /// <summary>
        /// The density of the fluid, uncorrected.
        /// </summary>
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        /// <summary>
        /// Class for Natural Gas. This is not valid for oil or water.
        /// </summary>
        [XmlElement("gasClass")]
        public String GasClass { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the abstractMeasure xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectricPotentialMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnglePerTimeQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaPerAreaQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FootageEastWest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeneralMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellElevationCoord))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellVerticalDepthCoord))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasuredDepthCoord))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RatioGenericMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumePerVolumeMeasurePercent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(YAxisAzimuth))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumePerVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumeFlowRateMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VelocityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThermodynamicTemperatureMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecificVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelativePowerMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PressureMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneAngleMeasure))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectricCurrentMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicViscosityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DimensionlessMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DensityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaPerAreaMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnglePerTimeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnglePerLengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccelerationLinearMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumePerStandardVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StandardVolumePerVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StandardVolumePerStandardVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StandardVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThermalConductivityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MolarVolumeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MolarFractionMeasurePercent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModulusOfCompressionMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MassFlowRateMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MassConcentrationMeasurePercent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MagneticFieldStrengthMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrequencyMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeneralQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompressibilityMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AmountOfSubstanceMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FootageNorthSouth))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnergyPerAreaMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumeQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumeFlowRateQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThermodynamicTemperatureQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemperatureSlopeMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PressureQualifiedMeasure))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LostVolumeAndReason))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthPerLengthQualifiedMeasure))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="abstractMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the abstractMeasure xsd type.")]
    public abstract partial class AbstractMeasure : Object 
    {

		
        [XmlText]
        public Double Value { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the volumeMeasure xsd type.")]
    public partial class VolumeMeasure : AbstractMeasure 
    {
        public VolumeMeasure() {}
        public VolumeMeasure(Double value, VolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumeUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumeQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumeQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the volumeQualifiedMeasure xsd type.")]
    public partial class VolumeQualifiedMeasure : AbstractMeasure 
    {
        public VolumeQualifiedMeasure() {}
        public VolumeQualifiedMeasure(Double value, VolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public VolumeUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumeFlowRateQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumeFlowRateQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the volumeFlowRateQualifiedMeasure xsd type.")]
    public partial class VolumeFlowRateQualifiedMeasure : AbstractMeasure 
    {
        public VolumeFlowRateQualifiedMeasure() {}
        public VolumeFlowRateQualifiedMeasure(Double value, VolumeFlowRateUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public VolumeFlowRateUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the thermodynamicTemperatureQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="thermodynamicTemperatureQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the thermodynamicTemperatureQualifiedMeasure xsd type.")]
    public partial class ThermodynamicTemperatureQualifiedMeasure : AbstractMeasure 
    {
        public ThermodynamicTemperatureQualifiedMeasure() {}
        public ThermodynamicTemperatureQualifiedMeasure(Double value, ThermodynamicTemperatureUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public ThermodynamicTemperatureUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the temperatureSlopeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="temperatureSlopeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the temperatureSlopeMeasure xsd type.")]
    public partial class TemperatureSlopeMeasure : AbstractMeasure 
    {
        public TemperatureSlopeMeasure() {}
        public TemperatureSlopeMeasure(Double value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public String Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the pressureQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="pressureQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the pressureQualifiedMeasure xsd type.")]
    public partial class PressureQualifiedMeasure : AbstractMeasure 
    {
        public PressureQualifiedMeasure() {}
        public PressureQualifiedMeasure(Double value, PressureUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public PressureUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the lostVolumeAndReason xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lostVolumeAndReason", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the lostVolumeAndReason xsd type.")]
    public partial class LostVolumeAndReason : AbstractMeasure 
    {
        public LostVolumeAndReason() {}
        public LostVolumeAndReason(Double value, VolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumeUom Uom { get; set; }
		/// <summary>
        /// Defines why the volume was lost.
        /// </summary>
        [XmlAttribute("reasonLost")]
        private string ReasonLostSurrogate
        {
            get { return ReasonLost.Name; }
            set { ReasonLost.Name = value; }
        }

        [XmlIgnore]
        public ReasonLost ReasonLost { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the lengthPerLengthQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lengthPerLengthQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the lengthPerLengthQualifiedMeasure xsd type.")]
    public partial class LengthPerLengthQualifiedMeasure : AbstractMeasure 
    {
        public LengthPerLengthQualifiedMeasure() {}
        public LengthPerLengthQualifiedMeasure(Double value, LengthPerLengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public LengthPerLengthUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the generalQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="generalQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the generalQualifiedMeasure xsd type.")]
    public partial class GeneralQualifiedMeasure : AbstractMeasure 
    {
        public GeneralQualifiedMeasure() {}
        public GeneralQualifiedMeasure(Double value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// An indicator of the quality of the value.
        /// </summary>
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		/// <summary>
        /// The kind of the value component. For example, "X" in a tuple of X and Y.
        /// </summary>
        [XmlAttribute("component")]
        public String Component { get; set; }
		/// <summary>
        /// The unit of measure for the value. This value must conform to the values allowed by the measure class.
        /// </summary>
        [XmlAttribute("uom")]
        public String Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the generalMeasureType xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="generalMeasureType", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the generalMeasureType xsd type.")]
    public partial class GeneralMeasureType : AbstractMeasure 
    {
        public GeneralMeasureType() {}
        public GeneralMeasureType(Double value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public String Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the areaQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="areaQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the areaQualifiedMeasure xsd type.")]
    public partial class AreaQualifiedMeasure : AbstractMeasure 
    {
        public AreaQualifiedMeasure() {}
        public AreaQualifiedMeasure(Double value, AreaUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public AreaUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the anglePerTimeQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="anglePerTimeQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the anglePerTimeQualifiedMeasure xsd type.")]
    public partial class AnglePerTimeQualifiedMeasure : AbstractMeasure 
    {
        public AnglePerTimeQualifiedMeasure() {}
        public AnglePerTimeQualifiedMeasure(Double value, AnglePerTimeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public AnglePerTimeUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the areaPerAreaQualifiedMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="areaPerAreaQualifiedMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the areaPerAreaQualifiedMeasure xsd type.")]
    public partial class AreaPerAreaQualifiedMeasure : AbstractMeasure 
    {
        public AreaPerAreaQualifiedMeasure() {}
        public AreaPerAreaQualifiedMeasure(Double value, AreaPerAreaUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlAttribute("uom")]
        public AreaPerAreaUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="footageEastWest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the footageEastWest xsd type.")]
    public partial class FootageEastWest : AbstractMeasure 
    {
        public FootageEastWest() {}
        public FootageEastWest(Double value, LengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the distance value.
        /// </summary>
        [XmlAttribute("uom")]
        public LengthUom Uom { get; set; }
		/// <summary>
        /// Specifies the reference line that is the origin of the distance.
        /// </summary>
        [XmlAttribute("ref")]
        public EastOrWest Ref { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="footageNorthSouth", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the footageNorthSouth xsd type.")]
    public partial class FootageNorthSouth : AbstractMeasure 
    {
        public FootageNorthSouth() {}
        public FootageNorthSouth(Double value, LengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the distance value.
        /// </summary>
        [XmlAttribute("uom")]
        public LengthUom Uom { get; set; }
		/// <summary>
        /// Specifies the reference line that is the origin of the distance.
        /// </summary>
        [XmlAttribute("ref")]
        public NorthOrSouth Ref { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="wellElevationCoord", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the wellElevationCoord xsd type.")]
    public partial class WellElevationCoord : AbstractMeasure 
    {
        public WellElevationCoord() {}
        public WellElevationCoord(Double value, WellVerticalCoordinateUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the quantity value. If not given then the default unit of measure of the explicitly or implicitly given datum must be assumed.
        /// </summary>
        [XmlAttribute("uom")]
        public WellVerticalCoordinateUom Uom { get; set; }
		/// <summary>
        /// A pointer to the reference datum for this coordinate value as defined in WellDatum. If not given then the default WellDatum must be assumed.
        /// </summary>
        [XmlAttribute("datum")]
        public String Datum { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="wellVerticalDepthCoord", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the wellVerticalDepthCoord xsd type.")]
    public partial class WellVerticalDepthCoord : AbstractMeasure 
    {
        public WellVerticalDepthCoord() {}
        public WellVerticalDepthCoord(Double value, WellVerticalCoordinateUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the quantity value.
        /// </summary>
        [XmlAttribute("uom")]
        public WellVerticalCoordinateUom Uom { get; set; }
		/// <summary>
        /// A pointer to the reference datum for this coordinate value as defined in WellDatum. If not given then the default WellDatum must be assumed.
        /// </summary>
        [XmlAttribute("datum")]
        public String Datum { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="measuredDepthCoord", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the measuredDepthCoord xsd type.")]
    public partial class MeasuredDepthCoord : AbstractMeasure 
    {
        public MeasuredDepthCoord() {}
        public MeasuredDepthCoord(Double value, MeasuredDepthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the quantity value.
        /// </summary>
        [XmlAttribute("uom")]
        public MeasuredDepthUom Uom { get; set; }
		/// <summary>
        /// A pointer to the reference datum for this coordinate value as defined in WellDatum. This value is assumed to match the uid value in a WellDatum. If not given then the default WellDatum must be assumed.
        /// </summary>
        [XmlAttribute("datum")]
        public String Datum { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ratioGenericMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the ratioGenericMeasure xsd type.")]
    public partial class RatioGenericMeasure : AbstractMeasure 
    {
        public RatioGenericMeasure() {}
        public RatioGenericMeasure(Double value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public String Uom { get; set; }
		
        [XmlAttribute("numerator")]
        public Double Numerator {
            get {
                return numeratorField;
            } 
            set { 
                numeratorField = value;
                this.NumeratorSpecified = true;
            }
        }

        private Double numeratorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean NumeratorSpecified { get; set; }
		
        [XmlAttribute("denominator")]
        public Double Denominator {
            get {
                return denominatorField;
            } 
            set { 
                denominatorField = value;
                this.DenominatorSpecified = true;
            }
        }

        private Double denominatorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DenominatorSpecified { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="genericMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the genericMeasure xsd type.")]
    public partial class GenericMeasure : AbstractMeasure 
    {
        public GenericMeasure() {}
        public GenericMeasure(Double value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure for the quantity.
        /// </summary>
        [XmlAttribute("uom")]
        public String Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumePerVolumeMeasurePercent", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the volumePerVolumeMeasurePercent xsd type.")]
    public partial class VolumePerVolumeMeasurePercent : AbstractMeasure 
    {
        public VolumePerVolumeMeasurePercent() {}
        public VolumePerVolumeMeasurePercent(Double value, PercentUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public PercentUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="yAxisAzimuth", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the yAxisAzimuth xsd type.")]
    public partial class YAxisAzimuth : AbstractMeasure 
    {
        public YAxisAzimuth() {}
        public YAxisAzimuth(Double value, PlaneAngleUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the azimuth value.
        /// </summary>
        [XmlAttribute("uom")]
        public PlaneAngleUom Uom { get; set; }
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
            }
        }

        private AziRef northDirectionField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean NorthDirectionSpecified { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumePerVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the volumePerVolumeMeasure xsd type.")]
    public partial class VolumePerVolumeMeasure : AbstractMeasure 
    {
        public VolumePerVolumeMeasure() {}
        public VolumePerVolumeMeasure(Double value, VolumePerVolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumePerVolumeUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumeFlowRateMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the volumeFlowRateMeasure xsd type.")]
    public partial class VolumeFlowRateMeasure : AbstractMeasure 
    {
        public VolumeFlowRateMeasure() {}
        public VolumeFlowRateMeasure(Double value, VolumeFlowRateUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumeFlowRateUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="velocityMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the velocityMeasure xsd type.")]
    public partial class VelocityMeasure : AbstractMeasure 
    {
        public VelocityMeasure() {}
        public VelocityMeasure(Double value, VelocityUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VelocityUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="timeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the timeMeasure xsd type.")]
    public partial class TimeMeasure : AbstractMeasure 
    {
        public TimeMeasure() {}
        public TimeMeasure(Double value, TimeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public TimeUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="thermodynamicTemperatureMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the thermodynamicTemperatureMeasure xsd type.")]
    public partial class ThermodynamicTemperatureMeasure : AbstractMeasure 
    {
        public ThermodynamicTemperatureMeasure() {}
        public ThermodynamicTemperatureMeasure(Double value, ThermodynamicTemperatureUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ThermodynamicTemperatureUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="specificVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the specificVolumeMeasure xsd type.")]
    public partial class SpecificVolumeMeasure : AbstractMeasure 
    {
        public SpecificVolumeMeasure() {}
        public SpecificVolumeMeasure(Double value, SpecificVolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public SpecificVolumeUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="relativePowerMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the relativePowerMeasure xsd type.")]
    public partial class RelativePowerMeasure : AbstractMeasure 
    {
        public RelativePowerMeasure() {}
        public RelativePowerMeasure(Double value, RelativePowerUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public RelativePowerUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="pressureMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the pressureMeasure xsd type.")]
    public partial class PressureMeasure : AbstractMeasure 
    {
        public PressureMeasure() {}
        public PressureMeasure(Double value, PressureUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public PressureUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="powerMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the powerMeasure xsd type.")]
    public partial class PowerMeasure : AbstractMeasure 
    {
        public PowerMeasure() {}
        public PowerMeasure(Double value, PowerUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public PowerUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="planeAngleMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the planeAngleMeasure xsd type.")]
    public partial class PlaneAngleMeasure : AbstractMeasure 
    {
        public PlaneAngleMeasure() {}
        public PlaneAngleMeasure(Double value, PlaneAngleUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public PlaneAngleUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="perLengthMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the perLengthMeasure xsd type.")]
    public partial class PerLengthMeasure : AbstractMeasure 
    {
        public PerLengthMeasure() {}
        public PerLengthMeasure(Double value, PerLengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public PerLengthUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="momentOfForceMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the momentOfForceMeasure xsd type.")]
    public partial class MomentOfForceMeasure : AbstractMeasure 
    {
        public MomentOfForceMeasure() {}
        public MomentOfForceMeasure(Double value, MomentOfForceUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MomentOfForceUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massPerLengthMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the massPerLengthMeasure xsd type.")]
    public partial class MassPerLengthMeasure : AbstractMeasure 
    {
        public MassPerLengthMeasure() {}
        public MassPerLengthMeasure(Double value, MassPerLengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MassPerLengthUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the massMeasure xsd type.")]
    public partial class MassMeasure : AbstractMeasure 
    {
        public MassMeasure() {}
        public MassMeasure(Double value, MassUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MassUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massConcentrationMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the massConcentrationMeasure xsd type.")]
    public partial class MassConcentrationMeasure : AbstractMeasure 
    {
        public MassConcentrationMeasure() {}
        public MassConcentrationMeasure(Double value, MassConcentrationUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MassConcentrationUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="magneticInductionMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the magneticInductionMeasure xsd type.")]
    public partial class MagneticInductionMeasure : AbstractMeasure 
    {
        public MagneticInductionMeasure() {}
        public MagneticInductionMeasure(Double value, MagneticInductionUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MagneticInductionUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lengthPerLengthMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the lengthPerLengthMeasure xsd type.")]
    public partial class LengthPerLengthMeasure : AbstractMeasure 
    {
        public LengthPerLengthMeasure() {}
        public LengthPerLengthMeasure(Double value, LengthPerLengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public LengthPerLengthUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lengthMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the lengthMeasure xsd type.")]
    public partial class LengthMeasure : AbstractMeasure 
    {
        public LengthMeasure() {}
        public LengthMeasure(Double value, LengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public LengthUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="illuminanceMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the illuminanceMeasure xsd type.")]
    public partial class IlluminanceMeasure : AbstractMeasure 
    {
        public IlluminanceMeasure() {}
        public IlluminanceMeasure(Double value, IlluminanceUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public IlluminanceUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="forcePerVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the forcePerVolumeMeasure xsd type.")]
    public partial class ForcePerVolumeMeasure : AbstractMeasure 
    {
        public ForcePerVolumeMeasure() {}
        public ForcePerVolumeMeasure(Double value, ForcePerVolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ForcePerVolumeUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="forcePerLengthMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the forcePerLengthMeasure xsd type.")]
    public partial class ForcePerLengthMeasure : AbstractMeasure 
    {
        public ForcePerLengthMeasure() {}
        public ForcePerLengthMeasure(Double value, ForcePerLengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ForcePerLengthUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="forceMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the forceMeasure xsd type.")]
    public partial class ForceMeasure : AbstractMeasure 
    {
        public ForceMeasure() {}
        public ForceMeasure(Double value, ForceUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ForceUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="equivalentPerMassMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the equivalentPerMassMeasure xsd type.")]
    public partial class EquivalentPerMassMeasure : AbstractMeasure 
    {
        public EquivalentPerMassMeasure() {}
        public EquivalentPerMassMeasure(Double value, EquivalentPerMassUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public EquivalentPerMassUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="electricPotentialMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the electricPotentialMeasure xsd type.")]
    public partial class ElectricPotentialMeasure : AbstractMeasure 
    {
        public ElectricPotentialMeasure() {}
        public ElectricPotentialMeasure(Double value, ElectricPotentialUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ElectricPotentialUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="electricCurrentMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the electricCurrentMeasure xsd type.")]
    public partial class ElectricCurrentMeasure : AbstractMeasure 
    {
        public ElectricCurrentMeasure() {}
        public ElectricCurrentMeasure(Double value, ElectricCurrentUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ElectricCurrentUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="dynamicViscosityMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the dynamicViscosityMeasure xsd type.")]
    public partial class DynamicViscosityMeasure : AbstractMeasure 
    {
        public DynamicViscosityMeasure() {}
        public DynamicViscosityMeasure(Double value, DynamicViscosityUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public DynamicViscosityUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="dimensionlessMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the dimensionlessMeasure xsd type.")]
    public partial class DimensionlessMeasure : AbstractMeasure 
    {
        public DimensionlessMeasure() {}
        public DimensionlessMeasure(Double value, DimensionlessUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public DimensionlessUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="densityMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the densityMeasure xsd type.")]
    public partial class DensityMeasure : AbstractMeasure 
    {
        public DensityMeasure() {}
        public DensityMeasure(Double value, DensityUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public DensityUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="areaPerAreaMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the areaPerAreaMeasure xsd type.")]
    public partial class AreaPerAreaMeasure : AbstractMeasure 
    {
        public AreaPerAreaMeasure() {}
        public AreaPerAreaMeasure(Double value, AreaPerAreaUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public AreaPerAreaUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="areaMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the areaMeasure xsd type.")]
    public partial class AreaMeasure : AbstractMeasure 
    {
        public AreaMeasure() {}
        public AreaMeasure(Double value, AreaUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public AreaUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="anglePerTimeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the anglePerTimeMeasure xsd type.")]
    public partial class AnglePerTimeMeasure : AbstractMeasure 
    {
        public AnglePerTimeMeasure() {}
        public AnglePerTimeMeasure(Double value, AnglePerTimeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public AnglePerTimeUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="anglePerLengthMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the anglePerLengthMeasure xsd type.")]
    public partial class AnglePerLengthMeasure : AbstractMeasure 
    {
        public AnglePerLengthMeasure() {}
        public AnglePerLengthMeasure(Double value, AnglePerLengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public AnglePerLengthUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="accelerationLinearMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the accelerationLinearMeasure xsd type.")]
    public partial class AccelerationLinearMeasure : AbstractMeasure 
    {
        public AccelerationLinearMeasure() {}
        public AccelerationLinearMeasure(Double value, AccelerationLinearUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public AccelerationLinearUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the workMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="workMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the workMeasure xsd type.")]
    public partial class WorkMeasure : AbstractMeasure 
    {
        public WorkMeasure() {}
        public WorkMeasure(Double value, WorkUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public WorkUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the volumePerStandardVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="volumePerStandardVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the volumePerStandardVolumeMeasure xsd type.")]
    public partial class VolumePerStandardVolumeMeasure : AbstractMeasure 
    {
        public VolumePerStandardVolumeMeasure() {}
        public VolumePerStandardVolumeMeasure(Double value, VolumePerVolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumePerVolumeUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the standardVolumePerVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="standardVolumePerVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the standardVolumePerVolumeMeasure xsd type.")]
    public partial class StandardVolumePerVolumeMeasure : AbstractMeasure 
    {
        public StandardVolumePerVolumeMeasure() {}
        public StandardVolumePerVolumeMeasure(Double value, VolumePerVolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumePerVolumeUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the standardVolumePerStandardVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="standardVolumePerStandardVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the standardVolumePerStandardVolumeMeasure xsd type.")]
    public partial class StandardVolumePerStandardVolumeMeasure : AbstractMeasure 
    {
        public StandardVolumePerStandardVolumeMeasure() {}
        public StandardVolumePerStandardVolumeMeasure(Double value, VolumePerVolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumePerVolumeUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="standardVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the standardVolumeMeasure xsd type.")]
    public partial class StandardVolumeMeasure : AbstractMeasure 
    {
        public StandardVolumeMeasure() {}
        public StandardVolumeMeasure(Double value, VolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public VolumeUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="thermalConductivityMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the thermalConductivityMeasure xsd type.")]
    public partial class ThermalConductivityMeasure : AbstractMeasure 
    {
        public ThermalConductivityMeasure() {}
        public ThermalConductivityMeasure(Double value, ThermalConductivityUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ThermalConductivityUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the molarVolumeMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="molarVolumeMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the molarVolumeMeasure xsd type.")]
    public partial class MolarVolumeMeasure : AbstractMeasure 
    {
        public MolarVolumeMeasure() {}
        public MolarVolumeMeasure(Double value, MolarVolumeUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MolarVolumeUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the molarFractionMeasurePercent xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="molarFractionMeasurePercent", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the molarFractionMeasurePercent xsd type.")]
    public partial class MolarFractionMeasurePercent : AbstractMeasure 
    {
        public MolarFractionMeasurePercent() {}
        public MolarFractionMeasurePercent(Double value, PercentUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public PercentUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the modulusOfCompressionMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="modulusOfCompressionMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the modulusOfCompressionMeasure xsd type.")]
    public partial class ModulusOfCompressionMeasure : AbstractMeasure 
    {
        public ModulusOfCompressionMeasure() {}
        public ModulusOfCompressionMeasure(Double value, ModulusOfCompressionUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public ModulusOfCompressionUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the massFlowRateMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massFlowRateMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the massFlowRateMeasure xsd type.")]
    public partial class MassFlowRateMeasure : AbstractMeasure 
    {
        public MassFlowRateMeasure() {}
        public MassFlowRateMeasure(Double value, MassFlowRateUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MassFlowRateUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the massConcentrationMeasurePercent xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="massConcentrationMeasurePercent", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the massConcentrationMeasurePercent xsd type.")]
    public partial class MassConcentrationMeasurePercent : AbstractMeasure 
    {
        public MassConcentrationMeasurePercent() {}
        public MassConcentrationMeasurePercent(Double value, PercentUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public PercentUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the magneticFieldStrengthMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="magneticFieldStrengthMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the magneticFieldStrengthMeasure xsd type.")]
    public partial class MagneticFieldStrengthMeasure : AbstractMeasure 
    {
        public MagneticFieldStrengthMeasure() {}
        public MagneticFieldStrengthMeasure(Double value, MagneticFieldStrengthUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public MagneticFieldStrengthUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the frequencyMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="frequencyMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the frequencyMeasure xsd type.")]
    public partial class FrequencyMeasure : AbstractMeasure 
    {
        public FrequencyMeasure() {}
        public FrequencyMeasure(Double value, FrequencyUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public FrequencyUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the energyPerAreaMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="energyPerAreaMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the energyPerAreaMeasure xsd type.")]
    public partial class EnergyPerAreaMeasure : AbstractMeasure 
    {
        public EnergyPerAreaMeasure() {}
        public EnergyPerAreaMeasure(Double value, EnergyPerAreaUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public EnergyPerAreaUom Uom { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="compressibilityMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the compressibilityMeasure xsd type.")]
    public partial class CompressibilityMeasure : AbstractMeasure 
    {
        public CompressibilityMeasure() {}
        public CompressibilityMeasure(Double value, CompressibilityUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public CompressibilityUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the amountOfSubstanceMeasure xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="amountOfSubstanceMeasure", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the amountOfSubstanceMeasure xsd type.")]
    public partial class AmountOfSubstanceMeasure : AbstractMeasure 
    {
        public AmountOfSubstanceMeasure() {}
        public AmountOfSubstanceMeasure(Double value, AmountOfSubstanceUom uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("uom")]
        public AmountOfSubstanceUom Uom { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_wellTestFluidRate xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestFluidRate", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_wellTestFluidRate xsd type.")]
    public partial class WellTestFluidRate : Object 
    {

        /// <summary>
        /// The fluid flow rate.
        /// </summary>
        [XmlElement("fluidRate")]
        public VolumeFlowRateMeasure FluidRate { get; set; }
        /// <summary>
        /// The fluid flow rate that has been corrected to standard temperature and pressure.
        /// </summary>
        [XmlElement("fluidRateStdTempPres")]
        public VolumeFlowRateMeasure FluidRateStdTempPres { get; set; }
        /// <summary>
        /// Class for Natural Gas. This is not valid for oil or water.
        /// </summary>
        [XmlElement("gasClass")]
        public String GasClass { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_wellTestInjectionTestData xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestInjectionTestData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_wellTestInjectionTestData xsd type.")]
    public partial class WellTestInjectionTestData : Object 
    {

        /// <summary>
        /// The time length (with uom) of the well test.
        /// </summary>
        [XmlElement("testDuration")]
        public TimeMeasure TestDuration { get; set; }
        /// <summary>
        /// The interval tested. This element includes a top and base depth, and the formation tested.
        /// </summary>
        [XmlElement("testInterval")]
        public WellTestInterval TestInterval { get; set; }
        /// <summary>
        /// The fluid that is being injected. 
        /// </summary>
        [XmlElement("InjectedFluid")]
        public InjectionFluid InjectedFluid {
            get {
                return InjectedFluidField;
            } 
            set { 
                InjectedFluidField = value;
                this.InjectedFluidSpecified = true;
            }
        }

        private InjectionFluid InjectedFluidField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean InjectedFluidSpecified { get; set; }
        /// <summary>
        /// The cumulative volumes of fluids at the time of the well test. The fluids are oil, gas, and water.
        /// </summary>
        [XmlElement("wellTestCumulative")]
        public WellTestCumulative WellTestCumulative { get; set; }
        /// <summary>
        /// The size of the opening in the flow choke at the wellhead.
        /// </summary>
        [XmlElement("chokeOrificeSize")]
        public LengthMeasure ChokeOrificeSize { get; set; }
        /// <summary>
        /// The minimum pressure measured at the annulus.
        /// </summary>
        [XmlElement("minimumAnnularPressure")]
        public PressureMeasure MinimumAnnularPressure { get; set; }
        /// <summary>
        /// The maximum pressure measured at the annulus.
        /// </summary>
        [XmlElement("maximumAnnularPressure")]
        public PressureMeasure MaximumAnnularPressure { get; set; }
        /// <summary>
        /// The flowing pressure measured at the wellhead during the test.
        /// </summary>
        [XmlElement("wellheadFlowingPressure")]
        public PressureMeasure WellheadFlowingPressure { get; set; }
        /// <summary>
        /// The maximum pressure measured at the wellhead during the well test.
        /// </summary>
        [XmlElement("wellheadMaximumPressure")]
        public PressureMeasure WellheadMaximumPressure { get; set; }
        /// <summary>
        /// The production results of the test.
        /// </summary>
        [XmlElement("injectionTestResults")]
        public WellTestInjectionTestResults InjectionTestResults { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_wellTestInterval xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestInterval", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_wellTestInterval xsd type.")]
    public partial class WellTestInterval : Object 
    {

        /// <summary>
        /// The measured depth to the top of the interval.
        /// </summary>
        [XmlElement("mdTop")]
        public MeasuredDepthCoord MDTop { get; set; }
        /// <summary>
        /// The measured depth to the bottom of the interval.
        /// </summary>
        [XmlElement("mdBase")]
        public MeasuredDepthCoord MDBase { get; set; }
        /// <summary>
        /// Defines the wellbore (sidetract) represented by the measured depth. This must be given when the well has multiple wellbores and the measured depth value is deeper than the first kickoff point. It is recommended that it always be given.
        /// </summary>
        [XmlElement("wellbore")]
        public RefNameString Wellbore { get; set; }
		/// <summary>
        /// A formation that was tested.
        /// </summary>
        [XmlElement("testedFormation")]
        public List<String> TestedFormation { get; set; }
        /// <summary>
        /// The relative opening of the downhole control valve for the tested zone. This is for surface controllable valves.
        /// </summary>
        [XmlElement("valvePosition")]
        public LengthPerLengthMeasure ValvePosition { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="refNameString", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the refNameString xsd type.")]
    public partial class RefNameString : Object 
    {
        public RefNameString() {}
        public RefNameString(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// A reference to the unique identifier (uid attribute) in the node referenced by the name value. This attribute is required within the context of a WITSML server.
        /// </summary>
        [XmlAttribute("uidRef")]
        public String UidRef { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The cumulative amounts of the fluids at the time of the well test. The fluids are oil, gas, and water.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestCumulative", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The cumulative amounts of the fluids at the time of the well test. The fluids are oil, gas, and water.")]
    public partial class WellTestCumulative : Object 
    {

        /// <summary>
        /// The cumulative amount of oil.
        /// </summary>
        [XmlElement("cumulativeOil")]
        public VolumeMeasure CumulativeOil { get; set; }
        /// <summary>
        /// The cumulative amount of gas.
        /// </summary>
        [XmlElement("cumulativeGas")]
        public VolumeMeasure CumulativeGas { get; set; }
        /// <summary>
        /// The cumulative amount of water.
        /// </summary>
        [XmlElement("cumulativeWater")]
        public VolumeMeasure CumulativeWater { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Oil, gas, and water volumes and rates measured during the well test. The volumes allow either actual volumes or standard (corrected) volumes. The densities are also recorded with the volumes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestProductionTestResults", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Oil, gas, and water volumes and rates measured during the well test. The volumes allow either actual volumes or standard (corrected) volumes. The densities are also recorded with the volumes.")]
    public partial class WellTestProductionTestResults : Object 
    {

        /// <summary>
        /// Oil volumes measured during the well test.
        /// </summary>
        [XmlElement("oilVolume")]
        public WellTestTestVolume OilVolume { get; set; }
        /// <summary>
        /// Oil rates measured during the well test.
        /// </summary>
        [XmlElement("oilRate")]
        public WellTestFluidRate OilRate { get; set; }
        /// <summary>
        /// Gas volumes measured during the well test.
        /// </summary>
        [XmlElement("gasVolume")]
        public WellTestTestVolume GasVolume { get; set; }
        /// <summary>
        /// Gas rates measured during the well test.
        /// </summary>
        [XmlElement("gasRate")]
        public WellTestFluidRate GasRate { get; set; }
        /// <summary>
        /// Water volumes measured during the well test.
        /// </summary>
        [XmlElement("waterVolume")]
        public WellTestTestVolume WaterVolume { get; set; }
        /// <summary>
        /// Water rates measured during the well test.
        /// </summary>
        [XmlElement("waterRate")]
        public WellTestFluidRate WaterRate { get; set; }
        /// <summary>
        /// condensate volumes measured during the well test.
        /// </summary>
        [XmlElement("condensateVolume")]
        public WellTestTestVolume CondensateVolume { get; set; }
        /// <summary>
        /// Condensate rates measured during the well test.
        /// </summary>
        [XmlElement("condensateRate")]
        public WellTestFluidRate CondensateRate { get; set; }
        /// <summary>
        /// The ratio of the volume of gas and the volume of oil that was produced.
        /// </summary>
        [XmlElement("gasOilRatio")]
        public VolumePerVolumeMeasure GasOilRatio { get; set; }
        /// <summary>
        /// The ratio of water produced compared to the volume of total liquids produced.
        /// </summary>
        [XmlElement("waterCut")]
        public VolumePerVolumeMeasure WaterCut { get; set; }
        /// <summary>
        /// The density of the fluid mixture.
        /// </summary>
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        /// <summary>
        /// The velocity of the overall fluid mixture.
        /// </summary>
        [XmlElement("fluidVelocity")]
        public VelocityMeasure FluidVelocity { get; set; }
        /// <summary>
        /// This is the condensate yield, which describes the amount of condensate per unit of natural gas produced
        /// </summary>
        [XmlElement("condensateYield")]
        public VolumePerVolumeMeasure CondensateYield { get; set; }
        /// <summary>
        /// This is the measured of impurities present in crude oil as it comes from the well. BSandW content is commonly used as a measure for treating performance of hydrocarbon liquids
        /// </summary>
        [XmlElement("basicSedimentAndWater")]
        public VolumePerVolumeMeasure BasicSedimentAndWater { get; set; }
        /// <summary>
        /// This is the the potential of the well to produce crude oil. This represents the flow rate that could be achieved under maximum drawdown.
        /// </summary>
        [XmlElement("oilPotential")]
        public VolumeFlowRateMeasure OilPotential { get; set; }
        /// <summary>
        /// This is the potential of the well to produce natural gas. This represents the flow rate that could be achieved under maximum drawdown.
        /// </summary>
        [XmlElement("gasPotential")]
        public VolumeFlowRateMeasure GasPotential { get; set; }
        /// <summary>
        /// the volume of sand that was produced.
        /// </summary>
        [XmlElement("sandVolume")]
        public VolumeMeasure SandVolume { get; set; }
        /// <summary>
        /// True ("true" or "1") indicates that the the split factors are allocated as opposed to measured. False ("false" or "0") or not given indicates otherwise.
        /// </summary>
        [XmlElement("allocatedSplit")]
        public Boolean? AllocatedSplit {
            get {
                return allocatedSplitField;
            } 
            set { 
                allocatedSplitField = value;
                this.AllocatedSplitSpecified = true;
            }
        }

        private Boolean? allocatedSplitField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AllocatedSplitSpecified { get; set; }
        /// <summary>
        /// The split factor for Oil relative to the overall volume of the test.
        /// </summary>
        [XmlElement("oilSplitFactor")]
        public VolumePerVolumeMeasure OilSplitFactor { get; set; }
        /// <summary>
        /// The split factor for Gas relative to the overall volume of the test.
        /// </summary>
        [XmlElement("gasSplitFactor")]
        public VolumePerVolumeMeasure GasSplitFactor { get; set; }
        /// <summary>
        /// The split factor for Water relative to the overall volume of the test.
        /// </summary>
        [XmlElement("waterSplitFactor")]
        public VolumePerVolumeMeasure WaterSplitFactor { get; set; }
        /// <summary>
        /// The split factor for Condensate relative to the overall volume of the test.
        /// </summary>
        [XmlElement("condensateSplitFactor")]
        public VolumePerVolumeMeasure CondensateSplitFactor { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Well test data gathered at the separator.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestSeparatorData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Well test data gathered at the separator.")]
    public partial class WellTestSeparatorData : Object 
    {

        /// <summary>
        /// The pressure measured at the separator during the well test.
        /// </summary>
        [XmlElement("separatorPressure")]
        public PressureMeasure SeparatorPressure { get; set; }
        /// <summary>
        /// The temperature measured at the separator during the well test.
        /// </summary>
        [XmlElement("separatorTemperature")]
        public ThermodynamicTemperatureMeasure SeparatorTemperature { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Well test data gathered at points in the wellbore.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestPointData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Well test data gathered at points in the wellbore.")]
    public partial class WellTestPointData : Object 
    {

        /// <summary>
        /// The pressure at the point.
        /// </summary>
        [XmlElement("pres")]
        public PressureMeasure Pres { get; set; }
        /// <summary>
        /// The temperature at the point.
        /// </summary>
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp { get; set; }
        /// <summary>
        /// The P/Z value at the point. This is P/Z, pressure over gas compressibility factor (z). Note that the uom is units of pressure., since Z is dimensionless.
        /// </summary>
        [XmlElement("pOverZ")]
        public PressureMeasure POverZ { get; set; }
        /// <summary>
        /// The measured depth of the bottomhole.
        /// </summary>
        [XmlElement("md")]
        public MeasuredDepthCoord MD { get; set; }
        /// <summary>
        /// Defines the wellbore (sidetract) represented by the measured depth. This must be given when the well has multiple wellbores and the measured depth value is deeper than the first kickoff point. It is recommended that it always be given.
        /// </summary>
        [XmlElement("wellbore")]
        public RefNameString Wellbore { get; set; }
        /// <summary>
        /// A value of true (1 or "true") indicates that the point is at the bottomhole. A value of false (0 or "false") or not given indicates otherwise.
        /// </summary>
        [XmlElement("bottomhole")]
        public Boolean? Bottomhole {
            get {
                return bottomholeField;
            } 
            set { 
                bottomholeField = value;
                this.BottomholeSpecified = true;
            }
        }

        private Boolean? bottomholeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean BottomholeSpecified { get; set; }
        /// <summary>
        /// A value of true (1 or "true") indicates a static (non-flowing) pressure. A value of false (0 or "false") or not given indicates otherwise. The pressure may be measured (e.g., shut-in well) or calculated.
        /// </summary>
        [XmlElement("static")]
        public Boolean? Static {
            get {
                return staticField;
            } 
            set { 
                staticField = value;
                this.StaticSpecified = true;
            }
        }

        private Boolean? staticField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StaticSpecified { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_wellTestElectricSubmersiblePumpData xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestElectricSubmersiblePumpData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_wellTestElectricSubmersiblePumpData xsd type.")]
    public partial class WellTestElectricSubmersiblePumpData : Object 
    {

        /// <summary>
        /// The average electric current of the electric submersible pump (ESP) during the test. The presumption is that only one pump per well is operational during each test.
        /// </summary>
        [XmlElement("electricCurrent")]
        public ElectricCurrentMeasure ElectricCurrent { get; set; }
        /// <summary>
        /// The average frequency of the electric submersible pump (ESP) during the test. The presumption is that only one pump per well is operational during each test.
        /// </summary>
        [XmlElement("frequency")]
        public FrequencyMeasure Frequency { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Well test data gathered at the bottomhole.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestBottomholeData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Well test data gathered at the bottomhole.")]
    public partial class WellTestBottomholeData : Object 
    {

        /// <summary>
        /// The pressure at the bottomhole of the well.
        /// </summary>
        [XmlElement("bottomholePres")]
        public PressureMeasure BottomholePres { get; set; }
        /// <summary>
        /// The temperature at the bottomhole of the well.
        /// </summary>
        [XmlElement("bottomholeTemp")]
        public ThermodynamicTemperatureMeasure BottomholeTemp { get; set; }
        /// <summary>
        /// The P/Z value at the bottomhole. This is P/Z, pressure over gas compressibility factor (z), at the bottomhole of the well. Note that the uom is units of pressure., since Z is dimensionless.
        /// </summary>
        [XmlElement("bottomholePOverZ")]
        public PressureMeasure BottomholePOverZ { get; set; }
        /// <summary>
        /// The measured depth of the bottomhole.
        /// </summary>
        [XmlElement("bottomholeMD")]
        public MeasuredDepthCoord BottomholeMD { get; set; }
        /// <summary>
        /// Defines the wellbore (sidetract) represented by the measured depth. This must be given when the well has multiple wellbores and the measured depth value is deeper than the first kickoff point. It is recommended that it always be given.
        /// </summary>
        [XmlElement("wellbore")]
        public RefNameString Wellbore { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Basic measurements at the wellhead, during the well test.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestWellheadData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Basic measurements at the wellhead, during the well test.")]
    public partial class WellTestWellheadData : Object 
    {

        /// <summary>
        /// The temperature measured at the wellhead during the well test.
        /// </summary>
        [XmlElement("temperature")]
        public ThermodynamicTemperatureMeasure Temperature { get; set; }
        /// <summary>
        /// The flowing pressure measured at the wellhead during the well test.
        /// </summary>
        [XmlElement("flowingPressure")]
        public PressureMeasure FlowingPressure { get; set; }
        /// <summary>
        /// The shut-in pressure measured at the wellhead during the well test.
        /// </summary>
        [XmlElement("shutInPressure")]
        public PressureMeasure ShutInPressure { get; set; }
        /// <summary>
        /// The pressure measured at the flow line connected to the wellhead during this well test.
        /// </summary>
        [XmlElement("flowLinePressure")]
        public PressureMeasure FlowLinePressure { get; set; }
        /// <summary>
        /// The size of the choke opening at the wellhead.
        /// </summary>
        [XmlElement("chokeOrificeSize")]
        public LengthMeasure ChokeOrificeSize { get; set; }
        /// <summary>
        /// The pressure of the lift gas at the wellhead.
        /// </summary>
        [XmlElement("gasLiftPres")]
        public PressureMeasure GasLiftPres { get; set; }
        /// <summary>
        /// The temperature of the lift gas at the wellhead.
        /// </summary>
        [XmlElement("gasLiftTemp")]
        public ThermodynamicTemperatureMeasure GasLiftTemp { get; set; }
        /// <summary>
        /// Lift gas volumes injected during the well test at the wellhead.
        /// </summary>
        [XmlElement("gasLiftVolume")]
        public WellTestTestVolume GasLiftVolume { get; set; }
        /// <summary>
        /// Lift gas rates injected during the well test at the wellhead.
        /// </summary>
        [XmlElement("gasLiftRate")]
        public WellTestFluidRate GasLiftRate { get; set; }
        /// <summary>
        /// The size of the gas lift choke opening.
        /// </summary>
        [XmlElement("gasLiftchokeOrificeSize")]
        public LengthMeasure GasLiftchokeOrificeSize { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_wellTestProductionTestData xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestProductionTestData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_wellTestProductionTestData xsd type.")]
    public partial class WellTestProductionTestData : Object 
    {

        /// <summary>
        /// The time length (with uom) of the well test.
        /// </summary>
        [XmlElement("testDuration")]
        public TimeMeasure TestDuration { get; set; }
		/// <summary>
        /// The interval tested. This element includes a top and base depth, and the formation(s) tested. It also includes control data for the tested interval.
        /// </summary>
        [XmlElement("testInterval")]
        public List<WellTestInterval> TestInterval { get; set; }
        /// <summary>
        /// This element records measurements made and settings made at the wellhead.
        /// </summary>
        [XmlElement("wellheadData")]
        public WellTestWellheadData WellheadData { get; set; }
        /// <summary>
        /// DEPRECATED - Use pointData instead. This element records measurements made at the bottomhole.
        /// </summary>
        [XmlElement("bottomholeData")]
        public WellTestBottomholeData BottomholeData { get; set; }
        /// <summary>
        /// Frequency and electric current measured during the well test for electric submersible pump (ESP) wells. The presumption is that only one pump per well is operational during each test.
        /// </summary>
        [XmlElement("espData")]
        public WellTestElectricSubmersiblePumpData EspData { get; set; }
		/// <summary>
        /// This element records temperature and pressure at points in the wellbore.
        /// </summary>
        [XmlElement("pointData")]
        public List<WellTestPointData> PointData { get; set; }
        /// <summary>
        /// This element records the measurements (pressure and temperature) at the separator.
        /// </summary>
        [XmlElement("separatorData")]
        public WellTestSeparatorData SeparatorData { get; set; }
        /// <summary>
        /// The method being used to operate the well. Examples are 'flowing', 'pumping', 'gas lifted'.
        /// </summary>
        [XmlElement("operatingMethod")]
        public String OperatingMethod { get; set; }
        /// <summary>
        /// The cumulative volumes of fluids at the time of the well test. The fluids are oil, gas, and water.
        /// </summary>
        [XmlElement("wellTestCumulative")]
        public WellTestCumulative WellTestCumulative { get; set; }
        /// <summary>
        /// The production results of the test.
        /// </summary>
        [XmlElement("productionTestResults")]
        public WellTestProductionTestResults ProductionTestResults { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_wellTestFluidLevelTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestFluidLevelTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_wellTestFluidLevelTest xsd type.")]
    public partial class WellTestFluidLevelTest : Object 
    {

        /// <summary>
        /// The fluid level achieved in the well. The value is given as length units from the top of the well.
        /// </summary>
        [XmlElement("fluidLevel")]
        public LengthMeasure FluidLevel { get; set; }
        /// <summary>
        /// The lowest usable water depth as measured from the surface. See TxRRC H-15.
        /// </summary>
        [XmlElement("baseUsableWater")]
        public LengthMeasure BaseUsableWater { get; set; }
        /// <summary>
        /// The business associate that conducted the test. This is generally a person.
        /// </summary>
        [XmlElement("testedBy")]
        public String TestedBy { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_wellTestValidationOperation xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellTestValidationOperation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_wellTestValidationOperation xsd type.")]
    public partial class WellTestValidationOperation : Object 
    {

        /// <summary>
        /// The kind of validation operation.
        /// </summary>
        [XmlElement("kind")]
        public ValidationOperation Kind { get; set; }
        /// <summary>
        /// The result of the validation operation.
        /// </summary>
        [XmlElement("result")]
        public ValidationResult Result { get; set; }
		/// <summary>
        /// The date of the validation operation.
        /// </summary>
        [XmlElement("")]
        public DateTime? Date {
            get {
                return dateField;
            } 
            set { 
                dateField = value;
                this.DateSpecified = true;
            }
        }

        private DateTime? dateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateSpecified { get; set; }
        /// <summary>
        /// The tool used for the validation operation.
        /// </summary>
        [XmlElement("tool")]
        public String Tool { get; set; }
        /// <summary>
        /// The method used for the validation operation..
        /// </summary>
        [XmlElement("method")]
        public String Method { get; set; }
        /// <summary>
        /// A comment about the operation.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    /// <summary>
    /// The non-contextual content of a WITSML Well Test object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_wellTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The non-contextual content of a WITSML Well Test object.")]
    public partial class WellTest : Object 
    {

        /// <summary>
        /// Human recognizable context for the well that contains the well test. 
        /// </summary>
        [XmlElement("nameWell")]
        public String NameWell { get; set; }
        /// <summary>
        /// Human recognizable context for the well test. 
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The minimum time index contained within the object. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. That is, all wellTest for a well in the specified period defined by the min/max. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMin")]
        public EndpointQualifiedDateTime DateTimeMin { get; set; }
        /// <summary>
        /// The maximum time index contained within the object. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMax")]
        public EndpointQualifiedDateTime DateTimeMax { get; set; }
        /// <summary>
        /// The definition of the "current time" index for this object. The current time index is a server query parameter which requests the selection of a single node from a recurring set (e.g., the data related to one point in a time series). That is, the "most recent" (at or before the specified time) wellTest for a well. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimCurrent")]
        public DateTime? DateTimeCurrent {
            get {
                return dTimCurrentField;
            } 
            set { 
                dTimCurrentField = value;
                this.DateTimeCurrentSpecified = true;
            }
        }

        private DateTime? dTimCurrentField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeCurrentSpecified { get; set; }
        /// <summary>
        /// Contextual data about the well that was tested.
        /// </summary>
        [XmlElement("wellContext")]
        public WellContext WellContext { get; set; }
        /// <summary>
        /// The date-time of well test.
        /// </summary>
        [XmlElement("testDate")]
        public DateTime? TestDate {
            get {
                return testDateField;
            } 
            set { 
                testDateField = value;
                this.TestDateSpecified = true;
            }
        }

        private DateTime? testDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestDateSpecified { get; set; }
        /// <summary>
        /// The date-time of the previous well test.
        /// </summary>
        [XmlElement("previousTestDate")]
        public DateTime? PreviousTestDate {
            get {
                return previousTestDateField;
            } 
            set { 
                previousTestDateField = value;
                this.PreviousTestDateSpecified = true;
            }
        }

        private DateTime? previousTestDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PreviousTestDateSpecified { get; set; }
        /// <summary>
        /// The date-time of the last valid well test.
        /// </summary>
        [XmlElement("lastValidTest")]
        public DateTime? LastValidTest {
            get {
                return lastValidTestField;
            } 
            set { 
                lastValidTestField = value;
                this.LastValidTestSpecified = true;
            }
        }

        private DateTime? lastValidTestField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean LastValidTestSpecified { get; set; }
        /// <summary>
        /// The reason for the well test: initial, periodic, revision.
        /// </summary>
        [XmlElement("testReason")]
        public TestReason TestReason {
            get {
                return testReasonField;
            } 
            set { 
                testReasonField = value;
                this.TestReasonSpecified = true;
            }
        }

        private TestReason testReasonField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestReasonSpecified { get; set; }
        /// <summary>
        /// The type of well production test.
        /// </summary>
        [XmlElement("testType")]
        public String TestType { get; set; }
        /// <summary>
        /// DEPRECATED: use productionTest/wellheadData/chokeOrificeSize or injectionTest/chokeOrificeSize. The size of the opening in the flow choke at the wellhead.
        /// </summary>
        [XmlElement("chokeOrificeSize")]
        public LengthMeasure ChokeOrificeSize { get; set; }
        /// <summary>
        /// A port on a Product Flow Unit that is represented by this test.
        /// </summary>
        [XmlElement("productFlowPort")]
        public RefNameString ProductFlowPort { get; set; }
        /// <summary>
        /// The Product Flow Unit represented by the port. This is defined within the Product Flow Model
        /// </summary>
        [XmlElement("productFlowUnit")]
        public RefNameString ProductFlowUnit { get; set; }
        /// <summary>
        /// The Product Flow Model that represents the above Product Flow Unit.
        /// </summary>
        [XmlElement("productFlowModel")]
        public RefNameString ProductFlowModel { get; set; }
        /// <summary>
        /// Defines the standard temperature and pressure to which all standard volumes in this report have been corrected. This applies to all elements whose name is suffixed by StdTempPres.
        /// </summary>
        [XmlElement("standardTempPres")]
        public StandardTempPress StandardTempPres {
            get {
                return standardTempPresField;
            } 
            set { 
                standardTempPresField = value;
                this.StandardTempPresSpecified = true;
            }
        }

        private StandardTempPress standardTempPresField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StandardTempPresSpecified { get; set; }
        /// <summary>
        /// The overall state of the test with respect to validation operations.
        /// </summary>
        [XmlElement("validationState")]
        public ValidationState ValidationState {
            get {
                return validationStateField;
            } 
            set { 
                validationStateField = value;
                this.ValidationStateSpecified = true;
            }
        }

        private ValidationState validationStateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ValidationStateSpecified { get; set; }
		/// <summary>
        /// Defines the results of one validation operation.
        /// </summary>
        [XmlElement("validationOperation")]
        public List<WellTestValidationOperation> ValidationOperatingeration { get; set; }
        /// <summary>
        /// Data from a production test. Multiple tests generally indicate that there are multiple components of a single overall test. For example, for multi-zoned wells.
        /// </summary>
        [XmlElement("productionTest")]
        public WellTestProductionTestData ProductionTest {
            get {
                return productionTestField;
            } 
            set { 
                if (injectionTestFieldSpecified) throw new Exception("Cannot set property ProductionTest when property InjectionTest is already set");
                if (fluidLevelTestFieldSpecified) throw new Exception("Cannot set property ProductionTest when property FluidLevelTest is already set");
                productionTestField = value;
                productionTestFieldSpecified = true;
            }
        }

        private WellTestProductionTestData productionTestField; 
        private bool productionTestFieldSpecified = false; 

        /// <summary>
        /// Data from an injection test. Multiple tests generally indicate that there are multiple components of the overall test. For example, for multi-zoned wells.
        /// </summary>
        [XmlElement("injectionTest")]
        public WellTestInjectionTestData InjectionTest {
            get {
                return injectionTestField;
            } 
            set { 
                if (productionTestFieldSpecified) throw new Exception("Cannot set property InjectionTest when property ProductionTest is already set");
                if (fluidLevelTestFieldSpecified) throw new Exception("Cannot set property InjectionTest when property FluidLevelTest is already set");
                injectionTestField = value;
                injectionTestFieldSpecified = true;
            }
        }

        private WellTestInjectionTestData injectionTestField; 
        private bool injectionTestFieldSpecified = false; 

        /// <summary>
        /// Data from a fluid level test.
        /// </summary>
        [XmlElement("fluidLevelTest")]
        public WellTestFluidLevelTest FluidLevelTest {
            get {
                return fluidLevelTestField;
            } 
            set { 
                if (productionTestFieldSpecified) throw new Exception("Cannot set property FluidLevelTest when property ProductionTest is already set");
                if (injectionTestFieldSpecified) throw new Exception("Cannot set property FluidLevelTest when property InjectionTest is already set");
                fluidLevelTestField = value;
                fluidLevelTestFieldSpecified = true;
            }
        }

        private WellTestFluidLevelTest fluidLevelTestField; 
        private bool fluidLevelTestFieldSpecified = false; 


        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		/// <summary>
        /// Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell. 
        /// </summary>
        [XmlAttribute("uidWell")]
        public String UidWell { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the endpointQualifiedDateTime xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="endpointQualifiedDateTime", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the endpointQualifiedDateTime xsd type.")]
    public partial class EndpointQualifiedDateTime : Object 
    {
        public EndpointQualifiedDateTime() {}
        public EndpointQualifiedDateTime(DateTime value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The default is "inclusive".
        /// </summary>
        [XmlAttribute("endpoint")]
        private string EndpointSurrogate
        {
            get { return Endpoint.Name; }
            set { Endpoint.Name = value; }
        }

        [XmlIgnore]
        public EndpointQualifier Endpoint {
            get {
                return endpointField;
            } 
            set { 
                endpointField = value;
                this.EndpointSpecified = true;
            }
        }

        private EndpointQualifier endpointField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EndpointSpecified { get; set; }
		
        [XmlText]
        public DateTime Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Within the context of a WITSML Server, this data should duplicate the equivalent information in the well object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellContext", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Within the context of a WITSML Server, this data should duplicate the equivalent information in the well object.")]
    public partial class WellContext : Object 
    {

        /// <summary>
        /// Name of the field in which the well is located.
        /// </summary>
        [XmlElement("field")]
        public NameStruct Field { get; set; }
		/// <summary>
        /// An alias name associated with the well. If the wellName is associated with a naming system then it should be included in this list.
        /// </summary>
        [XmlElement("wellAlias")]
        public List<NameStruct> WellAlias { get; set; }
		/// <summary>
        /// A datum to which elevations and depths are referenced. 
        /// </summary>
        [XmlElement("wellDatum")]
        public List<WellDatum> WellDatum { get; set; }
        /// <summary>
        /// POSC well fluid. The type of fluid being produced from or injected into a well facility. 
        /// </summary>
        [XmlElement("fluidWell")]
        public WellFluid? FluidWell {
            get {
                return fluidWellField;
            } 
            set { 
                fluidWellField = value;
                this.FluidWellSpecified = true;
            }
        }

        private WellFluid? fluidWellField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean FluidWellSpecified { get; set; }
        /// <summary>
        /// POSC well direction. The direction of flow of the fluids in a well facility (generally, injected or produced, or some combination). 
        /// </summary>
        [XmlElement("directionWell")]
        public WellDirection? DirectionWell {
            get {
                return directionWellField;
            } 
            set { 
                directionWellField = value;
                this.DirectionWellSpecified = true;
            }
        }

        private WellDirection? directionWellField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DirectionWellSpecified { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines the vertical datums associated with elevation, vertical depth and measured depth coordinates within the context of a well. 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_wellDatum", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Defines the vertical datums associated with elevation, vertical depth and measured depth coordinates within the context of a well. ")]
    public partial class WellDatum : Object 
    {

        /// <summary>
        /// The human understandable contextual name of the reference datum.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The code value that represents the type of reference datum. This may represent a point on a device (e.g., kelly bushing) or it may represent a vertical reference datum (e.g., mean sea level).
        /// </summary>
        [XmlElement("code")]
        public ElevCodeEnum? Code {
            get {
                return codeField;
            } 
            set { 
                codeField = value;
                this.CodeSpecified = true;
            }
        }

        private ElevCodeEnum? codeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CodeSpecified { get; set; }
        /// <summary>
        /// The name of the vertical reference datum in a particular naming system. This should only be specified if the above 'code' represents some variation of sea level. An optional short name (code) can also be specified. Specifying a well known datum is highly desired if the above code is a variant of sea level because sea level varies over time and space. An example would be to specify a name of 'Caspian Sea' with a code of '5106' in the 'EPSG' naming system.
        /// </summary>
        [XmlElement("datumName")]
        public WellKnownNameStruct DatumName {
            get {
                return datumNameField;
            } 
            set { 
                if (datumCRSFieldSpecified) throw new Exception("Cannot set property DatumName when property DatumCRS is already set");
                datumNameField = value;
                datumNameFieldSpecified = true;
            }
        }

        private WellKnownNameStruct datumNameField; 
        private bool datumNameFieldSpecified = false; 

        /// <summary>
        /// A reference to the coordinateReferenceSystem object representing the vertical reference datum (i.e., this wellDatum). This should only be specified if the above 'code' represents some variation of sea level. 
        /// </summary>
        [XmlElement("datumCRS")]
        public RefNameString DatumCRS {
            get {
                return datumCRSField;
            } 
            set { 
                if (datumNameFieldSpecified) throw new Exception("Cannot set property DatumCRS when property DatumName is already set");
                datumCRSField = value;
                datumCRSFieldSpecified = true;
            }
        }

        private RefNameString datumCRSField; 
        private bool datumCRSFieldSpecified = false; 


		/// <summary>
        /// Since various activities may use different points as measurement datums, it is useful to characterize the point based on its usage. A well reference datum may have more than one such characterization. For example, it may be the datum used by the driller and logger for measuring their depths. Example usage values would be 'permanent','driller', 'logger' 'WRP' (well reference point) and 'SRP' (site reference point).
        /// </summary>
        [XmlElement("kind")]
        public List<String> Kind { get; set; }
        /// <summary>
        /// A pointer to the wellbore that contains the reference datum. This should be specified if a measured depth is given.
        /// </summary>
        [XmlElement("wellbore")]
        public RefWellWellbore Wellbore { get; set; }
        /// <summary>
        /// A pointer to the rig that contains the device used as a reference datum. The rig may be associated with a wellbore in another well (e.g., pattern drilling using a rig on a track).
        /// </summary>
        [XmlElement("rig")]
        public RefWellWellboreRig Rig { get; set; }
        /// <summary>
        /// The gravity based elevation coordinate of this reference datum as measured from another datum. Positive moving upward from the elevation datum. An elevation should be given unless this is a vertical reference datum (e.g., sea level). 
        /// </summary>
        [XmlElement("elevation")]
        public WellElevationCoord Elevation { get; set; }
        /// <summary>
        /// The measured depth coordinate of this reference datum as measured from another datum. The measured depth datum should either be the same as the elevation datum or it should be relatable to the elevation datum through other datums. Positive moving toward the bottomhole from the measured depth datum. This should be given when a local reference is "downhole", such as a kickoff point or ocean bottom template, and the borehole may not be vertical. If a Depth is given then an Elevation should also be given.
        /// </summary>
        [XmlElement("measuredDepth")]
        public MeasuredDepthCoord MeasuredDepth { get; set; }
        /// <summary>
        /// The horizontal location of the point being used as a well datum. This may be used when the point is not directly above or below the well point location. For example, a well being drilled from a platform may have its location at the entrance into the sea floor, while the well datum may be located on the drilling rig. Or the well datum may be a kickoff point, that is not directly under the well surface point. 
        /// </summary>
        [XmlElement("horizontalLocation")]
        public Location HorizontalLocation { get; set; }
        /// <summary>
        /// A contextual description of the well reference datum.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		/// <summary>
        /// True indicates that this is the default reference datum for measured depth coordinates. False or not given indicates that this is not the default reference datum. Measured depth coordinates that do not specify a datum reference should be assumed to be measured relative to this default reference datum. Only one reference datum may be designated as the default measured depth datum for each well. Values are "true" (or "1") and "false" ( or "0").
        /// </summary>
        [XmlAttribute("defaultMeasuredDepth")]
        public Boolean DefaultMeasuredDepth {
            get {
                return defaultMeasuredDepthField;
            } 
            set { 
                defaultMeasuredDepthField = value;
                this.DefaultMeasuredDepthSpecified = true;
            }
        }

        private Boolean defaultMeasuredDepthField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DefaultMeasuredDepthSpecified { get; set; }
		/// <summary>
        /// True indicates that this is the default reference datum for vertical depth coordinates. False or not given indicates that this is not the default reference datum. Vertical depth coordinates that do not specify a datum reference should be assumed to be measured relative to the default reference datum. Only one reference datum may be designated as the default vertical depth datum for each well. Values are "true" (or "1") and "false" ( or "0").
        /// </summary>
        [XmlAttribute("defaultVerticalDepth")]
        public Boolean DefaultVerticalDepth {
            get {
                return defaultVerticalDepthField;
            } 
            set { 
                defaultVerticalDepthField = value;
                this.DefaultVerticalDepthSpecified = true;
            }
        }

        private Boolean defaultVerticalDepthField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DefaultVerticalDepthSpecified { get; set; }
		/// <summary>
        /// True indicates that this is the default reference datum for elevation coordinates. False or not given indicates that this is not the default reference datum. Elevation coordinates that do not specify a datum reference should be assumed to be measured relative to the default reference datum. Only one reference datum may be designated as the default elevation datum for each well. Values are "true" (or "1") and "false" ( or "0").
        /// </summary>
        [XmlAttribute("defaultElevation")]
        public Boolean DefaultElevation {
            get {
                return defaultElevationField;
            } 
            set { 
                defaultElevationField = value;
                this.DefaultElevationSpecified = true;
            }
        }

        private Boolean defaultElevationField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DefaultElevationSpecified { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the wellKnownNameStruct xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="wellKnownNameStruct", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the wellKnownNameStruct xsd type.")]
    public partial class WellKnownNameStruct : Object 
    {
        public WellKnownNameStruct() {}
        public WellKnownNameStruct(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The naming system within the name is unique.
        /// </summary>
        [XmlAttribute("namingSystem")]
        public String NamingSystem { get; set; }
		/// <summary>
        /// A unique (short) code associated with the name.
        /// </summary>
        [XmlAttribute("code")]
        public String Code { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Data that represents a foreign key to a wellbore. The wellbore may be defined within the context of another well.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_refWellWellbore", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Data that represents a foreign key to a wellbore. The wellbore may be defined within the context of another well.")]
    public partial class RefWellWellbore : Object 
    {

        /// <summary>
        /// A pointer the wellbore with which there is a relationship.
        /// </summary>
        [XmlElement("wellboreReference")]
        public RefNameString WellboreReference { get; set; }
        /// <summary>
        /// A pointer to the well that contains the wellboreReference. This is not needed unless the referenced wellbore is outside the context of a common parent well.
        /// </summary>
        [XmlElement("wellParent")]
        public RefNameString WellPluggedAndAbandonedrent { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A reference to a rig within a wellbore. The wellbore may be defined within the context of another well. This value represents a foreign key from one node to another.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_refWellWellboreRig", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A reference to a rig within a wellbore. The wellbore may be defined within the context of another well. This value represents a foreign key from one node to another.")]
    public partial class RefWellWellboreRig : Object 
    {

        /// <summary>
        /// A pointer to the rig with which there is a relationship.
        /// </summary>
        [XmlElement("rigReference")]
        public RefNameString RigReference { get; set; }
        /// <summary>
        /// A pointer to the wellbore that contains the rigReference. This is not needed unless the referenced rig is outside the context of a common parent wellbore.
        /// </summary>
        [XmlElement("wellboreParent")]
        public RefNameString WellborePluggedAndAbandonedrent { get; set; }
        /// <summary>
        /// A pointer to the well that contains the wellboreParent. This is not needed unless the referenced wellbore is outside the context of a common parent well.
        /// </summary>
        [XmlElement("wellParent")]
        public RefNameString WellPluggedAndAbandonedrent { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML Location Component Schema This is a location that is expressed in terms of 2D coordinates. In order that the location be understood, the coordinate reference system (CRS) must be known. The survey location is given by a pair of tagged values. The pairs may be: (1) latitude/longitude, (2) easting/northing, (3) westing/southing, (4) projectedX/projectedY, or (5) localX/localY. The appropriate pair must be chosen for the data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_location", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML Location Component Schema This is a location that is expressed in terms of 2D coordinates. In order that the location be understood, the coordinate reference system (CRS) must be known. The survey location is given by a pair of tagged values. The pairs may be: (1) latitude/longitude, (2) easting/northing, (3) westing/southing, (4) projectedX/projectedY, or (5) localX/localY. The appropriate pair must be chosen for the data.")]
    public partial class Location : Object 
    {

        /// <summary>
        /// A pointer to the wellCRS that defines the CRS for the coordinates. While optional, it is strongly recommended that this be specified.
        /// </summary>
        [XmlElement("wellCRS")]
        public RefNameString WellCRS { get; set; }
        /// <summary>
        /// The latitude with north being positive. If you set this property, you must also set Longitude.
        /// </summary>
        [XmlElement("latitude")]
        public PlaneAngleMeasure Latitude {
            get {
                return latitudeField;
            } 
            set { 
                if (westingFieldSpecified) throw new Exception("Cannot set property Latitude when property Westing is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property Latitude when property ProjectedX is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property Latitude when property Southing is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property Latitude when property Northing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property Latitude when property ProjectedY is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property Latitude when property Easting is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property Latitude when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property Latitude when property LocalY is already set");
                latitudeField = value;
                latitudeFieldSpecified = true;
            }
        }

        private PlaneAngleMeasure latitudeField; 
        private bool latitudeFieldSpecified = false; 

        /// <summary>
        /// The longitude with east being positive. If you set this property, you must also set Latitude.
        /// </summary>
        [XmlElement("longitude")]
        public PlaneAngleMeasure Longitude {
            get {
                return longitudeField;
            } 
            set { 
                if (westingFieldSpecified) throw new Exception("Cannot set property Longitude when property Westing is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property Longitude when property ProjectedX is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property Longitude when property Southing is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property Longitude when property Northing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property Longitude when property ProjectedY is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property Longitude when property Easting is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property Longitude when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property Longitude when property LocalY is already set");
                longitudeField = value;
                longitudeFieldSpecified = true;
            }
        }

        private PlaneAngleMeasure longitudeField; 
        private bool longitudeFieldSpecified = false; 

        /// <summary>
        /// The projected coordinate with east being positive. This is the most common type of projected coordinates. UTM coordinates are expressed in Easting and Northing. If you set this property, you must also set Northing.
        /// </summary>
        [XmlElement("easting")]
        public LengthMeasure Easting {
            get {
                return eastingField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property Easting when property Longitude is already set");
                if (westingFieldSpecified) throw new Exception("Cannot set property Easting when property Westing is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property Easting when property ProjectedX is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property Easting when property Southing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property Easting when property ProjectedY is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property Easting when property Latitude is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property Easting when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property Easting when property LocalY is already set");
                eastingField = value;
                eastingFieldSpecified = true;
            }
        }

        private LengthMeasure eastingField; 
        private bool eastingFieldSpecified = false; 

        /// <summary>
        /// The projected coordinate with north being positive. This is the most common type of projected coordinates. UTM coordinates are expressed in Easting and Northing. If you set this property, you must also set Easting.
        /// </summary>
        [XmlElement("northing")]
        public LengthMeasure Northing {
            get {
                return northingField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property Northing when property Longitude is already set");
                if (westingFieldSpecified) throw new Exception("Cannot set property Northing when property Westing is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property Northing when property ProjectedX is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property Northing when property Southing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property Northing when property ProjectedY is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property Northing when property Latitude is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property Northing when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property Northing when property LocalY is already set");
                northingField = value;
                northingFieldSpecified = true;
            }
        }

        private LengthMeasure northingField; 
        private bool northingFieldSpecified = false; 

        /// <summary>
        /// The projected coordinate with west being positive. The positive directions are reversed from the usual Easting and Northing values. These values are generally located in the southern hemisphere, most notably in South Africa and Australia. If you set this property, you must also set Southing.
        /// </summary>
        [XmlElement("westing")]
        public LengthMeasure Westing {
            get {
                return westingField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property Westing when property Longitude is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property Westing when property ProjectedX is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property Westing when property Northing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property Westing when property ProjectedY is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property Westing when property Easting is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property Westing when property Latitude is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property Westing when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property Westing when property LocalY is already set");
                westingField = value;
                westingFieldSpecified = true;
            }
        }

        private LengthMeasure westingField; 
        private bool westingFieldSpecified = false; 

        /// <summary>
        /// The projected coordinate with south being positive. The positive directions are reversed from the usual Easting and Northing values. These values are generally located in the southern hemisphere, most notably in South Africa and Australia. If you set this property, you must also set Westing.
        /// </summary>
        [XmlElement("southing")]
        public LengthMeasure Southing {
            get {
                return southingField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property Southing when property Longitude is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property Southing when property ProjectedX is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property Southing when property Northing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property Southing when property ProjectedY is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property Southing when property Easting is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property Southing when property Latitude is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property Southing when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property Southing when property LocalY is already set");
                southingField = value;
                southingFieldSpecified = true;
            }
        }

        private LengthMeasure southingField; 
        private bool southingFieldSpecified = false; 

        /// <summary>
        /// The projected X coordinate with the positive direction unknown. ProjectedX and ProjectedY are used when it is not known what the meaning of the coordinates is. If the meaning is known, the Easting/Northing or Westing/Southing should be used. Use of this pair implies a lack of knowledge on the part of the sender. If you set this property, you must also set ProjectedY.
        /// </summary>
        [XmlElement("projectedX")]
        public LengthMeasure ProjectedX {
            get {
                return projectedXField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property ProjectedX when property Longitude is already set");
                if (westingFieldSpecified) throw new Exception("Cannot set property ProjectedX when property Westing is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property ProjectedX when property Southing is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property ProjectedX when property Northing is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property ProjectedX when property Easting is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property ProjectedX when property Latitude is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property ProjectedX when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property ProjectedX when property LocalY is already set");
                projectedXField = value;
                projectedXFieldSpecified = true;
            }
        }

        private LengthMeasure projectedXField; 
        private bool projectedXFieldSpecified = false; 

        /// <summary>
        /// The projected Y coordinate with the positive direction unknown. ProjectedX and ProjectedY are used when it is not known what the meaning of the coordinates is. If the meaning is known, the Easting/Northing or Westing/Southing should be used. Use of this pair implies a lack of knowledge on the part of the sender. If you set this property, you must also set ProjectedX.
        /// </summary>
        [XmlElement("projectedY")]
        public LengthMeasure ProjectedY {
            get {
                return projectedYField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property ProjectedY when property Longitude is already set");
                if (westingFieldSpecified) throw new Exception("Cannot set property ProjectedY when property Westing is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property ProjectedY when property Southing is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property ProjectedY when property Northing is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property ProjectedY when property Easting is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property ProjectedY when property Latitude is already set");
                if (localXFieldSpecified) throw new Exception("Cannot set property ProjectedY when property LocalX is already set");
                if (localYFieldSpecified) throw new Exception("Cannot set property ProjectedY when property LocalY is already set");
                projectedYField = value;
                projectedYFieldSpecified = true;
            }
        }

        private LengthMeasure projectedYField; 
        private bool projectedYFieldSpecified = false; 

        /// <summary>
        /// The local (engineering) X coordinate. The CRS will define the orientation of the axis. If you set this property, you must also set LocalY.
        /// </summary>
        [XmlElement("localX")]
        public LengthMeasure LocalX {
            get {
                return localXField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property LocalX when property Longitude is already set");
                if (westingFieldSpecified) throw new Exception("Cannot set property LocalX when property Westing is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property LocalX when property ProjectedX is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property LocalX when property Southing is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property LocalX when property Northing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property LocalX when property ProjectedY is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property LocalX when property Easting is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property LocalX when property Latitude is already set");
                localXField = value;
                localXFieldSpecified = true;
            }
        }

        private LengthMeasure localXField; 
        private bool localXFieldSpecified = false; 

        /// <summary>
        /// The local (engineering) Y coordinate. The CRS will define the orientation of the axis. If you set this property, you must also set LocalX.
        /// </summary>
        [XmlElement("localY")]
        public LengthMeasure LocalY {
            get {
                return localYField;
            } 
            set { 
                if (longitudeFieldSpecified) throw new Exception("Cannot set property LocalY when property Longitude is already set");
                if (westingFieldSpecified) throw new Exception("Cannot set property LocalY when property Westing is already set");
                if (projectedXFieldSpecified) throw new Exception("Cannot set property LocalY when property ProjectedX is already set");
                if (southingFieldSpecified) throw new Exception("Cannot set property LocalY when property Southing is already set");
                if (northingFieldSpecified) throw new Exception("Cannot set property LocalY when property Northing is already set");
                if (projectedYFieldSpecified) throw new Exception("Cannot set property LocalY when property ProjectedY is already set");
                if (eastingFieldSpecified) throw new Exception("Cannot set property LocalY when property Easting is already set");
                if (latitudeFieldSpecified) throw new Exception("Cannot set property LocalY when property Latitude is already set");
                localYField = value;
                localYFieldSpecified = true;
            }
        }

        private LengthMeasure localYField; 
        private bool localYFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType> ItemsElementName { get; set; }
        /// <summary>
        /// Flag indicating (if "true" or "1") that this pair of values was the original data given for the location. If the pair of values was calculated from an original pair of values, this flag should be "false" (or "0"), or not present.
        /// </summary>
        [XmlElement("original")]
        public Boolean? Original {
            get {
                return originalField;
            } 
            set { 
                originalField = value;
                this.OriginalSpecified = true;
            }
        }

        private Boolean? originalField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean OriginalSpecified { get; set; }
        /// <summary>
        /// A Comment, generally given to help the reader interpret the coordinates if the CRS and the chosen pair do not make them clear.
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_extensionNameValue", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Extension values Schema. The intent is to allow standard WITSML named extensions without having to modify the schema. A client or server can ignore any name that it does not recognize but certain meta data is required in order to allow generic clients or servers to process the value.")]
    public partial class ExtensionNameValue : Object 
    {

        /// <summary>
        /// The name of the extension. Each standard name should document the expected measure class. Each standard name should document the expected maximum size. For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the WITSML SIG Technical Team before use.
        /// </summary>
        [XmlElement("name")]
        public ExtensionName Name { get; set; }
        /// <summary>
        /// The value of the extension. This may also include a uom attribute. The content should conform to constraints defined by the data type.
        /// </summary>
        [XmlElement("value")]
        public Extensionvalue Value { get; set; }
        /// <summary>
        /// The underlying XML type of the value.
        /// </summary>
        [XmlElement("dataType")]
        public PrimitiveType? DataType { get; set; }
        /// <summary>
        /// The date-time associated with the value.
        /// </summary>
        [XmlElement("dTim")]
        public DateTime? DateTime {
            get {
                return dTimField;
            } 
            set { 
                dTimField = value;
                this.DateTimeSpecified = true;
            }
        }

        private DateTime? dTimField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified { get; set; }
        /// <summary>
        /// The measured depth associated with the value.
        /// </summary>
        [XmlElement("md")]
        public MeasuredDepthCoord MD { get; set; }
        /// <summary>
        /// Indexes things with the same name. That is, 1 indicates the first one, 2 incidates the second one, etc.
        /// </summary>
        [XmlElement("index")]
        public Int16? Index {
            get {
                return indexField;
            } 
            set { 
                indexField = value;
                this.IndexSpecified = true;
            }
        }

        private Int16? indexField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IndexSpecified { get; set; }
        /// <summary>
        /// The kind of the measure. For example, "length". This should be specified if the value requires a unit of measure.
        /// </summary>
        [XmlElement("measureClass")]
        public MeasureClass MeasureClass {
            get {
                return measureClassField;
            } 
            set { 
                measureClassField = value;
                this.MeasureClassSpecified = true;
            }
        }

        private MeasureClass measureClassField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MeasureClassSpecified { get; set; }
        /// <summary>
        /// A textual description of the extension.
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="extensionvalue", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the extensionvalue xsd type.")]
    public partial class Extensionvalue : Object 
    {
        public Extensionvalue() {}
        public Extensionvalue(String value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure for the value. This value must conform to the values allowed by a measure class.
        /// </summary>
        [XmlAttribute("uom")]
        public String Uom { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_commonData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description(" WITSML - Common Data Component Schema ")]
    public partial class CommonData : Object 
    {

        /// <summary>
        /// An identifier to indicate the data originator. This identifies the server that originally created the object and thus most of the uids in the object (but not necessarily the uids of the parents). This is typically a url. 
        /// </summary>
        [XmlElement("sourceName")]
        public String SourceName { get; set; }
        /// <summary>
        /// When the data was created at the persistent data store. In a query template, a specified value will be interpreted by the server as a request for dTimCreation values that are greater-than the specified value. 
        /// </summary>
        [XmlElement("dTimCreation")]
        public DateTime? DateTimeCreation {
            get {
                return dTimCreationField;
            } 
            set { 
                dTimCreationField = value;
                this.DateTimeCreationSpecified = true;
            }
        }

        private DateTime? dTimCreationField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeCreationSpecified { get; set; }
        /// <summary>
        /// Last change of any element of the data at the persistent data store. The change time is not updated for a growing object while it is growing. In a query template, a specified value will be interpreted by the server as a request for dTimLastChange values that are greater-than the specified value. The dTimLastChange value may be changed by a client (user). 
        /// </summary>
        [XmlElement("dTimLastChange")]
        public DateTime? DateTimeLastChange {
            get {
                return dTimLastChangeField;
            } 
            set { 
                dTimLastChangeField = value;
                this.DateTimeLastChangeSpecified = true;
            }
        }

        private DateTime? dTimLastChangeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeLastChangeSpecified { get; set; }
        /// <summary>
        /// The item state for the data object. 
        /// </summary>
        [XmlElement("itemState")]
        public ItemState? ItemState {
            get {
                return itemStateField;
            } 
            set { 
                itemStateField = value;
                this.ItemStateSpecified = true;
            }
        }

        private ItemState? itemStateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ItemStateSpecified { get; set; }
        /// <summary>
        /// The category of the service related to the creation of the object. For example, "mud log service", "cement service", "LWD service", "rig service", "drilling service". REALTIME STORE UNIQUE KEY: When accessed via the Store Interface, for each instance of realtime, the combination of "uidWell", "uidWellbore", "idSub" and commonData's "serviceCategory" must be unique. That is, the Store Interface will only retain one realtime for a particular wellbore, subscription and service with the REALTIME STORE UNIQUE KEY being the object selector.
        /// </summary>
        [XmlElement("serviceCategory")]
        public String ServiceCategory { get; set; }
        /// <summary>
        /// Comments and remarks. 
        /// </summary>
        [XmlElement("comments")]
        public String Comments { get; set; }
		/// <summary>
        /// The local time zone of the original acquisition date-time values. It is the deviation in hours and minutes from UTC. The first occurrence should be the actual local time zone at the start of acquisition and may represent a seasonally adjusted value such as daylight savings. The dTim attribute must be populated in the second and subsequent occurrences if the local time zone changes during acquisition. This knowledge is required because the original time zone in a dateTime value may be lost when software converts to a different time zone.
        /// </summary>
        [XmlElement("acquisitionTimeZone")]
        public List<TimestampedTimeZone> AcquisitionTimeZone { get; set; }
        /// <summary>
        /// Extensions to the schema using an xsd:any construct.
        /// </summary>
        [XmlElement("extensionAny")]
        public ExtensionAny ExtensionAny { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="timestampedTimeZone", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the timestampedTimeZone xsd type.")]
    public partial class TimestampedTimeZone : Object 
    {
        public TimestampedTimeZone() {}
        public TimestampedTimeZone(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The date and time when this local time zone became active. This value must be defined on the second and subsequent occurrences.
        /// </summary>
        [XmlAttribute("dTim")]
        public DateTime DateTime {
            get {
                return dTimField;
            } 
            set { 
                dTimField = value;
                this.DateTimeSpecified = true;
            }
        }

        private DateTime dTimField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_extensionAny", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Extension Schema. The intent is to allow standard WITSML schema extensions which will validate in older clients or servers. A client or server can ignore any schema that it does not recognize. New versions will modify specific elements to replace this type with a type that adds new elements, including another element with this type.")]
    public partial class ExtensionAny : Object 
    {

        
        [XmlElement("Any")]
        public List<XmlElement> Any { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_customData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_customData xsd type.")]
    public partial class CustomData : Object 
    {

        
        [XmlElement("Any")]
        public List<XmlElement> Any { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the endpointQuantity xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="endpointQuantity", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the endpointQuantity xsd type.")]
    public partial class EndpointQuantity : Object 
    {
        public EndpointQuantity() {}
        public EndpointQuantity(Double value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// Defines the semantics (inclusive or exclusive) of the endpoint within the context of the interval.
        /// </summary>
        [XmlAttribute("endpoint")]
        private string EndpointSurrogate
        {
            get { return Endpoint.Name; }
            set { Endpoint.Name = value; }
        }

        [XmlIgnore]
        public EndpointQualifierInterval Endpoint { get; set; }
		
        [XmlText]
        public Double Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines a value threshold window and the cumulative time duration that the data was within that window.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_timeSeriesThreshold", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Defines a value threshold window and the cumulative time duration that the data was within that window.")]
    public partial class TimeSeriesThreshold : Object 
    {

        /// <summary>
        /// The lower bound of the threshold for testing whether values are within a specific range. Element "unit" defines the unit of measure of this value. At least one of minimumValue and maximumValue must be specified. The thresholdMinimum must be less than thresholdMaximum. If thresholdMinimum is not specified then the minimum shall be assumed to be minus infinity.
        /// </summary>
        [XmlElement("thresholdMinimum")]
        public EndpointQuantity ThresholdMinimum { get; set; }
        /// <summary>
        /// The upper bound of the threshold for testing whether values are within a specific range. Element "unit" defines the unit of measure of this value. At least one of minimumValue and maximumValue must be specified. The thresholdMaximum must be greater than thresholdMinimum. If thresholdMaximum is not specified then the maximum shall be assumed to be plus infinity.
        /// </summary>
        [XmlElement("thresholdMaximum")]
        public EndpointQuantity ThresholdMaximum { get; set; }
        /// <summary>
        /// The sum of the time intervals over the range of dTimMin to dTimMax during which the values were within the specified threshold range.
        /// </summary>
        [XmlElement("duration")]
        public TimeMeasure Duration { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the endpointDateTime xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="endpointDateTime", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the endpointDateTime xsd type.")]
    public partial class EndpointDateTime : Object 
    {
        public EndpointDateTime() {}
        public EndpointDateTime(DateTime value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// Defines the semantics (inclusive or exclusive) of the endpoint within the context of the interval.
        /// </summary>
        [XmlAttribute("endpoint")]
        private string EndpointSurrogate
        {
            get { return Endpoint.Name; }
            set { Endpoint.Name = value; }
        }

        [XmlIgnore]
        public EndpointQualifierInterval Endpoint { get; set; }
		
        [XmlText]
        public DateTime Value { get; set; }
    }
    }

    /// <summary>
    /// The non-contextual content of WITSML statistics about a range of time series data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_timeSeriesStatistic", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The non-contextual content of WITSML statistics about a range of time series data.")]
    public partial class TimeSeriesStatistic : Object 
    {

        /// <summary>
        /// Human recognizable context for the time series.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
		/// <summary>
        /// A keyword value pair which characterizes the underlying nature of this value. The key value may provide part of the unique identity of an instance of a concept or it may characterize the underlying concept. The key value will be defined within the specified keyword naming system. This is essentially a classification of the data in the specified system (keyword).
        /// </summary>
        [XmlElement("key")]
        public List<KeywordValueStruct> Key { get; set; }
        /// <summary>
        /// If the time series is a measure then this specifies the unit of measure. The unit acronym must be chosen from the list that is valid for the measure class. If this is specified then the measure class must be specified.
        /// </summary>
        [XmlElement("unit")]
        public String Unit { get; set; }
        /// <summary>
        /// Defines the type of measure that the time series represents. If this is specified then unit must be specified. This may be redundant to some information in the keys but it is important for allowing an application to understand the nature of a measure value even if it does not understand all of the underlying nature.
        /// </summary>
        [XmlElement("measureClass")]
        public MeasureClass MeasureClass {
            get {
                return measureClassField;
            } 
            set { 
                measureClassField = value;
                this.MeasureClassSpecified = true;
            }
        }

        private MeasureClass measureClassField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MeasureClassSpecified { get; set; }
        /// <summary>
        /// A comment about the time series.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
        /// <summary>
        /// The lower bound of the analyzed time range. Only data within the range was included in the analysis. The endpoint attribute specifies whether the data was inclusive or exclusive of this point.
        /// </summary>
        [XmlElement("dTimMin")]
        public EndpointDateTime DateTimeMin { get; set; }
        /// <summary>
        /// The upper bound of the analyzed time range. Only data within the range was included in the analysis. The endpoint attribute specifies whether the data was inclusive or exclusive of this point.
        /// </summary>
        [XmlElement("dTimMax")]
        public EndpointDateTime DateTimeMax { get; set; }
        /// <summary>
        /// The minimum value within the time range of dTimMin to dTimMax. Element "unit" defines the unit of measure of this value.
        /// </summary>
        [XmlElement("minimum")]
        public Double? Minimum {
            get {
                return minimumField;
            } 
            set { 
                minimumField = value;
                this.MinimumSpecified = true;
            }
        }

        private Double? minimumField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MinimumSpecified { get; set; }
        /// <summary>
        /// The maximum value within the time range of dTimMin to dTimMax. Element "unit" defines the unit of measure of this value.
        /// </summary>
        [XmlElement("maximum")]
        public Double? Maximum {
            get {
                return maximumField;
            } 
            set { 
                maximumField = value;
                this.MaximumSpecified = true;
            }
        }

        private Double? maximumField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MaximumSpecified { get; set; }
        /// <summary>
        /// The sum of all values within the time range of dTimMin to dTimMax. Element "unit" defines the unit of measure of this value.
        /// </summary>
        [XmlElement("sum")]
        public Double? Sum {
            get {
                return sumField;
            } 
            set { 
                sumField = value;
                this.SumSpecified = true;
            }
        }

        private Double? sumField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SumSpecified { get; set; }
        /// <summary>
        /// The arithmetic mean (sum divided by count) of all values within the time range of dTimMin to dTimMax. Element "unit" defines the unit of measure of this value.
        /// </summary>
        [XmlElement("mean")]
        public Double? Mean {
            get {
                return meanField;
            } 
            set { 
                meanField = value;
                this.MeanSpecified = true;
            }
        }

        private Double? meanField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MeanSpecified { get; set; }
        /// <summary>
        /// The median value of all values within the time range of dTimMin to dTimMax. Element "unit" defines the unit of measure of this value.
        /// </summary>
        [XmlElement("median")]
        public Double? Median {
            get {
                return medianField;
            } 
            set { 
                medianField = value;
                this.MedianSpecified = true;
            }
        }

        private Double? medianField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MedianSpecified { get; set; }
        /// <summary>
        /// The standard deviation of all values within the time range of dTimMin to dTimMax. Element "unit" defines the unit of measure of this value.
        /// </summary>
        [XmlElement("standardDeviation")]
        public Double? StandardDeviation {
            get {
                return standardDeviationField;
            } 
            set { 
                standardDeviationField = value;
                this.StandardDeviationSpecified = true;
            }
        }

        private Double? standardDeviationField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StandardDeviationSpecified { get; set; }
        /// <summary>
        /// Defines a value threshold window and the time duration where values (within the time range of dTimMin to dTimMax) were within that window.
        /// </summary>
        [XmlElement("timeAtThreshold")]
        public TimeSeriesThreshold TimeAtThreshold { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the keywordValueStruct xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="keywordValueStruct", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the keywordValueStruct xsd type.")]
    public partial class KeywordValueStruct : Object 
    {
        public KeywordValueStruct() {}
        public KeywordValueStruct(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The keyword within which the value is unique. The concept of a keyword is very close to the concept of a classification system.
        /// </summary>
        [XmlAttribute("keyword")]
        private string KeywordSurrogate
        {
            get { return Keyword.Name; }
            set { Keyword.Name = value; }
        }

        [XmlIgnore]
        public TimeSeriesKeyword Keyword { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the timeSeriesStringSample xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="timeSeriesStringSample", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the timeSeriesStringSample xsd type.")]
    public partial class TimeSeriesStringSample : Object 
    {
        public TimeSeriesStringSample() {}
        public TimeSeriesStringSample(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The date and time at which the value applies. If no time is specified then the value is static and only one sample can be defined. Either dTime or value or both must be specified.
        /// </summary>
        [XmlAttribute("dTim")]
        public DateTime DateTime {
            get {
                return dTimField;
            } 
            set { 
                dTimField = value;
                this.DateTimeSpecified = true;
            }
        }

        private DateTime dTimField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified { get; set; }
		/// <summary>
        /// An indicator of the quality of the value.
        /// </summary>
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the timeSeriesDoubleSample xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="timeSeriesDoubleSample", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the timeSeriesDoubleSample xsd type.")]
    public partial class TimeSeriesDoubleSample : Object 
    {
        public TimeSeriesDoubleSample() {}
        public TimeSeriesDoubleSample(Double value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The date and time at which the value applies. If no time is specified then the value is static and only one sample can be defined. Either dTime or value or both must be specified.
        /// </summary>
        [XmlAttribute("dTim")]
        public DateTime DateTime {
            get {
                return dTimField;
            } 
            set { 
                dTimField = value;
                this.DateTimeSpecified = true;
            }
        }

        private DateTime dTimField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified { get; set; }
		/// <summary>
        /// An indicator of the quality of the value.
        /// </summary>
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlText]
        public Double Value { get; set; }
    }
    }

    /// <summary>
    /// The non-contextual content of a PRODML Time Series Data object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_timeSeriesData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The non-contextual content of a PRODML Time Series Data object.")]
    public partial class TimeSeriesData : Object 
    {

        /// <summary>
        /// Human recognizable context for the time series. 
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
		/// <summary>
        /// A keyword value pair which characterizes the underlying nature of this value. The key value may provide part of the unique identity of an instance of a concept or it may characterize the underlying concept. The key value will be defined within the specified keyword naming system. This is essentially a classification of the data in the specified system (keyword).
        /// </summary>
        [XmlElement("key")]
        public List<KeywordValueStruct> Key { get; set; }
        /// <summary>
        /// If the time series is a measure then this specifies the unit of measure. The unit acronym must be chosen from the list that is valid for the measure class. If this is specified then the measure class must be specified.
        /// </summary>
        [XmlElement("unit")]
        public String Unit { get; set; }
        /// <summary>
        /// Defines the type of measure that the time series represents. If this is specified then unit must be specified. This may be redundant to some information in the keys but it is important for allowing an application to understand the nature of a measure value even if it does not understand all of the underlying nature.
        /// </summary>
        [XmlElement("measureClass")]
        public MeasureClass MeasureClass {
            get {
                return measureClassField;
            } 
            set { 
                measureClassField = value;
                this.MeasureClassSpecified = true;
            }
        }

        private MeasureClass measureClassField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MeasureClassSpecified { get; set; }
        /// <summary>
        /// A comment about the time series.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
        /// <summary>
        /// A single string value in the time series.
        /// </summary>
        [XmlElement("stringValue")]
        public TimeSeriesStringSample StringValue {
            get {
                return stringValueField;
            } 
            set { 
                if (doubleValueFieldSpecified) throw new Exception("Cannot set property StringValue when property DoubleValue is already set");
                stringValueField = value;
                stringValueFieldSpecified = true;
            }
        }

        private TimeSeriesStringSample stringValueField; 
        private bool stringValueFieldSpecified = false; 

        /// <summary>
        /// A single double value in the time series.
        /// </summary>
        [XmlElement("doubleValue")]
        public TimeSeriesDoubleSample DoubleValue {
            get {
                return doubleValueField;
            } 
            set { 
                if (stringValueFieldSpecified) throw new Exception("Cannot set property DoubleValue when property StringValue is already set");
                doubleValueField = value;
                doubleValueFieldSpecified = true;
            }
        }

        private TimeSeriesDoubleSample doubleValueField; 
        private bool doubleValueFieldSpecified = false; 


        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Captures information about an event related to a product balance.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeBalanceEvent", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Captures information about an event related to a product balance.")]
    public partial class ProductVolumeBalanceEvent : Object 
    {

		/// <summary>
        /// The date of the event.
        /// </summary>
        [XmlElement("")]
        public DateTime? Date { get; set; }
        /// <summary>
        /// The kind of event.
        /// </summary>
        [XmlElement("kind")]
        public BalanceEventKind Kind { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume Balance Detail Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeBalanceDetail", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume Balance Detail Schema.")]
    public partial class ProductVolumeBalanceDetail : Object 
    {

        /// <summary>
        /// A pointer to the business unit which owns the product.
        /// </summary>
        [XmlElement("owner")]
        public RefNameString Owner { get; set; }
        /// <summary>
        /// Points to the business unit from which the product originated. 
        /// </summary>
        [XmlElement("sourceUnit")]
        public RefNameString SourceUnit { get; set; }
        /// <summary>
        /// The owner's share of the product.
        /// </summary>
        [XmlElement("share")]
        public VolumePerVolumeMeasurePercent Share { get; set; }
        /// <summary>
        /// An account identifier for the balance.
        /// </summary>
        [XmlElement("accountNumber")]
        public String AccountNumber { get; set; }
		/// <summary>
        /// A dated event related to the balance.
        /// </summary>
        [XmlElement("event")]
        public List<ProductVolumeBalanceEvent> Event { get; set; }
		/// <summary>
        /// The volume of the fluid, possibly corrected to specific conditions of temperature and pressure. Different volumes may be defined at different conditions but they should all represent the same mass of material.
        /// </summary>
        [XmlElement("volumeValue")]
        public List<VolumeValue> VolumeValue { get; set; }
		/// <summary>
        /// A pointer to a fluid sample analysis result object that is relevant to the balance. This sample may have been acquired previous to or after this period and is used for determining the allocated characteristics.
        /// </summary>
        [XmlElement("sampleAnalysisResult")]
        public List<RefNameString> SampleAnalysisResult { get; set; }
		/// <summary>
        /// The relative amount of a component product in the product.
        /// </summary>
        [XmlElement("componentContent")]
        public List<ProductVolumeComponentContent> ComponentContent { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A possibly temperature and pressure corrected volume value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_volumeValue", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A possibly temperature and pressure corrected volume value.")]
    public partial class VolumeValue : Object 
    {

        /// <summary>
        /// The volume of the product. If the 'status' attribute is absent and the value is not "NaN", the data value can be assumed to be good with no restrictions. A value of "NaN" should be interpreted as null and should be not be given unless a status is also specified to explain why it is null.
        /// </summary>
        [XmlElement("volume")]
        public VolumeQualifiedMeasure Volume { get; set; }
        /// <summary>
        /// The amount of heat which would be released by the complete combustion in air of the above volume of product. This is considered to be a condition of measurement (i.e., the volume may have been converted to this condition).
        /// </summary>
        [XmlElement("grossCalorificValue")]
        public ModulusOfCompressionMeasure GrossCAlorificValue { get; set; }
        /// <summary>
        /// The temperature to which the volume has been corrected. If given, then a pressure must also be given. Common standard temperatures are: 0 degC, 15 degC, 60 degF. If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the productVolume root. If you set this property, you must also set Pres.
        /// </summary>
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp {
            get {
                return tempField;
            } 
            set { 
                if (standardTempPresFieldSpecified) throw new Exception("Cannot set property Temp when property StandardTempPres is already set");
                tempField = value;
                tempFieldSpecified = true;
            }
        }

        private ThermodynamicTemperatureMeasure tempField; 
        private bool tempFieldSpecified = false; 

        /// <summary>
        /// The pressure to which the volume has been corrected. If given, then a temperature must also be given. Common standard pressures are: 1 atm and 14.696 psi (which are equivalent). If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the productVolume root. If you set this property, you must also set Temp.
        /// </summary>
        [XmlElement("pres")]
        public PressureMeasure Pres {
            get {
                return presField;
            } 
            set { 
                if (standardTempPresFieldSpecified) throw new Exception("Cannot set property Pres when property StandardTempPres is already set");
                presField = value;
                presFieldSpecified = true;
            }
        }

        private PressureMeasure presField; 
        private bool presFieldSpecified = false; 

        /// <summary>
        /// Defines the standard temperature and pressure to which the volume has been corrected. If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the procuctVolume root.
        /// </summary>
        [XmlElement("standardTempPres")]
        public StandardCondition StandardTempPres {
            get {
                return standardTempPresField;
            } 
            set { 
                if (presFieldSpecified) throw new Exception("Cannot set property StandardTempPres when property Pres is already set");
                if (tempFieldSpecified) throw new Exception("Cannot set property StandardTempPres when property Temp is already set");
                standardTempPresField = value;
                standardTempPresFieldSpecified = true;
            }
        }

        private StandardCondition standardTempPresField; 
        private bool standardTempPresFieldSpecified = false; 


		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume Component Content Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeComponentContent", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume Component Content Component Schema.")]
    public partial class ProductVolumeComponentContent : Object 
    {

        /// <summary>
        /// The type of product whose relative content is being described. This should be a specific component (e.g., water) rather than a phase (e.g., aqueous).
        /// </summary>
        [XmlElement("kind")]
        public ReportingProduct Kind { get; set; }
        /// <summary>
        /// The type of product to which the product is being compared. If not given then the product is being compared against the overall flow stream.
        /// </summary>
        [XmlElement("referenceKind")]
        public ReportingProduct ReferenceKind {
            get {
                return referenceKindField;
            } 
            set { 
                referenceKindField = value;
                this.ReferenceKindSpecified = true;
            }
        }

        private ReportingProduct referenceKindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ReferenceKindSpecified { get; set; }
        
        [XmlElement("gor")]
        public VolumePerVolumeMeasure Gor { get; set; }
        
        [XmlElement("gorMTD")]
        public VolumePerVolumeMeasure GorMTD { get; set; }
        
        [XmlElement("waterConcMass")]
        public MassConcentrationMeasure WaterConcMass { get; set; }
        
        [XmlElement("waterConcVol")]
        public VolumePerVolumeMeasure WaterConcVol { get; set; }
        
        [XmlElement("atmosphere")]
        public PressureMeasure Atmosphere { get; set; }
		
        [XmlElement("volumeValue")]
        public List<VolumeValue> VolumeValue { get; set; }
        
        [XmlElement("volume")]
        public VolumeQualifiedMeasure Volume { get; set; }
        
        [XmlElement("volumeStd")]
        public VolumeQualifiedMeasure VolumeStd { get; set; }
		
        [XmlElement("flowRateValue")]
        public List<FlowRateValue> FlowRateValue { get; set; }
        
        [XmlElement("flowRate")]
        public VolumeFlowRateQualifiedMeasure FlowRate { get; set; }
        
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp { get; set; }
        
        [XmlElement("pres")]
        public PressureMeasure Pres { get; set; }
        
        [XmlElement("absoluteMinPres")]
        public PressureMeasure AbsoluteMinPres { get; set; }
		
        [XmlElement("portDiff")]
        public List<ProductVolumePortDifference> PortDiff { get; set; }
        
        [XmlElement("mass")]
        public MassMeasure Mass { get; set; }
        
        [XmlElement("work")]
        public WorkMeasure Work { get; set; }
        
        [XmlElement("efficiency")]
        public VolumePerVolumeMeasure Efficiency { get; set; }
        
        [XmlElement("rvp")]
        public PressureMeasure Rvp { get; set; }
        
        [XmlElement("tvp")]
        public PressureMeasure Tvp { get; set; }
        
        [XmlElement("bsw")]
        public VolumePerVolumeMeasure Bsw { get; set; }
        
        [XmlElement("bswPrevious")]
        public VolumePerVolumeMeasure BswPrevious { get; set; }
		
        [XmlElement("densityValue")]
        public List<DensityValue> DensityValue { get; set; }
        
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        
        [XmlElement("densityFlowRate")]
        public MassFlowRateMeasure DensityFlowRate { get; set; }
        
        [XmlElement("densityStd")]
        public DensityMeasure DensityStd { get; set; }
        
        [XmlElement("concentration")]
        public VolumePerVolumeMeasure Concentration { get; set; }
        
        [XmlElement("molecularWeight")]
        public Double? MolecularWeight {
            get {
                return molecularWeightField;
            } 
            set { 
                molecularWeightField = value;
                this.MolecularWeightSpecified = true;
            }
        }

        private Double? molecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MolecularWeightSpecified { get; set; }
        
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        
        [XmlElement("molePercent")]
        public MolarFractionMeasurePercent MolePercent { get; set; }
        
        [XmlElement("moleAmt")]
        public AmountOfSubstanceMeasure MoleAmt { get; set; }
        
        [XmlElement("sg")]
        public DimensionlessMeasure SG { get; set; }
        
        [XmlElement("hcDewpoint")]
        public ThermodynamicTemperatureMeasure HCDewpoint { get; set; }
        
        [XmlElement("waterDewpoint")]
        public ThermodynamicTemperatureMeasure WaterDewpoint { get; set; }
        
        [XmlElement("wobbeIndex")]
        public ModulusOfCompressionMeasure WobbeIndex { get; set; }
        
        [XmlElement("grossCalorificValueStd")]
        public ModulusOfCompressionMeasure GrossCAlorificValueStd { get; set; }
        
        [XmlElement("rvpStabilizedCrude")]
        public PressureMeasure RvpStabilizedCrude { get; set; }
        
        [XmlElement("bswStabilizedCrude")]
        public VolumePerVolumeMeasure BswStabilizedCrude { get; set; }
        
        [XmlElement("densityStabilizedCrude")]
        public DensityMeasure DensityStabilizedCrude { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A possibly temperature and pressure corrected flow rate value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_flowRateValue", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A possibly temperature and pressure corrected flow rate value.")]
    public partial class FlowRateValue : Object 
    {

        /// <summary>
        /// The flow rate of the product. If the 'status' attribute is absent and the value is not "NaN", the data value can be assumed to be good with no restrictions. A value of "NaN" should be interpreted as null and should be not be given unless a status is also specified to explain why it is null.
        /// </summary>
        [XmlElement("flowRate")]
        public VolumeFlowRateQualifiedMeasure FlowRate { get; set; }
        /// <summary>
        /// The temperature to which the flowRate has been corrected. If given, then a pressure must also be given. Common standard temperatures are: 0 degC, 15 degC, 60 degF. If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the productVolume root. If you set this property, you must also set Pres.
        /// </summary>
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp {
            get {
                return tempField;
            } 
            set { 
                if (standardTempPresFieldSpecified) throw new Exception("Cannot set property Temp when property StandardTempPres is already set");
                tempField = value;
                tempFieldSpecified = true;
            }
        }

        private ThermodynamicTemperatureMeasure tempField; 
        private bool tempFieldSpecified = false; 

        /// <summary>
        /// The pressure to which the flowRate has been corrected. If given, then a temperature must also be given. Common standard pressures are: 1 atm and 14.696 psi (which are equivalent). If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the productVolume root. If you set this property, you must also set Temp.
        /// </summary>
        [XmlElement("pres")]
        public PressureMeasure Pres {
            get {
                return presField;
            } 
            set { 
                if (standardTempPresFieldSpecified) throw new Exception("Cannot set property Pres when property StandardTempPres is already set");
                presField = value;
                presFieldSpecified = true;
            }
        }

        private PressureMeasure presField; 
        private bool presFieldSpecified = false; 

        /// <summary>
        /// Defines the standard temperature and pressure to which the flowRate has been corrected. If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the procuctVolume root.
        /// </summary>
        [XmlElement("standardTempPres")]
        public StandardCondition StandardTempPres {
            get {
                return standardTempPresField;
            } 
            set { 
                if (presFieldSpecified) throw new Exception("Cannot set property StandardTempPres when property Pres is already set");
                if (tempFieldSpecified) throw new Exception("Cannot set property StandardTempPres when property Temp is already set");
                standardTempPresField = value;
                standardTempPresFieldSpecified = true;
            }
        }

        private StandardCondition standardTempPresField; 
        private bool standardTempPresFieldSpecified = false; 


		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_productVolumePortDifference xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumePortDifference", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_productVolumePortDifference xsd type.")]
    public partial class ProductVolumePortDifference : Object 
    {

        /// <summary>
        /// A port on the other end of an internal connection. This should always be specified if a Product Flow Network is being referenced by this report. If this is not specified then there is an assumption that there is only one other port for the unit. For example, if this end of the connection represents an inlet port then the implied other end is the outlet port for the unit.
        /// </summary>
        [XmlElement("port")]
        public RefNameString Port { get; set; }
        /// <summary>
        /// The differential pressure between the ports.
        /// </summary>
        [XmlElement("presDiff")]
        public PressureMeasure PresDiff { get; set; }
        /// <summary>
        /// The differential temperature between the ports.
        /// </summary>
        [XmlElement("tempDiff")]
        public ThermodynamicTemperatureMeasure TempDiff { get; set; }
        /// <summary>
        /// The size of the choke. This characterizes the overall unit with respect to the flow restriction between the ports. The restriction might be implemented using a valve or an actual choke.
        /// </summary>
        [XmlElement("chokeSize")]
        public LengthMeasure ChokeSize { get; set; }
        /// <summary>
        /// The relative size of the choke restriction. This characterizes the overall unit with respect to the flow restriction between the ports. The restriction might be implemented using a valve or an actual choke.
        /// </summary>
        [XmlElement("chokeRelative")]
        public LengthPerLengthMeasure ChokeRelative { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A possibly temperature and pressure corrected desity value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_densityValue", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A possibly temperature and pressure corrected desity value.")]
    public partial class DensityValue : Object 
    {

        /// <summary>
        /// The density of the product.
        /// </summary>
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        /// <summary>
        /// The temperature to which the density has been corrected. If given, then a pressure must also be given. Common standard temperatures are: 0 degC, 15 degC, 60 degF. If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the productVolume root. If you set this property, you must also set Pres.
        /// </summary>
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp {
            get {
                return tempField;
            } 
            set { 
                if (standardTempPresFieldSpecified) throw new Exception("Cannot set property Temp when property StandardTempPres is already set");
                tempField = value;
                tempFieldSpecified = true;
            }
        }

        private ThermodynamicTemperatureMeasure tempField; 
        private bool tempFieldSpecified = false; 

        /// <summary>
        /// The pressure to which the density has been corrected. If given, then a temperature must also be given. Common standard pressures are: 1 atm and 14.696 psi (which are equivalent). If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the productVolume root. If you set this property, you must also set Temp.
        /// </summary>
        [XmlElement("pres")]
        public PressureMeasure Pres {
            get {
                return presField;
            } 
            set { 
                if (standardTempPresFieldSpecified) throw new Exception("Cannot set property Pres when property StandardTempPres is already set");
                presField = value;
                presFieldSpecified = true;
            }
        }

        private PressureMeasure presField; 
        private bool presFieldSpecified = false; 

        /// <summary>
        /// Defines the standard temperature and pressure to which the density has been corrected. If neither standardTempPres nor temp,pres are specified then the standard condition is defined by standardTempPres at the procuctVolume root.
        /// </summary>
        [XmlElement("standardTempPres")]
        public StandardCondition StandardTempPres {
            get {
                return standardTempPresField;
            } 
            set { 
                if (tempFieldSpecified) throw new Exception("Cannot set property StandardTempPres when property Temp is already set");
                if (presFieldSpecified) throw new Exception("Cannot set property StandardTempPres when property Pres is already set");
                standardTempPresField = value;
                standardTempPresFieldSpecified = true;
            }
        }

        private StandardCondition standardTempPresField; 
        private bool standardTempPresFieldSpecified = false; 


		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Sales Destination Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeDestination", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Sales Destination Schema.")]
    public partial class ProductVolumeDestination : Object 
    {

        /// <summary>
        /// The name of the destination.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The type of destination.
        /// </summary>
        [XmlElement("type")]
        public BalanceDestinationType Type {
            get {
                return typeField;
            } 
            set { 
                typeField = value;
                this.TypeSpecified = true;
            }
        }

        private BalanceDestinationType typeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TypeSpecified { get; set; }
        /// <summary>
        /// The country of the destination.
        /// </summary>
        [XmlElement("country")]
        public String Country { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Balance Set Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeBalanceSet", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Balance Set Schema.")]
    public partial class ProductVolumeBalanceSet : Object 
    {

        /// <summary>
        /// Defines the aspect being described.
        /// </summary>
        [XmlElement("kind")]
        public BalanceFlowPart Kind {
            get {
                return kindField;
            } 
            set { 
                kindField = value;
                this.KindSpecified = true;
            }
        }

        private BalanceFlowPart kindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean KindSpecified { get; set; }
        /// <summary>
        /// A cargo identifier for the product.
        /// </summary>
        [XmlElement("cargoNumber")]
        public String CArgoNumber { get; set; }
        /// <summary>
        /// A cargo batch number. Used if the vessel needs to temporarily disconnect for some reason (e.g., weather).
        /// </summary>
        [XmlElement("cargoBatchNumber")]
        public Int16? CArgoBatchNumber {
            get {
                return cargoBatchNumberField;
            } 
            set { 
                cargoBatchNumberField = value;
                this.CArgoBatchNumberSpecified = true;
            }
        }

        private Int16? cargoBatchNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CArgoBatchNumberSpecified { get; set; }
        /// <summary>
        /// The name of the shipper
        /// </summary>
        [XmlElement("shipper")]
        public String Shipper { get; set; }
        /// <summary>
        /// Defines the destination of the product.
        /// </summary>
        [XmlElement("destination")]
        public ProductVolumeDestination Destination { get; set; }
		/// <summary>
        /// Provides details on the product.
        /// </summary>
        [XmlElement("balanceDetail")]
        public List<ProductVolumeBalanceDetail> BalanceDetail { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume Period Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumePeriod", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume Period Component Schema.")]
    public partial class ProductVolumePeriod : Object 
    {

        /// <summary>
        /// The type of period that is being reported. If not specified and a time is not given then the period is defined by the reporting period.
        /// </summary>
        [XmlElement("kind")]
        public ReportingPeriod Kind {
            get {
                return kindField;
            } 
            set { 
                kindField = value;
                this.KindSpecified = true;
            }
        }

        private ReportingPeriod kindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean KindSpecified { get; set; }
        /// <summary>
        /// The beginning date and time that the period represents. If you set this property, you must also set DateTimeEnd.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                if (dateEndFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property DateStart is already set");
                if (dateFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property Date is already set");
                if (dTimFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property DateTime is already set");
                dTimStartField = value;
                dTimStartFieldSpecified = true;
            }
        }

        private DateTime dTimStartField; 
        private bool dTimStartFieldSpecified = false; 

        /// <summary>
        /// The ending date and time that the period represents. If you set this property, you must also set DateTimeStart.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                if (dateEndFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property DateStart is already set");
                if (dateFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property Date is already set");
                if (dTimFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property DateTime is already set");
                dTimEndField = value;
                dTimEndFieldSpecified = true;
            }
        }

        private DateTime dTimEndField; 
        private bool dTimEndFieldSpecified = false; 

        /// <summary>
        /// The beginning date that the period represents. If you set this property, you must also set DateEnd.
        /// </summary>
        [XmlElement("dateStart")]
        public DateTime DateStart {
            get {
                return dateStartField;
            } 
            set { 
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property DateStart when property DateTimeStart is already set");
                if (dateFieldSpecified) throw new Exception("Cannot set property DateStart when property Date is already set");
                if (dTimFieldSpecified) throw new Exception("Cannot set property DateStart when property DateTime is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property DateStart when property DateTimeEnd is already set");
                dateStartField = value;
                dateStartFieldSpecified = true;
            }
        }

        private DateTime dateStartField; 
        private bool dateStartFieldSpecified = false; 

        /// <summary>
        /// The ending date that the period represents. If you set this property, you must also set DateStart.
        /// </summary>
        [XmlElement("dateEnd")]
        public DateTime DateEnd {
            get {
                return dateEndField;
            } 
            set { 
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property DateEnd when property DateTimeStart is already set");
                if (dateFieldSpecified) throw new Exception("Cannot set property DateEnd when property Date is already set");
                if (dTimFieldSpecified) throw new Exception("Cannot set property DateEnd when property DateTime is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property DateEnd when property DateTimeEnd is already set");
                dateEndField = value;
                dateEndFieldSpecified = true;
            }
        }

        private DateTime dateEndField; 
        private bool dateEndFieldSpecified = false; 

        /// <summary>
        /// The day that the period represents.
        /// </summary>
        [XmlElement("date")]
        public DateTime Date {
            get {
                return dateField;
            } 
            set { 
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property Date when property DateTimeStart is already set");
                if (dateEndFieldSpecified) throw new Exception("Cannot set property Date when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property Date when property DateStart is already set");
                if (dTimFieldSpecified) throw new Exception("Cannot set property Date when property DateTime is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property Date when property DateTimeEnd is already set");
                dateField = value;
                dateFieldSpecified = true;
            }
        }

        private DateTime dateField; 
        private bool dateFieldSpecified = false; 

        /// <summary>
        /// The beginning date and time that the period represents.
        /// </summary>
        [XmlElement("dTim")]
        public DateTime DateTime {
            get {
                return dTimField;
            } 
            set { 
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property DateTime when property DateTimeStart is already set");
                if (dateEndFieldSpecified) throw new Exception("Cannot set property DateTime when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property DateTime when property DateStart is already set");
                if (dateFieldSpecified) throw new Exception("Cannot set property DateTime when property Date is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property DateTime when property DateTimeEnd is already set");
                dTimField = value;
                dTimFieldSpecified = true;
            }
        }

        private DateTime dTimField; 
        private bool dTimFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType8> ItemsElementName { get; set; }
        
        [XmlElement("gor")]
        public VolumePerVolumeMeasure Gor { get; set; }
        
        [XmlElement("gorMTD")]
        public VolumePerVolumeMeasure GorMTD { get; set; }
        
        [XmlElement("waterConcMass")]
        public MassConcentrationMeasure WaterConcMass { get; set; }
        
        [XmlElement("waterConcVol")]
        public VolumePerVolumeMeasure WaterConcVol { get; set; }
        
        [XmlElement("atmosphere")]
        public PressureMeasure Atmosphere { get; set; }
		
        [XmlElement("volumeValue")]
        public List<VolumeValue> VolumeValue { get; set; }
        
        [XmlElement("volume")]
        public VolumeQualifiedMeasure Volume { get; set; }
        
        [XmlElement("volumeStd")]
        public VolumeQualifiedMeasure VolumeStd { get; set; }
		
        [XmlElement("flowRateValue")]
        public List<FlowRateValue> FlowRateValue { get; set; }
        
        [XmlElement("flowRate")]
        public VolumeFlowRateQualifiedMeasure FlowRate { get; set; }
        
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp { get; set; }
        
        [XmlElement("pres")]
        public PressureMeasure Pres { get; set; }
        
        [XmlElement("absoluteMinPres")]
        public PressureMeasure AbsoluteMinPres { get; set; }
		
        [XmlElement("portDiff")]
        public List<ProductVolumePortDifference> PortDiff { get; set; }
        
        [XmlElement("mass")]
        public MassMeasure Mass { get; set; }
        
        [XmlElement("work")]
        public WorkMeasure Work { get; set; }
        
        [XmlElement("efficiency")]
        public VolumePerVolumeMeasure Efficiency { get; set; }
        
        [XmlElement("rvp")]
        public PressureMeasure Rvp { get; set; }
        
        [XmlElement("tvp")]
        public PressureMeasure Tvp { get; set; }
        
        [XmlElement("bsw")]
        public VolumePerVolumeMeasure Bsw { get; set; }
        
        [XmlElement("bswPrevious")]
        public VolumePerVolumeMeasure BswPrevious { get; set; }
		
        [XmlElement("densityValue")]
        public List<DensityValue> DensityValue { get; set; }
        
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        
        [XmlElement("densityFlowRate")]
        public MassFlowRateMeasure DensityFlowRate { get; set; }
        
        [XmlElement("densityStd")]
        public DensityMeasure DensityStd { get; set; }
        
        [XmlElement("concentration")]
        public VolumePerVolumeMeasure Concentration { get; set; }
        
        [XmlElement("molecularWeight")]
        public Double? MolecularWeight {
            get {
                return molecularWeightField;
            } 
            set { 
                molecularWeightField = value;
                this.MolecularWeightSpecified = true;
            }
        }

        private Double? molecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MolecularWeightSpecified { get; set; }
        
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        
        [XmlElement("molePercent")]
        public MolarFractionMeasurePercent MolePercent { get; set; }
        
        [XmlElement("moleAmt")]
        public AmountOfSubstanceMeasure MoleAmt { get; set; }
        
        [XmlElement("sg")]
        public DimensionlessMeasure SG { get; set; }
        
        [XmlElement("hcDewpoint")]
        public ThermodynamicTemperatureMeasure HCDewpoint { get; set; }
        
        [XmlElement("waterDewpoint")]
        public ThermodynamicTemperatureMeasure WaterDewpoint { get; set; }
        
        [XmlElement("wobbeIndex")]
        public ModulusOfCompressionMeasure WobbeIndex { get; set; }
        
        [XmlElement("grossCalorificValueStd")]
        public ModulusOfCompressionMeasure GrossCAlorificValueStd { get; set; }
        
        [XmlElement("rvpStabilizedCrude")]
        public PressureMeasure RvpStabilizedCrude { get; set; }
        
        [XmlElement("bswStabilizedCrude")]
        public VolumePerVolumeMeasure BswStabilizedCrude { get; set; }
        
        [XmlElement("densityStabilizedCrude")]
        public DensityMeasure DensityStabilizedCrude { get; set; }
		/// <summary>
        /// The relative amount of a component product in the product stream.
        /// </summary>
        [XmlElement("componentContent")]
        public List<ProductVolumeComponentContent> ComponentContent { get; set; }
		/// <summary>
        /// Provides the sales context for this period.
        /// </summary>
        [XmlElement("balanceSet")]
        public List<ProductVolumeBalanceSet> BalanceSet { get; set; }
        /// <summary>
        /// An indication of some sort of abnormal condition relative the values in this period.
        /// </summary>
        [XmlElement("alert")]
        public ProductVolumeAlert Alert { get; set; }
		/// <summary>
        /// A timestamped remark about the amounts.
        /// </summary>
        [XmlElement("comment")]
        public List<DatedComment> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Alert Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeAlert", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Alert Component Schema.")]
    public partial class ProductVolumeAlert : Object 
    {

        /// <summary>
        /// An XPATH to the target value within the message containing this XPATH value.
        /// </summary>
        [XmlElement("target")]
        public String Target { get; set; }
        /// <summary>
        /// The level of the alert.
        /// </summary>
        [XmlElement("level")]
        public String Level { get; set; }
        /// <summary>
        /// The type of alert. For example "off specification".
        /// </summary>
        [XmlElement("type")]
        public String Type { get; set; }
        /// <summary>
        /// A textual decription of the alert.
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A general timestamped comment structure.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_datedComment", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A general timestamped comment structure.")]
    public partial class DatedComment : Object 
    {

        /// <summary>
        /// The name of the person providing the comment.
        /// </summary>
        [XmlElement("who")]
        public String Who { get; set; }
        /// <summary>
        /// The role of the person providing the comment. This is the role of the person within the context of comment.
        /// </summary>
        [XmlElement("role")]
        public String Role { get; set; }
        /// <summary>
        /// The date and time where the comment begins to be valid.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The date and time where the comment is no longer valid.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
        /// <summary>
        /// The relevant comment.
        /// </summary>
        [XmlElement("remark")]
        public String Remark { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_refProductFlow xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_refProductFlow", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_refProductFlow xsd type.")]
    public partial class RefProductFlow : Object 
    {

        /// <summary>
        /// A pointer to the flow within the facility.
        /// </summary>
        [XmlElement("referencedFlow")]
        public RefNameString ReferencedFlow { get; set; }
        /// <summary>
        /// A pointer to the facility that contains the flow.
        /// </summary>
        [XmlElement("parentfacility")]
        public RefNameString PluggedAndAbandonedrentfacility { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume Product Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeProduct", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume Product Component Schema.")]
    public partial class ProductVolumeProduct : Object 
    {

        /// <summary>
        /// The type of product that is being reported.
        /// </summary>
        [XmlElement("kind")]
        public ReportingProduct Kind { get; set; }
        /// <summary>
        /// The name of product that is being reported. This is reserved for generic kinds like chemical.
        /// </summary>
        [XmlElement("name")]
        public NameStruct Name { get; set; }
        /// <summary>
        /// This factor describes the fraction of fluid in the source flow that is allocated to this product stream. The volumes reported here are derived from the source flow based on this split factor. This should be an allocation flow.
        /// </summary>
        [XmlElement("splitFactor")]
        public Double? SplitFactor {
            get {
                return splitFactorField;
            } 
            set { 
                splitFactorField = value;
                this.SplitFactorSpecified = true;
            }
        }

        private Double? splitFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SplitFactorSpecified { get; set; }
        /// <summary>
        /// A reference to the source flow whose volumes are used to determine the volumes within this target product stream based on the split factor.
        /// </summary>
        [XmlElement("sourceFlow")]
        public RefProductFlow SourceFlow { get; set; }
        
        [XmlElement("gor")]
        public VolumePerVolumeMeasure Gor { get; set; }
        
        [XmlElement("gorMTD")]
        public VolumePerVolumeMeasure GorMTD { get; set; }
        
        [XmlElement("waterConcMass")]
        public MassConcentrationMeasure WaterConcMass { get; set; }
        
        [XmlElement("waterConcVol")]
        public VolumePerVolumeMeasure WaterConcVol { get; set; }
        
        [XmlElement("atmosphere")]
        public PressureMeasure Atmosphere { get; set; }
		
        [XmlElement("volumeValue")]
        public List<VolumeValue> VolumeValue { get; set; }
        
        [XmlElement("volume")]
        public VolumeQualifiedMeasure Volume { get; set; }
        
        [XmlElement("volumeStd")]
        public VolumeQualifiedMeasure VolumeStd { get; set; }
		
        [XmlElement("flowRateValue")]
        public List<FlowRateValue> FlowRateValue { get; set; }
        
        [XmlElement("flowRate")]
        public VolumeFlowRateQualifiedMeasure FlowRate { get; set; }
        
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp { get; set; }
        
        [XmlElement("pres")]
        public PressureMeasure Pres { get; set; }
        
        [XmlElement("absoluteMinPres")]
        public PressureMeasure AbsoluteMinPres { get; set; }
		
        [XmlElement("portDiff")]
        public List<ProductVolumePortDifference> PortDiff { get; set; }
        
        [XmlElement("mass")]
        public MassMeasure Mass { get; set; }
        
        [XmlElement("work")]
        public WorkMeasure Work { get; set; }
        
        [XmlElement("efficiency")]
        public VolumePerVolumeMeasure Efficiency { get; set; }
        
        [XmlElement("rvp")]
        public PressureMeasure Rvp { get; set; }
        
        [XmlElement("tvp")]
        public PressureMeasure Tvp { get; set; }
        
        [XmlElement("bsw")]
        public VolumePerVolumeMeasure Bsw { get; set; }
        
        [XmlElement("bswPrevious")]
        public VolumePerVolumeMeasure BswPrevious { get; set; }
		
        [XmlElement("densityValue")]
        public List<DensityValue> DensityValue { get; set; }
        
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        
        [XmlElement("densityFlowRate")]
        public MassFlowRateMeasure DensityFlowRate { get; set; }
        
        [XmlElement("densityStd")]
        public DensityMeasure DensityStd { get; set; }
        
        [XmlElement("concentration")]
        public VolumePerVolumeMeasure Concentration { get; set; }
        
        [XmlElement("molecularWeight")]
        public Double? MolecularWeight {
            get {
                return molecularWeightField;
            } 
            set { 
                molecularWeightField = value;
                this.MolecularWeightSpecified = true;
            }
        }

        private Double? molecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MolecularWeightSpecified { get; set; }
        
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        
        [XmlElement("molePercent")]
        public MolarFractionMeasurePercent MolePercent { get; set; }
        
        [XmlElement("moleAmt")]
        public AmountOfSubstanceMeasure MoleAmt { get; set; }
        
        [XmlElement("sg")]
        public DimensionlessMeasure SG { get; set; }
        
        [XmlElement("hcDewpoint")]
        public ThermodynamicTemperatureMeasure HCDewpoint { get; set; }
        
        [XmlElement("waterDewpoint")]
        public ThermodynamicTemperatureMeasure WaterDewpoint { get; set; }
        
        [XmlElement("wobbeIndex")]
        public ModulusOfCompressionMeasure WobbeIndex { get; set; }
        
        [XmlElement("grossCalorificValueStd")]
        public ModulusOfCompressionMeasure GrossCAlorificValueStd { get; set; }
        
        [XmlElement("rvpStabilizedCrude")]
        public PressureMeasure RvpStabilizedCrude { get; set; }
        
        [XmlElement("bswStabilizedCrude")]
        public VolumePerVolumeMeasure BswStabilizedCrude { get; set; }
        
        [XmlElement("densityStabilizedCrude")]
        public DensityMeasure DensityStabilizedCrude { get; set; }
		/// <summary>
        /// The relative amount of a component product in the product stream.
        /// </summary>
        [XmlElement("componentContent")]
        public List<ProductVolumeComponentContent> ComponentContent { get; set; }
		/// <summary>
        /// Product amounts for a specific period.
        /// </summary>
        [XmlElement("period")]
        public List<ProductVolumePeriod> Period { get; set; }
		/// <summary>
        /// A (possibly timstamped) remark about the product.
        /// </summary>
        [XmlElement("comment")]
        public List<DatedComment> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Report Facility Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeRelatedFacility", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Report Facility Component Schema.")]
    public partial class ProductVolumeRelatedFacility : Object 
    {

        /// <summary>
        /// The name of the facility. The name can be qualified by a naming system. This can also define the kind of facility.
        /// </summary>
        [XmlElement("name")]
        public FacilityIdentifierStruct Name { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent1")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent1 { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility of parent1. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent2")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent2 { get; set; }
        /// <summary>
        /// A kind of facility where the specific name is not relevant.
        /// </summary>
        [XmlElement("kind")]
        public ReportingFacility Kind {
            get {
                return kindField;
            } 
            set { 
                kindField = value;
                this.KindSpecified = true;
            }
        }

        private ReportingFacility kindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean KindSpecified { get; set; }
        /// <summary>
        /// The Product Flow Port associated with the Product Flow Unit.
        /// </summary>
        [XmlElement("port")]
        public RefNameString Port { get; set; }
        /// <summary>
        /// The Product Flow Unit representing the facility.
        /// </summary>
        [XmlElement("unit")]
        public RefNameString Unit { get; set; }
        /// <summary>
        /// The Product Flow Network representing the facility. This is only required if the network is not the same as the primary network that represents the Product Flow Model. This must be unique within the context of the Product Flow Model represented by this report.
        /// </summary>
        [XmlElement("network")]
        public RefNameString Network { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the facilityIdentifierStruct xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="facilityIdentifierStruct", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the facilityIdentifierStruct xsd type.")]
    public partial class FacilityIdentifierStruct : Object 
    {
        public FacilityIdentifierStruct() {}
        public FacilityIdentifierStruct(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The kind of facility.
        /// </summary>
        [XmlAttribute("kind")]
        private string KindSurrogate
        {
            get { return Kind.Name; }
            set { Kind.Name = value; }
        }

        [XmlIgnore]
        public ReportingFacility Kind {
            get {
                return kindField;
            } 
            set { 
                kindField = value;
                this.KindSpecified = true;
            }
        }

        private ReportingFacility kindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean KindSpecified { get; set; }
		/// <summary>
        /// The naming system within which the name is unique. For example, API or NPD.
        /// </summary>
        [XmlAttribute("namingSystem")]
        public String NamingSystem { get; set; }
		/// <summary>
        /// If the facility is defined and instantiated within the context of a WITSML server, this is a pointer to the uid value of that object instance.
        /// </summary>
        [XmlAttribute("uidRef")]
        public String UidRef { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume Flow Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeFlow", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume Flow Component Schema.")]
    public partial class ProductVolumeFlow : Object 
    {

        /// <summary>
        /// The name of this flow within the context of this report. This might reflect some combination of the kind of flow, port, qualifier and related facility.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// Indicates the type of flow that is being reported. The type of flow is an indication of the overall source or target of the flow. A production flow has one or more wells as the originating source. An injection flow has one or more wells as the ultimate target. An import flow has an offsite source. An export flow has an offiste target. A consumption flow generally has a kind of equipment as a target.
        /// </summary>
        [XmlElement("kind")]
        public ReportingFlow Kind { get; set; }
        /// <summary>
        /// The Product Flow Port to which the flow is assigned. This is the port on the Product Flow Unit that represents the facility.
        /// </summary>
        [XmlElement("port")]
        public RefNameString Port { get; set; }
        /// <summary>
        /// The kind of port that this flow represents: inlet or outlet.
        /// </summary>
        [XmlElement("direction")]
        public ProductFlowPortType Direction {
            get {
                return directionField;
            } 
            set { 
                directionField = value;
                this.DirectionSpecified = true;
            }
        }

        private ProductFlowPortType directionField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DirectionSpecified { get; set; }
        /// <summary>
        /// The name of the facility represented by the port where the measurements were taken. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facility")]
        public FacilityIdentifierStruct Facility { get; set; }
		/// <summary>
        /// An alternatative name of a facility represented by the port. This is generally unique within a naming system. The above contextually unique name (that is, within the context of a parent) should also be listed as an alias.
        /// </summary>
        [XmlElement("facilityAlias")]
        public List<NameStruct> FacilityAlias { get; set; }
        /// <summary>
        /// Qualifies the type of flow that is being reported.
        /// </summary>
        [XmlElement("qualifier")]
        public FlowQualifier Qualifier {
            get {
                return qualifierField;
            } 
            set { 
                qualifierField = value;
                this.QualifierSpecified = true;
            }
        }

        private FlowQualifier qualifierField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean QualifierSpecified { get; set; }
        /// <summary>
        /// Defines a specialization of the qualifier value. This should only be given if a qualifier is given.
        /// </summary>
        [XmlElement("subQualifier")]
        public FlowSubQualifier SubQualifier {
            get {
                return subQualifierField;
            } 
            set { 
                subQualifierField = value;
                this.SubQualifierSpecified = true;
            }
        }

        private FlowSubQualifier subQualifierField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SubQualifierSpecified { get; set; }
        /// <summary>
        /// A second facility related to this flow. For a production flow, this would represent a role of 'produced for'. For an import flow, this would represent a role of 'inport from'. For an export flow, this would represent a role of 'export to'.
        /// </summary>
        [XmlElement("relatedFacility")]
        public ProductVolumeRelatedFacility RelatedFacility { get; set; }
        /// <summary>
        /// A timestamp representing the version of this data. A flow (same port and products) with a more recent timestamp will represent the "current" version.
        /// </summary>
        [XmlElement("version")]
        public DateTime? Version {
            get {
                return versionField;
            } 
            set { 
                versionField = value;
                this.VersionSpecified = true;
            }
        }

        private DateTime? versionField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean VersionSpecified { get; set; }
        /// <summary>
        /// Identifies the source of the version. This will commonly be the name of the software which created the version. 
        /// </summary>
        [XmlElement("versionSource")]
        public String VersionSource { get; set; }
        /// <summary>
        /// This is a pointer to the flow from which this flow was derived.
        /// </summary>
        [XmlElement("sourceFlow")]
        public RefNameString SourceFlow { get; set; }
        
        [XmlElement("gor")]
        public VolumePerVolumeMeasure Gor { get; set; }
        
        [XmlElement("gorMTD")]
        public VolumePerVolumeMeasure GorMTD { get; set; }
        
        [XmlElement("waterConcMass")]
        public MassConcentrationMeasure WaterConcMass { get; set; }
        
        [XmlElement("waterConcVol")]
        public VolumePerVolumeMeasure WaterConcVol { get; set; }
        
        [XmlElement("atmosphere")]
        public PressureMeasure Atmosphere { get; set; }
		
        [XmlElement("volumeValue")]
        public List<VolumeValue> VolumeValue { get; set; }
        
        [XmlElement("volume")]
        public VolumeQualifiedMeasure Volume { get; set; }
        
        [XmlElement("volumeStd")]
        public VolumeQualifiedMeasure VolumeStd { get; set; }
		
        [XmlElement("flowRateValue")]
        public List<FlowRateValue> FlowRateValue { get; set; }
        
        [XmlElement("flowRate")]
        public VolumeFlowRateQualifiedMeasure FlowRate { get; set; }
        
        [XmlElement("temp")]
        public ThermodynamicTemperatureMeasure Temp { get; set; }
        
        [XmlElement("pres")]
        public PressureMeasure Pres { get; set; }
        
        [XmlElement("absoluteMinPres")]
        public PressureMeasure AbsoluteMinPres { get; set; }
		
        [XmlElement("portDiff")]
        public List<ProductVolumePortDifference> PortDiff { get; set; }
        
        [XmlElement("mass")]
        public MassMeasure Mass { get; set; }
        
        [XmlElement("work")]
        public WorkMeasure Work { get; set; }
        
        [XmlElement("efficiency")]
        public VolumePerVolumeMeasure Efficiency { get; set; }
        
        [XmlElement("rvp")]
        public PressureMeasure Rvp { get; set; }
        
        [XmlElement("tvp")]
        public PressureMeasure Tvp { get; set; }
        
        [XmlElement("bsw")]
        public VolumePerVolumeMeasure Bsw { get; set; }
        
        [XmlElement("bswPrevious")]
        public VolumePerVolumeMeasure BswPrevious { get; set; }
		
        [XmlElement("densityValue")]
        public List<DensityValue> DensityValue { get; set; }
        
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        
        [XmlElement("densityFlowRate")]
        public MassFlowRateMeasure DensityFlowRate { get; set; }
        
        [XmlElement("densityStd")]
        public DensityMeasure DensityStd { get; set; }
        
        [XmlElement("concentration")]
        public VolumePerVolumeMeasure Concentration { get; set; }
        
        [XmlElement("molecularWeight")]
        public Double? MolecularWeight {
            get {
                return molecularWeightField;
            } 
            set { 
                molecularWeightField = value;
                this.MolecularWeightSpecified = true;
            }
        }

        private Double? molecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MolecularWeightSpecified { get; set; }
        
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        
        [XmlElement("molePercent")]
        public MolarFractionMeasurePercent MolePercent { get; set; }
        
        [XmlElement("moleAmt")]
        public AmountOfSubstanceMeasure MoleAmt { get; set; }
        
        [XmlElement("sg")]
        public DimensionlessMeasure SG { get; set; }
        
        [XmlElement("hcDewpoint")]
        public ThermodynamicTemperatureMeasure HCDewpoint { get; set; }
        
        [XmlElement("waterDewpoint")]
        public ThermodynamicTemperatureMeasure WaterDewpoint { get; set; }
        
        [XmlElement("wobbeIndex")]
        public ModulusOfCompressionMeasure WobbeIndex { get; set; }
        
        [XmlElement("grossCalorificValueStd")]
        public ModulusOfCompressionMeasure GrossCAlorificValueStd { get; set; }
        
        [XmlElement("rvpStabilizedCrude")]
        public PressureMeasure RvpStabilizedCrude { get; set; }
        
        [XmlElement("bswStabilizedCrude")]
        public VolumePerVolumeMeasure BswStabilizedCrude { get; set; }
        
        [XmlElement("densityStabilizedCrude")]
        public DensityMeasure DensityStabilizedCrude { get; set; }
		/// <summary>
        /// Reports a product flow stream.
        /// </summary>
        [XmlElement("product")]
        public List<ProductVolumeProduct> Product { get; set; }
		/// <summary>
        /// A timestamped remark about the flow.
        /// </summary>
        [XmlElement("comment")]
        public List<DatedComment> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the integerQualifiedCount xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="integerQualifiedCount", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the integerQualifiedCount xsd type.")]
    public partial class IntegerQualifiedCount : Object 
    {
        public IntegerQualifiedCount() {}
        public IntegerQualifiedCount(Int32 value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// An indicator of the quality of the value.
        /// </summary>
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlText]
        public Int32 Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the kindQualifiedString xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="kindQualifiedString", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the kindQualifiedString xsd type.")]
    public partial class KindQualifiedString : Object 
    {
        public KindQualifiedString() {}
        public KindQualifiedString(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// An indicator of the quality of the value.
        /// </summary>
        [XmlAttribute("status")]
        private string StatusSurrogate
        {
            get { return Status.Name; }
            set { Status.Name = value; }
        }

        [XmlIgnore]
        public ValueStatus Status {
            get {
                return statusField;
            } 
            set { 
                statusField = value;
                this.StatusSpecified = true;
            }
        }

        private ValueStatus statusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusSpecified { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_curveData xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_curveData", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_curveData xsd type.")]
    public partial class CurveData : Object 
    {

		/// <summary>
        /// The value of an independent (index) variable in a row of the curve table. The units of measure are specified in the curve definition. The first value corresponds to order=1 for colums where isIndex is true. The second to order=2. And so on. The number of index and data values must match the number of columns in the table.
        /// </summary>
        [XmlElement("index")]
        public List<Double> Index { get; set; }
		/// <summary>
        /// The value of a dependent (data) variable in a row of the curve table. The units of measure are specified in the curve definition. The first value corresponds to order=1 for columns where isIndex is false. The second to order=2. And so on. The number of index and data values must match the number of columns in the table.
        /// </summary>
        [XmlElement("value")]
        public List<Double> Value { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Parameter Value Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeParameterValue", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Parameter Value Component Schema.")]
    public partial class ProductVolumeParameterValue : Object 
    {

        /// <summary>
        /// The date and time at which the parameter applies. If no time is specified then the value is static.
        /// </summary>
        [XmlElement("dTim")]
        public DateTime? DateTime {
            get {
                return dTimField;
            } 
            set { 
                dTimField = value;
                this.DateTimeSpecified = true;
            }
        }

        private DateTime? dTimField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified { get; set; }
        /// <summary>
        /// The date and time at which the parameter no longer applies. The "active" time interval is inclusive of this point. If dTimEnd is given then dTim shall also be given.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
        /// <summary>
        /// A measure value. Unless the parameter is defined as a tuple, only one value should be specified. The measure class is defined by measureClass in the parent set. The unit of measure must conform to the units allowed by the measure class in the unit dictionary file. If the 'status' attribute is absent and the value is not "NaN", the data value can be assumed to be good with no restrictions. A value of "NaN" should be interpreted as null and should be not be given unless a status is also specified to explain why it is null.
        /// </summary>
        [XmlElement("measureValue")]
        public GeneralQualifiedMeasure MeasureValue {
            get {
                return measureValueField;
            } 
            set { 
                if (integerValueFieldSpecified) throw new Exception("Cannot set property MeasureValue when property IntegerValue is already set");
                if (stringValueFieldSpecified) throw new Exception("Cannot set property MeasureValue when property StringValue is already set");
                if (curveValueFieldSpecified) throw new Exception("Cannot set property MeasureValue when property CurveValue is already set");
                measureValueField = value;
                measureValueFieldSpecified = true;
            }
        }

        private GeneralQualifiedMeasure measureValueField; 
        private bool measureValueFieldSpecified = false; 

        /// <summary>
        /// An integer value. If the 'status' attribute is absent and the value is not "NaN", the data value can be assumed to be good with no restrictions. A value of "NaN" should be interpreted as null and should be not be given unless a status is also specified to explain why it is null.
        /// </summary>
        [XmlElement("integerValue")]
        public IntegerQualifiedCount IntegerValue {
            get {
                return integerValueField;
            } 
            set { 
                if (measureValueFieldSpecified) throw new Exception("Cannot set property IntegerValue when property MeasureValue is already set");
                if (stringValueFieldSpecified) throw new Exception("Cannot set property IntegerValue when property StringValue is already set");
                if (curveValueFieldSpecified) throw new Exception("Cannot set property IntegerValue when property CurveValue is already set");
                integerValueField = value;
                integerValueFieldSpecified = true;
            }
        }

        private IntegerQualifiedCount integerValueField; 
        private bool integerValueFieldSpecified = false; 

        /// <summary>
        /// A string value. If the 'status' attribute is absent and the value is not "NaN", the data value can be assumed to be good with no restrictions. A value of "NaN" should be interpreted as null and should be not be given unless a status is also specified to explain why it is null.
        /// </summary>
        [XmlElement("stringValue")]
        public KindQualifiedString StringValue {
            get {
                return stringValueField;
            } 
            set { 
                if (measureValueFieldSpecified) throw new Exception("Cannot set property StringValue when property MeasureValue is already set");
                if (integerValueFieldSpecified) throw new Exception("Cannot set property StringValue when property IntegerValue is already set");
                if (curveValueFieldSpecified) throw new Exception("Cannot set property StringValue when property CurveValue is already set");
                stringValueField = value;
                stringValueFieldSpecified = true;
            }
        }

        private KindQualifiedString stringValueField; 
        private bool stringValueFieldSpecified = false; 

        /// <summary>
        /// The values in one row of a curve. The aggregate of the curve rows represent the curve.
        /// </summary>
        [XmlElement("curveValue")]
        public CurveData CurveValue {
            get {
                return curveValueField;
            } 
            set { 
                if (measureValueFieldSpecified) throw new Exception("Cannot set property CurveValue when property MeasureValue is already set");
                if (integerValueFieldSpecified) throw new Exception("Cannot set property CurveValue when property IntegerValue is already set");
                if (stringValueFieldSpecified) throw new Exception("Cannot set property CurveValue when property StringValue is already set");
                curveValueField = value;
                curveValueFieldSpecified = true;
            }
        }

        private CurveData curveValueField; 
        private bool curveValueFieldSpecified = false; 


        /// <summary>
        /// A port related to the parameter. If a port is given then the corresponding unit usually must be given. For example, an "offset along network" parameter must specify a port from which the offset was measured. 
        /// </summary>
        [XmlElement("port")]
        public RefNameString Port { get; set; }
        /// <summary>
        /// A unit related to the parameter. For example, an "offset along network" parameter must specify a port (on a unit) from which the offset was measured. 
        /// </summary>
        [XmlElement("unit")]
        public RefNameString Unit { get; set; }
        /// <summary>
        /// An indication of some sort of abnormal condition relative this parameter.
        /// </summary>
        [XmlElement("alert")]
        public ProductVolumeAlert Alert { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The definition of a curve.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_curveDefinition", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The definition of a curve.")]
    public partial class CurveDefinition : Object 
    {

        /// <summary>
        /// The order of the value in the index or data tuple. If isIndex is true this is the order of the (independent) index element. If isIndex is false, this is the order of the (dependent) value element.
        /// </summary>
        [XmlElement("order")]
        public Int16? Order { get; set; }
        /// <summary>
        /// The name of the variable in this curve.
        /// </summary>
        [XmlElement("parameter")]
        public String PluggedAndAbandonedrameter { get; set; }
        /// <summary>
        /// True (equal "1" or "true") indicates that this is an independent variable in this curve. At least one column column should be flagged as independent.
        /// </summary>
        [XmlElement("isIndex")]
        public Boolean? IsIndex {
            get {
                return isIndexField;
            } 
            set { 
                isIndexField = value;
                this.IsIndexSpecified = true;
            }
        }

        private Boolean? isIndexField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsIndexSpecified { get; set; }
        /// <summary>
        /// The measure class of the variable. This defines which units of measure are valid for the value.
        /// </summary>
        [XmlElement("measureClass")]
        public MeasureClass MeasureClass { get; set; }
        /// <summary>
        /// The unit of measure of the variable. The unit of measure must match a unit allowed by the measure class.
        /// </summary>
        [XmlElement("unit")]
        public String Unit { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume Facility Parameter Set Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeParameterSet", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume Facility Parameter Set Component Schema.")]
    public partial class ProductVolumeParameterSet : Object 
    {

        /// <summary>
        /// The name of the facility parameter. This should reflect the business semantics of all values in the set and not the underlying kind. For example, specify "diameter" rather than "length" or "distance".
        /// </summary>
        [XmlElement("name")]
        public FacilityParameter Name { get; set; }
        /// <summary>
        /// The port to which this parameter is assigned. This must be a port on the unit representing the parent facility of this parameter. If not specified then the parameter represents the unit.
        /// </summary>
        [XmlElement("port")]
        public RefNameString Port { get; set; }
        /// <summary>
        /// If the value is a measure (value with unit of measure), this defines the measurement class of the value. The units of measure for the value must conform to the list allowed by the measurement class in the unit dictionary file. Mutually exclusive with curveDefinition.
        /// </summary>
        [XmlElement("measureClass")]
        public MeasureClass MeasureClass {
            get {
                return measureClassField;
            } 
            set { 
                measureClassField = value;
                this.MeasureClassSpecified = true;
            }
        }

        private MeasureClass measureClassField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MeasureClassSpecified { get; set; }
		/// <summary>
        /// If the value is a curve, this defines the meaning of the one column in the table representing the curve. Mutually exclusive with measureClass.
        /// </summary>
        [XmlElement("curveDefinition")]
        public List<CurveDefinition> CurveDefinition { get; set; }
        /// <summary>
        /// Qualifies the type of parameter that is being reported.
        /// </summary>
        [XmlElement("qualifier")]
        public FlowQualifier Qualifier {
            get {
                return qualifierField;
            } 
            set { 
                qualifierField = value;
                this.QualifierSpecified = true;
            }
        }

        private FlowQualifier qualifierField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean QualifierSpecified { get; set; }
        /// <summary>
        /// Defines a specialization of the qualifier value. This should only be given if a qualifier is given.
        /// </summary>
        [XmlElement("subQualifier")]
        public FlowSubQualifier SubQualifier {
            get {
                return subQualifierField;
            } 
            set { 
                subQualifierField = value;
                this.SubQualifierSpecified = true;
            }
        }

        private FlowSubQualifier subQualifierField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SubQualifierSpecified { get; set; }
        /// <summary>
        /// A timestamp representing the version of this data. A parameter set with a more recent timestamp will represent the "current" version.
        /// </summary>
        [XmlElement("version")]
        public DateTime? Version {
            get {
                return versionField;
            } 
            set { 
                versionField = value;
                this.VersionSpecified = true;
            }
        }

        private DateTime? versionField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean VersionSpecified { get; set; }
        /// <summary>
        /// Identifies the source of the version. This will commonly be the name of the software which created the version. 
        /// </summary>
        [XmlElement("versionSource")]
        public String VersionSource { get; set; }
        /// <summary>
        /// The type of product that is being reported. This would be useful for something like specifying a tank procuct volume or level.
        /// </summary>
        [XmlElement("product")]
        public ReportingProduct Product {
            get {
                return productField;
            } 
            set { 
                productField = value;
                this.ProductSpecified = true;
            }
        }

        private ReportingProduct productField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ProductSpecified { get; set; }
		/// <summary>
        /// A parameter value, possibly at a time. If a time is not given then only one parameter should be given. If a time is specified with one value then time should be specified for all values. Each value in a time series should be of the same underling kind of value (for example, a length measure).
        /// </summary>
        [XmlElement("parameter")]
        public List<ProductVolumeParameterValue> PluggedAndAbandonedrameter { get; set; }
        /// <summary>
        /// A comment about the parameter.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Report Facility Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeFacility", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Report Facility Component Schema.")]
    public partial class ProductVolumeFacility : Object 
    {

        /// <summary>
        /// The name of the facility. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("name")]
        public FacilityIdentifierStruct Name { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility. For example, if name represents a completion, then facilityParent1 would represent the name of the well within which name was unique. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent1")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent1 { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility of parent1. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent2")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent2 { get; set; }
		/// <summary>
        /// An alternatative name of a facility. This is generally unique within a naming system. The above contextually unique name (that is, within the context of a parent) should also be listed as an alias.
        /// </summary>
        [XmlElement("facilityAlias")]
        public List<NameStruct> FacilityAlias { get; set; }
        /// <summary>
        /// The Product Flow Unit representing the facility. This must be unique within the context of the Product Flow Network.
        /// </summary>
        [XmlElement("unit")]
        public RefNameString Unit { get; set; }
        /// <summary>
        /// The Product Flow Network representing the facility. This can only be given if unit is given. This is only required if the network is not the same as the primary network that represents the Product Flow Model. This must be unique within the context of the Product Flow Model represented by this report.
        /// </summary>
        [XmlElement("network")]
        public RefNameString Network { get; set; }
		/// <summary>
        /// The name and type of a facility whose context is relevant to this facility.
        /// </summary>
        [XmlElement("contextFacility")]
        public List<FacilityIdentifierStruct> ContextFacility { get; set; }
        /// <summary>
        /// The status of the well. In PRODML, the value of "active -- injecting" has been DEPRECATED. Instead, use "active" with wellProducing=true. In PRODML, the value of "active -- producing" has been DEPRECATED. Instead, use "active" with wellInjecting=true.
        /// </summary>
        [XmlElement("statusWell")]
        public WellStatus? StatusWell {
            get {
                return statusWellField;
            } 
            set { 
                statusWellField = value;
                this.StatusWellSpecified = true;
            }
        }

        private WellStatus? statusWellField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StatusWellSpecified { get; set; }
        /// <summary>
        /// POSC well fluid. The type of fluid being produced from or injected into a well facility. 
        /// </summary>
        [XmlElement("fluidWell")]
        public WellFluid? FluidWell {
            get {
                return fluidWellField;
            } 
            set { 
                fluidWellField = value;
                this.FluidWellSpecified = true;
            }
        }

        private WellFluid? fluidWellField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean FluidWellSpecified { get; set; }
        /// <summary>
        /// The lift method being used to operate the well.
        /// </summary>
        [XmlElement("operatingMethod")]
        public WellOperationMethod OperatingMethod {
            get {
                return operatingMethodField;
            } 
            set { 
                operatingMethodField = value;
                this.OperatingMethodSpecified = true;
            }
        }

        private WellOperationMethod operatingMethodField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean OperatingMethodSpecified { get; set; }
        /// <summary>
        /// True (or 1) indicates that the well is producing. False (or 0) or not given indicates that the well is not producing. This only applies if the facility is a well or wellbore.
        /// </summary>
        [XmlElement("wellProducing")]
        public Boolean? WellProducing {
            get {
                return wellProducingField;
            } 
            set { 
                wellProducingField = value;
                this.WellProducingSpecified = true;
            }
        }

        private Boolean? wellProducingField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean WellProducingSpecified { get; set; }
        /// <summary>
        /// True (or 1) indicates that the well is injecting. False (or 0) or not given indicates that the well is not injecting. This only applies if the facility is a well or wellbore.
        /// </summary>
        [XmlElement("wellInjecting")]
        public Boolean? WellInjecting {
            get {
                return wellInjectingField;
            } 
            set { 
                wellInjectingField = value;
                this.WellInjectingSpecified = true;
            }
        }

        private Boolean? wellInjectingField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean WellInjectingSpecified { get; set; }
        /// <summary>
        /// The storage capacity of the facility (e.g., a tank).
        /// </summary>
        [XmlElement("capacity")]
        public VolumeMeasure Capacity { get; set; }
        /// <summary>
        /// The amount of time that the facility was active during the reporting period.
        /// </summary>
        [XmlElement("operationTime")]
        public TimeMeasure OperatingerationTime { get; set; }
		/// <summary>
        /// The reason for any down time during the reporting period.
        /// </summary>
        [XmlElement("downtimeReason")]
        public List<DatedComment> DowntimeReason { get; set; }
		/// <summary>
        /// Usage values for one parameter associated with the facility.
        /// </summary>
        [XmlElement("parameterSet")]
        public List<ProductVolumeParameterSet> PluggedAndAbandonedrameterSet { get; set; }
		/// <summary>
        /// Reports a flow of a product.
        /// </summary>
        [XmlElement("flow")]
        public List<ProductVolumeFlow> Flow { get; set; }
		/// <summary>
        /// A timestamped remark about the facility.
        /// </summary>
        [XmlElement("comment")]
        public List<DatedComment> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume component schema for defining account information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeBusinessAccountInfo", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume component schema for defining account information.")]
    public partial class ProductVolumeBusinessAccountInfo : Object 
    {

        /// <summary>
        /// The identifier of the account of the sub-unit within the whole business unit.
        /// </summary>
        [XmlElement("accountId")]
        public String AccountId { get; set; }
        /// <summary>
        /// The product associated with the account identifier.
        /// </summary>
        [XmlElement("product")]
        public ReportingProduct Product {
            get {
                return productField;
            } 
            set { 
                productField = value;
                this.ProductSpecified = true;
            }
        }

        private ReportingProduct productField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ProductSpecified { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume component schema for defining ownership shares.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeBusinessOwnershipShare", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume component schema for defining ownership shares.")]
    public partial class ProductVolumeBusinessOwnershipShare : Object 
    {

        /// <summary>
        /// The percent ownership of the sub-unit in the unit during the specified time.
        /// </summary>
        [XmlElement("share")]
        public VolumePerVolumeMeasurePercent Share { get; set; }
		/// <summary>
        /// The date on which the ownership became valid.
        /// </summary>
        [XmlElement("")]
        public DateTime? StartDate {
            get {
                return startDateField;
            } 
            set { 
                startDateField = value;
                this.StartDateSpecified = true;
            }
        }

        private DateTime? startDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StartDateSpecified { get; set; }
		/// <summary>
        /// The final date on which the ownership was valid. If no end date is specified, the share is considered to still be valid.
        /// </summary>
        [XmlElement("")]
        public DateTime? EndDate {
            get {
                return endDateField;
            } 
            set { 
                endDateField = value;
                this.EndDateSpecified = true;
            }
        }

        private DateTime? endDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EndDateSpecified { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume component schema for defining ownership shares of business units.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeBusinessSubUnit", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume component schema for defining ownership shares of business units.")]
    public partial class ProductVolumeBusinessSubUnit : Object 
    {

        /// <summary>
        /// Points to business unit which is part of another business unit.
        /// </summary>
        [XmlElement("kind")]
        public RefNameString Kind { get; set; }
        /// <summary>
        /// Defines account information in the parent unit. This commonly applies at a parent terminus unit (e.g., a terminal),
        /// </summary>
        [XmlElement("accountInformation")]
        public ProductVolumeBusinessAccountInfo AccountInformation {
            get {
                return accountInformationField;
            } 
            set { 
                if (ownershipShareFieldSpecified) throw new Exception("Cannot set property AccountInformation when property OwnershipShare is already set");
                accountInformationField = value;
                accountInformationFieldSpecified = true;
            }
        }

        private ProductVolumeBusinessAccountInfo accountInformationField; 
        private bool accountInformationFieldSpecified = false; 

        /// <summary>
        /// Defines the ownership share in the parent unit at a point in time. This commonly applies at a parent source unit (e.g., a field or platform).
        /// </summary>
        [XmlElement("ownershipShare")]
        public ProductVolumeBusinessOwnershipShare OwnershipShare {
            get {
                return ownershipShareField;
            } 
            set { 
                if (accountInformationFieldSpecified) throw new Exception("Cannot set property OwnershipShare when property AccountInformation is already set");
                ownershipShareField = value;
                ownershipShareFieldSpecified = true;
            }
        }

        private ProductVolumeBusinessOwnershipShare ownershipShareField; 
        private bool ownershipShareFieldSpecified = false; 


		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Volume component schema for defining business units.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productVolumeBusinessUnit", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Volume component schema for defining business units.")]
    public partial class ProductVolumeBusinessUnit : Object 
    {

        /// <summary>
        /// The type of business unit.
        /// </summary>
        [XmlElement("kind")]
        public BusinessUnitKind Kind { get; set; }
        /// <summary>
        /// The human contextual name of the business unit.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// A textual description of the business unit.
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
		/// <summary>
        /// A component part of the unit. The composition of a unit may vary with time. This defines the ownership share or account information for a sub unit within the context of the whole unit. For ownership shares, at any one point in time the sum of the shares should be 100%.
        /// </summary>
        [XmlElement("subUnit")]
        public List<ProductVolumeBusinessSubUnit> SubUnit { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    /// <summary>
    /// The non-contextual content of a WITSML Product Volume object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_productVolume", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The non-contextual content of a WITSML Product Volume object.")]
    public partial class ProductVolume : Object 
    {

        /// <summary>
        /// Human recognizable context for the Product Volume Report.
        /// </summary>
        [XmlElement("name")]
        public NameStruct Name { get; set; }
        /// <summary>
        /// The name of the facility which is represented by this report. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("installation")]
        public FacilityIdentifierStruct Installation { get; set; }
		/// <summary>
        /// The name and type of a facility whose context is relevant to the represented installation.
        /// </summary>
        [XmlElement("contextFacility")]
        public List<FacilityIdentifierStruct> ContextFacility { get; set; }
        /// <summary>
        /// The type of report.
        /// </summary>
        [XmlElement("kind")]
        public String Kind { get; set; }
        /// <summary>
        /// The type of period that is being reported. This value must be consistent with the reporting start and end values.
        /// </summary>
        [XmlElement("periodKind")]
        public ReportingPeriod PeriodKind {
            get {
                return periodKindField;
            } 
            set { 
                periodKindField = value;
                this.PeriodKindSpecified = true;
            }
        }

        private ReportingPeriod periodKindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PeriodKindSpecified { get; set; }
        /// <summary>
        /// The beginning date and time that the report represents. If you set this property, you must also set DateTimeEnd.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                if (dateEndFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property DateStart is already set");
                if (monthFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property Month is already set");
                dTimStartField = value;
                dTimStartFieldSpecified = true;
            }
        }

        private DateTime dTimStartField; 
        private bool dTimStartFieldSpecified = false; 

        /// <summary>
        /// The ending date and time that the report represents. If you set this property, you must also set DateTimeStart.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                if (dateEndFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property DateStart is already set");
                if (monthFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property Month is already set");
                dTimEndField = value;
                dTimEndFieldSpecified = true;
            }
        }

        private DateTime dTimEndField; 
        private bool dTimEndFieldSpecified = false; 

        /// <summary>
        /// The beginning date that the report represents. If you set this property, you must also set DateEnd.
        /// </summary>
        [XmlElement("dateStart")]
        public DateTime DateStart {
            get {
                return dateStartField;
            } 
            set { 
                if (monthFieldSpecified) throw new Exception("Cannot set property DateStart when property Month is already set");
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property DateStart when property DateTimeStart is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property DateStart when property DateTimeEnd is already set");
                dateStartField = value;
                dateStartFieldSpecified = true;
            }
        }

        private DateTime dateStartField; 
        private bool dateStartFieldSpecified = false; 

        /// <summary>
        /// The ending date that the report represents. If you set this property, you must also set DateStart.
        /// </summary>
        [XmlElement("dateEnd")]
        public DateTime DateEnd {
            get {
                return dateEndField;
            } 
            set { 
                if (monthFieldSpecified) throw new Exception("Cannot set property DateEnd when property Month is already set");
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property DateEnd when property DateTimeStart is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property DateEnd when property DateTimeEnd is already set");
                dateEndField = value;
                dateEndFieldSpecified = true;
            }
        }

        private DateTime dateEndField; 
        private bool dateEndFieldSpecified = false; 

        /// <summary>
        /// The ending date that the report represents.
        /// </summary>
        [XmlElement("month")]
        public String Month {
            get {
                return monthField;
            } 
            set { 
                if (dateEndFieldSpecified) throw new Exception("Cannot set property Month when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property Month when property DateStart is already set");
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property Month when property DateTimeStart is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property Month when property DateTimeEnd is already set");
                monthField = value;
                monthFieldSpecified = true;
            }
        }

        private String monthField; 
        private bool monthFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType7> ItemsElementName { get; set; }
        /// <summary>
        /// The minimum time index contained within the report. For the purposes of this parameter, a "period" or "facility parameter" without any time data should be assumed to have the time associated with the overall report. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMin")]
        public EndpointQualifiedDateTime DateTimeMin { get; set; }
        /// <summary>
        /// The maximum time index contained within the report. For the purposes of this parameter, a "period" or "facility parameter" without any time data should be assumed to have the time associated with the overall report. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMax")]
        public EndpointQualifiedDateTime DateTimeMax { get; set; }
        /// <summary>
        /// The definition of the "current time" index for this report. The current time index is a server query parameter which requests the selection of a single node from a recurring "period" set (e.g., the data related to one point in a time series). For the purposes of this parameter, a "period" without any time data should be assumed to have the time associated with the overall report. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimCurrent")]
        public DateTime? DateTimeCurrent {
            get {
                return dTimCurrentField;
            } 
            set { 
                dTimCurrentField = value;
                this.DateTimeCurrentSpecified = true;
            }
        }

        private DateTime? dTimCurrentField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeCurrentSpecified { get; set; }
        /// <summary>
        /// The calculation method for for "filling in" values in an indexed set. If not given, the default is that no calculations are performed to create data where none exists within an existing set. This is not to be construed as to prevent concepts such as simulation and forcasting from being applied in order to create a new set. This is a server query parameter.
        /// </summary>
        [XmlElement("calculationMethod")]
        public CalculationMethod CAlculationMethod {
            get {
                return calculationMethodField;
            } 
            set { 
                calculationMethodField = value;
                this.CAlculationMethodSpecified = true;
            }
        }

        private CalculationMethod calculationMethodField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CAlculationMethodSpecified { get; set; }
        /// <summary>
        /// The operator of the facilities in the report.
        /// </summary>
        [XmlElement("operator")]
        public BusinessAssociate Operator { get; set; }
        /// <summary>
        /// The tile of the report if different from the name of the report.
        /// </summary>
        [XmlElement("title")]
        public NameStruct Title { get; set; }
        /// <summary>
        /// The geographic context of the report.
        /// </summary>
        [XmlElement("geographicContext")]
        public GeographicContext GeographicContext { get; set; }
		/// <summary>
        /// The date that the report was issued.
        /// </summary>
        [XmlElement("")]
        public DateTime? IssueDate {
            get {
                return issueDateField;
            } 
            set { 
                issueDateField = value;
                this.IssueDateSpecified = true;
            }
        }

        private DateTime? issueDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IssueDateSpecified { get; set; }
        /// <summary>
        /// The person or company that issued the report. This may contain the role of the person or company within the context of the report.
        /// </summary>
        [XmlElement("issuedBy")]
        public BusinessAssociate IssuedBy { get; set; }
		/// <summary>
        /// The date that the report was approved.
        /// </summary>
        [XmlElement("")]
        public DateTime? ApprovalDate {
            get {
                return approvalDateField;
            } 
            set { 
                approvalDateField = value;
                this.ApprovalDateSpecified = true;
            }
        }

        private DateTime? approvalDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ApprovalDateSpecified { get; set; }
        /// <summary>
        /// The person or company that approved the report. This may contain the role of the person or company within the context of the report.
        /// </summary>
        [XmlElement("approver")]
        public BusinessAssociate Approver { get; set; }
        /// <summary>
        /// The Product Flow Model for the overall installation. This model represents all Product Flow Units referenced within this report.
        /// </summary>
        [XmlElement("productFlowModel")]
        public RefNameString ProductFlowModel { get; set; }
        /// <summary>
        /// Defines the default standard temperature and pressure to which all volumes, densities and flow rates in this report have been corrected. The default may be locally overridden for an individual value. If not specified, then the conditions must be presumed to be ambient conditions (i.e., uncorrected) unless otherwise specified at a local level.
        /// </summary>
        [XmlElement("standardTempPres")]
        public StandardCondition StandardTempPres {
            get {
                return standardTempPresField;
            } 
            set { 
                standardTempPresField = value;
                this.StandardTempPresSpecified = true;
            }
        }

        private StandardCondition standardTempPresField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StandardTempPresSpecified { get; set; }
		/// <summary>
        /// A business unit and related account or ownership share information.
        /// </summary>
        [XmlElement("businessUnit")]
        public List<ProductVolumeBusinessUnit> BusinessUnit { get; set; }
		/// <summary>
        /// A facility for which product information is being reported.
        /// </summary>
        [XmlElement("facility")]
        public List<ProductVolumeFacility> Facility { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The business associate describes any company, person, group, consultant, etc, which is associated within a context (e.g., a well). The information contained in this module is: (1) contact information, such as address, phone numbers, email, (2) alternate name, or aliases, and (3) associations, such as the business associate that this one is associated  with, or a contact who is associated with this business associate. 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_businessAssociate", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The business associate describes any company, person, group, consultant, etc, which is associated within a context (e.g., a well). The information contained in this module is: (1) contact information, such as address, phone numbers, email, (2) alternate name, or aliases, and (3) associations, such as the business associate that this one is associated  with, or a contact who is associated with this business associate. ")]
    public partial class BusinessAssociate : Object 
    {

        /// <summary>
        /// The name of the business associate. This can be the name of a person, business, group, etc.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
		/// <summary>
        /// The role of the business associate within the context. For example, "driller" or "operator", "lead agency - CEQA compliance" "regulatory contact", "safety contact". A business associate will generally have one role but the role may be called different things in different naming systems.
        /// </summary>
        [XmlElement("role")]
        public List<NameStruct> Role { get; set; }
        /// <summary>
        /// If the business associate is a person, this specifies the component names of the person.
        /// </summary>
        [XmlElement("personName")]
        public PersonName PersonName { get; set; }
		/// <summary>
        /// The alias is an alternate name of a business associate. It is generally associated with a naming system. An alias is not necessarily unique within the naming system. 
        /// </summary>
        [XmlElement("alias")]
        public List<NameStruct> Alias { get; set; }
		/// <summary>
        /// Note that address may occur more than once, because it may be necessary to give a physical address, a mailing address, or both. 
        /// </summary>
        [XmlElement("address")]
        public List<GeneralAddress> Address { get; set; }
		/// <summary>
        /// The various types of phone numbers may be given. The may be office or home, they may be a number for a cell phone, or for a fax, etc. Attributes of PhoneNumber declare the type of phone number that is being given. 
        /// </summary>
        [XmlElement("phoneNumber")]
        public List<PhoneNumberStruct> PHoneNumber { get; set; }
		/// <summary>
        /// The email address may be home, office, or permanent. More than one may be given. 
        /// </summary>
        [XmlElement("email")]
        public List<EmailQualifierStruct> Email { get; set; }
		/// <summary>
        /// The preferred method of being contacted within the context of this role. 
        /// </summary>
        [XmlElement("contactPreference")]
        public List<ContactPreference> ContactPreference { get; set; }
        /// <summary>
        /// A pointer to another business associate that this business associate is associated with. The most common situation is that of an employee being associated with a company. But it may also be, for example, a work group associated with a university.
        /// </summary>
        [XmlElement("associatedWith")]
        public RefNameString AssociatedWith { get; set; }
		/// <summary>
        /// A pointer to a business associate (generally a person) who serves as a contact for this business associate. 
        /// </summary>
        [XmlElement("contact")]
        public List<RefNameString> Contact { get; set; }
        /// <summary>
        /// The count of the number of personnel in a group.
        /// </summary>
        [XmlElement("personnelCount")]
        public Int16? PersonnelCount {
            get {
                return personnelCountField;
            } 
            set { 
                personnelCountField = value;
                this.PersonnelCountSpecified = true;
            }
        }

        private Int16? personnelCountField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PersonnelCountSpecified { get; set; }
        /// <summary>
        /// A general comment. This should not be used to carry semantic information. This is not intended to be machine interpretable. 
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_personName xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_personName", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_personName xsd type.")]
    public partial class PersonName : Object 
    {

        /// <summary>
        /// A name prefix. Such as, Dr, Ms, Miss, Mr, etc.
        /// </summary>
        [XmlElement("prefix")]
        public String Prefix { get; set; }
        /// <summary>
        /// The persons first name.
        /// </summary>
        [XmlElement("first")]
        public String First { get; set; }
        /// <summary>
        /// The persons middle name or initial name.
        /// </summary>
        [XmlElement("middle")]
        public String Middle { get; set; }
        /// <summary>
        /// The persons last or given name.
        /// </summary>
        [XmlElement("last")]
        public String Last { get; set; }
		/// <summary>
        /// A name suffix. Such as Esq, Phd, etc.
        /// </summary>
        [XmlElement("suffix")]
        public List<String> Suffix { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// An general address structure. This form is appropriate for most countries. 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_generalAddress", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("An general address structure. This form is appropriate for most countries. ")]
    public partial class GeneralAddress : Object 
    {

        
        [XmlElement("name")]
        public String Name { get; set; }
		
        [XmlElement("street")]
        public List<String> Street { get; set; }
        
        [XmlElement("city")]
        public String City { get; set; }
        
        [XmlElement("county")]
        public String County {
            get {
                return countyField;
            } 
            set { 
                if (provinceFieldSpecified) throw new Exception("Cannot set property County when property Province is already set");
                if (stateFieldSpecified) throw new Exception("Cannot set property County when property State is already set");
                countyField = value;
                countyFieldSpecified = true;
            }
        }

        private String countyField; 
        private bool countyFieldSpecified = false; 

        
        [XmlElement("province")]
        public String Province {
            get {
                return provinceField;
            } 
            set { 
                if (countyFieldSpecified) throw new Exception("Cannot set property Province when property County is already set");
                if (stateFieldSpecified) throw new Exception("Cannot set property Province when property State is already set");
                provinceField = value;
                provinceFieldSpecified = true;
            }
        }

        private String provinceField; 
        private bool provinceFieldSpecified = false; 

        
        [XmlElement("state")]
        public String State {
            get {
                return stateField;
            } 
            set { 
                if (countyFieldSpecified) throw new Exception("Cannot set property State when property County is already set");
                if (provinceFieldSpecified) throw new Exception("Cannot set property State when property Province is already set");
                stateField = value;
                stateFieldSpecified = true;
            }
        }

        private String stateField; 
        private bool stateFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType7? ItemElementName { get; set; }
        /// <summary>
        /// The Country may be included. Although this is optional, it is probably required for most uses.
        /// </summary>
        [XmlElement("country")]
        public String Country { get; set; }
        /// <summary>
        /// A postal code, if appropriate for the country. In the USA this would be the five or nine digit zip code.
        /// </summary>
        [XmlElement("postalCode")]
        public String PostalCode { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		/// <summary>
        /// The type of address: mailing, physical, or both.
        /// </summary>
        [XmlAttribute("kind")]
        private string KindSurrogate
        {
            get { return Kind.Name; }
            set { Kind.Name = value; }
        }

        [XmlIgnore]
        public AddressKindEnum Kind {
            get {
                return kindField;
            } 
            set { 
                kindField = value;
                this.KindSpecified = true;
            }
        }

        private AddressKindEnum kindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean KindSpecified { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the phoneNumberStruct xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="phoneNumberStruct", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the phoneNumberStruct xsd type.")]
    public partial class PhoneNumberStruct : Object 
    {
        public PhoneNumberStruct() {}
        public PhoneNumberStruct(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The kind of phone such as voice or fax.
        /// </summary>
        [XmlAttribute("type")]
        private string TypeSurrogate
        {
            get { return Type.Name; }
            set { Type.Name = value; }
        }

        [XmlIgnore]
        public PhoneType Type { get; set; }
		/// <summary>
        /// Indicates whether the number is personal, business or both.
        /// </summary>
        [XmlAttribute("qualifier")]
        private string QualifierSurrogate
        {
            get { return Qualifier.Name; }
            set { Qualifier.Name = value; }
        }

        [XmlIgnore]
        public AddressQualifier Qualifier {
            get {
                return qualifierField;
            } 
            set { 
                qualifierField = value;
                this.QualifierSpecified = true;
            }
        }

        private AddressQualifier qualifierField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean QualifierSpecified { get; set; }
		/// <summary>
        /// The phone number extension.
        /// </summary>
        [XmlAttribute("extension")]
        public String Extension { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the emailQualifierStruct xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="emailQualifierStruct", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the emailQualifierStruct xsd type.")]
    public partial class EmailQualifierStruct : Object 
    {
        public EmailQualifierStruct() {}
        public EmailQualifierStruct(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		
        [XmlAttribute("qualifier")]
        private string QualifierSurrogate
        {
            get { return Qualifier.Name; }
            set { Qualifier.Name = value; }
        }

        [XmlIgnore]
        public AddressQualifier Qualifier {
            get {
                return qualifierField;
            } 
            set { 
                qualifierField = value;
                this.QualifierSpecified = true;
            }
        }

        private AddressQualifier qualifierField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean QualifierSpecified { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A geographic context of a report.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_geographicContext", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A geographic context of a report.")]
    public partial class GeographicContext : Object 
    {

        /// <summary>
        /// The name of the country.
        /// </summary>
        [XmlElement("country")]
        public String Country { get; set; }
        /// <summary>
        /// The state of province within the country.
        /// </summary>
        [XmlElement("state")]
        public String State { get; set; }
        /// <summary>
        /// The name of the field within whose context the report exists.
        /// </summary>
        [XmlElement("field")]
        public NameStruct Field { get; set; }
        /// <summary>
        /// An offshore context.
        /// </summary>
        [XmlElement("offshoreLocation")]
        public OffshoreLocation OffshoreLocation { get; set; }
        /// <summary>
        /// An general comment that further explains the offshore location.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A generic type of offshore location. This allows an offshore location to be given by an Area Name, and up to four block names. A comment is also allowed.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_offshoreLocation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A generic type of offshore location. This allows an offshore location to be given by an Area Name, and up to four block names. A comment is also allowed.")]
    public partial class OffshoreLocation : Object 
    {

        /// <summary>
        /// A general meaning of Area. It may be as general as 'UK North Sea' or 'Viosca Knoll'. The user community must agree on the meaning of this element.
        /// </summary>
        [XmlElement("areaName")]
        public String AreaName { get; set; }
		/// <summary>
        /// A block ID that can more tightly locate the object. The BlockID should be an identifying name or code. The user community for an area must agree on the exact meaning of this element. An aggregate of increasingly specialized block IDs are sometimes necessary to define the location.
        /// </summary>
        [XmlElement("blockID")]
        public List<String> BlockID { get; set; }
        /// <summary>
        /// An offshore location using the North Sea Offshore terminology.
        /// </summary>
        [XmlElement("northSeaOffshore")]
        public NorthSeaOffshore NorthSeaOffshore { get; set; }
        /// <summary>
        /// An general comment that further explains the offshore location.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A type of offshore location that captures the North Sea Offshore terminology.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_northSeaOffshore", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A type of offshore location that captures the North Sea Offshore terminology.")]
    public partial class NorthSeaOffshore : Object 
    {

        /// <summary>
        /// An optional, uncontrolled value, which may be used to describe the general area of offshore North Sea in which the point is located.
        /// </summary>
        [XmlElement("areaName")]
        public String AreaName { get; set; }
        /// <summary>
        /// The number or letter of the quadrant in the North Sea.
        /// </summary>
        [XmlElement("quadrant")]
        public String Quadrant { get; set; }
        /// <summary>
        /// A lower case letter assigned if a block is subdivided.
        /// </summary>
        [XmlElement("blockSuffix")]
        public String BlockSuffix { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Operational Comments Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationOperationalComment", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Operational Comments Component Schema.")]
    public partial class ProductionOperationOperationalComment : Object 
    {

        /// <summary>
        /// The kind of operation
        /// </summary>
        [XmlElement("type")]
        public OperationKind Type {
            get {
                return typeField;
            } 
            set { 
                typeField = value;
                this.TypeSpecified = true;
            }
        }

        private OperationKind typeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TypeSpecified { get; set; }
        /// <summary>
        /// The beginning date and time that the comment represents.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The ending date and time that the comment represents.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
		/// <summary>
        /// A comment about the operation and/or the activities within the operation.
        /// </summary>
        [XmlElement("comment")]
        public List<String> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Infomation about a cargo ship operation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationCargoShipOperation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Infomation about a cargo ship operation.")]
    public partial class ProductionOperationCargoShipOperation : Object 
    {

        /// <summary>
        /// Name of the cargo vessel for the installation.
        /// </summary>
        [XmlElement("vesselName")]
        public String VesselName { get; set; }
        /// <summary>
        /// The date and time that the vessel arrived.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The date and time that the vessel left.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
        /// <summary>
        /// Name of the captain of the vessel.
        /// </summary>
        [XmlElement("captain")]
        public String Captain { get; set; }
        /// <summary>
        /// the cargo identifier.
        /// </summary>
        [XmlElement("cargoNumber")]
        public String CArgoNumber { get; set; }
        /// <summary>
        /// The cargo batch number. Used if the vessel needs to temporarily disconnect for some reason (e.g., weather).
        /// </summary>
        [XmlElement("cargoBatchNumber")]
        public Int16? CArgoBatchNumber {
            get {
                return cargoBatchNumberField;
            } 
            set { 
                cargoBatchNumberField = value;
                this.CArgoBatchNumberSpecified = true;
            }
        }

        private Int16? cargoBatchNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CArgoBatchNumberSpecified { get; set; }
        /// <summary>
        /// Description of cargo on the vessel.
        /// </summary>
        [XmlElement("cargo")]
        public String CArgo { get; set; }
        /// <summary>
        /// Gross oil loaded to the ship during the report period. Gross oil includes BS and W. This volume has been corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("oilGrossStdTempPres")]
        public VolumeMeasure OilGrossStdTempPres { get; set; }
        /// <summary>
        /// Gross oil loaded to the ship in total during the operation. Gross oil includes BS and W. This volume has been corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("oilGrossTotalStdTempPres")]
        public VolumeMeasure OilGrossTotalStdTempPres { get; set; }
        /// <summary>
        /// Net oil loaded to the ship during the report period. Net oil excludes BS and W, fuel, spill and leaks. This volume has been corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("oilNetStdTempPres")]
        public VolumeMeasure OilNetStdTempPres { get; set; }
        /// <summary>
        /// Net oil loaded to the ship from the beginning of the month to the end of the reporting period. Net oil excludes BS and W, fuel, spill and leaks. This volume has been corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("oilNetMonthToDateStdTempPres")]
        public VolumeMeasure OilNetMonthToDateStdTempPres { get; set; }
        /// <summary>
        /// Density of the liquid loaded to the tanker. This density has been corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("densityStdTempPres")]
        public DensityMeasure DensityStdTempPres { get; set; }
        /// <summary>
        /// Density of the liquid loaded to the tanker.
        /// </summary>
        [XmlElement("density")]
        public DensityMeasure Density { get; set; }
        /// <summary>
        /// Reid vapor pressure of the liquid.
        /// </summary>
        [XmlElement("rvp")]
        public PressureMeasure Rvp { get; set; }
        /// <summary>
        /// Basic sediment and water is measured from a liquid sample of the production stream. It includes free water, sediment and emulsion and is measured as a volume percentage of the liquid.
        /// </summary>
        [XmlElement("bsw")]
        public VolumePerVolumeMeasure Bsw { get; set; }
        /// <summary>
        /// Salt content. The product formed by neutralization of an acid and a base. The term is more specifically applied to sodium chloride.
        /// </summary>
        [XmlElement("salt")]
        public DensityMeasure Salt { get; set; }
		/// <summary>
        /// A commnet about the operation.
        /// </summary>
        [XmlElement("comment")]
        public List<DatedComment> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Infomation about a marine operation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationMarineOperation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Infomation about a marine operation.")]
    public partial class ProductionOperationMarineOperation : Object 
    {

        /// <summary>
        /// The beginning date and time that the information represents.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The ending date and time that the comment represents.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
        /// <summary>
        /// A general comment on marine activity in the area
        /// </summary>
        [XmlElement("generalComment")]
        public String GeneralComment { get; set; }
        /// <summary>
        /// Name of supply vessel for the installation.
        /// </summary>
        [XmlElement("supplyShip")]
        public String SupplyShip { get; set; }
        /// <summary>
        /// Name of standby vessel for the installation.
        /// </summary>
        [XmlElement("standbyVessel")]
        public String StandbyVessel { get; set; }
		/// <summary>
        /// Comment regarding the supply ship.
        /// </summary>
        [XmlElement("supplyShipComment")]
        public List<DatedComment> SupplyShipComment { get; set; }
		/// <summary>
        /// Comment regarding the standby vessel.
        /// </summary>
        [XmlElement("standbyVesselComment")]
        public List<DatedComment> StandbyVesselComment { get; set; }
		/// <summary>
        /// Report of any basket movement to and from the installation.
        /// </summary>
        [XmlElement("basketMovement")]
        public List<DatedComment> BasketMovement { get; set; }
		/// <summary>
        /// A comment on a special event in the marine area.
        /// </summary>
        [XmlElement("activity")]
        public List<DatedComment> Activity { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A structure to record informaion about a single alarm.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationAlarm", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A structure to record informaion about a single alarm.")]
    public partial class ProductionOperationAlarm : Object 
    {

        /// <summary>
        /// The date and time when the alarms went off.
        /// </summary>
        [XmlElement("dTim")]
        public DateTime? DateTime {
            get {
                return dTimField;
            } 
            set { 
                dTimField = value;
                this.DateTimeSpecified = true;
            }
        }

        private DateTime? dTimField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified { get; set; }
        /// <summary>
        /// The area where the alarm went off.
        /// </summary>
        [XmlElement("area")]
        public String Area { get; set; }
        /// <summary>
        /// The type of alarm that went off.
        /// </summary>
        [XmlElement("type")]
        public String Type { get; set; }
        /// <summary>
        /// The reason for the alarm going off.
        /// </summary>
        [XmlElement("reason")]
        public String Reason { get; set; }
        /// <summary>
        /// A general comment relevant for the alarm.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Infomation about a shutdown event.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationShutdown", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Infomation about a shutdown event.")]
    public partial class ProductionOperationShutdown : Object 
    {

        /// <summary>
        /// The name of the installation which was shut down. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("installation")]
        public FacilityIdentifierStruct Installation { get; set; }
        /// <summary>
        /// A general description of the shutdown with reason and other relevant information. 
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
        /// <summary>
        /// The time the shutdown started.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The time the shutdown ended.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
        /// <summary>
        /// Downtime when the installation is unable to produce 100% of its capability. 
        /// </summary>
        [XmlElement("volumetricDownTime")]
        public TimeMeasure VolumetricDownTime { get; set; }
        /// <summary>
        /// Estimated loss of oil deliveries because of the shutdown. This volume has been corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("lossOilStdTempPres")]
        public VolumeMeasure LossOilStdTempPres { get; set; }
        /// <summary>
        /// Estimated loss of gas deliveries because of the shutdown. This volume has been corrected to standard conditions of temperature and pressure.
        /// </summary>
        [XmlElement("lossGasStdTempPres")]
        public VolumeMeasure LossGasStdTempPres { get; set; }
		/// <summary>
        /// A description of main activities from time to time during the shutdown period. 
        /// </summary>
        [XmlElement("activity")]
        public List<DatedComment> Activity { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Information about the contaminants in water, and the general water quality. The values are measured from a sample, which is described below. Values measured from other samples should be given in different instances of the type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationWaterCleaningQuality", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Information about the contaminants in water, and the general water quality. The values are measured from a sample, which is described below. Values measured from other samples should be given in different instances of the type.")]
    public partial class ProductionOperationWaterCleaningQuality : Object 
    {

        /// <summary>
        /// An identifier of the point from which the sample was taken. This is an uncontrolled string value, which should be as descriptive as possible.
        /// </summary>
        [XmlElement("samplePoint")]
        public String SamplePoint { get; set; }
        /// <summary>
        /// Total measured oil in the water after the water cleaning process, but before it is discharged from the installation.
        /// </summary>
        [XmlElement("oilInWaterProduced")]
        public MassConcentrationMeasure OilInWaterProduced { get; set; }
        /// <summary>
        /// Total measured oil in the water after the water cleaning process, but before it is discharged from the installation
        /// </summary>
        [XmlElement("amountOfOil")]
        public MassMeasure AmountOfOil { get; set; }
        /// <summary>
        /// The amount of ammonium found in the water sample.
        /// </summary>
        [XmlElement("ammonium")]
        public DensityMeasure Ammonium { get; set; }
        /// <summary>
        /// The amount of total organic carbon found in the water. The water is under high temperature and the carbon left is measured
        /// </summary>
        [XmlElement("totalOrganicCarbon")]
        public MassConcentrationMeasure TotalOrganicCArbon { get; set; }
        /// <summary>
        /// The amount of Fenol found in the water sample.
        /// </summary>
        [XmlElement("phenol")]
        public DensityMeasure PHenol { get; set; }
        /// <summary>
        /// The amount of Glycol found in the water sample.
        /// </summary>
        [XmlElement("glycol")]
        public DensityMeasure Glycol { get; set; }
        /// <summary>
        /// The pH value of the treated water. The pH value is best given as a value, with no unit of measure, since there are no variations from the pH.
        /// </summary>
        [XmlElement("phValue")]
        public Double? PHValue {
            get {
                return phValueField;
            } 
            set { 
                phValueField = value;
                this.PHValueSpecified = true;
            }
        }

        private Double? phValueField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PHValueSpecified { get; set; }
        /// <summary>
        /// The temperature of the water before it is discharged.
        /// </summary>
        [XmlElement("waterTemperature")]
        public ThermodynamicTemperatureMeasure WaterTemperature { get; set; }
        /// <summary>
        /// Total measured residual clorines in the water after the water cleaning process, but before it is discharged from the installation.
        /// </summary>
        [XmlElement("residualChloride")]
        public MassConcentrationMeasure ResidualChloride { get; set; }
        /// <summary>
        /// Total measured Oxygen in the water after the water cleaning process, but before it is discharged from the installation.
        /// </summary>
        [XmlElement("oxygen")]
        public MassConcentrationMeasure Oxygen { get; set; }
        /// <summary>
        /// A measure of the cloudiness of water caused by suspended particles.
        /// </summary>
        [XmlElement("turbidity")]
        public Double? Turbidity {
            get {
                return turbidityField;
            } 
            set { 
                turbidityField = value;
                this.TurbiditySpecified = true;
            }
        }

        private Double? turbidityField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TurbiditySpecified { get; set; }
        /// <summary>
        /// A measure of the number of particles in water as measured by a coulter counter.
        /// </summary>
        [XmlElement("coulterCounter")]
        public MassConcentrationMeasure CoulterCounter { get; set; }
		/// <summary>
        /// Any comment that may be useful in describing the water quality. There can be multiple comments.
        /// </summary>
        [XmlElement("comment")]
        public List<DatedComment> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Production losses due to Third Party Processing.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationThirdPartyProcessing", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Production losses due to Third Party Processing.")]
    public partial class ProductionOperationThirdPartyProcessing : Object 
    {

        /// <summary>
        /// The name of the installation which performed the processing. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("installation")]
        public FacilityIdentifierStruct Installation { get; set; }
        /// <summary>
        /// The estimated amount of oil lost. This volume has been corrected to standard conditions of temperature and pressure
        /// </summary>
        [XmlElement("oilStdTempPres")]
        public VolumeMeasure OilStdTempPres { get; set; }
        /// <summary>
        /// The estimated amount of gas lost. This volume has been corrected to standard conditions of temperature and pressure
        /// </summary>
        [XmlElement("gasStdTempPres")]
        public VolumeMeasure GasStdTempPres { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Lost Production Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationLostProduction", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Lost Production Component Schema.")]
    public partial class ProductionOperationLostProduction : Object 
    {

		/// <summary>
        /// A estimated lost volume and the reason for the loss.
        /// </summary>
        [XmlElement("volumeAndReason")]
        public List<LostVolumeAndReason> VolumeAndReason { get; set; }
		/// <summary>
        /// The estimated amount of oil and gas lost due to third party processing at an installation.
        /// </summary>
        [XmlElement("thirdPartyProcessing")]
        public List<ProductionOperationThirdPartyProcessing> ThirdPluggedAndAbandonedrtyProcessing { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Production Activity Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationActivity", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Production Activity Component Schema.")]
    public partial class ProductionOperationActivity : Object 
    {

        /// <summary>
        /// Infomation about a lost production.
        /// </summary>
        [XmlElement("lostProduction")]
        public ProductionOperationLostProduction LostProduction { get; set; }
        /// <summary>
        /// Infomation about a lost injection.
        /// </summary>
        [XmlElement("lostInjection")]
        public ProductionOperationLostProduction LostInjection { get; set; }
		/// <summary>
        /// Information about the contaminants in water, and the general water quality.
        /// </summary>
        [XmlElement("waterCleaningQuality")]
        public List<ProductionOperationWaterCleaningQuality> WaterCleaningQuality { get; set; }
		/// <summary>
        /// Infomation about a shutdown event.
        /// </summary>
        [XmlElement("shutdown")]
        public List<ProductionOperationShutdown> Shutdown { get; set; }
		/// <summary>
        /// Infomation about an alarm.
        /// </summary>
        [XmlElement("alarm")]
        public List<ProductionOperationAlarm> Alarm { get; set; }
		/// <summary>
        /// Information about a marine operation.
        /// </summary>
        [XmlElement("marineOperation")]
        public List<ProductionOperationMarineOperation> MarineOperatingeration { get; set; }
		/// <summary>
        /// Information about a cargo operation.
        /// </summary>
        [XmlElement("cargoShipOperation")]
        public List<ProductionOperationCargoShipOperation> CArgoShipOperatingeration { get; set; }
		/// <summary>
        /// A comment about a kind of operation. The time of the operation can be specified.
        /// </summary>
        [XmlElement("operationalComment")]
        public List<ProductionOperationOperationalComment> OperatingerationalComment { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Operations Weather Component Schema
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationWeather", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Operations Weather Component Schema")]
    public partial class ProductionOperationWeather : Object 
    {

        /// <summary>
        /// Date and time the information is related to. 
        /// </summary>
        [XmlElement("dTim")]
        public DateTime? DateTime { get; set; }
        /// <summary>
        /// Name of company that supplied the data. 
        /// </summary>
        [XmlElement("agency")]
        public String Agency { get; set; }
        /// <summary>
        /// Atmospheric pressure. 
        /// </summary>
        [XmlElement("barometricPressure")]
        public PressureMeasure BarometricPressure { get; set; }
        /// <summary>
        /// The Beaufort wind scale is a system used to estimate and report wind speeds when no measuring apparatus is available. It was invented in the early 19th Century by Admiral Sir Francis Beaufort of the British Navy as a way to interpret winds from conditions. 
        /// </summary>
        [XmlElement("beaufortScaleNumber")]
        public Int16? BeaufortScaleNumber {
            get {
                return beaufortScaleNumberField;
            } 
            set { 
                beaufortScaleNumberField = value;
                this.BeaufortScaleNumberSpecified = true;
            }
        }

        private Int16? beaufortScaleNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean BeaufortScaleNumberSpecified { get; set; }
        /// <summary>
        /// Average temperature above ground for the period. Temperature of the atmosphere. 
        /// </summary>
        [XmlElement("tempSurface")]
        public ThermodynamicTemperatureMeasure TempSurface { get; set; }
        /// <summary>
        /// Minimum temperature above ground. Temperature of the atmosphere. 
        /// </summary>
        [XmlElement("tempSurfaceMn")]
        public ThermodynamicTemperatureMeasure TempSurfaceMin { get; set; }
        /// <summary>
        /// Maximum temperature above ground. 
        /// </summary>
        [XmlElement("tempSurfaceMx")]
        public ThermodynamicTemperatureMeasure TempSurfaceMax { get; set; }
        /// <summary>
        /// A measure of the combined chilling effect of wind and low temperature on living things, also named chill factor, e.g., according to US weather service table, an air temperature of 30 degF with a 10 mi/h corresponds to a windchill of 22 degF. 
        /// </summary>
        [XmlElement("tempWindChill")]
        public ThermodynamicTemperatureMeasure TempWindChill { get; set; }
        /// <summary>
        /// Sea temperature. 
        /// </summary>
        [XmlElement("tempsea")]
        public ThermodynamicTemperatureMeasure Tempsea { get; set; }
        /// <summary>
        /// Horizontal visibility. 
        /// </summary>
        [XmlElement("visibility")]
        public LengthMeasure Visibility { get; set; }
        /// <summary>
        /// The direction from which the waves are coming, measured from true north. 
        /// </summary>
        [XmlElement("aziWave")]
        public PlaneAngleMeasure AziWave { get; set; }
        /// <summary>
        /// Average height of the waves. 
        /// </summary>
        [XmlElement("htWave")]
        public LengthMeasure HeightWave { get; set; }
        /// <summary>
        /// An average of the higher 1/3 of the wave heights passing during a sample period (typically 20 to 30 minutes). 
        /// </summary>
        [XmlElement("significantWave")]
        public LengthMeasure SignificantWave { get; set; }
        /// <summary>
        /// The maximum wave height.
        /// </summary>
        [XmlElement("maxWave")]
        public LengthMeasure MaxWave { get; set; }
        /// <summary>
        /// The elapsed time between the passing of two wave tops. 
        /// </summary>
        [XmlElement("periodWave")]
        public TimeMeasure PeriodWave { get; set; }
        /// <summary>
        /// The direction from which the wind is blowing, measured from true north. 
        /// </summary>
        [XmlElement("aziWind")]
        public PlaneAngleMeasure AziWind { get; set; }
        /// <summary>
        /// Wind speed. 
        /// </summary>
        [XmlElement("velWind")]
        public VelocityMeasure VelWind { get; set; }
        /// <summary>
        /// Type of precipitation. 
        /// </summary>
        [XmlElement("typePrecip")]
        public String TypePrecip { get; set; }
        /// <summary>
        /// Amount of precipitation. 
        /// </summary>
        [XmlElement("amtPrecip")]
        public LengthMeasure AmtPrecip { get; set; }
        /// <summary>
        /// Description of cloud cover. 
        /// </summary>
        [XmlElement("coverCloud")]
        public String CoverCloud { get; set; }
        /// <summary>
        /// Height of cloud cover. 
        /// </summary>
        [XmlElement("ceilingCloud")]
        public LengthMeasure CeilingCloud { get; set; }
        /// <summary>
        /// Current speed. 
        /// </summary>
        [XmlElement("currentSea")]
        public VelocityMeasure CurrentSea { get; set; }
        /// <summary>
        /// Azimuth of current. 
        /// </summary>
        [XmlElement("aziCurrentSea")]
        public PlaneAngleMeasure AziCurrentSea { get; set; }
        /// <summary>
        /// Comments and remarks. 
        /// </summary>
        [XmlElement("comments")]
        public String Comments { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the safetyCount xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="safetyCount", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the safetyCount xsd type.")]
    public partial class SafetyCount : Object 
    {
        public SafetyCount() {}
        public SafetyCount(Int16 value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The type of safety issue for which a count is being defined.
        /// </summary>
        [XmlAttribute("type")]
        private string TypeSurrogate
        {
            get { return Type.Name; }
            set { Type.Name = value; }
        }

        [XmlIgnore]
        public SafetyType Type {
            get {
                return typeField;
            } 
            set { 
                typeField = value;
                this.TypeSpecified = true;
            }
        }

        private SafetyType typeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TypeSpecified { get; set; }
		/// <summary>
        /// The type of period being reported by this count.
        /// </summary>
        [XmlAttribute("period")]
        private string PeriodSurrogate
        {
            get { return Period.Name; }
            set { Period.Name = value; }
        }

        [XmlIgnore]
        public ReportingPeriod Period {
            get {
                return periodField;
            } 
            set { 
                periodField = value;
                this.PeriodSpecified = true;
            }
        }

        private ReportingPeriod periodField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PeriodSpecified { get; set; }
		
        [XmlText]
        public Int16 Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Safety Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationSafety", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Safety Component Schema.")]
    public partial class ProductionOperationSafety : Object 
    {

        /// <summary>
        /// The mean time between safety incidents.
        /// </summary>
        [XmlElement("meantimeIncident")]
        public TimeMeasure MeantimeIncident { get; set; }
		/// <summary>
        /// The count of a type of safety issue.
        /// </summary>
        [XmlElement("safetyCount")]
        public List<SafetyCount> SafetyCount { get; set; }
		/// <summary>
        /// Safety related comment. 
        /// </summary>
        [XmlElement("comment")]
        public List<DatedComment> Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Operational Health, Safety and Environment Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationHSE", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Operational Health, Safety and Environment Component Schema.")]
    public partial class ProductionOperationHSE : Object 
    {

        /// <summary>
        /// the number of incidents of accidents and injuries that were reported.
        /// </summary>
        [XmlElement("IncidentCount")]
        public Int16? IncidentCount {
            get {
                return IncidentCountField;
            } 
            set { 
                IncidentCountField = value;
                this.IncidentCountSpecified = true;
            }
        }

        private Int16? IncidentCountField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IncidentCountSpecified { get; set; }
        /// <summary>
        /// The amount of time since the most recent Lost Time Accident.
        /// </summary>
        [XmlElement("sinceLostTime")]
        public TimeMeasure SinceLostTime { get; set; }
        /// <summary>
        /// The amount of time since the most recent accident prevention exercise.
        /// </summary>
        [XmlElement("sincePreventionExercise")]
        public TimeMeasure SincePreventionExercise { get; set; }
        /// <summary>
        /// The amount of time since the most recent defined hazard and accident situation (Norwegian DFU). 
        /// </summary>
        [XmlElement("sinceDefinedSituation")]
        public TimeMeasure SinceDefinedSituation { get; set; }
        /// <summary>
        /// The number of medical treatments that have occurred.
        /// </summary>
        [XmlElement("medicalTreatmentCount")]
        public Int16? MedicalTreatmentCount {
            get {
                return medicalTreatmentCountField;
            } 
            set { 
                medicalTreatmentCountField = value;
                this.MedicalTreatmentCountSpecified = true;
            }
        }

        private Int16? medicalTreatmentCountField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MedicalTreatmentCountSpecified { get; set; }
        /// <summary>
        /// The number of system alarms that have occurred.
        /// </summary>
        [XmlElement("alarmCount")]
        public Int16? AlarmCount {
            get {
                return alarmCountField;
            } 
            set { 
                alarmCountField = value;
                this.AlarmCountSpecified = true;
            }
        }

        private Int16? alarmCountField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AlarmCountSpecified { get; set; }
        /// <summary>
        /// The number of personnel safety introductions that have occurred.
        /// </summary>
        [XmlElement("safetyIntroCount")]
        public Int16? SafetyIntroCount {
            get {
                return safetyIntroCountField;
            } 
            set { 
                safetyIntroCountField = value;
                this.SafetyIntroCountSpecified = true;
            }
        }

        private Int16? safetyIntroCountField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SafetyIntroCountSpecified { get; set; }
        /// <summary>
        /// A textual description of safety considerations.
        /// </summary>
        [XmlElement("safetyDescription")]
        public String SafetyDescription { get; set; }
		/// <summary>
        /// Safety information at a specific installatino.
        /// </summary>
        [XmlElement("safety")]
        public List<ProductionOperationSafety> Safety { get; set; }
		/// <summary>
        /// Information about the weather at a point in time.
        /// </summary>
        [XmlElement("weather")]
        public List<ProductionOperationWeather> Weather { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the crewCount xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="crewCount", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the crewCount xsd type.")]
    public partial class CrewCount : Object 
    {
        public CrewCount() {}
        public CrewCount(Int16 value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The type of crew for which a count is being defined.
        /// </summary>
        [XmlAttribute("type")]
        private string TypeSurrogate
        {
            get { return Type.Name; }
            set { Type.Name = value; }
        }

        [XmlIgnore]
        public CrewType Type {
            get {
                return typeField;
            } 
            set { 
                typeField = value;
                this.TypeSpecified = true;
            }
        }

        private CrewType typeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TypeSpecified { get; set; }
		
        [XmlText]
        public Int16 Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML -Installation Report Component Schema
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productionOperationInstallationReport", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML -Installation Report Component Schema")]
    public partial class ProductionOperationInstallationReport : Object 
    {

        /// <summary>
        /// The installation represented by this report.
        /// </summary>
        [XmlElement("installation")]
        public FacilityIdentifierStruct Installation { get; set; }
        /// <summary>
        /// Total count of beds available on the installation.
        /// </summary>
        [XmlElement("bedsAvailable")]
        public Int16? BedsAverageailable {
            get {
                return bedsAvailableField;
            } 
            set { 
                bedsAvailableField = value;
                this.BedsAverageailableSpecified = true;
            }
        }

        private Int16? bedsAvailableField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean BedsAverageailableSpecified { get; set; }
		/// <summary>
        /// The count of personnel on a type of crew. One of the types is all personnel on board.
        /// </summary>
        [XmlElement("crewCount")]
        public List<CrewCount> CrewCount { get; set; }
        /// <summary>
        /// The total cumulative amount of time worked during the reporting period. Commonly specified in units of hours. Note that a day unit translates to 24 hours worked.
        /// </summary>
        [XmlElement("work")]
        public TimeMeasure Work { get; set; }
        /// <summary>
        /// The total cumulative amount of time worked from the beginning of the month to the end of reporting period. Commonly specified in units of hours. Note that a day unit translates to 24 hours worked.
        /// </summary>
        [XmlElement("workMonthToDate")]
        public TimeMeasure WorkMonthToDate { get; set; }
        /// <summary>
        /// The total cumulative amount of time worked from the beginning of the year to the end of reporting period. Commonly specified in units of hours. Note that a day unit translates to 24 hours worked.
        /// </summary>
        [XmlElement("workYearToDate")]
        public TimeMeasure WorkYearToDate { get; set; }
		/// <summary>
        /// Health, Safety and Environmenal information.
        /// </summary>
        [XmlElement("operationalHSE")]
        public List<ProductionOperationHSE> OperatingerationalHSE { get; set; }
        /// <summary>
        /// Production activities.
        /// </summary>
        [XmlElement("productionActivity")]
        public ProductionOperationActivity ProductionActivity { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    /// <summary>
    /// The non-contextual content of a WITSML Production Operation object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_productionOperation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The non-contextual content of a WITSML Production Operation object.")]
    public partial class ProductionOperation : Object 
    {

        /// <summary>
        /// Human recognizable context for the Production Operation Report. 
        /// </summary>
        [XmlElement("name")]
        public NameStruct Name { get; set; }
        /// <summary>
        /// The name of the facility which is represented by this report. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("installation")]
        public FacilityIdentifierStruct Installation { get; set; }
		/// <summary>
        /// The name and type of a facility whose context is relevant to the represented installation.
        /// </summary>
        [XmlElement("contextFacility")]
        public List<FacilityIdentifierStruct> ContextFacility { get; set; }
        /// <summary>
        /// The type of report.
        /// </summary>
        [XmlElement("kind")]
        public String Kind { get; set; }
        /// <summary>
        /// The type of period that is being reported. This value must be consistent with the reporting start and end values.
        /// </summary>
        [XmlElement("periodKind")]
        public ReportingPeriod PeriodKind {
            get {
                return periodKindField;
            } 
            set { 
                periodKindField = value;
                this.PeriodKindSpecified = true;
            }
        }

        private ReportingPeriod periodKindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PeriodKindSpecified { get; set; }
        /// <summary>
        /// The beginning date and time that the report represents. If you set this property, you must also set DateTimeEnd.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                if (dateEndFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property DateTimeStart when property DateStart is already set");
                dTimStartField = value;
                dTimStartFieldSpecified = true;
            }
        }

        private DateTime dTimStartField; 
        private bool dTimStartFieldSpecified = false; 

        /// <summary>
        /// The ending date and time that the report represents. If you set this property, you must also set DateTimeStart.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                if (dateEndFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property DateEnd is already set");
                if (dateStartFieldSpecified) throw new Exception("Cannot set property DateTimeEnd when property DateStart is already set");
                dTimEndField = value;
                dTimEndFieldSpecified = true;
            }
        }

        private DateTime dTimEndField; 
        private bool dTimEndFieldSpecified = false; 

        /// <summary>
        /// The beginning date that the report represents. If you set this property, you must also set DateEnd.
        /// </summary>
        [XmlElement("dateStart")]
        public DateTime DateStart {
            get {
                return dateStartField;
            } 
            set { 
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property DateStart when property DateTimeStart is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property DateStart when property DateTimeEnd is already set");
                dateStartField = value;
                dateStartFieldSpecified = true;
            }
        }

        private DateTime dateStartField; 
        private bool dateStartFieldSpecified = false; 

        /// <summary>
        /// The ending date that the report represents. If you set this property, you must also set DateStart.
        /// </summary>
        [XmlElement("dateEnd")]
        public DateTime DateEnd {
            get {
                return dateEndField;
            } 
            set { 
                if (dTimStartFieldSpecified) throw new Exception("Cannot set property DateEnd when property DateTimeStart is already set");
                if (dTimEndFieldSpecified) throw new Exception("Cannot set property DateEnd when property DateTimeEnd is already set");
                dateEndField = value;
                dateEndFieldSpecified = true;
            }
        }

        private DateTime dateEndField; 
        private bool dateEndFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType6> ItemsElementName { get; set; }
        /// <summary>
        /// The operator of the facilities in the report.
        /// </summary>
        [XmlElement("operator")]
        public BusinessAssociate Operator { get; set; }
        /// <summary>
        /// The tile of the report if different from the name of the report.
        /// </summary>
        [XmlElement("title")]
        public NameStruct Title { get; set; }
        /// <summary>
        /// The geographic context of the report.
        /// </summary>
        [XmlElement("geographicContext")]
        public GeographicContext GeographicContext { get; set; }
		/// <summary>
        /// The date that the report was issued.
        /// </summary>
        [XmlElement("")]
        public DateTime? IssueDate {
            get {
                return issueDateField;
            } 
            set { 
                issueDateField = value;
                this.IssueDateSpecified = true;
            }
        }

        private DateTime? issueDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IssueDateSpecified { get; set; }
        /// <summary>
        /// The person or company that issued the report. This may contain the role of the person or company within the context of the report.
        /// </summary>
        [XmlElement("issuedBy")]
        public BusinessAssociate IssuedBy { get; set; }
		/// <summary>
        /// The date that the report was approved.
        /// </summary>
        [XmlElement("")]
        public DateTime? ApprovalDate {
            get {
                return approvalDateField;
            } 
            set { 
                approvalDateField = value;
                this.ApprovalDateSpecified = true;
            }
        }

        private DateTime? approvalDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ApprovalDateSpecified { get; set; }
        /// <summary>
        /// The person or company that approved the report. This may contain the role of the person or company within the context of the report.
        /// </summary>
        [XmlElement("approver")]
        public BusinessAssociate Approver { get; set; }
		/// <summary>
        /// A report for each installation
        /// </summary>
        [XmlElement("installationReport")]
        public List<ProductionOperationInstallationReport> InstallationReport { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A plan to extend an actual network.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowNetworkPlan", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A plan to extend an actual network.")]
    public partial class ProductFlowNetworkPlan : Object 
    {

        /// <summary>
        /// The name assigned to the plan.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The date and time of the start of the plan. This point coincides with the end of the actual configuration. The configuration of the actual at this point in time represents the configuration of the plan at this starting point. All changes to this plan must be in the future from this point in time.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart { get; set; }
        /// <summary>
        /// A textual description of the purpose of the plan.
        /// </summary>
        [XmlElement("purpose")]
        public String Purpose { get; set; }
		/// <summary>
        /// Documents that a change occurred at a particular time.
        /// </summary>
        [XmlElement("changeLog")]
        public List<ProductFlowChangeLog> ChangeLog { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Documents the point in time where changes were made.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowChangeLog", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Documents the point in time where changes were made.")]
    public partial class ProductFlowChangeLog : Object 
    {

        /// <summary>
        /// A name assigned to the change.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The timestamp associated with the change. All changes must use this timestamp.
        /// </summary>
        [XmlElement("dTim")]
        public DateTime? DateTime { get; set; }
        /// <summary>
        /// A textual reason for the change.
        /// </summary>
        [XmlElement("reason")]
        public String Reason { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Expected Property Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowExpectedPortProperty", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Expected Property Component Schema.")]
    public partial class ProductFlowExpectedPortProperty : Object 
    {

        /// <summary>
        /// The expected kind of property.
        /// </summary>
        [XmlElement("property")]
        public ReportingProperty Property { get; set; }
        /// <summary>
        /// The date and time that the sensor was activated on the port.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The date and time that the sensor was deactivated on the port.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
		/// <summary>
        /// An alternative name for the sensor that will measure the property.
        /// </summary>
        [XmlElement("tagAlias")]
        public List<NameStruct> TagAlias { get; set; }
		/// <summary>
        /// Defines the expected flow and product pairs to be assigned to this port by a Product Volume report. A set of expected qualifiers can be defined for each pair. The aggregate of expectations on all properties should be a subset of the aggregate of expectations on the port. If no expectations are defined on the port then the port aggregate will be defined by the properties.
        /// </summary>
        [XmlElement("expectedFlowProduct")]
        public List<ProductFlowQualifierExpected> ExpectedFlowProduct { get; set; }
        /// <summary>
        /// A descriptive remark associated with this property.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines an expected combination of kinds.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowQualifierExpected", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Defines an expected combination of kinds.")]
    public partial class ProductFlowQualifierExpected : Object 
    {

        /// <summary>
        /// The expected kind of flow.
        /// </summary>
        [XmlElement("flow")]
        public ReportingFlow Flow { get; set; }
        /// <summary>
        /// The expected kind of product within the flow.
        /// </summary>
        [XmlElement("product")]
        public ReportingProduct Product { get; set; }
		/// <summary>
        /// The expected kind of qualifier of the flow.
        /// </summary>
        [XmlElement("qualifier")]
        public List<FlowQualifier> Qualifier { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Connected Node Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_connectedNode", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Connected Node Component Schema.")]
    public partial class ConnectedNode : Object 
    {

        /// <summary>
        /// Defines the node to which this port is connected. Only two ports should be actively connected to the same node at the same point in time. That is, a port should only be connected to one other port. There are no semantics for the node except common connection. All ports that are connected to a node with the the same name are inherently connected to each other. The name of the node is only required to be unique within the context of the current Product Flow Network (that is, not the overall model). All ports must be connected to a node and whether or not any other port is connected to the same node depends on the requirements of the network. Any node that is internally connected to only one node is presumably a candidate to be connected to an external node. The behavior of ports connected at a common node is as follows: a) There is no pressure drop across the node. All ports connected to the node have the same pressure. That is, there is an assumption of steady state fluid flow. b) Conservation of mass exists across the node. The mass into the node via all connected ports equals the mass out of the node via all connected ports. c) The flow direction of a port connected to the node may be transient. That is, flow direction may change toward any port if the relative internal pressure of the Product Flow Units change and a new steady state is achieved.
        /// </summary>
        [XmlElement("node")]
        public String Node { get; set; }
        /// <summary>
        /// The name of a network plan. This indicates a planned connection. The connected port must be part of the same plan or be an actual. Not specified indicates an actual connection.
        /// </summary>
        [XmlElement("planName")]
        public String PlanName { get; set; }
        /// <summary>
        /// The date and time that the connection was activated.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The date and time that the connection was terminated.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
        /// <summary>
        /// A descriptive remark associated with this connection, possibly including a reason for termination.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Port Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowPort", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Port Component Schema.")]
    public partial class ProductFlowPort : Object 
    {

        /// <summary>
        /// The name of the port within the context of the Product Flow Unit.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The name of a network plan. This indicates a planned port. All child network components must all be planned and be part of the same plan. The parent unit must be part of the same plan or be an actual. Not specified indicates an actual port.
        /// </summary>
        [XmlElement("planName")]
        public String PlanName { get; set; }
        /// <summary>
        /// Defines whether this port is an inlet or outlet. This is a nominal intended direction.
        /// </summary>
        [XmlElement("direction")]
        public ProductFlowPortType Direction { get; set; }
        /// <summary>
        /// The name of the facility represented by this Product Flow Port The name can be qualified by a naming system. The facility name is assumed to be unique within the context of the facility represented by the unit. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facility")]
        public FacilityIdentifierStruct Facility { get; set; }
		/// <summary>
        /// An alternatative name of a facility. This is generally unique within a naming system. The above contextually unique name should also be listed as an alias.
        /// </summary>
        [XmlElement("facilityAlias")]
        public List<NameStruct> FacilityAlias { get; set; }
        /// <summary>
        /// True ("true" or "1") indicates that the port is an exposed internal port and cannot be used in a connection external to the unit. False ("false" or "0") or not given indicates a normal port.
        /// </summary>
        [XmlElement("exposed")]
        public Boolean? Exposed {
            get {
                return exposedField;
            } 
            set { 
                exposedField = value;
                this.ExposedSpecified = true;
            }
        }

        private Boolean? exposedField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ExposedSpecified { get; set; }
		/// <summary>
        /// Defines the node to which this port is connected. A timestamp activates and deactivates the connection. Only one connectedNode should be active at any one point in time. There are no semantics for the node except common connection. All ports that are connected to a node with the the same name are inherently connected to each other. The name of the node is only required to be unique within the context of the current Product Flow Network (that is, not the overall model). All ports must be connected to a node and whether or not any other port is connected to the same node depends on the requirements of the network. Any node that is internally connected to only one port is presumably a candidate to be connected to an external node. The behavior of ports connected at a common node is as follows: a) There is no pressure drop across the node. All ports connected to the node have the same pressure. That is, there is an assumption of steady state fluid flow. b) Conservation of mass exists across the node. The mass into the node via all connected ports equals the mass out of the node via all connected ports. c) The flow direction of a port connected to the node may be transient. That is, flow direction may change toward any port(s) if the relative internal pressure of the Product Flow Units change and a new steady state is achieved.
        /// </summary>
        [XmlElement("connectedNode")]
        public List<ConnectedNode> ConnectedNode { get; set; }
		/// <summary>
        /// Defines the expected flow and product pairs to be assigned to this port by a Product Volume report. A set of expected qualifiers can be defined for each pair.
        /// </summary>
        [XmlElement("expectedFlowProduct")]
        public List<ProductFlowQualifierExpected> ExpectedFlowProduct { get; set; }
		/// <summary>
        /// Defines the properties that are expected to be measured at this port. This can also specify the equipment tag(s) of the sensor that will read the value. Only one of each property kind should be active at any point in time.
        /// </summary>
        [XmlElement("expectedFlowProperty")]
        public List<ProductFlowExpectedPortProperty> ExpectedFlowProperty { get; set; }
        /// <summary>
        /// A descriptive remark associated with this port.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Connected Node Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_relativeCoordinate", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Connected Node Component Schema.")]
    public partial class RelativeCoordinate : Object 
    {

        /// <summary>
        /// Defines the relative from-left-to-right location on a display screen. The display origin (0,0) is the upper left-hand corner of the display as viewed by the user.
        /// </summary>
        [XmlElement("x")]
        public LengthPerLengthMeasure X { get; set; }
        /// <summary>
        /// Defines the relative from-top-to-bottom location on a display screen. The display origin (0,0) is the upper left-hand corner of the display as viewed by the user.
        /// </summary>
        [XmlElement("y")]
        public LengthPerLengthMeasure Y { get; set; }
        /// <summary>
        /// Defines the relative from-front-to-back location in a 3D system. The unrotated display origin (0,0) is the upper left-hand corner of the display as viewed by the user. The "3D picture" may be rotated on the 2d display.
        /// </summary>
        [XmlElement("z")]
        public LengthPerLengthMeasure Z { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Defines expected properties of a facility represented by a unit.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowExpectedUnitProperty", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Defines expected properties of a facility represented by a unit.")]
    public partial class ProductFlowExpectedUnitProperty : Object 
    {

        /// <summary>
        /// The expected kind of facility property. Each property is documented to have values of a particular type.
        /// </summary>
        [XmlElement("property")]
        public FacilityParameter Property { get; set; }
		/// <summary>
        /// The expected kind of qualifier of the property.
        /// </summary>
        [XmlElement("qualifier")]
        public List<FlowQualifier> Qualifier { get; set; }
        /// <summary>
        /// A descriptive remark associated with this property.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Unit Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowUnit", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Unit Component Schema.")]
    public partial class ProductFlowUnit : Object 
    {

        /// <summary>
        /// The name of the Product Flow Unit within the context of the Product Flow Network.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The name of a network plan. This indicates a planned unit. All child network components must all be planned and be part of the same plan. The parent network must either contain the plan (i.e., be an actual) or be part of the same plan. Not specified indicates an actual unit.
        /// </summary>
        [XmlElement("planName")]
        public String PlanName { get; set; }
        /// <summary>
        /// A pointer to the network representing the internal behavior of this unit. The names of the external ports on the internal network must match the names of the ports on this unit. That is they are logically the same ports.
        /// </summary>
        [XmlElement("internalNetwork")]
        public RefNameString InternalNetwork { get; set; }
        /// <summary>
        /// The name of the facility for which this Product Flow Unit describes fluid flow connecton behavior. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facility")]
        public FacilityIdentifierStruct Facility { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility this named facility. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent1")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent1 { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility of facilityParent1. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent2")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent2 { get; set; }
		/// <summary>
        /// An alternatative name of a facility. This is generally unique within a naming system. The above contextually unique name (that is, within the context of a parent) should also be listed as an alias.
        /// </summary>
        [XmlElement("facilityAlias")]
        public List<NameStruct> FacilityAlias { get; set; }
		/// <summary>
        /// The name and type of a facility whose context is relevant to the represented facility.
        /// </summary>
        [XmlElement("contextFacility")]
        public List<FacilityIdentifierStruct> ContextFacility { get; set; }
		/// <summary>
        /// Defines an expected property of the facility represented by this unit.
        /// </summary>
        [XmlElement("expectedProperty")]
        public List<ProductFlowExpectedUnitProperty> ExpectedProperty { get; set; }
        /// <summary>
        /// Defines the relative coordinate of the unit on a display screen. This is not intended for detailed diagrams. Rather it is intended to allow different applications to present a user view which has a consistent layout.
        /// </summary>
        [XmlElement("relativeCoordinate")]
        public RelativeCoordinate RelativeCoordinate { get; set; }
		/// <summary>
        /// An inlet or outlet port associated with this unit. If there is an internal network then the name of this port must match the name of an external port for that network. Any properties (e.g., volume, pressure, temperature) that are assigned to this port are inherently assigned to the corresponding external port on the internal network. That is, the ports are logically the same port. Similar to a node, there is no pressure drop across a port. Also similar to a node, conservation of mass exists across the port and the flow direction across the port can change over time if the relative pressures across connected units change.
        /// </summary>
        [XmlElement("port")]
        public List<ProductFlowPort> Port { get; set; }
        /// <summary>
        /// A descriptive remark associated with this unit.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// WITSML - Product Flow Network External Port Component Schema.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowlExternalPort", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Product Flow Network External Port Component Schema.")]
    public partial class ProductFlowlExternalPort : Object 
    {

        /// <summary>
        /// The name of the external port within the context of the current Product Flow Network.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// Defines whether this port is an inlet or outlet. Note that this is a nominal intended direction.
        /// </summary>
        [XmlElement("direction")]
        public ProductFlowPortType Direction { get; set; }
        /// <summary>
        /// True ("true" or "1") indicates that the port is an exposed internal port and cannot be used in a connection external to the network. False ("false" or "0") or not given indicates a normal port.
        /// </summary>
        [XmlElement("exposed")]
        public Boolean? Exposed {
            get {
                return exposedField;
            } 
            set { 
                exposedField = value;
                this.ExposedSpecified = true;
            }
        }

        private Boolean? exposedField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ExposedSpecified { get; set; }
        /// <summary>
        /// Defines the internal node to which this external port is connected. All ports (whether internal or external) that are connected to a node with the same name are connected to each other. Node names are unique to each network. The purpose of the external port is to provide input to or output from the internal network except when the port is an "exposed" port. The purpose of an exposed port is to allow the properties of the port to be seen external to the network. For an exposed port, the connection points to the associated port. 
        /// </summary>
        [XmlElement("connectedNode")]
        public String ConnectedNode { get; set; }
        /// <summary>
        /// A descriptive remark about the port.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The non-contextual content of a WITSML Product Flow Network object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowNetwork", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The non-contextual content of a WITSML Product Flow Network object.")]
    public partial class ProductFlowNetwork : Object 
    {

        /// <summary>
        /// The name of the Product Flow Network. This must be unique within the context of the overall Product Flow Model.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The name of a network plan. This indicates a planned network. All child network components must all be planned and be part of the same plan. The parent network must either contain the plan (i.e., be an actual) or be part of the same plan. Not specified indicates an actual network.
        /// </summary>
        [XmlElement("planName")]
        public String PlanName { get; set; }
        /// <summary>
        /// A pointer to the network containing the unit that this network represents. That is, the Unit must exist in a different Network. If a parent network is not specified then the network represents the model. A model should only be represented by one network. The model network represents the overall installation. All other networks represent internal detail and should not be referenced from outside the model. The external ports on the model network represent the external ports to the overall Product Flow Model. A pointer to an external port on the Product Flow Model does not require the name of the model network because it is redundant to knowledge of the model name (i.e., there is a one-to-one correspondence).
        /// </summary>
        [XmlElement("parentNetwork")]
        public RefNameString PluggedAndAbandonedrentNetwork { get; set; }
        /// <summary>
        /// DEPRECATED. Use parentNetwork for all new work. A pointer to the Flow Unit that this network represents. The Unit must exist in a different Network. If a unit is not specified then the network represents the model. A model should only be represented by one network. The model network represents the overall installation. All other networks represent internal detail and should not be referenced from outside this model. The external ports on the model network represent the external ports to the overall Product Flow Model. A pointer to an external port on the Product Flow Model does not require the name of the model network because it is redundant to knowledge of the model name (i.e., there is a one-to-one correspondence). A unit model defines the internal behavior of a Flow Unit.
        /// </summary>
        [Obsolete()]
        [XmlElement("representedUnit")]
        public RefNameString RepresentedUnit { get; set; }
        /// <summary>
        /// A descriptive remark about the network.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// An external port. This exposes an internal node for the purpose of allowing connections to the internal behavior of the network. Networks that represent a Flow Unit should always have external ports. If this network represents a Unit then the name of the external port must match the name of a port on the Unit (i.e., they are logically the same port).
        /// </summary>
        [XmlElement("port")]
        public List<ProductFlowlExternalPort> Port { get; set; }
		/// <summary>
        /// A flow behavior for one unit. Within this context, a unit represents a usage of equipment for some purpose. The unit is generally identified by its function rather than the actual equipment used to realize the function. A unit might represent something complex like a field or separator or something simple like a valve or pump.
        /// </summary>
        [XmlElement("unit")]
        public List<ProductFlowUnit> Unit { get; set; }
		/// <summary>
        /// Documents that a change occurred at a particular time.
        /// </summary>
        [XmlElement("changeLog")]
        public List<ProductFlowChangeLog> ChangeLog { get; set; }
		/// <summary>
        /// Defines the existance of a planned network which is a variant of this network beginning at a specified point in time. Any changes to the actual network after that time do not affect the plan.
        /// </summary>
        [XmlElement("plan")]
        public List<ProductFlowNetworkPlan> Plan { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A reference to an external port within a different Product Flow Model. This value represents a foreign key from one element to another.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_productFlowExternalReference", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A reference to an external port within a different Product Flow Model. This value represents a foreign key from one element to another.")]
    public partial class ProductFlowExternalReference : Object 
    {

        /// <summary>
        /// A pointer to the external port in the network that represents the current Model. This is the port to which a different model is being connected.
        /// </summary>
        [XmlElement("port")]
        public RefNameString Port { get; set; }
        /// <summary>
        /// A pointer to the external port within the connected Model. This is the port on a different model to which the port on this model is connected.
        /// </summary>
        [XmlElement("connectedPort")]
        public RefNameString ConnectedPort { get; set; }
        /// <summary>
        /// A pointer to the Product Flow Model that contains the connected port.
        /// </summary>
        [XmlElement("connectedModel")]
        public RefNameString ConnectedModel { get; set; }
        /// <summary>
        /// The name of the facility that is represented by the connected model. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("connectedInstallation")]
        public FacilityIdentifierStruct ConnectedInstallation { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    /// <summary>
    /// The non-contextual content of a WITSML Product Flow Model object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_productFlowModel", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The non-contextual content of a WITSML Product Flow Model object.")]
    public partial class ProductFlowModel : Object 
    {

        /// <summary>
        /// The name of the Product Flow Model.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The name of the facility which is represented by this model. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("installation")]
        public FacilityIdentifierStruct Installation { get; set; }
		/// <summary>
        /// The name and type of a facility whose context is relevant to the represented installation.
        /// </summary>
        [XmlElement("contextFacility")]
        public List<FacilityIdentifierStruct> ContextFacility { get; set; }
        /// <summary>
        /// The date and time of the start of validity for this model.
        /// </summary>
        [XmlElement("dTimStart")]
        public DateTime? DateTimeStart {
            get {
                return dTimStartField;
            } 
            set { 
                dTimStartField = value;
                this.DateTimeStartSpecified = true;
            }
        }

        private DateTime? dTimStartField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeStartSpecified { get; set; }
        /// <summary>
        /// The date and time of the termination of validity for this model.
        /// </summary>
        [XmlElement("dTimEnd")]
        public DateTime? DateTimeEnd {
            get {
                return dTimEndField;
            } 
            set { 
                dTimEndField = value;
                this.DateTimeEndSpecified = true;
            }
        }

        private DateTime? dTimEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeEndSpecified { get; set; }
        /// <summary>
        /// The time for which "currently existing" data is desired from the network. All connections (and related data) existing at this time (i.e. start and end bracket this value) will will be returned if requested. The existence time is a server query parameter. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("existenceTime")]
        public EndpointQualifiedDateTime ExistenceTime { get; set; }
        /// <summary>
        /// The minimum time index contained within the report. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMin")]
        public EndpointQualifiedDateTime DateTimeMin { get; set; }
        /// <summary>
        /// The maximum time index contained within the report. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMax")]
        public EndpointQualifiedDateTime DateTimeMax { get; set; }
		/// <summary>
        /// Defines the external port in another Product Flow Model to which an external port in this model is connected. An external port should be connected to an external port with the opposite direction. The connected external port must be in another Product Flow Model. These connections should always be defined on a one-to-one basis. For example, if a facility may receive input from multiple other facilities then a separate input port should be defined for each of those facilities. This allows any question about mass balancing to be contained within each individual model. The external port name must match the name of an external port on the network that represents this model.
        /// </summary>
        [XmlElement("externalConnect")]
        public List<ProductFlowExternalReference> ExternalConnect { get; set; }
		/// <summary>
        /// The description of one named network within this model. Each model is self contained but may reference other newtorks for defining internal detail. One of the networks must represent this model.
        /// </summary>
        [XmlElement("network")]
        public List<ProductFlowNetwork> Network { get; set; }
        /// <summary>
        /// A descriptive remark about the model.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    /// <summary>
    /// This class represents the obj_fluidSample xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_fluidSample", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the obj_fluidSample xsd type.")]
    public partial class FluidSample : Object 
    {

        /// <summary>
        /// The name of the Fluid Sample.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("sampleBottle")]
        public String SampleBottle { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("sampleType")]
        public FluidSampleKind SampleType {
            get {
                return sampleTypeField;
            } 
            set { 
                sampleTypeField = value;
                this.SampleTypeSpecified = true;
            }
        }

        private FluidSampleKind sampleTypeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SampleTypeSpecified { get; set; }
        /// <summary>
        /// The name of the facility from which the sample was acquired. The name can be qualified by a naming system. This also defines the kind of facility. Common facilities are wells, wellbores within a well, completions within a well.
        /// </summary>
        [XmlElement("facility")]
        public FacilityIdentifierStruct Facility { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility. For example, if name represents a completion, then facilityParent1 would represent the name of the well within which name was unique. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent1")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent1 { get; set; }
        /// <summary>
        /// For facilities whose name is unique within the context of another facility, the name of the parent facility of parent1. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("facilityParent2")]
        public FacilityIdentifierStruct FacilityPluggedAndAbandonedrent2 { get; set; }
		/// <summary>
        /// An alternatative name of a facility. This is generally unique within a naming system. The above contextually unique name (that is, within the context of a parent) should also be listed as an alias.
        /// </summary>
        [XmlElement("facilityAlias")]
        public List<NameStruct> FacilityAlias { get; set; }
        /// <summary>
        /// The kind of test which acquired the sample.
        /// </summary>
        [XmlElement("testKind")]
        public FluidSampleTestAcquisition TestKind {
            get {
                return testKindField;
            } 
            set { 
                testKindField = value;
                this.TestKindSpecified = true;
            }
        }

        private FluidSampleTestAcquisition testKindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestKindSpecified { get; set; }
        /// <summary>
        /// The measured depth of the test in a wellbore.
        /// </summary>
        [XmlElement("testMD")]
        public MeasuredDepthCoord TestMD { get; set; }
        /// <summary>
        /// The test identifier.
        /// </summary>
        [XmlElement("testId")]
        public String TestId { get; set; }
        /// <summary>
        /// The test run number (e.g., for an RFT)
        /// </summary>
        [XmlElement("testRun")]
        public String TestRun { get; set; }
        /// <summary>
        /// The name of the company which ran the test.
        /// </summary>
        [XmlElement("testProvider")]
        public String TestProvider { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("reservoirFluidType")]
        public ReservoirFluidKind ReservoirFluidType {
            get {
                return reservoirFluidTypeField;
            } 
            set { 
                reservoirFluidTypeField = value;
                this.ReservoirFluidTypeSpecified = true;
            }
        }

        private ReservoirFluidKind reservoirFluidTypeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ReservoirFluidTypeSpecified { get; set; }
		/// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("")]
        public DateTime? AcquisitionDate {
            get {
                return acquisitionDateField;
            } 
            set { 
                acquisitionDateField = value;
                this.AcquisitionDateSpecified = true;
            }
        }

        private DateTime? acquisitionDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AcquisitionDateSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("acquisitionMD")]
        public MeasuredDepthCoord AcquisitionMD { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("acquisitionPressure")]
        public PressureMeasure AcquisitionPressure { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("acquisitionTemperature")]
        public ThermodynamicTemperatureMeasure AcquisitionTemperature { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("acquisitionGORStd")]
        public StandardVolumePerStandardVolumeMeasure AcquisitionGORStd { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("sampleDisposition")]
        public String SampleDisposition { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("representative")]
        public Boolean? Representative {
            get {
                return representativeField;
            } 
            set { 
                representativeField = value;
                this.RepresentativeSpecified = true;
            }
        }

        private Boolean? representativeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean RepresentativeSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultContaminant xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultContaminant", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultContaminant xsd type.")]
    public partial class FluidResultContaminant : Object 
    {

        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("contaminantKind")]
        public FluidContaminant ContaminantKind { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("volumePercent")]
        public VolumePerVolumeMeasurePercent VolumePercent { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultSeparatorTestStep xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultSeparatorTestStep", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultSeparatorTestStep xsd type.")]
    public partial class FluidResultSeparatorTestStep : Object 
    {

        
        [XmlElement("stepNumber")]
        public Int16? StepNumber {
            get {
                return stepNumberField;
            } 
            set { 
                stepNumberField = value;
                this.StepNumberSpecified = true;
            }
        }

        private Int16? stepNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StepNumberSpecified { get; set; }
        
        [XmlElement("stepTemperature")]
        public ThermodynamicTemperatureMeasure StepTemperature { get; set; }
        
        [XmlElement("stepPressure")]
        public PressureMeasure StepPressure { get; set; }
        
        [XmlElement("bubblePointPressure")]
        public PressureMeasure BubblePointPressure {
            get {
                return bubblePointPressureField;
            } 
            set { 
                if (retrogradeDewPointPressureFieldSpecified) throw new Exception("Cannot set property BubblePointPressure when property RetrogradeDewPointPressure is already set");
                bubblePointPressureField = value;
                bubblePointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure bubblePointPressureField; 
        private bool bubblePointPressureFieldSpecified = false; 

        
        [XmlElement("retrogradeDewPointPressure")]
        public PressureMeasure RetrogradeDewPointPressure {
            get {
                return retrogradeDewPointPressureField;
            } 
            set { 
                if (bubblePointPressureFieldSpecified) throw new Exception("Cannot set property RetrogradeDewPointPressure when property BubblePointPressure is already set");
                retrogradeDewPointPressureField = value;
                retrogradeDewPointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure retrogradeDewPointPressureField; 
        private bool retrogradeDewPointPressureFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType6? ItemElementName { get; set; }
        
        [XmlElement("oilAPIGravity")]
        public DensityMeasure OilAPIGravity {
            get {
                return oilAPIGravityField;
            } 
            set { 
                if (oilSpecificGravityFieldSpecified) throw new Exception("Cannot set property OilAPIGravity when property OilSpecificGravity is already set");
                oilAPIGravityField = value;
                oilAPIGravityFieldSpecified = true;
            }
        }

        private DensityMeasure oilAPIGravityField; 
        private bool oilAPIGravityFieldSpecified = false; 

        
        [XmlElement("oilSpecificGravity")]
        public Double OilSpecificGravity {
            get {
                return oilSpecificGravityField;
            } 
            set { 
                if (oilAPIGravityFieldSpecified) throw new Exception("Cannot set property OilSpecificGravity when property OilAPIGravity is already set");
                oilSpecificGravityField = value;
                oilSpecificGravityFieldSpecified = true;
            }
        }

        private Double oilSpecificGravityField; 
        private bool oilSpecificGravityFieldSpecified = false; 


        
        [XmlElement("oilMassDensity")]
        public DensityMeasure OilMassDensity { get; set; }
        
        [XmlElement("oilFormationVolumeFactorStd")]
        public VolumePerStandardVolumeMeasure OilFormationVolumeFactorStd { get; set; }
        
        [XmlElement("oilViscosity")]
        public DynamicViscosityMeasure OilViscosity { get; set; }
        
        [XmlElement("oilVolume")]
        public VolumeMeasure OilVolume {
            get {
                return oilVolumeField;
            } 
            set { 
                if (stageSeparatorGORStdFieldSpecified) throw new Exception("Cannot set property OilVolume when property StageSeparatorGORStd is already set");
                if (oilShrinkageFactorFieldSpecified) throw new Exception("Cannot set property OilVolume when property OilShrinkageFactor is already set");
                oilVolumeField = value;
                oilVolumeFieldSpecified = true;
            }
        }

        private VolumeMeasure oilVolumeField; 
        private bool oilVolumeFieldSpecified = false; 

        
        [XmlElement("gasVolume")]
        public StandardVolumeMeasure GasVolume {
            get {
                return gasVolumeField;
            } 
            set { 
                if (stageSeparatorGORStdFieldSpecified) throw new Exception("Cannot set property GasVolume when property StageSeparatorGORStd is already set");
                if (oilShrinkageFactorFieldSpecified) throw new Exception("Cannot set property GasVolume when property OilShrinkageFactor is already set");
                gasVolumeField = value;
                gasVolumeFieldSpecified = true;
            }
        }

        private StandardVolumeMeasure gasVolumeField; 
        private bool gasVolumeFieldSpecified = false; 

        
        [XmlElement("oilShrinkageFactor")]
        public VolumePerVolumeMeasure OilShrinkageFactor {
            get {
                return oilShrinkageFactorField;
            } 
            set { 
                if (oilVolumeFieldSpecified) throw new Exception("Cannot set property OilShrinkageFactor when property OilVolume is already set");
                if (gasVolumeFieldSpecified) throw new Exception("Cannot set property OilShrinkageFactor when property GasVolume is already set");
                oilShrinkageFactorField = value;
                oilShrinkageFactorFieldSpecified = true;
            }
        }

        private VolumePerVolumeMeasure oilShrinkageFactorField; 
        private bool oilShrinkageFactorFieldSpecified = false; 

        
        [XmlElement("stageSeparatorGORStd")]
        public StandardVolumePerVolumeMeasure StageSeparatorGORStd {
            get {
                return stageSeparatorGORStdField;
            } 
            set { 
                if (oilVolumeFieldSpecified) throw new Exception("Cannot set property StageSeparatorGORStd when property OilVolume is already set");
                if (gasVolumeFieldSpecified) throw new Exception("Cannot set property StageSeparatorGORStd when property GasVolume is already set");
                stageSeparatorGORStdField = value;
                stageSeparatorGORStdFieldSpecified = true;
            }
        }

        private StandardVolumePerVolumeMeasure stageSeparatorGORStdField; 
        private bool stageSeparatorGORStdFieldSpecified = false; 


        
        [XmlElement("correctedStageSeparatorGORStd")]
        public StandardVolumePerStandardVolumeMeasure CorrectedStageSeparatorGORStd { get; set; }
        
        [XmlElement("cumulativeStockTankGORStd")]
        public StandardVolumePerStandardVolumeMeasure CumulativeStockTankGORStd { get; set; }
        
        [XmlElement("solutionGORStd")]
        public StandardVolumePerStandardVolumeMeasure SolutionGORStd { get; set; }
        
        [XmlElement("gasMolecularWeight")]
        public Double? GasMolecularWeight {
            get {
                return gasMolecularWeightField;
            } 
            set { 
                gasMolecularWeightField = value;
                this.GasMolecularWeightSpecified = true;
            }
        }

        private Double? gasMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasMolecularWeightSpecified { get; set; }
        
        [XmlElement("gasGravity")]
        public Double? GasGravity {
            get {
                return gasGravityField;
            } 
            set { 
                gasGravityField = value;
                this.GasGravitySpecified = true;
            }
        }

        private Double? gasGravityField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasGravitySpecified { get; set; }
        
        [XmlElement("gasMassDensity")]
        public DensityMeasure GasMassDensity { get; set; }
        
        [XmlElement("gasZFactor")]
        public Double? GasZFactor {
            get {
                return gasZFactorField;
            } 
            set { 
                gasZFactorField = value;
                this.GasZFactorSpecified = true;
            }
        }

        private Double? gasZFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasZFactorSpecified { get; set; }
        
        [XmlElement("gasViscosity")]
        public DynamicViscosityMeasure GasViscosity { get; set; }
        
        [XmlElement("residualAPIGravity")]
        public DensityMeasure ResidualAPIGravity { get; set; }
        
        [XmlElement("comment")]
        public String Comment { get; set; }
        
        [XmlElement("reservoir")]
        public Boolean Reservoir {
            get {
                return reservoirField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Reservoir when property StockTank is already set");
                reservoirField = value;
                reservoirFieldSpecified = true;
            }
        }

        private Boolean reservoirField; 
        private bool reservoirFieldSpecified = false; 

        
        [XmlElement("saturated")]
        public Boolean Saturated {
            get {
                return saturatedField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Saturated when property StockTank is already set");
                saturatedField = value;
                saturatedFieldSpecified = true;
            }
        }

        private Boolean saturatedField; 
        private bool saturatedFieldSpecified = false; 

        
        [XmlElement("stockTank")]
        public FluidResultStockTank StockTank {
            get {
                return stockTankField;
            } 
            set { 
                if (saturatedFieldSpecified) throw new Exception("Cannot set property StockTank when property Saturated is already set");
                if (reservoirFieldSpecified) throw new Exception("Cannot set property StockTank when property Reservoir is already set");
                stockTankField = value;
                stockTankFieldSpecified = true;
            }
        }

        private FluidResultStockTank stockTankField; 
        private bool stockTankFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<Items1ChoiceType1> Items1ElementName { get; set; }
		
        [XmlElement("vaporComposition")]
        public List<FluidResultPhaseComposition> VaporComposition { get; set; }
		
        [XmlElement("liquidComposition")]
        public List<FluidResultPhaseComposition> LiquidComposition { get; set; }
		
        [XmlElement("compositeComposition")]
        public List<FluidResultCompositeComposition> CompositeComposition { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultStockTank xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultStockTank", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultStockTank xsd type.")]
    public partial class FluidResultStockTank : Object 
    {

        
        [XmlElement("temperature")]
        public ThermodynamicTemperatureMeasure Temperature { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultPhaseComposition xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultPhaseComposition", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultPhaseComposition xsd type.")]
    public partial class FluidResultPhaseComposition : Object 
    {

        
        [XmlElement("componentName")]
        public String ComponentName { get; set; }
        
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        
        [XmlElement("molePercent")]
        public MolarFractionMeasurePercent MolePercent { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultCompositeComposition xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultCompositeComposition", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultCompositeComposition xsd type.")]
    public partial class FluidResultCompositeComposition : Object 
    {

        
        [XmlElement("componentName")]
        public String ComponentName { get; set; }
        
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        
        [XmlElement("molePercent")]
        public MolarFractionMeasurePercent MolePercent { get; set; }
        
        [XmlElement("kValue")]
        public Double? KValue {
            get {
                return kValueField;
            } 
            set { 
                kValueField = value;
                this.KValueSpecified = true;
            }
        }

        private Double? kValueField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean KValueSpecified { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultSeparatorTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultSeparatorTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultSeparatorTest xsd type.")]
    public partial class FluidResultSeparatorTest : Object 
    {

        
        [XmlElement("testNumber")]
        public Int16? TestNumber {
            get {
                return testNumberField;
            } 
            set { 
                testNumberField = value;
                this.TestNumberSpecified = true;
            }
        }

        private Int16? testNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestNumberSpecified { get; set; }
        
        [XmlElement("shrinkageReference")]
        public FluidResultVolumeReference ShrinkageReference { get; set; }
		
        [XmlElement("separatorTestStep")]
        public List<FluidResultSeparatorTestStep> SeparatorTestStep { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultVolumeReference xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultVolumeReference", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultVolumeReference xsd type.")]
    public partial class FluidResultVolumeReference : Object 
    {

        
        [XmlElement("kind")]
        public VolumeReferenceKind Kind { get; set; }
        
        [XmlElement("referenceVolume")]
        public VolumeMeasure ReferenceVolume { get; set; }
        
        [XmlElement("comment")]
        public String Comment { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultTransportTestStep xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultTransportTestStep", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultTransportTestStep xsd type.")]
    public partial class FluidResultTransportTestStep : Object 
    {

        
        [XmlElement("stepNumber")]
        public Int16? StepNumber {
            get {
                return stepNumberField;
            } 
            set { 
                stepNumberField = value;
                this.StepNumberSpecified = true;
            }
        }

        private Int16? stepNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StepNumberSpecified { get; set; }
        
        [XmlElement("stepTemperature")]
        public ThermodynamicTemperatureMeasure StepTemperature { get; set; }
        
        [XmlElement("stepPressure")]
        public PressureMeasure StepPressure { get; set; }
        
        [XmlElement("retrogradeDewPointPressure")]
        public PressureMeasure RetrogradeDewPointPressure {
            get {
                return retrogradeDewPointPressureField;
            } 
            set { 
                if (bubblePointPressureFieldSpecified) throw new Exception("Cannot set property RetrogradeDewPointPressure when property BubblePointPressure is already set");
                retrogradeDewPointPressureField = value;
                retrogradeDewPointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure retrogradeDewPointPressureField; 
        private bool retrogradeDewPointPressureFieldSpecified = false; 

        
        [XmlElement("bubblePointPressure")]
        public PressureMeasure BubblePointPressure {
            get {
                return bubblePointPressureField;
            } 
            set { 
                if (retrogradeDewPointPressureFieldSpecified) throw new Exception("Cannot set property BubblePointPressure when property RetrogradeDewPointPressure is already set");
                bubblePointPressureField = value;
                bubblePointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure bubblePointPressureField; 
        private bool bubblePointPressureFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType5? ItemElementName { get; set; }
        
        [XmlElement("dewPointPressure")]
        public PressureMeasure DewPointPressure { get; set; }
        
        [XmlElement("cloudPoint")]
        public ThermodynamicTemperatureMeasure CloudPoint { get; set; }
        
        [XmlElement("pourPoint")]
        public ThermodynamicTemperatureMeasure PourPoint { get; set; }
        
        [XmlElement("oilMolecularWeight")]
        public Double? OilMolecularWeight {
            get {
                return oilMolecularWeightField;
            } 
            set { 
                oilMolecularWeightField = value;
                this.OilMolecularWeightSpecified = true;
            }
        }

        private Double? oilMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean OilMolecularWeightSpecified { get; set; }
        
        [XmlElement("oilSpecificGravity")]
        public Double OilSpecificGravity {
            get {
                return oilSpecificGravityField;
            } 
            set { 
                if (oilAPIGravityFieldSpecified) throw new Exception("Cannot set property OilSpecificGravity when property OilAPIGravity is already set");
                oilSpecificGravityField = value;
                oilSpecificGravityFieldSpecified = true;
            }
        }

        private Double oilSpecificGravityField; 
        private bool oilSpecificGravityFieldSpecified = false; 

        
        [XmlElement("oilAPIGravity")]
        public DensityMeasure OilAPIGravity {
            get {
                return oilAPIGravityField;
            } 
            set { 
                if (oilSpecificGravityFieldSpecified) throw new Exception("Cannot set property OilAPIGravity when property OilSpecificGravity is already set");
                oilAPIGravityField = value;
                oilAPIGravityFieldSpecified = true;
            }
        }

        private DensityMeasure oilAPIGravityField; 
        private bool oilAPIGravityFieldSpecified = false; 


        
        [XmlElement("oilMassDensity")]
        public DensityMeasure OilMassDensity { get; set; }
        
        [XmlElement("oilCompressibility")]
        public CompressibilityMeasure OilCompressibility { get; set; }
        
        [XmlElement("oilViscosity")]
        public DynamicViscosityMeasure OilViscosity { get; set; }
        
        [XmlElement("oilThermalConductivity")]
        public ThermalConductivityMeasure OilThermalConductivity { get; set; }
        
        [XmlElement("gasMolecularWeight")]
        public Double? GasMolecularWeight {
            get {
                return gasMolecularWeightField;
            } 
            set { 
                gasMolecularWeightField = value;
                this.GasMolecularWeightSpecified = true;
            }
        }

        private Double? gasMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasMolecularWeightSpecified { get; set; }
        
        [XmlElement("gasGravity")]
        public Double? GasGravity {
            get {
                return gasGravityField;
            } 
            set { 
                gasGravityField = value;
                this.GasGravitySpecified = true;
            }
        }

        private Double? gasGravityField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasGravitySpecified { get; set; }
        
        [XmlElement("gasMassDensity")]
        public DensityMeasure GasMassDensity { get; set; }
        
        [XmlElement("gasZFactor")]
        public Double? GasZFactor {
            get {
                return gasZFactorField;
            } 
            set { 
                gasZFactorField = value;
                this.GasZFactorSpecified = true;
            }
        }

        private Double? gasZFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasZFactorSpecified { get; set; }
        
        [XmlElement("gasCompressibility")]
        public CompressibilityMeasure GasCompressibility { get; set; }
        
        [XmlElement("gasViscosity")]
        public DynamicViscosityMeasure GasViscosity { get; set; }
        
        [XmlElement("gasThermalConductivity")]
        public ThermalConductivityMeasure GasThermalConductivity { get; set; }
        
        [XmlElement("gasHeatingValue")]
        public ModulusOfCompressionMeasure GasHeatingValue { get; set; }
        
        [XmlElement("comment")]
        public String Comment { get; set; }
        
        [XmlElement("reservoir")]
        public Boolean Reservoir {
            get {
                return reservoirField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Reservoir when property StockTank is already set");
                reservoirField = value;
                reservoirFieldSpecified = true;
            }
        }

        private Boolean reservoirField; 
        private bool reservoirFieldSpecified = false; 

        
        [XmlElement("saturated")]
        public Boolean Saturated {
            get {
                return saturatedField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Saturated when property StockTank is already set");
                saturatedField = value;
                saturatedFieldSpecified = true;
            }
        }

        private Boolean saturatedField; 
        private bool saturatedFieldSpecified = false; 

        
        [XmlElement("stockTank")]
        public FluidResultStockTank StockTank {
            get {
                return stockTankField;
            } 
            set { 
                if (saturatedFieldSpecified) throw new Exception("Cannot set property StockTank when property Saturated is already set");
                if (reservoirFieldSpecified) throw new Exception("Cannot set property StockTank when property Reservoir is already set");
                stockTankField = value;
                stockTankFieldSpecified = true;
            }
        }

        private FluidResultStockTank stockTankField; 
        private bool stockTankFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType5> ItemsElementName { get; set; }
		
        [XmlElement("vaporComposition")]
        public List<FluidResultPhaseComposition> VaporComposition { get; set; }
		
        [XmlElement("liquidComposition")]
        public List<FluidResultPhaseComposition> LiquidComposition { get; set; }
		
        [XmlElement("compositeComposition")]
        public List<FluidResultCompositeComposition> CompositeComposition { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultTransportPropertiesTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultTransportPropertiesTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultTransportPropertiesTest xsd type.")]
    public partial class FluidResultTransportPropertiesTest : Object 
    {

        
        [XmlElement("testNumber")]
        public Int16? TestNumber {
            get {
                return testNumberField;
            } 
            set { 
                testNumberField = value;
                this.TestNumberSpecified = true;
            }
        }

        private Int16? testNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestNumberSpecified { get; set; }
		
        [XmlElement("transportTestStep")]
        public List<FluidResultTransportTestStep> TransportTestStep { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultJCurveTestStep xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultJCurveTestStep", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultJCurveTestStep xsd type.")]
    public partial class FluidResultJCurveTestStep : Object 
    {

        
        [XmlElement("stepNumber")]
        public Int16? StepNumber {
            get {
                return stepNumberField;
            } 
            set { 
                stepNumberField = value;
                this.StepNumberSpecified = true;
            }
        }

        private Int16? stepNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StepNumberSpecified { get; set; }
        
        [XmlElement("stepPressure")]
        public PressureMeasure StepPressure { get; set; }
        
        [XmlElement("oilViscosity")]
        public DynamicViscosityMeasure OilViscosity { get; set; }
        
        [XmlElement("liquidVolume")]
        public VolumeMeasure LiquidVolume {
            get {
                return liquidVolumeField;
            } 
            set { 
                if (liquidDropoutPercentFieldSpecified) throw new Exception("Cannot set property LiquidVolume when property LiquidDropoutPercent is already set");
                liquidVolumeField = value;
                liquidVolumeFieldSpecified = true;
            }
        }

        private VolumeMeasure liquidVolumeField; 
        private bool liquidVolumeFieldSpecified = false; 

        
        [XmlElement("liquidDropoutPercent")]
        public VolumePerVolumeMeasurePercent LiquidDropoutPercent {
            get {
                return liquidDropoutPercentField;
            } 
            set { 
                if (liquidVolumeFieldSpecified) throw new Exception("Cannot set property LiquidDropoutPercent when property LiquidVolume is already set");
                liquidDropoutPercentField = value;
                liquidDropoutPercentFieldSpecified = true;
            }
        }

        private VolumePerVolumeMeasurePercent liquidDropoutPercentField; 
        private bool liquidDropoutPercentFieldSpecified = false; 


        
        [XmlElement("gasMolecularWeight")]
        public Double? GasMolecularWeight {
            get {
                return gasMolecularWeightField;
            } 
            set { 
                gasMolecularWeightField = value;
                this.GasMolecularWeightSpecified = true;
            }
        }

        private Double? gasMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasMolecularWeightSpecified { get; set; }
        
        [XmlElement("gasGravity")]
        public Double? GasGravity {
            get {
                return gasGravityField;
            } 
            set { 
                gasGravityField = value;
                this.GasGravitySpecified = true;
            }
        }

        private Double? gasGravityField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasGravitySpecified { get; set; }
        
        [XmlElement("gasFormationVolumeFactorStd")]
        public VolumePerStandardVolumeMeasure GasFormationVolumeFactorStd { get; set; }
        
        [XmlElement("gasZFactor")]
        public Double? GasZFactor {
            get {
                return gasZFactorField;
            } 
            set { 
                gasZFactorField = value;
                this.GasZFactorSpecified = true;
            }
        }

        private Double? gasZFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasZFactorSpecified { get; set; }
        
        [XmlElement("gasViscosity")]
        public DynamicViscosityMeasure GasViscosity { get; set; }
        
        [XmlElement("cumulativeGasProducedVolume")]
        public StandardVolumeMeasure CumulativeGasProducedVolume {
            get {
                return cumulativeGasProducedVolumeField;
            } 
            set { 
                if (cumulativeGasProducedRatioStdFieldSpecified) throw new Exception("Cannot set property CumulativeGasProducedVolume when property CumulativeGasProducedRatioStd is already set");
                cumulativeGasProducedVolumeField = value;
                cumulativeGasProducedVolumeFieldSpecified = true;
            }
        }

        private StandardVolumeMeasure cumulativeGasProducedVolumeField; 
        private bool cumulativeGasProducedVolumeFieldSpecified = false; 

        
        [XmlElement("cumulativeGasProducedRatioStd")]
        public StandardVolumePerStandardVolumeMeasure CumulativeGasProducedRatioStd {
            get {
                return cumulativeGasProducedRatioStdField;
            } 
            set { 
                if (cumulativeGasProducedVolumeFieldSpecified) throw new Exception("Cannot set property CumulativeGasProducedRatioStd when property CumulativeGasProducedVolume is already set");
                cumulativeGasProducedRatioStdField = value;
                cumulativeGasProducedRatioStdFieldSpecified = true;
            }
        }

        private StandardVolumePerStandardVolumeMeasure cumulativeGasProducedRatioStdField; 
        private bool cumulativeGasProducedRatioStdFieldSpecified = false; 


        
        [XmlElement("condensateYieldVolumeRatio1Std")]
        public VolumePerStandardVolumeMeasure CondensateYieldVolumeRatio1Std { get; set; }
        
        [XmlElement("condensateYieldVolumeRatio2Std")]
        public VolumePerStandardVolumeMeasure CondensateYieldVolumeRatio2Std { get; set; }
        
        [XmlElement("comment")]
        public String Comment { get; set; }
        
        [XmlElement("reservoir")]
        public Boolean Reservoir {
            get {
                return reservoirField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Reservoir when property StockTank is already set");
                reservoirField = value;
                reservoirFieldSpecified = true;
            }
        }

        private Boolean reservoirField; 
        private bool reservoirFieldSpecified = false; 

        
        [XmlElement("saturated")]
        public Boolean Saturated {
            get {
                return saturatedField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Saturated when property StockTank is already set");
                saturatedField = value;
                saturatedFieldSpecified = true;
            }
        }

        private Boolean saturatedField; 
        private bool saturatedFieldSpecified = false; 

        
        [XmlElement("stockTank")]
        public FluidResultStockTank StockTank {
            get {
                return stockTankField;
            } 
            set { 
                if (reservoirFieldSpecified) throw new Exception("Cannot set property StockTank when property Reservoir is already set");
                if (saturatedFieldSpecified) throw new Exception("Cannot set property StockTank when property Saturated is already set");
                stockTankField = value;
                stockTankFieldSpecified = true;
            }
        }

        private FluidResultStockTank stockTankField; 
        private bool stockTankFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType4> ItemsElementName { get; set; }
		
        [XmlElement("vaporComposition")]
        public List<FluidResultPhaseComposition> VaporComposition { get; set; }
		
        [XmlElement("liquidComposition")]
        public List<FluidResultPhaseComposition> LiquidComposition { get; set; }
		
        [XmlElement("compositeComposition")]
        public List<FluidResultCompositeComposition> CompositeComposition { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultJCurveTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultJCurveTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultJCurveTest xsd type.")]
    public partial class FluidResultJCurveTest : Object 
    {

        
        [XmlElement("testNumber")]
        public Int16? TestNumber {
            get {
                return testNumberField;
            } 
            set { 
                testNumberField = value;
                this.TestNumberSpecified = true;
            }
        }

        private Int16? testNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestNumberSpecified { get; set; }
        
        [XmlElement("testTemperature")]
        public ThermodynamicTemperatureMeasure TestTemperature { get; set; }
        
        [XmlElement("retrogradeDewPointPressure")]
        public PressureMeasure RetrogradeDewPointPressure {
            get {
                return retrogradeDewPointPressureField;
            } 
            set { 
                if (bubblePointPressureFieldSpecified) throw new Exception("Cannot set property RetrogradeDewPointPressure when property BubblePointPressure is already set");
                retrogradeDewPointPressureField = value;
                retrogradeDewPointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure retrogradeDewPointPressureField; 
        private bool retrogradeDewPointPressureFieldSpecified = false; 

        
        [XmlElement("bubblePointPressure")]
        public PressureMeasure BubblePointPressure {
            get {
                return bubblePointPressureField;
            } 
            set { 
                if (retrogradeDewPointPressureFieldSpecified) throw new Exception("Cannot set property BubblePointPressure when property RetrogradeDewPointPressure is already set");
                bubblePointPressureField = value;
                bubblePointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure bubblePointPressureField; 
        private bool bubblePointPressureFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType4? ItemElementName { get; set; }
        
        [XmlElement("liquidDropoutReference")]
        public FluidResultVolumeReference LiquidDropoutReference { get; set; }
        
        [XmlElement("cumulativeGasProducedReference")]
        public StandardVolumeMeasure CumulativeGasProducedReference { get; set; }
        
        [XmlElement("condensateYieldPressure1")]
        public PressureMeasure CondensateYieldPressure1 { get; set; }
        
        [XmlElement("condensateYieldTemperature1")]
        public ThermodynamicTemperatureMeasure CondensateYieldTemperature1 { get; set; }
        
        [XmlElement("condensateYieldPressure2")]
        public PressureMeasure CondensateYieldPressure2 { get; set; }
        
        [XmlElement("condensateYieldTemperature2")]
        public ThermodynamicTemperatureMeasure CondensateYieldTemperature2 { get; set; }
		
        [XmlElement("jcrvTestStep")]
        public List<FluidResultJCurveTestStep> JcrvTestStep { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultDifferentialLiberationTestStep xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultDifferentialLiberationTestStep", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultDifferentialLiberationTestStep xsd type.")]
    public partial class FluidResultDifferentialLiberationTestStep : Object 
    {

        
        [XmlElement("stepNumber")]
        public Int16? StepNumber {
            get {
                return stepNumberField;
            } 
            set { 
                stepNumberField = value;
                this.StepNumberSpecified = true;
            }
        }

        private Int16? stepNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StepNumberSpecified { get; set; }
        
        [XmlElement("stepPressure")]
        public PressureMeasure StepPressure { get; set; }
        
        [XmlElement("oilMassDensity")]
        public DensityMeasure OilMassDensity { get; set; }
        
        [XmlElement("oilFormationVolumeFactorStd")]
        public VolumePerStandardVolumeMeasure OilFormationVolumeFactorStd { get; set; }
        
        [XmlElement("oilCompressibility")]
        public CompressibilityMeasure OilCompressibility { get; set; }
        
        [XmlElement("oilViscosity")]
        public DynamicViscosityMeasure OilViscosity { get; set; }
        
        [XmlElement("oilVolume")]
        public VolumeMeasure OilVolume {
            get {
                return oilVolumeField;
            } 
            set { 
                if (oilShrinkageFactorFieldSpecified) throw new Exception("Cannot set property OilVolume when property OilShrinkageFactor is already set");
                oilVolumeField = value;
                oilVolumeFieldSpecified = true;
            }
        }

        private VolumeMeasure oilVolumeField; 
        private bool oilVolumeFieldSpecified = false; 

        
        [XmlElement("oilShrinkageFactor")]
        public VolumePerVolumeMeasure OilShrinkageFactor {
            get {
                return oilShrinkageFactorField;
            } 
            set { 
                if (oilVolumeFieldSpecified) throw new Exception("Cannot set property OilShrinkageFactor when property OilVolume is already set");
                oilShrinkageFactorField = value;
                oilShrinkageFactorFieldSpecified = true;
            }
        }

        private VolumePerVolumeMeasure oilShrinkageFactorField; 
        private bool oilShrinkageFactorFieldSpecified = false; 


        
        [XmlElement("gasMolecularWeight")]
        public Double? GasMolecularWeight {
            get {
                return gasMolecularWeightField;
            } 
            set { 
                gasMolecularWeightField = value;
                this.GasMolecularWeightSpecified = true;
            }
        }

        private Double? gasMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasMolecularWeightSpecified { get; set; }
        
        [XmlElement("gasGravity")]
        public Double? GasGravity {
            get {
                return gasGravityField;
            } 
            set { 
                gasGravityField = value;
                this.GasGravitySpecified = true;
            }
        }

        private Double? gasGravityField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasGravitySpecified { get; set; }
        
        [XmlElement("gasMassDensity")]
        public DensityMeasure GasMassDensity { get; set; }
        
        [XmlElement("gasFormationVolumeFactorStd")]
        public VolumePerStandardVolumeMeasure GasFormationVolumeFactorStd { get; set; }
        
        [XmlElement("gasZFactor")]
        public Double? GasZFactor {
            get {
                return gasZFactorField;
            } 
            set { 
                gasZFactorField = value;
                this.GasZFactorSpecified = true;
            }
        }

        private Double? gasZFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasZFactorSpecified { get; set; }
        
        [XmlElement("gasViscosity")]
        public DynamicViscosityMeasure GasViscosity { get; set; }
        
        [XmlElement("totalFormationVolumeFactorStd")]
        public VolumePerStandardVolumeMeasure TotalFormationVolumeFactorStd { get; set; }
        
        [XmlElement("solutionGORStd")]
        public StandardVolumePerStandardVolumeMeasure SolutionGORStd { get; set; }
        
        [XmlElement("cumulativeStockTankGORStd")]
        public StandardVolumePerStandardVolumeMeasure CumulativeStockTankGORStd { get; set; }
        
        [XmlElement("cumulativeSaturatedGORStd")]
        public StandardVolumePerVolumeMeasure CumulativeSaturatedGORStd { get; set; }
        
        [XmlElement("residualAPIGravity")]
        public DensityMeasure ResidualAPIGravity { get; set; }
        
        [XmlElement("comment")]
        public String Comment { get; set; }
        
        [XmlElement("reservoir")]
        public Boolean Reservoir {
            get {
                return reservoirField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Reservoir when property StockTank is already set");
                reservoirField = value;
                reservoirFieldSpecified = true;
            }
        }

        private Boolean reservoirField; 
        private bool reservoirFieldSpecified = false; 

        
        [XmlElement("saturated")]
        public Boolean Saturated {
            get {
                return saturatedField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Saturated when property StockTank is already set");
                saturatedField = value;
                saturatedFieldSpecified = true;
            }
        }

        private Boolean saturatedField; 
        private bool saturatedFieldSpecified = false; 

        
        [XmlElement("stockTank")]
        public FluidResultStockTank StockTank {
            get {
                return stockTankField;
            } 
            set { 
                if (saturatedFieldSpecified) throw new Exception("Cannot set property StockTank when property Saturated is already set");
                if (reservoirFieldSpecified) throw new Exception("Cannot set property StockTank when property Reservoir is already set");
                stockTankField = value;
                stockTankFieldSpecified = true;
            }
        }

        private FluidResultStockTank stockTankField; 
        private bool stockTankFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType3> ItemsElementName { get; set; }
		
        [XmlElement("vaporComposition")]
        public List<FluidResultPhaseComposition> VaporComposition { get; set; }
		
        [XmlElement("liquidComposition")]
        public List<FluidResultPhaseComposition> LiquidComposition { get; set; }
		
        [XmlElement("compositeComposition")]
        public List<FluidResultCompositeComposition> CompositeComposition { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultDifferentialLiberationTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultDifferentialLiberationTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultDifferentialLiberationTest xsd type.")]
    public partial class FluidResultDifferentialLiberationTest : Object 
    {

        
        [XmlElement("testNumber")]
        public Int16? TestNumber {
            get {
                return testNumberField;
            } 
            set { 
                testNumberField = value;
                this.TestNumberSpecified = true;
            }
        }

        private Int16? testNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestNumberSpecified { get; set; }
        
        [XmlElement("testTemperature")]
        public ThermodynamicTemperatureMeasure TestTemperature { get; set; }
        
        [XmlElement("bubblePointPressure")]
        public PressureMeasure BubblePointPressure {
            get {
                return bubblePointPressureField;
            } 
            set { 
                if (retrogradeDewPointPressureFieldSpecified) throw new Exception("Cannot set property BubblePointPressure when property RetrogradeDewPointPressure is already set");
                bubblePointPressureField = value;
                bubblePointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure bubblePointPressureField; 
        private bool bubblePointPressureFieldSpecified = false; 

        
        [XmlElement("retrogradeDewPointPressure")]
        public PressureMeasure RetrogradeDewPointPressure {
            get {
                return retrogradeDewPointPressureField;
            } 
            set { 
                if (bubblePointPressureFieldSpecified) throw new Exception("Cannot set property RetrogradeDewPointPressure when property BubblePointPressure is already set");
                retrogradeDewPointPressureField = value;
                retrogradeDewPointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure retrogradeDewPointPressureField; 
        private bool retrogradeDewPointPressureFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType3? ItemElementName { get; set; }
        
        [XmlElement("shrinkageReference")]
        public FluidResultVolumeReference ShrinkageReference { get; set; }
		
        [XmlElement("dlTestStep")]
        public List<FluidResultDifferentialLiberationTestStep> DLTestStep { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultCvdTestStep xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultCvdTestStep", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultCvdTestStep xsd type.")]
    public partial class FluidResultCvdTestStep : Object 
    {

        
        [XmlElement("stepNumber")]
        public Int16? StepNumber {
            get {
                return stepNumberField;
            } 
            set { 
                stepNumberField = value;
                this.StepNumberSpecified = true;
            }
        }

        private Int16? stepNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StepNumberSpecified { get; set; }
        
        [XmlElement("stepPressure")]
        public PressureMeasure StepPressure { get; set; }
        
        [XmlElement("oilViscosity")]
        public DynamicViscosityMeasure OilViscosity { get; set; }
        
        [XmlElement("liquidVolume")]
        public VolumeMeasure LiquidVolume {
            get {
                return liquidVolumeField;
            } 
            set { 
                if (liquidDropoutPercentFieldSpecified) throw new Exception("Cannot set property LiquidVolume when property LiquidDropoutPercent is already set");
                liquidVolumeField = value;
                liquidVolumeFieldSpecified = true;
            }
        }

        private VolumeMeasure liquidVolumeField; 
        private bool liquidVolumeFieldSpecified = false; 

        
        [XmlElement("liquidDropoutPercent")]
        public VolumePerVolumeMeasurePercent LiquidDropoutPercent {
            get {
                return liquidDropoutPercentField;
            } 
            set { 
                if (liquidVolumeFieldSpecified) throw new Exception("Cannot set property LiquidDropoutPercent when property LiquidVolume is already set");
                liquidDropoutPercentField = value;
                liquidDropoutPercentFieldSpecified = true;
            }
        }

        private VolumePerVolumeMeasurePercent liquidDropoutPercentField; 
        private bool liquidDropoutPercentFieldSpecified = false; 


        
        [XmlElement("gasMolecularWeight")]
        public Double? GasMolecularWeight {
            get {
                return gasMolecularWeightField;
            } 
            set { 
                gasMolecularWeightField = value;
                this.GasMolecularWeightSpecified = true;
            }
        }

        private Double? gasMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasMolecularWeightSpecified { get; set; }
        
        [XmlElement("gasGravity")]
        public Double? GasGravity {
            get {
                return gasGravityField;
            } 
            set { 
                gasGravityField = value;
                this.GasGravitySpecified = true;
            }
        }

        private Double? gasGravityField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasGravitySpecified { get; set; }
        
        [XmlElement("gasFormationVolumeFactorStd")]
        public VolumePerStandardVolumeMeasure GasFormationVolumeFactorStd { get; set; }
        
        [XmlElement("gasZFactor")]
        public Double? GasZFactor {
            get {
                return gasZFactorField;
            } 
            set { 
                gasZFactorField = value;
                this.GasZFactorSpecified = true;
            }
        }

        private Double? gasZFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasZFactorSpecified { get; set; }
        
        [XmlElement("gasViscosity")]
        public DynamicViscosityMeasure GasViscosity { get; set; }
        
        [XmlElement("cumulativeGasProducedVolume")]
        public StandardVolumeMeasure CumulativeGasProducedVolume {
            get {
                return cumulativeGasProducedVolumeField;
            } 
            set { 
                if (cumulativeGasProducedRatioStdFieldSpecified) throw new Exception("Cannot set property CumulativeGasProducedVolume when property CumulativeGasProducedRatioStd is already set");
                cumulativeGasProducedVolumeField = value;
                cumulativeGasProducedVolumeFieldSpecified = true;
            }
        }

        private StandardVolumeMeasure cumulativeGasProducedVolumeField; 
        private bool cumulativeGasProducedVolumeFieldSpecified = false; 

        
        [XmlElement("cumulativeGasProducedRatioStd")]
        public StandardVolumePerStandardVolumeMeasure CumulativeGasProducedRatioStd {
            get {
                return cumulativeGasProducedRatioStdField;
            } 
            set { 
                if (cumulativeGasProducedVolumeFieldSpecified) throw new Exception("Cannot set property CumulativeGasProducedRatioStd when property CumulativeGasProducedVolume is already set");
                cumulativeGasProducedRatioStdField = value;
                cumulativeGasProducedRatioStdFieldSpecified = true;
            }
        }

        private StandardVolumePerStandardVolumeMeasure cumulativeGasProducedRatioStdField; 
        private bool cumulativeGasProducedRatioStdFieldSpecified = false; 


        
        [XmlElement("comment")]
        public String Comment { get; set; }
        
        [XmlElement("reservoir")]
        public Boolean Reservoir {
            get {
                return reservoirField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Reservoir when property StockTank is already set");
                reservoirField = value;
                reservoirFieldSpecified = true;
            }
        }

        private Boolean reservoirField; 
        private bool reservoirFieldSpecified = false; 

        
        [XmlElement("saturated")]
        public Boolean Saturated {
            get {
                return saturatedField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Saturated when property StockTank is already set");
                saturatedField = value;
                saturatedFieldSpecified = true;
            }
        }

        private Boolean saturatedField; 
        private bool saturatedFieldSpecified = false; 

        
        [XmlElement("stockTank")]
        public FluidResultStockTank StockTank {
            get {
                return stockTankField;
            } 
            set { 
                if (reservoirFieldSpecified) throw new Exception("Cannot set property StockTank when property Reservoir is already set");
                if (saturatedFieldSpecified) throw new Exception("Cannot set property StockTank when property Saturated is already set");
                stockTankField = value;
                stockTankFieldSpecified = true;
            }
        }

        private FluidResultStockTank stockTankField; 
        private bool stockTankFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType2> ItemsElementName { get; set; }
		
        [XmlElement("vaporComposition")]
        public List<FluidResultPhaseComposition> VaporComposition { get; set; }
		
        [XmlElement("liquidComposition")]
        public List<FluidResultPhaseComposition> LiquidComposition { get; set; }
		
        [XmlElement("compositeComposition")]
        public List<FluidResultCompositeComposition> CompositeComposition { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultConstantVolumeDepletionTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultConstantVolumeDepletionTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultConstantVolumeDepletionTest xsd type.")]
    public partial class FluidResultConstantVolumeDepletionTest : Object 
    {

        
        [XmlElement("testNumber")]
        public Int16? TestNumber {
            get {
                return testNumberField;
            } 
            set { 
                testNumberField = value;
                this.TestNumberSpecified = true;
            }
        }

        private Int16? testNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestNumberSpecified { get; set; }
        
        [XmlElement("testTemperature")]
        public ThermodynamicTemperatureMeasure TestTemperature { get; set; }
        
        [XmlElement("bubblePointPressure")]
        public PressureMeasure BubblePointPressure {
            get {
                return bubblePointPressureField;
            } 
            set { 
                if (retrogradeDewPointPressureFieldSpecified) throw new Exception("Cannot set property BubblePointPressure when property RetrogradeDewPointPressure is already set");
                bubblePointPressureField = value;
                bubblePointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure bubblePointPressureField; 
        private bool bubblePointPressureFieldSpecified = false; 

        
        [XmlElement("retrogradeDewPointPressure")]
        public PressureMeasure RetrogradeDewPointPressure {
            get {
                return retrogradeDewPointPressureField;
            } 
            set { 
                if (bubblePointPressureFieldSpecified) throw new Exception("Cannot set property RetrogradeDewPointPressure when property BubblePointPressure is already set");
                retrogradeDewPointPressureField = value;
                retrogradeDewPointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure retrogradeDewPointPressureField; 
        private bool retrogradeDewPointPressureFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType2? ItemElementName { get; set; }
        
        [XmlElement("liquidDropoutReference")]
        public FluidResultVolumeReference LiquidDropoutReference { get; set; }
        
        [XmlElement("cumulativeGasProducedReferenceStd")]
        public StandardVolumeMeasure CumulativeGasProducedReferenceStd { get; set; }
		
        [XmlElement("cvdTestStep")]
        public List<FluidResultCvdTestStep> CvdTestStep { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultCceTestStep xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultCceTestStep", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultCceTestStep xsd type.")]
    public partial class FluidResultCceTestStep : Object 
    {

        
        [XmlElement("stepNumber")]
        public Int16? StepNumber {
            get {
                return stepNumberField;
            } 
            set { 
                stepNumberField = value;
                this.StepNumberSpecified = true;
            }
        }

        private Int16? stepNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StepNumberSpecified { get; set; }
        
        [XmlElement("stepPressure")]
        public PressureMeasure StepPressure { get; set; }
        
        [XmlElement("oilMassDensity")]
        public DensityMeasure OilMassDensity { get; set; }
        
        [XmlElement("oilCompressibility")]
        public CompressibilityMeasure OilCompressibility { get; set; }
        
        [XmlElement("oilViscosity")]
        public DynamicViscosityMeasure OilViscosity { get; set; }
        
        [XmlElement("totalVolume")]
        public VolumeMeasure TotalVolume {
            get {
                return totalVolumeField;
            } 
            set { 
                if (liquidDropoutPercentFieldSpecified) throw new Exception("Cannot set property TotalVolume when property LiquidDropoutPercent is already set");
                totalVolumeField = value;
                totalVolumeFieldSpecified = true;
            }
        }

        private VolumeMeasure totalVolumeField; 
        private bool totalVolumeFieldSpecified = false; 

        
        [XmlElement("liquidVolume")]
        public VolumeMeasure LiquidVolume {
            get {
                return liquidVolumeField;
            } 
            set { 
                if (liquidDropoutPercentFieldSpecified) throw new Exception("Cannot set property LiquidVolume when property LiquidDropoutPercent is already set");
                liquidVolumeField = value;
                liquidVolumeFieldSpecified = true;
            }
        }

        private VolumeMeasure liquidVolumeField; 
        private bool liquidVolumeFieldSpecified = false; 

        
        [XmlElement("liquidDropoutPercent")]
        public VolumePerVolumeMeasurePercent LiquidDropoutPercent {
            get {
                return liquidDropoutPercentField;
            } 
            set { 
                if (totalVolumeFieldSpecified) throw new Exception("Cannot set property LiquidDropoutPercent when property TotalVolume is already set");
                if (liquidVolumeFieldSpecified) throw new Exception("Cannot set property LiquidDropoutPercent when property LiquidVolume is already set");
                liquidDropoutPercentField = value;
                liquidDropoutPercentFieldSpecified = true;
            }
        }

        private VolumePerVolumeMeasurePercent liquidDropoutPercentField; 
        private bool liquidDropoutPercentFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<ItemsChoiceType1> ItemsElementName { get; set; }
        
        [XmlElement("relativeVolumeRatio")]
        public VolumePerVolumeMeasure RelativeVolumeRatio { get; set; }
        
        [XmlElement("gasMassDensity")]
        public DensityMeasure GasMassDensity { get; set; }
        
        [XmlElement("gasZFactor")]
        public Double? GasZFactor {
            get {
                return gasZFactorField;
            } 
            set { 
                gasZFactorField = value;
                this.GasZFactorSpecified = true;
            }
        }

        private Double? gasZFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasZFactorSpecified { get; set; }
        
        [XmlElement("gasCompressibility")]
        public CompressibilityMeasure GasCompressibility { get; set; }
        
        [XmlElement("gasViscosity")]
        public DynamicViscosityMeasure GasViscosity { get; set; }
        
        [XmlElement("yFactor")]
        public Double? YFactor {
            get {
                return yFactorField;
            } 
            set { 
                yFactorField = value;
                this.YFactorSpecified = true;
            }
        }

        private Double? yFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean YFactorSpecified { get; set; }
        
        [XmlElement("comment")]
        public String Comment { get; set; }
        
        [XmlElement("reservoir")]
        public Boolean Reservoir {
            get {
                return reservoirField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Reservoir when property StockTank is already set");
                reservoirField = value;
                reservoirFieldSpecified = true;
            }
        }

        private Boolean reservoirField; 
        private bool reservoirFieldSpecified = false; 

        
        [XmlElement("saturated")]
        public Boolean Saturated {
            get {
                return saturatedField;
            } 
            set { 
                if (stockTankFieldSpecified) throw new Exception("Cannot set property Saturated when property StockTank is already set");
                saturatedField = value;
                saturatedFieldSpecified = true;
            }
        }

        private Boolean saturatedField; 
        private bool saturatedFieldSpecified = false; 

        
        [XmlElement("stockTank")]
        public FluidResultStockTank StockTank {
            get {
                return stockTankField;
            } 
            set { 
                if (reservoirFieldSpecified) throw new Exception("Cannot set property StockTank when property Reservoir is already set");
                if (saturatedFieldSpecified) throw new Exception("Cannot set property StockTank when property Saturated is already set");
                stockTankField = value;
                stockTankFieldSpecified = true;
            }
        }

        private FluidResultStockTank stockTankField; 
        private bool stockTankFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public List<Items1ChoiceType> Items1ElementName { get; set; }
		
        [XmlElement("vaporComposition")]
        public List<FluidResultPhaseComposition> VaporComposition { get; set; }
		
        [XmlElement("liquidComposition")]
        public List<FluidResultPhaseComposition> LiquidComposition { get; set; }
		
        [XmlElement("compositeComposition")]
        public List<FluidResultCompositeComposition> CompositeComposition { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultConstantCompositionExpansionTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultConstantCompositionExpansionTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultConstantCompositionExpansionTest xsd type.")]
    public partial class FluidResultConstantCompositionExpansionTest : Object 
    {

        
        [XmlElement("testNumber")]
        public Int16? TestNumber {
            get {
                return testNumberField;
            } 
            set { 
                testNumberField = value;
                this.TestNumberSpecified = true;
            }
        }

        private Int16? testNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestNumberSpecified { get; set; }
        
        [XmlElement("testTemperature")]
        public ThermodynamicTemperatureMeasure TestTemperature { get; set; }
        
        [XmlElement("bubblePointPressure")]
        public PressureMeasure BubblePointPressure {
            get {
                return bubblePointPressureField;
            } 
            set { 
                if (retrogradeDewPointPressureFieldSpecified) throw new Exception("Cannot set property BubblePointPressure when property RetrogradeDewPointPressure is already set");
                bubblePointPressureField = value;
                bubblePointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure bubblePointPressureField; 
        private bool bubblePointPressureFieldSpecified = false; 

        
        [XmlElement("retrogradeDewPointPressure")]
        public PressureMeasure RetrogradeDewPointPressure {
            get {
                return retrogradeDewPointPressureField;
            } 
            set { 
                if (bubblePointPressureFieldSpecified) throw new Exception("Cannot set property RetrogradeDewPointPressure when property BubblePointPressure is already set");
                retrogradeDewPointPressureField = value;
                retrogradeDewPointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure retrogradeDewPointPressureField; 
        private bool retrogradeDewPointPressureFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType1? ItemElementName { get; set; }
        
        [XmlElement("liquidDropoutReference")]
        public FluidResultVolumeReference LiquidDropoutReference { get; set; }
        
        [XmlElement("relativeVolumeReference")]
        public FluidResultVolumeReference RelativeVolumeReference { get; set; }
		
        [XmlElement("cceTestStep")]
        public List<FluidResultCceTestStep> CceTestStep { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultSaturationTestStep xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultSaturationTestStep", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultSaturationTestStep xsd type.")]
    public partial class FluidResultSaturationTestStep : Object 
    {

        
        [XmlElement("stepNumber")]
        public Int16? StepNumber {
            get {
                return stepNumberField;
            } 
            set { 
                stepNumberField = value;
                this.StepNumberSpecified = true;
            }
        }

        private Int16? stepNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean StepNumberSpecified { get; set; }
        
        [XmlElement("stepTemperature")]
        public ThermodynamicTemperatureMeasure StepTemperature { get; set; }
        
        [XmlElement("bubblePointPressure")]
        public PressureMeasure BubblePointPressure {
            get {
                return bubblePointPressureField;
            } 
            set { 
                if (retrogradeDewPointPressureFieldSpecified) throw new Exception("Cannot set property BubblePointPressure when property RetrogradeDewPointPressure is already set");
                bubblePointPressureField = value;
                bubblePointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure bubblePointPressureField; 
        private bool bubblePointPressureFieldSpecified = false; 

        
        [XmlElement("retrogradeDewPointPressure")]
        public PressureMeasure RetrogradeDewPointPressure {
            get {
                return retrogradeDewPointPressureField;
            } 
            set { 
                if (bubblePointPressureFieldSpecified) throw new Exception("Cannot set property RetrogradeDewPointPressure when property BubblePointPressure is already set");
                retrogradeDewPointPressureField = value;
                retrogradeDewPointPressureFieldSpecified = true;
            }
        }

        private PressureMeasure retrogradeDewPointPressureField; 
        private bool retrogradeDewPointPressureFieldSpecified = false; 


		
        [XmlIgnore]
		[Browsable(false)]
        public ItemChoiceType? ItemElementName { get; set; }
        
        [XmlElement("dewPointPressure")]
        public PressureMeasure DewPointPressure { get; set; }
        
        [XmlElement("comment")]
        public String Comment { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultSaturationTest xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultSaturationTest", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultSaturationTest xsd type.")]
    public partial class FluidResultSaturationTest : Object 
    {

        
        [XmlElement("testNumber")]
        public Int16? TestNumber {
            get {
                return testNumberField;
            } 
            set { 
                testNumberField = value;
                this.TestNumberSpecified = true;
            }
        }

        private Int16? testNumberField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TestNumberSpecified { get; set; }
		
        [XmlElement("saturationTestStep")]
        public List<FluidResultSaturationTestStep> SaturationTestStep { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the binaryInteractionCoefficient xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="binaryInteractionCoefficient", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the binaryInteractionCoefficient xsd type.")]
    public partial class BinaryInteractionCoefficient : Object 
    {
        public BinaryInteractionCoefficient() {}
        public BinaryInteractionCoefficient(Double value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		
        [XmlAttribute("referenceComponent")]
        public String ReferenceComponent { get; set; }
		
        [XmlText]
        public Double Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultComposition xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultComposition", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultComposition xsd type.")]
    public partial class FluidResultComposition : Object 
    {

        
        [XmlElement("isPrimary")]
        public Boolean? IsPrimary { get; set; }
        
        [XmlElement("componentName")]
        public String ComponentName { get; set; }
        
        [XmlElement("componentBaseKind")]
        public FluidComponent ComponentBaseKind {
            get {
                return componentBaseKindField;
            } 
            set { 
                componentBaseKindField = value;
                this.ComponentBaseKindSpecified = true;
            }
        }

        private FluidComponent componentBaseKindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ComponentBaseKindSpecified { get; set; }
        
        [XmlElement("componentKind")]
        public FluidComponentKind ComponentKind {
            get {
                return componentKindField;
            } 
            set { 
                componentKindField = value;
                this.ComponentKindSpecified = true;
            }
        }

        private FluidComponentKind componentKindField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ComponentKindSpecified { get; set; }
        
        [XmlElement("molecularWeight")]
        public Double? MolecularWeight {
            get {
                return molecularWeightField;
            } 
            set { 
                molecularWeightField = value;
                this.MolecularWeightSpecified = true;
            }
        }

        private Double? molecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean MolecularWeightSpecified { get; set; }
        
        [XmlElement("weightPercent")]
        public MassConcentrationMeasurePercent WeightPercent { get; set; }
        
        [XmlElement("molePercent")]
        public MolarFractionMeasurePercent MolePercent { get; set; }
        
        [XmlElement("specificGravity")]
        public Double? SpecificGravity {
            get {
                return specificGravityField;
            } 
            set { 
                specificGravityField = value;
                this.SpecificGravitySpecified = true;
            }
        }

        private Double? specificGravityField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SpecificGravitySpecified { get; set; }
        
        [XmlElement("boilingPoint")]
        public ThermodynamicTemperatureMeasure BoilingPoint { get; set; }
        
        [XmlElement("criticalPressure")]
        public PressureMeasure CriticalPressure { get; set; }
        
        [XmlElement("criticalTemperature")]
        public ThermodynamicTemperatureMeasure CriticalTemperature { get; set; }
        
        [XmlElement("criticalVolume")]
        public VolumeMeasure CriticalVolume { get; set; }
        
        [XmlElement("acentricFactor")]
        public Double? AcentricFactor {
            get {
                return acentricFactorField;
            } 
            set { 
                acentricFactorField = value;
                this.AcentricFactorSpecified = true;
            }
        }

        private Double? acentricFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AcentricFactorSpecified { get; set; }
        
        [XmlElement("volumeTranslationFactor")]
        public MolarVolumeMeasure VolumeTranslationFactor { get; set; }
        
        [XmlElement("alphaShapeFactor")]
        public Double? AlphaShapeFactor {
            get {
                return alphaShapeFactorField;
            } 
            set { 
                alphaShapeFactorField = value;
                this.AlphaShapeFactorSpecified = true;
            }
        }

        private Double? alphaShapeFactorField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AlphaShapeFactorSpecified { get; set; }
        
        [XmlElement("watsonKExponent")]
        public Double? WatsonKExponent {
            get {
                return watsonKExponentField;
            } 
            set { 
                watsonKExponentField = value;
                this.WatsonKExponentSpecified = true;
            }
        }

        private Double? watsonKExponentField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean WatsonKExponentSpecified { get; set; }
        
        [XmlElement("splitCount")]
        public Int16? SplitCount {
            get {
                return splitCountField;
            } 
            set { 
                splitCountField = value;
                this.SplitCountSpecified = true;
            }
        }

        private Int16? splitCountField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SplitCountSpecified { get; set; }
        
        [XmlElement("plusMinimumMolecularWeight")]
        public Double? PlusMinimumMolecularWeight {
            get {
                return plusMinimumMolecularWeightField;
            } 
            set { 
                plusMinimumMolecularWeightField = value;
                this.PlusMinimumMolecularWeightSpecified = true;
            }
        }

        private Double? plusMinimumMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PlusMinimumMolecularWeightSpecified { get; set; }
        
        [XmlElement("plusMaximumMolecularWeight")]
        public Double? PlusMaximumMolecularWeight {
            get {
                return plusMaximumMolecularWeightField;
            } 
            set { 
                plusMaximumMolecularWeightField = value;
                this.PlusMaximumMolecularWeightSpecified = true;
            }
        }

        private Double? plusMaximumMolecularWeightField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PlusMaximumMolecularWeightSpecified { get; set; }
        
        [XmlElement("rvp")]
        public PressureMeasure Rvp { get; set; }
        
        [XmlElement("tvp")]
        public PressureMeasure Tvp { get; set; }
		
        [XmlElement("binaryInteractionCoefficient")]
        public List<BinaryInteractionCoefficient> BinaryInteractionCoefficient { get; set; }
        
        [XmlElement("calculated")]
        public Boolean? CAlculated {
            get {
                return calculatedField;
            } 
            set { 
                calculatedField = value;
                this.CAlculatedSpecified = true;
            }
        }

        private Boolean? calculatedField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CAlculatedSpecified { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the cs_fluidResultDataQuality xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_fluidResultDataQuality", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the cs_fluidResultDataQuality xsd type.")]
    public partial class FluidResultDataQuality : Object 
    {

        
        [XmlElement("quality")]
        public DataQuality Quality { get; set; }
        
        [XmlElement("source")]
        public String Source { get; set; }
        
        [XmlElement("purpose")]
        public String Purpose { get; set; }
    }
    }

    /// <summary>
    /// This class represents the obj_fluidAnalysisResult xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_fluidAnalysisResult", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the obj_fluidAnalysisResult xsd type.")]
    public partial class FluidAnalysisResult : Object 
    {

        /// <summary>
        /// Human recognizable context for the fluid sample that was analyzed. 
        /// </summary>
        [XmlElement("nameFluidSample")]
        public String NameFluidSample { get; set; }
        /// <summary>
        /// Human recognizable context for the fluid analysis that produced this result. 
        /// </summary>
        [XmlElement("nameFluidAnalysis")]
        public String NameFluidAnalysis { get; set; }
        /// <summary>
        /// The name of the Fluid Analysis Result.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("transferPressure")]
        public PressureMeasure TransferPressure { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("transferTemperature")]
        public ThermodynamicTemperatureMeasure TransferTemperature { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("reservoirPressure")]
        public PressureMeasure ReservoirPressure { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("reservoirTemperature")]
        public ThermodynamicTemperatureMeasure ReservoirTemperature { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("saturationPressure")]
        public PressureMeasure SaturationPressure { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("producingGORStd")]
        public StandardVolumePerStandardVolumeMeasure ProducingGORStd { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("oilAPIGravityMeasured")]
        public DensityMeasure OilAPIGravityMeasured { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("oilAPIGravityCorrected")]
        public DensityMeasure OilAPIGravityCorrected { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("gasGravityMeasured")]
        public Double? GasGravityMeasured {
            get {
                return gasGravityMeasuredField;
            } 
            set { 
                gasGravityMeasuredField = value;
                this.GasGravityMeasuredSpecified = true;
            }
        }

        private Double? gasGravityMeasuredField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasGravityMeasuredSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("gasGravityCorrected")]
        public Double? GasGravityCorrected {
            get {
                return gasGravityCorrectedField;
            } 
            set { 
                gasGravityCorrectedField = value;
                this.GasGravityCorrectedSpecified = true;
            }
        }

        private Double? gasGravityCorrectedField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean GasGravityCorrectedSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("h2oGravityMeasured")]
        public Double? H2oGravityMeasured {
            get {
                return h2oGravityMeasuredField;
            } 
            set { 
                h2oGravityMeasuredField = value;
                this.H2oGravityMeasuredSpecified = true;
            }
        }

        private Double? h2oGravityMeasuredField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean H2oGravityMeasuredSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("h2oGravityCorrected")]
        public Double? H2oGravityCorrected {
            get {
                return h2oGravityCorrectedField;
            } 
            set { 
                h2oGravityCorrectedField = value;
                this.H2oGravityCorrectedSpecified = true;
            }
        }

        private Double? h2oGravityCorrectedField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean H2oGravityCorrectedSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("h2oSalinity")]
        public MassConcentrationMeasure H2oSalinity { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("aromaticsWeightPercent")]
        public MassConcentrationMeasurePercent AromaticsWeightPercent { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("asphaltenesWeightPercent")]
        public MassConcentrationMeasurePercent AsphaltenesWeightPercent { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("napthenesWeightPercent")]
        public MassConcentrationMeasurePercent NapthenesWeightPercent { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("parafinsWeightPercent")]
        public MassConcentrationMeasurePercent PluggedAndAbandonedrafinsWeightPercent { get; set; }
        /// <summary>
        /// The definition of standard pressure for all elements which end in "Std".
        /// </summary>
        [XmlElement("standardPressure")]
        public PressureMeasure StandardPressure { get; set; }
        /// <summary>
        /// The definition of standard temperature for all elements which end in "Std".
        /// </summary>
        [XmlElement("standardTemperature")]
        public ThermodynamicTemperatureMeasure StandardTemperature { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("eosMOdel")]
        public EosModelKind EosMOuterDiameterel {
            get {
                return eosMOdelField;
            } 
            set { 
                eosMOdelField = value;
                this.EosMOuterDiameterelSpecified = true;
            }
        }

        private EosModelKind eosMOdelField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EosMOuterDiameterelSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("analysisDescription")]
        public String AnalysisDescription { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("analysisPurpose")]
        public String AnalysisPurpose { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("fluidDataQuality")]
        public FluidResultDataQuality FluidDataQuality { get; set; }
		/// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("fluidSampleComposition")]
        public List<FluidResultComposition> FluidSampleComposition { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("jCurveTest")]
        public FluidResultJCurveTest JCurveTest {
            get {
                return jCurveTestField;
            } 
            set { 
                if (saturationTestFieldSpecified) throw new Exception("Cannot set property JCurveTest when property SaturationTest is already set");
                if (constantCompositionExpansionTestFieldSpecified) throw new Exception("Cannot set property JCurveTest when property ConstantCompositionExpansionTest is already set");
                if (differentialLiberationTestFieldSpecified) throw new Exception("Cannot set property JCurveTest when property DifferentialLiberationTest is already set");
                if (transportPropertiesTestFieldSpecified) throw new Exception("Cannot set property JCurveTest when property TransportPropertiesTest is already set");
                if (constantVolumeDepletionTestFieldSpecified) throw new Exception("Cannot set property JCurveTest when property ConstantVolumeDepletionTest is already set");
                if (separatorTestFieldSpecified) throw new Exception("Cannot set property JCurveTest when property SeparatorTest is already set");
                jCurveTestField = value;
                jCurveTestFieldSpecified = true;
            }
        }

        private FluidResultJCurveTest jCurveTestField; 
        private bool jCurveTestFieldSpecified = false; 

        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("saturationTest")]
        public FluidResultSaturationTest SaturationTest {
            get {
                return saturationTestField;
            } 
            set { 
                if (jCurveTestFieldSpecified) throw new Exception("Cannot set property SaturationTest when property JCurveTest is already set");
                if (constantCompositionExpansionTestFieldSpecified) throw new Exception("Cannot set property SaturationTest when property ConstantCompositionExpansionTest is already set");
                if (differentialLiberationTestFieldSpecified) throw new Exception("Cannot set property SaturationTest when property DifferentialLiberationTest is already set");
                if (transportPropertiesTestFieldSpecified) throw new Exception("Cannot set property SaturationTest when property TransportPropertiesTest is already set");
                if (constantVolumeDepletionTestFieldSpecified) throw new Exception("Cannot set property SaturationTest when property ConstantVolumeDepletionTest is already set");
                if (separatorTestFieldSpecified) throw new Exception("Cannot set property SaturationTest when property SeparatorTest is already set");
                saturationTestField = value;
                saturationTestFieldSpecified = true;
            }
        }

        private FluidResultSaturationTest saturationTestField; 
        private bool saturationTestFieldSpecified = false; 

        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("constantCompositionExpansionTest")]
        public FluidResultConstantCompositionExpansionTest ConstantCompositionExpansionTest {
            get {
                return constantCompositionExpansionTestField;
            } 
            set { 
                if (jCurveTestFieldSpecified) throw new Exception("Cannot set property ConstantCompositionExpansionTest when property JCurveTest is already set");
                if (saturationTestFieldSpecified) throw new Exception("Cannot set property ConstantCompositionExpansionTest when property SaturationTest is already set");
                if (differentialLiberationTestFieldSpecified) throw new Exception("Cannot set property ConstantCompositionExpansionTest when property DifferentialLiberationTest is already set");
                if (transportPropertiesTestFieldSpecified) throw new Exception("Cannot set property ConstantCompositionExpansionTest when property TransportPropertiesTest is already set");
                if (constantVolumeDepletionTestFieldSpecified) throw new Exception("Cannot set property ConstantCompositionExpansionTest when property ConstantVolumeDepletionTest is already set");
                if (separatorTestFieldSpecified) throw new Exception("Cannot set property ConstantCompositionExpansionTest when property SeparatorTest is already set");
                constantCompositionExpansionTestField = value;
                constantCompositionExpansionTestFieldSpecified = true;
            }
        }

        private FluidResultConstantCompositionExpansionTest constantCompositionExpansionTestField; 
        private bool constantCompositionExpansionTestFieldSpecified = false; 

        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("differentialLiberationTest")]
        public FluidResultDifferentialLiberationTest DifferentialLiberationTest {
            get {
                return differentialLiberationTestField;
            } 
            set { 
                if (jCurveTestFieldSpecified) throw new Exception("Cannot set property DifferentialLiberationTest when property JCurveTest is already set");
                if (saturationTestFieldSpecified) throw new Exception("Cannot set property DifferentialLiberationTest when property SaturationTest is already set");
                if (constantCompositionExpansionTestFieldSpecified) throw new Exception("Cannot set property DifferentialLiberationTest when property ConstantCompositionExpansionTest is already set");
                if (transportPropertiesTestFieldSpecified) throw new Exception("Cannot set property DifferentialLiberationTest when property TransportPropertiesTest is already set");
                if (constantVolumeDepletionTestFieldSpecified) throw new Exception("Cannot set property DifferentialLiberationTest when property ConstantVolumeDepletionTest is already set");
                if (separatorTestFieldSpecified) throw new Exception("Cannot set property DifferentialLiberationTest when property SeparatorTest is already set");
                differentialLiberationTestField = value;
                differentialLiberationTestFieldSpecified = true;
            }
        }

        private FluidResultDifferentialLiberationTest differentialLiberationTestField; 
        private bool differentialLiberationTestFieldSpecified = false; 

        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("transportPropertiesTest")]
        public FluidResultTransportPropertiesTest TransportPropertiesTest {
            get {
                return transportPropertiesTestField;
            } 
            set { 
                if (jCurveTestFieldSpecified) throw new Exception("Cannot set property TransportPropertiesTest when property JCurveTest is already set");
                if (saturationTestFieldSpecified) throw new Exception("Cannot set property TransportPropertiesTest when property SaturationTest is already set");
                if (constantCompositionExpansionTestFieldSpecified) throw new Exception("Cannot set property TransportPropertiesTest when property ConstantCompositionExpansionTest is already set");
                if (differentialLiberationTestFieldSpecified) throw new Exception("Cannot set property TransportPropertiesTest when property DifferentialLiberationTest is already set");
                if (constantVolumeDepletionTestFieldSpecified) throw new Exception("Cannot set property TransportPropertiesTest when property ConstantVolumeDepletionTest is already set");
                if (separatorTestFieldSpecified) throw new Exception("Cannot set property TransportPropertiesTest when property SeparatorTest is already set");
                transportPropertiesTestField = value;
                transportPropertiesTestFieldSpecified = true;
            }
        }

        private FluidResultTransportPropertiesTest transportPropertiesTestField; 
        private bool transportPropertiesTestFieldSpecified = false; 

        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("constantVolumeDepletionTest")]
        public FluidResultConstantVolumeDepletionTest ConstantVolumeDepletionTest {
            get {
                return constantVolumeDepletionTestField;
            } 
            set { 
                if (jCurveTestFieldSpecified) throw new Exception("Cannot set property ConstantVolumeDepletionTest when property JCurveTest is already set");
                if (saturationTestFieldSpecified) throw new Exception("Cannot set property ConstantVolumeDepletionTest when property SaturationTest is already set");
                if (constantCompositionExpansionTestFieldSpecified) throw new Exception("Cannot set property ConstantVolumeDepletionTest when property ConstantCompositionExpansionTest is already set");
                if (differentialLiberationTestFieldSpecified) throw new Exception("Cannot set property ConstantVolumeDepletionTest when property DifferentialLiberationTest is already set");
                if (transportPropertiesTestFieldSpecified) throw new Exception("Cannot set property ConstantVolumeDepletionTest when property TransportPropertiesTest is already set");
                if (separatorTestFieldSpecified) throw new Exception("Cannot set property ConstantVolumeDepletionTest when property SeparatorTest is already set");
                constantVolumeDepletionTestField = value;
                constantVolumeDepletionTestFieldSpecified = true;
            }
        }

        private FluidResultConstantVolumeDepletionTest constantVolumeDepletionTestField; 
        private bool constantVolumeDepletionTestFieldSpecified = false; 

        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("separatorTest")]
        public FluidResultSeparatorTest SeparatorTest {
            get {
                return separatorTestField;
            } 
            set { 
                if (jCurveTestFieldSpecified) throw new Exception("Cannot set property SeparatorTest when property JCurveTest is already set");
                if (saturationTestFieldSpecified) throw new Exception("Cannot set property SeparatorTest when property SaturationTest is already set");
                if (constantCompositionExpansionTestFieldSpecified) throw new Exception("Cannot set property SeparatorTest when property ConstantCompositionExpansionTest is already set");
                if (differentialLiberationTestFieldSpecified) throw new Exception("Cannot set property SeparatorTest when property DifferentialLiberationTest is already set");
                if (transportPropertiesTestFieldSpecified) throw new Exception("Cannot set property SeparatorTest when property TransportPropertiesTest is already set");
                if (constantVolumeDepletionTestFieldSpecified) throw new Exception("Cannot set property SeparatorTest when property ConstantVolumeDepletionTest is already set");
                separatorTestField = value;
                separatorTestFieldSpecified = true;
            }
        }

        private FluidResultSeparatorTest separatorTestField; 
        private bool separatorTestFieldSpecified = false; 


		/// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("fluidSampleContaminant")]
        public List<FluidResultContaminant> FluidSampleContaminant { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		/// <summary>
        /// Unique identifier for the Fluid Sample that was analyzed.
        /// </summary>
        [XmlAttribute("uidFluidSample")]
        public String UidFluidSample { get; set; }
		/// <summary>
        /// Unique identifier for the Fluid Analysis that produced this result.
        /// </summary>
        [XmlAttribute("uidFluidAnalysis")]
        public String UidFluidAnalysis { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    /// <summary>
    /// This class represents the obj_fluidAnalysis xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_fluidAnalysis", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the obj_fluidAnalysis xsd type.")]
    public partial class FluidAnalysis : Object 
    {

        /// <summary>
        /// The name of the Fluid Analysis.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("laboratorybAnalysisKind")]
        public String LaboratorybAnalysisKind {
            get {
                return laboratorybAnalysisKindField;
            } 
            set { 
                if (userAnalysisKindFieldSpecified) throw new Exception("Cannot set property LaboratorybAnalysisKind when property UserAnalysisKind is already set");
                laboratorybAnalysisKindField = value;
                laboratorybAnalysisKindFieldSpecified = true;
            }
        }

        private String laboratorybAnalysisKindField; 
        private bool laboratorybAnalysisKindFieldSpecified = false; 

        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("userAnalysisKind")]
        public FluidAnalysisKind UserAnalysisKind {
            get {
                return userAnalysisKindField;
            } 
            set { 
                if (laboratorybAnalysisKindFieldSpecified) throw new Exception("Cannot set property UserAnalysisKind when property LaboratorybAnalysisKind is already set");
                userAnalysisKindField = value;
                userAnalysisKindFieldSpecified = true;
            }
        }

        private FluidAnalysisKind userAnalysisKindField; 
        private bool userAnalysisKindFieldSpecified = false; 


		/// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("")]
        public DateTime? AnalysisdDate {
            get {
                return analysisdDateField;
            } 
            set { 
                analysisdDateField = value;
                this.AnalysisdDateSpecified = true;
            }
        }

        private DateTime? analysisdDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean AnalysisdDateSpecified { get; set; }
        /// <summary>
        /// The name of the application that was run by the user.
        /// </summary>
        [XmlElement("applicationName")]
        public String ApplicationName { get; set; }
        /// <summary>
        /// The version of the application that was run by the user.
        /// </summary>
        [XmlElement("applicationVersion")]
        public String ApplicationVersion { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("analysisCompany")]
        public String AnalysisCompany { get; set; }
        /// <summary>
        /// The name of the analyst or user who is responsible for the results. 
        /// </summary>
        [XmlElement("personName")]
        public String PersonName { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("reportIdentifier")]
        public String ReportIdentifier { get; set; }
		/// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("")]
        public DateTime? ReportDate {
            get {
                return reportDateField;
            } 
            set { 
                reportDateField = value;
                this.ReportDateSpecified = true;
            }
        }

        private DateTime? reportDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ReportDateSpecified { get; set; }
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [XmlElement("reportLocation")]
        public String ReportLocation { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Captures information about one processed wellLog.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsProcessedWellLog", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Captures information about one processed wellLog.")]
    public partial class DtsProcessedWellLog : Object 
    {

		/// <summary>
        /// The kind of processing used to create the new log.
        /// </summary>
        [XmlElement("processing")]
        public List<String> Processing { get; set; }
        /// <summary>
        /// The resultant wellLog.
        /// </summary>
        [XmlElement("derivedWellLog")]
        public RefNameString DerivedWellLog { get; set; }
        /// <summary>
        /// The wellLog which was the primary source for creating the derived log.
        /// </summary>
        [XmlElement("sourceWellLog")]
        public RefNameString SourceWellLog { get; set; }
        /// <summary>
        /// A textual comment about the processing.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A simple structure that allows an error report to be exchanged. The strucutre will allow for an error name, error id (generally a numerical code), and a description.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsErrorReport", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A simple structure that allows an error report to be exchanged. The strucutre will allow for an error name, error id (generally a numerical code), and a description.")]
    public partial class DtsErrorReport : Object 
    {

        /// <summary>
        /// A name of the error.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// A code, or other id, for the error.
        /// </summary>
        [XmlElement("id")]
        public String Id { get; set; }
        /// <summary>
        /// A description of the error.
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    /// <summary>
    /// The information content of a DTS temperature run is captured in the following elements, and in the referenced dtsInstalledFiber (for context) and the reference well log (captures the table of data).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_dtsMeasurement", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The information content of a DTS temperature run is captured in the following elements, and in the referenced dtsInstalledFiber (for context) and the reference well log (captures the table of data).")]
    public partial class DtsMeasurement : Object 
    {

        /// <summary>
        /// Human recognizable context for the well that contains the wellbore.
        /// </summary>
        [XmlElement("nameWell")]
        public String NameWell { get; set; }
        /// <summary>
        /// Human recognizable context for the wellbore that contains the dts. 
        /// </summary>
        [XmlElement("nameWellbore")]
        public String NameWellbore { get; set; }
        /// <summary>
        /// Human recognizable context for the dts.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The minimum time index contained within the object. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. That is, all measurements for a well in the specified period defined by the min/max. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMin")]
        public EndpointQualifiedDateTime DateTimeMin { get; set; }
        /// <summary>
        /// The maximum time index contained within the object. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimMax")]
        public EndpointQualifiedDateTime DateTimeMax { get; set; }
        /// <summary>
        /// The definition of the "current time" index for this object. The current time index is a server query parameter which requests the selection of a single node from a recurring set (e.g., the data related to one point in a time series). That is, the "most recent" (at or before the specified time) measurement for a well. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dTimCurrent")]
        public DateTime? DateTimeCurrent {
            get {
                return dTimCurrentField;
            } 
            set { 
                dTimCurrentField = value;
                this.DateTimeCurrentSpecified = true;
            }
        }

        private DateTime? dTimCurrentField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeCurrentSpecified { get; set; }
        /// <summary>
        /// Contextual data about the well that was tested.
        /// </summary>
        [XmlElement("wellContext")]
        public WellContext WellContext { get; set; }
        /// <summary>
        /// The date and time associated with the measurement. This will normally be the start of the run.
        /// </summary>
        [XmlElement("dTim")]
        public DateTime? DateTime {
            get {
                return dTimField;
            } 
            set { 
                dTimField = value;
                this.DateTimeSpecified = true;
            }
        }

        private DateTime? dTimField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeSpecified { get; set; }
        /// <summary>
        /// The length of time that the instrument box was operating while collecting DTS data.
        /// </summary>
        [XmlElement("runDuration")]
        public TimeMeasure RunDuration { get; set; }
        /// <summary>
        /// A reference to the installed system that was used to make the measurements.
        /// </summary>
        [XmlElement("installedSystemUsed")]
        public RefNameString InstalledSystemUsed { get; set; }
        /// <summary>
        /// A reference to the well log used to record the table of data.
        /// </summary>
        [XmlElement("dataInWellLog")]
        public RefNameString DataInWellLog { get; set; }
        /// <summary>
        /// A reference to the fiber used to record the table of data. This is necessary only in the cases in which a dtsInstalledSystem has a multi-fiber installation. If there is only a single installed fiber, this element is unnecessary.
        /// </summary>
        [XmlElement("connectedToFiber")]
        public RefNameString ConnectedToFiber { get; set; }
        /// <summary>
        /// A pointer to the fiber connection node. If more than one node is available for a well/wellbore, this element is used to specify which node is connected to the instrument box. This name should correspond to the fiberEndPoint/name that is recorded in the installed system object.
        /// </summary>
        [XmlElement("fiberEndConnected")]
        public RefNameString FiberEndConnected { get; set; }
        /// <summary>
        /// A known point of the fiber. This point should correspond to one that is given in the wellboreFiberSchematic, so that the relationship between the length of fiber values in the wellboreFiberSchematic can be related to the values in the measurement table.
        /// </summary>
        [XmlElement("fiberDefinedPoint")]
        public DtsSingleInstalledPoint FiberDefinedPoint { get; set; }
		/// <summary>
        /// An error that occurred during the measurement.
        /// </summary>
        [XmlElement("errorReport")]
        public List<DtsErrorReport> ErrorReport { get; set; }
		/// <summary>
        /// A reference to a processed wellLog that represents this measurement.
        /// </summary>
        [XmlElement("processedLog")]
        public List<DtsProcessedWellLog> ProcessedLog { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		/// <summary>
        /// Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell.
        /// </summary>
        [XmlAttribute("uidWell")]
        public String UidWell { get; set; }
		/// <summary>
        /// Unique identifier for the wellbore. This uniquely represents the wellbore referenced by the (possibly non-unique) nameWellbore.
        /// </summary>
        [XmlAttribute("uidWellbore")]
        public String UidWellbore { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A set of points recorded during the installation process. The information can include the length along the fiber, the measured depth, and a type of point.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsSingleInstalledPoint", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A set of points recorded during the installation process. The information can include the length along the fiber, the measured depth, and a type of point.")]
    public partial class DtsSingleInstalledPoint : Object 
    {

        /// <summary>
        /// The measured depth of the installed point of the fiber. This is optional, because the sender may want to record points that are outside the well.
        /// </summary>
        [XmlElement("md")]
        public MeasuredDepthCoord MD { get; set; }
        /// <summary>
        /// The length along the fiber, from the zero point, for this particular point.
        /// </summary>
        [XmlElement("lengthAlongFiber")]
        public LengthMeasure LengthAlongFiber { get; set; }
        /// <summary>
        /// The type of point that is being recorded.
        /// </summary>
        [XmlElement("type")]
        public InstalledFiberPoint Type {
            get {
                return typeField;
            } 
            set { 
                typeField = value;
                this.TypeSpecified = true;
            }
        }

        private InstalledFiberPoint typeField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TypeSpecified { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This records the result arrays, along with context information, from an Optical Time Domain Reflectometry (OTDR) run. The arrays will define the relative scattered power from the Rayleigh scattering vs distance along the fiber. The actual data values are recorded in a wellLog object, which is referenced in a subelement.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsOtdr", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This records the result arrays, along with context information, from an Optical Time Domain Reflectometry (OTDR) run. The arrays will define the relative scattered power from the Rayleigh scattering vs distance along the fiber. The actual data values are recorded in a wellLog object, which is referenced in a subelement.")]
    public partial class DtsOtdr : Object 
    {

        /// <summary>
        /// The reason the OTDR test was run. The three main reasons are 'pre-installation', which is before the installation of the fiber; 'post-installation', which is used to validate a successful fiber installation; and 'DTS run', which is a quality check of the fiber prior to a DTS run. A fourth permitted value is 'other'.
        /// </summary>
        [XmlElement("reasonForRun")]
        public OTDRReason ReasonForRun { get; set; }
        /// <summary>
        /// The dateTime of the run.
        /// </summary>
        [XmlElement("dTimRun")]
        public DateTime? DateTimeRun {
            get {
                return dTimRunField;
            } 
            set { 
                dTimRunField = value;
                this.DateTimeRunSpecified = true;
            }
        }

        private DateTime? dTimRunField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeRunSpecified { get; set; }
        /// <summary>
        /// A reference to the well log used to record the table of data.
        /// </summary>
        [XmlElement("dataInWellLog")]
        public RefNameString DataInWellLog { get; set; }
        /// <summary>
        /// A pointer to the fiber connection node. If more than one node is available for a well/wellbore, this element is used to specify which node is connected to the instrument box. This name should correspond to the fiberEndPoint/name that is recorded in the installed system object.
        /// </summary>
        [XmlElement("fiberEndConncected")]
        public RefNameString FiberEndConncected { get; set; }
        /// <summary>
        /// A general comment about the OTDR run.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The pump log row are elements defined in the sequence below.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsPumpLogRow", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The pump log row are elements defined in the sequence below.")]
    public partial class DtsPumpLogRow : Object 
    {

        /// <summary>
        /// The speed of the cable.
        /// </summary>
        [XmlElement("cableSpeed")]
        public VelocityMeasure CAbleSpeed { get; set; }
        /// <summary>
        /// The length of fiber pumped into the wellbore.
        /// </summary>
        [XmlElement("fiberPumpedLength")]
        public LengthMeasure FiberPumpedLength { get; set; }
        /// <summary>
        /// The operating pressure of the pump.
        /// </summary>
        [XmlElement("pumpPressure")]
        public PressureMeasure PumpPressure { get; set; }
        /// <summary>
        /// The fluid used in the pumping operation.
        /// </summary>
        [XmlElement("pumpFluid")]
        public String PumpFluid { get; set; }
        /// <summary>
        /// The temperature going into the wellbore.
        /// </summary>
        [XmlElement("temperatureIn")]
        public ThermodynamicTemperatureMeasure TemperatureIn { get; set; }
        /// <summary>
        /// The temperature at the end of the operation
        /// </summary>
        [XmlElement("temperatureOut")]
        public ThermodynamicTemperatureMeasure TemperatureOut { get; set; }
        /// <summary>
        /// Any general remarks about the pumping operation.
        /// </summary>
        [XmlElement("remarks")]
        public String Remarks { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The activity of pumping the fiber downhole.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsPumpActivity", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The activity of pumping the fiber downhole.")]
    public partial class DtsPumpActivity : Object 
    {

        /// <summary>
        /// A name which can be used to reference the pumping activity. In general, a pumping activity does not have a natural name, so that this element will not be often used.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The name of the InstalledFiberInstance that this activity relates to.
        /// </summary>
        [XmlElement("installedFiber")]
        public RefNameString InstalledFiber { get; set; }
		/// <summary>
        /// The date of the pumping activity.
        /// </summary>
        [XmlElement("")]
        public DateTime? PumpingDate {
            get {
                return pumpingDateField;
            } 
            set { 
                pumpingDateField = value;
                this.PumpingDateSpecified = true;
            }
        }

        private DateTime? pumpingDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean PumpingDateSpecified { get; set; }
        /// <summary>
        /// The person in charge of the pumping activity.
        /// </summary>
        [XmlElement("engineerName")]
        public String EngineerName { get; set; }
        /// <summary>
        /// The company that performed the pumping activity.
        /// </summary>
        [XmlElement("serviceCompany")]
        public String ServiceCompany { get; set; }
        /// <summary>
        /// The type of fluid used in the pump.
        /// </summary>
        [XmlElement("pumpFluidType")]
        public String PumpFluidType { get; set; }
        /// <summary>
        /// The type of fluid used in the control line.
        /// </summary>
        [XmlElement("controlLineFluid")]
        public String ControlLineFluid { get; set; }
        /// <summary>
        /// The direction of the pumping.
        /// </summary>
        [XmlElement("pumpDirection")]
        public String PumpDirection { get; set; }
        /// <summary>
        /// The type of end seal on the fiber.
        /// </summary>
        [XmlElement("fiberEndSeal")]
        public String FiberEndSeal { get; set; }
        /// <summary>
        /// The type of cable meter.
        /// </summary>
        [XmlElement("cableMeterType")]
        public String CAbleMeterType { get; set; }
        /// <summary>
        /// The serial number of the cable meter.
        /// </summary>
        [XmlElement("cableMeterSerialNumber")]
        public String CAbleMeterSerialNumber { get; set; }
		/// <summary>
        /// The date the cable meter was calibrated.
        /// </summary>
        [XmlElement("")]
        public DateTime? CAbleMeterCAlibrationDate {
            get {
                return cableMeterCalibrationDateField;
            } 
            set { 
                cableMeterCalibrationDateField = value;
                this.CAbleMeterCAlibrationDateSpecified = true;
            }
        }

        private DateTime? cableMeterCalibrationDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean CAbleMeterCAlibrationDateSpecified { get; set; }
        /// <summary>
        /// True or False. Was a drift run performed? This element should be used to indicate if a drift run was performed or not, where the instance of the drift run (OTDR) is not available. If the OTDR is available, use the OTDRPerformed element to specify the OTDR instance.
        /// </summary>
        [XmlElement("wasDriftRunPerformed")]
        public Boolean WasDriftRunPerformed {
            get {
                return wasDriftRunPerformedField;
            } 
            set { 
                if (OTDRPerformedFieldSpecified) throw new Exception("Cannot set property WasDriftRunPerformed when property OTDRPerformed is already set");
                wasDriftRunPerformedField = value;
                wasDriftRunPerformedFieldSpecified = true;
            }
        }

        private Boolean wasDriftRunPerformedField; 
        private bool wasDriftRunPerformedFieldSpecified = false; 

        /// <summary>
        /// A reference to the OTDR that was run. If an OTDR was run, but there is not instance of the OTDR to reference, choose the wasDriftRunPerformed element, and set it to True.
        /// </summary>
        [XmlElement("OTDRPerformed")]
        public RefNameString OTDRPerformed {
            get {
                return OTDRPerformedField;
            } 
            set { 
                if (wasDriftRunPerformedFieldSpecified) throw new Exception("Cannot set property OTDRPerformed when property WasDriftRunPerformed is already set");
                OTDRPerformedField = value;
                OTDRPerformedFieldSpecified = true;
            }
        }

        private RefNameString OTDRPerformedField; 
        private bool OTDRPerformedFieldSpecified = false; 


        /// <summary>
        /// The length of the excess fiber that was removed.
        /// </summary>
        [XmlElement("excessFiberRecovered")]
        public LengthMeasure ExcessFiberRecovered { get; set; }
        /// <summary>
        /// Information about the pumping activity, that is captured in the pump log.
        /// </summary>
        [XmlElement("pumpLog")]
        public List<DtsPumpLogRow> PumpLog { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A fiber installed in a "U" configuration has two end points that a cable may hook to. When making a measurement, it is useful to be able to say which end was hooked to the input from the instrument box. In order to do this, the fiber ends must be identified. The identifier is a name, along with a description to further aid the interpreter in determining which end was used as the input.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsFiberEndPoint", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A fiber installed in a U configuration has two end points that a cable may hook to. When making a measurement, it is useful to be able to say which end was hooked to the input from the instrument box. In order to do this, the fiber ends must be identified. The identifier is a name, along with a description to further aid the interpreter in determining which end was used as the input.")]
    public partial class DtsFiberEndPoint : Object 
    {

        /// <summary>
        /// A name, unique within the context of the well, for an instrument box cable to hook to.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// Any description of the node that may be useful in identifying the hookup.
        /// </summary>
        [XmlElement("description")]
        public String Description { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Calibration parameters vary from vendor to vendor, depending on the calibration method being used. This is an extension of the general cs_dtsCalibration, and allows for specific parameters associated with an instrument box. The two additional parameters are the offset temperature calibration, and the slope calibration. These allow for a linear shift in temperature vs measurements. Additional offset and slope calibrations may be performed at measurement time.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsInstrumentBoxCalibration", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Calibration parameters vary from vendor to vendor, depending on the calibration method being used. This is an extension of the general cs_dtsCalibration, and allows for specific parameters associated with an instrument box. The two additional parameters are the offset temperature calibration, and the slope calibration. These allow for a linear shift in temperature vs measurements. Additional offset and slope calibrations may be performed at measurement time.")]
    public partial class DtsInstrumentBoxCalibration : Object 
    {

		/// <summary>
        /// The date of the calibration
        /// </summary>
        [XmlElement("")]
        public DateTime? DateTimeCAlibration {
            get {
                return dTimCalibrationField;
            } 
            set { 
                dTimCalibrationField = value;
                this.DateTimeCAlibrationSpecified = true;
            }
        }

        private DateTime? dTimCalibrationField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeCAlibrationSpecified { get; set; }
        /// <summary>
        /// The business associate that performed the calibration.
        /// </summary>
        [XmlElement("calibratedBy")]
        public String CalibratedBy { get; set; }
        /// <summary>
        /// This may be a standard protocol, or a software application.
        /// </summary>
        [XmlElement("calibrationProtocol")]
        public String CAlibrationProtocol { get; set; }
		/// <summary>
        /// Attribute name is the name of the parameter. Optional attribute uom is the unit of measure of the parameter. The value of the element is the value of the parameter. Note that a string value may appear as a parameter.
        /// </summary>
        [XmlElement("parameter")]
        public List<CalibrationParameter> PluggedAndAbandonedrameter { get; set; }
        /// <summary>
        /// Any remarks that may be useful, regarding the calibration information.
        /// </summary>
        [XmlElement("remarks")]
        public String Remarks { get; set; }
        /// <summary>
        /// The temperature offset correction that is applied to the dts instrument box.
        /// </summary>
        [XmlElement("offsetTemperatureCalibration")]
        public ThermodynamicTemperatureMeasure OffsetTemperatureCAlibration { get; set; }
        /// <summary>
        /// The temperature slope correction that is applied to the dts instrument box.
        /// </summary>
        [XmlElement("slopeCalibration")]
        public TemperatureSlopeMeasure SlopeCAlibration { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the calibrationParameter xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="calibrationParameter", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the calibrationParameter xsd type.")]
    public partial class CalibrationParameter : Object 
    {
        public CalibrationParameter() {}
        public CalibrationParameter(String value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		/// <summary>
        /// The unit of measure of the parameter value.
        /// </summary>
        [XmlAttribute("uom")]
        public String Uom { get; set; }
		/// <summary>
        /// The name of the parameter.
        /// </summary>
        [XmlAttribute("name")]
        public String Name { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_nameTag", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("WITSML - Equipment NameTag Schema")]
    public partial class NameTag : Object 
    {

        /// <summary>
        /// The physical identification string of the equipment tag.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The format or encoding specification of the equipment tag. The tag may contain may different pieces of information and knowledge of that information is inherent in the specification. The "identification string" is a mandatory part of the information in a tag.
        /// </summary>
        [XmlElement("numberingScheme")]
        public NameTagNumberingScheme NumberingScheme { get; set; }
        /// <summary>
        /// Identifies the general type of identifier on an item. If multiple identifiers exist on an item, a separate description set for each identifier should be created. For example, a joint of casing may have a barcode label on it along with a painted-on code and an RFID tag attached or embedded into the coupling. The barcode label may in turn be an RFID equipped label. This particular scenario would require populating five nameTags to fully describe and decode all the possible identifiers as follows: 'tagged' - RFID tag embedded in the coupling, 'label' - Serial number printed on the label, 'tagged' - RFID tag embedded into the label, 'label' - Barcode printed on the label, 'painted'- Mill number painted on the pipe body.
        /// </summary>
        [XmlElement("technology")]
        public NameTagTechnology Technology {
            get {
                return technologyField;
            } 
            set { 
                technologyField = value;
                this.TechnologySpecified = true;
            }
        }

        private NameTagTechnology technologyField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean TechnologySpecified { get; set; }
        /// <summary>
        /// An indicator of where the tag is attached to the item. This is used to assist the user in finding where an identifier is located on an item. This optional field also helps to differentiate where an identifier is located when multiple identifiers exist on an item. Most downhole components have a box (female thread) and pin (male thread) end as well as a pipe body in between the ends. Where multiple identifiers are used on an item, it is convenient to have a reference as to which end, or somewhere in the middle, an identifier may be closer to. Some items may have an identifier on a non-standard location, such as on the arm of a hole opener. 'other', by exclusion, tells a user to look elsewhere than on the body or near the ends of an item. Most non-downhole tools will use either 'body', 'other' or not specified as the location tends to lose value with smaller or non threaded items.
        /// </summary>
        [XmlElement("location")]
        public NameTagLocation Location {
            get {
                return locationField;
            } 
            set { 
                locationField = value;
                this.LocationSpecified = true;
            }
        }

        private NameTagLocation locationField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean LocationSpecified { get; set; }
        /// <summary>
        /// When the tag was installed in or on the item. 
        /// </summary>
        [XmlElement("installationDate")]
        public DateTime? InstallationDate {
            get {
                return installationDateField;
            } 
            set { 
                installationDateField = value;
                this.InstallationDateSpecified = true;
            }
        }

        private DateTime? installationDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean InstallationDateSpecified { get; set; }
        /// <summary>
        /// The name of the company that installed the tag. 
        /// </summary>
        [XmlElement("installationCompany")]
        public String InstallationCompany { get; set; }
        /// <summary>
        /// Reference to a manufacturers or installers installation description, code, or method. 
        /// </summary>
        [XmlElement("mountingCode")]
        public String MountingCode { get; set; }
        /// <summary>
        /// A comment or remark about the tag.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The instrument box used for distributed temperature surveys
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsInstrumentBox", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The instrument box used for distributed temperature surveys")]
    public partial class DtsInstrumentBox : Object 
    {

        /// <summary>
        /// A name for the instrument box. This can be used to access the instrument box.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The ultimate manufacturer of the instrument box.
        /// </summary>
        [XmlElement("manufacturer")]
        public String Manufacturer { get; set; }
		/// <summary>
        /// The date the manufacturing of the instrument box was completed.
        /// </summary>
        [XmlElement("")]
        public DateTime? ManufacturingDate {
            get {
                return manufacturingDateField;
            } 
            set { 
                manufacturingDateField = value;
                this.ManufacturingDateSpecified = true;
            }
        }

        private DateTime? manufacturingDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ManufacturingDateSpecified { get; set; }
        /// <summary>
        /// The type of instrument box used.
        /// </summary>
        [XmlElement("type")]
        public String Type { get; set; }
		/// <summary>
        /// An identification tag for the instrument box. A serial number is a type of identification tag however some tags contain many pieces of information. This structure just identifies the tag and does not describe the contents.
        /// </summary>
        [XmlElement("nameTag")]
        public List<NameTag> NameTag { get; set; }
        /// <summary>
        /// The version of the software installed in the instrument box.
        /// </summary>
        [XmlElement("softwareVersion")]
        public String SoftwareVersion { get; set; }
		/// <summary>
        /// Information about the calibration of the instrument box that was performed. This includes factory calibrations before shipping, and bench calibrations. This does not include calibrations made in preparation for taking measurements.
        /// </summary>
        [XmlElement("factoryCalibration")]
        public List<DtsInstrumentBoxCalibration> FactoryCAlibration { get; set; }
        /// <summary>
        /// Near distance of the oven from the beginning of the fiber.
        /// </summary>
        [XmlElement("internalOvenLocationNear")]
        public LengthMeasure InternalOvenLocationNear { get; set; }
        /// <summary>
        /// Far distance of the oven from the beginning of the fiber.
        /// </summary>
        [XmlElement("internalOvenLocationFar")]
        public LengthMeasure InternalOvenLocationFar { get; set; }
        /// <summary>
        /// The temperature of the oven.
        /// </summary>
        [XmlElement("ovenSetPoint")]
        public ThermodynamicTemperatureMeasure OvenSetPoint { get; set; }
        /// <summary>
        /// The cable used to test the instrument box.
        /// </summary>
        [XmlElement("testCable")]
        public String TestCAble { get; set; }
        /// <summary>
        /// The offset setting applied to the instrument box based on the factory or bench calibration.
        /// </summary>
        [XmlElement("offset")]
        public String Offset { get; set; }
        /// <summary>
        /// The power loss over the length of the cable.
        /// </summary>
        [XmlElement("differentialLossSetting")]
        public GeneralMeasureType DifferentialLossSetting { get; set; }
		/// <summary>
        /// Additional parameters to define the instrument box as a piece of equipment. These should not be parameters to define the installation or use of the box in the wellbore, or other system. This element should be used only if an appropriate parameter is not available as an element, or in the calibration operation.
        /// </summary>
        [XmlElement("parameter")]
        public List<IndexedObject> PluggedAndAbandonedrameter { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="indexedObject", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the indexedObject xsd type.")]
    public partial class IndexedObject : Object 
    {
        public IndexedObject() {}
        public IndexedObject(String value, String uom)
        {
            this.Uom = uom;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " " + Uom;
        }

		
        [XmlAttribute("index")]
        public Int16 Index { get; set; }
		
        [XmlAttribute("name")]
        public String Name { get; set; }
		
        [XmlAttribute("uom")]
        public String Uom { get; set; }
		
        [XmlAttribute("description")]
        public String Description { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The instrument box used for distributed temperature surveys
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsBoxInformation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The instrument box used for distributed temperature surveys")]
    public partial class DtsBoxInformation : Object 
    {

		/// <summary>
        /// The date the instrument box was installed.
        /// </summary>
        [XmlElement("")]
        public DateTime? InstallationDate {
            get {
                return installationDateField;
            } 
            set { 
                installationDateField = value;
                this.InstallationDateSpecified = true;
            }
        }

        private DateTime? installationDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean InstallationDateSpecified { get; set; }
        /// <summary>
        /// The company that installed the instrument box in the wellbore measurement system.
        /// </summary>
        [XmlElement("installationCompany")]
        public String InstallationCompany { get; set; }
		/// <summary>
        /// The date the instrument box was de-installed from the wellbore.
        /// </summary>
        [XmlElement("")]
        public DateTime? DeInstallationDate {
            get {
                return deInstallationDateField;
            } 
            set { 
                deInstallationDateField = value;
                this.DeInstallationDateSpecified = true;
            }
        }

        private DateTime? deInstallationDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DeInstallationDateSpecified { get; set; }
        /// <summary>
        /// The properties of the instrument box.
        /// </summary>
        [XmlElement("instrumentBox")]
        public DtsInstrumentBox InstrumentBox { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// Calibration parameters vary from vendor to vendor, depending on the calibration method being used. This is a general type that allows a calibration date, business associate, and many name/value pairs.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsCalibration", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Calibration parameters vary from vendor to vendor, depending on the calibration method being used. This is a general type that allows a calibration date, business associate, and many name/value pairs.")]
    public partial class DtsCalibration : Object 
    {

		/// <summary>
        /// The date of the calibration
        /// </summary>
        [XmlElement("")]
        public DateTime? DateTimeCAlibration {
            get {
                return dTimCalibrationField;
            } 
            set { 
                dTimCalibrationField = value;
                this.DateTimeCAlibrationSpecified = true;
            }
        }

        private DateTime? dTimCalibrationField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateTimeCAlibrationSpecified { get; set; }
        /// <summary>
        /// The business associate that performed the calibration.
        /// </summary>
        [XmlElement("calibratedBy")]
        public String CalibratedBy { get; set; }
        /// <summary>
        /// This may be a standard protocol, or a software application.
        /// </summary>
        [XmlElement("calibrationProtocol")]
        public String CAlibrationProtocol { get; set; }
		/// <summary>
        /// Attribute name is the name of the parameter. Optional attribute uom is the unit of measure of the parameter. The value of the element is the value of the parameter. Note that a string value may appear as a parameter.
        /// </summary>
        [XmlElement("parameter")]
        public List<CalibrationParameter> PluggedAndAbandonedrameter { get; set; }
        /// <summary>
        /// Any remarks that may be useful, regarding the calibration information.
        /// </summary>
        [XmlElement("remarks")]
        public String Remarks { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The The power loss for one way travel of a beam of light, usually measured in decibels per unit length. It is necessary to include both the value (and its unit) and the wavelength. The wavelength varies with the refractive index, while the frequency remains constant. The wavelength given to specify this type is the wavelength in a vacuum (refractive index = 1).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsOneWayLoss", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The The power loss for one way travel of a beam of light, usually measured in decibels per unit length. It is necessary to include both the value (and its unit) and the wavelength. The wavelength varies with the refractive index, while the frequency remains constant. The wavelength given to specify this type is the wavelength in a vacuum (refractive index = 1).")]
    public partial class DtsOneWayLoss : Object 
    {

        /// <summary>
        /// The value of the one way loss per unit of length. The usual uom is decibels per kilometre (dB/km), although this might vary depending on the calibration method used.
        /// </summary>
        [XmlElement("value")]
        public GeneralMeasureType Value { get; set; }
        /// <summary>
        /// The frequency (and uom) for which the one-way loss is measured.
        /// </summary>
        [XmlElement("frequency")]
        public FrequencyMeasure Frequency { get; set; }
        /// <summary>
        /// The wavelength (and uom) for which the one-way loss is measured. The reported wavelength should be the wavelength of the light in a vacuum.
        /// </summary>
        [XmlElement("wavelength")]
        public LengthMeasure Wavelength { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The refractive index of a material depends on the frequency or wavelength of the light. Hence it is necessary to include both the value (a unitless number) and the frequency or wavelength. The frequency will be a quantity type with a frequency unit, such as Hz, kHz, or MHz. The wavelength will be a quantity type with a length unit, such as m, cm, um, in, or ft.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsRefractiveIndex", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The refractive index of a material depends on the frequency or wavelength of the light. Hence it is necessary to include both the value (a unitless number) and the frequency or wavelength. The frequency will be a quantity type with a frequency unit, such as Hz, kHz, or MHz. The wavelength will be a quantity type with a length unit, such as m, cm, um, in, or ft.")]
    public partial class DtsRefractiveIndex : Object 
    {

        /// <summary>
        /// The value of the refractive index.
        /// </summary>
        [XmlElement("value")]
        public Double? Value { get; set; }
        /// <summary>
        /// The frequency (and uom) for which the refractive index is measured.
        /// </summary>
        [XmlElement("frequency")]
        public FrequencyMeasure Frequency { get; set; }
        /// <summary>
        /// The wavelength (and uom) for which the refractive index is measured. The reported wavelength should be the wavelength of the light in a vacuum.
        /// </summary>
        [XmlElement("wavelength")]
        public LengthMeasure Wavelength { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the typeOptionalClassString xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="typeOptionalClassString", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the typeOptionalClassString xsd type.")]
    public partial class TypeOptionalClassString : Object 
    {
        public TypeOptionalClassString() {}
        public TypeOptionalClassString(String value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// This identifies the classification system to which the class belongs. 
        /// </summary>
        [XmlAttribute("classType")]
        public String ClassType { get; set; }
		
        [XmlText]
        public String Value { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The optical fiber used for distributed temperature surveys
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsFiber", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The optical fiber used for distributed temperature surveys")]
    public partial class DtsFiber : Object 
    {

        /// <summary>
        /// A human understandable name for the fiber. This is used for identification of the instance.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The mode of fiber.
        /// </summary>
        [XmlElement("mode")]
        public FiberMode Mode { get; set; }
		/// <summary>
        /// Zero or more instances that allow other classifications to be assigned to the fiber.
        /// </summary>
        [XmlElement("type")]
        public List<TypeOptionalClassString> Type { get; set; }
        /// <summary>
        /// The type of coating on the fiber.
        /// </summary>
        [XmlElement("coating")]
        public String Coating { get; set; }
        /// <summary>
        /// The type of jacket covering the fiber.
        /// </summary>
        [XmlElement("jacket")]
        public String Jacket { get; set; }
        /// <summary>
        /// The inner diameter of the core, generally measured in microns (um).
        /// </summary>
        [XmlElement("coreDiameter")]
        public LengthMeasure CoreDiameter { get; set; }
        /// <summary>
        /// The diameter of the core plus the cladding, generally measured in microns (um).
        /// </summary>
        [XmlElement("claddedDiameter")]
        public LengthMeasure CladdedDiameter { get; set; }
        /// <summary>
        /// The diameter of the cable and all its sheathing, generally measured in microns (um). This is intended to be the diameter of the cable on the spool.
        /// </summary>
        [XmlElement("outsideDiameter")]
        public LengthMeasure OutsideDiameter { get; set; }
		/// <summary>
        /// The refractive index of the fiber. Also included is the frequency in Hz for which this refractive index is valid. There may be multiple instances of this element.
        /// </summary>
        [XmlElement("refractiveIndex")]
        public List<DtsRefractiveIndex> RefractiveIndex { get; set; }
		/// <summary>
        /// The power loss (usually in decibels) per unit of length of the fiber. Also included is the frequency for which this loss is measured. There ay be multiple instances of this element.
        /// </summary>
        [XmlElement("oneWayLoss")]
        public List<DtsOneWayLoss> OneWayLoss { get; set; }
		/// <summary>
        /// Additional parameters to define the fiber as a material. These should not be parameters to define the installation of the fiber in a well, or other system. This element should be used only if an appropriate parameter is not available as an element, or in the calibration operation.
        /// </summary>
        [XmlElement("parameter")]
        public List<IndexedObject> PluggedAndAbandonedrameter { get; set; }
        /// <summary>
        /// The spool number located on the particular spool. The spool number may contain alphanumeric characters.
        /// </summary>
        [XmlElement("spoolNumberTag")]
        public String SpoolNumberTag { get; set; }
        /// <summary>
        /// The length of the fiber on the spool when purchased.
        /// </summary>
        [XmlElement("spoolLength")]
        public LengthMeasure SpoolLength { get; set; }
		/// <summary>
        /// A fiber may go through several manufacturers for its various parts. The supplier is the final company in the chain that supplies the fiber to the end user.
        /// </summary>
        [XmlElement("")]
        public DateTime? SupplyDate {
            get {
                return supplyDateField;
            } 
            set { 
                supplyDateField = value;
                this.SupplyDateSpecified = true;
            }
        }

        private DateTime? supplyDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean SupplyDateSpecified { get; set; }
        /// <summary>
        /// A fiber may go through several manufacturers for its various parts. The supplier is the final company in the chain that supplies the fiber to the end user.
        /// </summary>
        [XmlElement("supplier")]
        public String Supplier { get; set; }
        /// <summary>
        /// The model number (alphanumeric) that is used by the supplier to reference the type of fiber that is supplied to the user.
        /// </summary>
        [XmlElement("supplierModelNumber")]
        public String SupplierModelNumber { get; set; }
		/// <summary>
        /// Information about calibrations and quality checks that were performed on the cable at the factory. This is not to include calibrations that are run at installation time and at measurement time.
        /// </summary>
        [XmlElement("factoryCalibration")]
        public List<DtsCalibration> FactoryCAlibration { get; set; }
		/// <summary>
        /// A reference to a dtsInstalledSytem object that previously used the fiber.
        /// </summary>
        [XmlElement("installationHistory")]
        public List<RefNameString> InstallationHistory { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// The optical fiber used for distributed temperature surveys
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_dtsFiberInformation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The optical fiber used for distributed temperature surveys")]
    public partial class DtsFiberInformation : Object 
    {

		/// <summary>
        /// The date the fiber is installed.
        /// </summary>
        [XmlElement("")]
        public DateTime? InstallationDate {
            get {
                return installationDateField;
            } 
            set { 
                installationDateField = value;
                this.InstallationDateSpecified = true;
            }
        }

        private DateTime? installationDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean InstallationDateSpecified { get; set; }
        /// <summary>
        /// The company that installed the fiber in the wellbore.
        /// </summary>
        [XmlElement("installationCompany")]
        public String InstallationCompany { get; set; }
		/// <summary>
        /// The date the fiber was de-installed from the wellbore.
        /// </summary>
        [XmlElement("")]
        public DateTime? DeInstallationDate {
            get {
                return deInstallationDateField;
            } 
            set { 
                deInstallationDateField = value;
                this.DeInstallationDateSpecified = true;
            }
        }

        private DateTime? deInstallationDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DeInstallationDateSpecified { get; set; }
        /// <summary>
        /// The diameter of the capillary tube into which one or more fibers will be installed. If the installation has fibers that go to different wellbores, only those fibers installed in the parent wellbore should be included in this instance.
        /// </summary>
        [XmlElement("capillaryTubeDiameter")]
        public LengthMeasure CapillaryTubeDiameter { get; set; }
		/// <summary>
        /// The properties of the fiber or fibers installed in the wellbore.
        /// </summary>
        [XmlElement("fiber")]
        public List<DtsFiber> Fiber { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// This class represents the endpointQualifiedDate xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="endpointQualifiedDate", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("This class represents the endpointQualifiedDate xsd type.")]
    public partial class EndpointQualifiedDate : Object 
    {
        public EndpointQualifiedDate() {}
        public EndpointQualifiedDate(DateTime value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

		/// <summary>
        /// The default is "inclusive".
        /// </summary>
        [XmlAttribute("endpoint")]
        private string EndpointSurrogate
        {
            get { return Endpoint.Name; }
            set { Endpoint.Name = value; }
        }

        [XmlIgnore]
        public EndpointQualifier Endpoint {
            get {
                return endpointField;
            } 
            set { 
                endpointField = value;
                this.EndpointSpecified = true;
            }
        }

        private EndpointQualifier endpointField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EndpointSpecified { get; set; }
		
        [XmlText]
        public DateTime Value { get; set; }
    }
    }

    /// <summary>
    /// The optical fiber is installed in a wellbore and attached to an instrument box. Calibrations are performed. In general, this should be a subelement of a DTS object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="obj_dtsInstalledSystem", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("The optical fiber is installed in a wellbore and attached to an instrument box. Calibrations are performed. In general, this should be a subelement of a DTS object.")]
    public partial class DtsInstalledSystem : Object 
    {

        /// <summary>
        /// Human recognizable context for the well that contains the wellbore.
        /// </summary>
        [XmlElement("nameWell")]
        public String NameWell { get; set; }
        /// <summary>
        /// Human recognizable context for the wellbore that contains the installed system.
        /// </summary>
        [XmlElement("nameWellbore")]
        public String NameWellbore { get; set; }
        /// <summary>
        /// Human recognizable context for the dts.
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }
        /// <summary>
        /// The minimum date index contained within the object. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. That is, all measurements for a well in the specified period defined by the min/max. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dateMin")]
        public EndpointQualifiedDate DateMin { get; set; }
        /// <summary>
        /// The maximum date index contained within the object. The minimum and maximum indexes are server query parameters and will be populated with valid values in a "get" result. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("dateMax")]
        public EndpointQualifiedDate DateMax { get; set; }
		/// <summary>
        /// The definition of the "current date" index for this object. The current date index is a server query parameter which requests the selection of a single node from a recurring set (e.g., the data related to one point in a date series). That is, the "most recent" (at or before the specified date) installation for a well. See the WITSML API Specification appendix on "Special Handling" of growing objects for a description of the behavior related to this parameter.
        /// </summary>
        [XmlElement("")]
        public DateTime? DateCurrent {
            get {
                return dateCurrentField;
            } 
            set { 
                dateCurrentField = value;
                this.DateCurrentSpecified = true;
            }
        }

        private DateTime? dateCurrentField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateCurrentSpecified { get; set; }
        /// <summary>
        /// Contextual data about the well in which the system was installed.
        /// </summary>
        [XmlElement("wellContext")]
        public WellContext WellContext { get; set; }
        /// <summary>
        /// Is this a planned installation in a well, or has the installation already occurred. Note that the default value is 'false', which states that this is an actual installation.
        /// </summary>
        [XmlElement("isPlanned")]
        public Boolean? IsPlanned {
            get {
                return isPlannedField;
            } 
            set { 
                isPlannedField = value;
                this.IsPlannedSpecified = true;
            }
        }

        private Boolean? isPlannedField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IsPlannedSpecified { get; set; }
        /// <summary>
        /// Information about the fiber used, and its installation.
        /// </summary>
        [XmlElement("fiberInformation")]
        public DtsFiberInformation FiberInformation { get; set; }
        /// <summary>
        /// Information about the instrument box used, and its installation.
        /// </summary>
        [XmlElement("instrumentBoxInformation")]
        public DtsBoxInformation InstrumentBoxInformation { get; set; }
        /// <summary>
        /// The configuration of the fiber installation. Example values would be linear, linear with gauge, J, U.
        /// </summary>
        [XmlElement("fiberConfiguration")]
        public String FiberConfiguration { get; set; }
		/// <summary>
        /// A fiber installed with a "U" configuration will have two ends available for hookup to an instrument box. In order to record which end is cabled to the instrument box on a particular measurement run, it is necessary to identify the two ends. This complex type allows a name and description for each end, so that it may be identified in a later use. This may also be useful when multiple fibers in multiple wellbores converge at the same wellhead.
        /// </summary>
        [XmlElement("fiberEndPoint")]
        public List<DtsFiberEndPoint> FiberEndPoint { get; set; }
        /// <summary>
        /// The length of the fiber installed in the wellbore.
        /// </summary>
        [XmlElement("fiberLength")]
        public LengthMeasure FiberLength { get; set; }
        /// <summary>
        /// A table of values along the length along the fiber.
        /// </summary>
        [XmlElement("wellboreFiberSchematic")]
        public List<DtsSingleInstalledPoint> WellboreFiberSchematic { get; set; }
        /// <summary>
        /// Total light budget available for the installation. This is generally measured in decibels, and indicates the total power loss for two-way travel of the light in the installed fiber.
        /// </summary>
        [XmlElement("opticalBudget")]
        public GeneralMeasureType OperatingticalBudget { get; set; }
        /// <summary>
        /// The activity of pumping the fiber downhole
        /// </summary>
        [XmlElement("pumpActivity")]
        public DtsPumpActivity PumpActivity { get; set; }
		/// <summary>
        /// This captures the data from the pre-installation and post-installation OTDR tests run on the fiber. A standard quality control program would include these two, but the schema allows for more than two if additional runs associated with the installation of the fiber are performed. OTDR runs associated with a measurement are given as a child of the measurementInformation element.
        /// </summary>
        [XmlElement("otdrInstallationTest")]
        public List<DtsOtdr> OtdrInstallationTest { get; set; }
		/// <summary>
        /// Any calibration other than the ones explicitly given may be recorded here. This is a general calibration type, which is populated with name/value pairs.
        /// </summary>
        [XmlElement("installationCalibration")]
        public List<DtsCalibration> InstallationCAlibration { get; set; }
        /// <summary>
        /// If an instrument box is changed, for example, but the fiber remains the same, this instance of installed fiber is given to record that change. This element refers to a previous installed fiber, on which this one is based. For example, the wellboreFiberSchematic is unchanged, and may be obtained from the previous instance of installed fiber that is referenced here.
        /// </summary>
        [XmlElement("basedOnInstalledFiber")]
        public RefNameString BasedOnInstalledFiber { get; set; }
        /// <summary>
        /// A container element that contains elements that are common to all data objects. 
        /// </summary>
        [XmlElement("commonData")]
        public CommonData CommonData { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
		/// <summary>
        /// Unique identifier for the well. This uniquely represents the well referenced by the (possibly non-unique) nameWell.
        /// </summary>
        [XmlAttribute("uidWell")]
        public String UidWell { get; set; }
		/// <summary>
        /// Unique identifier for the wellbore. This uniquely represents the wellbore referenced by the (possibly non-unique) nameWellbore.
        /// </summary>
        [XmlAttribute("uidWellbore")]
        public String UidWellbore { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// A structure for WITSML query parameters. The intent is to allow a query for all objects within an index range (whether or not the object is growing). These would typically be something like a daily report.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentInfoQueryParam", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A structure for WITSML query parameters. The intent is to allow a query for all objects within an index range (whether or not the object is growing). These would typically be something like a daily report.")]
    public partial class DocumentInfoQueryParam : Object 
    {

        /// <summary>
        /// The minimum start time for an object. This only applies to objects with a root level date and/or dateTime element(s). The objects may or not be growing objects but the See the API specification for behavior related to this query parameter.
        /// </summary>
        [XmlElement("dTimMin")]
        public EndpointQualifiedDateTime DateTimeMin { get; set; }
        /// <summary>
        /// The maximum start time for an object. This only applies to objects with a root level date and/or dateTime element(s). See the API specification for behavior related to this query parameter.
        /// </summary>
        [XmlElement("dTimMax")]
        public EndpointQualifiedDateTime DateTimeMax { get; set; }
    }
    }

    namespace ComponentSchemas 
    {
    /// <summary>
    /// An event type captures the basic information about an event that has affected the data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentEvent", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("An event type captures the basic information about an event that has affected the data.")]
    public partial class DocumentEvent : Object 
    {

        /// <summary>
        /// The date on which the event took place.
        /// </summary>
        [XmlElement("eventDate")]
        public DateTime? EventDate { get; set; }
        /// <summary>
        /// The kind of event event.
        /// </summary>
        [XmlElement("eventType")]
        public String EventType { get; set; }
        /// <summary>
        /// The party responsible for the event.
        /// </summary>
        [XmlElement("responsibleParty")]
        public String ResponsiblePluggedAndAbandonedrty { get; set; }
        /// <summary>
        /// A free form comment that can further define the event that occurred.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentSecurityInfo", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("Information about the security classification of the document. This is intended as a documentation of the security so that the file will not inadvertently be sent to someone who is not allowed access to the data. This block also carries a date that the security classification expires. For example, a well log is confidential for a period of time, and then becomes open. All security classes are characterized by their classification systems.")]
    public partial class DocumentSecurityInfo : Object 
    {

        /// <summary>
        /// The security class in which this document is classified. Examples would be confidential, partner confidential, tight. The meaning of the class is determined by the System in which it is defined.
        /// </summary>
        [XmlElement("class")]
        public String Class { get; set; }
        /// <summary>
        /// The security classification system. This gives context to the meaning of the Class value.
        /// </summary>
        [XmlElement("securitySystem")]
        public String SecuritySystem { get; set; }
        /// <summary>
        /// The date on which this security class is no longer applicable.
        /// </summary>
        [XmlElement("endDate")]
        public DateTime? EndDate {
            get {
                return endDateField;
            } 
            set { 
                endDateField = value;
                this.EndDateSpecified = true;
            }
        }

        private DateTime? endDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean EndDateSpecified { get; set; }
        /// <summary>
        /// A general comment to further define the security class.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
		/// <summary>
        /// Extensions to the schema based on a name-value construct.
        /// </summary>
        [XmlElement("extensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue { get; set; }
		
        [XmlAttribute("uid")]
        public String Uid { get; set; }
    }
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="cs_documentFileCreation", Namespace="http://www.prodml.org/schemas/1series")]
    [Description("A block of information about the creation of the XML file. This is different than the creation of the data that is included within the file.")]
    public partial class DocumentFileCreation : Object 
    {

        /// <summary>
        /// The date and time that the file was created.
        /// </summary>
        [XmlElement("fileCreationDate")]
        public DateTime? FileCreationDate { get; set; }
        /// <summary>
        /// If appropriate, the software that created the file. This is a free form string, and may include whatever information is deemed relevant.
        /// </summary>
        [XmlElement("softwareName")]
        public String SoftwareName { get; set; }
        /// <summary>
        /// The person or business associate that created the file.
        /// </summary>
        [XmlElement("fileCreator")]
        public String FileCreator { get; set; }
        /// <summary>
        /// Any comment that would be useful to further explain the creation of this instance document.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
    }
    }

    /// <summary>
    /// This class represents the obj_wellTests xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("wellTests", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_wellTests xsd type.")]
    public partial class WellTestList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Information about a single well test.
        /// </summary>
        [XmlElement("wellTest")]
        public List<WellTest> WellTest { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return WellTest;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_timeSeriesStatistics xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("timeSeriesStatistics", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_timeSeriesStatistics xsd type.")]
    public partial class TimeSeriesStatisticList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance.
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Statistics about a single range of time. This is a VIEW of the time series data and represents derived information about that series. As such, it is not persisted and cannot be added, updated or deleted from a persistent server. The statistics view uses the same identity (including uid) as the time series data object.
        /// </summary>
        [XmlElement("timeSeriesStatistic")]
        public List<TimeSeriesStatistic> TimeSeriesStatistic { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return TimeSeriesStatistic;
			}
        }
		/// <summary>
        /// Data object schema version.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_timeSeriesDatas xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("timeSeriesDatas", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_timeSeriesDatas xsd type.")]
    public partial class TimeSeriesDataList : AbstractObject , IEnergisticsCollection
    {

		/// <summary>
        /// Information about a single time series.
        /// </summary>
        [XmlElement("timeSeriesData")]
        public List<TimeSeriesData> TimeSeriesData { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return TimeSeriesData;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_report xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("report", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_report xsd type.")]
    public partial class Report : AbstractObject 
    {

        /// <summary>
        /// The type of report. This should define and constrain the expected content of the report.
        /// </summary>
        [XmlElement("kind")]
        public String Kind { get; set; }
        /// <summary>
        /// The tile of the report if different from the name of the report.
        /// </summary>
        [XmlElement("title")]
        public NameStruct Title { get; set; }
		/// <summary>
        /// The date that the report represents (i.e., not a year or month). Only one of date, month or year should be specified.
        /// </summary>
        [XmlElement("")]
        public DateTime? Date {
            get {
                return dateField;
            } 
            set { 
                dateField = value;
                this.DateSpecified = true;
            }
        }

        private DateTime? dateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateSpecified { get; set; }
		/// <summary>
        /// The ending date that the report represents if it represents an interval.
        /// </summary>
        [XmlElement("")]
        public DateTime? DateEnd {
            get {
                return dateEndField;
            } 
            set { 
                dateEndField = value;
                this.DateEndSpecified = true;
            }
        }

        private DateTime? dateEndField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean DateEndSpecified { get; set; }
        /// <summary>
        /// The month that the report represents (i.e., not a year, date or date range). Only one of date, month or year should be specified.
        /// </summary>
        [XmlElement("month")]
        public String Month { get; set; }
        /// <summary>
        /// The year that the report represents (i.e., not a month, date or date range). Only one of date, month or year should be specified.
        /// </summary>
        [XmlElement("year")]
        public Int32? Year {
            get {
                return yearField;
            } 
            set { 
                yearField = value;
                this.YearSpecified = true;
            }
        }

        private Int32? yearField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean YearSpecified { get; set; }
        /// <summary>
        /// A textual comment about the report.
        /// </summary>
        [XmlElement("comment")]
        public String Comment { get; set; }
        /// <summary>
        /// The current report version.
        /// </summary>
        [XmlElement("reportVersion")]
        public String ReportVersion { get; set; }
        /// <summary>
        /// The current document version status.
        /// </summary>
        [XmlElement("reportStatus")]
        public ReportVersionStatus ReportStatus {
            get {
                return reportStatusField;
            } 
            set { 
                reportStatusField = value;
                this.ReportStatusSpecified = true;
            }
        }

        private ReportVersionStatus reportStatusField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ReportStatusSpecified { get; set; }
        /// <summary>
        /// The name of the facility which is represented by this report. The name can be qualified by a naming system. This also defines the kind of facility.
        /// </summary>
        [XmlElement("installation")]
        public FacilityIdentifierStruct Installation { get; set; }
		/// <summary>
        /// The name and type of a facility whose context is relevant to the represented installation.
        /// </summary>
        [XmlElement("contextFacility")]
        public List<FacilityIdentifierStruct> ContextFacility { get; set; }
        /// <summary>
        /// The operator of the facilities in the report.
        /// </summary>
        [XmlElement("operator")]
        public BusinessAssociate Operator { get; set; }
        /// <summary>
        /// The geographic context of the report.
        /// </summary>
        [XmlElement("geographicContext")]
        public GeographicContext GeographicContext { get; set; }
		/// <summary>
        /// The date that the report was issued.
        /// </summary>
        [XmlElement("")]
        public DateTime? IssueDate {
            get {
                return issueDateField;
            } 
            set { 
                issueDateField = value;
                this.IssueDateSpecified = true;
            }
        }

        private DateTime? issueDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean IssueDateSpecified { get; set; }
        /// <summary>
        /// The person or company that issued the report. This may contain the role of the person or company within the context of the report.
        /// </summary>
        [XmlElement("issuedBy")]
        public BusinessAssociate IssuedBy { get; set; }
		/// <summary>
        /// The date that the report was approved.
        /// </summary>
        [XmlElement("")]
        public DateTime? ApprovalDate {
            get {
                return approvalDateField;
            } 
            set { 
                approvalDateField = value;
                this.ApprovalDateSpecified = true;
            }
        }

        private DateTime? approvalDateField; 

		
        [XmlIgnore]
		[Browsable(false)]
        public Boolean ApprovalDateSpecified { get; set; }
        /// <summary>
        /// The person or company that approved the report. This may contain the role of the person or company within the context of the report.
        /// </summary>
        [XmlElement("approver")]
        public BusinessAssociate Approver { get; set; }
        /// <summary>
        /// A container element that can contain custom or user defined data elements.
        /// </summary>
        [XmlElement("customData")]
        public CustomData CustomData { get; set; }
    }

    /// <summary>
    /// This class represents the obj_productVolumes xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("productVolumes", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_productVolumes xsd type.")]
    public partial class ProductVolumeList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Information about a single productVolume. 
        /// </summary>
        [XmlElement("productVolume")]
        public List<ProductVolume> ProductVolume { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return ProductVolume;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_productionOperations xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("productionOperations", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_productionOperations xsd type.")]
    public partial class ProductionOperationList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Information about a single productionOperation. 
        /// </summary>
        [XmlElement("productionOperation")]
        public List<ProductionOperation> ProductionOperatingeration { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return ProductionOperatingeration;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_productFlowModels xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("productFlowModels", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_productFlowModels xsd type.")]
    public partial class ProductFlowModelList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Information about a single Product Flow Model. 
        /// </summary>
        [XmlElement("productFlowModel")]
        public List<ProductFlowModel> ProductFlowModel { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return ProductFlowModel;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the documenti nstance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_fluidSamples xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("fluidSamples", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_fluidSamples xsd type.")]
    public partial class FluidSampleList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Information about a single Fluid Sample. 
        /// </summary>
        [XmlElement("fluidSample")]
        public List<FluidSample> FluidSample { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return FluidSample;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the documenti nstance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_fluidAnalysisResults xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("fluidAnalysisResults", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_fluidAnalysisResults xsd type.")]
    public partial class FluidAnalysisResultList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Information about a single Fluid Analysis Result. 
        /// </summary>
        [XmlElement("fluidAnalysisResult")]
        public List<FluidAnalysisResult> FluidAnalysisResult { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return FluidAnalysisResult;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the documenti nstance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_fluidAnalysiss xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("fluidAnalysiss", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_fluidAnalysiss xsd type.")]
    public partial class FluidAnalysisList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance. 
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Information about a single Fluid Analysis. 
        /// </summary>
        [XmlElement("fluidAnalysis")]
        public List<FluidAnalysis> FluidAnalysis { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return FluidAnalysis;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the documenti nstance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    /// <summary>
    /// This class represents the obj_dtsMeasurements xsd type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Energistics.Generator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
    [System.Xml.Serialization.XmlRootAttribute("dtsMeasurements", Namespace="http://www.prodml.org/schemas/1series", IsNullable=false)]
    [Description("This class represents the obj_dtsMeasurements xsd type.")]
    public partial class DtsMeasurementList : AbstractObject , IEnergisticsCollection
    {

        /// <summary>
        /// Information about the XML message instance.
        /// </summary>
        [XmlElement("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; }
		/// <summary>
        /// Main wrapper for all the distributed temperature survey information about the measurement. Note that this object must be accompanied by a wellLog object in order to be complete.
        /// </summary>
        [XmlElement("dtsMeasurement")]
        public List<DtsMeasurement> DtsMeasurement { get; set; }
        [XmlIgnore]		
        public IList Items
        {
		    get
			{
			    return DtsMeasurement;
			}
        }
		/// <summary>
        /// Data object schema version. The fourth level must match the version of the schema constraints (enumerations and XML loader files) that are assumed by the document instance.
        /// </summary>
        [XmlAttribute("version")]
        public String Version { get; set; }
    }

    #endregion

    #region Enumerations
    namespace ReferenceData {
        /// <summary>
        /// This class represents the VolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the VolumeUom xsd enumeration.")]
        public enum VolumeUom 
        {
        
          m3,
        
          [XmlEnum("acre.ft")]
          acreft,
        
          bbl,
        
          bcf,
        
          cm3,
        
          dm3,
        
          flozUK,
        
          flozUS,
        
          ft3,
        
          galUK,
        
          galUS,
        
          [XmlEnum("ha.m")]
          ham,
        
          hL,
        
          in3,
        
          [XmlEnum("1000ft3")]
          Item1000ft3,
        
          km3,
        
          L,
        
          Mbbl,
        
          Mcf,
        
          [XmlEnum("M(ft3)")]
          Mft3,
        
          mi3,
        
          mL,
        
          [XmlEnum("M(m3)")]
          Mm3,
        
          mm3,
        
          MMbbl,
        
          ptUK,
        
          ptUS,
        
          qtUK,
        
          qtUS,
        
          tcf,
        
          [XmlEnum("um2.m")]
          um2m,
        
          yd3
        }
        /// <summary>
        /// This class represents the VolumeFlowRateUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the VolumeFlowRateUom xsd enumeration.")]
        public enum VolumeFlowRateUom 
        {
        
          [XmlEnum("m3/s")]
          m3s,
        
          [XmlEnum("bbl/d")]
          bbld,
        
          [XmlEnum("bbl/hr")]
          bblhr,
        
          [XmlEnum("bbl/min")]
          bblmin,
        
          [XmlEnum("cm3/30min")]
          cm330min,
        
          [XmlEnum("cm3/h")]
          cm3h,
        
          [XmlEnum("cm3/min")]
          cm3min,
        
          [XmlEnum("cm3/s")]
          cm3s,
        
          [XmlEnum("dm3/s")]
          dm3s,
        
          [XmlEnum("ft3/d")]
          ft3d,
        
          [XmlEnum("ft3/h")]
          ft3h,
        
          [XmlEnum("ft3/min")]
          ft3min,
        
          [XmlEnum("ft3/s")]
          ft3s,
        
          [XmlEnum("galUK/d")]
          galUKd,
        
          [XmlEnum("galUK/hr")]
          galUKhr,
        
          [XmlEnum("galUK/min")]
          galUKmin,
        
          [XmlEnum("galUS/d")]
          galUSd,
        
          [XmlEnum("galUS/hr")]
          galUShr,
        
          [XmlEnum("galUS/min")]
          galUSmin,
        
          [XmlEnum("kbbl/d")]
          kbbld,
        
          [XmlEnum("1000ft3/d")]
          Item1000ft3d,
        
          [XmlEnum("1000m3/d")]
          Item1000m3d,
        
          [XmlEnum("1000m3/h")]
          Item1000m3h,
        
          [XmlEnum("L/h")]
          Lh,
        
          [XmlEnum("L/min")]
          Lmin,
        
          [XmlEnum("L/s")]
          Ls,
        
          [XmlEnum("m3/d")]
          m3d,
        
          [XmlEnum("m3/h")]
          m3h,
        
          [XmlEnum("m3/min")]
          m3min,
        
          [XmlEnum("Mbbl/d")]
          Mbbld,
        
          [XmlEnum("M(ft3)/d")]
          Mft3d,
        
          [XmlEnum("M(m3)/d")]
          Mm3d
        }
        /// <summary>
        /// This class represents the ThermodynamicTemperatureUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ThermodynamicTemperatureUom xsd enumeration.")]
        public enum ThermodynamicTemperatureUom 
        {
        
          K,
        
          degC,
        
          degF,
        
          degR
        }
        /// <summary>
        /// This class represents the PressureUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the PressureUom xsd enumeration.")]
        public enum PressureUom 
        {
        
          Pa,
        
          at,
        
          atm,
        
          bar,
        
          [XmlEnum("cmH2O(4degC)")]
          cmH2O4degC,
        
          [XmlEnum("dyne/cm2")]
          dynecm2,
        
          GPa,
        
          hbar,
        
          [XmlEnum("inH2O(39.2F)")]
          inH2O392F,
        
          [XmlEnum("inH2O(60F)")]
          inH2O60F,
        
          [XmlEnum("inHg(32F)")]
          inHg32F,
        
          [XmlEnum("inHg(60F)")]
          inHg60F,
        
          [XmlEnum("kgf/cm2")]
          kgfcm2,
        
          [XmlEnum("kgf/mm2")]
          kgfmm2,
        
          [XmlEnum("kN/m2")]
          kNm2,
        
          kPa,
        
          kpsi,
        
          [XmlEnum("lbf/ft2")]
          lbfft2,
        
          [XmlEnum("lbf/100ft2")]
          lbf100ft2,
        
          [XmlEnum("lbf/in2")]
          lbfin2,
        
          mbar,
        
          [XmlEnum("mmHg(0C)")]
          mmHg0C,
        
          mPa,
        
          MPa,
        
          Mpsi,
        
          [XmlEnum("N/m2")]
          Nm2,
        
          [XmlEnum("N/mm2")]
          Nmm2,
        
          [XmlEnum("Pa(g)")]
          Pag,
        
          pPa,
        
          psi,
        
          [XmlEnum("tonfUS/ft2")]
          tonfUSft2,
        
          [XmlEnum("tonfUS/in2")]
          tonfUSin2,
        
          torr,
        
          ubar,
        
          [XmlEnum("umHg(0C)")]
          umHg0C,
        
          uPa,
        
          upsi
        }
        /// <summary>
        /// This class represents the LengthPerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the LengthPerLengthUom xsd enumeration.")]
        public enum LengthPerLengthUom 
        {
        
          [XmlEnum("%")]
          Item,
        
          [XmlEnum("ft/100ft")]
          ft100ft,
        
          [XmlEnum("ft/ft")]
          ftft,
        
          [XmlEnum("ft/in")]
          ftin,
        
          [XmlEnum("ft/m")]
          ftm,
        
          [XmlEnum("ft/mi")]
          ftmi,
        
          [XmlEnum("km/cm")]
          kmcm,
        
          [XmlEnum("m/30m")]
          m30m,
        
          [XmlEnum("m/cm")]
          mcm,
        
          [XmlEnum("m/km")]
          mkm,
        
          [XmlEnum("m/m")]
          mm,
        
          [XmlEnum("mi/in")]
          miin
        }
        /// <summary>
        /// This class represents the AreaUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the AreaUom xsd enumeration.")]
        public enum AreaUom 
        {
        
          m2,
        
          acre,
        
          b,
        
          cm2,
        
          ft2,
        
          ha,
        
          in2,
        
          km2,
        
          mi2,
        
          miUS2,
        
          mm2,
        
          um2,
        
          yd2
        }
        /// <summary>
        /// This class represents the AnglePerTimeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the AnglePerTimeUom xsd enumeration.")]
        public enum AnglePerTimeUom 
        {
        
          [XmlEnum("rad/s")]
          rads,
        
          [XmlEnum("c/s")]
          cs,
        
          [XmlEnum("dega/h")]
          degah,
        
          [XmlEnum("dega/min")]
          degamin,
        
          [XmlEnum("dega/s")]
          degas,
        
          [XmlEnum("rev/s")]
          revs,
        
          rpm
        }
        /// <summary>
        /// This class represents the AreaPerAreaUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the AreaPerAreaUom xsd enumeration.")]
        public enum AreaPerAreaUom 
        {
        
          Euc,
        
          [XmlEnum("%")]
          Item,
        
          [XmlEnum("in2/ft2")]
          in2ft2,
        
          [XmlEnum("in2/in2")]
          in2in2,
        
          [XmlEnum("m2/m2")]
          m2m2,
        
          [XmlEnum("mm2/mm2")]
          mm2mm2
        }
        /// <summary>
        /// This class represents the LengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the LengthUom xsd enumeration.")]
        public enum LengthUom 
        {
        
          m,
        
          angstrom,
        
          chBnA,
        
          chBnB,
        
          chCla,
        
          chSe,
        
          chUS,
        
          cm,
        
          dm,
        
          fathom,
        
          fm,
        
          ft,
        
          ftBnA,
        
          ftBnB,
        
          [XmlEnum("ftBr(65)")]
          ftBr65,
        
          ftCla,
        
          ftGC,
        
          ftInd,
        
          [XmlEnum("ftInd(37)")]
          ftInd37,
        
          [XmlEnum("ftInd(62)")]
          ftInd62,
        
          [XmlEnum("ftInd(75)")]
          ftInd75,
        
          ftMA,
        
          ftSe,
        
          ftUS,
        
          @in,
        
          [XmlEnum("in/10")]
          in10,
        
          [XmlEnum("in/16")]
          in16,
        
          [XmlEnum("in/32")]
          in32,
        
          [XmlEnum("in/64")]
          in64,
        
          inUS,
        
          km,
        
          lkBnA,
        
          lkBnB,
        
          lkCla,
        
          lkSe,
        
          lkUS,
        
          mGer,
        
          mi,
        
          mil,
        
          miUS,
        
          mm,
        
          Mm,
        
          nautmi,
        
          nm,
        
          pm,
        
          um,
        
          yd,
        
          ydBnA,
        
          ydBnB,
        
          ydCla,
        
          ydIm,
        
          ydInd,
        
          [XmlEnum("ydInd(37)")]
          ydInd37,
        
          [XmlEnum("ydInd(62)")]
          ydInd62,
        
          [XmlEnum("ydInd(75)")]
          ydInd75,
        
          ydSe
        }
        /// <summary>
        /// This class represents the EastOrWest xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
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
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
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
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
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
        
          [XmlEnum("ftBr(65)")]
          ftBr65
        }
        /// <summary>
        /// This class represents the MeasuredDepthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
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
        /// This class represents the PercentUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the PercentUom xsd enumeration.")]
        public enum PercentUom 
        {
        
          [XmlEnum("%")]
          Item
        }
        /// <summary>
        /// This class represents the PlaneAngleUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the PlaneAngleUom xsd enumeration.")]
        public enum PlaneAngleUom 
        {
        
          rad,
        
          c,
        
          ccgr,
        
          cgr,
        
          dega,
        
          gon,
        
          gr,
        
          Grad,
        
          krad,
        
          mila,
        
          mina,
        
          mrad,
        
          Mrad,
        
          mseca,
        
          seca,
        
          urad
        }
        /// <summary>
        /// This class represents the AziRef xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the AziRef xsd enumeration.")]
        public enum AziRef 
        {
        
          [XmlEnum("magnetic north")]
          magneticnorth,
        
          [XmlEnum("grid north")]
          gridnorth,
        
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
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the VolumePerVolumeUom xsd enumeration.")]
        public enum VolumePerVolumeUom 
        {
        
          Euc,
        
          [XmlEnum("%")]
          Item,
        
          permil,
        
          ppdk,
        
          ppk,
        
          ppm,
        
          [XmlEnum("bbl/acre.ft")]
          bblacreft,
        
          [XmlEnum("bbl/bbl")]
          bblbbl,
        
          [XmlEnum("bbl/ft3")]
          bblft3,
        
          [XmlEnum("bbl/100bbl")]
          bbl100bbl,
        
          [XmlEnum("bbl/k(ft3)")]
          bblkft3,
        
          [XmlEnum("bbl/M(ft3)")]
          bblMft3,
        
          [XmlEnum("cm3/cm3")]
          cm3cm3,
        
          [XmlEnum("cm3/m3")]
          cm3m3,
        
          [XmlEnum("dm3/m3")]
          dm3m3,
        
          [XmlEnum("ft3/bbl")]
          ft3bbl,
        
          [XmlEnum("ft3/ft3")]
          ft3ft3,
        
          [XmlEnum("galUS/kgalUS")]
          galUSkgalUS,
        
          [XmlEnum("galUK/kgalUK")]
          galUKkgalUK,
        
          [XmlEnum("galUK/ft3")]
          galUKft3,
        
          [XmlEnum("galUK/Mbbl")]
          galUKMbbl,
        
          [XmlEnum("galUS/bbl")]
          galUSbbl,
        
          [XmlEnum("galUS/10bbl")]
          galUS10bbl,
        
          [XmlEnum("galUS/ft3")]
          galUSft3,
        
          [XmlEnum("galUS/Mbbl")]
          galUSMbbl,
        
          [XmlEnum("1000ft3/bbl")]
          Item1000ft3bbl,
        
          [XmlEnum("ksm3/sm3")]
          ksm3sm3,
        
          [XmlEnum("L/10bbl")]
          L10bbl,
        
          [XmlEnum("L/m3")]
          Lm3,
        
          [XmlEnum("m3/ha.m")]
          m3ham,
        
          [XmlEnum("m3/m3")]
          m3m3,
        
          [XmlEnum("M(ft3)/acre.ft")]
          Mft3acreft,
        
          [XmlEnum("mL/galUK")]
          mLgalUK,
        
          [XmlEnum("mL/galUS")]
          mLgalUS,
        
          [XmlEnum("mL/mL")]
          mLmL,
        
          [XmlEnum("MMbbl/acre.ft")]
          MMbblacreft,
        
          [XmlEnum("MMscf60/stb60")]
          MMscf60stb60,
        
          [XmlEnum("Mscf60/stb60")]
          Mscf60stb60,
        
          [XmlEnum("ptUK/Mbbl")]
          ptUKMbbl,
        
          [XmlEnum("ptUS/10bbl")]
          ptUS10bbl,
        
          pu,
        
          [XmlEnum("scm15/stb60")]
          scm15stb60,
        
          [XmlEnum("sm3/ksm3")]
          sm3ksm3,
        
          [XmlEnum("sm3/sm3")]
          sm3sm3,
        
          [XmlEnum("stb60/MMscf60")]
          stb60MMscf60,
        
          [XmlEnum("stb60/MMscm15")]
          stb60MMscm15,
        
          [XmlEnum("stb60/Mscf60")]
          stb60Mscf60,
        
          [XmlEnum("stb60/Mscm15")]
          stb60Mscm15,
        
          [XmlEnum("stb60/scm15")]
          stb60scm15
        }
        /// <summary>
        /// This class represents the VelocityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the VelocityUom xsd enumeration.")]
        public enum VelocityUom 
        {
        
          [XmlEnum("m/s")]
          ms,
        
          [XmlEnum("cm/a")]
          cma,
        
          [XmlEnum("cm/s")]
          cms,
        
          [XmlEnum("dm/s")]
          dms,
        
          [XmlEnum("ft/d")]
          ftd,
        
          [XmlEnum("ft/h")]
          fth,
        
          [XmlEnum("ft/min")]
          ftmin,
        
          [XmlEnum("ft/ms")]
          ftms,
        
          [XmlEnum("ft/s")]
          fts,
        
          [XmlEnum("ft/us")]
          ftus,
        
          [XmlEnum("in/a")]
          ina,
        
          [XmlEnum("in/min")]
          inmin,
        
          [XmlEnum("in/s")]
          ins,
        
          [XmlEnum("kft/h")]
          kfth,
        
          [XmlEnum("kft/s")]
          kfts,
        
          [XmlEnum("km/h")]
          kmh,
        
          [XmlEnum("km/s")]
          kms,
        
          knot,
        
          [XmlEnum("m/d")]
          md,
        
          [XmlEnum("m/h")]
          mh,
        
          [XmlEnum("m/min")]
          mmin,
        
          [XmlEnum("m/ms")]
          mms,
        
          [XmlEnum("mi/h")]
          mih,
        
          [XmlEnum("mil/yr")]
          milyr,
        
          [XmlEnum("mm/a")]
          mma,
        
          [XmlEnum("mm/s")]
          mms1,
        
          [XmlEnum("nm/s")]
          nms,
        
          [XmlEnum("um/s")]
          ums
        }
        /// <summary>
        /// This class represents the TimeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the TimeUom xsd enumeration.")]
        public enum TimeUom 
        {
        
          s,
        
          a,
        
          cs,
        
          d,
        
          Ga,
        
          h,
        
          [XmlEnum("100s")]
          Item100s,
        
          Ma,
        
          min,
        
          ms,
        
          [XmlEnum("ms/2")]
          ms2,
        
          ns,
        
          ps,
        
          us,
        
          wk,
        
          [XmlEnum("100ka")]
          Item100ka
        }
        /// <summary>
        /// This class represents the SpecificVolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the SpecificVolumeUom xsd enumeration.")]
        public enum SpecificVolumeUom 
        {
        
          [XmlEnum("m3/kg")]
          m3kg,
        
          [XmlEnum("bbl/tonUK")]
          bbltonUK,
        
          [XmlEnum("bbl/tonUS")]
          bbltonUS,
        
          [XmlEnum("cm3/g")]
          cm3g,
        
          [XmlEnum("dm3/kg")]
          dm3kg,
        
          [XmlEnum("dm3/t")]
          dm3t,
        
          [XmlEnum("ft3/kg")]
          ft3kg,
        
          [XmlEnum("ft3/lbm")]
          ft3lbm,
        
          [XmlEnum("ft3/sack94")]
          ft3sack94,
        
          [XmlEnum("galUS/sack94")]
          galUSsack94,
        
          [XmlEnum("galUK/lbm")]
          galUKlbm,
        
          [XmlEnum("galUS/lbm")]
          galUSlbm,
        
          [XmlEnum("galUS/tonUK")]
          galUStonUK,
        
          [XmlEnum("galUS/tonUS")]
          galUStonUS,
        
          [XmlEnum("L/100kg")]
          L100kg,
        
          [XmlEnum("L/kg")]
          Lkg,
        
          [XmlEnum("L/t")]
          Lt,
        
          [XmlEnum("L/tonUK")]
          LtonUK,
        
          [XmlEnum("m3/g")]
          m3g,
        
          [XmlEnum("m3/t")]
          m3t,
        
          [XmlEnum("m3/tonUK")]
          m3tonUK,
        
          [XmlEnum("m3/tonUS")]
          m3tonUS
        }
        /// <summary>
        /// This class represents the RelativePowerUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the RelativePowerUom xsd enumeration.")]
        public enum RelativePowerUom 
        {
        
          [XmlEnum("%")]
          Item,
        
          [XmlEnum("Btu/bhp.hr")]
          Btubhphr,
        
          [XmlEnum("W/kW")]
          WkW,
        
          [XmlEnum("W/W")]
          WW
        }
        /// <summary>
        /// This class represents the PowerUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the PowerUom xsd enumeration.")]
        public enum PowerUom 
        {
        
          W,
        
          ch,
        
          CV,
        
          ehp,
        
          GW,
        
          hhp,
        
          hp,
        
          [XmlEnum("kcal/h")]
          kcalh,
        
          kW,
        
          [XmlEnum("MJ/a")]
          MJa,
        
          MW,
        
          mW,
        
          nW,
        
          [XmlEnum("ton of refrig")]
          tonofrefrig,
        
          TW,
        
          uW
        }
        /// <summary>
        /// This class represents the PerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the PerLengthUom xsd enumeration.")]
        public enum PerLengthUom 
        {
        
          [XmlEnum("1/m")]
          Item1m,
        
          [XmlEnum("1/angstrom")]
          Item1angstrom,
        
          [XmlEnum("1/cm")]
          Item1cm,
        
          [XmlEnum("1/ft")]
          Item1ft,
        
          [XmlEnum("1/in")]
          Item1in,
        
          [XmlEnum("1/mi")]
          Item1mi,
        
          [XmlEnum("1/mm")]
          Item1mm,
        
          [XmlEnum("1/nm")]
          Item1nm,
        
          [XmlEnum("1/yd")]
          Item1yd
        }
        /// <summary>
        /// This class represents the MomentOfForceUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MomentOfForceUom xsd enumeration.")]
        public enum MomentOfForceUom 
        {
        
          J,
        
          [XmlEnum("dN.m")]
          dNm,
        
          [XmlEnum("daN.m")]
          daNm,
        
          [XmlEnum("ft.lbf")]
          ftlbf,
        
          [XmlEnum("kft.lbf")]
          kftlbf,
        
          [XmlEnum("kgf.m")]
          kgfm,
        
          [XmlEnum("kN.m")]
          kNm,
        
          [XmlEnum("lbf.ft")]
          lbfft,
        
          [XmlEnum("lbf.in")]
          lbfin,
        
          [XmlEnum("lbm.ft2/s2")]
          lbmft2s2,
        
          [XmlEnum("N.m")]
          Nm,
        
          [XmlEnum("pdl.ft")]
          pdlft,
        
          [XmlEnum("tonfUS.ft")]
          tonfUSft,
        
          [XmlEnum("tonfUS.mi")]
          tonfUSmi
        }
        /// <summary>
        /// This class represents the MassPerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MassPerLengthUom xsd enumeration.")]
        public enum MassPerLengthUom 
        {
        
          [XmlEnum("kg/m")]
          kgm,
        
          [XmlEnum("klbm/in")]
          klbmin,
        
          [XmlEnum("lbm/ft")]
          lbmft,
        
          [XmlEnum("Mg/in")]
          Mgin,
        
          [XmlEnum("kg.m/cm2")]
          kgmcm2
        }
        /// <summary>
        /// This class represents the MassUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MassUom xsd enumeration.")]
        public enum MassUom 
        {
        
          kg,
        
          ag,
        
          ct,
        
          cwtUK,
        
          cwtUS,
        
          g,
        
          grain,
        
          klbm,
        
          lbm,
        
          Mg,
        
          mg,
        
          [XmlEnum("oz(av)")]
          ozav,
        
          [XmlEnum("oz(troy)")]
          oztroy,
        
          ozm,
        
          sack94,
        
          t,
        
          tonUK,
        
          tonUS,
        
          ug
        }
        /// <summary>
        /// This class represents the MassConcentrationUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MassConcentrationUom xsd enumeration.")]
        public enum MassConcentrationUom 
        {
        
          Euc,
        
          [XmlEnum("%")]
          Item,
        
          [XmlEnum("g/kg")]
          gkg,
        
          [XmlEnum("kg/kg")]
          kgkg,
        
          [XmlEnum("kg/sack94")]
          kgsack94,
        
          [XmlEnum("mg/kg")]
          mgkg,
        
          permil,
        
          ppdk,
        
          ppk,
        
          ppm
        }
        /// <summary>
        /// This class represents the MagneticInductionUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MagneticInductionUom xsd enumeration.")]
        public enum MagneticInductionUom 
        {
        
          T,
        
          gauss,
        
          mT,
        
          mgauss,
        
          nT,
        
          uT
        }
        /// <summary>
        /// This class represents the IlluminanceUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the IlluminanceUom xsd enumeration.")]
        public enum IlluminanceUom 
        {
        
          lx,
        
          [XmlEnum("lm/m2")]
          lmm2,
        
          footcandle,
        
          klx
        }
        /// <summary>
        /// This class represents the ForcePerVolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ForcePerVolumeUom xsd enumeration.")]
        public enum ForcePerVolumeUom 
        {
        
          [XmlEnum("N/m3")]
          Nm3,
        
          [XmlEnum("atm/100m")]
          atm100m,
        
          [XmlEnum("atm/m")]
          atmm,
        
          [XmlEnum("bar/km")]
          barkm,
        
          [XmlEnum("bar/m")]
          barm,
        
          [XmlEnum("GPa/cm")]
          GPacm,
        
          [XmlEnum("kPa/100m")]
          kPa100m,
        
          [XmlEnum("kPa/m")]
          kPam,
        
          [XmlEnum("lbf/ft3")]
          lbfft3,
        
          [XmlEnum("lbf/galUS")]
          lbfgalUS,
        
          [XmlEnum("MPa/m")]
          MPam,
        
          [XmlEnum("psi/ft")]
          psift,
        
          [XmlEnum("psi/100ft")]
          psi100ft,
        
          [XmlEnum("psi/kft")]
          psikft,
        
          [XmlEnum("psi/m")]
          psim,
        
          [XmlEnum("Pa/m")]
          Pam,
        
          [XmlEnum("atm/ft")]
          atmft
        }
        /// <summary>
        /// This class represents the ForcePerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ForcePerLengthUom xsd enumeration.")]
        public enum ForcePerLengthUom 
        {
        
          [XmlEnum("N/30m")]
          N30m,
        
          [XmlEnum("N/m")]
          Nm,
        
          [XmlEnum("dyne/cm")]
          dynecm,
        
          [XmlEnum("kN/m")]
          kNm,
        
          [XmlEnum("kgf/cm")]
          kgfcm,
        
          [XmlEnum("lbf/100ft")]
          lbf100ft,
        
          [XmlEnum("lbf/30m")]
          lbf30m,
        
          [XmlEnum("lbf/ft")]
          lbfft,
        
          [XmlEnum("lbf/in")]
          lbfin,
        
          [XmlEnum("mN/km")]
          mNkm,
        
          [XmlEnum("mN/m")]
          mNm,
        
          [XmlEnum("pdl/cm")]
          pdlcm,
        
          [XmlEnum("tonfUK/ft")]
          tonfUKft,
        
          [XmlEnum("tonfUS/ft")]
          tonfUSft
        }
        /// <summary>
        /// This class represents the ForceUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ForceUom xsd enumeration.")]
        public enum ForceUom 
        {
        
          N,
        
          daN,
        
          dyne,
        
          gf,
        
          kdyne,
        
          kgf,
        
          klbf,
        
          kN,
        
          lbf,
        
          Mgf,
        
          mN,
        
          MN,
        
          ozf,
        
          pdl,
        
          tonfUK,
        
          tonfUS,
        
          uN
        }
        /// <summary>
        /// This class represents the EquivalentPerMassUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the EquivalentPerMassUom xsd enumeration.")]
        public enum EquivalentPerMassUom 
        {
        
          [XmlEnum("eq/kg")]
          eqkg,
        
          [XmlEnum("meq/g")]
          meqg,
        
          [XmlEnum("meq/100g")]
          meq100g
        }
        /// <summary>
        /// This class represents the ElectricPotentialUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ElectricPotentialUom xsd enumeration.")]
        public enum ElectricPotentialUom 
        {
        
          V,
        
          kV,
        
          mV,
        
          MV,
        
          uV
        }
        /// <summary>
        /// This class represents the ElectricCurrentUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ElectricCurrentUom xsd enumeration.")]
        public enum ElectricCurrentUom 
        {
        
          A,
        
          MA,
        
          kA,
        
          mA,
        
          nA,
        
          pA,
        
          uA
        }
        /// <summary>
        /// This class represents the DynamicViscosityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the DynamicViscosityUom xsd enumeration.")]
        public enum DynamicViscosityUom 
        {
        
          [XmlEnum("Pa.s")]
          Pas,
        
          cP,
        
          P,
        
          [XmlEnum("psi.s")]
          psis,
        
          [XmlEnum("dyne.s/cm2")]
          dynescm2,
        
          [XmlEnum("kgf.s/m2")]
          kgfsm2,
        
          [XmlEnum("lbf.s/ft2")]
          lbfsft2,
        
          [XmlEnum("lbf.s/in2")]
          lbfsin2,
        
          [XmlEnum("mPa.s")]
          mPas,
        
          [XmlEnum("N.s/m2")]
          Nsm2
        }
        /// <summary>
        /// This class represents the DimensionlessUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the DimensionlessUom xsd enumeration.")]
        public enum DimensionlessUom 
        {
        
          Euc,
        
          [XmlEnum("%")]
          Item,
        
          cEuc,
        
          mEuc,
        
          nEuc,
        
          uEuc
        }
        /// <summary>
        /// This class represents the DensityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the DensityUom xsd enumeration.")]
        public enum DensityUom 
        {
        
          [XmlEnum("kg/m3")]
          kgm3,
        
          [XmlEnum("10Mg/m3")]
          Item10Mgm3,
        
          dAPI,
        
          [XmlEnum("g/cm3")]
          gcm3,
        
          [XmlEnum("g/dm3")]
          gdm3,
        
          [XmlEnum("g/galUK")]
          ggalUK,
        
          [XmlEnum("g/galUS")]
          ggalUS,
        
          [XmlEnum("g/L")]
          gL,
        
          [XmlEnum("g/m3")]
          gm3,
        
          [XmlEnum("grain/ft3")]
          grainft3,
        
          [XmlEnum("grain/galUS")]
          graingalUS,
        
          [XmlEnum("grain/100ft3")]
          grain100ft3,
        
          [XmlEnum("kg/dm3")]
          kgdm3,
        
          [XmlEnum("kg/L")]
          kgL,
        
          [XmlEnum("Mg/m3")]
          Mgm3,
        
          [XmlEnum("lbm/10bbl")]
          lbm10bbl,
        
          [XmlEnum("lbm/bbl")]
          lbmbbl,
        
          [XmlEnum("lbm/ft3")]
          lbmft3,
        
          [XmlEnum("lbm/galUK")]
          lbmgalUK,
        
          [XmlEnum("lbm/1000galUK")]
          lbm1000galUK,
        
          [XmlEnum("lbm/galUS")]
          lbmgalUS,
        
          [XmlEnum("lbm/1000galUS")]
          lbm1000galUS,
        
          [XmlEnum("lbm/in3")]
          lbmin3,
        
          [XmlEnum("lbm/Mbbl")]
          lbmMbbl,
        
          [XmlEnum("mg/dm3")]
          mgdm3,
        
          [XmlEnum("mg/galUS")]
          mggalUS,
        
          [XmlEnum("mg/L")]
          mgL,
        
          [XmlEnum("mg/m3")]
          mgm3,
        
          [XmlEnum("ug/cm3")]
          ugcm3
        }
        /// <summary>
        /// This class represents the AnglePerLengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the AnglePerLengthUom xsd enumeration.")]
        public enum AnglePerLengthUom 
        {
        
          [XmlEnum("rad/m")]
          radm,
        
          [XmlEnum("dega/30ft")]
          dega30ft,
        
          [XmlEnum("dega/ft")]
          degaft,
        
          [XmlEnum("dega/100ft")]
          dega100ft,
        
          [XmlEnum("dega/m")]
          degam,
        
          [XmlEnum("dega/30m")]
          dega30m,
        
          [XmlEnum("rad/ft")]
          radft
        }
        /// <summary>
        /// This class represents the AccelerationLinearUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the AccelerationLinearUom xsd enumeration.")]
        public enum AccelerationLinearUom 
        {
        
          [XmlEnum("m/s2")]
          ms2,
        
          [XmlEnum("cm/s2")]
          cms2,
        
          [XmlEnum("ft/s2")]
          fts2,
        
          Gal,
        
          mgn,
        
          gn,
        
          mGal
        }
        /// <summary>
        /// This class represents the WorkUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the WorkUom xsd enumeration.")]
        public enum WorkUom 
        {
        
          J,
        
          aJ,
        
          Btu,
        
          cal,
        
          [XmlEnum("ch.h")]
          chh,
        
          Chu,
        
          [XmlEnum("CV.h")]
          CVh,
        
          EJ,
        
          erg,
        
          eV,
        
          GeV,
        
          GJ,
        
          [XmlEnum("GW.h")]
          GWh,
        
          [XmlEnum("hp.hr")]
          hphr,
        
          kcal,
        
          keV,
        
          kJ,
        
          [XmlEnum("kW.h")]
          kWh,
        
          MeV,
        
          mJ,
        
          MJ,
        
          [XmlEnum("MW.h")]
          MWh,
        
          nJ,
        
          quad,
        
          TeV,
        
          therm,
        
          TJ,
        
          [XmlEnum("TW.h")]
          TWh,
        
          uJ
        }
        /// <summary>
        /// This class represents the ThermalConductivityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ThermalConductivityUom xsd enumeration.")]
        public enum ThermalConductivityUom 
        {
        
          [XmlEnum("W/m.K")]
          WmK,
        
          [XmlEnum("Btu/hr.ft.degF")]
          BtuhrftdegF,
        
          [XmlEnum("cal/h.cm.degC")]
          calhcmdegC,
        
          [XmlEnum("cal/s.cm.degC")]
          calscmdegC,
        
          [XmlEnum("kcal/h.m.degC")]
          kcalhmdegC
        }
        /// <summary>
        /// This class represents the MolarVolumeUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MolarVolumeUom xsd enumeration.")]
        public enum MolarVolumeUom 
        {
        
          [XmlEnum("m3/mol")]
          m3mol,
        
          [XmlEnum("dm3/mol(kg)")]
          dm3molkg,
        
          [XmlEnum("ft3/mol(lbm)")]
          ft3mollbm,
        
          [XmlEnum("L/mol(g)")]
          Lmolg,
        
          [XmlEnum("L/mol(kg)")]
          Lmolkg,
        
          [XmlEnum("m3/mol(kg)")]
          m3molkg
        }
        /// <summary>
        /// This class represents the ModulusOfCompressionUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ModulusOfCompressionUom xsd enumeration.")]
        public enum ModulusOfCompressionUom 
        {
        
          [XmlEnum("J/m3")]
          Jm3,
        
          [XmlEnum("Btu/bbl")]
          Btubbl,
        
          [XmlEnum("Btu/ft3")]
          Btuft3,
        
          [XmlEnum("Btu/galUK")]
          BtugalUK,
        
          [XmlEnum("Btu/galUS")]
          BtugalUS,
        
          [XmlEnum("cal/cm3")]
          calcm3,
        
          [XmlEnum("cal/mL")]
          calmL,
        
          [XmlEnum("cal/mm3")]
          calmm3,
        
          [XmlEnum("erg/cm3")]
          ergcm3,
        
          [XmlEnum("erg/m3")]
          ergm3,
        
          [XmlEnum("ft.lbf/bbl")]
          ftlbfbbl,
        
          [XmlEnum("ft.lbf/galUS")]
          ftlbfgalUS,
        
          [XmlEnum("hp.hr/bbl")]
          hphrbbl,
        
          [XmlEnum("J/dm3")]
          Jdm3,
        
          [XmlEnum("kcal/cm3")]
          kcalcm3,
        
          [XmlEnum("kcal/m3")]
          kcalm3,
        
          [XmlEnum("kJ/dm3")]
          kJdm3,
        
          [XmlEnum("kJ/m3")]
          kJm3,
        
          [XmlEnum("kW.h/dm3")]
          kWhdm3,
        
          [XmlEnum("kW.h/m3")]
          kWhm3,
        
          [XmlEnum("lbf.ft/bbl")]
          lbfftbbl,
        
          [XmlEnum("MJ/m3")]
          MJm3,
        
          [XmlEnum("MW.h/m3")]
          MWhm3,
        
          [XmlEnum("therm/ft3")]
          thermft3,
        
          [XmlEnum("therm/galUK")]
          thermgalUK,
        
          [XmlEnum("tonfUS.mi/bbl")]
          tonfUSmibbl
        }
        /// <summary>
        /// This class represents the MassFlowRateUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MassFlowRateUom xsd enumeration.")]
        public enum MassFlowRateUom 
        {
        
          [XmlEnum("Mg/a")]
          Mga,
        
          [XmlEnum("Mg/d")]
          Mgd,
        
          [XmlEnum("Mg/h")]
          Mgh,
        
          [XmlEnum("Mlbm/yr")]
          Mlbmyr,
        
          [XmlEnum("g/s")]
          gs,
        
          [XmlEnum("kg/d")]
          kgd,
        
          [XmlEnum("kg/h")]
          kgh,
        
          [XmlEnum("kg/min")]
          kgmin,
        
          [XmlEnum("kg/s")]
          kgs,
        
          [XmlEnum("lbm/d")]
          lbmd,
        
          [XmlEnum("lbm/h")]
          lbmh,
        
          [XmlEnum("lbm/min")]
          lbmmin,
        
          [XmlEnum("lbm/s")]
          lbms,
        
          [XmlEnum("t/a")]
          ta,
        
          [XmlEnum("t/d")]
          td,
        
          [XmlEnum("t/h")]
          th,
        
          [XmlEnum("t/min")]
          tmin,
        
          [XmlEnum("tonUK/a")]
          tonUKa,
        
          [XmlEnum("tonUK/d")]
          tonUKd,
        
          [XmlEnum("tonUK/h")]
          tonUKh,
        
          [XmlEnum("tonUK/min")]
          tonUKmin,
        
          [XmlEnum("tonUS/a")]
          tonUSa,
        
          [XmlEnum("tonUS/d")]
          tonUSd,
        
          [XmlEnum("tonUS/h")]
          tonUSh,
        
          [XmlEnum("tonUS/min")]
          tonUSmin
        }
        /// <summary>
        /// This class represents the MagneticFieldStrengthUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the MagneticFieldStrengthUom xsd enumeration.")]
        public enum MagneticFieldStrengthUom 
        {
        
          [XmlEnum("A/m")]
          Am,
        
          [XmlEnum("A/mm")]
          Amm,
        
          gamma,
        
          Oe
        }
        /// <summary>
        /// This class represents the FrequencyUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the FrequencyUom xsd enumeration.")]
        public enum FrequencyUom 
        {
        
          Hz,
        
          [XmlEnum("c/s")]
          cs,
        
          GHz,
        
          kHz,
        
          mHz,
        
          MHz,
        
          uHz,
        
          [XmlEnum("1/s")]
          Item1s,
        
          [XmlEnum("1/a")]
          Item1a,
        
          [XmlEnum("1/d")]
          Item1d,
        
          [XmlEnum("1/h")]
          Item1h,
        
          [XmlEnum("1/min")]
          Item1min,
        
          [XmlEnum("1/wk")]
          Item1wk,
        
          [XmlEnum("kEuc/s")]
          kEucs
        }
        /// <summary>
        /// This class represents the EnergyPerAreaUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the EnergyPerAreaUom xsd enumeration.")]
        public enum EnergyPerAreaUom 
        {
        
          [XmlEnum("N/m")]
          Nm,
        
          [XmlEnum("erg/cm2")]
          ergcm2,
        
          [XmlEnum("J/cm2")]
          Jcm2,
        
          [XmlEnum("J/m2")]
          Jm2,
        
          [XmlEnum("kgf.m/cm2")]
          kgfmcm2,
        
          [XmlEnum("lbf.ft/in2")]
          lbfftin2,
        
          [XmlEnum("mJ/cm2")]
          mJcm2,
        
          [XmlEnum("mJ/m2")]
          mJm2
        }
        /// <summary>
        /// This class represents the CompressibilityUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the CompressibilityUom xsd enumeration.")]
        public enum CompressibilityUom 
        {
        
          [XmlEnum("1/Pa")]
          Item1Pa,
        
          [XmlEnum("1/bar")]
          Item1bar,
        
          [XmlEnum("1/kPa")]
          Item1kPa,
        
          [XmlEnum("1/pPa")]
          Item1pPa,
        
          [XmlEnum("1/psi")]
          Item1psi,
        
          [XmlEnum("1/upsi")]
          Item1upsi
        }
        /// <summary>
        /// This class represents the AmountOfSubstanceUom xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the AmountOfSubstanceUom xsd enumeration.")]
        public enum AmountOfSubstanceUom 
        {
        
          kmol,
        
          mmol,
        
          mol,
        
          [XmlEnum("mol")]
          mol1,
        
          [XmlEnum("kmol")]
          kmol1,
        
          lbmole,
        
          umol
        }
        /// <summary>
        /// This class represents the ElevCodeEnum xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ElevCodeEnum xsd enumeration.")]
        public enum ElevCodeEnum 
        {
        /// <summary>
        /// casing flange: A flange affixed to the top of the casing string used to attach production equipment.
        /// </summary>
          CF,
        /// <summary>
        /// crown valve
        /// </summary>
          CV,
        /// <summary>
        /// derrick floor
        /// </summary>
          DF,
        /// <summary>
        /// ground level
        /// </summary>
          GL,
        /// <summary>
        /// kelly bushing
        /// </summary>
          KB,
        /// <summary>
        /// rotary bushing
        /// </summary>
          RB,
        /// <summary>
        /// rotary table
        /// </summary>
          RT,
        /// <summary>
        /// sea floor
        /// </summary>
          SF,
        /// <summary>
        /// Lowest Astronomical Tide. The lowest tide level over the duration of the National Tidal Datum Epoch (19 years).
        /// </summary>
          LAT,
        /// <summary>
        /// Mean Sea Level - A tidal datum. The arithmetic mean of hourly heights observed over the National Tidal Datum Epoch (19 years).
        /// </summary>
          SL,
        /// <summary>
        /// Mean Higher High Water - A tidal datum. The average of the higher high water height of each tidal day observed over the National Tidal Datum Epoch (19 years).
        /// </summary>
          MHHW,
        /// <summary>
        /// Mean High Water - A tidal datum. The average of all the high water heights observed over the National Tidal Datum Epoch (19 years).
        /// </summary>
          MHW,
        /// <summary>
        /// Mean Lower Low Water - A tidal datum. The average of the lower low water height of each tidal day observed over the National Tidal Datum Epoch (19 years ).
        /// </summary>
          MLLW,
        /// <summary>
        /// Mean Low Water - A tidal datum. The average of all the low water heights observed over the National Tidal Datum Epoch (19 years).
        /// </summary>
          MLW,
        /// <summary>
        /// Mean Tide Level - A tidal datum. The arithmetic mean of mean high water and mean low water. Same as half-tide level.
        /// </summary>
          MTL,
        /// <summary>
        /// kickoff point
        /// </summary>
          KO,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the ItemsChoiceType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType xsd enumeration.")]
        public enum ItemsChoiceType 
        {
        
          easting,
        
          latitude,
        
          localX,
        
          localY,
        
          longitude,
        
          northing,
        
          projectedX,
        
          projectedY,
        
          southing,
        
          westing
        }
        /// <summary>
        /// This class represents the PrimitiveType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the PrimitiveType xsd enumeration.")]
        public enum PrimitiveType 
        {
        
          @string,
        
          boolean,
        
          @float,
        
          @double,
        
          duration,
        
          dateTime,
        
          time,
        
          date,
        
          gYearMonth,
        
          gYear,
        
          gMonthDay,
        
          gDay,
        
          gMonth,
        
          base64Binary,
        
          anyURI,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the WellFluid xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the WellFluid xsd enumeration.")]
        public enum WellFluid 
        {
        /// <summary>
        /// This is generally an injected fluid.
        /// </summary>
          air,
        /// <summary>
        /// Liquid hydrocarbons produced with natural gas that are separated from the gas by cooling and various other means. Condensate generally has an API gravity of 50 degrees to 120 degrees and is water white, straw, or bluish in color. It is the liquid recovery from a well classified as a gas well. It is generally dissolved in the gaseous state under reservoir conditions but separates as a liquid either in passing up the hole or at the surface. These hydrocarbons, from associated and nonassociated gas well gas, normally are recovered from lease separators or field facilities by mechanical separation.
        /// </summary>
          condensate,
        /// <summary>
        /// The well facility is classified as a dry well. It has not been, nor will it be used to produce or inject any fluids.
        /// </summary>
          dry,
        /// <summary>
        /// The well is classified as a gas well, producing or injecting a hydrocarbon gas. The gas is generally methane, but may have a mixture of other gases also.
        /// </summary>
          gas,
        
          [XmlEnum("gas-water")]
          gaswater,
        
          [XmlEnum("non HC gas")]
          nonHCgas,
        
          [XmlEnum("non HC gas -- CO2")]
          nonHCgasCO2,
        /// <summary>
        /// The liquid hydrocarbon, generally referred to as crude oil.
        /// </summary>
          oil,
        
          [XmlEnum("oil-gas")]
          oilgas,
        
          [XmlEnum("oil-water")]
          oilwater,
        /// <summary>
        /// The gaseous state of water. This is generally an injected fluid, but it is possible that some hydrothermal wells produce steam.
        /// </summary>
          steam,
        /// <summary>
        /// The well is classified as a water well without distinguishing between brine or fresh water.
        /// </summary>
          water,
        
          [XmlEnum("water -- brine")]
          waterbrine,
        
          [XmlEnum("water -- fresh water")]
          waterfreshwater,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the WellDirection xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the WellDirection xsd enumeration.")]
        public enum WellDirection 
        {
        
          [XmlEnum("huff-n-puff")]
          huffnpuff,
        /// <summary>
        /// The well facility is injecting fluids into the subsurface.
        /// </summary>
          injector,
        /// <summary>
        /// The well facility is producing fluids from the subsurface.
        /// </summary>
          producer,
        /// <summary>
        /// The flow direction of the fluids is variable, but not on a regular basis as is the case with the huff-n-puff flow.
        /// </summary>
          uncertain,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the ItemState xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
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
        /// This class represents the ItemsChoiceType8 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType8 xsd enumeration.")]
        public enum ItemsChoiceType8 
        {
        
          dTim,
        
          dTimEnd,
        
          dTimStart,
        
          date,
        
          dateEnd,
        
          dateStart
        }
        /// <summary>
        /// This class represents the WellStatus xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the WellStatus xsd enumeration.")]
        public enum WellStatus 
        {
        /// <summary>
        /// The status of a facility in which drilling, completion, and production operations have been permanently terminated.
        /// </summary>
          abandoned,
        /// <summary>
        /// For a well to be active, at least one of its wellbores must be active. For a wellbore to be active, at least one of its completions must be actively producing or injecting fluids.
        /// </summary>
          active,
        
          [XmlEnum("active -- injecting")]
          activeinjecting,
        
          [XmlEnum("active -- producing")]
          activeproducing,
        /// <summary>
        /// The completion has been installed, but the facility is not yet active. This status is appropriate only before the initial producing or injecting activity.
        /// </summary>
          completed,
        /// <summary>
        /// The status of a well or wellbore in which drilling operations have begun, but are not yet completed. The status ends when another status becomes appropriate.
        /// </summary>
          drilling,
        
          [XmlEnum("partially plugged")]
          partiallyplugged,
        /// <summary>
        /// The facility has received regulatory approvel, but drilling has not yet commenced. For a well, it has been spudded. For a subsequent wellbore, the whipstock or similar device has not yet been set.
        /// </summary>
          permitted,
        
          [XmlEnum("plugged and abandoned")]
          pluggedandabandoned,
        /// <summary>
        /// The status of a well or wellbore from conception to either regulatory approval or commencement of drilling.
        /// </summary>
          proposed,
        /// <summary>
        /// The facility has been sold, so it is no longer appropriate to keep a close internal status value. Status values may be added at later times without changing the sold status.
        /// </summary>
          sold,
        /// <summary>
        /// Production or injection has been temporarily suspended in a manner that will allow immediate resumption of activities.
        /// </summary>
          suspended,
        
          [XmlEnum("temporarily abandoned")]
          temporarilyabandoned,
        /// <summary>
        /// The facility operations are suspended while tests are being conducted to determine formation and/or reservoir properties. For example, a drillstem test. This status also includes extended testing.
        /// </summary>
          testing,
        /// <summary>
        /// Information about the status of the well is confidential. This is more explicit than unknown, since it gives the reason that the status value is unknown.
        /// </summary>
          tight,
        
          [XmlEnum("working over")]
          workingover,
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
          unknown
        }
        /// <summary>
        /// This class represents the ItemsChoiceType7 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType7 xsd enumeration.")]
        public enum ItemsChoiceType7 
        {
        
          dTimEnd,
        
          dTimStart,
        
          dateEnd,
        
          dateStart,
        
          month
        }
        /// <summary>
        /// This class represents the ItemChoiceType7 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType7 xsd enumeration.")]
        public enum ItemChoiceType7 
        {
        
          county,
        
          province,
        
          state
        }
        /// <summary>
        /// This class represents the ItemsChoiceType6 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType6 xsd enumeration.")]
        public enum ItemsChoiceType6 
        {
        
          dTimEnd,
        
          dTimStart,
        
          dateEnd,
        
          dateStart
        }
        /// <summary>
        /// This class represents the ItemChoiceType6 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType6 xsd enumeration.")]
        public enum ItemChoiceType6 
        {
        
          bubblePointPressure,
        
          retrogradeDewPointPressure
        }
        /// <summary>
        /// This class represents the Items1ChoiceType1 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the Items1ChoiceType1 xsd enumeration.")]
        public enum Items1ChoiceType1 
        {
        
          reservoir,
        
          saturated,
        
          stockTank
        }
        /// <summary>
        /// This class represents the ItemChoiceType5 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType5 xsd enumeration.")]
        public enum ItemChoiceType5 
        {
        
          bubblePointPressure,
        
          retrogradeDewPointPressure
        }
        /// <summary>
        /// This class represents the ItemsChoiceType5 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType5 xsd enumeration.")]
        public enum ItemsChoiceType5 
        {
        
          reservoir,
        
          saturated,
        
          stockTank
        }
        /// <summary>
        /// This class represents the ItemsChoiceType4 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType4 xsd enumeration.")]
        public enum ItemsChoiceType4 
        {
        
          reservoir,
        
          saturated,
        
          stockTank
        }
        /// <summary>
        /// This class represents the ItemChoiceType4 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType4 xsd enumeration.")]
        public enum ItemChoiceType4 
        {
        
          bubblePointPressure,
        
          retrogradeDewPointPressure
        }
        /// <summary>
        /// This class represents the ItemsChoiceType3 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType3 xsd enumeration.")]
        public enum ItemsChoiceType3 
        {
        
          reservoir,
        
          saturated,
        
          stockTank
        }
        /// <summary>
        /// This class represents the ItemChoiceType3 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType3 xsd enumeration.")]
        public enum ItemChoiceType3 
        {
        
          bubblePointPressure,
        
          retrogradeDewPointPressure
        }
        /// <summary>
        /// This class represents the ItemsChoiceType2 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType2 xsd enumeration.")]
        public enum ItemsChoiceType2 
        {
        
          reservoir,
        
          saturated,
        
          stockTank
        }
        /// <summary>
        /// This class represents the ItemChoiceType2 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType2 xsd enumeration.")]
        public enum ItemChoiceType2 
        {
        
          bubblePointPressure,
        
          retrogradeDewPointPressure
        }
        /// <summary>
        /// This class represents the ItemsChoiceType1 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemsChoiceType1 xsd enumeration.")]
        public enum ItemsChoiceType1 
        {
        
          liquidDropoutPercent,
        
          liquidVolume,
        
          totalVolume
        }
        /// <summary>
        /// This class represents the Items1ChoiceType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the Items1ChoiceType xsd enumeration.")]
        public enum Items1ChoiceType 
        {
        
          reservoir,
        
          saturated,
        
          stockTank
        }
        /// <summary>
        /// This class represents the ItemChoiceType1 xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType1 xsd enumeration.")]
        public enum ItemChoiceType1 
        {
        
          bubblePointPressure,
        
          retrogradeDewPointPressure
        }
        /// <summary>
        /// This class represents the ItemChoiceType xsd enumeration.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/schemas/1series")]
        [Description("This class represents the ItemChoiceType xsd enumeration.")]
        public enum ItemChoiceType 
        {
        
          bubblePointPressure,
        
          retrogradeDewPointPressure
        }
    }
    #endregion
}