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
/*!\page resqml Using RESQML
 * \tableofcontents
 * 
 * \section resqmlread Reading RESQML
 * All RESQML documents are serialized as a ResqmlDocument. You read / write a ResqmlDocument using the same methods that you would use to read / write any other Energistics object.
 * \snippet RESQML110.cs Reading ResqmlDocument
 * 
 * \section resqmlhdf5 HDF5 explanation
 * <p>RESQML differs from the other Energistics standards in that it contains a binary representation of data within a <a href="http://www.hdfgroup.org/HDF5/">HDF5</a> file. The Standards DevKit hides the details of this implementation and allows the developer to work with RESQML HDF5 binary data in the same way he/she would work with XML data.</p>
 * <p>Any RESQML object that contains HDF5 binary data will contain a ResqmlHDFGroup property. This property contains a GUID that points to the location of the data within the HDF5 file. The handling of this GUID is internal to the DevKit and is hidden from the developer. The HDF data can be accessed by using the Read<i>ElementName</i> and Write<i>ElementName</i> methods on RESQML object that contains the ResqmlHDFGroup property.</p>
 * \snippet RESQML110.cs Reading HDF5
 * <p>In addition to these Read<i>ElementName</i> and Write<i>ElementName</i> methods, all ResqmlHDFGroup properties also contain generic Read and Write methods. This could be useful if the normal methods do not accept or return the desired data type or number of dimensions.</p>
 * \snippet RESQML110.cs GenericRead
 * 
 * \section slab Hyperslabbing
 * All read and write methods on the DevKit also support Hyperslabbing. Hyperslabbing is a method to allow reading or writing a subset of the data from an HDF5 file in order to accomidate very large data sets. Hyperslabbing can be performed by passing two additional arguments.
 * - The first additional argument is the <b>start</b> array. The start array determines the starting coordinates of the hyperslab to select.
 * - The second additional argument for READING is the <b>count</b> array. The count array determines how many blocks to select from the dataspace, in each dimension. 
 * - The second additional argument for WRITING is the <b>filespace</b> array. The filespace array is the total size to allot for the data within the HDF5 file
 *
 * \snippet RESQML110.cs Hyperslabbing
 *
 * \section PropertyData Property Data
* <p>Property data is implemented in RESQML with property values and property kinds.</p>
 * <p>Property values, which may be static or dynamic, may be associated with a horizon, a fault, a grid, a blocked wellbore list or a non-standard adjacency list.</p>
 * <p>Property groups are used to group, for instance, all of the properties at one time or simulation time step within a RESQML document.</p>
 * <p>Property kinds refer to a RESQML list of standard property names that represent the basis for the commonly used properties in the E&P subsurface workflow. Use of this list allows programmers implementing RESQML to map their software property names to the RESQML standard property software names, which makes it possible for RESQML-enabled software packages to translate property names between each other.</p> 
 * <h2>Property Values</h2>
 * <p>A property Group contains one Dataset named "values" which contain the property values. The dimension of the Dataspace in the Dataset corresponds to the dimension of the property data array.</p>
 * <p>The PropertyValues struct represent RESQML Property Value. This class contains a DataArray (possible of multiple dimensions) to store the data, a PropertyType to represent the type of data stored in the array, and a NullValue property to represent the value assigned to represent null within the dataset.</p>
 *
 * \snippet RESQML110.cs PropertyValues
 * 
 * <h2>ResqmlPropertyKind</h2>
 * <p>RESQML includes a list of standard property names that represent the basis for the commonly used properties in the E&P subsurface workflow. Use of this list allows programmers implementing RESQML to map their software property names to the RESQML standard property software names, which makes it possible for RESQML-enabled software packages to translate property names between each other.</p>
 * <p>For example, if Package A names “porosity” as POR and Package B names it PORO, and both packages are RESQML enabled, the packages can recognize that these properties are equivalent because they refer to the same RESQML parent property, e.g., "porosity". They can also exchange without ambiguity the numerical values that are recorded because those values will be in the same unit of measure.</p>
 * \snippet RESQML110.cs ResqmlPropertyKind
 * <p>ResqmlPropertyKinds have a hierarchical arrangement in that they have the concept of a ParentKind. This relationship can be easily shown in the ResqmlPropertyKindBrowser sample application included with the DevKit. Programmatically, hierarchical relationships can be determined through Linq expressions like the following:</p>
 * \snippet MainWindow.xaml.cs Linq
 */