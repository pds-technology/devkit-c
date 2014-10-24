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
using System.IO;
using Energistics.DataAccess;
using Energistics.DataAccess.WITSML141;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Energistics.UnitTests
{
    [TestClass]
    public class UnitTest_141
    {
        private string rootFolder = @"C:\Projects\StandardsDevkit";

        [TestMethod]
        public void WITSML141_SampleData()
        {
            object[] objs = new object[30];
            string pathToXml = Path.Combine(rootFolder, @"Standards\DataSchema\witsml_v1.4.1\witsml_v1.4.1_data\xml_examples");
           
            int i=0;
            objs[i++] = EnergisticsFile.ReadFile<AttachmentList>(Path.Combine(pathToXml, "attachment_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<BhaRunList>(Path.Combine(pathToXml, "bhaRun_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<CementJobList>(Path.Combine(pathToXml, "cementJob_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<ChangeLogList>(Path.Combine(pathToXml, "changeLog_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<ConvCoreList>(Path.Combine(pathToXml, "convCore_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<FluidsReportList>(Path.Combine(pathToXml, "fluidsReport_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<FormationMarkerList>(Path.Combine(pathToXml, "formationMarker_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<LogList>(Path.Combine(pathToXml, "log_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<MessageList>(Path.Combine(pathToXml, "message_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<MudLogList>(Path.Combine(pathToXml, "mudLog_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<ObjectGroupList>(Path.Combine(pathToXml, "objectGroup_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<OpsReportList>(Path.Combine(pathToXml, "opsReport_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<RigList>(Path.Combine(pathToXml, "rig_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<RiskList>(Path.Combine(pathToXml, "risk_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<SidewallCoreList>(Path.Combine(pathToXml, "sidewallCore_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<StimJobList>(Path.Combine(pathToXml, "stimJob_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<SurveyProgramList>(Path.Combine(pathToXml, "surveyProgram_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<TargetList>(Path.Combine(pathToXml, "target_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<ToolErrorModelList>(Path.Combine(pathToXml, "toolErrorModel_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<ToolErrorTermSetList>(Path.Combine(pathToXml, "toolErrorTermSet_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<TrajectoryList>(Path.Combine(pathToXml, "trajectory_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<TubularList>(Path.Combine(pathToXml, "tubular_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<WellboreGeometryList>(Path.Combine(pathToXml, "wbGeometry_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<WellboreList>(Path.Combine(pathToXml, "wellbore_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<WellList>(Path.Combine(pathToXml, "well_no_xsl.xml"));
            
        }
    }
}
