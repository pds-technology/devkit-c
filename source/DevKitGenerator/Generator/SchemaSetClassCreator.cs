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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Energistics.Generator
{
    /// <summary>
    /// This is the helper class used by the EnergisticsTextTemplate.tt TextTemplate
    /// It is used to help generated the devkit
    /// </summary>
    public class SchemaSetClassCreator
    {   
        private Dictionary<string, string> xmlSchemas = new Dictionary<string, string>();
        private List<List<string>> choiceSequences = new List<List<string>>();
        private List<string> enumClassNames;
        private string mlPath;
        private string mlVersion;

        /// <summary>
        /// Constructor
        /// </summary>
        public SchemaSetClassCreator(string mlPath, string mlVersion, List<string> enumClassNames)
        {            
            this.mlPath = mlPath;
            this.mlVersion = mlVersion;
            this.enumClassNames = enumClassNames;

            CacheAnnotations(mlPath);
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
                foreach (XmlElement choiceElements in xmlDoc.GetElementsByTagName("xsd:choice"))
                {
                    foreach (XmlElement sequenceElements in choiceElements.GetElementsByTagName("xsd:sequence"))
                    {
                        List<string> singleSequence = new List<string>();
                        choiceSequences.Add(singleSequence);

                        foreach (XmlElement elementElement in sequenceElements.GetElementsByTagName("xsd:element"))
                        {
                            string name = elementElement.Attributes["name"].Value;
                            singleSequence.Add(name);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Parses out portions of xsd files based on regular expressions
        /// </summary>
        private void ExtractXML(string xmlText, string type)
        {
            string regexText = String.Format("<xsd:{0} name=\"(.*?)\".*?</xsd:{0}>", type);
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
                    (t) => !t.IsEnum && t.Namespace == "Energistics.Generator." + mlVersion && !t.Name.Equals("cs_documentInfoQueryPara") && (!t.Name.EndsWith("1") || t.Name.StartsWith("Item")));
            }
        }

        public IEnumerable<Type> Enums
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetTypes().Except(new Type[] { this.GetType() }).Where(
                    (t) => t.IsEnum && t.Namespace == "Energistics.Generator." + mlVersion && (!t.Name.EndsWith("1") || t.Name.StartsWith("Item")));
            }
        }


        public string RenameClass(Type t)
        {
            if (t.IsArray)
            {
                Type elementType = t.GetElementType();

                string elementTypeName = RenameClass(elementType);

                return string.Format("List<{0}>", elementTypeName);
            }

            //If the type referred to isn't one of the xsd.exe generated types, don't rename it.
            if(!t.Assembly.Equals(Assembly.GetExecutingAssembly()))
            {
                return t.Name;
            }

            string newName = t.Name;

            newName = newName.Replace("obj_", "");

            newName = newName.Replace("cs_", "");

            newName = string.Format("{0}{1}", newName.Substring(0, 1).ToUpper(), newName.Substring(1, newName.Length - 1));

            //There are two trajectoryStation and wbGeometry types in WITSML.  The cs_trajectoryStation is used when the station is a component of a larger
            //xml document.  The obj_trajectoryStation is used when the trajectory stations represent the top level object in the xml document.
            //Since trajectory stations are normally a part of a obj_trajectory document, allow that one to use the base name.  Follow a similar pattern
            //for wbGeometry.
            if (t.Name.Equals("obj_trajectoryStation") || t.Name.Equals("obj_wbGeometry"))
            {
                newName = string.Format("StandAlone{0}", newName);
            }

            //The type listed below have both a class with the given name and an enumeration describing the "type" of that object.  Append "Type" to the name
            //of the enumeration to give them unique names.
            if ( t.IsEnum && (newName.Equals("SupportCraft") || newName.Equals("TubularComponent")))
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

            return newName;
        }

        /// <summary>
        /// Rename property name to be more .net compliant
        /// </summary>
        public string RenamePropertyByName(string newName)
        {
            newName = string.Format("{0}{1}", newName.Substring(0, 1).ToUpper(), newName.Substring(1, newName.Length - 1));

            newName = newName.Replace("Md", "MD").
                        Replace("Div", "Division").
                        Replace("Dls", "DoglegSeverity").
                        Replace("DTim", "DateTime").
                        Replace("Pc", "Percent").
                        Replace("Pa", "PluggedAndAbandoned").
                        Replace("Sg", "SG").
                        Replace("Hc", "HC").
                        Replace("Ph", "PH").
                        Replace("Ht", "Height").
                        Replace("Mn", "Min").
                        Replace("Mx", "Max").
                        Replace("Pv", "PV").
                        Replace("Yp", "YP").
                        Replace("Dl", "DL").
                        Replace("De", "De").
                        Replace("Ul", "UpperLeft").
                        Replace("Ur", "UpperRight").
                        Replace("Ll", "LowerLeft").
                        Replace("Lr", "LowerRight").
                        Replace("Wb", "Wellbore").
                        Replace("IdSection", "InnerDiameterSection").
                        Replace("Od", "OuterDiameter").
                        Replace("Wt", "Weight").
                        Replace("Tq", "Torque").
                        Replace("Av", "Average").
                        Replace("IdFishneck", "InnerDiameterFishneck").
                        Replace("Ns", "NS").
                        Replace("Ew", "EW").
                        Replace("Ht", "Height").
                        Replace("Ct", "CT").
                        Replace("Hkld", "Hookload").
                        Replace("Ld", "Load").
                        Replace("IdLiner", "LinerSize").
                        Replace("Dn", "Down").
                        Replace("ETim", "ETime").
                        Replace("Dh", "Downhole");

            if (newName.Contains("Ca") && !(newName.Contains("Cap") || newName.Contains("Calibrate") || newName.Contains("Carry") ||
                newName.Contains("Cat")))
            {
                newName = newName.Replace("Ca", "CA");
            }

            if (newName.Contains("Op") && !(newName.Contains("Operating") || newName.Contains("Open") || newName.Contains("Operator")))
            {
                newName = newName.Replace("Op", "Operating");
            }
            return newName;
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

                Regex regex = new Regex("<xsd:(attribute name|element name|enumeration value)=\"" + name + "\"(?!.*/>).*?<xsd:documentation>(.*?)</xsd:documentation>", RegexOptions.Singleline);
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
                    if (result.Contains("/// DEPRECATED."))
                    {
                        result += "\n        [Obsolete()]";
                    }
                    return result;
                }
            }

            return String.Empty;
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

                Regex regex = new Regex("name=\"\\w*?_" + typeName + "\">(.*?)<xsd:documentation>(.*?)</xsd:documentation>", RegexOptions.Singleline);
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

            return string.Format("This class represents the {0} xsd {1}.", t.Name, t.IsEnum ? "enumeration" : "type" );
        }

        public string GetEnumName(string originalName)
        {
            //Some of the enumeration values duplicate the names of C# keywords.  In those cases, prepend an '@' to the name to indicate to the compiler
            //that the string should be treated literally.
            string[] keywords = new string[] { "float", "double", "int", "long", "short", "event", "in", "string", "byte", "default", "fixed" };

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

                if (uomProp != null && valueProp != null)
                {
                    string uomType = RenameClass(uomProp.PropertyType);
                    string valueType = RenameClass(valueProp.PropertyType);
                    sb.AppendLine("        public " + RenameClass(type) + "() {}");
                    sb.AppendLine("        public " + RenameClass(type) + "(" + valueType + " value, " + uomType + " uom)");
                    sb.AppendLine("        {");
                    sb.AppendLine("            this.Uom = uom;");
                    sb.AppendLine("            this.Value = value;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                    sb.AppendLine("        public override string ToString()");
                    sb.AppendLine("        {");
                    sb.AppendLine("            return Value + \" \" + Uom;");
                    sb.AppendLine("        }");

                }
                else if (valueProp != null)
                {
                    string valueType = RenameClass(valueProp.PropertyType);
                    sb.AppendLine("        public " + RenameClass(type) + "() {}");
                    sb.AppendLine("        public " + RenameClass(type) + "(" + valueType + " value)");
                    sb.AppendLine("        {");
                    sb.AppendLine("            this.Value = value;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                    sb.AppendLine("        public override string ToString()");
                    sb.AppendLine("        {");
                    sb.AppendLine("            return Value.ToString();");
                    sb.AppendLine("        }");
                }
            }

            return sb.ToString();
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

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("{");
                sb.AppendLine("            get {");
                sb.AppendLine("                return " + privateFieldName + ";");
                sb.AppendLine("            } ");
                sb.AppendLine("            set { ");
                
                // If this attribute is part of a sequence, find that sequence
                List<string> mySequence = new List<string>();
                foreach (List<string> seq in choiceSequences)
                {
                    if (seq.Contains(attr.ElementName))
                    {
                        mySequence = seq;
                        break;
                    }
                }

                // Throw exceptions if any other attribute from this choice is set (that is not in my sequence)
                foreach (XmlElementAttribute otherAttr in property.GetCustomAttributes(typeof(XmlElementAttribute), false))
                {
                    if (otherAttr.ElementName != attr.ElementName)
                    {
                        if (!mySequence.Contains(otherAttr.ElementName))
                        {
                            sb.AppendLine("                if (" + otherAttr.ElementName + "FieldSpecified" + ") throw new Exception(\"Cannot set property " + RenamePropertyByName(attr.ElementName) + " when property " + RenamePropertyByName(otherAttr.ElementName) + " is already set\");");
                        }
                    }
                }
                sb.AppendLine("                " + privateFieldName + " = value;");
                sb.AppendLine("                " + privateFieldName + "Specified = true;");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine();
                sb.AppendLine("        private " + RenameClass(attr.Type) + " " + privateFieldName + "; ");
                sb.AppendLine("        private bool " + privateFieldName + "Specified = false; ");

                return sb.ToString();
            }
            else
            {
                // If this property has a cooresponding 'PropertyName'Specified property, then the setter should also set that property to true
                if (type.GetProperty(property.Name + "Specified") != null)
                {
                    string specifiedBool = RenameProperty(property) + "Specified";
                    string privateFieldName = property.Name + "Field";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("{");
                    sb.AppendLine("            get {");
                    sb.AppendLine("                return " + privateFieldName + ";");
                    sb.AppendLine("            } ");
                    sb.AppendLine("            set { ");
                    sb.AppendLine("                " + privateFieldName + " = value;");
                    sb.AppendLine("                this." + specifiedBool + " = true;");
                    sb.AppendLine("            }");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                    sb.AppendLine("        private " + RenameClass(property.PropertyType) + MakePropertyNullable(property) + " " + privateFieldName + "; ");

                    return sb.ToString();
                }
                else
                {
                    return "{ get; set; }";
                }
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
            foreach (XmlElementAttribute attr in property.GetCustomAttributes(typeof(XmlElementAttribute), false))
            {
                attrIndex.Add(attr.ElementName, attr);
            }

            // If our attributes are part of sequences, do them in the correct order
            foreach (List<string> sequence in choiceSequences)
            {
                foreach (string sequenceElement in sequence)
                {
                    if (attrIndex.ContainsKey(sequenceElement))
                    {
                        ExpandSingleChoiceAttributes(sb, type, property, attrIndex[sequenceElement], sequence);
                        attrIndex.Remove(sequenceElement);
                    }
                }
            }

            // Write out the remaining attributes. Since they are not in sequences, order does not matter
            foreach (XmlElementAttribute attr in attrIndex.Values)
            {
                ExpandSingleChoiceAttributes(sb, type, property, attr, null);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Used by ExpandChoiceAttributes
        /// </summary>
        private void ExpandSingleChoiceAttributes(StringBuilder sb, Type type, PropertyInfo property, XmlElementAttribute attr, List<string> sequence)
        {
            string extraDesc = String.Empty;

            if (sequence != null)
            {
                string others = String.Empty;
                foreach (string s in sequence)
                {
                    if (s != attr.ElementName)
                    {
                        if (others.Length != 0)
                        {
                            others += ", ";
                        }
                        others += RenamePropertyByName(s);
                    }
                }

                extraDesc = String.Format("If you set this property, you must also set {0}.", others);
            }

            

            sb.AppendLine("        " + GetDescription(type, attr.ElementName, extraDesc));
            sb.AppendLine("        [XmlElement(\"" + attr.ElementName + "\")]");
            sb.AppendLine("        public " + RenameClass(attr.Type) + " " + RenamePropertyByName(attr.ElementName) + " " + GetGetterSetter(attr, type, property)); 
        }

        /// <summary>
        /// Gets a surrogate method for a property that is an XmlAttribute. 
        /// This is needed because you cannot serialize a complex type as an XmlAttribute
        /// </summary>
        public string GetSurrogate(PropertyInfo property)
        {
            StringBuilder sb = new StringBuilder();
            string propertyName = RenameProperty(property);
            string surrogateName = propertyName + "Surrogate";

            if (enumClassNames.Contains(property.PropertyType.Name))
            {
                sb.AppendLine("        private string " + surrogateName);
                sb.AppendLine("        {");
                sb.AppendLine("            get { return " + propertyName + ".Name; }");
                sb.AppendLine("            set { " + propertyName + ".Name = value; }");
                sb.AppendLine("        }");
                sb.AppendLine();
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
    
    }
}
