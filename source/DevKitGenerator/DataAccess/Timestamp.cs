// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2016 Petrotechnical Data Systems
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
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Represents a point in time relative to Coordinated Universal Time (UTC), which
    /// can also be serialized and deserialized to and from XML.
    /// </summary>
    /// <seealso cref="System.Xml.Serialization.IXmlSerializable" />
    [Serializable]
    public struct Timestamp : IXmlSerializable
    {
        private DateTimeOffset value;

        /// <summary>
        /// <see cref="DateTimeStyles"/> to use when parsing timestamps.  In accordance with
        /// ISO 8601, the default value is <see cref="DateTimeStyles.AssumeLocal"/>, which
        /// means that timestamps with no time zone specified will be assumed to be in local time.
        /// </summary>
        public static DateTimeStyles ParsingStyle { get; set; } = DateTimeStyles.AssumeLocal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Timestamp"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        public Timestamp(DateTimeOffset value)
        {
            this.value = value;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="DateTimeOffset"/> to <see cref="Timestamp"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Timestamp(DateTimeOffset value)
        {
            return new Timestamp(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Timestamp"/> to <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator DateTimeOffset(Timestamp instance)
        {
            return instance.value;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Timestamp a, Timestamp b)
        {
            return a.value == b.value;
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Timestamp a, Timestamp b)
        {
            return a.value != b.value;
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(Timestamp a, Timestamp b)
        {
            return a.value < b.value;
        }

        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(Timestamp a, Timestamp b)
        {
            return a.value > b.value;
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(Timestamp a, Timestamp b)
        {
            return a.value <= b.value;
        }

        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(Timestamp a, Timestamp b)
        {
            return a.value >= b.value;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Timestamp a, DateTimeOffset b)
        {
            return a.value == b;
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Timestamp a, DateTimeOffset b)
        {
            return a.value != b;
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(Timestamp a, DateTimeOffset b)
        {
            return a.value < b;
        }

        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(Timestamp a, DateTimeOffset b)
        {
            return a.value > b;
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(Timestamp a, DateTimeOffset b)
        {
            return a.value <= b;
        }

        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(Timestamp a, DateTimeOffset b)
        {
            return a.value >= b;
        }


        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DateTimeOffset a, Timestamp b)
        {
            return a == b.value;
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(DateTimeOffset a, Timestamp b)
        {
            return a != b.value;
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(DateTimeOffset a, Timestamp b)
        {
            return a < b.value;
        }

        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(DateTimeOffset a, Timestamp b)
        {
            return a > b.value;
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(DateTimeOffset a, Timestamp b)
        {
            return a <= b.value;
        }

        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="a">Timestamp a.</param>
        /// <param name="b">Timestamp b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(DateTimeOffset a, Timestamp b)
        {
            return a >= b.value;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object other)
        {
            if (other is Timestamp)
                return value.Equals(((Timestamp)other).value);
            else if (other is DateTimeOffset)
                return value.Equals((DateTimeOffset)other);
            else
                return false;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        /// <summary>
        /// This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return 
        /// null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the 
        /// <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute" /> to the class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced 
        /// by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed 
        /// by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.
        /// </returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> stream from which the object is deserialized.</param>
        public void ReadXml(XmlReader reader)
        {
            var text = reader.ReadElementString();
            value = DateTimeOffset.Parse(text, CultureInfo.InvariantCulture, ParsingStyle);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return ToString(format: "o");
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public string ToString(string format)
        {
            return value.ToString(format, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> stream to which the object is serialized.</param>
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(ToString());
        }
    }
}
