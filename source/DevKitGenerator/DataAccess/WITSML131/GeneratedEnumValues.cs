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

        private static LithologyType andesite;
        /// <summary>
        /// Intermediate porphyritic volcanic rock consisting of plagioclase, pyroxene, hornblende and bitotite.
        /// </summary>
        [EnumValueNameAttribute("andesite")]
        public static LithologyType Andesite
        {
            get 
            {
                if (andesite == null)
                {
                    andesite = new LithologyType("andesite");
                    andesite.Description = "Intermediate porphyritic volcanic rock consisting of plagioclase, pyroxene, hornblende and bitotite.";
                }
                return andesite;
            }
        }

        private static LithologyType anhydrite;
        /// <summary>
        /// The mineral form of anhydrous calcium sulfate, commonly massive in evaporite beds.
        /// </summary>
        [EnumValueNameAttribute("anhydrite")]
        public static LithologyType Anhydrite
        {
            get 
            {
                if (anhydrite == null)
                {
                    anhydrite = new LithologyType("anhydrite");
                    anhydrite.Description = "The mineral form of anhydrous calcium sulfate, commonly massive in evaporite beds.";
                }
                return anhydrite;
            }
        }

        private static LithologyType arkose;
        /// <summary>
        /// An indurated arenaceous deposit consisting chiefly of quartz and feldspar (>25%).
        /// </summary>
        [EnumValueNameAttribute("arkose")]
        public static LithologyType Arkose
        {
            get 
            {
                if (arkose == null)
                {
                    arkose = new LithologyType("arkose");
                    arkose.Description = "An indurated arenaceous deposit consisting chiefly of quartz and feldspar (>25%).";
                }
                return arkose;
            }
        }

        private static LithologyType basalt;
        /// <summary>
        /// Volcanic rock consisting essentially of plagioclase feldspar and pyroxene.
        /// </summary>
        [EnumValueNameAttribute("basalt")]
        public static LithologyType Basalt
        {
            get 
            {
                if (basalt == null)
                {
                    basalt = new LithologyType("basalt");
                    basalt.Description = "Volcanic rock consisting essentially of plagioclase feldspar and pyroxene.";
                }
                return basalt;
            }
        }

        private static LithologyType breccia;
        /// <summary>
        /// A lithified rock rich in angular fragments of size greater than 2mm.
        /// </summary>
        [EnumValueNameAttribute("breccia")]
        public static LithologyType Breccia
        {
            get 
            {
                if (breccia == null)
                {
                    breccia = new LithologyType("breccia");
                    breccia.Description = "A lithified rock rich in angular fragments of size greater than 2mm.";
                }
                return breccia;
            }
        }

        private static LithologyType calcarenite;
        /// <summary>
        /// A limestone more than half of which consists of cemented sand-size grains of calcium carbonate: a consolidated calcareous sand.
        /// </summary>
        [EnumValueNameAttribute("calcarenite")]
        public static LithologyType Calcarenite
        {
            get 
            {
                if (calcarenite == null)
                {
                    calcarenite = new LithologyType("calcarenite");
                    calcarenite.Description = "A limestone more than half of which consists of cemented sand-size grains of calcium carbonate: a consolidated calcareous sand.";
                }
                return calcarenite;
            }
        }

        private static LithologyType calcilutite;
        /// <summary>
        /// A limestone more than half of which consists of detrital calcite particles of silt and/or clay size: a consolidated calcareous mud.
        /// </summary>
        [EnumValueNameAttribute("calcilutite")]
        public static LithologyType Calcilutite
        {
            get 
            {
                if (calcilutite == null)
                {
                    calcilutite = new LithologyType("calcilutite");
                    calcilutite.Description = "A limestone more than half of which consists of detrital calcite particles of silt and/or clay size: a consolidated calcareous mud.";
                }
                return calcilutite;
            }
        }

        private static LithologyType calcisiltite;
        /// <summary>
        /// A limestone more than half of which consists of detrital calcite particles of silt size: a consolidated calcareous silt.
        /// </summary>
        [EnumValueNameAttribute("calcisiltite")]
        public static LithologyType Calcisiltite
        {
            get 
            {
                if (calcisiltite == null)
                {
                    calcisiltite = new LithologyType("calcisiltite");
                    calcisiltite.Description = "A limestone more than half of which consists of detrital calcite particles of silt size: a consolidated calcareous silt.";
                }
                return calcisiltite;
            }
        }

        private static LithologyType chalk;
        /// <summary>
        /// A fine-grained limestone composed largely of coccolith fragments.
        /// </summary>
        [EnumValueNameAttribute("chalk")]
        public static LithologyType Chalk
        {
            get 
            {
                if (chalk == null)
                {
                    chalk = new LithologyType("chalk");
                    chalk.Description = "A fine-grained limestone composed largely of coccolith fragments.";
                }
                return chalk;
            }
        }

        private static LithologyType chert;
        /// <summary>
        /// Siliceous sedimentary rock containing finely crystalline snd fibrous quartz.
        /// </summary>
        [EnumValueNameAttribute("chert")]
        public static LithologyType Chert
        {
            get 
            {
                if (chert == null)
                {
                    chert = new LithologyType("chert");
                    chert.Description = "Siliceous sedimentary rock containing finely crystalline snd fibrous quartz.";
                }
                return chert;
            }
        }

        private static LithologyType clay;
        /// <summary>
        /// Unconsolidated deposit of very fine particles of size generally less than 1/256mm and composed of clay minerals.
        /// </summary>
        [EnumValueNameAttribute("clay")]
        public static LithologyType Clay
        {
            get 
            {
                if (clay == null)
                {
                    clay = new LithologyType("clay");
                    clay.Description = "Unconsolidated deposit of very fine particles of size generally less than 1/256mm and composed of clay minerals.";
                }
                return clay;
            }
        }

        private static LithologyType claystone;
        /// <summary>
        /// An indurated clay, lacking the fissility of shale.
        /// </summary>
        [EnumValueNameAttribute("claystone")]
        public static LithologyType Claystone
        {
            get 
            {
                if (claystone == null)
                {
                    claystone = new LithologyType("claystone");
                    claystone.Description = "An indurated clay, lacking the fissility of shale.";
                }
                return claystone;
            }
        }

        private static LithologyType coal;
        /// <summary>
        /// A combustible organic sedimentary rock with less than 40% of mineral matter (based on dry material) composed of polymers of cyclic hydrocarbons.
        /// </summary>
        [EnumValueNameAttribute("coal")]
        public static LithologyType Coal
        {
            get 
            {
                if (coal == null)
                {
                    coal = new LithologyType("coal");
                    coal.Description = "A combustible organic sedimentary rock with less than 40% of mineral matter (based on dry material) composed of polymers of cyclic hydrocarbons.";
                }
                return coal;
            }
        }

        private static LithologyType conglomerate;
        /// <summary>
        /// An indurated sedimentary rock containing an essential quantity of rounded rock fragments larger than 2mm, and normally having a matrix of sand.
        /// </summary>
        [EnumValueNameAttribute("conglomerate")]
        public static LithologyType Conglomerate
        {
            get 
            {
                if (conglomerate == null)
                {
                    conglomerate = new LithologyType("conglomerate");
                    conglomerate.Description = "An indurated sedimentary rock containing an essential quantity of rounded rock fragments larger than 2mm, and normally having a matrix of sand.";
                }
                return conglomerate;
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
                }
                return diabase;
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
                }
                return diorite;
            }
        }

        private static LithologyType dolomite;
        /// <summary>
        /// Sedimentary rock containing more than 90% dolomite (mineral) and less than 10% calcite.
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static LithologyType Dolomite
        {
            get 
            {
                if (dolomite == null)
                {
                    dolomite = new LithologyType("dolomite");
                    dolomite.Description = "Sedimentary rock containing more than 90% dolomite (mineral) and less than 10% calcite.";
                }
                return dolomite;
            }
        }

        private static LithologyType dolomiteCalcareous;
        /// <summary>
        /// A dolomite rock containing more than 10% calcite.
        /// </summary>
        [EnumValueNameAttribute("dolomite, calcareous")]
        public static LithologyType DolomiteCalcareous
        {
            get 
            {
                if (dolomiteCalcareous == null)
                {
                    dolomiteCalcareous = new LithologyType("dolomite, calcareous");
                    dolomiteCalcareous.Description = "A dolomite rock containing more than 10% calcite.";
                }
                return dolomiteCalcareous;
            }
        }

        private static LithologyType extrusiveRockVolcanic;
        /// <summary>
        /// Igneous rocks formed by solidification of material erupted sub-aerially or sub-aqueously onto the earth's surface, as either lava flows or pyroclastic material.
        /// </summary>
        [EnumValueNameAttribute("extrusive rock (volcanic)")]
        public static LithologyType ExtrusiveRockVolcanic
        {
            get 
            {
                if (extrusiveRockVolcanic == null)
                {
                    extrusiveRockVolcanic = new LithologyType("extrusive rock (volcanic)");
                    extrusiveRockVolcanic.Description = "Igneous rocks formed by solidification of material erupted sub-aerially or sub-aqueously onto the earth's surface, as either lava flows or pyroclastic material.";
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
                }
                return feldspar;
            }
        }

        private static LithologyType gabbro;
        /// <summary>
        /// Coarse grained plutonic igneous rock composed essentially of calcic plagioclase feldspar, pyroxenes and iron oxide.
        /// </summary>
        [EnumValueNameAttribute("gabbro")]
        public static LithologyType Gabbro
        {
            get 
            {
                if (gabbro == null)
                {
                    gabbro = new LithologyType("gabbro");
                    gabbro.Description = "Coarse grained plutonic igneous rock composed essentially of calcic plagioclase feldspar, pyroxenes and iron oxide.";
                }
                return gabbro;
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
                }
                return glauconite;
            }
        }

        private static LithologyType gneiss;
        /// <summary>
        /// A metamorphic rock, commonly foliated and crystalline, whose mineral content can range from quartz and feldspars to amphiboles and pyroxenes.
        /// </summary>
        [EnumValueNameAttribute("gneiss")]
        public static LithologyType Gneiss
        {
            get 
            {
                if (gneiss == null)
                {
                    gneiss = new LithologyType("gneiss");
                    gneiss.Description = "A metamorphic rock, commonly foliated and crystalline, whose mineral content can range from quartz and feldspars to amphiboles and pyroxenes.";
                }
                return gneiss;
            }
        }

        private static LithologyType granite;
        /// <summary>
        /// Coarse grained plutonic rock typically containing free quartz, alkali feldspar and biotite mica.
        /// </summary>
        [EnumValueNameAttribute("granite")]
        public static LithologyType Granite
        {
            get 
            {
                if (granite == null)
                {
                    granite = new LithologyType("granite");
                    granite.Description = "Coarse grained plutonic rock typically containing free quartz, alkali feldspar and biotite mica.";
                }
                return granite;
            }
        }

        private static LithologyType gravel;
        /// <summary>
        /// An unconsolidated deposit of coarse clastics. The diameters on the Wenworth scale are generally greater than 2mm.
        /// </summary>
        [EnumValueNameAttribute("gravel")]
        public static LithologyType Gravel
        {
            get 
            {
                if (gravel == null)
                {
                    gravel = new LithologyType("gravel");
                    gravel.Description = "An unconsolidated deposit of coarse clastics. The diameters on the Wenworth scale are generally greater than 2mm.";
                }
                return gravel;
            }
        }

        private static LithologyType greenstones;
        /// <summary>
        /// A field term for any dark fine grained altered or metamorphosed basic igneous rock.
        /// </summary>
        [EnumValueNameAttribute("greenstones")]
        public static LithologyType Greenstones
        {
            get 
            {
                if (greenstones == null)
                {
                    greenstones = new LithologyType("greenstones");
                    greenstones.Description = "A field term for any dark fine grained altered or metamorphosed basic igneous rock.";
                }
                return greenstones;
            }
        }

        private static LithologyType greywacke;
        /// <summary>
        /// A dark grey consolidated deposit containing feldspar, rock fragments and a dark chloritic matrix.
        /// </summary>
        [EnumValueNameAttribute("greywacke")]
        public static LithologyType Greywacke
        {
            get 
            {
                if (greywacke == null)
                {
                    greywacke = new LithologyType("greywacke");
                    greywacke.Description = "A dark grey consolidated deposit containing feldspar, rock fragments and a dark chloritic matrix.";
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
                }
                return gumbo;
            }
        }

        private static LithologyType gypsum;
        /// <summary>
        /// A mineral composed of hydrous calcium sulphate, commonly forming thick extensive evaporite beds.
        /// </summary>
        [EnumValueNameAttribute("gypsum")]
        public static LithologyType Gypsum
        {
            get 
            {
                if (gypsum == null)
                {
                    gypsum = new LithologyType("gypsum");
                    gypsum.Description = "A mineral composed of hydrous calcium sulphate, commonly forming thick extensive evaporite beds.";
                }
                return gypsum;
            }
        }

        private static LithologyType halite;
        /// <summary>
        /// A mineral composed of sodium chloride common in evaporite rocks.
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static LithologyType Halite
        {
            get 
            {
                if (halite == null)
                {
                    halite = new LithologyType("halite");
                    halite.Description = "A mineral composed of sodium chloride common in evaporite rocks.";
                }
                return halite;
            }
        }

        private static LithologyType igneous;
        /// <summary>
        /// Term applied to rock or mineral formed by solidification of molten or partly molten material (magma).
        /// </summary>
        [EnumValueNameAttribute("igneous")]
        public static LithologyType Igneous
        {
            get 
            {
                if (igneous == null)
                {
                    igneous = new LithologyType("igneous");
                    igneous.Description = "Term applied to rock or mineral formed by solidification of molten or partly molten material (magma).";
                }
                return igneous;
            }
        }

        private static LithologyType intrusvieRockPlutonic;
        /// <summary>
        /// Igneous rock formed by cooling and solidification of magma within the earth's crust.
        /// </summary>
        [EnumValueNameAttribute("intrusvie rock (plutonic)")]
        public static LithologyType IntrusvieRockPlutonic
        {
            get 
            {
                if (intrusvieRockPlutonic == null)
                {
                    intrusvieRockPlutonic = new LithologyType("intrusvie rock (plutonic)");
                    intrusvieRockPlutonic.Description = "Igneous rock formed by cooling and solidification of magma within the earth's crust.";
                }
                return intrusvieRockPlutonic;
            }
        }

        private static LithologyType lignite;
        /// <summary>
        /// A low-rank humic coal.
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static LithologyType Lignite
        {
            get 
            {
                if (lignite == null)
                {
                    lignite = new LithologyType("lignite");
                    lignite.Description = "A low-rank humic coal.";
                }
                return lignite;
            }
        }

        private static LithologyType limestone;
        /// <summary>
        /// A sedimentary rock composed mostly of the mineral calcite (calcium carbonate) which is the consolidated equivalent of lime mud, calcareous sand, and/or shell fragments.
        /// </summary>
        [EnumValueNameAttribute("limestone")]
        public static LithologyType Limestone
        {
            get 
            {
                if (limestone == null)
                {
                    limestone = new LithologyType("limestone");
                    limestone.Description = "A sedimentary rock composed mostly of the mineral calcite (calcium carbonate) which is the consolidated equivalent of lime mud, calcareous sand, and/or shell fragments.";
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
                }
                return limestoneSandy;
            }
        }

        private static LithologyType marble;
        /// <summary>
        /// A metamorphic rock composed of calcite.
        /// </summary>
        [EnumValueNameAttribute("marble")]
        public static LithologyType Marble
        {
            get 
            {
                if (marble == null)
                {
                    marble = new LithologyType("marble");
                    marble.Description = "A metamorphic rock composed of calcite.";
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
                }
                return marl;
            }
        }

        private static LithologyType metamorphicRocks;
        /// <summary>
        /// Rocks formed by mineralogical, chemical and structural alteration of pre-existing rocks under conditions of temperature and pressure at depth in the earth.
        /// </summary>
        [EnumValueNameAttribute("metamorphic rocks")]
        public static LithologyType MetamorphicRocks
        {
            get 
            {
                if (metamorphicRocks == null)
                {
                    metamorphicRocks = new LithologyType("metamorphic rocks");
                    metamorphicRocks.Description = "Rocks formed by mineralogical, chemical and structural alteration of pre-existing rocks under conditions of temperature and pressure at depth in the earth.";
                }
                return metamorphicRocks;
            }
        }

        private static LithologyType mudstone;
        /// <summary>
        /// Consolidated and indurated mud.
        /// </summary>
        [EnumValueNameAttribute("mudstone")]
        public static LithologyType Mudstone
        {
            get 
            {
                if (mudstone == null)
                {
                    mudstone = new LithologyType("mudstone");
                    mudstone.Description = "Consolidated and indurated mud.";
                }
                return mudstone;
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
                }
                return noDescription;
            }
        }

        private static LithologyType noSample;
        /// <summary>
        /// No sample is provided.
        /// </summary>
        [EnumValueNameAttribute("no sample")]
        public static LithologyType NoSample
        {
            get 
            {
                if (noSample == null)
                {
                    noSample = new LithologyType("no sample");
                    noSample.Description = "No sample is provided.";
                }
                return noSample;
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
                }
                return ophiolite;
            }
        }

        private static LithologyType peat;
        /// <summary>
        /// Unconsolidated, semi-carbonised plant remains which are a precursor of humic coal.
        /// </summary>
        [EnumValueNameAttribute("peat")]
        public static LithologyType Peat
        {
            get 
            {
                if (peat == null)
                {
                    peat = new LithologyType("peat");
                    peat.Description = "Unconsolidated, semi-carbonised plant remains which are a precursor of humic coal.";
                }
                return peat;
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
                }
                return phosphateRock;
            }
        }

        private static LithologyType potassiumAndMagnesiumSalts;
        /// <summary>
        /// Salts such as sylvinite, carnalite, keiserite with swelling properties that can severely obstruct drilling operations.
        /// </summary>
        [EnumValueNameAttribute("potassium and magnesium salts")]
        public static LithologyType PotassiumAndMagnesiumSalts
        {
            get 
            {
                if (potassiumAndMagnesiumSalts == null)
                {
                    potassiumAndMagnesiumSalts = new LithologyType("potassium and magnesium salts");
                    potassiumAndMagnesiumSalts.Description = "Salts such as sylvinite, carnalite, keiserite with swelling properties that can severely obstruct drilling operations.";
                }
                return potassiumAndMagnesiumSalts;
            }
        }

        private static LithologyType quartzite;
        /// <summary>
        /// A sedimentary rock composed of more than 95% of quartz.
        /// </summary>
        [EnumValueNameAttribute("quartzite")]
        public static LithologyType Quartzite
        {
            get 
            {
                if (quartzite == null)
                {
                    quartzite = new LithologyType("quartzite");
                    quartzite.Description = "A sedimentary rock composed of more than 95% of quartz.";
                }
                return quartzite;
            }
        }

        private static LithologyType rhyolite;
        /// <summary>
        /// Silica rich volcanic rock consisting of quartz and alkali feldspar with minor plagioclase and biotite.
        /// </summary>
        [EnumValueNameAttribute("rhyolite")]
        public static LithologyType Rhyolite
        {
            get 
            {
                if (rhyolite == null)
                {
                    rhyolite = new LithologyType("rhyolite");
                    rhyolite.Description = "Silica rich volcanic rock consisting of quartz and alkali feldspar with minor plagioclase and biotite.";
                }
                return rhyolite;
            }
        }

        private static LithologyType salt;
        /// <summary>
        /// Common term for naturally occurring sodium chloride.
        /// </summary>
        [EnumValueNameAttribute("salt")]
        public static LithologyType Salt
        {
            get 
            {
                if (salt == null)
                {
                    salt = new LithologyType("salt");
                    salt.Description = "Common term for naturally occurring sodium chloride.";
                }
                return salt;
            }
        }

        private static LithologyType sand;
        /// <summary>
        /// An aggregation of particles having diameters in the range 1/16mm to 2mm usually consisting of quartz.
        /// </summary>
        [EnumValueNameAttribute("sand")]
        public static LithologyType Sand
        {
            get 
            {
                if (sand == null)
                {
                    sand = new LithologyType("sand");
                    sand.Description = "An aggregation of particles having diameters in the range 1/16mm to 2mm usually consisting of quartz.";
                }
                return sand;
            }
        }

        private static LithologyType sandstone;
        /// <summary>
        /// A sedimentary rock composed of indurated sand.
        /// </summary>
        [EnumValueNameAttribute("sandstone")]
        public static LithologyType Sandstone
        {
            get 
            {
                if (sandstone == null)
                {
                    sandstone = new LithologyType("sandstone");
                    sandstone.Description = "A sedimentary rock composed of indurated sand.";
                }
                return sandstone;
            }
        }

        private static LithologyType schist;
        /// <summary>
        /// A strongly foliated crystalline metamorphic rock.
        /// </summary>
        [EnumValueNameAttribute("schist")]
        public static LithologyType Schist
        {
            get 
            {
                if (schist == null)
                {
                    schist = new LithologyType("schist");
                    schist.Description = "A strongly foliated crystalline metamorphic rock.";
                }
                return schist;
            }
        }

        private static LithologyType serpentine;
        /// <summary>
        /// A rock forming mineral of hydrous iron and magnesium silicates, often resulting from metamorhism of amphiboles and pyroxenes.
        /// </summary>
        [EnumValueNameAttribute("serpentine")]
        public static LithologyType Serpentine
        {
            get 
            {
                if (serpentine == null)
                {
                    serpentine = new LithologyType("serpentine");
                    serpentine.Description = "A rock forming mineral of hydrous iron and magnesium silicates, often resulting from metamorhism of amphiboles and pyroxenes.";
                }
                return serpentine;
            }
        }

        private static LithologyType shale;
        /// <summary>
        /// A fine-grained sedimentary rock formed by the compaction of clay, silt or mud.
        /// </summary>
        [EnumValueNameAttribute("shale")]
        public static LithologyType Shale
        {
            get 
            {
                if (shale == null)
                {
                    shale = new LithologyType("shale");
                    shale.Description = "A fine-grained sedimentary rock formed by the compaction of clay, silt or mud.";
                }
                return shale;
            }
        }

        private static LithologyType silt;
        /// <summary>
        /// Unconsolidated sedimentary material with grain sizes between 1/16mm and 1/256mm.
        /// </summary>
        [EnumValueNameAttribute("silt")]
        public static LithologyType Silt
        {
            get 
            {
                if (silt == null)
                {
                    silt = new LithologyType("silt");
                    silt.Description = "Unconsolidated sedimentary material with grain sizes between 1/16mm and 1/256mm.";
                }
                return silt;
            }
        }

        private static LithologyType siltstone;
        /// <summary>
        /// Consolidated silt.
        /// </summary>
        [EnumValueNameAttribute("siltstone")]
        public static LithologyType Siltstone
        {
            get 
            {
                if (siltstone == null)
                {
                    siltstone = new LithologyType("siltstone");
                    siltstone.Description = "Consolidated silt.";
                }
                return siltstone;
            }
        }

        private static LithologyType slate;
        /// <summary>
        /// A compact fine-grained metamorphic rock displaying slaty cleavage along which the rock may be cut into sheets.
        /// </summary>
        [EnumValueNameAttribute("slate")]
        public static LithologyType Slate
        {
            get 
            {
                if (slate == null)
                {
                    slate = new LithologyType("slate");
                    slate.Description = "A compact fine-grained metamorphic rock displaying slaty cleavage along which the rock may be cut into sheets.";
                }
                return slate;
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
                }
                return syenite;
            }
        }

        private static LithologyType tilliteDiamictite;
        /// <summary>
        /// Consolidated unsorted glacial deposits with particles ranging from boulder to mud in grain size and of highly variable composition.
        /// </summary>
        [EnumValueNameAttribute("tillite (diamictite)")]
        public static LithologyType TilliteDiamictite
        {
            get 
            {
                if (tilliteDiamictite == null)
                {
                    tilliteDiamictite = new LithologyType("tillite (diamictite)");
                    tilliteDiamictite.Description = "Consolidated unsorted glacial deposits with particles ranging from boulder to mud in grain size and of highly variable composition.";
                }
                return tilliteDiamictite;
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
                }
                return trachyte;
            }
        }

        private static LithologyType tuff;
        /// <summary>
        /// An indurated pyroclastic deposit, predominantly consisting of fine-grained volcanic rocks: sedimentary particles may be present. Tuff may be deposited sub-aerially or sub-aqueously, and may be well sorted or heterogeneous.
        /// </summary>
        [EnumValueNameAttribute("tuff")]
        public static LithologyType Tuff
        {
            get 
            {
                if (tuff == null)
                {
                    tuff = new LithologyType("tuff");
                    tuff.Description = "An indurated pyroclastic deposit, predominantly consisting of fine-grained volcanic rocks: sedimentary particles may be present. Tuff may be deposited sub-aerially or sub-aqueously, and may be well sorted or heterogeneous.";
                }
                return tuff;
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
                }
                return undifferentiated;
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
                }
                return unknown;
            }
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

        private static QualifierType anhydritic;
        /// <summary>
        /// Indicates that the associated lithology contains anhydrite
        /// </summary>
        [EnumValueNameAttribute("anhydritic")]
        public static QualifierType Anhydritic
        {
            get 
            {
                if (anhydritic == null)
                {
                    anhydritic = new QualifierType("anhydritic");
                    anhydritic.Description = "Indicates that the associated lithology contains anhydrite";
                }
                return anhydritic;
            }
        }

        private static QualifierType argillaceous;
        /// <summary>
        /// Indicates that the associated lithology has a clay content
        /// </summary>
        [EnumValueNameAttribute("argillaceous")]
        public static QualifierType Argillaceous
        {
            get 
            {
                if (argillaceous == null)
                {
                    argillaceous = new QualifierType("argillaceous");
                    argillaceous.Description = "Indicates that the associated lithology has a clay content";
                }
                return argillaceous;
            }
        }

        private static QualifierType barite;
        /// <summary>
        /// The mineral form of Barium sulphate.
        /// </summary>
        [EnumValueNameAttribute("barite")]
        public static QualifierType Barite
        {
            get 
            {
                if (barite == null)
                {
                    barite = new QualifierType("barite");
                    barite.Description = "The mineral form of Barium sulphate.";
                }
                return barite;
            }
        }

        private static QualifierType belemnitic;
        /// <summary>
        /// Indicates that the associated lithology contains belemnite fossils or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("belemnitic")]
        public static QualifierType Belemnitic
        {
            get 
            {
                if (belemnitic == null)
                {
                    belemnitic = new QualifierType("belemnitic");
                    belemnitic.Description = "Indicates that the associated lithology contains belemnite fossils or fragments thereof.";
                }
                return belemnitic;
            }
        }

        private static QualifierType bioturbated;
        /// <summary>
        /// Indicates that the associated lithology has been disturbed by organisms before consolidation.
        /// </summary>
        [EnumValueNameAttribute("bioturbated")]
        public static QualifierType Bioturbated
        {
            get 
            {
                if (bioturbated == null)
                {
                    bioturbated = new QualifierType("bioturbated");
                    bioturbated.Description = "Indicates that the associated lithology has been disturbed by organisms before consolidation.";
                }
                return bioturbated;
            }
        }

        private static QualifierType bituminous;
        /// <summary>
        /// Indicates that the associated lithology contains bituminous material
        /// </summary>
        [EnumValueNameAttribute("bituminous")]
        public static QualifierType Bituminous
        {
            get 
            {
                if (bituminous == null)
                {
                    bituminous = new QualifierType("bituminous");
                    bituminous.Description = "Indicates that the associated lithology contains bituminous material";
                }
                return bituminous;
            }
        }

        private static QualifierType bryozoans;
        /// <summary>
        /// Indicates that the associated lithology contains bryozoan fossils or fragments thereof.
        /// </summary>
        [EnumValueNameAttribute("bryozoans")]
        public static QualifierType Bryozoans
        {
            get 
            {
                if (bryozoans == null)
                {
                    bryozoans = new QualifierType("bryozoans");
                    bryozoans.Description = "Indicates that the associated lithology contains bryozoan fossils or fragments thereof.";
                }
                return bryozoans;
            }
        }

        private static QualifierType burrowed;
        /// <summary>
        /// Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation
        /// </summary>
        [EnumValueNameAttribute("burrowed")]
        public static QualifierType Burrowed
        {
            get 
            {
                if (burrowed == null)
                {
                    burrowed = new QualifierType("burrowed");
                    burrowed.Description = "Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation";
                }
                return burrowed;
            }
        }

        private static QualifierType calcareous;
        /// <summary>
        /// Indicates that the associated lithology has a calcite content
        /// </summary>
        [EnumValueNameAttribute("calcareous")]
        public static QualifierType Calcareous
        {
            get 
            {
                if (calcareous == null)
                {
                    calcareous = new QualifierType("calcareous");
                    calcareous.Description = "Indicates that the associated lithology has a calcite content";
                }
                return calcareous;
            }
        }

        private static QualifierType calciteConcr;
        /// <summary>
        /// Indicates that the associated lithology has calcite concretions
        /// </summary>
        [EnumValueNameAttribute("calcite concr")]
        public static QualifierType CalciteConcr
        {
            get 
            {
                if (calciteConcr == null)
                {
                    calciteConcr = new QualifierType("calcite concr");
                    calciteConcr.Description = "Indicates that the associated lithology has calcite concretions";
                }
                return calciteConcr;
            }
        }

        private static QualifierType carbonaceous;
        /// <summary>
        /// Indicates that the associated lithology contains carbonaceous material
        /// </summary>
        [EnumValueNameAttribute("carbonaceous")]
        public static QualifierType Carbonaceous
        {
            get 
            {
                if (carbonaceous == null)
                {
                    carbonaceous = new QualifierType("carbonaceous");
                    carbonaceous.Description = "Indicates that the associated lithology contains carbonaceous material";
                }
                return carbonaceous;
            }
        }

        private static QualifierType chalky;
        /// <summary>
        /// Indicates that the associated lithology has a chalk content
        /// </summary>
        [EnumValueNameAttribute("chalky")]
        public static QualifierType Chalky
        {
            get 
            {
                if (chalky == null)
                {
                    chalky = new QualifierType("chalky");
                    chalky.Description = "Indicates that the associated lithology has a chalk content";
                }
                return chalky;
            }
        }

        private static QualifierType chamosite;
        /// <summary>
        /// Indicates that the associated lithology contains chamosite
        /// </summary>
        [EnumValueNameAttribute("chamosite")]
        public static QualifierType Chamosite
        {
            get 
            {
                if (chamosite == null)
                {
                    chamosite = new QualifierType("chamosite");
                    chamosite.Description = "Indicates that the associated lithology contains chamosite";
                }
                return chamosite;
            }
        }

        private static QualifierType chert;
        /// <summary>
        /// Indicates that the associated lithology contains chert fragments
        /// </summary>
        [EnumValueNameAttribute("chert")]
        public static QualifierType Chert
        {
            get 
            {
                if (chert == null)
                {
                    chert = new QualifierType("chert");
                    chert.Description = "Indicates that the associated lithology contains chert fragments";
                }
                return chert;
            }
        }

        private static QualifierType chlorite;
        /// <summary>
        /// Indicates that the associated lithology contains chlorite
        /// </summary>
        [EnumValueNameAttribute("chlorite")]
        public static QualifierType Chlorite
        {
            get 
            {
                if (chlorite == null)
                {
                    chlorite = new QualifierType("chlorite");
                    chlorite.Description = "Indicates that the associated lithology contains chlorite";
                }
                return chlorite;
            }
        }

        private static QualifierType concretions;
        /// <summary>
        /// Indicates that the associated lithology contains concretions
        /// </summary>
        [EnumValueNameAttribute("concretions")]
        public static QualifierType Concretions
        {
            get 
            {
                if (concretions == null)
                {
                    concretions = new QualifierType("concretions");
                    concretions.Description = "Indicates that the associated lithology contains concretions";
                }
                return concretions;
            }
        }

        private static QualifierType conglomeratic;
        /// <summary>
        /// Indicates that the associated lithology contains conglomerate rock material.
        /// </summary>
        [EnumValueNameAttribute("conglomeratic")]
        public static QualifierType Conglomeratic
        {
            get 
            {
                if (conglomeratic == null)
                {
                    conglomeratic = new QualifierType("conglomeratic");
                    conglomeratic.Description = "Indicates that the associated lithology contains conglomerate rock material.";
                }
                return conglomeratic;
            }
        }

        private static QualifierType coral;
        /// <summary>
        /// Indicates that the associated lithology contains corals and/or coral fragments
        /// </summary>
        [EnumValueNameAttribute("coral")]
        public static QualifierType Coral
        {
            get 
            {
                if (coral == null)
                {
                    coral = new QualifierType("coral");
                    coral.Description = "Indicates that the associated lithology contains corals and/or coral fragments";
                }
                return coral;
            }
        }

        private static QualifierType crinoids;
        /// <summary>
        /// Indicates that the associated lithology contains crinoids and/or crinoid fragments
        /// </summary>
        [EnumValueNameAttribute("crinoids")]
        public static QualifierType Crinoids
        {
            get 
            {
                if (crinoids == null)
                {
                    crinoids = new QualifierType("crinoids");
                    crinoids.Description = "Indicates that the associated lithology contains crinoids and/or crinoid fragments";
                }
                return crinoids;
            }
        }

        private static QualifierType diatoms;
        /// <summary>
        /// Indicates that the associated lithology contains diatoms and/or diatom fragments
        /// </summary>
        [EnumValueNameAttribute("diatoms")]
        public static QualifierType Diatoms
        {
            get 
            {
                if (diatoms == null)
                {
                    diatoms = new QualifierType("diatoms");
                    diatoms.Description = "Indicates that the associated lithology contains diatoms and/or diatom fragments";
                }
                return diatoms;
            }
        }

        private static QualifierType dolomiteConcretion;
        /// <summary>
        /// Indicates that the associated lithology has dolomite concretions
        /// </summary>
        [EnumValueNameAttribute("dolomite concretion")]
        public static QualifierType DolomiteConcretion
        {
            get 
            {
                if (dolomiteConcretion == null)
                {
                    dolomiteConcretion = new QualifierType("dolomite concretion");
                    dolomiteConcretion.Description = "Indicates that the associated lithology has dolomite concretions";
                }
                return dolomiteConcretion;
            }
        }

        private static QualifierType dolomiteStringer;
        /// <summary>
        /// Indicates that the associated lithology contains thin beds or veins of dolomite
        /// </summary>
        [EnumValueNameAttribute("dolomite stringer")]
        public static QualifierType DolomiteStringer
        {
            get 
            {
                if (dolomiteStringer == null)
                {
                    dolomiteStringer = new QualifierType("dolomite stringer");
                    dolomiteStringer.Description = "Indicates that the associated lithology contains thin beds or veins of dolomite";
                }
                return dolomiteStringer;
            }
        }

        private static QualifierType dolomitic;
        /// <summary>
        /// Indicates that the associated lithology has a dolomite content
        /// </summary>
        [EnumValueNameAttribute("dolomitic")]
        public static QualifierType Dolomitic
        {
            get 
            {
                if (dolomitic == null)
                {
                    dolomitic = new QualifierType("dolomitic");
                    dolomitic.Description = "Indicates that the associated lithology has a dolomite content";
                }
                return dolomitic;
            }
        }

        private static QualifierType dolomite;
        /// <summary>
        /// A rock forming mineral composed of calcium-magnesium carbonate (CaMg(CO3)2).
        /// </summary>
        [EnumValueNameAttribute("dolomite")]
        public static QualifierType Dolomite
        {
            get 
            {
                if (dolomite == null)
                {
                    dolomite = new QualifierType("dolomite");
                    dolomite.Description = "A rock forming mineral composed of calcium-magnesium carbonate (CaMg(CO3)2).";
                }
                return dolomite;
            }
        }

        private static QualifierType feldspar;
        /// <summary>
        /// Indicates that the associated lithology contains feldspar
        /// </summary>
        [EnumValueNameAttribute("feldspar")]
        public static QualifierType Feldspar
        {
            get 
            {
                if (feldspar == null)
                {
                    feldspar = new QualifierType("feldspar");
                    feldspar.Description = "Indicates that the associated lithology contains feldspar";
                }
                return feldspar;
            }
        }

        private static QualifierType ferruginous;
        /// <summary>
        /// Indicates that the associated lithology contains minerals rich in iron oxide or iron hydroxide
        /// </summary>
        [EnumValueNameAttribute("ferruginous")]
        public static QualifierType Ferruginous
        {
            get 
            {
                if (ferruginous == null)
                {
                    ferruginous = new QualifierType("ferruginous");
                    ferruginous.Description = "Indicates that the associated lithology contains minerals rich in iron oxide or iron hydroxide";
                }
                return ferruginous;
            }
        }

        private static QualifierType fissile;
        /// <summary>
        /// Indicates that the associated lithology is fissile
        /// </summary>
        [EnumValueNameAttribute("fissile")]
        public static QualifierType Fissile
        {
            get 
            {
                if (fissile == null)
                {
                    fissile = new QualifierType("fissile");
                    fissile.Description = "Indicates that the associated lithology is fissile";
                }
                return fissile;
            }
        }

        private static QualifierType foramsUndifferentiated;
        /// <summary>
        /// Indicates that the associated lithology contains foraminifera
        /// </summary>
        [EnumValueNameAttribute("forams undifferentiated")]
        public static QualifierType ForamsUndifferentiated
        {
            get 
            {
                if (foramsUndifferentiated == null)
                {
                    foramsUndifferentiated = new QualifierType("forams undifferentiated");
                    foramsUndifferentiated.Description = "Indicates that the associated lithology contains foraminifera";
                }
                return foramsUndifferentiated;
            }
        }

        private static QualifierType fossilFragment;
        /// <summary>
        /// Indicates that the associated lithology contains fossil fragments
        /// </summary>
        [EnumValueNameAttribute("fossil fragment")]
        public static QualifierType FossilFragment
        {
            get 
            {
                if (fossilFragment == null)
                {
                    fossilFragment = new QualifierType("fossil fragment");
                    fossilFragment.Description = "Indicates that the associated lithology contains fossil fragments";
                }
                return fossilFragment;
            }
        }

        private static QualifierType fossilsUndifferentiated;
        /// <summary>
        /// Indicates that the associated lithology contains fossils
        /// </summary>
        [EnumValueNameAttribute("fossils undifferentiated")]
        public static QualifierType FossilsUndifferentiated
        {
            get 
            {
                if (fossilsUndifferentiated == null)
                {
                    fossilsUndifferentiated = new QualifierType("fossils undifferentiated");
                    fossilsUndifferentiated.Description = "Indicates that the associated lithology contains fossils";
                }
                return fossilsUndifferentiated;
            }
        }

        private static QualifierType glauconite;
        /// <summary>
        /// Indicates that the associated lithology contains glauconite granules
        /// </summary>
        [EnumValueNameAttribute("glauconite")]
        public static QualifierType Glauconite
        {
            get 
            {
                if (glauconite == null)
                {
                    glauconite = new QualifierType("glauconite");
                    glauconite.Description = "Indicates that the associated lithology contains glauconite granules";
                }
                return glauconite;
            }
        }

        private static QualifierType glauconitic;
        /// <summary>
        /// Indicates that the associated lithology is glauconitic
        /// </summary>
        [EnumValueNameAttribute("glauconitic")]
        public static QualifierType Glauconitic
        {
            get 
            {
                if (glauconitic == null)
                {
                    glauconitic = new QualifierType("glauconitic");
                    glauconitic.Description = "Indicates that the associated lithology is glauconitic";
                }
                return glauconitic;
            }
        }

        private static QualifierType gravelly;
        /// <summary>
        /// Indicates that the associated lithology contains gravel sized particles.
        /// </summary>
        [EnumValueNameAttribute("gravelly")]
        public static QualifierType Gravelly
        {
            get 
            {
                if (gravelly == null)
                {
                    gravelly = new QualifierType("gravelly");
                    gravelly.Description = "Indicates that the associated lithology contains gravel sized particles.";
                }
                return gravelly;
            }
        }

        private static QualifierType gypsiferous;
        /// <summary>
        /// Indicates that the associated lithology contains significant gypsum content.
        /// </summary>
        [EnumValueNameAttribute("gypsiferous")]
        public static QualifierType Gypsiferous
        {
            get 
            {
                if (gypsiferous == null)
                {
                    gypsiferous = new QualifierType("gypsiferous");
                    gypsiferous.Description = "Indicates that the associated lithology contains significant gypsum content.";
                }
                return gypsiferous;
            }
        }

        private static QualifierType halite;
        /// <summary>
        /// Indicates that the associated lithology contains halite
        /// </summary>
        [EnumValueNameAttribute("halite")]
        public static QualifierType Halite
        {
            get 
            {
                if (halite == null)
                {
                    halite = new QualifierType("halite");
                    halite.Description = "Indicates that the associated lithology contains halite";
                }
                return halite;
            }
        }

        private static QualifierType illite;
        /// <summary>
        /// Indicates that the associated lithology contains the clay mineral illite
        /// </summary>
        [EnumValueNameAttribute("illite")]
        public static QualifierType Illite
        {
            get 
            {
                if (illite == null)
                {
                    illite = new QualifierType("illite");
                    illite.Description = "Indicates that the associated lithology contains the clay mineral illite";
                }
                return illite;
            }
        }

        private static QualifierType kaolinite;
        /// <summary>
        /// Indicates that the associated lithology contains kaolinite
        /// </summary>
        [EnumValueNameAttribute("kaolinite")]
        public static QualifierType Kaolinite
        {
            get 
            {
                if (kaolinite == null)
                {
                    kaolinite = new QualifierType("kaolinite");
                    kaolinite.Description = "Indicates that the associated lithology contains kaolinite";
                }
                return kaolinite;
            }
        }

        private static QualifierType lignite;
        /// <summary>
        /// Indicates that the associated lithology contains lignite
        /// </summary>
        [EnumValueNameAttribute("lignite")]
        public static QualifierType Lignite
        {
            get 
            {
                if (lignite == null)
                {
                    lignite = new QualifierType("lignite");
                    lignite.Description = "Indicates that the associated lithology contains lignite";
                }
                return lignite;
            }
        }

        private static QualifierType limestoneStringer;
        /// <summary>
        /// Indicates that the associated lithology contains thin beds or veins of limestone
        /// </summary>
        [EnumValueNameAttribute("limestone stringer")]
        public static QualifierType LimestoneStringer
        {
            get 
            {
                if (limestoneStringer == null)
                {
                    limestoneStringer = new QualifierType("limestone stringer");
                    limestoneStringer.Description = "Indicates that the associated lithology contains thin beds or veins of limestone";
                }
                return limestoneStringer;
            }
        }

        private static QualifierType lithicFragment;
        /// <summary>
        /// Indicates that the associated lithology contains other rock fragments
        /// </summary>
        [EnumValueNameAttribute("lithic fragment")]
        public static QualifierType LithicFragment
        {
            get 
            {
                if (lithicFragment == null)
                {
                    lithicFragment = new QualifierType("lithic fragment");
                    lithicFragment.Description = "Indicates that the associated lithology contains other rock fragments";
                }
                return lithicFragment;
            }
        }

        private static QualifierType marly;
        /// <summary>
        /// Indicates that the associated lithology contains marl
        /// </summary>
        [EnumValueNameAttribute("marly")]
        public static QualifierType Marly
        {
            get 
            {
                if (marly == null)
                {
                    marly = new QualifierType("marly");
                    marly.Description = "Indicates that the associated lithology contains marl";
                }
                return marly;
            }
        }

        private static QualifierType mica;
        /// <summary>
        /// Indicates that the associated lithology contains mica
        /// </summary>
        [EnumValueNameAttribute("mica")]
        public static QualifierType Mica
        {
            get 
            {
                if (mica == null)
                {
                    mica = new QualifierType("mica");
                    mica.Description = "Indicates that the associated lithology contains mica";
                }
                return mica;
            }
        }

        private static QualifierType microfossil;
        /// <summary>
        /// Indicates that the associated lithology contains undifferentiated microfossils
        /// </summary>
        [EnumValueNameAttribute("microfossil")]
        public static QualifierType Microfossil
        {
            get 
            {
                if (microfossil == null)
                {
                    microfossil = new QualifierType("microfossil");
                    microfossil.Description = "Indicates that the associated lithology contains undifferentiated microfossils";
                }
                return microfossil;
            }
        }

        private static QualifierType noDescription;
        /// <summary>
        /// No description is provided
        /// </summary>
        [EnumValueNameAttribute("no description")]
        public static QualifierType NoDescription
        {
            get 
            {
                if (noDescription == null)
                {
                    noDescription = new QualifierType("no description");
                    noDescription.Description = "No description is provided";
                }
                return noDescription;
            }
        }

        private static QualifierType none;
        /// <summary>
        /// No qualifiers specified
        /// </summary>
        [EnumValueNameAttribute("none")]
        public static QualifierType None
        {
            get 
            {
                if (none == null)
                {
                    none = new QualifierType("none");
                    none.Description = "No qualifiers specified";
                }
                return none;
            }
        }

        private static QualifierType oncolite;
        /// <summary>
        /// A rock composed of stacked oncoliths
        /// </summary>
        [EnumValueNameAttribute("oncolite")]
        public static QualifierType Oncolite
        {
            get 
            {
                if (oncolite == null)
                {
                    oncolite = new QualifierType("oncolite");
                    oncolite.Description = "A rock composed of stacked oncoliths";
                }
                return oncolite;
            }
        }

        private static QualifierType oncolith;
        /// <summary>
        /// A hemispheroidal mass of calcified algal laminae surrounding a mud fragment
        /// </summary>
        [EnumValueNameAttribute("oncolith")]
        public static QualifierType Oncolith
        {
            get 
            {
                if (oncolith == null)
                {
                    oncolith = new QualifierType("oncolith");
                    oncolith.Description = "A hemispheroidal mass of calcified algal laminae surrounding a mud fragment";
                }
                return oncolith;
            }
        }

        private static QualifierType oncolithic;
        /// <summary>
        /// Indicates that the associated lithology contains oncolites
        /// </summary>
        [EnumValueNameAttribute("oncolithic")]
        public static QualifierType Oncolithic
        {
            get 
            {
                if (oncolithic == null)
                {
                    oncolithic = new QualifierType("oncolithic");
                    oncolithic.Description = "Indicates that the associated lithology contains oncolites";
                }
                return oncolithic;
            }
        }

        private static QualifierType ooidOrOolith;
        /// <summary>
        /// Indicates that the associated lithology contains ooids (synonym: ooliths)
        /// </summary>
        [EnumValueNameAttribute("ooid or oolith")]
        public static QualifierType OoidOrOolith
        {
            get 
            {
                if (ooidOrOolith == null)
                {
                    ooidOrOolith = new QualifierType("ooid or oolith");
                    ooidOrOolith.Description = "Indicates that the associated lithology contains ooids (synonym: ooliths)";
                }
                return ooidOrOolith;
            }
        }

        private static QualifierType ostracods;
        /// <summary>
        /// Indicates that the associated lithology contains ostracod fossils
        /// </summary>
        [EnumValueNameAttribute("ostracods")]
        public static QualifierType Ostracods
        {
            get 
            {
                if (ostracods == null)
                {
                    ostracods = new QualifierType("ostracods");
                    ostracods.Description = "Indicates that the associated lithology contains ostracod fossils";
                }
                return ostracods;
            }
        }

        private static QualifierType pebbly;
        /// <summary>
        /// Indicates that the associated material contains pebble sized particles.
        /// </summary>
        [EnumValueNameAttribute("pebbly")]
        public static QualifierType Pebbly
        {
            get 
            {
                if (pebbly == null)
                {
                    pebbly = new QualifierType("pebbly");
                    pebbly.Description = "Indicates that the associated material contains pebble sized particles.";
                }
                return pebbly;
            }
        }

        private static QualifierType pelletal;
        /// <summary>
        /// Indicates that the associated lithology contains pellets or fragments of pellets.
        /// </summary>
        [EnumValueNameAttribute("pelletal")]
        public static QualifierType Pelletal
        {
            get 
            {
                if (pelletal == null)
                {
                    pelletal = new QualifierType("pelletal");
                    pelletal.Description = "Indicates that the associated lithology contains pellets or fragments of pellets.";
                }
                return pelletal;
            }
        }

        private static QualifierType pellet;
        /// <summary>
        /// A round or rounded particle generally less than 10mm in diameter, not formed by rounding of detrital material.
        /// </summary>
        [EnumValueNameAttribute("pellet")]
        public static QualifierType Pellet
        {
            get 
            {
                if (pellet == null)
                {
                    pellet = new QualifierType("pellet");
                    pellet.Description = "A round or rounded particle generally less than 10mm in diameter, not formed by rounding of detrital material.";
                }
                return pellet;
            }
        }

        private static QualifierType peloid;
        /// <summary>
        /// A small particle of carbonate mineral in which individual crystals are too small to be distinguished either by the naked eye or under a polarizing microscope (less than 0.001mm).
        /// </summary>
        [EnumValueNameAttribute("peloid")]
        public static QualifierType Peloid
        {
            get 
            {
                if (peloid == null)
                {
                    peloid = new QualifierType("peloid");
                    peloid.Description = "A small particle of carbonate mineral in which individual crystals are too small to be distinguished either by the naked eye or under a polarizing microscope (less than 0.001mm).";
                }
                return peloid;
            }
        }

        private static QualifierType peloidal;
        /// <summary>
        /// Indicates that the associated lithology contains peloids.
        /// </summary>
        [EnumValueNameAttribute("peloidal")]
        public static QualifierType Peloidal
        {
            get 
            {
                if (peloidal == null)
                {
                    peloidal = new QualifierType("peloidal");
                    peloidal.Description = "Indicates that the associated lithology contains peloids.";
                }
                return peloidal;
            }
        }

        private static QualifierType phosphate;
        /// <summary>
        /// Indicates that the associated lithology contains phosphates
        /// </summary>
        [EnumValueNameAttribute("phosphate")]
        public static QualifierType Phosphate
        {
            get 
            {
                if (phosphate == null)
                {
                    phosphate = new QualifierType("phosphate");
                    phosphate.Description = "Indicates that the associated lithology contains phosphates";
                }
                return phosphate;
            }
        }

        private static QualifierType pisolite;
        /// <summary>
        /// A sedimentary rock mainly consisting of pisoliths
        /// </summary>
        [EnumValueNameAttribute("pisolite")]
        public static QualifierType Pisolite
        {
            get 
            {
                if (pisolite == null)
                {
                    pisolite = new QualifierType("pisolite");
                    pisolite.Description = "A sedimentary rock mainly consisting of pisoliths";
                }
                return pisolite;
            }
        }

        private static QualifierType pisolith;
        /// <summary>
        /// A sub-spherical body usually consisting of calcium carbonate, generally of length greater than 2mm
        /// </summary>
        [EnumValueNameAttribute("pisolith")]
        public static QualifierType Pisolith
        {
            get 
            {
                if (pisolith == null)
                {
                    pisolith = new QualifierType("pisolith");
                    pisolith.Description = "A sub-spherical body usually consisting of calcium carbonate, generally of length greater than 2mm";
                }
                return pisolith;
            }
        }

        private static QualifierType plantRemains;
        /// <summary>
        /// Indicates that the associated lithology contains plant remains
        /// </summary>
        [EnumValueNameAttribute("plant remains")]
        public static QualifierType PlantRemains
        {
            get 
            {
                if (plantRemains == null)
                {
                    plantRemains = new QualifierType("plant remains");
                    plantRemains.Description = "Indicates that the associated lithology contains plant remains";
                }
                return plantRemains;
            }
        }

        private static QualifierType pyrite;
        /// <summary>
        /// Indicates that the associated lithology contains pyrite
        /// </summary>
        [EnumValueNameAttribute("pyrite")]
        public static QualifierType Pyrite
        {
            get 
            {
                if (pyrite == null)
                {
                    pyrite = new QualifierType("pyrite");
                    pyrite.Description = "Indicates that the associated lithology contains pyrite";
                }
                return pyrite;
            }
        }

        private static QualifierType quartz;
        /// <summary>
        /// Indicates that the associated lithology contains quartz
        /// </summary>
        [EnumValueNameAttribute("quartz")]
        public static QualifierType Quartz
        {
            get 
            {
                if (quartz == null)
                {
                    quartz = new QualifierType("quartz");
                    quartz.Description = "Indicates that the associated lithology contains quartz";
                }
                return quartz;
            }
        }

        private static QualifierType radiolaria;
        /// <summary>
        /// Indicates that the associated lithology contains radiolaria
        /// </summary>
        [EnumValueNameAttribute("radiolaria")]
        public static QualifierType Radiolaria
        {
            get 
            {
                if (radiolaria == null)
                {
                    radiolaria = new QualifierType("radiolaria");
                    radiolaria.Description = "Indicates that the associated lithology contains radiolaria";
                }
                return radiolaria;
            }
        }

        private static QualifierType salty;
        /// <summary>
        /// Indicates that the associated lithology contains rock salt or halite
        /// </summary>
        [EnumValueNameAttribute("salty")]
        public static QualifierType Salty
        {
            get 
            {
                if (salty == null)
                {
                    salty = new QualifierType("salty");
                    salty.Description = "Indicates that the associated lithology contains rock salt or halite";
                }
                return salty;
            }
        }

        private static QualifierType sandy;
        /// <summary>
        /// Indicates that the associated lithology has a sand content
        /// </summary>
        [EnumValueNameAttribute("sandy")]
        public static QualifierType Sandy
        {
            get 
            {
                if (sandy == null)
                {
                    sandy = new QualifierType("sandy");
                    sandy.Description = "Indicates that the associated lithology has a sand content";
                }
                return sandy;
            }
        }

        private static QualifierType shell;
        /// <summary>
        /// Indicates that the associated lithology contains shell fragments
        /// </summary>
        [EnumValueNameAttribute("shell")]
        public static QualifierType Shell
        {
            get 
            {
                if (shell == null)
                {
                    shell = new QualifierType("shell");
                    shell.Description = "Indicates that the associated lithology contains shell fragments";
                }
                return shell;
            }
        }

        private static QualifierType siderite;
        /// <summary>
        /// Indicates that the associated lithology contains siderite
        /// </summary>
        [EnumValueNameAttribute("siderite")]
        public static QualifierType Siderite
        {
            get 
            {
                if (siderite == null)
                {
                    siderite = new QualifierType("siderite");
                    siderite.Description = "Indicates that the associated lithology contains siderite";
                }
                return siderite;
            }
        }

        private static QualifierType sideriteConcretion;
        /// <summary>
        /// Indicates that the associated lithology contains siderite concretions
        /// </summary>
        [EnumValueNameAttribute("siderite concretion")]
        public static QualifierType SideriteConcretion
        {
            get 
            {
                if (sideriteConcretion == null)
                {
                    sideriteConcretion = new QualifierType("siderite concretion");
                    sideriteConcretion.Description = "Indicates that the associated lithology contains siderite concretions";
                }
                return sideriteConcretion;
            }
        }

        private static QualifierType silty;
        /// <summary>
        /// Indicates that the associated lithology has a silt content
        /// </summary>
        [EnumValueNameAttribute("silty")]
        public static QualifierType Silty
        {
            get 
            {
                if (silty == null)
                {
                    silty = new QualifierType("silty");
                    silty.Description = "Indicates that the associated lithology has a silt content";
                }
                return silty;
            }
        }

        private static QualifierType spicule;
        /// <summary>
        /// A minute needle-like body of quartz or carbonate that forms part of skeletons of animals such as sponges, corals and radiolarians.
        /// </summary>
        [EnumValueNameAttribute("spicule")]
        public static QualifierType Spicule
        {
            get 
            {
                if (spicule == null)
                {
                    spicule = new QualifierType("spicule");
                    spicule.Description = "A minute needle-like body of quartz or carbonate that forms part of skeletons of animals such as sponges, corals and radiolarians.";
                }
                return spicule;
            }
        }

        private static QualifierType spicular;
        /// <summary>
        /// Indicates that the associated lithology contains spicules.
        /// </summary>
        [EnumValueNameAttribute("spicular")]
        public static QualifierType Spicular
        {
            get 
            {
                if (spicular == null)
                {
                    spicular = new QualifierType("spicular");
                    spicular.Description = "Indicates that the associated lithology contains spicules.";
                }
                return spicular;
            }
        }

        private static QualifierType stylolite;
        /// <summary>
        /// A small, more or less columnar, striated extension of a rock body that fits into a corresponding surface, common in carbonate rocks.
        /// </summary>
        [EnumValueNameAttribute("stylolite")]
        public static QualifierType Stylolite
        {
            get 
            {
                if (stylolite == null)
                {
                    stylolite = new QualifierType("stylolite");
                    stylolite.Description = "A small, more or less columnar, striated extension of a rock body that fits into a corresponding surface, common in carbonate rocks.";
                }
                return stylolite;
            }
        }

        private static QualifierType stylolitic;
        /// <summary>
        /// Indicates that the associated lithology contains stylolites.
        /// </summary>
        [EnumValueNameAttribute("stylolitic")]
        public static QualifierType Stylolitic
        {
            get 
            {
                if (stylolitic == null)
                {
                    stylolitic = new QualifierType("stylolitic");
                    stylolitic.Description = "Indicates that the associated lithology contains stylolites.";
                }
                return stylolitic;
            }
        }

        private static QualifierType tuffaceous;
        /// <summary>
        /// Indicates that the associated lithology contains pyroclastic detrital material (tuff).
        /// </summary>
        [EnumValueNameAttribute("tuffaceous")]
        public static QualifierType Tuffaceous
        {
            get 
            {
                if (tuffaceous == null)
                {
                    tuffaceous = new QualifierType("tuffaceous");
                    tuffaceous.Description = "Indicates that the associated lithology contains pyroclastic detrital material (tuff).";
                }
                return tuffaceous;
            }
        }

        private static QualifierType tuffite;
        /// <summary>
        /// Indicates that the associated lithology contains both pyroclastic and other detrital material.
        /// </summary>
        [EnumValueNameAttribute("tuffite")]
        public static QualifierType Tuffite
        {
            get 
            {
                if (tuffite == null)
                {
                    tuffite = new QualifierType("tuffite");
                    tuffite.Description = "Indicates that the associated lithology contains both pyroclastic and other detrital material.";
                }
                return tuffite;
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
                }
                return unknown;
            }
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

        private static RealtimeData lengthAlongFiber;
        /// <summary>
        /// The position along the length of a DTS fiber.
        /// </summary>
        [EnumValueNameAttribute("length along fiber")]
        public static RealtimeData LengthAlongFiber
        {
            get 
            {
                if (lengthAlongFiber == null)
                {
                    lengthAlongFiber = new RealtimeData("length along fiber");
                    lengthAlongFiber.Description = "The position along the length of a DTS fiber.";
                }
                return lengthAlongFiber;
            }
        }

        private static RealtimeData dtsTemperature;
        /// <summary>
        /// The temperature that was calculated from Distributed Temperature Survey data.
        /// </summary>
        [EnumValueNameAttribute("DTS temperature")]
        public static RealtimeData DtsTemperature
        {
            get 
            {
                if (dtsTemperature == null)
                {
                    dtsTemperature = new RealtimeData("DTS temperature");
                    dtsTemperature.Description = "The temperature that was calculated from Distributed Temperature Survey data.";
                }
                return dtsTemperature;
            }
        }

        private static RealtimeData stokesIntensity;
        /// <summary>
        /// Stokes intensity values from a Distributed Temperature Survey.
        /// </summary>
        [EnumValueNameAttribute("Stokes intensity")]
        public static RealtimeData StokesIntensity
        {
            get 
            {
                if (stokesIntensity == null)
                {
                    stokesIntensity = new RealtimeData("Stokes intensity");
                    stokesIntensity.Description = "Stokes intensity values from a Distributed Temperature Survey.";
                }
                return stokesIntensity;
            }
        }

        private static RealtimeData antistokesIntensity;
        /// <summary>
        /// Anti-Stokes intensity values from a Distributed Temperature Survey.
        /// </summary>
        [EnumValueNameAttribute("anti-Stokes intensity")]
        public static RealtimeData AntistokesIntensity
        {
            get 
            {
                if (antistokesIntensity == null)
                {
                    antistokesIntensity = new RealtimeData("anti-Stokes intensity");
                    antistokesIntensity.Description = "Anti-Stokes intensity values from a Distributed Temperature Survey.";
                }
                return antistokesIntensity;
            }
        }

        private static RealtimeData acetylene;
        /// <summary>
        /// Acetylene ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("acetylene")]
        public static RealtimeData Acetylene
        {
            get 
            {
                if (acetylene == null)
                {
                    acetylene = new RealtimeData("acetylene");
                    acetylene.Description = "Acetylene ppm (cycle-based)";
                }
                return acetylene;
            }
        }

        private static RealtimeData azimuthCorrected;
        /// <summary>
        /// MWD azimuth (corrected)
        /// </summary>
        [EnumValueNameAttribute("azimuth corrected")]
        public static RealtimeData AzimuthCorrected
        {
            get 
            {
                if (azimuthCorrected == null)
                {
                    azimuthCorrected = new RealtimeData("azimuth corrected");
                    azimuthCorrected.Description = "MWD azimuth (corrected)";
                }
                return azimuthCorrected;
            }
        }

        private static RealtimeData azimuthUncorrected;
        /// <summary>
        /// MWD azimuth (uncorrected)
        /// </summary>
        [EnumValueNameAttribute("azimuth uncorrected")]
        public static RealtimeData AzimuthUncorrected
        {
            get 
            {
                if (azimuthUncorrected == null)
                {
                    azimuthUncorrected = new RealtimeData("azimuth uncorrected");
                    azimuthUncorrected.Description = "MWD azimuth (uncorrected)";
                }
                return azimuthUncorrected;
            }
        }

        private static RealtimeData bitRevolutionsCumulative;
        /// <summary>
        /// Bit revolutions, cumulative
        /// </summary>
        [EnumValueNameAttribute("bit revolutions, cumulative")]
        public static RealtimeData BitRevolutionsCumulative
        {
            get 
            {
                if (bitRevolutionsCumulative == null)
                {
                    bitRevolutionsCumulative = new RealtimeData("bit revolutions, cumulative");
                    bitRevolutionsCumulative.Description = "Bit revolutions, cumulative";
                }
                return bitRevolutionsCumulative;
            }
        }

        private static RealtimeData buildRate;
        /// <summary>
        /// MWD build rate
        /// </summary>
        [EnumValueNameAttribute("build rate")]
        public static RealtimeData BuildRate
        {
            get 
            {
                if (buildRate == null)
                {
                    buildRate = new RealtimeData("build rate");
                    buildRate.Description = "MWD build rate";
                }
                return buildRate;
            }
        }

        private static RealtimeData caliper;
        /// <summary>
        /// Caliper measurement
        /// </summary>
        [EnumValueNameAttribute("caliper")]
        public static RealtimeData Caliper
        {
            get 
            {
                if (caliper == null)
                {
                    caliper = new RealtimeData("caliper");
                    caliper.Description = "Caliper measurement";
                }
                return caliper;
            }
        }

        private static RealtimeData cavings;
        /// <summary>
        /// Cavings percentage
        /// </summary>
        [EnumValueNameAttribute("cavings")]
        public static RealtimeData Cavings
        {
            get 
            {
                if (cavings == null)
                {
                    cavings = new RealtimeData("cavings");
                    cavings.Description = "Cavings percentage";
                }
                return cavings;
            }
        }

        private static RealtimeData cationExchangeCapacity;
        /// <summary>
        /// Cation exchange capacity
        /// </summary>
        [EnumValueNameAttribute("cation exchange capacity")]
        public static RealtimeData CationExchangeCapacity
        {
            get 
            {
                if (cationExchangeCapacity == null)
                {
                    cationExchangeCapacity = new RealtimeData("cation exchange capacity");
                    cationExchangeCapacity.Description = "Cation exchange capacity";
                }
                return cationExchangeCapacity;
            }
        }

        private static RealtimeData cementingCumulativeReturns;
        /// <summary>
        /// Cementing cumulative returns
        /// </summary>
        [EnumValueNameAttribute("cementing cumulative returns")]
        public static RealtimeData CementingCumulativeReturns
        {
            get 
            {
                if (cementingCumulativeReturns == null)
                {
                    cementingCumulativeReturns = new RealtimeData("cementing cumulative returns");
                    cementingCumulativeReturns.Description = "Cementing cumulative returns";
                }
                return cementingCumulativeReturns;
            }
        }

        private static RealtimeData cementingDensityInAverage;
        /// <summary>
        /// Cementing fluid density in (average)
        /// </summary>
        [EnumValueNameAttribute("cementing density in (average)")]
        public static RealtimeData CementingDensityInAverage
        {
            get 
            {
                if (cementingDensityInAverage == null)
                {
                    cementingDensityInAverage = new RealtimeData("cementing density in (average)");
                    cementingDensityInAverage.Description = "Cementing fluid density in (average)";
                }
                return cementingDensityInAverage;
            }
        }

        private static RealtimeData cementingDensityOutAverage;
        /// <summary>
        /// Cementing fluid density out (average)
        /// </summary>
        [EnumValueNameAttribute("cementing density out (average)")]
        public static RealtimeData CementingDensityOutAverage
        {
            get 
            {
                if (cementingDensityOutAverage == null)
                {
                    cementingDensityOutAverage = new RealtimeData("cementing density out (average)");
                    cementingDensityOutAverage.Description = "Cementing fluid density out (average)";
                }
                return cementingDensityOutAverage;
            }
        }

        private static RealtimeData cementingEcdAtCasingShoe;
        /// <summary>
        /// Cementing effective circulating density at casing shoe
        /// </summary>
        [EnumValueNameAttribute("cementing ECD at casing shoe")]
        public static RealtimeData CementingEcdAtCasingShoe
        {
            get 
            {
                if (cementingEcdAtCasingShoe == null)
                {
                    cementingEcdAtCasingShoe = new RealtimeData("cementing ECD at casing shoe");
                    cementingEcdAtCasingShoe.Description = "Cementing effective circulating density at casing shoe";
                }
                return cementingEcdAtCasingShoe;
            }
        }

        private static RealtimeData cementingFlowRateInAverage;
        /// <summary>
        /// Cementing flow rate in (average)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate in (average)")]
        public static RealtimeData CementingFlowRateInAverage
        {
            get 
            {
                if (cementingFlowRateInAverage == null)
                {
                    cementingFlowRateInAverage = new RealtimeData("cementing flow rate in (average)");
                    cementingFlowRateInAverage.Description = "Cementing flow rate in (average)";
                }
                return cementingFlowRateInAverage;
            }
        }

        private static RealtimeData cementingFlowRateInCalculated;
        /// <summary>
        /// Cementing flow rate in (calculated)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate in (calculated)")]
        public static RealtimeData CementingFlowRateInCalculated
        {
            get 
            {
                if (cementingFlowRateInCalculated == null)
                {
                    cementingFlowRateInCalculated = new RealtimeData("cementing flow rate in (calculated)");
                    cementingFlowRateInCalculated.Description = "Cementing flow rate in (calculated)";
                }
                return cementingFlowRateInCalculated;
            }
        }

        private static RealtimeData cementingFlowRateOutAverage;
        /// <summary>
        /// Cementing flow rate out (average)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (average)")]
        public static RealtimeData CementingFlowRateOutAverage
        {
            get 
            {
                if (cementingFlowRateOutAverage == null)
                {
                    cementingFlowRateOutAverage = new RealtimeData("cementing flow rate out (average)");
                    cementingFlowRateOutAverage.Description = "Cementing flow rate out (average)";
                }
                return cementingFlowRateOutAverage;
            }
        }

        private static RealtimeData cementingFlowRateOutCalculated;
        /// <summary>
        /// Cementing flow rate out (calculated)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (calculated)")]
        public static RealtimeData CementingFlowRateOutCalculated
        {
            get 
            {
                if (cementingFlowRateOutCalculated == null)
                {
                    cementingFlowRateOutCalculated = new RealtimeData("cementing flow rate out (calculated)");
                    cementingFlowRateOutCalculated.Description = "Cementing flow rate out (calculated)";
                }
                return cementingFlowRateOutCalculated;
            }
        }

        private static RealtimeData cementingFlowRateOutRelative;
        /// <summary>
        /// Cementing flow rate out (percentage)
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (relative)")]
        public static RealtimeData CementingFlowRateOutRelative
        {
            get 
            {
                if (cementingFlowRateOutRelative == null)
                {
                    cementingFlowRateOutRelative = new RealtimeData("cementing flow rate out (relative)");
                    cementingFlowRateOutRelative.Description = "Cementing flow rate out (percentage)";
                }
                return cementingFlowRateOutRelative;
            }
        }

        private static RealtimeData cementingFluidType;
        /// <summary>
        /// Cementing fluid type/batch
        /// </summary>
        [EnumValueNameAttribute("cementing fluid type")]
        public static RealtimeData CementingFluidType
        {
            get 
            {
                if (cementingFluidType == null)
                {
                    cementingFluidType = new RealtimeData("cementing fluid type");
                    cementingFluidType.Description = "Cementing fluid type/batch";
                }
                return cementingFluidType;
            }
        }

        private static RealtimeData cementingJobType;
        /// <summary>
        /// Cementing job type
        /// </summary>
        [EnumValueNameAttribute("cementing job type")]
        public static RealtimeData CementingJobType
        {
            get 
            {
                if (cementingJobType == null)
                {
                    cementingJobType = new RealtimeData("cementing job type");
                    cementingJobType.Description = "Cementing job type";
                }
                return cementingJobType;
            }
        }

        private static RealtimeData cementingPlugs;
        /// <summary>
        /// Cementing number and status of plugs
        /// </summary>
        [EnumValueNameAttribute("cementing plugs")]
        public static RealtimeData CementingPlugs
        {
            get 
            {
                if (cementingPlugs == null)
                {
                    cementingPlugs = new RealtimeData("cementing plugs");
                    cementingPlugs.Description = "Cementing number and status of plugs";
                }
                return cementingPlugs;
            }
        }

        private static RealtimeData cementingPumpPressureAverage;
        /// <summary>
        /// Cementing pump pressure (average)
        /// </summary>
        [EnumValueNameAttribute("cementing pump pressure (average)")]
        public static RealtimeData CementingPumpPressureAverage
        {
            get 
            {
                if (cementingPumpPressureAverage == null)
                {
                    cementingPumpPressureAverage = new RealtimeData("cementing pump pressure (average)");
                    cementingPumpPressureAverage.Description = "Cementing pump pressure (average)";
                }
                return cementingPumpPressureAverage;
            }
        }

        private static RealtimeData cementingStage;
        /// <summary>
        /// Cementing stage number
        /// </summary>
        [EnumValueNameAttribute("cementing stage")]
        public static RealtimeData CementingStage
        {
            get 
            {
                if (cementingStage == null)
                {
                    cementingStage = new RealtimeData("cementing stage");
                    cementingStage.Description = "Cementing stage number";
                }
                return cementingStage;
            }
        }

        private static RealtimeData cementingTemperatureInAverage;
        /// <summary>
        /// Cementing fluid temperature in (average)
        /// </summary>
        [EnumValueNameAttribute("cementing temperature in (average)")]
        public static RealtimeData CementingTemperatureInAverage
        {
            get 
            {
                if (cementingTemperatureInAverage == null)
                {
                    cementingTemperatureInAverage = new RealtimeData("cementing temperature in (average)");
                    cementingTemperatureInAverage.Description = "Cementing fluid temperature in (average)";
                }
                return cementingTemperatureInAverage;
            }
        }

        private static RealtimeData cementingTemperatureOutAverage;
        /// <summary>
        /// Cementing fluid temperature out (average)
        /// </summary>
        [EnumValueNameAttribute("cementing temperature out (average)")]
        public static RealtimeData CementingTemperatureOutAverage
        {
            get 
            {
                if (cementingTemperatureOutAverage == null)
                {
                    cementingTemperatureOutAverage = new RealtimeData("cementing temperature out (average)");
                    cementingTemperatureOutAverage.Description = "Cementing fluid temperature out (average)";
                }
                return cementingTemperatureOutAverage;
            }
        }

        private static RealtimeData cementingVolumeToBumpPlug;
        /// <summary>
        /// Cementing volume to bump plug
        /// </summary>
        [EnumValueNameAttribute("cementing volume to bump plug")]
        public static RealtimeData CementingVolumeToBumpPlug
        {
            get 
            {
                if (cementingVolumeToBumpPlug == null)
                {
                    cementingVolumeToBumpPlug = new RealtimeData("cementing volume to bump plug");
                    cementingVolumeToBumpPlug.Description = "Cementing volume to bump plug";
                }
                return cementingVolumeToBumpPlug;
            }
        }

        private static RealtimeData cementingCementVolume;
        /// <summary>
        /// Cementing cement volume pumped
        /// </summary>
        [EnumValueNameAttribute("cementing cement volume")]
        public static RealtimeData CementingCementVolume
        {
            get 
            {
                if (cementingCementVolume == null)
                {
                    cementingCementVolume = new RealtimeData("cementing cement volume");
                    cementingCementVolume.Description = "Cementing cement volume pumped";
                }
                return cementingCementVolume;
            }
        }

        private static RealtimeData cementingIndividualVolume;
        /// <summary>
        /// Cementing individual volume pumped
        /// </summary>
        [EnumValueNameAttribute("cementing individual volume")]
        public static RealtimeData CementingIndividualVolume
        {
            get 
            {
                if (cementingIndividualVolume == null)
                {
                    cementingIndividualVolume = new RealtimeData("cementing individual volume");
                    cementingIndividualVolume.Description = "Cementing individual volume pumped";
                }
                return cementingIndividualVolume;
            }
        }

        private static RealtimeData cementingTotalVolume;
        /// <summary>
        /// Cementing total volume pumped
        /// </summary>
        [EnumValueNameAttribute("cementing total volume")]
        public static RealtimeData CementingTotalVolume
        {
            get 
            {
                if (cementingTotalVolume == null)
                {
                    cementingTotalVolume = new RealtimeData("cementing total volume");
                    cementingTotalVolume.Description = "Cementing total volume pumped";
                }
                return cementingTotalVolume;
            }
        }

        private static RealtimeData chkprav;
        /// <summary>
        /// Casing pressure (average), measured at surface
        /// </summary>
        [EnumValueNameAttribute("chkPrAv")]
        public static RealtimeData Chkprav
        {
            get 
            {
                if (chkprav == null)
                {
                    chkprav = new RealtimeData("chkPrAv");
                    chkprav.Description = "Casing pressure (average), measured at surface";
                }
                return chkprav;
            }
        }

        private static RealtimeData carbonDioxideCyclebased;
        /// <summary>
        /// Carbon Dioxide ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (cycle-based)")]
        public static RealtimeData CarbonDioxideCyclebased
        {
            get 
            {
                if (carbonDioxideCyclebased == null)
                {
                    carbonDioxideCyclebased = new RealtimeData("carbon dioxide (cycle-based)");
                    carbonDioxideCyclebased.Description = "Carbon Dioxide ppm (cycle-based)";
                }
                return carbonDioxideCyclebased;
            }
        }

        private static RealtimeData carbonDioxideAverage;
        /// <summary>
        /// Carbon Dioxide ppm (average)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (average)")]
        public static RealtimeData CarbonDioxideAverage
        {
            get 
            {
                if (carbonDioxideAverage == null)
                {
                    carbonDioxideAverage = new RealtimeData("carbon dioxide (average)");
                    carbonDioxideAverage.Description = "Carbon Dioxide ppm (average)";
                }
                return carbonDioxideAverage;
            }
        }

        private static RealtimeData carbonDioxideMinimum;
        /// <summary>
        /// Carbon Dioxide ppm (min)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (minimum)")]
        public static RealtimeData CarbonDioxideMinimum
        {
            get 
            {
                if (carbonDioxideMinimum == null)
                {
                    carbonDioxideMinimum = new RealtimeData("carbon dioxide (minimum)");
                    carbonDioxideMinimum.Description = "Carbon Dioxide ppm (min)";
                }
                return carbonDioxideMinimum;
            }
        }

        private static RealtimeData carbonDioxideMaximum;
        /// <summary>
        /// Carbon Dioxide ppm (max)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (maximum)")]
        public static RealtimeData CarbonDioxideMaximum
        {
            get 
            {
                if (carbonDioxideMaximum == null)
                {
                    carbonDioxideMaximum = new RealtimeData("carbon dioxide (maximum)");
                    carbonDioxideMaximum.Description = "Carbon Dioxide ppm (max)";
                }
                return carbonDioxideMaximum;
            }
        }

        private static RealtimeData conductivity;
        /// <summary>
        /// Conductivity reading (corrected)
        /// </summary>
        [EnumValueNameAttribute("conductivity")]
        public static RealtimeData Conductivity
        {
            get 
            {
                if (conductivity == null)
                {
                    conductivity = new RealtimeData("conductivity");
                    conductivity.Description = "Conductivity reading (corrected)";
                }
                return conductivity;
            }
        }

        private static RealtimeData conductivityOfMudInAverage;
        /// <summary>
        /// Mud conductivity going into hole
        /// </summary>
        [EnumValueNameAttribute("conductivity of mud in (average)")]
        public static RealtimeData ConductivityOfMudInAverage
        {
            get 
            {
                if (conductivityOfMudInAverage == null)
                {
                    conductivityOfMudInAverage = new RealtimeData("conductivity of mud in (average)");
                    conductivityOfMudInAverage.Description = "Mud conductivity going into hole";
                }
                return conductivityOfMudInAverage;
            }
        }

        private static RealtimeData conductivityOfMudOutAverage;
        /// <summary>
        /// Mud conductivity coming out of the hole
        /// </summary>
        [EnumValueNameAttribute("conductivity of mud out (average)")]
        public static RealtimeData ConductivityOfMudOutAverage
        {
            get 
            {
                if (conductivityOfMudOutAverage == null)
                {
                    conductivityOfMudOutAverage = new RealtimeData("conductivity of mud out (average)");
                    conductivityOfMudOutAverage.Description = "Mud conductivity coming out of the hole";
                }
                return conductivityOfMudOutAverage;
            }
        }

        private static RealtimeData connectionsDone;
        /// <summary>
        /// Connections done
        /// </summary>
        [EnumValueNameAttribute("connections done")]
        public static RealtimeData ConnectionsDone
        {
            get 
            {
                if (connectionsDone == null)
                {
                    connectionsDone = new RealtimeData("connections done");
                    connectionsDone.Description = "Connections done";
                }
                return connectionsDone;
            }
        }

        private static RealtimeData connectionsRemaining;
        /// <summary>
        /// Connections to go
        /// </summary>
        [EnumValueNameAttribute("connections remaining")]
        public static RealtimeData ConnectionsRemaining
        {
            get 
            {
                if (connectionsRemaining == null)
                {
                    connectionsRemaining = new RealtimeData("connections remaining");
                    connectionsRemaining.Description = "Connections to go";
                }
                return connectionsRemaining;
            }
        }

        private static RealtimeData costPerDistance;
        /// <summary>
        /// Instantaneous cost per distance
        /// </summary>
        [EnumValueNameAttribute("cost per distance")]
        public static RealtimeData CostPerDistance
        {
            get 
            {
                if (costPerDistance == null)
                {
                    costPerDistance = new RealtimeData("cost per distance");
                    costPerDistance.Description = "Instantaneous cost per distance";
                }
                return costPerDistance;
            }
        }

        private static RealtimeData costPerDistanceAverage;
        /// <summary>
        /// Cost per distance averaged over the bit run
        /// </summary>
        [EnumValueNameAttribute("cost per distance (average)")]
        public static RealtimeData CostPerDistanceAverage
        {
            get 
            {
                if (costPerDistanceAverage == null)
                {
                    costPerDistanceAverage = new RealtimeData("cost per distance (average)");
                    costPerDistanceAverage.Description = "Cost per distance averaged over the bit run";
                }
                return costPerDistanceAverage;
            }
        }

        private static RealtimeData cumulativeTimeOnBit;
        /// <summary>
        /// Number of drilling hours on the bit
        /// </summary>
        [EnumValueNameAttribute("cumulative time on bit")]
        public static RealtimeData CumulativeTimeOnBit
        {
            get 
            {
                if (cumulativeTimeOnBit == null)
                {
                    cumulativeTimeOnBit = new RealtimeData("cumulative time on bit");
                    cumulativeTimeOnBit.Description = "Number of drilling hours on the bit";
                }
                return cumulativeTimeOnBit;
            }
        }

        private static RealtimeData density;
        /// <summary>
        /// Density value
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static RealtimeData Density
        {
            get 
            {
                if (density == null)
                {
                    density = new RealtimeData("density");
                    density.Description = "Density value";
                }
                return density;
            }
        }

        private static RealtimeData densityShale;
        /// <summary>
        /// Shale density
        /// </summary>
        [EnumValueNameAttribute("density shale")]
        public static RealtimeData DensityShale
        {
            get 
            {
                if (densityShale == null)
                {
                    densityShale = new RealtimeData("density shale");
                    densityShale.Description = "Shale density";
                }
                return densityShale;
            }
        }

        private static RealtimeData diameterOfBit;
        /// <summary>
        /// Bit diameter
        /// </summary>
        [EnumValueNameAttribute("diameter of bit")]
        public static RealtimeData DiameterOfBit
        {
            get 
            {
                if (diameterOfBit == null)
                {
                    diameterOfBit = new RealtimeData("diameter of bit");
                    diameterOfBit.Description = "Bit diameter";
                }
                return diameterOfBit;
            }
        }

        private static RealtimeData distanceDrilledByBit;
        /// <summary>
        /// Distance drilled by the bit
        /// </summary>
        [EnumValueNameAttribute("distance drilled by bit")]
        public static RealtimeData DistanceDrilledByBit
        {
            get 
            {
                if (distanceDrilledByBit == null)
                {
                    distanceDrilledByBit = new RealtimeData("distance drilled by bit");
                    distanceDrilledByBit.Description = "Distance drilled by the bit";
                }
                return distanceDrilledByBit;
            }
        }

        private static RealtimeData doglegSeverity;
        /// <summary>
        /// MWD dogleg severity
        /// </summary>
        [EnumValueNameAttribute("dogleg severity")]
        public static RealtimeData DoglegSeverity
        {
            get 
            {
                if (doglegSeverity == null)
                {
                    doglegSeverity = new RealtimeData("dogleg severity");
                    doglegSeverity.Description = "MWD dogleg severity";
                }
                return doglegSeverity;
            }
        }

        private static RealtimeData dstBottomHolePressure;
        /// <summary>
        /// DST bottom hole pressure
        /// </summary>
        [EnumValueNameAttribute("DST bottom hole pressure")]
        public static RealtimeData DstBottomHolePressure
        {
            get 
            {
                if (dstBottomHolePressure == null)
                {
                    dstBottomHolePressure = new RealtimeData("DST bottom hole pressure");
                    dstBottomHolePressure.Description = "DST bottom hole pressure";
                }
                return dstBottomHolePressure;
            }
        }

        private static RealtimeData dstBottomHoleTemperature;
        /// <summary>
        /// DST Bottom hole temperature
        /// </summary>
        [EnumValueNameAttribute("DST bottom hole temperature")]
        public static RealtimeData DstBottomHoleTemperature
        {
            get 
            {
                if (dstBottomHoleTemperature == null)
                {
                    dstBottomHoleTemperature = new RealtimeData("DST bottom hole temperature");
                    dstBottomHoleTemperature.Description = "DST Bottom hole temperature";
                }
                return dstBottomHoleTemperature;
            }
        }

        private static RealtimeData dstCumulativeGasProduction;
        /// <summary>
        /// DST cumulative gas production
        /// </summary>
        [EnumValueNameAttribute("DST cumulative gas production")]
        public static RealtimeData DstCumulativeGasProduction
        {
            get 
            {
                if (dstCumulativeGasProduction == null)
                {
                    dstCumulativeGasProduction = new RealtimeData("DST cumulative gas production");
                    dstCumulativeGasProduction.Description = "DST cumulative gas production";
                }
                return dstCumulativeGasProduction;
            }
        }

        private static RealtimeData dstCumulativeLiquidProduction;
        /// <summary>
        /// DST cumulative liquid production
        /// </summary>
        [EnumValueNameAttribute("DST cumulative liquid production")]
        public static RealtimeData DstCumulativeLiquidProduction
        {
            get 
            {
                if (dstCumulativeLiquidProduction == null)
                {
                    dstCumulativeLiquidProduction = new RealtimeData("DST cumulative liquid production");
                    dstCumulativeLiquidProduction.Description = "DST cumulative liquid production";
                }
                return dstCumulativeLiquidProduction;
            }
        }

        private static RealtimeData dstCumulativeTotalProduction;
        /// <summary>
        /// DST cumulative total production
        /// </summary>
        [EnumValueNameAttribute("DST cumulative total production")]
        public static RealtimeData DstCumulativeTotalProduction
        {
            get 
            {
                if (dstCumulativeTotalProduction == null)
                {
                    dstCumulativeTotalProduction = new RealtimeData("DST cumulative total production");
                    dstCumulativeTotalProduction.Description = "DST cumulative total production";
                }
                return dstCumulativeTotalProduction;
            }
        }

        private static RealtimeData dstGasFlowRate;
        /// <summary>
        /// DST gas flow rate
        /// </summary>
        [EnumValueNameAttribute("DST gas flow rate")]
        public static RealtimeData DstGasFlowRate
        {
            get 
            {
                if (dstGasFlowRate == null)
                {
                    dstGasFlowRate = new RealtimeData("DST gas flow rate");
                    dstGasFlowRate.Description = "DST gas flow rate";
                }
                return dstGasFlowRate;
            }
        }

        private static RealtimeData dstHydrogenSulfideAverage;
        /// <summary>
        /// Hydrogen Sulfide (average) ppm
        /// </summary>
        [EnumValueNameAttribute("DST hydrogen sulfide (average)")]
        public static RealtimeData DstHydrogenSulfideAverage
        {
            get 
            {
                if (dstHydrogenSulfideAverage == null)
                {
                    dstHydrogenSulfideAverage = new RealtimeData("DST hydrogen sulfide (average)");
                    dstHydrogenSulfideAverage.Description = "Hydrogen Sulfide (average) ppm";
                }
                return dstHydrogenSulfideAverage;
            }
        }

        private static RealtimeData dstIdentifier;
        /// <summary>
        /// Drill stem test identifier
        /// </summary>
        [EnumValueNameAttribute("DST identifier")]
        public static RealtimeData DstIdentifier
        {
            get 
            {
                if (dstIdentifier == null)
                {
                    dstIdentifier = new RealtimeData("DST identifier");
                    dstIdentifier.Description = "Drill stem test identifier";
                }
                return dstIdentifier;
            }
        }

        private static RealtimeData dstLiquidFlowRate;
        /// <summary>
        /// DST liquid flow rate
        /// </summary>
        [EnumValueNameAttribute("DST liquid flow rate")]
        public static RealtimeData DstLiquidFlowRate
        {
            get 
            {
                if (dstLiquidFlowRate == null)
                {
                    dstLiquidFlowRate = new RealtimeData("DST liquid flow rate");
                    dstLiquidFlowRate.Description = "DST liquid flow rate";
                }
                return dstLiquidFlowRate;
            }
        }

        private static RealtimeData dstSurfacePressureInCasing;
        /// <summary>
        /// DST surface pressure in casing
        /// </summary>
        [EnumValueNameAttribute("DST surface pressure in casing")]
        public static RealtimeData DstSurfacePressureInCasing
        {
            get 
            {
                if (dstSurfacePressureInCasing == null)
                {
                    dstSurfacePressureInCasing = new RealtimeData("DST surface pressure in casing");
                    dstSurfacePressureInCasing.Description = "DST surface pressure in casing";
                }
                return dstSurfacePressureInCasing;
            }
        }

        private static RealtimeData dstSurfacePressureInTubing;
        /// <summary>
        /// DST surface pressure in tubing
        /// </summary>
        [EnumValueNameAttribute("DST surface pressure in tubing")]
        public static RealtimeData DstSurfacePressureInTubing
        {
            get 
            {
                if (dstSurfacePressureInTubing == null)
                {
                    dstSurfacePressureInTubing = new RealtimeData("DST surface pressure in tubing");
                    dstSurfacePressureInTubing.Description = "DST surface pressure in tubing";
                }
                return dstSurfacePressureInTubing;
            }
        }

        private static RealtimeData dstSurfaceTemperatureInTubing;
        /// <summary>
        /// DST Surface temperature in tubing
        /// </summary>
        [EnumValueNameAttribute("DST surface temperature in tubing")]
        public static RealtimeData DstSurfaceTemperatureInTubing
        {
            get 
            {
                if (dstSurfaceTemperatureInTubing == null)
                {
                    dstSurfaceTemperatureInTubing = new RealtimeData("DST surface temperature in tubing");
                    dstSurfaceTemperatureInTubing.Description = "DST Surface temperature in tubing";
                }
                return dstSurfaceTemperatureInTubing;
            }
        }

        private static RealtimeData dstTotalFlowRate;
        /// <summary>
        /// DST Total flow rate
        /// </summary>
        [EnumValueNameAttribute("DST total flow rate")]
        public static RealtimeData DstTotalFlowRate
        {
            get 
            {
                if (dstTotalFlowRate == null)
                {
                    dstTotalFlowRate = new RealtimeData("DST total flow rate");
                    dstTotalFlowRate.Description = "DST Total flow rate";
                }
                return dstTotalFlowRate;
            }
        }

        private static RealtimeData dstToolTime;
        /// <summary>
        /// DST tool time (seconds)
        /// </summary>
        [EnumValueNameAttribute("DST tool time")]
        public static RealtimeData DstToolTime
        {
            get 
            {
                if (dstToolTime == null)
                {
                    dstToolTime = new RealtimeData("DST tool time");
                    dstToolTime.Description = "DST tool time (seconds)";
                }
                return dstToolTime;
            }
        }

        private static RealtimeData drillingExponentCorrected;
        /// <summary>
        /// Corrected drilling exponent
        /// </summary>
        [EnumValueNameAttribute("drilling exponent (corrected)")]
        public static RealtimeData DrillingExponentCorrected
        {
            get 
            {
                if (drillingExponentCorrected == null)
                {
                    drillingExponentCorrected = new RealtimeData("drilling exponent (corrected)");
                    drillingExponentCorrected.Description = "Corrected drilling exponent";
                }
                return drillingExponentCorrected;
            }
        }

        private static RealtimeData ecdAtBitDepth;
        /// <summary>
        /// Effective circulating density at bit depth
        /// </summary>
        [EnumValueNameAttribute("ECD at bit depth")]
        public static RealtimeData EcdAtBitDepth
        {
            get 
            {
                if (ecdAtBitDepth == null)
                {
                    ecdAtBitDepth = new RealtimeData("ECD at bit depth");
                    ecdAtBitDepth.Description = "Effective circulating density at bit depth";
                }
                return ecdAtBitDepth;
            }
        }

        private static RealtimeData ecdAtCasingShoeDepth;
        /// <summary>
        /// ECD at casing shoe depth
        /// </summary>
        [EnumValueNameAttribute("ECD at casing shoe depth")]
        public static RealtimeData EcdAtCasingShoeDepth
        {
            get 
            {
                if (ecdAtCasingShoeDepth == null)
                {
                    ecdAtCasingShoeDepth = new RealtimeData("ECD at casing shoe depth");
                    ecdAtCasingShoeDepth.Description = "ECD at casing shoe depth";
                }
                return ecdAtCasingShoeDepth;
            }
        }

        private static RealtimeData ecdFromMwdTool;
        /// <summary>
        /// ECD from MWD tool
        /// </summary>
        [EnumValueNameAttribute("ECD from MWD tool")]
        public static RealtimeData EcdFromMwdTool
        {
            get 
            {
                if (ecdFromMwdTool == null)
                {
                    ecdFromMwdTool = new RealtimeData("ECD from MWD tool");
                    ecdFromMwdTool.Description = "ECD from MWD tool";
                }
                return ecdFromMwdTool;
            }
        }

        private static RealtimeData ecdAtTotalDepth;
        /// <summary>
        /// Equivalent circulating density at total depth
        /// </summary>
        [EnumValueNameAttribute("ECD at total depth")]
        public static RealtimeData EcdAtTotalDepth
        {
            get 
            {
                if (ecdAtTotalDepth == null)
                {
                    ecdAtTotalDepth = new RealtimeData("ECD at total depth");
                    ecdAtTotalDepth.Description = "Equivalent circulating density at total depth";
                }
                return ecdAtTotalDepth;
            }
        }

        private static RealtimeData neopentane;
        /// <summary>
        /// neo-Pentane (eC5) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane")]
        public static RealtimeData Neopentane
        {
            get 
            {
                if (neopentane == null)
                {
                    neopentane = new RealtimeData("neo-pentane");
                    neopentane.Description = "neo-Pentane (eC5) ppm (cycle-based)";
                }
                return neopentane;
            }
        }

        private static RealtimeData neopentaneAverage;
        /// <summary>
        /// neo-Pentane (eC5) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (average)")]
        public static RealtimeData NeopentaneAverage
        {
            get 
            {
                if (neopentaneAverage == null)
                {
                    neopentaneAverage = new RealtimeData("neo-pentane (average)");
                    neopentaneAverage.Description = "neo-Pentane (eC5) ppm (average)";
                }
                return neopentaneAverage;
            }
        }

        private static RealtimeData neopentaneMinimum;
        /// <summary>
        /// neo-Pentane (eC5) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (minimum)")]
        public static RealtimeData NeopentaneMinimum
        {
            get 
            {
                if (neopentaneMinimum == null)
                {
                    neopentaneMinimum = new RealtimeData("neo-pentane (minimum)");
                    neopentaneMinimum.Description = "neo-Pentane (eC5) ppm (min)";
                }
                return neopentaneMinimum;
            }
        }

        private static RealtimeData neopentaneMaximum;
        /// <summary>
        /// neo-Pentane (eC5) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (maximum)")]
        public static RealtimeData NeopentaneMaximum
        {
            get 
            {
                if (neopentaneMaximum == null)
                {
                    neopentaneMaximum = new RealtimeData("neo-pentane (maximum)");
                    neopentaneMaximum.Description = "neo-Pentane (eC5) ppm (max)";
                }
                return neopentaneMaximum;
            }
        }

        private static RealtimeData ethane;
        /// <summary>
        /// Ethane (C2) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("ethane")]
        public static RealtimeData Ethane
        {
            get 
            {
                if (ethane == null)
                {
                    ethane = new RealtimeData("ethane");
                    ethane.Description = "Ethane (C2) ppm (cycle-based)";
                }
                return ethane;
            }
        }

        private static RealtimeData ethaneAverage;
        /// <summary>
        /// Ethane (C2) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("ethane (average)")]
        public static RealtimeData EthaneAverage
        {
            get 
            {
                if (ethaneAverage == null)
                {
                    ethaneAverage = new RealtimeData("ethane (average)");
                    ethaneAverage.Description = "Ethane (C2) ppm (average)";
                }
                return ethaneAverage;
            }
        }

        private static RealtimeData ethaneMinimum;
        /// <summary>
        /// Ethane (C2) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("ethane (minimum)")]
        public static RealtimeData EthaneMinimum
        {
            get 
            {
                if (ethaneMinimum == null)
                {
                    ethaneMinimum = new RealtimeData("ethane (minimum)");
                    ethaneMinimum.Description = "Ethane (C2) ppm (min)";
                }
                return ethaneMinimum;
            }
        }

        private static RealtimeData ethaneMaximum;
        /// <summary>
        /// Ethane (C2) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("ethane (maximum)")]
        public static RealtimeData EthaneMaximum
        {
            get 
            {
                if (ethaneMaximum == null)
                {
                    ethaneMaximum = new RealtimeData("ethane (maximum)");
                    ethaneMaximum.Description = "Ethane (C2) ppm (max)";
                }
                return ethaneMaximum;
            }
        }

        private static RealtimeData formationFracturePressureGradient;
        /// <summary>
        /// Formation fracture pressure gradient
        /// </summary>
        [EnumValueNameAttribute("formation fracture pressure gradient")]
        public static RealtimeData FormationFracturePressureGradient
        {
            get 
            {
                if (formationFracturePressureGradient == null)
                {
                    formationFracturePressureGradient = new RealtimeData("formation fracture pressure gradient");
                    formationFracturePressureGradient.Description = "Formation fracture pressure gradient";
                }
                return formationFracturePressureGradient;
            }
        }

        private static RealtimeData flowRateInAverage;
        /// <summary>
        /// Mud flow into the hole
        /// </summary>
        [EnumValueNameAttribute("flow rate in (average)")]
        public static RealtimeData FlowRateInAverage
        {
            get 
            {
                if (flowRateInAverage == null)
                {
                    flowRateInAverage = new RealtimeData("flow rate in (average)");
                    flowRateInAverage.Description = "Mud flow into the hole";
                }
                return flowRateInAverage;
            }
        }

        private static RealtimeData flowInRelative;
        /// <summary>
        /// Flow into the hole measured as a percentage
        /// </summary>
        [EnumValueNameAttribute("flow in (relative)")]
        public static RealtimeData FlowInRelative
        {
            get 
            {
                if (flowInRelative == null)
                {
                    flowInRelative = new RealtimeData("flow in (relative)");
                    flowInRelative.Description = "Flow into the hole measured as a percentage";
                }
                return flowInRelative;
            }
        }

        private static RealtimeData flowRateOutAverage;
        /// <summary>
        /// Mud flow out of the hole
        /// </summary>
        [EnumValueNameAttribute("flow rate out (average)")]
        public static RealtimeData FlowRateOutAverage
        {
            get 
            {
                if (flowRateOutAverage == null)
                {
                    flowRateOutAverage = new RealtimeData("flow rate out (average)");
                    flowRateOutAverage.Description = "Mud flow out of the hole";
                }
                return flowRateOutAverage;
            }
        }

        private static RealtimeData flowOutRelative;
        /// <summary>
        /// Flow out of hole measured as a percentage
        /// </summary>
        [EnumValueNameAttribute("flow out (relative)")]
        public static RealtimeData FlowOutRelative
        {
            get 
            {
                if (flowOutRelative == null)
                {
                    flowOutRelative = new RealtimeData("flow out (relative)");
                    flowOutRelative.Description = "Flow out of hole measured as a percentage";
                }
                return flowOutRelative;
            }
        }

        private static RealtimeData overburdenPressureGradient;
        /// <summary>
        /// Formation overburden pressure gradient
        /// </summary>
        [EnumValueNameAttribute("overburden pressure gradient")]
        public static RealtimeData OverburdenPressureGradient
        {
            get 
            {
                if (overburdenPressureGradient == null)
                {
                    overburdenPressureGradient = new RealtimeData("overburden pressure gradient");
                    overburdenPressureGradient.Description = "Formation overburden pressure gradient";
                }
                return overburdenPressureGradient;
            }
        }

        private static RealtimeData bitJetImpactForce;
        /// <summary>
        /// Bit jet impact force
        /// </summary>
        [EnumValueNameAttribute("bit jet impact force")]
        public static RealtimeData BitJetImpactForce
        {
            get 
            {
                if (bitJetImpactForce == null)
                {
                    bitJetImpactForce = new RealtimeData("bit jet impact force");
                    bitJetImpactForce.Description = "Bit jet impact force";
                }
                return bitJetImpactForce;
            }
        }

        private static RealtimeData formationPorePressureGradient;
        /// <summary>
        /// Formation pore pressure gradient
        /// </summary>
        [EnumValueNameAttribute("formation pore pressure gradient")]
        public static RealtimeData FormationPorePressureGradient
        {
            get 
            {
                if (formationPorePressureGradient == null)
                {
                    formationPorePressureGradient = new RealtimeData("formation pore pressure gradient");
                    formationPorePressureGradient.Description = "Formation pore pressure gradient";
                }
                return formationPorePressureGradient;
            }
        }

        private static RealtimeData gasTotalAverage;
        /// <summary>
        /// Total gas %
        /// </summary>
        [EnumValueNameAttribute("gas total (average)")]
        public static RealtimeData GasTotalAverage
        {
            get 
            {
                if (gasTotalAverage == null)
                {
                    gasTotalAverage = new RealtimeData("gas total (average)");
                    gasTotalAverage.Description = "Total gas %";
                }
                return gasTotalAverage;
            }
        }

        private static RealtimeData connectionGasAverage;
        /// <summary>
        /// Connection gas (average) %
        /// </summary>
        [EnumValueNameAttribute("connection gas (average)")]
        public static RealtimeData ConnectionGasAverage
        {
            get 
            {
                if (connectionGasAverage == null)
                {
                    connectionGasAverage = new RealtimeData("connection gas (average)");
                    connectionGasAverage.Description = "Connection gas (average) %";
                }
                return connectionGasAverage;
            }
        }

        private static RealtimeData connectionGasLast;
        /// <summary>
        /// Connection gas (last reading) %
        /// </summary>
        [EnumValueNameAttribute("connection gas (last)")]
        public static RealtimeData ConnectionGasLast
        {
            get 
            {
                if (connectionGasLast == null)
                {
                    connectionGasLast = new RealtimeData("connection gas (last)");
                    connectionGasLast.Description = "Connection gas (last reading) %";
                }
                return connectionGasLast;
            }
        }

        private static RealtimeData connectionGasMaximum;
        /// <summary>
        /// Connection gas (maximum) %
        /// </summary>
        [EnumValueNameAttribute("connection gas (maximum)")]
        public static RealtimeData ConnectionGasMaximum
        {
            get 
            {
                if (connectionGasMaximum == null)
                {
                    connectionGasMaximum = new RealtimeData("connection gas (maximum)");
                    connectionGasMaximum.Description = "Connection gas (maximum) %";
                }
                return connectionGasMaximum;
            }
        }

        private static RealtimeData tripGasLast;
        /// <summary>
        /// Trip gas last reading %
        /// </summary>
        [EnumValueNameAttribute("trip gas (last)")]
        public static RealtimeData TripGasLast
        {
            get 
            {
                if (tripGasLast == null)
                {
                    tripGasLast = new RealtimeData("trip gas (last)");
                    tripGasLast.Description = "Trip gas last reading %";
                }
                return tripGasLast;
            }
        }

        private static RealtimeData gammaRay;
        /// <summary>
        /// Gamma ray reading (uncorrected)
        /// </summary>
        [EnumValueNameAttribute("gamma ray")]
        public static RealtimeData GammaRay
        {
            get 
            {
                if (gammaRay == null)
                {
                    gammaRay = new RealtimeData("gamma ray");
                    gammaRay.Description = "Gamma ray reading (uncorrected)";
                }
                return gammaRay;
            }
        }

        private static RealtimeData gammaRayCorrected;
        /// <summary>
        /// Gamma ray reading (corrected)
        /// </summary>
        [EnumValueNameAttribute("gamma ray (corrected)")]
        public static RealtimeData GammaRayCorrected
        {
            get 
            {
                if (gammaRayCorrected == null)
                {
                    gammaRayCorrected = new RealtimeData("gamma ray (corrected)");
                    gammaRayCorrected.Description = "Gamma ray reading (corrected)";
                }
                return gammaRayCorrected;
            }
        }

        private static RealtimeData gravityToolFace;
        /// <summary>
        /// MWD gravity tool face
        /// </summary>
        [EnumValueNameAttribute("gravity tool face")]
        public static RealtimeData GravityToolFace
        {
            get 
            {
                if (gravityToolFace == null)
                {
                    gravityToolFace = new RealtimeData("gravity tool face");
                    gravityToolFace.Description = "MWD gravity tool face";
                }
                return gravityToolFace;
            }
        }

        private static RealtimeData gravityXaxisCorrected;
        /// <summary>
        /// X axis gravity corrected
        /// </summary>
        [EnumValueNameAttribute("gravity X-axis (corrected)")]
        public static RealtimeData GravityXaxisCorrected
        {
            get 
            {
                if (gravityXaxisCorrected == null)
                {
                    gravityXaxisCorrected = new RealtimeData("gravity X-axis (corrected)");
                    gravityXaxisCorrected.Description = "X axis gravity corrected";
                }
                return gravityXaxisCorrected;
            }
        }

        private static RealtimeData gravityXaxisUncorrected;
        /// <summary>
        /// X axis gravity uncorrected
        /// </summary>
        [EnumValueNameAttribute("gravity X-axis (uncorrected)")]
        public static RealtimeData GravityXaxisUncorrected
        {
            get 
            {
                if (gravityXaxisUncorrected == null)
                {
                    gravityXaxisUncorrected = new RealtimeData("gravity X-axis (uncorrected)");
                    gravityXaxisUncorrected.Description = "X axis gravity uncorrected";
                }
                return gravityXaxisUncorrected;
            }
        }

        private static RealtimeData gravityYaxisCorrected;
        /// <summary>
        /// Y axis gravity corrected
        /// </summary>
        [EnumValueNameAttribute("gravity Y-axis (corrected)")]
        public static RealtimeData GravityYaxisCorrected
        {
            get 
            {
                if (gravityYaxisCorrected == null)
                {
                    gravityYaxisCorrected = new RealtimeData("gravity Y-axis (corrected)");
                    gravityYaxisCorrected.Description = "Y axis gravity corrected";
                }
                return gravityYaxisCorrected;
            }
        }

        private static RealtimeData gravityYaxisUncorrected;
        /// <summary>
        /// Y axis gravity uncorrected
        /// </summary>
        [EnumValueNameAttribute("gravity Y-axis (uncorrected)")]
        public static RealtimeData GravityYaxisUncorrected
        {
            get 
            {
                if (gravityYaxisUncorrected == null)
                {
                    gravityYaxisUncorrected = new RealtimeData("gravity Y-axis (uncorrected)");
                    gravityYaxisUncorrected.Description = "Y axis gravity uncorrected";
                }
                return gravityYaxisUncorrected;
            }
        }

        private static RealtimeData gravityZaxisCorrected;
        /// <summary>
        /// Z axis gravity corrected
        /// </summary>
        [EnumValueNameAttribute("gravity Z-axis (corrected)")]
        public static RealtimeData GravityZaxisCorrected
        {
            get 
            {
                if (gravityZaxisCorrected == null)
                {
                    gravityZaxisCorrected = new RealtimeData("gravity Z-axis (corrected)");
                    gravityZaxisCorrected.Description = "Z axis gravity corrected";
                }
                return gravityZaxisCorrected;
            }
        }

        private static RealtimeData gravityZaxisUncorrected;
        /// <summary>
        /// Z axis gravity uncorrected
        /// </summary>
        [EnumValueNameAttribute("gravity Z-axis (uncorrected)")]
        public static RealtimeData GravityZaxisUncorrected
        {
            get 
            {
                if (gravityZaxisUncorrected == null)
                {
                    gravityZaxisUncorrected = new RealtimeData("gravity Z-axis (uncorrected)");
                    gravityZaxisUncorrected.Description = "Z axis gravity uncorrected";
                }
                return gravityZaxisUncorrected;
            }
        }

        private static RealtimeData hydrogenSulfide;
        /// <summary>
        /// Hydrogen Sulfide ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide")]
        public static RealtimeData HydrogenSulfide
        {
            get 
            {
                if (hydrogenSulfide == null)
                {
                    hydrogenSulfide = new RealtimeData("hydrogen sulfide");
                    hydrogenSulfide.Description = "Hydrogen Sulfide ppm";
                }
                return hydrogenSulfide;
            }
        }

        private static RealtimeData hydrogenSulfideAverage;
        /// <summary>
        /// Hydrogen Sulfide (average) ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (average)")]
        public static RealtimeData HydrogenSulfideAverage
        {
            get 
            {
                if (hydrogenSulfideAverage == null)
                {
                    hydrogenSulfideAverage = new RealtimeData("hydrogen sulfide (average)");
                    hydrogenSulfideAverage.Description = "Hydrogen Sulfide (average) ppm";
                }
                return hydrogenSulfideAverage;
            }
        }

        private static RealtimeData hydrogenSulfideMinimum;
        /// <summary>
        /// Hydrogen Sulfide (min) ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (minimum)")]
        public static RealtimeData HydrogenSulfideMinimum
        {
            get 
            {
                if (hydrogenSulfideMinimum == null)
                {
                    hydrogenSulfideMinimum = new RealtimeData("hydrogen sulfide (minimum)");
                    hydrogenSulfideMinimum.Description = "Hydrogen Sulfide (min) ppm";
                }
                return hydrogenSulfideMinimum;
            }
        }

        private static RealtimeData hydrogenSulfideMaximum;
        /// <summary>
        /// Hydrogen Sulfide (max) ppm
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (maximum)")]
        public static RealtimeData HydrogenSulfideMaximum
        {
            get 
            {
                if (hydrogenSulfideMaximum == null)
                {
                    hydrogenSulfideMaximum = new RealtimeData("hydrogen sulfide (maximum)");
                    hydrogenSulfideMaximum.Description = "Hydrogen Sulfide (max) ppm";
                }
                return hydrogenSulfideMaximum;
            }
        }

        private static RealtimeData hookloadAverage;
        /// <summary>
        /// Hookload, average, measured at surface
        /// </summary>
        [EnumValueNameAttribute("hookload (average)")]
        public static RealtimeData HookloadAverage
        {
            get 
            {
                if (hookloadAverage == null)
                {
                    hookloadAverage = new RealtimeData("hookload (average)");
                    hookloadAverage.Description = "Hookload, average, measured at surface";
                }
                return hookloadAverage;
            }
        }

        private static RealtimeData hookloadMinimum;
        /// <summary>
        /// Minimum hookload while running the stand
        /// </summary>
        [EnumValueNameAttribute("hookload (minimum)")]
        public static RealtimeData HookloadMinimum
        {
            get 
            {
                if (hookloadMinimum == null)
                {
                    hookloadMinimum = new RealtimeData("hookload (minimum)");
                    hookloadMinimum.Description = "Minimum hookload while running the stand";
                }
                return hookloadMinimum;
            }
        }

        private static RealtimeData hookloadMaximum;
        /// <summary>
        /// Hookload, maximum measured at surface
        /// </summary>
        [EnumValueNameAttribute("hookload (maximum)")]
        public static RealtimeData HookloadMaximum
        {
            get 
            {
                if (hookloadMaximum == null)
                {
                    hookloadMaximum = new RealtimeData("hookload (maximum)");
                    hookloadMaximum.Description = "Hookload, maximum measured at surface";
                }
                return hookloadMaximum;
            }
        }

        private static RealtimeData mwdMagnetometerXCorrected;
        /// <summary>
        /// X axis magnetic corrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer X (corrected)")]
        public static RealtimeData MwdMagnetometerXCorrected
        {
            get 
            {
                if (mwdMagnetometerXCorrected == null)
                {
                    mwdMagnetometerXCorrected = new RealtimeData("MWD magnetometer X (corrected)");
                    mwdMagnetometerXCorrected.Description = "X axis magnetic corrected";
                }
                return mwdMagnetometerXCorrected;
            }
        }

        private static RealtimeData mwdMagnetometerXRaw;
        /// <summary>
        /// X axis magnetic uncorrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer X (raw)")]
        public static RealtimeData MwdMagnetometerXRaw
        {
            get 
            {
                if (mwdMagnetometerXRaw == null)
                {
                    mwdMagnetometerXRaw = new RealtimeData("MWD magnetometer X (raw)");
                    mwdMagnetometerXRaw.Description = "X axis magnetic uncorrected";
                }
                return mwdMagnetometerXRaw;
            }
        }

        private static RealtimeData mwdMagnetometerYCorrected;
        /// <summary>
        /// Y axis magnetic corrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Y (corrected)")]
        public static RealtimeData MwdMagnetometerYCorrected
        {
            get 
            {
                if (mwdMagnetometerYCorrected == null)
                {
                    mwdMagnetometerYCorrected = new RealtimeData("MWD magnetometer Y (corrected)");
                    mwdMagnetometerYCorrected.Description = "Y axis magnetic corrected";
                }
                return mwdMagnetometerYCorrected;
            }
        }

        private static RealtimeData mwdMagnetometerYRaw;
        /// <summary>
        /// Y axis magnetic uncorrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Y (raw)")]
        public static RealtimeData MwdMagnetometerYRaw
        {
            get 
            {
                if (mwdMagnetometerYRaw == null)
                {
                    mwdMagnetometerYRaw = new RealtimeData("MWD magnetometer Y (raw)");
                    mwdMagnetometerYRaw.Description = "Y axis magnetic uncorrected";
                }
                return mwdMagnetometerYRaw;
            }
        }

        private static RealtimeData mwdMagnetometerZCorrected;
        /// <summary>
        /// Z axis magnetic corrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Z (corrected)")]
        public static RealtimeData MwdMagnetometerZCorrected
        {
            get 
            {
                if (mwdMagnetometerZCorrected == null)
                {
                    mwdMagnetometerZCorrected = new RealtimeData("MWD magnetometer Z (corrected)");
                    mwdMagnetometerZCorrected.Description = "Z axis magnetic corrected";
                }
                return mwdMagnetometerZCorrected;
            }
        }

        private static RealtimeData mwdMagnetometerZRaw;
        /// <summary>
        /// Z axis magnetic uncorrected
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Z (raw)")]
        public static RealtimeData MwdMagnetometerZRaw
        {
            get 
            {
                if (mwdMagnetometerZRaw == null)
                {
                    mwdMagnetometerZRaw = new RealtimeData("MWD magnetometer Z (raw)");
                    mwdMagnetometerZRaw.Description = "Z axis magnetic uncorrected";
                }
                return mwdMagnetometerZRaw;
            }
        }

        private static RealtimeData isobutane;
        /// <summary>
        /// iso-Butane (iC4) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-butane")]
        public static RealtimeData Isobutane
        {
            get 
            {
                if (isobutane == null)
                {
                    isobutane = new RealtimeData("iso-butane");
                    isobutane.Description = "iso-Butane (iC4) ppm (cycle-based)";
                }
                return isobutane;
            }
        }

        private static RealtimeData isobutaneAverage;
        /// <summary>
        /// iso-Butane (iC4) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("iso-butane (average)")]
        public static RealtimeData IsobutaneAverage
        {
            get 
            {
                if (isobutaneAverage == null)
                {
                    isobutaneAverage = new RealtimeData("iso-butane (average)");
                    isobutaneAverage.Description = "iso-Butane (iC4) ppm (average)";
                }
                return isobutaneAverage;
            }
        }

        private static RealtimeData isobutaneMinimum;
        /// <summary>
        /// iso-Butane (iC4) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("iso-butane (minimum)")]
        public static RealtimeData IsobutaneMinimum
        {
            get 
            {
                if (isobutaneMinimum == null)
                {
                    isobutaneMinimum = new RealtimeData("iso-butane (minimum)");
                    isobutaneMinimum.Description = "iso-Butane (iC4) ppm (min)";
                }
                return isobutaneMinimum;
            }
        }

        private static RealtimeData isobutaneMaximum;
        /// <summary>
        /// iso-Butane (iC4) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("iso-butane (maximum)")]
        public static RealtimeData IsobutaneMaximum
        {
            get 
            {
                if (isobutaneMaximum == null)
                {
                    isobutaneMaximum = new RealtimeData("iso-butane (maximum)");
                    isobutaneMaximum.Description = "iso-Butane (iC4) ppm (max)";
                }
                return isobutaneMaximum;
            }
        }

        private static RealtimeData isohexane;
        /// <summary>
        /// iso-Hexane (iC6) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane")]
        public static RealtimeData Isohexane
        {
            get 
            {
                if (isohexane == null)
                {
                    isohexane = new RealtimeData("iso-hexane");
                    isohexane.Description = "iso-Hexane (iC6) ppm (cycle-based)";
                }
                return isohexane;
            }
        }

        private static RealtimeData isohexaneAverage;
        /// <summary>
        /// iso-Hexane (iC6) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (average)")]
        public static RealtimeData IsohexaneAverage
        {
            get 
            {
                if (isohexaneAverage == null)
                {
                    isohexaneAverage = new RealtimeData("iso-hexane (average)");
                    isohexaneAverage.Description = "iso-Hexane (iC6) ppm (average)";
                }
                return isohexaneAverage;
            }
        }

        private static RealtimeData isohexaneMinimum;
        /// <summary>
        /// iso-Hexane (iC6) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (minimum)")]
        public static RealtimeData IsohexaneMinimum
        {
            get 
            {
                if (isohexaneMinimum == null)
                {
                    isohexaneMinimum = new RealtimeData("iso-hexane (minimum)");
                    isohexaneMinimum.Description = "iso-Hexane (iC6) ppm (min)";
                }
                return isohexaneMinimum;
            }
        }

        private static RealtimeData isohexaneMaximum;
        /// <summary>
        /// iso-Hexane (iC6) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (maximum)")]
        public static RealtimeData IsohexaneMaximum
        {
            get 
            {
                if (isohexaneMaximum == null)
                {
                    isohexaneMaximum = new RealtimeData("iso-hexane (maximum)");
                    isohexaneMaximum.Description = "iso-Hexane (iC6) ppm (max)";
                }
                return isohexaneMaximum;
            }
        }

        private static RealtimeData inclinationCorrected;
        /// <summary>
        /// MWD inclination (corrected)
        /// </summary>
        [EnumValueNameAttribute("inclination (corrected)")]
        public static RealtimeData InclinationCorrected
        {
            get 
            {
                if (inclinationCorrected == null)
                {
                    inclinationCorrected = new RealtimeData("inclination (corrected)");
                    inclinationCorrected.Description = "MWD inclination (corrected)";
                }
                return inclinationCorrected;
            }
        }

        private static RealtimeData inclinationNearBit;
        /// <summary>
        /// Near-bit inclination
        /// </summary>
        [EnumValueNameAttribute("inclination near bit")]
        public static RealtimeData InclinationNearBit
        {
            get 
            {
                if (inclinationNearBit == null)
                {
                    inclinationNearBit = new RealtimeData("inclination near bit");
                    inclinationNearBit.Description = "Near-bit inclination";
                }
                return inclinationNearBit;
            }
        }

        private static RealtimeData inclinationUncorrected;
        /// <summary>
        /// MWD inclination (uncorrected)
        /// </summary>
        [EnumValueNameAttribute("inclination (uncorrected)")]
        public static RealtimeData InclinationUncorrected
        {
            get 
            {
                if (inclinationUncorrected == null)
                {
                    inclinationUncorrected = new RealtimeData("inclination (uncorrected)");
                    inclinationUncorrected.Description = "MWD inclination (uncorrected)";
                }
                return inclinationUncorrected;
            }
        }

        private static RealtimeData isopentane;
        /// <summary>
        /// iso-Pentane (iC5) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane")]
        public static RealtimeData Isopentane
        {
            get 
            {
                if (isopentane == null)
                {
                    isopentane = new RealtimeData("iso-pentane");
                    isopentane.Description = "iso-Pentane (iC5) ppm (cycle-based)";
                }
                return isopentane;
            }
        }

        private static RealtimeData isopentaneAverage;
        /// <summary>
        /// iso-Pentane (iC5) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (average)")]
        public static RealtimeData IsopentaneAverage
        {
            get 
            {
                if (isopentaneAverage == null)
                {
                    isopentaneAverage = new RealtimeData("iso-pentane (average)");
                    isopentaneAverage.Description = "iso-Pentane (iC5) ppm (average)";
                }
                return isopentaneAverage;
            }
        }

        private static RealtimeData isopentaneMinimum;
        /// <summary>
        /// iso-Pentane (iC5) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (minimum)")]
        public static RealtimeData IsopentaneMinimum
        {
            get 
            {
                if (isopentaneMinimum == null)
                {
                    isopentaneMinimum = new RealtimeData("iso-pentane (minimum)");
                    isopentaneMinimum.Description = "iso-Pentane (iC5) ppm (min)";
                }
                return isopentaneMinimum;
            }
        }

        private static RealtimeData isopentaneMaximum;
        /// <summary>
        /// iso-Pentane (iC5) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (maximum)")]
        public static RealtimeData IsopentaneMaximum
        {
            get 
            {
                if (isopentaneMaximum == null)
                {
                    isopentaneMaximum = new RealtimeData("iso-pentane (maximum)");
                    isopentaneMaximum.Description = "iso-Pentane (iC5) ppm (max)";
                }
                return isopentaneMaximum;
            }
        }

        private static RealtimeData kickTolerance;
        /// <summary>
        /// Kick tolerance
        /// </summary>
        [EnumValueNameAttribute("kick tolerance")]
        public static RealtimeData KickTolerance
        {
            get 
            {
                if (kickTolerance == null)
                {
                    kickTolerance = new RealtimeData("kick tolerance");
                    kickTolerance.Description = "Kick tolerance";
                }
                return kickTolerance;
            }
        }

        private static RealtimeData lithologyFlag;
        /// <summary>
        /// Lithology flag
        /// </summary>
        [EnumValueNameAttribute("lithology flag")]
        public static RealtimeData LithologyFlag
        {
            get 
            {
                if (lithologyFlag == null)
                {
                    lithologyFlag = new RealtimeData("lithology flag");
                    lithologyFlag.Description = "Lithology flag";
                }
                return lithologyFlag;
            }
        }

        private static RealtimeData mwdAlternatorVoltage;
        /// <summary>
        /// Downhole tool alternator voltage
        /// </summary>
        [EnumValueNameAttribute("MWD alternator voltage")]
        public static RealtimeData MwdAlternatorVoltage
        {
            get 
            {
                if (mwdAlternatorVoltage == null)
                {
                    mwdAlternatorVoltage = new RealtimeData("MWD alternator voltage");
                    mwdAlternatorVoltage.Description = "Downhole tool alternator voltage";
                }
                return mwdAlternatorVoltage;
            }
        }

        private static RealtimeData mwdBottomHoleAnnulusPressure;
        /// <summary>
        /// Bottom hole annulus pressure
        /// </summary>
        [EnumValueNameAttribute("MWD bottom hole annulus pressure")]
        public static RealtimeData MwdBottomHoleAnnulusPressure
        {
            get 
            {
                if (mwdBottomHoleAnnulusPressure == null)
                {
                    mwdBottomHoleAnnulusPressure = new RealtimeData("MWD bottom hole annulus pressure");
                    mwdBottomHoleAnnulusPressure.Description = "Bottom hole annulus pressure";
                }
                return mwdBottomHoleAnnulusPressure;
            }
        }

        private static RealtimeData mwdBottomHoleInternalPressure;
        /// <summary>
        /// Bottom hole internal pressure
        /// </summary>
        [EnumValueNameAttribute("MWD bottom hole internal pressure")]
        public static RealtimeData MwdBottomHoleInternalPressure
        {
            get 
            {
                if (mwdBottomHoleInternalPressure == null)
                {
                    mwdBottomHoleInternalPressure = new RealtimeData("MWD bottom hole internal pressure");
                    mwdBottomHoleInternalPressure.Description = "Bottom hole internal pressure";
                }
                return mwdBottomHoleInternalPressure;
            }
        }

        private static RealtimeData bitTotalMeasuredDepth;
        /// <summary>
        /// Total (measured) depth of bit
        /// </summary>
        [EnumValueNameAttribute("bit total measured depth")]
        public static RealtimeData BitTotalMeasuredDepth
        {
            get 
            {
                if (bitTotalMeasuredDepth == null)
                {
                    bitTotalMeasuredDepth = new RealtimeData("bit total measured depth");
                    bitTotalMeasuredDepth.Description = "Total (measured) depth of bit";
                }
                return bitTotalMeasuredDepth;
            }
        }

        private static RealtimeData mwdConductivity;
        /// <summary>
        /// Mud conductivity
        /// </summary>
        [EnumValueNameAttribute("MWD conductivity")]
        public static RealtimeData MwdConductivity
        {
            get 
            {
                if (mwdConductivity == null)
                {
                    mwdConductivity = new RealtimeData("MWD conductivity");
                    mwdConductivity.Description = "Mud conductivity";
                }
                return mwdConductivity;
            }
        }

        private static RealtimeData measuredDepthOfCasing;
        /// <summary>
        /// Measured depth of casing in the cementing 
        /// </summary>
        [EnumValueNameAttribute("measured depth of casing")]
        public static RealtimeData MeasuredDepthOfCasing
        {
            get 
            {
                if (measuredDepthOfCasing == null)
                {
                    measuredDepthOfCasing = new RealtimeData("measured depth of casing");
                    measuredDepthOfCasing.Description = "Measured depth of casing in the cementing ";
                }
                return measuredDepthOfCasing;
            }
        }

        private static RealtimeData measuredDepthOfDstBottom;
        /// <summary>
        /// Depth (measured) of bottom of DST interval
        /// </summary>
        [EnumValueNameAttribute("measured depth of DST bottom")]
        public static RealtimeData MeasuredDepthOfDstBottom
        {
            get 
            {
                if (measuredDepthOfDstBottom == null)
                {
                    measuredDepthOfDstBottom = new RealtimeData("measured depth of DST bottom");
                    measuredDepthOfDstBottom.Description = "Depth (measured) of bottom of DST interval";
                }
                return measuredDepthOfDstBottom;
            }
        }

        private static RealtimeData measuredDepthOfDstTop;
        /// <summary>
        /// Depth (measured) of top of DST interval
        /// </summary>
        [EnumValueNameAttribute("measured depth of DST top")]
        public static RealtimeData MeasuredDepthOfDstTop
        {
            get 
            {
                if (measuredDepthOfDstTop == null)
                {
                    measuredDepthOfDstTop = new RealtimeData("measured depth of DST top");
                    measuredDepthOfDstTop.Description = "Depth (measured) of top of DST interval";
                }
                return measuredDepthOfDstTop;
            }
        }

        private static RealtimeData measuredDepthOfDiverterTool;
        /// <summary>
        /// Cementing depth to DV tool
        /// </summary>
        [EnumValueNameAttribute("measured depth of diverter tool")]
        public static RealtimeData MeasuredDepthOfDiverterTool
        {
            get 
            {
                if (measuredDepthOfDiverterTool == null)
                {
                    measuredDepthOfDiverterTool = new RealtimeData("measured depth of diverter tool");
                    measuredDepthOfDiverterTool.Description = "Cementing depth to DV tool";
                }
                return measuredDepthOfDiverterTool;
            }
        }

        private static RealtimeData measuredDepthOfHole;
        /// <summary>
        /// Total (measured) depth of hole
        /// </summary>
        [EnumValueNameAttribute("measured depth of hole")]
        public static RealtimeData MeasuredDepthOfHole
        {
            get 
            {
                if (measuredDepthOfHole == null)
                {
                    measuredDepthOfHole = new RealtimeData("measured depth of hole");
                    measuredDepthOfHole.Description = "Total (measured) depth of hole";
                }
                return measuredDepthOfHole;
            }
        }

        private static RealtimeData measuredDepthOfReturns;
        /// <summary>
        /// Depth of cuttings returns
        /// </summary>
        [EnumValueNameAttribute("measured depth of returns")]
        public static RealtimeData MeasuredDepthOfReturns
        {
            get 
            {
                if (measuredDepthOfReturns == null)
                {
                    measuredDepthOfReturns = new RealtimeData("measured depth of returns");
                    measuredDepthOfReturns.Description = "Depth of cuttings returns";
                }
                return measuredDepthOfReturns;
            }
        }

        private static RealtimeData methane;
        /// <summary>
        /// Methane (C1) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("methane")]
        public static RealtimeData Methane
        {
            get 
            {
                if (methane == null)
                {
                    methane = new RealtimeData("methane");
                    methane.Description = "Methane (C1) ppm (cycle-based)";
                }
                return methane;
            }
        }

        private static RealtimeData methaneAverage;
        /// <summary>
        /// Methane (C1) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("methane (average)")]
        public static RealtimeData MethaneAverage
        {
            get 
            {
                if (methaneAverage == null)
                {
                    methaneAverage = new RealtimeData("methane (average)");
                    methaneAverage.Description = "Methane (C1) ppm (average)";
                }
                return methaneAverage;
            }
        }

        private static RealtimeData methaneMinimum;
        /// <summary>
        /// Methane (C1) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("methane (minimum)")]
        public static RealtimeData MethaneMinimum
        {
            get 
            {
                if (methaneMinimum == null)
                {
                    methaneMinimum = new RealtimeData("methane (minimum)");
                    methaneMinimum.Description = "Methane (C1) ppm (min)";
                }
                return methaneMinimum;
            }
        }

        private static RealtimeData methaneMaximum;
        /// <summary>
        /// Methane (C1) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("methane (maximum)")]
        public static RealtimeData MethaneMaximum
        {
            get 
            {
                if (methaneMaximum == null)
                {
                    methaneMaximum = new RealtimeData("methane (maximum)");
                    methaneMaximum.Description = "Methane (C1) ppm (max)";
                }
                return methaneMaximum;
            }
        }

        private static RealtimeData mwdDerivedFracturePressureGradient;
        /// <summary>
        /// Fracture pressure gradient from MWD
        /// </summary>
        [EnumValueNameAttribute("MWD derived fracture pressure gradient")]
        public static RealtimeData MwdDerivedFracturePressureGradient
        {
            get 
            {
                if (mwdDerivedFracturePressureGradient == null)
                {
                    mwdDerivedFracturePressureGradient = new RealtimeData("MWD derived fracture pressure gradient");
                    mwdDerivedFracturePressureGradient.Description = "Fracture pressure gradient from MWD";
                }
                return mwdDerivedFracturePressureGradient;
            }
        }

        private static RealtimeData mwdDerivedPorePressureGradient;
        /// <summary>
        /// Pore Pressure gradient from MWD
        /// </summary>
        [EnumValueNameAttribute("MWD derived pore pressure gradient")]
        public static RealtimeData MwdDerivedPorePressureGradient
        {
            get 
            {
                if (mwdDerivedPorePressureGradient == null)
                {
                    mwdDerivedPorePressureGradient = new RealtimeData("MWD derived pore pressure gradient");
                    mwdDerivedPorePressureGradient.Description = "Pore Pressure gradient from MWD";
                }
                return mwdDerivedPorePressureGradient;
            }
        }

        private static RealtimeData mwdFluidResistivityInAnnulus;
        /// <summary>
        /// Downhole fluid resistivity in annulus
        /// </summary>
        [EnumValueNameAttribute("MWD fluid resistivity in annulus")]
        public static RealtimeData MwdFluidResistivityInAnnulus
        {
            get 
            {
                if (mwdFluidResistivityInAnnulus == null)
                {
                    mwdFluidResistivityInAnnulus = new RealtimeData("MWD fluid resistivity in annulus");
                    mwdFluidResistivityInAnnulus.Description = "Downhole fluid resistivity in annulus";
                }
                return mwdFluidResistivityInAnnulus;
            }
        }

        private static RealtimeData mwdFluidResistivityInPipe;
        /// <summary>
        /// Downhole fluid resistivity in pipe
        /// </summary>
        [EnumValueNameAttribute("MWD fluid resistivity in pipe")]
        public static RealtimeData MwdFluidResistivityInPipe
        {
            get 
            {
                if (mwdFluidResistivityInPipe == null)
                {
                    mwdFluidResistivityInPipe = new RealtimeData("MWD fluid resistivity in pipe");
                    mwdFluidResistivityInPipe.Description = "Downhole fluid resistivity in pipe";
                }
                return mwdFluidResistivityInPipe;
            }
        }

        private static RealtimeData mwdFluidTemperatureInAnnulus;
        /// <summary>
        /// Downhole fluid temperature in annulus
        /// </summary>
        [EnumValueNameAttribute("MWD fluid temperature in annulus")]
        public static RealtimeData MwdFluidTemperatureInAnnulus
        {
            get 
            {
                if (mwdFluidTemperatureInAnnulus == null)
                {
                    mwdFluidTemperatureInAnnulus = new RealtimeData("MWD fluid temperature in annulus");
                    mwdFluidTemperatureInAnnulus.Description = "Downhole fluid temperature in annulus";
                }
                return mwdFluidTemperatureInAnnulus;
            }
        }

        private static RealtimeData mwdFluidTemperatureInPipe;
        /// <summary>
        /// Downhole fluid temperature in pipe
        /// </summary>
        [EnumValueNameAttribute("MWD fluid temperature in pipe")]
        public static RealtimeData MwdFluidTemperatureInPipe
        {
            get 
            {
                if (mwdFluidTemperatureInPipe == null)
                {
                    mwdFluidTemperatureInPipe = new RealtimeData("MWD fluid temperature in pipe");
                    mwdFluidTemperatureInPipe.Description = "Downhole fluid temperature in pipe";
                }
                return mwdFluidTemperatureInPipe;
            }
        }

        private static RealtimeData mwdGammaRay;
        /// <summary>
        /// Measured gamma ray value
        /// </summary>
        [EnumValueNameAttribute("MWD gamma ray")]
        public static RealtimeData MwdGammaRay
        {
            get 
            {
                if (mwdGammaRay == null)
                {
                    mwdGammaRay = new RealtimeData("MWD gamma ray");
                    mwdGammaRay.Description = "Measured gamma ray value";
                }
                return mwdGammaRay;
            }
        }

        private static RealtimeData mwdGammaRayCorrected;
        /// <summary>
        /// Borehole corrected gamma ray value
        /// </summary>
        [EnumValueNameAttribute("MWD gamma ray (corrected)")]
        public static RealtimeData MwdGammaRayCorrected
        {
            get 
            {
                if (mwdGammaRayCorrected == null)
                {
                    mwdGammaRayCorrected = new RealtimeData("MWD gamma ray (corrected)");
                    mwdGammaRayCorrected.Description = "Borehole corrected gamma ray value";
                }
                return mwdGammaRayCorrected;
            }
        }

        private static RealtimeData mwdMotorSpeed;
        /// <summary>
        /// Downhole motor RPM
        /// </summary>
        [EnumValueNameAttribute("MWD motor speed")]
        public static RealtimeData MwdMotorSpeed
        {
            get 
            {
                if (mwdMotorSpeed == null)
                {
                    mwdMotorSpeed = new RealtimeData("MWD motor speed");
                    mwdMotorSpeed.Description = "Downhole motor RPM";
                }
                return mwdMotorSpeed;
            }
        }

        private static RealtimeData mwdResistivity;
        /// <summary>
        /// Measured resistivity value
        /// </summary>
        [EnumValueNameAttribute("MWD resistivity")]
        public static RealtimeData MwdResistivity
        {
            get 
            {
                if (mwdResistivity == null)
                {
                    mwdResistivity = new RealtimeData("MWD resistivity");
                    mwdResistivity.Description = "Measured resistivity value";
                }
                return mwdResistivity;
            }
        }

        private static RealtimeData mwdResistivityCorrected;
        /// <summary>
        /// Borehole corrected resistivity value
        /// </summary>
        [EnumValueNameAttribute("MWD resistivity (corrected)")]
        public static RealtimeData MwdResistivityCorrected
        {
            get 
            {
                if (mwdResistivityCorrected == null)
                {
                    mwdResistivityCorrected = new RealtimeData("MWD resistivity (corrected)");
                    mwdResistivityCorrected.Description = "Borehole corrected resistivity value";
                }
                return mwdResistivityCorrected;
            }
        }

        private static RealtimeData magneticToolFace;
        /// <summary>
        /// MWD magnetic tool face
        /// </summary>
        [EnumValueNameAttribute("magnetic tool face")]
        public static RealtimeData MagneticToolFace
        {
            get 
            {
                if (magneticToolFace == null)
                {
                    magneticToolFace = new RealtimeData("magnetic tool face");
                    magneticToolFace.Description = "MWD magnetic tool face";
                }
                return magneticToolFace;
            }
        }

        private static RealtimeData mwdTorqueAverage;
        /// <summary>
        /// Downhole torque (average)
        /// </summary>
        [EnumValueNameAttribute("MWD torque (average)")]
        public static RealtimeData MwdTorqueAverage
        {
            get 
            {
                if (mwdTorqueAverage == null)
                {
                    mwdTorqueAverage = new RealtimeData("MWD torque (average)");
                    mwdTorqueAverage.Description = "Downhole torque (average)";
                }
                return mwdTorqueAverage;
            }
        }

        private static RealtimeData mwdTorqueMaximum;
        /// <summary>
        /// Downhole torque (maximum)
        /// </summary>
        [EnumValueNameAttribute("MWD torque (maximum)")]
        public static RealtimeData MwdTorqueMaximum
        {
            get 
            {
                if (mwdTorqueMaximum == null)
                {
                    mwdTorqueMaximum = new RealtimeData("MWD torque (maximum)");
                    mwdTorqueMaximum.Description = "Downhole torque (maximum)";
                }
                return mwdTorqueMaximum;
            }
        }

        private static RealtimeData mwdAxialVibration;
        /// <summary>
        /// Downhole vibration in axial direction
        /// </summary>
        [EnumValueNameAttribute("MWD axial vibration")]
        public static RealtimeData MwdAxialVibration
        {
            get 
            {
                if (mwdAxialVibration == null)
                {
                    mwdAxialVibration = new RealtimeData("MWD axial vibration");
                    mwdAxialVibration.Description = "Downhole vibration in axial direction";
                }
                return mwdAxialVibration;
            }
        }

        private static RealtimeData mwdLateralVibration;
        /// <summary>
        /// Downhole vibration in lateral direction
        /// </summary>
        [EnumValueNameAttribute("MWD lateral vibration")]
        public static RealtimeData MwdLateralVibration
        {
            get 
            {
                if (mwdLateralVibration == null)
                {
                    mwdLateralVibration = new RealtimeData("MWD lateral vibration");
                    mwdLateralVibration.Description = "Downhole vibration in lateral direction";
                }
                return mwdLateralVibration;
            }
        }

        private static RealtimeData mwdTorsionalVibration;
        /// <summary>
        /// Downhole vibration in torsional direction
        /// </summary>
        [EnumValueNameAttribute("MWD torsional vibration")]
        public static RealtimeData MwdTorsionalVibration
        {
            get 
            {
                if (mwdTorsionalVibration == null)
                {
                    mwdTorsionalVibration = new RealtimeData("MWD torsional vibration");
                    mwdTorsionalVibration.Description = "Downhole vibration in torsional direction";
                }
                return mwdTorsionalVibration;
            }
        }

        private static RealtimeData mwdWeightOnBitAverage;
        /// <summary>
        /// Downhole weight on bit (average)
        /// </summary>
        [EnumValueNameAttribute("MWD weight on bit (average)")]
        public static RealtimeData MwdWeightOnBitAverage
        {
            get 
            {
                if (mwdWeightOnBitAverage == null)
                {
                    mwdWeightOnBitAverage = new RealtimeData("MWD weight on bit (average)");
                    mwdWeightOnBitAverage.Description = "Downhole weight on bit (average)";
                }
                return mwdWeightOnBitAverage;
            }
        }

        private static RealtimeData mwdWeightOnBitMaximum;
        /// <summary>
        /// Downhole weight on bit (maximum)
        /// </summary>
        [EnumValueNameAttribute("MWD weight on bit (maximum)")]
        public static RealtimeData MwdWeightOnBitMaximum
        {
            get 
            {
                if (mwdWeightOnBitMaximum == null)
                {
                    mwdWeightOnBitMaximum = new RealtimeData("MWD weight on bit (maximum)");
                    mwdWeightOnBitMaximum.Description = "Downhole weight on bit (maximum)";
                }
                return mwdWeightOnBitMaximum;
            }
        }

        private static RealtimeData norbutane;
        /// <summary>
        /// nor-Butane (nC4) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-butane")]
        public static RealtimeData Norbutane
        {
            get 
            {
                if (norbutane == null)
                {
                    norbutane = new RealtimeData("nor-butane");
                    norbutane.Description = "nor-Butane (nC4) ppm (cycle-based)";
                }
                return norbutane;
            }
        }

        private static RealtimeData norbutaneAverage;
        /// <summary>
        /// nor-Butane (nC4) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("nor-butane (average)")]
        public static RealtimeData NorbutaneAverage
        {
            get 
            {
                if (norbutaneAverage == null)
                {
                    norbutaneAverage = new RealtimeData("nor-butane (average)");
                    norbutaneAverage.Description = "nor-Butane (nC4) ppm (average)";
                }
                return norbutaneAverage;
            }
        }

        private static RealtimeData norbutaneMinimum;
        /// <summary>
        /// nor-Butane (nC4) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("nor-butane (minimum)")]
        public static RealtimeData NorbutaneMinimum
        {
            get 
            {
                if (norbutaneMinimum == null)
                {
                    norbutaneMinimum = new RealtimeData("nor-butane (minimum)");
                    norbutaneMinimum.Description = "nor-Butane (nC4) ppm (min)";
                }
                return norbutaneMinimum;
            }
        }

        private static RealtimeData norbutaneMaximum;
        /// <summary>
        /// nor-Butane (nC4) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("nor-butane (maximum)")]
        public static RealtimeData NorbutaneMaximum
        {
            get 
            {
                if (norbutaneMaximum == null)
                {
                    norbutaneMaximum = new RealtimeData("nor-butane (maximum)");
                    norbutaneMaximum.Description = "nor-Butane (nC4) ppm (max)";
                }
                return norbutaneMaximum;
            }
        }

        private static RealtimeData neutronDensity;
        /// <summary>
        /// Neutron density
        /// </summary>
        [EnumValueNameAttribute("neutron density")]
        public static RealtimeData NeutronDensity
        {
            get 
            {
                if (neutronDensity == null)
                {
                    neutronDensity = new RealtimeData("neutron density");
                    neutronDensity.Description = "Neutron density";
                }
                return neutronDensity;
            }
        }

        private static RealtimeData norhexane;
        /// <summary>
        /// nor-Hexane (nC6) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane")]
        public static RealtimeData Norhexane
        {
            get 
            {
                if (norhexane == null)
                {
                    norhexane = new RealtimeData("nor-hexane");
                    norhexane.Description = "nor-Hexane (nC6) ppm (cycle-based)";
                }
                return norhexane;
            }
        }

        private static RealtimeData norhexaneAverage;
        /// <summary>
        /// nor-Hexane (nC6) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (average)")]
        public static RealtimeData NorhexaneAverage
        {
            get 
            {
                if (norhexaneAverage == null)
                {
                    norhexaneAverage = new RealtimeData("nor-hexane (average)");
                    norhexaneAverage.Description = "nor-Hexane (nC6) ppm (average)";
                }
                return norhexaneAverage;
            }
        }

        private static RealtimeData norhexaneMinimum;
        /// <summary>
        /// nor-Hexane (nC6) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (minimum)")]
        public static RealtimeData NorhexaneMinimum
        {
            get 
            {
                if (norhexaneMinimum == null)
                {
                    norhexaneMinimum = new RealtimeData("nor-hexane (minimum)");
                    norhexaneMinimum.Description = "nor-Hexane (nC6) ppm (min)";
                }
                return norhexaneMinimum;
            }
        }

        private static RealtimeData norhexaneMaximum;
        /// <summary>
        /// nor-Hexane (nC6) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (maximum)")]
        public static RealtimeData NorhexaneMaximum
        {
            get 
            {
                if (norhexaneMaximum == null)
                {
                    norhexaneMaximum = new RealtimeData("nor-hexane (maximum)");
                    norhexaneMaximum.Description = "nor-Hexane (nC6) ppm (max)";
                }
                return norhexaneMaximum;
            }
        }

        private static RealtimeData norpentane;
        /// <summary>
        /// nor-Pentane (nC5) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane")]
        public static RealtimeData Norpentane
        {
            get 
            {
                if (norpentane == null)
                {
                    norpentane = new RealtimeData("nor-pentane");
                    norpentane.Description = "nor-Pentane (nC5) ppm (cycle-based)";
                }
                return norpentane;
            }
        }

        private static RealtimeData norpentaneAverage;
        /// <summary>
        /// nor-Pentane (nC5) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (average)")]
        public static RealtimeData NorpentaneAverage
        {
            get 
            {
                if (norpentaneAverage == null)
                {
                    norpentaneAverage = new RealtimeData("nor-pentane (average)");
                    norpentaneAverage.Description = "nor-Pentane (nC5) ppm (average)";
                }
                return norpentaneAverage;
            }
        }

        private static RealtimeData norpentaneMinimum;
        /// <summary>
        /// nor-Pentane (nC5) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (minimum)")]
        public static RealtimeData NorpentaneMinimum
        {
            get 
            {
                if (norpentaneMinimum == null)
                {
                    norpentaneMinimum = new RealtimeData("nor-pentane (minimum)");
                    norpentaneMinimum.Description = "nor-Pentane (nC5) ppm (min)";
                }
                return norpentaneMinimum;
            }
        }

        private static RealtimeData norpentaneMaximum;
        /// <summary>
        /// nor-Pentane (nC5) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (maximum)")]
        public static RealtimeData NorpentaneMaximum
        {
            get 
            {
                if (norpentaneMaximum == null)
                {
                    norpentaneMaximum = new RealtimeData("nor-pentane (maximum)");
                    norpentaneMaximum.Description = "nor-Pentane (nC5) ppm (max)";
                }
                return norpentaneMaximum;
            }
        }

        private static RealtimeData neutronPorosity;
        /// <summary>
        /// Neutron porosity
        /// </summary>
        [EnumValueNameAttribute("neutron porosity")]
        public static RealtimeData NeutronPorosity
        {
            get 
            {
                if (neutronPorosity == null)
                {
                    neutronPorosity = new RealtimeData("neutron porosity");
                    neutronPorosity.Description = "Neutron porosity";
                }
                return neutronPorosity;
            }
        }

        private static RealtimeData neutronPorosityCorrected;
        /// <summary>
        /// Neutron porosity corrected
        /// </summary>
        [EnumValueNameAttribute("neutron porosity (corrected)")]
        public static RealtimeData NeutronPorosityCorrected
        {
            get 
            {
                if (neutronPorosityCorrected == null)
                {
                    neutronPorosityCorrected = new RealtimeData("neutron porosity (corrected)");
                    neutronPorosityCorrected.Description = "Neutron porosity corrected";
                }
                return neutronPorosityCorrected;
            }
        }

        private static RealtimeData neutronPorosityRatio;
        /// <summary>
        /// Neutron porosity ratio
        /// </summary>
        [EnumValueNameAttribute("neutron porosity ratio")]
        public static RealtimeData NeutronPorosityRatio
        {
            get 
            {
                if (neutronPorosityRatio == null)
                {
                    neutronPorosityRatio = new RealtimeData("neutron porosity ratio");
                    neutronPorosityRatio.Description = "Neutron porosity ratio";
                }
                return neutronPorosityRatio;
            }
        }

        private static RealtimeData passNumber;
        /// <summary>
        /// MWD pass number
        /// </summary>
        [EnumValueNameAttribute("pass number")]
        public static RealtimeData PassNumber
        {
            get 
            {
                if (passNumber == null)
                {
                    passNumber = new RealtimeData("pass number");
                    passNumber.Description = "MWD pass number";
                }
                return passNumber;
            }
        }

        private static RealtimeData tripNumber;
        /// <summary>
        /// Trip number
        /// </summary>
        [EnumValueNameAttribute("trip number")]
        public static RealtimeData TripNumber
        {
            get 
            {
                if (tripNumber == null)
                {
                    tripNumber = new RealtimeData("trip number");
                    tripNumber.Description = "Trip number";
                }
                return tripNumber;
            }
        }

        private static RealtimeData photoelectricEffect;
        /// <summary>
        /// Photoelectric effect
        /// </summary>
        [EnumValueNameAttribute("photoelectric effect")]
        public static RealtimeData PhotoelectricEffect
        {
            get 
            {
                if (photoelectricEffect == null)
                {
                    photoelectricEffect = new RealtimeData("photoelectric effect");
                    photoelectricEffect.Description = "Photoelectric effect";
                }
                return photoelectricEffect;
            }
        }

        private static RealtimeData bitPressureLoss;
        /// <summary>
        /// Bit pressure loss
        /// </summary>
        [EnumValueNameAttribute("bit pressure loss")]
        public static RealtimeData BitPressureLoss
        {
            get 
            {
                if (bitPressureLoss == null)
                {
                    bitPressureLoss = new RealtimeData("bit pressure loss");
                    bitPressureLoss.Description = "Bit pressure loss";
                }
                return bitPressureLoss;
            }
        }

        private static RealtimeData blockPosition;
        /// <summary>
        /// Block position
        /// </summary>
        [EnumValueNameAttribute("block position")]
        public static RealtimeData BlockPosition
        {
            get 
            {
                if (blockPosition == null)
                {
                    blockPosition = new RealtimeData("block position");
                    blockPosition.Description = "Block position";
                }
                return blockPosition;
            }
        }

        private static RealtimeData hydraulicPowerOfBit;
        /// <summary>
        /// Bit hydraulic power
        /// </summary>
        [EnumValueNameAttribute("hydraulic power of bit")]
        public static RealtimeData HydraulicPowerOfBit
        {
            get 
            {
                if (hydraulicPowerOfBit == null)
                {
                    hydraulicPowerOfBit = new RealtimeData("hydraulic power of bit");
                    hydraulicPowerOfBit.Description = "Bit hydraulic power";
                }
                return hydraulicPowerOfBit;
            }
        }

        private static RealtimeData hydraulicPowerPerAreaOfBit;
        /// <summary>
        /// Bit hydraulic power per area
        /// </summary>
        [EnumValueNameAttribute("hydraulic power per area of bit")]
        public static RealtimeData HydraulicPowerPerAreaOfBit
        {
            get 
            {
                if (hydraulicPowerPerAreaOfBit == null)
                {
                    hydraulicPowerPerAreaOfBit = new RealtimeData("hydraulic power per area of bit");
                    hydraulicPowerPerAreaOfBit.Description = "Bit hydraulic power per area";
                }
                return hydraulicPowerPerAreaOfBit;
            }
        }

        private static RealtimeData hydraulicPowerOfPump;
        /// <summary>
        /// Pump hydraulic power
        /// </summary>
        [EnumValueNameAttribute("hydraulic power of pump")]
        public static RealtimeData HydraulicPowerOfPump
        {
            get 
            {
                if (hydraulicPowerOfPump == null)
                {
                    hydraulicPowerOfPump = new RealtimeData("hydraulic power of pump");
                    hydraulicPowerOfPump.Description = "Pump hydraulic power";
                }
                return hydraulicPowerOfPump;
            }
        }

        private static RealtimeData pressureLossAtAnnulus;
        /// <summary>
        /// Annulus pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure loss at annulus")]
        public static RealtimeData PressureLossAtAnnulus
        {
            get 
            {
                if (pressureLossAtAnnulus == null)
                {
                    pressureLossAtAnnulus = new RealtimeData("pressure loss at annulus");
                    pressureLossAtAnnulus.Description = "Annulus pressure loss";
                }
                return pressureLossAtAnnulus;
            }
        }

        private static RealtimeData pressureDropAtBit;
        /// <summary>
        /// pressure drop at the bit
        /// </summary>
        [EnumValueNameAttribute("pressure drop at bit")]
        public static RealtimeData PressureDropAtBit
        {
            get 
            {
                if (pressureDropAtBit == null)
                {
                    pressureDropAtBit = new RealtimeData("pressure drop at bit");
                    pressureDropAtBit.Description = "pressure drop at the bit";
                }
                return pressureDropAtBit;
            }
        }

        private static RealtimeData pressureLossAtBit;
        /// <summary>
        /// Bit pressure loss percentage
        /// </summary>
        [EnumValueNameAttribute("pressure loss at bit")]
        public static RealtimeData PressureLossAtBit
        {
            get 
            {
                if (pressureLossAtBit == null)
                {
                    pressureLossAtBit = new RealtimeData("pressure loss at bit");
                    pressureLossAtBit.Description = "Bit pressure loss percentage";
                }
                return pressureLossAtBit;
            }
        }

        private static RealtimeData pressureDropCalculatedOrObserved;
        /// <summary>
        /// Calculated/observed pressure loss ratio (%)
        /// </summary>
        [EnumValueNameAttribute("pressure drop (calculated or observed)")]
        public static RealtimeData PressureDropCalculatedOrObserved
        {
            get 
            {
                if (pressureDropCalculatedOrObserved == null)
                {
                    pressureDropCalculatedOrObserved = new RealtimeData("pressure drop (calculated or observed)");
                    pressureDropCalculatedOrObserved.Description = "Calculated/observed pressure loss ratio (%)";
                }
                return pressureDropCalculatedOrObserved;
            }
        }

        private static RealtimeData pressureDropAtMotor;
        /// <summary>
        /// Mud motor pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at motor")]
        public static RealtimeData PressureDropAtMotor
        {
            get 
            {
                if (pressureDropAtMotor == null)
                {
                    pressureDropAtMotor = new RealtimeData("pressure drop at motor");
                    pressureDropAtMotor.Description = "Mud motor pressure loss";
                }
                return pressureDropAtMotor;
            }
        }

        private static RealtimeData pressureDropAtMwdTool;
        /// <summary>
        /// MWD tool pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at MWD tool")]
        public static RealtimeData PressureDropAtMwdTool
        {
            get 
            {
                if (pressureDropAtMwdTool == null)
                {
                    pressureDropAtMwdTool = new RealtimeData("pressure drop at MWD tool");
                    pressureDropAtMwdTool.Description = "MWD tool pressure loss";
                }
                return pressureDropAtMwdTool;
            }
        }

        private static RealtimeData pressureDropAtString;
        /// <summary>
        /// Pipe (drillstring) pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at string")]
        public static RealtimeData PressureDropAtString
        {
            get 
            {
                if (pressureDropAtString == null)
                {
                    pressureDropAtString = new RealtimeData("pressure drop at string");
                    pressureDropAtString.Description = "Pipe (drillstring) pressure loss";
                }
                return pressureDropAtString;
            }
        }

        private static RealtimeData pressureDropAtSurface;
        /// <summary>
        /// Surface pressure loss
        /// </summary>
        [EnumValueNameAttribute("pressure drop at surface")]
        public static RealtimeData PressureDropAtSurface
        {
            get 
            {
                if (pressureDropAtSurface == null)
                {
                    pressureDropAtSurface = new RealtimeData("pressure drop at surface");
                    pressureDropAtSurface.Description = "Surface pressure loss";
                }
                return pressureDropAtSurface;
            }
        }

        private static RealtimeData pressureAtMwdTool;
        /// <summary>
        /// Downhole pressure from MWD tool
        /// </summary>
        [EnumValueNameAttribute("pressure at MWD tool")]
        public static RealtimeData PressureAtMwdTool
        {
            get 
            {
                if (pressureAtMwdTool == null)
                {
                    pressureAtMwdTool = new RealtimeData("pressure at MWD tool");
                    pressureAtMwdTool.Description = "Downhole pressure from MWD tool";
                }
                return pressureAtMwdTool;
            }
        }

        private static RealtimeData pressureAtPumpAverage;
        /// <summary>
        /// Pump (standpipe) pressure, measured at surface
        /// </summary>
        [EnumValueNameAttribute("pressure at pump (average)")]
        public static RealtimeData PressureAtPumpAverage
        {
            get 
            {
                if (pressureAtPumpAverage == null)
                {
                    pressureAtPumpAverage = new RealtimeData("pressure at pump (average)");
                    pressureAtPumpAverage.Description = "Pump (standpipe) pressure, measured at surface";
                }
                return pressureAtPumpAverage;
            }
        }

        private static RealtimeData shutinPressureMaximum;
        /// <summary>
        /// Maximum permitted shut-in pressure
        /// </summary>
        [EnumValueNameAttribute("shut-in pressure (maximum)")]
        public static RealtimeData ShutinPressureMaximum
        {
            get 
            {
                if (shutinPressureMaximum == null)
                {
                    shutinPressureMaximum = new RealtimeData("shut-in pressure (maximum)");
                    shutinPressureMaximum.Description = "Maximum permitted shut-in pressure";
                }
                return shutinPressureMaximum;
            }
        }

        private static RealtimeData propane;
        /// <summary>
        /// Propane (C3) ppm (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("propane")]
        public static RealtimeData Propane
        {
            get 
            {
                if (propane == null)
                {
                    propane = new RealtimeData("propane");
                    propane.Description = "Propane (C3) ppm (cycle-based)";
                }
                return propane;
            }
        }

        private static RealtimeData propaneAverage;
        /// <summary>
        /// Propane (C3) ppm (average)
        /// </summary>
        [EnumValueNameAttribute("propane (average)")]
        public static RealtimeData PropaneAverage
        {
            get 
            {
                if (propaneAverage == null)
                {
                    propaneAverage = new RealtimeData("propane (average)");
                    propaneAverage.Description = "Propane (C3) ppm (average)";
                }
                return propaneAverage;
            }
        }

        private static RealtimeData propaneMinimum;
        /// <summary>
        /// Propane (C3) ppm (min)
        /// </summary>
        [EnumValueNameAttribute("propane (minimum)")]
        public static RealtimeData PropaneMinimum
        {
            get 
            {
                if (propaneMinimum == null)
                {
                    propaneMinimum = new RealtimeData("propane (minimum)");
                    propaneMinimum.Description = "Propane (C3) ppm (min)";
                }
                return propaneMinimum;
            }
        }

        private static RealtimeData propaneMaximum;
        /// <summary>
        /// Propane (C3) ppm (max)
        /// </summary>
        [EnumValueNameAttribute("propane (maximum)")]
        public static RealtimeData PropaneMaximum
        {
            get 
            {
                if (propaneMaximum == null)
                {
                    propaneMaximum = new RealtimeData("propane (maximum)");
                    propaneMaximum.Description = "Propane (C3) ppm (max)";
                }
                return propaneMaximum;
            }
        }

        private static RealtimeData plasticViscosity;
        /// <summary>
        /// Mud plastic viscosity
        /// </summary>
        [EnumValueNameAttribute("plastic viscosity")]
        public static RealtimeData PlasticViscosity
        {
            get 
            {
                if (plasticViscosity == null)
                {
                    plasticViscosity = new RealtimeData("plastic viscosity");
                    plasticViscosity.Description = "Mud plastic viscosity";
                }
                return plasticViscosity;
            }
        }

        private static RealtimeData resistivity;
        /// <summary>
        /// Resistivity reading
        /// </summary>
        [EnumValueNameAttribute("resistivity")]
        public static RealtimeData Resistivity
        {
            get 
            {
                if (resistivity == null)
                {
                    resistivity = new RealtimeData("resistivity");
                    resistivity.Description = "Resistivity reading";
                }
                return resistivity;
            }
        }

        private static RealtimeData resistivityCorrected;
        /// <summary>
        /// Resistivity reading (corrected)
        /// </summary>
        [EnumValueNameAttribute("resistivity (corrected)")]
        public static RealtimeData ResistivityCorrected
        {
            get 
            {
                if (resistivityCorrected == null)
                {
                    resistivityCorrected = new RealtimeData("resistivity (corrected)");
                    resistivityCorrected.Description = "Resistivity reading (corrected)";
                }
                return resistivityCorrected;
            }
        }

        private static RealtimeData rateOfPenetrationAverage;
        /// <summary>
        /// Drill Rate
        /// </summary>
        [EnumValueNameAttribute("rate of penetration (average)")]
        public static RealtimeData RateOfPenetrationAverage
        {
            get 
            {
                if (rateOfPenetrationAverage == null)
                {
                    rateOfPenetrationAverage = new RealtimeData("rate of penetration (average)");
                    rateOfPenetrationAverage.Description = "Drill Rate";
                }
                return rateOfPenetrationAverage;
            }
        }

        private static RealtimeData rateOfPenetrationIntantaneous;
        /// <summary>
        /// Rate of Penetration (intantaneous)
        /// </summary>
        [EnumValueNameAttribute("rate of penetration (intantaneous)")]
        public static RealtimeData RateOfPenetrationIntantaneous
        {
            get 
            {
                if (rateOfPenetrationIntantaneous == null)
                {
                    rateOfPenetrationIntantaneous = new RealtimeData("rate of penetration (intantaneous)");
                    rateOfPenetrationIntantaneous.Description = "Rate of Penetration (intantaneous)";
                }
                return rateOfPenetrationIntantaneous;
            }
        }

        private static RealtimeData rotationFlag;
        /// <summary>
        /// Rotation flag = 1 if pipe is rotating, else = 0
        /// </summary>
        [EnumValueNameAttribute("rotation flag")]
        public static RealtimeData RotationFlag
        {
            get 
            {
                if (rotationFlag == null)
                {
                    rotationFlag = new RealtimeData("rotation flag");
                    rotationFlag.Description = "Rotation flag = 1 if pipe is rotating, else = 0";
                }
                return rotationFlag;
            }
        }

        private static RealtimeData rotarySpeedAverage;
        /// <summary>
        /// Rotary speed, measured at surface (revs per minute)
        /// </summary>
        [EnumValueNameAttribute("rotary speed (average)")]
        public static RealtimeData RotarySpeedAverage
        {
            get 
            {
                if (rotarySpeedAverage == null)
                {
                    rotarySpeedAverage = new RealtimeData("rotary speed (average)");
                    rotarySpeedAverage.Description = "Rotary speed, measured at surface (revs per minute)";
                }
                return rotarySpeedAverage;
            }
        }

        private static RealtimeData runningSpeedDownAverage;
        /// <summary>
        /// Trip average running speed, down
        /// </summary>
        [EnumValueNameAttribute("running speed down (average)")]
        public static RealtimeData RunningSpeedDownAverage
        {
            get 
            {
                if (runningSpeedDownAverage == null)
                {
                    runningSpeedDownAverage = new RealtimeData("running speed down (average)");
                    runningSpeedDownAverage.Description = "Trip average running speed, down";
                }
                return runningSpeedDownAverage;
            }
        }

        private static RealtimeData runningSpeedDownMaximum;
        /// <summary>
        /// Trip maximum running speed, down
        /// </summary>
        [EnumValueNameAttribute("running speed down (maximum)")]
        public static RealtimeData RunningSpeedDownMaximum
        {
            get 
            {
                if (runningSpeedDownMaximum == null)
                {
                    runningSpeedDownMaximum = new RealtimeData("running speed down (maximum)");
                    runningSpeedDownMaximum.Description = "Trip maximum running speed, down";
                }
                return runningSpeedDownMaximum;
            }
        }

        private static RealtimeData runningSpeedUpAverage;
        /// <summary>
        /// Trip average running speed, up
        /// </summary>
        [EnumValueNameAttribute("running speed up (average)")]
        public static RealtimeData RunningSpeedUpAverage
        {
            get 
            {
                if (runningSpeedUpAverage == null)
                {
                    runningSpeedUpAverage = new RealtimeData("running speed up (average)");
                    runningSpeedUpAverage.Description = "Trip average running speed, up";
                }
                return runningSpeedUpAverage;
            }
        }

        private static RealtimeData runningSpeedUpMaximum;
        /// <summary>
        /// Trip maximum running speed, up
        /// </summary>
        [EnumValueNameAttribute("running speed up (maximum)")]
        public static RealtimeData RunningSpeedUpMaximum
        {
            get 
            {
                if (runningSpeedUpMaximum == null)
                {
                    runningSpeedUpMaximum = new RealtimeData("running speed up (maximum)");
                    runningSpeedUpMaximum.Description = "Trip maximum running speed, up";
                }
                return runningSpeedUpMaximum;
            }
        }

        private static RealtimeData sonicCoherence;
        /// <summary>
        /// Coherence
        /// </summary>
        [EnumValueNameAttribute("sonic coherence")]
        public static RealtimeData SonicCoherence
        {
            get 
            {
                if (sonicCoherence == null)
                {
                    sonicCoherence = new RealtimeData("sonic coherence");
                    sonicCoherence.Description = "Coherence";
                }
                return sonicCoherence;
            }
        }

        private static RealtimeData sonicDensity;
        /// <summary>
        /// Sonic density
        /// </summary>
        [EnumValueNameAttribute("sonic density")]
        public static RealtimeData SonicDensity
        {
            get 
            {
                if (sonicDensity == null)
                {
                    sonicDensity = new RealtimeData("sonic density");
                    sonicDensity.Description = "Sonic density";
                }
                return sonicDensity;
            }
        }

        private static RealtimeData sonicDeltatimeCorrected;
        /// <summary>
        /// Sonic delta T corrected
        /// </summary>
        [EnumValueNameAttribute("sonic delta-time (corrected)")]
        public static RealtimeData SonicDeltatimeCorrected
        {
            get 
            {
                if (sonicDeltatimeCorrected == null)
                {
                    sonicDeltatimeCorrected = new RealtimeData("sonic delta-time (corrected)");
                    sonicDeltatimeCorrected.Description = "Sonic delta T corrected";
                }
                return sonicDeltatimeCorrected;
            }
        }

        private static RealtimeData sonicDeltatimeUncorrected;
        /// <summary>
        /// Sonic delta T raw reading 
        /// </summary>
        [EnumValueNameAttribute("sonic delta-time (uncorrected)")]
        public static RealtimeData SonicDeltatimeUncorrected
        {
            get 
            {
                if (sonicDeltatimeUncorrected == null)
                {
                    sonicDeltatimeUncorrected = new RealtimeData("sonic delta-time (uncorrected)");
                    sonicDeltatimeUncorrected.Description = "Sonic delta T raw reading ";
                }
                return sonicDeltatimeUncorrected;
            }
        }

        private static RealtimeData sonicPorosity;
        /// <summary>
        /// Sonic porosity
        /// </summary>
        [EnumValueNameAttribute("sonic porosity")]
        public static RealtimeData SonicPorosity
        {
            get 
            {
                if (sonicPorosity == null)
                {
                    sonicPorosity = new RealtimeData("sonic porosity");
                    sonicPorosity.Description = "Sonic porosity";
                }
                return sonicPorosity;
            }
        }

        private static RealtimeData sonicPorosityCorrected;
        /// <summary>
        /// Sonic porosity corrected
        /// </summary>
        [EnumValueNameAttribute("sonic porosity (corrected)")]
        public static RealtimeData SonicPorosityCorrected
        {
            get 
            {
                if (sonicPorosityCorrected == null)
                {
                    sonicPorosityCorrected = new RealtimeData("sonic porosity (corrected)");
                    sonicPorosityCorrected.Description = "Sonic porosity corrected";
                }
                return sonicPorosityCorrected;
            }
        }

        private static RealtimeData strokeRate;
        /// <summary>
        /// Pump stroke rate (strokes/minute)
        /// </summary>
        [EnumValueNameAttribute("stroke rate")]
        public static RealtimeData StrokeRate
        {
            get 
            {
                if (strokeRate == null)
                {
                    strokeRate = new RealtimeData("stroke rate");
                    strokeRate.Description = "Pump stroke rate (strokes/minute)";
                }
                return strokeRate;
            }
        }

        private static RealtimeData strokeRateTotal;
        /// <summary>
        /// Cumulative pump stroke rate (strokes/minute)
        /// </summary>
        [EnumValueNameAttribute("stroke rate total")]
        public static RealtimeData StrokeRateTotal
        {
            get 
            {
                if (strokeRateTotal == null)
                {
                    strokeRateTotal = new RealtimeData("stroke rate total");
                    strokeRateTotal.Description = "Cumulative pump stroke rate (strokes/minute)";
                }
                return strokeRateTotal;
            }
        }

        private static RealtimeData stateOfWell;
        /// <summary>
        /// State of well during DST (SHUT-IN or FLOWING)
        /// </summary>
        [EnumValueNameAttribute("state of well")]
        public static RealtimeData StateOfWell
        {
            get 
            {
                if (stateOfWell == null)
                {
                    stateOfWell = new RealtimeData("state of well");
                    stateOfWell.Description = "State of well during DST (SHUT-IN or FLOWING)";
                }
                return stateOfWell;
            }
        }

        private static RealtimeData inslipsStatus;
        /// <summary>
        /// In-slips status (In or out)
        /// </summary>
        [EnumValueNameAttribute("in-slips status")]
        public static RealtimeData InslipsStatus
        {
            get 
            {
                if (inslipsStatus == null)
                {
                    inslipsStatus = new RealtimeData("in-slips status");
                    inslipsStatus.Description = "In-slips status (In or out)";
                }
                return inslipsStatus;
            }
        }

        private static RealtimeData lagStrokes;
        /// <summary>
        /// Lag strokes
        /// </summary>
        [EnumValueNameAttribute("lag strokes")]
        public static RealtimeData LagStrokes
        {
            get 
            {
                if (lagStrokes == null)
                {
                    lagStrokes = new RealtimeData("lag strokes");
                    lagStrokes.Description = "Lag strokes";
                }
                return lagStrokes;
            }
        }

        private static RealtimeData strokeCountTotal;
        /// <summary>
        /// Cumulative total pump strokes
        /// </summary>
        [EnumValueNameAttribute("stroke count (total)")]
        public static RealtimeData StrokeCountTotal
        {
            get 
            {
                if (strokeCountTotal == null)
                {
                    strokeCountTotal = new RealtimeData("stroke count (total)");
                    strokeCountTotal.Description = "Cumulative total pump strokes";
                }
                return strokeCountTotal;
            }
        }

        private static RealtimeData strokeCount;
        /// <summary>
        /// Pump strokes for each pump
        /// </summary>
        [EnumValueNameAttribute("stroke count")]
        public static RealtimeData StrokeCount
        {
            get 
            {
                if (strokeCount == null)
                {
                    strokeCount = new RealtimeData("stroke count");
                    strokeCount.Description = "Pump strokes for each pump";
                }
                return strokeCount;
            }
        }

        private static RealtimeData mudTemperatureInAverage;
        /// <summary>
        /// Mud temperature going into hole
        /// </summary>
        [EnumValueNameAttribute("mud temperature in (average)")]
        public static RealtimeData MudTemperatureInAverage
        {
            get 
            {
                if (mudTemperatureInAverage == null)
                {
                    mudTemperatureInAverage = new RealtimeData("mud temperature in (average)");
                    mudTemperatureInAverage.Description = "Mud temperature going into hole";
                }
                return mudTemperatureInAverage;
            }
        }

        private static RealtimeData mudTemperatureOutAverage;
        /// <summary>
        /// Mud temperature coming out of the hole
        /// </summary>
        [EnumValueNameAttribute("mud temperature out (average)")]
        public static RealtimeData MudTemperatureOutAverage
        {
            get 
            {
                if (mudTemperatureOutAverage == null)
                {
                    mudTemperatureOutAverage = new RealtimeData("mud temperature out (average)");
                    mudTemperatureOutAverage.Description = "Mud temperature coming out of the hole";
                }
                return mudTemperatureOutAverage;
            }
        }

        private static RealtimeData timeInSlips;
        /// <summary>
        /// Time in slips (seconds)
        /// </summary>
        [EnumValueNameAttribute("time in slips")]
        public static RealtimeData TimeInSlips
        {
            get 
            {
                if (timeInSlips == null)
                {
                    timeInSlips = new RealtimeData("time in slips");
                    timeInSlips.Description = "Time in slips (seconds)";
                }
                return timeInSlips;
            }
        }

        private static RealtimeData timeOutOfSlips;
        /// <summary>
        /// Time out of slips (seconds)
        /// </summary>
        [EnumValueNameAttribute("time out of slips")]
        public static RealtimeData TimeOutOfSlips
        {
            get 
            {
                if (timeOutOfSlips == null)
                {
                    timeOutOfSlips = new RealtimeData("time out of slips");
                    timeOutOfSlips.Description = "Time out of slips (seconds)";
                }
                return timeOutOfSlips;
            }
        }

        private static RealtimeData torqueAverage;
        /// <summary>
        /// Rotary torque, average, measured at surface
        /// </summary>
        [EnumValueNameAttribute("torque (average)")]
        public static RealtimeData TorqueAverage
        {
            get 
            {
                if (torqueAverage == null)
                {
                    torqueAverage = new RealtimeData("torque (average)");
                    torqueAverage.Description = "Rotary torque, average, measured at surface";
                }
                return torqueAverage;
            }
        }

        private static RealtimeData torqueForBreakoutMaximum;
        /// <summary>
        /// Break-out torque
        /// </summary>
        [EnumValueNameAttribute("torque for break-out (maximum)")]
        public static RealtimeData TorqueForBreakoutMaximum
        {
            get 
            {
                if (torqueForBreakoutMaximum == null)
                {
                    torqueForBreakoutMaximum = new RealtimeData("torque for break-out (maximum)");
                    torqueForBreakoutMaximum.Description = "Break-out torque";
                }
                return torqueForBreakoutMaximum;
            }
        }

        private static RealtimeData torqueForMakeupMaximum;
        /// <summary>
        /// Make-up torque
        /// </summary>
        [EnumValueNameAttribute("torque for make-up (maximum)")]
        public static RealtimeData TorqueForMakeupMaximum
        {
            get 
            {
                if (torqueForMakeupMaximum == null)
                {
                    torqueForMakeupMaximum = new RealtimeData("torque for make-up (maximum)");
                    torqueForMakeupMaximum.Description = "Make-up torque";
                }
                return torqueForMakeupMaximum;
            }
        }

        private static RealtimeData torqueMaximum;
        /// <summary>
        /// Rotary torque, maximum, measured at surface
        /// </summary>
        [EnumValueNameAttribute("torque (maximum)")]
        public static RealtimeData TorqueMaximum
        {
            get 
            {
                if (torqueMaximum == null)
                {
                    torqueMaximum = new RealtimeData("torque (maximum)");
                    torqueMaximum.Description = "Rotary torque, maximum, measured at surface";
                }
                return torqueMaximum;
            }
        }

        private static RealtimeData tripTankVolume;
        /// <summary>
        /// Trip tank volume
        /// </summary>
        [EnumValueNameAttribute("trip tank volume")]
        public static RealtimeData TripTankVolume
        {
            get 
            {
                if (tripTankVolume == null)
                {
                    tripTankVolume = new RealtimeData("trip tank volume");
                    tripTankVolume.Description = "Trip tank volume";
                }
                return tripTankVolume;
            }
        }

        private static RealtimeData turnRate;
        /// <summary>
        /// MWD walk/turn rate
        /// </summary>
        [EnumValueNameAttribute("turn rate")]
        public static RealtimeData TurnRate
        {
            get 
            {
                if (turnRate == null)
                {
                    turnRate = new RealtimeData("turn rate");
                    turnRate.Description = "MWD walk/turn rate";
                }
                return turnRate;
            }
        }

        private static RealtimeData tvdOfBit;
        /// <summary>
        /// Total (vertical) depth of bit
        /// </summary>
        [EnumValueNameAttribute("TVD of Bit")]
        public static RealtimeData TvdOfBit
        {
            get 
            {
                if (tvdOfBit == null)
                {
                    tvdOfBit = new RealtimeData("TVD of Bit");
                    tvdOfBit.Description = "Total (vertical) depth of bit";
                }
                return tvdOfBit;
            }
        }

        private static RealtimeData tvdOfCasing;
        /// <summary>
        /// TVD of casing in the cementing context
        /// </summary>
        [EnumValueNameAttribute("TVD of casing")]
        public static RealtimeData TvdOfCasing
        {
            get 
            {
                if (tvdOfCasing == null)
                {
                    tvdOfCasing = new RealtimeData("TVD of casing");
                    tvdOfCasing.Description = "TVD of casing in the cementing context";
                }
                return tvdOfCasing;
            }
        }

        private static RealtimeData tvdOfDstBottom;
        /// <summary>
        /// Depth (vertical) of bottom of DST interval
        /// </summary>
        [EnumValueNameAttribute("TVD of DST bottom")]
        public static RealtimeData TvdOfDstBottom
        {
            get 
            {
                if (tvdOfDstBottom == null)
                {
                    tvdOfDstBottom = new RealtimeData("TVD of DST bottom");
                    tvdOfDstBottom.Description = "Depth (vertical) of bottom of DST interval";
                }
                return tvdOfDstBottom;
            }
        }

        private static RealtimeData tvdOfDstTop;
        /// <summary>
        /// Depth (vertical) of top of DST interval
        /// </summary>
        [EnumValueNameAttribute("TVD of DST top")]
        public static RealtimeData TvdOfDstTop
        {
            get 
            {
                if (tvdOfDstTop == null)
                {
                    tvdOfDstTop = new RealtimeData("TVD of DST top");
                    tvdOfDstTop.Description = "Depth (vertical) of top of DST interval";
                }
                return tvdOfDstTop;
            }
        }

        private static RealtimeData tvdOfHole;
        /// <summary>
        /// Total (vertical) depth of hole
        /// </summary>
        [EnumValueNameAttribute("TVD of hole")]
        public static RealtimeData TvdOfHole
        {
            get 
            {
                if (tvdOfHole == null)
                {
                    tvdOfHole = new RealtimeData("TVD of hole");
                    tvdOfHole.Description = "Total (vertical) depth of hole";
                }
                return tvdOfHole;
            }
        }

        private static RealtimeData tankVolume;
        /// <summary>
        /// Tank volume
        /// </summary>
        [EnumValueNameAttribute("tank volume")]
        public static RealtimeData TankVolume
        {
            get 
            {
                if (tankVolume == null)
                {
                    tankVolume = new RealtimeData("tank volume");
                    tankVolume.Description = "Tank volume";
                }
                return tankVolume;
            }
        }

        private static RealtimeData tankVolumeActive;
        /// <summary>
        /// Tank volume (active)
        /// </summary>
        [EnumValueNameAttribute("tank volume (active)")]
        public static RealtimeData TankVolumeActive
        {
            get 
            {
                if (tankVolumeActive == null)
                {
                    tankVolumeActive = new RealtimeData("tank volume (active)");
                    tankVolumeActive.Description = "Tank volume (active)";
                }
                return tankVolumeActive;
            }
        }

        private static RealtimeData tankVolumeChange;
        /// <summary>
        /// Mud Tank Volume change
        /// </summary>
        [EnumValueNameAttribute("tank volume change")]
        public static RealtimeData TankVolumeChange
        {
            get 
            {
                if (tankVolumeChange == null)
                {
                    tankVolumeChange = new RealtimeData("tank volume change");
                    tankVolumeChange.Description = "Mud Tank Volume change";
                }
                return tankVolumeChange;
            }
        }

        private static RealtimeData tankVolumeChangeActive;
        /// <summary>
        /// Tank volume change (active)
        /// </summary>
        [EnumValueNameAttribute("tank volume change (active)")]
        public static RealtimeData TankVolumeChangeActive
        {
            get 
            {
                if (tankVolumeChangeActive == null)
                {
                    tankVolumeChangeActive = new RealtimeData("tank volume change (active)");
                    tankVolumeChangeActive.Description = "Tank volume change (active)";
                }
                return tankVolumeChangeActive;
            }
        }

        private static RealtimeData tankVolumeChangeTotal;
        /// <summary>
        /// Tank volume change (total)
        /// </summary>
        [EnumValueNameAttribute("tank volume change total")]
        public static RealtimeData TankVolumeChangeTotal
        {
            get 
            {
                if (tankVolumeChangeTotal == null)
                {
                    tankVolumeChangeTotal = new RealtimeData("tank volume change total");
                    tankVolumeChangeTotal.Description = "Tank volume change (total)";
                }
                return tankVolumeChangeTotal;
            }
        }

        private static RealtimeData tankVolumeTotal;
        /// <summary>
        /// Tank volume (total)
        /// </summary>
        [EnumValueNameAttribute("tank volume (total)")]
        public static RealtimeData TankVolumeTotal
        {
            get 
            {
                if (tankVolumeTotal == null)
                {
                    tankVolumeTotal = new RealtimeData("tank volume (total)");
                    tankVolumeTotal.Description = "Tank volume (total)";
                }
                return tankVolumeTotal;
            }
        }

        private static RealtimeData annularVelocityMinimum;
        /// <summary>
        /// Annular velocity (minimum)
        /// </summary>
        [EnumValueNameAttribute("annular velocity (minimum)")]
        public static RealtimeData AnnularVelocityMinimum
        {
            get 
            {
                if (annularVelocityMinimum == null)
                {
                    annularVelocityMinimum = new RealtimeData("annular velocity (minimum)");
                    annularVelocityMinimum.Description = "Annular velocity (minimum)";
                }
                return annularVelocityMinimum;
            }
        }

        private static RealtimeData annularVelocityMaximum;
        /// <summary>
        /// Annular velocity (maximum)
        /// </summary>
        [EnumValueNameAttribute("annular velocity (maximum)")]
        public static RealtimeData AnnularVelocityMaximum
        {
            get 
            {
                if (annularVelocityMaximum == null)
                {
                    annularVelocityMaximum = new RealtimeData("annular velocity (maximum)");
                    annularVelocityMaximum.Description = "Annular velocity (maximum)";
                }
                return annularVelocityMaximum;
            }
        }

        private static RealtimeData velocityOfJet;
        /// <summary>
        /// Bit jet velocity
        /// </summary>
        [EnumValueNameAttribute("velocity of jet")]
        public static RealtimeData VelocityOfJet
        {
            get 
            {
                if (velocityOfJet == null)
                {
                    velocityOfJet = new RealtimeData("velocity of jet");
                    velocityOfJet.Description = "Bit jet velocity";
                }
                return velocityOfJet;
            }
        }

        private static RealtimeData fillVolumeExpected;
        /// <summary>
        /// Fill/gain volume, expected
        /// </summary>
        [EnumValueNameAttribute("fill volume (expected)")]
        public static RealtimeData FillVolumeExpected
        {
            get 
            {
                if (fillVolumeExpected == null)
                {
                    fillVolumeExpected = new RealtimeData("fill volume (expected)");
                    fillVolumeExpected.Description = "Fill/gain volume, expected";
                }
                return fillVolumeExpected;
            }
        }

        private static RealtimeData fillVolumeTotalExpected;
        /// <summary>
        /// Fill/gain volume, expected, cumulative
        /// </summary>
        [EnumValueNameAttribute("fill volume total (expected)")]
        public static RealtimeData FillVolumeTotalExpected
        {
            get 
            {
                if (fillVolumeTotalExpected == null)
                {
                    fillVolumeTotalExpected = new RealtimeData("fill volume total (expected)");
                    fillVolumeTotalExpected.Description = "Fill/gain volume, expected, cumulative";
                }
                return fillVolumeTotalExpected;
            }
        }

        private static RealtimeData fillVolumeObserved;
        /// <summary>
        /// Fill/gain volume, observed
        /// </summary>
        [EnumValueNameAttribute("fill volume (observed)")]
        public static RealtimeData FillVolumeObserved
        {
            get 
            {
                if (fillVolumeObserved == null)
                {
                    fillVolumeObserved = new RealtimeData("fill volume (observed)");
                    fillVolumeObserved.Description = "Fill/gain volume, observed";
                }
                return fillVolumeObserved;
            }
        }

        private static RealtimeData fillVolumeTotalObserved;
        /// <summary>
        /// Fill/gain volume, observed, cumulative
        /// </summary>
        [EnumValueNameAttribute("fill volume total (observed)")]
        public static RealtimeData FillVolumeTotalObserved
        {
            get 
            {
                if (fillVolumeTotalObserved == null)
                {
                    fillVolumeTotalObserved = new RealtimeData("fill volume total (observed)");
                    fillVolumeTotalObserved.Description = "Fill/gain volume, observed, cumulative";
                }
                return fillVolumeTotalObserved;
            }
        }

        private static RealtimeData weightOnBitAverage;
        /// <summary>
        /// Weight on bit, measured at surface
        /// </summary>
        [EnumValueNameAttribute("weight on bit (average)")]
        public static RealtimeData WeightOnBitAverage
        {
            get 
            {
                if (weightOnBitAverage == null)
                {
                    weightOnBitAverage = new RealtimeData("weight on bit (average)");
                    weightOnBitAverage.Description = "Weight on bit, measured at surface";
                }
                return weightOnBitAverage;
            }
        }

        private static RealtimeData weightOnBitMaximum;
        /// <summary>
        /// Weight on bit, maximum, measured at surface
        /// </summary>
        [EnumValueNameAttribute("weight on bit (maximum)")]
        public static RealtimeData WeightOnBitMaximum
        {
            get 
            {
                if (weightOnBitMaximum == null)
                {
                    weightOnBitMaximum = new RealtimeData("weight on bit (maximum)");
                    weightOnBitMaximum.Description = "Weight on bit, maximum, measured at surface";
                }
                return weightOnBitMaximum;
            }
        }

        private static RealtimeData mudDensityInAverage;
        /// <summary>
        /// Mud density going into the hole
        /// </summary>
        [EnumValueNameAttribute("mud density in (average)")]
        public static RealtimeData MudDensityInAverage
        {
            get 
            {
                if (mudDensityInAverage == null)
                {
                    mudDensityInAverage = new RealtimeData("mud density in (average)");
                    mudDensityInAverage.Description = "Mud density going into the hole";
                }
                return mudDensityInAverage;
            }
        }

        private static RealtimeData mudDensityOutAverage;
        /// <summary>
        /// Mud density coming out of the hole
        /// </summary>
        [EnumValueNameAttribute("mud density out (average)")]
        public static RealtimeData MudDensityOutAverage
        {
            get 
            {
                if (mudDensityOutAverage == null)
                {
                    mudDensityOutAverage = new RealtimeData("mud density out (average)");
                    mudDensityOutAverage.Description = "Mud density coming out of the hole";
                }
                return mudDensityOutAverage;
            }
        }

        private static RealtimeData yieldPoint;
        /// <summary>
        /// Mud yield point
        /// </summary>
        [EnumValueNameAttribute("yield point")]
        public static RealtimeData YieldPoint
        {
            get 
            {
                if (yieldPoint == null)
                {
                    yieldPoint = new RealtimeData("yield point");
                    yieldPoint.Description = "Mud yield point";
                }
                return yieldPoint;
            }
        }

        private static RealtimeData unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static RealtimeData Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new RealtimeData("unknown");
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
                    ansiaimbcTwo.Description = "Barcode - 1995, Uniform Symbology Specification ";
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
                    ansiaimbcSix.Description = "Barcode - 1995, Uniform Symbology Multi Row Specification ";
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
        /// Magnetic - "Modified Frequency Modulation for Magnetic Stripes" standard developed by AIM Inc.
        /// </summary>
        [EnumValueNameAttribute("MFM")]
        public static NameTagNumberingScheme Mfm
        {
            get 
            {
                if (mfm == null)
                {
                    mfm = new NameTagNumberingScheme("MFM");
                    mfm.Description = "Magnetic - \"Modified Frequency Modulation for Magnetic Stripes\" standard developed by AIM Inc.";
                }
                return mfm;
            }
        }

        private static NameTagNumberingScheme serialNumber;
        /// <summary>
        /// Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the "tag". 
        /// </summary>
        [EnumValueNameAttribute("serial number")]
        public static NameTagNumberingScheme SerialNumber
        {
            get 
            {
                if (serialNumber == null)
                {
                    serialNumber = new NameTagNumberingScheme("serial number");
                    serialNumber.Description = "Serial number contains a code which does not require any further knowledge of an encoding scheme to manipulate or process. The identifier is the only information in the \"tag\". ";
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
