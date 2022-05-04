using SouthNests.Phoenix.Framework;
using SouthNests.PhoenixMobile.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Model;

namespace WebApplication1.Translators
{
    public class PhoenixMobileActionDashboardTranslator
    {
        public static List<DashboardTechnicalMaintenanceScreenListModel> DashboardTechnicalMaintenanceScreenList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@FROMDATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, scmf.fromDate));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, scmf.toDate));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRPMSDAILYWORKPLANISSUEDWORKORDERSEARCH", ParameterList);

            return DashboardTechnicalMaintenanceScreenListModel.TranslateAsActionList(dt);

        }
        public static List<DashboardTechnicalOperationScreenListModel> DashboardTechnicalOperationScreenList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@ISKEYACTIVITY", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.iskeyactivity));
            ParameterList.Add(DataAccess.GetDBParameter("@FROMDATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, scmf.fromDate));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, scmf.toDate));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber)); 
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRPMSDAILYWORKPLANACTIVITYOPERATIONSEARCH", ParameterList);

            return DashboardTechnicalOperationScreenListModel.TranslateAsActionList(dt);

        }

        public static List<PlannedMaintenanceOrderInformationModel> PlannedMaintenanceOrderInformationList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@TYPE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.type));
            ParameterList.Add(DataAccess.GetDBParameter("@ISOFFICEUSER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.isofficeruser));
            ParameterList.Add(DataAccess.GetDBParameter("@FROMDATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetDateTimeToString(DateTime.Now.AddDays(-7))));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetDateTimeToString(DateTime.Now)));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRPMSORDERINFORMATIONSEARCH", ParameterList);

            return PlannedMaintenanceOrderInformationModel.TranslateAsActionList(dt);

        }


        public static List<StoresandSparesDashoardScreenListModel> StoresandSparesDashoardList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            //ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@DASHBOARDCODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.dashboardcode));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRPURCHASEFORMSDASHBOARD", ParameterList);

            return StoresandSparesDashoardScreenListModel.TranslateAsActionList(dt);

        }


        public static List<DefectsAndNonRoutineJobsListModel> DefectsAndNonRoutineJobsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
     
          ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
          ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
          ParameterList.Add(DataAccess.GetDBParameter("@COMPONENTNUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, General.GetNullableString(scmf.CompNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@COMPONENTNAME", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, General.GetNullableString(scmf.CompName)));
          ParameterList.Add(DataAccess.GetDBParameter("@RESPONSIBILITY", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, General.GetNullableInteger(scmf.Responsibility)));
          ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
          ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
          ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
          ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
          ParameterList.Add(DataAccess.GetDBParameter("@STATUSID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, General.GetNullableInteger(scmf.statusid)));
          ParameterList.Add(DataAccess.GetDBParameter("@TITLE", SqlDbType.VarChar, DbConstant.VARCHAR_400, ParameterDirection.Input, General.GetNullableString(scmf.title)));
          ParameterList.Add(DataAccess.GetDBParameter("@TYPE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, General.GetNullableInteger(scmf.type)));
          ParameterList.Add(DataAccess.GetDBParameter("@DEFECTNO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.DefectNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@DEFECTDETAILS", SqlDbType.NVarChar, DbConstant.NVARCHAR_MAX, ParameterDirection.Input, General.GetNullableString(scmf.DefectDetails)));
          ParameterList.Add(DataAccess.GetDBParameter("@SOURCE", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, General.GetNullableString(scmf.Source)));
          ParameterList.Add(DataAccess.GetDBParameter("@SIRECODE", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, General.GetNullableString(scmf.SIRECode)));
          ParameterList.Add(DataAccess.GetDBParameter("@PSCCODE", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, General.GetNullableString(scmf.PSCCode)));
          ParameterList.Add(DataAccess.GetDBParameter("@ISSUEDATEFROM", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetNullableDateTime(scmf.DateofIssue)));
          ParameterList.Add(DataAccess.GetDBParameter("@ISSUEDATETO", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetNullableDateTime(scmf.DateofIssueTo)));
          ParameterList.Add(DataAccess.GetDBParameter("@DUEDATEFROM", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetNullableDateTime(scmf.Due)));
          ParameterList.Add(DataAccess.GetDBParameter("@DUEDATETO", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetNullableDateTime(scmf.DueTo)));
          ParameterList.Add(DataAccess.GetDBParameter("@JOBNO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.JobNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@WONO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.WONo)));
          ParameterList.Add(DataAccess.GetDBParameter("@SIGNIFICANTDEFECT", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, General.GetNullableInteger(scmf.SignificantType)));
          ParameterList.Add(DataAccess.GetDBParameter("@DDJOB", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, General.GetNullableInteger(scmf.DDJob)));
          ParameterList.Add(DataAccess.GetDBParameter("@RANO", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, General.GetNullableString(scmf.RANo)));
          ParameterList.Add(DataAccess.GetDBParameter("@REQNNO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.ReqnNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@STOREREQNNO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.StoreReqnNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@SERVICEREQNNO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.ServiceReqnNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@REQUESTREQNNO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.RequestReqnNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@COMPLETIONDATEFROM", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetNullableDateTime(scmf.CompletionDate)));
          ParameterList.Add(DataAccess.GetDBParameter("@COMPLETIONDATETO", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, General.GetNullableDateTime(scmf.CompletionDateTo)));
          ParameterList.Add(DataAccess.GetDBParameter("@ISDISPENSATION", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.Dispensation));
          ParameterList.Add(DataAccess.GetDBParameter("@RAREQUIRED", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.RARequired));
          ParameterList.Add(DataAccess.GetDBParameter("@SPARESAVAILABLE", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.SpareAvailable));
          ParameterList.Add(DataAccess.GetDBParameter("@STORESAVAILABLE", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.StoreAvailable));
          ParameterList.Add(DataAccess.GetDBParameter("@MACHINERYFAILURE", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.MachineryFailure));
          ParameterList.Add(DataAccess.GetDBParameter("@ASSISTANTREQUIRED", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.AssistantRequired));
          ParameterList.Add(DataAccess.GetDBParameter("@MACHINERYFAILURENO", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, General.GetNullableString(scmf.MachineryFailureNo)));
          ParameterList.Add(DataAccess.GetDBParameter("@ISREVIEWREJECTED", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.ReviewRejected));
          ParameterList.Add(DataAccess.GetDBParameter("@ISNEWOFFICECOMMENT", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.IsNewOfficeComment));
          ParameterList.Add(DataAccess.GetDBParameter("@ISNEWVESSELCOMMENT", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.IsNewVesselComment));

            dt = DataAccess.ExecSPReturnDataTable("PRDEFECTJOBSEARCH", ParameterList);

            return DefectsAndNonRoutineJobsListModel.TranslateAsActionList(dt);

        }

        public static List<ShipboardTasksInAlertAndCrewDocumentsDashboardModel> ShipboardTasksInAlertAndCrewDocumentsDashboardList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@OVERDUEYN", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.overdueyn));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDTASKDETAILS", ParameterList);

            return ShipboardTasksInAlertAndCrewDocumentsDashboardModel.TranslateAsActionList(dt);

        }


        public static List<InspectionDrillScheduleModel> InspectionDrillScheduleList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            //ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@OVERDUE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.overdue));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRDRILLSCHEDULESCREENSEARCH", ParameterList);

            return InspectionDrillScheduleModel.TranslateAsActionList(dt);

        }


        public static List<InspectionTrainingScheduleModule> InspectionTrainingScheduleList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            //ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@OVERDUE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.overdue));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRTRAININGONBOARDSCHEDULESCREENSEARCH", ParameterList);

            return InspectionTrainingScheduleModule.TranslateAsActionList(dt);

        }


        public static List<DashboardCrewExpiryDocumentDetailsModel> DashboardCrewExpiryDocumentDetailsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@DUEDAYS", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.duedays));
    
            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDEXPIRYDOCUMENTLIST", ParameterList);

            return DashboardCrewExpiryDocumentDetailsModel.TranslateAsActionList(dt);

        }


        public static List<InspectionDashboardSealUsageModel> InspectionDashboardSealUsageList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@OVERDUE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.overdue));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDSEALUSAGESEARCH", ParameterList);

            return InspectionDashboardSealUsageModel.TranslateAsActionList(dt);

        }


        public static List<VesselAccountsEmployeeQueryDashboardModel> VesselAccountsEmployeeQueryDashboardList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();


            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            if (scmf.code== "NCCM")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRVESSELEMPLOYEESEARCHDASHBOARDNCCM", ParameterList);
            }
            if (scmf.code == "RHWM")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRVESSELEMPLOYEESEARCHDASHBOARDRHWM", ParameterList);
            }
            if (scmf.code == "RHWH")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRVESSELEMPLOYEESEARCHDASHBOARDRHWH", ParameterList);
            }
            if (scmf.code == "RHWS")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRVESSELEMPLOYEESEARCHDASHBOARDRHWS", ParameterList);
            }
            if (scmf.code == "VSWHS")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRVESSELEMPLOYEESEARCHDASHBOARDVSWHS", ParameterList);
            }
            if (scmf.code == "NCCM2")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRVESSELEMPLOYEESEARCHDASHBOARDNCCM2", ParameterList);
            }


            return VesselAccountsEmployeeQueryDashboardModel.TranslateAsActionList(dt);

        }

        public static List<DashboardTechnicalRAStatusModel> DashboardTechnicalRAStatusList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DateTime.Now.AddDays(30)));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBORADNONROUTINERASTATUSSEARCH", ParameterList);

            return DashboardTechnicalRAStatusModel.TranslateAsActionList(dt);

        }



        public static List<DashboardTechnicalPTWStatusModel> DashboardTechnicalPTWStatusList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@CSVSTATUSID", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DateTime.Now.AddDays(7)));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDWORKORDERPTWSTATUSSEARCH", ParameterList);

            return DashboardTechnicalPTWStatusModel.TranslateAsActionList(dt);

        }

        public static List<DashboardTechnicalDMFFormsModel> DashboardTechnicalDMFFormsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            if (scmf.code ==null){
                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));
                dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDFORMDUESEARCH", ParameterList);

            }
            else
            {
                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
                ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, scmf.code));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

                dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDFORMSTATUSSEARCH", ParameterList);

            }

            return DashboardTechnicalDMFFormsModel.TranslateAsActionList(dt);

        }


        public static List<DashboardTechnicalRAModel> DashboardTechnicalRAList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DateTime.Now.AddDays(7)));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBORADNONROUTINERADUE", ParameterList);

            return DashboardTechnicalRAModel.TranslateAsActionList(dt);

        }


        public static List<InspectionDashboardIncidentNearMissModel> InspectionDashboardIncidentNearMissList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, scmf.code));

            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDINCIDENTSEARCH", ParameterList);

            return InspectionDashboardIncidentNearMissModel.TranslateAsActionList(dt);

        }



        public static List<InspectionDashboardUnsafeActsConditionsModel> InspectionDashboardUnsafeActsConditionsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, scmf.code));

            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDUNSAFEACTSCONDITIONSEARCH", ParameterList);

            return InspectionDashboardUnsafeActsConditionsModel.TranslateAsActionList(dt);

        }


        public static List<DashboardTechnicalPTWDueModel> DashboardTechnicalPTWDueList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DateTime.Now.AddDays(7)));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDWORKORDERPTWDUESEARCH", ParameterList);

            return DashboardTechnicalPTWDueModel.TranslateAsActionList(dt);

        }


    }
}