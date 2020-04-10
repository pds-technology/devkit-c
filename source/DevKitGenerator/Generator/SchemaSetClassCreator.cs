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
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using Energistics.DataAccess.Reflection;
using Energistics.SchemaGatherer;

namespace Energistics.Generator
{
    public class ChoiceElement
    {
        public string Name { get; set; }
    }

    public class Sequence : ChoiceElement
    {
        public List<ChoiceElement> Sequences { get; set; }

        public override string ToString()
        {
            if (Sequences == null)
            {
                return String.Empty;
            }
            else
            {
                string retval = String.Empty;

                foreach (ChoiceElement elem in Sequences)
                {
                    if (!String.IsNullOrEmpty(retval))
                    {
                        retval += ", ";
                    }
                    retval += elem.ToString();
                }

                return retval;
            }
        }

        public List<string> Flatten()
        {
            List<string> retStrings = new List<string>();
            foreach (ChoiceElement elem in Sequences)
            {
                if (elem is Sequence)
                {
                    retStrings.AddRange(((Sequence)elem).Flatten());
                }
                else
                {
                    retStrings.Add(elem.Name);
                }
            }
            return retStrings;
        }

        public bool IsSameSequence(string one, string two)
        {
            foreach (ChoiceElement elem in Sequences)
            {
                if (elem is Sequence)
                {
                    if (((Sequence)elem).Contains(one))
                    {
                        if (((Sequence)elem).Contains(two))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (elem.Name == one)
                    {
                        return false;
                    }
                }
            }

            throw new Exception("Element not found in sequence");
        }

        public bool Contains(string val)
        {
            foreach (ChoiceElement elem in Sequences)
            {
                if (elem is Sequence)
                {
                    if (((Sequence)elem).Contains(val))
                    {
                        return true;
                    }
                }
                else
                {
                    if (elem.Name == val)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public NormalElement Get(string val)
        {
            foreach (ChoiceElement elem in Sequences)
            {
                if (elem is Sequence)
                {
                    if (((Sequence)elem).Contains(val))
                    {
                        return ((Sequence)elem).Get(val);
                    }
                }
                else
                {
                    if (elem.Name == val)
                    {
                        return (NormalElement)elem;
                    }
                }
            }

            return null;
        }
    }

    public class NormalElement : ChoiceElement
    {
        public bool Unbounded { get; set; }

        public override string ToString()
        {
            if (Unbounded)
            {
                return Name + "[]";
            }
            else
            {
                return Name;
            }
        }
    }





    /// <summary>
    /// This is the helper class used by the EnergisticsTextTemplate.tt TextTemplate
    /// It is used to help generated the devkit
    /// </summary>
    public class SchemaSetClassCreator
    {
        private Dictionary<string, string> xmlSchemas = new Dictionary<string, string>();
        private List<Sequence> choices = new List<Sequence>();
        private List<string> enumClassNames;
        private string mlPath;
        private string mlVersion;
        private string versionString;

        /// <summary>
        /// Constructor
        /// </summary>
        public SchemaSetClassCreator(string mlPath, string mlVersion, List<string> enumClassNames, string versionString)
        {
            this.mlPath = mlPath;
            this.mlVersion = mlVersion;
            this.enumClassNames = enumClassNames;
            this.versionString = versionString;

            CacheAnnotations(mlPath);
        }

        private ChoiceElement ParseElement(XmlElement element)
        {
            if (element.Name == "xsd:sequence" || element.Name == "xs:sequence")
            {
                Sequence seq = new Sequence();
                seq.Sequences = new List<ChoiceElement>();

                foreach (XmlNode elem in element)
                {
                    if (elem is XmlElement)
                    {
                        if (elem.Name != "xsd:annotation" && elem.Name != "xs:annotation")
                        {
                            seq.Sequences.Add(ParseElement((XmlElement)elem));
                        }
                    }
                }

                return seq;
            }
            else if (element.Name == "xsd:element" || element.Name == "xs.element")
            {
                NormalElement normalElement = new NormalElement();
                if (element.Attributes["name"] != null)
                {
                    normalElement.Name = element.Attributes["name"].Value;
                }
                try
                {
                    normalElement.Unbounded = (element.Attributes["maxOccurs"].Value == "unbounded") ? true : false;
                }
                catch (Exception)
                {
                    normalElement.Unbounded = false;
                }
                return normalElement;
            }
            else
            {
                throw new Exception("Unexpected value!");
            }
        }


        /// <summary>
        /// Reads in XSD files so they can later be parsed for annotations
        /// </summary>
        private void CacheAnnotations(string mlPath)
        {
            foreach (string file in Directory.GetFiles(mlPath, "*.xsd"))
            {
                string xmlText = File.ReadAllText(file);

                ExtractXML(xmlText, "complexType");
                ExtractXML(xmlText, "group");
                ExtractXML(xmlText, "simpleType");
            }

            foreach (string file in Directory.GetFiles(mlPath, "*.xsd"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(file);
                CacheChoiceAnnotations(xmlDoc.GetElementsByTagName("xsd:choice"));
                CacheChoiceAnnotations(xmlDoc.GetElementsByTagName("xs:choice"));
            }
        }

        private void CacheChoiceAnnotations(XmlNodeList choiceElementList)
        {
            foreach (XmlElement choiceElements in choiceElementList)
            {
                XmlNode parent = choiceElements;

                do
                {
                    parent = parent.ParentNode;

                } while (parent.Name == "xsd:sequence" || parent.Name == "xs:sequence");

                // 1. if choice are single then it is exclusive.
                // 2. if choice are unbounded then it is not exclusive. ignore
                if (choiceElements.Attributes["maxOccurs"] != null)
                    if (((choiceElements.Attributes["maxOccurs"].Value == "unbounded" || (choiceElements.Attributes["maxOccurs"].Value.Contains("-1")))))
                        continue;
                Sequence choice = new Sequence();
                choice.Sequences = new List<ChoiceElement>();
                if (parent.Attributes["name"] != null)
                {
                    if (parent.Attributes["name"].Value.StartsWith("grp_"))
                    {
                        choice.Name = parent.Attributes["name"].Value.Replace("grp_", "obj_");
                    }
                    else
                        choice.Name = parent.Attributes["name"].Value;
                }
                choices.Add(choice);


                foreach (XmlElement element in choiceElements)
                {
                    if (element.Name != "xsd:annotation" && element.Name != "xs:annotation")
                    {
                        choice.Sequences.Add(ParseElement(element));
                    }
                }
            }
        }


        /// <summary>
        /// Parses out portions of xsd files based on regular expressions
        /// </summary>
        private void ExtractXML(string xmlText, string type)
        {
            string regexText = String.Format("<xsd?:{0} name=\"(.*?)\".*?</xsd?:{0}>", type);
            Regex regex = new Regex(regexText, RegexOptions.Singleline);

            foreach (Match m in regex.Matches(xmlText))
            {
                string name = m.Groups[1].Value;
                if (name.Contains("_"))
                {
                    name = name.Substring(name.IndexOf("_") + 1);
                }
                string xmlPiece = m.Groups[0].Value;

                if (xmlSchemas.ContainsKey(name))
                {
                    xmlSchemas[name] = xmlSchemas[name] + xmlPiece;
                }
                else
                {
                    xmlSchemas.Add(name, xmlPiece);
                }
            }
        }

        public IEnumerable<Type> Classes
        {
            get
            {
                //cs_documentInfoQueryPara is a hold over in PRODML from before the GDA web service existed.  It was used to place a date constraint on the 
                //entire query.  Gary Masters of Energistics confirmed that this should probably be removed from PRODML.  Since the class introduces an
                //inconsistency between PRODML and WITSML, and it should be obsolete, remove it.
                //
                //Also remove all classes whose name ends with a 1, except those classes that start with Item.  The 1 at the end of the class name is the result
                //of the component schemas being copied from WITSML into PRODML and their namespace changed.  This has the effect of generating two definitions
                //of each of these classes, the second having a '1' appended to its name.  By removing this one here and in the class rename method below,
                //the duplicate classes are removed.  Classes starting with Item are left in the list since those are generated as part of a XSD choice element.
                //XSD Choice elements need to be handled separately.
                return Assembly.GetExecutingAssembly().GetTypes().Except(new Type[] { this.GetType() }).Where(
                    (t) => !t.IsEnum
                        && t.Namespace == "Energistics.Generator." + mlVersion
                        && !t.Name.Equals("cs_documentInfoQueryPara")
                        && (!t.Name.EndsWith("1") || t.Name.StartsWith("Item") || mlVersion.Contains("ML2")));
            }
        }

        public IEnumerable<Type> Enums
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetTypes().Except(new Type[] { this.GetType() }).Where(
                    (t) => t.IsEnum
                        && t.Namespace == "Energistics.Generator." + mlVersion
                        && (!t.Name.EndsWith("1") || t.Name.StartsWith("Item") || mlVersion.Contains("ML2")));
            }
        }


        /// <summary>
        /// Gets the WITSML interface of data object.
        /// </summary>
        /// <param name="t">The data object type.</param>
        /// <returns>The WITSML interface in a string format</returns>
        public string GetDataObjectInterface(Type t)
        {
            var properties = t.GetProperties()
                .Where(x => x.Name.Contains("uid") || x.Name.Contains("name"))
                .Where(x => x.PropertyType == typeof(String))
                .Select(x => x.Name.ToLowerInvariant())
                .ToList();

            var interfaces = GetFamilyDataObjectInterface(t);
            if (t.GetProperty("commonData") != null && t.GetProperty("customData") != null)
            {
                interfaces += ", ICommonDataObject";
            }

            if (properties.Contains("uid") && properties.Contains("name")
                && properties.Contains("uidwell") && properties.Contains("namewell")
                && properties.Contains("uidwellbore") && properties.Contains("namewellbore"))
            {
                return interfaces + ", IWellboreObject";
            }
            if (properties.Contains("uid") && properties.Contains("name")
                && properties.Contains("uidwell") && properties.Contains("namewell"))
            {
                return interfaces + ", IWellObject";
            }
            if (properties.Contains("uid") && properties.Contains("name"))
            {
                return interfaces + ", IDataObject";
            }
            if (properties.Contains("uid"))
            {
                return interfaces + ", IUniqueId";
            }

            return interfaces;
        }

        public static string GetFamilyDataObjectInterface(Type t)
        {
            var name = t.Name;
            var attribute = t.GetCustomAttributes(typeof(EnergisticsDataObjectAttribute), false).FirstOrDefault() as EnergisticsDataObjectAttribute;
            if (attribute == null)
                return string.Empty;

            if (attribute.StandardFamily == "WITSML")
                return ", IWitsmlDataObject";
            if (attribute.StandardFamily == "PRODML")
                return ", IProdmlDataObject";
            if (attribute.StandardFamily == "RESQML")
                return ", IResqmlDataObject";

            return string.Empty;
        }

        public string GetPropertyType(PropertyInfo property)
        {
            if (property.DeclaringType.Name.EndsWith("ChannelData") && property.Name == "Data")
            {
                return typeof(XmlCDataSection).Name;
            }

            return RenameClass(property.PropertyType);
        }

        public bool IsComponentSchemaType(Type type)
        {
            return !type.Name.StartsWith("obj_") &&
                   !type.Name.Equals("abstractObject", StringComparison.InvariantCultureIgnoreCase) &&
                   !type.IsDefined(typeof(XmlRootAttribute), false);
        }

        public string GetFriendlyName(Type type)
        {
            // Get friendly name of common and generic types
            // https://stackoverflow.com/a/16466437/74601

            if (type == typeof(int))
                return "int";
            else if (type == typeof(short))
                return "short";
            else if (type == typeof(byte))
                return "byte";
            else if (type == typeof(bool))
                return "bool";
            else if (type == typeof(long))
                return "long";
            else if (type == typeof(float))
                return "float";
            else if (type == typeof(double))
                return "double";
            else if (type == typeof(decimal))
                return "decimal";
            else if (type == typeof(string))
                return "string";
            else if (type.IsGenericType)
                return type.Name.Split('`')[0] + "<" + string.Join(", ", type.GetGenericArguments().Select(GetFriendlyName).ToArray()) + ">";
            else
                return type.Name;
        }

        public bool IsEnergisticsCollection(Type t)
        {
            var name = RenameClass(t);
            return name.EndsWith("List") && !name.EndsWith("ValueList");
        }

        public string RenameClass(Type t, bool isDeclaration = false)
        {
            Type elementType = t.GetElementType();

            if (t.IsArray && elementType != typeof(byte))
            {
                string elementTypeName = RenameClass(elementType);

                return string.Format("List<{0}>", elementTypeName);
            }

            //If the type referred to isn't one of the xsd.exe generated types, don't rename it.
            if (!t.Assembly.Equals(Assembly.GetExecutingAssembly()))
            {
                return GetFriendlyName(t);
            }

            string newName = GetFriendlyName(t);
            newName = newName.Replace("obj_", "");

            newName = newName.Replace("cs_", "");

            newName = string.Format("{0}{1}", newName.Substring(0, 1).ToUpper(), newName.Substring(1, newName.Length - 1));

            if (!t.FullName.Contains("ML2"))
            {
                //There are two trajectoryStation and wbGeometry types in WITSML.  The cs_trajectoryStation is used when the station is a component of a larger
                //xml document.  The obj_trajectoryStation is used when the trajectory stations represent the top level object in the xml document.
                //Since trajectory stations are normally a part of a obj_trajectory document, allow that one to use the base name.  Follow a similar pattern
                //for wbGeometry.
                if (t.Name.Equals("obj_trajectoryStation") || t.Name.Equals("obj_wbGeometry") || t.Name.Equals("secondDefiningParameter") || t.Name.Equals("cs_resqmlPropertyKind"))
                {
                    newName = string.Format("StandAlone{0}", newName);
                }

                //The type listed below have both a class with the given name and an enumeration describing the "type" of that object.  Append "Type" to the name
                //of the enumeration to give them unique names.
                if (t.IsEnum && (newName.Equals("SupportCraft") || newName.Equals("TubularComponent")))
                {
                    newName = string.Format("{0}Type", newName);
                }

                //Rename plural class names to from [ClassName]s to [ClassName]List.
                if (t.Name.EndsWith("s") && !t.Name.EndsWith("Class") && !t.Name.EndsWith("Status") && !t.Name.EndsWith("Analysis") && !t.Name.StartsWith("cs_") && !t.Name.EndsWith("Press") && !t.Name.Equals("obj_capServers") && !t.Name.Equals("obj_capClients") && !t.Name.Equals("obj_capPublishers") && !t.Name.Equals("obj_capSubscribers"))
                {
                    newName = string.Format("{0}List", newName.Substring(0, newName.Length - 1));
                }

                //Rename 1 from the end of class names that are duplicated between PRODML and WITSML.
                if (t.Name.EndsWith("1") && !t.Name.StartsWith("Item"))
                {
                    newName = newName.Substring(0, newName.Length - 1);
                }

                newName = newName.Replace("Wb", "Wellbore");

                if (newName.Equals("Data"))
                {
                    newName = "LogCurveInfoData";
                }
            }

            if (t.FullName.Contains("PRODML2"))
            {
                if (!isDeclaration && t.Name.Equals("ValidationResult"))
                {
                    // the validationresult has duplication conflict with prodml 2.0 and system.ComponentModel.DataAnnotations
                    newName = t.FullName.Replace(".Generator.",".DataAccess.").Replace(".ValidationResult",".ReferenceData.ValidationResult");
                }
            }
			
			if (t.FullName.Contains("ML2"))
            {
                //Rename 1 from the end of class names that are duplicated between PRODML and WITSML.
                if (t.Name.EndsWith("1") && !t.Name.StartsWith("Item"))
                {
                    newName = newName.Substring(0, newName.Length - 1);
                }
            }

            //RESQML2.0 there is two same name class declared SecondDefiningParameter.
            if (t.FullName.Contains("secondDefiningParameter"))
            {
                newName = newName.Replace("SecondDefiningParameter", "SecondDefParameter");
            } 
             
            return newName;
        }

        /// <summary>
        /// Rename property name to be more .net compliant
        /// </summary>
        public string RenameProperty(PropertyInfo property)
        {
            string newName = property.Name;
            newName = RenamePropertyByName(newName);
            if (property.DeclaringType.Name.Equals("cs_pump") ||
                property.DeclaringType.Name.Equals("cs_bop") ||
                property.DeclaringType.Name.Equals("cs_bopComponent") ||
                property.DeclaringType.Name.Equals("cs_connection") ||
                property.DeclaringType.Name.Equals("cs_tubularComponent") ||
                property.DeclaringType.Name.Equals("cs_surfaceEquipment") ||
                property.DeclaringType.Name.Equals("cs_degasser"))
            {
                newName = newName.Replace("Id", "InnerDiameter");
            }

            if (property.DeclaringType.Name.Equals("Pump") ||
                property.DeclaringType.Name.Equals("Bop") ||
                property.DeclaringType.Name.Equals("BopComponent") ||
                property.DeclaringType.Name.Equals("Connection") ||
                property.DeclaringType.Name.Equals("TubularComponent") ||
                property.DeclaringType.Name.Equals("SurfaceEquipment") ||
                property.DeclaringType.Name.Equals("Degasser"))
            {
                newName = newName.Replace("Id", "InnerDiameter");
            }
			
            return newName;
        }

        /// <summary>
        /// Rename property name to be more .net compliant
        /// </summary>
        public string RenamePropertyByName(string newName)
        {
            newName = string.Format("{0}{1}", newName.Substring(0, 1).ToUpper(), newName.Substring(1, newName.Length - 1));
            if (newName.CompareTo("Participant") == 0)
            {
                newName = ReplaceSubstringIfNotPartial(newName, "Participant", "Participants");
            }
            if (newName.Contains("SecondDefiningParameter"))
            {
                newName="SecondDefPara";
            }
            newName = ReplaceSubstringIfNotPartial(newName, "Md", "MD");
            newName = ReplaceSubstringIfNotPartial(newName, "Div", "Division");
            newName = ReplaceSubstringIfNotPartial(newName, "Dls", "DoglegSeverity");
            newName = ReplaceSubstringIfNotPartial(newName, "DTim", "DateTime");
            newName = ReplaceSubstringIfNotPartial(newName, "Pc", "Percent");
            newName = ReplaceSubstringIfNotPartial(newName, "Pa", "PluggedAndAbandoned");
            newName = ReplaceSubstringIfNotPartial(newName, "Sg", "SG");
            newName = ReplaceSubstringIfNotPartial(newName, "Hc", "HC");
            newName = ReplaceSubstringIfNotPartial(newName, "Ph", "PH");
            newName = ReplaceSubstringIfNotPartial(newName, "Ht", "Height");
            newName = ReplaceSubstringIfNotPartial(newName, "Mn", "Min");
            newName = ReplaceSubstringIfNotPartial(newName, "Mx", "Max");
            newName = ReplaceSubstringIfNotPartial(newName, "Pv", "PV");
            newName = ReplaceSubstringIfNotPartial(newName, "Yp", "YP");
            newName = ReplaceSubstringIfNotPartial(newName, "Dl", "DL");
            newName = ReplaceSubstringIfNotPartial(newName, "De", "De");
            newName = ReplaceSubstringIfNotPartial(newName, "Ul", "UpperLeft");
            newName = ReplaceSubstringIfNotPartial(newName, "Ur", "UpperRight");
            newName = ReplaceSubstringIfNotPartial(newName, "Ll", "LowerLeft");
            newName = ReplaceSubstringIfNotPartial(newName, "Lr", "LowerRight");
            newName = ReplaceSubstringIfNotPartial(newName, "Wb", "Wellbore");
            newName = ReplaceSubstringIfNotPartial(newName, "IdSection", "InnerDiameterSection");
            newName = ReplaceSubstringIfNotPartial(newName, "Od", "OuterDiameter");
            newName = ReplaceSubstringIfNotPartial(newName, "Wt", "Weight");
            newName = ReplaceSubstringIfNotPartial(newName, "Tq", "Torque");
            newName = ReplaceSubstringIfNotPartial(newName, "Av", "Average");
            newName = ReplaceSubstringIfNotPartial(newName, "IdFishneck", "InnerDiameterFishneck");
            newName = ReplaceSubstringIfNotPartial(newName, "Ns", "NS");
            newName = ReplaceSubstringIfNotPartial(newName, "Ew", "EW");
            newName = ReplaceSubstringIfNotPartial(newName, "Ht", "Height");
            newName = ReplaceSubstringIfNotPartial(newName, "Ct", "CT");
            newName = ReplaceSubstringIfNotPartial(newName, "Hkld", "Hookload");
            newName = ReplaceSubstringIfNotPartial(newName, "Ld", "Load");
            newName = ReplaceSubstringIfNotPartial(newName, "IdLiner", "LinerSize");
            newName = ReplaceSubstringIfNotPartial(newName, "Dn", "Down");
            newName = ReplaceSubstringIfNotPartial(newName, "ETim", "ETime");
            newName = ReplaceSubstringIfNotPartial(newName, "Dh", "Downhole");
            newName = ReplaceSubstringIfNotPartial(newName, "Ca", "CA");
            newName = ReplaceSubstringIfNotPartial(newName, "Op", "Operating");

            return newName;
        }

        private string ReplaceSubstringIfNotPartial(string original, string substring, string replacement)
        {
            return Regex.Replace(original, substring + "([A-Z]|$)", replacement + "$1");
        }

        /// <summary>
        /// Get the namespace of a Type
        /// </summary>
        public string GetXmlNamespace(Type t)
        {
            object[] xmlTypes = t.GetCustomAttributes(typeof(XmlTypeAttribute), false);

            if (xmlTypes.Length == 1)
            {
                return (xmlTypes[0] as XmlTypeAttribute).Namespace;
            }

            return "http://www.witsml.org/schemas/131";
        }

        public string GetXmlRootName(Type t)
        {
            object[] xmlTypes = t.GetCustomAttributes(typeof(XmlRootAttribute), false);

            if (xmlTypes.Length == 1)
            {
                return (xmlTypes[0] as XmlRootAttribute).ElementName;
            }

            return null;
        }

        /// <summary>
        /// Gets the description for use in "summary" tags
        /// </summary>
        public string GetDescription(Type t, string name)
        {
            return GetDescription(t, name, String.Empty);
        }

        /// <summary>
        /// Gets the description for use in "summary" tags
        /// </summary>
        public string GetDescription(Type t, string name, string extraDesc)
        {
            string typeName = t.Name;
            if (typeName.Contains("_"))
            {
                typeName = typeName.Substring(typeName.IndexOf("_") + 1);
            }

            if (xmlSchemas.ContainsKey(typeName))
            {

                string xml = xmlSchemas[typeName];

                Regex regex = new Regex("<xsd?:(attribute name|element name|enumeration value)=\"" + name + "\"(?!.*/>).*?<xsd?:documentation>(.*?)</xsd?:documentation>", RegexOptions.Singleline);
                foreach (Match m in regex.Matches(xml))
                {
                    StringBuilder sb = new StringBuilder(Regex.Replace(m.Groups[2].Value, @"\s+", " "));
                    sb.Replace("&", "&amp;");
                    sb.Replace("<", "&lt;");
                    sb.Replace(">", "&gt;");

                    sb.Insert(0, "/// <summary>\n        /// ");
                    if (!String.IsNullOrEmpty(extraDesc))
                    {
                        if (!sb.ToString().EndsWith("."))
                        {
                            sb.Append(".");
                        }
                        sb.Append(" ");
                        sb.Append(extraDesc);
                    }
                    sb.Append("\n        /// </summary>");

                    string result = sb.ToString();
                    //if (result.Contains("/// DEPRECATED."))
                    //{
                    //    result += "\n        [Obsolete()]";
                    //}
                    return result;
                }
            }

            return "/// <summary>\n        /// " + name + " property\n        /// </summary>";
        }

        /// <summary>
        /// Gets the description for use in "summary" tags
        /// </summary>
        public string GetDescription(Type t)
        {
            string typeName = t.Name;

            if (typeName.Contains("_"))
            {
                typeName = typeName.Substring(typeName.IndexOf("_") + 1);
            }

            if (xmlSchemas.ContainsKey(typeName))
            {
                string xml = xmlSchemas[typeName];

                Regex regex = new Regex("name=\"\\w*?_" + typeName + "\">(.*?)<xsd?:documentation>(.*?)</xsd?:documentation>", RegexOptions.Singleline);
                foreach (Match m in regex.Matches(xml))
                {
                    if (m.Groups[1].Value.Contains(" name=\""))
                    {
                        break;
                    }
                    StringBuilder sb = new StringBuilder(m.Groups[2].Value);
                    sb.Replace("\n", " ");
                    sb.Replace("\r", " ");
                    sb.Replace("\t", " ");
                    sb.Replace("  ", " ");
                    sb.Replace("  ", " ");
                    sb.Replace("  ", " ");
                    return sb.ToString();
                }
            }

            return string.Format("This class represents the {0} xsd {1}.", t.Name, t.IsEnum ? "enumeration" : "type");
        }

        /// <summary>
        /// Differentiate the enum name from C# keywords.
        /// </summary>
        /// <param name="originalName">Name of the original enum.</param>
        /// <returns>The name of the enum after treatment.</returns>
        public string GetEnumName(string originalName)
        {
            //Some of the enumeration values duplicate the names of C# keywords.  In those cases, prepend an '@' to the name to indicate to the compiler
            //that the string should be treated literally.
            string[] keywords = new string[] { "float", "double", "int", "long", "short", "event", "in", "string", "byte", "default", "fixed", "base", "null" };

            if (keywords.Contains(originalName))
            {
                return "@" + originalName;
            }

            return originalName;
        }

        /// <summary>
        /// Overloads constructor to take name and uom properties if they exist
        /// Also overrides ToString() to make them display better
        /// </summary>
        public string GetConstructor(Type type)
        {
            StringBuilder sb = new StringBuilder("");

            if (!type.IsAbstract)
            {
                PropertyInfo uomProp = type.GetProperty("uom");
                PropertyInfo valueProp = type.GetProperty("Value");

                string renameClass = RenameClass(type);

                if (uomProp != null && valueProp != null)
                {
                    string uomType = RenameClass(uomProp.PropertyType);
                    string valueType = RenameClass(valueProp.PropertyType);
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Initializes a new instance of the " + renameClass + " class.");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        public " + renameClass + "() {}");
                    sb.AppendLine();
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Initializes a new instance of the " + renameClass + " class.");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        /// <param name=\"value\">Initial value</param>");
                    sb.AppendLine("        /// <param name=\"uom\">Initial unit of measure</param>");
                    sb.AppendLine("        public " + renameClass + "(" + valueType + " value, " + uomType + " uom)");
                    sb.AppendLine("        {");
                    sb.AppendLine("            this.Uom = uom;");
                    sb.AppendLine("            this.Value = value;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Returns a string that represents the current object.");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        public override string ToString()");
                    sb.AppendLine("        {");
                    sb.AppendLine("            return Value + \" \" + Uom;");
                    sb.AppendLine("        }");

                }
                else if (valueProp != null)
                {
                    string valueType = RenameClass(valueProp.PropertyType);
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Initializes a new instance of the " + renameClass + " class.");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        public " + renameClass + "() {}");
                    sb.AppendLine();
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Initializes a new instance of the " + renameClass + " class.");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        /// <param name=\"value\">Initial value</param>");
                    sb.AppendLine("        public " + renameClass + "(" + valueType + " value)");
                    sb.AppendLine("        {");
                    sb.AppendLine("            this.Value = value;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// Returns a string that represents the current object.");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        public override string ToString()");
                    sb.AppendLine("        {");
                    sb.AppendLine("            return Value.ToString();");
                    sb.AppendLine("        }");
                }
            }

