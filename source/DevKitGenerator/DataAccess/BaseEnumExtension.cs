using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;
namespace Energistics.DataAccess
{
    /// <summary>
    /// extension serialize the string.
    /// </summary>
    [Serializable]
    public abstract class BaseEnumExtension : IXmlSerializable
    {
        public abstract string EnumValueStr
        {
            get;
            set;
        }
        /// <summary>
        /// construction
        /// </summary>
        public BaseEnumExtension()
            : base()
        {
        }

        string customerExtEnumStr = "";

        /// <summary>
        /// the customer enum extension string.
        /// </summary>
        [XmlIgnore]
        public string CustomerExtEnumStr
        {
            get { return customerExtEnumStr; }
            set { customerExtEnumStr = value; }

        }

        /// <summary>
        /// get the schema 
        /// </summary>
        /// <returns></returns>
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return (null);
        }

        /// <summary>
        /// read the xml
        /// </summary>
        /// <param name="reader"></param>
        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            Boolean isEmptyElement = reader.IsEmptyElement; // (1)
            reader.ReadStartElement();
            if (!isEmptyElement) // (1)
            {
                String str = reader.ReadContentAsString();
                if (str.Contains(":")) //valide extension string.
                {
                    this.customerExtEnumStr = str;
                }
                else
                {
                    EnumValueStr = str;
                    if (EnumValueStr != null)
                        this.customerExtEnumStr = "";
                }
                reader.ReadEndElement();
            }
        }

        /// <summary>
        /// write the xml.
        /// </summary>
        /// <param name="writer"></param>
        public void WriteXml(XmlWriter writer)
        {
            if (customerExtEnumStr.Length > 0)
                writer.WriteString(this.customerExtEnumStr);
            else
                writer.WriteString(EnumValueStr);
        }
    }
}
