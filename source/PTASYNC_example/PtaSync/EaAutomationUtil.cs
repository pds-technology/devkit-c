/******************************************************************************
// Copyright (c) 2014, Atman Consulting
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met:
//
// Redistributions of source code must retain the above copyright notice, this 
// list of conditions and the following disclaimer.
//
// Redistributions in binary form must reproduce the above copyright notice, 
// this list of conditions and the following disclaimer in the documentation 
// and/or other materials provided with the distribution.
//
// Neither the name of the Atman Consulting nor the names of its contributors 
// may be used to endorse or promote products derived from this software without 
// specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF 
// THE POSSIBILITY OF SUCH DAMAGE.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PtaSync
{
    /// <summary>
    /// A utility for working with the Sparx Enterprise Architect (EA) automation API. 
    /// </summary>
    public class EaAutomationUtil
    {
        private EA.Repository _eaRepository;
        public static readonly SortedSet<string> XmlTypes = LoadXsdPrimitiveTypes();

        public EaAutomationUtil(EA.Repository eaRepository)
        {
            _eaRepository = eaRepository;
        }

        private static SortedSet<string> LoadXsdPrimitiveTypes()
        {
            var types = new SortedSet<string>();
            TextReader reader = new StringReader(Resource.XsdTypes);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (!String.IsNullOrWhiteSpace(line))
                    types.Add(line.Trim());
            }
            return types;
        }

        public EA.Attribute GetAttributeByName(EA.Element element, string attributeName)
        {
            for (short iattr = 0; iattr < element.AttributesEx.Count; iattr++)
            {
                var attr = element.AttributesEx.GetAt(iattr);
                if (attr.Name == attributeName)
                    return attr;
            }
            return null;
        }

        /// <summary>
        /// Creates an adds an EA attribute of stereotype XSDelement to the given EA element.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="minOccurs"></param>
        /// <param name="maxOccurs"></param>
        /// <returns></returns>
        public EA.Attribute CreateXsdElement(EA.Element element, string name, string type, string minOccurs, string maxOccurs)
        {

            var attribute = (EA.Attribute)element.Attributes.AddNew(name, type);
            attribute.Stereotype = "XSDelement";
            attribute.LowerBound = minOccurs;
            attribute.UpperBound = maxOccurs;
            if (!attribute.Update())
                throw new EaAutomationException(attribute.GetLastError());

            // Attempt to fix broken type link if needed.
            if (attribute.ClassifierID == 0 && !XmlTypes.Contains(attribute.Type))
            {
                var xsdType = FindXsdTypeByName(type);
                if (xsdType != null)
                {
                    attribute.ClassifierID = xsdType.ElementID;
                    if (!attribute.Update())
                        throw new EaAutomationException(attribute.GetLastError());
                }
            }

            AddTaggedValue(attribute, "form", string.Empty, Resource.XsdTagFormNote);
            AddTaggedValue(attribute, "position", string.Empty, Resource.XsdTagPositionNote);
            AddTaggedValue(attribute, "anonymousType", "true", Resource.XsdTagAnonymousTypeNote);
            AddTaggedValue(attribute, "anonymousRole", "false", Resource.XsdTagAnonymousRoleNote);
            AddTaggedValue(attribute, "nillable", "false", Resource.XsdTagNillableNote);
            AddTaggedValue(attribute, "default", string.Empty,Resource.XsdTagDefaultNote);
            AddTaggedValue(attribute, "fixed", string.Empty,Resource.XsdTagFixedNote);
            if (!attribute.Update())
                throw new EaAutomationException(attribute.GetLastError());
            return attribute;
        }

        public EA.Element FindXsdTypeByName(string typeName)
        {
            var queryResult = _eaRepository.GetElementsByQuery("Simple", typeName);
            return queryResult.Cast<EA.Element>().FirstOrDefault(element => (element.Type == "Class" || element.Type == "Enumeration") && element.Name == typeName);
        }

        /// <summary>
        /// Retrieves the EA attributes of stereotype 'XSDattribute' from the given XSD complex type.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public IList<EA.Attribute> GetXsdAttributes(EA.Element element)
        {
            var eaAttributeList = new List<EA.Attribute>();
            if (element.Type != "Class" && element.Stereotype != "XSDcomplexType")
                return eaAttributeList;

            eaAttributeList.AddRange(element.Attributes.Cast<EA.Attribute>().Where(attribute => attribute.Stereotype == "XSDattribute"));
            return eaAttributeList;
        }

        /// <summary>
        /// Retrieves the EA attributes of stereotype 'XSDelement' from the given XSD complex type.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public IList<EA.Attribute> GetXsdElements(EA.Element element)
        {
            var eaAttributeList = new List<EA.Attribute>();
            if (element.Type != "Class" && element.Stereotype != "XSDcomplexType")
                return eaAttributeList;

            eaAttributeList.AddRange(element.Attributes.Cast<EA.Attribute>().Where(attribute => attribute.Stereotype == "XSDelement"));
            return eaAttributeList;
        }

        public EA.Connector CreateXsdExtensionConnection(EA.Element child, EA.Element parent)
        {
            // Generalization of AbstractParameter
            var connector = (EA.Connector)child.Connectors.AddNew(string.Empty, "Generalization");
            connector.SupplierID = parent.ElementID;
            //connector.Stereotype = "XSDextension";
            if (!connector.Update())
                throw new EaAutomationException(connector.GetLastError());
            return connector;
            
        }
        /// <summary>
        /// Create a new XML schema complex type with the given name in the given EA package.
        /// </summary>
        /// <param name="package"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public EA.Element CreateXsdComplexType(EA.Package package, string name)
        {
            var newElement = (EA.Element)package.Elements.AddNew(name, "Class");
            newElement.Stereotype = "XSDcomplexType";
            newElement.Gentype = string.Empty;
            if (!newElement.Update())
                throw new EaAutomationException(newElement.GetLastError());

            AddTaggedValue(newElement, "maxOccurs", string.Empty, Resource.XsdTagMaxOccursNote);
            AddTaggedValue(newElement, "memberNames", string.Empty, Resource.XsdTagMemberNamesNote);
            AddTaggedValue(newElement, "minOccurs", string.Empty, Resource.XsdTagMinOccursNote);
            AddTaggedValue(newElement, "mixed", "false", Resource.XsdTagMixedNote);
            AddTaggedValue(newElement, "modelGroup", "sequence", Resource.XsdTagModelGroupNote);
            AddTaggedValue(newElement, "nillable", "false", Resource.XsdTagNillableNote);
            return newElement;
        }

        public void AddTaggedValue(EA.Attribute attribute, string tagName, string tagValue, string notes)
        {
            var taggedValue = attribute.TaggedValues.AddNew(tagName, tagValue);
            taggedValue.Notes = notes;
            if (!taggedValue.Update())
                throw new EaAutomationException(taggedValue.GetLastError());
            attribute.TaggedValues.Refresh();
        }

        public void AddTaggedValue(EA.Element element, string tagName, string tagValue, string notes)
        {
            var taggedValue = element.TaggedValues.AddNew(tagName, tagValue);
            taggedValue.Notes = notes;
            if (!taggedValue.Update())
                throw new EaAutomationException(taggedValue.GetLastError());
            element.TaggedValues.Refresh();
            //element.Refresh();
        }

    }
}