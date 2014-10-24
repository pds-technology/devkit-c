using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.PRODML121
{
    /// <summary>
    /// The names of agreed extensions to WITSML.
    ///		This list may be locally extended but it is recommended that new names be
    ///		approved by the WITSML SIG before use.
    ///		Each standard name must define its data type.
    ///		For string types, the maximum length must be defined in number of characters.
    ///		For measures, the expected measure class must be defined.
    /// </summary>
    public class ExtensionName : Energistics.DataAccess.EnumValue.ExtensionDataEnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ExtensionName(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ExtensionName</param>
        public ExtensionName(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ExtensionNames
        /// </summary>
        /// <returns>The complete list of ExtensionNames</returns>
        public static List<ExtensionName> GetList()
        {
            return GetList<ExtensionName>();
        }

        private static ExtensionName dummyexamplestring;
        /// <summary>
        /// This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a string of maximum length of 64 characters which can be used in the commonData of any object. The semantics of the name would be defined in this description field.
        /// </summary>
        [EnumValueNameAttribute("dummy-example-string")]
        public static ExtensionName Dummyexamplestring
        {
            get 
            {
                if (dummyexamplestring == null)
                {
                    dummyexamplestring = new ExtensionName("dummy-example-string");
                    dummyexamplestring.ExtensionDataType = typeof(String);
                    dummyexamplestring.ExtensionMaximumSize = 64;
                    dummyexamplestring.ExtensionPath = ".//commonData/extensionNameValue";
                    dummyexamplestring.Description = "This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a string of maximum length of 64 characters which can be used in the commonData of any object. The semantics of the name would be defined in this description field.";
                }
                return dummyexamplestring;
            }
        }

        private static ExtensionName dummyexamplemeasure;
        /// <summary>
        /// This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a length measure which can only be specified in the commonData of the well and wellbore objects. The semantics of the name would be defined in this description field. The extensionMeasureClass constrains the allowed units of measure for each value. The extensionDataType value of double constrains the size of each value.
        /// </summary>
        [EnumValueNameAttribute("dummy-example-measure")]
        public static ExtensionName Dummyexamplemeasure
        {
            get 
            {
                if (dummyexamplemeasure == null)
                {
                    dummyexamplemeasure = new ExtensionName("dummy-example-measure");
                    dummyexamplemeasure.ExtensionDataType = typeof(Double);
                    dummyexamplemeasure.ExtensionMeasureClass = "length";
                    dummyexamplemeasure.ExtensionPath = "/well/commonData/extensionNameValue";
                    dummyexamplemeasure.Description = "This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a length measure which can only be specified in the commonData of the well and wellbore objects. The semantics of the name would be defined in this description field. The extensionMeasureClass constrains the allowed units of measure for each value. The extensionDataType value of double constrains the size of each value.";
                }
                return dummyexamplemeasure;
            }
        }

        private static ExtensionName dummyexampledatetime;
        /// <summary>
        /// This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a dateTime value which can be specified anywhere in the tubular object. The semantics of the name would be defined in this description field.
        /// </summary>
        [EnumValueNameAttribute("dummy-example-dateTime")]
        public static ExtensionName Dummyexampledatetime
        {
            get 
            {
                if (dummyexampledatetime == null)
                {
                    dummyexampledatetime = new ExtensionName("dummy-example-dateTime");
                    dummyexampledatetime.ExtensionDataType = typeof(DateTime);
                    dummyexampledatetime.ExtensionPath = "/tubular//extensionNameValue";
                    dummyexampledatetime.Description = "This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a dateTime value which can be specified anywhere in the tubular object. The semantics of the name would be defined in this description field.";
                }
                return dummyexampledatetime;
            }
        }

    }

    /// <summary>
    /// Defines classes of measures and their allowed units of measures.
    ///		For a value whose underlying meaning conforms to one of these classes, 
    ///		any specified unit of measure must conform to the defined list.
    ///		These are copied from the Energistics (POSC) Units Classes v2.2.
    ///		The units of measure map to the POSC Units of Measure Dictionary v2.2.
    /// </summary>
    public class MeasureClass : Energistics.DataAccess.EnumValue.MeasureUOMEnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected MeasureClass(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the MeasureClass</param>
        public MeasureClass(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of MeasureClasss
        /// </summary>
        /// <returns>The complete list of MeasureClasss</returns>
        public static List<MeasureClass> GetList()
        {
            return GetList<MeasureClass>();
        }

        private static MeasureClass absorbedDose;
        /// <summary>
        /// The amount of energy absorbed per mass.
        /// </summary>
        [EnumValueNameAttribute("absorbed dose")]
        public static MeasureClass AbsorbedDose
        {
            get 
            {
                if (absorbedDose == null)
                {
                    absorbedDose = new MeasureClass("absorbed dose");
                    absorbedDose.MeasureRepresentativeUOM = "Gy";
                    absorbedDose.MeasureBaseForConversion = "Gy";
                    absorbedDose.MeasureUom = "Gy";
                    absorbedDose.Description = "The amount of energy absorbed per mass.";
                }
                return absorbedDose;
            }
        }

        private static MeasureClass accelerationLinear;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("acceleration linear")]
        public static MeasureClass AccelerationLinear
        {
            get 
            {
                if (accelerationLinear == null)
                {
                    accelerationLinear = new MeasureClass("acceleration linear");
                    accelerationLinear.MeasureRepresentativeUOM = "m/s2";
                    accelerationLinear.MeasureBaseForConversion = "m/s2";
                    accelerationLinear.MeasureUom = "Gal";
                }
                return accelerationLinear;
            }
        }

        private static MeasureClass activityOfRadioactivity;
        /// <summary>
        /// A measure of the radiation being emitted.
        /// </summary>
        [EnumValueNameAttribute("activity (of radioactivity)")]
        public static MeasureClass ActivityOfRadioactivity
        {
            get 
            {
                if (activityOfRadioactivity == null)
                {
                    activityOfRadioactivity = new MeasureClass("activity (of radioactivity)");
                    activityOfRadioactivity.MeasureRepresentativeUOM = "Bq";
                    activityOfRadioactivity.MeasureBaseForConversion = "Bq";
                    activityOfRadioactivity.MeasureUom = "Bq";
                    activityOfRadioactivity.Description = "A measure of the radiation being emitted.";
                }
                return activityOfRadioactivity;
            }
        }

        private static MeasureClass concentrationOfB;
        /// <summary>
        /// molar concentration of a substance
        /// </summary>
        [EnumValueNameAttribute("concentration of B")]
        public static MeasureClass ConcentrationOfB
        {
            get 
            {
                if (concentrationOfB == null)
                {
                    concentrationOfB = new MeasureClass("concentration of B");
                    concentrationOfB.MeasureRepresentativeUOM = "mol/m3";
                    concentrationOfB.MeasureBaseForConversion = "mol/m3";
                    concentrationOfB.MeasureUom = "kmol/m3";
                    concentrationOfB.Description = "molar concentration of a substance";
                }
                return concentrationOfB;
            }
        }

        private static MeasureClass amountOfSubstance;
        /// <summary>
        /// molar amount of a substance
        /// </summary>
        [EnumValueNameAttribute("amount of substance")]
        public static MeasureClass AmountOfSubstance
        {
            get 
            {
                if (amountOfSubstance == null)
                {
                    amountOfSubstance = new MeasureClass("amount of substance");
                    amountOfSubstance.MeasureRepresentativeUOM = "mol";
                    amountOfSubstance.MeasureBaseForConversion = "mol";
                    amountOfSubstance.MeasureUom = "kmol";
                    amountOfSubstance.Description = "molar amount of a substance";
                }
                return amountOfSubstance;
            }
        }

        private static MeasureClass anglePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per length")]
        public static MeasureClass AnglePerLength
        {
            get 
            {
                if (anglePerLength == null)
                {
                    anglePerLength = new MeasureClass("angle per length");
                    anglePerLength.MeasureRepresentativeUOM = "rad/m";
                    anglePerLength.MeasureBaseForConversion = "rad/m";
                    anglePerLength.MeasureUom = "dega/100ft";
                }
                return anglePerLength;
            }
        }

        private static MeasureClass anglePerTime;
        /// <summary>
        /// The angular velocity. The rate of change of an angle.
        /// </summary>
        [EnumValueNameAttribute("angle per time")]
        public static MeasureClass AnglePerTime
        {
            get 
            {
                if (anglePerTime == null)
                {
                    anglePerTime = new MeasureClass("angle per time");
                    anglePerTime.MeasureRepresentativeUOM = "rad/s";
                    anglePerTime.MeasureBaseForConversion = "rad/s";
                    anglePerTime.MeasureUom = "c/s";
                    anglePerTime.Description = "The angular velocity. The rate of change of an angle.";
                }
                return anglePerTime;
            }
        }

        private static MeasureClass anglePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per volume")]
        public static MeasureClass AnglePerVolume
        {
            get 
            {
                if (anglePerVolume == null)
                {
                    anglePerVolume = new MeasureClass("angle per volume");
                    anglePerVolume.MeasureRepresentativeUOM = "rad/m3";
                    anglePerVolume.MeasureBaseForConversion = "rad/m3";
                    anglePerVolume.MeasureUom = "rad/ft3";
                }
                return anglePerVolume;
            }
        }

        private static MeasureClass angularAcceleration;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angular acceleration")]
        public static MeasureClass AngularAcceleration
        {
            get 
            {
                if (angularAcceleration == null)
                {
                    angularAcceleration = new MeasureClass("angular acceleration");
                    angularAcceleration.MeasureRepresentativeUOM = "rad/s2";
                    angularAcceleration.MeasureBaseForConversion = "rad/s2";
                    angularAcceleration.MeasureUom = "rad/s2";
                }
                return angularAcceleration;
            }
        }

        private static MeasureClass area;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area")]
        public static MeasureClass Area
        {
            get 
            {
                if (area == null)
                {
                    area = new MeasureClass("area");
                    area.MeasureRepresentativeUOM = "m2";
                    area.MeasureBaseForConversion = "m2";
                    area.MeasureUom = "acre";
                }
                return area;
            }
        }

        private static MeasureClass areaPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area per area")]
        public static MeasureClass AreaPerArea
        {
            get 
            {
                if (areaPerArea == null)
                {
                    areaPerArea = new MeasureClass("area per area");
                    areaPerArea.MeasureRepresentativeUOM = "m2/m2";
                    areaPerArea.MeasureBaseForConversion = "Euc";
                    areaPerArea.MeasureUom = "%";
                }
                return areaPerArea;
            }
        }

        private static MeasureClass areaPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area per volume")]
        public static MeasureClass AreaPerVolume
        {
            get 
            {
                if (areaPerVolume == null)
                {
                    areaPerVolume = new MeasureClass("area per volume");
                    areaPerVolume.MeasureRepresentativeUOM = "m2/m3";
                    areaPerVolume.MeasureBaseForConversion = "1/m";
                    areaPerVolume.MeasureUom = "b/cm3";
                }
                return areaPerVolume;
            }
        }

        private static MeasureClass attenuation;
        /// <summary>
        /// A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave.
        /// </summary>
        [EnumValueNameAttribute("attenuation")]
        public static MeasureClass Attenuation
        {
            get 
            {
                if (attenuation == null)
                {
                    attenuation = new MeasureClass("attenuation");
                    attenuation.MeasureRepresentativeUOM = "Euc";
                    attenuation.MeasureBaseForConversion = "Euc";
                    attenuation.MeasureUom = "B/O";
                    attenuation.Description = "A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave.";
                }
                return attenuation;
            }
        }

        private static MeasureClass attenuationPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("attenuation per length")]
        public static MeasureClass AttenuationPerLength
        {
            get 
            {
                if (attenuationPerLength == null)
                {
                    attenuationPerLength = new MeasureClass("attenuation per length");
                    attenuationPerLength.MeasureRepresentativeUOM = "B/m";
                    attenuationPerLength.MeasureBaseForConversion = "B/m";
                    attenuationPerLength.MeasureUom = "B/m";
                }
                return attenuationPerLength;
            }
        }

        private static MeasureClass capacitance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("capacitance")]
        public static MeasureClass Capacitance
        {
            get 
            {
                if (capacitance == null)
                {
                    capacitance = new MeasureClass("capacitance");
                    capacitance.MeasureRepresentativeUOM = "F";
                    capacitance.MeasureBaseForConversion = "F";
                    capacitance.MeasureUom = "F";
                }
                return capacitance;
            }
        }

        private static MeasureClass chargeDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("charge density")]
        public static MeasureClass ChargeDensity
        {
            get 
            {
                if (chargeDensity == null)
                {
                    chargeDensity = new MeasureClass("charge density");
                    chargeDensity.MeasureRepresentativeUOM = "C/m3";
                    chargeDensity.MeasureBaseForConversion = "C/m3";
                    chargeDensity.MeasureUom = "C/cm3";
                }
                return chargeDensity;
            }
        }

        private static MeasureClass chemicalPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("chemical potential")]
        public static MeasureClass ChemicalPotential
        {
            get 
            {
                if (chemicalPotential == null)
                {
                    chemicalPotential = new MeasureClass("chemical potential");
                    chemicalPotential.MeasureRepresentativeUOM = "J/mol";
                    chemicalPotential.MeasureBaseForConversion = "J/mol";
                    chemicalPotential.MeasureUom = "Btu/lbmole";
                }
                return chemicalPotential;
            }
        }

        private static MeasureClass compressibility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("compressibility")]
        public static MeasureClass Compressibility
        {
            get 
            {
                if (compressibility == null)
                {
                    compressibility = new MeasureClass("compressibility");
                    compressibility.MeasureRepresentativeUOM = "1/Pa";
                    compressibility.MeasureBaseForConversion = "1/Pa";
                    compressibility.MeasureUom = "1/Pa";
                }
                return compressibility;
            }
        }

        private static MeasureClass conductivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("conductivity")]
        public static MeasureClass Conductivity
        {
            get 
            {
                if (conductivity == null)
                {
                    conductivity = new MeasureClass("conductivity");
                    conductivity.MeasureRepresentativeUOM = "S/m";
                    conductivity.MeasureBaseForConversion = "S/m";
                    conductivity.MeasureUom = "S/m";
                }
                return conductivity;
            }
        }

        private static MeasureClass crossSectionAbsorption;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("cross section absorption")]
        public static MeasureClass CrossSectionAbsorption
        {
            get 
            {
                if (crossSectionAbsorption == null)
                {
                    crossSectionAbsorption = new MeasureClass("cross section absorption");
                    crossSectionAbsorption.MeasureRepresentativeUOM = "m2/mol";
                    crossSectionAbsorption.MeasureBaseForConversion = "m2/mol";
                    crossSectionAbsorption.MeasureUom = "b/elec";
                }
                return crossSectionAbsorption;
            }
        }

        private static MeasureClass currentDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("current density")]
        public static MeasureClass CurrentDensity
        {
            get 
            {
                if (currentDensity == null)
                {
                    currentDensity = new MeasureClass("current density");
                    currentDensity.MeasureRepresentativeUOM = "A/m2";
                    currentDensity.MeasureBaseForConversion = "A/m2";
                    currentDensity.MeasureUom = "A/cm2";
                }
                return currentDensity;
            }
        }

        private static MeasureClass darcyFlowCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Darcy flow coefficient")]
        public static MeasureClass DarcyFlowCoefficient
        {
            get 
            {
                if (darcyFlowCoefficient == null)
                {
                    darcyFlowCoefficient = new MeasureClass("Darcy flow coefficient");
                    darcyFlowCoefficient.MeasureRepresentativeUOM = "Pa/m3";
                    darcyFlowCoefficient.MeasureBaseForConversion = "Pa/m3";
                    darcyFlowCoefficient.MeasureUom = "Pa/m3";
                }
                return darcyFlowCoefficient;
            }
        }

        private static MeasureClass dataTransmissionSpeed;
        /// <summary>
        /// used primarily for computer transmission rates.
        /// </summary>
        [EnumValueNameAttribute("data transmission speed")]
        public static MeasureClass DataTransmissionSpeed
        {
            get 
            {
                if (dataTransmissionSpeed == null)
                {
                    dataTransmissionSpeed = new MeasureClass("data transmission speed");
                    dataTransmissionSpeed.MeasureRepresentativeUOM = "Bd";
                    dataTransmissionSpeed.MeasureBaseForConversion = "Bd";
                    dataTransmissionSpeed.MeasureUom = "Bd";
                    dataTransmissionSpeed.Description = "used primarily for computer transmission rates.";
                }
                return dataTransmissionSpeed;
            }
        }

        private static MeasureClass deltaTemperature;
        /// <summary>
        /// Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures.
        /// </summary>
        [EnumValueNameAttribute("delta temperature")]
        public static MeasureClass DeltaTemperature
        {
            get 
            {
                if (deltaTemperature == null)
                {
                    deltaTemperature = new MeasureClass("delta temperature");
                    deltaTemperature.MeasureRepresentativeUOM = "K";
                    deltaTemperature.MeasureBaseForConversion = "K";
                    deltaTemperature.MeasureUom = "K";
                    deltaTemperature.Description = "Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures.";
                }
                return deltaTemperature;
            }
        }

        private static MeasureClass density;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static MeasureClass Density
        {
            get 
            {
                if (density == null)
                {
                    density = new MeasureClass("density");
                    density.MeasureRepresentativeUOM = "kg/m3";
                    density.MeasureBaseForConversion = "kg/m3";
                    density.MeasureUom = "10Mg/m3";
                }
                return density;
            }
        }

        private static MeasureClass diffusionCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("diffusion coefficient")]
        public static MeasureClass DiffusionCoefficient
        {
            get 
            {
                if (diffusionCoefficient == null)
                {
                    diffusionCoefficient = new MeasureClass("diffusion coefficient");
                    diffusionCoefficient.MeasureRepresentativeUOM = "m2/s";
                    diffusionCoefficient.MeasureBaseForConversion = "m2/s";
                    diffusionCoefficient.MeasureUom = "m2/s";
                }
                return diffusionCoefficient;
            }
        }

        private static MeasureClass digitalStorage;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("digital storage")]
        public static MeasureClass DigitalStorage
        {
            get 
            {
                if (digitalStorage == null)
                {
                    digitalStorage = new MeasureClass("digital storage");
                    digitalStorage.MeasureRepresentativeUOM = "byte";
                    digitalStorage.MeasureBaseForConversion = "byte";
                    digitalStorage.MeasureUom = "Mbyte";
                }
                return digitalStorage;
            }
        }

        private static MeasureClass dimensionless;
        /// <summary>
        /// A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass.
        /// </summary>
        [EnumValueNameAttribute("dimensionless")]
        public static MeasureClass Dimensionless
        {
            get 
            {
                if (dimensionless == null)
                {
                    dimensionless = new MeasureClass("dimensionless");
                    dimensionless.MeasureRepresentativeUOM = "Euc";
                    dimensionless.MeasureBaseForConversion = "Euc";
                    dimensionless.MeasureUom = "%";
                    dimensionless.Description = "A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass.";
                }
                return dimensionless;
            }
        }

        private static MeasureClass doseEquivalent;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent")]
        public static MeasureClass DoseEquivalent
        {
            get 
            {
                if (doseEquivalent == null)
                {
                    doseEquivalent = new MeasureClass("dose equivalent");
                    doseEquivalent.MeasureRepresentativeUOM = "Sv";
                    doseEquivalent.MeasureBaseForConversion = "Sv";
                    doseEquivalent.MeasureUom = "Sv";
                }
                return doseEquivalent;
            }
        }

        private static MeasureClass doseEquivalentRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent rate")]
        public static MeasureClass DoseEquivalentRate
        {
            get 
            {
                if (doseEquivalentRate == null)
                {
                    doseEquivalentRate = new MeasureClass("dose equivalent rate");
                    doseEquivalentRate.MeasureRepresentativeUOM = "Sv/s";
                    doseEquivalentRate.MeasureBaseForConversion = "Sv/s";
                    doseEquivalentRate.MeasureUom = "Sv/h";
                }
                return doseEquivalentRate;
            }
        }

        private static MeasureClass dynamicViscosity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dynamic viscosity")]
        public static MeasureClass DynamicViscosity
        {
            get 
            {
                if (dynamicViscosity == null)
                {
                    dynamicViscosity = new MeasureClass("dynamic viscosity");
                    dynamicViscosity.MeasureRepresentativeUOM = "Pa.s";
                    dynamicViscosity.MeasureBaseForConversion = "Pa.s";
                    dynamicViscosity.MeasureUom = "N.s/m2";
                }
                return dynamicViscosity;
            }
        }

        private static MeasureClass electricCharge;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric charge")]
        public static MeasureClass ElectricCharge
        {
            get 
            {
                if (electricCharge == null)
                {
                    electricCharge = new MeasureClass("electric charge");
                    electricCharge.MeasureRepresentativeUOM = "C";
                    electricCharge.MeasureBaseForConversion = "C";
                    electricCharge.MeasureUom = "A.h";
                }
                return electricCharge;
            }
        }

        private static MeasureClass electricConductance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric conductance")]
        public static MeasureClass ElectricConductance
        {
            get 
            {
                if (electricConductance == null)
                {
                    electricConductance = new MeasureClass("electric conductance");
                    electricConductance.MeasureRepresentativeUOM = "S";
                    electricConductance.MeasureBaseForConversion = "S";
                    electricConductance.MeasureUom = "GS";
                }
                return electricConductance;
            }
        }

        private static MeasureClass electricCurrent;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric current")]
        public static MeasureClass ElectricCurrent
        {
            get 
            {
                if (electricCurrent == null)
                {
                    electricCurrent = new MeasureClass("electric current");
                    electricCurrent.MeasureRepresentativeUOM = "A";
                    electricCurrent.MeasureBaseForConversion = "A";
                    electricCurrent.MeasureUom = "A";
                }
                return electricCurrent;
            }
        }

        private static MeasureClass electricDipoleMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric dipole moment")]
        public static MeasureClass ElectricDipoleMoment
        {
            get 
            {
                if (electricDipoleMoment == null)
                {
                    electricDipoleMoment = new MeasureClass("electric dipole moment");
                    electricDipoleMoment.MeasureRepresentativeUOM = "C.m";
                    electricDipoleMoment.MeasureBaseForConversion = "C.m";
                    electricDipoleMoment.MeasureUom = "C.m";
                }
                return electricDipoleMoment;
            }
        }

        private static MeasureClass electricFieldStrength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric field strength")]
        public static MeasureClass ElectricFieldStrength
        {
            get 
            {
                if (electricFieldStrength == null)
                {
                    electricFieldStrength = new MeasureClass("electric field strength");
                    electricFieldStrength.MeasureRepresentativeUOM = "V/m";
                    electricFieldStrength.MeasureBaseForConversion = "V/m";
                    electricFieldStrength.MeasureUom = "V/m";
                }
                return electricFieldStrength;
            }
        }

        private static MeasureClass electricPolarization;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric polarization")]
        public static MeasureClass ElectricPolarization
        {
            get 
            {
                if (electricPolarization == null)
                {
                    electricPolarization = new MeasureClass("electric polarization");
                    electricPolarization.MeasureRepresentativeUOM = "C/m2";
                    electricPolarization.MeasureBaseForConversion = "C/m2";
                    electricPolarization.MeasureUom = "C/cm2";
                }
                return electricPolarization;
            }
        }

        private static MeasureClass electricPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric potential")]
        public static MeasureClass ElectricPotential
        {
            get 
            {
                if (electricPotential == null)
                {
                    electricPotential = new MeasureClass("electric potential");
                    electricPotential.MeasureRepresentativeUOM = "V";
                    electricPotential.MeasureBaseForConversion = "V";
                    electricPotential.MeasureUom = "MV";
                }
                return electricPotential;
            }
        }

        private static MeasureClass electricalResistivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electrical resistivity")]
        public static MeasureClass ElectricalResistivity
        {
            get 
            {
                if (electricalResistivity == null)
                {
                    electricalResistivity = new MeasureClass("electrical resistivity");
                    electricalResistivity.MeasureRepresentativeUOM = "ohm.m";
                    electricalResistivity.MeasureBaseForConversion = "ohm.m";
                    electricalResistivity.MeasureUom = "kohm.m";
                }
                return electricalResistivity;
            }
        }

        private static MeasureClass electrochemicalEquivalent;
        /// <summary>
        /// An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered.
        /// </summary>
        [EnumValueNameAttribute("electrochemical equivalent")]
        public static MeasureClass ElectrochemicalEquivalent
        {
            get 
            {
                if (electrochemicalEquivalent == null)
                {
                    electrochemicalEquivalent = new MeasureClass("electrochemical equivalent");
                    electrochemicalEquivalent.MeasureRepresentativeUOM = "eq";
                    electrochemicalEquivalent.MeasureBaseForConversion = "eq";
                    electrochemicalEquivalent.MeasureUom = "eq";
                    electrochemicalEquivalent.Description = "An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered.";
                }
                return electrochemicalEquivalent;
            }
        }

        private static MeasureClass electromagneticMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electromagnetic moment")]
        public static MeasureClass ElectromagneticMoment
        {
            get 
            {
                if (electromagneticMoment == null)
                {
                    electromagneticMoment = new MeasureClass("electromagnetic moment");
                    electromagneticMoment.MeasureRepresentativeUOM = "A.m2";
                    electromagneticMoment.MeasureBaseForConversion = "A.m2";
                    electromagneticMoment.MeasureUom = "A.m2";
                }
                return electromagneticMoment;
            }
        }

        private static MeasureClass energyLengthPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per area")]
        public static MeasureClass EnergyLengthPerArea
        {
            get 
            {
                if (energyLengthPerArea == null)
                {
                    energyLengthPerArea = new MeasureClass("energy length per area");
                    energyLengthPerArea.MeasureRepresentativeUOM = "kcal.m/cm2";
                    energyLengthPerArea.MeasureBaseForConversion = "kcal.m/cm2";
                    energyLengthPerArea.MeasureUom = "kcal.m/cm2";
                }
                return energyLengthPerArea;
            }
        }

        private static MeasureClass energyLengthPerTimeAreaTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per time area temperature")]
        public static MeasureClass EnergyLengthPerTimeAreaTemperature
        {
            get 
            {
                if (energyLengthPerTimeAreaTemperature == null)
                {
                    energyLengthPerTimeAreaTemperature = new MeasureClass("energy length per time area temperature");
                    energyLengthPerTimeAreaTemperature.MeasureRepresentativeUOM = "W/m.K";
                    energyLengthPerTimeAreaTemperature.MeasureBaseForConversion = "W/m.K";
                    energyLengthPerTimeAreaTemperature.MeasureUom = "Btu.in/hr.ft2.F";
                }
                return energyLengthPerTimeAreaTemperature;
            }
        }

        private static MeasureClass energyPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per area")]
        public static MeasureClass EnergyPerArea
        {
            get 
            {
                if (energyPerArea == null)
                {
                    energyPerArea = new MeasureClass("energy per area");
                    energyPerArea.MeasureRepresentativeUOM = "N/m";
                    energyPerArea.MeasureBaseForConversion = "N/m";
                    energyPerArea.MeasureUom = "J/cm2";
                }
                return energyPerArea;
            }
        }

        private static MeasureClass energyPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per length")]
        public static MeasureClass EnergyPerLength
        {
            get 
            {
                if (energyPerLength == null)
                {
                    energyPerLength = new MeasureClass("energy per length");
                    energyPerLength.MeasureRepresentativeUOM = "J/m";
                    energyPerLength.MeasureBaseForConversion = "J/m";
                    energyPerLength.MeasureUom = "J/m";
                }
                return energyPerLength;
            }
        }

        private static MeasureClass equivalentPerMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per mass")]
        public static MeasureClass EquivalentPerMass
        {
            get 
            {
                if (equivalentPerMass == null)
                {
                    equivalentPerMass = new MeasureClass("equivalent per mass");
                    equivalentPerMass.MeasureRepresentativeUOM = "eq/kg";
                    equivalentPerMass.MeasureBaseForConversion = "eq/kg";
                    equivalentPerMass.MeasureUom = "eq/kg";
                }
                return equivalentPerMass;
            }
        }

        private static MeasureClass equivalentPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per volume")]
        public static MeasureClass EquivalentPerVolume
        {
            get 
            {
                if (equivalentPerVolume == null)
                {
                    equivalentPerVolume = new MeasureClass("equivalent per volume");
                    equivalentPerVolume.MeasureRepresentativeUOM = "eq/L";
                    equivalentPerVolume.MeasureBaseForConversion = "eq/L";
                    equivalentPerVolume.MeasureUom = "eq/L";
                }
                return equivalentPerVolume;
            }
        }

        private static MeasureClass exposureRadioactivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("exposure (radioactivity)")]
        public static MeasureClass ExposureRadioactivity
        {
            get 
            {
                if (exposureRadioactivity == null)
                {
                    exposureRadioactivity = new MeasureClass("exposure (radioactivity)");
                    exposureRadioactivity.MeasureRepresentativeUOM = "C/kg";
                    exposureRadioactivity.MeasureBaseForConversion = "C/kg";
                    exposureRadioactivity.MeasureUom = "C/g";
                }
                return exposureRadioactivity;
            }
        }

        private static MeasureClass force;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force")]
        public static MeasureClass Force
        {
            get 
            {
                if (force == null)
                {
                    force = new MeasureClass("force");
                    force.MeasureRepresentativeUOM = "N";
                    force.MeasureBaseForConversion = "N";
                    force.MeasureUom = "MN";
                }
                return force;
            }
        }

        private static MeasureClass forceArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force area")]
        public static MeasureClass ForceArea
        {
            get 
            {
                if (forceArea == null)
                {
                    forceArea = new MeasureClass("force area");
                    forceArea.MeasureRepresentativeUOM = "N.m2";
                    forceArea.MeasureBaseForConversion = "N.m2";
                    forceArea.MeasureUom = "N.m2";
                }
                return forceArea;
            }
        }

        private static MeasureClass forceLengthPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force length per length")]
        public static MeasureClass ForceLengthPerLength
        {
            get 
            {
                if (forceLengthPerLength == null)
                {
                    forceLengthPerLength = new MeasureClass("force length per length");
                    forceLengthPerLength.MeasureRepresentativeUOM = "kgf.m/m";
                    forceLengthPerLength.MeasureBaseForConversion = "kgf.m/m";
                    forceLengthPerLength.MeasureUom = "N.m/m";
                }
                return forceLengthPerLength;
            }
        }

        private static MeasureClass forcePerForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per force")]
        public static MeasureClass ForcePerForce
        {
            get 
            {
                if (forcePerForce == null)
                {
                    forcePerForce = new MeasureClass("force per force");
                    forcePerForce.MeasureRepresentativeUOM = "N/N";
                    forcePerForce.MeasureBaseForConversion = "Euc";
                    forcePerForce.MeasureUom = "%";
                }
                return forcePerForce;
            }
        }

        private static MeasureClass forcePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per length")]
        public static MeasureClass ForcePerLength
        {
            get 
            {
                if (forcePerLength == null)
                {
                    forcePerLength = new MeasureClass("force per length");
                    forcePerLength.MeasureRepresentativeUOM = "N/m";
                    forcePerLength.MeasureBaseForConversion = "N/m";
                    forcePerLength.MeasureUom = "N/30m";
                }
                return forcePerLength;
            }
        }

        private static MeasureClass forcePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per volume")]
        public static MeasureClass ForcePerVolume
        {
            get 
            {
                if (forcePerVolume == null)
                {
                    forcePerVolume = new MeasureClass("force per volume");
                    forcePerVolume.MeasureRepresentativeUOM = "N/m3";
                    forcePerVolume.MeasureBaseForConversion = "N/m3";
                    forcePerVolume.MeasureUom = "GPa/cm";
                }
                return forcePerVolume;
            }
        }

        private static MeasureClass frequency;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("frequency")]
        public static MeasureClass Frequency
        {
            get 
            {
                if (frequency == null)
                {
                    frequency = new MeasureClass("frequency");
                    frequency.MeasureRepresentativeUOM = "Hz";
                    frequency.MeasureBaseForConversion = "Hz";
                    frequency.MeasureUom = "1/s";
                }
                return frequency;
            }
        }

        private static MeasureClass frequencyInterval;
        /// <summary>
        /// An octave is a doubling of a frquency.
        /// </summary>
        [EnumValueNameAttribute("frequency interval")]
        public static MeasureClass FrequencyInterval
        {
            get 
            {
                if (frequencyInterval == null)
                {
                    frequencyInterval = new MeasureClass("frequency interval");
                    frequencyInterval.MeasureRepresentativeUOM = "O";
                    frequencyInterval.MeasureBaseForConversion = "O";
                    frequencyInterval.MeasureUom = "O";
                    frequencyInterval.Description = "An octave is a doubling of a frquency.";
                }
                return frequencyInterval;
            }
        }

        private static MeasureClass gammaRayApiUnit;
        /// <summary>
        /// This class is defined by the API, and is used for units of gamma ray log response.
        /// </summary>
        [EnumValueNameAttribute("gamma ray API unit")]
        public static MeasureClass GammaRayApiUnit
        {
            get 
            {
                if (gammaRayApiUnit == null)
                {
                    gammaRayApiUnit = new MeasureClass("gamma ray API unit");
                    gammaRayApiUnit.MeasureRepresentativeUOM = "gAPI";
                    gammaRayApiUnit.MeasureBaseForConversion = "gAPI";
                    gammaRayApiUnit.MeasureUom = "gAPI";
                    gammaRayApiUnit.Description = "This class is defined by the API, and is used for units of gamma ray log response.";
                }
                return gammaRayApiUnit;
            }
        }

        private static MeasureClass heatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat capacity")]
        public static MeasureClass HeatCapacity
        {
            get 
            {
                if (heatCapacity == null)
                {
                    heatCapacity = new MeasureClass("heat capacity");
                    heatCapacity.MeasureRepresentativeUOM = "J/K";
                    heatCapacity.MeasureBaseForConversion = "J/K";
                    heatCapacity.MeasureUom = "J/K";
                }
                return heatCapacity;
            }
        }

        private static MeasureClass heatFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat flow rate")]
        public static MeasureClass HeatFlowRate
        {
            get 
            {
                if (heatFlowRate == null)
                {
                    heatFlowRate = new MeasureClass("heat flow rate");
                    heatFlowRate.MeasureRepresentativeUOM = "W";
                    heatFlowRate.MeasureBaseForConversion = "W";
                    heatFlowRate.MeasureUom = "Btu/hr";
                }
                return heatFlowRate;
            }
        }

        private static MeasureClass heatTransferCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat transfer coefficient")]
        public static MeasureClass HeatTransferCoefficient
        {
            get 
            {
                if (heatTransferCoefficient == null)
                {
                    heatTransferCoefficient = new MeasureClass("heat transfer coefficient");
                    heatTransferCoefficient.MeasureRepresentativeUOM = "W/m2.K";
                    heatTransferCoefficient.MeasureBaseForConversion = "W/m2.K";
                    heatTransferCoefficient.MeasureUom = "Btu/hr.ft2.degF";
                }
                return heatTransferCoefficient;
            }
        }

        private static MeasureClass illuminance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("illuminance")]
        public static MeasureClass Illuminance
        {
            get 
            {
                if (illuminance == null)
                {
                    illuminance = new MeasureClass("illuminance");
                    illuminance.MeasureRepresentativeUOM = "lx";
                    illuminance.MeasureBaseForConversion = "lx";
                    illuminance.MeasureUom = "footcandle";
                }
                return illuminance;
            }
        }

        private static MeasureClass irradiance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("irradiance")]
        public static MeasureClass Irradiance
        {
            get 
            {
                if (irradiance == null)
                {
                    irradiance = new MeasureClass("irradiance");
                    irradiance.MeasureRepresentativeUOM = "W/m2";
                    irradiance.MeasureBaseForConversion = "W/m2";
                    irradiance.MeasureUom = "Btu/hr.ft2";
                }
                return irradiance;
            }
        }

        private static MeasureClass isothermalCompressibility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("isothermal compressibility")]
        public static MeasureClass IsothermalCompressibility
        {
            get 
            {
                if (isothermalCompressibility == null)
                {
                    isothermalCompressibility = new MeasureClass("isothermal compressibility");
                    isothermalCompressibility.MeasureRepresentativeUOM = "m3/J";
                    isothermalCompressibility.MeasureBaseForConversion = "m3/J";
                    isothermalCompressibility.MeasureUom = "dm3/MJ";
                }
                return isothermalCompressibility;
            }
        }

        private static MeasureClass kinematicViscosity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kinematic viscosity")]
        public static MeasureClass KinematicViscosity
        {
            get 
            {
                if (kinematicViscosity == null)
                {
                    kinematicViscosity = new MeasureClass("kinematic viscosity");
                    kinematicViscosity.MeasureRepresentativeUOM = "m2/s";
                    kinematicViscosity.MeasureBaseForConversion = "m2/s";
                    kinematicViscosity.MeasureUom = "cSt";
                }
                return kinematicViscosity;
            }
        }

        private static MeasureClass length;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length")]
        public static MeasureClass Length
        {
            get 
            {
                if (length == null)
                {
                    length = new MeasureClass("length");
                    length.MeasureRepresentativeUOM = "m";
                    length.MeasureBaseForConversion = "m";
                    length.MeasureUom = "Mm";
                }
                return length;
            }
        }

        private static MeasureClass lengthPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per length")]
        public static MeasureClass LengthPerLength
        {
            get 
            {
                if (lengthPerLength == null)
                {
                    lengthPerLength = new MeasureClass("length per length");
                    lengthPerLength.MeasureRepresentativeUOM = "m/m";
                    lengthPerLength.MeasureBaseForConversion = "Euc";
                    lengthPerLength.MeasureUom = "%";
                }
                return lengthPerLength;
            }
        }

        private static MeasureClass lengthPerTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per temperature")]
        public static MeasureClass LengthPerTemperature
        {
            get 
            {
                if (lengthPerTemperature == null)
                {
                    lengthPerTemperature = new MeasureClass("length per temperature");
                    lengthPerTemperature.MeasureRepresentativeUOM = "m/K";
                    lengthPerTemperature.MeasureBaseForConversion = "m/K";
                    lengthPerTemperature.MeasureUom = "ft/degF";
                }
                return lengthPerTemperature;
            }
        }

        private static MeasureClass lengthPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per volume")]
        public static MeasureClass LengthPerVolume
        {
            get 
            {
                if (lengthPerVolume == null)
                {
                    lengthPerVolume = new MeasureClass("length per volume");
                    lengthPerVolume.MeasureRepresentativeUOM = "ft/bbl";
                    lengthPerVolume.MeasureBaseForConversion = "ft/bbl";
                    lengthPerVolume.MeasureUom = "ft/bbl";
                }
                return lengthPerVolume;
            }
        }

        private static MeasureClass levelOfPowerIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("level of power intensity")]
        public static MeasureClass LevelOfPowerIntensity
        {
            get 
            {
                if (levelOfPowerIntensity == null)
                {
                    levelOfPowerIntensity = new MeasureClass("level of power intensity");
                    levelOfPowerIntensity.MeasureRepresentativeUOM = "B";
                    levelOfPowerIntensity.MeasureBaseForConversion = "B";
                    levelOfPowerIntensity.MeasureUom = "B";
                }
                return levelOfPowerIntensity;
            }
        }

        private static MeasureClass lightExposure;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("light exposure")]
        public static MeasureClass LightExposure
        {
            get 
            {
                if (lightExposure == null)
                {
                    lightExposure = new MeasureClass("light exposure");
                    lightExposure.MeasureRepresentativeUOM = "lx.s";
                    lightExposure.MeasureBaseForConversion = "lx.s";
                    lightExposure.MeasureUom = "footcandle.s";
                }
                return lightExposure;
            }
        }

        private static MeasureClass massPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per length")]
        public static MeasureClass MassPerLength
        {
            get 
            {
                if (massPerLength == null)
                {
                    massPerLength = new MeasureClass("mass per length");
                    massPerLength.MeasureRepresentativeUOM = "kg/m";
                    massPerLength.MeasureBaseForConversion = "kg/m";
                    massPerLength.MeasureUom = "Mg/in";
                }
                return massPerLength;
            }
        }

        private static MeasureClass linearThermalExpansion;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("linear thermal expansion")]
        public static MeasureClass LinearThermalExpansion
        {
            get 
            {
                if (linearThermalExpansion == null)
                {
                    linearThermalExpansion = new MeasureClass("linear thermal expansion");
                    linearThermalExpansion.MeasureRepresentativeUOM = "in/in.degF";
                    linearThermalExpansion.MeasureBaseForConversion = "in/in.degF";
                    linearThermalExpansion.MeasureUom = "1/K";
                }
                return linearThermalExpansion;
            }
        }

        private static MeasureClass luminance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminance")]
        public static MeasureClass Luminance
        {
            get 
            {
                if (luminance == null)
                {
                    luminance = new MeasureClass("luminance");
                    luminance.MeasureRepresentativeUOM = "cd/m2";
                    luminance.MeasureBaseForConversion = "cd/m2";
                    luminance.MeasureUom = "cd/m2";
                }
                return luminance;
            }
        }

        private static MeasureClass luminousEfficacy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous efficacy")]
        public static MeasureClass LuminousEfficacy
        {
            get 
            {
                if (luminousEfficacy == null)
                {
                    luminousEfficacy = new MeasureClass("luminous efficacy");
                    luminousEfficacy.MeasureRepresentativeUOM = "lm/W";
                    luminousEfficacy.MeasureBaseForConversion = "lm/W";
                    luminousEfficacy.MeasureUom = "lm/W";
                }
                return luminousEfficacy;
            }
        }

        private static MeasureClass luminousFlux;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous flux")]
        public static MeasureClass LuminousFlux
        {
            get 
            {
                if (luminousFlux == null)
                {
                    luminousFlux = new MeasureClass("luminous flux");
                    luminousFlux.MeasureRepresentativeUOM = "lm";
                    luminousFlux.MeasureBaseForConversion = "lm";
                    luminousFlux.MeasureUom = "lm";
                }
                return luminousFlux;
            }
        }

        private static MeasureClass luminousIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous intensity")]
        public static MeasureClass LuminousIntensity
        {
            get 
            {
                if (luminousIntensity == null)
                {
                    luminousIntensity = new MeasureClass("luminous intensity");
                    luminousIntensity.MeasureRepresentativeUOM = "cd";
                    luminousIntensity.MeasureBaseForConversion = "cd";
                    luminousIntensity.MeasureUom = "cd";
                }
                return luminousIntensity;
            }
        }

        private static MeasureClass magneticDipoleMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic dipole moment")]
        public static MeasureClass MagneticDipoleMoment
        {
            get 
            {
                if (magneticDipoleMoment == null)
                {
                    magneticDipoleMoment = new MeasureClass("magnetic dipole moment");
                    magneticDipoleMoment.MeasureRepresentativeUOM = "Wb.m";
                    magneticDipoleMoment.MeasureBaseForConversion = "Wb.m";
                    magneticDipoleMoment.MeasureUom = "Wb.m";
                }
                return magneticDipoleMoment;
            }
        }

        private static MeasureClass magneticFieldStrength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic field strength")]
        public static MeasureClass MagneticFieldStrength
        {
            get 
            {
                if (magneticFieldStrength == null)
                {
                    magneticFieldStrength = new MeasureClass("magnetic field strength");
                    magneticFieldStrength.MeasureRepresentativeUOM = "A/m";
                    magneticFieldStrength.MeasureBaseForConversion = "A/m";
                    magneticFieldStrength.MeasureUom = "A/m";
                }
                return magneticFieldStrength;
            }
        }

        private static MeasureClass magneticFlux;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic flux")]
        public static MeasureClass MagneticFlux
        {
            get 
            {
                if (magneticFlux == null)
                {
                    magneticFlux = new MeasureClass("magnetic flux");
                    magneticFlux.MeasureRepresentativeUOM = "Wb";
                    magneticFlux.MeasureBaseForConversion = "Wb";
                    magneticFlux.MeasureUom = "Wb";
                }
                return magneticFlux;
            }
        }

        private static MeasureClass magneticInduction;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic induction")]
        public static MeasureClass MagneticInduction
        {
            get 
            {
                if (magneticInduction == null)
                {
                    magneticInduction = new MeasureClass("magnetic induction");
                    magneticInduction.MeasureRepresentativeUOM = "T";
                    magneticInduction.MeasureBaseForConversion = "T";
                    magneticInduction.MeasureUom = "T";
                }
                return magneticInduction;
            }
        }

        private static MeasureClass magneticPermeability;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic permeability")]
        public static MeasureClass MagneticPermeability
        {
            get 
            {
                if (magneticPermeability == null)
                {
                    magneticPermeability = new MeasureClass("magnetic permeability");
                    magneticPermeability.MeasureRepresentativeUOM = "H/m";
                    magneticPermeability.MeasureBaseForConversion = "H/m";
                    magneticPermeability.MeasureUom = "H/m";
                }
                return magneticPermeability;
            }
        }

        private static MeasureClass magneticVectorPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic vector potential")]
        public static MeasureClass MagneticVectorPotential
        {
            get 
            {
                if (magneticVectorPotential == null)
                {
                    magneticVectorPotential = new MeasureClass("magnetic vector potential");
                    magneticVectorPotential.MeasureRepresentativeUOM = "Wb/m";
                    magneticVectorPotential.MeasureBaseForConversion = "Wb/m";
                    magneticVectorPotential.MeasureUom = "Wb/m";
                }
                return magneticVectorPotential;
            }
        }

        private static MeasureClass mass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass")]
        public static MeasureClass Mass
        {
            get 
            {
                if (mass == null)
                {
                    mass = new MeasureClass("mass");
                    mass.MeasureRepresentativeUOM = "kg";
                    mass.MeasureBaseForConversion = "kg";
                    mass.MeasureUom = "Mg";
                }
                return mass;
            }
        }

        private static MeasureClass massAttenuationCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass attenuation coefficient")]
        public static MeasureClass MassAttenuationCoefficient
        {
            get 
            {
                if (massAttenuationCoefficient == null)
                {
                    massAttenuationCoefficient = new MeasureClass("mass attenuation coefficient");
                    massAttenuationCoefficient.MeasureRepresentativeUOM = "m2/kg";
                    massAttenuationCoefficient.MeasureBaseForConversion = "m2/kg";
                    massAttenuationCoefficient.MeasureUom = "cm2/g";
                }
                return massAttenuationCoefficient;
            }
        }

        private static MeasureClass massFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass flow rate")]
        public static MeasureClass MassFlowRate
        {
            get 
            {
                if (massFlowRate == null)
                {
                    massFlowRate = new MeasureClass("mass flow rate");
                    massFlowRate.MeasureRepresentativeUOM = "kg/s";
                    massFlowRate.MeasureBaseForConversion = "kg/s";
                    massFlowRate.MeasureUom = "Mg/a";
                }
                return massFlowRate;
            }
        }

        private static MeasureClass massLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass length")]
        public static MeasureClass MassLength
        {
            get 
            {
                if (massLength == null)
                {
                    massLength = new MeasureClass("mass length");
                    massLength.MeasureRepresentativeUOM = "kg.m";
                    massLength.MeasureBaseForConversion = "kg.m";
                    massLength.MeasureUom = "ft.lbm";
                }
                return massLength;
            }
        }

        private static MeasureClass massPerEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per energy")]
        public static MeasureClass MassPerEnergy
        {
            get 
            {
                if (massPerEnergy == null)
                {
                    massPerEnergy = new MeasureClass("mass per energy");
                    massPerEnergy.MeasureRepresentativeUOM = "kg/J";
                    massPerEnergy.MeasureBaseForConversion = "kg/J";
                    massPerEnergy.MeasureUom = "kg/J";
                }
                return massPerEnergy;
            }
        }

        private static MeasureClass massPerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per area")]
        public static MeasureClass MassPerTimePerArea
        {
            get 
            {
                if (massPerTimePerArea == null)
                {
                    massPerTimePerArea = new MeasureClass("mass per time per area");
                    massPerTimePerArea.MeasureRepresentativeUOM = "kg/m2.s";
                    massPerTimePerArea.MeasureBaseForConversion = "kg/m2.s";
                    massPerTimePerArea.MeasureUom = "MPa.s/m";
                }
                return massPerTimePerArea;
            }
        }

        private static MeasureClass massPerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per length")]
        public static MeasureClass MassPerTimePerLength
        {
            get 
            {
                if (massPerTimePerLength == null)
                {
                    massPerTimePerLength = new MeasureClass("mass per time per length");
                    massPerTimePerLength.MeasureRepresentativeUOM = "Pa.s";
                    massPerTimePerLength.MeasureBaseForConversion = "Pa.s";
                    massPerTimePerLength.MeasureUom = "Pa.s";
                }
                return massPerTimePerLength;
            }
        }

        private static MeasureClass massPerVolumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per volume per length")]
        public static MeasureClass MassPerVolumePerLength
        {
            get 
            {
                if (massPerVolumePerLength == null)
                {
                    massPerVolumePerLength = new MeasureClass("mass per volume per length");
                    massPerVolumePerLength.MeasureRepresentativeUOM = "kg/m4";
                    massPerVolumePerLength.MeasureBaseForConversion = "kg/m4";
                    massPerVolumePerLength.MeasureUom = "g/cm4";
                }
                return massPerVolumePerLength;
            }
        }

        private static MeasureClass massConcentration;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass concentration")]
        public static MeasureClass MassConcentration
        {
            get 
            {
                if (massConcentration == null)
                {
                    massConcentration = new MeasureClass("mass concentration");
                    massConcentration.MeasureRepresentativeUOM = "Euc";
                    massConcentration.MeasureBaseForConversion = "Euc";
                    massConcentration.MeasureUom = "%";
                }
                return massConcentration;
            }
        }

        private static MeasureClass mobility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mobility")]
        public static MeasureClass Mobility
        {
            get 
            {
                if (mobility == null)
                {
                    mobility = new MeasureClass("mobility");
                    mobility.MeasureRepresentativeUOM = "m2/Pa.s";
                    mobility.MeasureBaseForConversion = "m2/Pa.s";
                    mobility.MeasureUom = "m2/Pa.s";
                }
                return mobility;
            }
        }

        private static MeasureClass modulusOfCompression;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("modulus of compression")]
        public static MeasureClass ModulusOfCompression
        {
            get 
            {
                if (modulusOfCompression == null)
                {
                    modulusOfCompression = new MeasureClass("modulus of compression");
                    modulusOfCompression.MeasureRepresentativeUOM = "J/m3";
                    modulusOfCompression.MeasureBaseForConversion = "J/m3";
                    modulusOfCompression.MeasureUom = "Btu/bbl";
                }
                return modulusOfCompression;
            }
        }

        private static MeasureClass molarHeatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar heat capacity")]
        public static MeasureClass MolarHeatCapacity
        {
            get 
            {
                if (molarHeatCapacity == null)
                {
                    molarHeatCapacity = new MeasureClass("molar heat capacity");
                    molarHeatCapacity.MeasureRepresentativeUOM = "J/mol.K";
                    molarHeatCapacity.MeasureBaseForConversion = "J/mol.K";
                    molarHeatCapacity.MeasureUom = "Btu/lbmole.F";
                }
                return molarHeatCapacity;
            }
        }

        private static MeasureClass molarVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar volume")]
        public static MeasureClass MolarVolume
        {
            get 
            {
                if (molarVolume == null)
                {
                    molarVolume = new MeasureClass("molar volume");
                    molarVolume.MeasureRepresentativeUOM = "m3/mol";
                    molarVolume.MeasureBaseForConversion = "m3/mol";
                    molarVolume.MeasureUom = "L/mol";
                }
                return molarVolume;
            }
        }

        private static MeasureClass molePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per area")]
        public static MeasureClass MolePerArea
        {
            get 
            {
                if (molePerArea == null)
                {
                    molePerArea = new MeasureClass("mole per area");
                    molePerArea.MeasureRepresentativeUOM = "mol/m2";
                    molePerArea.MeasureBaseForConversion = "mol/m2";
                    molePerArea.MeasureUom = "mol/m2";
                }
                return molePerArea;
            }
        }

        private static MeasureClass molePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time")]
        public static MeasureClass MolePerTime
        {
            get 
            {
                if (molePerTime == null)
                {
                    molePerTime = new MeasureClass("mole per time");
                    molePerTime.MeasureRepresentativeUOM = "mol/s";
                    molePerTime.MeasureBaseForConversion = "mol/s";
                    molePerTime.MeasureUom = "kmol/h";
                }
                return molePerTime;
            }
        }

        private static MeasureClass molePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time per area")]
        public static MeasureClass MolePerTimePerArea
        {
            get 
            {
                if (molePerTimePerArea == null)
                {
                    molePerTimePerArea = new MeasureClass("mole per time per area");
                    molePerTimePerArea.MeasureRepresentativeUOM = "mol/m2.s";
                    molePerTimePerArea.MeasureBaseForConversion = "mol/m2.s";
                    molePerTimePerArea.MeasureUom = "lbmole/h.ft2";
                }
                return molePerTimePerArea;
            }
        }

        private static MeasureClass momentOfForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of force")]
        public static MeasureClass MomentOfForce
        {
            get 
            {
                if (momentOfForce == null)
                {
                    momentOfForce = new MeasureClass("moment of force");
                    momentOfForce.MeasureRepresentativeUOM = "J";
                    momentOfForce.MeasureBaseForConversion = "J";
                    momentOfForce.MeasureUom = "J";
                }
                return momentOfForce;
            }
        }

        private static MeasureClass momentOfInertia;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of inertia")]
        public static MeasureClass MomentOfInertia
        {
            get 
            {
                if (momentOfInertia == null)
                {
                    momentOfInertia = new MeasureClass("moment of inertia");
                    momentOfInertia.MeasureRepresentativeUOM = "kg.m2";
                    momentOfInertia.MeasureBaseForConversion = "kg.m2";
                    momentOfInertia.MeasureUom = "kg.m2";
                }
                return momentOfInertia;
            }
        }

        private static MeasureClass momentOfSection;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of section")]
        public static MeasureClass MomentOfSection
        {
            get 
            {
                if (momentOfSection == null)
                {
                    momentOfSection = new MeasureClass("moment of section");
                    momentOfSection.MeasureRepresentativeUOM = "m4";
                    momentOfSection.MeasureBaseForConversion = "m4";
                    momentOfSection.MeasureUom = "m4";
                }
                return momentOfSection;
            }
        }

        private static MeasureClass momentum;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("momentum")]
        public static MeasureClass Momentum
        {
            get 
            {
                if (momentum == null)
                {
                    momentum = new MeasureClass("momentum");
                    momentum.MeasureRepresentativeUOM = "kg.m/s";
                    momentum.MeasureBaseForConversion = "kg.m/s";
                    momentum.MeasureUom = "kg.m/s";
                }
                return momentum;
            }
        }

        private static MeasureClass neutronApiUnit;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("neutron API unit")]
        public static MeasureClass NeutronApiUnit
        {
            get 
            {
                if (neutronApiUnit == null)
                {
                    neutronApiUnit = new MeasureClass("neutron API unit");
                    neutronApiUnit.MeasureRepresentativeUOM = "nAPI";
                    neutronApiUnit.MeasureBaseForConversion = "nAPI";
                    neutronApiUnit.MeasureUom = "nAPI";
                }
                return neutronApiUnit;
            }
        }

        private static MeasureClass nondarcyFlowCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("nonDarcy flow coefficient")]
        public static MeasureClass NondarcyFlowCoefficient
        {
            get 
            {
                if (nondarcyFlowCoefficient == null)
                {
                    nondarcyFlowCoefficient = new MeasureClass("nonDarcy flow coefficient");
                    nondarcyFlowCoefficient.MeasureRepresentativeUOM = "Pa.s/m6";
                    nondarcyFlowCoefficient.MeasureBaseForConversion = "Pa.s/m6";
                    nondarcyFlowCoefficient.MeasureUom = "Pa.s/m6";
                }
                return nondarcyFlowCoefficient;
            }
        }

        private static MeasureClass operationsPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("operations per time")]
        public static MeasureClass OperationsPerTime
        {
            get 
            {
                if (operationsPerTime == null)
                {
                    operationsPerTime = new MeasureClass("operations per time");
                    operationsPerTime.MeasureRepresentativeUOM = "1/s";
                    operationsPerTime.MeasureBaseForConversion = "1/s";
                    operationsPerTime.MeasureUom = "1/s";
                }
                return operationsPerTime;
            }
        }

        private static MeasureClass parachor;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("parachor")]
        public static MeasureClass Parachor
        {
            get 
            {
                if (parachor == null)
                {
                    parachor = new MeasureClass("parachor");
                    parachor.MeasureRepresentativeUOM = "N4/kg.m7";
                    parachor.MeasureBaseForConversion = "N4/kg.m7";
                    parachor.MeasureUom = "(N/m)4/kg.m3";
                }
                return parachor;
            }
        }

        private static MeasureClass perArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per area")]
        public static MeasureClass PerArea
        {
            get 
            {
                if (perArea == null)
                {
                    perArea = new MeasureClass("per area");
                    perArea.MeasureRepresentativeUOM = "1/m2";
                    perArea.MeasureBaseForConversion = "1/m2";
                    perArea.MeasureUom = "1/ft2";
                }
                return perArea;
            }
        }

        private static MeasureClass perElectricPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per electric potential")]
        public static MeasureClass PerElectricPotential
        {
            get 
            {
                if (perElectricPotential == null)
                {
                    perElectricPotential = new MeasureClass("per electric potential");
                    perElectricPotential.MeasureRepresentativeUOM = "1/V";
                    perElectricPotential.MeasureBaseForConversion = "1/V";
                    perElectricPotential.MeasureUom = "1/V";
                }
                return perElectricPotential;
            }
        }

        private static MeasureClass perForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per force")]
        public static MeasureClass PerForce
        {
            get 
            {
                if (perForce == null)
                {
                    perForce = new MeasureClass("per force");
                    perForce.MeasureRepresentativeUOM = "1/N";
                    perForce.MeasureBaseForConversion = "1/N";
                    perForce.MeasureUom = "1/N";
                }
                return perForce;
            }
        }

        private static MeasureClass perLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per length")]
        public static MeasureClass PerLength
        {
            get 
            {
                if (perLength == null)
                {
                    perLength = new MeasureClass("per length");
                    perLength.MeasureRepresentativeUOM = "1/m";
                    perLength.MeasureBaseForConversion = "1/m";
                    perLength.MeasureUom = "1/angstrom";
                }
                return perLength;
            }
        }

        private static MeasureClass perMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per mass")]
        public static MeasureClass PerMass
        {
            get 
            {
                if (perMass == null)
                {
                    perMass = new MeasureClass("per mass");
                    perMass.MeasureRepresentativeUOM = "1/kg";
                    perMass.MeasureBaseForConversion = "1/kg";
                    perMass.MeasureUom = "1/g";
                }
                return perMass;
            }
        }

        private static MeasureClass perVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per volume")]
        public static MeasureClass PerVolume
        {
            get 
            {
                if (perVolume == null)
                {
                    perVolume = new MeasureClass("per volume");
                    perVolume.MeasureRepresentativeUOM = "1/m3";
                    perVolume.MeasureBaseForConversion = "1/m3";
                    perVolume.MeasureUom = "1/L";
                }
                return perVolume;
            }
        }

        private static MeasureClass permeabilityLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability length")]
        public static MeasureClass PermeabilityLength
        {
            get 
            {
                if (permeabilityLength == null)
                {
                    permeabilityLength = new MeasureClass("permeability length");
                    permeabilityLength.MeasureRepresentativeUOM = "D.ft";
                    permeabilityLength.MeasureBaseForConversion = "D.ft";
                    permeabilityLength.MeasureUom = "D.ft";
                }
                return permeabilityLength;
            }
        }

        private static MeasureClass permeabilityRock;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability rock")]
        public static MeasureClass PermeabilityRock
        {
            get 
            {
                if (permeabilityRock == null)
                {
                    permeabilityRock = new MeasureClass("permeability rock");
                    permeabilityRock.MeasureRepresentativeUOM = "D";
                    permeabilityRock.MeasureBaseForConversion = "D";
                    permeabilityRock.MeasureUom = "D";
                }
                return permeabilityRock;
            }
        }

        private static MeasureClass permeance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeance")]
        public static MeasureClass Permeance
        {
            get 
            {
                if (permeance == null)
                {
                    permeance = new MeasureClass("permeance");
                    permeance.MeasureRepresentativeUOM = "H";
                    permeance.MeasureBaseForConversion = "H";
                    permeance.MeasureUom = "H";
                }
                return permeance;
            }
        }

        private static MeasureClass permittivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permittivity")]
        public static MeasureClass Permittivity
        {
            get 
            {
                if (permittivity == null)
                {
                    permittivity = new MeasureClass("permittivity");
                    permittivity.MeasureRepresentativeUOM = "F/m";
                    permittivity.MeasureBaseForConversion = "F/m";
                    permittivity.MeasureUom = "F/m";
                }
                return permittivity;
            }
        }

        private static MeasureClass ph;
        /// <summary>
        /// The pH is a class that measures the hydrogen ion concentration (acidity).
        /// </summary>
        [EnumValueNameAttribute("pH")]
        public static MeasureClass Ph
        {
            get 
            {
                if (ph == null)
                {
                    ph = new MeasureClass("pH");
                    ph.MeasureRepresentativeUOM = "pH";
                    ph.MeasureBaseForConversion = "pH";
                    ph.MeasureUom = "pH";
                    ph.Description = "The pH is a class that measures the hydrogen ion concentration (acidity).";
                }
                return ph;
            }
        }

        private static MeasureClass planeAngle;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("plane angle")]
        public static MeasureClass PlaneAngle
        {
            get 
            {
                if (planeAngle == null)
                {
                    planeAngle = new MeasureClass("plane angle");
                    planeAngle.MeasureRepresentativeUOM = "rad";
                    planeAngle.MeasureBaseForConversion = "rad";
                    planeAngle.MeasureUom = "Grad";
                }
                return planeAngle;
            }
        }

        private static MeasureClass potentialDifferencePerPowerDrop;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("potential difference per power drop")]
        public static MeasureClass PotentialDifferencePerPowerDrop
        {
            get 
            {
                if (potentialDifferencePerPowerDrop == null)
                {
                    potentialDifferencePerPowerDrop = new MeasureClass("potential difference per power drop");
                    potentialDifferencePerPowerDrop.MeasureRepresentativeUOM = "V/B";
                    potentialDifferencePerPowerDrop.MeasureBaseForConversion = "V/B";
                    potentialDifferencePerPowerDrop.MeasureUom = "V/B";
                }
                return potentialDifferencePerPowerDrop;
            }
        }

        private static MeasureClass power;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power")]
        public static MeasureClass Power
        {
            get 
            {
                if (power == null)
                {
                    power = new MeasureClass("power");
                    power.MeasureRepresentativeUOM = "W";
                    power.MeasureBaseForConversion = "W";
                    power.MeasureUom = "CV";
                }
                return power;
            }
        }

        private static MeasureClass powerPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power per volume")]
        public static MeasureClass PowerPerVolume
        {
            get 
            {
                if (powerPerVolume == null)
                {
                    powerPerVolume = new MeasureClass("power per volume");
                    powerPerVolume.MeasureRepresentativeUOM = "W/m3";
                    powerPerVolume.MeasureBaseForConversion = "W/m3";
                    powerPerVolume.MeasureUom = "Btu/hr.ft3";
                }
                return powerPerVolume;
            }
        }

        private static MeasureClass pressure;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure")]
        public static MeasureClass Pressure
        {
            get 
            {
                if (pressure == null)
                {
                    pressure = new MeasureClass("pressure");
                    pressure.MeasureRepresentativeUOM = "Pa";
                    pressure.MeasureBaseForConversion = "Pa";
                    pressure.MeasureUom = "GPa";
                }
                return pressure;
            }
        }

        private static MeasureClass pressurePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure per time")]
        public static MeasureClass PressurePerTime
        {
            get 
            {
                if (pressurePerTime == null)
                {
                    pressurePerTime = new MeasureClass("pressure per time");
                    pressurePerTime.MeasureRepresentativeUOM = "Pa/s";
                    pressurePerTime.MeasureBaseForConversion = "Pa/s";
                    pressurePerTime.MeasureUom = "MPa/h";
                }
                return pressurePerTime;
            }
        }

        private static MeasureClass pressureSquared;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared")]
        public static MeasureClass PressureSquared
        {
            get 
            {
                if (pressureSquared == null)
                {
                    pressureSquared = new MeasureClass("pressure squared");
                    pressureSquared.MeasureRepresentativeUOM = "Pa2";
                    pressureSquared.MeasureBaseForConversion = "Pa2";
                    pressureSquared.MeasureUom = "GPa2";
                }
                return pressureSquared;
            }
        }

        private static MeasureClass pressureSquaredPerForceTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared per force time per area")]
        public static MeasureClass PressureSquaredPerForceTimePerArea
        {
            get 
            {
                if (pressureSquaredPerForceTimePerArea == null)
                {
                    pressureSquaredPerForceTimePerArea = new MeasureClass("pressure squared per force time per area");
                    pressureSquaredPerForceTimePerArea.MeasureRepresentativeUOM = "bar2/cP";
                    pressureSquaredPerForceTimePerArea.MeasureBaseForConversion = "Pa/s";
                    pressureSquaredPerForceTimePerArea.MeasureUom = "bar2/cP";
                }
                return pressureSquaredPerForceTimePerArea;
            }
        }

        private static MeasureClass pressureTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure time per volume")]
        public static MeasureClass PressureTimePerVolume
        {
            get 
            {
                if (pressureTimePerVolume == null)
                {
                    pressureTimePerVolume = new MeasureClass("pressure time per volume");
                    pressureTimePerVolume.MeasureRepresentativeUOM = "Pa.s/m3";
                    pressureTimePerVolume.MeasureBaseForConversion = "Pa.s/m3";
                    pressureTimePerVolume.MeasureUom = "Pa.s/m3";
                }
                return pressureTimePerVolume;
            }
        }

        private static MeasureClass productivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("productivity index")]
        public static MeasureClass ProductivityIndex
        {
            get 
            {
                if (productivityIndex == null)
                {
                    productivityIndex = new MeasureClass("productivity index");
                    productivityIndex.MeasureRepresentativeUOM = "m3/Pa.s";
                    productivityIndex.MeasureBaseForConversion = "m3/Pa.s";
                    productivityIndex.MeasureUom = "1000ft3/psi.d";
                }
                return productivityIndex;
            }
        }

        private static MeasureClass quantityOfLight;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("quantity of light")]
        public static MeasureClass QuantityOfLight
        {
            get 
            {
                if (quantityOfLight == null)
                {
                    quantityOfLight = new MeasureClass("quantity of light");
                    quantityOfLight.MeasureRepresentativeUOM = "lm.s";
                    quantityOfLight.MeasureBaseForConversion = "lm.s";
                    quantityOfLight.MeasureUom = "lm.s";
                }
                return quantityOfLight;
            }
        }

        private static MeasureClass radiance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiance")]
        public static MeasureClass Radiance
        {
            get 
            {
                if (radiance == null)
                {
                    radiance = new MeasureClass("radiance");
                    radiance.MeasureRepresentativeUOM = "W/m2.sr";
                    radiance.MeasureBaseForConversion = "W/m2.sr";
                    radiance.MeasureUom = "W/m2.sr";
                }
                return radiance;
            }
        }

        private static MeasureClass radiantIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiant intensity")]
        public static MeasureClass RadiantIntensity
        {
            get 
            {
                if (radiantIntensity == null)
                {
                    radiantIntensity = new MeasureClass("radiant intensity");
                    radiantIntensity.MeasureRepresentativeUOM = "W/sr";
                    radiantIntensity.MeasureBaseForConversion = "W/sr";
                    radiantIntensity.MeasureUom = "W/sr";
                }
                return radiantIntensity;
            }
        }

        private static MeasureClass relativePower;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("relative power")]
        public static MeasureClass RelativePower
        {
            get 
            {
                if (relativePower == null)
                {
                    relativePower = new MeasureClass("relative power");
                    relativePower.MeasureRepresentativeUOM = "Euc";
                    relativePower.MeasureBaseForConversion = "Euc";
                    relativePower.MeasureUom = "%";
                }
                return relativePower;
            }
        }

        private static MeasureClass relativeTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("relative time")]
        public static MeasureClass RelativeTime
        {
            get 
            {
                if (relativeTime == null)
                {
                    relativeTime = new MeasureClass("relative time");
                    relativeTime.MeasureRepresentativeUOM = "ms/s";
                    relativeTime.MeasureBaseForConversion = "ms/s";
                    relativeTime.MeasureUom = "ms/s";
                }
                return relativeTime;
            }
        }

        private static MeasureClass reluctance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("reluctance")]
        public static MeasureClass Reluctance
        {
            get 
            {
                if (reluctance == null)
                {
                    reluctance = new MeasureClass("reluctance");
                    reluctance.MeasureRepresentativeUOM = "1/H";
                    reluctance.MeasureBaseForConversion = "1/H";
                    reluctance.MeasureUom = "1/H";
                }
                return reluctance;
            }
        }

        private static MeasureClass resistance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistance")]
        public static MeasureClass Resistance
        {
            get 
            {
                if (resistance == null)
                {
                    resistance = new MeasureClass("resistance");
                    resistance.MeasureRepresentativeUOM = "ohm";
                    resistance.MeasureBaseForConversion = "ohm";
                    resistance.MeasureUom = "Gohm";
                }
                return resistance;
            }
        }

        private static MeasureClass resistivityPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistivity per length")]
        public static MeasureClass ResistivityPerLength
        {
            get 
            {
                if (resistivityPerLength == null)
                {
                    resistivityPerLength = new MeasureClass("resistivity per length");
                    resistivityPerLength.MeasureRepresentativeUOM = "ohm/m";
                    resistivityPerLength.MeasureBaseForConversion = "ohm/m";
                    resistivityPerLength.MeasureUom = "ohm/m";
                }
                return resistivityPerLength;
            }
        }

        private static MeasureClass secondMomentOfArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("second moment of area")]
        public static MeasureClass SecondMomentOfArea
        {
            get 
            {
                if (secondMomentOfArea == null)
                {
                    secondMomentOfArea = new MeasureClass("second moment of area");
                    secondMomentOfArea.MeasureRepresentativeUOM = "m4";
                    secondMomentOfArea.MeasureBaseForConversion = "m4";
                    secondMomentOfArea.MeasureUom = "cm4";
                }
                return secondMomentOfArea;
            }
        }

        private static MeasureClass solidAngle;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("solid angle")]
        public static MeasureClass SolidAngle
        {
            get 
            {
                if (solidAngle == null)
                {
                    solidAngle = new MeasureClass("solid angle");
                    solidAngle.MeasureRepresentativeUOM = "sr";
                    solidAngle.MeasureBaseForConversion = "sr";
                    solidAngle.MeasureUom = "sr";
                }
                return solidAngle;
            }
        }

        private static MeasureClass specificActivityOfRadioactivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific activity (of radioactivity)")]
        public static MeasureClass SpecificActivityOfRadioactivity
        {
            get 
            {
                if (specificActivityOfRadioactivity == null)
                {
                    specificActivityOfRadioactivity = new MeasureClass("specific activity (of radioactivity)");
                    specificActivityOfRadioactivity.MeasureRepresentativeUOM = "Bq/kg";
                    specificActivityOfRadioactivity.MeasureBaseForConversion = "Bq/kg";
                    specificActivityOfRadioactivity.MeasureUom = "Bq/kg";
                }
                return specificActivityOfRadioactivity;
            }
        }

        private static MeasureClass specificEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific energy")]
        public static MeasureClass SpecificEnergy
        {
            get 
            {
                if (specificEnergy == null)
                {
                    specificEnergy = new MeasureClass("specific energy");
                    specificEnergy.MeasureRepresentativeUOM = "J/kg";
                    specificEnergy.MeasureBaseForConversion = "J/kg";
                    specificEnergy.MeasureUom = "Btu/lbm";
                }
                return specificEnergy;
            }
        }

        private static MeasureClass specificHeatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific heat capacity")]
        public static MeasureClass SpecificHeatCapacity
        {
            get 
            {
                if (specificHeatCapacity == null)
                {
                    specificHeatCapacity = new MeasureClass("specific heat capacity");
                    specificHeatCapacity.MeasureRepresentativeUOM = "J/kg.K";
                    specificHeatCapacity.MeasureBaseForConversion = "J/kg.K";
                    specificHeatCapacity.MeasureUom = "Btu/lbm.degF";
                }
                return specificHeatCapacity;
            }
        }

        private static MeasureClass specificProductivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific productivity index")]
        public static MeasureClass SpecificProductivityIndex
        {
            get 
            {
                if (specificProductivityIndex == null)
                {
                    specificProductivityIndex = new MeasureClass("specific productivity index");
                    specificProductivityIndex.MeasureRepresentativeUOM = "m3/Pa2.s2";
                    specificProductivityIndex.MeasureBaseForConversion = "m3/Pa2.s2";
                    specificProductivityIndex.MeasureUom = "bbl/cP.d.psi";
                }
                return specificProductivityIndex;
            }
        }

        private static MeasureClass specificVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific volume")]
        public static MeasureClass SpecificVolume
        {
            get 
            {
                if (specificVolume == null)
                {
                    specificVolume = new MeasureClass("specific volume");
                    specificVolume.MeasureRepresentativeUOM = "m3/kg";
                    specificVolume.MeasureBaseForConversion = "m3/kg";
                    specificVolume.MeasureUom = "L/100kg";
                }
                return specificVolume;
            }
        }

        private static MeasureClass standardVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume")]
        public static MeasureClass StandardVolume
        {
            get 
            {
                if (standardVolume == null)
                {
                    standardVolume = new MeasureClass("standard volume");
                    standardVolume.MeasureRepresentativeUOM = "scm(15C)";
                    standardVolume.MeasureBaseForConversion = "scm(15C)";
                    standardVolume.MeasureUom = "Gsm3";
                }
                return standardVolume;
            }
        }

        private static MeasureClass standardVolumePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume per area")]
        public static MeasureClass StandardVolumePerArea
        {
            get 
            {
                if (standardVolumePerArea == null)
                {
                    standardVolumePerArea = new MeasureClass("standard volume per area");
                    standardVolumePerArea.MeasureRepresentativeUOM = "scm(15C)/m2";
                    standardVolumePerArea.MeasureBaseForConversion = "scm(15C)/m2";
                    standardVolumePerArea.MeasureUom = "MMstb/acre";
                }
                return standardVolumePerArea;
            }
        }

        private static MeasureClass standardVolumePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume per time")]
        public static MeasureClass StandardVolumePerTime
        {
            get 
            {
                if (standardVolumePerTime == null)
                {
                    standardVolumePerTime = new MeasureClass("standard volume per time");
                    standardVolumePerTime.MeasureRepresentativeUOM = "scm(15C)/s";
                    standardVolumePerTime.MeasureBaseForConversion = "scm(15C)/s";
                    standardVolumePerTime.MeasureUom = "MMscf(60F)/d";
                }
                return standardVolumePerTime;
            }
        }

        private static MeasureClass standardVolumePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume per volume")]
        public static MeasureClass StandardVolumePerVolume
        {
            get 
            {
                if (standardVolumePerVolume == null)
                {
                    standardVolumePerVolume = new MeasureClass("standard volume per volume");
                    standardVolumePerVolume.MeasureRepresentativeUOM = "scm(0C)/m3";
                    standardVolumePerVolume.MeasureBaseForConversion = "scm(0C)/m3";
                    standardVolumePerVolume.MeasureUom = "MMstb/acre.ft";
                }
                return standardVolumePerVolume;
            }
        }

        private static MeasureClass surfaceDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("surface density")]
        public static MeasureClass SurfaceDensity
        {
            get 
            {
                if (surfaceDensity == null)
                {
                    surfaceDensity = new MeasureClass("surface density");
                    surfaceDensity.MeasureRepresentativeUOM = "kg/m2";
                    surfaceDensity.MeasureBaseForConversion = "kg/m2";
                    surfaceDensity.MeasureUom = "Mg/m2";
                }
                return surfaceDensity;
            }
        }

        private static MeasureClass temperaturePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per length")]
        public static MeasureClass TemperaturePerLength
        {
            get 
            {
                if (temperaturePerLength == null)
                {
                    temperaturePerLength = new MeasureClass("temperature per length");
                    temperaturePerLength.MeasureRepresentativeUOM = "K/m";
                    temperaturePerLength.MeasureBaseForConversion = "K/m";
                    temperaturePerLength.MeasureUom = "K/m";
                }
                return temperaturePerLength;
            }
        }

        private static MeasureClass temperaturePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per time")]
        public static MeasureClass TemperaturePerTime
        {
            get 
            {
                if (temperaturePerTime == null)
                {
                    temperaturePerTime = new MeasureClass("temperature per time");
                    temperaturePerTime.MeasureRepresentativeUOM = "K/s";
                    temperaturePerTime.MeasureBaseForConversion = "K/s";
                    temperaturePerTime.MeasureUom = "K/s";
                }
                return temperaturePerTime;
            }
        }

        private static MeasureClass thermalConductance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductance")]
        public static MeasureClass ThermalConductance
        {
            get 
            {
                if (thermalConductance == null)
                {
                    thermalConductance = new MeasureClass("thermal conductance");
                    thermalConductance.MeasureRepresentativeUOM = "W/K";
                    thermalConductance.MeasureBaseForConversion = "W/K";
                    thermalConductance.MeasureUom = "W/K";
                }
                return thermalConductance;
            }
        }

        private static MeasureClass thermalConductivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductivity")]
        public static MeasureClass ThermalConductivity
        {
            get 
            {
                if (thermalConductivity == null)
                {
                    thermalConductivity = new MeasureClass("thermal conductivity");
                    thermalConductivity.MeasureRepresentativeUOM = "W/m.K";
                    thermalConductivity.MeasureBaseForConversion = "W/m.K";
                    thermalConductivity.MeasureUom = "Btu/hr.ft.degF";
                }
                return thermalConductivity;
            }
        }

        private static MeasureClass thermalDiffusivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal diffusivity")]
        public static MeasureClass ThermalDiffusivity
        {
            get 
            {
                if (thermalDiffusivity == null)
                {
                    thermalDiffusivity = new MeasureClass("thermal diffusivity");
                    thermalDiffusivity.MeasureRepresentativeUOM = "m2/s";
                    thermalDiffusivity.MeasureBaseForConversion = "m2/s";
                    thermalDiffusivity.MeasureUom = "cm2/s";
                }
                return thermalDiffusivity;
            }
        }

        private static MeasureClass thermalInsulance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal insulance")]
        public static MeasureClass ThermalInsulance
        {
            get 
            {
                if (thermalInsulance == null)
                {
                    thermalInsulance = new MeasureClass("thermal insulance");
                    thermalInsulance.MeasureRepresentativeUOM = "K.m2/W";
                    thermalInsulance.MeasureBaseForConversion = "K.m2/W";
                    thermalInsulance.MeasureUom = "K.m2/W";
                }
                return thermalInsulance;
            }
        }

        private static MeasureClass thermalResistance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal resistance")]
        public static MeasureClass ThermalResistance
        {
            get 
            {
                if (thermalResistance == null)
                {
                    thermalResistance = new MeasureClass("thermal resistance");
                    thermalResistance.MeasureRepresentativeUOM = "K/W";
                    thermalResistance.MeasureBaseForConversion = "K/W";
                    thermalResistance.MeasureUom = "K/W";
                }
                return thermalResistance;
            }
        }

        private static MeasureClass thermodynamicTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermodynamic temperature")]
        public static MeasureClass ThermodynamicTemperature
        {
            get 
            {
                if (thermodynamicTemperature == null)
                {
                    thermodynamicTemperature = new MeasureClass("thermodynamic temperature");
                    thermodynamicTemperature.MeasureRepresentativeUOM = "K";
                    thermodynamicTemperature.MeasureBaseForConversion = "K";
                    thermodynamicTemperature.MeasureUom = "K";
                }
                return thermodynamicTemperature;
            }
        }

        private static MeasureClass time;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time")]
        public static MeasureClass Time
        {
            get 
            {
                if (time == null)
                {
                    time = new MeasureClass("time");
                    time.MeasureRepresentativeUOM = "s";
                    time.MeasureBaseForConversion = "s";
                    time.MeasureUom = "100ka";
                }
                return time;
            }
        }

        private static MeasureClass timePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per length")]
        public static MeasureClass TimePerLength
        {
            get 
            {
                if (timePerLength == null)
                {
                    timePerLength = new MeasureClass("time per length");
                    timePerLength.MeasureRepresentativeUOM = "s/m";
                    timePerLength.MeasureBaseForConversion = "s/m";
                    timePerLength.MeasureUom = "h/kft";
                }
                return timePerLength;
            }
        }

        private static MeasureClass timePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per volume")]
        public static MeasureClass TimePerVolume
        {
            get 
            {
                if (timePerVolume == null)
                {
                    timePerVolume = new MeasureClass("time per volume");
                    timePerVolume.MeasureRepresentativeUOM = "s/m3";
                    timePerVolume.MeasureBaseForConversion = "s/m3";
                    timePerVolume.MeasureUom = "d/bbl";
                }
                return timePerVolume;
            }
        }

        private static MeasureClass unitProductivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("unit productivity index")]
        public static MeasureClass UnitProductivityIndex
        {
            get 
            {
                if (unitProductivityIndex == null)
                {
                    unitProductivityIndex = new MeasureClass("unit productivity index");
                    unitProductivityIndex.MeasureRepresentativeUOM = "m2/Pa.s";
                    unitProductivityIndex.MeasureBaseForConversion = "m2/Pa.s";
                    unitProductivityIndex.MeasureUom = "bbl/d.ft.psi";
                }
                return unitProductivityIndex;
            }
        }

        private static MeasureClass velocity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("velocity")]
        public static MeasureClass Velocity
        {
            get 
            {
                if (velocity == null)
                {
                    velocity = new MeasureClass("velocity");
                    velocity.MeasureRepresentativeUOM = "m/s";
                    velocity.MeasureBaseForConversion = "m/s";
                    velocity.MeasureUom = "cm/a";
                }
                return velocity;
            }
        }

        private static MeasureClass volume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume")]
        public static MeasureClass Volume
        {
            get 
            {
                if (volume == null)
                {
                    volume = new MeasureClass("volume");
                    volume.MeasureRepresentativeUOM = "m3";
                    volume.MeasureBaseForConversion = "m3";
                    volume.MeasureUom = "1000ft3";
                }
                return volume;
            }
        }

        private static MeasureClass volumeFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume flow rate")]
        public static MeasureClass VolumeFlowRate
        {
            get 
            {
                if (volumeFlowRate == null)
                {
                    volumeFlowRate = new MeasureClass("volume flow rate");
                    volumeFlowRate.MeasureRepresentativeUOM = "m3/s";
                    volumeFlowRate.MeasureBaseForConversion = "m3/s";
                    volumeFlowRate.MeasureUom = "1000ft3/d";
                }
                return volumeFlowRate;
            }
        }

        private static MeasureClass volumeLengthPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume length per time")]
        public static MeasureClass VolumeLengthPerTime
        {
            get 
            {
                if (volumeLengthPerTime == null)
                {
                    volumeLengthPerTime = new MeasureClass("volume length per time");
                    volumeLengthPerTime.MeasureRepresentativeUOM = "m4/s";
                    volumeLengthPerTime.MeasureBaseForConversion = "m4/s";
                    volumeLengthPerTime.MeasureUom = "1000m4/d";
                }
                return volumeLengthPerTime;
            }
        }

        private static MeasureClass volumePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per area")]
        public static MeasureClass VolumePerArea
        {
            get 
            {
                if (volumePerArea == null)
                {
                    volumePerArea = new MeasureClass("volume per area");
                    volumePerArea.MeasureRepresentativeUOM = "m3/m2";
                    volumePerArea.MeasureBaseForConversion = "m";
                    volumePerArea.MeasureUom = "bbl/acre";
                }
                return volumePerArea;
            }
        }

        private static MeasureClass volumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per length")]
        public static MeasureClass VolumePerLength
        {
            get 
            {
                if (volumePerLength == null)
                {
                    volumePerLength = new MeasureClass("volume per length");
                    volumePerLength.MeasureRepresentativeUOM = "m3/m";
                    volumePerLength.MeasureBaseForConversion = "m2";
                    volumePerLength.MeasureUom = "L/100km";
                }
                return volumePerLength;
            }
        }

        private static MeasureClass volumePerStandardVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per standard volume")]
        public static MeasureClass VolumePerStandardVolume
        {
            get 
            {
                if (volumePerStandardVolume == null)
                {
                    volumePerStandardVolume = new MeasureClass("volume per standard volume");
                    volumePerStandardVolume.MeasureRepresentativeUOM = "m3/scm(15C)";
                    volumePerStandardVolume.MeasureBaseForConversion = "m3/scm(15C)";
                    volumePerStandardVolume.MeasureUom = "acre.ft/MMstb";
                }
                return volumePerStandardVolume;
            }
        }

        private static MeasureClass volumePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per area")]
        public static MeasureClass VolumePerTimePerArea
        {
            get 
            {
                if (volumePerTimePerArea == null)
                {
                    volumePerTimePerArea = new MeasureClass("volume per time per area");
                    volumePerTimePerArea.MeasureRepresentativeUOM = "ft3/min.ft2";
                    volumePerTimePerArea.MeasureBaseForConversion = "ft3/min.ft2";
                    volumePerTimePerArea.MeasureUom = "ft3/min.ft2";
                }
                return volumePerTimePerArea;
            }
        }

        private static MeasureClass volumePerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per length")]
        public static MeasureClass VolumePerTimePerLength
        {
            get 
            {
                if (volumePerTimePerLength == null)
                {
                    volumePerTimePerLength = new MeasureClass("volume per time per length");
                    volumePerTimePerLength.MeasureRepresentativeUOM = "bbl/d.ft";
                    volumePerTimePerLength.MeasureBaseForConversion = "bbl/d.ft";
                    volumePerTimePerLength.MeasureUom = "1000ft3/d.ft";
                }
                return volumePerTimePerLength;
            }
        }

        private static MeasureClass volumePerTimePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per time")]
        public static MeasureClass VolumePerTimePerTime
        {
            get 
            {
                if (volumePerTimePerTime == null)
                {
                    volumePerTimePerTime = new MeasureClass("volume per time per time");
                    volumePerTimePerTime.MeasureRepresentativeUOM = "m3/s2";
                    volumePerTimePerTime.MeasureBaseForConversion = "m3/s2";
                    volumePerTimePerTime.MeasureUom = "L/s2";
                }
                return volumePerTimePerTime;
            }
        }

        private static MeasureClass volumePerTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per volume")]
        public static MeasureClass VolumePerTimePerVolume
        {
            get 
            {
                if (volumePerTimePerVolume == null)
                {
                    volumePerTimePerVolume = new MeasureClass("volume per time per volume");
                    volumePerTimePerVolume.MeasureRepresentativeUOM = "bbl/d.acre.ft";
                    volumePerTimePerVolume.MeasureBaseForConversion = "bbl/d.acre.ft";
                    volumePerTimePerVolume.MeasureUom = "bbl/d.acre.ft";
                }
                return volumePerTimePerVolume;
            }
        }

        private static MeasureClass volumePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per volume")]
        public static MeasureClass VolumePerVolume
        {
            get 
            {
                if (volumePerVolume == null)
                {
                    volumePerVolume = new MeasureClass("volume per volume");
                    volumePerVolume.MeasureRepresentativeUOM = "Euc";
                    volumePerVolume.MeasureBaseForConversion = "Euc";
                    volumePerVolume.MeasureUom = "%";
                }
                return volumePerVolume;
            }
        }

        private static MeasureClass volumetricHeatTransferCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric heat transfer coefficient")]
        public static MeasureClass VolumetricHeatTransferCoefficient
        {
            get 
            {
                if (volumetricHeatTransferCoefficient == null)
                {
                    volumetricHeatTransferCoefficient = new MeasureClass("volumetric heat transfer coefficient");
                    volumetricHeatTransferCoefficient.MeasureRepresentativeUOM = "W/m3.K";
                    volumetricHeatTransferCoefficient.MeasureBaseForConversion = "W/m3.K";
                    volumetricHeatTransferCoefficient.MeasureUom = "Btu/hr.ft3.degF";
                }
                return volumetricHeatTransferCoefficient;
            }
        }

        private static MeasureClass volumetricThermalExpansion;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric thermal expansion")]
        public static MeasureClass VolumetricThermalExpansion
        {
            get 
            {
                if (volumetricThermalExpansion == null)
                {
                    volumetricThermalExpansion = new MeasureClass("volumetric thermal expansion");
                    volumetricThermalExpansion.MeasureRepresentativeUOM = "1/K";
                    volumetricThermalExpansion.MeasureBaseForConversion = "1/K";
                    volumetricThermalExpansion.MeasureUom = "1/K";
                }
                return volumetricThermalExpansion;
            }
        }

        private static MeasureClass work;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static MeasureClass Work
        {
            get 
            {
                if (work == null)
                {
                    work = new MeasureClass("work");
                    work.MeasureRepresentativeUOM = "J";
                    work.MeasureBaseForConversion = "J";
                    work.MeasureUom = "Btu";
                }
                return work;
            }
        }

        private static MeasureClass unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static MeasureClass Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new MeasureClass("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines the locations where an equipment tag might be found.
    /// </summary>
    public class NameTagLocation : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected NameTagLocation(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the NameTagLocation</param>
        public NameTagLocation(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of NameTagLocations
        /// </summary>
        /// <returns>The complete list of NameTagLocations</returns>
        public static List<NameTagLocation> GetList()
        {
            return GetList<NameTagLocation>();
        }

        private static NameTagLocation body;
        /// <summary>
        /// The body of the equipment. For tubular components this specifies a location toward the middle of the component. 
        /// </summary>
        [EnumValueNameAttribute("body")]
        public static NameTagLocation Body
        {
            get 
            {
                if (body == null)
                {
                    body = new NameTagLocation("body");
                    body.Description = "The body of the equipment. For tubular components this specifies a location toward the middle of the component. ";
                }
                return body;
            }
        }

        private static NameTagLocation box;
        /// <summary>
        /// The female threaded end of a device.
        /// </summary>
        [EnumValueNameAttribute("box")]
        public static NameTagLocation Box
        {
            get 
            {
                if (box == null)
                {
                    box = new NameTagLocation("box");
                    box.Description = "The female threaded end of a device.";
                }
                return box;
            }
        }

        private static NameTagLocation pin;
        /// <summary>
        /// The male threaded end of a device.
        /// </summary>
        [EnumValueNameAttribute("pin")]
        public static NameTagLocation Pin
        {
            get 
            {
                if (pin == null)
                {
                    pin = new NameTagLocation("pin");
                    pin.Description = "The male threaded end of a device.";
                }
                return pin;
            }
        }

        private static NameTagLocation other;
        /// <summary>
        /// This, by exclusion, tells a user to look elsewhere than on the body or near the ends of a component.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static NameTagLocation Other
        {
            get 
            {
                if (other == null)
                {
                    other = new NameTagLocation("other");
                    other.Description = "This, by exclusion, tells a user to look elsewhere than on the body or near the ends of a component.";
                }
                return other;
            }
        }

        private static NameTagLocation unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static NameTagLocation Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new NameTagLocation("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. ";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines the specifications for creating equipment tags.
    /// </summary>
    public class NameTagNumberingScheme : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected NameTagNumberingScheme(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the NameTagNumberingScheme</param>
        public NameTagNumberingScheme(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of NameTagNumberingSchemes
        /// </summary>
        /// <returns>The complete list of NameTagNumberingSchemes</returns>
        public static List<NameTagNumberingScheme> GetList()
        {
            return GetList<NameTagNumberingScheme>();
        }

        private static NameTagNumberingScheme epcSixFour;
        /// <summary>
        /// RFID - Electronic Product Code, 64 bit.
        /// </summary>
        [EnumValueNameAttribute("EPC64")]
        public static NameTagNumberingScheme EpcSixFour
        {
            get 
            {
                if (epcSixFour == null)
                {
                    epcSixFour = new NameTagNumberingScheme("EPC64");
                    epcSixFour.Description = "RFID - Electronic Product Code, 64 bit.";
                }
                return epcSixFour;
            }
        }

        private static NameTagNumberingScheme epcNineSix;
        /// <summary>
        /// RFID - Electronic Product Code, 96 bit.
        /// </summary>
        [EnumValueNameAttribute("EPC96")]
        public static NameTagNumberingScheme EpcNineSix
        {
            get 
            {
                if (epcNineSix == null)
                {
                    epcNineSix = new NameTagNumberingScheme("EPC96");
                    epcNineSix.Description = "RFID - Electronic Product Code, 96 bit.";
                }
                return epcNineSix;
            }
        }

        private static NameTagNumberingScheme msrcid;
        /// <summary>
        /// RFID - Merrick Systems Rapid Component Identification.
        /// </summary>
        [EnumValueNameAttribute("MSRCID")]
        public static NameTagNumberingScheme Msrcid
        {
            get 
            {
                if (msrcid == null)
                {
                    msrcid = new NameTagNumberingScheme("MSRCID");
                    msrcid.Description = "RFID - Merrick Systems Rapid Component Identification.";
                }
                return msrcid;
            }
        }

        private static NameTagNumberingScheme ansiaimbcTwo;
        /// <summary>
        /// Barcode - 1995, Uniform Symbology Specification
        /// </summary>
        [EnumValueNameAttribute("ANSI/AIM-BC2")]
        public static NameTagNumberingScheme AnsiaimbcTwo
        {
            get 
            {
                if (ansiaimbcTwo == null)
                {
                    ansiaimbcTwo = new NameTagNumberingScheme("ANSI/AIM-BC2");
                    ansiaimbcTwo.Description = "Barcode - 1995, Uniform Symbology Specification";
                }
                return ansiaimbcTwo;
            }
        }

        private static NameTagNumberingScheme ansiaimbcSix;
        /// <summary>
        /// Barcode - 1995, Uniform Symbology Multi Row Specification
        /// </summary>
        [EnumValueNameAttribute("ANSI/AIM-BC6")]
        public static NameTagNumberingScheme AnsiaimbcSix
        {
            get 
            {
                if (ansiaimbcSix == null)
                {
                    ansiaimbcSix = new NameTagNumberingScheme("ANSI/AIM-BC6");
                    ansiaimbcSix.Description = "Barcode - 1995, Uniform Symbology Multi Row Specification";
                }
                return ansiaimbcSix;
            }
        }

        private static NameTagNumberingScheme ansiaimbcOneZero;
        /// <summary>
        /// Barcode - 1996, International Symbology Specification - MaxiCode
        /// </summary>
        [EnumValueNameAttribute("ANSI/AIM-BC10")]
        public static NameTagNumberingScheme AnsiaimbcOneZero
        {
            get 
            {
                if (ansiaimbcOneZero == null)
                {
                    ansiaimbcOneZero = new NameTagNumberingScheme("ANSI/AIM-BC10");
                    ansiaimbcOneZero.Description = "Barcode - 1996, International Symbology Specification - MaxiCode";
                }
                return ansiaimbcOneZero;
            }
        }

        private static NameTagNumberingScheme eanucc;
        /// <summary>
        /// Barcode - Composite Symbology
        /// </summary>
        [EnumValueNameAttribute("EAN.UCC")]
        public static NameTagNumberingScheme Eanucc
        {
            get 
            {
                if (eanucc == null)
                {
                    eanucc = new NameTagNumberingScheme("EAN.UCC");
                    eanucc.Description = "Barcode - Composite Symbology";
                }
                return eanucc;
            }
        }

        private static NameTagNumberingScheme fTwof;
        /// <summary>
        /// Magnetic - ISO/IEC 7811
        /// </summary>
        [EnumValueNameAttribute("F2F")]
        public static NameTagNumberingScheme FTwof
        {
            get 
            {
                if (fTwof == null)
                {
                    fTwof = new NameTagNumberingScheme("F2F");
                    fTwof.Description = "Magnetic - ISO/IEC 7811";
                }
                return fTwof;
            }
        }

        private static NameTagNumberingScheme mfm;
        /// <summary>
        /// Magnetic - 'Modified Frequency Modulation for Magnetic Stripes' standard developed by AIM Inc.
        /// </summary>
        [EnumValueNameAttribute("MFM")]
        public static NameTagNumberingScheme Mfm
        {
            get 
            {
                if (mfm == null)
                {
                    mfm = new NameTagNumberingScheme("MFM");
                    mfm.Description = "Magnetic - 'Modified Frequency Modulation for Magnetic Stripes' standard developed by AIM Inc.";
                }
                return mfm;
            }
        }

        private static NameTagNumberingScheme serialNumber;
        /// <summary>
        /// Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the 'tag'. 
        /// </summary>
        [EnumValueNameAttribute("serial number")]
        public static NameTagNumberingScheme SerialNumber
        {
            get 
            {
                if (serialNumber == null)
                {
                    serialNumber = new NameTagNumberingScheme("serial number");
                    serialNumber.Description = "Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the 'tag'. ";
                }
                return serialNumber;
            }
        }

        private static NameTagNumberingScheme unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static NameTagNumberingScheme Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new NameTagNumberingScheme("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. ";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines the mechanisms for attaching an equipment tag to an item.
    /// </summary>
    public class NameTagTechnology : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected NameTagTechnology(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the NameTagTechnology</param>
        public NameTagTechnology(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of NameTagTechnologys
        /// </summary>
        /// <returns>The complete list of NameTagTechnologys</returns>
        public static List<NameTagTechnology> GetList()
        {
            return GetList<NameTagTechnology>();
        }

        private static NameTagTechnology tagged;
        /// <summary>
        /// Independent identification components attached or embedded to a larger component for purposes of identification of the larger component. Tags typically use electronic, radio or sound based technologies and that require a special non-optical device to read them. Radio Frequency Identification (RFID tags) are of this type, as are some magnetic and sound based identification technologies. 
        /// </summary>
        [EnumValueNameAttribute("tagged")]
        public static NameTagTechnology Tagged
        {
            get 
            {
                if (tagged == null)
                {
                    tagged = new NameTagTechnology("tagged");
                    tagged.Description = "Independent identification components attached or embedded to a larger component for purposes of identification of the larger component. Tags typically use electronic, radio or sound based technologies and that require a special non-optical device to read them. Radio Frequency Identification (RFID tags) are of this type, as are some magnetic and sound based identification technologies. ";
                }
                return tagged;
            }
        }

        private static NameTagTechnology labeled;
        /// <summary>
        /// An optical label attached to a component. The label may be glued, riveted or attached by some other method and may contain a serial number, barcode or other optically recognized information. Note that a label may possibly have a combination of identifiers associated with it, such as a serial number, a barcode and an embedded RFID identifier. This would generate three nameTags for the one physical label, two of type 'label' for the barcode and serial number and one of type 'tagged' for the RFID identifier. 
        /// </summary>
        [EnumValueNameAttribute("labeled")]
        public static NameTagTechnology Labeled
        {
            get 
            {
                if (labeled == null)
                {
                    labeled = new NameTagTechnology("labeled");
                    labeled.Description = "An optical label attached to a component. The label may be glued, riveted or attached by some other method and may contain a serial number, barcode or other optically recognized information. Note that a label may possibly have a combination of identifiers associated with it, such as a serial number, a barcode and an embedded RFID identifier. This would generate three nameTags for the one physical label, two of type 'label' for the barcode and serial number and one of type 'tagged' for the RFID identifier. ";
                }
                return labeled;
            }
        }

        private static NameTagTechnology intrinsic;
        /// <summary>
        /// Identification technologies where the intrinsic properties of the component to be identified contain the identification information and no other unique code has been added. For example, some magnetic identification technologies use grooves machined into a component. Some components may also be identified, for example, by their individual sonic signature or optical profile. 
        /// </summary>
        [EnumValueNameAttribute("intrinsic")]
        public static NameTagTechnology Intrinsic
        {
            get 
            {
                if (intrinsic == null)
                {
                    intrinsic = new NameTagTechnology("intrinsic");
                    intrinsic.Description = "Identification technologies where the intrinsic properties of the component to be identified contain the identification information and no other unique code has been added. For example, some magnetic identification technologies use grooves machined into a component. Some components may also be identified, for example, by their individual sonic signature or optical profile. ";
                }
                return intrinsic;
            }
        }

        private static NameTagTechnology stamped;
        /// <summary>
        /// An identification code physically stamped into the base material of the component to be identified. Note that if a serial number is stamped into a label attached to a component, 'labeled' should be used and not 'stamped'. Stamped identifiers can wear off but can not fall off. 
        /// </summary>
        [EnumValueNameAttribute("stamped")]
        public static NameTagTechnology Stamped
        {
            get 
            {
                if (stamped == null)
                {
                    stamped = new NameTagTechnology("stamped");
                    stamped.Description = "An identification code physically stamped into the base material of the component to be identified. Note that if a serial number is stamped into a label attached to a component, 'labeled' should be used and not 'stamped'. Stamped identifiers can wear off but can not fall off. ";
                }
                return stamped;
            }
        }

        private static NameTagTechnology painted;
        /// <summary>
        /// Painted or stenciled on the material. 
        /// </summary>
        [EnumValueNameAttribute("painted")]
        public static NameTagTechnology Painted
        {
            get 
            {
                if (painted == null)
                {
                    painted = new NameTagTechnology("painted");
                    painted.Description = "Painted or stenciled on the material. ";
                }
                return painted;
            }
        }

        private static NameTagTechnology temporary;
        /// <summary>
        /// Temporary identification codes marked with grease pencil, chalk, or such.
        /// </summary>
        [EnumValueNameAttribute("temporary")]
        public static NameTagTechnology Temporary
        {
            get 
            {
                if (temporary == null)
                {
                    temporary = new NameTagTechnology("temporary");
                    temporary.Description = "Temporary identification codes marked with grease pencil, chalk, or such.";
                }
                return temporary;
            }
        }

        private static NameTagTechnology unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static NameTagTechnology Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new NameTagTechnology("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. ";
                }
                return unknown;
            }
        }

    }

}
