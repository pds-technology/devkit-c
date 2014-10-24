using System;
using System.Collections.Generic;
using System.IO;
//! [Using]
using Energistics.DataAccess;
using Energistics.DataAccess.RESQML110;
//! [Using]
using Energistics.DataAccess.RESQML110.ComponentSchemas;
using Energistics.RESQMLDataAccess.RESQML110;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Energistics.UnitTests
{
    [TestClass]
    public class RESQML110
    {
        private const string PATH_TO_RESQML_PROJECTS = @"C:\Projects\StandardsDevkit\Standards\DataSchema\resqml_v1.1\resqml_v1.1.0_data\xml_examples";

        [TestMethod]
        public void RESQML_Read_ResqmlIJKNonStandardAdjacency()
        {
            string filename = Path.Combine(Path.GetTempPath(), "RESQML_Read_ResqmlIJKNonStandardAdjacency.resqml");

            GridIJKCellFacePair pair = 
            new GridIJKCellFacePair(){ 
                face1 = new GridIJKCellFace() {
                    cell = new GridIJKCell() {
                        gridID = 0,
                        i = 1,
                        j = 2,
                        k = 3
                    },
                    face = GridIJKCellFaceDirection.Jminus
                },
            face2 = new GridIJKCellFace() {
                    cell = new GridIJKCell() {
                        gridID = 0,
                        i = 1,
                        j = 2,
                        k = 3
                    },
                    face = GridIJKCellFaceDirection.Jminus
                }
            };

            GridIJKCellFacePair[] origpairs = new GridIJKCellFacePair[]{pair,pair,pair,pair};

            ResqmlDocument doc2 = new ResqmlDocument();
            doc2.Description = new DublinCoreString("My Description");
            doc2.GriddedVolumeSet = new ResqmlGriddedVolumeSet();
            doc2.GriddedVolumeSet.NonStandardAdjacencySet = new System.Collections.Generic.List<ResqmlIJKNonStandardAdjacency>();
            doc2.GriddedVolumeSet.NonStandardAdjacencySet.Add(new ResqmlIJKNonStandardAdjacency());
            doc2.GriddedVolumeSet.NonStandardAdjacencySet[0].WriteHdfRepresentation(doc2, origpairs, null, null);


            EnergisticsFile.WriteFile(filename, doc2, true);


            ResqmlDocument doc = EnergisticsFile.ReadFile<ResqmlDocument>(filename);

            GridIJKCellFacePair[] newpair = doc.GriddedVolumeSet.NonStandardAdjacencySet[0].ReadHdfRepresentation(doc);

            Assert.AreEqual(doc2.Description.Value, doc.Description.Value);
            Assert.AreEqual(origpairs.Length, newpair.Length);
            Assert.AreEqual(origpairs[0].face1.cell.gridID, newpair[0].face1.cell.gridID);
            Assert.AreEqual(origpairs[0].face1.cell.i, newpair[0].face1.cell.i);
            Assert.AreEqual(origpairs[0].face1.cell.j, newpair[0].face1.cell.j);
            Assert.AreEqual(origpairs[0].face1.cell.k, newpair[0].face1.cell.k);
            Assert.AreEqual(origpairs[0].face1.face, newpair[0].face1.face);

            Array newpair2Array = doc.GriddedVolumeSet.NonStandardAdjacencySet[0].HdfRepresentation.Read<GridIJKCellFacePair>(doc, null, null, null);
            if (newpair2Array.Rank == 1)
            {
                GridIJKCellFacePair[] newPair2 = (GridIJKCellFacePair[])newpair2Array;

                Assert.AreEqual(origpairs.Length, newPair2.Length);
                Assert.AreEqual(origpairs[0].face1.cell.gridID, newPair2[0].face1.cell.gridID);
                Assert.AreEqual(origpairs[0].face1.cell.i, newPair2[0].face1.cell.i);
                Assert.AreEqual(origpairs[0].face1.cell.j, newPair2[0].face1.cell.j);
                Assert.AreEqual(origpairs[0].face1.cell.k, newPair2[0].face1.cell.k);
                Assert.AreEqual(origpairs[0].face1.face, newPair2[0].face1.face);
            }
        }

        [TestMethod]
        public void RESQML_Read_ResqmlGrid2dPatch()
        {
            //! [Hyperslabbing]
            // Read RESQML XML document
            ResqmlDocument doc = ReadAlwyn();

            // Retrieve ResqmlGrid2dPatch from the ResqmlDocument
            ResqmlGrid2dPatch patch = doc.InterfaceFeatureSet.Horizon[0].HorizonInterpretation[0].Grid2dRepresentation[0].Grid2dPatch[0];
            
            // Get the dimensions of the existing dataset
            long[] dims = patch.Grid2dHdfGroup.GetSimpleExtentDims(doc, null);

            // Define the starting coordinates of the hyperslab to select
            long[] start = new long[] { 314, 0 };

            // Define how many blocks to select from the dataspace, in each dimension. 
            long[] count = new long[] { 3, dims[1] };

            // Read a partial set of data
            double[,] partialZValueSet = patch.ReadZValueSet(doc, start, count);
            //! [Hyperslabbing]

            Assert.AreEqual(partialZValueSet[315 - start[0], 390 - start[1]], 3190.88, 0.01);
            Assert.AreEqual(partialZValueSet[315 - start[0], 398 - start[1]], 3214.9, 0.01);
            Assert.AreEqual(partialZValueSet[315 - start[0], 406 - start[1]], 3224.74, 0.01);
            Assert.AreEqual(partialZValueSet[315 - start[0], 414 - start[1]], 3230.43, 0.01);

            double[,] grid = patch.ReadZValueSet(doc);

            Assert.IsTrue(Double.IsNaN(grid[0, 0])); // first element            
            Assert.AreEqual(grid[188, 440], 3078.43969726563, 0.00000000001); // first value
            Assert.AreEqual(grid[342, 557], 3149.6806640625, 0.00000000001);
            Assert.AreEqual(grid[457, 675], 3032.646484375, 0.00000000001);
            Assert.AreEqual(grid[554, 353], 3199.6123046875, 0.00000000001);
            Assert.AreEqual(grid[663, 582], 3035.7021484375, 0.00000000001);
            Assert.AreEqual(grid[779, 412], 3112.42626953125, 0.00000000001);
            Assert.AreEqual(grid[946, 344], 3193.34252929688, 0.00000000001);
            Assert.AreEqual(grid[1124, 421], 3161.43798828125, 0.00000000001); // last value
            Assert.IsTrue(Double.IsNaN(grid[1162, 848])); // last element
        }

        [TestMethod]
        public void RESQML_Read_ResqmlPillarSetPatch()
        {
            //! [Reading HDF5]
            // Read RESQML XML document
            ResqmlDocument doc = ReadAlwyn();

            // Retrieve ResqmlPillarSetPatch from the ResqmlDocument
            ResqmlPillarSetPatch patch =
                doc.InterfaceFeatureSet.Fault[0].FaultInterpretation[0].PillarSetRepresentation[0].PillarSetPatch[0];

            // The ResqmlPillarSetPatch contains a ResqmlHdfGroup that points to the HDF5 data
            ResqmlHdfGroup hdfGroup = patch.PillarSetHdfGroup;

            // Read points from ResqmlPillarSetPatch HDF5 data
            Point3D[,] points = patch.ReadPillarSet(doc);
            //! [Reading HDF5]

            //! [GenericRead]
            // This generic Read method is the same as calling patch.ReadPillarSet(doc), but provides more flexibility.
            Array point3dArray = hdfGroup.Read<Point3D>(doc, null, null, "pillarSet");
            if (point3dArray.Rank == 2)
            {
                Point3D[,] points2 = (Point3D[,]) point3dArray;
            }
            //! [GenericRead]

            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    byte[] temp = BitConverter.GetBytes(points[i, j].x);
                    Array.Reverse(temp);
                    points[i, j].x = BitConverter.ToDouble(temp, 0);

                    temp = BitConverter.GetBytes(points[i, j].y);
                    Array.Reverse(temp);
                    points[i, j].y = BitConverter.ToDouble(temp, 0);

                    temp = BitConverter.GetBytes(points[i, j].z);
                    Array.Reverse(temp);
                    points[i, j].z = BitConverter.ToDouble(temp, 0);
                }
            }

            Assert.AreEqual(points[0, 0].x, 430869.478516);
            Assert.AreEqual(points[0, 0].y, 6740624.910156);
            Assert.AreEqual(points[0, 0].z, 3534.646729);

            Assert.AreEqual(points[18, 1].x, 429003.05384933972, 0.000000001);
            Assert.AreEqual(points[18, 1].y, 6743676.3309267415, 0.000000001);
            Assert.AreEqual(points[18, 1].z, 3102.0);
        }

        [TestMethod]
        public void RESQML_Alwyn()
        {
            string filename = Path.Combine(Path.GetTempPath(), "RESQML_Alwyn.resqml");

            ResqmlDocument doc = ReadAlwyn();

            Assert.AreEqual(doc.AreaOfInterest.Outline.Polygon.Id, "PolygonOfInterest");

            EnergisticsFile.WriteFile(filename, doc, true);
        }

        [TestMethod]
        public void RESQML_Write_PropertyValues()
        {
            //! [PropertyValues]
            // Create a new PropertyValues object
            PropertyValues pv = new PropertyValues()
            {
                PropertyType = typeof(int),
                NullValue = -999,
                DataArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -999 }
            };

            // Create a new ResqmlDocument and DiscretePropertyValues
            ResqmlDocument doc = new ResqmlDocument();
            doc.GriddedVolumeSet = new ResqmlGriddedVolumeSet();
            doc.GriddedVolumeSet.GridSet = new List<ResqmlRootIJKGrid>();
            doc.GriddedVolumeSet.GridSet.Add(new ResqmlRootIJKGrid());
            doc.GriddedVolumeSet.GridSet[0].PropertyValues = new ResqmlPropertySet();
            doc.GriddedVolumeSet.GridSet[0].PropertyValues.DiscretePropertyValues = new List<ResqmlDiscretePropertyValues>();

            // Create a new ResqmlDiscretePropertyValues object and add it to ResqmlDocument
            ResqmlDiscretePropertyValues discPropValue = new ResqmlDiscretePropertyValues();
            doc.GriddedVolumeSet.GridSet[0].PropertyValues.DiscretePropertyValues.Add(discPropValue);

            // Write PropertyValues data to the ResqmlDiscretePropertyValues
            discPropValue.WritePropertyValues(doc, pv);

            // Read PropertyValues data back out
            PropertyValues pv2 =  discPropValue.ReadPropertyValues(doc);
            
            // Show that they are equal
            Assert.AreEqual(pv.NullValue, pv2.NullValue);
            Assert.AreEqual(pv.DataArray.GetValue(4), pv2.DataArray.GetValue(4));
            Assert.AreEqual(pv.PropertyType, pv2.PropertyType);
            //! [PropertyValues]
        }

        [TestMethod]
        public void RESQML_TestCreatedDate()
        {
            string filename = Path.Combine(Path.GetTempPath(), "RESQML_TestCreatedDate.resqml");

            ResqmlDocument doc = new ResqmlDocument();
            doc.AreaOfInterest = new ResqmlAreaOfInterest();
            doc.Created = new W3CDTF(DateTime.Now);
            doc.Creator = new DublinCoreString(Environment.UserName);
            doc.CustomData = new CustomData();
            doc.Description = new DublinCoreString("Description");
            doc.Format = new DataAccess.RESQML110.ReferenceData.ResqmlFormat();
            doc.GriddedVolumeSet = new ResqmlGriddedVolumeSet();
            doc.InterfaceFeatureSet = new ResqmlInterfaceFeatureSet();
            doc.PropertyGroupSet = new ResqmlPropertyGroupSet();
            doc.PropertyKindSet = new List<StandAloneResqmlPropertyKind>();
            doc.Publisher = new DublinCoreString("Publisher");
            doc.SpatialReferenceSet = new ResqmlSpatialReferenceSet();
            doc.Subject = new DublinCoreString("Subject");
            doc.Title = new DublinCoreString("Title");
            doc.Uid = Guid.NewGuid().ToString("d");
            EnergisticsFile.WriteFile(filename, doc, true);

            ResqmlDocument doc2 = EnergisticsFile.ReadFile<ResqmlDocument>(filename);
        }

        [TestMethod]
        public void RESQML_TestSample()
        {
            ResqmlDocument doc3 =
                EnergisticsFile.ReadFile<ResqmlDocument>(
                    @"C:\Projects\StandardsDevkit\Standards\DataSchema\resqml_v1.1\resqml_v1.1.0_data\xml_examples\resqmlDocumentStandAlone_no_xsl.xml");

            Assert.AreEqual(
                doc3.InterfaceFeatureSet.Horizon[0].HorizonInterpretation[0].Grid2dRepresentation[0].Grid2dPatch[0].
                    PropertyValues.ContinuousPropertyValues[0].XmlRepresentation.IntValues.Array[0], 12345678);

        }

        [TestMethod]
        public void RESQML_Write_WriteInterfaceFeatureSet_Horizon()
        {
            ResqmlDocument doc = ReadAlwyn();

            foreach (ResqmlHorizon horizon in doc.InterfaceFeatureSet.Horizon)
            {
                foreach (ResqmlHorizonInterpretation horizonInterpretation in horizon.HorizonInterpretation)
                {
                    foreach (ResqmlGrid2dRepresentation grid2DRepresentation in horizonInterpretation.Grid2dRepresentation)
                    {
                        foreach (ResqmlGrid2dPatch grid2DPatch in grid2DRepresentation.Grid2dPatch)
                        {
                            double[,] grid = grid2DPatch.ReadZValueSet(doc);

                            try
                            {
                                grid2DPatch.WriteZValueSet(doc, grid);
                            }
                            catch (ResqmlException ex)
                            {
                                Assert.IsTrue(ex.Message.Contains("cannot be opened. Check the H5 file and verify that this group is not corrupt."));
                            }

                        }
                    }
                }
            }
        }

        [TestMethod]
        public void RESQML_ResqmlPropertyKind()
        {
            ResqmlPropertyKind bulkMod = ResqmlPropertyKind.GetByName("bulk modulus");
            
            Assert.AreEqual(bulkMod.IsAbstract, false);
            Assert.AreEqual(bulkMod.ParentKind, "pressure");
            Assert.AreEqual(bulkMod.UnitOfMeasure, "Pa");
            Assert.AreEqual(bulkMod.DimensionalClass, "M/LT2");
            Assert.AreEqual(bulkMod.Description, "Bulk modulus, K");

            //! [ResqmlPropertyKind]
            // Read RESQML XML document
            ResqmlDocument doc = EnergisticsConverter.XmlToObject<ResqmlDocument>(
                @"<?xml version=""1.0""?>
                    <resqmlDocument xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:gml=""http://www.opengis.net/gml/3.2"" xmlns:xlink=""http://www.w3.org/1999/xlink"" xmlns:dc=""http://purl.org/dc/terms/"" xmlns=""http://www.resqml.org/schemas/1series"">
                      <propertyKindSet>
                        <propertyKind>
                          <resqmlKind>porosity</resqmlKind>
                        </propertyKind>
                      </propertyKindSet>
                    </resqmlDocument>");

            // Get the ResqmlPropertyKind from the ResqmlDocument
            ResqmlPropertyKind propKind = doc.PropertyKindSet[0].ResqmlKind;

            // Confirm porosity properties
            Assert.AreEqual(propKind.IsAbstract, false);
            Assert.AreEqual(propKind.ParentKind, "volume per volume");
            Assert.AreEqual(propKind.UnitOfMeasure, "Euc");
            Assert.AreEqual(propKind.DimensionalClass, "ratio(L3)");
            Assert.AreEqual(propKind.Description, "porosity");
            Assert.AreEqual(propKind.Name, "porosity");
            Assert.AreEqual(propKind, ResqmlPropertyKind.Porosity);
            //! [ResqmlPropertyKind]
        }

        [TestMethod]
        public void RESQML_Write_Slabbing()
        {
            ResqmlDocument doc = ReadAlwyn();
            int successfulCount = 0;

            foreach (ResqmlHorizon horizon in doc.InterfaceFeatureSet.Horizon)
            {
                foreach (ResqmlHorizonInterpretation horizonInterpretation in horizon.HorizonInterpretation)
                {
                    foreach (ResqmlGrid2dRepresentation grid2DRepresentation in horizonInterpretation.Grid2dRepresentation)
                    {
                        foreach (ResqmlGrid2dPatch grid2DPatch in grid2DRepresentation.Grid2dPatch)
                        {
                            double[,] zValueSet = grid2DPatch.ReadZValueSet(doc);

                            try
                            {
                                grid2DPatch.WriteZValueSet(doc, zValueSet,
                                    new long[]
                                    {
                                        grid2DPatch.IStart.Value, 
                                        grid2DPatch.JStart.Value
                                    },
                                    new long[]
                                    {
                                        zValueSet.GetLongLength(0), zValueSet.GetLongLength(1)
                                    });
                                successfulCount++;
                            }
                            catch (ResqmlException ex)
                            {
                                if (!ex.Message.Contains("cannot be opened. Check the H5 file and verify that this group is not corrupt."))
                                    throw;
                            }
                        }
                    }
                }
            }
            Assert.IsTrue(successfulCount > 0);
        }

        //! [Reading ResqmlDocument]
        private static ResqmlDocument ReadAlwyn()
        {
            string fileName = Path.Combine(PATH_TO_RESQML_PROJECTS, "ALWYN-RESQML.resqml");
            return EnergisticsFile.ReadFile<ResqmlDocument>(fileName);
        }
        //! [Reading ResqmlDocument]
    }
}
