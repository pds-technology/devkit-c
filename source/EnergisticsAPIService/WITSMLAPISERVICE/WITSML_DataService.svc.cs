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
