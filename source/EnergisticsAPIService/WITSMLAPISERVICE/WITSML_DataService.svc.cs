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
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Xml;

using System.Xml.Serialization;
using Energistics.DataAccess.WITSML141;
namespace WITSMLAPISERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WITSML_DataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WITSML_DataService.svc or WITSML_DataService.svc.cs at the Solution Explorer and start debugging.
    public class WITSML_DataService : StoreSoapPort
    { 
       
        public WMLS_AddToStoreResponse WMLS_AddToStore(WMLS_AddToStoreRequest request)
        {
            WMLS_AddToStoreResponse res = new WMLS_AddToStoreResponse();
            if (request.XMLin!=null)
            {
                if (request.XMLin.Contains("TestUID_1"))
                {
                    res.Result = 1;
                }
                else
                    throw new Exception("wrong");
            }
            return res;
        }


        public WMLS_DeleteFromStoreResponse WMLS_DeleteFromStore(WMLS_DeleteFromStoreRequest request)
        {
            WMLS_DeleteFromStoreResponse res = new WMLS_DeleteFromStoreResponse();
            if (request.QueryIn != null)
            {
                if (request.QueryIn.Contains("TestUID_1"))
                {
                    res.Result = 1;
                }
                else
                    throw new Exception("wrong");
            }
            return res;
        }

        public WMLS_GetBaseMsgResponse WMLS_GetBaseMsg(WMLS_GetBaseMsgRequest request)
        {
            WMLS_GetBaseMsgResponse res = new WMLS_GetBaseMsgResponse();
            if (request.ReturnValueIn == 999)
            {
                 
                    res.ResultBase = "test success";
            }
            else
                throw new Exception("wrong");
            return res;
        }

        public WMLS_GetCapResponse WMLS_GetCap(WMLS_GetCapRequest request)
        {
            WMLS_GetCapResponse res = new WMLS_GetCapResponse();
            CapServers serv= new CapServers();
            serv.CapServer = new CapServer();
            serv.Version = "1.0";
            serv.CapServer.ApiVers = "WITSML1.4.1";

            XmlSerializer obj = new XmlSerializer(typeof(CapServers));
           
            StringBuilder sb = new StringBuilder();
            using ( var memoryStream = new MemoryStream())
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                obj.Serialize(xmlTextWriter, serv);
                res.CapabilitiesOut = Encoding.UTF8.GetString(memoryStream.ToArray()); 
            } 
          
            res.Result = 0;
            res.SuppMsgOut = "success";
            return res;
        }

        public WMLS_GetFromStoreResponse WMLS_GetFromStore(WMLS_GetFromStoreRequest request)
        {
            WMLS_GetFromStoreResponse res = new WMLS_GetFromStoreResponse();
            if (request.QueryIn != null)
            {
                if (request.QueryIn.Contains("TestUID_1"))
                {
                    res.Result = 1;
                    res.XMLout = request.QueryIn;
                }
                else
                    throw new Exception("wrong");
            }
            return res;
        }

        public WMLS_GetVersionResponse WMLS_GetVersion(WMLS_GetVersionRequest request)
        {
            WMLS_GetVersionResponse res = new WMLS_GetVersionResponse();
            res.ResultVer = "WITSML1.4.1";
            return res;
        }

        public WMLS_UpdateInStoreResponse WMLS_UpdateInStore(WMLS_UpdateInStoreRequest request)
        {
            WMLS_UpdateInStoreResponse res = new WMLS_UpdateInStoreResponse();
            if (request.XMLin != null)
            {
                if (request.XMLin.Contains("TestUID_1"))
                {
                    res.Result = 1;
                }
                else
                    throw new Exception("wrong");
            }
            return res;
        }
    }
}
