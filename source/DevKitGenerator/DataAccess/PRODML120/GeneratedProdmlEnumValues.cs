using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.PRODML120
{
    /// <summary>
    /// Kind of Address.
    /// </summary>
    public class AddressKindEnum : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected AddressKindEnum(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the AddressKindEnum</param>
        public AddressKindEnum(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of AddressKindEnums
        /// </summary>
        /// <returns>The complete list of AddressKindEnums</returns>
        public static List<AddressKindEnum> GetList()
        {
            return GetList<AddressKindEnum>();
        }

        private static AddressKindEnum mailing;
        /// <summary>
        /// The mailing address of a business associate or facility.
        /// </summary>
        [EnumValueNameAttribute("mailing")]
        public static AddressKindEnum Mailing
        {
            get 
            {
                if (mailing == null)
                {
                    mailing = new AddressKindEnum("mailing");
                    mailing.Description = "The mailing address of a business associate or facility.";
                }
                return mailing;
            }
        }

        private static AddressKindEnum physical;
        /// <summary>
        /// The physical address - location - of a business associate or facility.
        /// </summary>
        [EnumValueNameAttribute("physical")]
        public static AddressKindEnum Physical
        {
            get 
            {
                if (physical == null)
                {
                    physical = new AddressKindEnum("physical");
                    physical.Description = "The physical address - location - of a business associate or facility.";
                }
                return physical;
            }
        }

        private static AddressKindEnum both;
        /// <summary>
        /// Both the mailing address and the physical address.
        /// </summary>
        [EnumValueNameAttribute("both")]
        public static AddressKindEnum Both
        {
            get 
            {
                if (both == null)
                {
                    both = new AddressKindEnum("both");
                    both.Description = "Both the mailing address and the physical address.";
                }
                return both;
            }
        }

        private static AddressKindEnum unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static AddressKindEnum Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new AddressKindEnum("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// What kind of email (or phone) is this? Is it a 
    ///		work phone? Or personal? Or is a permanent one?
    /// </summary>
    public class AddressQualifier : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected AddressQualifier(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the AddressQualifier</param>
        public AddressQualifier(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of AddressQualifiers
        /// </summary>
        /// <returns>The complete list of AddressQualifiers</returns>
        public static List<AddressQualifier> GetList()
        {
            return GetList<AddressQualifier>();
        }

        private static AddressQualifier personal;
        /// <summary>
        /// The phone number or email address is personal, and can probably be received at the business associates home.
        /// </summary>
        [EnumValueNameAttribute("personal")]
        public static AddressQualifier Personal
        {
            get 
            {
                if (personal == null)
                {
                    personal = new AddressQualifier("personal");
                    personal.Description = "The phone number or email address is personal, and can probably be received at the business associates home.";
                }
                return personal;
            }
        }

        private static AddressQualifier work;
        /// <summary>
        /// The phone number or email is a work number, which is subject to change if the business associate changes jobs.
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static AddressQualifier Work
        {
            get 
            {
                if (work == null)
                {
                    work = new AddressQualifier("work");
                    work.Description = "The phone number or email is a work number, which is subject to change if the business associate changes jobs.";
                }
                return work;
            }
        }

        private static AddressQualifier permanent;
        /// <summary>
        /// The phone number or email is permanent, which will still be valid if the person changes home or work locations.
        /// </summary>
        [EnumValueNameAttribute("permanent")]
        public static AddressQualifier Permanent
        {
            get 
            {
                if (permanent == null)
                {
                    permanent = new AddressQualifier("permanent");
                    permanent.Description = "The phone number or email is permanent, which will still be valid if the person changes home or work locations.";
                }
                return permanent;
            }
        }

        private static AddressQualifier unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static AddressQualifier Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new AddressQualifier("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines a type of destination.
    /// </summary>
    public class BalanceDestinationType : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected BalanceDestinationType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the BalanceDestinationType</param>
        public BalanceDestinationType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of BalanceDestinationTypes
        /// </summary>
        /// <returns>The complete list of BalanceDestinationTypes</returns>
        public static List<BalanceDestinationType> GetList()
        {
            return GetList<BalanceDestinationType>();
        }

        private static BalanceDestinationType harbor;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("harbor")]
        public static BalanceDestinationType Harbor
        {
            get 
            {
                if (harbor == null)
                {
                    harbor = new BalanceDestinationType("harbor");
                    harbor.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return harbor;
            }
        }

        private static BalanceDestinationType terminal;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("terminal")]
        public static BalanceDestinationType Terminal
        {
            get 
            {
                if (terminal == null)
                {
                    terminal = new BalanceDestinationType("terminal");
                    terminal.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return terminal;
            }
        }

        private static BalanceDestinationType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BalanceDestinationType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new BalanceDestinationType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines a type of event related to a product balance.
    /// </summary>
    public class BalanceEventKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected BalanceEventKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the BalanceEventKind</param>
        public BalanceEventKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of BalanceEventKinds
        /// </summary>
        /// <returns>The complete list of BalanceEventKinds</returns>
        public static List<BalanceEventKind> GetList()
        {
            return GetList<BalanceEventKind>();
        }

        private static BalanceEventKind xxxxxxx;
        /// <summary>
        /// XXXXXXXXXXXXXXXXXXXXXX
        /// </summary>
        [EnumValueNameAttribute("XXXXXXX")]
        public static BalanceEventKind Xxxxxxx
        {
            get 
            {
                if (xxxxxxx == null)
                {
                    xxxxxxx = new BalanceEventKind("XXXXXXX");
                    xxxxxxx.Description = "XXXXXXXXXXXXXXXXXXXXXX";
                }
                return xxxxxxx;
            }
        }

        private static BalanceEventKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BalanceEventKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new BalanceEventKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines a subdivision of a flow related to the stock balance.
    /// </summary>
    public class BalanceFlowPart : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected BalanceFlowPart(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the BalanceFlowPart</param>
        public BalanceFlowPart(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of BalanceFlowParts
        /// </summary>
        /// <returns>The complete list of BalanceFlowParts</returns>
        public static List<BalanceFlowPart> GetList()
        {
            return GetList<BalanceFlowPart>();
        }

        private static BalanceFlowPart openingBalance;
        /// <summary>
        /// A volume that is the total volume on stock at the beginning of a time period.
        /// </summary>
        [EnumValueNameAttribute("opening balance")]
        public static BalanceFlowPart OpeningBalance
        {
            get 
            {
                if (openingBalance == null)
                {
                    openingBalance = new BalanceFlowPart("opening balance");
                    openingBalance.Description = "A volume that is the total volume on stock at the beginning of a time period.";
                }
                return openingBalance;
            }
        }

        private static BalanceFlowPart closingBalance;
        /// <summary>
        /// A volume that is the total volume on stock at the end of a time period.
        /// </summary>
        [EnumValueNameAttribute("closing balance")]
        public static BalanceFlowPart ClosingBalance
        {
            get 
            {
                if (closingBalance == null)
                {
                    closingBalance = new BalanceFlowPart("closing balance");
                    closingBalance.Description = "A volume that is the total volume on stock at the end of a time period.";
                }
                return closingBalance;
            }
        }

        private static BalanceFlowPart inputToStorage;
        /// <summary>
        /// A volume that is the total volume of additions to a stock within a given time period.
        /// </summary>
        [EnumValueNameAttribute("input to storage")]
        public static BalanceFlowPart InputToStorage
        {
            get 
            {
                if (inputToStorage == null)
                {
                    inputToStorage = new BalanceFlowPart("input to storage");
                    inputToStorage.Description = "A volume that is the total volume of additions to a stock within a given time period.";
                }
                return inputToStorage;
            }
        }

        private static BalanceFlowPart liftingEntitlement;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("lifting entitlement")]
        public static BalanceFlowPart LiftingEntitlement
        {
            get 
            {
                if (liftingEntitlement == null)
                {
                    liftingEntitlement = new BalanceFlowPart("lifting entitlement");
                    liftingEntitlement.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return liftingEntitlement;
            }
        }

        private static BalanceFlowPart liftingEntitlementRemaining;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("lifting entitlement remaining")]
        public static BalanceFlowPart LiftingEntitlementRemaining
        {
            get 
            {
                if (liftingEntitlementRemaining == null)
                {
                    liftingEntitlementRemaining = new BalanceFlowPart("lifting entitlement remaining");
                    liftingEntitlementRemaining.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return liftingEntitlementRemaining;
            }
        }

        private static BalanceFlowPart gainloss;
        /// <summary>
        /// A volume that is a lack of proper proportion or relation between the corresponding input and liftings transactions.
        /// </summary>
        [EnumValueNameAttribute("gain/loss")]
        public static BalanceFlowPart Gainloss
        {
            get 
            {
                if (gainloss == null)
                {
                    gainloss = new BalanceFlowPart("gain/loss");
                    gainloss.Description = "A volume that is a lack of proper proportion or relation between the corresponding input and liftings transactions.";
                }
                return gainloss;
            }
        }

        private static BalanceFlowPart adjustedClosing;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("adjusted closing")]
        public static BalanceFlowPart AdjustedClosing
        {
            get 
            {
                if (adjustedClosing == null)
                {
                    adjustedClosing = new BalanceFlowPart("adjusted closing");
                    adjustedClosing.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return adjustedClosing;
            }
        }

        private static BalanceFlowPart lifted;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("lifted")]
        public static BalanceFlowPart Lifted
        {
            get 
            {
                if (lifted == null)
                {
                    lifted = new BalanceFlowPart("lifted");
                    lifted.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return lifted;
            }
        }

        private static BalanceFlowPart productionValueAdjustment;
        /// <summary>
        /// A value that is adjusted due to a change in the value of a product.
        /// </summary>
        [EnumValueNameAttribute("production -- value adjustment")]
        public static BalanceFlowPart ProductionValueAdjustment
        {
            get 
            {
                if (productionValueAdjustment == null)
                {
                    productionValueAdjustment = new BalanceFlowPart("production -- value adjustment");
                    productionValueAdjustment.Description = "A value that is adjusted due to a change in the value of a product.";
                }
                return productionValueAdjustment;
            }
        }

        private static BalanceFlowPart transaction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("transaction")]
        public static BalanceFlowPart Transaction
        {
            get 
            {
                if (transaction == null)
                {
                    transaction = new BalanceFlowPart("transaction");
                    transaction.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return transaction;
            }
        }

        private static BalanceFlowPart completedLifting;
        /// <summary>
        /// A volume that is the total volume of a hydrocarbon product that is exported from a stock within a given time period.
        /// </summary>
        [EnumValueNameAttribute("completed lifting")]
        public static BalanceFlowPart CompletedLifting
        {
            get 
            {
                if (completedLifting == null)
                {
                    completedLifting = new BalanceFlowPart("completed lifting");
                    completedLifting.Description = "A volume that is the total volume of a hydrocarbon product that is exported from a stock within a given time period.";
                }
                return completedLifting;
            }
        }

        private static BalanceFlowPart productionImbalance;
        /// <summary>
        /// A gas volume that is the difference between gas volume entering and exiting a shipper's nomination portfolio. This will take into account all differences whatever the time or reason it occurs.
        /// </summary>
        [EnumValueNameAttribute("production imbalance")]
        public static BalanceFlowPart ProductionImbalance
        {
            get 
            {
                if (productionImbalance == null)
                {
                    productionImbalance = new BalanceFlowPart("production imbalance");
                    productionImbalance.Description = "A gas volume that is the difference between gas volume entering and exiting a shipper's nomination portfolio. This will take into account all differences whatever the time or reason it occurs.";
                }
                return productionImbalance;
            }
        }

        private static BalanceFlowPart partialLifting;
        /// <summary>
        /// A volume that is the volume of a hydrocarbon product lifting up to a (not completed) determined point in time.
        /// </summary>
        [EnumValueNameAttribute("partial lifting")]
        public static BalanceFlowPart PartialLifting
        {
            get 
            {
                if (partialLifting == null)
                {
                    partialLifting = new BalanceFlowPart("partial lifting");
                    partialLifting.Description = "A volume that is the volume of a hydrocarbon product lifting up to a (not completed) determined point in time.";
                }
                return partialLifting;
            }
        }

        private static BalanceFlowPart closingStorageInventory;
        /// <summary>
        /// A closing storage balance that is adjusted according to imbalance at end of period.
        /// </summary>
        [EnumValueNameAttribute("closing storage inventory")]
        public static BalanceFlowPart ClosingStorageInventory
        {
            get 
            {
                if (closingStorageInventory == null)
                {
                    closingStorageInventory = new BalanceFlowPart("closing storage inventory");
                    closingStorageInventory.Description = "A closing storage balance that is adjusted according to imbalance at end of period.";
                }
                return closingStorageInventory;
            }
        }

        private static BalanceFlowPart tankerLifting;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("tanker lifting")]
        public static BalanceFlowPart TankerLifting
        {
            get 
            {
                if (tankerLifting == null)
                {
                    tankerLifting = new BalanceFlowPart("tanker lifting");
                    tankerLifting.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return tankerLifting;
            }
        }

        private static BalanceFlowPart pipelineLifting;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("pipeline lifting")]
        public static BalanceFlowPart PipelineLifting
        {
            get 
            {
                if (pipelineLifting == null)
                {
                    pipelineLifting = new BalanceFlowPart("pipeline lifting");
                    pipelineLifting.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return pipelineLifting;
            }
        }

        private static BalanceFlowPart opflex;
        /// <summary>
        /// A gas volume that is the unused and availiable quantity of gas within a gas transportation system and/or at one or many gas producting fields that is accessible by the operator responsible for gas transportation for the purposes of alleviating field curtailment.
        /// </summary>
        [EnumValueNameAttribute("opflex")]
        public static BalanceFlowPart Opflex
        {
            get 
            {
                if (opflex == null)
                {
                    opflex = new BalanceFlowPart("opflex");
                    opflex.Description = "A gas volume that is the unused and availiable quantity of gas within a gas transportation system and/or at one or many gas producting fields that is accessible by the operator responsible for gas transportation for the purposes of alleviating field curtailment.";
                }
                return opflex;
            }
        }

        private static BalanceFlowPart linepack;
        /// <summary>
        /// A gas volume that is the quantity of gas which the operator responsible for gas transportation decides must be provided by the gas producing fields in order to make deliveries as requested by gas shippers and provide operating tolerances.
        /// </summary>
        [EnumValueNameAttribute("linepack")]
        public static BalanceFlowPart Linepack
        {
            get 
            {
                if (linepack == null)
                {
                    linepack = new BalanceFlowPart("linepack");
                    linepack.Description = "A gas volume that is the quantity of gas which the operator responsible for gas transportation decides must be provided by the gas producing fields in order to make deliveries as requested by gas shippers and provide operating tolerances.";
                }
                return linepack;
            }
        }

        private static BalanceFlowPart transfer;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("transfer")]
        public static BalanceFlowPart Transfer
        {
            get 
            {
                if (transfer == null)
                {
                    transfer = new BalanceFlowPart("transfer");
                    transfer.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return transfer;
            }
        }

        private static BalanceFlowPart productionMassAdjustment;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("production - mass adjustment")]
        public static BalanceFlowPart ProductionMassAdjustment
        {
            get 
            {
                if (productionMassAdjustment == null)
                {
                    productionMassAdjustment = new BalanceFlowPart("production - mass adjustment");
                    productionMassAdjustment.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return productionMassAdjustment;
            }
        }

        private static BalanceFlowPart swap;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("swap")]
        public static BalanceFlowPart Swap
        {
            get 
            {
                if (swap == null)
                {
                    swap = new BalanceFlowPart("swap");
                    swap.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return swap;
            }
        }

        private static BalanceFlowPart unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BalanceFlowPart Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new BalanceFlowPart("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines a type of business unit.
    /// </summary>
    public class BusinessUnitKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected BusinessUnitKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the BusinessUnitKind</param>
        public BusinessUnitKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of BusinessUnitKinds
        /// </summary>
        /// <returns>The complete list of BusinessUnitKinds</returns>
        public static List<BusinessUnitKind> GetList()
        {
            return GetList<BusinessUnitKind>();
        }

        private static BusinessUnitKind company;
        /// <summary>
        /// xxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("company")]
        public static BusinessUnitKind Company
        {
            get 
            {
                if (company == null)
                {
                    company = new BusinessUnitKind("company");
                    company.Description = "xxxxxxxxxxxxx";
                }
                return company;
            }
        }

        private static BusinessUnitKind field;
        /// <summary>
        /// xxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("field")]
        public static BusinessUnitKind Field
        {
            get 
            {
                if (field == null)
                {
                    field = new BusinessUnitKind("field");
                    field.Description = "xxxxxxxxxxxxx";
                }
                return field;
            }
        }

        private static BusinessUnitKind license;
        /// <summary>
        /// xxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("license")]
        public static BusinessUnitKind License
        {
            get 
            {
                if (license == null)
                {
                    license = new BusinessUnitKind("license");
                    license.Description = "xxxxxxxxxxxxx";
                }
                return license;
            }
        }

        private static BusinessUnitKind businessArea;
        /// <summary>
        /// xxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("business area")]
        public static BusinessUnitKind BusinessArea
        {
            get 
            {
                if (businessArea == null)
                {
                    businessArea = new BusinessUnitKind("business area");
                    businessArea.Description = "xxxxxxxxxxxxx";
                }
                return businessArea;
            }
        }

        private static BusinessUnitKind platform;
        /// <summary>
        /// xxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("platform")]
        public static BusinessUnitKind Platform
        {
            get 
            {
                if (platform == null)
                {
                    platform = new BusinessUnitKind("platform");
                    platform.Description = "xxxxxxxxxxxxx";
                }
                return platform;
            }
        }

        private static BusinessUnitKind terminal;
        /// <summary>
        /// xxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("terminal")]
        public static BusinessUnitKind Terminal
        {
            get 
            {
                if (terminal == null)
                {
                    terminal = new BusinessUnitKind("terminal");
                    terminal.Description = "xxxxxxxxxxxxx";
                }
                return terminal;
            }
        }

        private static BusinessUnitKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BusinessUnitKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new BusinessUnitKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines the calculation methods available for "filling in" values in an indexed set.
    /// </summary>
    public class CalculationMethod : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected CalculationMethod(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the CalculationMethod</param>
        public CalculationMethod(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of CalculationMethods
        /// </summary>
        /// <returns>The complete list of CalculationMethods</returns>
        public static List<CalculationMethod> GetList()
        {
            return GetList<CalculationMethod>();
        }

        private static CalculationMethod none;
        /// <summary>
        /// No calculations are performed to create data where none exists at index points within an existing set of data.
        /// </summary>
        [EnumValueNameAttribute("none")]
        public static CalculationMethod None
        {
            get 
            {
                if (none == null)
                {
                    none = new CalculationMethod("none");
                    none.Description = "No calculations are performed to create data where none exists at index points within an existing set of data.";
                }
                return none;
            }
        }

        private static CalculationMethod stepWiseConstant;
        /// <summary>
        /// The value is held constant until the next index point.
        /// </summary>
        [EnumValueNameAttribute("step wise constant")]
        public static CalculationMethod StepWiseConstant
        {
            get 
            {
                if (stepWiseConstant == null)
                {
                    stepWiseConstant = new CalculationMethod("step wise constant");
                    stepWiseConstant.Description = "The value is held constant until the next index point.";
                }
                return stepWiseConstant;
            }
        }

        private static CalculationMethod unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static CalculationMethod Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new CalculationMethod("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The preferred method of contacting a business associate.
    /// </summary>
    public class ContactPreference : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ContactPreference(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ContactPreference</param>
        public ContactPreference(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ContactPreferences
        /// </summary>
        /// <returns>The complete list of ContactPreferences</returns>
        public static List<ContactPreference> GetList()
        {
            return GetList<ContactPreference>();
        }

        private static ContactPreference businessMail;
        /// <summary>
        /// Postal mail at the business address.
        /// </summary>
        [EnumValueNameAttribute("business mail")]
        public static ContactPreference BusinessMail
        {
            get 
            {
                if (businessMail == null)
                {
                    businessMail = new ContactPreference("business mail");
                    businessMail.Description = "Postal mail at the business address.";
                }
                return businessMail;
            }
        }

        private static ContactPreference businessFax;
        /// <summary>
        /// Business fax.
        /// </summary>
        [EnumValueNameAttribute("business fax")]
        public static ContactPreference BusinessFax
        {
            get 
            {
                if (businessFax == null)
                {
                    businessFax = new ContactPreference("business fax");
                    businessFax.Description = "Business fax.";
                }
                return businessFax;
            }
        }

        private static ContactPreference businessEmail;
        /// <summary>
        /// Business email.
        /// </summary>
        [EnumValueNameAttribute("business email")]
        public static ContactPreference BusinessEmail
        {
            get 
            {
                if (businessEmail == null)
                {
                    businessEmail = new ContactPreference("business email");
                    businessEmail.Description = "Business email.";
                }
                return businessEmail;
            }
        }

        private static ContactPreference businessPhone;
        /// <summary>
        /// Business voice phone.
        /// </summary>
        [EnumValueNameAttribute("business phone")]
        public static ContactPreference BusinessPhone
        {
            get 
            {
                if (businessPhone == null)
                {
                    businessPhone = new ContactPreference("business phone");
                    businessPhone.Description = "Business voice phone.";
                }
                return businessPhone;
            }
        }

        private static ContactPreference mobile;
        /// <summary>
        /// Mobile phone.
        /// </summary>
        [EnumValueNameAttribute("mobile")]
        public static ContactPreference Mobile
        {
            get 
            {
                if (mobile == null)
                {
                    mobile = new ContactPreference("mobile");
                    mobile.Description = "Mobile phone.";
                }
                return mobile;
            }
        }

        private static ContactPreference pager;
        /// <summary>
        /// Pager.
        /// </summary>
        [EnumValueNameAttribute("pager")]
        public static ContactPreference Pager
        {
            get 
            {
                if (pager == null)
                {
                    pager = new ContactPreference("pager");
                    pager.Description = "Pager.";
                }
                return pager;
            }
        }

        private static ContactPreference personalFax;
        /// <summary>
        /// Personal fax.
        /// </summary>
        [EnumValueNameAttribute("personal fax")]
        public static ContactPreference PersonalFax
        {
            get 
            {
                if (personalFax == null)
                {
                    personalFax = new ContactPreference("personal fax");
                    personalFax.Description = "Personal fax.";
                }
                return personalFax;
            }
        }

        private static ContactPreference personalEmail;
        /// <summary>
        /// Personal email.
        /// </summary>
        [EnumValueNameAttribute("personal email")]
        public static ContactPreference PersonalEmail
        {
            get 
            {
                if (personalEmail == null)
                {
                    personalEmail = new ContactPreference("personal email");
                    personalEmail.Description = "Personal email.";
                }
                return personalEmail;
            }
        }

        private static ContactPreference personalMail;
        /// <summary>
        /// Postal mail at the personal address.
        /// </summary>
        [EnumValueNameAttribute("personal mail")]
        public static ContactPreference PersonalMail
        {
            get 
            {
                if (personalMail == null)
                {
                    personalMail = new ContactPreference("personal mail");
                    personalMail.Description = "Postal mail at the personal address.";
                }
                return personalMail;
            }
        }

        private static ContactPreference personalPhone;
        /// <summary>
        /// Personal voice phone.
        /// </summary>
        [EnumValueNameAttribute("personal phone")]
        public static ContactPreference PersonalPhone
        {
            get 
            {
                if (personalPhone == null)
                {
                    personalPhone = new ContactPreference("personal phone");
                    personalPhone.Description = "Personal voice phone.";
                }
                return personalPhone;
            }
        }

        private static ContactPreference unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ContactPreference Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ContactPreference("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The type of personnel grouping.
    /// </summary>
    public class CrewType : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected CrewType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the CrewType</param>
        public CrewType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of CrewTypes
        /// </summary>
        /// <returns>The complete list of CrewTypes</returns>
        public static List<CrewType> GetList()
        {
            return GetList<CrewType>();
        }

        private static CrewType cateringCrew;
        /// <summary>
        /// A count that is the number of persons from the catering contractor spending the night at the installation.
        /// </summary>
        [EnumValueNameAttribute("catering crew")]
        public static CrewType CateringCrew
        {
            get 
            {
                if (cateringCrew == null)
                {
                    cateringCrew = new CrewType("catering crew");
                    cateringCrew.Description = "A count that is the number of persons from the catering contractor spending the night at the installation.";
                }
                return cateringCrew;
            }
        }

        private static CrewType contractorCrew;
        /// <summary>
        /// A count that is the number of persons from other than operator spending the night at the installation.
        /// </summary>
        [EnumValueNameAttribute("contractor crew")]
        public static CrewType ContractorCrew
        {
            get 
            {
                if (contractorCrew == null)
                {
                    contractorCrew = new CrewType("contractor crew");
                    contractorCrew.Description = "A count that is the number of persons from other than operator spending the night at the installation.";
                }
                return contractorCrew;
            }
        }

        private static CrewType dayVisitors;
        /// <summary>
        /// A count that is the number of persons visiting the installation but not spending the night at the installation.
        /// </summary>
        [EnumValueNameAttribute("day visitors")]
        public static CrewType DayVisitors
        {
            get 
            {
                if (dayVisitors == null)
                {
                    dayVisitors = new CrewType("day visitors");
                    dayVisitors.Description = "A count that is the number of persons visiting the installation but not spending the night at the installation.";
                }
                return dayVisitors;
            }
        }

        private static CrewType drillingContractCrew;
        /// <summary>
        /// A count that is the number of persons from the drilling contractor spending the night at the installation.
        /// </summary>
        [EnumValueNameAttribute("drilling contract crew")]
        public static CrewType DrillingContractCrew
        {
            get 
            {
                if (drillingContractCrew == null)
                {
                    drillingContractCrew = new CrewType("drilling contract crew");
                    drillingContractCrew.Description = "A count that is the number of persons from the drilling contractor spending the night at the installation.";
                }
                return drillingContractCrew;
            }
        }

        private static CrewType ownCrew;
        /// <summary>
        /// A count that is the number of persons from the operator normally working on the installation and spending the night there.
        /// </summary>
        [EnumValueNameAttribute("own crew")]
        public static CrewType OwnCrew
        {
            get 
            {
                if (ownCrew == null)
                {
                    ownCrew = new CrewType("own crew");
                    ownCrew.Description = "A count that is the number of persons from the operator normally working on the installation and spending the night there.";
                }
                return ownCrew;
            }
        }

        private static CrewType ownOtherCrew;
        /// <summary>
        /// A count that is the number of persons from the operator normally not working on the installation, but spending the night there.
        /// </summary>
        [EnumValueNameAttribute("own other crew")]
        public static CrewType OwnOtherCrew
        {
            get 
            {
                if (ownOtherCrew == null)
                {
                    ownOtherCrew = new CrewType("own other crew");
                    ownOtherCrew.Description = "A count that is the number of persons from the operator normally not working on the installation, but spending the night there.";
                }
                return ownOtherCrew;
            }
        }

        private static CrewType otherCrew;
        /// <summary>
        /// A count that is the number of persons from an unknown source normally not working on the installation, but spending the night there.
        /// </summary>
        [EnumValueNameAttribute("other crew")]
        public static CrewType OtherCrew
        {
            get 
            {
                if (otherCrew == null)
                {
                    otherCrew = new CrewType("other crew");
                    otherCrew.Description = "A count that is the number of persons from an unknown source normally not working on the installation, but spending the night there.";
                }
                return otherCrew;
            }
        }

        private static CrewType personnelOnBoard;
        /// <summary>
        /// A count of the total personnel on board.
        /// </summary>
        [EnumValueNameAttribute("personnel on board")]
        public static CrewType PersonnelOnBoard
        {
            get 
            {
                if (personnelOnBoard == null)
                {
                    personnelOnBoard = new CrewType("personnel on board");
                    personnelOnBoard.Description = "A count of the total personnel on board.";
                }
                return personnelOnBoard;
            }
        }

        private static CrewType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static CrewType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new CrewType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class DataQuality : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected DataQuality(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the DataQuality</param>
        public DataQuality(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of DataQualitys
        /// </summary>
        /// <returns>The complete list of DataQualitys</returns>
        public static List<DataQuality> GetList()
        {
            return GetList<DataQuality>();
        }

        private static DataQuality best;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("best")]
        public static DataQuality Best
        {
            get 
            {
                if (best == null)
                {
                    best = new DataQuality("best");
                    best.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return best;
            }
        }

        private static DataQuality good;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("good")]
        public static DataQuality Good
        {
            get 
            {
                if (good == null)
                {
                    good = new DataQuality("good");
                    good.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return good;
            }
        }

        private static DataQuality fair;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("fair")]
        public static DataQuality Fair
        {
            get 
            {
                if (fair == null)
                {
                    fair = new DataQuality("fair");
                    fair.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return fair;
            }
        }

        private static DataQuality poor;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("poor")]
        public static DataQuality Poor
        {
            get 
            {
                if (poor == null)
                {
                    poor = new DataQuality("poor");
                    poor.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return poor;
            }
        }

        private static DataQuality invalid;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("invalid")]
        public static DataQuality Invalid
        {
            get 
            {
                if (invalid == null)
                {
                    invalid = new DataQuality("invalid");
                    invalid.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return invalid;
            }
        }

        private static DataQuality unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static DataQuality Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new DataQuality("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The meaning of the endpoint for min/max query parameters 
    ///			on "growing objects".
    /// </summary>
    public class EndpointQualifier : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected EndpointQualifier(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the EndpointQualifier</param>
        public EndpointQualifier(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of EndpointQualifiers
        /// </summary>
        /// <returns>The complete list of EndpointQualifiers</returns>
        public static List<EndpointQualifier> GetList()
        {
            return GetList<EndpointQualifier>();
        }

        private static EndpointQualifier inclusive;
        /// <summary>
        /// The endpoint of the range is inclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be within the range.
        /// </summary>
        [EnumValueNameAttribute("inclusive")]
        public static EndpointQualifier Inclusive
        {
            get 
            {
                if (inclusive == null)
                {
                    inclusive = new EndpointQualifier("inclusive");
                    inclusive.Description = "The endpoint of the range is inclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be within the range.";
                }
                return inclusive;
            }
        }

        private static EndpointQualifier exclusive;
        /// <summary>
        /// The endpoint of the range is exclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be outside the range.
        /// </summary>
        [EnumValueNameAttribute("exclusive")]
        public static EndpointQualifier Exclusive
        {
            get 
            {
                if (exclusive == null)
                {
                    exclusive = new EndpointQualifier("exclusive");
                    exclusive.Description = "The endpoint of the range is exclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be outside the range.";
                }
                return exclusive;
            }
        }

        private static EndpointQualifier extensive;
        /// <summary>
        /// The endpoint of the range may be extended to the first encountered value if an exact value match is not found. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. Basically, this concept is designed to support interpolation across an undefined point.
        /// </summary>
        [EnumValueNameAttribute("extensive")]
        public static EndpointQualifier Extensive
        {
            get 
            {
                if (extensive == null)
                {
                    extensive = new EndpointQualifier("extensive");
                    extensive.Description = "The endpoint of the range may be extended to the first encountered value if an exact value match is not found. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. Basically, this concept is designed to support interpolation across an undefined point.";
                }
                return extensive;
            }
        }

        private static EndpointQualifier overlapExtensive;
        /// <summary>
        /// The endpoint of the range may be extended to the first encountered value if the interval is overlapped with the index interval. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. This concept is designed to select ALL nodes whose index interval overlap with the query range.
        /// </summary>
        [EnumValueNameAttribute("overlap extensive")]
        public static EndpointQualifier OverlapExtensive
        {
            get 
            {
                if (overlapExtensive == null)
                {
                    overlapExtensive = new EndpointQualifier("overlap extensive");
                    overlapExtensive.Description = "The endpoint of the range may be extended to the first encountered value if the interval is overlapped with the index interval. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. This concept is designed to select ALL nodes whose index interval overlap with the query range.";
                }
                return overlapExtensive;
            }
        }

        private static EndpointQualifier unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static EndpointQualifier Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new EndpointQualifier("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The meaning of the endpoint for simpe interval.
    /// </summary>
    public class EndpointQualifierInterval : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected EndpointQualifierInterval(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the EndpointQualifierInterval</param>
        public EndpointQualifierInterval(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of EndpointQualifierIntervals
        /// </summary>
        /// <returns>The complete list of EndpointQualifierIntervals</returns>
        public static List<EndpointQualifierInterval> GetList()
        {
            return GetList<EndpointQualifierInterval>();
        }

        private static EndpointQualifierInterval inclusive;
        /// <summary>
        /// The endpoint of the interval is inclusive of the specified value.
        /// </summary>
        [EnumValueNameAttribute("inclusive")]
        public static EndpointQualifierInterval Inclusive
        {
            get 
            {
                if (inclusive == null)
                {
                    inclusive = new EndpointQualifierInterval("inclusive");
                    inclusive.Description = "The endpoint of the interval is inclusive of the specified value.";
                }
                return inclusive;
            }
        }

        private static EndpointQualifierInterval exclusive;
        /// <summary>
        /// The endpoint of the interval is exclusive of the specified value.
        /// </summary>
        [EnumValueNameAttribute("exclusive")]
        public static EndpointQualifierInterval Exclusive
        {
            get 
            {
                if (exclusive == null)
                {
                    exclusive = new EndpointQualifierInterval("exclusive");
                    exclusive.Description = "The endpoint of the interval is exclusive of the specified value.";
                }
                return exclusive;
            }
        }

        private static EndpointQualifierInterval unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static EndpointQualifierInterval Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new EndpointQualifierInterval("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Kind of equation of state model.
    /// </summary>
    public class EosModelKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected EosModelKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the EosModelKind</param>
        public EosModelKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of EosModelKinds
        /// </summary>
        /// <returns>The complete list of EosModelKinds</returns>
        public static List<EosModelKind> GetList()
        {
            return GetList<EosModelKind>();
        }

        private static EosModelKind bwrs;
        /// <summary>
        /// A modification of the Benedict-Webb-Rubin equation of state by Professor Kenneth E. Starling of the University of Oklahoma.
        /// </summary>
        [EnumValueNameAttribute("bwrs")]
        public static EosModelKind Bwrs
        {
            get 
            {
                if (bwrs == null)
                {
                    bwrs = new EosModelKind("bwrs");
                    bwrs.Description = "A modification of the Benedict-Webb-Rubin equation of state by Professor Kenneth E. Starling of the University of Oklahoma.";
                }
                return bwrs;
            }
        }

        private static EosModelKind cubeos;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("cubeos")]
        public static EosModelKind Cubeos
        {
            get 
            {
                if (cubeos == null)
                {
                    cubeos = new EosModelKind("cubeos");
                    cubeos.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cubeos;
            }
        }

        private static EosModelKind pr;
        /// <summary>
        /// Peng-Robinson equation of state.
        /// </summary>
        [EnumValueNameAttribute("pr")]
        public static EosModelKind Pr
        {
            get 
            {
                if (pr == null)
                {
                    pr = new EosModelKind("pr");
                    pr.Description = "Peng-Robinson equation of state.";
                }
                return pr;
            }
        }

        private static EosModelKind prvt;
        /// <summary>
        /// Peng-Robinson with volume translation.
        /// </summary>
        [EnumValueNameAttribute("prvt")]
        public static EosModelKind Prvt
        {
            get 
            {
                if (prvt == null)
                {
                    prvt = new EosModelKind("prvt");
                    prvt.Description = "Peng-Robinson with volume translation.";
                }
                return prvt;
            }
        }

        private static EosModelKind srk;
        /// <summary>
        /// Soave modification of Redlich-Kwong equation of state.
        /// </summary>
        [EnumValueNameAttribute("srk")]
        public static EosModelKind Srk
        {
            get 
            {
                if (srk == null)
                {
                    srk = new EosModelKind("srk");
                    srk.Description = "Soave modification of Redlich-Kwong equation of state.";
                }
                return srk;
            }
        }

        private static EosModelKind srkvt;
        /// <summary>
        /// Soave-Redlich-Kwong with volume translation.
        /// </summary>
        [EnumValueNameAttribute("srkvt")]
        public static EosModelKind Srkvt
        {
            get 
            {
                if (srkvt == null)
                {
                    srkvt = new EosModelKind("srkvt");
                    srkvt.Description = "Soave-Redlich-Kwong with volume translation.";
                }
                return srkvt;
            }
        }

        private static EosModelKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static EosModelKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new EosModelKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines kinds of facility parameters.
    /// </summary>
    public class FacilityParameter : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FacilityParameter(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FacilityParameter</param>
        public FacilityParameter(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FacilityParameters
        /// </summary>
        /// <returns>The complete list of FacilityParameters</returns>
        public static List<FacilityParameter> GetList()
        {
            return GetList<FacilityParameter>();
        }

        private static FacilityParameter available;
        /// <summary>
        /// Indicates the availablity of the facility. This should be implemented as a string value. A value of "true" indicates that it is available for use. That is, it may be currently shut-down but it can be restarted. A value of "false" indicates that the faility is not available to be used. That is, it cannot be restarted at this time.
        /// </summary>
        [EnumValueNameAttribute("available")]
        public static FacilityParameter Available
        {
            get 
            {
                if (available == null)
                {
                    available = new FacilityParameter("available");
                    available.Description = "Indicates the availablity of the facility. This should be implemented as a string value. A value of \"true\" indicates that it is available for use. That is, it may be currently shut-down but it can be restarted. A value of \"false\" indicates that the faility is not available to be used. That is, it cannot be restarted at this time.";
                }
                return available;
            }
        }

        private static FacilityParameter availableRoom;
        /// <summary>
        /// Defines the unoccupied volume of a tank. Zero indicates that the tank is full. This should be implemented as a volume measure.
        /// </summary>
        [EnumValueNameAttribute("available room")]
        public static FacilityParameter AvailableRoom
        {
            get 
            {
                if (availableRoom == null)
                {
                    availableRoom = new FacilityParameter("available room");
                    availableRoom.Description = "Defines the unoccupied volume of a tank. Zero indicates that the tank is full. This should be implemented as a volume measure.";
                }
                return availableRoom;
            }
        }

        private static FacilityParameter blockValveStatus;
        /// <summary>
        /// Indicates the status of a block valve. This should be implemented as a string value. A value of "open" indicates that it is open. A value of "closed" indicates that it is closed.
        /// </summary>
        [EnumValueNameAttribute("block valve status")]
        public static FacilityParameter BlockValveStatus
        {
            get 
            {
                if (blockValveStatus == null)
                {
                    blockValveStatus = new FacilityParameter("block valve status");
                    blockValveStatus.Description = "Indicates the status of a block valve. This should be implemented as a string value. A value of \"open\" indicates that it is open. A value of \"closed\" indicates that it is closed.";
                }
                return blockValveStatus;
            }
        }

        private static FacilityParameter facilityUptime;
        /// <summary>
        /// The ammount to time the facility was available during the specified period. This should be implemented as an time measure.
        /// </summary>
        [EnumValueNameAttribute("facility uptime")]
        public static FacilityParameter FacilityUptime
        {
            get 
            {
                if (facilityUptime == null)
                {
                    facilityUptime = new FacilityParameter("facility uptime");
                    facilityUptime.Description = "The ammount to time the facility was available during the specified period. This should be implemented as an time measure.";
                }
                return facilityUptime;
            }
        }

        private static FacilityParameter pumpCountOnline;
        /// <summary>
        /// The number of pumps which are active. This should be implemented as an integer value.
        /// </summary>
        [EnumValueNameAttribute("pump count online")]
        public static FacilityParameter PumpCountOnline
        {
            get 
            {
                if (pumpCountOnline == null)
                {
                    pumpCountOnline = new FacilityParameter("pump count online");
                    pumpCountOnline.Description = "The number of pumps which are active. This should be implemented as an integer value.";
                }
                return pumpCountOnline;
            }
        }

        private static FacilityParameter reciprocatingSpeed;
        /// <summary>
        /// The reciprocating speed of a device (e.g., motor, compressor). This should be implemented as an anglePerTime measure.
        /// </summary>
        [EnumValueNameAttribute("reciprocating speed")]
        public static FacilityParameter ReciprocatingSpeed
        {
            get 
            {
                if (reciprocatingSpeed == null)
                {
                    reciprocatingSpeed = new FacilityParameter("reciprocating speed");
                    reciprocatingSpeed.Description = "The reciprocating speed of a device (e.g., motor, compressor). This should be implemented as an anglePerTime measure.";
                }
                return reciprocatingSpeed;
            }
        }

        private static FacilityParameter relativeTankLevel;
        /// <summary>
        /// Defines the relative level of a tank. Zero indicates empty and 100% indicates full. This should be implemented as a lengthPerLength measure.
        /// </summary>
        [EnumValueNameAttribute("relative tank level")]
        public static FacilityParameter RelativeTankLevel
        {
            get 
            {
                if (relativeTankLevel == null)
                {
                    relativeTankLevel = new FacilityParameter("relative tank level");
                    relativeTankLevel.Description = "Defines the relative level of a tank. Zero indicates empty and 100% indicates full. This should be implemented as a lengthPerLength measure.";
                }
                return relativeTankLevel;
            }
        }

        private static FacilityParameter relativeValveOpening;
        /// <summary>
        /// Indicates the status of a valve. This should be implemented as an areaPerAreaMeasure. A value of 100 % indicates that it is open. A value of zero indicates that it is closed.
        /// </summary>
        [EnumValueNameAttribute("relative valve opening")]
        public static FacilityParameter RelativeValveOpening
        {
            get 
            {
                if (relativeValveOpening == null)
                {
                    relativeValveOpening = new FacilityParameter("relative valve opening");
                    relativeValveOpening.Description = "Indicates the status of a valve. This should be implemented as an areaPerAreaMeasure. A value of 100 % indicates that it is open. A value of zero indicates that it is closed.";
                }
                return relativeValveOpening;
            }
        }

        private static FacilityParameter valveOpening;
        /// <summary>
        /// Indicates the open area of a valve. This should be implemented as an areaMeasure. A value of zero indicates that it is closed.
        /// </summary>
        [EnumValueNameAttribute("valve opening")]
        public static FacilityParameter ValveOpening
        {
            get 
            {
                if (valveOpening == null)
                {
                    valveOpening = new FacilityParameter("valve opening");
                    valveOpening.Description = "Indicates the open area of a valve. This should be implemented as an areaMeasure. A value of zero indicates that it is closed.";
                }
                return valveOpening;
            }
        }

        private static FacilityParameter scheduledDowntime;
        /// <summary>
        /// Indicates the amount of time the facility has been unavailable during the specified period. May be related to a particular point in time which would represent the start of the downtime. This should be implemented as an time measure.
        /// </summary>
        [EnumValueNameAttribute("scheduled downtime")]
        public static FacilityParameter ScheduledDowntime
        {
            get 
            {
                if (scheduledDowntime == null)
                {
                    scheduledDowntime = new FacilityParameter("scheduled downtime");
                    scheduledDowntime.Description = "Indicates the amount of time the facility has been unavailable during the specified period. May be related to a particular point in time which would represent the start of the downtime. This should be implemented as an time measure.";
                }
                return scheduledDowntime;
            }
        }

        private static FacilityParameter shutdownOrder;
        /// <summary>
        /// Defines the relative order in which a facility should be shutdown. This should be implemented as an integer count. Facilities with smaller values should be shut down first. Only facility parameters with the same version time and same version source should be evaluated together for the purposes of this order.
        /// </summary>
        [EnumValueNameAttribute("shutdown order")]
        public static FacilityParameter ShutdownOrder
        {
            get 
            {
                if (shutdownOrder == null)
                {
                    shutdownOrder = new FacilityParameter("shutdown order");
                    shutdownOrder.Description = "Defines the relative order in which a facility should be shutdown. This should be implemented as an integer count. Facilities with smaller values should be shut down first. Only facility parameters with the same version time and same version source should be evaluated together for the purposes of this order.";
                }
                return shutdownOrder;
            }
        }

        private static FacilityParameter tankFluidLevel;
        /// <summary>
        /// The vertical height of the specified product in a tank. This should be implemented as a length measure.
        /// </summary>
        [EnumValueNameAttribute("tank fluid level")]
        public static FacilityParameter TankFluidLevel
        {
            get 
            {
                if (tankFluidLevel == null)
                {
                    tankFluidLevel = new FacilityParameter("tank fluid level");
                    tankFluidLevel.Description = "The vertical height of the specified product in a tank. This should be implemented as a length measure.";
                }
                return tankFluidLevel;
            }
        }

        private static FacilityParameter tankProductVolume;
        /// <summary>
        /// The volume of the specified product in a tank. This should be implemented as a volume measure.
        /// </summary>
        [EnumValueNameAttribute("tank product volume")]
        public static FacilityParameter TankProductVolume
        {
            get 
            {
                if (tankProductVolume == null)
                {
                    tankProductVolume = new FacilityParameter("tank product volume");
                    tankProductVolume.Description = "The volume of the specified product in a tank. This should be implemented as a volume measure.";
                }
                return tankProductVolume;
            }
        }

        private static FacilityParameter tankProductStandardVolume;
        /// <summary>
        /// The volume of the specified product in a tank, corrected to standard conditions of temperature and pressure. This should be implemented as a volume measure.
        /// </summary>
        [EnumValueNameAttribute("tank product standard volume")]
        public static FacilityParameter TankProductStandardVolume
        {
            get 
            {
                if (tankProductStandardVolume == null)
                {
                    tankProductStandardVolume = new FacilityParameter("tank product standard volume");
                    tankProductStandardVolume.Description = "The volume of the specified product in a tank, corrected to standard conditions of temperature and pressure. This should be implemented as a volume measure.";
                }
                return tankProductStandardVolume;
            }
        }

        private static FacilityParameter wellOperationType;
        /// <summary>
        /// This commonly called the "well type". It characterizes the well based on its mode of lifting the product. This should be implemented as a string value.
        /// </summary>
        [EnumValueNameAttribute("well operation type")]
        public static FacilityParameter WellOperationType
        {
            get 
            {
                if (wellOperationType == null)
                {
                    wellOperationType = new FacilityParameter("well operation type");
                    wellOperationType.Description = "This commonly called the \"well type\". It characterizes the well based on its mode of lifting the product. This should be implemented as a string value.";
                }
                return wellOperationType;
            }
        }

        private static FacilityParameter unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FacilityParameter Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FacilityParameter("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The mode of a Distributed Temperature Survey (DTS) fiber.
    /// </summary>
    public class FiberMode : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FiberMode(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FiberMode</param>
        public FiberMode(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FiberModes
        /// </summary>
        /// <returns>The complete list of FiberModes</returns>
        public static List<FiberMode> GetList()
        {
            return GetList<FiberMode>();
        }

        private static FiberMode singlemode;
        /// <summary>
        /// A single, narrow, core of constant refractive index, surrounded by glass cladding. The core diameter is comparable to a wave length of the light (about 5 um).
        /// </summary>
        [EnumValueNameAttribute("singlemode")]
        public static FiberMode Singlemode
        {
            get 
            {
                if (singlemode == null)
                {
                    singlemode = new FiberMode("singlemode");
                    singlemode.Description = "A single, narrow, core of constant refractive index, surrounded by glass cladding. The core diameter is comparable to a wave length of the light (about 5 um).";
                }
                return singlemode;
            }
        }

        private static FiberMode multimode;
        /// <summary>
        /// The core has a graded refractive index. The core is generally about 50um in diameter.
        /// </summary>
        [EnumValueNameAttribute("multimode")]
        public static FiberMode Multimode
        {
            get 
            {
                if (multimode == null)
                {
                    multimode = new FiberMode("multimode");
                    multimode.Description = "The core has a graded refractive index. The core is generally about 50um in diameter.";
                }
                return multimode;
            }
        }

        private static FiberMode other;
        /// <summary>
        /// The fiber mode is neither singlemode or multimode.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static FiberMode Other
        {
            get 
            {
                if (other == null)
                {
                    other = new FiberMode("other");
                    other.Description = "The fiber mode is neither singlemode or multimode.";
                }
                return other;
            }
        }

        private static FiberMode unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FiberMode Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FiberMode("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines qualifiers for type of flow.
    /// </summary>
    public class FlowQualifier : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FlowQualifier(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FlowQualifier</param>
        public FlowQualifier(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FlowQualifiers
        /// </summary>
        /// <returns>The complete list of FlowQualifiers</returns>
        public static List<FlowQualifier> GetList()
        {
            return GetList<FlowQualifier>();
        }

        private static FlowQualifier allocated;
        /// <summary>
        /// Indicates product characteristics that were allocated back to a well as opposed to being measured at the well.
        /// </summary>
        [EnumValueNameAttribute("allocated")]
        public static FlowQualifier Allocated
        {
            get 
            {
                if (allocated == null)
                {
                    allocated = new FlowQualifier("allocated");
                    allocated.Description = "Indicates product characteristics that were allocated back to a well as opposed to being measured at the well.";
                }
                return allocated;
            }
        }

        private static FlowQualifier budget;
        /// <summary>
        /// A performance requirement as determined by a budget.
        /// </summary>
        [EnumValueNameAttribute("budget")]
        public static FlowQualifier Budget
        {
            get 
            {
                if (budget == null)
                {
                    budget = new FlowQualifier("budget");
                    budget.Description = "A performance requirement as determined by a budget.";
                }
                return budget;
            }
        }

        private static FlowQualifier constraint;
        /// <summary>
        /// Indicates product characteristics that were determined by an allowable or other performance limit. This includes allowables which are usually established by a regulatory agency for a product.
        /// </summary>
        [EnumValueNameAttribute("constraint")]
        public static FlowQualifier Constraint
        {
            get 
            {
                if (constraint == null)
                {
                    constraint = new FlowQualifier("constraint");
                    constraint.Description = "Indicates product characteristics that were determined by an allowable or other performance limit. This includes allowables which are usually established by a regulatory agency for a product.";
                }
                return constraint;
            }
        }

        private static FlowQualifier difference;
        /// <summary>
        /// A value that is the difference between e.g. a target value and a metered value.
        /// </summary>
        [EnumValueNameAttribute("difference")]
        public static FlowQualifier Difference
        {
            get 
            {
                if (difference == null)
                {
                    difference = new FlowQualifier("difference");
                    difference.Description = "A value that is the difference between e.g. a target value and a metered value.";
                }
                return difference;
            }
        }

        private static FlowQualifier forecast;
        /// <summary>
        /// A forecast future value.
        /// </summary>
        [EnumValueNameAttribute("forecast")]
        public static FlowQualifier Forecast
        {
            get 
            {
                if (forecast == null)
                {
                    forecast = new FlowQualifier("forecast");
                    forecast.Description = "A forecast future value.";
                }
                return forecast;
            }
        }

        private static FlowQualifier derived;
        /// <summary>
        /// Indicates product volumes that were derived directly from one or more other flows.
        /// </summary>
        [EnumValueNameAttribute("derived")]
        public static FlowQualifier Derived
        {
            get 
            {
                if (derived == null)
                {
                    derived = new FlowQualifier("derived");
                    derived.Description = "Indicates product volumes that were derived directly from one or more other flows.";
                }
                return derived;
            }
        }

        private static FlowQualifier estimate;
        /// <summary>
        /// An estimated or calculated performance, possibly based on comparable product flow units, but not based on reservoir simulations for the particular product flow unit.
        /// </summary>
        [EnumValueNameAttribute("estimate")]
        public static FlowQualifier Estimate
        {
            get 
            {
                if (estimate == null)
                {
                    estimate = new FlowQualifier("estimate");
                    estimate.Description = "An estimated or calculated performance, possibly based on comparable product flow units, but not based on reservoir simulations for the particular product flow unit.";
                }
                return estimate;
            }
        }

        private static FlowQualifier massAdjusted;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("mass adjusted")]
        public static FlowQualifier MassAdjusted
        {
            get 
            {
                if (massAdjusted == null)
                {
                    massAdjusted = new FlowQualifier("mass adjusted");
                    massAdjusted.Description = "xxxxxxxxxxxxxxxxxxxxxxxxxxx";
                }
                return massAdjusted;
            }
        }

        private static FlowQualifier measured;
        /// <summary>
        /// Indicates product volumes that were actually measured at the port.
        /// </summary>
        [EnumValueNameAttribute("measured")]
        public static FlowQualifier Measured
        {
            get 
            {
                if (measured == null)
                {
                    measured = new FlowQualifier("measured");
                    measured.Description = "Indicates product volumes that were actually measured at the port.";
                }
                return measured;
            }
        }

        private static FlowQualifier metered;
        /// <summary>
        /// A value that is read off an officially calibrated instrument (e.g. a gas chromatograph).
        /// </summary>
        [EnumValueNameAttribute("metered")]
        public static FlowQualifier Metered
        {
            get 
            {
                if (metered == null)
                {
                    metered = new FlowQualifier("metered");
                    metered.Description = "A value that is read off an officially calibrated instrument (e.g. a gas chromatograph).";
                }
                return metered;
            }
        }

        private static FlowQualifier meteredFiscal;
        /// <summary>
        /// A value that is generated by measurement and calculation and has an impact on company revenue and government taxation.
        /// </summary>
        [EnumValueNameAttribute("metered - fiscal")]
        public static FlowQualifier MeteredFiscal
        {
            get 
            {
                if (meteredFiscal == null)
                {
                    meteredFiscal = new FlowQualifier("metered - fiscal");
                    meteredFiscal.Description = "A value that is generated by measurement and calculation and has an impact on company revenue and government taxation.";
                }
                return meteredFiscal;
            }
        }

        private static FlowQualifier nominated;
        /// <summary>
        /// Normally a 1 day forcast promise to a buyer.
        /// </summary>
        [EnumValueNameAttribute("nominated")]
        public static FlowQualifier Nominated
        {
            get 
            {
                if (nominated == null)
                {
                    nominated = new FlowQualifier("nominated");
                    nominated.Description = "Normally a 1 day forcast promise to a buyer.";
                }
                return nominated;
            }
        }

        private static FlowQualifier potential;
        /// <summary>
        /// The estimated maximum which is possible.
        /// </summary>
        [EnumValueNameAttribute("potential")]
        public static FlowQualifier Potential
        {
            get 
            {
                if (potential == null)
                {
                    potential = new FlowQualifier("potential");
                    potential.Description = "The estimated maximum which is possible.";
                }
                return potential;
            }
        }

        private static FlowQualifier processed;
        /// <summary>
        /// A measured value that has been processed. This is different from derived because it is fundamentally a variation of the original value.
        /// </summary>
        [EnumValueNameAttribute("processed")]
        public static FlowQualifier Processed
        {
            get 
            {
                if (processed == null)
                {
                    processed = new FlowQualifier("processed");
                    processed.Description = "A measured value that has been processed. This is different from derived because it is fundamentally a variation of the original value.";
                }
                return processed;
            }
        }

        private static FlowQualifier quota;
        /// <summary>
        /// An amount, set by some authority, which may or may not be based on technical criteria.
        /// </summary>
        [EnumValueNameAttribute("quota")]
        public static FlowQualifier Quota
        {
            get 
            {
                if (quota == null)
                {
                    quota = new FlowQualifier("quota");
                    quota.Description = "An amount, set by some authority, which may or may not be based on technical criteria.";
                }
                return quota;
            }
        }

        private static FlowQualifier recommended;
        /// <summary>
        /// A value which is believed to be very desirable if it can be achieved. This a recommendation that something be changed in order to achieve this value.
        /// </summary>
        [EnumValueNameAttribute("recommended")]
        public static FlowQualifier Recommended
        {
            get 
            {
                if (recommended == null)
                {
                    recommended = new FlowQualifier("recommended");
                    recommended.Description = "A value which is believed to be very desirable if it can be achieved. This a recommendation that something be changed in order to achieve this value.";
                }
                return recommended;
            }
        }

        private static FlowQualifier simulated;
        /// <summary>
        /// An estimated performance based on a simulation that includes the particular product flow unit.
        /// </summary>
        [EnumValueNameAttribute("simulated")]
        public static FlowQualifier Simulated
        {
            get 
            {
                if (simulated == null)
                {
                    simulated = new FlowQualifier("simulated");
                    simulated.Description = "An estimated performance based on a simulation that includes the particular product flow unit.";
                }
                return simulated;
            }
        }

        private static FlowQualifier target;
        /// <summary>
        /// The desired value. What you are aiming for.
        /// </summary>
        [EnumValueNameAttribute("target")]
        public static FlowQualifier Target
        {
            get 
            {
                if (target == null)
                {
                    target = new FlowQualifier("target");
                    target.Description = "The desired value. What you are aiming for.";
                }
                return target;
            }
        }

        private static FlowQualifier tariffBasis;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("tariff basis")]
        public static FlowQualifier TariffBasis
        {
            get 
            {
                if (tariffBasis == null)
                {
                    tariffBasis = new FlowQualifier("tariff basis");
                    tariffBasis.Description = "xxxxxxxxxxxxxxxxxxxxxxxxxxx";
                }
                return tariffBasis;
            }
        }

        private static FlowQualifier valueAdjusted;
        /// <summary>
        /// A value that is adjusted due to a change in the value of a product.
        /// </summary>
        [EnumValueNameAttribute("value adjusted")]
        public static FlowQualifier ValueAdjusted
        {
            get 
            {
                if (valueAdjusted == null)
                {
                    valueAdjusted = new FlowQualifier("value adjusted");
                    valueAdjusted.Description = "A value that is adjusted due to a change in the value of a product.";
                }
                return valueAdjusted;
            }
        }

        private static FlowQualifier unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FlowQualifier Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FlowQualifier("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines a specialization of a flow qualifier.
    /// </summary>
    public class FlowSubQualifier : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FlowSubQualifier(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FlowSubQualifier</param>
        public FlowSubQualifier(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FlowSubQualifiers
        /// </summary>
        /// <returns>The complete list of FlowSubQualifiers</returns>
        public static List<FlowSubQualifier> GetList()
        {
            return GetList<FlowSubQualifier>();
        }

        private static FlowSubQualifier declineCurve;
        /// <summary>
        /// Indicates a pseudo decline-curve of flow rate over time. This presumes that the flow will not be interrupted over that time period. Specialization of "forecast".
        /// </summary>
        [EnumValueNameAttribute("decline curve")]
        public static FlowSubQualifier DeclineCurve
        {
            get 
            {
                if (declineCurve == null)
                {
                    declineCurve = new FlowSubQualifier("decline curve");
                    declineCurve.Description = "Indicates a pseudo decline-curve of flow rate over time. This presumes that the flow will not be interrupted over that time period. Specialization of \"forecast\".";
                }
                return declineCurve;
            }
        }

        private static FlowSubQualifier difference;
        /// <summary>
        /// A value is derived by taking the difference between two other values. Specialization of "derived".
        /// </summary>
        [EnumValueNameAttribute("difference")]
        public static FlowSubQualifier Difference
        {
            get 
            {
                if (difference == null)
                {
                    difference = new FlowSubQualifier("difference");
                    difference.Description = "A value is derived by taking the difference between two other values. Specialization of \"derived\".";
                }
                return difference;
            }
        }

        private static FlowSubQualifier fiscal;
        /// <summary>
        /// The value was measured for fiscal purposes. Specialization of "measured".
        /// </summary>
        [EnumValueNameAttribute("fiscal")]
        public static FlowSubQualifier Fiscal
        {
            get 
            {
                if (fiscal == null)
                {
                    fiscal = new FlowSubQualifier("fiscal");
                    fiscal.Description = "The value was measured for fiscal purposes. Specialization of \"measured\".";
                }
                return fiscal;
            }
        }

        private static FlowSubQualifier @fixed;
        /// <summary>
        /// The value supplied is the only value permitted. Specialization of "constraint".
        /// </summary>
        [EnumValueNameAttribute("fixed")]
        public static FlowSubQualifier Fixed
        {
            get 
            {
                if (@fixed == null)
                {
                    @fixed = new FlowSubQualifier("fixed");
                    @fixed.Description = "The value supplied is the only value permitted. Specialization of \"constraint\".";
                }
                return @fixed;
            }
        }

        private static FlowSubQualifier minimum;
        /// <summary>
        /// The value supplied is the minimum permitted. Specialization of "constraint".
        /// </summary>
        [EnumValueNameAttribute("minimum")]
        public static FlowSubQualifier Minimum
        {
            get 
            {
                if (minimum == null)
                {
                    minimum = new FlowSubQualifier("minimum");
                    minimum.Description = "The value supplied is the minimum permitted. Specialization of \"constraint\".";
                }
                return minimum;
            }
        }

        private static FlowSubQualifier maximum;
        /// <summary>
        /// The value supplied is the maximum permitted. Specialization of "constraint".
        /// </summary>
        [EnumValueNameAttribute("maximum")]
        public static FlowSubQualifier Maximum
        {
            get 
            {
                if (maximum == null)
                {
                    maximum = new FlowSubQualifier("maximum");
                    maximum.Description = "The value supplied is the maximum permitted. Specialization of \"constraint\".";
                }
                return maximum;
            }
        }

        private static FlowSubQualifier raw;
        /// <summary>
        /// The value is a raw measurement. Specialization of "measured".
        /// </summary>
        [EnumValueNameAttribute("raw")]
        public static FlowSubQualifier Raw
        {
            get 
            {
                if (raw == null)
                {
                    raw = new FlowSubQualifier("raw");
                    raw.Description = "The value is a raw measurement. Specialization of \"measured\".";
                }
                return raw;
            }
        }

        private static FlowSubQualifier recalibrated;
        /// <summary>
        /// The value has changed due to a recalibration of the sensor. Specialization of "measured".
        /// </summary>
        [EnumValueNameAttribute("recalibrated")]
        public static FlowSubQualifier Recalibrated
        {
            get 
            {
                if (recalibrated == null)
                {
                    recalibrated = new FlowSubQualifier("recalibrated");
                    recalibrated.Description = "The value has changed due to a recalibration of the sensor. Specialization of \"measured\".";
                }
                return recalibrated;
            }
        }

        private static FlowSubQualifier standard;
        /// <summary>
        /// A standard forecast as opposed to a decline curve. Specialization of "forecast".
        /// </summary>
        [EnumValueNameAttribute("standard")]
        public static FlowSubQualifier Standard
        {
            get 
            {
                if (standard == null)
                {
                    standard = new FlowSubQualifier("standard");
                    standard.Description = "A standard forecast as opposed to a decline curve. Specialization of \"forecast\".";
                }
                return standard;
            }
        }

        private static FlowSubQualifier unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FlowSubQualifier Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FlowSubQualifier("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class FluidAnalysisKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FluidAnalysisKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FluidAnalysisKind</param>
        public FluidAnalysisKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FluidAnalysisKinds
        /// </summary>
        /// <returns>The complete list of FluidAnalysisKinds</returns>
        public static List<FluidAnalysisKind> GetList()
        {
            return GetList<FluidAnalysisKind>();
        }

        private static FluidAnalysisKind qualityControl;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("quality control")]
        public static FluidAnalysisKind QualityControl
        {
            get 
            {
                if (qualityControl == null)
                {
                    qualityControl = new FluidAnalysisKind("quality control");
                    qualityControl.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return qualityControl;
            }
        }

        private static FluidAnalysisKind calc;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("calc")]
        public static FluidAnalysisKind Calc
        {
            get 
            {
                if (calc == null)
                {
                    calc = new FluidAnalysisKind("calc");
                    calc.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return calc;
            }
        }

        private static FluidAnalysisKind bus;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("bus")]
        public static FluidAnalysisKind Bus
        {
            get 
            {
                if (bus == null)
                {
                    bus = new FluidAnalysisKind("bus");
                    bus.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return bus;
            }
        }

        private static FluidAnalysisKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidAnalysisKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FluidAnalysisKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class FluidComponent : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FluidComponent(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FluidComponent</param>
        public FluidComponent(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FluidComponents
        /// </summary>
        /// <returns>The complete list of FluidComponents</returns>
        public static List<FluidComponent> GetList()
        {
            return GetList<FluidComponent>();
        }

        private static FluidComponent hydrogen;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("hydrogen")]
        public static FluidComponent Hydrogen
        {
            get 
            {
                if (hydrogen == null)
                {
                    hydrogen = new FluidComponent("hydrogen");
                    hydrogen.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return hydrogen;
            }
        }

        private static FluidComponent water;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("water")]
        public static FluidComponent Water
        {
            get 
            {
                if (water == null)
                {
                    water = new FluidComponent("water");
                    water.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return water;
            }
        }

        private static FluidComponent nitrogen;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("nitrogen")]
        public static FluidComponent Nitrogen
        {
            get 
            {
                if (nitrogen == null)
                {
                    nitrogen = new FluidComponent("nitrogen");
                    nitrogen.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return nitrogen;
            }
        }

        private static FluidComponent oxygen;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("oxygen")]
        public static FluidComponent Oxygen
        {
            get 
            {
                if (oxygen == null)
                {
                    oxygen = new FluidComponent("oxygen");
                    oxygen.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return oxygen;
            }
        }

        private static FluidComponent hydrogenSulfide;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide")]
        public static FluidComponent HydrogenSulfide
        {
            get 
            {
                if (hydrogenSulfide == null)
                {
                    hydrogenSulfide = new FluidComponent("hydrogen sulfide");
                    hydrogenSulfide.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return hydrogenSulfide;
            }
        }

        private static FluidComponent argon;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("argon")]
        public static FluidComponent Argon
        {
            get 
            {
                if (argon == null)
                {
                    argon = new FluidComponent("argon");
                    argon.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return argon;
            }
        }

        private static FluidComponent carbonDioxide;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide")]
        public static FluidComponent CarbonDioxide
        {
            get 
            {
                if (carbonDioxide == null)
                {
                    carbonDioxide = new FluidComponent("carbon dioxide");
                    carbonDioxide.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return carbonDioxide;
            }
        }

        private static FluidComponent methane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("methane")]
        public static FluidComponent Methane
        {
            get 
            {
                if (methane == null)
                {
                    methane = new FluidComponent("methane");
                    methane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return methane;
            }
        }

        private static FluidComponent ethane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("ethane")]
        public static FluidComponent Ethane
        {
            get 
            {
                if (ethane == null)
                {
                    ethane = new FluidComponent("ethane");
                    ethane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return ethane;
            }
        }

        private static FluidComponent propane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("propane")]
        public static FluidComponent Propane
        {
            get 
            {
                if (propane == null)
                {
                    propane = new FluidComponent("propane");
                    propane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return propane;
            }
        }

        private static FluidComponent twomethylpropane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2-methylpropane")]
        public static FluidComponent Twomethylpropane
        {
            get 
            {
                if (twomethylpropane == null)
                {
                    twomethylpropane = new FluidComponent("2-methylpropane");
                    twomethylpropane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twomethylpropane;
            }
        }

        private static FluidComponent butane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("butane")]
        public static FluidComponent Butane
        {
            get 
            {
                if (butane == null)
                {
                    butane = new FluidComponent("butane");
                    butane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return butane;
            }
        }

        private static FluidComponent cyclopentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("cyclopentane")]
        public static FluidComponent Cyclopentane
        {
            get 
            {
                if (cyclopentane == null)
                {
                    cyclopentane = new FluidComponent("cyclopentane");
                    cyclopentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cyclopentane;
            }
        }

        private static FluidComponent twomethylbutane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2-methylbutane")]
        public static FluidComponent Twomethylbutane
        {
            get 
            {
                if (twomethylbutane == null)
                {
                    twomethylbutane = new FluidComponent("2-methylbutane");
                    twomethylbutane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twomethylbutane;
            }
        }

        private static FluidComponent pentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("pentane")]
        public static FluidComponent Pentane
        {
            get 
            {
                if (pentane == null)
                {
                    pentane = new FluidComponent("pentane");
                    pentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return pentane;
            }
        }

        private static FluidComponent twoTwoDimethylpropane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,2 dimethylpropane")]
        public static FluidComponent TwoTwoDimethylpropane
        {
            get 
            {
                if (twoTwoDimethylpropane == null)
                {
                    twoTwoDimethylpropane = new FluidComponent("2,2 dimethylpropane");
                    twoTwoDimethylpropane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoTwoDimethylpropane;
            }
        }

        private static FluidComponent benzene;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("benzene")]
        public static FluidComponent Benzene
        {
            get 
            {
                if (benzene == null)
                {
                    benzene = new FluidComponent("benzene");
                    benzene.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return benzene;
            }
        }

        private static FluidComponent cyclohexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("cyclohexane")]
        public static FluidComponent Cyclohexane
        {
            get 
            {
                if (cyclohexane == null)
                {
                    cyclohexane = new FluidComponent("cyclohexane");
                    cyclohexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cyclohexane;
            }
        }

        private static FluidComponent methylcyclopentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("methylcyclopentane ")]
        public static FluidComponent Methylcyclopentane
        {
            get 
            {
                if (methylcyclopentane == null)
                {
                    methylcyclopentane = new FluidComponent("methylcyclopentane ");
                    methylcyclopentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return methylcyclopentane;
            }
        }

        private static FluidComponent hexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("hexane")]
        public static FluidComponent Hexane
        {
            get 
            {
                if (hexane == null)
                {
                    hexane = new FluidComponent("hexane");
                    hexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return hexane;
            }
        }

        private static FluidComponent twoTwodimethylbutane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,2-dimethylbutane")]
        public static FluidComponent TwoTwodimethylbutane
        {
            get 
            {
                if (twoTwodimethylbutane == null)
                {
                    twoTwodimethylbutane = new FluidComponent("2,2-dimethylbutane");
                    twoTwodimethylbutane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoTwodimethylbutane;
            }
        }

        private static FluidComponent twoThreedimethylbutane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,3-dimethylbutane")]
        public static FluidComponent TwoThreedimethylbutane
        {
            get 
            {
                if (twoThreedimethylbutane == null)
                {
                    twoThreedimethylbutane = new FluidComponent("2,3-dimethylbutane");
                    twoThreedimethylbutane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoThreedimethylbutane;
            }
        }

        private static FluidComponent twomethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2-methylpentane")]
        public static FluidComponent Twomethylpentane
        {
            get 
            {
                if (twomethylpentane == null)
                {
                    twomethylpentane = new FluidComponent("2-methylpentane");
                    twomethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twomethylpentane;
            }
        }

        private static FluidComponent threemethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("3-methylpentane")]
        public static FluidComponent Threemethylpentane
        {
            get 
            {
                if (threemethylpentane == null)
                {
                    threemethylpentane = new FluidComponent("3-methylpentane");
                    threemethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return threemethylpentane;
            }
        }

        private static FluidComponent methylbenzene;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("methylbenzene")]
        public static FluidComponent Methylbenzene
        {
            get 
            {
                if (methylbenzene == null)
                {
                    methylbenzene = new FluidComponent("methylbenzene");
                    methylbenzene.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return methylbenzene;
            }
        }

        private static FluidComponent methylcyclohexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("methylcyclohexane")]
        public static FluidComponent Methylcyclohexane
        {
            get 
            {
                if (methylcyclohexane == null)
                {
                    methylcyclohexane = new FluidComponent("methylcyclohexane");
                    methylcyclohexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return methylcyclohexane;
            }
        }

        private static FluidComponent oneOnedimethylcyclopentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("1,1-dimethylcyclopentane")]
        public static FluidComponent OneOnedimethylcyclopentane
        {
            get 
            {
                if (oneOnedimethylcyclopentane == null)
                {
                    oneOnedimethylcyclopentane = new FluidComponent("1,1-dimethylcyclopentane");
                    oneOnedimethylcyclopentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return oneOnedimethylcyclopentane;
            }
        }

        private static FluidComponent cisOneThreedimethylcyclopentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("cis-1,3-dimethylcyclopentane")]
        public static FluidComponent CisOneThreedimethylcyclopentane
        {
            get 
            {
                if (cisOneThreedimethylcyclopentane == null)
                {
                    cisOneThreedimethylcyclopentane = new FluidComponent("cis-1,3-dimethylcyclopentane");
                    cisOneThreedimethylcyclopentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cisOneThreedimethylcyclopentane;
            }
        }

        private static FluidComponent transOneTwodimethylcyclopentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("trans-1,2-dimethylcyclopentane")]
        public static FluidComponent TransOneTwodimethylcyclopentane
        {
            get 
            {
                if (transOneTwodimethylcyclopentane == null)
                {
                    transOneTwodimethylcyclopentane = new FluidComponent("trans-1,2-dimethylcyclopentane");
                    transOneTwodimethylcyclopentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return transOneTwodimethylcyclopentane;
            }
        }

        private static FluidComponent transOneThreedimethylcyclopentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("trans-1,3-dimethylcyclopentane")]
        public static FluidComponent TransOneThreedimethylcyclopentane
        {
            get 
            {
                if (transOneThreedimethylcyclopentane == null)
                {
                    transOneThreedimethylcyclopentane = new FluidComponent("trans-1,3-dimethylcyclopentane");
                    transOneThreedimethylcyclopentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return transOneThreedimethylcyclopentane;
            }
        }

        private static FluidComponent ethylcyclopentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("ethylcyclopentane")]
        public static FluidComponent Ethylcyclopentane
        {
            get 
            {
                if (ethylcyclopentane == null)
                {
                    ethylcyclopentane = new FluidComponent("ethylcyclopentane");
                    ethylcyclopentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return ethylcyclopentane;
            }
        }

        private static FluidComponent twoTwodimethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,2-dimethylpentane")]
        public static FluidComponent TwoTwodimethylpentane
        {
            get 
            {
                if (twoTwodimethylpentane == null)
                {
                    twoTwodimethylpentane = new FluidComponent("2,2-dimethylpentane");
                    twoTwodimethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoTwodimethylpentane;
            }
        }

        private static FluidComponent twoTwoThreetrimethylbutane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,2,3-trimethylbutane")]
        public static FluidComponent TwoTwoThreetrimethylbutane
        {
            get 
            {
                if (twoTwoThreetrimethylbutane == null)
                {
                    twoTwoThreetrimethylbutane = new FluidComponent("2,2,3-trimethylbutane");
                    twoTwoThreetrimethylbutane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoTwoThreetrimethylbutane;
            }
        }

        private static FluidComponent twoFourdimethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,4-Dimethylpentane")]
        public static FluidComponent TwoFourdimethylpentane
        {
            get 
            {
                if (twoFourdimethylpentane == null)
                {
                    twoFourdimethylpentane = new FluidComponent("2,4-Dimethylpentane");
                    twoFourdimethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoFourdimethylpentane;
            }
        }

        private static FluidComponent twomethylhexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2-methylhexane")]
        public static FluidComponent Twomethylhexane
        {
            get 
            {
                if (twomethylhexane == null)
                {
                    twomethylhexane = new FluidComponent("2-methylhexane");
                    twomethylhexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twomethylhexane;
            }
        }

        private static FluidComponent threeThreedimethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("3,3-dimethylpentane")]
        public static FluidComponent ThreeThreedimethylpentane
        {
            get 
            {
                if (threeThreedimethylpentane == null)
                {
                    threeThreedimethylpentane = new FluidComponent("3,3-dimethylpentane");
                    threeThreedimethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return threeThreedimethylpentane;
            }
        }

        private static FluidComponent twoThreedimethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,3-dimethylpentane")]
        public static FluidComponent TwoThreedimethylpentane
        {
            get 
            {
                if (twoThreedimethylpentane == null)
                {
                    twoThreedimethylpentane = new FluidComponent("2,3-dimethylpentane");
                    twoThreedimethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoThreedimethylpentane;
            }
        }

        private static FluidComponent threeethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("3-ethylpentane")]
        public static FluidComponent Threeethylpentane
        {
            get 
            {
                if (threeethylpentane == null)
                {
                    threeethylpentane = new FluidComponent("3-ethylpentane");
                    threeethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return threeethylpentane;
            }
        }

        private static FluidComponent threemethylhexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("3-methylhexane")]
        public static FluidComponent Threemethylhexane
        {
            get 
            {
                if (threemethylhexane == null)
                {
                    threemethylhexane = new FluidComponent("3-methylhexane");
                    threemethylhexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return threemethylhexane;
            }
        }

        private static FluidComponent oneTwoDimethylbenzene;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("1,2 dimethylbenzene")]
        public static FluidComponent OneTwoDimethylbenzene
        {
            get 
            {
                if (oneTwoDimethylbenzene == null)
                {
                    oneTwoDimethylbenzene = new FluidComponent("1,2 dimethylbenzene");
                    oneTwoDimethylbenzene.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return oneTwoDimethylbenzene;
            }
        }

        private static FluidComponent oneThreeDimethylbenzene;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("1,3 dimethylbenzene")]
        public static FluidComponent OneThreeDimethylbenzene
        {
            get 
            {
                if (oneThreeDimethylbenzene == null)
                {
                    oneThreeDimethylbenzene = new FluidComponent("1,3 dimethylbenzene");
                    oneThreeDimethylbenzene.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return oneThreeDimethylbenzene;
            }
        }

        private static FluidComponent oneFourdimethylbenzene;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("1,4-dimethylbenzene")]
        public static FluidComponent OneFourdimethylbenzene
        {
            get 
            {
                if (oneFourdimethylbenzene == null)
                {
                    oneFourdimethylbenzene = new FluidComponent("1,4-dimethylbenzene");
                    oneFourdimethylbenzene.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return oneFourdimethylbenzene;
            }
        }

        private static FluidComponent ethylbenzene;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("ethylbenzene")]
        public static FluidComponent Ethylbenzene
        {
            get 
            {
                if (ethylbenzene == null)
                {
                    ethylbenzene = new FluidComponent("ethylbenzene");
                    ethylbenzene.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return ethylbenzene;
            }
        }

        private static FluidComponent twoThreeThreetrimethylpentane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,3,3-trimethylpentane")]
        public static FluidComponent TwoThreeThreetrimethylpentane
        {
            get 
            {
                if (twoThreeThreetrimethylpentane == null)
                {
                    twoThreeThreetrimethylpentane = new FluidComponent("2,3,3-trimethylpentane");
                    twoThreeThreetrimethylpentane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoThreeThreetrimethylpentane;
            }
        }

        private static FluidComponent twoTwodimethylhexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,2-dimethylhexane")]
        public static FluidComponent TwoTwodimethylhexane
        {
            get 
            {
                if (twoTwodimethylhexane == null)
                {
                    twoTwodimethylhexane = new FluidComponent("2,2-dimethylhexane");
                    twoTwodimethylhexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoTwodimethylhexane;
            }
        }

        private static FluidComponent twoFourdimethylhexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,4-dimethylhexane")]
        public static FluidComponent TwoFourdimethylhexane
        {
            get 
            {
                if (twoFourdimethylhexane == null)
                {
                    twoFourdimethylhexane = new FluidComponent("2,4-dimethylhexane");
                    twoFourdimethylhexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoFourdimethylhexane;
            }
        }

        private static FluidComponent twoFivedimethylhexane;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("2,5-dimethylhexane")]
        public static FluidComponent TwoFivedimethylhexane
        {
            get 
            {
                if (twoFivedimethylhexane == null)
                {
                    twoFivedimethylhexane = new FluidComponent("2,5-dimethylhexane");
                    twoFivedimethylhexane.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return twoFivedimethylhexane;
            }
        }

        private static FluidComponent oneTwoFourtrimethylbenzene;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("1,2,4-trimethylbenzene")]
        public static FluidComponent OneTwoFourtrimethylbenzene
        {
            get 
            {
                if (oneTwoFourtrimethylbenzene == null)
                {
                    oneTwoFourtrimethylbenzene = new FluidComponent("1,2,4-trimethylbenzene");
                    oneTwoFourtrimethylbenzene.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return oneTwoFourtrimethylbenzene;
            }
        }

        private static FluidComponent hexanes;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("hexanes")]
        public static FluidComponent Hexanes
        {
            get 
            {
                if (hexanes == null)
                {
                    hexanes = new FluidComponent("hexanes");
                    hexanes.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return hexanes;
            }
        }

        private static FluidComponent heptanes;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("heptanes")]
        public static FluidComponent Heptanes
        {
            get 
            {
                if (heptanes == null)
                {
                    heptanes = new FluidComponent("heptanes");
                    heptanes.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return heptanes;
            }
        }

        private static FluidComponent octanes;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("octanes")]
        public static FluidComponent Octanes
        {
            get 
            {
                if (octanes == null)
                {
                    octanes = new FluidComponent("octanes");
                    octanes.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return octanes;
            }
        }

        private static FluidComponent nonanes;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("nonanes")]
        public static FluidComponent Nonanes
        {
            get 
            {
                if (nonanes == null)
                {
                    nonanes = new FluidComponent("nonanes");
                    nonanes.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return nonanes;
            }
        }

        private static FluidComponent decanes;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("decanes")]
        public static FluidComponent Decanes
        {
            get 
            {
                if (decanes == null)
                {
                    decanes = new FluidComponent("decanes");
                    decanes.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return decanes;
            }
        }

        private static FluidComponent cOneOneFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C11 fraction")]
        public static FluidComponent COneOneFraction
        {
            get 
            {
                if (cOneOneFraction == null)
                {
                    cOneOneFraction = new FluidComponent("C11 fraction");
                    cOneOneFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneOneFraction;
            }
        }

        private static FluidComponent cOneTwoFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C12 fraction")]
        public static FluidComponent COneTwoFraction
        {
            get 
            {
                if (cOneTwoFraction == null)
                {
                    cOneTwoFraction = new FluidComponent("C12 fraction");
                    cOneTwoFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneTwoFraction;
            }
        }

        private static FluidComponent cOneThreeFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C13 fraction")]
        public static FluidComponent COneThreeFraction
        {
            get 
            {
                if (cOneThreeFraction == null)
                {
                    cOneThreeFraction = new FluidComponent("C13 fraction");
                    cOneThreeFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneThreeFraction;
            }
        }

        private static FluidComponent cOneFourFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C14 fraction")]
        public static FluidComponent COneFourFraction
        {
            get 
            {
                if (cOneFourFraction == null)
                {
                    cOneFourFraction = new FluidComponent("C14 fraction");
                    cOneFourFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneFourFraction;
            }
        }

        private static FluidComponent cOneFiveFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C15 fraction")]
        public static FluidComponent COneFiveFraction
        {
            get 
            {
                if (cOneFiveFraction == null)
                {
                    cOneFiveFraction = new FluidComponent("C15 fraction");
                    cOneFiveFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneFiveFraction;
            }
        }

        private static FluidComponent cOneSixFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C16 fraction")]
        public static FluidComponent COneSixFraction
        {
            get 
            {
                if (cOneSixFraction == null)
                {
                    cOneSixFraction = new FluidComponent("C16 fraction");
                    cOneSixFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneSixFraction;
            }
        }

        private static FluidComponent cOneSevenFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C17 fraction")]
        public static FluidComponent COneSevenFraction
        {
            get 
            {
                if (cOneSevenFraction == null)
                {
                    cOneSevenFraction = new FluidComponent("C17 fraction");
                    cOneSevenFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneSevenFraction;
            }
        }

        private static FluidComponent cOneEightFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C18 fraction")]
        public static FluidComponent COneEightFraction
        {
            get 
            {
                if (cOneEightFraction == null)
                {
                    cOneEightFraction = new FluidComponent("C18 fraction");
                    cOneEightFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneEightFraction;
            }
        }

        private static FluidComponent cOneNineFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C19 fraction")]
        public static FluidComponent COneNineFraction
        {
            get 
            {
                if (cOneNineFraction == null)
                {
                    cOneNineFraction = new FluidComponent("C19 fraction");
                    cOneNineFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cOneNineFraction;
            }
        }

        private static FluidComponent cTwoZeroFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C20 fraction")]
        public static FluidComponent CTwoZeroFraction
        {
            get 
            {
                if (cTwoZeroFraction == null)
                {
                    cTwoZeroFraction = new FluidComponent("C20 fraction");
                    cTwoZeroFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoZeroFraction;
            }
        }

        private static FluidComponent cTwoOneFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C21 fraction")]
        public static FluidComponent CTwoOneFraction
        {
            get 
            {
                if (cTwoOneFraction == null)
                {
                    cTwoOneFraction = new FluidComponent("C21 fraction");
                    cTwoOneFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoOneFraction;
            }
        }

        private static FluidComponent cTwoTwoFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C22 fraction")]
        public static FluidComponent CTwoTwoFraction
        {
            get 
            {
                if (cTwoTwoFraction == null)
                {
                    cTwoTwoFraction = new FluidComponent("C22 fraction");
                    cTwoTwoFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoTwoFraction;
            }
        }

        private static FluidComponent cTwoThreeFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C23 fraction")]
        public static FluidComponent CTwoThreeFraction
        {
            get 
            {
                if (cTwoThreeFraction == null)
                {
                    cTwoThreeFraction = new FluidComponent("C23 fraction");
                    cTwoThreeFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoThreeFraction;
            }
        }

        private static FluidComponent cTwoFourFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C24 fraction")]
        public static FluidComponent CTwoFourFraction
        {
            get 
            {
                if (cTwoFourFraction == null)
                {
                    cTwoFourFraction = new FluidComponent("C24 fraction");
                    cTwoFourFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoFourFraction;
            }
        }

        private static FluidComponent cTwoFiveFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C25 fraction")]
        public static FluidComponent CTwoFiveFraction
        {
            get 
            {
                if (cTwoFiveFraction == null)
                {
                    cTwoFiveFraction = new FluidComponent("C25 fraction");
                    cTwoFiveFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoFiveFraction;
            }
        }

        private static FluidComponent cTwoSixFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C26 fraction")]
        public static FluidComponent CTwoSixFraction
        {
            get 
            {
                if (cTwoSixFraction == null)
                {
                    cTwoSixFraction = new FluidComponent("C26 fraction");
                    cTwoSixFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoSixFraction;
            }
        }

        private static FluidComponent cTwoSevenFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C27 fraction")]
        public static FluidComponent CTwoSevenFraction
        {
            get 
            {
                if (cTwoSevenFraction == null)
                {
                    cTwoSevenFraction = new FluidComponent("C27 fraction");
                    cTwoSevenFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoSevenFraction;
            }
        }

        private static FluidComponent cTwoEightFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C28 fraction")]
        public static FluidComponent CTwoEightFraction
        {
            get 
            {
                if (cTwoEightFraction == null)
                {
                    cTwoEightFraction = new FluidComponent("C28 fraction");
                    cTwoEightFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoEightFraction;
            }
        }

        private static FluidComponent cTwoNineFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C29 fraction")]
        public static FluidComponent CTwoNineFraction
        {
            get 
            {
                if (cTwoNineFraction == null)
                {
                    cTwoNineFraction = new FluidComponent("C29 fraction");
                    cTwoNineFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cTwoNineFraction;
            }
        }

        private static FluidComponent cThreeZeroFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C30 fraction")]
        public static FluidComponent CThreeZeroFraction
        {
            get 
            {
                if (cThreeZeroFraction == null)
                {
                    cThreeZeroFraction = new FluidComponent("C30 fraction");
                    cThreeZeroFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeZeroFraction;
            }
        }

        private static FluidComponent cThreeOneFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C31 fraction")]
        public static FluidComponent CThreeOneFraction
        {
            get 
            {
                if (cThreeOneFraction == null)
                {
                    cThreeOneFraction = new FluidComponent("C31 fraction");
                    cThreeOneFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeOneFraction;
            }
        }

        private static FluidComponent cThreeTwoFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C32 fraction")]
        public static FluidComponent CThreeTwoFraction
        {
            get 
            {
                if (cThreeTwoFraction == null)
                {
                    cThreeTwoFraction = new FluidComponent("C32 fraction");
                    cThreeTwoFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeTwoFraction;
            }
        }

        private static FluidComponent cThreeThreeFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C33 fraction")]
        public static FluidComponent CThreeThreeFraction
        {
            get 
            {
                if (cThreeThreeFraction == null)
                {
                    cThreeThreeFraction = new FluidComponent("C33 fraction");
                    cThreeThreeFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeThreeFraction;
            }
        }

        private static FluidComponent cThreeFourFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C34 fraction")]
        public static FluidComponent CThreeFourFraction
        {
            get 
            {
                if (cThreeFourFraction == null)
                {
                    cThreeFourFraction = new FluidComponent("C34 fraction");
                    cThreeFourFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeFourFraction;
            }
        }

        private static FluidComponent cThreeFiveFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C35 fraction")]
        public static FluidComponent CThreeFiveFraction
        {
            get 
            {
                if (cThreeFiveFraction == null)
                {
                    cThreeFiveFraction = new FluidComponent("C35 fraction");
                    cThreeFiveFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeFiveFraction;
            }
        }

        private static FluidComponent cThreeSixFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C36 fraction")]
        public static FluidComponent CThreeSixFraction
        {
            get 
            {
                if (cThreeSixFraction == null)
                {
                    cThreeSixFraction = new FluidComponent("C36 fraction");
                    cThreeSixFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeSixFraction;
            }
        }

        private static FluidComponent cThreeSevenFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C37 fraction")]
        public static FluidComponent CThreeSevenFraction
        {
            get 
            {
                if (cThreeSevenFraction == null)
                {
                    cThreeSevenFraction = new FluidComponent("C37 fraction");
                    cThreeSevenFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeSevenFraction;
            }
        }

        private static FluidComponent cThreeEightFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C38 fraction")]
        public static FluidComponent CThreeEightFraction
        {
            get 
            {
                if (cThreeEightFraction == null)
                {
                    cThreeEightFraction = new FluidComponent("C38 fraction");
                    cThreeEightFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeEightFraction;
            }
        }

        private static FluidComponent cThreeNineFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C39 fraction")]
        public static FluidComponent CThreeNineFraction
        {
            get 
            {
                if (cThreeNineFraction == null)
                {
                    cThreeNineFraction = new FluidComponent("C39 fraction");
                    cThreeNineFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cThreeNineFraction;
            }
        }

        private static FluidComponent cFourZeroFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C40 fraction")]
        public static FluidComponent CFourZeroFraction
        {
            get 
            {
                if (cFourZeroFraction == null)
                {
                    cFourZeroFraction = new FluidComponent("C40 fraction");
                    cFourZeroFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourZeroFraction;
            }
        }

        private static FluidComponent cFourOneFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C41 fraction")]
        public static FluidComponent CFourOneFraction
        {
            get 
            {
                if (cFourOneFraction == null)
                {
                    cFourOneFraction = new FluidComponent("C41 fraction");
                    cFourOneFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourOneFraction;
            }
        }

        private static FluidComponent cFourTwoFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C42 fraction")]
        public static FluidComponent CFourTwoFraction
        {
            get 
            {
                if (cFourTwoFraction == null)
                {
                    cFourTwoFraction = new FluidComponent("C42 fraction");
                    cFourTwoFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourTwoFraction;
            }
        }

        private static FluidComponent cFourThreeFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C43 fraction")]
        public static FluidComponent CFourThreeFraction
        {
            get 
            {
                if (cFourThreeFraction == null)
                {
                    cFourThreeFraction = new FluidComponent("C43 fraction");
                    cFourThreeFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourThreeFraction;
            }
        }

        private static FluidComponent cFourFourFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C44 fraction")]
        public static FluidComponent CFourFourFraction
        {
            get 
            {
                if (cFourFourFraction == null)
                {
                    cFourFourFraction = new FluidComponent("C44 fraction");
                    cFourFourFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourFourFraction;
            }
        }

        private static FluidComponent cFourFiveFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C45 fraction")]
        public static FluidComponent CFourFiveFraction
        {
            get 
            {
                if (cFourFiveFraction == null)
                {
                    cFourFiveFraction = new FluidComponent("C45 fraction");
                    cFourFiveFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourFiveFraction;
            }
        }

        private static FluidComponent cFourSixFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C46 fraction")]
        public static FluidComponent CFourSixFraction
        {
            get 
            {
                if (cFourSixFraction == null)
                {
                    cFourSixFraction = new FluidComponent("C46 fraction");
                    cFourSixFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourSixFraction;
            }
        }

        private static FluidComponent cFourSevenFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C47 fraction")]
        public static FluidComponent CFourSevenFraction
        {
            get 
            {
                if (cFourSevenFraction == null)
                {
                    cFourSevenFraction = new FluidComponent("C47 fraction");
                    cFourSevenFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourSevenFraction;
            }
        }

        private static FluidComponent cFourEightFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C48 fraction")]
        public static FluidComponent CFourEightFraction
        {
            get 
            {
                if (cFourEightFraction == null)
                {
                    cFourEightFraction = new FluidComponent("C48 fraction");
                    cFourEightFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourEightFraction;
            }
        }

        private static FluidComponent cFourNineFraction;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("C49 fraction")]
        public static FluidComponent CFourNineFraction
        {
            get 
            {
                if (cFourNineFraction == null)
                {
                    cFourNineFraction = new FluidComponent("C49 fraction");
                    cFourNineFraction.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cFourNineFraction;
            }
        }

        private static FluidComponent unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidComponent Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FluidComponent("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class FluidComponentKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FluidComponentKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FluidComponentKind</param>
        public FluidComponentKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FluidComponentKinds
        /// </summary>
        /// <returns>The complete list of FluidComponentKinds</returns>
        public static List<FluidComponentKind> GetList()
        {
            return GetList<FluidComponentKind>();
        }

        private static FluidComponentKind pure;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("pure")]
        public static FluidComponentKind Pure
        {
            get 
            {
                if (pure == null)
                {
                    pure = new FluidComponentKind("pure");
                    pure.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return pure;
            }
        }

        private static FluidComponentKind frac;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("frac")]
        public static FluidComponentKind Frac
        {
            get 
            {
                if (frac == null)
                {
                    frac = new FluidComponentKind("frac");
                    frac.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return frac;
            }
        }

        private static FluidComponentKind plus;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("plus")]
        public static FluidComponentKind Plus
        {
            get 
            {
                if (plus == null)
                {
                    plus = new FluidComponentKind("plus");
                    plus.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return plus;
            }
        }

        private static FluidComponentKind split;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("split")]
        public static FluidComponentKind Split
        {
            get 
            {
                if (split == null)
                {
                    split = new FluidComponentKind("split");
                    split.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return split;
            }
        }

        private static FluidComponentKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidComponentKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FluidComponentKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class FluidContaminant : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FluidContaminant(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FluidContaminant</param>
        public FluidContaminant(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FluidContaminants
        /// </summary>
        /// <returns>The complete list of FluidContaminants</returns>
        public static List<FluidContaminant> GetList()
        {
            return GetList<FluidContaminant>();
        }

        private static FluidContaminant drillingMud;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("drilling mud")]
        public static FluidContaminant DrillingMud
        {
            get 
            {
                if (drillingMud == null)
                {
                    drillingMud = new FluidContaminant("drilling mud");
                    drillingMud.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return drillingMud;
            }
        }

        private static FluidContaminant completionFluid;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("completion fluid")]
        public static FluidContaminant CompletionFluid
        {
            get 
            {
                if (completionFluid == null)
                {
                    completionFluid = new FluidContaminant("completion fluid");
                    completionFluid.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return completionFluid;
            }
        }

        private static FluidContaminant extraneousOil;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("extraneous oil")]
        public static FluidContaminant ExtraneousOil
        {
            get 
            {
                if (extraneousOil == null)
                {
                    extraneousOil = new FluidContaminant("extraneous oil");
                    extraneousOil.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return extraneousOil;
            }
        }

        private static FluidContaminant extraneousGas;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("extraneous gas")]
        public static FluidContaminant ExtraneousGas
        {
            get 
            {
                if (extraneousGas == null)
                {
                    extraneousGas = new FluidContaminant("extraneous gas");
                    extraneousGas.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return extraneousGas;
            }
        }

        private static FluidContaminant extraneousWater;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("extraneous water")]
        public static FluidContaminant ExtraneousWater
        {
            get 
            {
                if (extraneousWater == null)
                {
                    extraneousWater = new FluidContaminant("extraneous water");
                    extraneousWater.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return extraneousWater;
            }
        }

        private static FluidContaminant formationWater;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("formation water")]
        public static FluidContaminant FormationWater
        {
            get 
            {
                if (formationWater == null)
                {
                    formationWater = new FluidContaminant("formation water");
                    formationWater.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return formationWater;
            }
        }

        private static FluidContaminant cementFluids;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("cement fluids")]
        public static FluidContaminant CementFluids
        {
            get 
            {
                if (cementFluids == null)
                {
                    cementFluids = new FluidContaminant("cement fluids");
                    cementFluids.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return cementFluids;
            }
        }

        private static FluidContaminant treatmentChemicals;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("treatment chemicals")]
        public static FluidContaminant TreatmentChemicals
        {
            get 
            {
                if (treatmentChemicals == null)
                {
                    treatmentChemicals = new FluidContaminant("treatment chemicals");
                    treatmentChemicals.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return treatmentChemicals;
            }
        }

        private static FluidContaminant unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidContaminant Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FluidContaminant("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class FluidSampleKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FluidSampleKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FluidSampleKind</param>
        public FluidSampleKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FluidSampleKinds
        /// </summary>
        /// <returns>The complete list of FluidSampleKinds</returns>
        public static List<FluidSampleKind> GetList()
        {
            return GetList<FluidSampleKind>();
        }

        private static FluidSampleKind bottomHole;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("bottom hole")]
        public static FluidSampleKind BottomHole
        {
            get 
            {
                if (bottomHole == null)
                {
                    bottomHole = new FluidSampleKind("bottom hole");
                    bottomHole.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return bottomHole;
            }
        }

        private static FluidSampleKind wellhead;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("wellhead")]
        public static FluidSampleKind Wellhead
        {
            get 
            {
                if (wellhead == null)
                {
                    wellhead = new FluidSampleKind("wellhead");
                    wellhead.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return wellhead;
            }
        }

        private static FluidSampleKind drillStemTest;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("drill stem test")]
        public static FluidSampleKind DrillStemTest
        {
            get 
            {
                if (drillStemTest == null)
                {
                    drillStemTest = new FluidSampleKind("drill stem test");
                    drillStemTest.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return drillStemTest;
            }
        }

        private static FluidSampleKind formationTester;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("formation tester")]
        public static FluidSampleKind FormationTester
        {
            get 
            {
                if (formationTester == null)
                {
                    formationTester = new FluidSampleKind("formation tester");
                    formationTester.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return formationTester;
            }
        }

        private static FluidSampleKind rftOrMdt;
        /// <summary>
        /// Repeat Formation Tester or Modular Formation Dynamics Tester
        /// </summary>
        [EnumValueNameAttribute("RFT or MDT")]
        public static FluidSampleKind RftOrMdt
        {
            get 
            {
                if (rftOrMdt == null)
                {
                    rftOrMdt = new FluidSampleKind("RFT or MDT");
                    rftOrMdt.Description = "Repeat Formation Tester or Modular Formation Dynamics Tester";
                }
                return rftOrMdt;
            }
        }

        private static FluidSampleKind recombined;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("recombined")]
        public static FluidSampleKind Recombined
        {
            get 
            {
                if (recombined == null)
                {
                    recombined = new FluidSampleKind("recombined");
                    recombined.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return recombined;
            }
        }

        private static FluidSampleKind separatorGas;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator gas")]
        public static FluidSampleKind SeparatorGas
        {
            get 
            {
                if (separatorGas == null)
                {
                    separatorGas = new FluidSampleKind("separator gas");
                    separatorGas.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorGas;
            }
        }

        private static FluidSampleKind separatorOil;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator oil")]
        public static FluidSampleKind SeparatorOil
        {
            get 
            {
                if (separatorOil == null)
                {
                    separatorOil = new FluidSampleKind("separator oil");
                    separatorOil.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorOil;
            }
        }

        private static FluidSampleKind separatorWater;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator water")]
        public static FluidSampleKind SeparatorWater
        {
            get 
            {
                if (separatorWater == null)
                {
                    separatorWater = new FluidSampleKind("separator water");
                    separatorWater.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorWater;
            }
        }

        private static FluidSampleKind synthetic;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("synthetic")]
        public static FluidSampleKind Synthetic
        {
            get 
            {
                if (synthetic == null)
                {
                    synthetic = new FluidSampleKind("synthetic");
                    synthetic.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return synthetic;
            }
        }

        private static FluidSampleKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidSampleKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FluidSampleKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class FluidSampleTestAcquisition : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected FluidSampleTestAcquisition(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the FluidSampleTestAcquisition</param>
        public FluidSampleTestAcquisition(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of FluidSampleTestAcquisitions
        /// </summary>
        /// <returns>The complete list of FluidSampleTestAcquisitions</returns>
        public static List<FluidSampleTestAcquisition> GetList()
        {
            return GetList<FluidSampleTestAcquisition>();
        }

        private static FluidSampleTestAcquisition drillStemTest;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("drill stem test")]
        public static FluidSampleTestAcquisition DrillStemTest
        {
            get 
            {
                if (drillStemTest == null)
                {
                    drillStemTest = new FluidSampleTestAcquisition("drill stem test");
                    drillStemTest.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return drillStemTest;
            }
        }

        private static FluidSampleTestAcquisition repeatFormationTester;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("repeat formation tester")]
        public static FluidSampleTestAcquisition RepeatFormationTester
        {
            get 
            {
                if (repeatFormationTester == null)
                {
                    repeatFormationTester = new FluidSampleTestAcquisition("repeat formation tester");
                    repeatFormationTester.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return repeatFormationTester;
            }
        }

        private static FluidSampleTestAcquisition unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidSampleTestAcquisition Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new FluidSampleTestAcquisition("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Kind of fluid injected in a well test.
    /// </summary>
    public class InjectionFluid : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected InjectionFluid(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the InjectionFluid</param>
        public InjectionFluid(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of InjectionFluids
        /// </summary>
        /// <returns>The complete list of InjectionFluids</returns>
        public static List<InjectionFluid> GetList()
        {
            return GetList<InjectionFluid>();
        }

        private static InjectionFluid oil;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("oil")]
        public static InjectionFluid Oil
        {
            get 
            {
                if (oil == null)
                {
                    oil = new InjectionFluid("oil");
                }
                return oil;
            }
        }

        private static InjectionFluid gas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gas")]
        public static InjectionFluid Gas
        {
            get 
            {
                if (gas == null)
                {
                    gas = new InjectionFluid("gas");
                }
                return gas;
            }
        }

        private static InjectionFluid nonHcGas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("non HC gas")]
        public static InjectionFluid NonHcGas
        {
            get 
            {
                if (nonHcGas == null)
                {
                    nonHcGas = new InjectionFluid("non HC gas");
                }
                return nonHcGas;
            }
        }

        private static InjectionFluid coTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("CO2")]
        public static InjectionFluid CoTwo
        {
            get 
            {
                if (coTwo == null)
                {
                    coTwo = new InjectionFluid("CO2");
                }
                return coTwo;
            }
        }

        private static InjectionFluid water;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("water")]
        public static InjectionFluid Water
        {
            get 
            {
                if (water == null)
                {
                    water = new InjectionFluid("water");
                }
                return water;
            }
        }

        private static InjectionFluid brine;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("brine")]
        public static InjectionFluid Brine
        {
            get 
            {
                if (brine == null)
                {
                    brine = new InjectionFluid("brine");
                }
                return brine;
            }
        }

        private static InjectionFluid freshWater;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("fresh water")]
        public static InjectionFluid FreshWater
        {
            get 
            {
                if (freshWater == null)
                {
                    freshWater = new InjectionFluid("fresh water");
                }
                return freshWater;
            }
        }

        private static InjectionFluid oilgas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("oil-gas")]
        public static InjectionFluid Oilgas
        {
            get 
            {
                if (oilgas == null)
                {
                    oilgas = new InjectionFluid("oil-gas");
                }
                return oilgas;
            }
        }

        private static InjectionFluid oilwater;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("oil-water")]
        public static InjectionFluid Oilwater
        {
            get 
            {
                if (oilwater == null)
                {
                    oilwater = new InjectionFluid("oil-water");
                }
                return oilwater;
            }
        }

        private static InjectionFluid gaswater;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gas-water")]
        public static InjectionFluid Gaswater
        {
            get 
            {
                if (gaswater == null)
                {
                    gaswater = new InjectionFluid("gas-water");
                }
                return gaswater;
            }
        }

        private static InjectionFluid condensate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("condensate")]
        public static InjectionFluid Condensate
        {
            get 
            {
                if (condensate == null)
                {
                    condensate = new InjectionFluid("condensate");
                }
                return condensate;
            }
        }

        private static InjectionFluid steam;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("steam")]
        public static InjectionFluid Steam
        {
            get 
            {
                if (steam == null)
                {
                    steam = new InjectionFluid("steam");
                }
                return steam;
            }
        }

        private static InjectionFluid air;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("air")]
        public static InjectionFluid Air
        {
            get 
            {
                if (air == null)
                {
                    air = new InjectionFluid("air");
                }
                return air;
            }
        }

        private static InjectionFluid dry;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dry")]
        public static InjectionFluid Dry
        {
            get 
            {
                if (dry == null)
                {
                    dry = new InjectionFluid("dry");
                }
                return dry;
            }
        }

        private static InjectionFluid other;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static InjectionFluid Other
        {
            get 
            {
                if (other == null)
                {
                    other = new InjectionFluid("other");
                }
                return other;
            }
        }

        private static InjectionFluid unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static InjectionFluid Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new InjectionFluid("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The type of Distributed Temperature Survey (DTS) fiber point.
    /// </summary>
    public class InstalledFiberPoint : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected InstalledFiberPoint(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the InstalledFiberPoint</param>
        public InstalledFiberPoint(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of InstalledFiberPoints
        /// </summary>
        /// <returns>The complete list of InstalledFiberPoints</returns>
        public static List<InstalledFiberPoint> GetList()
        {
            return GetList<InstalledFiberPoint>();
        }

        private static InstalledFiberPoint splice;
        /// <summary>
        /// A point at which a fiber is physically, and semi-permanently, connected to another length of fiber.
        /// </summary>
        [EnumValueNameAttribute("splice")]
        public static InstalledFiberPoint Splice
        {
            get 
            {
                if (splice == null)
                {
                    splice = new InstalledFiberPoint("splice");
                    splice.Description = "A point at which a fiber is physically, and semi-permanently, connected to another length of fiber.";
                }
                return splice;
            }
        }

        private static InstalledFiberPoint connector;
        /// <summary>
        /// A point at which a cable connector is installed, which allows the fiber to be connected to another instrument or fiber length.
        /// </summary>
        [EnumValueNameAttribute("connector")]
        public static InstalledFiberPoint Connector
        {
            get 
            {
                if (connector == null)
                {
                    connector = new InstalledFiberPoint("connector");
                    connector.Description = "A point at which a cable connector is installed, which allows the fiber to be connected to another instrument or fiber length.";
                }
                return connector;
            }
        }

        private static InstalledFiberPoint endOfFiber;
        /// <summary>
        /// The end of the fiber. If a U-geometry is used, and a connector is at both ends, the connector classification should be used rather than the end of fiber classification.
        /// </summary>
        [EnumValueNameAttribute("end of fiber")]
        public static InstalledFiberPoint EndOfFiber
        {
            get 
            {
                if (endOfFiber == null)
                {
                    endOfFiber = new InstalledFiberPoint("end of fiber");
                    endOfFiber.Description = "The end of the fiber. If a U-geometry is used, and a connector is at both ends, the connector classification should be used rather than the end of fiber classification.";
                }
                return endOfFiber;
            }
        }

        private static InstalledFiberPoint baseOfFiber;
        /// <summary>
        /// The deepest point of the installed fiber in a well. This is a valid value for fiber installations that do NOT turn around at the bottom (J- and U-type installations).
        /// </summary>
        [EnumValueNameAttribute("base of fiber")]
        public static InstalledFiberPoint BaseOfFiber
        {
            get 
            {
                if (baseOfFiber == null)
                {
                    baseOfFiber = new InstalledFiberPoint("base of fiber");
                    baseOfFiber.Description = "The deepest point of the installed fiber in a well. This is a valid value for fiber installations that do NOT turn around at the bottom (J- and U-type installations).";
                }
                return baseOfFiber;
            }
        }

        private static InstalledFiberPoint turnAroundPoint;
        /// <summary>
        /// The point in the turn-around-sub at which measured depth stops increasing and begins decreasing. This is a valid value for fiber installations of the J- and U- type only.
        /// </summary>
        [EnumValueNameAttribute("turn around point")]
        public static InstalledFiberPoint TurnAroundPoint
        {
            get 
            {
                if (turnAroundPoint == null)
                {
                    turnAroundPoint = new InstalledFiberPoint("turn around point");
                    turnAroundPoint.Description = "The point in the turn-around-sub at which measured depth stops increasing and begins decreasing. This is a valid value for fiber installations of the J- and U- type only.";
                }
                return turnAroundPoint;
            }
        }

        private static InstalledFiberPoint startOfFiber;
        /// <summary>
        /// The start of the fiber. If appropriate, the connector classification should be used instead of this classification.
        /// </summary>
        [EnumValueNameAttribute("start of fiber")]
        public static InstalledFiberPoint StartOfFiber
        {
            get 
            {
                if (startOfFiber == null)
                {
                    startOfFiber = new InstalledFiberPoint("start of fiber");
                    startOfFiber.Description = "The start of the fiber. If appropriate, the connector classification should be used instead of this classification.";
                }
                return startOfFiber;
            }
        }

        private static InstalledFiberPoint ovenEntryPoint;
        /// <summary>
        /// The point on the fiber at which it enters the oven.
        /// </summary>
        [EnumValueNameAttribute("oven entry point")]
        public static InstalledFiberPoint OvenEntryPoint
        {
            get 
            {
                if (ovenEntryPoint == null)
                {
                    ovenEntryPoint = new InstalledFiberPoint("oven entry point");
                    ovenEntryPoint.Description = "The point on the fiber at which it enters the oven.";
                }
                return ovenEntryPoint;
            }
        }

        private static InstalledFiberPoint ovenExitPoint;
        /// <summary>
        /// The point on the fiber at which it exits the oven. The oven exit point should be closer to the wellbore than the oven entry point.
        /// </summary>
        [EnumValueNameAttribute("oven exit point")]
        public static InstalledFiberPoint OvenExitPoint
        {
            get 
            {
                if (ovenExitPoint == null)
                {
                    ovenExitPoint = new InstalledFiberPoint("oven exit point");
                    ovenExitPoint.Description = "The point on the fiber at which it exits the oven. The oven exit point should be closer to the wellbore than the oven entry point.";
                }
                return ovenExitPoint;
            }
        }

        private static InstalledFiberPoint downholeGauge;
        /// <summary>
        /// A downhole point on the fiber at which a gauge is attached.
        /// </summary>
        [EnumValueNameAttribute("downhole gauge")]
        public static InstalledFiberPoint DownholeGauge
        {
            get 
            {
                if (downholeGauge == null)
                {
                    downholeGauge = new InstalledFiberPoint("downhole gauge");
                    downholeGauge.Description = "A downhole point on the fiber at which a gauge is attached.";
                }
                return downholeGauge;
            }
        }

        private static InstalledFiberPoint dtsLaserHead;
        /// <summary>
        /// The connector between the laser head and the optical fiber.
        /// </summary>
        [EnumValueNameAttribute("DTS laser head")]
        public static InstalledFiberPoint DtsLaserHead
        {
            get 
            {
                if (dtsLaserHead == null)
                {
                    dtsLaserHead = new InstalledFiberPoint("DTS laser head");
                    dtsLaserHead.Description = "The connector between the laser head and the optical fiber.";
                }
                return dtsLaserHead;
            }
        }

        private static InstalledFiberPoint dtsReferenceOven;
        /// <summary>
        /// The oven within or near the DTS instrument box which maintains a length of fiber at a reference temperature.
        /// </summary>
        [EnumValueNameAttribute("DTS reference oven")]
        public static InstalledFiberPoint DtsReferenceOven
        {
            get 
            {
                if (dtsReferenceOven == null)
                {
                    dtsReferenceOven = new InstalledFiberPoint("DTS reference oven");
                    dtsReferenceOven.Description = "The oven within or near the DTS instrument box which maintains a length of fiber at a reference temperature.";
                }
                return dtsReferenceOven;
            }
        }

        private static InstalledFiberPoint spliceBox;
        /// <summary>
        /// Container in which ends of lengths of fiber are joined.
        /// </summary>
        [EnumValueNameAttribute("splice box")]
        public static InstalledFiberPoint SpliceBox
        {
            get 
            {
                if (spliceBox == null)
                {
                    spliceBox = new InstalledFiberPoint("splice box");
                    spliceBox.Description = "Container in which ends of lengths of fiber are joined.";
                }
                return spliceBox;
            }
        }

        private static InstalledFiberPoint wellheadJunctionBox;
        /// <summary>
        /// The device at which a fiber originating at the instrument box is joined to a fiber installed in a wellbore. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated
        /// </summary>
        [EnumValueNameAttribute("wellhead junction box")]
        public static InstalledFiberPoint WellheadJunctionBox
        {
            get 
            {
                if (wellheadJunctionBox == null)
                {
                    wellheadJunctionBox = new InstalledFiberPoint("wellhead junction box");
                    wellheadJunctionBox.Description = "The device at which a fiber originating at the instrument box is joined to a fiber installed in a wellbore. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated";
                }
                return wellheadJunctionBox;
            }
        }

        private static InstalledFiberPoint baseTubingHangerFlange;
        /// <summary>
        /// The device at the base of the wellhead to which the production tubing is attached. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated.
        /// </summary>
        [EnumValueNameAttribute("base tubing hanger flange")]
        public static InstalledFiberPoint BaseTubingHangerFlange
        {
            get 
            {
                if (baseTubingHangerFlange == null)
                {
                    baseTubingHangerFlange = new InstalledFiberPoint("base tubing hanger flange");
                    baseTubingHangerFlange.Description = "The device at the base of the wellhead to which the production tubing is attached. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated.";
                }
                return baseTubingHangerFlange;
            }
        }

        private static InstalledFiberPoint pbrWetConnect;
        /// <summary>
        /// The top-most point at which the fiber intersects the PBR (polished bore receptacle). For J- and U- installations, on the upward portion of the fiber, this is the point at which it leaves the pbf.
        /// </summary>
        [EnumValueNameAttribute("PBR wet connect")]
        public static InstalledFiberPoint PbrWetConnect
        {
            get 
            {
                if (pbrWetConnect == null)
                {
                    pbrWetConnect = new InstalledFiberPoint("PBR wet connect");
                    pbrWetConnect.Description = "The top-most point at which the fiber intersects the PBR (polished bore receptacle). For J- and U- installations, on the upward portion of the fiber, this is the point at which it leaves the pbf.";
                }
                return pbrWetConnect;
            }
        }

        private static InstalledFiberPoint topEspPump;
        /// <summary>
        /// The top of the electrical submersible pump (ESP). This is the minimum measured depth point of the pump.
        /// </summary>
        [EnumValueNameAttribute("top ESP pump")]
        public static InstalledFiberPoint TopEspPump
        {
            get 
            {
                if (topEspPump == null)
                {
                    topEspPump = new InstalledFiberPoint("top ESP pump");
                    topEspPump.Description = "The top of the electrical submersible pump (ESP). This is the minimum measured depth point of the pump.";
                }
                return topEspPump;
            }
        }

        private static InstalledFiberPoint baseEspPump;
        /// <summary>
        /// The base of the electrical submersible pump (ESP). This is the maximum measured depth point of the pump.
        /// </summary>
        [EnumValueNameAttribute("base ESP pump")]
        public static InstalledFiberPoint BaseEspPump
        {
            get 
            {
                if (baseEspPump == null)
                {
                    baseEspPump = new InstalledFiberPoint("base ESP pump");
                    baseEspPump.Description = "The base of the electrical submersible pump (ESP). This is the maximum measured depth point of the pump.";
                }
                return baseEspPump;
            }
        }

        private static InstalledFiberPoint wellheadTemperatureGauge;
        /// <summary>
        /// Temperature measuring device at the wellhead independent of the optic fiber sensor.
        /// </summary>
        [EnumValueNameAttribute("wellhead temperature gauge")]
        public static InstalledFiberPoint WellheadTemperatureGauge
        {
            get 
            {
                if (wellheadTemperatureGauge == null)
                {
                    wellheadTemperatureGauge = new InstalledFiberPoint("wellhead temperature gauge");
                    wellheadTemperatureGauge.Description = "Temperature measuring device at the wellhead independent of the optic fiber sensor.";
                }
                return wellheadTemperatureGauge;
            }
        }

        private static InstalledFiberPoint topCompletionZone;
        /// <summary>
        /// The point which is the minimum measured depth of a completion zone.
        /// </summary>
        [EnumValueNameAttribute("top completion zone")]
        public static InstalledFiberPoint TopCompletionZone
        {
            get 
            {
                if (topCompletionZone == null)
                {
                    topCompletionZone = new InstalledFiberPoint("top completion zone");
                    topCompletionZone.Description = "The point which is the minimum measured depth of a completion zone.";
                }
                return topCompletionZone;
            }
        }

        private static InstalledFiberPoint baseCompletionZone;
        /// <summary>
        /// The point which is the maximum measured depth of a completion zone.
        /// </summary>
        [EnumValueNameAttribute("base completion zone")]
        public static InstalledFiberPoint BaseCompletionZone
        {
            get 
            {
                if (baseCompletionZone == null)
                {
                    baseCompletionZone = new InstalledFiberPoint("base completion zone");
                    baseCompletionZone.Description = "The point which is the maximum measured depth of a completion zone.";
                }
                return baseCompletionZone;
            }
        }

        private static InstalledFiberPoint unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static InstalledFiberPoint Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new InstalledFiberPoint("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The type of operation for which general comments can be defined.
    /// </summary>
    public class OperationKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected OperationKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the OperationKind</param>
        public OperationKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of OperationKinds
        /// </summary>
        /// <returns>The complete list of OperationKinds</returns>
        public static List<OperationKind> GetList()
        {
            return GetList<OperationKind>();
        }

        private static OperationKind production;
        /// <summary>
        /// Production operations.
        /// </summary>
        [EnumValueNameAttribute("production")]
        public static OperationKind Production
        {
            get 
            {
                if (production == null)
                {
                    production = new OperationKind("production");
                    production.Description = "Production operations.";
                }
                return production;
            }
        }

        private static OperationKind well;
        /// <summary>
        /// Well operations.
        /// </summary>
        [EnumValueNameAttribute("well")]
        public static OperationKind Well
        {
            get 
            {
                if (well == null)
                {
                    well = new OperationKind("well");
                    well.Description = "Well operations.";
                }
                return well;
            }
        }

        private static OperationKind deviations;
        /// <summary>
        /// Deviations from existing procedures and guidelines.
        /// </summary>
        [EnumValueNameAttribute("deviations")]
        public static OperationKind Deviations
        {
            get 
            {
                if (deviations == null)
                {
                    deviations = new OperationKind("deviations");
                    deviations.Description = "Deviations from existing procedures and guidelines.";
                }
                return deviations;
            }
        }

        private static OperationKind maintenance;
        /// <summary>
        /// Maintenance work.
        /// </summary>
        [EnumValueNameAttribute("maintenance")]
        public static OperationKind Maintenance
        {
            get 
            {
                if (maintenance == null)
                {
                    maintenance = new OperationKind("maintenance");
                    maintenance.Description = "Maintenance work.";
                }
                return maintenance;
            }
        }

        private static OperationKind construction;
        /// <summary>
        /// Construction work.
        /// </summary>
        [EnumValueNameAttribute("construction")]
        public static OperationKind Construction
        {
            get 
            {
                if (construction == null)
                {
                    construction = new OperationKind("construction");
                    construction.Description = "Construction work.";
                }
                return construction;
            }
        }

        private static OperationKind powerStationFailure;
        /// <summary>
        /// Failure of a power station.
        /// </summary>
        [EnumValueNameAttribute("power station failure")]
        public static OperationKind PowerStationFailure
        {
            get 
            {
                if (powerStationFailure == null)
                {
                    powerStationFailure = new OperationKind("power station failure");
                    powerStationFailure.Description = "Failure of a power station.";
                }
                return powerStationFailure;
            }
        }

        private static OperationKind airTraffic;
        /// <summary>
        /// Air traffic in the area.
        /// </summary>
        [EnumValueNameAttribute("air traffic")]
        public static OperationKind AirTraffic
        {
            get 
            {
                if (airTraffic == null)
                {
                    airTraffic = new OperationKind("air traffic");
                    airTraffic.Description = "Air traffic in the area.";
                }
                return airTraffic;
            }
        }

        private static OperationKind other;
        /// <summary>
        /// Other comment relevant for the production periods on the installation.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static OperationKind Other
        {
            get 
            {
                if (other == null)
                {
                    other = new OperationKind("other");
                    other.Description = "Other comment relevant for the production periods on the installation.";
                }
                return other;
            }
        }

        private static OperationKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static OperationKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new OperationKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The reason an Optical Time Domain Reflectometry (OTDR) 
    ///			test was run within a  Distributed Temperature Survey (DTS).
    /// </summary>
    public class OTDRReason : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected OTDRReason(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the OTDRReason</param>
        public OTDRReason(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of OTDRReasons
        /// </summary>
        /// <returns>The complete list of OTDRReasons</returns>
        public static List<OTDRReason> GetList()
        {
            return GetList<OTDRReason>();
        }

        private static OTDRReason preinstallation;
        /// <summary>
        /// The OTDR was run prior to installing the fiber in the well.
        /// </summary>
        [EnumValueNameAttribute("pre-installation")]
        public static OTDRReason Preinstallation
        {
            get 
            {
                if (preinstallation == null)
                {
                    preinstallation = new OTDRReason("pre-installation");
                    preinstallation.Description = "The OTDR was run prior to installing the fiber in the well.";
                }
                return preinstallation;
            }
        }

        private static OTDRReason postinstallation;
        /// <summary>
        /// The OTDR was run after installating the fiber in the well in order to quality check the installation process.
        /// </summary>
        [EnumValueNameAttribute("post-installation")]
        public static OTDRReason Postinstallation
        {
            get 
            {
                if (postinstallation == null)
                {
                    postinstallation = new OTDRReason("post-installation");
                    postinstallation.Description = "The OTDR was run after installating the fiber in the well in order to quality check the installation process.";
                }
                return postinstallation;
            }
        }

        private static OTDRReason dtsRun;
        /// <summary>
        /// The OTDR was run in conjunction with a DTS run. This is generally immediately preceding the timed run.
        /// </summary>
        [EnumValueNameAttribute("DTS run")]
        public static OTDRReason DtsRun
        {
            get 
            {
                if (dtsRun == null)
                {
                    dtsRun = new OTDRReason("DTS run");
                    dtsRun.Description = "The OTDR was run in conjunction with a DTS run. This is generally immediately preceding the timed run.";
                }
                return dtsRun;
            }
        }

        private static OTDRReason other;
        /// <summary>
        /// The OTDR was run for another reason.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static OTDRReason Other
        {
            get 
            {
                if (other == null)
                {
                    other = new OTDRReason("other");
                    other.Description = "The OTDR was run for another reason.";
                }
                return other;
            }
        }

        private static OTDRReason unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static OTDRReason Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new OTDRReason("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// One method of characterizing a phone number.
    /// </summary>
    public class PhoneType : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected PhoneType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the PhoneType</param>
        public PhoneType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of PhoneTypes
        /// </summary>
        /// <returns>The complete list of PhoneTypes</returns>
        public static List<PhoneType> GetList()
        {
            return GetList<PhoneType>();
        }

        private static PhoneType voice;
        /// <summary>
        /// The telephone number is a conventional number which is used for voice contact.
        /// </summary>
        [EnumValueNameAttribute("voice")]
        public static PhoneType Voice
        {
            get 
            {
                if (voice == null)
                {
                    voice = new PhoneType("voice");
                    voice.Description = "The telephone number is a conventional number which is used for voice contact.";
                }
                return voice;
            }
        }

        private static PhoneType fax;
        /// <summary>
        /// The telephone number is exclusively used for receiving faxes.
        /// </summary>
        [EnumValueNameAttribute("fax")]
        public static PhoneType Fax
        {
            get 
            {
                if (fax == null)
                {
                    fax = new PhoneType("fax");
                    fax.Description = "The telephone number is exclusively used for receiving faxes.";
                }
                return fax;
            }
        }

        private static PhoneType mobile;
        /// <summary>
        /// The telephone number is a mobile telephone, such as a cell phone.
        /// </summary>
        [EnumValueNameAttribute("mobile")]
        public static PhoneType Mobile
        {
            get 
            {
                if (mobile == null)
                {
                    mobile = new PhoneType("mobile");
                    mobile.Description = "The telephone number is a mobile telephone, such as a cell phone.";
                }
                return mobile;
            }
        }

        private static PhoneType voicefax;
        /// <summary>
        /// The telephone at this number is capable of voice communication and of receiving faxes.
        /// </summary>
        [EnumValueNameAttribute("voice/fax")]
        public static PhoneType Voicefax
        {
            get 
            {
                if (voicefax == null)
                {
                    voicefax = new PhoneType("voice/fax");
                    voicefax.Description = "The telephone at this number is capable of voice communication and of receiving faxes.";
                }
                return voicefax;
            }
        }

        private static PhoneType voicemail;
        /// <summary>
        /// The telephone is connected directly to voice mail. A voice phone may lead a caller to voice mail. However this choice qualifies the phone type as being only voice mail.
        /// </summary>
        [EnumValueNameAttribute("voicemail")]
        public static PhoneType Voicemail
        {
            get 
            {
                if (voicemail == null)
                {
                    voicemail = new PhoneType("voicemail");
                    voicemail.Description = "The telephone is connected directly to voice mail. A voice phone may lead a caller to voice mail. However this choice qualifies the phone type as being only voice mail.";
                }
                return voicemail;
            }
        }

        private static PhoneType pager;
        /// <summary>
        /// The telephone is intended only for pages.
        /// </summary>
        [EnumValueNameAttribute("pager")]
        public static PhoneType Pager
        {
            get 
            {
                if (pager == null)
                {
                    pager = new PhoneType("pager");
                    pager.Description = "The telephone is intended only for pages.";
                }
                return pager;
            }
        }

        private static PhoneType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static PhoneType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new PhoneType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines the types of Product Flow Ports.
    /// </summary>
    public class ProductFlowPortType : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ProductFlowPortType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ProductFlowPortType</param>
        public ProductFlowPortType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ProductFlowPortTypes
        /// </summary>
        /// <returns>The complete list of ProductFlowPortTypes</returns>
        public static List<ProductFlowPortType> GetList()
        {
            return GetList<ProductFlowPortType>();
        }

        private static ProductFlowPortType inlet;
        /// <summary>
        /// An inlet port by which fluid normally flows into the Product Flow Unit.
        /// </summary>
        [EnumValueNameAttribute("inlet")]
        public static ProductFlowPortType Inlet
        {
            get 
            {
                if (inlet == null)
                {
                    inlet = new ProductFlowPortType("inlet");
                    inlet.Description = "An inlet port by which fluid normally flows into the Product Flow Unit.";
                }
                return inlet;
            }
        }

        private static ProductFlowPortType outlet;
        /// <summary>
        /// An inlet port by which fluid normally flows out of Product Flow Unit.
        /// </summary>
        [EnumValueNameAttribute("outlet")]
        public static ProductFlowPortType Outlet
        {
            get 
            {
                if (outlet == null)
                {
                    outlet = new ProductFlowPortType("outlet");
                    outlet.Description = "An inlet port by which fluid normally flows out of Product Flow Unit.";
                }
                return outlet;
            }
        }

        private static ProductFlowPortType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ProductFlowPortType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ProductFlowPortType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Reason for lost production.
    /// </summary>
    public class ReasonLost : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReasonLost(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReasonLost</param>
        public ReasonLost(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReasonLosts
        /// </summary>
        /// <returns>The complete list of ReasonLosts</returns>
        public static List<ReasonLost> GetList()
        {
            return GetList<ReasonLost>();
        }

        private static ReasonLost topsideEquipmentFailuremaint;
        /// <summary>
        /// Estimated loss of production due to equipment failure and maintenance topside.
        /// </summary>
        [EnumValueNameAttribute("topside equipment failure-maint")]
        public static ReasonLost TopsideEquipmentFailuremaint
        {
            get 
            {
                if (topsideEquipmentFailuremaint == null)
                {
                    topsideEquipmentFailuremaint = new ReasonLost("topside equipment failure-maint");
                    topsideEquipmentFailuremaint.Description = "Estimated loss of production due to equipment failure and maintenance topside.";
                }
                return topsideEquipmentFailuremaint;
            }
        }

        private static ReasonLost extendedMaintTurnaround;
        /// <summary>
        /// Estimated loss of production due to extended maintenance turnaround.
        /// </summary>
        [EnumValueNameAttribute("extended maint turnaround")]
        public static ReasonLost ExtendedMaintTurnaround
        {
            get 
            {
                if (extendedMaintTurnaround == null)
                {
                    extendedMaintTurnaround = new ReasonLost("extended maint turnaround");
                    extendedMaintTurnaround.Description = "Estimated loss of production due to extended maintenance turnaround.";
                }
                return extendedMaintTurnaround;
            }
        }

        private static ReasonLost extendedMaintTurnaroundExport;
        /// <summary>
        /// Estimated loss of production due to extended maintenance turnaround on export terminal.
        /// </summary>
        [EnumValueNameAttribute("extended maint turnaround export")]
        public static ReasonLost ExtendedMaintTurnaroundExport
        {
            get 
            {
                if (extendedMaintTurnaroundExport == null)
                {
                    extendedMaintTurnaroundExport = new ReasonLost("extended maint turnaround export");
                    extendedMaintTurnaroundExport.Description = "Estimated loss of production due to extended maintenance turnaround on export terminal.";
                }
                return extendedMaintTurnaroundExport;
            }
        }

        private static ReasonLost preventiveMaintTopside;
        /// <summary>
        /// Estimated loss of production due to preventive maintenance topside.
        /// </summary>
        [EnumValueNameAttribute("preventive maint topside")]
        public static ReasonLost PreventiveMaintTopside
        {
            get 
            {
                if (preventiveMaintTopside == null)
                {
                    preventiveMaintTopside = new ReasonLost("preventive maint topside");
                    preventiveMaintTopside.Description = "Estimated loss of production due to preventive maintenance topside.";
                }
                return preventiveMaintTopside;
            }
        }

        private static ReasonLost plannedMaintTurnaround;
        /// <summary>
        /// Estimated loss of production due to planned maintenance turnaround.
        /// </summary>
        [EnumValueNameAttribute("planned maint turnaround")]
        public static ReasonLost PlannedMaintTurnaround
        {
            get 
            {
                if (plannedMaintTurnaround == null)
                {
                    plannedMaintTurnaround = new ReasonLost("planned maint turnaround");
                    plannedMaintTurnaround.Description = "Estimated loss of production due to planned maintenance turnaround.";
                }
                return plannedMaintTurnaround;
            }
        }

        private static ReasonLost markedOil;
        /// <summary>
        /// Estimated loss of oil production due to lost export due to marked product.
        /// </summary>
        [EnumValueNameAttribute("marked oil")]
        public static ReasonLost MarkedOil
        {
            get 
            {
                if (markedOil == null)
                {
                    markedOil = new ReasonLost("marked oil");
                    markedOil.Description = "Estimated loss of oil production due to lost export due to marked product.";
                }
                return markedOil;
            }
        }

        private static ReasonLost markedGas;
        /// <summary>
        /// Estimated loss of gas production due to lost export due to marked product.
        /// </summary>
        [EnumValueNameAttribute("marked gas")]
        public static ReasonLost MarkedGas
        {
            get 
            {
                if (markedGas == null)
                {
                    markedGas = new ReasonLost("marked gas");
                    markedGas.Description = "Estimated loss of gas production due to lost export due to marked product.";
                }
                return markedGas;
            }
        }

        private static ReasonLost modificationProject;
        /// <summary>
        /// Estimated loss of production due to modification projects.
        /// </summary>
        [EnumValueNameAttribute("modification project")]
        public static ReasonLost ModificationProject
        {
            get 
            {
                if (modificationProject == null)
                {
                    modificationProject = new ReasonLost("modification project");
                    modificationProject.Description = "Estimated loss of production due to modification projects.";
                }
                return modificationProject;
            }
        }

        private static ReasonLost operationMistakes;
        /// <summary>
        /// Estimated loss of production due to operation mistakes reference.
        /// </summary>
        [EnumValueNameAttribute("operation mistakes")]
        public static ReasonLost OperationMistakes
        {
            get 
            {
                if (operationMistakes == null)
                {
                    operationMistakes = new ReasonLost("operation mistakes");
                    operationMistakes.Description = "Estimated loss of production due to operation mistakes reference.";
                }
                return operationMistakes;
            }
        }

        private static ReasonLost other;
        /// <summary>
        /// Estimated loss of production due to unspecified reasons.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static ReasonLost Other
        {
            get 
            {
                if (other == null)
                {
                    other = new ReasonLost("other");
                    other.Description = "Estimated loss of production due to unspecified reasons.";
                }
                return other;
            }
        }

        private static ReasonLost processAndOperationProblem;
        /// <summary>
        /// Estimated loss of production due to process and operation problems.
        /// </summary>
        [EnumValueNameAttribute("process and operation problem")]
        public static ReasonLost ProcessAndOperationProblem
        {
            get 
            {
                if (processAndOperationProblem == null)
                {
                    processAndOperationProblem = new ReasonLost("process and operation problem");
                    processAndOperationProblem.Description = "Estimated loss of production due to process and operation problems.";
                }
                return processAndOperationProblem;
            }
        }

        private static ReasonLost production;
        /// <summary>
        /// Estimated loss of production due to total loss of production.
        /// </summary>
        [EnumValueNameAttribute("production")]
        public static ReasonLost Production
        {
            get 
            {
                if (production == null)
                {
                    production = new ReasonLost("production");
                    production.Description = "Estimated loss of production due to total loss of production.";
                }
                return production;
            }
        }

        private static ReasonLost regulatoryReference;
        /// <summary>
        /// Estimated loss of production due to regulatory reference.
        /// </summary>
        [EnumValueNameAttribute("regulatory reference")]
        public static ReasonLost RegulatoryReference
        {
            get 
            {
                if (regulatoryReference == null)
                {
                    regulatoryReference = new ReasonLost("regulatory reference");
                    regulatoryReference.Description = "Estimated loss of production due to regulatory reference.";
                }
                return regulatoryReference;
            }
        }

        private static ReasonLost reservoir;
        /// <summary>
        /// Estimated loss of production due to reservoir losses.
        /// </summary>
        [EnumValueNameAttribute("reservoir")]
        public static ReasonLost Reservoir
        {
            get 
            {
                if (reservoir == null)
                {
                    reservoir = new ReasonLost("reservoir");
                    reservoir.Description = "Estimated loss of production due to reservoir losses.";
                }
                return reservoir;
            }
        }

        private static ReasonLost testingAndLogging;
        /// <summary>
        /// Estimated loss of production due to well testing and logging.
        /// </summary>
        [EnumValueNameAttribute("testing and logging")]
        public static ReasonLost TestingAndLogging
        {
            get 
            {
                if (testingAndLogging == null)
                {
                    testingAndLogging = new ReasonLost("testing and logging");
                    testingAndLogging.Description = "Estimated loss of production due to well testing and logging.";
                }
                return testingAndLogging;
            }
        }

        private static ReasonLost unavailableTankerStorage;
        /// <summary>
        /// Estimated loss of production due to unavailable tanker storage.
        /// </summary>
        [EnumValueNameAttribute("unavailable tanker storage")]
        public static ReasonLost UnavailableTankerStorage
        {
            get 
            {
                if (unavailableTankerStorage == null)
                {
                    unavailableTankerStorage = new ReasonLost("unavailable tanker storage");
                    unavailableTankerStorage.Description = "Estimated loss of production due to unavailable tanker storage.";
                }
                return unavailableTankerStorage;
            }
        }

        private static ReasonLost wellEquipmentFailuremaint;
        /// <summary>
        /// Estimated loss of production due to well equipment failure and maintenance.
        /// </summary>
        [EnumValueNameAttribute("well equipment failure-maint")]
        public static ReasonLost WellEquipmentFailuremaint
        {
            get 
            {
                if (wellEquipmentFailuremaint == null)
                {
                    wellEquipmentFailuremaint = new ReasonLost("well equipment failure-maint");
                    wellEquipmentFailuremaint.Description = "Estimated loss of production due to well equipment failure and maintenance.";
                }
                return wellEquipmentFailuremaint;
            }
        }

        private static ReasonLost wellPlannedOperations;
        /// <summary>
        /// Estimated loss of production due to planned well operations.
        /// </summary>
        [EnumValueNameAttribute("well planned operations")]
        public static ReasonLost WellPlannedOperations
        {
            get 
            {
                if (wellPlannedOperations == null)
                {
                    wellPlannedOperations = new ReasonLost("well planned operations");
                    wellPlannedOperations.Description = "Estimated loss of production due to planned well operations.";
                }
                return wellPlannedOperations;
            }
        }

        private static ReasonLost wellPreventiveMaint;
        /// <summary>
        /// Estimated loss of production due to preventive maintenance on a well.
        /// </summary>
        [EnumValueNameAttribute("well preventive maint")]
        public static ReasonLost WellPreventiveMaint
        {
            get 
            {
                if (wellPreventiveMaint == null)
                {
                    wellPreventiveMaint = new ReasonLost("well preventive maint");
                    wellPreventiveMaint.Description = "Estimated loss of production due to preventive maintenance on a well.";
                }
                return wellPreventiveMaint;
            }
        }

        private static ReasonLost weatherProblem;
        /// <summary>
        /// Estimated loss of production due to weather conditions.
        /// </summary>
        [EnumValueNameAttribute("weather problem")]
        public static ReasonLost WeatherProblem
        {
            get 
            {
                if (weatherProblem == null)
                {
                    weatherProblem = new ReasonLost("weather problem");
                    weatherProblem.Description = "Estimated loss of production due to weather conditions.";
                }
                return weatherProblem;
            }
        }

        private static ReasonLost hse;
        /// <summary>
        /// Estimated loss of production due to Safety or Emergency requirements.
        /// </summary>
        [EnumValueNameAttribute("hse")]
        public static ReasonLost Hse
        {
            get 
            {
                if (hse == null)
                {
                    hse = new ReasonLost("hse");
                    hse.Description = "Estimated loss of production due to Safety or Emergency requirements.";
                }
                return hse;
            }
        }

        private static ReasonLost strikelockout;
        /// <summary>
        /// Estimated loss of production due to strike or lock-out.
        /// </summary>
        [EnumValueNameAttribute("strike/lock-out")]
        public static ReasonLost Strikelockout
        {
            get 
            {
                if (strikelockout == null)
                {
                    strikelockout = new ReasonLost("strike/lock-out");
                    strikelockout.Description = "Estimated loss of production due to strike or lock-out.";
                }
                return strikelockout;
            }
        }

        private static ReasonLost threerdPartyProcessing;
        /// <summary>
        /// Estimated loss of production due to 3rd party processing.
        /// </summary>
        [EnumValueNameAttribute("3rd party processing")]
        public static ReasonLost ThreerdPartyProcessing
        {
            get 
            {
                if (threerdPartyProcessing == null)
                {
                    threerdPartyProcessing = new ReasonLost("3rd party processing");
                    threerdPartyProcessing.Description = "Estimated loss of production due to 3rd party processing.";
                }
                return threerdPartyProcessing;
            }
        }

        private static ReasonLost dailyTotalLossOfProd;
        /// <summary>
        /// Estimated total loss of production.
        /// </summary>
        [EnumValueNameAttribute("daily total loss of prod")]
        public static ReasonLost DailyTotalLossOfProd
        {
            get 
            {
                if (dailyTotalLossOfProd == null)
                {
                    dailyTotalLossOfProd = new ReasonLost("daily total loss of prod");
                    dailyTotalLossOfProd.Description = "Estimated total loss of production.";
                }
                return dailyTotalLossOfProd;
            }
        }

        private static ReasonLost wellProblems;
        /// <summary>
        /// Estimated loss of production due well problems.
        /// </summary>
        [EnumValueNameAttribute("well problems")]
        public static ReasonLost WellProblems
        {
            get 
            {
                if (wellProblems == null)
                {
                    wellProblems = new ReasonLost("well problems");
                    wellProblems.Description = "Estimated loss of production due well problems.";
                }
                return wellProblems;
            }
        }

        private static ReasonLost unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReasonLost Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReasonLost("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// A single block valve.
    /// </summary>
    public class ReportingFacility : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReportingFacility(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReportingFacility</param>
        public ReportingFacility(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReportingFacilitys
        /// </summary>
        /// <returns>The complete list of ReportingFacilitys</returns>
        public static List<ReportingFacility> GetList()
        {
            return GetList<ReportingFacility>();
        }

        private static ReportingFacility blockValve;
        /// <summary>
        /// A single block valve.
        /// </summary>
        [EnumValueNameAttribute("block valve")]
        public static ReportingFacility BlockValve
        {
            get 
            {
                if (blockValve == null)
                {
                    blockValve = new ReportingFacility("block valve");
                    blockValve.Description = "A single block valve.";
                }
                return blockValve;
            }
        }

        private static ReportingFacility bottomhole;
        /// <summary>
        /// A single bottomhole.
        /// </summary>
        [EnumValueNameAttribute("bottomhole")]
        public static ReportingFacility Bottomhole
        {
            get 
            {
                if (bottomhole == null)
                {
                    bottomhole = new ReportingFacility("bottomhole");
                    bottomhole.Description = "A single bottomhole.";
                }
                return bottomhole;
            }
        }

        private static ReportingFacility choke;
        /// <summary>
        /// A single choke.
        /// </summary>
        [EnumValueNameAttribute("choke")]
        public static ReportingFacility Choke
        {
            get 
            {
                if (choke == null)
                {
                    choke = new ReportingFacility("choke");
                    choke.Description = "A single choke.";
                }
                return choke;
            }
        }

        private static ReportingFacility cluster;
        /// <summary>
        /// A single cluster.
        /// </summary>
        [EnumValueNameAttribute("cluster")]
        public static ReportingFacility Cluster
        {
            get 
            {
                if (cluster == null)
                {
                    cluster = new ReportingFacility("cluster");
                    cluster.Description = "A single cluster.";
                }
                return cluster;
            }
        }

        private static ReportingFacility commercialEntity;
        /// <summary>
        /// A commercial entity is an organisational construct through which the a group of organisations or facilities are grouped as if it were a single composite. 
        /// </summary>
        [EnumValueNameAttribute("commercial entity")]
        public static ReportingFacility CommercialEntity
        {
            get 
            {
                if (commercialEntity == null)
                {
                    commercialEntity = new ReportingFacility("commercial entity");
                    commercialEntity.Description = "A commercial entity is an organisational construct through which the a group of organisations or facilities are grouped as if it were a single composite. ";
                }
                return commercialEntity;
            }
        }

        private static ReportingFacility company;
        /// <summary>
        /// A company name that is the name of the operator company.
        /// </summary>
        [EnumValueNameAttribute("company")]
        public static ReportingFacility Company
        {
            get 
            {
                if (company == null)
                {
                    company = new ReportingFacility("company");
                    company.Description = "A company name that is the name of the operator company.";
                }
                return company;
            }
        }

        private static ReportingFacility completion;
        /// <summary>
        /// A single completion.
        /// </summary>
        [EnumValueNameAttribute("completion")]
        public static ReportingFacility Completion
        {
            get 
            {
                if (completion == null)
                {
                    completion = new ReportingFacility("completion");
                    completion.Description = "A single completion.";
                }
                return completion;
            }
        }

        private static ReportingFacility compressor;
        /// <summary>
        /// A single compressor.
        /// </summary>
        [EnumValueNameAttribute("compressor")]
        public static ReportingFacility Compressor
        {
            get 
            {
                if (compressor == null)
                {
                    compressor = new ReportingFacility("compressor");
                    compressor.Description = "A single compressor.";
                }
                return compressor;
            }
        }

        private static ReportingFacility controller;
        /// <summary>
        /// A single lift gas controller.
        /// </summary>
        [EnumValueNameAttribute("controller")]
        public static ReportingFacility Controller
        {
            get 
            {
                if (controller == null)
                {
                    controller = new ReportingFacility("controller");
                    controller.Description = "A single lift gas controller.";
                }
                return controller;
            }
        }

        private static ReportingFacility controllerLift;
        /// <summary>
        /// DEPRECATED: use "controller" instead.
        /// </summary>
        [EnumValueNameAttribute("controller -- lift")]
        public static ReportingFacility ControllerLift
        {
            get 
            {
                if (controllerLift == null)
                {
                    controllerLift = new ReportingFacility("controller -- lift");
                    controllerLift.Description = "DEPRECATED: use \"controller\" instead.";
                }
                return controllerLift;
            }
        }

        private static ReportingFacility county;
        /// <summary>
        /// A single county.
        /// </summary>
        [EnumValueNameAttribute("county")]
        public static ReportingFacility County
        {
            get 
            {
                if (county == null)
                {
                    county = new ReportingFacility("county");
                    county.Description = "A single county.";
                }
                return county;
            }
        }

        private static ReportingFacility country;
        /// <summary>
        /// A single country.
        /// </summary>
        [EnumValueNameAttribute("country")]
        public static ReportingFacility Country
        {
            get 
            {
                if (country == null)
                {
                    country = new ReportingFacility("country");
                    country.Description = "A single country.";
                }
                return country;
            }
        }

        private static ReportingFacility field;
        /// <summary>
        /// A single field.
        /// </summary>
        [EnumValueNameAttribute("field")]
        public static ReportingFacility Field
        {
            get 
            {
                if (field == null)
                {
                    field = new ReportingFacility("field");
                    field.Description = "A single field.";
                }
                return field;
            }
        }

        private static ReportingFacility fieldArea;
        /// <summary>
        /// A ground that is an area above an oilfield.
        /// </summary>
        [EnumValueNameAttribute("field - area")]
        public static ReportingFacility FieldArea
        {
            get 
            {
                if (fieldArea == null)
                {
                    fieldArea = new ReportingFacility("field - area");
                    fieldArea.Description = "A ground that is an area above an oilfield.";
                }
                return fieldArea;
            }
        }

        private static ReportingFacility fieldGroup;
        /// <summary>
        /// An area concept that is a grouping of two or more selcted petroleum fields for commercial reasons or other purposes.
        /// </summary>
        [EnumValueNameAttribute("field - group")]
        public static ReportingFacility FieldGroup
        {
            get 
            {
                if (fieldGroup == null)
                {
                    fieldGroup = new ReportingFacility("field - group");
                    fieldGroup.Description = "An area concept that is a grouping of two or more selcted petroleum fields for commercial reasons or other purposes.";
                }
                return fieldGroup;
            }
        }

        private static ReportingFacility fieldPart;
        /// <summary>
        /// An area concept that is an area that forms part of a petroleum field.
        /// </summary>
        [EnumValueNameAttribute("field - part")]
        public static ReportingFacility FieldPart
        {
            get 
            {
                if (fieldPart == null)
                {
                    fieldPart = new ReportingFacility("field - part");
                    fieldPart.Description = "An area concept that is an area that forms part of a petroleum field.";
                }
                return fieldPart;
            }
        }

        private static ReportingFacility flowline;
        /// <summary>
        /// A single flowline.
        /// </summary>
        [EnumValueNameAttribute("flowline")]
        public static ReportingFacility Flowline
        {
            get 
            {
                if (flowline == null)
                {
                    flowline = new ReportingFacility("flowline");
                    flowline.Description = "A single flowline.";
                }
                return flowline;
            }
        }

        private static ReportingFacility flowMeter;
        /// <summary>
        /// A single flow meter.
        /// </summary>
        [EnumValueNameAttribute("flow meter")]
        public static ReportingFacility FlowMeter
        {
            get 
            {
                if (flowMeter == null)
                {
                    flowMeter = new ReportingFacility("flow meter");
                    flowMeter.Description = "A single flow meter.";
                }
                return flowMeter;
            }
        }

        private static ReportingFacility formation;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("formation")]
        public static ReportingFacility Formation
        {
            get 
            {
                if (formation == null)
                {
                    formation = new ReportingFacility("formation");
                    formation.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return formation;
            }
        }

        private static ReportingFacility generator;
        /// <summary>
        /// A single electrical generator.
        /// </summary>
        [EnumValueNameAttribute("generator")]
        public static ReportingFacility Generator
        {
            get 
            {
                if (generator == null)
                {
                    generator = new ReportingFacility("generator");
                    generator.Description = "A single electrical generator.";
                }
                return generator;
            }
        }

        private static ReportingFacility installation;
        /// <summary>
        /// A physical object that is an appliance involved in the extraction, production, transportation or storage of oil or gas.
        /// </summary>
        [EnumValueNameAttribute("installation")]
        public static ReportingFacility Installation
        {
            get 
            {
                if (installation == null)
                {
                    installation = new ReportingFacility("installation");
                    installation.Description = "A physical object that is an appliance involved in the extraction, production, transportation or storage of oil or gas.";
                }
                return installation;
            }
        }

        private static ReportingFacility lease;
        /// <summary>
        /// A single lease.
        /// </summary>
        [EnumValueNameAttribute("lease")]
        public static ReportingFacility Lease
        {
            get 
            {
                if (lease == null)
                {
                    lease = new ReportingFacility("lease");
                    lease.Description = "A single lease.";
                }
                return lease;
            }
        }

        private static ReportingFacility license;
        /// <summary>
        /// A regulatory agreement that gives the licensees excluding rights to investigate, explore and recover petroleum deposits within the geographical area and timeperiode stated in the agreement.
        /// </summary>
        [EnumValueNameAttribute("license")]
        public static ReportingFacility License
        {
            get 
            {
                if (license == null)
                {
                    license = new ReportingFacility("license");
                    license.Description = "A regulatory agreement that gives the licensees excluding rights to investigate, explore and recover petroleum deposits within the geographical area and timeperiode stated in the agreement.";
                }
                return license;
            }
        }

        private static ReportingFacility manifold;
        /// <summary>
        /// A single manifold.
        /// </summary>
        [EnumValueNameAttribute("manifold")]
        public static ReportingFacility Manifold
        {
            get 
            {
                if (manifold == null)
                {
                    manifold = new ReportingFacility("manifold");
                    manifold.Description = "A single manifold.";
                }
                return manifold;
            }
        }

        private static ReportingFacility pipeline;
        /// <summary>
        /// A fluid conductor that consists of pipe, possibly also including pumps, valves, and control devices, intended for conveying liquids, gases, or finely divided solids.
        /// </summary>
        [EnumValueNameAttribute("pipeline")]
        public static ReportingFacility Pipeline
        {
            get 
            {
                if (pipeline == null)
                {
                    pipeline = new ReportingFacility("pipeline");
                    pipeline.Description = "A fluid conductor that consists of pipe, possibly also including pumps, valves, and control devices, intended for conveying liquids, gases, or finely divided solids.";
                }
                return pipeline;
            }
        }

        private static ReportingFacility plantProcessing;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("plant - processing")]
        public static ReportingFacility PlantProcessing
        {
            get 
            {
                if (plantProcessing == null)
                {
                    plantProcessing = new ReportingFacility("plant - processing");
                    plantProcessing.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return plantProcessing;
            }
        }

        private static ReportingFacility platform;
        /// <summary>
        /// A single platform.
        /// </summary>
        [EnumValueNameAttribute("platform")]
        public static ReportingFacility Platform
        {
            get 
            {
                if (platform == null)
                {
                    platform = new ReportingFacility("platform");
                    platform.Description = "A single platform.";
                }
                return platform;
            }
        }

        private static ReportingFacility pressureMeter;
        /// <summary>
        /// A single pressure meter. Note that this represents the device and not the sensor itself.
        /// </summary>
        [EnumValueNameAttribute("pressure meter")]
        public static ReportingFacility PressureMeter
        {
            get 
            {
                if (pressureMeter == null)
                {
                    pressureMeter = new ReportingFacility("pressure meter");
                    pressureMeter.Description = "A single pressure meter. Note that this represents the device and not the sensor itself.";
                }
                return pressureMeter;
            }
        }

        private static ReportingFacility pump;
        /// <summary>
        /// A single pump.
        /// </summary>
        [EnumValueNameAttribute("pump")]
        public static ReportingFacility Pump
        {
            get 
            {
                if (pump == null)
                {
                    pump = new ReportingFacility("pump");
                    pump.Description = "A single pump.";
                }
                return pump;
            }
        }

        private static ReportingFacility processingFacility;
        /// <summary>
        /// A single production processing facility.
        /// </summary>
        [EnumValueNameAttribute("processing facility")]
        public static ReportingFacility ProcessingFacility
        {
            get 
            {
                if (processingFacility == null)
                {
                    processingFacility = new ReportingFacility("processing facility");
                    processingFacility.Description = "A single production processing facility.";
                }
                return processingFacility;
            }
        }

        private static ReportingFacility regulatingValve;
        /// <summary>
        /// A single regulating valve.
        /// </summary>
        [EnumValueNameAttribute("regulating valve")]
        public static ReportingFacility RegulatingValve
        {
            get 
            {
                if (regulatingValve == null)
                {
                    regulatingValve = new ReportingFacility("regulating valve");
                    regulatingValve.Description = "A single regulating valve.";
                }
                return regulatingValve;
            }
        }

        private static ReportingFacility reservoir;
        /// <summary>
        /// A single reservoir.
        /// </summary>
        [EnumValueNameAttribute("reservoir")]
        public static ReportingFacility Reservoir
        {
            get 
            {
                if (reservoir == null)
                {
                    reservoir = new ReportingFacility("reservoir");
                    reservoir.Description = "A single reservoir.";
                }
                return reservoir;
            }
        }

        private static ReportingFacility separator;
        /// <summary>
        /// A single separator.
        /// </summary>
        [EnumValueNameAttribute("separator")]
        public static ReportingFacility Separator
        {
            get 
            {
                if (separator == null)
                {
                    separator = new ReportingFacility("separator");
                    separator.Description = "A single separator.";
                }
                return separator;
            }
        }

        private static ReportingFacility sleeveValve;
        /// <summary>
        /// A single sleeve valve. This is a type of tubing valve which has a sliding sleeve to cover holes in the tubing. You cover all of the holes in order to close the valve. For configurations oriented toward production, the inlet is on the casing side and the outlet is on the tubing side. For injection, the reverse would be true.
        /// </summary>
        [EnumValueNameAttribute("sleeve valve")]
        public static ReportingFacility SleeveValve
        {
            get 
            {
                if (sleeveValve == null)
                {
                    sleeveValve = new ReportingFacility("sleeve valve");
                    sleeveValve.Description = "A single sleeve valve. This is a type of tubing valve which has a sliding sleeve to cover holes in the tubing. You cover all of the holes in order to close the valve. For configurations oriented toward production, the inlet is on the casing side and the outlet is on the tubing side. For injection, the reverse would be true.";
                }
                return sleeveValve;
            }
        }

        private static ReportingFacility state;
        /// <summary>
        /// A single state or province.
        /// </summary>
        [EnumValueNameAttribute("state")]
        public static ReportingFacility State
        {
            get 
            {
                if (state == null)
                {
                    state = new ReportingFacility("state");
                    state.Description = "A single state or province.";
                }
                return state;
            }
        }

        private static ReportingFacility storage;
        /// <summary>
        /// A system for the storage of gaseous, liquid and solid products.
        /// </summary>
        [EnumValueNameAttribute("storage")]
        public static ReportingFacility Storage
        {
            get 
            {
                if (storage == null)
                {
                    storage = new ReportingFacility("storage");
                    storage.Description = "A system for the storage of gaseous, liquid and solid products.";
                }
                return storage;
            }
        }

        private static ReportingFacility tank;
        /// <summary>
        /// A single tank.
        /// </summary>
        [EnumValueNameAttribute("tank")]
        public static ReportingFacility Tank
        {
            get 
            {
                if (tank == null)
                {
                    tank = new ReportingFacility("tank");
                    tank.Description = "A single tank.";
                }
                return tank;
            }
        }

        private static ReportingFacility temperatureMeter;
        /// <summary>
        /// A single temperature meter. Note that this represents the device and not the sensor itself.
        /// </summary>
        [EnumValueNameAttribute("temperature meter")]
        public static ReportingFacility TemperatureMeter
        {
            get 
            {
                if (temperatureMeter == null)
                {
                    temperatureMeter = new ReportingFacility("temperature meter");
                    temperatureMeter.Description = "A single temperature meter. Note that this represents the device and not the sensor itself.";
                }
                return temperatureMeter;
            }
        }

        private static ReportingFacility template;
        /// <summary>
        /// A single template.
        /// </summary>
        [EnumValueNameAttribute("template")]
        public static ReportingFacility Template
        {
            get 
            {
                if (template == null)
                {
                    template = new ReportingFacility("template");
                    template.Description = "A single template.";
                }
                return template;
            }
        }

        private static ReportingFacility terminal;
        /// <summary>
        /// A physical object that is an industrial facility for the storage of oil and/or petrochemical products and from which these products are usually transported to end users or further storage facilities. 
        /// </summary>
        [EnumValueNameAttribute("terminal")]
        public static ReportingFacility Terminal
        {
            get 
            {
                if (terminal == null)
                {
                    terminal = new ReportingFacility("terminal");
                    terminal.Description = "A physical object that is an industrial facility for the storage of oil and/or petrochemical products and from which these products are usually transported to end users or further storage facilities. ";
                }
                return terminal;
            }
        }

        private static ReportingFacility trunkline;
        /// <summary>
        /// A single trunkline.
        /// </summary>
        [EnumValueNameAttribute("trunkline")]
        public static ReportingFacility Trunkline
        {
            get 
            {
                if (trunkline == null)
                {
                    trunkline = new ReportingFacility("trunkline");
                    trunkline.Description = "A single trunkline.";
                }
                return trunkline;
            }
        }

        private static ReportingFacility tubingHead;
        /// <summary>
        /// A single tubing head within a wellhead.
        /// </summary>
        [EnumValueNameAttribute("tubing head")]
        public static ReportingFacility TubingHead
        {
            get 
            {
                if (tubingHead == null)
                {
                    tubingHead = new ReportingFacility("tubing head");
                    tubingHead.Description = "A single tubing head within a wellhead.";
                }
                return tubingHead;
            }
        }

        private static ReportingFacility turbine;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("turbine")]
        public static ReportingFacility Turbine
        {
            get 
            {
                if (turbine == null)
                {
                    turbine = new ReportingFacility("turbine");
                    turbine.Description = "xxxxxxxxxxxxxxxxxxxxxxx";
                }
                return turbine;
            }
        }

        private static ReportingFacility wellGroup;
        /// <summary>
        /// A single named group of wells.
        /// </summary>
        [EnumValueNameAttribute("well group")]
        public static ReportingFacility WellGroup
        {
            get 
            {
                if (wellGroup == null)
                {
                    wellGroup = new ReportingFacility("well group");
                    wellGroup.Description = "A single named group of wells.";
                }
                return wellGroup;
            }
        }

        private static ReportingFacility well;
        /// <summary>
        /// A single well, possibly with many wellbores (sidetracks).
        /// </summary>
        [EnumValueNameAttribute("well")]
        public static ReportingFacility Well
        {
            get 
            {
                if (well == null)
                {
                    well = new ReportingFacility("well");
                    well.Description = "A single well, possibly with many wellbores (sidetracks).";
                }
                return well;
            }
        }

        private static ReportingFacility wellbore;
        /// <summary>
        /// A single wellbore (sidetrack) within a well.
        /// </summary>
        [EnumValueNameAttribute("wellbore")]
        public static ReportingFacility Wellbore
        {
            get 
            {
                if (wellbore == null)
                {
                    wellbore = new ReportingFacility("wellbore");
                    wellbore.Description = "A single wellbore (sidetrack) within a well.";
                }
                return wellbore;
            }
        }

        private static ReportingFacility wellhead;
        /// <summary>
        /// A single wellhead for one well. See also "tubing head".
        /// </summary>
        [EnumValueNameAttribute("wellhead")]
        public static ReportingFacility Wellhead
        {
            get 
            {
                if (wellhead == null)
                {
                    wellhead = new ReportingFacility("wellhead");
                    wellhead.Description = "A single wellhead for one well. See also \"tubing head\".";
                }
                return wellhead;
            }
        }

        private static ReportingFacility zone;
        /// <summary>
        /// A single zone.
        /// </summary>
        [EnumValueNameAttribute("zone")]
        public static ReportingFacility Zone
        {
            get 
            {
                if (zone == null)
                {
                    zone = new ReportingFacility("zone");
                    zone.Description = "A single zone.";
                }
                return zone;
            }
        }

        private static ReportingFacility unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingFacility Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReportingFacility("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Defines the types of flows for volume reports.
    /// </summary>
    public class ReportingFlow : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReportingFlow(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReportingFlow</param>
        public ReportingFlow(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReportingFlows
        /// </summary>
        /// <returns>The complete list of ReportingFlows</returns>
        public static List<ReportingFlow> GetList()
        {
            return GetList<ReportingFlow>();
        }

        private static ReportingFlow consume;
        /// <summary>
        /// Consumed (all methods) by the facility.
        /// </summary>
        [EnumValueNameAttribute("consume")]
        public static ReportingFlow Consume
        {
            get 
            {
                if (consume == null)
                {
                    consume = new ReportingFlow("consume");
                    consume.Description = "Consumed (all methods) by the facility.";
                }
                return consume;
            }
        }

        private static ReportingFlow consumeBlackStart;
        /// <summary>
        /// Consummed to restart power facilities as a result of an overall power outage.
        /// </summary>
        [EnumValueNameAttribute("consume - black start")]
        public static ReportingFlow ConsumeBlackStart
        {
            get 
            {
                if (consumeBlackStart == null)
                {
                    consumeBlackStart = new ReportingFlow("consume - black start");
                    consumeBlackStart.Description = "Consummed to restart power facilities as a result of an overall power outage.";
                }
                return consumeBlackStart;
            }
        }

        private static ReportingFlow consumeCompressor;
        /// <summary>
        /// Consummed by compressors.
        /// </summary>
        [EnumValueNameAttribute("consume - compressor")]
        public static ReportingFlow ConsumeCompressor
        {
            get 
            {
                if (consumeCompressor == null)
                {
                    consumeCompressor = new ReportingFlow("consume - compressor");
                    consumeCompressor.Description = "Consummed by compressors.";
                }
                return consumeCompressor;
            }
        }

        private static ReportingFlow consumeNonCompressor;
        /// <summary>
        /// Consumed by devices other than compressors.
        /// </summary>
        [EnumValueNameAttribute("consume - non compressor")]
        public static ReportingFlow ConsumeNonCompressor
        {
            get 
            {
                if (consumeNonCompressor == null)
                {
                    consumeNonCompressor = new ReportingFlow("consume - non compressor");
                    consumeNonCompressor.Description = "Consumed by devices other than compressors.";
                }
                return consumeNonCompressor;
            }
        }

        private static ReportingFlow consumeEmitted;
        /// <summary>
        /// Released into the atmosphere as a by-product of consumption.
        /// </summary>
        [EnumValueNameAttribute("consume - emitted")]
        public static ReportingFlow ConsumeEmitted
        {
            get 
            {
                if (consumeEmitted == null)
                {
                    consumeEmitted = new ReportingFlow("consume - emitted");
                    consumeEmitted.Description = "Released into the atmosphere as a by-product of consumption.";
                }
                return consumeEmitted;
            }
        }

        private static ReportingFlow consumeFlare;
        /// <summary>
        /// Burned in a flare. A fluid stream that has one or more flares as the ultimate target.
        /// </summary>
        [EnumValueNameAttribute("consume - flare")]
        public static ReportingFlow ConsumeFlare
        {
            get 
            {
                if (consumeFlare == null)
                {
                    consumeFlare = new ReportingFlow("consume - flare");
                    consumeFlare.Description = "Burned in a flare. A fluid stream that has one or more flares as the ultimate target.";
                }
                return consumeFlare;
            }
        }

        private static ReportingFlow consumeHpFlare;
        /// <summary>
        /// Burned in a high pressure flare.
        /// </summary>
        [EnumValueNameAttribute("consume - HP flare")]
        public static ReportingFlow ConsumeHpFlare
        {
            get 
            {
                if (consumeHpFlare == null)
                {
                    consumeHpFlare = new ReportingFlow("consume - HP flare");
                    consumeHpFlare.Description = "Burned in a high pressure flare.";
                }
                return consumeHpFlare;
            }
        }

        private static ReportingFlow consumeLpFlare;
        /// <summary>
        /// Burned in a low pressure flare.
        /// </summary>
        [EnumValueNameAttribute("consume - LP flare")]
        public static ReportingFlow ConsumeLpFlare
        {
            get 
            {
                if (consumeLpFlare == null)
                {
                    consumeLpFlare = new ReportingFlow("consume - LP flare");
                    consumeLpFlare.Description = "Burned in a low pressure flare.";
                }
                return consumeLpFlare;
            }
        }

        private static ReportingFlow consumeFuel;
        /// <summary>
        /// Consumed by processing equipment.
        /// </summary>
        [EnumValueNameAttribute("consume - fuel")]
        public static ReportingFlow ConsumeFuel
        {
            get 
            {
                if (consumeFuel == null)
                {
                    consumeFuel = new ReportingFlow("consume - fuel");
                    consumeFuel.Description = "Consumed by processing equipment.";
                }
                return consumeFuel;
            }
        }

        private static ReportingFlow consumeVenting;
        /// <summary>
        /// Released into the atmosphere.
        /// </summary>
        [EnumValueNameAttribute("consume - venting")]
        public static ReportingFlow ConsumeVenting
        {
            get 
            {
                if (consumeVenting == null)
                {
                    consumeVenting = new ReportingFlow("consume - venting");
                    consumeVenting.Description = "Released into the atmosphere.";
                }
                return consumeVenting;
            }
        }

        private static ReportingFlow disposal;
        /// <summary>
        /// A fluid stream that contains waste fluids for disposal.
        /// </summary>
        [EnumValueNameAttribute("disposal")]
        public static ReportingFlow Disposal
        {
            get 
            {
                if (disposal == null)
                {
                    disposal = new ReportingFlow("disposal");
                    disposal.Description = "A fluid stream that contains waste fluids for disposal.";
                }
                return disposal;
            }
        }

        private static ReportingFlow export;
        /// <summary>
        /// Leaving the installation for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("export")]
        public static ReportingFlow Export
        {
            get 
            {
                if (export == null)
                {
                    export = new ReportingFlow("export");
                    export.Description = "Leaving the installation for commercialized purposes.";
                }
                return export;
            }
        }

        private static ReportingFlow exportRequested;
        /// <summary>
        /// Requested to leave the installation for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("export - requested")]
        public static ReportingFlow ExportRequested
        {
            get 
            {
                if (exportRequested == null)
                {
                    exportRequested = new ReportingFlow("export - requested");
                    exportRequested.Description = "Requested to leave the installation for commercialized purposes.";
                }
                return exportRequested;
            }
        }

        private static ReportingFlow exportNominated;
        /// <summary>
        /// Planned to leave the installation for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("export - nominated")]
        public static ReportingFlow ExportNominated
        {
            get 
            {
                if (exportNominated == null)
                {
                    exportNominated = new ReportingFlow("export - nominated");
                    exportNominated.Description = "Planned to leave the installation for commercialized purposes.";
                }
                return exportNominated;
            }
        }

        private static ReportingFlow exportShortfall;
        /// <summary>
        /// Difference between what was requested and what was delivered.
        /// </summary>
        [EnumValueNameAttribute("export - shortfall")]
        public static ReportingFlow ExportShortfall
        {
            get 
            {
                if (exportShortfall == null)
                {
                    exportShortfall = new ReportingFlow("export - shortfall");
                    exportShortfall.Description = "Difference between what was requested and what was delivered.";
                }
                return exportShortfall;
            }
        }

        private static ReportingFlow gasLift;
        /// <summary>
        /// Injected into a producing well to reduce the hydrostataic pressure of the fluid column. The resulting reduction in bottom hole pressure allows the reservoir liquids to flow.
        /// </summary>
        [EnumValueNameAttribute("gas lift")]
        public static ReportingFlow GasLift
        {
            get 
            {
                if (gasLift == null)
                {
                    gasLift = new ReportingFlow("gas lift");
                    gasLift.Description = "Injected into a producing well to reduce the hydrostataic pressure of the fluid column. The resulting reduction in bottom hole pressure allows the reservoir liquids to flow.";
                }
                return gasLift;
            }
        }

        private static ReportingFlow hydrocarbonAccounting;
        /// <summary>
        /// An accounting of all of the fluids into and out of Stock (i.e., Inventory) which includes all storage facilities at a site including fluid within a pipeline.
        /// </summary>
        [EnumValueNameAttribute("hydrocarbon accounting")]
        public static ReportingFlow HydrocarbonAccounting
        {
            get 
            {
                if (hydrocarbonAccounting == null)
                {
                    hydrocarbonAccounting = new ReportingFlow("hydrocarbon accounting");
                    hydrocarbonAccounting.Description = "An accounting of all of the fluids into and out of Stock (i.e., Inventory) which includes all storage facilities at a site including fluid within a pipeline.";
                }
                return hydrocarbonAccounting;
            }
        }

        private static ReportingFlow import;
        /// <summary>
        /// Entering the facility for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("import")]
        public static ReportingFlow Import
        {
            get 
            {
                if (import == null)
                {
                    import = new ReportingFlow("import");
                    import.Description = "Entering the facility for commercialized purposes.";
                }
                return import;
            }
        }

        private static ReportingFlow injection;
        /// <summary>
        /// Inject into a well.
        /// </summary>
        [EnumValueNameAttribute("injection")]
        public static ReportingFlow Injection
        {
            get 
            {
                if (injection == null)
                {
                    injection = new ReportingFlow("injection");
                    injection.Description = "Inject into a well.";
                }
                return injection;
            }
        }

        private static ReportingFlow inventory;
        /// <summary>
        /// Stock at a facility. For a period that represents an event, the amount would represent the current amount of inventory. For other periods, the amount would represent the addition (positive value) or drawdown (negative value) over that period. For an individual storage facility (e.g., a tank), the amounts would represent that tank. For an overall facility, the amounts would represent all tanks.
        /// </summary>
        [EnumValueNameAttribute("inventory")]
        public static ReportingFlow Inventory
        {
            get 
            {
                if (inventory == null)
                {
                    inventory = new ReportingFlow("inventory");
                    inventory.Description = "Stock at a facility. For a period that represents an event, the amount would represent the current amount of inventory. For other periods, the amount would represent the addition (positive value) or drawdown (negative value) over that period. For an individual storage facility (e.g., a tank), the amounts would represent that tank. For an overall facility, the amounts would represent all tanks.";
                }
                return inventory;
            }
        }

        private static ReportingFlow overboard;
        /// <summary>
        /// Dropped overboard into the sea.
        /// </summary>
        [EnumValueNameAttribute("overboard")]
        public static ReportingFlow Overboard
        {
            get 
            {
                if (overboard == null)
                {
                    overboard = new ReportingFlow("overboard");
                    overboard.Description = "Dropped overboard into the sea.";
                }
                return overboard;
            }
        }

        private static ReportingFlow production;
        /// <summary>
        /// Exploited from a reservoir. This is independent of any disposition.
        /// </summary>
        [EnumValueNameAttribute("production")]
        public static ReportingFlow Production
        {
            get 
            {
                if (production == null)
                {
                    production = new ReportingFlow("production");
                    production.Description = "Exploited from a reservoir. This is independent of any disposition.";
                }
                return production;
            }
        }

        private static ReportingFlow sale;
        /// <summary>
        /// A fluid stream that is sold and transported to a buyer by pipeline.
        /// </summary>
        [EnumValueNameAttribute("sale")]
        public static ReportingFlow Sale
        {
            get 
            {
                if (sale == null)
                {
                    sale = new ReportingFlow("sale");
                    sale.Description = "A fluid stream that is sold and transported to a buyer by pipeline.";
                }
                return sale;
            }
        }

        private static ReportingFlow storage;
        /// <summary>
        /// A fluid stream that is directed to one or more storage locations.
        /// </summary>
        [EnumValueNameAttribute("storage")]
        public static ReportingFlow Storage
        {
            get 
            {
                if (storage == null)
                {
                    storage = new ReportingFlow("storage");
                    storage.Description = "A fluid stream that is directed to one or more storage locations.";
                }
                return storage;
            }
        }

        private static ReportingFlow unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingFlow Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReportingFlow("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// A period of one day. 
    ///			If the report does not represent one day then this represents the 
    ///			24 hour period ending at the end of the report period.
    /// </summary>
    public class ReportingPeriod : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReportingPeriod(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReportingPeriod</param>
        public ReportingPeriod(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReportingPeriods
        /// </summary>
        /// <returns>The complete list of ReportingPeriods</returns>
        public static List<ReportingPeriod> GetList()
        {
            return GetList<ReportingPeriod>();
        }

        private static ReportingPeriod day;
        /// <summary>
        /// A period of one day. If the report does not represent one day then this represents the 24 hour period ending at the end of the report period.
        /// </summary>
        [EnumValueNameAttribute("day")]
        public static ReportingPeriod Day
        {
            get 
            {
                if (day == null)
                {
                    day = new ReportingPeriod("day");
                    day.Description = "A period of one day. If the report does not represent one day then this represents the 24 hour period ending at the end of the report period.";
                }
                return day;
            }
        }

        private static ReportingPeriod week;
        /// <summary>
        /// A period of one week. If the report does not represent one week then this represents the 7 times 24 hour period ending at the end of the report period.
        /// </summary>
        [EnumValueNameAttribute("week")]
        public static ReportingPeriod Week
        {
            get 
            {
                if (week == null)
                {
                    week = new ReportingPeriod("week");
                    week.Description = "A period of one week. If the report does not represent one week then this represents the 7 times 24 hour period ending at the end of the report period.";
                }
                return week;
            }
        }

        private static ReportingPeriod month;
        /// <summary>
        /// A period of one calendar month.
        /// </summary>
        [EnumValueNameAttribute("month")]
        public static ReportingPeriod Month
        {
            get 
            {
                if (month == null)
                {
                    month = new ReportingPeriod("month");
                    month.Description = "A period of one calendar month.";
                }
                return month;
            }
        }

        private static ReportingPeriod year;
        /// <summary>
        /// A period of one gregorian year.
        /// </summary>
        [EnumValueNameAttribute("year")]
        public static ReportingPeriod Year
        {
            get 
            {
                if (year == null)
                {
                    year = new ReportingPeriod("year");
                    year.Description = "A period of one gregorian year.";
                }
                return year;
            }
        }

        private static ReportingPeriod yearToDate;
        /// <summary>
        /// A period from the beginning of the year to the end of the report period.
        /// </summary>
        [EnumValueNameAttribute("year to date")]
        public static ReportingPeriod YearToDate
        {
            get 
            {
                if (yearToDate == null)
                {
                    yearToDate = new ReportingPeriod("year to date");
                    yearToDate.Description = "A period from the beginning of the year to the end of the report period.";
                }
                return yearToDate;
            }
        }

        private static ReportingPeriod monthToDate;
        /// <summary>
        /// A period from the beginning of the calendar month to the end of the report period.
        /// </summary>
        [EnumValueNameAttribute("month to date")]
        public static ReportingPeriod MonthToDate
        {
            get 
            {
                if (monthToDate == null)
                {
                    monthToDate = new ReportingPeriod("month to date");
                    monthToDate.Description = "A period from the beginning of the calendar month to the end of the report period.";
                }
                return monthToDate;
            }
        }

        private static ReportingPeriod dailyYearToDate;
        /// <summary>
        /// The average per day over the period from the beginning of the year to the end of the report period
        /// </summary>
        [EnumValueNameAttribute("daily year to date")]
        public static ReportingPeriod DailyYearToDate
        {
            get 
            {
                if (dailyYearToDate == null)
                {
                    dailyYearToDate = new ReportingPeriod("daily year to date");
                    dailyYearToDate.Description = "The average per day over the period from the beginning of the year to the end of the report period";
                }
                return dailyYearToDate;
            }
        }

        private static ReportingPeriod dailyMonthToDate;
        /// <summary>
        /// The average per day over the period from the beginning of the month to the end of the report period
        /// </summary>
        [EnumValueNameAttribute("daily month to date")]
        public static ReportingPeriod DailyMonthToDate
        {
            get 
            {
                if (dailyMonthToDate == null)
                {
                    dailyMonthToDate = new ReportingPeriod("daily month to date");
                    dailyMonthToDate.Description = "The average per day over the period from the beginning of the month to the end of the report period";
                }
                return dailyMonthToDate;
            }
        }

        private static ReportingPeriod totalCumulative;
        /// <summary>
        /// A period with no beginning that ends at the end of the report period.
        /// </summary>
        [EnumValueNameAttribute("total cumulative")]
        public static ReportingPeriod TotalCumulative
        {
            get 
            {
                if (totalCumulative == null)
                {
                    totalCumulative = new ReportingPeriod("total cumulative");
                    totalCumulative.Description = "A period with no beginning that ends at the end of the report period.";
                }
                return totalCumulative;
            }
        }

        private static ReportingPeriod report;
        /// <summary>
        /// A period coinciding with the report period.
        /// </summary>
        [EnumValueNameAttribute("report")]
        public static ReportingPeriod Report
        {
            get 
            {
                if (report == null)
                {
                    report = new ReportingPeriod("report");
                    report.Description = "A period coinciding with the report period.";
                }
                return report;
            }
        }

        private static ReportingPeriod reportStart;
        /// <summary>
        /// A point in time coinciding with the start of report period.
        /// </summary>
        [EnumValueNameAttribute("report start")]
        public static ReportingPeriod ReportStart
        {
            get 
            {
                if (reportStart == null)
                {
                    reportStart = new ReportingPeriod("report start");
                    reportStart.Description = "A point in time coinciding with the start of report period.";
                }
                return reportStart;
            }
        }

        private static ReportingPeriod reportEnd;
        /// <summary>
        /// A point in time coinciding with the end of report period.
        /// </summary>
        [EnumValueNameAttribute("report end")]
        public static ReportingPeriod ReportEnd
        {
            get 
            {
                if (reportEnd == null)
                {
                    reportEnd = new ReportingPeriod("report end");
                    reportEnd.Description = "A point in time coinciding with the end of report period.";
                }
                return reportEnd;
            }
        }

        private static ReportingPeriod previousPeriod;
        /// <summary>
        /// The previous reporting period. For example, if the report period represents a day then the previous period represents the previous day.
        /// </summary>
        [EnumValueNameAttribute("previous period")]
        public static ReportingPeriod PreviousPeriod
        {
            get 
            {
                if (previousPeriod == null)
                {
                    previousPeriod = new ReportingPeriod("previous period");
                    previousPeriod.Description = "The previous reporting period. For example, if the report period represents a day then the previous period represents the previous day.";
                }
                return previousPeriod;
            }
        }

        private static ReportingPeriod midnight;
        /// <summary>
        /// A point in time coinciding with midnight during the report period. This can be ambiguous if the report begins and ends at midnight - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours.
        /// </summary>
        [EnumValueNameAttribute("midnight")]
        public static ReportingPeriod Midnight
        {
            get 
            {
                if (midnight == null)
                {
                    midnight = new ReportingPeriod("midnight");
                    midnight.Description = "A point in time coinciding with midnight during the report period. This can be ambiguous if the report begins and ends at midnight - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours.";
                }
                return midnight;
            }
        }

        private static ReportingPeriod noon;
        /// <summary>
        /// A point in time coinciding with noon during the report period. This can be ambiguous if the report begins and ends at noon - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours.
        /// </summary>
        [EnumValueNameAttribute("noon")]
        public static ReportingPeriod Noon
        {
            get 
            {
                if (noon == null)
                {
                    noon = new ReportingPeriod("noon");
                    noon.Description = "A point in time coinciding with noon during the report period. This can be ambiguous if the report begins and ends at noon - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours.";
                }
                return noon;
            }
        }

        private static ReportingPeriod zeroSixZeroZero;
        /// <summary>
        /// A point in time coinciding with 6 am during the report period. This can be ambiguous if the report begins and ends at 6 am - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours.
        /// </summary>
        [EnumValueNameAttribute("06:00")]
        public static ReportingPeriod ZeroSixZeroZero
        {
            get 
            {
                if (zeroSixZeroZero == null)
                {
                    zeroSixZeroZero = new ReportingPeriod("06:00");
                    zeroSixZeroZero.Description = "A point in time coinciding with 6 am during the report period. This can be ambiguous if the report begins and ends at 6 am - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours.";
                }
                return zeroSixZeroZero;
            }
        }

        private static ReportingPeriod gasDay;
        /// <summary>
        /// A period in time that is all space of time within a day (24 hour period) starting at 06:00 AM and ending 06:00 AM next day.
        /// </summary>
        [EnumValueNameAttribute("gas day")]
        public static ReportingPeriod GasDay
        {
            get 
            {
                if (gasDay == null)
                {
                    gasDay = new ReportingPeriod("gas day");
                    gasDay.Description = "A period in time that is all space of time within a day (24 hour period) starting at 06:00 AM and ending 06:00 AM next day.";
                }
                return gasDay;
            }
        }

        private static ReportingPeriod gasMonth;
        /// <summary>
        /// A period in time that is all space of time within a whole given month starting at 06:00 AM the first day and ending at 06:00 AM the first day of next month.
        /// </summary>
        [EnumValueNameAttribute("gas month")]
        public static ReportingPeriod GasMonth
        {
            get 
            {
                if (gasMonth == null)
                {
                    gasMonth = new ReportingPeriod("gas month");
                    gasMonth.Description = "A period in time that is all space of time within a whole given month starting at 06:00 AM the first day and ending at 06:00 AM the first day of next month.";
                }
                return gasMonth;
            }
        }

        private static ReportingPeriod gasYear;
        /// <summary>
        /// A period in time that is all time within a period starting at 06:00 AM October 1st and ending at same date and time the following year.
        /// </summary>
        [EnumValueNameAttribute("gas year")]
        public static ReportingPeriod GasYear
        {
            get 
            {
                if (gasYear == null)
                {
                    gasYear = new ReportingPeriod("gas year");
                    gasYear.Description = "A period in time that is all time within a period starting at 06:00 AM October 1st and ending at same date and time the following year.";
                }
                return gasYear;
            }
        }

        private static ReportingPeriod gasYearToDate;
        /// <summary>
        /// A period in time that is all space of time within a period starting at 06:00 AM October 1st ending at 06:00 AM at a given date.
        /// </summary>
        [EnumValueNameAttribute("gas year to date")]
        public static ReportingPeriod GasYearToDate
        {
            get 
            {
                if (gasYearToDate == null)
                {
                    gasYearToDate = new ReportingPeriod("gas year to date");
                    gasYearToDate.Description = "A period in time that is all space of time within a period starting at 06:00 AM October 1st ending at 06:00 AM at a given date.";
                }
                return gasYearToDate;
            }
        }

        private static ReportingPeriod lifeToDate;
        /// <summary>
        /// A period in time that is all space of time within a period from starting up an equipment, installation, field, license, etc, to a given date.
        /// </summary>
        [EnumValueNameAttribute("life to date")]
        public static ReportingPeriod LifeToDate
        {
            get 
            {
                if (lifeToDate == null)
                {
                    lifeToDate = new ReportingPeriod("life to date");
                    lifeToDate.Description = "A period in time that is all space of time within a period from starting up an equipment, installation, field, license, etc, to a given date.";
                }
                return lifeToDate;
            }
        }

        private static ReportingPeriod unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingPeriod Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReportingPeriod("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// A product composed of the component with the specified number of carbon 
    ///			atoms plus all heavier components.
    /// </summary>
    public class ReportingProduct : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReportingProduct(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReportingProduct</param>
        public ReportingProduct(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReportingProducts
        /// </summary>
        /// <returns>The complete list of ReportingProducts</returns>
        public static List<ReportingProduct> GetList()
        {
            return GetList<ReportingProduct>();
        }

        private static ReportingProduct cTwoPlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C2+")]
        public static ReportingProduct CTwoPlus
        {
            get 
            {
                if (cTwoPlus == null)
                {
                    cTwoPlus = new ReportingProduct("C2+");
                    cTwoPlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cTwoPlus;
            }
        }

        private static ReportingProduct cThreePlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C3+")]
        public static ReportingProduct CThreePlus
        {
            get 
            {
                if (cThreePlus == null)
                {
                    cThreePlus = new ReportingProduct("C3+");
                    cThreePlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cThreePlus;
            }
        }

        private static ReportingProduct cFourPlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C4+")]
        public static ReportingProduct CFourPlus
        {
            get 
            {
                if (cFourPlus == null)
                {
                    cFourPlus = new ReportingProduct("C4+");
                    cFourPlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cFourPlus;
            }
        }

        private static ReportingProduct cFivePlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C5+")]
        public static ReportingProduct CFivePlus
        {
            get 
            {
                if (cFivePlus == null)
                {
                    cFivePlus = new ReportingProduct("C5+");
                    cFivePlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cFivePlus;
            }
        }

        private static ReportingProduct cSixPlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C6+")]
        public static ReportingProduct CSixPlus
        {
            get 
            {
                if (cSixPlus == null)
                {
                    cSixPlus = new ReportingProduct("C6+");
                    cSixPlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cSixPlus;
            }
        }

        private static ReportingProduct cSevenPlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C7+")]
        public static ReportingProduct CSevenPlus
        {
            get 
            {
                if (cSevenPlus == null)
                {
                    cSevenPlus = new ReportingProduct("C7+");
                    cSevenPlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cSevenPlus;
            }
        }

        private static ReportingProduct cEightPlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C8+")]
        public static ReportingProduct CEightPlus
        {
            get 
            {
                if (cEightPlus == null)
                {
                    cEightPlus = new ReportingProduct("C8+");
                    cEightPlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cEightPlus;
            }
        }

        private static ReportingProduct cNinePlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C9+")]
        public static ReportingProduct CNinePlus
        {
            get 
            {
                if (cNinePlus == null)
                {
                    cNinePlus = new ReportingProduct("C9+");
                    cNinePlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cNinePlus;
            }
        }

        private static ReportingProduct cOneZeroPlus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all heavier components.
        /// </summary>
        [EnumValueNameAttribute("C10+")]
        public static ReportingProduct COneZeroPlus
        {
            get 
            {
                if (cOneZeroPlus == null)
                {
                    cOneZeroPlus = new ReportingProduct("C10+");
                    cOneZeroPlus.Description = "A product composed of the component with the specified number of carbon atoms plus all heavier components.";
                }
                return cOneZeroPlus;
            }
        }

        private static ReportingProduct cTwoMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C2-")]
        public static ReportingProduct CTwoMinus
        {
            get 
            {
                if (cTwoMinus == null)
                {
                    cTwoMinus = new ReportingProduct("C2-");
                    cTwoMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cTwoMinus;
            }
        }

        private static ReportingProduct cThreeMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C3-")]
        public static ReportingProduct CThreeMinus
        {
            get 
            {
                if (cThreeMinus == null)
                {
                    cThreeMinus = new ReportingProduct("C3-");
                    cThreeMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cThreeMinus;
            }
        }

        private static ReportingProduct cFourMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C4-")]
        public static ReportingProduct CFourMinus
        {
            get 
            {
                if (cFourMinus == null)
                {
                    cFourMinus = new ReportingProduct("C4-");
                    cFourMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cFourMinus;
            }
        }

        private static ReportingProduct cFiveMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C5-")]
        public static ReportingProduct CFiveMinus
        {
            get 
            {
                if (cFiveMinus == null)
                {
                    cFiveMinus = new ReportingProduct("C5-");
                    cFiveMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cFiveMinus;
            }
        }

        private static ReportingProduct cSixMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C6-")]
        public static ReportingProduct CSixMinus
        {
            get 
            {
                if (cSixMinus == null)
                {
                    cSixMinus = new ReportingProduct("C6-");
                    cSixMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cSixMinus;
            }
        }

        private static ReportingProduct cSevenMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C7-")]
        public static ReportingProduct CSevenMinus
        {
            get 
            {
                if (cSevenMinus == null)
                {
                    cSevenMinus = new ReportingProduct("C7-");
                    cSevenMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cSevenMinus;
            }
        }

        private static ReportingProduct cEightMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C8-")]
        public static ReportingProduct CEightMinus
        {
            get 
            {
                if (cEightMinus == null)
                {
                    cEightMinus = new ReportingProduct("C8-");
                    cEightMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cEightMinus;
            }
        }

        private static ReportingProduct cNineMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C9-")]
        public static ReportingProduct CNineMinus
        {
            get 
            {
                if (cNineMinus == null)
                {
                    cNineMinus = new ReportingProduct("C9-");
                    cNineMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cNineMinus;
            }
        }

        private static ReportingProduct cOneZeroMinus;
        /// <summary>
        /// A product composed of the component with the specified number of carbon atoms plus all lighter components.
        /// </summary>
        [EnumValueNameAttribute("C10-")]
        public static ReportingProduct COneZeroMinus
        {
            get 
            {
                if (cOneZeroMinus == null)
                {
                    cOneZeroMinus = new ReportingProduct("C10-");
                    cOneZeroMinus.Description = "A product composed of the component with the specified number of carbon atoms plus all lighter components.";
                }
                return cOneZeroMinus;
            }
        }

        private static ReportingProduct oleic;
        /// <summary>
        /// An undifferentiated liquid fluid phase in which the dominant continuous materials are liquid hydrocarbons. This phase is often called the "oil phase".
        /// </summary>
        [EnumValueNameAttribute("oleic")]
        public static ReportingProduct Oleic
        {
            get 
            {
                if (oleic == null)
                {
                    oleic = new ReportingProduct("oleic");
                    oleic.Description = "An undifferentiated liquid fluid phase in which the dominant continuous materials are liquid hydrocarbons. This phase is often called the \"oil phase\".";
                }
                return oleic;
            }
        }

        private static ReportingProduct aqueous;
        /// <summary>
        /// An undifferentiated liquid fluid phase in which the dominant continuous material is liquid water. This phase is often called the "water phase".
        /// </summary>
        [EnumValueNameAttribute("aqueous")]
        public static ReportingProduct Aqueous
        {
            get 
            {
                if (aqueous == null)
                {
                    aqueous = new ReportingProduct("aqueous");
                    aqueous.Description = "An undifferentiated liquid fluid phase in which the dominant continuous material is liquid water. This phase is often called the \"water phase\".";
                }
                return aqueous;
            }
        }

        private static ReportingProduct vapor;
        /// <summary>
        /// An undifferentiated fluid phase that is distinctly gaseous. This phase is often called the "gas phase".
        /// </summary>
        [EnumValueNameAttribute("vapor")]
        public static ReportingProduct Vapor
        {
            get 
            {
                if (vapor == null)
                {
                    vapor = new ReportingProduct("vapor");
                    vapor.Description = "An undifferentiated fluid phase that is distinctly gaseous. This phase is often called the \"gas phase\".";
                }
                return vapor;
            }
        }

        private static ReportingProduct liquid;
        /// <summary>
        /// An undifferentiated fluid phase that is distinctly liquid. This includes water.
        /// </summary>
        [EnumValueNameAttribute("liquid")]
        public static ReportingProduct Liquid
        {
            get 
            {
                if (liquid == null)
                {
                    liquid = new ReportingProduct("liquid");
                    liquid.Description = "An undifferentiated fluid phase that is distinctly liquid. This includes water.";
                }
                return liquid;
            }
        }

        private static ReportingProduct cSeven;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with seven carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C7")]
        public static ReportingProduct CSeven
        {
            get 
            {
                if (cSeven == null)
                {
                    cSeven = new ReportingProduct("C7");
                    cSeven.Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with seven carbon atoms.";
                }
                return cSeven;
            }
        }

        private static ReportingProduct cEight;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with eight carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C8")]
        public static ReportingProduct CEight
        {
            get 
            {
                if (cEight == null)
                {
                    cEight = new ReportingProduct("C8");
                    cEight.Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with eight carbon atoms.";
                }
                return cEight;
            }
        }

        private static ReportingProduct cNine;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with nine carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C9")]
        public static ReportingProduct CNine
        {
            get 
            {
                if (cNine == null)
                {
                    cNine = new ReportingProduct("C9");
                    cNine.Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with nine carbon atoms.";
                }
                return cNine;
            }
        }

        private static ReportingProduct cOneZero;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with ten carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C10")]
        public static ReportingProduct COneZero
        {
            get 
            {
                if (cOneZero == null)
                {
                    cOneZero = new ReportingProduct("C10");
                    cOneZero.Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with ten carbon atoms.";
                }
                return cOneZero;
            }
        }

        private static ReportingProduct carbonMonoxodeGas;
        /// <summary>
        /// Carbon monoxode in a gaseous state.
        /// </summary>
        [EnumValueNameAttribute("carbon monoxode gas")]
        public static ReportingProduct CarbonMonoxodeGas
        {
            get 
            {
                if (carbonMonoxodeGas == null)
                {
                    carbonMonoxodeGas = new ReportingProduct("carbon monoxode gas");
                    carbonMonoxodeGas.Description = "Carbon monoxode in a gaseous state.";
                }
                return carbonMonoxodeGas;
            }
        }

        private static ReportingProduct carbonDioxideGas;
        /// <summary>
        /// Carbon dioxide in a gaseous state.
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide gas")]
        public static ReportingProduct CarbonDioxideGas
        {
            get 
            {
                if (carbonDioxideGas == null)
                {
                    carbonDioxideGas = new ReportingProduct("carbon dioxide gas");
                    carbonDioxideGas.Description = "Carbon dioxide in a gaseous state.";
                }
                return carbonDioxideGas;
            }
        }

        private static ReportingProduct chemical;
        /// <summary>
        /// A chemical of some type.
        /// </summary>
        [EnumValueNameAttribute("chemical")]
        public static ReportingProduct Chemical
        {
            get 
            {
                if (chemical == null)
                {
                    chemical = new ReportingProduct("chemical");
                    chemical.Description = "A chemical of some type.";
                }
                return chemical;
            }
        }

        private static ReportingProduct condensate;
        /// <summary>
        /// Mixture of light and heavier hydrocarbons in a liguid state.
        /// </summary>
        [EnumValueNameAttribute("condensate")]
        public static ReportingProduct Condensate
        {
            get 
            {
                if (condensate == null)
                {
                    condensate = new ReportingProduct("condensate");
                    condensate.Description = "Mixture of light and heavier hydrocarbons in a liguid state.";
                }
                return condensate;
            }
        }

        private static ReportingProduct condensateGross;
        /// <summary>
        /// Light hydrocarbon fractions produced with natural gas, which condense into liquid at normal temperatures and pressures associated with surface production equipment. 
        /// </summary>
        [EnumValueNameAttribute("condensate - gross")]
        public static ReportingProduct CondensateGross
        {
            get 
            {
                if (condensateGross == null)
                {
                    condensateGross = new ReportingProduct("condensate - gross");
                    condensateGross.Description = "Light hydrocarbon fractions produced with natural gas, which condense into liquid at normal temperatures and pressures associated with surface production equipment. ";
                }
                return condensateGross;
            }
        }

        private static ReportingProduct condensateNet;
        /// <summary>
        /// Hydrocatbon condensate containing only the heavier carbon fractions C5 to C10+.
        /// </summary>
        [EnumValueNameAttribute("condensate - net")]
        public static ReportingProduct CondensateNet
        {
            get 
            {
                if (condensateNet == null)
                {
                    condensateNet = new ReportingProduct("condensate - net");
                    condensateNet.Description = "Hydrocatbon condensate containing only the heavier carbon fractions C5 to C10+.";
                }
                return condensateNet;
            }
        }

        private static ReportingProduct crudeStabilized;
        /// <summary>
        /// A crude oil that has been stabilized by separating out dissolved gas.
        /// </summary>
        [EnumValueNameAttribute("crude - stabilized")]
        public static ReportingProduct CrudeStabilized
        {
            get 
            {
                if (crudeStabilized == null)
                {
                    crudeStabilized = new ReportingProduct("crude - stabilized");
                    crudeStabilized.Description = "A crude oil that has been stabilized by separating out dissolved gas.";
                }
                return crudeStabilized;
            }
        }

        private static ReportingProduct cuttings;
        /// <summary>
        /// Drill cuttings.
        /// </summary>
        [EnumValueNameAttribute("cuttings")]
        public static ReportingProduct Cuttings
        {
            get 
            {
                if (cuttings == null)
                {
                    cuttings = new ReportingProduct("cuttings");
                    cuttings.Description = "Drill cuttings.";
                }
                return cuttings;
            }
        }

        private static ReportingProduct diethyleneGlycol;
        /// <summary>
        /// A compound where the main component is diethylene glycol.
        /// </summary>
        [EnumValueNameAttribute("diethylene glycol")]
        public static ReportingProduct DiethyleneGlycol
        {
            get 
            {
                if (diethyleneGlycol == null)
                {
                    diethyleneGlycol = new ReportingProduct("diethylene glycol");
                    diethyleneGlycol.Description = "A compound where the main component is diethylene glycol.";
                }
                return diethyleneGlycol;
            }
        }

        private static ReportingProduct diesel;
        /// <summary>
        /// Diesel fuel.
        /// </summary>
        [EnumValueNameAttribute("diesel")]
        public static ReportingProduct Diesel
        {
            get 
            {
                if (diesel == null)
                {
                    diesel = new ReportingProduct("diesel");
                    diesel.Description = "Diesel fuel.";
                }
                return diesel;
            }
        }

        private static ReportingProduct dioxygen;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("dioxygen")]
        public static ReportingProduct Dioxygen
        {
            get 
            {
                if (dioxygen == null)
                {
                    dioxygen = new ReportingProduct("dioxygen");
                    dioxygen.Description = "xxxxxxxxxxxxxxxxxxxxxx";
                }
                return dioxygen;
            }
        }

        private static ReportingProduct electricPower;
        /// <summary>
        /// Electrical power.
        /// </summary>
        [EnumValueNameAttribute("electric power")]
        public static ReportingProduct ElectricPower
        {
            get 
            {
                if (electricPower == null)
                {
                    electricPower = new ReportingProduct("electric power");
                    electricPower.Description = "Electrical power.";
                }
                return electricPower;
            }
        }

        private static ReportingProduct ethane;
        /// <summary>
        /// A compound where the main component is ethane.
        /// </summary>
        [EnumValueNameAttribute("ethane")]
        public static ReportingProduct Ethane
        {
            get 
            {
                if (ethane == null)
                {
                    ethane = new ReportingProduct("ethane");
                    ethane.Description = "A compound where the main component is ethane.";
                }
                return ethane;
            }
        }

        private static ReportingProduct ethaneComponent;
        /// <summary>
        /// Ethane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("ethane - component")]
        public static ReportingProduct EthaneComponent
        {
            get 
            {
                if (ethaneComponent == null)
                {
                    ethaneComponent = new ReportingProduct("ethane - component");
                    ethaneComponent.Description = "Ethane as a component in another fluid.";
                }
                return ethaneComponent;
            }
        }

        private static ReportingProduct gas;
        /// <summary>
        /// Gas mixture of hydrocarbons.
        /// </summary>
        [EnumValueNameAttribute("gas")]
        public static ReportingProduct Gas
        {
            get 
            {
                if (gas == null)
                {
                    gas = new ReportingProduct("gas");
                    gas.Description = "Gas mixture of hydrocarbons.";
                }
                return gas;
            }
        }

        private static ReportingProduct gasDry;
        /// <summary>
        /// A natural gas that occurs in the absence of condensate or liquid hydrocarbons, or gas that has had condensable hydrocarbons removed, mainly consisting of methane gas.
        /// </summary>
        [EnumValueNameAttribute("gas - dry")]
        public static ReportingProduct GasDry
        {
            get 
            {
                if (gasDry == null)
                {
                    gasDry = new ReportingProduct("gas - dry");
                    gasDry.Description = "A natural gas that occurs in the absence of condensate or liquid hydrocarbons, or gas that has had condensable hydrocarbons removed, mainly consisting of methane gas.";
                }
                return gasDry;
            }
        }

        private static ReportingProduct gasRich;
        /// <summary>
        /// Gas mixture of light and heavier hydrocarbons than a lean gas.
        /// </summary>
        [EnumValueNameAttribute("gas - rich")]
        public static ReportingProduct GasRich
        {
            get 
            {
                if (gasRich == null)
                {
                    gasRich = new ReportingProduct("gas - rich");
                    gasRich.Description = "Gas mixture of light and heavier hydrocarbons than a lean gas.";
                }
                return gasRich;
            }
        }

        private static ReportingProduct gasWet;
        /// <summary>
        /// A natural gas that contains less methane (typically less than 85% methane) and more ethane and other more complex hydrocarbons like propane, butane and naphtha.
        /// </summary>
        [EnumValueNameAttribute("gas - wet")]
        public static ReportingProduct GasWet
        {
            get 
            {
                if (gasWet == null)
                {
                    gasWet = new ReportingProduct("gas - wet");
                    gasWet.Description = "A natural gas that contains less methane (typically less than 85% methane) and more ethane and other more complex hydrocarbons like propane, butane and naphtha.";
                }
                return gasWet;
            }
        }

        private static ReportingProduct gasComponentInOil;
        /// <summary>
        /// Gas as a component in oil.
        /// </summary>
        [EnumValueNameAttribute("gas - component in oil")]
        public static ReportingProduct GasComponentInOil
        {
            get 
            {
                if (gasComponentInOil == null)
                {
                    gasComponentInOil = new ReportingProduct("gas - component in oil");
                    gasComponentInOil.Description = "Gas as a component in oil.";
                }
                return gasComponentInOil;
            }
        }

        private static ReportingProduct heliumGas;
        /// <summary>
        /// xxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("helium gas")]
        public static ReportingProduct HeliumGas
        {
            get 
            {
                if (heliumGas == null)
                {
                    heliumGas = new ReportingProduct("helium gas");
                    heliumGas.Description = "xxxxxxxxxxxxxxxxx";
                }
                return heliumGas;
            }
        }

        private static ReportingProduct heptane;
        /// <summary>
        /// A compound where the main component is heptane.
        /// </summary>
        [EnumValueNameAttribute("heptane")]
        public static ReportingProduct Heptane
        {
            get 
            {
                if (heptane == null)
                {
                    heptane = new ReportingProduct("heptane");
                    heptane.Description = "A compound where the main component is heptane.";
                }
                return heptane;
            }
        }

        private static ReportingProduct hydraulicControlFluid;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("hydraulic control fluid")]
        public static ReportingProduct HydraulicControlFluid
        {
            get 
            {
                if (hydraulicControlFluid == null)
                {
                    hydraulicControlFluid = new ReportingProduct("hydraulic control fluid");
                    hydraulicControlFluid.Description = "xxxxxxxxxxxxxxxxxxxxxx";
                }
                return hydraulicControlFluid;
            }
        }

        private static ReportingProduct hydrogenGas;
        /// <summary>
        /// xxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("hydrogen gas")]
        public static ReportingProduct HydrogenGas
        {
            get 
            {
                if (hydrogenGas == null)
                {
                    hydrogenGas = new ReportingProduct("hydrogen gas");
                    hydrogenGas.Description = "xxxxxxxxxxxxxxxxx";
                }
                return hydrogenGas;
            }
        }

        private static ReportingProduct hydrogenSulfide;
        /// <summary>
        /// A compound where the main component is hydrogen sulfide.
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide")]
        public static ReportingProduct HydrogenSulfide
        {
            get 
            {
                if (hydrogenSulfide == null)
                {
                    hydrogenSulfide = new ReportingProduct("hydrogen sulfide");
                    hydrogenSulfide.Description = "A compound where the main component is hydrogen sulfide.";
                }
                return hydrogenSulfide;
            }
        }

        private static ReportingProduct ibutaneComponent;
        /// <summary>
        /// I-butane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("i-butane - component")]
        public static ReportingProduct IbutaneComponent
        {
            get 
            {
                if (ibutaneComponent == null)
                {
                    ibutaneComponent = new ReportingProduct("i-butane - component");
                    ibutaneComponent.Description = "I-butane as a component in another fluid.";
                }
                return ibutaneComponent;
            }
        }

        private static ReportingProduct isobutane;
        /// <summary>
        /// A compound where the main component is isobutane.
        /// </summary>
        [EnumValueNameAttribute("isobutane")]
        public static ReportingProduct Isobutane
        {
            get 
            {
                if (isobutane == null)
                {
                    isobutane = new ReportingProduct("isobutane");
                    isobutane.Description = "A compound where the main component is isobutane.";
                }
                return isobutane;
            }
        }

        private static ReportingProduct isopentane;
        /// <summary>
        /// A compound where the main component is isopentane.
        /// </summary>
        [EnumValueNameAttribute("isopentane")]
        public static ReportingProduct Isopentane
        {
            get 
            {
                if (isopentane == null)
                {
                    isopentane = new ReportingProduct("isopentane");
                    isopentane.Description = "A compound where the main component is isopentane.";
                }
                return isopentane;
            }
        }

        private static ReportingProduct liquifiedNaturalGas;
        /// <summary>
        /// A liquid compound that is natural gas compressed and supercooled to -167 deg C (-269 deg F) into a liquid to reduce its volume to 1/635th for storage and transportation. Liquefied natural gas has a calorific value of 22,300 Btu/lb. It consists of about 91% of methane and 7% ethane with some propane, butane, and higher hydrocarbons. One tonne liquified natural gas is equal to about 53 Mcf of gas. Liquified natural gas can be vaporized by ambient air, another fluid, or directfired vaporizer.
        /// </summary>
        [EnumValueNameAttribute("liquified natural gas")]
        public static ReportingProduct LiquifiedNaturalGas
        {
            get 
            {
                if (liquifiedNaturalGas == null)
                {
                    liquifiedNaturalGas = new ReportingProduct("liquified natural gas");
                    liquifiedNaturalGas.Description = "A liquid compound that is natural gas compressed and supercooled to -167 deg C (-269 deg F) into a liquid to reduce its volume to 1/635th for storage and transportation. Liquefied natural gas has a calorific value of 22,300 Btu/lb. It consists of about 91% of methane and 7% ethane with some propane, butane, and higher hydrocarbons. One tonne liquified natural gas is equal to about 53 Mcf of gas. Liquified natural gas can be vaporized by ambient air, another fluid, or directfired vaporizer.";
                }
                return liquifiedNaturalGas;
            }
        }

        private static ReportingProduct liquifiedPetroleumGas;
        /// <summary>
        /// A liquid compound that is predominantly butane and propane separated from natural gasoline or natural gas and sold as fuel - commonly known as bottled gas, tank gas or LP-gas.
        /// </summary>
        [EnumValueNameAttribute("liquified petroleum gas")]
        public static ReportingProduct LiquifiedPetroleumGas
        {
            get 
            {
                if (liquifiedPetroleumGas == null)
                {
                    liquifiedPetroleumGas = new ReportingProduct("liquified petroleum gas");
                    liquifiedPetroleumGas.Description = "A liquid compound that is predominantly butane and propane separated from natural gasoline or natural gas and sold as fuel - commonly known as bottled gas, tank gas or LP-gas.";
                }
                return liquifiedPetroleumGas;
            }
        }

        private static ReportingProduct methane;
        /// <summary>
        /// A compound where the main component is methane.
        /// </summary>
        [EnumValueNameAttribute("methane")]
        public static ReportingProduct Methane
        {
            get 
            {
                if (methane == null)
                {
                    methane = new ReportingProduct("methane");
                    methane.Description = "A compound where the main component is methane.";
                }
                return methane;
            }
        }

        private static ReportingProduct methaneComponent;
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("methane - component")]
        public static ReportingProduct MethaneComponent
        {
            get 
            {
                if (methaneComponent == null)
                {
                    methaneComponent = new ReportingProduct("methane - component");
                    methaneComponent.Description = "xxxxxxxxxxxxxxxx";
                }
                return methaneComponent;
            }
        }

        private static ReportingProduct methanol;
        /// <summary>
        /// A compound where the main component is methanol.
        /// </summary>
        [EnumValueNameAttribute("methanol")]
        public static ReportingProduct Methanol
        {
            get 
            {
                if (methanol == null)
                {
                    methanol = new ReportingProduct("methanol");
                    methanol.Description = "A compound where the main component is methanol.";
                }
                return methanol;
            }
        }

        private static ReportingProduct mixedButane;
        /// <summary>
        /// A compound where the main components are butane and isobutane.
        /// </summary>
        [EnumValueNameAttribute("mixed butane")]
        public static ReportingProduct MixedButane
        {
            get 
            {
                if (mixedButane == null)
                {
                    mixedButane = new ReportingProduct("mixed butane");
                    mixedButane.Description = "A compound where the main components are butane and isobutane.";
                }
                return mixedButane;
            }
        }

        private static ReportingProduct monoethyleneGlycol;
        /// <summary>
        /// A compound where the main component is monoethylene glycol.
        /// </summary>
        [EnumValueNameAttribute("monoethylene glycol")]
        public static ReportingProduct MonoethyleneGlycol
        {
            get 
            {
                if (monoethyleneGlycol == null)
                {
                    monoethyleneGlycol = new ReportingProduct("monoethylene glycol");
                    monoethyleneGlycol.Description = "A compound where the main component is monoethylene glycol.";
                }
                return monoethyleneGlycol;
            }
        }

        private static ReportingProduct nbutaneComponent;
        /// <summary>
        /// N-butane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("n-butane - component")]
        public static ReportingProduct NbutaneComponent
        {
            get 
            {
                if (nbutaneComponent == null)
                {
                    nbutaneComponent = new ReportingProduct("n-butane - component");
                    nbutaneComponent.Description = "N-butane as a component in another fluid.";
                }
                return nbutaneComponent;
            }
        }

        private static ReportingProduct naphta;
        /// <summary>
        /// An aggregate that is a volatile and inflammable product of crude oil refining with a boiling range 140 - 210 deg. Celsius consisting of C5+ to C10 components (pentanes and hexanes).
        /// </summary>
        [EnumValueNameAttribute("naphta")]
        public static ReportingProduct Naphta
        {
            get 
            {
                if (naphta == null)
                {
                    naphta = new ReportingProduct("naphta");
                    naphta.Description = "An aggregate that is a volatile and inflammable product of crude oil refining with a boiling range 140 - 210 deg. Celsius consisting of C5+ to C10 components (pentanes and hexanes).";
                }
                return naphta;
            }
        }

        private static ReportingProduct naturalGasLiquid;
        /// <summary>
        /// Mixture of ethane, propane and butane with small quantities of heaver hydrocarbons. Partially liquid at atmospheric pressure.
        /// </summary>
        [EnumValueNameAttribute("natural gas liquid")]
        public static ReportingProduct NaturalGasLiquid
        {
            get 
            {
                if (naturalGasLiquid == null)
                {
                    naturalGasLiquid = new ReportingProduct("natural gas liquid");
                    naturalGasLiquid.Description = "Mixture of ethane, propane and butane with small quantities of heaver hydrocarbons. Partially liquid at atmospheric pressure.";
                }
                return naturalGasLiquid;
            }
        }

        private static ReportingProduct neopentane;
        /// <summary>
        /// A compound where the main component is neopentane.
        /// </summary>
        [EnumValueNameAttribute("neopentane")]
        public static ReportingProduct Neopentane
        {
            get 
            {
                if (neopentane == null)
                {
                    neopentane = new ReportingProduct("neopentane");
                    neopentane.Description = "A compound where the main component is neopentane.";
                }
                return neopentane;
            }
        }

        private static ReportingProduct nitrogenGas;
        /// <summary>
        /// A gasous compound where the main component is nitrogen.
        /// </summary>
        [EnumValueNameAttribute("nitrogen gas")]
        public static ReportingProduct NitrogenGas
        {
            get 
            {
                if (nitrogenGas == null)
                {
                    nitrogenGas = new ReportingProduct("nitrogen gas");
                    nitrogenGas.Description = "A gasous compound where the main component is nitrogen.";
                }
                return nitrogenGas;
            }
        }

        private static ReportingProduct nitrogenOxideGas;
        /// <summary>
        /// Nitrogen oxides in a gaseous state
        /// </summary>
        [EnumValueNameAttribute("nitrogen oxide gas")]
        public static ReportingProduct NitrogenOxideGas
        {
            get 
            {
                if (nitrogenOxideGas == null)
                {
                    nitrogenOxideGas = new ReportingProduct("nitrogen oxide gas");
                    nitrogenOxideGas.Description = "Nitrogen oxides in a gaseous state";
                }
                return nitrogenOxideGas;
            }
        }

        private static ReportingProduct nglComponentInGas;
        /// <summary>
        /// Natural gas liquid as a component in gas.
        /// </summary>
        [EnumValueNameAttribute("NGL - component in gas")]
        public static ReportingProduct NglComponentInGas
        {
            get 
            {
                if (nglComponentInGas == null)
                {
                    nglComponentInGas = new ReportingProduct("NGL - component in gas");
                    nglComponentInGas.Description = "Natural gas liquid as a component in gas.";
                }
                return nglComponentInGas;
            }
        }

        private static ReportingProduct normalButane;
        /// <summary>
        /// A compound where the main component is butane.
        /// </summary>
        [EnumValueNameAttribute("normal butane")]
        public static ReportingProduct NormalButane
        {
            get 
            {
                if (normalButane == null)
                {
                    normalButane = new ReportingProduct("normal butane");
                    normalButane.Description = "A compound where the main component is butane.";
                }
                return normalButane;
            }
        }

        private static ReportingProduct normalPentane;
        /// <summary>
        /// A compound where the main component is pentane.
        /// </summary>
        [EnumValueNameAttribute("normal pentane")]
        public static ReportingProduct NormalPentane
        {
            get 
            {
                if (normalPentane == null)
                {
                    normalPentane = new ReportingProduct("normal pentane");
                    normalPentane.Description = "A compound where the main component is pentane.";
                }
                return normalPentane;
            }
        }

        private static ReportingProduct oilAndGas;
        /// <summary>
        /// A combination of oil (including water) and gas. This is generally used when refering to 'all production'.
        /// </summary>
        [EnumValueNameAttribute("oil and gas")]
        public static ReportingProduct OilAndGas
        {
            get 
            {
                if (oilAndGas == null)
                {
                    oilAndGas = new ReportingProduct("oil and gas");
                    oilAndGas.Description = "A combination of oil (including water) and gas. This is generally used when refering to 'all production'.";
                }
                return oilAndGas;
            }
        }

        private static ReportingProduct oil;
        /// <summary>
        /// Crude oil including water. A mixture of hydrocargons, that existed in liquid phase in underground reservoirs and remains liquid at atmospheric pressure after passing through separating facilities.
        /// </summary>
        [EnumValueNameAttribute("oil")]
        public static ReportingProduct Oil
        {
            get 
            {
                if (oil == null)
                {
                    oil = new ReportingProduct("oil");
                    oil.Description = "Crude oil including water. A mixture of hydrocargons, that existed in liquid phase in underground reservoirs and remains liquid at atmospheric pressure after passing through separating facilities.";
                }
                return oil;
            }
        }

        private static ReportingProduct oilGross;
        /// <summary>
        /// A crude oil that that includes all petroleum liquids and sediments and water, excluding free water.
        /// </summary>
        [EnumValueNameAttribute("oil - gross")]
        public static ReportingProduct OilGross
        {
            get 
            {
                if (oilGross == null)
                {
                    oilGross = new ReportingProduct("oil - gross");
                    oilGross.Description = "A crude oil that that includes all petroleum liquids and sediments and water, excluding free water.";
                }
                return oilGross;
            }
        }

        private static ReportingProduct oilNet;
        /// <summary>
        /// A crude oil that includes all petroleum liquids excluding sediments and water as well as free water.
        /// </summary>
        [EnumValueNameAttribute("oil - net")]
        public static ReportingProduct OilNet
        {
            get 
            {
                if (oilNet == null)
                {
                    oilNet = new ReportingProduct("oil - net");
                    oilNet.Description = "A crude oil that includes all petroleum liquids excluding sediments and water as well as free water.";
                }
                return oilNet;
            }
        }

        private static ReportingProduct oilComponentInWater;
        /// <summary>
        /// Oil as a component in water.
        /// </summary>
        [EnumValueNameAttribute("oil - component in water")]
        public static ReportingProduct OilComponentInWater
        {
            get 
            {
                if (oilComponentInWater == null)
                {
                    oilComponentInWater = new ReportingProduct("oil - component in water");
                    oilComponentInWater.Description = "Oil as a component in water.";
                }
                return oilComponentInWater;
            }
        }

        private static ReportingProduct pentaneComponent;
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("pentane - component")]
        public static ReportingProduct PentaneComponent
        {
            get 
            {
                if (pentaneComponent == null)
                {
                    pentaneComponent = new ReportingProduct("pentane - component");
                    pentaneComponent.Description = "xxxxxxxxxxxxxxxx";
                }
                return pentaneComponent;
            }
        }

        private static ReportingProduct petroleumGasLiquid;
        /// <summary>
        /// DEPRECATED - See liquified natural gas.
        /// </summary>
        [EnumValueNameAttribute("petroleum gas liquid")]
        public static ReportingProduct PetroleumGasLiquid
        {
            get 
            {
                if (petroleumGasLiquid == null)
                {
                    petroleumGasLiquid = new ReportingProduct("petroleum gas liquid");
                    petroleumGasLiquid.Description = "DEPRECATED - See liquified natural gas.";
                }
                return petroleumGasLiquid;
            }
        }

        private static ReportingProduct propane;
        /// <summary>
        /// A compound where the main component is propane.
        /// </summary>
        [EnumValueNameAttribute("propane")]
        public static ReportingProduct Propane
        {
            get 
            {
                if (propane == null)
                {
                    propane = new ReportingProduct("propane");
                    propane.Description = "A compound where the main component is propane.";
                }
                return propane;
            }
        }

        private static ReportingProduct propaneComponent;
        /// <summary>
        /// Propane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("propane - component")]
        public static ReportingProduct PropaneComponent
        {
            get 
            {
                if (propaneComponent == null)
                {
                    propaneComponent = new ReportingProduct("propane - component");
                    propaneComponent.Description = "Propane as a component in another fluid.";
                }
                return propaneComponent;
            }
        }

        private static ReportingProduct salt;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("salt")]
        public static ReportingProduct Salt
        {
            get 
            {
                if (salt == null)
                {
                    salt = new ReportingProduct("salt");
                    salt.Description = "xxxxxxxxxxxxxxxxxxxxxx";
                }
                return salt;
            }
        }

        private static ReportingProduct sandComponent;
        /// <summary>
        /// Sand as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("sand - component")]
        public static ReportingProduct SandComponent
        {
            get 
            {
                if (sandComponent == null)
                {
                    sandComponent = new ReportingProduct("sand - component");
                    sandComponent.Description = "Sand as a component in another fluid.";
                }
                return sandComponent;
            }
        }

        private static ReportingProduct triethyleneGlycol;
        /// <summary>
        /// A compound where the main component is triethylene glycol.
        /// </summary>
        [EnumValueNameAttribute("triethylene glycol")]
        public static ReportingProduct TriethyleneGlycol
        {
            get 
            {
                if (triethyleneGlycol == null)
                {
                    triethyleneGlycol = new ReportingProduct("triethylene glycol");
                    triethyleneGlycol.Description = "A compound where the main component is triethylene glycol.";
                }
                return triethyleneGlycol;
            }
        }

        private static ReportingProduct water;
        /// <summary>
        /// Water in a liquid state.
        /// </summary>
        [EnumValueNameAttribute("water")]
        public static ReportingProduct Water
        {
            get 
            {
                if (water == null)
                {
                    water = new ReportingProduct("water");
                    water.Description = "Water in a liquid state.";
                }
                return water;
            }
        }

        private static ReportingProduct waterDischarge;
        /// <summary>
        /// Produced water that has not been processed.
        /// </summary>
        [EnumValueNameAttribute("water - discharge")]
        public static ReportingProduct WaterDischarge
        {
            get 
            {
                if (waterDischarge == null)
                {
                    waterDischarge = new ReportingProduct("water - discharge");
                    waterDischarge.Description = "Produced water that has not been processed.";
                }
                return waterDischarge;
            }
        }

        private static ReportingProduct waterProcessed;
        /// <summary>
        /// Produced water that has been processed to remove hydrocarbons.
        /// </summary>
        [EnumValueNameAttribute("water - processed")]
        public static ReportingProduct WaterProcessed
        {
            get 
            {
                if (waterProcessed == null)
                {
                    waterProcessed = new ReportingProduct("water - processed");
                    waterProcessed.Description = "Produced water that has been processed to remove hydrocarbons.";
                }
                return waterProcessed;
            }
        }

        private static ReportingProduct unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingProduct Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReportingProduct("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The type of properties that can be measured at a port.
    /// </summary>
    public class ReportingProperty : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReportingProperty(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReportingProperty</param>
        public ReportingProperty(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReportingPropertys
        /// </summary>
        /// <returns>The complete list of ReportingPropertys</returns>
        public static List<ReportingProperty> GetList()
        {
            return GetList<ReportingProperty>();
        }

        private static ReportingProperty volume;
        /// <summary>
        /// A volume measure.
        /// </summary>
        [EnumValueNameAttribute("volume")]
        public static ReportingProperty Volume
        {
            get 
            {
                if (volume == null)
                {
                    volume = new ReportingProperty("volume");
                    volume.Description = "A volume measure.";
                }
                return volume;
            }
        }

        private static ReportingProperty standardVolume;
        /// <summary>
        /// A volume measure at standard conditions of temperature and pressure.
        /// </summary>
        [EnumValueNameAttribute("standard volume")]
        public static ReportingProperty StandardVolume
        {
            get 
            {
                if (standardVolume == null)
                {
                    standardVolume = new ReportingProperty("standard volume");
                    standardVolume.Description = "A volume measure at standard conditions of temperature and pressure.";
                }
                return standardVolume;
            }
        }

        private static ReportingProperty flowRate;
        /// <summary>
        /// A flow rate measure.
        /// </summary>
        [EnumValueNameAttribute("flow rate")]
        public static ReportingProperty FlowRate
        {
            get 
            {
                if (flowRate == null)
                {
                    flowRate = new ReportingProperty("flow rate");
                    flowRate.Description = "A flow rate measure.";
                }
                return flowRate;
            }
        }

        private static ReportingProperty temperature;
        /// <summary>
        /// A temperature measure.
        /// </summary>
        [EnumValueNameAttribute("temperature")]
        public static ReportingProperty Temperature
        {
            get 
            {
                if (temperature == null)
                {
                    temperature = new ReportingProperty("temperature");
                    temperature.Description = "A temperature measure.";
                }
                return temperature;
            }
        }

        private static ReportingProperty pressure;
        /// <summary>
        /// A pressure measure.
        /// </summary>
        [EnumValueNameAttribute("pressure")]
        public static ReportingProperty Pressure
        {
            get 
            {
                if (pressure == null)
                {
                    pressure = new ReportingProperty("pressure");
                    pressure.Description = "A pressure measure.";
                }
                return pressure;
            }
        }

        private static ReportingProperty mass;
        /// <summary>
        /// A mass measure.
        /// </summary>
        [EnumValueNameAttribute("mass")]
        public static ReportingProperty Mass
        {
            get 
            {
                if (mass == null)
                {
                    mass = new ReportingProperty("mass");
                    mass.Description = "A mass measure.";
                }
                return mass;
            }
        }

        private static ReportingProperty work;
        /// <summary>
        /// A work measure (of electricity).
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static ReportingProperty Work
        {
            get 
            {
                if (work == null)
                {
                    work = new ReportingProperty("work");
                    work.Description = "A work measure (of electricity).";
                }
                return work;
            }
        }

        private static ReportingProperty unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingProperty Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReportingProperty("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The status of a version of a report.
    /// </summary>
    public class ReportVersionStatus : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReportVersionStatus(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReportVersionStatus</param>
        public ReportVersionStatus(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReportVersionStatuss
        /// </summary>
        /// <returns>The complete list of ReportVersionStatuss</returns>
        public static List<ReportVersionStatus> GetList()
        {
            return GetList<ReportVersionStatus>();
        }

        private static ReportVersionStatus final;
        /// <summary>
        /// xxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("final")]
        public static ReportVersionStatus Final
        {
            get 
            {
                if (final == null)
                {
                    final = new ReportVersionStatus("final");
                    final.Description = "xxxxxxxxxxxxxxx";
                }
                return final;
            }
        }

        private static ReportVersionStatus preliminary;
        /// <summary>
        /// xxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("preliminary")]
        public static ReportVersionStatus Preliminary
        {
            get 
            {
                if (preliminary == null)
                {
                    preliminary = new ReportVersionStatus("preliminary");
                    preliminary.Description = "xxxxxxxxxxxxxxx";
                }
                return preliminary;
            }
        }

        private static ReportVersionStatus unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportVersionStatus Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReportVersionStatus("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class ReservoirFluidKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ReservoirFluidKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ReservoirFluidKind</param>
        public ReservoirFluidKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ReservoirFluidKinds
        /// </summary>
        /// <returns>The complete list of ReservoirFluidKinds</returns>
        public static List<ReservoirFluidKind> GetList()
        {
            return GetList<ReservoirFluidKind>();
        }

        private static ReservoirFluidKind blackOil;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("black oil")]
        public static ReservoirFluidKind BlackOil
        {
            get 
            {
                if (blackOil == null)
                {
                    blackOil = new ReservoirFluidKind("black oil");
                    blackOil.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return blackOil;
            }
        }

        private static ReservoirFluidKind volatileOil;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("volatile oil")]
        public static ReservoirFluidKind VolatileOil
        {
            get 
            {
                if (volatileOil == null)
                {
                    volatileOil = new ReservoirFluidKind("volatile oil");
                    volatileOil.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return volatileOil;
            }
        }

        private static ReservoirFluidKind criticalOrNearCritical;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("critical or near critical")]
        public static ReservoirFluidKind CriticalOrNearCritical
        {
            get 
            {
                if (criticalOrNearCritical == null)
                {
                    criticalOrNearCritical = new ReservoirFluidKind("critical or near critical");
                    criticalOrNearCritical.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return criticalOrNearCritical;
            }
        }

        private static ReservoirFluidKind wetGasOrCondensate;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("wet gas or condensate")]
        public static ReservoirFluidKind WetGasOrCondensate
        {
            get 
            {
                if (wetGasOrCondensate == null)
                {
                    wetGasOrCondensate = new ReservoirFluidKind("wet gas or condensate");
                    wetGasOrCondensate.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return wetGasOrCondensate;
            }
        }

        private static ReservoirFluidKind dryGas;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("dry gas")]
        public static ReservoirFluidKind DryGas
        {
            get 
            {
                if (dryGas == null)
                {
                    dryGas = new ReservoirFluidKind("dry gas");
                    dryGas.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return dryGas;
            }
        }

        private static ReservoirFluidKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReservoirFluidKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ReservoirFluidKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The type of safety issues for which a count can be defined.
    /// </summary>
    public class SafetyType : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected SafetyType(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the SafetyType</param>
        public SafetyType(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of SafetyTypes
        /// </summary>
        /// <returns>The complete list of SafetyTypes</returns>
        public static List<SafetyType> GetList()
        {
            return GetList<SafetyType>();
        }

        private static SafetyType drillOrExercise;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("drill or exercise")]
        public static SafetyType DrillOrExercise
        {
            get 
            {
                if (drillOrExercise == null)
                {
                    drillOrExercise = new SafetyType("drill or exercise");
                    drillOrExercise.Description = "xxxxxxxxxxxxxxx.";
                }
                return drillOrExercise;
            }
        }

        private static SafetyType fire;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("fire")]
        public static SafetyType Fire
        {
            get 
            {
                if (fire == null)
                {
                    fire = new SafetyType("fire");
                    fire.Description = "xxxxxxxxxxxxxxx.";
                }
                return fire;
            }
        }

        private static SafetyType firstAid;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("first aid")]
        public static SafetyType FirstAid
        {
            get 
            {
                if (firstAid == null)
                {
                    firstAid = new SafetyType("first aid");
                    firstAid.Description = "xxxxxxxxxxxxxxx.";
                }
                return firstAid;
            }
        }

        private static SafetyType hazardReportCard;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("hazard report card")]
        public static SafetyType HazardReportCard
        {
            get 
            {
                if (hazardReportCard == null)
                {
                    hazardReportCard = new SafetyType("hazard report card");
                    hazardReportCard.Description = "xxxxxxxxxxxxxxx.";
                }
                return hazardReportCard;
            }
        }

        private static SafetyType jobObservation;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("job observation")]
        public static SafetyType JobObservation
        {
            get 
            {
                if (jobObservation == null)
                {
                    jobObservation = new SafetyType("job observation");
                    jobObservation.Description = "xxxxxxxxxxxxxxx.";
                }
                return jobObservation;
            }
        }

        private static SafetyType lostTimeIncident;
        /// <summary>
        /// An incident resulted in an injured employee who required medical treatment and could not return to work the next day.
        /// </summary>
        [EnumValueNameAttribute("lost time incident")]
        public static SafetyType LostTimeIncident
        {
            get 
            {
                if (lostTimeIncident == null)
                {
                    lostTimeIncident = new SafetyType("lost time incident");
                    lostTimeIncident.Description = "An incident resulted in an injured employee who required medical treatment and could not return to work the next day.";
                }
                return lostTimeIncident;
            }
        }

        private static SafetyType lostTimeAccident;
        /// <summary>
        /// An accident resulting in lost time from work .
        /// </summary>
        [EnumValueNameAttribute("lost time accident")]
        public static SafetyType LostTimeAccident
        {
            get 
            {
                if (lostTimeAccident == null)
                {
                    lostTimeAccident = new SafetyType("lost time accident");
                    lostTimeAccident.Description = "An accident resulting in lost time from work .";
                }
                return lostTimeAccident;
            }
        }

        private static SafetyType miscellaneous;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("miscellaneous")]
        public static SafetyType Miscellaneous
        {
            get 
            {
                if (miscellaneous == null)
                {
                    miscellaneous = new SafetyType("miscellaneous");
                    miscellaneous.Description = "xxxxxxxxxxxxxxx.";
                }
                return miscellaneous;
            }
        }

        private static SafetyType nearMiss;
        /// <summary>
        /// An incident which, under different circumstances, could have caused injury, illness and/or major damage to/loss of assets, or harm to the environment or to a third party.
        /// </summary>
        [EnumValueNameAttribute("near miss")]
        public static SafetyType NearMiss
        {
            get 
            {
                if (nearMiss == null)
                {
                    nearMiss = new SafetyType("near miss");
                    nearMiss.Description = "An incident which, under different circumstances, could have caused injury, illness and/or major damage to/loss of assets, or harm to the environment or to a third party.";
                }
                return nearMiss;
            }
        }

        private static SafetyType permitWithSja;
        /// <summary>
        /// Safe Job Analysis.
        /// </summary>
        [EnumValueNameAttribute("permit with SJA")]
        public static SafetyType PermitWithSja
        {
            get 
            {
                if (permitWithSja == null)
                {
                    permitWithSja = new SafetyType("permit with SJA");
                    permitWithSja.Description = "Safe Job Analysis.";
                }
                return permitWithSja;
            }
        }

        private static SafetyType releasedToAir;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("released to air")]
        public static SafetyType ReleasedToAir
        {
            get 
            {
                if (releasedToAir == null)
                {
                    releasedToAir = new SafetyType("released to air");
                    releasedToAir.Description = "xxxxxxxxxxxxxxx.";
                }
                return releasedToAir;
            }
        }

        private static SafetyType releasedToWater;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("released to water")]
        public static SafetyType ReleasedToWater
        {
            get 
            {
                if (releasedToWater == null)
                {
                    releasedToWater = new SafetyType("released to water");
                    releasedToWater.Description = "xxxxxxxxxxxxxxx.";
                }
                return releasedToWater;
            }
        }

        private static SafetyType restrictedWork;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("restricted work")]
        public static SafetyType RestrictedWork
        {
            get 
            {
                if (restrictedWork == null)
                {
                    restrictedWork = new SafetyType("restricted work");
                    restrictedWork.Description = "xxxxxxxxxxxxxxx.";
                }
                return restrictedWork;
            }
        }

        private static SafetyType safetyMeeting;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("safety meeting")]
        public static SafetyType SafetyMeeting
        {
            get 
            {
                if (safetyMeeting == null)
                {
                    safetyMeeting = new SafetyType("safety meeting");
                    safetyMeeting.Description = "xxxxxxxxxxxxxxx.";
                }
                return safetyMeeting;
            }
        }

        private static SafetyType sentAshore;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("sent ashore")]
        public static SafetyType SentAshore
        {
            get 
            {
                if (sentAshore == null)
                {
                    sentAshore = new SafetyType("sent ashore");
                    sentAshore.Description = "xxxxxxxxxxxxxxx.";
                }
                return sentAshore;
            }
        }

        private static SafetyType severeAccident;
        /// <summary>
        ///  A type of accident that may challenge safety systems at a level much higher than expected..
        /// </summary>
        [EnumValueNameAttribute("severe accident")]
        public static SafetyType SevereAccident
        {
            get 
            {
                if (severeAccident == null)
                {
                    severeAccident = new SafetyType("severe accident");
                    severeAccident.Description = " A type of accident that may challenge safety systems at a level much higher than expected..";
                }
                return severeAccident;
            }
        }

        private static SafetyType sickOnBoard;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("sick on board")]
        public static SafetyType SickOnBoard
        {
            get 
            {
                if (sickOnBoard == null)
                {
                    sickOnBoard = new SafetyType("sick on board");
                    sickOnBoard.Description = "xxxxxxxxxxxxxxx.";
                }
                return sickOnBoard;
            }
        }

        private static SafetyType spillOrLeak;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("spill or leak")]
        public static SafetyType SpillOrLeak
        {
            get 
            {
                if (spillOrLeak == null)
                {
                    spillOrLeak = new SafetyType("spill or leak");
                    spillOrLeak.Description = "xxxxxxxxxxxxxxx.";
                }
                return spillOrLeak;
            }
        }

        private static SafetyType trafficAccident;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("traffic accident")]
        public static SafetyType TrafficAccident
        {
            get 
            {
                if (trafficAccident == null)
                {
                    trafficAccident = new SafetyType("traffic accident");
                    trafficAccident.Description = "xxxxxxxxxxxxxxx.";
                }
                return trafficAccident;
            }
        }

        private static SafetyType totalPermits;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("total permits")]
        public static SafetyType TotalPermits
        {
            get 
            {
                if (totalPermits == null)
                {
                    totalPermits = new SafetyType("total permits");
                    totalPermits.Description = "xxxxxxxxxxxxxxx.";
                }
                return totalPermits;
            }
        }

        private static SafetyType yeartodateIncidents;
        /// <summary>
        /// xxxxxxxxxxxxxxx.
        /// </summary>
        [EnumValueNameAttribute("year-to-date incidents")]
        public static SafetyType YeartodateIncidents
        {
            get 
            {
                if (yeartodateIncidents == null)
                {
                    yeartodateIncidents = new SafetyType("year-to-date incidents");
                    yeartodateIncidents.Description = "xxxxxxxxxxxxxxx.";
                }
                return yeartodateIncidents;
            }
        }

        private static SafetyType unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static SafetyType Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new SafetyType("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Combinations of standard temperature and pressure including "ambient".
    /// </summary>
    public class StandardCondition : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected StandardCondition(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the StandardCondition</param>
        public StandardCondition(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of StandardConditions
        /// </summary>
        /// <returns>The complete list of StandardConditions</returns>
        public static List<StandardCondition> GetList()
        {
            return GetList<StandardCondition>();
        }

        private static StandardCondition ambient;
        /// <summary>
        /// Ambient conditions at the time of measurement. That is, the value has not been converted.
        /// </summary>
        [EnumValueNameAttribute("ambient")]
        public static StandardCondition Ambient
        {
            get 
            {
                if (ambient == null)
                {
                    ambient = new StandardCondition("ambient");
                    ambient.Description = "Ambient conditions at the time of measurement. That is, the value has not been converted.";
                }
                return ambient;
            }
        }

        private static StandardCondition zeroDegcOneAtm;
        /// <summary>
        /// A temperature of zero degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("0 degC 1 atm")]
        public static StandardCondition ZeroDegcOneAtm
        {
            get 
            {
                if (zeroDegcOneAtm == null)
                {
                    zeroDegcOneAtm = new StandardCondition("0 degC 1 atm");
                    zeroDegcOneAtm.Description = "A temperature of zero degrees Centigrade and a pressure of one atmosphere.";
                }
                return zeroDegcOneAtm;
            }
        }

        private static StandardCondition oneFiveDegcOneAtm;
        /// <summary>
        /// A temperature of sixty degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("15 degC 1 atm")]
        public static StandardCondition OneFiveDegcOneAtm
        {
            get 
            {
                if (oneFiveDegcOneAtm == null)
                {
                    oneFiveDegcOneAtm = new StandardCondition("15 degC 1 atm");
                    oneFiveDegcOneAtm.Description = "A temperature of sixty degrees Centigrade and a pressure of one atmosphere.";
                }
                return oneFiveDegcOneAtm;
            }
        }

        private static StandardCondition sixZeroDegfOneAtm;
        /// <summary>
        /// A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("60 degF 1 atm")]
        public static StandardCondition SixZeroDegfOneAtm
        {
            get 
            {
                if (sixZeroDegfOneAtm == null)
                {
                    sixZeroDegfOneAtm = new StandardCondition("60 degF 1 atm");
                    sixZeroDegfOneAtm.Description = "A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere.";
                }
                return sixZeroDegfOneAtm;
            }
        }

        private static StandardCondition unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static StandardCondition Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new StandardCondition("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Combinations of standard temperature and pressure.
    /// </summary>
    public class StandardTempPress : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected StandardTempPress(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the StandardTempPress</param>
        public StandardTempPress(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of StandardTempPresss
        /// </summary>
        /// <returns>The complete list of StandardTempPresss</returns>
        public static List<StandardTempPress> GetList()
        {
            return GetList<StandardTempPress>();
        }

        private static StandardTempPress zeroDegcOneAtm;
        /// <summary>
        /// A temperature of zero degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("0 degC 1 atm")]
        public static StandardTempPress ZeroDegcOneAtm
        {
            get 
            {
                if (zeroDegcOneAtm == null)
                {
                    zeroDegcOneAtm = new StandardTempPress("0 degC 1 atm");
                    zeroDegcOneAtm.Description = "A temperature of zero degrees Centigrade and a pressure of one atmosphere.";
                }
                return zeroDegcOneAtm;
            }
        }

        private static StandardTempPress oneFiveDegcOneAtm;
        /// <summary>
        /// A temperature of sixty degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("15 degC 1 atm")]
        public static StandardTempPress OneFiveDegcOneAtm
        {
            get 
            {
                if (oneFiveDegcOneAtm == null)
                {
                    oneFiveDegcOneAtm = new StandardTempPress("15 degC 1 atm");
                    oneFiveDegcOneAtm.Description = "A temperature of sixty degrees Centigrade and a pressure of one atmosphere.";
                }
                return oneFiveDegcOneAtm;
            }
        }

        private static StandardTempPress sixZeroDegfOneAtm;
        /// <summary>
        /// A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("60 degF 1 atm")]
        public static StandardTempPress SixZeroDegfOneAtm
        {
            get 
            {
                if (sixZeroDegfOneAtm == null)
                {
                    sixZeroDegfOneAtm = new StandardTempPress("60 degF 1 atm");
                    sixZeroDegfOneAtm.Description = "A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere.";
                }
                return sixZeroDegfOneAtm;
            }
        }

        private static StandardTempPress unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static StandardTempPress Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new StandardTempPress("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// The value is not known. This value should not be used
    ///			in normal situations. All reasonable attempts should be made to determine
    ///			the appropriate value. Use of this value may result in rejection in some situations.
    /// </summary>
    public class TestReason : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected TestReason(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the TestReason</param>
        public TestReason(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of TestReasons
        /// </summary>
        /// <returns>The complete list of TestReasons</returns>
        public static List<TestReason> GetList()
        {
            return GetList<TestReason>();
        }

        private static TestReason initial;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("initial")]
        public static TestReason Initial
        {
            get 
            {
                if (initial == null)
                {
                    initial = new TestReason("initial");
                }
                return initial;
            }
        }

        private static TestReason periodic;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("periodic")]
        public static TestReason Periodic
        {
            get 
            {
                if (periodic == null)
                {
                    periodic = new TestReason("periodic");
                }
                return periodic;
            }
        }

        private static TestReason revision;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("revision")]
        public static TestReason Revision
        {
            get 
            {
                if (revision == null)
                {
                    revision = new TestReason("revision");
                }
                return revision;
            }
        }

        private static TestReason unknown;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TestReason Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new TestReason("unknown");
                }
                return unknown;
            }
        }

        private static TestReason other;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static TestReason Other
        {
            get 
            {
                if (other == null)
                {
                    other = new TestReason("other");
                }
                return other;
            }
        }

    }

    /// <summary>
    /// Keyword for defining keyword-value paris in a time series.
    /// </summary>
    public class TimeSeriesKeyword : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected TimeSeriesKeyword(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the TimeSeriesKeyword</param>
        public TimeSeriesKeyword(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of TimeSeriesKeywords
        /// </summary>
        /// <returns>The complete list of TimeSeriesKeywords</returns>
        public static List<TimeSeriesKeyword> GetList()
        {
            return GetList<TimeSeriesKeyword>();
        }

        private static TimeSeriesKeyword assetIdentifier;
        /// <summary>
        /// A PRODML formatted URI identifier of the asset (facility) related to the value. This captures the kind of asset as well as the unique identifier of the asset within a specified context (the authority). The identifier may define a hierarchy of assets.
        /// </summary>
        [EnumValueNameAttribute("asset identifier")]
        public static TimeSeriesKeyword AssetIdentifier
        {
            get 
            {
                if (assetIdentifier == null)
                {
                    assetIdentifier = new TimeSeriesKeyword("asset identifier");
                    assetIdentifier.Description = "A PRODML formatted URI identifier of the asset (facility) related to the value. This captures the kind of asset as well as the unique identifier of the asset within a specified context (the authority). The identifier may define a hierarchy of assets.";
                }
                return assetIdentifier;
            }
        }

        private static TimeSeriesKeyword qualifier;
        /// <summary>
        /// A qualifier of the meaning of the value. This is used to distinguish between variations of an underlying meaning based on the method of creating the value (e.g., measured versus simulated). The values associated with this keyword must be from the list defined by type FlowQualifier.
        /// </summary>
        [EnumValueNameAttribute("qualifier")]
        public static TimeSeriesKeyword Qualifier
        {
            get 
            {
                if (qualifier == null)
                {
                    qualifier = new TimeSeriesKeyword("qualifier");
                    qualifier.Description = "A qualifier of the meaning of the value. This is used to distinguish between variations of an underlying meaning based on the method of creating the value (e.g., measured versus simulated). The values associated with this keyword must be from the list defined by type FlowQualifier.";
                }
                return qualifier;
            }
        }

        private static TimeSeriesKeyword subqualifier;
        /// <summary>
        /// A specialization of a qualifier. The values associated with this keyword must be from the list defined by type FlowSubQualifier.
        /// </summary>
        [EnumValueNameAttribute("subqualifier")]
        public static TimeSeriesKeyword Subqualifier
        {
            get 
            {
                if (subqualifier == null)
                {
                    subqualifier = new TimeSeriesKeyword("subqualifier");
                    subqualifier.Description = "A specialization of a qualifier. The values associated with this keyword must be from the list defined by type FlowSubQualifier.";
                }
                return subqualifier;
            }
        }

        private static TimeSeriesKeyword product;
        /// <summary>
        /// The type of product that is represented by the value. This is generally used with things like volume or flow rate. It is generally meaningless for things like temperature or pressure. The values associated with this keyword must be from the list defined by type ReportingProduct.
        /// </summary>
        [EnumValueNameAttribute("product")]
        public static TimeSeriesKeyword Product
        {
            get 
            {
                if (product == null)
                {
                    product = new TimeSeriesKeyword("product");
                    product.Description = "The type of product that is represented by the value. This is generally used with things like volume or flow rate. It is generally meaningless for things like temperature or pressure. The values associated with this keyword must be from the list defined by type ReportingProduct.";
                }
                return product;
            }
        }

        private static TimeSeriesKeyword flow;
        /// <summary>
        /// Defines the part of the flow network where the asset is located. This is most useful in situations (e.g., reporting) where detailed knowledge of the network configuration is not needed. Basically, this classifies different segments of the flow network based on its purpose within the context of the whole network. The values associated with this keyword must be from the list defined by type ReportingFlow.
        /// </summary>
        [EnumValueNameAttribute("flow")]
        public static TimeSeriesKeyword Flow
        {
            get 
            {
                if (flow == null)
                {
                    flow = new TimeSeriesKeyword("flow");
                    flow.Description = "Defines the part of the flow network where the asset is located. This is most useful in situations (e.g., reporting) where detailed knowledge of the network configuration is not needed. Basically, this classifies different segments of the flow network based on its purpose within the context of the whole network. The values associated with this keyword must be from the list defined by type ReportingFlow.";
                }
                return flow;
            }
        }

        private static TimeSeriesKeyword unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TimeSeriesKeyword Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new TimeSeriesKeyword("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// A kind of well test validation operation.
    /// </summary>
    public class ValidationOperation : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ValidationOperation(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ValidationOperation</param>
        public ValidationOperation(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ValidationOperations
        /// </summary>
        /// <returns>The complete list of ValidationOperations</returns>
        public static List<ValidationOperation> GetList()
        {
            return GetList<ValidationOperation>();
        }

        private static ValidationOperation acquisitionValidation;
        /// <summary>
        /// Checks against the acquired data.
        /// </summary>
        [EnumValueNameAttribute("acquisition validation")]
        public static ValidationOperation AcquisitionValidation
        {
            get 
            {
                if (acquisitionValidation == null)
                {
                    acquisitionValidation = new ValidationOperation("acquisition validation");
                    acquisitionValidation.Description = "Checks against the acquired data.";
                }
                return acquisitionValidation;
            }
        }

        private static ValidationOperation siteValidation;
        /// <summary>
        /// Checks against site validation criteria.
        /// </summary>
        [EnumValueNameAttribute("site validation")]
        public static ValidationOperation SiteValidation
        {
            get 
            {
                if (siteValidation == null)
                {
                    siteValidation = new ValidationOperation("site validation");
                    siteValidation.Description = "Checks against site validation criteria.";
                }
                return siteValidation;
            }
        }

        private static ValidationOperation allocationValidation;
        /// <summary>
        /// Checks against back-allocation validation criteria.
        /// </summary>
        [EnumValueNameAttribute("allocation validation")]
        public static ValidationOperation AllocationValidation
        {
            get 
            {
                if (allocationValidation == null)
                {
                    allocationValidation = new ValidationOperation("allocation validation");
                    allocationValidation.Description = "Checks against back-allocation validation criteria.";
                }
                return allocationValidation;
            }
        }

        private static ValidationOperation externalQualityAssurance;
        /// <summary>
        /// Checks against external quality assurance criteria. This operation must not have a result of "passed with changes".
        /// </summary>
        [EnumValueNameAttribute("external quality assurance")]
        public static ValidationOperation ExternalQualityAssurance
        {
            get 
            {
                if (externalQualityAssurance == null)
                {
                    externalQualityAssurance = new ValidationOperation("external quality assurance");
                    externalQualityAssurance.Description = "Checks against external quality assurance criteria. This operation must not have a result of \"passed with changes\".";
                }
                return externalQualityAssurance;
            }
        }

        private static ValidationOperation validationResult;
        /// <summary>
        /// The overall status of the test.
        /// </summary>
        [EnumValueNameAttribute("validation result")]
        public static ValidationOperation ValidationResult
        {
            get 
            {
                if (validationResult == null)
                {
                    validationResult = new ValidationOperation("validation result");
                    validationResult.Description = "The overall status of the test.";
                }
                return validationResult;
            }
        }

        private static ValidationOperation wellModelValidation;
        /// <summary>
        /// Checks against a well model. This operation must not have a result of "passed with changes".
        /// </summary>
        [EnumValueNameAttribute("well model validation")]
        public static ValidationOperation WellModelValidation
        {
            get 
            {
                if (wellModelValidation == null)
                {
                    wellModelValidation = new ValidationOperation("well model validation");
                    wellModelValidation.Description = "Checks against a well model. This operation must not have a result of \"passed with changes\".";
                }
                return wellModelValidation;
            }
        }

        private static ValidationOperation unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValidationOperation Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ValidationOperation("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// A result of a well test validation operation.
    /// </summary>
    public class ValidationResult : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ValidationResult(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ValidationResult</param>
        public ValidationResult(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ValidationResults
        /// </summary>
        /// <returns>The complete list of ValidationResults</returns>
        public static List<ValidationResult> GetList()
        {
            return GetList<ValidationResult>();
        }

        private static ValidationResult passed;
        /// <summary>
        /// The well test passed the validation criteria without modification of the data.
        /// </summary>
        [EnumValueNameAttribute("passed")]
        public static ValidationResult Passed
        {
            get 
            {
                if (passed == null)
                {
                    passed = new ValidationResult("passed");
                    passed.Description = "The well test passed the validation criteria without modification of the data.";
                }
                return passed;
            }
        }

        private static ValidationResult passedWithChanges;
        /// <summary>
        /// The well test passed the validation criteria after modification of the data.
        /// </summary>
        [EnumValueNameAttribute("passed with changes")]
        public static ValidationResult PassedWithChanges
        {
            get 
            {
                if (passedWithChanges == null)
                {
                    passedWithChanges = new ValidationResult("passed with changes");
                    passedWithChanges.Description = "The well test passed the validation criteria after modification of the data.";
                }
                return passedWithChanges;
            }
        }

        private static ValidationResult failed;
        /// <summary>
        /// The well test failed the validation criteria.
        /// </summary>
        [EnumValueNameAttribute("failed")]
        public static ValidationResult Failed
        {
            get 
            {
                if (failed == null)
                {
                    failed = new ValidationResult("failed");
                    failed.Description = "The well test failed the validation criteria.";
                }
                return failed;
            }
        }

        private static ValidationResult unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValidationResult Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ValidationResult("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// An overall state of all well test validation operations.
    /// </summary>
    public class ValidationState : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ValidationState(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ValidationState</param>
        public ValidationState(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ValidationStates
        /// </summary>
        /// <returns>The complete list of ValidationStates</returns>
        public static List<ValidationState> GetList()
        {
            return GetList<ValidationState>();
        }

        private static ValidationState unvalidated;
        /// <summary>
        /// The well test has not yet begun validation operations.
        /// </summary>
        [EnumValueNameAttribute("unvalidated")]
        public static ValidationState Unvalidated
        {
            get 
            {
                if (unvalidated == null)
                {
                    unvalidated = new ValidationState("unvalidated");
                    unvalidated.Description = "The well test has not yet begun validation operations.";
                }
                return unvalidated;
            }
        }

        private static ValidationState validating;
        /// <summary>
        /// The well test is in the process of being validated.
        /// </summary>
        [EnumValueNameAttribute("validating")]
        public static ValidationState Validating
        {
            get 
            {
                if (validating == null)
                {
                    validating = new ValidationState("validating");
                    validating.Description = "The well test is in the process of being validated.";
                }
                return validating;
            }
        }

        private static ValidationState validated;
        /// <summary>
        /// The well test has completed validation operations. This does not mean that the test is valid - only that the validation steps have been completed.
        /// </summary>
        [EnumValueNameAttribute("validated")]
        public static ValidationState Validated
        {
            get 
            {
                if (validated == null)
                {
                    validated = new ValidationState("validated");
                    validated.Description = "The well test has completed validation operations. This does not mean that the test is valid - only that the validation steps have been completed.";
                }
                return validated;
            }
        }

        private static ValidationState unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValidationState Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ValidationState("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// An indicator of the quality of a value.
    ///			This is designed for a SCADA or OPC style of value stasus.
    ///			The token in parentheses are OPC's status string for the condition.
    /// </summary>
    public class ValueStatus : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ValueStatus(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the ValueStatus</param>
        public ValueStatus(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of ValueStatuss
        /// </summary>
        /// <returns>The complete list of ValueStatuss</returns>
        public static List<ValueStatus> GetList()
        {
            return GetList<ValueStatus>();
        }

        private static ValueStatus badCalibration;
        /// <summary>
        /// The calibration status of the sensor is unknown. (Out of Calibration)
        /// </summary>
        [EnumValueNameAttribute("bad calibration")]
        public static ValueStatus BadCalibration
        {
            get 
            {
                if (badCalibration == null)
                {
                    badCalibration = new ValueStatus("bad calibration");
                    badCalibration.Description = "The calibration status of the sensor is unknown. (Out of Calibration)";
                }
                return badCalibration;
            }
        }

        private static ValueStatus rangeLimit;
        /// <summary>
        /// The value is range limited, that is, at or near the end of range of the sensor. The value might be clamped. (Low Limited, High Limited)
        /// </summary>
        [EnumValueNameAttribute("range limit")]
        public static ValueStatus RangeLimit
        {
            get 
            {
                if (rangeLimit == null)
                {
                    rangeLimit = new ValueStatus("range limit");
                    rangeLimit.Description = "The value is range limited, that is, at or near the end of range of the sensor. The value might be clamped. (Low Limited, High Limited)";
                }
                return rangeLimit;
            }
        }

        private static ValueStatus questionable;
        /// <summary>
        /// The value is just plain questionable. (Sub-Normal, Non-specific)
        /// </summary>
        [EnumValueNameAttribute("questionable")]
        public static ValueStatus Questionable
        {
            get 
            {
                if (questionable == null)
                {
                    questionable = new ValueStatus("questionable");
                    questionable.Description = "The value is just plain questionable. (Sub-Normal, Non-specific)";
                }
                return questionable;
            }
        }

        private static ValueStatus deviceFailure;
        /// <summary>
        /// The unit to which the sensor is attached is not running. (Device Failure)
        /// </summary>
        [EnumValueNameAttribute("device failure")]
        public static ValueStatus DeviceFailure
        {
            get 
            {
                if (deviceFailure == null)
                {
                    deviceFailure = new ValueStatus("device failure");
                    deviceFailure.Description = "The unit to which the sensor is attached is not running. (Device Failure)";
                }
                return deviceFailure;
            }
        }

        private static ValueStatus sensorFailure;
        /// <summary>
        /// The field sensor itself is not working due to hardware failure or misconfiguration. (Sensor Failure)
        /// </summary>
        [EnumValueNameAttribute("sensor failure")]
        public static ValueStatus SensorFailure
        {
            get 
            {
                if (sensorFailure == null)
                {
                    sensorFailure = new ValueStatus("sensor failure");
                    sensorFailure.Description = "The field sensor itself is not working due to hardware failure or misconfiguration. (Sensor Failure)";
                }
                return sensorFailure;
            }
        }

        private static ValueStatus commFailure;
        /// <summary>
        /// The communication to the field sensor is not working. That is, communcation cannot be established or maintained. (Comm Failure)
        /// </summary>
        [EnumValueNameAttribute("comm failure")]
        public static ValueStatus CommFailure
        {
            get 
            {
                if (commFailure == null)
                {
                    commFailure = new ValueStatus("comm failure");
                    commFailure.Description = "The communication to the field sensor is not working. That is, communcation cannot be established or maintained. (Comm Failure)";
                }
                return commFailure;
            }
        }

        private static ValueStatus timeout;
        /// <summary>
        /// Communication to the field sensor has timed out, that is, a connection exists, but a request for a field sensor data value has failed. (Last Known Value)
        /// </summary>
        [EnumValueNameAttribute("timeout")]
        public static ValueStatus Timeout
        {
            get 
            {
                if (timeout == null)
                {
                    timeout = new ValueStatus("timeout");
                    timeout.Description = "Communication to the field sensor has timed out, that is, a connection exists, but a request for a field sensor data value has failed. (Last Known Value)";
                }
                return timeout;
            }
        }

        private static ValueStatus unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValueStatus Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new ValueStatus("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// xxxxxxxxxxxx
    /// </summary>
    public class VolumeReferenceKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected VolumeReferenceKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the VolumeReferenceKind</param>
        public VolumeReferenceKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of VolumeReferenceKinds
        /// </summary>
        /// <returns>The complete list of VolumeReferenceKinds</returns>
        public static List<VolumeReferenceKind> GetList()
        {
            return GetList<VolumeReferenceKind>();
        }

        private static VolumeReferenceKind initialReservoir;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("initial reservoir")]
        public static VolumeReferenceKind InitialReservoir
        {
            get 
            {
                if (initialReservoir == null)
                {
                    initialReservoir = new VolumeReferenceKind("initial reservoir");
                    initialReservoir.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return initialReservoir;
            }
        }

        private static VolumeReferenceKind saturationmeasured;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("saturation-measured")]
        public static VolumeReferenceKind Saturationmeasured
        {
            get 
            {
                if (saturationmeasured == null)
                {
                    saturationmeasured = new VolumeReferenceKind("saturation-measured");
                    saturationmeasured.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return saturationmeasured;
            }
        }

        private static VolumeReferenceKind saturationcalculated;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("saturation-calculated")]
        public static VolumeReferenceKind Saturationcalculated
        {
            get 
            {
                if (saturationcalculated == null)
                {
                    saturationcalculated = new VolumeReferenceKind("saturation-calculated");
                    saturationcalculated.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return saturationcalculated;
            }
        }

        private static VolumeReferenceKind stockTank;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("stock tank")]
        public static VolumeReferenceKind StockTank
        {
            get 
            {
                if (stockTank == null)
                {
                    stockTank = new VolumeReferenceKind("stock tank");
                    stockTank.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return stockTank;
            }
        }

        private static VolumeReferenceKind currentSeparatorStage;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("current separator stage")]
        public static VolumeReferenceKind CurrentSeparatorStage
        {
            get 
            {
                if (currentSeparatorStage == null)
                {
                    currentSeparatorStage = new VolumeReferenceKind("current separator stage");
                    currentSeparatorStage.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return currentSeparatorStage;
            }
        }

        private static VolumeReferenceKind separatorStageOne;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 1")]
        public static VolumeReferenceKind SeparatorStageOne
        {
            get 
            {
                if (separatorStageOne == null)
                {
                    separatorStageOne = new VolumeReferenceKind("separator stage 1");
                    separatorStageOne.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOne;
            }
        }

        private static VolumeReferenceKind separatorStageTwo;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 2")]
        public static VolumeReferenceKind SeparatorStageTwo
        {
            get 
            {
                if (separatorStageTwo == null)
                {
                    separatorStageTwo = new VolumeReferenceKind("separator stage 2");
                    separatorStageTwo.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwo;
            }
        }

        private static VolumeReferenceKind separatorStageThree;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 3")]
        public static VolumeReferenceKind SeparatorStageThree
        {
            get 
            {
                if (separatorStageThree == null)
                {
                    separatorStageThree = new VolumeReferenceKind("separator stage 3");
                    separatorStageThree.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageThree;
            }
        }

        private static VolumeReferenceKind separatorStageFour;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 4")]
        public static VolumeReferenceKind SeparatorStageFour
        {
            get 
            {
                if (separatorStageFour == null)
                {
                    separatorStageFour = new VolumeReferenceKind("separator stage 4");
                    separatorStageFour.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageFour;
            }
        }

        private static VolumeReferenceKind separatorStageFive;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 5")]
        public static VolumeReferenceKind SeparatorStageFive
        {
            get 
            {
                if (separatorStageFive == null)
                {
                    separatorStageFive = new VolumeReferenceKind("separator stage 5");
                    separatorStageFive.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageFive;
            }
        }

        private static VolumeReferenceKind separatorStageSix;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 6")]
        public static VolumeReferenceKind SeparatorStageSix
        {
            get 
            {
                if (separatorStageSix == null)
                {
                    separatorStageSix = new VolumeReferenceKind("separator stage 6");
                    separatorStageSix.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageSix;
            }
        }

        private static VolumeReferenceKind separatorStageSeven;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 7")]
        public static VolumeReferenceKind SeparatorStageSeven
        {
            get 
            {
                if (separatorStageSeven == null)
                {
                    separatorStageSeven = new VolumeReferenceKind("separator stage 7");
                    separatorStageSeven.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageSeven;
            }
        }

        private static VolumeReferenceKind separatorStageEight;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 8")]
        public static VolumeReferenceKind SeparatorStageEight
        {
            get 
            {
                if (separatorStageEight == null)
                {
                    separatorStageEight = new VolumeReferenceKind("separator stage 8");
                    separatorStageEight.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageEight;
            }
        }

        private static VolumeReferenceKind separatorStageNine;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 9")]
        public static VolumeReferenceKind SeparatorStageNine
        {
            get 
            {
                if (separatorStageNine == null)
                {
                    separatorStageNine = new VolumeReferenceKind("separator stage 9");
                    separatorStageNine.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageNine;
            }
        }

        private static VolumeReferenceKind separatorStageOneZero;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 10")]
        public static VolumeReferenceKind SeparatorStageOneZero
        {
            get 
            {
                if (separatorStageOneZero == null)
                {
                    separatorStageOneZero = new VolumeReferenceKind("separator stage 10");
                    separatorStageOneZero.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneZero;
            }
        }

        private static VolumeReferenceKind separatorStageOneOne;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 11")]
        public static VolumeReferenceKind SeparatorStageOneOne
        {
            get 
            {
                if (separatorStageOneOne == null)
                {
                    separatorStageOneOne = new VolumeReferenceKind("separator stage 11");
                    separatorStageOneOne.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneOne;
            }
        }

        private static VolumeReferenceKind separatorStageOneTwo;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 12")]
        public static VolumeReferenceKind SeparatorStageOneTwo
        {
            get 
            {
                if (separatorStageOneTwo == null)
                {
                    separatorStageOneTwo = new VolumeReferenceKind("separator stage 12");
                    separatorStageOneTwo.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneTwo;
            }
        }

        private static VolumeReferenceKind separatorStageOneThree;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 13")]
        public static VolumeReferenceKind SeparatorStageOneThree
        {
            get 
            {
                if (separatorStageOneThree == null)
                {
                    separatorStageOneThree = new VolumeReferenceKind("separator stage 13");
                    separatorStageOneThree.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneThree;
            }
        }

        private static VolumeReferenceKind separatorStageOneFour;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 14")]
        public static VolumeReferenceKind SeparatorStageOneFour
        {
            get 
            {
                if (separatorStageOneFour == null)
                {
                    separatorStageOneFour = new VolumeReferenceKind("separator stage 14");
                    separatorStageOneFour.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneFour;
            }
        }

        private static VolumeReferenceKind separatorStageOneFive;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 15")]
        public static VolumeReferenceKind SeparatorStageOneFive
        {
            get 
            {
                if (separatorStageOneFive == null)
                {
                    separatorStageOneFive = new VolumeReferenceKind("separator stage 15");
                    separatorStageOneFive.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneFive;
            }
        }

        private static VolumeReferenceKind separatorStageOneSix;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 16")]
        public static VolumeReferenceKind SeparatorStageOneSix
        {
            get 
            {
                if (separatorStageOneSix == null)
                {
                    separatorStageOneSix = new VolumeReferenceKind("separator stage 16");
                    separatorStageOneSix.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneSix;
            }
        }

        private static VolumeReferenceKind separatorStageOneSeven;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 17")]
        public static VolumeReferenceKind SeparatorStageOneSeven
        {
            get 
            {
                if (separatorStageOneSeven == null)
                {
                    separatorStageOneSeven = new VolumeReferenceKind("separator stage 17");
                    separatorStageOneSeven.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneSeven;
            }
        }

        private static VolumeReferenceKind separatorStageOneEight;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 18")]
        public static VolumeReferenceKind SeparatorStageOneEight
        {
            get 
            {
                if (separatorStageOneEight == null)
                {
                    separatorStageOneEight = new VolumeReferenceKind("separator stage 18");
                    separatorStageOneEight.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneEight;
            }
        }

        private static VolumeReferenceKind separatorStageOneNine;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 19")]
        public static VolumeReferenceKind SeparatorStageOneNine
        {
            get 
            {
                if (separatorStageOneNine == null)
                {
                    separatorStageOneNine = new VolumeReferenceKind("separator stage 19");
                    separatorStageOneNine.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageOneNine;
            }
        }

        private static VolumeReferenceKind separatorStageTwoZero;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 20")]
        public static VolumeReferenceKind SeparatorStageTwoZero
        {
            get 
            {
                if (separatorStageTwoZero == null)
                {
                    separatorStageTwoZero = new VolumeReferenceKind("separator stage 20");
                    separatorStageTwoZero.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoZero;
            }
        }

        private static VolumeReferenceKind separatorStageTwoOne;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 21")]
        public static VolumeReferenceKind SeparatorStageTwoOne
        {
            get 
            {
                if (separatorStageTwoOne == null)
                {
                    separatorStageTwoOne = new VolumeReferenceKind("separator stage 21");
                    separatorStageTwoOne.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoOne;
            }
        }

        private static VolumeReferenceKind separatorStageTwoTwo;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 22")]
        public static VolumeReferenceKind SeparatorStageTwoTwo
        {
            get 
            {
                if (separatorStageTwoTwo == null)
                {
                    separatorStageTwoTwo = new VolumeReferenceKind("separator stage 22");
                    separatorStageTwoTwo.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoTwo;
            }
        }

        private static VolumeReferenceKind separatorStageTwoThree;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 23")]
        public static VolumeReferenceKind SeparatorStageTwoThree
        {
            get 
            {
                if (separatorStageTwoThree == null)
                {
                    separatorStageTwoThree = new VolumeReferenceKind("separator stage 23");
                    separatorStageTwoThree.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoThree;
            }
        }

        private static VolumeReferenceKind separatorStageTwoFour;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 24")]
        public static VolumeReferenceKind SeparatorStageTwoFour
        {
            get 
            {
                if (separatorStageTwoFour == null)
                {
                    separatorStageTwoFour = new VolumeReferenceKind("separator stage 24");
                    separatorStageTwoFour.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoFour;
            }
        }

        private static VolumeReferenceKind separatorStageTwoFive;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 25")]
        public static VolumeReferenceKind SeparatorStageTwoFive
        {
            get 
            {
                if (separatorStageTwoFive == null)
                {
                    separatorStageTwoFive = new VolumeReferenceKind("separator stage 25");
                    separatorStageTwoFive.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoFive;
            }
        }

        private static VolumeReferenceKind separatorStageTwoSix;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 26")]
        public static VolumeReferenceKind SeparatorStageTwoSix
        {
            get 
            {
                if (separatorStageTwoSix == null)
                {
                    separatorStageTwoSix = new VolumeReferenceKind("separator stage 26");
                    separatorStageTwoSix.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoSix;
            }
        }

        private static VolumeReferenceKind separatorStageTwoSeven;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 27")]
        public static VolumeReferenceKind SeparatorStageTwoSeven
        {
            get 
            {
                if (separatorStageTwoSeven == null)
                {
                    separatorStageTwoSeven = new VolumeReferenceKind("separator stage 27");
                    separatorStageTwoSeven.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoSeven;
            }
        }

        private static VolumeReferenceKind separatorStageTwoEight;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 28")]
        public static VolumeReferenceKind SeparatorStageTwoEight
        {
            get 
            {
                if (separatorStageTwoEight == null)
                {
                    separatorStageTwoEight = new VolumeReferenceKind("separator stage 28");
                    separatorStageTwoEight.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoEight;
            }
        }

        private static VolumeReferenceKind separatorStageTwoNine;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 29")]
        public static VolumeReferenceKind SeparatorStageTwoNine
        {
            get 
            {
                if (separatorStageTwoNine == null)
                {
                    separatorStageTwoNine = new VolumeReferenceKind("separator stage 29");
                    separatorStageTwoNine.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageTwoNine;
            }
        }

        private static VolumeReferenceKind separatorStageThreeZero;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("separator stage 30")]
        public static VolumeReferenceKind SeparatorStageThreeZero
        {
            get 
            {
                if (separatorStageThreeZero == null)
                {
                    separatorStageThreeZero = new VolumeReferenceKind("separator stage 30");
                    separatorStageThreeZero.Description = "xxxxxxxxxxxxxxxxxx";
                }
                return separatorStageThreeZero;
            }
        }

        private static VolumeReferenceKind unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static VolumeReferenceKind Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new VolumeReferenceKind("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

    /// <summary>
    /// Kind of lift method for producing a well.
    /// </summary>
    public class WellOperationMethod : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected WellOperationMethod(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the WellOperationMethod</param>
        public WellOperationMethod(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of WellOperationMethods
        /// </summary>
        /// <returns>The complete list of WellOperationMethods</returns>
        public static List<WellOperationMethod> GetList()
        {
            return GetList<WellOperationMethod>();
        }

        private static WellOperationMethod naturalFlow;
        /// <summary>
        /// Oil or gas well under natural flow.
        /// </summary>
        [EnumValueNameAttribute("natural flow")]
        public static WellOperationMethod NaturalFlow
        {
            get 
            {
                if (naturalFlow == null)
                {
                    naturalFlow = new WellOperationMethod("natural flow");
                    naturalFlow.Description = "Oil or gas well under natural flow.";
                }
                return naturalFlow;
            }
        }

        private static WellOperationMethod continuousGasLift;
        /// <summary>
        /// Oil well under continous gas lift.
        /// </summary>
        [EnumValueNameAttribute("continuous gas lift")]
        public static WellOperationMethod ContinuousGasLift
        {
            get 
            {
                if (continuousGasLift == null)
                {
                    continuousGasLift = new WellOperationMethod("continuous gas lift");
                    continuousGasLift.Description = "Oil well under continous gas lift.";
                }
                return continuousGasLift;
            }
        }

        private static WellOperationMethod intermittentGasLift;
        /// <summary>
        /// Oil well under intermittent gas lift.
        /// </summary>
        [EnumValueNameAttribute("intermittent gas lift")]
        public static WellOperationMethod IntermittentGasLift
        {
            get 
            {
                if (intermittentGasLift == null)
                {
                    intermittentGasLift = new WellOperationMethod("intermittent gas lift");
                    intermittentGasLift.Description = "Oil well under intermittent gas lift.";
                }
                return intermittentGasLift;
            }
        }

        private static WellOperationMethod plungerGasLift;
        /// <summary>
        /// Oil or gas well under plunger gas lift.
        /// </summary>
        [EnumValueNameAttribute("plunger gas lift")]
        public static WellOperationMethod PlungerGasLift
        {
            get 
            {
                if (plungerGasLift == null)
                {
                    plungerGasLift = new WellOperationMethod("plunger gas lift");
                    plungerGasLift.Description = "Oil or gas well under plunger gas lift.";
                }
                return plungerGasLift;
            }
        }

        private static WellOperationMethod electricSubmersiblePumpLift;
        /// <summary>
        /// Oil well under electric submersible pump lift.
        /// </summary>
        [EnumValueNameAttribute("electric submersible pump lift")]
        public static WellOperationMethod ElectricSubmersiblePumpLift
        {
            get 
            {
                if (electricSubmersiblePumpLift == null)
                {
                    electricSubmersiblePumpLift = new WellOperationMethod("electric submersible pump lift");
                    electricSubmersiblePumpLift.Description = "Oil well under electric submersible pump lift.";
                }
                return electricSubmersiblePumpLift;
            }
        }

        private static WellOperationMethod progressiveCavityPumpLift;
        /// <summary>
        /// Oil well under progressive cavity pump lift.
        /// </summary>
        [EnumValueNameAttribute("progressive cavity pump lift")]
        public static WellOperationMethod ProgressiveCavityPumpLift
        {
            get 
            {
                if (progressiveCavityPumpLift == null)
                {
                    progressiveCavityPumpLift = new WellOperationMethod("progressive cavity pump lift");
                    progressiveCavityPumpLift.Description = "Oil well under progressive cavity pump lift.";
                }
                return progressiveCavityPumpLift;
            }
        }

        private static WellOperationMethod hydraulicPumpLift;
        /// <summary>
        /// Oil well under hydraulic pump lift.
        /// </summary>
        [EnumValueNameAttribute("hydraulic pump lift")]
        public static WellOperationMethod HydraulicPumpLift
        {
            get 
            {
                if (hydraulicPumpLift == null)
                {
                    hydraulicPumpLift = new WellOperationMethod("hydraulic pump lift");
                    hydraulicPumpLift.Description = "Oil well under hydraulic pump lift.";
                }
                return hydraulicPumpLift;
            }
        }

        private static WellOperationMethod suckerRodPumpLift;
        /// <summary>
        /// Oil well under sucker rod pump lift.
        /// </summary>
        [EnumValueNameAttribute("sucker rod pump lift")]
        public static WellOperationMethod SuckerRodPumpLift
        {
            get 
            {
                if (suckerRodPumpLift == null)
                {
                    suckerRodPumpLift = new WellOperationMethod("sucker rod pump lift");
                    suckerRodPumpLift.Description = "Oil well under sucker rod pump lift.";
                }
                return suckerRodPumpLift;
            }
        }

        private static WellOperationMethod jetPumpLift;
        /// <summary>
        /// Oil well under jet pump lift.
        /// </summary>
        [EnumValueNameAttribute("jet pump lift")]
        public static WellOperationMethod JetPumpLift
        {
            get 
            {
                if (jetPumpLift == null)
                {
                    jetPumpLift = new WellOperationMethod("jet pump lift");
                    jetPumpLift.Description = "Oil well under jet pump lift.";
                }
                return jetPumpLift;
            }
        }

        private static WellOperationMethod foamLift;
        /// <summary>
        /// Gas well under foam lift.
        /// </summary>
        [EnumValueNameAttribute("foam lift")]
        public static WellOperationMethod FoamLift
        {
            get 
            {
                if (foamLift == null)
                {
                    foamLift = new WellOperationMethod("foam lift");
                    foamLift.Description = "Gas well under foam lift.";
                }
                return foamLift;
            }
        }

        private static WellOperationMethod unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WellOperationMethod Unknown
        {
            get 
            {
                if (unknown == null)
                {
                    unknown = new WellOperationMethod("unknown");
                    unknown.Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.";
                }
                return unknown;
            }
        }

    }

}
