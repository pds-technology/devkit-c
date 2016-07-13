using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.PRODML131
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

        private readonly static ExtensionName dummyexamplestring;
        /// <summary>
        /// This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a string of maximum length of 64 characters which can be used in the commonData of any object. The semantics of the name would be defined in this description field.
        /// </summary>
        [EnumValueNameAttribute("dummy-example-string")]
        public static ExtensionName Dummyexamplestring
        {
            get 
            {
                return dummyexamplestring;
            }
        }

        private readonly static ExtensionName dummyexamplemeasure;
        /// <summary>
        /// This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a length measure which can only be specified in the commonData of the well and wellbore objects. The semantics of the name would be defined in this description field. The extensionMeasureClass constrains the allowed units of measure for each value. The extensionDataType value of double constrains the size of each value.
        /// </summary>
        [EnumValueNameAttribute("dummy-example-measure")]
        public static ExtensionName Dummyexamplemeasure
        {
            get 
            {
                return dummyexamplemeasure;
            }
        }

        private readonly static ExtensionName dummyexampledatetime;
        /// <summary>
        /// This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a dateTime value which can be specified anywhere in the tubular object. The semantics of the name would be defined in this description field.
        /// </summary>
        [EnumValueNameAttribute("dummy-example-dateTime")]
        public static ExtensionName Dummyexampledatetime
        {
            get 
            {
                return dummyexampledatetime;
            }
        }

        static ExtensionName()
        {
            dummyexamplestring = 
                new ExtensionName("dummy-example-string")
                {
                    ExtensionDataType = typeof(String)
                    ,ExtensionMaximumSize = 64
                    ,ExtensionPath = ".//commonData/extensionNameValue"
                    ,Description = "This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a string of maximum length of 64 characters which can be used in the commonData of any object. The semantics of the name would be defined in this description field."
            };
            dummyexamplemeasure = 
                new ExtensionName("dummy-example-measure")
                {
                    ExtensionDataType = typeof(Double)
                    ,ExtensionMeasureClass = "length"
                    ,ExtensionPath = "/well/commonData/extensionNameValue"
                    ,Description = "This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a length measure which can only be specified in the commonData of the well and wellbore objects. The semantics of the name would be defined in this description field. The extensionMeasureClass constrains the allowed units of measure for each value. The extensionDataType value of double constrains the size of each value."
            };
            dummyexampledatetime = 
                new ExtensionName("dummy-example-dateTime")
                {
                    ExtensionDataType = typeof(DateTime)
                    ,ExtensionPath = "/tubular//extensionNameValue"
                    ,Description = "This is an example for the purpose of demonstrating the capabilities. This name should not be used and can be removed from a production file. It describes a dateTime value which can be specified anywhere in the tubular object. The semantics of the name would be defined in this description field."
            };
        }

        /// <summary>
        /// Gets a ExtensionName by name
        /// </summary>
        /// <param name="name">The name of the ExtensionName to return</param>
        /// <returns>The ExtensionName represented by 'name'</returns>
        public static ExtensionName GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ExtensionName)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ExtensionName)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ExtensionName)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static MeasureClass absorbedDose;
        /// <summary>
        /// The amount of energy absorbed per mass.
        /// </summary>
        [EnumValueNameAttribute("absorbed dose")]
        public static MeasureClass AbsorbedDose
        {
            get 
            {
                return absorbedDose;
            }
        }

        private readonly static MeasureClass accelerationLinear;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("acceleration linear")]
        public static MeasureClass AccelerationLinear
        {
            get 
            {
                return accelerationLinear;
            }
        }

        private readonly static MeasureClass activityOfRadioactivity;
        /// <summary>
        /// A measure of the radiation being emitted.
        /// </summary>
        [EnumValueNameAttribute("activity (of radioactivity)")]
        public static MeasureClass ActivityOfRadioactivity
        {
            get 
            {
                return activityOfRadioactivity;
            }
        }

        private readonly static MeasureClass concentrationOfB;
        /// <summary>
        /// molar concentration of a substance
        /// </summary>
        [EnumValueNameAttribute("concentration of B")]
        public static MeasureClass ConcentrationOfB
        {
            get 
            {
                return concentrationOfB;
            }
        }

        private readonly static MeasureClass amountOfSubstance;
        /// <summary>
        /// molar amount of a substance
        /// </summary>
        [EnumValueNameAttribute("amount of substance")]
        public static MeasureClass AmountOfSubstance
        {
            get 
            {
                return amountOfSubstance;
            }
        }

        private readonly static MeasureClass anglePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per length")]
        public static MeasureClass AnglePerLength
        {
            get 
            {
                return anglePerLength;
            }
        }

        private readonly static MeasureClass anglePerTime;
        /// <summary>
        /// The angular velocity. The rate of change of an angle.
        /// </summary>
        [EnumValueNameAttribute("angle per time")]
        public static MeasureClass AnglePerTime
        {
            get 
            {
                return anglePerTime;
            }
        }

        private readonly static MeasureClass anglePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per volume")]
        public static MeasureClass AnglePerVolume
        {
            get 
            {
                return anglePerVolume;
            }
        }

        private readonly static MeasureClass angularAcceleration;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angular acceleration")]
        public static MeasureClass AngularAcceleration
        {
            get 
            {
                return angularAcceleration;
            }
        }

        private readonly static MeasureClass area;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area")]
        public static MeasureClass Area
        {
            get 
            {
                return area;
            }
        }

        private readonly static MeasureClass areaPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area per area")]
        public static MeasureClass AreaPerArea
        {
            get 
            {
                return areaPerArea;
            }
        }

        private readonly static MeasureClass areaPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area per volume")]
        public static MeasureClass AreaPerVolume
        {
            get 
            {
                return areaPerVolume;
            }
        }

        private readonly static MeasureClass attenuation;
        /// <summary>
        /// A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave.
        /// </summary>
        [EnumValueNameAttribute("attenuation")]
        public static MeasureClass Attenuation
        {
            get 
            {
                return attenuation;
            }
        }

        private readonly static MeasureClass attenuationPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("attenuation per length")]
        public static MeasureClass AttenuationPerLength
        {
            get 
            {
                return attenuationPerLength;
            }
        }

        private readonly static MeasureClass capacitance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("capacitance")]
        public static MeasureClass Capacitance
        {
            get 
            {
                return capacitance;
            }
        }

        private readonly static MeasureClass chargeDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("charge density")]
        public static MeasureClass ChargeDensity
        {
            get 
            {
                return chargeDensity;
            }
        }

        private readonly static MeasureClass chemicalPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("chemical potential")]
        public static MeasureClass ChemicalPotential
        {
            get 
            {
                return chemicalPotential;
            }
        }

        private readonly static MeasureClass compressibility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("compressibility")]
        public static MeasureClass Compressibility
        {
            get 
            {
                return compressibility;
            }
        }

        private readonly static MeasureClass conductivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("conductivity")]
        public static MeasureClass Conductivity
        {
            get 
            {
                return conductivity;
            }
        }

        private readonly static MeasureClass crossSectionAbsorption;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("cross section absorption")]
        public static MeasureClass CrossSectionAbsorption
        {
            get 
            {
                return crossSectionAbsorption;
            }
        }

        private readonly static MeasureClass currentDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("current density")]
        public static MeasureClass CurrentDensity
        {
            get 
            {
                return currentDensity;
            }
        }

        private readonly static MeasureClass darcyFlowCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Darcy flow coefficient")]
        public static MeasureClass DarcyFlowCoefficient
        {
            get 
            {
                return darcyFlowCoefficient;
            }
        }

        private readonly static MeasureClass dataTransmissionSpeed;
        /// <summary>
        /// used primarily for computer transmission rates.
        /// </summary>
        [EnumValueNameAttribute("data transmission speed")]
        public static MeasureClass DataTransmissionSpeed
        {
            get 
            {
                return dataTransmissionSpeed;
            }
        }

        private readonly static MeasureClass deltaTemperature;
        /// <summary>
        /// Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures.
        /// </summary>
        [EnumValueNameAttribute("delta temperature")]
        public static MeasureClass DeltaTemperature
        {
            get 
            {
                return deltaTemperature;
            }
        }

        private readonly static MeasureClass density;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static MeasureClass Density
        {
            get 
            {
                return density;
            }
        }

        private readonly static MeasureClass diffusionCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("diffusion coefficient")]
        public static MeasureClass DiffusionCoefficient
        {
            get 
            {
                return diffusionCoefficient;
            }
        }

        private readonly static MeasureClass digitalStorage;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("digital storage")]
        public static MeasureClass DigitalStorage
        {
            get 
            {
                return digitalStorage;
            }
        }

        private readonly static MeasureClass dimensionless;
        /// <summary>
        /// A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass.
        /// </summary>
        [EnumValueNameAttribute("dimensionless")]
        public static MeasureClass Dimensionless
        {
            get 
            {
                return dimensionless;
            }
        }

        private readonly static MeasureClass doseEquivalent;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent")]
        public static MeasureClass DoseEquivalent
        {
            get 
            {
                return doseEquivalent;
            }
        }

        private readonly static MeasureClass doseEquivalentRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent rate")]
        public static MeasureClass DoseEquivalentRate
        {
            get 
            {
                return doseEquivalentRate;
            }
        }

        private readonly static MeasureClass dynamicViscosity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dynamic viscosity")]
        public static MeasureClass DynamicViscosity
        {
            get 
            {
                return dynamicViscosity;
            }
        }

        private readonly static MeasureClass electricCharge;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric charge")]
        public static MeasureClass ElectricCharge
        {
            get 
            {
                return electricCharge;
            }
        }

        private readonly static MeasureClass electricConductance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric conductance")]
        public static MeasureClass ElectricConductance
        {
            get 
            {
                return electricConductance;
            }
        }

        private readonly static MeasureClass electricCurrent;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric current")]
        public static MeasureClass ElectricCurrent
        {
            get 
            {
                return electricCurrent;
            }
        }

        private readonly static MeasureClass electricDipoleMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric dipole moment")]
        public static MeasureClass ElectricDipoleMoment
        {
            get 
            {
                return electricDipoleMoment;
            }
        }

        private readonly static MeasureClass electricFieldStrength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric field strength")]
        public static MeasureClass ElectricFieldStrength
        {
            get 
            {
                return electricFieldStrength;
            }
        }

        private readonly static MeasureClass electricPolarization;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric polarization")]
        public static MeasureClass ElectricPolarization
        {
            get 
            {
                return electricPolarization;
            }
        }

        private readonly static MeasureClass electricPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric potential")]
        public static MeasureClass ElectricPotential
        {
            get 
            {
                return electricPotential;
            }
        }

        private readonly static MeasureClass electricalResistivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electrical resistivity")]
        public static MeasureClass ElectricalResistivity
        {
            get 
            {
                return electricalResistivity;
            }
        }

        private readonly static MeasureClass electrochemicalEquivalent;
        /// <summary>
        /// An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered.
        /// </summary>
        [EnumValueNameAttribute("electrochemical equivalent")]
        public static MeasureClass ElectrochemicalEquivalent
        {
            get 
            {
                return electrochemicalEquivalent;
            }
        }

        private readonly static MeasureClass electromagneticMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electromagnetic moment")]
        public static MeasureClass ElectromagneticMoment
        {
            get 
            {
                return electromagneticMoment;
            }
        }

        private readonly static MeasureClass energyLengthPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per area")]
        public static MeasureClass EnergyLengthPerArea
        {
            get 
            {
                return energyLengthPerArea;
            }
        }

        private readonly static MeasureClass energyLengthPerTimeAreaTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per time area temperature")]
        public static MeasureClass EnergyLengthPerTimeAreaTemperature
        {
            get 
            {
                return energyLengthPerTimeAreaTemperature;
            }
        }

        private readonly static MeasureClass energyPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per area")]
        public static MeasureClass EnergyPerArea
        {
            get 
            {
                return energyPerArea;
            }
        }

        private readonly static MeasureClass energyPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per length")]
        public static MeasureClass EnergyPerLength
        {
            get 
            {
                return energyPerLength;
            }
        }

        private readonly static MeasureClass equivalentPerMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per mass")]
        public static MeasureClass EquivalentPerMass
        {
            get 
            {
                return equivalentPerMass;
            }
        }

        private readonly static MeasureClass equivalentPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per volume")]
        public static MeasureClass EquivalentPerVolume
        {
            get 
            {
                return equivalentPerVolume;
            }
        }

        private readonly static MeasureClass exposureRadioactivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("exposure (radioactivity)")]
        public static MeasureClass ExposureRadioactivity
        {
            get 
            {
                return exposureRadioactivity;
            }
        }

        private readonly static MeasureClass force;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force")]
        public static MeasureClass Force
        {
            get 
            {
                return force;
            }
        }

        private readonly static MeasureClass forceArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force area")]
        public static MeasureClass ForceArea
        {
            get 
            {
                return forceArea;
            }
        }

        private readonly static MeasureClass forceLengthPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force length per length")]
        public static MeasureClass ForceLengthPerLength
        {
            get 
            {
                return forceLengthPerLength;
            }
        }

        private readonly static MeasureClass forcePerForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per force")]
        public static MeasureClass ForcePerForce
        {
            get 
            {
                return forcePerForce;
            }
        }

        private readonly static MeasureClass forcePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per length")]
        public static MeasureClass ForcePerLength
        {
            get 
            {
                return forcePerLength;
            }
        }

        private readonly static MeasureClass forcePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per volume")]
        public static MeasureClass ForcePerVolume
        {
            get 
            {
                return forcePerVolume;
            }
        }

        private readonly static MeasureClass frequency;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("frequency")]
        public static MeasureClass Frequency
        {
            get 
            {
                return frequency;
            }
        }

        private readonly static MeasureClass frequencyInterval;
        /// <summary>
        /// An octave is a doubling of a frquency.
        /// </summary>
        [EnumValueNameAttribute("frequency interval")]
        public static MeasureClass FrequencyInterval
        {
            get 
            {
                return frequencyInterval;
            }
        }

        private readonly static MeasureClass gammaRayApiUnit;
        /// <summary>
        /// This class is defined by the API, and is used for units of gamma ray log response.
        /// </summary>
        [EnumValueNameAttribute("gamma ray API unit")]
        public static MeasureClass GammaRayApiUnit
        {
            get 
            {
                return gammaRayApiUnit;
            }
        }

        private readonly static MeasureClass heatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat capacity")]
        public static MeasureClass HeatCapacity
        {
            get 
            {
                return heatCapacity;
            }
        }

        private readonly static MeasureClass heatFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat flow rate")]
        public static MeasureClass HeatFlowRate
        {
            get 
            {
                return heatFlowRate;
            }
        }

        private readonly static MeasureClass heatTransferCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat transfer coefficient")]
        public static MeasureClass HeatTransferCoefficient
        {
            get 
            {
                return heatTransferCoefficient;
            }
        }

        private readonly static MeasureClass illuminance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("illuminance")]
        public static MeasureClass Illuminance
        {
            get 
            {
                return illuminance;
            }
        }

        private readonly static MeasureClass irradiance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("irradiance")]
        public static MeasureClass Irradiance
        {
            get 
            {
                return irradiance;
            }
        }

        private readonly static MeasureClass isothermalCompressibility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("isothermal compressibility")]
        public static MeasureClass IsothermalCompressibility
        {
            get 
            {
                return isothermalCompressibility;
            }
        }

        private readonly static MeasureClass kinematicViscosity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kinematic viscosity")]
        public static MeasureClass KinematicViscosity
        {
            get 
            {
                return kinematicViscosity;
            }
        }

        private readonly static MeasureClass length;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length")]
        public static MeasureClass Length
        {
            get 
            {
                return length;
            }
        }

        private readonly static MeasureClass lengthPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per length")]
        public static MeasureClass LengthPerLength
        {
            get 
            {
                return lengthPerLength;
            }
        }

        private readonly static MeasureClass lengthPerTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per temperature")]
        public static MeasureClass LengthPerTemperature
        {
            get 
            {
                return lengthPerTemperature;
            }
        }

        private readonly static MeasureClass lengthPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per volume")]
        public static MeasureClass LengthPerVolume
        {
            get 
            {
                return lengthPerVolume;
            }
        }

        private readonly static MeasureClass levelOfPowerIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("level of power intensity")]
        public static MeasureClass LevelOfPowerIntensity
        {
            get 
            {
                return levelOfPowerIntensity;
            }
        }

        private readonly static MeasureClass lightExposure;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("light exposure")]
        public static MeasureClass LightExposure
        {
            get 
            {
                return lightExposure;
            }
        }

        private readonly static MeasureClass massPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per length")]
        public static MeasureClass MassPerLength
        {
            get 
            {
                return massPerLength;
            }
        }

        private readonly static MeasureClass linearThermalExpansion;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("linear thermal expansion")]
        public static MeasureClass LinearThermalExpansion
        {
            get 
            {
                return linearThermalExpansion;
            }
        }

        private readonly static MeasureClass luminance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminance")]
        public static MeasureClass Luminance
        {
            get 
            {
                return luminance;
            }
        }

        private readonly static MeasureClass luminousEfficacy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous efficacy")]
        public static MeasureClass LuminousEfficacy
        {
            get 
            {
                return luminousEfficacy;
            }
        }

        private readonly static MeasureClass luminousFlux;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous flux")]
        public static MeasureClass LuminousFlux
        {
            get 
            {
                return luminousFlux;
            }
        }

        private readonly static MeasureClass luminousIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous intensity")]
        public static MeasureClass LuminousIntensity
        {
            get 
            {
                return luminousIntensity;
            }
        }

        private readonly static MeasureClass magneticDipoleMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic dipole moment")]
        public static MeasureClass MagneticDipoleMoment
        {
            get 
            {
                return magneticDipoleMoment;
            }
        }

        private readonly static MeasureClass magneticFieldStrength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic field strength")]
        public static MeasureClass MagneticFieldStrength
        {
            get 
            {
                return magneticFieldStrength;
            }
        }

        private readonly static MeasureClass magneticFlux;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic flux")]
        public static MeasureClass MagneticFlux
        {
            get 
            {
                return magneticFlux;
            }
        }

        private readonly static MeasureClass magneticInduction;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic induction")]
        public static MeasureClass MagneticInduction
        {
            get 
            {
                return magneticInduction;
            }
        }

        private readonly static MeasureClass magneticPermeability;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic permeability")]
        public static MeasureClass MagneticPermeability
        {
            get 
            {
                return magneticPermeability;
            }
        }

        private readonly static MeasureClass magneticVectorPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic vector potential")]
        public static MeasureClass MagneticVectorPotential
        {
            get 
            {
                return magneticVectorPotential;
            }
        }

        private readonly static MeasureClass mass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass")]
        public static MeasureClass Mass
        {
            get 
            {
                return mass;
            }
        }

        private readonly static MeasureClass massAttenuationCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass attenuation coefficient")]
        public static MeasureClass MassAttenuationCoefficient
        {
            get 
            {
                return massAttenuationCoefficient;
            }
        }

        private readonly static MeasureClass massFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass flow rate")]
        public static MeasureClass MassFlowRate
        {
            get 
            {
                return massFlowRate;
            }
        }

        private readonly static MeasureClass massLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass length")]
        public static MeasureClass MassLength
        {
            get 
            {
                return massLength;
            }
        }

        private readonly static MeasureClass massPerEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per energy")]
        public static MeasureClass MassPerEnergy
        {
            get 
            {
                return massPerEnergy;
            }
        }

        private readonly static MeasureClass massPerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per area")]
        public static MeasureClass MassPerTimePerArea
        {
            get 
            {
                return massPerTimePerArea;
            }
        }

        private readonly static MeasureClass massPerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per length")]
        public static MeasureClass MassPerTimePerLength
        {
            get 
            {
                return massPerTimePerLength;
            }
        }

        private readonly static MeasureClass massPerVolumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per volume per length")]
        public static MeasureClass MassPerVolumePerLength
        {
            get 
            {
                return massPerVolumePerLength;
            }
        }

        private readonly static MeasureClass massConcentration;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass concentration")]
        public static MeasureClass MassConcentration
        {
            get 
            {
                return massConcentration;
            }
        }

        private readonly static MeasureClass mobility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mobility")]
        public static MeasureClass Mobility
        {
            get 
            {
                return mobility;
            }
        }

        private readonly static MeasureClass modulusOfCompression;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("modulus of compression")]
        public static MeasureClass ModulusOfCompression
        {
            get 
            {
                return modulusOfCompression;
            }
        }

        private readonly static MeasureClass molarHeatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar heat capacity")]
        public static MeasureClass MolarHeatCapacity
        {
            get 
            {
                return molarHeatCapacity;
            }
        }

        private readonly static MeasureClass molarVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar volume")]
        public static MeasureClass MolarVolume
        {
            get 
            {
                return molarVolume;
            }
        }

        private readonly static MeasureClass molePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per area")]
        public static MeasureClass MolePerArea
        {
            get 
            {
                return molePerArea;
            }
        }

        private readonly static MeasureClass molePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time")]
        public static MeasureClass MolePerTime
        {
            get 
            {
                return molePerTime;
            }
        }

        private readonly static MeasureClass molePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time per area")]
        public static MeasureClass MolePerTimePerArea
        {
            get 
            {
                return molePerTimePerArea;
            }
        }

        private readonly static MeasureClass momentOfForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of force")]
        public static MeasureClass MomentOfForce
        {
            get 
            {
                return momentOfForce;
            }
        }

        private readonly static MeasureClass momentOfInertia;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of inertia")]
        public static MeasureClass MomentOfInertia
        {
            get 
            {
                return momentOfInertia;
            }
        }

        private readonly static MeasureClass momentOfSection;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of section")]
        public static MeasureClass MomentOfSection
        {
            get 
            {
                return momentOfSection;
            }
        }

        private readonly static MeasureClass momentum;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("momentum")]
        public static MeasureClass Momentum
        {
            get 
            {
                return momentum;
            }
        }

        private readonly static MeasureClass neutronApiUnit;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("neutron API unit")]
        public static MeasureClass NeutronApiUnit
        {
            get 
            {
                return neutronApiUnit;
            }
        }

        private readonly static MeasureClass nondarcyFlowCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("nonDarcy flow coefficient")]
        public static MeasureClass NondarcyFlowCoefficient
        {
            get 
            {
                return nondarcyFlowCoefficient;
            }
        }

        private readonly static MeasureClass operationsPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("operations per time")]
        public static MeasureClass OperationsPerTime
        {
            get 
            {
                return operationsPerTime;
            }
        }

        private readonly static MeasureClass parachor;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("parachor")]
        public static MeasureClass Parachor
        {
            get 
            {
                return parachor;
            }
        }

        private readonly static MeasureClass perArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per area")]
        public static MeasureClass PerArea
        {
            get 
            {
                return perArea;
            }
        }

        private readonly static MeasureClass perElectricPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per electric potential")]
        public static MeasureClass PerElectricPotential
        {
            get 
            {
                return perElectricPotential;
            }
        }

        private readonly static MeasureClass perForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per force")]
        public static MeasureClass PerForce
        {
            get 
            {
                return perForce;
            }
        }

        private readonly static MeasureClass perLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per length")]
        public static MeasureClass PerLength
        {
            get 
            {
                return perLength;
            }
        }

        private readonly static MeasureClass perMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per mass")]
        public static MeasureClass PerMass
        {
            get 
            {
                return perMass;
            }
        }

        private readonly static MeasureClass perVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per volume")]
        public static MeasureClass PerVolume
        {
            get 
            {
                return perVolume;
            }
        }

        private readonly static MeasureClass permeabilityLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability length")]
        public static MeasureClass PermeabilityLength
        {
            get 
            {
                return permeabilityLength;
            }
        }

        private readonly static MeasureClass permeabilityRock;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability rock")]
        public static MeasureClass PermeabilityRock
        {
            get 
            {
                return permeabilityRock;
            }
        }

        private readonly static MeasureClass permeance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeance")]
        public static MeasureClass Permeance
        {
            get 
            {
                return permeance;
            }
        }

        private readonly static MeasureClass permittivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permittivity")]
        public static MeasureClass Permittivity
        {
            get 
            {
                return permittivity;
            }
        }

        private readonly static MeasureClass ph;
        /// <summary>
        /// The pH is a class that measures the hydrogen ion concentration (acidity).
        /// </summary>
        [EnumValueNameAttribute("pH")]
        public static MeasureClass Ph
        {
            get 
            {
                return ph;
            }
        }

        private readonly static MeasureClass planeAngle;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("plane angle")]
        public static MeasureClass PlaneAngle
        {
            get 
            {
                return planeAngle;
            }
        }

        private readonly static MeasureClass potentialDifferencePerPowerDrop;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("potential difference per power drop")]
        public static MeasureClass PotentialDifferencePerPowerDrop
        {
            get 
            {
                return potentialDifferencePerPowerDrop;
            }
        }

        private readonly static MeasureClass power;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power")]
        public static MeasureClass Power
        {
            get 
            {
                return power;
            }
        }

        private readonly static MeasureClass powerPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power per volume")]
        public static MeasureClass PowerPerVolume
        {
            get 
            {
                return powerPerVolume;
            }
        }

        private readonly static MeasureClass pressure;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure")]
        public static MeasureClass Pressure
        {
            get 
            {
                return pressure;
            }
        }

        private readonly static MeasureClass pressurePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure per time")]
        public static MeasureClass PressurePerTime
        {
            get 
            {
                return pressurePerTime;
            }
        }

        private readonly static MeasureClass pressureSquared;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared")]
        public static MeasureClass PressureSquared
        {
            get 
            {
                return pressureSquared;
            }
        }

        private readonly static MeasureClass pressureSquaredPerForceTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared per force time per area")]
        public static MeasureClass PressureSquaredPerForceTimePerArea
        {
            get 
            {
                return pressureSquaredPerForceTimePerArea;
            }
        }

        private readonly static MeasureClass pressureTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure time per volume")]
        public static MeasureClass PressureTimePerVolume
        {
            get 
            {
                return pressureTimePerVolume;
            }
        }

        private readonly static MeasureClass productivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("productivity index")]
        public static MeasureClass ProductivityIndex
        {
            get 
            {
                return productivityIndex;
            }
        }

        private readonly static MeasureClass quantityOfLight;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("quantity of light")]
        public static MeasureClass QuantityOfLight
        {
            get 
            {
                return quantityOfLight;
            }
        }

        private readonly static MeasureClass radiance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiance")]
        public static MeasureClass Radiance
        {
            get 
            {
                return radiance;
            }
        }

        private readonly static MeasureClass radiantIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiant intensity")]
        public static MeasureClass RadiantIntensity
        {
            get 
            {
                return radiantIntensity;
            }
        }

        private readonly static MeasureClass relativePower;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("relative power")]
        public static MeasureClass RelativePower
        {
            get 
            {
                return relativePower;
            }
        }

        private readonly static MeasureClass relativeTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("relative time")]
        public static MeasureClass RelativeTime
        {
            get 
            {
                return relativeTime;
            }
        }

        private readonly static MeasureClass reluctance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("reluctance")]
        public static MeasureClass Reluctance
        {
            get 
            {
                return reluctance;
            }
        }

        private readonly static MeasureClass resistance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistance")]
        public static MeasureClass Resistance
        {
            get 
            {
                return resistance;
            }
        }

        private readonly static MeasureClass resistivityPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistivity per length")]
        public static MeasureClass ResistivityPerLength
        {
            get 
            {
                return resistivityPerLength;
            }
        }

        private readonly static MeasureClass secondMomentOfArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("second moment of area")]
        public static MeasureClass SecondMomentOfArea
        {
            get 
            {
                return secondMomentOfArea;
            }
        }

        private readonly static MeasureClass solidAngle;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("solid angle")]
        public static MeasureClass SolidAngle
        {
            get 
            {
                return solidAngle;
            }
        }

        private readonly static MeasureClass specificActivityOfRadioactivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific activity (of radioactivity)")]
        public static MeasureClass SpecificActivityOfRadioactivity
        {
            get 
            {
                return specificActivityOfRadioactivity;
            }
        }

        private readonly static MeasureClass specificEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific energy")]
        public static MeasureClass SpecificEnergy
        {
            get 
            {
                return specificEnergy;
            }
        }

        private readonly static MeasureClass specificHeatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific heat capacity")]
        public static MeasureClass SpecificHeatCapacity
        {
            get 
            {
                return specificHeatCapacity;
            }
        }

        private readonly static MeasureClass specificProductivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific productivity index")]
        public static MeasureClass SpecificProductivityIndex
        {
            get 
            {
                return specificProductivityIndex;
            }
        }

        private readonly static MeasureClass specificVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific volume")]
        public static MeasureClass SpecificVolume
        {
            get 
            {
                return specificVolume;
            }
        }

        private readonly static MeasureClass standardVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume")]
        public static MeasureClass StandardVolume
        {
            get 
            {
                return standardVolume;
            }
        }

        private readonly static MeasureClass standardVolumePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume per area")]
        public static MeasureClass StandardVolumePerArea
        {
            get 
            {
                return standardVolumePerArea;
            }
        }

        private readonly static MeasureClass standardVolumePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume per time")]
        public static MeasureClass StandardVolumePerTime
        {
            get 
            {
                return standardVolumePerTime;
            }
        }

        private readonly static MeasureClass standardVolumePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("standard volume per volume")]
        public static MeasureClass StandardVolumePerVolume
        {
            get 
            {
                return standardVolumePerVolume;
            }
        }

        private readonly static MeasureClass surfaceDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("surface density")]
        public static MeasureClass SurfaceDensity
        {
            get 
            {
                return surfaceDensity;
            }
        }

        private readonly static MeasureClass temperaturePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per length")]
        public static MeasureClass TemperaturePerLength
        {
            get 
            {
                return temperaturePerLength;
            }
        }

        private readonly static MeasureClass temperaturePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per time")]
        public static MeasureClass TemperaturePerTime
        {
            get 
            {
                return temperaturePerTime;
            }
        }

        private readonly static MeasureClass thermalConductance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductance")]
        public static MeasureClass ThermalConductance
        {
            get 
            {
                return thermalConductance;
            }
        }

        private readonly static MeasureClass thermalConductivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductivity")]
        public static MeasureClass ThermalConductivity
        {
            get 
            {
                return thermalConductivity;
            }
        }

        private readonly static MeasureClass thermalDiffusivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal diffusivity")]
        public static MeasureClass ThermalDiffusivity
        {
            get 
            {
                return thermalDiffusivity;
            }
        }

        private readonly static MeasureClass thermalInsulance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal insulance")]
        public static MeasureClass ThermalInsulance
        {
            get 
            {
                return thermalInsulance;
            }
        }

        private readonly static MeasureClass thermalResistance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal resistance")]
        public static MeasureClass ThermalResistance
        {
            get 
            {
                return thermalResistance;
            }
        }

        private readonly static MeasureClass thermodynamicTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermodynamic temperature")]
        public static MeasureClass ThermodynamicTemperature
        {
            get 
            {
                return thermodynamicTemperature;
            }
        }

        private readonly static MeasureClass time;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time")]
        public static MeasureClass Time
        {
            get 
            {
                return time;
            }
        }

        private readonly static MeasureClass timePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per length")]
        public static MeasureClass TimePerLength
        {
            get 
            {
                return timePerLength;
            }
        }

        private readonly static MeasureClass timePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per volume")]
        public static MeasureClass TimePerVolume
        {
            get 
            {
                return timePerVolume;
            }
        }

        private readonly static MeasureClass unitProductivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("unit productivity index")]
        public static MeasureClass UnitProductivityIndex
        {
            get 
            {
                return unitProductivityIndex;
            }
        }

        private readonly static MeasureClass velocity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("velocity")]
        public static MeasureClass Velocity
        {
            get 
            {
                return velocity;
            }
        }

        private readonly static MeasureClass volume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume")]
        public static MeasureClass Volume
        {
            get 
            {
                return volume;
            }
        }

        private readonly static MeasureClass volumeFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume flow rate")]
        public static MeasureClass VolumeFlowRate
        {
            get 
            {
                return volumeFlowRate;
            }
        }

        private readonly static MeasureClass volumeLengthPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume length per time")]
        public static MeasureClass VolumeLengthPerTime
        {
            get 
            {
                return volumeLengthPerTime;
            }
        }

        private readonly static MeasureClass volumePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per area")]
        public static MeasureClass VolumePerArea
        {
            get 
            {
                return volumePerArea;
            }
        }

        private readonly static MeasureClass volumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per length")]
        public static MeasureClass VolumePerLength
        {
            get 
            {
                return volumePerLength;
            }
        }

        private readonly static MeasureClass volumePerStandardVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per standard volume")]
        public static MeasureClass VolumePerStandardVolume
        {
            get 
            {
                return volumePerStandardVolume;
            }
        }

        private readonly static MeasureClass volumePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per area")]
        public static MeasureClass VolumePerTimePerArea
        {
            get 
            {
                return volumePerTimePerArea;
            }
        }

        private readonly static MeasureClass volumePerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per length")]
        public static MeasureClass VolumePerTimePerLength
        {
            get 
            {
                return volumePerTimePerLength;
            }
        }

        private readonly static MeasureClass volumePerTimePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per time")]
        public static MeasureClass VolumePerTimePerTime
        {
            get 
            {
                return volumePerTimePerTime;
            }
        }

        private readonly static MeasureClass volumePerTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per volume")]
        public static MeasureClass VolumePerTimePerVolume
        {
            get 
            {
                return volumePerTimePerVolume;
            }
        }

        private readonly static MeasureClass volumePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per volume")]
        public static MeasureClass VolumePerVolume
        {
            get 
            {
                return volumePerVolume;
            }
        }

        private readonly static MeasureClass volumetricHeatTransferCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric heat transfer coefficient")]
        public static MeasureClass VolumetricHeatTransferCoefficient
        {
            get 
            {
                return volumetricHeatTransferCoefficient;
            }
        }

        private readonly static MeasureClass volumetricThermalExpansion;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric thermal expansion")]
        public static MeasureClass VolumetricThermalExpansion
        {
            get 
            {
                return volumetricThermalExpansion;
            }
        }

        private readonly static MeasureClass work;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static MeasureClass Work
        {
            get 
            {
                return work;
            }
        }

        private readonly static MeasureClass unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static MeasureClass Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static MeasureClass()
        {
            absorbedDose = 
                new MeasureClass("absorbed dose")
                {
                    MeasureRepresentativeUOM = "Gy"
                    ,MeasureBaseForConversion = "Gy"
                    ,MeasureUom = "Gy"
                    ,Description = "The amount of energy absorbed per mass."
            };
            accelerationLinear = 
                new MeasureClass("acceleration linear")
                {
                    MeasureRepresentativeUOM = "m/s2"
                    ,MeasureBaseForConversion = "m/s2"
                    ,MeasureUom = "Gal"
            };
            activityOfRadioactivity = 
                new MeasureClass("activity (of radioactivity)")
                {
                    MeasureRepresentativeUOM = "Bq"
                    ,MeasureBaseForConversion = "Bq"
                    ,MeasureUom = "Bq"
                    ,Description = "A measure of the radiation being emitted."
            };
            concentrationOfB = 
                new MeasureClass("concentration of B")
                {
                    MeasureRepresentativeUOM = "mol/m3"
                    ,MeasureBaseForConversion = "mol/m3"
                    ,MeasureUom = "kmol/m3"
                    ,Description = "molar concentration of a substance"
            };
            amountOfSubstance = 
                new MeasureClass("amount of substance")
                {
                    MeasureRepresentativeUOM = "mol"
                    ,MeasureBaseForConversion = "mol"
                    ,MeasureUom = "kmol"
                    ,Description = "molar amount of a substance"
            };
            anglePerLength = 
                new MeasureClass("angle per length")
                {
                    MeasureRepresentativeUOM = "rad/m"
                    ,MeasureBaseForConversion = "rad/m"
                    ,MeasureUom = "dega/100ft"
            };
            anglePerTime = 
                new MeasureClass("angle per time")
                {
                    MeasureRepresentativeUOM = "rad/s"
                    ,MeasureBaseForConversion = "rad/s"
                    ,MeasureUom = "c/s"
                    ,Description = "The angular velocity. The rate of change of an angle."
            };
            anglePerVolume = 
                new MeasureClass("angle per volume")
                {
                    MeasureRepresentativeUOM = "rad/m3"
                    ,MeasureBaseForConversion = "rad/m3"
                    ,MeasureUom = "rad/ft3"
            };
            angularAcceleration = 
                new MeasureClass("angular acceleration")
                {
                    MeasureRepresentativeUOM = "rad/s2"
                    ,MeasureBaseForConversion = "rad/s2"
                    ,MeasureUom = "rad/s2"
            };
            area = 
                new MeasureClass("area")
                {
                    MeasureRepresentativeUOM = "m2"
                    ,MeasureBaseForConversion = "m2"
                    ,MeasureUom = "acre"
            };
            areaPerArea = 
                new MeasureClass("area per area")
                {
                    MeasureRepresentativeUOM = "m2/m2"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "%"
            };
            areaPerVolume = 
                new MeasureClass("area per volume")
                {
                    MeasureRepresentativeUOM = "m2/m3"
                    ,MeasureBaseForConversion = "1/m"
                    ,MeasureUom = "b/cm3"
            };
            attenuation = 
                new MeasureClass("attenuation")
                {
                    MeasureRepresentativeUOM = "Euc"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "B/O"
                    ,Description = "A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave."
            };
            attenuationPerLength = 
                new MeasureClass("attenuation per length")
                {
                    MeasureRepresentativeUOM = "B/m"
                    ,MeasureBaseForConversion = "B/m"
                    ,MeasureUom = "B/m"
            };
            capacitance = 
                new MeasureClass("capacitance")
                {
                    MeasureRepresentativeUOM = "F"
                    ,MeasureBaseForConversion = "F"
                    ,MeasureUom = "F"
            };
            chargeDensity = 
                new MeasureClass("charge density")
                {
                    MeasureRepresentativeUOM = "C/m3"
                    ,MeasureBaseForConversion = "C/m3"
                    ,MeasureUom = "C/cm3"
            };
            chemicalPotential = 
                new MeasureClass("chemical potential")
                {
                    MeasureRepresentativeUOM = "J/mol"
                    ,MeasureBaseForConversion = "J/mol"
                    ,MeasureUom = "Btu/lbmole"
            };
            compressibility = 
                new MeasureClass("compressibility")
                {
                    MeasureRepresentativeUOM = "1/Pa"
                    ,MeasureBaseForConversion = "1/Pa"
                    ,MeasureUom = "1/Pa"
            };
            conductivity = 
                new MeasureClass("conductivity")
                {
                    MeasureRepresentativeUOM = "S/m"
                    ,MeasureBaseForConversion = "S/m"
                    ,MeasureUom = "S/m"
            };
            crossSectionAbsorption = 
                new MeasureClass("cross section absorption")
                {
                    MeasureRepresentativeUOM = "m2/mol"
                    ,MeasureBaseForConversion = "m2/mol"
                    ,MeasureUom = "b/elec"
            };
            currentDensity = 
                new MeasureClass("current density")
                {
                    MeasureRepresentativeUOM = "A/m2"
                    ,MeasureBaseForConversion = "A/m2"
                    ,MeasureUom = "A/cm2"
            };
            darcyFlowCoefficient = 
                new MeasureClass("Darcy flow coefficient")
                {
                    MeasureRepresentativeUOM = "Pa/m3"
                    ,MeasureBaseForConversion = "Pa/m3"
                    ,MeasureUom = "Pa/m3"
            };
            dataTransmissionSpeed = 
                new MeasureClass("data transmission speed")
                {
                    MeasureRepresentativeUOM = "Bd"
                    ,MeasureBaseForConversion = "Bd"
                    ,MeasureUom = "Bd"
                    ,Description = "used primarily for computer transmission rates."
            };
            deltaTemperature = 
                new MeasureClass("delta temperature")
                {
                    MeasureRepresentativeUOM = "K"
                    ,MeasureBaseForConversion = "K"
                    ,MeasureUom = "K"
                    ,Description = "Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures."
            };
            density = 
                new MeasureClass("density")
                {
                    MeasureRepresentativeUOM = "kg/m3"
                    ,MeasureBaseForConversion = "kg/m3"
                    ,MeasureUom = "10Mg/m3"
            };
            diffusionCoefficient = 
                new MeasureClass("diffusion coefficient")
                {
                    MeasureRepresentativeUOM = "m2/s"
                    ,MeasureBaseForConversion = "m2/s"
                    ,MeasureUom = "m2/s"
            };
            digitalStorage = 
                new MeasureClass("digital storage")
                {
                    MeasureRepresentativeUOM = "byte"
                    ,MeasureBaseForConversion = "byte"
                    ,MeasureUom = "Mbyte"
            };
            dimensionless = 
                new MeasureClass("dimensionless")
                {
                    MeasureRepresentativeUOM = "Euc"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "%"
                    ,Description = "A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass."
            };
            doseEquivalent = 
                new MeasureClass("dose equivalent")
                {
                    MeasureRepresentativeUOM = "Sv"
                    ,MeasureBaseForConversion = "Sv"
                    ,MeasureUom = "Sv"
            };
            doseEquivalentRate = 
                new MeasureClass("dose equivalent rate")
                {
                    MeasureRepresentativeUOM = "Sv/s"
                    ,MeasureBaseForConversion = "Sv/s"
                    ,MeasureUom = "Sv/h"
            };
            dynamicViscosity = 
                new MeasureClass("dynamic viscosity")
                {
                    MeasureRepresentativeUOM = "Pa.s"
                    ,MeasureBaseForConversion = "Pa.s"
                    ,MeasureUom = "N.s/m2"
            };
            electricCharge = 
                new MeasureClass("electric charge")
                {
                    MeasureRepresentativeUOM = "C"
                    ,MeasureBaseForConversion = "C"
                    ,MeasureUom = "A.h"
            };
            electricConductance = 
                new MeasureClass("electric conductance")
                {
                    MeasureRepresentativeUOM = "S"
                    ,MeasureBaseForConversion = "S"
                    ,MeasureUom = "GS"
            };
            electricCurrent = 
                new MeasureClass("electric current")
                {
                    MeasureRepresentativeUOM = "A"
                    ,MeasureBaseForConversion = "A"
                    ,MeasureUom = "A"
            };
            electricDipoleMoment = 
                new MeasureClass("electric dipole moment")
                {
                    MeasureRepresentativeUOM = "C.m"
                    ,MeasureBaseForConversion = "C.m"
                    ,MeasureUom = "C.m"
            };
            electricFieldStrength = 
                new MeasureClass("electric field strength")
                {
                    MeasureRepresentativeUOM = "V/m"
                    ,MeasureBaseForConversion = "V/m"
                    ,MeasureUom = "V/m"
            };
            electricPolarization = 
                new MeasureClass("electric polarization")
                {
                    MeasureRepresentativeUOM = "C/m2"
                    ,MeasureBaseForConversion = "C/m2"
                    ,MeasureUom = "C/cm2"
            };
            electricPotential = 
                new MeasureClass("electric potential")
                {
                    MeasureRepresentativeUOM = "V"
                    ,MeasureBaseForConversion = "V"
                    ,MeasureUom = "MV"
            };
            electricalResistivity = 
                new MeasureClass("electrical resistivity")
                {
                    MeasureRepresentativeUOM = "ohm.m"
                    ,MeasureBaseForConversion = "ohm.m"
                    ,MeasureUom = "kohm.m"
            };
            electrochemicalEquivalent = 
                new MeasureClass("electrochemical equivalent")
                {
                    MeasureRepresentativeUOM = "eq"
                    ,MeasureBaseForConversion = "eq"
                    ,MeasureUom = "eq"
                    ,Description = "An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered."
            };
            electromagneticMoment = 
                new MeasureClass("electromagnetic moment")
                {
                    MeasureRepresentativeUOM = "A.m2"
                    ,MeasureBaseForConversion = "A.m2"
                    ,MeasureUom = "A.m2"
            };
            energyLengthPerArea = 
                new MeasureClass("energy length per area")
                {
                    MeasureRepresentativeUOM = "kcal.m/cm2"
                    ,MeasureBaseForConversion = "kcal.m/cm2"
                    ,MeasureUom = "kcal.m/cm2"
            };
            energyLengthPerTimeAreaTemperature = 
                new MeasureClass("energy length per time area temperature")
                {
                    MeasureRepresentativeUOM = "W/m.K"
                    ,MeasureBaseForConversion = "W/m.K"
                    ,MeasureUom = "Btu.in/hr.ft2.F"
            };
            energyPerArea = 
                new MeasureClass("energy per area")
                {
                    MeasureRepresentativeUOM = "N/m"
                    ,MeasureBaseForConversion = "N/m"
                    ,MeasureUom = "J/cm2"
            };
            energyPerLength = 
                new MeasureClass("energy per length")
                {
                    MeasureRepresentativeUOM = "J/m"
                    ,MeasureBaseForConversion = "J/m"
                    ,MeasureUom = "J/m"
            };
            equivalentPerMass = 
                new MeasureClass("equivalent per mass")
                {
                    MeasureRepresentativeUOM = "eq/kg"
                    ,MeasureBaseForConversion = "eq/kg"
                    ,MeasureUom = "eq/kg"
            };
            equivalentPerVolume = 
                new MeasureClass("equivalent per volume")
                {
                    MeasureRepresentativeUOM = "eq/L"
                    ,MeasureBaseForConversion = "eq/L"
                    ,MeasureUom = "eq/L"
            };
            exposureRadioactivity = 
                new MeasureClass("exposure (radioactivity)")
                {
                    MeasureRepresentativeUOM = "C/kg"
                    ,MeasureBaseForConversion = "C/kg"
                    ,MeasureUom = "C/g"
            };
            force = 
                new MeasureClass("force")
                {
                    MeasureRepresentativeUOM = "N"
                    ,MeasureBaseForConversion = "N"
                    ,MeasureUom = "MN"
            };
            forceArea = 
                new MeasureClass("force area")
                {
                    MeasureRepresentativeUOM = "N.m2"
                    ,MeasureBaseForConversion = "N.m2"
                    ,MeasureUom = "N.m2"
            };
            forceLengthPerLength = 
                new MeasureClass("force length per length")
                {
                    MeasureRepresentativeUOM = "kgf.m/m"
                    ,MeasureBaseForConversion = "kgf.m/m"
                    ,MeasureUom = "N.m/m"
            };
            forcePerForce = 
                new MeasureClass("force per force")
                {
                    MeasureRepresentativeUOM = "N/N"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "%"
            };
            forcePerLength = 
                new MeasureClass("force per length")
                {
                    MeasureRepresentativeUOM = "N/m"
                    ,MeasureBaseForConversion = "N/m"
                    ,MeasureUom = "N/30m"
            };
            forcePerVolume = 
                new MeasureClass("force per volume")
                {
                    MeasureRepresentativeUOM = "N/m3"
                    ,MeasureBaseForConversion = "N/m3"
                    ,MeasureUom = "GPa/cm"
            };
            frequency = 
                new MeasureClass("frequency")
                {
                    MeasureRepresentativeUOM = "Hz"
                    ,MeasureBaseForConversion = "Hz"
                    ,MeasureUom = "1/s"
            };
            frequencyInterval = 
                new MeasureClass("frequency interval")
                {
                    MeasureRepresentativeUOM = "O"
                    ,MeasureBaseForConversion = "O"
                    ,MeasureUom = "O"
                    ,Description = "An octave is a doubling of a frquency."
            };
            gammaRayApiUnit = 
                new MeasureClass("gamma ray API unit")
                {
                    MeasureRepresentativeUOM = "gAPI"
                    ,MeasureBaseForConversion = "gAPI"
                    ,MeasureUom = "gAPI"
                    ,Description = "This class is defined by the API, and is used for units of gamma ray log response."
            };
            heatCapacity = 
                new MeasureClass("heat capacity")
                {
                    MeasureRepresentativeUOM = "J/K"
                    ,MeasureBaseForConversion = "J/K"
                    ,MeasureUom = "J/K"
            };
            heatFlowRate = 
                new MeasureClass("heat flow rate")
                {
                    MeasureRepresentativeUOM = "W"
                    ,MeasureBaseForConversion = "W"
                    ,MeasureUom = "Btu/hr"
            };
            heatTransferCoefficient = 
                new MeasureClass("heat transfer coefficient")
                {
                    MeasureRepresentativeUOM = "W/m2.K"
                    ,MeasureBaseForConversion = "W/m2.K"
                    ,MeasureUom = "Btu/hr.ft2.degF"
            };
            illuminance = 
                new MeasureClass("illuminance")
                {
                    MeasureRepresentativeUOM = "lx"
                    ,MeasureBaseForConversion = "lx"
                    ,MeasureUom = "footcandle"
            };
            irradiance = 
                new MeasureClass("irradiance")
                {
                    MeasureRepresentativeUOM = "W/m2"
                    ,MeasureBaseForConversion = "W/m2"
                    ,MeasureUom = "Btu/hr.ft2"
            };
            isothermalCompressibility = 
                new MeasureClass("isothermal compressibility")
                {
                    MeasureRepresentativeUOM = "m3/J"
                    ,MeasureBaseForConversion = "m3/J"
                    ,MeasureUom = "dm3/MJ"
            };
            kinematicViscosity = 
                new MeasureClass("kinematic viscosity")
                {
                    MeasureRepresentativeUOM = "m2/s"
                    ,MeasureBaseForConversion = "m2/s"
                    ,MeasureUom = "cSt"
            };
            length = 
                new MeasureClass("length")
                {
                    MeasureRepresentativeUOM = "m"
                    ,MeasureBaseForConversion = "m"
                    ,MeasureUom = "Mm"
            };
            lengthPerLength = 
                new MeasureClass("length per length")
                {
                    MeasureRepresentativeUOM = "m/m"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "%"
            };
            lengthPerTemperature = 
                new MeasureClass("length per temperature")
                {
                    MeasureRepresentativeUOM = "m/K"
                    ,MeasureBaseForConversion = "m/K"
                    ,MeasureUom = "ft/degF"
            };
            lengthPerVolume = 
                new MeasureClass("length per volume")
                {
                    MeasureRepresentativeUOM = "ft/bbl"
                    ,MeasureBaseForConversion = "ft/bbl"
                    ,MeasureUom = "ft/bbl"
            };
            levelOfPowerIntensity = 
                new MeasureClass("level of power intensity")
                {
                    MeasureRepresentativeUOM = "B"
                    ,MeasureBaseForConversion = "B"
                    ,MeasureUom = "B"
            };
            lightExposure = 
                new MeasureClass("light exposure")
                {
                    MeasureRepresentativeUOM = "lx.s"
                    ,MeasureBaseForConversion = "lx.s"
                    ,MeasureUom = "footcandle.s"
            };
            massPerLength = 
                new MeasureClass("mass per length")
                {
                    MeasureRepresentativeUOM = "kg/m"
                    ,MeasureBaseForConversion = "kg/m"
                    ,MeasureUom = "Mg/in"
            };
            linearThermalExpansion = 
                new MeasureClass("linear thermal expansion")
                {
                    MeasureRepresentativeUOM = "in/in.degF"
                    ,MeasureBaseForConversion = "in/in.degF"
                    ,MeasureUom = "1/K"
            };
            luminance = 
                new MeasureClass("luminance")
                {
                    MeasureRepresentativeUOM = "cd/m2"
                    ,MeasureBaseForConversion = "cd/m2"
                    ,MeasureUom = "cd/m2"
            };
            luminousEfficacy = 
                new MeasureClass("luminous efficacy")
                {
                    MeasureRepresentativeUOM = "lm/W"
                    ,MeasureBaseForConversion = "lm/W"
                    ,MeasureUom = "lm/W"
            };
            luminousFlux = 
                new MeasureClass("luminous flux")
                {
                    MeasureRepresentativeUOM = "lm"
                    ,MeasureBaseForConversion = "lm"
                    ,MeasureUom = "lm"
            };
            luminousIntensity = 
                new MeasureClass("luminous intensity")
                {
                    MeasureRepresentativeUOM = "cd"
                    ,MeasureBaseForConversion = "cd"
                    ,MeasureUom = "cd"
            };
            magneticDipoleMoment = 
                new MeasureClass("magnetic dipole moment")
                {
                    MeasureRepresentativeUOM = "Wb.m"
                    ,MeasureBaseForConversion = "Wb.m"
                    ,MeasureUom = "Wb.m"
            };
            magneticFieldStrength = 
                new MeasureClass("magnetic field strength")
                {
                    MeasureRepresentativeUOM = "A/m"
                    ,MeasureBaseForConversion = "A/m"
                    ,MeasureUom = "A/m"
            };
            magneticFlux = 
                new MeasureClass("magnetic flux")
                {
                    MeasureRepresentativeUOM = "Wb"
                    ,MeasureBaseForConversion = "Wb"
                    ,MeasureUom = "Wb"
            };
            magneticInduction = 
                new MeasureClass("magnetic induction")
                {
                    MeasureRepresentativeUOM = "T"
                    ,MeasureBaseForConversion = "T"
                    ,MeasureUom = "T"
            };
            magneticPermeability = 
                new MeasureClass("magnetic permeability")
                {
                    MeasureRepresentativeUOM = "H/m"
                    ,MeasureBaseForConversion = "H/m"
                    ,MeasureUom = "H/m"
            };
            magneticVectorPotential = 
                new MeasureClass("magnetic vector potential")
                {
                    MeasureRepresentativeUOM = "Wb/m"
                    ,MeasureBaseForConversion = "Wb/m"
                    ,MeasureUom = "Wb/m"
            };
            mass = 
                new MeasureClass("mass")
                {
                    MeasureRepresentativeUOM = "kg"
                    ,MeasureBaseForConversion = "kg"
                    ,MeasureUom = "Mg"
            };
            massAttenuationCoefficient = 
                new MeasureClass("mass attenuation coefficient")
                {
                    MeasureRepresentativeUOM = "m2/kg"
                    ,MeasureBaseForConversion = "m2/kg"
                    ,MeasureUom = "cm2/g"
            };
            massFlowRate = 
                new MeasureClass("mass flow rate")
                {
                    MeasureRepresentativeUOM = "kg/s"
                    ,MeasureBaseForConversion = "kg/s"
                    ,MeasureUom = "Mg/a"
            };
            massLength = 
                new MeasureClass("mass length")
                {
                    MeasureRepresentativeUOM = "kg.m"
                    ,MeasureBaseForConversion = "kg.m"
                    ,MeasureUom = "ft.lbm"
            };
            massPerEnergy = 
                new MeasureClass("mass per energy")
                {
                    MeasureRepresentativeUOM = "kg/J"
                    ,MeasureBaseForConversion = "kg/J"
                    ,MeasureUom = "kg/J"
            };
            massPerTimePerArea = 
                new MeasureClass("mass per time per area")
                {
                    MeasureRepresentativeUOM = "kg/m2.s"
                    ,MeasureBaseForConversion = "kg/m2.s"
                    ,MeasureUom = "MPa.s/m"
            };
            massPerTimePerLength = 
                new MeasureClass("mass per time per length")
                {
                    MeasureRepresentativeUOM = "Pa.s"
                    ,MeasureBaseForConversion = "Pa.s"
                    ,MeasureUom = "Pa.s"
            };
            massPerVolumePerLength = 
                new MeasureClass("mass per volume per length")
                {
                    MeasureRepresentativeUOM = "kg/m4"
                    ,MeasureBaseForConversion = "kg/m4"
                    ,MeasureUom = "g/cm4"
            };
            massConcentration = 
                new MeasureClass("mass concentration")
                {
                    MeasureRepresentativeUOM = "Euc"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "%"
            };
            mobility = 
                new MeasureClass("mobility")
                {
                    MeasureRepresentativeUOM = "m2/Pa.s"
                    ,MeasureBaseForConversion = "m2/Pa.s"
                    ,MeasureUom = "m2/Pa.s"
            };
            modulusOfCompression = 
                new MeasureClass("modulus of compression")
                {
                    MeasureRepresentativeUOM = "J/m3"
                    ,MeasureBaseForConversion = "J/m3"
                    ,MeasureUom = "Btu/bbl"
            };
            molarHeatCapacity = 
                new MeasureClass("molar heat capacity")
                {
                    MeasureRepresentativeUOM = "J/mol.K"
                    ,MeasureBaseForConversion = "J/mol.K"
                    ,MeasureUom = "Btu/lbmole.F"
            };
            molarVolume = 
                new MeasureClass("molar volume")
                {
                    MeasureRepresentativeUOM = "m3/mol"
                    ,MeasureBaseForConversion = "m3/mol"
                    ,MeasureUom = "L/mol"
            };
            molePerArea = 
                new MeasureClass("mole per area")
                {
                    MeasureRepresentativeUOM = "mol/m2"
                    ,MeasureBaseForConversion = "mol/m2"
                    ,MeasureUom = "mol/m2"
            };
            molePerTime = 
                new MeasureClass("mole per time")
                {
                    MeasureRepresentativeUOM = "mol/s"
                    ,MeasureBaseForConversion = "mol/s"
                    ,MeasureUom = "kmol/h"
            };
            molePerTimePerArea = 
                new MeasureClass("mole per time per area")
                {
                    MeasureRepresentativeUOM = "mol/m2.s"
                    ,MeasureBaseForConversion = "mol/m2.s"
                    ,MeasureUom = "lbmole/h.ft2"
            };
            momentOfForce = 
                new MeasureClass("moment of force")
                {
                    MeasureRepresentativeUOM = "J"
                    ,MeasureBaseForConversion = "J"
                    ,MeasureUom = "J"
            };
            momentOfInertia = 
                new MeasureClass("moment of inertia")
                {
                    MeasureRepresentativeUOM = "kg.m2"
                    ,MeasureBaseForConversion = "kg.m2"
                    ,MeasureUom = "kg.m2"
            };
            momentOfSection = 
                new MeasureClass("moment of section")
                {
                    MeasureRepresentativeUOM = "m4"
                    ,MeasureBaseForConversion = "m4"
                    ,MeasureUom = "m4"
            };
            momentum = 
                new MeasureClass("momentum")
                {
                    MeasureRepresentativeUOM = "kg.m/s"
                    ,MeasureBaseForConversion = "kg.m/s"
                    ,MeasureUom = "kg.m/s"
            };
            neutronApiUnit = 
                new MeasureClass("neutron API unit")
                {
                    MeasureRepresentativeUOM = "nAPI"
                    ,MeasureBaseForConversion = "nAPI"
                    ,MeasureUom = "nAPI"
            };
            nondarcyFlowCoefficient = 
                new MeasureClass("nonDarcy flow coefficient")
                {
                    MeasureRepresentativeUOM = "Pa.s/m6"
                    ,MeasureBaseForConversion = "Pa.s/m6"
                    ,MeasureUom = "Pa.s/m6"
            };
            operationsPerTime = 
                new MeasureClass("operations per time")
                {
                    MeasureRepresentativeUOM = "1/s"
                    ,MeasureBaseForConversion = "1/s"
                    ,MeasureUom = "1/s"
            };
            parachor = 
                new MeasureClass("parachor")
                {
                    MeasureRepresentativeUOM = "N4/kg.m7"
                    ,MeasureBaseForConversion = "N4/kg.m7"
                    ,MeasureUom = "(N/m)4/kg.m3"
            };
            perArea = 
                new MeasureClass("per area")
                {
                    MeasureRepresentativeUOM = "1/m2"
                    ,MeasureBaseForConversion = "1/m2"
                    ,MeasureUom = "1/ft2"
            };
            perElectricPotential = 
                new MeasureClass("per electric potential")
                {
                    MeasureRepresentativeUOM = "1/V"
                    ,MeasureBaseForConversion = "1/V"
                    ,MeasureUom = "1/V"
            };
            perForce = 
                new MeasureClass("per force")
                {
                    MeasureRepresentativeUOM = "1/N"
                    ,MeasureBaseForConversion = "1/N"
                    ,MeasureUom = "1/N"
            };
            perLength = 
                new MeasureClass("per length")
                {
                    MeasureRepresentativeUOM = "1/m"
                    ,MeasureBaseForConversion = "1/m"
                    ,MeasureUom = "1/angstrom"
            };
            perMass = 
                new MeasureClass("per mass")
                {
                    MeasureRepresentativeUOM = "1/kg"
                    ,MeasureBaseForConversion = "1/kg"
                    ,MeasureUom = "1/g"
            };
            perVolume = 
                new MeasureClass("per volume")
                {
                    MeasureRepresentativeUOM = "1/m3"
                    ,MeasureBaseForConversion = "1/m3"
                    ,MeasureUom = "1/L"
            };
            permeabilityLength = 
                new MeasureClass("permeability length")
                {
                    MeasureRepresentativeUOM = "D.ft"
                    ,MeasureBaseForConversion = "D.ft"
                    ,MeasureUom = "D.ft"
            };
            permeabilityRock = 
                new MeasureClass("permeability rock")
                {
                    MeasureRepresentativeUOM = "D"
                    ,MeasureBaseForConversion = "D"
                    ,MeasureUom = "D"
            };
            permeance = 
                new MeasureClass("permeance")
                {
                    MeasureRepresentativeUOM = "H"
                    ,MeasureBaseForConversion = "H"
                    ,MeasureUom = "H"
            };
            permittivity = 
                new MeasureClass("permittivity")
                {
                    MeasureRepresentativeUOM = "F/m"
                    ,MeasureBaseForConversion = "F/m"
                    ,MeasureUom = "F/m"
            };
            ph = 
                new MeasureClass("pH")
                {
                    MeasureRepresentativeUOM = "pH"
                    ,MeasureBaseForConversion = "pH"
                    ,MeasureUom = "pH"
                    ,Description = "The pH is a class that measures the hydrogen ion concentration (acidity)."
            };
            planeAngle = 
                new MeasureClass("plane angle")
                {
                    MeasureRepresentativeUOM = "rad"
                    ,MeasureBaseForConversion = "rad"
                    ,MeasureUom = "Grad"
            };
            potentialDifferencePerPowerDrop = 
                new MeasureClass("potential difference per power drop")
                {
                    MeasureRepresentativeUOM = "V/B"
                    ,MeasureBaseForConversion = "V/B"
                    ,MeasureUom = "V/B"
            };
            power = 
                new MeasureClass("power")
                {
                    MeasureRepresentativeUOM = "W"
                    ,MeasureBaseForConversion = "W"
                    ,MeasureUom = "CV"
            };
            powerPerVolume = 
                new MeasureClass("power per volume")
                {
                    MeasureRepresentativeUOM = "W/m3"
                    ,MeasureBaseForConversion = "W/m3"
                    ,MeasureUom = "Btu/hr.ft3"
            };
            pressure = 
                new MeasureClass("pressure")
                {
                    MeasureRepresentativeUOM = "Pa"
                    ,MeasureBaseForConversion = "Pa"
                    ,MeasureUom = "GPa"
            };
            pressurePerTime = 
                new MeasureClass("pressure per time")
                {
                    MeasureRepresentativeUOM = "Pa/s"
                    ,MeasureBaseForConversion = "Pa/s"
                    ,MeasureUom = "MPa/h"
            };
            pressureSquared = 
                new MeasureClass("pressure squared")
                {
                    MeasureRepresentativeUOM = "Pa2"
                    ,MeasureBaseForConversion = "Pa2"
                    ,MeasureUom = "GPa2"
            };
            pressureSquaredPerForceTimePerArea = 
                new MeasureClass("pressure squared per force time per area")
                {
                    MeasureRepresentativeUOM = "bar2/cP"
                    ,MeasureBaseForConversion = "Pa/s"
                    ,MeasureUom = "bar2/cP"
            };
            pressureTimePerVolume = 
                new MeasureClass("pressure time per volume")
                {
                    MeasureRepresentativeUOM = "Pa.s/m3"
                    ,MeasureBaseForConversion = "Pa.s/m3"
                    ,MeasureUom = "Pa.s/m3"
            };
            productivityIndex = 
                new MeasureClass("productivity index")
                {
                    MeasureRepresentativeUOM = "m3/Pa.s"
                    ,MeasureBaseForConversion = "m3/Pa.s"
                    ,MeasureUom = "1000ft3/psi.d"
            };
            quantityOfLight = 
                new MeasureClass("quantity of light")
                {
                    MeasureRepresentativeUOM = "lm.s"
                    ,MeasureBaseForConversion = "lm.s"
                    ,MeasureUom = "lm.s"
            };
            radiance = 
                new MeasureClass("radiance")
                {
                    MeasureRepresentativeUOM = "W/m2.sr"
                    ,MeasureBaseForConversion = "W/m2.sr"
                    ,MeasureUom = "W/m2.sr"
            };
            radiantIntensity = 
                new MeasureClass("radiant intensity")
                {
                    MeasureRepresentativeUOM = "W/sr"
                    ,MeasureBaseForConversion = "W/sr"
                    ,MeasureUom = "W/sr"
            };
            relativePower = 
                new MeasureClass("relative power")
                {
                    MeasureRepresentativeUOM = "Euc"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "%"
            };
            relativeTime = 
                new MeasureClass("relative time")
                {
                    MeasureRepresentativeUOM = "ms/s"
                    ,MeasureBaseForConversion = "ms/s"
                    ,MeasureUom = "ms/s"
            };
            reluctance = 
                new MeasureClass("reluctance")
                {
                    MeasureRepresentativeUOM = "1/H"
                    ,MeasureBaseForConversion = "1/H"
                    ,MeasureUom = "1/H"
            };
            resistance = 
                new MeasureClass("resistance")
                {
                    MeasureRepresentativeUOM = "ohm"
                    ,MeasureBaseForConversion = "ohm"
                    ,MeasureUom = "Gohm"
            };
            resistivityPerLength = 
                new MeasureClass("resistivity per length")
                {
                    MeasureRepresentativeUOM = "ohm/m"
                    ,MeasureBaseForConversion = "ohm/m"
                    ,MeasureUom = "ohm/m"
            };
            secondMomentOfArea = 
                new MeasureClass("second moment of area")
                {
                    MeasureRepresentativeUOM = "m4"
                    ,MeasureBaseForConversion = "m4"
                    ,MeasureUom = "cm4"
            };
            solidAngle = 
                new MeasureClass("solid angle")
                {
                    MeasureRepresentativeUOM = "sr"
                    ,MeasureBaseForConversion = "sr"
                    ,MeasureUom = "sr"
            };
            specificActivityOfRadioactivity = 
                new MeasureClass("specific activity (of radioactivity)")
                {
                    MeasureRepresentativeUOM = "Bq/kg"
                    ,MeasureBaseForConversion = "Bq/kg"
                    ,MeasureUom = "Bq/kg"
            };
            specificEnergy = 
                new MeasureClass("specific energy")
                {
                    MeasureRepresentativeUOM = "J/kg"
                    ,MeasureBaseForConversion = "J/kg"
                    ,MeasureUom = "Btu/lbm"
            };
            specificHeatCapacity = 
                new MeasureClass("specific heat capacity")
                {
                    MeasureRepresentativeUOM = "J/kg.K"
                    ,MeasureBaseForConversion = "J/kg.K"
                    ,MeasureUom = "Btu/lbm.degF"
            };
            specificProductivityIndex = 
                new MeasureClass("specific productivity index")
                {
                    MeasureRepresentativeUOM = "m3/Pa2.s2"
                    ,MeasureBaseForConversion = "m3/Pa2.s2"
                    ,MeasureUom = "bbl/cP.d.psi"
            };
            specificVolume = 
                new MeasureClass("specific volume")
                {
                    MeasureRepresentativeUOM = "m3/kg"
                    ,MeasureBaseForConversion = "m3/kg"
                    ,MeasureUom = "L/100kg"
            };
            standardVolume = 
                new MeasureClass("standard volume")
                {
                    MeasureRepresentativeUOM = "scm(15C)"
                    ,MeasureBaseForConversion = "scm(15C)"
                    ,MeasureUom = "Gsm3"
            };
            standardVolumePerArea = 
                new MeasureClass("standard volume per area")
                {
                    MeasureRepresentativeUOM = "scm(15C)/m2"
                    ,MeasureBaseForConversion = "scm(15C)/m2"
                    ,MeasureUom = "MMstb/acre"
            };
            standardVolumePerTime = 
                new MeasureClass("standard volume per time")
                {
                    MeasureRepresentativeUOM = "scm(15C)/s"
                    ,MeasureBaseForConversion = "scm(15C)/s"
                    ,MeasureUom = "MMscf(60F)/d"
            };
            standardVolumePerVolume = 
                new MeasureClass("standard volume per volume")
                {
                    MeasureRepresentativeUOM = "scm(0C)/m3"
                    ,MeasureBaseForConversion = "scm(0C)/m3"
                    ,MeasureUom = "MMstb/acre.ft"
            };
            surfaceDensity = 
                new MeasureClass("surface density")
                {
                    MeasureRepresentativeUOM = "kg/m2"
                    ,MeasureBaseForConversion = "kg/m2"
                    ,MeasureUom = "Mg/m2"
            };
            temperaturePerLength = 
                new MeasureClass("temperature per length")
                {
                    MeasureRepresentativeUOM = "K/m"
                    ,MeasureBaseForConversion = "K/m"
                    ,MeasureUom = "K/m"
            };
            temperaturePerTime = 
                new MeasureClass("temperature per time")
                {
                    MeasureRepresentativeUOM = "K/s"
                    ,MeasureBaseForConversion = "K/s"
                    ,MeasureUom = "K/s"
            };
            thermalConductance = 
                new MeasureClass("thermal conductance")
                {
                    MeasureRepresentativeUOM = "W/K"
                    ,MeasureBaseForConversion = "W/K"
                    ,MeasureUom = "W/K"
            };
            thermalConductivity = 
                new MeasureClass("thermal conductivity")
                {
                    MeasureRepresentativeUOM = "W/m.K"
                    ,MeasureBaseForConversion = "W/m.K"
                    ,MeasureUom = "Btu/hr.ft.degF"
            };
            thermalDiffusivity = 
                new MeasureClass("thermal diffusivity")
                {
                    MeasureRepresentativeUOM = "m2/s"
                    ,MeasureBaseForConversion = "m2/s"
                    ,MeasureUom = "cm2/s"
            };
            thermalInsulance = 
                new MeasureClass("thermal insulance")
                {
                    MeasureRepresentativeUOM = "K.m2/W"
                    ,MeasureBaseForConversion = "K.m2/W"
                    ,MeasureUom = "K.m2/W"
            };
            thermalResistance = 
                new MeasureClass("thermal resistance")
                {
                    MeasureRepresentativeUOM = "K/W"
                    ,MeasureBaseForConversion = "K/W"
                    ,MeasureUom = "K/W"
            };
            thermodynamicTemperature = 
                new MeasureClass("thermodynamic temperature")
                {
                    MeasureRepresentativeUOM = "K"
                    ,MeasureBaseForConversion = "K"
                    ,MeasureUom = "K"
            };
            time = 
                new MeasureClass("time")
                {
                    MeasureRepresentativeUOM = "s"
                    ,MeasureBaseForConversion = "s"
                    ,MeasureUom = "100ka"
            };
            timePerLength = 
                new MeasureClass("time per length")
                {
                    MeasureRepresentativeUOM = "s/m"
                    ,MeasureBaseForConversion = "s/m"
                    ,MeasureUom = "h/kft"
            };
            timePerVolume = 
                new MeasureClass("time per volume")
                {
                    MeasureRepresentativeUOM = "s/m3"
                    ,MeasureBaseForConversion = "s/m3"
                    ,MeasureUom = "d/bbl"
            };
            unitProductivityIndex = 
                new MeasureClass("unit productivity index")
                {
                    MeasureRepresentativeUOM = "m2/Pa.s"
                    ,MeasureBaseForConversion = "m2/Pa.s"
                    ,MeasureUom = "bbl/d.ft.psi"
            };
            velocity = 
                new MeasureClass("velocity")
                {
                    MeasureRepresentativeUOM = "m/s"
                    ,MeasureBaseForConversion = "m/s"
                    ,MeasureUom = "cm/a"
            };
            volume = 
                new MeasureClass("volume")
                {
                    MeasureRepresentativeUOM = "m3"
                    ,MeasureBaseForConversion = "m3"
                    ,MeasureUom = "1000ft3"
            };
            volumeFlowRate = 
                new MeasureClass("volume flow rate")
                {
                    MeasureRepresentativeUOM = "m3/s"
                    ,MeasureBaseForConversion = "m3/s"
                    ,MeasureUom = "1000ft3/d"
            };
            volumeLengthPerTime = 
                new MeasureClass("volume length per time")
                {
                    MeasureRepresentativeUOM = "m4/s"
                    ,MeasureBaseForConversion = "m4/s"
                    ,MeasureUom = "1000m4/d"
            };
            volumePerArea = 
                new MeasureClass("volume per area")
                {
                    MeasureRepresentativeUOM = "m3/m2"
                    ,MeasureBaseForConversion = "m"
                    ,MeasureUom = "bbl/acre"
            };
            volumePerLength = 
                new MeasureClass("volume per length")
                {
                    MeasureRepresentativeUOM = "m3/m"
                    ,MeasureBaseForConversion = "m2"
                    ,MeasureUom = "L/100km"
            };
            volumePerStandardVolume = 
                new MeasureClass("volume per standard volume")
                {
                    MeasureRepresentativeUOM = "m3/scm(15C)"
                    ,MeasureBaseForConversion = "m3/scm(15C)"
                    ,MeasureUom = "acre.ft/MMstb"
            };
            volumePerTimePerArea = 
                new MeasureClass("volume per time per area")
                {
                    MeasureRepresentativeUOM = "ft3/min.ft2"
                    ,MeasureBaseForConversion = "ft3/min.ft2"
                    ,MeasureUom = "ft3/min.ft2"
            };
            volumePerTimePerLength = 
                new MeasureClass("volume per time per length")
                {
                    MeasureRepresentativeUOM = "bbl/d.ft"
                    ,MeasureBaseForConversion = "bbl/d.ft"
                    ,MeasureUom = "1000ft3/d.ft"
            };
            volumePerTimePerTime = 
                new MeasureClass("volume per time per time")
                {
                    MeasureRepresentativeUOM = "m3/s2"
                    ,MeasureBaseForConversion = "m3/s2"
                    ,MeasureUom = "L/s2"
            };
            volumePerTimePerVolume = 
                new MeasureClass("volume per time per volume")
                {
                    MeasureRepresentativeUOM = "bbl/d.acre.ft"
                    ,MeasureBaseForConversion = "bbl/d.acre.ft"
                    ,MeasureUom = "bbl/d.acre.ft"
            };
            volumePerVolume = 
                new MeasureClass("volume per volume")
                {
                    MeasureRepresentativeUOM = "Euc"
                    ,MeasureBaseForConversion = "Euc"
                    ,MeasureUom = "%"
            };
            volumetricHeatTransferCoefficient = 
                new MeasureClass("volumetric heat transfer coefficient")
                {
                    MeasureRepresentativeUOM = "W/m3.K"
                    ,MeasureBaseForConversion = "W/m3.K"
                    ,MeasureUom = "Btu/hr.ft3.degF"
            };
            volumetricThermalExpansion = 
                new MeasureClass("volumetric thermal expansion")
                {
                    MeasureRepresentativeUOM = "1/K"
                    ,MeasureBaseForConversion = "1/K"
                    ,MeasureUom = "1/K"
            };
            work = 
                new MeasureClass("work")
                {
                    MeasureRepresentativeUOM = "J"
                    ,MeasureBaseForConversion = "J"
                    ,MeasureUom = "Btu"
            };
            unknown = 
                new MeasureClass("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
            };
        }

        /// <summary>
        /// Gets a MeasureClass by name
        /// </summary>
        /// <param name="name">The name of the MeasureClass to return</param>
        /// <returns>The MeasureClass represented by 'name'</returns>
        public static MeasureClass GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(MeasureClass)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(MeasureClass)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (MeasureClass)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static NameTagLocation body;
        /// <summary>
        /// The body of the equipment. For tubular components this specifies a location toward the middle of the component. 
        /// </summary>
        [EnumValueNameAttribute("body")]
        public static NameTagLocation Body
        {
            get 
            {
                return body;
            }
        }

        private readonly static NameTagLocation box;
        /// <summary>
        /// The female threaded end of a device.
        /// </summary>
        [EnumValueNameAttribute("box")]
        public static NameTagLocation Box
        {
            get 
            {
                return box;
            }
        }

        private readonly static NameTagLocation pin;
        /// <summary>
        /// The male threaded end of a device.
        /// </summary>
        [EnumValueNameAttribute("pin")]
        public static NameTagLocation Pin
        {
            get 
            {
                return pin;
            }
        }

        private readonly static NameTagLocation other;
        /// <summary>
        /// This, by exclusion, tells a user to look elsewhere than on the body or near the ends of a component.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static NameTagLocation Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static NameTagLocation unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static NameTagLocation Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static NameTagLocation()
        {
            body = 
                new NameTagLocation("body")
                {
                    Description = "The body of the equipment. For tubular components this specifies a location toward the middle of the component. "
            };
            box = 
                new NameTagLocation("box")
                {
                    Description = "The female threaded end of a device."
            };
            pin = 
                new NameTagLocation("pin")
                {
                    Description = "The male threaded end of a device."
            };
            other = 
                new NameTagLocation("other")
                {
                    Description = "This, by exclusion, tells a user to look elsewhere than on the body or near the ends of a component."
            };
            unknown = 
                new NameTagLocation("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a NameTagLocation by name
        /// </summary>
        /// <param name="name">The name of the NameTagLocation to return</param>
        /// <returns>The NameTagLocation represented by 'name'</returns>
        public static NameTagLocation GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(NameTagLocation)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(NameTagLocation)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (NameTagLocation)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static NameTagNumberingScheme epcSixFour;
        /// <summary>
        /// RFID - Electronic Product Code, 64 bit.
        /// </summary>
        [EnumValueNameAttribute("EPC64")]
        public static NameTagNumberingScheme EpcSixFour
        {
            get 
            {
                return epcSixFour;
            }
        }

        private readonly static NameTagNumberingScheme epcNineSix;
        /// <summary>
        /// RFID - Electronic Product Code, 96 bit.
        /// </summary>
        [EnumValueNameAttribute("EPC96")]
        public static NameTagNumberingScheme EpcNineSix
        {
            get 
            {
                return epcNineSix;
            }
        }

        private readonly static NameTagNumberingScheme msrcid;
        /// <summary>
        /// RFID - Merrick Systems Rapid Component Identification.
        /// </summary>
        [EnumValueNameAttribute("MSRCID")]
        public static NameTagNumberingScheme Msrcid
        {
            get 
            {
                return msrcid;
            }
        }

        private readonly static NameTagNumberingScheme ansiaimbcTwo;
        /// <summary>
        /// Barcode - 1995, Uniform Symbology Specification
        /// </summary>
        [EnumValueNameAttribute("ANSI/AIM-BC2")]
        public static NameTagNumberingScheme AnsiaimbcTwo
        {
            get 
            {
                return ansiaimbcTwo;
            }
        }

        private readonly static NameTagNumberingScheme ansiaimbcSix;
        /// <summary>
        /// Barcode - 1995, Uniform Symbology Multi Row Specification
        /// </summary>
        [EnumValueNameAttribute("ANSI/AIM-BC6")]
        public static NameTagNumberingScheme AnsiaimbcSix
        {
            get 
            {
                return ansiaimbcSix;
            }
        }

        private readonly static NameTagNumberingScheme ansiaimbcOneZero;
        /// <summary>
        /// Barcode - 1996, International Symbology Specification - MaxiCode
        /// </summary>
        [EnumValueNameAttribute("ANSI/AIM-BC10")]
        public static NameTagNumberingScheme AnsiaimbcOneZero
        {
            get 
            {
                return ansiaimbcOneZero;
            }
        }

        private readonly static NameTagNumberingScheme eanucc;
        /// <summary>
        /// Barcode - Composite Symbology
        /// </summary>
        [EnumValueNameAttribute("EAN.UCC")]
        public static NameTagNumberingScheme Eanucc
        {
            get 
            {
                return eanucc;
            }
        }

        private readonly static NameTagNumberingScheme fTwof;
        /// <summary>
        /// Magnetic - ISO/IEC 7811
        /// </summary>
        [EnumValueNameAttribute("F2F")]
        public static NameTagNumberingScheme FTwof
        {
            get 
            {
                return fTwof;
            }
        }

        private readonly static NameTagNumberingScheme mfm;
        /// <summary>
        /// Magnetic - 'Modified Frequency Modulation for Magnetic Stripes' standard developed by AIM Inc.
        /// </summary>
        [EnumValueNameAttribute("MFM")]
        public static NameTagNumberingScheme Mfm
        {
            get 
            {
                return mfm;
            }
        }

        private readonly static NameTagNumberingScheme serialNumber;
        /// <summary>
        /// Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the 'tag'. 
        /// </summary>
        [EnumValueNameAttribute("serial number")]
        public static NameTagNumberingScheme SerialNumber
        {
            get 
            {
                return serialNumber;
            }
        }

        private readonly static NameTagNumberingScheme unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static NameTagNumberingScheme Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static NameTagNumberingScheme()
        {
            epcSixFour = 
                new NameTagNumberingScheme("EPC64")
                {
                    Description = "RFID - Electronic Product Code, 64 bit."
            };
            epcNineSix = 
                new NameTagNumberingScheme("EPC96")
                {
                    Description = "RFID - Electronic Product Code, 96 bit."
            };
            msrcid = 
                new NameTagNumberingScheme("MSRCID")
                {
                    Description = "RFID - Merrick Systems Rapid Component Identification."
            };
            ansiaimbcTwo = 
                new NameTagNumberingScheme("ANSI/AIM-BC2")
                {
                    Description = "Barcode - 1995, Uniform Symbology Specification"
            };
            ansiaimbcSix = 
                new NameTagNumberingScheme("ANSI/AIM-BC6")
                {
                    Description = "Barcode - 1995, Uniform Symbology Multi Row Specification"
            };
            ansiaimbcOneZero = 
                new NameTagNumberingScheme("ANSI/AIM-BC10")
                {
                    Description = "Barcode - 1996, International Symbology Specification - MaxiCode"
            };
            eanucc = 
                new NameTagNumberingScheme("EAN.UCC")
                {
                    Description = "Barcode - Composite Symbology"
            };
            fTwof = 
                new NameTagNumberingScheme("F2F")
                {
                    Description = "Magnetic - ISO/IEC 7811"
            };
            mfm = 
                new NameTagNumberingScheme("MFM")
                {
                    Description = "Magnetic - 'Modified Frequency Modulation for Magnetic Stripes' standard developed by AIM Inc."
            };
            serialNumber = 
                new NameTagNumberingScheme("serial number")
                {
                    Description = "Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the 'tag'. "
            };
            unknown = 
                new NameTagNumberingScheme("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a NameTagNumberingScheme by name
        /// </summary>
        /// <param name="name">The name of the NameTagNumberingScheme to return</param>
        /// <returns>The NameTagNumberingScheme represented by 'name'</returns>
        public static NameTagNumberingScheme GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(NameTagNumberingScheme)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(NameTagNumberingScheme)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (NameTagNumberingScheme)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static NameTagTechnology tagged;
        /// <summary>
        /// Independent identification components attached or embedded to a larger component for purposes of identification of the larger component. Tags typically use electronic, radio or sound based technologies and that require a special non-optical device to read them. Radio Frequency Identification (RFID tags) are of this type, as are some magnetic and sound based identification technologies. 
        /// </summary>
        [EnumValueNameAttribute("tagged")]
        public static NameTagTechnology Tagged
        {
            get 
            {
                return tagged;
            }
        }

        private readonly static NameTagTechnology labeled;
        /// <summary>
        /// An optical label attached to a component. The label may be glued, riveted or attached by some other method and may contain a serial number, barcode or other optically recognized information. Note that a label may possibly have a combination of identifiers associated with it, such as a serial number, a barcode and an embedded RFID identifier. This would generate three nameTags for the one physical label, two of type 'label' for the barcode and serial number and one of type 'tagged' for the RFID identifier. 
        /// </summary>
        [EnumValueNameAttribute("labeled")]
        public static NameTagTechnology Labeled
        {
            get 
            {
                return labeled;
            }
        }

        private readonly static NameTagTechnology intrinsic;
        /// <summary>
        /// Identification technologies where the intrinsic properties of the component to be identified contain the identification information and no other unique code has been added. For example, some magnetic identification technologies use grooves machined into a component. Some components may also be identified, for example, by their individual sonic signature or optical profile. 
        /// </summary>
        [EnumValueNameAttribute("intrinsic")]
        public static NameTagTechnology Intrinsic
        {
            get 
            {
                return intrinsic;
            }
        }

        private readonly static NameTagTechnology stamped;
        /// <summary>
        /// An identification code physically stamped into the base material of the component to be identified. Note that if a serial number is stamped into a label attached to a component, 'labeled' should be used and not 'stamped'. Stamped identifiers can wear off but can not fall off. 
        /// </summary>
        [EnumValueNameAttribute("stamped")]
        public static NameTagTechnology Stamped
        {
            get 
            {
                return stamped;
            }
        }

        private readonly static NameTagTechnology painted;
        /// <summary>
        /// Painted or stenciled on the material. 
        /// </summary>
        [EnumValueNameAttribute("painted")]
        public static NameTagTechnology Painted
        {
            get 
            {
                return painted;
            }
        }

        private readonly static NameTagTechnology temporary;
        /// <summary>
        /// Temporary identification codes marked with grease pencil, chalk, or such.
        /// </summary>
        [EnumValueNameAttribute("temporary")]
        public static NameTagTechnology Temporary
        {
            get 
            {
                return temporary;
            }
        }

        private readonly static NameTagTechnology unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static NameTagTechnology Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static NameTagTechnology()
        {
            tagged = 
                new NameTagTechnology("tagged")
                {
                    Description = "Independent identification components attached or embedded to a larger component for purposes of identification of the larger component. Tags typically use electronic, radio or sound based technologies and that require a special non-optical device to read them. Radio Frequency Identification (RFID tags) are of this type, as are some magnetic and sound based identification technologies. "
            };
            labeled = 
                new NameTagTechnology("labeled")
                {
                    Description = "An optical label attached to a component. The label may be glued, riveted or attached by some other method and may contain a serial number, barcode or other optically recognized information. Note that a label may possibly have a combination of identifiers associated with it, such as a serial number, a barcode and an embedded RFID identifier. This would generate three nameTags for the one physical label, two of type 'label' for the barcode and serial number and one of type 'tagged' for the RFID identifier. "
            };
            intrinsic = 
                new NameTagTechnology("intrinsic")
                {
                    Description = "Identification technologies where the intrinsic properties of the component to be identified contain the identification information and no other unique code has been added. For example, some magnetic identification technologies use grooves machined into a component. Some components may also be identified, for example, by their individual sonic signature or optical profile. "
            };
            stamped = 
                new NameTagTechnology("stamped")
                {
                    Description = "An identification code physically stamped into the base material of the component to be identified. Note that if a serial number is stamped into a label attached to a component, 'labeled' should be used and not 'stamped'. Stamped identifiers can wear off but can not fall off. "
            };
            painted = 
                new NameTagTechnology("painted")
                {
                    Description = "Painted or stenciled on the material. "
            };
            temporary = 
                new NameTagTechnology("temporary")
                {
                    Description = "Temporary identification codes marked with grease pencil, chalk, or such."
            };
            unknown = 
                new NameTagTechnology("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a NameTagTechnology by name
        /// </summary>
        /// <param name="name">The name of the NameTagTechnology to return</param>
        /// <returns>The NameTagTechnology represented by 'name'</returns>
        public static NameTagTechnology GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(NameTagTechnology)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(NameTagTechnology)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (NameTagTechnology)ev;
                    }
                }
            }
            
            return null;
        }
    }

}
