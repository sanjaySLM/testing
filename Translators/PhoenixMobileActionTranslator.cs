using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SouthNests.Phoenix.Framework;
using System.Web.Script.Serialization;
using SouthNests.PhoenixMobile.Model;

namespace SouthNests.PhoenixMobile.Translators
{
    public class PhoenixMobileActionTranslator
    {
        public static List<ActionCrewList> crewListActionList(crewList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@RANKID", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.rankid));
            ParameterList.Add(DataAccess.GetDBParameter("@ONDATE", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.ondate));
            ParameterList.Add(DataAccess.GetDBParameter("@SAILONLY", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.sailonly));
            ParameterList.Add(DataAccess.GetDBParameter("@ACCESS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.access));
            ParameterList.Add(DataAccess.GetDBParameter("@FAMILYYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.familyyn));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.sortby));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.sortdirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@NAME", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.name));
            ParameterList.Add(DataAccess.GetDBParameter("@NATIONALITY", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.nationality));
            ParameterList.Add(DataAccess.GetDBParameter("@EXTRACREW", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.extracrew));
            ParameterList.Add(DataAccess.GetDBParameter("@RELIEFDUEDAYS", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.reliefduedate));



            dt = DataAccess.ExecSPReturnDataTable("PRCREWOFFSHORECREWLISTSHOWALLSEARCH", ParameterList);

            return ActionCrewList.TranslateAsActionCrewList(dt);

        }

        public static List<ActionEventList> EventListActionList(EventList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@EVENTFROM", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.eventfrom));
            ParameterList.Add(DataAccess.GetDBParameter("@EVENTTO", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.eventto));
            ParameterList.Add(DataAccess.GetDBParameter("@PORTID", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.portid));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.sortby));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.sortdirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@DASHBOARDYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.dashboardyn));




            dt = DataAccess.ExecSPReturnDataTable("PRCREWEVENTSEARCH", ParameterList);

