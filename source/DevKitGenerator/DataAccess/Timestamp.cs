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
            value = DateTimeOffset.Parse(text, formatProvider: null, styles: DateTimeStyles.RoundtripKind);
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
            return value.ToString(format);
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