            return sb.ToString();
        }

        String getPrivateFieldName(String name)
        {
            return name.Substring(0, 1).ToLower() + name.Substring(1, name.Length - 1);
        }

        /// <summary>
        /// Gets the body of a property. Handles properties that are part of a ordered sequence as well as
        /// the special "FieldSpecified" boolean flags.
        /// </summary>
        public string GetGetterSetter(XmlElementAttribute attr, Type type, PropertyInfo property)
        {
            if (attr != null)
            {
                string privateFieldName = attr.ElementName + "Field";
                string publicPropName = RenamePropertyByName(attr.ElementName);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("{");
                sb.AppendLine("            get {");
                sb.AppendLine("                return " + privateFieldName + ";");
                sb.AppendLine("            } ");
                sb.AppendLine("            set {");

                string array = GetArrayString(type, attr);

                foreach (Sequence choice in choices)
                {
                    if (choice.Name == type.Name)
                    {
                        foreach (XmlElementAttribute otherAttr in property.GetCustomAttributes(typeof(XmlElementAttribute), false))
                        {
                            if (attr.ElementName != otherAttr.ElementName)
                            {
                                // 1. if choice are single then it is exclusive.
                                // 2. if choice are unbounded then it is not exclusive. 
                                if (choice.Contains(attr.ElementName))
                                {
                                    if (!choice.IsSameSequence(attr.ElementName, otherAttr.ElementName))
                                    {
                                        sb.AppendLine("                if (value != null && " + RenamePropertyByName(otherAttr.ElementName) + "Specified" + ") throw new Exception(\"Cannot set property " + publicPropName + " when property " + RenamePropertyByName(otherAttr.ElementName) + " is already set\");");
                                    }
                                }
                            }
                        }
                    }
                }

                string wrapperClassName = RenameClass(attr.Type);
                string propertyName = getPrivateFieldName(publicPropName) + "Specified";
                sb.AppendLine("                " + privateFieldName + " = value;");

                sb.AppendLine("                " + publicPropName + "Specified = (value!=null);");
                sb.AppendLine("                NotifyPropertyChanged(\"" + publicPropName + "\");");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine();

                sb.AppendLine("        private " + wrapperClassName + (IsNullable(attr.Type) ? "?" : String.Empty) + array + " " + privateFieldName + "; ");
                sb.AppendLine("        private bool " + propertyName + " = false; ");
                sb.AppendLine();

                //here we need to need the specified property.
                sb.AppendLine("        /// <summary>");
                sb.AppendLine("        /// bool to indicate if " + publicPropName + " has been set. Used for serialization.");
                sb.AppendLine("        /// </summary>");
                sb.AppendLine("        [XmlIgnore]");
                sb.AppendLine("        public bool " + publicPropName + "Specified");
                sb.AppendLine("        {");
                sb.AppendLine("            get {");
                sb.AppendLine("                return " + propertyName + ";");
                sb.AppendLine("            }");
                sb.AppendLine("            set {");
                sb.AppendLine("                " + propertyName + "= value;");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                string realClassName = RenameClass(attr.Type);

                return sb.ToString();
            }
            else
            {
                var dataType = GetEnergisticsDataType(property);
                var isNullableEnum = MakePropertyNullable(property) == "?" && property.PropertyType.IsEnum; // Enums that will be converted to nullable values.
                var isSpecialCase = type.GetProperty(property.Name + "Specified") == null && (dataType == "TimeStamp" || isNullableEnum);
                //this section has run for every field in classes.
                string specifiedBool = RenameProperty(property) + "Specified";
                string privateFieldName = property.Name + "Field";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("{");
                sb.AppendLine("            get {");
                sb.AppendLine("                return " + privateFieldName + ";");
                sb.AppendLine("            } ");
                sb.AppendLine("            set {");
                sb.AppendLine("                " + privateFieldName + " = value;");
                if (type.GetProperty(property.Name + "Specified") != null || isSpecialCase)
                {
                    // If this property has a cooresponding 'PropertyName'Specified property, then the setter should also set that property to true
                    if ((property.PropertyType.IsEnum) || (property.PropertyType.IsValueType) || (property.PropertyType.FullName.ToLower().Contains("boolean")))
                    {
                        //ignore
                    }
                    else
                        sb.AppendLine("             if(value!=null) ");
                    sb.AppendLine("                 this." + specifiedBool + " = true;");
                }
                sb.AppendLine("                NotifyPropertyChanged(\"" + RenameProperty(property) + "\");");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine();

                if (isSpecialCase) // Special cases need the specified field and property added.
                {
                    sb.AppendLine("        ");
                    sb.AppendLine("        private bool " + specifiedBool + "Field = false;");
                    sb.AppendLine("        ");
                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// " + specifiedBool + " property");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine("        [XmlIgnore]");
                    sb.AppendLine("        [Browsable(false)]");
                    sb.AppendLine("        public bool " + specifiedBool + " {");
                    sb.AppendLine("            get {");
                    sb.AppendLine("                return " + specifiedBool + "Field;");
                    sb.AppendLine("            } ");
                    sb.AppendLine("            set {");
                    sb.AppendLine("                " + specifiedBool + "Field = value;");
                    sb.AppendLine("                NotifyPropertyChanged(\"" + specifiedBool + "\");");
                    sb.AppendLine("            }");
                    sb.AppendLine("        }");
                    sb.AppendLine("        ");
                }

                // create the Sepcified field for array list. thus prevent the nil output in xml.
                // from the research, there is two ways to prevent the null : 1. bool xxxSpecified property 2. ShouldSerializexxx() method
                if (IsArray(type, property))
                {
                    sb.AppendLine("         /// <summary>");
                    sb.AppendLine("         /// bool to indicate if " + RenameProperty(property) + " has been set. Used for serialization.");
                    sb.AppendLine("         /// </summary>");
                    sb.AppendLine("         [XmlIgnore]");
                    sb.AppendLine("         public bool " + specifiedBool);
                    sb.AppendLine("         {");
                    sb.AppendLine("             get {");
                    if (property.PropertyType == typeof(Byte)||property.PropertyType == typeof(Byte[]))
                    {
                        sb.AppendLine("             if("+privateFieldName +"!=null)");
                        sb.AppendLine("                 return " + privateFieldName + ".Length>0?true:false;");
                        sb.AppendLine("             else return false;");
                    }
                    else
                    {
                        sb.AppendLine("             if(" + privateFieldName + "!=null)");
                        sb.AppendLine("                 return " + privateFieldName + ".Count>0?true:false;");
                        sb.AppendLine("             else return false;");
                    }
                    sb.AppendLine("             }");
                    sb.AppendLine("         }");
                }
                bool addSchemaVersion = true;
                if (property.PropertyType != typeof(String) || privateFieldName != "versionField" || string.IsNullOrEmpty(versionString))
                    addSchemaVersion = false;
                if (!IsEnergisticsCollection(type) && !type.Name.Equals("obj_capServers") && !type.Name.Equals("obj_capClients") && !type.Name.Equals("obj_capPublishers") && !type.Name.Equals("obj_capSubscribers"))
                    addSchemaVersion = false;

                sb.AppendLine("        private " + GetPropertyType(property) + MakePropertyNullable(property) + " " + privateFieldName + (addSchemaVersion ? String.Format(" = \"{0}\"", versionString) : String.Empty) + "; ");


                return sb.ToString();
            }
        }

