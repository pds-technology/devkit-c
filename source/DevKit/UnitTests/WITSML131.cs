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
    public class UnitTest131
    {
        private const string RootFolder = @"C:\Projects\StandardsDevkit";

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
            conn.Username = "yourusername"; //Environment.GetEnvironmentVariable("WITSMLUSER");
            conn.SetPassword("yourpassword"); // (Environment.GetEnvironmentVariable("WITSMLPW"));
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
            //! [Converting XML]
            // Convert the wellList object to a xml string
            string xml = EnergisticsConverter.ObjectToXml<WellList>(wellList);

            // Convert the xml string back to a well list object
            WellList wellList2 = EnergisticsConverter.XmlToObject<WellList>(xml);
            //! [Converting XML]
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
            //! [Creating Object]
            Well well = new Well()                        // Create a new well
            {
                Uid = Guid.NewGuid().ToString("N"),       // Generates a new random GUID and assigns it to the well
                Name = "Test 12345",                      // Set a well name
                Field = "Field Name",                     // Set a field name
                DirectionWell = WellDirection.uncertain,  // Sets the direction well to uncertain
                DateTimeSpud = new DateTime(1977, 3, 23), // Sets the DateTimeSpud date to March 23, 1977 @ 4:55:44
                Country = "Mexico",                       // Sets the country to Mexico
                WellLocation = new List<Location>()       // Creates an empty list of well locations
            };

            well.WellLocation.Add(new Location()                              // Adds a new location to the list of well locations
            {
                Uid = "MBHAFN123",                                            // Sets the UID on the new well location
                Latitude = new PlaneAngleMeasure(29.97, PlaneAngleUom.dega),  // Sets the latitude of the well locatoin
                Longitude = new PlaneAngleMeasure(95.35, PlaneAngleUom.dega), // Sets the longitude of the well location
            });
            //! [Creating Object]

            //! [Creating Collection]                     
            // Create new WellList
            WellList wellList = new WellList();

            // Initialize it's collections of wells
            wellList.Well = new List<Well>();

            // Add the previously created well to the collection
            wellList.Well.Add(well);
            //! [Creating Collection]

            return wellList;
        }

        [TestMethod]
        public void WITSML131_WriteWellboreList()
        {
            string outputFolder = Path.Combine(RootFolder, "temp");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            WellList wellList = CreateTestWellList();

            EnergisticsFile.WriteFile(Path.Combine(outputFolder, "welltest2.xml"), wellList, true);
        }

        [TestMethod]
        public void WITSML131_FileReaderWriterTest()
        {
            string outputFolder = Path.Combine(RootFolder, "temp");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            string originalFileName = Path.Combine(RootFolder, @"Standards\DataSchema\witsml_v1.3.1.1\XML_Examples\wellbore_no_xsl.xml");
            string newFilename = Path.Combine(outputFolder, "wells.xml");
            
            //! [Converting File]
            // Read in original XML file
            WellboreList wellbores = EnergisticsFile.ReadFile<WellboreList>(originalFileName);

            // Change the well name
            wellbores.Wellbore[0].Name = "New name for wellbore 0";

            // Write to a new file
            EnergisticsFile.WriteFile(newFilename, wellbores, true);
            //! [Converting File]
        }

        [TestMethod]
        public void WITSML131_TestSampleData()
        {
            string pathToXml = Path.Combine(RootFolder, @"Standards\DataSchema\witsml_v1.3.1.1\XML_Examples");

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
