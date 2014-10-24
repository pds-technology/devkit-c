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
using System.Net;
using Energistics.DataAccess;
using Energistics.DataAccess.WITSML131;
using Energistics.DataAccess.WITSML131.ComponentSchemas;
using Energistics.DataAccess.WITSML131.ReferenceData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Energistics.UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest_131
    {
        private string rootFolder = @"C:\Projects\StandardsDevkit";

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private WITSMLWebServiceConnection CreateConnection()
        {
            WITSMLWebServiceConnection conn = new WITSMLWebServiceConnection("http://sitecom.intellifield.no/Store/WITSML", WMLSVersion.WITSML131);
            conn.Username = Environment.GetEnvironmentVariable("WITSMLUSER");
            conn.SetPassword(Environment.GetEnvironmentVariable("WITSMLPW"));
            conn.Proxy = new WebProxy();
            conn.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            return conn;
        }

        [TestMethod]
        public void WITSML131_WebService_OptionsIn()
        {
            WITSMLWebServiceConnection conn = CreateConnection();
            WellList queryList = WITSMLWebServiceConnection.BuildEmptyQuery<WellList>();
            queryList.Well[0].Name = "Radius Well";

            // This is how you set the optionsIn parameter for web methods
            Dictionary<string, string> optionsIn = new Dictionary<string, string>();
            optionsIn.Add("maxReturnNodes", "1");
            optionsIn.Add("returnElements", "all");

            WellList readWells = conn.Read<WellList>(queryList, optionsIn);
            string xml = EnergisticsConverter.ObjectToXml<WellList>(readWells);
        }

        [TestMethod]
        public void WITSML131_WebService_Full()
        {
            WITSMLWebServiceConnection conn = CreateConnection();

            WellList originalWellList = CreateTestWellList(); // pass in version

            // Get ws version
            string version = conn.GetVersion();
            Assert.AreEqual(version, "1.3.1.1");

            CapServers cap = conn.GetCap<CapServers>(); // rename to get capabilities
            Assert.AreEqual(cap.CapServer.Name, "SiteCom Central:SC001");

            // Create a query
            WellList queryList = WITSMLWebServiceConnection.BuildEmptyQuery<WellList>();
            queryList.Well[0].Uid = originalWellList.Well[0].Uid;

            // Read from WS, ensure 0 wells exist
            WellList readWells = conn.Read<WellList>(queryList);
            Assert.AreEqual(readWells.Well.Count, 0);

            // Write test well to WS            
            conn.Write<WellList>(originalWellList);

            // Read from WS, ensure wells match
            readWells = conn.Read<WellList>(queryList);
            Assert.AreEqual(readWells.Well.Count, 1);
            AssertWellListsEqual(readWells, originalWellList);

            // Update well
            readWells.Well[0].Country = "USA";
            conn.Update<WellList>(readWells);

            // Read again, ensure update worked
            readWells = conn.Read<WellList>(queryList);
            Assert.AreEqual(readWells.Well[0].Country, "USA");

            // Delete from WS
            conn.Delete<WellList>(queryList);

            // Read from WS, ensure 0 wells exist
            readWells = conn.Read<WellList>(queryList);
            Assert.AreEqual(readWells.Well.Count, 0);
        }

        [TestMethod]
        public void WITSML131_BackAndForth()
        {
            WellList wellList = CreateTestWellList();
            string xml = EnergisticsConverter.ObjectToXml<WellList>(wellList);

            WellList wellList2 = EnergisticsConverter.XmlToObject<WellList>(xml);
            AssertWellListsEqual(wellList, wellList2);
        }

        private void AssertWellListsEqual(WellList wellList, WellList wellList2)
        {
            Assert.AreEqual(wellList.Version, wellList2.Version);
            Assert.AreEqual(wellList.Well.Count, wellList2.Well.Count);

            for (int i = 0; i < wellList.Well.Count; i++)
            {
                Assert.AreEqual(wellList.Well[i].Name, wellList2.Well[i].Name);
                Assert.AreEqual(wellList.Well[i].Uid, wellList2.Well[i].Uid);
                Assert.AreEqual(wellList.Well[i].Field, wellList2.Well[i].Field);
                Assert.AreEqual(wellList.Well[i].Country, wellList2.Well[i].Country);
                Assert.AreEqual(wellList.Well[i].NumAPI, wellList2.Well[i].NumAPI);
                Assert.AreEqual(wellList.Well[i].DirectionWell, wellList2.Well[i].DirectionWell);
                Assert.AreEqual(wellList.Well[i].DateTimeSpud, wellList2.Well[i].DateTimeSpud);
                Assert.AreEqual(wellList.Well[i].CommonData.Comments, wellList2.Well[i].CommonData.Comments);
                Assert.AreEqual(wellList.Well[i].CommonData.SourceName, wellList2.Well[i].CommonData.SourceName);
                Assert.AreEqual(wellList.Well[i].WellLocation.Count, wellList2.Well[i].WellLocation.Count);
                for (int j = 0; j < wellList.Well[i].WellLocation.Count; j++)
                {
                    Assert.AreEqual(wellList.Well[i].WellLocation[j].Latitude.Value, wellList2.Well[i].WellLocation[j].Latitude.Value);
                    Assert.AreEqual(wellList.Well[i].WellLocation[j].Latitude.Uom, wellList2.Well[i].WellLocation[j].Latitude.Uom);
                }

                //Assert.AreEqual(wellList.Well[i].CommonData.DateTimeCreation, wellList2.Well[i].CommonData.DateTimeCreation);
            }
        }

        private WellList CreateTestWellList()
        {
            WellList wellList = new WellList();
            Well well = new Well();
            well.Uid = "7138675309";
            well.Name = "Test 12345";
            well.Field = "Field Name";
            well.DirectionWell = WellDirection.uncertain;
            well.DateTimeSpud = new DateTime(1977, 3, 23, 4, 55, 44);
            well.Country = "Mexico";
            well.NumAPI = "12345";
            well.CommonData = new CommonData();
            well.CommonData.Comments = "Comments here";
            well.CommonData.SourceName = "Source Name";
            well.CommonData.DateTimeCreation = new DateTime(1987, 5, 2, 12, 55, 44);
            well.WellLocation = new List<Location>();

            Location loc = new Location();
            loc.Uid = "MBHAFN123";
            loc.Latitude = new PlaneAngleMeasure(29.97, PlaneAngleUom.dega);
            loc.Longitude = new PlaneAngleMeasure(95.35, PlaneAngleUom.dega);
            well.WellLocation.Add(loc);


            wellList.Well = new System.Collections.Generic.List<Well>();
            wellList.Version = "1.3.1.1";
            wellList.Well.Add(well);
            return wellList;
        }

        [TestMethod]
        public void WITSML131_WriteWellboreList()
        {
            string outputFolder = Path.Combine(rootFolder, "temp");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            WellList wellList = CreateTestWellList();

            EnergisticsFile.WriteFile(Path.Combine(outputFolder, "welltest2.xml"), wellList);
        }

        [TestMethod]
        public void WITSML131_FileReaderWriterTest()
        {
            string outputFolder = Path.Combine(rootFolder, "temp");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            WellboreList wellbores = EnergisticsFile.ReadFile<WellboreList>(Path.Combine(rootFolder, @"Standards\DataSchema\witsml_v1.3.1.1\XML_Examples\wellbore_no_xsl.xml"));

            wellbores.Wellbore[0].Name = "New name for wellbore 0";

            EnergisticsFile.WriteFile(Path.Combine(outputFolder, "wells.xml"), wellbores);
        }

        [TestMethod]
        public void WITSML131_TestSampleData()
        {
            string pathToXml = Path.Combine(rootFolder, @"Standards\DataSchema\witsml_v1.3.1.1\XML_Examples");

            BhaRunList obj1 = EnergisticsFile.ReadFile<BhaRunList>(Path.Combine(pathToXml, "bhaRun_no_xsl.xml"));
            CementJobList obj2 = EnergisticsFile.ReadFile<CementJobList>(Path.Combine(pathToXml, "cementJob_no_xsl.xml"));
            ConvCoreList obj3 = EnergisticsFile.ReadFile<ConvCoreList>(Path.Combine(pathToXml, "convCore_no_xsl.xml"));
            DtsInstalledSystemList obj5 = EnergisticsFile.ReadFile<DtsInstalledSystemList>(Path.Combine(pathToXml, "dtsInstalledSystem_no_xsl.xml"));
            DtsMeasurementList obj8 = EnergisticsFile.ReadFile<DtsMeasurementList>(Path.Combine(pathToXml, "dtsMeasurement_no_xsl.xml"));
            FluidsReportList obj9 = EnergisticsFile.ReadFile<FluidsReportList>(Path.Combine(pathToXml, "fluidsReport_no_xsl.xml"));
            FormationMarkerList obj10 = EnergisticsFile.ReadFile<FormationMarkerList>(Path.Combine(pathToXml, "formationMarker_no_xsl.xml"));
            MessageList obj12 = EnergisticsFile.ReadFile<MessageList>(Path.Combine(pathToXml, "message_no_xsl.xml"));
            MudLogList obj13 = EnergisticsFile.ReadFile<MudLogList>(Path.Combine(pathToXml, "mudLog_no_xsl.xml"));
            OpsReportList obj14 = EnergisticsFile.ReadFile<OpsReportList>(Path.Combine(pathToXml, "opsReport_no_xsl.xml"));
            RealtimeList obj15 = EnergisticsFile.ReadFile<RealtimeList>(Path.Combine(pathToXml, "realtime_no_xsl.xml"));
            RigList obj16 = EnergisticsFile.ReadFile<RigList>(Path.Combine(pathToXml, "rig_no_xsl.xml"));
            RiskList obj17 = EnergisticsFile.ReadFile<RiskList>(Path.Combine(pathToXml, "risk_no_xsl.xml"));
            SidewallCoreList obj18 = EnergisticsFile.ReadFile<SidewallCoreList>(Path.Combine(pathToXml, "sidewallCore_no_xsl.xml"));
            SurveyProgramList obj19 = EnergisticsFile.ReadFile<SurveyProgramList>(Path.Combine(pathToXml, "surveyProgram_no_xsl.xml"));
            TargetList obj20 = EnergisticsFile.ReadFile<TargetList>(Path.Combine(pathToXml, "target_no_xsl.xml"));
            TrajectoryStationList obj21 = EnergisticsFile.ReadFile<TrajectoryStationList>(Path.Combine(pathToXml, "trajectoryStation_no_xsl.xml"));
            TrajectoryList obj22 = EnergisticsFile.ReadFile<TrajectoryList>(Path.Combine(pathToXml, "trajectory_no_xsl.xml"));
            TubularList obj23 = EnergisticsFile.ReadFile<TubularList>(Path.Combine(pathToXml, "tubular_no_xsl.xml"));
            WellboreGeometryList obj24 = EnergisticsFile.ReadFile<WellboreGeometryList>(Path.Combine(pathToXml, "wbGeometry_no_xsl.xml"));
            WellboreList obj25 = EnergisticsFile.ReadFile<WellboreList>(Path.Combine(pathToXml, "wellbore_no_xsl.xml"));
            WellList obj27 = EnergisticsFile.ReadFile<WellList>(Path.Combine(pathToXml, "well_no_xsl.xml"));            
        }

        [TestMethod]
        public void WITSML131_TestChoice()
        {
            Location loc = new Location();
            loc.Latitude = new PlaneAngleMeasure(29.97, PlaneAngleUom.dega);
            loc.Latitude = new PlaneAngleMeasure(95.35, PlaneAngleUom.dega);
            try
            {
                // This should generate an exception because lat/lon are already set
                loc.LocalX = new LengthMeasure(23422.4, LengthUom.ft);
                Assert.Fail();
            }
            catch (Exception)
            {
            }
        }

        [TestMethod]
        public void WITSML131_TestArray()
        {
            
            
            PumpActivity pump = new PumpActivity();
            pump.OTDRPerformed = new RefNameString[2];
            pump.OTDRPerformed[0] = new RefNameString("abc");
            pump.OTDRPerformed[1] = new RefNameString("xyz");

            DtsInstalledSystem dts = new DtsInstalledSystem();
            dts.PumpActivity = pump;

            DtsInstalledSystemList dtsList = new DtsInstalledSystemList();
            dtsList.DtsInstalledSystem = new List<DtsInstalledSystem>();
            dtsList.DtsInstalledSystem.Add(dts);

            string xml = EnergisticsConverter.ObjectToXml<DtsInstalledSystemList>(dtsList);

            DtsInstalledSystemList dtsList2 = EnergisticsConverter.XmlToObject<DtsInstalledSystemList>(xml);
            
        }
    }
}
