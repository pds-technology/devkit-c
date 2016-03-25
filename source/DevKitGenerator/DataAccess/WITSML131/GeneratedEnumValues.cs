using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.WITSML131
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
    /// These values represent the lithological terminology used 
    ///		in descriptions of rock cuttings in mud logs.
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

        private readonly static LithologyType andesite;
        /// <summary>
        /// Intermediate porphyritic volcanic rock consisting of plagioclase, pyroxene, hornblende and bitotite.
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
        /// The mineral form of anhydrous calcium sulfate, commonly massive in evaporite beds.
        /// </summary>
        [EnumValueNameAttribute("anhydrite")]
        public static LithologyType Anhydrite
        {
            get 
            {
                return anhydrite;
            }
        }

        private readonly static LithologyType arkose;
        /// <summary>
        /// An indurated arenaceous deposit consisting chiefly of quartz and feldspar (>25%).
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
        /// Volcanic rock consisting essentially of plagioclase feldspar and pyroxene.
        /// </summary>
        [EnumValueNameAttribute("basalt")]
        public static LithologyType Basalt
        {
            get 
            {
                return basalt;
            }
        }

        private readonly static LithologyType breccia;
        /// <summary>
        /// A lithified rock rich in angular fragments of size greater than 2mm.
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
        /// A limestone more than half of which consists of cemented sand-size grains of calcium carbonate: a consolidated calcareous sand.
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
        /// A limestone more than half of which consists of detrital calcite particles of silt and/or clay size: a consolidated calcareous mud.
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
        /// A limestone more than half of which consists of detrital calcite particles of silt size: a consolidated calcareous silt.
        /// </summary>
        [EnumValueNameAttribute("calcisiltite")]
        public static LithologyType Calcisiltite
        {
            get 
            {
                return calcisiltite;
            }
        }

        private readonly static LithologyType chalk;
        /// <summary>
        /// A fine-grained limestone composed largely of coccolith fragments.
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
        /// Siliceous sedimentary rock containing finely crystalline snd fibrous quartz.
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
        /// Unconsolidated deposit of very fine particles of size generally less than 1/256mm and composed of clay minerals.
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
        /// An indurated clay, lacking the fissility of shale.
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
        /// A combustible organic sedimentary rock with less than 40% of mineral matter (based on dry material) composed of polymers of cyclic hydrocarbons.
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
        /// An indurated sedimentary rock containing an essential quantity of rounded rock fragments larger than 2mm, and normally having a matrix of sand.
        /// </summary>
        [EnumValueNameAttribute("conglomerate")]
        public static LithologyType Conglomerate
        {
            get 
            {
                return conglomerate;
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

        private readonly static LithologyType dolomite;
        /// <summary>
        /// Sedimentary rock containing more than 90% dolomite (mineral) and less than 10% calcite.
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
        /// A dolomite rock containing more than 10% calcite.
        /// </summary>
        [EnumValueNameAttribute("dolomite, calcareous")]
        public static LithologyType DolomiteCalcareous
        {
            get 
            {
                return dolomiteCalcareous;
            }
        }

        private readonly static LithologyType extrusiveRockVolcanic;
        /// <summary>
        /// Igneous rocks formed by solidification of material erupted sub-aerially or sub-aqueously onto the earth's surface, as either lava flows or pyroclastic material.
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

        private readonly static LithologyType gabbro;
        /// <summary>
        /// Coarse grained plutonic igneous rock composed essentially of calcic plagioclase feldspar, pyroxenes and iron oxide.
        /// </summary>
        [EnumValueNameAttribute("gabbro")]
        public static LithologyType Gabbro
        {
            get 
            {
                return gabbro;
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
        /// A metamorphic rock, commonly foliated and crystalline, whose mineral content can range from quartz and feldspars to amphiboles and pyroxenes.
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
        /// Coarse grained plutonic rock typically containing free quartz, alkali feldspar and biotite mica.
        /// </summary>
        [EnumValueNameAttribute("granite")]
        public static LithologyType Granite
        {
            get 
            {
                return granite;
            }
        }

        private readonly static LithologyType gravel;
        /// <summary>
        /// An unconsolidated deposit of coarse clastics. The diameters on the Wenworth scale are generally greater than 2mm.
        /// </summary>
        [EnumValueNameAttribute("gravel")]
        public static LithologyType Gravel
        {
            get 
            {
                return gravel;
            }
        }

        private readonly static LithologyType greenstones;
        /// <summary>
        /// A field term for any dark fine grained altered or metamorphosed basic igneous rock.
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
        /// A dark grey consolidated deposit containing feldspar, rock fragments and a dark chloritic matrix.
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
        /// A mineral composed of hydrous calcium sulphate, commonly forming thick extensive evaporite beds.
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
        /// A mineral composed of sodium chloride common in evaporite rocks.
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static LithologyType Halite
        {
            get 
            {
                return halite;
            }
        }

        private readonly static LithologyType igneous;
        /// <summary>
        /// Term applied to rock or mineral formed by solidification of molten or partly molten material (magma).
        /// </summary>
        [EnumValueNameAttribute("igneous")]
        public static LithologyType Igneous
        {
            get 
            {
                return igneous;
            }
        }

        private readonly static LithologyType intrusvieRockPlutonic;
        /// <summary>
        /// Igneous rock formed by cooling and solidification of magma within the earth's crust.
        /// </summary>
        [EnumValueNameAttribute("intrusvie rock (plutonic)")]
        public static LithologyType IntrusvieRockPlutonic
        {
            get 
            {
                return intrusvieRockPlutonic;
            }
        }

        private readonly static LithologyType lignite;
        /// <summary>
        /// A low-rank humic coal.
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static LithologyType Lignite
        {
            get 
            {
                return lignite;
            }
        }

        private readonly static LithologyType limestone;
        /// <summary>
        /// A sedimentary rock composed mostly of the mineral calcite (calcium carbonate) which is the consolidated equivalent of lime mud, calcareous sand, and/or shell fragments.
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
        /// A metamorphic rock composed of calcite.
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

        private readonly static LithologyType metamorphicRocks;
        /// <summary>
        /// Rocks formed by mineralogical, chemical and structural alteration of pre-existing rocks under conditions of temperature and pressure at depth in the earth.
        /// </summary>
        [EnumValueNameAttribute("metamorphic rocks")]
        public static LithologyType MetamorphicRocks
        {
            get 
            {
                return metamorphicRocks;
            }
        }

        private readonly static LithologyType mudstone;
        /// <summary>
        /// Consolidated and indurated mud.
        /// </summary>
        [EnumValueNameAttribute("mudstone")]
        public static LithologyType Mudstone
        {
            get 
            {
                return mudstone;
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
        /// No sample is provided.
        /// </summary>
        [EnumValueNameAttribute("no sample")]
        public static LithologyType NoSample
        {
            get 
            {
                return noSample;
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

        private readonly static LithologyType peat;
        /// <summary>
        /// Unconsolidated, semi-carbonised plant remains which are a precursor of humic coal.
        /// </summary>
        [EnumValueNameAttribute("peat")]
        public static LithologyType Peat
        {
            get 
            {
                return peat;
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

        private readonly static LithologyType potassiumAndMagnesiumSalts;
        /// <summary>
        /// Salts such as sylvinite, carnalite, keiserite with swelling properties that can severely obstruct drilling operations.
        /// </summary>
        [EnumValueNameAttribute("potassium and magnesium salts")]
        public static LithologyType PotassiumAndMagnesiumSalts
        {
            get 
            {
                return potassiumAndMagnesiumSalts;
            }
        }

        private readonly static LithologyType quartzite;
        /// <summary>
        /// A sedimentary rock composed of more than 95% of quartz.
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
        /// Silica rich volcanic rock consisting of quartz and alkali feldspar with minor plagioclase and biotite.
        /// </summary>
        [EnumValueNameAttribute("rhyolite")]
        public static LithologyType Rhyolite
        {
            get 
            {
                return rhyolite;
            }
        }

        private readonly static LithologyType salt;
        /// <summary>
        /// Common term for naturally occurring sodium chloride.
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
        /// An aggregation of particles having diameters in the range 1/16mm to 2mm usually consisting of quartz.
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
        /// A sedimentary rock composed of indurated sand.
        /// </summary>
        [EnumValueNameAttribute("sandstone")]
        public static LithologyType Sandstone
        {
            get 
            {
                return sandstone;
            }
        }

        private readonly static LithologyType schist;
        /// <summary>
        /// A strongly foliated crystalline metamorphic rock.
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
        /// A rock forming mineral of hydrous iron and magnesium silicates, often resulting from metamorhism of amphiboles and pyroxenes.
        /// </summary>
        [EnumValueNameAttribute("serpentine")]
        public static LithologyType Serpentine
        {
            get 
            {
                return serpentine;
            }
        }

        private readonly static LithologyType shale;
        /// <summary>
        /// A fine-grained sedimentary rock formed by the compaction of clay, silt or mud.
        /// </summary>
        [EnumValueNameAttribute("shale")]
        public static LithologyType Shale
        {
            get 
            {
                return shale;
            }
        }

        private readonly static LithologyType silt;
        /// <summary>
        /// Unconsolidated sedimentary material with grain sizes between 1/16mm and 1/256mm.
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
        /// Consolidated silt.
        /// </summary>
        [EnumValueNameAttribute("siltstone")]
        public static LithologyType Siltstone
        {
            get 
            {
                return siltstone;
            }
        }

        private readonly static LithologyType slate;
        /// <summary>
        /// A compact fine-grained metamorphic rock displaying slaty cleavage along which the rock may be cut into sheets.
        /// </summary>
        [EnumValueNameAttribute("slate")]
        public static LithologyType Slate
        {
            get 
            {
                return slate;
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

        private readonly static LithologyType tilliteDiamictite;
        /// <summary>
        /// Consolidated unsorted glacial deposits with particles ranging from boulder to mud in grain size and of highly variable composition.
        /// </summary>
        [EnumValueNameAttribute("tillite (diamictite)")]
        public static LithologyType TilliteDiamictite
        {
            get 
            {
                return tilliteDiamictite;
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

        private readonly static LithologyType tuff;
        /// <summary>
        /// An indurated pyroclastic deposit, predominantly consisting of fine-grained volcanic rocks: sedimentary particles may be present. Tuff may be deposited sub-aerially or sub-aqueously, and may be well sorted or heterogeneous.
        /// </summary>
        [EnumValueNameAttribute("tuff")]
        public static LithologyType Tuff
        {
            get 
            {
                return tuff;
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
            andesite = 
                new LithologyType("andesite")
                {
                    Description = "Intermediate porphyritic volcanic rock consisting of plagioclase, pyroxene, hornblende and bitotite."
            };
            anhydrite = 
                new LithologyType("anhydrite")
                {
                    Description = "The mineral form of anhydrous calcium sulfate, commonly massive in evaporite beds."
            };
            arkose = 
                new LithologyType("arkose")
                {
                    Description = "An indurated arenaceous deposit consisting chiefly of quartz and feldspar (>25%)."
            };
            basalt = 
                new LithologyType("basalt")
                {
                    Description = "Volcanic rock consisting essentially of plagioclase feldspar and pyroxene."
            };
            breccia = 
                new LithologyType("breccia")
                {
                    Description = "A lithified rock rich in angular fragments of size greater than 2mm."
            };
            calcarenite = 
                new LithologyType("calcarenite")
                {
                    Description = "A limestone more than half of which consists of cemented sand-size grains of calcium carbonate: a consolidated calcareous sand."
            };
            calcilutite = 
                new LithologyType("calcilutite")
                {
                    Description = "A limestone more than half of which consists of detrital calcite particles of silt and/or clay size: a consolidated calcareous mud."
            };
            calcisiltite = 
                new LithologyType("calcisiltite")
                {
                    Description = "A limestone more than half of which consists of detrital calcite particles of silt size: a consolidated calcareous silt."
            };
            chalk = 
                new LithologyType("chalk")
                {
                    Description = "A fine-grained limestone composed largely of coccolith fragments."
            };
            chert = 
                new LithologyType("chert")
                {
                    Description = "Siliceous sedimentary rock containing finely crystalline snd fibrous quartz."
            };
            clay = 
                new LithologyType("clay")
                {
                    Description = "Unconsolidated deposit of very fine particles of size generally less than 1/256mm and composed of clay minerals."
            };
            claystone = 
                new LithologyType("claystone")
                {
                    Description = "An indurated clay, lacking the fissility of shale."
            };
            coal = 
                new LithologyType("coal")
                {
                    Description = "A combustible organic sedimentary rock with less than 40% of mineral matter (based on dry material) composed of polymers of cyclic hydrocarbons."
            };
            conglomerate = 
                new LithologyType("conglomerate")
                {
                    Description = "An indurated sedimentary rock containing an essential quantity of rounded rock fragments larger than 2mm, and normally having a matrix of sand."
            };
            diabase = 
                new LithologyType("diabase")
                {
                    Description = "Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite."
            };
            diorite = 
                new LithologyType("diorite")
                {
                    Description = "Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite."
            };
            dolomite = 
                new LithologyType("dolomite")
                {
                    Description = "Sedimentary rock containing more than 90% dolomite (mineral) and less than 10% calcite."
            };
            dolomiteCalcareous = 
                new LithologyType("dolomite, calcareous")
                {
                    Description = "A dolomite rock containing more than 10% calcite."
            };
            extrusiveRockVolcanic = 
                new LithologyType("extrusive rock (volcanic)")
                {
                    Description = "Igneous rocks formed by solidification of material erupted sub-aerially or sub-aqueously onto the earth's surface, as either lava flows or pyroclastic material."
            };
            feldspar = 
                new LithologyType("feldspar")
                {
                    Description = "The family of aluminium silicates of sodium, potassium, calcium and other metals which comprise over 60% of the earth's crust, are the most abundant mineral group, and occur in all types of rocks."
            };
            gabbro = 
                new LithologyType("gabbro")
                {
                    Description = "Coarse grained plutonic igneous rock composed essentially of calcic plagioclase feldspar, pyroxenes and iron oxide."
            };
            glauconite = 
                new LithologyType("glauconite")
                {
                    Description = "A mineral composed of ferrous potassium silicates related to mica which commonly imparts a green color to its sedimentary host rock."
            };
            gneiss = 
                new LithologyType("gneiss")
                {
                    Description = "A metamorphic rock, commonly foliated and crystalline, whose mineral content can range from quartz and feldspars to amphiboles and pyroxenes."
            };
            granite = 
                new LithologyType("granite")
                {
                    Description = "Coarse grained plutonic rock typically containing free quartz, alkali feldspar and biotite mica."
            };
            gravel = 
                new LithologyType("gravel")
                {
                    Description = "An unconsolidated deposit of coarse clastics. The diameters on the Wenworth scale are generally greater than 2mm."
            };
            greenstones = 
                new LithologyType("greenstones")
                {
                    Description = "A field term for any dark fine grained altered or metamorphosed basic igneous rock."
            };
            greywacke = 
                new LithologyType("greywacke")
                {
                    Description = "A dark grey consolidated deposit containing feldspar, rock fragments and a dark chloritic matrix."
            };
            gumbo = 
                new LithologyType("gumbo")
                {
                    Description = "A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet."
            };
            gypsum = 
                new LithologyType("gypsum")
                {
                    Description = "A mineral composed of hydrous calcium sulphate, commonly forming thick extensive evaporite beds."
            };
            halite = 
                new LithologyType("halite")
                {
                    Description = "A mineral composed of sodium chloride common in evaporite rocks."
            };
            igneous = 
                new LithologyType("igneous")
                {
                    Description = "Term applied to rock or mineral formed by solidification of molten or partly molten material (magma)."
            };
            intrusvieRockPlutonic = 
                new LithologyType("intrusvie rock (plutonic)")
                {
                    Description = "Igneous rock formed by cooling and solidification of magma within the earth's crust."
            };
            lignite = 
                new LithologyType("lignite")
                {
                    Description = "A low-rank humic coal."
            };
            limestone = 
                new LithologyType("limestone")
                {
                    Description = "A sedimentary rock composed mostly of the mineral calcite (calcium carbonate) which is the consolidated equivalent of lime mud, calcareous sand, and/or shell fragments."
            };
            limestoneArgillaceous = 
                new LithologyType("limestone, argillaceous")
                {
                    Description = "A limestone homogeneously mixed with 10-50% clay minerals."
            };
            limestoneDolomitic = 
                new LithologyType("limestone, dolomitic")
                {
                    Description = "A limestone containing 10-50% dolomite and 50-90% calcite."
            };
            limestoneSandy = 
                new LithologyType("limestone, sandy")
                {
                    Description = "A limestone homogeneously mixed with 10-50% quartz grains."
            };
            marble = 
                new LithologyType("marble")
                {
                    Description = "A metamorphic rock composed of calcite."
            };
            marl = 
                new LithologyType("marl")
                {
                    Description = "A consolidated or semi-consolidated mixture of clay and generally fine grained carbonate material."
            };
            metamorphicRocks = 
                new LithologyType("metamorphic rocks")
                {
                    Description = "Rocks formed by mineralogical, chemical and structural alteration of pre-existing rocks under conditions of temperature and pressure at depth in the earth."
            };
            mudstone = 
                new LithologyType("mudstone")
                {
                    Description = "Consolidated and indurated mud."
            };
            noDescription = 
                new LithologyType("no description")
                {
                    Description = "No description is provided."
            };
            noSample = 
                new LithologyType("no sample")
                {
                    Description = "No sample is provided."
            };
            ophiolite = 
                new LithologyType("ophiolite")
                {
                    Description = "Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust."
            };
            peat = 
                new LithologyType("peat")
                {
                    Description = "Unconsolidated, semi-carbonised plant remains which are a precursor of humic coal."
            };
            phosphate = 
                new LithologyType("phosphate")
                {
                    Description = "Any mineral compound containing the ((PO4)3) radical."
            };
            phosphateRock = 
                new LithologyType("phosphate rock")
                {
                    Description = "Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource."
            };
            potassiumAndMagnesiumSalts = 
                new LithologyType("potassium and magnesium salts")
                {
                    Description = "Salts such as sylvinite, carnalite, keiserite with swelling properties that can severely obstruct drilling operations."
            };
            quartzite = 
                new LithologyType("quartzite")
                {
                    Description = "A sedimentary rock composed of more than 95% of quartz."
            };
            rhyolite = 
                new LithologyType("rhyolite")
                {
                    Description = "Silica rich volcanic rock consisting of quartz and alkali feldspar with minor plagioclase and biotite."
            };
            salt = 
                new LithologyType("salt")
                {
                    Description = "Common term for naturally occurring sodium chloride."
            };
            sand = 
                new LithologyType("sand")
                {
                    Description = "An aggregation of particles having diameters in the range 1/16mm to 2mm usually consisting of quartz."
            };
            sandstone = 
                new LithologyType("sandstone")
                {
                    Description = "A sedimentary rock composed of indurated sand."
            };
            schist = 
                new LithologyType("schist")
                {
                    Description = "A strongly foliated crystalline metamorphic rock."
            };
            serpentine = 
                new LithologyType("serpentine")
                {
                    Description = "A rock forming mineral of hydrous iron and magnesium silicates, often resulting from metamorhism of amphiboles and pyroxenes."
            };
            shale = 
                new LithologyType("shale")
                {
                    Description = "A fine-grained sedimentary rock formed by the compaction of clay, silt or mud."
            };
            silt = 
                new LithologyType("silt")
                {
                    Description = "Unconsolidated sedimentary material with grain sizes between 1/16mm and 1/256mm."
            };
            siltstone = 
                new LithologyType("siltstone")
                {
                    Description = "Consolidated silt."
            };
            slate = 
                new LithologyType("slate")
                {
                    Description = "A compact fine-grained metamorphic rock displaying slaty cleavage along which the rock may be cut into sheets."
            };
            syenite = 
                new LithologyType("syenite")
                {
                    Description = "Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz."
            };
            tilliteDiamictite = 
                new LithologyType("tillite (diamictite)")
                {
                    Description = "Consolidated unsorted glacial deposits with particles ranging from boulder to mud in grain size and of highly variable composition."
            };
            trachyte = 
                new LithologyType("trachyte")
                {
                    Description = "A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals."
            };
            tuff = 
                new LithologyType("tuff")
                {
                    Description = "An indurated pyroclastic deposit, predominantly consisting of fine-grained volcanic rocks: sedimentary particles may be present. Tuff may be deposited sub-aerially or sub-aqueously, and may be well sorted or heterogeneous."
            };
            ultrabasic = 
                new LithologyType("ultrabasic")
                {
                    Description = "A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%."
            };
            undifferentiated = 
                new LithologyType("undifferentiated")
                {
                    Description = "The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent."
            };
            unknown = 
                new LithologyType("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
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
    /// These values represent the type of qualifier in lithology.
    /// </summary>
    public class QualifierType : Energistics.DataAccess.EnumValue.EnumValue
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

        private readonly static QualifierType anhydritic;
        /// <summary>
        /// Indicates that the associated lithology contains anhydrite
        /// </summary>
        [EnumValueNameAttribute("anhydritic")]
        public static QualifierType Anhydritic
        {
            get 
            {
                return anhydritic;
            }
        }

        private readonly static QualifierType argillaceous;
        /// <summary>
        /// Indicates that the associated lithology has a clay content
        /// </summary>
        [EnumValueNameAttribute("argillaceous")]
        public static QualifierType Argillaceous
        {
            get 
            {
                return argillaceous;
            }
        }

        private readonly static QualifierType barite;
        /// <summary>
        /// The mineral form of Barium sulphate.
        /// </summary>
        [EnumValueNameAttribute("barite")]
        public static QualifierType Barite
        {
            get 
            {
                return barite;
            }
        }

        private readonly static QualifierType belemnitic;
        /// <summary>
        /// Indicates that the associated lithology contains belemnite fossils or fragments thereof.
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
        /// Indicates that the associated lithology has been disturbed by organisms before consolidation.
        /// </summary>
        [EnumValueNameAttribute("bioturbated")]
        public static QualifierType Bioturbated
        {
            get 
            {
                return bioturbated;
            }
        }

        private readonly static QualifierType bituminous;
        /// <summary>
        /// Indicates that the associated lithology contains bituminous material
        /// </summary>
        [EnumValueNameAttribute("bituminous")]
        public static QualifierType Bituminous
        {
            get 
            {
                return bituminous;
            }
        }

        private readonly static QualifierType bryozoans;
        /// <summary>
        /// Indicates that the associated lithology contains bryozoan fossils or fragments thereof.
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
        /// Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation
        /// </summary>
        [EnumValueNameAttribute("burrowed")]
        public static QualifierType Burrowed
        {
            get 
            {
                return burrowed;
            }
        }

        private readonly static QualifierType calcareous;
        /// <summary>
        /// Indicates that the associated lithology has a calcite content
        /// </summary>
        [EnumValueNameAttribute("calcareous")]
        public static QualifierType Calcareous
        {
            get 
            {
                return calcareous;
            }
        }

        private readonly static QualifierType calciteConcr;
        /// <summary>
        /// Indicates that the associated lithology has calcite concretions
        /// </summary>
        [EnumValueNameAttribute("calcite concr")]
        public static QualifierType CalciteConcr
        {
            get 
            {
                return calciteConcr;
            }
        }

        private readonly static QualifierType carbonaceous;
        /// <summary>
        /// Indicates that the associated lithology contains carbonaceous material
        /// </summary>
        [EnumValueNameAttribute("carbonaceous")]
        public static QualifierType Carbonaceous
        {
            get 
            {
                return carbonaceous;
            }
        }

        private readonly static QualifierType chalky;
        /// <summary>
        /// Indicates that the associated lithology has a chalk content
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
        /// Indicates that the associated lithology contains chamosite
        /// </summary>
        [EnumValueNameAttribute("chamosite")]
        public static QualifierType Chamosite
        {
            get 
            {
                return chamosite;
            }
        }

        private readonly static QualifierType chert;
        /// <summary>
        /// Indicates that the associated lithology contains chert fragments
        /// </summary>
        [EnumValueNameAttribute("chert")]
        public static QualifierType Chert
        {
            get 
            {
                return chert;
            }
        }

        private readonly static QualifierType chlorite;
        /// <summary>
        /// Indicates that the associated lithology contains chlorite
        /// </summary>
        [EnumValueNameAttribute("chlorite")]
        public static QualifierType Chlorite
        {
            get 
            {
                return chlorite;
            }
        }

        private readonly static QualifierType concretions;
        /// <summary>
        /// Indicates that the associated lithology contains concretions
        /// </summary>
        [EnumValueNameAttribute("concretions")]
        public static QualifierType Concretions
        {
            get 
            {
                return concretions;
            }
        }

        private readonly static QualifierType conglomeratic;
        /// <summary>
        /// Indicates that the associated lithology contains conglomerate rock material.
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
        /// Indicates that the associated lithology contains corals and/or coral fragments
        /// </summary>
        [EnumValueNameAttribute("coral")]
        public static QualifierType Coral
        {
            get 
            {
                return coral;
            }
        }

        private readonly static QualifierType crinoids;
        /// <summary>
        /// Indicates that the associated lithology contains crinoids and/or crinoid fragments
        /// </summary>
        [EnumValueNameAttribute("crinoids")]
        public static QualifierType Crinoids
        {
            get 
            {
                return crinoids;
            }
        }

        private readonly static QualifierType diatoms;
        /// <summary>
        /// Indicates that the associated lithology contains diatoms and/or diatom fragments
        /// </summary>
        [EnumValueNameAttribute("diatoms")]
        public static QualifierType Diatoms
        {
            get 
            {
                return diatoms;
            }
        }

        private readonly static QualifierType dolomiteConcretion;
        /// <summary>
        /// Indicates that the associated lithology has dolomite concretions
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
        /// Indicates that the associated lithology contains thin beds or veins of dolomite
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
        /// Indicates that the associated lithology has a dolomite content
        /// </summary>
        [EnumValueNameAttribute("dolomitic")]
        public static QualifierType Dolomitic
        {
            get 
            {
                return dolomitic;
            }
        }

        private readonly static QualifierType dolomite;
        /// <summary>
        /// A rock forming mineral composed of calcium-magnesium carbonate (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static QualifierType Dolomite
        {
            get 
            {
                return dolomite;
            }
        }

        private readonly static QualifierType feldspar;
        /// <summary>
        /// Indicates that the associated lithology contains feldspar
        /// </summary>
        [EnumValueNameAttribute("feldspar")]
        public static QualifierType Feldspar
        {
            get 
            {
                return feldspar;
            }
        }

        private readonly static QualifierType ferruginous;
        /// <summary>
        /// Indicates that the associated lithology contains minerals rich in iron oxide or iron hydroxide
        /// </summary>
        [EnumValueNameAttribute("ferruginous")]
        public static QualifierType Ferruginous
        {
            get 
            {
                return ferruginous;
            }
        }

        private readonly static QualifierType fissile;
        /// <summary>
        /// Indicates that the associated lithology is fissile
        /// </summary>
        [EnumValueNameAttribute("fissile")]
        public static QualifierType Fissile
        {
            get 
            {
                return fissile;
            }
        }

        private readonly static QualifierType foramsUndifferentiated;
        /// <summary>
        /// Indicates that the associated lithology contains foraminifera
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
        /// Indicates that the associated lithology contains fossil fragments
        /// </summary>
        [EnumValueNameAttribute("fossil fragment")]
        public static QualifierType FossilFragment
        {
            get 
            {
                return fossilFragment;
            }
        }

        private readonly static QualifierType fossilsUndifferentiated;
        /// <summary>
        /// Indicates that the associated lithology contains fossils
        /// </summary>
        [EnumValueNameAttribute("fossils undifferentiated")]
        public static QualifierType FossilsUndifferentiated
        {
            get 
            {
                return fossilsUndifferentiated;
            }
        }

        private readonly static QualifierType glauconite;
        /// <summary>
        /// Indicates that the associated lithology contains glauconite granules
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
        /// Indicates that the associated lithology is glauconitic
        /// </summary>
        [EnumValueNameAttribute("glauconitic")]
        public static QualifierType Glauconitic
        {
            get 
            {
                return glauconitic;
            }
        }

        private readonly static QualifierType gravelly;
        /// <summary>
        /// Indicates that the associated lithology contains gravel sized particles.
        /// </summary>
        [EnumValueNameAttribute("gravelly")]
        public static QualifierType Gravelly
        {
            get 
            {
                return gravelly;
            }
        }

        private readonly static QualifierType gypsiferous;
        /// <summary>
        /// Indicates that the associated lithology contains significant gypsum content.
        /// </summary>
        [EnumValueNameAttribute("gypsiferous")]
        public static QualifierType Gypsiferous
        {
            get 
            {
                return gypsiferous;
            }
        }

        private readonly static QualifierType halite;
        /// <summary>
        /// Indicates that the associated lithology contains halite
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static QualifierType Halite
        {
            get 
            {
                return halite;
            }
        }

        private readonly static QualifierType illite;
        /// <summary>
        /// Indicates that the associated lithology contains the clay mineral illite
        /// </summary>
        [EnumValueNameAttribute("illite")]
        public static QualifierType Illite
        {
            get 
            {
                return illite;
            }
        }

        private readonly static QualifierType kaolinite;
        /// <summary>
        /// Indicates that the associated lithology contains kaolinite
        /// </summary>
        [EnumValueNameAttribute("kaolinite")]
        public static QualifierType Kaolinite
        {
            get 
            {
                return kaolinite;
            }
        }

        private readonly static QualifierType lignite;
        /// <summary>
        /// Indicates that the associated lithology contains lignite
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static QualifierType Lignite
        {
            get 
            {
                return lignite;
            }
        }

        private readonly static QualifierType limestoneStringer;
        /// <summary>
        /// Indicates that the associated lithology contains thin beds or veins of limestone
        /// </summary>
        [EnumValueNameAttribute("limestone stringer")]
        public static QualifierType LimestoneStringer
        {
            get 
            {
                return limestoneStringer;
            }
        }

        private readonly static QualifierType lithicFragment;
        /// <summary>
        /// Indicates that the associated lithology contains other rock fragments
        /// </summary>
        [EnumValueNameAttribute("lithic fragment")]
        public static QualifierType LithicFragment
        {
            get 
            {
                return lithicFragment;
            }
        }

        private readonly static QualifierType marly;
        /// <summary>
        /// Indicates that the associated lithology contains marl
        /// </summary>
        [EnumValueNameAttribute("marly")]
        public static QualifierType Marly
        {
            get 
            {
                return marly;
            }
        }

        private readonly static QualifierType mica;
        /// <summary>
        /// Indicates that the associated lithology contains mica
        /// </summary>
        [EnumValueNameAttribute("mica")]
        public static QualifierType Mica
        {
            get 
            {
                return mica;
            }
        }

        private readonly static QualifierType microfossil;
        /// <summary>
        /// Indicates that the associated lithology contains undifferentiated microfossils
        /// </summary>
        [EnumValueNameAttribute("microfossil")]
        public static QualifierType Microfossil
        {
            get 
            {
                return microfossil;
            }
        }

        private readonly static QualifierType noDescription;
        /// <summary>
        /// No description is provided
        /// </summary>
        [EnumValueNameAttribute("no description")]
        public static QualifierType NoDescription
        {
            get 
            {
                return noDescription;
            }
        }

        private readonly static QualifierType none;
        /// <summary>
        /// No qualifiers specified
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
        /// A rock composed of stacked oncoliths
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
        /// A hemispheroidal mass of calcified algal laminae surrounding a mud fragment
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
        /// Indicates that the associated lithology contains oncolites
        /// </summary>
        [EnumValueNameAttribute("oncolithic")]
        public static QualifierType Oncolithic
        {
            get 
            {
                return oncolithic;
            }
        }

        private readonly static QualifierType ooidOrOolith;
        /// <summary>
        /// Indicates that the associated lithology contains ooids (synonym: ooliths)
        /// </summary>
        [EnumValueNameAttribute("ooid or oolith")]
        public static QualifierType OoidOrOolith
        {
            get 
            {
                return ooidOrOolith;
            }
        }

        private readonly static QualifierType ostracods;
        /// <summary>
        /// Indicates that the associated lithology contains ostracod fossils
        /// </summary>
        [EnumValueNameAttribute("ostracods")]
        public static QualifierType Ostracods
        {
            get 
            {
                return ostracods;
            }
        }

        private readonly static QualifierType pebbly;
        /// <summary>
        /// Indicates that the associated material contains pebble sized particles.
        /// </summary>
        [EnumValueNameAttribute("pebbly")]
        public static QualifierType Pebbly
        {
            get 
            {
                return pebbly;
            }
        }

        private readonly static QualifierType pelletal;
        /// <summary>
        /// Indicates that the associated lithology contains pellets or fragments of pellets.
        /// </summary>
        [EnumValueNameAttribute("pelletal")]
        public static QualifierType Pelletal
        {
            get 
            {
                return pelletal;
            }
        }

        private readonly static QualifierType pellet;
        /// <summary>
        /// A round or rounded particle generally less than 10mm in diameter, not formed by rounding of detrital material.
        /// </summary>
        [EnumValueNameAttribute("pellet")]
        public static QualifierType Pellet
        {
            get 
            {
                return pellet;
            }
        }

        private readonly static QualifierType peloid;
        /// <summary>
        /// A small particle of carbonate mineral in which individual crystals are too small to be distinguished either by the naked eye or under a polarizing microscope (less than 0.001mm).
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
        /// Indicates that the associated lithology contains peloids.
        /// </summary>
        [EnumValueNameAttribute("peloidal")]
        public static QualifierType Peloidal
        {
            get 
            {
                return peloidal;
            }
        }

        private readonly static QualifierType phosphate;
        /// <summary>
        /// Indicates that the associated lithology contains phosphates
        /// </summary>
        [EnumValueNameAttribute("phosphate")]
        public static QualifierType Phosphate
        {
            get 
            {
                return phosphate;
            }
        }

        private readonly static QualifierType pisolite;
        /// <summary>
        /// A sedimentary rock mainly consisting of pisoliths
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
        /// A sub-spherical body usually consisting of calcium carbonate, generally of length greater than 2mm
        /// </summary>
        [EnumValueNameAttribute("pisolith")]
        public static QualifierType Pisolith
        {
            get 
            {
                return pisolith;
            }
        }

        private readonly static QualifierType plantRemains;
        /// <summary>
        /// Indicates that the associated lithology contains plant remains
        /// </summary>
        [EnumValueNameAttribute("plant remains")]
        public static QualifierType PlantRemains
        {
            get 
            {
                return plantRemains;
            }
        }

        private readonly static QualifierType pyrite;
        /// <summary>
        /// Indicates that the associated lithology contains pyrite
        /// </summary>
        [EnumValueNameAttribute("pyrite")]
        public static QualifierType Pyrite
        {
            get 
            {
                return pyrite;
            }
        }

        private readonly static QualifierType quartz;
        /// <summary>
        /// Indicates that the associated lithology contains quartz
        /// </summary>
        [EnumValueNameAttribute("quartz")]
        public static QualifierType Quartz
        {
            get 
            {
                return quartz;
            }
        }

        private readonly static QualifierType radiolaria;
        /// <summary>
        /// Indicates that the associated lithology contains radiolaria
        /// </summary>
        [EnumValueNameAttribute("radiolaria")]
        public static QualifierType Radiolaria
        {
            get 
            {
                return radiolaria;
            }
        }

        private readonly static QualifierType salty;
        /// <summary>
        /// Indicates that the associated lithology contains rock salt or halite
        /// </summary>
        [EnumValueNameAttribute("salty")]
        public static QualifierType Salty
        {
            get 
            {
                return salty;
            }
        }

        private readonly static QualifierType sandy;
        /// <summary>
        /// Indicates that the associated lithology has a sand content
        /// </summary>
        [EnumValueNameAttribute("sandy")]
        public static QualifierType Sandy
        {
            get 
            {
                return sandy;
            }
        }

        private readonly static QualifierType shell;
        /// <summary>
        /// Indicates that the associated lithology contains shell fragments
        /// </summary>
        [EnumValueNameAttribute("shell")]
        public static QualifierType Shell
        {
            get 
            {
                return shell;
            }
        }

        private readonly static QualifierType siderite;
        /// <summary>
        /// Indicates that the associated lithology contains siderite
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
        /// Indicates that the associated lithology contains siderite concretions
        /// </summary>
        [EnumValueNameAttribute("siderite concretion")]
        public static QualifierType SideriteConcretion
        {
            get 
            {
                return sideriteConcretion;
            }
        }

        private readonly static QualifierType silty;
        /// <summary>
        /// Indicates that the associated lithology has a silt content
        /// </summary>
        [EnumValueNameAttribute("silty")]
        public static QualifierType Silty
        {
            get 
            {
                return silty;
            }
        }

        private readonly static QualifierType spicule;
        /// <summary>
        /// A minute needle-like body of quartz or carbonate that forms part of skeletons of animals such as sponges, corals and radiolarians.
        /// </summary>
        [EnumValueNameAttribute("spicule")]
        public static QualifierType Spicule
        {
            get 
            {
                return spicule;
            }
        }

        private readonly static QualifierType spicular;
        /// <summary>
        /// Indicates that the associated lithology contains spicules.
        /// </summary>
        [EnumValueNameAttribute("spicular")]
        public static QualifierType Spicular
        {
            get 
            {
                return spicular;
            }
        }

        private readonly static QualifierType stylolite;
        /// <summary>
        /// A small, more or less columnar, striated extension of a rock body that fits into a corresponding surface, common in carbonate rocks.
        /// </summary>
        [EnumValueNameAttribute("stylolite")]
        public static QualifierType Stylolite
        {
            get 
            {
                return stylolite;
            }
        }

        private readonly static QualifierType stylolitic;
        /// <summary>
        /// Indicates that the associated lithology contains stylolites.
        /// </summary>
        [EnumValueNameAttribute("stylolitic")]
        public static QualifierType Stylolitic
        {
            get 
            {
                return stylolitic;
            }
        }

        private readonly static QualifierType tuffaceous;
        /// <summary>
        /// Indicates that the associated lithology contains pyroclastic detrital material (tuff).
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
        /// Indicates that the associated lithology contains both pyroclastic and other detrital material.
        /// </summary>
        [EnumValueNameAttribute("tuffite")]
        public static QualifierType Tuffite
        {
            get 
            {
                return tuffite;
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
            anhydritic = 
                new QualifierType("anhydritic")
                {
                    Description = "Indicates that the associated lithology contains anhydrite"
            };
            argillaceous = 
                new QualifierType("argillaceous")
                {
                    Description = "Indicates that the associated lithology has a clay content"
            };
            barite = 
                new QualifierType("barite")
                {
                    Description = "The mineral form of Barium sulphate."
            };
            belemnitic = 
                new QualifierType("belemnitic")
                {
                    Description = "Indicates that the associated lithology contains belemnite fossils or fragments thereof."
            };
            bioturbated = 
                new QualifierType("bioturbated")
                {
                    Description = "Indicates that the associated lithology has been disturbed by organisms before consolidation."
            };
            bituminous = 
                new QualifierType("bituminous")
                {
                    Description = "Indicates that the associated lithology contains bituminous material"
            };
            bryozoans = 
                new QualifierType("bryozoans")
                {
                    Description = "Indicates that the associated lithology contains bryozoan fossils or fragments thereof."
            };
            burrowed = 
                new QualifierType("burrowed")
                {
                    Description = "Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation"
            };
            calcareous = 
                new QualifierType("calcareous")
                {
                    Description = "Indicates that the associated lithology has a calcite content"
            };
            calciteConcr = 
                new QualifierType("calcite concr")
                {
                    Description = "Indicates that the associated lithology has calcite concretions"
            };
            carbonaceous = 
                new QualifierType("carbonaceous")
                {
                    Description = "Indicates that the associated lithology contains carbonaceous material"
            };
            chalky = 
                new QualifierType("chalky")
                {
                    Description = "Indicates that the associated lithology has a chalk content"
            };
            chamosite = 
                new QualifierType("chamosite")
                {
                    Description = "Indicates that the associated lithology contains chamosite"
            };
            chert = 
                new QualifierType("chert")
                {
                    Description = "Indicates that the associated lithology contains chert fragments"
            };
            chlorite = 
                new QualifierType("chlorite")
                {
                    Description = "Indicates that the associated lithology contains chlorite"
            };
            concretions = 
                new QualifierType("concretions")
                {
                    Description = "Indicates that the associated lithology contains concretions"
            };
            conglomeratic = 
                new QualifierType("conglomeratic")
                {
                    Description = "Indicates that the associated lithology contains conglomerate rock material."
            };
            coral = 
                new QualifierType("coral")
                {
                    Description = "Indicates that the associated lithology contains corals and/or coral fragments"
            };
            crinoids = 
                new QualifierType("crinoids")
                {
                    Description = "Indicates that the associated lithology contains crinoids and/or crinoid fragments"
            };
            diatoms = 
                new QualifierType("diatoms")
                {
                    Description = "Indicates that the associated lithology contains diatoms and/or diatom fragments"
            };
            dolomiteConcretion = 
                new QualifierType("dolomite concretion")
                {
                    Description = "Indicates that the associated lithology has dolomite concretions"
            };
            dolomiteStringer = 
                new QualifierType("dolomite stringer")
                {
                    Description = "Indicates that the associated lithology contains thin beds or veins of dolomite"
            };
            dolomitic = 
                new QualifierType("dolomitic")
                {
                    Description = "Indicates that the associated lithology has a dolomite content"
            };
            dolomite = 
                new QualifierType("dolomite")
                {
                    Description = "A rock forming mineral composed of calcium-magnesium carbonate (CaMg(CO3)2)."
            };
            feldspar = 
                new QualifierType("feldspar")
                {
                    Description = "Indicates that the associated lithology contains feldspar"
            };
            ferruginous = 
                new QualifierType("ferruginous")
                {
                    Description = "Indicates that the associated lithology contains minerals rich in iron oxide or iron hydroxide"
            };
            fissile = 
                new QualifierType("fissile")
                {
                    Description = "Indicates that the associated lithology is fissile"
            };
            foramsUndifferentiated = 
                new QualifierType("forams undifferentiated")
                {
                    Description = "Indicates that the associated lithology contains foraminifera"
            };
            fossilFragment = 
                new QualifierType("fossil fragment")
                {
                    Description = "Indicates that the associated lithology contains fossil fragments"
            };
            fossilsUndifferentiated = 
                new QualifierType("fossils undifferentiated")
                {
                    Description = "Indicates that the associated lithology contains fossils"
            };
            glauconite = 
                new QualifierType("glauconite")
                {
                    Description = "Indicates that the associated lithology contains glauconite granules"
            };
            glauconitic = 
                new QualifierType("glauconitic")
                {
                    Description = "Indicates that the associated lithology is glauconitic"
            };
            gravelly = 
                new QualifierType("gravelly")
                {
                    Description = "Indicates that the associated lithology contains gravel sized particles."
            };
            gypsiferous = 
                new QualifierType("gypsiferous")
                {
                    Description = "Indicates that the associated lithology contains significant gypsum content."
            };
            halite = 
                new QualifierType("halite")
                {
                    Description = "Indicates that the associated lithology contains halite"
            };
            illite = 
                new QualifierType("illite")
                {
                    Description = "Indicates that the associated lithology contains the clay mineral illite"
            };
            kaolinite = 
                new QualifierType("kaolinite")
                {
                    Description = "Indicates that the associated lithology contains kaolinite"
            };
            lignite = 
                new QualifierType("lignite")
                {
                    Description = "Indicates that the associated lithology contains lignite"
            };
            limestoneStringer = 
                new QualifierType("limestone stringer")
                {
                    Description = "Indicates that the associated lithology contains thin beds or veins of limestone"
            };
            lithicFragment = 
                new QualifierType("lithic fragment")
                {
                    Description = "Indicates that the associated lithology contains other rock fragments"
            };
            marly = 
                new QualifierType("marly")
                {
                    Description = "Indicates that the associated lithology contains marl"
            };
            mica = 
                new QualifierType("mica")
                {
                    Description = "Indicates that the associated lithology contains mica"
            };
            microfossil = 
                new QualifierType("microfossil")
                {
                    Description = "Indicates that the associated lithology contains undifferentiated microfossils"
            };
            noDescription = 
                new QualifierType("no description")
                {
                    Description = "No description is provided"
            };
            none = 
                new QualifierType("none")
                {
                    Description = "No qualifiers specified"
            };
            oncolite = 
                new QualifierType("oncolite")
                {
                    Description = "A rock composed of stacked oncoliths"
            };
            oncolith = 
                new QualifierType("oncolith")
                {
                    Description = "A hemispheroidal mass of calcified algal laminae surrounding a mud fragment"
            };
            oncolithic = 
                new QualifierType("oncolithic")
                {
                    Description = "Indicates that the associated lithology contains oncolites"
            };
            ooidOrOolith = 
                new QualifierType("ooid or oolith")
                {
                    Description = "Indicates that the associated lithology contains ooids (synonym: ooliths)"
            };
            ostracods = 
                new QualifierType("ostracods")
                {
                    Description = "Indicates that the associated lithology contains ostracod fossils"
            };
            pebbly = 
                new QualifierType("pebbly")
                {
                    Description = "Indicates that the associated material contains pebble sized particles."
            };
            pelletal = 
                new QualifierType("pelletal")
                {
                    Description = "Indicates that the associated lithology contains pellets or fragments of pellets."
            };
            pellet = 
                new QualifierType("pellet")
                {
                    Description = "A round or rounded particle generally less than 10mm in diameter, not formed by rounding of detrital material."
            };
            peloid = 
                new QualifierType("peloid")
                {
                    Description = "A small particle of carbonate mineral in which individual crystals are too small to be distinguished either by the naked eye or under a polarizing microscope (less than 0.001mm)."
            };
            peloidal = 
                new QualifierType("peloidal")
                {
                    Description = "Indicates that the associated lithology contains peloids."
            };
            phosphate = 
                new QualifierType("phosphate")
                {
                    Description = "Indicates that the associated lithology contains phosphates"
            };
            pisolite = 
                new QualifierType("pisolite")
                {
                    Description = "A sedimentary rock mainly consisting of pisoliths"
            };
            pisolith = 
                new QualifierType("pisolith")
                {
                    Description = "A sub-spherical body usually consisting of calcium carbonate, generally of length greater than 2mm"
            };
            plantRemains = 
                new QualifierType("plant remains")
                {
                    Description = "Indicates that the associated lithology contains plant remains"
            };
            pyrite = 
                new QualifierType("pyrite")
                {
                    Description = "Indicates that the associated lithology contains pyrite"
            };
            quartz = 
                new QualifierType("quartz")
                {
                    Description = "Indicates that the associated lithology contains quartz"
            };
            radiolaria = 
                new QualifierType("radiolaria")
                {
                    Description = "Indicates that the associated lithology contains radiolaria"
            };
            salty = 
                new QualifierType("salty")
                {
                    Description = "Indicates that the associated lithology contains rock salt or halite"
            };
            sandy = 
                new QualifierType("sandy")
                {
                    Description = "Indicates that the associated lithology has a sand content"
            };
            shell = 
                new QualifierType("shell")
                {
                    Description = "Indicates that the associated lithology contains shell fragments"
            };
            siderite = 
                new QualifierType("siderite")
                {
                    Description = "Indicates that the associated lithology contains siderite"
            };
            sideriteConcretion = 
                new QualifierType("siderite concretion")
                {
                    Description = "Indicates that the associated lithology contains siderite concretions"
            };
            silty = 
                new QualifierType("silty")
                {
                    Description = "Indicates that the associated lithology has a silt content"
            };
            spicule = 
                new QualifierType("spicule")
                {
                    Description = "A minute needle-like body of quartz or carbonate that forms part of skeletons of animals such as sponges, corals and radiolarians."
            };
            spicular = 
                new QualifierType("spicular")
                {
                    Description = "Indicates that the associated lithology contains spicules."
            };
            stylolite = 
                new QualifierType("stylolite")
                {
                    Description = "A small, more or less columnar, striated extension of a rock body that fits into a corresponding surface, common in carbonate rocks."
            };
            stylolitic = 
                new QualifierType("stylolitic")
                {
                    Description = "Indicates that the associated lithology contains stylolites."
            };
            tuffaceous = 
                new QualifierType("tuffaceous")
                {
                    Description = "Indicates that the associated lithology contains pyroclastic detrital material (tuff)."
            };
            tuffite = 
                new QualifierType("tuffite")
                {
                    Description = "Indicates that the associated lithology contains both pyroclastic and other detrital material."
            };
            unknown = 
                new QualifierType("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
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
    /// These values represent the name of a recording channel.
    /// </summary>
    public class RealtimeData : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected RealtimeData(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the RealtimeData</param>
        public RealtimeData(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of RealtimeDatas
        /// </summary>
        /// <returns>The complete list of RealtimeDatas</returns>
        public static List<RealtimeData> GetList()
        {
            return GetList<RealtimeData>();
        }

        private readonly static RealtimeData lengthAlongFiber;
        /// <summary>
        /// The position along the length of a DTS fiber.
        /// </summary>
        [EnumValueNameAttribute("length along fiber")]
        public static RealtimeData LengthAlongFiber
        {
            get 
            {
                return lengthAlongFiber;
            }
        }

        private readonly static RealtimeData dtsTemperature;
        /// <summary>
        /// The temperature that was calculated from Distributed Temperature Survey data.
        /// </summary>
        [EnumValueNameAttribute("DTS temperature")]
        public static RealtimeData DtsTemperature
        {
            get 
            {
                return dtsTemperature;
            }
        }

        private readonly static RealtimeData stokesIntensity;
        /// <summary>
        /// Stokes intensity values from a Distributed Temperature Survey.
        /// </summary>
        [EnumValueNameAttribute("Stokes intensity")]
        public static RealtimeData StokesIntensity
        {
            get 
            {
                return stokesIntensity;
            }
        }

        private readonly static RealtimeData antistokesIntensity;
        /// <summary>
        /// Anti-Stokes intensity values from a Distributed Temperature Survey.
        /// </summary>
        [EnumValueNameAttribute("anti-Stokes intensity")]
        public static RealtimeData AntistokesIntensity
        {
            get 
            {
                return antistokesIntensity;
            }
        }

        private readonly static RealtimeData acetylene;
        /// <summary>
        /// Acetylene ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("acetylene")]
        public static RealtimeData Acetylene
        {
            get 
            {
                return acetylene;
            }
        }

        private readonly static RealtimeData azimuthCorrected;
        /// <summary>
        /// MWD azimuth (corrected)
        /// </summary>
        [EnumValueNameAttribute("azimuth corrected")]
        public static RealtimeData AzimuthCorrected
        {
            get 
            {
                return azimuthCorrected;
            }
        }

        private readonly static RealtimeData azimuthUncorrected;
        /// <summary>
        /// MWD azimuth (uncorrected)
        /// </summary>
        [EnumValueNameAttribute("azimuth uncorrected")]
        public static RealtimeData AzimuthUncorrected
        {
            get 
            {
                return azimuthUncorrected;
            }
        }

        private readonly static RealtimeData bitRevolutionsCumulative;
        /// <summary>
        /// Bit revolutions, cumulative
        /// </summary>
        [EnumValueNameAttribute("bit revolutions, cumulative")]
        public static RealtimeData BitRevolutionsCumulative
        {
            get 
            {
                return bitRevolutionsCumulative;
            }
        }

        private readonly static RealtimeData buildRate;
        /// <summary>
        /// MWD build rate
        /// </summary>
        [EnumValueNameAttribute("build rate")]
        public static RealtimeData BuildRate
        {
            get 
            {
                return buildRate;
            }
        }

        private readonly static RealtimeData caliper;
        /// <summary>
        /// Caliper measurement
        /// </summary>
        [EnumValueNameAttribute("caliper")]
        public static RealtimeData Caliper
        {
            get 
            {
                return caliper;
            }
        }

        private readonly static RealtimeData cavings;
        /// <summary>
        /// Cavings percentage
        /// </summary>
        [EnumValueNameAttribute("cavings")]
        public static RealtimeData Cavings
        {
            get 
            {
                return cavings;
            }
        }

        private readonly static RealtimeData cationExchangeCapacity;
        /// <summary>
        /// Cation exchange capacity
        /// </summary>
        [EnumValueNameAttribute("cation exchange capacity")]
        public static RealtimeData CationExchangeCapacity
        {
            get 
            {
                return cationExchangeCapacity;
            }
        }

        private readonly static RealtimeData cementingCumulativeReturns;
        /// <summary>
        /// Cementing cumulative returns
        /// </summary>
        [EnumValueNameAttribute("cementing cumulative returns")]
        public static RealtimeData CementingCumulativeReturns
        {
            get 
            {
                return cementingCumulativeReturns;
            }
        }

        private readonly static RealtimeData cementingDensityInAverage;
        /// <summary>
        /// Cementing fluid density in (average)
        /// </summary>
        [EnumValueNameAttribute("cementing density in (average)")]
        public static RealtimeData CementingDensityInAverage
        {
            get 
            {
                return cementingDensityInAverage;
            }
        }

        private readonly static RealtimeData cementingDensityOutAverage;
        /// <summary>
        /// Cementing fluid density out (average)
        /// </summary>
        [EnumValueNameAttribute("cementing density out (average)")]
        public static RealtimeData CementingDensityOutAverage
        {
            get 
            {
                return cementingDensityOutAverage;
            }
        }

        private readonly static RealtimeData cementingEcdAtCasingShoe;
        /// <summary>
        /// Cementing effective circulating density at casing shoe
        /// </summary>
        [EnumValueNameAttribute("cementing ECD at casing shoe")]
        public static RealtimeData CementingEcdAtCasingShoe
        {
            get 
            {
                return cementingEcdAtCasingShoe;
            }
        }

        private readonly static RealtimeData cementingFlowRateInAverage;
        /// <summary>
        /// Cementing flow rate in (average)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate in (average)")]
        public static RealtimeData CementingFlowRateInAverage
        {
            get 
            {
                return cementingFlowRateInAverage;
            }
        }

        private readonly static RealtimeData cementingFlowRateInCalculated;
        /// <summary>
        /// Cementing flow rate in (calculated)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate in (calculated)")]
        public static RealtimeData CementingFlowRateInCalculated
        {
            get 
            {
                return cementingFlowRateInCalculated;
            }
        }

        private readonly static RealtimeData cementingFlowRateOutAverage;
        /// <summary>
        /// Cementing flow rate out (average)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (average)")]
        public static RealtimeData CementingFlowRateOutAverage
        {
            get 
            {
                return cementingFlowRateOutAverage;
            }
        }

        private readonly static RealtimeData cementingFlowRateOutCalculated;
        /// <summary>
        /// Cementing flow rate out (calculated)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (calculated)")]
        public static RealtimeData CementingFlowRateOutCalculated
        {
            get 
            {
                return cementingFlowRateOutCalculated;
            }
        }

        private readonly static RealtimeData cementingFlowRateOutRelative;
        /// <summary>
        /// Cementing flow rate out (percentage)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (relative)")]
        public static RealtimeData CementingFlowRateOutRelative
        {
            get 
            {
                return cementingFlowRateOutRelative;
            }
        }

        private readonly static RealtimeData cementingFluidType;
        /// <summary>
        /// Cementing fluid type/batch
        /// </summary>
        [EnumValueNameAttribute("cementing fluid type")]
        public static RealtimeData CementingFluidType
        {
            get 
            {
                return cementingFluidType;
            }
        }

        private readonly static RealtimeData cementingJobType;
        /// <summary>
        /// Cementing job type
        /// </summary>
        [EnumValueNameAttribute("cementing job type")]
        public static RealtimeData CementingJobType
        {
            get 
            {
                return cementingJobType;
            }
        }

        private readonly static RealtimeData cementingPlugs;
        /// <summary>
        /// Cementing number and status of plugs
        /// </summary>
        [EnumValueNameAttribute("cementing plugs")]
        public static RealtimeData CementingPlugs
        {
            get 
            {
                return cementingPlugs;
            }
        }

        private readonly static RealtimeData cementingPumpPressureAverage;
        /// <summary>
        /// Cementing pump pressure (average)
        /// </summary>
        [EnumValueNameAttribute("cementing pump pressure (average)")]
        public static RealtimeData CementingPumpPressureAverage
        {
            get 
            {
                return cementingPumpPressureAverage;
            }
        }

        private readonly static RealtimeData cementingStage;
        /// <summary>
        /// Cementing stage number
        /// </summary>
        [EnumValueNameAttribute("cementing stage")]
        public static RealtimeData CementingStage
        {
            get 
            {
                return cementingStage;
            }
        }

        private readonly static RealtimeData cementingTemperatureInAverage;
        /// <summary>
        /// Cementing fluid temperature in (average)
        /// </summary>
        [EnumValueNameAttribute("cementing temperature in (average)")]
        public static RealtimeData CementingTemperatureInAverage
        {
            get 
            {
                return cementingTemperatureInAverage;
            }
        }

        private readonly static RealtimeData cementingTemperatureOutAverage;
        /// <summary>
        /// Cementing fluid temperature out (average)
        /// </summary>
        [EnumValueNameAttribute("cementing temperature out (average)")]
        public static RealtimeData CementingTemperatureOutAverage
        {
            get 
            {
                return cementingTemperatureOutAverage;
            }
        }

        private readonly static RealtimeData cementingVolumeToBumpPlug;
        /// <summary>
        /// Cementing volume to bump plug
        /// </summary>
        [EnumValueNameAttribute("cementing volume to bump plug")]
        public static RealtimeData CementingVolumeToBumpPlug
        {
            get 
            {
                return cementingVolumeToBumpPlug;
            }
        }

        private readonly static RealtimeData cementingCementVolume;
        /// <summary>
        /// Cementing cement volume pumped
        /// </summary>
        [EnumValueNameAttribute("cementing cement volume")]
        public static RealtimeData CementingCementVolume
        {
            get 
            {
                return cementingCementVolume;
            }
        }

        private readonly static RealtimeData cementingIndividualVolume;
        /// <summary>
        /// Cementing individual volume pumped
        /// </summary>
        [EnumValueNameAttribute("cementing individual volume")]
        public static RealtimeData CementingIndividualVolume
        {
            get 
            {
                return cementingIndividualVolume;
            }
        }

        private readonly static RealtimeData cementingTotalVolume;
        /// <summary>
        /// Cementing total volume pumped
        /// </summary>
        [EnumValueNameAttribute("cementing total volume")]
        public static RealtimeData CementingTotalVolume
        {
            get 
            {
                return cementingTotalVolume;
            }
        }

        private readonly static RealtimeData chkprav;
        /// <summary>
        /// Casing pressure (average), measured at surface
        /// </summary>
        [EnumValueNameAttribute("chkPrAv")]
        public static RealtimeData Chkprav
        {
            get 
            {
                return chkprav;
            }
        }

        private readonly static RealtimeData carbonDioxideCyclebased;
        /// <summary>
        /// Carbon Dioxide ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (cycle-based)")]
        public static RealtimeData CarbonDioxideCyclebased
        {
            get 
            {
                return carbonDioxideCyclebased;
            }
        }

        private readonly static RealtimeData carbonDioxideAverage;
        /// <summary>
        /// Carbon Dioxide ppm (average)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (average)")]
        public static RealtimeData CarbonDioxideAverage
        {
            get 
            {
                return carbonDioxideAverage;
            }
        }

        private readonly static RealtimeData carbonDioxideMinimum;
        /// <summary>
        /// Carbon Dioxide ppm (min)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (minimum)")]
        public static RealtimeData CarbonDioxideMinimum
        {
            get 
            {
                return carbonDioxideMinimum;
            }
        }

        private readonly static RealtimeData carbonDioxideMaximum;
        /// <summary>
        /// Carbon Dioxide ppm (max)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (maximum)")]
        public static RealtimeData CarbonDioxideMaximum
        {
            get 
            {
                return carbonDioxideMaximum;
            }
        }

        private readonly static RealtimeData conductivity;
        /// <summary>
        /// Conductivity reading (corrected)
        /// </summary>
        [EnumValueNameAttribute("conductivity")]
        public static RealtimeData Conductivity
        {
            get 
            {
                return conductivity;
            }
        }

        private readonly static RealtimeData conductivityOfMudInAverage;
        /// <summary>
        /// Mud conductivity going into hole
        /// </summary>
        [EnumValueNameAttribute("conductivity of mud in (average)")]
        public static RealtimeData ConductivityOfMudInAverage
        {
            get 
            {
                return conductivityOfMudInAverage;
            }
        }

        private readonly static RealtimeData conductivityOfMudOutAverage;
        /// <summary>
        /// Mud conductivity coming out of the hole
        /// </summary>
        [EnumValueNameAttribute("conductivity of mud out (average)")]
        public static RealtimeData ConductivityOfMudOutAverage
        {
            get 
            {
                return conductivityOfMudOutAverage;
            }
        }

        private readonly static RealtimeData connectionsDone;
        /// <summary>
        /// Connections done
        /// </summary>
        [EnumValueNameAttribute("connections done")]
        public static RealtimeData ConnectionsDone
        {
            get 
            {
                return connectionsDone;
            }
        }

        private readonly static RealtimeData connectionsRemaining;
        /// <summary>
        /// Connections to go
        /// </summary>
        [EnumValueNameAttribute("connections remaining")]
        public static RealtimeData ConnectionsRemaining
        {
            get 
            {
                return connectionsRemaining;
            }
        }

        private readonly static RealtimeData costPerDistance;
        /// <summary>
        /// Instantaneous cost per distance
        /// </summary>
        [EnumValueNameAttribute("cost per distance")]
        public static RealtimeData CostPerDistance
        {
            get 
            {
                return costPerDistance;
            }
        }

        private readonly static RealtimeData costPerDistanceAverage;
        /// <summary>
        /// Cost per distance averaged over the bit run
        /// </summary>
        [EnumValueNameAttribute("cost per distance (average)")]
        public static RealtimeData CostPerDistanceAverage
        {
            get 
            {
                return costPerDistanceAverage;
            }
        }

        private readonly static RealtimeData cumulativeTimeOnBit;
        /// <summary>
        /// Number of drilling hours on the bit
        /// </summary>
        [EnumValueNameAttribute("cumulative time on bit")]
        public static RealtimeData CumulativeTimeOnBit
        {
            get 
            {
                return cumulativeTimeOnBit;
            }
        }

        private readonly static RealtimeData density;
        /// <summary>
        /// Density value
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static RealtimeData Density
        {
            get 
            {
                return density;
            }
        }

        private readonly static RealtimeData densityShale;
        /// <summary>
        /// Shale density
        /// </summary>
        [EnumValueNameAttribute("density shale")]
        public static RealtimeData DensityShale
        {
            get 
            {
                return densityShale;
            }
        }

        private readonly static RealtimeData diameterOfBit;
        /// <summary>
        /// Bit diameter
        /// </summary>
        [EnumValueNameAttribute("diameter of bit")]
        public static RealtimeData DiameterOfBit
        {
            get 
            {
                return diameterOfBit;
            }
        }

        private readonly static RealtimeData distanceDrilledByBit;
        /// <summary>
        /// Distance drilled by the bit
        /// </summary>
        [EnumValueNameAttribute("distance drilled by bit")]
        public static RealtimeData DistanceDrilledByBit
        {
            get 
            {
                return distanceDrilledByBit;
            }
        }

        private readonly static RealtimeData doglegSeverity;
        /// <summary>
        /// MWD dogleg severity
        /// </summary>
        [EnumValueNameAttribute("dogleg severity")]
        public static RealtimeData DoglegSeverity
        {
            get 
            {
                return doglegSeverity;
            }
        }

        private readonly static RealtimeData dstBottomHolePressure;
        /// <summary>
        /// DST bottom hole pressure
        /// </summary>
        [EnumValueNameAttribute("DST bottom hole pressure")]
        public static RealtimeData DstBottomHolePressure
        {
            get 
            {
                return dstBottomHolePressure;
            }
        }

        private readonly static RealtimeData dstBottomHoleTemperature;
        /// <summary>
        /// DST Bottom hole temperature
        /// </summary>
        [EnumValueNameAttribute("DST bottom hole temperature")]
        public static RealtimeData DstBottomHoleTemperature
        {
            get 
            {
                return dstBottomHoleTemperature;
            }
        }

        private readonly static RealtimeData dstCumulativeGasProduction;
        /// <summary>
        /// DST cumulative gas production
        /// </summary>
        [EnumValueNameAttribute("DST cumulative gas production")]
        public static RealtimeData DstCumulativeGasProduction
        {
            get 
            {
                return dstCumulativeGasProduction;
            }
        }

        private readonly static RealtimeData dstCumulativeLiquidProduction;
        /// <summary>
        /// DST cumulative liquid production
        /// </summary>
        [EnumValueNameAttribute("DST cumulative liquid production")]
        public static RealtimeData DstCumulativeLiquidProduction
        {
            get 
            {
                return dstCumulativeLiquidProduction;
            }
        }

        private readonly static RealtimeData dstCumulativeTotalProduction;
        /// <summary>
        /// DST cumulative total production
        /// </summary>
        [EnumValueNameAttribute("DST cumulative total production")]
        public static RealtimeData DstCumulativeTotalProduction
        {
            get 
            {
                return dstCumulativeTotalProduction;
            }
        }

        private readonly static RealtimeData dstGasFlowRate;
        /// <summary>
        /// DST gas flow rate
        /// </summary>
        [EnumValueNameAttribute("DST gas flow rate")]
        public static RealtimeData DstGasFlowRate
        {
            get 
            {
                return dstGasFlowRate;
            }
        }

        private readonly static RealtimeData dstHydrogenSulfideAverage;
        /// <summary>
        /// Hydrogen Sulfide (average) ppm
        /// </summary>
        [EnumValueNameAttribute("DST hydrogen sulfide (average)")]
        public static RealtimeData DstHydrogenSulfideAverage
        {
            get 
            {
                return dstHydrogenSulfideAverage;
            }
        }

        private readonly static RealtimeData dstIdentifier;
        /// <summary>
        /// Drill stem test identifier
        /// </summary>
        [EnumValueNameAttribute("DST identifier")]
        public static RealtimeData DstIdentifier
        {
            get 
            {
                return dstIdentifier;
            }
        }

        private readonly static RealtimeData dstLiquidFlowRate;
        /// <summary>
        /// DST liquid flow rate
        /// </summary>
        [EnumValueNameAttribute("DST liquid flow rate")]
        public static RealtimeData DstLiquidFlowRate
        {
            get 
            {
                return dstLiquidFlowRate;
            }
        }

        private readonly static RealtimeData dstSurfacePressureInCasing;
        /// <summary>
        /// DST surface pressure in casing
        /// </summary>
        [EnumValueNameAttribute("DST surface pressure in casing")]
        public static RealtimeData DstSurfacePressureInCasing
        {
            get 
            {
                return dstSurfacePressureInCasing;
            }
        }

        private readonly static RealtimeData dstSurfacePressureInTubing;
        /// <summary>
        /// DST surface pressure in tubing
        /// </summary>
        [EnumValueNameAttribute("DST surface pressure in tubing")]
        public static RealtimeData DstSurfacePressureInTubing
        {
            get 
            {
                return dstSurfacePressureInTubing;
            }
        }

        private readonly static RealtimeData dstSurfaceTemperatureInTubing;
        /// <summary>
        /// DST Surface temperature in tubing
        /// </summary>
        [EnumValueNameAttribute("DST surface temperature in tubing")]
        public static RealtimeData DstSurfaceTemperatureInTubing
        {
            get 
            {
                return dstSurfaceTemperatureInTubing;
            }
        }

        private readonly static RealtimeData dstTotalFlowRate;
        /// <summary>
        /// DST Total flow rate
        /// </summary>
        [EnumValueNameAttribute("DST total flow rate")]
        public static RealtimeData DstTotalFlowRate
        {
            get 
            {
                return dstTotalFlowRate;
            }
        }

        private readonly static RealtimeData dstToolTime;
        /// <summary>
        /// DST tool time (seconds)
        /// </summary>
        [EnumValueNameAttribute("DST tool time")]
        public static RealtimeData DstToolTime
        {
            get 
            {
                return dstToolTime;
            }
        }

        private readonly static RealtimeData drillingExponentCorrected;
        /// <summary>
        /// Corrected drilling exponent
        /// </summary>
        [EnumValueNameAttribute("drilling exponent (corrected)")]
        public static RealtimeData DrillingExponentCorrected
        {
            get 
            {
                return drillingExponentCorrected;
            }
        }

        private readonly static RealtimeData ecdAtBitDepth;
        /// <summary>
        /// Effective circulating density at bit depth
        /// </summary>
        [EnumValueNameAttribute("ECD at bit depth")]
        public static RealtimeData EcdAtBitDepth
        {
            get 
            {
                return ecdAtBitDepth;
            }
        }

        private readonly static RealtimeData ecdAtCasingShoeDepth;
        /// <summary>
        /// ECD at casing shoe depth
        /// </summary>
        [EnumValueNameAttribute("ECD at casing shoe depth")]
        public static RealtimeData EcdAtCasingShoeDepth
        {
            get 
            {
                return ecdAtCasingShoeDepth;
            }
        }

        private readonly static RealtimeData ecdFromMwdTool;
        /// <summary>
        /// ECD from MWD tool
        /// </summary>
        [EnumValueNameAttribute("ECD from MWD tool")]
        public static RealtimeData EcdFromMwdTool
        {
            get 
            {
                return ecdFromMwdTool;
            }
        }

        private readonly static RealtimeData ecdAtTotalDepth;
        /// <summary>
        /// Equivalent circulating density at total depth
        /// </summary>
        [EnumValueNameAttribute("ECD at total depth")]
        public static RealtimeData EcdAtTotalDepth
        {
            get 
            {
                return ecdAtTotalDepth;
            }
        }

        private readonly static RealtimeData neopentane;
        /// <summary>
        /// neo-Pentane (eC5) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane")]
        public static RealtimeData Neopentane
        {
            get 
            {
                return neopentane;
            }
        }

        private readonly static RealtimeData neopentaneAverage;
        /// <summary>
        /// neo-Pentane (eC5) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (average)")]
        public static RealtimeData NeopentaneAverage
        {
            get 
            {
                return neopentaneAverage;
            }
        }

        private readonly static RealtimeData neopentaneMinimum;
        /// <summary>
        /// neo-Pentane (eC5) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (minimum)")]
        public static RealtimeData NeopentaneMinimum
        {
            get 
            {
                return neopentaneMinimum;
            }
        }

        private readonly static RealtimeData neopentaneMaximum;
        /// <summary>
        /// neo-Pentane (eC5) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (maximum)")]
        public static RealtimeData NeopentaneMaximum
        {
            get 
            {
                return neopentaneMaximum;
            }
        }

        private readonly static RealtimeData ethane;
        /// <summary>
        /// Ethane (C2) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("ethane")]
        public static RealtimeData Ethane
        {
            get 
            {
                return ethane;
            }
        }

        private readonly static RealtimeData ethaneAverage;
        /// <summary>
        /// Ethane (C2) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("ethane (average)")]
        public static RealtimeData EthaneAverage
        {
            get 
            {
                return ethaneAverage;
            }
        }

        private readonly static RealtimeData ethaneMinimum;
        /// <summary>
        /// Ethane (C2) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("ethane (minimum)")]
        public static RealtimeData EthaneMinimum
        {
            get 
            {
                return ethaneMinimum;
            }
        }

        private readonly static RealtimeData ethaneMaximum;
        /// <summary>
        /// Ethane (C2) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("ethane (maximum)")]
        public static RealtimeData EthaneMaximum
        {
            get 
            {
                return ethaneMaximum;
            }
        }

        private readonly static RealtimeData formationFracturePressureGradient;
        /// <summary>
        /// Formation fracture pressure gradient
        /// </summary>
        [EnumValueNameAttribute("formation fracture pressure gradient")]
        public static RealtimeData FormationFracturePressureGradient
        {
            get 
            {
                return formationFracturePressureGradient;
            }
        }

        private readonly static RealtimeData flowRateInAverage;
        /// <summary>
        /// Mud flow into the hole
        /// </summary>
        [EnumValueNameAttribute("flow rate in (average)")]
        public static RealtimeData FlowRateInAverage
        {
            get 
            {
                return flowRateInAverage;
            }
        }

        private readonly static RealtimeData flowInRelative;
        /// <summary>
        /// Flow into the hole measured as a percentage
        /// </summary>
        [EnumValueNameAttribute("flow in (relative)")]
        public static RealtimeData FlowInRelative
        {
            get 
            {
                return flowInRelative;
            }
        }

        private readonly static RealtimeData flowRateOutAverage;
        /// <summary>
        /// Mud flow out of the hole
        /// </summary>
        [EnumValueNameAttribute("flow rate out (average)")]
        public static RealtimeData FlowRateOutAverage
        {
            get 
            {
                return flowRateOutAverage;
            }
        }

        private readonly static RealtimeData flowOutRelative;
        /// <summary>
        /// Flow out of hole measured as a percentage
        /// </summary>
        [EnumValueNameAttribute("flow out (relative)")]
        public static RealtimeData FlowOutRelative
        {
            get 
            {
                return flowOutRelative;
            }
        }

        private readonly static RealtimeData overburdenPressureGradient;
        /// <summary>
        /// Formation overburden pressure gradient
        /// </summary>
        [EnumValueNameAttribute("overburden pressure gradient")]
        public static RealtimeData OverburdenPressureGradient
        {
            get 
            {
                return overburdenPressureGradient;
            }
        }

        private readonly static RealtimeData bitJetImpactForce;
        /// <summary>
        /// Bit jet impact force
        /// </summary>
        [EnumValueNameAttribute("bit jet impact force")]
        public static RealtimeData BitJetImpactForce
        {
            get 
            {
                return bitJetImpactForce;
            }
        }

        private readonly static RealtimeData formationPorePressureGradient;
        /// <summary>
        /// Formation pore pressure gradient
        /// </summary>
        [EnumValueNameAttribute("formation pore pressure gradient")]
        public static RealtimeData FormationPorePressureGradient
        {
            get 
            {
                return formationPorePressureGradient;
            }
        }

        private readonly static RealtimeData gasTotalAverage;
        /// <summary>
        /// Total gas %
        /// </summary>
        [EnumValueNameAttribute("gas total (average)")]
        public static RealtimeData GasTotalAverage
        {
            get 
            {
                return gasTotalAverage;
            }
        }

        private readonly static RealtimeData connectionGasAverage;
        /// <summary>
        /// Connection gas (average) %
        /// </summary>
        [EnumValueNameAttribute("connection gas (average)")]
        public static RealtimeData ConnectionGasAverage
        {
            get 
            {
                return connectionGasAverage;
            }
        }

        private readonly static RealtimeData connectionGasLast;
        /// <summary>
        /// Connection gas (last reading) %
        /// </summary>
        [EnumValueNameAttribute("connection gas (last)")]
        public static RealtimeData ConnectionGasLast
        {
            get 
            {
                return connectionGasLast;
            }
        }

        private readonly static RealtimeData connectionGasMaximum;
        /// <summary>
        /// Connection gas (maximum) %
        /// </summary>
        [EnumValueNameAttribute("connection gas (maximum)")]
        public static RealtimeData ConnectionGasMaximum
        {
            get 
            {
                return connectionGasMaximum;
            }
        }

        private readonly static RealtimeData tripGasLast;
        /// <summary>
        /// Trip gas last reading %
        /// </summary>
        [EnumValueNameAttribute("trip gas (last)")]
        public static RealtimeData TripGasLast
        {
            get 
            {
                return tripGasLast;
            }
        }

        private readonly static RealtimeData gammaRay;
        /// <summary>
        /// Gamma ray reading (uncorrected)
        /// </summary>
        [EnumValueNameAttribute("gamma ray")]
        public static RealtimeData GammaRay
        {
            get 
            {
                return gammaRay;
            }
        }

        private readonly static RealtimeData gammaRayCorrected;
        /// <summary>
        /// Gamma ray reading (corrected)
        /// </summary>
        [EnumValueNameAttribute("gamma ray (corrected)")]
        public static RealtimeData GammaRayCorrected
        {
            get 
            {
                return gammaRayCorrected;
            }
        }

        private readonly static RealtimeData gravityToolFace;
        /// <summary>
        /// MWD gravity tool face
        /// </summary>
        [EnumValueNameAttribute("gravity tool face")]
        public static RealtimeData GravityToolFace
        {
            get 
            {
                return gravityToolFace;
            }
        }

        private readonly static RealtimeData gravityXaxisCorrected;
        /// <summary>
        /// X axis gravity corrected
        /// </summary>
        [EnumValueNameAttribute("gravity X-axis (corrected)")]
        public static RealtimeData GravityXaxisCorrected
        {
            get 
            {
                return gravityXaxisCorrected;
            }
        }

        private readonly static RealtimeData gravityXaxisUncorrected;
        /// <summary>
        /// X axis gravity uncorrected
        /// </summary>
        [EnumValueNameAttribute("gravity X-axis (uncorrected)")]
        public static RealtimeData GravityXaxisUncorrected
        {
            get 
            {
                return gravityXaxisUncorrected;
            }
        }

        private readonly static RealtimeData gravityYaxisCorrected;
        /// <summary>
        /// Y axis gravity corrected
        /// </summary>
        [EnumValueNameAttribute("gravity Y-axis (corrected)")]
        public static RealtimeData GravityYaxisCorrected
        {
            get 
            {
                return gravityYaxisCorrected;
            }
        }

        private readonly static RealtimeData gravityYaxisUncorrected;
        /// <summary>
        /// Y axis gravity uncorrected
        /// </summary>
        [EnumValueNameAttribute("gravity Y-axis (uncorrected)")]
        public static RealtimeData GravityYaxisUncorrected
        {
            get 
            {
                return gravityYaxisUncorrected;
            }
        }

        private readonly static RealtimeData gravityZaxisCorrected;
        /// <summary>
        /// Z axis gravity corrected
        /// </summary>
        [EnumValueNameAttribute("gravity Z-axis (corrected)")]
        public static RealtimeData GravityZaxisCorrected
        {
            get 
            {
                return gravityZaxisCorrected;
            }
        }

        private readonly static RealtimeData gravityZaxisUncorrected;
        /// <summary>
        /// Z axis gravity uncorrected
        /// </summary>
        [EnumValueNameAttribute("gravity Z-axis (uncorrected)")]
        public static RealtimeData GravityZaxisUncorrected
        {
            get 
            {
                return gravityZaxisUncorrected;
            }
        }

        private readonly static RealtimeData hydrogenSulfide;
        /// <summary>
        /// Hydrogen Sulfide ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide")]
        public static RealtimeData HydrogenSulfide
        {
            get 
            {
                return hydrogenSulfide;
            }
        }

        private readonly static RealtimeData hydrogenSulfideAverage;
        /// <summary>
        /// Hydrogen Sulfide (average) ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (average)")]
        public static RealtimeData HydrogenSulfideAverage
        {
            get 
            {
                return hydrogenSulfideAverage;
            }
        }

        private readonly static RealtimeData hydrogenSulfideMinimum;
        /// <summary>
        /// Hydrogen Sulfide (min) ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (minimum)")]
        public static RealtimeData HydrogenSulfideMinimum
        {
            get 
            {
                return hydrogenSulfideMinimum;
            }
        }

        private readonly static RealtimeData hydrogenSulfideMaximum;
        /// <summary>
        /// Hydrogen Sulfide (max) ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (maximum)")]
        public static RealtimeData HydrogenSulfideMaximum
        {
            get 
            {
                return hydrogenSulfideMaximum;
            }
        }

        private readonly static RealtimeData hookloadAverage;
        /// <summary>
        /// Hookload, average, measured at surface
        /// </summary>
        [EnumValueNameAttribute("hookload (average)")]
        public static RealtimeData HookloadAverage
        {
            get 
            {
                return hookloadAverage;
            }
        }

        private readonly static RealtimeData hookloadMinimum;
        /// <summary>
        /// Minimum hookload while running the stand
        /// </summary>
        [EnumValueNameAttribute("hookload (minimum)")]
        public static RealtimeData HookloadMinimum
        {
            get 
            {
                return hookloadMinimum;
            }
        }

        private readonly static RealtimeData hookloadMaximum;
        /// <summary>
        /// Hookload, maximum measured at surface
        /// </summary>
        [EnumValueNameAttribute("hookload (maximum)")]
        public static RealtimeData HookloadMaximum
        {
            get 
            {
                return hookloadMaximum;
            }
        }

        private readonly static RealtimeData mwdMagnetometerXCorrected;
        /// <summary>
        /// X axis magnetic corrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer X (corrected)")]
        public static RealtimeData MwdMagnetometerXCorrected
        {
            get 
            {
                return mwdMagnetometerXCorrected;
            }
        }

        private readonly static RealtimeData mwdMagnetometerXRaw;
        /// <summary>
        /// X axis magnetic uncorrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer X (raw)")]
        public static RealtimeData MwdMagnetometerXRaw
        {
            get 
            {
                return mwdMagnetometerXRaw;
            }
        }

        private readonly static RealtimeData mwdMagnetometerYCorrected;
        /// <summary>
        /// Y axis magnetic corrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Y (corrected)")]
        public static RealtimeData MwdMagnetometerYCorrected
        {
            get 
            {
                return mwdMagnetometerYCorrected;
            }
        }

        private readonly static RealtimeData mwdMagnetometerYRaw;
        /// <summary>
        /// Y axis magnetic uncorrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Y (raw)")]
        public static RealtimeData MwdMagnetometerYRaw
        {
            get 
            {
                return mwdMagnetometerYRaw;
            }
        }

        private readonly static RealtimeData mwdMagnetometerZCorrected;
        /// <summary>
        /// Z axis magnetic corrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Z (corrected)")]
        public static RealtimeData MwdMagnetometerZCorrected
        {
            get 
            {
                return mwdMagnetometerZCorrected;
            }
        }

        private readonly static RealtimeData mwdMagnetometerZRaw;
        /// <summary>
        /// Z axis magnetic uncorrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Z (raw)")]
        public static RealtimeData MwdMagnetometerZRaw
        {
            get 
            {
                return mwdMagnetometerZRaw;
            }
        }

        private readonly static RealtimeData isobutane;
        /// <summary>
        /// iso-Butane (iC4) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-butane")]
        public static RealtimeData Isobutane
        {
            get 
            {
                return isobutane;
            }
        }

        private readonly static RealtimeData isobutaneAverage;
        /// <summary>
        /// iso-Butane (iC4) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("iso-butane (average)")]
        public static RealtimeData IsobutaneAverage
        {
            get 
            {
                return isobutaneAverage;
            }
        }

        private readonly static RealtimeData isobutaneMinimum;
        /// <summary>
        /// iso-Butane (iC4) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("iso-butane (minimum)")]
        public static RealtimeData IsobutaneMinimum
        {
            get 
            {
                return isobutaneMinimum;
            }
        }

        private readonly static RealtimeData isobutaneMaximum;
        /// <summary>
        /// iso-Butane (iC4) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("iso-butane (maximum)")]
        public static RealtimeData IsobutaneMaximum
        {
            get 
            {
                return isobutaneMaximum;
            }
        }

        private readonly static RealtimeData isohexane;
        /// <summary>
        /// iso-Hexane (iC6) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane")]
        public static RealtimeData Isohexane
        {
            get 
            {
                return isohexane;
            }
        }

        private readonly static RealtimeData isohexaneAverage;
        /// <summary>
        /// iso-Hexane (iC6) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (average)")]
        public static RealtimeData IsohexaneAverage
        {
            get 
            {
                return isohexaneAverage;
            }
        }

        private readonly static RealtimeData isohexaneMinimum;
        /// <summary>
        /// iso-Hexane (iC6) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (minimum)")]
        public static RealtimeData IsohexaneMinimum
        {
            get 
            {
                return isohexaneMinimum;
            }
        }

        private readonly static RealtimeData isohexaneMaximum;
        /// <summary>
        /// iso-Hexane (iC6) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (maximum)")]
        public static RealtimeData IsohexaneMaximum
        {
            get 
            {
                return isohexaneMaximum;
            }
        }

        private readonly static RealtimeData inclinationCorrected;
        /// <summary>
        /// MWD inclination (corrected)
        /// </summary>
        [EnumValueNameAttribute("inclination (corrected)")]
        public static RealtimeData InclinationCorrected
        {
            get 
            {
                return inclinationCorrected;
            }
        }

        private readonly static RealtimeData inclinationNearBit;
        /// <summary>
        /// Near-bit inclination
        /// </summary>
        [EnumValueNameAttribute("inclination near bit")]
        public static RealtimeData InclinationNearBit
        {
            get 
            {
                return inclinationNearBit;
            }
        }

        private readonly static RealtimeData inclinationUncorrected;
        /// <summary>
        /// MWD inclination (uncorrected)
        /// </summary>
        [EnumValueNameAttribute("inclination (uncorrected)")]
        public static RealtimeData InclinationUncorrected
        {
            get 
            {
                return inclinationUncorrected;
            }
        }

        private readonly static RealtimeData isopentane;
        /// <summary>
        /// iso-Pentane (iC5) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane")]
        public static RealtimeData Isopentane
        {
            get 
            {
                return isopentane;
            }
        }

        private readonly static RealtimeData isopentaneAverage;
        /// <summary>
        /// iso-Pentane (iC5) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (average)")]
        public static RealtimeData IsopentaneAverage
        {
            get 
            {
                return isopentaneAverage;
            }
        }

        private readonly static RealtimeData isopentaneMinimum;
        /// <summary>
        /// iso-Pentane (iC5) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (minimum)")]
        public static RealtimeData IsopentaneMinimum
        {
            get 
            {
                return isopentaneMinimum;
            }
        }

        private readonly static RealtimeData isopentaneMaximum;
        /// <summary>
        /// iso-Pentane (iC5) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (maximum)")]
        public static RealtimeData IsopentaneMaximum
        {
            get 
            {
                return isopentaneMaximum;
            }
        }

        private readonly static RealtimeData kickTolerance;
        /// <summary>
        /// Kick tolerance
        /// </summary>
        [EnumValueNameAttribute("kick tolerance")]
        public static RealtimeData KickTolerance
        {
            get 
            {
                return kickTolerance;
            }
        }

        private readonly static RealtimeData lithologyFlag;
        /// <summary>
        /// Lithology flag
        /// </summary>
        [EnumValueNameAttribute("lithology flag")]
        public static RealtimeData LithologyFlag
        {
            get 
            {
                return lithologyFlag;
            }
        }

        private readonly static RealtimeData mwdAlternatorVoltage;
        /// <summary>
        /// Downhole tool alternator voltage
        /// </summary>
        [EnumValueNameAttribute("MWD alternator voltage")]
        public static RealtimeData MwdAlternatorVoltage
        {
            get 
            {
                return mwdAlternatorVoltage;
            }
        }

        private readonly static RealtimeData mwdBottomHoleAnnulusPressure;
        /// <summary>
        /// Bottom hole annulus pressure
        /// </summary>
        [EnumValueNameAttribute("MWD bottom hole annulus pressure")]
        public static RealtimeData MwdBottomHoleAnnulusPressure
        {
            get 
            {
                return mwdBottomHoleAnnulusPressure;
            }
        }

        private readonly static RealtimeData mwdBottomHoleInternalPressure;
        /// <summary>
        /// Bottom hole internal pressure
        /// </summary>
        [EnumValueNameAttribute("MWD bottom hole internal pressure")]
        public static RealtimeData MwdBottomHoleInternalPressure
        {
            get 
            {
                return mwdBottomHoleInternalPressure;
            }
        }

        private readonly static RealtimeData bitTotalMeasuredDepth;
        /// <summary>
        /// Total (measured) depth of bit
        /// </summary>
        [EnumValueNameAttribute("bit total measured depth")]
        public static RealtimeData BitTotalMeasuredDepth
        {
            get 
            {
                return bitTotalMeasuredDepth;
            }
        }

        private readonly static RealtimeData mwdConductivity;
        /// <summary>
        /// Mud conductivity
        /// </summary>
        [EnumValueNameAttribute("MWD conductivity")]
        public static RealtimeData MwdConductivity
        {
            get 
            {
                return mwdConductivity;
            }
        }

        private readonly static RealtimeData measuredDepthOfCasing;
        /// <summary>
        /// Measured depth of casing in the cementing 
        /// </summary>
        [EnumValueNameAttribute("measured depth of casing")]
        public static RealtimeData MeasuredDepthOfCasing
        {
            get 
            {
                return measuredDepthOfCasing;
            }
        }

        private readonly static RealtimeData measuredDepthOfDstBottom;
        /// <summary>
        /// Depth (measured) of bottom of DST interval
        /// </summary>
        [EnumValueNameAttribute("measured depth of DST bottom")]
        public static RealtimeData MeasuredDepthOfDstBottom
        {
            get 
            {
                return measuredDepthOfDstBottom;
            }
        }

        private readonly static RealtimeData measuredDepthOfDstTop;
        /// <summary>
        /// Depth (measured) of top of DST interval
        /// </summary>
        [EnumValueNameAttribute("measured depth of DST top")]
        public static RealtimeData MeasuredDepthOfDstTop
        {
            get 
            {
                return measuredDepthOfDstTop;
            }
        }

        private readonly static RealtimeData measuredDepthOfDiverterTool;
        /// <summary>
        /// Cementing depth to DV tool
        /// </summary>
        [EnumValueNameAttribute("measured depth of diverter tool")]
        public static RealtimeData MeasuredDepthOfDiverterTool
        {
            get 
            {
                return measuredDepthOfDiverterTool;
            }
        }

        private readonly static RealtimeData measuredDepthOfHole;
        /// <summary>
        /// Total (measured) depth of hole
        /// </summary>
        [EnumValueNameAttribute("measured depth of hole")]
        public static RealtimeData MeasuredDepthOfHole
        {
            get 
            {
                return measuredDepthOfHole;
            }
        }

        private readonly static RealtimeData measuredDepthOfReturns;
        /// <summary>
        /// Depth of cuttings returns
        /// </summary>
        [EnumValueNameAttribute("measured depth of returns")]
        public static RealtimeData MeasuredDepthOfReturns
        {
            get 
            {
                return measuredDepthOfReturns;
            }
        }

        private readonly static RealtimeData methane;
        /// <summary>
        /// Methane (C1) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("methane")]
        public static RealtimeData Methane
        {
            get 
            {
                return methane;
            }
        }

        private readonly static RealtimeData methaneAverage;
        /// <summary>
        /// Methane (C1) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("methane (average)")]
        public static RealtimeData MethaneAverage
        {
            get 
            {
                return methaneAverage;
            }
        }

        private readonly static RealtimeData methaneMinimum;
        /// <summary>
        /// Methane (C1) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("methane (minimum)")]
        public static RealtimeData MethaneMinimum
        {
            get 
            {
                return methaneMinimum;
            }
        }

        private readonly static RealtimeData methaneMaximum;
        /// <summary>
        /// Methane (C1) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("methane (maximum)")]
        public static RealtimeData MethaneMaximum
        {
            get 
            {
                return methaneMaximum;
            }
        }

        private readonly static RealtimeData mwdDerivedFracturePressureGradient;
        /// <summary>
        /// Fracture pressure gradient from MWD
        /// </summary>
        [EnumValueNameAttribute("MWD derived fracture pressure gradient")]
        public static RealtimeData MwdDerivedFracturePressureGradient
        {
            get 
            {
                return mwdDerivedFracturePressureGradient;
            }
        }

        private readonly static RealtimeData mwdDerivedPorePressureGradient;
        /// <summary>
        /// Pore Pressure gradient from MWD
        /// </summary>
        [EnumValueNameAttribute("MWD derived pore pressure gradient")]
        public static RealtimeData MwdDerivedPorePressureGradient
        {
            get 
            {
                return mwdDerivedPorePressureGradient;
            }
        }

        private readonly static RealtimeData mwdFluidResistivityInAnnulus;
        /// <summary>
        /// Downhole fluid resistivity in annulus
        /// </summary>
        [EnumValueNameAttribute("MWD fluid resistivity in annulus")]
        public static RealtimeData MwdFluidResistivityInAnnulus
        {
            get 
            {
                return mwdFluidResistivityInAnnulus;
            }
        }

        private readonly static RealtimeData mwdFluidResistivityInPipe;
        /// <summary>
        /// Downhole fluid resistivity in pipe
        /// </summary>
        [EnumValueNameAttribute("MWD fluid resistivity in pipe")]
        public static RealtimeData MwdFluidResistivityInPipe
        {
            get 
            {
                return mwdFluidResistivityInPipe;
            }
        }

        private readonly static RealtimeData mwdFluidTemperatureInAnnulus;
        /// <summary>
        /// Downhole fluid temperature in annulus
        /// </summary>
        [EnumValueNameAttribute("MWD fluid temperature in annulus")]
        public static RealtimeData MwdFluidTemperatureInAnnulus
        {
            get 
            {
                return mwdFluidTemperatureInAnnulus;
            }
        }

        private readonly static RealtimeData mwdFluidTemperatureInPipe;
        /// <summary>
        /// Downhole fluid temperature in pipe
        /// </summary>
        [EnumValueNameAttribute("MWD fluid temperature in pipe")]
        public static RealtimeData MwdFluidTemperatureInPipe
        {
            get 
            {
                return mwdFluidTemperatureInPipe;
            }
        }

        private readonly static RealtimeData mwdGammaRay;
        /// <summary>
        /// Measured gamma ray value
        /// </summary>
        [EnumValueNameAttribute("MWD gamma ray")]
        public static RealtimeData MwdGammaRay
        {
            get 
            {
                return mwdGammaRay;
            }
        }

        private readonly static RealtimeData mwdGammaRayCorrected;
        /// <summary>
        /// Borehole corrected gamma ray value
        /// </summary>
        [EnumValueNameAttribute("MWD gamma ray (corrected)")]
        public static RealtimeData MwdGammaRayCorrected
        {
            get 
            {
                return mwdGammaRayCorrected;
            }
        }

        private readonly static RealtimeData mwdMotorSpeed;
        /// <summary>
        /// Downhole motor RPM
        /// </summary>
        [EnumValueNameAttribute("MWD motor speed")]
        public static RealtimeData MwdMotorSpeed
        {
            get 
            {
                return mwdMotorSpeed;
            }
        }

        private readonly static RealtimeData mwdResistivity;
        /// <summary>
        /// Measured resistivity value
        /// </summary>
        [EnumValueNameAttribute("MWD resistivity")]
        public static RealtimeData MwdResistivity
        {
            get 
            {
                return mwdResistivity;
            }
        }

        private readonly static RealtimeData mwdResistivityCorrected;
        /// <summary>
        /// Borehole corrected resistivity value
        /// </summary>
        [EnumValueNameAttribute("MWD resistivity (corrected)")]
        public static RealtimeData MwdResistivityCorrected
        {
            get 
            {
                return mwdResistivityCorrected;
            }
        }

        private readonly static RealtimeData magneticToolFace;
        /// <summary>
        /// MWD magnetic tool face
        /// </summary>
        [EnumValueNameAttribute("magnetic tool face")]
        public static RealtimeData MagneticToolFace
        {
            get 
            {
                return magneticToolFace;
            }
        }

        private readonly static RealtimeData mwdTorqueAverage;
        /// <summary>
        /// Downhole torque (average)
        /// </summary>
        [EnumValueNameAttribute("MWD torque (average)")]
        public static RealtimeData MwdTorqueAverage
        {
            get 
            {
                return mwdTorqueAverage;
            }
        }

        private readonly static RealtimeData mwdTorqueMaximum;
        /// <summary>
        /// Downhole torque (maximum)
        /// </summary>
        [EnumValueNameAttribute("MWD torque (maximum)")]
        public static RealtimeData MwdTorqueMaximum
        {
            get 
            {
                return mwdTorqueMaximum;
            }
        }

        private readonly static RealtimeData mwdAxialVibration;
        /// <summary>
        /// Downhole vibration in axial direction
        /// </summary>
        [EnumValueNameAttribute("MWD axial vibration")]
        public static RealtimeData MwdAxialVibration
        {
            get 
            {
                return mwdAxialVibration;
            }
        }

        private readonly static RealtimeData mwdLateralVibration;
        /// <summary>
        /// Downhole vibration in lateral direction
        /// </summary>
        [EnumValueNameAttribute("MWD lateral vibration")]
        public static RealtimeData MwdLateralVibration
        {
            get 
            {
                return mwdLateralVibration;
            }
        }

        private readonly static RealtimeData mwdTorsionalVibration;
        /// <summary>
        /// Downhole vibration in torsional direction
        /// </summary>
        [EnumValueNameAttribute("MWD torsional vibration")]
        public static RealtimeData MwdTorsionalVibration
        {
            get 
            {
                return mwdTorsionalVibration;
            }
        }

        private readonly static RealtimeData mwdWeightOnBitAverage;
        /// <summary>
        /// Downhole weight on bit (average)
        /// </summary>
        [EnumValueNameAttribute("MWD weight on bit (average)")]
        public static RealtimeData MwdWeightOnBitAverage
        {
            get 
            {
                return mwdWeightOnBitAverage;
            }
        }

        private readonly static RealtimeData mwdWeightOnBitMaximum;
        /// <summary>
        /// Downhole weight on bit (maximum)
        /// </summary>
        [EnumValueNameAttribute("MWD weight on bit (maximum)")]
        public static RealtimeData MwdWeightOnBitMaximum
        {
            get 
            {
                return mwdWeightOnBitMaximum;
            }
        }

        private readonly static RealtimeData norbutane;
        /// <summary>
        /// nor-Butane (nC4) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-butane")]
        public static RealtimeData Norbutane
        {
            get 
            {
                return norbutane;
            }
        }

        private readonly static RealtimeData norbutaneAverage;
        /// <summary>
        /// nor-Butane (nC4) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("nor-butane (average)")]
        public static RealtimeData NorbutaneAverage
        {
            get 
            {
                return norbutaneAverage;
            }
        }

        private readonly static RealtimeData norbutaneMinimum;
        /// <summary>
        /// nor-Butane (nC4) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("nor-butane (minimum)")]
        public static RealtimeData NorbutaneMinimum
        {
            get 
            {
                return norbutaneMinimum;
            }
        }

        private readonly static RealtimeData norbutaneMaximum;
        /// <summary>
        /// nor-Butane (nC4) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("nor-butane (maximum)")]
        public static RealtimeData NorbutaneMaximum
        {
            get 
            {
                return norbutaneMaximum;
            }
        }

        private readonly static RealtimeData neutronDensity;
        /// <summary>
        /// Neutron density
        /// </summary>
        [EnumValueNameAttribute("neutron density")]
        public static RealtimeData NeutronDensity
        {
            get 
            {
                return neutronDensity;
            }
        }

        private readonly static RealtimeData norhexane;
        /// <summary>
        /// nor-Hexane (nC6) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane")]
        public static RealtimeData Norhexane
        {
            get 
            {
                return norhexane;
            }
        }

        private readonly static RealtimeData norhexaneAverage;
        /// <summary>
        /// nor-Hexane (nC6) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (average)")]
        public static RealtimeData NorhexaneAverage
        {
            get 
            {
                return norhexaneAverage;
            }
        }

        private readonly static RealtimeData norhexaneMinimum;
        /// <summary>
        /// nor-Hexane (nC6) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (minimum)")]
        public static RealtimeData NorhexaneMinimum
        {
            get 
            {
                return norhexaneMinimum;
            }
        }

        private readonly static RealtimeData norhexaneMaximum;
        /// <summary>
        /// nor-Hexane (nC6) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (maximum)")]
        public static RealtimeData NorhexaneMaximum
        {
            get 
            {
                return norhexaneMaximum;
            }
        }

        private readonly static RealtimeData norpentane;
        /// <summary>
        /// nor-Pentane (nC5) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane")]
        public static RealtimeData Norpentane
        {
            get 
            {
                return norpentane;
            }
        }

        private readonly static RealtimeData norpentaneAverage;
        /// <summary>
        /// nor-Pentane (nC5) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (average)")]
        public static RealtimeData NorpentaneAverage
        {
            get 
            {
                return norpentaneAverage;
            }
        }

        private readonly static RealtimeData norpentaneMinimum;
        /// <summary>
        /// nor-Pentane (nC5) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (minimum)")]
        public static RealtimeData NorpentaneMinimum
        {
            get 
            {
                return norpentaneMinimum;
            }
        }

        private readonly static RealtimeData norpentaneMaximum;
        /// <summary>
        /// nor-Pentane (nC5) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (maximum)")]
        public static RealtimeData NorpentaneMaximum
        {
            get 
            {
                return norpentaneMaximum;
            }
        }

        private readonly static RealtimeData neutronPorosity;
        /// <summary>
        /// Neutron porosity
        /// </summary>
        [EnumValueNameAttribute("neutron porosity")]
        public static RealtimeData NeutronPorosity
        {
            get 
            {
                return neutronPorosity;
            }
        }

        private readonly static RealtimeData neutronPorosityCorrected;
        /// <summary>
        /// Neutron porosity corrected
        /// </summary>
        [EnumValueNameAttribute("neutron porosity (corrected)")]
        public static RealtimeData NeutronPorosityCorrected
        {
            get 
            {
                return neutronPorosityCorrected;
            }
        }

        private readonly static RealtimeData neutronPorosityRatio;
        /// <summary>
        /// Neutron porosity ratio
        /// </summary>
        [EnumValueNameAttribute("neutron porosity ratio")]
        public static RealtimeData NeutronPorosityRatio
        {
            get 
            {
                return neutronPorosityRatio;
            }
        }

        private readonly static RealtimeData passNumber;
        /// <summary>
        /// MWD pass number
        /// </summary>
        [EnumValueNameAttribute("pass number")]
        public static RealtimeData PassNumber
        {
            get 
            {
                return passNumber;
            }
        }

        private readonly static RealtimeData tripNumber;
        /// <summary>
        /// Trip number
        /// </summary>
        [EnumValueNameAttribute("trip number")]
        public static RealtimeData TripNumber
        {
            get 
            {
                return tripNumber;
            }
        }

        private readonly static RealtimeData photoelectricEffect;
        /// <summary>
        /// Photoelectric effect
        /// </summary>
        [EnumValueNameAttribute("photoelectric effect")]
        public static RealtimeData PhotoelectricEffect
        {
            get 
            {
                return photoelectricEffect;
            }
        }

        private readonly static RealtimeData bitPressureLoss;
        /// <summary>
        /// Bit pressure loss
        /// </summary>
        [EnumValueNameAttribute("bit pressure loss")]
        public static RealtimeData BitPressureLoss
        {
            get 
            {
                return bitPressureLoss;
            }
        }

        private readonly static RealtimeData blockPosition;
        /// <summary>
        /// Block position
        /// </summary>
        [EnumValueNameAttribute("block position")]
        public static RealtimeData BlockPosition
        {
            get 
            {
                return blockPosition;
            }
        }

        private readonly static RealtimeData hydraulicPowerOfBit;
        /// <summary>
        /// Bit hydraulic power
        /// </summary>
        [EnumValueNameAttribute("hydraulic power of bit")]
        public static RealtimeData HydraulicPowerOfBit
        {
            get 
            {
                return hydraulicPowerOfBit;
            }
        }

        private readonly static RealtimeData hydraulicPowerPerAreaOfBit;
        /// <summary>
        /// Bit hydraulic power per area
        /// </summary>
        [EnumValueNameAttribute("hydraulic power per area of bit")]
        public static RealtimeData HydraulicPowerPerAreaOfBit
        {
            get 
            {
                return hydraulicPowerPerAreaOfBit;
            }
        }

        private readonly static RealtimeData hydraulicPowerOfPump;
        /// <summary>
        /// Pump hydraulic power
        /// </summary>
        [EnumValueNameAttribute("hydraulic power of pump")]
        public static RealtimeData HydraulicPowerOfPump
        {
            get 
            {
                return hydraulicPowerOfPump;
            }
        }

        private readonly static RealtimeData pressureLossAtAnnulus;
        /// <summary>
        /// Annulus pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure loss at annulus")]
        public static RealtimeData PressureLossAtAnnulus
        {
            get 
            {
                return pressureLossAtAnnulus;
            }
        }

        private readonly static RealtimeData pressureDropAtBit;
        /// <summary>
        /// pressure drop at the bit
        /// </summary>
        [EnumValueNameAttribute("pressure drop at bit")]
        public static RealtimeData PressureDropAtBit
        {
            get 
            {
                return pressureDropAtBit;
            }
        }

        private readonly static RealtimeData pressureLossAtBit;
        /// <summary>
        /// Bit pressure loss percentage
        /// </summary>
        [EnumValueNameAttribute("pressure loss at bit")]
        public static RealtimeData PressureLossAtBit
        {
            get 
            {
                return pressureLossAtBit;
            }
        }

        private readonly static RealtimeData pressureDropCalculatedOrObserved;
        /// <summary>
        /// Calculated/observed pressure loss ratio (%)
        /// </summary>
        [EnumValueNameAttribute("pressure drop (calculated or observed)")]
        public static RealtimeData PressureDropCalculatedOrObserved
        {
            get 
            {
                return pressureDropCalculatedOrObserved;
            }
        }

        private readonly static RealtimeData pressureDropAtMotor;
        /// <summary>
        /// Mud motor pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at motor")]
        public static RealtimeData PressureDropAtMotor
        {
            get 
            {
                return pressureDropAtMotor;
            }
        }

        private readonly static RealtimeData pressureDropAtMwdTool;
        /// <summary>
        /// MWD tool pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at MWD tool")]
        public static RealtimeData PressureDropAtMwdTool
        {
            get 
            {
                return pressureDropAtMwdTool;
            }
        }

        private readonly static RealtimeData pressureDropAtString;
        /// <summary>
        /// Pipe (drillstring) pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at string")]
        public static RealtimeData PressureDropAtString
        {
            get 
            {
                return pressureDropAtString;
            }
        }

        private readonly static RealtimeData pressureDropAtSurface;
        /// <summary>
        /// Surface pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at surface")]
        public static RealtimeData PressureDropAtSurface
        {
            get 
            {
                return pressureDropAtSurface;
            }
        }

        private readonly static RealtimeData pressureAtMwdTool;
        /// <summary>
        /// Downhole pressure from MWD tool
        /// </summary>
        [EnumValueNameAttribute("pressure at MWD tool")]
        public static RealtimeData PressureAtMwdTool
        {
            get 
            {
                return pressureAtMwdTool;
            }
        }

        private readonly static RealtimeData pressureAtPumpAverage;
        /// <summary>
        /// Pump (standpipe) pressure, measured at surface
        /// </summary>
        [EnumValueNameAttribute("pressure at pump (average)")]
        public static RealtimeData PressureAtPumpAverage
        {
            get 
            {
                return pressureAtPumpAverage;
            }
        }

        private readonly static RealtimeData shutinPressureMaximum;
        /// <summary>
        /// Maximum permitted shut-in pressure
        /// </summary>
        [EnumValueNameAttribute("shut-in pressure (maximum)")]
        public static RealtimeData ShutinPressureMaximum
        {
            get 
            {
                return shutinPressureMaximum;
            }
        }

        private readonly static RealtimeData propane;
        /// <summary>
        /// Propane (C3) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("propane")]
        public static RealtimeData Propane
        {
            get 
            {
                return propane;
            }
        }

        private readonly static RealtimeData propaneAverage;
        /// <summary>
        /// Propane (C3) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("propane (average)")]
        public static RealtimeData PropaneAverage
        {
            get 
            {
                return propaneAverage;
            }
        }

        private readonly static RealtimeData propaneMinimum;
        /// <summary>
        /// Propane (C3) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("propane (minimum)")]
        public static RealtimeData PropaneMinimum
        {
            get 
            {
                return propaneMinimum;
            }
        }

        private readonly static RealtimeData propaneMaximum;
        /// <summary>
        /// Propane (C3) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("propane (maximum)")]
        public static RealtimeData PropaneMaximum
        {
            get 
            {
                return propaneMaximum;
            }
        }

        private readonly static RealtimeData plasticViscosity;
        /// <summary>
        /// Mud plastic viscosity
        /// </summary>
        [EnumValueNameAttribute("plastic viscosity")]
        public static RealtimeData PlasticViscosity
        {
            get 
            {
                return plasticViscosity;
            }
        }

        private readonly static RealtimeData resistivity;
        /// <summary>
        /// Resistivity reading
        /// </summary>
        [EnumValueNameAttribute("resistivity")]
        public static RealtimeData Resistivity
        {
            get 
            {
                return resistivity;
            }
        }

        private readonly static RealtimeData resistivityCorrected;
        /// <summary>
        /// Resistivity reading (corrected)
        /// </summary>
        [EnumValueNameAttribute("resistivity (corrected)")]
        public static RealtimeData ResistivityCorrected
        {
            get 
            {
                return resistivityCorrected;
            }
        }

        private readonly static RealtimeData rateOfPenetrationAverage;
        /// <summary>
        /// Drill Rate
        /// </summary>
        [EnumValueNameAttribute("rate of penetration (average)")]
        public static RealtimeData RateOfPenetrationAverage
        {
            get 
            {
                return rateOfPenetrationAverage;
            }
        }

        private readonly static RealtimeData rateOfPenetrationIntantaneous;
        /// <summary>
        /// Rate of Penetration (intantaneous)
        /// </summary>
        [EnumValueNameAttribute("rate of penetration (intantaneous)")]
        public static RealtimeData RateOfPenetrationIntantaneous
        {
            get 
            {
                return rateOfPenetrationIntantaneous;
            }
        }

        private readonly static RealtimeData rotationFlag;
        /// <summary>
        /// Rotation flag = 1 if pipe is rotating, else = 0
        /// </summary>
        [EnumValueNameAttribute("rotation flag")]
        public static RealtimeData RotationFlag
        {
            get 
            {
                return rotationFlag;
            }
        }

        private readonly static RealtimeData rotarySpeedAverage;
        /// <summary>
        /// Rotary speed, measured at surface (revs per minute)
        /// </summary>
        [EnumValueNameAttribute("rotary speed (average)")]
        public static RealtimeData RotarySpeedAverage
        {
            get 
            {
                return rotarySpeedAverage;
            }
        }

        private readonly static RealtimeData runningSpeedDownAverage;
        /// <summary>
        /// Trip average running speed, down
        /// </summary>
        [EnumValueNameAttribute("running speed down (average)")]
        public static RealtimeData RunningSpeedDownAverage
        {
            get 
            {
                return runningSpeedDownAverage;
            }
        }

        private readonly static RealtimeData runningSpeedDownMaximum;
        /// <summary>
        /// Trip maximum running speed, down
        /// </summary>
        [EnumValueNameAttribute("running speed down (maximum)")]
        public static RealtimeData RunningSpeedDownMaximum
        {
            get 
            {
                return runningSpeedDownMaximum;
            }
        }

        private readonly static RealtimeData runningSpeedUpAverage;
        /// <summary>
        /// Trip average running speed, up
        /// </summary>
        [EnumValueNameAttribute("running speed up (average)")]
        public static RealtimeData RunningSpeedUpAverage
        {
            get 
            {
                return runningSpeedUpAverage;
            }
        }

        private readonly static RealtimeData runningSpeedUpMaximum;
        /// <summary>
        /// Trip maximum running speed, up
        /// </summary>
        [EnumValueNameAttribute("running speed up (maximum)")]
        public static RealtimeData RunningSpeedUpMaximum
        {
            get 
            {
                return runningSpeedUpMaximum;
            }
        }

        private readonly static RealtimeData sonicCoherence;
        /// <summary>
        /// Coherence
        /// </summary>
        [EnumValueNameAttribute("sonic coherence")]
        public static RealtimeData SonicCoherence
        {
            get 
            {
                return sonicCoherence;
            }
        }

        private readonly static RealtimeData sonicDensity;
        /// <summary>
        /// Sonic density
        /// </summary>
        [EnumValueNameAttribute("sonic density")]
        public static RealtimeData SonicDensity
        {
            get 
            {
                return sonicDensity;
            }
        }

        private readonly static RealtimeData sonicDeltatimeCorrected;
        /// <summary>
        /// Sonic delta T corrected
        /// </summary>
        [EnumValueNameAttribute("sonic delta-time (corrected)")]
        public static RealtimeData SonicDeltatimeCorrected
        {
            get 
            {
                return sonicDeltatimeCorrected;
            }
        }

        private readonly static RealtimeData sonicDeltatimeUncorrected;
        /// <summary>
        /// Sonic delta T raw reading 
        /// </summary>
        [EnumValueNameAttribute("sonic delta-time (uncorrected)")]
        public static RealtimeData SonicDeltatimeUncorrected
        {
            get 
            {
                return sonicDeltatimeUncorrected;
            }
        }

        private readonly static RealtimeData sonicPorosity;
        /// <summary>
        /// Sonic porosity
        /// </summary>
        [EnumValueNameAttribute("sonic porosity")]
        public static RealtimeData SonicPorosity
        {
            get 
            {
                return sonicPorosity;
            }
        }

        private readonly static RealtimeData sonicPorosityCorrected;
        /// <summary>
        /// Sonic porosity corrected
        /// </summary>
        [EnumValueNameAttribute("sonic porosity (corrected)")]
        public static RealtimeData SonicPorosityCorrected
        {
            get 
            {
                return sonicPorosityCorrected;
            }
        }

        private readonly static RealtimeData strokeRate;
        /// <summary>
        /// Pump stroke rate (strokes/minute)
        /// </summary>
        [EnumValueNameAttribute("stroke rate")]
        public static RealtimeData StrokeRate
        {
            get 
            {
                return strokeRate;
            }
        }

        private readonly static RealtimeData strokeRateTotal;
        /// <summary>
        /// Cumulative pump stroke rate (strokes/minute)
        /// </summary>
        [EnumValueNameAttribute("stroke rate total")]
        public static RealtimeData StrokeRateTotal
        {
            get 
            {
                return strokeRateTotal;
            }
        }

        private readonly static RealtimeData stateOfWell;
        /// <summary>
        /// State of well during DST (SHUT-IN or FLOWING)
        /// </summary>
        [EnumValueNameAttribute("state of well")]
        public static RealtimeData StateOfWell
        {
            get 
            {
                return stateOfWell;
            }
        }

        private readonly static RealtimeData inslipsStatus;
        /// <summary>
        /// In-slips status (In or out)
        /// </summary>
        [EnumValueNameAttribute("in-slips status")]
        public static RealtimeData InslipsStatus
        {
            get 
            {
                return inslipsStatus;
            }
        }

        private readonly static RealtimeData lagStrokes;
        /// <summary>
        /// Lag strokes
        /// </summary>
        [EnumValueNameAttribute("lag strokes")]
        public static RealtimeData LagStrokes
        {
            get 
            {
                return lagStrokes;
            }
        }

        private readonly static RealtimeData strokeCountTotal;
        /// <summary>
        /// Cumulative total pump strokes
        /// </summary>
        [EnumValueNameAttribute("stroke count (total)")]
        public static RealtimeData StrokeCountTotal
        {
            get 
            {
                return strokeCountTotal;
            }
        }

        private readonly static RealtimeData strokeCount;
        /// <summary>
        /// Pump strokes for each pump
        /// </summary>
        [EnumValueNameAttribute("stroke count")]
        public static RealtimeData StrokeCount
        {
            get 
            {
                return strokeCount;
            }
        }

        private readonly static RealtimeData mudTemperatureInAverage;
        /// <summary>
        /// Mud temperature going into hole
        /// </summary>
        [EnumValueNameAttribute("mud temperature in (average)")]
        public static RealtimeData MudTemperatureInAverage
        {
            get 
            {
                return mudTemperatureInAverage;
            }
        }

        private readonly static RealtimeData mudTemperatureOutAverage;
        /// <summary>
        /// Mud temperature coming out of the hole
        /// </summary>
        [EnumValueNameAttribute("mud temperature out (average)")]
        public static RealtimeData MudTemperatureOutAverage
        {
            get 
            {
                return mudTemperatureOutAverage;
            }
        }

        private readonly static RealtimeData timeInSlips;
        /// <summary>
        /// Time in slips (seconds)
        /// </summary>
        [EnumValueNameAttribute("time in slips")]
        public static RealtimeData TimeInSlips
        {
            get 
            {
                return timeInSlips;
            }
        }

        private readonly static RealtimeData timeOutOfSlips;
        /// <summary>
        /// Time out of slips (seconds)
        /// </summary>
        [EnumValueNameAttribute("time out of slips")]
        public static RealtimeData TimeOutOfSlips
        {
            get 
            {
                return timeOutOfSlips;
            }
        }

        private readonly static RealtimeData torqueAverage;
        /// <summary>
        /// Rotary torque, average, measured at surface
        /// </summary>
        [EnumValueNameAttribute("torque (average)")]
        public static RealtimeData TorqueAverage
        {
            get 
            {
                return torqueAverage;
            }
        }

        private readonly static RealtimeData torqueForBreakoutMaximum;
        /// <summary>
        /// Break-out torque
        /// </summary>
        [EnumValueNameAttribute("torque for break-out (maximum)")]
        public static RealtimeData TorqueForBreakoutMaximum
        {
            get 
            {
                return torqueForBreakoutMaximum;
            }
        }

        private readonly static RealtimeData torqueForMakeupMaximum;
        /// <summary>
        /// Make-up torque
        /// </summary>
        [EnumValueNameAttribute("torque for make-up (maximum)")]
        public static RealtimeData TorqueForMakeupMaximum
        {
            get 
            {
                return torqueForMakeupMaximum;
            }
        }

        private readonly static RealtimeData torqueMaximum;
        /// <summary>
        /// Rotary torque, maximum, measured at surface
        /// </summary>
        [EnumValueNameAttribute("torque (maximum)")]
        public static RealtimeData TorqueMaximum
        {
            get 
            {
                return torqueMaximum;
            }
        }

        private readonly static RealtimeData tripTankVolume;
        /// <summary>
        /// Trip tank volume
        /// </summary>
        [EnumValueNameAttribute("trip tank volume")]
        public static RealtimeData TripTankVolume
        {
            get 
            {
                return tripTankVolume;
            }
        }

        private readonly static RealtimeData turnRate;
        /// <summary>
        /// MWD walk/turn rate
        /// </summary>
        [EnumValueNameAttribute("turn rate")]
        public static RealtimeData TurnRate
        {
            get 
            {
                return turnRate;
            }
        }

        private readonly static RealtimeData tvdOfBit;
        /// <summary>
        /// Total (vertical) depth of bit
        /// </summary>
        [EnumValueNameAttribute("TVD of Bit")]
        public static RealtimeData TvdOfBit
        {
            get 
            {
                return tvdOfBit;
            }
        }

        private readonly static RealtimeData tvdOfCasing;
        /// <summary>
        /// TVD of casing in the cementing context
        /// </summary>
        [EnumValueNameAttribute("TVD of casing")]
        public static RealtimeData TvdOfCasing
        {
            get 
            {
                return tvdOfCasing;
            }
        }

        private readonly static RealtimeData tvdOfDstBottom;
        /// <summary>
        /// Depth (vertical) of bottom of DST interval
        /// </summary>
        [EnumValueNameAttribute("TVD of DST bottom")]
        public static RealtimeData TvdOfDstBottom
        {
            get 
            {
                return tvdOfDstBottom;
            }
        }

        private readonly static RealtimeData tvdOfDstTop;
        /// <summary>
        /// Depth (vertical) of top of DST interval
        /// </summary>
        [EnumValueNameAttribute("TVD of DST top")]
        public static RealtimeData TvdOfDstTop
        {
            get 
            {
                return tvdOfDstTop;
            }
        }

        private readonly static RealtimeData tvdOfHole;
        /// <summary>
        /// Total (vertical) depth of hole
        /// </summary>
        [EnumValueNameAttribute("TVD of hole")]
        public static RealtimeData TvdOfHole
        {
            get 
            {
                return tvdOfHole;
            }
        }

        private readonly static RealtimeData tankVolume;
        /// <summary>
        /// Tank volume
        /// </summary>
        [EnumValueNameAttribute("tank volume")]
        public static RealtimeData TankVolume
        {
            get 
            {
                return tankVolume;
            }
        }

        private readonly static RealtimeData tankVolumeActive;
        /// <summary>
        /// Tank volume (active)
        /// </summary>
        [EnumValueNameAttribute("tank volume (active)")]
        public static RealtimeData TankVolumeActive
        {
            get 
            {
                return tankVolumeActive;
            }
        }

        private readonly static RealtimeData tankVolumeChange;
        /// <summary>
        /// Mud Tank Volume change
        /// </summary>
        [EnumValueNameAttribute("tank volume change")]
        public static RealtimeData TankVolumeChange
        {
            get 
            {
                return tankVolumeChange;
            }
        }

        private readonly static RealtimeData tankVolumeChangeActive;
        /// <summary>
        /// Tank volume change (active)
        /// </summary>
        [EnumValueNameAttribute("tank volume change (active)")]
        public static RealtimeData TankVolumeChangeActive
        {
            get 
            {
                return tankVolumeChangeActive;
            }
        }

        private readonly static RealtimeData tankVolumeChangeTotal;
        /// <summary>
        /// Tank volume change (total)
        /// </summary>
        [EnumValueNameAttribute("tank volume change total")]
        public static RealtimeData TankVolumeChangeTotal
        {
            get 
            {
                return tankVolumeChangeTotal;
            }
        }

        private readonly static RealtimeData tankVolumeTotal;
        /// <summary>
        /// Tank volume (total)
        /// </summary>
        [EnumValueNameAttribute("tank volume (total)")]
        public static RealtimeData TankVolumeTotal
        {
            get 
            {
                return tankVolumeTotal;
            }
        }

        private readonly static RealtimeData annularVelocityMinimum;
        /// <summary>
        /// Annular velocity (minimum)
        /// </summary>
        [EnumValueNameAttribute("annular velocity (minimum)")]
        public static RealtimeData AnnularVelocityMinimum
        {
            get 
            {
                return annularVelocityMinimum;
            }
        }

        private readonly static RealtimeData annularVelocityMaximum;
        /// <summary>
        /// Annular velocity (maximum)
        /// </summary>
        [EnumValueNameAttribute("annular velocity (maximum)")]
        public static RealtimeData AnnularVelocityMaximum
        {
            get 
            {
                return annularVelocityMaximum;
            }
        }

        private readonly static RealtimeData velocityOfJet;
        /// <summary>
        /// Bit jet velocity
        /// </summary>
        [EnumValueNameAttribute("velocity of jet")]
        public static RealtimeData VelocityOfJet
        {
            get 
            {
                return velocityOfJet;
            }
        }

        private readonly static RealtimeData fillVolumeExpected;
        /// <summary>
        /// Fill/gain volume, expected
        /// </summary>
        [EnumValueNameAttribute("fill volume (expected)")]
        public static RealtimeData FillVolumeExpected
        {
            get 
            {
                return fillVolumeExpected;
            }
        }

        private readonly static RealtimeData fillVolumeTotalExpected;
        /// <summary>
        /// Fill/gain volume, expected, cumulative
        /// </summary>
        [EnumValueNameAttribute("fill volume total (expected)")]
        public static RealtimeData FillVolumeTotalExpected
        {
            get 
            {
                return fillVolumeTotalExpected;
            }
        }

        private readonly static RealtimeData fillVolumeObserved;
        /// <summary>
        /// Fill/gain volume, observed
        /// </summary>
        [EnumValueNameAttribute("fill volume (observed)")]
        public static RealtimeData FillVolumeObserved
        {
            get 
            {
                return fillVolumeObserved;
            }
        }

        private readonly static RealtimeData fillVolumeTotalObserved;
        /// <summary>
        /// Fill/gain volume, observed, cumulative
        /// </summary>
        [EnumValueNameAttribute("fill volume total (observed)")]
        public static RealtimeData FillVolumeTotalObserved
        {
            get 
            {
                return fillVolumeTotalObserved;
            }
        }

        private readonly static RealtimeData weightOnBitAverage;
        /// <summary>
        /// Weight on bit, measured at surface
        /// </summary>
        [EnumValueNameAttribute("weight on bit (average)")]
        public static RealtimeData WeightOnBitAverage
        {
            get 
            {
                return weightOnBitAverage;
            }
        }

        private readonly static RealtimeData weightOnBitMaximum;
        /// <summary>
        /// Weight on bit, maximum, measured at surface
        /// </summary>
        [EnumValueNameAttribute("weight on bit (maximum)")]
        public static RealtimeData WeightOnBitMaximum
        {
            get 
            {
                return weightOnBitMaximum;
            }
        }

        private readonly static RealtimeData mudDensityInAverage;
        /// <summary>
        /// Mud density going into the hole
        /// </summary>
        [EnumValueNameAttribute("mud density in (average)")]
        public static RealtimeData MudDensityInAverage
        {
            get 
            {
                return mudDensityInAverage;
            }
        }

        private readonly static RealtimeData mudDensityOutAverage;
        /// <summary>
        /// Mud density coming out of the hole
        /// </summary>
        [EnumValueNameAttribute("mud density out (average)")]
        public static RealtimeData MudDensityOutAverage
        {
            get 
            {
                return mudDensityOutAverage;
            }
        }

        private readonly static RealtimeData yieldPoint;
        /// <summary>
        /// Mud yield point
        /// </summary>
        [EnumValueNameAttribute("yield point")]
        public static RealtimeData YieldPoint
        {
            get 
            {
                return yieldPoint;
            }
        }

        private readonly static RealtimeData unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static RealtimeData Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static RealtimeData()
        {
            lengthAlongFiber = 
                new RealtimeData("length along fiber")
                {
                    Description = "The position along the length of a DTS fiber."
            };
            dtsTemperature = 
                new RealtimeData("DTS temperature")
                {
                    Description = "The temperature that was calculated from Distributed Temperature Survey data."
            };
            stokesIntensity = 
                new RealtimeData("Stokes intensity")
                {
                    Description = "Stokes intensity values from a Distributed Temperature Survey."
            };
            antistokesIntensity = 
                new RealtimeData("anti-Stokes intensity")
                {
                    Description = "Anti-Stokes intensity values from a Distributed Temperature Survey."
            };
            acetylene = 
                new RealtimeData("acetylene")
                {
                    Description = "Acetylene ppm (cycle-based)"
            };
            azimuthCorrected = 
                new RealtimeData("azimuth corrected")
                {
                    Description = "MWD azimuth (corrected)"
            };
            azimuthUncorrected = 
                new RealtimeData("azimuth uncorrected")
                {
                    Description = "MWD azimuth (uncorrected)"
            };
            bitRevolutionsCumulative = 
                new RealtimeData("bit revolutions, cumulative")
                {
                    Description = "Bit revolutions, cumulative"
            };
            buildRate = 
                new RealtimeData("build rate")
                {
                    Description = "MWD build rate"
            };
            caliper = 
                new RealtimeData("caliper")
                {
                    Description = "Caliper measurement"
            };
            cavings = 
                new RealtimeData("cavings")
                {
                    Description = "Cavings percentage"
            };
            cationExchangeCapacity = 
                new RealtimeData("cation exchange capacity")
                {
                    Description = "Cation exchange capacity"
            };
            cementingCumulativeReturns = 
                new RealtimeData("cementing cumulative returns")
                {
                    Description = "Cementing cumulative returns"
            };
            cementingDensityInAverage = 
                new RealtimeData("cementing density in (average)")
                {
                    Description = "Cementing fluid density in (average)"
            };
            cementingDensityOutAverage = 
                new RealtimeData("cementing density out (average)")
                {
                    Description = "Cementing fluid density out (average)"
            };
            cementingEcdAtCasingShoe = 
                new RealtimeData("cementing ECD at casing shoe")
                {
                    Description = "Cementing effective circulating density at casing shoe"
            };
            cementingFlowRateInAverage = 
                new RealtimeData("cementing flow rate in (average)")
                {
                    Description = "Cementing flow rate in (average)"
            };
            cementingFlowRateInCalculated = 
                new RealtimeData("cementing flow rate in (calculated)")
                {
                    Description = "Cementing flow rate in (calculated)"
            };
            cementingFlowRateOutAverage = 
                new RealtimeData("cementing flow rate out (average)")
                {
                    Description = "Cementing flow rate out (average)"
            };
            cementingFlowRateOutCalculated = 
                new RealtimeData("cementing flow rate out (calculated)")
                {
                    Description = "Cementing flow rate out (calculated)"
            };
            cementingFlowRateOutRelative = 
                new RealtimeData("cementing flow rate out (relative)")
                {
                    Description = "Cementing flow rate out (percentage)"
            };
            cementingFluidType = 
                new RealtimeData("cementing fluid type")
                {
                    Description = "Cementing fluid type/batch"
            };
            cementingJobType = 
                new RealtimeData("cementing job type")
                {
                    Description = "Cementing job type"
            };
            cementingPlugs = 
                new RealtimeData("cementing plugs")
                {
                    Description = "Cementing number and status of plugs"
            };
            cementingPumpPressureAverage = 
                new RealtimeData("cementing pump pressure (average)")
                {
                    Description = "Cementing pump pressure (average)"
            };
            cementingStage = 
                new RealtimeData("cementing stage")
                {
                    Description = "Cementing stage number"
            };
            cementingTemperatureInAverage = 
                new RealtimeData("cementing temperature in (average)")
                {
                    Description = "Cementing fluid temperature in (average)"
            };
            cementingTemperatureOutAverage = 
                new RealtimeData("cementing temperature out (average)")
                {
                    Description = "Cementing fluid temperature out (average)"
            };
            cementingVolumeToBumpPlug = 
                new RealtimeData("cementing volume to bump plug")
                {
                    Description = "Cementing volume to bump plug"
            };
            cementingCementVolume = 
                new RealtimeData("cementing cement volume")
                {
                    Description = "Cementing cement volume pumped"
            };
            cementingIndividualVolume = 
                new RealtimeData("cementing individual volume")
                {
                    Description = "Cementing individual volume pumped"
            };
            cementingTotalVolume = 
                new RealtimeData("cementing total volume")
                {
                    Description = "Cementing total volume pumped"
            };
            chkprav = 
                new RealtimeData("chkPrAv")
                {
                    Description = "Casing pressure (average), measured at surface"
            };
            carbonDioxideCyclebased = 
                new RealtimeData("carbon dioxide (cycle-based)")
                {
                    Description = "Carbon Dioxide ppm (cycle-based)"
            };
            carbonDioxideAverage = 
                new RealtimeData("carbon dioxide (average)")
                {
                    Description = "Carbon Dioxide ppm (average)"
            };
            carbonDioxideMinimum = 
                new RealtimeData("carbon dioxide (minimum)")
                {
                    Description = "Carbon Dioxide ppm (min)"
            };
            carbonDioxideMaximum = 
                new RealtimeData("carbon dioxide (maximum)")
                {
                    Description = "Carbon Dioxide ppm (max)"
            };
            conductivity = 
                new RealtimeData("conductivity")
                {
                    Description = "Conductivity reading (corrected)"
            };
            conductivityOfMudInAverage = 
                new RealtimeData("conductivity of mud in (average)")
                {
                    Description = "Mud conductivity going into hole"
            };
            conductivityOfMudOutAverage = 
                new RealtimeData("conductivity of mud out (average)")
                {
                    Description = "Mud conductivity coming out of the hole"
            };
            connectionsDone = 
                new RealtimeData("connections done")
                {
                    Description = "Connections done"
            };
            connectionsRemaining = 
                new RealtimeData("connections remaining")
                {
                    Description = "Connections to go"
            };
            costPerDistance = 
                new RealtimeData("cost per distance")
                {
                    Description = "Instantaneous cost per distance"
            };
            costPerDistanceAverage = 
                new RealtimeData("cost per distance (average)")
                {
                    Description = "Cost per distance averaged over the bit run"
            };
            cumulativeTimeOnBit = 
                new RealtimeData("cumulative time on bit")
                {
                    Description = "Number of drilling hours on the bit"
            };
            density = 
                new RealtimeData("density")
                {
                    Description = "Density value"
            };
            densityShale = 
                new RealtimeData("density shale")
                {
                    Description = "Shale density"
            };
            diameterOfBit = 
                new RealtimeData("diameter of bit")
                {
                    Description = "Bit diameter"
            };
            distanceDrilledByBit = 
                new RealtimeData("distance drilled by bit")
                {
                    Description = "Distance drilled by the bit"
            };
            doglegSeverity = 
                new RealtimeData("dogleg severity")
                {
                    Description = "MWD dogleg severity"
            };
            dstBottomHolePressure = 
                new RealtimeData("DST bottom hole pressure")
                {
                    Description = "DST bottom hole pressure"
            };
            dstBottomHoleTemperature = 
                new RealtimeData("DST bottom hole temperature")
                {
                    Description = "DST Bottom hole temperature"
            };
            dstCumulativeGasProduction = 
                new RealtimeData("DST cumulative gas production")
                {
                    Description = "DST cumulative gas production"
            };
            dstCumulativeLiquidProduction = 
                new RealtimeData("DST cumulative liquid production")
                {
                    Description = "DST cumulative liquid production"
            };
            dstCumulativeTotalProduction = 
                new RealtimeData("DST cumulative total production")
                {
                    Description = "DST cumulative total production"
            };
            dstGasFlowRate = 
                new RealtimeData("DST gas flow rate")
                {
                    Description = "DST gas flow rate"
            };
            dstHydrogenSulfideAverage = 
                new RealtimeData("DST hydrogen sulfide (average)")
                {
                    Description = "Hydrogen Sulfide (average) ppm"
            };
            dstIdentifier = 
                new RealtimeData("DST identifier")
                {
                    Description = "Drill stem test identifier"
            };
            dstLiquidFlowRate = 
                new RealtimeData("DST liquid flow rate")
                {
                    Description = "DST liquid flow rate"
            };
            dstSurfacePressureInCasing = 
                new RealtimeData("DST surface pressure in casing")
                {
                    Description = "DST surface pressure in casing"
            };
            dstSurfacePressureInTubing = 
                new RealtimeData("DST surface pressure in tubing")
                {
                    Description = "DST surface pressure in tubing"
            };
            dstSurfaceTemperatureInTubing = 
                new RealtimeData("DST surface temperature in tubing")
                {
                    Description = "DST Surface temperature in tubing"
            };
            dstTotalFlowRate = 
                new RealtimeData("DST total flow rate")
                {
                    Description = "DST Total flow rate"
            };
            dstToolTime = 
                new RealtimeData("DST tool time")
                {
                    Description = "DST tool time (seconds)"
            };
            drillingExponentCorrected = 
                new RealtimeData("drilling exponent (corrected)")
                {
                    Description = "Corrected drilling exponent"
            };
            ecdAtBitDepth = 
                new RealtimeData("ECD at bit depth")
                {
                    Description = "Effective circulating density at bit depth"
            };
            ecdAtCasingShoeDepth = 
                new RealtimeData("ECD at casing shoe depth")
                {
                    Description = "ECD at casing shoe depth"
            };
            ecdFromMwdTool = 
                new RealtimeData("ECD from MWD tool")
                {
                    Description = "ECD from MWD tool"
            };
            ecdAtTotalDepth = 
                new RealtimeData("ECD at total depth")
                {
                    Description = "Equivalent circulating density at total depth"
            };
            neopentane = 
                new RealtimeData("neo-pentane")
                {
                    Description = "neo-Pentane (eC5) ppm (cycle-based)"
            };
            neopentaneAverage = 
                new RealtimeData("neo-pentane (average)")
                {
                    Description = "neo-Pentane (eC5) ppm (average)"
            };
            neopentaneMinimum = 
                new RealtimeData("neo-pentane (minimum)")
                {
                    Description = "neo-Pentane (eC5) ppm (min)"
            };
            neopentaneMaximum = 
                new RealtimeData("neo-pentane (maximum)")
                {
                    Description = "neo-Pentane (eC5) ppm (max)"
            };
            ethane = 
                new RealtimeData("ethane")
                {
                    Description = "Ethane (C2) ppm (cycle-based)"
            };
            ethaneAverage = 
                new RealtimeData("ethane (average)")
                {
                    Description = "Ethane (C2) ppm (average)"
            };
            ethaneMinimum = 
                new RealtimeData("ethane (minimum)")
                {
                    Description = "Ethane (C2) ppm (min)"
            };
            ethaneMaximum = 
                new RealtimeData("ethane (maximum)")
                {
                    Description = "Ethane (C2) ppm (max)"
            };
            formationFracturePressureGradient = 
                new RealtimeData("formation fracture pressure gradient")
                {
                    Description = "Formation fracture pressure gradient"
            };
            flowRateInAverage = 
                new RealtimeData("flow rate in (average)")
                {
                    Description = "Mud flow into the hole"
            };
            flowInRelative = 
                new RealtimeData("flow in (relative)")
                {
                    Description = "Flow into the hole measured as a percentage"
            };
            flowRateOutAverage = 
                new RealtimeData("flow rate out (average)")
                {
                    Description = "Mud flow out of the hole"
            };
            flowOutRelative = 
                new RealtimeData("flow out (relative)")
                {
                    Description = "Flow out of hole measured as a percentage"
            };
            overburdenPressureGradient = 
                new RealtimeData("overburden pressure gradient")
                {
                    Description = "Formation overburden pressure gradient"
            };
            bitJetImpactForce = 
                new RealtimeData("bit jet impact force")
                {
                    Description = "Bit jet impact force"
            };
            formationPorePressureGradient = 
                new RealtimeData("formation pore pressure gradient")
                {
                    Description = "Formation pore pressure gradient"
            };
            gasTotalAverage = 
                new RealtimeData("gas total (average)")
                {
                    Description = "Total gas %"
            };
            connectionGasAverage = 
                new RealtimeData("connection gas (average)")
                {
                    Description = "Connection gas (average) %"
            };
            connectionGasLast = 
                new RealtimeData("connection gas (last)")
                {
                    Description = "Connection gas (last reading) %"
            };
            connectionGasMaximum = 
                new RealtimeData("connection gas (maximum)")
                {
                    Description = "Connection gas (maximum) %"
            };
            tripGasLast = 
                new RealtimeData("trip gas (last)")
                {
                    Description = "Trip gas last reading %"
            };
            gammaRay = 
                new RealtimeData("gamma ray")
                {
                    Description = "Gamma ray reading (uncorrected)"
            };
            gammaRayCorrected = 
                new RealtimeData("gamma ray (corrected)")
                {
                    Description = "Gamma ray reading (corrected)"
            };
            gravityToolFace = 
                new RealtimeData("gravity tool face")
                {
                    Description = "MWD gravity tool face"
            };
            gravityXaxisCorrected = 
                new RealtimeData("gravity X-axis (corrected)")
                {
                    Description = "X axis gravity corrected"
            };
            gravityXaxisUncorrected = 
                new RealtimeData("gravity X-axis (uncorrected)")
                {
                    Description = "X axis gravity uncorrected"
            };
            gravityYaxisCorrected = 
                new RealtimeData("gravity Y-axis (corrected)")
                {
                    Description = "Y axis gravity corrected"
            };
            gravityYaxisUncorrected = 
                new RealtimeData("gravity Y-axis (uncorrected)")
                {
                    Description = "Y axis gravity uncorrected"
            };
            gravityZaxisCorrected = 
                new RealtimeData("gravity Z-axis (corrected)")
                {
                    Description = "Z axis gravity corrected"
            };
            gravityZaxisUncorrected = 
                new RealtimeData("gravity Z-axis (uncorrected)")
                {
                    Description = "Z axis gravity uncorrected"
            };
            hydrogenSulfide = 
                new RealtimeData("hydrogen sulfide")
                {
                    Description = "Hydrogen Sulfide ppm"
            };
            hydrogenSulfideAverage = 
                new RealtimeData("hydrogen sulfide (average)")
                {
                    Description = "Hydrogen Sulfide (average) ppm"
            };
            hydrogenSulfideMinimum = 
                new RealtimeData("hydrogen sulfide (minimum)")
                {
                    Description = "Hydrogen Sulfide (min) ppm"
            };
            hydrogenSulfideMaximum = 
                new RealtimeData("hydrogen sulfide (maximum)")
                {
                    Description = "Hydrogen Sulfide (max) ppm"
            };
            hookloadAverage = 
                new RealtimeData("hookload (average)")
                {
                    Description = "Hookload, average, measured at surface"
            };
            hookloadMinimum = 
                new RealtimeData("hookload (minimum)")
                {
                    Description = "Minimum hookload while running the stand"
            };
            hookloadMaximum = 
                new RealtimeData("hookload (maximum)")
                {
                    Description = "Hookload, maximum measured at surface"
            };
            mwdMagnetometerXCorrected = 
                new RealtimeData("MWD magnetometer X (corrected)")
                {
                    Description = "X axis magnetic corrected"
            };
            mwdMagnetometerXRaw = 
                new RealtimeData("MWD magnetometer X (raw)")
                {
                    Description = "X axis magnetic uncorrected"
            };
            mwdMagnetometerYCorrected = 
                new RealtimeData("MWD magnetometer Y (corrected)")
                {
                    Description = "Y axis magnetic corrected"
            };
            mwdMagnetometerYRaw = 
                new RealtimeData("MWD magnetometer Y (raw)")
                {
                    Description = "Y axis magnetic uncorrected"
            };
            mwdMagnetometerZCorrected = 
                new RealtimeData("MWD magnetometer Z (corrected)")
                {
                    Description = "Z axis magnetic corrected"
            };
            mwdMagnetometerZRaw = 
                new RealtimeData("MWD magnetometer Z (raw)")
                {
                    Description = "Z axis magnetic uncorrected"
            };
            isobutane = 
                new RealtimeData("iso-butane")
                {
                    Description = "iso-Butane (iC4) ppm (cycle-based)"
            };
            isobutaneAverage = 
                new RealtimeData("iso-butane (average)")
                {
                    Description = "iso-Butane (iC4) ppm (average)"
            };
            isobutaneMinimum = 
                new RealtimeData("iso-butane (minimum)")
                {
                    Description = "iso-Butane (iC4) ppm (min)"
            };
            isobutaneMaximum = 
                new RealtimeData("iso-butane (maximum)")
                {
                    Description = "iso-Butane (iC4) ppm (max)"
            };
            isohexane = 
                new RealtimeData("iso-hexane")
                {
                    Description = "iso-Hexane (iC6) ppm (cycle-based)"
            };
            isohexaneAverage = 
                new RealtimeData("iso-hexane (average)")
                {
                    Description = "iso-Hexane (iC6) ppm (average)"
            };
            isohexaneMinimum = 
                new RealtimeData("iso-hexane (minimum)")
                {
                    Description = "iso-Hexane (iC6) ppm (min)"
            };
            isohexaneMaximum = 
                new RealtimeData("iso-hexane (maximum)")
                {
                    Description = "iso-Hexane (iC6) ppm (max)"
            };
            inclinationCorrected = 
                new RealtimeData("inclination (corrected)")
                {
                    Description = "MWD inclination (corrected)"
            };
            inclinationNearBit = 
                new RealtimeData("inclination near bit")
                {
                    Description = "Near-bit inclination"
            };
            inclinationUncorrected = 
                new RealtimeData("inclination (uncorrected)")
                {
                    Description = "MWD inclination (uncorrected)"
            };
            isopentane = 
                new RealtimeData("iso-pentane")
                {
                    Description = "iso-Pentane (iC5) ppm (cycle-based)"
            };
            isopentaneAverage = 
                new RealtimeData("iso-pentane (average)")
                {
                    Description = "iso-Pentane (iC5) ppm (average)"
            };
            isopentaneMinimum = 
                new RealtimeData("iso-pentane (minimum)")
                {
                    Description = "iso-Pentane (iC5) ppm (min)"
            };
            isopentaneMaximum = 
                new RealtimeData("iso-pentane (maximum)")
                {
                    Description = "iso-Pentane (iC5) ppm (max)"
            };
            kickTolerance = 
                new RealtimeData("kick tolerance")
                {
                    Description = "Kick tolerance"
            };
            lithologyFlag = 
                new RealtimeData("lithology flag")
                {
                    Description = "Lithology flag"
            };
            mwdAlternatorVoltage = 
                new RealtimeData("MWD alternator voltage")
                {
                    Description = "Downhole tool alternator voltage"
            };
            mwdBottomHoleAnnulusPressure = 
                new RealtimeData("MWD bottom hole annulus pressure")
                {
                    Description = "Bottom hole annulus pressure"
            };
            mwdBottomHoleInternalPressure = 
                new RealtimeData("MWD bottom hole internal pressure")
                {
                    Description = "Bottom hole internal pressure"
            };
            bitTotalMeasuredDepth = 
                new RealtimeData("bit total measured depth")
                {
                    Description = "Total (measured) depth of bit"
            };
            mwdConductivity = 
                new RealtimeData("MWD conductivity")
                {
                    Description = "Mud conductivity"
            };
            measuredDepthOfCasing = 
                new RealtimeData("measured depth of casing")
                {
                    Description = "Measured depth of casing in the cementing "
            };
            measuredDepthOfDstBottom = 
                new RealtimeData("measured depth of DST bottom")
                {
                    Description = "Depth (measured) of bottom of DST interval"
            };
            measuredDepthOfDstTop = 
                new RealtimeData("measured depth of DST top")
                {
                    Description = "Depth (measured) of top of DST interval"
            };
            measuredDepthOfDiverterTool = 
                new RealtimeData("measured depth of diverter tool")
                {
                    Description = "Cementing depth to DV tool"
            };
            measuredDepthOfHole = 
                new RealtimeData("measured depth of hole")
                {
                    Description = "Total (measured) depth of hole"
            };
            measuredDepthOfReturns = 
                new RealtimeData("measured depth of returns")
                {
                    Description = "Depth of cuttings returns"
            };
            methane = 
                new RealtimeData("methane")
                {
                    Description = "Methane (C1) ppm (cycle-based)"
            };
            methaneAverage = 
                new RealtimeData("methane (average)")
                {
                    Description = "Methane (C1) ppm (average)"
            };
            methaneMinimum = 
                new RealtimeData("methane (minimum)")
                {
                    Description = "Methane (C1) ppm (min)"
            };
            methaneMaximum = 
                new RealtimeData("methane (maximum)")
                {
                    Description = "Methane (C1) ppm (max)"
            };
            mwdDerivedFracturePressureGradient = 
                new RealtimeData("MWD derived fracture pressure gradient")
                {
                    Description = "Fracture pressure gradient from MWD"
            };
            mwdDerivedPorePressureGradient = 
                new RealtimeData("MWD derived pore pressure gradient")
                {
                    Description = "Pore Pressure gradient from MWD"
            };
            mwdFluidResistivityInAnnulus = 
                new RealtimeData("MWD fluid resistivity in annulus")
                {
                    Description = "Downhole fluid resistivity in annulus"
            };
            mwdFluidResistivityInPipe = 
                new RealtimeData("MWD fluid resistivity in pipe")
                {
                    Description = "Downhole fluid resistivity in pipe"
            };
            mwdFluidTemperatureInAnnulus = 
                new RealtimeData("MWD fluid temperature in annulus")
                {
                    Description = "Downhole fluid temperature in annulus"
            };
            mwdFluidTemperatureInPipe = 
                new RealtimeData("MWD fluid temperature in pipe")
                {
                    Description = "Downhole fluid temperature in pipe"
            };
            mwdGammaRay = 
                new RealtimeData("MWD gamma ray")
                {
                    Description = "Measured gamma ray value"
            };
            mwdGammaRayCorrected = 
                new RealtimeData("MWD gamma ray (corrected)")
                {
                    Description = "Borehole corrected gamma ray value"
            };
            mwdMotorSpeed = 
                new RealtimeData("MWD motor speed")
                {
                    Description = "Downhole motor RPM"
            };
            mwdResistivity = 
                new RealtimeData("MWD resistivity")
                {
                    Description = "Measured resistivity value"
            };
            mwdResistivityCorrected = 
                new RealtimeData("MWD resistivity (corrected)")
                {
                    Description = "Borehole corrected resistivity value"
            };
            magneticToolFace = 
                new RealtimeData("magnetic tool face")
                {
                    Description = "MWD magnetic tool face"
            };
            mwdTorqueAverage = 
                new RealtimeData("MWD torque (average)")
                {
                    Description = "Downhole torque (average)"
            };
            mwdTorqueMaximum = 
                new RealtimeData("MWD torque (maximum)")
                {
                    Description = "Downhole torque (maximum)"
            };
            mwdAxialVibration = 
                new RealtimeData("MWD axial vibration")
                {
                    Description = "Downhole vibration in axial direction"
            };
            mwdLateralVibration = 
                new RealtimeData("MWD lateral vibration")
                {
                    Description = "Downhole vibration in lateral direction"
            };
            mwdTorsionalVibration = 
                new RealtimeData("MWD torsional vibration")
                {
                    Description = "Downhole vibration in torsional direction"
            };
            mwdWeightOnBitAverage = 
                new RealtimeData("MWD weight on bit (average)")
                {
                    Description = "Downhole weight on bit (average)"
            };
            mwdWeightOnBitMaximum = 
                new RealtimeData("MWD weight on bit (maximum)")
                {
                    Description = "Downhole weight on bit (maximum)"
            };
            norbutane = 
                new RealtimeData("nor-butane")
                {
                    Description = "nor-Butane (nC4) ppm (cycle-based)"
            };
            norbutaneAverage = 
                new RealtimeData("nor-butane (average)")
                {
                    Description = "nor-Butane (nC4) ppm (average)"
            };
            norbutaneMinimum = 
                new RealtimeData("nor-butane (minimum)")
                {
                    Description = "nor-Butane (nC4) ppm (min)"
            };
            norbutaneMaximum = 
                new RealtimeData("nor-butane (maximum)")
                {
                    Description = "nor-Butane (nC4) ppm (max)"
            };
            neutronDensity = 
                new RealtimeData("neutron density")
                {
                    Description = "Neutron density"
            };
            norhexane = 
                new RealtimeData("nor-hexane")
                {
                    Description = "nor-Hexane (nC6) ppm (cycle-based)"
            };
            norhexaneAverage = 
                new RealtimeData("nor-hexane (average)")
                {
                    Description = "nor-Hexane (nC6) ppm (average)"
            };
            norhexaneMinimum = 
                new RealtimeData("nor-hexane (minimum)")
                {
                    Description = "nor-Hexane (nC6) ppm (min)"
            };
            norhexaneMaximum = 
                new RealtimeData("nor-hexane (maximum)")
                {
                    Description = "nor-Hexane (nC6) ppm (max)"
            };
            norpentane = 
                new RealtimeData("nor-pentane")
                {
                    Description = "nor-Pentane (nC5) ppm (cycle-based)"
            };
            norpentaneAverage = 
                new RealtimeData("nor-pentane (average)")
                {
                    Description = "nor-Pentane (nC5) ppm (average)"
            };
            norpentaneMinimum = 
                new RealtimeData("nor-pentane (minimum)")
                {
                    Description = "nor-Pentane (nC5) ppm (min)"
            };
            norpentaneMaximum = 
                new RealtimeData("nor-pentane (maximum)")
                {
                    Description = "nor-Pentane (nC5) ppm (max)"
            };
            neutronPorosity = 
                new RealtimeData("neutron porosity")
                {
                    Description = "Neutron porosity"
            };
            neutronPorosityCorrected = 
                new RealtimeData("neutron porosity (corrected)")
                {
                    Description = "Neutron porosity corrected"
            };
            neutronPorosityRatio = 
                new RealtimeData("neutron porosity ratio")
                {
                    Description = "Neutron porosity ratio"
            };
            passNumber = 
                new RealtimeData("pass number")
                {
                    Description = "MWD pass number"
            };
            tripNumber = 
                new RealtimeData("trip number")
                {
                    Description = "Trip number"
            };
            photoelectricEffect = 
                new RealtimeData("photoelectric effect")
                {
                    Description = "Photoelectric effect"
            };
            bitPressureLoss = 
                new RealtimeData("bit pressure loss")
                {
                    Description = "Bit pressure loss"
            };
            blockPosition = 
                new RealtimeData("block position")
                {
                    Description = "Block position"
            };
            hydraulicPowerOfBit = 
                new RealtimeData("hydraulic power of bit")
                {
                    Description = "Bit hydraulic power"
            };
            hydraulicPowerPerAreaOfBit = 
                new RealtimeData("hydraulic power per area of bit")
                {
                    Description = "Bit hydraulic power per area"
            };
            hydraulicPowerOfPump = 
                new RealtimeData("hydraulic power of pump")
                {
                    Description = "Pump hydraulic power"
            };
            pressureLossAtAnnulus = 
                new RealtimeData("pressure loss at annulus")
                {
                    Description = "Annulus pressure loss"
            };
            pressureDropAtBit = 
                new RealtimeData("pressure drop at bit")
                {
                    Description = "pressure drop at the bit"
            };
            pressureLossAtBit = 
                new RealtimeData("pressure loss at bit")
                {
                    Description = "Bit pressure loss percentage"
            };
            pressureDropCalculatedOrObserved = 
                new RealtimeData("pressure drop (calculated or observed)")
                {
                    Description = "Calculated/observed pressure loss ratio (%)"
            };
            pressureDropAtMotor = 
                new RealtimeData("pressure drop at motor")
                {
                    Description = "Mud motor pressure loss"
            };
            pressureDropAtMwdTool = 
                new RealtimeData("pressure drop at MWD tool")
                {
                    Description = "MWD tool pressure loss"
            };
            pressureDropAtString = 
                new RealtimeData("pressure drop at string")
                {
                    Description = "Pipe (drillstring) pressure loss"
            };
            pressureDropAtSurface = 
                new RealtimeData("pressure drop at surface")
                {
                    Description = "Surface pressure loss"
            };
            pressureAtMwdTool = 
                new RealtimeData("pressure at MWD tool")
                {
                    Description = "Downhole pressure from MWD tool"
            };
            pressureAtPumpAverage = 
                new RealtimeData("pressure at pump (average)")
                {
                    Description = "Pump (standpipe) pressure, measured at surface"
            };
            shutinPressureMaximum = 
                new RealtimeData("shut-in pressure (maximum)")
                {
                    Description = "Maximum permitted shut-in pressure"
            };
            propane = 
                new RealtimeData("propane")
                {
                    Description = "Propane (C3) ppm (cycle-based)"
            };
            propaneAverage = 
                new RealtimeData("propane (average)")
                {
                    Description = "Propane (C3) ppm (average)"
            };
            propaneMinimum = 
                new RealtimeData("propane (minimum)")
                {
                    Description = "Propane (C3) ppm (min)"
            };
            propaneMaximum = 
                new RealtimeData("propane (maximum)")
                {
                    Description = "Propane (C3) ppm (max)"
            };
            plasticViscosity = 
                new RealtimeData("plastic viscosity")
                {
                    Description = "Mud plastic viscosity"
            };
            resistivity = 
                new RealtimeData("resistivity")
                {
                    Description = "Resistivity reading"
            };
            resistivityCorrected = 
                new RealtimeData("resistivity (corrected)")
                {
                    Description = "Resistivity reading (corrected)"
            };
            rateOfPenetrationAverage = 
                new RealtimeData("rate of penetration (average)")
                {
                    Description = "Drill Rate"
            };
            rateOfPenetrationIntantaneous = 
                new RealtimeData("rate of penetration (intantaneous)")
                {
                    Description = "Rate of Penetration (intantaneous)"
            };
            rotationFlag = 
                new RealtimeData("rotation flag")
                {
                    Description = "Rotation flag = 1 if pipe is rotating, else = 0"
            };
            rotarySpeedAverage = 
                new RealtimeData("rotary speed (average)")
                {
                    Description = "Rotary speed, measured at surface (revs per minute)"
            };
            runningSpeedDownAverage = 
                new RealtimeData("running speed down (average)")
                {
                    Description = "Trip average running speed, down"
            };
            runningSpeedDownMaximum = 
                new RealtimeData("running speed down (maximum)")
                {
                    Description = "Trip maximum running speed, down"
            };
            runningSpeedUpAverage = 
                new RealtimeData("running speed up (average)")
                {
                    Description = "Trip average running speed, up"
            };
            runningSpeedUpMaximum = 
                new RealtimeData("running speed up (maximum)")
                {
                    Description = "Trip maximum running speed, up"
            };
            sonicCoherence = 
                new RealtimeData("sonic coherence")
                {
                    Description = "Coherence"
            };
            sonicDensity = 
                new RealtimeData("sonic density")
                {
                    Description = "Sonic density"
            };
            sonicDeltatimeCorrected = 
                new RealtimeData("sonic delta-time (corrected)")
                {
                    Description = "Sonic delta T corrected"
            };
            sonicDeltatimeUncorrected = 
                new RealtimeData("sonic delta-time (uncorrected)")
                {
                    Description = "Sonic delta T raw reading "
            };
            sonicPorosity = 
                new RealtimeData("sonic porosity")
                {
                    Description = "Sonic porosity"
            };
            sonicPorosityCorrected = 
                new RealtimeData("sonic porosity (corrected)")
                {
                    Description = "Sonic porosity corrected"
            };
            strokeRate = 
                new RealtimeData("stroke rate")
                {
                    Description = "Pump stroke rate (strokes/minute)"
            };
            strokeRateTotal = 
                new RealtimeData("stroke rate total")
                {
                    Description = "Cumulative pump stroke rate (strokes/minute)"
            };
            stateOfWell = 
                new RealtimeData("state of well")
                {
                    Description = "State of well during DST (SHUT-IN or FLOWING)"
            };
            inslipsStatus = 
                new RealtimeData("in-slips status")
                {
                    Description = "In-slips status (In or out)"
            };
            lagStrokes = 
                new RealtimeData("lag strokes")
                {
                    Description = "Lag strokes"
            };
            strokeCountTotal = 
                new RealtimeData("stroke count (total)")
                {
                    Description = "Cumulative total pump strokes"
            };
            strokeCount = 
                new RealtimeData("stroke count")
                {
                    Description = "Pump strokes for each pump"
            };
            mudTemperatureInAverage = 
                new RealtimeData("mud temperature in (average)")
                {
                    Description = "Mud temperature going into hole"
            };
            mudTemperatureOutAverage = 
                new RealtimeData("mud temperature out (average)")
                {
                    Description = "Mud temperature coming out of the hole"
            };
            timeInSlips = 
                new RealtimeData("time in slips")
                {
                    Description = "Time in slips (seconds)"
            };
            timeOutOfSlips = 
                new RealtimeData("time out of slips")
                {
                    Description = "Time out of slips (seconds)"
            };
            torqueAverage = 
                new RealtimeData("torque (average)")
                {
                    Description = "Rotary torque, average, measured at surface"
            };
            torqueForBreakoutMaximum = 
                new RealtimeData("torque for break-out (maximum)")
                {
                    Description = "Break-out torque"
            };
            torqueForMakeupMaximum = 
                new RealtimeData("torque for make-up (maximum)")
                {
                    Description = "Make-up torque"
            };
            torqueMaximum = 
                new RealtimeData("torque (maximum)")
                {
                    Description = "Rotary torque, maximum, measured at surface"
            };
            tripTankVolume = 
                new RealtimeData("trip tank volume")
                {
                    Description = "Trip tank volume"
            };
            turnRate = 
                new RealtimeData("turn rate")
                {
                    Description = "MWD walk/turn rate"
            };
            tvdOfBit = 
                new RealtimeData("TVD of Bit")
                {
                    Description = "Total (vertical) depth of bit"
            };
            tvdOfCasing = 
                new RealtimeData("TVD of casing")
                {
                    Description = "TVD of casing in the cementing context"
            };
            tvdOfDstBottom = 
                new RealtimeData("TVD of DST bottom")
                {
                    Description = "Depth (vertical) of bottom of DST interval"
            };
            tvdOfDstTop = 
                new RealtimeData("TVD of DST top")
                {
                    Description = "Depth (vertical) of top of DST interval"
            };
            tvdOfHole = 
                new RealtimeData("TVD of hole")
                {
                    Description = "Total (vertical) depth of hole"
            };
            tankVolume = 
                new RealtimeData("tank volume")
                {
                    Description = "Tank volume"
            };
            tankVolumeActive = 
                new RealtimeData("tank volume (active)")
                {
                    Description = "Tank volume (active)"
            };
            tankVolumeChange = 
                new RealtimeData("tank volume change")
                {
                    Description = "Mud Tank Volume change"
            };
            tankVolumeChangeActive = 
                new RealtimeData("tank volume change (active)")
                {
                    Description = "Tank volume change (active)"
            };
            tankVolumeChangeTotal = 
                new RealtimeData("tank volume change total")
                {
                    Description = "Tank volume change (total)"
            };
            tankVolumeTotal = 
                new RealtimeData("tank volume (total)")
                {
                    Description = "Tank volume (total)"
            };
            annularVelocityMinimum = 
                new RealtimeData("annular velocity (minimum)")
                {
                    Description = "Annular velocity (minimum)"
            };
            annularVelocityMaximum = 
                new RealtimeData("annular velocity (maximum)")
                {
                    Description = "Annular velocity (maximum)"
            };
            velocityOfJet = 
                new RealtimeData("velocity of jet")
                {
                    Description = "Bit jet velocity"
            };
            fillVolumeExpected = 
                new RealtimeData("fill volume (expected)")
                {
                    Description = "Fill/gain volume, expected"
            };
            fillVolumeTotalExpected = 
                new RealtimeData("fill volume total (expected)")
                {
                    Description = "Fill/gain volume, expected, cumulative"
            };
            fillVolumeObserved = 
                new RealtimeData("fill volume (observed)")
                {
                    Description = "Fill/gain volume, observed"
            };
            fillVolumeTotalObserved = 
                new RealtimeData("fill volume total (observed)")
                {
                    Description = "Fill/gain volume, observed, cumulative"
            };
            weightOnBitAverage = 
                new RealtimeData("weight on bit (average)")
                {
                    Description = "Weight on bit, measured at surface"
            };
            weightOnBitMaximum = 
                new RealtimeData("weight on bit (maximum)")
                {
                    Description = "Weight on bit, maximum, measured at surface"
            };
            mudDensityInAverage = 
                new RealtimeData("mud density in (average)")
                {
                    Description = "Mud density going into the hole"
            };
            mudDensityOutAverage = 
                new RealtimeData("mud density out (average)")
                {
                    Description = "Mud density coming out of the hole"
            };
            yieldPoint = 
                new RealtimeData("yield point")
                {
                    Description = "Mud yield point"
            };
            unknown = 
                new RealtimeData("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
            };
        }

        /// <summary>
        /// Gets a RealtimeData by name
        /// </summary>
        /// <param name="name">The name of the RealtimeData to return</param>
        /// <returns>The RealtimeData represented by 'name'</returns>
        public static RealtimeData GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(RealtimeData)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(RealtimeData)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (RealtimeData)ev;
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
        /// Magnetic - "Modified Frequency Modulation for Magnetic Stripes" standard developed by AIM Inc.
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
        /// Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the "tag". 
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
                    Description = "Barcode - 1995, Uniform Symbology Specification "
            };
            ansiaimbcSix = 
                new NameTagNumberingScheme("ANSI/AIM-BC6")
                {
                    Description = "Barcode - 1995, Uniform Symbology Multi Row Specification "
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
                    Description = "Magnetic - \"Modified Frequency Modulation for Magnetic Stripes\" standard developed by AIM Inc."
            };
            serialNumber = 
                new NameTagNumberingScheme("serial number")
                {
                    Description = "Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the \"tag\". "
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
