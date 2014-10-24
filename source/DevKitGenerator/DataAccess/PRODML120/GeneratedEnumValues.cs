using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.PRODML120
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
    /// These values represent the type of qualifier in lithology.
    ///		HISTORY:
    ///			Issue 1.3.1-34, deprecated 39 values and added 31 values. Added new elements for version, deprecated, replacedBy, lithoType, lithoVariant.
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
                    anhydrite.Description = "Indicates that the associated lithology contains or resembles the evaporite mineral anhydrite (CaSO4).";
                    anhydrite.Version = "1.4.0.0";
                }
                return anhydrite;
            }
        }

        private static QualifierType anhydritic;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains anhydrite.
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
                    anhydritic.Description = "DEPRECATED. Indicates that the associated lithology contains anhydrite.";
                    anhydritic.Version = "1.3.1.0";
                    anhydritic.Deprecated = "1.4.0.0";
                    anhydritic.ReplacedBy = Anhydrite;
                }
                return anhydritic;
            }
        }

        private static QualifierType argillaceous;
        /// <summary>
        /// Indicates that the associated lithology comprises particles less than 0.0625mm in size, which contain or resemble clay or rock flour.
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
                    argillaceous.Description = "Indicates that the associated lithology comprises particles less than 0.0625mm in size, which contain or resemble clay or rock flour.";
                    argillaceous.Version = "1.3.1.0";
                }
                return argillaceous;
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
        /// DEPRECATED. Indicates that the associated lithology contains belemnite fossils or fragments thereof.
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
                    belemnitic.Description = "DEPRECATED. Indicates that the associated lithology contains belemnite fossils or fragments thereof.";
                    belemnitic.Version = "1.3.1.0";
                    belemnitic.Deprecated = "1.4.0.0";
                    belemnitic.ReplacedBy = Belemnites;
                }
                return belemnitic;
            }
        }

        private static QualifierType bioturbated;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology has been disturbed by organisms before consolidation.
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
                    bioturbated.Description = "DEPRECATED. Indicates that the associated lithology has been disturbed by organisms before consolidation.";
                    bioturbated.Version = "1.3.1.0";
                    bioturbated.Deprecated = "1.4.0.0";
                    bioturbated.ReplacedBy = Bioturbation;
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
        /// DEPRECATED. Indicates that the associated lithology contains bituminous material.
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
                    bituminous.Description = "DEPRECATED. Indicates that the associated lithology contains bituminous material.";
                    bituminous.Version = "1.3.1.0";
                    bituminous.Deprecated = "1.4.0.0";
                    bituminous.ReplacedBy = Bitumen;
                }
                return bituminous;
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
        /// DEPRECATED. Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation.
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
                    burrowed.Description = "DEPRECATED. Indicates that the associated lithology has been disturbed by burrowing organisms before consolidation.";
                    burrowed.Version = "1.3.1.0";
                    burrowed.Deprecated = "1.4.0.0";
                    burrowed.ReplacedBy = Burrows;
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
                    chalk.Description = "Indicates that the associated lithology comprises material containing or resembling a soft compact form of calcium carbonate (CaCO3).";
                    chalk.Version = "1.4.0.0";
                }
                return chalk;
            }
        }

        private static QualifierType chalky;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology has a chalk content.
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
                    chalky.Description = "DEPRECATED. Indicates that the associated lithology has a chalk content.";
                    chalky.Version = "1.3.1.0";
                    chalky.Deprecated = "1.4.0.0";
                    chalky.ReplacedBy = Chalk;
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
                    chert.Description = "Indicates that the associated lithology contains or resembles the microcrystalline or cryptocrystalline form of quartz (SiO2).";
                    chert.Version = "1.3.1.0";
                }
                return chert;
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
                    chlorite.Description = "Indicates that the associated lithology contains or resembles chlorite, a generally green or black flaky phyllosilicate mineral.";
                    chlorite.Version = "1.3.1.0";
                }
                return chlorite;
            }
        }

        private static QualifierType coal;
        /// <summary>
        /// Indicates that the associated lithology contains material resembling an organoclastic sedimentary rock, comprising more than 50% by weight of carbonaceous material composed mainly of lithified plant remains.
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
                    coal.Description = "Indicates that the associated lithology contains material resembling an organoclastic sedimentary rock, comprising more than 50% by weight of carbonaceous material composed mainly of lithified plant remains.";
                    coal.Version = "1.4.0.0";
                }
                return coal;
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
                    conglomerate.Description = "Indicates that the associated lithology contains rounded rock fragments of greater than 20mm in size.";
                    conglomerate.Version = "1.4.0.0";
                }
                return conglomerate;
            }
        }

        private static QualifierType conglomeratic;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains conglomerate rock material.
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
                    conglomeratic.Description = "DEPRECATED. Indicates that the associated lithology contains conglomerate rock material.";
                    conglomeratic.Version = "1.3.1.0";
                    conglomeratic.Deprecated = "1.4.0.0";
                    conglomeratic.ReplacedBy = Conglomerate;
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
        /// DEPRECATED. Indicates that the associated lithology has a dolomite content.
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
                    dolomitic.Description = "DEPRECATED. Indicates that the associated lithology has a dolomite content.";
                    dolomitic.Version = "1.3.1.0";
                    dolomitic.Deprecated = "1.4.0.0";
                    dolomitic.ReplacedBy = Dolomite;
                }
                return dolomitic;
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
                    feldspar.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the rock-forming aluminosilicate minerals of sodium, potassium or calcium.";
                    feldspar.Version = "1.3.1.0";
                }
                return feldspar;
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

        private static QualifierType fissile;
        /// <summary>
        /// DEPRECATED. the term 'fissile' doesn't belong in this list as it is neither qualifier or modifier .... it is a descriptor of 'grain fabric'.
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
                    fissile.Description = "DEPRECATED. the term 'fissile' doesn't belong in this list as it is neither qualifier or modifier .... it is a descriptor of 'grain fabric'.";
                    fissile.Version = "1.3.1.0";
                    fissile.Deprecated = "1.4.0.0";
                    fissile.ReplacedBy = Unknown;
                }
                return fissile;
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
        /// DEPRECATED. see forams.
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
                    foramsUndifferentiated.Description = "DEPRECATED. see forams.";
                    foramsUndifferentiated.Version = "1.3.1.0";
                    foramsUndifferentiated.Deprecated = "1.4.0.0";
                    foramsUndifferentiated.ReplacedBy = Forams;
                }
                return foramsUndifferentiated;
            }
        }

        private static QualifierType fossilFragment;
        /// <summary>
        /// DEPRECATED. see fossil fragments.
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
                    fossilFragment.Description = "DEPRECATED. see fossil fragments.";
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
                    glauconite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the generally greenish authogenic clay mineral glauconite.";
                    glauconite.Version = "1.3.1.0";
                }
                return glauconite;
            }
        }

        private static QualifierType glauconitic;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology is glauconitic.
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
                    glauconitic.Description = "DEPRECATED. Indicates that the associated lithology is glauconitic.";
                    glauconitic.Version = "1.3.1.0";
                    glauconitic.Deprecated = "1.4.0.0";
                    glauconitic.ReplacedBy = Glauconite;
                }
                return glauconitic;
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
                    gravel.Description = "Indicates that the associated lithology contains particles in the size range of 2mm - 20mm.";
                    gravel.Version = "1.4.0.0";
                }
                return gravel;
            }
        }

        private static QualifierType gravelly;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains gravel sized particles.
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
                    gravelly.Description = "DEPRECATED. Indicates that the associated lithology contains gravel sized particles.";
                    gravelly.Version = "1.3.1.0";
                    gravelly.Deprecated = "1.4.0.0";
                    gravelly.ReplacedBy = Gravel;
                }
                return gravelly;
            }
        }

        private static QualifierType gypsiferous;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains significant gypsum content.
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
                    gypsiferous.Description = "DEPRECATED. Indicates that the associated lithology contains significant gypsum content.";
                    gypsiferous.Version = "1.3.1.0";
                    gypsiferous.Deprecated = "1.4.0.0";
                    gypsiferous.ReplacedBy = Gypsum;
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
                    halite.Description = "Indicates that the associated lithology contains or resembles the common evaporite mineral Halite (NaCl).";
                    halite.Version = "1.3.1.0";
                }
                return halite;
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
                    illite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral illite.";
                    illite.Version = "1.3.1.0";
                }
                return illite;
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
                    kaolinite.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling the common clay mineral kaolinite.";
                    kaolinite.Version = "1.3.1.0";
                }
                return kaolinite;
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
                    lignite.Description = "Indicates that the associated lithology comprises material containing or resembling a soft brownish-black form of coal.";
                    lignite.Version = "1.3.1.0";
                }
                return lignite;
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

        private static QualifierType lithicFragment;
        /// <summary>
        /// DEPRECATED. see lithic fragments.
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
                    lithicFragment.Description = "DEPRECATED. see lithic fragments.";
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
                    marl.Description = "Indicates that the associated lithology comprises material containing or characteristic of a crumbly mixture of clays, calcium and magnesium carbonates.";
                    marl.Version = "1.4.0.0";
                }
                return marl;
            }
        }

        private static QualifierType marly;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains marl.
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
                    marly.Description = "DEPRECATED. Indicates that the associated lithology contains marl.";
                    marly.Version = "1.3.1.0";
                    marly.Deprecated = "1.4.0.0";
                    marly.ReplacedBy = Marl;
                }
                return marly;
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

        private static QualifierType microfossil;
        /// <summary>
        /// DEPRECATED. see microfossils.
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
                    microfossil.Description = "DEPRECATED. see microfossils.";
                    microfossil.Version = "1.3.1.0";
                    microfossil.Deprecated = "1.4.0.0";
                    microfossil.ReplacedBy = Microfossils;
                }
                return microfossil;
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

        private static QualifierType noDescription;
        /// <summary>
        /// DEPRECATED. where's the validity of creating a null entry for either qualifier or modifer?.
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
                    noDescription.Description = "DEPRECATED. where's the validity of creating a null entry for either qualifier or modifer?.";
                    noDescription.Version = "1.3.1.0";
                    noDescription.Deprecated = "1.4.0.0";
                    noDescription.ReplacedBy = Unknown;
                }
                return noDescription;
            }
        }

        private static QualifierType none;
        /// <summary>
        /// DEPRECATED. where's the validity of creating a null entry for either qualifier or modifer?.
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
                    none.Description = "DEPRECATED. where's the validity of creating a null entry for either qualifier or modifer?.";
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
        /// DEPRECATED. see oncoliths.
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
                    oncolith.Description = "DEPRECATED. see oncoliths.";
                    oncolith.Version = "1.3.1.0";
                    oncolith.Deprecated = "1.4.0.0";
                    oncolith.ReplacedBy = Oncoliths;
                }
                return oncolith;
            }
        }

        private static QualifierType oncolithic;
        /// <summary>
        /// Indicates that the associated lithology contains oncolites.
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
                    oncolithic.Description = "Indicates that the associated lithology contains oncolites.";
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

        private static QualifierType ooidOrOolith;
        /// <summary>
        /// DEPRECATED. see ooids.
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
                    ooidOrOolith.Description = "DEPRECATED. see ooids.";
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
        /// DEPRECATED. Indicates that the associated material contains pebble sized particles.
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
                    pebbly.Description = "DEPRECATED. Indicates that the associated material contains pebble sized particles.";
                    pebbly.Version = "1.3.1.0";
                    pebbly.Deprecated = "1.4.0.0";
                    pebbly.ReplacedBy = Pebble;
                }
                return pebbly;
            }
        }

        private static QualifierType pellet;
        /// <summary>
        /// DEPRECATED. See "pellets".
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
                    pellet.Description = "DEPRECATED. See \"pellets\".";
                    pellet.Version = "1.3.1.0";
                    pellet.Deprecated = "1.4.0.0";
                    pellet.ReplacedBy = Pellets;
                }
                return pellet;
            }
        }

        private static QualifierType pelletal;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains pellets or fragments of pellets.
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
                    pelletal.Description = "DEPRECATED. Indicates that the associated lithology contains pellets or fragments of pellets.";
                    pelletal.Version = "1.3.1.0";
                    pelletal.Deprecated = "1.4.0.0";
                    pelletal.ReplacedBy = Pellets;
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
        /// DEPRECATED. see peloids.
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
                    peloid.Description = "DEPRECATED. see peloids.";
                    peloid.Version = "1.3.1.0";
                    peloid.Deprecated = "1.4.0.0";
                    peloid.ReplacedBy = Peloids;
                }
                return peloid;
            }
        }

        private static QualifierType peloidal;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains peloids.
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
                    peloidal.Description = "DEPRECATED. Indicates that the associated lithology contains peloids.";
                    peloidal.Version = "1.3.1.0";
                    peloidal.Deprecated = "1.4.0.0";
                    peloidal.ReplacedBy = Peloids;
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
                    phosphate.Description = "Indicates that the associated lithology contains phosphates.";
                    phosphate.Version = "1.3.1.0";
                }
                return phosphate;
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
        /// DEPRECATED. see pisoliths.
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
                    pisolith.Description = "DEPRECATED. see pisoliths.";
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
                    quartz.Description = "Indicates that the associated lithology comprises (crystalline) material containing or resembling the common silica mineral quartz (SiO2).";
                    quartz.Version = "1.3.1.0";
                }
                return quartz;
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

        private static QualifierType salt;
        /// <summary>
        /// Indicates that the associated lithology comprises (crystalline) material containing or resembling rock salts of sodium or potassium (NaCl or KCl).
        /// </summary>
        [EnumValueNameAttribute("salt")]
        public static QualifierType Salt
        {
            get 
            {
                if (salt == null)
                {
                    salt = new QualifierType("salt");
                    salt.LithoType = EnumValueLithoType.both;
                    salt.Description = "Indicates that the associated lithology comprises (crystalline) material containing or resembling rock salts of sodium or potassium (NaCl or KCl).";
                    salt.Version = "1.4.0.0";
                }
                return salt;
            }
        }

        private static QualifierType salty;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains rock salt or halite.
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
                    salty.Description = "DEPRECATED. Indicates that the associated lithology contains rock salt or halite.";
                    salty.Version = "1.3.1.0";
                    salty.Deprecated = "1.4.0.0";
                    salty.ReplacedBy = Salt;
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
                    sand.Description = "Indicates that the associated lithology comprises (crystalline) material containing or resembling mineral or rock grains of diameter in the range of 0.625mm - 2mm.";
                    sand.Version = "1.4.0.0";
                }
                return sand;
            }
        }

        private static QualifierType sandy;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology has a sand content.
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
                    sandy.Description = "DEPRECATED. Indicates that the associated lithology has a sand content.";
                    sandy.Version = "1.3.1.0";
                    sandy.Deprecated = "1.4.0.0";
                    sandy.ReplacedBy = Sand;
                }
                return sandy;
            }
        }

        private static QualifierType shell;
        /// <summary>
        /// DEPRECATED. see shell fragments.
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
                    shell.Description = "DEPRECATED. see shell fragments.";
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
                    silt.Description = "Indicates that the associated lithology comprises (matrix) material of very fine particles intermediate in size between clay and sand (0.0625mm - 2mm).";
                    silt.Version = "1.4.0.0";
                }
                return silt;
            }
        }

        private static QualifierType silty;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology has a silt content.
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
                    silty.Description = "DEPRECATED. Indicates that the associated lithology has a silt content.";
                    silty.Version = "1.3.1.0";
                    silty.Deprecated = "1.4.0.0";
                    silty.ReplacedBy = Silt;
                }
                return silty;
            }
        }

        private static QualifierType spicular;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains spicules.
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
                    spicular.Description = "DEPRECATED. Indicates that the associated lithology contains spicules.";
                    spicular.Version = "1.3.1.0";
                    spicular.Deprecated = "1.4.0.0";
                    spicular.ReplacedBy = Spicules;
                }
                return spicular;
            }
        }

        private static QualifierType spicule;
        /// <summary>
        /// DEPRECATED. see spicules.
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
                    spicule.Description = "DEPRECATED. see spicules.";
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

        private static QualifierType stylolite;
        /// <summary>
        /// DEPRECATED. see stylolites.
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
                    stylolite.Description = "DEPRECATED. see stylolites.";
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
        /// DEPRECATED. Indicates that the associated lithology contains stylolites.
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
                    stylolitic.Description = "DEPRECATED. Indicates that the associated lithology contains stylolites.";
                    stylolitic.Version = "1.3.1.0";
                    stylolitic.Deprecated = "1.4.0.0";
                    stylolitic.ReplacedBy = Stylolites;
                }
                return stylolitic;
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
                    tuff.Description = "Indicates that the associated lithology comprises (matrix) material containing or resembling pyroclastic detrital material (volcanic ash).";
                    tuff.Version = "1.4.0.0";
                }
                return tuff;
            }
        }

        private static QualifierType tuffaceous;
        /// <summary>
        /// DEPRECATED. Indicates that the associated lithology contains pyroclastic detrital material (tuff).
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
                    tuffaceous.Description = "DEPRECATED. Indicates that the associated lithology contains pyroclastic detrital material (tuff).";
                    tuffaceous.Version = "1.3.1.0";
                    tuffaceous.Deprecated = "1.4.0.0";
                    tuffaceous.ReplacedBy = Tuff;
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
                    tuffite.Description = "Indicates that the associated lithology comprises material containing or resembling a fine grained matrix of volcanic breccia with intruded grains of fluidized sediment.";
                    tuffite.Version = "1.3.1.0";
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
                    unknown.LithoType = EnumValueLithoType.both;
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                    unknown.Version = "1.3.1.0";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// These values represent the name of a recording channel.
    /// </summary>
    public class RealtimeData : Energistics.DataAccess.EnumValue.RealtimeEnumValue
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

        private static RealtimeData acetylene;
        /// <summary>
        /// Acetylene content of the sample (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("acetylene")]
        public static RealtimeData Acetylene
        {
            get 
            {
                if (acetylene == null)
                {
                    acetylene = new RealtimeData("acetylene");
                    acetylene.RealtimeMeasureClass = "volume per volume";
                    acetylene.Description = "Acetylene content of the sample (cycle-based)";
                }
                return acetylene;
            }
        }

        private static RealtimeData activity;
        /// <summary>
        /// A WITSML activity name indicating what activity is currently being performed on the rig. IT IS ESSENTIAL that this information be as accurate and current as possible. Added via Issue
        /// </summary>
        [EnumValueNameAttribute("activity")]
        public static RealtimeData Activity
        {
            get 
            {
                if (activity == null)
                {
                    activity = new RealtimeData("activity");
                    activity.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    activity.Description = "A WITSML activity name indicating what activity is currently being performed on the rig. IT IS ESSENTIAL that this information be as accurate and current as possible. Added via Issue";
                    activity.Version = "1.4.0.0";
                }
                return activity;
            }
        }

        private static RealtimeData activityWits;
        /// <summary>
        /// Code indicating what activity is currently being performed on the rig. IT IS ESSENTIAL that this information be as accurate and current as possible. Use the integer codes shown in WITS Appendix E.
        /// </summary>
        [EnumValueNameAttribute("activity WITS")]
        public static RealtimeData ActivityWits
        {
            get 
            {
                if (activityWits == null)
                {
                    activityWits = new RealtimeData("activity WITS");
                    activityWits.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    activityWits.Description = "Code indicating what activity is currently being performed on the rig. IT IS ESSENTIAL that this information be as accurate and current as possible. Use the integer codes shown in WITS Appendix E.";
                    activityWits.Version = "1.4.0.0";
                }
                return activityWits;
            }
        }

        private static RealtimeData annularVelocityMaximum;
        /// <summary>
        /// Calculated maximum velocity of the drilling fluid in the annulus.
        /// </summary>
        [EnumValueNameAttribute("annular velocity (maximum)")]
        public static RealtimeData AnnularVelocityMaximum
        {
            get 
            {
                if (annularVelocityMaximum == null)
                {
                    annularVelocityMaximum = new RealtimeData("annular velocity (maximum)");
                    annularVelocityMaximum.RealtimeMeasureClass = "velocity";
                    annularVelocityMaximum.Description = "Calculated maximum velocity of the drilling fluid in the annulus.";
                }
                return annularVelocityMaximum;
            }
        }

        private static RealtimeData annularVelocityMinimum;
        /// <summary>
        /// Calculated minimum velocity of the drilling fluid in the annulus.
        /// </summary>
        [EnumValueNameAttribute("annular velocity (minimum)")]
        public static RealtimeData AnnularVelocityMinimum
        {
            get 
            {
                if (annularVelocityMinimum == null)
                {
                    annularVelocityMinimum = new RealtimeData("annular velocity (minimum)");
                    annularVelocityMinimum.RealtimeMeasureClass = "velocity";
                    annularVelocityMinimum.Description = "Calculated minimum velocity of the drilling fluid in the annulus.";
                }
                return annularVelocityMinimum;
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
                    antistokesIntensity.RealtimeDataType = EnumValueRealtimeType.RealtimeNumeric;
                    antistokesIntensity.Description = "Anti-Stokes intensity values from a Distributed Temperature Survey.";
                }
                return antistokesIntensity;
            }
        }

        private static RealtimeData azimuthCorrected;
        /// <summary>
        /// Borehole azimuth measured by the directional sensor relative to true north, i.e. corrected for declination.
        /// </summary>
        [EnumValueNameAttribute("azimuth corrected")]
        public static RealtimeData AzimuthCorrected
        {
            get 
            {
                if (azimuthCorrected == null)
                {
                    azimuthCorrected = new RealtimeData("azimuth corrected");
                    azimuthCorrected.RealtimeMeasureClass = "plane angle";
                    azimuthCorrected.Description = "Borehole azimuth measured by the directional sensor relative to true north, i.e. corrected for declination.";
                }
                return azimuthCorrected;
            }
        }

        private static RealtimeData azimuthUncorrected;
        /// <summary>
        /// Borehole azimuth measured by the directional sensor relative to local magnetic north.
        /// </summary>
        [EnumValueNameAttribute("azimuth uncorrected")]
        public static RealtimeData AzimuthUncorrected
        {
            get 
            {
                if (azimuthUncorrected == null)
                {
                    azimuthUncorrected = new RealtimeData("azimuth uncorrected");
                    azimuthUncorrected.RealtimeMeasureClass = "plane angle";
                    azimuthUncorrected.Description = "Borehole azimuth measured by the directional sensor relative to local magnetic north.";
                }
                return azimuthUncorrected;
            }
        }

        private static RealtimeData bitJetImpactForce;
        /// <summary>
        /// Force exerted on the bottom of the hole by the flow of fluid through the bit.
        /// </summary>
        [EnumValueNameAttribute("bit jet impact force")]
        public static RealtimeData BitJetImpactForce
        {
            get 
            {
                if (bitJetImpactForce == null)
                {
                    bitJetImpactForce = new RealtimeData("bit jet impact force");
                    bitJetImpactForce.RealtimeMeasureClass = "force";
                    bitJetImpactForce.Description = "Force exerted on the bottom of the hole by the flow of fluid through the bit.";
                }
                return bitJetImpactForce;
            }
        }

        private static RealtimeData bitPressureLoss;
        /// <summary>
        /// Calculated pressure differential across the bit.
        /// </summary>
        [EnumValueNameAttribute("bit pressure loss")]
        public static RealtimeData BitPressureLoss
        {
            get 
            {
                if (bitPressureLoss == null)
                {
                    bitPressureLoss = new RealtimeData("bit pressure loss");
                    bitPressureLoss.RealtimeMeasureClass = "pressure";
                    bitPressureLoss.Description = "Calculated pressure differential across the bit.";
                }
                return bitPressureLoss;
            }
        }

        private static RealtimeData bitRevolutionsCumulative;
        /// <summary>
        /// Measured/calculated running total of the bit revolutions while on bottom. This does not include reaming time. For a re run bit, it is the total revolutions since the last trip.
        /// </summary>
        [EnumValueNameAttribute("bit revolutions, cumulative")]
        public static RealtimeData BitRevolutionsCumulative
        {
            get 
            {
                if (bitRevolutionsCumulative == null)
                {
                    bitRevolutionsCumulative = new RealtimeData("bit revolutions, cumulative");
                    bitRevolutionsCumulative.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    bitRevolutionsCumulative.Description = "Measured/calculated running total of the bit revolutions while on bottom. This does not include reaming time. For a re run bit, it is the total revolutions since the last trip.";
                }
                return bitRevolutionsCumulative;
            }
        }

        private static RealtimeData bitTotalMeasuredDepth;
        /// <summary>
        /// Measured depth at the end of the bit run (null if bit run not over).
        /// </summary>
        [EnumValueNameAttribute("bit total measured depth")]
        public static RealtimeData BitTotalMeasuredDepth
        {
            get 
            {
                if (bitTotalMeasuredDepth == null)
                {
                    bitTotalMeasuredDepth = new RealtimeData("bit total measured depth");
                    bitTotalMeasuredDepth.RealtimeMeasureClass = "length";
                    bitTotalMeasuredDepth.Description = "Measured depth at the end of the bit run (null if bit run not over).";
                }
                return bitTotalMeasuredDepth;
            }
        }

        private static RealtimeData blockPosition;
        /// <summary>
        /// Measured distance of the traveling block above the rotary table.
        /// </summary>
        [EnumValueNameAttribute("block position")]
        public static RealtimeData BlockPosition
        {
            get 
            {
                if (blockPosition == null)
                {
                    blockPosition = new RealtimeData("block position");
                    blockPosition.RealtimeMeasureClass = "length";
                    blockPosition.Description = "Measured distance of the traveling block above the rotary table.";
                }
                return blockPosition;
            }
        }

        private static RealtimeData buildRate;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("build rate")]
        public static RealtimeData BuildRate
        {
            get 
            {
                if (buildRate == null)
                {
                    buildRate = new RealtimeData("build rate");
                    buildRate.RealtimeMeasureClass = "angle per length";
                    buildRate.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return buildRate;
            }
        }

        private static RealtimeData caliper;
        /// <summary>
        /// Value of the Caliper sensor.
        /// </summary>
        [EnumValueNameAttribute("caliper")]
        public static RealtimeData Caliper
        {
            get 
            {
                if (caliper == null)
                {
                    caliper = new RealtimeData("caliper");
                    caliper.RealtimeMeasureClass = "length";
                    caliper.Description = "Value of the Caliper sensor.";
                }
                return caliper;
            }
        }

        private static RealtimeData carbonDioxideAverage;
        /// <summary>
        /// Carbon dioxide content of the returning mud sample, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (average)")]
        public static RealtimeData CarbonDioxideAverage
        {
            get 
            {
                if (carbonDioxideAverage == null)
                {
                    carbonDioxideAverage = new RealtimeData("carbon dioxide (average)");
                    carbonDioxideAverage.RealtimeMeasureClass = "volume per volume";
                    carbonDioxideAverage.Description = "Carbon dioxide content of the returning mud sample, averaged over the interval.";
                }
                return carbonDioxideAverage;
            }
        }

        private static RealtimeData carbonDioxideCyclebased;
        /// <summary>
        /// Carbon dioxide content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (cycle-based)")]
        public static RealtimeData CarbonDioxideCyclebased
        {
            get 
            {
                if (carbonDioxideCyclebased == null)
                {
                    carbonDioxideCyclebased = new RealtimeData("carbon dioxide (cycle-based)");
                    carbonDioxideCyclebased.RealtimeMeasureClass = "volume per volume";
                    carbonDioxideCyclebased.Description = "Carbon dioxide content of the sample. (cycle-based)";
                }
                return carbonDioxideCyclebased;
            }
        }

        private static RealtimeData carbonDioxideMaximum;
        /// <summary>
        /// Maximum carbon dioxide content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (maximum)")]
        public static RealtimeData CarbonDioxideMaximum
        {
            get 
            {
                if (carbonDioxideMaximum == null)
                {
                    carbonDioxideMaximum = new RealtimeData("carbon dioxide (maximum)");
                    carbonDioxideMaximum.RealtimeMeasureClass = "volume per volume";
                    carbonDioxideMaximum.Description = "Maximum carbon dioxide content of the returning mud sample, over the interval.";
                }
                return carbonDioxideMaximum;
            }
        }

        private static RealtimeData carbonDioxideMinimum;
        /// <summary>
        /// Minimum carbon dioxide content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide (minimum)")]
        public static RealtimeData CarbonDioxideMinimum
        {
            get 
            {
                if (carbonDioxideMinimum == null)
                {
                    carbonDioxideMinimum = new RealtimeData("carbon dioxide (minimum)");
                    carbonDioxideMinimum.RealtimeMeasureClass = "volume per volume";
                    carbonDioxideMinimum.Description = "Minimum carbon dioxide content of the returning mud sample, over the interval.";
                }
                return carbonDioxideMinimum;
            }
        }

        private static RealtimeData cationExchangeCapacity;
        /// <summary>
        /// The cation exchange capacity of a sample, measured using the methylene blue titration method.
        /// </summary>
        [EnumValueNameAttribute("cation exchange capacity")]
        public static RealtimeData CationExchangeCapacity
        {
            get 
            {
                if (cationExchangeCapacity == null)
                {
                    cationExchangeCapacity = new RealtimeData("cation exchange capacity");
                    cationExchangeCapacity.RealtimeMeasureClass = "equivalent per mass";
                    cationExchangeCapacity.Description = "The cation exchange capacity of a sample, measured using the methylene blue titration method.";
                }
                return cationExchangeCapacity;
            }
        }

        private static RealtimeData cavings;
        /// <summary>
        /// That proportion of the cuttings which are interpreted to be cavings.
        /// </summary>
        [EnumValueNameAttribute("cavings")]
        public static RealtimeData Cavings
        {
            get 
            {
                if (cavings == null)
                {
                    cavings = new RealtimeData("cavings");
                    cavings.RealtimeMeasureClass = "volume per volume";
                    cavings.Description = "That proportion of the cuttings which are interpreted to be cavings.";
                }
                return cavings;
            }
        }

        private static RealtimeData cementingCementVolume;
        /// <summary>
        /// Cumulative volume of cement pumped (all batches in the current stage) at the time the record is generated.
        /// </summary>
        [EnumValueNameAttribute("cementing cement volume")]
        public static RealtimeData CementingCementVolume
        {
            get 
            {
                if (cementingCementVolume == null)
                {
                    cementingCementVolume = new RealtimeData("cementing cement volume");
                    cementingCementVolume.RealtimeMeasureClass = "volume";
                    cementingCementVolume.Description = "Cumulative volume of cement pumped (all batches in the current stage) at the time the record is generated.";
                }
                return cementingCementVolume;
            }
        }

        private static RealtimeData cementingCumulativeReturns;
        /// <summary>
        /// Cumulative calculated/measured returns since the start of the cement job. This does not include mud circulation prior to pumping cement or spacer
        /// </summary>
        [EnumValueNameAttribute("cementing cumulative returns")]
        public static RealtimeData CementingCumulativeReturns
        {
            get 
            {
                if (cementingCumulativeReturns == null)
                {
                    cementingCumulativeReturns = new RealtimeData("cementing cumulative returns");
                    cementingCumulativeReturns.RealtimeMeasureClass = "volume";
                    cementingCumulativeReturns.Description = "Cumulative calculated/measured returns since the start of the cement job. This does not include mud circulation prior to pumping cement or spacer";
                }
                return cementingCumulativeReturns;
            }
        }

        private static RealtimeData cementingDensityInAverage;
        /// <summary>
        /// Measured density of the fluid entering the well, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing density in (average)")]
        public static RealtimeData CementingDensityInAverage
        {
            get 
            {
                if (cementingDensityInAverage == null)
                {
                    cementingDensityInAverage = new RealtimeData("cementing density in (average)");
                    cementingDensityInAverage.RealtimeMeasureClass = "density";
                    cementingDensityInAverage.Description = "Measured density of the fluid entering the well, averaged over the interval.";
                }
                return cementingDensityInAverage;
            }
        }

        private static RealtimeData cementingDensityOutAverage;
        /// <summary>
        /// Measured density of the fluid leaving the well, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing density out (average)")]
        public static RealtimeData CementingDensityOutAverage
        {
            get 
            {
                if (cementingDensityOutAverage == null)
                {
                    cementingDensityOutAverage = new RealtimeData("cementing density out (average)");
                    cementingDensityOutAverage.RealtimeMeasureClass = "density";
                    cementingDensityOutAverage.Description = "Measured density of the fluid leaving the well, averaged over the interval.";
                }
                return cementingDensityOutAverage;
            }
        }

        private static RealtimeData cementingEcdAtCasingShoe;
        /// <summary>
        /// Effective circulating density, at the casing shoe measured depth, of the fluids currently in the hole.
        /// </summary>
        [EnumValueNameAttribute("cementing ECD at casing shoe")]
        public static RealtimeData CementingEcdAtCasingShoe
        {
            get 
            {
                if (cementingEcdAtCasingShoe == null)
                {
                    cementingEcdAtCasingShoe = new RealtimeData("cementing ECD at casing shoe");
                    cementingEcdAtCasingShoe.RealtimeMeasureClass = "density";
                    cementingEcdAtCasingShoe.Description = "Effective circulating density, at the casing shoe measured depth, of the fluids currently in the hole.";
                }
                return cementingEcdAtCasingShoe;
            }
        }

        private static RealtimeData cementingFlowRateInAverage;
        /// <summary>
        /// Flow rate of the fluid entering the hole, measured with a flow sensor, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate in (average)")]
        public static RealtimeData CementingFlowRateInAverage
        {
            get 
            {
                if (cementingFlowRateInAverage == null)
                {
                    cementingFlowRateInAverage = new RealtimeData("cementing flow rate in (average)");
                    cementingFlowRateInAverage.RealtimeMeasureClass = "volume flow rate";
                    cementingFlowRateInAverage.Description = "Flow rate of the fluid entering the hole, measured with a flow sensor, averaged over the interval.";
                }
                return cementingFlowRateInAverage;
            }
        }

        private static RealtimeData cementingFlowRateInCalculated;
        /// <summary>
        /// Flow rate of the fluid entering the hole, based on strokes per minute, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate in (calculated)")]
        public static RealtimeData CementingFlowRateInCalculated
        {
            get 
            {
                if (cementingFlowRateInCalculated == null)
                {
                    cementingFlowRateInCalculated = new RealtimeData("cementing flow rate in (calculated)");
                    cementingFlowRateInCalculated.RealtimeMeasureClass = "volume flow rate";
                    cementingFlowRateInCalculated.Description = "Flow rate of the fluid entering the hole, based on strokes per minute, averaged over the interval.";
                }
                return cementingFlowRateInCalculated;
            }
        }

        private static RealtimeData cementingFlowRateOutAverage;
        /// <summary>
        /// Flow rate of the fluid leaving the hole, measured with a flow sensor, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (average)")]
        public static RealtimeData CementingFlowRateOutAverage
        {
            get 
            {
                if (cementingFlowRateOutAverage == null)
                {
                    cementingFlowRateOutAverage = new RealtimeData("cementing flow rate out (average)");
                    cementingFlowRateOutAverage.RealtimeMeasureClass = "volume flow rate";
                    cementingFlowRateOutAverage.Description = "Flow rate of the fluid leaving the hole, measured with a flow sensor, averaged over the interval.";
                }
                return cementingFlowRateOutAverage;
            }
        }

        private static RealtimeData cementingFlowRateOutCalculated;
        /// <summary>
        /// Flow rate of the fluid leaving the hole, based on strokes per minute, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (calculated)")]
        public static RealtimeData CementingFlowRateOutCalculated
        {
            get 
            {
                if (cementingFlowRateOutCalculated == null)
                {
                    cementingFlowRateOutCalculated = new RealtimeData("cementing flow rate out (calculated)");
                    cementingFlowRateOutCalculated.RealtimeMeasureClass = "volume flow rate";
                    cementingFlowRateOutCalculated.Description = "Flow rate of the fluid leaving the hole, based on strokes per minute, averaged over the interval.";
                }
                return cementingFlowRateOutCalculated;
            }
        }

        private static RealtimeData cementingFlowRateOutRelative;
        /// <summary>
        /// Percent of flow out as measured by a paddle or target sensor in the flow line, where 0% = no flow, 100% = full deflection of the sensor.
        /// </summary>
        [EnumValueNameAttribute("cementing flow rate out (relative)")]
        public static RealtimeData CementingFlowRateOutRelative
        {
            get 
            {
                if (cementingFlowRateOutRelative == null)
                {
                    cementingFlowRateOutRelative = new RealtimeData("cementing flow rate out (relative)");
                    cementingFlowRateOutRelative.RealtimeMeasureClass = "volume per volume";
                    cementingFlowRateOutRelative.Description = "Percent of flow out as measured by a paddle or target sensor in the flow line, where 0% = no flow, 100% = full deflection of the sensor.";
                }
                return cementingFlowRateOutRelative;
            }
        }

        private static RealtimeData cementingFluidType;
        /// <summary>
        /// Type/batch of fluid currently being pumped. An integer number indicates the fluid type and a letter (ie. A,B,C etc.) indicates the batch. Type codes are: 1=Drilling fluid, 2=Spacer, 3=Cement, 4=Displacement. The coding sequence for a cement job could look like this: 1A, 2A, 2B, 3A, 3B, 4A, etc.
        /// </summary>
        [EnumValueNameAttribute("cementing fluid type")]
        public static RealtimeData CementingFluidType
        {
            get 
            {
                if (cementingFluidType == null)
                {
                    cementingFluidType = new RealtimeData("cementing fluid type");
                    cementingFluidType.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    cementingFluidType.Description = "Type/batch of fluid currently being pumped. An integer number indicates the fluid type and a letter (ie. A,B,C etc.) indicates the batch. Type codes are: 1=Drilling fluid, 2=Spacer, 3=Cement, 4=Displacement. The coding sequence for a cement job could look like this: 1A, 2A, 2B, 3A, 3B, 4A, etc.";
                }
                return cementingFluidType;
            }
        }

        private static RealtimeData cementingIndividualVolume;
        /// <summary>
        /// Cumulative volume of fluid pumped, for the current individual type/batch, at the time the record is generated. This number should be reset to zero whenever the fluid type or batch changes.
        /// </summary>
        [EnumValueNameAttribute("cementing individual volume")]
        public static RealtimeData CementingIndividualVolume
        {
            get 
            {
                if (cementingIndividualVolume == null)
                {
                    cementingIndividualVolume = new RealtimeData("cementing individual volume");
                    cementingIndividualVolume.RealtimeMeasureClass = "volume";
                    cementingIndividualVolume.Description = "Cumulative volume of fluid pumped, for the current individual type/batch, at the time the record is generated. This number should be reset to zero whenever the fluid type or batch changes.";
                }
                return cementingIndividualVolume;
            }
        }

        private static RealtimeData cementingJobType;
        /// <summary>
        /// Type of cementing job being performed. Valid types are: 1=Casing, 2=Liner, 3=Plug, 4=Squeeze.
        /// </summary>
        [EnumValueNameAttribute("cementing job type")]
        public static RealtimeData CementingJobType
        {
            get 
            {
                if (cementingJobType == null)
                {
                    cementingJobType = new RealtimeData("cementing job type");
                    cementingJobType.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    cementingJobType.Description = "Type of cementing job being performed. Valid types are: 1=Casing, 2=Liner, 3=Plug, 4=Squeeze.";
                }
                return cementingJobType;
            }
        }

        private static RealtimeData cementingPlugs;
        /// <summary>
        /// Number/status of all plugs for the current stage. Number the plugs in sequential order starting with the first plug that will be released (i.e. bottom plug (1), middle plug (2), top plug (3)). The status is either loaded (L) or dropped (D) (ie. 1D2L3L).
        /// </summary>
        [EnumValueNameAttribute("cementing plugs")]
        public static RealtimeData CementingPlugs
        {
            get 
            {
                if (cementingPlugs == null)
                {
                    cementingPlugs = new RealtimeData("cementing plugs");
                    cementingPlugs.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    cementingPlugs.Description = "Number/status of all plugs for the current stage. Number the plugs in sequential order starting with the first plug that will be released (i.e. bottom plug (1), middle plug (2), top plug (3)). The status is either loaded (L) or dropped (D) (ie. 1D2L3L).";
                }
                return cementingPlugs;
            }
        }

        private static RealtimeData cementingPumpPressureAverage;
        /// <summary>
        /// Measured pump pressure, averaged over the interval. This is the pressure required to displace fluid down the hole during the entire cementing operation (ie. rig pump pressure, cement truck pump pressure, etc.).
        /// </summary>
        [EnumValueNameAttribute("cementing pump pressure (average)")]
        public static RealtimeData CementingPumpPressureAverage
        {
            get 
            {
                if (cementingPumpPressureAverage == null)
                {
                    cementingPumpPressureAverage = new RealtimeData("cementing pump pressure (average)");
                    cementingPumpPressureAverage.RealtimeMeasureClass = "pressure";
                    cementingPumpPressureAverage.Description = "Measured pump pressure, averaged over the interval. This is the pressure required to displace fluid down the hole during the entire cementing operation (ie. rig pump pressure, cement truck pump pressure, etc.).";
                }
                return cementingPumpPressureAverage;
            }
        }

        private static RealtimeData cementingStage;
        /// <summary>
        /// Current stage number of the cementing operation (i.e. 1 , 2, 3, etc.).
        /// </summary>
        [EnumValueNameAttribute("cementing stage")]
        public static RealtimeData CementingStage
        {
            get 
            {
                if (cementingStage == null)
                {
                    cementingStage = new RealtimeData("cementing stage");
                    cementingStage.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    cementingStage.Description = "Current stage number of the cementing operation (i.e. 1 , 2, 3, etc.).";
                }
                return cementingStage;
            }
        }

        private static RealtimeData cementingTemperatureInAverage;
        /// <summary>
        /// Measured temperature of the fluid entering the well, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing temperature in (average)")]
        public static RealtimeData CementingTemperatureInAverage
        {
            get 
            {
                if (cementingTemperatureInAverage == null)
                {
                    cementingTemperatureInAverage = new RealtimeData("cementing temperature in (average)");
                    cementingTemperatureInAverage.RealtimeMeasureClass = "thermodynamic temperature";
                    cementingTemperatureInAverage.Description = "Measured temperature of the fluid entering the well, averaged over the interval.";
                }
                return cementingTemperatureInAverage;
            }
        }

        private static RealtimeData cementingTemperatureOutAverage;
        /// <summary>
        /// Measured temperature of the fluid leaving the well, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("cementing temperature out (average)")]
        public static RealtimeData CementingTemperatureOutAverage
        {
            get 
            {
                if (cementingTemperatureOutAverage == null)
                {
                    cementingTemperatureOutAverage = new RealtimeData("cementing temperature out (average)");
                    cementingTemperatureOutAverage.RealtimeMeasureClass = "thermodynamic temperature";
                    cementingTemperatureOutAverage.Description = "Measured temperature of the fluid leaving the well, averaged over the interval.";
                }
                return cementingTemperatureOutAverage;
            }
        }

        private static RealtimeData cementingTotalVolume;
        /// <summary>
        /// Cumulative volume of spacer, cement and displacement fluid pumped (current stage) at the time the record is generated.
        /// </summary>
        [EnumValueNameAttribute("cementing total volume")]
        public static RealtimeData CementingTotalVolume
        {
            get 
            {
                if (cementingTotalVolume == null)
                {
                    cementingTotalVolume = new RealtimeData("cementing total volume");
                    cementingTotalVolume.RealtimeMeasureClass = "volume";
                    cementingTotalVolume.Description = "Cumulative volume of spacer, cement and displacement fluid pumped (current stage) at the time the record is generated.";
                }
                return cementingTotalVolume;
            }
        }

        private static RealtimeData cementingVolumeToBumpPlug;
        /// <summary>
        /// Calculated volume required for the plug to bump.
        /// </summary>
        [EnumValueNameAttribute("cementing volume to bump plug")]
        public static RealtimeData CementingVolumeToBumpPlug
        {
            get 
            {
                if (cementingVolumeToBumpPlug == null)
                {
                    cementingVolumeToBumpPlug = new RealtimeData("cementing volume to bump plug");
                    cementingVolumeToBumpPlug.RealtimeMeasureClass = "volume";
                    cementingVolumeToBumpPlug.Description = "Calculated volume required for the plug to bump.";
                }
                return cementingVolumeToBumpPlug;
            }
        }

        private static RealtimeData chkprav;
        /// <summary>
        /// DEPRECATED. Use "choke pressure (average)".
        /// </summary>
        [EnumValueNameAttribute("chkPrAv")]
        public static RealtimeData Chkprav
        {
            get 
            {
                if (chkprav == null)
                {
                    chkprav = new RealtimeData("chkPrAv");
                    chkprav.RealtimeMeasureClass = "pressure";
                    chkprav.Description = "DEPRECATED. Use \"choke pressure (average)\".";
                    chkprav.Version = "1.2.0.0";
                    chkprav.Deprecated = "1.4.0.0";
                    chkprav.ReplacedBy = ChokePressureAverage;
                }
                return chkprav;
            }
        }

        private static RealtimeData chokePressureAverage;
        /// <summary>
        /// Measured casing (choke) pressure, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("choke pressure (average)")]
        public static RealtimeData ChokePressureAverage
        {
            get 
            {
                if (chokePressureAverage == null)
                {
                    chokePressureAverage = new RealtimeData("choke pressure (average)");
                    chokePressureAverage.RealtimeMeasureClass = "pressure";
                    chokePressureAverage.Description = "Measured casing (choke) pressure, averaged over the interval.";
                }
                return chokePressureAverage;
            }
        }

        private static RealtimeData conductivity;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("conductivity")]
        public static RealtimeData Conductivity
        {
            get 
            {
                if (conductivity == null)
                {
                    conductivity = new RealtimeData("conductivity");
                    conductivity.RealtimeMeasureClass = "conductivity";
                    conductivity.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return conductivity;
            }
        }

        private static RealtimeData conductivityOfMudInAverage;
        /// <summary>
        /// Conductivity of the mud entering the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("conductivity of mud in (average)")]
        public static RealtimeData ConductivityOfMudInAverage
        {
            get 
            {
                if (conductivityOfMudInAverage == null)
                {
                    conductivityOfMudInAverage = new RealtimeData("conductivity of mud in (average)");
                    conductivityOfMudInAverage.RealtimeMeasureClass = "conductivity";
                    conductivityOfMudInAverage.Description = "Conductivity of the mud entering the hole, averaged over the interval.";
                }
                return conductivityOfMudInAverage;
            }
        }

        private static RealtimeData conductivityOfMudOutAverage;
        /// <summary>
        /// Average conductivity of the returning mud sample. Conductivity of the mud leaving the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("conductivity of mud out (average)")]
        public static RealtimeData ConductivityOfMudOutAverage
        {
            get 
            {
                if (conductivityOfMudOutAverage == null)
                {
                    conductivityOfMudOutAverage = new RealtimeData("conductivity of mud out (average)");
                    conductivityOfMudOutAverage.RealtimeMeasureClass = "conductivity";
                    conductivityOfMudOutAverage.Description = "Average conductivity of the returning mud sample. Conductivity of the mud leaving the hole, averaged over the interval.";
                }
                return conductivityOfMudOutAverage;
            }
        }

        private static RealtimeData connectionGasAverage;
        /// <summary>
        /// Average value of connection gas since the last record was generated.
        /// </summary>
        [EnumValueNameAttribute("connection gas (average)")]
        public static RealtimeData ConnectionGasAverage
        {
            get 
            {
                if (connectionGasAverage == null)
                {
                    connectionGasAverage = new RealtimeData("connection gas (average)");
                    connectionGasAverage.RealtimeMeasureClass = "volume per volume";
                    connectionGasAverage.Description = "Average value of connection gas since the last record was generated.";
                }
                return connectionGasAverage;
            }
        }

        private static RealtimeData connectionGasLast;
        /// <summary>
        /// Value of the last connection gas recorded.
        /// </summary>
        [EnumValueNameAttribute("connection gas (last)")]
        public static RealtimeData ConnectionGasLast
        {
            get 
            {
                if (connectionGasLast == null)
                {
                    connectionGasLast = new RealtimeData("connection gas (last)");
                    connectionGasLast.RealtimeMeasureClass = "volume per volume";
                    connectionGasLast.Description = "Value of the last connection gas recorded.";
                }
                return connectionGasLast;
            }
        }

        private static RealtimeData connectionGasMaximum;
        /// <summary>
        /// Maximum value of connection gas since the last record was generated.
        /// </summary>
        [EnumValueNameAttribute("connection gas (maximum)")]
        public static RealtimeData ConnectionGasMaximum
        {
            get 
            {
                if (connectionGasMaximum == null)
                {
                    connectionGasMaximum = new RealtimeData("connection gas (maximum)");
                    connectionGasMaximum.RealtimeMeasureClass = "volume per volume";
                    connectionGasMaximum.Description = "Maximum value of connection gas since the last record was generated.";
                }
                return connectionGasMaximum;
            }
        }

        private static RealtimeData connectionsDone;
        /// <summary>
        /// Number of connections made on the current trip.
        /// </summary>
        [EnumValueNameAttribute("connections done")]
        public static RealtimeData ConnectionsDone
        {
            get 
            {
                if (connectionsDone == null)
                {
                    connectionsDone = new RealtimeData("connections done");
                    connectionsDone.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    connectionsDone.Description = "Number of connections made on the current trip.";
                }
                return connectionsDone;
            }
        }

        private static RealtimeData connectionsRemaining;
        /// <summary>
        /// Number of connections remaining on the current trip.
        /// </summary>
        [EnumValueNameAttribute("connections remaining")]
        public static RealtimeData ConnectionsRemaining
        {
            get 
            {
                if (connectionsRemaining == null)
                {
                    connectionsRemaining = new RealtimeData("connections remaining");
                    connectionsRemaining.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    connectionsRemaining.Description = "Number of connections remaining on the current trip.";
                }
                return connectionsRemaining;
            }
        }

        private static RealtimeData costPerDistance;
        /// <summary>
        /// Cumulative per distance cost to drill from a specified point (i.e. normally the start of the current bit run) to the current depth.
        /// </summary>
        [EnumValueNameAttribute("cost per distance")]
        public static RealtimeData CostPerDistance
        {
            get 
            {
                if (costPerDistance == null)
                {
                    costPerDistance = new RealtimeData("cost per distance");
                    costPerDistance.RealtimeMeasureClass = "per length";
                    costPerDistance.Description = "Cumulative per distance cost to drill from a specified point (i.e. normally the start of the current bit run) to the current depth.";
                }
                return costPerDistance;
            }
        }

        private static RealtimeData costPerDistanceAverage;
        /// <summary>
        /// Average per distance cost to drill the interval since the last record was generated.
        /// </summary>
        [EnumValueNameAttribute("cost per distance (average)")]
        public static RealtimeData CostPerDistanceAverage
        {
            get 
            {
                if (costPerDistanceAverage == null)
                {
                    costPerDistanceAverage = new RealtimeData("cost per distance (average)");
                    costPerDistanceAverage.RealtimeMeasureClass = "per length";
                    costPerDistanceAverage.Description = "Average per distance cost to drill the interval since the last record was generated.";
                }
                return costPerDistanceAverage;
            }
        }

        private static RealtimeData cumulativeTimeOnBit;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("cumulative time on bit")]
        public static RealtimeData CumulativeTimeOnBit
        {
            get 
            {
                if (cumulativeTimeOnBit == null)
                {
                    cumulativeTimeOnBit = new RealtimeData("cumulative time on bit");
                    cumulativeTimeOnBit.RealtimeMeasureClass = "time";
                    cumulativeTimeOnBit.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return cumulativeTimeOnBit;
            }
        }

        private static RealtimeData density;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static RealtimeData Density
        {
            get 
            {
                if (density == null)
                {
                    density = new RealtimeData("density");
                    density.RealtimeMeasureClass = "density";
                    density.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return density;
            }
        }

        private static RealtimeData densityShale;
        /// <summary>
        /// The density of a representative shale sample taken from the cuttings, measured using a shale density kit.
        /// </summary>
        [EnumValueNameAttribute("density shale")]
        public static RealtimeData DensityShale
        {
            get 
            {
                if (densityShale == null)
                {
                    densityShale = new RealtimeData("density shale");
                    densityShale.RealtimeMeasureClass = "density";
                    densityShale.Description = "The density of a representative shale sample taken from the cuttings, measured using a shale density kit.";
                }
                return densityShale;
            }
        }

        private static RealtimeData diameterOfBit;
        /// <summary>
        /// Diameter of the center jet (nozzle). If bit has more than 5 jets, enter null here and enter Total Flow Area instead.
        /// </summary>
        [EnumValueNameAttribute("diameter of bit")]
        public static RealtimeData DiameterOfBit
        {
            get 
            {
                if (diameterOfBit == null)
                {
                    diameterOfBit = new RealtimeData("diameter of bit");
                    diameterOfBit.RealtimeMeasureClass = "length";
                    diameterOfBit.Description = "Diameter of the center jet (nozzle). If bit has more than 5 jets, enter null here and enter Total Flow Area instead.";
                }
                return diameterOfBit;
            }
        }

        private static RealtimeData distanceDrilledByBit;
        /// <summary>
        /// Total distance drilled for the current bit run. For a re run bit, this is only the distance drilled since the last full trip.
        /// </summary>
        [EnumValueNameAttribute("distance drilled by bit")]
        public static RealtimeData DistanceDrilledByBit
        {
            get 
            {
                if (distanceDrilledByBit == null)
                {
                    distanceDrilledByBit = new RealtimeData("distance drilled by bit");
                    distanceDrilledByBit.RealtimeMeasureClass = "length";
                    distanceDrilledByBit.Description = "Total distance drilled for the current bit run. For a re run bit, this is only the distance drilled since the last full trip.";
                }
                return distanceDrilledByBit;
            }
        }

        private static RealtimeData doglegSeverity;
        /// <summary>
        /// Rate of change of hole angle and/or direction evaluated between the current survey point and the next shallowest survey point (for the current pass number).
        /// </summary>
        [EnumValueNameAttribute("dogleg severity")]
        public static RealtimeData DoglegSeverity
        {
            get 
            {
                if (doglegSeverity == null)
                {
                    doglegSeverity = new RealtimeData("dogleg severity");
                    doglegSeverity.RealtimeMeasureClass = "angle per length";
                    doglegSeverity.Description = "Rate of change of hole angle and/or direction evaluated between the current survey point and the next shallowest survey point (for the current pass number).";
                }
                return doglegSeverity;
            }
        }

        private static RealtimeData drillingExponentCorrected;
        /// <summary>
        /// The calculated drilling exponent (corrected) at the time the record is generated. (Jordan and Shirley drilling exponent, with Rehm and McClendon correction for mud density/ECD)
        /// </summary>
        [EnumValueNameAttribute("drilling exponent (corrected)")]
        public static RealtimeData DrillingExponentCorrected
        {
            get 
            {
                if (drillingExponentCorrected == null)
                {
                    drillingExponentCorrected = new RealtimeData("drilling exponent (corrected)");
                    drillingExponentCorrected.RealtimeDataType = EnumValueRealtimeType.RealtimeNumeric;
                    drillingExponentCorrected.Description = "The calculated drilling exponent (corrected) at the time the record is generated. (Jordan and Shirley drilling exponent, with Rehm and McClendon correction for mud density/ECD)";
                }
                return drillingExponentCorrected;
            }
        }

        private static RealtimeData dstBottomHolePressure;
        /// <summary>
        /// Pressure recorded at the bottom of the hole. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST bottom hole pressure")]
        public static RealtimeData DstBottomHolePressure
        {
            get 
            {
                if (dstBottomHolePressure == null)
                {
                    dstBottomHolePressure = new RealtimeData("DST bottom hole pressure");
                    dstBottomHolePressure.RealtimeMeasureClass = "pressure";
                    dstBottomHolePressure.Description = "Pressure recorded at the bottom of the hole. (during a drill stem testing operation.)";
                }
                return dstBottomHolePressure;
            }
        }

        private static RealtimeData dstBottomHoleTemperature;
        /// <summary>
        /// Temperature recorded at the bottom of the hole. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST bottom hole temperature")]
        public static RealtimeData DstBottomHoleTemperature
        {
            get 
            {
                if (dstBottomHoleTemperature == null)
                {
                    dstBottomHoleTemperature = new RealtimeData("DST bottom hole temperature");
                    dstBottomHoleTemperature.RealtimeMeasureClass = "thermodynamic temperature";
                    dstBottomHoleTemperature.Description = "Temperature recorded at the bottom of the hole. (during a drill stem testing operation.)";
                }
                return dstBottomHoleTemperature;
            }
        }

        private static RealtimeData dstCumulativeGasProduction;
        /// <summary>
        /// Total gas production up to the time the record is generated. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST cumulative gas production")]
        public static RealtimeData DstCumulativeGasProduction
        {
            get 
            {
                if (dstCumulativeGasProduction == null)
                {
                    dstCumulativeGasProduction = new RealtimeData("DST cumulative gas production");
                    dstCumulativeGasProduction.RealtimeMeasureClass = "volume";
                    dstCumulativeGasProduction.Description = "Total gas production up to the time the record is generated. (during a drill stem testing operation.)";
                }
                return dstCumulativeGasProduction;
            }
        }

        private static RealtimeData dstCumulativeLiquidProduction;
        /// <summary>
        /// Total liquid production up to the time the record is generated. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST cumulative liquid production")]
        public static RealtimeData DstCumulativeLiquidProduction
        {
            get 
            {
                if (dstCumulativeLiquidProduction == null)
                {
                    dstCumulativeLiquidProduction = new RealtimeData("DST cumulative liquid production");
                    dstCumulativeLiquidProduction.RealtimeMeasureClass = "volume";
                    dstCumulativeLiquidProduction.Description = "Total liquid production up to the time the record is generated. (during a drill stem testing operation.)";
                }
                return dstCumulativeLiquidProduction;
            }
        }

        private static RealtimeData dstCumulativeTotalProduction;
        /// <summary>
        /// Total production up to the time the record is generated. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST cumulative total production")]
        public static RealtimeData DstCumulativeTotalProduction
        {
            get 
            {
                if (dstCumulativeTotalProduction == null)
                {
                    dstCumulativeTotalProduction = new RealtimeData("DST cumulative total production");
                    dstCumulativeTotalProduction.RealtimeMeasureClass = "volume";
                    dstCumulativeTotalProduction.Description = "Total production up to the time the record is generated. (during a drill stem testing operation.)";
                }
                return dstCumulativeTotalProduction;
            }
        }

        private static RealtimeData dstGasFlowRate;
        /// <summary>
        /// Measured gas flow rate at the time the record is generated. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST gas flow rate")]
        public static RealtimeData DstGasFlowRate
        {
            get 
            {
                if (dstGasFlowRate == null)
                {
                    dstGasFlowRate = new RealtimeData("DST gas flow rate");
                    dstGasFlowRate.RealtimeMeasureClass = "volume flow rate";
                    dstGasFlowRate.Description = "Measured gas flow rate at the time the record is generated. (during a drill stem testing operation.)";
                }
                return dstGasFlowRate;
            }
        }

        private static RealtimeData dstHydrogenSulfideAverage;
        /// <summary>
        /// Measured concentration of hydrogen sulfide at the time the record is generated. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST hydrogen sulfide (average)")]
        public static RealtimeData DstHydrogenSulfideAverage
        {
            get 
            {
                if (dstHydrogenSulfideAverage == null)
                {
                    dstHydrogenSulfideAverage = new RealtimeData("DST hydrogen sulfide (average)");
                    dstHydrogenSulfideAverage.RealtimeMeasureClass = "volume per volume";
                    dstHydrogenSulfideAverage.Description = "Measured concentration of hydrogen sulfide at the time the record is generated. (during a drill stem testing operation.)";
                }
                return dstHydrogenSulfideAverage;
            }
        }

        private static RealtimeData dstIdentifier;
        /// <summary>
        /// Identifier assigned to current DST. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST identifier")]
        public static RealtimeData DstIdentifier
        {
            get 
            {
                if (dstIdentifier == null)
                {
                    dstIdentifier = new RealtimeData("DST identifier");
                    dstIdentifier.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    dstIdentifier.Description = "Identifier assigned to current DST. (during a drill stem testing operation.)";
                }
                return dstIdentifier;
            }
        }

        private static RealtimeData dstLiquidFlowRate;
        /// <summary>
        /// Measured liquid flow rate at the time the record is generated. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST liquid flow rate")]
        public static RealtimeData DstLiquidFlowRate
        {
            get 
            {
                if (dstLiquidFlowRate == null)
                {
                    dstLiquidFlowRate = new RealtimeData("DST liquid flow rate");
                    dstLiquidFlowRate.RealtimeMeasureClass = "volume flow rate";
                    dstLiquidFlowRate.Description = "Measured liquid flow rate at the time the record is generated. (during a drill stem testing operation.)";
                }
                return dstLiquidFlowRate;
            }
        }

        private static RealtimeData dstSurfacePressureInCasing;
        /// <summary>
        /// Pressure recorded inside the casing at the surface. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST surface pressure in casing")]
        public static RealtimeData DstSurfacePressureInCasing
        {
            get 
            {
                if (dstSurfacePressureInCasing == null)
                {
                    dstSurfacePressureInCasing = new RealtimeData("DST surface pressure in casing");
                    dstSurfacePressureInCasing.RealtimeMeasureClass = "pressure";
                    dstSurfacePressureInCasing.Description = "Pressure recorded inside the casing at the surface. (during a drill stem testing operation.)";
                }
                return dstSurfacePressureInCasing;
            }
        }

        private static RealtimeData dstSurfacePressureInTubing;
        /// <summary>
        /// Pressure recorded inside the tubing at the surface. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST surface pressure in tubing")]
        public static RealtimeData DstSurfacePressureInTubing
        {
            get 
            {
                if (dstSurfacePressureInTubing == null)
                {
                    dstSurfacePressureInTubing = new RealtimeData("DST surface pressure in tubing");
                    dstSurfacePressureInTubing.RealtimeMeasureClass = "pressure";
                    dstSurfacePressureInTubing.Description = "Pressure recorded inside the tubing at the surface. (during a drill stem testing operation.)";
                }
                return dstSurfacePressureInTubing;
            }
        }

        private static RealtimeData dstSurfaceTemperatureInTubing;
        /// <summary>
        /// Temperature recorded inside the tubing at the surface. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST surface temperature in tubing")]
        public static RealtimeData DstSurfaceTemperatureInTubing
        {
            get 
            {
                if (dstSurfaceTemperatureInTubing == null)
                {
                    dstSurfaceTemperatureInTubing = new RealtimeData("DST surface temperature in tubing");
                    dstSurfaceTemperatureInTubing.RealtimeMeasureClass = "thermodynamic temperature";
                    dstSurfaceTemperatureInTubing.Description = "Temperature recorded inside the tubing at the surface. (during a drill stem testing operation.)";
                }
                return dstSurfaceTemperatureInTubing;
            }
        }

        private static RealtimeData dstToolTime;
        /// <summary>
        /// Time elapsed since the tool began running. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST tool time")]
        public static RealtimeData DstToolTime
        {
            get 
            {
                if (dstToolTime == null)
                {
                    dstToolTime = new RealtimeData("DST tool time");
                    dstToolTime.RealtimeMeasureClass = "time";
                    dstToolTime.Description = "Time elapsed since the tool began running. (during a drill stem testing operation.)";
                }
                return dstToolTime;
            }
        }

        private static RealtimeData dstTotalFlowRate;
        /// <summary>
        /// Measured total flow rate at the time the record is generated. (during a drill stem testing operation.)
        /// </summary>
        [EnumValueNameAttribute("DST total flow rate")]
        public static RealtimeData DstTotalFlowRate
        {
            get 
            {
                if (dstTotalFlowRate == null)
                {
                    dstTotalFlowRate = new RealtimeData("DST total flow rate");
                    dstTotalFlowRate.RealtimeMeasureClass = "volume flow rate";
                    dstTotalFlowRate.Description = "Measured total flow rate at the time the record is generated. (during a drill stem testing operation.)";
                }
                return dstTotalFlowRate;
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
                    dtsTemperature.RealtimeMeasureClass = "thermodynamic temperature";
                    dtsTemperature.Description = "The temperature that was calculated from Distributed Temperature Survey data.";
                }
                return dtsTemperature;
            }
        }

        private static RealtimeData ecdAtBitDepth;
        /// <summary>
        /// Effective circulating density, at the current bit measured depth, of the fluids currently in the hole.
        /// </summary>
        [EnumValueNameAttribute("ECD at bit depth")]
        public static RealtimeData EcdAtBitDepth
        {
            get 
            {
                if (ecdAtBitDepth == null)
                {
                    ecdAtBitDepth = new RealtimeData("ECD at bit depth");
                    ecdAtBitDepth.RealtimeMeasureClass = "density";
                    ecdAtBitDepth.Description = "Effective circulating density, at the current bit measured depth, of the fluids currently in the hole.";
                }
                return ecdAtBitDepth;
            }
        }

        private static RealtimeData ecdAtCasingShoeDepth;
        /// <summary>
        /// Effective circulating density, at the casing shoe measured depth, of the fluids currently in the hole.
        /// </summary>
        [EnumValueNameAttribute("ECD at casing shoe depth")]
        public static RealtimeData EcdAtCasingShoeDepth
        {
            get 
            {
                if (ecdAtCasingShoeDepth == null)
                {
                    ecdAtCasingShoeDepth = new RealtimeData("ECD at casing shoe depth");
                    ecdAtCasingShoeDepth.RealtimeMeasureClass = "density";
                    ecdAtCasingShoeDepth.Description = "Effective circulating density, at the casing shoe measured depth, of the fluids currently in the hole.";
                }
                return ecdAtCasingShoeDepth;
            }
        }

        private static RealtimeData ecdAtTotalDepth;
        /// <summary>
        /// Effective circulating density, at the current measured hole depth, of the fluids currently in the hole.
        /// </summary>
        [EnumValueNameAttribute("ECD at total depth")]
        public static RealtimeData EcdAtTotalDepth
        {
            get 
            {
                if (ecdAtTotalDepth == null)
                {
                    ecdAtTotalDepth = new RealtimeData("ECD at total depth");
                    ecdAtTotalDepth.RealtimeMeasureClass = "density";
                    ecdAtTotalDepth.Description = "Effective circulating density, at the current measured hole depth, of the fluids currently in the hole.";
                }
                return ecdAtTotalDepth;
            }
        }

        private static RealtimeData ecdFromMwdTool;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("ECD from MWD tool")]
        public static RealtimeData EcdFromMwdTool
        {
            get 
            {
                if (ecdFromMwdTool == null)
                {
                    ecdFromMwdTool = new RealtimeData("ECD from MWD tool");
                    ecdFromMwdTool.RealtimeMeasureClass = "density";
                    ecdFromMwdTool.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return ecdFromMwdTool;
            }
        }

        private static RealtimeData ethane;
        /// <summary>
        /// Ethane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("ethane")]
        public static RealtimeData Ethane
        {
            get 
            {
                if (ethane == null)
                {
                    ethane = new RealtimeData("ethane");
                    ethane.RealtimeMeasureClass = "volume per volume";
                    ethane.Description = "Ethane content of the sample. (cycle-based)";
                }
                return ethane;
            }
        }

        private static RealtimeData ethaneAverage;
        /// <summary>
        /// Average ethane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("ethane (average)")]
        public static RealtimeData EthaneAverage
        {
            get 
            {
                if (ethaneAverage == null)
                {
                    ethaneAverage = new RealtimeData("ethane (average)");
                    ethaneAverage.RealtimeMeasureClass = "volume per volume";
                    ethaneAverage.Description = "Average ethane content of the returning mud sample, over the interval.";
                }
                return ethaneAverage;
            }
        }

        private static RealtimeData ethaneMaximum;
        /// <summary>
        /// Maximum ethane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("ethane (maximum)")]
        public static RealtimeData EthaneMaximum
        {
            get 
            {
                if (ethaneMaximum == null)
                {
                    ethaneMaximum = new RealtimeData("ethane (maximum)");
                    ethaneMaximum.RealtimeMeasureClass = "volume per volume";
                    ethaneMaximum.Description = "Maximum ethane content of the returning mud sample, over the interval.";
                }
                return ethaneMaximum;
            }
        }

        private static RealtimeData ethaneMinimum;
        /// <summary>
        /// Minimum ethane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("ethane (minimum)")]
        public static RealtimeData EthaneMinimum
        {
            get 
            {
                if (ethaneMinimum == null)
                {
                    ethaneMinimum = new RealtimeData("ethane (minimum)");
                    ethaneMinimum.RealtimeMeasureClass = "volume per volume";
                    ethaneMinimum.Description = "Minimum ethane content of the returning mud sample, over the interval.";
                }
                return ethaneMinimum;
            }
        }

        private static RealtimeData fillVolumeExpected;
        /// <summary>
        /// Calculated cumulative volume of mud which should have been gained or lost from the trip tank on the current trip.
        /// </summary>
        [EnumValueNameAttribute("fill volume (expected)")]
        public static RealtimeData FillVolumeExpected
        {
            get 
            {
                if (fillVolumeExpected == null)
                {
                    fillVolumeExpected = new RealtimeData("fill volume (expected)");
                    fillVolumeExpected.RealtimeMeasureClass = "volume";
                    fillVolumeExpected.Description = "Calculated cumulative volume of mud which should have been gained or lost from the trip tank on the current trip.";
                }
                return fillVolumeExpected;
            }
        }

        private static RealtimeData fillVolumeObserved;
        /// <summary>
        /// Measured volume of mud gained in, or lost from, the trip tank due to the movement of the current stand or joint.
        /// </summary>
        [EnumValueNameAttribute("fill volume (observed)")]
        public static RealtimeData FillVolumeObserved
        {
            get 
            {
                if (fillVolumeObserved == null)
                {
                    fillVolumeObserved = new RealtimeData("fill volume (observed)");
                    fillVolumeObserved.RealtimeMeasureClass = "volume";
                    fillVolumeObserved.Description = "Measured volume of mud gained in, or lost from, the trip tank due to the movement of the current stand or joint.";
                }
                return fillVolumeObserved;
            }
        }

        private static RealtimeData fillVolumeTotalExpected;
        /// <summary>
        /// Calculated volume per stand or joint which should be gained or lost from the trip tank due to the movement of the pipe.
        /// </summary>
        [EnumValueNameAttribute("fill volume total (expected)")]
        public static RealtimeData FillVolumeTotalExpected
        {
            get 
            {
                if (fillVolumeTotalExpected == null)
                {
                    fillVolumeTotalExpected = new RealtimeData("fill volume total (expected)");
                    fillVolumeTotalExpected.RealtimeMeasureClass = "volume";
                    fillVolumeTotalExpected.Description = "Calculated volume per stand or joint which should be gained or lost from the trip tank due to the movement of the pipe.";
                }
                return fillVolumeTotalExpected;
            }
        }

        private static RealtimeData fillVolumeTotalObserved;
        /// <summary>
        /// Cumulative volume of mud gained or lost from the trip tank on the current trip.
        /// </summary>
        [EnumValueNameAttribute("fill volume total (observed)")]
        public static RealtimeData FillVolumeTotalObserved
        {
            get 
            {
                if (fillVolumeTotalObserved == null)
                {
                    fillVolumeTotalObserved = new RealtimeData("fill volume total (observed)");
                    fillVolumeTotalObserved.RealtimeMeasureClass = "volume";
                    fillVolumeTotalObserved.Description = "Cumulative volume of mud gained or lost from the trip tank on the current trip.";
                }
                return fillVolumeTotalObserved;
            }
        }

        private static RealtimeData flowInRelative;
        /// <summary>
        /// Flow into the hole measured by a paddle or target type sensor and averaged over the interval, where 0 % = no flow, 100 % = full deflection of the sensor.
        /// </summary>
        [EnumValueNameAttribute("flow in (relative)")]
        public static RealtimeData FlowInRelative
        {
            get 
            {
                if (flowInRelative == null)
                {
                    flowInRelative = new RealtimeData("flow in (relative)");
                    flowInRelative.RealtimeMeasureClass = "volume per volume";
                    flowInRelative.Description = "Flow into the hole measured by a paddle or target type sensor and averaged over the interval, where 0 % = no flow, 100 % = full deflection of the sensor.";
                }
                return flowInRelative;
            }
        }

        private static RealtimeData flowOutRelative;
        /// <summary>
        /// Flow out of hole measured by a paddle or target type sensor and averaged over the interval, where 0 % = no flow, 100 % = full deflection of the sensor.
        /// </summary>
        [EnumValueNameAttribute("flow out (relative)")]
        public static RealtimeData FlowOutRelative
        {
            get 
            {
                if (flowOutRelative == null)
                {
                    flowOutRelative = new RealtimeData("flow out (relative)");
                    flowOutRelative.RealtimeMeasureClass = "volume per volume";
                    flowOutRelative.Description = "Flow out of hole measured by a paddle or target type sensor and averaged over the interval, where 0 % = no flow, 100 % = full deflection of the sensor.";
                }
                return flowOutRelative;
            }
        }

        private static RealtimeData flowRateInAverage;
        /// <summary>
        /// Measured/calculated flow rate of the mud entering the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("flow rate in (average)")]
        public static RealtimeData FlowRateInAverage
        {
            get 
            {
                if (flowRateInAverage == null)
                {
                    flowRateInAverage = new RealtimeData("flow rate in (average)");
                    flowRateInAverage.RealtimeMeasureClass = "volume flow rate";
                    flowRateInAverage.Description = "Measured/calculated flow rate of the mud entering the hole, averaged over the interval.";
                }
                return flowRateInAverage;
            }
        }

        private static RealtimeData flowRateOutAverage;
        /// <summary>
        /// Measured flow rate of the mud leaving the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("flow rate out (average)")]
        public static RealtimeData FlowRateOutAverage
        {
            get 
            {
                if (flowRateOutAverage == null)
                {
                    flowRateOutAverage = new RealtimeData("flow rate out (average)");
                    flowRateOutAverage.RealtimeMeasureClass = "volume flow rate";
                    flowRateOutAverage.Description = "Measured flow rate of the mud leaving the hole, averaged over the interval.";
                }
                return flowRateOutAverage;
            }
        }

        private static RealtimeData formationFracturePressureGradient;
        /// <summary>
        /// Estimated formation fracture pressure gradient at this depth, expressed as equivalent mud density.
        /// </summary>
        [EnumValueNameAttribute("formation fracture pressure gradient")]
        public static RealtimeData FormationFracturePressureGradient
        {
            get 
            {
                if (formationFracturePressureGradient == null)
                {
                    formationFracturePressureGradient = new RealtimeData("formation fracture pressure gradient");
                    formationFracturePressureGradient.RealtimeMeasureClass = "force per volume";
                    formationFracturePressureGradient.Description = "Estimated formation fracture pressure gradient at this depth, expressed as equivalent mud density.";
                }
                return formationFracturePressureGradient;
            }
        }

        private static RealtimeData formationPorePressureGradient;
        /// <summary>
        /// Estimated formation pore pressure gradient at this depth, expressed as equivalent mud density.
        /// </summary>
        [EnumValueNameAttribute("formation pore pressure gradient")]
        public static RealtimeData FormationPorePressureGradient
        {
            get 
            {
                if (formationPorePressureGradient == null)
                {
                    formationPorePressureGradient = new RealtimeData("formation pore pressure gradient");
                    formationPorePressureGradient.RealtimeMeasureClass = "force per volume";
                    formationPorePressureGradient.Description = "Estimated formation pore pressure gradient at this depth, expressed as equivalent mud density.";
                }
                return formationPorePressureGradient;
            }
        }

        private static RealtimeData gammaRay;
        /// <summary>
        /// Value of a Porosity sensor.
        /// </summary>
        [EnumValueNameAttribute("gamma ray")]
        public static RealtimeData GammaRay
        {
            get 
            {
                if (gammaRay == null)
                {
                    gammaRay = new RealtimeData("gamma ray");
                    gammaRay.RealtimeMeasureClass = "gamma ray API unit";
                    gammaRay.Description = "Value of a Porosity sensor.";
                }
                return gammaRay;
            }
        }

        private static RealtimeData gammaRayCorrected;
        /// <summary>
        /// Value of a Gamma Ray sensor corrected for borehole effects (normalized).
        /// </summary>
        [EnumValueNameAttribute("gamma ray (corrected)")]
        public static RealtimeData GammaRayCorrected
        {
            get 
            {
                if (gammaRayCorrected == null)
                {
                    gammaRayCorrected = new RealtimeData("gamma ray (corrected)");
                    gammaRayCorrected.RealtimeMeasureClass = "gamma ray API unit";
                    gammaRayCorrected.Description = "Value of a Gamma Ray sensor corrected for borehole effects (normalized).";
                }
                return gammaRayCorrected;
            }
        }

        private static RealtimeData gasTotalAverage;
        /// <summary>
        /// Total combustible gas content in the returning mud sample, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("gas total (average)")]
        public static RealtimeData GasTotalAverage
        {
            get 
            {
                if (gasTotalAverage == null)
                {
                    gasTotalAverage = new RealtimeData("gas total (average)");
                    gasTotalAverage.RealtimeMeasureClass = "volume per volume";
                    gasTotalAverage.Description = "Total combustible gas content in the returning mud sample, averaged over the interval.";
                }
                return gasTotalAverage;
            }
        }

        private static RealtimeData gravityToolFace;
        /// <summary>
        /// Gravity tool face measured by the directional sensor.
        /// </summary>
        [EnumValueNameAttribute("gravity tool face")]
        public static RealtimeData GravityToolFace
        {
            get 
            {
                if (gravityToolFace == null)
                {
                    gravityToolFace = new RealtimeData("gravity tool face");
                    gravityToolFace.RealtimeMeasureClass = "plane angle";
                    gravityToolFace.Description = "Gravity tool face measured by the directional sensor.";
                }
                return gravityToolFace;
            }
        }

        private static RealtimeData gravityXaxisCorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("gravity X-axis (corrected)")]
        public static RealtimeData GravityXaxisCorrected
        {
            get 
            {
                if (gravityXaxisCorrected == null)
                {
                    gravityXaxisCorrected = new RealtimeData("gravity X-axis (corrected)");
                    gravityXaxisCorrected.RealtimeMeasureClass = "acceleration linear";
                    gravityXaxisCorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return gravityXaxisCorrected;
            }
        }

        private static RealtimeData gravityXaxisUncorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("gravity X-axis (uncorrected)")]
        public static RealtimeData GravityXaxisUncorrected
        {
            get 
            {
                if (gravityXaxisUncorrected == null)
                {
                    gravityXaxisUncorrected = new RealtimeData("gravity X-axis (uncorrected)");
                    gravityXaxisUncorrected.RealtimeMeasureClass = "acceleration linear";
                    gravityXaxisUncorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return gravityXaxisUncorrected;
            }
        }

        private static RealtimeData gravityYaxisCorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("gravity Y-axis (corrected)")]
        public static RealtimeData GravityYaxisCorrected
        {
            get 
            {
                if (gravityYaxisCorrected == null)
                {
                    gravityYaxisCorrected = new RealtimeData("gravity Y-axis (corrected)");
                    gravityYaxisCorrected.RealtimeMeasureClass = "acceleration linear";
                    gravityYaxisCorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return gravityYaxisCorrected;
            }
        }

        private static RealtimeData gravityYaxisUncorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("gravity Y-axis (uncorrected)")]
        public static RealtimeData GravityYaxisUncorrected
        {
            get 
            {
                if (gravityYaxisUncorrected == null)
                {
                    gravityYaxisUncorrected = new RealtimeData("gravity Y-axis (uncorrected)");
                    gravityYaxisUncorrected.RealtimeMeasureClass = "acceleration linear";
                    gravityYaxisUncorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return gravityYaxisUncorrected;
            }
        }

        private static RealtimeData gravityZaxisCorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("gravity Z-axis (corrected)")]
        public static RealtimeData GravityZaxisCorrected
        {
            get 
            {
                if (gravityZaxisCorrected == null)
                {
                    gravityZaxisCorrected = new RealtimeData("gravity Z-axis (corrected)");
                    gravityZaxisCorrected.RealtimeMeasureClass = "acceleration linear";
                    gravityZaxisCorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
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
                    gravityZaxisUncorrected.RealtimeMeasureClass = "acceleration linear";
                    gravityZaxisUncorrected.Description = "Z axis gravity uncorrected";
                }
                return gravityZaxisUncorrected;
            }
        }

        private static RealtimeData hookloadAverage;
        /// <summary>
        /// Measured hookload, averaged over the specified interval or connection.
        /// </summary>
        [EnumValueNameAttribute("hookload (average)")]
        public static RealtimeData HookloadAverage
        {
            get 
            {
                if (hookloadAverage == null)
                {
                    hookloadAverage = new RealtimeData("hookload (average)");
                    hookloadAverage.RealtimeMeasureClass = "force";
                    hookloadAverage.Description = "Measured hookload, averaged over the specified interval or connection.";
                }
                return hookloadAverage;
            }
        }

        private static RealtimeData hookloadMaximum;
        /// <summary>
        /// Maximum hookload, measured over the specified interval or connection.
        /// </summary>
        [EnumValueNameAttribute("hookload (maximum)")]
        public static RealtimeData HookloadMaximum
        {
            get 
            {
                if (hookloadMaximum == null)
                {
                    hookloadMaximum = new RealtimeData("hookload (maximum)");
                    hookloadMaximum.RealtimeMeasureClass = "force";
                    hookloadMaximum.Description = "Maximum hookload, measured over the specified interval or connection.";
                }
                return hookloadMaximum;
            }
        }

        private static RealtimeData hookloadMinimum;
        /// <summary>
        /// Minimum hookload, measured over the specified interval or connection, while not in slips.
        /// </summary>
        [EnumValueNameAttribute("hookload (minimum)")]
        public static RealtimeData HookloadMinimum
        {
            get 
            {
                if (hookloadMinimum == null)
                {
                    hookloadMinimum = new RealtimeData("hookload (minimum)");
                    hookloadMinimum.RealtimeMeasureClass = "force";
                    hookloadMinimum.Description = "Minimum hookload, measured over the specified interval or connection, while not in slips.";
                }
                return hookloadMinimum;
            }
        }

        private static RealtimeData hydraulicPowerOfBit;
        /// <summary>
        /// Calculated hydraulic horsepower generated by the flow of fluid through the bit nozzles.
        /// </summary>
        [EnumValueNameAttribute("hydraulic power of bit")]
        public static RealtimeData HydraulicPowerOfBit
        {
            get 
            {
                if (hydraulicPowerOfBit == null)
                {
                    hydraulicPowerOfBit = new RealtimeData("hydraulic power of bit");
                    hydraulicPowerOfBit.RealtimeMeasureClass = "power";
                    hydraulicPowerOfBit.Description = "Calculated hydraulic horsepower generated by the flow of fluid through the bit nozzles.";
                }
                return hydraulicPowerOfBit;
            }
        }

        private static RealtimeData hydraulicPowerOfPump;
        /// <summary>
        /// Hydraulic power output of the pumps.
        /// </summary>
        [EnumValueNameAttribute("hydraulic power of pump")]
        public static RealtimeData HydraulicPowerOfPump
        {
            get 
            {
                if (hydraulicPowerOfPump == null)
                {
                    hydraulicPowerOfPump = new RealtimeData("hydraulic power of pump");
                    hydraulicPowerOfPump.RealtimeMeasureClass = "power";
                    hydraulicPowerOfPump.Description = "Hydraulic power output of the pumps.";
                }
                return hydraulicPowerOfPump;
            }
        }

        private static RealtimeData hydraulicPowerPerAreaOfBit;
        /// <summary>
        /// Total hydraulic horsepower, as in 'hydraulic power of bit', divided by the cross sectional area of the bit.
        /// </summary>
        [EnumValueNameAttribute("hydraulic power per area of bit")]
        public static RealtimeData HydraulicPowerPerAreaOfBit
        {
            get 
            {
                if (hydraulicPowerPerAreaOfBit == null)
                {
                    hydraulicPowerPerAreaOfBit = new RealtimeData("hydraulic power per area of bit");
                    hydraulicPowerPerAreaOfBit.RealtimeMeasureClass = "irradiance";
                    hydraulicPowerPerAreaOfBit.Description = "Total hydraulic horsepower, as in 'hydraulic power of bit', divided by the cross sectional area of the bit.";
                }
                return hydraulicPowerPerAreaOfBit;
            }
        }

        private static RealtimeData hydrogenSulfide;
        /// <summary>
        /// Measured concentration of hydrogen sulfide at the time the record is generated. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide")]
        public static RealtimeData HydrogenSulfide
        {
            get 
            {
                if (hydrogenSulfide == null)
                {
                    hydrogenSulfide = new RealtimeData("hydrogen sulfide");
                    hydrogenSulfide.RealtimeMeasureClass = "volume per volume";
                    hydrogenSulfide.Description = "Measured concentration of hydrogen sulfide at the time the record is generated. (cycle-based)";
                }
                return hydrogenSulfide;
            }
        }

        private static RealtimeData hydrogenSulfideAverage;
        /// <summary>
        /// Hydrogen sulfide content of the returning mud sample, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (average)")]
        public static RealtimeData HydrogenSulfideAverage
        {
            get 
            {
                if (hydrogenSulfideAverage == null)
                {
                    hydrogenSulfideAverage = new RealtimeData("hydrogen sulfide (average)");
                    hydrogenSulfideAverage.RealtimeMeasureClass = "volume per volume";
                    hydrogenSulfideAverage.Description = "Hydrogen sulfide content of the returning mud sample, averaged over the interval.";
                }
                return hydrogenSulfideAverage;
            }
        }

        private static RealtimeData hydrogenSulfideMaximum;
        /// <summary>
        /// Maximum hydrogen sulfide content of the returning mud sample, measured over the interval.
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (maximum)")]
        public static RealtimeData HydrogenSulfideMaximum
        {
            get 
            {
                if (hydrogenSulfideMaximum == null)
                {
                    hydrogenSulfideMaximum = new RealtimeData("hydrogen sulfide (maximum)");
                    hydrogenSulfideMaximum.RealtimeMeasureClass = "volume per volume";
                    hydrogenSulfideMaximum.Description = "Maximum hydrogen sulfide content of the returning mud sample, measured over the interval.";
                }
                return hydrogenSulfideMaximum;
            }
        }

        private static RealtimeData hydrogenSulfideMinimum;
        /// <summary>
        /// Hydrogen sulfide content of the returning mud sample, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide (minimum)")]
        public static RealtimeData HydrogenSulfideMinimum
        {
            get 
            {
                if (hydrogenSulfideMinimum == null)
                {
                    hydrogenSulfideMinimum = new RealtimeData("hydrogen sulfide (minimum)");
                    hydrogenSulfideMinimum.RealtimeMeasureClass = "volume per volume";
                    hydrogenSulfideMinimum.Description = "Hydrogen sulfide content of the returning mud sample, averaged over the interval.";
                }
                return hydrogenSulfideMinimum;
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
                    inclinationCorrected.RealtimeMeasureClass = "plane angle";
                    inclinationCorrected.Description = "MWD inclination (corrected)";
                }
                return inclinationCorrected;
            }
        }

        private static RealtimeData inclinationUncorrected;
        /// <summary>
        /// Borehole inclination measured by the directional sensor.
        /// </summary>
        [EnumValueNameAttribute("inclination (uncorrected)")]
        public static RealtimeData InclinationUncorrected
        {
            get 
            {
                if (inclinationUncorrected == null)
                {
                    inclinationUncorrected = new RealtimeData("inclination (uncorrected)");
                    inclinationUncorrected.RealtimeMeasureClass = "plane angle";
                    inclinationUncorrected.Description = "Borehole inclination measured by the directional sensor.";
                }
                return inclinationUncorrected;
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
                    inclinationNearBit.RealtimeMeasureClass = "plane angle";
                    inclinationNearBit.Description = "Near-bit inclination";
                }
                return inclinationNearBit;
            }
        }

        private static RealtimeData inslipsStatus;
        /// <summary>
        /// In- or Out-of slips condition. 'I' indicates that the slips are set, 'O' indicates that the slips are out, at the time that the record is generated.
        /// </summary>
        [EnumValueNameAttribute("in-slips status")]
        public static RealtimeData InslipsStatus
        {
            get 
            {
                if (inslipsStatus == null)
                {
                    inslipsStatus = new RealtimeData("in-slips status");
                    inslipsStatus.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    inslipsStatus.Description = "In- or Out-of slips condition. 'I' indicates that the slips are set, 'O' indicates that the slips are out, at the time that the record is generated.";
                }
                return inslipsStatus;
            }
        }

        private static RealtimeData isobutane;
        /// <summary>
        /// Iso Butane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-butane")]
        public static RealtimeData Isobutane
        {
            get 
            {
                if (isobutane == null)
                {
                    isobutane = new RealtimeData("iso-butane");
                    isobutane.RealtimeMeasureClass = "volume per volume";
                    isobutane.Description = "Iso Butane content of the sample. (cycle-based)";
                }
                return isobutane;
            }
        }

        private static RealtimeData isobutaneAverage;
        /// <summary>
        /// Average iso butane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-butane (average)")]
        public static RealtimeData IsobutaneAverage
        {
            get 
            {
                if (isobutaneAverage == null)
                {
                    isobutaneAverage = new RealtimeData("iso-butane (average)");
                    isobutaneAverage.RealtimeMeasureClass = "volume per volume";
                    isobutaneAverage.Description = "Average iso butane content of the returning mud sample, over the interval.";
                }
                return isobutaneAverage;
            }
        }

        private static RealtimeData isobutaneMaximum;
        /// <summary>
        /// Maximum iso butane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-butane (maximum)")]
        public static RealtimeData IsobutaneMaximum
        {
            get 
            {
                if (isobutaneMaximum == null)
                {
                    isobutaneMaximum = new RealtimeData("iso-butane (maximum)");
                    isobutaneMaximum.RealtimeMeasureClass = "volume per volume";
                    isobutaneMaximum.Description = "Maximum iso butane content of the returning mud sample, over the interval.";
                }
                return isobutaneMaximum;
            }
        }

        private static RealtimeData isobutaneMinimum;
        /// <summary>
        /// Minimum iso butane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-butane (minimum)")]
        public static RealtimeData IsobutaneMinimum
        {
            get 
            {
                if (isobutaneMinimum == null)
                {
                    isobutaneMinimum = new RealtimeData("iso-butane (minimum)");
                    isobutaneMinimum.RealtimeMeasureClass = "volume per volume";
                    isobutaneMinimum.Description = "Minimum iso butane content of the returning mud sample, over the interval.";
                }
                return isobutaneMinimum;
            }
        }

        private static RealtimeData isohexane;
        /// <summary>
        /// Iso Hexane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-hexane")]
        public static RealtimeData Isohexane
        {
            get 
            {
                if (isohexane == null)
                {
                    isohexane = new RealtimeData("iso-hexane");
                    isohexane.RealtimeMeasureClass = "volume per volume";
                    isohexane.Description = "Iso Hexane content of the sample. (cycle-based)";
                }
                return isohexane;
            }
        }

        private static RealtimeData isohexaneAverage;
        /// <summary>
        /// Average iso hexane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (average)")]
        public static RealtimeData IsohexaneAverage
        {
            get 
            {
                if (isohexaneAverage == null)
                {
                    isohexaneAverage = new RealtimeData("iso-hexane (average)");
                    isohexaneAverage.RealtimeMeasureClass = "volume per volume";
                    isohexaneAverage.Description = "Average iso hexane content of the returning mud sample, over the interval.";
                }
                return isohexaneAverage;
            }
        }

        private static RealtimeData isohexaneMaximum;
        /// <summary>
        /// Maximum iso hexane content of the returning mud sample, over the interval
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (maximum)")]
        public static RealtimeData IsohexaneMaximum
        {
            get 
            {
                if (isohexaneMaximum == null)
                {
                    isohexaneMaximum = new RealtimeData("iso-hexane (maximum)");
                    isohexaneMaximum.RealtimeMeasureClass = "volume per volume";
                    isohexaneMaximum.Description = "Maximum iso hexane content of the returning mud sample, over the interval";
                }
                return isohexaneMaximum;
            }
        }

        private static RealtimeData isohexaneMinimum;
        /// <summary>
        /// Minimum iso hexane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-hexane (minimum)")]
        public static RealtimeData IsohexaneMinimum
        {
            get 
            {
                if (isohexaneMinimum == null)
                {
                    isohexaneMinimum = new RealtimeData("iso-hexane (minimum)");
                    isohexaneMinimum.RealtimeMeasureClass = "volume per volume";
                    isohexaneMinimum.Description = "Minimum iso hexane content of the returning mud sample, over the interval.";
                }
                return isohexaneMinimum;
            }
        }

        private static RealtimeData isopentane;
        /// <summary>
        /// Iso Pentane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("iso-pentane")]
        public static RealtimeData Isopentane
        {
            get 
            {
                if (isopentane == null)
                {
                    isopentane = new RealtimeData("iso-pentane");
                    isopentane.RealtimeMeasureClass = "volume per volume";
                    isopentane.Description = "Iso Pentane content of the sample. (cycle-based)";
                }
                return isopentane;
            }
        }

        private static RealtimeData isopentaneAverage;
        /// <summary>
        /// Average iso pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (average)")]
        public static RealtimeData IsopentaneAverage
        {
            get 
            {
                if (isopentaneAverage == null)
                {
                    isopentaneAverage = new RealtimeData("iso-pentane (average)");
                    isopentaneAverage.RealtimeMeasureClass = "volume per volume";
                    isopentaneAverage.Description = "Average iso pentane content of the returning mud sample, over the interval.";
                }
                return isopentaneAverage;
            }
        }

        private static RealtimeData isopentaneMaximum;
        /// <summary>
        /// Maximum iso pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (maximum)")]
        public static RealtimeData IsopentaneMaximum
        {
            get 
            {
                if (isopentaneMaximum == null)
                {
                    isopentaneMaximum = new RealtimeData("iso-pentane (maximum)");
                    isopentaneMaximum.RealtimeMeasureClass = "volume per volume";
                    isopentaneMaximum.Description = "Maximum iso pentane content of the returning mud sample, over the interval.";
                }
                return isopentaneMaximum;
            }
        }

        private static RealtimeData isopentaneMinimum;
        /// <summary>
        /// Minimum iso pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("iso-pentane (minimum)")]
        public static RealtimeData IsopentaneMinimum
        {
            get 
            {
                if (isopentaneMinimum == null)
                {
                    isopentaneMinimum = new RealtimeData("iso-pentane (minimum)");
                    isopentaneMinimum.RealtimeMeasureClass = "volume per volume";
                    isopentaneMinimum.Description = "Minimum iso pentane content of the returning mud sample, over the interval.";
                }
                return isopentaneMinimum;
            }
        }

        private static RealtimeData kickTolerance;
        /// <summary>
        /// Estimated kick tolerance at this depth, based on zero influx and no trip margin (unless specified by the Operator).
        /// </summary>
        [EnumValueNameAttribute("kick tolerance")]
        public static RealtimeData KickTolerance
        {
            get 
            {
                if (kickTolerance == null)
                {
                    kickTolerance = new RealtimeData("kick tolerance");
                    kickTolerance.RealtimeMeasureClass = "force per volume";
                    kickTolerance.Description = "Estimated kick tolerance at this depth, based on zero influx and no trip margin (unless specified by the Operator).";
                }
                return kickTolerance;
            }
        }

        private static RealtimeData lagStrokes;
        /// <summary>
        /// Total strokes (based on the pump(s) currently operating) being used for lagging cuttings, using either the calculation or tracer method.
        /// </summary>
        [EnumValueNameAttribute("lag strokes")]
        public static RealtimeData LagStrokes
        {
            get 
            {
                if (lagStrokes == null)
                {
                    lagStrokes = new RealtimeData("lag strokes");
                    lagStrokes.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    lagStrokes.Description = "Total strokes (based on the pump(s) currently operating) being used for lagging cuttings, using either the calculation or tracer method.";
                }
                return lagStrokes;
            }
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
                    lengthAlongFiber.RealtimeMeasureClass = "length";
                    lengthAlongFiber.Description = "The position along the length of a DTS fiber.";
                }
                return lengthAlongFiber;
            }
        }

        private static RealtimeData lithologyFlag;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("lithology flag")]
        public static RealtimeData LithologyFlag
        {
            get 
            {
                if (lithologyFlag == null)
                {
                    lithologyFlag = new RealtimeData("lithology flag");
                    lithologyFlag.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    lithologyFlag.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return lithologyFlag;
            }
        }

        private static RealtimeData magneticToolFace;
        /// <summary>
        /// Magnetic tool face measured by the directional sensor.
        /// </summary>
        [EnumValueNameAttribute("magnetic tool face")]
        public static RealtimeData MagneticToolFace
        {
            get 
            {
                if (magneticToolFace == null)
                {
                    magneticToolFace = new RealtimeData("magnetic tool face");
                    magneticToolFace.RealtimeMeasureClass = "plane angle";
                    magneticToolFace.Description = "Magnetic tool face measured by the directional sensor.";
                }
                return magneticToolFace;
            }
        }

        private static RealtimeData measuredDepthOfCasing;
        /// <summary>
        /// Measured depth of the casing shoe being cemented.
        /// </summary>
        [EnumValueNameAttribute("measured depth of casing")]
        public static RealtimeData MeasuredDepthOfCasing
        {
            get 
            {
                if (measuredDepthOfCasing == null)
                {
                    measuredDepthOfCasing = new RealtimeData("measured depth of casing");
                    measuredDepthOfCasing.RealtimeMeasureClass = "length";
                    measuredDepthOfCasing.Description = "Measured depth of the casing shoe being cemented.";
                }
                return measuredDepthOfCasing;
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
                    measuredDepthOfDiverterTool.RealtimeMeasureClass = "length";
                    measuredDepthOfDiverterTool.Description = "Cementing depth to DV tool";
                }
                return measuredDepthOfDiverterTool;
            }
        }

        private static RealtimeData measuredDepthOfDstBottom;
        /// <summary>
        /// Measured depth of bottom perforations, or depth of bottom packer in an open hole DST.
        /// </summary>
        [EnumValueNameAttribute("measured depth of DST bottom")]
        public static RealtimeData MeasuredDepthOfDstBottom
        {
            get 
            {
                if (measuredDepthOfDstBottom == null)
                {
                    measuredDepthOfDstBottom = new RealtimeData("measured depth of DST bottom");
                    measuredDepthOfDstBottom.RealtimeMeasureClass = "length";
                    measuredDepthOfDstBottom.Description = "Measured depth of bottom perforations, or depth of bottom packer in an open hole DST.";
                }
                return measuredDepthOfDstBottom;
            }
        }

        private static RealtimeData measuredDepthOfDstTop;
        /// <summary>
        /// Measured depth of top perforations, or depth of top packer in an open hole DST.
        /// </summary>
        [EnumValueNameAttribute("measured depth of DST top")]
        public static RealtimeData MeasuredDepthOfDstTop
        {
            get 
            {
                if (measuredDepthOfDstTop == null)
                {
                    measuredDepthOfDstTop = new RealtimeData("measured depth of DST top");
                    measuredDepthOfDstTop.RealtimeMeasureClass = "length";
                    measuredDepthOfDstTop.Description = "Measured depth of top perforations, or depth of top packer in an open hole DST.";
                }
                return measuredDepthOfDstTop;
            }
        }

        private static RealtimeData measuredDepthOfHole;
        /// <summary>
        /// Measured depth of the hole at the time the record is generated.
        /// </summary>
        [EnumValueNameAttribute("measured depth of hole")]
        public static RealtimeData MeasuredDepthOfHole
        {
            get 
            {
                if (measuredDepthOfHole == null)
                {
                    measuredDepthOfHole = new RealtimeData("measured depth of hole");
                    measuredDepthOfHole.RealtimeMeasureClass = "length";
                    measuredDepthOfHole.Description = "Measured depth of the hole at the time the record is generated.";
                }
                return measuredDepthOfHole;
            }
        }

        private static RealtimeData measuredDepthOfReturns;
        /// <summary>
        /// Measured hole depth (lagged depth) corresponding to the origin of the returning mud/cuttings sample.
        /// </summary>
        [EnumValueNameAttribute("measured depth of returns")]
        public static RealtimeData MeasuredDepthOfReturns
        {
            get 
            {
                if (measuredDepthOfReturns == null)
                {
                    measuredDepthOfReturns = new RealtimeData("measured depth of returns");
                    measuredDepthOfReturns.RealtimeMeasureClass = "length";
                    measuredDepthOfReturns.Description = "Measured hole depth (lagged depth) corresponding to the origin of the returning mud/cuttings sample.";
                }
                return measuredDepthOfReturns;
            }
        }

        private static RealtimeData methane;
        /// <summary>
        /// Methane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("methane")]
        public static RealtimeData Methane
        {
            get 
            {
                if (methane == null)
                {
                    methane = new RealtimeData("methane");
                    methane.RealtimeMeasureClass = "volume per volume";
                    methane.Description = "Methane content of the sample. (cycle-based)";
                }
                return methane;
            }
        }

        private static RealtimeData methaneAverage;
        /// <summary>
        /// Average methane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("methane (average)")]
        public static RealtimeData MethaneAverage
        {
            get 
            {
                if (methaneAverage == null)
                {
                    methaneAverage = new RealtimeData("methane (average)");
                    methaneAverage.RealtimeMeasureClass = "volume per volume";
                    methaneAverage.Description = "Average methane content of the returning mud sample, over the interval.";
                }
                return methaneAverage;
            }
        }

        private static RealtimeData methaneMaximum;
        /// <summary>
        /// Maximum methane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("methane (maximum)")]
        public static RealtimeData MethaneMaximum
        {
            get 
            {
                if (methaneMaximum == null)
                {
                    methaneMaximum = new RealtimeData("methane (maximum)");
                    methaneMaximum.RealtimeMeasureClass = "volume per volume";
                    methaneMaximum.Description = "Maximum methane content of the returning mud sample, over the interval.";
                }
                return methaneMaximum;
            }
        }

        private static RealtimeData methaneMinimum;
        /// <summary>
        /// Minimum methane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("methane (minimum)")]
        public static RealtimeData MethaneMinimum
        {
            get 
            {
                if (methaneMinimum == null)
                {
                    methaneMinimum = new RealtimeData("methane (minimum)");
                    methaneMinimum.RealtimeMeasureClass = "volume per volume";
                    methaneMinimum.Description = "Minimum methane content of the returning mud sample, over the interval.";
                }
                return methaneMinimum;
            }
        }

        private static RealtimeData mudDensityInAverage;
        /// <summary>
        /// Density of the mud entering the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("mud density in (average)")]
        public static RealtimeData MudDensityInAverage
        {
            get 
            {
                if (mudDensityInAverage == null)
                {
                    mudDensityInAverage = new RealtimeData("mud density in (average)");
                    mudDensityInAverage.RealtimeMeasureClass = "density";
                    mudDensityInAverage.Description = "Density of the mud entering the hole, averaged over the interval.";
                }
                return mudDensityInAverage;
            }
        }

        private static RealtimeData mudDensityOutAverage;
        /// <summary>
        /// Density of the mud leaving the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("mud density out (average)")]
        public static RealtimeData MudDensityOutAverage
        {
            get 
            {
                if (mudDensityOutAverage == null)
                {
                    mudDensityOutAverage = new RealtimeData("mud density out (average)");
                    mudDensityOutAverage.RealtimeMeasureClass = "density";
                    mudDensityOutAverage.Description = "Density of the mud leaving the hole, averaged over the interval.";
                }
                return mudDensityOutAverage;
            }
        }

        private static RealtimeData mudTemperatureInAverage;
        /// <summary>
        /// Temperature of the mud entering the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("mud temperature in (average)")]
        public static RealtimeData MudTemperatureInAverage
        {
            get 
            {
                if (mudTemperatureInAverage == null)
                {
                    mudTemperatureInAverage = new RealtimeData("mud temperature in (average)");
                    mudTemperatureInAverage.RealtimeMeasureClass = "thermodynamic temperature";
                    mudTemperatureInAverage.Description = "Temperature of the mud entering the hole, averaged over the interval.";
                }
                return mudTemperatureInAverage;
            }
        }

        private static RealtimeData mudTemperatureOutAverage;
        /// <summary>
        /// Temperature of the mud leaving the hole, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("mud temperature out (average)")]
        public static RealtimeData MudTemperatureOutAverage
        {
            get 
            {
                if (mudTemperatureOutAverage == null)
                {
                    mudTemperatureOutAverage = new RealtimeData("mud temperature out (average)");
                    mudTemperatureOutAverage.RealtimeMeasureClass = "thermodynamic temperature";
                    mudTemperatureOutAverage.Description = "Temperature of the mud leaving the hole, averaged over the interval.";
                }
                return mudTemperatureOutAverage;
            }
        }

        private static RealtimeData mwdAlternatorVoltage;
        /// <summary>
        /// Alternator voltage of the MWD tool averaged over the interval
        /// </summary>
        [EnumValueNameAttribute("MWD alternator voltage")]
        public static RealtimeData MwdAlternatorVoltage
        {
            get 
            {
                if (mwdAlternatorVoltage == null)
                {
                    mwdAlternatorVoltage = new RealtimeData("MWD alternator voltage");
                    mwdAlternatorVoltage.RealtimeMeasureClass = "electric potential";
                    mwdAlternatorVoltage.Description = "Alternator voltage of the MWD tool averaged over the interval";
                }
                return mwdAlternatorVoltage;
            }
        }

        private static RealtimeData mwdBottomHoleAnnulusPressure;
        /// <summary>
        /// Pressure measured in the annulus, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("MWD bottom hole annulus pressure")]
        public static RealtimeData MwdBottomHoleAnnulusPressure
        {
            get 
            {
                if (mwdBottomHoleAnnulusPressure == null)
                {
                    mwdBottomHoleAnnulusPressure = new RealtimeData("MWD bottom hole annulus pressure");
                    mwdBottomHoleAnnulusPressure.RealtimeMeasureClass = "pressure";
                    mwdBottomHoleAnnulusPressure.Description = "Pressure measured in the annulus, averaged over the interval.";
                }
                return mwdBottomHoleAnnulusPressure;
            }
        }

        private static RealtimeData mwdBottomHoleInternalPressure;
        /// <summary>
        /// Pressure measured inside the drillstring, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("MWD bottom hole internal pressure")]
        public static RealtimeData MwdBottomHoleInternalPressure
        {
            get 
            {
                if (mwdBottomHoleInternalPressure == null)
                {
                    mwdBottomHoleInternalPressure = new RealtimeData("MWD bottom hole internal pressure");
                    mwdBottomHoleInternalPressure.RealtimeMeasureClass = "pressure";
                    mwdBottomHoleInternalPressure.Description = "Pressure measured inside the drillstring, averaged over the interval.";
                }
                return mwdBottomHoleInternalPressure;
            }
        }

        private static RealtimeData mwdCVibration;
        /// <summary>
        /// Downhole vibration in axial direction
        /// </summary>
        [EnumValueNameAttribute("MWD c vibration")]
        public static RealtimeData MwdCVibration
        {
            get 
            {
                if (mwdCVibration == null)
                {
                    mwdCVibration = new RealtimeData("MWD c vibration");
                    mwdCVibration.RealtimeMeasureClass = "acceleration linear";
                    mwdCVibration.Description = "Downhole vibration in axial direction";
                }
                return mwdCVibration;
            }
        }

        private static RealtimeData mwdConductivity;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("MWD conductivity")]
        public static RealtimeData MwdConductivity
        {
            get 
            {
                if (mwdConductivity == null)
                {
                    mwdConductivity = new RealtimeData("MWD conductivity");
                    mwdConductivity.RealtimeMeasureClass = "conductivity";
                    mwdConductivity.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return mwdConductivity;
            }
        }

        private static RealtimeData mwdDerivedFracturePressureGradient;
        /// <summary>
        /// Computed formation fracture pressure gradient, based exclusively on MWD readings, for the current depth.
        /// </summary>
        [EnumValueNameAttribute("MWD derived fracture pressure gradient")]
        public static RealtimeData MwdDerivedFracturePressureGradient
        {
            get 
            {
                if (mwdDerivedFracturePressureGradient == null)
                {
                    mwdDerivedFracturePressureGradient = new RealtimeData("MWD derived fracture pressure gradient");
                    mwdDerivedFracturePressureGradient.RealtimeMeasureClass = "force per volume";
                    mwdDerivedFracturePressureGradient.Description = "Computed formation fracture pressure gradient, based exclusively on MWD readings, for the current depth.";
                }
                return mwdDerivedFracturePressureGradient;
            }
        }

        private static RealtimeData mwdDerivedPorePressureGradient;
        /// <summary>
        /// Computed formation pore pressure gradient, based exclusively on MWD readings, for the current depth.
        /// </summary>
        [EnumValueNameAttribute("MWD derived pore pressure gradient")]
        public static RealtimeData MwdDerivedPorePressureGradient
        {
            get 
            {
                if (mwdDerivedPorePressureGradient == null)
                {
                    mwdDerivedPorePressureGradient = new RealtimeData("MWD derived pore pressure gradient");
                    mwdDerivedPorePressureGradient.RealtimeMeasureClass = "force per volume";
                    mwdDerivedPorePressureGradient.Description = "Computed formation pore pressure gradient, based exclusively on MWD readings, for the current depth.";
                }
                return mwdDerivedPorePressureGradient;
            }
        }

        private static RealtimeData mwdFluidResistivityInAnnulus;
        /// <summary>
        /// Average fluid resistivity measured outside the MWD collar.
        /// </summary>
        [EnumValueNameAttribute("MWD fluid resistivity in annulus")]
        public static RealtimeData MwdFluidResistivityInAnnulus
        {
            get 
            {
                if (mwdFluidResistivityInAnnulus == null)
                {
                    mwdFluidResistivityInAnnulus = new RealtimeData("MWD fluid resistivity in annulus");
                    mwdFluidResistivityInAnnulus.RealtimeMeasureClass = "resistance";
                    mwdFluidResistivityInAnnulus.Description = "Average fluid resistivity measured outside the MWD collar.";
                }
                return mwdFluidResistivityInAnnulus;
            }
        }

        private static RealtimeData mwdFluidResistivityInPipe;
        /// <summary>
        /// Average fluid resistivity measured inside the MWD collar.
        /// </summary>
        [EnumValueNameAttribute("MWD fluid resistivity in pipe")]
        public static RealtimeData MwdFluidResistivityInPipe
        {
            get 
            {
                if (mwdFluidResistivityInPipe == null)
                {
                    mwdFluidResistivityInPipe = new RealtimeData("MWD fluid resistivity in pipe");
                    mwdFluidResistivityInPipe.RealtimeMeasureClass = "resistance";
                    mwdFluidResistivityInPipe.Description = "Average fluid resistivity measured inside the MWD collar.";
                }
                return mwdFluidResistivityInPipe;
            }
        }

        private static RealtimeData mwdFluidTemperatureInAnnulus;
        /// <summary>
        /// Average fluid temperature measured outside the MWD collar.
        /// </summary>
        [EnumValueNameAttribute("MWD fluid temperature in annulus")]
        public static RealtimeData MwdFluidTemperatureInAnnulus
        {
            get 
            {
                if (mwdFluidTemperatureInAnnulus == null)
                {
                    mwdFluidTemperatureInAnnulus = new RealtimeData("MWD fluid temperature in annulus");
                    mwdFluidTemperatureInAnnulus.RealtimeMeasureClass = "thermodynamic temperature";
                    mwdFluidTemperatureInAnnulus.Description = "Average fluid temperature measured outside the MWD collar.";
                }
                return mwdFluidTemperatureInAnnulus;
            }
        }

        private static RealtimeData mwdFluidTemperatureInPipe;
        /// <summary>
        /// Average fluid temperature measured inside the MWD collar.
        /// </summary>
        [EnumValueNameAttribute("MWD fluid temperature in pipe")]
        public static RealtimeData MwdFluidTemperatureInPipe
        {
            get 
            {
                if (mwdFluidTemperatureInPipe == null)
                {
                    mwdFluidTemperatureInPipe = new RealtimeData("MWD fluid temperature in pipe");
                    mwdFluidTemperatureInPipe.RealtimeMeasureClass = "thermodynamic temperature";
                    mwdFluidTemperatureInPipe.Description = "Average fluid temperature measured inside the MWD collar.";
                }
                return mwdFluidTemperatureInPipe;
            }
        }

        private static RealtimeData mwdGammaRay;
        /// <summary>
        /// Value of Gamma Ray sensor.
        /// </summary>
        [EnumValueNameAttribute("MWD gamma ray")]
        public static RealtimeData MwdGammaRay
        {
            get 
            {
                if (mwdGammaRay == null)
                {
                    mwdGammaRay = new RealtimeData("MWD gamma ray");
                    mwdGammaRay.RealtimeMeasureClass = "gamma ray API unit";
                    mwdGammaRay.Description = "Value of Gamma Ray sensor.";
                }
                return mwdGammaRay;
            }
        }

        private static RealtimeData mwdGammaRayCorrected;
        /// <summary>
        /// Value of Gamma Ray sensor corrected for borehole effects (normalized).
        /// </summary>
        [EnumValueNameAttribute("MWD gamma ray (corrected)")]
        public static RealtimeData MwdGammaRayCorrected
        {
            get 
            {
                if (mwdGammaRayCorrected == null)
                {
                    mwdGammaRayCorrected = new RealtimeData("MWD gamma ray (corrected)");
                    mwdGammaRayCorrected.RealtimeMeasureClass = "gamma ray API unit";
                    mwdGammaRayCorrected.Description = "Value of Gamma Ray sensor corrected for borehole effects (normalized).";
                }
                return mwdGammaRayCorrected;
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
                    mwdLateralVibration.RealtimeMeasureClass = "acceleration linear";
                    mwdLateralVibration.Description = "Downhole vibration in lateral direction";
                }
                return mwdLateralVibration;
            }
        }

        private static RealtimeData mwdMagnetometerXCorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer X (corrected)")]
        public static RealtimeData MwdMagnetometerXCorrected
        {
            get 
            {
                if (mwdMagnetometerXCorrected == null)
                {
                    mwdMagnetometerXCorrected = new RealtimeData("MWD magnetometer X (corrected)");
                    mwdMagnetometerXCorrected.RealtimeMeasureClass = "magnetic induction";
                    mwdMagnetometerXCorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return mwdMagnetometerXCorrected;
            }
        }

        private static RealtimeData mwdMagnetometerXRaw;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer X (raw)")]
        public static RealtimeData MwdMagnetometerXRaw
        {
            get 
            {
                if (mwdMagnetometerXRaw == null)
                {
                    mwdMagnetometerXRaw = new RealtimeData("MWD magnetometer X (raw)");
                    mwdMagnetometerXRaw.RealtimeMeasureClass = "magnetic induction";
                    mwdMagnetometerXRaw.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return mwdMagnetometerXRaw;
            }
        }

        private static RealtimeData mwdMagnetometerYCorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Y (corrected)")]
        public static RealtimeData MwdMagnetometerYCorrected
        {
            get 
            {
                if (mwdMagnetometerYCorrected == null)
                {
                    mwdMagnetometerYCorrected = new RealtimeData("MWD magnetometer Y (corrected)");
                    mwdMagnetometerYCorrected.RealtimeMeasureClass = "magnetic induction";
                    mwdMagnetometerYCorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return mwdMagnetometerYCorrected;
            }
        }

        private static RealtimeData mwdMagnetometerYRaw;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Y (raw)")]
        public static RealtimeData MwdMagnetometerYRaw
        {
            get 
            {
                if (mwdMagnetometerYRaw == null)
                {
                    mwdMagnetometerYRaw = new RealtimeData("MWD magnetometer Y (raw)");
                    mwdMagnetometerYRaw.RealtimeMeasureClass = "magnetic induction";
                    mwdMagnetometerYRaw.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return mwdMagnetometerYRaw;
            }
        }

        private static RealtimeData mwdMagnetometerZCorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Z (corrected)")]
        public static RealtimeData MwdMagnetometerZCorrected
        {
            get 
            {
                if (mwdMagnetometerZCorrected == null)
                {
                    mwdMagnetometerZCorrected = new RealtimeData("MWD magnetometer Z (corrected)");
                    mwdMagnetometerZCorrected.RealtimeMeasureClass = "magnetic induction";
                    mwdMagnetometerZCorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return mwdMagnetometerZCorrected;
            }
        }

        private static RealtimeData mwdMagnetometerZRaw;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("MWD magnetometer Z (raw)")]
        public static RealtimeData MwdMagnetometerZRaw
        {
            get 
            {
                if (mwdMagnetometerZRaw == null)
                {
                    mwdMagnetometerZRaw = new RealtimeData("MWD magnetometer Z (raw)");
                    mwdMagnetometerZRaw.RealtimeMeasureClass = "magnetic induction";
                    mwdMagnetometerZRaw.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return mwdMagnetometerZRaw;
            }
        }

        private static RealtimeData mwdMotorSpeed;
        /// <summary>
        /// Average rotary speed of a downhole motor as measured by a MWD tool over the interval.
        /// </summary>
        [EnumValueNameAttribute("MWD motor speed")]
        public static RealtimeData MwdMotorSpeed
        {
            get 
            {
                if (mwdMotorSpeed == null)
                {
                    mwdMotorSpeed = new RealtimeData("MWD motor speed");
                    mwdMotorSpeed.RealtimeMeasureClass = "angle per time";
                    mwdMotorSpeed.Description = "Average rotary speed of a downhole motor as measured by a MWD tool over the interval.";
                }
                return mwdMotorSpeed;
            }
        }

        private static RealtimeData mwdResistivity;
        /// <summary>
        /// Value of Resistivity sensor.
        /// </summary>
        [EnumValueNameAttribute("MWD resistivity")]
        public static RealtimeData MwdResistivity
        {
            get 
            {
                if (mwdResistivity == null)
                {
                    mwdResistivity = new RealtimeData("MWD resistivity");
                    mwdResistivity.RealtimeMeasureClass = "resistance";
                    mwdResistivity.Description = "Value of Resistivity sensor.";
                }
                return mwdResistivity;
            }
        }

        private static RealtimeData mwdResistivityCorrected;
        /// <summary>
        /// Value of Resistivity sensor corrected for borehole effects.
        /// </summary>
        [EnumValueNameAttribute("MWD resistivity (corrected)")]
        public static RealtimeData MwdResistivityCorrected
        {
            get 
            {
                if (mwdResistivityCorrected == null)
                {
                    mwdResistivityCorrected = new RealtimeData("MWD resistivity (corrected)");
                    mwdResistivityCorrected.RealtimeMeasureClass = "resistance";
                    mwdResistivityCorrected.Description = "Value of Resistivity sensor corrected for borehole effects.";
                }
                return mwdResistivityCorrected;
            }
        }

        private static RealtimeData mwdTorqueAverage;
        /// <summary>
        /// Measured downhole (bit) torque, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("MWD torque (average)")]
        public static RealtimeData MwdTorqueAverage
        {
            get 
            {
                if (mwdTorqueAverage == null)
                {
                    mwdTorqueAverage = new RealtimeData("MWD torque (average)");
                    mwdTorqueAverage.RealtimeMeasureClass = "moment of force";
                    mwdTorqueAverage.Description = "Measured downhole (bit) torque, averaged over the interval.";
                }
                return mwdTorqueAverage;
            }
        }

        private static RealtimeData mwdTorqueMaximum;
        /// <summary>
        /// Maximum measured downhole (bit) torque recorded over the interval.
        /// </summary>
        [EnumValueNameAttribute("MWD torque (maximum)")]
        public static RealtimeData MwdTorqueMaximum
        {
            get 
            {
                if (mwdTorqueMaximum == null)
                {
                    mwdTorqueMaximum = new RealtimeData("MWD torque (maximum)");
                    mwdTorqueMaximum.RealtimeMeasureClass = "moment of force";
                    mwdTorqueMaximum.Description = "Maximum measured downhole (bit) torque recorded over the interval.";
                }
                return mwdTorqueMaximum;
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
                    mwdTorsionalVibration.RealtimeMeasureClass = "acceleration linear";
                    mwdTorsionalVibration.Description = "Downhole vibration in torsional direction";
                }
                return mwdTorsionalVibration;
            }
        }

        private static RealtimeData mwdWeightOnBitAverage;
        /// <summary>
        /// Measured downhole weight on bit, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("MWD weight on bit (average)")]
        public static RealtimeData MwdWeightOnBitAverage
        {
            get 
            {
                if (mwdWeightOnBitAverage == null)
                {
                    mwdWeightOnBitAverage = new RealtimeData("MWD weight on bit (average)");
                    mwdWeightOnBitAverage.RealtimeMeasureClass = "force";
                    mwdWeightOnBitAverage.Description = "Measured downhole weight on bit, averaged over the interval.";
                }
                return mwdWeightOnBitAverage;
            }
        }

        private static RealtimeData mwdWeightOnBitMaximum;
        /// <summary>
        /// Maximum measured downhole weight on bit over the interval.
        /// </summary>
        [EnumValueNameAttribute("MWD weight on bit (maximum)")]
        public static RealtimeData MwdWeightOnBitMaximum
        {
            get 
            {
                if (mwdWeightOnBitMaximum == null)
                {
                    mwdWeightOnBitMaximum = new RealtimeData("MWD weight on bit (maximum)");
                    mwdWeightOnBitMaximum.RealtimeMeasureClass = "force";
                    mwdWeightOnBitMaximum.Description = "Maximum measured downhole weight on bit over the interval.";
                }
                return mwdWeightOnBitMaximum;
            }
        }

        private static RealtimeData neopentane;
        /// <summary>
        /// Neo Pentane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("neo-pentane")]
        public static RealtimeData Neopentane
        {
            get 
            {
                if (neopentane == null)
                {
                    neopentane = new RealtimeData("neo-pentane");
                    neopentane.RealtimeMeasureClass = "volume per volume";
                    neopentane.Description = "Neo Pentane content of the sample. (cycle-based)";
                }
                return neopentane;
            }
        }

        private static RealtimeData neopentaneAverage;
        /// <summary>
        /// Average neo pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (average)")]
        public static RealtimeData NeopentaneAverage
        {
            get 
            {
                if (neopentaneAverage == null)
                {
                    neopentaneAverage = new RealtimeData("neo-pentane (average)");
                    neopentaneAverage.RealtimeMeasureClass = "volume per volume";
                    neopentaneAverage.Description = "Average neo pentane content of the returning mud sample, over the interval.";
                }
                return neopentaneAverage;
            }
        }

        private static RealtimeData neopentaneMaximum;
        /// <summary>
        /// Maximum neo pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (maximum)")]
        public static RealtimeData NeopentaneMaximum
        {
            get 
            {
                if (neopentaneMaximum == null)
                {
                    neopentaneMaximum = new RealtimeData("neo-pentane (maximum)");
                    neopentaneMaximum.RealtimeMeasureClass = "volume per volume";
                    neopentaneMaximum.Description = "Maximum neo pentane content of the returning mud sample, over the interval.";
                }
                return neopentaneMaximum;
            }
        }

        private static RealtimeData neopentaneMinimum;
        /// <summary>
        /// Minimum neo pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("neo-pentane (minimum)")]
        public static RealtimeData NeopentaneMinimum
        {
            get 
            {
                if (neopentaneMinimum == null)
                {
                    neopentaneMinimum = new RealtimeData("neo-pentane (minimum)");
                    neopentaneMinimum.RealtimeMeasureClass = "volume per volume";
                    neopentaneMinimum.Description = "Minimum neo pentane content of the returning mud sample, over the interval.";
                }
                return neopentaneMinimum;
            }
        }

        private static RealtimeData neutronDensity;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("neutron density")]
        public static RealtimeData NeutronDensity
        {
            get 
            {
                if (neutronDensity == null)
                {
                    neutronDensity = new RealtimeData("neutron density");
                    neutronDensity.RealtimeMeasureClass = "density";
                    neutronDensity.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return neutronDensity;
            }
        }

        private static RealtimeData neutronPorosity;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("neutron porosity")]
        public static RealtimeData NeutronPorosity
        {
            get 
            {
                if (neutronPorosity == null)
                {
                    neutronPorosity = new RealtimeData("neutron porosity");
                    neutronPorosity.RealtimeMeasureClass = "volume per volume";
                    neutronPorosity.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return neutronPorosity;
            }
        }

        private static RealtimeData neutronPorosityCorrected;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("neutron porosity (corrected)")]
        public static RealtimeData NeutronPorosityCorrected
        {
            get 
            {
                if (neutronPorosityCorrected == null)
                {
                    neutronPorosityCorrected = new RealtimeData("neutron porosity (corrected)");
                    neutronPorosityCorrected.RealtimeMeasureClass = "volume per volume";
                    neutronPorosityCorrected.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return neutronPorosityCorrected;
            }
        }

        private static RealtimeData neutronPorosityRatio;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("neutron porosity ratio")]
        public static RealtimeData NeutronPorosityRatio
        {
            get 
            {
                if (neutronPorosityRatio == null)
                {
                    neutronPorosityRatio = new RealtimeData("neutron porosity ratio");
                    neutronPorosityRatio.RealtimeMeasureClass = "volume per volume";
                    neutronPorosityRatio.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return neutronPorosityRatio;
            }
        }

        private static RealtimeData norbutane;
        /// <summary>
        /// Nor?Butane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-butane")]
        public static RealtimeData Norbutane
        {
            get 
            {
                if (norbutane == null)
                {
                    norbutane = new RealtimeData("nor-butane");
                    norbutane.RealtimeMeasureClass = "volume per volume";
                    norbutane.Description = "Nor?Butane content of the sample. (cycle-based)";
                }
                return norbutane;
            }
        }

        private static RealtimeData norbutaneAverage;
        /// <summary>
        /// Average normal butane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-butane (average)")]
        public static RealtimeData NorbutaneAverage
        {
            get 
            {
                if (norbutaneAverage == null)
                {
                    norbutaneAverage = new RealtimeData("nor-butane (average)");
                    norbutaneAverage.RealtimeMeasureClass = "volume per volume";
                    norbutaneAverage.Description = "Average normal butane content of the returning mud sample, over the interval.";
                }
                return norbutaneAverage;
            }
        }

        private static RealtimeData norbutaneMaximum;
        /// <summary>
        /// Maximum normal butane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-butane (maximum)")]
        public static RealtimeData NorbutaneMaximum
        {
            get 
            {
                if (norbutaneMaximum == null)
                {
                    norbutaneMaximum = new RealtimeData("nor-butane (maximum)");
                    norbutaneMaximum.RealtimeMeasureClass = "volume per volume";
                    norbutaneMaximum.Description = "Maximum normal butane content of the returning mud sample, over the interval.";
                }
                return norbutaneMaximum;
            }
        }

        private static RealtimeData norbutaneMinimum;
        /// <summary>
        /// Minimum normal butane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-butane (minimum)")]
        public static RealtimeData NorbutaneMinimum
        {
            get 
            {
                if (norbutaneMinimum == null)
                {
                    norbutaneMinimum = new RealtimeData("nor-butane (minimum)");
                    norbutaneMinimum.RealtimeMeasureClass = "volume per volume";
                    norbutaneMinimum.Description = "Minimum normal butane content of the returning mud sample, over the interval.";
                }
                return norbutaneMinimum;
            }
        }

        private static RealtimeData norhexane;
        /// <summary>
        /// Nor Hexane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-hexane")]
        public static RealtimeData Norhexane
        {
            get 
            {
                if (norhexane == null)
                {
                    norhexane = new RealtimeData("nor-hexane");
                    norhexane.RealtimeMeasureClass = "volume per volume";
                    norhexane.Description = "Nor Hexane content of the sample. (cycle-based)";
                }
                return norhexane;
            }
        }

        private static RealtimeData norhexaneAverage;
        /// <summary>
        /// Average normal hexane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (average)")]
        public static RealtimeData NorhexaneAverage
        {
            get 
            {
                if (norhexaneAverage == null)
                {
                    norhexaneAverage = new RealtimeData("nor-hexane (average)");
                    norhexaneAverage.RealtimeMeasureClass = "volume per volume";
                    norhexaneAverage.Description = "Average normal hexane content of the returning mud sample, over the interval.";
                }
                return norhexaneAverage;
            }
        }

        private static RealtimeData norhexaneMaximum;
        /// <summary>
        /// Maximum normal hexane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (maximum)")]
        public static RealtimeData NorhexaneMaximum
        {
            get 
            {
                if (norhexaneMaximum == null)
                {
                    norhexaneMaximum = new RealtimeData("nor-hexane (maximum)");
                    norhexaneMaximum.RealtimeMeasureClass = "volume per volume";
                    norhexaneMaximum.Description = "Maximum normal hexane content of the returning mud sample, over the interval.";
                }
                return norhexaneMaximum;
            }
        }

        private static RealtimeData norhexaneMinimum;
        /// <summary>
        /// Minimum normal hexane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-hexane (minimum)")]
        public static RealtimeData NorhexaneMinimum
        {
            get 
            {
                if (norhexaneMinimum == null)
                {
                    norhexaneMinimum = new RealtimeData("nor-hexane (minimum)");
                    norhexaneMinimum.RealtimeMeasureClass = "volume per volume";
                    norhexaneMinimum.Description = "Minimum normal hexane content of the returning mud sample, over the interval.";
                }
                return norhexaneMinimum;
            }
        }

        private static RealtimeData norpentane;
        /// <summary>
        /// Nor Pentane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("nor-pentane")]
        public static RealtimeData Norpentane
        {
            get 
            {
                if (norpentane == null)
                {
                    norpentane = new RealtimeData("nor-pentane");
                    norpentane.RealtimeMeasureClass = "volume per volume";
                    norpentane.Description = "Nor Pentane content of the sample. (cycle-based)";
                }
                return norpentane;
            }
        }

        private static RealtimeData norpentaneAverage;
        /// <summary>
        /// Average normal pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (average)")]
        public static RealtimeData NorpentaneAverage
        {
            get 
            {
                if (norpentaneAverage == null)
                {
                    norpentaneAverage = new RealtimeData("nor-pentane (average)");
                    norpentaneAverage.RealtimeMeasureClass = "volume per volume";
                    norpentaneAverage.Description = "Average normal pentane content of the returning mud sample, over the interval.";
                }
                return norpentaneAverage;
            }
        }

        private static RealtimeData norpentaneMaximum;
        /// <summary>
        /// Maximum normal pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (maximum)")]
        public static RealtimeData NorpentaneMaximum
        {
            get 
            {
                if (norpentaneMaximum == null)
                {
                    norpentaneMaximum = new RealtimeData("nor-pentane (maximum)");
                    norpentaneMaximum.RealtimeMeasureClass = "volume per volume";
                    norpentaneMaximum.Description = "Maximum normal pentane content of the returning mud sample, over the interval.";
                }
                return norpentaneMaximum;
            }
        }

        private static RealtimeData norpentaneMinimum;
        /// <summary>
        /// Minimum normal pentane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("nor-pentane (minimum)")]
        public static RealtimeData NorpentaneMinimum
        {
            get 
            {
                if (norpentaneMinimum == null)
                {
                    norpentaneMinimum = new RealtimeData("nor-pentane (minimum)");
                    norpentaneMinimum.RealtimeMeasureClass = "volume per volume";
                    norpentaneMinimum.Description = "Minimum normal pentane content of the returning mud sample, over the interval.";
                }
                return norpentaneMinimum;
            }
        }

        private static RealtimeData overburdenPressureGradient;
        /// <summary>
        /// Estimated overburden pressure gradient at this depth, expressed as equivalent mud density.
        /// </summary>
        [EnumValueNameAttribute("overburden pressure gradient")]
        public static RealtimeData OverburdenPressureGradient
        {
            get 
            {
                if (overburdenPressureGradient == null)
                {
                    overburdenPressureGradient = new RealtimeData("overburden pressure gradient");
                    overburdenPressureGradient.RealtimeMeasureClass = "force per volume";
                    overburdenPressureGradient.Description = "Estimated overburden pressure gradient at this depth, expressed as equivalent mud density.";
                }
                return overburdenPressureGradient;
            }
        }

        private static RealtimeData passNumber;
        /// <summary>
        /// Sequential number assigned to repeated MWD logging runs over the same hole interval. The original hole should have a pass number of 0. Any new hole drilled should have a pass number of 0. Repeat logging sections in a hole should have the pass number incremented by 1. Except for returning to 0 for new sections, the pass number will always increment for each repeat section. As an example: A hole is drilled from 2000m to 4000m with pass number 0. It is decided to repeat log the section from 3500m to 4000m. The pass number is 1 for this section. New hole is again drilled from 4000m. The pass number returns to 0. After drilling to 5000m, it is decided to relog the section from 3500m to 5000m. The pass number for this section is 2. Following this, another repeat log is taken from 4800m to 5000m. This pass is number 3.
        /// </summary>
        [EnumValueNameAttribute("pass number")]
        public static RealtimeData PassNumber
        {
            get 
            {
                if (passNumber == null)
                {
                    passNumber = new RealtimeData("pass number");
                    passNumber.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    passNumber.Description = "Sequential number assigned to repeated MWD logging runs over the same hole interval. The original hole should have a pass number of 0. Any new hole drilled should have a pass number of 0. Repeat logging sections in a hole should have the pass number incremented by 1. Except for returning to 0 for new sections, the pass number will always increment for each repeat section. As an example: A hole is drilled from 2000m to 4000m with pass number 0. It is decided to repeat log the section from 3500m to 4000m. The pass number is 1 for this section. New hole is again drilled from 4000m. The pass number returns to 0. After drilling to 5000m, it is decided to relog the section from 3500m to 5000m. The pass number for this section is 2. Following this, another repeat log is taken from 4800m to 5000m. This pass is number 3.";
                }
                return passNumber;
            }
        }

        private static RealtimeData photoelectricEffect;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("photoelectric effect")]
        public static RealtimeData PhotoelectricEffect
        {
            get 
            {
                if (photoelectricEffect == null)
                {
                    photoelectricEffect = new RealtimeData("photoelectric effect");
                    photoelectricEffect.RealtimeDataType = EnumValueRealtimeType.RealtimeNumeric;
                    photoelectricEffect.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return photoelectricEffect;
            }
        }

        private static RealtimeData plasticViscosity;
        /// <summary>
        /// Measured plastic viscosity of the mud. Where this is manually entered, it's value should remain, rather than being replaced by a NULL, until the next entry is made. The SENDER should enter a NULL if the value is no longer valid.
        /// </summary>
        [EnumValueNameAttribute("plastic viscosity")]
        public static RealtimeData PlasticViscosity
        {
            get 
            {
                if (plasticViscosity == null)
                {
                    plasticViscosity = new RealtimeData("plastic viscosity");
                    plasticViscosity.RealtimeMeasureClass = "dynamic viscosity";
                    plasticViscosity.Description = "Measured plastic viscosity of the mud. Where this is manually entered, it's value should remain, rather than being replaced by a NULL, until the next entry is made. The SENDER should enter a NULL if the value is no longer valid.";
                }
                return plasticViscosity;
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
                    pressureAtMwdTool.RealtimeMeasureClass = "pressure";
                    pressureAtMwdTool.Description = "Downhole pressure from MWD tool";
                }
                return pressureAtMwdTool;
            }
        }

        private static RealtimeData pressureAtPumpAverage;
        /// <summary>
        /// Measured pump pressure, averaged over the interval. This is the pressure required to displace fluid down the hole during the entire cementing operation (ie. rig pump pressure, cement truck pump pressure, etc.).
        /// </summary>
        [EnumValueNameAttribute("pressure at pump (average)")]
        public static RealtimeData PressureAtPumpAverage
        {
            get 
            {
                if (pressureAtPumpAverage == null)
                {
                    pressureAtPumpAverage = new RealtimeData("pressure at pump (average)");
                    pressureAtPumpAverage.RealtimeMeasureClass = "pressure";
                    pressureAtPumpAverage.Description = "Measured pump pressure, averaged over the interval. This is the pressure required to displace fluid down the hole during the entire cementing operation (ie. rig pump pressure, cement truck pump pressure, etc.).";
                }
                return pressureAtPumpAverage;
            }
        }

        private static RealtimeData pressureDropCalculatedOrObserved;
        /// <summary>
        /// Proportion of the total system pressure loss.
        /// </summary>
        [EnumValueNameAttribute("pressure drop (calculated or observed)")]
        public static RealtimeData PressureDropCalculatedOrObserved
        {
            get 
            {
                if (pressureDropCalculatedOrObserved == null)
                {
                    pressureDropCalculatedOrObserved = new RealtimeData("pressure drop (calculated or observed)");
                    pressureDropCalculatedOrObserved.RealtimeMeasureClass = "force per force";
                    pressureDropCalculatedOrObserved.Description = "Proportion of the total system pressure loss.";
                }
                return pressureDropCalculatedOrObserved;
            }
        }

        private static RealtimeData pressureDropAtBit;
        /// <summary>
        /// DEPRECATED. See "bit pressure loss".
        /// </summary>
        [EnumValueNameAttribute("pressure drop at bit")]
        public static RealtimeData PressureDropAtBit
        {
            get 
            {
                if (pressureDropAtBit == null)
                {
                    pressureDropAtBit = new RealtimeData("pressure drop at bit");
                    pressureDropAtBit.RealtimeMeasureClass = "pressure";
                    pressureDropAtBit.Description = "DEPRECATED. See \"bit pressure loss\".";
                    pressureDropAtBit.Version = "1.3.1.0";
                    pressureDropAtBit.Deprecated = "1.4.0.0";
                    pressureDropAtBit.ReplacedBy = BitPressureLoss;
                }
                return pressureDropAtBit;
            }
        }

        private static RealtimeData pressureDropAtMotor;
        /// <summary>
        /// Calculated/measured pressure differential across the mud motor or turbine.
        /// </summary>
        [EnumValueNameAttribute("pressure drop at motor")]
        public static RealtimeData PressureDropAtMotor
        {
            get 
            {
                if (pressureDropAtMotor == null)
                {
                    pressureDropAtMotor = new RealtimeData("pressure drop at motor");
                    pressureDropAtMotor.RealtimeMeasureClass = "pressure";
                    pressureDropAtMotor.Description = "Calculated/measured pressure differential across the mud motor or turbine.";
                }
                return pressureDropAtMotor;
            }
        }

        private static RealtimeData pressureDropAtMwdTool;
        /// <summary>
        /// Calculated/measured pressure differential across the MWD tool.
        /// </summary>
        [EnumValueNameAttribute("pressure drop at MWD tool")]
        public static RealtimeData PressureDropAtMwdTool
        {
            get 
            {
                if (pressureDropAtMwdTool == null)
                {
                    pressureDropAtMwdTool = new RealtimeData("pressure drop at MWD tool");
                    pressureDropAtMwdTool.RealtimeMeasureClass = "pressure";
                    pressureDropAtMwdTool.Description = "Calculated/measured pressure differential across the MWD tool.";
                }
                return pressureDropAtMwdTool;
            }
        }

        private static RealtimeData pressureDropAtString;
        /// <summary>
        /// Sum of the calculated frictional pressure losses inside the drillstring.
        /// </summary>
        [EnumValueNameAttribute("pressure drop at string")]
        public static RealtimeData PressureDropAtString
        {
            get 
            {
                if (pressureDropAtString == null)
                {
                    pressureDropAtString = new RealtimeData("pressure drop at string");
                    pressureDropAtString.RealtimeMeasureClass = "pressure";
                    pressureDropAtString.Description = "Sum of the calculated frictional pressure losses inside the drillstring.";
                }
                return pressureDropAtString;
            }
        }

        private static RealtimeData pressureDropAtSurface;
        /// <summary>
        /// Sum of the calculated frictional pressure losses in the surface equipment.
        /// </summary>
        [EnumValueNameAttribute("pressure drop at surface")]
        public static RealtimeData PressureDropAtSurface
        {
            get 
            {
                if (pressureDropAtSurface == null)
                {
                    pressureDropAtSurface = new RealtimeData("pressure drop at surface");
                    pressureDropAtSurface.RealtimeMeasureClass = "pressure";
                    pressureDropAtSurface.Description = "Sum of the calculated frictional pressure losses in the surface equipment.";
                }
                return pressureDropAtSurface;
            }
        }

        private static RealtimeData pressureLossAtAnnulus;
        /// <summary>
        /// Sum of the calculated frictional pressure losses in the annulus.
        /// </summary>
        [EnumValueNameAttribute("pressure loss at annulus")]
        public static RealtimeData PressureLossAtAnnulus
        {
            get 
            {
                if (pressureLossAtAnnulus == null)
                {
                    pressureLossAtAnnulus = new RealtimeData("pressure loss at annulus");
                    pressureLossAtAnnulus.RealtimeMeasureClass = "pressure";
                    pressureLossAtAnnulus.Description = "Sum of the calculated frictional pressure losses in the annulus.";
                }
                return pressureLossAtAnnulus;
            }
        }

        private static RealtimeData pressureLossAtBit;
        /// <summary>
        /// Proportion of the total system pressure loss which occurs across the bit.
        /// </summary>
        [EnumValueNameAttribute("pressure loss at bit")]
        public static RealtimeData PressureLossAtBit
        {
            get 
            {
                if (pressureLossAtBit == null)
                {
                    pressureLossAtBit = new RealtimeData("pressure loss at bit");
                    pressureLossAtBit.RealtimeMeasureClass = "force per force";
                    pressureLossAtBit.Description = "Proportion of the total system pressure loss which occurs across the bit.";
                }
                return pressureLossAtBit;
            }
        }

        private static RealtimeData propane;
        /// <summary>
        /// Propane content of the sample. (cycle-based)
        /// </summary>
        [EnumValueNameAttribute("propane")]
        public static RealtimeData Propane
        {
            get 
            {
                if (propane == null)
                {
                    propane = new RealtimeData("propane");
                    propane.RealtimeMeasureClass = "volume per volume";
                    propane.Description = "Propane content of the sample. (cycle-based)";
                }
                return propane;
            }
        }

        private static RealtimeData propaneAverage;
        /// <summary>
        /// Average propane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("propane (average)")]
        public static RealtimeData PropaneAverage
        {
            get 
            {
                if (propaneAverage == null)
                {
                    propaneAverage = new RealtimeData("propane (average)");
                    propaneAverage.RealtimeMeasureClass = "volume per volume";
                    propaneAverage.Description = "Average propane content of the returning mud sample, over the interval.";
                }
                return propaneAverage;
            }
        }

        private static RealtimeData propaneMaximum;
        /// <summary>
        /// Maximum propane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("propane (maximum)")]
        public static RealtimeData PropaneMaximum
        {
            get 
            {
                if (propaneMaximum == null)
                {
                    propaneMaximum = new RealtimeData("propane (maximum)");
                    propaneMaximum.RealtimeMeasureClass = "volume per volume";
                    propaneMaximum.Description = "Maximum propane content of the returning mud sample, over the interval.";
                }
                return propaneMaximum;
            }
        }

        private static RealtimeData propaneMinimum;
        /// <summary>
        /// Minimum propane content of the returning mud sample, over the interval.
        /// </summary>
        [EnumValueNameAttribute("propane (minimum)")]
        public static RealtimeData PropaneMinimum
        {
            get 
            {
                if (propaneMinimum == null)
                {
                    propaneMinimum = new RealtimeData("propane (minimum)");
                    propaneMinimum.RealtimeMeasureClass = "volume per volume";
                    propaneMinimum.Description = "Minimum propane content of the returning mud sample, over the interval.";
                }
                return propaneMinimum;
            }
        }

        private static RealtimeData rateOfPenetrationAverage;
        /// <summary>
        /// Calculated rate of penetration, averaged over the interval, while on bottom, drilling new hole or reaming.
        /// </summary>
        [EnumValueNameAttribute("rate of penetration (average)")]
        public static RealtimeData RateOfPenetrationAverage
        {
            get 
            {
                if (rateOfPenetrationAverage == null)
                {
                    rateOfPenetrationAverage = new RealtimeData("rate of penetration (average)");
                    rateOfPenetrationAverage.RealtimeMeasureClass = "velocity";
                    rateOfPenetrationAverage.Description = "Calculated rate of penetration, averaged over the interval, while on bottom, drilling new hole or reaming.";
                }
                return rateOfPenetrationAverage;
            }
        }

        private static RealtimeData rateOfPenetrationIntantaneous;
        /// <summary>
        /// Rate of penetration while on bottom, drilling new hole or reaming.
        /// </summary>
        [EnumValueNameAttribute("rate of penetration (intantaneous)")]
        public static RealtimeData RateOfPenetrationIntantaneous
        {
            get 
            {
                if (rateOfPenetrationIntantaneous == null)
                {
                    rateOfPenetrationIntantaneous = new RealtimeData("rate of penetration (intantaneous)");
                    rateOfPenetrationIntantaneous.RealtimeMeasureClass = "velocity";
                    rateOfPenetrationIntantaneous.Description = "Rate of penetration while on bottom, drilling new hole or reaming.";
                }
                return rateOfPenetrationIntantaneous;
            }
        }

        private static RealtimeData resistivity;
        /// <summary>
        /// Value of Resistivity sensor.
        /// </summary>
        [EnumValueNameAttribute("resistivity")]
        public static RealtimeData Resistivity
        {
            get 
            {
                if (resistivity == null)
                {
                    resistivity = new RealtimeData("resistivity");
                    resistivity.RealtimeMeasureClass = "resistance";
                    resistivity.Description = "Value of Resistivity sensor.";
                }
                return resistivity;
            }
        }

        private static RealtimeData resistivityCorrected;
        /// <summary>
        /// Value of Resistivity sensor corrected for borehole effects.
        /// </summary>
        [EnumValueNameAttribute("resistivity (corrected)")]
        public static RealtimeData ResistivityCorrected
        {
            get 
            {
                if (resistivityCorrected == null)
                {
                    resistivityCorrected = new RealtimeData("resistivity (corrected)");
                    resistivityCorrected.RealtimeMeasureClass = "resistance";
                    resistivityCorrected.Description = "Value of Resistivity sensor corrected for borehole effects.";
                }
                return resistivityCorrected;
            }
        }

        private static RealtimeData rotarySpeedAverage;
        /// <summary>
        /// Measured surface rotations per minute, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("rotary speed (average)")]
        public static RealtimeData RotarySpeedAverage
        {
            get 
            {
                if (rotarySpeedAverage == null)
                {
                    rotarySpeedAverage = new RealtimeData("rotary speed (average)");
                    rotarySpeedAverage.RealtimeMeasureClass = "angle per time";
                    rotarySpeedAverage.Description = "Measured surface rotations per minute, averaged over the interval.";
                }
                return rotarySpeedAverage;
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
                    rotationFlag.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    rotationFlag.Description = "Rotation flag = 1 if pipe is rotating, else = 0";
                }
                return rotationFlag;
            }
        }

        private static RealtimeData runningSpeedDownAverage;
        /// <summary>
        /// Average downward velocity of the drillstring while running into the hole. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).
        /// </summary>
        [EnumValueNameAttribute("running speed down (average)")]
        public static RealtimeData RunningSpeedDownAverage
        {
            get 
            {
                if (runningSpeedDownAverage == null)
                {
                    runningSpeedDownAverage = new RealtimeData("running speed down (average)");
                    runningSpeedDownAverage.RealtimeMeasureClass = "velocity";
                    runningSpeedDownAverage.Description = "Average downward velocity of the drillstring while running into the hole. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).";
                }
                return runningSpeedDownAverage;
            }
        }

        private static RealtimeData runningSpeedDownMaximum;
        /// <summary>
        /// Maximum downward velocity of the drillstring while running into the hole. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).
        /// </summary>
        [EnumValueNameAttribute("running speed down (maximum)")]
        public static RealtimeData RunningSpeedDownMaximum
        {
            get 
            {
                if (runningSpeedDownMaximum == null)
                {
                    runningSpeedDownMaximum = new RealtimeData("running speed down (maximum)");
                    runningSpeedDownMaximum.RealtimeMeasureClass = "velocity";
                    runningSpeedDownMaximum.Description = "Maximum downward velocity of the drillstring while running into the hole. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).";
                }
                return runningSpeedDownMaximum;
            }
        }

        private static RealtimeData runningSpeedUpAverage;
        /// <summary>
        /// Average upward velocity of the drillstring while picking up. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).
        /// </summary>
        [EnumValueNameAttribute("running speed up (average)")]
        public static RealtimeData RunningSpeedUpAverage
        {
            get 
            {
                if (runningSpeedUpAverage == null)
                {
                    runningSpeedUpAverage = new RealtimeData("running speed up (average)");
                    runningSpeedUpAverage.RealtimeMeasureClass = "velocity";
                    runningSpeedUpAverage.Description = "Average upward velocity of the drillstring while picking up. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).";
                }
                return runningSpeedUpAverage;
            }
        }

        private static RealtimeData runningSpeedUpMaximum;
        /// <summary>
        /// Maximum upward velocity of the drillstring while picking up. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).
        /// </summary>
        [EnumValueNameAttribute("running speed up (maximum)")]
        public static RealtimeData RunningSpeedUpMaximum
        {
            get 
            {
                if (runningSpeedUpMaximum == null)
                {
                    runningSpeedUpMaximum = new RealtimeData("running speed up (maximum)");
                    runningSpeedUpMaximum.RealtimeMeasureClass = "velocity";
                    runningSpeedUpMaximum.Description = "Maximum upward velocity of the drillstring while picking up. This value is reset following transmission of the record. It should always be a positive number. An appropriate sampling interval should be used to eliminate spikes ( eg. 1 second).";
                }
                return runningSpeedUpMaximum;
            }
        }

        private static RealtimeData shutinPressureMaximum;
        /// <summary>
        /// Imaximum allowable Shut In Casing Pressure at this depth, with the present mud density (assuming no fluid influx into the borehole).
        /// </summary>
        [EnumValueNameAttribute("shut-in pressure (maximum)")]
        public static RealtimeData ShutinPressureMaximum
        {
            get 
            {
                if (shutinPressureMaximum == null)
                {
                    shutinPressureMaximum = new RealtimeData("shut-in pressure (maximum)");
                    shutinPressureMaximum.RealtimeMeasureClass = "pressure";
                    shutinPressureMaximum.Description = "Imaximum allowable Shut In Casing Pressure at this depth, with the present mud density (assuming no fluid influx into the borehole).";
                }
                return shutinPressureMaximum;
            }
        }

        private static RealtimeData sonicCoherence;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("sonic coherence")]
        public static RealtimeData SonicCoherence
        {
            get 
            {
                if (sonicCoherence == null)
                {
                    sonicCoherence = new RealtimeData("sonic coherence");
                    sonicCoherence.RealtimeDataType = EnumValueRealtimeType.RealtimeNumeric;
                    sonicCoherence.Description = "XXXXXXXXXX";
                }
                return sonicCoherence;
            }
        }

        private static RealtimeData sonicDeltatimeCorrected;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("sonic delta-time (corrected)")]
        public static RealtimeData SonicDeltatimeCorrected
        {
            get 
            {
                if (sonicDeltatimeCorrected == null)
                {
                    sonicDeltatimeCorrected = new RealtimeData("sonic delta-time (corrected)");
                    sonicDeltatimeCorrected.RealtimeMeasureClass = "time per length";
                    sonicDeltatimeCorrected.Description = "XXXXXXXXXX";
                }
                return sonicDeltatimeCorrected;
            }
        }

        private static RealtimeData sonicDeltatimeUncorrected;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("sonic delta-time (uncorrected)")]
        public static RealtimeData SonicDeltatimeUncorrected
        {
            get 
            {
                if (sonicDeltatimeUncorrected == null)
                {
                    sonicDeltatimeUncorrected = new RealtimeData("sonic delta-time (uncorrected)");
                    sonicDeltatimeUncorrected.RealtimeMeasureClass = "time per length";
                    sonicDeltatimeUncorrected.Description = "XXXXXXXXXX";
                }
                return sonicDeltatimeUncorrected;
            }
        }

        private static RealtimeData sonicDensity;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("sonic density")]
        public static RealtimeData SonicDensity
        {
            get 
            {
                if (sonicDensity == null)
                {
                    sonicDensity = new RealtimeData("sonic density");
                    sonicDensity.RealtimeMeasureClass = "density";
                    sonicDensity.Description = "XXXXXXXXXX";
                }
                return sonicDensity;
            }
        }

        private static RealtimeData sonicPorosity;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("sonic porosity")]
        public static RealtimeData SonicPorosity
        {
            get 
            {
                if (sonicPorosity == null)
                {
                    sonicPorosity = new RealtimeData("sonic porosity");
                    sonicPorosity.RealtimeMeasureClass = "volume per volume";
                    sonicPorosity.Description = "XXXXXXXXXX";
                }
                return sonicPorosity;
            }
        }

        private static RealtimeData sonicPorosityCorrected;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("sonic porosity (corrected)")]
        public static RealtimeData SonicPorosityCorrected
        {
            get 
            {
                if (sonicPorosityCorrected == null)
                {
                    sonicPorosityCorrected = new RealtimeData("sonic porosity (corrected)");
                    sonicPorosityCorrected.RealtimeMeasureClass = "volume per volume";
                    sonicPorosityCorrected.Description = "XXXXXXXXXX";
                }
                return sonicPorosityCorrected;
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
                    stateOfWell.RealtimeDataType = EnumValueRealtimeType.RealtimeString;
                    stateOfWell.Description = "State of well during DST (SHUT-IN or FLOWING)";
                }
                return stateOfWell;
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
                    stokesIntensity.RealtimeDataType = EnumValueRealtimeType.RealtimeNumeric;
                    stokesIntensity.Description = "Stokes intensity values from a Distributed Temperature Survey.";
                }
                return stokesIntensity;
            }
        }

        private static RealtimeData strokeCount;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("stroke count")]
        public static RealtimeData StrokeCount
        {
            get 
            {
                if (strokeCount == null)
                {
                    strokeCount = new RealtimeData("stroke count");
                    strokeCount.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    strokeCount.Description = "XXXXXXXXXX";
                }
                return strokeCount;
            }
        }

        private static RealtimeData strokeCountTotal;
        /// <summary>
        /// Cumulative strokes for all pumps since reset. Normally reset at a major change in rig activity, e.g. from drilling to tripping, or as specified by the Operator.
        /// </summary>
        [EnumValueNameAttribute("stroke count (total)")]
        public static RealtimeData StrokeCountTotal
        {
            get 
            {
                if (strokeCountTotal == null)
                {
                    strokeCountTotal = new RealtimeData("stroke count (total)");
                    strokeCountTotal.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    strokeCountTotal.Description = "Cumulative strokes for all pumps since reset. Normally reset at a major change in rig activity, e.g. from drilling to tripping, or as specified by the Operator.";
                }
                return strokeCountTotal;
            }
        }

        private static RealtimeData strokeRate;
        /// <summary>
        /// Stroke rate for a pump, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("stroke rate")]
        public static RealtimeData StrokeRate
        {
            get 
            {
                if (strokeRate == null)
                {
                    strokeRate = new RealtimeData("stroke rate");
                    strokeRate.RealtimeMeasureClass = "operations per time";
                    strokeRate.Description = "Stroke rate for a pump, averaged over the interval.";
                }
                return strokeRate;
            }
        }

        private static RealtimeData strokeRateTotal;
        /// <summary>
        /// XXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("stroke rate total")]
        public static RealtimeData StrokeRateTotal
        {
            get 
            {
                if (strokeRateTotal == null)
                {
                    strokeRateTotal = new RealtimeData("stroke rate total");
                    strokeRateTotal.RealtimeMeasureClass = "operations per time";
                    strokeRateTotal.Description = "XXXXXXXXXX";
                }
                return strokeRateTotal;
            }
        }

        private static RealtimeData tankVolume;
        /// <summary>
        /// Volume of mud, indicated by sensors, in each of the designated compartments, averaged over the interval. NOTE: THIS REQUIRES SOMETHING TO SPEICFY THE IDENTITY OF THE 'COMPARTMENTS'.
        /// </summary>
        [EnumValueNameAttribute("tank volume")]
        public static RealtimeData TankVolume
        {
            get 
            {
                if (tankVolume == null)
                {
                    tankVolume = new RealtimeData("tank volume");
                    tankVolume.RealtimeMeasureClass = "volume";
                    tankVolume.Description = "Volume of mud, indicated by sensors, in each of the designated compartments, averaged over the interval. NOTE: THIS REQUIRES SOMETHING TO SPEICFY THE IDENTITY OF THE 'COMPARTMENTS'.";
                }
                return tankVolume;
            }
        }

        private static RealtimeData tankVolumeActive;
        /// <summary>
        /// Cumulative volume of mud, indicated by sensors, in all of the active compartments, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("tank volume (active)")]
        public static RealtimeData TankVolumeActive
        {
            get 
            {
                if (tankVolumeActive == null)
                {
                    tankVolumeActive = new RealtimeData("tank volume (active)");
                    tankVolumeActive.RealtimeMeasureClass = "volume";
                    tankVolumeActive.Description = "Cumulative volume of mud, indicated by sensors, in all of the active compartments, averaged over the interval.";
                }
                return tankVolumeActive;
            }
        }

        private static RealtimeData tankVolumeTotal;
        /// <summary>
        /// Total volume of mud, indicated by sensors in all the compartments, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("tank volume (total)")]
        public static RealtimeData TankVolumeTotal
        {
            get 
            {
                if (tankVolumeTotal == null)
                {
                    tankVolumeTotal = new RealtimeData("tank volume (total)");
                    tankVolumeTotal.RealtimeMeasureClass = "volume";
                    tankVolumeTotal.Description = "Total volume of mud, indicated by sensors in all the compartments, averaged over the interval.";
                }
                return tankVolumeTotal;
            }
        }

        private static RealtimeData tankVolumeChange;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("tank volume change")]
        public static RealtimeData TankVolumeChange
        {
            get 
            {
                if (tankVolumeChange == null)
                {
                    tankVolumeChange = new RealtimeData("tank volume change");
                    tankVolumeChange.RealtimeMeasureClass = "volume";
                    tankVolumeChange.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return tankVolumeChange;
            }
        }

        private static RealtimeData tankVolumeChangeActive;
        /// <summary>
        /// Net gain/loss of mud in all the active compartments since the Tank Volume Reset Time.
        /// </summary>
        [EnumValueNameAttribute("tank volume change (active)")]
        public static RealtimeData TankVolumeChangeActive
        {
            get 
            {
                if (tankVolumeChangeActive == null)
                {
                    tankVolumeChangeActive = new RealtimeData("tank volume change (active)");
                    tankVolumeChangeActive.RealtimeMeasureClass = "volume";
                    tankVolumeChangeActive.Description = "Net gain/loss of mud in all the active compartments since the Tank Volume Reset Time.";
                }
                return tankVolumeChangeActive;
            }
        }

        private static RealtimeData tankVolumeChangeTotal;
        /// <summary>
        /// Net gain/loss of mud in all the active compartments since the Tank Volume Reset Time .
        /// </summary>
        [EnumValueNameAttribute("tank volume change total")]
        public static RealtimeData TankVolumeChangeTotal
        {
            get 
            {
                if (tankVolumeChangeTotal == null)
                {
                    tankVolumeChangeTotal = new RealtimeData("tank volume change total");
                    tankVolumeChangeTotal.RealtimeMeasureClass = "volume";
                    tankVolumeChangeTotal.Description = "Net gain/loss of mud in all the active compartments since the Tank Volume Reset Time .";
                }
                return tankVolumeChangeTotal;
            }
        }

        private static RealtimeData timeInSlips;
        /// <summary>
        /// Time interval between setting the slips and then releasing them, for the current connection.
        /// </summary>
        [EnumValueNameAttribute("time in slips")]
        public static RealtimeData TimeInSlips
        {
            get 
            {
                if (timeInSlips == null)
                {
                    timeInSlips = new RealtimeData("time in slips");
                    timeInSlips.RealtimeMeasureClass = "time";
                    timeInSlips.Description = "Time interval between setting the slips and then releasing them, for the current connection.";
                }
                return timeInSlips;
            }
        }

        private static RealtimeData timeOutOfSlips;
        /// <summary>
        /// Elapsed out of slips time for the current connection.
        /// </summary>
        [EnumValueNameAttribute("time out of slips")]
        public static RealtimeData TimeOutOfSlips
        {
            get 
            {
                if (timeOutOfSlips == null)
                {
                    timeOutOfSlips = new RealtimeData("time out of slips");
                    timeOutOfSlips.RealtimeMeasureClass = "time";
                    timeOutOfSlips.Description = "Elapsed out of slips time for the current connection.";
                }
                return timeOutOfSlips;
            }
        }

        private static RealtimeData torqueAverage;
        /// <summary>
        /// Measured rotary torque, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("torque (average)")]
        public static RealtimeData TorqueAverage
        {
            get 
            {
                if (torqueAverage == null)
                {
                    torqueAverage = new RealtimeData("torque (average)");
                    torqueAverage.RealtimeMeasureClass = "moment of force";
                    torqueAverage.Description = "Measured rotary torque, averaged over the interval.";
                }
                return torqueAverage;
            }
        }

        private static RealtimeData torqueMaximum;
        /// <summary>
        /// Maximum rotary torque, measured over the interval.
        /// </summary>
        [EnumValueNameAttribute("torque (maximum)")]
        public static RealtimeData TorqueMaximum
        {
            get 
            {
                if (torqueMaximum == null)
                {
                    torqueMaximum = new RealtimeData("torque (maximum)");
                    torqueMaximum.RealtimeMeasureClass = "moment of force";
                    torqueMaximum.Description = "Maximum rotary torque, measured over the interval.";
                }
                return torqueMaximum;
            }
        }

        private static RealtimeData torqueForBreakoutMaximum;
        /// <summary>
        /// Maximum torque required to break out the connection.
        /// </summary>
        [EnumValueNameAttribute("torque for break-out (maximum)")]
        public static RealtimeData TorqueForBreakoutMaximum
        {
            get 
            {
                if (torqueForBreakoutMaximum == null)
                {
                    torqueForBreakoutMaximum = new RealtimeData("torque for break-out (maximum)");
                    torqueForBreakoutMaximum.RealtimeMeasureClass = "moment of force";
                    torqueForBreakoutMaximum.Description = "Maximum torque required to break out the connection.";
                }
                return torqueForBreakoutMaximum;
            }
        }

        private static RealtimeData torqueForMakeupMaximum;
        /// <summary>
        /// Maximum torque applied while making up the connection.
        /// </summary>
        [EnumValueNameAttribute("torque for make-up (maximum)")]
        public static RealtimeData TorqueForMakeupMaximum
        {
            get 
            {
                if (torqueForMakeupMaximum == null)
                {
                    torqueForMakeupMaximum = new RealtimeData("torque for make-up (maximum)");
                    torqueForMakeupMaximum.RealtimeMeasureClass = "moment of force";
                    torqueForMakeupMaximum.Description = "Maximum torque applied while making up the connection.";
                }
                return torqueForMakeupMaximum;
            }
        }

        private static RealtimeData tripGasLast;
        /// <summary>
        /// Trip gas recorded after the last trip.
        /// </summary>
        [EnumValueNameAttribute("trip gas (last)")]
        public static RealtimeData TripGasLast
        {
            get 
            {
                if (tripGasLast == null)
                {
                    tripGasLast = new RealtimeData("trip gas (last)");
                    tripGasLast.RealtimeMeasureClass = "volume per volume";
                    tripGasLast.Description = "Trip gas recorded after the last trip.";
                }
                return tripGasLast;
            }
        }

        private static RealtimeData tripNumber;
        /// <summary>
        /// Sequential number assigned to all trips, as specified by the Operator.
        /// </summary>
        [EnumValueNameAttribute("trip number")]
        public static RealtimeData TripNumber
        {
            get 
            {
                if (tripNumber == null)
                {
                    tripNumber = new RealtimeData("trip number");
                    tripNumber.RealtimeDataType = EnumValueRealtimeType.RealtimeInteger;
                    tripNumber.Description = "Sequential number assigned to all trips, as specified by the Operator.";
                }
                return tripNumber;
            }
        }

        private static RealtimeData tripTankVolume;
        /// <summary>
        /// Current volume of mud, indicated by a sensor, in a trip tank when the record is generated.
        /// </summary>
        [EnumValueNameAttribute("trip tank volume")]
        public static RealtimeData TripTankVolume
        {
            get 
            {
                if (tripTankVolume == null)
                {
                    tripTankVolume = new RealtimeData("trip tank volume");
                    tripTankVolume.RealtimeMeasureClass = "volume";
                    tripTankVolume.Description = "Current volume of mud, indicated by a sensor, in a trip tank when the record is generated.";
                }
                return tripTankVolume;
            }
        }

        private static RealtimeData turnRate;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("turn rate")]
        public static RealtimeData TurnRate
        {
            get 
            {
                if (turnRate == null)
                {
                    turnRate = new RealtimeData("turn rate");
                    turnRate.RealtimeMeasureClass = "angle per length";
                    turnRate.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return turnRate;
            }
        }

        private static RealtimeData tvdOfBit;
        /// <summary>
        /// Vertical depth of the bit at the time the record is generated.
        /// </summary>
        [EnumValueNameAttribute("TVD of bit")]
        public static RealtimeData TvdOfBit
        {
            get 
            {
                if (tvdOfBit == null)
                {
                    tvdOfBit = new RealtimeData("TVD of bit");
                    tvdOfBit.RealtimeMeasureClass = "length";
                    tvdOfBit.Description = "Vertical depth of the bit at the time the record is generated.";
                    tvdOfBit.Version = "1.4.0.0";
                }
                return tvdOfBit;
            }
        }

        private static RealtimeData tvdOfCasing;
        /// <summary>
        /// Vertical depth of the casing shoe being cemented.
        /// </summary>
        [EnumValueNameAttribute("TVD of casing")]
        public static RealtimeData TvdOfCasing
        {
            get 
            {
                if (tvdOfCasing == null)
                {
                    tvdOfCasing = new RealtimeData("TVD of casing");
                    tvdOfCasing.RealtimeMeasureClass = "length";
                    tvdOfCasing.Description = "Vertical depth of the casing shoe being cemented.";
                }
                return tvdOfCasing;
            }
        }

        private static RealtimeData tvdOfDstBottom;
        /// <summary>
        /// Vertical depth of bottom perforations, or depth of bottom packer in an open hole DST.
        /// </summary>
        [EnumValueNameAttribute("TVD of DST bottom")]
        public static RealtimeData TvdOfDstBottom
        {
            get 
            {
                if (tvdOfDstBottom == null)
                {
                    tvdOfDstBottom = new RealtimeData("TVD of DST bottom");
                    tvdOfDstBottom.RealtimeMeasureClass = "length";
                    tvdOfDstBottom.Description = "Vertical depth of bottom perforations, or depth of bottom packer in an open hole DST.";
                }
                return tvdOfDstBottom;
            }
        }

        private static RealtimeData tvdOfDstTop;
        /// <summary>
        /// Vertical depth of top perforations, or depth of top packer in an open hole DST.
        /// </summary>
        [EnumValueNameAttribute("TVD of DST top")]
        public static RealtimeData TvdOfDstTop
        {
            get 
            {
                if (tvdOfDstTop == null)
                {
                    tvdOfDstTop = new RealtimeData("TVD of DST top");
                    tvdOfDstTop.RealtimeMeasureClass = "length";
                    tvdOfDstTop.Description = "Vertical depth of top perforations, or depth of top packer in an open hole DST.";
                }
                return tvdOfDstTop;
            }
        }

        private static RealtimeData tvdOfHole;
        /// <summary>
        /// Vertical depth of the hole at the time the record is generated.
        /// </summary>
        [EnumValueNameAttribute("TVD of hole")]
        public static RealtimeData TvdOfHole
        {
            get 
            {
                if (tvdOfHole == null)
                {
                    tvdOfHole = new RealtimeData("TVD of hole");
                    tvdOfHole.RealtimeMeasureClass = "length";
                    tvdOfHole.Description = "Vertical depth of the hole at the time the record is generated.";
                }
                return tvdOfHole;
            }
        }

        private static RealtimeData velocityOfJet;
        /// <summary>
        /// Calculated velocity of the drilling fluid as it exits the bit nozzles.
        /// </summary>
        [EnumValueNameAttribute("velocity of jet")]
        public static RealtimeData VelocityOfJet
        {
            get 
            {
                if (velocityOfJet == null)
                {
                    velocityOfJet = new RealtimeData("velocity of jet");
                    velocityOfJet.RealtimeMeasureClass = "velocity";
                    velocityOfJet.Description = "Calculated velocity of the drilling fluid as it exits the bit nozzles.";
                }
                return velocityOfJet;
            }
        }

        private static RealtimeData weightOnBitAverage;
        /// <summary>
        /// Measured surface weight on the bit, averaged over the interval.
        /// </summary>
        [EnumValueNameAttribute("weight on bit (average)")]
        public static RealtimeData WeightOnBitAverage
        {
            get 
            {
                if (weightOnBitAverage == null)
                {
                    weightOnBitAverage = new RealtimeData("weight on bit (average)");
                    weightOnBitAverage.RealtimeMeasureClass = "force";
                    weightOnBitAverage.Description = "Measured surface weight on the bit, averaged over the interval.";
                }
                return weightOnBitAverage;
            }
        }

        private static RealtimeData weightOnBitMaximum;
        /// <summary>
        /// Maximum surface weight on the bit, measured over the interval.
        /// </summary>
        [EnumValueNameAttribute("weight on bit (maximum)")]
        public static RealtimeData WeightOnBitMaximum
        {
            get 
            {
                if (weightOnBitMaximum == null)
                {
                    weightOnBitMaximum = new RealtimeData("weight on bit (maximum)");
                    weightOnBitMaximum.RealtimeMeasureClass = "force";
                    weightOnBitMaximum.Description = "Maximum surface weight on the bit, measured over the interval.";
                }
                return weightOnBitMaximum;
            }
        }

        private static RealtimeData yieldPoint;
        /// <summary>
        /// Measured yield point of the mud. Where this is manually entered, it's value should remain, rather than being replaced by a NULL, until the next entry is made. The SENDER should enter a NULL if the value is no longer valid.
        /// </summary>
        [EnumValueNameAttribute("yield point")]
        public static RealtimeData YieldPoint
        {
            get 
            {
                if (yieldPoint == null)
                {
                    yieldPoint = new RealtimeData("yield point");
                    yieldPoint.RealtimeMeasureClass = "pressure";
                    yieldPoint.Description = "Measured yield point of the mud. Where this is manually entered, it's value should remain, rather than being replaced by a NULL, until the next entry is made. The SENDER should enter a NULL if the value is no longer valid.";
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
