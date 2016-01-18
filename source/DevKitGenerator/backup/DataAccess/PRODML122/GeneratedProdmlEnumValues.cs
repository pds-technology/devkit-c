using System;
using Energistics.DataAccess.EnumValue;
using System.Collections.Generic;

namespace Energistics.DataAccess.PRODML122
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

        private readonly static AddressKindEnum mailing;
        /// <summary>
        /// The mailing address of a business associate or facility.
        /// </summary>
        [EnumValueNameAttribute("mailing")]
        public static AddressKindEnum Mailing
        {
            get 
            {
                return mailing;
            }
        }

        private readonly static AddressKindEnum physical;
        /// <summary>
        /// The physical address - location - of a business associate or facility.
        /// </summary>
        [EnumValueNameAttribute("physical")]
        public static AddressKindEnum Physical
        {
            get 
            {
                return physical;
            }
        }

        private readonly static AddressKindEnum both;
        /// <summary>
        /// Both the mailing address and the physical address.
        /// </summary>
        [EnumValueNameAttribute("both")]
        public static AddressKindEnum Both
        {
            get 
            {
                return both;
            }
        }

        private readonly static AddressKindEnum unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static AddressKindEnum Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static AddressKindEnum()
        {
            mailing = 
                new AddressKindEnum("mailing")
                {
                    Description = "The mailing address of a business associate or facility."
            };
            physical = 
                new AddressKindEnum("physical")
                {
                    Description = "The physical address - location - of a business associate or facility."
            };
            both = 
                new AddressKindEnum("both")
                {
                    Description = "Both the mailing address and the physical address."
            };
            unknown = 
                new AddressKindEnum("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a AddressKindEnum by name
        /// </summary>
        /// <param name="name">The name of the AddressKindEnum to return</param>
        /// <returns>The AddressKindEnum represented by 'name'</returns>
        public static AddressKindEnum GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(AddressKindEnum)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(AddressKindEnum)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (AddressKindEnum)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			What kind of email (or phone) is this? Is it a
    ///			work phone? Or personal? Or is a permanent one?
    ///		
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

        private readonly static AddressQualifier personal;
        /// <summary>
        ///  The phone number or email address is personal, and can probably be received at the business associates home. 
        /// </summary>
        [EnumValueNameAttribute("personal")]
        public static AddressQualifier Personal
        {
            get 
            {
                return personal;
            }
        }

        private readonly static AddressQualifier work;
        /// <summary>
        ///  The phone number or email is a work number, which is subject to change if the business associate changes jobs. 
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static AddressQualifier Work
        {
            get 
            {
                return work;
            }
        }

        private readonly static AddressQualifier permanent;
        /// <summary>
        ///  The phone number or email is permanent, which will still be valid if the person changes home or work locations. 
        /// </summary>
        [EnumValueNameAttribute("permanent")]
        public static AddressQualifier Permanent
        {
            get 
            {
                return permanent;
            }
        }

        private readonly static AddressQualifier unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static AddressQualifier Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static AddressQualifier()
        {
            personal = 
                new AddressQualifier("personal")
                {
                    Description = " The phone number or email address is personal, and can probably be received at the business associates home. "
            };
            work = 
                new AddressQualifier("work")
                {
                    Description = " The phone number or email is a work number, which is subject to change if the business associate changes jobs. "
            };
            permanent = 
                new AddressQualifier("permanent")
                {
                    Description = " The phone number or email is permanent, which will still be valid if the person changes home or work locations. "
            };
            unknown = 
                new AddressQualifier("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a AddressQualifier by name
        /// </summary>
        /// <param name="name">The name of the AddressQualifier to return</param>
        /// <returns>The AddressQualifier represented by 'name'</returns>
        public static AddressQualifier GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(AddressQualifier)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(AddressQualifier)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (AddressQualifier)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static BalanceDestinationType harbor;
        /// <summary>
        /// Defines the name of the destination harbor
        /// </summary>
        [EnumValueNameAttribute("harbor")]
        public static BalanceDestinationType Harbor
        {
            get 
            {
                return harbor;
            }
        }

        private readonly static BalanceDestinationType terminal;
        /// <summary>
        /// Defines the name of the destination terminal
        /// </summary>
        [EnumValueNameAttribute("terminal")]
        public static BalanceDestinationType Terminal
        {
            get 
            {
                return terminal;
            }
        }

        private readonly static BalanceDestinationType unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BalanceDestinationType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static BalanceDestinationType()
        {
            harbor = 
                new BalanceDestinationType("harbor")
                {
                    Description = "Defines the name of the destination harbor"
            };
            terminal = 
                new BalanceDestinationType("terminal")
                {
                    Description = "Defines the name of the destination terminal"
            };
            unknown = 
                new BalanceDestinationType("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a BalanceDestinationType by name
        /// </summary>
        /// <param name="name">The name of the BalanceDestinationType to return</param>
        /// <returns>The BalanceDestinationType represented by 'name'</returns>
        public static BalanceDestinationType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(BalanceDestinationType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(BalanceDestinationType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (BalanceDestinationType)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines a type of event related to a product balance by reference to its date.
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

        private readonly static BalanceEventKind billOfLading;
        /// <summary>
        /// For a cargo, the date of the bill of lading for the cargo involved.
        /// </summary>
        [EnumValueNameAttribute("bill of lading")]
        public static BalanceEventKind BillOfLading
        {
            get 
            {
                return billOfLading;
            }
        }

        private readonly static BalanceEventKind transactionDate;
        /// <summary>
        /// For a transaction (e.g. gas sales transaction), the date for the transaction involved.
        /// </summary>
        [EnumValueNameAttribute("transaction date")]
        public static BalanceEventKind TransactionDate
        {
            get 
            {
                return transactionDate;
            }
        }

        private readonly static BalanceEventKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BalanceEventKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static BalanceEventKind()
        {
            billOfLading = 
                new BalanceEventKind("bill of lading")
                {
                    Description = "For a cargo, the date of the bill of lading for the cargo involved."
            };
            transactionDate = 
                new BalanceEventKind("transaction date")
                {
                    Description = "For a transaction (e.g. gas sales transaction), the date for the transaction involved."
            };
            unknown = 
                new BalanceEventKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a BalanceEventKind by name
        /// </summary>
        /// <param name="name">The name of the BalanceEventKind to return</param>
        /// <returns>The BalanceEventKind represented by 'name'</returns>
        public static BalanceEventKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(BalanceEventKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(BalanceEventKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (BalanceEventKind)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static BalanceFlowPart openingBalance;
        /// <summary>
        ///  A volume that is the total volume on stock at the beginning of a time period. 
        /// </summary>
        [EnumValueNameAttribute("opening balance")]
        public static BalanceFlowPart OpeningBalance
        {
            get 
            {
                return openingBalance;
            }
        }

        private readonly static BalanceFlowPart closingBalance;
        /// <summary>
        ///  A volume that is the total volume on stock at the end of a time period. 
        /// </summary>
        [EnumValueNameAttribute("closing balance")]
        public static BalanceFlowPart ClosingBalance
        {
            get 
            {
                return closingBalance;
            }
        }

        private readonly static BalanceFlowPart inputToStorage;
        /// <summary>
        ///  A volume that is the total volume of additions to a stock within a given time period. 
        /// </summary>
        [EnumValueNameAttribute("input to storage")]
        public static BalanceFlowPart InputToStorage
        {
            get 
            {
                return inputToStorage;
            }
        }

        private readonly static BalanceFlowPart liftingEntitlement;
        /// <summary>
        /// A volume that is the contracted volume which can be transferred
        /// </summary>
        [EnumValueNameAttribute("lifting entitlement")]
        public static BalanceFlowPart LiftingEntitlement
        {
            get 
            {
                return liftingEntitlement;
            }
        }

        private readonly static BalanceFlowPart liftingEntitlementRemaining;
        /// <summary>
        /// A volume that is the contracted volume which is not transferred but which remains available for subsequent transfer
        /// </summary>
        [EnumValueNameAttribute("lifting entitlement remaining")]
        public static BalanceFlowPart LiftingEntitlementRemaining
        {
            get 
            {
                return liftingEntitlementRemaining;
            }
        }

        private readonly static BalanceFlowPart gainloss;
        /// <summary>
        ///  A volume that is a lack of proper proportion or relation between the corresponding input and liftings transactions. 
        /// </summary>
        [EnumValueNameAttribute("gain/loss")]
        public static BalanceFlowPart Gainloss
        {
            get 
            {
                return gainloss;
            }
        }

        private readonly static BalanceFlowPart adjustedClosing;
        /// <summary>
        /// A volume that remains after the operation of transfer
        /// </summary>
        [EnumValueNameAttribute("adjusted closing")]
        public static BalanceFlowPart AdjustedClosing
        {
            get 
            {
                return adjustedClosing;
            }
        }

        private readonly static BalanceFlowPart lifted;
        /// <summary>
        /// A volume that is transferred ("lifted")
        /// </summary>
        [EnumValueNameAttribute("lifted")]
        public static BalanceFlowPart Lifted
        {
            get 
            {
                return lifted;
            }
        }

        private readonly static BalanceFlowPart productionValueAdjustment;
        /// <summary>
        /// A value that is adjusted due to a change in the value of a product.
        /// </summary>
        [EnumValueNameAttribute("production -- value adjustment")]
        public static BalanceFlowPart ProductionValueAdjustment
        {
            get 
            {
                return productionValueAdjustment;
            }
        }

        private readonly static BalanceFlowPart transaction;
        /// <summary>
        ///  Typically used within the cargo shipper operations and in this context is a change in ownership as executed between shippers of the cargo. 
        /// </summary>
        [EnumValueNameAttribute("transaction")]
        public static BalanceFlowPart Transaction
        {
            get 
            {
                return transaction;
            }
        }

        private readonly static BalanceFlowPart completedLifting;
        /// <summary>
        ///  A volume that is the total volume of a hydrocarbon product that is exported from a stock within a given time period. 
        /// </summary>
        [EnumValueNameAttribute("completed lifting")]
        public static BalanceFlowPart CompletedLifting
        {
            get 
            {
                return completedLifting;
            }
        }

        private readonly static BalanceFlowPart productionImbalance;
        /// <summary>
        ///  A gas volume that is the difference between gas volume entering and exiting a shipper's nomination portfolio. This will take into account all differences whatever the time or reason it occurs. 
        /// </summary>
        [EnumValueNameAttribute("production imbalance")]
        public static BalanceFlowPart ProductionImbalance
        {
            get 
            {
                return productionImbalance;
            }
        }

        private readonly static BalanceFlowPart partialLifting;
        /// <summary>
        ///  A volume that is the volume of a hydrocarbon product lifting up to a (not completed) determined point in time. 
        /// </summary>
        [EnumValueNameAttribute("partial lifting")]
        public static BalanceFlowPart PartialLifting
        {
            get 
            {
                return partialLifting;
            }
        }

        private readonly static BalanceFlowPart closingStorageInventory;
        /// <summary>
        ///  A closing storage balance that is adjusted according to imbalance at end of period. 
        /// </summary>
        [EnumValueNameAttribute("closing storage inventory")]
        public static BalanceFlowPart ClosingStorageInventory
        {
            get 
            {
                return closingStorageInventory;
            }
        }

        private readonly static BalanceFlowPart tankerLifting;
        /// <summary>
        ///  A volume that is the volume of a hydrocarbon product lifting transferred by tanker 
        /// </summary>
        [EnumValueNameAttribute("tanker lifting")]
        public static BalanceFlowPart TankerLifting
        {
            get 
            {
                return tankerLifting;
            }
        }

        private readonly static BalanceFlowPart pipelineLifting;
        /// <summary>
        ///  A volume that is the volume of a hydrocarbon product lifting transferred by pipeline 
        /// </summary>
        [EnumValueNameAttribute("pipeline lifting")]
        public static BalanceFlowPart PipelineLifting
        {
            get 
            {
                return pipelineLifting;
            }
        }

        private readonly static BalanceFlowPart opflex;
        /// <summary>
        ///  A gas volume that is the unused and available quantity of gas within a gas transportation system and/or at one or many gas producing fields that is accessible by the operator responsible for gas transportation for the purposes of alleviating field curtailment. 
        /// </summary>
        [EnumValueNameAttribute("opflex")]
        public static BalanceFlowPart Opflex
        {
            get 
            {
                return opflex;
            }
        }

        private readonly static BalanceFlowPart linepack;
        /// <summary>
        ///  A gas volume that is the quantity of gas which the operator responsible for gas transportation decides must be provided by the gas producing fields in order to make deliveries as requested by gas shippers and provide operating tolerances. 
        /// </summary>
        [EnumValueNameAttribute("linepack")]
        public static BalanceFlowPart Linepack
        {
            get 
            {
                return linepack;
            }
        }

        private readonly static BalanceFlowPart transfer;
        /// <summary>
        ///  A volume that is the volume of a hydrocarbon product which changes custody in the operation 
        /// </summary>
        [EnumValueNameAttribute("transfer")]
        public static BalanceFlowPart Transfer
        {
            get 
            {
                return transfer;
            }
        }

        private readonly static BalanceFlowPart productionMassAdjustment;
        /// <summary>
        /// A part of a mass adjustment process of a given production volume.
        /// </summary>
        [EnumValueNameAttribute("production - mass adjustment")]
        public static BalanceFlowPart ProductionMassAdjustment
        {
            get 
            {
                return productionMassAdjustment;
            }
        }

        private readonly static BalanceFlowPart swap;
        /// <summary>
        ///  A swap of a volume in between different parties (often used in crude sales), e.g. "I have this volume with this quality and value and you can give me this higher volume for it with a lower quality." 
        /// </summary>
        [EnumValueNameAttribute("swap")]
        public static BalanceFlowPart Swap
        {
            get 
            {
                return swap;
            }
        }

        private readonly static BalanceFlowPart unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BalanceFlowPart Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static BalanceFlowPart()
        {
            openingBalance = 
                new BalanceFlowPart("opening balance")
                {
                    Description = " A volume that is the total volume on stock at the beginning of a time period. "
            };
            closingBalance = 
                new BalanceFlowPart("closing balance")
                {
                    Description = " A volume that is the total volume on stock at the end of a time period. "
            };
            inputToStorage = 
                new BalanceFlowPart("input to storage")
                {
                    Description = " A volume that is the total volume of additions to a stock within a given time period. "
            };
            liftingEntitlement = 
                new BalanceFlowPart("lifting entitlement")
                {
                    Description = "A volume that is the contracted volume which can be transferred"
            };
            liftingEntitlementRemaining = 
                new BalanceFlowPart("lifting entitlement remaining")
                {
                    Description = "A volume that is the contracted volume which is not transferred but which remains available for subsequent transfer"
            };
            gainloss = 
                new BalanceFlowPart("gain/loss")
                {
                    Description = " A volume that is a lack of proper proportion or relation between the corresponding input and liftings transactions. "
            };
            adjustedClosing = 
                new BalanceFlowPart("adjusted closing")
                {
                    Description = "A volume that remains after the operation of transfer"
            };
            lifted = 
                new BalanceFlowPart("lifted")
                {
                    Description = "A volume that is transferred (\"lifted\")"
            };
            productionValueAdjustment = 
                new BalanceFlowPart("production -- value adjustment")
                {
                    Description = "A value that is adjusted due to a change in the value of a product."
            };
            transaction = 
                new BalanceFlowPart("transaction")
                {
                    Description = " Typically used within the cargo shipper operations and in this context is a change in ownership as executed between shippers of the cargo. "
            };
            completedLifting = 
                new BalanceFlowPart("completed lifting")
                {
                    Description = " A volume that is the total volume of a hydrocarbon product that is exported from a stock within a given time period. "
            };
            productionImbalance = 
                new BalanceFlowPart("production imbalance")
                {
                    Description = " A gas volume that is the difference between gas volume entering and exiting a shipper's nomination portfolio. This will take into account all differences whatever the time or reason it occurs. "
            };
            partialLifting = 
                new BalanceFlowPart("partial lifting")
                {
                    Description = " A volume that is the volume of a hydrocarbon product lifting up to a (not completed) determined point in time. "
            };
            closingStorageInventory = 
                new BalanceFlowPart("closing storage inventory")
                {
                    Description = " A closing storage balance that is adjusted according to imbalance at end of period. "
            };
            tankerLifting = 
                new BalanceFlowPart("tanker lifting")
                {
                    Description = " A volume that is the volume of a hydrocarbon product lifting transferred by tanker "
            };
            pipelineLifting = 
                new BalanceFlowPart("pipeline lifting")
                {
                    Description = " A volume that is the volume of a hydrocarbon product lifting transferred by pipeline "
            };
            opflex = 
                new BalanceFlowPart("opflex")
                {
                    Description = " A gas volume that is the unused and available quantity of gas within a gas transportation system and/or at one or many gas producing fields that is accessible by the operator responsible for gas transportation for the purposes of alleviating field curtailment. "
            };
            linepack = 
                new BalanceFlowPart("linepack")
                {
                    Description = " A gas volume that is the quantity of gas which the operator responsible for gas transportation decides must be provided by the gas producing fields in order to make deliveries as requested by gas shippers and provide operating tolerances. "
            };
            transfer = 
                new BalanceFlowPart("transfer")
                {
                    Description = " A volume that is the volume of a hydrocarbon product which changes custody in the operation "
            };
            productionMassAdjustment = 
                new BalanceFlowPart("production - mass adjustment")
                {
                    Description = "A part of a mass adjustment process of a given production volume."
            };
            swap = 
                new BalanceFlowPart("swap")
                {
                    Description = " A swap of a volume in between different parties (often used in crude sales), e.g. \"I have this volume with this quality and value and you can give me this higher volume for it with a lower quality.\" "
            };
            unknown = 
                new BalanceFlowPart("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a BalanceFlowPart by name
        /// </summary>
        /// <param name="name">The name of the BalanceFlowPart to return</param>
        /// <returns>The BalanceFlowPart represented by 'name'</returns>
        public static BalanceFlowPart GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(BalanceFlowPart)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(BalanceFlowPart)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (BalanceFlowPart)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static BusinessUnitKind company;
        /// <summary>
        /// A business unit which is a whole company
        /// </summary>
        [EnumValueNameAttribute("company")]
        public static BusinessUnitKind Company
        {
            get 
            {
                return company;
            }
        }

        private readonly static BusinessUnitKind field;
        /// <summary>
        /// A business unit which is a single field
        /// </summary>
        [EnumValueNameAttribute("field")]
        public static BusinessUnitKind Field
        {
            get 
            {
                return field;
            }
        }

        private readonly static BusinessUnitKind license;
        /// <summary>
        /// A business unit which is a single license
        /// </summary>
        [EnumValueNameAttribute("license")]
        public static BusinessUnitKind License
        {
            get 
            {
                return license;
            }
        }

        private readonly static BusinessUnitKind businessArea;
        /// <summary>
        /// A business unit which is a group of fields or licenses
        /// </summary>
        [EnumValueNameAttribute("business area")]
        public static BusinessUnitKind BusinessArea
        {
            get 
            {
                return businessArea;
            }
        }

        private readonly static BusinessUnitKind platform;
        /// <summary>
        /// A business unit which is a single platform
        /// </summary>
        [EnumValueNameAttribute("platform")]
        public static BusinessUnitKind Platform
        {
            get 
            {
                return platform;
            }
        }

        private readonly static BusinessUnitKind terminal;
        /// <summary>
        /// A business unit which is a terminal
        /// </summary>
        [EnumValueNameAttribute("terminal")]
        public static BusinessUnitKind Terminal
        {
            get 
            {
                return terminal;
            }
        }

        private readonly static BusinessUnitKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static BusinessUnitKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static BusinessUnitKind()
        {
            company = 
                new BusinessUnitKind("company")
                {
                    Description = "A business unit which is a whole company"
            };
            field = 
                new BusinessUnitKind("field")
                {
                    Description = "A business unit which is a single field"
            };
            license = 
                new BusinessUnitKind("license")
                {
                    Description = "A business unit which is a single license"
            };
            businessArea = 
                new BusinessUnitKind("business area")
                {
                    Description = "A business unit which is a group of fields or licenses"
            };
            platform = 
                new BusinessUnitKind("platform")
                {
                    Description = "A business unit which is a single platform"
            };
            terminal = 
                new BusinessUnitKind("terminal")
                {
                    Description = "A business unit which is a terminal"
            };
            unknown = 
                new BusinessUnitKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a BusinessUnitKind by name
        /// </summary>
        /// <param name="name">The name of the BusinessUnitKind to return</param>
        /// <returns>The BusinessUnitKind represented by 'name'</returns>
        public static BusinessUnitKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(BusinessUnitKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(BusinessUnitKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (BusinessUnitKind)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static CalculationMethod none;
        /// <summary>
        ///  No calculations are performed to create data where none exists at index points within an existing set of data. 
        /// </summary>
        [EnumValueNameAttribute("none")]
        public static CalculationMethod None
        {
            get 
            {
                return none;
            }
        }

        private readonly static CalculationMethod stepWiseConstant;
        /// <summary>
        /// The value is held constant until the next index point.
        /// </summary>
        [EnumValueNameAttribute("step wise constant")]
        public static CalculationMethod StepWiseConstant
        {
            get 
            {
                return stepWiseConstant;
            }
        }

        private readonly static CalculationMethod unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static CalculationMethod Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static CalculationMethod()
        {
            none = 
                new CalculationMethod("none")
                {
                    Description = " No calculations are performed to create data where none exists at index points within an existing set of data. "
            };
            stepWiseConstant = 
                new CalculationMethod("step wise constant")
                {
                    Description = "The value is held constant until the next index point."
            };
            unknown = 
                new CalculationMethod("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a CalculationMethod by name
        /// </summary>
        /// <param name="name">The name of the CalculationMethod to return</param>
        /// <returns>The CalculationMethod represented by 'name'</returns>
        public static CalculationMethod GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(CalculationMethod)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(CalculationMethod)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (CalculationMethod)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ContactPreference businessMail;
        /// <summary>
        /// Postal mail at the business address.
        /// </summary>
        [EnumValueNameAttribute("business mail")]
        public static ContactPreference BusinessMail
        {
            get 
            {
                return businessMail;
            }
        }

        private readonly static ContactPreference businessFax;
        /// <summary>
        /// Business fax.
        /// </summary>
        [EnumValueNameAttribute("business fax")]
        public static ContactPreference BusinessFax
        {
            get 
            {
                return businessFax;
            }
        }

        private readonly static ContactPreference businessEmail;
        /// <summary>
        /// Business email.
        /// </summary>
        [EnumValueNameAttribute("business email")]
        public static ContactPreference BusinessEmail
        {
            get 
            {
                return businessEmail;
            }
        }

        private readonly static ContactPreference businessPhone;
        /// <summary>
        /// Business voice phone.
        /// </summary>
        [EnumValueNameAttribute("business phone")]
        public static ContactPreference BusinessPhone
        {
            get 
            {
                return businessPhone;
            }
        }

        private readonly static ContactPreference mobile;
        /// <summary>
        /// Mobile phone.
        /// </summary>
        [EnumValueNameAttribute("mobile")]
        public static ContactPreference Mobile
        {
            get 
            {
                return mobile;
            }
        }

        private readonly static ContactPreference pager;
        /// <summary>
        /// Pager.
        /// </summary>
        [EnumValueNameAttribute("pager")]
        public static ContactPreference Pager
        {
            get 
            {
                return pager;
            }
        }

        private readonly static ContactPreference personalFax;
        /// <summary>
        /// Personal fax.
        /// </summary>
        [EnumValueNameAttribute("personal fax")]
        public static ContactPreference PersonalFax
        {
            get 
            {
                return personalFax;
            }
        }

        private readonly static ContactPreference personalEmail;
        /// <summary>
        /// Personal email.
        /// </summary>
        [EnumValueNameAttribute("personal email")]
        public static ContactPreference PersonalEmail
        {
            get 
            {
                return personalEmail;
            }
        }

        private readonly static ContactPreference personalMail;
        /// <summary>
        /// Postal mail at the personal address.
        /// </summary>
        [EnumValueNameAttribute("personal mail")]
        public static ContactPreference PersonalMail
        {
            get 
            {
                return personalMail;
            }
        }

        private readonly static ContactPreference personalPhone;
        /// <summary>
        /// Personal voice phone.
        /// </summary>
        [EnumValueNameAttribute("personal phone")]
        public static ContactPreference PersonalPhone
        {
            get 
            {
                return personalPhone;
            }
        }

        private readonly static ContactPreference unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ContactPreference Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ContactPreference()
        {
            businessMail = 
                new ContactPreference("business mail")
                {
                    Description = "Postal mail at the business address."
            };
            businessFax = 
                new ContactPreference("business fax")
                {
                    Description = "Business fax."
            };
            businessEmail = 
                new ContactPreference("business email")
                {
                    Description = "Business email."
            };
            businessPhone = 
                new ContactPreference("business phone")
                {
                    Description = "Business voice phone."
            };
            mobile = 
                new ContactPreference("mobile")
                {
                    Description = "Mobile phone."
            };
            pager = 
                new ContactPreference("pager")
                {
                    Description = "Pager."
            };
            personalFax = 
                new ContactPreference("personal fax")
                {
                    Description = "Personal fax."
            };
            personalEmail = 
                new ContactPreference("personal email")
                {
                    Description = "Personal email."
            };
            personalMail = 
                new ContactPreference("personal mail")
                {
                    Description = "Postal mail at the personal address."
            };
            personalPhone = 
                new ContactPreference("personal phone")
                {
                    Description = "Personal voice phone."
            };
            unknown = 
                new ContactPreference("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ContactPreference by name
        /// </summary>
        /// <param name="name">The name of the ContactPreference to return</param>
        /// <returns>The ContactPreference represented by 'name'</returns>
        public static ContactPreference GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ContactPreference)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ContactPreference)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ContactPreference)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static CrewType cateringCrew;
        /// <summary>
        ///  A count that is the number of persons from the catering contractor spending the night at the installation. 
        /// </summary>
        [EnumValueNameAttribute("catering crew")]
        public static CrewType CateringCrew
        {
            get 
            {
                return cateringCrew;
            }
        }

        private readonly static CrewType contractorCrew;
        /// <summary>
        ///  A count that is the number of persons from other than operator spending the night at the installation. 
        /// </summary>
        [EnumValueNameAttribute("contractor crew")]
        public static CrewType ContractorCrew
        {
            get 
            {
                return contractorCrew;
            }
        }

        private readonly static CrewType dayVisitors;
        /// <summary>
        ///  A count that is the number of persons visiting the installation but not spending the night at the installation. 
        /// </summary>
        [EnumValueNameAttribute("day visitors")]
        public static CrewType DayVisitors
        {
            get 
            {
                return dayVisitors;
            }
        }

        private readonly static CrewType drillingContractCrew;
        /// <summary>
        ///  A count that is the number of persons from the drilling contractor spending the night at the installation. 
        /// </summary>
        [EnumValueNameAttribute("drilling contract crew")]
        public static CrewType DrillingContractCrew
        {
            get 
            {
                return drillingContractCrew;
            }
        }

        private readonly static CrewType ownCrew;
        /// <summary>
        ///  A count that is the number of persons from the operator normally working on the installation and spending the night there. 
        /// </summary>
        [EnumValueNameAttribute("own crew")]
        public static CrewType OwnCrew
        {
            get 
            {
                return ownCrew;
            }
        }

        private readonly static CrewType ownOtherCrew;
        /// <summary>
        ///  A count that is the number of persons from the operator normally not working on the installation, but spending the night there. 
        /// </summary>
        [EnumValueNameAttribute("own other crew")]
        public static CrewType OwnOtherCrew
        {
            get 
            {
                return ownOtherCrew;
            }
        }

        private readonly static CrewType otherCrew;
        /// <summary>
        ///  A count that is the number of persons from an unknown source normally not working on the installation, but spending the night there. 
        /// </summary>
        [EnumValueNameAttribute("other crew")]
        public static CrewType OtherCrew
        {
            get 
            {
                return otherCrew;
            }
        }

        private readonly static CrewType personnelOnBoard;
        /// <summary>
        /// A count of the total personnel on board.
        /// </summary>
        [EnumValueNameAttribute("personnel on board")]
        public static CrewType PersonnelOnBoard
        {
            get 
            {
                return personnelOnBoard;
            }
        }

        private readonly static CrewType unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static CrewType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static CrewType()
        {
            cateringCrew = 
                new CrewType("catering crew")
                {
                    Description = " A count that is the number of persons from the catering contractor spending the night at the installation. "
            };
            contractorCrew = 
                new CrewType("contractor crew")
                {
                    Description = " A count that is the number of persons from other than operator spending the night at the installation. "
            };
            dayVisitors = 
                new CrewType("day visitors")
                {
                    Description = " A count that is the number of persons visiting the installation but not spending the night at the installation. "
            };
            drillingContractCrew = 
                new CrewType("drilling contract crew")
                {
                    Description = " A count that is the number of persons from the drilling contractor spending the night at the installation. "
            };
            ownCrew = 
                new CrewType("own crew")
                {
                    Description = " A count that is the number of persons from the operator normally working on the installation and spending the night there. "
            };
            ownOtherCrew = 
                new CrewType("own other crew")
                {
                    Description = " A count that is the number of persons from the operator normally not working on the installation, but spending the night there. "
            };
            otherCrew = 
                new CrewType("other crew")
                {
                    Description = " A count that is the number of persons from an unknown source normally not working on the installation, but spending the night there. "
            };
            personnelOnBoard = 
                new CrewType("personnel on board")
                {
                    Description = "A count of the total personnel on board."
            };
            unknown = 
                new CrewType("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a CrewType by name
        /// </summary>
        /// <param name="name">The name of the CrewType to return</param>
        /// <returns>The CrewType represented by 'name'</returns>
        public static CrewType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(CrewType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(CrewType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (CrewType)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines the quality of data
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

        private readonly static DataQuality best;
        /// <summary>
        /// Data quality is of the best standard possible
        /// </summary>
        [EnumValueNameAttribute("best")]
        public static DataQuality Best
        {
            get 
            {
                return best;
            }
        }

        private readonly static DataQuality good;
        /// <summary>
        /// Data quality is of good standard
        /// </summary>
        [EnumValueNameAttribute("good")]
        public static DataQuality Good
        {
            get 
            {
                return good;
            }
        }

        private readonly static DataQuality fair;
        /// <summary>
        /// Data quality is of fair standard
        /// </summary>
        [EnumValueNameAttribute("fair")]
        public static DataQuality Fair
        {
            get 
            {
                return fair;
            }
        }

        private readonly static DataQuality poor;
        /// <summary>
        /// Data quality is of poor standard
        /// </summary>
        [EnumValueNameAttribute("poor")]
        public static DataQuality Poor
        {
            get 
            {
                return poor;
            }
        }

        private readonly static DataQuality invalid;
        /// <summary>
        /// Data quality is sufficiently bad as to render the data invalid
        /// </summary>
        [EnumValueNameAttribute("invalid")]
        public static DataQuality Invalid
        {
            get 
            {
                return invalid;
            }
        }

        private readonly static DataQuality unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static DataQuality Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static DataQuality()
        {
            best = 
                new DataQuality("best")
                {
                    Description = "Data quality is of the best standard possible"
            };
            good = 
                new DataQuality("good")
                {
                    Description = "Data quality is of good standard"
            };
            fair = 
                new DataQuality("fair")
                {
                    Description = "Data quality is of fair standard"
            };
            poor = 
                new DataQuality("poor")
                {
                    Description = "Data quality is of poor standard"
            };
            invalid = 
                new DataQuality("invalid")
                {
                    Description = "Data quality is sufficiently bad as to render the data invalid"
            };
            unknown = 
                new DataQuality("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a DataQuality by name
        /// </summary>
        /// <param name="name">The name of the DataQuality to return</param>
        /// <returns>The DataQuality represented by 'name'</returns>
        public static DataQuality GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(DataQuality)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(DataQuality)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (DataQuality)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			The meaning of the endpoint for min/max query parameters
    ///			on "growing objects".
    ///		
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

        private readonly static EndpointQualifier inclusive;
        /// <summary>
        ///  The endpoint of the range is inclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be within the range. 
        /// </summary>
        [EnumValueNameAttribute("inclusive")]
        public static EndpointQualifier Inclusive
        {
            get 
            {
                return inclusive;
            }
        }

        private readonly static EndpointQualifier exclusive;
        /// <summary>
        ///  The endpoint of the range is exclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be outside the range. 
        /// </summary>
        [EnumValueNameAttribute("exclusive")]
        public static EndpointQualifier Exclusive
        {
            get 
            {
                return exclusive;
            }
        }

        private readonly static EndpointQualifier extensive;
        /// <summary>
        ///  The endpoint of the range may be extended to the first encountered value if an exact value match is not found. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. Basically, this concept is designed to support interpolation across an undefined point. 
        /// </summary>
        [EnumValueNameAttribute("extensive")]
        public static EndpointQualifier Extensive
        {
            get 
            {
                return extensive;
            }
        }

        private readonly static EndpointQualifier overlapExtensive;
        /// <summary>
        ///  The endpoint of the range may be extended to the first encountered value if the interval is overlapped with the index interval. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. This concept is designed to select ALL nodes whose index interval overlap with the query range. 
        /// </summary>
        [EnumValueNameAttribute("overlap extensive")]
        public static EndpointQualifier OverlapExtensive
        {
            get 
            {
                return overlapExtensive;
            }
        }

        private readonly static EndpointQualifier unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static EndpointQualifier Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static EndpointQualifier()
        {
            inclusive = 
                new EndpointQualifier("inclusive")
                {
                    Description = " The endpoint of the range is inclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be within the range. "
            };
            exclusive = 
                new EndpointQualifier("exclusive")
                {
                    Description = " The endpoint of the range is exclusive of the specified range value. That is, a node index value which matches the specified range value is considered to be outside the range. "
            };
            extensive = 
                new EndpointQualifier("extensive")
                {
                    Description = " The endpoint of the range may be extended to the first encountered value if an exact value match is not found. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. Basically, this concept is designed to support interpolation across an undefined point. "
            };
            overlapExtensive = 
                new EndpointQualifier("overlap extensive")
                {
                    Description = " The endpoint of the range may be extended to the first encountered value if the interval is overlapped with the index interval. That is, if a node index value does not match the specified range value then the next smaller value (on minimum end) or larger value (on maximum end) in the index series should be used as the endpoint. This concept is designed to select ALL nodes whose index interval overlap with the query range. "
            };
            unknown = 
                new EndpointQualifier("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a EndpointQualifier by name
        /// </summary>
        /// <param name="name">The name of the EndpointQualifier to return</param>
        /// <returns>The EndpointQualifier represented by 'name'</returns>
        public static EndpointQualifier GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(EndpointQualifier)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(EndpointQualifier)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (EndpointQualifier)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// The meaning of the endpoint for some interval.
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

        private readonly static EndpointQualifierInterval inclusive;
        /// <summary>
        ///  The endpoint of the interval is inclusive of the specified value. 
        /// </summary>
        [EnumValueNameAttribute("inclusive")]
        public static EndpointQualifierInterval Inclusive
        {
            get 
            {
                return inclusive;
            }
        }

        private readonly static EndpointQualifierInterval exclusive;
        /// <summary>
        ///  The endpoint of the interval is exclusive of the specified value. 
        /// </summary>
        [EnumValueNameAttribute("exclusive")]
        public static EndpointQualifierInterval Exclusive
        {
            get 
            {
                return exclusive;
            }
        }

        private readonly static EndpointQualifierInterval unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static EndpointQualifierInterval Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static EndpointQualifierInterval()
        {
            inclusive = 
                new EndpointQualifierInterval("inclusive")
                {
                    Description = " The endpoint of the interval is inclusive of the specified value. "
            };
            exclusive = 
                new EndpointQualifierInterval("exclusive")
                {
                    Description = " The endpoint of the interval is exclusive of the specified value. "
            };
            unknown = 
                new EndpointQualifierInterval("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a EndpointQualifierInterval by name
        /// </summary>
        /// <param name="name">The name of the EndpointQualifierInterval to return</param>
        /// <returns>The EndpointQualifierInterval represented by 'name'</returns>
        public static EndpointQualifierInterval GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(EndpointQualifierInterval)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(EndpointQualifierInterval)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (EndpointQualifierInterval)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static EosModelKind bwrs;
        /// <summary>
        /// A modification of the Benedict-Webb-Rubin equation of state by Professor Kenneth E. Starling of the University of Oklahoma.
        /// </summary>
        [EnumValueNameAttribute("bwrs")]
        public static EosModelKind Bwrs
        {
            get 
            {
                return bwrs;
            }
        }

        private readonly static EosModelKind cubeos;
        /// <summary>
        /// A cubic equation of state
        /// </summary>
        [EnumValueNameAttribute("cubeos")]
        public static EosModelKind Cubeos
        {
            get 
            {
                return cubeos;
            }
        }

        private readonly static EosModelKind pr;
        /// <summary>
        /// Peng-Robinson equation of state.
        /// </summary>
        [EnumValueNameAttribute("pr")]
        public static EosModelKind Pr
        {
            get 
            {
                return pr;
            }
        }

        private readonly static EosModelKind prvt;
        /// <summary>
        /// Peng-Robinson with volume translation.
        /// </summary>
        [EnumValueNameAttribute("prvt")]
        public static EosModelKind Prvt
        {
            get 
            {
                return prvt;
            }
        }

        private readonly static EosModelKind srk;
        /// <summary>
        /// Soave modification of Redlich-Kwong equation of state.
        /// </summary>
        [EnumValueNameAttribute("srk")]
        public static EosModelKind Srk
        {
            get 
            {
                return srk;
            }
        }

        private readonly static EosModelKind srkvt;
        /// <summary>
        /// Soave-Redlich-Kwong with volume translation.
        /// </summary>
        [EnumValueNameAttribute("srkvt")]
        public static EosModelKind Srkvt
        {
            get 
            {
                return srkvt;
            }
        }

        private readonly static EosModelKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static EosModelKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static EosModelKind()
        {
            bwrs = 
                new EosModelKind("bwrs")
                {
                    Description = "A modification of the Benedict-Webb-Rubin equation of state by Professor Kenneth E. Starling of the University of Oklahoma."
            };
            cubeos = 
                new EosModelKind("cubeos")
                {
                    Description = "A cubic equation of state"
            };
            pr = 
                new EosModelKind("pr")
                {
                    Description = "Peng-Robinson equation of state."
            };
            prvt = 
                new EosModelKind("prvt")
                {
                    Description = "Peng-Robinson with volume translation."
            };
            srk = 
                new EosModelKind("srk")
                {
                    Description = "Soave modification of Redlich-Kwong equation of state."
            };
            srkvt = 
                new EosModelKind("srkvt")
                {
                    Description = "Soave-Redlich-Kwong with volume translation."
            };
            unknown = 
                new EosModelKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a EosModelKind by name
        /// </summary>
        /// <param name="name">The name of the EosModelKind to return</param>
        /// <returns>The EosModelKind represented by 'name'</returns>
        public static EosModelKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(EosModelKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(EosModelKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (EosModelKind)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static FacilityParameter absorbedDoseClass;
        /// <summary>
        /// The amount of energy absorbed per mass.
        /// </summary>
        [EnumValueNameAttribute("absorbed dose class")]
        public static FacilityParameter AbsorbedDoseClass
        {
            get 
            {
                return absorbedDoseClass;
            }
        }

        private readonly static FacilityParameter accelerationLinearClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("acceleration linear class")]
        public static FacilityParameter AccelerationLinearClass
        {
            get 
            {
                return accelerationLinearClass;
            }
        }

        private readonly static FacilityParameter activityOfRadioactivityClass;
        /// <summary>
        /// A measure of the radiation being emitted.
        /// </summary>
        [EnumValueNameAttribute("activity (of radioactivity) class")]
        public static FacilityParameter ActivityOfRadioactivityClass
        {
            get 
            {
                return activityOfRadioactivityClass;
            }
        }

        private readonly static FacilityParameter alarmAbsolutePressure;
        /// <summary>
        /// Absolute minimum pressure of the flow stream before the system will give an alarm. Equivalent to element absoluteMinPres in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("alarm absolute pressure")]
        public static FacilityParameter AlarmAbsolutePressure
        {
            get 
            {
                return alarmAbsolutePressure;
            }
        }

        private readonly static FacilityParameter amountOfSubstanceClass;
        /// <summary>
        /// Molar amount of a substance.
        /// </summary>
        [EnumValueNameAttribute("amount of substance class")]
        public static FacilityParameter AmountOfSubstanceClass
        {
            get 
            {
                return amountOfSubstanceClass;
            }
        }

        private readonly static FacilityParameter anglePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per length")]
        public static FacilityParameter AnglePerLength
        {
            get 
            {
                return anglePerLength;
            }
        }

        private readonly static FacilityParameter anglePerTime;
        /// <summary>
        /// The angular velocity. The rate of change of an angle.
        /// </summary>
        [EnumValueNameAttribute("angle per time")]
        public static FacilityParameter AnglePerTime
        {
            get 
            {
                return anglePerTime;
            }
        }

        private readonly static FacilityParameter anglePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angle per volume")]
        public static FacilityParameter AnglePerVolume
        {
            get 
            {
                return anglePerVolume;
            }
        }

        private readonly static FacilityParameter angularAccelerationClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("angular acceleration class")]
        public static FacilityParameter AngularAccelerationClass
        {
            get 
            {
                return angularAccelerationClass;
            }
        }

        private readonly static FacilityParameter annulusInnerDiameter;
        /// <summary>
        /// Inner diameter of Annulus.
        /// </summary>
        [EnumValueNameAttribute("annulus inner diameter")]
        public static FacilityParameter AnnulusInnerDiameter
        {
            get 
            {
                return annulusInnerDiameter;
            }
        }

        private readonly static FacilityParameter annulusOuterDiameter;
        /// <summary>
        /// Outer diameter of annulus.
        /// </summary>
        [EnumValueNameAttribute("annulus outer diameter")]
        public static FacilityParameter AnnulusOuterDiameter
        {
            get 
            {
                return annulusOuterDiameter;
            }
        }

        private readonly static FacilityParameter areaClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area class")]
        public static FacilityParameter AreaClass
        {
            get 
            {
                return areaClass;
            }
        }

        private readonly static FacilityParameter areaPerArea;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is area.
        /// </summary>
        [EnumValueNameAttribute("area per area")]
        public static FacilityParameter AreaPerArea
        {
            get 
            {
                return areaPerArea;
            }
        }

        private readonly static FacilityParameter areaPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("area per volume")]
        public static FacilityParameter AreaPerVolume
        {
            get 
            {
                return areaPerVolume;
            }
        }

        private readonly static FacilityParameter atmosphericPressure;
        /// <summary>
        ///  The average atmospheric pressure during the reporting period. Equivalent to element atmosphere in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("atmospheric pressure")]
        public static FacilityParameter AtmosphericPressure
        {
            get 
            {
                return atmosphericPressure;
            }
        }

        private readonly static FacilityParameter attenuationClass;
        /// <summary>
        ///  A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave. 
        /// </summary>
        [EnumValueNameAttribute("attenuation class")]
        public static FacilityParameter AttenuationClass
        {
            get 
            {
                return attenuationClass;
            }
        }

        private readonly static FacilityParameter attenuationPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("attenuation per length")]
        public static FacilityParameter AttenuationPerLength
        {
            get 
            {
                return attenuationPerLength;
            }
        }

        private readonly static FacilityParameter available;
        /// <summary>
        ///  Indicates the availability of the facility. This should be implemented as a string value. A value of "true" indicates that it is available for use. That is, it may be currently shut-down but it can be restarted. A value of "false" indicates that the facility is not available to be used. That is, it cannot be restarted at this time. 
        /// </summary>
        [EnumValueNameAttribute("available")]
        public static FacilityParameter Available
        {
            get 
            {
                return available;
            }
        }

        private readonly static FacilityParameter availableRoom;
        /// <summary>
        /// Defines the unoccupied volume of a tank. Zero indicates that the tank is full.
        /// </summary>
        [EnumValueNameAttribute("available room")]
        public static FacilityParameter AvailableRoom
        {
            get 
            {
                return availableRoom;
            }
        }

        private readonly static FacilityParameter blockValveStatus;
        /// <summary>
        ///  Indicates the status of a block valve. This should be implemented as a string value. A value of "open" indicates that it is open. A value of "closed" indicates that it is closed. 
        /// </summary>
        [EnumValueNameAttribute("block valve status")]
        public static FacilityParameter BlockValveStatus
        {
            get 
            {
                return blockValveStatus;
            }
        }

        private readonly static FacilityParameter capacitanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("capacitance class")]
        public static FacilityParameter CapacitanceClass
        {
            get 
            {
                return capacitanceClass;
            }
        }

        private readonly static FacilityParameter categorical;
        /// <summary>
        /// The abstract supertype of all enumerated string properties.
        /// </summary>
        [EnumValueNameAttribute("categorical")]
        public static FacilityParameter Categorical
        {
            get 
            {
                return categorical;
            }
        }

        private readonly static FacilityParameter cathodicProtectionOutputCurrent;
        /// <summary>
        /// Rectifier DC Output.
        /// </summary>
        [EnumValueNameAttribute("cathodic protection output current")]
        public static FacilityParameter CathodicProtectionOutputCurrent
        {
            get 
            {
                return cathodicProtectionOutputCurrent;
            }
        }

        private readonly static FacilityParameter cathodicProtectionOutputVoltage;
        /// <summary>
        /// Rectifier DC Output.
        /// </summary>
        [EnumValueNameAttribute("cathodic protection output voltage")]
        public static FacilityParameter CathodicProtectionOutputVoltage
        {
            get 
            {
                return cathodicProtectionOutputVoltage;
            }
        }

        private readonly static FacilityParameter chargeDensityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("charge density class")]
        public static FacilityParameter ChargeDensityClass
        {
            get 
            {
                return chargeDensityClass;
            }
        }

        private readonly static FacilityParameter chemicalPotentialClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("chemical potential class")]
        public static FacilityParameter ChemicalPotentialClass
        {
            get 
            {
                return chemicalPotentialClass;
            }
        }

        private readonly static FacilityParameter chokePosition;
        /// <summary>
        /// A coded value describing the position of the choke (open, close, travelling).
        /// </summary>
        [EnumValueNameAttribute("choke position")]
        public static FacilityParameter ChokePosition
        {
            get 
            {
                return chokePosition;
            }
        }

        private readonly static FacilityParameter chokeSetting;
        /// <summary>
        /// A fraction value (percentage) of the choke opening.
        /// </summary>
        [EnumValueNameAttribute("choke setting")]
        public static FacilityParameter ChokeSetting
        {
            get 
            {
                return chokeSetting;
            }
        }

        private readonly static FacilityParameter code;
        /// <summary>
        /// A property whose values are constrained to specific string values
        /// </summary>
        [EnumValueNameAttribute("code")]
        public static FacilityParameter Code
        {
            get 
            {
                return code;
            }
        }

        private readonly static FacilityParameter compressibilityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("compressibility class")]
        public static FacilityParameter CompressibilityClass
        {
            get 
            {
                return compressibilityClass;
            }
        }

        private readonly static FacilityParameter concentrationOfBClass;
        /// <summary>
        /// molar concentration of a substance.
        /// </summary>
        [EnumValueNameAttribute("concentration of B class")]
        public static FacilityParameter ConcentrationOfBClass
        {
            get 
            {
                return concentrationOfBClass;
            }
        }

        private readonly static FacilityParameter conductivityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("conductivity class")]
        public static FacilityParameter ConductivityClass
        {
            get 
            {
                return conductivityClass;
            }
        }

        private readonly static FacilityParameter continuous;
        /// <summary>
        /// The abstract supertype of all floating point properties.
        /// </summary>
        [EnumValueNameAttribute("continuous")]
        public static FacilityParameter Continuous
        {
            get 
            {
                return continuous;
            }
        }

        private readonly static FacilityParameter crossSectionAbsorptionClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("cross section absorption class")]
        public static FacilityParameter CrossSectionAbsorptionClass
        {
            get 
            {
                return crossSectionAbsorptionClass;
            }
        }

        private readonly static FacilityParameter currentDensityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("current density class")]
        public static FacilityParameter CurrentDensityClass
        {
            get 
            {
                return currentDensityClass;
            }
        }

        private readonly static FacilityParameter darcyFlowCoefficientClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("Darcy flow coefficient class")]
        public static FacilityParameter DarcyFlowCoefficientClass
        {
            get 
            {
                return darcyFlowCoefficientClass;
            }
        }

        private readonly static FacilityParameter dataTransmissionSpeedClass;
        /// <summary>
        /// used primarily for computer transmission rates.
        /// </summary>
        [EnumValueNameAttribute("data transmission speed class")]
        public static FacilityParameter DataTransmissionSpeedClass
        {
            get 
            {
                return dataTransmissionSpeedClass;
            }
        }

        private readonly static FacilityParameter deltaTemperatureClass;
        /// <summary>
        /// Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures.
        /// </summary>
        [EnumValueNameAttribute("delta temperature class")]
        public static FacilityParameter DeltaTemperatureClass
        {
            get 
            {
                return deltaTemperatureClass;
            }
        }

        private readonly static FacilityParameter density;
        /// <summary>
        /// The density of the flow stream or a specified component product within the flow. Equivalent to element densityValue in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static FacilityParameter Density
        {
            get 
            {
                return density;
            }
        }

        private readonly static FacilityParameter densityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("density class")]
        public static FacilityParameter DensityClass
        {
            get 
            {
                return densityClass;
            }
        }

        private readonly static FacilityParameter densityFlowRate;
        /// <summary>
        /// The mass basis flow rate of the flow stream or a specified component product within the flow. This is used for things like a sand component. Equivalent to element densityFlowRate in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("density flow rate")]
        public static FacilityParameter DensityFlowRate
        {
            get 
            {
                return densityFlowRate;
            }
        }

        private readonly static FacilityParameter densityStandard;
        /// <summary>
        /// The density of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element densityValue in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("density standard")]
        public static FacilityParameter DensityStandard
        {
            get 
            {
                return densityStandard;
            }
        }

        private readonly static FacilityParameter dewpointTemperature;
        /// <summary>
        /// The temperature at which the specified component product within the flow will start to condense out of the gaseous phase. Equivalent to element hcDewpoint or waterDewpoint (depending on the specified product) in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("dewpoint temperature")]
        public static FacilityParameter DewpointTemperature
        {
            get 
            {
                return dewpointTemperature;
            }
        }

        private readonly static FacilityParameter differentialPressure;
        /// <summary>
        /// The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/presDiff in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("differential pressure")]
        public static FacilityParameter DifferentialPressure
        {
            get 
            {
                return differentialPressure;
            }
        }

        private readonly static FacilityParameter differentialTemperature;
        /// <summary>
        /// The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/tempDiff in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("differential temperature")]
        public static FacilityParameter DifferentialTemperature
        {
            get 
            {
                return differentialTemperature;
            }
        }

        private readonly static FacilityParameter diffusionCoefficientClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("diffusion coefficient class")]
        public static FacilityParameter DiffusionCoefficientClass
        {
            get 
            {
                return diffusionCoefficientClass;
            }
        }

        private readonly static FacilityParameter digitalStorageClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("digital storage class")]
        public static FacilityParameter DigitalStorageClass
        {
            get 
            {
                return digitalStorageClass;
            }
        }

        private readonly static FacilityParameter dimensionlessClass;
        /// <summary>
        /// A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass.
        /// </summary>
        [EnumValueNameAttribute("dimensionless class")]
        public static FacilityParameter DimensionlessClass
        {
            get 
            {
                return dimensionlessClass;
            }
        }

        private readonly static FacilityParameter discrete;
        /// <summary>
        /// The abstract super-type of all integer properties.
        /// </summary>
        [EnumValueNameAttribute("discrete")]
        public static FacilityParameter Discrete
        {
            get 
            {
                return discrete;
            }
        }

        private readonly static FacilityParameter doseEquivalentClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent class")]
        public static FacilityParameter DoseEquivalentClass
        {
            get 
            {
                return doseEquivalentClass;
            }
        }

        private readonly static FacilityParameter doseEquivalentRateClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dose equivalent rate class")]
        public static FacilityParameter DoseEquivalentRateClass
        {
            get 
            {
                return doseEquivalentRateClass;
            }
        }

        private readonly static FacilityParameter dynamicViscosityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dynamic viscosity class")]
        public static FacilityParameter DynamicViscosityClass
        {
            get 
            {
                return dynamicViscosityClass;
            }
        }

        private readonly static FacilityParameter electricChargeClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric charge class")]
        public static FacilityParameter ElectricChargeClass
        {
            get 
            {
                return electricChargeClass;
            }
        }

        private readonly static FacilityParameter electricConductanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric conductance class")]
        public static FacilityParameter ElectricConductanceClass
        {
            get 
            {
                return electricConductanceClass;
            }
        }

        private readonly static FacilityParameter electricCurrentClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric current class")]
        public static FacilityParameter ElectricCurrentClass
        {
            get 
            {
                return electricCurrentClass;
            }
        }

        private readonly static FacilityParameter electricDipoleMomentClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric dipole moment class")]
        public static FacilityParameter ElectricDipoleMomentClass
        {
            get 
            {
                return electricDipoleMomentClass;
            }
        }

        private readonly static FacilityParameter electricFieldStrengthClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric field strength class")]
        public static FacilityParameter ElectricFieldStrengthClass
        {
            get 
            {
                return electricFieldStrengthClass;
            }
        }

        private readonly static FacilityParameter electricPolarizationClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric polarization class")]
        public static FacilityParameter ElectricPolarizationClass
        {
            get 
            {
                return electricPolarizationClass;
            }
        }

        private readonly static FacilityParameter electricPotentialClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electric potential class")]
        public static FacilityParameter ElectricPotentialClass
        {
            get 
            {
                return electricPotentialClass;
            }
        }

        private readonly static FacilityParameter electricalResistivityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electrical resistivity class")]
        public static FacilityParameter ElectricalResistivityClass
        {
            get 
            {
                return electricalResistivityClass;
            }
        }

        private readonly static FacilityParameter electrochemicalEquivalentClass;
        /// <summary>
        /// An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered.
        /// </summary>
        [EnumValueNameAttribute("electrochemical equivalent class")]
        public static FacilityParameter ElectrochemicalEquivalentClass
        {
            get 
            {
                return electrochemicalEquivalentClass;
            }
        }

        private readonly static FacilityParameter electromagneticMomentClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("electromagnetic moment class")]
        public static FacilityParameter ElectromagneticMomentClass
        {
            get 
            {
                return electromagneticMomentClass;
            }
        }

        private readonly static FacilityParameter energyLengthPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per area")]
        public static FacilityParameter EnergyLengthPerArea
        {
            get 
            {
                return energyLengthPerArea;
            }
        }

        private readonly static FacilityParameter energyLengthPerTimeAreaTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy length per time area temperature")]
        public static FacilityParameter EnergyLengthPerTimeAreaTemperature
        {
            get 
            {
                return energyLengthPerTimeAreaTemperature;
            }
        }

        private readonly static FacilityParameter energyPerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per area")]
        public static FacilityParameter EnergyPerArea
        {
            get 
            {
                return energyPerArea;
            }
        }

        private readonly static FacilityParameter energyPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("energy per length")]
        public static FacilityParameter EnergyPerLength
        {
            get 
            {
                return energyPerLength;
            }
        }

        private readonly static FacilityParameter equivalentPerMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per mass")]
        public static FacilityParameter EquivalentPerMass
        {
            get 
            {
                return equivalentPerMass;
            }
        }

        private readonly static FacilityParameter equivalentPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("equivalent per volume")]
        public static FacilityParameter EquivalentPerVolume
        {
            get 
            {
                return equivalentPerVolume;
            }
        }

        private readonly static FacilityParameter exposureRadioactivityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("exposure (radioactivity) class")]
        public static FacilityParameter ExposureRadioactivityClass
        {
            get 
            {
                return exposureRadioactivityClass;
            }
        }

        private readonly static FacilityParameter facilityUptime;
        /// <summary>
        /// The amount to time the facility was available during the specified period.
        /// </summary>
        [EnumValueNameAttribute("facility uptime")]
        public static FacilityParameter FacilityUptime
        {
            get 
            {
                return facilityUptime;
            }
        }

        private readonly static FacilityParameter flowRate;
        /// <summary>
        /// The flow rate of the flow stream or a specified component product within the flow. Equivalent to element flowRateValue in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("flow rate")]
        public static FacilityParameter FlowRate
        {
            get 
            {
                return flowRate;
            }
        }

        private readonly static FacilityParameter flowRateStandard;
        /// <summary>
        /// The flow rate of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element flowRateValue in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("flow rate standard")]
        public static FacilityParameter FlowRateStandard
        {
            get 
            {
                return flowRateStandard;
            }
        }

        private readonly static FacilityParameter forceAreaClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force area class")]
        public static FacilityParameter ForceAreaClass
        {
            get 
            {
                return forceAreaClass;
            }
        }

        private readonly static FacilityParameter forceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force class")]
        public static FacilityParameter ForceClass
        {
            get 
            {
                return forceClass;
            }
        }

        private readonly static FacilityParameter forceLengthPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force length per length")]
        public static FacilityParameter ForceLengthPerLength
        {
            get 
            {
                return forceLengthPerLength;
            }
        }

        private readonly static FacilityParameter forcePerForce;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is force.
        /// </summary>
        [EnumValueNameAttribute("force per force")]
        public static FacilityParameter ForcePerForce
        {
            get 
            {
                return forcePerForce;
            }
        }

        private readonly static FacilityParameter forcePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per length")]
        public static FacilityParameter ForcePerLength
        {
            get 
            {
                return forcePerLength;
            }
        }

        private readonly static FacilityParameter forcePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("force per volume")]
        public static FacilityParameter ForcePerVolume
        {
            get 
            {
                return forcePerVolume;
            }
        }

        private readonly static FacilityParameter frequencyClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("frequency class")]
        public static FacilityParameter FrequencyClass
        {
            get 
            {
                return frequencyClass;
            }
        }

        private readonly static FacilityParameter frequencyIntervalClass;
        /// <summary>
        /// An octave is a doubling of a frquency.
        /// </summary>
        [EnumValueNameAttribute("frequency interval class")]
        public static FacilityParameter FrequencyIntervalClass
        {
            get 
            {
                return frequencyIntervalClass;
            }
        }

        private readonly static FacilityParameter gammaRayApiUnitClass;
        /// <summary>
        /// This class is defined by the API, and is used for units of gamma ray log response.
        /// </summary>
        [EnumValueNameAttribute("gamma ray API unit class")]
        public static FacilityParameter GammaRayApiUnitClass
        {
            get 
            {
                return gammaRayApiUnitClass;
            }
        }

        private readonly static FacilityParameter gasLiquidRatio;
        /// <summary>
        /// The ratio of ratio of gas to liquid for all products in the whole flow stream. Equivalent to element gasLiquidRatio in the productVolume data-schema. The volumes related to each component should have been at or converted to the same pressure and temperature.
        /// </summary>
        [EnumValueNameAttribute("gas liquid ratio")]
        public static FacilityParameter GasLiquidRatio
        {
            get 
            {
                return gasLiquidRatio;
            }
        }

        private readonly static FacilityParameter gasOilRatio;
        /// <summary>
        /// Gas oil ratio. The ratio between the total gas volume and the total oil volume in the flow stream. Equivalent to element gor in the productVolume data-schema. The volumes related to each component should have been at or converted to the same pressure and temperature.
        /// </summary>
        [EnumValueNameAttribute("gas oil ratio")]
        public static FacilityParameter GasOilRatio
        {
            get 
            {
                return gasOilRatio;
            }
        }

        private readonly static FacilityParameter grossCalorificValueStandard;
        /// <summary>
        /// The amount of heat which would be released by the complete combustion in air of a specific quantity of a specified component product at standard temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element grossCalorificValueStd in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("gross calorific value standard")]
        public static FacilityParameter GrossCalorificValueStandard
        {
            get 
            {
                return grossCalorificValueStandard;
            }
        }

        private readonly static FacilityParameter heatCapacityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat capacity class")]
        public static FacilityParameter HeatCapacityClass
        {
            get 
            {
                return heatCapacityClass;
            }
        }

        private readonly static FacilityParameter heatFlowRateClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("heat flow rate class")]
        public static FacilityParameter HeatFlowRateClass
        {
            get 
            {
                return heatFlowRateClass;
            }
        }

        private readonly static FacilityParameter heatTransferCoefficientClass;
        /// <summary>
        /// PRESSURE PER VELOCITY PER AREA
        /// </summary>
        [EnumValueNameAttribute("heat transfer coefficient class")]
        public static FacilityParameter HeatTransferCoefficientClass
        {
            get 
            {
                return heatTransferCoefficientClass;
            }
        }

        private readonly static FacilityParameter illuminanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("illuminance class")]
        public static FacilityParameter IlluminanceClass
        {
            get 
            {
                return illuminanceClass;
            }
        }

        private readonly static FacilityParameter internalControlValveStatus;
        /// <summary>
        /// The status of which the Internal Coltrol Valve sleeve is set to.
        /// </summary>
        [EnumValueNameAttribute("internal control valve status")]
        public static FacilityParameter InternalControlValveStatus
        {
            get 
            {
                return internalControlValveStatus;
            }
        }

        private readonly static FacilityParameter irradianceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("irradiance class")]
        public static FacilityParameter IrradianceClass
        {
            get 
            {
                return irradianceClass;
            }
        }

        private readonly static FacilityParameter isothermalCompressibilityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("isothermal compressibility class")]
        public static FacilityParameter IsothermalCompressibilityClass
        {
            get 
            {
                return isothermalCompressibilityClass;
            }
        }

        private readonly static FacilityParameter kinematicViscosityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("kinematic viscosity class")]
        public static FacilityParameter KinematicViscosityClass
        {
            get 
            {
                return kinematicViscosityClass;
            }
        }

        private readonly static FacilityParameter lengthClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length class")]
        public static FacilityParameter LengthClass
        {
            get 
            {
                return lengthClass;
            }
        }

        private readonly static FacilityParameter lengthPerLength;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is length.
        /// </summary>
        [EnumValueNameAttribute("length per length")]
        public static FacilityParameter LengthPerLength
        {
            get 
            {
                return lengthPerLength;
            }
        }

        private readonly static FacilityParameter lengthPerTemperature;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per temperature")]
        public static FacilityParameter LengthPerTemperature
        {
            get 
            {
                return lengthPerTemperature;
            }
        }

        private readonly static FacilityParameter lengthPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("length per volume")]
        public static FacilityParameter LengthPerVolume
        {
            get 
            {
                return lengthPerVolume;
            }
        }

        private readonly static FacilityParameter levelOfPowerIntensityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("level of power intensity class")]
        public static FacilityParameter LevelOfPowerIntensityClass
        {
            get 
            {
                return levelOfPowerIntensityClass;
            }
        }

        private readonly static FacilityParameter lightExposureClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("light exposure class")]
        public static FacilityParameter LightExposureClass
        {
            get 
            {
                return lightExposureClass;
            }
        }

        private readonly static FacilityParameter linearThermalExpansionClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("linear thermal expansion class")]
        public static FacilityParameter LinearThermalExpansionClass
        {
            get 
            {
                return linearThermalExpansionClass;
            }
        }

        private readonly static FacilityParameter luminanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminance class")]
        public static FacilityParameter LuminanceClass
        {
            get 
            {
                return luminanceClass;
            }
        }

        private readonly static FacilityParameter luminousEfficacyClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous efficacy class")]
        public static FacilityParameter LuminousEfficacyClass
        {
            get 
            {
                return luminousEfficacyClass;
            }
        }

        private readonly static FacilityParameter luminousFluxClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous flux class")]
        public static FacilityParameter LuminousFluxClass
        {
            get 
            {
                return luminousFluxClass;
            }
        }

        private readonly static FacilityParameter luminousIntensityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("luminous intensity class")]
        public static FacilityParameter LuminousIntensityClass
        {
            get 
            {
                return luminousIntensityClass;
            }
        }

        private readonly static FacilityParameter magneticDipoleMomentClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic dipole moment class")]
        public static FacilityParameter MagneticDipoleMomentClass
        {
            get 
            {
                return magneticDipoleMomentClass;
            }
        }

        private readonly static FacilityParameter magneticFieldStrengthClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic field strength class")]
        public static FacilityParameter MagneticFieldStrengthClass
        {
            get 
            {
                return magneticFieldStrengthClass;
            }
        }

        private readonly static FacilityParameter magneticFluxClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic flux class")]
        public static FacilityParameter MagneticFluxClass
        {
            get 
            {
                return magneticFluxClass;
            }
        }

        private readonly static FacilityParameter magneticInductionClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic induction class")]
        public static FacilityParameter MagneticInductionClass
        {
            get 
            {
                return magneticInductionClass;
            }
        }

        private readonly static FacilityParameter magneticPermeabilityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic permeability class")]
        public static FacilityParameter MagneticPermeabilityClass
        {
            get 
            {
                return magneticPermeabilityClass;
            }
        }

        private readonly static FacilityParameter magneticVectorPotentialClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("magnetic vector potential class")]
        public static FacilityParameter MagneticVectorPotentialClass
        {
            get 
            {
                return magneticVectorPotentialClass;
            }
        }

        private readonly static FacilityParameter mass;
        /// <summary>
        /// The mass of the flow stream or a specified component product within the flow. Equivalent to element mass in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("mass")]
        public static FacilityParameter Mass
        {
            get 
            {
                return mass;
            }
        }

        private readonly static FacilityParameter massAttenuationCoefficientClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass attenuation coefficient class")]
        public static FacilityParameter MassAttenuationCoefficientClass
        {
            get 
            {
                return massAttenuationCoefficientClass;
            }
        }

        private readonly static FacilityParameter massClass;
        /// <summary>
        /// M/L2T
        /// </summary>
        [EnumValueNameAttribute("mass class")]
        public static FacilityParameter MassClass
        {
            get 
            {
                return massClass;
            }
        }

        private readonly static FacilityParameter massConcentration;
        /// <summary>
        /// The concentration of the specified component product as a weight percentage of the flow stream. Equivalent to element weightPercent in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("mass concentration")]
        public static FacilityParameter MassConcentration
        {
            get 
            {
                return massConcentration;
            }
        }

        private readonly static FacilityParameter massConcentrationClass;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is mass.
        /// </summary>
        [EnumValueNameAttribute("mass concentration class")]
        public static FacilityParameter MassConcentrationClass
        {
            get 
            {
                return massConcentrationClass;
            }
        }

        private readonly static FacilityParameter massFlowRateClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass flow rate class")]
        public static FacilityParameter MassFlowRateClass
        {
            get 
            {
                return massFlowRateClass;
            }
        }

        private readonly static FacilityParameter massLengthClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass length class")]
        public static FacilityParameter MassLengthClass
        {
            get 
            {
                return massLengthClass;
            }
        }

        private readonly static FacilityParameter massPerEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per energy")]
        public static FacilityParameter MassPerEnergy
        {
            get 
            {
                return massPerEnergy;
            }
        }

        private readonly static FacilityParameter massPerLength;
        /// <summary>
        /// M /L4T
        /// </summary>
        [EnumValueNameAttribute("mass per length")]
        public static FacilityParameter MassPerLength
        {
            get 
            {
                return massPerLength;
            }
        }

        private readonly static FacilityParameter massPerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per area")]
        public static FacilityParameter MassPerTimePerArea
        {
            get 
            {
                return massPerTimePerArea;
            }
        }

        private readonly static FacilityParameter massPerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per time per length")]
        public static FacilityParameter MassPerTimePerLength
        {
            get 
            {
                return massPerTimePerLength;
            }
        }

        private readonly static FacilityParameter massPerVolumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mass per volume per length")]
        public static FacilityParameter MassPerVolumePerLength
        {
            get 
            {
                return massPerVolumePerLength;
            }
        }

        private readonly static FacilityParameter measuredDepth;
        /// <summary>
        /// Measured depth of the specified facility with respect to the specified datum.
        /// </summary>
        [EnumValueNameAttribute("measured depth")]
        public static FacilityParameter MeasuredDepth
        {
            get 
            {
                return measuredDepth;
            }
        }

        private readonly static FacilityParameter mobilityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mobility class")]
        public static FacilityParameter MobilityClass
        {
            get 
            {
                return mobilityClass;
            }
        }

        private readonly static FacilityParameter modulusOfCompressionClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("modulus of compression class")]
        public static FacilityParameter ModulusOfCompressionClass
        {
            get 
            {
                return modulusOfCompressionClass;
            }
        }

        private readonly static FacilityParameter molarConcentration;
        /// <summary>
        /// The molar amount of a specified component product. Equivalent to element moleAmt in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("molar concentration")]
        public static FacilityParameter MolarConcentration
        {
            get 
            {
                return molarConcentration;
            }
        }

        private readonly static FacilityParameter molarFraction;
        /// <summary>
        /// The molar fraction of the specified component product as a molar amount percentage of the flow stream. Equivalent to element molePercent in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("molar fraction")]
        public static FacilityParameter MolarFraction
        {
            get 
            {
                return molarFraction;
            }
        }

        private readonly static FacilityParameter molarHeatCapacityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar heat capacity class")]
        public static FacilityParameter MolarHeatCapacityClass
        {
            get 
            {
                return molarHeatCapacityClass;
            }
        }

        private readonly static FacilityParameter molarVolumeClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("molar volume class")]
        public static FacilityParameter MolarVolumeClass
        {
            get 
            {
                return molarVolumeClass;
            }
        }

        private readonly static FacilityParameter molePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per area")]
        public static FacilityParameter MolePerArea
        {
            get 
            {
                return molePerArea;
            }
        }

        private readonly static FacilityParameter molePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time")]
        public static FacilityParameter MolePerTime
        {
            get 
            {
                return molePerTime;
            }
        }

        private readonly static FacilityParameter molePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("mole per time per area")]
        public static FacilityParameter MolePerTimePerArea
        {
            get 
            {
                return molePerTimePerArea;
            }
        }

        private readonly static FacilityParameter molecularWeight;
        /// <summary>
        /// The molecular weight of a specified component product. Equivalent to element molecularWeight in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("molecular weight")]
        public static FacilityParameter MolecularWeight
        {
            get 
            {
                return molecularWeight;
            }
        }

        private readonly static FacilityParameter momentOfForceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of force class")]
        public static FacilityParameter MomentOfForceClass
        {
            get 
            {
                return momentOfForceClass;
            }
        }

        private readonly static FacilityParameter momentOfInertiaClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of inertia class")]
        public static FacilityParameter MomentOfInertiaClass
        {
            get 
            {
                return momentOfInertiaClass;
            }
        }

        private readonly static FacilityParameter momentOfSectionClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("moment of section class")]
        public static FacilityParameter MomentOfSectionClass
        {
            get 
            {
                return momentOfSectionClass;
            }
        }

        private readonly static FacilityParameter momentumClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("momentum class")]
        public static FacilityParameter MomentumClass
        {
            get 
            {
                return momentumClass;
            }
        }

        private readonly static FacilityParameter motorCurrent;
        /// <summary>
        /// Current at which the motor operates.
        /// </summary>
        [EnumValueNameAttribute("motor current")]
        public static FacilityParameter MotorCurrent
        {
            get 
            {
                return motorCurrent;
            }
        }

        private readonly static FacilityParameter motorCurrentLeakage;
        /// <summary>
        /// Leakage current of the motor.
        /// </summary>
        [EnumValueNameAttribute("motor current leakage")]
        public static FacilityParameter MotorCurrentLeakage
        {
            get 
            {
                return motorCurrentLeakage;
            }
        }

        private readonly static FacilityParameter motorSpeed;
        /// <summary>
        /// Speed at which the motor operates.
        /// </summary>
        [EnumValueNameAttribute("motor speed")]
        public static FacilityParameter MotorSpeed
        {
            get 
            {
                return motorSpeed;
            }
        }

        private readonly static FacilityParameter motorTemperature;
        /// <summary>
        /// Motor temperature.
        /// </summary>
        [EnumValueNameAttribute("motor temperature")]
        public static FacilityParameter MotorTemperature
        {
            get 
            {
                return motorTemperature;
            }
        }

        private readonly static FacilityParameter motorVibration;
        /// <summary>
        /// The vibration (distortion) of which the motor produces.
        /// </summary>
        [EnumValueNameAttribute("motor vibration")]
        public static FacilityParameter MotorVibration
        {
            get 
            {
                return motorVibration;
            }
        }

        private readonly static FacilityParameter motorVoltage;
        /// <summary>
        /// Voltage at which the motor Operates.
        /// </summary>
        [EnumValueNameAttribute("motor voltage")]
        public static FacilityParameter MotorVoltage
        {
            get 
            {
                return motorVoltage;
            }
        }

        private readonly static FacilityParameter neutronApiUnitClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("neutron API unit class")]
        public static FacilityParameter NeutronApiUnitClass
        {
            get 
            {
                return neutronApiUnitClass;
            }
        }

        private readonly static FacilityParameter nondarcyFlowCoefficientClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("nonDarcy flow coefficient class")]
        public static FacilityParameter NondarcyFlowCoefficientClass
        {
            get 
            {
                return nondarcyFlowCoefficientClass;
            }
        }

        private readonly static FacilityParameter openingSize;
        /// <summary>
        /// The size of an opening. For example, a valve diameter. A value of zero indicates that it is closed.
        /// </summary>
        [EnumValueNameAttribute("opening size")]
        public static FacilityParameter OpeningSize
        {
            get 
            {
                return openingSize;
            }
        }

        private readonly static FacilityParameter operationsPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("operations per time")]
        public static FacilityParameter OperationsPerTime
        {
            get 
            {
                return operationsPerTime;
            }
        }

        private readonly static FacilityParameter parachorClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("parachor class")]
        public static FacilityParameter ParachorClass
        {
            get 
            {
                return parachorClass;
            }
        }

        private readonly static FacilityParameter perArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per area")]
        public static FacilityParameter PerArea
        {
            get 
            {
                return perArea;
            }
        }

        private readonly static FacilityParameter perElectricPotential;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per electric potential")]
        public static FacilityParameter PerElectricPotential
        {
            get 
            {
                return perElectricPotential;
            }
        }

        private readonly static FacilityParameter perForce;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per force")]
        public static FacilityParameter PerForce
        {
            get 
            {
                return perForce;
            }
        }

        private readonly static FacilityParameter perLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per length")]
        public static FacilityParameter PerLength
        {
            get 
            {
                return perLength;
            }
        }

        private readonly static FacilityParameter perMass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per mass")]
        public static FacilityParameter PerMass
        {
            get 
            {
                return perMass;
            }
        }

        private readonly static FacilityParameter perVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("per volume")]
        public static FacilityParameter PerVolume
        {
            get 
            {
                return perVolume;
            }
        }

        private readonly static FacilityParameter permeabilityLengthClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability length class")]
        public static FacilityParameter PermeabilityLengthClass
        {
            get 
            {
                return permeabilityLengthClass;
            }
        }

        private readonly static FacilityParameter permeabilityRockClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeability rock class")]
        public static FacilityParameter PermeabilityRockClass
        {
            get 
            {
                return permeabilityRockClass;
            }
        }

        private readonly static FacilityParameter permeanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permeance class")]
        public static FacilityParameter PermeanceClass
        {
            get 
            {
                return permeanceClass;
            }
        }

        private readonly static FacilityParameter permittivityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("permittivity class")]
        public static FacilityParameter PermittivityClass
        {
            get 
            {
                return permittivityClass;
            }
        }

        private readonly static FacilityParameter phClass;
        /// <summary>
        /// The pH is a class that measures the hydrogen ion concentration (acidity).
        /// </summary>
        [EnumValueNameAttribute("pH class")]
        public static FacilityParameter PhClass
        {
            get 
            {
                return phClass;
            }
        }

        private readonly static FacilityParameter planeAngleClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("plane angle class")]
        public static FacilityParameter PlaneAngleClass
        {
            get 
            {
                return planeAngleClass;
            }
        }

        private readonly static FacilityParameter potentialDifferencePerPowerDrop;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("potential difference per power drop")]
        public static FacilityParameter PotentialDifferencePerPowerDrop
        {
            get 
            {
                return potentialDifferencePerPowerDrop;
            }
        }

        private readonly static FacilityParameter powerClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power class")]
        public static FacilityParameter PowerClass
        {
            get 
            {
                return powerClass;
            }
        }

        private readonly static FacilityParameter powerPerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("power per volume")]
        public static FacilityParameter PowerPerVolume
        {
            get 
            {
                return powerPerVolume;
            }
        }

        private readonly static FacilityParameter pressure;
        /// <summary>
        /// Pressure in the flow stream. Equivalent to element pres in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("pressure")]
        public static FacilityParameter Pressure
        {
            get 
            {
                return pressure;
            }
        }

        private readonly static FacilityParameter pressureClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure class")]
        public static FacilityParameter PressureClass
        {
            get 
            {
                return pressureClass;
            }
        }

        private readonly static FacilityParameter pressurePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure per time")]
        public static FacilityParameter PressurePerTime
        {
            get 
            {
                return pressurePerTime;
            }
        }

        private readonly static FacilityParameter pressureSquaredClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared class")]
        public static FacilityParameter PressureSquaredClass
        {
            get 
            {
                return pressureSquaredClass;
            }
        }

        private readonly static FacilityParameter pressureSquaredPerForceTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure squared per force time per area")]
        public static FacilityParameter PressureSquaredPerForceTimePerArea
        {
            get 
            {
                return pressureSquaredPerForceTimePerArea;
            }
        }

        private readonly static FacilityParameter pressureTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("pressure time per volume")]
        public static FacilityParameter PressureTimePerVolume
        {
            get 
            {
                return pressureTimePerVolume;
            }
        }

        private readonly static FacilityParameter productivityIndexClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("productivity index class")]
        public static FacilityParameter ProductivityIndexClass
        {
            get 
            {
                return productivityIndexClass;
            }
        }

        private readonly static FacilityParameter pumpCountOnline;
        /// <summary>
        /// The number of pumps which are active. This should be implemented as a whole numbered value.
        /// </summary>
        [EnumValueNameAttribute("pump count online")]
        public static FacilityParameter PumpCountOnline
        {
            get 
            {
                return pumpCountOnline;
            }
        }

        private readonly static FacilityParameter pumpStatus;
        /// <summary>
        /// The operating status of the pump.
        /// </summary>
        [EnumValueNameAttribute("pump status")]
        public static FacilityParameter PumpStatus
        {
            get 
            {
                return pumpStatus;
            }
        }

        private readonly static FacilityParameter quantity;
        /// <summary>
        /// The abstract super-type of all floating point properties with a unit of measure.
        /// </summary>
        [EnumValueNameAttribute("quantity")]
        public static FacilityParameter Quantity
        {
            get 
            {
                return quantity;
            }
        }

        private readonly static FacilityParameter quantityOfLightClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("quantity of light class")]
        public static FacilityParameter QuantityOfLightClass
        {
            get 
            {
                return quantityOfLightClass;
            }
        }

        private readonly static FacilityParameter radianceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiance class")]
        public static FacilityParameter RadianceClass
        {
            get 
            {
                return radianceClass;
            }
        }

        private readonly static FacilityParameter radiantIntensityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("radiant intensity class")]
        public static FacilityParameter RadiantIntensityClass
        {
            get 
            {
                return radiantIntensityClass;
            }
        }

        private readonly static FacilityParameter reciprocatingSpeed;
        /// <summary>
        /// The reciprocating speed of a device (e.g., motor, compressor). 
        /// </summary>
        [EnumValueNameAttribute("reciprocating speed")]
        public static FacilityParameter ReciprocatingSpeed
        {
            get 
            {
                return reciprocatingSpeed;
            }
        }

        private readonly static FacilityParameter rectifierStructurePotential;
        /// <summary>
        /// Rectifier Structure Potential.
        /// </summary>
        [EnumValueNameAttribute("rectifier structure potential")]
        public static FacilityParameter RectifierStructurePotential
        {
            get 
            {
                return rectifierStructurePotential;
            }
        }

        private readonly static FacilityParameter reidVaporPressure;
        /// <summary>
        /// Reid vapor pressure of the flow stream or a specified component product within the flow. The absolute vapor pressure of volatile crude oil and volatile petroleum liquids, except liquefied petroleum gases, as determined in accordance with American Society for Testing and Materials under the designation ASTM D323-56. Equivalent to element rvp in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("reid vapor pressure")]
        public static FacilityParameter ReidVaporPressure
        {
            get 
            {
                return reidVaporPressure;
            }
        }

        private readonly static FacilityParameter relativeOpeningSize;
        /// <summary>
        /// The size of an opening. A value of 100 % indicates that it is open. A value of zero indicates that it is closed.
        /// </summary>
        [EnumValueNameAttribute("relative opening size")]
        public static FacilityParameter RelativeOpeningSize
        {
            get 
            {
                return relativeOpeningSize;
            }
        }

        private readonly static FacilityParameter relativePowerClass;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is power.
        /// </summary>
        [EnumValueNameAttribute("relative power class")]
        public static FacilityParameter RelativePowerClass
        {
            get 
            {
                return relativePowerClass;
            }
        }

        private readonly static FacilityParameter relativeTankLevel;
        /// <summary>
        /// Defines the relative level of a tank. Zero indicates empty and 100% indicates full. 
        /// </summary>
        [EnumValueNameAttribute("relative tank level")]
        public static FacilityParameter RelativeTankLevel
        {
            get 
            {
                return relativeTankLevel;
            }
        }

        private readonly static FacilityParameter relativeTimeClass;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is time.
        /// </summary>
        [EnumValueNameAttribute("relative time class")]
        public static FacilityParameter RelativeTimeClass
        {
            get 
            {
                return relativeTimeClass;
            }
        }

        private readonly static FacilityParameter relativeValveOpening;
        /// <summary>
        /// Indicates the status of a valve. A value of 100 % indicates that it is open. A value of zero indicates that it is closed.
        /// </summary>
        [EnumValueNameAttribute("relative valve opening")]
        public static FacilityParameter RelativeValveOpening
        {
            get 
            {
                return relativeValveOpening;
            }
        }

        private readonly static FacilityParameter reluctanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("reluctance class")]
        public static FacilityParameter ReluctanceClass
        {
            get 
            {
                return reluctanceClass;
            }
        }

        private readonly static FacilityParameter resistanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistance class")]
        public static FacilityParameter ResistanceClass
        {
            get 
            {
                return resistanceClass;
            }
        }

        private readonly static FacilityParameter resistivityPerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("resistivity per length")]
        public static FacilityParameter ResistivityPerLength
        {
            get 
            {
                return resistivityPerLength;
            }
        }

        private readonly static FacilityParameter rootProperty;
        /// <summary>
        /// The abstract supertype of all properties. This property does not have a parent.
        /// </summary>
        [EnumValueNameAttribute("root property")]
        public static FacilityParameter RootProperty
        {
            get 
            {
                return rootProperty;
            }
        }

        private readonly static FacilityParameter scheduledDowntime;
        /// <summary>
        /// Indicates the amount of time the facility has been unavailable during the specified period. May be related to a particular point in time which would represent the start of the downtime.
        /// </summary>
        [EnumValueNameAttribute("scheduled downtime")]
        public static FacilityParameter ScheduledDowntime
        {
            get 
            {
                return scheduledDowntime;
            }
        }

        private readonly static FacilityParameter secondMomentOfAreaClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("second moment of area class")]
        public static FacilityParameter SecondMomentOfAreaClass
        {
            get 
            {
                return secondMomentOfAreaClass;
            }
        }

        private readonly static FacilityParameter shutdownOrder;
        /// <summary>
        /// Defines the relative order in which a facility should be shutdown. This should be implemented as a whole numbered count. Facilities with smaller values should be shut down first. Only facility parameters with the same version time and same version source should be evaluated together for the purposes of this order.
        /// </summary>
        [EnumValueNameAttribute("shutdown order")]
        public static FacilityParameter ShutdownOrder
        {
            get 
            {
                return shutdownOrder;
            }
        }

        private readonly static FacilityParameter shutinPressure;
        /// <summary>
        /// A pressure value within a non-flowing system.
        /// </summary>
        [EnumValueNameAttribute("shutin pressure")]
        public static FacilityParameter ShutinPressure
        {
            get 
            {
                return shutinPressure;
            }
        }

        private readonly static FacilityParameter shutinTemperature;
        /// <summary>
        /// A temperature value within a non-flowing system. 
        /// </summary>
        [EnumValueNameAttribute("shutin temperature")]
        public static FacilityParameter ShutinTemperature
        {
            get 
            {
                return shutinTemperature;
            }
        }

        private readonly static FacilityParameter solidAngleClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("solid angle class")]
        public static FacilityParameter SolidAngleClass
        {
            get 
            {
                return solidAngleClass;
            }
        }

        private readonly static FacilityParameter specificActivityOfRadioactivity;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific activity (of radioactivity)")]
        public static FacilityParameter SpecificActivityOfRadioactivity
        {
            get 
            {
                return specificActivityOfRadioactivity;
            }
        }

        private readonly static FacilityParameter specificEnergyClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific energy class")]
        public static FacilityParameter SpecificEnergyClass
        {
            get 
            {
                return specificEnergyClass;
            }
        }

        private readonly static FacilityParameter specificGravity;
        /// <summary>
        /// The specific gravity of the flow stream or a specified component product within the flow. Equivalent to element sg in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("specific gravity")]
        public static FacilityParameter SpecificGravity
        {
            get 
            {
                return specificGravity;
            }
        }

        private readonly static FacilityParameter specificHeatCapacityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific heat capacity class")]
        public static FacilityParameter SpecificHeatCapacityClass
        {
            get 
            {
                return specificHeatCapacityClass;
            }
        }

        private readonly static FacilityParameter specificProductivityIndexClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific productivity index class")]
        public static FacilityParameter SpecificProductivityIndexClass
        {
            get 
            {
                return specificProductivityIndexClass;
            }
        }

        private readonly static FacilityParameter specificVolumeClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("specific volume class")]
        public static FacilityParameter SpecificVolumeClass
        {
            get 
            {
                return specificVolumeClass;
            }
        }

        private readonly static FacilityParameter subSurfaceSafetyValveStatus;
        /// <summary>
        /// Status of the Sub Surface Safety Valve.
        /// </summary>
        [EnumValueNameAttribute("sub surface safety valve status")]
        public static FacilityParameter SubSurfaceSafetyValveStatus
        {
            get 
            {
                return subSurfaceSafetyValveStatus;
            }
        }

        private readonly static FacilityParameter surfaceDensityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("surface density class")]
        public static FacilityParameter SurfaceDensityClass
        {
            get 
            {
                return surfaceDensityClass;
            }
        }

        private readonly static FacilityParameter surfaceSafetyValveStatus;
        /// <summary>
        /// Status of the Surface Safety Valve.
        /// </summary>
        [EnumValueNameAttribute("surface safety valve status")]
        public static FacilityParameter SurfaceSafetyValveStatus
        {
            get 
            {
                return surfaceSafetyValveStatus;
            }
        }

        private readonly static FacilityParameter tankFluidLevel;
        /// <summary>
        /// The vertical height of the specified product in a tank.
        /// </summary>
        [EnumValueNameAttribute("tank fluid level")]
        public static FacilityParameter TankFluidLevel
        {
            get 
            {
                return tankFluidLevel;
            }
        }

        private readonly static FacilityParameter tankProductStandardVolume;
        /// <summary>
        /// The volume of the specified product in a tank, corrected to standard conditions of temperature and pressure.
        /// </summary>
        [EnumValueNameAttribute("tank product standard volume")]
        public static FacilityParameter TankProductStandardVolume
        {
            get 
            {
                return tankProductStandardVolume;
            }
        }

        private readonly static FacilityParameter tankProductVolume;
        /// <summary>
        /// The volume of the specified product in a tank.
        /// </summary>
        [EnumValueNameAttribute("tank product volume")]
        public static FacilityParameter TankProductVolume
        {
            get 
            {
                return tankProductVolume;
            }
        }

        private readonly static FacilityParameter temperature;
        /// <summary>
        /// The temperature of the context for the property (e.g.,a flow stream or a facility). Equivalent to element temp in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("temperature")]
        public static FacilityParameter Temperature
        {
            get 
            {
                return temperature;
            }
        }

        private readonly static FacilityParameter temperaturePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per length")]
        public static FacilityParameter TemperaturePerLength
        {
            get 
            {
                return temperaturePerLength;
            }
        }

        private readonly static FacilityParameter temperaturePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("temperature per time")]
        public static FacilityParameter TemperaturePerTime
        {
            get 
            {
                return temperaturePerTime;
            }
        }

        private readonly static FacilityParameter thermalConductanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductance class")]
        public static FacilityParameter ThermalConductanceClass
        {
            get 
            {
                return thermalConductanceClass;
            }
        }

        private readonly static FacilityParameter thermalConductivityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal conductivity class")]
        public static FacilityParameter ThermalConductivityClass
        {
            get 
            {
                return thermalConductivityClass;
            }
        }

        private readonly static FacilityParameter thermalDiffusivityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal diffusivity class")]
        public static FacilityParameter ThermalDiffusivityClass
        {
            get 
            {
                return thermalDiffusivityClass;
            }
        }

        private readonly static FacilityParameter thermalInsulanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal insulance class")]
        public static FacilityParameter ThermalInsulanceClass
        {
            get 
            {
                return thermalInsulanceClass;
            }
        }

        private readonly static FacilityParameter thermalResistanceClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermal resistance class")]
        public static FacilityParameter ThermalResistanceClass
        {
            get 
            {
                return thermalResistanceClass;
            }
        }

        private readonly static FacilityParameter thermodynamicTemperatureClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("thermodynamic temperature class")]
        public static FacilityParameter ThermodynamicTemperatureClass
        {
            get 
            {
                return thermodynamicTemperatureClass;
            }
        }

        private readonly static FacilityParameter timeClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time class")]
        public static FacilityParameter TimeClass
        {
            get 
            {
                return timeClass;
            }
        }

        private readonly static FacilityParameter timePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per length")]
        public static FacilityParameter TimePerLength
        {
            get 
            {
                return timePerLength;
            }
        }

        private readonly static FacilityParameter timePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("time per volume")]
        public static FacilityParameter TimePerVolume
        {
            get 
            {
                return timePerVolume;
            }
        }

        private readonly static FacilityParameter trueVaporPressure;
        /// <summary>
        /// True vapor pressure of the flow stream or a specified component product within the flow The equilibrium partial pressure exerted by a petroleum liquid as determined in accordance with standard methods. Equivalent to element tvp in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("true vapor pressure")]
        public static FacilityParameter TrueVaporPressure
        {
            get 
            {
                return trueVaporPressure;
            }
        }

        private readonly static FacilityParameter unitProductivityIndexClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("unit productivity index class")]
        public static FacilityParameter UnitProductivityIndexClass
        {
            get 
            {
                return unitProductivityIndexClass;
            }
        }

        private readonly static FacilityParameter unitless;
        /// <summary>
        /// The abstract supertype of all floating point properties with NO unit of measure. In order to allow the unit information to be required for all continuous properties, the special unit of measure of "NONE" has been assigned to all children of this class. In addition, the special dimensional class of "0" has been assigned to all children of this class.
        /// </summary>
        [EnumValueNameAttribute("unitless")]
        public static FacilityParameter Unitless
        {
            get 
            {
                return unitless;
            }
        }

        private readonly static FacilityParameter valveOpening;
        /// <summary>
        /// Indicates the open area of a valve. A value of zero indicates that it is closed.
        /// </summary>
        [EnumValueNameAttribute("valve opening")]
        public static FacilityParameter ValveOpening
        {
            get 
            {
                return valveOpening;
            }
        }

        private readonly static FacilityParameter valveStatus;
        /// <summary>
        /// A coded value describing the status of a valve. 
        /// </summary>
        [EnumValueNameAttribute("valve status")]
        public static FacilityParameter ValveStatus
        {
            get 
            {
                return valveStatus;
            }
        }

        private readonly static FacilityParameter velocityClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("velocity class")]
        public static FacilityParameter VelocityClass
        {
            get 
            {
                return velocityClass;
            }
        }

        private readonly static FacilityParameter volume;
        /// <summary>
        /// The volume of the context for the property (e.g., a flow stream or a specified component product within the flow). Equivalent to element volumeValue in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("volume")]
        public static FacilityParameter Volume
        {
            get 
            {
                return volume;
            }
        }

        private readonly static FacilityParameter volumeClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume class")]
        public static FacilityParameter VolumeClass
        {
            get 
            {
                return volumeClass;
            }
        }

        private readonly static FacilityParameter volumeConcentration;
        /// <summary>
        /// The concentration of the specified component product as a volume percentage of the flow stream. Equivalent to element concentration in the productVolume data-schema. The volumes related to each component should have been at or converted to the same pressure and temperature.
        /// </summary>
        [EnumValueNameAttribute("volume concentration")]
        public static FacilityParameter VolumeConcentration
        {
            get 
            {
                return volumeConcentration;
            }
        }

        private readonly static FacilityParameter volumeFlowRateClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume flow rate class")]
        public static FacilityParameter VolumeFlowRateClass
        {
            get 
            {
                return volumeFlowRateClass;
            }
        }

        private readonly static FacilityParameter volumeLengthPerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume length per time")]
        public static FacilityParameter VolumeLengthPerTime
        {
            get 
            {
                return volumeLengthPerTime;
            }
        }

        private readonly static FacilityParameter volumePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per area")]
        public static FacilityParameter VolumePerArea
        {
            get 
            {
                return volumePerArea;
            }
        }

        private readonly static FacilityParameter volumePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per length")]
        public static FacilityParameter VolumePerLength
        {
            get 
            {
                return volumePerLength;
            }
        }

        private readonly static FacilityParameter volumePerTimePerArea;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per area")]
        public static FacilityParameter VolumePerTimePerArea
        {
            get 
            {
                return volumePerTimePerArea;
            }
        }

        private readonly static FacilityParameter volumePerTimePerLength;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per length")]
        public static FacilityParameter VolumePerTimePerLength
        {
            get 
            {
                return volumePerTimePerLength;
            }
        }

        private readonly static FacilityParameter volumePerTimePerTime;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per time")]
        public static FacilityParameter VolumePerTimePerTime
        {
            get 
            {
                return volumePerTimePerTime;
            }
        }

        private readonly static FacilityParameter volumePerTimePerVolume;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volume per time per volume")]
        public static FacilityParameter VolumePerTimePerVolume
        {
            get 
            {
                return volumePerTimePerVolume;
            }
        }

        private readonly static FacilityParameter volumePerVolume;
        /// <summary>
        /// A dimensionless quantity where the basis of the ratio is volume.
        /// </summary>
        [EnumValueNameAttribute("volume per volume")]
        public static FacilityParameter VolumePerVolume
        {
            get 
            {
                return volumePerVolume;
            }
        }

        private readonly static FacilityParameter volumeStandard;
        /// <summary>
        /// The volume of the context for the property (e.g., a flow stream or a specified component product within the flow) corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element volumeValue in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("volume standard")]
        public static FacilityParameter VolumeStandard
        {
            get 
            {
                return volumeStandard;
            }
        }

        private readonly static FacilityParameter volumetricEfficiency;
        /// <summary>
        /// The actual volume divided by the potential volume. Equivalent to element efficiency in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("volumetric efficiency")]
        public static FacilityParameter VolumetricEfficiency
        {
            get 
            {
                return volumetricEfficiency;
            }
        }

        private readonly static FacilityParameter volumetricHeatTransferCoefficient;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric heat transfer coefficient")]
        public static FacilityParameter VolumetricHeatTransferCoefficient
        {
            get 
            {
                return volumetricHeatTransferCoefficient;
            }
        }

        private readonly static FacilityParameter volumetricThermalExpansionClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("volumetric thermal expansion class")]
        public static FacilityParameter VolumetricThermalExpansionClass
        {
            get 
            {
                return volumetricThermalExpansionClass;
            }
        }

        private readonly static FacilityParameter wellOperatingStatus;
        /// <summary>
        /// A coded value describing operating status of a well.
        /// </summary>
        [EnumValueNameAttribute("well operating status")]
        public static FacilityParameter WellOperatingStatus
        {
            get 
            {
                return wellOperatingStatus;
            }
        }

        private readonly static FacilityParameter wellOperationType;
        /// <summary>
        /// This commonly called the "well type". It characterizes the well based on its mode of lifting the product. This should be implemented as a string value.
        /// </summary>
        [EnumValueNameAttribute("well operation type")]
        public static FacilityParameter WellOperationType
        {
            get 
            {
                return wellOperationType;
            }
        }

        private readonly static FacilityParameter wobbeIndex;
        /// <summary>
        /// The Wobbe Index is a number which indicates interchangeability of fuel gasses and is obtained by dividing the heating value of a gas by the square root of its specific gravity. Equivalent to element wobbeIndex in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("wobbe index")]
        public static FacilityParameter WobbeIndex
        {
            get 
            {
                return wobbeIndex;
            }
        }

        private readonly static FacilityParameter work;
        /// <summary>
        /// The electrical energy represented by the flow stream or a specified component product within the flow. Equivalent to element work in the productVolume data-schema.
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static FacilityParameter Work
        {
            get 
            {
                return work;
            }
        }

        private readonly static FacilityParameter workClass;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("work class")]
        public static FacilityParameter WorkClass
        {
            get 
            {
                return workClass;
            }
        }

        private readonly static FacilityParameter unknown;
        /// <summary>
        /// The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FacilityParameter Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FacilityParameter()
        {
            absorbedDoseClass = 
                new FacilityParameter("absorbed dose class")
                {
                    Description = "The amount of energy absorbed per mass."
            };
            accelerationLinearClass = 
                new FacilityParameter("acceleration linear class")
                {
            };
            activityOfRadioactivityClass = 
                new FacilityParameter("activity (of radioactivity) class")
                {
                    Description = "A measure of the radiation being emitted."
            };
            alarmAbsolutePressure = 
                new FacilityParameter("alarm absolute pressure")
                {
                    Description = "Absolute minimum pressure of the flow stream before the system will give an alarm. Equivalent to element absoluteMinPres in the productVolume data-schema."
            };
            amountOfSubstanceClass = 
                new FacilityParameter("amount of substance class")
                {
                    Description = "Molar amount of a substance."
            };
            anglePerLength = 
                new FacilityParameter("angle per length")
                {
            };
            anglePerTime = 
                new FacilityParameter("angle per time")
                {
                    Description = "The angular velocity. The rate of change of an angle."
            };
            anglePerVolume = 
                new FacilityParameter("angle per volume")
                {
            };
            angularAccelerationClass = 
                new FacilityParameter("angular acceleration class")
                {
            };
            annulusInnerDiameter = 
                new FacilityParameter("annulus inner diameter")
                {
                    Description = "Inner diameter of Annulus."
            };
            annulusOuterDiameter = 
                new FacilityParameter("annulus outer diameter")
                {
                    Description = "Outer diameter of annulus."
            };
            areaClass = 
                new FacilityParameter("area class")
                {
            };
            areaPerArea = 
                new FacilityParameter("area per area")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is area."
            };
            areaPerVolume = 
                new FacilityParameter("area per volume")
                {
            };
            atmosphericPressure = 
                new FacilityParameter("atmospheric pressure")
                {
                    Description = " The average atmospheric pressure during the reporting period. Equivalent to element atmosphere in the productVolume data-schema. "
            };
            attenuationClass = 
                new FacilityParameter("attenuation class")
                {
                    Description = " A logarithmic, fractional change of some measure, generally power or amplitude, over a standard range. This is generally used for frequency attenuation over an octave. "
            };
            attenuationPerLength = 
                new FacilityParameter("attenuation per length")
                {
            };
            available = 
                new FacilityParameter("available")
                {
                    Description = " Indicates the availability of the facility. This should be implemented as a string value. A value of \"true\" indicates that it is available for use. That is, it may be currently shut-down but it can be restarted. A value of \"false\" indicates that the facility is not available to be used. That is, it cannot be restarted at this time. "
            };
            availableRoom = 
                new FacilityParameter("available room")
                {
                    Description = "Defines the unoccupied volume of a tank. Zero indicates that the tank is full."
            };
            blockValveStatus = 
                new FacilityParameter("block valve status")
                {
                    Description = " Indicates the status of a block valve. This should be implemented as a string value. A value of \"open\" indicates that it is open. A value of \"closed\" indicates that it is closed. "
            };
            capacitanceClass = 
                new FacilityParameter("capacitance class")
                {
            };
            categorical = 
                new FacilityParameter("categorical")
                {
                    Description = "The abstract supertype of all enumerated string properties."
            };
            cathodicProtectionOutputCurrent = 
                new FacilityParameter("cathodic protection output current")
                {
                    Description = "Rectifier DC Output."
            };
            cathodicProtectionOutputVoltage = 
                new FacilityParameter("cathodic protection output voltage")
                {
                    Description = "Rectifier DC Output."
            };
            chargeDensityClass = 
                new FacilityParameter("charge density class")
                {
            };
            chemicalPotentialClass = 
                new FacilityParameter("chemical potential class")
                {
            };
            chokePosition = 
                new FacilityParameter("choke position")
                {
                    Description = "A coded value describing the position of the choke (open, close, travelling)."
            };
            chokeSetting = 
                new FacilityParameter("choke setting")
                {
                    Description = "A fraction value (percentage) of the choke opening."
            };
            code = 
                new FacilityParameter("code")
                {
                    Description = "A property whose values are constrained to specific string values"
            };
            compressibilityClass = 
                new FacilityParameter("compressibility class")
                {
            };
            concentrationOfBClass = 
                new FacilityParameter("concentration of B class")
                {
                    Description = "molar concentration of a substance."
            };
            conductivityClass = 
                new FacilityParameter("conductivity class")
                {
            };
            continuous = 
                new FacilityParameter("continuous")
                {
                    Description = "The abstract supertype of all floating point properties."
            };
            crossSectionAbsorptionClass = 
                new FacilityParameter("cross section absorption class")
                {
            };
            currentDensityClass = 
                new FacilityParameter("current density class")
                {
            };
            darcyFlowCoefficientClass = 
                new FacilityParameter("Darcy flow coefficient class")
                {
            };
            dataTransmissionSpeedClass = 
                new FacilityParameter("data transmission speed class")
                {
                    Description = "used primarily for computer transmission rates."
            };
            deltaTemperatureClass = 
                new FacilityParameter("delta temperature class")
                {
                    Description = "Delta temperature refers to temperature differences. For non-zero offset temperature scales, Fahrenheit and Celsius, the conversion formulas are different than for absolute temperatures."
            };
            density = 
                new FacilityParameter("density")
                {
                    Description = "The density of the flow stream or a specified component product within the flow. Equivalent to element densityValue in the productVolume data-schema."
            };
            densityClass = 
                new FacilityParameter("density class")
                {
            };
            densityFlowRate = 
                new FacilityParameter("density flow rate")
                {
                    Description = "The mass basis flow rate of the flow stream or a specified component product within the flow. This is used for things like a sand component. Equivalent to element densityFlowRate in the productVolume data-schema."
            };
            densityStandard = 
                new FacilityParameter("density standard")
                {
                    Description = "The density of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element densityValue in the productVolume data-schema."
            };
            dewpointTemperature = 
                new FacilityParameter("dewpoint temperature")
                {
                    Description = "The temperature at which the specified component product within the flow will start to condense out of the gaseous phase. Equivalent to element hcDewpoint or waterDewpoint (depending on the specified product) in the productVolume data-schema."
            };
            differentialPressure = 
                new FacilityParameter("differential pressure")
                {
                    Description = "The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/presDiff in the productVolume data-schema."
            };
            differentialTemperature = 
                new FacilityParameter("differential temperature")
                {
                    Description = "The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/tempDiff in the productVolume data-schema."
            };
            diffusionCoefficientClass = 
                new FacilityParameter("diffusion coefficient class")
                {
            };
            digitalStorageClass = 
                new FacilityParameter("digital storage class")
                {
            };
            dimensionlessClass = 
                new FacilityParameter("dimensionless class")
                {
                    Description = "A dimensionless quantity is the ratio of two dimensional quantities. The quantity types are not apparent from the basic dimensionless class, but may be apparent in variations - such as area per area, volume per volume, or mass per mass."
            };
            discrete = 
                new FacilityParameter("discrete")
                {
                    Description = "The abstract super-type of all integer properties."
            };
            doseEquivalentClass = 
                new FacilityParameter("dose equivalent class")
                {
            };
            doseEquivalentRateClass = 
                new FacilityParameter("dose equivalent rate class")
                {
            };
            dynamicViscosityClass = 
                new FacilityParameter("dynamic viscosity class")
                {
            };
            electricChargeClass = 
                new FacilityParameter("electric charge class")
                {
            };
            electricConductanceClass = 
                new FacilityParameter("electric conductance class")
                {
            };
            electricCurrentClass = 
                new FacilityParameter("electric current class")
                {
            };
            electricDipoleMomentClass = 
                new FacilityParameter("electric dipole moment class")
                {
            };
            electricFieldStrengthClass = 
                new FacilityParameter("electric field strength class")
                {
            };
            electricPolarizationClass = 
                new FacilityParameter("electric polarization class")
                {
            };
            electricPotentialClass = 
                new FacilityParameter("electric potential class")
                {
            };
            electricalResistivityClass = 
                new FacilityParameter("electrical resistivity class")
                {
            };
            electrochemicalEquivalentClass = 
                new FacilityParameter("electrochemical equivalent class")
                {
                    Description = "An electrochemical equivalent differs from molarity in that the valence (oxidation reduction potential) of the element is also considered."
            };
            electromagneticMomentClass = 
                new FacilityParameter("electromagnetic moment class")
                {
            };
            energyLengthPerArea = 
                new FacilityParameter("energy length per area")
                {
            };
            energyLengthPerTimeAreaTemperature = 
                new FacilityParameter("energy length per time area temperature")
                {
            };
            energyPerArea = 
                new FacilityParameter("energy per area")
                {
            };
            energyPerLength = 
                new FacilityParameter("energy per length")
                {
            };
            equivalentPerMass = 
                new FacilityParameter("equivalent per mass")
                {
            };
            equivalentPerVolume = 
                new FacilityParameter("equivalent per volume")
                {
            };
            exposureRadioactivityClass = 
                new FacilityParameter("exposure (radioactivity) class")
                {
            };
            facilityUptime = 
                new FacilityParameter("facility uptime")
                {
                    Description = "The amount to time the facility was available during the specified period."
            };
            flowRate = 
                new FacilityParameter("flow rate")
                {
                    Description = "The flow rate of the flow stream or a specified component product within the flow. Equivalent to element flowRateValue in the productVolume data-schema."
            };
            flowRateStandard = 
                new FacilityParameter("flow rate standard")
                {
                    Description = "The flow rate of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element flowRateValue in the productVolume data-schema."
            };
            forceAreaClass = 
                new FacilityParameter("force area class")
                {
            };
            forceClass = 
                new FacilityParameter("force class")
                {
            };
            forceLengthPerLength = 
                new FacilityParameter("force length per length")
                {
            };
            forcePerForce = 
                new FacilityParameter("force per force")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is force."
            };
            forcePerLength = 
                new FacilityParameter("force per length")
                {
            };
            forcePerVolume = 
                new FacilityParameter("force per volume")
                {
            };
            frequencyClass = 
                new FacilityParameter("frequency class")
                {
            };
            frequencyIntervalClass = 
                new FacilityParameter("frequency interval class")
                {
                    Description = "An octave is a doubling of a frquency."
            };
            gammaRayApiUnitClass = 
                new FacilityParameter("gamma ray API unit class")
                {
                    Description = "This class is defined by the API, and is used for units of gamma ray log response."
            };
            gasLiquidRatio = 
                new FacilityParameter("gas liquid ratio")
                {
                    Description = "The ratio of ratio of gas to liquid for all products in the whole flow stream. Equivalent to element gasLiquidRatio in the productVolume data-schema. The volumes related to each component should have been at or converted to the same pressure and temperature."
            };
            gasOilRatio = 
                new FacilityParameter("gas oil ratio")
                {
                    Description = "Gas oil ratio. The ratio between the total gas volume and the total oil volume in the flow stream. Equivalent to element gor in the productVolume data-schema. The volumes related to each component should have been at or converted to the same pressure and temperature."
            };
            grossCalorificValueStandard = 
                new FacilityParameter("gross calorific value standard")
                {
                    Description = "The amount of heat which would be released by the complete combustion in air of a specific quantity of a specified component product at standard temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element grossCalorificValueStd in the productVolume data-schema."
            };
            heatCapacityClass = 
                new FacilityParameter("heat capacity class")
                {
            };
            heatFlowRateClass = 
                new FacilityParameter("heat flow rate class")
                {
            };
            heatTransferCoefficientClass = 
                new FacilityParameter("heat transfer coefficient class")
                {
                    Description = "PRESSURE PER VELOCITY PER AREA"
            };
            illuminanceClass = 
                new FacilityParameter("illuminance class")
                {
            };
            internalControlValveStatus = 
                new FacilityParameter("internal control valve status")
                {
                    Description = "The status of which the Internal Coltrol Valve sleeve is set to."
            };
            irradianceClass = 
                new FacilityParameter("irradiance class")
                {
            };
            isothermalCompressibilityClass = 
                new FacilityParameter("isothermal compressibility class")
                {
            };
            kinematicViscosityClass = 
                new FacilityParameter("kinematic viscosity class")
                {
            };
            lengthClass = 
                new FacilityParameter("length class")
                {
            };
            lengthPerLength = 
                new FacilityParameter("length per length")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is length."
            };
            lengthPerTemperature = 
                new FacilityParameter("length per temperature")
                {
            };
            lengthPerVolume = 
                new FacilityParameter("length per volume")
                {
            };
            levelOfPowerIntensityClass = 
                new FacilityParameter("level of power intensity class")
                {
            };
            lightExposureClass = 
                new FacilityParameter("light exposure class")
                {
            };
            linearThermalExpansionClass = 
                new FacilityParameter("linear thermal expansion class")
                {
            };
            luminanceClass = 
                new FacilityParameter("luminance class")
                {
            };
            luminousEfficacyClass = 
                new FacilityParameter("luminous efficacy class")
                {
            };
            luminousFluxClass = 
                new FacilityParameter("luminous flux class")
                {
            };
            luminousIntensityClass = 
                new FacilityParameter("luminous intensity class")
                {
            };
            magneticDipoleMomentClass = 
                new FacilityParameter("magnetic dipole moment class")
                {
            };
            magneticFieldStrengthClass = 
                new FacilityParameter("magnetic field strength class")
                {
            };
            magneticFluxClass = 
                new FacilityParameter("magnetic flux class")
                {
            };
            magneticInductionClass = 
                new FacilityParameter("magnetic induction class")
                {
            };
            magneticPermeabilityClass = 
                new FacilityParameter("magnetic permeability class")
                {
            };
            magneticVectorPotentialClass = 
                new FacilityParameter("magnetic vector potential class")
                {
            };
            mass = 
                new FacilityParameter("mass")
                {
                    Description = "The mass of the flow stream or a specified component product within the flow. Equivalent to element mass in the productVolume data-schema."
            };
            massAttenuationCoefficientClass = 
                new FacilityParameter("mass attenuation coefficient class")
                {
            };
            massClass = 
                new FacilityParameter("mass class")
                {
                    Description = "M/L2T"
            };
            massConcentration = 
                new FacilityParameter("mass concentration")
                {
                    Description = "The concentration of the specified component product as a weight percentage of the flow stream. Equivalent to element weightPercent in the productVolume data-schema."
            };
            massConcentrationClass = 
                new FacilityParameter("mass concentration class")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is mass."
            };
            massFlowRateClass = 
                new FacilityParameter("mass flow rate class")
                {
            };
            massLengthClass = 
                new FacilityParameter("mass length class")
                {
            };
            massPerEnergy = 
                new FacilityParameter("mass per energy")
                {
            };
            massPerLength = 
                new FacilityParameter("mass per length")
                {
                    Description = "M /L4T"
            };
            massPerTimePerArea = 
                new FacilityParameter("mass per time per area")
                {
            };
            massPerTimePerLength = 
                new FacilityParameter("mass per time per length")
                {
            };
            massPerVolumePerLength = 
                new FacilityParameter("mass per volume per length")
                {
            };
            measuredDepth = 
                new FacilityParameter("measured depth")
                {
                    Description = "Measured depth of the specified facility with respect to the specified datum."
            };
            mobilityClass = 
                new FacilityParameter("mobility class")
                {
            };
            modulusOfCompressionClass = 
                new FacilityParameter("modulus of compression class")
                {
            };
            molarConcentration = 
                new FacilityParameter("molar concentration")
                {
                    Description = "The molar amount of a specified component product. Equivalent to element moleAmt in the productVolume data-schema."
            };
            molarFraction = 
                new FacilityParameter("molar fraction")
                {
                    Description = "The molar fraction of the specified component product as a molar amount percentage of the flow stream. Equivalent to element molePercent in the productVolume data-schema."
            };
            molarHeatCapacityClass = 
                new FacilityParameter("molar heat capacity class")
                {
            };
            molarVolumeClass = 
                new FacilityParameter("molar volume class")
                {
            };
            molePerArea = 
                new FacilityParameter("mole per area")
                {
            };
            molePerTime = 
                new FacilityParameter("mole per time")
                {
            };
            molePerTimePerArea = 
                new FacilityParameter("mole per time per area")
                {
            };
            molecularWeight = 
                new FacilityParameter("molecular weight")
                {
                    Description = "The molecular weight of a specified component product. Equivalent to element molecularWeight in the productVolume data-schema."
            };
            momentOfForceClass = 
                new FacilityParameter("moment of force class")
                {
            };
            momentOfInertiaClass = 
                new FacilityParameter("moment of inertia class")
                {
            };
            momentOfSectionClass = 
                new FacilityParameter("moment of section class")
                {
            };
            momentumClass = 
                new FacilityParameter("momentum class")
                {
            };
            motorCurrent = 
                new FacilityParameter("motor current")
                {
                    Description = "Current at which the motor operates."
            };
            motorCurrentLeakage = 
                new FacilityParameter("motor current leakage")
                {
                    Description = "Leakage current of the motor."
            };
            motorSpeed = 
                new FacilityParameter("motor speed")
                {
                    Description = "Speed at which the motor operates."
            };
            motorTemperature = 
                new FacilityParameter("motor temperature")
                {
                    Description = "Motor temperature."
            };
            motorVibration = 
                new FacilityParameter("motor vibration")
                {
                    Description = "The vibration (distortion) of which the motor produces."
            };
            motorVoltage = 
                new FacilityParameter("motor voltage")
                {
                    Description = "Voltage at which the motor Operates."
            };
            neutronApiUnitClass = 
                new FacilityParameter("neutron API unit class")
                {
            };
            nondarcyFlowCoefficientClass = 
                new FacilityParameter("nonDarcy flow coefficient class")
                {
            };
            openingSize = 
                new FacilityParameter("opening size")
                {
                    Description = "The size of an opening. For example, a valve diameter. A value of zero indicates that it is closed."
            };
            operationsPerTime = 
                new FacilityParameter("operations per time")
                {
            };
            parachorClass = 
                new FacilityParameter("parachor class")
                {
            };
            perArea = 
                new FacilityParameter("per area")
                {
            };
            perElectricPotential = 
                new FacilityParameter("per electric potential")
                {
            };
            perForce = 
                new FacilityParameter("per force")
                {
            };
            perLength = 
                new FacilityParameter("per length")
                {
            };
            perMass = 
                new FacilityParameter("per mass")
                {
            };
            perVolume = 
                new FacilityParameter("per volume")
                {
            };
            permeabilityLengthClass = 
                new FacilityParameter("permeability length class")
                {
            };
            permeabilityRockClass = 
                new FacilityParameter("permeability rock class")
                {
            };
            permeanceClass = 
                new FacilityParameter("permeance class")
                {
            };
            permittivityClass = 
                new FacilityParameter("permittivity class")
                {
            };
            phClass = 
                new FacilityParameter("pH class")
                {
                    Description = "The pH is a class that measures the hydrogen ion concentration (acidity)."
            };
            planeAngleClass = 
                new FacilityParameter("plane angle class")
                {
            };
            potentialDifferencePerPowerDrop = 
                new FacilityParameter("potential difference per power drop")
                {
            };
            powerClass = 
                new FacilityParameter("power class")
                {
            };
            powerPerVolume = 
                new FacilityParameter("power per volume")
                {
            };
            pressure = 
                new FacilityParameter("pressure")
                {
                    Description = "Pressure in the flow stream. Equivalent to element pres in the productVolume data-schema."
            };
            pressureClass = 
                new FacilityParameter("pressure class")
                {
            };
            pressurePerTime = 
                new FacilityParameter("pressure per time")
                {
            };
            pressureSquaredClass = 
                new FacilityParameter("pressure squared class")
                {
            };
            pressureSquaredPerForceTimePerArea = 
                new FacilityParameter("pressure squared per force time per area")
                {
            };
            pressureTimePerVolume = 
                new FacilityParameter("pressure time per volume")
                {
            };
            productivityIndexClass = 
                new FacilityParameter("productivity index class")
                {
            };
            pumpCountOnline = 
                new FacilityParameter("pump count online")
                {
                    Description = "The number of pumps which are active. This should be implemented as a whole numbered value."
            };
            pumpStatus = 
                new FacilityParameter("pump status")
                {
                    Description = "The operating status of the pump."
            };
            quantity = 
                new FacilityParameter("quantity")
                {
                    Description = "The abstract super-type of all floating point properties with a unit of measure."
            };
            quantityOfLightClass = 
                new FacilityParameter("quantity of light class")
                {
            };
            radianceClass = 
                new FacilityParameter("radiance class")
                {
            };
            radiantIntensityClass = 
                new FacilityParameter("radiant intensity class")
                {
            };
            reciprocatingSpeed = 
                new FacilityParameter("reciprocating speed")
                {
                    Description = "The reciprocating speed of a device (e.g., motor, compressor). "
            };
            rectifierStructurePotential = 
                new FacilityParameter("rectifier structure potential")
                {
                    Description = "Rectifier Structure Potential."
            };
            reidVaporPressure = 
                new FacilityParameter("reid vapor pressure")
                {
                    Description = "Reid vapor pressure of the flow stream or a specified component product within the flow. The absolute vapor pressure of volatile crude oil and volatile petroleum liquids, except liquefied petroleum gases, as determined in accordance with American Society for Testing and Materials under the designation ASTM D323-56. Equivalent to element rvp in the productVolume data-schema."
            };
            relativeOpeningSize = 
                new FacilityParameter("relative opening size")
                {
                    Description = "The size of an opening. A value of 100 % indicates that it is open. A value of zero indicates that it is closed."
            };
            relativePowerClass = 
                new FacilityParameter("relative power class")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is power."
            };
            relativeTankLevel = 
                new FacilityParameter("relative tank level")
                {
                    Description = "Defines the relative level of a tank. Zero indicates empty and 100% indicates full. "
            };
            relativeTimeClass = 
                new FacilityParameter("relative time class")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is time."
            };
            relativeValveOpening = 
                new FacilityParameter("relative valve opening")
                {
                    Description = "Indicates the status of a valve. A value of 100 % indicates that it is open. A value of zero indicates that it is closed."
            };
            reluctanceClass = 
                new FacilityParameter("reluctance class")
                {
            };
            resistanceClass = 
                new FacilityParameter("resistance class")
                {
            };
            resistivityPerLength = 
                new FacilityParameter("resistivity per length")
                {
            };
            rootProperty = 
                new FacilityParameter("root property")
                {
                    Description = "The abstract supertype of all properties. This property does not have a parent."
            };
            scheduledDowntime = 
                new FacilityParameter("scheduled downtime")
                {
                    Description = "Indicates the amount of time the facility has been unavailable during the specified period. May be related to a particular point in time which would represent the start of the downtime."
            };
            secondMomentOfAreaClass = 
                new FacilityParameter("second moment of area class")
                {
            };
            shutdownOrder = 
                new FacilityParameter("shutdown order")
                {
                    Description = "Defines the relative order in which a facility should be shutdown. This should be implemented as a whole numbered count. Facilities with smaller values should be shut down first. Only facility parameters with the same version time and same version source should be evaluated together for the purposes of this order."
            };
            shutinPressure = 
                new FacilityParameter("shutin pressure")
                {
                    Description = "A pressure value within a non-flowing system."
            };
            shutinTemperature = 
                new FacilityParameter("shutin temperature")
                {
                    Description = "A temperature value within a non-flowing system. "
            };
            solidAngleClass = 
                new FacilityParameter("solid angle class")
                {
            };
            specificActivityOfRadioactivity = 
                new FacilityParameter("specific activity (of radioactivity)")
                {
            };
            specificEnergyClass = 
                new FacilityParameter("specific energy class")
                {
            };
            specificGravity = 
                new FacilityParameter("specific gravity")
                {
                    Description = "The specific gravity of the flow stream or a specified component product within the flow. Equivalent to element sg in the productVolume data-schema."
            };
            specificHeatCapacityClass = 
                new FacilityParameter("specific heat capacity class")
                {
            };
            specificProductivityIndexClass = 
                new FacilityParameter("specific productivity index class")
                {
            };
            specificVolumeClass = 
                new FacilityParameter("specific volume class")
                {
            };
            subSurfaceSafetyValveStatus = 
                new FacilityParameter("sub surface safety valve status")
                {
                    Description = "Status of the Sub Surface Safety Valve."
            };
            surfaceDensityClass = 
                new FacilityParameter("surface density class")
                {
            };
            surfaceSafetyValveStatus = 
                new FacilityParameter("surface safety valve status")
                {
                    Description = "Status of the Surface Safety Valve."
            };
            tankFluidLevel = 
                new FacilityParameter("tank fluid level")
                {
                    Description = "The vertical height of the specified product in a tank."
            };
            tankProductStandardVolume = 
                new FacilityParameter("tank product standard volume")
                {
                    Description = "The volume of the specified product in a tank, corrected to standard conditions of temperature and pressure."
            };
            tankProductVolume = 
                new FacilityParameter("tank product volume")
                {
                    Description = "The volume of the specified product in a tank."
            };
            temperature = 
                new FacilityParameter("temperature")
                {
                    Description = "The temperature of the context for the property (e.g.,a flow stream or a facility). Equivalent to element temp in the productVolume data-schema."
            };
            temperaturePerLength = 
                new FacilityParameter("temperature per length")
                {
            };
            temperaturePerTime = 
                new FacilityParameter("temperature per time")
                {
            };
            thermalConductanceClass = 
                new FacilityParameter("thermal conductance class")
                {
            };
            thermalConductivityClass = 
                new FacilityParameter("thermal conductivity class")
                {
            };
            thermalDiffusivityClass = 
                new FacilityParameter("thermal diffusivity class")
                {
            };
            thermalInsulanceClass = 
                new FacilityParameter("thermal insulance class")
                {
            };
            thermalResistanceClass = 
                new FacilityParameter("thermal resistance class")
                {
            };
            thermodynamicTemperatureClass = 
                new FacilityParameter("thermodynamic temperature class")
                {
            };
            timeClass = 
                new FacilityParameter("time class")
                {
            };
            timePerLength = 
                new FacilityParameter("time per length")
                {
            };
            timePerVolume = 
                new FacilityParameter("time per volume")
                {
            };
            trueVaporPressure = 
                new FacilityParameter("true vapor pressure")
                {
                    Description = "True vapor pressure of the flow stream or a specified component product within the flow The equilibrium partial pressure exerted by a petroleum liquid as determined in accordance with standard methods. Equivalent to element tvp in the productVolume data-schema."
            };
            unitProductivityIndexClass = 
                new FacilityParameter("unit productivity index class")
                {
            };
            unitless = 
                new FacilityParameter("unitless")
                {
                    Description = "The abstract supertype of all floating point properties with NO unit of measure. In order to allow the unit information to be required for all continuous properties, the special unit of measure of \"NONE\" has been assigned to all children of this class. In addition, the special dimensional class of \"0\" has been assigned to all children of this class."
            };
            valveOpening = 
                new FacilityParameter("valve opening")
                {
                    Description = "Indicates the open area of a valve. A value of zero indicates that it is closed."
            };
            valveStatus = 
                new FacilityParameter("valve status")
                {
                    Description = "A coded value describing the status of a valve. "
            };
            velocityClass = 
                new FacilityParameter("velocity class")
                {
            };
            volume = 
                new FacilityParameter("volume")
                {
                    Description = "The volume of the context for the property (e.g., a flow stream or a specified component product within the flow). Equivalent to element volumeValue in the productVolume data-schema."
            };
            volumeClass = 
                new FacilityParameter("volume class")
                {
            };
            volumeConcentration = 
                new FacilityParameter("volume concentration")
                {
                    Description = "The concentration of the specified component product as a volume percentage of the flow stream. Equivalent to element concentration in the productVolume data-schema. The volumes related to each component should have been at or converted to the same pressure and temperature."
            };
            volumeFlowRateClass = 
                new FacilityParameter("volume flow rate class")
                {
            };
            volumeLengthPerTime = 
                new FacilityParameter("volume length per time")
                {
            };
            volumePerArea = 
                new FacilityParameter("volume per area")
                {
            };
            volumePerLength = 
                new FacilityParameter("volume per length")
                {
            };
            volumePerTimePerArea = 
                new FacilityParameter("volume per time per area")
                {
            };
            volumePerTimePerLength = 
                new FacilityParameter("volume per time per length")
                {
            };
            volumePerTimePerTime = 
                new FacilityParameter("volume per time per time")
                {
            };
            volumePerTimePerVolume = 
                new FacilityParameter("volume per time per volume")
                {
            };
            volumePerVolume = 
                new FacilityParameter("volume per volume")
                {
                    Description = "A dimensionless quantity where the basis of the ratio is volume."
            };
            volumeStandard = 
                new FacilityParameter("volume standard")
                {
                    Description = "The volume of the context for the property (e.g., a flow stream or a specified component product within the flow) corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element volumeValue in the productVolume data-schema."
            };
            volumetricEfficiency = 
                new FacilityParameter("volumetric efficiency")
                {
                    Description = "The actual volume divided by the potential volume. Equivalent to element efficiency in the productVolume data-schema."
            };
            volumetricHeatTransferCoefficient = 
                new FacilityParameter("volumetric heat transfer coefficient")
                {
            };
            volumetricThermalExpansionClass = 
                new FacilityParameter("volumetric thermal expansion class")
                {
            };
            wellOperatingStatus = 
                new FacilityParameter("well operating status")
                {
                    Description = "A coded value describing operating status of a well."
            };
            wellOperationType = 
                new FacilityParameter("well operation type")
                {
                    Description = "This commonly called the \"well type\". It characterizes the well based on its mode of lifting the product. This should be implemented as a string value."
            };
            wobbeIndex = 
                new FacilityParameter("wobbe index")
                {
                    Description = "The Wobbe Index is a number which indicates interchangeability of fuel gasses and is obtained by dividing the heating value of a gas by the square root of its specific gravity. Equivalent to element wobbeIndex in the productVolume data-schema."
            };
            work = 
                new FacilityParameter("work")
                {
                    Description = "The electrical energy represented by the flow stream or a specified component product within the flow. Equivalent to element work in the productVolume data-schema."
            };
            workClass = 
                new FacilityParameter("work class")
                {
            };
            unknown = 
                new FacilityParameter("unknown")
                {
                    Description = "The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations."
            };
        }

        /// <summary>
        /// Gets a FacilityParameter by name
        /// </summary>
        /// <param name="name">The name of the FacilityParameter to return</param>
        /// <returns>The FacilityParameter represented by 'name'</returns>
        public static FacilityParameter GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FacilityParameter)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FacilityParameter)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FacilityParameter)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static FiberMode singlemode;
        /// <summary>
        ///  A single, narrow, core of constant refractive index, surrounded by glass cladding. The core diameter is comparable to a wave length of the light (about 5 um). 
        /// </summary>
        [EnumValueNameAttribute("singlemode")]
        public static FiberMode Singlemode
        {
            get 
            {
                return singlemode;
            }
        }

        private readonly static FiberMode multimode;
        /// <summary>
        ///  The core has a graded refractive index. The core is generally about 50um in diameter. 
        /// </summary>
        [EnumValueNameAttribute("multimode")]
        public static FiberMode Multimode
        {
            get 
            {
                return multimode;
            }
        }

        private readonly static FiberMode other;
        /// <summary>
        /// The fiber mode is neither singlemode or multimode.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static FiberMode Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static FiberMode unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FiberMode Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FiberMode()
        {
            singlemode = 
                new FiberMode("singlemode")
                {
                    Description = " A single, narrow, core of constant refractive index, surrounded by glass cladding. The core diameter is comparable to a wave length of the light (about 5 um). "
            };
            multimode = 
                new FiberMode("multimode")
                {
                    Description = " The core has a graded refractive index. The core is generally about 50um in diameter. "
            };
            other = 
                new FiberMode("other")
                {
                    Description = "The fiber mode is neither singlemode or multimode."
            };
            unknown = 
                new FiberMode("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FiberMode by name
        /// </summary>
        /// <param name="name">The name of the FiberMode to return</param>
        /// <returns>The FiberMode represented by 'name'</returns>
        public static FiberMode GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FiberMode)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FiberMode)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FiberMode)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static FlowQualifier allocated;
        /// <summary>
        ///  Indicates product characteristics that were allocated back to a well as opposed to being measured at the well. 
        /// </summary>
        [EnumValueNameAttribute("allocated")]
        public static FlowQualifier Allocated
        {
            get 
            {
                return allocated;
            }
        }

        private readonly static FlowQualifier budget;
        /// <summary>
        /// A performance requirement as determined by a budget.
        /// </summary>
        [EnumValueNameAttribute("budget")]
        public static FlowQualifier Budget
        {
            get 
            {
                return budget;
            }
        }

        private readonly static FlowQualifier constraint;
        /// <summary>
        ///  Indicates product characteristics that were determined by an allowable or other performance limit. This includes allowables which are usually established by a regulatory agency for a product. 
        /// </summary>
        [EnumValueNameAttribute("constraint")]
        public static FlowQualifier Constraint
        {
            get 
            {
                return constraint;
            }
        }

        private readonly static FlowQualifier difference;
        /// <summary>
        /// A value that is the difference between e.g. a target value and a metered value.
        /// </summary>
        [EnumValueNameAttribute("difference")]
        public static FlowQualifier Difference
        {
            get 
            {
                return difference;
            }
        }

        private readonly static FlowQualifier forecast;
        /// <summary>
        /// A forecast future value.
        /// </summary>
        [EnumValueNameAttribute("forecast")]
        public static FlowQualifier Forecast
        {
            get 
            {
                return forecast;
            }
        }

        private readonly static FlowQualifier derived;
        /// <summary>
        ///  Indicates product volumes that were derived directly from one or more other flows. 
        /// </summary>
        [EnumValueNameAttribute("derived")]
        public static FlowQualifier Derived
        {
            get 
            {
                return derived;
            }
        }

        private readonly static FlowQualifier estimate;
        /// <summary>
        ///  An estimated or calculated performance, possibly based on comparable product flow units, but not based on reservoir simulations for the particular product flow unit. 
        /// </summary>
        [EnumValueNameAttribute("estimate")]
        public static FlowQualifier Estimate
        {
            get 
            {
                return estimate;
            }
        }

        private readonly static FlowQualifier massAdjusted;
        /// <summary>
        /// The Flow is the resulting flow resulting from a mass adjustment process.
        /// </summary>
        [EnumValueNameAttribute("mass adjusted")]
        public static FlowQualifier MassAdjusted
        {
            get 
            {
                return massAdjusted;
            }
        }

        private readonly static FlowQualifier measured;
        /// <summary>
        ///  Indicates product volumes that were actually measured at the port. 
        /// </summary>
        [EnumValueNameAttribute("measured")]
        public static FlowQualifier Measured
        {
            get 
            {
                return measured;
            }
        }

        private readonly static FlowQualifier metered;
        /// <summary>
        /// A value that is read off an officially calibrated instrument (e.g. a gas chromatograph).
        /// </summary>
        [EnumValueNameAttribute("metered")]
        public static FlowQualifier Metered
        {
            get 
            {
                return metered;
            }
        }

        private readonly static FlowQualifier meteredFiscal;
        /// <summary>
        /// A value that is generated by measurement and calculation and has an impact on company revenue and government taxation.
        /// </summary>
        [EnumValueNameAttribute("metered - fiscal")]
        public static FlowQualifier MeteredFiscal
        {
            get 
            {
                return meteredFiscal;
            }
        }

        private readonly static FlowQualifier nominated;
        /// <summary>
        /// Normally a 1 day forecast promise to a buyer.
        /// </summary>
        [EnumValueNameAttribute("nominated")]
        public static FlowQualifier Nominated
        {
            get 
            {
                return nominated;
            }
        }

        private readonly static FlowQualifier potential;
        /// <summary>
        /// The estimated maximum which is possible.
        /// </summary>
        [EnumValueNameAttribute("potential")]
        public static FlowQualifier Potential
        {
            get 
            {
                return potential;
            }
        }

        private readonly static FlowQualifier processed;
        /// <summary>
        ///  A measured value that has been processed. This is different from derived because it is fundamentally a variation of the original value. 
        /// </summary>
        [EnumValueNameAttribute("processed")]
        public static FlowQualifier Processed
        {
            get 
            {
                return processed;
            }
        }

        private readonly static FlowQualifier quota;
        /// <summary>
        ///  An amount, set by some authority, which may or may not be based on technical criteria. 
        /// </summary>
        [EnumValueNameAttribute("quota")]
        public static FlowQualifier Quota
        {
            get 
            {
                return quota;
            }
        }

        private readonly static FlowQualifier recommended;
        /// <summary>
        ///  A value which is believed to be very desirable if it can be achieved. This a recommendation that something be changed in order to achieve this value. 
        /// </summary>
        [EnumValueNameAttribute("recommended")]
        public static FlowQualifier Recommended
        {
            get 
            {
                return recommended;
            }
        }

        private readonly static FlowQualifier simulated;
        /// <summary>
        ///  An estimated performance based on a simulation that includes the particular product flow unit. 
        /// </summary>
        [EnumValueNameAttribute("simulated")]
        public static FlowQualifier Simulated
        {
            get 
            {
                return simulated;
            }
        }

        private readonly static FlowQualifier target;
        /// <summary>
        /// The desired value. What you are aiming for.
        /// </summary>
        [EnumValueNameAttribute("target")]
        public static FlowQualifier Target
        {
            get 
            {
                return target;
            }
        }

        private readonly static FlowQualifier tariffBasis;
        /// <summary>
        ///  The flow represents the basis on which a tariff is charged, rather than necessarily the actual flow. 
        /// </summary>
        [EnumValueNameAttribute("tariff basis")]
        public static FlowQualifier TariffBasis
        {
            get 
            {
                return tariffBasis;
            }
        }

        private readonly static FlowQualifier valueAdjusted;
        /// <summary>
        /// A value that is adjusted due to a change in the value of a product.
        /// </summary>
        [EnumValueNameAttribute("value adjusted")]
        public static FlowQualifier ValueAdjusted
        {
            get 
            {
                return valueAdjusted;
            }
        }

        private readonly static FlowQualifier unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FlowQualifier Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FlowQualifier()
        {
            allocated = 
                new FlowQualifier("allocated")
                {
                    Description = " Indicates product characteristics that were allocated back to a well as opposed to being measured at the well. "
            };
            budget = 
                new FlowQualifier("budget")
                {
                    Description = "A performance requirement as determined by a budget."
            };
            constraint = 
                new FlowQualifier("constraint")
                {
                    Description = " Indicates product characteristics that were determined by an allowable or other performance limit. This includes allowables which are usually established by a regulatory agency for a product. "
            };
            difference = 
                new FlowQualifier("difference")
                {
                    Description = "A value that is the difference between e.g. a target value and a metered value."
            };
            forecast = 
                new FlowQualifier("forecast")
                {
                    Description = "A forecast future value."
            };
            derived = 
                new FlowQualifier("derived")
                {
                    Description = " Indicates product volumes that were derived directly from one or more other flows. "
            };
            estimate = 
                new FlowQualifier("estimate")
                {
                    Description = " An estimated or calculated performance, possibly based on comparable product flow units, but not based on reservoir simulations for the particular product flow unit. "
            };
            massAdjusted = 
                new FlowQualifier("mass adjusted")
                {
                    Description = "The Flow is the resulting flow resulting from a mass adjustment process."
            };
            measured = 
                new FlowQualifier("measured")
                {
                    Description = " Indicates product volumes that were actually measured at the port. "
            };
            metered = 
                new FlowQualifier("metered")
                {
                    Description = "A value that is read off an officially calibrated instrument (e.g. a gas chromatograph)."
            };
            meteredFiscal = 
                new FlowQualifier("metered - fiscal")
                {
                    Description = "A value that is generated by measurement and calculation and has an impact on company revenue and government taxation."
            };
            nominated = 
                new FlowQualifier("nominated")
                {
                    Description = "Normally a 1 day forecast promise to a buyer."
            };
            potential = 
                new FlowQualifier("potential")
                {
                    Description = "The estimated maximum which is possible."
            };
            processed = 
                new FlowQualifier("processed")
                {
                    Description = " A measured value that has been processed. This is different from derived because it is fundamentally a variation of the original value. "
            };
            quota = 
                new FlowQualifier("quota")
                {
                    Description = " An amount, set by some authority, which may or may not be based on technical criteria. "
            };
            recommended = 
                new FlowQualifier("recommended")
                {
                    Description = " A value which is believed to be very desirable if it can be achieved. This a recommendation that something be changed in order to achieve this value. "
            };
            simulated = 
                new FlowQualifier("simulated")
                {
                    Description = " An estimated performance based on a simulation that includes the particular product flow unit. "
            };
            target = 
                new FlowQualifier("target")
                {
                    Description = "The desired value. What you are aiming for."
            };
            tariffBasis = 
                new FlowQualifier("tariff basis")
                {
                    Description = " The flow represents the basis on which a tariff is charged, rather than necessarily the actual flow. "
            };
            valueAdjusted = 
                new FlowQualifier("value adjusted")
                {
                    Description = "A value that is adjusted due to a change in the value of a product."
            };
            unknown = 
                new FlowQualifier("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FlowQualifier by name
        /// </summary>
        /// <param name="name">The name of the FlowQualifier to return</param>
        /// <returns>The FlowQualifier represented by 'name'</returns>
        public static FlowQualifier GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FlowQualifier)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FlowQualifier)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FlowQualifier)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static FlowSubQualifier declineCurve;
        /// <summary>
        ///  Indicates a pseudo decline-curve of flow rate over time. This presumes that the flow will not be interrupted over that time period. Specialization of "forecast". 
        /// </summary>
        [EnumValueNameAttribute("decline curve")]
        public static FlowSubQualifier DeclineCurve
        {
            get 
            {
                return declineCurve;
            }
        }

        private readonly static FlowSubQualifier difference;
        /// <summary>
        ///  A value is derived by taking the difference between two other values. Specialization of "derived". 
        /// </summary>
        [EnumValueNameAttribute("difference")]
        public static FlowSubQualifier Difference
        {
            get 
            {
                return difference;
            }
        }

        private readonly static FlowSubQualifier fiscal;
        /// <summary>
        ///  The value was measured for fiscal purposes. Specialization of "measured". 
        /// </summary>
        [EnumValueNameAttribute("fiscal")]
        public static FlowSubQualifier Fiscal
        {
            get 
            {
                return fiscal;
            }
        }

        private readonly static FlowSubQualifier @fixed;
        /// <summary>
        ///  The value supplied is the only value permitted. Specialization of "constraint". 
        /// </summary>
        [EnumValueNameAttribute("fixed")]
        public static FlowSubQualifier Fixed
        {
            get 
            {
                return @fixed;
            }
        }

        private readonly static FlowSubQualifier minimum;
        /// <summary>
        ///  The value supplied is the minimum permitted. Specialization of "constraint". 
        /// </summary>
        [EnumValueNameAttribute("minimum")]
        public static FlowSubQualifier Minimum
        {
            get 
            {
                return minimum;
            }
        }

        private readonly static FlowSubQualifier maximum;
        /// <summary>
        ///  The value supplied is the maximum permitted. Specialization of "constraint". 
        /// </summary>
        [EnumValueNameAttribute("maximum")]
        public static FlowSubQualifier Maximum
        {
            get 
            {
                return maximum;
            }
        }

        private readonly static FlowSubQualifier raw;
        /// <summary>
        ///  The value is a raw measurement. Specialization of "measured". 
        /// </summary>
        [EnumValueNameAttribute("raw")]
        public static FlowSubQualifier Raw
        {
            get 
            {
                return raw;
            }
        }

        private readonly static FlowSubQualifier recalibrated;
        /// <summary>
        ///  The value has changed due to a recalibration of the sensor. Specialization of "measured". 
        /// </summary>
        [EnumValueNameAttribute("recalibrated")]
        public static FlowSubQualifier Recalibrated
        {
            get 
            {
                return recalibrated;
            }
        }

        private readonly static FlowSubQualifier standard;
        /// <summary>
        ///  A standard forecast as opposed to a decline curve. Specialization of "forecast". 
        /// </summary>
        [EnumValueNameAttribute("standard")]
        public static FlowSubQualifier Standard
        {
            get 
            {
                return standard;
            }
        }

        private readonly static FlowSubQualifier unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FlowSubQualifier Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FlowSubQualifier()
        {
            declineCurve = 
                new FlowSubQualifier("decline curve")
                {
                    Description = " Indicates a pseudo decline-curve of flow rate over time. This presumes that the flow will not be interrupted over that time period. Specialization of \"forecast\". "
            };
            difference = 
                new FlowSubQualifier("difference")
                {
                    Description = " A value is derived by taking the difference between two other values. Specialization of \"derived\". "
            };
            fiscal = 
                new FlowSubQualifier("fiscal")
                {
                    Description = " The value was measured for fiscal purposes. Specialization of \"measured\". "
            };
            @fixed = 
                new FlowSubQualifier("fixed")
                {
                    Description = " The value supplied is the only value permitted. Specialization of \"constraint\". "
            };
            minimum = 
                new FlowSubQualifier("minimum")
                {
                    Description = " The value supplied is the minimum permitted. Specialization of \"constraint\". "
            };
            maximum = 
                new FlowSubQualifier("maximum")
                {
                    Description = " The value supplied is the maximum permitted. Specialization of \"constraint\". "
            };
            raw = 
                new FlowSubQualifier("raw")
                {
                    Description = " The value is a raw measurement. Specialization of \"measured\". "
            };
            recalibrated = 
                new FlowSubQualifier("recalibrated")
                {
                    Description = " The value has changed due to a recalibration of the sensor. Specialization of \"measured\". "
            };
            standard = 
                new FlowSubQualifier("standard")
                {
                    Description = " A standard forecast as opposed to a decline curve. Specialization of \"forecast\". "
            };
            unknown = 
                new FlowSubQualifier("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FlowSubQualifier by name
        /// </summary>
        /// <param name="name">The name of the FlowSubQualifier to return</param>
        /// <returns>The FlowSubQualifier represented by 'name'</returns>
        public static FlowSubQualifier GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FlowSubQualifier)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FlowSubQualifier)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FlowSubQualifier)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static FluidAnalysisKind qualityControl;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("quality control")]
        public static FluidAnalysisKind QualityControl
        {
            get 
            {
                return qualityControl;
            }
        }

        private readonly static FluidAnalysisKind calc;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("calc")]
        public static FluidAnalysisKind Calc
        {
            get 
            {
                return calc;
            }
        }

        private readonly static FluidAnalysisKind bus;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("bus")]
        public static FluidAnalysisKind Bus
        {
            get 
            {
                return bus;
            }
        }

        private readonly static FluidAnalysisKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidAnalysisKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FluidAnalysisKind()
        {
            qualityControl = 
                new FluidAnalysisKind("quality control")
                {
                    Description = "xxxxxxxxxxxxxxxxxx"
            };
            calc = 
                new FluidAnalysisKind("calc")
                {
                    Description = "xxxxxxxxxxxxxxxxxx"
            };
            bus = 
                new FluidAnalysisKind("bus")
                {
                    Description = "xxxxxxxxxxxxxxxxxx"
            };
            unknown = 
                new FluidAnalysisKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FluidAnalysisKind by name
        /// </summary>
        /// <param name="name">The name of the FluidAnalysisKind to return</param>
        /// <returns>The FluidAnalysisKind represented by 'name'</returns>
        public static FluidAnalysisKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FluidAnalysisKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FluidAnalysisKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FluidAnalysisKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines, in a mixture such as an oil or gas, either a single chemical component, a group of isomeric chemicals or a fraction
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

        private readonly static FluidComponent hydrogen;
        /// <summary>
        /// The chemical hydrogen H2
        /// </summary>
        [EnumValueNameAttribute("hydrogen")]
        public static FluidComponent Hydrogen
        {
            get 
            {
                return hydrogen;
            }
        }

        private readonly static FluidComponent water;
        /// <summary>
        /// The chemical water H2O
        /// </summary>
        [EnumValueNameAttribute("water")]
        public static FluidComponent Water
        {
            get 
            {
                return water;
            }
        }

        private readonly static FluidComponent nitrogen;
        /// <summary>
        /// The chemical nitrogen N2
        /// </summary>
        [EnumValueNameAttribute("nitrogen")]
        public static FluidComponent Nitrogen
        {
            get 
            {
                return nitrogen;
            }
        }

        private readonly static FluidComponent oxygen;
        /// <summary>
        /// The chemical oxygen O2
        /// </summary>
        [EnumValueNameAttribute("oxygen")]
        public static FluidComponent Oxygen
        {
            get 
            {
                return oxygen;
            }
        }

        private readonly static FluidComponent hydrogenSulfide;
        /// <summary>
        /// The chemical hydrogen sulfide H2S
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide")]
        public static FluidComponent HydrogenSulfide
        {
            get 
            {
                return hydrogenSulfide;
            }
        }

        private readonly static FluidComponent argon;
        /// <summary>
        /// The chemical argon Ar
        /// </summary>
        [EnumValueNameAttribute("argon")]
        public static FluidComponent Argon
        {
            get 
            {
                return argon;
            }
        }

        private readonly static FluidComponent carbonDioxide;
        /// <summary>
        /// The chemical carbon dioxide CO2
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide")]
        public static FluidComponent CarbonDioxide
        {
            get 
            {
                return carbonDioxide;
            }
        }

        private readonly static FluidComponent methane;
        /// <summary>
        /// The chemical methane CH4
        /// </summary>
        [EnumValueNameAttribute("methane")]
        public static FluidComponent Methane
        {
            get 
            {
                return methane;
            }
        }

        private readonly static FluidComponent ethane;
        /// <summary>
        /// The chemical ethane C2H6
        /// </summary>
        [EnumValueNameAttribute("ethane")]
        public static FluidComponent Ethane
        {
            get 
            {
                return ethane;
            }
        }

        private readonly static FluidComponent propane;
        /// <summary>
        /// The chemical propane C3H8
        /// </summary>
        [EnumValueNameAttribute("propane")]
        public static FluidComponent Propane
        {
            get 
            {
                return propane;
            }
        }

        private readonly static FluidComponent twomethylpropane;
        /// <summary>
        /// The chemical 2-methylpropane C4H10
        /// </summary>
        [EnumValueNameAttribute("2-methylpropane")]
        public static FluidComponent Twomethylpropane
        {
            get 
            {
                return twomethylpropane;
            }
        }

        private readonly static FluidComponent butane;
        /// <summary>
        /// The chemical butane C4H10
        /// </summary>
        [EnumValueNameAttribute("butane")]
        public static FluidComponent Butane
        {
            get 
            {
                return butane;
            }
        }

        private readonly static FluidComponent cyclopentane;
        /// <summary>
        /// The chemical cyclopentane C5H10
        /// </summary>
        [EnumValueNameAttribute("cyclopentane")]
        public static FluidComponent Cyclopentane
        {
            get 
            {
                return cyclopentane;
            }
        }

        private readonly static FluidComponent twomethylbutane;
        /// <summary>
        /// The chemical 2-methylbutane C5H12
        /// </summary>
        [EnumValueNameAttribute("2-methylbutane")]
        public static FluidComponent Twomethylbutane
        {
            get 
            {
                return twomethylbutane;
            }
        }

        private readonly static FluidComponent pentane;
        /// <summary>
        /// The chemical pentane C5H12
        /// </summary>
        [EnumValueNameAttribute("pentane")]
        public static FluidComponent Pentane
        {
            get 
            {
                return pentane;
            }
        }

        private readonly static FluidComponent twoTwoDimethylpropane;
        /// <summary>
        /// The chemical 2,2 dimethylpropane C5H12
        /// </summary>
        [EnumValueNameAttribute("2,2 dimethylpropane")]
        public static FluidComponent TwoTwoDimethylpropane
        {
            get 
            {
                return twoTwoDimethylpropane;
            }
        }

        private readonly static FluidComponent benzene;
        /// <summary>
        /// The chemical benzene C6H6
        /// </summary>
        [EnumValueNameAttribute("benzene")]
        public static FluidComponent Benzene
        {
            get 
            {
                return benzene;
            }
        }

        private readonly static FluidComponent cyclohexane;
        /// <summary>
        /// The chemical cyclohexane C6H12
        /// </summary>
        [EnumValueNameAttribute("cyclohexane")]
        public static FluidComponent Cyclohexane
        {
            get 
            {
                return cyclohexane;
            }
        }

        private readonly static FluidComponent methylcyclopentane;
        /// <summary>
        /// The chemical methylcyclopentane C6H12
        /// </summary>
        [EnumValueNameAttribute("methylcyclopentane ")]
        public static FluidComponent Methylcyclopentane
        {
            get 
            {
                return methylcyclopentane;
            }
        }

        private readonly static FluidComponent hexane;
        /// <summary>
        /// The chemical hexane C6H14
        /// </summary>
        [EnumValueNameAttribute("hexane")]
        public static FluidComponent Hexane
        {
            get 
            {
                return hexane;
            }
        }

        private readonly static FluidComponent twoTwodimethylbutane;
        /// <summary>
        /// The chemical 2,2-dimethylbutane C6H14
        /// </summary>
        [EnumValueNameAttribute("2,2-dimethylbutane")]
        public static FluidComponent TwoTwodimethylbutane
        {
            get 
            {
                return twoTwodimethylbutane;
            }
        }

        private readonly static FluidComponent twoThreedimethylbutane;
        /// <summary>
        /// The chemical 2,3-dimethylbutane C6H14
        /// </summary>
        [EnumValueNameAttribute("2,3-dimethylbutane")]
        public static FluidComponent TwoThreedimethylbutane
        {
            get 
            {
                return twoThreedimethylbutane;
            }
        }

        private readonly static FluidComponent twomethylpentane;
        /// <summary>
        /// The chemical 2-methylpentane C6H14
        /// </summary>
        [EnumValueNameAttribute("2-methylpentane")]
        public static FluidComponent Twomethylpentane
        {
            get 
            {
                return twomethylpentane;
            }
        }

        private readonly static FluidComponent threemethylpentane;
        /// <summary>
        /// The chemical 3-methylpentane C6H14
        /// </summary>
        [EnumValueNameAttribute("3-methylpentane")]
        public static FluidComponent Threemethylpentane
        {
            get 
            {
                return threemethylpentane;
            }
        }

        private readonly static FluidComponent methylbenzene;
        /// <summary>
        /// The chemical methylbenzene C7H8
        /// </summary>
        [EnumValueNameAttribute("methylbenzene")]
        public static FluidComponent Methylbenzene
        {
            get 
            {
                return methylbenzene;
            }
        }

        private readonly static FluidComponent methylcyclohexane;
        /// <summary>
        /// The chemical methylcyclohexane C7H14
        /// </summary>
        [EnumValueNameAttribute("methylcyclohexane")]
        public static FluidComponent Methylcyclohexane
        {
            get 
            {
                return methylcyclohexane;
            }
        }

        private readonly static FluidComponent oneOnedimethylcyclopentane;
        /// <summary>
        /// The chemical 1,1-dimethylcyclopentane C7H14
        /// </summary>
        [EnumValueNameAttribute("1,1-dimethylcyclopentane")]
        public static FluidComponent OneOnedimethylcyclopentane
        {
            get 
            {
                return oneOnedimethylcyclopentane;
            }
        }

        private readonly static FluidComponent cisOneThreedimethylcyclopentane;
        /// <summary>
        /// The chemical cis-1,3-dimethylcyclopentane C7H14
        /// </summary>
        [EnumValueNameAttribute("cis-1,3-dimethylcyclopentane")]
        public static FluidComponent CisOneThreedimethylcyclopentane
        {
            get 
            {
                return cisOneThreedimethylcyclopentane;
            }
        }

        private readonly static FluidComponent transOneTwodimethylcyclopentane;
        /// <summary>
        /// The chemical trans-1,2-dimethylcyclopentane C7H14
        /// </summary>
        [EnumValueNameAttribute("trans-1,2-dimethylcyclopentane")]
        public static FluidComponent TransOneTwodimethylcyclopentane
        {
            get 
            {
                return transOneTwodimethylcyclopentane;
            }
        }

        private readonly static FluidComponent transOneThreedimethylcyclopentane;
        /// <summary>
        /// The chemical trans-1,3-dimethylcyclopentane C7H14
        /// </summary>
        [EnumValueNameAttribute("trans-1,3-dimethylcyclopentane")]
        public static FluidComponent TransOneThreedimethylcyclopentane
        {
            get 
            {
                return transOneThreedimethylcyclopentane;
            }
        }

        private readonly static FluidComponent ethylcyclopentane;
        /// <summary>
        /// The chemical ethylcyclopentane C7H14
        /// </summary>
        [EnumValueNameAttribute("ethylcyclopentane")]
        public static FluidComponent Ethylcyclopentane
        {
            get 
            {
                return ethylcyclopentane;
            }
        }

        private readonly static FluidComponent twoTwodimethylpentane;
        /// <summary>
        /// The chemical 2,2-dimethylpentane C7H16
        /// </summary>
        [EnumValueNameAttribute("2,2-dimethylpentane")]
        public static FluidComponent TwoTwodimethylpentane
        {
            get 
            {
                return twoTwodimethylpentane;
            }
        }

        private readonly static FluidComponent twoTwoThreetrimethylbutane;
        /// <summary>
        /// The chemical 2,2,3-trimethylbutane C7H16
        /// </summary>
        [EnumValueNameAttribute("2,2,3-trimethylbutane")]
        public static FluidComponent TwoTwoThreetrimethylbutane
        {
            get 
            {
                return twoTwoThreetrimethylbutane;
            }
        }

        private readonly static FluidComponent twoFourdimethylpentane;
        /// <summary>
        /// The chemical 2,4-Dimethylpentane C7H16
        /// </summary>
        [EnumValueNameAttribute("2,4-Dimethylpentane")]
        public static FluidComponent TwoFourdimethylpentane
        {
            get 
            {
                return twoFourdimethylpentane;
            }
        }

        private readonly static FluidComponent twomethylhexane;
        /// <summary>
        /// The chemical 2-methylhexane C7H16
        /// </summary>
        [EnumValueNameAttribute("2-methylhexane")]
        public static FluidComponent Twomethylhexane
        {
            get 
            {
                return twomethylhexane;
            }
        }

        private readonly static FluidComponent threeThreedimethylpentane;
        /// <summary>
        /// The chemical 3,3-dimethylpentane C7H16
        /// </summary>
        [EnumValueNameAttribute("3,3-dimethylpentane")]
        public static FluidComponent ThreeThreedimethylpentane
        {
            get 
            {
                return threeThreedimethylpentane;
            }
        }

        private readonly static FluidComponent twoThreedimethylpentane;
        /// <summary>
        /// The chemical 2,3-dimethylpentane C7H16
        /// </summary>
        [EnumValueNameAttribute("2,3-dimethylpentane")]
        public static FluidComponent TwoThreedimethylpentane
        {
            get 
            {
                return twoThreedimethylpentane;
            }
        }

        private readonly static FluidComponent threeethylpentane;
        /// <summary>
        /// The chemical 3-ethylpentane C7H16
        /// </summary>
        [EnumValueNameAttribute("3-ethylpentane")]
        public static FluidComponent Threeethylpentane
        {
            get 
            {
                return threeethylpentane;
            }
        }

        private readonly static FluidComponent threemethylhexane;
        /// <summary>
        /// The chemical 3-methylhexane C7H16
        /// </summary>
        [EnumValueNameAttribute("3-methylhexane")]
        public static FluidComponent Threemethylhexane
        {
            get 
            {
                return threemethylhexane;
            }
        }

        private readonly static FluidComponent oneTwoDimethylbenzene;
        /// <summary>
        /// The chemical 1,2 dimethylbenzene C8H10
        /// </summary>
        [EnumValueNameAttribute("1,2 dimethylbenzene")]
        public static FluidComponent OneTwoDimethylbenzene
        {
            get 
            {
                return oneTwoDimethylbenzene;
            }
        }

        private readonly static FluidComponent oneThreeDimethylbenzene;
        /// <summary>
        /// The chemical 1,3 dimethylbenzene C8H10
        /// </summary>
        [EnumValueNameAttribute("1,3 dimethylbenzene")]
        public static FluidComponent OneThreeDimethylbenzene
        {
            get 
            {
                return oneThreeDimethylbenzene;
            }
        }

        private readonly static FluidComponent oneFourdimethylbenzene;
        /// <summary>
        /// The chemical 1,4 dimethylbenzene C8H10
        /// </summary>
        [EnumValueNameAttribute("1,4-dimethylbenzene")]
        public static FluidComponent OneFourdimethylbenzene
        {
            get 
            {
                return oneFourdimethylbenzene;
            }
        }

        private readonly static FluidComponent ethylbenzene;
        /// <summary>
        /// The chemical ethylbenzene C8H10
        /// </summary>
        [EnumValueNameAttribute("ethylbenzene")]
        public static FluidComponent Ethylbenzene
        {
            get 
            {
                return ethylbenzene;
            }
        }

        private readonly static FluidComponent twoThreeThreetrimethylpentane;
        /// <summary>
        /// The chemical 2,3,3-trimethylpentane C8H18
        /// </summary>
        [EnumValueNameAttribute("2,3,3-trimethylpentane")]
        public static FluidComponent TwoThreeThreetrimethylpentane
        {
            get 
            {
                return twoThreeThreetrimethylpentane;
            }
        }

        private readonly static FluidComponent twoTwodimethylhexane;
        /// <summary>
        /// The chemical 2,2-dimethylhexane C8H18
        /// </summary>
        [EnumValueNameAttribute("2,2-dimethylhexane")]
        public static FluidComponent TwoTwodimethylhexane
        {
            get 
            {
                return twoTwodimethylhexane;
            }
        }

        private readonly static FluidComponent twoFourdimethylhexane;
        /// <summary>
        /// The chemical 2,4-dimethylhexane C8H18
        /// </summary>
        [EnumValueNameAttribute("2,4-dimethylhexane")]
        public static FluidComponent TwoFourdimethylhexane
        {
            get 
            {
                return twoFourdimethylhexane;
            }
        }

        private readonly static FluidComponent twoFivedimethylhexane;
        /// <summary>
        /// The chemical 2,5-dimethylhexane C8H18
        /// </summary>
        [EnumValueNameAttribute("2,5-dimethylhexane")]
        public static FluidComponent TwoFivedimethylhexane
        {
            get 
            {
                return twoFivedimethylhexane;
            }
        }

        private readonly static FluidComponent oneTwoFourtrimethylbenzene;
        /// <summary>
        /// The chemical 1,2,4-trimethylbenzene C9H12
        /// </summary>
        [EnumValueNameAttribute("1,2,4-trimethylbenzene")]
        public static FluidComponent OneTwoFourtrimethylbenzene
        {
            get 
            {
                return oneTwoFourtrimethylbenzene;
            }
        }

        private readonly static FluidComponent hexanes;
        /// <summary>
        /// The group of chemicals comprising n-hexane and its isomers, all C6H14
        /// </summary>
        [EnumValueNameAttribute("hexanes")]
        public static FluidComponent Hexanes
        {
            get 
            {
                return hexanes;
            }
        }

        private readonly static FluidComponent heptanes;
        /// <summary>
        /// The group of chemicals comprising n-heptane and its isomers, all C7H16
        /// </summary>
        [EnumValueNameAttribute("heptanes")]
        public static FluidComponent Heptanes
        {
            get 
            {
                return heptanes;
            }
        }

        private readonly static FluidComponent octanes;
        /// <summary>
        /// The group of chemicals comprising n-octane and its isomers, all C8H18
        /// </summary>
        [EnumValueNameAttribute("octanes")]
        public static FluidComponent Octanes
        {
            get 
            {
                return octanes;
            }
        }

        private readonly static FluidComponent nonanes;
        /// <summary>
        /// The group of chemicals comprising n-nonane and its isomers, all C9H20
        /// </summary>
        [EnumValueNameAttribute("nonanes")]
        public static FluidComponent Nonanes
        {
            get 
            {
                return nonanes;
            }
        }

        private readonly static FluidComponent decanes;
        /// <summary>
        /// The group of chemicals comprising n-decane and its isomers, all C10H22
        /// </summary>
        [EnumValueNameAttribute("decanes")]
        public static FluidComponent Decanes
        {
            get 
            {
                return decanes;
            }
        }

        private readonly static FluidComponent cOneOneFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C11
        /// </summary>
        [EnumValueNameAttribute("C11 fraction")]
        public static FluidComponent COneOneFraction
        {
            get 
            {
                return cOneOneFraction;
            }
        }

        private readonly static FluidComponent cOneTwoFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C12
        /// </summary>
        [EnumValueNameAttribute("C12 fraction")]
        public static FluidComponent COneTwoFraction
        {
            get 
            {
                return cOneTwoFraction;
            }
        }

        private readonly static FluidComponent cOneThreeFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C13
        /// </summary>
        [EnumValueNameAttribute("C13 fraction")]
        public static FluidComponent COneThreeFraction
        {
            get 
            {
                return cOneThreeFraction;
            }
        }

        private readonly static FluidComponent cOneFourFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C14
        /// </summary>
        [EnumValueNameAttribute("C14 fraction")]
        public static FluidComponent COneFourFraction
        {
            get 
            {
                return cOneFourFraction;
            }
        }

        private readonly static FluidComponent cOneFiveFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C15
        /// </summary>
        [EnumValueNameAttribute("C15 fraction")]
        public static FluidComponent COneFiveFraction
        {
            get 
            {
                return cOneFiveFraction;
            }
        }

        private readonly static FluidComponent cOneSixFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C16
        /// </summary>
        [EnumValueNameAttribute("C16 fraction")]
        public static FluidComponent COneSixFraction
        {
            get 
            {
                return cOneSixFraction;
            }
        }

        private readonly static FluidComponent cOneSevenFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C17
        /// </summary>
        [EnumValueNameAttribute("C17 fraction")]
        public static FluidComponent COneSevenFraction
        {
            get 
            {
                return cOneSevenFraction;
            }
        }

        private readonly static FluidComponent cOneEightFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C18
        /// </summary>
        [EnumValueNameAttribute("C18 fraction")]
        public static FluidComponent COneEightFraction
        {
            get 
            {
                return cOneEightFraction;
            }
        }

        private readonly static FluidComponent cOneNineFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C19
        /// </summary>
        [EnumValueNameAttribute("C19 fraction")]
        public static FluidComponent COneNineFraction
        {
            get 
            {
                return cOneNineFraction;
            }
        }

        private readonly static FluidComponent cTwoZeroFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C20
        /// </summary>
        [EnumValueNameAttribute("C20 fraction")]
        public static FluidComponent CTwoZeroFraction
        {
            get 
            {
                return cTwoZeroFraction;
            }
        }

        private readonly static FluidComponent cTwoOneFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C21
        /// </summary>
        [EnumValueNameAttribute("C21 fraction")]
        public static FluidComponent CTwoOneFraction
        {
            get 
            {
                return cTwoOneFraction;
            }
        }

        private readonly static FluidComponent cTwoTwoFraction;
        /// <summary>
        ///  The group of hydrocarbons characterized by being the single carbon number fraction C22
        /// </summary>
        [EnumValueNameAttribute("C22 fraction")]
        public static FluidComponent CTwoTwoFraction
        {
            get 
            {
                return cTwoTwoFraction;
            }
        }

        private readonly static FluidComponent cTwoThreeFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C23
        /// </summary>
        [EnumValueNameAttribute("C23 fraction")]
        public static FluidComponent CTwoThreeFraction
        {
            get 
            {
                return cTwoThreeFraction;
            }
        }

        private readonly static FluidComponent cTwoFourFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C24
        /// </summary>
        [EnumValueNameAttribute("C24 fraction")]
        public static FluidComponent CTwoFourFraction
        {
            get 
            {
                return cTwoFourFraction;
            }
        }

        private readonly static FluidComponent cTwoFiveFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C25
        /// </summary>
        [EnumValueNameAttribute("C25 fraction")]
        public static FluidComponent CTwoFiveFraction
        {
            get 
            {
                return cTwoFiveFraction;
            }
        }

        private readonly static FluidComponent cTwoSixFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C26
        /// </summary>
        [EnumValueNameAttribute("C26 fraction")]
        public static FluidComponent CTwoSixFraction
        {
            get 
            {
                return cTwoSixFraction;
            }
        }

        private readonly static FluidComponent cTwoSevenFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C27
        /// </summary>
        [EnumValueNameAttribute("C27 fraction")]
        public static FluidComponent CTwoSevenFraction
        {
            get 
            {
                return cTwoSevenFraction;
            }
        }

        private readonly static FluidComponent cTwoEightFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C28
        /// </summary>
        [EnumValueNameAttribute("C28 fraction")]
        public static FluidComponent CTwoEightFraction
        {
            get 
            {
                return cTwoEightFraction;
            }
        }

        private readonly static FluidComponent cTwoNineFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C29
        /// </summary>
        [EnumValueNameAttribute("C29 fraction")]
        public static FluidComponent CTwoNineFraction
        {
            get 
            {
                return cTwoNineFraction;
            }
        }

        private readonly static FluidComponent cThreeZeroFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction 30C
        /// </summary>
        [EnumValueNameAttribute("C30 fraction")]
        public static FluidComponent CThreeZeroFraction
        {
            get 
            {
                return cThreeZeroFraction;
            }
        }

        private readonly static FluidComponent cThreeOneFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction 31C
        /// </summary>
        [EnumValueNameAttribute("C31 fraction")]
        public static FluidComponent CThreeOneFraction
        {
            get 
            {
                return cThreeOneFraction;
            }
        }

        private readonly static FluidComponent cThreeTwoFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C32
        /// </summary>
        [EnumValueNameAttribute("C32 fraction")]
        public static FluidComponent CThreeTwoFraction
        {
            get 
            {
                return cThreeTwoFraction;
            }
        }

        private readonly static FluidComponent cThreeThreeFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C33
        /// </summary>
        [EnumValueNameAttribute("C33 fraction")]
        public static FluidComponent CThreeThreeFraction
        {
            get 
            {
                return cThreeThreeFraction;
            }
        }

        private readonly static FluidComponent cThreeFourFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C34
        /// </summary>
        [EnumValueNameAttribute("C34 fraction")]
        public static FluidComponent CThreeFourFraction
        {
            get 
            {
                return cThreeFourFraction;
            }
        }

        private readonly static FluidComponent cThreeFiveFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C35
        /// </summary>
        [EnumValueNameAttribute("C35 fraction")]
        public static FluidComponent CThreeFiveFraction
        {
            get 
            {
                return cThreeFiveFraction;
            }
        }

        private readonly static FluidComponent cThreeSixFraction;
        /// <summary>
        ///  The group of hydrocarbons characterized by being the single carbon number fraction C36
        /// </summary>
        [EnumValueNameAttribute("C36 fraction")]
        public static FluidComponent CThreeSixFraction
        {
            get 
            {
                return cThreeSixFraction;
            }
        }

        private readonly static FluidComponent cThreeSevenFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C37
        /// </summary>
        [EnumValueNameAttribute("C37 fraction")]
        public static FluidComponent CThreeSevenFraction
        {
            get 
            {
                return cThreeSevenFraction;
            }
        }

        private readonly static FluidComponent cThreeEightFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction 38C
        /// </summary>
        [EnumValueNameAttribute("C38 fraction")]
        public static FluidComponent CThreeEightFraction
        {
            get 
            {
                return cThreeEightFraction;
            }
        }

        private readonly static FluidComponent cThreeNineFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C39
        /// </summary>
        [EnumValueNameAttribute("C39 fraction")]
        public static FluidComponent CThreeNineFraction
        {
            get 
            {
                return cThreeNineFraction;
            }
        }

        private readonly static FluidComponent cFourZeroFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C40
        /// </summary>
        [EnumValueNameAttribute("C40 fraction")]
        public static FluidComponent CFourZeroFraction
        {
            get 
            {
                return cFourZeroFraction;
            }
        }

        private readonly static FluidComponent cFourOneFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C41
        /// </summary>
        [EnumValueNameAttribute("C41 fraction")]
        public static FluidComponent CFourOneFraction
        {
            get 
            {
                return cFourOneFraction;
            }
        }

        private readonly static FluidComponent cFourTwoFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C42
        /// </summary>
        [EnumValueNameAttribute("C42 fraction")]
        public static FluidComponent CFourTwoFraction
        {
            get 
            {
                return cFourTwoFraction;
            }
        }

        private readonly static FluidComponent cFourThreeFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C43
        /// </summary>
        [EnumValueNameAttribute("C43 fraction")]
        public static FluidComponent CFourThreeFraction
        {
            get 
            {
                return cFourThreeFraction;
            }
        }

        private readonly static FluidComponent cFourFourFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C44
        /// </summary>
        [EnumValueNameAttribute("C44 fraction")]
        public static FluidComponent CFourFourFraction
        {
            get 
            {
                return cFourFourFraction;
            }
        }

        private readonly static FluidComponent cFourFiveFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C45
        /// </summary>
        [EnumValueNameAttribute("C45 fraction")]
        public static FluidComponent CFourFiveFraction
        {
            get 
            {
                return cFourFiveFraction;
            }
        }

        private readonly static FluidComponent cFourSixFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction 46C
        /// </summary>
        [EnumValueNameAttribute("C46 fraction")]
        public static FluidComponent CFourSixFraction
        {
            get 
            {
                return cFourSixFraction;
            }
        }

        private readonly static FluidComponent cFourSevenFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C47
        /// </summary>
        [EnumValueNameAttribute("C47 fraction")]
        public static FluidComponent CFourSevenFraction
        {
            get 
            {
                return cFourSevenFraction;
            }
        }

        private readonly static FluidComponent cFourEightFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C48
        /// </summary>
        [EnumValueNameAttribute("C48 fraction")]
        public static FluidComponent CFourEightFraction
        {
            get 
            {
                return cFourEightFraction;
            }
        }

        private readonly static FluidComponent cFourNineFraction;
        /// <summary>
        /// The group of hydrocarbons characterized by being the single carbon number fraction C49
        /// </summary>
        [EnumValueNameAttribute("C49 fraction")]
        public static FluidComponent CFourNineFraction
        {
            get 
            {
                return cFourNineFraction;
            }
        }

        private readonly static FluidComponent unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidComponent Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FluidComponent()
        {
            hydrogen = 
                new FluidComponent("hydrogen")
                {
                    Description = "The chemical hydrogen H2"
            };
            water = 
                new FluidComponent("water")
                {
                    Description = "The chemical water H2O"
            };
            nitrogen = 
                new FluidComponent("nitrogen")
                {
                    Description = "The chemical nitrogen N2"
            };
            oxygen = 
                new FluidComponent("oxygen")
                {
                    Description = "The chemical oxygen O2"
            };
            hydrogenSulfide = 
                new FluidComponent("hydrogen sulfide")
                {
                    Description = "The chemical hydrogen sulfide H2S"
            };
            argon = 
                new FluidComponent("argon")
                {
                    Description = "The chemical argon Ar"
            };
            carbonDioxide = 
                new FluidComponent("carbon dioxide")
                {
                    Description = "The chemical carbon dioxide CO2"
            };
            methane = 
                new FluidComponent("methane")
                {
                    Description = "The chemical methane CH4"
            };
            ethane = 
                new FluidComponent("ethane")
                {
                    Description = "The chemical ethane C2H6"
            };
            propane = 
                new FluidComponent("propane")
                {
                    Description = "The chemical propane C3H8"
            };
            twomethylpropane = 
                new FluidComponent("2-methylpropane")
                {
                    Description = "The chemical 2-methylpropane C4H10"
            };
            butane = 
                new FluidComponent("butane")
                {
                    Description = "The chemical butane C4H10"
            };
            cyclopentane = 
                new FluidComponent("cyclopentane")
                {
                    Description = "The chemical cyclopentane C5H10"
            };
            twomethylbutane = 
                new FluidComponent("2-methylbutane")
                {
                    Description = "The chemical 2-methylbutane C5H12"
            };
            pentane = 
                new FluidComponent("pentane")
                {
                    Description = "The chemical pentane C5H12"
            };
            twoTwoDimethylpropane = 
                new FluidComponent("2,2 dimethylpropane")
                {
                    Description = "The chemical 2,2 dimethylpropane C5H12"
            };
            benzene = 
                new FluidComponent("benzene")
                {
                    Description = "The chemical benzene C6H6"
            };
            cyclohexane = 
                new FluidComponent("cyclohexane")
                {
                    Description = "The chemical cyclohexane C6H12"
            };
            methylcyclopentane = 
                new FluidComponent("methylcyclopentane ")
                {
                    Description = "The chemical methylcyclopentane C6H12"
            };
            hexane = 
                new FluidComponent("hexane")
                {
                    Description = "The chemical hexane C6H14"
            };
            twoTwodimethylbutane = 
                new FluidComponent("2,2-dimethylbutane")
                {
                    Description = "The chemical 2,2-dimethylbutane C6H14"
            };
            twoThreedimethylbutane = 
                new FluidComponent("2,3-dimethylbutane")
                {
                    Description = "The chemical 2,3-dimethylbutane C6H14"
            };
            twomethylpentane = 
                new FluidComponent("2-methylpentane")
                {
                    Description = "The chemical 2-methylpentane C6H14"
            };
            threemethylpentane = 
                new FluidComponent("3-methylpentane")
                {
                    Description = "The chemical 3-methylpentane C6H14"
            };
            methylbenzene = 
                new FluidComponent("methylbenzene")
                {
                    Description = "The chemical methylbenzene C7H8"
            };
            methylcyclohexane = 
                new FluidComponent("methylcyclohexane")
                {
                    Description = "The chemical methylcyclohexane C7H14"
            };
            oneOnedimethylcyclopentane = 
                new FluidComponent("1,1-dimethylcyclopentane")
                {
                    Description = "The chemical 1,1-dimethylcyclopentane C7H14"
            };
            cisOneThreedimethylcyclopentane = 
                new FluidComponent("cis-1,3-dimethylcyclopentane")
                {
                    Description = "The chemical cis-1,3-dimethylcyclopentane C7H14"
            };
            transOneTwodimethylcyclopentane = 
                new FluidComponent("trans-1,2-dimethylcyclopentane")
                {
                    Description = "The chemical trans-1,2-dimethylcyclopentane C7H14"
            };
            transOneThreedimethylcyclopentane = 
                new FluidComponent("trans-1,3-dimethylcyclopentane")
                {
                    Description = "The chemical trans-1,3-dimethylcyclopentane C7H14"
            };
            ethylcyclopentane = 
                new FluidComponent("ethylcyclopentane")
                {
                    Description = "The chemical ethylcyclopentane C7H14"
            };
            twoTwodimethylpentane = 
                new FluidComponent("2,2-dimethylpentane")
                {
                    Description = "The chemical 2,2-dimethylpentane C7H16"
            };
            twoTwoThreetrimethylbutane = 
                new FluidComponent("2,2,3-trimethylbutane")
                {
                    Description = "The chemical 2,2,3-trimethylbutane C7H16"
            };
            twoFourdimethylpentane = 
                new FluidComponent("2,4-Dimethylpentane")
                {
                    Description = "The chemical 2,4-Dimethylpentane C7H16"
            };
            twomethylhexane = 
                new FluidComponent("2-methylhexane")
                {
                    Description = "The chemical 2-methylhexane C7H16"
            };
            threeThreedimethylpentane = 
                new FluidComponent("3,3-dimethylpentane")
                {
                    Description = "The chemical 3,3-dimethylpentane C7H16"
            };
            twoThreedimethylpentane = 
                new FluidComponent("2,3-dimethylpentane")
                {
                    Description = "The chemical 2,3-dimethylpentane C7H16"
            };
            threeethylpentane = 
                new FluidComponent("3-ethylpentane")
                {
                    Description = "The chemical 3-ethylpentane C7H16"
            };
            threemethylhexane = 
                new FluidComponent("3-methylhexane")
                {
                    Description = "The chemical 3-methylhexane C7H16"
            };
            oneTwoDimethylbenzene = 
                new FluidComponent("1,2 dimethylbenzene")
                {
                    Description = "The chemical 1,2 dimethylbenzene C8H10"
            };
            oneThreeDimethylbenzene = 
                new FluidComponent("1,3 dimethylbenzene")
                {
                    Description = "The chemical 1,3 dimethylbenzene C8H10"
            };
            oneFourdimethylbenzene = 
                new FluidComponent("1,4-dimethylbenzene")
                {
                    Description = "The chemical 1,4 dimethylbenzene C8H10"
            };
            ethylbenzene = 
                new FluidComponent("ethylbenzene")
                {
                    Description = "The chemical ethylbenzene C8H10"
            };
            twoThreeThreetrimethylpentane = 
                new FluidComponent("2,3,3-trimethylpentane")
                {
                    Description = "The chemical 2,3,3-trimethylpentane C8H18"
            };
            twoTwodimethylhexane = 
                new FluidComponent("2,2-dimethylhexane")
                {
                    Description = "The chemical 2,2-dimethylhexane C8H18"
            };
            twoFourdimethylhexane = 
                new FluidComponent("2,4-dimethylhexane")
                {
                    Description = "The chemical 2,4-dimethylhexane C8H18"
            };
            twoFivedimethylhexane = 
                new FluidComponent("2,5-dimethylhexane")
                {
                    Description = "The chemical 2,5-dimethylhexane C8H18"
            };
            oneTwoFourtrimethylbenzene = 
                new FluidComponent("1,2,4-trimethylbenzene")
                {
                    Description = "The chemical 1,2,4-trimethylbenzene C9H12"
            };
            hexanes = 
                new FluidComponent("hexanes")
                {
                    Description = "The group of chemicals comprising n-hexane and its isomers, all C6H14"
            };
            heptanes = 
                new FluidComponent("heptanes")
                {
                    Description = "The group of chemicals comprising n-heptane and its isomers, all C7H16"
            };
            octanes = 
                new FluidComponent("octanes")
                {
                    Description = "The group of chemicals comprising n-octane and its isomers, all C8H18"
            };
            nonanes = 
                new FluidComponent("nonanes")
                {
                    Description = "The group of chemicals comprising n-nonane and its isomers, all C9H20"
            };
            decanes = 
                new FluidComponent("decanes")
                {
                    Description = "The group of chemicals comprising n-decane and its isomers, all C10H22"
            };
            cOneOneFraction = 
                new FluidComponent("C11 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C11"
            };
            cOneTwoFraction = 
                new FluidComponent("C12 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C12"
            };
            cOneThreeFraction = 
                new FluidComponent("C13 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C13"
            };
            cOneFourFraction = 
                new FluidComponent("C14 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C14"
            };
            cOneFiveFraction = 
                new FluidComponent("C15 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C15"
            };
            cOneSixFraction = 
                new FluidComponent("C16 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C16"
            };
            cOneSevenFraction = 
                new FluidComponent("C17 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C17"
            };
            cOneEightFraction = 
                new FluidComponent("C18 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C18"
            };
            cOneNineFraction = 
                new FluidComponent("C19 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C19"
            };
            cTwoZeroFraction = 
                new FluidComponent("C20 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C20"
            };
            cTwoOneFraction = 
                new FluidComponent("C21 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C21"
            };
            cTwoTwoFraction = 
                new FluidComponent("C22 fraction")
                {
                    Description = " The group of hydrocarbons characterized by being the single carbon number fraction C22"
            };
            cTwoThreeFraction = 
                new FluidComponent("C23 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C23"
            };
            cTwoFourFraction = 
                new FluidComponent("C24 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C24"
            };
            cTwoFiveFraction = 
                new FluidComponent("C25 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C25"
            };
            cTwoSixFraction = 
                new FluidComponent("C26 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C26"
            };
            cTwoSevenFraction = 
                new FluidComponent("C27 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C27"
            };
            cTwoEightFraction = 
                new FluidComponent("C28 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C28"
            };
            cTwoNineFraction = 
                new FluidComponent("C29 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C29"
            };
            cThreeZeroFraction = 
                new FluidComponent("C30 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction 30C"
            };
            cThreeOneFraction = 
                new FluidComponent("C31 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction 31C"
            };
            cThreeTwoFraction = 
                new FluidComponent("C32 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C32"
            };
            cThreeThreeFraction = 
                new FluidComponent("C33 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C33"
            };
            cThreeFourFraction = 
                new FluidComponent("C34 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C34"
            };
            cThreeFiveFraction = 
                new FluidComponent("C35 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C35"
            };
            cThreeSixFraction = 
                new FluidComponent("C36 fraction")
                {
                    Description = " The group of hydrocarbons characterized by being the single carbon number fraction C36"
            };
            cThreeSevenFraction = 
                new FluidComponent("C37 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C37"
            };
            cThreeEightFraction = 
                new FluidComponent("C38 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction 38C"
            };
            cThreeNineFraction = 
                new FluidComponent("C39 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C39"
            };
            cFourZeroFraction = 
                new FluidComponent("C40 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C40"
            };
            cFourOneFraction = 
                new FluidComponent("C41 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C41"
            };
            cFourTwoFraction = 
                new FluidComponent("C42 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C42"
            };
            cFourThreeFraction = 
                new FluidComponent("C43 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C43"
            };
            cFourFourFraction = 
                new FluidComponent("C44 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C44"
            };
            cFourFiveFraction = 
                new FluidComponent("C45 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C45"
            };
            cFourSixFraction = 
                new FluidComponent("C46 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction 46C"
            };
            cFourSevenFraction = 
                new FluidComponent("C47 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C47"
            };
            cFourEightFraction = 
                new FluidComponent("C48 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C48"
            };
            cFourNineFraction = 
                new FluidComponent("C49 fraction")
                {
                    Description = "The group of hydrocarbons characterized by being the single carbon number fraction C49"
            };
            unknown = 
                new FluidComponent("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FluidComponent by name
        /// </summary>
        /// <param name="name">The name of the FluidComponent to return</param>
        /// <returns>The FluidComponent represented by 'name'</returns>
        public static FluidComponent GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FluidComponent)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FluidComponent)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FluidComponent)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines, for a Fluid Component in a mixture such as an oil or gas, that the component is of a given kind
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

        private readonly static FluidComponentKind pure;
        /// <summary>
        /// The component is a pure substance, i.e. comprised of one kind of molecules
        /// </summary>
        [EnumValueNameAttribute("pure")]
        public static FluidComponentKind Pure
        {
            get 
            {
                return pure;
            }
        }

        private readonly static FluidComponentKind frac;
        /// <summary>
        /// The component is a fraction, i.e. comprised of a mixture of molecules characterized by having closely similar boiling points
        /// </summary>
        [EnumValueNameAttribute("frac")]
        public static FluidComponentKind Frac
        {
            get 
            {
                return frac;
            }
        }

        private readonly static FluidComponentKind plus;
        /// <summary>
        ///  The component is a plus-fraction, i.e. comprised of a mixture of molecules lumped together and characterized by having higher molecular weights and boiling points than the carbon number of the plus fraction 
        /// </summary>
        [EnumValueNameAttribute("plus")]
        public static FluidComponentKind Plus
        {
            get 
            {
                return plus;
            }
        }

        private readonly static FluidComponentKind split;
        /// <summary>
        ///  The component is a pseudo component, i.e. comprised of a mixture of molecules lumped together and characterized by an average molecular weight, boiling point and other properties 
        /// </summary>
        [EnumValueNameAttribute("split")]
        public static FluidComponentKind Split
        {
            get 
            {
                return split;
            }
        }

        private readonly static FluidComponentKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidComponentKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FluidComponentKind()
        {
            pure = 
                new FluidComponentKind("pure")
                {
                    Description = "The component is a pure substance, i.e. comprised of one kind of molecules"
            };
            frac = 
                new FluidComponentKind("frac")
                {
                    Description = "The component is a fraction, i.e. comprised of a mixture of molecules characterized by having closely similar boiling points"
            };
            plus = 
                new FluidComponentKind("plus")
                {
                    Description = " The component is a plus-fraction, i.e. comprised of a mixture of molecules lumped together and characterized by having higher molecular weights and boiling points than the carbon number of the plus fraction "
            };
            split = 
                new FluidComponentKind("split")
                {
                    Description = " The component is a pseudo component, i.e. comprised of a mixture of molecules lumped together and characterized by an average molecular weight, boiling point and other properties "
            };
            unknown = 
                new FluidComponentKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FluidComponentKind by name
        /// </summary>
        /// <param name="name">The name of the FluidComponentKind to return</param>
        /// <returns>The FluidComponentKind represented by 'name'</returns>
        public static FluidComponentKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FluidComponentKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FluidComponentKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FluidComponentKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines the kind of contaminating fluid present in a fluid sample
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

        private readonly static FluidContaminant drillingMud;
        /// <summary>
        /// The contaminating fluid is drilling mud
        /// </summary>
        [EnumValueNameAttribute("drilling mud")]
        public static FluidContaminant DrillingMud
        {
            get 
            {
                return drillingMud;
            }
        }

        private readonly static FluidContaminant completionFluid;
        /// <summary>
        /// The contaminating fluid is completion fluid
        /// </summary>
        [EnumValueNameAttribute("completion fluid")]
        public static FluidContaminant CompletionFluid
        {
            get 
            {
                return completionFluid;
            }
        }

        private readonly static FluidContaminant extraneousOil;
        /// <summary>
        /// The contaminating fluid is extraneous oil
        /// </summary>
        [EnumValueNameAttribute("extraneous oil")]
        public static FluidContaminant ExtraneousOil
        {
            get 
            {
                return extraneousOil;
            }
        }

        private readonly static FluidContaminant extraneousGas;
        /// <summary>
        /// The contaminating fluid is extraneous gas
        /// </summary>
        [EnumValueNameAttribute("extraneous gas")]
        public static FluidContaminant ExtraneousGas
        {
            get 
            {
                return extraneousGas;
            }
        }

        private readonly static FluidContaminant extraneousWater;
        /// <summary>
        /// The contaminating fluid is extraneous water
        /// </summary>
        [EnumValueNameAttribute("extraneous water")]
        public static FluidContaminant ExtraneousWater
        {
            get 
            {
                return extraneousWater;
            }
        }

        private readonly static FluidContaminant formationWater;
        /// <summary>
        /// The contaminating fluid is formation water
        /// </summary>
        [EnumValueNameAttribute("formation water")]
        public static FluidContaminant FormationWater
        {
            get 
            {
                return formationWater;
            }
        }

        private readonly static FluidContaminant cementFluids;
        /// <summary>
        /// The contaminating fluid is cement fluids
        /// </summary>
        [EnumValueNameAttribute("cement fluids")]
        public static FluidContaminant CementFluids
        {
            get 
            {
                return cementFluids;
            }
        }

        private readonly static FluidContaminant treatmentChemicals;
        /// <summary>
        /// The contaminating fluid is treatment chemicals
        /// </summary>
        [EnumValueNameAttribute("treatment chemicals")]
        public static FluidContaminant TreatmentChemicals
        {
            get 
            {
                return treatmentChemicals;
            }
        }

        private readonly static FluidContaminant unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidContaminant Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FluidContaminant()
        {
            drillingMud = 
                new FluidContaminant("drilling mud")
                {
                    Description = "The contaminating fluid is drilling mud"
            };
            completionFluid = 
                new FluidContaminant("completion fluid")
                {
                    Description = "The contaminating fluid is completion fluid"
            };
            extraneousOil = 
                new FluidContaminant("extraneous oil")
                {
                    Description = "The contaminating fluid is extraneous oil"
            };
            extraneousGas = 
                new FluidContaminant("extraneous gas")
                {
                    Description = "The contaminating fluid is extraneous gas"
            };
            extraneousWater = 
                new FluidContaminant("extraneous water")
                {
                    Description = "The contaminating fluid is extraneous water"
            };
            formationWater = 
                new FluidContaminant("formation water")
                {
                    Description = "The contaminating fluid is formation water"
            };
            cementFluids = 
                new FluidContaminant("cement fluids")
                {
                    Description = "The contaminating fluid is cement fluids"
            };
            treatmentChemicals = 
                new FluidContaminant("treatment chemicals")
                {
                    Description = "The contaminating fluid is treatment chemicals"
            };
            unknown = 
                new FluidContaminant("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FluidContaminant by name
        /// </summary>
        /// <param name="name">The name of the FluidContaminant to return</param>
        /// <returns>The FluidContaminant represented by 'name'</returns>
        public static FluidContaminant GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FluidContaminant)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FluidContaminant)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FluidContaminant)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines the kind of fluid sample by reference to how it was obtained
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

        private readonly static FluidSampleKind bottomHole;
        /// <summary>
        /// The sample was obtained downhole in the wellbore
        /// </summary>
        [EnumValueNameAttribute("bottom hole")]
        public static FluidSampleKind BottomHole
        {
            get 
            {
                return bottomHole;
            }
        }

        private readonly static FluidSampleKind wellhead;
        /// <summary>
        /// The sample was obtained from the production stream at the wellhead
        /// </summary>
        [EnumValueNameAttribute("wellhead")]
        public static FluidSampleKind Wellhead
        {
            get 
            {
                return wellhead;
            }
        }

        private readonly static FluidSampleKind drillStemTest;
        /// <summary>
        /// The sample was obtained from a drill stem test
        /// </summary>
        [EnumValueNameAttribute("drill stem test")]
        public static FluidSampleKind DrillStemTest
        {
            get 
            {
                return drillStemTest;
            }
        }

        private readonly static FluidSampleKind formationTester;
        /// <summary>
        /// The sample was obtained from a wireline formation tester
        /// </summary>
        [EnumValueNameAttribute("formation tester")]
        public static FluidSampleKind FormationTester
        {
            get 
            {
                return formationTester;
            }
        }

        private readonly static FluidSampleKind rftOrMdt;
        /// <summary>
        ///  The sample was obtained from a Repeat Formation Tester or Modular Formation Dynamics Tester, both of which are services offered by Schlumberger, under the generic type of [wireline] formation tester 
        /// </summary>
        [EnumValueNameAttribute("RFT or MDT")]
        public static FluidSampleKind RftOrMdt
        {
            get 
            {
                return rftOrMdt;
            }
        }

        private readonly static FluidSampleKind recombined;
        /// <summary>
        /// The sample was obtained by recombining production streams from the separator
        /// </summary>
        [EnumValueNameAttribute("recombined")]
        public static FluidSampleKind Recombined
        {
            get 
            {
                return recombined;
            }
        }

        private readonly static FluidSampleKind separatorGas;
        /// <summary>
        /// The sample was obtained from the separator gas stream
        /// </summary>
        [EnumValueNameAttribute("separator gas")]
        public static FluidSampleKind SeparatorGas
        {
            get 
            {
                return separatorGas;
            }
        }

        private readonly static FluidSampleKind separatorOil;
        /// <summary>
        /// The sample was obtained from the separator oil stream
        /// </summary>
        [EnumValueNameAttribute("separator oil")]
        public static FluidSampleKind SeparatorOil
        {
            get 
            {
                return separatorOil;
            }
        }

        private readonly static FluidSampleKind separatorWater;
        /// <summary>
        /// The sample was obtained from the separator water stream
        /// </summary>
        [EnumValueNameAttribute("separator water")]
        public static FluidSampleKind SeparatorWater
        {
            get 
            {
                return separatorWater;
            }
        }

        private readonly static FluidSampleKind synthetic;
        /// <summary>
        /// The sample is a synthetic mixture
        /// </summary>
        [EnumValueNameAttribute("synthetic")]
        public static FluidSampleKind Synthetic
        {
            get 
            {
                return synthetic;
            }
        }

        private readonly static FluidSampleKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidSampleKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FluidSampleKind()
        {
            bottomHole = 
                new FluidSampleKind("bottom hole")
                {
                    Description = "The sample was obtained downhole in the wellbore"
            };
            wellhead = 
                new FluidSampleKind("wellhead")
                {
                    Description = "The sample was obtained from the production stream at the wellhead"
            };
            drillStemTest = 
                new FluidSampleKind("drill stem test")
                {
                    Description = "The sample was obtained from a drill stem test"
            };
            formationTester = 
                new FluidSampleKind("formation tester")
                {
                    Description = "The sample was obtained from a wireline formation tester"
            };
            rftOrMdt = 
                new FluidSampleKind("RFT or MDT")
                {
                    Description = " The sample was obtained from a Repeat Formation Tester or Modular Formation Dynamics Tester, both of which are services offered by Schlumberger, under the generic type of [wireline] formation tester "
            };
            recombined = 
                new FluidSampleKind("recombined")
                {
                    Description = "The sample was obtained by recombining production streams from the separator"
            };
            separatorGas = 
                new FluidSampleKind("separator gas")
                {
                    Description = "The sample was obtained from the separator gas stream"
            };
            separatorOil = 
                new FluidSampleKind("separator oil")
                {
                    Description = "The sample was obtained from the separator oil stream"
            };
            separatorWater = 
                new FluidSampleKind("separator water")
                {
                    Description = "The sample was obtained from the separator water stream"
            };
            synthetic = 
                new FluidSampleKind("synthetic")
                {
                    Description = "The sample is a synthetic mixture"
            };
            unknown = 
                new FluidSampleKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FluidSampleKind by name
        /// </summary>
        /// <param name="name">The name of the FluidSampleKind to return</param>
        /// <returns>The FluidSampleKind represented by 'name'</returns>
        public static FluidSampleKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FluidSampleKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FluidSampleKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FluidSampleKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines the kind of test acquisition which resulted in the fluid sample
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

        private readonly static FluidSampleTestAcquisition drillStemTest;
        /// <summary>
        /// The test acquisition was a drill stem test
        /// </summary>
        [EnumValueNameAttribute("drill stem test")]
        public static FluidSampleTestAcquisition DrillStemTest
        {
            get 
            {
                return drillStemTest;
            }
        }

        private readonly static FluidSampleTestAcquisition repeatFormationTester;
        /// <summary>
        ///  The test acquisition was a repeat formation tester (which is a propietary brand of Schlumberger referring to one kind of wireline formation tester) 
        /// </summary>
        [EnumValueNameAttribute("repeat formation tester")]
        public static FluidSampleTestAcquisition RepeatFormationTester
        {
            get 
            {
                return repeatFormationTester;
            }
        }

        private readonly static FluidSampleTestAcquisition unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static FluidSampleTestAcquisition Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static FluidSampleTestAcquisition()
        {
            drillStemTest = 
                new FluidSampleTestAcquisition("drill stem test")
                {
                    Description = "The test acquisition was a drill stem test"
            };
            repeatFormationTester = 
                new FluidSampleTestAcquisition("repeat formation tester")
                {
                    Description = " The test acquisition was a repeat formation tester (which is a propietary brand of Schlumberger referring to one kind of wireline formation tester) "
            };
            unknown = 
                new FluidSampleTestAcquisition("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a FluidSampleTestAcquisition by name
        /// </summary>
        /// <param name="name">The name of the FluidSampleTestAcquisition to return</param>
        /// <returns>The FluidSampleTestAcquisition represented by 'name'</returns>
        public static FluidSampleTestAcquisition GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(FluidSampleTestAcquisition)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(FluidSampleTestAcquisition)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (FluidSampleTestAcquisition)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static InjectionFluid oil;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("oil")]
        public static InjectionFluid Oil
        {
            get 
            {
                return oil;
            }
        }

        private readonly static InjectionFluid gas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gas")]
        public static InjectionFluid Gas
        {
            get 
            {
                return gas;
            }
        }

        private readonly static InjectionFluid nonHcGas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("non HC gas")]
        public static InjectionFluid NonHcGas
        {
            get 
            {
                return nonHcGas;
            }
        }

        private readonly static InjectionFluid coTwo;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("CO2")]
        public static InjectionFluid CoTwo
        {
            get 
            {
                return coTwo;
            }
        }

        private readonly static InjectionFluid water;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("water")]
        public static InjectionFluid Water
        {
            get 
            {
                return water;
            }
        }

        private readonly static InjectionFluid brine;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("brine")]
        public static InjectionFluid Brine
        {
            get 
            {
                return brine;
            }
        }

        private readonly static InjectionFluid freshWater;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("fresh water")]
        public static InjectionFluid FreshWater
        {
            get 
            {
                return freshWater;
            }
        }

        private readonly static InjectionFluid oilgas;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("oil-gas")]
        public static InjectionFluid Oilgas
        {
            get 
            {
                return oilgas;
            }
        }

        private readonly static InjectionFluid oilwater;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("oil-water")]
        public static InjectionFluid Oilwater
        {
            get 
            {
                return oilwater;
            }
        }

        private readonly static InjectionFluid gaswater;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("gas-water")]
        public static InjectionFluid Gaswater
        {
            get 
            {
                return gaswater;
            }
        }

        private readonly static InjectionFluid condensate;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("condensate")]
        public static InjectionFluid Condensate
        {
            get 
            {
                return condensate;
            }
        }

        private readonly static InjectionFluid steam;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("steam")]
        public static InjectionFluid Steam
        {
            get 
            {
                return steam;
            }
        }

        private readonly static InjectionFluid air;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("air")]
        public static InjectionFluid Air
        {
            get 
            {
                return air;
            }
        }

        private readonly static InjectionFluid dry;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("dry")]
        public static InjectionFluid Dry
        {
            get 
            {
                return dry;
            }
        }

        private readonly static InjectionFluid other;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static InjectionFluid Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static InjectionFluid unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static InjectionFluid Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static InjectionFluid()
        {
            oil = 
                new InjectionFluid("oil")
                {
            };
            gas = 
                new InjectionFluid("gas")
                {
            };
            nonHcGas = 
                new InjectionFluid("non HC gas")
                {
            };
            coTwo = 
                new InjectionFluid("CO2")
                {
            };
            water = 
                new InjectionFluid("water")
                {
            };
            brine = 
                new InjectionFluid("brine")
                {
            };
            freshWater = 
                new InjectionFluid("fresh water")
                {
            };
            oilgas = 
                new InjectionFluid("oil-gas")
                {
            };
            oilwater = 
                new InjectionFluid("oil-water")
                {
            };
            gaswater = 
                new InjectionFluid("gas-water")
                {
            };
            condensate = 
                new InjectionFluid("condensate")
                {
            };
            steam = 
                new InjectionFluid("steam")
                {
            };
            air = 
                new InjectionFluid("air")
                {
            };
            dry = 
                new InjectionFluid("dry")
                {
            };
            other = 
                new InjectionFluid("other")
                {
            };
            unknown = 
                new InjectionFluid("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a InjectionFluid by name
        /// </summary>
        /// <param name="name">The name of the InjectionFluid to return</param>
        /// <returns>The InjectionFluid represented by 'name'</returns>
        public static InjectionFluid GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(InjectionFluid)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(InjectionFluid)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (InjectionFluid)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static InstalledFiberPoint splice;
        /// <summary>
        ///  A point at which a fiber is physically, and semi-permanently, connected to another length of fiber. 
        /// </summary>
        [EnumValueNameAttribute("splice")]
        public static InstalledFiberPoint Splice
        {
            get 
            {
                return splice;
            }
        }

        private readonly static InstalledFiberPoint connector;
        /// <summary>
        ///  A point at which a cable connector is installed, which allows the fiber to be connected to another instrument or fiber length. 
        /// </summary>
        [EnumValueNameAttribute("connector")]
        public static InstalledFiberPoint Connector
        {
            get 
            {
                return connector;
            }
        }

        private readonly static InstalledFiberPoint endOfFiber;
        /// <summary>
        ///  The end of the fiber. If a U-geometry is used, and a connector is at both ends, the connector classification should be used rather than the end of fiber classification. 
        /// </summary>
        [EnumValueNameAttribute("end of fiber")]
        public static InstalledFiberPoint EndOfFiber
        {
            get 
            {
                return endOfFiber;
            }
        }

        private readonly static InstalledFiberPoint baseOfFiber;
        /// <summary>
        ///  The deepest point of the installed fiber in a well. This is a valid value for fiber installations that do NOT turn around at the bottom (J- and U-type installations). 
        /// </summary>
        [EnumValueNameAttribute("base of fiber")]
        public static InstalledFiberPoint BaseOfFiber
        {
            get 
            {
                return baseOfFiber;
            }
        }

        private readonly static InstalledFiberPoint turnAroundPoint;
        /// <summary>
        ///  The point in the turn-around-sub at which measured depth stops increasing and begins decreasing. This is a valid value for fiber installations of the J- and U- type only. 
        /// </summary>
        [EnumValueNameAttribute("turn around point")]
        public static InstalledFiberPoint TurnAroundPoint
        {
            get 
            {
                return turnAroundPoint;
            }
        }

        private readonly static InstalledFiberPoint startOfFiber;
        /// <summary>
        ///  The start of the fiber. If appropriate, the connector classification should be used instead of this classification. 
        /// </summary>
        [EnumValueNameAttribute("start of fiber")]
        public static InstalledFiberPoint StartOfFiber
        {
            get 
            {
                return startOfFiber;
            }
        }

        private readonly static InstalledFiberPoint ovenEntryPoint;
        /// <summary>
        /// The point on the fiber at which it enters the oven.
        /// </summary>
        [EnumValueNameAttribute("oven entry point")]
        public static InstalledFiberPoint OvenEntryPoint
        {
            get 
            {
                return ovenEntryPoint;
            }
        }

        private readonly static InstalledFiberPoint ovenExitPoint;
        /// <summary>
        ///  The point on the fiber at which it exits the oven. The oven exit point should be closer to the wellbore than the oven entry point. 
        /// </summary>
        [EnumValueNameAttribute("oven exit point")]
        public static InstalledFiberPoint OvenExitPoint
        {
            get 
            {
                return ovenExitPoint;
            }
        }

        private readonly static InstalledFiberPoint downholeGauge;
        /// <summary>
        /// A downhole point on the fiber at which a gauge is attached.
        /// </summary>
        [EnumValueNameAttribute("downhole gauge")]
        public static InstalledFiberPoint DownholeGauge
        {
            get 
            {
                return downholeGauge;
            }
        }

        private readonly static InstalledFiberPoint dtsLaserHead;
        /// <summary>
        /// The connector between the laser head and the optical fiber.
        /// </summary>
        [EnumValueNameAttribute("DTS laser head")]
        public static InstalledFiberPoint DtsLaserHead
        {
            get 
            {
                return dtsLaserHead;
            }
        }

        private readonly static InstalledFiberPoint dtsReferenceOven;
        /// <summary>
        ///  The oven within or near the DTS instrument box which maintains a length of fiber at a reference temperature. 
        /// </summary>
        [EnumValueNameAttribute("DTS reference oven")]
        public static InstalledFiberPoint DtsReferenceOven
        {
            get 
            {
                return dtsReferenceOven;
            }
        }

        private readonly static InstalledFiberPoint spliceBox;
        /// <summary>
        /// Container in which ends of lengths of fiber are joined.
        /// </summary>
        [EnumValueNameAttribute("splice box")]
        public static InstalledFiberPoint SpliceBox
        {
            get 
            {
                return spliceBox;
            }
        }

        private readonly static InstalledFiberPoint wellheadJunctionBox;
        /// <summary>
        ///  The device at which a fiber originating at the instrument box is joined to a fiber installed in a wellbore. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated 
        /// </summary>
        [EnumValueNameAttribute("wellhead junction box")]
        public static InstalledFiberPoint WellheadJunctionBox
        {
            get 
            {
                return wellheadJunctionBox;
            }
        }

        private readonly static InstalledFiberPoint baseTubingHangerFlange;
        /// <summary>
        ///  The device at the base of the wellhead to which the production tubing is attached. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated. 
        /// </summary>
        [EnumValueNameAttribute("base tubing hanger flange")]
        public static InstalledFiberPoint BaseTubingHangerFlange
        {
            get 
            {
                return baseTubingHangerFlange;
            }
        }

        private readonly static InstalledFiberPoint pbrWetConnect;
        /// <summary>
        ///  The top-most point at which the fiber intersects the PBR (polished bore receptacle). For J- and U- installations, on the upward portion of the fiber, this is the point at which it leaves the pbf. 
        /// </summary>
        [EnumValueNameAttribute("PBR wet connect")]
        public static InstalledFiberPoint PbrWetConnect
        {
            get 
            {
                return pbrWetConnect;
            }
        }

        private readonly static InstalledFiberPoint topEspPump;
        /// <summary>
        ///  The top of the electrical submersible pump (ESP). This is the minimum measured depth point of the pump. 
        /// </summary>
        [EnumValueNameAttribute("top ESP pump")]
        public static InstalledFiberPoint TopEspPump
        {
            get 
            {
                return topEspPump;
            }
        }

        private readonly static InstalledFiberPoint baseEspPump;
        /// <summary>
        ///  The base of the electrical submersible pump (ESP). This is the maximum measured depth point of the pump. 
        /// </summary>
        [EnumValueNameAttribute("base ESP pump")]
        public static InstalledFiberPoint BaseEspPump
        {
            get 
            {
                return baseEspPump;
            }
        }

        private readonly static InstalledFiberPoint wellheadTemperatureGauge;
        /// <summary>
        ///  Temperature measuring device at the wellhead independent of the optic fiber sensor. 
        /// </summary>
        [EnumValueNameAttribute("wellhead temperature gauge")]
        public static InstalledFiberPoint WellheadTemperatureGauge
        {
            get 
            {
                return wellheadTemperatureGauge;
            }
        }

        private readonly static InstalledFiberPoint topCompletionZone;
        /// <summary>
        ///  The point which is the minimum measured depth of a completion zone. 
        /// </summary>
        [EnumValueNameAttribute("top completion zone")]
        public static InstalledFiberPoint TopCompletionZone
        {
            get 
            {
                return topCompletionZone;
            }
        }

        private readonly static InstalledFiberPoint baseCompletionZone;
        /// <summary>
        ///  The point which is the maximum measured depth of a completion zone. 
        /// </summary>
        [EnumValueNameAttribute("base completion zone")]
        public static InstalledFiberPoint BaseCompletionZone
        {
            get 
            {
                return baseCompletionZone;
            }
        }

        private readonly static InstalledFiberPoint unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static InstalledFiberPoint Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static InstalledFiberPoint()
        {
            splice = 
                new InstalledFiberPoint("splice")
                {
                    Description = " A point at which a fiber is physically, and semi-permanently, connected to another length of fiber. "
            };
            connector = 
                new InstalledFiberPoint("connector")
                {
                    Description = " A point at which a cable connector is installed, which allows the fiber to be connected to another instrument or fiber length. "
            };
            endOfFiber = 
                new InstalledFiberPoint("end of fiber")
                {
                    Description = " The end of the fiber. If a U-geometry is used, and a connector is at both ends, the connector classification should be used rather than the end of fiber classification. "
            };
            baseOfFiber = 
                new InstalledFiberPoint("base of fiber")
                {
                    Description = " The deepest point of the installed fiber in a well. This is a valid value for fiber installations that do NOT turn around at the bottom (J- and U-type installations). "
            };
            turnAroundPoint = 
                new InstalledFiberPoint("turn around point")
                {
                    Description = " The point in the turn-around-sub at which measured depth stops increasing and begins decreasing. This is a valid value for fiber installations of the J- and U- type only. "
            };
            startOfFiber = 
                new InstalledFiberPoint("start of fiber")
                {
                    Description = " The start of the fiber. If appropriate, the connector classification should be used instead of this classification. "
            };
            ovenEntryPoint = 
                new InstalledFiberPoint("oven entry point")
                {
                    Description = "The point on the fiber at which it enters the oven."
            };
            ovenExitPoint = 
                new InstalledFiberPoint("oven exit point")
                {
                    Description = " The point on the fiber at which it exits the oven. The oven exit point should be closer to the wellbore than the oven entry point. "
            };
            downholeGauge = 
                new InstalledFiberPoint("downhole gauge")
                {
                    Description = "A downhole point on the fiber at which a gauge is attached."
            };
            dtsLaserHead = 
                new InstalledFiberPoint("DTS laser head")
                {
                    Description = "The connector between the laser head and the optical fiber."
            };
            dtsReferenceOven = 
                new InstalledFiberPoint("DTS reference oven")
                {
                    Description = " The oven within or near the DTS instrument box which maintains a length of fiber at a reference temperature. "
            };
            spliceBox = 
                new InstalledFiberPoint("splice box")
                {
                    Description = "Container in which ends of lengths of fiber are joined."
            };
            wellheadJunctionBox = 
                new InstalledFiberPoint("wellhead junction box")
                {
                    Description = " The device at which a fiber originating at the instrument box is joined to a fiber installed in a wellbore. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated "
            };
            baseTubingHangerFlange = 
                new InstalledFiberPoint("base tubing hanger flange")
                {
                    Description = " The device at the base of the wellhead to which the production tubing is attached. This is a recommended location at which LengthAlongFiber and measuredDepth in the wellbore are correlated. "
            };
            pbrWetConnect = 
                new InstalledFiberPoint("PBR wet connect")
                {
                    Description = " The top-most point at which the fiber intersects the PBR (polished bore receptacle). For J- and U- installations, on the upward portion of the fiber, this is the point at which it leaves the pbf. "
            };
            topEspPump = 
                new InstalledFiberPoint("top ESP pump")
                {
                    Description = " The top of the electrical submersible pump (ESP). This is the minimum measured depth point of the pump. "
            };
            baseEspPump = 
                new InstalledFiberPoint("base ESP pump")
                {
                    Description = " The base of the electrical submersible pump (ESP). This is the maximum measured depth point of the pump. "
            };
            wellheadTemperatureGauge = 
                new InstalledFiberPoint("wellhead temperature gauge")
                {
                    Description = " Temperature measuring device at the wellhead independent of the optic fiber sensor. "
            };
            topCompletionZone = 
                new InstalledFiberPoint("top completion zone")
                {
                    Description = " The point which is the minimum measured depth of a completion zone. "
            };
            baseCompletionZone = 
                new InstalledFiberPoint("base completion zone")
                {
                    Description = " The point which is the maximum measured depth of a completion zone. "
            };
            unknown = 
                new InstalledFiberPoint("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a InstalledFiberPoint by name
        /// </summary>
        /// <param name="name">The name of the InstalledFiberPoint to return</param>
        /// <returns>The InstalledFiberPoint represented by 'name'</returns>
        public static InstalledFiberPoint GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(InstalledFiberPoint)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(InstalledFiberPoint)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (InstalledFiberPoint)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static OperationKind production;
        /// <summary>
        /// Production operations.
        /// </summary>
        [EnumValueNameAttribute("production")]
        public static OperationKind Production
        {
            get 
            {
                return production;
            }
        }

        private readonly static OperationKind well;
        /// <summary>
        /// Well operations.
        /// </summary>
        [EnumValueNameAttribute("well")]
        public static OperationKind Well
        {
            get 
            {
                return well;
            }
        }

        private readonly static OperationKind deviations;
        /// <summary>
        /// Deviations from existing procedures and guidelines.
        /// </summary>
        [EnumValueNameAttribute("deviations")]
        public static OperationKind Deviations
        {
            get 
            {
                return deviations;
            }
        }

        private readonly static OperationKind maintenance;
        /// <summary>
        /// Maintenance work.
        /// </summary>
        [EnumValueNameAttribute("maintenance")]
        public static OperationKind Maintenance
        {
            get 
            {
                return maintenance;
            }
        }

        private readonly static OperationKind construction;
        /// <summary>
        /// Construction work.
        /// </summary>
        [EnumValueNameAttribute("construction")]
        public static OperationKind Construction
        {
            get 
            {
                return construction;
            }
        }

        private readonly static OperationKind powerStationFailure;
        /// <summary>
        /// Failure of a power station.
        /// </summary>
        [EnumValueNameAttribute("power station failure")]
        public static OperationKind PowerStationFailure
        {
            get 
            {
                return powerStationFailure;
            }
        }

        private readonly static OperationKind airTraffic;
        /// <summary>
        /// Air traffic in the area.
        /// </summary>
        [EnumValueNameAttribute("air traffic")]
        public static OperationKind AirTraffic
        {
            get 
            {
                return airTraffic;
            }
        }

        private readonly static OperationKind other;
        /// <summary>
        /// Other comment relevant for the production periods on the installation.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static OperationKind Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static OperationKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static OperationKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static OperationKind()
        {
            production = 
                new OperationKind("production")
                {
                    Description = "Production operations."
            };
            well = 
                new OperationKind("well")
                {
                    Description = "Well operations."
            };
            deviations = 
                new OperationKind("deviations")
                {
                    Description = "Deviations from existing procedures and guidelines."
            };
            maintenance = 
                new OperationKind("maintenance")
                {
                    Description = "Maintenance work."
            };
            construction = 
                new OperationKind("construction")
                {
                    Description = "Construction work."
            };
            powerStationFailure = 
                new OperationKind("power station failure")
                {
                    Description = "Failure of a power station."
            };
            airTraffic = 
                new OperationKind("air traffic")
                {
                    Description = "Air traffic in the area."
            };
            other = 
                new OperationKind("other")
                {
                    Description = "Other comment relevant for the production periods on the installation."
            };
            unknown = 
                new OperationKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a OperationKind by name
        /// </summary>
        /// <param name="name">The name of the OperationKind to return</param>
        /// <returns>The OperationKind represented by 'name'</returns>
        public static OperationKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(OperationKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(OperationKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (OperationKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			The reason an Optical Time Domain Reflectometry (OTDR)
    ///			test was run within a  Distributed Temperature Survey (DTS).
    ///		
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

        private readonly static OTDRReason preinstallation;
        /// <summary>
        /// The OTDR was run prior to installing the fiber in the well.
        /// </summary>
        [EnumValueNameAttribute("pre-installation")]
        public static OTDRReason Preinstallation
        {
            get 
            {
                return preinstallation;
            }
        }

        private readonly static OTDRReason postinstallation;
        /// <summary>
        ///  The OTDR was run after installing the fiber in the well in order to quality check the installation process. 
        /// </summary>
        [EnumValueNameAttribute("post-installation")]
        public static OTDRReason Postinstallation
        {
            get 
            {
                return postinstallation;
            }
        }

        private readonly static OTDRReason dtsRun;
        /// <summary>
        ///  The OTDR was run in conjunction with a DTS run. This is generally immediately preceding the timed run. 
        /// </summary>
        [EnumValueNameAttribute("DTS run")]
        public static OTDRReason DtsRun
        {
            get 
            {
                return dtsRun;
            }
        }

        private readonly static OTDRReason other;
        /// <summary>
        /// The OTDR was run for another reason.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static OTDRReason Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static OTDRReason unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static OTDRReason Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static OTDRReason()
        {
            preinstallation = 
                new OTDRReason("pre-installation")
                {
                    Description = "The OTDR was run prior to installing the fiber in the well."
            };
            postinstallation = 
                new OTDRReason("post-installation")
                {
                    Description = " The OTDR was run after installing the fiber in the well in order to quality check the installation process. "
            };
            dtsRun = 
                new OTDRReason("DTS run")
                {
                    Description = " The OTDR was run in conjunction with a DTS run. This is generally immediately preceding the timed run. "
            };
            other = 
                new OTDRReason("other")
                {
                    Description = "The OTDR was run for another reason."
            };
            unknown = 
                new OTDRReason("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a OTDRReason by name
        /// </summary>
        /// <param name="name">The name of the OTDRReason to return</param>
        /// <returns>The OTDRReason represented by 'name'</returns>
        public static OTDRReason GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(OTDRReason)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(OTDRReason)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (OTDRReason)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static PhoneType voice;
        /// <summary>
        ///  The telephone number is a conventional number which is used for voice contact. 
        /// </summary>
        [EnumValueNameAttribute("voice")]
        public static PhoneType Voice
        {
            get 
            {
                return voice;
            }
        }

        private readonly static PhoneType fax;
        /// <summary>
        ///  The telephone number is exclusively used for receiving faxes. 
        /// </summary>
        [EnumValueNameAttribute("fax")]
        public static PhoneType Fax
        {
            get 
            {
                return fax;
            }
        }

        private readonly static PhoneType mobile;
        /// <summary>
        ///  The telephone number is a mobile telephone, such as a cell phone. 
        /// </summary>
        [EnumValueNameAttribute("mobile")]
        public static PhoneType Mobile
        {
            get 
            {
                return mobile;
            }
        }

        private readonly static PhoneType voicefax;
        /// <summary>
        ///  The telephone at this number is capable of voice communication and of receiving faxes. 
        /// </summary>
        [EnumValueNameAttribute("voice/fax")]
        public static PhoneType Voicefax
        {
            get 
            {
                return voicefax;
            }
        }

        private readonly static PhoneType voicemail;
        /// <summary>
        ///  The telephone is connected directly to voice mail. A voice phone may lead a caller to voice mail. However this choice qualifies the phone type as being only voice mail. 
        /// </summary>
        [EnumValueNameAttribute("voicemail")]
        public static PhoneType Voicemail
        {
            get 
            {
                return voicemail;
            }
        }

        private readonly static PhoneType pager;
        /// <summary>
        /// The telephone is intended only for pages.
        /// </summary>
        [EnumValueNameAttribute("pager")]
        public static PhoneType Pager
        {
            get 
            {
                return pager;
            }
        }

        private readonly static PhoneType unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static PhoneType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static PhoneType()
        {
            voice = 
                new PhoneType("voice")
                {
                    Description = " The telephone number is a conventional number which is used for voice contact. "
            };
            fax = 
                new PhoneType("fax")
                {
                    Description = " The telephone number is exclusively used for receiving faxes. "
            };
            mobile = 
                new PhoneType("mobile")
                {
                    Description = " The telephone number is a mobile telephone, such as a cell phone. "
            };
            voicefax = 
                new PhoneType("voice/fax")
                {
                    Description = " The telephone at this number is capable of voice communication and of receiving faxes. "
            };
            voicemail = 
                new PhoneType("voicemail")
                {
                    Description = " The telephone is connected directly to voice mail. A voice phone may lead a caller to voice mail. However this choice qualifies the phone type as being only voice mail. "
            };
            pager = 
                new PhoneType("pager")
                {
                    Description = "The telephone is intended only for pages."
            };
            unknown = 
                new PhoneType("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a PhoneType by name
        /// </summary>
        /// <param name="name">The name of the PhoneType to return</param>
        /// <returns>The PhoneType represented by 'name'</returns>
        public static PhoneType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(PhoneType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(PhoneType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (PhoneType)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ProductFlowPortType inlet;
        /// <summary>
        /// An inlet port by which fluid normally flows into the Product Flow Unit.
        /// </summary>
        [EnumValueNameAttribute("inlet")]
        public static ProductFlowPortType Inlet
        {
            get 
            {
                return inlet;
            }
        }

        private readonly static ProductFlowPortType outlet;
        /// <summary>
        /// An inlet port by which fluid normally flows out of Product Flow Unit.
        /// </summary>
        [EnumValueNameAttribute("outlet")]
        public static ProductFlowPortType Outlet
        {
            get 
            {
                return outlet;
            }
        }

        private readonly static ProductFlowPortType unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ProductFlowPortType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ProductFlowPortType()
        {
            inlet = 
                new ProductFlowPortType("inlet")
                {
                    Description = "An inlet port by which fluid normally flows into the Product Flow Unit."
            };
            outlet = 
                new ProductFlowPortType("outlet")
                {
                    Description = "An inlet port by which fluid normally flows out of Product Flow Unit."
            };
            unknown = 
                new ProductFlowPortType("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ProductFlowPortType by name
        /// </summary>
        /// <param name="name">The name of the ProductFlowPortType to return</param>
        /// <returns>The ProductFlowPortType represented by 'name'</returns>
        public static ProductFlowPortType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ProductFlowPortType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ProductFlowPortType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ProductFlowPortType)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ReasonLost topsideEquipmentFailuremaint;
        /// <summary>
        /// Estimated loss of production due to equipment failure and maintenance topside.
        /// </summary>
        [EnumValueNameAttribute("topside equipment failure-maint")]
        public static ReasonLost TopsideEquipmentFailuremaint
        {
            get 
            {
                return topsideEquipmentFailuremaint;
            }
        }

        private readonly static ReasonLost extendedMaintTurnaround;
        /// <summary>
        /// Estimated loss of production due to extended maintenance turnaround.
        /// </summary>
        [EnumValueNameAttribute("extended maint turnaround")]
        public static ReasonLost ExtendedMaintTurnaround
        {
            get 
            {
                return extendedMaintTurnaround;
            }
        }

        private readonly static ReasonLost extendedMaintTurnaroundExport;
        /// <summary>
        /// Estimated loss of production due to extended maintenance turnaround on export terminal.
        /// </summary>
        [EnumValueNameAttribute("extended maint turnaround export")]
        public static ReasonLost ExtendedMaintTurnaroundExport
        {
            get 
            {
                return extendedMaintTurnaroundExport;
            }
        }

        private readonly static ReasonLost preventiveMaintTopside;
        /// <summary>
        /// Estimated loss of production due to preventive maintenance topside.
        /// </summary>
        [EnumValueNameAttribute("preventive maint topside")]
        public static ReasonLost PreventiveMaintTopside
        {
            get 
            {
                return preventiveMaintTopside;
            }
        }

        private readonly static ReasonLost plannedMaintTurnaround;
        /// <summary>
        /// Estimated loss of production due to planned maintenance turnaround.
        /// </summary>
        [EnumValueNameAttribute("planned maint turnaround")]
        public static ReasonLost PlannedMaintTurnaround
        {
            get 
            {
                return plannedMaintTurnaround;
            }
        }

        private readonly static ReasonLost markedOil;
        /// <summary>
        /// Estimated loss of oil production due to lost export due to marked product.
        /// </summary>
        [EnumValueNameAttribute("marked oil")]
        public static ReasonLost MarkedOil
        {
            get 
            {
                return markedOil;
            }
        }

        private readonly static ReasonLost markedGas;
        /// <summary>
        /// Estimated loss of gas production due to lost export due to marked product.
        /// </summary>
        [EnumValueNameAttribute("marked gas")]
        public static ReasonLost MarkedGas
        {
            get 
            {
                return markedGas;
            }
        }

        private readonly static ReasonLost modificationProject;
        /// <summary>
        /// Estimated loss of production due to modification projects.
        /// </summary>
        [EnumValueNameAttribute("modification project")]
        public static ReasonLost ModificationProject
        {
            get 
            {
                return modificationProject;
            }
        }

        private readonly static ReasonLost operationMistakes;
        /// <summary>
        /// Estimated loss of production due to operation mistakes reference.
        /// </summary>
        [EnumValueNameAttribute("operation mistakes")]
        public static ReasonLost OperationMistakes
        {
            get 
            {
                return operationMistakes;
            }
        }

        private readonly static ReasonLost other;
        /// <summary>
        /// Estimated loss of production due to unspecified reasons.
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static ReasonLost Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static ReasonLost processAndOperationProblem;
        /// <summary>
        /// Estimated loss of production due to process and operation problems.
        /// </summary>
        [EnumValueNameAttribute("process and operation problem")]
        public static ReasonLost ProcessAndOperationProblem
        {
            get 
            {
                return processAndOperationProblem;
            }
        }

        private readonly static ReasonLost production;
        /// <summary>
        /// Estimated loss of production due to total loss of production.
        /// </summary>
        [EnumValueNameAttribute("production")]
        public static ReasonLost Production
        {
            get 
            {
                return production;
            }
        }

        private readonly static ReasonLost regulatoryReference;
        /// <summary>
        /// Estimated loss of production due to regulatory reference.
        /// </summary>
        [EnumValueNameAttribute("regulatory reference")]
        public static ReasonLost RegulatoryReference
        {
            get 
            {
                return regulatoryReference;
            }
        }

        private readonly static ReasonLost reservoir;
        /// <summary>
        /// Estimated loss of production due to reservoir losses.
        /// </summary>
        [EnumValueNameAttribute("reservoir")]
        public static ReasonLost Reservoir
        {
            get 
            {
                return reservoir;
            }
        }

        private readonly static ReasonLost testingAndLogging;
        /// <summary>
        /// Estimated loss of production due to well testing and logging.
        /// </summary>
        [EnumValueNameAttribute("testing and logging")]
        public static ReasonLost TestingAndLogging
        {
            get 
            {
                return testingAndLogging;
            }
        }

        private readonly static ReasonLost unavailableTankerStorage;
        /// <summary>
        /// Estimated loss of production due to unavailable tanker storage.
        /// </summary>
        [EnumValueNameAttribute("unavailable tanker storage")]
        public static ReasonLost UnavailableTankerStorage
        {
            get 
            {
                return unavailableTankerStorage;
            }
        }

        private readonly static ReasonLost wellEquipmentFailuremaint;
        /// <summary>
        /// Estimated loss of production due to well equipment failure and maintenance.
        /// </summary>
        [EnumValueNameAttribute("well equipment failure-maint")]
        public static ReasonLost WellEquipmentFailuremaint
        {
            get 
            {
                return wellEquipmentFailuremaint;
            }
        }

        private readonly static ReasonLost wellPlannedOperations;
        /// <summary>
        /// Estimated loss of production due to planned well operations.
        /// </summary>
        [EnumValueNameAttribute("well planned operations")]
        public static ReasonLost WellPlannedOperations
        {
            get 
            {
                return wellPlannedOperations;
            }
        }

        private readonly static ReasonLost wellPreventiveMaint;
        /// <summary>
        /// Estimated loss of production due to preventive maintenance on a well.
        /// </summary>
        [EnumValueNameAttribute("well preventive maint")]
        public static ReasonLost WellPreventiveMaint
        {
            get 
            {
                return wellPreventiveMaint;
            }
        }

        private readonly static ReasonLost weatherProblem;
        /// <summary>
        /// Estimated loss of production due to weather conditions.
        /// </summary>
        [EnumValueNameAttribute("weather problem")]
        public static ReasonLost WeatherProblem
        {
            get 
            {
                return weatherProblem;
            }
        }

        private readonly static ReasonLost hse;
        /// <summary>
        /// Estimated loss of production due to Safety or Emergency requirements.
        /// </summary>
        [EnumValueNameAttribute("hse")]
        public static ReasonLost Hse
        {
            get 
            {
                return hse;
            }
        }

        private readonly static ReasonLost strikelockout;
        /// <summary>
        /// Estimated loss of production due to strike or lock-out.
        /// </summary>
        [EnumValueNameAttribute("strike/lock-out")]
        public static ReasonLost Strikelockout
        {
            get 
            {
                return strikelockout;
            }
        }

        private readonly static ReasonLost threerdPartyProcessing;
        /// <summary>
        /// Estimated loss of production due to 3rd party processing.
        /// </summary>
        [EnumValueNameAttribute("3rd party processing")]
        public static ReasonLost ThreerdPartyProcessing
        {
            get 
            {
                return threerdPartyProcessing;
            }
        }

        private readonly static ReasonLost dailyTotalLossOfProd;
        /// <summary>
        /// Estimated total loss of production.
        /// </summary>
        [EnumValueNameAttribute("daily total loss of prod")]
        public static ReasonLost DailyTotalLossOfProd
        {
            get 
            {
                return dailyTotalLossOfProd;
            }
        }

        private readonly static ReasonLost wellProblems;
        /// <summary>
        /// Estimated loss of production due well problems.
        /// </summary>
        [EnumValueNameAttribute("well problems")]
        public static ReasonLost WellProblems
        {
            get 
            {
                return wellProblems;
            }
        }

        private readonly static ReasonLost unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReasonLost Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReasonLost()
        {
            topsideEquipmentFailuremaint = 
                new ReasonLost("topside equipment failure-maint")
                {
                    Description = "Estimated loss of production due to equipment failure and maintenance topside."
            };
            extendedMaintTurnaround = 
                new ReasonLost("extended maint turnaround")
                {
                    Description = "Estimated loss of production due to extended maintenance turnaround."
            };
            extendedMaintTurnaroundExport = 
                new ReasonLost("extended maint turnaround export")
                {
                    Description = "Estimated loss of production due to extended maintenance turnaround on export terminal."
            };
            preventiveMaintTopside = 
                new ReasonLost("preventive maint topside")
                {
                    Description = "Estimated loss of production due to preventive maintenance topside."
            };
            plannedMaintTurnaround = 
                new ReasonLost("planned maint turnaround")
                {
                    Description = "Estimated loss of production due to planned maintenance turnaround."
            };
            markedOil = 
                new ReasonLost("marked oil")
                {
                    Description = "Estimated loss of oil production due to lost export due to marked product."
            };
            markedGas = 
                new ReasonLost("marked gas")
                {
                    Description = "Estimated loss of gas production due to lost export due to marked product."
            };
            modificationProject = 
                new ReasonLost("modification project")
                {
                    Description = "Estimated loss of production due to modification projects."
            };
            operationMistakes = 
                new ReasonLost("operation mistakes")
                {
                    Description = "Estimated loss of production due to operation mistakes reference."
            };
            other = 
                new ReasonLost("other")
                {
                    Description = "Estimated loss of production due to unspecified reasons."
            };
            processAndOperationProblem = 
                new ReasonLost("process and operation problem")
                {
                    Description = "Estimated loss of production due to process and operation problems."
            };
            production = 
                new ReasonLost("production")
                {
                    Description = "Estimated loss of production due to total loss of production."
            };
            regulatoryReference = 
                new ReasonLost("regulatory reference")
                {
                    Description = "Estimated loss of production due to regulatory reference."
            };
            reservoir = 
                new ReasonLost("reservoir")
                {
                    Description = "Estimated loss of production due to reservoir losses."
            };
            testingAndLogging = 
                new ReasonLost("testing and logging")
                {
                    Description = "Estimated loss of production due to well testing and logging."
            };
            unavailableTankerStorage = 
                new ReasonLost("unavailable tanker storage")
                {
                    Description = "Estimated loss of production due to unavailable tanker storage."
            };
            wellEquipmentFailuremaint = 
                new ReasonLost("well equipment failure-maint")
                {
                    Description = "Estimated loss of production due to well equipment failure and maintenance."
            };
            wellPlannedOperations = 
                new ReasonLost("well planned operations")
                {
                    Description = "Estimated loss of production due to planned well operations."
            };
            wellPreventiveMaint = 
                new ReasonLost("well preventive maint")
                {
                    Description = "Estimated loss of production due to preventive maintenance on a well."
            };
            weatherProblem = 
                new ReasonLost("weather problem")
                {
                    Description = "Estimated loss of production due to weather conditions."
            };
            hse = 
                new ReasonLost("hse")
                {
                    Description = "Estimated loss of production due to Safety or Emergency requirements."
            };
            strikelockout = 
                new ReasonLost("strike/lock-out")
                {
                    Description = "Estimated loss of production due to strike or lock-out."
            };
            threerdPartyProcessing = 
                new ReasonLost("3rd party processing")
                {
                    Description = "Estimated loss of production due to 3rd party processing."
            };
            dailyTotalLossOfProd = 
                new ReasonLost("daily total loss of prod")
                {
                    Description = "Estimated total loss of production."
            };
            wellProblems = 
                new ReasonLost("well problems")
                {
                    Description = "Estimated loss of production due well problems."
            };
            unknown = 
                new ReasonLost("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReasonLost by name
        /// </summary>
        /// <param name="name">The name of the ReasonLost to return</param>
        /// <returns>The ReasonLost represented by 'name'</returns>
        public static ReasonLost GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReasonLost)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReasonLost)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReasonLost)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ReportingFacility blockValve;
        /// <summary>
        /// A single block valve.
        /// </summary>
        [EnumValueNameAttribute("block valve")]
        public static ReportingFacility BlockValve
        {
            get 
            {
                return blockValve;
            }
        }

        private readonly static ReportingFacility bottomhole;
        /// <summary>
        /// A single bottomhole.
        /// </summary>
        [EnumValueNameAttribute("bottomhole")]
        public static ReportingFacility Bottomhole
        {
            get 
            {
                return bottomhole;
            }
        }

        private readonly static ReportingFacility casing;
        /// <summary>
        /// A production casing (steel pipe) used to seal and stabilize a wellbore.
        /// </summary>
        [EnumValueNameAttribute("casing")]
        public static ReportingFacility Casing
        {
            get 
            {
                return casing;
            }
        }

        private readonly static ReportingFacility choke;
        /// <summary>
        /// A single choke.
        /// </summary>
        [EnumValueNameAttribute("choke")]
        public static ReportingFacility Choke
        {
            get 
            {
                return choke;
            }
        }

        private readonly static ReportingFacility cluster;
        /// <summary>
        /// A single cluster.
        /// </summary>
        [EnumValueNameAttribute("cluster")]
        public static ReportingFacility Cluster
        {
            get 
            {
                return cluster;
            }
        }

        private readonly static ReportingFacility commercialEntity;
        /// <summary>
        /// A commercial entity is an organizational construct through which the a group of organizations or facilities are grouped as if it were a single composite.
        /// </summary>
        [EnumValueNameAttribute("commercial entity")]
        public static ReportingFacility CommercialEntity
        {
            get 
            {
                return commercialEntity;
            }
        }

        private readonly static ReportingFacility company;
        /// <summary>
        /// A company name that is the name of the operator company.
        /// </summary>
        [EnumValueNameAttribute("company")]
        public static ReportingFacility Company
        {
            get 
            {
                return company;
            }
        }

        private readonly static ReportingFacility completion;
        /// <summary>
        /// A single completion.
        /// </summary>
        [EnumValueNameAttribute("completion")]
        public static ReportingFacility Completion
        {
            get 
            {
                return completion;
            }
        }

        private readonly static ReportingFacility compressor;
        /// <summary>
        /// A single compressor.
        /// </summary>
        [EnumValueNameAttribute("compressor")]
        public static ReportingFacility Compressor
        {
            get 
            {
                return compressor;
            }
        }

        private readonly static ReportingFacility controller;
        /// <summary>
        /// A single lift gas controller.
        /// </summary>
        [EnumValueNameAttribute("controller")]
        public static ReportingFacility Controller
        {
            get 
            {
                return controller;
            }
        }

        private readonly static ReportingFacility controllerLift;
        /// <summary>
        /// "DEPRECATED: use ""controller"" instead."
        /// </summary>
        [EnumValueNameAttribute("controller -- lift")]
        public static ReportingFacility ControllerLift
        {
            get 
            {
                return controllerLift;
            }
        }

        private readonly static ReportingFacility country;
        /// <summary>
        /// A single country.
        /// </summary>
        [EnumValueNameAttribute("country")]
        public static ReportingFacility Country
        {
            get 
            {
                return country;
            }
        }

        private readonly static ReportingFacility county;
        /// <summary>
        /// A single county.
        /// </summary>
        [EnumValueNameAttribute("county")]
        public static ReportingFacility County
        {
            get 
            {
                return county;
            }
        }

        private readonly static ReportingFacility downholeMonitoringSystem;
        /// <summary>
        /// An equipment permanently fitted in the well's tubing that is equipped with pressure and temperature sensors.
        /// </summary>
        [EnumValueNameAttribute("downhole monitoring system")]
        public static ReportingFacility DownholeMonitoringSystem
        {
            get 
            {
                return downholeMonitoringSystem;
            }
        }

        private readonly static ReportingFacility electricSubmersiblePump;
        /// <summary>
        /// An artificial-lift system that utilizes a downhole pumping system that is electrically driven.
        /// </summary>
        [EnumValueNameAttribute("electric submersible pump")]
        public static ReportingFacility ElectricSubmersiblePump
        {
            get 
            {
                return electricSubmersiblePump;
            }
        }

        private readonly static ReportingFacility field;
        /// <summary>
        /// A single field.
        /// </summary>
        [EnumValueNameAttribute("field")]
        public static ReportingFacility Field
        {
            get 
            {
                return field;
            }
        }

        private readonly static ReportingFacility fieldArea;
        /// <summary>
        /// A ground that is an area above an oilfield.
        /// </summary>
        [EnumValueNameAttribute("field - area")]
        public static ReportingFacility FieldArea
        {
            get 
            {
                return fieldArea;
            }
        }

        private readonly static ReportingFacility fieldGroup;
        /// <summary>
        /// An area concept that is a grouping of two or more selected petroleum fields for commercial reasons or other purposes.
        /// </summary>
        [EnumValueNameAttribute("field - group")]
        public static ReportingFacility FieldGroup
        {
            get 
            {
                return fieldGroup;
            }
        }

        private readonly static ReportingFacility fieldPart;
        /// <summary>
        /// An area concept that is an area that forms part of a petroleum field.
        /// </summary>
        [EnumValueNameAttribute("field - part")]
        public static ReportingFacility FieldPart
        {
            get 
            {
                return fieldPart;
            }
        }

        private readonly static ReportingFacility flowMeter;
        /// <summary>
        /// A single flow meter.
        /// </summary>
        [EnumValueNameAttribute("flow meter")]
        public static ReportingFacility FlowMeter
        {
            get 
            {
                return flowMeter;
            }
        }

        private readonly static ReportingFacility flowline;
        /// <summary>
        /// A single flowline.
        /// </summary>
        [EnumValueNameAttribute("flowline")]
        public static ReportingFacility Flowline
        {
            get 
            {
                return flowline;
            }
        }

        private readonly static ReportingFacility formation;
        /// <summary>
        /// A bed or deposit composed throughout of substantially the same kind of rock.
        /// </summary>
        [EnumValueNameAttribute("formation")]
        public static ReportingFacility Formation
        {
            get 
            {
                return formation;
            }
        }

        private readonly static ReportingFacility gasLiftValveMandrel;
        /// <summary>
        /// A gas-lift system component that is assembled with the production tubing string onto which or into which a gas-lift valve is fitted.
        /// </summary>
        [EnumValueNameAttribute("gas lift valve mandrel")]
        public static ReportingFacility GasLiftValveMandrel
        {
            get 
            {
                return gasLiftValveMandrel;
            }
        }

        private readonly static ReportingFacility generator;
        /// <summary>
        /// A single electrical generator.
        /// </summary>
        [EnumValueNameAttribute("generator")]
        public static ReportingFacility Generator
        {
            get 
            {
                return generator;
            }
        }

        private readonly static ReportingFacility installation;
        /// <summary>
        /// A physical object that is an appliance involved in the extraction, production, transportation or storage of oil or gas.
        /// </summary>
        [EnumValueNameAttribute("installation")]
        public static ReportingFacility Installation
        {
            get 
            {
                return installation;
            }
        }

        private readonly static ReportingFacility lease;
        /// <summary>
        /// A single lease.
        /// </summary>
        [EnumValueNameAttribute("lease")]
        public static ReportingFacility Lease
        {
            get 
            {
                return lease;
            }
        }

        private readonly static ReportingFacility license;
        /// <summary>
        /// A regulatory agreement that gives the licensees excluding rights to investigate, explore and recover petroleum deposits within the geographical area and time period stated in the agreement.
        /// </summary>
        [EnumValueNameAttribute("license")]
        public static ReportingFacility License
        {
            get 
            {
                return license;
            }
        }

        private readonly static ReportingFacility manifold;
        /// <summary>
        /// An accessory system of piping to a main piping system that serves to divide a flow into several parts, to combine several flows into one, or to reroute a flow to any one of several possible destinations.
        /// </summary>
        [EnumValueNameAttribute("manifold")]
        public static ReportingFacility Manifold
        {
            get 
            {
                return manifold;
            }
        }

        private readonly static ReportingFacility organizationalUnit;
        /// <summary>
        /// A logical unit of organization for production reporting.
        /// </summary>
        [EnumValueNameAttribute("organizational unit")]
        public static ReportingFacility OrganizationalUnit
        {
            get 
            {
                return organizationalUnit;
            }
        }

        private readonly static ReportingFacility packer;
        /// <summary>
        /// A device used to make a seal between the outside of the production tubing and the inside of the casing.
        /// </summary>
        [EnumValueNameAttribute("packer")]
        public static ReportingFacility Packer
        {
            get 
            {
                return packer;
            }
        }

        private readonly static ReportingFacility perforatedInterval;
        /// <summary>
        /// The section of wellbore that has been prepared for production by creating channels between the reservoir formation and the wellbore.
        /// </summary>
        [EnumValueNameAttribute("perforated interval")]
        public static ReportingFacility PerforatedInterval
        {
            get 
            {
                return perforatedInterval;
            }
        }

        private readonly static ReportingFacility pipeline;
        /// <summary>
        /// A fluid conductor that consists of pipe, possibly also including pumps, valves, and control devices, intended for conveying liquids, gases, or finely divided solids.
        /// </summary>
        [EnumValueNameAttribute("pipeline")]
        public static ReportingFacility Pipeline
        {
            get 
            {
                return pipeline;
            }
        }

        private readonly static ReportingFacility plantProcessing;
        /// <summary>
        /// A facility that processes natural gas to achieve the recovery of natural gas liquids.
        /// </summary>
        [EnumValueNameAttribute("plant - processing")]
        public static ReportingFacility PlantProcessing
        {
            get 
            {
                return plantProcessing;
            }
        }

        private readonly static ReportingFacility platform;
        /// <summary>
        /// A single platform.
        /// </summary>
        [EnumValueNameAttribute("platform")]
        public static ReportingFacility Platform
        {
            get 
            {
                return platform;
            }
        }

        private readonly static ReportingFacility pressureMeter;
        /// <summary>
        /// A single pressure meter. Note that this represents the device and not the sensor itself.
        /// </summary>
        [EnumValueNameAttribute("pressure meter")]
        public static ReportingFacility PressureMeter
        {
            get 
            {
                return pressureMeter;
            }
        }

        private readonly static ReportingFacility processingFacility;
        /// <summary>
        /// A single production processing facility.
        /// </summary>
        [EnumValueNameAttribute("processing facility")]
        public static ReportingFacility ProcessingFacility
        {
            get 
            {
                return processingFacility;
            }
        }

        private readonly static ReportingFacility productionTubing;
        /// <summary>
        /// A tube placed in a wellbore through which production fluids travel.
        /// </summary>
        [EnumValueNameAttribute("production tubing")]
        public static ReportingFacility ProductionTubing
        {
            get 
            {
                return productionTubing;
            }
        }

        private readonly static ReportingFacility pump;
        /// <summary>
        /// A single pump.
        /// </summary>
        [EnumValueNameAttribute("pump")]
        public static ReportingFacility Pump
        {
            get 
            {
                return pump;
            }
        }

        private readonly static ReportingFacility rectifier;
        /// <summary>
        /// An electrical device that converts alternating current (AC) to direct current (DC).
        /// </summary>
        [EnumValueNameAttribute("rectifier")]
        public static ReportingFacility Rectifier
        {
            get 
            {
                return rectifier;
            }
        }

        private readonly static ReportingFacility regulatingValve;
        /// <summary>
        /// A device used to regulate the rate of flow of a fluid.
        /// </summary>
        [EnumValueNameAttribute("regulating valve")]
        public static ReportingFacility RegulatingValve
        {
            get 
            {
                return regulatingValve;
            }
        }

        private readonly static ReportingFacility remoteTerminalUnit;
        /// <summary>
        /// A unit that transmits signals received from sensors to SCADA.
        /// </summary>
        [EnumValueNameAttribute("remote terminal unit")]
        public static ReportingFacility RemoteTerminalUnit
        {
            get 
            {
                return remoteTerminalUnit;
            }
        }

        private readonly static ReportingFacility reservoir;
        /// <summary>
        /// A single reservoir.
        /// </summary>
        [EnumValueNameAttribute("reservoir")]
        public static ReportingFacility Reservoir
        {
            get 
            {
                return reservoir;
            }
        }

        private readonly static ReportingFacility separator;
        /// <summary>
        /// A single separator.
        /// </summary>
        [EnumValueNameAttribute("separator")]
        public static ReportingFacility Separator
        {
            get 
            {
                return separator;
            }
        }

        private readonly static ReportingFacility sleeveValve;
        /// <summary>
        ///  A single sleeve valve. This is a type of tubing valve which has a sliding sleeve to cover holes in the tubing. You cover all of the holes in order to close the valve. For configurations oriented toward production, the inlet is on the casing side and the outlet is on the tubing side. For injection, the reverse would be true. 
        /// </summary>
        [EnumValueNameAttribute("sleeve valve")]
        public static ReportingFacility SleeveValve
        {
            get 
            {
                return sleeveValve;
            }
        }

        private readonly static ReportingFacility state;
        /// <summary>
        /// A single state or province.
        /// </summary>
        [EnumValueNameAttribute("state")]
        public static ReportingFacility State
        {
            get 
            {
                return state;
            }
        }

        private readonly static ReportingFacility storage;
        /// <summary>
        /// A system for the storage of gaseous, liquid and solid products.
        /// </summary>
        [EnumValueNameAttribute("storage")]
        public static ReportingFacility Storage
        {
            get 
            {
                return storage;
            }
        }

        private readonly static ReportingFacility tank;
        /// <summary>
        /// A single tank.
        /// </summary>
        [EnumValueNameAttribute("tank")]
        public static ReportingFacility Tank
        {
            get 
            {
                return tank;
            }
        }

        private readonly static ReportingFacility temperatureMeter;
        /// <summary>
        /// A single temperature meter. Note that this represents the device and not the sensor itself.
        /// </summary>
        [EnumValueNameAttribute("temperature meter")]
        public static ReportingFacility TemperatureMeter
        {
            get 
            {
                return temperatureMeter;
            }
        }

        private readonly static ReportingFacility template;
        /// <summary>
        /// A single template.
        /// </summary>
        [EnumValueNameAttribute("template")]
        public static ReportingFacility Template
        {
            get 
            {
                return template;
            }
        }

        private readonly static ReportingFacility terminal;
        /// <summary>
        /// A physical object that is an industrial facility for the storage of oil and/or petrochemical products and from which these products are usually transported to end users or further storage facilities.
        /// </summary>
        [EnumValueNameAttribute("terminal")]
        public static ReportingFacility Terminal
        {
            get 
            {
                return terminal;
            }
        }

        private readonly static ReportingFacility trap;
        /// <summary>
        /// An equipment, that has sensors installed, designed to trap sand that is associated with the well's produced/injected fluids.
        /// </summary>
        [EnumValueNameAttribute("trap")]
        public static ReportingFacility Trap
        {
            get 
            {
                return trap;
            }
        }

        private readonly static ReportingFacility trunkline;
        /// <summary>
        /// A single trunkline.
        /// </summary>
        [EnumValueNameAttribute("trunkline")]
        public static ReportingFacility Trunkline
        {
            get 
            {
                return trunkline;
            }
        }

        private readonly static ReportingFacility tubingHead;
        /// <summary>
        /// A single tubing head within a wellhead.
        /// </summary>
        [EnumValueNameAttribute("tubing head")]
        public static ReportingFacility TubingHead
        {
            get 
            {
                return tubingHead;
            }
        }

        private readonly static ReportingFacility turbine;
        /// <summary>
        /// A gas turbine used to generate power eg for electricaL power generation or pumping.
        /// </summary>
        [EnumValueNameAttribute("turbine")]
        public static ReportingFacility Turbine
        {
            get 
            {
                return turbine;
            }
        }

        private readonly static ReportingFacility wellGroup;
        /// <summary>
        /// A single named group of wells.
        /// </summary>
        [EnumValueNameAttribute("well group")]
        public static ReportingFacility WellGroup
        {
            get 
            {
                return wellGroup;
            }
        }

        private readonly static ReportingFacility well;
        /// <summary>
        /// A single well, possibly with many wellbores (sidetracks).
        /// </summary>
        [EnumValueNameAttribute("well")]
        public static ReportingFacility Well
        {
            get 
            {
                return well;
            }
        }

        private readonly static ReportingFacility wellbore;
        /// <summary>
        /// A single wellbore (sidetrack) within a well.
        /// </summary>
        [EnumValueNameAttribute("wellbore")]
        public static ReportingFacility Wellbore
        {
            get 
            {
                return wellbore;
            }
        }

        private readonly static ReportingFacility wellhead;
        /// <summary>
        /// A single wellhead for one well. See also "tubing head".
        /// </summary>
        [EnumValueNameAttribute("wellhead")]
        public static ReportingFacility Wellhead
        {
            get 
            {
                return wellhead;
            }
        }

        private readonly static ReportingFacility zone;
        /// <summary>
        /// A single zone.
        /// </summary>
        [EnumValueNameAttribute("zone")]
        public static ReportingFacility Zone
        {
            get 
            {
                return zone;
            }
        }

        private readonly static ReportingFacility unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingFacility Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReportingFacility()
        {
            blockValve = 
                new ReportingFacility("block valve")
                {
                    Description = "A single block valve."
            };
            bottomhole = 
                new ReportingFacility("bottomhole")
                {
                    Description = "A single bottomhole."
            };
            casing = 
                new ReportingFacility("casing")
                {
                    Description = "A production casing (steel pipe) used to seal and stabilize a wellbore."
                    ,Version = "1.2.2"
            };
            choke = 
                new ReportingFacility("choke")
                {
                    Description = "A single choke."
            };
            cluster = 
                new ReportingFacility("cluster")
                {
                    Description = "A single cluster."
            };
            commercialEntity = 
                new ReportingFacility("commercial entity")
                {
                    Description = "A commercial entity is an organizational construct through which the a group of organizations or facilities are grouped as if it were a single composite."
            };
            company = 
                new ReportingFacility("company")
                {
                    Description = "A company name that is the name of the operator company."
            };
            completion = 
                new ReportingFacility("completion")
                {
                    Description = "A single completion."
            };
            compressor = 
                new ReportingFacility("compressor")
                {
                    Description = "A single compressor."
            };
            controller = 
                new ReportingFacility("controller")
                {
                    Description = "A single lift gas controller."
            };
            controllerLift = 
                new ReportingFacility("controller -- lift")
                {
                    Description = "\"DEPRECATED: use \"\"controller\"\" instead.\""
                    ,Deprecated = "1.2.2"
                    ,ReplacedBy = Controller
            };
            country = 
                new ReportingFacility("country")
                {
                    Description = "A single country."
            };
            county = 
                new ReportingFacility("county")
                {
                    Description = "A single county."
            };
            downholeMonitoringSystem = 
                new ReportingFacility("downhole monitoring system")
                {
                    Description = "An equipment permanently fitted in the well's tubing that is equipped with pressure and temperature sensors."
                    ,Version = "1.2.2"
            };
            electricSubmersiblePump = 
                new ReportingFacility("electric submersible pump")
                {
                    Description = "An artificial-lift system that utilizes a downhole pumping system that is electrically driven."
                    ,Version = "1.2.2"
            };
            field = 
                new ReportingFacility("field")
                {
                    Description = "A single field."
            };
            fieldArea = 
                new ReportingFacility("field - area")
                {
                    Description = "A ground that is an area above an oilfield."
            };
            fieldGroup = 
                new ReportingFacility("field - group")
                {
                    Description = "An area concept that is a grouping of two or more selected petroleum fields for commercial reasons or other purposes."
            };
            fieldPart = 
                new ReportingFacility("field - part")
                {
                    Description = "An area concept that is an area that forms part of a petroleum field."
            };
            flowMeter = 
                new ReportingFacility("flow meter")
                {
                    Description = "A single flow meter."
            };
            flowline = 
                new ReportingFacility("flowline")
                {
                    Description = "A single flowline."
            };
            formation = 
                new ReportingFacility("formation")
                {
                    Description = "A bed or deposit composed throughout of substantially the same kind of rock."
            };
            gasLiftValveMandrel = 
                new ReportingFacility("gas lift valve mandrel")
                {
                    Description = "A gas-lift system component that is assembled with the production tubing string onto which or into which a gas-lift valve is fitted."
                    ,Version = "1.2.2"
            };
            generator = 
                new ReportingFacility("generator")
                {
                    Description = "A single electrical generator."
            };
            installation = 
                new ReportingFacility("installation")
                {
                    Description = "A physical object that is an appliance involved in the extraction, production, transportation or storage of oil or gas."
            };
            lease = 
                new ReportingFacility("lease")
                {
                    Description = "A single lease."
            };
            license = 
                new ReportingFacility("license")
                {
                    Description = "A regulatory agreement that gives the licensees excluding rights to investigate, explore and recover petroleum deposits within the geographical area and time period stated in the agreement."
            };
            manifold = 
                new ReportingFacility("manifold")
                {
                    Description = "An accessory system of piping to a main piping system that serves to divide a flow into several parts, to combine several flows into one, or to reroute a flow to any one of several possible destinations."
            };
            organizationalUnit = 
                new ReportingFacility("organizational unit")
                {
                    Description = "A logical unit of organization for production reporting."
                    ,Version = "1.2.2"
            };
            packer = 
                new ReportingFacility("packer")
                {
                    Description = "A device used to make a seal between the outside of the production tubing and the inside of the casing."
                    ,Version = "1.2.2"
            };
            perforatedInterval = 
                new ReportingFacility("perforated interval")
                {
                    Description = "The section of wellbore that has been prepared for production by creating channels between the reservoir formation and the wellbore."
                    ,Version = "1.2.2"
            };
            pipeline = 
                new ReportingFacility("pipeline")
                {
                    Description = "A fluid conductor that consists of pipe, possibly also including pumps, valves, and control devices, intended for conveying liquids, gases, or finely divided solids."
            };
            plantProcessing = 
                new ReportingFacility("plant - processing")
                {
                    Description = "A facility that processes natural gas to achieve the recovery of natural gas liquids."
            };
            platform = 
                new ReportingFacility("platform")
                {
                    Description = "A single platform."
            };
            pressureMeter = 
                new ReportingFacility("pressure meter")
                {
                    Description = "A single pressure meter. Note that this represents the device and not the sensor itself."
            };
            processingFacility = 
                new ReportingFacility("processing facility")
                {
                    Description = "A single production processing facility."
            };
            productionTubing = 
                new ReportingFacility("production tubing")
                {
                    Description = "A tube placed in a wellbore through which production fluids travel."
                    ,Version = "1.2.2"
            };
            pump = 
                new ReportingFacility("pump")
                {
                    Description = "A single pump."
            };
            rectifier = 
                new ReportingFacility("rectifier")
                {
                    Description = "An electrical device that converts alternating current (AC) to direct current (DC)."
                    ,Version = "1.2.2"
            };
            regulatingValve = 
                new ReportingFacility("regulating valve")
                {
                    Description = "A device used to regulate the rate of flow of a fluid."
            };
            remoteTerminalUnit = 
                new ReportingFacility("remote terminal unit")
                {
                    Description = "A unit that transmits signals received from sensors to SCADA."
                    ,Version = "1.2.2"
            };
            reservoir = 
                new ReportingFacility("reservoir")
                {
                    Description = "A single reservoir."
            };
            separator = 
                new ReportingFacility("separator")
                {
                    Description = "A single separator."
            };
            sleeveValve = 
                new ReportingFacility("sleeve valve")
                {
                    Description = " A single sleeve valve. This is a type of tubing valve which has a sliding sleeve to cover holes in the tubing. You cover all of the holes in order to close the valve. For configurations oriented toward production, the inlet is on the casing side and the outlet is on the tubing side. For injection, the reverse would be true. "
            };
            state = 
                new ReportingFacility("state")
                {
                    Description = "A single state or province."
            };
            storage = 
                new ReportingFacility("storage")
                {
                    Description = "A system for the storage of gaseous, liquid and solid products."
            };
            tank = 
                new ReportingFacility("tank")
                {
                    Description = "A single tank."
            };
            temperatureMeter = 
                new ReportingFacility("temperature meter")
                {
                    Description = "A single temperature meter. Note that this represents the device and not the sensor itself."
            };
            template = 
                new ReportingFacility("template")
                {
                    Description = "A single template."
            };
            terminal = 
                new ReportingFacility("terminal")
                {
                    Description = "A physical object that is an industrial facility for the storage of oil and/or petrochemical products and from which these products are usually transported to end users or further storage facilities."
            };
            trap = 
                new ReportingFacility("trap")
                {
                    Description = "An equipment, that has sensors installed, designed to trap sand that is associated with the well's produced/injected fluids."
                    ,Version = "1.2.2"
            };
            trunkline = 
                new ReportingFacility("trunkline")
                {
                    Description = "A single trunkline."
            };
            tubingHead = 
                new ReportingFacility("tubing head")
                {
                    Description = "A single tubing head within a wellhead."
            };
            turbine = 
                new ReportingFacility("turbine")
                {
                    Description = "A gas turbine used to generate power eg for electricaL power generation or pumping."
            };
            wellGroup = 
                new ReportingFacility("well group")
                {
                    Description = "A single named group of wells."
            };
            well = 
                new ReportingFacility("well")
                {
                    Description = "A single well, possibly with many wellbores (sidetracks)."
            };
            wellbore = 
                new ReportingFacility("wellbore")
                {
                    Description = "A single wellbore (sidetrack) within a well."
            };
            wellhead = 
                new ReportingFacility("wellhead")
                {
                    Description = "A single wellhead for one well. See also \"tubing head\"."
            };
            zone = 
                new ReportingFacility("zone")
                {
                    Description = "A single zone."
            };
            unknown = 
                new ReportingFacility("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReportingFacility by name
        /// </summary>
        /// <param name="name">The name of the ReportingFacility to return</param>
        /// <returns>The ReportingFacility represented by 'name'</returns>
        public static ReportingFacility GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReportingFacility)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReportingFacility)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReportingFacility)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ReportingFlow consume;
        /// <summary>
        /// Consumed (all methods) by the facility.
        /// </summary>
        [EnumValueNameAttribute("consume")]
        public static ReportingFlow Consume
        {
            get 
            {
                return consume;
            }
        }

        private readonly static ReportingFlow consumeBlackStart;
        /// <summary>
        ///  Consummed to restart power facilities as a result of an overall power outage. 
        /// </summary>
        [EnumValueNameAttribute("consume - black start")]
        public static ReportingFlow ConsumeBlackStart
        {
            get 
            {
                return consumeBlackStart;
            }
        }

        private readonly static ReportingFlow consumeCompressor;
        /// <summary>
        /// Consummed by compressors.
        /// </summary>
        [EnumValueNameAttribute("consume - compressor")]
        public static ReportingFlow ConsumeCompressor
        {
            get 
            {
                return consumeCompressor;
            }
        }

        private readonly static ReportingFlow consumeNonCompressor;
        /// <summary>
        /// Consumed by devices other than compressors.
        /// </summary>
        [EnumValueNameAttribute("consume - non compressor")]
        public static ReportingFlow ConsumeNonCompressor
        {
            get 
            {
                return consumeNonCompressor;
            }
        }

        private readonly static ReportingFlow consumeEmitted;
        /// <summary>
        /// Released into the atmosphere as a by-product of consumption.
        /// </summary>
        [EnumValueNameAttribute("consume - emitted")]
        public static ReportingFlow ConsumeEmitted
        {
            get 
            {
                return consumeEmitted;
            }
        }

        private readonly static ReportingFlow consumeFlare;
        /// <summary>
        /// Burned in a flare. A fluid stream that has one or more flares as the ultimate target.
        /// </summary>
        [EnumValueNameAttribute("consume - flare")]
        public static ReportingFlow ConsumeFlare
        {
            get 
            {
                return consumeFlare;
            }
        }

        private readonly static ReportingFlow consumeHpFlare;
        /// <summary>
        /// Burned in a high pressure flare.
        /// </summary>
        [EnumValueNameAttribute("consume - HP flare")]
        public static ReportingFlow ConsumeHpFlare
        {
            get 
            {
                return consumeHpFlare;
            }
        }

        private readonly static ReportingFlow consumeLpFlare;
        /// <summary>
        /// Burned in a low pressure flare.
        /// </summary>
        [EnumValueNameAttribute("consume - LP flare")]
        public static ReportingFlow ConsumeLpFlare
        {
            get 
            {
                return consumeLpFlare;
            }
        }

        private readonly static ReportingFlow consumeFuel;
        /// <summary>
        /// Consumed by processing equipment.
        /// </summary>
        [EnumValueNameAttribute("consume - fuel")]
        public static ReportingFlow ConsumeFuel
        {
            get 
            {
                return consumeFuel;
            }
        }

        private readonly static ReportingFlow consumeVenting;
        /// <summary>
        /// Released into the atmosphere.
        /// </summary>
        [EnumValueNameAttribute("consume - venting")]
        public static ReportingFlow ConsumeVenting
        {
            get 
            {
                return consumeVenting;
            }
        }

        private readonly static ReportingFlow disposal;
        /// <summary>
        /// A fluid stream that contains waste fluids for disposal.
        /// </summary>
        [EnumValueNameAttribute("disposal")]
        public static ReportingFlow Disposal
        {
            get 
            {
                return disposal;
            }
        }

        private readonly static ReportingFlow export;
        /// <summary>
        /// Leaving the installation for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("export")]
        public static ReportingFlow Export
        {
            get 
            {
                return export;
            }
        }

        private readonly static ReportingFlow exportRequested;
        /// <summary>
        /// Requested to leave the installation for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("export - requested")]
        public static ReportingFlow ExportRequested
        {
            get 
            {
                return exportRequested;
            }
        }

        private readonly static ReportingFlow exportNominated;
        /// <summary>
        /// Planned to leave the installation for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("export - nominated")]
        public static ReportingFlow ExportNominated
        {
            get 
            {
                return exportNominated;
            }
        }

        private readonly static ReportingFlow exportShortfall;
        /// <summary>
        /// Difference between what was requested and what was delivered.
        /// </summary>
        [EnumValueNameAttribute("export - shortfall")]
        public static ReportingFlow ExportShortfall
        {
            get 
            {
                return exportShortfall;
            }
        }

        private readonly static ReportingFlow gasLift;
        /// <summary>
        ///  Injected into a producing well to reduce the hydrostatic pressure of the fluid column. The resulting reduction in bottom hole pressure allows the reservoir liquids to flow. 
        /// </summary>
        [EnumValueNameAttribute("gas lift")]
        public static ReportingFlow GasLift
        {
            get 
            {
                return gasLift;
            }
        }

        private readonly static ReportingFlow hydrocarbonAccounting;
        /// <summary>
        ///  An accounting of all of the fluids into and out of Stock (i.e., Inventory) which includes all storage facilities at a site including fluid within a pipeline. 
        /// </summary>
        [EnumValueNameAttribute("hydrocarbon accounting")]
        public static ReportingFlow HydrocarbonAccounting
        {
            get 
            {
                return hydrocarbonAccounting;
            }
        }

        private readonly static ReportingFlow import;
        /// <summary>
        /// Entering the facility for commercialized purposes.
        /// </summary>
        [EnumValueNameAttribute("import")]
        public static ReportingFlow Import
        {
            get 
            {
                return import;
            }
        }

        private readonly static ReportingFlow injection;
        /// <summary>
        /// Inject into a well.
        /// </summary>
        [EnumValueNameAttribute("injection")]
        public static ReportingFlow Injection
        {
            get 
            {
                return injection;
            }
        }

        private readonly static ReportingFlow inventory;
        /// <summary>
        ///  Stock at a facility. For a period that represents an event, the amount would represent the current amount of inventory. For other periods, the amount would represent the addition (positive value) or drawdown (negative value) over that period. For an individual storage facility (e.g., a tank), the amounts would represent that tank. For an overall facility, the amounts would represent all tanks. 
        /// </summary>
        [EnumValueNameAttribute("inventory")]
        public static ReportingFlow Inventory
        {
            get 
            {
                return inventory;
            }
        }

        private readonly static ReportingFlow overboard;
        /// <summary>
        /// Dropped overboard into the sea.
        /// </summary>
        [EnumValueNameAttribute("overboard")]
        public static ReportingFlow Overboard
        {
            get 
            {
                return overboard;
            }
        }

        private readonly static ReportingFlow production;
        /// <summary>
        /// Exploited from a reservoir. This is independent of any disposition.
        /// </summary>
        [EnumValueNameAttribute("production")]
        public static ReportingFlow Production
        {
            get 
            {
                return production;
            }
        }

        private readonly static ReportingFlow sale;
        /// <summary>
        /// A fluid stream that is sold and transported to a buyer by pipeline.
        /// </summary>
        [EnumValueNameAttribute("sale")]
        public static ReportingFlow Sale
        {
            get 
            {
                return sale;
            }
        }

        private readonly static ReportingFlow storage;
        /// <summary>
        /// A fluid stream that is directed to one or more storage locations.
        /// </summary>
        [EnumValueNameAttribute("storage")]
        public static ReportingFlow Storage
        {
            get 
            {
                return storage;
            }
        }

        private readonly static ReportingFlow unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingFlow Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReportingFlow()
        {
            consume = 
                new ReportingFlow("consume")
                {
                    Description = "Consumed (all methods) by the facility."
            };
            consumeBlackStart = 
                new ReportingFlow("consume - black start")
                {
                    Description = " Consummed to restart power facilities as a result of an overall power outage. "
            };
            consumeCompressor = 
                new ReportingFlow("consume - compressor")
                {
                    Description = "Consummed by compressors."
            };
            consumeNonCompressor = 
                new ReportingFlow("consume - non compressor")
                {
                    Description = "Consumed by devices other than compressors."
            };
            consumeEmitted = 
                new ReportingFlow("consume - emitted")
                {
                    Description = "Released into the atmosphere as a by-product of consumption."
            };
            consumeFlare = 
                new ReportingFlow("consume - flare")
                {
                    Description = "Burned in a flare. A fluid stream that has one or more flares as the ultimate target."
            };
            consumeHpFlare = 
                new ReportingFlow("consume - HP flare")
                {
                    Description = "Burned in a high pressure flare."
            };
            consumeLpFlare = 
                new ReportingFlow("consume - LP flare")
                {
                    Description = "Burned in a low pressure flare."
            };
            consumeFuel = 
                new ReportingFlow("consume - fuel")
                {
                    Description = "Consumed by processing equipment."
            };
            consumeVenting = 
                new ReportingFlow("consume - venting")
                {
                    Description = "Released into the atmosphere."
            };
            disposal = 
                new ReportingFlow("disposal")
                {
                    Description = "A fluid stream that contains waste fluids for disposal."
            };
            export = 
                new ReportingFlow("export")
                {
                    Description = "Leaving the installation for commercialized purposes."
            };
            exportRequested = 
                new ReportingFlow("export - requested")
                {
                    Description = "Requested to leave the installation for commercialized purposes."
            };
            exportNominated = 
                new ReportingFlow("export - nominated")
                {
                    Description = "Planned to leave the installation for commercialized purposes."
            };
            exportShortfall = 
                new ReportingFlow("export - shortfall")
                {
                    Description = "Difference between what was requested and what was delivered."
            };
            gasLift = 
                new ReportingFlow("gas lift")
                {
                    Description = " Injected into a producing well to reduce the hydrostatic pressure of the fluid column. The resulting reduction in bottom hole pressure allows the reservoir liquids to flow. "
            };
            hydrocarbonAccounting = 
                new ReportingFlow("hydrocarbon accounting")
                {
                    Description = " An accounting of all of the fluids into and out of Stock (i.e., Inventory) which includes all storage facilities at a site including fluid within a pipeline. "
            };
            import = 
                new ReportingFlow("import")
                {
                    Description = "Entering the facility for commercialized purposes."
            };
            injection = 
                new ReportingFlow("injection")
                {
                    Description = "Inject into a well."
            };
            inventory = 
                new ReportingFlow("inventory")
                {
                    Description = " Stock at a facility. For a period that represents an event, the amount would represent the current amount of inventory. For other periods, the amount would represent the addition (positive value) or drawdown (negative value) over that period. For an individual storage facility (e.g., a tank), the amounts would represent that tank. For an overall facility, the amounts would represent all tanks. "
            };
            overboard = 
                new ReportingFlow("overboard")
                {
                    Description = "Dropped overboard into the sea."
            };
            production = 
                new ReportingFlow("production")
                {
                    Description = "Exploited from a reservoir. This is independent of any disposition."
            };
            sale = 
                new ReportingFlow("sale")
                {
                    Description = "A fluid stream that is sold and transported to a buyer by pipeline."
            };
            storage = 
                new ReportingFlow("storage")
                {
                    Description = "A fluid stream that is directed to one or more storage locations."
            };
            unknown = 
                new ReportingFlow("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReportingFlow by name
        /// </summary>
        /// <param name="name">The name of the ReportingFlow to return</param>
        /// <returns>The ReportingFlow represented by 'name'</returns>
        public static ReportingFlow GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReportingFlow)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReportingFlow)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReportingFlow)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///				A period of one day.
    ///				If the report does not represent one day then this represents the
    ///				24 hour period ending at the end of the report period.
    ///			
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

        private readonly static ReportingPeriod day;
        /// <summary>
        ///  A period of one day. If the report does not represent one day then this represents the 24 hour period ending at the end of the report period. 
        /// </summary>
        [EnumValueNameAttribute("day")]
        public static ReportingPeriod Day
        {
            get 
            {
                return day;
            }
        }

        private readonly static ReportingPeriod week;
        /// <summary>
        ///  A period of one week. If the report does not represent one week then this represents the 7 times 24 hour period ending at the end of the report period. 
        /// </summary>
        [EnumValueNameAttribute("week")]
        public static ReportingPeriod Week
        {
            get 
            {
                return week;
            }
        }

        private readonly static ReportingPeriod month;
        /// <summary>
        /// A period of one calendar month.
        /// </summary>
        [EnumValueNameAttribute("month")]
        public static ReportingPeriod Month
        {
            get 
            {
                return month;
            }
        }

        private readonly static ReportingPeriod year;
        /// <summary>
        /// A period of one Gregorian year.
        /// </summary>
        [EnumValueNameAttribute("year")]
        public static ReportingPeriod Year
        {
            get 
            {
                return year;
            }
        }

        private readonly static ReportingPeriod yearToDate;
        /// <summary>
        /// A period from the beginning of the year to the end of the report period.
        /// </summary>
        [EnumValueNameAttribute("year to date")]
        public static ReportingPeriod YearToDate
        {
            get 
            {
                return yearToDate;
            }
        }

        private readonly static ReportingPeriod monthToDate;
        /// <summary>
        ///  A period from the beginning of the calendar month to the end of the report period. 
        /// </summary>
        [EnumValueNameAttribute("month to date")]
        public static ReportingPeriod MonthToDate
        {
            get 
            {
                return monthToDate;
            }
        }

        private readonly static ReportingPeriod dailyYearToDate;
        /// <summary>
        ///  The average per day over the period from the beginning of the year to the end of the report period 
        /// </summary>
        [EnumValueNameAttribute("daily year to date")]
        public static ReportingPeriod DailyYearToDate
        {
            get 
            {
                return dailyYearToDate;
            }
        }

        private readonly static ReportingPeriod dailyMonthToDate;
        /// <summary>
        ///  The average per day over the period from the beginning of the month to the end of the report period 
        /// </summary>
        [EnumValueNameAttribute("daily month to date")]
        public static ReportingPeriod DailyMonthToDate
        {
            get 
            {
                return dailyMonthToDate;
            }
        }

        private readonly static ReportingPeriod totalCumulative;
        /// <summary>
        ///  A period with no beginning that ends at the end of the report period. 
        /// </summary>
        [EnumValueNameAttribute("total cumulative")]
        public static ReportingPeriod TotalCumulative
        {
            get 
            {
                return totalCumulative;
            }
        }

        private readonly static ReportingPeriod report;
        /// <summary>
        /// A period coinciding with the report period.
        /// </summary>
        [EnumValueNameAttribute("report")]
        public static ReportingPeriod Report
        {
            get 
            {
                return report;
            }
        }

        private readonly static ReportingPeriod reportStart;
        /// <summary>
        /// A point in time coinciding with the start of report period.
        /// </summary>
        [EnumValueNameAttribute("report start")]
        public static ReportingPeriod ReportStart
        {
            get 
            {
                return reportStart;
            }
        }

        private readonly static ReportingPeriod reportEnd;
        /// <summary>
        /// A point in time coinciding with the end of report period.
        /// </summary>
        [EnumValueNameAttribute("report end")]
        public static ReportingPeriod ReportEnd
        {
            get 
            {
                return reportEnd;
            }
        }

        private readonly static ReportingPeriod previousPeriod;
        /// <summary>
        ///  The previous reporting period. For example, if the report period represents a day then the previous period represents the previous day. 
        /// </summary>
        [EnumValueNameAttribute("previous period")]
        public static ReportingPeriod PreviousPeriod
        {
            get 
            {
                return previousPeriod;
            }
        }

        private readonly static ReportingPeriod midnight;
        /// <summary>
        ///  A point in time coinciding with midnight during the report period. This can be ambiguous if the report begins and ends at midnight - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours. 
        /// </summary>
        [EnumValueNameAttribute("midnight")]
        public static ReportingPeriod Midnight
        {
            get 
            {
                return midnight;
            }
        }

        private readonly static ReportingPeriod noon;
        /// <summary>
        ///  A point in time coinciding with noon during the report period. This can be ambiguous if the report begins and ends at noon - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours. 
        /// </summary>
        [EnumValueNameAttribute("noon")]
        public static ReportingPeriod Noon
        {
            get 
            {
                return noon;
            }
        }

        private readonly static ReportingPeriod zeroSixZeroZero;
        /// <summary>
        ///  A point in time coinciding with 6 am during the report period. This can be ambiguous if the report begins and ends at 6 am - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours. 
        /// </summary>
        [EnumValueNameAttribute("06:00")]
        public static ReportingPeriod ZeroSixZeroZero
        {
            get 
            {
                return zeroSixZeroZero;
            }
        }

        private readonly static ReportingPeriod gasDay;
        /// <summary>
        /// A period in time that is all space of time within a day (24 hour period) starting at 06:00 AM and ending 06:00 AM next day.
        /// </summary>
        [EnumValueNameAttribute("gas day")]
        public static ReportingPeriod GasDay
        {
            get 
            {
                return gasDay;
            }
        }

        private readonly static ReportingPeriod gasMonth;
        /// <summary>
        /// A period in time that is all space of time within a whole given month starting at 06:00 AM the first day and ending at 06:00 AM the first day of next month.
        /// </summary>
        [EnumValueNameAttribute("gas month")]
        public static ReportingPeriod GasMonth
        {
            get 
            {
                return gasMonth;
            }
        }

        private readonly static ReportingPeriod gasYear;
        /// <summary>
        /// A period in time that is all time within a period starting at 06:00 AM October 1st and ending at same date and time the following year.
        /// </summary>
        [EnumValueNameAttribute("gas year")]
        public static ReportingPeriod GasYear
        {
            get 
            {
                return gasYear;
            }
        }

        private readonly static ReportingPeriod gasYearToDate;
        /// <summary>
        /// A period in time that is all space of time within a period starting at 06:00 AM October 1st ending at 06:00 AM at a given date.
        /// </summary>
        [EnumValueNameAttribute("gas year to date")]
        public static ReportingPeriod GasYearToDate
        {
            get 
            {
                return gasYearToDate;
            }
        }

        private readonly static ReportingPeriod lifeToDate;
        /// <summary>
        /// A period in time that is all space of time within a period from starting up an equipment, installation, field, license, etc, to a given date.
        /// </summary>
        [EnumValueNameAttribute("life to date")]
        public static ReportingPeriod LifeToDate
        {
            get 
            {
                return lifeToDate;
            }
        }

        private readonly static ReportingPeriod unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingPeriod Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReportingPeriod()
        {
            day = 
                new ReportingPeriod("day")
                {
                    Description = " A period of one day. If the report does not represent one day then this represents the 24 hour period ending at the end of the report period. "
            };
            week = 
                new ReportingPeriod("week")
                {
                    Description = " A period of one week. If the report does not represent one week then this represents the 7 times 24 hour period ending at the end of the report period. "
            };
            month = 
                new ReportingPeriod("month")
                {
                    Description = "A period of one calendar month."
            };
            year = 
                new ReportingPeriod("year")
                {
                    Description = "A period of one Gregorian year."
            };
            yearToDate = 
                new ReportingPeriod("year to date")
                {
                    Description = "A period from the beginning of the year to the end of the report period."
            };
            monthToDate = 
                new ReportingPeriod("month to date")
                {
                    Description = " A period from the beginning of the calendar month to the end of the report period. "
            };
            dailyYearToDate = 
                new ReportingPeriod("daily year to date")
                {
                    Description = " The average per day over the period from the beginning of the year to the end of the report period "
            };
            dailyMonthToDate = 
                new ReportingPeriod("daily month to date")
                {
                    Description = " The average per day over the period from the beginning of the month to the end of the report period "
            };
            totalCumulative = 
                new ReportingPeriod("total cumulative")
                {
                    Description = " A period with no beginning that ends at the end of the report period. "
            };
            report = 
                new ReportingPeriod("report")
                {
                    Description = "A period coinciding with the report period."
            };
            reportStart = 
                new ReportingPeriod("report start")
                {
                    Description = "A point in time coinciding with the start of report period."
            };
            reportEnd = 
                new ReportingPeriod("report end")
                {
                    Description = "A point in time coinciding with the end of report period."
            };
            previousPeriod = 
                new ReportingPeriod("previous period")
                {
                    Description = " The previous reporting period. For example, if the report period represents a day then the previous period represents the previous day. "
            };
            midnight = 
                new ReportingPeriod("midnight")
                {
                    Description = " A point in time coinciding with midnight during the report period. This can be ambiguous if the report begins and ends at midnight - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours. "
            };
            noon = 
                new ReportingPeriod("noon")
                {
                    Description = " A point in time coinciding with noon during the report period. This can be ambiguous if the report begins and ends at noon - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours. "
            };
            zeroSixZeroZero = 
                new ReportingPeriod("06:00")
                {
                    Description = " A point in time coinciding with 6 am during the report period. This can be ambiguous if the report begins and ends at 6 am - use report start/end instead. This cannot be used for a reporting period that is greater than 24 hours. "
            };
            gasDay = 
                new ReportingPeriod("gas day")
                {
                    Description = "A period in time that is all space of time within a day (24 hour period) starting at 06:00 AM and ending 06:00 AM next day."
            };
            gasMonth = 
                new ReportingPeriod("gas month")
                {
                    Description = "A period in time that is all space of time within a whole given month starting at 06:00 AM the first day and ending at 06:00 AM the first day of next month."
            };
            gasYear = 
                new ReportingPeriod("gas year")
                {
                    Description = "A period in time that is all time within a period starting at 06:00 AM October 1st and ending at same date and time the following year."
            };
            gasYearToDate = 
                new ReportingPeriod("gas year to date")
                {
                    Description = "A period in time that is all space of time within a period starting at 06:00 AM October 1st ending at 06:00 AM at a given date."
            };
            lifeToDate = 
                new ReportingPeriod("life to date")
                {
                    Description = "A period in time that is all space of time within a period from starting up an equipment, installation, field, license, etc, to a given date."
            };
            unknown = 
                new ReportingPeriod("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReportingPeriod by name
        /// </summary>
        /// <param name="name">The name of the ReportingPeriod to return</param>
        /// <returns>The ReportingPeriod represented by 'name'</returns>
        public static ReportingPeriod GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReportingPeriod)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReportingPeriod)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReportingPeriod)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///				A product composed of the component with the specified number of carbon
    ///				atoms plus all heavier components.
    ///			
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

        private readonly static ReportingProduct cTwoPlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C2+")]
        public static ReportingProduct CTwoPlus
        {
            get 
            {
                return cTwoPlus;
            }
        }

        private readonly static ReportingProduct cThreePlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C3+")]
        public static ReportingProduct CThreePlus
        {
            get 
            {
                return cThreePlus;
            }
        }

        private readonly static ReportingProduct cFourPlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C4+")]
        public static ReportingProduct CFourPlus
        {
            get 
            {
                return cFourPlus;
            }
        }

        private readonly static ReportingProduct cFivePlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C5+")]
        public static ReportingProduct CFivePlus
        {
            get 
            {
                return cFivePlus;
            }
        }

        private readonly static ReportingProduct cSixPlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C6+")]
        public static ReportingProduct CSixPlus
        {
            get 
            {
                return cSixPlus;
            }
        }

        private readonly static ReportingProduct cSevenPlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C7+")]
        public static ReportingProduct CSevenPlus
        {
            get 
            {
                return cSevenPlus;
            }
        }

        private readonly static ReportingProduct cEightPlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C8+")]
        public static ReportingProduct CEightPlus
        {
            get 
            {
                return cEightPlus;
            }
        }

        private readonly static ReportingProduct cNinePlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C9+")]
        public static ReportingProduct CNinePlus
        {
            get 
            {
                return cNinePlus;
            }
        }

        private readonly static ReportingProduct cOneZeroPlus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all heavier components. 
        /// </summary>
        [EnumValueNameAttribute("C10+")]
        public static ReportingProduct COneZeroPlus
        {
            get 
            {
                return cOneZeroPlus;
            }
        }

        private readonly static ReportingProduct cTwoMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C2-")]
        public static ReportingProduct CTwoMinus
        {
            get 
            {
                return cTwoMinus;
            }
        }

        private readonly static ReportingProduct cThreeMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C3-")]
        public static ReportingProduct CThreeMinus
        {
            get 
            {
                return cThreeMinus;
            }
        }

        private readonly static ReportingProduct cFourMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C4-")]
        public static ReportingProduct CFourMinus
        {
            get 
            {
                return cFourMinus;
            }
        }

        private readonly static ReportingProduct cFiveMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C5-")]
        public static ReportingProduct CFiveMinus
        {
            get 
            {
                return cFiveMinus;
            }
        }

        private readonly static ReportingProduct cSixMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C6-")]
        public static ReportingProduct CSixMinus
        {
            get 
            {
                return cSixMinus;
            }
        }

        private readonly static ReportingProduct cSevenMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C7-")]
        public static ReportingProduct CSevenMinus
        {
            get 
            {
                return cSevenMinus;
            }
        }

        private readonly static ReportingProduct cEightMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C8-")]
        public static ReportingProduct CEightMinus
        {
            get 
            {
                return cEightMinus;
            }
        }

        private readonly static ReportingProduct cNineMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C9-")]
        public static ReportingProduct CNineMinus
        {
            get 
            {
                return cNineMinus;
            }
        }

        private readonly static ReportingProduct cOneZeroMinus;
        /// <summary>
        ///  A product composed of the component with the specified number of carbon atoms plus all lighter components. 
        /// </summary>
        [EnumValueNameAttribute("C10-")]
        public static ReportingProduct COneZeroMinus
        {
            get 
            {
                return cOneZeroMinus;
            }
        }

        private readonly static ReportingProduct oleic;
        /// <summary>
        ///  An undifferentiated liquid fluid phase in which the dominant continuous materials are liquid hydrocarbons. This phase is often called the "oil phase". 
        /// </summary>
        [EnumValueNameAttribute("oleic")]
        public static ReportingProduct Oleic
        {
            get 
            {
                return oleic;
            }
        }

        private readonly static ReportingProduct aqueous;
        /// <summary>
        ///  An undifferentiated liquid fluid phase in which the dominant continuous material is liquid water. This phase is often called the "water phase". 
        /// </summary>
        [EnumValueNameAttribute("aqueous")]
        public static ReportingProduct Aqueous
        {
            get 
            {
                return aqueous;
            }
        }

        private readonly static ReportingProduct vapor;
        /// <summary>
        ///  An undifferentiated fluid phase that is distinctly gaseous. This phase is often called the "gas phase". 
        /// </summary>
        [EnumValueNameAttribute("vapor")]
        public static ReportingProduct Vapor
        {
            get 
            {
                return vapor;
            }
        }

        private readonly static ReportingProduct liquid;
        /// <summary>
        ///  An undifferentiated fluid phase that is distinctly liquid. This includes water. 
        /// </summary>
        [EnumValueNameAttribute("liquid")]
        public static ReportingProduct Liquid
        {
            get 
            {
                return liquid;
            }
        }

        private readonly static ReportingProduct cSeven;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with seven carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C7")]
        public static ReportingProduct CSeven
        {
            get 
            {
                return cSeven;
            }
        }

        private readonly static ReportingProduct cEight;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with eight carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C8")]
        public static ReportingProduct CEight
        {
            get 
            {
                return cEight;
            }
        }

        private readonly static ReportingProduct cNine;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with nine carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C9")]
        public static ReportingProduct CNine
        {
            get 
            {
                return cNine;
            }
        }

        private readonly static ReportingProduct cOneZero;
        /// <summary>
        /// A hydrocarbon compound that consists of mainly hydrocarbon molecules with ten carbon atoms.
        /// </summary>
        [EnumValueNameAttribute("C10")]
        public static ReportingProduct COneZero
        {
            get 
            {
                return cOneZero;
            }
        }

        private readonly static ReportingProduct carbonMonoxideGas;
        /// <summary>
        /// Carbon monoxide in a gaseous state.
        /// </summary>
        [EnumValueNameAttribute("carbon monoxide gas")]
        public static ReportingProduct CarbonMonoxideGas
        {
            get 
            {
                return carbonMonoxideGas;
            }
        }

        private readonly static ReportingProduct carbonDioxideGas;
        /// <summary>
        /// Carbon dioxide in a gaseous state.
        /// </summary>
        [EnumValueNameAttribute("carbon dioxide gas")]
        public static ReportingProduct CarbonDioxideGas
        {
            get 
            {
                return carbonDioxideGas;
            }
        }

        private readonly static ReportingProduct chemical;
        /// <summary>
        /// A chemical of some type.
        /// </summary>
        [EnumValueNameAttribute("chemical")]
        public static ReportingProduct Chemical
        {
            get 
            {
                return chemical;
            }
        }

        private readonly static ReportingProduct condensate;
        /// <summary>
        /// Mixture of light and heavier hydrocarbons in a liquid state.
        /// </summary>
        [EnumValueNameAttribute("condensate")]
        public static ReportingProduct Condensate
        {
            get 
            {
                return condensate;
            }
        }

        private readonly static ReportingProduct condensateGross;
        /// <summary>
        /// Light hydrocarbon fractions produced with natural gas, which condense into liquid at normal temperatures and pressures associated with surface production equipment. 
        /// </summary>
        [EnumValueNameAttribute("condensate - gross")]
        public static ReportingProduct CondensateGross
        {
            get 
            {
                return condensateGross;
            }
        }

        private readonly static ReportingProduct condensateNet;
        /// <summary>
        /// Hydrocatbon condensate containing only the heavier carbon fractions C5 to C10+.
        /// </summary>
        [EnumValueNameAttribute("condensate - net")]
        public static ReportingProduct CondensateNet
        {
            get 
            {
                return condensateNet;
            }
        }

        private readonly static ReportingProduct crudeStabilized;
        /// <summary>
        /// A crude oil that has been stabilized by separating out dissolved gas.
        /// </summary>
        [EnumValueNameAttribute("crude - stabilized")]
        public static ReportingProduct CrudeStabilized
        {
            get 
            {
                return crudeStabilized;
            }
        }

        private readonly static ReportingProduct cuttings;
        /// <summary>
        /// Drill cuttings.
        /// </summary>
        [EnumValueNameAttribute("cuttings")]
        public static ReportingProduct Cuttings
        {
            get 
            {
                return cuttings;
            }
        }

        private readonly static ReportingProduct diethyleneGlycol;
        /// <summary>
        /// A compound where the main component is diethylene glycol.
        /// </summary>
        [EnumValueNameAttribute("diethylene glycol")]
        public static ReportingProduct DiethyleneGlycol
        {
            get 
            {
                return diethyleneGlycol;
            }
        }

        private readonly static ReportingProduct diesel;
        /// <summary>
        /// Diesel fuel.
        /// </summary>
        [EnumValueNameAttribute("diesel")]
        public static ReportingProduct Diesel
        {
            get 
            {
                return diesel;
            }
        }

        private readonly static ReportingProduct dioxygen;
        /// <summary>
        /// Oxygen
        /// </summary>
        [EnumValueNameAttribute("dioxygen")]
        public static ReportingProduct Dioxygen
        {
            get 
            {
                return dioxygen;
            }
        }

        private readonly static ReportingProduct electricPower;
        /// <summary>
        /// Electrical power.
        /// </summary>
        [EnumValueNameAttribute("electric power")]
        public static ReportingProduct ElectricPower
        {
            get 
            {
                return electricPower;
            }
        }

        private readonly static ReportingProduct ethane;
        /// <summary>
        /// A compound where the main component is ethane.
        /// </summary>
        [EnumValueNameAttribute("ethane")]
        public static ReportingProduct Ethane
        {
            get 
            {
                return ethane;
            }
        }

        private readonly static ReportingProduct ethaneComponent;
        /// <summary>
        /// Ethane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("ethane - component")]
        public static ReportingProduct EthaneComponent
        {
            get 
            {
                return ethaneComponent;
            }
        }

        private readonly static ReportingProduct gas;
        /// <summary>
        /// Gas mixture of hydrocarbons.
        /// </summary>
        [EnumValueNameAttribute("gas")]
        public static ReportingProduct Gas
        {
            get 
            {
                return gas;
            }
        }

        private readonly static ReportingProduct gasDry;
        /// <summary>
        /// A natural gas that occurs in the absence of condensate or liquid hydrocarbons, or gas that has had condensible hydrocarbons removed, mainly consisting of methane gas.
        /// </summary>
        [EnumValueNameAttribute("gas - dry")]
        public static ReportingProduct GasDry
        {
            get 
            {
                return gasDry;
            }
        }

        private readonly static ReportingProduct gasRich;
        /// <summary>
        /// Gas mixture of light and heavier hydrocarbons than a lean gas.
        /// </summary>
        [EnumValueNameAttribute("gas - rich")]
        public static ReportingProduct GasRich
        {
            get 
            {
                return gasRich;
            }
        }

        private readonly static ReportingProduct gasWet;
        /// <summary>
        /// A natural gas that contains less methane (typically less than 85% methane) and more ethane and other more complex hydrocarbons like propane, butane and naphtha.
        /// </summary>
        [EnumValueNameAttribute("gas - wet")]
        public static ReportingProduct GasWet
        {
            get 
            {
                return gasWet;
            }
        }

        private readonly static ReportingProduct gasComponentInOil;
        /// <summary>
        /// Gas as a component in oil.
        /// </summary>
        [EnumValueNameAttribute("gas - component in oil")]
        public static ReportingProduct GasComponentInOil
        {
            get 
            {
                return gasComponentInOil;
            }
        }

        private readonly static ReportingProduct heliumGas;
        /// <summary>
        /// Helium
        /// </summary>
        [EnumValueNameAttribute("helium gas")]
        public static ReportingProduct HeliumGas
        {
            get 
            {
                return heliumGas;
            }
        }

        private readonly static ReportingProduct heptane;
        /// <summary>
        /// A compound where the main component is heptane.
        /// </summary>
        [EnumValueNameAttribute("heptane")]
        public static ReportingProduct Heptane
        {
            get 
            {
                return heptane;
            }
        }

        private readonly static ReportingProduct hydraulicControlFluid;
        /// <summary>
        /// hydraulic control fluid as used to actuate remote devices
        /// </summary>
        [EnumValueNameAttribute("hydraulic control fluid")]
        public static ReportingProduct HydraulicControlFluid
        {
            get 
            {
                return hydraulicControlFluid;
            }
        }

        private readonly static ReportingProduct hydrogenGas;
        /// <summary>
        /// Hydrogen
        /// </summary>
        [EnumValueNameAttribute("hydrogen gas")]
        public static ReportingProduct HydrogenGas
        {
            get 
            {
                return hydrogenGas;
            }
        }

        private readonly static ReportingProduct hydrogenSulfide;
        /// <summary>
        /// A compound where the main component is hydrogen sulfide.
        /// </summary>
        [EnumValueNameAttribute("hydrogen sulfide")]
        public static ReportingProduct HydrogenSulfide
        {
            get 
            {
                return hydrogenSulfide;
            }
        }

        private readonly static ReportingProduct ibutaneComponent;
        /// <summary>
        /// I-butane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("i-butane - component")]
        public static ReportingProduct IbutaneComponent
        {
            get 
            {
                return ibutaneComponent;
            }
        }

        private readonly static ReportingProduct isobutane;
        /// <summary>
        /// A compound where the main component is isobutane.
        /// </summary>
        [EnumValueNameAttribute("isobutane")]
        public static ReportingProduct Isobutane
        {
            get 
            {
                return isobutane;
            }
        }

        private readonly static ReportingProduct isopentane;
        /// <summary>
        /// A compound where the main component is isopentane.
        /// </summary>
        [EnumValueNameAttribute("isopentane")]
        public static ReportingProduct Isopentane
        {
            get 
            {
                return isopentane;
            }
        }

        private readonly static ReportingProduct liquefiedNaturalGas;
        /// <summary>
        ///  A liquid compound that is natural gas compressed and supercooled to -167 deg C (-269 deg F) into a liquid to reduce its volume to 1/635th for storage and transportation. Liquefied natural gas has a calorific value of 22,300 Btu/lb. It consists of about 91% of methane and 7% ethane with some propane, butane, and higher hydrocarbons. One tonne liquefied natural gas is equal to about 53 Mcf of gas. Liquified natural gas can be vaporized by ambient air, another fluid, or direct fired vaporizer. 
        /// </summary>
        [EnumValueNameAttribute("liquefied natural gas")]
        public static ReportingProduct LiquefiedNaturalGas
        {
            get 
            {
                return liquefiedNaturalGas;
            }
        }

        private readonly static ReportingProduct liquefiedPetroleumGas;
        /// <summary>
        /// A liquid compound that is predominantly butane and propane separated from natural gasoline or natural gas and sold as fuel - commonly known as bottled gas, tank gas or LP-gas.
        /// </summary>
        [EnumValueNameAttribute("liquefied petroleum gas")]
        public static ReportingProduct LiquefiedPetroleumGas
        {
            get 
            {
                return liquefiedPetroleumGas;
            }
        }

        private readonly static ReportingProduct methane;
        /// <summary>
        /// A compound where the main component is methane.
        /// </summary>
        [EnumValueNameAttribute("methane")]
        public static ReportingProduct Methane
        {
            get 
            {
                return methane;
            }
        }

        private readonly static ReportingProduct methaneComponent;
        /// <summary>
        /// xxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("methane - component")]
        public static ReportingProduct MethaneComponent
        {
            get 
            {
                return methaneComponent;
            }
        }

        private readonly static ReportingProduct methanol;
        /// <summary>
        /// A compound where the main component is methanol.
        /// </summary>
        [EnumValueNameAttribute("methanol")]
        public static ReportingProduct Methanol
        {
            get 
            {
                return methanol;
            }
        }

        private readonly static ReportingProduct mixedButane;
        /// <summary>
        /// A compound where the main components are butane and isobutane.
        /// </summary>
        [EnumValueNameAttribute("mixed butane")]
        public static ReportingProduct MixedButane
        {
            get 
            {
                return mixedButane;
            }
        }

        private readonly static ReportingProduct monoethyleneGlycol;
        /// <summary>
        /// A compound where the main component is monoethylene glycol.
        /// </summary>
        [EnumValueNameAttribute("monoethylene glycol")]
        public static ReportingProduct MonoethyleneGlycol
        {
            get 
            {
                return monoethyleneGlycol;
            }
        }

        private readonly static ReportingProduct nbutaneComponent;
        /// <summary>
        /// N-butane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("n-butane - component")]
        public static ReportingProduct NbutaneComponent
        {
            get 
            {
                return nbutaneComponent;
            }
        }

        private readonly static ReportingProduct naphta;
        /// <summary>
        /// An aggregate that is a volatile and inflammable product of crude oil refining with a boiling range 140 - 210 deg. Celsius consisting of C5+ to C10 components (pentanes and hexanes).
        /// </summary>
        [EnumValueNameAttribute("naphta")]
        public static ReportingProduct Naphta
        {
            get 
            {
                return naphta;
            }
        }

        private readonly static ReportingProduct naturalGasLiquid;
        /// <summary>
        ///  Mixture of ethane, propane and butane with small quantities of heaver hydrocarbons. Partially liquid at atmospheric pressure. 
        /// </summary>
        [EnumValueNameAttribute("natural gas liquid")]
        public static ReportingProduct NaturalGasLiquid
        {
            get 
            {
                return naturalGasLiquid;
            }
        }

        private readonly static ReportingProduct neopentane;
        /// <summary>
        /// A compound where the main component is neopentane.
        /// </summary>
        [EnumValueNameAttribute("neopentane")]
        public static ReportingProduct Neopentane
        {
            get 
            {
                return neopentane;
            }
        }

        private readonly static ReportingProduct nitrogenGas;
        /// <summary>
        /// A gasous compound where the main component is nitrogen.
        /// </summary>
        [EnumValueNameAttribute("nitrogen gas")]
        public static ReportingProduct NitrogenGas
        {
            get 
            {
                return nitrogenGas;
            }
        }

        private readonly static ReportingProduct nitrogenOxideGas;
        /// <summary>
        /// Nitrogen oxides in a gaseous state
        /// </summary>
        [EnumValueNameAttribute("nitrogen oxide gas")]
        public static ReportingProduct NitrogenOxideGas
        {
            get 
            {
                return nitrogenOxideGas;
            }
        }

        private readonly static ReportingProduct nglComponentInGas;
        /// <summary>
        /// Natural gas liquid as a component in gas.
        /// </summary>
        [EnumValueNameAttribute("NGL - component in gas")]
        public static ReportingProduct NglComponentInGas
        {
            get 
            {
                return nglComponentInGas;
            }
        }

        private readonly static ReportingProduct normalButane;
        /// <summary>
        /// A compound where the main component is butane.
        /// </summary>
        [EnumValueNameAttribute("normal butane")]
        public static ReportingProduct NormalButane
        {
            get 
            {
                return normalButane;
            }
        }

        private readonly static ReportingProduct normalPentane;
        /// <summary>
        /// A compound where the main component is pentane.
        /// </summary>
        [EnumValueNameAttribute("normal pentane")]
        public static ReportingProduct NormalPentane
        {
            get 
            {
                return normalPentane;
            }
        }

        private readonly static ReportingProduct oilAndGas;
        /// <summary>
        ///  A combination of oil (including water) and gas. This is generally used when referring to 'all production'. 
        /// </summary>
        [EnumValueNameAttribute("oil and gas")]
        public static ReportingProduct OilAndGas
        {
            get 
            {
                return oilAndGas;
            }
        }

        private readonly static ReportingProduct oil;
        /// <summary>
        ///  Crude oil including water. A mixture of hydrocarbons, that existed in liquid phase in underground reservoirs and remains liquid at atmospheric pressure after passing through separating facilities. 
        /// </summary>
        [EnumValueNameAttribute("oil")]
        public static ReportingProduct Oil
        {
            get 
            {
                return oil;
            }
        }

        private readonly static ReportingProduct oilGross;
        /// <summary>
        /// A crude oil that that includes all petroleum liquids and sediments and water, excluding free water.
        /// </summary>
        [EnumValueNameAttribute("oil - gross")]
        public static ReportingProduct OilGross
        {
            get 
            {
                return oilGross;
            }
        }

        private readonly static ReportingProduct oilNet;
        /// <summary>
        /// A crude oil that includes all petroleum liquids excluding sediments and water as well as free water.
        /// </summary>
        [EnumValueNameAttribute("oil - net")]
        public static ReportingProduct OilNet
        {
            get 
            {
                return oilNet;
            }
        }

        private readonly static ReportingProduct oilComponentInWater;
        /// <summary>
        /// Oil as a component in water.
        /// </summary>
        [EnumValueNameAttribute("oil - component in water")]
        public static ReportingProduct OilComponentInWater
        {
            get 
            {
                return oilComponentInWater;
            }
        }

        private readonly static ReportingProduct pentaneComponent;
        /// <summary>
        /// The hydrocarbon pentane C5H12 which has several isomers
        /// </summary>
        [EnumValueNameAttribute("pentane - component")]
        public static ReportingProduct PentaneComponent
        {
            get 
            {
                return pentaneComponent;
            }
        }

        private readonly static ReportingProduct petroleumGasLiquid;
        /// <summary>
        /// DEPRECATED - See liquefied natural gas.
        /// </summary>
        [EnumValueNameAttribute("petroleum gas liquid")]
        public static ReportingProduct PetroleumGasLiquid
        {
            get 
            {
                return petroleumGasLiquid;
            }
        }

        private readonly static ReportingProduct propane;
        /// <summary>
        /// A compound where the main component is propane.
        /// </summary>
        [EnumValueNameAttribute("propane")]
        public static ReportingProduct Propane
        {
            get 
            {
                return propane;
            }
        }

        private readonly static ReportingProduct propaneComponent;
        /// <summary>
        /// Propane as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("propane - component")]
        public static ReportingProduct PropaneComponent
        {
            get 
            {
                return propaneComponent;
            }
        }

        private readonly static ReportingProduct salt;
        /// <summary>
        /// xxxxxxxxxxxxxxxxxxxxxx
        /// </summary>
        [EnumValueNameAttribute("salt")]
        public static ReportingProduct Salt
        {
            get 
            {
                return salt;
            }
        }

        private readonly static ReportingProduct sandComponent;
        /// <summary>
        /// Sand as a component in another fluid.
        /// </summary>
        [EnumValueNameAttribute("sand - component")]
        public static ReportingProduct SandComponent
        {
            get 
            {
                return sandComponent;
            }
        }

        private readonly static ReportingProduct triethyleneGlycol;
        /// <summary>
        /// A compound where the main component is triethylene glycol.
        /// </summary>
        [EnumValueNameAttribute("triethylene glycol")]
        public static ReportingProduct TriethyleneGlycol
        {
            get 
            {
                return triethyleneGlycol;
            }
        }

        private readonly static ReportingProduct water;
        /// <summary>
        /// Water in a liquid state.
        /// </summary>
        [EnumValueNameAttribute("water")]
        public static ReportingProduct Water
        {
            get 
            {
                return water;
            }
        }

        private readonly static ReportingProduct waterDischarge;
        /// <summary>
        /// Produced water that has not been processed.
        /// </summary>
        [EnumValueNameAttribute("water - discharge")]
        public static ReportingProduct WaterDischarge
        {
            get 
            {
                return waterDischarge;
            }
        }

        private readonly static ReportingProduct waterProcessed;
        /// <summary>
        /// Produced water that has been processed to remove hydrocarbons.
        /// </summary>
        [EnumValueNameAttribute("water - processed")]
        public static ReportingProduct WaterProcessed
        {
            get 
            {
                return waterProcessed;
            }
        }

        private readonly static ReportingProduct unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingProduct Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReportingProduct()
        {
            cTwoPlus = 
                new ReportingProduct("C2+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cThreePlus = 
                new ReportingProduct("C3+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cFourPlus = 
                new ReportingProduct("C4+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cFivePlus = 
                new ReportingProduct("C5+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cSixPlus = 
                new ReportingProduct("C6+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cSevenPlus = 
                new ReportingProduct("C7+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cEightPlus = 
                new ReportingProduct("C8+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cNinePlus = 
                new ReportingProduct("C9+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cOneZeroPlus = 
                new ReportingProduct("C10+")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all heavier components. "
            };
            cTwoMinus = 
                new ReportingProduct("C2-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cThreeMinus = 
                new ReportingProduct("C3-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cFourMinus = 
                new ReportingProduct("C4-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cFiveMinus = 
                new ReportingProduct("C5-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cSixMinus = 
                new ReportingProduct("C6-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cSevenMinus = 
                new ReportingProduct("C7-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cEightMinus = 
                new ReportingProduct("C8-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cNineMinus = 
                new ReportingProduct("C9-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            cOneZeroMinus = 
                new ReportingProduct("C10-")
                {
                    Description = " A product composed of the component with the specified number of carbon atoms plus all lighter components. "
            };
            oleic = 
                new ReportingProduct("oleic")
                {
                    Description = " An undifferentiated liquid fluid phase in which the dominant continuous materials are liquid hydrocarbons. This phase is often called the \"oil phase\". "
            };
            aqueous = 
                new ReportingProduct("aqueous")
                {
                    Description = " An undifferentiated liquid fluid phase in which the dominant continuous material is liquid water. This phase is often called the \"water phase\". "
            };
            vapor = 
                new ReportingProduct("vapor")
                {
                    Description = " An undifferentiated fluid phase that is distinctly gaseous. This phase is often called the \"gas phase\". "
            };
            liquid = 
                new ReportingProduct("liquid")
                {
                    Description = " An undifferentiated fluid phase that is distinctly liquid. This includes water. "
            };
            cSeven = 
                new ReportingProduct("C7")
                {
                    Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with seven carbon atoms."
            };
            cEight = 
                new ReportingProduct("C8")
                {
                    Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with eight carbon atoms."
            };
            cNine = 
                new ReportingProduct("C9")
                {
                    Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with nine carbon atoms."
            };
            cOneZero = 
                new ReportingProduct("C10")
                {
                    Description = "A hydrocarbon compound that consists of mainly hydrocarbon molecules with ten carbon atoms."
            };
            carbonMonoxideGas = 
                new ReportingProduct("carbon monoxide gas")
                {
                    Description = "Carbon monoxide in a gaseous state."
            };
            carbonDioxideGas = 
                new ReportingProduct("carbon dioxide gas")
                {
                    Description = "Carbon dioxide in a gaseous state."
            };
            chemical = 
                new ReportingProduct("chemical")
                {
                    Description = "A chemical of some type."
            };
            condensate = 
                new ReportingProduct("condensate")
                {
                    Description = "Mixture of light and heavier hydrocarbons in a liquid state."
            };
            condensateGross = 
                new ReportingProduct("condensate - gross")
                {
                    Description = "Light hydrocarbon fractions produced with natural gas, which condense into liquid at normal temperatures and pressures associated with surface production equipment. "
            };
            condensateNet = 
                new ReportingProduct("condensate - net")
                {
                    Description = "Hydrocatbon condensate containing only the heavier carbon fractions C5 to C10+."
            };
            crudeStabilized = 
                new ReportingProduct("crude - stabilized")
                {
                    Description = "A crude oil that has been stabilized by separating out dissolved gas."
            };
            cuttings = 
                new ReportingProduct("cuttings")
                {
                    Description = "Drill cuttings."
            };
            diethyleneGlycol = 
                new ReportingProduct("diethylene glycol")
                {
                    Description = "A compound where the main component is diethylene glycol."
            };
            diesel = 
                new ReportingProduct("diesel")
                {
                    Description = "Diesel fuel."
            };
            dioxygen = 
                new ReportingProduct("dioxygen")
                {
                    Description = "Oxygen"
            };
            electricPower = 
                new ReportingProduct("electric power")
                {
                    Description = "Electrical power."
            };
            ethane = 
                new ReportingProduct("ethane")
                {
                    Description = "A compound where the main component is ethane."
            };
            ethaneComponent = 
                new ReportingProduct("ethane - component")
                {
                    Description = "Ethane as a component in another fluid."
            };
            gas = 
                new ReportingProduct("gas")
                {
                    Description = "Gas mixture of hydrocarbons."
            };
            gasDry = 
                new ReportingProduct("gas - dry")
                {
                    Description = "A natural gas that occurs in the absence of condensate or liquid hydrocarbons, or gas that has had condensible hydrocarbons removed, mainly consisting of methane gas."
            };
            gasRich = 
                new ReportingProduct("gas - rich")
                {
                    Description = "Gas mixture of light and heavier hydrocarbons than a lean gas."
            };
            gasWet = 
                new ReportingProduct("gas - wet")
                {
                    Description = "A natural gas that contains less methane (typically less than 85% methane) and more ethane and other more complex hydrocarbons like propane, butane and naphtha."
            };
            gasComponentInOil = 
                new ReportingProduct("gas - component in oil")
                {
                    Description = "Gas as a component in oil."
            };
            heliumGas = 
                new ReportingProduct("helium gas")
                {
                    Description = "Helium"
            };
            heptane = 
                new ReportingProduct("heptane")
                {
                    Description = "A compound where the main component is heptane."
            };
            hydraulicControlFluid = 
                new ReportingProduct("hydraulic control fluid")
                {
                    Description = "hydraulic control fluid as used to actuate remote devices"
            };
            hydrogenGas = 
                new ReportingProduct("hydrogen gas")
                {
                    Description = "Hydrogen"
            };
            hydrogenSulfide = 
                new ReportingProduct("hydrogen sulfide")
                {
                    Description = "A compound where the main component is hydrogen sulfide."
            };
            ibutaneComponent = 
                new ReportingProduct("i-butane - component")
                {
                    Description = "I-butane as a component in another fluid."
            };
            isobutane = 
                new ReportingProduct("isobutane")
                {
                    Description = "A compound where the main component is isobutane."
            };
            isopentane = 
                new ReportingProduct("isopentane")
                {
                    Description = "A compound where the main component is isopentane."
            };
            liquefiedNaturalGas = 
                new ReportingProduct("liquefied natural gas")
                {
                    Description = " A liquid compound that is natural gas compressed and supercooled to -167 deg C (-269 deg F) into a liquid to reduce its volume to 1/635th for storage and transportation. Liquefied natural gas has a calorific value of 22,300 Btu/lb. It consists of about 91% of methane and 7% ethane with some propane, butane, and higher hydrocarbons. One tonne liquefied natural gas is equal to about 53 Mcf of gas. Liquified natural gas can be vaporized by ambient air, another fluid, or direct fired vaporizer. "
            };
            liquefiedPetroleumGas = 
                new ReportingProduct("liquefied petroleum gas")
                {
                    Description = "A liquid compound that is predominantly butane and propane separated from natural gasoline or natural gas and sold as fuel - commonly known as bottled gas, tank gas or LP-gas."
            };
            methane = 
                new ReportingProduct("methane")
                {
                    Description = "A compound where the main component is methane."
            };
            methaneComponent = 
                new ReportingProduct("methane - component")
                {
                    Description = "xxxxxxxxxxxxxxxx"
            };
            methanol = 
                new ReportingProduct("methanol")
                {
                    Description = "A compound where the main component is methanol."
            };
            mixedButane = 
                new ReportingProduct("mixed butane")
                {
                    Description = "A compound where the main components are butane and isobutane."
            };
            monoethyleneGlycol = 
                new ReportingProduct("monoethylene glycol")
                {
                    Description = "A compound where the main component is monoethylene glycol."
            };
            nbutaneComponent = 
                new ReportingProduct("n-butane - component")
                {
                    Description = "N-butane as a component in another fluid."
            };
            naphta = 
                new ReportingProduct("naphta")
                {
                    Description = "An aggregate that is a volatile and inflammable product of crude oil refining with a boiling range 140 - 210 deg. Celsius consisting of C5+ to C10 components (pentanes and hexanes)."
            };
            naturalGasLiquid = 
                new ReportingProduct("natural gas liquid")
                {
                    Description = " Mixture of ethane, propane and butane with small quantities of heaver hydrocarbons. Partially liquid at atmospheric pressure. "
            };
            neopentane = 
                new ReportingProduct("neopentane")
                {
                    Description = "A compound where the main component is neopentane."
            };
            nitrogenGas = 
                new ReportingProduct("nitrogen gas")
                {
                    Description = "A gasous compound where the main component is nitrogen."
            };
            nitrogenOxideGas = 
                new ReportingProduct("nitrogen oxide gas")
                {
                    Description = "Nitrogen oxides in a gaseous state"
            };
            nglComponentInGas = 
                new ReportingProduct("NGL - component in gas")
                {
                    Description = "Natural gas liquid as a component in gas."
            };
            normalButane = 
                new ReportingProduct("normal butane")
                {
                    Description = "A compound where the main component is butane."
            };
            normalPentane = 
                new ReportingProduct("normal pentane")
                {
                    Description = "A compound where the main component is pentane."
            };
            oilAndGas = 
                new ReportingProduct("oil and gas")
                {
                    Description = " A combination of oil (including water) and gas. This is generally used when referring to 'all production'. "
            };
            oil = 
                new ReportingProduct("oil")
                {
                    Description = " Crude oil including water. A mixture of hydrocarbons, that existed in liquid phase in underground reservoirs and remains liquid at atmospheric pressure after passing through separating facilities. "
            };
            oilGross = 
                new ReportingProduct("oil - gross")
                {
                    Description = "A crude oil that that includes all petroleum liquids and sediments and water, excluding free water."
            };
            oilNet = 
                new ReportingProduct("oil - net")
                {
                    Description = "A crude oil that includes all petroleum liquids excluding sediments and water as well as free water."
            };
            oilComponentInWater = 
                new ReportingProduct("oil - component in water")
                {
                    Description = "Oil as a component in water."
            };
            pentaneComponent = 
                new ReportingProduct("pentane - component")
                {
                    Description = "The hydrocarbon pentane C5H12 which has several isomers"
            };
            petroleumGasLiquid = 
                new ReportingProduct("petroleum gas liquid")
                {
                    Description = "DEPRECATED - See liquefied natural gas."
            };
            propane = 
                new ReportingProduct("propane")
                {
                    Description = "A compound where the main component is propane."
            };
            propaneComponent = 
                new ReportingProduct("propane - component")
                {
                    Description = "Propane as a component in another fluid."
            };
            salt = 
                new ReportingProduct("salt")
                {
                    Description = "xxxxxxxxxxxxxxxxxxxxxx"
            };
            sandComponent = 
                new ReportingProduct("sand - component")
                {
                    Description = "Sand as a component in another fluid."
            };
            triethyleneGlycol = 
                new ReportingProduct("triethylene glycol")
                {
                    Description = "A compound where the main component is triethylene glycol."
            };
            water = 
                new ReportingProduct("water")
                {
                    Description = "Water in a liquid state."
            };
            waterDischarge = 
                new ReportingProduct("water - discharge")
                {
                    Description = "Produced water that has not been processed."
            };
            waterProcessed = 
                new ReportingProduct("water - processed")
                {
                    Description = "Produced water that has been processed to remove hydrocarbons."
            };
            unknown = 
                new ReportingProduct("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReportingProduct by name
        /// </summary>
        /// <param name="name">The name of the ReportingProduct to return</param>
        /// <returns>The ReportingProduct represented by 'name'</returns>
        public static ReportingProduct GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReportingProduct)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReportingProduct)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReportingProduct)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ReportingProperty alarmAbsolutePressure;
        /// <summary>
        ///  Absolute minimum pressure of the flow stream before the system will give an alarm. Equivalent to element absoluteMinPres in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("alarm absolute pressure")]
        public static ReportingProperty AlarmAbsolutePressure
        {
            get 
            {
                return alarmAbsolutePressure;
            }
        }

        private readonly static ReportingProperty atmosphericPressure;
        /// <summary>
        ///  The average atmospheric pressure during the reporting period. Equivalent to element atmosphere in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("atmospheric pressure")]
        public static ReportingProperty AtmosphericPressure
        {
            get 
            {
                return atmosphericPressure;
            }
        }

        private readonly static ReportingProperty density;
        /// <summary>
        ///  The density of the flow stream or a specified component product within the flow. Equivalent to element densityValue in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("density")]
        public static ReportingProperty Density
        {
            get 
            {
                return density;
            }
        }

        private readonly static ReportingProperty densityFlowRate;
        /// <summary>
        ///  The mass basis flow rate of the flow stream or a specified component product within the flow. This is used for things like a sand component. Equivalent to element densityFlowRate in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("density flow rate")]
        public static ReportingProperty DensityFlowRate
        {
            get 
            {
                return densityFlowRate;
            }
        }

        private readonly static ReportingProperty densityStandard;
        /// <summary>
        ///  The density of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element densityValue in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("density standard")]
        public static ReportingProperty DensityStandard
        {
            get 
            {
                return densityStandard;
            }
        }

        private readonly static ReportingProperty dewpointTemperatureStandard;
        /// <summary>
        ///  The temperature at which the specified component product within the flow will start to condense out of the gaseous phase, corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element hcDewpoint or waterDewpoint (depending on the specified product) in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("dewpoint temperature standard")]
        public static ReportingProperty DewpointTemperatureStandard
        {
            get 
            {
                return dewpointTemperatureStandard;
            }
        }

        private readonly static ReportingProperty differentialPressure;
        /// <summary>
        ///  The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/presDiff in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("differential pressure")]
        public static ReportingProperty DifferentialPressure
        {
            get 
            {
                return differentialPressure;
            }
        }

        private readonly static ReportingProperty differentialTemperature;
        /// <summary>
        ///  The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/tempDiff in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("differential temperature")]
        public static ReportingProperty DifferentialTemperature
        {
            get 
            {
                return differentialTemperature;
            }
        }

        private readonly static ReportingProperty efficiency;
        /// <summary>
        ///  The actual volume of the flow stream or a specified component product within the flow divided by the potential volume. Equivalent to element efficiency in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("efficiency")]
        public static ReportingProperty Efficiency
        {
            get 
            {
                return efficiency;
            }
        }

        private readonly static ReportingProperty flowRate;
        /// <summary>
        ///  The flow rate of the flow stream or a specified component product within the flow. Equivalent to element flowRateValue in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("flow rate")]
        public static ReportingProperty FlowRate
        {
            get 
            {
                return flowRate;
            }
        }

        private readonly static ReportingProperty flowRateStandard;
        /// <summary>
        ///  The flow rate of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element flowRateValue in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("flow rate standard")]
        public static ReportingProperty FlowRateStandard
        {
            get 
            {
                return flowRateStandard;
            }
        }

        private readonly static ReportingProperty gasLiquidRatio;
        /// <summary>
        ///  The volumetric ratio of gas to liquid for all products in the whole flow stream. Equivalent to element gasLiquidRatio in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("gas liquid ratio")]
        public static ReportingProperty GasLiquidRatio
        {
            get 
            {
                return gasLiquidRatio;
            }
        }

        private readonly static ReportingProperty gasOilRatio;
        /// <summary>
        ///  The volumetric ratio between the total gas volume and the total oil volume in the flow stream. Equivalent to element gor in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("gas oil ratio")]
        public static ReportingProperty GasOilRatio
        {
            get 
            {
                return gasOilRatio;
            }
        }

        private readonly static ReportingProperty grossCalorificValueStandard;
        /// <summary>
        ///  The amount of heat which would be released by the complete combustion in air of a specific quantity of a specified component product at standard temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element grossCalorificValueSt in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("gross calorific value standard")]
        public static ReportingProperty GrossCalorificValueStandard
        {
            get 
            {
                return grossCalorificValueStandard;
            }
        }

        private readonly static ReportingProperty mass;
        /// <summary>
        ///  The mass of the flow stream or a specified component product within the flow. Equivalent to element mass in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("mass")]
        public static ReportingProperty Mass
        {
            get 
            {
                return mass;
            }
        }

        private readonly static ReportingProperty massConcentration;
        /// <summary>
        ///  The concentration of the specified component product as a weight percentage of the flow stream. Equivalent to element weightPercent in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("mass concentration")]
        public static ReportingProperty MassConcentration
        {
            get 
            {
                return massConcentration;
            }
        }

        private readonly static ReportingProperty molarAmount;
        /// <summary>
        ///  The molar amount of a specified component product. Equivalent to element moleAmt in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("molar amount")]
        public static ReportingProperty MolarAmount
        {
            get 
            {
                return molarAmount;
            }
        }

        private readonly static ReportingProperty molarFraction;
        /// <summary>
        ///  The molar fraction of the specified component product as a molar amount percentage of the flow stream. Equivalent to element molePercent in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("molar fraction")]
        public static ReportingProperty MolarFraction
        {
            get 
            {
                return molarFraction;
            }
        }

        private readonly static ReportingProperty molecularWeight;
        /// <summary>
        ///  The molecular weight of a specified component product. This is a unitless quantity. Equivalent to element molecularWeight in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("molecular weight")]
        public static ReportingProperty MolecularWeight
        {
            get 
            {
                return molecularWeight;
            }
        }

        private readonly static ReportingProperty pressure;
        /// <summary>
        ///  Pressure in the flow stream. Equivalent to element pres in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("pressure")]
        public static ReportingProperty Pressure
        {
            get 
            {
                return pressure;
            }
        }

        private readonly static ReportingProperty reidVaporPressure;
        /// <summary>
        ///  Reid vapor pressure of the flow stream or a specified component product within the flow. The absolute vapor pressure of volatile crude oil and volatile petroleum liquids, except liquefied petroleum gases, as determined in accordance with American Society for Testing and Materials under the designation ASTM D323-56. Equivalent to element rvp in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("reid vapor pressure")]
        public static ReportingProperty ReidVaporPressure
        {
            get 
            {
                return reidVaporPressure;
            }
        }

        private readonly static ReportingProperty specificGravity;
        /// <summary>
        ///  The specific gravity of the flow stream or a specified component product within the flow. Equivalent to element sg in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("specific gravity")]
        public static ReportingProperty SpecificGravity
        {
            get 
            {
                return specificGravity;
            }
        }

        private readonly static ReportingProperty temperature;
        /// <summary>
        ///  Temperature of the port. Equivalent to element temp in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("temperature")]
        public static ReportingProperty Temperature
        {
            get 
            {
                return temperature;
            }
        }

        private readonly static ReportingProperty trueVaporPressure;
        /// <summary>
        ///  True vapor pressure of the flow stream or a specified component product within the flow The equilibrium partial pressure exerted by a petroleum liquid as determined in accordance with standard methods. Equivalent to element tvp in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("true vapor pressure")]
        public static ReportingProperty TrueVaporPressure
        {
            get 
            {
                return trueVaporPressure;
            }
        }

        private readonly static ReportingProperty volume;
        /// <summary>
        ///  The volume of the flow stream or a specified component product within the flow. Equivalent to element volumeValue in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("volume")]
        public static ReportingProperty Volume
        {
            get 
            {
                return volume;
            }
        }

        private readonly static ReportingProperty volumeConcentration;
        /// <summary>
        ///  The concentration of the specified component product as a volume percentage of the flow stream. Equivalent to element concentration in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("volume concentration")]
        public static ReportingProperty VolumeConcentration
        {
            get 
            {
                return volumeConcentration;
            }
        }

        private readonly static ReportingProperty volumeStandard;
        /// <summary>
        ///  The volume of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element volumeValue in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("volume standard")]
        public static ReportingProperty VolumeStandard
        {
            get 
            {
                return volumeStandard;
            }
        }

        private readonly static ReportingProperty wobbeIndex;
        /// <summary>
        ///  The volume of the flow stream or a specified component product within the flow. The Wobbe Index is a number which indicates interchangeability of fuel gasses and is obtained by dividing the heating value of a gas by the square root of its specific gravity. Equivalent to element wobbeIndex in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("wobbe index")]
        public static ReportingProperty WobbeIndex
        {
            get 
            {
                return wobbeIndex;
            }
        }

        private readonly static ReportingProperty work;
        /// <summary>
        ///  The electrical energy represented by the flow stream or a specified component product within the flow. Equivalent to element work in the productVolume data-schema. 
        /// </summary>
        [EnumValueNameAttribute("work")]
        public static ReportingProperty Work
        {
            get 
            {
                return work;
            }
        }

        private readonly static ReportingProperty standardVolume;
        /// <summary>
        /// DEPRECATED: use "volume standard" instead.
        /// </summary>
        [EnumValueNameAttribute("standard volume")]
        public static ReportingProperty StandardVolume
        {
            get 
            {
                return standardVolume;
            }
        }

        private readonly static ReportingProperty unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportingProperty Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReportingProperty()
        {
            alarmAbsolutePressure = 
                new ReportingProperty("alarm absolute pressure")
                {
                    Description = " Absolute minimum pressure of the flow stream before the system will give an alarm. Equivalent to element absoluteMinPres in the productVolume data-schema. "
            };
            atmosphericPressure = 
                new ReportingProperty("atmospheric pressure")
                {
                    Description = " The average atmospheric pressure during the reporting period. Equivalent to element atmosphere in the productVolume data-schema. "
            };
            density = 
                new ReportingProperty("density")
                {
                    Description = " The density of the flow stream or a specified component product within the flow. Equivalent to element densityValue in the productVolume data-schema. "
            };
            densityFlowRate = 
                new ReportingProperty("density flow rate")
                {
                    Description = " The mass basis flow rate of the flow stream or a specified component product within the flow. This is used for things like a sand component. Equivalent to element densityFlowRate in the productVolume data-schema. "
            };
            densityStandard = 
                new ReportingProperty("density standard")
                {
                    Description = " The density of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element densityValue in the productVolume data-schema. "
            };
            dewpointTemperatureStandard = 
                new ReportingProperty("dewpoint temperature standard")
                {
                    Description = " The temperature at which the specified component product within the flow will start to condense out of the gaseous phase, corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element hcDewpoint or waterDewpoint (depending on the specified product) in the productVolume data-schema. "
            };
            differentialPressure = 
                new ReportingProperty("differential pressure")
                {
                    Description = " The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/presDiff in the productVolume data-schema. "
            };
            differentialTemperature = 
                new ReportingProperty("differential temperature")
                {
                    Description = " The differential pressure between the ports. Presumes a facility with only two ports. Equivalent to element portDiff/tempDiff in the productVolume data-schema. "
            };
            efficiency = 
                new ReportingProperty("efficiency")
                {
                    Description = " The actual volume of the flow stream or a specified component product within the flow divided by the potential volume. Equivalent to element efficiency in the productVolume data-schema. "
            };
            flowRate = 
                new ReportingProperty("flow rate")
                {
                    Description = " The flow rate of the flow stream or a specified component product within the flow. Equivalent to element flowRateValue in the productVolume data-schema. "
            };
            flowRateStandard = 
                new ReportingProperty("flow rate standard")
                {
                    Description = " The flow rate of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element flowRateValue in the productVolume data-schema. "
            };
            gasLiquidRatio = 
                new ReportingProperty("gas liquid ratio")
                {
                    Description = " The volumetric ratio of gas to liquid for all products in the whole flow stream. Equivalent to element gasLiquidRatio in the productVolume data-schema. "
            };
            gasOilRatio = 
                new ReportingProperty("gas oil ratio")
                {
                    Description = " The volumetric ratio between the total gas volume and the total oil volume in the flow stream. Equivalent to element gor in the productVolume data-schema. "
            };
            grossCalorificValueStandard = 
                new ReportingProperty("gross calorific value standard")
                {
                    Description = " The amount of heat which would be released by the complete combustion in air of a specific quantity of a specified component product at standard temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element grossCalorificValueSt in the productVolume data-schema. "
            };
            mass = 
                new ReportingProperty("mass")
                {
                    Description = " The mass of the flow stream or a specified component product within the flow. Equivalent to element mass in the productVolume data-schema. "
            };
            massConcentration = 
                new ReportingProperty("mass concentration")
                {
                    Description = " The concentration of the specified component product as a weight percentage of the flow stream. Equivalent to element weightPercent in the productVolume data-schema. "
            };
            molarAmount = 
                new ReportingProperty("molar amount")
                {
                    Description = " The molar amount of a specified component product. Equivalent to element moleAmt in the productVolume data-schema. "
            };
            molarFraction = 
                new ReportingProperty("molar fraction")
                {
                    Description = " The molar fraction of the specified component product as a molar amount percentage of the flow stream. Equivalent to element molePercent in the productVolume data-schema. "
            };
            molecularWeight = 
                new ReportingProperty("molecular weight")
                {
                    Description = " The molecular weight of a specified component product. This is a unitless quantity. Equivalent to element molecularWeight in the productVolume data-schema. "
            };
            pressure = 
                new ReportingProperty("pressure")
                {
                    Description = " Pressure in the flow stream. Equivalent to element pres in the productVolume data-schema. "
            };
            reidVaporPressure = 
                new ReportingProperty("reid vapor pressure")
                {
                    Description = " Reid vapor pressure of the flow stream or a specified component product within the flow. The absolute vapor pressure of volatile crude oil and volatile petroleum liquids, except liquefied petroleum gases, as determined in accordance with American Society for Testing and Materials under the designation ASTM D323-56. Equivalent to element rvp in the productVolume data-schema. "
            };
            specificGravity = 
                new ReportingProperty("specific gravity")
                {
                    Description = " The specific gravity of the flow stream or a specified component product within the flow. Equivalent to element sg in the productVolume data-schema. "
            };
            temperature = 
                new ReportingProperty("temperature")
                {
                    Description = " Temperature of the port. Equivalent to element temp in the productVolume data-schema. "
            };
            trueVaporPressure = 
                new ReportingProperty("true vapor pressure")
                {
                    Description = " True vapor pressure of the flow stream or a specified component product within the flow The equilibrium partial pressure exerted by a petroleum liquid as determined in accordance with standard methods. Equivalent to element tvp in the productVolume data-schema. "
            };
            volume = 
                new ReportingProperty("volume")
                {
                    Description = " The volume of the flow stream or a specified component product within the flow. Equivalent to element volumeValue in the productVolume data-schema. "
            };
            volumeConcentration = 
                new ReportingProperty("volume concentration")
                {
                    Description = " The concentration of the specified component product as a volume percentage of the flow stream. Equivalent to element concentration in the productVolume data-schema. "
            };
            volumeStandard = 
                new ReportingProperty("volume standard")
                {
                    Description = " The volume of the flow stream or a specified component product within the flow corrected to specific conditions of temperature and pressure as specified by the standardTempPres element in the productVolume data-schema. Equivalent to element volumeValue in the productVolume data-schema. "
            };
            wobbeIndex = 
                new ReportingProperty("wobbe index")
                {
                    Description = " The volume of the flow stream or a specified component product within the flow. The Wobbe Index is a number which indicates interchangeability of fuel gasses and is obtained by dividing the heating value of a gas by the square root of its specific gravity. Equivalent to element wobbeIndex in the productVolume data-schema. "
            };
            work = 
                new ReportingProperty("work")
                {
                    Description = " The electrical energy represented by the flow stream or a specified component product within the flow. Equivalent to element work in the productVolume data-schema. "
            };
            standardVolume = 
                new ReportingProperty("standard volume")
                {
                    Description = "DEPRECATED: use \"volume standard\" instead."
                    ,Deprecated = "1.2.2"
                    ,ReplacedBy = VolumeStandard
            };
            unknown = 
                new ReportingProperty("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReportingProperty by name
        /// </summary>
        /// <param name="name">The name of the ReportingProperty to return</param>
        /// <returns>The ReportingProperty represented by 'name'</returns>
        public static ReportingProperty GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReportingProperty)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReportingProperty)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReportingProperty)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ReportVersionStatus final;
        /// <summary>
        /// The final version of a report
        /// </summary>
        [EnumValueNameAttribute("final")]
        public static ReportVersionStatus Final
        {
            get 
            {
                return final;
            }
        }

        private readonly static ReportVersionStatus preliminary;
        /// <summary>
        /// A preliminary version of a report
        /// </summary>
        [EnumValueNameAttribute("preliminary")]
        public static ReportVersionStatus Preliminary
        {
            get 
            {
                return preliminary;
            }
        }

        private readonly static ReportVersionStatus unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReportVersionStatus Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReportVersionStatus()
        {
            final = 
                new ReportVersionStatus("final")
                {
                    Description = "The final version of a report"
            };
            preliminary = 
                new ReportVersionStatus("preliminary")
                {
                    Description = "A preliminary version of a report"
            };
            unknown = 
                new ReportVersionStatus("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReportVersionStatus by name
        /// </summary>
        /// <param name="name">The name of the ReportVersionStatus to return</param>
        /// <returns>The ReportVersionStatus represented by 'name'</returns>
        public static ReportVersionStatus GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReportVersionStatus)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReportVersionStatus)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReportVersionStatus)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines the reservoir hydrocarbon fluid in broad terms of its phase behavior.
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

        private readonly static ReservoirFluidKind blackOil;
        /// <summary>
        /// The reservoir fluid is predominantly oil with dissolved gas
        /// </summary>
        [EnumValueNameAttribute("black oil")]
        public static ReservoirFluidKind BlackOil
        {
            get 
            {
                return blackOil;
            }
        }

        private readonly static ReservoirFluidKind volatileOil;
        /// <summary>
        /// The reservoir fluid is a light oil with a high proportion of dissolved gas
        /// </summary>
        [EnumValueNameAttribute("volatile oil")]
        public static ReservoirFluidKind VolatileOil
        {
            get 
            {
                return volatileOil;
            }
        }

        private readonly static ReservoirFluidKind criticalOrNearCritical;
        /// <summary>
        ///  The reservoir fluid is a light oil and gas mix which exits close to its critical point in the reservoir 
        /// </summary>
        [EnumValueNameAttribute("critical or near critical")]
        public static ReservoirFluidKind CriticalOrNearCritical
        {
            get 
            {
                return criticalOrNearCritical;
            }
        }

        private readonly static ReservoirFluidKind wetGasOrCondensate;
        /// <summary>
        /// The reservoir fluid is gaseous but will yield some hydrocarbon liquid when brought to surface
        /// </summary>
        [EnumValueNameAttribute("wet gas or condensate")]
        public static ReservoirFluidKind WetGasOrCondensate
        {
            get 
            {
                return wetGasOrCondensate;
            }
        }

        private readonly static ReservoirFluidKind dryGas;
        /// <summary>
        /// The reservoir fluid is gaseous and will yield no material hydrocarbon liquid when brought to surface
        /// </summary>
        [EnumValueNameAttribute("dry gas")]
        public static ReservoirFluidKind DryGas
        {
            get 
            {
                return dryGas;
            }
        }

        private readonly static ReservoirFluidKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ReservoirFluidKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ReservoirFluidKind()
        {
            blackOil = 
                new ReservoirFluidKind("black oil")
                {
                    Description = "The reservoir fluid is predominantly oil with dissolved gas"
            };
            volatileOil = 
                new ReservoirFluidKind("volatile oil")
                {
                    Description = "The reservoir fluid is a light oil with a high proportion of dissolved gas"
            };
            criticalOrNearCritical = 
                new ReservoirFluidKind("critical or near critical")
                {
                    Description = " The reservoir fluid is a light oil and gas mix which exits close to its critical point in the reservoir "
            };
            wetGasOrCondensate = 
                new ReservoirFluidKind("wet gas or condensate")
                {
                    Description = "The reservoir fluid is gaseous but will yield some hydrocarbon liquid when brought to surface"
            };
            dryGas = 
                new ReservoirFluidKind("dry gas")
                {
                    Description = "The reservoir fluid is gaseous and will yield no material hydrocarbon liquid when brought to surface"
            };
            unknown = 
                new ReservoirFluidKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ReservoirFluidKind by name
        /// </summary>
        /// <param name="name">The name of the ReservoirFluidKind to return</param>
        /// <returns>The ReservoirFluidKind represented by 'name'</returns>
        public static ReservoirFluidKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ReservoirFluidKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ReservoirFluidKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ReservoirFluidKind)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static SafetyType drillOrExercise;
        /// <summary>
        /// The safety issue is a drill or exercise
        /// </summary>
        [EnumValueNameAttribute("drill or exercise")]
        public static SafetyType DrillOrExercise
        {
            get 
            {
                return drillOrExercise;
            }
        }

        private readonly static SafetyType fire;
        /// <summary>
        /// The safety issue is a fire
        /// </summary>
        [EnumValueNameAttribute("fire")]
        public static SafetyType Fire
        {
            get 
            {
                return fire;
            }
        }

        private readonly static SafetyType firstAid;
        /// <summary>
        /// The safety issue required first aid
        /// </summary>
        [EnumValueNameAttribute("first aid")]
        public static SafetyType FirstAid
        {
            get 
            {
                return firstAid;
            }
        }

        private readonly static SafetyType hazardReportCard;
        /// <summary>
        /// The safety issue is a hazard report card being completed
        /// </summary>
        [EnumValueNameAttribute("hazard report card")]
        public static SafetyType HazardReportCard
        {
            get 
            {
                return hazardReportCard;
            }
        }

        private readonly static SafetyType jobObservation;
        /// <summary>
        /// The safety issue is an observation being made
        /// </summary>
        [EnumValueNameAttribute("job observation")]
        public static SafetyType JobObservation
        {
            get 
            {
                return jobObservation;
            }
        }

        private readonly static SafetyType lostTimeIncident;
        /// <summary>
        ///  The safety issue is an incident which resulted in an injured employee who required medical treatment and could not return to work the next day. 
        /// </summary>
        [EnumValueNameAttribute("lost time incident")]
        public static SafetyType LostTimeIncident
        {
            get 
            {
                return lostTimeIncident;
            }
        }

        private readonly static SafetyType lostTimeAccident;
        /// <summary>
        /// The safety issue is an accident resulting in lost time from work .
        /// </summary>
        [EnumValueNameAttribute("lost time accident")]
        public static SafetyType LostTimeAccident
        {
            get 
            {
                return lostTimeAccident;
            }
        }

        private readonly static SafetyType miscellaneous;
        /// <summary>
        /// The safety issue is in the miscellaneous category
        /// </summary>
        [EnumValueNameAttribute("miscellaneous")]
        public static SafetyType Miscellaneous
        {
            get 
            {
                return miscellaneous;
            }
        }

        private readonly static SafetyType nearMiss;
        /// <summary>
        ///  The safety issue is an incident which, under different circumstances, could have caused injury, illness and/or major damage to/loss of assets, or harm to the environment or to a third party. 
        /// </summary>
        [EnumValueNameAttribute("near miss")]
        public static SafetyType NearMiss
        {
            get 
            {
                return nearMiss;
            }
        }

        private readonly static SafetyType permitWithSja;
        /// <summary>
        /// The safety issue is a a permit with a Safe Job Analysis.
        /// </summary>
        [EnumValueNameAttribute("permit with SJA")]
        public static SafetyType PermitWithSja
        {
            get 
            {
                return permitWithSja;
            }
        }

        private readonly static SafetyType releasedToAir;
        /// <summary>
        /// The safety issue is a release of fluids to air
        /// </summary>
        [EnumValueNameAttribute("released to air")]
        public static SafetyType ReleasedToAir
        {
            get 
            {
                return releasedToAir;
            }
        }

        private readonly static SafetyType releasedToWater;
        /// <summary>
        /// The safety issue is a release of fluids to water
        /// </summary>
        [EnumValueNameAttribute("released to water")]
        public static SafetyType ReleasedToWater
        {
            get 
            {
                return releasedToWater;
            }
        }

        private readonly static SafetyType restrictedWork;
        /// <summary>
        /// The safety issue is restricted work
        /// </summary>
        [EnumValueNameAttribute("restricted work")]
        public static SafetyType RestrictedWork
        {
            get 
            {
                return restrictedWork;
            }
        }

        private readonly static SafetyType safetyMeeting;
        /// <summary>
        /// The safety issue is a safety meeting
        /// </summary>
        [EnumValueNameAttribute("safety meeting")]
        public static SafetyType SafetyMeeting
        {
            get 
            {
                return safetyMeeting;
            }
        }

        private readonly static SafetyType sentAshore;
        /// <summary>
        /// The safety issue is a person being sent ashore
        /// </summary>
        [EnumValueNameAttribute("sent ashore")]
        public static SafetyType SentAshore
        {
            get 
            {
                return sentAshore;
            }
        }

        private readonly static SafetyType severeAccident;
        /// <summary>
        ///  The safety issue is a type of accident that may challenge safety systems at a level much higher than expected 
        /// </summary>
        [EnumValueNameAttribute("severe accident")]
        public static SafetyType SevereAccident
        {
            get 
            {
                return severeAccident;
            }
        }

        private readonly static SafetyType sickOnBoard;
        /// <summary>
        /// The safety issue is a person sick on board
        /// </summary>
        [EnumValueNameAttribute("sick on board")]
        public static SafetyType SickOnBoard
        {
            get 
            {
                return sickOnBoard;
            }
        }

        private readonly static SafetyType spillOrLeak;
        /// <summary>
        /// The safety issue is a spill or leak
        /// </summary>
        [EnumValueNameAttribute("spill or leak")]
        public static SafetyType SpillOrLeak
        {
            get 
            {
                return spillOrLeak;
            }
        }

        private readonly static SafetyType trafficAccident;
        /// <summary>
        /// The safety issue is a traffic accident
        /// </summary>
        [EnumValueNameAttribute("traffic accident")]
        public static SafetyType TrafficAccident
        {
            get 
            {
                return trafficAccident;
            }
        }

        private readonly static SafetyType totalPermits;
        /// <summary>
        /// The safety issue is a count of total permits
        /// </summary>
        [EnumValueNameAttribute("total permits")]
        public static SafetyType TotalPermits
        {
            get 
            {
                return totalPermits;
            }
        }

        private readonly static SafetyType yeartodateIncidents;
        /// <summary>
        /// The safety issue is a count of year-to-date incidents
        /// </summary>
        [EnumValueNameAttribute("year-to-date incidents")]
        public static SafetyType YeartodateIncidents
        {
            get 
            {
                return yeartodateIncidents;
            }
        }

        private readonly static SafetyType unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static SafetyType Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static SafetyType()
        {
            drillOrExercise = 
                new SafetyType("drill or exercise")
                {
                    Description = "The safety issue is a drill or exercise"
            };
            fire = 
                new SafetyType("fire")
                {
                    Description = "The safety issue is a fire"
            };
            firstAid = 
                new SafetyType("first aid")
                {
                    Description = "The safety issue required first aid"
            };
            hazardReportCard = 
                new SafetyType("hazard report card")
                {
                    Description = "The safety issue is a hazard report card being completed"
            };
            jobObservation = 
                new SafetyType("job observation")
                {
                    Description = "The safety issue is an observation being made"
            };
            lostTimeIncident = 
                new SafetyType("lost time incident")
                {
                    Description = " The safety issue is an incident which resulted in an injured employee who required medical treatment and could not return to work the next day. "
            };
            lostTimeAccident = 
                new SafetyType("lost time accident")
                {
                    Description = "The safety issue is an accident resulting in lost time from work ."
            };
            miscellaneous = 
                new SafetyType("miscellaneous")
                {
                    Description = "The safety issue is in the miscellaneous category"
            };
            nearMiss = 
                new SafetyType("near miss")
                {
                    Description = " The safety issue is an incident which, under different circumstances, could have caused injury, illness and/or major damage to/loss of assets, or harm to the environment or to a third party. "
            };
            permitWithSja = 
                new SafetyType("permit with SJA")
                {
                    Description = "The safety issue is a a permit with a Safe Job Analysis."
            };
            releasedToAir = 
                new SafetyType("released to air")
                {
                    Description = "The safety issue is a release of fluids to air"
            };
            releasedToWater = 
                new SafetyType("released to water")
                {
                    Description = "The safety issue is a release of fluids to water"
            };
            restrictedWork = 
                new SafetyType("restricted work")
                {
                    Description = "The safety issue is restricted work"
            };
            safetyMeeting = 
                new SafetyType("safety meeting")
                {
                    Description = "The safety issue is a safety meeting"
            };
            sentAshore = 
                new SafetyType("sent ashore")
                {
                    Description = "The safety issue is a person being sent ashore"
            };
            severeAccident = 
                new SafetyType("severe accident")
                {
                    Description = " The safety issue is a type of accident that may challenge safety systems at a level much higher than expected "
            };
            sickOnBoard = 
                new SafetyType("sick on board")
                {
                    Description = "The safety issue is a person sick on board"
            };
            spillOrLeak = 
                new SafetyType("spill or leak")
                {
                    Description = "The safety issue is a spill or leak"
            };
            trafficAccident = 
                new SafetyType("traffic accident")
                {
                    Description = "The safety issue is a traffic accident"
            };
            totalPermits = 
                new SafetyType("total permits")
                {
                    Description = "The safety issue is a count of total permits"
            };
            yeartodateIncidents = 
                new SafetyType("year-to-date incidents")
                {
                    Description = "The safety issue is a count of year-to-date incidents"
            };
            unknown = 
                new SafetyType("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a SafetyType by name
        /// </summary>
        /// <param name="name">The name of the SafetyType to return</param>
        /// <returns>The SafetyType represented by 'name'</returns>
        public static SafetyType GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(SafetyType)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(SafetyType)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (SafetyType)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static StandardCondition ambient;
        /// <summary>
        /// Ambient conditions at the time of measurement. That is, the value has not been converted.
        /// </summary>
        [EnumValueNameAttribute("ambient")]
        public static StandardCondition Ambient
        {
            get 
            {
                return ambient;
            }
        }

        private readonly static StandardCondition zeroDegcOneAtm;
        /// <summary>
        /// A temperature of zero degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("0 degC 1 atm")]
        public static StandardCondition ZeroDegcOneAtm
        {
            get 
            {
                return zeroDegcOneAtm;
            }
        }

        private readonly static StandardCondition oneFiveDegcOneAtm;
        /// <summary>
        /// A temperature of sixty degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("15 degC 1 atm")]
        public static StandardCondition OneFiveDegcOneAtm
        {
            get 
            {
                return oneFiveDegcOneAtm;
            }
        }

        private readonly static StandardCondition sixZeroDegfOneAtm;
        /// <summary>
        /// A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("60 degF 1 atm")]
        public static StandardCondition SixZeroDegfOneAtm
        {
            get 
            {
                return sixZeroDegfOneAtm;
            }
        }

        private readonly static StandardCondition unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static StandardCondition Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static StandardCondition()
        {
            ambient = 
                new StandardCondition("ambient")
                {
                    Description = "Ambient conditions at the time of measurement. That is, the value has not been converted."
            };
            zeroDegcOneAtm = 
                new StandardCondition("0 degC 1 atm")
                {
                    Description = "A temperature of zero degrees Centigrade and a pressure of one atmosphere."
            };
            oneFiveDegcOneAtm = 
                new StandardCondition("15 degC 1 atm")
                {
                    Description = "A temperature of sixty degrees Centigrade and a pressure of one atmosphere."
            };
            sixZeroDegfOneAtm = 
                new StandardCondition("60 degF 1 atm")
                {
                    Description = "A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere."
            };
            unknown = 
                new StandardCondition("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a StandardCondition by name
        /// </summary>
        /// <param name="name">The name of the StandardCondition to return</param>
        /// <returns>The StandardCondition represented by 'name'</returns>
        public static StandardCondition GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(StandardCondition)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(StandardCondition)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (StandardCondition)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static StandardTempPress zeroDegcOneAtm;
        /// <summary>
        /// A temperature of zero degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("0 degC 1 atm")]
        public static StandardTempPress ZeroDegcOneAtm
        {
            get 
            {
                return zeroDegcOneAtm;
            }
        }

        private readonly static StandardTempPress oneFiveDegcOneAtm;
        /// <summary>
        /// A temperature of sixty degrees Centigrade and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("15 degC 1 atm")]
        public static StandardTempPress OneFiveDegcOneAtm
        {
            get 
            {
                return oneFiveDegcOneAtm;
            }
        }

        private readonly static StandardTempPress sixZeroDegfOneAtm;
        /// <summary>
        /// A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere.
        /// </summary>
        [EnumValueNameAttribute("60 degF 1 atm")]
        public static StandardTempPress SixZeroDegfOneAtm
        {
            get 
            {
                return sixZeroDegfOneAtm;
            }
        }

        private readonly static StandardTempPress unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static StandardTempPress Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static StandardTempPress()
        {
            zeroDegcOneAtm = 
                new StandardTempPress("0 degC 1 atm")
                {
                    Description = "A temperature of zero degrees Centigrade and a pressure of one atmosphere."
            };
            oneFiveDegcOneAtm = 
                new StandardTempPress("15 degC 1 atm")
                {
                    Description = "A temperature of sixty degrees Centigrade and a pressure of one atmosphere."
            };
            sixZeroDegfOneAtm = 
                new StandardTempPress("60 degF 1 atm")
                {
                    Description = "A temperature of fifteen degrees Fahrenheit and a pressure of one atmosphere."
            };
            unknown = 
                new StandardTempPress("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a StandardTempPress by name
        /// </summary>
        /// <param name="name">The name of the StandardTempPress to return</param>
        /// <returns>The StandardTempPress represented by 'name'</returns>
        public static StandardTempPress GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(StandardTempPress)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(StandardTempPress)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (StandardTempPress)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///				The value is not known. This value should not be used
    ///				in normal situations. All reasonable attempts should be made to determine
    ///				the appropriate value. Use of this value may result in rejection in some situations.
    ///			
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

        private readonly static TestReason initial;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("initial")]
        public static TestReason Initial
        {
            get 
            {
                return initial;
            }
        }

        private readonly static TestReason periodic;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("periodic")]
        public static TestReason Periodic
        {
            get 
            {
                return periodic;
            }
        }

        private readonly static TestReason revision;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("revision")]
        public static TestReason Revision
        {
            get 
            {
                return revision;
            }
        }

        private readonly static TestReason other;
        /// <summary>
        /// 
        /// </summary>
        [EnumValueNameAttribute("other")]
        public static TestReason Other
        {
            get 
            {
                return other;
            }
        }

        private readonly static TestReason unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TestReason Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static TestReason()
        {
            initial = 
                new TestReason("initial")
                {
            };
            periodic = 
                new TestReason("periodic")
                {
            };
            revision = 
                new TestReason("revision")
                {
            };
            other = 
                new TestReason("other")
                {
            };
            unknown = 
                new TestReason("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a TestReason by name
        /// </summary>
        /// <param name="name">The name of the TestReason to return</param>
        /// <returns>The TestReason represented by 'name'</returns>
        public static TestReason GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(TestReason)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(TestReason)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (TestReason)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Keyword for defining keyword-value pairs in a time series.
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

        private readonly static TimeSeriesKeyword assetIdentifier;
        /// <summary>
        ///  A PRODML formatted URI identifier of the asset (facility) related to the value. This captures the kind of asset as well as the unique identifier of the asset within a specified context (the authority). The identifier may define a hierarchy of assets. 
        /// </summary>
        [EnumValueNameAttribute("asset identifier")]
        public static TimeSeriesKeyword AssetIdentifier
        {
            get 
            {
                return assetIdentifier;
            }
        }

        private readonly static TimeSeriesKeyword qualifier;
        /// <summary>
        ///  A qualifier of the meaning of the value. This is used to distinguish between variations of an underlying meaning based on the method of creating the value (e.g., measured versus simulated). The values associated with this keyword must be from the list defined by type FlowQualifier. 
        /// </summary>
        [EnumValueNameAttribute("qualifier")]
        public static TimeSeriesKeyword Qualifier
        {
            get 
            {
                return qualifier;
            }
        }

        private readonly static TimeSeriesKeyword subqualifier;
        /// <summary>
        ///  A specialization of a qualifier. The values associated with this keyword must be from the list defined by type FlowSubQualifier. 
        /// </summary>
        [EnumValueNameAttribute("subqualifier")]
        public static TimeSeriesKeyword Subqualifier
        {
            get 
            {
                return subqualifier;
            }
        }

        private readonly static TimeSeriesKeyword product;
        /// <summary>
        ///  The type of product that is represented by the value. This is generally used with things like volume or flow rate. It is generally meaningless for things like temperature or pressure. The values associated with this keyword must be from the list defined by type ReportingProduct. 
        /// </summary>
        [EnumValueNameAttribute("product")]
        public static TimeSeriesKeyword Product
        {
            get 
            {
                return product;
            }
        }

        private readonly static TimeSeriesKeyword flow;
        /// <summary>
        ///  Defines the part of the flow network where the asset is located. This is most useful in situations (e.g., reporting) where detailed knowledge of the network configuration is not needed. Basically, this classifies different segments of the flow network based on its purpose within the context of the whole network. The values associated with this keyword must be from the list defined by type ReportingFlow. 
        /// </summary>
        [EnumValueNameAttribute("flow")]
        public static TimeSeriesKeyword Flow
        {
            get 
            {
                return flow;
            }
        }

        private readonly static TimeSeriesKeyword unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static TimeSeriesKeyword Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static TimeSeriesKeyword()
        {
            assetIdentifier = 
                new TimeSeriesKeyword("asset identifier")
                {
                    Description = " A PRODML formatted URI identifier of the asset (facility) related to the value. This captures the kind of asset as well as the unique identifier of the asset within a specified context (the authority). The identifier may define a hierarchy of assets. "
            };
            qualifier = 
                new TimeSeriesKeyword("qualifier")
                {
                    Description = " A qualifier of the meaning of the value. This is used to distinguish between variations of an underlying meaning based on the method of creating the value (e.g., measured versus simulated). The values associated with this keyword must be from the list defined by type FlowQualifier. "
            };
            subqualifier = 
                new TimeSeriesKeyword("subqualifier")
                {
                    Description = " A specialization of a qualifier. The values associated with this keyword must be from the list defined by type FlowSubQualifier. "
            };
            product = 
                new TimeSeriesKeyword("product")
                {
                    Description = " The type of product that is represented by the value. This is generally used with things like volume or flow rate. It is generally meaningless for things like temperature or pressure. The values associated with this keyword must be from the list defined by type ReportingProduct. "
            };
            flow = 
                new TimeSeriesKeyword("flow")
                {
                    Description = " Defines the part of the flow network where the asset is located. This is most useful in situations (e.g., reporting) where detailed knowledge of the network configuration is not needed. Basically, this classifies different segments of the flow network based on its purpose within the context of the whole network. The values associated with this keyword must be from the list defined by type ReportingFlow. "
            };
            unknown = 
                new TimeSeriesKeyword("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a TimeSeriesKeyword by name
        /// </summary>
        /// <param name="name">The name of the TimeSeriesKeyword to return</param>
        /// <returns>The TimeSeriesKeyword represented by 'name'</returns>
        public static TimeSeriesKeyword GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(TimeSeriesKeyword)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(TimeSeriesKeyword)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (TimeSeriesKeyword)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ValidationOperation acquisitionValidation;
        /// <summary>
        /// Checks against the acquired data.
        /// </summary>
        [EnumValueNameAttribute("acquisition validation")]
        public static ValidationOperation AcquisitionValidation
        {
            get 
            {
                return acquisitionValidation;
            }
        }

        private readonly static ValidationOperation siteValidation;
        /// <summary>
        /// Checks against site validation criteria.
        /// </summary>
        [EnumValueNameAttribute("site validation")]
        public static ValidationOperation SiteValidation
        {
            get 
            {
                return siteValidation;
            }
        }

        private readonly static ValidationOperation allocationValidation;
        /// <summary>
        /// Checks against back-allocation validation criteria.
        /// </summary>
        [EnumValueNameAttribute("allocation validation")]
        public static ValidationOperation AllocationValidation
        {
            get 
            {
                return allocationValidation;
            }
        }

        private readonly static ValidationOperation externalQualityAssurance;
        /// <summary>
        ///  Checks against external quality assurance criteria. This operation must not have a result of "passed with changes". 
        /// </summary>
        [EnumValueNameAttribute("external quality assurance")]
        public static ValidationOperation ExternalQualityAssurance
        {
            get 
            {
                return externalQualityAssurance;
            }
        }

        private readonly static ValidationOperation validationResult;
        /// <summary>
        /// The overall status of the test.
        /// </summary>
        [EnumValueNameAttribute("validation result")]
        public static ValidationOperation ValidationResult
        {
            get 
            {
                return validationResult;
            }
        }

        private readonly static ValidationOperation wellModelValidation;
        /// <summary>
        ///  Checks against a well model. This operation must not have a result of "passed with changes". 
        /// </summary>
        [EnumValueNameAttribute("well model validation")]
        public static ValidationOperation WellModelValidation
        {
            get 
            {
                return wellModelValidation;
            }
        }

        private readonly static ValidationOperation unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValidationOperation Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ValidationOperation()
        {
            acquisitionValidation = 
                new ValidationOperation("acquisition validation")
                {
                    Description = "Checks against the acquired data."
            };
            siteValidation = 
                new ValidationOperation("site validation")
                {
                    Description = "Checks against site validation criteria."
            };
            allocationValidation = 
                new ValidationOperation("allocation validation")
                {
                    Description = "Checks against back-allocation validation criteria."
            };
            externalQualityAssurance = 
                new ValidationOperation("external quality assurance")
                {
                    Description = " Checks against external quality assurance criteria. This operation must not have a result of \"passed with changes\". "
            };
            validationResult = 
                new ValidationOperation("validation result")
                {
                    Description = "The overall status of the test."
            };
            wellModelValidation = 
                new ValidationOperation("well model validation")
                {
                    Description = " Checks against a well model. This operation must not have a result of \"passed with changes\". "
            };
            unknown = 
                new ValidationOperation("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ValidationOperation by name
        /// </summary>
        /// <param name="name">The name of the ValidationOperation to return</param>
        /// <returns>The ValidationOperation represented by 'name'</returns>
        public static ValidationOperation GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ValidationOperation)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ValidationOperation)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ValidationOperation)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ValidationResult passed;
        /// <summary>
        /// The well test passed the validation criteria without modification of the data.
        /// </summary>
        [EnumValueNameAttribute("passed")]
        public static ValidationResult Passed
        {
            get 
            {
                return passed;
            }
        }

        private readonly static ValidationResult passedWithChanges;
        /// <summary>
        /// The well test passed the validation criteria after modification of the data.
        /// </summary>
        [EnumValueNameAttribute("passed with changes")]
        public static ValidationResult PassedWithChanges
        {
            get 
            {
                return passedWithChanges;
            }
        }

        private readonly static ValidationResult failed;
        /// <summary>
        /// The well test failed the validation criteria.
        /// </summary>
        [EnumValueNameAttribute("failed")]
        public static ValidationResult Failed
        {
            get 
            {
                return failed;
            }
        }

        private readonly static ValidationResult unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValidationResult Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ValidationResult()
        {
            passed = 
                new ValidationResult("passed")
                {
                    Description = "The well test passed the validation criteria without modification of the data."
            };
            passedWithChanges = 
                new ValidationResult("passed with changes")
                {
                    Description = "The well test passed the validation criteria after modification of the data."
            };
            failed = 
                new ValidationResult("failed")
                {
                    Description = "The well test failed the validation criteria."
            };
            unknown = 
                new ValidationResult("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ValidationResult by name
        /// </summary>
        /// <param name="name">The name of the ValidationResult to return</param>
        /// <returns>The ValidationResult represented by 'name'</returns>
        public static ValidationResult GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ValidationResult)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ValidationResult)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ValidationResult)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static ValidationState unvalidated;
        /// <summary>
        /// The well test has not yet begun validation operations.
        /// </summary>
        [EnumValueNameAttribute("unvalidated")]
        public static ValidationState Unvalidated
        {
            get 
            {
                return unvalidated;
            }
        }

        private readonly static ValidationState validating;
        /// <summary>
        /// The well test is in the process of being validated.
        /// </summary>
        [EnumValueNameAttribute("validating")]
        public static ValidationState Validating
        {
            get 
            {
                return validating;
            }
        }

        private readonly static ValidationState validated;
        /// <summary>
        ///  The well test has completed validation operations. This does not mean that the test is valid - only that the validation steps have been completed. 
        /// </summary>
        [EnumValueNameAttribute("validated")]
        public static ValidationState Validated
        {
            get 
            {
                return validated;
            }
        }

        private readonly static ValidationState unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValidationState Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ValidationState()
        {
            unvalidated = 
                new ValidationState("unvalidated")
                {
                    Description = "The well test has not yet begun validation operations."
            };
            validating = 
                new ValidationState("validating")
                {
                    Description = "The well test is in the process of being validated."
            };
            validated = 
                new ValidationState("validated")
                {
                    Description = " The well test has completed validation operations. This does not mean that the test is valid - only that the validation steps have been completed. "
            };
            unknown = 
                new ValidationState("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ValidationState by name
        /// </summary>
        /// <param name="name">The name of the ValidationState to return</param>
        /// <returns>The ValidationState represented by 'name'</returns>
        public static ValidationState GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ValidationState)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ValidationState)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ValidationState)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			An indicator of the quality of a value.
    ///			This is designed for a SCADA or OPC style of value status.
    ///			The token in parentheses are OPC's status string for the condition.
    ///		
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

        private readonly static ValueStatus badCalibration;
        /// <summary>
        ///  The calibration status of the sensor is unknown. (Out of Calibration) 
        /// </summary>
        [EnumValueNameAttribute("bad calibration")]
        public static ValueStatus BadCalibration
        {
            get 
            {
                return badCalibration;
            }
        }

        private readonly static ValueStatus rangeLimit;
        /// <summary>
        ///  The value is range limited, that is, at or near the end of range of the sensor. The value might be clamped. (Low Limited, High Limited) 
        /// </summary>
        [EnumValueNameAttribute("range limit")]
        public static ValueStatus RangeLimit
        {
            get 
            {
                return rangeLimit;
            }
        }

        private readonly static ValueStatus questionable;
        /// <summary>
        ///  The value is just plain questionable. (Sub-Normal, Non-specific) 
        /// </summary>
        [EnumValueNameAttribute("questionable")]
        public static ValueStatus Questionable
        {
            get 
            {
                return questionable;
            }
        }

        private readonly static ValueStatus deviceFailure;
        /// <summary>
        ///  The unit to which the sensor is attached is not running. (Device Failure) 
        /// </summary>
        [EnumValueNameAttribute("device failure")]
        public static ValueStatus DeviceFailure
        {
            get 
            {
                return deviceFailure;
            }
        }

        private readonly static ValueStatus sensorFailure;
        /// <summary>
        ///  The field sensor itself is not working due to hardware failure or misconfiguration. (Sensor Failure) 
        /// </summary>
        [EnumValueNameAttribute("sensor failure")]
        public static ValueStatus SensorFailure
        {
            get 
            {
                return sensorFailure;
            }
        }

        private readonly static ValueStatus commFailure;
        /// <summary>
        ///  The communication to the field sensor is not working. That is, communication cannot be established or maintained. (Comm Failure) 
        /// </summary>
        [EnumValueNameAttribute("comm failure")]
        public static ValueStatus CommFailure
        {
            get 
            {
                return commFailure;
            }
        }

        private readonly static ValueStatus timeout;
        /// <summary>
        ///  Communication to the field sensor has timed out, that is, a connection exists, but a request for a field sensor data value has failed. (Last Known Value) 
        /// </summary>
        [EnumValueNameAttribute("timeout")]
        public static ValueStatus Timeout
        {
            get 
            {
                return timeout;
            }
        }

        private readonly static ValueStatus frozen;
        /// <summary>
        ///  The value has a frozen status - i.e. the sensor has been reading the same value for a specific period of time. Value is required. 
        /// </summary>
        [EnumValueNameAttribute("frozen")]
        public static ValueStatus Frozen
        {
            get 
            {
                return frozen;
            }
        }

        private readonly static ValueStatus substituted;
        /// <summary>
        ///  This value has been manually input by the operator. Value is required. (Local Override) 
        /// </summary>
        [EnumValueNameAttribute("substituted")]
        public static ValueStatus Substituted
        {
            get 
            {
                return substituted;
            }
        }

        private readonly static ValueStatus bad;
        /// <summary>
        ///  The value is bad for an unknown reason. Value is required. (Non-Specific) 
        /// </summary>
        [EnumValueNameAttribute("bad")]
        public static ValueStatus Bad
        {
            get 
            {
                return bad;
            }
        }

        private readonly static ValueStatus overflow;
        /// <summary>
        ///  There is an overflow indicated (conversion process). Resulting from a calculation. Value may be NaN. 
        /// </summary>
        [EnumValueNameAttribute("overflow")]
        public static ValueStatus Overflow
        {
            get 
            {
                return overflow;
            }
        }

        private readonly static ValueStatus calculationFailure;
        /// <summary>
        /// The calculation for the value indicates failure. Value may be NaN.
        /// </summary>
        [EnumValueNameAttribute("calculation failure")]
        public static ValueStatus CalculationFailure
        {
            get 
            {
                return calculationFailure;
            }
        }

        private readonly static ValueStatus notAvailable;
        /// <summary>
        ///  The input is not available. Value may be NaN. May be device, sensor, or comm failure, but the exact reason is unknown. 
        /// </summary>
        [EnumValueNameAttribute("not available")]
        public static ValueStatus NotAvailable
        {
            get 
            {
                return notAvailable;
            }
        }

        private readonly static ValueStatus accessDenied;
        /// <summary>
        /// Access denied for this point. Value may be NaN.
        /// </summary>
        [EnumValueNameAttribute("access denied")]
        public static ValueStatus AccessDenied
        {
            get 
            {
                return accessDenied;
            }
        }

        private readonly static ValueStatus unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static ValueStatus Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static ValueStatus()
        {
            badCalibration = 
                new ValueStatus("bad calibration")
                {
                    Description = " The calibration status of the sensor is unknown. (Out of Calibration) "
            };
            rangeLimit = 
                new ValueStatus("range limit")
                {
                    Description = " The value is range limited, that is, at or near the end of range of the sensor. The value might be clamped. (Low Limited, High Limited) "
            };
            questionable = 
                new ValueStatus("questionable")
                {
                    Description = " The value is just plain questionable. (Sub-Normal, Non-specific) "
            };
            deviceFailure = 
                new ValueStatus("device failure")
                {
                    Description = " The unit to which the sensor is attached is not running. (Device Failure) "
            };
            sensorFailure = 
                new ValueStatus("sensor failure")
                {
                    Description = " The field sensor itself is not working due to hardware failure or misconfiguration. (Sensor Failure) "
            };
            commFailure = 
                new ValueStatus("comm failure")
                {
                    Description = " The communication to the field sensor is not working. That is, communication cannot be established or maintained. (Comm Failure) "
            };
            timeout = 
                new ValueStatus("timeout")
                {
                    Description = " Communication to the field sensor has timed out, that is, a connection exists, but a request for a field sensor data value has failed. (Last Known Value) "
            };
            frozen = 
                new ValueStatus("frozen")
                {
                    Description = " The value has a frozen status - i.e. the sensor has been reading the same value for a specific period of time. Value is required. "
            };
            substituted = 
                new ValueStatus("substituted")
                {
                    Description = " This value has been manually input by the operator. Value is required. (Local Override) "
            };
            bad = 
                new ValueStatus("bad")
                {
                    Description = " The value is bad for an unknown reason. Value is required. (Non-Specific) "
            };
            overflow = 
                new ValueStatus("overflow")
                {
                    Description = " There is an overflow indicated (conversion process). Resulting from a calculation. Value may be NaN. "
            };
            calculationFailure = 
                new ValueStatus("calculation failure")
                {
                    Description = "The calculation for the value indicates failure. Value may be NaN."
            };
            notAvailable = 
                new ValueStatus("not available")
                {
                    Description = " The input is not available. Value may be NaN. May be device, sensor, or comm failure, but the exact reason is unknown. "
            };
            accessDenied = 
                new ValueStatus("access denied")
                {
                    Description = "Access denied for this point. Value may be NaN."
            };
            unknown = 
                new ValueStatus("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a ValueStatus by name
        /// </summary>
        /// <param name="name">The name of the ValueStatus to return</param>
        /// <returns>The ValueStatus represented by 'name'</returns>
        public static ValueStatus GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(ValueStatus)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(ValueStatus)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (ValueStatus)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// Defines the conditions at which the volume is measured
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

        private readonly static VolumeReferenceKind initialReservoir;
        /// <summary>
        /// The volume is measured at initial reservoir conditions
        /// </summary>
        [EnumValueNameAttribute("initial reservoir")]
        public static VolumeReferenceKind InitialReservoir
        {
            get 
            {
                return initialReservoir;
            }
        }

        private readonly static VolumeReferenceKind saturationmeasured;
        /// <summary>
        /// The volume is measured at saturation conditions
        /// </summary>
        [EnumValueNameAttribute("saturation-measured")]
        public static VolumeReferenceKind Saturationmeasured
        {
            get 
            {
                return saturationmeasured;
            }
        }

        private readonly static VolumeReferenceKind saturationcalculated;
        /// <summary>
        /// The volume is calculated rather than measured, at saturation conditions
        /// </summary>
        [EnumValueNameAttribute("saturation-calculated")]
        public static VolumeReferenceKind Saturationcalculated
        {
            get 
            {
                return saturationcalculated;
            }
        }

        private readonly static VolumeReferenceKind stockTank;
        /// <summary>
        /// The volume is measured at stock tank conditions
        /// </summary>
        [EnumValueNameAttribute("stock tank")]
        public static VolumeReferenceKind StockTank
        {
            get 
            {
                return stockTank;
            }
        }

        private readonly static VolumeReferenceKind currentSeparatorStage;
        /// <summary>
        /// The volume is measured at the current separator conditions
        /// </summary>
        [EnumValueNameAttribute("current separator stage")]
        public static VolumeReferenceKind CurrentSeparatorStage
        {
            get 
            {
                return currentSeparatorStage;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOne;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 1")]
        public static VolumeReferenceKind SeparatorStageOne
        {
            get 
            {
                return separatorStageOne;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwo;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 2")]
        public static VolumeReferenceKind SeparatorStageTwo
        {
            get 
            {
                return separatorStageTwo;
            }
        }

        private readonly static VolumeReferenceKind separatorStageThree;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 3")]
        public static VolumeReferenceKind SeparatorStageThree
        {
            get 
            {
                return separatorStageThree;
            }
        }

        private readonly static VolumeReferenceKind separatorStageFour;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 4")]
        public static VolumeReferenceKind SeparatorStageFour
        {
            get 
            {
                return separatorStageFour;
            }
        }

        private readonly static VolumeReferenceKind separatorStageFive;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 5")]
        public static VolumeReferenceKind SeparatorStageFive
        {
            get 
            {
                return separatorStageFive;
            }
        }

        private readonly static VolumeReferenceKind separatorStageSix;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 6")]
        public static VolumeReferenceKind SeparatorStageSix
        {
            get 
            {
                return separatorStageSix;
            }
        }

        private readonly static VolumeReferenceKind separatorStageSeven;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 7")]
        public static VolumeReferenceKind SeparatorStageSeven
        {
            get 
            {
                return separatorStageSeven;
            }
        }

        private readonly static VolumeReferenceKind separatorStageEight;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 8")]
        public static VolumeReferenceKind SeparatorStageEight
        {
            get 
            {
                return separatorStageEight;
            }
        }

        private readonly static VolumeReferenceKind separatorStageNine;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 9")]
        public static VolumeReferenceKind SeparatorStageNine
        {
            get 
            {
                return separatorStageNine;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneZero;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 10")]
        public static VolumeReferenceKind SeparatorStageOneZero
        {
            get 
            {
                return separatorStageOneZero;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneOne;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 11")]
        public static VolumeReferenceKind SeparatorStageOneOne
        {
            get 
            {
                return separatorStageOneOne;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneTwo;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 12")]
        public static VolumeReferenceKind SeparatorStageOneTwo
        {
            get 
            {
                return separatorStageOneTwo;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneThree;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 13")]
        public static VolumeReferenceKind SeparatorStageOneThree
        {
            get 
            {
                return separatorStageOneThree;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneFour;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 14")]
        public static VolumeReferenceKind SeparatorStageOneFour
        {
            get 
            {
                return separatorStageOneFour;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneFive;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 15")]
        public static VolumeReferenceKind SeparatorStageOneFive
        {
            get 
            {
                return separatorStageOneFive;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneSix;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 16")]
        public static VolumeReferenceKind SeparatorStageOneSix
        {
            get 
            {
                return separatorStageOneSix;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneSeven;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 17")]
        public static VolumeReferenceKind SeparatorStageOneSeven
        {
            get 
            {
                return separatorStageOneSeven;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneEight;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 18")]
        public static VolumeReferenceKind SeparatorStageOneEight
        {
            get 
            {
                return separatorStageOneEight;
            }
        }

        private readonly static VolumeReferenceKind separatorStageOneNine;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 19")]
        public static VolumeReferenceKind SeparatorStageOneNine
        {
            get 
            {
                return separatorStageOneNine;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoZero;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 20")]
        public static VolumeReferenceKind SeparatorStageTwoZero
        {
            get 
            {
                return separatorStageTwoZero;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoOne;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 21")]
        public static VolumeReferenceKind SeparatorStageTwoOne
        {
            get 
            {
                return separatorStageTwoOne;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoTwo;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 22")]
        public static VolumeReferenceKind SeparatorStageTwoTwo
        {
            get 
            {
                return separatorStageTwoTwo;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoThree;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 23")]
        public static VolumeReferenceKind SeparatorStageTwoThree
        {
            get 
            {
                return separatorStageTwoThree;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoFour;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 24")]
        public static VolumeReferenceKind SeparatorStageTwoFour
        {
            get 
            {
                return separatorStageTwoFour;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoFive;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 25")]
        public static VolumeReferenceKind SeparatorStageTwoFive
        {
            get 
            {
                return separatorStageTwoFive;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoSix;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 26")]
        public static VolumeReferenceKind SeparatorStageTwoSix
        {
            get 
            {
                return separatorStageTwoSix;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoSeven;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 27")]
        public static VolumeReferenceKind SeparatorStageTwoSeven
        {
            get 
            {
                return separatorStageTwoSeven;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoEight;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 28")]
        public static VolumeReferenceKind SeparatorStageTwoEight
        {
            get 
            {
                return separatorStageTwoEight;
            }
        }

        private readonly static VolumeReferenceKind separatorStageTwoNine;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 29")]
        public static VolumeReferenceKind SeparatorStageTwoNine
        {
            get 
            {
                return separatorStageTwoNine;
            }
        }

        private readonly static VolumeReferenceKind separatorStageThreeZero;
        /// <summary>
        /// The volume is measured at the numbered separator stage conditions
        /// </summary>
        [EnumValueNameAttribute("separator stage 30")]
        public static VolumeReferenceKind SeparatorStageThreeZero
        {
            get 
            {
                return separatorStageThreeZero;
            }
        }

        private readonly static VolumeReferenceKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static VolumeReferenceKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static VolumeReferenceKind()
        {
            initialReservoir = 
                new VolumeReferenceKind("initial reservoir")
                {
                    Description = "The volume is measured at initial reservoir conditions"
            };
            saturationmeasured = 
                new VolumeReferenceKind("saturation-measured")
                {
                    Description = "The volume is measured at saturation conditions"
            };
            saturationcalculated = 
                new VolumeReferenceKind("saturation-calculated")
                {
                    Description = "The volume is calculated rather than measured, at saturation conditions"
            };
            stockTank = 
                new VolumeReferenceKind("stock tank")
                {
                    Description = "The volume is measured at stock tank conditions"
            };
            currentSeparatorStage = 
                new VolumeReferenceKind("current separator stage")
                {
                    Description = "The volume is measured at the current separator conditions"
            };
            separatorStageOne = 
                new VolumeReferenceKind("separator stage 1")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwo = 
                new VolumeReferenceKind("separator stage 2")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageThree = 
                new VolumeReferenceKind("separator stage 3")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageFour = 
                new VolumeReferenceKind("separator stage 4")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageFive = 
                new VolumeReferenceKind("separator stage 5")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageSix = 
                new VolumeReferenceKind("separator stage 6")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageSeven = 
                new VolumeReferenceKind("separator stage 7")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageEight = 
                new VolumeReferenceKind("separator stage 8")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageNine = 
                new VolumeReferenceKind("separator stage 9")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneZero = 
                new VolumeReferenceKind("separator stage 10")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneOne = 
                new VolumeReferenceKind("separator stage 11")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneTwo = 
                new VolumeReferenceKind("separator stage 12")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneThree = 
                new VolumeReferenceKind("separator stage 13")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneFour = 
                new VolumeReferenceKind("separator stage 14")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneFive = 
                new VolumeReferenceKind("separator stage 15")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneSix = 
                new VolumeReferenceKind("separator stage 16")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneSeven = 
                new VolumeReferenceKind("separator stage 17")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneEight = 
                new VolumeReferenceKind("separator stage 18")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageOneNine = 
                new VolumeReferenceKind("separator stage 19")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoZero = 
                new VolumeReferenceKind("separator stage 20")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoOne = 
                new VolumeReferenceKind("separator stage 21")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoTwo = 
                new VolumeReferenceKind("separator stage 22")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoThree = 
                new VolumeReferenceKind("separator stage 23")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoFour = 
                new VolumeReferenceKind("separator stage 24")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoFive = 
                new VolumeReferenceKind("separator stage 25")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoSix = 
                new VolumeReferenceKind("separator stage 26")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoSeven = 
                new VolumeReferenceKind("separator stage 27")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoEight = 
                new VolumeReferenceKind("separator stage 28")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageTwoNine = 
                new VolumeReferenceKind("separator stage 29")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            separatorStageThreeZero = 
                new VolumeReferenceKind("separator stage 30")
                {
                    Description = "The volume is measured at the numbered separator stage conditions"
            };
            unknown = 
                new VolumeReferenceKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a VolumeReferenceKind by name
        /// </summary>
        /// <param name="name">The name of the VolumeReferenceKind to return</param>
        /// <returns>The VolumeReferenceKind represented by 'name'</returns>
        public static VolumeReferenceKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(VolumeReferenceKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(VolumeReferenceKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (VolumeReferenceKind)ev;
                    }
                }
            }
            
            return null;
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

        private readonly static WellOperationMethod naturalFlow;
        /// <summary>
        /// Oil or gas well under natural flow.
        /// </summary>
        [EnumValueNameAttribute("natural flow")]
        public static WellOperationMethod NaturalFlow
        {
            get 
            {
                return naturalFlow;
            }
        }

        private readonly static WellOperationMethod continuousGasLift;
        /// <summary>
        /// Oil well under continuous gas lift.
        /// </summary>
        [EnumValueNameAttribute("continuous gas lift")]
        public static WellOperationMethod ContinuousGasLift
        {
            get 
            {
                return continuousGasLift;
            }
        }

        private readonly static WellOperationMethod intermittentGasLift;
        /// <summary>
        /// Oil well under intermittent gas lift.
        /// </summary>
        [EnumValueNameAttribute("intermittent gas lift")]
        public static WellOperationMethod IntermittentGasLift
        {
            get 
            {
                return intermittentGasLift;
            }
        }

        private readonly static WellOperationMethod plungerGasLift;
        /// <summary>
        /// Oil or gas well under plunger gas lift.
        /// </summary>
        [EnumValueNameAttribute("plunger gas lift")]
        public static WellOperationMethod PlungerGasLift
        {
            get 
            {
                return plungerGasLift;
            }
        }

        private readonly static WellOperationMethod electricSubmersiblePumpLift;
        /// <summary>
        /// Oil well under electric submersible pump lift.
        /// </summary>
        [EnumValueNameAttribute("electric submersible pump lift")]
        public static WellOperationMethod ElectricSubmersiblePumpLift
        {
            get 
            {
                return electricSubmersiblePumpLift;
            }
        }

        private readonly static WellOperationMethod progressiveCavityPumpLift;
        /// <summary>
        /// Oil well under progressive cavity pump lift.
        /// </summary>
        [EnumValueNameAttribute("progressive cavity pump lift")]
        public static WellOperationMethod ProgressiveCavityPumpLift
        {
            get 
            {
                return progressiveCavityPumpLift;
            }
        }

        private readonly static WellOperationMethod hydraulicPumpLift;
        /// <summary>
        /// Oil well under hydraulic pump lift.
        /// </summary>
        [EnumValueNameAttribute("hydraulic pump lift")]
        public static WellOperationMethod HydraulicPumpLift
        {
            get 
            {
                return hydraulicPumpLift;
            }
        }

        private readonly static WellOperationMethod suckerRodPumpLift;
        /// <summary>
        /// Oil well under sucker rod pump lift.
        /// </summary>
        [EnumValueNameAttribute("sucker rod pump lift")]
        public static WellOperationMethod SuckerRodPumpLift
        {
            get 
            {
                return suckerRodPumpLift;
            }
        }

        private readonly static WellOperationMethod jetPumpLift;
        /// <summary>
        /// Oil well under jet pump lift.
        /// </summary>
        [EnumValueNameAttribute("jet pump lift")]
        public static WellOperationMethod JetPumpLift
        {
            get 
            {
                return jetPumpLift;
            }
        }

        private readonly static WellOperationMethod foamLift;
        /// <summary>
        /// Gas well under foam lift.
        /// </summary>
        [EnumValueNameAttribute("foam lift")]
        public static WellOperationMethod FoamLift
        {
            get 
            {
                return foamLift;
            }
        }

        private readonly static WellOperationMethod unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WellOperationMethod Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static WellOperationMethod()
        {
            naturalFlow = 
                new WellOperationMethod("natural flow")
                {
                    Description = "Oil or gas well under natural flow."
            };
            continuousGasLift = 
                new WellOperationMethod("continuous gas lift")
                {
                    Description = "Oil well under continuous gas lift."
            };
            intermittentGasLift = 
                new WellOperationMethod("intermittent gas lift")
                {
                    Description = "Oil well under intermittent gas lift."
            };
            plungerGasLift = 
                new WellOperationMethod("plunger gas lift")
                {
                    Description = "Oil or gas well under plunger gas lift."
            };
            electricSubmersiblePumpLift = 
                new WellOperationMethod("electric submersible pump lift")
                {
                    Description = "Oil well under electric submersible pump lift."
            };
            progressiveCavityPumpLift = 
                new WellOperationMethod("progressive cavity pump lift")
                {
                    Description = "Oil well under progressive cavity pump lift."
            };
            hydraulicPumpLift = 
                new WellOperationMethod("hydraulic pump lift")
                {
                    Description = "Oil well under hydraulic pump lift."
            };
            suckerRodPumpLift = 
                new WellOperationMethod("sucker rod pump lift")
                {
                    Description = "Oil well under sucker rod pump lift."
            };
            jetPumpLift = 
                new WellOperationMethod("jet pump lift")
                {
                    Description = "Oil well under jet pump lift."
            };
            foamLift = 
                new WellOperationMethod("foam lift")
                {
                    Description = "Gas well under foam lift."
            };
            unknown = 
                new WellOperationMethod("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a WellOperationMethod by name
        /// </summary>
        /// <param name="name">The name of the WellOperationMethod to return</param>
        /// <returns>The WellOperationMethod represented by 'name'</returns>
        public static WellOperationMethod GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(WellOperationMethod)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(WellOperationMethod)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (WellOperationMethod)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			This is used to characterize the kind of connection between the
    ///			wireline formation tester tool (WFT) and the formation via a section of wellbore.
    ///			Since WFTs can have probes or pairs of packers, which have different geometries
    ///			(respectively a point connection or a section of wellbore like a welltest),
    ///			it is necessary to state which kind if flowing for this station.
    ///		
    /// </summary>
    public class WftFlowingIntervalKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected WftFlowingIntervalKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the WftFlowingIntervalKind</param>
        public WftFlowingIntervalKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of WftFlowingIntervalKinds
        /// </summary>
        /// <returns>The complete list of WftFlowingIntervalKinds</returns>
        public static List<WftFlowingIntervalKind> GetList()
        {
            return GetList<WftFlowingIntervalKind>();
        }

        private readonly static WftFlowingIntervalKind probe;
        /// <summary>
        ///  This is used to identify a probe connection between reservoir and WFT tool. 
        /// </summary>
        [EnumValueNameAttribute("probe")]
        public static WftFlowingIntervalKind Probe
        {
            get 
            {
                return probe;
            }
        }

        private readonly static WftFlowingIntervalKind packedInterval;
        /// <summary>
        ///  This is to identify a connection between reservoir and WFT tool which is between a pair of packers, ie akin to the flow connection of a traditional drill stem test (DST) though usually on a smaller scale. 
        /// </summary>
        [EnumValueNameAttribute("packed interval")]
        public static WftFlowingIntervalKind PackedInterval
        {
            get 
            {
                return packedInterval;
            }
        }

        private readonly static WftFlowingIntervalKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WftFlowingIntervalKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static WftFlowingIntervalKind()
        {
            probe = 
                new WftFlowingIntervalKind("probe")
                {
                    Description = " This is used to identify a probe connection between reservoir and WFT tool. "
            };
            packedInterval = 
                new WftFlowingIntervalKind("packed interval")
                {
                    Description = " This is to identify a connection between reservoir and WFT tool which is between a pair of packers, ie akin to the flow connection of a traditional drill stem test (DST) though usually on a smaller scale. "
            };
            unknown = 
                new WftFlowingIntervalKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a WftFlowingIntervalKind by name
        /// </summary>
        /// <param name="name">The name of the WftFlowingIntervalKind to return</param>
        /// <returns>The WftFlowingIntervalKind represented by 'name'</returns>
        public static WftFlowingIntervalKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(WftFlowingIntervalKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(WftFlowingIntervalKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (WftFlowingIntervalKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			This is used to identify events occurring during the operation of a
    ///			wireline formation tester (WFT) at a given station (i.e. a temporary fixed position
    ///			in the wellbore where a series of tests will be made).  This list could be expanded
    ///			in future.  Two basic events are documented.
    ///		
    /// </summary>
    public class WftEventKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected WftEventKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the WftEventKind</param>
        public WftEventKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of WftEventKinds
        /// </summary>
        /// <returns>The complete list of WftEventKinds</returns>
        public static List<WftEventKind> GetList()
        {
            return GetList<WftEventKind>();
        }

        private readonly static WftEventKind toolSet;
        /// <summary>
        ///  This event describes the process of setting the WFT tool prior to tests being made at the station. 
        /// </summary>
        [EnumValueNameAttribute("tool set")]
        public static WftEventKind ToolSet
        {
            get 
            {
                return toolSet;
            }
        }

        private readonly static WftEventKind toolRetract;
        /// <summary>
        ///  This event describes the process of retracting the WFT tool after tests being made at the station, ready to move to another station or be retrieved from the wellbore. 
        /// </summary>
        [EnumValueNameAttribute("tool retract")]
        public static WftEventKind ToolRetract
        {
            get 
            {
                return toolRetract;
            }
        }

        private readonly static WftEventKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WftEventKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static WftEventKind()
        {
            toolSet = 
                new WftEventKind("tool set")
                {
                    Description = " This event describes the process of setting the WFT tool prior to tests being made at the station. "
            };
            toolRetract = 
                new WftEventKind("tool retract")
                {
                    Description = " This event describes the process of retracting the WFT tool after tests being made at the station, ready to move to another station or be retrieved from the wellbore. "
            };
            unknown = 
                new WftEventKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a WftEventKind by name
        /// </summary>
        /// <param name="name">The name of the WftEventKind to return</param>
        /// <returns>The WftEventKind represented by 'name'</returns>
        public static WftEventKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(WftEventKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(WftEventKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (WftEventKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			This is used to characterize the kind of station.  Two kinds are expected:
    ///			conventional where flow is occurring and being measured, and observation where there is
    ///			no flow and merely pressure observation of the effect at this station of flow which is
    ///			occurring at a different station.
    ///		
    /// </summary>
    public class WftStationKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected WftStationKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the WftStationKind</param>
        public WftStationKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of WftStationKinds
        /// </summary>
        /// <returns>The complete list of WftStationKinds</returns>
        public static List<WftStationKind> GetList()
        {
            return GetList<WftStationKind>();
        }

        private readonly static WftStationKind conventional;
        /// <summary>
        ///  This is used to identify a station where flow is occurring and being measured, such as pressure, temperature and flowrate. 
        /// </summary>
        [EnumValueNameAttribute("conventional")]
        public static WftStationKind Conventional
        {
            get 
            {
                return conventional;
            }
        }

        private readonly static WftStationKind observation;
        /// <summary>
        ///  This is used to identify a station where there is no flow occurring but the WFT tool is set and making pressure observation of the effect at this station of flow which is occurring at a different station. 
        /// </summary>
        [EnumValueNameAttribute("observation")]
        public static WftStationKind Observation
        {
            get 
            {
                return observation;
            }
        }

        private readonly static WftStationKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WftStationKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static WftStationKind()
        {
            conventional = 
                new WftStationKind("conventional")
                {
                    Description = " This is used to identify a station where flow is occurring and being measured, such as pressure, temperature and flowrate. "
            };
            observation = 
                new WftStationKind("observation")
                {
                    Description = " This is used to identify a station where there is no flow occurring but the WFT tool is set and making pressure observation of the effect at this station of flow which is occurring at a different station. "
            };
            unknown = 
                new WftStationKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a WftStationKind by name
        /// </summary>
        /// <param name="name">The name of the WftStationKind to return</param>
        /// <returns>The WftStationKind represented by 'name'</returns>
        public static WftStationKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(WftStationKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(WftStationKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (WftStationKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			This is used to characterize the kind of Test being carried out at a given time at
    ///			a given station by a wireline formation tester (WFT). This list could be expanded
    ///			in future.  Two basic tests are documented.
    ///		
    /// </summary>
    public class WftTestKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected WftTestKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the WftTestKind</param>
        public WftTestKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of WftTestKinds
        /// </summary>
        /// <returns>The complete list of WftTestKinds</returns>
        public static List<WftTestKind> GetList()
        {
            return GetList<WftTestKind>();
        }

        private readonly static WftTestKind drawdown;
        /// <summary>
        ///  A drawdown test is where reservoir fluid is flowing into the WFT tool via a connection described by the flowing interval kind element. 
        /// </summary>
        [EnumValueNameAttribute("drawdown")]
        public static WftTestKind Drawdown
        {
            get 
            {
                return drawdown;
            }
        }

        private readonly static WftTestKind buildup;
        /// <summary>
        ///  A build up test is where there is no flow of reservoir fluid into the WFT tool, but because the connection described by the flowing interval kind element remains in place, the WFT tool is measuring the pressure in the reservoir at the sandface (ie the inside face of the wellbore). A buildup must be preceded by one or more drawdowns (during which the sandface pressure will have dropped), and during the buildup the pressure will rise again. Hence the name, buildup. 
        /// </summary>
        [EnumValueNameAttribute("buildup")]
        public static WftTestKind Buildup
        {
            get 
            {
                return buildup;
            }
        }

        private readonly static WftTestKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WftTestKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static WftTestKind()
        {
            drawdown = 
                new WftTestKind("drawdown")
                {
                    Description = " A drawdown test is where reservoir fluid is flowing into the WFT tool via a connection described by the flowing interval kind element. "
            };
            buildup = 
                new WftTestKind("buildup")
                {
                    Description = " A build up test is where there is no flow of reservoir fluid into the WFT tool, but because the connection described by the flowing interval kind element remains in place, the WFT tool is measuring the pressure in the reservoir at the sandface (ie the inside face of the wellbore). A buildup must be preceded by one or more drawdowns (during which the sandface pressure will have dropped), and during the buildup the pressure will rise again. Hence the name, buildup. "
            };
            unknown = 
                new WftTestKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a WftTestKind by name
        /// </summary>
        /// <param name="name">The name of the WftTestKind to return</param>
        /// <returns>The WftTestKind represented by 'name'</returns>
        public static WftTestKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(WftTestKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(WftTestKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (WftTestKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			This is used to characterize the kind of test result. The kind of result typically
    ///			represents a combination of test kind and analysis method applied. This list could be expanded
    ///			in future. Two illustrative result kinds are documented.
    ///		
    /// </summary>
    public class WftTestResultKind : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected WftTestResultKind(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the WftTestResultKind</param>
        public WftTestResultKind(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of WftTestResultKinds
        /// </summary>
        /// <returns>The complete list of WftTestResultKinds</returns>
        public static List<WftTestResultKind> GetList()
        {
            return GetList<WftTestResultKind>();
        }

        private readonly static WftTestResultKind buildupResult;
        /// <summary>
        ///  This refers to the result of analysis of a buildup. More specialist buildup results could be added to the enum list such as buildup horner analysis, etc. 
        /// </summary>
        [EnumValueNameAttribute("buildup result")]
        public static WftTestResultKind BuildupResult
        {
            get 
            {
                return buildupResult;
            }
        }

        private readonly static WftTestResultKind drawdownResult;
        /// <summary>
        /// This refers to the result of analysis of a drawdown.
        /// </summary>
        [EnumValueNameAttribute("drawdown result")]
        public static WftTestResultKind DrawdownResult
        {
            get 
            {
                return drawdownResult;
            }
        }

        private readonly static WftTestResultKind unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WftTestResultKind Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static WftTestResultKind()
        {
            buildupResult = 
                new WftTestResultKind("buildup result")
                {
                    Description = " This refers to the result of analysis of a buildup. More specialist buildup results could be added to the enum list such as buildup horner analysis, etc. "
            };
            drawdownResult = 
                new WftTestResultKind("drawdown result")
                {
                    Description = "This refers to the result of analysis of a drawdown."
            };
            unknown = 
                new WftTestResultKind("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a WftTestResultKind by name
        /// </summary>
        /// <param name="name">The name of the WftTestResultKind to return</param>
        /// <returns>The WftTestResultKind represented by 'name'</returns>
        public static WftTestResultKind GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(WftTestResultKind)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(WftTestResultKind)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (WftTestResultKind)ev;
                    }
                }
            }
            
            return null;
        }
    }

    /// <summary>
    /// 
    ///			This is used to characterize the test data being described.  A curve of data
    ///			may comprise one item of test data (by use of the curveSection element), in which case
    ///			the wftTestDataRole is used to say what	that curve "means" in the test.
    ///			Alternatively a single parameter may characterize the test in some manner (by use of the
    ///			parameter element), in which case the wftTestDataRole is used to say what that parameter
    ///			"means" in the test.   This list could be expanded in future.
    ///			Two illustrative WftTestDataRole kinds are documented.
    ///		
    /// </summary>
    public class WftTestDataRole : Energistics.DataAccess.EnumValue.EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected WftTestDataRole(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        ///<param name="name">Name of the WftTestDataRole</param>
        public WftTestDataRole(string name) : base(name) {}

        /// <summary>
        /// Retrieves the complete list of WftTestDataRoles
        /// </summary>
        /// <returns>The complete list of WftTestDataRoles</returns>
        public static List<WftTestDataRole> GetList()
        {
            return GetList<WftTestDataRole>();
        }

        private readonly static WftTestDataRole pressureStream;
        /// <summary>
        ///  This would refer to a curveSection element and indicate the curve is a curve (a time series of data points) containing the pressure data. 
        /// </summary>
        [EnumValueNameAttribute("pressure stream")]
        public static WftTestDataRole PressureStream
        {
            get 
            {
                return pressureStream;
            }
        }

        private readonly static WftTestDataRole flowHistory;
        /// <summary>
        ///  This would refer to a curveSection element and indicate the curve is a curve (a time series of data points) containing the flowrate history data (used in pressure transient analysis. 
        /// </summary>
        [EnumValueNameAttribute("flow history")]
        public static WftTestDataRole FlowHistory
        {
            get 
            {
                return flowHistory;
            }
        }

        private readonly static WftTestDataRole unknown;
        /// <summary>
        ///  The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. 
        /// </summary>
        [EnumValueNameAttribute("unknown")]
        public static WftTestDataRole Unknown
        {
            get 
            {
                return unknown;
            }
        }

        static WftTestDataRole()
        {
            pressureStream = 
                new WftTestDataRole("pressure stream")
                {
                    Description = " This would refer to a curveSection element and indicate the curve is a curve (a time series of data points) containing the pressure data. "
            };
            flowHistory = 
                new WftTestDataRole("flow history")
                {
                    Description = " This would refer to a curveSection element and indicate the curve is a curve (a time series of data points) containing the flowrate history data (used in pressure transient analysis. "
            };
            unknown = 
                new WftTestDataRole("unknown")
                {
                    Description = " The value is not known. This value should not be used in normal situations. All reasonable attempts should be made to determine the appropriate value. Use of this value may result in rejection in some situations. "
            };
        }

        /// <summary>
        /// Gets a WftTestDataRole by name
        /// </summary>
        /// <param name="name">The name of the WftTestDataRole to return</param>
        /// <returns>The WftTestDataRole represented by 'name'</returns>
        public static WftTestDataRole GetByName(string name)
        {
            if (enumValuesRegistry.ContainsKey(typeof(WftTestDataRole)))
            {
                List<EnumValue.EnumValue> myList = enumValuesRegistry[typeof(WftTestDataRole)];
            
                foreach (EnumValue.EnumValue ev in myList)
                {
                    if (ev.Name == name)
                    {
                        return (WftTestDataRole)ev;
                    }
                }
            }
            
            return null;
        }
    }

}
