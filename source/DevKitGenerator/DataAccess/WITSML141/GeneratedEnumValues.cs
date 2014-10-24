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

        private static ActivityCode abandonment;
        /// <summary>
        /// abandonment
        /// </summary>
        [EnumValueNameAttribute("abandonment")]
        public static ActivityCode Abandonment
        {
            get 
            {
                if (abandonment == null)
                {
                    abandonment = new ActivityCode("abandonment");
                    abandonment.Description = "abandonment";
                }
                return abandonment;
            }
        }

        private static ActivityCode abandonmentLogPlugs;
        /// <summary>
        /// A specialization of 'abandonment'.
        /// </summary>
        [EnumValueNameAttribute("abandonment -- log plugs")]
        public static ActivityCode AbandonmentLogPlugs
        {
            get 
            {
                if (abandonmentLogPlugs == null)
                {
                    abandonmentLogPlugs = new ActivityCode("abandonment -- log plugs");
                    abandonmentLogPlugs.Description = "A specialization of 'abandonment'.";
                }
                return abandonmentLogPlugs;
            }
        }

        private static ActivityCode abandonmentRunPlugs;
        /// <summary>
        /// A specialization of 'abandonment'.
        /// </summary>
        [EnumValueNameAttribute("abandonment -- run plugs")]
        public static ActivityCode AbandonmentRunPlugs
        {
            get 
            {
                if (abandonmentRunPlugs == null)
                {
                    abandonmentRunPlugs = new ActivityCode("abandonment -- run plugs");
                    abandonmentRunPlugs.Description = "A specialization of 'abandonment'.";
                }
                return abandonmentRunPlugs;
            }
        }

        private static ActivityCode abandonmentWaitOnCement;
        /// <summary>
        /// A specialization of 'abandonment'.
        /// </summary>
        [EnumValueNameAttribute("abandonment -- wait on cement")]
        public static ActivityCode AbandonmentWaitOnCement
        {
            get 
            {
                if (abandonmentWaitOnCement == null)
                {
                    abandonmentWaitOnCement = new ActivityCode("abandonment -- wait on cement");
                    abandonmentWaitOnCement.Description = "A specialization of 'abandonment'.";
                }
                return abandonmentWaitOnCement;
            }
        }

        private static ActivityCode casingCement;
        /// <summary>
        /// casing and cement
        /// </summary>
        [EnumValueNameAttribute("casing, cement")]
        public static ActivityCode CasingCement
        {
            get 
            {
                if (casingCement == null)
                {
                    casingCement = new ActivityCode("casing, cement");
                    casingCement.Description = "casing and cement";
                }
                return casingCement;
            }
        }

        private static ActivityCode casingCementCirculateCement;
        /// <summary>
        /// A specialization of 'casing, cement': circulate and cement
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- circulate, cement")]
        public static ActivityCode CasingCementCirculateCement
        {
            get 
            {
                if (casingCementCirculateCement == null)
                {
                    casingCementCirculateCement = new ActivityCode("casing, cement -- circulate, cement");
                    casingCementCirculateCement.Description = "A specialization of 'casing, cement': circulate and cement";
                }
                return casingCementCirculateCement;
            }
        }

        private static ActivityCode casingCementOther;
        /// <summary>
        /// A specialization of 'casing, cement'.
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- other")]
        public static ActivityCode CasingCementOther
        {
            get 
            {
                if (casingCementOther == null)
                {
                    casingCementOther = new ActivityCode("casing, cement -- other");
                    casingCementOther.Description = "A specialization of 'casing, cement'.";
                }
                return casingCementOther;
            }
        }

        private static ActivityCode casingCementRigUpRunCasing;
        /// <summary>
        /// A specialization of 'casing, cement': rig up and run casing
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- rig up, run casing")]
        public static ActivityCode CasingCementRigUpRunCasing
        {
            get 
            {
                if (casingCementRigUpRunCasing == null)
                {
                    casingCementRigUpRunCasing = new ActivityCode("casing, cement -- rig up, run casing");
                    casingCementRigUpRunCasing.Description = "A specialization of 'casing, cement': rig up and run casing";
                }
                return casingCementRigUpRunCasing;
            }
        }

        private static ActivityCode casingCementRigUpRunLiner;
        /// <summary>
        /// A specialization of 'casing, cement': rig up and run liner
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- rig up, run liner")]
        public static ActivityCode CasingCementRigUpRunLiner
        {
            get 
            {
                if (casingCementRigUpRunLiner == null)
                {
                    casingCementRigUpRunLiner = new ActivityCode("casing, cement -- rig up, run liner");
                    casingCementRigUpRunLiner.Description = "A specialization of 'casing, cement': rig up and run liner";
                }
                return casingCementRigUpRunLiner;
            }
        }

        private static ActivityCode casingCementWaitOnCement;
        /// <summary>
        /// A specialization of 'casing, cement'.
        /// </summary>
        [EnumValueNameAttribute("casing, cement -- wait on cement")]
        public static ActivityCode CasingCementWaitOnCement
        {
            get 
            {
                if (casingCementWaitOnCement == null)
                {
                    casingCementWaitOnCement = new ActivityCode("casing, cement -- wait on cement");
                    casingCementWaitOnCement.Description = "A specialization of 'casing, cement'.";
                }
                return casingCementWaitOnCement;
            }
        }

        private static ActivityCode completionOperations;
        /// <summary>
        /// After reaching total depth, any operations for completing the well and bringing it on production - no further detail is known.
        /// </summary>
        [EnumValueNameAttribute("completion operations")]
        public static ActivityCode CompletionOperations
        {
            get 
            {
                if (completionOperations == null)
                {
                    completionOperations = new ActivityCode("completion operations");
                    completionOperations.Description = "After reaching total depth, any operations for completing the well and bringing it on production - no further detail is known.";
                }
                return completionOperations;
            }
        }

        private static ActivityCode completionOperationsRigUp;
        /// <summary>
        /// Rig up completion equipment.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- rig up")]
        public static ActivityCode CompletionOperationsRigUp
        {
            get 
            {
                if (completionOperationsRigUp == null)
                {
                    completionOperationsRigUp = new ActivityCode("completion operations -- rig up");
                    completionOperationsRigUp.Description = "Rig up completion equipment.";
                }
                return completionOperationsRigUp;
            }
        }

        private static ActivityCode completionOperationsTearDown;
        /// <summary>
        /// Tear down completion equipment.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- tear down")]
        public static ActivityCode CompletionOperationsTearDown
        {
            get 
            {
                if (completionOperationsTearDown == null)
                {
                    completionOperationsTearDown = new ActivityCode("completion operations -- tear down");
                    completionOperationsTearDown.Description = "Tear down completion equipment.";
                }
                return completionOperationsTearDown;
            }
        }

        private static ActivityCode completionOperationsTesting;
        /// <summary>
        /// Pre-production flow testing in the well completion phase.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- testing ")]
        public static ActivityCode CompletionOperationsTesting
        {
            get 
            {
                if (completionOperationsTesting == null)
                {
                    completionOperationsTesting = new ActivityCode("completion operations -- testing ");
                    completionOperationsTesting.Description = "Pre-production flow testing in the well completion phase.";
                }
                return completionOperationsTesting;
            }
        }

        private static ActivityCode completionOperationsRunningLiner;
        /// <summary>
        /// Running the production liner.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- running liner")]
        public static ActivityCode CompletionOperationsRunningLiner
        {
            get 
            {
                if (completionOperationsRunningLiner == null)
                {
                    completionOperationsRunningLiner = new ActivityCode("completion operations -- running liner");
                    completionOperationsRunningLiner.Description = "Running the production liner.";
                }
                return completionOperationsRunningLiner;
            }
        }

        private static ActivityCode completionOperationsGravelPacking;
        /// <summary>
        /// Completion operation for producing zones.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- gravel packing")]
        public static ActivityCode CompletionOperationsGravelPacking
        {
            get 
            {
                if (completionOperationsGravelPacking == null)
                {
                    completionOperationsGravelPacking = new ActivityCode("completion operations -- gravel packing");
                    completionOperationsGravelPacking.Description = "Completion operation for producing zones.";
                }
                return completionOperationsGravelPacking;
            }
        }

        private static ActivityCode completionOperationsLogging;
        /// <summary>
        /// Production logging tool runs.
        /// </summary>
        [EnumValueNameAttribute("completion operations -- logging")]
        public static ActivityCode CompletionOperationsLogging
        {
            get 
            {
                if (completionOperationsLogging == null)
                {
                    completionOperationsLogging = new ActivityCode("completion operations -- logging");
                    completionOperationsLogging.Description = "Production logging tool runs.";
                }
                return completionOperationsLogging;
            }
        }

        private static ActivityCode condMudCirculate;
        /// <summary>
        /// condition mud and circulate
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate")]
        public static ActivityCode CondMudCirculate
        {
            get 
            {
                if (condMudCirculate == null)
                {
                    condMudCirculate = new ActivityCode("cond mud, circulate");
                    condMudCirculate.Description = "condition mud and circulate";
                }
                return condMudCirculate;
            }
        }

        private static ActivityCode condMudCirculateBoulderOrGravel;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- boulder or gravel")]
        public static ActivityCode CondMudCirculateBoulderOrGravel
        {
            get 
            {
                if (condMudCirculateBoulderOrGravel == null)
                {
                    condMudCirculateBoulderOrGravel = new ActivityCode("cond mud, circulate -- boulder or gravel");
                    condMudCirculateBoulderOrGravel.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateBoulderOrGravel;
            }
        }

        private static ActivityCode condMudCirculateCasing;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- casing")]
        public static ActivityCode CondMudCirculateCasing
        {
            get 
            {
                if (condMudCirculateCasing == null)
                {
                    condMudCirculateCasing = new ActivityCode("cond mud, circulate -- casing");
                    condMudCirculateCasing.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateCasing;
            }
        }

        private static ActivityCode condMudCirculateCementing;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- cementing")]
        public static ActivityCode CondMudCirculateCementing
        {
            get 
            {
                if (condMudCirculateCementing == null)
                {
                    condMudCirculateCementing = new ActivityCode("cond mud, circulate -- cementing");
                    condMudCirculateCementing.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateCementing;
            }
        }

        private static ActivityCode condMudCirculateCirculateSamples;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- circulate samples")]
        public static ActivityCode CondMudCirculateCirculateSamples
        {
            get 
            {
                if (condMudCirculateCirculateSamples == null)
                {
                    condMudCirculateCirculateSamples = new ActivityCode("cond mud, circulate -- circulate samples");
                    condMudCirculateCirculateSamples.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateCirculateSamples;
            }
        }

        private static ActivityCode condMudCirculateCoring;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- coring")]
        public static ActivityCode CondMudCirculateCoring
        {
            get 
            {
                if (condMudCirculateCoring == null)
                {
                    condMudCirculateCoring = new ActivityCode("cond mud, circulate -- coring");
                    condMudCirculateCoring.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateCoring;
            }
        }

        private static ActivityCode condMudCirculateDrilling;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- drilling")]
        public static ActivityCode CondMudCirculateDrilling
        {
            get 
            {
                if (condMudCirculateDrilling == null)
                {
                    condMudCirculateDrilling = new ActivityCode("cond mud, circulate -- drilling");
                    condMudCirculateDrilling.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateDrilling;
            }
        }

        private static ActivityCode condMudCirculateFishing;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- fishing")]
        public static ActivityCode CondMudCirculateFishing
        {
            get 
            {
                if (condMudCirculateFishing == null)
                {
                    condMudCirculateFishing = new ActivityCode("cond mud, circulate -- fishing");
                    condMudCirculateFishing.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateFishing;
            }
        }

        private static ActivityCode condMudCirculateGumboAttack;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- gumbo attack")]
        public static ActivityCode CondMudCirculateGumboAttack
        {
            get 
            {
                if (condMudCirculateGumboAttack == null)
                {
                    condMudCirculateGumboAttack = new ActivityCode("cond mud, circulate -- gumbo attack");
                    condMudCirculateGumboAttack.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateGumboAttack;
            }
        }

        private static ActivityCode condMudCirculateLogging;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- logging")]
        public static ActivityCode CondMudCirculateLogging
        {
            get 
            {
                if (condMudCirculateLogging == null)
                {
                    condMudCirculateLogging = new ActivityCode("cond mud, circulate -- logging");
                    condMudCirculateLogging.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateLogging;
            }
        }

        private static ActivityCode condMudCirculateLostCirculation;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- lost circulation")]
        public static ActivityCode CondMudCirculateLostCirculation
        {
            get 
            {
                if (condMudCirculateLostCirculation == null)
                {
                    condMudCirculateLostCirculation = new ActivityCode("cond mud, circulate -- lost circulation");
                    condMudCirculateLostCirculation.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateLostCirculation;
            }
        }

        private static ActivityCode condMudCirculateWellControl;
        /// <summary>
        /// A specialization of 'cond mud, circulate'.
        /// </summary>
        [EnumValueNameAttribute("cond mud, circulate -- well control")]
        public static ActivityCode CondMudCirculateWellControl
        {
            get 
            {
                if (condMudCirculateWellControl == null)
                {
                    condMudCirculateWellControl = new ActivityCode("cond mud, circulate -- well control");
                    condMudCirculateWellControl.Description = "A specialization of 'cond mud, circulate'.";
                }
                return condMudCirculateWellControl;
            }
        }

        private static ActivityCode coring;
        /// <summary>
        /// coring
        /// </summary>
        [EnumValueNameAttribute("coring")]
        public static ActivityCode Coring
        {
            get 
            {
                if (coring == null)
                {
                    coring = new ActivityCode("coring");
                    coring.Description = "coring";
                }
                return coring;
            }
        }

        private static ActivityCode coringConventional;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- conventional")]
        public static ActivityCode CoringConventional
        {
            get 
            {
                if (coringConventional == null)
                {
                    coringConventional = new ActivityCode("coring -- conventional");
                    coringConventional.Description = "A specialization of 'coring'.";
                }
                return coringConventional;
            }
        }

        private static ActivityCode coringFlowCheck;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- flow check")]
        public static ActivityCode CoringFlowCheck
        {
            get 
            {
                if (coringFlowCheck == null)
                {
                    coringFlowCheck = new ActivityCode("coring -- flow check");
                    coringFlowCheck.Description = "A specialization of 'coring'.";
                }
                return coringFlowCheck;
            }
        }

        private static ActivityCode coringLaydownBarrel;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- laydown barrel")]
        public static ActivityCode CoringLaydownBarrel
        {
            get 
            {
                if (coringLaydownBarrel == null)
                {
                    coringLaydownBarrel = new ActivityCode("coring -- laydown barrel");
                    coringLaydownBarrel.Description = "A specialization of 'coring'.";
                }
                return coringLaydownBarrel;
            }
        }

        private static ActivityCode coringOriented;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- oriented")]
        public static ActivityCode CoringOriented
        {
            get 
            {
                if (coringOriented == null)
                {
                    coringOriented = new ActivityCode("coring -- oriented");
                    coringOriented.Description = "A specialization of 'coring'.";
                }
                return coringOriented;
            }
        }

        private static ActivityCode coringPlasticSleeve;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- plastic sleeve")]
        public static ActivityCode CoringPlasticSleeve
        {
            get 
            {
                if (coringPlasticSleeve == null)
                {
                    coringPlasticSleeve = new ActivityCode("coring -- plastic sleeve");
                    coringPlasticSleeve.Description = "A specialization of 'coring'.";
                }
                return coringPlasticSleeve;
            }
        }

        private static ActivityCode coringRigUpCoreBarrel;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- rig up core barrel")]
        public static ActivityCode CoringRigUpCoreBarrel
        {
            get 
            {
                if (coringRigUpCoreBarrel == null)
                {
                    coringRigUpCoreBarrel = new ActivityCode("coring -- rig up core barrel");
                    coringRigUpCoreBarrel.Description = "A specialization of 'coring'.";
                }
                return coringRigUpCoreBarrel;
            }
        }

        private static ActivityCode coringSponge;
        /// <summary>
        /// A specialization of 'coring'.
        /// </summary>
        [EnumValueNameAttribute("coring -- sponge")]
        public static ActivityCode CoringSponge
        {
            get 
            {
                if (coringSponge == null)
                {
                    coringSponge = new ActivityCode("coring -- sponge");
                    coringSponge.Description = "A specialization of 'coring'.";
                }
                return coringSponge;
            }
        }

        private static ActivityCode cutSlipDrillingLine;
        /// <summary>
        /// cut and slip drilling line
        /// </summary>
        [EnumValueNameAttribute("cut, slip drilling line")]
        public static ActivityCode CutSlipDrillingLine
        {
            get 
            {
                if (cutSlipDrillingLine == null)
                {
                    cutSlipDrillingLine = new ActivityCode("cut, slip drilling line");
                    cutSlipDrillingLine.Description = "cut and slip drilling line";
                }
                return cutSlipDrillingLine;
            }
        }

        private static ActivityCode deviationSurvey;
        /// <summary>
        /// deviation survey
        /// </summary>
        [EnumValueNameAttribute("deviation survey")]
        public static ActivityCode DeviationSurvey
        {
            get 
            {
                if (deviationSurvey == null)
                {
                    deviationSurvey = new ActivityCode("deviation survey");
                    deviationSurvey.Description = "deviation survey";
                }
                return deviationSurvey;
            }
        }

        private static ActivityCode deviationSurveyDirMultishot;
        /// <summary>
        /// A specialization of 'deviation survey': directional multi-shot
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- dir multi-shot")]
        public static ActivityCode DeviationSurveyDirMultishot
        {
            get 
            {
                if (deviationSurveyDirMultishot == null)
                {
                    deviationSurveyDirMultishot = new ActivityCode("deviation survey -- dir multi-shot");
                    deviationSurveyDirMultishot.Description = "A specialization of 'deviation survey': directional multi-shot";
                }
                return deviationSurveyDirMultishot;
            }
        }

        private static ActivityCode deviationSurveyDirSingleShot;
        /// <summary>
        /// A specialization of 'deviation survey': directional single shot
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- dir single shot")]
        public static ActivityCode DeviationSurveyDirSingleShot
        {
            get 
            {
                if (deviationSurveyDirSingleShot == null)
                {
                    deviationSurveyDirSingleShot = new ActivityCode("deviation survey -- dir single shot");
                    deviationSurveyDirSingleShot.Description = "A specialization of 'deviation survey': directional single shot";
                }
                return deviationSurveyDirSingleShot;
            }
        }

        private static ActivityCode deviationSurveyDrift;
        /// <summary>
        /// A specialization of 'deviation survey'.
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- drift")]
        public static ActivityCode DeviationSurveyDrift
        {
            get 
            {
                if (deviationSurveyDrift == null)
                {
                    deviationSurveyDrift = new ActivityCode("deviation survey -- drift");
                    deviationSurveyDrift.Description = "A specialization of 'deviation survey'.";
                }
                return deviationSurveyDrift;
            }
        }

        private static ActivityCode deviationSurveyGyro;
        /// <summary>
        /// A specialization of 'deviation survey'.
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- gyro")]
        public static ActivityCode DeviationSurveyGyro
        {
            get 
            {
                if (deviationSurveyGyro == null)
                {
                    deviationSurveyGyro = new ActivityCode("deviation survey -- gyro");
                    deviationSurveyGyro.Description = "A specialization of 'deviation survey'.";
                }
                return deviationSurveyGyro;
            }
        }

        private static ActivityCode deviationSurveyMwd;
        /// <summary>
        /// A specialization of 'deviation survey'.
        /// </summary>
        [EnumValueNameAttribute("deviation survey -- MWD")]
        public static ActivityCode DeviationSurveyMwd
        {
            get 
            {
                if (deviationSurveyMwd == null)
                {
                    deviationSurveyMwd = new ActivityCode("deviation survey -- MWD");
                    deviationSurveyMwd.Description = "A specialization of 'deviation survey'.";
                }
                return deviationSurveyMwd;
            }
        }

        private static ActivityCode dirWork;
        /// <summary>
        /// directional work
        /// </summary>
        [EnumValueNameAttribute("dir work")]
        public static ActivityCode DirWork
        {
            get 
            {
                if (dirWork == null)
                {
                    dirWork = new ActivityCode("dir work");
                    dirWork.Description = "directional work";
                }
                return dirWork;
            }
        }

        private static ActivityCode dirWorkHorizontalDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- horizontal drilling")]
        public static ActivityCode DirWorkHorizontalDrilling
        {
            get 
            {
                if (dirWorkHorizontalDrilling == null)
                {
                    dirWorkHorizontalDrilling = new ActivityCode("dir work -- horizontal drilling");
                    dirWorkHorizontalDrilling.Description = "A specialization of 'dir work'.";
                }
                return dirWorkHorizontalDrilling;
            }
        }

        private static ActivityCode dirWorkMotorDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- motor drilling")]
        public static ActivityCode DirWorkMotorDrilling
        {
            get 
            {
                if (dirWorkMotorDrilling == null)
                {
                    dirWorkMotorDrilling = new ActivityCode("dir work -- motor drilling");
                    dirWorkMotorDrilling.Description = "A specialization of 'dir work'.";
                }
                return dirWorkMotorDrilling;
            }
        }

        private static ActivityCode dirWorkOrient;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- orient")]
        public static ActivityCode DirWorkOrient
        {
            get 
            {
                if (dirWorkOrient == null)
                {
                    dirWorkOrient = new ActivityCode("dir work -- orient");
                    dirWorkOrient.Description = "A specialization of 'dir work'.";
                }
                return dirWorkOrient;
            }
        }

        private static ActivityCode dirWorkRotaryDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- rotary drilling")]
        public static ActivityCode DirWorkRotaryDrilling
        {
            get 
            {
                if (dirWorkRotaryDrilling == null)
                {
                    dirWorkRotaryDrilling = new ActivityCode("dir work -- rotary drilling");
                    dirWorkRotaryDrilling.Description = "A specialization of 'dir work'.";
                }
                return dirWorkRotaryDrilling;
            }
        }

        private static ActivityCode dirWorkSlantDrilling;
        /// <summary>
        /// A specialization of 'dir work'.
        /// </summary>
        [EnumValueNameAttribute("dir work -- slant drilling")]
        public static ActivityCode DirWorkSlantDrilling
        {
            get 
            {
                if (dirWorkSlantDrilling == null)
                {
                    dirWorkSlantDrilling = new ActivityCode("dir work -- slant drilling");
                    dirWorkSlantDrilling.Description = "A specialization of 'dir work'.";
                }
                return dirWorkSlantDrilling;
            }
        }

        private static ActivityCode dst;
        /// <summary>
        /// drill stem test
        /// </summary>
        [EnumValueNameAttribute("DST")]
        public static ActivityCode Dst
        {
            get 
            {
                if (dst == null)
                {
                    dst = new ActivityCode("DST");
                    dst.Description = "drill stem test";
                }
                return dst;
            }
        }

        private static ActivityCode dstCasedHole;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- cased hole")]
        public static ActivityCode DstCasedHole
        {
            get 
            {
                if (dstCasedHole == null)
                {
                    dstCasedHole = new ActivityCode("DST -- cased hole");
                    dstCasedHole.Description = "A specialization of 'DST'.";
                }
                return dstCasedHole;
            }
        }

        private static ActivityCode dstLayDownTools;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- lay down tools")]
        public static ActivityCode DstLayDownTools
        {
            get 
            {
                if (dstLayDownTools == null)
                {
                    dstLayDownTools = new ActivityCode("DST -- lay down tools");
                    dstLayDownTools.Description = "A specialization of 'DST'.";
                }
                return dstLayDownTools;
            }
        }

        private static ActivityCode dstOpenHole;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- open hole")]
        public static ActivityCode DstOpenHole
        {
            get 
            {
                if (dstOpenHole == null)
                {
                    dstOpenHole = new ActivityCode("DST -- open hole");
                    dstOpenHole.Description = "A specialization of 'DST'.";
                }
                return dstOpenHole;
            }
        }

        private static ActivityCode dstOpenHoleClosedChamber;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- open hole closed chamber")]
        public static ActivityCode DstOpenHoleClosedChamber
        {
            get 
            {
                if (dstOpenHoleClosedChamber == null)
                {
                    dstOpenHoleClosedChamber = new ActivityCode("DST -- open hole closed chamber");
                    dstOpenHoleClosedChamber.Description = "A specialization of 'DST'.";
                }
                return dstOpenHoleClosedChamber;
            }
        }

        private static ActivityCode dstRigUpTools;
        /// <summary>
        /// A specialization of 'DST'.
        /// </summary>
        [EnumValueNameAttribute("DST -- rig up tools")]
        public static ActivityCode DstRigUpTools
        {
            get 
            {
                if (dstRigUpTools == null)
                {
                    dstRigUpTools = new ActivityCode("DST -- rig up tools");
                    dstRigUpTools.Description = "A specialization of 'DST'.";
                }
                return dstRigUpTools;
            }
        }

        private static ActivityCode drilling;
        /// <summary>
        /// drilling
        /// </summary>
        [EnumValueNameAttribute("drilling")]
        public static ActivityCode Drilling
        {
            get 
            {
                if (drilling == null)
                {
                    drilling = new ActivityCode("drilling");
                    drilling.Description = "drilling";
                }
                return drilling;
            }
        }

        private static ActivityCode drillingCasing;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- casing")]
        public static ActivityCode DrillingCasing
        {
            get 
            {
                if (drillingCasing == null)
                {
                    drillingCasing = new ActivityCode("drilling -- casing");
                    drillingCasing.Description = "A specialization of 'drilling'.";
                }
                return drillingCasing;
            }
        }

        private static ActivityCode drillingConnection;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- connection")]
        public static ActivityCode DrillingConnection
        {
            get 
            {
                if (drillingConnection == null)
                {
                    drillingConnection = new ActivityCode("drilling -- connection");
                    drillingConnection.Description = "A specialization of 'drilling'.";
                }
                return drillingConnection;
            }
        }

        private static ActivityCode drillingDrillCementFloatEquip;
        /// <summary>
        /// A specialization of 'drilling': drill out cement and/or float equipment
        /// </summary>
        [EnumValueNameAttribute("drilling -- drill cement, float equip")]
        public static ActivityCode DrillingDrillCementFloatEquip
        {
            get 
            {
                if (drillingDrillCementFloatEquip == null)
                {
                    drillingDrillCementFloatEquip = new ActivityCode("drilling -- drill cement, float equip");
                    drillingDrillCementFloatEquip.Description = "A specialization of 'drilling': drill out cement and/or float equipment";
                }
                return drillingDrillCementFloatEquip;
            }
        }

        private static ActivityCode drillingFlowCheck;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- flow check")]
        public static ActivityCode DrillingFlowCheck
        {
            get 
            {
                if (drillingFlowCheck == null)
                {
                    drillingFlowCheck = new ActivityCode("drilling -- flow check");
                    drillingFlowCheck.Description = "A specialization of 'drilling'.";
                }
                return drillingFlowCheck;
            }
        }

        private static ActivityCode drillingHoleOpening;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- hole opening")]
        public static ActivityCode DrillingHoleOpening
        {
            get 
            {
                if (drillingHoleOpening == null)
                {
                    drillingHoleOpening = new ActivityCode("drilling -- hole opening");
                    drillingHoleOpening.Description = "A specialization of 'drilling'.";
                }
                return drillingHoleOpening;
            }
        }

        private static ActivityCode drillingNewHole;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- new hole")]
        public static ActivityCode DrillingNewHole
        {
            get 
            {
                if (drillingNewHole == null)
                {
                    drillingNewHole = new ActivityCode("drilling -- new hole");
                    drillingNewHole.Description = "A specialization of 'drilling'.";
                }
                return drillingNewHole;
            }
        }

        private static ActivityCode drillingSidetracking;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- sidetracking")]
        public static ActivityCode DrillingSidetracking
        {
            get 
            {
                if (drillingSidetracking == null)
                {
                    drillingSidetracking = new ActivityCode("drilling -- sidetracking");
                    drillingSidetracking.Description = "A specialization of 'drilling'.";
                }
                return drillingSidetracking;
            }
        }

        private static ActivityCode drillingUnderreaming;
        /// <summary>
        /// A specialization of 'drilling'.
        /// </summary>
        [EnumValueNameAttribute("drilling -- under-reaming")]
        public static ActivityCode DrillingUnderreaming
        {
            get 
            {
                if (drillingUnderreaming == null)
                {
                    drillingUnderreaming = new ActivityCode("drilling -- under-reaming");
                    drillingUnderreaming.Description = "A specialization of 'drilling'.";
                }
                return drillingUnderreaming;
            }
        }

        private static ActivityCode fishing;
        /// <summary>
        /// fishing
        /// </summary>
        [EnumValueNameAttribute("fishing")]
        public static ActivityCode Fishing
        {
            get 
            {
                if (fishing == null)
                {
                    fishing = new ActivityCode("fishing");
                    fishing.Description = "fishing";
                }
                return fishing;
            }
        }

        private static ActivityCode fishingBha;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- BHA")]
        public static ActivityCode FishingBha
        {
            get 
            {
                if (fishingBha == null)
                {
                    fishingBha = new ActivityCode("fishing -- BHA");
                    fishingBha.Description = "A specialization of 'fishing'.";
                }
                return fishingBha;
            }
        }

        private static ActivityCode fishingCasing;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- casing")]
        public static ActivityCode FishingCasing
        {
            get 
            {
                if (fishingCasing == null)
                {
                    fishingCasing = new ActivityCode("fishing -- casing");
                    fishingCasing.Description = "A specialization of 'fishing'.";
                }
                return fishingCasing;
            }
        }

        private static ActivityCode fishingCones;
        /// <summary>
        /// >A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- cones")]
        public static ActivityCode FishingCones
        {
            get 
            {
                if (fishingCones == null)
                {
                    fishingCones = new ActivityCode("fishing -- cones");
                    fishingCones.Description = ">A specialization of 'fishing'.";
                }
                return fishingCones;
            }
        }

        private static ActivityCode fishingOther;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- other")]
        public static ActivityCode FishingOther
        {
            get 
            {
                if (fishingOther == null)
                {
                    fishingOther = new ActivityCode("fishing -- other");
                    fishingOther.Description = "A specialization of 'fishing'.";
                }
                return fishingOther;
            }
        }

        private static ActivityCode fishingStuckPipe;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- stuck pipe")]
        public static ActivityCode FishingStuckPipe
        {
            get 
            {
                if (fishingStuckPipe == null)
                {
                    fishingStuckPipe = new ActivityCode("fishing -- stuck pipe");
                    fishingStuckPipe.Description = "A specialization of 'fishing'.";
                }
                return fishingStuckPipe;
            }
        }

        private static ActivityCode fishingWirelineTools;
        /// <summary>
        /// A specialization of 'fishing'.
        /// </summary>
        [EnumValueNameAttribute("fishing -- wireline tools")]
        public static ActivityCode FishingWirelineTools
        {
            get 
            {
                if (fishingWirelineTools == null)
                {
                    fishingWirelineTools = new ActivityCode("fishing -- wireline tools");
                    fishingWirelineTools.Description = "A specialization of 'fishing'.";
                }
                return fishingWirelineTools;
            }
        }

        private static ActivityCode hse;
        /// <summary>
        /// Health, Safety and Environmental
        /// </summary>
        [EnumValueNameAttribute("HSE")]
        public static ActivityCode Hse
        {
            get 
            {
                if (hse == null)
                {
                    hse = new ActivityCode("HSE");
                    hse.Description = "Health, Safety and Environmental";
                }
                return hse;
            }
        }

        private static ActivityCode hseHoldDrill;
        /// <summary>
        /// A specialization of 'HSE'.
        /// </summary>
        [EnumValueNameAttribute("HSE -- hold drill")]
        public static ActivityCode HseHoldDrill
        {
            get 
            {
                if (hseHoldDrill == null)
                {
                    hseHoldDrill = new ActivityCode("HSE -- hold drill");
                    hseHoldDrill.Description = "A specialization of 'HSE'.";
                }
                return hseHoldDrill;
            }
        }

        private static ActivityCode hseIncident;
        /// <summary>
        /// A specialization of 'HSE'.
        /// </summary>
        [EnumValueNameAttribute("HSE -- incident")]
        public static ActivityCode HseIncident
        {
            get 
            {
                if (hseIncident == null)
                {
                    hseIncident = new ActivityCode("HSE -- incident");
                    hseIncident.Description = "A specialization of 'HSE'.";
                }
                return hseIncident;
            }
        }

        private static ActivityCode hseSafetyMeeting;
        /// <summary>
        /// A specialization of 'HSE'.
        /// </summary>
        [EnumValueNameAttribute("HSE -- safety meeting")]
        public static ActivityCode HseSafetyMeeting
        {
            get 
            {
                if (hseSafetyMeeting == null)
                {
                    hseSafetyMeeting = new ActivityCode("HSE -- safety meeting");
                    hseSafetyMeeting.Description = "A specialization of 'HSE'.";
                }
                return hseSafetyMeeting;
            }
        }

        private static ActivityCode mill;
        /// <summary>
        /// mill
        /// </summary>
        [EnumValueNameAttribute("mill")]
        public static ActivityCode Mill
        {
            get 
            {
                if (mill == null)
                {
                    mill = new ActivityCode("mill");
                    mill.Description = "mill";
                }
                return mill;
            }
        }

        private static ActivityCode millCutCasingOrTubing;
        /// <summary>
        /// A specialization of 'mill'.
        /// </summary>
        [EnumValueNameAttribute("mill -- cut casing or tubing")]
        public static ActivityCode MillCutCasingOrTubing
        {
            get 
            {
                if (millCutCasingOrTubing == null)
                {
                    millCutCasingOrTubing = new ActivityCode("mill -- cut casing or tubing");
                    millCutCasingOrTubing.Description = "A specialization of 'mill'.";
                }
                return millCutCasingOrTubing;
            }
        }

        private static ActivityCode millMilling;
        /// <summary>
        /// A specialization of 'mill'.
        /// </summary>
        [EnumValueNameAttribute("mill -- milling")]
        public static ActivityCode MillMilling
        {
            get 
            {
                if (millMilling == null)
                {
                    millMilling = new ActivityCode("mill -- milling");
                    millMilling.Description = "A specialization of 'mill'.";
                }
                return millMilling;
            }
        }

        private static ActivityCode miscellaneous;
        /// <summary>
        /// miscellaneous
        /// </summary>
        [EnumValueNameAttribute("miscellaneous")]
        public static ActivityCode Miscellaneous
        {
            get 
            {
                if (miscellaneous == null)
                {
                    miscellaneous = new ActivityCode("miscellaneous");
                    miscellaneous.Description = "miscellaneous";
                }
                return miscellaneous;
            }
        }

        private static ActivityCode nippleUpBop;
        /// <summary>
        /// nipple up blowout preventer
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP")]
        public static ActivityCode NippleUpBop
        {
            get 
            {
                if (nippleUpBop == null)
                {
                    nippleUpBop = new ActivityCode("nipple up BOP");
                    nippleUpBop.Description = "nipple up blowout preventer";
                }
                return nippleUpBop;
            }
        }

        private static ActivityCode nippleUpBopDiverter;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- diverter")]
        public static ActivityCode NippleUpBopDiverter
        {
            get 
            {
                if (nippleUpBopDiverter == null)
                {
                    nippleUpBopDiverter = new ActivityCode("nipple up BOP -- diverter");
                    nippleUpBopDiverter.Description = "A specialization of 'nipple up BOP'.";
                }
                return nippleUpBopDiverter;
            }
        }

        private static ActivityCode nippleUpBopManifold;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- manifold")]
        public static ActivityCode NippleUpBopManifold
        {
            get 
            {
                if (nippleUpBopManifold == null)
                {
                    nippleUpBopManifold = new ActivityCode("nipple up BOP -- manifold");
                    nippleUpBopManifold.Description = "A specialization of 'nipple up BOP'.";
                }
                return nippleUpBopManifold;
            }
        }

        private static ActivityCode nippleUpBopOther;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- other")]
        public static ActivityCode NippleUpBopOther
        {
            get 
            {
                if (nippleUpBopOther == null)
                {
                    nippleUpBopOther = new ActivityCode("nipple up BOP -- other");
                    nippleUpBopOther.Description = "A specialization of 'nipple up BOP'.";
                }
                return nippleUpBopOther;
            }
        }

        private static ActivityCode nippleUpBopPvtSystem;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- PVT system")]
        public static ActivityCode NippleUpBopPvtSystem
        {
            get 
            {
                if (nippleUpBopPvtSystem == null)
                {
                    nippleUpBopPvtSystem = new ActivityCode("nipple up BOP -- PVT system");
                    nippleUpBopPvtSystem.Description = "A specialization of 'nipple up BOP'.";
                }
                return nippleUpBopPvtSystem;
            }
        }

        private static ActivityCode nippleUpBopStack;
        /// <summary>
        /// A specialization of 'nipple up BOP'.
        /// </summary>
        [EnumValueNameAttribute("nipple up BOP -- stack")]
        public static ActivityCode NippleUpBopStack
        {
            get 
            {
                if (nippleUpBopStack == null)
                {
                    nippleUpBopStack = new ActivityCode("nipple up BOP -- stack");
                    nippleUpBopStack.Description = "A specialization of 'nipple up BOP'.";
                }
                return nippleUpBopStack;
            }
        }

        private static ActivityCode plugBack;
        /// <summary>
        /// plug back
        /// </summary>
        [EnumValueNameAttribute("plug back")]
        public static ActivityCode PlugBack
        {
            get 
            {
                if (plugBack == null)
                {
                    plugBack = new ActivityCode("plug back");
                    plugBack.Description = "plug back";
                }
                return plugBack;
            }
        }

        private static ActivityCode plugBackAbandonment;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- abandonment")]
        public static ActivityCode PlugBackAbandonment
        {
            get 
            {
                if (plugBackAbandonment == null)
                {
                    plugBackAbandonment = new ActivityCode("plug back -- abandonment");
                    plugBackAbandonment.Description = "A specialization of 'plug back'.";
                }
                return plugBackAbandonment;
            }
        }

        private static ActivityCode plugBackKickOffPlug;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- kick off plug")]
        public static ActivityCode PlugBackKickOffPlug
        {
            get 
            {
                if (plugBackKickOffPlug == null)
                {
                    plugBackKickOffPlug = new ActivityCode("plug back -- kick off plug");
                    plugBackKickOffPlug.Description = "A specialization of 'plug back'.";
                }
                return plugBackKickOffPlug;
            }
        }

        private static ActivityCode plugBackLostCirculation;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- lost circulation")]
        public static ActivityCode PlugBackLostCirculation
        {
            get 
            {
                if (plugBackLostCirculation == null)
                {
                    plugBackLostCirculation = new ActivityCode("plug back -- lost circulation");
                    plugBackLostCirculation.Description = "A specialization of 'plug back'.";
                }
                return plugBackLostCirculation;
            }
        }

        private static ActivityCode plugBackWaitOnCement;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- wait on cement")]
        public static ActivityCode PlugBackWaitOnCement
        {
            get 
            {
                if (plugBackWaitOnCement == null)
                {
                    plugBackWaitOnCement = new ActivityCode("plug back -- wait on cement");
                    plugBackWaitOnCement.Description = "A specialization of 'plug back'.";
                }
                return plugBackWaitOnCement;
            }
        }

        private static ActivityCode plugBackWellControl;
        /// <summary>
        /// A specialization of 'plug back'.
        /// </summary>
        [EnumValueNameAttribute("plug back -- well control")]
        public static ActivityCode PlugBackWellControl
        {
            get 
            {
                if (plugBackWellControl == null)
                {
                    plugBackWellControl = new ActivityCode("plug back -- well control");
                    plugBackWellControl.Description = "A specialization of 'plug back'.";
                }
                return plugBackWellControl;
            }
        }

        private static ActivityCode pressureTest;
        /// <summary>
        /// pressure test
        /// </summary>
        [EnumValueNameAttribute("pressure test")]
        public static ActivityCode PressureTest
        {
            get 
            {
                if (pressureTest == null)
                {
                    pressureTest = new ActivityCode("pressure test");
                    pressureTest.Description = "pressure test";
                }
                return pressureTest;
            }
        }

        private static ActivityCode pressureTestBopManifold;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- BOP manifold")]
        public static ActivityCode PressureTestBopManifold
        {
            get 
            {
                if (pressureTestBopManifold == null)
                {
                    pressureTestBopManifold = new ActivityCode("pressure test -- BOP manifold");
                    pressureTestBopManifold.Description = "A specialization of 'pressure test'.";
                }
                return pressureTestBopManifold;
            }
        }

        private static ActivityCode pressureTestBopStack;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- BOP stack")]
        public static ActivityCode PressureTestBopStack
        {
            get 
            {
                if (pressureTestBopStack == null)
                {
                    pressureTestBopStack = new ActivityCode("pressure test -- BOP stack");
                    pressureTestBopStack.Description = "A specialization of 'pressure test'.";
                }
                return pressureTestBopStack;
            }
        }

        private static ActivityCode pressureTestFormIntegrityTest;
        /// <summary>
        /// A specialization of 'pressure test': formation integrity test
        /// </summary>
        [EnumValueNameAttribute("pressure test -- form integrity test")]
        public static ActivityCode PressureTestFormIntegrityTest
        {
            get 
            {
                if (pressureTestFormIntegrityTest == null)
                {
                    pressureTestFormIntegrityTest = new ActivityCode("pressure test -- form integrity test");
                    pressureTestFormIntegrityTest.Description = "A specialization of 'pressure test': formation integrity test";
                }
                return pressureTestFormIntegrityTest;
            }
        }

        private static ActivityCode pressureTestFormLeakOffTest;
        /// <summary>
        /// A specialization of 'pressure test': formation leak off test
        /// </summary>
        [EnumValueNameAttribute("pressure test -- form leak off test")]
        public static ActivityCode PressureTestFormLeakOffTest
        {
            get 
            {
                if (pressureTestFormLeakOffTest == null)
                {
                    pressureTestFormLeakOffTest = new ActivityCode("pressure test -- form leak off test");
                    pressureTestFormLeakOffTest.Description = "A specialization of 'pressure test': formation leak off test";
                }
                return pressureTestFormLeakOffTest;
            }
        }

        private static ActivityCode pressureTestPacker;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- packer")]
        public static ActivityCode PressureTestPacker
        {
            get 
            {
                if (pressureTestPacker == null)
                {
                    pressureTestPacker = new ActivityCode("pressure test -- packer");
                    pressureTestPacker.Description = "A specialization of 'pressure test'.";
                }
                return pressureTestPacker;
            }
        }

        private static ActivityCode pressureTestPit;
        /// <summary>
        /// A specialization of 'pressure test'.
        /// </summary>
        [EnumValueNameAttribute("pressure test -- PIT")]
        public static ActivityCode PressureTestPit
        {
            get 
            {
                if (pressureTestPit == null)
                {
                    pressureTestPit = new ActivityCode("pressure test -- PIT");
                    pressureTestPit.Description = "A specialization of 'pressure test'.";
                }
                return pressureTestPit;
            }
        }

        private static ActivityCode reaming;
        /// <summary>
        /// reaming
        /// </summary>
        [EnumValueNameAttribute("reaming")]
        public static ActivityCode Reaming
        {
            get 
            {
                if (reaming == null)
                {
                    reaming = new ActivityCode("reaming");
                    reaming.Description = "reaming";
                }
                return reaming;
            }
        }

        private static ActivityCode reamingBackReaming;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- back reaming")]
        public static ActivityCode ReamingBackReaming
        {
            get 
            {
                if (reamingBackReaming == null)
                {
                    reamingBackReaming = new ActivityCode("reaming -- back reaming");
                    reamingBackReaming.Description = "A specialization of 'reaming'.";
                }
                return reamingBackReaming;
            }
        }

        private static ActivityCode reamingCoring;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- coring")]
        public static ActivityCode ReamingCoring
        {
            get 
            {
                if (reamingCoring == null)
                {
                    reamingCoring = new ActivityCode("reaming -- coring");
                    reamingCoring.Description = "A specialization of 'reaming'.";
                }
                return reamingCoring;
            }
        }

        private static ActivityCode reamingDrill;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- drill")]
        public static ActivityCode ReamingDrill
        {
            get 
            {
                if (reamingDrill == null)
                {
                    reamingDrill = new ActivityCode("reaming -- drill");
                    reamingDrill.Description = "A specialization of 'reaming'.";
                }
                return reamingDrill;
            }
        }

        private static ActivityCode reamingLogging;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- logging")]
        public static ActivityCode ReamingLogging
        {
            get 
            {
                if (reamingLogging == null)
                {
                    reamingLogging = new ActivityCode("reaming -- logging");
                    reamingLogging.Description = "A specialization of 'reaming'.";
                }
                return reamingLogging;
            }
        }

        private static ActivityCode reamingUnderreaming;
        /// <summary>
        /// A specialization of 'reaming'.
        /// </summary>
        [EnumValueNameAttribute("reaming -- under-reaming")]
        public static ActivityCode ReamingUnderreaming
        {
            get 
            {
                if (reamingUnderreaming == null)
                {
                    reamingUnderreaming = new ActivityCode("reaming -- under-reaming");
                    reamingUnderreaming.Description = "A specialization of 'reaming'.";
                }
                return reamingUnderreaming;
            }
        }

        private static ActivityCode rigMove;
        /// <summary>
        /// rig move
        /// </summary>
        [EnumValueNameAttribute("rig move")]
        public static ActivityCode RigMove
        {
            get 
            {
                if (rigMove == null)
                {
                    rigMove = new ActivityCode("rig move");
                    rigMove.Description = "rig move";
                }
                return rigMove;
            }
        }

        private static ActivityCode rigMoveAnchorHandling;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- anchor handling")]
        public static ActivityCode RigMoveAnchorHandling
        {
            get 
            {
                if (rigMoveAnchorHandling == null)
                {
                    rigMoveAnchorHandling = new ActivityCode("rig move -- anchor handling");
                    rigMoveAnchorHandling.Description = "A specialization of 'rig move'.";
                }
                return rigMoveAnchorHandling;
            }
        }

        private static ActivityCode rigMoveInterpadMove;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- inter-pad move")]
        public static ActivityCode RigMoveInterpadMove
        {
            get 
            {
                if (rigMoveInterpadMove == null)
                {
                    rigMoveInterpadMove = new ActivityCode("rig move -- inter-pad move");
                    rigMoveInterpadMove.Description = "A specialization of 'rig move'.";
                }
                return rigMoveInterpadMove;
            }
        }

        private static ActivityCode rigMoveInterwellMove;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- inter-well move")]
        public static ActivityCode RigMoveInterwellMove
        {
            get 
            {
                if (rigMoveInterwellMove == null)
                {
                    rigMoveInterwellMove = new ActivityCode("rig move -- inter-well move");
                    rigMoveInterwellMove.Description = "A specialization of 'rig move'.";
                }
                return rigMoveInterwellMove;
            }
        }

        private static ActivityCode rigMoveJackUpOrDown;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- jack up or down")]
        public static ActivityCode RigMoveJackUpOrDown
        {
            get 
            {
                if (rigMoveJackUpOrDown == null)
                {
                    rigMoveJackUpOrDown = new ActivityCode("rig move -- jack up or down");
                    rigMoveJackUpOrDown.Description = "A specialization of 'rig move'.";
                }
                return rigMoveJackUpOrDown;
            }
        }

        private static ActivityCode rigMoveOther;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- other")]
        public static ActivityCode RigMoveOther
        {
            get 
            {
                if (rigMoveOther == null)
                {
                    rigMoveOther = new ActivityCode("rig move -- other");
                    rigMoveOther.Description = "A specialization of 'rig move'.";
                }
                return rigMoveOther;
            }
        }

        private static ActivityCode rigMovePositionRig;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- position rig")]
        public static ActivityCode RigMovePositionRig
        {
            get 
            {
                if (rigMovePositionRig == null)
                {
                    rigMovePositionRig = new ActivityCode("rig move -- position rig");
                    rigMovePositionRig.Description = "A specialization of 'rig move'.";
                }
                return rigMovePositionRig;
            }
        }

        private static ActivityCode rigMoveSkidRig;
        /// <summary>
        /// A specialization of 'rig move'.
        /// </summary>
        [EnumValueNameAttribute("rig move -- skid rig")]
        public static ActivityCode RigMoveSkidRig
        {
            get 
            {
                if (rigMoveSkidRig == null)
                {
                    rigMoveSkidRig = new ActivityCode("rig move -- skid rig");
                    rigMoveSkidRig.Description = "A specialization of 'rig move'.";
                }
                return rigMoveSkidRig;
            }
        }

        private static ActivityCode rigRelease;
        /// <summary>
        /// rig release
        /// </summary>
        [EnumValueNameAttribute("rig release")]
        public static ActivityCode RigRelease
        {
            get 
            {
                if (rigRelease == null)
                {
                    rigRelease = new ActivityCode("rig release");
                    rigRelease.Description = "rig release";
                }
                return rigRelease;
            }
        }

        private static ActivityCode rigReleaseCutCasing;
        /// <summary>
        /// A specialization of 'rig release'.
        /// </summary>
        [EnumValueNameAttribute("rig release -- cut casing")]
        public static ActivityCode RigReleaseCutCasing
        {
            get 
            {
                if (rigReleaseCutCasing == null)
                {
                    rigReleaseCutCasing = new ActivityCode("rig release -- cut casing");
                    rigReleaseCutCasing.Description = "A specialization of 'rig release'.";
                }
                return rigReleaseCutCasing;
            }
        }

        private static ActivityCode rigReleaseInstallCappingAssembly;
        /// <summary>
        /// A specialization of 'rig release'.
        /// </summary>
        [EnumValueNameAttribute("rig release -- install capping assembly")]
        public static ActivityCode RigReleaseInstallCappingAssembly
        {
            get 
            {
                if (rigReleaseInstallCappingAssembly == null)
                {
                    rigReleaseInstallCappingAssembly = new ActivityCode("rig release -- install capping assembly");
                    rigReleaseInstallCappingAssembly.Description = "A specialization of 'rig release'.";
                }
                return rigReleaseInstallCappingAssembly;
            }
        }

        private static ActivityCode rigReleaseMobOrDemob;
        /// <summary>
        /// A specialization of 'rig release'.
        /// </summary>
        [EnumValueNameAttribute("rig release -- MOB or DE-MOB")]
        public static ActivityCode RigReleaseMobOrDemob
        {
            get 
            {
                if (rigReleaseMobOrDemob == null)
                {
                    rigReleaseMobOrDemob = new ActivityCode("rig release -- MOB or DE-MOB");
                    rigReleaseMobOrDemob.Description = "A specialization of 'rig release'.";
                }
                return rigReleaseMobOrDemob;
            }
        }

        private static ActivityCode rigRepairs;
        /// <summary>
        /// rig repairs
        /// </summary>
        [EnumValueNameAttribute("rig repairs")]
        public static ActivityCode RigRepairs
        {
            get 
            {
                if (rigRepairs == null)
                {
                    rigRepairs = new ActivityCode("rig repairs");
                    rigRepairs.Description = "rig repairs";
                }
                return rigRepairs;
            }
        }

        private static ActivityCode rigRepairsDrawworks;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- drawworks")]
        public static ActivityCode RigRepairsDrawworks
        {
            get 
            {
                if (rigRepairsDrawworks == null)
                {
                    rigRepairsDrawworks = new ActivityCode("rig repairs -- drawworks");
                    rigRepairsDrawworks.Description = "A specialization of 'rig repairs'.";
                }
                return rigRepairsDrawworks;
            }
        }

        private static ActivityCode rigRepairsElectrical;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- electrical")]
        public static ActivityCode RigRepairsElectrical
        {
            get 
            {
                if (rigRepairsElectrical == null)
                {
                    rigRepairsElectrical = new ActivityCode("rig repairs -- electrical");
                    rigRepairsElectrical.Description = "A specialization of 'rig repairs'.";
                }
                return rigRepairsElectrical;
            }
        }

        private static ActivityCode rigRepairsMudSystem;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- mud system")]
        public static ActivityCode RigRepairsMudSystem
        {
            get 
            {
                if (rigRepairsMudSystem == null)
                {
                    rigRepairsMudSystem = new ActivityCode("rig repairs -- mud system");
                    rigRepairsMudSystem.Description = "A specialization of 'rig repairs'.";
                }
                return rigRepairsMudSystem;
            }
        }

        private static ActivityCode rigRepairsOther;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- other")]
        public static ActivityCode RigRepairsOther
        {
            get 
            {
                if (rigRepairsOther == null)
                {
                    rigRepairsOther = new ActivityCode("rig repairs -- other");
                    rigRepairsOther.Description = "A specialization of 'rig repairs'.";
                }
                return rigRepairsOther;
            }
        }

        private static ActivityCode rigRepairsRotary;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- rotary")]
        public static ActivityCode RigRepairsRotary
        {
            get 
            {
                if (rigRepairsRotary == null)
                {
                    rigRepairsRotary = new ActivityCode("rig repairs -- rotary");
                    rigRepairsRotary.Description = "A specialization of 'rig repairs'.";
                }
                return rigRepairsRotary;
            }
        }

        private static ActivityCode rigRepairsSubseaEquipment;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- subsea equipment")]
        public static ActivityCode RigRepairsSubseaEquipment
        {
            get 
            {
                if (rigRepairsSubseaEquipment == null)
                {
                    rigRepairsSubseaEquipment = new ActivityCode("rig repairs -- subsea equipment");
                    rigRepairsSubseaEquipment.Description = "A specialization of 'rig repairs'.";
                }
                return rigRepairsSubseaEquipment;
            }
        }

        private static ActivityCode rigRepairsWellControlEquipment;
        /// <summary>
        /// A specialization of 'rig repairs'.
        /// </summary>
        [EnumValueNameAttribute("rig repairs -- well control equipment")]
        public static ActivityCode RigRepairsWellControlEquipment
        {
            get 
            {
                if (rigRepairsWellControlEquipment == null)
                {
                    rigRepairsWellControlEquipment = new ActivityCode("rig repairs -- well control equipment");
                    rigRepairsWellControlEquipment.Description = "A specialization of 'rig repairs'.";
                }
                return rigRepairsWellControlEquipment;
            }
        }

        private static ActivityCode rigService;
        /// <summary>
        /// rig service
        /// </summary>
        [EnumValueNameAttribute("rig service")]
        public static ActivityCode RigService
        {
            get 
            {
                if (rigService == null)
                {
                    rigService = new ActivityCode("rig service");
                    rigService.Description = "rig service";
                }
                return rigService;
            }
        }

        private static ActivityCode rigServiceLubricateRig;
        /// <summary>
        /// A specialization of 'rig service'.
        /// </summary>
        [EnumValueNameAttribute("rig service -- lubricate rig")]
        public static ActivityCode RigServiceLubricateRig
        {
            get 
            {
                if (rigServiceLubricateRig == null)
                {
                    rigServiceLubricateRig = new ActivityCode("rig service -- lubricate rig");
                    rigServiceLubricateRig.Description = "A specialization of 'rig service'.";
                }
                return rigServiceLubricateRig;
            }
        }

        private static ActivityCode rigServiceTestEquipment;
        /// <summary>
        /// A specialization of 'rig service'.
        /// </summary>
        [EnumValueNameAttribute("rig service -- test equipment")]
        public static ActivityCode RigServiceTestEquipment
        {
            get 
            {
                if (rigServiceTestEquipment == null)
                {
                    rigServiceTestEquipment = new ActivityCode("rig service -- test equipment");
                    rigServiceTestEquipment.Description = "A specialization of 'rig service'.";
                }
                return rigServiceTestEquipment;
            }
        }

        private static ActivityCode rigUpOrTearDown;
        /// <summary>
        /// rig up or tear down
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down")]
        public static ActivityCode RigUpOrTearDown
        {
            get 
            {
                if (rigUpOrTearDown == null)
                {
                    rigUpOrTearDown = new ActivityCode("rig up or tear down");
                    rigUpOrTearDown.Description = "rig up or tear down";
                }
                return rigUpOrTearDown;
            }
        }

        private static ActivityCode rigUpOrTearDownRigUp;
        /// <summary>
        /// A specialization of 'rig up or tear down'.
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down -- rig up")]
        public static ActivityCode RigUpOrTearDownRigUp
        {
            get 
            {
                if (rigUpOrTearDownRigUp == null)
                {
                    rigUpOrTearDownRigUp = new ActivityCode("rig up or tear down -- rig up");
                    rigUpOrTearDownRigUp.Description = "A specialization of 'rig up or tear down'.";
                }
                return rigUpOrTearDownRigUp;
            }
        }

        private static ActivityCode rigUpOrTearDownSiteWork;
        /// <summary>
        /// A specialization of 'rig up or tear down'.
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down -- site work")]
        public static ActivityCode RigUpOrTearDownSiteWork
        {
            get 
            {
                if (rigUpOrTearDownSiteWork == null)
                {
                    rigUpOrTearDownSiteWork = new ActivityCode("rig up or tear down -- site work");
                    rigUpOrTearDownSiteWork.Description = "A specialization of 'rig up or tear down'.";
                }
                return rigUpOrTearDownSiteWork;
            }
        }

        private static ActivityCode rigUpOrTearDownTearDown;
        /// <summary>
        /// A specialization of 'rig up or tear down'.v
        /// </summary>
        [EnumValueNameAttribute("rig up or tear down -- tear down")]
        public static ActivityCode RigUpOrTearDownTearDown
        {
            get 
            {
                if (rigUpOrTearDownTearDown == null)
                {
                    rigUpOrTearDownTearDown = new ActivityCode("rig up or tear down -- tear down");
                    rigUpOrTearDownTearDown.Description = "A specialization of 'rig up or tear down'.v";
                }
                return rigUpOrTearDownTearDown;
            }
        }

        private static ActivityCode runOrPullRiser;
        /// <summary>
        /// run or pull riser
        /// </summary>
        [EnumValueNameAttribute("run or pull riser")]
        public static ActivityCode RunOrPullRiser
        {
            get 
            {
                if (runOrPullRiser == null)
                {
                    runOrPullRiser = new ActivityCode("run or pull riser");
                    runOrPullRiser.Description = "run or pull riser";
                }
                return runOrPullRiser;
            }
        }

        private static ActivityCode runOrPullRiserOther;
        /// <summary>
        /// A specialization of 'run or pull riser'.
        /// </summary>
        [EnumValueNameAttribute("run or pull riser -- other")]
        public static ActivityCode RunOrPullRiserOther
        {
            get 
            {
                if (runOrPullRiserOther == null)
                {
                    runOrPullRiserOther = new ActivityCode("run or pull riser -- other");
                    runOrPullRiserOther.Description = "A specialization of 'run or pull riser'.";
                }
                return runOrPullRiserOther;
            }
        }

        private static ActivityCode runOrPullRiserRunOrPullRiser;
        /// <summary>
        /// A specialization of 'run or pull riser'.
        /// </summary>
        [EnumValueNameAttribute("run or pull riser -- run or pull riser")]
        public static ActivityCode RunOrPullRiserRunOrPullRiser
        {
            get 
            {
                if (runOrPullRiserRunOrPullRiser == null)
                {
                    runOrPullRiserRunOrPullRiser = new ActivityCode("run or pull riser -- run or pull riser");
                    runOrPullRiserRunOrPullRiser.Description = "A specialization of 'run or pull riser'.";
                }
                return runOrPullRiserRunOrPullRiser;
            }
        }

        private static ActivityCode squeezeCement;
        /// <summary>
        /// squeeze cement
        /// </summary>
        [EnumValueNameAttribute("squeeze cement")]
        public static ActivityCode SqueezeCement
        {
            get 
            {
                if (squeezeCement == null)
                {
                    squeezeCement = new ActivityCode("squeeze cement");
                    squeezeCement.Description = "squeeze cement";
                }
                return squeezeCement;
            }
        }

        private static ActivityCode squeezeCementCasingRepair;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- casing repair")]
        public static ActivityCode SqueezeCementCasingRepair
        {
            get 
            {
                if (squeezeCementCasingRepair == null)
                {
                    squeezeCementCasingRepair = new ActivityCode("squeeze cement -- casing repair");
                    squeezeCementCasingRepair.Description = "A specialization of 'squeeze cement'.";
                }
                return squeezeCementCasingRepair;
            }
        }

        private static ActivityCode squeezeCementCasingShoe;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- casing shoe")]
        public static ActivityCode SqueezeCementCasingShoe
        {
            get 
            {
                if (squeezeCementCasingShoe == null)
                {
                    squeezeCementCasingShoe = new ActivityCode("squeeze cement -- casing shoe");
                    squeezeCementCasingShoe.Description = "A specialization of 'squeeze cement'.";
                }
                return squeezeCementCasingShoe;
            }
        }

        private static ActivityCode squeezeCementPartedCasing;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- parted casing")]
        public static ActivityCode SqueezeCementPartedCasing
        {
            get 
            {
                if (squeezeCementPartedCasing == null)
                {
                    squeezeCementPartedCasing = new ActivityCode("squeeze cement -- parted casing");
                    squeezeCementPartedCasing.Description = "A specialization of 'squeeze cement'.";
                }
                return squeezeCementPartedCasing;
            }
        }

        private static ActivityCode squeezeCementPerforationsDst;
        /// <summary>
        /// A specialization of 'squeeze cement'.
        /// </summary>
        [EnumValueNameAttribute("squeeze cement -- perforations DST")]
        public static ActivityCode SqueezeCementPerforationsDst
        {
            get 
            {
                if (squeezeCementPerforationsDst == null)
                {
                    squeezeCementPerforationsDst = new ActivityCode("squeeze cement -- perforations DST");
                    squeezeCementPerforationsDst.Description = "A specialization of 'squeeze cement'.";
                }
                return squeezeCementPerforationsDst;
            }
        }

        private static ActivityCode stuckPipe;
        /// <summary>
        /// stuck pipe
        /// </summary>
        [EnumValueNameAttribute("stuck pipe")]
        public static ActivityCode StuckPipe
        {
            get 
            {
                if (stuckPipe == null)
                {
                    stuckPipe = new ActivityCode("stuck pipe");
                    stuckPipe.Description = "stuck pipe";
                }
                return stuckPipe;
            }
        }

        private static ActivityCode surfaceStringHandling;
        /// <summary>
        /// surface string handling
        /// </summary>
        [EnumValueNameAttribute("surface string handling")]
        public static ActivityCode SurfaceStringHandling
        {
            get 
            {
                if (surfaceStringHandling == null)
                {
                    surfaceStringHandling = new ActivityCode("surface string handling");
                    surfaceStringHandling.Description = "surface string handling";
                }
                return surfaceStringHandling;
            }
        }

        private static ActivityCode testingGeneral;
        /// <summary>
        /// Testing of any nature, if more detail is not known.
        /// </summary>
        [EnumValueNameAttribute("testing general")]
        public static ActivityCode TestingGeneral
        {
            get 
            {
                if (testingGeneral == null)
                {
                    testingGeneral = new ActivityCode("testing general");
                    testingGeneral.Description = "Testing of any nature, if more detail is not known.";
                }
                return testingGeneral;
            }
        }

        private static ActivityCode testingGeneralEquipment;
        /// <summary>
        /// A specialization of 'testing general'. Testing of surface equipment, or downhole equipment tested at surface.
        /// </summary>
        [EnumValueNameAttribute("testing general -- equipment")]
        public static ActivityCode TestingGeneralEquipment
        {
            get 
            {
                if (testingGeneralEquipment == null)
                {
                    testingGeneralEquipment = new ActivityCode("testing general -- equipment");
                    testingGeneralEquipment.Description = "A specialization of 'testing general'. Testing of surface equipment, or downhole equipment tested at surface.";
                }
                return testingGeneralEquipment;
            }
        }

        private static ActivityCode testingGeneralFlow;
        /// <summary>
        /// A specialization of 'testing general'. Well Flow testing, in the pre-production phase of the well.
        /// </summary>
        [EnumValueNameAttribute("testing general -- flow")]
        public static ActivityCode TestingGeneralFlow
        {
            get 
            {
                if (testingGeneralFlow == null)
                {
                    testingGeneralFlow = new ActivityCode("testing general -- flow");
                    testingGeneralFlow.Description = "A specialization of 'testing general'. Well Flow testing, in the pre-production phase of the well.";
                }
                return testingGeneralFlow;
            }
        }

        private static ActivityCode tripping;
        /// <summary>
        /// tripping
        /// </summary>
        [EnumValueNameAttribute("tripping")]
        public static ActivityCode Tripping
        {
            get 
            {
                if (tripping == null)
                {
                    tripping = new ActivityCode("tripping");
                    tripping.Description = "tripping";
                }
                return tripping;
            }
        }

        private static ActivityCode trippingBackreaming;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- back-reaming")]
        public static ActivityCode TrippingBackreaming
        {
            get 
            {
                if (trippingBackreaming == null)
                {
                    trippingBackreaming = new ActivityCode("tripping -- back-reaming");
                    trippingBackreaming.Description = "A specialization of 'tripping'.";
                }
                return trippingBackreaming;
            }
        }

        private static ActivityCode trippingFlowCheck;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- flow check")]
        public static ActivityCode TrippingFlowCheck
        {
            get 
            {
                if (trippingFlowCheck == null)
                {
                    trippingFlowCheck = new ActivityCode("tripping -- flow check");
                    trippingFlowCheck.Description = "A specialization of 'tripping'.";
                }
                return trippingFlowCheck;
            }
        }

        private static ActivityCode trippingShortTripIn;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- short trip in")]
        public static ActivityCode TrippingShortTripIn
        {
            get 
            {
                if (trippingShortTripIn == null)
                {
                    trippingShortTripIn = new ActivityCode("tripping -- short trip in");
                    trippingShortTripIn.Description = "A specialization of 'tripping'.";
                }
                return trippingShortTripIn;
            }
        }

        private static ActivityCode trippingShortTripOut;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- short trip out")]
        public static ActivityCode TrippingShortTripOut
        {
            get 
            {
                if (trippingShortTripOut == null)
                {
                    trippingShortTripOut = new ActivityCode("tripping -- short trip out");
                    trippingShortTripOut.Description = "A specialization of 'tripping'.";
                }
                return trippingShortTripOut;
            }
        }

        private static ActivityCode trippingTripInFromSurface;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- trip in (from surface)")]
        public static ActivityCode TrippingTripInFromSurface
        {
            get 
            {
                if (trippingTripInFromSurface == null)
                {
                    trippingTripInFromSurface = new ActivityCode("tripping -- trip in (from surface)");
                    trippingTripInFromSurface.Description = "A specialization of 'tripping'.";
                }
                return trippingTripInFromSurface;
            }
        }

        private static ActivityCode trippingTripOutToSurface;
        /// <summary>
        /// A specialization of 'tripping'.
        /// </summary>
        [EnumValueNameAttribute("tripping -- trip out (to surface)")]
        public static ActivityCode TrippingTripOutToSurface
        {
            get 
            {
                if (trippingTripOutToSurface == null)
                {
                    trippingTripOutToSurface = new ActivityCode("tripping -- trip out (to surface)");
                    trippingTripOutToSurface.Description = "A specialization of 'tripping'.";
                }
                return trippingTripOutToSurface;
            }
        }

        private static ActivityCode wait;
        /// <summary>
        /// wait
        /// </summary>
        [EnumValueNameAttribute("wait")]
        public static ActivityCode Wait
        {
            get 
            {
                if (wait == null)
                {
                    wait = new ActivityCode("wait");
                    wait.Description = "wait";
                }
                return wait;
            }
        }

        private static ActivityCode waitDaylight;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- daylight")]
        public static ActivityCode WaitDaylight
        {
            get 
            {
                if (waitDaylight == null)
                {
                    waitDaylight = new ActivityCode("wait -- daylight");
                    waitDaylight.Description = "A specialization of 'wait'.";
                }
                return waitDaylight;
            }
        }

        private static ActivityCode waitEnvironmentalOrRegulatory;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- environmental or regulatory")]
        public static ActivityCode WaitEnvironmentalOrRegulatory
        {
            get 
            {
                if (waitEnvironmentalOrRegulatory == null)
                {
                    waitEnvironmentalOrRegulatory = new ActivityCode("wait -- environmental or regulatory");
                    waitEnvironmentalOrRegulatory.Description = "A specialization of 'wait'.";
                }
                return waitEnvironmentalOrRegulatory;
            }
        }

        private static ActivityCode waitEquipment;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- equipment")]
        public static ActivityCode WaitEquipment
        {
            get 
            {
                if (waitEquipment == null)
                {
                    waitEquipment = new ActivityCode("wait -- equipment");
                    waitEquipment.Description = "A specialization of 'wait'.";
                }
                return waitEquipment;
            }
        }

        private static ActivityCode waitHoliday;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- holiday")]
        public static ActivityCode WaitHoliday
        {
            get 
            {
                if (waitHoliday == null)
                {
                    waitHoliday = new ActivityCode("wait -- holiday");
                    waitHoliday.Description = "A specialization of 'wait'.";
                }
                return waitHoliday;
            }
        }

        private static ActivityCode waitIce;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- ice")]
        public static ActivityCode WaitIce
        {
            get 
            {
                if (waitIce == null)
                {
                    waitIce = new ActivityCode("wait -- ice");
                    waitIce.Description = "A specialization of 'wait'.";
                }
                return waitIce;
            }
        }

        private static ActivityCode waitOnOrders;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- on orders")]
        public static ActivityCode WaitOnOrders
        {
            get 
            {
                if (waitOnOrders == null)
                {
                    waitOnOrders = new ActivityCode("wait -- on orders");
                    waitOnOrders.Description = "A specialization of 'wait'.";
                }
                return waitOnOrders;
            }
        }

        private static ActivityCode waitOperator;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- operator")]
        public static ActivityCode WaitOperator
        {
            get 
            {
                if (waitOperator == null)
                {
                    waitOperator = new ActivityCode("wait -- operator");
                    waitOperator.Description = "A specialization of 'wait'.";
                }
                return waitOperator;
            }
        }

        private static ActivityCode waitOther;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- other")]
        public static ActivityCode WaitOther
        {
            get 
            {
                if (waitOther == null)
                {
                    waitOther = new ActivityCode("wait -- other");
                    waitOther.Description = "A specialization of 'wait'.";
                }
                return waitOther;
            }
        }

        private static ActivityCode waitPartners;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- partners")]
        public static ActivityCode WaitPartners
        {
            get 
            {
                if (waitPartners == null)
                {
                    waitPartners = new ActivityCode("wait -- partners");
                    waitPartners.Description = "A specialization of 'wait'.";
                }
                return waitPartners;
            }
        }

        private static ActivityCode waitServiceCompany;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- service company")]
        public static ActivityCode WaitServiceCompany
        {
            get 
            {
                if (waitServiceCompany == null)
                {
                    waitServiceCompany = new ActivityCode("wait -- service company");
                    waitServiceCompany.Description = "A specialization of 'wait'.";
                }
                return waitServiceCompany;
            }
        }

        private static ActivityCode waitWeather;
        /// <summary>
        /// A specialization of 'wait'.
        /// </summary>
        [EnumValueNameAttribute("wait -- weather")]
        public static ActivityCode WaitWeather
        {
            get 
            {
                if (waitWeather == null)
                {
                    waitWeather = new ActivityCode("wait -- weather");
                    waitWeather.Description = "A specialization of 'wait'.";
                }
                return waitWeather;
            }
        }

        private static ActivityCode wellControl;
        /// <summary>
        /// well control
        /// </summary>
        [EnumValueNameAttribute("well control")]
        public static ActivityCode WellControl
        {
            get 
            {
                if (wellControl == null)
                {
                    wellControl = new ActivityCode("well control");
                    wellControl.Description = "well control";
                }
                return wellControl;
            }
        }

        private static ActivityCode wellControlMix;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- mix")]
        public static ActivityCode WellControlMix
        {
            get 
            {
                if (wellControlMix == null)
                {
                    wellControlMix = new ActivityCode("well control -- mix");
                    wellControlMix.Description = "A specialization of 'well control'.";
                }
                return wellControlMix;
            }
        }

        private static ActivityCode wellControlShutIn;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- shut in")]
        public static ActivityCode WellControlShutIn
        {
            get 
            {
                if (wellControlShutIn == null)
                {
                    wellControlShutIn = new ActivityCode("well control -- shut in");
                    wellControlShutIn.Description = "A specialization of 'well control'.";
                }
                return wellControlShutIn;
            }
        }

        private static ActivityCode wellControlStrip;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- strip")]
        public static ActivityCode WellControlStrip
        {
            get 
            {
                if (wellControlStrip == null)
                {
                    wellControlStrip = new ActivityCode("well control -- strip");
                    wellControlStrip.Description = "A specialization of 'well control'.";
                }
                return wellControlStrip;
            }
        }

        private static ActivityCode wellControlWellKill;
        /// <summary>
        /// A specialization of 'well control'.
        /// </summary>
        [EnumValueNameAttribute("well control -- well kill")]
        public static ActivityCode WellControlWellKill
        {
            get 
            {
                if (wellControlWellKill == null)
                {
                    wellControlWellKill = new ActivityCode("well control -- well kill");
                    wellControlWellKill.Description = "A specialization of 'well control'.";
                }
                return wellControlWellKill;
            }
        }

        private static ActivityCode wellSrvc;
        /// <summary>
        /// well services
        /// </summary>
        [EnumValueNameAttribute("well srvc")]
        public static ActivityCode WellSrvc
        {
            get 
            {
                if (wellSrvc == null)
                {
                    wellSrvc = new ActivityCode("well srvc");
                    wellSrvc.Description = "well services";
                }
                return wellSrvc;
            }
        }

        private static ActivityCode wellSrvcCasingRepair;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- casing repair")]
        public static ActivityCode WellSrvcCasingRepair
        {
            get 
            {
                if (wellSrvcCasingRepair == null)
                {
                    wellSrvcCasingRepair = new ActivityCode("well srvc -- casing repair");
                    wellSrvcCasingRepair.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcCasingRepair;
            }
        }

        private static ActivityCode wellSrvcCleanWellToComplFluid;
        /// <summary>
        /// cleanout well to completion fluid
        /// </summary>
        [EnumValueNameAttribute("well srvc -- clean well to compl fluid")]
        public static ActivityCode WellSrvcCleanWellToComplFluid
        {
            get 
            {
                if (wellSrvcCleanWellToComplFluid == null)
                {
                    wellSrvcCleanWellToComplFluid = new ActivityCode("well srvc -- clean well to compl fluid");
                    wellSrvcCleanWellToComplFluid.Description = "cleanout well to completion fluid";
                }
                return wellSrvcCleanWellToComplFluid;
            }
        }

        private static ActivityCode wellSrvcCoiledTubingWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- coiled tubing work")]
        public static ActivityCode WellSrvcCoiledTubingWork
        {
            get 
            {
                if (wellSrvcCoiledTubingWork == null)
                {
                    wellSrvcCoiledTubingWork = new ActivityCode("well srvc -- coiled tubing work");
                    wellSrvcCoiledTubingWork.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcCoiledTubingWork;
            }
        }

        private static ActivityCode wellSrvcGravelPack;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- gravel pack")]
        public static ActivityCode WellSrvcGravelPack
        {
            get 
            {
                if (wellSrvcGravelPack == null)
                {
                    wellSrvcGravelPack = new ActivityCode("well srvc -- gravel pack");
                    wellSrvcGravelPack.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcGravelPack;
            }
        }

        private static ActivityCode wellSrvcInstallOrTestXmasTree;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- install or test xmas tree")]
        public static ActivityCode WellSrvcInstallOrTestXmasTree
        {
            get 
            {
                if (wellSrvcInstallOrTestXmasTree == null)
                {
                    wellSrvcInstallOrTestXmasTree = new ActivityCode("well srvc -- install or test xmas tree");
                    wellSrvcInstallOrTestXmasTree.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcInstallOrTestXmasTree;
            }
        }

        private static ActivityCode wellSrvcKillWell;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- kill well")]
        public static ActivityCode WellSrvcKillWell
        {
            get 
            {
                if (wellSrvcKillWell == null)
                {
                    wellSrvcKillWell = new ActivityCode("well srvc -- kill well");
                    wellSrvcKillWell.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcKillWell;
            }
        }

        private static ActivityCode wellSrvcLandSetTestCompletion;
        /// <summary>
        /// A specialization of 'well srvc': land, set and test completion
        /// </summary>
        [EnumValueNameAttribute("well srvc -- land, set, test completion")]
        public static ActivityCode WellSrvcLandSetTestCompletion
        {
            get 
            {
                if (wellSrvcLandSetTestCompletion == null)
                {
                    wellSrvcLandSetTestCompletion = new ActivityCode("well srvc -- land, set, test completion");
                    wellSrvcLandSetTestCompletion.Description = "A specialization of 'well srvc': land, set and test completion";
                }
                return wellSrvcLandSetTestCompletion;
            }
        }

        private static ActivityCode wellSrvcPerforate;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- perforate")]
        public static ActivityCode WellSrvcPerforate
        {
            get 
            {
                if (wellSrvcPerforate == null)
                {
                    wellSrvcPerforate = new ActivityCode("well srvc -- perforate");
                    wellSrvcPerforate.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcPerforate;
            }
        }

        private static ActivityCode wellSrvcPullCompletion;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- pull completion")]
        public static ActivityCode WellSrvcPullCompletion
        {
            get 
            {
                if (wellSrvcPullCompletion == null)
                {
                    wellSrvcPullCompletion = new ActivityCode("well srvc -- pull completion");
                    wellSrvcPullCompletion.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcPullCompletion;
            }
        }

        private static ActivityCode wellSrvcPullSuspensionPlugs;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- pull suspension plugs")]
        public static ActivityCode WellSrvcPullSuspensionPlugs
        {
            get 
            {
                if (wellSrvcPullSuspensionPlugs == null)
                {
                    wellSrvcPullSuspensionPlugs = new ActivityCode("well srvc -- pull suspension plugs");
                    wellSrvcPullSuspensionPlugs.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcPullSuspensionPlugs;
            }
        }

        private static ActivityCode wellSrvcRunCompletion;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- run completion")]
        public static ActivityCode WellSrvcRunCompletion
        {
            get 
            {
                if (wellSrvcRunCompletion == null)
                {
                    wellSrvcRunCompletion = new ActivityCode("well srvc -- run completion");
                    wellSrvcRunCompletion.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcRunCompletion;
            }
        }

        private static ActivityCode wellSrvcRunScreens;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- run screens")]
        public static ActivityCode WellSrvcRunScreens
        {
            get 
            {
                if (wellSrvcRunScreens == null)
                {
                    wellSrvcRunScreens = new ActivityCode("well srvc -- run screens");
                    wellSrvcRunScreens.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcRunScreens;
            }
        }

        private static ActivityCode wellSrvcSandControl;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- sand control")]
        public static ActivityCode WellSrvcSandControl
        {
            get 
            {
                if (wellSrvcSandControl == null)
                {
                    wellSrvcSandControl = new ActivityCode("well srvc -- sand control");
                    wellSrvcSandControl.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcSandControl;
            }
        }

        private static ActivityCode wellSrvcStimulation;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- stimulation")]
        public static ActivityCode WellSrvcStimulation
        {
            get 
            {
                if (wellSrvcStimulation == null)
                {
                    wellSrvcStimulation = new ActivityCode("well srvc -- stimulation");
                    wellSrvcStimulation.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcStimulation;
            }
        }

        private static ActivityCode wellSrvcSubseaWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- subsea work")]
        public static ActivityCode WellSrvcSubseaWork
        {
            get 
            {
                if (wellSrvcSubseaWork == null)
                {
                    wellSrvcSubseaWork = new ActivityCode("well srvc -- subsea work");
                    wellSrvcSubseaWork.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcSubseaWork;
            }
        }

        private static ActivityCode wellSrvcSurfaceLineWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- surface line work")]
        public static ActivityCode WellSrvcSurfaceLineWork
        {
            get 
            {
                if (wellSrvcSurfaceLineWork == null)
                {
                    wellSrvcSurfaceLineWork = new ActivityCode("well srvc -- surface line work");
                    wellSrvcSurfaceLineWork.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcSurfaceLineWork;
            }
        }

        private static ActivityCode wellSrvcSuspendWellOrPullBops;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- suspend well or pull BOPs")]
        public static ActivityCode WellSrvcSuspendWellOrPullBops
        {
            get 
            {
                if (wellSrvcSuspendWellOrPullBops == null)
                {
                    wellSrvcSuspendWellOrPullBops = new ActivityCode("well srvc -- suspend well or pull BOPs");
                    wellSrvcSuspendWellOrPullBops.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcSuspendWellOrPullBops;
            }
        }

        private static ActivityCode wellSrvcTestWell;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- test well")]
        public static ActivityCode WellSrvcTestWell
        {
            get 
            {
                if (wellSrvcTestWell == null)
                {
                    wellSrvcTestWell = new ActivityCode("well srvc -- test well");
                    wellSrvcTestWell.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcTestWell;
            }
        }

        private static ActivityCode wellSrvcWash;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- wash")]
        public static ActivityCode WellSrvcWash
        {
            get 
            {
                if (wellSrvcWash == null)
                {
                    wellSrvcWash = new ActivityCode("well srvc -- wash");
                    wellSrvcWash.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcWash;
            }
        }

        private static ActivityCode wellSrvcWirelineWork;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- wireline work")]
        public static ActivityCode WellSrvcWirelineWork
        {
            get 
            {
                if (wellSrvcWirelineWork == null)
                {
                    wellSrvcWirelineWork = new ActivityCode("well srvc -- wireline work");
                    wellSrvcWirelineWork.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcWirelineWork;
            }
        }

        private static ActivityCode wellSrvcWorkTubulars;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- work tubulars")]
        public static ActivityCode WellSrvcWorkTubulars
        {
            get 
            {
                if (wellSrvcWorkTubulars == null)
                {
                    wellSrvcWorkTubulars = new ActivityCode("well srvc -- work tubulars");
                    wellSrvcWorkTubulars.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcWorkTubulars;
            }
        }

        private static ActivityCode wellSrvcWorkstringRun;
        /// <summary>
        /// A specialization of 'well srvc'.
        /// </summary>
        [EnumValueNameAttribute("well srvc -- workstring run")]
        public static ActivityCode WellSrvcWorkstringRun
        {
            get 
            {
                if (wellSrvcWorkstringRun == null)
                {
                    wellSrvcWorkstringRun = new ActivityCode("well srvc -- workstring run");
                    wellSrvcWorkstringRun.Description = "A specialization of 'well srvc'.";
                }
                return wellSrvcWorkstringRun;
            }
        }

        private static ActivityCode wirelineLogs;
        /// <summary>
        /// wireline logs
        /// </summary>
        [EnumValueNameAttribute("wireline logs")]
        public static ActivityCode WirelineLogs
        {
            get 
            {
                if (wirelineLogs == null)
                {
                    wirelineLogs = new ActivityCode("wireline logs");
                    wirelineLogs.Description = "wireline logs";
                }
                return wirelineLogs;
            }
        }

        private static ActivityCode wirelineLogsAbandonment;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- abandonment")]
        public static ActivityCode WirelineLogsAbandonment
        {
            get 
            {
                if (wirelineLogsAbandonment == null)
                {
                    wirelineLogsAbandonment = new ActivityCode("wireline logs -- abandonment");
                    wirelineLogsAbandonment.Description = "A specialization of 'wireline logs'.";
                }
                return wirelineLogsAbandonment;
            }
        }

        private static ActivityCode wirelineLogsEvaluation;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- evaluation")]
        public static ActivityCode WirelineLogsEvaluation
        {
            get 
            {
                if (wirelineLogsEvaluation == null)
                {
                    wirelineLogsEvaluation = new ActivityCode("wireline logs -- evaluation");
                    wirelineLogsEvaluation.Description = "A specialization of 'wireline logs'.";
                }
                return wirelineLogsEvaluation;
            }
        }

        private static ActivityCode wirelineLogsFormTester;
        /// <summary>
        /// A specialization of 'wireline logs': formation tester
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- form tester")]
        public static ActivityCode WirelineLogsFormTester
        {
            get 
            {
                if (wirelineLogsFormTester == null)
                {
                    wirelineLogsFormTester = new ActivityCode("wireline logs -- form tester");
                    wirelineLogsFormTester.Description = "A specialization of 'wireline logs': formation tester";
                }
                return wirelineLogsFormTester;
            }
        }

        private static ActivityCode wirelineLogsOther;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- other")]
        public static ActivityCode WirelineLogsOther
        {
            get 
            {
                if (wirelineLogsOther == null)
                {
                    wirelineLogsOther = new ActivityCode("wireline logs -- other");
                    wirelineLogsOther.Description = "A specialization of 'wireline logs'.";
                }
                return wirelineLogsOther;
            }
        }

        private static ActivityCode wirelineLogsSideWallCores;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- side wall cores")]
        public static ActivityCode WirelineLogsSideWallCores
        {
            get 
            {
                if (wirelineLogsSideWallCores == null)
                {
                    wirelineLogsSideWallCores = new ActivityCode("wireline logs -- side wall cores");
                    wirelineLogsSideWallCores.Description = "A specialization of 'wireline logs'.";
                }
                return wirelineLogsSideWallCores;
            }
        }

        private static ActivityCode wirelineLogsVelocity;
        /// <summary>
        /// A specialization of 'wireline logs'.
        /// </summary>
        [EnumValueNameAttribute("wireline logs -- velocity")]
        public static ActivityCode WirelineLogsVelocity
        {
            get 
            {
                if (wirelineLogsVelocity == null)
                {
                    wirelineLogsVelocity = new ActivityCode("wireline logs -- velocity");
                    wirelineLogsVelocity.Description = "A specialization of 'wireline logs'.";
                }
                return wirelineLogsVelocity;
            }
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

        private static LithologyType alkaliFeldsparRhyolite;
        /// <summary>
        /// Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("alkali feldspar rhyolite")]
        public static LithologyType AlkaliFeldsparRhyolite
        {
            get 
            {
                if (alkaliFeldsparRhyolite == null)
                {
                    alkaliFeldsparRhyolite = new LithologyType("alkali feldspar rhyolite");
                    alkaliFeldsparRhyolite.Description = "Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002.";
                    alkaliFeldsparRhyolite.Version = "1.4.1.0";
                }
                return alkaliFeldsparRhyolite;
            }
        }

        private static LithologyType alkaliOlivineBasalt;
        /// <summary>
        /// Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("alkali olivine basalt")]
        public static LithologyType AlkaliOlivineBasalt
        {
            get 
            {
                if (alkaliOlivineBasalt == null)
                {
                    alkaliOlivineBasalt = new LithologyType("alkali olivine basalt");
                    alkaliOlivineBasalt.Description = "Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.";
                    alkaliOlivineBasalt.Version = "1.4.1.0";
                }
                return alkaliOlivineBasalt;
            }
        }

        private static LithologyType amphibolite;
        /// <summary>
        /// Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8.
        /// </summary>
        [EnumValueNameAttribute("amphibolite")]
        public static LithologyType Amphibolite
        {
            get 
            {
                if (amphibolite == null)
                {
                    amphibolite = new LithologyType("amphibolite");
                    amphibolite.Description = "Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8.";
                    amphibolite.Version = "1.4.1.0";
                }
                return amphibolite;
            }
        }

        private static LithologyType andesite;
        /// <summary>
        /// Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("andesite")]
        public static LithologyType Andesite
        {
            get 
            {
                if (andesite == null)
                {
                    andesite = new LithologyType("andesite");
                    andesite.Description = "Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002.";
                    andesite.Version = "1.4.1.0";
                }
                return andesite;
            }
        }

        private static LithologyType anhydrite;
        /// <summary>
        /// Evaporite composed of at least 50 percent anhydrite. OneGeology / WITSML
        /// </summary>
        [EnumValueNameAttribute("anhydrite")]
        public static LithologyType Anhydrite
        {
            get 
            {
                if (anhydrite == null)
                {
                    anhydrite = new LithologyType("anhydrite");
                    anhydrite.Description = "Evaporite composed of at least 50 percent anhydrite. OneGeology / WITSML";
                    anhydrite.Version = "1.4.1.0";
                }
                return anhydrite;
            }
        }

        private static LithologyType anorthositicRock;
        /// <summary>
        /// Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("anorthositic rock")]
        public static LithologyType AnorthositicRock
        {
            get 
            {
                if (anorthositicRock == null)
                {
                    anorthositicRock = new LithologyType("anorthositic rock");
                    anorthositicRock.Description = "Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002.";
                    anorthositicRock.Version = "1.4.1.0";
                }
                return anorthositicRock;
            }
        }

        private static LithologyType anthracite;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005
        /// </summary>
        [EnumValueNameAttribute("anthracite")]
        public static LithologyType Anthracite
        {
            get 
            {
                if (anthracite == null)
                {
                    anthracite = new LithologyType("anthracite");
                    anthracite.Description = "Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005";
                    anthracite.Version = "1.4.1.0";
                }
                return anthracite;
            }
        }

        private static LithologyType aplite;
        /// <summary>
        /// Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("aplite")]
        public static LithologyType Aplite
        {
            get 
            {
                if (aplite == null)
                {
                    aplite = new LithologyType("aplite");
                    aplite.Description = "Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005.";
                    aplite.Version = "1.4.1.0";
                }
                return aplite;
            }
        }

        private static LithologyType arenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite.
        /// </summary>
        [EnumValueNameAttribute("arenite")]
        public static LithologyType Arenite
        {
            get 
            {
                if (arenite == null)
                {
                    arenite = new LithologyType("arenite");
                    arenite.Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite.";
                    arenite.Version = "1.4.1.0";
                }
                return arenite;
            }
        }

        private static LithologyType arkose;
        /// <summary>
        /// An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%).
        /// </summary>
        [EnumValueNameAttribute("arkose")]
        public static LithologyType Arkose
        {
            get 
            {
                if (arkose == null)
                {
                    arkose = new LithologyType("arkose");
                    arkose.Description = "An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%).";
                    arkose.Version = "1.3.1.1";
                }
                return arkose;
            }
        }

        private static LithologyType basalt;
        /// <summary>
        /// Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basalt")]
        public static LithologyType Basalt
        {
            get 
            {
                if (basalt == null)
                {
                    basalt = new LithologyType("basalt");
                    basalt.Description = "Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002.";
                    basalt.Version = "1.4.1.0";
                }
                return basalt;
            }
        }

        private static LithologyType basanite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basanite")]
        public static LithologyType Basanite
        {
            get 
            {
                if (basanite == null)
                {
                    basanite = new LithologyType("basanite");
                    basanite.Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.";
                    basanite.Version = "1.4.1.0";
                }
                return basanite;
            }
        }

        private static LithologyType bauxite;
        /// <summary>
        /// Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001.
        /// </summary>
        [EnumValueNameAttribute("bauxite")]
        public static LithologyType Bauxite
        {
            get 
            {
                if (bauxite == null)
                {
                    bauxite = new LithologyType("bauxite");
                    bauxite.Description = "Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001.";
                    bauxite.Version = "1.4.1.0";
                }
                return bauxite;
            }
        }

        private static LithologyType bituminousCoal;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("bituminous coal")]
        public static LithologyType BituminousCoal
        {
            get 
            {
                if (bituminousCoal == null)
                {
                    bituminousCoal = new LithologyType("bituminous coal");
                    bituminousCoal.Description = "Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.";
                    bituminousCoal.Version = "1.4.1.0";
                }
                return bituminousCoal;
            }
        }

        private static LithologyType blueschistMetamorphicRock;
        /// <summary>
        /// Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock
        /// </summary>
        [EnumValueNameAttribute("blueschist metamorphic rock")]
        public static LithologyType BlueschistMetamorphicRock
        {
            get 
            {
                if (blueschistMetamorphicRock == null)
                {
                    blueschistMetamorphicRock = new LithologyType("blueschist metamorphic rock");
                    blueschistMetamorphicRock.Description = "Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock";
                    blueschistMetamorphicRock.Version = "1.4.1.0";
                }
                return blueschistMetamorphicRock;
            }
        }

        private static LithologyType boninite;
        /// <summary>
        /// andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("boninite")]
        public static LithologyType Boninite
        {
            get 
            {
                if (boninite == null)
                {
                    boninite = new LithologyType("boninite");
                    boninite.Description = "andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002.";
                    boninite.Version = "1.4.1.0";
                }
                return boninite;
            }
        }

        private static LithologyType breccia;
        /// <summary>
        /// Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("breccia")]
        public static LithologyType Breccia
        {
            get 
            {
                if (breccia == null)
                {
                    breccia = new LithologyType("breccia");
                    breccia.Description = "Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005.";
                    breccia.Version = "1.4.1.0";
                }
                return breccia;
            }
        }

        private static LithologyType calcarenite;
        /// <summary>
        /// DEPRECATED. See "impure limestone".
        /// </summary>
        [EnumValueNameAttribute("calcarenite")]
        public static LithologyType Calcarenite
        {
            get 
            {
                if (calcarenite == null)
                {
                    calcarenite = new LithologyType("calcarenite");
                    calcarenite.Description = "DEPRECATED. See \"impure limestone\".";
                    calcarenite.Version = "1.3.1.1";
                    calcarenite.Deprecated = "1.4.1.0";
                    calcarenite.ReplacedBy = ImpureLimestone;
                }
                return calcarenite;
            }
        }

        private static LithologyType calcilutite;
        /// <summary>
        /// DEPRECATED. See "impure limestone".
        /// </summary>
        [EnumValueNameAttribute("calcilutite")]
        public static LithologyType Calcilutite
        {
            get 
            {
                if (calcilutite == null)
                {
                    calcilutite = new LithologyType("calcilutite");
                    calcilutite.Description = "DEPRECATED. See \"impure limestone\".";
                    calcilutite.Version = "1.3.1.1";
                    calcilutite.Deprecated = "1.4.1.0";
                    calcilutite.ReplacedBy = ImpureLimestone;
                }
                return calcilutite;
            }
        }

        private static LithologyType calcisiltite;
        /// <summary>
        /// DEPRECATED. See "impure limestone".
        /// </summary>
        [EnumValueNameAttribute("calcisiltite")]
        public static LithologyType Calcisiltite
        {
            get 
            {
                if (calcisiltite == null)
                {
                    calcisiltite = new LithologyType("calcisiltite");
                    calcisiltite.Description = "DEPRECATED. See \"impure limestone\".";
                    calcisiltite.Version = "1.3.1.1";
                    calcisiltite.Deprecated = "1.4.1.0";
                    calcisiltite.ReplacedBy = ImpureLimestone;
                }
                return calcisiltite;
            }
        }

        private static LithologyType carbonateOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("carbonate ooze")]
        public static LithologyType CarbonateOoze
        {
            get 
            {
                if (carbonateOoze == null)
                {
                    carbonateOoze = new LithologyType("carbonate ooze");
                    carbonateOoze.Description = "Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology.";
                    carbonateOoze.Version = "1.4.1.0";
                }
                return carbonateOoze;
            }
        }

        private static LithologyType carbonatite;
        /// <summary>
        /// Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("carbonatite")]
        public static LithologyType Carbonatite
        {
            get 
            {
                if (carbonatite == null)
                {
                    carbonatite = new LithologyType("carbonatite");
                    carbonatite.Description = "Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002.";
                    carbonatite.Version = "1.4.1.0";
                }
                return carbonatite;
            }
        }

        private static LithologyType chalk;
        /// <summary>
        /// A generally soft, white, very fine-grained, extremely pure, porous limestone. It forms under marine conditions from the gradual accumulation of skeletal elements from minute planktonic green algae (cocoliths), associated with varying proportions of larger microscopic fragments of bivalves, foraminifera and ostracods. It is common to find flint and chert nodules embedded in chalk. C.S. Harris, 2009
        /// </summary>
        [EnumValueNameAttribute("chalk")]
        public static LithologyType Chalk
        {
            get 
            {
                if (chalk == null)
                {
                    chalk = new LithologyType("chalk");
                    chalk.Description = "A generally soft, white, very fine-grained, extremely pure, porous limestone. It forms under marine conditions from the gradual accumulation of skeletal elements from minute planktonic green algae (cocoliths), associated with varying proportions of larger microscopic fragments of bivalves, foraminifera and ostracods. It is common to find flint and chert nodules embedded in chalk. C.S. Harris, 2009";
                    chalk.Version = "1.4.1.0";
                }
                return chalk;
            }
        }

        private static LithologyType chert;
        /// <summary>
        /// Sedimentary rock that consists of at least 50 percent silicate mineral material, deposited directly by chemical or biological processes at the depositional surface, or in particles formed by chemical or biological processes within the basin of deposition. SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("chert")]
        public static LithologyType Chert
        {
            get 
            {
                if (chert == null)
                {
                    chert = new LithologyType("chert");
                    chert.Description = "Sedimentary rock that consists of at least 50 percent silicate mineral material, deposited directly by chemical or biological processes at the depositional surface, or in particles formed by chemical or biological processes within the basin of deposition. SLTTs 2004.";
                    chert.Version = "1.4.1.0";
                }
                return chert;
            }
        }

        private static LithologyType clay;
        /// <summary>
        /// Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("clay")]
        public static LithologyType Clay
        {
            get 
            {
                if (clay == null)
                {
                    clay = new LithologyType("clay");
                    clay.Description = "Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.";
                    clay.Version = "1.4.1.0";
                }
                return clay;
            }
        }

        private static LithologyType claystone;
        /// <summary>
        /// Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("claystone")]
        public static LithologyType Claystone
        {
            get 
            {
                if (claystone == null)
                {
                    claystone = new LithologyType("claystone");
                    claystone.Description = "Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology.";
                    claystone.Version = "1.4.1.0";
                }
                return claystone;
            }
        }

        private static LithologyType coal;
        /// <summary>
        /// A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("coal")]
        public static LithologyType Coal
        {
            get 
            {
                if (coal == null)
                {
                    coal = new LithologyType("coal");
                    coal.Description = "A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.";
                    coal.Version = "1.3.1.1";
                }
                return coal;
            }
        }

        private static LithologyType conglomerate;
        /// <summary>
        /// Clastic sedimentary rock composed of at least 30 percent rounded to subangular fragments larger than 2 millimeter in diameter; typically contains finer grained material in interstices between larger fragments. If more than 15 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wackestone. If rock has unsorted or poorly sorted texture with a wide range of particle sizes, may also be categorized as diamictite. Neuendorf et al. 2005; SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("conglomerate")]
        public static LithologyType Conglomerate
        {
            get 
            {
                if (conglomerate == null)
                {
                    conglomerate = new LithologyType("conglomerate");
                    conglomerate.Description = "Clastic sedimentary rock composed of at least 30 percent rounded to subangular fragments larger than 2 millimeter in diameter; typically contains finer grained material in interstices between larger fragments. If more than 15 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wackestone. If rock has unsorted or poorly sorted texture with a wide range of particle sizes, may also be categorized as diamictite. Neuendorf et al. 2005; SLTTs 2004.";
                    conglomerate.Version = "1.4.1.0";
                }
                return conglomerate;
            }
        }

        private static LithologyType dacite;
        /// <summary>
        /// Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dacite")]
        public static LithologyType Dacite
        {
            get 
            {
                if (dacite == null)
                {
                    dacite = new LithologyType("dacite");
                    dacite.Description = "Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002.";
                    dacite.Version = "1.4.1.0";
                }
                return dacite;
            }
        }

        private static LithologyType diabase;
        /// <summary>
        /// Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite.
        /// </summary>
        [EnumValueNameAttribute("diabase")]
        public static LithologyType Diabase
        {
            get 
            {
                if (diabase == null)
                {
                    diabase = new LithologyType("diabase");
                    diabase.Description = "Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite.";
                    diabase.Version = "1.3.1.1";
                }
                return diabase;
            }
        }

        private static LithologyType diamictite;
        /// <summary>
        /// Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978.
        /// </summary>
        [EnumValueNameAttribute("diamictite")]
        public static LithologyType Diamictite
        {
            get 
            {
                if (diamictite == null)
                {
                    diamictite = new LithologyType("diamictite");
                    diamictite.Description = "Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978.";
                    diamictite.Version = "1.4.1.0";
                }
                return diamictite;
            }
        }

        private static LithologyType diorite;
        /// <summary>
        /// Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite.
        /// </summary>
        [EnumValueNameAttribute("diorite")]
        public static LithologyType Diorite
        {
            get 
            {
                if (diorite == null)
                {
                    diorite = new LithologyType("diorite");
                    diorite.Description = "Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite.";
                    diorite.Version = "1.3.1.1";
                }
                return diorite;
            }
        }

        private static LithologyType dioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dioritoid")]
        public static LithologyType Dioritoid
        {
            get 
            {
                if (dioritoid == null)
                {
                    dioritoid = new LithologyType("dioritoid");
                    dioritoid.Description = "Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002.";
                    dioritoid.Version = "1.4.1.0";
                }
                return dioritoid;
            }
        }

        private static LithologyType doleriticRock;
        /// <summary>
        /// Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("doleritic rock")]
        public static LithologyType DoleriticRock
        {
            get 
            {
                if (doleriticRock == null)
                {
                    doleriticRock = new LithologyType("doleritic rock");
                    doleriticRock.Description = "Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002.";
                    doleriticRock.Version = "1.4.1.0";
                }
                return doleriticRock;
            }
        }

        private static LithologyType dolomite;
        /// <summary>
        /// Pure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static LithologyType Dolomite
        {
            get 
            {
                if (dolomite == null)
                {
                    dolomite = new LithologyType("dolomite");
                    dolomite.Description = "Pure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.";
                    dolomite.Version = "1.4.1.0";
                }
                return dolomite;
            }
        }

        private static LithologyType dolomiteCalcareous;
        /// <summary>
        /// DEPRECATED. See "impure dolomite".
        /// </summary>
        [EnumValueNameAttribute("dolomite, calcareous")]
        public static LithologyType DolomiteCalcareous
        {
            get 
            {
                if (dolomiteCalcareous == null)
                {
                    dolomiteCalcareous = new LithologyType("dolomite, calcareous");
                    dolomiteCalcareous.Description = "DEPRECATED. See \"impure dolomite\".";
                    dolomiteCalcareous.Version = "1.3.1.1";
                    dolomiteCalcareous.Deprecated = "1.4.1.0";
                    dolomiteCalcareous.ReplacedBy = ImpureDolomite;
                }
                return dolomiteCalcareous;
            }
        }

        private static LithologyType eclogite;
        /// <summary>
        /// Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("eclogite")]
        public static LithologyType Eclogite
        {
            get 
            {
                if (eclogite == null)
                {
                    eclogite = new LithologyType("eclogite");
                    eclogite.Description = "Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007";
                    eclogite.Version = "1.4.1.0";
                }
                return eclogite;
            }
        }

        private static LithologyType exoticAlkalineRock;
        /// <summary>
        /// Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("exotic alkaline rock")]
        public static LithologyType ExoticAlkalineRock
        {
            get 
            {
                if (exoticAlkalineRock == null)
                {
                    exoticAlkalineRock = new LithologyType("exotic alkaline rock");
                    exoticAlkalineRock.Description = "Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002.";
                    exoticAlkalineRock.Version = "1.4.1.0";
                }
                return exoticAlkalineRock;
            }
        }

        private static LithologyType extrusiveRockVolcanic;
        /// <summary>
        /// DEPRECATED. See "fragmental igneous rock".
        /// </summary>
        [EnumValueNameAttribute("extrusive rock (volcanic)")]
        public static LithologyType ExtrusiveRockVolcanic
        {
            get 
            {
                if (extrusiveRockVolcanic == null)
                {
                    extrusiveRockVolcanic = new LithologyType("extrusive rock (volcanic)");
                    extrusiveRockVolcanic.Description = "DEPRECATED. See \"fragmental igneous rock\".";
                    extrusiveRockVolcanic.Version = "1.3.1.1";
                    extrusiveRockVolcanic.Deprecated = "1.4.1.0";
                    extrusiveRockVolcanic.ReplacedBy = FragmentalIgneousRock;
                }
                return extrusiveRockVolcanic;
            }
        }

        private static LithologyType feldspar;
        /// <summary>
        /// The family of aluminium silicates of sodium, potassium, calcium and other metals which comprise over 60% of the earth's crust, are the most abundant mineral group, and occur in all types of rocks.
        /// </summary>
        [EnumValueNameAttribute("feldspar")]
        public static LithologyType Feldspar
        {
            get 
            {
                if (feldspar == null)
                {
                    feldspar = new LithologyType("feldspar");
                    feldspar.Description = "The family of aluminium silicates of sodium, potassium, calcium and other metals which comprise over 60% of the earth's crust, are the most abundant mineral group, and occur in all types of rocks.";
                    feldspar.Version = "1.3.1.1";
                }
                return feldspar;
            }
        }

        private static LithologyType feldspathicArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("feldspathic arenite")]
        public static LithologyType FeldspathicArenite
        {
            get 
            {
                if (feldspathicArenite == null)
                {
                    feldspathicArenite = new LithologyType("feldspathic arenite");
                    feldspathicArenite.Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.";
                    feldspathicArenite.Version = "1.4.1.0";
                }
                return feldspathicArenite;
            }
        }

        private static LithologyType fineGrainedIgneousRock;
        /// <summary>
        /// Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("fine grained igneous rock")]
        public static LithologyType FineGrainedIgneousRock
        {
            get 
            {
                if (fineGrainedIgneousRock == null)
                {
                    fineGrainedIgneousRock = new LithologyType("fine grained igneous rock");
                    fineGrainedIgneousRock.Description = "Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002.";
                    fineGrainedIgneousRock.Version = "1.4.1.0";
                }
                return fineGrainedIgneousRock;
            }
        }

        private static LithologyType foidDioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid dioritoid")]
        public static LithologyType FoidDioritoid
        {
            get 
            {
                if (foidDioritoid == null)
                {
                    foidDioritoid = new LithologyType("foid dioritoid");
                    foidDioritoid.Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.";
                    foidDioritoid.Version = "1.4.1.0";
                }
                return foidDioritoid;
            }
        }

        private static LithologyType foidGabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid gabbroid")]
        public static LithologyType FoidGabbroid
        {
            get 
            {
                if (foidGabbroid == null)
                {
                    foidGabbroid = new LithologyType("foid gabbroid");
                    foidGabbroid.Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.";
                    foidGabbroid.Version = "1.4.1.0";
                }
                return foidGabbroid;
            }
        }

        private static LithologyType foidSyenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid syenitoid")]
        public static LithologyType FoidSyenitoid
        {
            get 
            {
                if (foidSyenitoid == null)
                {
                    foidSyenitoid = new LithologyType("foid syenitoid");
                    foidSyenitoid.Description = "Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002.";
                    foidSyenitoid.Version = "1.4.1.0";
                }
                return foidSyenitoid;
            }
        }

        private static LithologyType foidite;
        /// <summary>
        /// Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidite")]
        public static LithologyType Foidite
        {
            get 
            {
                if (foidite == null)
                {
                    foidite = new LithologyType("foidite");
                    foidite.Description = "Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002.";
                    foidite.Version = "1.4.1.0";
                }
                return foidite;
            }
        }

        private static LithologyType foiditoid;
        /// <summary>
        /// Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foiditoid")]
        public static LithologyType Foiditoid
        {
            get 
            {
                if (foiditoid == null)
                {
                    foiditoid = new LithologyType("foiditoid");
                    foiditoid.Description = "Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002.";
                    foiditoid.Version = "1.4.1.0";
                }
                return foiditoid;
            }
        }

        private static LithologyType foidolite;
        /// <summary>
        /// Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidolite")]
        public static LithologyType Foidolite
        {
            get 
            {
                if (foidolite == null)
                {
                    foidolite = new LithologyType("foidolite");
                    foidolite.Description = "Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002.";
                    foidolite.Version = "1.4.1.0";
                }
                return foidolite;
            }
        }

        private static LithologyType foliatedMetamorphicRock;
        /// <summary>
        /// Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic.
        /// </summary>
        [EnumValueNameAttribute("foliated metamorphic rock")]
        public static LithologyType FoliatedMetamorphicRock
        {
            get 
            {
                if (foliatedMetamorphicRock == null)
                {
                    foliatedMetamorphicRock = new LithologyType("foliated metamorphic rock");
                    foliatedMetamorphicRock.Description = "Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic.";
                    foliatedMetamorphicRock.Version = "1.4.1.0";
                }
                return foliatedMetamorphicRock;
            }
        }

        private static LithologyType fragmentalIgneousRock;
        /// <summary>
        /// Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite).
        /// </summary>
        [EnumValueNameAttribute("fragmental igneous rock")]
        public static LithologyType FragmentalIgneousRock
        {
            get 
            {
                if (fragmentalIgneousRock == null)
                {
                    fragmentalIgneousRock = new LithologyType("fragmental igneous rock");
                    fragmentalIgneousRock.Description = "Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite).";
                    fragmentalIgneousRock.Version = "1.4.1.0";
                }
                return fragmentalIgneousRock;
            }
        }

        private static LithologyType gabbro;
        /// <summary>
        /// Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbro")]
        public static LithologyType Gabbro
        {
            get 
            {
                if (gabbro == null)
                {
                    gabbro = new LithologyType("gabbro");
                    gabbro.Description = "Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002.";
                    gabbro.Version = "1.4.1.0";
                }
                return gabbro;
            }
        }

        private static LithologyType gabbroicRock;
        /// <summary>
        /// Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroic rock")]
        public static LithologyType GabbroicRock
        {
            get 
            {
                if (gabbroicRock == null)
                {
                    gabbroicRock = new LithologyType("gabbroic rock");
                    gabbroicRock.Description = "Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002.";
                    gabbroicRock.Version = "1.4.1.0";
                }
                return gabbroicRock;
            }
        }

        private static LithologyType gabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroid")]
        public static LithologyType Gabbroid
        {
            get 
            {
                if (gabbroid == null)
                {
                    gabbroid = new LithologyType("gabbroid");
                    gabbroid.Description = "Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002.";
                    gabbroid.Version = "1.4.1.0";
                }
                return gabbroid;
            }
        }

        private static LithologyType glauconite;
        /// <summary>
        /// A mineral composed of ferrous potassium silicates related to mica which commonly imparts a green color to its sedimentary host rock.
        /// </summary>
        [EnumValueNameAttribute("glauconite")]
        public static LithologyType Glauconite
        {
            get 
            {
                if (glauconite == null)
                {
                    glauconite = new LithologyType("glauconite");
                    glauconite.Description = "A mineral composed of ferrous potassium silicates related to mica which commonly imparts a green color to its sedimentary host rock.";
                    glauconite.Version = "1.3.1.1";
                }
                return glauconite;
            }
        }

        private static LithologyType gneiss;
        /// <summary>
        /// Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("gneiss")]
        public static LithologyType Gneiss
        {
            get 
            {
                if (gneiss == null)
                {
                    gneiss = new LithologyType("gneiss");
                    gneiss.Description = "Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005.";
                    gneiss.Version = "1.4.1.0";
                }
                return gneiss;
            }
        }

        private static LithologyType granite;
        /// <summary>
        /// Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granite")]
        public static LithologyType Granite
        {
            get 
            {
                if (granite == null)
                {
                    granite = new LithologyType("granite");
                    granite.Description = "Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002.";
                    granite.Version = "1.4.1.0";
                }
                return granite;
            }
        }

        private static LithologyType granodiorite;
        /// <summary>
        /// Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granodiorite")]
        public static LithologyType Granodiorite
        {
            get 
            {
                if (granodiorite == null)
                {
                    granodiorite = new LithologyType("granodiorite");
                    granodiorite.Description = "Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002.";
                    granodiorite.Version = "1.4.1.0";
                }
                return granodiorite;
            }
        }

        private static LithologyType granofels;
        /// <summary>
        /// Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004.
        /// </summary>
        [EnumValueNameAttribute("granofels")]
        public static LithologyType Granofels
        {
            get 
            {
                if (granofels == null)
                {
                    granofels = new LithologyType("granofels");
                    granofels.Description = "Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004.";
                    granofels.Version = "1.4.1.0";
                }
                return granofels;
            }
        }

        private static LithologyType granulite;
        /// <summary>
        /// Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2
        /// </summary>
        [EnumValueNameAttribute("granulite")]
        public static LithologyType Granulite
        {
            get 
            {
                if (granulite == null)
                {
                    granulite = new LithologyType("granulite");
                    granulite.Description = "Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2";
                    granulite.Version = "1.4.1.0";
                }
                return granulite;
            }
        }

        private static LithologyType gravel;
        /// <summary>
        /// Clastic sediment containing greater than 30 percent gravel-size particles (greater than 2.0 millimeter diameter). Gravel in which more than half of the particles are of epiclastic origin.definition of gravel from SLTTs 2004; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("gravel")]
        public static LithologyType Gravel
        {
            get 
            {
                if (gravel == null)
                {
                    gravel = new LithologyType("gravel");
                    gravel.Description = "Clastic sediment containing greater than 30 percent gravel-size particles (greater than 2.0 millimeter diameter). Gravel in which more than half of the particles are of epiclastic origin.definition of gravel from SLTTs 2004; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).";
                    gravel.Version = "1.4.1.0";
                }
                return gravel;
            }
        }

        private static LithologyType greenstone;
        /// <summary>
        /// Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone.
        /// </summary>
        [EnumValueNameAttribute("greenstone")]
        public static LithologyType Greenstone
        {
            get 
            {
                if (greenstone == null)
                {
                    greenstone = new LithologyType("greenstone");
                    greenstone.Description = "Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone.";
                    greenstone.Version = "1.4.1.0";
                }
                return greenstone;
            }
        }

        private static LithologyType greenstones;
        /// <summary>
        /// DEPRECATED. See "greenstone".
        /// </summary>
        [EnumValueNameAttribute("greenstones")]
        public static LithologyType Greenstones
        {
            get 
            {
                if (greenstones == null)
                {
                    greenstones = new LithologyType("greenstones");
                    greenstones.Description = "DEPRECATED. See \"greenstone\".";
                    greenstones.Version = "1.3.1.1";
                    greenstones.Deprecated = "1.4.1.0";
                    greenstones.ReplacedBy = Greenstone;
                }
                return greenstones;
            }
        }

        private static LithologyType greywacke;
        /// <summary>
        /// DEPRECATED. See "wacke".
        /// </summary>
        [EnumValueNameAttribute("greywacke")]
        public static LithologyType Greywacke
        {
            get 
            {
                if (greywacke == null)
                {
                    greywacke = new LithologyType("greywacke");
                    greywacke.Description = "DEPRECATED. See \"wacke\".";
                    greywacke.Version = "1.3.1.1";
                    greywacke.Deprecated = "1.4.1.0";
                    greywacke.ReplacedBy = Wacke;
                }
                return greywacke;
            }
        }

        private static LithologyType gumbo;
        /// <summary>
        /// A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet.
        /// </summary>
        [EnumValueNameAttribute("gumbo")]
        public static LithologyType Gumbo
        {
            get 
            {
                if (gumbo == null)
                {
                    gumbo = new LithologyType("gumbo");
                    gumbo.Description = "A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet.";
                    gumbo.Version = "1.3.1.1";
                }
                return gumbo;
            }
        }

        private static LithologyType gypsum;
        /// <summary>
        /// Evaporite composed of at least 50 percent gypsum . OneGeology / WITSML
        /// </summary>
        [EnumValueNameAttribute("gypsum")]
        public static LithologyType Gypsum
        {
            get 
            {
                if (gypsum == null)
                {
                    gypsum = new LithologyType("gypsum");
                    gypsum.Description = "Evaporite composed of at least 50 percent gypsum . OneGeology / WITSML";
                    gypsum.Version = "1.4.1.0";
                }
                return gypsum;
            }
        }

        private static LithologyType halite;
        /// <summary>
        /// Evaporite composed of at least 90 percent halite.(NaCl). Use Rock Salt if unclear on chemical composition. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static LithologyType Halite
        {
            get 
            {
                if (halite == null)
                {
                    halite = new LithologyType("halite");
                    halite.Description = "Evaporite composed of at least 90 percent halite.(NaCl). Use Rock Salt if unclear on chemical composition. OneGeology.";
                    halite.Version = "1.4.1.0";
                }
                return halite;
            }
        }

        private static LithologyType hornfels;
        /// <summary>
        /// Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained.
        /// </summary>
        [EnumValueNameAttribute("hornfels")]
        public static LithologyType Hornfels
        {
            get 
            {
                if (hornfels == null)
                {
                    hornfels = new LithologyType("hornfels");
                    hornfels.Description = "Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained.";
                    hornfels.Version = "1.4.1.0";
                }
                return hornfels;
            }
        }

        private static LithologyType igneous;
        /// <summary>
        /// DEPRECATED. See "igneous rock".
        /// </summary>
        [EnumValueNameAttribute("igneous")]
        public static LithologyType Igneous
        {
            get 
            {
                if (igneous == null)
                {
                    igneous = new LithologyType("igneous");
                    igneous.Description = "DEPRECATED. See \"igneous rock\".";
                    igneous.Version = "1.3.1.1";
                    igneous.Deprecated = "1.4.1.0";
                    igneous.ReplacedBy = IgneousRock;
                }
                return igneous;
            }
        }

        private static LithologyType igneousRock;
        /// <summary>
        /// Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("igneous rock")]
        public static LithologyType IgneousRock
        {
            get 
            {
                if (igneousRock == null)
                {
                    igneousRock = new LithologyType("igneous rock");
                    igneousRock.Description = "Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005.";
                    igneousRock.Version = "1.4.1.0";
                }
                return igneousRock;
            }
        }

        private static LithologyType impactGeneratedMaterial;
        /// <summary>
        /// Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("impact generated material")]
        public static LithologyType ImpactGeneratedMaterial
        {
            get 
            {
                if (impactGeneratedMaterial == null)
                {
                    impactGeneratedMaterial = new LithologyType("impact generated material");
                    impactGeneratedMaterial.Description = "Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997.";
                    impactGeneratedMaterial.Version = "1.4.1.0";
                }
                return impactGeneratedMaterial;
            }
        }

        private static LithologyType impureDolomite;
        /// <summary>
        /// Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure dolomite")]
        public static LithologyType ImpureDolomite
        {
            get 
            {
                if (impureDolomite == null)
                {
                    impureDolomite = new LithologyType("impure dolomite");
                    impureDolomite.Description = "Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.";
                    impureDolomite.Version = "1.4.1.0";
                }
                return impureDolomite;
            }
        }

        private static LithologyType impureLimestone;
        /// <summary>
        /// Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure limestone")]
        public static LithologyType ImpureLimestone
        {
            get 
            {
                if (impureLimestone == null)
                {
                    impureLimestone = new LithologyType("impure limestone");
                    impureLimestone.Description = "Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology.";
                    impureLimestone.Version = "1.4.1.0";
                }
                return impureLimestone;
            }
        }

        private static LithologyType intrusiveRockPlutonic;
        /// <summary>
        /// Igneous rock formed by cooling and solidification of magma within the earth's crust.
        /// </summary>
        [EnumValueNameAttribute("intrusive rock (plutonic)")]
        public static LithologyType IntrusiveRockPlutonic
        {
            get 
            {
                if (intrusiveRockPlutonic == null)
                {
                    intrusiveRockPlutonic = new LithologyType("intrusive rock (plutonic)");
                    intrusiveRockPlutonic.Description = "Igneous rock formed by cooling and solidification of magma within the earth's crust.";
                    intrusiveRockPlutonic.Version = "1.3.1.1";
                }
                return intrusiveRockPlutonic;
            }
        }

        private static LithologyType ironRichSedimentaryRock;
        /// <summary>
        /// Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("iron rich sedimentary rock")]
        public static LithologyType IronRichSedimentaryRock
        {
            get 
            {
                if (ironRichSedimentaryRock == null)
                {
                    ironRichSedimentaryRock = new LithologyType("iron rich sedimentary rock");
                    ironRichSedimentaryRock.Description = "Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004.";
                    ironRichSedimentaryRock.Version = "1.4.1.0";
                }
                return ironRichSedimentaryRock;
            }
        }

        private static LithologyType kalsiliticAndMeliliticRocks;
        /// <summary>
        /// Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("kalsilitic and melilitic rocks")]
        public static LithologyType KalsiliticAndMeliliticRocks
        {
            get 
            {
                if (kalsiliticAndMeliliticRocks == null)
                {
                    kalsiliticAndMeliliticRocks = new LithologyType("kalsilitic and melilitic rocks");
                    kalsiliticAndMeliliticRocks.Description = "Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002.";
                    kalsiliticAndMeliliticRocks.Version = "1.4.1.0";
                }
                return kalsiliticAndMeliliticRocks;
            }
        }

        private static LithologyType komatiiticRock;
        /// <summary>
        /// Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("komatiitic rock")]
        public static LithologyType KomatiiticRock
        {
            get 
            {
                if (komatiiticRock == null)
                {
                    komatiiticRock = new LithologyType("komatiitic rock");
                    komatiiticRock.Description = "Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002.";
                    komatiiticRock.Version = "1.4.1.0";
                }
                return komatiiticRock;
            }
        }

        private static LithologyType latiticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("latitic rock")]
        public static LithologyType LatiticRock
        {
            get 
            {
                if (latiticRock == null)
                {
                    latiticRock = new LithologyType("latitic rock");
                    latiticRock.Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002.";
                    latiticRock.Version = "1.4.1.0";
                }
                return latiticRock;
            }
        }

        private static LithologyType lignite;
        /// <summary>
        /// Coal that has a gross calorific value less than 24 MJ/kg (determined in conformance with ISO 1928), and vitrinite mean random reflectance less than 0.6 percent (determined in conformance with ISO 7404-5). Gross calorific value is recalculated to a moist, ash free basis using bed moisture (determined according to ISO 1015 or ISO 5068). Includes all low-rank coals, including sub-bitiminous coal. A consolidated, dull, soft brown to black coal having many readily discernible plant fragments set in a finer grained organic matrix. Tends to crack and fall apart on drying. Operationally sub-bituminous and bitiminous coal are qualitatively distinguished based on brown streak for sub-bitiminous coal and black streak for bituminous coal. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static LithologyType Lignite
        {
            get 
            {
                if (lignite == null)
                {
                    lignite = new LithologyType("lignite");
                    lignite.Description = "Coal that has a gross calorific value less than 24 MJ/kg (determined in conformance with ISO 1928), and vitrinite mean random reflectance less than 0.6 percent (determined in conformance with ISO 7404-5). Gross calorific value is recalculated to a moist, ash free basis using bed moisture (determined according to ISO 1015 or ISO 5068). Includes all low-rank coals, including sub-bitiminous coal. A consolidated, dull, soft brown to black coal having many readily discernible plant fragments set in a finer grained organic matrix. Tends to crack and fall apart on drying. Operationally sub-bituminous and bitiminous coal are qualitatively distinguished based on brown streak for sub-bitiminous coal and black streak for bituminous coal. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.";
                    lignite.Version = "1.4.1.0";
                }
                return lignite;
            }
        }

        private static LithologyType limeBoundstone;
        /// <summary>
        /// Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime boundstone")]
        public static LithologyType LimeBoundstone
        {
            get 
            {
                if (limeBoundstone == null)
                {
                    limeBoundstone = new LithologyType("lime boundstone");
                    limeBoundstone.Description = "Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limeBoundstone.Version = "1.4.1.0";
                }
                return limeBoundstone;
            }
        }

        private static LithologyType limeFramestone;
        /// <summary>
        /// Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth &amp; Knox 1999; SLTTs 2004, Table 15-3-1
        /// </summary>
        [EnumValueNameAttribute("lime framestone")]
        public static LithologyType LimeFramestone
        {
            get 
            {
                if (limeFramestone == null)
                {
                    limeFramestone = new LithologyType("lime framestone");
                    limeFramestone.Description = "Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth & Knox 1999; SLTTs 2004, Table 15-3-1";
                    limeFramestone.Version = "1.4.1.0";
                }
                return limeFramestone;
            }
        }

        private static LithologyType limeGrainstone;
        /// <summary>
        /// Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime grainstone")]
        public static LithologyType LimeGrainstone
        {
            get 
            {
                if (limeGrainstone == null)
                {
                    limeGrainstone = new LithologyType("lime grainstone");
                    limeGrainstone.Description = "Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limeGrainstone.Version = "1.4.1.0";
                }
                return limeGrainstone;
            }
        }

        private static LithologyType limeMudstone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary.
        /// </summary>
        [EnumValueNameAttribute("lime mudstone")]
        public static LithologyType LimeMudstone
        {
            get 
            {
                if (limeMudstone == null)
                {
                    limeMudstone = new LithologyType("lime mudstone");
                    limeMudstone.Description = "Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary.";
                    limeMudstone.Version = "1.4.1.0";
                }
                return limeMudstone;
            }
        }

        private static LithologyType limePackstone;
        /// <summary>
        /// Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime packstone")]
        public static LithologyType LimePackstone
        {
            get 
            {
                if (limePackstone == null)
                {
                    limePackstone = new LithologyType("lime packstone");
                    limePackstone.Description = "Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limePackstone.Version = "1.4.1.0";
                }
                return limePackstone;
            }
        }

        private static LithologyType limeWackestone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime wackestone")]
        public static LithologyType LimeWackestone
        {
            get 
            {
                if (limeWackestone == null)
                {
                    limeWackestone = new LithologyType("lime wackestone");
                    limeWackestone.Description = "Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limeWackestone.Version = "1.4.1.0";
                }
                return limeWackestone;
            }
        }

        private static LithologyType limestone;
        /// <summary>
        /// Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("limestone")]
        public static LithologyType Limestone
        {
            get 
            {
                if (limestone == null)
                {
                    limestone = new LithologyType("limestone");
                    limestone.Description = "Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology.";
                    limestone.Version = "1.4.1.0";
                }
                return limestone;
            }
        }

        private static LithologyType limestoneArgillaceous;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% clay minerals.
        /// </summary>
        [EnumValueNameAttribute("limestone, argillaceous")]
        public static LithologyType LimestoneArgillaceous
        {
            get 
            {
                if (limestoneArgillaceous == null)
                {
                    limestoneArgillaceous = new LithologyType("limestone, argillaceous");
                    limestoneArgillaceous.Description = "A limestone homogeneously mixed with 10-50% clay minerals.";
                    limestoneArgillaceous.Version = "1.3.1.1";
                }
                return limestoneArgillaceous;
            }
        }

        private static LithologyType limestoneDolomitic;
        /// <summary>
        /// A limestone containing 10-50% dolomite and 50-90% calcite.
        /// </summary>
        [EnumValueNameAttribute("limestone, dolomitic")]
        public static LithologyType LimestoneDolomitic
        {
            get 
            {
                if (limestoneDolomitic == null)
                {
                    limestoneDolomitic = new LithologyType("limestone, dolomitic");
                    limestoneDolomitic.Description = "A limestone containing 10-50% dolomite and 50-90% calcite.";
                    limestoneDolomitic.Version = "1.3.1.1";
                }
                return limestoneDolomitic;
            }
        }

        private static LithologyType limestoneSandy;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% quartz grains.
        /// </summary>
        [EnumValueNameAttribute("limestone, sandy")]
        public static LithologyType LimestoneSandy
        {
            get 
            {
                if (limestoneSandy == null)
                {
                    limestoneSandy = new LithologyType("limestone, sandy");
                    limestoneSandy.Description = "A limestone homogeneously mixed with 10-50% quartz grains.";
                    limestoneSandy.Version = "1.3.1.1";
                }
                return limestoneSandy;
            }
        }

        private static LithologyType marble;
        /// <summary>
        /// Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("marble")]
        public static LithologyType Marble
        {
            get 
            {
                if (marble == null)
                {
                    marble = new LithologyType("marble");
                    marble.Description = "Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007";
                    marble.Version = "1.4.1.0";
                }
                return marble;
            }
        }

        private static LithologyType marl;
        /// <summary>
        /// A consolidated or semi-consolidated mixture of clay and generally fine grained carbonate material.
        /// </summary>
        [EnumValueNameAttribute("marl")]
        public static LithologyType Marl
        {
            get 
            {
                if (marl == null)
                {
                    marl = new LithologyType("marl");
                    marl.Description = "A consolidated or semi-consolidated mixture of clay and generally fine grained carbonate material.";
                    marl.Version = "1.3.1.1";
                }
                return marl;
            }
        }

        private static LithologyType metamorphicRock;
        /// <summary>
        /// Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("metamorphic rock")]
        public static LithologyType MetamorphicRock
        {
            get 
            {
                if (metamorphicRock == null)
                {
                    metamorphicRock = new LithologyType("metamorphic rock");
                    metamorphicRock.Description = "Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997.";
                    metamorphicRock.Version = "1.4.1.0";
                }
                return metamorphicRock;
            }
        }

        private static LithologyType metamorphicRocks;
        /// <summary>
        /// DEPRECATED. See "metamorphic rock".
        /// </summary>
        [EnumValueNameAttribute("metamorphic rocks")]
        public static LithologyType MetamorphicRocks
        {
            get 
            {
                if (metamorphicRocks == null)
                {
                    metamorphicRocks = new LithologyType("metamorphic rocks");
                    metamorphicRocks.Description = "DEPRECATED. See \"metamorphic rock\".";
                    metamorphicRocks.Version = "1.3.1.1";
                    metamorphicRocks.Deprecated = "1.4.1.0";
                    metamorphicRocks.ReplacedBy = MetamorphicRock;
                }
                return metamorphicRocks;
            }
        }

        private static LithologyType micaSchist;
        /// <summary>
        /// A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("mica schist")]
        public static LithologyType MicaSchist
        {
            get 
            {
                if (micaSchist == null)
                {
                    micaSchist = new LithologyType("mica schist");
                    micaSchist.Description = "A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology.";
                    micaSchist.Version = "1.4.1.0";
                }
                return micaSchist;
            }
        }

        private static LithologyType migmatite;
        /// <summary>
        /// Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)
        /// </summary>
        [EnumValueNameAttribute("migmatite")]
        public static LithologyType Migmatite
        {
            get 
            {
                if (migmatite == null)
                {
                    migmatite = new LithologyType("migmatite");
                    migmatite.Description = "Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)";
                    migmatite.Version = "1.4.1.0";
                }
                return migmatite;
            }
        }

        private static LithologyType monzogabbro;
        /// <summary>
        /// Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("monzogabbro")]
        public static LithologyType Monzogabbro
        {
            get 
            {
                if (monzogabbro == null)
                {
                    monzogabbro = new LithologyType("monzogabbro");
                    monzogabbro.Description = "Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002.";
                    monzogabbro.Version = "1.4.1.0";
                }
                return monzogabbro;
            }
        }

        private static LithologyType mud;
        /// <summary>
        /// Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("mud")]
        public static LithologyType Mud
        {
            get 
            {
                if (mud == null)
                {
                    mud = new LithologyType("mud");
                    mud.Description = "Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).";
                    mud.Version = "1.4.1.0";
                }
                return mud;
            }
        }

        private static LithologyType mudstone;
        /// <summary>
        /// Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth &amp; Knox 1999; extrapolated from Folk, 1954, Figure 1a.
        /// </summary>
        [EnumValueNameAttribute("mudstone")]
        public static LithologyType Mudstone
        {
            get 
            {
                if (mudstone == null)
                {
                    mudstone = new LithologyType("mudstone");
                    mudstone.Description = "Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth & Knox 1999; extrapolated from Folk, 1954, Figure 1a.";
                    mudstone.Version = "1.4.1.0";
                }
                return mudstone;
            }
        }

        private static LithologyType myloniticRock;
        /// <summary>
        /// Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak &amp; Mitra 1988.
        /// </summary>
        [EnumValueNameAttribute("mylonitic rock")]
        public static LithologyType MyloniticRock
        {
            get 
            {
                if (myloniticRock == null)
                {
                    myloniticRock = new LithologyType("mylonitic rock");
                    myloniticRock.Description = "Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak & Mitra 1988.";
                    myloniticRock.Version = "1.4.1.0";
                }
                return myloniticRock;
            }
        }

        private static LithologyType noDescription;
        /// <summary>
        /// No description is provided.
        /// </summary>
        [EnumValueNameAttribute("no description")]
        public static LithologyType NoDescription
        {
            get 
            {
                if (noDescription == null)
                {
                    noDescription = new LithologyType("no description");
                    noDescription.Description = "No description is provided.";
                    noDescription.Version = "1.3.1.1";
                }
                return noDescription;
            }
        }

        private static LithologyType noSample;
        /// <summary>
        /// A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML.
        /// </summary>
        [EnumValueNameAttribute("no sample")]
        public static LithologyType NoSample
        {
            get 
            {
                if (noSample == null)
                {
                    noSample = new LithologyType("no sample");
                    noSample.Description = "A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML.";
                    noSample.Version = "1.4.1.0";
                }
                return noSample;
            }
        }

        private static LithologyType ooze;
        /// <summary>
        /// Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 &amp; Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("ooze")]
        public static LithologyType Ooze
        {
            get 
            {
                if (ooze == null)
                {
                    ooze = new LithologyType("ooze");
                    ooze.Description = "Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 & Hallsworth & Knox 1999.";
                    ooze.Version = "1.4.1.0";
                }
                return ooze;
            }
        }

        private static LithologyType ophiolite;
        /// <summary>
        /// Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust.
        /// </summary>
        [EnumValueNameAttribute("ophiolite")]
        public static LithologyType Ophiolite
        {
            get 
            {
                if (ophiolite == null)
                {
                    ophiolite = new LithologyType("ophiolite");
                    ophiolite.Description = "Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust.";
                    ophiolite.Version = "1.3.1.1";
                }
                return ophiolite;
            }
        }

        private static LithologyType organicBearingMudstone;
        /// <summary>
        /// Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;
        /// </summary>
        [EnumValueNameAttribute("organic bearing mudstone")]
        public static LithologyType OrganicBearingMudstone
        {
            get 
            {
                if (organicBearingMudstone == null)
                {
                    organicBearingMudstone = new LithologyType("organic bearing mudstone");
                    organicBearingMudstone.Description = "Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;";
                    organicBearingMudstone.Version = "1.4.1.0";
                }
                return organicBearingMudstone;
            }
        }

        private static LithologyType peat;
        /// <summary>
        /// Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("peat")]
        public static LithologyType Peat
        {
            get 
            {
                if (peat == null)
                {
                    peat = new LithologyType("peat");
                    peat.Description = "Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth & Knox 1999.";
                    peat.Version = "1.4.1.0";
                }
                return peat;
            }
        }

        private static LithologyType pegmatite;
        /// <summary>
        /// Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("pegmatite")]
        public static LithologyType Pegmatite
        {
            get 
            {
                if (pegmatite == null)
                {
                    pegmatite = new LithologyType("pegmatite");
                    pegmatite.Description = "Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005.";
                    pegmatite.Version = "1.4.1.0";
                }
                return pegmatite;
            }
        }

        private static LithologyType peridotite;
        /// <summary>
        /// Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("peridotite")]
        public static LithologyType Peridotite
        {
            get 
            {
                if (peridotite == null)
                {
                    peridotite = new LithologyType("peridotite");
                    peridotite.Description = "Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002.";
                    peridotite.Version = "1.4.1.0";
                }
                return peridotite;
            }
        }

        private static LithologyType phaneriticIgneousRock;
        /// <summary>
        /// Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("phaneritic igneous rock")]
        public static LithologyType PhaneriticIgneousRock
        {
            get 
            {
                if (phaneriticIgneousRock == null)
                {
                    phaneriticIgneousRock = new LithologyType("phaneritic igneous rock");
                    phaneriticIgneousRock.Description = "Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005.";
                    phaneriticIgneousRock.Version = "1.4.1.0";
                }
                return phaneriticIgneousRock;
            }
        }

        private static LithologyType phonolite;
        /// <summary>
        /// Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolite")]
        public static LithologyType Phonolite
        {
            get 
            {
                if (phonolite == null)
                {
                    phonolite = new LithologyType("phonolite");
                    phonolite.Description = "Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002.";
                    phonolite.Version = "1.4.1.0";
                }
                return phonolite;
            }
        }

        private static LithologyType phonolitoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolitoid")]
        public static LithologyType Phonolitoid
        {
            get 
            {
                if (phonolitoid == null)
                {
                    phonolitoid = new LithologyType("phonolitoid");
                    phonolitoid.Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002.";
                    phonolitoid.Version = "1.4.1.0";
                }
                return phonolitoid;
            }
        }

        private static LithologyType phosphate;
        /// <summary>
        /// Any mineral compound containing the ((PO4)3) radical.
        /// </summary>
        [EnumValueNameAttribute("phosphate")]
        public static LithologyType Phosphate
        {
            get 
            {
                if (phosphate == null)
                {
                    phosphate = new LithologyType("phosphate");
                    phosphate.Description = "Any mineral compound containing the ((PO4)3) radical.";
                    phosphate.Version = "1.3.1.1";
                }
                return phosphate;
            }
        }

        private static LithologyType phosphateRock;
        /// <summary>
        /// Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource.
        /// </summary>
        [EnumValueNameAttribute("phosphate rock")]
        public static LithologyType PhosphateRock
        {
            get 
            {
                if (phosphateRock == null)
                {
                    phosphateRock = new LithologyType("phosphate rock");
                    phosphateRock.Description = "Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource.";
                    phosphateRock.Version = "1.3.1.1";
                }
                return phosphateRock;
            }
        }

        private static LithologyType phyllite;
        /// <summary>
        /// Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007.
        /// </summary>
        [EnumValueNameAttribute("phyllite")]
        public static LithologyType Phyllite
        {
            get 
            {
                if (phyllite == null)
                {
                    phyllite = new LithologyType("phyllite");
                    phyllite.Description = "Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007.";
                    phyllite.Version = "1.4.1.0";
                }
                return phyllite;
            }
        }

        private static LithologyType porphyry;
        /// <summary>
        /// Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("porphyry")]
        public static LithologyType Porphyry
        {
            get 
            {
                if (porphyry == null)
                {
                    porphyry = new LithologyType("porphyry");
                    porphyry.Description = "Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002.";
                    porphyry.Version = "1.4.1.0";
                }
                return porphyry;
            }
        }

        private static LithologyType potassiumAndMagnesiumSalts;
        /// <summary>
        /// Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML.
        /// </summary>
        [EnumValueNameAttribute("potassium and magnesium salts")]
        public static LithologyType PotassiumAndMagnesiumSalts
        {
            get 
            {
                if (potassiumAndMagnesiumSalts == null)
                {
                    potassiumAndMagnesiumSalts = new LithologyType("potassium and magnesium salts");
                    potassiumAndMagnesiumSalts.Description = "Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML.";
                    potassiumAndMagnesiumSalts.Version = "1.4.1.0";
                }
                return potassiumAndMagnesiumSalts;
            }
        }

        private static LithologyType pyroclasticBreccia;
        /// <summary>
        /// Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic breccia")]
        public static LithologyType PyroclasticBreccia
        {
            get 
            {
                if (pyroclasticBreccia == null)
                {
                    pyroclasticBreccia = new LithologyType("pyroclastic breccia");
                    pyroclasticBreccia.Description = "Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002.";
                    pyroclasticBreccia.Version = "1.4.1.0";
                }
                return pyroclasticBreccia;
            }
        }

        private static LithologyType pyroclasticRock;
        /// <summary>
        /// Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic rock")]
        public static LithologyType PyroclasticRock
        {
            get 
            {
                if (pyroclasticRock == null)
                {
                    pyroclasticRock = new LithologyType("pyroclastic rock");
                    pyroclasticRock.Description = "Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002.";
                    pyroclasticRock.Version = "1.4.1.0";
                }
                return pyroclasticRock;
            }
        }

        private static LithologyType pyroxenite;
        /// <summary>
        /// Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroxenite")]
        public static LithologyType Pyroxenite
        {
            get 
            {
                if (pyroxenite == null)
                {
                    pyroxenite = new LithologyType("pyroxenite");
                    pyroxenite.Description = "Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002.";
                    pyroxenite.Version = "1.4.1.0";
                }
                return pyroxenite;
            }
        }

        private static LithologyType quartzArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("quartz arenite")]
        public static LithologyType QuartzArenite
        {
            get 
            {
                if (quartzArenite == null)
                {
                    quartzArenite = new LithologyType("quartz arenite");
                    quartzArenite.Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.";
                    quartzArenite.Version = "1.4.1.0";
                }
                return quartzArenite;
            }
        }

        private static LithologyType quartzite;
        /// <summary>
        /// Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("quartzite")]
        public static LithologyType Quartzite
        {
            get 
            {
                if (quartzite == null)
                {
                    quartzite = new LithologyType("quartzite");
                    quartzite.Description = "Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005.";
                    quartzite.Version = "1.4.1.0";
                }
                return quartzite;
            }
        }

        private static LithologyType rhyolite;
        /// <summary>
        /// rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("rhyolite")]
        public static LithologyType Rhyolite
        {
            get 
            {
                if (rhyolite == null)
                {
                    rhyolite = new LithologyType("rhyolite");
                    rhyolite.Description = "rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002.";
                    rhyolite.Version = "1.4.1.0";
                }
                return rhyolite;
            }
        }

        private static LithologyType rockSalt;
        /// <summary>
        /// Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("rock salt")]
        public static LithologyType RockSalt
        {
            get 
            {
                if (rockSalt == null)
                {
                    rockSalt = new LithologyType("rock salt");
                    rockSalt.Description = "Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology.";
                    rockSalt.Version = "1.4.1.0";
                }
                return rockSalt;
            }
        }

        private static LithologyType salt;
        /// <summary>
        /// DEPRECATED. See "rock salt".
        /// </summary>
        [EnumValueNameAttribute("salt")]
        public static LithologyType Salt
        {
            get 
            {
                if (salt == null)
                {
                    salt = new LithologyType("salt");
                    salt.Description = "DEPRECATED. See \"rock salt\".";
                    salt.Version = "1.3.1.1";
                    salt.Deprecated = "1.4.1.0";
                    salt.ReplacedBy = RockSalt;
                }
                return salt;
            }
        }

        private static LithologyType sand;
        /// <summary>
        /// Clastic sediment in which less than 30 percent of particles are gravel (greater than 2 millimeter in diameter) and the sand to mud ratio is at least 1. More than half of the particles are of epiclastic origin.definition of sand from SLTTs 2004 sandy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("sand")]
        public static LithologyType Sand
        {
            get 
            {
                if (sand == null)
                {
                    sand = new LithologyType("sand");
                    sand.Description = "Clastic sediment in which less than 30 percent of particles are gravel (greater than 2 millimeter in diameter) and the sand to mud ratio is at least 1. More than half of the particles are of epiclastic origin.definition of sand from SLTTs 2004 sandy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).";
                    sand.Version = "1.4.1.0";
                }
                return sand;
            }
        }

        private static LithologyType sandstone;
        /// <summary>
        /// Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("sandstone")]
        public static LithologyType Sandstone
        {
            get 
            {
                if (sandstone == null)
                {
                    sandstone = new LithologyType("sandstone");
                    sandstone.Description = "Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.";
                    sandstone.Version = "1.4.1.0";
                }
                return sandstone;
            }
        }

        private static LithologyType sapropel;
        /// <summary>
        /// Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("sapropel")]
        public static LithologyType Sapropel
        {
            get 
            {
                if (sapropel == null)
                {
                    sapropel = new LithologyType("sapropel");
                    sapropel.Description = "Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005.";
                    sapropel.Version = "1.4.1.0";
                }
                return sapropel;
            }
        }

        private static LithologyType schist;
        /// <summary>
        /// Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("schist")]
        public static LithologyType Schist
        {
            get 
            {
                if (schist == null)
                {
                    schist = new LithologyType("schist");
                    schist.Description = "Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005.";
                    schist.Version = "1.4.1.0";
                }
                return schist;
            }
        }

        private static LithologyType serpentine;
        /// <summary>
        /// DEPRECATED. See "serpentinite".
        /// </summary>
        [EnumValueNameAttribute("serpentine")]
        public static LithologyType Serpentine
        {
            get 
            {
                if (serpentine == null)
                {
                    serpentine = new LithologyType("serpentine");
                    serpentine.Description = "DEPRECATED. See \"serpentinite\".";
                    serpentine.Version = "1.3.1.1";
                    serpentine.Deprecated = "1.4.1.0";
                    serpentine.ReplacedBy = Serpentinite;
                }
                return serpentine;
            }
        }

        private static LithologyType serpentinite;
        /// <summary>
        /// Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("serpentinite")]
        public static LithologyType Serpentinite
        {
            get 
            {
                if (serpentinite == null)
                {
                    serpentinite = new LithologyType("serpentinite");
                    serpentinite.Description = "Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005.";
                    serpentinite.Version = "1.4.1.0";
                }
                return serpentinite;
            }
        }

        private static LithologyType shale;
        /// <summary>
        /// Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically.
        /// </summary>
        [EnumValueNameAttribute("shale")]
        public static LithologyType Shale
        {
            get 
            {
                if (shale == null)
                {
                    shale = new LithologyType("shale");
                    shale.Description = "Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically.";
                    shale.Version = "1.4.1.0";
                }
                return shale;
            }
        }

        private static LithologyType siliceousOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siliceous ooze")]
        public static LithologyType SiliceousOoze
        {
            get 
            {
                if (siliceousOoze == null)
                {
                    siliceousOoze = new LithologyType("siliceous ooze");
                    siliceousOoze.Description = "Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology.";
                    siliceousOoze.Version = "1.4.1.0";
                }
                return siliceousOoze;
            }
        }

        private static LithologyType silt;
        /// <summary>
        /// Mud that consists of greater than 50 percent silt-size grains. Based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("silt")]
        public static LithologyType Silt
        {
            get 
            {
                if (silt == null)
                {
                    silt = new LithologyType("silt");
                    silt.Description = "Mud that consists of greater than 50 percent silt-size grains. Based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.";
                    silt.Version = "1.4.1.0";
                }
                return silt;
            }
        }

        private static LithologyType siltstone;
        /// <summary>
        /// Mudstone that contains detectable silt. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siltstone")]
        public static LithologyType Siltstone
        {
            get 
            {
                if (siltstone == null)
                {
                    siltstone = new LithologyType("siltstone");
                    siltstone.Description = "Mudstone that contains detectable silt. OneGeology.";
                    siltstone.Version = "1.4.1.0";
                }
                return siltstone;
            }
        }

        private static LithologyType skarn;
        /// <summary>
        /// Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195.
        /// </summary>
        [EnumValueNameAttribute("skarn")]
        public static LithologyType Skarn
        {
            get 
            {
                if (skarn == null)
                {
                    skarn = new LithologyType("skarn");
                    skarn.Description = "Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195.";
                    skarn.Version = "1.4.1.0";
                }
                return skarn;
            }
        }

        private static LithologyType slate;
        /// <summary>
        /// Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("slate")]
        public static LithologyType Slate
        {
            get 
            {
                if (slate == null)
                {
                    slate = new LithologyType("slate");
                    slate.Description = "Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005.";
                    slate.Version = "1.4.1.0";
                }
                return slate;
            }
        }

        private static LithologyType spilite;
        /// <summary>
        /// Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619.
        /// </summary>
        [EnumValueNameAttribute("spilite")]
        public static LithologyType Spilite
        {
            get 
            {
                if (spilite == null)
                {
                    spilite = new LithologyType("spilite");
                    spilite.Description = "Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619.";
                    spilite.Version = "1.4.1.0";
                }
                return spilite;
            }
        }

        private static LithologyType syenite;
        /// <summary>
        /// Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz.
        /// </summary>
        [EnumValueNameAttribute("syenite")]
        public static LithologyType Syenite
        {
            get 
            {
                if (syenite == null)
                {
                    syenite = new LithologyType("syenite");
                    syenite.Description = "Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz.";
                    syenite.Version = "1.3.1.1";
                }
                return syenite;
            }
        }

        private static LithologyType syenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("syenitoid")]
        public static LithologyType Syenitoid
        {
            get 
            {
                if (syenitoid == null)
                {
                    syenitoid = new LithologyType("syenitoid");
                    syenitoid.Description = "Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002.";
                    syenitoid.Version = "1.4.1.0";
                }
                return syenitoid;
            }
        }

        private static LithologyType sylvite;
        /// <summary>
        /// Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology.
        /// </summary>
        [EnumValueNameAttribute("sylvite")]
        public static LithologyType Sylvite
        {
            get 
            {
                if (sylvite == null)
                {
                    sylvite = new LithologyType("sylvite");
                    sylvite.Description = "Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology.";
                    sylvite.Version = "1.4.1.0";
                }
                return sylvite;
            }
        }

        private static LithologyType tephrite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephrite")]
        public static LithologyType Tephrite
        {
            get 
            {
                if (tephrite == null)
                {
                    tephrite = new LithologyType("tephrite");
                    tephrite.Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.";
                    tephrite.Version = "1.4.1.0";
                }
                return tephrite;
            }
        }

        private static LithologyType tephritoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephritoid")]
        public static LithologyType Tephritoid
        {
            get 
            {
                if (tephritoid == null)
                {
                    tephritoid = new LithologyType("tephritoid");
                    tephritoid.Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002.";
                    tephritoid.Version = "1.4.1.0";
                }
                return tephritoid;
            }
        }

        private static LithologyType tholeiiticBasalt;
        /// <summary>
        /// Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("tholeiitic basalt")]
        public static LithologyType TholeiiticBasalt
        {
            get 
            {
                if (tholeiiticBasalt == null)
                {
                    tholeiiticBasalt = new LithologyType("tholeiitic basalt");
                    tholeiiticBasalt.Description = "Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.";
                    tholeiiticBasalt.Version = "1.4.1.0";
                }
                return tholeiiticBasalt;
            }
        }

        private static LithologyType tilliteDiamictite;
        /// <summary>
        /// DEPRECATED. See "diamictite".
        /// </summary>
        [EnumValueNameAttribute("tillite (diamictite)")]
        public static LithologyType TilliteDiamictite
        {
            get 
            {
                if (tilliteDiamictite == null)
                {
                    tilliteDiamictite = new LithologyType("tillite (diamictite)");
                    tilliteDiamictite.Description = "DEPRECATED. See \"diamictite\".";
                    tilliteDiamictite.Version = "1.3.1.1";
                    tilliteDiamictite.Deprecated = "1.4.1.0";
                    tilliteDiamictite.ReplacedBy = Diamictite;
                }
                return tilliteDiamictite;
            }
        }

        private static LithologyType tonalite;
        /// <summary>
        /// Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tonalite")]
        public static LithologyType Tonalite
        {
            get 
            {
                if (tonalite == null)
                {
                    tonalite = new LithologyType("tonalite");
                    tonalite.Description = "Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002.";
                    tonalite.Version = "1.4.1.0";
                }
                return tonalite;
            }
        }

        private static LithologyType trachyte;
        /// <summary>
        /// A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals.
        /// </summary>
        [EnumValueNameAttribute("trachyte")]
        public static LithologyType Trachyte
        {
            get 
            {
                if (trachyte == null)
                {
                    trachyte = new LithologyType("trachyte");
                    trachyte.Description = "A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals.";
                    trachyte.Version = "1.3.1.1";
                }
                return trachyte;
            }
        }

        private static LithologyType trachyticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytic rock")]
        public static LithologyType TrachyticRock
        {
            get 
            {
                if (trachyticRock == null)
                {
                    trachyticRock = new LithologyType("trachytic rock");
                    trachyticRock.Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002.";
                    trachyticRock.Version = "1.4.1.0";
                }
                return trachyticRock;
            }
        }

        private static LithologyType trachytoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytoid")]
        public static LithologyType Trachytoid
        {
            get 
            {
                if (trachytoid == null)
                {
                    trachytoid = new LithologyType("trachytoid");
                    trachytoid.Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002.";
                    trachytoid.Version = "1.4.1.0";
                }
                return trachytoid;
            }
        }

        private static LithologyType travertine;
        /// <summary>
        /// Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74.
        /// </summary>
        [EnumValueNameAttribute("travertine")]
        public static LithologyType Travertine
        {
            get 
            {
                if (travertine == null)
                {
                    travertine = new LithologyType("travertine");
                    travertine.Description = "Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74.";
                    travertine.Version = "1.4.1.0";
                }
                return travertine;
            }
        }

        private static LithologyType tuff;
        /// <summary>
        /// Ash tuff, lapillistone, and lapilli tuff. Pyroclastic rock in which less than 25 percent of rock by volume are more than 64 millimeter in longest diameter. Includes tuff, lapilli tuff, and lapillistone. Schmid 1981; LeMaitre et al. 2002. Modified by WITSML to just use the term Tuff.
        /// </summary>
        [EnumValueNameAttribute("tuff")]
        public static LithologyType Tuff
        {
            get 
            {
                if (tuff == null)
                {
                    tuff = new LithologyType("tuff");
                    tuff.Description = "Ash tuff, lapillistone, and lapilli tuff. Pyroclastic rock in which less than 25 percent of rock by volume are more than 64 millimeter in longest diameter. Includes tuff, lapilli tuff, and lapillistone. Schmid 1981; LeMaitre et al. 2002. Modified by WITSML to just use the term Tuff.";
                    tuff.Version = "1.4.1.0";
                }
                return tuff;
            }
        }

        private static LithologyType tuffite;
        /// <summary>
        /// Rock consists of more than 50 percent particles of indeterminate pyroclastic or epiclastic origin and less than 75 percent particles of clearly pyroclastic origin. Commonly the rock is laminated or exhibits size grading. (based on LeMaitre et al. 2002; Murawski and Meyer 1998).
        /// </summary>
        [EnumValueNameAttribute("tuffite")]
        public static LithologyType Tuffite
        {
            get 
            {
                if (tuffite == null)
                {
                    tuffite = new LithologyType("tuffite");
                    tuffite.Description = "Rock consists of more than 50 percent particles of indeterminate pyroclastic or epiclastic origin and less than 75 percent particles of clearly pyroclastic origin. Commonly the rock is laminated or exhibits size grading. (based on LeMaitre et al. 2002; Murawski and Meyer 1998).";
                    tuffite.Version = "1.4.1.0";
                }
                return tuffite;
            }
        }

        private static LithologyType ultrabasic;
        /// <summary>
        /// A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%.
        /// </summary>
        [EnumValueNameAttribute("ultrabasic")]
        public static LithologyType Ultrabasic
        {
            get 
            {
                if (ultrabasic == null)
                {
                    ultrabasic = new LithologyType("ultrabasic");
                    ultrabasic.Description = "A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%.";
                    ultrabasic.Version = "1.3.1.1";
                }
                return ultrabasic;
            }
        }

        private static LithologyType undifferentiated;
        /// <summary>
        /// The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent.
        /// </summary>
        [EnumValueNameAttribute("undifferentiated")]
        public static LithologyType Undifferentiated
        {
            get 
            {
                if (undifferentiated == null)
                {
                    undifferentiated = new LithologyType("undifferentiated");
                    undifferentiated.Description = "The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent.";
                    undifferentiated.Version = "1.3.1.1";
                }
                return undifferentiated;
            }
        }

        private static LithologyType wacke;
        /// <summary>
        /// Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p.
        /// </summary>
        [EnumValueNameAttribute("wacke")]
        public static LithologyType Wacke
        {
            get 
            {
                if (wacke == null)
                {
                    wacke = new LithologyType("wacke");
                    wacke.Description = "Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p.";
                    wacke.Version = "1.4.1.0";
                }
                return wacke;
            }
        }

        private static LithologyType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static LithologyType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new LithologyType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                    unknown.Version = "1.3.1.1";
                }
                return unknown;
            }
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

        private static MatrixCementType ankerite;
        /// <summary>
        /// A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),
        /// </summary>
        [EnumValueNameAttribute("ankerite")]
        public static MatrixCementType Ankerite
        {
            get 
            {
                if (ankerite == null)
                {
                    ankerite = new MatrixCementType("ankerite");
                    ankerite.Description = "A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),";
                    ankerite.Version = "1.4.1.0";
                }
                return ankerite;
            }
        }

        private static MatrixCementType calcite;
        /// <summary>
        /// A matrix cement dominantly composed of Calcite, the most stable polymorph of calcium carbonate (CaCO3), and readily identifiable at the wellsite due to its reaction with dilute hydrochloric acid. The most common matrix cement.
        /// </summary>
        [EnumValueNameAttribute("calcite")]
        public static MatrixCementType Calcite
        {
            get 
            {
                if (calcite == null)
                {
                    calcite = new MatrixCementType("calcite");
                    calcite.Description = "A matrix cement dominantly composed of Calcite, the most stable polymorph of calcium carbonate (CaCO3), and readily identifiable at the wellsite due to its reaction with dilute hydrochloric acid. The most common matrix cement.";
                    calcite.Version = "1.4.1.0";
                }
                return calcite;
            }
        }

        private static MatrixCementType chlorite;
        /// <summary>
        /// A matrix cement dominantly composed of Chlorite. It is a low grade metamorphic cement. The typical general formula is: (Mg,Fe)3(Si,Al)4O10(OH)2Â·(Mg,Fe)3(OH)6.Seen in Algerian gas fields such as Teg.
        /// </summary>
        [EnumValueNameAttribute("chlorite")]
        public static MatrixCementType Chlorite
        {
            get 
            {
                if (chlorite == null)
                {
                    chlorite = new MatrixCementType("chlorite");
                    chlorite.Description = "A matrix cement dominantly composed of Chlorite. It is a low grade metamorphic cement. The typical general formula is: (Mg,Fe)3(Si,Al)4O10(OH)2Â·(Mg,Fe)3(OH)6.Seen in Algerian gas fields such as Teg.";
                    chlorite.Version = "1.4.1.0";
                }
                return chlorite;
            }
        }

        private static MatrixCementType dolomite;
        /// <summary>
        /// A matrix cement dominantly composed of dolomite.Dolomite cement is composed predominantly of the mineral dolomite with a stoichiometric ratio of 50% or greater content of magnesium replacing calcium, often as a result of diagenesis .
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static MatrixCementType Dolomite
        {
            get 
            {
                if (dolomite == null)
                {
                    dolomite = new MatrixCementType("dolomite");
                    dolomite.Description = "A matrix cement dominantly composed of dolomite.Dolomite cement is composed predominantly of the mineral dolomite with a stoichiometric ratio of 50% or greater content of magnesium replacing calcium, often as a result of diagenesis .";
                    dolomite.Version = "1.4.1.0";
                }
                return dolomite;
            }
        }

        private static MatrixCementType illite;
        /// <summary>
        /// A matrix cement dominantly composed of Illite. Illite is a clay sized micaceous mineral. The chemical formula is given as (K,H3O)(Al,Mg,Fe)2(Si,Al)4O10[(OH)2,(H2O)],[2] but there is considerable ion substitution. Seen in Southern North Sea gas fields such as the "Village" fields area.
        /// </summary>
        [EnumValueNameAttribute("illite")]
        public static MatrixCementType Illite
        {
            get 
            {
                if (illite == null)
                {
                    illite = new MatrixCementType("illite");
                    illite.Description = "A matrix cement dominantly composed of Illite. Illite is a clay sized micaceous mineral. The chemical formula is given as (K,H3O)(Al,Mg,Fe)2(Si,Al)4O10[(OH)2,(H2O)],[2] but there is considerable ion substitution. Seen in Southern North Sea gas fields such as the \"Village\" fields area.";
                    illite.Version = "1.4.1.0";
                }
                return illite;
            }
        }

        private static MatrixCementType kaolinite;
        /// <summary>
        /// A matrix cement dominantly composed of Kaolinite. A matrix cement with the chemical composition Al2Si2O5(OH)4. It is a soft, earthy, usually white mineral (dioctahedral phyllosilicate clay), produced by the chemical weathering of aluminium silicate minerals like feldspar.
        /// </summary>
        [EnumValueNameAttribute("kaolinite")]
        public static MatrixCementType Kaolinite
        {
            get 
            {
                if (kaolinite == null)
                {
                    kaolinite = new MatrixCementType("kaolinite");
                    kaolinite.Description = "A matrix cement dominantly composed of Kaolinite. A matrix cement with the chemical composition Al2Si2O5(OH)4. It is a soft, earthy, usually white mineral (dioctahedral phyllosilicate clay), produced by the chemical weathering of aluminium silicate minerals like feldspar.";
                    kaolinite.Version = "1.4.1.0";
                }
                return kaolinite;
            }
        }

        private static MatrixCementType quartz;
        /// <summary>
        /// A matrix cement dominantly composed of Quartz, either from pressure solution grain to grain contact cementation or secondary quartz deposition. Fairly common.
        /// </summary>
        [EnumValueNameAttribute("quartz")]
        public static MatrixCementType Quartz
        {
            get 
            {
                if (quartz == null)
                {
                    quartz = new MatrixCementType("quartz");
                    quartz.Description = "A matrix cement dominantly composed of Quartz, either from pressure solution grain to grain contact cementation or secondary quartz deposition. Fairly common.";
                    quartz.Version = "1.4.1.0";
                }
                return quartz;
            }
        }

        private static MatrixCementType siderite;
        /// <summary>
        /// A matrix cement dominantly composed of Siderite. Siderite is composed of iron carbonate FeCO3. ( Sherwood sandstones, in the southern UK typical include Siderite cements)
        /// </summary>
        [EnumValueNameAttribute("siderite")]
        public static MatrixCementType Siderite
        {
            get 
            {
                if (siderite == null)
                {
                    siderite = new MatrixCementType("siderite");
                    siderite.Description = "A matrix cement dominantly composed of Siderite. Siderite is composed of iron carbonate FeCO3. ( Sherwood sandstones, in the southern UK typical include Siderite cements)";
                    siderite.Version = "1.4.1.0";
                }
                return siderite;
            }
        }

        private static MatrixCementType smectite;
        /// <summary>
        /// A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples.
        /// </summary>
        [EnumValueNameAttribute("smectite")]
        public static MatrixCementType Smectite
        {
            get 
            {
                if (smectite == null)
                {
                    smectite = new MatrixCementType("smectite");
                    smectite.Description = "A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples.";
                    smectite.Version = "1.4.1.0";
                }
                return smectite;
            }
        }

        private static MatrixCementType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static MatrixCementType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new MatrixCementType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                    unknown.Version = "1.4.1.0";
                }
                return unknown;
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

        private static ObjectGroupKind drilling;
        /// <summary>
        /// Run of BHA tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the BHA run number. The sequence1 element represents the BHA pass number within the run. The range elements represent the portion of the wellbore traversed by the BHA for that run. 
        /// </summary>
        [EnumValueNameAttribute("drilling")]
        public static ObjectGroupKind Drilling
        {
            get 
            {
                if (drilling == null)
                {
                    drilling = new ObjectGroupKind("drilling");
                    drilling.Description = "Run of BHA tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the BHA run number. The sequence1 element represents the BHA pass number within the run. The range elements represent the portion of the wellbore traversed by the BHA for that run. ";
                    drilling.Version = "1.4.1.0";
                }
                return drilling;
            }
        }

        private static ObjectGroupKind wireline;
        /// <summary>
        /// Run of wirelilne tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the wireline run (trip) number. The sequence1 element represents the pass number within the run. The range elements represent the portion of the wellbore traversed by the tool for that run. 
        /// </summary>
        [EnumValueNameAttribute("wireline")]
        public static ObjectGroupKind Wireline
        {
            get 
            {
                if (wireline == null)
                {
                    wireline = new ObjectGroupKind("wireline");
                    wireline.Description = "Run of wirelilne tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the wireline run (trip) number. The sequence1 element represents the pass number within the run. The range elements represent the portion of the wellbore traversed by the tool for that run. ";
                    wireline.Version = "1.4.1.0";
                }
                return wireline;
            }
        }

        private static ObjectGroupKind pressureTest;
        /// <summary>
        /// Run of pressure test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the pressure test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. 
        /// </summary>
        [EnumValueNameAttribute("pressure test")]
        public static ObjectGroupKind PressureTest
        {
            get 
            {
                if (pressureTest == null)
                {
                    pressureTest = new ObjectGroupKind("pressure test");
                    pressureTest.Description = "Run of pressure test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the pressure test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. ";
                    pressureTest.Version = "1.4.1.0";
                }
                return pressureTest;
            }
        }

        private static ObjectGroupKind flowTest;
        /// <summary>
        /// Run of flow test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the flow test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. 
        /// </summary>
        [EnumValueNameAttribute("flow test")]
        public static ObjectGroupKind FlowTest
        {
            get 
            {
                if (flowTest == null)
                {
                    flowTest = new ObjectGroupKind("flow test");
                    flowTest.Description = "Run of flow test tools from the time they go below the rotary table, to the time they come back up. The sequence element represents the flow test run number. The sequence1 element represents the pass number within the run. The sequence2 element represents the test number within the pass. The range elements represent the portion of the wellbore traversed by the tool for that run. The reference elements represent the time and depth of the test. ";
                    flowTest.Version = "1.4.1.0";
                }
                return flowTest;
            }
        }

        private static ObjectGroupKind holeSection;
        /// <summary>
        /// The group collects the data-objects which operate within a portion of the wellbore with the same hole size. The sequence element represents the ordered sequence of the hole size within the wellbore. A sequence number of one represents the shallowest section. The range elements represent the portion of the wellbore with the same hole size. The parameter with the name "holeSize" represents the numeric size of the hole and MUST be specified with a "length" unit of measure. 
        /// </summary>
        [EnumValueNameAttribute("hole section")]
        public static ObjectGroupKind HoleSection
        {
            get 
            {
                if (holeSection == null)
                {
                    holeSection = new ObjectGroupKind("hole section");
                    holeSection.Description = "The group collects the data-objects which operate within a portion of the wellbore with the same hole size. The sequence element represents the ordered sequence of the hole size within the wellbore. A sequence number of one represents the shallowest section. The range elements represent the portion of the wellbore with the same hole size. The parameter with the name \"holeSize\" represents the numeric size of the hole and MUST be specified with a \"length\" unit of measure. ";
                    holeSection.Version = "1.4.1.0";
                }
                return holeSection;
            }
        }

        private static ObjectGroupKind coring;
        /// <summary>
        /// The group collects the data-objects which relate to a cored interval. The sequence element represents the BHA run within which the core was taken. The range elements represent the portion of the wellbore from which the core was taken. The reference elements represent the time and depth of the core. The parameter with the name "coreLength" represents the numeric length of the core and MUST be specified with a "length" unit of measure. 
        /// </summary>
        [EnumValueNameAttribute("coring")]
        public static ObjectGroupKind Coring
        {
            get 
            {
                if (coring == null)
                {
                    coring = new ObjectGroupKind("coring");
                    coring.Description = "The group collects the data-objects which relate to a cored interval. The sequence element represents the BHA run within which the core was taken. The range elements represent the portion of the wellbore from which the core was taken. The reference elements represent the time and depth of the core. The parameter with the name \"coreLength\" represents the numeric length of the core and MUST be specified with a \"length\" unit of measure. ";
                    coring.Version = "1.4.1.0";
                }
                return coring;
            }
        }

        private static ObjectGroupKind drillReport;
        /// <summary>
        /// The group collects the data-objects which relate to a reporting period. The sequence element represents the Nth report. The range elements represent the portion of the wellbore which was drilled during the period. The reference date-time element represents the time of the end of the reporting period. 
        /// </summary>
        [EnumValueNameAttribute("drill report")]
        public static ObjectGroupKind DrillReport
        {
            get 
            {
                if (drillReport == null)
                {
                    drillReport = new ObjectGroupKind("drill report");
                    drillReport.Description = "The group collects the data-objects which relate to a reporting period. The sequence element represents the Nth report. The range elements represent the portion of the wellbore which was drilled during the period. The reference date-time element represents the time of the end of the reporting period. ";
                    drillReport.Version = "1.4.1.0";
                }
                return drillReport;
            }
        }

        private static ObjectGroupKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ObjectGroupKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ObjectGroupKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. ";
                    unknown.Version = "1.4.1.0";
                }
                return unknown;
            }
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

        private static QualifierType alkaliFeldsparRhyolite;
        /// <summary>
        /// Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("alkali feldspar rhyolite")]
        public static QualifierType AlkaliFeldsparRhyolite
        {
            get 
            {
                if (alkaliFeldsparRhyolite == null)
                {
                    alkaliFeldsparRhyolite = new QualifierType("alkali feldspar rhyolite");
                    alkaliFeldsparRhyolite.LithoType = EnumValueLithoType.both;
                    alkaliFeldsparRhyolite.IsLithology = true;
                    alkaliFeldsparRhyolite.Description = "Rhyolitoid in which the ratio of plagioclase to total feldspar is less than 0.1. QAPF field 2. LeMaitre et al. 2002.";
                    alkaliFeldsparRhyolite.Version = "1.4.1.0";
                }
                return alkaliFeldsparRhyolite;
            }
        }

        private static QualifierType alkaliOlivineBasalt;
        /// <summary>
        /// Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("alkali olivine basalt")]
        public static QualifierType AlkaliOlivineBasalt
        {
            get 
            {
                if (alkaliOlivineBasalt == null)
                {
                    alkaliOlivineBasalt = new QualifierType("alkali olivine basalt");
                    alkaliOlivineBasalt.LithoType = EnumValueLithoType.noun;
                    alkaliOlivineBasalt.IsLithology = true;
                    alkaliOlivineBasalt.Description = "Alkali olivine basalt is silica-undersaturated, characterized by the absence of orthopyroxene, absence of quartz, presence of olivine, and typically contains some feldspathoid mineral, alkali feldspar or phlogopite in the groundmass. Feldspar phenocrysts typically are labradorite to andesine in composition. Augite is rich in titanium compared to augite in tholeiitic basalt. Alkali olivine basalt is relatively rich in sodium. Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.";
                    alkaliOlivineBasalt.Version = "1.4.1.0";
                }
                return alkaliOlivineBasalt;
            }
        }

        private static QualifierType amphibolite;
        /// <summary>
        /// Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8.
        /// </summary>
        [EnumValueNameAttribute("amphibolite")]
        public static QualifierType Amphibolite
        {
            get 
            {
                if (amphibolite == null)
                {
                    amphibolite = new QualifierType("amphibolite");
                    amphibolite.LithoType = EnumValueLithoType.both;
                    amphibolite.IsLithology = true;
                    amphibolite.Description = "Metamorphic rock mainly consisting of green, brown or black amphibole and plagioclase (including albite), which combined form 75 percent or more of the rock, and both of which are present as major constituents. The amphibole constitutes 50 percent or more of the total mafic constituents and is present in an amount of 30 percent or more; other common minerals include quartz, clinopyroxene, garnet, epidote-group minerals, biotite, titanite and scapolite. Coutinho et al. 2007, IUGS SCMR chapter 8.";
                    amphibolite.Version = "1.4.1.0";
                }
                return amphibolite;
            }
        }

        private static QualifierType amphibolitic;
        /// <summary>
        /// VARIANT. See "amphibolite".
        /// </summary>
        [EnumValueNameAttribute("amphibolitic")]
        public static QualifierType Amphibolitic
        {
            get 
            {
                if (amphibolitic == null)
                {
                    amphibolitic = new QualifierType("amphibolitic");
                    amphibolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK amphibolitic.VariantOf = "amphibolite";
                    amphibolitic.Description = "VARIANT. See \"amphibolite\".";
                    amphibolitic.Version = "1.4.1.0";
                }
                return amphibolitic;
            }
        }

        private static QualifierType andesite;
        /// <summary>
        /// Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("andesite")]
        public static QualifierType Andesite
        {
            get 
            {
                if (andesite == null)
                {
                    andesite = new QualifierType("andesite");
                    andesite.LithoType = EnumValueLithoType.both;
                    andesite.IsLithology = true;
                    andesite.Description = "Fine-grained igneous rock with less than 20 percent quartz and less than 10 percent feldspathoid minerals in the QAPF fraction, in which the ratio of plagioclase to total feldspar is greater 0.65. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field O2 as andesite. Basalt and andesite, which share the same QAPF fields, are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. Typically consists of plagioclase (frequently zoned from labradorite to oligoclase), pyroxene, hornblende and/or biotite. Fine grained equivalent of dioritic rock. LeMaitre et al. 2002.";
                    andesite.Version = "1.4.1.0";
                }
                return andesite;
            }
        }

        private static QualifierType andesitic;
        /// <summary>
        /// VARIANT. See "andesite".
        /// </summary>
        [EnumValueNameAttribute("andesitic")]
        public static QualifierType Andesitic
        {
            get 
            {
                if (andesitic == null)
                {
                    andesitic = new QualifierType("andesitic");
                    andesitic.LithoType = EnumValueLithoType.adjective;
                    //UNK andesitic.VariantOf = "andesite";
                    andesitic.Description = "VARIANT. See \"andesite\".";
                    andesitic.Version = "1.4.1.0";
                }
                return andesitic;
            }
        }

        private static QualifierType anhydrite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles the evaporite mineral anhydrite (CaSO4).
        /// </summary>
        [EnumValueNameAttribute("anhydrite")]
        public static QualifierType Anhydrite
        {
            get 
            {
                if (anhydrite == null)
                {
                    anhydrite = new QualifierType("anhydrite");
                    anhydrite.LithoType = EnumValueLithoType.both;
                    anhydrite.IsLithology = true;
                    anhydrite.Description = "Indicates that the associated lithology contains or resembles the evaporite mineral anhydrite (CaSO4).";
                    anhydrite.Version = "1.4.0.0";
                }
                return anhydrite;
            }
        }

        private static QualifierType anhydritic;
        /// <summary>
        /// VARIANT. See "anhydrite".
        /// </summary>
        [EnumValueNameAttribute("anhydritic")]
        public static QualifierType Anhydritic
        {
            get 
            {
                if (anhydritic == null)
                {
                    anhydritic = new QualifierType("anhydritic");
                    anhydritic.LithoType = EnumValueLithoType.adjective;
                    //UNK anhydritic.VariantOf = "anhydrite";
                    anhydritic.Description = "VARIANT. See \"anhydrite\".";
                    anhydritic.Version = "1.3.1.0";
                }
                return anhydritic;
            }
        }

        private static QualifierType ankerite;
        /// <summary>
        /// A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),
        /// </summary>
        [EnumValueNameAttribute("ankerite")]
        public static QualifierType Ankerite
        {
            get 
            {
                if (ankerite == null)
                {
                    ankerite = new QualifierType("ankerite");
                    ankerite.LithoType = EnumValueLithoType.both;
                    ankerite.IsMatrixCement = true;
                    ankerite.Description = "A matrix cement dominantly composed of Ankerite. Ankerite is a calcium, iron, magnesium, manganese carbonate mineral of the group of rhombohedral carbonates with formula: Ca(Fe, Mg, Mn)(CO3)2. In composition it is closely related to dolomite, but differs from this in having magnesium replaced by varying amounts of iron(II) and manganese. ( AS a matrix cement it is seen in HP HT North Sea HPHT reservoirs such as Elgin and Franklin which have almost pure Ankerite cementation ),";
                    ankerite.Version = "1.4.1.0";
                }
                return ankerite;
            }
        }

        private static QualifierType ankeritic;
        /// <summary>
        /// VARIANT. See "ankerite".
        /// </summary>
        [EnumValueNameAttribute("ankeritic")]
        public static QualifierType Ankeritic
        {
            get 
            {
                if (ankeritic == null)
                {
                    ankeritic = new QualifierType("ankeritic");
                    ankeritic.LithoType = EnumValueLithoType.adjective;
                    //UNK ankeritic.VariantOf = "ankerite";
                    ankeritic.Description = "VARIANT. See \"ankerite\".";
                    ankeritic.Version = "1.4.1.0";
                }
                return ankeritic;
            }
        }

        private static QualifierType anorthositicRock;
        /// <summary>
        /// Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("anorthositic rock")]
        public static QualifierType AnorthositicRock
        {
            get 
            {
                if (anorthositicRock == null)
                {
                    anorthositicRock = new QualifierType("anorthositic rock");
                    anorthositicRock.LithoType = EnumValueLithoType.noun;
                    anorthositicRock.IsLithology = true;
                    anorthositicRock.Description = "Leucocratic phaneritic crystalline igneous rock consisting essentially of plagioclase, often with small amounts of pyroxene. By definition, colour index M is less than 10, and plagiclase to total feldspar ratio is greater than 0.9. Less than 20 percent quartz and less than 10 percent feldspathoid in the QAPF fraction. QAPF field 10, 10*, and 10'. LeMaitre et al. 2002.";
                    anorthositicRock.Version = "1.4.1.0";
                }
                return anorthositicRock;
            }
        }

        private static QualifierType anthracite;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005
        /// </summary>
        [EnumValueNameAttribute("anthracite")]
        public static QualifierType Anthracite
        {
            get 
            {
                if (anthracite == null)
                {
                    anthracite = new QualifierType("anthracite");
                    anthracite.LithoType = EnumValueLithoType.both;
                    anthracite.IsLithology = true;
                    anthracite.Description = "Coal that has vitrinite mean random reflectance greater than 2.0 percent (determined in conformance with ISO 7404-5). Less than 12-14 percent volatiles (dry, ash free), greater than 91 percent fixed carbon (dry, ash free basis). The highest rank coal; very hard, glossy, black, with semimetallic luster, semi conchoidal fracture. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp; see also Neuendorf et al. 2005";
                    anthracite.Version = "1.4.1.0";
                }
                return anthracite;
            }
        }

        private static QualifierType anthracitic;
        /// <summary>
        /// VARIANT. See "anthracite".
        /// </summary>
        [EnumValueNameAttribute("anthracitic")]
        public static QualifierType Anthracitic
        {
            get 
            {
                if (anthracitic == null)
                {
                    anthracitic = new QualifierType("anthracitic");
                    anthracitic.LithoType = EnumValueLithoType.adjective;
                    //UNK anthracitic.VariantOf = "anthracite";
                    anthracitic.Description = "VARIANT. See \"anthracite\".";
                    anthracitic.Version = "1.4.1.0";
                }
                return anthracitic;
            }
        }

        private static QualifierType aplite;
        /// <summary>
        /// Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("aplite")]
        public static QualifierType Aplite
        {
            get 
            {
                if (aplite == null)
                {
                    aplite = new QualifierType("aplite");
                    aplite.LithoType = EnumValueLithoType.both;
                    aplite.IsLithology = true;
                    aplite.Description = "Light coloured crystalline rock, characterized by a fine grained allotriomorphic-granular (aplitic, saccharoidal or xenomorphic) texture; typically granitic composition, consisting of quartz, alkali feldspar and sodic plagioclase. Neuendorf et al 2005.";
                    aplite.Version = "1.4.1.0";
                }
                return aplite;
            }
        }

        private static QualifierType aplitic;
        /// <summary>
        /// VARIANT. See "aplite".
        /// </summary>
        [EnumValueNameAttribute("aplitic")]
        public static QualifierType Aplitic
        {
            get 
            {
                if (aplitic == null)
                {
                    aplitic = new QualifierType("aplitic");
                    aplitic.LithoType = EnumValueLithoType.adjective;
                    //UNK aplitic.VariantOf = "aplite";
                    aplitic.Description = "VARIANT. See \"aplite\".";
                    aplitic.Version = "1.4.1.0";
                }
                return aplitic;
            }
        }

        private static QualifierType arenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite.
        /// </summary>
        [EnumValueNameAttribute("arenite")]
        public static QualifierType Arenite
        {
            get 
            {
                if (arenite == null)
                {
                    arenite = new QualifierType("arenite");
                    arenite.LithoType = EnumValueLithoType.both;
                    arenite.IsLithology = true;
                    arenite.Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p. WITSML note: In drill cuttings there is a tendancy for grains to break apart, and loose the matrix, so frequently Sandstone is used rather then Arenite.";
                    arenite.Version = "1.4.1.0";
                }
                return arenite;
            }
        }

        private static QualifierType arenitic;
        /// <summary>
        /// VARIANT. See "arenite".
        /// </summary>
        [EnumValueNameAttribute("arenitic")]
        public static QualifierType Arenitic
        {
            get 
            {
                if (arenitic == null)
                {
                    arenitic = new QualifierType("arenitic");
                    arenitic.LithoType = EnumValueLithoType.adjective;
                    //UNK arenitic.VariantOf = "arenite";
                    arenitic.Description = "VARIANT. See \"arenite\".";
                    arenitic.Version = "1.4.1.0";
                }
                return arenitic;
            }
        }

        private static QualifierType argillaceous;
        /// <summary>
        /// VARIANT. See "clay".
        /// </summary>
        [EnumValueNameAttribute("argillaceous")]
        public static QualifierType Argillaceous
        {
            get 
            {
                if (argillaceous == null)
                {
                    argillaceous = new QualifierType("argillaceous");
                    argillaceous.LithoType = EnumValueLithoType.adjective;
                    //UNK argillaceous.VariantOf = "clay";
                    argillaceous.Description = "VARIANT. See \"clay\".";
                    argillaceous.Version = "1.3.1.0";
                }
                return argillaceous;
            }
        }

        private static QualifierType arkose;
        /// <summary>
        /// An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%).
        /// </summary>
        [EnumValueNameAttribute("arkose")]
        public static QualifierType Arkose
        {
            get 
            {
                if (arkose == null)
                {
                    arkose = new QualifierType("arkose");
                    arkose.LithoType = EnumValueLithoType.both;
                    arkose.IsLithology = true;
                    arkose.Description = "An indurated arenaceous deposit consisting chiefly of quartz and feldspar (greater than 25%).";
                    arkose.Version = "1.4.1.0";
                }
                return arkose;
            }
        }

        private static QualifierType arkosic;
        /// <summary>
        /// VARIANT. See "arkose".
        /// </summary>
        [EnumValueNameAttribute("arkosic")]
        public static QualifierType Arkosic
        {
            get 
            {
                if (arkosic == null)
                {
                    arkosic = new QualifierType("arkosic");
                    arkosic.LithoType = EnumValueLithoType.adjective;
                    //UNK arkosic.VariantOf = "arkose";
                    arkosic.Description = "VARIANT. See \"arkose\".";
                    arkosic.Version = "1.4.1.0";
                }
                return arkosic;
            }
        }

        private static QualifierType barite;
        /// <summary>
        /// Indicates that the associated lithology contains the mineral barite [baryte] (BaSO4).
        /// </summary>
        [EnumValueNameAttribute("barite")]
        public static QualifierType Barite
        {
            get 
            {
                if (barite == null)
                {
                    barite = new QualifierType("barite");
                    barite.LithoType = EnumValueLithoType.both;
                    barite.Description = "Indicates that the associated lithology contains the mineral barite [baryte] (BaSO4).";
                    barite.Version = "1.3.1.0";
                }
                return barite;
            }
        }

        private static QualifierType baritic;
        /// <summary>
        /// VARIANT. See "barite".
        /// </summary>
        [EnumValueNameAttribute("baritic")]
        public static QualifierType Baritic
        {
            get 
            {
                if (baritic == null)
                {
                    baritic = new QualifierType("baritic");
                    baritic.LithoType = EnumValueLithoType.adjective;
                    //UNK baritic.VariantOf = "barite";
                    baritic.Description = "VARIANT. See \"barite\".";
                    baritic.Version = "1.4.0.0";
                }
                return baritic;
            }
        }

        private static QualifierType basalt;
        /// <summary>
        /// Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basalt")]
        public static QualifierType Basalt
        {
            get 
            {
                if (basalt == null)
                {
                    basalt = new QualifierType("basalt");
                    basalt.LithoType = EnumValueLithoType.both;
                    basalt.IsLithology = true;
                    basalt.Description = "Fine-grained or porphyritic igneous rock with less than 20 percent quartz, and less than 10 percent feldspathoid minerals, in which the ratio of plagioclase to total feldspar is greater 0.65. Typically composed of calcic plagioclase and clinopyroxene; phenocrysts typically include one or more of calcic plagioclase, clinopyroxene, orthopyroxene, and olivine. Includes rocks defined modally in QAPF fields 9 and 10 or chemically in TAS field B as basalt. Basalt and andesite are distinguished chemically based on silica content, with basalt defined to contain less than 52 weight percent silica. If chemical data are not available, the color index is used to distinguish the categories, with basalt defined to contain greater than 35 percent mafic minerals by volume or greater than 40 percent mafic minerals by weight. LeMaitre et al. 2002.";
                    basalt.Version = "1.4.1.0";
                }
                return basalt;
            }
        }

        private static QualifierType basaltic;
        /// <summary>
        /// VARIANT. See "basalt".
        /// </summary>
        [EnumValueNameAttribute("basaltic")]
        public static QualifierType Basaltic
        {
            get 
            {
                if (basaltic == null)
                {
                    basaltic = new QualifierType("basaltic");
                    basaltic.LithoType = EnumValueLithoType.adjective;
                    //UNK basaltic.VariantOf = "basalt";
                    basaltic.Description = "VARIANT. See \"basalt\".";
                    basaltic.Version = "1.4.1.0";
                }
                return basaltic;
            }
        }

        private static QualifierType basanite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("basanite")]
        public static QualifierType Basanite
        {
            get 
            {
                if (basanite == null)
                {
                    basanite = new QualifierType("basanite");
                    basanite.LithoType = EnumValueLithoType.both;
                    basanite.IsLithology = true;
                    basanite.Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains more than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.";
                    basanite.Version = "1.4.1.0";
                }
                return basanite;
            }
        }

        private static QualifierType basanitic;
        /// <summary>
        /// VARIANT. See "basanite".
        /// </summary>
        [EnumValueNameAttribute("basanitic")]
        public static QualifierType Basanitic
        {
            get 
            {
                if (basanitic == null)
                {
                    basanitic = new QualifierType("basanitic");
                    basanitic.LithoType = EnumValueLithoType.adjective;
                    //UNK basanitic.VariantOf = "basanite";
                    basanitic.Description = "VARIANT. See \"basanite\".";
                    basanitic.Version = "1.4.1.0";
                }
                return basanitic;
            }
        }

        private static QualifierType bauxite;
        /// <summary>
        /// Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001.
        /// </summary>
        [EnumValueNameAttribute("bauxite")]
        public static QualifierType Bauxite
        {
            get 
            {
                if (bauxite == null)
                {
                    bauxite = new QualifierType("bauxite");
                    bauxite.LithoType = EnumValueLithoType.both;
                    bauxite.IsLithology = true;
                    bauxite.Description = "Highly aluminous material containing abundant aluminium hydroxides (gibbsite, less commonly boehmite, diaspore) and aluminium-substituted iron oxides or hydroxides and generally minor or negligible kaolin minerals; may contain up to 20 percent quartz. Commonly has a pisolitic or nodular texture, and may be cemented. Eggleton 2001.";
                    bauxite.Version = "1.4.1.0";
                }
                return bauxite;
            }
        }

        private static QualifierType bauxitic;
        /// <summary>
        /// VARIANT. See "bauxite".
        /// </summary>
        [EnumValueNameAttribute("bauxitic")]
        public static QualifierType Bauxitic
        {
            get 
            {
                if (bauxitic == null)
                {
                    bauxitic = new QualifierType("bauxitic");
                    bauxitic.LithoType = EnumValueLithoType.adjective;
                    //UNK bauxitic.VariantOf = "bauxite";
                    bauxitic.Description = "VARIANT. See \"bauxite\".";
                    bauxitic.Version = "1.4.1.0";
                }
                return bauxitic;
            }
        }

        private static QualifierType belemnites;
        /// <summary>
        /// Indicates that the associated lithology contains belemnite (Carboniferous - Eocene) fossils or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("belemnites")]
        public static QualifierType Belemnites
        {
            get 
            {
                if (belemnites == null)
                {
                    belemnites = new QualifierType("belemnites");
                    belemnites.LithoType = EnumValueLithoType.both;
                    belemnites.Description = "Indicates that the associated lithology contains belemnite (Carboniferous - Eocene) fossils or fragments thereof.";
                    belemnites.Version = "1.4.0.0";
                }
                return belemnites;
            }
        }

        private static QualifierType belemnitic;
        /// <summary>
        /// VARIANT. See "belemnites".
        /// </summary>
        [EnumValueNameAttribute("belemnitic")]
        public static QualifierType Belemnitic
        {
            get 
            {
                if (belemnitic == null)
                {
                    belemnitic = new QualifierType("belemnitic");
                    belemnitic.LithoType = EnumValueLithoType.adjective;
                    //UNK belemnitic.VariantOf = "belemnites";
                    belemnitic.Description = "VARIANT. See \"belemnites\".";
                    belemnitic.Version = "1.3.1.0";
                }
                return belemnitic;
            }
        }

        private static QualifierType bioturbated;
        /// <summary>
        /// VARIANT. See "bioturbation".
        /// </summary>
        [EnumValueNameAttribute("bioturbated")]
        public static QualifierType Bioturbated
        {
            get 
            {
                if (bioturbated == null)
                {
                    bioturbated = new QualifierType("bioturbated");
                    bioturbated.LithoType = EnumValueLithoType.adjective;
                    //UNK bioturbated.VariantOf = "bioturbation";
                    bioturbated.Description = "VARIANT. See \"bioturbation\".";
                    bioturbated.Version = "1.3.1.0";
                }
                return bioturbated;
            }
        }

        private static QualifierType bioturbation;
        /// <summary>
        /// Indicates that the associated lithology has been disturbed by the (burrowing) activities of organisms before consolidation of the sediment.
        /// </summary>
        [EnumValueNameAttribute("bioturbation")]
        public static QualifierType Bioturbation
        {
            get 
            {
                if (bioturbation == null)
                {
                    bioturbation = new QualifierType("bioturbation");
                    bioturbation.LithoType = EnumValueLithoType.both;
                    bioturbation.Description = "Indicates that the associated lithology has been disturbed by the (burrowing) activities of organisms before consolidation of the sediment.";
                    bioturbation.Version = "1.4.0.0";
                }
                return bioturbation;
            }
        }

        private static QualifierType bitumen;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling bitumen (asphalt), pitch or tar.
        /// </summary>
        [EnumValueNameAttribute("bitumen")]
        public static QualifierType Bitumen
        {
            get 
            {
                if (bitumen == null)
                {
                    bitumen = new QualifierType("bitumen");
                    bitumen.LithoType = EnumValueLithoType.both;
                    bitumen.Description = "Indicates that the associated lithology comprises material containing or resembling bitumen (asphalt), pitch or tar.";
                    bitumen.Version = "1.4.0.0";
                }
                return bitumen;
            }
        }

        private static QualifierType bituminous;
        /// <summary>
        /// VARIANT. See "bitumen".
        /// </summary>
        [EnumValueNameAttribute("bituminous")]
        public static QualifierType Bituminous
        {
            get 
            {
                if (bituminous == null)
                {
                    bituminous = new QualifierType("bituminous");
                    bituminous.LithoType = EnumValueLithoType.adjective;
                    //UNK bituminous.VariantOf = "bitumen";
                    bituminous.Description = "VARIANT. See \"bitumen\".";
                    bituminous.Version = "1.3.1.0";
                }
                return bituminous;
            }
        }

        private static QualifierType bituminousCoal;
        /// <summary>
        /// Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("bituminous coal")]
        public static QualifierType BituminousCoal
        {
            get 
            {
                if (bituminousCoal == null)
                {
                    bituminousCoal = new QualifierType("bituminous coal");
                    bituminousCoal.LithoType = EnumValueLithoType.both;
                    bituminousCoal.IsLithology = true;
                    bituminousCoal.Description = "Coal that has vitrinite mean random reflectance greater than 0.6 percent and less than 2.0 percent (determined in conformance with ISO 7404-5), or has a gross calorific value greater than 24 MJ/kg (determined in conformance with ISO 1928). Hard, black, organic rich sedimentary rock; contains less than 91 percent fixed carbon on a dry, mineral-matter-free basis, and greater than 13-14 percent volatiles (dry, ash free). Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.";
                    bituminousCoal.Version = "1.4.1.0";
                }
                return bituminousCoal;
            }
        }

        private static QualifierType blueschistMetamorphicRock;
        /// <summary>
        /// Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock
        /// </summary>
        [EnumValueNameAttribute("blueschist metamorphic rock")]
        public static QualifierType BlueschistMetamorphicRock
        {
            get 
            {
                if (blueschistMetamorphicRock == null)
                {
                    blueschistMetamorphicRock = new QualifierType("blueschist metamorphic rock");
                    blueschistMetamorphicRock.LithoType = EnumValueLithoType.noun;
                    blueschistMetamorphicRock.IsLithology = true;
                    blueschistMetamorphicRock.Description = "Glaucophane lawsonite epidote metamorphic rock. A metamorphic rock of roughly basaltic composition, defined by the presence of glaucophane with lawsonite or epidote. Other minerals that may be present include jadeite, albite, chlorite, garnet, and muscovite (phengitic white mica). Typically fine-grained, dark colored. Category for rocks commonly referred to as blueschist. OneGeology, simplified for WITSML to blueschist metamorphic rock";
                    blueschistMetamorphicRock.Version = "1.4.1.0";
                }
                return blueschistMetamorphicRock;
            }
        }

        private static QualifierType boninite;
        /// <summary>
        /// andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("boninite")]
        public static QualifierType Boninite
        {
            get 
            {
                if (boninite == null)
                {
                    boninite = new QualifierType("boninite");
                    boninite.LithoType = EnumValueLithoType.noun;
                    boninite.IsLithology = true;
                    boninite.Description = "andesitic rock that contains more than 8 percent MgO. Typically consists of phenocrysts of protoenstatite, orthopyroxene, clinopyroxene, and olivine in a glassy base full of crystallites, and exhibits textures characterisitc of rapid crystal growth. LeMaitre et al. 2002.";
                    boninite.Version = "1.4.1.0";
                }
                return boninite;
            }
        }

        private static QualifierType breccia;
        /// <summary>
        /// Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("breccia")]
        public static QualifierType Breccia
        {
            get 
            {
                if (breccia == null)
                {
                    breccia = new QualifierType("breccia");
                    breccia.LithoType = EnumValueLithoType.both;
                    breccia.IsLithology = true;
                    breccia.Description = "Coarse-grained material composed of angular broken rock fragments; the fragments typically have sharp edges and unworn corners. The fragments may be held together by a mineral cement or in a fine-grained matrix, and consolidated or nonconsolidated. Clasts may be of any composition or origin. In sedimentary environments, breccia is used for material that consists entirely of angular fragments, mostly derived from a single source rock body, as in a rock avalanche deposit, and matrix is interpreted to be the product of comminution of clasts during transport. Diamictite or diamicton is used when the material reflects mixing of rock from a variety of sources, some sub angular or subrounded clasts may be present, and matrix is pre-existing fine grained material that is not a direct product of the brecciation/deposition process. Neuendorf et al. 2005.";
                    breccia.Version = "1.4.1.0";
                }
                return breccia;
            }
        }

        private static QualifierType brecciated;
        /// <summary>
        /// VARIANT. See "breccia".
        /// </summary>
        [EnumValueNameAttribute("brecciated")]
        public static QualifierType Brecciated
        {
            get 
            {
                if (brecciated == null)
                {
                    brecciated = new QualifierType("brecciated");
                    brecciated.LithoType = EnumValueLithoType.adjective;
                    //UNK brecciated.VariantOf = "breccia";
                    brecciated.Description = "VARIANT. See \"breccia\".";
                    brecciated.Version = "1.4.1.0";
                }
                return brecciated;
            }
        }

        private static QualifierType bryozoan;
        /// <summary>
        /// VARIANT. See "bryozoans".
        /// </summary>
        [EnumValueNameAttribute("bryozoan")]
        public static QualifierType Bryozoan
        {
            get 
            {
                if (bryozoan == null)
                {
                    bryozoan = new QualifierType("bryozoan");
                    bryozoan.LithoType = EnumValueLithoType.adjective;
                    //UNK bryozoan.VariantOf = "bryozoans";
                    bryozoan.Description = "VARIANT. See \"bryozoans\".";
                    bryozoan.Version = "1.4.0.0";
                }
                return bryozoan;
            }
        }

        private static QualifierType bryozoans;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of bryozoan (Ordovician - Recent) fossils or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("bryozoans")]
        public static QualifierType Bryozoans
        {
            get 
            {
                if (bryozoans == null)
                {
                    bryozoans = new QualifierType("bryozoans");
                    bryozoans.LithoType = EnumValueLithoType.both;
                    bryozoans.Description = "Indicates that the associated lithology contains or is characteristic of bryozoan (Ordovician - Recent) fossils or fragments thereof.";
                    bryozoans.Version = "1.3.1.0";
                }
                return bryozoans;
            }
        }

        private static QualifierType burrowed;
        /// <summary>
        /// VARIANT. See "burrows".
        /// </summary>
        [EnumValueNameAttribute("burrowed")]
        public static QualifierType Burrowed
        {
            get 
            {
                if (burrowed == null)
                {
                    burrowed = new QualifierType("burrowed");
                    burrowed.LithoType = EnumValueLithoType.adjective;
                    //UNK burrowed.VariantOf = "burrows";
                    burrowed.Description = "VARIANT. See \"burrows\".";
                    burrowed.Version = "1.3.1.0";
                }
                return burrowed;
            }
        }

        private static QualifierType burrows;
        /// <summary>
        /// Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation of the sediment.
        /// </summary>
        [EnumValueNameAttribute("burrows")]
        public static QualifierType Burrows
        {
            get 
            {
                if (burrows == null)
                {
                    burrows = new QualifierType("burrows");
                    burrows.LithoType = EnumValueLithoType.both;
                    burrows.Description = "Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation of the sediment.";
                    burrows.Version = "1.4.0.0";
                }
                return burrows;
            }
        }

        private static QualifierType calcareous;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or characteristic of calcium carbonate (CaCO3).
        /// </summary>
        [EnumValueNameAttribute("calcareous")]
        public static QualifierType Calcareous
        {
            get 
            {
                if (calcareous == null)
                {
                    calcareous = new QualifierType("calcareous");
                    calcareous.LithoType = EnumValueLithoType.adjective;
                    calcareous.Description = "Indicates that the associated lithology comprises (matrix) material containing or characteristic of calcium carbonate (CaCO3).";
                    calcareous.Version = "1.3.1.0";
                }
                return calcareous;
            }
        }

        private static QualifierType calcite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the crystalline form of calcium carbonate (CaCO3).
        /// </summary>
        [EnumValueNameAttribute("calcite")]
        public static QualifierType Calcite
        {
            get 
            {
                if (calcite == null)
                {
                    calcite = new QualifierType("calcite");
                    calcite.LithoType = EnumValueLithoType.both;
                    calcite.IsMatrixCement = true;
                    calcite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the crystalline form of calcium carbonate (CaCO3).";
                    calcite.Version = "1.4.0.0";
                }
                return calcite;
            }
        }

        private static QualifierType calciteConcr;
        /// <summary>
        /// DEPRECATED. See "calcite concretion".
        /// </summary>
        [EnumValueNameAttribute("calcite concr")]
        public static QualifierType CalciteConcr
        {
            get 
            {
                if (calciteConcr == null)
                {
                    calciteConcr = new QualifierType("calcite concr");
                    calciteConcr.LithoType = EnumValueLithoType.noun;
                    calciteConcr.Description = "DEPRECATED. See \"calcite concretion\".";
                    calciteConcr.Version = "1.3.1.0";
                    calciteConcr.Deprecated = "1.4.0.0";
                    calciteConcr.ReplacedBy = CalciteConcretion;
                }
                return calciteConcr;
            }
        }

        private static QualifierType calciteConcretion;
        /// <summary>
        /// Indicates that the associated lithology contains rounded nodules of crystalline calcium carbonate.
        /// </summary>
        [EnumValueNameAttribute("calcite concretion")]
        public static QualifierType CalciteConcretion
        {
            get 
            {
                if (calciteConcretion == null)
                {
                    calciteConcretion = new QualifierType("calcite concretion");
                    calciteConcretion.LithoType = EnumValueLithoType.noun;
                    calciteConcretion.Description = "Indicates that the associated lithology contains rounded nodules of crystalline calcium carbonate.";
                    calciteConcretion.Version = "1.4.0.0";
                }
                return calciteConcretion;
            }
        }

        private static QualifierType calcitic;
        /// <summary>
        /// VARIANT. See "calcite".
        /// </summary>
        [EnumValueNameAttribute("calcitic")]
        public static QualifierType Calcitic
        {
            get 
            {
                if (calcitic == null)
                {
                    calcitic = new QualifierType("calcitic");
                    calcitic.LithoType = EnumValueLithoType.adjective;
                    //UNK calcitic.VariantOf = "calcite";
                    calcitic.Description = "VARIANT. See \"calcite\".";
                    calcitic.Version = "1.4.0.0";
                }
                return calcitic;
            }
        }

        private static QualifierType carbonaceous;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or yielding carbon.
        /// </summary>
        [EnumValueNameAttribute("carbonaceous")]
        public static QualifierType Carbonaceous
        {
            get 
            {
                if (carbonaceous == null)
                {
                    carbonaceous = new QualifierType("carbonaceous");
                    carbonaceous.LithoType = EnumValueLithoType.adjective;
                    carbonaceous.Description = "Indicates that the associated lithology comprises material containing or yielding carbon.";
                    carbonaceous.Version = "1.3.1.0";
                }
                return carbonaceous;
            }
        }

        private static QualifierType carbonateOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("carbonate ooze")]
        public static QualifierType CarbonateOoze
        {
            get 
            {
                if (carbonateOoze == null)
                {
                    carbonateOoze = new QualifierType("carbonate ooze");
                    carbonateOoze.LithoType = EnumValueLithoType.both;
                    carbonateOoze.IsLithology = true;
                    carbonateOoze.Description = "Ooze that consists of more than 50 percent carbonate skeletal remains. OneGeology.";
                    carbonateOoze.Version = "1.4.1.0";
                }
                return carbonateOoze;
            }
        }

        private static QualifierType carbonatite;
        /// <summary>
        /// Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("carbonatite")]
        public static QualifierType Carbonatite
        {
            get 
            {
                if (carbonatite == null)
                {
                    carbonatite = new QualifierType("carbonatite");
                    carbonatite.LithoType = EnumValueLithoType.both;
                    carbonatite.IsLithology = true;
                    carbonatite.Description = "Igneous rock composed of more than 50 percent modal carbonate minerals. LeMaitre et al. 2002.";
                    carbonatite.Version = "1.4.1.0";
                }
                return carbonatite;
            }
        }

        private static QualifierType carbonatitic;
        /// <summary>
        /// VARIANT. See "carbonatite".
        /// </summary>
        [EnumValueNameAttribute("carbonatitic")]
        public static QualifierType Carbonatitic
        {
            get 
            {
                if (carbonatitic == null)
                {
                    carbonatitic = new QualifierType("carbonatitic");
                    carbonatitic.LithoType = EnumValueLithoType.adjective;
                    //UNK carbonatitic.VariantOf = "carbonatite";
                    carbonatitic.Description = "VARIANT. See \"carbonatite\".";
                    carbonatitic.Version = "1.4.1.0";
                }
                return carbonatitic;
            }
        }

        private static QualifierType chalk;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a soft compact form of calcium carbonate (CaCO3).
        /// </summary>
        [EnumValueNameAttribute("chalk")]
        public static QualifierType Chalk
        {
            get 
            {
                if (chalk == null)
                {
                    chalk = new QualifierType("chalk");
                    chalk.LithoType = EnumValueLithoType.both;
                    chalk.IsLithology = true;
                    chalk.Description = "Indicates that the associated lithology comprises material containing or resembling a soft compact form of calcium carbonate (CaCO3).";
                    chalk.Version = "1.4.0.0";
                }
                return chalk;
            }
        }

        private static QualifierType chalky;
        /// <summary>
        /// VARIANT. See "chalk".
        /// </summary>
        [EnumValueNameAttribute("chalky")]
        public static QualifierType Chalky
        {
            get 
            {
                if (chalky == null)
                {
                    chalky = new QualifierType("chalky");
                    chalky.LithoType = EnumValueLithoType.adjective;
                    //UNK chalky.VariantOf = "chalk";
                    chalky.Description = "VARIANT. See \"chalk\".";
                    chalky.Version = "1.3.1.0";
                }
                return chalky;
            }
        }

        private static QualifierType chamosite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles chamosite, a generally greenish-gray or black silicate mineral of iron and aluminium.
        /// </summary>
        [EnumValueNameAttribute("chamosite")]
        public static QualifierType Chamosite
        {
            get 
            {
                if (chamosite == null)
                {
                    chamosite = new QualifierType("chamosite");
                    chamosite.LithoType = EnumValueLithoType.both;
                    chamosite.Description = "Indicates that the associated lithology contains or resembles chamosite, a generally greenish-gray or black silicate mineral of iron and aluminium.";
                    chamosite.Version = "1.3.1.0";
                }
                return chamosite;
            }
        }

        private static QualifierType chamositic;
        /// <summary>
        /// VARIANT. See "chamosite".
        /// </summary>
        [EnumValueNameAttribute("chamositic")]
        public static QualifierType Chamositic
        {
            get 
            {
                if (chamositic == null)
                {
                    chamositic = new QualifierType("chamositic");
                    chamositic.LithoType = EnumValueLithoType.adjective;
                    //UNK chamositic.VariantOf = "chamosite";
                    chamositic.Description = "VARIANT. See \"chamosite\".";
                    chamositic.Version = "1.4.0.0";
                }
                return chamositic;
            }
        }

        private static QualifierType chert;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles the microcrystalline or cryptocrystalline form of quartz (SiO2).
        /// </summary>
        [EnumValueNameAttribute("chert")]
        public static QualifierType Chert
        {
            get 
            {
                if (chert == null)
                {
                    chert = new QualifierType("chert");
                    chert.LithoType = EnumValueLithoType.both;
                    chert.IsLithology = true;
                    chert.Description = "Indicates that the associated lithology contains or resembles the microcrystalline or cryptocrystalline form of quartz (SiO2).";
                    chert.Version = "1.3.1.0";
                }
                return chert;
            }
        }

        private static QualifierType cherty;
        /// <summary>
        /// VARIANT. See "chert".
        /// </summary>
        [EnumValueNameAttribute("cherty")]
        public static QualifierType Cherty
        {
            get 
            {
                if (cherty == null)
                {
                    cherty = new QualifierType("cherty");
                    cherty.LithoType = EnumValueLithoType.adjective;
                    //UNK cherty.VariantOf = "chert";
                    cherty.Description = "VARIANT. See \"chert\".";
                    cherty.Version = "1.4.0.0";
                }
                return cherty;
            }
        }

        private static QualifierType chlorite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles chlorite, a generally green or black flaky phyllosilicate mineral.
        /// </summary>
        [EnumValueNameAttribute("chlorite")]
        public static QualifierType Chlorite
        {
            get 
            {
                if (chlorite == null)
                {
                    chlorite = new QualifierType("chlorite");
                    chlorite.LithoType = EnumValueLithoType.both;
                    chlorite.IsMatrixCement = true;
                    chlorite.Description = "Indicates that the associated lithology contains or resembles chlorite, a generally green or black flaky phyllosilicate mineral.";
                    chlorite.Version = "1.3.1.0";
                }
                return chlorite;
            }
        }

        private static QualifierType chloritic;
        /// <summary>
        /// VARIANT. See "chlorite".
        /// </summary>
        [EnumValueNameAttribute("chloritic")]
        public static QualifierType Chloritic
        {
            get 
            {
                if (chloritic == null)
                {
                    chloritic = new QualifierType("chloritic");
                    chloritic.LithoType = EnumValueLithoType.adjective;
                    //UNK chloritic.VariantOf = "chlorite";
                    chloritic.Description = "VARIANT. See \"chlorite\".";
                    chloritic.Version = "1.4.0.0";
                }
                return chloritic;
            }
        }

        private static QualifierType clay;
        /// <summary>
        /// Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("clay")]
        public static QualifierType Clay
        {
            get 
            {
                if (clay == null)
                {
                    clay = new QualifierType("clay");
                    clay.LithoType = EnumValueLithoType.both;
                    clay.IsLithology = true;
                    clay.Description = "Mud that consists of greater than 50 percent particles with grain size less than 0.004 mm.based on SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.";
                    clay.Version = "1.4.1.0";
                }
                return clay;
            }
        }

        private static QualifierType claystone;
        /// <summary>
        /// Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("claystone")]
        public static QualifierType Claystone
        {
            get 
            {
                if (claystone == null)
                {
                    claystone = new QualifierType("claystone");
                    claystone.LithoType = EnumValueLithoType.noun;
                    claystone.IsLithology = true;
                    claystone.Description = "Mudstone that contains no detectable silt, inferred to consist virtually entirely of clay-size particles. OneGeology.";
                    claystone.Version = "1.4.1.0";
                }
                return claystone;
            }
        }

        private static QualifierType coal;
        /// <summary>
        /// A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.
        /// </summary>
        [EnumValueNameAttribute("coal")]
        public static QualifierType Coal
        {
            get 
            {
                if (coal == null)
                {
                    coal = new QualifierType("coal");
                    coal.LithoType = EnumValueLithoType.noun;
                    coal.IsLithology = true;
                    coal.Description = "A consolidated organic sedimentary material having less than 75 percent moisture. This category includes low, medium, and high rank coals according to International Classification of In-Seam Coal (United Nations, 1998), thus including lignite. Sapropelic coal is not distinguished in this category from humic coals. Formed from the compaction or induration of variously altered plant remains similar to those of peaty deposits. Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.";
                    coal.Version = "1.4.0.0";
                }
                return coal;
            }
        }

        private static QualifierType concretionary;
        /// <summary>
        /// VARIANT. See "concretions".
        /// </summary>
        [EnumValueNameAttribute("concretionary")]
        public static QualifierType Concretionary
        {
            get 
            {
                if (concretionary == null)
                {
                    concretionary = new QualifierType("concretionary");
                    concretionary.LithoType = EnumValueLithoType.adjective;
                    //UNK concretionary.VariantOf = "concretions";
                    concretionary.Description = "VARIANT. See \"concretions\".";
                    concretionary.Version = "1.4.0.0";
                }
                return concretionary;
            }
        }

        private static QualifierType concretions;
        /// <summary>
        /// Indicates that the associated lithology contains rounded masses of mineral material.
        /// </summary>
        [EnumValueNameAttribute("concretions")]
        public static QualifierType Concretions
        {
            get 
            {
                if (concretions == null)
                {
                    concretions = new QualifierType("concretions");
                    concretions.LithoType = EnumValueLithoType.both;
                    concretions.Description = "Indicates that the associated lithology contains rounded masses of mineral material.";
                    concretions.Version = "1.3.1.0";
                }
                return concretions;
            }
        }

        private static QualifierType conglomerate;
        /// <summary>
        /// Indicates that the associated lithology contains rounded rock fragments of greater than 20mm in size.
        /// </summary>
        [EnumValueNameAttribute("conglomerate")]
        public static QualifierType Conglomerate
        {
            get 
            {
                if (conglomerate == null)
                {
                    conglomerate = new QualifierType("conglomerate");
                    conglomerate.LithoType = EnumValueLithoType.both;
                    conglomerate.IsLithology = true;
                    conglomerate.Description = "Indicates that the associated lithology contains rounded rock fragments of greater than 20mm in size.";
                    conglomerate.Version = "1.4.0.0";
                }
                return conglomerate;
            }
        }

        private static QualifierType conglomeratic;
        /// <summary>
        /// VARIANT. See "conglomerate".
        /// </summary>
        [EnumValueNameAttribute("conglomeratic")]
        public static QualifierType Conglomeratic
        {
            get 
            {
                if (conglomeratic == null)
                {
                    conglomeratic = new QualifierType("conglomeratic");
                    conglomeratic.LithoType = EnumValueLithoType.adjective;
                    //UNK conglomeratic.VariantOf = "conglomerate";
                    conglomeratic.Description = "VARIANT. See \"conglomerate\".";
                    conglomeratic.Version = "1.3.1.0";
                }
                return conglomeratic;
            }
        }

        private static QualifierType coral;
        /// <summary>
        /// DEPRECATED. See "coral fragments".
        /// </summary>
        [EnumValueNameAttribute("coral")]
        public static QualifierType Coral
        {
            get 
            {
                if (coral == null)
                {
                    coral = new QualifierType("coral");
                    coral.LithoType = EnumValueLithoType.noun;
                    coral.Description = "DEPRECATED. See \"coral fragments\".";
                    coral.Version = "1.3.1.0";
                    coral.Deprecated = "1.4.0.0";
                    coral.ReplacedBy = CoralFragments;
                }
                return coral;
            }
        }

        private static QualifierType coralFragments;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles corals (late Pre-Cambrian - Recent) and/or coral fragments.
        /// </summary>
        [EnumValueNameAttribute("coral fragments")]
        public static QualifierType CoralFragments
        {
            get 
            {
                if (coralFragments == null)
                {
                    coralFragments = new QualifierType("coral fragments");
                    coralFragments.LithoType = EnumValueLithoType.both;
                    coralFragments.Description = "Indicates that the associated lithology contains or resembles corals (late Pre-Cambrian - Recent) and/or coral fragments.";
                    coralFragments.Version = "1.4.0.0";
                }
                return coralFragments;
            }
        }

        private static QualifierType coralline;
        /// <summary>
        /// VARIANT. See "coral fragments".
        /// </summary>
        [EnumValueNameAttribute("coralline")]
        public static QualifierType Coralline
        {
            get 
            {
                if (coralline == null)
                {
                    coralline = new QualifierType("coralline");
                    coralline.LithoType = EnumValueLithoType.adjective;
                    //UNK coralline.VariantOf = "coral fragments";
                    coralline.Description = "VARIANT. See \"coral fragments\".";
                    coralline.Version = "1.4.0.0";
                }
                return coralline;
            }
        }

        private static QualifierType crinoidal;
        /// <summary>
        /// VARIANT. See "crinoids".
        /// </summary>
        [EnumValueNameAttribute("crinoidal")]
        public static QualifierType Crinoidal
        {
            get 
            {
                if (crinoidal == null)
                {
                    crinoidal = new QualifierType("crinoidal");
                    crinoidal.LithoType = EnumValueLithoType.adjective;
                    //UNK crinoidal.VariantOf = "crinoids";
                    crinoidal.Description = "VARIANT. See \"crinoids\".";
                    crinoidal.Version = "1.4.0.0";
                }
                return crinoidal;
            }
        }

        private static QualifierType crinoids;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles crinoids (Mid Cambrian - Recent) and/or crinoid fragments.
        /// </summary>
        [EnumValueNameAttribute("crinoids")]
        public static QualifierType Crinoids
        {
            get 
            {
                if (crinoids == null)
                {
                    crinoids = new QualifierType("crinoids");
                    crinoids.LithoType = EnumValueLithoType.both;
                    crinoids.Description = "Indicates that the associated lithology contains or resembles crinoids (Mid Cambrian - Recent) and/or crinoid fragments.";
                    crinoids.Version = "1.3.1.0";
                }
                return crinoids;
            }
        }

        private static QualifierType dacite;
        /// <summary>
        /// Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dacite")]
        public static QualifierType Dacite
        {
            get 
            {
                if (dacite == null)
                {
                    dacite = new QualifierType("dacite");
                    dacite.LithoType = EnumValueLithoType.both;
                    dacite.IsLithology = true;
                    dacite.Description = "Fine grained or porphyritic crystalline rock that contains less than 90 percent mafic minerals, between 20 and 60 percent quartz in the QAPF fraction, and has a plagioclase to total feldspar ratio greater than 0.65. Includes rocks defined modally in QAPF fields 4 and 5 or chemically in TAS Field O3. Typcially composed of quartz and sodic plagioclase with minor amounts of biotite and/or hornblende and/or pyroxene; fine-grained equivalent of granodiorite and tonalite. LeMaitre et al. 2002.";
                    dacite.Version = "1.4.1.0";
                }
                return dacite;
            }
        }

        private static QualifierType dacitic;
        /// <summary>
        /// VARIANT. See "dacite".
        /// </summary>
        [EnumValueNameAttribute("dacitic")]
        public static QualifierType Dacitic
        {
            get 
            {
                if (dacitic == null)
                {
                    dacitic = new QualifierType("dacitic");
                    dacitic.LithoType = EnumValueLithoType.adjective;
                    //UNK dacitic.VariantOf = "dacite";
                    dacitic.Description = "VARIANT. See \"dacite\".";
                    dacitic.Version = "1.4.1.0";
                }
                return dacitic;
            }
        }

        private static QualifierType diabase;
        /// <summary>
        /// Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite.
        /// </summary>
        [EnumValueNameAttribute("diabase")]
        public static QualifierType Diabase
        {
            get 
            {
                if (diabase == null)
                {
                    diabase = new QualifierType("diabase");
                    diabase.LithoType = EnumValueLithoType.both;
                    diabase.IsLithology = true;
                    diabase.Description = "Igneous rock of grain size intermediate between basalt and gabbro composed of plagioclase feldspar, pyroxene and opaque minerals. Synonym: dolerite.";
                    diabase.Version = "1.4.1.0";
                }
                return diabase;
            }
        }

        private static QualifierType diabasic;
        /// <summary>
        /// VARIANT. See "diabase".
        /// </summary>
        [EnumValueNameAttribute("diabasic")]
        public static QualifierType Diabasic
        {
            get 
            {
                if (diabasic == null)
                {
                    diabasic = new QualifierType("diabasic");
                    diabasic.LithoType = EnumValueLithoType.adjective;
                    //UNK diabasic.VariantOf = "diabase";
                    diabasic.Description = "VARIANT. See \"diabase\".";
                    diabasic.Version = "1.4.1.0";
                }
                return diabasic;
            }
        }

        private static QualifierType diamictite;
        /// <summary>
        /// Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978.
        /// </summary>
        [EnumValueNameAttribute("diamictite")]
        public static QualifierType Diamictite
        {
            get 
            {
                if (diamictite == null)
                {
                    diamictite = new QualifierType("diamictite");
                    diamictite.LithoType = EnumValueLithoType.both;
                    diamictite.IsLithology = true;
                    diamictite.Description = "Unsorted or poorly sorted, clastic sedimentary rock with a wide range of particle sizes including a muddy matrix. Biogenic materials that have such texture are excluded. Distinguished from conglomerate, sandstone, mudstone based on polymodality and lack of structures related to transport and deposition of sediment by moving air or water. If more than 10 percent of the fine grained matrix is of indeterminant clastic or diagenetic origin and the fabric is matrix supported, may also be categorized as wacke. Fairbridge and Bourgeois 1978.";
                    diamictite.Version = "1.4.1.0";
                }
                return diamictite;
            }
        }

        private static QualifierType diamictitic;
        /// <summary>
        /// VARIANT. See "diamictite".
        /// </summary>
        [EnumValueNameAttribute("diamictitic")]
        public static QualifierType Diamictitic
        {
            get 
            {
                if (diamictitic == null)
                {
                    diamictitic = new QualifierType("diamictitic");
                    diamictitic.LithoType = EnumValueLithoType.adjective;
                    //UNK diamictitic.VariantOf = "diamictite";
                    diamictitic.Description = "VARIANT. See \"diamictite\".";
                    diamictitic.Version = "1.4.1.0";
                }
                return diamictitic;
            }
        }

        private static QualifierType diatomaceous;
        /// <summary>
        /// VARIANT. See "diatoms".
        /// </summary>
        [EnumValueNameAttribute("diatomaceous")]
        public static QualifierType Diatomaceous
        {
            get 
            {
                if (diatomaceous == null)
                {
                    diatomaceous = new QualifierType("diatomaceous");
                    diatomaceous.LithoType = EnumValueLithoType.adjective;
                    //UNK diatomaceous.VariantOf = "diatoms";
                    diatomaceous.Description = "VARIANT. See \"diatoms\".";
                    diatomaceous.Version = "1.4.0.0";
                }
                return diatomaceous;
            }
        }

        private static QualifierType diatoms;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles diatoms and/or diatom fragments.
        /// </summary>
        [EnumValueNameAttribute("diatoms")]
        public static QualifierType Diatoms
        {
            get 
            {
                if (diatoms == null)
                {
                    diatoms = new QualifierType("diatoms");
                    diatoms.LithoType = EnumValueLithoType.both;
                    diatoms.Description = "Indicates that the associated lithology contains or resembles diatoms and/or diatom fragments.";
                    diatoms.Version = "1.3.1.0";
                }
                return diatoms;
            }
        }

        private static QualifierType diorite;
        /// <summary>
        /// Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite.
        /// </summary>
        [EnumValueNameAttribute("diorite")]
        public static QualifierType Diorite
        {
            get 
            {
                if (diorite == null)
                {
                    diorite = new QualifierType("diorite");
                    diorite.LithoType = EnumValueLithoType.both;
                    diorite.IsLithology = true;
                    diorite.Description = "Plutonic igneous rock consisting of plagioclase feldspar, commonly with hornblende and biotite.";
                    diorite.Version = "1.4.1.0";
                }
                return diorite;
            }
        }

        private static QualifierType dioritic;
        /// <summary>
        /// VARIANT. See "diorite".
        /// </summary>
        [EnumValueNameAttribute("dioritic")]
        public static QualifierType Dioritic
        {
            get 
            {
                if (dioritic == null)
                {
                    dioritic = new QualifierType("dioritic");
                    dioritic.LithoType = EnumValueLithoType.adjective;
                    //UNK dioritic.VariantOf = "diorite";
                    dioritic.Description = "VARIANT. See \"diorite\".";
                    dioritic.Version = "1.4.1.0";
                }
                return dioritic;
            }
        }

        private static QualifierType dioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("dioritoid")]
        public static QualifierType Dioritoid
        {
            get 
            {
                if (dioritoid == null)
                {
                    dioritoid = new QualifierType("dioritoid");
                    dioritoid.LithoType = EnumValueLithoType.both;
                    dioritoid.IsLithology = true;
                    dioritoid.Description = "Phaneritic crystalline igneous rock with M less than 90, consisting of intermediate plagioclase, commonly with hornblende and often with biotite or augite. Plagioclase to total feldspar ratio is greater that 0.65, and anorthite content of plagioclase is less than 50 percent. Less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction. Includes rocks defined modally in QAPF fields 9 and 10 (and their subdivisions). LeMaitre et al. 2002.";
                    dioritoid.Version = "1.4.1.0";
                }
                return dioritoid;
            }
        }

        private static QualifierType dioritoidic;
        /// <summary>
        /// VARIANT. See "dioritoid".
        /// </summary>
        [EnumValueNameAttribute("dioritoidic")]
        public static QualifierType Dioritoidic
        {
            get 
            {
                if (dioritoidic == null)
                {
                    dioritoidic = new QualifierType("dioritoidic");
                    dioritoidic.LithoType = EnumValueLithoType.adjective;
                    //UNK dioritoidic.VariantOf = "dioritoid";
                    dioritoidic.Description = "VARIANT. See \"dioritoid\".";
                    dioritoidic.Version = "1.4.1.0";
                }
                return dioritoidic;
            }
        }

        private static QualifierType doleriticRock;
        /// <summary>
        /// Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("doleritic rock")]
        public static QualifierType DoleriticRock
        {
            get 
            {
                if (doleriticRock == null)
                {
                    doleriticRock = new QualifierType("doleritic rock");
                    doleriticRock.LithoType = EnumValueLithoType.noun;
                    doleriticRock.IsLithology = true;
                    doleriticRock.Description = "Dark colored gabbroic (basaltic) or dioritic (andesitic) rock intermediate in grain size between basalt and gabbro and composed of plagioclase, pyroxene and opaque minerals; often with ophitic texture. Typically occurs as hypabyssal intrusions. Includes dolerite, microdiorite, diabase and microgabbro. LeMaitre et al. 2002.";
                    doleriticRock.Version = "1.4.1.0";
                }
                return doleriticRock;
            }
        }

        private static QualifierType dolomite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling a magnesium-rich carbonate mineral of calcium (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static QualifierType Dolomite
        {
            get 
            {
                if (dolomite == null)
                {
                    dolomite = new QualifierType("dolomite");
                    dolomite.LithoType = EnumValueLithoType.both;
                    dolomite.IsLithology = true;
                    dolomite.IsMatrixCement = true;
                    dolomite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling a magnesium-rich carbonate mineral of calcium (CaMg(CO3)2).";
                    dolomite.Version = "1.3.1.0";
                }
                return dolomite;
            }
        }

        private static QualifierType dolomiteConcretion;
        /// <summary>
        /// Indicates that the associated lithology has rounded nodules of dolomite (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite concretion")]
        public static QualifierType DolomiteConcretion
        {
            get 
            {
                if (dolomiteConcretion == null)
                {
                    dolomiteConcretion = new QualifierType("dolomite concretion");
                    dolomiteConcretion.LithoType = EnumValueLithoType.noun;
                    dolomiteConcretion.Description = "Indicates that the associated lithology has rounded nodules of dolomite (CaMg(CO3)2).";
                    dolomiteConcretion.Version = "1.3.1.0";
                }
                return dolomiteConcretion;
            }
        }

        private static QualifierType dolomiteStringer;
        /// <summary>
        /// Indicates that the associated lithology contains thin beds of dolomite (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite stringer")]
        public static QualifierType DolomiteStringer
        {
            get 
            {
                if (dolomiteStringer == null)
                {
                    dolomiteStringer = new QualifierType("dolomite stringer");
                    dolomiteStringer.LithoType = EnumValueLithoType.noun;
                    dolomiteStringer.Description = "Indicates that the associated lithology contains thin beds of dolomite (CaMg(CO3)2).";
                    dolomiteStringer.Version = "1.3.1.0";
                }
                return dolomiteStringer;
            }
        }

        private static QualifierType dolomitic;
        /// <summary>
        /// VARIANT. See "dolomite".
        /// </summary>
        [EnumValueNameAttribute("dolomitic")]
        public static QualifierType Dolomitic
        {
            get 
            {
                if (dolomitic == null)
                {
                    dolomitic = new QualifierType("dolomitic");
                    dolomitic.LithoType = EnumValueLithoType.adjective;
                    //UNK dolomitic.VariantOf = "dolomite";
                    dolomitic.Description = "VARIANT. See \"dolomite\".";
                    dolomitic.Version = "1.3.1.0";
                }
                return dolomitic;
            }
        }

        private static QualifierType eclogite;
        /// <summary>
        /// Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("eclogite")]
        public static QualifierType Eclogite
        {
            get 
            {
                if (eclogite == null)
                {
                    eclogite = new QualifierType("eclogite");
                    eclogite.LithoType = EnumValueLithoType.both;
                    eclogite.IsLithology = true;
                    eclogite.Description = "Metamorphic rock composed of 75 percent or more (by volume) omphacite and garnet, both of which are present as major constituents, the amount of neither of them being higher than 75 percent (by volume); the presence of plagioclase precludes classification as an eclogite. IUGS SCMR 2007";
                    eclogite.Version = "1.4.1.0";
                }
                return eclogite;
            }
        }

        private static QualifierType eclogitic;
        /// <summary>
        /// VARIANT. See "eclogite".
        /// </summary>
        [EnumValueNameAttribute("eclogitic")]
        public static QualifierType Eclogitic
        {
            get 
            {
                if (eclogitic == null)
                {
                    eclogitic = new QualifierType("eclogitic");
                    eclogitic.LithoType = EnumValueLithoType.adjective;
                    //UNK eclogitic.VariantOf = "eclogite";
                    eclogitic.Description = "VARIANT. See \"eclogite\".";
                    eclogitic.Version = "1.4.1.0";
                }
                return eclogitic;
            }
        }

        private static QualifierType exoticAlkalineRock;
        /// <summary>
        /// Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("exotic alkaline rock")]
        public static QualifierType ExoticAlkalineRock
        {
            get 
            {
                if (exoticAlkalineRock == null)
                {
                    exoticAlkalineRock = new QualifierType("exotic alkaline rock");
                    exoticAlkalineRock.LithoType = EnumValueLithoType.noun;
                    exoticAlkalineRock.IsLithology = true;
                    exoticAlkalineRock.Description = "Kimberlite, lamproite, or lamprophyre. Generally are potassic, mafic or ultramafic rocks. Olivine (commonly serpentinized in kimberlite), and phlogopite are significant constituents. LeMaitre et al. 2002.";
                    exoticAlkalineRock.Version = "1.4.1.0";
                }
                return exoticAlkalineRock;
            }
        }

        private static QualifierType feldspar;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the rock-forming aluminosilicate minerals of sodium, potassium or calcium.
        /// </summary>
        [EnumValueNameAttribute("feldspar")]
        public static QualifierType Feldspar
        {
            get 
            {
                if (feldspar == null)
                {
                    feldspar = new QualifierType("feldspar");
                    feldspar.LithoType = EnumValueLithoType.both;
                    feldspar.IsLithology = true;
                    feldspar.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the rock-forming aluminosilicate minerals of sodium, potassium or calcium.";
                    feldspar.Version = "1.3.1.0";
                }
                return feldspar;
            }
        }

        private static QualifierType feldsparic;
        /// <summary>
        /// VARIANT. See "feldspar".
        /// </summary>
        [EnumValueNameAttribute("feldsparic")]
        public static QualifierType Feldsparic
        {
            get 
            {
                if (feldsparic == null)
                {
                    feldsparic = new QualifierType("feldsparic");
                    feldsparic.LithoType = EnumValueLithoType.adjective;
                    //UNK feldsparic.VariantOf = "feldspar";
                    feldsparic.Description = "VARIANT. See \"feldspar\".";
                    feldsparic.Version = "1.4.0.0";
                }
                return feldsparic;
            }
        }

        private static QualifierType feldspathic;
        /// <summary>
        /// VARIANT. See "feldspar".
        /// </summary>
        [EnumValueNameAttribute("feldspathic")]
        public static QualifierType Feldspathic
        {
            get 
            {
                if (feldspathic == null)
                {
                    feldspathic = new QualifierType("feldspathic");
                    feldspathic.LithoType = EnumValueLithoType.adjective;
                    //UNK feldspathic.VariantOf = "feldspar";
                    feldspathic.Description = "VARIANT. See \"feldspar\".";
                    feldspathic.Version = "1.4.0.0";
                }
                return feldspathic;
            }
        }

        private static QualifierType feldspathicArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("feldspathic arenite")]
        public static QualifierType FeldspathicArenite
        {
            get 
            {
                if (feldspathicArenite == null)
                {
                    feldspathicArenite = new QualifierType("feldspathic arenite");
                    feldspathicArenite.LithoType = EnumValueLithoType.noun;
                    feldspathicArenite.IsLithology = true;
                    feldspathicArenite.Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain less than 90 percent quartz.Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.";
                    feldspathicArenite.Version = "1.4.1.0";
                }
                return feldspathicArenite;
            }
        }

        private static QualifierType ferruginous;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling minerals rich in iron oxide or iron hydroxide.
        /// </summary>
        [EnumValueNameAttribute("ferruginous")]
        public static QualifierType Ferruginous
        {
            get 
            {
                if (ferruginous == null)
                {
                    ferruginous = new QualifierType("ferruginous");
                    ferruginous.LithoType = EnumValueLithoType.adjective;
                    ferruginous.Description = "Indicates that the associated lithology comprises material containing or resembling minerals rich in iron oxide or iron hydroxide.";
                    ferruginous.Version = "1.3.1.0";
                }
                return ferruginous;
            }
        }

        private static QualifierType fineGrainedIgneousRock;
        /// <summary>
        /// Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("fine grained igneous rock")]
        public static QualifierType FineGrainedIgneousRock
        {
            get 
            {
                if (fineGrainedIgneousRock == null)
                {
                    fineGrainedIgneousRock = new QualifierType("fine grained igneous rock");
                    fineGrainedIgneousRock.LithoType = EnumValueLithoType.noun;
                    fineGrainedIgneousRock.IsLithology = true;
                    fineGrainedIgneousRock.Description = "Undifferentaited Igneous rock in which the framework of the rock consists of crystals that are too small to determine mineralogy with the unaided eye; framework may include up to 50 percent glass. A significant percentage of the rock by volume may be phenocrysts. Includes rocks that are generally called volcanic rocks. Gillespie and Styles 1999; LeMaitre et al. 2002.";
                    fineGrainedIgneousRock.Version = "1.4.1.0";
                }
                return fineGrainedIgneousRock;
            }
        }

        private static QualifierType fissile;
        /// <summary>
        /// DEPRECATED. The term 'fissile' doesn't belong in this list as it is neither qualifier or modifier .... it is a descriptor of 'grain fabric'.
        /// </summary>
        [EnumValueNameAttribute("fissile")]
        public static QualifierType Fissile
        {
            get 
            {
                if (fissile == null)
                {
                    fissile = new QualifierType("fissile");
                    fissile.LithoType = EnumValueLithoType.unknown;
                    fissile.Description = "DEPRECATED. The term 'fissile' doesn't belong in this list as it is neither qualifier or modifier .... it is a descriptor of 'grain fabric'.";
                    fissile.Version = "1.3.1.0";
                    fissile.Deprecated = "1.4.0.0";
                    fissile.ReplacedBy = Unknown;
                }
                return fissile;
            }
        }

        private static QualifierType foidDioritoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid dioritoid")]
        public static QualifierType FoidDioritoid
        {
            get 
            {
                if (foidDioritoid == null)
                {
                    foidDioritoid = new QualifierType("foid dioritoid");
                    foidDioritoid.LithoType = EnumValueLithoType.noun;
                    foidDioritoid.IsLithology = true;
                    foidDioritoid.Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoid minerals form 10-60 percent of the QAPF fraction, plagioclase has anorthite content less than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.";
                    foidDioritoid.Version = "1.4.1.0";
                }
                return foidDioritoid;
            }
        }

        private static QualifierType foidGabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid gabbroid")]
        public static QualifierType FoidGabbroid
        {
            get 
            {
                if (foidGabbroid == null)
                {
                    foidGabbroid = new QualifierType("foid gabbroid");
                    foidGabbroid.LithoType = EnumValueLithoType.noun;
                    foidGabbroid.IsLithology = true;
                    foidGabbroid.Description = "Phaneritic crystalline igneous rock in which M is less than 90, the plagioclase to total feldspar ratio is greater than 0.5, feldspathoids form 10-60 percent of the QAPF fraction, and plagioclase has anorthite content greater than 50 percent. These rocks typically contain large amounts of mafic minerals. Includes rocks defined modally in QAPF fields 13 and 14. LeMaitre et al. 2002.";
                    foidGabbroid.Version = "1.4.1.0";
                }
                return foidGabbroid;
            }
        }

        private static QualifierType foidSyenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foid syenitoid")]
        public static QualifierType FoidSyenitoid
        {
            get 
            {
                if (foidSyenitoid == null)
                {
                    foidSyenitoid = new QualifierType("foid syenitoid");
                    foidSyenitoid.LithoType = EnumValueLithoType.noun;
                    foidSyenitoid.IsLithology = true;
                    foidSyenitoid.Description = "Phaneritic crystalline igneous rock with M less than 90, contains between 10 and 60 percent feldspathoid mineral in the QAPF fraction, and has a plagioclase to total feldspar ratio less than 0.5. Includes QAPF fields 11 and 12. LeMaitre et al. 2002.";
                    foidSyenitoid.Version = "1.4.1.0";
                }
                return foidSyenitoid;
            }
        }

        private static QualifierType foidite;
        /// <summary>
        /// Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidite")]
        public static QualifierType Foidite
        {
            get 
            {
                if (foidite == null)
                {
                    foidite = new QualifierType("foidite");
                    foidite.LithoType = EnumValueLithoType.both;
                    foidite.IsLithology = true;
                    foidite.Description = "Foiditoid that contains greater than 90 percent feldspathoid minerals in the QAPF fraction. LeMaitre et al. 2002.";
                    foidite.Version = "1.4.1.0";
                }
                return foidite;
            }
        }

        private static QualifierType foiditic;
        /// <summary>
        /// VARIANT. See "foidite".
        /// </summary>
        [EnumValueNameAttribute("foiditic")]
        public static QualifierType Foiditic
        {
            get 
            {
                if (foiditic == null)
                {
                    foiditic = new QualifierType("foiditic");
                    foiditic.LithoType = EnumValueLithoType.adjective;
                    //UNK foiditic.VariantOf = "foidite";
                    foiditic.Description = "VARIANT. See \"foidite\".";
                    foiditic.Version = "1.4.1.0";
                }
                return foiditic;
            }
        }

        private static QualifierType foiditoid;
        /// <summary>
        /// Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foiditoid")]
        public static QualifierType Foiditoid
        {
            get 
            {
                if (foiditoid == null)
                {
                    foiditoid = new QualifierType("foiditoid");
                    foiditoid.LithoType = EnumValueLithoType.noun;
                    foiditoid.IsLithology = true;
                    foiditoid.Description = "Fine grained crystalline rock containing less than 90 percent mafic minerals and more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15 or chemically in TAS field F. LeMaitre et al. 2002.";
                    foiditoid.Version = "1.4.1.0";
                }
                return foiditoid;
            }
        }

        private static QualifierType foidolite;
        /// <summary>
        /// Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("foidolite")]
        public static QualifierType Foidolite
        {
            get 
            {
                if (foidolite == null)
                {
                    foidolite = new QualifierType("foidolite");
                    foidolite.LithoType = EnumValueLithoType.both;
                    foidolite.IsLithology = true;
                    foidolite.Description = "Phaneritic crystalline rock containing more than 60 percent feldspathoid minerals in the QAPF fraction. Includes rocks defined modally in QAPF field 15. LeMaitre et al. 2002.";
                    foidolite.Version = "1.4.1.0";
                }
                return foidolite;
            }
        }

        private static QualifierType foidolitic;
        /// <summary>
        /// VARIANT. See "foidolite".
        /// </summary>
        [EnumValueNameAttribute("foidolitic")]
        public static QualifierType Foidolitic
        {
            get 
            {
                if (foidolitic == null)
                {
                    foidolitic = new QualifierType("foidolitic");
                    foidolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK foidolitic.VariantOf = "foidolite";
                    foidolitic.Description = "VARIANT. See \"foidolite\".";
                    foidolitic.Version = "1.4.1.0";
                }
                return foidolitic;
            }
        }

        private static QualifierType foliatedMetamorphicRock;
        /// <summary>
        /// Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic.
        /// </summary>
        [EnumValueNameAttribute("foliated metamorphic rock")]
        public static QualifierType FoliatedMetamorphicRock
        {
            get 
            {
                if (foliatedMetamorphicRock == null)
                {
                    foliatedMetamorphicRock = new QualifierType("foliated metamorphic rock");
                    foliatedMetamorphicRock.LithoType = EnumValueLithoType.noun;
                    foliatedMetamorphicRock.IsLithology = true;
                    foliatedMetamorphicRock.Description = "Metamorphic rock in which 10 percent or more of the contained mineral grains are elements in a planar or linear fabric. Cataclastic or glassy character precludes classification with this concept. Based on NADM SLTT metamorphic.";
                    foliatedMetamorphicRock.Version = "1.4.1.0";
                }
                return foliatedMetamorphicRock;
            }
        }

        private static QualifierType foraminifera;
        /// <summary>
        /// VARIANT. See "forams".
        /// </summary>
        [EnumValueNameAttribute("foraminifera")]
        public static QualifierType Foraminifera
        {
            get 
            {
                if (foraminifera == null)
                {
                    foraminifera = new QualifierType("foraminifera");
                    foraminifera.LithoType = EnumValueLithoType.noun;
                    //UNK foraminifera.VariantOf = "forams";
                    foraminifera.Description = "VARIANT. See \"forams\".";
                    foraminifera.Version = "1.4.0.0";
                }
                return foraminifera;
            }
        }

        private static QualifierType foraminiferous;
        /// <summary>
        /// VARIANT. See "forams".
        /// </summary>
        [EnumValueNameAttribute("foraminiferous")]
        public static QualifierType Foraminiferous
        {
            get 
            {
                if (foraminiferous == null)
                {
                    foraminiferous = new QualifierType("foraminiferous");
                    foraminiferous.LithoType = EnumValueLithoType.adjective;
                    //UNK foraminiferous.VariantOf = "forams";
                    foraminiferous.Description = "VARIANT. See \"forams\".";
                    foraminiferous.Version = "1.4.0.0";
                }
                return foraminiferous;
            }
        }

        private static QualifierType forams;
        /// <summary>
        /// Indicates that the associated lithology contains marine micro-organisms of the order Foraminifera (Devonian - Recent), having a calcareous shell.
        /// </summary>
        [EnumValueNameAttribute("forams")]
        public static QualifierType Forams
        {
            get 
            {
                if (forams == null)
                {
                    forams = new QualifierType("forams");
                    forams.LithoType = EnumValueLithoType.both;
                    forams.Description = "Indicates that the associated lithology contains marine micro-organisms of the order Foraminifera (Devonian - Recent), having a calcareous shell.";
                    forams.Version = "1.4.0.0";
                }
                return forams;
            }
        }

        private static QualifierType foramsUndifferentiated;
        /// <summary>
        /// DEPRECATED. See forams.
        /// </summary>
        [EnumValueNameAttribute("forams undifferentiated")]
        public static QualifierType ForamsUndifferentiated
        {
            get 
            {
                if (foramsUndifferentiated == null)
                {
                    foramsUndifferentiated = new QualifierType("forams undifferentiated");
                    foramsUndifferentiated.LithoType = EnumValueLithoType.noun;
                    foramsUndifferentiated.Description = "DEPRECATED. See forams.";
                    foramsUndifferentiated.Version = "1.3.1.0";
                    foramsUndifferentiated.Deprecated = "1.4.0.0";
                    foramsUndifferentiated.ReplacedBy = Forams;
                }
                return foramsUndifferentiated;
            }
        }

        private static QualifierType fossilFragment;
        /// <summary>
        /// DEPRECATED. See "fossil fragments".
        /// </summary>
        [EnumValueNameAttribute("fossil fragment")]
        public static QualifierType FossilFragment
        {
            get 
            {
                if (fossilFragment == null)
                {
                    fossilFragment = new QualifierType("fossil fragment");
                    fossilFragment.LithoType = EnumValueLithoType.noun;
                    fossilFragment.Description = "DEPRECATED. See \"fossil fragments\".";
                    fossilFragment.Version = "1.3.1.0";
                    fossilFragment.Deprecated = "1.4.0.0";
                    fossilFragment.ReplacedBy = FossilFragments;
                }
                return fossilFragment;
            }
        }

        private static QualifierType fossilFragments;
        /// <summary>
        /// Indicates that the associated lithology contains material comprised of fossils or fossil fragments.
        /// </summary>
        [EnumValueNameAttribute("fossil fragments")]
        public static QualifierType FossilFragments
        {
            get 
            {
                if (fossilFragments == null)
                {
                    fossilFragments = new QualifierType("fossil fragments");
                    fossilFragments.LithoType = EnumValueLithoType.both;
                    fossilFragments.Description = "Indicates that the associated lithology contains material comprised of fossils or fossil fragments.";
                    fossilFragments.Version = "1.4.0.0";
                }
                return fossilFragments;
            }
        }

        private static QualifierType fossiliferous;
        /// <summary>
        /// VARIANT. See "fossil fragments".
        /// </summary>
        [EnumValueNameAttribute("fossiliferous")]
        public static QualifierType Fossiliferous
        {
            get 
            {
                if (fossiliferous == null)
                {
                    fossiliferous = new QualifierType("fossiliferous");
                    fossiliferous.LithoType = EnumValueLithoType.adjective;
                    //UNK fossiliferous.VariantOf = "fossil fragments";
                    fossiliferous.Description = "VARIANT. See \"fossil fragments\".";
                    fossiliferous.Version = "1.4.0.0";
                }
                return fossiliferous;
            }
        }

        private static QualifierType fossilsUndifferentiated;
        /// <summary>
        /// Indicates that the associated lithology contains material comprised of fossils or fossil fragments of undetermined type type, form or species.
        /// </summary>
        [EnumValueNameAttribute("fossils undifferentiated")]
        public static QualifierType FossilsUndifferentiated
        {
            get 
            {
                if (fossilsUndifferentiated == null)
                {
                    fossilsUndifferentiated = new QualifierType("fossils undifferentiated");
                    fossilsUndifferentiated.LithoType = EnumValueLithoType.noun;
                    fossilsUndifferentiated.Description = "Indicates that the associated lithology contains material comprised of fossils or fossil fragments of undetermined type type, form or species.";
                    fossilsUndifferentiated.Version = "1.3.1.0";
                }
                return fossilsUndifferentiated;
            }
        }

        private static QualifierType fragmentalIgneousRock;
        /// <summary>
        /// Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite).
        /// </summary>
        [EnumValueNameAttribute("fragmental igneous rock")]
        public static QualifierType FragmentalIgneousRock
        {
            get 
            {
                if (fragmentalIgneousRock == null)
                {
                    fragmentalIgneousRock = new QualifierType("fragmental igneous rock");
                    fragmentalIgneousRock.LithoType = EnumValueLithoType.noun;
                    fragmentalIgneousRock.IsLithology = true;
                    fragmentalIgneousRock.Description = "Igneous rock in which greater than 75 percent of the rock consists of fragments produced as a result of igneous rock-forming process. Includes pyroclastic rocks, autobreccia associated with lava flows and intrusive breccias. Excludes deposits reworked by epiclastic processes (see Tuffite).";
                    fragmentalIgneousRock.Version = "1.4.1.0";
                }
                return fragmentalIgneousRock;
            }
        }

        private static QualifierType gabbro;
        /// <summary>
        /// Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbro")]
        public static QualifierType Gabbro
        {
            get 
            {
                if (gabbro == null)
                {
                    gabbro = new QualifierType("gabbro");
                    gabbro.LithoType = EnumValueLithoType.both;
                    gabbro.IsLithology = true;
                    gabbro.Description = "Gabbroic rock that contains between 0 and 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF Field 10 as gabbro. LeMaitre et al. 2002.";
                    gabbro.Version = "1.4.1.0";
                }
                return gabbro;
            }
        }

        private static QualifierType gabbroic;
        /// <summary>
        /// VARIANT. See "gabbro".
        /// </summary>
        [EnumValueNameAttribute("gabbroic")]
        public static QualifierType Gabbroic
        {
            get 
            {
                if (gabbroic == null)
                {
                    gabbroic = new QualifierType("gabbroic");
                    gabbroic.LithoType = EnumValueLithoType.adjective;
                    //UNK gabbroic.VariantOf = "gabbro";
                    gabbroic.Description = "VARIANT. See \"gabbro\".";
                    gabbroic.Version = "1.4.1.0";
                }
                return gabbroic;
            }
        }

        private static QualifierType gabbroicRock;
        /// <summary>
        /// Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroic rock")]
        public static QualifierType GabbroicRock
        {
            get 
            {
                if (gabbroicRock == null)
                {
                    gabbroicRock = new QualifierType("gabbroic rock");
                    gabbroicRock.LithoType = EnumValueLithoType.noun;
                    gabbroicRock.IsLithology = true;
                    gabbroicRock.Description = "Gabbroid that has a plagioclase to total feldspar ratio greater than 0.9 in the QAPF fraction. Includes QAPF fields 10*, 10, and 10'. This category includes the various categories defined in LeMaitre et al. (2002) based on the mafic mineralogy, but apparently not subdivided based on the quartz/feldspathoid content. LeMaitre et al. 2002.";
                    gabbroicRock.Version = "1.4.1.0";
                }
                return gabbroicRock;
            }
        }

        private static QualifierType gabbroid;
        /// <summary>
        /// Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("gabbroid")]
        public static QualifierType Gabbroid
        {
            get 
            {
                if (gabbroid == null)
                {
                    gabbroid = new QualifierType("gabbroid");
                    gabbroid.LithoType = EnumValueLithoType.both;
                    gabbroid.IsLithology = true;
                    gabbroid.Description = "Phaneritic crystalline igneous rock that contains less than 90 percent mafic minerals, and up to 20 percent quartz or up to 10 percent feldspathoid in the QAPF fraction. The ratio of plagioclase to total feldspar is greater than 0.65, and anorthite content of the plagioclase is greater than 50 percent. Includes rocks defined modally in QAPF fields 9 and 10 and their subdivisions. LeMaitre et al. 2002.";
                    gabbroid.Version = "1.4.1.0";
                }
                return gabbroid;
            }
        }

        private static QualifierType gabbroidic;
        /// <summary>
        /// VARIANT. See "gabbroid".
        /// </summary>
        [EnumValueNameAttribute("gabbroidic")]
        public static QualifierType Gabbroidic
        {
            get 
            {
                if (gabbroidic == null)
                {
                    gabbroidic = new QualifierType("gabbroidic");
                    gabbroidic.LithoType = EnumValueLithoType.adjective;
                    //UNK gabbroidic.VariantOf = "gabbroid";
                    gabbroidic.Description = "VARIANT. See \"gabbroid\".";
                    gabbroidic.Version = "1.4.1.0";
                }
                return gabbroidic;
            }
        }

        private static QualifierType gilsonite;
        /// <summary>
        /// Indicates that the associated lithology contains material containing or resembling gilsonite (uintaite), a brilliant black variety of asphalt occurring in rounded masses.
        /// </summary>
        [EnumValueNameAttribute("gilsonite")]
        public static QualifierType Gilsonite
        {
            get 
            {
                if (gilsonite == null)
                {
                    gilsonite = new QualifierType("gilsonite");
                    gilsonite.LithoType = EnumValueLithoType.both;
                    gilsonite.Description = "Indicates that the associated lithology contains material containing or resembling gilsonite (uintaite), a brilliant black variety of asphalt occurring in rounded masses.";
                    gilsonite.Version = "1.4.0.0";
                }
                return gilsonite;
            }
        }

        private static QualifierType gilsonitic;
        /// <summary>
        /// VARIANT. See "gilsonite".
        /// </summary>
        [EnumValueNameAttribute("gilsonitic")]
        public static QualifierType Gilsonitic
        {
            get 
            {
                if (gilsonitic == null)
                {
                    gilsonitic = new QualifierType("gilsonitic");
                    gilsonitic.LithoType = EnumValueLithoType.adjective;
                    //UNK gilsonitic.VariantOf = "gilsonite";
                    gilsonitic.Description = "VARIANT. See \"gilsonite\".";
                    gilsonitic.Version = "1.4.0.0";
                }
                return gilsonitic;
            }
        }

        private static QualifierType glauconite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the generally greenish authogenic clay mineral glauconite.
        /// </summary>
        [EnumValueNameAttribute("glauconite")]
        public static QualifierType Glauconite
        {
            get 
            {
                if (glauconite == null)
                {
                    glauconite = new QualifierType("glauconite");
                    glauconite.LithoType = EnumValueLithoType.both;
                    glauconite.IsLithology = true;
                    glauconite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the generally greenish authogenic clay mineral glauconite.";
                    glauconite.Version = "1.3.1.0";
                }
                return glauconite;
            }
        }

        private static QualifierType glauconitic;
        /// <summary>
        /// VARIANT. See "glauconite".
        /// </summary>
        [EnumValueNameAttribute("glauconitic")]
        public static QualifierType Glauconitic
        {
            get 
            {
                if (glauconitic == null)
                {
                    glauconitic = new QualifierType("glauconitic");
                    glauconitic.LithoType = EnumValueLithoType.adjective;
                    //UNK glauconitic.VariantOf = "glauconite";
                    glauconitic.Description = "VARIANT. See \"glauconite\".";
                    glauconitic.Version = "1.3.1.0";
                }
                return glauconitic;
            }
        }

        private static QualifierType gneiss;
        /// <summary>
        /// Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("gneiss")]
        public static QualifierType Gneiss
        {
            get 
            {
                if (gneiss == null)
                {
                    gneiss = new QualifierType("gneiss");
                    gneiss.LithoType = EnumValueLithoType.both;
                    gneiss.IsLithology = true;
                    gneiss.Description = "Foliated metamorphic rock with bands or lenticles rich in granular minerals alternating with bands or lenticles rich in minerals with a flaky or elongate prismatic habit. Mylonitic foliation or well developed, continuous schistosity (greater than 50 percent of the rock consists of grains participate in a planar or linear fabric) precludes classification with this concept. Neuendorf et al. 2005.";
                    gneiss.Version = "1.4.1.0";
                }
                return gneiss;
            }
        }

        private static QualifierType gneissic;
        /// <summary>
        /// VARIANT. See "gneiss".
        /// </summary>
        [EnumValueNameAttribute("gneissic")]
        public static QualifierType Gneissic
        {
            get 
            {
                if (gneissic == null)
                {
                    gneissic = new QualifierType("gneissic");
                    gneissic.LithoType = EnumValueLithoType.adjective;
                    //UNK gneissic.VariantOf = "gneiss";
                    gneissic.Description = "VARIANT. See \"gneiss\".";
                    gneissic.Version = "1.4.1.0";
                }
                return gneissic;
            }
        }

        private static QualifierType granite;
        /// <summary>
        /// Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granite")]
        public static QualifierType Granite
        {
            get 
            {
                if (granite == null)
                {
                    granite = new QualifierType("granite");
                    granite.LithoType = EnumValueLithoType.both;
                    granite.IsLithology = true;
                    granite.Description = "Phaneritic crystalline rock consisting of quartz, alkali feldspar and plagioclase (typically sodic) in variable amounts, usually with biotite and/or hornblende. Includes rocks defined modally in QAPF Field 3. LeMaitre et al. 2002.";
                    granite.Version = "1.4.1.0";
                }
                return granite;
            }
        }

        private static QualifierType granitic;
        /// <summary>
        /// VARIANT. See "granite".
        /// </summary>
        [EnumValueNameAttribute("granitic")]
        public static QualifierType Granitic
        {
            get 
            {
                if (granitic == null)
                {
                    granitic = new QualifierType("granitic");
                    granitic.LithoType = EnumValueLithoType.adjective;
                    //UNK granitic.VariantOf = "granite";
                    granitic.Description = "VARIANT. See \"granite\".";
                    granitic.Version = "1.4.1.0";
                }
                return granitic;
            }
        }

        private static QualifierType granodiorite;
        /// <summary>
        /// Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("granodiorite")]
        public static QualifierType Granodiorite
        {
            get 
            {
                if (granodiorite == null)
                {
                    granodiorite = new QualifierType("granodiorite");
                    granodiorite.LithoType = EnumValueLithoType.both;
                    granodiorite.IsLithology = true;
                    granodiorite.Description = "Phaneritic crystalline rock consisting essentially of quartz, sodic plagioclase and lesser amounts of alkali feldspar with minor hornblende and biotite. Includes rocks defined modally in QAPF field 4. LeMaitre et al. 2002.";
                    granodiorite.Version = "1.4.1.0";
                }
                return granodiorite;
            }
        }

        private static QualifierType granodioritic;
        /// <summary>
        /// VARIANT. See "granodiorite".
        /// </summary>
        [EnumValueNameAttribute("granodioritic")]
        public static QualifierType Granodioritic
        {
            get 
            {
                if (granodioritic == null)
                {
                    granodioritic = new QualifierType("granodioritic");
                    granodioritic.LithoType = EnumValueLithoType.adjective;
                    //UNK granodioritic.VariantOf = "granodiorite";
                    granodioritic.Description = "VARIANT. See \"granodiorite\".";
                    granodioritic.Version = "1.4.1.0";
                }
                return granodioritic;
            }
        }

        private static QualifierType granofels;
        /// <summary>
        /// Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004.
        /// </summary>
        [EnumValueNameAttribute("granofels")]
        public static QualifierType Granofels
        {
            get 
            {
                if (granofels == null)
                {
                    granofels = new QualifierType("granofels");
                    granofels.LithoType = EnumValueLithoType.noun;
                    granofels.IsLithology = true;
                    granofels.Description = "Metamorphic rock with granoblastic fabric and very little or no foliation (less than 10 percent of the mineral grains in the rock are elements in a planar or linear fabric). Grainsize not specified. SLTTm 2004.";
                    granofels.Version = "1.4.1.0";
                }
                return granofels;
            }
        }

        private static QualifierType granulite;
        /// <summary>
        /// Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2
        /// </summary>
        [EnumValueNameAttribute("granulite")]
        public static QualifierType Granulite
        {
            get 
            {
                if (granulite == null)
                {
                    granulite = new QualifierType("granulite");
                    granulite.LithoType = EnumValueLithoType.both;
                    granulite.IsLithology = true;
                    granulite.Description = "Metamorphic rock of high metamorphic grade in which Fe-Mg silicate minerals are dominantly hydroxl-free; feldspar must be present, and muscovite is absent; rock contains less than 90 percent mafic minerals, less than 75 percent calcite and/or dolomite, less than 75 percent quartz, less than 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), and less than 50 percent calc-silicate minerals. Fettes and Desmons (2007). See also Wimmenauer (1985), Winkler (1979) (D.R. Bowes (1989), The Encyclopedia of Igneous and Metamorphic Petrology; Van Nostrand Reinhold ISBN: 0-442-20623-2";
                    granulite.Version = "1.4.1.0";
                }
                return granulite;
            }
        }

        private static QualifierType granulitic;
        /// <summary>
        /// VARIANT. See "granulite".
        /// </summary>
        [EnumValueNameAttribute("granulitic")]
        public static QualifierType Granulitic
        {
            get 
            {
                if (granulitic == null)
                {
                    granulitic = new QualifierType("granulitic");
                    granulitic.LithoType = EnumValueLithoType.adjective;
                    //UNK granulitic.VariantOf = "granulite";
                    granulitic.Description = "VARIANT. See \"granulite\".";
                    granulitic.Version = "1.4.1.0";
                }
                return granulitic;
            }
        }

        private static QualifierType gravel;
        /// <summary>
        /// Indicates that the associated lithology contains particles in the size range of 2mm - 20mm.
        /// </summary>
        [EnumValueNameAttribute("gravel")]
        public static QualifierType Gravel
        {
            get 
            {
                if (gravel == null)
                {
                    gravel = new QualifierType("gravel");
                    gravel.LithoType = EnumValueLithoType.both;
                    gravel.IsLithology = true;
                    gravel.Description = "Indicates that the associated lithology contains particles in the size range of 2mm - 20mm.";
                    gravel.Version = "1.4.0.0";
                }
                return gravel;
            }
        }

        private static QualifierType gravelly;
        /// <summary>
        /// VARIANT. See "gravel".
        /// </summary>
        [EnumValueNameAttribute("gravelly")]
        public static QualifierType Gravelly
        {
            get 
            {
                if (gravelly == null)
                {
                    gravelly = new QualifierType("gravelly");
                    gravelly.LithoType = EnumValueLithoType.adjective;
                    //UNK gravelly.VariantOf = "gravel";
                    gravelly.Description = "VARIANT. See \"gravel\".";
                    gravelly.Version = "1.3.1.0";
                }
                return gravelly;
            }
        }

        private static QualifierType greenstone;
        /// <summary>
        /// Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone.
        /// </summary>
        [EnumValueNameAttribute("greenstone")]
        public static QualifierType Greenstone
        {
            get 
            {
                if (greenstone == null)
                {
                    greenstone = new QualifierType("greenstone");
                    greenstone.LithoType = EnumValueLithoType.noun;
                    greenstone.IsLithology = true;
                    greenstone.Description = "Chlorite actinolite epidote metamorphic rocks. Metamorphic rock characterized by 50 percent or more of combined chlorite, actinolite and epidote. Category for rocks generally named greenschist or greenstone. OneGeology, simplified for WITSML to Greenstone.";
                    greenstone.Version = "1.4.1.0";
                }
                return greenstone;
            }
        }

        private static QualifierType gumbo;
        /// <summary>
        /// A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet.
        /// </summary>
        [EnumValueNameAttribute("gumbo")]
        public static QualifierType Gumbo
        {
            get 
            {
                if (gumbo == null)
                {
                    gumbo = new QualifierType("gumbo");
                    gumbo.LithoType = EnumValueLithoType.noun;
                    gumbo.IsLithology = true;
                    gumbo.Description = "A term used in the U.S. for clay soils that become sticky, impervious, and plastic when wet.";
                    gumbo.Version = "1.4.1.0";
                }
                return gumbo;
            }
        }

        private static QualifierType gypsiferous;
        /// <summary>
        /// VARIANT. See "gypsum".
        /// </summary>
        [EnumValueNameAttribute("gypsiferous")]
        public static QualifierType Gypsiferous
        {
            get 
            {
                if (gypsiferous == null)
                {
                    gypsiferous = new QualifierType("gypsiferous");
                    gypsiferous.LithoType = EnumValueLithoType.adjective;
                    //UNK gypsiferous.VariantOf = "gypsum";
                    gypsiferous.Description = "VARIANT. See \"gypsum\".";
                    gypsiferous.Version = "1.3.1.0";
                }
                return gypsiferous;
            }
        }

        private static QualifierType gypsum;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the evaporite mineral gypsum (CaSO4.2H2O).
        /// </summary>
        [EnumValueNameAttribute("gypsum")]
        public static QualifierType Gypsum
        {
            get 
            {
                if (gypsum == null)
                {
                    gypsum = new QualifierType("gypsum");
                    gypsum.LithoType = EnumValueLithoType.both;
                    gypsum.IsLithology = true;
                    gypsum.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the evaporite mineral gypsum (CaSO4.2H2O).";
                    gypsum.Version = "1.4.0.0";
                }
                return gypsum;
            }
        }

        private static QualifierType halite;
        /// <summary>
        /// Indicates that the associated lithology contains or resembles the common evaporite mineral Halite (NaCl).
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static QualifierType Halite
        {
            get 
            {
                if (halite == null)
                {
                    halite = new QualifierType("halite");
                    halite.LithoType = EnumValueLithoType.both;
                    halite.IsLithology = true;
                    halite.Description = "Indicates that the associated lithology contains or resembles the common evaporite mineral Halite (NaCl).";
                    halite.Version = "1.3.1.0";
                }
                return halite;
            }
        }

        private static QualifierType halitic;
        /// <summary>
        /// VARIANT. See "halite".
        /// </summary>
        [EnumValueNameAttribute("halitic")]
        public static QualifierType Halitic
        {
            get 
            {
                if (halitic == null)
                {
                    halitic = new QualifierType("halitic");
                    halitic.LithoType = EnumValueLithoType.adjective;
                    //UNK halitic.VariantOf = "halite";
                    halitic.Description = "VARIANT. See \"halite\".";
                    halitic.Version = "1.4.0.0";
                }
                return halitic;
            }
        }

        private static QualifierType hornfels;
        /// <summary>
        /// Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained.
        /// </summary>
        [EnumValueNameAttribute("hornfels")]
        public static QualifierType Hornfels
        {
            get 
            {
                if (hornfels == null)
                {
                    hornfels = new QualifierType("hornfels");
                    hornfels.LithoType = EnumValueLithoType.both;
                    hornfels.IsLithology = true;
                    hornfels.Description = "Granofels formed by contact metamorphism, composed of a mosaic of equidimensional grains in a characteristically granoblastic or decussate matrix; porphyroblasts or relict phenocrysts may be present. Typically fine grained.";
                    hornfels.Version = "1.4.1.0";
                }
                return hornfels;
            }
        }

        private static QualifierType hornfelsic;
        /// <summary>
        /// VARIANT. See "hornfels".
        /// </summary>
        [EnumValueNameAttribute("hornfelsic")]
        public static QualifierType Hornfelsic
        {
            get 
            {
                if (hornfelsic == null)
                {
                    hornfelsic = new QualifierType("hornfelsic");
                    hornfelsic.LithoType = EnumValueLithoType.adjective;
                    //UNK hornfelsic.VariantOf = "hornfels";
                    hornfelsic.Description = "VARIANT. See \"hornfels\".";
                    hornfelsic.Version = "1.4.1.0";
                }
                return hornfelsic;
            }
        }

        private static QualifierType igneous;
        /// <summary>
        /// VARIANT. See "igneous rock".
        /// </summary>
        [EnumValueNameAttribute("igneous")]
        public static QualifierType Igneous
        {
            get 
            {
                if (igneous == null)
                {
                    igneous = new QualifierType("igneous");
                    igneous.LithoType = EnumValueLithoType.adjective;
                    //UNK igneous.VariantOf = "igneous rock";
                    igneous.Description = "VARIANT. See \"igneous rock\".";
                    igneous.Version = "1.4.1.0";
                }
                return igneous;
            }
        }

        private static QualifierType igneousRock;
        /// <summary>
        /// Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("igneous rock")]
        public static QualifierType IgneousRock
        {
            get 
            {
                if (igneousRock == null)
                {
                    igneousRock = new QualifierType("igneous rock");
                    igneousRock.LithoType = EnumValueLithoType.both;
                    igneousRock.IsLithology = true;
                    igneousRock.Description = "Undefined rock formed as a result of igneous processes, for example intrusion and cooling of magma in the crust, or volcanic eruption. Neuendorf et al 2005.";
                    igneousRock.Version = "1.4.1.0";
                }
                return igneousRock;
            }
        }

        private static QualifierType illite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral illite.
        /// </summary>
        [EnumValueNameAttribute("illite")]
        public static QualifierType Illite
        {
            get 
            {
                if (illite == null)
                {
                    illite = new QualifierType("illite");
                    illite.LithoType = EnumValueLithoType.both;
                    illite.IsMatrixCement = true;
                    illite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral illite.";
                    illite.Version = "1.3.1.0";
                }
                return illite;
            }
        }

        private static QualifierType illitic;
        /// <summary>
        /// VARIANT. See "illite".
        /// </summary>
        [EnumValueNameAttribute("illitic")]
        public static QualifierType Illitic
        {
            get 
            {
                if (illitic == null)
                {
                    illitic = new QualifierType("illitic");
                    illitic.LithoType = EnumValueLithoType.adjective;
                    //UNK illitic.VariantOf = "illite";
                    illitic.Description = "VARIANT. See \"illite\".";
                    illitic.Version = "1.4.0.0";
                }
                return illitic;
            }
        }

        private static QualifierType impactGeneratedMaterial;
        /// <summary>
        /// Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("impact generated material")]
        public static QualifierType ImpactGeneratedMaterial
        {
            get 
            {
                if (impactGeneratedMaterial == null)
                {
                    impactGeneratedMaterial = new QualifierType("impact generated material");
                    impactGeneratedMaterial.LithoType = EnumValueLithoType.noun;
                    impactGeneratedMaterial.IsLithology = true;
                    impactGeneratedMaterial.Description = "Material that contains features indicative of shock metamorphism, such as microscopic planar deformation features within grains or shatter cones, interpreted to be the result of extraterrestrial bolide impact. Includes breccias and melt rocks. StÃ¶ffler and Grieve 2007; Jackson 1997.";
                    impactGeneratedMaterial.Version = "1.4.1.0";
                }
                return impactGeneratedMaterial;
            }
        }

        private static QualifierType impureDolomite;
        /// <summary>
        /// Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure dolomite")]
        public static QualifierType ImpureDolomite
        {
            get 
            {
                if (impureDolomite == null)
                {
                    impureDolomite = new QualifierType("impure dolomite");
                    impureDolomite.LithoType = EnumValueLithoType.noun;
                    impureDolomite.IsLithology = true;
                    impureDolomite.Description = "Impure carbonate sedimentary rock with a ratio of magnesium carbonate to calcite (plus aragonite) greater than 1 to 1. OneGeology.";
                    impureDolomite.Version = "1.4.1.0";
                }
                return impureDolomite;
            }
        }

        private static QualifierType impureLimestone;
        /// <summary>
        /// Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("impure limestone")]
        public static QualifierType ImpureLimestone
        {
            get 
            {
                if (impureLimestone == null)
                {
                    impureLimestone = new QualifierType("impure limestone");
                    impureLimestone.LithoType = EnumValueLithoType.noun;
                    impureLimestone.IsLithology = true;
                    impureLimestone.Description = "Impure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. OneGeology.";
                    impureLimestone.Version = "1.4.1.0";
                }
                return impureLimestone;
            }
        }

        private static QualifierType intrusiveRockPlutonic;
        /// <summary>
        /// Igneous rock formed by cooling and solidification of magma within the earth's crust.
        /// </summary>
        [EnumValueNameAttribute("intrusive rock (plutonic)")]
        public static QualifierType IntrusiveRockPlutonic
        {
            get 
            {
                if (intrusiveRockPlutonic == null)
                {
                    intrusiveRockPlutonic = new QualifierType("intrusive rock (plutonic)");
                    intrusiveRockPlutonic.LithoType = EnumValueLithoType.noun;
                    intrusiveRockPlutonic.IsLithology = true;
                    intrusiveRockPlutonic.Description = "Igneous rock formed by cooling and solidification of magma within the earth's crust.";
                    intrusiveRockPlutonic.Version = "1.4.1.0";
                }
                return intrusiveRockPlutonic;
            }
        }

        private static QualifierType ironRichSedimentaryRock;
        /// <summary>
        /// Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004.
        /// </summary>
        [EnumValueNameAttribute("iron rich sedimentary rock")]
        public static QualifierType IronRichSedimentaryRock
        {
            get 
            {
                if (ironRichSedimentaryRock == null)
                {
                    ironRichSedimentaryRock = new QualifierType("iron rich sedimentary rock");
                    ironRichSedimentaryRock.LithoType = EnumValueLithoType.both;
                    ironRichSedimentaryRock.IsLithology = true;
                    ironRichSedimentaryRock.Description = "Sedimentary rock that consists of at least 50 percent iron-bearing minerals (hematite, magnetite, limonite-group, siderite, iron-sulfides), as determined by hand-lens or petrographic analysis. Corresponds to a rock typically containing 15 percent iron by weight. Hallsworth and Knox 1999; SLTTs 2004.";
                    ironRichSedimentaryRock.Version = "1.4.1.0";
                }
                return ironRichSedimentaryRock;
            }
        }

        private static QualifierType kalsiliticAndMeliliticRocks;
        /// <summary>
        /// Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("kalsilitic and melilitic rocks")]
        public static QualifierType KalsiliticAndMeliliticRocks
        {
            get 
            {
                if (kalsiliticAndMeliliticRocks == null)
                {
                    kalsiliticAndMeliliticRocks = new QualifierType("kalsilitic and melilitic rocks");
                    kalsiliticAndMeliliticRocks.LithoType = EnumValueLithoType.noun;
                    kalsiliticAndMeliliticRocks.IsLithology = true;
                    kalsiliticAndMeliliticRocks.Description = "Igneous rock containing greater than 10 percent melilite or kalsilite. Typically undersaturated, ultrapotassic (kalsilitic rocks) or calcium-rich (melilitic rocks) mafic or ultramafic rocks. LeMaitre et al. 2002.";
                    kalsiliticAndMeliliticRocks.Version = "1.4.1.0";
                }
                return kalsiliticAndMeliliticRocks;
            }
        }

        private static QualifierType kaolinite;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral kaolinite.
        /// </summary>
        [EnumValueNameAttribute("kaolinite")]
        public static QualifierType Kaolinite
        {
            get 
            {
                if (kaolinite == null)
                {
                    kaolinite = new QualifierType("kaolinite");
                    kaolinite.LithoType = EnumValueLithoType.both;
                    kaolinite.IsMatrixCement = true;
                    kaolinite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral kaolinite.";
                    kaolinite.Version = "1.3.1.0";
                }
                return kaolinite;
            }
        }

        private static QualifierType kaolinitic;
        /// <summary>
        /// VARIANT. See "kaolinite".
        /// </summary>
        [EnumValueNameAttribute("kaolinitic")]
        public static QualifierType Kaolinitic
        {
            get 
            {
                if (kaolinitic == null)
                {
                    kaolinitic = new QualifierType("kaolinitic");
                    kaolinitic.LithoType = EnumValueLithoType.adjective;
                    //UNK kaolinitic.VariantOf = "kaolinite";
                    kaolinitic.Description = "VARIANT. See \"kaolinite\".";
                    kaolinitic.Version = "1.4.0.0";
                }
                return kaolinitic;
            }
        }

        private static QualifierType komatiiticRock;
        /// <summary>
        /// Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("komatiitic rock")]
        public static QualifierType KomatiiticRock
        {
            get 
            {
                if (komatiiticRock == null)
                {
                    komatiiticRock = new QualifierType("komatiitic rock");
                    komatiiticRock.LithoType = EnumValueLithoType.noun;
                    komatiiticRock.IsLithology = true;
                    komatiiticRock.Description = "Ultramafic, magnesium-rich volcanic rock, typically with spinifex texture of intergrown skeletal and bladed olivine and pyroxene crystals set in abundant glass. Includes komatiite and meimechite. LeMaitre et al. 2002.";
                    komatiiticRock.Version = "1.4.1.0";
                }
                return komatiiticRock;
            }
        }

        private static QualifierType latiticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("latitic rock")]
        public static QualifierType LatiticRock
        {
            get 
            {
                if (latiticRock == null)
                {
                    latiticRock = new QualifierType("latitic rock");
                    latiticRock.LithoType = EnumValueLithoType.noun;
                    latiticRock.IsLithology = true;
                    latiticRock.Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.35 and 0.65. QAPF fields 8, 8' and 8*. LeMaitre et al. 2002.";
                    latiticRock.Version = "1.4.1.0";
                }
                return latiticRock;
            }
        }

        private static QualifierType lignite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a soft brownish-black form of coal.
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static QualifierType Lignite
        {
            get 
            {
                if (lignite == null)
                {
                    lignite = new QualifierType("lignite");
                    lignite.LithoType = EnumValueLithoType.both;
                    lignite.IsLithology = true;
                    lignite.Description = "Indicates that the associated lithology comprises material containing or resembling a soft brownish-black form of coal.";
                    lignite.Version = "1.3.1.0";
                }
                return lignite;
            }
        }

        private static QualifierType lignitic;
        /// <summary>
        /// VARIANT. See "lignite".
        /// </summary>
        [EnumValueNameAttribute("lignitic")]
        public static QualifierType Lignitic
        {
            get 
            {
                if (lignitic == null)
                {
                    lignitic = new QualifierType("lignitic");
                    lignitic.LithoType = EnumValueLithoType.adjective;
                    //UNK lignitic.VariantOf = "lignite";
                    lignitic.Description = "VARIANT. See \"lignite\".";
                    lignitic.Version = "1.4.0.0";
                }
                return lignitic;
            }
        }

        private static QualifierType limeBoundstone;
        /// <summary>
        /// Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime boundstone")]
        public static QualifierType LimeBoundstone
        {
            get 
            {
                if (limeBoundstone == null)
                {
                    limeBoundstone = new QualifierType("lime boundstone");
                    limeBoundstone.LithoType = EnumValueLithoType.noun;
                    limeBoundstone.IsLithology = true;
                    limeBoundstone.Description = "Biogenic textural class. The origianl components were bound and encrusted together by the action of plants and animals in the position of growth. That is, Reef limestones. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limeBoundstone.Version = "1.4.1.0";
                }
                return limeBoundstone;
            }
        }

        private static QualifierType limeFramestone;
        /// <summary>
        /// Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth &amp; Knox 1999; SLTTs 2004, Table 15-3-1
        /// </summary>
        [EnumValueNameAttribute("lime framestone")]
        public static QualifierType LimeFramestone
        {
            get 
            {
                if (limeFramestone == null)
                {
                    limeFramestone = new QualifierType("lime framestone");
                    limeFramestone.LithoType = EnumValueLithoType.noun;
                    limeFramestone.IsLithology = true;
                    limeFramestone.Description = "Biogenic textural class. Carbonate reef rock consisting of a rigid framework of colonies, shells or skeletons, with internal cavities filled with fine sediment; usually created through the activities of colonial organisms. Source () Hallsworth & Knox 1999; SLTTs 2004, Table 15-3-1";
                    limeFramestone.Version = "1.4.1.0";
                }
                return limeFramestone;
            }
        }

        private static QualifierType limeGrainstone;
        /// <summary>
        /// Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime grainstone")]
        public static QualifierType LimeGrainstone
        {
            get 
            {
                if (limeGrainstone == null)
                {
                    limeGrainstone = new QualifierType("lime grainstone");
                    limeGrainstone.LithoType = EnumValueLithoType.noun;
                    limeGrainstone.IsLithology = true;
                    limeGrainstone.Description = "Depositional textural cassification. Grain supported carbonate with little ( less than 25 percent) carbonate matrix. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limeGrainstone.Version = "1.4.1.0";
                }
                return limeGrainstone;
            }
        }

        private static QualifierType limeMudstone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary.
        /// </summary>
        [EnumValueNameAttribute("lime mudstone")]
        public static QualifierType LimeMudstone
        {
            get 
            {
                if (limeMudstone == null)
                {
                    limeMudstone = new QualifierType("lime mudstone");
                    limeMudstone.LithoType = EnumValueLithoType.noun;
                    limeMudstone.IsLithology = true;
                    limeMudstone.Description = "Depositional textural cassification. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Less than 10 percent Grains. Mudstone that contains between 10 and 50 percent carbonate minerals in the mud size fraction. Carbonate origin is not specified. The operational test typically used to identify this category is if the rock fizzes when hydrochloric acid is applied. The '10 percent carbonate' criteria is a fuzzy boundary.";
                    limeMudstone.Version = "1.4.1.0";
                }
                return limeMudstone;
            }
        }

        private static QualifierType limePackstone;
        /// <summary>
        /// Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime packstone")]
        public static QualifierType LimePackstone
        {
            get 
            {
                if (limePackstone == null)
                {
                    limePackstone = new QualifierType("lime packstone");
                    limePackstone.LithoType = EnumValueLithoType.noun;
                    limePackstone.IsLithology = true;
                    limePackstone.Description = "Grain supported carbonate. Original components not bound together during deposition. Contains mud (clay and fine silt-size carbonate). Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limePackstone.Version = "1.4.1.0";
                }
                return limePackstone;
            }
        }

        private static QualifierType limeWackestone;
        /// <summary>
        /// Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.
        /// </summary>
        [EnumValueNameAttribute("lime wackestone")]
        public static QualifierType LimeWackestone
        {
            get 
            {
                if (limeWackestone == null)
                {
                    limeWackestone = new QualifierType("lime wackestone");
                    limeWackestone.LithoType = EnumValueLithoType.noun;
                    limeWackestone.IsLithology = true;
                    limeWackestone.Description = "Depositional textural cassification. Original components not bound together during deposition. Matrix supported. Contains less than 75 percent mud grade (less than 32 micrometer) calcite. (clay and fine silt-size carbonate). Mud-supported (particles greater than 20 mm). Greater than 10 percent Grains. Hallsworth and Knox 1999. These are incremental additions to OneGeology to add the Dunham depositional terms used in Carbonates. When plotting these, they will all plot as Limestone.";
                    limeWackestone.Version = "1.4.1.0";
                }
                return limeWackestone;
            }
        }

        private static QualifierType limestone;
        /// <summary>
        /// Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("limestone")]
        public static QualifierType Limestone
        {
            get 
            {
                if (limestone == null)
                {
                    limestone = new QualifierType("limestone");
                    limestone.LithoType = EnumValueLithoType.noun;
                    limestone.IsLithology = true;
                    limestone.Description = "Pure carbonate sedimentary rock with a calcite (plus aragonite) to dolomite ratio greater than 1 to 1. Includes limestone and dolomitic limestone. OneGeology.";
                    limestone.Version = "1.4.1.0";
                }
                return limestone;
            }
        }

        private static QualifierType limestoneStringer;
        /// <summary>
        /// Indicates that the associated lithology contains thin beds of limestone.
        /// </summary>
        [EnumValueNameAttribute("limestone stringer")]
        public static QualifierType LimestoneStringer
        {
            get 
            {
                if (limestoneStringer == null)
                {
                    limestoneStringer = new QualifierType("limestone stringer");
                    limestoneStringer.LithoType = EnumValueLithoType.noun;
                    limestoneStringer.Description = "Indicates that the associated lithology contains thin beds of limestone.";
                    limestoneStringer.Version = "1.3.1.0";
                }
                return limestoneStringer;
            }
        }

        private static QualifierType limestoneArgillaceous;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% clay minerals.
        /// </summary>
        [EnumValueNameAttribute("limestone, argillaceous")]
        public static QualifierType LimestoneArgillaceous
        {
            get 
            {
                if (limestoneArgillaceous == null)
                {
                    limestoneArgillaceous = new QualifierType("limestone, argillaceous");
                    limestoneArgillaceous.LithoType = EnumValueLithoType.noun;
                    limestoneArgillaceous.IsLithology = true;
                    limestoneArgillaceous.Description = "A limestone homogeneously mixed with 10-50% clay minerals.";
                    limestoneArgillaceous.Version = "1.4.1.0";
                }
                return limestoneArgillaceous;
            }
        }

        private static QualifierType limestoneDolomitic;
        /// <summary>
        /// A limestone containing 10-50% dolomite and 50-90% calcite.
        /// </summary>
        [EnumValueNameAttribute("limestone, dolomitic")]
        public static QualifierType LimestoneDolomitic
        {
            get 
            {
                if (limestoneDolomitic == null)
                {
                    limestoneDolomitic = new QualifierType("limestone, dolomitic");
                    limestoneDolomitic.LithoType = EnumValueLithoType.noun;
                    limestoneDolomitic.IsLithology = true;
                    limestoneDolomitic.Description = "A limestone containing 10-50% dolomite and 50-90% calcite.";
                    limestoneDolomitic.Version = "1.4.1.0";
                }
                return limestoneDolomitic;
            }
        }

        private static QualifierType limestoneSandy;
        /// <summary>
        /// A limestone homogeneously mixed with 10-50% quartz grains.
        /// </summary>
        [EnumValueNameAttribute("limestone, sandy")]
        public static QualifierType LimestoneSandy
        {
            get 
            {
                if (limestoneSandy == null)
                {
                    limestoneSandy = new QualifierType("limestone, sandy");
                    limestoneSandy.LithoType = EnumValueLithoType.noun;
                    limestoneSandy.IsLithology = true;
                    limestoneSandy.Description = "A limestone homogeneously mixed with 10-50% quartz grains.";
                    limestoneSandy.Version = "1.4.1.0";
                }
                return limestoneSandy;
            }
        }

        private static QualifierType lithic;
        /// <summary>
        /// VARIANT. See "lithic fragments".
        /// </summary>
        [EnumValueNameAttribute("lithic")]
        public static QualifierType Lithic
        {
            get 
            {
                if (lithic == null)
                {
                    lithic = new QualifierType("lithic");
                    lithic.LithoType = EnumValueLithoType.adjective;
                    //UNK lithic.VariantOf = "lithic fragments";
                    lithic.Description = "VARIANT. See \"lithic fragments\".";
                    lithic.Version = "1.4.0.0";
                }
                return lithic;
            }
        }

        private static QualifierType lithicFragment;
        /// <summary>
        /// DEPRECATED. See "lithic fragments".
        /// </summary>
        [EnumValueNameAttribute("lithic fragment")]
        public static QualifierType LithicFragment
        {
            get 
            {
                if (lithicFragment == null)
                {
                    lithicFragment = new QualifierType("lithic fragment");
                    lithicFragment.LithoType = EnumValueLithoType.noun;
                    lithicFragment.Description = "DEPRECATED. See \"lithic fragments\".";
                    lithicFragment.Version = "1.3.1.0";
                    lithicFragment.Deprecated = "1.4.0.0";
                    lithicFragment.ReplacedBy = LithicFragments;
                }
                return lithicFragment;
            }
        }

        private static QualifierType lithicFragments;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of undetermined rock fragments.
        /// </summary>
        [EnumValueNameAttribute("lithic fragments")]
        public static QualifierType LithicFragments
        {
            get 
            {
                if (lithicFragments == null)
                {
                    lithicFragments = new QualifierType("lithic fragments");
                    lithicFragments.LithoType = EnumValueLithoType.both;
                    lithicFragments.Description = "Indicates that the associated lithology comprises material containing or characteristic of undetermined rock fragments.";
                    lithicFragments.Version = "1.4.0.0";
                }
                return lithicFragments;
            }
        }

        private static QualifierType marble;
        /// <summary>
        /// Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007
        /// </summary>
        [EnumValueNameAttribute("marble")]
        public static QualifierType Marble
        {
            get 
            {
                if (marble == null)
                {
                    marble = new QualifierType("marble");
                    marble.LithoType = EnumValueLithoType.noun;
                    marble.IsLithology = true;
                    marble.Description = "Metamorphic rock consisting of greater than 75 percent fine- to coarse-grained recrystallized calcite and/or dolomite; usually with a granoblastic, saccharoidal texture. IUGS SCMR 2007";
                    marble.Version = "1.4.1.0";
                }
                return marble;
            }
        }

        private static QualifierType marcasite;
        /// <summary>
        /// Indicates that the associate lithology comprises material containing or characteristic of the white (gem) form of iron pyrites (FeS).
        /// </summary>
        [EnumValueNameAttribute("marcasite")]
        public static QualifierType Marcasite
        {
            get 
            {
                if (marcasite == null)
                {
                    marcasite = new QualifierType("marcasite");
                    marcasite.LithoType = EnumValueLithoType.both;
                    marcasite.Description = "Indicates that the associate lithology comprises material containing or characteristic of the white (gem) form of iron pyrites (FeS).";
                    marcasite.Version = "1.4.0.0";
                }
                return marcasite;
            }
        }

        private static QualifierType marcasitic;
        /// <summary>
        /// VARIANT. See "marcasite".
        /// </summary>
        [EnumValueNameAttribute("marcasitic")]
        public static QualifierType Marcasitic
        {
            get 
            {
                if (marcasitic == null)
                {
                    marcasitic = new QualifierType("marcasitic");
                    marcasitic.LithoType = EnumValueLithoType.adjective;
                    //UNK marcasitic.VariantOf = "marcasite";
                    marcasitic.Description = "VARIANT. See \"marcasite\".";
                    marcasitic.Version = "1.4.0.0";
                }
                return marcasitic;
            }
        }

        private static QualifierType marl;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of a crumbly mixture of clays, calcium and magnesium carbonates.
        /// </summary>
        [EnumValueNameAttribute("marl")]
        public static QualifierType Marl
        {
            get 
            {
                if (marl == null)
                {
                    marl = new QualifierType("marl");
                    marl.LithoType = EnumValueLithoType.both;
                    marl.IsLithology = true;
                    marl.Description = "Indicates that the associated lithology comprises material containing or characteristic of a crumbly mixture of clays, calcium and magnesium carbonates.";
                    marl.Version = "1.4.0.0";
                }
                return marl;
            }
        }

        private static QualifierType marly;
        /// <summary>
        /// VARIANT. See "marl".
        /// </summary>
        [EnumValueNameAttribute("marly")]
        public static QualifierType Marly
        {
            get 
            {
                if (marly == null)
                {
                    marly = new QualifierType("marly");
                    marly.LithoType = EnumValueLithoType.adjective;
                    //UNK marly.VariantOf = "marl";
                    marly.Description = "VARIANT. See \"marl\".";
                    marly.Version = "1.3.1.0";
                }
                return marly;
            }
        }

        private static QualifierType metamorphicRock;
        /// <summary>
        /// Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997.
        /// </summary>
        [EnumValueNameAttribute("metamorphic rock")]
        public static QualifierType MetamorphicRock
        {
            get 
            {
                if (metamorphicRock == null)
                {
                    metamorphicRock = new QualifierType("metamorphic rock");
                    metamorphicRock.LithoType = EnumValueLithoType.noun;
                    metamorphicRock.IsLithology = true;
                    metamorphicRock.Description = "Undefined rock formed by solid-state mineralogical, chemical and/or structural changes to a pre-existing rock, in response to marked changes in temperature, pressure, shearing stress and chemical environment. Not further defined. Jackson 1997.";
                    metamorphicRock.Version = "1.4.1.0";
                }
                return metamorphicRock;
            }
        }

        private static QualifierType mica;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of mica, a group of hydrous aluminosilicate minerals that split easily into thin partly-transparent sheets.
        /// </summary>
        [EnumValueNameAttribute("mica")]
        public static QualifierType Mica
        {
            get 
            {
                if (mica == null)
                {
                    mica = new QualifierType("mica");
                    mica.LithoType = EnumValueLithoType.both;
                    mica.Description = "Indicates that the associated lithology comprises material containing or characteristic of mica, a group of hydrous aluminosilicate minerals that split easily into thin partly-transparent sheets.";
                    mica.Version = "1.3.1.0";
                }
                return mica;
            }
        }

        private static QualifierType micaSchist;
        /// <summary>
        /// A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("mica schist")]
        public static QualifierType MicaSchist
        {
            get 
            {
                if (micaSchist == null)
                {
                    micaSchist = new QualifierType("mica schist");
                    micaSchist.LithoType = EnumValueLithoType.noun;
                    micaSchist.IsLithology = true;
                    micaSchist.Description = "A schist that consists of more than 50 percent mica minerals, typically muscovite or biotite. Special type included to distinguish this common variety of schist. OneGeology.";
                    micaSchist.Version = "1.4.1.0";
                }
                return micaSchist;
            }
        }

        private static QualifierType micaceous;
        /// <summary>
        /// VARIANT. See "mica".
        /// </summary>
        [EnumValueNameAttribute("micaceous")]
        public static QualifierType Micaceous
        {
            get 
            {
                if (micaceous == null)
                {
                    micaceous = new QualifierType("micaceous");
                    micaceous.LithoType = EnumValueLithoType.adjective;
                    //UNK micaceous.VariantOf = "mica";
                    micaceous.Description = "VARIANT. See \"mica\".";
                    micaceous.Version = "1.4.0.0";
                }
                return micaceous;
            }
        }

        private static QualifierType microfossil;
        /// <summary>
        /// DEPRECATED. See microfossils.
        /// </summary>
        [EnumValueNameAttribute("microfossil")]
        public static QualifierType Microfossil
        {
            get 
            {
                if (microfossil == null)
                {
                    microfossil = new QualifierType("microfossil");
                    microfossil.LithoType = EnumValueLithoType.noun;
                    microfossil.Description = "DEPRECATED. See microfossils.";
                    microfossil.Version = "1.3.1.0";
                    microfossil.Deprecated = "1.4.0.0";
                    microfossil.ReplacedBy = Microfossils;
                }
                return microfossil;
            }
        }

        private static QualifierType microfossiliferous;
        /// <summary>
        /// VARIANT. See "microfossils".
        /// </summary>
        [EnumValueNameAttribute("microfossiliferous")]
        public static QualifierType Microfossiliferous
        {
            get 
            {
                if (microfossiliferous == null)
                {
                    microfossiliferous = new QualifierType("microfossiliferous");
                    microfossiliferous.LithoType = EnumValueLithoType.adjective;
                    //UNK microfossiliferous.VariantOf = "microfossils";
                    microfossiliferous.Description = "VARIANT. See \"microfossils\".";
                    microfossiliferous.Version = "1.4.0.0";
                }
                return microfossiliferous;
            }
        }

        private static QualifierType microfossils;
        /// <summary>
        /// Indicates that the associated lithology contains undifferentiated microscopic fossils.
        /// </summary>
        [EnumValueNameAttribute("microfossils")]
        public static QualifierType Microfossils
        {
            get 
            {
                if (microfossils == null)
                {
                    microfossils = new QualifierType("microfossils");
                    microfossils.LithoType = EnumValueLithoType.both;
                    microfossils.Description = "Indicates that the associated lithology contains undifferentiated microscopic fossils.";
                    microfossils.Version = "1.4.0.0";
                }
                return microfossils;
            }
        }

        private static QualifierType migmatite;
        /// <summary>
        /// Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)
        /// </summary>
        [EnumValueNameAttribute("migmatite")]
        public static QualifierType Migmatite
        {
            get 
            {
                if (migmatite == null)
                {
                    migmatite = new QualifierType("migmatite");
                    migmatite.LithoType = EnumValueLithoType.both;
                    migmatite.IsLithology = true;
                    migmatite.Description = "Silicate metamorphic rock that is pervasively heterogeneous on a decimeter to meter scale that typically consists of darker and lighter parts; the darker parts usually exhibit features of metamorphic rocks whereas the lighter parts are of igneous-looking appearance. Fette and Desmons (2007)";
                    migmatite.Version = "1.4.1.0";
                }
                return migmatite;
            }
        }

        private static QualifierType migmatitic;
        /// <summary>
        /// VARIANT. See "migmatite".
        /// </summary>
        [EnumValueNameAttribute("migmatitic")]
        public static QualifierType Migmatitic
        {
            get 
            {
                if (migmatitic == null)
                {
                    migmatitic = new QualifierType("migmatitic");
                    migmatitic.LithoType = EnumValueLithoType.adjective;
                    //UNK migmatitic.VariantOf = "migmatite";
                    migmatitic.Description = "VARIANT. See \"migmatite\".";
                    migmatitic.Version = "1.4.1.0";
                }
                return migmatitic;
            }
        }

        private static QualifierType monzogabbro;
        /// <summary>
        /// Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("monzogabbro")]
        public static QualifierType Monzogabbro
        {
            get 
            {
                if (monzogabbro == null)
                {
                    monzogabbro = new QualifierType("monzogabbro");
                    monzogabbro.LithoType = EnumValueLithoType.both;
                    monzogabbro.IsLithology = true;
                    monzogabbro.Description = "Monzogabbroic rock that contains between 0 an 5 percent quartz and no feldspathoid mineral in the QAPF fraction. Includes rocks defined modally in QAPF field 9. LeMaitre et al. 2002.";
                    monzogabbro.Version = "1.4.1.0";
                }
                return monzogabbro;
            }
        }

        private static QualifierType monzogabbroic;
        /// <summary>
        /// VARIANT. See "monzogabbro".
        /// </summary>
        [EnumValueNameAttribute("monzogabbroic")]
        public static QualifierType Monzogabbroic
        {
            get 
            {
                if (monzogabbroic == null)
                {
                    monzogabbroic = new QualifierType("monzogabbroic");
                    monzogabbroic.LithoType = EnumValueLithoType.adjective;
                    //UNK monzogabbroic.VariantOf = "monzogabbro";
                    monzogabbroic.Description = "VARIANT. See \"monzogabbro\".";
                    monzogabbroic.Version = "1.4.1.0";
                }
                return monzogabbroic;
            }
        }

        private static QualifierType mud;
        /// <summary>
        /// Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein &amp; L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).
        /// </summary>
        [EnumValueNameAttribute("mud")]
        public static QualifierType Mud
        {
            get 
            {
                if (mud == null)
                {
                    mud = new QualifierType("mud");
                    mud.LithoType = EnumValueLithoType.both;
                    mud.IsLithology = true;
                    mud.Description = "Clastic sediment consisting of less than 30 percent gravel-size (2 mm) particles and with a mud-size to sand-size particle ratio greater than 1. More than half of the particles are of epiclastic origin. Definition of mud from SLTTs 2004 muddy sediment; particle sizes defined from Krumbein phi scale (W C Krumbein & L L Sloss, Stratigraphy and Sedimentation, 2nd edition, Freeman, San Francisco, 1963; Krumbein and Pettijohn, 1938, Manual of Sedimentary Petrography: New York, Appleton Century Co., Inc.).";
                    mud.Version = "1.4.1.0";
                }
                return mud;
            }
        }

        private static QualifierType muddy;
        /// <summary>
        /// VARIANT. See "mud".
        /// </summary>
        [EnumValueNameAttribute("muddy")]
        public static QualifierType Muddy
        {
            get 
            {
                if (muddy == null)
                {
                    muddy = new QualifierType("muddy");
                    muddy.LithoType = EnumValueLithoType.adjective;
                    //UNK muddy.VariantOf = "mud";
                    muddy.Description = "VARIANT. See \"mud\".";
                    muddy.Version = "1.4.1.0";
                }
                return muddy;
            }
        }

        private static QualifierType mudstone;
        /// <summary>
        /// Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth &amp; Knox 1999; extrapolated from Folk, 1954, Figure 1a.
        /// </summary>
        [EnumValueNameAttribute("mudstone")]
        public static QualifierType Mudstone
        {
            get 
            {
                if (mudstone == null)
                {
                    mudstone = new QualifierType("mudstone");
                    mudstone.LithoType = EnumValueLithoType.noun;
                    mudstone.IsLithology = true;
                    mudstone.Description = "Clastic sedimentary rock consisting of less than 30 percent gravel-size (2 mm) particles and with a mud to sand ratio greater than 1. The definition includes Claystone, Siltstone and Shale. Pettijohn et al. 1987 referenced in Hallsworth & Knox 1999; extrapolated from Folk, 1954, Figure 1a.";
                    mudstone.Version = "1.4.1.0";
                }
                return mudstone;
            }
        }

        private static QualifierType myloniticRock;
        /// <summary>
        /// Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak &amp; Mitra 1988.
        /// </summary>
        [EnumValueNameAttribute("mylonitic rock")]
        public static QualifierType MyloniticRock
        {
            get 
            {
                if (myloniticRock == null)
                {
                    myloniticRock = new QualifierType("mylonitic rock");
                    myloniticRock.LithoType = EnumValueLithoType.noun;
                    myloniticRock.IsLithology = true;
                    myloniticRock.Description = "Metamorphic rock characterised by a foliation resulting from tectonic grain size reduction, in which more than 10 percent of the rock volume has undergone grain size reduction. Includes protomylonite, mylonite, ultramylonite, and blastomylonite. Marshak & Mitra 1988.";
                    myloniticRock.Version = "1.4.1.0";
                }
                return myloniticRock;
            }
        }

        private static QualifierType noDescription;
        /// <summary>
        /// DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?.
        /// </summary>
        [EnumValueNameAttribute("no description")]
        public static QualifierType NoDescription
        {
            get 
            {
                if (noDescription == null)
                {
                    noDescription = new QualifierType("no description");
                    noDescription.LithoType = EnumValueLithoType.unknown;
                    noDescription.IsLithology = true;
                    noDescription.Description = "DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?.";
                    noDescription.Version = "1.3.1.0";
                    noDescription.Deprecated = "1.4.0.0";
                    noDescription.ReplacedBy = Unknown;
                }
                return noDescription;
            }
        }

        private static QualifierType noSample;
        /// <summary>
        /// A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML.
        /// </summary>
        [EnumValueNameAttribute("no sample")]
        public static QualifierType NoSample
        {
            get 
            {
                if (noSample == null)
                {
                    noSample = new QualifierType("no sample");
                    noSample.LithoType = EnumValueLithoType.noun;
                    noSample.IsLithology = true;
                    noSample.Description = "A sample would be expected, given the drilling situation, but nothing was seen at the shakers, implying either solution in the mud system of a salt, or lack of returns. WITSML.";
                    noSample.Version = "1.4.1.0";
                }
                return noSample;
            }
        }

        private static QualifierType none;
        /// <summary>
        /// DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?.
        /// </summary>
        [EnumValueNameAttribute("none")]
        public static QualifierType None
        {
            get 
            {
                if (none == null)
                {
                    none = new QualifierType("none");
                    none.LithoType = EnumValueLithoType.unknown;
                    none.Description = "DEPRECATED. Where's the validity of creating a null entry for either qualifier or modifer?.";
                    none.Version = "1.3.1.0";
                    none.Deprecated = "1.4.0.0";
                    none.ReplacedBy = Unknown;
                }
                return none;
            }
        }

        private static QualifierType oncolite;
        /// <summary>
        /// Indicates that the associated lithology is largely composed of oncoliths (oncoids).
        /// </summary>
        [EnumValueNameAttribute("oncolite")]
        public static QualifierType Oncolite
        {
            get 
            {
                if (oncolite == null)
                {
                    oncolite = new QualifierType("oncolite");
                    oncolite.LithoType = EnumValueLithoType.noun;
                    oncolite.Description = "Indicates that the associated lithology is largely composed of oncoliths (oncoids).";
                    oncolite.Version = "1.3.1.0";
                }
                return oncolite;
            }
        }

        private static QualifierType oncolith;
        /// <summary>
        /// DEPRECATED. See oncoliths.
        /// </summary>
        [EnumValueNameAttribute("oncolith")]
        public static QualifierType Oncolith
        {
            get 
            {
                if (oncolith == null)
                {
                    oncolith = new QualifierType("oncolith");
                    oncolith.LithoType = EnumValueLithoType.noun;
                    oncolith.Description = "DEPRECATED. See oncoliths.";
                    oncolith.Version = "1.3.1.0";
                    oncolith.Deprecated = "1.4.0.0";
                    oncolith.ReplacedBy = Oncoliths;
                }
                return oncolith;
            }
        }

        private static QualifierType oncolithic;
        /// <summary>
        /// DEPRECATED. See oncoliths.
        /// </summary>
        [EnumValueNameAttribute("oncolithic")]
        public static QualifierType Oncolithic
        {
            get 
            {
                if (oncolithic == null)
                {
                    oncolithic = new QualifierType("oncolithic");
                    oncolithic.LithoType = EnumValueLithoType.adjective;
                    oncolithic.Description = "DEPRECATED. See oncoliths.";
                    oncolithic.Version = "1.3.1.0";
                    oncolithic.Deprecated = "1.4.0.0";
                    oncolithic.ReplacedBy = Oncoliths;
                }
                return oncolithic;
            }
        }

        private static QualifierType oncoliths;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of oncoliths (oncoids), a type of carbonate-coated grain with irregular laminae.
        /// </summary>
        [EnumValueNameAttribute("oncoliths")]
        public static QualifierType Oncoliths
        {
            get 
            {
                if (oncoliths == null)
                {
                    oncoliths = new QualifierType("oncoliths");
                    oncoliths.LithoType = EnumValueLithoType.both;
                    oncoliths.Description = "Indicates that the associated lithology comprises material containing or characteristic of oncoliths (oncoids), a type of carbonate-coated grain with irregular laminae.";
                    oncoliths.Version = "1.4.0.0";
                }
                return oncoliths;
            }
        }

        private static QualifierType oncolitic;
        /// <summary>
        /// VARIANT. See "oncoliths".
        /// </summary>
        [EnumValueNameAttribute("oncolitic")]
        public static QualifierType Oncolitic
        {
            get 
            {
                if (oncolitic == null)
                {
                    oncolitic = new QualifierType("oncolitic");
                    oncolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK oncolitic.VariantOf = "oncoliths";
                    oncolitic.Description = "VARIANT. See \"oncoliths\".";
                    oncolitic.Version = "1.4.0.0";
                }
                return oncolitic;
            }
        }

        private static QualifierType ooidOrOolith;
        /// <summary>
        /// DEPRECATED. See ooids.
        /// </summary>
        [EnumValueNameAttribute("ooid or oolith")]
        public static QualifierType OoidOrOolith
        {
            get 
            {
                if (ooidOrOolith == null)
                {
                    ooidOrOolith = new QualifierType("ooid or oolith");
                    ooidOrOolith.LithoType = EnumValueLithoType.noun;
                    ooidOrOolith.Description = "DEPRECATED. See ooids.";
                    ooidOrOolith.Version = "1.3.1.0";
                    ooidOrOolith.Deprecated = "1.4.0.0";
                    ooidOrOolith.ReplacedBy = Ooids;
                }
                return ooidOrOolith;
            }
        }

        private static QualifierType ooids;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or characteristic of ooids (ooliths), small round grains consisting of calcium carbonate, silica, or dolomite.
        /// </summary>
        [EnumValueNameAttribute("ooids")]
        public static QualifierType Ooids
        {
            get 
            {
                if (ooids == null)
                {
                    ooids = new QualifierType("ooids");
                    ooids.LithoType = EnumValueLithoType.both;
                    ooids.Description = "Indicates that the associated lithology comprises material containing or characteristic of ooids (ooliths), small round grains consisting of calcium carbonate, silica, or dolomite.";
                    ooids.Version = "1.4.0.0";
                }
                return ooids;
            }
        }

        private static QualifierType ooliths;
        /// <summary>
        /// VARIANT. See "ooids".
        /// </summary>
        [EnumValueNameAttribute("ooliths")]
        public static QualifierType Ooliths
        {
            get 
            {
                if (ooliths == null)
                {
                    ooliths = new QualifierType("ooliths");
                    ooliths.LithoType = EnumValueLithoType.noun;
                    //UNK ooliths.VariantOf = "ooids";
                    ooliths.Description = "VARIANT. See \"ooids\".";
                    ooliths.Version = "1.4.0.0";
                }
                return ooliths;
            }
        }

        private static QualifierType oolitic;
        /// <summary>
        /// VARIANT. See "ooids".
        /// </summary>
        [EnumValueNameAttribute("oolitic")]
        public static QualifierType Oolitic
        {
            get 
            {
                if (oolitic == null)
                {
                    oolitic = new QualifierType("oolitic");
                    oolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK oolitic.VariantOf = "ooids";
                    oolitic.Description = "VARIANT. See \"ooids\".";
                    oolitic.Version = "1.4.0.0";
                }
                return oolitic;
            }
        }

        private static QualifierType ooze;
        /// <summary>
        /// Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 &amp; Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("ooze")]
        public static QualifierType Ooze
        {
            get 
            {
                if (ooze == null)
                {
                    ooze = new QualifierType("ooze");
                    ooze.LithoType = EnumValueLithoType.noun;
                    ooze.IsLithology = true;
                    ooze.Description = "Biogenic sediment consisting of less than 1 percent gravel-size (greater than or equal to 2 mm) particles, with a sand to mud ratio less than 1 to 9, and less than 50 percent carbonate minerals. Based on Bates and Jackson 1987 & Hallsworth & Knox 1999.";
                    ooze.Version = "1.4.1.0";
                }
                return ooze;
            }
        }

        private static QualifierType ophiolite;
        /// <summary>
        /// Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust.
        /// </summary>
        [EnumValueNameAttribute("ophiolite")]
        public static QualifierType Ophiolite
        {
            get 
            {
                if (ophiolite == null)
                {
                    ophiolite = new QualifierType("ophiolite");
                    ophiolite.LithoType = EnumValueLithoType.both;
                    ophiolite.IsLithology = true;
                    ophiolite.Description = "Basic and ultra-basic igneous rocks and their metamorposed, often hydrated, derivatives, believed to represent former oceanic crust.";
                    ophiolite.Version = "1.4.1.0";
                }
                return ophiolite;
            }
        }

        private static QualifierType ophiolitic;
        /// <summary>
        /// VARIANT. See "ophiolite".
        /// </summary>
        [EnumValueNameAttribute("ophiolitic")]
        public static QualifierType Ophiolitic
        {
            get 
            {
                if (ophiolitic == null)
                {
                    ophiolitic = new QualifierType("ophiolitic");
                    ophiolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK ophiolitic.VariantOf = "ophiolite";
                    ophiolitic.Description = "VARIANT. See \"ophiolite\".";
                    ophiolitic.Version = "1.4.1.0";
                }
                return ophiolitic;
            }
        }

        private static QualifierType organicBearingMudstone;
        /// <summary>
        /// Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;
        /// </summary>
        [EnumValueNameAttribute("organic bearing mudstone")]
        public static QualifierType OrganicBearingMudstone
        {
            get 
            {
                if (organicBearingMudstone == null)
                {
                    organicBearingMudstone = new QualifierType("organic bearing mudstone");
                    organicBearingMudstone.LithoType = EnumValueLithoType.noun;
                    organicBearingMudstone.IsLithology = true;
                    organicBearingMudstone.Description = "Mudstone that contains a significant amount of organic carbon, typically kerogen. Commonly finely laminated, brown or black in color. Neuendorf et al. 2005;";
                    organicBearingMudstone.Version = "1.4.1.0";
                }
                return organicBearingMudstone;
            }
        }

        private static QualifierType ostracodal;
        /// <summary>
        /// VARIANT. See "ostracods".
        /// </summary>
        [EnumValueNameAttribute("ostracodal")]
        public static QualifierType Ostracodal
        {
            get 
            {
                if (ostracodal == null)
                {
                    ostracodal = new QualifierType("ostracodal");
                    ostracodal.LithoType = EnumValueLithoType.adjective;
                    //UNK ostracodal.VariantOf = "ostracods";
                    ostracodal.Description = "VARIANT. See \"ostracods\".";
                    ostracodal.Version = "1.4.0.0";
                }
                return ostracodal;
            }
        }

        private static QualifierType ostracods;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling ostracod (Cambrian - Recent) fossils.
        /// </summary>
        [EnumValueNameAttribute("ostracods")]
        public static QualifierType Ostracods
        {
            get 
            {
                if (ostracods == null)
                {
                    ostracods = new QualifierType("ostracods");
                    ostracods.LithoType = EnumValueLithoType.both;
                    ostracods.Description = "Indicates that the associated lithology comprises material containing or resembling ostracod (Cambrian - Recent) fossils.";
                    ostracods.Version = "1.3.1.0";
                }
                return ostracods;
            }
        }

        private static QualifierType peat;
        /// <summary>
        /// Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth &amp; Knox 1999.
        /// </summary>
        [EnumValueNameAttribute("peat")]
        public static QualifierType Peat
        {
            get 
            {
                if (peat == null)
                {
                    peat = new QualifierType("peat");
                    peat.LithoType = EnumValueLithoType.both;
                    peat.IsLithology = true;
                    peat.Description = "Unconsolidated organic-rich sediment composed of at least 50 percent semi-carbonised plant remains; individual remains commonly seen with unaided eye; yellowish brown to brownish black; generally fibrous texture; can be plastic or friable. In its natural state it can be readily cut and has a very high moisture content, generally greater than 90 percent. Liptinite to Inertinite ratio is less than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Hallsworth & Knox 1999.";
                    peat.Version = "1.4.1.0";
                }
                return peat;
            }
        }

        private static QualifierType peaty;
        /// <summary>
        /// VARIANT. See "peat".
        /// </summary>
        [EnumValueNameAttribute("peaty")]
        public static QualifierType Peaty
        {
            get 
            {
                if (peaty == null)
                {
                    peaty = new QualifierType("peaty");
                    peaty.LithoType = EnumValueLithoType.adjective;
                    //UNK peaty.VariantOf = "peat";
                    peaty.Description = "VARIANT. See \"peat\".";
                    peaty.Version = "1.4.1.0";
                }
                return peaty;
            }
        }

        private static QualifierType pebble;
        /// <summary>
        /// Indicates that the associated lithology contains rounded rock fragments in the size range of 2mm - 64mm.
        /// </summary>
        [EnumValueNameAttribute("pebble")]
        public static QualifierType Pebble
        {
            get 
            {
                if (pebble == null)
                {
                    pebble = new QualifierType("pebble");
                    pebble.LithoType = EnumValueLithoType.both;
                    pebble.Description = "Indicates that the associated lithology contains rounded rock fragments in the size range of 2mm - 64mm.";
                    pebble.Version = "1.4.0.0";
                }
                return pebble;
            }
        }

        private static QualifierType pebbly;
        /// <summary>
        /// VARIANT. See "pebble".
        /// </summary>
        [EnumValueNameAttribute("pebbly")]
        public static QualifierType Pebbly
        {
            get 
            {
                if (pebbly == null)
                {
                    pebbly = new QualifierType("pebbly");
                    pebbly.LithoType = EnumValueLithoType.adjective;
                    //UNK pebbly.VariantOf = "pebble";
                    pebbly.Description = "VARIANT. See \"pebble\".";
                    pebbly.Version = "1.3.1.0";
                }
                return pebbly;
            }
        }

        private static QualifierType pegmatite;
        /// <summary>
        /// Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("pegmatite")]
        public static QualifierType Pegmatite
        {
            get 
            {
                if (pegmatite == null)
                {
                    pegmatite = new QualifierType("pegmatite");
                    pegmatite.LithoType = EnumValueLithoType.both;
                    pegmatite.IsLithology = true;
                    pegmatite.Description = "Exceptionally coarse grained crystalline rock with interlocking crystals; most grains are 1 centimeter or more diameter; composition is generally that of granite, but the term may refer to the coarse grained facies of any type of igneous rock; usually found as irregular dikes, lenses, or veins associated with plutons or batholiths. Neuendorf et al 2005.";
                    pegmatite.Version = "1.4.1.0";
                }
                return pegmatite;
            }
        }

        private static QualifierType pegmatitic;
        /// <summary>
        /// VARIANT. See "pegmatite".
        /// </summary>
        [EnumValueNameAttribute("pegmatitic")]
        public static QualifierType Pegmatitic
        {
            get 
            {
                if (pegmatitic == null)
                {
                    pegmatitic = new QualifierType("pegmatitic");
                    pegmatitic.LithoType = EnumValueLithoType.adjective;
                    //UNK pegmatitic.VariantOf = "pegmatite";
                    pegmatitic.Description = "VARIANT. See \"pegmatite\".";
                    pegmatitic.Version = "1.4.1.0";
                }
                return pegmatitic;
            }
        }

        private static QualifierType pellet;
        /// <summary>
        /// DEPRECATED. See pellets.
        /// </summary>
        [EnumValueNameAttribute("pellet")]
        public static QualifierType Pellet
        {
            get 
            {
                if (pellet == null)
                {
                    pellet = new QualifierType("pellet");
                    pellet.LithoType = EnumValueLithoType.noun;
                    pellet.Description = "DEPRECATED. See pellets.";
                    pellet.Version = "1.3.1.0";
                    pellet.Deprecated = "1.4.0.0";
                    pellet.ReplacedBy = Pellets;
                }
                return pellet;
            }
        }

        private static QualifierType pelletal;
        /// <summary>
        /// VARIANT. See "pellets".
        /// </summary>
        [EnumValueNameAttribute("pelletal")]
        public static QualifierType Pelletal
        {
            get 
            {
                if (pelletal == null)
                {
                    pelletal = new QualifierType("pelletal");
                    pelletal.LithoType = EnumValueLithoType.adjective;
                    //UNK pelletal.VariantOf = "pellets";
                    pelletal.Description = "VARIANT. See \"pellets\".";
                    pelletal.Version = "1.3.1.0";
                }
                return pelletal;
            }
        }

        private static QualifierType pellets;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of small ovoid or spherical particles of microcrystalline calcite, in the size range 0.03mm - 0.15mm.
        /// </summary>
        [EnumValueNameAttribute("pellets")]
        public static QualifierType Pellets
        {
            get 
            {
                if (pellets == null)
                {
                    pellets = new QualifierType("pellets");
                    pellets.LithoType = EnumValueLithoType.both;
                    pellets.Description = "Indicates that the associated lithology contains or is characteristic of small ovoid or spherical particles of microcrystalline calcite, in the size range 0.03mm - 0.15mm.";
                    pellets.Version = "1.4.0.0";
                }
                return pellets;
            }
        }

        private static QualifierType peloid;
        /// <summary>
        /// DEPRECATED. See peloids.
        /// </summary>
        [EnumValueNameAttribute("peloid")]
        public static QualifierType Peloid
        {
            get 
            {
                if (peloid == null)
                {
                    peloid = new QualifierType("peloid");
                    peloid.LithoType = EnumValueLithoType.noun;
                    peloid.Description = "DEPRECATED. See peloids.";
                    peloid.Version = "1.3.1.0";
                    peloid.Deprecated = "1.4.0.0";
                    peloid.ReplacedBy = Peloids;
                }
                return peloid;
            }
        }

        private static QualifierType peloidal;
        /// <summary>
        /// VARIANT. See "peloids".
        /// </summary>
        [EnumValueNameAttribute("peloidal")]
        public static QualifierType Peloidal
        {
            get 
            {
                if (peloidal == null)
                {
                    peloidal = new QualifierType("peloidal");
                    peloidal.LithoType = EnumValueLithoType.adjective;
                    //UNK peloidal.VariantOf = "peloids";
                    peloidal.Description = "VARIANT. See \"peloids\".";
                    peloidal.Version = "1.3.1.0";
                }
                return peloidal;
            }
        }

        private static QualifierType peloids;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of sand-size grains of carbonate mud.
        /// </summary>
        [EnumValueNameAttribute("peloids")]
        public static QualifierType Peloids
        {
            get 
            {
                if (peloids == null)
                {
                    peloids = new QualifierType("peloids");
                    peloids.LithoType = EnumValueLithoType.both;
                    peloids.Description = "Indicates that the associated lithology contains or is characteristic of sand-size grains of carbonate mud.";
                    peloids.Version = "1.4.0.0";
                }
                return peloids;
            }
        }

        private static QualifierType peridotite;
        /// <summary>
        /// Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("peridotite")]
        public static QualifierType Peridotite
        {
            get 
            {
                if (peridotite == null)
                {
                    peridotite = new QualifierType("peridotite");
                    peridotite.LithoType = EnumValueLithoType.both;
                    peridotite.IsLithology = true;
                    peridotite.Description = "Ultramafic rock consisting of more than 40 percent (by volume) olivine with pyroxene and/or amphibole and little or no feldspar. Commonly altered to serpentinite. Includes rocks defined modally in the ultramafic rock classification as dunite, harzburgite, lherzolite, wehrlite, olivinite, pyroxene peridotite, pyroxene hornblende peridotite or hornblende peridotite. LeMaitre et al. 2002.";
                    peridotite.Version = "1.4.1.0";
                }
                return peridotite;
            }
        }

        private static QualifierType peridotitic;
        /// <summary>
        /// VARIANT. See "peridotite".
        /// </summary>
        [EnumValueNameAttribute("peridotitic")]
        public static QualifierType Peridotitic
        {
            get 
            {
                if (peridotitic == null)
                {
                    peridotitic = new QualifierType("peridotitic");
                    peridotitic.LithoType = EnumValueLithoType.adjective;
                    //UNK peridotitic.VariantOf = "peridotite";
                    peridotitic.Description = "VARIANT. See \"peridotite\".";
                    peridotitic.Version = "1.4.1.0";
                }
                return peridotitic;
            }
        }

        private static QualifierType phaneriticIgneousRock;
        /// <summary>
        /// Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005.
        /// </summary>
        [EnumValueNameAttribute("phaneritic igneous rock")]
        public static QualifierType PhaneriticIgneousRock
        {
            get 
            {
                if (phaneriticIgneousRock == null)
                {
                    phaneriticIgneousRock = new QualifierType("phaneritic igneous rock");
                    phaneriticIgneousRock.LithoType = EnumValueLithoType.noun;
                    phaneriticIgneousRock.IsLithology = true;
                    phaneriticIgneousRock.Description = "Igneous rock in which the framework of the rock consists of individual crystals that can be discerned with the unaided eye. Bounding grain size is on the order of 32 to 100 microns. Igneous rocks with 'exotic' composition are excluded from this concept. Neuendorf et al 2005.";
                    phaneriticIgneousRock.Version = "1.4.1.0";
                }
                return phaneriticIgneousRock;
            }
        }

        private static QualifierType phonolite;
        /// <summary>
        /// Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolite")]
        public static QualifierType Phonolite
        {
            get 
            {
                if (phonolite == null)
                {
                    phonolite = new QualifierType("phonolite");
                    phonolite.LithoType = EnumValueLithoType.both;
                    phonolite.IsLithology = true;
                    phonolite.Description = "Phonolitoid in which the plagioclase to total feldspar ratio is less than 0.1. Rock consists of alkali feldspar, feldspathoid minerals, and mafic minerals. LeMaitre et al. 2002.";
                    phonolite.Version = "1.4.1.0";
                }
                return phonolite;
            }
        }

        private static QualifierType phonolitic;
        /// <summary>
        /// VARIANT. See "phonolite".
        /// </summary>
        [EnumValueNameAttribute("phonolitic")]
        public static QualifierType Phonolitic
        {
            get 
            {
                if (phonolitic == null)
                {
                    phonolitic = new QualifierType("phonolitic");
                    phonolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK phonolitic.VariantOf = "phonolite";
                    phonolitic.Description = "VARIANT. See \"phonolite\".";
                    phonolitic.Version = "1.4.1.0";
                }
                return phonolitic;
            }
        }

        private static QualifierType phonolitoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("phonolitoid")]
        public static QualifierType Phonolitoid
        {
            get 
            {
                if (phonolitoid == null)
                {
                    phonolitoid = new QualifierType("phonolitoid");
                    phonolitoid.LithoType = EnumValueLithoType.noun;
                    phonolitoid.IsLithology = true;
                    phonolitoid.Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.5. Includes rocks defined modally in QAPF fields 11 and 12, and TAS field Ph. LeMaitre et al. 2002.";
                    phonolitoid.Version = "1.4.1.0";
                }
                return phonolitoid;
            }
        }

        private static QualifierType phosphate;
        /// <summary>
        /// Indicates that the associated lithology contains phosphates.
        /// </summary>
        [EnumValueNameAttribute("phosphate")]
        public static QualifierType Phosphate
        {
            get 
            {
                if (phosphate == null)
                {
                    phosphate = new QualifierType("phosphate");
                    phosphate.LithoType = EnumValueLithoType.both;
                    phosphate.IsLithology = true;
                    phosphate.Description = "Indicates that the associated lithology contains phosphates.";
                    phosphate.Version = "1.3.1.0";
                }
                return phosphate;
            }
        }

        private static QualifierType phosphateRock;
        /// <summary>
        /// Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource.
        /// </summary>
        [EnumValueNameAttribute("phosphate rock")]
        public static QualifierType PhosphateRock
        {
            get 
            {
                if (phosphateRock == null)
                {
                    phosphateRock = new QualifierType("phosphate rock");
                    phosphateRock.LithoType = EnumValueLithoType.noun;
                    phosphateRock.IsLithology = true;
                    phosphateRock.Description = "Any rock containing phosphate minerals such as apatite of sufficient purity and abundance to be an economic resource.";
                    phosphateRock.Version = "1.4.1.0";
                }
                return phosphateRock;
            }
        }

        private static QualifierType phosphatic;
        /// <summary>
        /// VARIANT. See "phosphate".
        /// </summary>
        [EnumValueNameAttribute("phosphatic")]
        public static QualifierType Phosphatic
        {
            get 
            {
                if (phosphatic == null)
                {
                    phosphatic = new QualifierType("phosphatic");
                    phosphatic.LithoType = EnumValueLithoType.adjective;
                    //UNK phosphatic.VariantOf = "phosphate";
                    phosphatic.Description = "VARIANT. See \"phosphate\".";
                    phosphatic.Version = "1.4.0.0";
                }
                return phosphatic;
            }
        }

        private static QualifierType phyllite;
        /// <summary>
        /// Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007.
        /// </summary>
        [EnumValueNameAttribute("phyllite")]
        public static QualifierType Phyllite
        {
            get 
            {
                if (phyllite == null)
                {
                    phyllite = new QualifierType("phyllite");
                    phyllite.LithoType = EnumValueLithoType.both;
                    phyllite.IsLithology = true;
                    phyllite.Description = "Rock with a well developed, continuous schistosity, an average grain size between 0.1 and 0.5 millimeters, and a silvery sheen on cleavage surfaces. Individual phyllosilicate grains are barely visible with the unaided eye. IUGS SCMR 2007.";
                    phyllite.Version = "1.4.1.0";
                }
                return phyllite;
            }
        }

        private static QualifierType phyllitic;
        /// <summary>
        /// VARIANT. See "phyllite".
        /// </summary>
        [EnumValueNameAttribute("phyllitic")]
        public static QualifierType Phyllitic
        {
            get 
            {
                if (phyllitic == null)
                {
                    phyllitic = new QualifierType("phyllitic");
                    phyllitic.LithoType = EnumValueLithoType.adjective;
                    //UNK phyllitic.VariantOf = "phyllite";
                    phyllitic.Description = "VARIANT. See \"phyllite\".";
                    phyllitic.Version = "1.4.1.0";
                }
                return phyllitic;
            }
        }

        private static QualifierType pisolite;
        /// <summary>
        /// Indicates that the associated lithology is composed largely of pisoliths (pisoids).
        /// </summary>
        [EnumValueNameAttribute("pisolite")]
        public static QualifierType Pisolite
        {
            get 
            {
                if (pisolite == null)
                {
                    pisolite = new QualifierType("pisolite");
                    pisolite.LithoType = EnumValueLithoType.both;
                    pisolite.Description = "Indicates that the associated lithology is composed largely of pisoliths (pisoids).";
                    pisolite.Version = "1.3.1.0";
                }
                return pisolite;
            }
        }

        private static QualifierType pisolith;
        /// <summary>
        /// DEPRECATED. See pisoliths.
        /// </summary>
        [EnumValueNameAttribute("pisolith")]
        public static QualifierType Pisolith
        {
            get 
            {
                if (pisolith == null)
                {
                    pisolith = new QualifierType("pisolith");
                    pisolith.LithoType = EnumValueLithoType.noun;
                    pisolith.Description = "DEPRECATED. See pisoliths.";
                    pisolith.Version = "1.3.1.0";
                    pisolith.Deprecated = "1.4.0.0";
                    pisolith.ReplacedBy = Pisoliths;
                }
                return pisolith;
            }
        }

        private static QualifierType pisoliths;
        /// <summary>
        /// Indicates that the associated lithology contains or is characteristic of sub-spherical usually carbonate coated grains, of diameter greater than 2mm.
        /// </summary>
        [EnumValueNameAttribute("pisoliths")]
        public static QualifierType Pisoliths
        {
            get 
            {
                if (pisoliths == null)
                {
                    pisoliths = new QualifierType("pisoliths");
                    pisoliths.LithoType = EnumValueLithoType.noun;
                    pisoliths.Description = "Indicates that the associated lithology contains or is characteristic of sub-spherical usually carbonate coated grains, of diameter greater than 2mm.";
                    pisoliths.Version = "1.4.0.0";
                }
                return pisoliths;
            }
        }

        private static QualifierType pisolitic;
        /// <summary>
        /// VARIANT. See "pisolite".
        /// </summary>
        [EnumValueNameAttribute("pisolitic")]
        public static QualifierType Pisolitic
        {
            get 
            {
                if (pisolitic == null)
                {
                    pisolitic = new QualifierType("pisolitic");
                    pisolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK pisolitic.VariantOf = "pisolite";
                    pisolitic.Description = "VARIANT. See \"pisolite\".";
                    pisolitic.Version = "1.4.0.0";
                }
                return pisolitic;
            }
        }

        private static QualifierType plantRemains;
        /// <summary>
        /// Indicates that the associated lithology contains remains of a probable botanical origin.
        /// </summary>
        [EnumValueNameAttribute("plant remains")]
        public static QualifierType PlantRemains
        {
            get 
            {
                if (plantRemains == null)
                {
                    plantRemains = new QualifierType("plant remains");
                    plantRemains.LithoType = EnumValueLithoType.noun;
                    plantRemains.Description = "Indicates that the associated lithology contains remains of a probable botanical origin.";
                    plantRemains.Version = "1.3.1.0";
                }
                return plantRemains;
            }
        }

        private static QualifierType porphyritic;
        /// <summary>
        /// VARIANT. See "porphyry".
        /// </summary>
        [EnumValueNameAttribute("porphyritic")]
        public static QualifierType Porphyritic
        {
            get 
            {
                if (porphyritic == null)
                {
                    porphyritic = new QualifierType("porphyritic");
                    porphyritic.LithoType = EnumValueLithoType.adjective;
                    //UNK porphyritic.VariantOf = "porphyry";
                    porphyritic.Description = "VARIANT. See \"porphyry\".";
                    porphyritic.Version = "1.4.1.0";
                }
                return porphyritic;
            }
        }

        private static QualifierType porphyry;
        /// <summary>
        /// Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("porphyry")]
        public static QualifierType Porphyry
        {
            get 
            {
                if (porphyry == null)
                {
                    porphyry = new QualifierType("porphyry");
                    porphyry.LithoType = EnumValueLithoType.both;
                    porphyry.IsLithology = true;
                    porphyry.Description = "Igneous rock that contains conspicuous phenocrysts in a finer grained groundmass; groundmass itself may be phaneritic or fine-grained. LeMaitre et al. 2002.";
                    porphyry.Version = "1.4.1.0";
                }
                return porphyry;
            }
        }

        private static QualifierType potassiumAndMagnesiumSalts;
        /// <summary>
        /// Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML.
        /// </summary>
        [EnumValueNameAttribute("potassium and magnesium salts")]
        public static QualifierType PotassiumAndMagnesiumSalts
        {
            get 
            {
                if (potassiumAndMagnesiumSalts == null)
                {
                    potassiumAndMagnesiumSalts = new QualifierType("potassium and magnesium salts");
                    potassiumAndMagnesiumSalts.LithoType = EnumValueLithoType.noun;
                    potassiumAndMagnesiumSalts.IsLithology = true;
                    potassiumAndMagnesiumSalts.Description = "Evaporite composed with significant (greater than 50 percent) magnesium salts, such as Carnallite /Kainite/Polyhalite/Kieserite/Bischofite/Tachydrite. WITSML.";
                    potassiumAndMagnesiumSalts.Version = "1.4.1.0";
                }
                return potassiumAndMagnesiumSalts;
            }
        }

        private static QualifierType pyrite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling the sulphide mineral of iron (FeS2).
        /// </summary>
        [EnumValueNameAttribute("pyrite")]
        public static QualifierType Pyrite
        {
            get 
            {
                if (pyrite == null)
                {
                    pyrite = new QualifierType("pyrite");
                    pyrite.LithoType = EnumValueLithoType.both;
                    pyrite.Description = "Indicates that the associated lithology comprises material containing or resembling the sulphide mineral of iron (FeS2).";
                    pyrite.Version = "1.3.1.0";
                }
                return pyrite;
            }
        }

        private static QualifierType pyritic;
        /// <summary>
        /// VARIANT. See "pyrite".
        /// </summary>
        [EnumValueNameAttribute("pyritic")]
        public static QualifierType Pyritic
        {
            get 
            {
                if (pyritic == null)
                {
                    pyritic = new QualifierType("pyritic");
                    pyritic.LithoType = EnumValueLithoType.adjective;
                    //UNK pyritic.VariantOf = "pyrite";
                    pyritic.Description = "VARIANT. See \"pyrite\".";
                    pyritic.Version = "1.4.0.0";
                }
                return pyritic;
            }
        }

        private static QualifierType pyroclasticBreccia;
        /// <summary>
        /// Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic breccia")]
        public static QualifierType PyroclasticBreccia
        {
            get 
            {
                if (pyroclasticBreccia == null)
                {
                    pyroclasticBreccia = new QualifierType("pyroclastic breccia");
                    pyroclasticBreccia.LithoType = EnumValueLithoType.noun;
                    pyroclasticBreccia.IsLithology = true;
                    pyroclasticBreccia.Description = "Pyroclastic rock in which greater than 25 percent of particles are greater than 64 millimeter in largest dimension. Includes agglomerate, pyroclastic breccia of Gillespie and Styles (1999). Schmid 1981; LeMaitre et al. 2002.";
                    pyroclasticBreccia.Version = "1.4.1.0";
                }
                return pyroclasticBreccia;
            }
        }

        private static QualifierType pyroclasticRock;
        /// <summary>
        /// Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroclastic rock")]
        public static QualifierType PyroclasticRock
        {
            get 
            {
                if (pyroclasticRock == null)
                {
                    pyroclasticRock = new QualifierType("pyroclastic rock");
                    pyroclasticRock.LithoType = EnumValueLithoType.noun;
                    pyroclasticRock.IsLithology = true;
                    pyroclasticRock.Description = "Fragmental igneous rock that consists of greater than 75 percent fragments produced as a direct result of eruption or extrusion of magma from within the earth onto its surface. Includes autobreccia associated with lava flows and excludes deposits reworked by epiclastic processes. Based on LeMaitre et al. 2002.";
                    pyroclasticRock.Version = "1.4.1.0";
                }
                return pyroclasticRock;
            }
        }

        private static QualifierType pyroxenite;
        /// <summary>
        /// Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("pyroxenite")]
        public static QualifierType Pyroxenite
        {
            get 
            {
                if (pyroxenite == null)
                {
                    pyroxenite = new QualifierType("pyroxenite");
                    pyroxenite.LithoType = EnumValueLithoType.both;
                    pyroxenite.IsLithology = true;
                    pyroxenite.Description = "Ultramafic phaneritic igneous rock composed almost entirely of one or more pyroxenes and occasionally biotite, hornblende and olivine. Includes rocks defined modally in the ultramafic rock classification as olivine pyroxenite, olivine-hornblende pyroxenite, pyroxenite, orthopyroxenite, clinopyroxenite and websterite. LeMaitre et al. 2002.";
                    pyroxenite.Version = "1.4.1.0";
                }
                return pyroxenite;
            }
        }

        private static QualifierType pyroxenitic;
        /// <summary>
        /// VARIANT. See "pyroxenite".
        /// </summary>
        [EnumValueNameAttribute("pyroxenitic")]
        public static QualifierType Pyroxenitic
        {
            get 
            {
                if (pyroxenitic == null)
                {
                    pyroxenitic = new QualifierType("pyroxenitic");
                    pyroxenitic.LithoType = EnumValueLithoType.adjective;
                    //UNK pyroxenitic.VariantOf = "pyroxenite";
                    pyroxenitic.Description = "VARIANT. See \"pyroxenite\".";
                    pyroxenitic.Version = "1.4.1.0";
                }
                return pyroxenitic;
            }
        }

        private static QualifierType quartiferous;
        /// <summary>
        /// VARIANT. See "quartz".
        /// </summary>
        [EnumValueNameAttribute("quartiferous")]
        public static QualifierType Quartiferous
        {
            get 
            {
                if (quartiferous == null)
                {
                    quartiferous = new QualifierType("quartiferous");
                    quartiferous.LithoType = EnumValueLithoType.adjective;
                    //UNK quartiferous.VariantOf = "quartz";
                    quartiferous.Description = "VARIANT. See \"quartz\".";
                    quartiferous.Version = "1.4.0.0";
                }
                return quartiferous;
            }
        }

        private static QualifierType quartz;
        /// <summary>
        /// Indicates that the associated lithology comprises (crystalline) material containing or resembling the common silica mineral quartz (SiO2).
        /// </summary>
        [EnumValueNameAttribute("quartz")]
        public static QualifierType Quartz
        {
            get 
            {
                if (quartz == null)
                {
                    quartz = new QualifierType("quartz");
                    quartz.LithoType = EnumValueLithoType.both;
                    quartz.IsMatrixCement = true;
                    quartz.Description = "Indicates that the associated lithology comprises (crystalline) material containing or resembling the common silica mineral quartz (SiO2).";
                    quartz.Version = "1.3.1.0";
                }
                return quartz;
            }
        }

        private static QualifierType quartzArenite;
        /// <summary>
        /// Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.
        /// </summary>
        [EnumValueNameAttribute("quartz arenite")]
        public static QualifierType QuartzArenite
        {
            get 
            {
                if (quartzArenite == null)
                {
                    quartzArenite = new QualifierType("quartz arenite");
                    quartzArenite.LithoType = EnumValueLithoType.both;
                    quartzArenite.IsLithology = true;
                    quartzArenite.Description = "Clastic sandstone that contains less than 10 percent matrix. Matrix is mud-size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products) of detrital or diagenetic nature. Sandstones that contain more than 90 percent of siliceous grains. Grains can include quartz or chert rock fragments. Dott, R. H, (1964). Wacke, Graywacke and matrix-what approach to immature sandstone classification: Journal of Sedimentary Petrology, v-34, p. 625-632.";
                    quartzArenite.Version = "1.4.1.0";
                }
                return quartzArenite;
            }
        }

        private static QualifierType quartzite;
        /// <summary>
        /// Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("quartzite")]
        public static QualifierType Quartzite
        {
            get 
            {
                if (quartzite == null)
                {
                    quartzite = new QualifierType("quartzite");
                    quartzite.LithoType = EnumValueLithoType.both;
                    quartzite.IsLithology = true;
                    quartzite.Description = "Metamorphic rock consisting of greater than or equal to 75 percent quartz; typically granoblastic texture. Neuendorf et al. 2005.";
                    quartzite.Version = "1.4.1.0";
                }
                return quartzite;
            }
        }

        private static QualifierType quartzitic;
        /// <summary>
        /// VARIANT. See "quartzite".
        /// </summary>
        [EnumValueNameAttribute("quartzitic")]
        public static QualifierType Quartzitic
        {
            get 
            {
                if (quartzitic == null)
                {
                    quartzitic = new QualifierType("quartzitic");
                    quartzitic.LithoType = EnumValueLithoType.adjective;
                    //UNK quartzitic.VariantOf = "quartzite";
                    quartzitic.Description = "VARIANT. See \"quartzite\".";
                    quartzitic.Version = "1.4.1.0";
                }
                return quartzitic;
            }
        }

        private static QualifierType radiolaria;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling fossils of the marine protozoan order of Radiolaria (Cambrian - Recent), generally with endoskeletons of opaline silica.
        /// </summary>
        [EnumValueNameAttribute("radiolaria")]
        public static QualifierType Radiolaria
        {
            get 
            {
                if (radiolaria == null)
                {
                    radiolaria = new QualifierType("radiolaria");
                    radiolaria.LithoType = EnumValueLithoType.both;
                    radiolaria.Description = "Indicates that the associated lithology comprises material containing or resembling fossils of the marine protozoan order of Radiolaria (Cambrian - Recent), generally with endoskeletons of opaline silica.";
                    radiolaria.Version = "1.3.1.0";
                }
                return radiolaria;
            }
        }

        private static QualifierType radiolarian;
        /// <summary>
        /// VARIANT. See "radiolaria".
        /// </summary>
        [EnumValueNameAttribute("radiolarian")]
        public static QualifierType Radiolarian
        {
            get 
            {
                if (radiolarian == null)
                {
                    radiolarian = new QualifierType("radiolarian");
                    radiolarian.LithoType = EnumValueLithoType.adjective;
                    //UNK radiolarian.VariantOf = "radiolaria";
                    radiolarian.Description = "VARIANT. See \"radiolaria\".";
                    radiolarian.Version = "1.4.0.0";
                }
                return radiolarian;
            }
        }

        private static QualifierType rhyolite;
        /// <summary>
        /// rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("rhyolite")]
        public static QualifierType Rhyolite
        {
            get 
            {
                if (rhyolite == null)
                {
                    rhyolite = new QualifierType("rhyolite");
                    rhyolite.LithoType = EnumValueLithoType.both;
                    rhyolite.IsLithology = true;
                    rhyolite.Description = "rhyolitoid in which the ratio of plagioclase to total feldspar is between 0.1 and 0.65. LeMaitre et al. 2002.";
                    rhyolite.Version = "1.4.1.0";
                }
                return rhyolite;
            }
        }

        private static QualifierType rhyolitic;
        /// <summary>
        /// VARIANT. See "rhyolite".
        /// </summary>
        [EnumValueNameAttribute("rhyolitic")]
        public static QualifierType Rhyolitic
        {
            get 
            {
                if (rhyolitic == null)
                {
                    rhyolitic = new QualifierType("rhyolitic");
                    rhyolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK rhyolitic.VariantOf = "rhyolite";
                    rhyolitic.Description = "VARIANT. See \"rhyolite\".";
                    rhyolitic.Version = "1.4.1.0";
                }
                return rhyolitic;
            }
        }

        private static QualifierType rockSalt;
        /// <summary>
        /// Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("rock salt")]
        public static QualifierType RockSalt
        {
            get 
            {
                if (rockSalt == null)
                {
                    rockSalt = new QualifierType("rock salt");
                    rockSalt.LithoType = EnumValueLithoType.both;
                    rockSalt.IsLithology = true;
                    rockSalt.Description = "Evaporite composed of at least 50 percent halite. Superset of Halite, Silvite and Potassium and magnesium salts. OneGeology.";
                    rockSalt.Version = "1.4.1.0";
                }
                return rockSalt;
            }
        }

        private static QualifierType rootlets;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling plant roots, or structures (rhizoliths) resulting from the mineralization of plant roots by accumulation/cementation or replacement.
        /// </summary>
        [EnumValueNameAttribute("rootlets")]
        public static QualifierType Rootlets
        {
            get 
            {
                if (rootlets == null)
                {
                    rootlets = new QualifierType("rootlets");
                    rootlets.LithoType = EnumValueLithoType.noun;
                    rootlets.Description = "Indicates that the associated lithology comprises material containing or resembling plant roots, or structures (rhizoliths) resulting from the mineralization of plant roots by accumulation/cementation or replacement.";
                    rootlets.Version = "1.4.0.0";
                }
                return rootlets;
            }
        }

        private static QualifierType salty;
        /// <summary>
        /// VARIANT. See "rock salt".
        /// </summary>
        [EnumValueNameAttribute("salty")]
        public static QualifierType Salty
        {
            get 
            {
                if (salty == null)
                {
                    salty = new QualifierType("salty");
                    salty.LithoType = EnumValueLithoType.adjective;
                    //UNK salty.VariantOf = "rock salt";
                    salty.Description = "VARIANT. See \"rock salt\".";
                    salty.Version = "1.3.1.0";
                }
                return salty;
            }
        }

        private static QualifierType sand;
        /// <summary>
        /// Indicates that the associated lithology comprises (crystalline) material containing or resembling mineral or rock grains of diameter in the range of 0.625mm - 2mm.
        /// </summary>
        [EnumValueNameAttribute("sand")]
        public static QualifierType Sand
        {
            get 
            {
                if (sand == null)
                {
                    sand = new QualifierType("sand");
                    sand.LithoType = EnumValueLithoType.both;
                    sand.IsLithology = true;
                    sand.Description = "Indicates that the associated lithology comprises (crystalline) material containing or resembling mineral or rock grains of diameter in the range of 0.625mm - 2mm.";
                    sand.Version = "1.4.0.0";
                }
                return sand;
            }
        }

        private static QualifierType sandstone;
        /// <summary>
        /// Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.
        /// </summary>
        [EnumValueNameAttribute("sandstone")]
        public static QualifierType Sandstone
        {
            get 
            {
                if (sandstone == null)
                {
                    sandstone = new QualifierType("sandstone");
                    sandstone.LithoType = EnumValueLithoType.noun;
                    sandstone.IsLithology = true;
                    sandstone.Description = "Clastic sedimentary rock in which less than 30 percent of particles are greater than 2 millimeter in diameter (gravel) and the sand to mud ratio is at least 1. SLTTs 2004; Neuendorf et al. 2005; particle size from Wentworth grade scale.";
                    sandstone.Version = "1.4.1.0";
                }
                return sandstone;
            }
        }

        private static QualifierType sandy;
        /// <summary>
        /// VARIANT. See "sand".
        /// </summary>
        [EnumValueNameAttribute("sandy")]
        public static QualifierType Sandy
        {
            get 
            {
                if (sandy == null)
                {
                    sandy = new QualifierType("sandy");
                    sandy.LithoType = EnumValueLithoType.adjective;
                    //UNK sandy.VariantOf = "sand";
                    sandy.Description = "VARIANT. See \"sand\".";
                    sandy.Version = "1.3.1.0";
                }
                return sandy;
            }
        }

        private static QualifierType sapropel;
        /// <summary>
        /// Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("sapropel")]
        public static QualifierType Sapropel
        {
            get 
            {
                if (sapropel == null)
                {
                    sapropel = new QualifierType("sapropel");
                    sapropel.LithoType = EnumValueLithoType.both;
                    sapropel.IsLithology = true;
                    sapropel.Description = "Jelly like organic rich sediment composed of plant remains, usually algal. Liptinite to Inertinite ratio is greater than one (Economic Commission for Europe, Committee on Sustainable Energy- United Nations (ECE-UN), 1998, International Classification of in-Seam Coals: Energy 19, 41 pp.). Neuendorf et al. 2005.";
                    sapropel.Version = "1.4.1.0";
                }
                return sapropel;
            }
        }

        private static QualifierType sapropelic;
        /// <summary>
        /// VARIANT. See "sapropel".
        /// </summary>
        [EnumValueNameAttribute("sapropelic")]
        public static QualifierType Sapropelic
        {
            get 
            {
                if (sapropelic == null)
                {
                    sapropelic = new QualifierType("sapropelic");
                    sapropelic.LithoType = EnumValueLithoType.adjective;
                    //UNK sapropelic.VariantOf = "sapropel";
                    sapropelic.Description = "VARIANT. See \"sapropel\".";
                    sapropelic.Version = "1.4.1.0";
                }
                return sapropelic;
            }
        }

        private static QualifierType schist;
        /// <summary>
        /// Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("schist")]
        public static QualifierType Schist
        {
            get 
            {
                if (schist == null)
                {
                    schist = new QualifierType("schist");
                    schist.LithoType = EnumValueLithoType.both;
                    schist.IsLithology = true;
                    schist.Description = "Foliated phaneritic metamorphic rock with well developed, continuous schistosity, meaning that greater than 50 percent of the rock by volume is mineral grains with a thin tabular, lamellar, or acicular prismatic crystallographic habit that are oriented in a continuous planar or linear fabric. SLTTm 2004; Neuendorf et al. 2005.";
                    schist.Version = "1.4.1.0";
                }
                return schist;
            }
        }

        private static QualifierType schisty;
        /// <summary>
        /// VARIANT. See "schist".
        /// </summary>
        [EnumValueNameAttribute("schisty")]
        public static QualifierType Schisty
        {
            get 
            {
                if (schisty == null)
                {
                    schisty = new QualifierType("schisty");
                    schisty.LithoType = EnumValueLithoType.adjective;
                    //UNK schisty.VariantOf = "schist";
                    schisty.Description = "VARIANT. See \"schist\".";
                    schisty.Version = "1.4.1.0";
                }
                return schisty;
            }
        }

        private static QualifierType sepentinitic;
        /// <summary>
        /// VARIANT. See "serpentinite".
        /// </summary>
        [EnumValueNameAttribute("sepentinitic")]
        public static QualifierType Sepentinitic
        {
            get 
            {
                if (sepentinitic == null)
                {
                    sepentinitic = new QualifierType("sepentinitic");
                    sepentinitic.LithoType = EnumValueLithoType.adjective;
                    //UNK sepentinitic.VariantOf = "serpentinite";
                    sepentinitic.Description = "VARIANT. See \"serpentinite\".";
                    sepentinitic.Version = "1.4.1.0";
                }
                return sepentinitic;
            }
        }

        private static QualifierType serpentinite;
        /// <summary>
        /// Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("serpentinite")]
        public static QualifierType Serpentinite
        {
            get 
            {
                if (serpentinite == null)
                {
                    serpentinite = new QualifierType("serpentinite");
                    serpentinite.LithoType = EnumValueLithoType.both;
                    serpentinite.IsLithology = true;
                    serpentinite.Description = "Rock consisting of more than 75 percent serpentine-group minerals, eg. antigorite, chrysotile or lizardite; accessory chlorite, talc and magnetite may be present; derived from hydration of ferromagnesian silicate minerals such as olivine and pyroxene. Neuendorf et al. 2005.";
                    serpentinite.Version = "1.4.1.0";
                }
                return serpentinite;
            }
        }

        private static QualifierType shale;
        /// <summary>
        /// Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically.
        /// </summary>
        [EnumValueNameAttribute("shale")]
        public static QualifierType Shale
        {
            get 
            {
                if (shale == null)
                {
                    shale = new QualifierType("shale");
                    shale.LithoType = EnumValueLithoType.both;
                    shale.IsLithology = true;
                    shale.Description = "Laminated mudstone that will part or break along thin, closely spaced layers parallel to stratification. NADM SLTT sedimentary, 2004. WITSML note: Since Hallsworth and Knox did not recognise the term Shale, some operators do not use this in descriptions, but do plot it graphically.";
                    shale.Version = "1.4.1.0";
                }
                return shale;
            }
        }

        private static QualifierType shaly;
        /// <summary>
        /// VARIANT. See "shale".
        /// </summary>
        [EnumValueNameAttribute("shaly")]
        public static QualifierType Shaly
        {
            get 
            {
                if (shaly == null)
                {
                    shaly = new QualifierType("shaly");
                    shaly.LithoType = EnumValueLithoType.adjective;
                    //UNK shaly.VariantOf = "shale";
                    shaly.Description = "VARIANT. See \"shale\".";
                    shaly.Version = "1.4.1.0";
                }
                return shaly;
            }
        }

        private static QualifierType shell;
        /// <summary>
        /// DEPRECATED. See "shell fragments".
        /// </summary>
        [EnumValueNameAttribute("shell")]
        public static QualifierType Shell
        {
            get 
            {
                if (shell == null)
                {
                    shell = new QualifierType("shell");
                    shell.LithoType = EnumValueLithoType.noun;
                    shell.Description = "DEPRECATED. See \"shell fragments\".";
                    shell.Version = "1.3.1.0";
                    shell.Deprecated = "1.4.0.0";
                    shell.ReplacedBy = ShellFragments;
                }
                return shell;
            }
        }

        private static QualifierType shellFragments;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling shells (generally bivalves) or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("shell fragments")]
        public static QualifierType ShellFragments
        {
            get 
            {
                if (shellFragments == null)
                {
                    shellFragments = new QualifierType("shell fragments");
                    shellFragments.LithoType = EnumValueLithoType.both;
                    shellFragments.Description = "Indicates that the associated lithology comprises material containing or resembling shells (generally bivalves) or fragments thereof.";
                    shellFragments.Version = "1.4.0.0";
                }
                return shellFragments;
            }
        }

        private static QualifierType shelly;
        /// <summary>
        /// VARIANT. See "shell fragments".
        /// </summary>
        [EnumValueNameAttribute("shelly")]
        public static QualifierType Shelly
        {
            get 
            {
                if (shelly == null)
                {
                    shelly = new QualifierType("shelly");
                    shelly.LithoType = EnumValueLithoType.adjective;
                    //UNK shelly.VariantOf = "shell fragments";
                    shelly.Description = "VARIANT. See \"shell fragments\".";
                    shelly.Version = "1.4.0.0";
                }
                return shelly;
            }
        }

        private static QualifierType siderite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling siderite (spathic iron), a carbonate mineral of iron (FeCO3).
        /// </summary>
        [EnumValueNameAttribute("siderite")]
        public static QualifierType Siderite
        {
            get 
            {
                if (siderite == null)
                {
                    siderite = new QualifierType("siderite");
                    siderite.LithoType = EnumValueLithoType.both;
                    siderite.IsMatrixCement = true;
                    siderite.Description = "Indicates that the associated lithology comprises material containing or resembling siderite (spathic iron), a carbonate mineral of iron (FeCO3).";
                    siderite.Version = "1.3.1.0";
                }
                return siderite;
            }
        }

        private static QualifierType sideriteConcretion;
        /// <summary>
        /// Indicates that the associated lithology contains rounded masses comprised of the mineral siderite (spathic iron), a carbonate mineral of iron (FeCO3).
        /// </summary>
        [EnumValueNameAttribute("siderite concretion")]
        public static QualifierType SideriteConcretion
        {
            get 
            {
                if (sideriteConcretion == null)
                {
                    sideriteConcretion = new QualifierType("siderite concretion");
                    sideriteConcretion.LithoType = EnumValueLithoType.noun;
                    sideriteConcretion.Description = "Indicates that the associated lithology contains rounded masses comprised of the mineral siderite (spathic iron), a carbonate mineral of iron (FeCO3).";
                    sideriteConcretion.Version = "1.3.1.0";
                }
                return sideriteConcretion;
            }
        }

        private static QualifierType sideritic;
        /// <summary>
        /// VARIANT. See "siderite".
        /// </summary>
        [EnumValueNameAttribute("sideritic")]
        public static QualifierType Sideritic
        {
            get 
            {
                if (sideritic == null)
                {
                    sideritic = new QualifierType("sideritic");
                    sideritic.LithoType = EnumValueLithoType.adjective;
                    //UNK sideritic.VariantOf = "siderite";
                    sideritic.Description = "VARIANT. See \"siderite\".";
                    sideritic.Version = "1.4.0.0";
                }
                return sideritic;
            }
        }

        private static QualifierType siliceousOoze;
        /// <summary>
        /// Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siliceous ooze")]
        public static QualifierType SiliceousOoze
        {
            get 
            {
                if (siliceousOoze == null)
                {
                    siliceousOoze = new QualifierType("siliceous ooze");
                    siliceousOoze.LithoType = EnumValueLithoType.noun;
                    siliceousOoze.IsLithology = true;
                    siliceousOoze.Description = "Ooze that consists of more than 50 percent siliceous skeletal remains. OneGeology.";
                    siliceousOoze.Version = "1.4.1.0";
                }
                return siliceousOoze;
            }
        }

        private static QualifierType silt;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material of very fine particles intermediate in size between clay and sand (0.0625mm - 2mm).
        /// </summary>
        [EnumValueNameAttribute("silt")]
        public static QualifierType Silt
        {
            get 
            {
                if (silt == null)
                {
                    silt = new QualifierType("silt");
                    silt.LithoType = EnumValueLithoType.both;
                    silt.IsLithology = true;
                    silt.Description = "Indicates that the associated lithology comprises (matrix) material of very fine particles intermediate in size between clay and sand (0.0625mm - 2mm).";
                    silt.Version = "1.4.0.0";
                }
                return silt;
            }
        }

        private static QualifierType siltstone;
        /// <summary>
        /// Mudstone that contains detectable silt. OneGeology.
        /// </summary>
        [EnumValueNameAttribute("siltstone")]
        public static QualifierType Siltstone
        {
            get 
            {
                if (siltstone == null)
                {
                    siltstone = new QualifierType("siltstone");
                    siltstone.LithoType = EnumValueLithoType.noun;
                    siltstone.IsLithology = true;
                    siltstone.Description = "Mudstone that contains detectable silt. OneGeology.";
                    siltstone.Version = "1.4.1.0";
                }
                return siltstone;
            }
        }

        private static QualifierType silty;
        /// <summary>
        /// VARIANT. See "silt".
        /// </summary>
        [EnumValueNameAttribute("silty")]
        public static QualifierType Silty
        {
            get 
            {
                if (silty == null)
                {
                    silty = new QualifierType("silty");
                    silty.LithoType = EnumValueLithoType.adjective;
                    //UNK silty.VariantOf = "silt";
                    silty.Description = "VARIANT. See \"silt\".";
                    silty.Version = "1.3.1.0";
                }
                return silty;
            }
        }

        private static QualifierType skarn;
        /// <summary>
        /// Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195.
        /// </summary>
        [EnumValueNameAttribute("skarn")]
        public static QualifierType Skarn
        {
            get 
            {
                if (skarn == null)
                {
                    skarn = new QualifierType("skarn");
                    skarn.LithoType = EnumValueLithoType.both;
                    skarn.IsLithology = true;
                    skarn.Description = "Metasomatic rock consisting mainly of Ca-, Mg-, Fe-, or Mn-silicate minerals, which are free from or poor in water. Typically formed at the contact between a silicate rock or magma and a carbonate rock.Fettes and Desmons, 2007, p195.";
                    skarn.Version = "1.4.1.0";
                }
                return skarn;
            }
        }

        private static QualifierType skarny;
        /// <summary>
        /// VARIANT. See "skarn".
        /// </summary>
        [EnumValueNameAttribute("skarny")]
        public static QualifierType Skarny
        {
            get 
            {
                if (skarny == null)
                {
                    skarny = new QualifierType("skarny");
                    skarny.LithoType = EnumValueLithoType.adjective;
                    //UNK skarny.VariantOf = "skarn";
                    skarny.Description = "VARIANT. See \"skarn\".";
                    skarny.Version = "1.4.1.0";
                }
                return skarny;
            }
        }

        private static QualifierType slate;
        /// <summary>
        /// Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005.
        /// </summary>
        [EnumValueNameAttribute("slate")]
        public static QualifierType Slate
        {
            get 
            {
                if (slate == null)
                {
                    slate = new QualifierType("slate");
                    slate.LithoType = EnumValueLithoType.both;
                    slate.IsLithology = true;
                    slate.Description = "Compact, fine grained rock with an average grain size less than 0.032 millimeter and a well developed schistosity (slaty cleavage), and hence can be split into slabs or thin plates. NADM metamorphic rock vocabulary SLTTm1.0; Neuendorf et al. 2005.";
                    slate.Version = "1.4.1.0";
                }
                return slate;
            }
        }

        private static QualifierType slaty;
        /// <summary>
        /// VARIANT. See "slate".
        /// </summary>
        [EnumValueNameAttribute("slaty")]
        public static QualifierType Slaty
        {
            get 
            {
                if (slaty == null)
                {
                    slaty = new QualifierType("slaty");
                    slaty.LithoType = EnumValueLithoType.adjective;
                    //UNK slaty.VariantOf = "slate";
                    slaty.Description = "VARIANT. See \"slate\".";
                    slaty.Version = "1.4.1.0";
                }
                return slaty;
            }
        }

        private static QualifierType smectite;
        /// <summary>
        /// A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples.
        /// </summary>
        [EnumValueNameAttribute("smectite")]
        public static QualifierType Smectite
        {
            get 
            {
                if (smectite == null)
                {
                    smectite = new QualifierType("smectite");
                    smectite.LithoType = EnumValueLithoType.both;
                    smectite.IsMatrixCement = true;
                    smectite.Description = "A matrix cement dominantly composed of Smectite. Chemically Smectite is a hydrated sodium calcium aluminium magnesium silicate hydroxide (Na,Ca)0.33(Al,Mg)2(Si4O10)(OH)2Â·nH2O. It will respond to changes in hydration, so may be altered in cuttings samples.";
                    smectite.Version = "1.4.1.0";
                }
                return smectite;
            }
        }

        private static QualifierType smectitic;
        /// <summary>
        /// VARIANT. See "smectite".
        /// </summary>
        [EnumValueNameAttribute("smectitic")]
        public static QualifierType Smectitic
        {
            get 
            {
                if (smectitic == null)
                {
                    smectitic = new QualifierType("smectitic");
                    smectitic.LithoType = EnumValueLithoType.adjective;
                    //UNK smectitic.VariantOf = "smectite";
                    smectitic.Description = "VARIANT. See \"smectite\".";
                    smectitic.Version = "1.4.1.0";
                }
                return smectitic;
            }
        }

        private static QualifierType spicular;
        /// <summary>
        /// VARIANT. See "spicules".
        /// </summary>
        [EnumValueNameAttribute("spicular")]
        public static QualifierType Spicular
        {
            get 
            {
                if (spicular == null)
                {
                    spicular = new QualifierType("spicular");
                    spicular.LithoType = EnumValueLithoType.adjective;
                    //UNK spicular.VariantOf = "spicules";
                    spicular.Description = "VARIANT. See \"spicules\".";
                    spicular.Version = "1.3.1.0";
                }
                return spicular;
            }
        }

        private static QualifierType spicule;
        /// <summary>
        /// DEPRECATED. See spicules.
        /// </summary>
        [EnumValueNameAttribute("spicule")]
        public static QualifierType Spicule
        {
            get 
            {
                if (spicule == null)
                {
                    spicule = new QualifierType("spicule");
                    spicule.LithoType = EnumValueLithoType.noun;
                    spicule.Description = "DEPRECATED. See spicules.";
                    spicule.Version = "1.3.1.0";
                    spicule.Deprecated = "1.4.0.0";
                    spicule.ReplacedBy = Spicules;
                }
                return spicule;
            }
        }

        private static QualifierType spicules;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling minute needle-like structures of silica or carbonate, such as that supporting the soft tissue of certain invertebrates, especially sponges.
        /// </summary>
        [EnumValueNameAttribute("spicules")]
        public static QualifierType Spicules
        {
            get 
            {
                if (spicules == null)
                {
                    spicules = new QualifierType("spicules");
                    spicules.LithoType = EnumValueLithoType.both;
                    spicules.Description = "Indicates that the associated lithology comprises material containing or resembling minute needle-like structures of silica or carbonate, such as that supporting the soft tissue of certain invertebrates, especially sponges.";
                    spicules.Version = "1.4.0.0";
                }
                return spicules;
            }
        }

        private static QualifierType spilite;
        /// <summary>
        /// Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619.
        /// </summary>
        [EnumValueNameAttribute("spilite")]
        public static QualifierType Spilite
        {
            get 
            {
                if (spilite == null)
                {
                    spilite = new QualifierType("spilite");
                    spilite.LithoType = EnumValueLithoType.both;
                    spilite.IsLithology = true;
                    spilite.Description = "Altered basic to intermediate composition fine-grained igneous rock in which the feldspar is partially or completely composed of of albite, typically accompanied by chlorite, calcite, quartz, epidote, prehnite, and low-temperature hydrous crystallization products. Preservation of eruptive volcanic features is typical. Fettes and Desmon, 2007; Best, M.G., 1982, Igneous and metamorphic petrology: New York, W.H. Freeman and Company, p. 398; Neuendorf et al. 2005, p. 619.";
                    spilite.Version = "1.4.1.0";
                }
                return spilite;
            }
        }

        private static QualifierType spilitic;
        /// <summary>
        /// VARIANT. See "spilite".
        /// </summary>
        [EnumValueNameAttribute("spilitic")]
        public static QualifierType Spilitic
        {
            get 
            {
                if (spilitic == null)
                {
                    spilitic = new QualifierType("spilitic");
                    spilitic.LithoType = EnumValueLithoType.adjective;
                    //UNK spilitic.VariantOf = "spilite";
                    spilitic.Description = "VARIANT. See \"spilite\".";
                    spilitic.Version = "1.4.1.0";
                }
                return spilitic;
            }
        }

        private static QualifierType stylolite;
        /// <summary>
        /// DEPRECATED. See stylolites.
        /// </summary>
        [EnumValueNameAttribute("stylolite")]
        public static QualifierType Stylolite
        {
            get 
            {
                if (stylolite == null)
                {
                    stylolite = new QualifierType("stylolite");
                    stylolite.LithoType = EnumValueLithoType.noun;
                    stylolite.Description = "DEPRECATED. See stylolites.";
                    stylolite.Version = "1.3.1.0";
                    stylolite.Deprecated = "1.4.0.0";
                    stylolite.ReplacedBy = Stylolites;
                }
                return stylolite;
            }
        }

        private static QualifierType stylolites;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a contact zone surface between two adjacent calcareous rocks, along which dissolution by pressure solution has ocurred and appearing in cross section as a series of jagged interlocking up-and-down projections (of insoluble clay minerals) that resemble a suture.
        /// </summary>
        [EnumValueNameAttribute("stylolites")]
        public static QualifierType Stylolites
        {
            get 
            {
                if (stylolites == null)
                {
                    stylolites = new QualifierType("stylolites");
                    stylolites.LithoType = EnumValueLithoType.both;
                    stylolites.Description = "Indicates that the associated lithology comprises material containing or resembling a contact zone surface between two adjacent calcareous rocks, along which dissolution by pressure solution has ocurred and appearing in cross section as a series of jagged interlocking up-and-down projections (of insoluble clay minerals) that resemble a suture.";
                    stylolites.Version = "1.4.0.0";
                }
                return stylolites;
            }
        }

        private static QualifierType stylolitic;
        /// <summary>
        /// VARIANT. See "stylolites".
        /// </summary>
        [EnumValueNameAttribute("stylolitic")]
        public static QualifierType Stylolitic
        {
            get 
            {
                if (stylolitic == null)
                {
                    stylolitic = new QualifierType("stylolitic");
                    stylolitic.LithoType = EnumValueLithoType.adjective;
                    //UNK stylolitic.VariantOf = "stylolites";
                    stylolitic.Description = "VARIANT. See \"stylolites\".";
                    stylolitic.Version = "1.3.1.0";
                }
                return stylolitic;
            }
        }

        private static QualifierType syenite;
        /// <summary>
        /// Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz.
        /// </summary>
        [EnumValueNameAttribute("syenite")]
        public static QualifierType Syenite
        {
            get 
            {
                if (syenite == null)
                {
                    syenite = new QualifierType("syenite");
                    syenite.LithoType = EnumValueLithoType.both;
                    syenite.IsLithology = true;
                    syenite.Description = "Plutonic igneous rock composed essentially of alkali feldspar, with lesser sodic plagioclase, biotite and hornblende, and minor quartz.";
                    syenite.Version = "1.4.1.0";
                }
                return syenite;
            }
        }

        private static QualifierType syenitic;
        /// <summary>
        /// VARIANT. See "syenite".
        /// </summary>
        [EnumValueNameAttribute("syenitic")]
        public static QualifierType Syenitic
        {
            get 
            {
                if (syenitic == null)
                {
                    syenitic = new QualifierType("syenitic");
                    syenitic.LithoType = EnumValueLithoType.adjective;
                    //UNK syenitic.VariantOf = "syenite";
                    syenitic.Description = "VARIANT. See \"syenite\".";
                    syenitic.Version = "1.4.1.0";
                }
                return syenitic;
            }
        }

        private static QualifierType syenitoid;
        /// <summary>
        /// Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("syenitoid")]
        public static QualifierType Syenitoid
        {
            get 
            {
                if (syenitoid == null)
                {
                    syenitoid = new QualifierType("syenitoid");
                    syenitoid.LithoType = EnumValueLithoType.noun;
                    syenitoid.IsLithology = true;
                    syenitoid.Description = "Phaneritic crystalline igneous rock with M less than 90, consisting mainly of alkali feldspar and plagioclase; minor quartz or nepheline may be present, along with pyroxene, amphibole or biotite. Ratio of plagioclase to total feldspar is less than 0.65, quartz forms less than 20 percent of QAPF fraction, and feldspathoid minerals form less than 10 percent of QAPF fraction. Includes rocks classified in QAPF fields 6, 7 and 8 and their subdivisions. LeMaitre et al. 2002.";
                    syenitoid.Version = "1.4.1.0";
                }
                return syenitoid;
            }
        }

        private static QualifierType sylvite;
        /// <summary>
        /// Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology.
        /// </summary>
        [EnumValueNameAttribute("sylvite")]
        public static QualifierType Sylvite
        {
            get 
            {
                if (sylvite == null)
                {
                    sylvite = new QualifierType("sylvite");
                    sylvite.LithoType = EnumValueLithoType.both;
                    sylvite.IsLithology = true;
                    sylvite.Description = "Evaporite composed of at least 50 percent Sylvite (KCL). OneGeology.";
                    sylvite.Version = "1.4.1.0";
                }
                return sylvite;
            }
        }

        private static QualifierType sylvitic;
        /// <summary>
        /// VARIANT. See "sylvite".
        /// </summary>
        [EnumValueNameAttribute("sylvitic")]
        public static QualifierType Sylvitic
        {
            get 
            {
                if (sylvitic == null)
                {
                    sylvitic = new QualifierType("sylvitic");
                    sylvitic.LithoType = EnumValueLithoType.adjective;
                    //UNK sylvitic.VariantOf = "sylvite";
                    sylvitic.Description = "VARIANT. See \"sylvite\".";
                    sylvitic.Version = "1.4.1.0";
                }
                return sylvitic;
            }
        }

        private static QualifierType tarry;
        /// <summary>
        /// VARIANT. See "bitumen".
        /// </summary>
        [EnumValueNameAttribute("tarry")]
        public static QualifierType Tarry
        {
            get 
            {
                if (tarry == null)
                {
                    tarry = new QualifierType("tarry");
                    tarry.LithoType = EnumValueLithoType.adjective;
                    //UNK tarry.VariantOf = "bitumen";
                    tarry.Description = "VARIANT. See \"bitumen\".";
                    tarry.Version = "1.4.0.0";
                }
                return tarry;
            }
        }

        private static QualifierType tephrite;
        /// <summary>
        /// Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephrite")]
        public static QualifierType Tephrite
        {
            get 
            {
                if (tephrite == null)
                {
                    tephrite = new QualifierType("tephrite");
                    tephrite.LithoType = EnumValueLithoType.both;
                    tephrite.IsLithology = true;
                    tephrite.Description = "Tephritoid that has a plagioclase to total feldspar ratio greater than 0.9, and contains less than 10 percent normative (CIPW) olivine. LeMaitre et al. 2002.";
                    tephrite.Version = "1.4.1.0";
                }
                return tephrite;
            }
        }

        private static QualifierType tephritic;
        /// <summary>
        /// VARIANT. See "tephrite".
        /// </summary>
        [EnumValueNameAttribute("tephritic")]
        public static QualifierType Tephritic
        {
            get 
            {
                if (tephritic == null)
                {
                    tephritic = new QualifierType("tephritic");
                    tephritic.LithoType = EnumValueLithoType.adjective;
                    //UNK tephritic.VariantOf = "tephrite";
                    tephritic.Description = "VARIANT. See \"tephrite\".";
                    tephritic.Version = "1.4.1.0";
                }
                return tephritic;
            }
        }

        private static QualifierType tephritoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tephritoid")]
        public static QualifierType Tephritoid
        {
            get 
            {
                if (tephritoid == null)
                {
                    tephritoid = new QualifierType("tephritoid");
                    tephritoid.LithoType = EnumValueLithoType.noun;
                    tephritoid.IsLithology = true;
                    tephritoid.Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, between 10 and 60 percent feldspathoid mineral in the QAPF fraction and has a plagioclase to total feldspar ratio greater than 0.5. Includes rocks classified in QAPF field 13 and 14 or chemically in TAS field U1 as basanite or tephrite. LeMaitre et al. 2002.";
                    tephritoid.Version = "1.4.1.0";
                }
                return tephritoid;
            }
        }

        private static QualifierType tholeiiticBasalt;
        /// <summary>
        /// Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.
        /// </summary>
        [EnumValueNameAttribute("tholeiitic basalt")]
        public static QualifierType TholeiiticBasalt
        {
            get 
            {
                if (tholeiiticBasalt == null)
                {
                    tholeiiticBasalt = new QualifierType("tholeiitic basalt");
                    tholeiiticBasalt.LithoType = EnumValueLithoType.noun;
                    tholeiiticBasalt.IsLithology = true;
                    tholeiiticBasalt.Description = "Tholeiitic basalt is defined here to contain 2 pyroxene phases and interstitial quartz or tridymite or cristobalite in the groundmass. Pyroxene (augite and orthopyroxene or pigeonite) and calcium-rich plagioclase are common phenocryst minerals. Olivine may also be a phenocryst, and when present, may have rims of pigeonite. Only in tholeiitic basalt is olivine in reaction relationship with melt. Interstitial siliceous residue may be present, and is often glassy. Tholeiitic basalt is relatively poor in sodium. This category includes most basalts of the ocean floor, most large oceanic islands, and continental flood basalts such as the Columbia River Plateau.Carmichael, I.S. Turner, F.J., Verhoogen, John, 1974, Igneous petrology: New York, McGraw HIll Book Co., p.42-43.";
                    tholeiiticBasalt.Version = "1.4.1.0";
                }
                return tholeiiticBasalt;
            }
        }

        private static QualifierType tonalite;
        /// <summary>
        /// Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("tonalite")]
        public static QualifierType Tonalite
        {
            get 
            {
                if (tonalite == null)
                {
                    tonalite = new QualifierType("tonalite");
                    tonalite.LithoType = EnumValueLithoType.both;
                    tonalite.IsLithology = true;
                    tonalite.Description = "Granitoid consisting of quartz and intermediate plagioclase, usually with biotite and amphibole. Includes rocks defined modally in QAPF field 5; ratio of plagioclase to total feldspar is greater than 0.9. LeMaitre et al. 2002.";
                    tonalite.Version = "1.4.1.0";
                }
                return tonalite;
            }
        }

        private static QualifierType tonalitic;
        /// <summary>
        /// VARIANT. See "tonalite".
        /// </summary>
        [EnumValueNameAttribute("tonalitic")]
        public static QualifierType Tonalitic
        {
            get 
            {
                if (tonalitic == null)
                {
                    tonalitic = new QualifierType("tonalitic");
                    tonalitic.LithoType = EnumValueLithoType.adjective;
                    //UNK tonalitic.VariantOf = "tonalite";
                    tonalitic.Description = "VARIANT. See \"tonalite\".";
                    tonalitic.Version = "1.4.1.0";
                }
                return tonalitic;
            }
        }

        private static QualifierType trachyte;
        /// <summary>
        /// A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals.
        /// </summary>
        [EnumValueNameAttribute("trachyte")]
        public static QualifierType Trachyte
        {
            get 
            {
                if (trachyte == null)
                {
                    trachyte = new QualifierType("trachyte");
                    trachyte.LithoType = EnumValueLithoType.both;
                    trachyte.IsLithology = true;
                    trachyte.Description = "A group of fine-grained often porphyritic volcanic rocks containing alkali feldspar and minor mafic minerals.";
                    trachyte.Version = "1.4.1.0";
                }
                return trachyte;
            }
        }

        private static QualifierType trachytic;
        /// <summary>
        /// VARIANT. See "trachyte".
        /// </summary>
        [EnumValueNameAttribute("trachytic")]
        public static QualifierType Trachytic
        {
            get 
            {
                if (trachytic == null)
                {
                    trachytic = new QualifierType("trachytic");
                    trachytic.LithoType = EnumValueLithoType.adjective;
                    //UNK trachytic.VariantOf = "trachyte";
                    trachytic.Description = "VARIANT. See \"trachyte\".";
                    trachytic.Version = "1.4.1.0";
                }
                return trachytic;
            }
        }

        private static QualifierType trachyticRock;
        /// <summary>
        /// Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytic rock")]
        public static QualifierType TrachyticRock
        {
            get 
            {
                if (trachyticRock == null)
                {
                    trachyticRock = new QualifierType("trachytic rock");
                    trachyticRock.LithoType = EnumValueLithoType.noun;
                    trachyticRock.IsLithology = true;
                    trachyticRock.Description = "Trachytoid that has a plagioclase to total feldspar ratio between 0.1 and 0.35. QAPF fields 7, 7', and 7*. LeMaitre et al. 2002.";
                    trachyticRock.Version = "1.4.1.0";
                }
                return trachyticRock;
            }
        }

        private static QualifierType trachytoid;
        /// <summary>
        /// Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002.
        /// </summary>
        [EnumValueNameAttribute("trachytoid")]
        public static QualifierType Trachytoid
        {
            get 
            {
                if (trachytoid == null)
                {
                    trachytoid = new QualifierType("trachytoid");
                    trachytoid.LithoType = EnumValueLithoType.noun;
                    trachytoid.IsLithology = true;
                    trachytoid.Description = "Fine grained igneous rock than contains less than 90 percent mafic minerals, less than 10 percent feldspathoid mineral and less than 20 percent quartz in the QAPF fraction and has a plagioclase to total feldspar ratio less than 0.65. Mafic minerals typically include amphibole or mica; typically porphyritic. Includes rocks defined modally in QAPF fields 6, 7 and 8 (with subdivisions) or chemically in TAS Field T as trachyte or latite. LeMaitre et al. 2002.";
                    trachytoid.Version = "1.4.1.0";
                }
                return trachytoid;
            }
        }

        private static QualifierType travertine;
        /// <summary>
        /// Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74.
        /// </summary>
        [EnumValueNameAttribute("travertine")]
        public static QualifierType Travertine
        {
            get 
            {
                if (travertine == null)
                {
                    travertine = new QualifierType("travertine");
                    travertine.LithoType = EnumValueLithoType.noun;
                    travertine.IsLithology = true;
                    travertine.Description = "Biotically or abiotically precipitated calcium carbonate, from spring-fed, heated, or ambient-temperature water. May be white and spongy, various shades of orange, tan or gray, and ranges to dense, banded or laminated rock. Macrophytes, bryophytes, algae, cyanobacteria and other organisms often colonize the surface of travertine and may be preserved, to produce the porous varieties. Neuendorf et al. 2005; Chafetz, H.S., and Folk, R.L., 1984, Travertine: Depositional morphology an dthe bacterially constructed constituents: J. Sed. Petrology, v. 126, p.57-74.";
                    travertine.Version = "1.4.1.0";
                }
                return travertine;
            }
        }

        private static QualifierType tuff;
        /// <summary>
        /// Indicates that the associated lithology comprises (matrix) material containing or resembling pyroclastic detrital material (volcanic ash).
        /// </summary>
        [EnumValueNameAttribute("tuff")]
        public static QualifierType Tuff
        {
            get 
            {
                if (tuff == null)
                {
                    tuff = new QualifierType("tuff");
                    tuff.LithoType = EnumValueLithoType.both;
                    tuff.IsLithology = true;
                    tuff.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling pyroclastic detrital material (volcanic ash).";
                    tuff.Version = "1.4.0.0";
                }
                return tuff;
            }
        }

        private static QualifierType tuffaceous;
        /// <summary>
        /// VARIANT. See "tuff".
        /// </summary>
        [EnumValueNameAttribute("tuffaceous")]
        public static QualifierType Tuffaceous
        {
            get 
            {
                if (tuffaceous == null)
                {
                    tuffaceous = new QualifierType("tuffaceous");
                    tuffaceous.LithoType = EnumValueLithoType.adjective;
                    //UNK tuffaceous.VariantOf = "tuff";
                    tuffaceous.Description = "VARIANT. See \"tuff\".";
                    tuffaceous.Version = "1.3.1.0";
                }
                return tuffaceous;
            }
        }

        private static QualifierType tuffite;
        /// <summary>
        /// Indicates that the associated lithology comprises material containing or resembling a fine grained matrix of volcanic breccia with intruded grains of fluidized sediment.
        /// </summary>
        [EnumValueNameAttribute("tuffite")]
        public static QualifierType Tuffite
        {
            get 
            {
                if (tuffite == null)
                {
                    tuffite = new QualifierType("tuffite");
                    tuffite.LithoType = EnumValueLithoType.noun;
                    tuffite.IsLithology = true;
                    tuffite.Description = "Indicates that the associated lithology comprises material containing or resembling a fine grained matrix of volcanic breccia with intruded grains of fluidized sediment.";
                    tuffite.Version = "1.3.1.0";
                }
                return tuffite;
            }
        }

        private static QualifierType tuffitic;
        /// <summary>
        /// VARIANT. See "tuffite".
        /// </summary>
        [EnumValueNameAttribute("tuffitic")]
        public static QualifierType Tuffitic
        {
            get 
            {
                if (tuffitic == null)
                {
                    tuffitic = new QualifierType("tuffitic");
                    tuffitic.LithoType = EnumValueLithoType.adjective;
                    //UNK tuffitic.VariantOf = "tuffite";
                    tuffitic.Description = "VARIANT. See \"tuffite\".";
                    tuffitic.Version = "1.4.1.0";
                }
                return tuffitic;
            }
        }

        private static QualifierType ultrabasic;
        /// <summary>
        /// A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%.
        /// </summary>
        [EnumValueNameAttribute("ultrabasic")]
        public static QualifierType Ultrabasic
        {
            get 
            {
                if (ultrabasic == null)
                {
                    ultrabasic = new QualifierType("ultrabasic");
                    ultrabasic.LithoType = EnumValueLithoType.adjective;
                    ultrabasic.IsLithology = true;
                    ultrabasic.Description = "A class of igneous rocks composed mostly of mafic minerals such as pyroxenes along with calcic feldspar, with no free silica and a total silica content less than about 45%.";
                    ultrabasic.Version = "1.4.1.0";
                }
                return ultrabasic;
            }
        }

        private static QualifierType undifferentiated;
        /// <summary>
        /// The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent.
        /// </summary>
        [EnumValueNameAttribute("undifferentiated")]
        public static QualifierType Undifferentiated
        {
            get 
            {
                if (undifferentiated == null)
                {
                    undifferentiated = new QualifierType("undifferentiated");
                    undifferentiated.LithoType = EnumValueLithoType.adjective;
                    undifferentiated.IsLithology = true;
                    undifferentiated.Description = "The lithology is not differentiated. This is typically used to fill out a lithology description to 100 percent.";
                    undifferentiated.Version = "1.4.1.0";
                }
                return undifferentiated;
            }
        }

        private static QualifierType wacke;
        /// <summary>
        /// Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p.
        /// </summary>
        [EnumValueNameAttribute("wacke")]
        public static QualifierType Wacke
        {
            get 
            {
                if (wacke == null)
                {
                    wacke = new QualifierType("wacke");
                    wacke.LithoType = EnumValueLithoType.noun;
                    wacke.IsLithology = true;
                    wacke.Description = "Clastic sandstone with more than 10 percent matrix of indeterminate detrital or diagenetic nature. Matrix is mud size silicate minerals (clay, feldspar, quartz, rock fragments, and alteration products). Pettijohn, Potter, Siever, 1972, Sand and Sandstone: New York, Springer Verlag, 681 p.";
                    wacke.Version = "1.4.1.0";
                }
                return wacke;
            }
        }

        private static QualifierType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static QualifierType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new QualifierType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                    unknown.Version = "1.3.1.0";
                }
                return unknown;
            }
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

        private static TrajStnCalcAlgorithm constantToolFace;
        /// <summary>
        /// An algorithm used to design a well trajectory during the planning stage
        /// </summary>
        [EnumValueNameAttribute("constant tool face")]
        public static TrajStnCalcAlgorithm ConstantToolFace
        {
            get 
            {
                if (constantToolFace == null)
                {
                    constantToolFace = new TrajStnCalcAlgorithm("constant tool face");
                    constantToolFace.Description = "An algorithm used to design a well trajectory during the planning stage";
                }
                return constantToolFace;
            }
        }

        private static TrajStnCalcAlgorithm minimumCurvature;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is that of a circular arc in 3-D space. Also known as "Minimum Radius Of Curvature" method.
        /// </summary>
        [EnumValueNameAttribute("minimum curvature")]
        public static TrajStnCalcAlgorithm MinimumCurvature
        {
            get 
            {
                if (minimumCurvature == null)
                {
                    minimumCurvature = new TrajStnCalcAlgorithm("minimum curvature");
                    minimumCurvature.Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is that of a circular arc in 3-D space. Also known as \"Minimum Radius Of Curvature\" method.";
                }
                return minimumCurvature;
            }
        }

        private static TrajStnCalcAlgorithm tangential;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is a straight line oriented according to the seconds stations orientation. Also known as "Backward Station" and "Terminal Angle" methods. 
        /// </summary>
        [EnumValueNameAttribute("tangential")]
        public static TrajStnCalcAlgorithm Tangential
        {
            get 
            {
                if (tangential == null)
                {
                    tangential = new TrajStnCalcAlgorithm("tangential");
                    tangential.Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is a straight line oriented according to the seconds stations orientation. Also known as \"Backward Station\" and \"Terminal Angle\" methods. ";
                }
                return tangential;
            }
        }

        private static TrajStnCalcAlgorithm balancedTangential;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along two straight lines, with the first section oriented according to the first stations orientation and the second line oriented according to the second stations orientation. Each line segment is set to have a length of half the measured depth difference between the two stations. Also known as "Acceleration", "Secant", "Trapezoidal", and "Vector Averaging" methods.
        /// </summary>
        [EnumValueNameAttribute("balanced tangential")]
        public static TrajStnCalcAlgorithm BalancedTangential
        {
            get 
            {
                if (balancedTangential == null)
                {
                    balancedTangential = new TrajStnCalcAlgorithm("balanced tangential");
                    balancedTangential.Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along two straight lines, with the first section oriented according to the first stations orientation and the second line oriented according to the second stations orientation. Each line segment is set to have a length of half the measured depth difference between the two stations. Also known as \"Acceleration\", \"Secant\", \"Trapezoidal\", and \"Vector Averaging\" methods.";
                }
                return balancedTangential;
            }
        }

        private static TrajStnCalcAlgorithm averageAngle;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along a straight line oriented according to the average of the inclination and azimuth orientations of the start and end stations. Also known as "Angle Averaging" method. 
        /// </summary>
        [EnumValueNameAttribute("average angle")]
        public static TrajStnCalcAlgorithm AverageAngle
        {
            get 
            {
                if (averageAngle == null)
                {
                    averageAngle = new TrajStnCalcAlgorithm("average angle");
                    averageAngle.Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path between stations is along a straight line oriented according to the average of the inclination and azimuth orientations of the start and end stations. Also known as \"Angle Averaging\" method. ";
                }
                return averageAngle;
            }
        }

        private static TrajStnCalcAlgorithm radiusOfCurvature;
        /// <summary>
        /// An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path is a helix with a fixed vertical radius wrapped around a cylinder of fixed radius. Both radii can tend to infinity yielding simple circular arcs in either the horizontal or vertical planes.
        /// </summary>
        [EnumValueNameAttribute("radius of curvature")]
        public static TrajStnCalcAlgorithm RadiusOfCurvature
        {
            get 
            {
                if (radiusOfCurvature == null)
                {
                    radiusOfCurvature = new TrajStnCalcAlgorithm("radius of curvature");
                    radiusOfCurvature.Description = "An algorithm used to calculate the well trajectory spatial position (X,Y,Z) at execution stage or planning stage. The assumed path is a helix with a fixed vertical radius wrapped around a cylinder of fixed radius. Both radii can tend to infinity yielding simple circular arcs in either the horizontal or vertical planes.";
                }
                return radiusOfCurvature;
            }
        }

        private static TrajStnCalcAlgorithm inertial;
        /// <summary>
        /// This encompasses surveying methods where the positional data was not derived from a transformation of MD,INC,AZM, but are provided directly by some other mechanism such as direct positional output from an inertial gyro system.
        /// </summary>
        [EnumValueNameAttribute("inertial")]
        public static TrajStnCalcAlgorithm Inertial
        {
            get 
            {
                if (inertial == null)
                {
                    inertial = new TrajStnCalcAlgorithm("inertial");
                    inertial.Description = "This encompasses surveying methods where the positional data was not derived from a transformation of MD,INC,AZM, but are provided directly by some other mechanism such as direct positional output from an inertial gyro system.";
                }
                return inertial;
            }
        }

        private static TrajStnCalcAlgorithm custom;
        /// <summary>
        /// This encompasses methodologies which are similar to the Inertial method in that they are direct populations of the positional data, which have been determined by some other possibly non-published methodology.
        /// </summary>
        [EnumValueNameAttribute("custom")]
        public static TrajStnCalcAlgorithm Custom
        {
            get 
            {
                if (custom == null)
                {
                    custom = new TrajStnCalcAlgorithm("custom");
                    custom.Description = "This encompasses methodologies which are similar to the Inertial method in that they are direct populations of the positional data, which have been determined by some other possibly non-published methodology.";
                }
                return custom;
            }
        }

        private static TrajStnCalcAlgorithm unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TrajStnCalcAlgorithm Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new TrajStnCalcAlgorithm("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
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

        private static TypeSurveyTool magneticMwd;
        /// <summary>
        /// A tool measuring downhole inclination and azimuth from sets of accelerometers and magnetometers sensors.
        /// </summary>
        [EnumValueNameAttribute("magnetic MWD")]
        public static TypeSurveyTool MagneticMwd
        {
            get 
            {
                if (magneticMwd == null)
                {
                    magneticMwd = new TypeSurveyTool("magnetic MWD");
                    magneticMwd.Description = "A tool measuring downhole inclination and azimuth from sets of accelerometers and magnetometers sensors.";
                    magneticMwd.Version = "1.3.1";
                }
                return magneticMwd;
            }
        }

        private static TypeSurveyTool gyroscopicMwd;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gyroscopic  MWD")]
        public static TypeSurveyTool GyroscopicMwd
        {
            get 
            {
                if (gyroscopicMwd == null)
                {
                    gyroscopicMwd = new TypeSurveyTool("gyroscopic  MWD");
                    gyroscopicMwd.Version = "1.3.1";
                }
                return gyroscopicMwd;
            }
        }

        private static TypeSurveyTool gyroscopicNorthSeeking;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gyroscopic north seeking")]
        public static TypeSurveyTool GyroscopicNorthSeeking
        {
            get 
            {
                if (gyroscopicNorthSeeking == null)
                {
                    gyroscopicNorthSeeking = new TypeSurveyTool("gyroscopic north seeking");
                    gyroscopicNorthSeeking.Version = "1.3.1";
                }
                return gyroscopicNorthSeeking;
            }
        }

        private static TypeSurveyTool gyroscopicInertial;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gyroscopic inertial")]
        public static TypeSurveyTool GyroscopicInertial
        {
            get 
            {
                if (gyroscopicInertial == null)
                {
                    gyroscopicInertial = new TypeSurveyTool("gyroscopic inertial");
                    gyroscopicInertial.Version = "1.3.1";
                }
                return gyroscopicInertial;
            }
        }

        private static TypeSurveyTool magneticSingleshot;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic single-shot")]
        public static TypeSurveyTool MagneticSingleshot
        {
            get 
            {
                if (magneticSingleshot == null)
                {
                    magneticSingleshot = new TypeSurveyTool("magnetic single-shot");
                    magneticSingleshot.Version = "1.3.1";
                }
                return magneticSingleshot;
            }
        }

        private static TypeSurveyTool magneticMultipleshot;
        /// <summary>
        /// A tool measuring downhole inclination and azimuth from photo-mechanical inclinometers and magnetic compass.
        /// </summary>
        [EnumValueNameAttribute("magnetic multiple-shot")]
        public static TypeSurveyTool MagneticMultipleshot
        {
            get 
            {
                if (magneticMultipleshot == null)
                {
                    magneticMultipleshot = new TypeSurveyTool("magnetic multiple-shot");
                    magneticMultipleshot.Description = "A tool measuring downhole inclination and azimuth from photo-mechanical inclinometers and magnetic compass.";
                    magneticMultipleshot.Version = "1.3.1";
                }
                return magneticMultipleshot;
            }
        }

        private static TypeSurveyTool unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TypeSurveyTool Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new TypeSurveyTool("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                    unknown.Version = "1.3.1";
                }
                return unknown;
            }
        }

    }

}
