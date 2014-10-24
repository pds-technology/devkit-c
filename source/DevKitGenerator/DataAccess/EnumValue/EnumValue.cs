// 
// License notice 
// Standards DevKit, version 1.0 
// Copyright 2011 ExxonMobil Upstream Research Company
//  
// The following Energistics (c) products were used in the creation of this work: 
// 
// •	WITSML Data Schema Specifications, Version 1.4.1 
// •	WITSML API Specifications, version 1.4.1 
// •	WITSML Data Schema Specifications, Version 1.3.1.1 
// •	WITSML API Specifications, version 1.3.1 
// •	PRODML Data Schema Specifications, Version 1.2 
// •	PRODML Web Service Specifications, Version 2.0
// 
// All rights in the WITSML™ Standard and the PRODML™ Standard, or any portion thereof, which remain in the 
// Standards DevKitshall remain with Energistics or its suppliers and shall remain subject to the terms of 
// the Product License Agreement available at http://www.energistics.org/product-license-agreement. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in 
// compliance with the License. 
// 
// You may obtain a copy of the License at 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the License. 
// 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Reflection;

namespace Energistics.DataAccess.EnumValue
{   
    /// <summary>
    /// Base class for Enumeration values that are definied in EnumValues.xml
    /// </summary>
    public abstract class EnumValue
    {
        private static Dictionary<Type, List<EnumValue>> enumValuesRegistry = new Dictionary<Type, List<EnumValue>>();
        private string name;

        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected EnumValue() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the EnumValue</param>
        protected EnumValue(string name)
            : this()
        {
            this.Name = name;
        }

        /// <summary>
        /// Register a new EnumValue
        /// </summary>
        /// <param name="value">The EnumValue to register</param>
        protected void Register(EnumValue value)
        {
            Type key = this.GetType();
            if (!enumValuesRegistry.ContainsKey(key))
            {
                enumValuesRegistry.Add(key, new List<EnumValue>());
            }

            List<EnumValue> myList = enumValuesRegistry[key];
  
            if (!myList.Contains(value))
            {
                myList.Add(value);
            }
        }

        /// <summary>
        /// Retrieves the list of pre-compiled EnumValues
        /// </summary>
        /// <typeparam name="T">The type of EnumValue to return</typeparam>
        /// <returns>The List of EnumValues</returns>
        protected static List<T> GetEnumValueNameAttributeList<T>()
        {
            List<T> myList = new List<T>();

            foreach (PropertyInfo p in typeof(T).GetProperties())
            {
                if (p.GetGetMethod().IsStatic && p.GetCustomAttributes(typeof(EnumValueNameAttribute), false).Length > 0)
                {
                    myList.Add((T)p.GetValue(null, new object[] { }));
                }
            }

            return myList;
        }

        /// <summary>
        /// Retrieves the list of pre-compiled EnumValues combined with the registered EnumValues
        /// </summary>
        /// <typeparam name="T">The type of EnumValue to return</typeparam>
        /// <returns>The List of EnumValues</returns>
        protected static List<T> GetList<T>()
        {
            List<T> myList = new List<T>();

            foreach (T enumVal in GetEnumValueNameAttributeList<T>())
            {
                myList.Add(enumVal);
            }
            foreach (object enumVal in enumValuesRegistry[typeof(T)])
            {
                if (!myList.Contains((T)enumVal))
                {
                    myList.Add(((T)enumVal));
                }
            }
            return myList;
        }

        /// <summary>
        /// The name of the value.
        /// </summary>
        [EnumValueNameAttribute("name")]    
        [XmlText]
        public string Name
        {
            get { return name; }
            set
            {
                if (name == null)
                {
                    name = value;
                    Register(this);
                }
                else
                {
                    throw new Exception("You cannot set name on a EnumValue where name has already been set.");
                }
            }
        }

        /// <summary>
        /// A description of the value.
        /// </summary>
        [EnumValueNameAttribute("description")]
        [XmlIgnore]
        public string Description { get; set; }

        /// <summary>
        /// The version when the value was added.
		///	The string should match the content of the root version attribute of the schema.
		///	For example, "1.4.0.0".
        /// </summary>
        [EnumValueNameAttribute("version")]
        [XmlIgnore]
        public string Version { get; set; }

