using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.WITSML141
{
    /// <summary>
    /// Activity codes.
    /// </summary>
    public class ActivityCode : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ActivityCode(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ActivityCode</param>
        public ActivityCode(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ActivityCodes
        /// </summary>
        /// <returns>The complete list of ActivityCodes</returns>
        public static List<ActivityCode> GetList()
        {
            return GetList<ActivityCode>();
        }

        private readonly static ActivityCode abandonment;
        /// <summary>
        /// abandonment
        /// </summary>
        [EnumValueNameAttribute("abandonment")]
        public static ActivityCode Abandonment
        {
            get 
            {
                return abandonment;
            }
        }

        private readonly static ActivityCode abandonmentLogPlugs;
        /// <summary>
        /// A specialization of 'abandonment'.
        /// </summary>
        [EnumValueNameAttribute("abandonment -- log plugs")]
        public static ActivityCode AbandonmentLogPlugs
        {
            get 
            {
                return abandonmentLogPlugs;
            }
        }

        private readonly static ActivityCode abandonmentRunPlugs;
        /// <summary>
        /// A specialization of 'abandonment'.
        /// </summary>
        [EnumValueNameAttribute("abandonment -- run plugs")]
        public static ActivityCode AbandonmentRunPlugs
        {
            get 
            {
                return abandonmentRunPlugs;
            }
        }

        private readonly static ActivityCode abandonmentWaitOnCement;
        /// <summary>
        /// A specialization of 'abandonment'.
        /// </summary>
        [EnumValueNameAttribute("abandonment -- wait on cement")]
        public static ActivityCode AbandonmentWaitOnCement
        {
            get 
            {
                return abandonmentWaitOnCement;
            }
        }

        private readonly static ActivityCode casingCement;
        /// <summary>
        /// casing and cement
        /// </summary>
        [EnumValueNameAttribute("casing, cement")]
        public static ActivityCode CasingCement
        {
            get 
            {
                return casingCement;
            }
        }

        private readonly static ActivityCode casingCementCirculateCement;
        /// <summary>
        /// A specialization of 'casing, cement': circulate and cement
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- circulate, cement")]
        public static ActivityCode CasingCementCirculateCement
        {
            get 
            {
                return casingCementCirculateCement;
            }
        }

        private readonly static ActivityCode casingCementOther;
        /// <summary>
        /// A specialization of 'casing, cement'.
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- other")]
        public static ActivityCode CasingCementOther
        {
            get 
            {
                return casingCementOther;
            }
        }

        private readonly static ActivityCode casingCementRigUpRunCasing;
        /// <summary>
        /// A specialization of 'casing, cement': rig up and run casing
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- rig up, run casing")]
        public static ActivityCode CasingCementRigUpRunCasing
        {
            get 
            {
                return casingCementRigUpRunCasing;
            }
        }

        private readonly static ActivityCode casingCementRigUpRunLiner;
        /// <summary>
        /// A specialization of 'casing, cement': rig up and run liner
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- rig up, run liner")]
        public static ActivityCode CasingCementRigUpRunLiner
        {
            get 
            {
                return casingCementRigUpRunLiner;
            }
        }

        private readonly static ActivityCode casingCementWaitOnCement;
        /// <summary>
        /// A specialization of 'casing, cement'.
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- wait on cement")]
        public static ActivityCode CasingCementWaitOnCement
        {
            get 
            {
                return casingCementWaitOnCement;
            }
        }

        private readonly static ActivityCode completionOperations;
        /// <summary>
        /// After reaching total depth, any operations for completing the well and bringing it on production - no further detail is known.
        /// </summary>
        [EnumValueNameAttribute("completion operations")]
        public static ActivityCode CompletionOperations
        {
            get 
            {
                return completionOperations;
            }
        }

        private readonly static ActivityCode completionOperationsRigUp;
        /// <summary>
        /// Rig up completion equipment.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- rig up")]
        public static ActivityCode CompletionOperationsRigUp
        {
            get 
            {
                return completionOperationsRigUp;
            }
        }

        private readonly static ActivityCode completionOperationsTearDown;
        /// <summary>
        /// Tear down completion equipment.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- tear down")]
        public static ActivityCode CompletionOperationsTearDown
        {
            get 
            {
                return completionOperationsTearDown;
            }
        }

        private readonly static ActivityCode completionOperationsTesting;
        /// <summary>
        /// Pre-production flow testing in the well completion phase.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- testing ")]
        public static ActivityCode CompletionOperationsTesting
        {
            get 
            {
                return completionOperationsTesting;
            }
        }

        private readonly static ActivityCode completionOperationsRunningLiner;
        /// <summary>
        /// Running the production liner.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- running liner")]
        public static ActivityCode CompletionOperationsRunningLiner
        {
            get 
            {
                return completionOperationsRunningLiner;
            }
        }

        private readonly static ActivityCode completionOperationsGravelPacking;
        /// <summary>
        /// Completion operation for producing zones.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- gravel packing")]
        public static ActivityCode CompletionOperationsGravelPacking
        {
            get 
            {
                return completionOperationsGravelPacking;
            }
        }

        private readonly static ActivityCode completionOperationsLogging;
        /// <summary>
        /// Production logging tool runs.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- logging")]
        public static ActivityCode CompletionOperationsLogging
        {
            get 
            {
                return completionOperationsLogging;
            }
        }

        private readonly static ActivityCode condMudCirculate;
        /// <summary>
        /// condition mud and circulate
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate")]
        public static ActivityCode CondMudCirculate
        {
            get 
            {
                return condMudCirculate;
            }
        }

        private readonly static ActivityCode condMudCirculateBoulderOrGravel;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- boulder or gravel")]
        public static ActivityCode CondMudCirculateBoulderOrGravel
        {
            get 
            {
                return condMudCirculateBoulderOrGravel;
            }
        }

        private readonly static ActivityCode condMudCirculateCasing;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- casing")]
        public static ActivityCode CondMudCirculateCasing
        {
            get 
            {
                return condMudCirculateCasing;
            }
        }

        private readonly static ActivityCode condMudCirculateCementing;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- cementing")]
        public static ActivityCode CondMudCirculateCementing
        {
            get 
            {
                return condMudCirculateCementing;
            }
        }

        private readonly static ActivityCode condMudCirculateCirculateSamples;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- circulate samples")]
        public static ActivityCode CondMudCirculateCirculateSamples
        {
            get 
            {
                return condMudCirculateCirculateSamples;
            }
        }

        private readonly static ActivityCode condMudCirculateCoring;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- coring")]
        public static ActivityCode CondMudCirculateCoring
        {
            get 
            {
                return condMudCirculateCoring;
            }
        }

        private readonly static ActivityCode condMudCirculateDrilling;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- drilling")]
        public static ActivityCode CondMudCirculateDrilling
        {
            get 
            {
                return condMudCirculateDrilling;
            }
        }

        private readonly static ActivityCode condMudCirculateFishing;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- fishing")]
        public static ActivityCode CondMudCirculateFishing
        {
            get 
            {
                return condMudCirculateFishing;
            }
        }

        private readonly static ActivityCode condMudCirculateGumboAttack;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- gumbo attack")]
        public static ActivityCode CondMudCirculateGumboAttack
        {
            get 
            {
                return condMudCirculateGumboAttack;
            }
        }

        private readonly static ActivityCode condMudCirculateLogging;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- logging")]
        public static ActivityCode CondMudCirculateLogging
        {
            get 
            {
                return condMudCirculateLogging;
            }
        }

        private readonly static ActivityCode condMudCirculateLostCirculation;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- lost circulation")]
        public static ActivityCode CondMudCirculateLostCirculation
        {
            get 
            {
                return condMudCirculateLostCirculation;
            }
        }

        private readonly static ActivityCode condMudCirculateWellControl;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- well control")]
        public static ActivityCode CondMudCirculateWellControl
        {
            get 
            {
                return condMudCirculateWellControl;
            }
        }

        private readonly static ActivityCode coring;
        /// <summary>
        /// coring
        /// </summary>
        [EnumValueNameAttribute("coring")]
        public static ActivityCode Coring
        {
            get 
            {
                return coring;
            }
        }

        private readonly static ActivityCode coringConventional;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- conventional")]
        public static ActivityCode CoringConventional
        {
            get 
            {
                return coringConventional;
            }
        }

        private readonly static ActivityCode coringFlowCheck;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- flow check")]
        public static ActivityCode CoringFlowCheck
        {
            get 
            {
                return coringFlowCheck;
            }
        }

        private readonly static ActivityCode coringLaydownBarrel;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- laydown barrel")]
        public static ActivityCode CoringLaydownBarrel
        {
            get 
            {
                return coringLaydownBarrel;
            }
        }

        private readonly static ActivityCode coringOriented;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- oriented")]
        public static ActivityCode CoringOriented
        {
            get 
            {
                return coringOriented;
            }
        }

        private readonly static ActivityCode coringPlasticSleeve;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- plastic sleeve")]
        public static ActivityCode CoringPlasticSleeve
        {
            get 
            {
                return coringPlasticSleeve;
            }
        }

        private readonly static ActivityCode coringRigUpCoreBarrel;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- rig up core barrel")]
        public static ActivityCode CoringRigUpCoreBarrel
        {
            get 
            {
                return coringRigUpCoreBarrel;
            }
        }

        private readonly static ActivityCode coringSponge;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- sponge")]
        public static ActivityCode CoringSponge
        {
            get 
            {
                return coringSponge;
            }
        }

        private readonly static ActivityCode cutSlipDrillingLine;
        /// <summary>
        /// cut and slip drilling line
        /// </summary>
        [EnumValueNameAttribute("cut, slip drilling line")]
        public static ActivityCode CutSlipDrillingLine
        {
            get 
            {
                return cutSlipDrillingLine;
            }
        }

        private readonly static ActivityCode deviationSurvey;
        /// <summary>
        /// deviation survey
        /// </summary>
        [EnumValueNameAttribute("deviation survey")]
        public static ActivityCode DeviationSurvey
        {
            get 
            {
                return deviationSurvey;
            }
        }

        private readonly static ActivityCode deviationSurveyDirMultishot;
        /// <summary>
        /// A specialization of 'deviation survey': directional multi-shot
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- dir multi-shot")]
        public static ActivityCode DeviationSurveyDirMultishot
        {
            get 
            {
                return deviationSurveyDirMultishot;
            }
        }

        private readonly static ActivityCode deviationSurveyDirSingleShot;
        /// <summary>
        /// A specialization of 'deviation survey': directional single shot
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- dir single shot")]
        public static ActivityCode DeviationSurveyDirSingleShot
        {
            get 
            {
                return deviationSurveyDirSingleShot;
            }
        }

        private readonly static ActivityCode deviationSurveyDrift;
        /// <summary>
        /// A specialization of 'deviation survey'.
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- drift")]
        public static ActivityCode DeviationSurveyDrift
        {
            get 
            {
                return deviationSurveyDrift;
            }
        }

        private readonly static ActivityCode deviationSurveyGyro;
        /// <summary>
        /// A specialization of 'deviation survey'.
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- gyro")]
        public static ActivityCode DeviationSurveyGyro
        {
            get 
            {
                return deviationSurveyGyro;
            }
        }

        private readonly static ActivityCode deviationSurveyMwd;
        /// <summary>
        /// A specialization of 'deviation survey'.
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- MWD")]
        public static ActivityCode DeviationSurveyMwd
        {
            get 
            {
                return deviationSurveyMwd;
            }
        }

        private readonly static ActivityCode dirWork;
        /// <summary>
        /// directional work
        /// </summary>
        [EnumValueNameAttribute("dir work")]
        public static ActivityCode DirWork
        {
            get 
            {
                return dirWork;
            }
        }

        private readonly static ActivityCode dirWorkHorizontalDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- horizontal drilling")]
        public static ActivityCode DirWorkHorizontalDrilling
        {
            get 
            {
                return dirWorkHorizontalDrilling;
            }
        }

        private readonly static ActivityCode dirWorkMotorDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- motor drilling")]
        public static ActivityCode DirWorkMotorDrilling
        {
            get 
            {
                return dirWorkMotorDrilling;
            }
        }

        private readonly static ActivityCode dirWorkOrient;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- orient")]
        public static ActivityCode DirWorkOrient
        {
            get 
            {
                return dirWorkOrient;
            }
        }

        private readonly static ActivityCode dirWorkRotaryDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- rotary drilling")]
        public static ActivityCode DirWorkRotaryDrilling
        {
            get 
            {
                return dirWorkRotaryDrilling;
            }
        }

        private readonly static ActivityCode dirWorkSlantDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- slant drilling")]
        public static ActivityCode DirWorkSlantDrilling
        {
            get 
            {
                return dirWorkSlantDrilling;
            }
        }

        private readonly static ActivityCode dst;
        /// <summary>
        /// drill stem test
        /// </summary>
        [EnumValueNameAttribute("DST")]
        public static ActivityCode Dst
        {
            get 
            {
                return dst;
            }
        }

        private readonly static ActivityCode dstCasedHole;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- cased hole")]
        public static ActivityCode DstCasedHole
        {
            get 
            {
                return dstCasedHole;
            }
        }

        private readonly static ActivityCode dstLayDownTools;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- lay down tools")]
        public static ActivityCode DstLayDownTools
        {
            get 
            {
                return dstLayDownTools;
            }
        }

        private readonly static ActivityCode dstOpenHole;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- open hole")]
        public static ActivityCode DstOpenHole
        {
            get 
            {
                return dstOpenHole;
            }
        }

        private readonly static ActivityCode dstOpenHoleClosedChamber;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- open hole closed chamber")]
        public static ActivityCode DstOpenHoleClosedChamber
        {
            get 
            {
                return dstOpenHoleClosedChamber;
            }
        }

        private readonly static ActivityCode dstRigUpTools;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- rig up tools")]
        public static ActivityCode DstRigUpTools
        {
            get 
            {
                return dstRigUpTools;
            }
        }

        private readonly static ActivityCode drilling;
        /// <summary>
        /// drilling
        /// </summary>
        [EnumValueNameAttribute("drilling")]
        public static ActivityCode Drilling
        {
            get 
            {
                return drilling;
            }
        }

        private readonly static ActivityCode drillingCasing;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- casing")]
        public static ActivityCode DrillingCasing
        {
            get 
            {
                return drillingCasing;
            }
        }

        private readonly static ActivityCode drillingConnection;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- connection")]
        public static ActivityCode DrillingConnection
        {
            get 
            {
                return drillingConnection;
            }
        }

        private readonly static ActivityCode drillingDrillCementFloatEquip;
        /// <summary>
        /// A specialization of 'drilling': drill out cement and/or float equipment
        /// </summary>
        [EnumValueNameAttribute("drilling -- drill cement, float equip")]
        public static ActivityCode DrillingDrillCementFloatEquip
        {
            get 
            {
                return drillingDrillCementFloatEquip;
            }
        }

        private readonly static ActivityCode drillingFlowCheck;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- flow check")]
        public static ActivityCode DrillingFlowCheck
        {
            get 
            {
                return drillingFlowCheck;
            }
        }

        private readonly static ActivityCode drillingHoleOpening;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- hole opening")]
        public static ActivityCode DrillingHoleOpening
        {
            get 
            {
                return drillingHoleOpening;
            }
        }

        private readonly static ActivityCode drillingNewHole;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- new hole")]
        public static ActivityCode DrillingNewHole
        {
            get 
            {
                return drillingNewHole;
            }
        }

        private readonly static ActivityCode drillingSidetracking;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- sidetracking")]
        public static ActivityCode DrillingSidetracking
        {
            get 
            {
                return drillingSidetracking;
            }
        }

        private readonly static ActivityCode drillingUnderreaming;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- under-reaming")]
        public static ActivityCode DrillingUnderreaming
        {
            get 
            {
                return drillingUnderreaming;
            }
        }

        private readonly static ActivityCode fishing;
        /// <summary>
        /// fishing
        /// </summary>
        [EnumValueNameAttribute("fishing")]
        public static ActivityCode Fishing
        {
            get 
            {
                return fishing;
            }
        }

        private readonly static ActivityCode fishingBha;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- BHA")]
        public static ActivityCode FishingBha
        {
            get 
            {
                return fishingBha;
            }
        }

        private readonly static ActivityCode fishingCasing;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- casing")]
        public static ActivityCode FishingCasing
        {
            get 
            {
                return fishingCasing;
            }
        }

        private readonly static ActivityCode fishingCones;
        /// <summary>
        /// >A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- cones")]
        public static ActivityCode FishingCones
        {
            get 
            {
                return fishingCones;
            }
        }

        private readonly static ActivityCode fishingOther;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- other")]
        public static ActivityCode FishingOther
        {
            get 
            {
                return fishingOther;
            }
        }

        private readonly static ActivityCode fishingStuckPipe;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- stuck pipe")]
        public static ActivityCode FishingStuckPipe
        {
            get 
            {
                return fishingStuckPipe;
            }
        }

        private readonly static ActivityCode fishingWirelineTools;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- wireline tools")]
        public static ActivityCode FishingWirelineTools
        {
            get 
            {
                return fishingWirelineTools;
            }
        }

        private readonly static ActivityCode hse;
        /// <summary>
        /// Health, Safety and Environmental
        /// </summary>
        [EnumValueNameAttribute("HSE")]
        public static ActivityCode Hse
        {
            get 
            {
                return hse;
            }
        }

        private readonly static ActivityCode hseHoldDrill;
        /// <summary>
        /// A specialization of 'HSE'.
        /// </summary>
        [EnumValueNameAttribute("HSE -- hold drill")]
        public static ActivityCode HseHoldDrill
        {
            get 
            {
                return hseHoldDrill;
            }
        }

        private readonly static ActivityCode hseIncident;
        /// <summary>
        /// A specialization of 'HSE'.
        /// </summary>
        [EnumValueNameAttribute("HSE -- incident")]
        public static ActivityCode HseIncident
        {
            get 
            {
                return hseIncident;
            }
        }

        private readonly static ActivityCode hseSafetyMeeting;
        /// <summary>
        /// A specialization of 'HSE'.
        /// </summary>
        [EnumValueNameAttribute("HSE -- safety meeting")]
        public static ActivityCode HseSafetyMeeting
        {
            get 
            {
                return hseSafetyMeeting;
            }
        }

        private readonly static ActivityCode mill;
        /// <summary>
        /// mill
        /// </summary>
        [EnumValueNameAttribute("mill")]
        public static ActivityCode Mill
        {
            get 
            {
                return mill;
            }
        }

        private readonly static ActivityCode millCutCasingOrTubing;
        /// <summary>
        /// A specialization of 'mill'.
        /// </summary>
        [EnumValueNameAttribute("mill -- cut casing or tubing")]
        public static ActivityCode MillCutCasingOrTubing
        {
            get 
            {
                return millCutCasingOrTubing;
            }
        }

        private readonly static ActivityCode millMilling;
        /// <summary>
        /// A specialization of 'mill'.
        /// </summary>
        [EnumValueNameAttribute("mill -- milling")]
        public static ActivityCode MillMilling
        {
            get 
            {
                return millMilling;
            }
        }

        private readonly static ActivityCode miscellaneous;
        /// <summary>
        /// miscellaneous
        /// </summary>
        [EnumValueNameAttribute("miscellaneous")]
        public static ActivityCode Miscellaneous
        {
            get 
            {
                return miscellaneous;
            }
        }

        private readonly static ActivityCode nippleUpBop;
        /// <summary>
        /// nipple up blowout preventer
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP")]
        public static ActivityCode NippleUpBop
        {
            get 
            {
                return nippleUpBop;
            }
        }

        private readonly static ActivityCode nippleUpBopDiverter;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- diverter")]
        public static ActivityCode NippleUpBopDiverter
        {
            get 
            {
                return nippleUpBopDiverter;
            }
        }

        private readonly static ActivityCode nippleUpBopManifold;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- manifold")]
        public static ActivityCode NippleUpBopManifold
        {
            get 
            {
                return nippleUpBopManifold;
            }
        }

        private readonly static ActivityCode nippleUpBopOther;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- other")]
        public static ActivityCode NippleUpBopOther
        {
            get 
            {
                return nippleUpBopOther;
            }
        }

        private readonly static ActivityCode nippleUpBopPvtSystem;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- PVT system")]
        public static ActivityCode NippleUpBopPvtSystem
        {
            get 
            {
                return nippleUpBopPvtSystem;
            }
        }

        private readonly static ActivityCode nippleUpBopStack;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- stack")]
        public static ActivityCode NippleUpBopStack
        {
            get 
            {
                return nippleUpBopStack;
            }
        }

        private readonly static ActivityCode plugBack;
        /// <summary>
        /// plug back
        /// </summary>
        [EnumValueNameAttribute("plug back")]
        public static ActivityCode PlugBack
        {
            get 
            {
                return plugBack;
            }
        }

        private readonly static ActivityCode plugBackAbandonment;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- abandonment")]
        public static ActivityCode PlugBackAbandonment
        {
            get 
            {
                return plugBackAbandonment;
            }
        }

        private readonly static ActivityCode plugBackKickOffPlug;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- kick off plug")]
        public static ActivityCode PlugBackKickOffPlug
        {
            get 
            {
                return plugBackKickOffPlug;
            }
        }

        private readonly static ActivityCode plugBackLostCirculation;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- lost circulation")]
        public static ActivityCode PlugBackLostCirculation
        {
            get 
            {
                return plugBackLostCirculation;
            }
        }

        private readonly static ActivityCode plugBackWaitOnCement;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- wait on cement")]
        public static ActivityCode PlugBackWaitOnCement
        {
            get 
            {
                return plugBackWaitOnCement;
            }
        }

        private readonly static ActivityCode plugBackWellControl;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- well control")]
        public static ActivityCode PlugBackWellControl
        {
            get 
            {
                return plugBackWellControl;
            }
        }

        private readonly static ActivityCode pressureTest;
        /// <summary>
        /// pressure test
        /// </summary>
        [EnumValueNameAttribute("pressure test")]
        public static ActivityCode PressureTest
        {
            get 
            {
                return pressureTest;
            }
        }

        private readonly static ActivityCode pressureTestBopManifold;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- BOP manifold")]
        public static ActivityCode PressureTestBopManifold
        {
            get 
            {
                return pressureTestBopManifold;
            }
        }

        private readonly static ActivityCode pressureTestBopStack;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- BOP stack")]
        public static ActivityCode PressureTestBopStack
        {
            get 
            {
                return pressureTestBopStack;
            }
        }

        private readonly static ActivityCode pressureTestFormIntegrityTest;
        /// <summary>
        /// A specialization of 'pressure test': formation integrity test
        /// </summary>
        [EnumValueNameAttribute("pressure test -- form integrity test")]
        public static ActivityCode PressureTestFormIntegrityTest
        {
            get 
            {
                return pressureTestFormIntegrityTest;
            }
        }

        private readonly static ActivityCode pressureTestFormLeakOffTest;
        /// <summary>
        /// A specialization of 'pressure test': formation leak off test
        /// </summary>
        [EnumValueNameAttribute("pressure test -- form leak off test")]
        public static ActivityCode PressureTestFormLeakOffTest
        {
            get 
            {
                return pressureTestFormLeakOffTest;
            }
        }

        private readonly static ActivityCode pressureTestPacker;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- packer")]
        public static ActivityCode PressureTestPacker
        {
            get 
            {
                return pressureTestPacker;
            }
        }

        private readonly static ActivityCode pressureTestPit;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- PIT")]
        public static ActivityCode PressureTestPit
        {
            get 
            {
                return pressureTestPit;
            }
        }

        private readonly static ActivityCode reaming;
        /// <summary>
        /// reaming
        /// </summary>
        [EnumValueNameAttribute("reaming")]
        public static ActivityCode Reaming
        {
            get 
            {
                return reaming;
            }
        }

        private readonly static ActivityCode reamingBackReaming;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- back reaming")]
        public static ActivityCode ReamingBackReaming
        {
            get 
            {
                return reamingBackReaming;
            }
        }

        private readonly static ActivityCode reamingCoring;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- coring")]
        public static ActivityCode ReamingCoring
        {
            get 
            {
                return reamingCoring;
            }
        }

        private readonly static ActivityCode reamingDrill;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- drill")]
        public static ActivityCode ReamingDrill
        {
            get 
            {
                return reamingDrill;
            }
        }

        private readonly static ActivityCode reamingLogging;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- logging")]
        public static ActivityCode ReamingLogging
        {
            get 
            {
                return reamingLogging;
            }
        }

        private readonly static ActivityCode reamingUnderreaming;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- under-reaming")]
        public static ActivityCode ReamingUnderreaming
        {
            get 
            {
                return reamingUnderreaming;
            }
        }

        private readonly static ActivityCode rigMove;
        /// <summary>
        /// rig move
        /// </summary>
        [EnumValueNameAttribute("rig move")]
        public static ActivityCode RigMove
        {
            get 
            {
                return rigMove;
            }
        }

        private readonly static ActivityCode rigMoveAnchorHandling;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- anchor handling")]
        public static ActivityCode RigMoveAnchorHandling
        {
            get 
            {
                return rigMoveAnchorHandling;
            }
        }

        private readonly static ActivityCode rigMoveInterpadMove;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- inter-pad move")]
        public static ActivityCode RigMoveInterpadMove
        {
            get 
            {
                return rigMoveInterpadMove;
            }
        }

        private readonly static ActivityCode rigMoveInterwellMove;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- inter-well move")]
        public static ActivityCode RigMoveInterwellMove
        {
            get 
            {
                return rigMoveInterwellMove;
            }
        }

        private readonly static ActivityCode rigMoveJackUpOrDown;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- jack up or down")]
        public static ActivityCode RigMoveJackUpOrDown
        {
            get 
            {
                return rigMoveJackUpOrDown;
            }
        }

        private readonly static ActivityCode rigMoveOther;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- other")]
        public static ActivityCode RigMoveOther
        {
            get 
            {
                return rigMoveOther;
            }
        }

        private readonly static ActivityCode rigMovePositionRig;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- position rig")]
        public static ActivityCode RigMovePositionRig
        {
            get 
            {
                return rigMovePositionRig;
            }
        }

        private readonly static ActivityCode rigMoveSkidRig;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- skid rig")]
        public static ActivityCode RigMoveSkidRig
        {
            get 
            {
                return rigMoveSkidRig;
            }
        }

        private readonly static ActivityCode rigRelease;
        /// <summary>
        /// rig release
        /// </summary>
        [EnumValueNameAttribute("rig release")]
        public static ActivityCode RigRelease
        {
            get 
            {
                return rigRelease;
            }
        }

        private readonly static ActivityCode rigReleaseCutCasing;
        /// <summary>
        /// A specialization of 'rig release'.
        /// </summary>
        [EnumValueNameAttribute("rig release -- cut casing")]
        public static ActivityCode RigReleaseCutCasing
        {
            get 
            {
                return rigReleaseCutCasing;
            }
        }

        private readonly static ActivityCode rigReleaseInstallCappingAssembly;
        /// <summary>
        /// A specialization of 'rig release'.
        /// </summary>
        [EnumValueNameAttribute("rig release -- install capping assembly")]
        public static ActivityCode RigReleaseInstallCappingAssembly
        {
            get 
            {
                return rigReleaseInstallCappingAssembly;
            }
        }

        private readonly static ActivityCode rigReleaseMobOrDemob;
        /// <summary>
        /// A specialization of 'rig release'.
        /// </summary>
        [EnumValueNameAttribute("rig release -- MOB or DE-MOB")]
        public static ActivityCode RigReleaseMobOrDemob
        {
            get 
            {
                return rigReleaseMobOrDemob;
            }
        }

        private readonly static ActivityCode rigRepairs;
        /// <summary>
        /// rig repairs
        /// </summary>
        [EnumValueNameAttribute("rig repairs")]
        public static ActivityCode RigRepairs
        {
            get 
            {
                return rigRepairs;
            }
        }

        private readonly static ActivityCode rigRepairsDrawworks;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- drawworks")]
        public static ActivityCode RigRepairsDrawworks
        {
            get 
            {
                return rigRepairsDrawworks;
            }
        }

        private readonly static ActivityCode rigRepairsElectrical;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- electrical")]
        public static ActivityCode RigRepairsElectrical
        {
            get 
            {
                return rigRepairsElectrical;
            }
        }

        private readonly static ActivityCode rigRepairsMudSystem;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- mud system")]
        public static ActivityCode RigRepairsMudSystem
        {
            get 
            {
                return rigRepairsMudSystem;
            }
        }

        private readonly static ActivityCode rigRepairsOther;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- other")]
        public static ActivityCode RigRepairsOther
        {
            get 
            {
                return rigRepairsOther;
            }
        }

        private readonly static ActivityCode rigRepairsRotary;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- rotary")]
        public static ActivityCode RigRepairsRotary
        {
            get 
            {
                return rigRepairsRotary;
            }
        }

        private readonly static ActivityCode rigRepairsSubseaEquipment;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- subsea equipment")]
        public static ActivityCode RigRepairsSubseaEquipment
        {
            get 
            {
                return rigRepairsSubseaEquipment;
            }
        }

        private readonly static ActivityCode rigRepairsWellControlEquipment;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- well control equipment")]
        public static ActivityCode RigRepairsWellControlEquipment
        {
            get 
            {
                return rigRepairsWellControlEquipment;
            }
        }

        private readonly static ActivityCode rigService;
        /// <summary>
        /// rig service
        /// </summary>
        [EnumValueNameAttribute("rig service")]
        public static ActivityCode RigService
        {
            get 
            {
                return rigService;
            }
        }

        private readonly static ActivityCode rigServiceLubricateRig;
        /// <summary>
        /// A specialization of 'rig service'.
        /// </summary>
        [EnumValueNameAttribute("rig service -- lubricate rig")]
        public static ActivityCode RigServiceLubricateRig
        {
            get 
            {
                return rigServiceLubricateRig;
            }
        }

        private readonly static ActivityCode rigServiceTestEquipment;
        /// <summary>
        /// A specialization of 'rig service'.
        /// </summary>
        [EnumValueNameAttribute("rig service -- test equipment")]
        public static ActivityCode RigServiceTestEquipment
        {
            get 
            {
                return rigServiceTestEquipment;
            }
        }

        private readonly static ActivityCode rigUpOrTearDown;
        /// <summary>
        /// rig up or tear down
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down")]
        public static ActivityCode RigUpOrTearDown
        {
            get 
            {
                return rigUpOrTearDown;
            }
        }

        private readonly static ActivityCode rigUpOrTearDownRigUp;
        /// <summary>
        /// A specialization of 'rig up or tear down'.
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down -- rig up")]
        public static ActivityCode RigUpOrTearDownRigUp
        {
            get 
            {
                return rigUpOrTearDownRigUp;
            }
        }

        private readonly static ActivityCode rigUpOrTearDownSiteWork;
        /// <summary>
        /// A specialization of 'rig up or tear down'.
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down -- site work")]
        public static ActivityCode RigUpOrTearDownSiteWork
        {
            get 
            {
                return rigUpOrTearDownSiteWork;
            }
        }

        private readonly static ActivityCode rigUpOrTearDownTearDown;
        /// <summary>
        /// A specialization of 'rig up or tear down'.v
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down -- tear down")]
        public static ActivityCode RigUpOrTearDownTearDown
        {
            get 
            {
                return rigUpOrTearDownTearDown;
            }
        }

        private readonly static ActivityCode runOrPullRiser;
        /// <summary>
        /// run or pull riser
        /// </summary>
        [EnumValueNameAttribute("run or pull riser")]
        public static ActivityCode RunOrPullRiser
        {
            get 
            {
                return runOrPullRiser;
            }
        }

        private readonly static ActivityCode runOrPullRiserOther;
        /// <summary>
        /// A specialization of 'run or pull riser'.
        /// </summary>
        [EnumValueNameAttribute("run or pull riser -- other")]
        public static ActivityCode RunOrPullRiserOther
        {
            get 
            {
                return runOrPullRiserOther;
            }
        }

        private readonly static ActivityCode runOrPullRiserRunOrPullRiser;
        /// <summary>
        /// A specialization of 'run or pull riser'.
        /// </summary>
        [EnumValueNameAttribute("run or pull riser -- run or pull riser")]
        public static ActivityCode RunOrPullRiserRunOrPullRiser
        {
            get 
            {
                return runOrPullRiserRunOrPullRiser;
            }
        }

        private readonly static ActivityCode squeezeCement;
        /// <summary>
        /// squeeze cement
        /// </summary>
        [EnumValueNameAttribute("squeeze cement")]
        public static ActivityCode SqueezeCement
        {
            get 
            {
                return squeezeCement;
            }
        }

        private readonly static ActivityCode squeezeCementCasingRepair;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- casing repair")]
        public static ActivityCode SqueezeCementCasingRepair
        {
            get 
            {
                return squeezeCementCasingRepair;
            }
        }

        private readonly static ActivityCode squeezeCementCasingShoe;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- casing shoe")]
        public static ActivityCode SqueezeCementCasingShoe
        {
            get 
            {
                return squeezeCementCasingShoe;
            }
        }

        private readonly static ActivityCode squeezeCementPartedCasing;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- parted casing")]
        public static ActivityCode SqueezeCementPartedCasing
        {
            get 
            {
                return squeezeCementPartedCasing;
            }
        }

        private readonly static ActivityCode squeezeCementPerforationsDst;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- perforations DST")]
        public static ActivityCode SqueezeCementPerforationsDst
        {
            get 
            {
                return squeezeCementPerforationsDst;
            }
        }

        private readonly static ActivityCode stuckPipe;
        /// <summary>
        /// stuck pipe
        /// </summary>
        [EnumValueNameAttribute("stuck pipe")]
        public static ActivityCode StuckPipe
        {
            get 
            {
                return stuckPipe;
            }
        }

        private readonly static ActivityCode surfaceStringHandling;
        /// <summary>
        /// surface string handling
        /// </summary>
        [EnumValueNameAttribute("surface string handling")]
        public static ActivityCode SurfaceStringHandling
        {
            get 
            {
                return surfaceStringHandling;
            }
        }

        private readonly static ActivityCode testingGeneral;
        /// <summary>
        /// Testing of any nature, if more detail is not known.
        /// </summary>
        [EnumValueNameAttribute("testing general")]
        public static ActivityCode TestingGeneral
        {
            get 
            {
                return testingGeneral;
            }
        }

        private readonly static ActivityCode testingGeneralEquipment;
        /// <summary>
        /// A specialization of 'testing general'. Testing of surface equipment, or downhole equipment tested at surface.
        /// </summary>
        [EnumValueNameAttribute("testing general -- equipment")]
        public static ActivityCode TestingGeneralEquipment
        {
            get 
            {
                return testingGeneralEquipment;
            }
        }

        private readonly static ActivityCode testingGeneralFlow;
        /// <summary>
        /// A specialization of 'testing general'. Well Flow testing, in the pre-production phase of the well.
        /// </summary>
        [EnumValueNameAttribute("testing general -- flow")]
        public static ActivityCode TestingGeneralFlow
        {
            get 
            {
                return testingGeneralFlow;
            }
        }

        private readonly static ActivityCode tripping;
        /// <summary>
        /// tripping
        /// </summary>
        [EnumValueNameAttribute("tripping")]
        public static ActivityCode Tripping
        {
            get 
            {
                return tripping;
            }
        }

        private readonly static ActivityCode trippingBackreaming;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- back-reaming")]
        public static ActivityCode TrippingBackreaming
        {
            get 
            {
                return trippingBackreaming;
            }
        }

        private readonly static ActivityCode trippingFlowCheck;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- flow check")]
        public static ActivityCode TrippingFlowCheck
        {
            get 
            {
                return trippingFlowCheck;
            }
        }

        private readonly static ActivityCode trippingShortTripIn;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- short trip in")]
        public static ActivityCode TrippingShortTripIn
        {
            get 
            {
                return trippingShortTripIn;
            }
        }

        private readonly static ActivityCode trippingShortTripOut;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- short trip out")]
        public static ActivityCode TrippingShortTripOut
        {
            get 
            {
                return trippingShortTripOut;
            }
        }

        private readonly static ActivityCode trippingTripInFromSurface;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- trip in (from surface)")]
        public static ActivityCode TrippingTripInFromSurface
        {
            get 
            {
                return trippingTripInFromSurface;
            }
        }

        private readonly static ActivityCode trippingTripOutToSurface;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- trip out (to surface)")]
        public static ActivityCode TrippingTripOutToSurface
        {
            get 
            {
                return trippingTripOutToSurface;
            }
        }

        private readonly static ActivityCode wait;
        /// <summary>
        /// wait
        /// </summary>
        [EnumValueNameAttribute("wait")]
        public static ActivityCode Wait
        {
            get 
            {
                return wait;
            }
        }

        private readonly static ActivityCode waitDaylight;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- daylight")]
        public static ActivityCode WaitDaylight
        {
            get 
            {
                return waitDaylight;
            }
        }

        private readonly static ActivityCode waitEnvironmentalOrRegulatory;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- environmental or regulatory")]
        public static ActivityCode WaitEnvironmentalOrRegulatory
        {
            get 
            {
                return waitEnvironmentalOrRegulatory;
            }
        }

        private readonly static ActivityCode waitEquipment;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- equipment")]
        public static ActivityCode WaitEquipment
        {
            get 
            {
                return waitEquipment;
            }
        }

        private readonly static ActivityCode waitHoliday;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- holiday")]
        public static ActivityCode WaitHoliday
        {
            get 
            {
                return waitHoliday;
            }
        }

        private readonly static ActivityCode waitIce;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- ice")]
        public static ActivityCode WaitIce
        {
            get 
            {
                return waitIce;
            }
        }

        private readonly static ActivityCode waitOnOrders;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- on orders")]
        public static ActivityCode WaitOnOrders
        {
            get 
            {
                return waitOnOrders;
            }
        }

        private readonly static ActivityCode waitOperator;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- operator")]
        public static ActivityCode WaitOperator
        {
            get 
            {
                return waitOperator;
            }
        }

        private readonly static ActivityCode waitOther;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- other")]
        public static ActivityCode WaitOther
        {
            get 
            {
                return waitOther;
            }
        }

        private readonly static ActivityCode waitPartners;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- partners")]
        public static ActivityCode WaitPartners
        {
            get 
            {
                return waitPartners;
            }
        }

        private readonly static ActivityCode waitServiceCompany;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- service company")]
        public static ActivityCode WaitServiceCompany
        {
            get 
            {
                return waitServiceCompany;
            }
        }

        private readonly static ActivityCode waitWeather;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- weather")]
        public static ActivityCode WaitWeather
        {
            get 
            {
                return waitWeather;
            }
        }

        private readonly static ActivityCode wellControl;
        /// <summary>
        /// well control
        /// </summary>
        [EnumValueNameAttribute("well control")]
        public static ActivityCode WellControl
        {
            get 
            {
                return wellControl;
            }
        }

        private readonly static ActivityCode wellControlMix;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- mix")]
        public static ActivityCode WellControlMix
        {
            get 
            {
                return wellControlMix;
            }
        }

        private readonly static ActivityCode wellControlShutIn;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- shut in")]
        public static ActivityCode WellControlShutIn
        {
            get 
            {
                return wellControlShutIn;
            }
        }

        private readonly static ActivityCode wellControlStrip;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- strip")]
        public static ActivityCode WellControlStrip
        {
            get 
            {
                return wellControlStrip;
            }
        }

        private readonly static ActivityCode wellControlWellKill;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- well kill")]
        public static ActivityCode WellControlWellKill
        {
            get 
            {
                return wellControlWellKill;
            }
        }

        private readonly static ActivityCode wellSrvc;
        /// <summary>
        /// well services
        /// </summary>
        [EnumValueNameAttribute("well srvc")]
        public static ActivityCode WellSrvc
        {
            get 
            {
                return wellSrvc;
            }
        }

        private readonly static ActivityCode wellSrvcCasingRepair;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- casing repair")]
        public static ActivityCode WellSrvcCasingRepair
        {
            get 
            {
                return wellSrvcCasingRepair;
            }
        }

        private readonly static ActivityCode wellSrvcCleanWellToComplFluid;
        /// <summary>
        /// cleanout well to completion fluid
        /// </summary>
        [EnumValueNameAttribute("well srvc -- clean well to compl fluid")]
        public static ActivityCode WellSrvcCleanWellToComplFluid
        {
            get 
            {
                return wellSrvcCleanWellToComplFluid;
            }
        }

        private readonly static ActivityCode wellSrvcCoiledTubingWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- coiled tubing work")]
        public static ActivityCode WellSrvcCoiledTubingWork
        {
            get 
            {
                return wellSrvcCoiledTubingWork;
            }
        }

        private readonly static ActivityCode wellSrvcGravelPack;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- gravel pack")]
        public static ActivityCode WellSrvcGravelPack
        {
            get 
            {
                return wellSrvcGravelPack;
            }
        }

        private readonly static ActivityCode wellSrvcInstallOrTestXmasTree;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- install or test xmas tree")]
        public static ActivityCode WellSrvcInstallOrTestXmasTree
        {
            get 
            {
                return wellSrvcInstallOrTestXmasTree;
            }
        }

        private readonly static ActivityCode wellSrvcKillWell;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- kill well")]
        public static ActivityCode WellSrvcKillWell
        {
            get 
            {
                return wellSrvcKillWell;
            }
        }

        private readonly static ActivityCode wellSrvcLandSetTestCompletion;
        /// <summary>
        /// A specialization of 'well srvc': land, set and test completion
        /// </summary>
        [EnumValueNameAttribute("well srvc -- land, set, test completion")]
        public static ActivityCode WellSrvcLandSetTestCompletion
        {
            get 
            {
                return wellSrvcLandSetTestCompletion;
            }
        }

        private readonly static ActivityCode wellSrvcPerforate;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- perforate")]
        public static ActivityCode WellSrvcPerforate
        {
            get 
            {
                return wellSrvcPerforate;
            }
        }

        private readonly static ActivityCode wellSrvcPullCompletion;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- pull completion")]
        public static ActivityCode WellSrvcPullCompletion
        {
            get 
            {
                return wellSrvcPullCompletion;
            }
        }

        private readonly static ActivityCode wellSrvcPullSuspensionPlugs;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- pull suspension plugs")]
        public static ActivityCode WellSrvcPullSuspensionPlugs
        {
            get 
            {
                return wellSrvcPullSuspensionPlugs;
            }
        }

        private readonly static ActivityCode wellSrvcRunCompletion;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- run completion")]
        public static ActivityCode WellSrvcRunCompletion
        {
            get 
            {
                return wellSrvcRunCompletion;
            }
        }

        private readonly static ActivityCode wellSrvcRunScreens;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- run screens")]
        public static ActivityCode WellSrvcRunScreens
        {
            get 
            {
                return wellSrvcRunScreens;
            }
        }

        private readonly static ActivityCode wellSrvcSandControl;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- sand control")]
        public static ActivityCode WellSrvcSandControl
        {
            get 
            {
                return wellSrvcSandControl;
            }
        }

        private readonly static ActivityCode wellSrvcStimulation;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- stimulation")]
        public static ActivityCode WellSrvcStimulation
        {
            get 
            {
                return wellSrvcStimulation;
            }
        }

        private readonly static ActivityCode wellSrvcSubseaWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- subsea work")]
        public static ActivityCode WellSrvcSubseaWork
        {
            get 
            {
                return wellSrvcSubseaWork;
            }
        }

        private readonly static ActivityCode wellSrvcSurfaceLineWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- surface line work")]
        public static ActivityCode WellSrvcSurfaceLineWork
        {
            get 
            {
                return wellSrvcSurfaceLineWork;
            }
        }

        private readonly static ActivityCode wellSrvcSuspendWellOrPullBops;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- suspend well or pull BOPs")]
        public static ActivityCode WellSrvcSuspendWellOrPullBops
        {
            get 
            {
                return wellSrvcSuspendWellOrPullBops;
            }
        }

        private readonly static ActivityCode wellSrvcTestWell;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- test well")]
        public static ActivityCode WellSrvcTestWell
        {
            get 
            {
                return wellSrvcTestWell;
            }
        }

        private readonly static ActivityCode wellSrvcWash;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- wash")]
        public static ActivityCode WellSrvcWash
        {
            get 
            {
                return wellSrvcWash;
            }
        }

        private readonly static ActivityCode wellSrvcWirelineWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- wireline work")]
        public static ActivityCode WellSrvcWirelineWork
        {
            get 
            {
                return wellSrvcWirelineWork;
            }
        }

        private readonly static ActivityCode wellSrvcWorkTubulars;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- work tubulars")]
        public static ActivityCode WellSrvcWorkTubulars
        {
            get 
            {
                return wellSrvcWorkTubulars;
            }
        }

        private readonly static ActivityCode wellSrvcWorkstringRun;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- workstring run")]
        public static ActivityCode WellSrvcWorkstringRun
        {
            get 
            {
                return wellSrvcWorkstringRun;
            }
        }

        private readonly static ActivityCode wirelineLogs;
        /// <summary>
        /// wireline logs
        /// </summary>
        [EnumValueNameAttribute("wireline logs")]
        public static ActivityCode WirelineLogs
        {
            get 
            {
                return wirelineLogs;
            }
        }

        private readonly static ActivityCode wirelineLogsAbandonment;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- abandonment")]
        public static ActivityCode WirelineLogsAbandonment
        {
            get 
            {
                return wirelineLogsAbandonment;
            }
        }

        private readonly static ActivityCode wirelineLogsEvaluation;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- evaluation")]
        public static ActivityCode WirelineLogsEvaluation
        {
            get 
            {
                return wirelineLogsEvaluation;
            }
        }

        private readonly static ActivityCode wirelineLogsFormTester;
        /// <summary>
        /// A specialization of 'wireline logs': formation tester
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- form tester")]
        public static ActivityCode WirelineLogsFormTester
        {
            get 
            {
                return wirelineLogsFormTester;
            }
        }

        private readonly static ActivityCode wirelineLogsOther;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- other")]
        public static ActivityCode WirelineLogsOther
        {
            get 
            {
                return wirelineLogsOther;
            }
        }

        private readonly static ActivityCode wirelineLogsSideWallCores;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- side wall cores")]
        public static ActivityCode WirelineLogsSideWallCores
        {
            get 
            {
                return wirelineLogsSideWallCores;
            }
        }

        private readonly static ActivityCode wirelineLogsVelocity;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- velocity")]
        public static ActivityCode WirelineLogsVelocity
        {
            get 
            {
                return wirelineLogsVelocity;
            }
        }

        static ActivityCode()
        {
            abandonment = 
                new ActivityCode("abandonment")
                {
                    Description = "abandonment"
            };
            abandonmentLogPlugs = 
                new ActivityCode("abandonment -- log plugs")
                {
                    Description = "A specialization of 'abandonment'."
            };
            abandonmentRunPlugs = 
                new ActivityCode("abandonment -- run plugs")
                {
                    Description = "A specialization of 'abandonment'."
            };
            abandonmentWaitOnCement = 
                new ActivityCode("abandonment -- wait on cement")
                {
                    Description = "A specialization of 'abandonment'."
            };
            casingCement = 
                new ActivityCode("casing, cement")
                {
                    Description = "casing and cement"
            };
            casingCementCirculateCement = 
                new ActivityCode("casing, cement -- circulate, cement")
                {
                    Description = "A specialization of 'casing, cement': circulate and cement"
            };
            casingCementOther = 
                new ActivityCode("casing, cement -- other")
                {
                    Description = "A specialization of 'casing, cement'."
            };
            casingCementRigUpRunCasing = 
                new ActivityCode("casing, cement -- rig up, run casing")
                {
                    Description = "A specialization of 'casing, cement': rig up and run casing"
            };
            casingCementRigUpRunLiner = 
                new ActivityCode("casing, cement -- rig up, run liner")
                {
                    Description = "A specialization of 'casing, cement': rig up and run liner"
            };
            casingCementWaitOnCement = 
                new ActivityCode("casing, cement -- wait on cement")
                {
                    Description = "A specialization of 'casing, cement'."
            };
            completionOperations = 
                new ActivityCode("completion operations")
                {
                    Description = "After reaching total depth, any operations for completing the well and bringing it on production - no further detail is known."
            };
            completionOperationsRigUp = 
                new ActivityCode("completion operations -- rig up")
                {
                    Description = "Rig up completion equipment."
            };
            completionOperationsTearDown = 
                new ActivityCode("completion operations -- tear down")
                {
                    Description = "Tear down completion equipment."
            };
            completionOperationsTesting = 
                new ActivityCode("completion operations -- testing ")
                {
                    Description = "Pre-production flow testing in the well completion phase."
            };
            completionOperationsRunningLiner = 
                new ActivityCode("completion operations -- running liner")
                {
                    Description = "Running the production liner."
            };
            completionOperationsGravelPacking = 
                new ActivityCode("completion operations -- gravel packing")
                {
                    Description = "Completion operation for producing zones."
            };
            completionOperationsLogging = 
                new ActivityCode("completion operations -- logging")
                {
                    Description = "Production logging tool runs."
            };
            condMudCirculate = 
                new ActivityCode("cond mud, circulate")
                {
                    Description = "condition mud and circulate"
            };
            condMudCirculateBoulderOrGravel = 
                new ActivityCode("cond mud, circulate -- boulder or gravel")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateCasing = 
                new ActivityCode("cond mud, circulate -- casing")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateCementing = 
                new ActivityCode("cond mud, circulate -- cementing")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateCirculateSamples = 
                new ActivityCode("cond mud, circulate -- circulate samples")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateCoring = 
                new ActivityCode("cond mud, circulate -- coring")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateDrilling = 
                new ActivityCode("cond mud, circulate -- drilling")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateFishing = 
                new ActivityCode("cond mud, circulate -- fishing")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateGumboAttack = 
                new ActivityCode("cond mud, circulate -- gumbo attack")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateLogging = 
                new ActivityCode("cond mud, circulate -- logging")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateLostCirculation = 
                new ActivityCode("cond mud, circulate -- lost circulation")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            condMudCirculateWellControl = 
                new ActivityCode("cond mud, circulate -- well control")
                {
                    Description = "A specialization of 'cond mud, circulate'."
            };
            coring = 
                new ActivityCode("coring")
                {
                    Description = "coring"
            };
            coringConventional = 
                new ActivityCode("coring -- conventional")
                {
                    Description = "A specialization of 'coring'."
            };
            coringFlowCheck = 
                new ActivityCode("coring -- flow check")
                {
                    Description = "A specialization of 'coring'."
            };
            coringLaydownBarrel = 
                new ActivityCode("coring -- laydown barrel")
                {
                    Description = "A specialization of 'coring'."
            };
            coringOriented = 
                new ActivityCode("coring -- oriented")
                {
                    Description = "A specialization of 'coring'."
            };
            coringPlasticSleeve = 
                new ActivityCode("coring -- plastic sleeve")
                {
                    Description = "A specialization of 'coring'."
            };
            coringRigUpCoreBarrel = 
                new ActivityCode("coring -- rig up core barrel")
                {
                    Description = "A specialization of 'coring'."
            };
            coringSponge = 
                new ActivityCode("coring -- sponge")
                {
                    Description = "A specialization of 'coring'."
            };
            cutSlipDrillingLine = 
                new ActivityCode("cut, slip drilling line")
                {
                    Description = "cut and slip drilling line"
            };
            deviationSurvey = 
                new ActivityCode("deviation survey")
                {
                    Description = "deviation survey"
            };
            deviationSurveyDirMultishot = 
                new ActivityCode("deviation survey -- dir multi-shot")
                {
                    Description = "A specialization of 'deviation survey': directional multi-shot"
            };
            deviationSurveyDirSingleShot = 
                new ActivityCode("deviation survey -- dir single shot")
                {
                    Description = "A specialization of 'deviation survey': directional single shot"
            };
            deviationSurveyDrift = 
                new ActivityCode("deviation survey -- drift")
                {
                    Description = "A specialization of 'deviation survey'."
            };
            deviationSurveyGyro = 
                new ActivityCode("deviation survey -- gyro")
                {
                    Description = "A specialization of 'deviation survey'."
            };
            deviationSurveyMwd = 
                new ActivityCode("deviation survey -- MWD")
                {
                    Description = "A specialization of 'deviation survey'."
            };
            dirWork = 
                new ActivityCode("dir work")
                {
                    Description = "directional work"
            };
            dirWorkHorizontalDrilling = 
                new ActivityCode("dir work -- horizontal drilling")
                {
                    Description = "A specialization of 'dir work'."
            };
            dirWorkMotorDrilling = 
                new ActivityCode("dir work -- motor drilling")
                {
                    Description = "A specialization of 'dir work'."
            };
            dirWorkOrient = 
                new ActivityCode("dir work -- orient")
                {
                    Description = "A specialization of 'dir work'."
            };
            dirWorkRotaryDrilling = 
                new ActivityCode("dir work -- rotary drilling")
                {
                    Description = "A specialization of 'dir work'."
            };
            dirWorkSlantDrilling = 
                new ActivityCode("dir work -- slant drilling")
                {
                    Description = "A specialization of 'dir work'."
            };
            dst = 
                new ActivityCode("DST")
                {
                    Description = "drill stem test"
            };
            dstCasedHole = 
                new ActivityCode("DST -- cased hole")
                {
                    Description = "A specialization of 'DST'."
            };
            dstLayDownTools = 
                new ActivityCode("DST -- lay down tools")
                {
                    Description = "A specialization of 'DST'."
            };
            dstOpenHole = 
                new ActivityCode("DST -- open hole")
                {
                    Description = "A specialization of 'DST'."
            };
            dstOpenHoleClosedChamber = 
                new ActivityCode("DST -- open hole closed chamber")
                {
                    Description = "A specialization of 'DST'."
            };
            dstRigUpTools = 
                new ActivityCode("DST -- rig up tools")
                {
                    Description = "A specialization of 'DST'."
            };
            drilling = 
                new ActivityCode("drilling")
                {
                    Description = "drilling"
            };
            drillingCasing = 
                new ActivityCode("drilling -- casing")
                {
                    Description = "A specialization of 'drilling'."
            };
            drillingConnection = 
                new ActivityCode("drilling -- connection")
                {
                    Description = "A specialization of 'drilling'."
            };
            drillingDrillCementFloatEquip = 
                new ActivityCode("drilling -- drill cement, float equip")
                {
                    Description = "A specialization of 'drilling': drill out cement and/or float equipment"
            };
            drillingFlowCheck = 
                new ActivityCode("drilling -- flow check")
                {
                    Description = "A specialization of 'drilling'."
            };
            drillingHoleOpening = 
                new ActivityCode("drilling -- hole opening")
                {
                    Description = "A specialization of 'drilling'."
            };
            drillingNewHole = 
                new ActivityCode("drilling -- new hole")
                {
                    Description = "A specialization of 'drilling'."
            };
            drillingSidetracking = 
                new ActivityCode("drilling -- sidetracking")
                {
                    Description = "A specialization of 'drilling'."
            };
            drillingUnderreaming = 
                new ActivityCode("drilling -- under-reaming")
                {
                    Description = "A specialization of 'drilling'."
            };
            fishing = 
                new ActivityCode("fishing")
                {
                    Description = "fishing"
            };
            fishingBha = 
                new ActivityCode("fishing -- BHA")
                {
                    Description = "A specialization of 'fishing'."
            };
            fishingCasing = 
                new ActivityCode("fishing -- casing")
                {
                    Description = "A specialization of 'fishing'."
            };
            fishingCones = 
                new ActivityCode("fishing -- cones")
                {
                    Description = ">A specialization of 'fishing'."
            };
            fishingOther = 
                new ActivityCode("fishing -- other")
                {
                    Description = "A specialization of 'fishing'."
            };
            fishingStuckPipe = 
                new ActivityCode("fishing -- stuck pipe")
                {
                    Description = "A specialization of 'fishing'."
            };
            fishingWirelineTools = 
                new ActivityCode("fishing -- wireline tools")
                {
                    Description = "A specialization of 'fishing'."
            };
            hse = 
                new ActivityCode("HSE")
                {
                    Description = "Health, Safety and Environmental"
            };
            hseHoldDrill = 
                new ActivityCode("HSE -- hold drill")
                {
                    Description = "A specialization of 'HSE'."
            };
            hseIncident = 
                new ActivityCode("HSE -- incident")
                {
                    Description = "A specialization of 'HSE'."
            };
            hseSafetyMeeting = 
                new ActivityCode("HSE -- safety meeting")
                {
                    Description = "A specialization of 'HSE'."
            };
            mill = 
                new ActivityCode("mill")
                {
                    Description = "mill"
            };
            millCutCasingOrTubing = 
                new ActivityCode("mill -- cut casing or tubing")
                {
                    Description = "A specialization of 'mill'."
            };
            millMilling = 
                new ActivityCode("mill -- milling")
                {
                    Description = "A specialization of 'mill'."
            };
            miscellaneous = 
                new ActivityCode("miscellaneous")
                {
                    Description = "miscellaneous"
            };
            nippleUpBop = 
                new ActivityCode("nipple up BOP")
                {
                    Description = "nipple up blowout preventer"
            };
            nippleUpBopDiverter = 
                new ActivityCode("nipple up BOP -- diverter")
                {
                    Description = "A specialization of 'nipple up BOP'."
            };
            nippleUpBopManifold = 
                new ActivityCode("nipple up BOP -- manifold")
                {
                    Description = "A specialization of 'nipple up BOP'."
            };
            nippleUpBopOther = 
                new ActivityCode("nipple up BOP -- other")
                {
                    Description = "A specialization of 'nipple up BOP'."
            };
            nippleUpBopPvtSystem = 
                new ActivityCode("nipple up BOP -- PVT system")
                {
                    Description = "A specialization of 'nipple up BOP'."
            };
            nippleUpBopStack = 
                new ActivityCode("nipple up BOP -- stack")
                {
                    Description = "A specialization of 'nipple up BOP'."
            };
            plugBack = 
                new ActivityCode("plug back")
                {
                    Description = "plug back"
            };
            plugBackAbandonment = 
                new ActivityCode("plug back -- abandonment")
                {
                    Description = "A specialization of 'plug back'."
            };
            plugBackKickOffPlug = 
                new ActivityCode("plug back -- kick off plug")
                {
                    Description = "A specialization of 'plug back'."
            };
            plugBackLostCirculation = 
                new ActivityCode("plug back -- lost circulation")
                {
                    Description = "A specialization of 'plug back'."
            };
            plugBackWaitOnCement = 
                new ActivityCode("plug back -- wait on cement")
                {
                    Description = "A specialization of 'plug back'."
            };
            plugBackWellControl = 
                new ActivityCode("plug back -- well control")
                {
                    Description = "A specialization of 'plug back'."
            };
            pressureTest = 
                new ActivityCode("pressure test")
                {
                    Description = "pressure test"
            };
            pressureTestBopManifold = 
                new ActivityCode("pressure test -- BOP manifold")
                {
                    Description = "A specialization of 'pressure test'."
            };
            pressureTestBopStack = 
                new ActivityCode("pressure test -- BOP stack")
                {
                    Description = "A specialization of 'pressure test'."
            };
            pressureTestFormIntegrityTest = 
                new ActivityCode("pressure test -- form integrity test")
                {
                    Description = "A specialization of 'pressure test': formation integrity test"
            };
            pressureTestFormLeakOffTest = 
                new ActivityCode("pressure test -- form leak off test")
                {
                    Description = "A specialization of 'pressure test': formation leak off test"
            };
            pressureTestPacker = 
                new ActivityCode("pressure test -- packer")
                {
                    Description = "A specialization of 'pressure test'."
            };
            pressureTestPit = 
                new ActivityCode("pressure test -- PIT")
                {
                    Description = "A specialization of 'pressure test'."
            };
            reaming = 
                new ActivityCode("reaming")
                {
                    Description = "reaming"
            };
            reamingBackReaming = 
                new ActivityCode("reaming -- back reaming")
                {
                    Description = "A specialization of 'reaming'."
            };
            reamingCoring = 
                new ActivityCode("reaming -- coring")
                {
                    Description = "A specialization of 'reaming'."
            };
            reamingDrill = 
                new ActivityCode("reaming -- drill")
                {
                    Description = "A specialization of 'reaming'."
            };
            reamingLogging = 
                new ActivityCode("reaming -- logging")
                {
                    Description = "A specialization of 'reaming'."
            };
            reamingUnderreaming = 
                new ActivityCode("reaming -- under-reaming")
                {
                    Description = "A specialization of 'reaming'."
            };
            rigMove = 
                new ActivityCode("rig move")
                {
                    Description = "rig move"
            };
            rigMoveAnchorHandling = 
                new ActivityCode("rig move -- anchor handling")
                {
                    Description = "A specialization of 'rig move'."
            };
            rigMoveInterpadMove = 
                new ActivityCode("rig move -- inter-pad move")
                {
                    Description = "A specialization of 'rig move'."
            };
            rigMoveInterwellMove = 
                new ActivityCode("rig move -- inter-well move")
                {
                    Description = "A specialization of 'rig move'."
            };
            rigMoveJackUpOrDown = 
                new ActivityCode("rig move -- jack up or down")
                {
                    Description = "A specialization of 'rig move'."
            };
            rigMoveOther = 
                new ActivityCode("rig move -- other")
                {
                    Description = "A specialization of 'rig move'."
            };
            rigMovePositionRig = 
                new ActivityCode("rig move -- position rig")
                {
                    Description = "A specialization of 'rig move'."
            };
            rigMoveSkidRig = 
                new ActivityCode("rig move -- skid rig")
                {
                    Description = "A specialization of 'rig move'."
            };
            rigRelease = 
                new ActivityCode("rig release")
                {
                    Description = "rig release"
            };
            rigReleaseCutCasing = 
                new ActivityCode("rig release -- cut casing")
                {
                    Description = "A specialization of 'rig release'."
            };
            rigReleaseInstallCappingAssembly = 
                new ActivityCode("rig release -- install capping assembly")
                {
                    Description = "A specialization of 'rig release'."
            };
            rigReleaseMobOrDemob = 
                new ActivityCode("rig release -- MOB or DE-MOB")
                {
                    Description = "A specialization of 'rig release'."
            };
            rigRepairs = 
                new ActivityCode("rig repairs")
                {
                    Description = "rig repairs"
            };
            rigRepairsDrawworks = 
                new ActivityCode("rig repairs -- drawworks")
                {
                    Description = "A specialization of 'rig repairs'."
            };
            rigRepairsElectrical = 
                new ActivityCode("rig repairs -- electrical")
                {
                    Description = "A specialization of 'rig repairs'."
            };
            rigRepairsMudSystem = 
                new ActivityCode("rig repairs -- mud system")
                {
                    Description = "A specialization of 'rig repairs'."
            };
            rigRepairsOther = 
                new ActivityCode("rig repairs -- other")
                {
                    Description = "A specialization of 'rig repairs'."
            };
            rigRepairsRotary = 
                new ActivityCode("rig repairs -- rotary")
                {
                    Description = "A specialization of 'rig repairs'."
            };
            rigRepairsSubseaEquipment = 
                new ActivityCode("rig repairs -- subsea equipment")
                {
                    Description = "A specialization of 'rig repairs'."
            };
            rigRepairsWellControlEquipment = 
                new ActivityCode("rig repairs -- well control equipment")
                {
                    Description = "A specialization of 'rig repairs'."
            };
            rigService = 
                new ActivityCode("rig service")
                {
                    Description = "rig service"
            };
            rigServiceLubricateRig = 
                new ActivityCode("rig service -- lubricate rig")
                {
                    Description = "A specialization of 'rig service'."
            };
            rigServiceTestEquipment = 
                new ActivityCode("rig service -- test equipment")
                {
                    Description = "A specialization of 'rig service'."
            };
            rigUpOrTearDown = 
                new ActivityCode("rig up or tear down")
                {
                    Description = "rig up or tear down"
            };
            rigUpOrTearDownRigUp = 
                new ActivityCode("rig up or tear down -- rig up")
                {
                    Description = "A specialization of 'rig up or tear down'."
            };
            rigUpOrTearDownSiteWork = 
                new ActivityCode("rig up or tear down -- site work")
                {
                    Description = "A specialization of 'rig up or tear down'."
            };
            rigUpOrTearDownTearDown = 
                new ActivityCode("rig up or tear down -- tear down")
                {
                    Description = "A specialization of 'rig up or tear down'.v"
            };
            runOrPullRiser = 
                new ActivityCode("run or pull riser")
                {
                    Description = "run or pull riser"
            };
            runOrPullRiserOther = 
                new ActivityCode("run or pull riser -- other")
                {
                    Description = "A specialization of 'run or pull riser'."
            };
            runOrPullRiserRunOrPullRiser = 
                new ActivityCode("run or pull riser -- run or pull riser")
                {
                    Description = "A specialization of 'run or pull riser'."
            };
            squeezeCement = 
                new ActivityCode("squeeze cement")
                {
                    Description = "squeeze cement"
            };
            squeezeCementCasingRepair = 
                new ActivityCode("squeeze cement -- casing repair")
                {
                    Description = "A specialization of 'squeeze cement'."
            };
            squeezeCementCasingShoe = 
                new ActivityCode("squeeze cement -- casing shoe")
                {
                    Description = "A specialization of 'squeeze cement'."
            };
            squeezeCementPartedCasing = 
                new ActivityCode("squeeze cement -- parted casing")
                {
                    Description = "A specialization of 'squeeze cement'."
            };
            squeezeCementPerforationsDst = 
                new ActivityCode("squeeze cement -- perforations DST")
                {
                    Description = "A specialization of 'squeeze cement'."
            };
            stuckPipe = 
                new ActivityCode("stuck pipe")
                {
                    Description = "stuck pipe"
            };
            surfaceStringHandling = 
                new ActivityCode("surface string handling")
                {
                    Description = "surface string handling"
            };
            testingGeneral = 
                new ActivityCode("testing general")
                {
                    Description = "Testing of any nature, if more detail is not known."
            };
            testingGeneralEquipment = 
                new ActivityCode("testing general -- equipment")
                {
                    Description = "A specialization of 'testing general'. Testing of surface equipment, or downhole equipment tested at surface."
            };
            testingGeneralFlow = 
                new ActivityCode("testing general -- flow")
                {
                    Description = "A specialization of 'testing general'. Well Flow testing, in the pre-production phase of the well."
            };
            tripping = 
                new ActivityCode("tripping")
                {
                    Description = "tripping"
            };
            trippingBackreaming = 
                new ActivityCode("tripping -- back-reaming")
                {
                    Description = "A specialization of 'tripping'."
            };
            trippingFlowCheck = 
                new ActivityCode("tripping -- flow check")
                {
                    Description = "A specialization of 'tripping'."
            };
            trippingShortTripIn = 
                new ActivityCode("tripping -- short trip in")
                {
                    Description = "A specialization of 'tripping'."
            };
            trippingShortTripOut = 
                new ActivityCode("tripping -- short trip out")
                {
                    Description = "A specialization of 'tripping'."
            };
            trippingTripInFromSurface = 
                new ActivityCode("tripping -- trip in (from surface)")
                {
                    Description = "A specialization of 'tripping'."
            };
            trippingTripOutToSurface = 
                new ActivityCode("tripping -- trip out (to surface)")
                {
                    Description = "A specialization of 'tripping'."
            };
            wait = 
                new ActivityCode("wait")
                {
                    Description = "wait"
            };
            waitDaylight = 
                new ActivityCode("wait -- daylight")
                {
                    Description = "A specialization of 'wait'."
            };
            waitEnvironmentalOrRegulatory = 
                new ActivityCode("wait -- environmental or regulatory")
                {
                    Description = "A specialization of 'wait'."
            };
            waitEquipment = 
                new ActivityCode("wait -- equipment")
                {
                    Description = "A specialization of 'wait'."
            };
            waitHoliday = 
                new ActivityCode("wait -- holiday")
                {
                    Description = "A specialization of 'wait'."
            };
            waitIce = 
                new ActivityCode("wait -- ice")
                {
                    Description = "A specialization of 'wait'."
            };
            waitOnOrders = 
                new ActivityCode("wait -- on orders")
                {
                    Description = "A specialization of 'wait'."
            };
            waitOperator = 
                new ActivityCode("wait -- operator")
                {
                    Description = "A specialization of 'wait'."
            };
            waitOther = 
                new ActivityCode("wait -- other")
                {
                    Description = "A specialization of 'wait'."
            };
            waitPartners = 
                new ActivityCode("wait -- partners")
                {
                    Description = "A specialization of 'wait'."
            };
            waitServiceCompany = 
                new ActivityCode("wait -- service company")
                {
                    Description = "A specialization of 'wait'."
            };
            waitWeather = 
                new ActivityCode("wait -- weather")
                {
                    Description = "A specialization of 'wait'."
            };
            wellControl = 
                new ActivityCode("well control")
                {
                    Description = "well control"
            };
            wellControlMix = 
                new ActivityCode("well control -- mix")
                {
                    Description = "A specialization of 'well control'."
            };
            wellControlShutIn = 
                new ActivityCode("well control -- shut in")
                {
                    Description = "A specialization of 'well control'."
            };
            wellControlStrip = 
                new ActivityCode("well control -- strip")
                {
                    Description = "A specialization of 'well control'."
            };
            wellControlWellKill = 
                new ActivityCode("well control -- well kill")
                {
                    Description = "A specialization of 'well control'."
            };
            wellSrvc = 
                new ActivityCode("well srvc")
                {
                    Description = "well services"
            };
            wellSrvcCasingRepair = 
                new ActivityCode("well srvc -- casing repair")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcCleanWellToComplFluid = 
                new ActivityCode("well srvc -- clean well to compl fluid")
                {
                    Description = "cleanout well to completion fluid"
            };
            wellSrvcCoiledTubingWork = 
                new ActivityCode("well srvc -- coiled tubing work")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcGravelPack = 
                new ActivityCode("well srvc -- gravel pack")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcInstallOrTestXmasTree = 
                new ActivityCode("well srvc -- install or test xmas tree")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcKillWell = 
                new ActivityCode("well srvc -- kill well")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcLandSetTestCompletion = 
                new ActivityCode("well srvc -- land, set, test completion")
                {
                    Description = "A specialization of 'well srvc': land, set and test completion"
            };
            wellSrvcPerforate = 
                new ActivityCode("well srvc -- perforate")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcPullCompletion = 
                new ActivityCode("well srvc -- pull completion")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcPullSuspensionPlugs = 
                new ActivityCode("well srvc -- pull suspension plugs")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcRunCompletion = 
                new ActivityCode("well srvc -- run completion")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcRunScreens = 
                new ActivityCode("well srvc -- run screens")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcSandControl = 
                new ActivityCode("well srvc -- sand control")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcStimulation = 
                new ActivityCode("well srvc -- stimulation")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcSubseaWork = 
                new ActivityCode("well srvc -- subsea work")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcSurfaceLineWork = 
                new ActivityCode("well srvc -- surface line work")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcSuspendWellOrPullBops = 
                new ActivityCode("well srvc -- suspend well or pull BOPs")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcTestWell = 
                new ActivityCode("well srvc -- test well")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcWash = 
                new ActivityCode("well srvc -- wash")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcWirelineWork = 
                new ActivityCode("well srvc -- wireline work")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcWorkTubulars = 
                new ActivityCode("well srvc -- work tubulars")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wellSrvcWorkstringRun = 
                new ActivityCode("well srvc -- workstring run")
                {
                    Description = "A specialization of 'well srvc'."
            };
            wirelineLogs = 
                new ActivityCode("wireline logs")
                {
                    Description = "wireline logs"
            };
            wirelineLogsAbandonment = 
                new ActivityCode("wireline logs -- abandonment")
                {
                    Description = "A specialization of 'wireline logs'."
            };
            wirelineLogsEvaluation = 
                new ActivityCode("wireline logs -- evaluation")
                {
                    Description = "A specialization of 'wireline logs'."
            };
            wirelineLogsFormTester = 
                new ActivityCode("wireline logs -- form tester")
                {
                    Description = "A specialization of 'wireline logs': formation tester"
            };
            wirelineLogsOther = 
                new ActivityCode("wireline logs -- other")
                {
                    Description = "A specialization of 'wireline logs'."
            };
            wirelineLogsSideWallCores = 
                new ActivityCode("wireline logs -- side wall cores")
                {
                    Description = "A specialization of 'wireline logs'."
            };
            wirelineLogsVelocity = 
                new ActivityCode("wireline logs -- velocity")
                {
                    Description = "A specialization of 'wireline logs'."
            };
        }

        /// <summary>
        /// Gets a ActivityCode by name
        /// </summary>
        /// <param name="name">The name of the ActivityCode to return</param>
        /// <returns>The ActivityCode represented by 'name'</returns>
        public static ActivityCode GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ActivityCode)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ActivityCode)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ActivityCode)ev;
                    }
                }
            }
            
            return null;
        }
    }

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
    /// These values represent the lithological terminology used in descriptions of rock cuttings in mud
    ///		logs.
    /// </summary>
    public class LithologyType : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected LithologyType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the LithologyType</param>
        public LithologyType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of LithologyTypes
        /// </summary>
        /// <returns>The complete list of LithologyTypes</returns>
        public static List<LithologyType> GetList()
        {
            return GetList<LithologyType>();
        }

        private readonly static LithologyType alkaliFeldsparRhyolite;
        /// <summary>
        /// Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("alkali feldspar rhyolite")]
        public static LithologyType AlkaliFeldsparRhyolite
        {
            get 
            {
                return alkaliFeldsparRhyolite;
            }
        }

        private readonly static LithologyType alkaliOlivineBasalt;
        /// <summary>
        /// Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("alkali olivine basalt")]
        public static LithologyType AlkaliOlivineBasalt
        {
            get 
            {
                return alkaliOlivineBasalt;
            }
        }

        private readonly static LithologyType amphibolite;
        /// <summary>
        /// Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8.
        /// </summary>
        [EnumValueNameAttribute("amphibolite")]
        public static LithologyType Amphibolite
        {
            get 
            {
                return amphibolite;
            }
        }

        private readonly static LithologyType andesite;
        /// <summary>
        /// Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("andesite")]
        public static LithologyType Andesite
        {
            get 
            {
                return andesite;
            }
        }

        private readonly static LithologyType anhydrite;
        /// <summary>
        /// Evaporite composed of at least 50 percent anhydrite. OneGeology / WITSML
        /// </summary>
        [EnumValueNameAttribute("anhydrite")]
        public static LithologyType Anhydrite
        {
            get 
            {
                return anhydrite;
            }
        }

        private readonly static LithologyType anorthositicRock;
        /// <summary>
        /// Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("anorthositic rock")]
        public static LithologyType AnorthositicRock
        {
            get 
            {
                return anorthositicRock;
            }
        }

        private readonly static LithologyType anthracite;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005
        /// </summary>
        [EnumValueNameAttribute("anthracite")]
        public static LithologyType Anthracite
        {
            get 
            {
                return anthracite;
            }
        }

        private readonly static LithologyType aplite;
        /// <summary>
        /// Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("aplite")]
        public static LithologyType Aplite
        {
            get 
            {
                return aplite;
            }
        }

        private readonly static LithologyType arenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite.
        /// </summary>
        [EnumValueNameAttribute("arenite")]
        public static LithologyType Arenite
        {
            get 
            {
                return arenite;
            }
        }

        private readonly static LithologyType arkose;
        /// <summary>
        /// An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%).
        /// </summary>
        [EnumValueNameAttribute("arkose")]
        public static LithologyType Arkose
        {
            get 
            {
                return arkose;
            }
        }

        private readonly static LithologyType basalt;
        /// <summary>
        /// Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basalt")]
        public static LithologyType Basalt
        {
            get 
            {
                return basalt;
            }
        }

        private readonly static LithologyType basanite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basanite")]
        public static LithologyType Basanite
        {
            get 
            {
                return basanite;
            }
        }

        private readonly static LithologyType bauxite;
        /// <summary>
        /// Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001.
        /// </summary>
        [EnumValueNameAttribute("bauxite")]
        public static LithologyType Bauxite
        {
            get 
            {
                return bauxite;
            }
        }

        private readonly static LithologyType bituminousCoal;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("bituminous coal")]
        public static LithologyType BituminousCoal
        {
            get 
            {
                return bituminousCoal;
            }
        }

        private readonly static LithologyType blueschistMetamorphicRock;
        /// <summary>
        /// Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock
        /// </summary>
        [EnumValueNameAttribute("blueschist metamorphic rock")]
        public static LithologyType BlueschistMetamorphicRock
        {
            get 
            {
                return blueschistMetamorphicRock;
            }
        }

        private readonly static LithologyType boninite;
        /// <summary>
        /// andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("boninite")]
        public static LithologyType Boninite
        {
            get 
            {
                return boninite;
            }
        }

        private readonly static LithologyType breccia;
        /// <summary>
        /// Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("breccia")]
        public static LithologyType Breccia
        {
            get 
            {
                return breccia;
            }
        }

        private readonly static LithologyType calcarenite;
        /// <summary>
        /// DEPRECATED. See "impure limestone".
        /// </summary>
        [EnumValueNameAttribute("calcarenite")]
        public static LithologyType Calcarenite
        {
            get 
            {
                return calcarenite;
            }
        }

        private readonly static LithologyType calcilutite;
        /// <summary>
        /// DEPRECATED. See "impure limestone".
        /// </summary>
        [EnumValueNameAttribute("calcilutite")]
        public static LithologyType Calcilutite
        {
            get 
            {
                return calcilutite;
            }
        }

        private readonly static LithologyType calcisiltite;
        /// <summary>
        /// DEPRECATED. See "impure limestone".
        /// </summary>
        [EnumValueNameAttribute("calcisiltite")]
        public static LithologyType Calcisiltite
        {
            get 
            {
                return calcisiltite;
            }
        }

        private readonly static LithologyType carbonateOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("carbonate ooze")]
        public static LithologyType CarbonateOoze
        {
            get 
            {
                return carbonateOoze;
            }
        }

        private readonly static LithologyType carbonatite;
        /// <summary>
        /// Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("carbonatite")]
        public static LithologyType Carbonatite
        {
            get 
            {
                return carbonatite;
            }
        }

        private readonly static LithologyType chalk;
        /// <summary>
        /// A generally soft, white, very fine-grained, extremely pure, porous limestone. It forms under marine conditions from the gradual accumulation of skeletal elements from minute planktonic green algae (cocoliths), associated with varying proportions of larger microscopic fragments of bivalves, foraminifera and ostracods. It is common to find flint and chert nodules embedded in chalk. C.S. Harris, 2009
        /// </summary>
        [EnumValueNameAttribute("chalk")]
        public static LithologyType Chalk
        {
            get 
            {
                return chalk;
            }
        }

        private readonly static LithologyType chert;
        /// <summary>
        /// Sedimentary rock that consists of at least 50 percent silicate mineral material, deposited directly by chemical or biological processes at the depositional surface, or in particles formed by chemical or biological processes within the basin of deposition. SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("chert")]
        public static LithologyType Chert
        {
            get 
            {
                return chert;
            }
        }

        private readonly static LithologyType clay;
        /// <summary>
        /// Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("clay")]
        public static LithologyType Clay
        {
            get 
            {
                return clay;
            }
        }

        private readonly static LithologyType claystone;
        /// <summary>
        /// Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("claystone")]
        public static LithologyType Claystone
        {
            get 
            {
                return claystone;
            }
        }

        private readonly static LithologyType coal;
        /// <summary>
        /// A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("coal")]
        public static LithologyType Coal
        {
            get 
            {
                return coal;
            }
        }

        private readonly static LithologyType conglomerate;
        /// <summary>
        /// Clastic sedimentary rock composed of at least 30 percent rounded to subangular fragments larger than 2 millimeter in diameter; typically contains finer grained material in interstices between larger fragments. If more than 15 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wackestone. If rock has unsorted or poorly sorted texture with a wide range of particle sizes, may also be categorized as diamictite. Neuendorf et al. 2005; SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("conglomerate")]
        public static LithologyType Conglomerate
        {
            get 
            {
                return conglomerate;
            }
        }

        private readonly static LithologyType dacite;
        /// <summary>
        /// Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dacite")]
        public static LithologyType Dacite
        {
            get 
            {
                return dacite;
            }
        }

        private readonly static LithologyType diabase;
        /// <summary>
        /// Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite.
        /// </summary>
        [EnumValueNameAttribute("diabase")]
        public static LithologyType Diabase
        {
            get 
            {
                return diabase;
            }
        }

        private readonly static LithologyType diamictite;
        /// <summary>
        /// Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978.
        /// </summary>
        [EnumValueNameAttribute("diamictite")]
        public static LithologyType Diamictite
        {
            get 
            {
                return diamictite;
            }
        }

        private readonly static LithologyType diorite;
        /// <summary>
        /// Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite.
        /// </summary>
        [EnumValueNameAttribute("diorite")]
        public static LithologyType Diorite
        {
            get 
            {
                return diorite;
            }
        }

        private readonly static LithologyType dioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dioritoid")]
        public static LithologyType Dioritoid
        {
            get 
            {
                return dioritoid;
            }
        }

        private readonly static LithologyType doleriticRock;
        /// <summary>
        /// Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("doleritic rock")]
        public static LithologyType DoleriticRock
        {
            get 
            {
                return doleriticRock;
            }
        }

        private readonly static LithologyType dolomite;
        /// <summary>
        /// Pure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static LithologyType Dolomite
        {
            get 
            {
                return dolomite;
            }
        }

        private readonly static LithologyType dolomiteCalcareous;
        /// <summary>
        /// DEPRECATED. See "impure dolomite".
        /// </summary>
        [EnumValueNameAttribute("dolomite, calcareous")]
        public static LithologyType DolomiteCalcareous
        {
            get 
            {
                return dolomiteCalcareous;
            }
        }

        private readonly static LithologyType eclogite;
        /// <summary>
        /// Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("eclogite")]
        public static LithologyType Eclogite
        {
            get 
            {
                return eclogite;
            }
        }

        private readonly static LithologyType exoticAlkalineRock;
        /// <summary>
        /// Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("exotic alkaline rock")]
        public static LithologyType ExoticAlkalineRock
        {
            get 
            {
                return exoticAlkalineRock;
            }
        }

        private readonly static LithologyType extrusiveRockVolcanic;
        /// <summary>
        /// DEPRECATED. See "fragmental igneous rock".
        /// </summary>
        [EnumValueNameAttribute("extrusive rock (volcanic)")]
        public static LithologyType ExtrusiveRockVolcanic
        {
            get 
            {
                return extrusiveRockVolcanic;
            }
        }

        private readonly static LithologyType feldspar;
        /// <summary>
        /// The family of aluminium silicates of sodium, potassium, calcium and other metals which comprise over 60% of the earth's crust, are the most abundant mineral group, and occur in all types of rocks.
        /// </summary>
        [EnumValueNameAttribute("feldspar")]
        public static LithologyType Feldspar
        {
            get 
            {
                return feldspar;
            }
        }

        private readonly static LithologyType feldspathicArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("feldspathic arenite")]
        public static LithologyType FeldspathicArenite
        {
            get 
            {
                return feldspathicArenite;
            }
        }

        private readonly static LithologyType fineGrainedIgneousRock;
        /// <summary>
        /// Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("fine grained igneous rock")]
        public static LithologyType FineGrainedIgneousRock
        {
            get 
            {
                return fineGrainedIgneousRock;
            }
        }

        private readonly static LithologyType foidDioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid dioritoid")]
        public static LithologyType FoidDioritoid
        {
            get 
            {
                return foidDioritoid;
            }
        }

        private readonly static LithologyType foidGabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid gabbroid")]
        public static LithologyType FoidGabbroid
        {
            get 
            {
                return foidGabbroid;
            }
        }

        private readonly static LithologyType foidSyenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid syenitoid")]
        public static LithologyType FoidSyenitoid
        {
            get 
            {
                return foidSyenitoid;
            }
        }

        private readonly static LithologyType foidite;
        /// <summary>
        /// Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidite")]
        public static LithologyType Foidite
        {
            get 
            {
                return foidite;
            }
        }

        private readonly static LithologyType foiditoid;
        /// <summary>
        /// Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foiditoid")]
        public static LithologyType Foiditoid
        {
            get 
            {
                return foiditoid;
            }
        }

        private readonly static LithologyType foidolite;
        /// <summary>
        /// Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidolite")]
        public static LithologyType Foidolite
        {
            get 
            {
                return foidolite;
            }
        }

        private readonly static LithologyType foliatedMetamorphicRock;
        /// <summary>
        /// Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic.
        /// </summary>
        [EnumValueNameAttribute("foliated metamorphic rock")]
        public static LithologyType FoliatedMetamorphicRock
        {
            get 
            {
                return foliatedMetamorphicRock;
            }
        }

        private readonly static LithologyType fragmentalIgneousRock;
        /// <summary>
        /// Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite).
        /// </summary>
        [EnumValueNameAttribute("fragmental igneous rock")]
        public static LithologyType FragmentalIgneousRock
        {
            get 
            {
                return fragmentalIgneousRock;
            }
        }

        private readonly static LithologyType gabbro;
        /// <summary>
        /// Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbro")]
        public static LithologyType Gabbro
        {
            get 
            {
                return gabbro;
            }
        }

        private readonly static LithologyType gabbroicRock;
        /// <summary>
        /// Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroic rock")]
        public static LithologyType GabbroicRock
        {
            get 
            {
                return gabbroicRock;
            }
        }

        private readonly static LithologyType gabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroid")]
        public static LithologyType Gabbroid
        {
            get 
            {
                return gabbroid;
            }
        }

        private readonly static LithologyType glauconite;
        /// <summary>
        /// A mineral composed of ferrous potassium silicates related to mica which commonly imparts a green color to its sedimentary host rock.
        /// </summary>
        [EnumValueNameAttribute("glauconite")]
        public static LithologyType Glauconite
        {
            get 
            {
                return glauconite;
            }
        }

        private readonly static LithologyType gneiss;
        /// <summary>
        /// Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("gneiss")]
        public static LithologyType Gneiss
        {
            get 
            {
                return gneiss;
            }
        }

        private readonly static LithologyType granite;
        /// <summary>
        /// Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granite")]
        public static LithologyType Granite
        {
            get 
            {
                return granite;
            }
        }

        private readonly static LithologyType granodiorite;
        /// <summary>
        /// Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granodiorite")]
        public static LithologyType Granodiorite
        {
            get 
            {
                return granodiorite;
            }
        }

        private readonly static LithologyType granofels;
        /// <summary>
        /// Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004.
        /// </summary>
        [EnumValueNameAttribute("granofels")]
        public static LithologyType Granofels
        {
            get 
            {
                return granofels;
            }
        }

        private readonly static LithologyType granulite;
        /// <summary>
        /// Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2
        /// </summary>
        [EnumValueNameAttribute("granulite")]
        public static LithologyType Granulite
        {
            get 
            {
                return granulite;
            }
        }

        private readonly static LithologyType gravel;
        /// <summary>
        /// Clastic sediment containing greater than 30 percent gravel-size particles (greater than 2.0 millimeter diameter). Gravel in which more than half of the particles are of epiclastic origin.definition of gravel from SLTTs 2004; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("gravel")]
        public static LithologyType Gravel
        {
            get 
            {
                return gravel;
            }
        }

        private readonly static LithologyType greenstone;
        /// <summary>
        /// Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone.
        /// </summary>
        [EnumValueNameAttribute("greenstone")]
        public static LithologyType Greenstone
        {
            get 
            {
                return greenstone;
            }
        }

        private readonly static LithologyType greenstones;
        /// <summary>
        /// DEPRECATED. See "greenstone".
        /// </summary>
        [EnumValueNameAttribute("greenstones")]
        public static LithologyType Greenstones
        {
            get 
            {
                return greenstones;
            }
        }

        private readonly static LithologyType greywacke;
        /// <summary>
        /// DEPRECATED. See "wacke".
        /// </summary>
        [EnumValueNameAttribute("greywacke")]
        public static LithologyType Greywacke
        {
            get 
            {
                return greywacke;
            }
        }

        private readonly static LithologyType gumbo;
        /// <summary>
        /// A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet.
        /// </summary>
        [EnumValueNameAttribute("gumbo")]
        public static LithologyType Gumbo
        {
            get 
            {
                return gumbo;
            }
        }

        private readonly static LithologyType gypsum;
        /// <summary>
        /// Evaporite composed of at least 50 percent gypsum . OneGeology / WITSML
        /// </summary>
        [EnumValueNameAttribute("gypsum")]
        public static LithologyType Gypsum
        {
            get 
            {
                return gypsum;
            }
        }

        private readonly static LithologyType halite;
        /// <summary>
        /// Evaporite composed of at least 90 percent halite.(NaCl). Use Rock Salt if unclear on chemical composition. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static LithologyType Halite
        {
            get 
            {
                return halite;
            }
        }

        private readonly static LithologyType hornfels;
        /// <summary>
        /// Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained.
        /// </summary>
        [EnumValueNameAttribute("hornfels")]
        public static LithologyType Hornfels
        {
            get 
            {
                return hornfels;
            }
        }

        private readonly static LithologyType igneous;
        /// <summary>
        /// DEPRECATED. See "igneous rock".
        /// </summary>
        [EnumValueNameAttribute("igneous")]
        public static LithologyType Igneous
        {
            get 
            {
                return igneous;
            }
        }

        private readonly static LithologyType igneousRock;
        /// <summary>
        /// Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("igneous rock")]
        public static LithologyType IgneousRock
        {
            get 
            {
                return igneousRock;
            }
        }

        private readonly static LithologyType impactGeneratedMaterial;
        /// <summary>
        /// Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("impact generated material")]
        public static LithologyType ImpactGeneratedMaterial
        {
            get 
            {
                return impactGeneratedMaterial;
            }
        }

        private readonly static LithologyType impureDolomite;
        /// <summary>
        /// Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure dolomite")]
        public static LithologyType ImpureDolomite
        {
            get 
            {
                return impureDolomite;
            }
        }

        private readonly static LithologyType impureLimestone;
        /// <summary>
        /// Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure limestone")]
        public static LithologyType ImpureLimestone
        {
            get 
            {
                return impureLimestone;
            }
        }

        private readonly static LithologyType intrusiveRockPlutonic;
        /// <summary>
        /// Igneous rock formed by cooling and solidification of magma within the earth's crust.
        /// </summary>
        [EnumValueNameAttribute("intrusive rock (plutonic)")]
        public static LithologyType IntrusiveRockPlutonic
        {
            get 
            {
                return intrusiveRockPlutonic;
            }
        }

        private readonly static LithologyType ironRichSedimentaryRock;
        /// <summary>
        /// Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("iron rich sedimentary rock")]
        public static LithologyType IronRichSedimentaryRock
        {
            get 
            {
                return ironRichSedimentaryRock;
            }
        }

        private readonly static LithologyType kalsiliticAndMeliliticRocks;
        /// <summary>
        /// Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("kalsilitic and melilitic rocks")]
        public static LithologyType KalsiliticAndMeliliticRocks
        {
            get 
            {
                return kalsiliticAndMeliliticRocks;
            }
        }

        private readonly static LithologyType komatiiticRock;
        /// <summary>
        /// Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("komatiitic rock")]
        public static LithologyType KomatiiticRock
        {
            get 
            {
                return komatiiticRock;
            }
        }

        private readonly static LithologyType latiticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("latitic rock")]
        public static LithologyType LatiticRock
        {
            get 
            {
                return latiticRock;
            }
        }

        private readonly static LithologyType lignite;
        /// <summary>
        /// Coal that has a gross calorific value less than 24 MJ/kg (determined in conformance with ISO 1928), and vitrinite mean random reflectance less than 0.6 percent (determined in conformance with ISO 7404-5). Gross calorific value is recalculated to a moist, ash free basis using bed moisture (determined according to ISO 1015 or ISO 5068). Includes all low-rank coals, including sub-bitiminous coal. A consolidated, dull, soft brown to black coal having many readily discernible plant fragments set in a finer grained organic matrix. Tends to crack and fall apart on drying. Operationally sub-bituminous and bitiminous coal are qualitatively distinguished based on brown streak for sub-bitiminous coal and black streak for bituminous coal. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static LithologyType Lignite
        {
            get 
            {
                return lignite;
            }
        }

        private readonly static LithologyType limeBoundstone;
        /// <summary>
        /// Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime boundstone")]
        public static LithologyType LimeBoundstone
        {
            get 
            {
                return limeBoundstone;
            }
        }

        private readonly static LithologyType limeFramestone;
        /// <summary>
        /// Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth &amp; Knox 1999; SLTTs 2004, Table 15-3-1
        /// </summary>
        [EnumValueNameAttribute("lime framestone")]
        public static LithologyType LimeFramestone
        {
            get 
            {
                return limeFramestone;
            }
        }

        private readonly static LithologyType limeGrainstone;
        /// <summary>
        /// Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime grainstone")]
        public static LithologyType LimeGrainstone
        {
            get 
            {
                return limeGrainstone;
            }
        }

        private readonly static LithologyType limeMudstone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary.
        /// </summary>
        [EnumValueNameAttribute("lime mudstone")]
        public static LithologyType LimeMudstone
        {
            get 
            {
                return limeMudstone;
            }
        }

        private readonly static LithologyType limePackstone;
        /// <summary>
        /// Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime packstone")]
        public static LithologyType LimePackstone
        {
            get 
            {
                return limePackstone;
            }
        }

        private readonly static LithologyType limeWackestone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime wackestone")]
        public static LithologyType LimeWackestone
        {
            get 
            {
                return limeWackestone;
            }
        }

        private readonly static LithologyType limestone;
        /// <summary>
        /// Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("limestone")]
        public static LithologyType Limestone
        {
            get 
            {
                return limestone;
            }
        }

        private readonly static LithologyType limestoneArgillaceous;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% clay minerals.
        /// </summary>
        [EnumValueNameAttribute("limestone, argillaceous")]
        public static LithologyType LimestoneArgillaceous
        {
            get 
            {
                return limestoneArgillaceous;
            }
        }

        private readonly static LithologyType limestoneDolomitic;
        /// <summary>
        /// A limestone containing 10-50% dolomite and 50-90% calcite.
        /// </summary>
        [EnumValueNameAttribute("limestone, dolomitic")]
        public static LithologyType LimestoneDolomitic
        {
            get 
            {
                return limestoneDolomitic;
            }
        }

        private readonly static LithologyType limestoneSandy;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% quartz grains.
        /// </summary>
        [EnumValueNameAttribute("limestone, sandy")]
        public static LithologyType LimestoneSandy
        {
            get 
            {
                return limestoneSandy;
            }
        }

        private readonly static LithologyType marble;
        /// <summary>
        /// Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("marble")]
        public static LithologyType Marble
        {
            get 
            {
                return marble;
            }
        }

        private readonly static LithologyType marl;
        /// <summary>
        /// A consolidated or semi-consolidated mixture of clay and generally fine grained carbonate material.
        /// </summary>
        [EnumValueNameAttribute("marl")]
        public static LithologyType Marl
        {
            get 
            {
                return marl;
            }
        }

        private readonly static LithologyType metamorphicRock;
        /// <summary>
        /// Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("metamorphic rock")]
        public static LithologyType MetamorphicRock
        {
            get 
            {
                return metamorphicRock;
            }
        }

        private readonly static LithologyType metamorphicRocks;
        /// <summary>
        /// DEPRECATED. See "metamorphic rock".
        /// </summary>
        [EnumValueNameAttribute("metamorphic rocks")]
        public static LithologyType MetamorphicRocks
        {
            get 
            {
                return metamorphicRocks;
            }
        }

        private readonly static LithologyType micaSchist;
        /// <summary>
        /// A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("mica schist")]
        public static LithologyType MicaSchist
        {
            get 
            {
                return micaSchist;
            }
        }

        private readonly static LithologyType migmatite;
        /// <summary>
        /// Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)
        /// </summary>
        [EnumValueNameAttribute("migmatite")]
        public static LithologyType Migmatite
        {
            get 
            {
                return migmatite;
            }
        }

        private readonly static LithologyType monzogabbro;
        /// <summary>
        /// Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("monzogabbro")]
        public static LithologyType Monzogabbro
        {
            get 
            {
                return monzogabbro;
            }
        }

        private readonly static LithologyType mud;
        /// <summary>
        /// Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("mud")]
        public static LithologyType Mud
        {
            get 
            {
                return mud;
            }
        }

        private readonly static LithologyType mudstone;
        /// <summary>
        /// Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth &amp; Knox 1999; extrapolated from Folk, 1954, Figure 1a.
        /// </summary>
        [EnumValueNameAttribute("mudstone")]
        public static LithologyType Mudstone
        {
            get 
            {
                return mudstone;
            }
        }

        private readonly static LithologyType myloniticRock;
        /// <summary>
        /// Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak &amp; Mitra 1988.
        /// </summary>
        [EnumValueNameAttribute("mylonitic rock")]
        public static LithologyType MyloniticRock
        {
            get 
            {
                return myloniticRock;
            }
        }

        private readonly static LithologyType noDescription;
        /// <summary>
        /// No description is provided.
        /// </summary>
        [EnumValueNameAttribute("no description")]
        public static LithologyType NoDescription
        {
            get 
            {
                return noDescription;
            }
        }

        private readonly static LithologyType noSample;
        /// <summary>
        /// A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML.
        /// </summary>
        [EnumValueNameAttribute("no sample")]
        public static LithologyType NoSample
        {
            get 
            {
                return noSample;
            }
        }

        private readonly static LithologyType ooze;
        /// <summary>
        /// Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 &amp; Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("ooze")]
        public static LithologyType Ooze
        {
            get 
            {
                return ooze;
            }
        }

        private readonly static LithologyType ophiolite;
        /// <summary>
        /// Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust.
        /// </summary>
        [EnumValueNameAttribute("ophiolite")]
        public static LithologyType Ophiolite
        {
            get 
            {
                return ophiolite;
            }
        }

        private readonly static LithologyType organicBearingMudstone;
        /// <summary>
        /// Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;
        /// </summary>
        [EnumValueNameAttribute("organic bearing mudstone")]
        public static LithologyType OrganicBearingMudstone
        {
            get 
            {
                return organicBearingMudstone;
            }
        }

        private readonly static LithologyType peat;
        /// <summary>
        /// Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("peat")]
        public static LithologyType Peat
        {
            get 
            {
                return peat;
            }
        }

        private readonly static LithologyType pegmatite;
        /// <summary>
        /// Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("pegmatite")]
        public static LithologyType Pegmatite
        {
            get 
            {
                return pegmatite;
            }
        }

        private readonly static LithologyType peridotite;
        /// <summary>
        /// Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("peridotite")]
        public static LithologyType Peridotite
        {
            get 
            {
                return peridotite;
            }
        }

        private readonly static LithologyType phaneriticIgneousRock;
        /// <summary>
        /// Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("phaneritic igneous rock")]
        public static LithologyType PhaneriticIgneousRock
        {
            get 
            {
                return phaneriticIgneousRock;
            }
        }

        private readonly static LithologyType phonolite;
        /// <summary>
        /// Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolite")]
        public static LithologyType Phonolite
        {
            get 
            {
                return phonolite;
            }
        }

        private readonly static LithologyType phonolitoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolitoid")]
        public static LithologyType Phonolitoid
        {
            get 
            {
                return phonolitoid;
            }
        }

        private readonly static LithologyType phosphate;
        /// <summary>
        /// Any mineral compound containing the ((PO4)3) radical.
        /// </summary>
        [EnumValueNameAttribute("phosphate")]
        public static LithologyType Phosphate
        {
            get 
            {
                return phosphate;
            }
        }

        private readonly static LithologyType phosphateRock;
        /// <summary>
        /// Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource.
        /// </summary>
        [EnumValueNameAttribute("phosphate rock")]
        public static LithologyType PhosphateRock
        {
            get 
            {
                return phosphateRock;
            }
        }

        private readonly static LithologyType phyllite;
        /// <summary>
        /// Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007.
        /// </summary>
        [EnumValueNameAttribute("phyllite")]
        public static LithologyType Phyllite
        {
            get 
            {
                return phyllite;
            }
        }

        private readonly static LithologyType porphyry;
        /// <summary>
        /// Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("porphyry")]
        public static LithologyType Porphyry
        {
            get 
            {
                return porphyry;
            }
        }

        private readonly static LithologyType potassiumAndMagnesiumSalts;
        /// <summary>
        /// Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML.
        /// </summary>
        [EnumValueNameAttribute("potassium and magnesium salts")]
        public static LithologyType PotassiumAndMagnesiumSalts
        {
            get 
            {
                return potassiumAndMagnesiumSalts;
            }
        }

        private readonly static LithologyType pyroclasticBreccia;
        /// <summary>
        /// Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic breccia")]
        public static LithologyType PyroclasticBreccia
        {
            get 
            {
                return pyroclasticBreccia;
            }
        }

        private readonly static LithologyType pyroclasticRock;
        /// <summary>
        /// Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic rock")]
        public static LithologyType PyroclasticRock
        {
            get 
            {
                return pyroclasticRock;
            }
        }

        private readonly static LithologyType pyroxenite;
        /// <summary>
        /// Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroxenite")]
        public static LithologyType Pyroxenite
        {
            get 
            {
                return pyroxenite;
            }
        }

        private readonly static LithologyType quartzArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("quartz arenite")]
        public static LithologyType QuartzArenite
        {
            get 
            {
                return quartzArenite;
            }
        }

        private readonly static LithologyType quartzite;
        /// <summary>
        /// Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("quartzite")]
        public static LithologyType Quartzite
        {
            get 
            {
                return quartzite;
            }
        }

        private readonly static LithologyType rhyolite;
        /// <summary>
        /// rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("rhyolite")]
        public static LithologyType Rhyolite
        {
            get 
            {
                return rhyolite;
            }
        }

        private readonly static LithologyType rockSalt;
        /// <summary>
        /// Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("rock salt")]
        public static LithologyType RockSalt
        {
            get 
            {
                return rockSalt;
            }
        }

        private readonly static LithologyType salt;
        /// <summary>
        /// DEPRECATED. See "rock salt".
        /// </summary>
        [EnumValueNameAttribute("salt")]
        public static LithologyType Salt
        {
            get 
            {
                return salt;
            }
        }

        private readonly static LithologyType sand;
        /// <summary>
        /// Clastic sediment in which less than 30 percent of particles are gravel (greater than 2 millimeter in diameter) and the sand to mud ratio is at least 1. More than half of the particles are of epiclastic origin.definition of sand from SLTTs 2004 sandy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("sand")]
        public static LithologyType Sand
        {
            get 
            {
                return sand;
            }
        }

        private readonly static LithologyType sandstone;
        /// <summary>
        /// Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("sandstone")]
        public static LithologyType Sandstone
        {
            get 
            {
                return sandstone;
            }
        }

        private readonly static LithologyType sapropel;
        /// <summary>
        /// Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("sapropel")]
        public static LithologyType Sapropel
        {
            get 
            {
                return sapropel;
            }
        }

        private readonly static LithologyType schist;
        /// <summary>
        /// Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("schist")]
        public static LithologyType Schist
        {
            get 
            {
                return schist;
            }
        }

        private readonly static LithologyType serpentine;
        /// <summary>
        /// DEPRECATED. See "serpentinite".
        /// </summary>
        [EnumValueNameAttribute("serpentine")]
        public static LithologyType Serpentine
        {
            get 
            {
                return serpentine;
            }
        }

        private readonly static LithologyType serpentinite;
        /// <summary>
        /// Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("serpentinite")]
        public static LithologyType Serpentinite
        {
            get 
            {
                return serpentinite;
            }
        }

        private readonly static LithologyType shale;
        /// <summary>
        /// Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically.
        /// </summary>
        [EnumValueNameAttribute("shale")]
        public static LithologyType Shale
        {
            get 
            {
                return shale;
            }
        }

        private readonly static LithologyType siliceousOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siliceous ooze")]
        public static LithologyType SiliceousOoze
        {
            get 
            {
                return siliceousOoze;
            }
        }

        private readonly static LithologyType silt;
        /// <summary>
        /// Mud that consists of greater than 50 percent silt-size grains. Based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("silt")]
        public static LithologyType Silt
        {
            get 
            {
                return silt;
            }
        }

        private readonly static LithologyType siltstone;
        /// <summary>
        /// Mudstone that contains detectable silt. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siltstone")]
        public static LithologyType Siltstone
        {
            get 
            {
                return siltstone;
            }
        }

        private readonly static LithologyType skarn;
        /// <summary>
        /// Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195.
        /// </summary>
        [EnumValueNameAttribute("skarn")]
        public static LithologyType Skarn
        {
            get 
            {
                return skarn;
            }
        }

        private readonly static LithologyType slate;
        /// <summary>
        /// Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("slate")]
        public static LithologyType Slate
        {
            get 
            {
                return slate;
            }
        }

        private readonly static LithologyType spilite;
        /// <summary>
        /// Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619.
        /// </summary>
        [EnumValueNameAttribute("spilite")]
        public static LithologyType Spilite
        {
            get 
            {
                return spilite;
            }
        }

        private readonly static LithologyType syenite;
        /// <summary>
        /// Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz.
        /// </summary>
        [EnumValueNameAttribute("syenite")]
        public static LithologyType Syenite
        {
            get 
            {
                return syenite;
            }
        }

        private readonly static LithologyType syenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("syenitoid")]
        public static LithologyType Syenitoid
        {
            get 
            {
                return syenitoid;
            }
        }

        private readonly static LithologyType sylvite;
        /// <summary>
        /// Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology.
        /// </summary>
        [EnumValueNameAttribute("sylvite")]
        public static LithologyType Sylvite
        {
            get 
            {
                return sylvite;
            }
        }

        private readonly static LithologyType tephrite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephrite")]
        public static LithologyType Tephrite
        {
            get 
            {
                return tephrite;
            }
        }

        private readonly static LithologyType tephritoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephritoid")]
        public static LithologyType Tephritoid
        {
            get 
            {
                return tephritoid;
            }
        }

        private readonly static LithologyType tholeiiticBasalt;
        /// <summary>
        /// Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("tholeiitic basalt")]
        public static LithologyType TholeiiticBasalt
        {
            get 
            {
                return tholeiiticBasalt;
            }
        }

        private readonly static LithologyType tilliteDiamictite;
        /// <summary>
        /// DEPRECATED. See "diamictite".
        /// </summary>
        [EnumValueNameAttribute("tillite (diamictite)")]
        public static LithologyType TilliteDiamictite
        {
            get 
            {
                return tilliteDiamictite;
            }
        }

        private readonly static LithologyType tonalite;
        /// <summary>
        /// Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tonalite")]
        public static LithologyType Tonalite
        {
            get 
            {
                return tonalite;
            }
        }

        private readonly static LithologyType trachyte;
        /// <summary>
        /// A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals.
        /// </summary>
        [EnumValueNameAttribute("trachyte")]
        public static LithologyType Trachyte
        {
            get 
            {
                return trachyte;
            }
        }

        private readonly static LithologyType trachyticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytic rock")]
        public static LithologyType TrachyticRock
        {
            get 
            {
                return trachyticRock;
            }
        }

        private readonly static LithologyType trachytoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytoid")]
        public static LithologyType Trachytoid
        {
            get 
            {
                return trachytoid;
            }
        }

        private readonly static LithologyType travertine;
        /// <summary>
        /// Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74.
        /// </summary>
        [EnumValueNameAttribute("travertine")]
        public static LithologyType Travertine
        {
            get 
            {
                return travertine;
            }
        }

        private readonly static LithologyType tuff;
        /// <summary>
        /// Ash tuff, lapillistone, and lapilli tuff. Pyroclastic rock in which less than 25 percent of rock by volume are more than 64 millimeter in longest diameter. Includes tuff, lapilli tuff, and lapillistone. Schmid 1981; LeMaitre et al. 2002. Modified by WITSML to just use the term Tuff.
        /// </summary>
        [EnumValueNameAttribute("tuff")]
        public static LithologyType Tuff
        {
            get 
            {
                return tuff;
            }
        }

        private readonly static LithologyType tuffite;
        /// <summary>
        /// Rock consists of more than 50 percent particles of indeterminate pyroclastic or epiclastic origin and less than 75 percent particles of clearly pyroclastic origin. Commonly the rock is laminated or exhibits size grading. (based on LeMaitre et al. 2002; Murawski and Meyer 1998).
        /// </summary>
        [EnumValueNameAttribute("tuffite")]
        public static LithologyType Tuffite
        {
            get 
            {
                return tuffite;
            }
        }

        private readonly static LithologyType ultrabasic;
        /// <summary>
        /// A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%.
        /// </summary>
        [EnumValueNameAttribute("ultrabasic")]
        public static LithologyType Ultrabasic
        {
            get 
            {
                return ultrabasic;
            }
        }

        private readonly static LithologyType undifferentiated;
        /// <summary>
        /// The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent.
        /// </summary>
        [EnumValueNameAttribute("undifferentiated")]
        public static LithologyType Undifferentiated
        {
            get 
            {
                return undifferentiated;
            }
        }

        private readonly static LithologyType wacke;
        /// <summary>
        /// Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p.
        /// </summary>
        [EnumValueNameAttribute("wacke")]
        public static LithologyType Wacke
        {
            get 
            {
                return wacke;
            }
        }

        private readonly static LithologyType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static LithologyType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static LithologyType()
        {
            alkaliFeldsparRhyolite = 
                new LithologyType("alkali feldspar rhyolite")
                {
                    Description = "Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            alkaliOlivineBasalt = 
                new LithologyType("alkali olivine basalt")
                {
                    Description = "Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43."
                    ,Version = "1.4.1.0"
            };
            amphibolite = 
                new LithologyType("amphibolite")
                {
                    Description = "Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8."
                    ,Version = "1.4.1.0"
            };
            andesite = 
                new LithologyType("andesite")
                {
                    Description = "Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            anhydrite = 
                new LithologyType("anhydrite")
                {
                    Description = "Evaporite composed of at least 50 percent anhydrite. OneGeology / WITSML"
                    ,Version = "1.4.1.0"
            };
            anorthositicRock = 
                new LithologyType("anorthositic rock")
                {
                    Description = "Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            anthracite = 
                new LithologyType("anthracite")
                {
                    Description = "Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005"
                    ,Version = "1.4.1.0"
            };
            aplite = 
                new LithologyType("aplite")
                {
                    Description = "Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            arenite = 
                new LithologyType("arenite")
                {
                    Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite."
                    ,Version = "1.4.1.0"
            };
            arkose = 
                new LithologyType("arkose")
                {
                    Description = "An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%)."
                    ,Version = "1.3.1.1"
            };
            basalt = 
                new LithologyType("basalt")
                {
                    Description = "Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            basanite = 
                new LithologyType("basanite")
                {
                    Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            bauxite = 
                new LithologyType("bauxite")
                {
                    Description = "Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001."
                    ,Version = "1.4.1.0"
            };
            bituminousCoal = 
                new LithologyType("bituminous coal")
                {
                    Description = "Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp."
                    ,Version = "1.4.1.0"
            };
            blueschistMetamorphicRock = 
                new LithologyType("blueschist metamorphic rock")
                {
                    Description = "Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock"
                    ,Version = "1.4.1.0"
            };
            boninite = 
                new LithologyType("boninite")
                {
                    Description = "andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            breccia = 
                new LithologyType("breccia")
                {
                    Description = "Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            calcarenite = 
                new LithologyType("calcarenite")
                {
                    Description = "DEPRECATED. See \"impure limestone\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = ImpureLimestone
            };
            calcilutite = 
                new LithologyType("calcilutite")
                {
                    Description = "DEPRECATED. See \"impure limestone\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = ImpureLimestone
            };
            calcisiltite = 
                new LithologyType("calcisiltite")
                {
                    Description = "DEPRECATED. See \"impure limestone\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = ImpureLimestone
            };
            carbonateOoze = 
                new LithologyType("carbonate ooze")
                {
                    Description = "Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology."
                    ,Version = "1.4.1.0"
            };
            carbonatite = 
                new LithologyType("carbonatite")
                {
                    Description = "Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            chalk = 
                new LithologyType("chalk")
                {
                    Description = "A generally soft, white, very fine-grained, extremely pure, porous limestone. It forms under marine conditions from the gradual accumulation of skeletal elements from minute planktonic green algae (cocoliths), associated with varying proportions of larger microscopic fragments of bivalves, foraminifera and ostracods. It is common to find flint and chert nodules embedded in chalk. C.S. Harris, 2009"
                    ,Version = "1.4.1.0"
            };
            chert = 
                new LithologyType("chert")
                {
                    Description = "Sedimentary rock that consists of at least 50 percent silicate mineral material, deposited directly by chemical or biological processes at the depositional surface, or in particles formed by chemical or biological processes within the basin of deposition. SLTTs 2004."
                    ,Version = "1.4.1.0"
            };
            clay = 
                new LithologyType("clay")
                {
                    Description = "Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale."
                    ,Version = "1.4.1.0"
            };
            claystone = 
                new LithologyType("claystone")
                {
                    Description = "Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology."
                    ,Version = "1.4.1.0"
            };
            coal = 
                new LithologyType("coal")
                {
                    Description = "A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp."
                    ,Version = "1.3.1.1"
            };
            conglomerate = 
                new LithologyType("conglomerate")
                {
                    Description = "Clastic sedimentary rock composed of at least 30 percent rounded to subangular fragments larger than 2 millimeter in diameter; typically contains finer grained material in interstices between larger fragments. If more than 15 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wackestone. If rock has unsorted or poorly sorted texture with a wide range of particle sizes, may also be categorized as diamictite. Neuendorf et al. 2005; SLTTs 2004."
                    ,Version = "1.4.1.0"
            };
            dacite = 
                new LithologyType("dacite")
                {
                    Description = "Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            diabase = 
                new LithologyType("diabase")
                {
                    Description = "Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite."
                    ,Version = "1.3.1.1"
            };
            diamictite = 
                new LithologyType("diamictite")
                {
                    Description = "Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978."
                    ,Version = "1.4.1.0"
            };
            diorite = 
                new LithologyType("diorite")
                {
                    Description = "Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite."
                    ,Version = "1.3.1.1"
            };
            dioritoid = 
                new LithologyType("dioritoid")
                {
                    Description = "Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            doleriticRock = 
                new LithologyType("doleritic rock")
                {
                    Description = "Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            dolomite = 
                new LithologyType("dolomite")
                {
                    Description = "Pure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology."
                    ,Version = "1.4.1.0"
            };
            dolomiteCalcareous = 
                new LithologyType("dolomite, calcareous")
                {
                    Description = "DEPRECATED. See \"impure dolomite\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = ImpureDolomite
            };
            eclogite = 
                new LithologyType("eclogite")
                {
                    Description = "Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007"
                    ,Version = "1.4.1.0"
            };
            exoticAlkalineRock = 
                new LithologyType("exotic alkaline rock")
                {
                    Description = "Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            extrusiveRockVolcanic = 
                new LithologyType("extrusive rock (volcanic)")
                {
                    Description = "DEPRECATED. See \"fragmental igneous rock\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = FragmentalIgneousRock
            };
            feldspar = 
                new LithologyType("feldspar")
                {
                    Description = "The family of aluminium silicates of sodium, potassium, calcium and other metals which comprise over 60% of the earth's crust, are the most abundant mineral group, and occur in all types of rocks."
                    ,Version = "1.3.1.1"
            };
            feldspathicArenite = 
                new LithologyType("feldspathic arenite")
                {
                    Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632."
                    ,Version = "1.4.1.0"
            };
            fineGrainedIgneousRock = 
                new LithologyType("fine grained igneous rock")
                {
                    Description = "Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidDioritoid = 
                new LithologyType("foid dioritoid")
                {
                    Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidGabbroid = 
                new LithologyType("foid gabbroid")
                {
                    Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidSyenitoid = 
                new LithologyType("foid syenitoid")
                {
                    Description = "Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidite = 
                new LithologyType("foidite")
                {
                    Description = "Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foiditoid = 
                new LithologyType("foiditoid")
                {
                    Description = "Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidolite = 
                new LithologyType("foidolite")
                {
                    Description = "Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foliatedMetamorphicRock = 
                new LithologyType("foliated metamorphic rock")
                {
                    Description = "Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic."
                    ,Version = "1.4.1.0"
            };
            fragmentalIgneousRock = 
                new LithologyType("fragmental igneous rock")
                {
                    Description = "Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite)."
                    ,Version = "1.4.1.0"
            };
            gabbro = 
                new LithologyType("gabbro")
                {
                    Description = "Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            gabbroicRock = 
                new LithologyType("gabbroic rock")
                {
                    Description = "Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            gabbroid = 
                new LithologyType("gabbroid")
                {
                    Description = "Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            glauconite = 
                new LithologyType("glauconite")
                {
                    Description = "A mineral composed of ferrous potassium silicates related to mica which commonly imparts a green color to its sedimentary host rock."
                    ,Version = "1.3.1.1"
            };
            gneiss = 
                new LithologyType("gneiss")
                {
                    Description = "Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            granite = 
                new LithologyType("granite")
                {
                    Description = "Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            granodiorite = 
                new LithologyType("granodiorite")
                {
                    Description = "Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            granofels = 
                new LithologyType("granofels")
                {
                    Description = "Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004."
                    ,Version = "1.4.1.0"
            };
            granulite = 
                new LithologyType("granulite")
                {
                    Description = "Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2"
                    ,Version = "1.4.1.0"
            };
            gravel = 
                new LithologyType("gravel")
                {
                    Description = "Clastic sediment containing greater than 30 percent gravel-size particles (greater than 2.0 millimeter diameter). Gravel in which more than half of the particles are of epiclastic origin.definition of gravel from SLTTs 2004; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.)."
                    ,Version = "1.4.1.0"
            };
            greenstone = 
                new LithologyType("greenstone")
                {
                    Description = "Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone."
                    ,Version = "1.4.1.0"
            };
            greenstones = 
                new LithologyType("greenstones")
                {
                    Description = "DEPRECATED. See \"greenstone\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = Greenstone
            };
            greywacke = 
                new LithologyType("greywacke")
                {
                    Description = "DEPRECATED. See \"wacke\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = Wacke
            };
            gumbo = 
                new LithologyType("gumbo")
                {
                    Description = "A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet."
                    ,Version = "1.3.1.1"
            };
            gypsum = 
                new LithologyType("gypsum")
                {
                    Description = "Evaporite composed of at least 50 percent gypsum . OneGeology / WITSML"
                    ,Version = "1.4.1.0"
            };
            halite = 
                new LithologyType("halite")
                {
                    Description = "Evaporite composed of at least 90 percent halite.(NaCl). Use Rock Salt if unclear on chemical composition. OneGeology."
                    ,Version = "1.4.1.0"
            };
            hornfels = 
                new LithologyType("hornfels")
                {
                    Description = "Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained."
                    ,Version = "1.4.1.0"
            };
            igneous = 
                new LithologyType("igneous")
                {
                    Description = "DEPRECATED. See \"igneous rock\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = IgneousRock
            };
            igneousRock = 
                new LithologyType("igneous rock")
                {
                    Description = "Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            impactGeneratedMaterial = 
                new LithologyType("impact generated material")
                {
                    Description = "Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997."
                    ,Version = "1.4.1.0"
            };
            impureDolomite = 
                new LithologyType("impure dolomite")
                {
                    Description = "Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology."
                    ,Version = "1.4.1.0"
            };
            impureLimestone = 
                new LithologyType("impure limestone")
                {
                    Description = "Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology."
                    ,Version = "1.4.1.0"
            };
            intrusiveRockPlutonic = 
                new LithologyType("intrusive rock (plutonic)")
                {
                    Description = "Igneous rock formed by cooling and solidification of magma within the earth's crust."
                    ,Version = "1.3.1.1"
            };
            ironRichSedimentaryRock = 
                new LithologyType("iron rich sedimentary rock")
                {
                    Description = "Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004."
                    ,Version = "1.4.1.0"
            };
            kalsiliticAndMeliliticRocks = 
                new LithologyType("kalsilitic and melilitic rocks")
                {
                    Description = "Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            komatiiticRock = 
                new LithologyType("komatiitic rock")
                {
                    Description = "Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            latiticRock = 
                new LithologyType("latitic rock")
                {
                    Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            lignite = 
                new LithologyType("lignite")
                {
                    Description = "Coal that has a gross calorific value less than 24 MJ/kg (determined in conformance with ISO 1928), and vitrinite mean random reflectance less than 0.6 percent (determined in conformance with ISO 7404-5). Gross calorific value is recalculated to a moist, ash free basis using bed moisture (determined according to ISO 1015 or ISO 5068). Includes all low-rank coals, including sub-bitiminous coal. A consolidated, dull, soft brown to black coal having many readily discernible plant fragments set in a finer grained organic matrix. Tends to crack and fall apart on drying. Operationally sub-bituminous and bitiminous coal are qualitatively distinguished based on brown streak for sub-bitiminous coal and black streak for bituminous coal. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp."
                    ,Version = "1.4.1.0"
            };
            limeBoundstone = 
                new LithologyType("lime boundstone")
                {
                    Description = "Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limeFramestone = 
                new LithologyType("lime framestone")
                {
                    Description = "Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth & Knox 1999; SLTTs 2004, Table 15-3-1"
                    ,Version = "1.4.1.0"
            };
            limeGrainstone = 
                new LithologyType("lime grainstone")
                {
                    Description = "Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limeMudstone = 
                new LithologyType("lime mudstone")
                {
                    Description = "Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary."
                    ,Version = "1.4.1.0"
            };
            limePackstone = 
                new LithologyType("lime packstone")
                {
                    Description = "Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limeWackestone = 
                new LithologyType("lime wackestone")
                {
                    Description = "Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limestone = 
                new LithologyType("limestone")
                {
                    Description = "Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology."
                    ,Version = "1.4.1.0"
            };
            limestoneArgillaceous = 
                new LithologyType("limestone, argillaceous")
                {
                    Description = "A limestone homogeneously mixed with 10-50% clay minerals."
                    ,Version = "1.3.1.1"
            };
            limestoneDolomitic = 
                new LithologyType("limestone, dolomitic")
                {
                    Description = "A limestone containing 10-50% dolomite and 50-90% calcite."
                    ,Version = "1.3.1.1"
            };
            limestoneSandy = 
                new LithologyType("limestone, sandy")
                {
                    Description = "A limestone homogeneously mixed with 10-50% quartz grains."
                    ,Version = "1.3.1.1"
            };
            marble = 
                new LithologyType("marble")
                {
                    Description = "Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007"
                    ,Version = "1.4.1.0"
            };
            marl = 
                new LithologyType("marl")
                {
                    Description = "A consolidated or semi-consolidated mixture of clay and generally fine grained carbonate material."
                    ,Version = "1.3.1.1"
            };
            metamorphicRock = 
                new LithologyType("metamorphic rock")
                {
                    Description = "Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997."
                    ,Version = "1.4.1.0"
            };
            metamorphicRocks = 
                new LithologyType("metamorphic rocks")
                {
                    Description = "DEPRECATED. See \"metamorphic rock\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = MetamorphicRock
            };
            micaSchist = 
                new LithologyType("mica schist")
                {
                    Description = "A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology."
                    ,Version = "1.4.1.0"
            };
            migmatite = 
                new LithologyType("migmatite")
                {
                    Description = "Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)"
                    ,Version = "1.4.1.0"
            };
            monzogabbro = 
                new LithologyType("monzogabbro")
                {
                    Description = "Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            mud = 
                new LithologyType("mud")
                {
                    Description = "Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.)."
                    ,Version = "1.4.1.0"
            };
            mudstone = 
                new LithologyType("mudstone")
                {
                    Description = "Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth & Knox 1999; extrapolated from Folk, 1954, Figure 1a."
                    ,Version = "1.4.1.0"
            };
            myloniticRock = 
                new LithologyType("mylonitic rock")
                {
                    Description = "Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak & Mitra 1988."
                    ,Version = "1.4.1.0"
            };
            noDescription = 
                new LithologyType("no description")
                {
                    Description = "No description is provided."
                    ,Version = "1.3.1.1"
            };
            noSample = 
                new LithologyType("no sample")
                {
                    Description = "A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML."
                    ,Version = "1.4.1.0"
            };
            ooze = 
                new LithologyType("ooze")
                {
                    Description = "Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 & Hallsworth & Knox 1999."
                    ,Version = "1.4.1.0"
            };
            ophiolite = 
                new LithologyType("ophiolite")
                {
                    Description = "Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust."
                    ,Version = "1.3.1.1"
            };
            organicBearingMudstone = 
                new LithologyType("organic bearing mudstone")
                {
                    Description = "Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;"
                    ,Version = "1.4.1.0"
            };
            peat = 
                new LithologyType("peat")
                {
                    Description = "Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth & Knox 1999."
                    ,Version = "1.4.1.0"
            };
            pegmatite = 
                new LithologyType("pegmatite")
                {
                    Description = "Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            peridotite = 
                new LithologyType("peridotite")
                {
                    Description = "Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            phaneriticIgneousRock = 
                new LithologyType("phaneritic igneous rock")
                {
                    Description = "Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            phonolite = 
                new LithologyType("phonolite")
                {
                    Description = "Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            phonolitoid = 
                new LithologyType("phonolitoid")
                {
                    Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            phosphate = 
                new LithologyType("phosphate")
                {
                    Description = "Any mineral compound containing the ((PO4)3) radical."
                    ,Version = "1.3.1.1"
            };
            phosphateRock = 
                new LithologyType("phosphate rock")
                {
                    Description = "Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource."
                    ,Version = "1.3.1.1"
            };
            phyllite = 
                new LithologyType("phyllite")
                {
                    Description = "Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007."
                    ,Version = "1.4.1.0"
            };
            porphyry = 
                new LithologyType("porphyry")
                {
                    Description = "Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            potassiumAndMagnesiumSalts = 
                new LithologyType("potassium and magnesium salts")
                {
                    Description = "Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML."
                    ,Version = "1.4.1.0"
            };
            pyroclasticBreccia = 
                new LithologyType("pyroclastic breccia")
                {
                    Description = "Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            pyroclasticRock = 
                new LithologyType("pyroclastic rock")
                {
                    Description = "Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            pyroxenite = 
                new LithologyType("pyroxenite")
                {
                    Description = "Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            quartzArenite = 
                new LithologyType("quartz arenite")
                {
                    Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632."
                    ,Version = "1.4.1.0"
            };
            quartzite = 
                new LithologyType("quartzite")
                {
                    Description = "Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            rhyolite = 
                new LithologyType("rhyolite")
                {
                    Description = "rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            rockSalt = 
                new LithologyType("rock salt")
                {
                    Description = "Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology."
                    ,Version = "1.4.1.0"
            };
            salt = 
                new LithologyType("salt")
                {
                    Description = "DEPRECATED. See \"rock salt\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = RockSalt
            };
            sand = 
                new LithologyType("sand")
                {
                    Description = "Clastic sediment in which less than 30 percent of particles are gravel (greater than 2 millimeter in diameter) and the sand to mud ratio is at least 1. More than half of the particles are of epiclastic origin.definition of sand from SLTTs 2004 sandy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.)."
                    ,Version = "1.4.1.0"
            };
            sandstone = 
                new LithologyType("sandstone")
                {
                    Description = "Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale."
                    ,Version = "1.4.1.0"
            };
            sapropel = 
                new LithologyType("sapropel")
                {
                    Description = "Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            schist = 
                new LithologyType("schist")
                {
                    Description = "Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            serpentine = 
                new LithologyType("serpentine")
                {
                    Description = "DEPRECATED. See \"serpentinite\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = Serpentinite
            };
            serpentinite = 
                new LithologyType("serpentinite")
                {
                    Description = "Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            shale = 
                new LithologyType("shale")
                {
                    Description = "Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically."
                    ,Version = "1.4.1.0"
            };
            siliceousOoze = 
                new LithologyType("siliceous ooze")
                {
                    Description = "Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology."
                    ,Version = "1.4.1.0"
            };
            silt = 
                new LithologyType("silt")
                {
                    Description = "Mud that consists of greater than 50 percent silt-size grains. Based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale."
                    ,Version = "1.4.1.0"
            };
            siltstone = 
                new LithologyType("siltstone")
                {
                    Description = "Mudstone that contains detectable silt. OneGeology."
                    ,Version = "1.4.1.0"
            };
            skarn = 
                new LithologyType("skarn")
                {
                    Description = "Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195."
                    ,Version = "1.4.1.0"
            };
            slate = 
                new LithologyType("slate")
                {
                    Description = "Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            spilite = 
                new LithologyType("spilite")
                {
                    Description = "Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619."
                    ,Version = "1.4.1.0"
            };
            syenite = 
                new LithologyType("syenite")
                {
                    Description = "Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz."
                    ,Version = "1.3.1.1"
            };
            syenitoid = 
                new LithologyType("syenitoid")
                {
                    Description = "Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            sylvite = 
                new LithologyType("sylvite")
                {
                    Description = "Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology."
                    ,Version = "1.4.1.0"
            };
            tephrite = 
                new LithologyType("tephrite")
                {
                    Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            tephritoid = 
                new LithologyType("tephritoid")
                {
                    Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            tholeiiticBasalt = 
                new LithologyType("tholeiitic basalt")
                {
                    Description = "Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43."
                    ,Version = "1.4.1.0"
            };
            tilliteDiamictite = 
                new LithologyType("tillite (diamictite)")
                {
                    Description = "DEPRECATED. See \"diamictite\"."
                    ,Version = "1.3.1.1"
                    ,Deprecated = "1.4.1.0"
                    ,ReplacedBy = Diamictite
            };
            tonalite = 
                new LithologyType("tonalite")
                {
                    Description = "Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            trachyte = 
                new LithologyType("trachyte")
                {
                    Description = "A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals."
                    ,Version = "1.3.1.1"
            };
            trachyticRock = 
                new LithologyType("trachytic rock")
                {
                    Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            trachytoid = 
                new LithologyType("trachytoid")
                {
                    Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            travertine = 
                new LithologyType("travertine")
                {
                    Description = "Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74."
                    ,Version = "1.4.1.0"
            };
            tuff = 
                new LithologyType("tuff")
                {
                    Description = "Ash tuff, lapillistone, and lapilli tuff. Pyroclastic rock in which less than 25 percent of rock by volume are more than 64 millimeter in longest diameter. Includes tuff, lapilli tuff, and lapillistone. Schmid 1981; LeMaitre et al. 2002. Modified by WITSML to just use the term Tuff."
                    ,Version = "1.4.1.0"
            };
            tuffite = 
                new LithologyType("tuffite")
                {
                    Description = "Rock consists of more than 50 percent particles of indeterminate pyroclastic or epiclastic origin and less than 75 percent particles of clearly pyroclastic origin. Commonly the rock is laminated or exhibits size grading. (based on LeMaitre et al. 2002; Murawski and Meyer 1998)."
                    ,Version = "1.4.1.0"
            };
            ultrabasic = 
                new LithologyType("ultrabasic")
                {
                    Description = "A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%."
                    ,Version = "1.3.1.1"
            };
            undifferentiated = 
                new LithologyType("undifferentiated")
                {
                    Description = "The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent."
                    ,Version = "1.3.1.1"
            };
            wacke = 
                new LithologyType("wacke")
                {
                    Description = "Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p."
                    ,Version = "1.4.1.0"
            };
            unknown = 
                new LithologyType("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
                    ,Version = "1.3.1.1"
            };
        }

        /// <summary>
        /// Gets a LithologyType by name
        /// </summary>
        /// <param name="name">The name of the LithologyType to return</param>
        /// <returns>The LithologyType represented by 'name'</returns>
        public static LithologyType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(LithologyType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(LithologyType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (LithologyType)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Lithology matrix/cement description.
    /// </summary>
    public class MatrixCementType : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected MatrixCementType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the MatrixCementType</param>
        public MatrixCementType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of MatrixCementTypes
        /// </summary>
        /// <returns>The complete list of MatrixCementTypes</returns>
        public static List<MatrixCementType> GetList()
        {
            return GetList<MatrixCementType>();
        }

        private readonly static MatrixCementType ankerite;
        /// <summary>
        /// A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),
        /// </summary>
        [EnumValueNameAttribute("ankerite")]
        public static MatrixCementType Ankerite
        {
            get 
            {
                return ankerite;
            }
        }

        private readonly static MatrixCementType calcite;
        /// <summary>
        /// A matrix cement dominantly composed of Calcite, the most stable polymorph of calcium carbonate (CaCO3), and readily identifiable at the wellsite due to its reaction with dilute hydrochloric acid. The most common matrix cement.
        /// </summary>
        [EnumValueNameAttribute("calcite")]
        public static MatrixCementType Calcite
        {
            get 
            {
                return calcite;
            }
        }

        private readonly static MatrixCementType chlorite;
        /// <summary>
        /// A matrix cement dominantly composed of Chlorite. It is a low grade metamorphic cement. The typical general formula is: (Mg,Fe)3(Si,Al)4O10(OH)2Â·(Mg,Fe)3(OH)6.Seen in Algerian gas fields such as Teg.
        /// </summary>
        [EnumValueNameAttribute("chlorite")]
        public static MatrixCementType Chlorite
        {
            get 
            {
                return chlorite;
            }
        }

        private readonly static MatrixCementType dolomite;
        /// <summary>
        /// A matrix cement dominantly composed of dolomite.Dolomite cement is composed predominantly of the mineral dolomite with a stoichiometric ratio of 50% or greater content of magnesium replacing calcium, often as a result of diagenesis .
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static MatrixCementType Dolomite
        {
            get 
            {
                return dolomite;
            }
        }

        private readonly static MatrixCementType illite;
        /// <summary>
        /// A matrix cement dominantly composed of Illite. Illite is a clay sized micaceous mineral. The chemical formula is given as (K,H3O)(Al,Mg,Fe)2(Si,Al)4O10[(OH)2,(H2O)],[2] but there is considerable ion substitution. Seen in Southern North Sea gas fields such as the "Village" fields area.
        /// </summary>
        [EnumValueNameAttribute("illite")]
        public static MatrixCementType Illite
        {
            get 
            {
                return illite;
            }
        }

        private readonly static MatrixCementType kaolinite;
        /// <summary>
        /// A matrix cement dominantly composed of Kaolinite. A matrix cement with the chemical composition Al2Si2O5(OH)4. It is a soft, earthy, usually white mineral (dioctahedral phyllosilicate clay), produced by the chemical weathering of aluminium silicate minerals like feldspar.
        /// </summary>
        [EnumValueNameAttribute("kaolinite")]
        public static MatrixCementType Kaolinite
        {
            get 
            {
                return kaolinite;
            }
        }

        private readonly static MatrixCementType quartz;
        /// <summary>
        /// A matrix cement dominantly composed of Quartz, either from pressure solution grain to grain contact cementation or secondary quartz deposition. Fairly common.
        /// </summary>
        [EnumValueNameAttribute("quartz")]
        public static MatrixCementType Quartz
        {
            get 
            {
                return quartz;
            }
        }

        private readonly static MatrixCementType siderite;
        /// <summary>
        /// A matrix cement dominantly composed of Siderite. Siderite is composed of iron carbonate FeCO3. ( Sherwood sandstones, in the southern UK typical include Siderite cements)
        /// </summary>
        [EnumValueNameAttribute("siderite")]
        public static MatrixCementType Siderite
        {
            get 
            {
                return siderite;
            }
        }

        private readonly static MatrixCementType smectite;
        /// <summary>
        /// A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples.
        /// </summary>
        [EnumValueNameAttribute("smectite")]
        public static MatrixCementType Smectite
        {
            get 
            {
                return smectite;
            }
        }

        private readonly static MatrixCementType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static MatrixCementType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static MatrixCementType()
        {
            ankerite = 
                new MatrixCementType("ankerite")
                {
                    Description = "A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),"
                    ,Version = "1.4.1.0"
            };
            calcite = 
                new MatrixCementType("calcite")
                {
                    Description = "A matrix cement dominantly composed of Calcite, the most stable polymorph of calcium carbonate (CaCO3), and readily identifiable at the wellsite due to its reaction with dilute hydrochloric acid. The most common matrix cement."
                    ,Version = "1.4.1.0"
            };
            chlorite = 
                new MatrixCementType("chlorite")
                {
                    Description = "A matrix cement dominantly composed of Chlorite. It is a low grade metamorphic cement. The typical general formula is: (Mg,Fe)3(Si,Al)4O10(OH)2Â·(Mg,Fe)3(OH)6.Seen in Algerian gas fields such as Teg."
                    ,Version = "1.4.1.0"
            };
            dolomite = 
                new MatrixCementType("dolomite")
                {
                    Description = "A matrix cement dominantly composed of dolomite.Dolomite cement is composed predominantly of the mineral dolomite with a stoichiometric ratio of 50% or greater content of magnesium replacing calcium, often as a result of diagenesis ."
                    ,Version = "1.4.1.0"
            };
            illite = 
                new MatrixCementType("illite")
                {
                    Description = "A matrix cement dominantly composed of Illite. Illite is a clay sized micaceous mineral. The chemical formula is given as (K,H3O)(Al,Mg,Fe)2(Si,Al)4O10[(OH)2,(H2O)],[2] but there is considerable ion substitution. Seen in Southern North Sea gas fields such as the \"Village\" fields area."
                    ,Version = "1.4.1.0"
            };
            kaolinite = 
                new MatrixCementType("kaolinite")
                {
                    Description = "A matrix cement dominantly composed of Kaolinite. A matrix cement with the chemical composition Al2Si2O5(OH)4. It is a soft, earthy, usually white mineral (dioctahedral phyllosilicate clay), produced by the chemical weathering of aluminium silicate minerals like feldspar."
                    ,Version = "1.4.1.0"
            };
            quartz = 
                new MatrixCementType("quartz")
                {
                    Description = "A matrix cement dominantly composed of Quartz, either from pressure solution grain to grain contact cementation or secondary quartz deposition. Fairly common."
                    ,Version = "1.4.1.0"
            };
            siderite = 
                new MatrixCementType("siderite")
                {
                    Description = "A matrix cement dominantly composed of Siderite. Siderite is composed of iron carbonate FeCO3. ( Sherwood sandstones, in the southern UK typical include Siderite cements)"
                    ,Version = "1.4.1.0"
            };
            smectite = 
                new MatrixCementType("smectite")
                {
                    Description = "A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples."
                    ,Version = "1.4.1.0"
            };
            unknown = 
                new MatrixCementType("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
                    ,Version = "1.4.1.0"
            };
        }

        /// <summary>
        /// Gets a MatrixCementType by name
        /// </summary>
        /// <param name="name">The name of the MatrixCementType to return</param>
        /// <returns>The MatrixCementType represented by 'name'</returns>
        public static MatrixCementType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(MatrixCementType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(MatrixCementType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (MatrixCementType)ev;
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
    /// Mud Subtype at event occurrence.
    /// </summary>
    public class MudSubClass : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected MudSubClass(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the MudSubClass</param>
        public MudSubClass(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of MudSubClasss
        /// </summary>
        /// <returns>The complete list of MudSubClasss</returns>
        public static List<MudSubClass> GetList()
        {
            return GetList<MudSubClass>();
        }

        private readonly static MudSubClass waterbasedDrillingFluids;
        /// <summary>
        /// A drilling fluid in which water or saltwater is the major liquid phase as well as the wetting (external) phase.
        /// </summary>
        [EnumValueNameAttribute("water-based drilling fluids")]
        public static MudSubClass WaterbasedDrillingFluids
        {
            get 
            {
                return waterbasedDrillingFluids;
            }
        }

        private readonly static MudSubClass freshwater;
        /// <summary>
        /// Water with no to very low salinity used as drilling fluid or a base fluid for making WBM.
        /// </summary>
        [EnumValueNameAttribute("freshwater")]
        public static MudSubClass Freshwater
        {
            get 
            {
                return freshwater;
            }
        }

        private readonly static MudSubClass brackishWater;
        /// <summary>
        /// Water with higher salinity than fresh water, but less than sea water.
        /// </summary>
        [EnumValueNameAttribute("brackish water")]
        public static MudSubClass BrackishWater
        {
            get 
            {
                return brackishWater;
            }
        }

        private readonly static MudSubClass seaWater;
        /// <summary>
        /// Offshore locations may use sea water as a base fluid for WBM. It is denser than fresh water and has higher salinity.
        /// </summary>
        [EnumValueNameAttribute("sea water")]
        public static MudSubClass SeaWater
        {
            get 
            {
                return seaWater;
            }
        }

        private readonly static MudSubClass brine;
        /// <summary>
        /// A solution of a salt (organic or inorganic) in water with a wide density range depending on salt type and concentration.
        /// </summary>
        [EnumValueNameAttribute("brine")]
        public static MudSubClass Brine
        {
            get 
            {
                return brine;
            }
        }

        private readonly static MudSubClass caesiumFormate;
        /// <summary>
        /// A chloride-free colorless 18.34 ppg brine that can be blended with potassium formate for lower densities. 
        /// </summary>
        [EnumValueNameAttribute("caesium formate")]
        public static MudSubClass CaesiumFormate
        {
            get 
            {
                return caesiumFormate;
            }
        }

        private readonly static MudSubClass potassiumFormate;
        /// <summary>
        /// A single-salt clear (chloride-free) brine fluid. Pure potassium formate solutions can be prepared with densities between 8.4 ppg and 13.1 ppg.
        /// </summary>
        [EnumValueNameAttribute("potassium formate")]
        public static MudSubClass PotassiumFormate
        {
            get 
            {
                return potassiumFormate;
            }
        }

        private readonly static MudSubClass sodiumFormate;
        /// <summary>
        /// A single-salt used clear (chloride-free) brine fluid. Densities range from 8.4 ppg to 11.0 ppg.
        /// </summary>
        [EnumValueNameAttribute("sodium formate")]
        public static MudSubClass SodiumFormate
        {
            get 
            {
                return sodiumFormate;
            }
        }

        private readonly static MudSubClass lignitelignosulfonateMud;
        /// <summary>
        /// Lignite and/or lignosulfonate added to water-based mud to reduce viscosity and gel strengths.
        /// </summary>
        [EnumValueNameAttribute("lignite/lignosulfonate mud")]
        public static MudSubClass LignitelignosulfonateMud
        {
            get 
            {
                return lignitelignosulfonateMud;
            }
        }

        private readonly static MudSubClass limeMud;
        /// <summary>
        /// A type of water-based mud that is saturated with lime-Ca(OH)2-and has excess, undissolved lime solids maintained in reserve.
        /// </summary>
        [EnumValueNameAttribute("lime mud")]
        public static MudSubClass LimeMud
        {
            get 
            {
                return limeMud;
            }
        }

        private readonly static MudSubClass gypMud;
        /// <summary>
        /// A calcium-based water mud system containing gysum.
        /// </summary>
        [EnumValueNameAttribute("gyp mud")]
        public static MudSubClass GypMud
        {
            get 
            {
                return gypMud;
            }
        }

        private readonly static MudSubClass potassiumtreatedMud;
        /// <summary>
        /// A class of muds that contain potassium ion (K+) dissolved in the water phase for shale inhibition.
        /// </summary>
        [EnumValueNameAttribute("potassium-treated mud")]
        public static MudSubClass PotassiumtreatedMud
        {
            get 
            {
                return potassiumtreatedMud;
            }
        }

        private readonly static MudSubClass saltWaterMud;
        /// <summary>
        /// A water mud containing varying amounts of dissolved salts as a major component for density and inhibition.
        /// </summary>
        [EnumValueNameAttribute("salt water mud")]
        public static MudSubClass SaltWaterMud
        {
            get 
            {
                return saltWaterMud;
            }
        }

        private readonly static MudSubClass saturatedSaltMud;
        /// <summary>
        /// A water mud that contains salt up to the saturation point for a certain salt. Saturated saltwater systems are designed to prevent the enlargement of the wellbore while drilling salt sections.
        /// </summary>
        [EnumValueNameAttribute("saturated salt mud")]
        public static MudSubClass SaturatedSaltMud
        {
            get 
            {
                return saturatedSaltMud;
            }
        }

        private readonly static MudSubClass seawaterMud;
        /// <summary>
        /// A special class of saltwater muds where seawater is used as the fluid phase. 
        /// </summary>
        [EnumValueNameAttribute("seawater mud")]
        public static MudSubClass SeawaterMud
        {
            get 
            {
                return seawaterMud;
            }
        }

        private readonly static MudSubClass spudMud;
        /// <summary>
        /// A fluid used when drilling starts at the surface, often a thick bentonite/lime slurry.
        /// </summary>
        [EnumValueNameAttribute("spud mud")]
        public static MudSubClass SpudMud
        {
            get 
            {
                return spudMud;
            }
        }

        private readonly static MudSubClass nativenaturalMud;
        /// <summary>
        /// A water-based fluid that incorporates drilled native solids/clays to maintain its rheological properties.
        /// </summary>
        [EnumValueNameAttribute("native/natural mud")]
        public static MudSubClass NativenaturalMud
        {
            get 
            {
                return nativenaturalMud;
            }
        }

        private readonly static MudSubClass lowSolidsNondispersed;
        /// <summary>
        /// A water-based mud containing low solids (HGS or LGS) with no dispersants or thinners.
        /// </summary>
        [EnumValueNameAttribute("low solids, non-dispersed")]
        public static MudSubClass LowSolidsNondispersed
        {
            get 
            {
                return lowSolidsNondispersed;
            }
        }

        private readonly static MudSubClass lightlyTreatedNondispersed;
        /// <summary>
        /// A water-based mud containing low polymer concentrations and no dispersants.
        /// </summary>
        [EnumValueNameAttribute("lightly treated non-dispersed")]
        public static MudSubClass LightlyTreatedNondispersed
        {
            get 
            {
                return lightlyTreatedNondispersed;
            }
        }

        private readonly static MudSubClass polymerMud;
        /// <summary>
        /// A water-based mud that uses polymers for rheological properties, filtration and sometimes encapsulation 
        /// </summary>
        [EnumValueNameAttribute("polymer mud")]
        public static MudSubClass PolymerMud
        {
            get 
            {
                return polymerMud;
            }
        }

        private readonly static MudSubClass silicateMud;
        /// <summary>
        /// A type of shale-inhibitive water base drilling fluid that contains sodium silicate or potassium silicate polymeric ions.
        /// </summary>
        [EnumValueNameAttribute("silicate mud")]
        public static MudSubClass SilicateMud
        {
            get 
            {
                return silicateMud;
            }
        }

        private readonly static MudSubClass glycolMud;
        /// <summary>
        /// A water-based mud containing one or more of the glycol compounds for inhibition and sometimes hydrates suppression.
        /// </summary>
        [EnumValueNameAttribute("glycol mud")]
        public static MudSubClass GlycolMud
        {
            get 
            {
                return glycolMud;
            }
        }

        private readonly static MudSubClass mixedmetalOxideMud;
        /// <summary>
        /// A low-solids, flocculated, cationic drilling fluid system which provides excellent hole-cleaning and solids-suspension characteristics.
        /// </summary>
        [EnumValueNameAttribute("mixed-metal oxide mud")]
        public static MudSubClass MixedmetalOxideMud
        {
            get 
            {
                return mixedmetalOxideMud;
            }
        }

        private readonly static MudSubClass nonaqueousInvertEmulsionDrillingFluids;
        /// <summary>
        /// An invert-emulsion mud or an emulsion with an Diesel, Mineral oil or a Synthetic base fluid as the continuous phase
        /// </summary>
        [EnumValueNameAttribute("non-aqueous (invert emulsion) drilling fluids")]
        public static MudSubClass NonaqueousInvertEmulsionDrillingFluids
        {
            get 
            {
                return nonaqueousInvertEmulsionDrillingFluids;
            }
        }

        private readonly static MudSubClass dieselOilbased;
        /// <summary>
        /// A non-aqueous fluid that uses #2-grade diesel most of the time as the continuous phase. 
        /// </summary>
        [EnumValueNameAttribute("diesel oil-based")]
        public static MudSubClass DieselOilbased
        {
            get 
            {
                return dieselOilbased;
            }
        }

        private readonly static MudSubClass mineralOilbased;
        /// <summary>
        /// A non-aqueous fluid that uses a refined base oil with a much lower aromatic content than diesel.
        /// </summary>
        [EnumValueNameAttribute("mineral oil-based")]
        public static MudSubClass MineralOilbased
        {
            get 
            {
                return mineralOilbased;
            }
        }

        private readonly static MudSubClass lowToxicityMineralOilbased;
        /// <summary>
        /// A non-aqueous fluid that uses a highly purified material having lower Polycyclic Aromatic Hydrocarbon content.
        /// </summary>
        [EnumValueNameAttribute("low toxicity mineral oil-based")]
        public static MudSubClass LowToxicityMineralOilbased
        {
            get 
            {
                return lowToxicityMineralOilbased;
            }
        }

        private readonly static MudSubClass internalolefinSyntheticbased;
        /// <summary>
        /// A synthetic-based drilling fluid with a base fluid that only contains carbon and hydrogen. It is formed by isomerizing Linear-Alpha-Olefins. 
        /// </summary>
        [EnumValueNameAttribute("internal-olefin synthetic-based")]
        public static MudSubClass InternalolefinSyntheticbased
        {
            get 
            {
                return internalolefinSyntheticbased;
            }
        }

        private readonly static MudSubClass linearalphaolefinSyntheticbased;
        /// <summary>
        /// A synthetic-based drilling fluid where the base fluid only contains carbon and hydrogen where monomers are oligomerized to form that linear chain. 
        /// </summary>
        [EnumValueNameAttribute("linear-alpha-olefin synthetic-based")]
        public static MudSubClass LinearalphaolefinSyntheticbased
        {
            get 
            {
                return linearalphaolefinSyntheticbased;
            }
        }

        private readonly static MudSubClass linearParaffinSyntheticbased;
        /// <summary>
        /// A synthetic-based drilling fluid where the base fluid only contains carbon and hydrogen. It is formed by either a purely synthetic route or by a multi-step refinery process that includes hydrocracking and the use of molecular-sieve separation.
        /// </summary>
        [EnumValueNameAttribute("linear paraffin synthetic-based")]
        public static MudSubClass LinearParaffinSyntheticbased
        {
            get 
            {
                return linearParaffinSyntheticbased;
            }
        }

        private readonly static MudSubClass esterSyntheticbased;
        /// <summary>
        /// A synthetic based fluid with a base fluid that contains oxygen in its structure characterized by a fast biodegradation compared to other synthetic-based fluids. 
        /// </summary>
        [EnumValueNameAttribute("ester synthetic-based")]
        public static MudSubClass EsterSyntheticbased
        {
            get 
            {
                return esterSyntheticbased;
            }
        }

        private readonly static MudSubClass pneumaticGaseousDrillingFluids;
        /// <summary>
        /// Pneumatic drilling fluids are a mix of compressed air, gas or nitrogen, water and chemicals to achieve certain properties
        /// </summary>
        [EnumValueNameAttribute("pneumatic (gaseous) drilling fluids")]
        public static MudSubClass PneumaticGaseousDrillingFluids
        {
            get 
            {
                return pneumaticGaseousDrillingFluids;
            }
        }

        private readonly static MudSubClass air;
        /// <summary>
        /// Atmospheric air compressed and pumped by itself or injected as part of a fluid.
        /// </summary>
        [EnumValueNameAttribute("air")]
        public static MudSubClass Air
        {
            get 
            {
                return air;
            }
        }

        private readonly static MudSubClass mist;
        /// <summary>
        /// Air combined with a small amount of surfactant (soap) and water mixture to create a mist.
        /// </summary>
        [EnumValueNameAttribute("mist")]
        public static MudSubClass Mist
        {
            get 
            {
                return mist;
            }
        }

        private readonly static MudSubClass stiffFoam;
        /// <summary>
        /// A mixture of compressed air, viscosified water and a surfactant foaming agent.
        /// </summary>
        [EnumValueNameAttribute("stiff foam")]
        public static MudSubClass StiffFoam
        {
            get 
            {
                return stiffFoam;
            }
        }

        private readonly static MudSubClass stableFoam;
        /// <summary>
        /// A mixture of compressed air, water and a surfactant foaming agent
        /// </summary>
        [EnumValueNameAttribute("stable foam")]
        public static MudSubClass StableFoam
        {
            get 
            {
                return stableFoam;
            }
        }

        private readonly static MudSubClass naturalGas;
        /// <summary>
        /// Compressed naturally occurring hydrocarbon gas
        /// </summary>
        [EnumValueNameAttribute("natural gas")]
        public static MudSubClass NaturalGas
        {
            get 
            {
                return naturalGas;
            }
        }

        private readonly static MudSubClass aeratedMud;
        /// <summary>
        /// Compressed air or gas injected into water to reduce the mud weight
        /// </summary>
        [EnumValueNameAttribute("aerated mud")]
        public static MudSubClass AeratedMud
        {
            get 
            {
                return aeratedMud;
            }
        }

        private readonly static MudSubClass nitrogenaeratedMud;
        /// <summary>
        /// Compressed air with 95% nitrogen to reduce the risk of downhole fire
        /// </summary>
        [EnumValueNameAttribute("nitrogen-aerated mud")]
        public static MudSubClass NitrogenaeratedMud
        {
            get 
            {
                return nitrogenaeratedMud;
            }
        }

        static MudSubClass()
        {
            waterbasedDrillingFluids = 
                new MudSubClass("water-based drilling fluids")
                {
                    Description = "A drilling fluid in which water or saltwater is the major liquid phase as well as the wetting (external) phase."
                    ,Version = "1.4.1.1"
            };
            freshwater = 
                new MudSubClass("freshwater")
                {
                    Description = "Water with no to very low salinity used as drilling fluid or a base fluid for making WBM."
                    ,Version = "1.4.1.1"
            };
            brackishWater = 
                new MudSubClass("brackish water")
                {
                    Description = "Water with higher salinity than fresh water, but less than sea water."
                    ,Version = "1.4.1.1"
            };
            seaWater = 
                new MudSubClass("sea water")
                {
                    Description = "Offshore locations may use sea water as a base fluid for WBM. It is denser than fresh water and has higher salinity."
                    ,Version = "1.4.1.1"
            };
            brine = 
                new MudSubClass("brine")
                {
                    Description = "A solution of a salt (organic or inorganic) in water with a wide density range depending on salt type and concentration."
                    ,Version = "1.4.1.1"
            };
            caesiumFormate = 
                new MudSubClass("caesium formate")
                {
                    Description = "A chloride-free colorless 18.34 ppg brine that can be blended with potassium formate for lower densities. "
                    ,Version = "1.4.1.1"
            };
            potassiumFormate = 
                new MudSubClass("potassium formate")
                {
                    Description = "A single-salt clear (chloride-free) brine fluid. Pure potassium formate solutions can be prepared with densities between 8.4 ppg and 13.1 ppg."
                    ,Version = "1.4.1.1"
            };
            sodiumFormate = 
                new MudSubClass("sodium formate")
                {
                    Description = "A single-salt used clear (chloride-free) brine fluid. Densities range from 8.4 ppg to 11.0 ppg."
                    ,Version = "1.4.1.1"
            };
            lignitelignosulfonateMud = 
                new MudSubClass("lignite/lignosulfonate mud")
                {
                    Description = "Lignite and/or lignosulfonate added to water-based mud to reduce viscosity and gel strengths."
                    ,Version = "1.4.1.1"
            };
            limeMud = 
                new MudSubClass("lime mud")
                {
                    Description = "A type of water-based mud that is saturated with lime-Ca(OH)2-and has excess, undissolved lime solids maintained in reserve."
                    ,Version = "1.4.1.1"
            };
            gypMud = 
                new MudSubClass("gyp mud")
                {
                    Description = "A calcium-based water mud system containing gysum."
                    ,Version = "1.4.1.1"
            };
            potassiumtreatedMud = 
                new MudSubClass("potassium-treated mud")
                {
                    Description = "A class of muds that contain potassium ion (K+) dissolved in the water phase for shale inhibition."
                    ,Version = "1.4.1.1"
            };
            saltWaterMud = 
                new MudSubClass("salt water mud")
                {
                    Description = "A water mud containing varying amounts of dissolved salts as a major component for density and inhibition."
                    ,Version = "1.4.1.1"
            };
            saturatedSaltMud = 
                new MudSubClass("saturated salt mud")
                {
                    Description = "A water mud that contains salt up to the saturation point for a certain salt. Saturated saltwater systems are designed to prevent the enlargement of the wellbore while drilling salt sections."
                    ,Version = "1.4.1.1"
            };
            seawaterMud = 
                new MudSubClass("seawater mud")
                {
                    Description = "A special class of saltwater muds where seawater is used as the fluid phase. "
                    ,Version = "1.4.1.1"
            };
            spudMud = 
                new MudSubClass("spud mud")
                {
                    Description = "A fluid used when drilling starts at the surface, often a thick bentonite/lime slurry."
                    ,Version = "1.4.1.1"
            };
            nativenaturalMud = 
                new MudSubClass("native/natural mud")
                {
                    Description = "A water-based fluid that incorporates drilled native solids/clays to maintain its rheological properties."
                    ,Version = "1.4.1.1"
            };
            lowSolidsNondispersed = 
                new MudSubClass("low solids, non-dispersed")
                {
                    Description = "A water-based mud containing low solids (HGS or LGS) with no dispersants or thinners."
                    ,Version = "1.4.1.1"
            };
            lightlyTreatedNondispersed = 
                new MudSubClass("lightly treated non-dispersed")
                {
                    Description = "A water-based mud containing low polymer concentrations and no dispersants."
                    ,Version = "1.4.1.1"
            };
            polymerMud = 
                new MudSubClass("polymer mud")
                {
                    Description = "A water-based mud that uses polymers for rheological properties, filtration and sometimes encapsulation "
                    ,Version = "1.4.1.1"
            };
            silicateMud = 
                new MudSubClass("silicate mud")
                {
                    Description = "A type of shale-inhibitive water base drilling fluid that contains sodium silicate or potassium silicate polymeric ions."
                    ,Version = "1.4.1.1"
            };
            glycolMud = 
                new MudSubClass("glycol mud")
                {
                    Description = "A water-based mud containing one or more of the glycol compounds for inhibition and sometimes hydrates suppression."
                    ,Version = "1.4.1.1"
            };
            mixedmetalOxideMud = 
                new MudSubClass("mixed-metal oxide mud")
                {
                    Description = "A low-solids, flocculated, cationic drilling fluid system which provides excellent hole-cleaning and solids-suspension characteristics."
                    ,Version = "1.4.1.1"
            };
            nonaqueousInvertEmulsionDrillingFluids = 
                new MudSubClass("non-aqueous (invert emulsion) drilling fluids")
                {
                    Description = "An invert-emulsion mud or an emulsion with an Diesel, Mineral oil or a Synthetic base fluid as the continuous phase"
                    ,Version = "1.4.1.1"
            };
            dieselOilbased = 
                new MudSubClass("diesel oil-based")
                {
                    Description = "A non-aqueous fluid that uses #2-grade diesel most of the time as the continuous phase. "
                    ,Version = "1.4.1.1"
            };
            mineralOilbased = 
                new MudSubClass("mineral oil-based")
                {
                    Description = "A non-aqueous fluid that uses a refined base oil with a much lower aromatic content than diesel."
                    ,Version = "1.4.1.1"
            };
            lowToxicityMineralOilbased = 
                new MudSubClass("low toxicity mineral oil-based")
                {
                    Description = "A non-aqueous fluid that uses a highly purified material having lower Polycyclic Aromatic Hydrocarbon content."
                    ,Version = "1.4.1.1"
            };
            internalolefinSyntheticbased = 
                new MudSubClass("internal-olefin synthetic-based")
                {
                    Description = "A synthetic-based drilling fluid with a base fluid that only contains carbon and hydrogen. It is formed by isomerizing Linear-Alpha-Olefins. "
                    ,Version = "1.4.1.1"
            };
            linearalphaolefinSyntheticbased = 
                new MudSubClass("linear-alpha-olefin synthetic-based")
                {
                    Description = "A synthetic-based drilling fluid where the base fluid only contains carbon and hydrogen where monomers are oligomerized to form that linear chain. "
                    ,Version = "1.4.1.1"
            };
            linearParaffinSyntheticbased = 
                new MudSubClass("linear paraffin synthetic-based")
                {
                    Description = "A synthetic-based drilling fluid where the base fluid only contains carbon and hydrogen. It is formed by either a purely synthetic route or by a multi-step refinery process that includes hydrocracking and the use of molecular-sieve separation."
                    ,Version = "1.4.1.1"
            };
            esterSyntheticbased = 
                new MudSubClass("ester synthetic-based")
                {
                    Description = "A synthetic based fluid with a base fluid that contains oxygen in its structure characterized by a fast biodegradation compared to other synthetic-based fluids. "
                    ,Version = "1.4.1.1"
            };
            pneumaticGaseousDrillingFluids = 
                new MudSubClass("pneumatic (gaseous) drilling fluids")
                {
                    Description = "Pneumatic drilling fluids are a mix of compressed air, gas or nitrogen, water and chemicals to achieve certain properties"
                    ,Version = "1.4.1.1"
            };
            air = 
                new MudSubClass("air")
                {
                    Description = "Atmospheric air compressed and pumped by itself or injected as part of a fluid."
                    ,Version = "1.4.1.1"
            };
            mist = 
                new MudSubClass("mist")
                {
                    Description = "Air combined with a small amount of surfactant (soap) and water mixture to create a mist."
                    ,Version = "1.4.1.1"
            };
            stiffFoam = 
                new MudSubClass("stiff foam")
                {
                    Description = "A mixture of compressed air, viscosified water and a surfactant foaming agent."
                    ,Version = "1.4.1.1"
            };
            stableFoam = 
                new MudSubClass("stable foam")
                {
                    Description = "A mixture of compressed air, water and a surfactant foaming agent"
                    ,Version = "1.4.1.1"
            };
            naturalGas = 
                new MudSubClass("natural gas")
                {
                    Description = "Compressed naturally occurring hydrocarbon gas"
                    ,Version = "1.4.1.1"
            };
            aeratedMud = 
                new MudSubClass("aerated mud")
                {
                    Description = "Compressed air or gas injected into water to reduce the mud weight"
                    ,Version = "1.4.1.1"
            };
            nitrogenaeratedMud = 
                new MudSubClass("nitrogen-aerated mud")
                {
                    Description = "Compressed air with 95% nitrogen to reduce the risk of downhole fire"
                    ,Version = "1.4.1.1"
            };
        }

        /// <summary>
        /// Gets a MudSubClass by name
        /// </summary>
        /// <param name="name">The name of the MudSubClass to return</param>
        /// <returns>The MudSubClass represented by 'name'</returns>
        public static MudSubClass GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(MudSubClass)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(MudSubClass)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (MudSubClass)ev;
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

    /// <summary>
    /// Defines the kind of objectGroup.
    /// </summary>
    public class ObjectGroupKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ObjectGroupKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ObjectGroupKind</param>
        public ObjectGroupKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ObjectGroupKinds
        /// </summary>
        /// <returns>The complete list of ObjectGroupKinds</returns>
        public static List<ObjectGroupKind> GetList()
        {
            return GetList<ObjectGroupKind>();
        }

        private readonly static ObjectGroupKind drilling;
        /// <summary>
        /// Run of BHA tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the BHA run number. The sequence1 element represents the BHA pass number within the run. The range elements represent the portion of the wellbore traversed by the BHA for that run. 
        /// </summary>
        [EnumValueNameAttribute("drilling")]
        public static ObjectGroupKind Drilling
        {
            get 
            {
                return drilling;
            }
        }

        private readonly static ObjectGroupKind wireline;
        /// <summary>
        /// Run of wirelilne tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the wireline run (trip) number. The sequence1 element represents the pass number within the run. The range elements represent the portion of the wellbore traversed by the tool for that run. 
        /// </summary>
        [EnumValueNameAttribute("wireline")]
        public static ObjectGroupKind Wireline
        {
            get 
            {
                return wireline;
            }
        }

        private readonly static ObjectGroupKind pressureTest;
        /// <summary>
        /// Run of pressure test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the pressure test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. 
        /// </summary>
        [EnumValueNameAttribute("pressure test")]
        public static ObjectGroupKind PressureTest
        {
            get 
            {
                return pressureTest;
            }
        }

        private readonly static ObjectGroupKind flowTest;
        /// <summary>
        /// Run of flow test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the flow test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. 
        /// </summary>
        [EnumValueNameAttribute("flow test")]
        public static ObjectGroupKind FlowTest
        {
            get 
            {
                return flowTest;
            }
        }

        private readonly static ObjectGroupKind holeSection;
        /// <summary>
        /// The group collects the data-objects which operate within a portion of the wellbore with the same hole size. The sequence element represents the ordered sequence of the hole size within the wellbore. A sequence number of one represents the shallowest section. The range elements represent the portion of the wellbore with the same hole size. The parameter with the name "holeSize" represents the numeric size of the hole and MUST be specified with a "length" unit of measure. 
        /// </summary>
        [EnumValueNameAttribute("hole section")]
        public static ObjectGroupKind HoleSection
        {
            get 
            {
                return holeSection;
            }
        }

        private readonly static ObjectGroupKind coring;
        /// <summary>
        /// The group collects the data-objects which relate to a cored interval. The sequence element represents the BHA run within which the core was taken. The range elements represent the portion of the wellbore from which the core was taken. The reference elements represent the time and depth of the core. The parameter with the name "coreLength" represents the numeric length of the core and MUST be specified with a "length" unit of measure. 
        /// </summary>
        [EnumValueNameAttribute("coring")]
        public static ObjectGroupKind Coring
        {
            get 
            {
                return coring;
            }
        }

        private readonly static ObjectGroupKind drillReport;
        /// <summary>
        /// The group collects the data-objects which relate to a reporting period. The sequence element represents the Nth report. The range elements represent the portion of the wellbore which was drilled during the period. The reference date-time element represents the time of the end of the reporting period. 
        /// </summary>
        [EnumValueNameAttribute("drill report")]
        public static ObjectGroupKind DrillReport
        {
            get 
            {
                return drillReport;
            }
        }

        private readonly static ObjectGroupKind other;
        /// <summary>
        /// Primarily allows objectGroup.groupType not be constrained to enum values. 
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static ObjectGroupKind Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static ObjectGroupKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ObjectGroupKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ObjectGroupKind()
        {
            drilling = 
                new ObjectGroupKind("drilling")
                {
                    Description = "Run of BHA tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the BHA run number. The sequence1 element represents the BHA pass number within the run. The range elements represent the portion of the wellbore traversed by the BHA for that run. "
                    ,Version = "1.4.1.0"
            };
            wireline = 
                new ObjectGroupKind("wireline")
                {
                    Description = "Run of wirelilne tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the wireline run (trip) number. The sequence1 element represents the pass number within the run. The range elements represent the portion of the wellbore traversed by the tool for that run. "
                    ,Version = "1.4.1.0"
            };
            pressureTest = 
                new ObjectGroupKind("pressure test")
                {
                    Description = "Run of pressure test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the pressure test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. "
                    ,Version = "1.4.1.0"
            };
            flowTest = 
                new ObjectGroupKind("flow test")
                {
                    Description = "Run of flow test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the flow test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. "
                    ,Version = "1.4.1.0"
            };
            holeSection = 
                new ObjectGroupKind("hole section")
                {
                    Description = "The group collects the data-objects which operate within a portion of the wellbore with the same hole size. The sequence element represents the ordered sequence of the hole size within the wellbore. A sequence number of one represents the shallowest section. The range elements represent the portion of the wellbore with the same hole size. The parameter with the name \"holeSize\" represents the numeric size of the hole and MUST be specified with a \"length\" unit of measure. "
                    ,Version = "1.4.1.0"
            };
            coring = 
                new ObjectGroupKind("coring")
                {
                    Description = "The group collects the data-objects which relate to a cored interval. The sequence element represents the BHA run within which the core was taken. The range elements represent the portion of the wellbore from which the core was taken. The reference elements represent the time and depth of the core. The parameter with the name \"coreLength\" represents the numeric length of the core and MUST be specified with a \"length\" unit of measure. "
                    ,Version = "1.4.1.0"
            };
            drillReport = 
                new ObjectGroupKind("drill report")
                {
                    Description = "The group collects the data-objects which relate to a reporting period. The sequence element represents the Nth report. The range elements represent the portion of the wellbore which was drilled during the period. The reference date-time element represents the time of the end of the reporting period. "
                    ,Version = "1.4.1.0"
            };
            other = 
                new ObjectGroupKind("other")
                {
                    Description = "Primarily allows objectGroup.groupType not be constrained to enum values. "
                    ,Version = "1.4.1.1"
            };
            unknown = 
                new ObjectGroupKind("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
                    ,Version = "1.4.1.0"
            };
        }

        /// <summary>
        /// Gets a ObjectGroupKind by name
        /// </summary>
        /// <param name="name">The name of the ObjectGroupKind to return</param>
        /// <returns>The ObjectGroupKind represented by 'name'</returns>
        public static ObjectGroupKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ObjectGroupKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ObjectGroupKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ObjectGroupKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// These values represent the type of qualifier in lithology.
    /// </summary>
    public class QualifierType : Energistics.DataAccess.EnumValue.LithoTypeEnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected QualifierType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the QualifierType</param>
        public QualifierType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of QualifierTypes
        /// </summary>
        /// <returns>The complete list of QualifierTypes</returns>
        public static List<QualifierType> GetList()
        {
            return GetList<QualifierType>();
        }

        private readonly static QualifierType alkaliFeldsparRhyolite;
        /// <summary>
        /// Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("alkali feldspar rhyolite")]
        public static QualifierType AlkaliFeldsparRhyolite
        {
            get 
            {
                return alkaliFeldsparRhyolite;
            }
        }

        private readonly static QualifierType alkaliOlivineBasalt;
        /// <summary>
        /// Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("alkali olivine basalt")]
        public static QualifierType AlkaliOlivineBasalt
        {
            get 
            {
                return alkaliOlivineBasalt;
            }
        }

        private readonly static QualifierType amphibolite;
        /// <summary>
        /// Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8.
        /// </summary>
        [EnumValueNameAttribute("amphibolite")]
        public static QualifierType Amphibolite
        {
            get 
            {
                return amphibolite;
            }
        }

        private readonly static QualifierType amphibolitic;
        /// <summary>
        /// VARIANT. See "amphibolite".
        /// </summary>
        [EnumValueNameAttribute("amphibolitic")]
        public static QualifierType Amphibolitic
        {
            get 
            {
                return amphibolitic;
            }
        }

        private readonly static QualifierType andesite;
        /// <summary>
        /// Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("andesite")]
        public static QualifierType Andesite
        {
            get 
            {
                return andesite;
            }
        }

        private readonly static QualifierType andesitic;
        /// <summary>
        /// VARIANT. See "andesite".
        /// </summary>
        [EnumValueNameAttribute("andesitic")]
        public static QualifierType Andesitic
        {
            get 
            {
                return andesitic;
            }
        }

        private readonly static QualifierType anhydrite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles the evaporite mineral anhydrite (CaSO4).
        /// </summary>
        [EnumValueNameAttribute("anhydrite")]
        public static QualifierType Anhydrite
        {
            get 
            {
                return anhydrite;
            }
        }

        private readonly static QualifierType anhydritic;
        /// <summary>
        /// VARIANT. See "anhydrite".
        /// </summary>
        [EnumValueNameAttribute("anhydritic")]
        public static QualifierType Anhydritic
        {
            get 
            {
                return anhydritic;
            }
        }

        private readonly static QualifierType ankerite;
        /// <summary>
        /// A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),
        /// </summary>
        [EnumValueNameAttribute("ankerite")]
        public static QualifierType Ankerite
        {
            get 
            {
                return ankerite;
            }
        }

        private readonly static QualifierType ankeritic;
        /// <summary>
        /// VARIANT. See "ankerite".
        /// </summary>
        [EnumValueNameAttribute("ankeritic")]
        public static QualifierType Ankeritic
        {
            get 
            {
                return ankeritic;
            }
        }

        private readonly static QualifierType anorthositicRock;
        /// <summary>
        /// Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("anorthositic rock")]
        public static QualifierType AnorthositicRock
        {
            get 
            {
                return anorthositicRock;
            }
        }

        private readonly static QualifierType anthracite;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005
        /// </summary>
        [EnumValueNameAttribute("anthracite")]
        public static QualifierType Anthracite
        {
            get 
            {
                return anthracite;
            }
        }

        private readonly static QualifierType anthracitic;
        /// <summary>
        /// VARIANT. See "anthracite".
        /// </summary>
        [EnumValueNameAttribute("anthracitic")]
        public static QualifierType Anthracitic
        {
            get 
            {
                return anthracitic;
            }
        }

        private readonly static QualifierType aplite;
        /// <summary>
        /// Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("aplite")]
        public static QualifierType Aplite
        {
            get 
            {
                return aplite;
            }
        }

        private readonly static QualifierType aplitic;
        /// <summary>
        /// VARIANT. See "aplite".
        /// </summary>
        [EnumValueNameAttribute("aplitic")]
        public static QualifierType Aplitic
        {
            get 
            {
                return aplitic;
            }
        }

        private readonly static QualifierType arenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite.
        /// </summary>
        [EnumValueNameAttribute("arenite")]
        public static QualifierType Arenite
        {
            get 
            {
                return arenite;
            }
        }

        private readonly static QualifierType arenitic;
        /// <summary>
        /// VARIANT. See "arenite".
        /// </summary>
        [EnumValueNameAttribute("arenitic")]
        public static QualifierType Arenitic
        {
            get 
            {
                return arenitic;
            }
        }

        private readonly static QualifierType argillaceous;
        /// <summary>
        /// VARIANT. See "clay".
        /// </summary>
        [EnumValueNameAttribute("argillaceous")]
        public static QualifierType Argillaceous
        {
            get 
            {
                return argillaceous;
            }
        }

        private readonly static QualifierType arkose;
        /// <summary>
        /// An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%).
        /// </summary>
        [EnumValueNameAttribute("arkose")]
        public static QualifierType Arkose
        {
            get 
            {
                return arkose;
            }
        }

        private readonly static QualifierType arkosic;
        /// <summary>
        /// VARIANT. See "arkose".
        /// </summary>
        [EnumValueNameAttribute("arkosic")]
        public static QualifierType Arkosic
        {
            get 
            {
                return arkosic;
            }
        }

        private readonly static QualifierType barite;
        /// <summary>
        /// Indicates that the associated lithology contains the mineral barite [baryte] (BaSO4).
        /// </summary>
        [EnumValueNameAttribute("barite")]
        public static QualifierType Barite
        {
            get 
            {
                return barite;
            }
        }

        private readonly static QualifierType baritic;
        /// <summary>
        /// VARIANT. See "barite".
        /// </summary>
        [EnumValueNameAttribute("baritic")]
        public static QualifierType Baritic
        {
            get 
            {
                return baritic;
            }
        }

        private readonly static QualifierType basalt;
        /// <summary>
        /// Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basalt")]
        public static QualifierType Basalt
        {
            get 
            {
                return basalt;
            }
        }

        private readonly static QualifierType basaltic;
        /// <summary>
        /// VARIANT. See "basalt".
        /// </summary>
        [EnumValueNameAttribute("basaltic")]
        public static QualifierType Basaltic
        {
            get 
            {
                return basaltic;
            }
        }

        private readonly static QualifierType basanite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basanite")]
        public static QualifierType Basanite
        {
            get 
            {
                return basanite;
            }
        }

        private readonly static QualifierType basanitic;
        /// <summary>
        /// VARIANT. See "basanite".
        /// </summary>
        [EnumValueNameAttribute("basanitic")]
        public static QualifierType Basanitic
        {
            get 
            {
                return basanitic;
            }
        }

        private readonly static QualifierType bauxite;
        /// <summary>
        /// Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001.
        /// </summary>
        [EnumValueNameAttribute("bauxite")]
        public static QualifierType Bauxite
        {
            get 
            {
                return bauxite;
            }
        }

        private readonly static QualifierType bauxitic;
        /// <summary>
        /// VARIANT. See "bauxite".
        /// </summary>
        [EnumValueNameAttribute("bauxitic")]
        public static QualifierType Bauxitic
        {
            get 
            {
                return bauxitic;
            }
        }

        private readonly static QualifierType belemnites;
        /// <summary>
        /// Indicates that the associated lithology contains belemnite (Carboniferous - Eocene) fossils or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("belemnites")]
        public static QualifierType Belemnites
        {
            get 
            {
                return belemnites;
            }
        }

        private readonly static QualifierType belemnitic;
        /// <summary>
        /// VARIANT. See "belemnites".
        /// </summary>
        [EnumValueNameAttribute("belemnitic")]
        public static QualifierType Belemnitic
        {
            get 
            {
                return belemnitic;
            }
        }

        private readonly static QualifierType bioturbated;
        /// <summary>
        /// VARIANT. See "bioturbation".
        /// </summary>
        [EnumValueNameAttribute("bioturbated")]
        public static QualifierType Bioturbated
        {
            get 
            {
                return bioturbated;
            }
        }

        private readonly static QualifierType bioturbation;
        /// <summary>
        /// Indicates that the associated lithology has been disturbed by the (burrowing) activities of organisms before consolidation of the sediment.
        /// </summary>
        [EnumValueNameAttribute("bioturbation")]
        public static QualifierType Bioturbation
        {
            get 
            {
                return bioturbation;
            }
        }

        private readonly static QualifierType bitumen;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling bitumen (asphalt), pitch or tar.
        /// </summary>
        [EnumValueNameAttribute("bitumen")]
        public static QualifierType Bitumen
        {
            get 
            {
                return bitumen;
            }
        }

        private readonly static QualifierType bituminous;
        /// <summary>
        /// VARIANT. See "bitumen".
        /// </summary>
        [EnumValueNameAttribute("bituminous")]
        public static QualifierType Bituminous
        {
            get 
            {
                return bituminous;
            }
        }

        private readonly static QualifierType bituminousCoal;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("bituminous coal")]
        public static QualifierType BituminousCoal
        {
            get 
            {
                return bituminousCoal;
            }
        }

        private readonly static QualifierType blueschistMetamorphicRock;
        /// <summary>
        /// Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock
        /// </summary>
        [EnumValueNameAttribute("blueschist metamorphic rock")]
        public static QualifierType BlueschistMetamorphicRock
        {
            get 
            {
                return blueschistMetamorphicRock;
            }
        }

        private readonly static QualifierType boninite;
        /// <summary>
        /// andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("boninite")]
        public static QualifierType Boninite
        {
            get 
            {
                return boninite;
            }
        }

        private readonly static QualifierType breccia;
        /// <summary>
        /// Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("breccia")]
        public static QualifierType Breccia
        {
            get 
            {
                return breccia;
            }
        }

        private readonly static QualifierType brecciated;
        /// <summary>
        /// VARIANT. See "breccia".
        /// </summary>
        [EnumValueNameAttribute("brecciated")]
        public static QualifierType Brecciated
        {
            get 
            {
                return brecciated;
            }
        }

        private readonly static QualifierType bryozoan;
        /// <summary>
        /// VARIANT. See "bryozoans".
        /// </summary>
        [EnumValueNameAttribute("bryozoan")]
        public static QualifierType Bryozoan
        {
            get 
            {
                return bryozoan;
            }
        }

        private readonly static QualifierType bryozoans;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of bryozoan (Ordovician - Recent) fossils or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("bryozoans")]
        public static QualifierType Bryozoans
        {
            get 
            {
                return bryozoans;
            }
        }

        private readonly static QualifierType burrowed;
        /// <summary>
        /// VARIANT. See "burrows".
        /// </summary>
        [EnumValueNameAttribute("burrowed")]
        public static QualifierType Burrowed
        {
            get 
            {
                return burrowed;
            }
        }

        private readonly static QualifierType burrows;
        /// <summary>
        /// Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation of the sediment.
        /// </summary>
        [EnumValueNameAttribute("burrows")]
        public static QualifierType Burrows
        {
            get 
            {
                return burrows;
            }
        }

        private readonly static QualifierType calcareous;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or characteristic of calcium carbonate (CaCO3).
        /// </summary>
        [EnumValueNameAttribute("calcareous")]
        public static QualifierType Calcareous
        {
            get 
            {
                return calcareous;
            }
        }

        private readonly static QualifierType calcite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the crystalline form of calcium carbonate (CaCO3).
        /// </summary>
        [EnumValueNameAttribute("calcite")]
        public static QualifierType Calcite
        {
            get 
            {
                return calcite;
            }
        }

        private readonly static QualifierType calciteConcr;
        /// <summary>
        /// DEPRECATED. See "calcite concretion".
        /// </summary>
        [EnumValueNameAttribute("calcite concr")]
        public static QualifierType CalciteConcr
        {
            get 
            {
                return calciteConcr;
            }
        }

        private readonly static QualifierType calciteConcretion;
        /// <summary>
        /// Indicates that the associated lithology contains rounded nodules of crystalline calcium carbonate.
        /// </summary>
        [EnumValueNameAttribute("calcite concretion")]
        public static QualifierType CalciteConcretion
        {
            get 
            {
                return calciteConcretion;
            }
        }

        private readonly static QualifierType calcitic;
        /// <summary>
        /// VARIANT. See "calcite".
        /// </summary>
        [EnumValueNameAttribute("calcitic")]
        public static QualifierType Calcitic
        {
            get 
            {
                return calcitic;
            }
        }

        private readonly static QualifierType carbonaceous;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or yielding carbon.
        /// </summary>
        [EnumValueNameAttribute("carbonaceous")]
        public static QualifierType Carbonaceous
        {
            get 
            {
                return carbonaceous;
            }
        }

        private readonly static QualifierType carbonateOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("carbonate ooze")]
        public static QualifierType CarbonateOoze
        {
            get 
            {
                return carbonateOoze;
            }
        }

        private readonly static QualifierType carbonatite;
        /// <summary>
        /// Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("carbonatite")]
        public static QualifierType Carbonatite
        {
            get 
            {
                return carbonatite;
            }
        }

        private readonly static QualifierType carbonatitic;
        /// <summary>
        /// VARIANT. See "carbonatite".
        /// </summary>
        [EnumValueNameAttribute("carbonatitic")]
        public static QualifierType Carbonatitic
        {
            get 
            {
                return carbonatitic;
            }
        }

        private readonly static QualifierType chalk;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a soft compact form of calcium carbonate (CaCO3).
        /// </summary>
        [EnumValueNameAttribute("chalk")]
        public static QualifierType Chalk
        {
            get 
            {
                return chalk;
            }
        }

        private readonly static QualifierType chalky;
        /// <summary>
        /// VARIANT. See "chalk".
        /// </summary>
        [EnumValueNameAttribute("chalky")]
        public static QualifierType Chalky
        {
            get 
            {
                return chalky;
            }
        }

        private readonly static QualifierType chamosite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles chamosite, a generally greenish-gray or black silicate mineral of iron and aluminium.
        /// </summary>
        [EnumValueNameAttribute("chamosite")]
        public static QualifierType Chamosite
        {
            get 
            {
                return chamosite;
            }
        }

        private readonly static QualifierType chamositic;
        /// <summary>
        /// VARIANT. See "chamosite".
        /// </summary>
        [EnumValueNameAttribute("chamositic")]
        public static QualifierType Chamositic
        {
            get 
            {
                return chamositic;
            }
        }

        private readonly static QualifierType chert;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles the microcrystalline or cryptocrystalline form of quartz (SiO2).
        /// </summary>
        [EnumValueNameAttribute("chert")]
        public static QualifierType Chert
        {
            get 
            {
                return chert;
            }
        }

        private readonly static QualifierType cherty;
        /// <summary>
        /// VARIANT. See "chert".
        /// </summary>
        [EnumValueNameAttribute("cherty")]
        public static QualifierType Cherty
        {
            get 
            {
                return cherty;
            }
        }

        private readonly static QualifierType chlorite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles chlorite, a generally green or black flaky phyllosilicate mineral.
        /// </summary>
        [EnumValueNameAttribute("chlorite")]
        public static QualifierType Chlorite
        {
            get 
            {
                return chlorite;
            }
        }

        private readonly static QualifierType chloritic;
        /// <summary>
        /// VARIANT. See "chlorite".
        /// </summary>
        [EnumValueNameAttribute("chloritic")]
        public static QualifierType Chloritic
        {
            get 
            {
                return chloritic;
            }
        }

        private readonly static QualifierType clay;
        /// <summary>
        /// Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("clay")]
        public static QualifierType Clay
        {
            get 
            {
                return clay;
            }
        }

        private readonly static QualifierType claystone;
        /// <summary>
        /// Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("claystone")]
        public static QualifierType Claystone
        {
            get 
            {
                return claystone;
            }
        }

        private readonly static QualifierType coal;
        /// <summary>
        /// A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("coal")]
        public static QualifierType Coal
        {
            get 
            {
                return coal;
            }
        }

        private readonly static QualifierType concretionary;
        /// <summary>
        /// VARIANT. See "concretions".
        /// </summary>
        [EnumValueNameAttribute("concretionary")]
        public static QualifierType Concretionary
        {
            get 
            {
                return concretionary;
            }
        }

        private readonly static QualifierType concretions;
        /// <summary>
        /// Indicates that the associated lithology contains rounded masses of mineral material.
        /// </summary>
        [EnumValueNameAttribute("concretions")]
        public static QualifierType Concretions
        {
            get 
            {
                return concretions;
            }
        }

        private readonly static QualifierType conglomerate;
        /// <summary>
        /// Indicates that the associated lithology contains rounded rock fragments of greater than 20mm in size.
        /// </summary>
        [EnumValueNameAttribute("conglomerate")]
        public static QualifierType Conglomerate
        {
            get 
            {
                return conglomerate;
            }
        }

        private readonly static QualifierType conglomeratic;
        /// <summary>
        /// VARIANT. See "conglomerate".
        /// </summary>
        [EnumValueNameAttribute("conglomeratic")]
        public static QualifierType Conglomeratic
        {
            get 
            {
                return conglomeratic;
            }
        }

        private readonly static QualifierType coral;
        /// <summary>
        /// DEPRECATED. See "coral fragments".
        /// </summary>
        [EnumValueNameAttribute("coral")]
        public static QualifierType Coral
        {
            get 
            {
                return coral;
            }
        }

        private readonly static QualifierType coralFragments;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles corals (late Pre-Cambrian - Recent) and/or coral fragments.
        /// </summary>
        [EnumValueNameAttribute("coral fragments")]
        public static QualifierType CoralFragments
        {
            get 
            {
                return coralFragments;
            }
        }

        private readonly static QualifierType coralline;
        /// <summary>
        /// VARIANT. See "coral fragments".
        /// </summary>
        [EnumValueNameAttribute("coralline")]
        public static QualifierType Coralline
        {
            get 
            {
                return coralline;
            }
        }

        private readonly static QualifierType crinoidal;
        /// <summary>
        /// VARIANT. See "crinoids".
        /// </summary>
        [EnumValueNameAttribute("crinoidal")]
        public static QualifierType Crinoidal
        {
            get 
            {
                return crinoidal;
            }
        }

        private readonly static QualifierType crinoids;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles crinoids (Mid Cambrian - Recent) and/or crinoid fragments.
        /// </summary>
        [EnumValueNameAttribute("crinoids")]
        public static QualifierType Crinoids
        {
            get 
            {
                return crinoids;
            }
        }

        private readonly static QualifierType dacite;
        /// <summary>
        /// Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dacite")]
        public static QualifierType Dacite
        {
            get 
            {
                return dacite;
            }
        }

        private readonly static QualifierType dacitic;
        /// <summary>
        /// VARIANT. See "dacite".
        /// </summary>
        [EnumValueNameAttribute("dacitic")]
        public static QualifierType Dacitic
        {
            get 
            {
                return dacitic;
            }
        }

        private readonly static QualifierType diabase;
        /// <summary>
        /// Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite.
        /// </summary>
        [EnumValueNameAttribute("diabase")]
        public static QualifierType Diabase
        {
            get 
            {
                return diabase;
            }
        }

        private readonly static QualifierType diabasic;
        /// <summary>
        /// VARIANT. See "diabase".
        /// </summary>
        [EnumValueNameAttribute("diabasic")]
        public static QualifierType Diabasic
        {
            get 
            {
                return diabasic;
            }
        }

        private readonly static QualifierType diamictite;
        /// <summary>
        /// Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978.
        /// </summary>
        [EnumValueNameAttribute("diamictite")]
        public static QualifierType Diamictite
        {
            get 
            {
                return diamictite;
            }
        }

        private readonly static QualifierType diamictitic;
        /// <summary>
        /// VARIANT. See "diamictite".
        /// </summary>
        [EnumValueNameAttribute("diamictitic")]
        public static QualifierType Diamictitic
        {
            get 
            {
                return diamictitic;
            }
        }

        private readonly static QualifierType diatomaceous;
        /// <summary>
        /// VARIANT. See "diatoms".
        /// </summary>
        [EnumValueNameAttribute("diatomaceous")]
        public static QualifierType Diatomaceous
        {
            get 
            {
                return diatomaceous;
            }
        }

        private readonly static QualifierType diatoms;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles diatoms and/or diatom fragments.
        /// </summary>
        [EnumValueNameAttribute("diatoms")]
        public static QualifierType Diatoms
        {
            get 
            {
                return diatoms;
            }
        }

        private readonly static QualifierType diorite;
        /// <summary>
        /// Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite.
        /// </summary>
        [EnumValueNameAttribute("diorite")]
        public static QualifierType Diorite
        {
            get 
            {
                return diorite;
            }
        }

        private readonly static QualifierType dioritic;
        /// <summary>
        /// VARIANT. See "diorite".
        /// </summary>
        [EnumValueNameAttribute("dioritic")]
        public static QualifierType Dioritic
        {
            get 
            {
                return dioritic;
            }
        }

        private readonly static QualifierType dioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dioritoid")]
        public static QualifierType Dioritoid
        {
            get 
            {
                return dioritoid;
            }
        }

        private readonly static QualifierType dioritoidic;
        /// <summary>
        /// VARIANT. See "dioritoid".
        /// </summary>
        [EnumValueNameAttribute("dioritoidic")]
        public static QualifierType Dioritoidic
        {
            get 
            {
                return dioritoidic;
            }
        }

        private readonly static QualifierType doleriticRock;
        /// <summary>
        /// Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("doleritic rock")]
        public static QualifierType DoleriticRock
        {
            get 
            {
                return doleriticRock;
            }
        }

        private readonly static QualifierType dolomite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling a magnesium-rich carbonate mineral of calcium (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static QualifierType Dolomite
        {
            get 
            {
                return dolomite;
            }
        }

        private readonly static QualifierType dolomiteConcretion;
        /// <summary>
        /// Indicates that the associated lithology has rounded nodules of dolomite (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite concretion")]
        public static QualifierType DolomiteConcretion
        {
            get 
            {
                return dolomiteConcretion;
            }
        }

        private readonly static QualifierType dolomiteStringer;
        /// <summary>
        /// Indicates that the associated lithology contains thin beds of dolomite (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite stringer")]
        public static QualifierType DolomiteStringer
        {
            get 
            {
                return dolomiteStringer;
            }
        }

        private readonly static QualifierType dolomitic;
        /// <summary>
        /// VARIANT. See "dolomite".
        /// </summary>
        [EnumValueNameAttribute("dolomitic")]
        public static QualifierType Dolomitic
        {
            get 
            {
                return dolomitic;
            }
        }

        private readonly static QualifierType eclogite;
        /// <summary>
        /// Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("eclogite")]
        public static QualifierType Eclogite
        {
            get 
            {
                return eclogite;
            }
        }

        private readonly static QualifierType eclogitic;
        /// <summary>
        /// VARIANT. See "eclogite".
        /// </summary>
        [EnumValueNameAttribute("eclogitic")]
        public static QualifierType Eclogitic
        {
            get 
            {
                return eclogitic;
            }
        }

        private readonly static QualifierType exoticAlkalineRock;
        /// <summary>
        /// Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("exotic alkaline rock")]
        public static QualifierType ExoticAlkalineRock
        {
            get 
            {
                return exoticAlkalineRock;
            }
        }

        private readonly static QualifierType feldspar;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the rock-forming aluminosilicate minerals of sodium, potassium or calcium.
        /// </summary>
        [EnumValueNameAttribute("feldspar")]
        public static QualifierType Feldspar
        {
            get 
            {
                return feldspar;
            }
        }

        private readonly static QualifierType feldsparic;
        /// <summary>
        /// VARIANT. See "feldspar".
        /// </summary>
        [EnumValueNameAttribute("feldsparic")]
        public static QualifierType Feldsparic
        {
            get 
            {
                return feldsparic;
            }
        }

        private readonly static QualifierType feldspathic;
        /// <summary>
        /// VARIANT. See "feldspar".
        /// </summary>
        [EnumValueNameAttribute("feldspathic")]
        public static QualifierType Feldspathic
        {
            get 
            {
                return feldspathic;
            }
        }

        private readonly static QualifierType feldspathicArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("feldspathic arenite")]
        public static QualifierType FeldspathicArenite
        {
            get 
            {
                return feldspathicArenite;
            }
        }

        private readonly static QualifierType ferruginous;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling minerals rich in iron oxide or iron hydroxide.
        /// </summary>
        [EnumValueNameAttribute("ferruginous")]
        public static QualifierType Ferruginous
        {
            get 
            {
                return ferruginous;
            }
        }

        private readonly static QualifierType fineGrainedIgneousRock;
        /// <summary>
        /// Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("fine grained igneous rock")]
        public static QualifierType FineGrainedIgneousRock
        {
            get 
            {
                return fineGrainedIgneousRock;
            }
        }

        private readonly static QualifierType fissile;
        /// <summary>
        /// DEPRECATED. The term 'fissile' doesn't belong in this list as it is neither qualifier or modifier .... it is a descriptor of 'grain fabric'.
        /// </summary>
        [EnumValueNameAttribute("fissile")]
        public static QualifierType Fissile
        {
            get 
            {
                return fissile;
            }
        }

        private readonly static QualifierType foidDioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid dioritoid")]
        public static QualifierType FoidDioritoid
        {
            get 
            {
                return foidDioritoid;
            }
        }

        private readonly static QualifierType foidGabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid gabbroid")]
        public static QualifierType FoidGabbroid
        {
            get 
            {
                return foidGabbroid;
            }
        }

        private readonly static QualifierType foidSyenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid syenitoid")]
        public static QualifierType FoidSyenitoid
        {
            get 
            {
                return foidSyenitoid;
            }
        }

        private readonly static QualifierType foidite;
        /// <summary>
        /// Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidite")]
        public static QualifierType Foidite
        {
            get 
            {
                return foidite;
            }
        }

        private readonly static QualifierType foiditic;
        /// <summary>
        /// VARIANT. See "foidite".
        /// </summary>
        [EnumValueNameAttribute("foiditic")]
        public static QualifierType Foiditic
        {
            get 
            {
                return foiditic;
            }
        }

        private readonly static QualifierType foiditoid;
        /// <summary>
        /// Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foiditoid")]
        public static QualifierType Foiditoid
        {
            get 
            {
                return foiditoid;
            }
        }

        private readonly static QualifierType foidolite;
        /// <summary>
        /// Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidolite")]
        public static QualifierType Foidolite
        {
            get 
            {
                return foidolite;
            }
        }

        private readonly static QualifierType foidolitic;
        /// <summary>
        /// VARIANT. See "foidolite".
        /// </summary>
        [EnumValueNameAttribute("foidolitic")]
        public static QualifierType Foidolitic
        {
            get 
            {
                return foidolitic;
            }
        }

        private readonly static QualifierType foliatedMetamorphicRock;
        /// <summary>
        /// Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic.
        /// </summary>
        [EnumValueNameAttribute("foliated metamorphic rock")]
        public static QualifierType FoliatedMetamorphicRock
        {
            get 
            {
                return foliatedMetamorphicRock;
            }
        }

        private readonly static QualifierType foraminifera;
        /// <summary>
        /// VARIANT. See "forams".
        /// </summary>
        [EnumValueNameAttribute("foraminifera")]
        public static QualifierType Foraminifera
        {
            get 
            {
                return foraminifera;
            }
        }

        private readonly static QualifierType foraminiferous;
        /// <summary>
        /// VARIANT. See "forams".
        /// </summary>
        [EnumValueNameAttribute("foraminiferous")]
        public static QualifierType Foraminiferous
        {
            get 
            {
                return foraminiferous;
            }
        }

        private readonly static QualifierType forams;
        /// <summary>
        /// Indicates that the associated lithology contains marine micro-organisms of the order Foraminifera (Devonian - Recent), having a calcareous shell.
        /// </summary>
        [EnumValueNameAttribute("forams")]
        public static QualifierType Forams
        {
            get 
            {
                return forams;
            }
        }

        private readonly static QualifierType foramsUndifferentiated;
        /// <summary>
        /// DEPRECATED. See forams.
        /// </summary>
        [EnumValueNameAttribute("forams undifferentiated")]
        public static QualifierType ForamsUndifferentiated
        {
            get 
            {
                return foramsUndifferentiated;
            }
        }

        private readonly static QualifierType fossilFragment;
        /// <summary>
        /// DEPRECATED. See "fossil fragments".
        /// </summary>
        [EnumValueNameAttribute("fossil fragment")]
        public static QualifierType FossilFragment
        {
            get 
            {
                return fossilFragment;
            }
        }

        private readonly static QualifierType fossilFragments;
        /// <summary>
        /// Indicates that the associated lithology contains material comprised of fossils or fossil fragments.
        /// </summary>
        [EnumValueNameAttribute("fossil fragments")]
        public static QualifierType FossilFragments
        {
            get 
            {
                return fossilFragments;
            }
        }

        private readonly static QualifierType fossiliferous;
        /// <summary>
        /// VARIANT. See "fossil fragments".
        /// </summary>
        [EnumValueNameAttribute("fossiliferous")]
        public static QualifierType Fossiliferous
        {
            get 
            {
                return fossiliferous;
            }
        }

        private readonly static QualifierType fossilsUndifferentiated;
        /// <summary>
        /// Indicates that the associated lithology contains material comprised of fossils or fossil fragments of undetermined type type, form or species.
        /// </summary>
        [EnumValueNameAttribute("fossils undifferentiated")]
        public static QualifierType FossilsUndifferentiated
        {
            get 
            {
                return fossilsUndifferentiated;
            }
        }

        private readonly static QualifierType fragmentalIgneousRock;
        /// <summary>
        /// Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite).
        /// </summary>
        [EnumValueNameAttribute("fragmental igneous rock")]
        public static QualifierType FragmentalIgneousRock
        {
            get 
            {
                return fragmentalIgneousRock;
            }
        }

        private readonly static QualifierType gabbro;
        /// <summary>
        /// Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbro")]
        public static QualifierType Gabbro
        {
            get 
            {
                return gabbro;
            }
        }

        private readonly static QualifierType gabbroic;
        /// <summary>
        /// VARIANT. See "gabbro".
        /// </summary>
        [EnumValueNameAttribute("gabbroic")]
        public static QualifierType Gabbroic
        {
            get 
            {
                return gabbroic;
            }
        }

        private readonly static QualifierType gabbroicRock;
        /// <summary>
        /// Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroic rock")]
        public static QualifierType GabbroicRock
        {
            get 
            {
                return gabbroicRock;
            }
        }

        private readonly static QualifierType gabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroid")]
        public static QualifierType Gabbroid
        {
            get 
            {
                return gabbroid;
            }
        }

        private readonly static QualifierType gabbroidic;
        /// <summary>
        /// VARIANT. See "gabbroid".
        /// </summary>
        [EnumValueNameAttribute("gabbroidic")]
        public static QualifierType Gabbroidic
        {
            get 
            {
                return gabbroidic;
            }
        }

        private readonly static QualifierType gilsonite;
        /// <summary>
        /// Indicates that the associated lithology contains material containing or resembling gilsonite (uintaite), a brilliant black variety of asphalt occurring in rounded masses.
        /// </summary>
        [EnumValueNameAttribute("gilsonite")]
        public static QualifierType Gilsonite
        {
            get 
            {
                return gilsonite;
            }
        }

        private readonly static QualifierType gilsonitic;
        /// <summary>
        /// VARIANT. See "gilsonite".
        /// </summary>
        [EnumValueNameAttribute("gilsonitic")]
        public static QualifierType Gilsonitic
        {
            get 
            {
                return gilsonitic;
            }
        }

        private readonly static QualifierType glauconite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the generally greenish authogenic clay mineral glauconite.
        /// </summary>
        [EnumValueNameAttribute("glauconite")]
        public static QualifierType Glauconite
        {
            get 
            {
                return glauconite;
            }
        }

        private readonly static QualifierType glauconitic;
        /// <summary>
        /// VARIANT. See "glauconite".
        /// </summary>
        [EnumValueNameAttribute("glauconitic")]
        public static QualifierType Glauconitic
        {
            get 
            {
                return glauconitic;
            }
        }

        private readonly static QualifierType gneiss;
        /// <summary>
        /// Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("gneiss")]
        public static QualifierType Gneiss
        {
            get 
            {
                return gneiss;
            }
        }

        private readonly static QualifierType gneissic;
        /// <summary>
        /// VARIANT. See "gneiss".
        /// </summary>
        [EnumValueNameAttribute("gneissic")]
        public static QualifierType Gneissic
        {
            get 
            {
                return gneissic;
            }
        }

        private readonly static QualifierType granite;
        /// <summary>
        /// Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granite")]
        public static QualifierType Granite
        {
            get 
            {
                return granite;
            }
        }

        private readonly static QualifierType granitic;
        /// <summary>
        /// VARIANT. See "granite".
        /// </summary>
        [EnumValueNameAttribute("granitic")]
        public static QualifierType Granitic
        {
            get 
            {
                return granitic;
            }
        }

        private readonly static QualifierType granodiorite;
        /// <summary>
        /// Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granodiorite")]
        public static QualifierType Granodiorite
        {
            get 
            {
                return granodiorite;
            }
        }

        private readonly static QualifierType granodioritic;
        /// <summary>
        /// VARIANT. See "granodiorite".
        /// </summary>
        [EnumValueNameAttribute("granodioritic")]
        public static QualifierType Granodioritic
        {
            get 
            {
                return granodioritic;
            }
        }

        private readonly static QualifierType granofels;
        /// <summary>
        /// Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004.
        /// </summary>
        [EnumValueNameAttribute("granofels")]
        public static QualifierType Granofels
        {
            get 
            {
                return granofels;
            }
        }

        private readonly static QualifierType granulite;
        /// <summary>
        /// Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2
        /// </summary>
        [EnumValueNameAttribute("granulite")]
        public static QualifierType Granulite
        {
            get 
            {
                return granulite;
            }
        }

        private readonly static QualifierType granulitic;
        /// <summary>
        /// VARIANT. See "granulite".
        /// </summary>
        [EnumValueNameAttribute("granulitic")]
        public static QualifierType Granulitic
        {
            get 
            {
                return granulitic;
            }
        }

        private readonly static QualifierType gravel;
        /// <summary>
        /// Indicates that the associated lithology contains particles in the size range of 2mm - 20mm.
        /// </summary>
        [EnumValueNameAttribute("gravel")]
        public static QualifierType Gravel
        {
            get 
            {
                return gravel;
            }
        }

        private readonly static QualifierType gravelly;
        /// <summary>
        /// VARIANT. See "gravel".
        /// </summary>
        [EnumValueNameAttribute("gravelly")]
        public static QualifierType Gravelly
        {
            get 
            {
                return gravelly;
            }
        }

        private readonly static QualifierType greenstone;
        /// <summary>
        /// Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone.
        /// </summary>
        [EnumValueNameAttribute("greenstone")]
        public static QualifierType Greenstone
        {
            get 
            {
                return greenstone;
            }
        }

        private readonly static QualifierType gumbo;
        /// <summary>
        /// A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet.
        /// </summary>
        [EnumValueNameAttribute("gumbo")]
        public static QualifierType Gumbo
        {
            get 
            {
                return gumbo;
            }
        }

        private readonly static QualifierType gypsiferous;
        /// <summary>
        /// VARIANT. See "gypsum".
        /// </summary>
        [EnumValueNameAttribute("gypsiferous")]
        public static QualifierType Gypsiferous
        {
            get 
            {
                return gypsiferous;
            }
        }

        private readonly static QualifierType gypsum;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the evaporite mineral gypsum (CaSO4.2H2O).
        /// </summary>
        [EnumValueNameAttribute("gypsum")]
        public static QualifierType Gypsum
        {
            get 
            {
                return gypsum;
            }
        }

        private readonly static QualifierType halite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles the common evaporite mineral Halite (NaCl).
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static QualifierType Halite
        {
            get 
            {
                return halite;
            }
        }

        private readonly static QualifierType halitic;
        /// <summary>
        /// VARIANT. See "halite".
        /// </summary>
        [EnumValueNameAttribute("halitic")]
        public static QualifierType Halitic
        {
            get 
            {
                return halitic;
            }
        }

        private readonly static QualifierType hornfels;
        /// <summary>
        /// Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained.
        /// </summary>
        [EnumValueNameAttribute("hornfels")]
        public static QualifierType Hornfels
        {
            get 
            {
                return hornfels;
            }
        }

        private readonly static QualifierType hornfelsic;
        /// <summary>
        /// VARIANT. See "hornfels".
        /// </summary>
        [EnumValueNameAttribute("hornfelsic")]
        public static QualifierType Hornfelsic
        {
            get 
            {
                return hornfelsic;
            }
        }

        private readonly static QualifierType igneous;
        /// <summary>
        /// VARIANT. See "igneous rock".
        /// </summary>
        [EnumValueNameAttribute("igneous")]
        public static QualifierType Igneous
        {
            get 
            {
                return igneous;
            }
        }

        private readonly static QualifierType igneousRock;
        /// <summary>
        /// Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("igneous rock")]
        public static QualifierType IgneousRock
        {
            get 
            {
                return igneousRock;
            }
        }

        private readonly static QualifierType illite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral illite.
        /// </summary>
        [EnumValueNameAttribute("illite")]
        public static QualifierType Illite
        {
            get 
            {
                return illite;
            }
        }

        private readonly static QualifierType illitic;
        /// <summary>
        /// VARIANT. See "illite".
        /// </summary>
        [EnumValueNameAttribute("illitic")]
        public static QualifierType Illitic
        {
            get 
            {
                return illitic;
            }
        }

        private readonly static QualifierType impactGeneratedMaterial;
        /// <summary>
        /// Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("impact generated material")]
        public static QualifierType ImpactGeneratedMaterial
        {
            get 
            {
                return impactGeneratedMaterial;
            }
        }

        private readonly static QualifierType impureDolomite;
        /// <summary>
        /// Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure dolomite")]
        public static QualifierType ImpureDolomite
        {
            get 
            {
                return impureDolomite;
            }
        }

        private readonly static QualifierType impureLimestone;
        /// <summary>
        /// Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure limestone")]
        public static QualifierType ImpureLimestone
        {
            get 
            {
                return impureLimestone;
            }
        }

        private readonly static QualifierType intrusiveRockPlutonic;
        /// <summary>
        /// Igneous rock formed by cooling and solidification of magma within the earth's crust.
        /// </summary>
        [EnumValueNameAttribute("intrusive rock (plutonic)")]
        public static QualifierType IntrusiveRockPlutonic
        {
            get 
            {
                return intrusiveRockPlutonic;
            }
        }

        private readonly static QualifierType ironRichSedimentaryRock;
        /// <summary>
        /// Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("iron rich sedimentary rock")]
        public static QualifierType IronRichSedimentaryRock
        {
            get 
            {
                return ironRichSedimentaryRock;
            }
        }

        private readonly static QualifierType kalsiliticAndMeliliticRocks;
        /// <summary>
        /// Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("kalsilitic and melilitic rocks")]
        public static QualifierType KalsiliticAndMeliliticRocks
        {
            get 
            {
                return kalsiliticAndMeliliticRocks;
            }
        }

        private readonly static QualifierType kaolinite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral kaolinite.
        /// </summary>
        [EnumValueNameAttribute("kaolinite")]
        public static QualifierType Kaolinite
        {
            get 
            {
                return kaolinite;
            }
        }

        private readonly static QualifierType kaolinitic;
        /// <summary>
        /// VARIANT. See "kaolinite".
        /// </summary>
        [EnumValueNameAttribute("kaolinitic")]
        public static QualifierType Kaolinitic
        {
            get 
            {
                return kaolinitic;
            }
        }

        private readonly static QualifierType komatiiticRock;
        /// <summary>
        /// Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("komatiitic rock")]
        public static QualifierType KomatiiticRock
        {
            get 
            {
                return komatiiticRock;
            }
        }

        private readonly static QualifierType latiticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("latitic rock")]
        public static QualifierType LatiticRock
        {
            get 
            {
                return latiticRock;
            }
        }

        private readonly static QualifierType lignite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a soft brownish-black form of coal.
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static QualifierType Lignite
        {
            get 
            {
                return lignite;
            }
        }

        private readonly static QualifierType lignitic;
        /// <summary>
        /// VARIANT. See "lignite".
        /// </summary>
        [EnumValueNameAttribute("lignitic")]
        public static QualifierType Lignitic
        {
            get 
            {
                return lignitic;
            }
        }

        private readonly static QualifierType limeBoundstone;
        /// <summary>
        /// Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime boundstone")]
        public static QualifierType LimeBoundstone
        {
            get 
            {
                return limeBoundstone;
            }
        }

        private readonly static QualifierType limeFramestone;
        /// <summary>
        /// Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth &amp; Knox 1999; SLTTs 2004, Table 15-3-1
        /// </summary>
        [EnumValueNameAttribute("lime framestone")]
        public static QualifierType LimeFramestone
        {
            get 
            {
                return limeFramestone;
            }
        }

        private readonly static QualifierType limeGrainstone;
        /// <summary>
        /// Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime grainstone")]
        public static QualifierType LimeGrainstone
        {
            get 
            {
                return limeGrainstone;
            }
        }

        private readonly static QualifierType limeMudstone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary.
        /// </summary>
        [EnumValueNameAttribute("lime mudstone")]
        public static QualifierType LimeMudstone
        {
            get 
            {
                return limeMudstone;
            }
        }

        private readonly static QualifierType limePackstone;
        /// <summary>
        /// Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime packstone")]
        public static QualifierType LimePackstone
        {
            get 
            {
                return limePackstone;
            }
        }

        private readonly static QualifierType limeWackestone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime wackestone")]
        public static QualifierType LimeWackestone
        {
            get 
            {
                return limeWackestone;
            }
        }

        private readonly static QualifierType limestone;
        /// <summary>
        /// Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("limestone")]
        public static QualifierType Limestone
        {
            get 
            {
                return limestone;
            }
        }

        private readonly static QualifierType limestoneStringer;
        /// <summary>
        /// Indicates that the associated lithology contains thin beds of limestone.
        /// </summary>
        [EnumValueNameAttribute("limestone stringer")]
        public static QualifierType LimestoneStringer
        {
            get 
            {
                return limestoneStringer;
            }
        }

        private readonly static QualifierType limestoneArgillaceous;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% clay minerals.
        /// </summary>
        [EnumValueNameAttribute("limestone, argillaceous")]
        public static QualifierType LimestoneArgillaceous
        {
            get 
            {
                return limestoneArgillaceous;
            }
        }

        private readonly static QualifierType limestoneDolomitic;
        /// <summary>
        /// A limestone containing 10-50% dolomite and 50-90% calcite.
        /// </summary>
        [EnumValueNameAttribute("limestone, dolomitic")]
        public static QualifierType LimestoneDolomitic
        {
            get 
            {
                return limestoneDolomitic;
            }
        }

        private readonly static QualifierType limestoneSandy;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% quartz grains.
        /// </summary>
        [EnumValueNameAttribute("limestone, sandy")]
        public static QualifierType LimestoneSandy
        {
            get 
            {
                return limestoneSandy;
            }
        }

        private readonly static QualifierType lithic;
        /// <summary>
        /// VARIANT. See "lithic fragments".
        /// </summary>
        [EnumValueNameAttribute("lithic")]
        public static QualifierType Lithic
        {
            get 
            {
                return lithic;
            }
        }

        private readonly static QualifierType lithicFragment;
        /// <summary>
        /// DEPRECATED. See "lithic fragments".
        /// </summary>
        [EnumValueNameAttribute("lithic fragment")]
        public static QualifierType LithicFragment
        {
            get 
            {
                return lithicFragment;
            }
        }

        private readonly static QualifierType lithicFragments;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of undetermined rock fragments.
        /// </summary>
        [EnumValueNameAttribute("lithic fragments")]
        public static QualifierType LithicFragments
        {
            get 
            {
                return lithicFragments;
            }
        }

        private readonly static QualifierType marble;
        /// <summary>
        /// Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("marble")]
        public static QualifierType Marble
        {
            get 
            {
                return marble;
            }
        }

        private readonly static QualifierType marcasite;
        /// <summary>
        /// Indicates that the associate lithology comprises material containing or characteristic of the white (gem) form of iron pyrites (FeS).
        /// </summary>
        [EnumValueNameAttribute("marcasite")]
        public static QualifierType Marcasite
        {
            get 
            {
                return marcasite;
            }
        }

        private readonly static QualifierType marcasitic;
        /// <summary>
        /// VARIANT. See "marcasite".
        /// </summary>
        [EnumValueNameAttribute("marcasitic")]
        public static QualifierType Marcasitic
        {
            get 
            {
                return marcasitic;
            }
        }

        private readonly static QualifierType marl;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of a crumbly mixture of clays, calcium and magnesium carbonates.
        /// </summary>
        [EnumValueNameAttribute("marl")]
        public static QualifierType Marl
        {
            get 
            {
                return marl;
            }
        }

        private readonly static QualifierType marly;
        /// <summary>
        /// VARIANT. See "marl".
        /// </summary>
        [EnumValueNameAttribute("marly")]
        public static QualifierType Marly
        {
            get 
            {
                return marly;
            }
        }

        private readonly static QualifierType metamorphicRock;
        /// <summary>
        /// Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("metamorphic rock")]
        public static QualifierType MetamorphicRock
        {
            get 
            {
                return metamorphicRock;
            }
        }

        private readonly static QualifierType mica;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of mica, a group of hydrous aluminosilicate minerals that split easily into thin partly-transparent sheets.
        /// </summary>
        [EnumValueNameAttribute("mica")]
        public static QualifierType Mica
        {
            get 
            {
                return mica;
            }
        }

        private readonly static QualifierType micaSchist;
        /// <summary>
        /// A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("mica schist")]
        public static QualifierType MicaSchist
        {
            get 
            {
                return micaSchist;
            }
        }

        private readonly static QualifierType micaceous;
        /// <summary>
        /// VARIANT. See "mica".
        /// </summary>
        [EnumValueNameAttribute("micaceous")]
        public static QualifierType Micaceous
        {
            get 
            {
                return micaceous;
            }
        }

        private readonly static QualifierType microfossil;
        /// <summary>
        /// DEPRECATED. See microfossils.
        /// </summary>
        [EnumValueNameAttribute("microfossil")]
        public static QualifierType Microfossil
        {
            get 
            {
                return microfossil;
            }
        }

        private readonly static QualifierType microfossiliferous;
        /// <summary>
        /// VARIANT. See "microfossils".
        /// </summary>
        [EnumValueNameAttribute("microfossiliferous")]
        public static QualifierType Microfossiliferous
        {
            get 
            {
                return microfossiliferous;
            }
        }

        private readonly static QualifierType microfossils;
        /// <summary>
        /// Indicates that the associated lithology contains undifferentiated microscopic fossils.
        /// </summary>
        [EnumValueNameAttribute("microfossils")]
        public static QualifierType Microfossils
        {
            get 
            {
                return microfossils;
            }
        }

        private readonly static QualifierType migmatite;
        /// <summary>
        /// Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)
        /// </summary>
        [EnumValueNameAttribute("migmatite")]
        public static QualifierType Migmatite
        {
            get 
            {
                return migmatite;
            }
        }

        private readonly static QualifierType migmatitic;
        /// <summary>
        /// VARIANT. See "migmatite".
        /// </summary>
        [EnumValueNameAttribute("migmatitic")]
        public static QualifierType Migmatitic
        {
            get 
            {
                return migmatitic;
            }
        }

        private readonly static QualifierType monzogabbro;
        /// <summary>
        /// Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("monzogabbro")]
        public static QualifierType Monzogabbro
        {
            get 
            {
                return monzogabbro;
            }
        }

        private readonly static QualifierType monzogabbroic;
        /// <summary>
        /// VARIANT. See "monzogabbro".
        /// </summary>
        [EnumValueNameAttribute("monzogabbroic")]
        public static QualifierType Monzogabbroic
        {
            get 
            {
                return monzogabbroic;
            }
        }

        private readonly static QualifierType mud;
        /// <summary>
        /// Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("mud")]
        public static QualifierType Mud
        {
            get 
            {
                return mud;
            }
        }

        private readonly static QualifierType muddy;
        /// <summary>
        /// VARIANT. See "mud".
        /// </summary>
        [EnumValueNameAttribute("muddy")]
        public static QualifierType Muddy
        {
            get 
            {
                return muddy;
            }
        }

        private readonly static QualifierType mudstone;
        /// <summary>
        /// Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth &amp; Knox 1999; extrapolated from Folk, 1954, Figure 1a.
        /// </summary>
        [EnumValueNameAttribute("mudstone")]
        public static QualifierType Mudstone
        {
            get 
            {
                return mudstone;
            }
        }

        private readonly static QualifierType myloniticRock;
        /// <summary>
        /// Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak &amp; Mitra 1988.
        /// </summary>
        [EnumValueNameAttribute("mylonitic rock")]
        public static QualifierType MyloniticRock
        {
            get 
            {
                return myloniticRock;
            }
        }

        private readonly static QualifierType noDescription;
        /// <summary>
        /// DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?.
        /// </summary>
        [EnumValueNameAttribute("no description")]
        public static QualifierType NoDescription
        {
            get 
            {
                return noDescription;
            }
        }

        private readonly static QualifierType noSample;
        /// <summary>
        /// A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML.
        /// </summary>
        [EnumValueNameAttribute("no sample")]
        public static QualifierType NoSample
        {
            get 
            {
                return noSample;
            }
        }

        private readonly static QualifierType none;
        /// <summary>
        /// DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?.
        /// </summary>
        [EnumValueNameAttribute("none")]
        public static QualifierType None
        {
            get 
            {
                return none;
            }
        }

        private readonly static QualifierType oncolite;
        /// <summary>
        /// Indicates that the associated lithology is largely composed of oncoliths (oncoids).
        /// </summary>
        [EnumValueNameAttribute("oncolite")]
        public static QualifierType Oncolite
        {
            get 
            {
                return oncolite;
            }
        }

        private readonly static QualifierType oncolith;
        /// <summary>
        /// DEPRECATED. See oncoliths.
        /// </summary>
        [EnumValueNameAttribute("oncolith")]
        public static QualifierType Oncolith
        {
            get 
            {
                return oncolith;
            }
        }

        private readonly static QualifierType oncolithic;
        /// <summary>
        /// DEPRECATED. See oncoliths.
        /// </summary>
        [EnumValueNameAttribute("oncolithic")]
        public static QualifierType Oncolithic
        {
            get 
            {
                return oncolithic;
            }
        }

        private readonly static QualifierType oncoliths;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of oncoliths (oncoids), a type of carbonate-coated grain with irregular laminae.
        /// </summary>
        [EnumValueNameAttribute("oncoliths")]
        public static QualifierType Oncoliths
        {
            get 
            {
                return oncoliths;
            }
        }

        private readonly static QualifierType oncolitic;
        /// <summary>
        /// VARIANT. See "oncoliths".
        /// </summary>
        [EnumValueNameAttribute("oncolitic")]
        public static QualifierType Oncolitic
        {
            get 
            {
                return oncolitic;
            }
        }

        private readonly static QualifierType ooidOrOolith;
        /// <summary>
        /// DEPRECATED. See ooids.
        /// </summary>
        [EnumValueNameAttribute("ooid or oolith")]
        public static QualifierType OoidOrOolith
        {
            get 
            {
                return ooidOrOolith;
            }
        }

        private readonly static QualifierType ooids;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of ooids (ooliths), small round grains consisting of calcium carbonate, silica, or dolomite.
        /// </summary>
        [EnumValueNameAttribute("ooids")]
        public static QualifierType Ooids
        {
            get 
            {
                return ooids;
            }
        }

        private readonly static QualifierType ooliths;
        /// <summary>
        /// VARIANT. See "ooids".
        /// </summary>
        [EnumValueNameAttribute("ooliths")]
        public static QualifierType Ooliths
        {
            get 
            {
                return ooliths;
            }
        }

        private readonly static QualifierType oolitic;
        /// <summary>
        /// VARIANT. See "ooids".
        /// </summary>
        [EnumValueNameAttribute("oolitic")]
        public static QualifierType Oolitic
        {
            get 
            {
                return oolitic;
            }
        }

        private readonly static QualifierType ooze;
        /// <summary>
        /// Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 &amp; Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("ooze")]
        public static QualifierType Ooze
        {
            get 
            {
                return ooze;
            }
        }

        private readonly static QualifierType ophiolite;
        /// <summary>
        /// Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust.
        /// </summary>
        [EnumValueNameAttribute("ophiolite")]
        public static QualifierType Ophiolite
        {
            get 
            {
                return ophiolite;
            }
        }

        private readonly static QualifierType ophiolitic;
        /// <summary>
        /// VARIANT. See "ophiolite".
        /// </summary>
        [EnumValueNameAttribute("ophiolitic")]
        public static QualifierType Ophiolitic
        {
            get 
            {
                return ophiolitic;
            }
        }

        private readonly static QualifierType organicBearingMudstone;
        /// <summary>
        /// Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;
        /// </summary>
        [EnumValueNameAttribute("organic bearing mudstone")]
        public static QualifierType OrganicBearingMudstone
        {
            get 
            {
                return organicBearingMudstone;
            }
        }

        private readonly static QualifierType ostracodal;
        /// <summary>
        /// VARIANT. See "ostracods".
        /// </summary>
        [EnumValueNameAttribute("ostracodal")]
        public static QualifierType Ostracodal
        {
            get 
            {
                return ostracodal;
            }
        }

        private readonly static QualifierType ostracods;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling ostracod (Cambrian - Recent) fossils.
        /// </summary>
        [EnumValueNameAttribute("ostracods")]
        public static QualifierType Ostracods
        {
            get 
            {
                return ostracods;
            }
        }

        private readonly static QualifierType peat;
        /// <summary>
        /// Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("peat")]
        public static QualifierType Peat
        {
            get 
            {
                return peat;
            }
        }

        private readonly static QualifierType peaty;
        /// <summary>
        /// VARIANT. See "peat".
        /// </summary>
        [EnumValueNameAttribute("peaty")]
        public static QualifierType Peaty
        {
            get 
            {
                return peaty;
            }
        }

        private readonly static QualifierType pebble;
        /// <summary>
        /// Indicates that the associated lithology contains rounded rock fragments in the size range of 2mm - 64mm.
        /// </summary>
        [EnumValueNameAttribute("pebble")]
        public static QualifierType Pebble
        {
            get 
            {
                return pebble;
            }
        }

        private readonly static QualifierType pebbly;
        /// <summary>
        /// VARIANT. See "pebble".
        /// </summary>
        [EnumValueNameAttribute("pebbly")]
        public static QualifierType Pebbly
        {
            get 
            {
                return pebbly;
            }
        }

        private readonly static QualifierType pegmatite;
        /// <summary>
        /// Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("pegmatite")]
        public static QualifierType Pegmatite
        {
            get 
            {
                return pegmatite;
            }
        }

        private readonly static QualifierType pegmatitic;
        /// <summary>
        /// VARIANT. See "pegmatite".
        /// </summary>
        [EnumValueNameAttribute("pegmatitic")]
        public static QualifierType Pegmatitic
        {
            get 
            {
                return pegmatitic;
            }
        }

        private readonly static QualifierType pellet;
        /// <summary>
        /// DEPRECATED. See pellets.
        /// </summary>
        [EnumValueNameAttribute("pellet")]
        public static QualifierType Pellet
        {
            get 
            {
                return pellet;
            }
        }

        private readonly static QualifierType pelletal;
        /// <summary>
        /// VARIANT. See "pellets".
        /// </summary>
        [EnumValueNameAttribute("pelletal")]
        public static QualifierType Pelletal
        {
            get 
            {
                return pelletal;
            }
        }

        private readonly static QualifierType pellets;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of small ovoid or spherical particles of microcrystalline calcite, in the size range 0.03mm - 0.15mm.
        /// </summary>
        [EnumValueNameAttribute("pellets")]
        public static QualifierType Pellets
        {
            get 
            {
                return pellets;
            }
        }

        private readonly static QualifierType peloid;
        /// <summary>
        /// DEPRECATED. See peloids.
        /// </summary>
        [EnumValueNameAttribute("peloid")]
        public static QualifierType Peloid
        {
            get 
            {
                return peloid;
            }
        }

        private readonly static QualifierType peloidal;
        /// <summary>
        /// VARIANT. See "peloids".
        /// </summary>
        [EnumValueNameAttribute("peloidal")]
        public static QualifierType Peloidal
        {
            get 
            {
                return peloidal;
            }
        }

        private readonly static QualifierType peloids;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of sand-size grains of carbonate mud.
        /// </summary>
        [EnumValueNameAttribute("peloids")]
        public static QualifierType Peloids
        {
            get 
            {
                return peloids;
            }
        }

        private readonly static QualifierType peridotite;
        /// <summary>
        /// Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("peridotite")]
        public static QualifierType Peridotite
        {
            get 
            {
                return peridotite;
            }
        }

        private readonly static QualifierType peridotitic;
        /// <summary>
        /// VARIANT. See "peridotite".
        /// </summary>
        [EnumValueNameAttribute("peridotitic")]
        public static QualifierType Peridotitic
        {
            get 
            {
                return peridotitic;
            }
        }

        private readonly static QualifierType phaneriticIgneousRock;
        /// <summary>
        /// Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("phaneritic igneous rock")]
        public static QualifierType PhaneriticIgneousRock
        {
            get 
            {
                return phaneriticIgneousRock;
            }
        }

        private readonly static QualifierType phonolite;
        /// <summary>
        /// Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolite")]
        public static QualifierType Phonolite
        {
            get 
            {
                return phonolite;
            }
        }

        private readonly static QualifierType phonolitic;
        /// <summary>
        /// VARIANT. See "phonolite".
        /// </summary>
        [EnumValueNameAttribute("phonolitic")]
        public static QualifierType Phonolitic
        {
            get 
            {
                return phonolitic;
            }
        }

        private readonly static QualifierType phonolitoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolitoid")]
        public static QualifierType Phonolitoid
        {
            get 
            {
                return phonolitoid;
            }
        }

        private readonly static QualifierType phosphate;
        /// <summary>
        /// Indicates that the associated lithology contains phosphates.
        /// </summary>
        [EnumValueNameAttribute("phosphate")]
        public static QualifierType Phosphate
        {
            get 
            {
                return phosphate;
            }
        }

        private readonly static QualifierType phosphateRock;
        /// <summary>
        /// Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource.
        /// </summary>
        [EnumValueNameAttribute("phosphate rock")]
        public static QualifierType PhosphateRock
        {
            get 
            {
                return phosphateRock;
            }
        }

        private readonly static QualifierType phosphatic;
        /// <summary>
        /// VARIANT. See "phosphate".
        /// </summary>
        [EnumValueNameAttribute("phosphatic")]
        public static QualifierType Phosphatic
        {
            get 
            {
                return phosphatic;
            }
        }

        private readonly static QualifierType phyllite;
        /// <summary>
        /// Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007.
        /// </summary>
        [EnumValueNameAttribute("phyllite")]
        public static QualifierType Phyllite
        {
            get 
            {
                return phyllite;
            }
        }

        private readonly static QualifierType phyllitic;
        /// <summary>
        /// VARIANT. See "phyllite".
        /// </summary>
        [EnumValueNameAttribute("phyllitic")]
        public static QualifierType Phyllitic
        {
            get 
            {
                return phyllitic;
            }
        }

        private readonly static QualifierType pisolite;
        /// <summary>
        /// Indicates that the associated lithology is composed largely of pisoliths (pisoids).
        /// </summary>
        [EnumValueNameAttribute("pisolite")]
        public static QualifierType Pisolite
        {
            get 
            {
                return pisolite;
            }
        }

        private readonly static QualifierType pisolith;
        /// <summary>
        /// DEPRECATED. See pisoliths.
        /// </summary>
        [EnumValueNameAttribute("pisolith")]
        public static QualifierType Pisolith
        {
            get 
            {
                return pisolith;
            }
        }

        private readonly static QualifierType pisoliths;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of sub-spherical usually carbonate coated grains, of diameter greater than 2mm.
        /// </summary>
        [EnumValueNameAttribute("pisoliths")]
        public static QualifierType Pisoliths
        {
            get 
            {
                return pisoliths;
            }
        }

        private readonly static QualifierType pisolitic;
        /// <summary>
        /// VARIANT. See "pisolite".
        /// </summary>
        [EnumValueNameAttribute("pisolitic")]
        public static QualifierType Pisolitic
        {
            get 
            {
                return pisolitic;
            }
        }

        private readonly static QualifierType plantRemains;
        /// <summary>
        /// Indicates that the associated lithology contains remains of a probable botanical origin.
        /// </summary>
        [EnumValueNameAttribute("plant remains")]
        public static QualifierType PlantRemains
        {
            get 
            {
                return plantRemains;
            }
        }

        private readonly static QualifierType porphyritic;
        /// <summary>
        /// VARIANT. See "porphyry".
        /// </summary>
        [EnumValueNameAttribute("porphyritic")]
        public static QualifierType Porphyritic
        {
            get 
            {
                return porphyritic;
            }
        }

        private readonly static QualifierType porphyry;
        /// <summary>
        /// Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("porphyry")]
        public static QualifierType Porphyry
        {
            get 
            {
                return porphyry;
            }
        }

        private readonly static QualifierType potassiumAndMagnesiumSalts;
        /// <summary>
        /// Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML.
        /// </summary>
        [EnumValueNameAttribute("potassium and magnesium salts")]
        public static QualifierType PotassiumAndMagnesiumSalts
        {
            get 
            {
                return potassiumAndMagnesiumSalts;
            }
        }

        private readonly static QualifierType pyrite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling the sulphide mineral of iron (FeS2).
        /// </summary>
        [EnumValueNameAttribute("pyrite")]
        public static QualifierType Pyrite
        {
            get 
            {
                return pyrite;
            }
        }

        private readonly static QualifierType pyritic;
        /// <summary>
        /// VARIANT. See "pyrite".
        /// </summary>
        [EnumValueNameAttribute("pyritic")]
        public static QualifierType Pyritic
        {
            get 
            {
                return pyritic;
            }
        }

        private readonly static QualifierType pyroclasticBreccia;
        /// <summary>
        /// Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic breccia")]
        public static QualifierType PyroclasticBreccia
        {
            get 
            {
                return pyroclasticBreccia;
            }
        }

        private readonly static QualifierType pyroclasticRock;
        /// <summary>
        /// Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic rock")]
        public static QualifierType PyroclasticRock
        {
            get 
            {
                return pyroclasticRock;
            }
        }

        private readonly static QualifierType pyroxenite;
        /// <summary>
        /// Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroxenite")]
        public static QualifierType Pyroxenite
        {
            get 
            {
                return pyroxenite;
            }
        }

        private readonly static QualifierType pyroxenitic;
        /// <summary>
        /// VARIANT. See "pyroxenite".
        /// </summary>
        [EnumValueNameAttribute("pyroxenitic")]
        public static QualifierType Pyroxenitic
        {
            get 
            {
                return pyroxenitic;
            }
        }

        private readonly static QualifierType quartiferous;
        /// <summary>
        /// VARIANT. See "quartz".
        /// </summary>
        [EnumValueNameAttribute("quartiferous")]
        public static QualifierType Quartiferous
        {
            get 
            {
                return quartiferous;
            }
        }

        private readonly static QualifierType quartz;
        /// <summary>
        /// Indicates that the associated lithology comprises (crystalline) material containing or resembling the common silica mineral quartz (SiO2).
        /// </summary>
        [EnumValueNameAttribute("quartz")]
        public static QualifierType Quartz
        {
            get 
            {
                return quartz;
            }
        }

        private readonly static QualifierType quartzArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("quartz arenite")]
        public static QualifierType QuartzArenite
        {
            get 
            {
                return quartzArenite;
            }
        }

        private readonly static QualifierType quartzite;
        /// <summary>
        /// Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("quartzite")]
        public static QualifierType Quartzite
        {
            get 
            {
                return quartzite;
            }
        }

        private readonly static QualifierType quartzitic;
        /// <summary>
        /// VARIANT. See "quartzite".
        /// </summary>
        [EnumValueNameAttribute("quartzitic")]
        public static QualifierType Quartzitic
        {
            get 
            {
                return quartzitic;
            }
        }

        private readonly static QualifierType radiolaria;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling fossils of the marine protozoan order of Radiolaria (Cambrian - Recent), generally with endoskeletons of opaline silica.
        /// </summary>
        [EnumValueNameAttribute("radiolaria")]
        public static QualifierType Radiolaria
        {
            get 
            {
                return radiolaria;
            }
        }

        private readonly static QualifierType radiolarian;
        /// <summary>
        /// VARIANT. See "radiolaria".
        /// </summary>
        [EnumValueNameAttribute("radiolarian")]
        public static QualifierType Radiolarian
        {
            get 
            {
                return radiolarian;
            }
        }

        private readonly static QualifierType rhyolite;
        /// <summary>
        /// rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("rhyolite")]
        public static QualifierType Rhyolite
        {
            get 
            {
                return rhyolite;
            }
        }

        private readonly static QualifierType rhyolitic;
        /// <summary>
        /// VARIANT. See "rhyolite".
        /// </summary>
        [EnumValueNameAttribute("rhyolitic")]
        public static QualifierType Rhyolitic
        {
            get 
            {
                return rhyolitic;
            }
        }

        private readonly static QualifierType rockSalt;
        /// <summary>
        /// Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("rock salt")]
        public static QualifierType RockSalt
        {
            get 
            {
                return rockSalt;
            }
        }

        private readonly static QualifierType rootlets;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling plant roots, or structures (rhizoliths) resulting from the mineralization of plant roots by accumulation/cementation or replacement.
        /// </summary>
        [EnumValueNameAttribute("rootlets")]
        public static QualifierType Rootlets
        {
            get 
            {
                return rootlets;
            }
        }

        private readonly static QualifierType salty;
        /// <summary>
        /// VARIANT. See "rock salt".
        /// </summary>
        [EnumValueNameAttribute("salty")]
        public static QualifierType Salty
        {
            get 
            {
                return salty;
            }
        }

        private readonly static QualifierType sand;
        /// <summary>
        /// Indicates that the associated lithology comprises (crystalline) material containing or resembling mineral or rock grains of diameter in the range of 0.625mm - 2mm.
        /// </summary>
        [EnumValueNameAttribute("sand")]
        public static QualifierType Sand
        {
            get 
            {
                return sand;
            }
        }

        private readonly static QualifierType sandstone;
        /// <summary>
        /// Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("sandstone")]
        public static QualifierType Sandstone
        {
            get 
            {
                return sandstone;
            }
        }

        private readonly static QualifierType sandy;
        /// <summary>
        /// VARIANT. See "sand".
        /// </summary>
        [EnumValueNameAttribute("sandy")]
        public static QualifierType Sandy
        {
            get 
            {
                return sandy;
            }
        }

        private readonly static QualifierType sapropel;
        /// <summary>
        /// Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("sapropel")]
        public static QualifierType Sapropel
        {
            get 
            {
                return sapropel;
            }
        }

        private readonly static QualifierType sapropelic;
        /// <summary>
        /// VARIANT. See "sapropel".
        /// </summary>
        [EnumValueNameAttribute("sapropelic")]
        public static QualifierType Sapropelic
        {
            get 
            {
                return sapropelic;
            }
        }

        private readonly static QualifierType schist;
        /// <summary>
        /// Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("schist")]
        public static QualifierType Schist
        {
            get 
            {
                return schist;
            }
        }

        private readonly static QualifierType schisty;
        /// <summary>
        /// VARIANT. See "schist".
        /// </summary>
        [EnumValueNameAttribute("schisty")]
        public static QualifierType Schisty
        {
            get 
            {
                return schisty;
            }
        }

        private readonly static QualifierType sepentinitic;
        /// <summary>
        /// VARIANT. See "serpentinite".
        /// </summary>
        [EnumValueNameAttribute("sepentinitic")]
        public static QualifierType Sepentinitic
        {
            get 
            {
                return sepentinitic;
            }
        }

        private readonly static QualifierType serpentinite;
        /// <summary>
        /// Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("serpentinite")]
        public static QualifierType Serpentinite
        {
            get 
            {
                return serpentinite;
            }
        }

        private readonly static QualifierType shale;
        /// <summary>
        /// Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically.
        /// </summary>
        [EnumValueNameAttribute("shale")]
        public static QualifierType Shale
        {
            get 
            {
                return shale;
            }
        }

        private readonly static QualifierType shaly;
        /// <summary>
        /// VARIANT. See "shale".
        /// </summary>
        [EnumValueNameAttribute("shaly")]
        public static QualifierType Shaly
        {
            get 
            {
                return shaly;
            }
        }

        private readonly static QualifierType shell;
        /// <summary>
        /// DEPRECATED. See "shell fragments".
        /// </summary>
        [EnumValueNameAttribute("shell")]
        public static QualifierType Shell
        {
            get 
            {
                return shell;
            }
        }

        private readonly static QualifierType shellFragments;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling shells (generally bivalves) or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("shell fragments")]
        public static QualifierType ShellFragments
        {
            get 
            {
                return shellFragments;
            }
        }

        private readonly static QualifierType shelly;
        /// <summary>
        /// VARIANT. See "shell fragments".
        /// </summary>
        [EnumValueNameAttribute("shelly")]
        public static QualifierType Shelly
        {
            get 
            {
                return shelly;
            }
        }

        private readonly static QualifierType siderite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling siderite (spathic iron), a carbonate mineral of iron (FeCO3).
        /// </summary>
        [EnumValueNameAttribute("siderite")]
        public static QualifierType Siderite
        {
            get 
            {
                return siderite;
            }
        }

        private readonly static QualifierType sideriteConcretion;
        /// <summary>
        /// Indicates that the associated lithology contains rounded masses comprised of the mineral siderite (spathic iron), a carbonate mineral of iron (FeCO3).
        /// </summary>
        [EnumValueNameAttribute("siderite concretion")]
        public static QualifierType SideriteConcretion
        {
            get 
            {
                return sideriteConcretion;
            }
        }

        private readonly static QualifierType sideritic;
        /// <summary>
        /// VARIANT. See "siderite".
        /// </summary>
        [EnumValueNameAttribute("sideritic")]
        public static QualifierType Sideritic
        {
            get 
            {
                return sideritic;
            }
        }

        private readonly static QualifierType siliceousOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siliceous ooze")]
        public static QualifierType SiliceousOoze
        {
            get 
            {
                return siliceousOoze;
            }
        }

        private readonly static QualifierType silt;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material of very fine particles intermediate in size between clay and sand (0.0625mm - 2mm).
        /// </summary>
        [EnumValueNameAttribute("silt")]
        public static QualifierType Silt
        {
            get 
            {
                return silt;
            }
        }

        private readonly static QualifierType siltstone;
        /// <summary>
        /// Mudstone that contains detectable silt. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siltstone")]
        public static QualifierType Siltstone
        {
            get 
            {
                return siltstone;
            }
        }

        private readonly static QualifierType silty;
        /// <summary>
        /// VARIANT. See "silt".
        /// </summary>
        [EnumValueNameAttribute("silty")]
        public static QualifierType Silty
        {
            get 
            {
                return silty;
            }
        }

        private readonly static QualifierType skarn;
        /// <summary>
        /// Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195.
        /// </summary>
        [EnumValueNameAttribute("skarn")]
        public static QualifierType Skarn
        {
            get 
            {
                return skarn;
            }
        }

        private readonly static QualifierType skarny;
        /// <summary>
        /// VARIANT. See "skarn".
        /// </summary>
        [EnumValueNameAttribute("skarny")]
        public static QualifierType Skarny
        {
            get 
            {
                return skarny;
            }
        }

        private readonly static QualifierType slate;
        /// <summary>
        /// Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("slate")]
        public static QualifierType Slate
        {
            get 
            {
                return slate;
            }
        }

        private readonly static QualifierType slaty;
        /// <summary>
        /// VARIANT. See "slate".
        /// </summary>
        [EnumValueNameAttribute("slaty")]
        public static QualifierType Slaty
        {
            get 
            {
                return slaty;
            }
        }

        private readonly static QualifierType smectite;
        /// <summary>
        /// A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples.
        /// </summary>
        [EnumValueNameAttribute("smectite")]
        public static QualifierType Smectite
        {
            get 
            {
                return smectite;
            }
        }

        private readonly static QualifierType smectitic;
        /// <summary>
        /// VARIANT. See "smectite".
        /// </summary>
        [EnumValueNameAttribute("smectitic")]
        public static QualifierType Smectitic
        {
            get 
            {
                return smectitic;
            }
        }

        private readonly static QualifierType spicular;
        /// <summary>
        /// VARIANT. See "spicules".
        /// </summary>
        [EnumValueNameAttribute("spicular")]
        public static QualifierType Spicular
        {
            get 
            {
                return spicular;
            }
        }

        private readonly static QualifierType spicule;
        /// <summary>
        /// DEPRECATED. See spicules.
        /// </summary>
        [EnumValueNameAttribute("spicule")]
        public static QualifierType Spicule
        {
            get 
            {
                return spicule;
            }
        }

        private readonly static QualifierType spicules;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling minute needle-like structures of silica or carbonate, such as that supporting the soft tissue of certain invertebrates, especially sponges.
        /// </summary>
        [EnumValueNameAttribute("spicules")]
        public static QualifierType Spicules
        {
            get 
            {
                return spicules;
            }
        }

        private readonly static QualifierType spilite;
        /// <summary>
        /// Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619.
        /// </summary>
        [EnumValueNameAttribute("spilite")]
        public static QualifierType Spilite
        {
            get 
            {
                return spilite;
            }
        }

        private readonly static QualifierType spilitic;
        /// <summary>
        /// VARIANT. See "spilite".
        /// </summary>
        [EnumValueNameAttribute("spilitic")]
        public static QualifierType Spilitic
        {
            get 
            {
                return spilitic;
            }
        }

        private readonly static QualifierType stylolite;
        /// <summary>
        /// DEPRECATED. See stylolites.
        /// </summary>
        [EnumValueNameAttribute("stylolite")]
        public static QualifierType Stylolite
        {
            get 
            {
                return stylolite;
            }
        }

        private readonly static QualifierType stylolites;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a contact zone surface between two adjacent calcareous rocks, along which dissolution by pressure solution has ocurred and appearing in cross section as a series of jagged interlocking up-and-down projections (of insoluble clay minerals) that resemble a suture.
        /// </summary>
        [EnumValueNameAttribute("stylolites")]
        public static QualifierType Stylolites
        {
            get 
            {
                return stylolites;
            }
        }

        private readonly static QualifierType stylolitic;
        /// <summary>
        /// VARIANT. See "stylolites".
        /// </summary>
        [EnumValueNameAttribute("stylolitic")]
        public static QualifierType Stylolitic
        {
            get 
            {
                return stylolitic;
            }
        }

        private readonly static QualifierType syenite;
        /// <summary>
        /// Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz.
        /// </summary>
        [EnumValueNameAttribute("syenite")]
        public static QualifierType Syenite
        {
            get 
            {
                return syenite;
            }
        }

        private readonly static QualifierType syenitic;
        /// <summary>
        /// VARIANT. See "syenite".
        /// </summary>
        [EnumValueNameAttribute("syenitic")]
        public static QualifierType Syenitic
        {
            get 
            {
                return syenitic;
            }
        }

        private readonly static QualifierType syenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("syenitoid")]
        public static QualifierType Syenitoid
        {
            get 
            {
                return syenitoid;
            }
        }

        private readonly static QualifierType sylvite;
        /// <summary>
        /// Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology.
        /// </summary>
        [EnumValueNameAttribute("sylvite")]
        public static QualifierType Sylvite
        {
            get 
            {
                return sylvite;
            }
        }

        private readonly static QualifierType sylvitic;
        /// <summary>
        /// VARIANT. See "sylvite".
        /// </summary>
        [EnumValueNameAttribute("sylvitic")]
        public static QualifierType Sylvitic
        {
            get 
            {
                return sylvitic;
            }
        }

        private readonly static QualifierType tarry;
        /// <summary>
        /// VARIANT. See "bitumen".
        /// </summary>
        [EnumValueNameAttribute("tarry")]
        public static QualifierType Tarry
        {
            get 
            {
                return tarry;
            }
        }

        private readonly static QualifierType tephrite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephrite")]
        public static QualifierType Tephrite
        {
            get 
            {
                return tephrite;
            }
        }

        private readonly static QualifierType tephritic;
        /// <summary>
        /// VARIANT. See "tephrite".
        /// </summary>
        [EnumValueNameAttribute("tephritic")]
        public static QualifierType Tephritic
        {
            get 
            {
                return tephritic;
            }
        }

        private readonly static QualifierType tephritoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephritoid")]
        public static QualifierType Tephritoid
        {
            get 
            {
                return tephritoid;
            }
        }

        private readonly static QualifierType tholeiiticBasalt;
        /// <summary>
        /// Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("tholeiitic basalt")]
        public static QualifierType TholeiiticBasalt
        {
            get 
            {
                return tholeiiticBasalt;
            }
        }

        private readonly static QualifierType tonalite;
        /// <summary>
        /// Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tonalite")]
        public static QualifierType Tonalite
        {
            get 
            {
                return tonalite;
            }
        }

        private readonly static QualifierType tonalitic;
        /// <summary>
        /// VARIANT. See "tonalite".
        /// </summary>
        [EnumValueNameAttribute("tonalitic")]
        public static QualifierType Tonalitic
        {
            get 
            {
                return tonalitic;
            }
        }

        private readonly static QualifierType trachyte;
        /// <summary>
        /// A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals.
        /// </summary>
        [EnumValueNameAttribute("trachyte")]
        public static QualifierType Trachyte
        {
            get 
            {
                return trachyte;
            }
        }

        private readonly static QualifierType trachytic;
        /// <summary>
        /// VARIANT. See "trachyte".
        /// </summary>
        [EnumValueNameAttribute("trachytic")]
        public static QualifierType Trachytic
        {
            get 
            {
                return trachytic;
            }
        }

        private readonly static QualifierType trachyticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytic rock")]
        public static QualifierType TrachyticRock
        {
            get 
            {
                return trachyticRock;
            }
        }

        private readonly static QualifierType trachytoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytoid")]
        public static QualifierType Trachytoid
        {
            get 
            {
                return trachytoid;
            }
        }

        private readonly static QualifierType travertine;
        /// <summary>
        /// Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74.
        /// </summary>
        [EnumValueNameAttribute("travertine")]
        public static QualifierType Travertine
        {
            get 
            {
                return travertine;
            }
        }

        private readonly static QualifierType tuff;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling pyroclastic detrital material (volcanic ash).
        /// </summary>
        [EnumValueNameAttribute("tuff")]
        public static QualifierType Tuff
        {
            get 
            {
                return tuff;
            }
        }

        private readonly static QualifierType tuffaceous;
        /// <summary>
        /// VARIANT. See "tuff".
        /// </summary>
        [EnumValueNameAttribute("tuffaceous")]
        public static QualifierType Tuffaceous
        {
            get 
            {
                return tuffaceous;
            }
        }

        private readonly static QualifierType tuffite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a fine grained matrix of volcanic breccia with intruded grains of fluidized sediment.
        /// </summary>
        [EnumValueNameAttribute("tuffite")]
        public static QualifierType Tuffite
        {
            get 
            {
                return tuffite;
            }
        }

        private readonly static QualifierType tuffitic;
        /// <summary>
        /// VARIANT. See "tuffite".
        /// </summary>
        [EnumValueNameAttribute("tuffitic")]
        public static QualifierType Tuffitic
        {
            get 
            {
                return tuffitic;
            }
        }

        private readonly static QualifierType ultrabasic;
        /// <summary>
        /// A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%.
        /// </summary>
        [EnumValueNameAttribute("ultrabasic")]
        public static QualifierType Ultrabasic
        {
            get 
            {
                return ultrabasic;
            }
        }

        private readonly static QualifierType undifferentiated;
        /// <summary>
        /// The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent.
        /// </summary>
        [EnumValueNameAttribute("undifferentiated")]
        public static QualifierType Undifferentiated
        {
            get 
            {
                return undifferentiated;
            }
        }

        private readonly static QualifierType wacke;
        /// <summary>
        /// Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p.
        /// </summary>
        [EnumValueNameAttribute("wacke")]
        public static QualifierType Wacke
        {
            get 
            {
                return wacke;
            }
        }

        private readonly static QualifierType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static QualifierType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static QualifierType()
        {
            alkaliFeldsparRhyolite = 
                new QualifierType("alkali feldspar rhyolite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            alkaliOlivineBasalt = 
                new QualifierType("alkali olivine basalt")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43."
                    ,Version = "1.4.1.0"
            };
            amphibolite = 
                new QualifierType("amphibolite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8."
                    ,Version = "1.4.1.0"
            };
            amphibolitic = 
                new QualifierType("amphibolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "amphibolite"
                    ,Description = "VARIANT. See \"amphibolite\"."
                    ,Version = "1.4.1.0"
            };
            andesite = 
                new QualifierType("andesite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            andesitic = 
                new QualifierType("andesitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "andesite"
                    ,Description = "VARIANT. See \"andesite\"."
                    ,Version = "1.4.1.0"
            };
            anhydrite = 
                new QualifierType("anhydrite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology contains or resembles the evaporite mineral anhydrite (CaSO4)."
                    ,Version = "1.4.0.0"
            };
            anhydritic = 
                new QualifierType("anhydritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "anhydrite"
                    ,Description = "VARIANT. See \"anhydrite\"."
                    ,Version = "1.3.1.0"
            };
            ankerite = 
                new QualifierType("ankerite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),"
                    ,Version = "1.4.1.0"
            };
            ankeritic = 
                new QualifierType("ankeritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "ankerite"
                    ,Description = "VARIANT. See \"ankerite\"."
                    ,Version = "1.4.1.0"
            };
            anorthositicRock = 
                new QualifierType("anorthositic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            anthracite = 
                new QualifierType("anthracite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005"
                    ,Version = "1.4.1.0"
            };
            anthracitic = 
                new QualifierType("anthracitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "anthracite"
                    ,Description = "VARIANT. See \"anthracite\"."
                    ,Version = "1.4.1.0"
            };
            aplite = 
                new QualifierType("aplite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            aplitic = 
                new QualifierType("aplitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "aplite"
                    ,Description = "VARIANT. See \"aplite\"."
                    ,Version = "1.4.1.0"
            };
            arenite = 
                new QualifierType("arenite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite."
                    ,Version = "1.4.1.0"
            };
            arenitic = 
                new QualifierType("arenitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "arenite"
                    ,Description = "VARIANT. See \"arenite\"."
                    ,Version = "1.4.1.0"
            };
            argillaceous = 
                new QualifierType("argillaceous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "clay"
                    ,Description = "VARIANT. See \"clay\"."
                    ,Version = "1.3.1.0"
            };
            arkose = 
                new QualifierType("arkose")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%)."
                    ,Version = "1.4.1.0"
            };
            arkosic = 
                new QualifierType("arkosic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "arkose"
                    ,Description = "VARIANT. See \"arkose\"."
                    ,Version = "1.4.1.0"
            };
            barite = 
                new QualifierType("barite")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains the mineral barite [baryte] (BaSO4)."
                    ,Version = "1.3.1.0"
            };
            baritic = 
                new QualifierType("baritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "barite"
                    ,Description = "VARIANT. See \"barite\"."
                    ,Version = "1.4.0.0"
            };
            basalt = 
                new QualifierType("basalt")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            basaltic = 
                new QualifierType("basaltic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "basalt"
                    ,Description = "VARIANT. See \"basalt\"."
                    ,Version = "1.4.1.0"
            };
            basanite = 
                new QualifierType("basanite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            basanitic = 
                new QualifierType("basanitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "basanite"
                    ,Description = "VARIANT. See \"basanite\"."
                    ,Version = "1.4.1.0"
            };
            bauxite = 
                new QualifierType("bauxite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001."
                    ,Version = "1.4.1.0"
            };
            bauxitic = 
                new QualifierType("bauxitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "bauxite"
                    ,Description = "VARIANT. See \"bauxite\"."
                    ,Version = "1.4.1.0"
            };
            belemnites = 
                new QualifierType("belemnites")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains belemnite (Carboniferous - Eocene) fossils or fragments thereof."
                    ,Version = "1.4.0.0"
            };
            belemnitic = 
                new QualifierType("belemnitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "belemnites"
                    ,Description = "VARIANT. See \"belemnites\"."
                    ,Version = "1.3.1.0"
            };
            bioturbated = 
                new QualifierType("bioturbated")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "bioturbation"
                    ,Description = "VARIANT. See \"bioturbation\"."
                    ,Version = "1.3.1.0"
            };
            bioturbation = 
                new QualifierType("bioturbation")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology has been disturbed by the (burrowing) activities of organisms before consolidation of the sediment."
                    ,Version = "1.4.0.0"
            };
            bitumen = 
                new QualifierType("bitumen")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling bitumen (asphalt), pitch or tar."
                    ,Version = "1.4.0.0"
            };
            bituminous = 
                new QualifierType("bituminous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "bitumen"
                    ,Description = "VARIANT. See \"bitumen\"."
                    ,Version = "1.3.1.0"
            };
            bituminousCoal = 
                new QualifierType("bituminous coal")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp."
                    ,Version = "1.4.1.0"
            };
            blueschistMetamorphicRock = 
                new QualifierType("blueschist metamorphic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock"
                    ,Version = "1.4.1.0"
            };
            boninite = 
                new QualifierType("boninite")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            breccia = 
                new QualifierType("breccia")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            brecciated = 
                new QualifierType("brecciated")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "breccia"
                    ,Description = "VARIANT. See \"breccia\"."
                    ,Version = "1.4.1.0"
            };
            bryozoan = 
                new QualifierType("bryozoan")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "bryozoans"
                    ,Description = "VARIANT. See \"bryozoans\"."
                    ,Version = "1.4.0.0"
            };
            bryozoans = 
                new QualifierType("bryozoans")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains or is characteristic of bryozoan (Ordovician - Recent) fossils or fragments thereof."
                    ,Version = "1.3.1.0"
            };
            burrowed = 
                new QualifierType("burrowed")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "burrows"
                    ,Description = "VARIANT. See \"burrows\"."
                    ,Version = "1.3.1.0"
            };
            burrows = 
                new QualifierType("burrows")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation of the sediment."
                    ,Version = "1.4.0.0"
            };
            calcareous = 
                new QualifierType("calcareous")
                {
                    LithoType = EnumValueLithoType.adjective
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or characteristic of calcium carbonate (CaCO3)."
                    ,Version = "1.3.1.0"
            };
            calcite = 
                new QualifierType("calcite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the crystalline form of calcium carbonate (CaCO3)."
                    ,Version = "1.4.0.0"
            };
            calciteConcr = 
                new QualifierType("calcite concr")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See \"calcite concretion\"."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = CalciteConcretion
            };
            calciteConcretion = 
                new QualifierType("calcite concretion")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology contains rounded nodules of crystalline calcium carbonate."
                    ,Version = "1.4.0.0"
            };
            calcitic = 
                new QualifierType("calcitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "calcite"
                    ,Description = "VARIANT. See \"calcite\"."
                    ,Version = "1.4.0.0"
            };
            carbonaceous = 
                new QualifierType("carbonaceous")
                {
                    LithoType = EnumValueLithoType.adjective
                    ,Description = "Indicates that the associated lithology comprises material containing or yielding carbon."
                    ,Version = "1.3.1.0"
            };
            carbonateOoze = 
                new QualifierType("carbonate ooze")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology."
                    ,Version = "1.4.1.0"
            };
            carbonatite = 
                new QualifierType("carbonatite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            carbonatitic = 
                new QualifierType("carbonatitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "carbonatite"
                    ,Description = "VARIANT. See \"carbonatite\"."
                    ,Version = "1.4.1.0"
            };
            chalk = 
                new QualifierType("chalk")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling a soft compact form of calcium carbonate (CaCO3)."
                    ,Version = "1.4.0.0"
            };
            chalky = 
                new QualifierType("chalky")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "chalk"
                    ,Description = "VARIANT. See \"chalk\"."
                    ,Version = "1.3.1.0"
            };
            chamosite = 
                new QualifierType("chamosite")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains or resembles chamosite, a generally greenish-gray or black silicate mineral of iron and aluminium."
                    ,Version = "1.3.1.0"
            };
            chamositic = 
                new QualifierType("chamositic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "chamosite"
                    ,Description = "VARIANT. See \"chamosite\"."
                    ,Version = "1.4.0.0"
            };
            chert = 
                new QualifierType("chert")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology contains or resembles the microcrystalline or cryptocrystalline form of quartz (SiO2)."
                    ,Version = "1.3.1.0"
            };
            cherty = 
                new QualifierType("cherty")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "chert"
                    ,Description = "VARIANT. See \"chert\"."
                    ,Version = "1.4.0.0"
            };
            chlorite = 
                new QualifierType("chlorite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "Indicates that the associated lithology contains or resembles chlorite, a generally green or black flaky phyllosilicate mineral."
                    ,Version = "1.3.1.0"
            };
            chloritic = 
                new QualifierType("chloritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "chlorite"
                    ,Description = "VARIANT. See \"chlorite\"."
                    ,Version = "1.4.0.0"
            };
            clay = 
                new QualifierType("clay")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale."
                    ,Version = "1.4.1.0"
            };
            claystone = 
                new QualifierType("claystone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology."
                    ,Version = "1.4.1.0"
            };
            coal = 
                new QualifierType("coal")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp."
                    ,Version = "1.4.0.0"
            };
            concretionary = 
                new QualifierType("concretionary")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "concretions"
                    ,Description = "VARIANT. See \"concretions\"."
                    ,Version = "1.4.0.0"
            };
            concretions = 
                new QualifierType("concretions")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains rounded masses of mineral material."
                    ,Version = "1.3.1.0"
            };
            conglomerate = 
                new QualifierType("conglomerate")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology contains rounded rock fragments of greater than 20mm in size."
                    ,Version = "1.4.0.0"
            };
            conglomeratic = 
                new QualifierType("conglomeratic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "conglomerate"
                    ,Description = "VARIANT. See \"conglomerate\"."
                    ,Version = "1.3.1.0"
            };
            coral = 
                new QualifierType("coral")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See \"coral fragments\"."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = CoralFragments
            };
            coralFragments = 
                new QualifierType("coral fragments")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains or resembles corals (late Pre-Cambrian - Recent) and/or coral fragments."
                    ,Version = "1.4.0.0"
            };
            coralline = 
                new QualifierType("coralline")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "coral fragments"
                    ,Description = "VARIANT. See \"coral fragments\"."
                    ,Version = "1.4.0.0"
            };
            crinoidal = 
                new QualifierType("crinoidal")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "crinoids"
                    ,Description = "VARIANT. See \"crinoids\"."
                    ,Version = "1.4.0.0"
            };
            crinoids = 
                new QualifierType("crinoids")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains or resembles crinoids (Mid Cambrian - Recent) and/or crinoid fragments."
                    ,Version = "1.3.1.0"
            };
            dacite = 
                new QualifierType("dacite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            dacitic = 
                new QualifierType("dacitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "dacite"
                    ,Description = "VARIANT. See \"dacite\"."
                    ,Version = "1.4.1.0"
            };
            diabase = 
                new QualifierType("diabase")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite."
                    ,Version = "1.4.1.0"
            };
            diabasic = 
                new QualifierType("diabasic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "diabase"
                    ,Description = "VARIANT. See \"diabase\"."
                    ,Version = "1.4.1.0"
            };
            diamictite = 
                new QualifierType("diamictite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978."
                    ,Version = "1.4.1.0"
            };
            diamictitic = 
                new QualifierType("diamictitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "diamictite"
                    ,Description = "VARIANT. See \"diamictite\"."
                    ,Version = "1.4.1.0"
            };
            diatomaceous = 
                new QualifierType("diatomaceous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "diatoms"
                    ,Description = "VARIANT. See \"diatoms\"."
                    ,Version = "1.4.0.0"
            };
            diatoms = 
                new QualifierType("diatoms")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains or resembles diatoms and/or diatom fragments."
                    ,Version = "1.3.1.0"
            };
            diorite = 
                new QualifierType("diorite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite."
                    ,Version = "1.4.1.0"
            };
            dioritic = 
                new QualifierType("dioritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "diorite"
                    ,Description = "VARIANT. See \"diorite\"."
                    ,Version = "1.4.1.0"
            };
            dioritoid = 
                new QualifierType("dioritoid")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            dioritoidic = 
                new QualifierType("dioritoidic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "dioritoid"
                    ,Description = "VARIANT. See \"dioritoid\"."
                    ,Version = "1.4.1.0"
            };
            doleriticRock = 
                new QualifierType("doleritic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            dolomite = 
                new QualifierType("dolomite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,IsMatrixCement = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling a magnesium-rich carbonate mineral of calcium (CaMg(CO3)2)."
                    ,Version = "1.3.1.0"
            };
            dolomiteConcretion = 
                new QualifierType("dolomite concretion")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology has rounded nodules of dolomite (CaMg(CO3)2)."
                    ,Version = "1.3.1.0"
            };
            dolomiteStringer = 
                new QualifierType("dolomite stringer")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology contains thin beds of dolomite (CaMg(CO3)2)."
                    ,Version = "1.3.1.0"
            };
            dolomitic = 
                new QualifierType("dolomitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "dolomite"
                    ,Description = "VARIANT. See \"dolomite\"."
                    ,Version = "1.3.1.0"
            };
            eclogite = 
                new QualifierType("eclogite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007"
                    ,Version = "1.4.1.0"
            };
            eclogitic = 
                new QualifierType("eclogitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "eclogite"
                    ,Description = "VARIANT. See \"eclogite\"."
                    ,Version = "1.4.1.0"
            };
            exoticAlkalineRock = 
                new QualifierType("exotic alkaline rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            feldspar = 
                new QualifierType("feldspar")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the rock-forming aluminosilicate minerals of sodium, potassium or calcium."
                    ,Version = "1.3.1.0"
            };
            feldsparic = 
                new QualifierType("feldsparic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "feldspar"
                    ,Description = "VARIANT. See \"feldspar\"."
                    ,Version = "1.4.0.0"
            };
            feldspathic = 
                new QualifierType("feldspathic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "feldspar"
                    ,Description = "VARIANT. See \"feldspar\"."
                    ,Version = "1.4.0.0"
            };
            feldspathicArenite = 
                new QualifierType("feldspathic arenite")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632."
                    ,Version = "1.4.1.0"
            };
            ferruginous = 
                new QualifierType("ferruginous")
                {
                    LithoType = EnumValueLithoType.adjective
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling minerals rich in iron oxide or iron hydroxide."
                    ,Version = "1.3.1.0"
            };
            fineGrainedIgneousRock = 
                new QualifierType("fine grained igneous rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            fissile = 
                new QualifierType("fissile")
                {
                    LithoType = EnumValueLithoType.unknown
                    ,Description = "DEPRECATED. The term 'fissile' doesn't belong in this list as it is neither qualifier or modifier .... it is a descriptor of 'grain fabric'."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Unknown
            };
            foidDioritoid = 
                new QualifierType("foid dioritoid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidGabbroid = 
                new QualifierType("foid gabbroid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidSyenitoid = 
                new QualifierType("foid syenitoid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidite = 
                new QualifierType("foidite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foiditic = 
                new QualifierType("foiditic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "foidite"
                    ,Description = "VARIANT. See \"foidite\"."
                    ,Version = "1.4.1.0"
            };
            foiditoid = 
                new QualifierType("foiditoid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidolite = 
                new QualifierType("foidolite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            foidolitic = 
                new QualifierType("foidolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "foidolite"
                    ,Description = "VARIANT. See \"foidolite\"."
                    ,Version = "1.4.1.0"
            };
            foliatedMetamorphicRock = 
                new QualifierType("foliated metamorphic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic."
                    ,Version = "1.4.1.0"
            };
            foraminifera = 
                new QualifierType("foraminifera")
                {
                    LithoType = EnumValueLithoType.noun
                    //UNK ,VariantOf = "forams"
                    ,Description = "VARIANT. See \"forams\"."
                    ,Version = "1.4.0.0"
            };
            foraminiferous = 
                new QualifierType("foraminiferous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "forams"
                    ,Description = "VARIANT. See \"forams\"."
                    ,Version = "1.4.0.0"
            };
            forams = 
                new QualifierType("forams")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains marine micro-organisms of the order Foraminifera (Devonian - Recent), having a calcareous shell."
                    ,Version = "1.4.0.0"
            };
            foramsUndifferentiated = 
                new QualifierType("forams undifferentiated")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See forams."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Forams
            };
            fossilFragment = 
                new QualifierType("fossil fragment")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See \"fossil fragments\"."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = FossilFragments
            };
            fossilFragments = 
                new QualifierType("fossil fragments")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains material comprised of fossils or fossil fragments."
                    ,Version = "1.4.0.0"
            };
            fossiliferous = 
                new QualifierType("fossiliferous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "fossil fragments"
                    ,Description = "VARIANT. See \"fossil fragments\"."
                    ,Version = "1.4.0.0"
            };
            fossilsUndifferentiated = 
                new QualifierType("fossils undifferentiated")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology contains material comprised of fossils or fossil fragments of undetermined type type, form or species."
                    ,Version = "1.3.1.0"
            };
            fragmentalIgneousRock = 
                new QualifierType("fragmental igneous rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite)."
                    ,Version = "1.4.1.0"
            };
            gabbro = 
                new QualifierType("gabbro")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            gabbroic = 
                new QualifierType("gabbroic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "gabbro"
                    ,Description = "VARIANT. See \"gabbro\"."
                    ,Version = "1.4.1.0"
            };
            gabbroicRock = 
                new QualifierType("gabbroic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            gabbroid = 
                new QualifierType("gabbroid")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            gabbroidic = 
                new QualifierType("gabbroidic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "gabbroid"
                    ,Description = "VARIANT. See \"gabbroid\"."
                    ,Version = "1.4.1.0"
            };
            gilsonite = 
                new QualifierType("gilsonite")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains material containing or resembling gilsonite (uintaite), a brilliant black variety of asphalt occurring in rounded masses."
                    ,Version = "1.4.0.0"
            };
            gilsonitic = 
                new QualifierType("gilsonitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "gilsonite"
                    ,Description = "VARIANT. See \"gilsonite\"."
                    ,Version = "1.4.0.0"
            };
            glauconite = 
                new QualifierType("glauconite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the generally greenish authogenic clay mineral glauconite."
                    ,Version = "1.3.1.0"
            };
            glauconitic = 
                new QualifierType("glauconitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "glauconite"
                    ,Description = "VARIANT. See \"glauconite\"."
                    ,Version = "1.3.1.0"
            };
            gneiss = 
                new QualifierType("gneiss")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            gneissic = 
                new QualifierType("gneissic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "gneiss"
                    ,Description = "VARIANT. See \"gneiss\"."
                    ,Version = "1.4.1.0"
            };
            granite = 
                new QualifierType("granite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            granitic = 
                new QualifierType("granitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "granite"
                    ,Description = "VARIANT. See \"granite\"."
                    ,Version = "1.4.1.0"
            };
            granodiorite = 
                new QualifierType("granodiorite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            granodioritic = 
                new QualifierType("granodioritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "granodiorite"
                    ,Description = "VARIANT. See \"granodiorite\"."
                    ,Version = "1.4.1.0"
            };
            granofels = 
                new QualifierType("granofels")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004."
                    ,Version = "1.4.1.0"
            };
            granulite = 
                new QualifierType("granulite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2"
                    ,Version = "1.4.1.0"
            };
            granulitic = 
                new QualifierType("granulitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "granulite"
                    ,Description = "VARIANT. See \"granulite\"."
                    ,Version = "1.4.1.0"
            };
            gravel = 
                new QualifierType("gravel")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology contains particles in the size range of 2mm - 20mm."
                    ,Version = "1.4.0.0"
            };
            gravelly = 
                new QualifierType("gravelly")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "gravel"
                    ,Description = "VARIANT. See \"gravel\"."
                    ,Version = "1.3.1.0"
            };
            greenstone = 
                new QualifierType("greenstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone."
                    ,Version = "1.4.1.0"
            };
            gumbo = 
                new QualifierType("gumbo")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet."
                    ,Version = "1.4.1.0"
            };
            gypsiferous = 
                new QualifierType("gypsiferous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "gypsum"
                    ,Description = "VARIANT. See \"gypsum\"."
                    ,Version = "1.3.1.0"
            };
            gypsum = 
                new QualifierType("gypsum")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the evaporite mineral gypsum (CaSO4.2H2O)."
                    ,Version = "1.4.0.0"
            };
            halite = 
                new QualifierType("halite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology contains or resembles the common evaporite mineral Halite (NaCl)."
                    ,Version = "1.3.1.0"
            };
            halitic = 
                new QualifierType("halitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "halite"
                    ,Description = "VARIANT. See \"halite\"."
                    ,Version = "1.4.0.0"
            };
            hornfels = 
                new QualifierType("hornfels")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained."
                    ,Version = "1.4.1.0"
            };
            hornfelsic = 
                new QualifierType("hornfelsic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "hornfels"
                    ,Description = "VARIANT. See \"hornfels\"."
                    ,Version = "1.4.1.0"
            };
            igneous = 
                new QualifierType("igneous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "igneous rock"
                    ,Description = "VARIANT. See \"igneous rock\"."
                    ,Version = "1.4.1.0"
            };
            igneousRock = 
                new QualifierType("igneous rock")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            illite = 
                new QualifierType("illite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral illite."
                    ,Version = "1.3.1.0"
            };
            illitic = 
                new QualifierType("illitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "illite"
                    ,Description = "VARIANT. See \"illite\"."
                    ,Version = "1.4.0.0"
            };
            impactGeneratedMaterial = 
                new QualifierType("impact generated material")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997."
                    ,Version = "1.4.1.0"
            };
            impureDolomite = 
                new QualifierType("impure dolomite")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology."
                    ,Version = "1.4.1.0"
            };
            impureLimestone = 
                new QualifierType("impure limestone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology."
                    ,Version = "1.4.1.0"
            };
            intrusiveRockPlutonic = 
                new QualifierType("intrusive rock (plutonic)")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Igneous rock formed by cooling and solidification of magma within the earth's crust."
                    ,Version = "1.4.1.0"
            };
            ironRichSedimentaryRock = 
                new QualifierType("iron rich sedimentary rock")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004."
                    ,Version = "1.4.1.0"
            };
            kalsiliticAndMeliliticRocks = 
                new QualifierType("kalsilitic and melilitic rocks")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            kaolinite = 
                new QualifierType("kaolinite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral kaolinite."
                    ,Version = "1.3.1.0"
            };
            kaolinitic = 
                new QualifierType("kaolinitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "kaolinite"
                    ,Description = "VARIANT. See \"kaolinite\"."
                    ,Version = "1.4.0.0"
            };
            komatiiticRock = 
                new QualifierType("komatiitic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            latiticRock = 
                new QualifierType("latitic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            lignite = 
                new QualifierType("lignite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling a soft brownish-black form of coal."
                    ,Version = "1.3.1.0"
            };
            lignitic = 
                new QualifierType("lignitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "lignite"
                    ,Description = "VARIANT. See \"lignite\"."
                    ,Version = "1.4.0.0"
            };
            limeBoundstone = 
                new QualifierType("lime boundstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limeFramestone = 
                new QualifierType("lime framestone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth & Knox 1999; SLTTs 2004, Table 15-3-1"
                    ,Version = "1.4.1.0"
            };
            limeGrainstone = 
                new QualifierType("lime grainstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limeMudstone = 
                new QualifierType("lime mudstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary."
                    ,Version = "1.4.1.0"
            };
            limePackstone = 
                new QualifierType("lime packstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limeWackestone = 
                new QualifierType("lime wackestone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone."
                    ,Version = "1.4.1.0"
            };
            limestone = 
                new QualifierType("limestone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology."
                    ,Version = "1.4.1.0"
            };
            limestoneStringer = 
                new QualifierType("limestone stringer")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology contains thin beds of limestone."
                    ,Version = "1.3.1.0"
            };
            limestoneArgillaceous = 
                new QualifierType("limestone, argillaceous")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "A limestone homogeneously mixed with 10-50% clay minerals."
                    ,Version = "1.4.1.0"
            };
            limestoneDolomitic = 
                new QualifierType("limestone, dolomitic")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "A limestone containing 10-50% dolomite and 50-90% calcite."
                    ,Version = "1.4.1.0"
            };
            limestoneSandy = 
                new QualifierType("limestone, sandy")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "A limestone homogeneously mixed with 10-50% quartz grains."
                    ,Version = "1.4.1.0"
            };
            lithic = 
                new QualifierType("lithic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "lithic fragments"
                    ,Description = "VARIANT. See \"lithic fragments\"."
                    ,Version = "1.4.0.0"
            };
            lithicFragment = 
                new QualifierType("lithic fragment")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See \"lithic fragments\"."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = LithicFragments
            };
            lithicFragments = 
                new QualifierType("lithic fragments")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or characteristic of undetermined rock fragments."
                    ,Version = "1.4.0.0"
            };
            marble = 
                new QualifierType("marble")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007"
                    ,Version = "1.4.1.0"
            };
            marcasite = 
                new QualifierType("marcasite")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associate lithology comprises material containing or characteristic of the white (gem) form of iron pyrites (FeS)."
                    ,Version = "1.4.0.0"
            };
            marcasitic = 
                new QualifierType("marcasitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "marcasite"
                    ,Description = "VARIANT. See \"marcasite\"."
                    ,Version = "1.4.0.0"
            };
            marl = 
                new QualifierType("marl")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises material containing or characteristic of a crumbly mixture of clays, calcium and magnesium carbonates."
                    ,Version = "1.4.0.0"
            };
            marly = 
                new QualifierType("marly")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "marl"
                    ,Description = "VARIANT. See \"marl\"."
                    ,Version = "1.3.1.0"
            };
            metamorphicRock = 
                new QualifierType("metamorphic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997."
                    ,Version = "1.4.1.0"
            };
            mica = 
                new QualifierType("mica")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or characteristic of mica, a group of hydrous aluminosilicate minerals that split easily into thin partly-transparent sheets."
                    ,Version = "1.3.1.0"
            };
            micaSchist = 
                new QualifierType("mica schist")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology."
                    ,Version = "1.4.1.0"
            };
            micaceous = 
                new QualifierType("micaceous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "mica"
                    ,Description = "VARIANT. See \"mica\"."
                    ,Version = "1.4.0.0"
            };
            microfossil = 
                new QualifierType("microfossil")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See microfossils."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Microfossils
            };
            microfossiliferous = 
                new QualifierType("microfossiliferous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "microfossils"
                    ,Description = "VARIANT. See \"microfossils\"."
                    ,Version = "1.4.0.0"
            };
            microfossils = 
                new QualifierType("microfossils")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains undifferentiated microscopic fossils."
                    ,Version = "1.4.0.0"
            };
            migmatite = 
                new QualifierType("migmatite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)"
                    ,Version = "1.4.1.0"
            };
            migmatitic = 
                new QualifierType("migmatitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "migmatite"
                    ,Description = "VARIANT. See \"migmatite\"."
                    ,Version = "1.4.1.0"
            };
            monzogabbro = 
                new QualifierType("monzogabbro")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            monzogabbroic = 
                new QualifierType("monzogabbroic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "monzogabbro"
                    ,Description = "VARIANT. See \"monzogabbro\"."
                    ,Version = "1.4.1.0"
            };
            mud = 
                new QualifierType("mud")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.)."
                    ,Version = "1.4.1.0"
            };
            muddy = 
                new QualifierType("muddy")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "mud"
                    ,Description = "VARIANT. See \"mud\"."
                    ,Version = "1.4.1.0"
            };
            mudstone = 
                new QualifierType("mudstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth & Knox 1999; extrapolated from Folk, 1954, Figure 1a."
                    ,Version = "1.4.1.0"
            };
            myloniticRock = 
                new QualifierType("mylonitic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak & Mitra 1988."
                    ,Version = "1.4.1.0"
            };
            noDescription = 
                new QualifierType("no description")
                {
                    LithoType = EnumValueLithoType.unknown
                    ,IsLithology = true
                    ,Description = "DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Unknown
            };
            noSample = 
                new QualifierType("no sample")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML."
                    ,Version = "1.4.1.0"
            };
            none = 
                new QualifierType("none")
                {
                    LithoType = EnumValueLithoType.unknown
                    ,Description = "DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Unknown
            };
            oncolite = 
                new QualifierType("oncolite")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology is largely composed of oncoliths (oncoids)."
                    ,Version = "1.3.1.0"
            };
            oncolith = 
                new QualifierType("oncolith")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See oncoliths."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Oncoliths
            };
            oncolithic = 
                new QualifierType("oncolithic")
                {
                    LithoType = EnumValueLithoType.adjective
                    ,Description = "DEPRECATED. See oncoliths."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Oncoliths
            };
            oncoliths = 
                new QualifierType("oncoliths")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or characteristic of oncoliths (oncoids), a type of carbonate-coated grain with irregular laminae."
                    ,Version = "1.4.0.0"
            };
            oncolitic = 
                new QualifierType("oncolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "oncoliths"
                    ,Description = "VARIANT. See \"oncoliths\"."
                    ,Version = "1.4.0.0"
            };
            ooidOrOolith = 
                new QualifierType("ooid or oolith")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See ooids."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Ooids
            };
            ooids = 
                new QualifierType("ooids")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or characteristic of ooids (ooliths), small round grains consisting of calcium carbonate, silica, or dolomite."
                    ,Version = "1.4.0.0"
            };
            ooliths = 
                new QualifierType("ooliths")
                {
                    LithoType = EnumValueLithoType.noun
                    //UNK ,VariantOf = "ooids"
                    ,Description = "VARIANT. See \"ooids\"."
                    ,Version = "1.4.0.0"
            };
            oolitic = 
                new QualifierType("oolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "ooids"
                    ,Description = "VARIANT. See \"ooids\"."
                    ,Version = "1.4.0.0"
            };
            ooze = 
                new QualifierType("ooze")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 & Hallsworth & Knox 1999."
                    ,Version = "1.4.1.0"
            };
            ophiolite = 
                new QualifierType("ophiolite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust."
                    ,Version = "1.4.1.0"
            };
            ophiolitic = 
                new QualifierType("ophiolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "ophiolite"
                    ,Description = "VARIANT. See \"ophiolite\"."
                    ,Version = "1.4.1.0"
            };
            organicBearingMudstone = 
                new QualifierType("organic bearing mudstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;"
                    ,Version = "1.4.1.0"
            };
            ostracodal = 
                new QualifierType("ostracodal")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "ostracods"
                    ,Description = "VARIANT. See \"ostracods\"."
                    ,Version = "1.4.0.0"
            };
            ostracods = 
                new QualifierType("ostracods")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling ostracod (Cambrian - Recent) fossils."
                    ,Version = "1.3.1.0"
            };
            peat = 
                new QualifierType("peat")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth & Knox 1999."
                    ,Version = "1.4.1.0"
            };
            peaty = 
                new QualifierType("peaty")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "peat"
                    ,Description = "VARIANT. See \"peat\"."
                    ,Version = "1.4.1.0"
            };
            pebble = 
                new QualifierType("pebble")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains rounded rock fragments in the size range of 2mm - 64mm."
                    ,Version = "1.4.0.0"
            };
            pebbly = 
                new QualifierType("pebbly")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "pebble"
                    ,Description = "VARIANT. See \"pebble\"."
                    ,Version = "1.3.1.0"
            };
            pegmatite = 
                new QualifierType("pegmatite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            pegmatitic = 
                new QualifierType("pegmatitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "pegmatite"
                    ,Description = "VARIANT. See \"pegmatite\"."
                    ,Version = "1.4.1.0"
            };
            pellet = 
                new QualifierType("pellet")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See pellets."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Pellets
            };
            pelletal = 
                new QualifierType("pelletal")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "pellets"
                    ,Description = "VARIANT. See \"pellets\"."
                    ,Version = "1.3.1.0"
            };
            pellets = 
                new QualifierType("pellets")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains or is characteristic of small ovoid or spherical particles of microcrystalline calcite, in the size range 0.03mm - 0.15mm."
                    ,Version = "1.4.0.0"
            };
            peloid = 
                new QualifierType("peloid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See peloids."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Peloids
            };
            peloidal = 
                new QualifierType("peloidal")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "peloids"
                    ,Description = "VARIANT. See \"peloids\"."
                    ,Version = "1.3.1.0"
            };
            peloids = 
                new QualifierType("peloids")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology contains or is characteristic of sand-size grains of carbonate mud."
                    ,Version = "1.4.0.0"
            };
            peridotite = 
                new QualifierType("peridotite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            peridotitic = 
                new QualifierType("peridotitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "peridotite"
                    ,Description = "VARIANT. See \"peridotite\"."
                    ,Version = "1.4.1.0"
            };
            phaneriticIgneousRock = 
                new QualifierType("phaneritic igneous rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005."
                    ,Version = "1.4.1.0"
            };
            phonolite = 
                new QualifierType("phonolite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            phonolitic = 
                new QualifierType("phonolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "phonolite"
                    ,Description = "VARIANT. See \"phonolite\"."
                    ,Version = "1.4.1.0"
            };
            phonolitoid = 
                new QualifierType("phonolitoid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            phosphate = 
                new QualifierType("phosphate")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology contains phosphates."
                    ,Version = "1.3.1.0"
            };
            phosphateRock = 
                new QualifierType("phosphate rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource."
                    ,Version = "1.4.1.0"
            };
            phosphatic = 
                new QualifierType("phosphatic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "phosphate"
                    ,Description = "VARIANT. See \"phosphate\"."
                    ,Version = "1.4.0.0"
            };
            phyllite = 
                new QualifierType("phyllite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007."
                    ,Version = "1.4.1.0"
            };
            phyllitic = 
                new QualifierType("phyllitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "phyllite"
                    ,Description = "VARIANT. See \"phyllite\"."
                    ,Version = "1.4.1.0"
            };
            pisolite = 
                new QualifierType("pisolite")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology is composed largely of pisoliths (pisoids)."
                    ,Version = "1.3.1.0"
            };
            pisolith = 
                new QualifierType("pisolith")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See pisoliths."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Pisoliths
            };
            pisoliths = 
                new QualifierType("pisoliths")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology contains or is characteristic of sub-spherical usually carbonate coated grains, of diameter greater than 2mm."
                    ,Version = "1.4.0.0"
            };
            pisolitic = 
                new QualifierType("pisolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "pisolite"
                    ,Description = "VARIANT. See \"pisolite\"."
                    ,Version = "1.4.0.0"
            };
            plantRemains = 
                new QualifierType("plant remains")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology contains remains of a probable botanical origin."
                    ,Version = "1.3.1.0"
            };
            porphyritic = 
                new QualifierType("porphyritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "porphyry"
                    ,Description = "VARIANT. See \"porphyry\"."
                    ,Version = "1.4.1.0"
            };
            porphyry = 
                new QualifierType("porphyry")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            potassiumAndMagnesiumSalts = 
                new QualifierType("potassium and magnesium salts")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML."
                    ,Version = "1.4.1.0"
            };
            pyrite = 
                new QualifierType("pyrite")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling the sulphide mineral of iron (FeS2)."
                    ,Version = "1.3.1.0"
            };
            pyritic = 
                new QualifierType("pyritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "pyrite"
                    ,Description = "VARIANT. See \"pyrite\"."
                    ,Version = "1.4.0.0"
            };
            pyroclasticBreccia = 
                new QualifierType("pyroclastic breccia")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            pyroclasticRock = 
                new QualifierType("pyroclastic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            pyroxenite = 
                new QualifierType("pyroxenite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            pyroxenitic = 
                new QualifierType("pyroxenitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "pyroxenite"
                    ,Description = "VARIANT. See \"pyroxenite\"."
                    ,Version = "1.4.1.0"
            };
            quartiferous = 
                new QualifierType("quartiferous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "quartz"
                    ,Description = "VARIANT. See \"quartz\"."
                    ,Version = "1.4.0.0"
            };
            quartz = 
                new QualifierType("quartz")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "Indicates that the associated lithology comprises (crystalline) material containing or resembling the common silica mineral quartz (SiO2)."
                    ,Version = "1.3.1.0"
            };
            quartzArenite = 
                new QualifierType("quartz arenite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632."
                    ,Version = "1.4.1.0"
            };
            quartzite = 
                new QualifierType("quartzite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            quartzitic = 
                new QualifierType("quartzitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "quartzite"
                    ,Description = "VARIANT. See \"quartzite\"."
                    ,Version = "1.4.1.0"
            };
            radiolaria = 
                new QualifierType("radiolaria")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling fossils of the marine protozoan order of Radiolaria (Cambrian - Recent), generally with endoskeletons of opaline silica."
                    ,Version = "1.3.1.0"
            };
            radiolarian = 
                new QualifierType("radiolarian")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "radiolaria"
                    ,Description = "VARIANT. See \"radiolaria\"."
                    ,Version = "1.4.0.0"
            };
            rhyolite = 
                new QualifierType("rhyolite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            rhyolitic = 
                new QualifierType("rhyolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "rhyolite"
                    ,Description = "VARIANT. See \"rhyolite\"."
                    ,Version = "1.4.1.0"
            };
            rockSalt = 
                new QualifierType("rock salt")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology."
                    ,Version = "1.4.1.0"
            };
            rootlets = 
                new QualifierType("rootlets")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling plant roots, or structures (rhizoliths) resulting from the mineralization of plant roots by accumulation/cementation or replacement."
                    ,Version = "1.4.0.0"
            };
            salty = 
                new QualifierType("salty")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "rock salt"
                    ,Description = "VARIANT. See \"rock salt\"."
                    ,Version = "1.3.1.0"
            };
            sand = 
                new QualifierType("sand")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises (crystalline) material containing or resembling mineral or rock grains of diameter in the range of 0.625mm - 2mm."
                    ,Version = "1.4.0.0"
            };
            sandstone = 
                new QualifierType("sandstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale."
                    ,Version = "1.4.1.0"
            };
            sandy = 
                new QualifierType("sandy")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "sand"
                    ,Description = "VARIANT. See \"sand\"."
                    ,Version = "1.3.1.0"
            };
            sapropel = 
                new QualifierType("sapropel")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            sapropelic = 
                new QualifierType("sapropelic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "sapropel"
                    ,Description = "VARIANT. See \"sapropel\"."
                    ,Version = "1.4.1.0"
            };
            schist = 
                new QualifierType("schist")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            schisty = 
                new QualifierType("schisty")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "schist"
                    ,Description = "VARIANT. See \"schist\"."
                    ,Version = "1.4.1.0"
            };
            sepentinitic = 
                new QualifierType("sepentinitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "serpentinite"
                    ,Description = "VARIANT. See \"serpentinite\"."
                    ,Version = "1.4.1.0"
            };
            serpentinite = 
                new QualifierType("serpentinite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            shale = 
                new QualifierType("shale")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically."
                    ,Version = "1.4.1.0"
            };
            shaly = 
                new QualifierType("shaly")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "shale"
                    ,Description = "VARIANT. See \"shale\"."
                    ,Version = "1.4.1.0"
            };
            shell = 
                new QualifierType("shell")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See \"shell fragments\"."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = ShellFragments
            };
            shellFragments = 
                new QualifierType("shell fragments")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling shells (generally bivalves) or fragments thereof."
                    ,Version = "1.4.0.0"
            };
            shelly = 
                new QualifierType("shelly")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "shell fragments"
                    ,Description = "VARIANT. See \"shell fragments\"."
                    ,Version = "1.4.0.0"
            };
            siderite = 
                new QualifierType("siderite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling siderite (spathic iron), a carbonate mineral of iron (FeCO3)."
                    ,Version = "1.3.1.0"
            };
            sideriteConcretion = 
                new QualifierType("siderite concretion")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "Indicates that the associated lithology contains rounded masses comprised of the mineral siderite (spathic iron), a carbonate mineral of iron (FeCO3)."
                    ,Version = "1.3.1.0"
            };
            sideritic = 
                new QualifierType("sideritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "siderite"
                    ,Description = "VARIANT. See \"siderite\"."
                    ,Version = "1.4.0.0"
            };
            siliceousOoze = 
                new QualifierType("siliceous ooze")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology."
                    ,Version = "1.4.1.0"
            };
            silt = 
                new QualifierType("silt")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material of very fine particles intermediate in size between clay and sand (0.0625mm - 2mm)."
                    ,Version = "1.4.0.0"
            };
            siltstone = 
                new QualifierType("siltstone")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Mudstone that contains detectable silt. OneGeology."
                    ,Version = "1.4.1.0"
            };
            silty = 
                new QualifierType("silty")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "silt"
                    ,Description = "VARIANT. See \"silt\"."
                    ,Version = "1.3.1.0"
            };
            skarn = 
                new QualifierType("skarn")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195."
                    ,Version = "1.4.1.0"
            };
            skarny = 
                new QualifierType("skarny")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "skarn"
                    ,Description = "VARIANT. See \"skarn\"."
                    ,Version = "1.4.1.0"
            };
            slate = 
                new QualifierType("slate")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005."
                    ,Version = "1.4.1.0"
            };
            slaty = 
                new QualifierType("slaty")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "slate"
                    ,Description = "VARIANT. See \"slate\"."
                    ,Version = "1.4.1.0"
            };
            smectite = 
                new QualifierType("smectite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsMatrixCement = true
                    ,Description = "A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples."
                    ,Version = "1.4.1.0"
            };
            smectitic = 
                new QualifierType("smectitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "smectite"
                    ,Description = "VARIANT. See \"smectite\"."
                    ,Version = "1.4.1.0"
            };
            spicular = 
                new QualifierType("spicular")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "spicules"
                    ,Description = "VARIANT. See \"spicules\"."
                    ,Version = "1.3.1.0"
            };
            spicule = 
                new QualifierType("spicule")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See spicules."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Spicules
            };
            spicules = 
                new QualifierType("spicules")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling minute needle-like structures of silica or carbonate, such as that supporting the soft tissue of certain invertebrates, especially sponges."
                    ,Version = "1.4.0.0"
            };
            spilite = 
                new QualifierType("spilite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619."
                    ,Version = "1.4.1.0"
            };
            spilitic = 
                new QualifierType("spilitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "spilite"
                    ,Description = "VARIANT. See \"spilite\"."
                    ,Version = "1.4.1.0"
            };
            stylolite = 
                new QualifierType("stylolite")
                {
                    LithoType = EnumValueLithoType.noun
                    ,Description = "DEPRECATED. See stylolites."
                    ,Version = "1.3.1.0"
                    ,Deprecated = "1.4.0.0"
                    ,ReplacedBy = Stylolites
            };
            stylolites = 
                new QualifierType("stylolites")
                {
                    LithoType = EnumValueLithoType.both
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling a contact zone surface between two adjacent calcareous rocks, along which dissolution by pressure solution has ocurred and appearing in cross section as a series of jagged interlocking up-and-down projections (of insoluble clay minerals) that resemble a suture."
                    ,Version = "1.4.0.0"
            };
            stylolitic = 
                new QualifierType("stylolitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "stylolites"
                    ,Description = "VARIANT. See \"stylolites\"."
                    ,Version = "1.3.1.0"
            };
            syenite = 
                new QualifierType("syenite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz."
                    ,Version = "1.4.1.0"
            };
            syenitic = 
                new QualifierType("syenitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "syenite"
                    ,Description = "VARIANT. See \"syenite\"."
                    ,Version = "1.4.1.0"
            };
            syenitoid = 
                new QualifierType("syenitoid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            sylvite = 
                new QualifierType("sylvite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology."
                    ,Version = "1.4.1.0"
            };
            sylvitic = 
                new QualifierType("sylvitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "sylvite"
                    ,Description = "VARIANT. See \"sylvite\"."
                    ,Version = "1.4.1.0"
            };
            tarry = 
                new QualifierType("tarry")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "bitumen"
                    ,Description = "VARIANT. See \"bitumen\"."
                    ,Version = "1.4.0.0"
            };
            tephrite = 
                new QualifierType("tephrite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            tephritic = 
                new QualifierType("tephritic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "tephrite"
                    ,Description = "VARIANT. See \"tephrite\"."
                    ,Version = "1.4.1.0"
            };
            tephritoid = 
                new QualifierType("tephritoid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            tholeiiticBasalt = 
                new QualifierType("tholeiitic basalt")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43."
                    ,Version = "1.4.1.0"
            };
            tonalite = 
                new QualifierType("tonalite")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            tonalitic = 
                new QualifierType("tonalitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "tonalite"
                    ,Description = "VARIANT. See \"tonalite\"."
                    ,Version = "1.4.1.0"
            };
            trachyte = 
                new QualifierType("trachyte")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals."
                    ,Version = "1.4.1.0"
            };
            trachytic = 
                new QualifierType("trachytic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "trachyte"
                    ,Description = "VARIANT. See \"trachyte\"."
                    ,Version = "1.4.1.0"
            };
            trachyticRock = 
                new QualifierType("trachytic rock")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            trachytoid = 
                new QualifierType("trachytoid")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002."
                    ,Version = "1.4.1.0"
            };
            travertine = 
                new QualifierType("travertine")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74."
                    ,Version = "1.4.1.0"
            };
            tuff = 
                new QualifierType("tuff")
                {
                    LithoType = EnumValueLithoType.both
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling pyroclastic detrital material (volcanic ash)."
                    ,Version = "1.4.0.0"
            };
            tuffaceous = 
                new QualifierType("tuffaceous")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "tuff"
                    ,Description = "VARIANT. See \"tuff\"."
                    ,Version = "1.3.1.0"
            };
            tuffite = 
                new QualifierType("tuffite")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Indicates that the associated lithology comprises material containing or resembling a fine grained matrix of volcanic breccia with intruded grains of fluidized sediment."
                    ,Version = "1.3.1.0"
            };
            tuffitic = 
                new QualifierType("tuffitic")
                {
                    LithoType = EnumValueLithoType.adjective
                    //UNK ,VariantOf = "tuffite"
                    ,Description = "VARIANT. See \"tuffite\"."
                    ,Version = "1.4.1.0"
            };
            ultrabasic = 
                new QualifierType("ultrabasic")
                {
                    LithoType = EnumValueLithoType.adjective
                    ,IsLithology = true
                    ,Description = "A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%."
                    ,Version = "1.4.1.0"
            };
            undifferentiated = 
                new QualifierType("undifferentiated")
                {
                    LithoType = EnumValueLithoType.adjective
                    ,IsLithology = true
                    ,Description = "The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent."
                    ,Version = "1.4.1.0"
            };
            wacke = 
                new QualifierType("wacke")
                {
                    LithoType = EnumValueLithoType.noun
                    ,IsLithology = true
                    ,Description = "Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p."
                    ,Version = "1.4.1.0"
            };
            unknown = 
                new QualifierType("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
                    ,Version = "1.3.1.0"
            };
        }

        /// <summary>
        /// Gets a QualifierType by name
        /// </summary>
        /// <param name="name">The name of the QualifierType to return</param>
        /// <returns>The QualifierType represented by 'name'</returns>
        public static QualifierType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(QualifierType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(QualifierType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (QualifierType)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// The type of algorithm used in the calculation of a trajectory station dependent data. 
    ///		This is traditionally positional information except for the cases of inertial survey data.
    ///		See API Bulletin D20 "BULLETIN ON DIRECTIONAL DRILLING SURVEY CALCULATION METHODS AND TERMINOLOGY", 
    ///		First Edition December 31, 1985.
    /// </summary>
    public class TrajStnCalcAlgorithm : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected TrajStnCalcAlgorithm(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the TrajStnCalcAlgorithm</param>
        public TrajStnCalcAlgorithm(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of TrajStnCalcAlgorithms
        /// </summary>
        /// <returns>The complete list of TrajStnCalcAlgorithms</returns>
        public static List<TrajStnCalcAlgorithm> GetList()
        {
            return GetList<TrajStnCalcAlgorithm>();
        }

        private readonly static TrajStnCalcAlgorithm constantToolFace;
        /// <summary>
        /// An algorithm used to design a well trajectory during the planning stage
        /// </summary>
        [EnumValueNameAttribute("constant tool face")]
        public static TrajStnCalcAlgorithm ConstantToolFace
        {
            get 
            {
                return constantToolFace;
            }
        }

        private readonly static TrajStnCalcAlgorithm minimumCurvature;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is that of a circular arc in 3-D space. Also known as "Minimum Radius Of Curvature" method.
        /// </summary>
        [EnumValueNameAttribute("minimum curvature")]
        public static TrajStnCalcAlgorithm MinimumCurvature
        {
            get 
            {
                return minimumCurvature;
            }
        }

        private readonly static TrajStnCalcAlgorithm tangential;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is a straight line oriented according to the seconds stations orientation. Also known as "Backward Station" and "Terminal Angle" methods. 
        /// </summary>
        [EnumValueNameAttribute("tangential")]
        public static TrajStnCalcAlgorithm Tangential
        {
            get 
            {
                return tangential;
            }
        }

        private readonly static TrajStnCalcAlgorithm balancedTangential;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along two straight lines, with the first section oriented according to the first stations orientation and the second line oriented according to the second stations orientation. Each line segment is set to have a length of half the measured depth difference between the two stations. Also known as "Acceleration", "Secant", "Trapezoidal", and "Vector Averaging" methods.
        /// </summary>
        [EnumValueNameAttribute("balanced tangential")]
        public static TrajStnCalcAlgorithm BalancedTangential
        {
            get 
            {
                return balancedTangential;
            }
        }

        private readonly static TrajStnCalcAlgorithm averageAngle;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along a straight line oriented according to the average of the inclination and azimuth orientations of the start and end stations. Also known as "Angle Averaging" method. 
        /// </summary>
        [EnumValueNameAttribute("average angle")]
        public static TrajStnCalcAlgorithm AverageAngle
        {
            get 
            {
                return averageAngle;
            }
        }

        private readonly static TrajStnCalcAlgorithm radiusOfCurvature;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path is a helix with a fixed vertical radius wrapped around a cylinder of fixed radius. Both radii can tend to infinity yielding simple circular arcs in either the horizontal or vertical planes.
        /// </summary>
        [EnumValueNameAttribute("radius of curvature")]
        public static TrajStnCalcAlgorithm RadiusOfCurvature
        {
            get 
            {
                return radiusOfCurvature;
            }
        }

        private readonly static TrajStnCalcAlgorithm inertial;
        /// <summary>
        /// This encompasses surveying methods where the positional data was not derived from a transformation of MD,INC,AZM, but are provided directly by some other mechanism such as direct positional output from an inertial gyro system.
        /// </summary>
        [EnumValueNameAttribute("inertial")]
        public static TrajStnCalcAlgorithm Inertial
        {
            get 
            {
                return inertial;
            }
        }

        private readonly static TrajStnCalcAlgorithm custom;
        /// <summary>
        /// This encompasses methodologies which are similar to the Inertial method in that they are direct populations of the positional data, which have been determined by some other possibly non-published methodology.
        /// </summary>
        [EnumValueNameAttribute("custom")]
        public static TrajStnCalcAlgorithm Custom
        {
            get 
            {
                return custom;
            }
        }

        private readonly static TrajStnCalcAlgorithm unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TrajStnCalcAlgorithm Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static TrajStnCalcAlgorithm()
        {
            constantToolFace = 
                new TrajStnCalcAlgorithm("constant tool face")
                {
                    Description = "An algorithm used to design a well trajectory during the planning stage"
            };
            minimumCurvature = 
                new TrajStnCalcAlgorithm("minimum curvature")
                {
                    Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is that of a circular arc in 3-D space. Also known as \"Minimum Radius Of Curvature\" method."
            };
            tangential = 
                new TrajStnCalcAlgorithm("tangential")
                {
                    Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is a straight line oriented according to the seconds stations orientation. Also known as \"Backward Station\" and \"Terminal Angle\" methods. "
            };
            balancedTangential = 
                new TrajStnCalcAlgorithm("balanced tangential")
                {
                    Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along two straight lines, with the first section oriented according to the first stations orientation and the second line oriented according to the second stations orientation. Each line segment is set to have a length of half the measured depth difference between the two stations. Also known as \"Acceleration\", \"Secant\", \"Trapezoidal\", and \"Vector Averaging\" methods."
            };
            averageAngle = 
                new TrajStnCalcAlgorithm("average angle")
                {
                    Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along a straight line oriented according to the average of the inclination and azimuth orientations of the start and end stations. Also known as \"Angle Averaging\" method. "
            };
            radiusOfCurvature = 
                new TrajStnCalcAlgorithm("radius of curvature")
                {
                    Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path is a helix with a fixed vertical radius wrapped around a cylinder of fixed radius. Both radii can tend to infinity yielding simple circular arcs in either the horizontal or vertical planes."
            };
            inertial = 
                new TrajStnCalcAlgorithm("inertial")
                {
                    Description = "This encompasses surveying methods where the positional data was not derived from a transformation of MD,INC,AZM, but are provided directly by some other mechanism such as direct positional output from an inertial gyro system."
            };
            custom = 
                new TrajStnCalcAlgorithm("custom")
                {
                    Description = "This encompasses methodologies which are similar to the Inertial method in that they are direct populations of the positional data, which have been determined by some other possibly non-published methodology."
            };
            unknown = 
                new TrajStnCalcAlgorithm("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
            };
        }

        /// <summary>
        /// Gets a TrajStnCalcAlgorithm by name
        /// </summary>
        /// <param name="name">The name of the TrajStnCalcAlgorithm to return</param>
        /// <returns>The TrajStnCalcAlgorithm represented by 'name'</returns>
        public static TrajStnCalcAlgorithm GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(TrajStnCalcAlgorithm)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(TrajStnCalcAlgorithm)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (TrajStnCalcAlgorithm)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    ///  Type of directional survey tool; a very generic classification.
    /// </summary>
    public class TypeSurveyTool : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected TypeSurveyTool(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the TypeSurveyTool</param>
        public TypeSurveyTool(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of TypeSurveyTools
        /// </summary>
        /// <returns>The complete list of TypeSurveyTools</returns>
        public static List<TypeSurveyTool> GetList()
        {
            return GetList<TypeSurveyTool>();
        }

        private readonly static TypeSurveyTool magneticMwd;
        /// <summary>
        /// A tool measuring downhole inclination and azimuth from sets of accelerometers and magnetometers sensors.
        /// </summary>
        [EnumValueNameAttribute("magnetic MWD")]
        public static TypeSurveyTool MagneticMwd
        {
            get 
            {
                return magneticMwd;
            }
        }

        private readonly static TypeSurveyTool gyroscopicMwd;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gyroscopic  MWD")]
        public static TypeSurveyTool GyroscopicMwd
        {
            get 
            {
                return gyroscopicMwd;
            }
        }

        private readonly static TypeSurveyTool gyroscopicNorthSeeking;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gyroscopic north seeking")]
        public static TypeSurveyTool GyroscopicNorthSeeking
        {
            get 
            {
                return gyroscopicNorthSeeking;
            }
        }

        private readonly static TypeSurveyTool gyroscopicInertial;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gyroscopic inertial")]
        public static TypeSurveyTool GyroscopicInertial
        {
            get 
            {
                return gyroscopicInertial;
            }
        }

        private readonly static TypeSurveyTool magneticSingleshot;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic single-shot")]
        public static TypeSurveyTool MagneticSingleshot
        {
            get 
            {
                return magneticSingleshot;
            }
        }

        private readonly static TypeSurveyTool magneticMultipleshot;
        /// <summary>
        /// A tool measuring downhole inclination and azimuth from photo-mechanical inclinometers and magnetic compass.
        /// </summary>
        [EnumValueNameAttribute("magnetic multiple-shot")]
        public static TypeSurveyTool MagneticMultipleshot
        {
            get 
            {
                return magneticMultipleshot;
            }
        }

        private readonly static TypeSurveyTool unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TypeSurveyTool Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static TypeSurveyTool()
        {
            magneticMwd = 
                new TypeSurveyTool("magnetic MWD")
                {
                    Description = "A tool measuring downhole inclination and azimuth from sets of accelerometers and magnetometers sensors."
                    ,Version = "1.3.1"
            };
            gyroscopicMwd = 
                new TypeSurveyTool("gyroscopic  MWD")
                {
                    Version = "1.3.1"
            };
            gyroscopicNorthSeeking = 
                new TypeSurveyTool("gyroscopic north seeking")
                {
                    Version = "1.3.1"
            };
            gyroscopicInertial = 
                new TypeSurveyTool("gyroscopic inertial")
                {
                    Version = "1.3.1"
            };
            magneticSingleshot = 
                new TypeSurveyTool("magnetic single-shot")
                {
                    Version = "1.3.1"
            };
            magneticMultipleshot = 
                new TypeSurveyTool("magnetic multiple-shot")
                {
                    Description = "A tool measuring downhole inclination and azimuth from photo-mechanical inclinometers and magnetic compass."
                    ,Version = "1.3.1"
            };
            unknown = 
                new TypeSurveyTool("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
                    ,Version = "1.3.1"
            };
        }

        /// <summary>
        /// Gets a TypeSurveyTool by name
        /// </summary>
        /// <param name="name">The name of the TypeSurveyTool to return</param>
        /// <returns>The TypeSurveyTool represented by 'name'</returns>
        public static TypeSurveyTool GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(TypeSurveyTool)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(TypeSurveyTool)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (TypeSurveyTool)ev;
                    }
                }
            }
            
            return null;
        }
    }

}
