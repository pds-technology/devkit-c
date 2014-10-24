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
using System.IO;
using Energistics.DataAccess;
using Energistics.DataAccess.WITSML141;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Energistics.UnitTests
{
    [TestClass]
    public class UnitTest141
    {
        private const string RootFolder = @"C:\Projects\StandardsDevkit";

        [TestMethod]
        public void WITSML141_SampleData()
        {
            var objs = new object[30];
            string pathToXml = Path.Combine(RootFolder, @"Standards\DataSchema\witsml_v1.4.1.1\witsml_v1.4.1.1_data\xml_examples");
           
            int i=0;
            objs[i++] = EnergisticsFile.ReadFile<AttachmentList>(Path.Combine(pathToXml, "attachment_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<BhaRunList>(Path.Combine(pathToXml, "bhaRun_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<CementJobList>(Path.Combine(pathToXml, "cementJob_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<ChangeLogList>(Path.Combine(pathToXml, "changeLog_no_xsl.xml"));
            objs[i++] = EnergisticsFile.ReadFile<ConvCoreList>(Path.Combine(pathToXml, "convCore_no_xsl.xml"));
            //objs[i++] = EnergisticsFile.ReadFile<ConvCoreList>(Path.Combine(pathToXml, "coordinateReferenceSystem_no_xsl.xml"));
            //objs[i++] = EnergisticsFile.ReadFile<ConvCoreList>(Path.Combine(pathToXml, "drillReport_no_xsl.xml"));
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

        [TestMethod]
        public void WITSML141_TestEMSDBWS()
        {
            //string emsdbInstance = "devsdb2";
            //string url = String.Format("http://UTCSWebDEVLB02-EMSDB/WitsmlToEmsdbWebService/WitsmlToEmsdbWebService.asmx?EMSDB={0}", emsdbInstance); // QA
            string url = String.Format("https://141.wellstorm.com/witsml/services/store");
            //! [WebService]
            // Create a new web service connection
            WITSMLWebServiceConnection conn = new WITSMLWebServiceConnection(url, WMLSVersion.WITSML141);

            // Set to use default credentials.
            //conn.UseDefaultNetworkCredentials = true;

            // If not using default credentials, then you would set a username and password
            conn.UseDefaultNetworkCredentials = false;
            conn.Username = "guest"; //Environment.GetEnvironmentVariable("WITSMLUSER");
            conn.SetPassword("wellstorm.wsp"); // (Environment.GetEnvironmentVariable("WITSMLPW"));
            
            // To query for wells, we need to create an empty WellList object
            WellList queryList = WITSMLWebServiceConnection.BuildEmptyQuery<WellList>();

            // Then set the field on the object that will server as our query.
            // This will build a query for all wells named "Well OC Test"
            queryList.Well[0].Name = "Well OC Test";

            // Call the Read method and it will return a full set of wells matching the query
            WellList readWells = conn.Read<WellList>(queryList);
            //! [WebService]

            Assert.AreEqual(readWells.Well[0].Field, "FunctionalTest");
        }
        

        [TestMethod]
        public void WITSML141_TestConverter2()
        {
            const string input = @"C:\Projects\StandardsDevkit\Standards\DataSchema\witsml_v1.3.1.1\XML_Examples\wellbore_no_xsl.xml";
            var oldWellbores = EnergisticsFile.ReadFile<DataAccess.WITSML131.WellboreList>(input);

            WellboreList newWellbores = EnergisticsConverter.UpgradeVersion<DataAccess.WITSML131.WellboreList, WellboreList>(oldWellbores);

            Assert.AreEqual(oldWellbores.Version, "1.3.1.1");
            Assert.AreEqual(newWellbores.Version, "1.4.1.0");

            Assert.AreEqual(oldWellbores.Wellbore[0].Name, newWellbores.Wellbore[0].Name);
            Assert.AreEqual(oldWellbores.Wellbore[0].DateTimeKickoff, newWellbores.Wellbore[0].DateTimeKickoff);
        }
    }
}