        /// <summary>
        /// A non blank version indicates that the value has
		/// been deprecated and may be removed in future versions.
		///	The string should match the content of the root version attribute of the schema.
		///	For example, "1.4.0.0".
        /// </summary>
        [EnumValueNameAttribute("deprecated")]
        [XmlIgnore]
        public string Deprecated { get; set; }

        /// <summary>
        /// The value to use as a replacement for a deprecated value.
        /// </summary>
        [EnumValueNameAttribute("replacedBy")]
        [XmlIgnore]
        public EnumValue ReplacedBy { get; set; }

        /// <summary>
        /// String representation of EnumValue
        /// </summary>
        /// <returns>String representation of EnumValue</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Determines whether two EnumValue objects are equal
        /// </summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns></returns>
        public override bool Equals(System.Object obj)
        {
            EnumValue p = obj as EnumValue;
            
            if (p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (this.Name == p.Name);
        }

        /// <summary>
        /// Determines whether two EnumValue objects are equal
        /// </summary>
        /// <param name="a">First EnumValue object to compare</param>
        /// <param name="b">Second EnumValue object to compare</param>
        /// <returns>True if the objects are equal, false if they are not</returns>
        public static bool operator ==(EnumValue a, EnumValue b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.Equals(b);
        }

        /// <summary>
        /// Determines whether two EnumValue objects are not equal
        /// </summary>
        /// <param name="a">First EnumValue object to compare</param>
        /// <param name="b">Second EnumValue object to compare</param>
        /// <returns>True if the objects are not equal, false if they are</returns>
        public static bool operator !=(EnumValue a, EnumValue b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    public abstract class LithoTypeEnumValue : EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected LithoTypeEnumValue(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the LithoTypeEnumValue</param>
        protected LithoTypeEnumValue(string name) : base(name) { }

        /// <summary>
        /// For lithology qualifiers, the type of qualifier: "noun", "adjective" or "both". 
		/// For a qualifier which has a type of "both", the "noun" form must be specified as the qualifier value
		///	and an adjective form must be listed as a variant.
		///	The interpretation of whether a specified qualifier value represents a noun or a adjective is 
		///	defined by its association with either an interval (adjective) or point (noun).
        /// </summary>
        [EnumValueNameAttribute("lithoType")]
        [XmlIgnore]
        public EnumValueLithoType LithoType { get; set; }

        /// <summary>
        /// The name of the lithology qualifier for which this qualifier 
		///	represents a variation of the same underlying concept. 
		///	A variant will always represent either an adjective or a noun but not both.
        /// </summary>
        [EnumValueNameAttribute("variantOf")]
        [XmlIgnore]
        public LithoTypeEnumValue VariantOf { get; set; }

        /// <summary>
        /// True ("true" or "1") indicates that the qualifier is also in the LithologyType list.
		///	False ("false" or "0") indicates otherwise.
        /// </summary>
        [EnumValueNameAttribute("isLithology")]
        [XmlIgnore]
        public bool IsLithology { get; set; }

        /// <summary>
        /// True ("true" or "1") indicates that the qualifier is also in the MatrixCementType list.
		/// False ("false" or "0") indicates otherwise.
        /// </summary>
        [EnumValueNameAttribute("isMatrixCement")]
        [XmlIgnore]
        public bool IsMatrixCement { get; set; }
    }

    public abstract class ExtensionDataEnumValue : EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ExtensionDataEnumValue(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the ExtensionDataEnumValue</param>
        protected ExtensionDataEnumValue(string name) : base(name) { }

        /// <summary>
        /// For extensions, the underlying data type of the value.
        /// </summary>
        [EnumValueNameAttribute("extensionDataType")]
        [XmlIgnore]
        public Type ExtensionDataType { get; set; }

        /// <summary>
        /// For extensions, the maximum number of charactetrs in a string value.
        /// </summary>
        [EnumValueNameAttribute("extensionMaximumSize")]
        [XmlIgnore]
        public int ExtensionMaximumSize { get; set; }

        /// <summary>
        /// For extensions, defines the measure class associated with the temm.
		///	This controls the allowed units of measure. 
		///	If this is specified then the value must be defined with a unit of measure.
        /// </summary>
        [EnumValueNameAttribute("extensionMeasureClass")]
        [XmlIgnore]
        public string ExtensionMeasureClass { get; set; }

        /// <summary>
        /// For extensions, defines the path to the allowed location in the schema
		///	where the extension is allowed. 
		/// This should begin at the singular object level  (e.g., "/well/commonData/extension"). 
		///	A relative location will allow it in any object (i.e., ".//commonData/extension").
		///	A relative location within the object will allow it at any location within that object
		///	(e.g., "/opsReport//commonData/extension").
        /// </summary>
        [EnumValueNameAttribute("extensionPath")]
        [XmlIgnore]
        public string ExtensionPath { get; set; }
    }

    public abstract class MeasureUOMEnumValue : EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected MeasureUOMEnumValue(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the MeasureUOMEnumValue</param>
        protected MeasureUOMEnumValue(string name) : base(name) { }

        /// <summary>
        /// For measure classes, defines a representative uom.
        /// </summary>
        [EnumValueNameAttribute("measureRepresentativeUOM")]
        [XmlIgnore]
        public string MeasureRepresentativeUOM { get; set; }

        /// <summary>
        /// For measure classes, defines the base uom for conversion.
        /// </summary>
        [EnumValueNameAttribute("measureBaseForConversion")]
        [XmlIgnore]
        public string MeasureBaseForConversion { get; set; }

        /// <summary>
        /// For measure classes, defines an allowed uom for the class.
        /// </summary>
        [EnumValueNameAttribute("measureUom")]
        [XmlIgnore]
        public string MeasureUom { get; set; }
    }

    public abstract class RealtimeEnumValue : EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected RealtimeEnumValue(): base() {}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the RealtimeEnumValue</param>
        protected RealtimeEnumValue(string name) : base(name) { }

        /// <summary>
        /// For realtime data, defines the underlying type data associated with this term.
        /// </summary>
        [EnumValueNameAttribute("realtimeDataType")]
        [XmlIgnore]
        public EnumValueRealtimeType RealtimeDataType { get; set; }

        /// <summary>
        /// For realtime data, defines the measure class associated with the term.
        /// This controls the allowed units of measure. 
		///	If this is specified then the value must be defined with a unit of measure.
		///	All measure values inherently have a numeric data type.
        /// </summary>
        [EnumValueNameAttribute("realtimeMeasureClass")]
        [XmlIgnore]
        public string RealtimeMeasureClass { get; set; }
    }

    /// <summary>
    /// Lithology qualifier types.
    /// </summary>
    public enum EnumValueRealtimeType
    {
        /// <summary>
        /// The value is a string. This is also appropriate for a short list of integer codes (e.g., "1", 2" or "3") or for booleans.
        /// </summary>
        RealtimeString,

        /// <summary>
        /// The value is a number and fractional component is allowed.
        /// </summary>
        RealtimeNumeric,

        /// <summary>
        /// Specialization of numeric. The value is a whole number. That is, a fractional component is not allowed.
        /// </summary>
        RealtimeInteger,

        /// <summary>
        /// The value is not known. This value should not be used
		///	in normal situations. All reasonable attempts should be made to determine
		///	the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        RealtimeUnknown
    }

    /// <summary>
    /// Lithology qualifier types.
    /// </summary>
    public enum EnumValueLithoType
    {
        /// <summary>
        /// Qualifiers which are isolated or spot occurrences suggesting 
  		///	that these components are `included' in a lithology and does not imply a 
  		///	lithology type (for example, a single occurrence of a fossil).
		///	A qualifier which is specified as a point value (top=bottom) should be interpreted 
		///	as representing the noun form.
        /// </summary>
        noun,
        
        /// <summary>
        /// Qualifiers which are components or attributes of the lithology 
  		///	occurring/prevailing over a depth range, or over the whole lithology; an adjective 
  		///	should be used as a further definition of an existing lithology type (for example, 
  		///	types of cementation or other diagenetic effects would be expressed using adjectives).
		///	A qualifier which is specified over a depth range should be interpreted as representing
		///	the adjective form.
        /// </summary>
        adjective,

        /// <summary>
        /// A qualifier which can have both adjective and noun forms.
		///	If the qualifier is specified either over a depth range then it should be interpreted
		///	as representing its adjective form. If the qualifier is specified at a point then it
		///	should be interpreted as its noun form.
        /// </summary>
        both,

        /// <summary>
        /// The value is not known. This value should not be used
		///	in normal situations. All reasonable attempts should be made to determine
		///	the appropriate value. Use of this value may result in rejection in some situations.
        /// </summary>
        unknown
    }
}
