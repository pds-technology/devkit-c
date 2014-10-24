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
/*! \mainpage Standards DevKit Documentation
 * \tableofcontents
 * \section intro Introduction
 * <p>The WITSML, PRODML, and RESQML schemas provide the definition for standard data exchange formats within the oil and gas industry. However, developing a software solution that uses these standard formats has not always been simple. The Standards Devkit removes the complexity of using the WITSML, PRODML, and RESQML standards and lets the developer concentrate on the important work of integrating the standards into their business solution.</p>
 * <p>The Standards Devkit wraps the WITSML, PRODML, and RESQML schemas with Microsoft .NET objects. The developer can work directly with these objects rather than having to deal with the XML definition itself. It provides all of the conveniences that .NET developers are familiar with such as full IntelliSense support,  XML Serialization, .NET naming conventions, enumerations, and more.</p>
 * <p>In addition to dealing with the data format itself, the Devkit also provides direct interfaces to the WITSML and PRODML APIs so the developer does not have to handle the details of web service communication with backend servers. The Devkit provides synchronous and asynchronous methods for all WITSML and PRODML web methods. It also provides wrappers for these web services that provide simplified calls, secure password management, and error handling.</p>
 * <p>When looking at the binaries provided with the project (<a href="http://sourceforge.net/projects/stdsdevkit/files/">link</a>) you will see two different Zip packages.  DevKitGenerator.zip will contain the code necessary to generate the DevKit from scratch when Energistics provides new versions of the schemas, and thus you should only be worried about that package if are need a new version before Energistics official updates the DevKit.  The DevKit.zip package is what most users should be working with.  This contains the pre-built assemblies for the Standards DevKit as well as sample applications and unit tests to help users to learn how the DevKit works.</p>
 *  
 * \section contents Contents
 * - \subpage start
 * - \subpage resqml
 * - \subpage trouble
 * - \subpage generating
 * - \subpage new
 *  
 * \section license License
 * \verbinclude License.txt
 * 
 * \page trouble Troubleshooting
 * \tableofcontents
 * \section devkit DevKit Usage
 * - <b>When compiling against the DevKit I get, "The type or namespace name 'RESQML110' does not exist in the namespace 'Energistics.DataAccess' (are you missing an assembly reference?)"</b><br/><br/> - Make sure you have a reference to Energistics.RESQMLDataAccess in your project. If you do, make sure your project is using .Net Framework 4.0.
 * \section generator Generating the DevKit
 * - <b>When I load the DevkitGenerator solution, some of the files are missing"</b><br/><br/> - This is normal. These files will be generated as part of the build process. See the page on \subpage generating for more details.
 * 
 * \page new What's New in Version 2.0?
 * \tableofcontents
 * Version 2.0 of the DevKit includes the following changes from version 1.1:
 * - Support for RESQML 1.1
 *     - All RESQML XML is abstracted from developers as .NET POCO objects.
 *     - All interactions with HDF5 API are hidden from the developer.  
 *     - Included ResqmlPropertyKind Browser sample app
 * - WITSML API Specifications, version 1.4.1.1 
 * - PRODML Data Schema Specifications, Version 1.2.2 
 * - Improved Web Service API wrappers for WITSML and PRODML
 * - Support for conversion from WITSML 1.3.1 to 1.4.1.1
 * - Data Objects provide better support for WPF
 * - Various bug fixes and minor enhancements.
 */