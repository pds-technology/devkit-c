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
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.DataAccess
{
    /// <summary>
    /// A class used to support the EnumExtensionPattern from EML Common.  This pattern is used to construct a union between
    /// an explicitly defined standard enumeration (<typeparamref name="TEnum"/>) and a custom enumeration string following the pattern: &quot;.*:.*&quot;
    /// </summary>
    /// <typeparam name="TEnum">The <typeparamref name="TEnum"/> enumeration to use as the native enumeration.</typeparam>
    [Serializable]
    public struct ExtensibleEnum<TEnum> : IComparable<ExtensibleEnum<TEnum>>, IEquatable<ExtensibleEnum<TEnum>>, IComparable<TEnum>, IEquatable<TEnum>, IXmlSerializable
        where TEnum : struct, IComparable
    {
        private static Dictionary<TEnum, string> _enumToXmlString;
        private static Dictionary<string, TEnum> _stringToXmlEnum;

        /// <summary>
        /// Static constructor to initialize serialization dictionaries.
        /// </summary>
        static ExtensibleEnum()
        {
            _enumToXmlString = new Dictionary<TEnum, string>();
            _stringToXmlEnum = new Dictionary<string, TEnum>();

            var type = typeof(TEnum);

            foreach (var value in System.Enum.GetValues(type).Cast<TEnum>())
            {
                var name = System.Enum.GetName(type, value);
                var field = type.GetField(name);
                var attribute = (XmlEnumAttribute)Attribute.GetCustomAttribute(field, typeof(XmlEnumAttribute));

                _enumToXmlString[value] = attribute?.Name ?? name;
                _stringToXmlEnum[attribute?.Name ?? name] = value;
            }
        }

        /// <summary>
        /// The standard enumeration value, if set.
        /// </summary>
        public TEnum Enum { get; private set; }

        /// <summary>
        /// A custom extension value, if set.
        /// </summary>
        public string Extension { get; private set; }

        /// <summary>
        /// Whether the standard enumeration value is set or not.
        /// </summary>
        public bool IsEnum => string.IsNullOrEmpty(Extension);

        /// <summary>
        /// Whether a custom enumeration value is set or not.
        /// </summary>
        public bool IsExtension => !IsEnum;

        /// <summary>
        /// Initializes a new <see cref="ExtensibleEnum{TEnum}"/> instance from the specified enumeration value.
        /// </summary>
        /// <param name="enum">The specified enumeration value.</param>
        public ExtensibleEnum(TEnum @enum)
        {
            Enum = @enum;
            Extension = null;
        }

        /// <summary>
        /// Initializes a new <see cref="ExtensibleEnum{TEnum}"/> instance from the specified string enumeration value.
        /// </summary>
        /// <param name="enum">The specified string enumeration value.</param>
        /// <remarks>The XML Enumeration string representation is given priority over the .NET code string representaiton</remarks>
        public ExtensibleEnum(string @enum)
            : this()
        {
            InitializeFromString(@enum);
        }

        /// <summary>
        /// Initializes this instance from a string.  If the string is parsable
        /// as a <typeparamref name="TEnum"/> instance, then that is used.  Otherwise,
        /// the string is treated as an extension.
        /// </summary>
        /// <param name="enum">The string enumeration to initialize from.</param>
        /// <remarks>The XML Enumeration string representation is given priority over the .NET code string representaiton</remarks>
        private void InitializeFromString(string @enum)
        {
            TEnum parsedEnum;

            if (_stringToXmlEnum.TryGetValue(@enum, out parsedEnum))
            {
                Enum = parsedEnum;
                Extension = null;
            }
            else if (System.Enum.TryParse<TEnum>(@enum, out parsedEnum))
            {
                Enum = parsedEnum;
                Extension = null;
            }
            else
            {
                Extension = @enum;
            }
        }

        /// <summary>
        /// Converts this instance to a string.
        /// </summary>
        /// <returns>The string version of this enumeration.</returns>
        /// <remarks>The XML Enumeration string representation is given priority over the .NET code string representaiton</remarks>
        private string ConvertToString()
        {
            string convertedString;

            if (IsEnum && _enumToXmlString.TryGetValue(Enum, out convertedString))
                return convertedString;
            else if (IsEnum)
                return Enum.ToString();
            else
                return Extension;
        }

        #region Equality and Inequality

        /// <summary>
        /// Compares two <see cref="ExtensibleEnum{TEnum}"/> instances.
        /// </summary>
        /// <param name="other">The instance to compare against.</param>
        /// <returns>The result of the comparison.</returns>
        public int CompareTo(ExtensibleEnum<TEnum> other)
        {
            return ToString().CompareTo(other.ToString());
        }

        /// <summary>
        /// Compares two <see cref="ExtensibleEnum{TEnum}"/> instances for equality.
        /// </summary>
        /// <param name="other">The instance to compare against.</param>
        /// <returns><c>true</c> if the instances are equal; <c>false</c> otherwise.</returns>
        public bool Equals(ExtensibleEnum<TEnum> other)
        {
            return (other.Enum.Equals(Enum) && other.Extension == Extension);
        }

        /// <summary>
        /// Compares two <typeparamref name="TEnum"/> instances.
        /// </summary>
        /// <param name="other">The instance to compare against.</param>
        /// <returns>The result of the comparison.</returns>
        public int CompareTo(TEnum other)
        {
            if (!IsEnum) return -1;

            return Enum.CompareTo(other);
        }

        /// <summary>
        /// Compares two <typeparamref name="TEnum"/> instances for equality.
        /// </summary>
        /// <param name="other">The instance to compare against.</param>
        /// <returns><c>true</c> if the instances are equal; <c>false</c> otherwise.</returns>
        public bool Equals(TEnum other)
        {
            return (IsEnum && other.Equals(Enum));
        }

        /// <summary>
        /// Compares this <see cref="ExtensibleEnum{TEnum}"/> with an object for equality.
        /// </summary>
        /// <param name="obj">The object to compare against.</param>
        /// <returns><c>true</c> if the instances are equal; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is TEnum)
                return (IsEnum && ((TEnum)obj).Equals(Enum));

            if (obj is ExtensibleEnum<TEnum>)
            {
                var other = (ExtensibleEnum<TEnum>)obj;

                return (other.Enum.Equals(Enum) && other.Extension == Extension);
            }

            return false;
        }

        /// <summary>
        /// Creates a string representation of this instance.
        /// </summary>
        /// <returns>The string representation of this instance.</returns>
        public override string ToString()
        {
            return ConvertToString();
        }

        /// <summary>
        /// Gets the hash code for this instance.
        /// </summary>
        /// <returns>The hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return (Enum.GetHashCode() * 11) + (Extension?.GetHashCode() ?? 23);
        }

        #endregion

        #region IXmlSerializable

        /// <summary>
        /// Gets the <see cref="XmlSchema"/> used for XML Serialization for this instance.
        /// </summary>
        /// <exception cref="NotImplementedException">Any call to this method.</exception>
        /// <remarks>This method is not implemented.</remarks>
        XmlSchema IXmlSerializable.GetSchema()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads this instance from an <see cref="XmlReader"/> for XML Serialization.
        /// </summary>
        /// <param name="reader">The <see cref="XmlReader"/> to read the instance data from.</param>
        /// <remarks>This method is to support XML Serialization.  It should not be used directly.</remarks>
        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            var content = reader.ReadElementContentAsString();
            InitializeFromString(content);
        }

        /// <summary>
        /// Writes this instance to an <see cref="XmlWriter"/> for XML Serialization.
        /// </summary>
        /// <param name="writer">The <see cref="XmlWriter"/> to write the instance data to.</param>
        /// <remarks>This method is to support XML Serialization.  It should not be used directly.</remarks>
        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            writer.WriteString(ToString());
        }

        #endregion

        #region Implicit Conversion Operators

        /// <summary>
        /// Implicit conversion operator to <typeparamref name="TEnum"/>.
        /// </summary>
        /// <param name="enum">The <see cref="ExtensibleEnum{TEnum}"/> instance to convert.</param>
        /// <returns>The native enumeration value if set or the default value for <typeparamref name="TEnum"/> if not set.</returns>
        public static implicit operator TEnum(ExtensibleEnum<TEnum> @enum)
        {
            return @enum.IsEnum ? @enum.Enum : default(TEnum);
        }

        /// <summary>
        /// Implicit conversion operator to <see cref="string"/>.
        /// </summary>
        /// <param name="enum">The <see cref="ExtensibleEnum{TEnum}"/> instance to convert.</param>
        /// <returns>The string representation of the <see cref="ExtensibleEnum{TEnum}"/>.</returns>
        public static implicit operator string(ExtensibleEnum<TEnum> @enum)
        {
            return @enum.ToString();
        }

        /// <summary>
        /// Implicit conversion operator from a <see cref="string"/>.
        /// </summary>
        /// <param name="enum">The <see cref="string"/> instance to convert.</param>
        /// <returns>A <see cref="ExtensibleEnum{TEnum}"/> initialized from the string.</returns>
        public static implicit operator ExtensibleEnum<TEnum>(TEnum @enum)
        {
            return new ExtensibleEnum<TEnum>(@enum);
        }

        #endregion
    }
}