            return ActionEventList.TranslateAsActionEventList(dt);

        }


        public static List<ActionStoresAndSparesList> sparesAndStoresActionList(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPURCHASESUMMARY", ParameterList);

            return ActionStoresAndSparesList.TranslateAsActionStoresAndSparesList(dt);

        }

        public static List<ActionAlertsAndCrewDocumentsList> AlertsAndCrewDocumentsActionList(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDCREWDOCUMENTALERTLIST", ParameterList);

            return ActionAlertsAndCrewDocumentsList.TranslateAsActionAlertsAndCrewDocumentsList(dt);

        }


        public static List<ActionMaintenanceAndOperationList> MaintainanceAndOperationActionList(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRPMSDAILYWORKPLANISSUEDWORKORDERSUMMARY", ParameterList);

            return ActionMaintenanceAndOperationList.TranslateAsActionMaintenanceAndOperationList(dt);

        }


        public static List<ActionOrdersAndInformationList> OrdersAndInformationAActionList(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDORDERINFORMATIONLIST", ParameterList);

            return ActionOrdersAndInformationList.TranslateAsActionOrdersAndInformationList(dt);

        }

        public static List<ActionOrdersAndInformationListB> OrdersAndInformationAActionListB(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDVESSELUNREADCOUNT", ParameterList);

            return ActionOrdersAndInformationListB.TranslateAsActionOrdersAndInformationListB(dt);

        }


        public static List<PMSList> PMSActionList(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDVESSELPMSSUMARRY", ParameterList);

            return PMSList.TranslateAsActionPMSList(dt);

        }

        public static List<WorkAndRestHoursList> WorkAndRestHoursActionList(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDWORKANDRESTHOURLIST", ParameterList);

            return WorkAndRestHoursList.TranslateAsActionWorkAndRestHoursList(dt);

        }

        public static List<WorkAndRestHoursListB> WorkAndRestHoursActionListB(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDWRHALERT", ParameterList);

            return WorkAndRestHoursListB.TranslateAsActionWorkAndRestHoursListB(dt);

        }
        public static List<DefectsAndNonRoutineList> DefectsAndNonRoutineJobsList(StoresAndSparesList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDVESSELDEFECTSUMARRY", ParameterList);

            return DefectsAndNonRoutineList.TranslateAsActionDefectsAndNonRoutineList(dt);

        }

        public static List<TimeSheetList> TimesheetActionList(Timesheet scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@FROMDATE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.fromdate));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.todate));
            ParameterList.Add(DataAccess.GetDBParameter("@OPERATION", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.operation));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELSTATUS", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.vesselstatus));
            ParameterList.Add(DataAccess.GetDBParameter("@SOURCE", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.source));
            ParameterList.Add(DataAccess.GetDBParameter("@ENTEREDBY", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, scmf.enteredby));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.sortby));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.sortdirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Output, scmf.totalpagecount));




            dt = DataAccess.ExecSPReturnDataTable("PRPMSTIMESHEETSEARCH", ParameterList);

            return TimeSheetList.TranslateAsActionTimeSheetList(dt);

        }


        public static List<ActionPersonnelOnDutyList> PersonnelOnDutyActionList(PersonnelOnDutyList scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDWORKANDRESTHOURLIST", ParameterList);

            return ActionPersonnelOnDutyList.TranslateAsActionPersonnelOnDutyList(dt);

        }

        public static NearMissList NearMissListActionList(StoresAndSparesList scmf)
        {
            DataSet dt = new DataSet();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));


            dt = DataAccess.ExecSPReturnDataSet("PRDASHBOARDUNSAFEACCIDENTNEARMISSSUMMARY", ParameterList);

            return NearMissList.TranslateAsNearMissList(dt);

        }


        public static DataTable DashboardNonRoutineRASearch(int VesselId, DateTime? ToDate,
               string sortexpression,
               int? sortdirection,
               int iPageNumber,
               int iPageSize,
               ref int iRowCount,
               ref int iTotalPageCount)
        {

            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, 1));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, VesselId));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, ToDate));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.VarChar, DbConstant.NVARCHAR_100, ParameterDirection.Input, sortexpression));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, sortdirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, iPageNumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, iPageSize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, iRowCount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, iTotalPageCount));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRDASHBORADNONROUTINERADUE", ParameterList);
            foreach (SqlParameter sp in ParameterList)
            {
                if (sp.Direction == ParameterDirection.Output)
                {
                    if (sp.ParameterName == "@RESULTCOUNT")
                        iRowCount = (int)sp.Value;

                    if (sp.ParameterName == "@TOTALPAGECOUNT")
                        iTotalPageCount = (int)sp.Value;
                }
            }
            return dt;
        }

        public static DataTable DashboardNonRoutineRAStatusCount(int VesselId, DateTime? ToDate)
        {

            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, 1));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, VesselId));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, ToDate));
            return DataAccess.ExecSPReturnDataTable("PRDASHBORADNONROUTINERASTATUSCOUNT", ParameterList);
        }
        public static DataTable DashboardPTWDueSearch(int VesselId, DateTime? ToDate,
            string sortexpression,
            int? sortdirection,
            int iPageNumber,
            int iPageSize,
            ref int iRowCount,
            ref int iTotalPageCount)
        {

            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, 1));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, VesselId));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, ToDate));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.VarChar, DbConstant.NVARCHAR_100, ParameterDirection.Input, sortexpression));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, sortdirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, iPageNumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, iPageSize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, iRowCount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, iTotalPageCount));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDWORKORDERPTWDUESEARCH", ParameterList);
            foreach (SqlParameter sp in ParameterList)
            {
                if (sp.Direction == ParameterDirection.Output)
                {
                    if (sp.ParameterName == "@RESULTCOUNT")
                        iRowCount = (int)sp.Value;

                    if (sp.ParameterName == "@TOTALPAGECOUNT")
                        iTotalPageCount = (int)sp.Value;
                }
            }
            return dt;
        }

        public static DataTable DashboardPTWStatusSearch(int VesselId, DateTime? ToDate, string csvStatusId,
             string sortexpression,
             int? sortdirection,
             int iPageNumber,
             int iPageSize,
             ref int iRowCount,
             ref int iTotalPageCount)
        {

            List<SqlParameter> ParameterList = new List<SqlParameter>();
            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, 1));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, VesselId));
            ParameterList.Add(DataAccess.GetDBParameter("@TODATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, ToDate));
            ParameterList.Add(DataAccess.GetDBParameter("@CSVSTATUSID", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, csvStatusId));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTBY", SqlDbType.VarChar, DbConstant.NVARCHAR_100, ParameterDirection.Input, sortexpression));
            ParameterList.Add(DataAccess.GetDBParameter("@SORTDIRECTION", SqlDbType.TinyInt, DbConstant.TINYINT, ParameterDirection.Input, sortdirection));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, iPageNumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, iPageSize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, iRowCount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, iTotalPageCount));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDWORKORDERPTWSTATUSSEARCH", ParameterList);
            foreach (SqlParameter sp in ParameterList)
            {
                if (sp.Direction == ParameterDirection.Output)
                {
                    if (sp.ParameterName == "@RESULTCOUNT")
                        iRowCount = (int)sp.Value;

                    if (sp.ParameterName == "@TOTALPAGECOUNT")
                        iTotalPageCount = (int)sp.Value;
                }
            }
            return dt;
        }

        public static DataTable DashboardFormCheckListDue(int VesselId)
        {

            List<SqlParameter> ParameterList = new List<SqlParameter>
            {
                DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, 1),
                DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, VesselId)
            };
            return DataAccess.ExecSPReturnDataTable("PRDASHBOARDFORMDUELIST", ParameterList);
        }
        public static DataTable DashboardFormCheckListStatusList(int VesselId, string Status)
        {

            List<SqlParameter> ParameterList = new List<SqlParameter>
            {
                DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input,1),
                DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, VesselId),
                DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_100, ParameterDirection.Input, Status)
            };
            return DataAccess.ExecSPReturnDataTable("PRDASHBOARDFORMSTATUSLIST", ParameterList);
        }

        public static List<ReliefPLanAlertList> ReliefPlanAlertList(ReliefPlan scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));



            dt = DataAccess.ExecSPReturnDataTable("PROFFSHOREPLANEDCREWLIST", ParameterList);

            return ReliefPLanAlertList.TranslateAsReliefPLanAlertList(dt);

        }

        public static List<ReliefPlanCurrentPlannedList> CrewReliefPlanCurrentPlannedList(ReliefPlan scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));



            dt = DataAccess.ExecSPReturnDataTable("PRCERWRELIEFPLANRELIEVEELISTSEARCH", ParameterList);

            return ReliefPlanCurrentPlannedList.TranslateAsReliefPlanCurrentPlannedList(dt);

        }


        public static List<CertificatesList> ActionCertificatesList(ReliefPlan scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@DAYS", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.days));
            ParameterList.Add(DataAccess.GetDBParameter("@SHOWNOTAPPLICABLE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.shownotapplicable));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));



            dt = DataAccess.ExecSPReturnDataTable("PRVESSELSURVEYCERTIFICATESCHEDULESEARCH", ParameterList);

            return CertificatesList.TranslateAsCertificatesList(dt);

        }



        public static List<EfillingList> ActionEfilingList(ReliefPlan scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));



            dt = DataAccess.ExecSPReturnDataTable("PRFMSPLANNEDMAINTENANCEFORMSEARCH", ParameterList);

            return EfillingList.TranslateAsEfillingList(dt);

        }


        public static List<EfillingOfficeFormsList> ActionEfilingOfficeList(EfillingOfficeForms scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.companyid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.NVarChar, DbConstant.NVARCHAR_200, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@CATEGORYID", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.categoryid));



            dt = DataAccess.ExecSPReturnDataTable("PRFMSFORMSEARCH", ParameterList);

            return EfillingOfficeFormsList.TranslateAsEfillingOfficeFormsList(dt);

        }
    }
}