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
/*!\page start Getting Started
 * \tableofcontents
 * 
 * \section hdf5 Installing required HDF5 libraries.
 * The Standares DevKit RESQML libraries require additional libraries from <a href="http://www.hdfgroup.org/">The HDF Group</a> to compile properly. Before trying to use the DevKit, download the correct build for your architecture below and unzip the file into the Devkit's <strong>Assemblies</strong> folder.
 * - <a href="http://hdf5.net/downloads/1.8.9/x86/HDF5DotNet-Net4.0-x86.zip">HDF5DotNet assembly for .NET Framework 4.0 32-bit</a>
 * - <a href="http://hdf5.net/downloads/1.8.9/amd64/HDF5DotNet-Net4.0-x86_64.zip">HDF5DotNet assembly for .NET Framework 4.0 64-bit</a>
 * 
 * \section ref Referencing the DevKit
 * In order to use the DevKit, you must first add a reference to the DevKit from your Visual Studio project.
 * -# Right Click the project name and click “Add Reference”
 * -# Browse to “Energistics.DataAccess.dll” and add that as a reference
 * -# If you need to use RESQML, browse to “Energistics.RESQMLDataAccess.dll” and add that as a reference
 *    - You will also need to unzip the HDFDotNet binaries from the HDF Group into the <strong>Assemblies</strong> folder (<a href="http://hdf5.net/downloads/1.8.9/x86/HDF5DotNet-Net4.0-x86.zip">x86</a> <a href="http://hdf5.net/downloads/1.8.9/amd64/HDF5DotNet-Net4.0-x86_64.zip">x64</a>)
 * -# At the top of your code, add a using statement for the namespace(s) that you will be using. 
 * \snippet RESQML110.cs Using
 * 
 * \section obj Working with objects
 * Once you have referenced the DevKit, you can begin to write code. The following example creates a single wellbore and sets several values:
 * \snippet WITSML131.cs Creating Object
 * The Well object in the previous example represents only a single well. WITSML and PRODML support the concepts of collections of objects. These collections implement the IEnergisticsCollection interface. The class names of these collections end in the word "List" and are typically the objects that end up getting read from and written to XML. The following code demonstrates adding the previously created Well to a WellList collection:
 * \snippet WITSML131.cs Creating Collection
 * 
 * \section conv Converting between XML and objects
 * The DevKit stores everything it works with as objects that are easily manipulated through .NET code. However, to save or exchange this information it needs to be in XML format. The conversion between the two is easy. Here is how to convert the well we just created to an XML string.
 * \snippet WITSML131.cs Converting XML
 * 
 * \section file Working with XML files
 * An XML file is simply a XML string written to a file. You could handle the file operation yourself, but the DevKit provides convenience method to help you do that.
 * \snippet WITSML131.cs Converting File
 * 
 * \section web Web Service Connections
 * You can call WITSML and PRODML web services with the WITSMLWebServiceConnection & PRODMLWebServiceConnection classes. At this time, RESQML does not have an web API.
 * \snippet WITSML141.cs WebService
 */