        /// <summary>
        /// Determines if a property can be made nullable
        /// </summary>
        public string MakePropertyNullable(PropertyInfo property)
        {
            if (property.GetCustomAttributes(typeof(XmlAttributeAttribute), false).Length == 0 &&
                property.GetCustomAttributes(typeof(XmlTextAttribute), false).Length == 0 &&
                property.PropertyType.IsValueType &&
                //!property.PropertyType.IsEnum && 
                !property.Name.EndsWith("Specified") &&
                !enumClassNames.Contains(property.PropertyType.Name)
                )
            {
                return "?";
            }
            else
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// xsd.exe implements choice attributes using a generic Item property.
        /// This method expands them back out to make them easier to use
        /// </summary>
        public string ExpandChoiceAttributes(Type type, PropertyInfo property)
        {
            StringBuilder sb = new StringBuilder();

            // Build an index to our attributes for easy reference
            Dictionary<string, XmlElementAttribute> attrIndex = new Dictionary<string, XmlElementAttribute>();
            Dictionary<string, EnergisticsDataTypeAttribute> typeIndex = new Dictionary<string, EnergisticsDataTypeAttribute>();
            var types = property.GetCustomAttributes(typeof(EnergisticsDataTypeAttribute), false).Cast<EnergisticsDataTypeAttribute>().ToList();
            foreach (XmlElementAttribute attr in property.GetCustomAttributes(typeof(XmlElementAttribute), false))
            {
                attrIndex.Add(attr.ElementName, attr);
                typeIndex.Add(attr.ElementName, types.Where(t => t.Name == attr.ElementName).FirstOrDefault());
            }



            foreach (Sequence choice in choices)
            {
                if (choice.Name == type.Name)
                {
                    foreach (string sequenceElement in choice.Flatten())
                    {
                        if (sequenceElement != null && attrIndex.ContainsKey(sequenceElement))
                        {
                            ExpandSingleChoiceAttributes(sb, type, property, attrIndex[sequenceElement], typeIndex[sequenceElement], choice);
                            attrIndex.Remove(sequenceElement);
                        }
                    }
                }
            }

            // this cause the object[]items wrong, it shoudl depends on the property type: array or single then create the correspondent properties.
            // if property is array create the choiceAttribute as array.
            // if property is single, then create signle choiceAttribute.

            // Write out the remaining attributes. Since they are not in sequences, order does not matter
            foreach (var kvp in attrIndex)
            {
                var attr = kvp.Value;
                ExpandSingleChoiceAttributes(sb, type, property, attr, typeIndex[kvp.Key], null);
            }


            return sb.ToString();
        }


        public string GetXmlElementOrXmlArray(Type type, PropertyInfo property)
        {
            object[] elementAttribute = property.GetCustomAttributes(typeof(XmlArrayItemAttribute), false);
            if (elementAttribute.Length > 0)
            {
                XmlArrayItemAttribute xaia = (XmlArrayItemAttribute)elementAttribute[0];

                string returnString = GetArrayPropertyElementName(property, xaia);
                returnString += String.Format("[XmlArray(\"{0}\")]", property.Name);
                return returnString;
            }
            else
            {
                object[] elementAttr = property.GetCustomAttributes(typeof(XmlElementAttribute), false);
                if (elementAttr.Length > 0)
                {
                    XmlElementAttribute xmlElemAttr = (elementAttribute[0] as XmlElementAttribute);
                    return GetXmlElementAttrTag(xmlElemAttr, property);
                }
                else
                {
                    var xmlElementAttrTag = "";
                    if (property.Name.Equals("Any"))
                    {
                        xmlElementAttrTag = String.Format("[XmlAnyElement]");

                    }
                    else
                    {
                        xmlElementAttrTag = String.Format("[XmlElement(\"{0}\"", property.Name);
                    
	                    if (property.DeclaringType.Name.EndsWith("ChannelData") && property.Name == "Data")
	                    {
	                        xmlElementAttrTag += String.Format(", Type=typeof({0})", typeof(XmlCDataSection).Name);
	                    }

                        xmlElementAttrTag += ")]";
                    }

                    return xmlElementAttrTag;
                }
            }
        }

        private string GetArrayPropertyElementName(PropertyInfo property, XmlArrayItemAttribute xaia)
        {
            string name = xaia.ElementName;
            if (string.IsNullOrEmpty(name))
            {
                if (property.PropertyType.IsArray)
                    name = GetTypeXmlTypeName(property.PropertyType.GetElementType());
                else
                    name = GetTypeXmlTypeName(property.PropertyType);
            }
            if (string.IsNullOrEmpty(name))
            {
                string dataType = GetEnergisticsDataType(property);
                if (!string.IsNullOrEmpty(dataType) && dataType != property.Name)
                    name = dataType;
            }
            if (string.IsNullOrEmpty(name))
            {
                if (property.PropertyType.IsArray)
                {
                    name = property.PropertyType.GetElementType().Name;
                }
                else
                    name = property.PropertyType.Name;
            }

            return String.Format("[XmlArrayItem(\"{0}\")]\n        ", name);
        }

        private string GetEnergisticsDataType(PropertyInfo property)
        {
            object[] dataTypes = property.GetCustomAttributes(typeof(EnergisticsDataTypeAttribute), false);
            if (dataTypes.Length > 0)
            {
                return ((EnergisticsDataTypeAttribute)dataTypes[0]).DataType;
            }

            return null;
        }

        private string GetTypeXmlTypeName(Type type)
        {
            object[] xmlTypes = type.GetCustomAttributes(typeof(XmlTypeAttribute), false);
            if (xmlTypes.Length == 0) return null;

            XmlTypeAttribute typeAttribute = ((XmlTypeAttribute)xmlTypes[0]);
            if (string.IsNullOrEmpty(typeAttribute.TypeName))
                return type.Name;

            return typeAttribute.TypeName;
        }

        /// <summary>
        /// Get the EnergisticsDataObject attribute string for the specified type.
        /// </summary>
        /// <param name="type">The type to create the attribute for.</param>
        /// <returns>A populated EnergisticsDataObject if the incoming type has this attribute.  The emptry string otherwise.</returns>
        public string GetEnergisticsDataObjectAttribute(Type type)
        {
            var attributes = type.GetCustomAttributes(typeof(EnergisticsDataObjectAttribute), false);
            if (attributes.Length == 0) return String.Empty;

            var attribute = ((EnergisticsDataObjectAttribute)attributes[0]);
            return "[" + typeof(EnergisticsDataObjectAttribute).Name + "(StandardFamily." + attribute.StandardFamily + ", \"" + attribute.DataSchemaVersion + "\")]" + Environment.NewLine + "    ";
        }

        /// <summary>
        /// Gets validation attributes to the property.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="property">The property.</param>
        /// <returns>
        /// The validation attributes for the property.
        /// </returns>
        public string GetValidationAttributes(Type type, PropertyInfo property)
        {
            StringBuilder sb = new StringBuilder();

            Action init = () =>
            {
                if (sb.Length > 0)
                    sb.AppendLine().Append("        ");
            };

            var reqs = property.GetCustomAttributes(typeof(RequiredAttribute), false);
            if (reqs.Length > 0)
            {
                init();
                var req = ((RequiredAttribute)reqs[0]);
                sb.Append("[Required]");
            }

            var regexs = property.GetCustomAttributes(typeof(RegularExpressionAttribute), false);
            if (regexs.Length > 0 && property.PropertyType == typeof(string))
            {
                init();
                var regex = ((RegularExpressionAttribute)regexs[0]);
                sb.AppendFormat("[RegularExpression(\"{0}\")]", regex.Pattern
                    .Replace("\\", "\\\\")
                    .Replace("\"", "\\\""));
            }

            var lengths = property.GetCustomAttributes(typeof(StringLengthAttribute), false);
            if (lengths.Length > 0)
            {
                init();
                var length = ((StringLengthAttribute)lengths[0]);
                sb.AppendFormat("[StringLength({0})]", length.MaximumLength);
            }

            var ranges = property.GetCustomAttributes(typeof(RangeAttribute), false);
            if (ranges.Length > 0)
            {
                init();
                var range = ((RangeAttribute)ranges[0]);
                sb.AppendFormat("[Range({0}, {1})]", range.Minimum, range.Maximum);
            }

            var descriptions = property.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (descriptions.Length > 0)
            {
                init();
                var desc = ((DescriptionAttribute)descriptions[0]);
                sb.AppendFormat("[Description(\"{0}\")]", desc.Description
                    .Replace("\\", "\\\\")
                    .Replace("\"", "\\\""));
            }

            var propType = property.PropertyType;
            var nested = IsNested(propType);

            if (nested)
            {
                init();
                sb.Append("[ComponentElement]");
            }
            else if (propType.IsArray && propType != typeof(byte[]))
            {
                init();
                sb.Append("[RecurringElement]");
            }

            var dataType = GetEnergisticsDataType(property);
            if (!string.IsNullOrEmpty(dataType))
            {
                init();
                sb.AppendFormat("[EnergisticsDataTypeAttribute(DataType = \"{0}\")]", dataType);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Used by ExpandChoiceAttributes
        /// </summary>
        private void ExpandSingleChoiceAttributes(StringBuilder sb, Type type, PropertyInfo property, XmlElementAttribute attr, EnergisticsDataTypeAttribute typeAttr, Sequence sequence)
        {
            string extraDesc = String.Empty;

            if (sequence != null)
            {
                string others = String.Empty;
                foreach (string s in sequence.Flatten())
                {
                    if (s != attr.ElementName && sequence.IsSameSequence(s, attr.ElementName))
                    {
                        if (others.Length != 0)
                        {
                            others += ", ";
                        }
                        others += RenamePropertyByName(s);
                    }
                }

                if (!String.IsNullOrEmpty(others))
                {
                    extraDesc = String.Format("If you set this property, you must also set {0}.", others);
                }
            }

            string array = GetArrayString(type, attr);

            sb.AppendLine("        " + GetDescription(type, attr.ElementName, extraDesc));

            var nested = IsNested(attr.Type);

            if (nested)
            {
                sb.AppendLine("        [ComponentElement]");
            }

            //make sure the type is specify in xmlelement annoatation , otherwise the xml output is invalidate.
            sb.AppendLine("        " + GetXmlElementAttrTag(attr, property));
            if (!string.IsNullOrEmpty(typeAttr?.DataType))
            {
                sb.AppendLine($"        [EnergisticsDataTypeAttribute(DataType = \"{typeAttr.DataType}\")]");
            }

            // sb.AppendLine("        [XmlElement(\"" + attr.ElementName + "\")]");
            //check whether this is override method.
            sb.AppendLine("        public " + getOverride(property) + RenameClass(attr.Type) + ((IsNullable(attr.Type)) ? "?" : String.Empty) + array + " " + RenamePropertyByName(attr.ElementName) + " " + GetGetterSetter(attr, type, property));
            
        }

        bool IsNullable(Type type)
        {

            if ((type.IsValueType && !enumClassNames.Contains(type.Name)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsNested(Type type, bool recursive = false)
        {
            return type.GetProperties()
                .Any(p => p.IsDefined(typeof(XmlElementAttribute), true) ||
                          p.IsDefined(typeof(XmlAttributeAttribute), true) ||
                          p.IsDefined(typeof(ValidationAttribute), true) ||
                          !recursive && IsNested(p.PropertyType, true));
        }

        private string GetArrayString(Type type, XmlElementAttribute attr)
        {
            string array = String.Empty;

            foreach (Sequence choice in choices)
            {
                if (choice.Name == type.Name)
                {
                    if (choice.Contains(attr.ElementName))
                    {
                        if (choice.Get(attr.ElementName).Unbounded)
                        {
                            array = "[]";
                            break;
                        }
                    }
                }
            }
            return array;
        }

        public bool IsArray(Type type, PropertyInfo property)
        {
            string className = RenameClass(type);
            if (property.PropertyType.IsArray)
            {
                return true;
            }
            return false;
        }

        public bool IsItemsList(Type type, PropertyInfo property)
        {
            string className = RenameClass(type);
            if (className.EndsWith("List") && property.PropertyType.IsArray)
            {
                if (className.Contains(RenameProperty(property)))
                {
                    return true;
                }

                string classes = RenameClass(property.PropertyType);
                Regex regex = new Regex(@"List<(\w*)>");
                if (regex.IsMatch(classes))
                {
                    string listType = regex.Match(classes).Groups[1].Value;

                    if (className.StartsWith(listType))
                    {
                        return true;
                    }
                    else if (listType == "Single" && className.StartsWith("FloatValue"))
                    {
                        return true;
                    }
                    else if (listType == "Int64" && className.StartsWith("LongValue"))
                    {
                        return true;
                    }
                    else if (listType == "Int16" && className.StartsWith("ShortValue"))
                    {
                        return true;
                    }
                    else if (listType == "Int32" && className.StartsWith("IntValue"))
                    {
                        return true;
                    }
                    else if (listType == "SByte" && className.StartsWith("ByteValue"))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gets a surrogate method for a property that is an XmlAttribute. 
        /// This is needed because you cannot serialize a complex type as an XmlAttribute
        /// </summary>
        public string GetSurrogate(Type type, PropertyInfo property)
        {
            StringBuilder sb = new StringBuilder();
            string propertyName = RenameProperty(property);
            string surrogateName = propertyName + "Surrogate";

            if (enumClassNames.Contains(property.PropertyType.Name))
            {
                sb.AppendLine("        public string " + surrogateName);
                sb.AppendLine("        {");
                sb.AppendLine("            get {");
                sb.AppendLine("                     if(" + propertyName + "==null)  return null;");
                sb.AppendLine("                     else return " + propertyName + ".Name; }");
                sb.AppendLine("            set { \n");
                sb.AppendLine("                 if(this." + propertyName + "== null)");
                sb.AppendLine("                 " + propertyName + "= new " + property.PropertyType.Name + "(value);");
                sb.AppendLine("                 else");
                sb.AppendLine("                   " + propertyName + ".Name = value; }");
                sb.AppendLine("        }");
                sb.AppendLine("        " + GetDescription(type, property.Name));
                sb.AppendLine("        [XmlIgnore]");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns the license text
        /// </summary>
        /// <returns>The license text as a commented string</returns>
        public static string GetLicenseText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("// ");

            string solutionFolder = Energistics.SchemaGatherer.SchemaGatherer.GetAppSetting("SOLUTION_FOLDER");
            if (Directory.Exists(solutionFolder))
            {
                if (!File.Exists("license.txt")) return "";
            }
            else
                return "";
            using (StreamReader sr = new StreamReader(Path.Combine(solutionFolder, "License.txt"), Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    sb.Append("// ");
                    sb.AppendLine(sr.ReadLine());
                }
            }
            sb.AppendLine("// ");

            return sb.ToString();
        }

        public string GetXmlElementAttrTag(XmlElementAttribute xmlElemAttr, PropertyInfo property)
        {
            string elementName = String.IsNullOrEmpty(xmlElemAttr.ElementName) ? property.Name : xmlElemAttr.ElementName;


            string xmlElementAttrTag = String.Format("[XmlElement(\"{0}\"", elementName);

            if (!String.IsNullOrEmpty(xmlElemAttr.Namespace))
            {
                xmlElementAttrTag += String.Format(", Namespace=\"{0}\"", xmlElemAttr.Namespace);
            }

            if (!String.IsNullOrEmpty(xmlElemAttr.DataType))
            {
                xmlElementAttrTag += String.Format(", DataType=\"{0}\"", xmlElemAttr.DataType);
            }

            xmlElementAttrTag += ")]";

            return xmlElementAttrTag;
        }
   
        //return this is override property
        internal String getOverride(PropertyInfo property)
        {
            if(property.Name.Contains("EnumValueStr"))
            {
                return " override ";
            }
            return "";
        }
    }
}
