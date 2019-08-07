// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2016 Petrotechnical Data Systems
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
using System.Xml;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Defines properties common to all data objects.
    /// </summary>
    public interface ICommonDataObject
    {
        /// <summary>
        /// Gets the common data object.
        /// </summary>
        ICommonData CommonData { get; set; }

        /// <summary>
        /// Gets the custom data object.
        /// </summary>
        ICustomData CustomData { get; set; }
    }

    /// <summary>
    /// Defines audit properties common to all data objects.
    /// </summary>
    public interface ICommonData
    {
        /// <summary>
        /// When the data was created at the persistent data store. This is an API server parameter releted to the "Special Handling of Change Information" within a server. See the relevant API specification for the behavior related to this element.
        /// </summary>
        Timestamp? DateTimeCreation { get; set; }

        /// <summary>
        /// Last change of any element of the data at the persistent data store. This is an API server parameter releted to the "Special Handling of Change Information" within a server. See the relevant API specification for the behavior related to this element.
        /// </summary>
        Timestamp? DateTimeLastChange { get; set; }

        /// <summary>
        /// An identifier to indicate the data originator. This identifies the server that originally created the object and thus most of the uids in the object (but not necessarily the uids of the parents). This is typically a url. 
        /// </summary>
        String SourceName { get; set; }

        /// <summary>
        /// Comments and remarks. 
        /// </summary>
        String Comments { get; set; }
    }

    /// <summary>
    /// Defines an extensible property common to all data objects.
    /// </summary>
    public interface ICustomData
    {
        /// <summary>
        /// Any property
        /// </summary>
        List<XmlElement> Any { get; set; }
    }
}