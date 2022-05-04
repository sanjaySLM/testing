using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SouthNests.Phoenix.Framework;
using System.Web.Script.Serialization;
using SouthNests.PhoenixMobile.Model;

namespace SouthNests.PhoenixMobile.Translators
{
    public class PhoenixMobileUserContextTranslator
    {
        public static List<MobilePhoenixUserContext> MobileUserContext(MobilePhoenixUserLogin scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERNAME", SqlDbType.VarChar, DbConstant.NVARCHAR_100, ParameterDirection.Input, scmf.username));
            ParameterList.Add(DataAccess.GetDBParameter("@PASSWORD", SqlDbType.VarChar, DbConstant.NVARCHAR_100, ParameterDirection.Input, scmf.password));
            dt = DataAccess.ExecSPReturnDataTable("PRUSERLOGIN", ParameterList);

            return MobilePhoenixUserContext.TranslateAsUserContextList(dt);

        }
    }
}