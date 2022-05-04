using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SouthNests.Phoenix.Framework;
using System.Web.Script.Serialization;
using SouthNests.PhoenixMobile.Model;

namespace SouthNests.PhoenixMobile.Translators
{
    public class PhoenixMobileVesselTranslator
    {
        public static List<CategoryMenuItemModel> ListSubCategoryMenuItemList(CategoryMenuItemModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@SUBCATEGORYID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.subcategoryid));
            ParameterList.Add(DataAccess.GetDBParameter("@ISTECH", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.istech));
            ParameterList.Add(DataAccess.GetDBParameter("@ISOPERATION", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.isoperation));
            ParameterList.Add(DataAccess.GetDBParameter("@ISHSQEA", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.ishseqa));
            ParameterList.Add(DataAccess.GetDBParameter("@ISCREW", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.iscrew));
            ParameterList.Add(DataAccess.GetDBParameter("@PARENTID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.parentid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGMENUITEMLIST", ParameterList);

            return CategoryMenuItemModel.TranslateAsCategoryMenuItemList(dt);

        }

        public static List<SubCategoryModel> ListSubCategory(SubCategoryModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@CATEGORYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.categoryid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGSUBCATEGORYLIST", ParameterList);

            return SubCategoryModel.TranslateAsSubCategoryList(dt);

        }

        public static List<CategoryModel> ListCategory(CategoryModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGCATEGORYLIST", ParameterList);

            return CategoryModel.TranslateAsCategoryList(dt);

        }


        public static List<VesselModel> ListMobileVessels(string name)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            dt = DataAccess.ExecSPReturnDataTable("PRMOBILEVESSELLIST", ParameterList);

            return VesselModel.TranslateAsVesselList(dt);

        }
        public static List<VesselModel> ListMobileVessels(VesselModelSearch model)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            if (model != null)
            {
                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, model.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, model.pageNumber));
                ParameterList.Add(DataAccess.GetDBParameter("@TYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, model.typeid));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, model.pageSize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, model.resultCount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, model.resultCount));

                dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGSEARCH", ParameterList);

            }

            return VesselModel.TranslateAsVesselList(dt);


        }

        public static List<CountListModel> UserRecordsCountList(VesselModelSearch model)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, model.rowUserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@ISTELERIK", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, 1));

            dt = DataAccess.ExecSPReturnDataTable("PRGENERALSETTINGFETCH", ParameterList);

            return CountListModel.TranslateAsActionList(dt);

        }

        public static AuthenticateUser LoginMobileUser(MobileUserSignup u)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERNAME", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, u.email));
            ParameterList.Add(DataAccess.GetDBParameter("@PASSWORD", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, u.password));

            dt = DataAccess.ExecSPReturnDataTable("PRMOBILEUSERLOGIN", ParameterList);

            return MobileUsersModelTranslator.TranslateAsAuthenticateUser(dt);
        }

        public static int InsertMobileUser(MobileUsersModel m)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, 1));
            ParameterList.Add(DataAccess.GetDBParameter("@NAME", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, m.Name));
            ParameterList.Add(DataAccess.GetDBParameter("@EMAIL", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, m.EmailId));
            ParameterList.Add(DataAccess.GetDBParameter("@ADDRESS", SqlDbType.NVarChar, DbConstant.NVARCHAR_MAX, ParameterDirection.Input, m.Address));
            ParameterList.Add(DataAccess.GetDBParameter("@MOBILE", SqlDbType.NVarChar, DbConstant.NVARCHAR_20, ParameterDirection.Input, m.Mobile));
            ParameterList.Add(DataAccess.GetDBParameter("@ISACTIVE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, m.IsActive));
            ParameterList.Add(DataAccess.GetDBParameter("@ISAPPROVED", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, m.IsApproved));
            ParameterList.Add(DataAccess.GetDBParameter("@PUSHTOKEN", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, m.PushToken));
            ParameterList.Add(DataAccess.GetDBParameter("@DOJ", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, m.Doj));
            int n = DataAccess.ExecSPReturnInt("PRMOBILEUSERINSERT", ParameterList);

            return n;

        }

        public static AuthenticateUser SignupMobileUser(MobileUserSignup u)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERNAME", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, u.email));
            ParameterList.Add(DataAccess.GetDBParameter("@PASSWORD", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, u.password));

            dt = DataAccess.ExecSPReturnDataTable("PRMOBILEUSERSIGNUP", ParameterList);

            return MobileUsersModelTranslator.TranslateAsAuthenticateUser(dt);
        }
        public static List<VesselListModel> VesselListSearching(VesselModelSearch model)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, model.rowUserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, model.sortBy));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, model.sortDirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, model.pageNumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, model.pageSize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, model.resultCount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, model.resultCount));

            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGSEARCH", ParameterList);
            //foreach (SqlParameter sp in ParameterList)
            //{
            //    if (sp.Direction == ParameterDirection.Output)
            //    {
            //        if (sp.ParameterName == "@RESULTCOUNT")
            //            model.resultCount = (int)sp.Value;

            //        if (sp.ParameterName == "@TOTALPAGECOUNT")
            //            model.resultCount = (int)sp.Value;
            //    }
            //}
            return VesselListModel.TranslateAsVesselList(dt);

        }


    }
}