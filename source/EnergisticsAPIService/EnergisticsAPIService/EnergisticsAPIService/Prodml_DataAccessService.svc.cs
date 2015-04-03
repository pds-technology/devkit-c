using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Energistics.DataAccess.WITSML141;
namespace EnergisticsAPIService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Prodml_DataAccessService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Prodml_DataAccessService.svc or Prodml_DataAccessService.svc.cs at the Solution Explorer and start debugging.
    public class Prodml_DataAccessService : PROD_GenericDataAccessSoap
    {

        GenericDataAccessCapabilities PROD_GenericDataAccessSoap.GetCapabilities()
        {
            NameValuePair pair = new NameValuePair();
            pair.Name = "NAME";
            pair.Value = "PRODML1.2.2";
            GenericDataAccessCapabilities res = new GenericDataAccessCapabilities();
            res.Properties = new NameValuePair[1];
            res.Properties[0] = pair;
            return res;
        }

        GetDataResult PROD_GenericDataAccessSoap.GetData(GetDataQuery query)
        {
            string uid = "TestUID_1";
            GetDataResult res = new GetDataResult();
            String[] test = query.Uid;
            if (test[0].CompareTo(uid) == 0)
            {
                Energistics.DataAccess.PRODML122.FluidAnalysis fa = new Energistics.DataAccess.PRODML122.FluidAnalysis();
                fa.AnalysisCompany = "Energistics";
                fa.Uid = uid;
                Energistics.DataAccess.PRODML122.FluidAnalysisList falist = new Energistics.DataAccess.PRODML122.FluidAnalysisList();
                falist.FluidAnalysis = new List<Energistics.DataAccess.PRODML122.FluidAnalysis>();
                falist.FluidAnalysis.Add(fa);
                res.abstractDataObject = falist;
            }
            return res;

        }

        PutDataResponse PROD_GenericDataAccessSoap.PutData(PutDataRequest request)
        {
            PutDataResponse res = new PutDataResponse();
            res.putDataResult = new PutDataResult[1];
            res.putDataResult[0] = new PutDataResult();
            Energistics.DataAccess.PRODML122.AbstractObject obj = request.abstractDataObject;
            if (obj != null)
            {
                res.putDataResult[0].Id = "1";
                res.putDataResult[0].Status = PutDataResultStatus.Added;
                res.putDataResult[0].SuppMsg = "Success!";
            }
            return res;
        }

        DeleteDataResponse PROD_GenericDataAccessSoap.DeleteData(DeleteDataRequest request)
        {
            DeleteDataResponse res = new DeleteDataResponse();
            res.deleteDataResult = new DeleteDataResult();
            String[] test = request.Uid;
            if (test[0].CompareTo("TestUID_1") == 0)
                res.deleteDataResult.Count = 999;
            else
                res.deleteDataResult.Count = 0;
            return res;
        }
    }
}
