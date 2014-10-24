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
/*!\page generating Generating the DevKit
 * \tableofcontents
 * \section folder Folder Structure
 * <table>
 * <tr><td>C:\\Program Files\\doxygen</td><td>Install <a href="http://www.doxygen.org">Doxygen</a> here (optional, to generate this documentation)</td></tr>
 * <tr><td>C:\\Program Files (x86)\\HTML Help Workshop</td><td>Install <a href="http://www.microsoft.com/en-us/download/details.aspx?id=21138">HTML Help Workshop</a> here (optional, to generate this documentation)</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\DevKit</td><td>Unzip <a href="http://sourceforge.net/projects/stdsdevkit/files/DevKit.zip/download">DevKit.zip</a> here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\DevKit\\Assemblies</td><td>Unzip dll's from <a href="http://hdf5.net">HDF5DotNet</a> here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\DevKitGenerator</td><td>Unzip <a href="http://sourceforge.net/projects/stdsdevkit/files/DevKitGenerator.zip/download">DevKitGenerator.zip</a> here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\Standards\\API\\prodml_v2.1.0.1_GDA</td><td>Unzip <a href="http://energistics.org">Energistics</a> PRODML API here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\Standards\\API\\witsml_v1.3.1_api</td><td>Unzip <a href="http://energistics.org">Energistics</a> WITSML 1.3.1 API here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\Standards\\API\\witsml_v1.4.1.1_api</td><td>Unzip <a href="http://energistics.org">Energistics</a> WITSML 1.4.1 API here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\Standards\\DataSchema\\prodml_v1.2.2</td><td></td>Unzip <a href="http://energistics.org">Energistics</a> PRODML data schema specs here</tr>
 * <tr><td>&lt;rootFolder&gt;\\Standards\\DataSchema\\resqml_v1.1</td><td>Unzip <a href="http://energistics.org">Energistics</a> RESQML data schema specs here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\Standards\\DataSchema\\witsml_v1.3.1.1</td><td>Unzip <a href="http://energistics.org">Energistics</a> WITSML 1.3.1 data schema specs here</td></tr>
 * <tr><td>&lt;rootFolder&gt;\\Standards\\DataSchema\\witsml_v1.4.1.1</td><td>Unzip <a href="http://energistics.org">Energistics</a> WITSML 1.4.1 data schema specs here</td></tr>
 * </table>
 * \section gen Generating the DevKit
 * -# Setup the folder structure as indicated above.
 * -# Open Visual Studio 2010 or 2012
 * -# Go to File -> Open -> Project / Solution
 * -# Open &lt;rootFolder&gt;\\DevKitGenerator\\DevKitGenerator.sln
 * \note Some files will appear to be missing from the solution. This is normal. Many files are generated as part of the build process.
 * -# From the Solution Explorer expand the SchemaGatherer project and double-click App.config
 * -# Edit and save this file so that the ROOT_FOLDER setting points to &lt;rootFolder&gt; in the folder structure above.
 * -# Build the devkit by going to Build ->  Build Solution. This will copy the resulting devkit assemblies into &lt;rootFolder&gt;\\DevKit\\Assemblies
 * \note Building in release mode will also generate this documentation
 *
 * \section update Updating / Adding a new standards version
 * The DevKit Generator typically needs a minimal amount of changes to support a new version standards version. The following changes need to be made to support new versions:
 * - Update app.config file with new version strings and path to xsd files
 * - Update hard-coded references:
 *    - EnergisticsConverter.UpgradeVersion
 *    - WITSMLWebServiceConnection.BuildEmptyQuery
 *    - WITSMLWebServiceConnection.WMLSVersion
 *    - PRODMLWebServiceConnection
 *    - EnumValuesExtensionGenerator
 * 
 * \note These hard-coded references will be removed in a future version, but are documented here for completeness.
 * 
 */