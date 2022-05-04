using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SouthNests.Phoenix.Framework;
using System.Web.Script.Serialization;
using SouthNests.PhoenixMobile.Model;

namespace SouthNests.PhoenixMobile.Translators
{
    public class PanelTranslator
    {
        public static List<QuartelyReport> QuartelyReportList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRVPRSQUARTERLYREPORTSEARCH", ParameterList);

            return QuartelyReport.TranslateAsActionList(dt);

        }


        public static List<MonthlyReport> MonthlyReportList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRVPRSMONTHLYREPORTSEARCH", ParameterList);

            return MonthlyReport.TranslateAsActionList(dt);

        }



        public static List<NoonReport> NoonReportList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRVPRSNOONREPORTDEFAULTSEARCH", ParameterList);

            return NoonReport.TranslateAsActionList(dt);

        }


        public static List<OverdueJobs> OverdueJobsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSMAINTENANCEDUE", ParameterList);

            return OverdueJobs.TranslateAsActionList(dt);

        }



        public static List<OverdueWorkOrder> OverdueWorkOrderList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSJOBPLANNEDSEARCH", ParameterList);

            return OverdueWorkOrder.TranslateAsActionList(dt);

        }



        public static List<CriticalOverdueJobs> CriticalOverdueJobsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@PRIORITY", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.priority));
            ParameterList.Add(DataAccess.GetDBParameter("@DUETO", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, scmf.dueto));
            ParameterList.Add(DataAccess.GetDBParameter("@ISCRITICAL", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.iscritical));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSMAINTENANCEDUE", ParameterList);

            return CriticalOverdueJobs.TranslateAsActionList(dt);

        }



        public static List<MajorOverhauls> MajorOverhaulsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
         

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSJOBPLANNEDSEARCH", ParameterList);

            return MajorOverhauls.TranslateAsActionList(dt);

        }



        public static List<Cat2MajorOverhauls> Cat2MajorOverhaulsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));


            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSJOBPLANNEDSEARCH", ParameterList);

            return Cat2MajorOverhauls.TranslateAsActionList(dt);

        }


        public static List<WOverified> WOverifiedList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VERIFICATIONTYPE", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.verifyType));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));


            dt = DataAccess.ExecSPReturnDataTable("PRWORKORDERVERIFICATIONPENDINGSEARCH", ParameterList);

            return WOverified.TranslateAsActionList(dt);

        }

        public static List<PostpondedJobs> PostpondedJobsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));


            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSJOBSEARCH ", ParameterList);

            return PostpondedJobs.TranslateAsActionList(dt);

        }


        public static List<Cat1MajorOverHaulDue60Days> Cat1MajorOverHaulDue60DaysList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@DAYS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.days));
            ParameterList.Add(DataAccess.GetDBParameter("@JOBCATEGORYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.JobCategoryId));
            //ParameterList.Add(DataAccess.GetDBParameter("@CLASSCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.classcode));
            ParameterList.Add(DataAccess.GetDBParameter("@JOBCLASS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.Jobclass));


            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSMAINTENANCEDUE ", ParameterList);

            return Cat1MajorOverHaulDue60Days.TranslateAsActionList(dt);

        }




        public static List<Cat2MajorOverHaulDue60Days> cat2MajorOverHaulDue60DaysList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@DAYS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.days));
            ParameterList.Add(DataAccess.GetDBParameter("@JOBCATEGORYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.JobCategoryId));
            //ParameterList.Add(DataAccess.GetDBParameter("@CLASSCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.classcode));
            ParameterList.Add(DataAccess.GetDBParameter("@JOBCLASS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.Jobclass));



            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDPMSMAINTENANCEDUE ", ParameterList);

            return Cat2MajorOverHaulDue60Days.TranslateAsActionList(dt);

        }

        public static List<PurchaseForm> PurchaseFormsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            
            //PO Awaiting Vessel Receipt
            if (scmf.code == "POAWVR")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHPOAWVR", ParameterList);
            }
            //Quotation Not Received
            if (scmf.code == "QTNR")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHQTNR", ParameterList);
            }
            //Quotation Awaiting Approval > 10k
            if (scmf.code == "QAA10K")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHQAA10K", ParameterList);
            }
            //Quotation Awaiting Approval > 5k
            if (scmf.code == "QAA5K")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHQAA5K", ParameterList);
            }
            //RFQ Awaiting Approval
            if (scmf.code == "RFQAP")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHRFQAP", ParameterList);
            }
            //POs Not Delivered by Delivery Date
            if (scmf.code == "POND")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHPOND", ParameterList);
            }
            //Approved Quotations Pending PO Issue
            if (scmf.code == "AQPPO")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHAQPPO", ParameterList);
            }
            //New Requisitions Received-- - 
            if (scmf.code == "REQV2")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHREQV2", ParameterList);
            }
            //PO Filed but Invoice not Received
            if (scmf.code == "INVV2")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHINVV2", ParameterList);
            }
            //PO Awaiting Superintendent Approval
            if (scmf.code == "SUPV2")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHSUPV2", ParameterList);
            }
            //PO Awaiting Fleet Manager Approval
            if (scmf.code == "FLTV2")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHFLTV2", ParameterList);
            }
            //PO Awaiting Tech Director Approval
            if (scmf.code == "TDRV2")
            {
                dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDPURCHASESEARCHTDRV2", ParameterList);
            }
            return PurchaseForm.TranslateAsActionList(dt);
        }

        public static List<ExpiredCrewDocumentList> ExpiredCrewDocumentsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@DUEDAYS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.duedays));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));

            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDEXPIRYDOCUMENTLIST ", ParameterList);

            return ExpiredCrewDocumentList.TranslateAsActionList(dt);
        }

        public static List<CriticalSparePurchaseFormList> CriticalSparePurchasePanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@ISCRITICAL", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.iscritical));
            ParameterList.Add(DataAccess.GetDBParameter("@SHOWROBBELOWMIN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.showrobbelowmin));
            ParameterList.Add(DataAccess.GetDBParameter("@ROB", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.ROB));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));

            dt = DataAccess.ExecSPReturnDataTable("PRSPAREITEMSEARCH", ParameterList);

            return CriticalSparePurchaseFormList.TranslateAsActionList(dt);
        }


        public static List<OpenReportUnclassifiedList> OpenReportUnclassified(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));

            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEDASHBOARDOPENREPORTSEARCH", ParameterList);

            return OpenReportUnclassifiedList.TranslateAsActionList(dt);

        }


        public static List<CrewComplaintsOpenClosedList> CrewComplaintsOpenClosed(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));

            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEDASHBOARDCREWCOMPLAINTSSEARCH", ParameterList);

            return CrewComplaintsOpenClosedList.TranslateAsActionList(dt);

        }


        public static List<DrillList> DrillsList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@TYPE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.type));
            ParameterList.Add(DataAccess.GetDBParameter("@DRILLNAME", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.drillname));


            dt = DataAccess.ExecSPReturnDataTable("PRDRILLVSVESSELSEARCH", ParameterList);

            return DrillList.TranslateAsActionList(dt);

        }


        public static List<MOC> MOCPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>(); 


            if (scmf.status == "PSD" || scmf.status == "EAP" || scmf.status == "PAL" || scmf.status == "APD" || scmf.status == "IMD" || scmf.status == "IMP"  )
            {

                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
                ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
                ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
                ParameterList.Add(DataAccess.GetDBParameter("@OFFICEYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.officeyn));
                ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));

                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEMOCDASHBOARDSEARCH", ParameterList);
            }
            else if (scmf.status == "RES" || scmf.status == "OVD")
            {
                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
                ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
                ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
                ParameterList.Add(DataAccess.GetDBParameter("@OFFICEYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.officeyn));
                ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEMOCREQUESTDASHBOARDSEARCH", ParameterList);
            }

            else if (scmf.status == "ERPA")
            {
                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
                ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
                ParameterList.Add(DataAccess.GetDBParameter("@OFFICEYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.officeyn));
                ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));

                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEMOCEXTENTIONDASHBOARDSEARCH", ParameterList);
            }
            else if(scmf.status == "IVO")
            {
                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
                ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
                ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));

                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEMOCINTERMEDIATEDASHBOARDSEARRCH", ParameterList);
            }
            else
            {
                ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
                ParameterList.Add(DataAccess.GetDBParameter("@OFFICEYN", SqlDbType.SmallInt, DbConstant.SMALLINT, ParameterDirection.Input, scmf.officeyn));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
                ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
                ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
                ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
                ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));

                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEMOCACTIONPLANTASKDASHBOARDEARCH", ParameterList);

            }

            return MOC.TranslateAsActionList(dt);
        }


        public static List<RA> RAPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount)); 
            ParameterList.Add(DataAccess.GetDBParameter("@RATYPE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.RAtype));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBORADNONROUTINERASEARCH", ParameterList);

            return RA.TranslateAsActionList(dt);

        }


        public static List<AccidentAndNearmissIncidentList> AccidentAndNearmissIncidentPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@INCIDENTCLASSIFICATION", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.incidentclassification));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEDASHBOARDINCIDENTSEARCH", ParameterList);

            return AccidentAndNearmissIncidentList.TranslateAsActionList(dt);

        }


        public static List<MachineryDamageIncidentList> MachineryDamageIncidentPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PROFFICEDASHBOARDMACHINARYDAMAGESEARCH", ParameterList);

            return MachineryDamageIncidentList.TranslateAsActionList(dt);

        }



        public static List<unsafeActsOpenCompletedIncidentList> unsafeActsOpenCompletedIncidentPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEDASHBOARDUNSAFEACTSCONDITIONSEARCH", ParameterList);

            return unsafeActsOpenCompletedIncidentList.TranslateAsActionList(dt);

        }



        public static List<CrewChangesAndApprovalCrewList> CrewChangesAndApprovalCrewPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@PNDAPPROVALSTATUS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.PNDStatus));
            ParameterList.Add(DataAccess.GetDBParameter("@DASHBOARDYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.dashboardyn));
            ParameterList.Add(DataAccess.GetDBParameter("@DETAILPENDINGYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.detailpending));



            dt = DataAccess.ExecSPReturnDataTable("PRCREWOFFSHOREPDSEARCH", ParameterList);

            return CrewChangesAndApprovalCrewList.TranslateAsActionList(dt);

        }


        public static List<CrewChangesAndApprovalLast24hrsList> CrewChangesAndApprovalLast24hoursList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();



            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@DASHBOARDYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.dashboardyn));
            ParameterList.Add(DataAccess.GetDBParameter("@RELIEFDUE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.reliefdue));
            ParameterList.Add(DataAccess.GetDBParameter("@FILTERYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.filteryn));
            ParameterList.Add(DataAccess.GetDBParameter("@NOTPLANNED", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.notplanned));
            ParameterList.Add(DataAccess.GetDBParameter("@DEPCHECKPND", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.depcheckpnd));
            ParameterList.Add(DataAccess.GetDBParameter("@CONTRACTNOTATTACHED", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.contractnotattached));
            ParameterList.Add(DataAccess.GetDBParameter("@PENDINDSIGNON", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pendingsignon));
            ParameterList.Add(DataAccess.GetDBParameter("@OFFERLETTERISSUANCE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.offerletterinsurence));
            ParameterList.Add(DataAccess.GetDBParameter("@OFFERLETTERNOTSIGNED", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.offerletternotsigned));
            ParameterList.Add(DataAccess.GetDBParameter("@ISOVERDUE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.isoverdue));

            dt = DataAccess.ExecSPReturnDataTable("PRCERWRELIEFPLANRELIEVEELISTSEARCH", ParameterList);

            return CrewChangesAndApprovalLast24hrsList.TranslateAsActionList(dt);

        }


        public static List<NoonReportTechnicalPanel> NoonReportTechPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();



            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@ISREVIEWSTATUS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.isreviewstatus));


            dt = DataAccess.ExecSPReturnDataTable("PRVPRSNOONREPORTDASHBOARDREVIEWSEARCH", ParameterList);

            return NoonReportTechnicalPanel.TranslateAsActionList(dt);

        }


        public static List<ArrivalReportTechnicalPanel> ArrivalReportTechPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();



            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@ISREVIEWSTATUS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.isreviewstatus));


            dt = DataAccess.ExecSPReturnDataTable("PRVPRSARRIVALREPORTSEARCH", ParameterList);

            return ArrivalReportTechnicalPanel.TranslateAsActionList(dt);

        }


        public static List<DepartureReportTechnicalPanel> DepartureReportTechPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();



            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@ISREVIEWSTATUS", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.isreviewstatus)); 
            ParameterList.Add(DataAccess.GetDBParameter("@SHIFTINGREPORT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.shiftingreport));


            dt = DataAccess.ExecSPReturnDataTable("PRVPRSDEPARTUREREPORTSEARCH", ParameterList);

            return DepartureReportTechnicalPanel.TranslateAsActionList(dt);

        }



        public static List<InsPanelList> InspectionPanelList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();



            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@CODE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.code));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            if (scmf.type == "VIR")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDVIRTASKSEARCH", ParameterList);
            }
            else if(scmf.type == "Shipboard Corrective" || scmf.type == "Office Corrective")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDCORRECTTIVETASKSEARCH", ParameterList);
            }
            else if (scmf.type == "Shipboard Preventive" || scmf.type == "Office Preventive")
            {
                dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDPREVENTIVETASKSEARCH", ParameterList);
            }
            return InsPanelList.TranslateAsActionList(dt);

        }




        public static List<PostpondedRequestListPMSPanel> PostpondedRequestPMSList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSELID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@DASHBOARD", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.dashboard));
            ParameterList.Add(DataAccess.GetDBParameter("@OFFICEDBYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.officebyn));

            dt = DataAccess.ExecSPReturnDataTable("PRWORKORDERJOBPOSTPONEDAPPROVALSEARCH", ParameterList);

            return PostpondedRequestListPMSPanel.TranslateAsActionList(dt);

        }

        public static List<AuditAndInspection60daysAndOverduePanel> AuditAndInspection60daysAndOverdueList(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@EXTERNALYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.externalyn));
            ParameterList.Add(DataAccess.GetDBParameter("@TYPE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.type));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDSHIPAUDITSCHEDULEPLANNERSEARCH", ParameterList);

            return AuditAndInspection60daysAndOverduePanel.TranslateAsActionList(dt);

        }



        public static List<InspectionDashBoardAuditRecordListPanel> InspectionDashBoardAuditRecordListPanels(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@EXTERNALYN", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.externalyn));
            ParameterList.Add(DataAccess.GetDBParameter("@TYPE", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.type));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@QUALITYCOMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONOFFICEDASHBOARDSHIPAUDITINSPECTIONSEARCH", ParameterList);

            return InspectionDashBoardAuditRecordListPanel.TranslateAsActionList(dt);

        }


        public static List<InspectionDashboardSIREPlannerList> InspectionDashboardSIREPlannerPanel(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PRINSPECTIONDASHBOARDVETTINGSCHEDULEPLANNERSEARCH", ParameterList);

            return InspectionDashboardSIREPlannerList.TranslateAsActionList(dt);

        }


        public static List<InspectionDashboardScheduleMasterList> InspectionDashboardScheduleMasterPanel(PanelTech scmf)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@ROWUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.rowusercode));
            ParameterList.Add(DataAccess.GetDBParameter("@VESSEL", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.vesselid));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGENUMBER", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@PAGESIZE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.pagesize));
            ParameterList.Add(DataAccess.GetDBParameter("@RESULTCOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.resultcount));
            ParameterList.Add(DataAccess.GetDBParameter("@TOTALPAGECOUNT", SqlDbType.Int, DbConstant.INT, ParameterDirection.Output, scmf.totalpagecount));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, scmf.status));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, scmf.companyid));


            dt = DataAccess.ExecSPReturnDataTable("PRDASHBOARDINSPECTIONSCHEDULESEARCH", ParameterList);

            return InspectionDashboardScheduleMasterList.TranslateAsActionList(dt);

        }
    }
}

