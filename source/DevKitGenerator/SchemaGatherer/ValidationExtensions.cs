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
using Energistics.DataAccess.Reflection;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Energistics.SchemaGatherer
{
    /// <summary>
    /// Encapsulates methods to generate base data object classes with default .net validation attributes
    /// </summary>
    public static class ValidationExtensions
    {
        private const string EmlTimeStampPattern = ".+T.+[Z+\\-].*";

        /// <summary>
        /// Generates the data objects with code DOM.
        /// </summary>
        /// <param name="targetFolder">The target folder.</param>
        /// <param name="targetXmlFile">The target XML file specifying the list of top-level schemas to process.</param>
        /// <param name="nameSpace">The name space.</param>
        /// <param name="dataSchemaRootFolder">The root folder for the data schemas.</param>
        /// <param name="standardFamily">The standard family.</param>
        /// <param name="dataSchemaVersion">The data schema version.</param>
        /// <param name="dataObjects">The data objects.</param>
        /// <param name="schemaSubstitutions">The schema substitutions.  The keys are top-level schemas.  The values are included schemas that the top-level schemas are to be substituted for.</param>
        public static void GenerateDataObjectsWithCodeDom(string targetFolder, string targetXmlFile, string nameSpace, string dataSchemaRootFolder, string standardFamily, string dataSchemaVersion, List<string> dataObjects, Dictionary<string, string> schemaSubstitutions, Dictionary<string, string> namespaceSubstitutions)
        {
            var schemas = LoadAndCompileAllSchemas(targetXmlFile, dataSchemaRootFolder, schemaSubstitutions, namespaceSubstitutions);

            var codeProvider = CodeDomProvider.CreateProvider("CS");
            var codeNamespace = new CodeNamespace(nameSpace);
            var codeCompileUnit = new CodeCompileUnit();

            var outputFile = Path.Combine(targetFolder, "DataObject.cs");
            var options = CodeGenerationOptions.GenerateProperties;
            var version = "2.0.50727.3038";

            var importer = new XmlSchemaImporter(schemas, options, codeProvider, new ImportContext(new CodeIdentifiers(), false));
            var exporter = new XmlCodeExporter(codeNamespace, codeCompileUnit, codeProvider, options, null);

            codeNamespace.Imports.Add(new CodeNamespaceImport(typeof(XmlRootAttribute).Namespace));
            codeCompileUnit.Namespaces.Add(codeNamespace);

            AddNamespaceComments(codeNamespace, version);
            UpdateGeneratedCodeAttribute(exporter, version);

            foreach (XmlSchema schema in schemas)
            {
                ImportXmlSchema(schema, importer, exporter);
            }

            foreach (CodeTypeDeclaration typeDeclaration in codeNamespace.Types)
            {
                if (typeDeclaration.IsEnum && Has<XmlRootAttribute>(typeDeclaration))
                    typeDeclaration.CustomAttributes.Remove(Get<XmlRootAttribute>(typeDeclaration));
            }

            AddValidationAttributes(codeNamespace, schemas.ToList(), standardFamily, dataSchemaVersion, dataObjects);

            using (var writer = new StreamWriter(outputFile, false, Encoding.UTF8))
            {
                codeProvider.GenerateCodeFromCompileUnit(codeCompileUnit, writer, null);
            }
            SchemaGatherer.CleanUpGeneratedCode(outputFile);
        }

        private static void AddNamespaceComments(CodeNamespace codeNamespace, string version)
        {
            codeNamespace.Comments.Add(new CodeCommentStatement(""));
            codeNamespace.Comments.Add(new CodeCommentStatement(string.Format("This source code was auto-generated by xsd, Version={0}.", version)));
            codeNamespace.Comments.Add(new CodeCommentStatement(""));
        }

        private static void UpdateGeneratedCodeAttribute(XmlCodeExporter exporter, string version)
        {
            var property = exporter.GetType().GetProperty("GeneratedCodeAttribute", BindingFlags.Instance | BindingFlags.NonPublic);
            var attribute = property.GetValue(exporter, null) as CodeAttributeDeclaration;

            if (attribute == null) return;

            attribute.Arguments[0].Value = new CodePrimitiveExpression("xsd");
            attribute.Arguments[1].Value = new CodePrimitiveExpression(version);
        }

        private static void ImportXmlSchema(XmlSchema schema, XmlSchemaImporter importer, XmlCodeExporter exporter)
        {
            foreach (XmlSchemaElement element in schema.Elements.Values)
            {
                exporter.ExportTypeMapping(importer.ImportTypeMapping(element.QualifiedName));
            }
        }

        /// <summary>
        /// Gets the paths to top level schemas in the specified XML file.
        /// </summary>
        /// <param name="targetXmlFile">The target XML file.</param>
        /// <returns>The list of distinct top-level schema paths.</returns>
        private static IEnumerable<string> GetTopLevelSchemaPaths(string targetXmlFile)
        {
            var doc = XDocument.Load(targetXmlFile);
            if (doc.Root == null) return null;

            var ns = XNamespace.Get("http://microsoft.com/dotnet/tools/xsd/");
            var elements = doc.Root.Elements(ns + "generateClasses");

            return
                elements.Elements(ns + "schema")
                    .Select(schema => schema.Value.ToLowerInvariant()).Distinct();
        }

        /// <summary>
        /// Loads the schema from the specified path and sets its SourceUri.
        /// </summary>
        /// <param name="schemaPath">The path to the schema to load.</param>
        /// <param name="namespaceSubstitutions">Namespace substitutions.</param>
        /// <returns>The loaded schema.</returns>
        private static XmlSchema LoadSchema(string schemaPath, Dictionary<string, string> namespaceSubstitutions)
        {
            using (var stream = File.OpenRead(schemaPath))
            {
                var schema = XmlSchema.Read(stream, null);
                schema.SourceUri = Path.GetFullPath(schemaPath).ToLowerInvariant();

                string substitution;
                if (namespaceSubstitutions.TryGetValue(schema.TargetNamespace, out substitution))
                {
                    schema.TargetNamespace = substitution;
                }

                return schema;
            }
        }

        /// <summary>
        /// Loads the top level schemas from the specified XML file.
        /// </summary>
        /// <param name="targetXmlFile">The target XML file specifying the list of top-level schemas to process.</param>
        /// <param name="namespaceSubstitutions">Namespace substitutions.</param>
        /// <returns>A collection of the loaded top-level schemas.</returns>
        private static XmlSchemas LoadTopLevelSchemas(string targetXmlFile, Dictionary<string, string> namespaceSubstitutions)
        {
            var topLevelSchemas = new XmlSchemas();

            foreach (var schemaPath in GetTopLevelSchemaPaths(targetXmlFile))
            {
                topLevelSchemas.Add(LoadSchema(schemaPath, namespaceSubstitutions));
            }

            return topLevelSchemas;
        }

        /// <summary>
        /// Gets a mapping from schema paths to loaded schemas.  This takes into account the supplied
        /// mapping from top-level schemas to included schemas that they are to be substituted for.
        /// </summary>
        /// <param name="topLevelSchemas">The top level schemas that have been loaded.</param>
        /// <param name="schemaSubstitutions">The schema substitutions.  The keys are top-level schemas.  The values are included schemas that the top-level schemas are to be substituted for.</param>
        /// <returns>A mapping from paths to loaded schemas.  The keys are paths to loaded top-level schemas and included schemas with a top-level schema substitute.  The values are the schema to use for that path.</returns>
        private static Dictionary<string, XmlSchema> GetLoadedSchemasWithSbustituations(IEnumerable<XmlSchema> topLevelSchemas, Dictionary<string, string> schemaSubstitutions)
        {
            // Make sure type mappings are case insensitive.
            schemaSubstitutions = new Dictionary<string, string>(schemaSubstitutions, StringComparer.InvariantCultureIgnoreCase);

            var loadedSchemas = new Dictionary<string, XmlSchema>();
            foreach (var topLevelSchema in topLevelSchemas)
            {
                loadedSchemas.Add(topLevelSchema.SourceUri, topLevelSchema);

                // If this top-level schema is a substitute for an included schema,
                // add a mapping from the included schema's path to the top-level schema
                string alias;
                if (schemaSubstitutions.TryGetValue(topLevelSchema.SourceUri, out alias))
                {
                    loadedSchemas.Add(alias.ToLowerInvariant(), topLevelSchema);
                }
            }

            return loadedSchemas;
        }


        /// <summary>
        /// Loads and compiles all schemas specified in the target XML file.
        /// </summary>
        /// <param name="targetXmlFile">The target XML file specifying the list of top-level schemas to process.</param>
        /// <param name="dataSchemaRootFolder">The root folder for the data schemas.</param>
        /// <param name="schemaSubstitutions">The schema substitutions.  The keys are top-level schemas.  The values are included schemas that the schemas are to be substituted for.</param>
        /// <param name="namespaceSubstitutions">Namespace substitutions.</param>
        /// <returns>The loaded and compiled schemas.</returns>
        private static XmlSchemas LoadAndCompileAllSchemas(string targetXmlFile, string dataSchemaRootFolder, Dictionary<string, string> schemaSubstitutions, Dictionary<string, string> namespaceSubstitutions)
        {
            XmlSchemas topLevelSchemas = LoadTopLevelSchemas(targetXmlFile, namespaceSubstitutions);
            var loadedSchemas = GetLoadedSchemasWithSbustituations(topLevelSchemas, schemaSubstitutions);
            LoadIncludesFromAllSchemas(topLevelSchemas, dataSchemaRootFolder, loadedSchemas, schemaSubstitutions, namespaceSubstitutions);

            topLevelSchemas.Compile(null, true);

            return topLevelSchemas;
        }

        /// <summary>
        /// Loads the includes from all schemas.
        /// </summary>
        /// <param name="topLevelSchemas">The top-level schemas.</param>
        /// <param name="dataSchemaRootFolder">The data schema root folder.</param>
        /// <param name="loadedSchemas">The mapping for schema paths to schemas that have already been loaded or have substitutes loaded.</param>
        /// <param name="schemaSubstitutions">The schema substitutions.  The keys are top-level schemas.  The values are included schemas that the schemas are to be substituted for.</param>
        /// <param name="namespaceSubstitutions">Namespace substitutions.</param>
        private static void LoadIncludesFromAllSchemas(IEnumerable<XmlSchema> topLevelSchemas, string dataSchemaRootFolder, IDictionary<string, XmlSchema> loadedSchemas, Dictionary<string, string> schemaSubstitutions, Dictionary<string, string> namespaceSubstitutions)
        {
            foreach (var topLevelSchema in topLevelSchemas)
            {
                LoadIncludesFromSchema(topLevelSchema, loadedSchemas, dataSchemaRootFolder, schemaSubstitutions, namespaceSubstitutions);
                EnsureElementsForSimpleTypes(topLevelSchema);
            }
        }

        /// <summary>
        /// Gets the path to an included schema.
        /// </summary>
        /// <param name="externalSchema">The external schema.</param>
        /// <param name="parentSchema">The parent schema.</param>
        /// <param name="dataSchemaRootFolder">The data schema root folder.</param>
        /// <returns>The path to the included schema.</returns>
        private static string GetPathToExternalSchema(XmlSchemaExternal externalSchema, XmlSchemaObject parentSchema, string dataSchemaRootFolder)
        {
            if (string.IsNullOrEmpty(parentSchema.SourceUri))
                return string.Empty;

            var location = externalSchema.SchemaLocation;
            var parentSchemaFolder = Path.GetDirectoryName(parentSchema.SourceUri);
            if (string.IsNullOrEmpty(parentSchemaFolder))
                return string.Empty;

            var path = Path.Combine(parentSchemaFolder, location).ToLowerInvariant();

            if (!File.Exists(path))
                path = Path.Combine(dataSchemaRootFolder, location).ToLowerInvariant();

            return path;
        }

        /// <summary>
        /// Loads the includes from the specified parent schema.
        /// </summary>
        /// <param name="parentSchema">The parent schema.</param>
        /// <param name="loadedSchemas">The loaded schemas.</param>
        /// <param name="dataSchemaRootFolder">The data schema root folder.</param>
        /// <param name="schemaSubstitutions">The schema substitutions.  The keys are top-level schemas.  The values are included schemas that the schemas are to be substituted for.</param>
        /// <param name="namespaceSubstitutions">Namespace substitutions.</param>
        private static void LoadIncludesFromSchema(XmlSchema parentSchema, IDictionary<string, XmlSchema> loadedSchemas, string dataSchemaRootFolder, Dictionary<string, string> schemaSubstitutions, Dictionary<string, string> namespaceSubstitutions)
        {
            foreach (var include in parentSchema.Includes)
            {
                var externalSchema = include as XmlSchemaExternal;
                if (externalSchema == null || externalSchema is XmlSchemaImport || string.IsNullOrWhiteSpace(externalSchema.SchemaLocation))
                    continue;

                var path = GetPathToExternalSchema(externalSchema, parentSchema, dataSchemaRootFolder);

                string alias;
                if (schemaSubstitutions.TryGetValue(path, out alias))
                {
                    path = alias.ToLowerInvariant();
                }

                XmlSchema includedSchema;
                if (!loadedSchemas.TryGetValue(path, out includedSchema) && File.Exists(path))
                {
                    includedSchema = LoadSchema(path, namespaceSubstitutions);
                    loadedSchemas.Add(path, includedSchema);

                    LoadIncludesFromSchema(includedSchema, loadedSchemas, dataSchemaRootFolder, schemaSubstitutions, namespaceSubstitutions);
                }

                externalSchema.Schema = includedSchema;
                externalSchema.SchemaLocation = null;
            }
        }

        private static void EnsureElementsForSimpleTypes(XmlSchema topLevelSchema)
        {
            foreach (var schemaType in topLevelSchema.SchemaTypes.Values.OfType<XmlSchemaSimpleType>())
            {
                if (topLevelSchema.Elements.Values.Cast<XmlSchemaElement>()
                    .Any(x => x.SchemaTypeName == schemaType.QualifiedName))
                    continue;

                topLevelSchema.Items.Add(new XmlSchemaElement
                {
                    Name = schemaType.Name,
                    SchemaTypeName = schemaType.QualifiedName
                });
            }
        }

        private static void AddValidationAttributes(CodeNamespace codeNamespace, IList<XmlSchema> schemas, string standardFamily, string dataSchemaVersion, ICollection<string> dataObjects)
        {
            var types = new HashSet<string>();

            foreach (var schemaElement in schemas.SelectMany(schema => schema.Elements.Values.Cast<XmlSchemaElement>().Where(x => x != null)))
            {
                AddValidationAttributes(codeNamespace, schemaElement, standardFamily, dataSchemaVersion, dataObjects, types);
            }

            foreach (var schemaType in schemas.SelectMany(schema => schema.SchemaTypes.Values.OfType<XmlSchemaComplexType>()))
            {
                AddValidationAttributes(codeNamespace, schemaType, standardFamily, dataSchemaVersion, dataObjects, types);
            }
        }

        private static void AddValidationAttributes(CodeNamespace codeNamespace, XmlSchemaElement schemaElement, string standardFamily, string dataSchemaVersion, ICollection<string> dataObjects, ICollection<string> types)
        {
            var schemaType = schemaElement.ElementSchemaType as XmlSchemaComplexType;
            if (schemaType == null) return;

            AddValidationAttributes(codeNamespace, schemaType, standardFamily, dataSchemaVersion, dataObjects, types);
        }

        private static void AddValidationAttributes(CodeNamespace codeNamespace, XmlSchemaComplexType schemaType, string standardFamily, string dataSchemaVersion, ICollection<string> dataObjects, ICollection<string> types)
        {
            var typeDeclaration = GetTypeDeclaration(codeNamespace, schemaType.Name);

            if (typeDeclaration == null || types.Contains(typeDeclaration.Name)) return;

            types.Add(typeDeclaration.Name);

            if (dataObjects.Contains(typeDeclaration.Name) || schemaType?.BaseXmlSchemaType?.Name == "AbstractObject")
                AddEnergisticsDataObjectAttribute(typeDeclaration, standardFamily, dataSchemaVersion);

            foreach (var attribute in schemaType.AttributeUses.Values.OfType<XmlSchemaAttribute>())
            {
                AddAttributeValidation(codeNamespace, typeDeclaration, attribute);
            }

            var schemaSequence = schemaType.ContentTypeParticle as XmlSchemaSequence;
            if (schemaSequence == null) return;

            var elements = schemaSequence.Items.OfType<XmlSchemaSequence>()
                .SelectMany(x => x.Items.OfType<XmlSchemaElement>())
                .Union(schemaSequence.Items.OfType<XmlSchemaElement>());

            foreach (var element in elements)
            {
                AddElementValidation(codeNamespace, typeDeclaration, element);

                AddValidationAttributes(codeNamespace, element, standardFamily, dataSchemaVersion, dataObjects, types);
            }

            var choices = schemaSequence.Items.OfType<XmlSchemaSequence>()
                .SelectMany(x => x.Items.OfType<XmlSchemaChoice>())
                .Union(schemaSequence.Items.OfType<XmlSchemaChoice>());

            foreach (var choice in choices)
            {
                AddChoiceAttributes(codeNamespace, typeDeclaration, choice);
            }
        }

        private static void AddEnergisticsDataObjectAttribute(CodeTypeMember typeDeclaration, string standardFamily, string dataSchemaVersion)
        {
            typeDeclaration.CustomAttributes.Add(new CodeAttributeDeclaration(typeof(EnergisticsDataObjectAttribute).FullName,
                new CodeAttributeArgument(new CodePrimitiveExpression(standardFamily)), new CodeAttributeArgument(new CodePrimitiveExpression(dataSchemaVersion))));
        }

        private static void AddAttributeValidation(CodeNamespace codeNamespace, CodeTypeDeclaration typeDeclaration, XmlSchemaAttribute attribute)
        {
            var memberProperty = GetMemberProperty(typeDeclaration, attribute.Name);
            var restrictions = GetAttributeRestrictions(attribute).ToList();
            if (memberProperty == null) return;
            
            if (attribute.Use == XmlSchemaUse.Required)
            {
                AddRequiredAttribute(memberProperty);
            }

            AddRestrictionAttributes(codeNamespace, typeDeclaration, memberProperty, restrictions);
            AddDescriptionAttribute(memberProperty, GetAnnotation(attribute));

            AddAttributeDataType(attribute, memberProperty);
        }

        private static void AddElementValidation(CodeNamespace codeNamespace, CodeTypeDeclaration typeDeclaration, XmlSchemaElement element)
        {
            var memberProperty = GetMemberProperty(typeDeclaration, element.Name);
            var restrictions = GetElementRestrictions(element).ToList();

            if (memberProperty == null) return;

            var parentSequence = element.Parent as XmlSchemaSequence;
            var inOptionalSequence = parentSequence != null && parentSequence.MinOccurs == 0;

            if (element.MinOccurs > 0 && !inOptionalSequence)
            {
                AddRequiredAttribute(memberProperty);
            }

            var elementSchemaType = element.ElementSchemaType as XmlSchemaSimpleType;
            var unionType = elementSchemaType?.Content as XmlSchemaSimpleTypeUnion;
            var memberType = GetTypeDeclaration(codeNamespace, unionType?.MemberTypes[0].Name);

            if (memberType != null)
            {
                SetExtensibleEnum(typeDeclaration, memberProperty, memberType.Name);
            }

            AddRestrictionAttributes(codeNamespace, typeDeclaration, memberProperty, restrictions);
            AddDescriptionAttribute(memberProperty, GetAnnotation(element));

            AddElementDataType(element, memberProperty);
        }

        private static void AddAttributeDataType(XmlSchemaAttribute attribute, CodeMemberProperty memberProperty)
        {
            if (string.IsNullOrEmpty(attribute?.SchemaTypeName?.Name))
                return;

            AddDataType(memberProperty, attribute.Name, attribute.SchemaTypeName.Name);
        }

        private static void AddElementDataType(XmlSchemaElement element, CodeMemberProperty memberProperty)
        {
            if (string.IsNullOrEmpty(element?.SchemaTypeName?.Name))
                return;

            AddDataType(memberProperty, element.Name, element.SchemaTypeName.Name);
        }

        private static void AddDataType(CodeMemberProperty memberProperty, string name, string schemaType)
        {
            var dataTypeAttributes = GetAll<EnergisticsDataTypeAttribute>(memberProperty);
            CodeAttributeDeclaration dataTypeAttribute = null;
            if (dataTypeAttributes != null)
            {
                foreach (var attribute in dataTypeAttributes)
                {
                    bool hasElementName = false;
                    bool nameMatches = false;

                    if (attribute.Arguments.Count > 0 &&
                        string.IsNullOrEmpty(attribute.Arguments[0].Name) &&
                        attribute.Arguments[0].Value is CodePrimitiveExpression)
                    {
                        var expression = attribute.Arguments[0].Value as CodePrimitiveExpression;
                        if (expression.Value is string)
                        {
                            hasElementName = true;
                            if ((string)expression.Value == name)
                                nameMatches = true;
                        }
                    }

                    if (hasElementName && !nameMatches)
                        continue;

                    foreach (var arg in attribute.Arguments.Cast<CodeAttributeArgument>())
                    {
                        if ((!hasElementName || nameMatches) && arg.Name == "DataType")
                            return;
                    }

                    if (!hasElementName || nameMatches)
                        dataTypeAttribute = attribute;
                }
            }
            if (dataTypeAttribute == null)
            {
                dataTypeAttribute = new CodeAttributeDeclaration(new CodeTypeReference(typeof(EnergisticsDataTypeAttribute)));
                memberProperty.CustomAttributes.Add(dataTypeAttribute);
            }

            var n = new CodeAttributeArgument(new CodePrimitiveExpression(name));
            dataTypeAttribute.Arguments.Add(n);
            var dataType = new CodeAttributeArgument("DataType", new CodePrimitiveExpression(schemaType));
            dataTypeAttribute.Arguments.Add(dataType);
        }


        private static void AddRestrictionAttributes(CodeNamespace codeNamespace, CodeTypeDeclaration typeDeclaration, CodeMemberProperty memberProperty, IList<XmlSchemaFacet> restrictions)
        {
            if (!restrictions.Any()) return;

            if (memberProperty.Type.ArrayElementType == null)
            {
                AddValidationAttributes(typeDeclaration, memberProperty, restrictions);
            }
            else
            {
                var baseTypeDeclaration = GetTypeDeclaration(codeNamespace, memberProperty.Type.BaseType);

                if (baseTypeDeclaration == null) return;

                var xmlTextProperty = baseTypeDeclaration.Members.OfType<CodeMemberProperty>()
                    .FirstOrDefault(Has<XmlTextAttribute>);

                if (xmlTextProperty == null) return;

                AddValidationAttributes(baseTypeDeclaration, xmlTextProperty, restrictions);
            }
        }

        private static void AddRequiredAttribute(CodeTypeMember memberProperty)
        {
            memberProperty.CustomAttributes.Add(new CodeAttributeDeclaration(typeof(RequiredAttribute).FullName));
        }

        private static void AddValidationAttributes(CodeTypeDeclaration typeDeclaration, CodeMemberProperty memberProperty, IList<XmlSchemaFacet> facets)
        {
            var pattern = facets.OfType<XmlSchemaPatternFacet>().FirstOrDefault();
            var maxLength = facets.OfType<XmlSchemaMaxLengthFacet>().FirstOrDefault();

            var minInclusive = facets.OfType<XmlSchemaMinInclusiveFacet>().FirstOrDefault();
            var maxInclusive = facets.OfType<XmlSchemaMaxInclusiveFacet>().FirstOrDefault();

            if (pattern != null)
            {
                if (memberProperty.Type.BaseType == typeof(string).FullName && !Has<RegularExpressionAttribute>(memberProperty))
                {
                    if (EmlTimeStampPattern.Equals(pattern.Value))
                    {
                        if (!Has<XmlElementAttribute>(memberProperty) && !Has<XmlAttributeAttribute>(memberProperty))
                        {
                            SetTimestampType(typeDeclaration, memberProperty);
                        }
                        else
                        {
                            SetDateTimeType(typeDeclaration, memberProperty);
                        }
                    }
                    else
                    {
                        memberProperty.CustomAttributes.Add(new CodeAttributeDeclaration(typeof(RegularExpressionAttribute).FullName,
                            new CodeAttributeArgument(new CodePrimitiveExpression(pattern.Value))));
                    }
                }
                else if (memberProperty.Type.BaseType == typeof(DateTime).FullName)
                {
                    if (!Has<XmlElementAttribute>(memberProperty) && !Has<XmlAttributeAttribute>(memberProperty))
                    {
                        SetTimestampType(typeDeclaration, memberProperty);
                    }
                }
            }

            if (maxLength != null && memberProperty.Type.BaseType == typeof(string).FullName && !Has<StringLengthAttribute>(memberProperty))
            {
                memberProperty.CustomAttributes.Add(new CodeAttributeDeclaration(typeof(StringLengthAttribute).FullName,
                    new CodeAttributeArgument(new CodePrimitiveExpression(int.Parse(maxLength.Value)))));
            }

            if (minInclusive != null && maxInclusive != null && !Has<RangeAttribute>(memberProperty))
            {
                memberProperty.CustomAttributes.Add(new CodeAttributeDeclaration(typeof(RangeAttribute).FullName,
                    new CodeAttributeArgument(new CodePrimitiveExpression(double.Parse(minInclusive.Value))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(double.Parse(maxInclusive.Value)))));
            }
        }

        private static void AddChoiceAttributes(CodeNamespace codeNamespace, CodeTypeDeclaration typeDeclaration, XmlSchemaChoice choice)
        {
            if (choice.MinOccurs == 1 && choice.MaxOccurs == 1)
                UpdateSingleChoiceAttributes(codeNamespace, typeDeclaration, choice);

            foreach (var element in choice.Items.OfType<XmlSchemaElement>())
            {
                var memberProperty = GetChoiceMemberProperty(typeDeclaration, element.Name);
                if (memberProperty != null)
                    AddElementDataType(element, memberProperty);
            }
            foreach (var sequence in choice.Items.OfType<XmlSchemaSequence>())
            {

                foreach (var element in sequence.Items.OfType<XmlSchemaElement>())
                {
                    var memberProperty = GetChoiceMemberProperty(typeDeclaration, element.Name);
                    if (memberProperty != null)
                        AddElementDataType(element, memberProperty);
                }
            }
        }

        private static void UpdateSingleChoiceAttributes(CodeNamespace codeNamespace, CodeTypeDeclaration typeDeclaration, XmlSchemaChoice choice)
        {
            var memberProperty = GetMemberProperty(typeDeclaration, "Item");
            if (memberProperty == null) return;

            var attributes = GetAll<XmlElementAttribute>(memberProperty).ToList();
            if (!attributes.Any()) return;

            foreach (var element in choice.Items.OfType<XmlSchemaElement>())
            {
                var elementSchemaType = element.ElementSchemaType as XmlSchemaSimpleType;
                var simpleTypeList = elementSchemaType?.Content as XmlSchemaSimpleTypeList;
                if (simpleTypeList == null) continue;

                // Find the attribute for the current choice element
                var attribute = attributes.FirstOrDefault(x => element.Name == ((CodePrimitiveExpression)x.Arguments[0].Value).Value as string);
                var typeofExpression = attribute?.Arguments[1].Value as CodeTypeOfExpression;
                if (typeofExpression == null) continue;

                // Ignore if type is already a string
                if (typeofExpression.Type.BaseType == typeof(string).FullName) continue;

                var dataType = elementSchemaType.Datatype;
                if (typeofExpression.Type.BaseType == dataType.ValueType.FullName) continue;

                // Update data type for choice element attribute
                //typeofExpression.Type = new CodeTypeReference(dataType.ValueType);
                typeofExpression.Type = new CodeTypeReference(typeof(string));
            }
        }

        private static void SetDateTimeType(CodeTypeDeclaration typeDeclaration, CodeMemberProperty memberProperty)
        {
            SetMemberPropertyType(typeDeclaration, memberProperty, typeof(DateTime).FullName);
        }

        private static void SetTimestampType(CodeTypeDeclaration typeDeclaration, CodeMemberProperty memberProperty)
        {
            SetMemberPropertyType(typeDeclaration, memberProperty, typeof(DataAccess.Timestamp).FullName);
        }

        private static void SetExtensibleEnum(CodeTypeDeclaration typeDeclaration, CodeMemberProperty memberProperty, string typeName)
        {
            var typeReference = new CodeTypeReference(typeof(DataAccess.ExtensibleEnum<>).FullName, new[] { new CodeTypeReference(typeName) });
            SetMemberPropertyType(typeDeclaration, memberProperty, typeReference);
        }

        private static void SetMemberPropertyType(CodeTypeDeclaration typeDeclaration, CodeMemberProperty memberProperty, string typeName)
        {
            var typeReference = new CodeTypeReference(typeName);
            SetMemberPropertyType(typeDeclaration, memberProperty, typeReference);
        }

        private static void SetMemberPropertyType(CodeTypeDeclaration typeDeclaration, CodeMemberProperty memberProperty, CodeTypeReference typeReference)
        {
            var memberField = GetMemberField(typeDeclaration, memberProperty.Name + "Field");
            memberField.Type = typeReference;
            memberProperty.Type = typeReference;
        }

        private static void AddDescriptionAttribute(CodeMemberProperty memberProperty, string description)
        {
            if (string.IsNullOrEmpty(description) || Has<DescriptionAttribute>(memberProperty)) return;

            memberProperty.CustomAttributes.Add(new CodeAttributeDeclaration(typeof(DescriptionAttribute).FullName,
                new CodeAttributeArgument(new CodePrimitiveExpression(description))));

            memberProperty.Comments.Add(new CodeCommentStatement("<summary>" + description + "</summary>", true));
        }

        private static bool Has<T>(CodeTypeMember member)
        {
            return member.CustomAttributes
                .OfType<CodeAttributeDeclaration>()
                .Any(x => x.Name == typeof(T).FullName);
        }

        private static CodeAttributeDeclaration Get<T>(CodeTypeMember member)
        {
            return member.CustomAttributes
                .OfType<CodeAttributeDeclaration>()
                .FirstOrDefault(x => x.Name == typeof(T).FullName);
        }

        private static IEnumerable<CodeAttributeDeclaration> GetAll<T>(CodeTypeMember member)
        {
            return member.CustomAttributes
                .OfType<CodeAttributeDeclaration>()
                .Where(x => x.Name == typeof(T).FullName);
        }

        private static CodeTypeDeclaration GetTypeDeclaration(CodeNamespace codeNamespace, string schemaTypeName)
        {
            return codeNamespace.Types.Cast<CodeTypeDeclaration>()
                .FirstOrDefault(x => x.Name == schemaTypeName);
        }

        private static CodeMemberProperty GetMemberProperty(CodeTypeDeclaration typeDeclaration, string propertyName)
        {
            return typeDeclaration.Members.OfType<CodeMemberProperty>()
                .FirstOrDefault(x => string.Equals(x.Name, propertyName, StringComparison.InvariantCultureIgnoreCase));
        }

        private static CodeMemberProperty GetChoiceMemberProperty(CodeTypeDeclaration typeDeclaration, string propertyName)
        {
            return typeDeclaration.Members.OfType<CodeMemberProperty>()
                .FirstOrDefault(x => GetAll<XmlElementAttribute>(x).Any(y =>
                    {
                        if (y.Arguments.Count == 0 ||
                            !string.IsNullOrEmpty(y.Arguments[0].Name) ||
                            !(y.Arguments[0].Value is CodePrimitiveExpression))
                        {
                            return false;
                        }

                        var expression = y.Arguments[0].Value as CodePrimitiveExpression;

                        return expression.Value is string && (string)expression.Value == propertyName;
                    })
                );
        }

        private static CodeMemberField GetMemberField(CodeTypeDeclaration typeDeclaration, string propertyName)
        {
            return typeDeclaration.Members.OfType<CodeMemberField>()
                .FirstOrDefault(x => string.Equals(x.Name, propertyName, StringComparison.InvariantCultureIgnoreCase));
        }

        private static IEnumerable<XmlSchemaFacet> GetElementRestrictions(XmlSchemaElement schemaElement)
        {
            var facets = new List<XmlSchemaFacet>();

            GetSchemaTypeRestrictions(facets, schemaElement.ElementSchemaType as XmlSchemaSimpleType);

            var complexType = schemaElement.ElementSchemaType as XmlSchemaComplexType;
            if (complexType != null)
            {
                GetSchemaTypeRestrictions(facets, complexType.BaseXmlSchemaType as XmlSchemaSimpleType);
            }

            return facets;
        }

        private static IEnumerable<XmlSchemaFacet> GetAttributeRestrictions(XmlSchemaAttribute schemaAttribute)
        {
            var facets = new List<XmlSchemaFacet>();

            GetSchemaTypeRestrictions(facets, schemaAttribute.AttributeSchemaType);

            //var complexType = schemaAttribute.AttributeSchemaType as XmlSchemaComplexType;
            //if (complexType != null)
            //{
            //    GetSchemaTypeRestrictions(facets, complexType.BaseXmlSchemaType as XmlSchemaSimpleType);
            //}

            return facets;
        }

        private static void GetSchemaTypeRestrictions(ICollection<XmlSchemaFacet> facets, XmlSchemaSimpleType elementType)
        {
            while (elementType != null)
            {
                var restrictions = elementType.Content as XmlSchemaSimpleTypeRestriction;

                if (restrictions != null)
                {
                    foreach (var facet in restrictions.Facets.OfType<XmlSchemaFacet>().Where(facet => facets.All(x => x.GetType() != facet.GetType())))
                    {
                        facets.Add(facet);
                    }
                }

                elementType = elementType.BaseXmlSchemaType as XmlSchemaSimpleType;
            }
        }

        private static string GetAnnotation(XmlSchemaAnnotated annotated)
        {
            var description = string.Empty;

            if (annotated.Annotation != null)
            {
                description = annotated.Annotation.Items
                    .OfType<XmlSchemaDocumentation>()
                    .SelectMany(x => x.Markup)
                    .Select(x => x.InnerText
                        .Replace(Environment.NewLine, " ")
                        .Replace("\n", " ")
                        .Replace("\t", string.Empty)
                        .Trim())
                    .FirstOrDefault();
            }

            return description;
        }
    }
}
