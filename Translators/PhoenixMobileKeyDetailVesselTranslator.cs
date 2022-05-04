using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SouthNests.Phoenix.Framework;
using System.Web.Script.Serialization;
using SouthNests.PhoenixMobile.Model;



namespace SouthNests.PhoenixMobile.Translators
{
    public class PhoenixMobileKeyDetailVesselTranslator
    {
        public static List<VesselKeyDetailsModel> VesselKeyDetailsList(VesselKeyDetailFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            //dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDVESSELDETAILSEDIT", ParameterList);
            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDOFFICEVESSELDETAILSEDIT", ParameterList);


            return VesselKeyDetailsModel.TranslateAsVesselKeyDetailsModelList(dt);

        }
    }
}