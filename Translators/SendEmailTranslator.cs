using SouthNests.Phoenix.Framework;
using SouthNests.PhoenixMobile.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Translators
{
    public class SendEmailTranslator
    {

        public static List<SetTemplateForEmailModel> SetTemplateForEmailList(Email scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@ELEMENTID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.elementId));


            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGMENUITEMEMAILTEMPLATELIST", ParameterList);

            return SetTemplateForEmailModel.TranslateAsActionList(dt);

        }

        public static List<EmailInfoForVesselModel> EmailInfoForVesselList(Email scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselId));


            dt = DataAccess.ExecSPReturnDataTable("PRVPRSREVIEWMAILDATAIL", ParameterList);

            return EmailInfoForVesselModel.TranslateAsActionList(dt);

        }


        public static List<DepartmentForEmailModel> DepartmentForEmailList(Email scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@DEPARTMENTTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.departmenttypeid));


            dt = DataAccess.ExecSPReturnDataTable("PRDEPARTMENTLIST", ParameterList);

            return DepartmentForEmailModel.TranslateAsActionList(dt);

        }



        public static List<DesignationForCreateTaskModel> DesignationForCreateTaskList(Email scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@DEPARTMENTID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.departmentid));


            dt = DataAccess.ExecSPReturnDataTable("PRDESIGNATIONLIST", ParameterList);

            return DesignationForCreateTaskModel.TranslateAsActionList(dt);

        }

    }
}