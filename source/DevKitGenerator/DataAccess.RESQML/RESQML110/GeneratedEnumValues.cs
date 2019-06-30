using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.RESQML110
{
    /// <summary>
    /// The names of agreed extensions to WITSML.
    ///		This list may be locally extended but it is recommended that new names be
    ///		approved by the WITSML SIG before use.
    ///		Each standard name must define its data type.
    ///		For string types, the maximum length must be defined in number of characters.
    ///		For measures, the expected measure class must be defined.
    /// </summary>
    [System.SerializableAttribute()]
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
    /// Defines classes of measures and their allowed units of measures. For a value whose underlying meaning conforms to one of these classes, any specified unit of measure must conform to the defined list. These are copied from the Energistics (POSC) Units Classes v2.2.
    /// </summary>
    [System.SerializableAttribute()]
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
                    MeasureBaseForConversion = "Gy"
                    ,Description = "The amount of energy absorbed per mass."
            };
            accelerationLinear = 
                new MeasureClass("acceleration linear")
                {
                    MeasureBaseForConversion = "m/s2"
            };
            activityOfRadioactivity = 
                new MeasureClass("activity (of radioactivity)")
                {
                    MeasureBaseForConversion = "Bq"
                    ,Description = "A measure of the radiation being emitted."
            };
            concentrationOfB = 
                new MeasureClass("concentration of B")
                {
                    MeasureBaseForConversion = "mol/m3"
                    ,Description = "molar concentration of a substance"
            };
            amountOfSubstance = 
                new MeasureClass("amount of substance")
                {
                    MeasureBaseForConversion = "mol"
                    ,Description = "molar amount of a substance"
            };
            anglePerLength = 
                new MeasureClass("angle per length")
                {
                    MeasureBaseForConversion = "rad/m"
            };
            anglePerTime = 
                new MeasureClass("angle per time")
                {
                    MeasureBaseForConversion = "rad/s"
                    ,Description = "The angular velocity. The rate of change of an angle."
            };
            anglePerVolume = 
                new MeasureClass("angle per volume")
                {
                    MeasureBaseForConversion = "rad/m3"
            };
            angularAcceleration = 
                new MeasureClass("angular acceleration")
                {
                    MeasureBaseForConversion = "rad/s2"
            };
            area = 
                new MeasureClass("area")
                {
                    MeasureBaseForConversion = "m2"
            };
            areaPerArea = 
                new MeasureClass("area per area")
                {
                    MeasureBaseForConversion = "Euc"
            };
            areaPerVolume = 
                new MeasureClass("area per volume")
                {
                    MeasureBaseForConversion = "1/m"
            };
            attenuation = 
                new MeasureClass("attenuation")
                {
                    MeasureBaseForConversion = "B/O"
                    ,Description = "A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave."
            };
            attenuationPerLength = 
                new MeasureClass("attenuation per length")
                {
                    MeasureBaseForConversion = "B/m"
            };
            capacitance = 
                new MeasureClass("capacitance")
                {
                    MeasureBaseForConversion = "F"
            };
            chargeDensity = 
                new MeasureClass("charge density")
                {
                    MeasureBaseForConversion = "C/m3"
            };
            chemicalPotential = 
                new MeasureClass("chemical potential")
                {
                    MeasureBaseForConversion = "J/mol"
            };
            compressibility = 
                new MeasureClass("compressibility")
                {
                    MeasureBaseForConversion = "1/Pa"
            };
            conductivity = 
                new MeasureClass("conductivity")
                {
                    MeasureBaseForConversion = "S/m"
            };
            crossSectionAbsorption = 
                new MeasureClass("cross section absorption")
                {
                    MeasureBaseForConversion = "m2/mol"
            };
            currentDensity = 
                new MeasureClass("current density")
                {
                    MeasureBaseForConversion = "A/m2"
            };
            darcyFlowCoefficient = 
                new MeasureClass("Darcy flow coefficient")
                {
                    MeasureBaseForConversion = "Pa/m3"
            };
            dataTransmissionSpeed = 
                new MeasureClass("data transmission speed")
                {
                    MeasureBaseForConversion = "bps"
                    ,Description = "used primarily for computer transmission rates."
            };
            deltaTemperature = 
                new MeasureClass("delta temperature")
                {
                    MeasureBaseForConversion = "K"
                    ,Description = "Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures."
            };
            density = 
                new MeasureClass("density")
                {
                    MeasureBaseForConversion = "kg/m3"
            };
            diffusionCoefficient = 
                new MeasureClass("diffusion coefficient")
                {
                    MeasureBaseForConversion = "m2/s"
            };
            digitalStorage = 
                new MeasureClass("digital storage")
                {
                    MeasureBaseForConversion = "byte"
            };
            dimensionless = 
                new MeasureClass("dimensionless")
                {
                    MeasureBaseForConversion = "Euc"
                    ,Description = "A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass."
            };
            doseEquivalent = 
                new MeasureClass("dose equivalent")
                {
                    MeasureBaseForConversion = "Sv"
            };
            doseEquivalentRate = 
                new MeasureClass("dose equivalent rate")
                {
                    MeasureBaseForConversion = "Sv/s"
            };
            dynamicViscosity = 
                new MeasureClass("dynamic viscosity")
                {
                    MeasureBaseForConversion = "Pa.s"
            };
            electricCharge = 
                new MeasureClass("electric charge")
                {
                    MeasureBaseForConversion = "C"
            };
            electricConductance = 
                new MeasureClass("electric conductance")
                {
                    MeasureBaseForConversion = "S"
            };
            electricCurrent = 
                new MeasureClass("electric current")
                {
                    MeasureBaseForConversion = "A"
            };
            electricDipoleMoment = 
                new MeasureClass("electric dipole moment")
                {
                    MeasureBaseForConversion = "C.m"
            };
            electricFieldStrength = 
                new MeasureClass("electric field strength")
                {
                    MeasureBaseForConversion = "V/m"
            };
            electricPolarization = 
                new MeasureClass("electric polarization")
                {
                    MeasureBaseForConversion = "C/m2"
            };
            electricPotential = 
                new MeasureClass("electric potential")
                {
                    MeasureBaseForConversion = "V"
            };
            electricalResistivity = 
                new MeasureClass("electrical resistivity")
                {
                    MeasureBaseForConversion = "ohm.m"
            };
            electrochemicalEquivalent = 
                new MeasureClass("electrochemical equivalent")
                {
                    MeasureBaseForConversion = "eq"
                    ,Description = "An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered."
            };
            electromagneticMoment = 
                new MeasureClass("electromagnetic moment")
                {
                    MeasureBaseForConversion = "A.m2"
            };
            energyLengthPerArea = 
                new MeasureClass("energy length per area")
                {
                    MeasureBaseForConversion = "N"
            };
            energyLengthPerTimeAreaTemperature = 
                new MeasureClass("energy length per time area temperature")
                {
                    MeasureBaseForConversion = "W/m.K"
            };
            energyPerArea = 
                new MeasureClass("energy per area")
                {
                    MeasureBaseForConversion = "N/m"
            };
            energyPerLength = 
                new MeasureClass("energy per length")
                {
                    MeasureBaseForConversion = "N"
            };
            equivalentPerMass = 
                new MeasureClass("equivalent per mass")
                {
                    MeasureBaseForConversion = "eq/kg"
            };
            equivalentPerVolume = 
                new MeasureClass("equivalent per volume")
                {
                    MeasureBaseForConversion = "eq/m3"
            };
            exposureRadioactivity = 
                new MeasureClass("exposure (radioactivity)")
                {
                    MeasureBaseForConversion = "C/kg"
            };
            force = 
                new MeasureClass("force")
                {
                    MeasureBaseForConversion = "N"
            };
            forceArea = 
                new MeasureClass("force area")
                {
                    MeasureBaseForConversion = "N.m2"
            };
            forceLengthPerLength = 
                new MeasureClass("force length per length")
                {
                    MeasureBaseForConversion = "N"
            };
            forcePerForce = 
                new MeasureClass("force per force")
                {
                    MeasureBaseForConversion = "Euc"
            };
            forcePerLength = 
                new MeasureClass("force per length")
                {
                    MeasureBaseForConversion = "N/m"
            };
            forcePerVolume = 
                new MeasureClass("force per volume")
                {
                    MeasureBaseForConversion = "N/m3"
            };
            frequency = 
                new MeasureClass("frequency")
                {
                    MeasureBaseForConversion = "Hz"
            };
            frequencyInterval = 
                new MeasureClass("frequency interval")
                {
                    MeasureBaseForConversion = "O"
                    ,Description = "An octave is a doubling of a frquency."
            };
            gammaRayApiUnit = 
                new MeasureClass("gamma ray API unit")
                {
                    MeasureBaseForConversion = "gAPI"
                    ,Description = "This class is defined by the API, and is used for units of gamma ray log response."
            };
            heatCapacity = 
                new MeasureClass("heat capacity")
                {
                    MeasureBaseForConversion = "J/K"
            };
            heatFlowRate = 
                new MeasureClass("heat flow rate")
                {
                    MeasureBaseForConversion = "W"
            };
            heatTransferCoefficient = 
                new MeasureClass("heat transfer coefficient")
                {
                    MeasureBaseForConversion = "W/m2.K"
            };
            illuminance = 
                new MeasureClass("illuminance")
                {
                    MeasureBaseForConversion = "lx"
            };
            irradiance = 
                new MeasureClass("irradiance")
                {
                    MeasureBaseForConversion = "W/m2"
            };
            isothermalCompressibility = 
                new MeasureClass("isothermal compressibility")
                {
                    MeasureBaseForConversion = "m3/J"
            };
            kinematicViscosity = 
                new MeasureClass("kinematic viscosity")
                {
                    MeasureBaseForConversion = "m2/s"
            };
            length = 
                new MeasureClass("length")
                {
                    MeasureBaseForConversion = "m"
            };
            lengthPerLength = 
                new MeasureClass("length per length")
                {
                    MeasureBaseForConversion = "Euc"
            };
            lengthPerTemperature = 
                new MeasureClass("length per temperature")
                {
                    MeasureBaseForConversion = "m/K"
            };
            lengthPerVolume = 
                new MeasureClass("length per volume")
                {
                    MeasureBaseForConversion = "1/m2"
            };
            levelOfPowerIntensity = 
                new MeasureClass("level of power intensity")
                {
                    MeasureBaseForConversion = "B"
            };
            lightExposure = 
                new MeasureClass("light exposure")
                {
                    MeasureBaseForConversion = "lx.s"
            };
            massPerLength = 
                new MeasureClass("mass per length")
                {
                    MeasureBaseForConversion = "kg/m"
            };
            linearThermalExpansion = 
                new MeasureClass("linear thermal expansion")
                {
                    MeasureBaseForConversion = "1/K"
            };
            luminance = 
                new MeasureClass("luminance")
                {
                    MeasureBaseForConversion = "cd/m2"
            };
            luminousEfficacy = 
                new MeasureClass("luminous efficacy")
                {
                    MeasureBaseForConversion = "lm/W"
            };
            luminousFlux = 
                new MeasureClass("luminous flux")
                {
                    MeasureBaseForConversion = "lm"
            };
            luminousIntensity = 
                new MeasureClass("luminous intensity")
                {
                    MeasureBaseForConversion = "cd"
            };
            magneticDipoleMoment = 
                new MeasureClass("magnetic dipole moment")
                {
                    MeasureBaseForConversion = "Wb.m"
            };
            magneticFieldStrength = 
                new MeasureClass("magnetic field strength")
                {
                    MeasureBaseForConversion = "A/m"
            };
            magneticFlux = 
                new MeasureClass("magnetic flux")
                {
                    MeasureBaseForConversion = "Wb"
            };
            magneticInduction = 
                new MeasureClass("magnetic induction")
                {
                    MeasureBaseForConversion = "T"
            };
            magneticPermeability = 
                new MeasureClass("magnetic permeability")
                {
                    MeasureBaseForConversion = "H/m"
            };
            magneticVectorPotential = 
                new MeasureClass("magnetic vector potential")
                {
                    MeasureBaseForConversion = "Wb/m"
            };
            mass = 
                new MeasureClass("mass")
                {
                    MeasureBaseForConversion = "kg"
            };
            massAttenuationCoefficient = 
                new MeasureClass("mass attenuation coefficient")
                {
                    MeasureBaseForConversion = "m2/kg"
            };
            massFlowRate = 
                new MeasureClass("mass flow rate")
                {
                    MeasureBaseForConversion = "kg/s"
            };
            massLength = 
                new MeasureClass("mass length")
                {
                    MeasureBaseForConversion = "kg.m"
            };
            massPerEnergy = 
                new MeasureClass("mass per energy")
                {
                    MeasureBaseForConversion = "kg/J"
            };
            massPerTimePerArea = 
                new MeasureClass("mass per time per area")
                {
                    MeasureBaseForConversion = "kg/m2.s"
            };
            massPerTimePerLength = 
                new MeasureClass("mass per time per length")
                {
                    MeasureBaseForConversion = "Pa.s"
            };
            massPerVolumePerLength = 
                new MeasureClass("mass per volume per length")
                {
                    MeasureBaseForConversion = "kg/m4"
            };
            massConcentration = 
                new MeasureClass("mass concentration")
                {
                    MeasureBaseForConversion = "Euc"
            };
            mobility = 
                new MeasureClass("mobility")
                {
                    MeasureBaseForConversion = "m2/Pa.s"
            };
            modulusOfCompression = 
                new MeasureClass("modulus of compression")
                {
                    MeasureBaseForConversion = "J/m3"
            };
            molarHeatCapacity = 
                new MeasureClass("molar heat capacity")
                {
                    MeasureBaseForConversion = "J/mol.K"
            };
            molarVolume = 
                new MeasureClass("molar volume")
                {
                    MeasureBaseForConversion = "m3/mol"
            };
            molePerArea = 
                new MeasureClass("mole per area")
                {
                    MeasureBaseForConversion = "mol/m2"
            };
            molePerTime = 
                new MeasureClass("mole per time")
                {
                    MeasureBaseForConversion = "mol/s"
            };
            molePerTimePerArea = 
                new MeasureClass("mole per time per area")
                {
                    MeasureBaseForConversion = "mol/m2.s"
            };
            momentOfForce = 
                new MeasureClass("moment of force")
                {
                    MeasureBaseForConversion = "J"
            };
            momentOfInertia = 
                new MeasureClass("moment of inertia")
                {
                    MeasureBaseForConversion = "kg.m2"
            };
            momentOfSection = 
                new MeasureClass("moment of section")
                {
                    MeasureBaseForConversion = "m4"
            };
            momentum = 
                new MeasureClass("momentum")
                {
                    MeasureBaseForConversion = "kg.m/s"
            };
            neutronApiUnit = 
                new MeasureClass("neutron API unit")
                {
                    MeasureBaseForConversion = "nAPI"
            };
            nondarcyFlowCoefficient = 
                new MeasureClass("nonDarcy flow coefficient")
                {
                    MeasureBaseForConversion = "Pa.s/m6"
            };
            operationsPerTime = 
                new MeasureClass("operations per time")
                {
                    MeasureBaseForConversion = "1/s"
            };
            parachor = 
                new MeasureClass("parachor")
                {
                    MeasureBaseForConversion = "N4/kg.m7"
            };
            perArea = 
                new MeasureClass("per area")
                {
                    MeasureBaseForConversion = "1/m2"
            };
            perElectricPotential = 
                new MeasureClass("per electric potential")
                {
                    MeasureBaseForConversion = "1/V"
            };
            perForce = 
                new MeasureClass("per force")
                {
                    MeasureBaseForConversion = "1/N"
            };
            perLength = 
                new MeasureClass("per length")
                {
                    MeasureBaseForConversion = "1/m"
            };
            perMass = 
                new MeasureClass("per mass")
                {
                    MeasureBaseForConversion = "1/kg"
            };
            perVolume = 
                new MeasureClass("per volume")
                {
                    MeasureBaseForConversion = "1/m3"
            };
            permeabilityLength = 
                new MeasureClass("permeability length")
                {
                    MeasureBaseForConversion = "m3"
            };
            permeabilityRock = 
                new MeasureClass("permeability rock")
                {
                    MeasureBaseForConversion = "m2"
            };
            permeance = 
                new MeasureClass("permeance")
                {
                    MeasureBaseForConversion = "H"
            };
            permittivity = 
                new MeasureClass("permittivity")
                {
                    MeasureBaseForConversion = "F/m"
            };
            ph = 
                new MeasureClass("pH")
                {
                    MeasureBaseForConversion = "pH"
                    ,Description = "The pH is a class that measures the hydrogen ion concentration (acidity)."
            };
            planeAngle = 
                new MeasureClass("plane angle")
                {
                    MeasureBaseForConversion = "rad"
            };
            potentialDifferencePerPowerDrop = 
                new MeasureClass("potential difference per power drop")
                {
                    MeasureBaseForConversion = "V/B"
            };
            power = 
                new MeasureClass("power")
                {
                    MeasureBaseForConversion = "W"
            };
            powerPerVolume = 
                new MeasureClass("power per volume")
                {
                    MeasureBaseForConversion = "W/m3"
            };
            pressure = 
                new MeasureClass("pressure")
                {
                    MeasureBaseForConversion = "Pa"
            };
            pressurePerTime = 
                new MeasureClass("pressure per time")
                {
                    MeasureBaseForConversion = "Pa/s"
            };
            pressureSquared = 
                new MeasureClass("pressure squared")
                {
                    MeasureBaseForConversion = "Pa2"
            };
            pressureSquaredPerForceTimePerArea = 
                new MeasureClass("pressure squared per force time per area")
                {
                    MeasureBaseForConversion = "Pa/s"
            };
            pressureTimePerVolume = 
                new MeasureClass("pressure time per volume")
                {
                    MeasureBaseForConversion = "Pa.s/m3"
            };
            productivityIndex = 
                new MeasureClass("productivity index")
                {
                    MeasureBaseForConversion = "m3/Pa.s"
            };
            quantityOfLight = 
                new MeasureClass("quantity of light")
                {
                    MeasureBaseForConversion = "lm.s"
            };
            radiance = 
                new MeasureClass("radiance")
                {
                    MeasureBaseForConversion = "W/m2.sr"
            };
            radiantIntensity = 
                new MeasureClass("radiant intensity")
                {
                    MeasureBaseForConversion = "W/sr"
            };
            relativePower = 
                new MeasureClass("relative power")
                {
                    MeasureBaseForConversion = "Euc"
            };
            relativeTime = 
                new MeasureClass("relative time")
                {
                    MeasureBaseForConversion = "Euc"
            };
            reluctance = 
                new MeasureClass("reluctance")
                {
                    MeasureBaseForConversion = "1/H"
            };
            resistance = 
                new MeasureClass("resistance")
                {
                    MeasureBaseForConversion = "ohm"
            };
            resistivityPerLength = 
                new MeasureClass("resistivity per length")
                {
                    MeasureBaseForConversion = "ohm/m"
            };
            secondMomentOfArea = 
                new MeasureClass("second moment of area")
                {
                    MeasureBaseForConversion = "m4"
            };
            solidAngle = 
                new MeasureClass("solid angle")
                {
                    MeasureBaseForConversion = "sr"
            };
            specificActivityOfRadioactivity = 
                new MeasureClass("specific activity (of radioactivity)")
                {
                    MeasureBaseForConversion = "Bq/kg"
            };
            specificEnergy = 
                new MeasureClass("specific energy")
                {
                    MeasureBaseForConversion = "J/kg"
            };
            specificHeatCapacity = 
                new MeasureClass("specific heat capacity")
                {
                    MeasureBaseForConversion = "J/kg.K"
            };
            specificProductivityIndex = 
                new MeasureClass("specific productivity index")
                {
                    MeasureBaseForConversion = "m3/Pa2.s2"
            };
            specificVolume = 
                new MeasureClass("specific volume")
                {
                    MeasureBaseForConversion = "m3/kg"
            };
            standardVolume = 
                new MeasureClass("standard volume")
                {
                    MeasureBaseForConversion = "scm(15C)"
            };
            standardVolumePerArea = 
                new MeasureClass("standard volume per area")
                {
                    MeasureBaseForConversion = "scm(15C)/m2"
            };
            standardVolumePerTime = 
                new MeasureClass("standard volume per time")
                {
                    MeasureBaseForConversion = "scm(15C)/s"
            };
            standardVolumePerVolume = 
                new MeasureClass("standard volume per volume")
                {
                    MeasureBaseForConversion = "scm(15C)/m3"
            };
            surfaceDensity = 
                new MeasureClass("surface density")
                {
                    MeasureBaseForConversion = "kg/m2"
            };
            temperaturePerLength = 
                new MeasureClass("temperature per length")
                {
                    MeasureBaseForConversion = "K/m"
            };
            temperaturePerTime = 
                new MeasureClass("temperature per time")
                {
                    MeasureBaseForConversion = "K/s"
            };
            thermalConductance = 
                new MeasureClass("thermal conductance")
                {
                    MeasureBaseForConversion = "W/K"
            };
            thermalConductivity = 
                new MeasureClass("thermal conductivity")
                {
                    MeasureBaseForConversion = "W/m.K"
            };
            thermalDiffusivity = 
                new MeasureClass("thermal diffusivity")
                {
                    MeasureBaseForConversion = "m2/s"
            };
            thermalInsulance = 
                new MeasureClass("thermal insulance")
                {
                    MeasureBaseForConversion = "K.m2/W"
            };
            thermalResistance = 
                new MeasureClass("thermal resistance")
                {
                    MeasureBaseForConversion = "K/W"
            };
            thermodynamicTemperature = 
                new MeasureClass("thermodynamic temperature")
                {
                    MeasureBaseForConversion = "K"
            };
            time = 
                new MeasureClass("time")
                {
                    MeasureBaseForConversion = "s"
            };
            timePerLength = 
                new MeasureClass("time per length")
                {
                    MeasureBaseForConversion = "s/m"
            };
            timePerVolume = 
                new MeasureClass("time per volume")
                {
                    MeasureBaseForConversion = "s/m3"
            };
            unitProductivityIndex = 
                new MeasureClass("unit productivity index")
                {
                    MeasureBaseForConversion = "m2/Pa.s"
            };
            velocity = 
                new MeasureClass("velocity")
                {
                    MeasureBaseForConversion = "m/s"
            };
            volume = 
                new MeasureClass("volume")
                {
                    MeasureBaseForConversion = "m3"
            };
            volumeFlowRate = 
                new MeasureClass("volume flow rate")
                {
                    MeasureBaseForConversion = "m3/s"
            };
            volumeLengthPerTime = 
                new MeasureClass("volume length per time")
                {
                    MeasureBaseForConversion = "m4/s"
            };
            volumePerArea = 
                new MeasureClass("volume per area")
                {
                    MeasureBaseForConversion = "m"
            };
            volumePerLength = 
                new MeasureClass("volume per length")
                {
                    MeasureBaseForConversion = "m2"
            };
            volumePerStandardVolume = 
                new MeasureClass("volume per standard volume")
                {
                    MeasureBaseForConversion = "m3/scm(15C)"
            };
            volumePerTimePerArea = 
                new MeasureClass("volume per time per area")
                {
                    MeasureBaseForConversion = "m/s"
            };
            volumePerTimePerLength = 
                new MeasureClass("volume per time per length")
                {
                    MeasureBaseForConversion = "m2/s"
            };
            volumePerTimePerTime = 
                new MeasureClass("volume per time per time")
                {
                    MeasureBaseForConversion = "m3/s2"
            };
            volumePerTimePerVolume = 
                new MeasureClass("volume per time per volume")
                {
                    MeasureBaseForConversion = "1/s"
            };
            volumePerVolume = 
                new MeasureClass("volume per volume")
                {
                    MeasureBaseForConversion = "Euc"
            };
            volumetricHeatTransferCoefficient = 
                new MeasureClass("volumetric heat transfer coefficient")
                {
                    MeasureBaseForConversion = "W/m3.K"
            };
            volumetricThermalExpansion = 
                new MeasureClass("volumetric thermal expansion")
                {
                    MeasureBaseForConversion = "1/K"
            };
            work = 
                new MeasureClass("work")
                {
                    MeasureBaseForConversion = "J"
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
    /// Defines classes of properties. A property inherents the underlying characteristis of its parent but specializes its meaning.
    /// </summary>
    [System.SerializableAttribute()]
    public class ResqmlPropertyKind : Energistics.DataAccess.EnumValue.ResqmlPropertyKindEnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ResqmlPropertyKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ResqmlPropertyKind</param>
        public ResqmlPropertyKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ResqmlPropertyKinds
        /// </summary>
        /// <returns>The complete list of ResqmlPropertyKinds</returns>
        public static List<ResqmlPropertyKind> GetList()
        {
            return GetList<ResqmlPropertyKind>();
        }

        private readonly static ResqmlPropertyKind absorbedDose;
        /// <summary>
        /// The amount of energy absorbed per mass.
        /// </summary>
        [EnumValueNameAttribute("absorbed dose")]
        public static ResqmlPropertyKind AbsorbedDose
        {
            get 
            {
                return absorbedDose;
            }
        }

        private readonly static ResqmlPropertyKind accelerationLinear;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("acceleration linear")]
        public static ResqmlPropertyKind AccelerationLinear
        {
            get 
            {
                return accelerationLinear;
            }
        }

        private readonly static ResqmlPropertyKind activityOfRadioactivity;
        /// <summary>
        /// A measure of the radiation being emitted.
        /// </summary>
        [EnumValueNameAttribute("activity (of radioactivity)")]
        public static ResqmlPropertyKind ActivityOfRadioactivity
        {
            get 
            {
                return activityOfRadioactivity;
            }
        }

        private readonly static ResqmlPropertyKind amountOfSubstance;
        /// <summary>
        /// Molar amount of a substance.
        /// </summary>
        [EnumValueNameAttribute("amount of substance")]
        public static ResqmlPropertyKind AmountOfSubstance
        {
            get 
            {
                return amountOfSubstance;
            }
        }

        private readonly static ResqmlPropertyKind amplitude;
        /// <summary>
        /// Amplitude of the acoustic signal recorded. It is not a physical property, only a value.
        /// </summary>
        [EnumValueNameAttribute("amplitude")]
        public static ResqmlPropertyKind Amplitude
        {
            get 
            {
                return amplitude;
            }
        }

        private readonly static ResqmlPropertyKind anglePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per length")]
        public static ResqmlPropertyKind AnglePerLength
        {
            get 
            {
                return anglePerLength;
            }
        }

        private readonly static ResqmlPropertyKind anglePerTime;
        /// <summary>
        /// The angular velocity. The rate of change of an angle.
        /// </summary>
        [EnumValueNameAttribute("angle per time")]
        public static ResqmlPropertyKind AnglePerTime
        {
            get 
            {
                return anglePerTime;
            }
        }

        private readonly static ResqmlPropertyKind anglePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per volume")]
        public static ResqmlPropertyKind AnglePerVolume
        {
            get 
            {
                return anglePerVolume;
            }
        }

        private readonly static ResqmlPropertyKind angularAcceleration;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angular acceleration")]
        public static ResqmlPropertyKind AngularAcceleration
        {
            get 
            {
                return angularAcceleration;
            }
        }

        private readonly static ResqmlPropertyKind area;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area")]
        public static ResqmlPropertyKind Area
        {
            get 
            {
                return area;
            }
        }

        private readonly static ResqmlPropertyKind areaPerArea;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is area.
        /// </summary>
        [EnumValueNameAttribute("area per area")]
        public static ResqmlPropertyKind AreaPerArea
        {
            get 
            {
                return areaPerArea;
            }
        }

        private readonly static ResqmlPropertyKind areaPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area per volume")]
        public static ResqmlPropertyKind AreaPerVolume
        {
            get 
            {
                return areaPerVolume;
            }
        }

        private readonly static ResqmlPropertyKind attenuation;
        /// <summary>
        /// A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave.
        /// </summary>
        [EnumValueNameAttribute("attenuation")]
        public static ResqmlPropertyKind Attenuation
        {
            get 
            {
                return attenuation;
            }
        }

        private readonly static ResqmlPropertyKind attenuationPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("attenuation per length")]
        public static ResqmlPropertyKind AttenuationPerLength
        {
            get 
            {
                return attenuationPerLength;
            }
        }

        private readonly static ResqmlPropertyKind azimuth;
        /// <summary>
        /// Angle between the North and the projection of the normal to the horizon surface estimated on a local area of the interface.
        /// </summary>
        [EnumValueNameAttribute("azimuth")]
        public static ResqmlPropertyKind Azimuth
        {
            get 
            {
                return azimuth;
            }
        }

        private readonly static ResqmlPropertyKind bubblePointPressure;
        /// <summary>
        /// The pressure at which the first gas bubble appears while decreasing pressure on a fluid sample.
        /// </summary>
        [EnumValueNameAttribute("bubble point pressure")]
        public static ResqmlPropertyKind BubblePointPressure
        {
            get 
            {
                return bubblePointPressure;
            }
        }

        private readonly static ResqmlPropertyKind bulkModulus;
        /// <summary>
        /// Bulk modulus, K
        /// </summary>
        [EnumValueNameAttribute("bulk modulus")]
        public static ResqmlPropertyKind BulkModulus
        {
            get 
            {
                return bulkModulus;
            }
        }

        private readonly static ResqmlPropertyKind capacitance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("capacitance")]
        public static ResqmlPropertyKind Capacitance
        {
            get 
            {
                return capacitance;
            }
        }

        private readonly static ResqmlPropertyKind categorical;
        /// <summary>
        /// The abstract supertype of all enumerated string properties.
        /// </summary>
        [EnumValueNameAttribute("categorical")]
        public static ResqmlPropertyKind Categorical
        {
            get 
            {
                return categorical;
            }
        }

        private readonly static ResqmlPropertyKind cellLength;
        /// <summary>
        /// distance from cell face center to cell face center in the specified direction, DI, DJ, DK
        /// </summary>
        [EnumValueNameAttribute("cell length")]
        public static ResqmlPropertyKind CellLength
        {
            get 
            {
                return cellLength;
            }
        }

        private readonly static ResqmlPropertyKind chargeDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("charge density")]
        public static ResqmlPropertyKind ChargeDensity
        {
            get 
            {
                return chargeDensity;
            }
        }

        private readonly static ResqmlPropertyKind chemicalPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("chemical potential")]
        public static ResqmlPropertyKind ChemicalPotential
        {
            get 
            {
                return chemicalPotential;
            }
        }

        private readonly static ResqmlPropertyKind code;
        /// <summary>
        /// A discrete code.
        /// </summary>
        [EnumValueNameAttribute("code")]
        public static ResqmlPropertyKind Code
        {
            get 
            {
                return code;
            }
        }

        private readonly static ResqmlPropertyKind compressibility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("compressibility")]
        public static ResqmlPropertyKind Compressibility
        {
            get 
            {
                return compressibility;
            }
        }

        private readonly static ResqmlPropertyKind concentrationOfB;
        /// <summary>
        /// molar concentration of a substance.
        /// </summary>
        [EnumValueNameAttribute("concentration of B")]
        public static ResqmlPropertyKind ConcentrationOfB
        {
            get 
            {
                return concentrationOfB;
            }
        }

        private readonly static ResqmlPropertyKind conductivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("conductivity")]
        public static ResqmlPropertyKind Conductivity
        {
            get 
            {
                return conductivity;
            }
        }

        private readonly static ResqmlPropertyKind continuous;
        /// <summary>
        /// The abstract supertype of all floating point properties.
        /// </summary>
        [EnumValueNameAttribute("continuous")]
        public static ResqmlPropertyKind Continuous
        {
            get 
            {
                return continuous;
            }
        }

        private readonly static ResqmlPropertyKind crossSectionAbsorption;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("cross section absorption")]
        public static ResqmlPropertyKind CrossSectionAbsorption
        {
            get 
            {
                return crossSectionAbsorption;
            }
        }

        private readonly static ResqmlPropertyKind currentDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("current density")]
        public static ResqmlPropertyKind CurrentDensity
        {
            get 
            {
                return currentDensity;
            }
        }

        private readonly static ResqmlPropertyKind darcyFlowCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Darcy flow coefficient")]
        public static ResqmlPropertyKind DarcyFlowCoefficient
        {
            get 
            {
                return darcyFlowCoefficient;
            }
        }

        private readonly static ResqmlPropertyKind dataTransmissionSpeed;
        /// <summary>
        /// used primarily for computer transmission rates.
        /// </summary>
        [EnumValueNameAttribute("data transmission speed")]
        public static ResqmlPropertyKind DataTransmissionSpeed
        {
            get 
            {
                return dataTransmissionSpeed;
            }
        }

        private readonly static ResqmlPropertyKind deltaTemperature;
        /// <summary>
        /// Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures.
        /// </summary>
        [EnumValueNameAttribute("delta temperature")]
        public static ResqmlPropertyKind DeltaTemperature
        {
            get 
            {
                return deltaTemperature;
            }
        }

        private readonly static ResqmlPropertyKind density;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static ResqmlPropertyKind Density
        {
            get 
            {
                return density;
            }
        }

        private readonly static ResqmlPropertyKind depth;
        /// <summary>
        /// The perpendicular measurement downward from a surface. Also, the direct linear measurement from the point of viewing usually from front to back.
        /// </summary>
        [EnumValueNameAttribute("depth")]
        public static ResqmlPropertyKind Depth
        {
            get 
            {
                return depth;
            }
        }

        private readonly static ResqmlPropertyKind diffusionCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("diffusion coefficient")]
        public static ResqmlPropertyKind DiffusionCoefficient
        {
            get 
            {
                return diffusionCoefficient;
            }
        }

        private readonly static ResqmlPropertyKind digitalStorage;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("digital storage")]
        public static ResqmlPropertyKind DigitalStorage
        {
            get 
            {
                return digitalStorage;
            }
        }

        private readonly static ResqmlPropertyKind dimensionless;
        /// <summary>
        /// A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass.
        /// </summary>
        [EnumValueNameAttribute("dimensionless")]
        public static ResqmlPropertyKind Dimensionless
        {
            get 
            {
                return dimensionless;
            }
        }

        private readonly static ResqmlPropertyKind dip;
        /// <summary>
        /// In the azimuth direction, Angle between an horizon plane and an estimated plane on a local area of the interface.
        /// </summary>
        [EnumValueNameAttribute("dip")]
        public static ResqmlPropertyKind Dip
        {
            get 
            {
                return dip;
            }
        }

        private readonly static ResqmlPropertyKind discrete;
        /// <summary>
        /// The abstract supertype of all integer properties.
        /// </summary>
        [EnumValueNameAttribute("discrete")]
        public static ResqmlPropertyKind Discrete
        {
            get 
            {
                return discrete;
            }
        }

        private readonly static ResqmlPropertyKind doseEquivalent;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent")]
        public static ResqmlPropertyKind DoseEquivalent
        {
            get 
            {
                return doseEquivalent;
            }
        }

        private readonly static ResqmlPropertyKind doseEquivalentRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent rate")]
        public static ResqmlPropertyKind DoseEquivalentRate
        {
            get 
            {
                return doseEquivalentRate;
            }
        }

        private readonly static ResqmlPropertyKind dynamicViscosity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dynamic viscosity")]
        public static ResqmlPropertyKind DynamicViscosity
        {
            get 
            {
                return dynamicViscosity;
            }
        }

        private readonly static ResqmlPropertyKind electricCharge;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric charge")]
        public static ResqmlPropertyKind ElectricCharge
        {
            get 
            {
                return electricCharge;
            }
        }

        private readonly static ResqmlPropertyKind electricConductance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric conductance")]
        public static ResqmlPropertyKind ElectricConductance
        {
            get 
            {
                return electricConductance;
            }
        }

        private readonly static ResqmlPropertyKind electricCurrent;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric current")]
        public static ResqmlPropertyKind ElectricCurrent
        {
            get 
            {
                return electricCurrent;
            }
        }

        private readonly static ResqmlPropertyKind electricDipoleMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric dipole moment")]
        public static ResqmlPropertyKind ElectricDipoleMoment
        {
            get 
            {
                return electricDipoleMoment;
            }
        }

        private readonly static ResqmlPropertyKind electricFieldStrength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric field strength")]
        public static ResqmlPropertyKind ElectricFieldStrength
        {
            get 
            {
                return electricFieldStrength;
            }
        }

        private readonly static ResqmlPropertyKind electricPolarization;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric polarization")]
        public static ResqmlPropertyKind ElectricPolarization
        {
            get 
            {
                return electricPolarization;
            }
        }

        private readonly static ResqmlPropertyKind electricPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric potential")]
        public static ResqmlPropertyKind ElectricPotential
        {
            get 
            {
                return electricPotential;
            }
        }

        private readonly static ResqmlPropertyKind electricalResistivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electrical resistivity")]
        public static ResqmlPropertyKind ElectricalResistivity
        {
            get 
            {
                return electricalResistivity;
            }
        }

        private readonly static ResqmlPropertyKind electrochemicalEquivalent;
        /// <summary>
        /// An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered.
        /// </summary>
        [EnumValueNameAttribute("electrochemical equivalent")]
        public static ResqmlPropertyKind ElectrochemicalEquivalent
        {
            get 
            {
                return electrochemicalEquivalent;
            }
        }

        private readonly static ResqmlPropertyKind electromagneticMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electromagnetic moment")]
        public static ResqmlPropertyKind ElectromagneticMoment
        {
            get 
            {
                return electromagneticMoment;
            }
        }

        private readonly static ResqmlPropertyKind energyLengthPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per area")]
        public static ResqmlPropertyKind EnergyLengthPerArea
        {
            get 
            {
                return energyLengthPerArea;
            }
        }

        private readonly static ResqmlPropertyKind energyLengthPerTimeAreaTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per time area temperature")]
        public static ResqmlPropertyKind EnergyLengthPerTimeAreaTemperature
        {
            get 
            {
                return energyLengthPerTimeAreaTemperature;
            }
        }

        private readonly static ResqmlPropertyKind energyPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per area")]
        public static ResqmlPropertyKind EnergyPerArea
        {
            get 
            {
                return energyPerArea;
            }
        }

        private readonly static ResqmlPropertyKind energyPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per length")]
        public static ResqmlPropertyKind EnergyPerLength
        {
            get 
            {
                return energyPerLength;
            }
        }

        private readonly static ResqmlPropertyKind equivalentPerMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per mass")]
        public static ResqmlPropertyKind EquivalentPerMass
        {
            get 
            {
                return equivalentPerMass;
            }
        }

        private readonly static ResqmlPropertyKind equivalentPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per volume")]
        public static ResqmlPropertyKind EquivalentPerVolume
        {
            get 
            {
                return equivalentPerVolume;
            }
        }

        private readonly static ResqmlPropertyKind exposureRadioactivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("exposure (radioactivity)")]
        public static ResqmlPropertyKind ExposureRadioactivity
        {
            get 
            {
                return exposureRadioactivity;
            }
        }

        private readonly static ResqmlPropertyKind fluidVolume;
        /// <summary>
        /// Volume of fluid
        /// </summary>
        [EnumValueNameAttribute("fluid volume")]
        public static ResqmlPropertyKind FluidVolume
        {
            get 
            {
                return fluidVolume;
            }
        }

        private readonly static ResqmlPropertyKind force;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force")]
        public static ResqmlPropertyKind Force
        {
            get 
            {
                return force;
            }
        }

        private readonly static ResqmlPropertyKind forceArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force area")]
        public static ResqmlPropertyKind ForceArea
        {
            get 
            {
                return forceArea;
            }
        }

        private readonly static ResqmlPropertyKind forceLengthPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force length per length")]
        public static ResqmlPropertyKind ForceLengthPerLength
        {
            get 
            {
                return forceLengthPerLength;
            }
        }

        private readonly static ResqmlPropertyKind forcePerForce;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is force.
        /// </summary>
        [EnumValueNameAttribute("force per force")]
        public static ResqmlPropertyKind ForcePerForce
        {
            get 
            {
                return forcePerForce;
            }
        }

        private readonly static ResqmlPropertyKind forcePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per length")]
        public static ResqmlPropertyKind ForcePerLength
        {
            get 
            {
                return forcePerLength;
            }
        }

        private readonly static ResqmlPropertyKind forcePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per volume")]
        public static ResqmlPropertyKind ForcePerVolume
        {
            get 
            {
                return forcePerVolume;
            }
        }

        private readonly static ResqmlPropertyKind formationVolumeFactor;
        /// <summary>
        /// Ratio of volumes at subsurface and surface conditions
        /// </summary>
        [EnumValueNameAttribute("formation volume factor")]
        public static ResqmlPropertyKind FormationVolumeFactor
        {
            get 
            {
                return formationVolumeFactor;
            }
        }

        private readonly static ResqmlPropertyKind frequency;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("frequency")]
        public static ResqmlPropertyKind Frequency
        {
            get 
            {
                return frequency;
            }
        }

        private readonly static ResqmlPropertyKind frequencyInterval;
        /// <summary>
        /// An octave is a doubling of a frquency.
        /// </summary>
        [EnumValueNameAttribute("frequency interval")]
        public static ResqmlPropertyKind FrequencyInterval
        {
            get 
            {
                return frequencyInterval;
            }
        }

        private readonly static ResqmlPropertyKind gammaRayApiUnit;
        /// <summary>
        /// This class is defined by the API, and is used for units of gamma ray log response.
        /// </summary>
        [EnumValueNameAttribute("gamma ray API unit")]
        public static ResqmlPropertyKind GammaRayApiUnit
        {
            get 
            {
                return gammaRayApiUnit;
            }
        }

        private readonly static ResqmlPropertyKind heatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat capacity")]
        public static ResqmlPropertyKind HeatCapacity
        {
            get 
            {
                return heatCapacity;
            }
        }

        private readonly static ResqmlPropertyKind heatFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat flow rate")]
        public static ResqmlPropertyKind HeatFlowRate
        {
            get 
            {
                return heatFlowRate;
            }
        }

        private readonly static ResqmlPropertyKind heatTransferCoefficient;
        /// <summary>
        /// PRESSURE PER VELOCITY PER AREA
        /// </summary>
        [EnumValueNameAttribute("heat transfer coefficient")]
        public static ResqmlPropertyKind HeatTransferCoefficient
        {
            get 
            {
                return heatTransferCoefficient;
            }
        }

        private readonly static ResqmlPropertyKind illuminance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("illuminance")]
        public static ResqmlPropertyKind Illuminance
        {
            get 
            {
                return illuminance;
            }
        }

        private readonly static ResqmlPropertyKind index;
        /// <summary>
        /// Serial ordering
        /// </summary>
        [EnumValueNameAttribute("index")]
        public static ResqmlPropertyKind Index
        {
            get 
            {
                return index;
            }
        }

        private readonly static ResqmlPropertyKind irradiance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("irradiance")]
        public static ResqmlPropertyKind Irradiance
        {
            get 
            {
                return irradiance;
            }
        }

        private readonly static ResqmlPropertyKind isothermalCompressibility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("isothermal compressibility")]
        public static ResqmlPropertyKind IsothermalCompressibility
        {
            get 
            {
                return isothermalCompressibility;
            }
        }

        private readonly static ResqmlPropertyKind kinematicViscosity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kinematic viscosity")]
        public static ResqmlPropertyKind KinematicViscosity
        {
            get 
            {
                return kinematicViscosity;
            }
        }

        private readonly static ResqmlPropertyKind lambdaRho;
        /// <summary>
        /// Product of Lame constant and density, LR
        /// </summary>
        [EnumValueNameAttribute("Lambda Rho")]
        public static ResqmlPropertyKind LambdaRho
        {
            get 
            {
                return lambdaRho;
            }
        }

        private readonly static ResqmlPropertyKind lameConstant;
        /// <summary>
        /// Lame constant, Lambda
        /// </summary>
        [EnumValueNameAttribute("Lame constant")]
        public static ResqmlPropertyKind LameConstant
        {
            get 
            {
                return lameConstant;
            }
        }

        private readonly static ResqmlPropertyKind length;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length")]
        public static ResqmlPropertyKind Length
        {
            get 
            {
                return length;
            }
        }

        private readonly static ResqmlPropertyKind lengthPerLength;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is length.
        /// </summary>
        [EnumValueNameAttribute("length per length")]
        public static ResqmlPropertyKind LengthPerLength
        {
            get 
            {
                return lengthPerLength;
            }
        }

        private readonly static ResqmlPropertyKind lengthPerTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per temperature")]
        public static ResqmlPropertyKind LengthPerTemperature
        {
            get 
            {
                return lengthPerTemperature;
            }
        }

        private readonly static ResqmlPropertyKind lengthPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per volume")]
        public static ResqmlPropertyKind LengthPerVolume
        {
            get 
            {
                return lengthPerVolume;
            }
        }

        private readonly static ResqmlPropertyKind levelOfPowerIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("level of power intensity")]
        public static ResqmlPropertyKind LevelOfPowerIntensity
        {
            get 
            {
                return levelOfPowerIntensity;
            }
        }

        private readonly static ResqmlPropertyKind lightExposure;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("light exposure")]
        public static ResqmlPropertyKind LightExposure
        {
            get 
            {
                return lightExposure;
            }
        }

        private readonly static ResqmlPropertyKind linearThermalExpansion;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("linear thermal expansion")]
        public static ResqmlPropertyKind LinearThermalExpansion
        {
            get 
            {
                return linearThermalExpansion;
            }
        }

        private readonly static ResqmlPropertyKind luminance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminance")]
        public static ResqmlPropertyKind Luminance
        {
            get 
            {
                return luminance;
            }
        }

        private readonly static ResqmlPropertyKind luminousEfficacy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous efficacy")]
        public static ResqmlPropertyKind LuminousEfficacy
        {
            get 
            {
                return luminousEfficacy;
            }
        }

        private readonly static ResqmlPropertyKind luminousFlux;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous flux")]
        public static ResqmlPropertyKind LuminousFlux
        {
            get 
            {
                return luminousFlux;
            }
        }

        private readonly static ResqmlPropertyKind luminousIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous intensity")]
        public static ResqmlPropertyKind LuminousIntensity
        {
            get 
            {
                return luminousIntensity;
            }
        }

        private readonly static ResqmlPropertyKind magneticDipoleMoment;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic dipole moment")]
        public static ResqmlPropertyKind MagneticDipoleMoment
        {
            get 
            {
                return magneticDipoleMoment;
            }
        }

        private readonly static ResqmlPropertyKind magneticFieldStrength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic field strength")]
        public static ResqmlPropertyKind MagneticFieldStrength
        {
            get 
            {
                return magneticFieldStrength;
            }
        }

        private readonly static ResqmlPropertyKind magneticFlux;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic flux")]
        public static ResqmlPropertyKind MagneticFlux
        {
            get 
            {
                return magneticFlux;
            }
        }

        private readonly static ResqmlPropertyKind magneticInduction;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic induction")]
        public static ResqmlPropertyKind MagneticInduction
        {
            get 
            {
                return magneticInduction;
            }
        }

        private readonly static ResqmlPropertyKind magneticPermeability;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic permeability")]
        public static ResqmlPropertyKind MagneticPermeability
        {
            get 
            {
                return magneticPermeability;
            }
        }

        private readonly static ResqmlPropertyKind magneticVectorPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic vector potential")]
        public static ResqmlPropertyKind MagneticVectorPotential
        {
            get 
            {
                return magneticVectorPotential;
            }
        }

        private readonly static ResqmlPropertyKind mass;
        /// <summary>
        /// M/L2T
        /// </summary>
        [EnumValueNameAttribute("mass")]
        public static ResqmlPropertyKind Mass
        {
            get 
            {
                return mass;
            }
        }

        private readonly static ResqmlPropertyKind massAttenuationCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass attenuation coefficient")]
        public static ResqmlPropertyKind MassAttenuationCoefficient
        {
            get 
            {
                return massAttenuationCoefficient;
            }
        }

        private readonly static ResqmlPropertyKind massConcentration;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is mass.
        /// </summary>
        [EnumValueNameAttribute("mass concentration")]
        public static ResqmlPropertyKind MassConcentration
        {
            get 
            {
                return massConcentration;
            }
        }

        private readonly static ResqmlPropertyKind massFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass flow rate")]
        public static ResqmlPropertyKind MassFlowRate
        {
            get 
            {
                return massFlowRate;
            }
        }

        private readonly static ResqmlPropertyKind massLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass length")]
        public static ResqmlPropertyKind MassLength
        {
            get 
            {
                return massLength;
            }
        }

        private readonly static ResqmlPropertyKind massPerEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per energy")]
        public static ResqmlPropertyKind MassPerEnergy
        {
            get 
            {
                return massPerEnergy;
            }
        }

        private readonly static ResqmlPropertyKind massPerLength;
        /// <summary>
        /// M /L4T
        /// </summary>
        [EnumValueNameAttribute("mass per length")]
        public static ResqmlPropertyKind MassPerLength
        {
            get 
            {
                return massPerLength;
            }
        }

        private readonly static ResqmlPropertyKind massPerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per area")]
        public static ResqmlPropertyKind MassPerTimePerArea
        {
            get 
            {
                return massPerTimePerArea;
            }
        }

        private readonly static ResqmlPropertyKind massPerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per length")]
        public static ResqmlPropertyKind MassPerTimePerLength
        {
            get 
            {
                return massPerTimePerLength;
            }
        }

        private readonly static ResqmlPropertyKind massPerVolumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per volume per length")]
        public static ResqmlPropertyKind MassPerVolumePerLength
        {
            get 
            {
                return massPerVolumePerLength;
            }
        }

        private readonly static ResqmlPropertyKind mobility;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mobility")]
        public static ResqmlPropertyKind Mobility
        {
            get 
            {
                return mobility;
            }
        }

        private readonly static ResqmlPropertyKind modulusOfCompression;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("modulus of compression")]
        public static ResqmlPropertyKind ModulusOfCompression
        {
            get 
            {
                return modulusOfCompression;
            }
        }

        private readonly static ResqmlPropertyKind molarConcentration;
        /// <summary>
        /// molar concentration of a substance.
        /// </summary>
        [EnumValueNameAttribute("molar concentration")]
        public static ResqmlPropertyKind MolarConcentration
        {
            get 
            {
                return molarConcentration;
            }
        }

        private readonly static ResqmlPropertyKind molarHeatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar heat capacity")]
        public static ResqmlPropertyKind MolarHeatCapacity
        {
            get 
            {
                return molarHeatCapacity;
            }
        }

        private readonly static ResqmlPropertyKind molarVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar volume")]
        public static ResqmlPropertyKind MolarVolume
        {
            get 
            {
                return molarVolume;
            }
        }

        private readonly static ResqmlPropertyKind molePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per area")]
        public static ResqmlPropertyKind MolePerArea
        {
            get 
            {
                return molePerArea;
            }
        }

        private readonly static ResqmlPropertyKind molePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time")]
        public static ResqmlPropertyKind MolePerTime
        {
            get 
            {
                return molePerTime;
            }
        }

        private readonly static ResqmlPropertyKind molePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time per area")]
        public static ResqmlPropertyKind MolePerTimePerArea
        {
            get 
            {
                return molePerTimePerArea;
            }
        }

        private readonly static ResqmlPropertyKind momentOfForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of force")]
        public static ResqmlPropertyKind MomentOfForce
        {
            get 
            {
                return momentOfForce;
            }
        }

        private readonly static ResqmlPropertyKind momentOfInertia;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of inertia")]
        public static ResqmlPropertyKind MomentOfInertia
        {
            get 
            {
                return momentOfInertia;
            }
        }

        private readonly static ResqmlPropertyKind momentOfSection;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of section")]
        public static ResqmlPropertyKind MomentOfSection
        {
            get 
            {
                return momentOfSection;
            }
        }

        private readonly static ResqmlPropertyKind momentum;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("momentum")]
        public static ResqmlPropertyKind Momentum
        {
            get 
            {
                return momentum;
            }
        }

        private readonly static ResqmlPropertyKind muRho;
        /// <summary>
        /// Product of Shear modulus and density, MR
        /// </summary>
        [EnumValueNameAttribute("Mu Rho")]
        public static ResqmlPropertyKind MuRho
        {
            get 
            {
                return muRho;
            }
        }

        private readonly static ResqmlPropertyKind netToGrossRatio;
        /// <summary>
        /// Ratio of net rock volume to gross rock volume, NTG
        /// </summary>
        [EnumValueNameAttribute("net to gross ratio")]
        public static ResqmlPropertyKind NetToGrossRatio
        {
            get 
            {
                return netToGrossRatio;
            }
        }

        private readonly static ResqmlPropertyKind neutronApiUnit;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("neutron API unit")]
        public static ResqmlPropertyKind NeutronApiUnit
        {
            get 
            {
                return neutronApiUnit;
            }
        }

        private readonly static ResqmlPropertyKind nondarcyFlowCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("nonDarcy flow coefficient")]
        public static ResqmlPropertyKind NondarcyFlowCoefficient
        {
            get 
            {
                return nondarcyFlowCoefficient;
            }
        }

        private readonly static ResqmlPropertyKind operationsPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("operations per time")]
        public static ResqmlPropertyKind OperationsPerTime
        {
            get 
            {
                return operationsPerTime;
            }
        }

        private readonly static ResqmlPropertyKind parachor;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("parachor")]
        public static ResqmlPropertyKind Parachor
        {
            get 
            {
                return parachor;
            }
        }

        private readonly static ResqmlPropertyKind perArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per area")]
        public static ResqmlPropertyKind PerArea
        {
            get 
            {
                return perArea;
            }
        }

        private readonly static ResqmlPropertyKind perElectricPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per electric potential")]
        public static ResqmlPropertyKind PerElectricPotential
        {
            get 
            {
                return perElectricPotential;
            }
        }

        private readonly static ResqmlPropertyKind perForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per force")]
        public static ResqmlPropertyKind PerForce
        {
            get 
            {
                return perForce;
            }
        }

        private readonly static ResqmlPropertyKind perLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per length")]
        public static ResqmlPropertyKind PerLength
        {
            get 
            {
                return perLength;
            }
        }

        private readonly static ResqmlPropertyKind perMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per mass")]
        public static ResqmlPropertyKind PerMass
        {
            get 
            {
                return perMass;
            }
        }

        private readonly static ResqmlPropertyKind perVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per volume")]
        public static ResqmlPropertyKind PerVolume
        {
            get 
            {
                return perVolume;
            }
        }

        private readonly static ResqmlPropertyKind permeabilityLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability length")]
        public static ResqmlPropertyKind PermeabilityLength
        {
            get 
            {
                return permeabilityLength;
            }
        }

        private readonly static ResqmlPropertyKind permeabilityRock;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability rock")]
        public static ResqmlPropertyKind PermeabilityRock
        {
            get 
            {
                return permeabilityRock;
            }
        }

        private readonly static ResqmlPropertyKind permeabilityThickness;
        /// <summary>
        /// Product of permeability and thickness
        /// </summary>
        [EnumValueNameAttribute("permeability thickness")]
        public static ResqmlPropertyKind PermeabilityThickness
        {
            get 
            {
                return permeabilityThickness;
            }
        }

        private readonly static ResqmlPropertyKind permeance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeance")]
        public static ResqmlPropertyKind Permeance
        {
            get 
            {
                return permeance;
            }
        }

        private readonly static ResqmlPropertyKind permittivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permittivity")]
        public static ResqmlPropertyKind Permittivity
        {
            get 
            {
                return permittivity;
            }
        }

        private readonly static ResqmlPropertyKind ph;
        /// <summary>
        /// The pH is a class that measures the hydrogen ion concentration (acidity).
        /// </summary>
        [EnumValueNameAttribute("pH")]
        public static ResqmlPropertyKind Ph
        {
            get 
            {
                return ph;
            }
        }

        private readonly static ResqmlPropertyKind planeAngle;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("plane angle")]
        public static ResqmlPropertyKind PlaneAngle
        {
            get 
            {
                return planeAngle;
            }
        }

        private readonly static ResqmlPropertyKind poissonRatio;
        /// <summary>
        /// Poisson's ratio, Sigma
        /// </summary>
        [EnumValueNameAttribute("Poisson ratio")]
        public static ResqmlPropertyKind PoissonRatio
        {
            get 
            {
                return poissonRatio;
            }
        }

        private readonly static ResqmlPropertyKind poreVolume;
        /// <summary>
        /// Volume of the Pore Space of the Rock
        /// </summary>
        [EnumValueNameAttribute("pore volume")]
        public static ResqmlPropertyKind PoreVolume
        {
            get 
            {
                return poreVolume;
            }
        }

        private readonly static ResqmlPropertyKind porosity;
        /// <summary>
        /// porosity
        /// </summary>
        [EnumValueNameAttribute("porosity")]
        public static ResqmlPropertyKind Porosity
        {
            get 
            {
                return porosity;
            }
        }

        private readonly static ResqmlPropertyKind potentialDifferencePerPowerDrop;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("potential difference per power drop")]
        public static ResqmlPropertyKind PotentialDifferencePerPowerDrop
        {
            get 
            {
                return potentialDifferencePerPowerDrop;
            }
        }

        private readonly static ResqmlPropertyKind power;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power")]
        public static ResqmlPropertyKind Power
        {
            get 
            {
                return power;
            }
        }

        private readonly static ResqmlPropertyKind powerPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power per volume")]
        public static ResqmlPropertyKind PowerPerVolume
        {
            get 
            {
                return powerPerVolume;
            }
        }

        private readonly static ResqmlPropertyKind pressure;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure")]
        public static ResqmlPropertyKind Pressure
        {
            get 
            {
                return pressure;
            }
        }

        private readonly static ResqmlPropertyKind pressurePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure per time")]
        public static ResqmlPropertyKind PressurePerTime
        {
            get 
            {
                return pressurePerTime;
            }
        }

        private readonly static ResqmlPropertyKind pressureSquared;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared")]
        public static ResqmlPropertyKind PressureSquared
        {
            get 
            {
                return pressureSquared;
            }
        }

        private readonly static ResqmlPropertyKind pressureSquaredPerForceTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared per force time per area")]
        public static ResqmlPropertyKind PressureSquaredPerForceTimePerArea
        {
            get 
            {
                return pressureSquaredPerForceTimePerArea;
            }
        }

        private readonly static ResqmlPropertyKind pressureTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure time per volume")]
        public static ResqmlPropertyKind PressureTimePerVolume
        {
            get 
            {
                return pressureTimePerVolume;
            }
        }

        private readonly static ResqmlPropertyKind productivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("productivity index")]
        public static ResqmlPropertyKind ProductivityIndex
        {
            get 
            {
                return productivityIndex;
            }
        }

        private readonly static ResqmlPropertyKind propertyMultiplier;
        /// <summary>
        /// Unitless multiplier to apply to any property
        /// </summary>
        [EnumValueNameAttribute("property multiplier")]
        public static ResqmlPropertyKind PropertyMultiplier
        {
            get 
            {
                return propertyMultiplier;
            }
        }

        private readonly static ResqmlPropertyKind quantity;
        /// <summary>
        /// The abstract supertype of all floating point properties with a unit of measure.
        /// </summary>
        [EnumValueNameAttribute("quantity")]
        public static ResqmlPropertyKind Quantity
        {
            get 
            {
                return quantity;
            }
        }

        private readonly static ResqmlPropertyKind quantityOfLight;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("quantity of light")]
        public static ResqmlPropertyKind QuantityOfLight
        {
            get 
            {
                return quantityOfLight;
            }
        }

        private readonly static ResqmlPropertyKind radiance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiance")]
        public static ResqmlPropertyKind Radiance
        {
            get 
            {
                return radiance;
            }
        }

        private readonly static ResqmlPropertyKind radiantIntensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiant intensity")]
        public static ResqmlPropertyKind RadiantIntensity
        {
            get 
            {
                return radiantIntensity;
            }
        }

        private readonly static ResqmlPropertyKind relativePermeability;
        /// <summary>
        /// Ratio of phase permeability, which is a function of saturation, to the rock permeability
        /// </summary>
        [EnumValueNameAttribute("relative permeability")]
        public static ResqmlPropertyKind RelativePermeability
        {
            get 
            {
                return relativePermeability;
            }
        }

        private readonly static ResqmlPropertyKind relativePower;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is power.
        /// </summary>
        [EnumValueNameAttribute("relative power")]
        public static ResqmlPropertyKind RelativePower
        {
            get 
            {
                return relativePower;
            }
        }

        private readonly static ResqmlPropertyKind relativeTime;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is time.
        /// </summary>
        [EnumValueNameAttribute("relative time")]
        public static ResqmlPropertyKind RelativeTime
        {
            get 
            {
                return relativeTime;
            }
        }

        private readonly static ResqmlPropertyKind reluctance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("reluctance")]
        public static ResqmlPropertyKind Reluctance
        {
            get 
            {
                return reluctance;
            }
        }

        private readonly static ResqmlPropertyKind resistance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistance")]
        public static ResqmlPropertyKind Resistance
        {
            get 
            {
                return resistance;
            }
        }

        private readonly static ResqmlPropertyKind resistivityPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistivity per length")]
        public static ResqmlPropertyKind ResistivityPerLength
        {
            get 
            {
                return resistivityPerLength;
            }
        }

        private readonly static ResqmlPropertyKind resqmlRootProperty;
        /// <summary>
        /// The abstract supertype of all properties. This property does not have a parent.
        /// </summary>
        [EnumValueNameAttribute("RESQML root property")]
        public static ResqmlPropertyKind ResqmlRootProperty
        {
            get 
            {
                return resqmlRootProperty;
            }
        }

        private readonly static ResqmlPropertyKind rockImpedance;
        /// <summary>
        /// Acoustic impedence, Ip, Is
        /// </summary>
        [EnumValueNameAttribute("Rock Impedance")]
        public static ResqmlPropertyKind RockImpedance
        {
            get 
            {
                return rockImpedance;
            }
        }

        private readonly static ResqmlPropertyKind rockPermeability;
        /// <summary>
        /// See "permeability rock"
        /// </summary>
        [EnumValueNameAttribute("rock permeability")]
        public static ResqmlPropertyKind RockPermeability
        {
            get 
            {
                return rockPermeability;
            }
        }

        private readonly static ResqmlPropertyKind rockVolume;
        /// <summary>
        /// Rock Volume
        /// </summary>
        [EnumValueNameAttribute("rock volume")]
        public static ResqmlPropertyKind RockVolume
        {
            get 
            {
                return rockVolume;
            }
        }

        private readonly static ResqmlPropertyKind saturation;
        /// <summary>
        /// Ratio of phase fluid volume to pore volume
        /// </summary>
        [EnumValueNameAttribute("saturation")]
        public static ResqmlPropertyKind Saturation
        {
            get 
            {
                return saturation;
            }
        }

        private readonly static ResqmlPropertyKind secondMomentOfArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("second moment of area")]
        public static ResqmlPropertyKind SecondMomentOfArea
        {
            get 
            {
                return secondMomentOfArea;
            }
        }

        private readonly static ResqmlPropertyKind shearModulus;
        /// <summary>
        /// Shear modulus, Mu
        /// </summary>
        [EnumValueNameAttribute("shear modulus")]
        public static ResqmlPropertyKind ShearModulus
        {
            get 
            {
                return shearModulus;
            }
        }

        private readonly static ResqmlPropertyKind solidAngle;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("solid angle")]
        public static ResqmlPropertyKind SolidAngle
        {
            get 
            {
                return solidAngle;
            }
        }

        private readonly static ResqmlPropertyKind solutionGasoilRatio;
        /// <summary>
        /// Ratio of solution gas volume to oil volume at reservoir conditions
        /// </summary>
        [EnumValueNameAttribute("solution gas-oil ratio")]
        public static ResqmlPropertyKind SolutionGasoilRatio
        {
            get 
            {
                return solutionGasoilRatio;
            }
        }

        private readonly static ResqmlPropertyKind specificActivityOfRadioactivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific activity (of radioactivity)")]
        public static ResqmlPropertyKind SpecificActivityOfRadioactivity
        {
            get 
            {
                return specificActivityOfRadioactivity;
            }
        }

        private readonly static ResqmlPropertyKind specificEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific energy")]
        public static ResqmlPropertyKind SpecificEnergy
        {
            get 
            {
                return specificEnergy;
            }
        }

        private readonly static ResqmlPropertyKind specificHeatCapacity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific heat capacity")]
        public static ResqmlPropertyKind SpecificHeatCapacity
        {
            get 
            {
                return specificHeatCapacity;
            }
        }

        private readonly static ResqmlPropertyKind specificProductivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific productivity index")]
        public static ResqmlPropertyKind SpecificProductivityIndex
        {
            get 
            {
                return specificProductivityIndex;
            }
        }

        private readonly static ResqmlPropertyKind specificVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific volume")]
        public static ResqmlPropertyKind SpecificVolume
        {
            get 
            {
                return specificVolume;
            }
        }

        private readonly static ResqmlPropertyKind surfaceDensity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("surface density")]
        public static ResqmlPropertyKind SurfaceDensity
        {
            get 
            {
                return surfaceDensity;
            }
        }

        private readonly static ResqmlPropertyKind temperaturePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per length")]
        public static ResqmlPropertyKind TemperaturePerLength
        {
            get 
            {
                return temperaturePerLength;
            }
        }

        private readonly static ResqmlPropertyKind temperaturePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per time")]
        public static ResqmlPropertyKind TemperaturePerTime
        {
            get 
            {
                return temperaturePerTime;
            }
        }

        private readonly static ResqmlPropertyKind thermalConductance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductance")]
        public static ResqmlPropertyKind ThermalConductance
        {
            get 
            {
                return thermalConductance;
            }
        }

        private readonly static ResqmlPropertyKind thermalConductivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductivity")]
        public static ResqmlPropertyKind ThermalConductivity
        {
            get 
            {
                return thermalConductivity;
            }
        }

        private readonly static ResqmlPropertyKind thermalDiffusivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal diffusivity")]
        public static ResqmlPropertyKind ThermalDiffusivity
        {
            get 
            {
                return thermalDiffusivity;
            }
        }

        private readonly static ResqmlPropertyKind thermalInsulance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal insulance")]
        public static ResqmlPropertyKind ThermalInsulance
        {
            get 
            {
                return thermalInsulance;
            }
        }

        private readonly static ResqmlPropertyKind thermalResistance;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal resistance")]
        public static ResqmlPropertyKind ThermalResistance
        {
            get 
            {
                return thermalResistance;
            }
        }

        private readonly static ResqmlPropertyKind thermodynamicTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermodynamic temperature")]
        public static ResqmlPropertyKind ThermodynamicTemperature
        {
            get 
            {
                return thermodynamicTemperature;
            }
        }

        private readonly static ResqmlPropertyKind thickness;
        /// <summary>
        /// Distance measured in a volume between two surfaces ( e.G. Geological Top Boundary and Geological Bottom Boundary of a Geological unit).
        /// </summary>
        [EnumValueNameAttribute("thickness")]
        public static ResqmlPropertyKind Thickness
        {
            get 
            {
                return thickness;
            }
        }

        private readonly static ResqmlPropertyKind time;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time")]
        public static ResqmlPropertyKind Time
        {
            get 
            {
                return time;
            }
        }

        private readonly static ResqmlPropertyKind timePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per length")]
        public static ResqmlPropertyKind TimePerLength
        {
            get 
            {
                return timePerLength;
            }
        }

        private readonly static ResqmlPropertyKind timePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per volume")]
        public static ResqmlPropertyKind TimePerVolume
        {
            get 
            {
                return timePerVolume;
            }
        }

        private readonly static ResqmlPropertyKind transmissibility;
        /// <summary>
        /// Volumetric flux per unit area per unit pressure drop for unit viscosity fluid
        /// </summary>
        [EnumValueNameAttribute("transmissibility")]
        public static ResqmlPropertyKind Transmissibility
        {
            get 
            {
                return transmissibility;
            }
        }

        private readonly static ResqmlPropertyKind unitProductivityIndex;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("unit productivity index")]
        public static ResqmlPropertyKind UnitProductivityIndex
        {
            get 
            {
                return unitProductivityIndex;
            }
        }

        private readonly static ResqmlPropertyKind unitless;
        /// <summary>
        /// The abstract supertype of all floating point properties with NO unit of measure. In order to allow the unit information to be required for all continuous properties, the special unit of measure of "NONE" has been assigned to all children of this class. In addition, the special dimensional class of "0" has been assigned to all children of this class.
        /// </summary>
        [EnumValueNameAttribute("unitless")]
        public static ResqmlPropertyKind Unitless
        {
            get 
            {
                return unitless;
            }
        }

        private readonly static ResqmlPropertyKind vaporOilgasRatio;
        /// <summary>
        /// Ratio of oil vapor volume to gas volume at reservoir conditions
        /// </summary>
        [EnumValueNameAttribute("vapor oil-gas ratio")]
        public static ResqmlPropertyKind VaporOilgasRatio
        {
            get 
            {
                return vaporOilgasRatio;
            }
        }

        private readonly static ResqmlPropertyKind velocity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("velocity")]
        public static ResqmlPropertyKind Velocity
        {
            get 
            {
                return velocity;
            }
        }

        private readonly static ResqmlPropertyKind volume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume")]
        public static ResqmlPropertyKind Volume
        {
            get 
            {
                return volume;
            }
        }

        private readonly static ResqmlPropertyKind volumeFlowRate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume flow rate")]
        public static ResqmlPropertyKind VolumeFlowRate
        {
            get 
            {
                return volumeFlowRate;
            }
        }

        private readonly static ResqmlPropertyKind volumeLengthPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume length per time")]
        public static ResqmlPropertyKind VolumeLengthPerTime
        {
            get 
            {
                return volumeLengthPerTime;
            }
        }

        private readonly static ResqmlPropertyKind volumePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per area")]
        public static ResqmlPropertyKind VolumePerArea
        {
            get 
            {
                return volumePerArea;
            }
        }

        private readonly static ResqmlPropertyKind volumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per length")]
        public static ResqmlPropertyKind VolumePerLength
        {
            get 
            {
                return volumePerLength;
            }
        }

        private readonly static ResqmlPropertyKind volumePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per area")]
        public static ResqmlPropertyKind VolumePerTimePerArea
        {
            get 
            {
                return volumePerTimePerArea;
            }
        }

        private readonly static ResqmlPropertyKind volumePerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per length")]
        public static ResqmlPropertyKind VolumePerTimePerLength
        {
            get 
            {
                return volumePerTimePerLength;
            }
        }

        private readonly static ResqmlPropertyKind volumePerTimePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per time")]
        public static ResqmlPropertyKind VolumePerTimePerTime
        {
            get 
            {
                return volumePerTimePerTime;
            }
        }

        private readonly static ResqmlPropertyKind volumePerTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per volume")]
        public static ResqmlPropertyKind VolumePerTimePerVolume
        {
            get 
            {
                return volumePerTimePerVolume;
            }
        }

        private readonly static ResqmlPropertyKind volumePerVolume;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is volume.
        /// </summary>
        [EnumValueNameAttribute("volume per volume")]
        public static ResqmlPropertyKind VolumePerVolume
        {
            get 
            {
                return volumePerVolume;
            }
        }

        private readonly static ResqmlPropertyKind volumetricHeatTransferCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric heat transfer coefficient")]
        public static ResqmlPropertyKind VolumetricHeatTransferCoefficient
        {
            get 
            {
                return volumetricHeatTransferCoefficient;
            }
        }

        private readonly static ResqmlPropertyKind volumetricThermalExpansion;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric thermal expansion")]
        public static ResqmlPropertyKind VolumetricThermalExpansion
        {
            get 
            {
                return volumetricThermalExpansion;
            }
        }

        private readonly static ResqmlPropertyKind work;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static ResqmlPropertyKind Work
        {
            get 
            {
                return work;
            }
        }

        private readonly static ResqmlPropertyKind youngModulus;
        /// <summary>
        /// Young's modulus, E
        /// </summary>
        [EnumValueNameAttribute("Young modulus")]
        public static ResqmlPropertyKind YoungModulus
        {
            get 
            {
                return youngModulus;
            }
        }

        static ResqmlPropertyKind()
        {
            absorbedDose = 
                new ResqmlPropertyKind("absorbed dose")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Gy"
                    ,DimensionalClass = "L2/T2"
                    ,Description = "The amount of energy absorbed per mass."
            };
            accelerationLinear = 
                new ResqmlPropertyKind("acceleration linear")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m/s2"
                    ,DimensionalClass = "L/T2"
            };
            activityOfRadioactivity = 
                new ResqmlPropertyKind("activity (of radioactivity)")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Bq"
                    ,DimensionalClass = "1/T"
                    ,Description = "A measure of the radiation being emitted."
            };
            amountOfSubstance = 
                new ResqmlPropertyKind("amount of substance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "mol"
                    ,DimensionalClass = "N"
                    ,Description = "Molar amount of a substance."
            };
            amplitude = 
                new ResqmlPropertyKind("amplitude")
                {
                    IsAbstract = false
                    ,ParentKind = "unitless"
                    ,UnitOfMeasure = "NONE"
                    ,DimensionalClass = "0"
                    ,Description = "Amplitude of the acoustic signal recorded. It is not a physical property, only a value."
            };
            anglePerLength = 
                new ResqmlPropertyKind("angle per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "rad/m"
                    ,DimensionalClass = "A/L"
            };
            anglePerTime = 
                new ResqmlPropertyKind("angle per time")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "rad/s"
                    ,DimensionalClass = "A/T"
                    ,Description = "The angular velocity. The rate of change of an angle."
            };
            anglePerVolume = 
                new ResqmlPropertyKind("angle per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "rad/m3"
                    ,DimensionalClass = "A/L3"
            };
            angularAcceleration = 
                new ResqmlPropertyKind("angular acceleration")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "rad/s2"
                    ,DimensionalClass = "A/T2"
            };
            area = 
                new ResqmlPropertyKind("area")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2"
                    ,DimensionalClass = "L2"
            };
            areaPerArea = 
                new ResqmlPropertyKind("area per area")
                {
                    IsAbstract = true
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L2)"
                    ,Description = "A dimensionless quantity where the basis of the ratio is area."
            };
            areaPerVolume = 
                new ResqmlPropertyKind("area per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/m"
                    ,DimensionalClass = "1/L"
            };
            attenuation = 
                new ResqmlPropertyKind("attenuation")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "B/O"
                    ,DimensionalClass = "1"
                    ,Description = "A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave."
            };
            attenuationPerLength = 
                new ResqmlPropertyKind("attenuation per length")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "B/m"
                    ,DimensionalClass = "1/L"
            };
            azimuth = 
                new ResqmlPropertyKind("azimuth")
                {
                    IsAbstract = false
                    ,ParentKind = "plane angle"
                    ,UnitOfMeasure = "rad"
                    ,DimensionalClass = "A"
                    ,Description = "Angle between the North and the projection of the normal to the horizon surface estimated on a local area of the interface."
            };
            bubblePointPressure = 
                new ResqmlPropertyKind("bubble point pressure")
                {
                    IsAbstract = false
                    ,ParentKind = "pressure"
                    ,UnitOfMeasure = "Pa"
                    ,DimensionalClass = "M/LT2"
                    ,Description = "The pressure at which the first gas bubble appears while decreasing pressure on a fluid sample."
            };
            bulkModulus = 
                new ResqmlPropertyKind("bulk modulus")
                {
                    IsAbstract = false
                    ,ParentKind = "pressure"
                    ,UnitOfMeasure = "Pa"
                    ,DimensionalClass = "M/LT2"
                    ,Description = "Bulk modulus, K"
            };
            capacitance = 
                new ResqmlPropertyKind("capacitance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "F"
                    ,DimensionalClass = "C2T4/L2M"
            };
            categorical = 
                new ResqmlPropertyKind("categorical")
                {
                    IsAbstract = true
                    ,ParentKind = "RESQML root property"
                    ,Description = "The abstract supertype of all enumerated string properties."
            };
            cellLength = 
                new ResqmlPropertyKind("cell length")
                {
                    IsAbstract = false
                    ,ParentKind = "length"
                    ,UnitOfMeasure = "m"
                    ,DimensionalClass = "L"
                    ,Description = "distance from cell face center to cell face center in the specified direction, DI, DJ, DK"
            };
            chargeDensity = 
                new ResqmlPropertyKind("charge density")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "C/m3"
                    ,DimensionalClass = "CT/L3"
            };
            chemicalPotential = 
                new ResqmlPropertyKind("chemical potential")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J/mol"
                    ,DimensionalClass = "L2M/NT2"
            };
            code = 
                new ResqmlPropertyKind("code")
                {
                    IsAbstract = false
                    ,ParentKind = "categorical"
                    ,Description = "A discrete code."
            };
            compressibility = 
                new ResqmlPropertyKind("compressibility")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/Pa"
                    ,DimensionalClass = "LT2/M"
            };
            concentrationOfB = 
                new ResqmlPropertyKind("concentration of B")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "mol/m3"
                    ,DimensionalClass = "N/L3"
                    ,Description = "molar concentration of a substance."
            };
            conductivity = 
                new ResqmlPropertyKind("conductivity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "S/m"
                    ,DimensionalClass = "C2T3/L3M"
            };
            continuous = 
                new ResqmlPropertyKind("continuous")
                {
                    IsAbstract = true
                    ,ParentKind = "RESQML root property"
                    ,Description = "The abstract supertype of all floating point properties."
            };
            crossSectionAbsorption = 
                new ResqmlPropertyKind("cross section absorption")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/mol"
                    ,DimensionalClass = "L2/N"
            };
            currentDensity = 
                new ResqmlPropertyKind("current density")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "A/m2"
                    ,DimensionalClass = "C/L2"
            };
            darcyFlowCoefficient = 
                new ResqmlPropertyKind("Darcy flow coefficient")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa/m3"
                    ,DimensionalClass = "M/L4T2"
            };
            dataTransmissionSpeed = 
                new ResqmlPropertyKind("data transmission speed")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "bps"
                    ,DimensionalClass = "1/T"
                    ,Description = "used primarily for computer transmission rates."
            };
            deltaTemperature = 
                new ResqmlPropertyKind("delta temperature")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "K"
                    ,DimensionalClass = "K"
                    ,Description = "Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures."
            };
            density = 
                new ResqmlPropertyKind("density")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg/m3"
                    ,DimensionalClass = "M/L3"
            };
            depth = 
                new ResqmlPropertyKind("depth")
                {
                    IsAbstract = false
                    ,ParentKind = "length"
                    ,UnitOfMeasure = "m"
                    ,DimensionalClass = "L"
                    ,Description = "The perpendicular measurement downward from a surface. Also, the direct linear measurement from the point of viewing usually from front to back."
            };
            diffusionCoefficient = 
                new ResqmlPropertyKind("diffusion coefficient")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/s"
                    ,DimensionalClass = "L2/T"
            };
            digitalStorage = 
                new ResqmlPropertyKind("digital storage")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "byte"
                    ,DimensionalClass = "1"
            };
            dimensionless = 
                new ResqmlPropertyKind("dimensionless")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "1"
                    ,Description = "A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass."
            };
            dip = 
                new ResqmlPropertyKind("dip")
                {
                    IsAbstract = false
                    ,ParentKind = "plane angle"
                    ,UnitOfMeasure = "rad"
                    ,DimensionalClass = "A"
                    ,Description = "In the azimuth direction, Angle between an horizon plane and an estimated plane on a local area of the interface."
            };
            discrete = 
                new ResqmlPropertyKind("discrete")
                {
                    IsAbstract = true
                    ,ParentKind = "RESQML root property"
                    ,Description = "The abstract supertype of all integer properties."
            };
            doseEquivalent = 
                new ResqmlPropertyKind("dose equivalent")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Sv"
                    ,DimensionalClass = "L2/T2"
            };
            doseEquivalentRate = 
                new ResqmlPropertyKind("dose equivalent rate")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Sv/s"
                    ,DimensionalClass = "L2/T3"
            };
            dynamicViscosity = 
                new ResqmlPropertyKind("dynamic viscosity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa.s"
                    ,DimensionalClass = "M/LT"
            };
            electricCharge = 
                new ResqmlPropertyKind("electric charge")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "C"
                    ,DimensionalClass = "CT"
            };
            electricConductance = 
                new ResqmlPropertyKind("electric conductance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "S"
                    ,DimensionalClass = "C2T3/L2M"
            };
            electricCurrent = 
                new ResqmlPropertyKind("electric current")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "A"
                    ,DimensionalClass = "C"
            };
            electricDipoleMoment = 
                new ResqmlPropertyKind("electric dipole moment")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "C.m"
                    ,DimensionalClass = "CTL"
            };
            electricFieldStrength = 
                new ResqmlPropertyKind("electric field strength")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "V/m"
                    ,DimensionalClass = "LM/CT3"
            };
            electricPolarization = 
                new ResqmlPropertyKind("electric polarization")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "C/m2"
                    ,DimensionalClass = "CT/L2"
            };
            electricPotential = 
                new ResqmlPropertyKind("electric potential")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "V"
                    ,DimensionalClass = "L2M/CT3"
            };
            electricalResistivity = 
                new ResqmlPropertyKind("electrical resistivity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "ohm.m"
                    ,DimensionalClass = "L3M/C2T3"
            };
            electrochemicalEquivalent = 
                new ResqmlPropertyKind("electrochemical equivalent")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "eq"
                    ,DimensionalClass = "CT/N"
                    ,Description = "An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered."
            };
            electromagneticMoment = 
                new ResqmlPropertyKind("electromagnetic moment")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "A.m2"
                    ,DimensionalClass = "CL2"
            };
            energyLengthPerArea = 
                new ResqmlPropertyKind("energy length per area")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N"
                    ,DimensionalClass = "LM/T2"
            };
            energyLengthPerTimeAreaTemperature = 
                new ResqmlPropertyKind("energy length per time area temperature")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/m.K"
                    ,DimensionalClass = "LM/KT3"
            };
            energyPerArea = 
                new ResqmlPropertyKind("energy per area")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N/m"
                    ,DimensionalClass = "M/T2"
            };
            energyPerLength = 
                new ResqmlPropertyKind("energy per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N"
                    ,DimensionalClass = "LM/T2"
            };
            equivalentPerMass = 
                new ResqmlPropertyKind("equivalent per mass")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "eq/kg"
                    ,DimensionalClass = "CT/MN"
            };
            equivalentPerVolume = 
                new ResqmlPropertyKind("equivalent per volume")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "eq/m3"
                    ,DimensionalClass = "CT/L3N"
            };
            exposureRadioactivity = 
                new ResqmlPropertyKind("exposure (radioactivity)")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "C/kg"
                    ,DimensionalClass = "CT/M"
            };
            fluidVolume = 
                new ResqmlPropertyKind("fluid volume")
                {
                    IsAbstract = false
                    ,ParentKind = "volume"
                    ,UnitOfMeasure = "m3"
                    ,DimensionalClass = "L3"
                    ,Description = "Volume of fluid"
            };
            force = 
                new ResqmlPropertyKind("force")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N"
                    ,DimensionalClass = "LM/T2"
            };
            forceArea = 
                new ResqmlPropertyKind("force area")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N.m2"
                    ,DimensionalClass = "L3M/T2"
            };
            forceLengthPerLength = 
                new ResqmlPropertyKind("force length per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N"
                    ,DimensionalClass = "LM/T2"
            };
            forcePerForce = 
                new ResqmlPropertyKind("force per force")
                {
                    IsAbstract = true
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(LM/T2)"
                    ,Description = "A dimensionless quantity where the basis of the ratio is force."
            };
            forcePerLength = 
                new ResqmlPropertyKind("force per length")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N/m"
                    ,DimensionalClass = "M/T2"
            };
            forcePerVolume = 
                new ResqmlPropertyKind("force per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N/m3"
                    ,DimensionalClass = "M/L2T2"
            };
            formationVolumeFactor = 
                new ResqmlPropertyKind("formation volume factor")
                {
                    IsAbstract = false
                    ,ParentKind = "volume per volume"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L3)"
                    ,Description = "Ratio of volumes at subsurface and surface conditions"
            };
            frequency = 
                new ResqmlPropertyKind("frequency")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Hz"
                    ,DimensionalClass = "1/T"
            };
            frequencyInterval = 
                new ResqmlPropertyKind("frequency interval")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "O"
                    ,DimensionalClass = "1"
                    ,Description = "An octave is a doubling of a frquency."
            };
            gammaRayApiUnit = 
                new ResqmlPropertyKind("gamma ray API unit")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "gAPI"
                    ,DimensionalClass = "1"
                    ,Description = "This class is defined by the API, and is used for units of gamma ray log response."
            };
            heatCapacity = 
                new ResqmlPropertyKind("heat capacity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J/K"
                    ,DimensionalClass = "L2M/KT2"
            };
            heatFlowRate = 
                new ResqmlPropertyKind("heat flow rate")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W"
                    ,DimensionalClass = "L2M/T3"
            };
            heatTransferCoefficient = 
                new ResqmlPropertyKind("heat transfer coefficient")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/m2.K"
                    ,DimensionalClass = "M/KT3"
                    ,Description = "PRESSURE PER VELOCITY PER AREA"
            };
            illuminance = 
                new ResqmlPropertyKind("illuminance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "lx"
                    ,DimensionalClass = "BS/L2"
            };
            index = 
                new ResqmlPropertyKind("index")
                {
                    IsAbstract = false
                    ,ParentKind = "discrete"
                    ,Description = "Serial ordering"
            };
            irradiance = 
                new ResqmlPropertyKind("irradiance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/m2"
                    ,DimensionalClass = "M/T3"
            };
            isothermalCompressibility = 
                new ResqmlPropertyKind("isothermal compressibility")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3/J"
                    ,DimensionalClass = "LT2/M"
            };
            kinematicViscosity = 
                new ResqmlPropertyKind("kinematic viscosity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/s"
                    ,DimensionalClass = "L2/T"
            };
            lambdaRho = 
                new ResqmlPropertyKind("Lambda Rho")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "(Pa.kg)/m3"
                    ,DimensionalClass = "M2/L4T2"
                    ,Description = "Product of Lame constant and density, LR"
            };
            lameConstant = 
                new ResqmlPropertyKind("Lame constant")
                {
                    IsAbstract = false
                    ,ParentKind = "pressure"
                    ,UnitOfMeasure = "Pa"
                    ,DimensionalClass = "M/LT2"
                    ,Description = "Lame constant, Lambda"
            };
            length = 
                new ResqmlPropertyKind("length")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m"
                    ,DimensionalClass = "L"
            };
            lengthPerLength = 
                new ResqmlPropertyKind("length per length")
                {
                    IsAbstract = true
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L)"
                    ,Description = "A dimensionless quantity where the basis of the ratio is length."
            };
            lengthPerTemperature = 
                new ResqmlPropertyKind("length per temperature")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m/K"
                    ,DimensionalClass = "L/K"
            };
            lengthPerVolume = 
                new ResqmlPropertyKind("length per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/m2"
                    ,DimensionalClass = "1/L2"
            };
            levelOfPowerIntensity = 
                new ResqmlPropertyKind("level of power intensity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "B"
                    ,DimensionalClass = "1"
            };
            lightExposure = 
                new ResqmlPropertyKind("light exposure")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "lx.s"
                    ,DimensionalClass = "BST/L2"
            };
            linearThermalExpansion = 
                new ResqmlPropertyKind("linear thermal expansion")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/K"
                    ,DimensionalClass = "1/K"
            };
            luminance = 
                new ResqmlPropertyKind("luminance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "cd/m2"
                    ,DimensionalClass = "B/L2"
            };
            luminousEfficacy = 
                new ResqmlPropertyKind("luminous efficacy")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "lm/W"
                    ,DimensionalClass = "BST3/L2M"
            };
            luminousFlux = 
                new ResqmlPropertyKind("luminous flux")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "lm"
                    ,DimensionalClass = "BS"
            };
            luminousIntensity = 
                new ResqmlPropertyKind("luminous intensity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "cd"
                    ,DimensionalClass = "B"
            };
            magneticDipoleMoment = 
                new ResqmlPropertyKind("magnetic dipole moment")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Wb.m"
                    ,DimensionalClass = "L3M/CT2"
            };
            magneticFieldStrength = 
                new ResqmlPropertyKind("magnetic field strength")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "A/m"
                    ,DimensionalClass = "C/L"
            };
            magneticFlux = 
                new ResqmlPropertyKind("magnetic flux")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Wb"
                    ,DimensionalClass = "L2M/CT2"
            };
            magneticInduction = 
                new ResqmlPropertyKind("magnetic induction")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "T"
                    ,DimensionalClass = "M/CT2"
            };
            magneticPermeability = 
                new ResqmlPropertyKind("magnetic permeability")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "H/m"
                    ,DimensionalClass = "LM/C2T2"
            };
            magneticVectorPotential = 
                new ResqmlPropertyKind("magnetic vector potential")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Wb/m"
                    ,DimensionalClass = "LM/CT2"
            };
            mass = 
                new ResqmlPropertyKind("mass")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg"
                    ,DimensionalClass = "M"
                    ,Description = "M/L2T"
            };
            massAttenuationCoefficient = 
                new ResqmlPropertyKind("mass attenuation coefficient")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/kg"
                    ,DimensionalClass = "L2/M"
            };
            massConcentration = 
                new ResqmlPropertyKind("mass concentration")
                {
                    IsAbstract = false
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(M)"
                    ,Description = "A dimensionless quantity where the basis of the ratio is mass."
            };
            massFlowRate = 
                new ResqmlPropertyKind("mass flow rate")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg/s"
                    ,DimensionalClass = "M/T"
            };
            massLength = 
                new ResqmlPropertyKind("mass length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg.m"
                    ,DimensionalClass = "ML"
            };
            massPerEnergy = 
                new ResqmlPropertyKind("mass per energy")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg/J"
                    ,DimensionalClass = "T2/L2"
            };
            massPerLength = 
                new ResqmlPropertyKind("mass per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg/m"
                    ,DimensionalClass = "M/L"
                    ,Description = "M /L4T"
            };
            massPerTimePerArea = 
                new ResqmlPropertyKind("mass per time per area")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg/m2.s"
                    ,DimensionalClass = "M/L2T"
            };
            massPerTimePerLength = 
                new ResqmlPropertyKind("mass per time per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa.s"
                    ,DimensionalClass = "M/LT"
            };
            massPerVolumePerLength = 
                new ResqmlPropertyKind("mass per volume per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg/m4"
                    ,DimensionalClass = "M/L4"
            };
            mobility = 
                new ResqmlPropertyKind("mobility")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/Pa.s"
                    ,DimensionalClass = "L3T/M"
            };
            modulusOfCompression = 
                new ResqmlPropertyKind("modulus of compression")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J/m3"
                    ,DimensionalClass = "M/LT2"
            };
            molarConcentration = 
                new ResqmlPropertyKind("molar concentration")
                {
                    IsAbstract = false
                    ,ParentKind = "concentration of B"
                    ,UnitOfMeasure = "mol/m3"
                    ,DimensionalClass = "N/L3"
                    ,Description = "molar concentration of a substance."
            };
            molarHeatCapacity = 
                new ResqmlPropertyKind("molar heat capacity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J/mol.K"
                    ,DimensionalClass = "L2M/KNT2"
            };
            molarVolume = 
                new ResqmlPropertyKind("molar volume")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3/mol"
                    ,DimensionalClass = "L3/N"
            };
            molePerArea = 
                new ResqmlPropertyKind("mole per area")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "mol/m2"
                    ,DimensionalClass = "N/L2"
            };
            molePerTime = 
                new ResqmlPropertyKind("mole per time")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "mol/s"
                    ,DimensionalClass = "N/T"
            };
            molePerTimePerArea = 
                new ResqmlPropertyKind("mole per time per area")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "mol/m2.s"
                    ,DimensionalClass = "N/L2T"
            };
            momentOfForce = 
                new ResqmlPropertyKind("moment of force")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J"
                    ,DimensionalClass = "L2M/T2"
            };
            momentOfInertia = 
                new ResqmlPropertyKind("moment of inertia")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg.m2"
                    ,DimensionalClass = "L2M"
            };
            momentOfSection = 
                new ResqmlPropertyKind("moment of section")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m4"
                    ,DimensionalClass = "L4"
            };
            momentum = 
                new ResqmlPropertyKind("momentum")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg.m/s"
                    ,DimensionalClass = "LM/T"
            };
            muRho = 
                new ResqmlPropertyKind("Mu Rho")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "(Pa.kg)/m3"
                    ,DimensionalClass = "M2/L4T2"
                    ,Description = "Product of Shear modulus and density, MR"
            };
            netToGrossRatio = 
                new ResqmlPropertyKind("net to gross ratio")
                {
                    IsAbstract = false
                    ,ParentKind = "volume per volume"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L3)"
                    ,Description = "Ratio of net rock volume to gross rock volume, NTG"
            };
            neutronApiUnit = 
                new ResqmlPropertyKind("neutron API unit")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "nAPI"
                    ,DimensionalClass = "1"
            };
            nondarcyFlowCoefficient = 
                new ResqmlPropertyKind("nonDarcy flow coefficient")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa.s/m6"
                    ,DimensionalClass = "M/L7T"
            };
            operationsPerTime = 
                new ResqmlPropertyKind("operations per time")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/s"
                    ,DimensionalClass = "1/T"
            };
            parachor = 
                new ResqmlPropertyKind("parachor")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "N4/kg.m7"
                    ,DimensionalClass = "M3/L3T8"
            };
            perArea = 
                new ResqmlPropertyKind("per area")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/m2"
                    ,DimensionalClass = "1/L2"
            };
            perElectricPotential = 
                new ResqmlPropertyKind("per electric potential")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/V"
                    ,DimensionalClass = "CT3/L2M"
            };
            perForce = 
                new ResqmlPropertyKind("per force")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/N"
                    ,DimensionalClass = "T2/LM"
            };
            perLength = 
                new ResqmlPropertyKind("per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/m"
                    ,DimensionalClass = "1/L"
            };
            perMass = 
                new ResqmlPropertyKind("per mass")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/kg"
                    ,DimensionalClass = "1/M"
            };
            perVolume = 
                new ResqmlPropertyKind("per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/m3"
                    ,DimensionalClass = "1/L3"
            };
            permeabilityLength = 
                new ResqmlPropertyKind("permeability length")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3"
                    ,DimensionalClass = "L3"
            };
            permeabilityRock = 
                new ResqmlPropertyKind("permeability rock")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2"
                    ,DimensionalClass = "L2"
            };
            permeabilityThickness = 
                new ResqmlPropertyKind("permeability thickness")
                {
                    IsAbstract = false
                    ,ParentKind = "permeability length"
                    ,UnitOfMeasure = "m3"
                    ,DimensionalClass = "L3"
                    ,Description = "Product of permeability and thickness"
            };
            permeance = 
                new ResqmlPropertyKind("permeance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "H"
                    ,DimensionalClass = "L2M/C2T2"
            };
            permittivity = 
                new ResqmlPropertyKind("permittivity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "F/m"
                    ,DimensionalClass = "C2T4/L3M"
            };
            ph = 
                new ResqmlPropertyKind("pH")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "pH"
                    ,DimensionalClass = "1"
                    ,Description = "The pH is a class that measures the hydrogen ion concentration (acidity)."
            };
            planeAngle = 
                new ResqmlPropertyKind("plane angle")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "rad"
                    ,DimensionalClass = "A"
            };
            poissonRatio = 
                new ResqmlPropertyKind("Poisson ratio")
                {
                    IsAbstract = false
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "1"
                    ,Description = "Poisson's ratio, Sigma"
            };
            poreVolume = 
                new ResqmlPropertyKind("pore volume")
                {
                    IsAbstract = false
                    ,ParentKind = "volume"
                    ,UnitOfMeasure = "m3"
                    ,DimensionalClass = "L3"
                    ,Description = "Volume of the Pore Space of the Rock"
            };
            porosity = 
                new ResqmlPropertyKind("porosity")
                {
                    IsAbstract = false
                    ,ParentKind = "volume per volume"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L3)"
                    ,Description = "porosity"
            };
            potentialDifferencePerPowerDrop = 
                new ResqmlPropertyKind("potential difference per power drop")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "V/B"
                    ,DimensionalClass = "L2M/CT3"
            };
            power = 
                new ResqmlPropertyKind("power")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W"
                    ,DimensionalClass = "L2M/T3"
            };
            powerPerVolume = 
                new ResqmlPropertyKind("power per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/m3"
                    ,DimensionalClass = "M/LT3"
            };
            pressure = 
                new ResqmlPropertyKind("pressure")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa"
                    ,DimensionalClass = "M/LT2"
            };
            pressurePerTime = 
                new ResqmlPropertyKind("pressure per time")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa/s"
                    ,DimensionalClass = "M/LT3"
            };
            pressureSquared = 
                new ResqmlPropertyKind("pressure squared")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa2"
                    ,DimensionalClass = "M2/L2T4"
            };
            pressureSquaredPerForceTimePerArea = 
                new ResqmlPropertyKind("pressure squared per force time per area")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa/s"
                    ,DimensionalClass = "M/LT3"
            };
            pressureTimePerVolume = 
                new ResqmlPropertyKind("pressure time per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Pa.s/m3"
                    ,DimensionalClass = "M/L4T"
            };
            productivityIndex = 
                new ResqmlPropertyKind("productivity index")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3/Pa.s"
                    ,DimensionalClass = "L4T/M"
            };
            propertyMultiplier = 
                new ResqmlPropertyKind("property multiplier")
                {
                    IsAbstract = false
                    ,ParentKind = "unitless"
                    ,UnitOfMeasure = "NONE"
                    ,DimensionalClass = "0"
                    ,Description = "Unitless multiplier to apply to any property"
            };
            quantity = 
                new ResqmlPropertyKind("quantity")
                {
                    IsAbstract = true
                    ,ParentKind = "continuous"
                    ,Description = "The abstract supertype of all floating point properties with a unit of measure."
            };
            quantityOfLight = 
                new ResqmlPropertyKind("quantity of light")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "lm.s"
                    ,DimensionalClass = "BST"
            };
            radiance = 
                new ResqmlPropertyKind("radiance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/m2.sr"
                    ,DimensionalClass = "M/ST3"
            };
            radiantIntensity = 
                new ResqmlPropertyKind("radiant intensity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/sr"
                    ,DimensionalClass = "L2M/ST3"
            };
            relativePermeability = 
                new ResqmlPropertyKind("relative permeability")
                {
                    IsAbstract = false
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "Ratio(L2)"
                    ,Description = "Ratio of phase permeability, which is a function of saturation, to the rock permeability"
            };
            relativePower = 
                new ResqmlPropertyKind("relative power")
                {
                    IsAbstract = false
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L2M/T3)"
                    ,Description = "A dimensionless quantity where the basis of the ratio is power."
            };
            relativeTime = 
                new ResqmlPropertyKind("relative time")
                {
                    IsAbstract = false
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(T)"
                    ,Description = "A dimensionless quantity where the basis of the ratio is time."
            };
            reluctance = 
                new ResqmlPropertyKind("reluctance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/H"
                    ,DimensionalClass = "C2T2/L2M"
            };
            resistance = 
                new ResqmlPropertyKind("resistance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "ohm"
                    ,DimensionalClass = "L2M/C2T3"
            };
            resistivityPerLength = 
                new ResqmlPropertyKind("resistivity per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "ohm/m"
                    ,DimensionalClass = "LM/C2T3"
            };
            resqmlRootProperty = 
                new ResqmlPropertyKind("RESQML root property")
                {
                    IsAbstract = true
                    ,Description = "The abstract supertype of all properties. This property does not have a parent."
            };
            rockImpedance = 
                new ResqmlPropertyKind("Rock Impedance")
                {
                    IsAbstract = false
                    ,ParentKind = "mass per time per area"
                    ,UnitOfMeasure = "kg/m2.s"
                    ,DimensionalClass = "M/L2T"
                    ,Description = "Acoustic impedence, Ip, Is"
            };
            rockPermeability = 
                new ResqmlPropertyKind("rock permeability")
                {
                    IsAbstract = false
                    ,ParentKind = "permeability rock"
                    ,UnitOfMeasure = "m2"
                    ,DimensionalClass = "L2"
                    ,Description = "See \"permeability rock\""
            };
            rockVolume = 
                new ResqmlPropertyKind("rock volume")
                {
                    IsAbstract = false
                    ,ParentKind = "volume"
                    ,UnitOfMeasure = "m3"
                    ,DimensionalClass = "L3"
                    ,Description = "Rock Volume"
            };
            saturation = 
                new ResqmlPropertyKind("saturation")
                {
                    IsAbstract = false
                    ,ParentKind = "volume per volume"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L3)"
                    ,Description = "Ratio of phase fluid volume to pore volume"
            };
            secondMomentOfArea = 
                new ResqmlPropertyKind("second moment of area")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m4"
                    ,DimensionalClass = "L4"
            };
            shearModulus = 
                new ResqmlPropertyKind("shear modulus")
                {
                    IsAbstract = false
                    ,ParentKind = "pressure"
                    ,UnitOfMeasure = "Pa"
                    ,DimensionalClass = "M/LT2"
                    ,Description = "Shear modulus, Mu"
            };
            solidAngle = 
                new ResqmlPropertyKind("solid angle")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "sr"
                    ,DimensionalClass = "S"
            };
            solutionGasoilRatio = 
                new ResqmlPropertyKind("solution gas-oil ratio")
                {
                    IsAbstract = false
                    ,ParentKind = "volume per volume"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L3)"
                    ,Description = "Ratio of solution gas volume to oil volume at reservoir conditions"
            };
            specificActivityOfRadioactivity = 
                new ResqmlPropertyKind("specific activity (of radioactivity)")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "Bq/kg"
                    ,DimensionalClass = "1/MT"
            };
            specificEnergy = 
                new ResqmlPropertyKind("specific energy")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J/kg"
                    ,DimensionalClass = "L2/T2"
            };
            specificHeatCapacity = 
                new ResqmlPropertyKind("specific heat capacity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J/kg.K"
                    ,DimensionalClass = "L2/KT2"
            };
            specificProductivityIndex = 
                new ResqmlPropertyKind("specific productivity index")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3/Pa2.s2"
                    ,DimensionalClass = "L5T2/M2"
            };
            specificVolume = 
                new ResqmlPropertyKind("specific volume")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3/kg"
                    ,DimensionalClass = "L3/M"
            };
            surfaceDensity = 
                new ResqmlPropertyKind("surface density")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "kg/m2"
                    ,DimensionalClass = "M/L2"
            };
            temperaturePerLength = 
                new ResqmlPropertyKind("temperature per length")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "K/m"
                    ,DimensionalClass = "K/L"
            };
            temperaturePerTime = 
                new ResqmlPropertyKind("temperature per time")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "K/s"
                    ,DimensionalClass = "K/T"
            };
            thermalConductance = 
                new ResqmlPropertyKind("thermal conductance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/K"
                    ,DimensionalClass = "L2M/KT3"
            };
            thermalConductivity = 
                new ResqmlPropertyKind("thermal conductivity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/m.K"
                    ,DimensionalClass = "LM/KT3"
            };
            thermalDiffusivity = 
                new ResqmlPropertyKind("thermal diffusivity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/s"
                    ,DimensionalClass = "L2/T"
            };
            thermalInsulance = 
                new ResqmlPropertyKind("thermal insulance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "K.m2/W"
                    ,DimensionalClass = "KT3/M"
            };
            thermalResistance = 
                new ResqmlPropertyKind("thermal resistance")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "K/W"
                    ,DimensionalClass = "KT3/L2M"
            };
            thermodynamicTemperature = 
                new ResqmlPropertyKind("thermodynamic temperature")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "K"
                    ,DimensionalClass = "K"
            };
            thickness = 
                new ResqmlPropertyKind("thickness")
                {
                    IsAbstract = false
                    ,ParentKind = "length"
                    ,UnitOfMeasure = "m"
                    ,DimensionalClass = "L"
                    ,Description = "Distance measured in a volume between two surfaces ( e.G. Geological Top Boundary and Geological Bottom Boundary of a Geological unit)."
            };
            time = 
                new ResqmlPropertyKind("time")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "s"
                    ,DimensionalClass = "T"
            };
            timePerLength = 
                new ResqmlPropertyKind("time per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "s/m"
                    ,DimensionalClass = "T/L"
            };
            timePerVolume = 
                new ResqmlPropertyKind("time per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "s/m3"
                    ,DimensionalClass = "T/L3"
            };
            transmissibility = 
                new ResqmlPropertyKind("transmissibility")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3"
                    ,DimensionalClass = "L3"
                    ,Description = "Volumetric flux per unit area per unit pressure drop for unit viscosity fluid"
            };
            unitProductivityIndex = 
                new ResqmlPropertyKind("unit productivity index")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/Pa.s"
                    ,DimensionalClass = "L3T/M"
            };
            unitless = 
                new ResqmlPropertyKind("unitless")
                {
                    IsAbstract = true
                    ,ParentKind = "continuous"
                    ,UnitOfMeasure = "NONE"
                    ,DimensionalClass = "0"
                    ,Description = "The abstract supertype of all floating point properties with NO unit of measure. In order to allow the unit information to be required for all continuous properties, the special unit of measure of \"NONE\" has been assigned to all children of this class. In addition, the special dimensional class of \"0\" has been assigned to all children of this class."
            };
            vaporOilgasRatio = 
                new ResqmlPropertyKind("vapor oil-gas ratio")
                {
                    IsAbstract = false
                    ,ParentKind = "volume per volume"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L3)"
                    ,Description = "Ratio of oil vapor volume to gas volume at reservoir conditions"
            };
            velocity = 
                new ResqmlPropertyKind("velocity")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m/s"
                    ,DimensionalClass = "L/T"
            };
            volume = 
                new ResqmlPropertyKind("volume")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3"
                    ,DimensionalClass = "L3"
            };
            volumeFlowRate = 
                new ResqmlPropertyKind("volume flow rate")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3/s"
                    ,DimensionalClass = "L3/T"
            };
            volumeLengthPerTime = 
                new ResqmlPropertyKind("volume length per time")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m4/s"
                    ,DimensionalClass = "L4/T"
            };
            volumePerArea = 
                new ResqmlPropertyKind("volume per area")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m"
                    ,DimensionalClass = "L"
            };
            volumePerLength = 
                new ResqmlPropertyKind("volume per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2"
                    ,DimensionalClass = "L2"
            };
            volumePerTimePerArea = 
                new ResqmlPropertyKind("volume per time per area")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m/s"
                    ,DimensionalClass = "L/T"
            };
            volumePerTimePerLength = 
                new ResqmlPropertyKind("volume per time per length")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m2/s"
                    ,DimensionalClass = "L2/T"
            };
            volumePerTimePerTime = 
                new ResqmlPropertyKind("volume per time per time")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "m3/s2"
                    ,DimensionalClass = "L3/T2"
            };
            volumePerTimePerVolume = 
                new ResqmlPropertyKind("volume per time per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/s"
                    ,DimensionalClass = "1/T"
            };
            volumePerVolume = 
                new ResqmlPropertyKind("volume per volume")
                {
                    IsAbstract = true
                    ,ParentKind = "dimensionless"
                    ,UnitOfMeasure = "Euc"
                    ,DimensionalClass = "ratio(L3)"
                    ,Description = "A dimensionless quantity where the basis of the ratio is volume."
            };
            volumetricHeatTransferCoefficient = 
                new ResqmlPropertyKind("volumetric heat transfer coefficient")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "W/m3.K"
                    ,DimensionalClass = "M/KLT3"
            };
            volumetricThermalExpansion = 
                new ResqmlPropertyKind("volumetric thermal expansion")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "1/K"
                    ,DimensionalClass = "1/K"
            };
            work = 
                new ResqmlPropertyKind("work")
                {
                    IsAbstract = false
                    ,ParentKind = "quantity"
                    ,UnitOfMeasure = "J"
                    ,DimensionalClass = "L2M/T2"
            };
            youngModulus = 
                new ResqmlPropertyKind("Young modulus")
                {
                    IsAbstract = false
                    ,ParentKind = "pressure"
                    ,UnitOfMeasure = "Pa"
                    ,DimensionalClass = "M/LT2"
                    ,Description = "Young's modulus, E"
            };
        }

        /// <summary>
        /// Gets a ResqmlPropertyKind by name
        /// </summary>
        /// <param name="name">The name of the ResqmlPropertyKind to return</param>
        /// <returns>The ResqmlPropertyKind represented by 'name'</returns>
        public static ResqmlPropertyKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ResqmlPropertyKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ResqmlPropertyKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ResqmlPropertyKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines the allowed units of measure.
    /// </summary>
    [System.SerializableAttribute()]
    public class ResqmlUnitOfMeasure : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ResqmlUnitOfMeasure(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ResqmlUnitOfMeasure</param>
        public ResqmlUnitOfMeasure(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ResqmlUnitOfMeasures
        /// </summary>
        /// <returns>The complete list of ResqmlUnitOfMeasures</returns>
        public static List<ResqmlUnitOfMeasure> GetList()
        {
            return GetList<ResqmlUnitOfMeasure>();
        }

        private readonly static ResqmlUnitOfMeasure none;
        /// <summary>
        /// This is a special unit for use with properties which are a specialization of "unitless". This is not appropriate for "dimensionless" properties or any other specialization of "quantity". Supporting NONE allows all "continuous" to have a mandatory unit of measure.
        /// </summary>
        [EnumValueNameAttribute("NONE")]
        public static ResqmlUnitOfMeasure None
        {
            get 
            {
                return none;
            }
        }

        private readonly static ResqmlUnitOfMeasure pakgmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("(Pa.kg)/m3")]
        public static ResqmlUnitOfMeasure PakgmThree
        {
            get 
            {
                return pakgmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure oneh;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/H")]
        public static ResqmlUnitOfMeasure Oneh
        {
            get 
            {
                return oneh;
            }
        }

        private readonly static ResqmlUnitOfMeasure onek;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/K")]
        public static ResqmlUnitOfMeasure Onek
        {
            get 
            {
                return onek;
            }
        }

        private readonly static ResqmlUnitOfMeasure onekg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/kg")]
        public static ResqmlUnitOfMeasure Onekg
        {
            get 
            {
                return onekg;
            }
        }

        private readonly static ResqmlUnitOfMeasure onem;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/m")]
        public static ResqmlUnitOfMeasure Onem
        {
            get 
            {
                return onem;
            }
        }

        private readonly static ResqmlUnitOfMeasure onemTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/m2")]
        public static ResqmlUnitOfMeasure OnemTwo
        {
            get 
            {
                return onemTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure onemThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/m3")]
        public static ResqmlUnitOfMeasure OnemThree
        {
            get 
            {
                return onemThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure onen;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/N")]
        public static ResqmlUnitOfMeasure Onen
        {
            get 
            {
                return onen;
            }
        }

        private readonly static ResqmlUnitOfMeasure onepa;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/Pa")]
        public static ResqmlUnitOfMeasure Onepa
        {
            get 
            {
                return onepa;
            }
        }

        private readonly static ResqmlUnitOfMeasure ones;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/s")]
        public static ResqmlUnitOfMeasure Ones
        {
            get 
            {
                return ones;
            }
        }

        private readonly static ResqmlUnitOfMeasure onev;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("1/V")]
        public static ResqmlUnitOfMeasure Onev
        {
            get 
            {
                return onev;
            }
        }

        private readonly static ResqmlUnitOfMeasure a;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("A")]
        public static ResqmlUnitOfMeasure A
        {
            get 
            {
                return a;
            }
        }

        private readonly static ResqmlUnitOfMeasure amTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("A.m2")]
        public static ResqmlUnitOfMeasure AmTwo
        {
            get 
            {
                return amTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure am;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("A/m")]
        public static ResqmlUnitOfMeasure Am
        {
            get 
            {
                return am;
            }
        }

        private readonly static ResqmlUnitOfMeasure b;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("B")]
        public static ResqmlUnitOfMeasure B
        {
            get 
            {
                return b;
            }
        }

        private readonly static ResqmlUnitOfMeasure bm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("B/m")]
        public static ResqmlUnitOfMeasure Bm
        {
            get 
            {
                return bm;
            }
        }

        private readonly static ResqmlUnitOfMeasure bo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("B/O")]
        public static ResqmlUnitOfMeasure Bo
        {
            get 
            {
                return bo;
            }
        }

        private readonly static ResqmlUnitOfMeasure bps;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("bps")]
        public static ResqmlUnitOfMeasure Bps
        {
            get 
            {
                return bps;
            }
        }

        private readonly static ResqmlUnitOfMeasure bq;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Bq")]
        public static ResqmlUnitOfMeasure Bq
        {
            get 
            {
                return bq;
            }
        }

        private readonly static ResqmlUnitOfMeasure bqkg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Bq/kg")]
        public static ResqmlUnitOfMeasure Bqkg
        {
            get 
            {
                return bqkg;
            }
        }

        private readonly static ResqmlUnitOfMeasure @byte;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("byte")]
        public static ResqmlUnitOfMeasure Byte
        {
            get 
            {
                return @byte;
            }
        }

        private readonly static ResqmlUnitOfMeasure c;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("C")]
        public static ResqmlUnitOfMeasure C
        {
            get 
            {
                return c;
            }
        }

        private readonly static ResqmlUnitOfMeasure cm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("C.m")]
        public static ResqmlUnitOfMeasure Cm
        {
            get 
            {
                return cm;
            }
        }

        private readonly static ResqmlUnitOfMeasure ckg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("C/kg")]
        public static ResqmlUnitOfMeasure Ckg
        {
            get 
            {
                return ckg;
            }
        }

        private readonly static ResqmlUnitOfMeasure cmTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("C/m2")]
        public static ResqmlUnitOfMeasure CmTwo
        {
            get 
            {
                return cmTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure cmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("C/m3")]
        public static ResqmlUnitOfMeasure CmThree
        {
            get 
            {
                return cmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure cd;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("cd")]
        public static ResqmlUnitOfMeasure Cd
        {
            get 
            {
                return cd;
            }
        }

        private readonly static ResqmlUnitOfMeasure cdmTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("cd/m2")]
        public static ResqmlUnitOfMeasure CdmTwo
        {
            get 
            {
                return cdmTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure eq;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("eq")]
        public static ResqmlUnitOfMeasure Eq
        {
            get 
            {
                return eq;
            }
        }

        private readonly static ResqmlUnitOfMeasure eqkg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("eq/kg")]
        public static ResqmlUnitOfMeasure Eqkg
        {
            get 
            {
                return eqkg;
            }
        }

        private readonly static ResqmlUnitOfMeasure eqmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("eq/m3")]
        public static ResqmlUnitOfMeasure EqmThree
        {
            get 
            {
                return eqmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure euc;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Euc")]
        public static ResqmlUnitOfMeasure Euc
        {
            get 
            {
                return euc;
            }
        }

        private readonly static ResqmlUnitOfMeasure f;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("F")]
        public static ResqmlUnitOfMeasure F
        {
            get 
            {
                return f;
            }
        }

        private readonly static ResqmlUnitOfMeasure fm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("F/m")]
        public static ResqmlUnitOfMeasure Fm
        {
            get 
            {
                return fm;
            }
        }

        private readonly static ResqmlUnitOfMeasure gapi;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gAPI")]
        public static ResqmlUnitOfMeasure Gapi
        {
            get 
            {
                return gapi;
            }
        }

        private readonly static ResqmlUnitOfMeasure gy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Gy")]
        public static ResqmlUnitOfMeasure Gy
        {
            get 
            {
                return gy;
            }
        }

        private readonly static ResqmlUnitOfMeasure h;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("H")]
        public static ResqmlUnitOfMeasure H
        {
            get 
            {
                return h;
            }
        }

        private readonly static ResqmlUnitOfMeasure hm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("H/m")]
        public static ResqmlUnitOfMeasure Hm
        {
            get 
            {
                return hm;
            }
        }

        private readonly static ResqmlUnitOfMeasure hz;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Hz")]
        public static ResqmlUnitOfMeasure Hz
        {
            get 
            {
                return hz;
            }
        }

        private readonly static ResqmlUnitOfMeasure j;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("J")]
        public static ResqmlUnitOfMeasure J
        {
            get 
            {
                return j;
            }
        }

        private readonly static ResqmlUnitOfMeasure jk;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("J/K")]
        public static ResqmlUnitOfMeasure Jk
        {
            get 
            {
                return jk;
            }
        }

        private readonly static ResqmlUnitOfMeasure jkg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("J/kg")]
        public static ResqmlUnitOfMeasure Jkg
        {
            get 
            {
                return jkg;
            }
        }

        private readonly static ResqmlUnitOfMeasure jkgk;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("J/kg.K")]
        public static ResqmlUnitOfMeasure Jkgk
        {
            get 
            {
                return jkgk;
            }
        }

        private readonly static ResqmlUnitOfMeasure jmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("J/m3")]
        public static ResqmlUnitOfMeasure JmThree
        {
            get 
            {
                return jmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure jmol;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("J/mol")]
        public static ResqmlUnitOfMeasure Jmol
        {
            get 
            {
                return jmol;
            }
        }

        private readonly static ResqmlUnitOfMeasure jmolk;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("J/mol.K")]
        public static ResqmlUnitOfMeasure Jmolk
        {
            get 
            {
                return jmolk;
            }
        }

        private readonly static ResqmlUnitOfMeasure k;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("K")]
        public static ResqmlUnitOfMeasure K
        {
            get 
            {
                return k;
            }
        }

        private readonly static ResqmlUnitOfMeasure kmTwow;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("K.m2/W")]
        public static ResqmlUnitOfMeasure KmTwow
        {
            get 
            {
                return kmTwow;
            }
        }

        private readonly static ResqmlUnitOfMeasure km;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("K/m")]
        public static ResqmlUnitOfMeasure Km
        {
            get 
            {
                return km;
            }
        }

        private readonly static ResqmlUnitOfMeasure ks;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("K/s")]
        public static ResqmlUnitOfMeasure Ks
        {
            get 
            {
                return ks;
            }
        }

        private readonly static ResqmlUnitOfMeasure kw;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("K/W")]
        public static ResqmlUnitOfMeasure Kw
        {
            get 
            {
                return kw;
            }
        }

        private readonly static ResqmlUnitOfMeasure kg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg")]
        public static ResqmlUnitOfMeasure Kg
        {
            get 
            {
                return kg;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg.m")]
        public static ResqmlUnitOfMeasure Kgm
        {
            get 
            {
                return kgm;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgms;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg.m/s")]
        public static ResqmlUnitOfMeasure Kgms
        {
            get 
            {
                return kgms;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgmTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg.m2")]
        public static ResqmlUnitOfMeasure KgmTwo
        {
            get 
            {
                return kgmTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgj;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg/J")]
        public static ResqmlUnitOfMeasure Kgj
        {
            get 
            {
                return kgj;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgmTwos;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg/m2.s")]
        public static ResqmlUnitOfMeasure KgmTwos
        {
            get 
            {
                return kgmTwos;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg/m3")]
        public static ResqmlUnitOfMeasure KgmThree
        {
            get 
            {
                return kgmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgmFour;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg/m4")]
        public static ResqmlUnitOfMeasure KgmFour
        {
            get 
            {
                return kgmFour;
            }
        }

        private readonly static ResqmlUnitOfMeasure kgs;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kg/s")]
        public static ResqmlUnitOfMeasure Kgs
        {
            get 
            {
                return kgs;
            }
        }

        private readonly static ResqmlUnitOfMeasure lm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("lm")]
        public static ResqmlUnitOfMeasure Lm
        {
            get 
            {
                return lm;
            }
        }

        private readonly static ResqmlUnitOfMeasure lms;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("lm.s")]
        public static ResqmlUnitOfMeasure Lms
        {
            get 
            {
                return lms;
            }
        }

        private readonly static ResqmlUnitOfMeasure lmw;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("lm/W")]
        public static ResqmlUnitOfMeasure Lmw
        {
            get 
            {
                return lmw;
            }
        }

        private readonly static ResqmlUnitOfMeasure lx;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("lx")]
        public static ResqmlUnitOfMeasure Lx
        {
            get 
            {
                return lx;
            }
        }

        private readonly static ResqmlUnitOfMeasure lxs;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("lx.s")]
        public static ResqmlUnitOfMeasure Lxs
        {
            get 
            {
                return lxs;
            }
        }

        private readonly static ResqmlUnitOfMeasure m;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m")]
        public static ResqmlUnitOfMeasure M
        {
            get 
            {
                return m;
            }
        }

        private readonly static ResqmlUnitOfMeasure mk;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m/K")]
        public static ResqmlUnitOfMeasure Mk
        {
            get 
            {
                return mk;
            }
        }

        private readonly static ResqmlUnitOfMeasure ms;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m/s")]
        public static ResqmlUnitOfMeasure Ms
        {
            get 
            {
                return ms;
            }
        }

        private readonly static ResqmlUnitOfMeasure msTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m/s2")]
        public static ResqmlUnitOfMeasure MsTwo
        {
            get 
            {
                return msTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure mTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m2")]
        public static ResqmlUnitOfMeasure MTwo
        {
            get 
            {
                return mTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure mTwokg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m2/kg")]
        public static ResqmlUnitOfMeasure MTwokg
        {
            get 
            {
                return mTwokg;
            }
        }

        private readonly static ResqmlUnitOfMeasure mTwomol;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m2/mol")]
        public static ResqmlUnitOfMeasure MTwomol
        {
            get 
            {
                return mTwomol;
            }
        }

        private readonly static ResqmlUnitOfMeasure mTwopas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m2/Pa.s")]
        public static ResqmlUnitOfMeasure MTwopas
        {
            get 
            {
                return mTwopas;
            }
        }

        private readonly static ResqmlUnitOfMeasure mTwos;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m2/s")]
        public static ResqmlUnitOfMeasure MTwos
        {
            get 
            {
                return mTwos;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3")]
        public static ResqmlUnitOfMeasure MThree
        {
            get 
            {
                return mThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThreej;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3/J")]
        public static ResqmlUnitOfMeasure MThreej
        {
            get 
            {
                return mThreej;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThreekg;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3/kg")]
        public static ResqmlUnitOfMeasure MThreekg
        {
            get 
            {
                return mThreekg;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThreemol;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3/mol")]
        public static ResqmlUnitOfMeasure MThreemol
        {
            get 
            {
                return mThreemol;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThreepas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3/Pa.s")]
        public static ResqmlUnitOfMeasure MThreepas
        {
            get 
            {
                return mThreepas;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThreepaTwosTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3/Pa2.s2")]
        public static ResqmlUnitOfMeasure MThreepaTwosTwo
        {
            get 
            {
                return mThreepaTwosTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThrees;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3/s")]
        public static ResqmlUnitOfMeasure MThrees
        {
            get 
            {
                return mThrees;
            }
        }

        private readonly static ResqmlUnitOfMeasure mThreesTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m3/s2")]
        public static ResqmlUnitOfMeasure MThreesTwo
        {
            get 
            {
                return mThreesTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure mFour;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m4")]
        public static ResqmlUnitOfMeasure MFour
        {
            get 
            {
                return mFour;
            }
        }

        private readonly static ResqmlUnitOfMeasure mFours;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("m4/s")]
        public static ResqmlUnitOfMeasure MFours
        {
            get 
            {
                return mFours;
            }
        }

        private readonly static ResqmlUnitOfMeasure mol;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mol")]
        public static ResqmlUnitOfMeasure Mol
        {
            get 
            {
                return mol;
            }
        }

        private readonly static ResqmlUnitOfMeasure molmTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mol/m2")]
        public static ResqmlUnitOfMeasure MolmTwo
        {
            get 
            {
                return molmTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure molmTwos;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mol/m2.s")]
        public static ResqmlUnitOfMeasure MolmTwos
        {
            get 
            {
                return molmTwos;
            }
        }

        private readonly static ResqmlUnitOfMeasure molmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mol/m3")]
        public static ResqmlUnitOfMeasure MolmThree
        {
            get 
            {
                return molmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure mols;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mol/s")]
        public static ResqmlUnitOfMeasure Mols
        {
            get 
            {
                return mols;
            }
        }

        private readonly static ResqmlUnitOfMeasure n;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("N")]
        public static ResqmlUnitOfMeasure N
        {
            get 
            {
                return n;
            }
        }

        private readonly static ResqmlUnitOfMeasure nmTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("N.m2")]
        public static ResqmlUnitOfMeasure NmTwo
        {
            get 
            {
                return nmTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure nm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("N/m")]
        public static ResqmlUnitOfMeasure Nm
        {
            get 
            {
                return nm;
            }
        }

        private readonly static ResqmlUnitOfMeasure nmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("N/m3")]
        public static ResqmlUnitOfMeasure NmThree
        {
            get 
            {
                return nmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure nFourkgmSeven;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("N4/kg.m7")]
        public static ResqmlUnitOfMeasure NFourkgmSeven
        {
            get 
            {
                return nFourkgmSeven;
            }
        }

        private readonly static ResqmlUnitOfMeasure napi;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("nAPI")]
        public static ResqmlUnitOfMeasure Napi
        {
            get 
            {
                return napi;
            }
        }

        private readonly static ResqmlUnitOfMeasure o;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("O")]
        public static ResqmlUnitOfMeasure O
        {
            get 
            {
                return o;
            }
        }

        private readonly static ResqmlUnitOfMeasure ohm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("ohm")]
        public static ResqmlUnitOfMeasure Ohm
        {
            get 
            {
                return ohm;
            }
        }

        private readonly static ResqmlUnitOfMeasure ohmm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("ohm.m")]
        public static ResqmlUnitOfMeasure Ohmm
        {
            get 
            {
                return ohmm;
            }
        }

        private readonly static ResqmlUnitOfMeasure pa;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Pa")]
        public static ResqmlUnitOfMeasure Pa
        {
            get 
            {
                return pa;
            }
        }

        private readonly static ResqmlUnitOfMeasure pas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Pa.s")]
        public static ResqmlUnitOfMeasure Pas
        {
            get 
            {
                return pas;
            }
        }

        private readonly static ResqmlUnitOfMeasure pasmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Pa.s/m3")]
        public static ResqmlUnitOfMeasure PasmThree
        {
            get 
            {
                return pasmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure pasmSix;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Pa.s/m6")]
        public static ResqmlUnitOfMeasure PasmSix
        {
            get 
            {
                return pasmSix;
            }
        }

        private readonly static ResqmlUnitOfMeasure pamThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Pa/m3")]
        public static ResqmlUnitOfMeasure PamThree
        {
            get 
            {
                return pamThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure paTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Pa2")]
        public static ResqmlUnitOfMeasure PaTwo
        {
            get 
            {
                return paTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure ph;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pH")]
        public static ResqmlUnitOfMeasure Ph
        {
            get 
            {
                return ph;
            }
        }

        private readonly static ResqmlUnitOfMeasure rad;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("rad")]
        public static ResqmlUnitOfMeasure Rad
        {
            get 
            {
                return rad;
            }
        }

        private readonly static ResqmlUnitOfMeasure radm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("rad/m")]
        public static ResqmlUnitOfMeasure Radm
        {
            get 
            {
                return radm;
            }
        }

        private readonly static ResqmlUnitOfMeasure radmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("rad/m3")]
        public static ResqmlUnitOfMeasure RadmThree
        {
            get 
            {
                return radmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure rads;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("rad/s")]
        public static ResqmlUnitOfMeasure Rads
        {
            get 
            {
                return rads;
            }
        }

        private readonly static ResqmlUnitOfMeasure radsTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("rad/s2")]
        public static ResqmlUnitOfMeasure RadsTwo
        {
            get 
            {
                return radsTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure s;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("S")]
        public static ResqmlUnitOfMeasure S
        {
            get 
            {
                return s;
            }
        }

        private readonly static ResqmlUnitOfMeasure sm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("S/m")]
        public static ResqmlUnitOfMeasure Sm
        {
            get 
            {
                return sm;
            }
        }

        private readonly static ResqmlUnitOfMeasure smThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("s/m3")]
        public static ResqmlUnitOfMeasure SmThree
        {
            get 
            {
                return smThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure sr;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("sr")]
        public static ResqmlUnitOfMeasure Sr
        {
            get 
            {
                return sr;
            }
        }

        private readonly static ResqmlUnitOfMeasure sv;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Sv")]
        public static ResqmlUnitOfMeasure Sv
        {
            get 
            {
                return sv;
            }
        }

        private readonly static ResqmlUnitOfMeasure svs;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Sv/s")]
        public static ResqmlUnitOfMeasure Svs
        {
            get 
            {
                return svs;
            }
        }

        private readonly static ResqmlUnitOfMeasure t;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("T")]
        public static ResqmlUnitOfMeasure T
        {
            get 
            {
                return t;
            }
        }

        private readonly static ResqmlUnitOfMeasure v;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("V")]
        public static ResqmlUnitOfMeasure V
        {
            get 
            {
                return v;
            }
        }

        private readonly static ResqmlUnitOfMeasure vb;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("V/B")]
        public static ResqmlUnitOfMeasure Vb
        {
            get 
            {
                return vb;
            }
        }

        private readonly static ResqmlUnitOfMeasure vm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("V/m")]
        public static ResqmlUnitOfMeasure Vm
        {
            get 
            {
                return vm;
            }
        }

        private readonly static ResqmlUnitOfMeasure w;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W")]
        public static ResqmlUnitOfMeasure W
        {
            get 
            {
                return w;
            }
        }

        private readonly static ResqmlUnitOfMeasure wk;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/K")]
        public static ResqmlUnitOfMeasure Wk
        {
            get 
            {
                return wk;
            }
        }

        private readonly static ResqmlUnitOfMeasure wmk;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/m.K")]
        public static ResqmlUnitOfMeasure Wmk
        {
            get 
            {
                return wmk;
            }
        }

        private readonly static ResqmlUnitOfMeasure wmTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/m2")]
        public static ResqmlUnitOfMeasure WmTwo
        {
            get 
            {
                return wmTwo;
            }
        }

        private readonly static ResqmlUnitOfMeasure wmTwok;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/m2.K")]
        public static ResqmlUnitOfMeasure WmTwok
        {
            get 
            {
                return wmTwok;
            }
        }

        private readonly static ResqmlUnitOfMeasure wmTwosr;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/m2.sr")]
        public static ResqmlUnitOfMeasure WmTwosr
        {
            get 
            {
                return wmTwosr;
            }
        }

        private readonly static ResqmlUnitOfMeasure wmThree;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/m3")]
        public static ResqmlUnitOfMeasure WmThree
        {
            get 
            {
                return wmThree;
            }
        }

        private readonly static ResqmlUnitOfMeasure wmThreek;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/m3.K")]
        public static ResqmlUnitOfMeasure WmThreek
        {
            get 
            {
                return wmThreek;
            }
        }

        private readonly static ResqmlUnitOfMeasure wsr;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("W/sr")]
        public static ResqmlUnitOfMeasure Wsr
        {
            get 
            {
                return wsr;
            }
        }

        private readonly static ResqmlUnitOfMeasure wb;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Wb")]
        public static ResqmlUnitOfMeasure Wb
        {
            get 
            {
                return wb;
            }
        }

        private readonly static ResqmlUnitOfMeasure wbm;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Wb.m")]
        public static ResqmlUnitOfMeasure Wbm
        {
            get 
            {
                return wbm;
            }
        }

        static ResqmlUnitOfMeasure()
        {
            none = 
                new ResqmlUnitOfMeasure("NONE")
                {
                    Description = "This is a special unit for use with properties which are a specialization of \"unitless\". This is not appropriate for \"dimensionless\" properties or any other specialization of \"quantity\". Supporting NONE allows all \"continuous\" to have a mandatory unit of measure."
            };
            pakgmThree = 
                new ResqmlUnitOfMeasure("(Pa.kg)/m3")
                {
            };
            oneh = 
                new ResqmlUnitOfMeasure("1/H")
                {
            };
            onek = 
                new ResqmlUnitOfMeasure("1/K")
                {
            };
            onekg = 
                new ResqmlUnitOfMeasure("1/kg")
                {
            };
            onem = 
                new ResqmlUnitOfMeasure("1/m")
                {
            };
            onemTwo = 
                new ResqmlUnitOfMeasure("1/m2")
                {
            };
            onemThree = 
                new ResqmlUnitOfMeasure("1/m3")
                {
            };
            onen = 
                new ResqmlUnitOfMeasure("1/N")
                {
            };
            onepa = 
                new ResqmlUnitOfMeasure("1/Pa")
                {
            };
            ones = 
                new ResqmlUnitOfMeasure("1/s")
                {
            };
            onev = 
                new ResqmlUnitOfMeasure("1/V")
                {
            };
            a = 
                new ResqmlUnitOfMeasure("A")
                {
            };
            amTwo = 
                new ResqmlUnitOfMeasure("A.m2")
                {
            };
            am = 
                new ResqmlUnitOfMeasure("A/m")
                {
            };
            b = 
                new ResqmlUnitOfMeasure("B")
                {
            };
            bm = 
                new ResqmlUnitOfMeasure("B/m")
                {
            };
            bo = 
                new ResqmlUnitOfMeasure("B/O")
                {
            };
            bps = 
                new ResqmlUnitOfMeasure("bps")
                {
            };
            bq = 
                new ResqmlUnitOfMeasure("Bq")
                {
            };
            bqkg = 
                new ResqmlUnitOfMeasure("Bq/kg")
                {
            };
            @byte = 
                new ResqmlUnitOfMeasure("byte")
                {
            };
            c = 
                new ResqmlUnitOfMeasure("C")
                {
            };
            cm = 
                new ResqmlUnitOfMeasure("C.m")
                {
            };
            ckg = 
                new ResqmlUnitOfMeasure("C/kg")
                {
            };
            cmTwo = 
                new ResqmlUnitOfMeasure("C/m2")
                {
            };
            cmThree = 
                new ResqmlUnitOfMeasure("C/m3")
                {
            };
            cd = 
                new ResqmlUnitOfMeasure("cd")
                {
            };
            cdmTwo = 
                new ResqmlUnitOfMeasure("cd/m2")
                {
            };
            eq = 
                new ResqmlUnitOfMeasure("eq")
                {
            };
            eqkg = 
                new ResqmlUnitOfMeasure("eq/kg")
                {
            };
            eqmThree = 
                new ResqmlUnitOfMeasure("eq/m3")
                {
            };
            euc = 
                new ResqmlUnitOfMeasure("Euc")
                {
            };
            f = 
                new ResqmlUnitOfMeasure("F")
                {
            };
            fm = 
                new ResqmlUnitOfMeasure("F/m")
                {
            };
            gapi = 
                new ResqmlUnitOfMeasure("gAPI")
                {
            };
            gy = 
                new ResqmlUnitOfMeasure("Gy")
                {
            };
            h = 
                new ResqmlUnitOfMeasure("H")
                {
            };
            hm = 
                new ResqmlUnitOfMeasure("H/m")
                {
            };
            hz = 
                new ResqmlUnitOfMeasure("Hz")
                {
            };
            j = 
                new ResqmlUnitOfMeasure("J")
                {
            };
            jk = 
                new ResqmlUnitOfMeasure("J/K")
                {
            };
            jkg = 
                new ResqmlUnitOfMeasure("J/kg")
                {
            };
            jkgk = 
                new ResqmlUnitOfMeasure("J/kg.K")
                {
            };
            jmThree = 
                new ResqmlUnitOfMeasure("J/m3")
                {
            };
            jmol = 
                new ResqmlUnitOfMeasure("J/mol")
                {
            };
            jmolk = 
                new ResqmlUnitOfMeasure("J/mol.K")
                {
            };
            k = 
                new ResqmlUnitOfMeasure("K")
                {
            };
            kmTwow = 
                new ResqmlUnitOfMeasure("K.m2/W")
                {
            };
            km = 
                new ResqmlUnitOfMeasure("K/m")
                {
            };
            ks = 
                new ResqmlUnitOfMeasure("K/s")
                {
            };
            kw = 
                new ResqmlUnitOfMeasure("K/W")
                {
            };
            kg = 
                new ResqmlUnitOfMeasure("kg")
                {
            };
            kgm = 
                new ResqmlUnitOfMeasure("kg.m")
                {
            };
            kgms = 
                new ResqmlUnitOfMeasure("kg.m/s")
                {
            };
            kgmTwo = 
                new ResqmlUnitOfMeasure("kg.m2")
                {
            };
            kgj = 
                new ResqmlUnitOfMeasure("kg/J")
                {
            };
            kgmTwos = 
                new ResqmlUnitOfMeasure("kg/m2.s")
                {
            };
            kgmThree = 
                new ResqmlUnitOfMeasure("kg/m3")
                {
            };
            kgmFour = 
                new ResqmlUnitOfMeasure("kg/m4")
                {
            };
            kgs = 
                new ResqmlUnitOfMeasure("kg/s")
                {
            };
            lm = 
                new ResqmlUnitOfMeasure("lm")
                {
            };
            lms = 
                new ResqmlUnitOfMeasure("lm.s")
                {
            };
            lmw = 
                new ResqmlUnitOfMeasure("lm/W")
                {
            };
            lx = 
                new ResqmlUnitOfMeasure("lx")
                {
            };
            lxs = 
                new ResqmlUnitOfMeasure("lx.s")
                {
            };
            m = 
                new ResqmlUnitOfMeasure("m")
                {
            };
            mk = 
                new ResqmlUnitOfMeasure("m/K")
                {
            };
            ms = 
                new ResqmlUnitOfMeasure("m/s")
                {
            };
            msTwo = 
                new ResqmlUnitOfMeasure("m/s2")
                {
            };
            mTwo = 
                new ResqmlUnitOfMeasure("m2")
                {
            };
            mTwokg = 
                new ResqmlUnitOfMeasure("m2/kg")
                {
            };
            mTwomol = 
                new ResqmlUnitOfMeasure("m2/mol")
                {
            };
            mTwopas = 
                new ResqmlUnitOfMeasure("m2/Pa.s")
                {
            };
            mTwos = 
                new ResqmlUnitOfMeasure("m2/s")
                {
            };
            mThree = 
                new ResqmlUnitOfMeasure("m3")
                {
            };
            mThreej = 
                new ResqmlUnitOfMeasure("m3/J")
                {
            };
            mThreekg = 
                new ResqmlUnitOfMeasure("m3/kg")
                {
            };
            mThreemol = 
                new ResqmlUnitOfMeasure("m3/mol")
                {
            };
            mThreepas = 
                new ResqmlUnitOfMeasure("m3/Pa.s")
                {
            };
            mThreepaTwosTwo = 
                new ResqmlUnitOfMeasure("m3/Pa2.s2")
                {
            };
            mThrees = 
                new ResqmlUnitOfMeasure("m3/s")
                {
            };
            mThreesTwo = 
                new ResqmlUnitOfMeasure("m3/s2")
                {
            };
            mFour = 
                new ResqmlUnitOfMeasure("m4")
                {
            };
            mFours = 
                new ResqmlUnitOfMeasure("m4/s")
                {
            };
            mol = 
                new ResqmlUnitOfMeasure("mol")
                {
            };
            molmTwo = 
                new ResqmlUnitOfMeasure("mol/m2")
                {
            };
            molmTwos = 
                new ResqmlUnitOfMeasure("mol/m2.s")
                {
            };
            molmThree = 
                new ResqmlUnitOfMeasure("mol/m3")
                {
            };
            mols = 
                new ResqmlUnitOfMeasure("mol/s")
                {
            };
            n = 
                new ResqmlUnitOfMeasure("N")
                {
            };
            nmTwo = 
                new ResqmlUnitOfMeasure("N.m2")
                {
            };
            nm = 
                new ResqmlUnitOfMeasure("N/m")
                {
            };
            nmThree = 
                new ResqmlUnitOfMeasure("N/m3")
                {
            };
            nFourkgmSeven = 
                new ResqmlUnitOfMeasure("N4/kg.m7")
                {
            };
            napi = 
                new ResqmlUnitOfMeasure("nAPI")
                {
            };
            o = 
                new ResqmlUnitOfMeasure("O")
                {
            };
            ohm = 
                new ResqmlUnitOfMeasure("ohm")
                {
            };
            ohmm = 
                new ResqmlUnitOfMeasure("ohm.m")
                {
            };
            pa = 
                new ResqmlUnitOfMeasure("Pa")
                {
            };
            pas = 
                new ResqmlUnitOfMeasure("Pa.s")
                {
            };
            pasmThree = 
                new ResqmlUnitOfMeasure("Pa.s/m3")
                {
            };
            pasmSix = 
                new ResqmlUnitOfMeasure("Pa.s/m6")
                {
            };
            pamThree = 
                new ResqmlUnitOfMeasure("Pa/m3")
                {
            };
            paTwo = 
                new ResqmlUnitOfMeasure("Pa2")
                {
            };
            ph = 
                new ResqmlUnitOfMeasure("pH")
                {
            };
            rad = 
                new ResqmlUnitOfMeasure("rad")
                {
            };
            radm = 
                new ResqmlUnitOfMeasure("rad/m")
                {
            };
            radmThree = 
                new ResqmlUnitOfMeasure("rad/m3")
                {
            };
            rads = 
                new ResqmlUnitOfMeasure("rad/s")
                {
            };
            radsTwo = 
                new ResqmlUnitOfMeasure("rad/s2")
                {
            };
            s = 
                new ResqmlUnitOfMeasure("S")
                {
            };
            sm = 
                new ResqmlUnitOfMeasure("S/m")
                {
            };
            smThree = 
                new ResqmlUnitOfMeasure("s/m3")
                {
            };
            sr = 
                new ResqmlUnitOfMeasure("sr")
                {
            };
            sv = 
                new ResqmlUnitOfMeasure("Sv")
                {
            };
            svs = 
                new ResqmlUnitOfMeasure("Sv/s")
                {
            };
            t = 
                new ResqmlUnitOfMeasure("T")
                {
            };
            v = 
                new ResqmlUnitOfMeasure("V")
                {
            };
            vb = 
                new ResqmlUnitOfMeasure("V/B")
                {
            };
            vm = 
                new ResqmlUnitOfMeasure("V/m")
                {
            };
            w = 
                new ResqmlUnitOfMeasure("W")
                {
            };
            wk = 
                new ResqmlUnitOfMeasure("W/K")
                {
            };
            wmk = 
                new ResqmlUnitOfMeasure("W/m.K")
                {
            };
            wmTwo = 
                new ResqmlUnitOfMeasure("W/m2")
                {
            };
            wmTwok = 
                new ResqmlUnitOfMeasure("W/m2.K")
                {
            };
            wmTwosr = 
                new ResqmlUnitOfMeasure("W/m2.sr")
                {
            };
            wmThree = 
                new ResqmlUnitOfMeasure("W/m3")
                {
            };
            wmThreek = 
                new ResqmlUnitOfMeasure("W/m3.K")
                {
            };
            wsr = 
                new ResqmlUnitOfMeasure("W/sr")
                {
            };
            wb = 
                new ResqmlUnitOfMeasure("Wb")
                {
            };
            wbm = 
                new ResqmlUnitOfMeasure("Wb.m")
                {
            };
        }

        /// <summary>
        /// Gets a ResqmlUnitOfMeasure by name
        /// </summary>
        /// <param name="name">The name of the ResqmlUnitOfMeasure to return</param>
        /// <returns>The ResqmlUnitOfMeasure represented by 'name'</returns>
        public static ResqmlUnitOfMeasure GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ResqmlUnitOfMeasure)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ResqmlUnitOfMeasure)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ResqmlUnitOfMeasure)ev;
                    }
                }
            }
            
            return null;
        }
    }

}
