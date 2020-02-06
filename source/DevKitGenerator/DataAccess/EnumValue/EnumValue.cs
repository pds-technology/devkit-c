// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2012 ExxonMobil Upstream Research Company
// 
// Third Party Software
// 
// Energistics 
// The following Energistics (c) products were used in the creation of this work: 
// 
// •             WITSML Data Schema Specifications, Version 1.4.1.1 
// •             WITSML API Specifications, version 1.4.1.1 
// •             WITSML Data Schema Specifications, Version 1.3.1.1 
// •             WITSML API Specifications, version 1.3.1 
// •             PRODML Data Schema Specifications, Version 1.2.2 
// •             PRODML Web Service Specifications, Version 2.1.0.1
// •             RESQML Data Schema Specifications, Version 1.1 
// 
// All rights in the WITSML™ Standard, the PRODML™ Standard, and the RESQML™ Standard, or
// any portion thereof, which remain in the Standards DevKit shall remain with Energistics
// or its suppliers and shall remain subject to the terms of the Product License Agreement
// available at http://www.energistics.org/product-license-agreement. 
// 
// Apache
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
// except in compliance with the License. 
// 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the
// License.
// 
// HDF5
// HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 2006-2012 by
// The HDF Group. 
// 
// NCSA HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 1998-2006
// by the Board of Trustees of the University of Illinois. 
// 
// All rights reserved. 
// 
// Redistribution and use in source and binary forms, with or without modification, are
// permitted for any purpose (including commercial purposes) provided that the following
// conditions are met: 
//    1. Redistributions of source code must retain the above copyright notice, this list
//       of conditions, and the following disclaimer. 
//    2. Redistributions in binary form must reproduce the above copyright notice, this
//       list of conditions, and the following disclaimer in the documentation and/or
// 	  materials provided with the distribution. 
//    3. In addition, redistributions of modified forms of the source or binary code must
//       carry prominent notices stating that the original code was changed and the date of
// 	  the change. 
//    4. All publications or advertising materials mentioning features or use of this
//       software are asked, but not required, to acknowledge that it was developed by The
// 	  HDF Group and by the National Center for Supercomputing Applications at the 
// 	  University of Illinois at Urbana-Champaign and credit the contributors. 
//    5. Neither the name of The HDF Group, the name of the University, nor the name of any
//       Contributor may be used to endorse or promote products derived from this software
// 	  without specific prior written permission from The HDF Group, the University, or
// 	  the Contributor, respectively. 
// 
// DISCLAIMER: THIS SOFTWARE IS PROVIDED BY THE HDF GROUP AND THE CONTRIBUTORS "AS IS" WITH
// NO WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED. In no event shall The HDF Group or
// the Contributors be liable for any damages suffered by the users arising out of the use
// of this software, even if advised of the possibility of such damage. 
// 
// Contributors: National Center for Supercomputing Applications (NCSA) at the University of
// Illinois, Fortner Software, Unidata Program Center (netCDF), The Independent JPEG Group
// (JPEG), Jean-loup Gailly and Mark Adler (gzip), and Digital Equipment Corporation (DEC). 
// 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Reflection;
using System.Collections.Concurrent;

