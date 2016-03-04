using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.RESQML201
{
    /// <summary>
    /// Defines classes of properties. A property inherents the underlying characteristis of its parent but specializes its meaning.
    /// </summary>
    public class ResqmlPropertyKind : Energistics.DataAccess.EnumValue.EnumValue
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
                    Description = "The amount of energy absorbed per mass."
            };
            accelerationLinear = 
                new ResqmlPropertyKind("acceleration linear")
                {
            };
            activityOfRadioactivity = 
                new ResqmlPropertyKind("activity (of radioactivity)")
                {
                    Description = "A measure of the radiation being emitted."
            };
            amountOfSubstance = 
                new ResqmlPropertyKind("amount of substance")
                {
                    Description = "Molar amount of a substance."
            };
            amplitude = 
                new ResqmlPropertyKind("amplitude")
                {
                    Description = "Amplitude of the acoustic signal recorded. It is not a physical property, only a value."
            };
            anglePerLength = 
                new ResqmlPropertyKind("angle per length")
                {
            };
            anglePerTime = 
                new ResqmlPropertyKind("angle per time")
                {
                    Description = "The angular velocity. The rate of change of an angle."
            };
            anglePerVolume = 
                new ResqmlPropertyKind("angle per volume")
                {
            };
            angularAcceleration = 
                new ResqmlPropertyKind("angular acceleration")
                {
            };
            area = 
                new ResqmlPropertyKind("area")
                {
            };
            areaPerArea = 
                new ResqmlPropertyKind("area per area")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is area."
            };
            areaPerVolume = 
                new ResqmlPropertyKind("area per volume")
                {
            };
            attenuation = 
                new ResqmlPropertyKind("attenuation")
                {
                    Description = "A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave."
            };
            attenuationPerLength = 
                new ResqmlPropertyKind("attenuation per length")
                {
            };
            azimuth = 
                new ResqmlPropertyKind("azimuth")
                {
                    Description = "Angle between the North and the projection of the normal to the horizon surface estimated on a local area of the interface."
            };
            bubblePointPressure = 
                new ResqmlPropertyKind("bubble point pressure")
                {
                    Description = "The pressure at which the first gas bubble appears while decreasing pressure on a fluid sample."
            };
            bulkModulus = 
                new ResqmlPropertyKind("bulk modulus")
                {
                    Description = "Bulk modulus, K"
            };
            capacitance = 
                new ResqmlPropertyKind("capacitance")
                {
            };
            categorical = 
                new ResqmlPropertyKind("categorical")
                {
                    Description = "The abstract supertype of all enumerated string properties."
            };
            cellLength = 
                new ResqmlPropertyKind("cell length")
                {
                    Description = "distance from cell face center to cell face center in the specified direction, DI, DJ, DK"
            };
            chargeDensity = 
                new ResqmlPropertyKind("charge density")
                {
            };
            chemicalPotential = 
                new ResqmlPropertyKind("chemical potential")
                {
            };
            code = 
                new ResqmlPropertyKind("code")
                {
                    Description = "A discrete code."
            };
            compressibility = 
                new ResqmlPropertyKind("compressibility")
                {
            };
            concentrationOfB = 
                new ResqmlPropertyKind("concentration of B")
                {
                    Description = "molar concentration of a substance."
            };
            conductivity = 
                new ResqmlPropertyKind("conductivity")
                {
            };
            continuous = 
                new ResqmlPropertyKind("continuous")
                {
                    Description = "The abstract supertype of all floating point properties."
            };
            crossSectionAbsorption = 
                new ResqmlPropertyKind("cross section absorption")
                {
            };
            currentDensity = 
                new ResqmlPropertyKind("current density")
                {
            };
            darcyFlowCoefficient = 
                new ResqmlPropertyKind("Darcy flow coefficient")
                {
            };
            dataTransmissionSpeed = 
                new ResqmlPropertyKind("data transmission speed")
                {
                    Description = "used primarily for computer transmission rates."
            };
            deltaTemperature = 
                new ResqmlPropertyKind("delta temperature")
                {
                    Description = "Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures."
            };
            density = 
                new ResqmlPropertyKind("density")
                {
            };
            depth = 
                new ResqmlPropertyKind("depth")
                {
                    Description = "The perpendicular measurement downward from a surface. Also, the direct linear measurement from the point of viewing usually from front to back."
            };
            diffusionCoefficient = 
                new ResqmlPropertyKind("diffusion coefficient")
                {
            };
            digitalStorage = 
                new ResqmlPropertyKind("digital storage")
                {
            };
            dimensionless = 
                new ResqmlPropertyKind("dimensionless")
                {
                    Description = "A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass."
            };
            dip = 
                new ResqmlPropertyKind("dip")
                {
                    Description = "In the azimuth direction, Angle between an horizon plane and an estimated plane on a local area of the interface."
            };
            discrete = 
                new ResqmlPropertyKind("discrete")
                {
                    Description = "The abstract supertype of all integer properties."
            };
            doseEquivalent = 
                new ResqmlPropertyKind("dose equivalent")
                {
            };
            doseEquivalentRate = 
                new ResqmlPropertyKind("dose equivalent rate")
                {
            };
            dynamicViscosity = 
                new ResqmlPropertyKind("dynamic viscosity")
                {
            };
            electricCharge = 
                new ResqmlPropertyKind("electric charge")
                {
            };
            electricConductance = 
                new ResqmlPropertyKind("electric conductance")
                {
            };
            electricCurrent = 
                new ResqmlPropertyKind("electric current")
                {
            };
            electricDipoleMoment = 
                new ResqmlPropertyKind("electric dipole moment")
                {
            };
            electricFieldStrength = 
                new ResqmlPropertyKind("electric field strength")
                {
            };
            electricPolarization = 
                new ResqmlPropertyKind("electric polarization")
                {
            };
            electricPotential = 
                new ResqmlPropertyKind("electric potential")
                {
            };
            electricalResistivity = 
                new ResqmlPropertyKind("electrical resistivity")
                {
            };
            electrochemicalEquivalent = 
                new ResqmlPropertyKind("electrochemical equivalent")
                {
                    Description = "An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered."
            };
            electromagneticMoment = 
                new ResqmlPropertyKind("electromagnetic moment")
                {
            };
            energyLengthPerArea = 
                new ResqmlPropertyKind("energy length per area")
                {
            };
            energyLengthPerTimeAreaTemperature = 
                new ResqmlPropertyKind("energy length per time area temperature")
                {
            };
            energyPerArea = 
                new ResqmlPropertyKind("energy per area")
                {
            };
            energyPerLength = 
                new ResqmlPropertyKind("energy per length")
                {
            };
            equivalentPerMass = 
                new ResqmlPropertyKind("equivalent per mass")
                {
            };
            equivalentPerVolume = 
                new ResqmlPropertyKind("equivalent per volume")
                {
            };
            exposureRadioactivity = 
                new ResqmlPropertyKind("exposure (radioactivity)")
                {
            };
            fluidVolume = 
                new ResqmlPropertyKind("fluid volume")
                {
                    Description = "Volume of fluid"
            };
            force = 
                new ResqmlPropertyKind("force")
                {
            };
            forceArea = 
                new ResqmlPropertyKind("force area")
                {
            };
            forceLengthPerLength = 
                new ResqmlPropertyKind("force length per length")
                {
            };
            forcePerForce = 
                new ResqmlPropertyKind("force per force")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is force."
            };
            forcePerLength = 
                new ResqmlPropertyKind("force per length")
                {
            };
            forcePerVolume = 
                new ResqmlPropertyKind("force per volume")
                {
            };
            formationVolumeFactor = 
                new ResqmlPropertyKind("formation volume factor")
                {
                    Description = "Ratio of volumes at subsurface and surface conditions"
            };
            frequency = 
                new ResqmlPropertyKind("frequency")
                {
            };
            frequencyInterval = 
                new ResqmlPropertyKind("frequency interval")
                {
                    Description = "An octave is a doubling of a frquency."
            };
            gammaRayApiUnit = 
                new ResqmlPropertyKind("gamma ray API unit")
                {
                    Description = "This class is defined by the API, and is used for units of gamma ray log response."
            };
            heatCapacity = 
                new ResqmlPropertyKind("heat capacity")
                {
            };
            heatFlowRate = 
                new ResqmlPropertyKind("heat flow rate")
                {
            };
            heatTransferCoefficient = 
                new ResqmlPropertyKind("heat transfer coefficient")
                {
                    Description = "PRESSURE PER VELOCITY PER AREA"
            };
            illuminance = 
                new ResqmlPropertyKind("illuminance")
                {
            };
            index = 
                new ResqmlPropertyKind("index")
                {
                    Description = "Serial ordering"
            };
            irradiance = 
                new ResqmlPropertyKind("irradiance")
                {
            };
            isothermalCompressibility = 
                new ResqmlPropertyKind("isothermal compressibility")
                {
            };
            kinematicViscosity = 
                new ResqmlPropertyKind("kinematic viscosity")
                {
            };
            lambdaRho = 
                new ResqmlPropertyKind("Lambda Rho")
                {
                    Description = "Product of Lame constant and density, LR"
            };
            lameConstant = 
                new ResqmlPropertyKind("Lame constant")
                {
                    Description = "Lame constant, Lambda"
            };
            length = 
                new ResqmlPropertyKind("length")
                {
            };
            lengthPerLength = 
                new ResqmlPropertyKind("length per length")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is length."
            };
            lengthPerTemperature = 
                new ResqmlPropertyKind("length per temperature")
                {
            };
            lengthPerVolume = 
                new ResqmlPropertyKind("length per volume")
                {
            };
            levelOfPowerIntensity = 
                new ResqmlPropertyKind("level of power intensity")
                {
            };
            lightExposure = 
                new ResqmlPropertyKind("light exposure")
                {
            };
            linearThermalExpansion = 
                new ResqmlPropertyKind("linear thermal expansion")
                {
            };
            luminance = 
                new ResqmlPropertyKind("luminance")
                {
            };
            luminousEfficacy = 
                new ResqmlPropertyKind("luminous efficacy")
                {
            };
            luminousFlux = 
                new ResqmlPropertyKind("luminous flux")
                {
            };
            luminousIntensity = 
                new ResqmlPropertyKind("luminous intensity")
                {
            };
            magneticDipoleMoment = 
                new ResqmlPropertyKind("magnetic dipole moment")
                {
            };
            magneticFieldStrength = 
                new ResqmlPropertyKind("magnetic field strength")
                {
            };
            magneticFlux = 
                new ResqmlPropertyKind("magnetic flux")
                {
            };
            magneticInduction = 
                new ResqmlPropertyKind("magnetic induction")
                {
            };
            magneticPermeability = 
                new ResqmlPropertyKind("magnetic permeability")
                {
            };
            magneticVectorPotential = 
                new ResqmlPropertyKind("magnetic vector potential")
                {
            };
            mass = 
                new ResqmlPropertyKind("mass")
                {
                    Description = "M/L2T"
            };
            massAttenuationCoefficient = 
                new ResqmlPropertyKind("mass attenuation coefficient")
                {
            };
            massConcentration = 
                new ResqmlPropertyKind("mass concentration")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is mass."
            };
            massFlowRate = 
                new ResqmlPropertyKind("mass flow rate")
                {
            };
            massLength = 
                new ResqmlPropertyKind("mass length")
                {
            };
            massPerEnergy = 
                new ResqmlPropertyKind("mass per energy")
                {
            };
            massPerLength = 
                new ResqmlPropertyKind("mass per length")
                {
                    Description = "M /L4T"
            };
            massPerTimePerArea = 
                new ResqmlPropertyKind("mass per time per area")
                {
            };
            massPerTimePerLength = 
                new ResqmlPropertyKind("mass per time per length")
                {
            };
            massPerVolumePerLength = 
                new ResqmlPropertyKind("mass per volume per length")
                {
            };
            mobility = 
                new ResqmlPropertyKind("mobility")
                {
            };
            modulusOfCompression = 
                new ResqmlPropertyKind("modulus of compression")
                {
            };
            molarConcentration = 
                new ResqmlPropertyKind("molar concentration")
                {
                    Description = "molar concentration of a substance."
            };
            molarHeatCapacity = 
                new ResqmlPropertyKind("molar heat capacity")
                {
            };
            molarVolume = 
                new ResqmlPropertyKind("molar volume")
                {
            };
            molePerArea = 
                new ResqmlPropertyKind("mole per area")
                {
            };
            molePerTime = 
                new ResqmlPropertyKind("mole per time")
                {
            };
            molePerTimePerArea = 
                new ResqmlPropertyKind("mole per time per area")
                {
            };
            momentOfForce = 
                new ResqmlPropertyKind("moment of force")
                {
            };
            momentOfInertia = 
                new ResqmlPropertyKind("moment of inertia")
                {
            };
            momentOfSection = 
                new ResqmlPropertyKind("moment of section")
                {
            };
            momentum = 
                new ResqmlPropertyKind("momentum")
                {
            };
            muRho = 
                new ResqmlPropertyKind("Mu Rho")
                {
                    Description = "Product of Shear modulus and density, MR"
            };
            netToGrossRatio = 
                new ResqmlPropertyKind("net to gross ratio")
                {
                    Description = "Ratio of net rock volume to gross rock volume, NTG"
            };
            neutronApiUnit = 
                new ResqmlPropertyKind("neutron API unit")
                {
            };
            nondarcyFlowCoefficient = 
                new ResqmlPropertyKind("nonDarcy flow coefficient")
                {
            };
            operationsPerTime = 
                new ResqmlPropertyKind("operations per time")
                {
            };
            parachor = 
                new ResqmlPropertyKind("parachor")
                {
            };
            perArea = 
                new ResqmlPropertyKind("per area")
                {
            };
            perElectricPotential = 
                new ResqmlPropertyKind("per electric potential")
                {
            };
            perForce = 
                new ResqmlPropertyKind("per force")
                {
            };
            perLength = 
                new ResqmlPropertyKind("per length")
                {
            };
            perMass = 
                new ResqmlPropertyKind("per mass")
                {
            };
            perVolume = 
                new ResqmlPropertyKind("per volume")
                {
            };
            permeabilityLength = 
                new ResqmlPropertyKind("permeability length")
                {
            };
            permeabilityRock = 
                new ResqmlPropertyKind("permeability rock")
                {
            };
            permeabilityThickness = 
                new ResqmlPropertyKind("permeability thickness")
                {
                    Description = "Product of permeability and thickness"
            };
            permeance = 
                new ResqmlPropertyKind("permeance")
                {
            };
            permittivity = 
                new ResqmlPropertyKind("permittivity")
                {
            };
            ph = 
                new ResqmlPropertyKind("pH")
                {
                    Description = "The pH is a class that measures the hydrogen ion concentration (acidity)."
            };
            planeAngle = 
                new ResqmlPropertyKind("plane angle")
                {
            };
            poissonRatio = 
                new ResqmlPropertyKind("Poisson ratio")
                {
                    Description = "Poisson's ratio, Sigma"
            };
            poreVolume = 
                new ResqmlPropertyKind("pore volume")
                {
                    Description = "Volume of the Pore Space of the Rock"
            };
            porosity = 
                new ResqmlPropertyKind("porosity")
                {
                    Description = "porosity"
            };
            potentialDifferencePerPowerDrop = 
                new ResqmlPropertyKind("potential difference per power drop")
                {
            };
            power = 
                new ResqmlPropertyKind("power")
                {
            };
            powerPerVolume = 
                new ResqmlPropertyKind("power per volume")
                {
            };
            pressure = 
                new ResqmlPropertyKind("pressure")
                {
            };
            pressurePerTime = 
                new ResqmlPropertyKind("pressure per time")
                {
            };
            pressureSquared = 
                new ResqmlPropertyKind("pressure squared")
                {
            };
            pressureSquaredPerForceTimePerArea = 
                new ResqmlPropertyKind("pressure squared per force time per area")
                {
            };
            pressureTimePerVolume = 
                new ResqmlPropertyKind("pressure time per volume")
                {
            };
            productivityIndex = 
                new ResqmlPropertyKind("productivity index")
                {
            };
            propertyMultiplier = 
                new ResqmlPropertyKind("property multiplier")
                {
                    Description = "Unitless multiplier to apply to any property"
            };
            quantity = 
                new ResqmlPropertyKind("quantity")
                {
                    Description = "The abstract supertype of all floating point properties with a unit of measure."
            };
            quantityOfLight = 
                new ResqmlPropertyKind("quantity of light")
                {
            };
            radiance = 
                new ResqmlPropertyKind("radiance")
                {
            };
            radiantIntensity = 
                new ResqmlPropertyKind("radiant intensity")
                {
            };
            relativePermeability = 
                new ResqmlPropertyKind("relative permeability")
                {
                    Description = "Ratio of phase permeability, which is a function of saturation, to the rock permeability"
            };
            relativePower = 
                new ResqmlPropertyKind("relative power")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is power."
            };
            relativeTime = 
                new ResqmlPropertyKind("relative time")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is time."
            };
            reluctance = 
                new ResqmlPropertyKind("reluctance")
                {
            };
            resistance = 
                new ResqmlPropertyKind("resistance")
                {
            };
            resistivityPerLength = 
                new ResqmlPropertyKind("resistivity per length")
                {
            };
            resqmlRootProperty = 
                new ResqmlPropertyKind("RESQML root property")
                {
                    Description = "The abstract supertype of all properties. This property does not have a parent."
            };
            rockImpedance = 
                new ResqmlPropertyKind("Rock Impedance")
                {
                    Description = "Acoustic impedence, Ip, Is"
            };
            rockPermeability = 
                new ResqmlPropertyKind("rock permeability")
                {
                    Description = "See \"permeability rock\""
            };
            rockVolume = 
                new ResqmlPropertyKind("rock volume")
                {
                    Description = "Rock Volume"
            };
            saturation = 
                new ResqmlPropertyKind("saturation")
                {
                    Description = "Ratio of phase fluid volume to pore volume"
            };
            secondMomentOfArea = 
                new ResqmlPropertyKind("second moment of area")
                {
            };
            shearModulus = 
                new ResqmlPropertyKind("shear modulus")
                {
                    Description = "Shear modulus, Mu"
            };
            solidAngle = 
                new ResqmlPropertyKind("solid angle")
                {
            };
            solutionGasoilRatio = 
                new ResqmlPropertyKind("solution gas-oil ratio")
                {
                    Description = "Ratio of solution gas volume to oil volume at reservoir conditions"
            };
            specificActivityOfRadioactivity = 
                new ResqmlPropertyKind("specific activity (of radioactivity)")
                {
            };
            specificEnergy = 
                new ResqmlPropertyKind("specific energy")
                {
            };
            specificHeatCapacity = 
                new ResqmlPropertyKind("specific heat capacity")
                {
            };
            specificProductivityIndex = 
                new ResqmlPropertyKind("specific productivity index")
                {
            };
            specificVolume = 
                new ResqmlPropertyKind("specific volume")
                {
            };
            surfaceDensity = 
                new ResqmlPropertyKind("surface density")
                {
            };
            temperaturePerLength = 
                new ResqmlPropertyKind("temperature per length")
                {
            };
            temperaturePerTime = 
                new ResqmlPropertyKind("temperature per time")
                {
            };
            thermalConductance = 
                new ResqmlPropertyKind("thermal conductance")
                {
            };
            thermalConductivity = 
                new ResqmlPropertyKind("thermal conductivity")
                {
            };
            thermalDiffusivity = 
                new ResqmlPropertyKind("thermal diffusivity")
                {
            };
            thermalInsulance = 
                new ResqmlPropertyKind("thermal insulance")
                {
            };
            thermalResistance = 
                new ResqmlPropertyKind("thermal resistance")
                {
            };
            thermodynamicTemperature = 
                new ResqmlPropertyKind("thermodynamic temperature")
                {
            };
            thickness = 
                new ResqmlPropertyKind("thickness")
                {
                    Description = "Distance measured in a volume between two surfaces ( e.G. Geological Top Boundary and Geological Bottom Boundary of a Geological unit)."
            };
            time = 
                new ResqmlPropertyKind("time")
                {
            };
            timePerLength = 
                new ResqmlPropertyKind("time per length")
                {
            };
            timePerVolume = 
                new ResqmlPropertyKind("time per volume")
                {
            };
            transmissibility = 
                new ResqmlPropertyKind("transmissibility")
                {
                    Description = "Volumetric flux per unit area per unit pressure drop for unit viscosity fluid"
            };
            unitProductivityIndex = 
                new ResqmlPropertyKind("unit productivity index")
                {
            };
            unitless = 
                new ResqmlPropertyKind("unitless")
                {
                    Description = "The abstract supertype of all floating point properties with NO unit of measure. In order to allow the unit information to be required for all continuous properties, the special unit of measure of \"NONE\" has been assigned to all children of this class. In addition, the special dimensional class of \"0\" has been assigned to all children of this class."
            };
            vaporOilgasRatio = 
                new ResqmlPropertyKind("vapor oil-gas ratio")
                {
                    Description = "Ratio of oil vapor volume to gas volume at reservoir conditions"
            };
            velocity = 
                new ResqmlPropertyKind("velocity")
                {
            };
            volume = 
                new ResqmlPropertyKind("volume")
                {
            };
            volumeFlowRate = 
                new ResqmlPropertyKind("volume flow rate")
                {
            };
            volumeLengthPerTime = 
                new ResqmlPropertyKind("volume length per time")
                {
            };
            volumePerArea = 
                new ResqmlPropertyKind("volume per area")
                {
            };
            volumePerLength = 
                new ResqmlPropertyKind("volume per length")
                {
            };
            volumePerTimePerArea = 
                new ResqmlPropertyKind("volume per time per area")
                {
            };
            volumePerTimePerLength = 
                new ResqmlPropertyKind("volume per time per length")
                {
            };
            volumePerTimePerTime = 
                new ResqmlPropertyKind("volume per time per time")
                {
            };
            volumePerTimePerVolume = 
                new ResqmlPropertyKind("volume per time per volume")
                {
            };
            volumePerVolume = 
                new ResqmlPropertyKind("volume per volume")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is volume."
            };
            volumetricHeatTransferCoefficient = 
                new ResqmlPropertyKind("volumetric heat transfer coefficient")
                {
            };
            volumetricThermalExpansion = 
                new ResqmlPropertyKind("volumetric thermal expansion")
                {
            };
            work = 
                new ResqmlPropertyKind("work")
                {
            };
            youngModulus = 
                new ResqmlPropertyKind("Young modulus")
                {
                    Description = "Young's modulus, E"
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

}
