using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SouthNests.Phoenix.Framework;
using System.Web.Script.Serialization;
using SouthNests.PhoenixMobile.Model;

namespace SouthNests.PhoenixMobile.Translators
{
    public class PhoenixMobileDashboardPanelTranslator
    {
        public static List<DashboardPanelModelPurchase> ListSubCategoryElementPurchase(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASE", ParameterList);

            return DashboardPanelModelPurchase.TranslateAsDashboardPanelModelPurchaseList(dt);

        }


        public static List<DashboardPanelModelDrills> ListSubCategoryElementDrills(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGHSEQADRILL", ParameterList);

            return DashboardPanelModelDrills.TranslateAsDashboardPanelModelDrillsList(dt);

        }


        public static List<DashboardPanelModelVesselPerformance> ListSubCategoryElementVesselPerformance(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGVPRSDUE", ParameterList);

            return DashboardPanelModelVesselPerformance.TranslateAsDashboardPanelModelVesselPerformance(dt);

        }

        //public static DashboardPanelModelOpenReports ListSubCategoryElementOpenReports(DashboardPanelModelFilter scmf)
        //{
        //    DataTable dt = new DataTable();
        //    List<SqlParameter> ParameterList = new List<SqlParameter>();

        //    ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
        //    ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
        //    dt = DataAccess.ExecSPReturnDataSet("PRVESSELDAILYMONITORINGCREWCOMPLAINTOPENREPORT", ParameterList);

        //    return DashboardPanelModelOpenReports.TranslateAsDashboardPanelModelOpenReport(dt);

        //}
        public static List<DashboardPanelModelOpenReports> ListSubCategoryElementOpenReports(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGCREWCOMPLAINTOPENREPORT", ParameterList);

            return DashboardPanelModelOpenReports.TranslateAsDashboardPanelModelOpenReports(dt);

        }


        public static List<DashboardPanelModelCertificateSurvey> ListSubCategoryElementCertificateSurvey(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGCERTIFICATECOUNT", ParameterList);

            return DashboardPanelModelCertificateSurvey.TranslateAsDashboardPanelModelCertificateSurvey(dt);

        }

        public static List<DashboardPanelModelCertificateSurveyDueList> ListSubCategoryElementCertificateSurveyDueList(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@DUEINTERVAL", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.dueinterval));
            ParameterList.Add(DataAccess.GetDBParameter("@CATEGORYCODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.categorycode));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.sortby));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.sortdirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount)); 
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@SHOWACTIONED", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.showActioned));


            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGCERTIICATEDUELIST", ParameterList);

            return DashboardPanelModelCertificateSurveyDueList.TranslateAsDashboardPanelModelCertificateSurveyDueList(dt);

        }



        public static List<DashboardPanelModelAuditAndInspectionTask> ListSubCategoryElementAuditAndInspectionTask(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGHSEQATASK", ParameterList);

            return DashboardPanelModelAuditAndInspectionTask.TranslateAsDashboardPanelModelAuditAndInspectionTask(dt);

        }


        public static List<DashboardPanelModelAuditAndInspection> ListSubCategoryElementAuditAndInspection(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input,null));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGHSEQAAUDITINSPECTION", ParameterList);

            return DashboardPanelModelAuditAndInspection.TranslateAsDashboardPanelModelAuditAndInspection(dt);

        }



        public static List<DashboardPanelModelPMS> ListSubCategoryElementPMS(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDOFFICEPMSSUMARRY", ParameterList);

            return DashboardPanelModelPMS.TranslateAsDashboardPanelModelPMSList(dt);

        }

        public static List<DashboardPanelModelRiskMoc> ListSubCategoryElementsRiskMoc(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGHSEQAMOC", ParameterList);

            return DashboardPanelModelRiskMoc.TranslateAsDashboardPanelModelRiskMocList(dt);

        }


           public static List<DashboardPanelModelRiskRa> ListSubCategoryElementsRiskRa(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGHSEQARA", ParameterList);


            return DashboardPanelModelRiskRa.TranslateAsDashboardPanelModelRiskRa(dt);


        }

        //public static List<DashboardPanelModelIncident> ListSubCategoryElementIncident(DashboardPanelModelFilter scmf)
        //{
        //    DataSet ds = new DataSet();
        //    List<SqlParameter> ParameterList = new List<SqlParameter>();

        //    ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
        //    ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
        //    ds = DataAccess.ExecSPReturnDataSet("PRVESSELDAILYMONITORINGHSEQAINCIDENT", ParameterList);

        //    return DashboardPanelModelIncident.TranslateAsDashboardPanelModelIncidentList(ds);

        //}
        ///
        public static List<DashboardPanelModelIncident> ListSubCategoryElementIncident(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGHSEQAINCIDENT", ParameterList);

            return DashboardPanelModelIncident.TranslateAsDashboardPanelModelIncidentList(dt);

        }
        public static List<cargoOperationsList> cargoOperationsPanelList(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGVPRSTRADINGCARGOOPERATION", ParameterList);

            return cargoOperationsList.TranslateAscargoOperationsList(dt);

        }


        public static List<TradingAreaList> TradingAreaOperationsPanelList(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGVPRSTRADINGWX", ParameterList);

            return TradingAreaList.TranslateAsTradingAreaListOperationsList(dt);

        }


        public static List<OthersOperationPanelList> OthersOperationsPanelList(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGOPERATIONWRH", ParameterList);

            return OthersOperationPanelList.TranslateAsOthersOperationPanelList(dt);

        }



        public static List<ManningAndDocumentsList> ManningAndDocumentsPanelList(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGCREWDOCUMENT", ParameterList);

            return ManningAndDocumentsList.TranslateAsManningAndDocumentsPanelList(dt);

        }



        public static List<CrewChangesAndApproval> CrewChangesAndApprovalPanelList(DashboardPanelModelFilter scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            dt = DataAccess.ExecSPReturnDataTable("PRVESSELDAILYMONITORINGCREWCHANGE", ParameterList);

            return CrewChangesAndApproval.TranslateAsCrewChangesAndApprovalPanelList(dt);

        }
    }
}