namespace Energistics.DataAccess.EnumValue
{   
    /// <summary>
    /// Base class for Enumeration values that are defined in EnumValues.xml
    /// </summary>
    [Serializable]
    public abstract class EnumValue
    {
        /// <summary>
        /// Collection to keep track of registered EnumValues
        /// </summary>
        protected static ConcurrentDictionary<Type, List<EnumValue>> enumValuesRegistry = new ConcurrentDictionary<Type, List<EnumValue>>();
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
        protected void Register()
        {
            Type key = this.GetType();
            if (!enumValuesRegistry.ContainsKey(key))
            {
                enumValuesRegistry.TryAdd(key, new List<EnumValue>());
            }

            List<EnumValue> myList = enumValuesRegistry[key];

            foreach (EnumValue ev in myList)
            {
                if (ev.Name == this.Name)
                {
                    foreach (PropertyInfo pi in key.GetProperties())
                    {
                        if (pi.CanWrite && pi.Name != "Name")
                        {
                            pi.SetValue(this, pi.GetValue(ev, new object[] {}), new object[] {});
                        }
                    }
                    return;
                }
            }
            myList.Add(this);
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
                    Register();
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

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>A hash code for the current Object</returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    /// <summary>
    /// These values represent the type of qualifier in lithology.
    /// </summary>
    [Serializable]
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

    /// <summary>
    /// The names of agreed extensions to WITSML.
    /// This list may be locally extended but it is recommended that new names be
    /// approved by the WITSML SIG before use.
    /// Each standard name must define its data type.
    /// For string types, the maximum length must be defined in number of characters.
    /// For measures, the expected measure class must be defined.
    /// </summary>
    [Serializable]
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
        /// For extensions, the maximum number of characters in a string value.
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

    /// <summary>
    /// Defines classes of measures and their allowed units of measures.
    /// For a value whose underlying meaning conforms to one of these classes, 
    /// any specified unit of measure must conform to the defined list.
    /// These are copied from the Energistics (POSC) Units Classes v2.2.
    /// The units of measure map to the POSC Units of Measure Dictionary v2.2.
    /// </summary>
    [Serializable]
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

    /// <summary>
    /// Defines classes of properties. A property inherits the underlying characteristics of its parent but specializes its meaning.
    /// </summary>
    [Serializable]
    public abstract class ResqmlPropertyKindEnumValue : EnumValue
    {
        /// <summary>
        /// Protected constructor, should always pass in "name"
        /// </summary>
        protected ResqmlPropertyKindEnumValue() : base() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the MeasureUOMEnumValue</param>
        protected ResqmlPropertyKindEnumValue(string name) : base(name) { }

        /// <summary>
        /// True ("1" or "true") indicates that the property is abstract and cannot be used to characterize a value.
		///	False ("0" or "false") or not given indicates a non-abstract property that can be instantiated.
        /// </summary>
        [EnumValueNameAttribute("isAbstract")]
        [XmlIgnore]
        public bool? IsAbstract { get; set; }

        /// <summary>
        /// Points to a parent property kind
        /// </summary>
        [EnumValueNameAttribute("parentKind")]
        [XmlIgnore]
        public string ParentKind { get; set; }

        /// <summary>
        /// A property classification.
        /// </summary>
        [EnumValueNameAttribute("category")]
        [XmlIgnore]
        public string Category { get; set; }

        /// <summary>
        /// The allowed unit of measure for the continuous property.
        /// </summary>
        [EnumValueNameAttribute("unitOfMeasure")]
        [XmlIgnore]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// The dimensional analysis of the unit of measure. 
        /// For example, a meter (m) would be of class "L", which represents length. 
        /// A foot (ft) would also be in this dimension.
        /// Note that angle       is considered to be dimensionless ratio of length.
        /// Note that solid angle is considered to be dimensionless ratio of area.
        /// The following nomenclature is used: 
        /// 	A = angle 			(SI unit = radian) 
        /// 	B = luminous intensity 		(SI unit = candela)
        /// 	C = electrical current 		(SI unit = ampere)
        /// 	K = thermodynamic temperature 	(SI unit = kelvin)
        /// 	L = length 			(SI unit = metre)
        /// 	M = mass 			(SI unit = kilogram)
        /// 	N = amount of substance 	(SI unit = mole)
        /// 	S = solid angle 		(SI unit = steradian)
        /// 	T = time 			(SI unit = second)
        /// 	1 = dimensionless
        /// 	2 = squared			(e.g., "M2")
        /// 	3 = cubed
        /// 	4 = 4th power
        /// 	5 = 5th power
        /// 	6 = 6th power
        /// 	7 = 7th power
        /// 	8 = 8th power
        /// 	/ = division
        /// 	ratio(X) = A dimensionless ratio of another dimension. 
        /// 	        For example, a dimensionless ratio of area would be indicated by "ratio(L2)" and represents the equivalent of "L2/L2".
        /// 		This is only used when the underlying dimension would otherwise be "1".
        /// The values may be broken into numerator and denominator separated by a slash "/" but multiple slashes must not be used. 
        /// A slash must not terminate the string.
        /// For example, length per time would be indicated by "L/T"
        /// A number other than "1" will always follow a single dimensional character (e.g., "M2") and will represent the power of that component.
        /// The number "1" will only exist by itself or as the whole numerator (e.g., "1" or "1/T"). 
        /// The number "1" must not be used as a denominator because it is implied (e.g., "M" impiles "M/1").
        /// For consistency, the items within a numerator or denominator are listed in alphabetical order (i.e., LM - not ML).
        /// </summary>
        [EnumValueNameAttribute("dimensionalClass")]
        [XmlIgnore]
        public string DimensionalClass { get; set; }

        /// <summary>
        /// The minimum value allowed for the discrete property.
        /// </summary>
        [EnumValueNameAttribute("minimumValue")]
        [XmlIgnore]
        public long? MinimumValue { get; set; }

        /// <summary>
        /// The maximum value allowed for the discrete property.
        /// </summary>
        [EnumValueNameAttribute("maximumValue")]
        [XmlIgnore]
        public long? MaximumValue { get; set; }

        /// <summary>
        /// A value allowed for the categorical property.
        /// </summary>
        [EnumValueNameAttribute("enumValue")]
        [XmlIgnore]
        public string EnumValue { get; set; }
        
    }

    /// <summary>
    /// Lithology qualifier types.
    /// </summary>
    [Serializable]
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
    [Serializable]
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


