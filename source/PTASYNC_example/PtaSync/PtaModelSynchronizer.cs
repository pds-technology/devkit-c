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
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace PtaSync
{
    public class PtaModelSynchronizer : IDisposable
    {
        private EA.Repository _eaRepository;
        private EA.Element _abstractParameterElement;
        private readonly _Worksheet _xlParameterSheet;
        private readonly _Worksheet _xlModelSheet;
        private Application _xlApp;
        private Workbook _xlBook;
        private readonly Dictionary<string, string> _excelParameters = new Dictionary<string, string>();
        private readonly Dictionary<string, string> _excelModels = new Dictionary<string, string>();
        private readonly Dictionary<string, EA.Element> _sectionBaseType = new Dictionary<string, EA.Element>();
        private readonly EaAutomationUtil _eaAutomationUtil;

        public PtaModelSynchronizer(string excelFilePathName, string eaModelFileName)
        {
            //Start Excel and get Application object.
            _xlApp = new Application { Visible = false };
            _xlBook = _xlApp.Workbooks.Open(excelFilePathName, true, true);
            _xlParameterSheet = (_Worksheet)_xlBook.Sheets["Parameters"];
            _xlModelSheet = (_Worksheet)_xlBook.Sheets["Models"];
            _eaRepository = new EA.Repository();
            _eaRepository.OpenFile(eaModelFileName);
            _eaAutomationUtil = new EaAutomationUtil(_eaRepository);
        }

        public void Synchronize()
        {
            // Navigate the model and find the PtaParameters schema.
            var model = (EA.Package)_eaRepository.Models.GetByName("pta");
            var package = (EA.Package)model.Packages.GetByName("pta");
            var xsdSchemaPackage = (EA.Package)package.Packages.GetByName("xsd_schema");
            SyncParameters(xsdSchemaPackage);
            SyncModels(xsdSchemaPackage);
        }

        private void SyncModels(EA.Package package)
        {
            var schema = (EA.Package)package.Packages.GetByName("PtaModels");
            // Find the AbstractParameter base class
            var abstractModel = _eaAutomationUtil.FindXsdTypeByName("AbstractModelSection");

            for (var rowIndex = 5; ; rowIndex++)
            {
                var modelName = GetModelName(rowIndex);
                if (String.IsNullOrWhiteSpace(modelName))
                    break;

                if (_excelModels.ContainsKey(modelName))
                {
                    Trace.TraceWarning("Duplicate model '{0}' found in spreadsheet.", modelName);
                    continue;
                }
                _excelModels.Add(modelName, modelName);
                var modelNote = GetExcelCellText(_xlModelSheet, rowIndex, "C");
                var sectionName = GetExcelCellText(_xlModelSheet, rowIndex, "D");
                var isAbstract = GetExcelCellText(_xlModelSheet, rowIndex, "E");
           
                // Create a new parameter
                var baseTypeElement = isAbstract == "1" ? abstractModel : _sectionBaseType[sectionName];
                var modelType = GetOrCreateComplexType(schema, modelName, baseTypeElement);
                modelType.Abstract = isAbstract;
                // Notes
                modelType.Notes = modelNote != "0" ? modelNote : string.Empty;
                modelType.Update();

                // Store abstract base type in dictionary for each section.
                if (isAbstract == "1")
                {
                    _sectionBaseType.Add(sectionName, modelType);
                    //_eaAutomationUtil.CreateXsdExtensionConnection(modelType, abstractModel);
                }
                // For non-abstract models, extend from abstract base type.
                //else
                //{
                //    var sectionBaseType = _sectionBaseType[sectionName];
                //    _eaAutomationUtil.CreateXsdExtensionConnection(modelType, sectionBaseType);
                //}

                // Add Parameters
                const int validColumnCheckRow = 2;
                const int elementNameRow = 4;
                for (var colIndex = 6; ; colIndex++)
                {
                    var checkValue = GetExcelCellText(_xlModelSheet, validColumnCheckRow, colIndex);
                    if (String.IsNullOrWhiteSpace(checkValue))
                        break;

                    var attributeType = GetExcelCellText(_xlModelSheet, elementNameRow, colIndex);
                    var attributeName = Char.ToLower(attributeType[0]) + attributeType.Substring(1);

                    // *** NOTE: Temporary workaround for 
                    if (attributeType.Equals("AnyParameter"))
                        attributeType = "AbstractParameter";

                    var code = GetExcelCellText(_xlModelSheet, rowIndex, colIndex);
                    // cell must be non-zero to include parameter
                    if (code == "0")
                        continue;

                    // Skip parameter if it already exists, either in this type or in the abstract base type.
                    var attribute = _eaAutomationUtil.GetAttributeByName(modelType, attributeName);
                    if (attribute != null)
                        continue;

                    // 0 => Parameter not used for this model
                    // 1 => cardinality 1..1 (required)
                    // 2 => cardinality 0..1 (optional)
                    // 3 => cardinality 0..* 
                    var lowerBound = code == "1" ? "1" : "0";
                    var upperBound = code == "3" ? "-1" : "1";
                    _eaAutomationUtil.CreateXsdElement(modelType, attributeName, attributeType, lowerBound, upperBound);
                    modelType.Update();
                    modelType.Attributes.Refresh();
                    modelType.AttributesEx.Refresh();
                }
            }
        }

        private void SyncParameters(EA.Package package)
        {
            var schema = (EA.Package) package.Packages.GetByName("PtaParameters");

            // Find the AbstractParameter base class
            _abstractParameterElement = _eaAutomationUtil.FindXsdTypeByName("AbstractParameter");

            for (var parameterRowIndex = 3;; parameterRowIndex++)
            {
                var parameterName = GetParameterName(parameterRowIndex);
                if (String.IsNullOrWhiteSpace(parameterName))
                    break;

                if (_excelParameters.ContainsKey(parameterName))
                {
                    Trace.TraceWarning("Duplicate parameter '{0}' found in spreadsheet.", parameterName);
                    continue;
                }
                _excelParameters.Add(parameterName, parameterName);
                var abbreviation = GetExcelCellText(_xlParameterSheet, parameterRowIndex, "B");
                var measureName = GetExcelCellText(_xlParameterSheet, parameterRowIndex, "C");
                var measureTypeName = GetExcelCellText(_xlParameterSheet, parameterRowIndex, "D");
                var parameterNote = GetExcelCellText(_xlParameterSheet, parameterRowIndex, "E");

                // Create a new parameter
                var umlParameter = GetOrCreateEaParameter(schema, parameterName);

                // Notes
                umlParameter.Notes = parameterNote != "0" ? parameterNote : string.Empty;

                // Abbreviation element
                if (!String.IsNullOrWhiteSpace(abbreviation))
                {
                    var abbreviationAttr = _eaAutomationUtil.CreateXsdElement(umlParameter, "abbreviation", "string", "1", "1");
                    var fixedTag = abbreviationAttr.TaggedValues.GetByName("fixed");
                    fixedTag.Value = abbreviation;
                    fixedTag.Update();
                }

                // Value element
                _eaAutomationUtil.CreateXsdElement(umlParameter, measureName, measureTypeName, "1", "1");

                umlParameter.Update();
            }
            PruneOldParameters(schema);
            _eaRepository.SaveAllDiagrams();
        }

        private void PruneOldParameters(EA.Package package)
        {
            for (short idx=0; idx < package.Elements.Count; idx++)
            {
                var element = (EA.Element)package.Elements.GetAt(idx);
                if (_excelParameters.ContainsKey(element.Name) || 
                    element.Name.Equals("AbstractParameter")) 
                    continue;

                Trace.TraceInformation("Deleting parameter '{0}' from EA model.", element.Name);
                package.Elements.Delete(idx);
            }
            package.Elements.Refresh();
        }

        private EA.Element GetOrCreateComplexType(EA.Package package, string name, EA.Element baseTypeElement)
        {
            EA.Element eaElement = null;
            try
            {
                eaElement = (EA.Element)package.Elements.GetByName(name);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch (Exception)
            // ReSharper restore EmptyGeneralCatchClause
            {
            }

            // Existing parameter class found in EA model. Remove existing attributes and return.
            if (eaElement != null)
            {
                Trace.WriteLine(String.Format("Updating EA type '{0}'", name));
                for (short idx = 0; idx < eaElement.Attributes.Count; idx++)
                    eaElement.Attributes.Delete(idx);
                eaElement.Attributes.Refresh();
                return eaElement;
            }

            // Create a new parameter class in the EA model.
            Trace.WriteLine(String.Format("Creating new EA complex type '{0}'", name));
            var newElement = _eaAutomationUtil.CreateXsdComplexType(package, name);
            if (baseTypeElement != null)
            {
                // Create a generalization association
                _eaAutomationUtil.CreateXsdExtensionConnection(newElement, _abstractParameterElement);
            }
            return newElement;
        }

        private EA.Element GetOrCreateEaParameter(EA.Package package, string parameterName)
        {
            var eaParameterElement = GetOrCreateComplexType(package, parameterName, _abstractParameterElement);
            return eaParameterElement;
        }

        private string GetModelName(int rowIndex)
        {
            var name = GetExcelCellText(_xlModelSheet, rowIndex, "B");
            return String.IsNullOrWhiteSpace(name)
                ? name
                : name.Replace("\"", "").Replace("_", "");
        }

        private string GetParameterName(int parameterRowIndex)
        {
            var paramName = GetExcelCellText(_xlParameterSheet, parameterRowIndex, "A");
            return String.IsNullOrWhiteSpace(paramName)
                ? paramName
                : paramName.Replace("\"", "").Replace("_", "");
        }

        private static string GetExcelCellText(_Worksheet xlParameterSheet, object row, object column)
        {
            var cell = (Range)xlParameterSheet.Cells[row, column];
            string cellText = Convert.ToString(cell.Text);
            return cellText.Trim();
        }

        public void Dispose()
        {
            if (_xlBook != null)
            {
                _xlBook.Close(false);
                Marshal.FinalReleaseComObject(_xlBook);
                _xlBook = null;
            }
            if (_xlApp != null)
            {
                _xlApp.Quit();
                Marshal.FinalReleaseComObject(_xlApp);
                _xlApp = null;
            }

            if (_eaRepository != null)
            {
                _eaRepository.CloseFile();
                _eaRepository.Exit();
                Marshal.FinalReleaseComObject(_eaRepository);
                _eaRepository = null;
            }
        }
    }
}
