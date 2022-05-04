using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{



    [DataContract]
    public class PanelTech
    {

        [DataMember(Name = "vesselid")]
        public int vesselid { get; set; }
        [DataMember(Name = "pagenumber")]
        public int pagenumber { get; set; }
        [DataMember(Name = "pagesize")]
        public int pagesize { get; set; }
        [DataMember(Name = "resultcount")]
        public int resultcount { get; set; }
        [DataMember(Name = "totalpagecount")]
        public int totalpagecount { get; set; }
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "code")]
        public string code { get; set; }
        [DataMember(Name = "priority")]
        public string priority { get; set; }
        [DataMember(Name = "dueto")]
        public string dueto { get; set; }
        [DataMember(Name = "iscritical")]
        public string iscritical { get; set; }
        [DataMember(Name = "verifyType")]
        public int verifyType { get; set; }
      
        [DataMember(Name = "JobCategoryId")]
        public int JobCategoryId { get; set; }
        [DataMember(Name = "classcode")]
        public int classcode { get; set; }
        [DataMember(Name = "days")]
        public int days { get; set; }
        [DataMember(Name = "Jobclass")]
        public int Jobclass { get; set; }
        [DataMember(Name = "externalyn")]
        public int externalyn { get; set; }
        [DataMember(Name = "duedays")] 
        public int duedays { get; set; }
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "companyid")]
        public int companyid { get; set; }
        [DataMember(Name = "type")]
        public string type { get; set; }
        [DataMember(Name = "drillname")]
        public string drillname { get; set; }
        [DataMember(Name = "officeyn")]
        public int officeyn { get; set; }
        [DataMember(Name = "RAtype")]
        public int RAtype { get; set; } 
        [DataMember(Name = "incidentclassification")]
        public int incidentclassification { get; set; }
        [DataMember(Name = "PNDStatus")]
        public int PNDStatus { get; set; }
        [DataMember(Name = "dashboardyn")]
        public int dashboardyn { get; set; }
        [DataMember(Name = "detailpending")]
        public int detailpending { get; set; }

        [DataMember(Name = "reliefdue")]
        public int reliefdue { get; set; }
        [DataMember(Name = "filteryn")]
        public int filteryn { get; set; }
        [DataMember(Name = "notplanned")]
        public int notplanned { get; set; }
        [DataMember(Name = "depcheckpnd")]
        public int depcheckpnd { get; set; }
        [DataMember(Name = "contractnotattached")]
        public int contractnotattached { get; set; }
        [DataMember(Name = "pendingsignon")]
        public int pendingsignon { get; set; }
        [DataMember(Name = "offerletterinsurence")]
        public int offerletterinsurence { get; set; }
        [DataMember(Name = "offerletternotsigned")]
        public int offerletternotsigned { get; set; }
        [DataMember(Name = "isoverdue")] 
        public int isoverdue { get; set; }
        [DataMember(Name = "isreviewstatus")]
        public int isreviewstatus { get; set; }
        [DataMember(Name = "shiftingreport")]
        public int shiftingreport { get; set; }
        [DataMember(Name = "showrobbelowmin")]
        public int showrobbelowmin { get; set; }              
        [DataMember(Name = "ROB")] 
        public int ROB { get; set; }
        [DataMember(Name = "overdueyn")]
        public int overdueyn { get; set; }
        [DataMember(Name = "overdue")]
        public int overdue { get; set; }
        [DataMember(Name = "officebyn")]
        public int officebyn { get; set; }
        [DataMember(Name = "dashboard")]
        public string dashboard { get; set; }
        [DataMember(Name = "fromDate")]
        public string fromDate { get; set; }
        [DataMember(Name = "toDate")] 
        public string toDate { get; set; }
        [DataMember(Name = "iskeyactivity")]
        public int iskeyactivity { get; set; }
        [DataMember(Name = "isofficeruser")]
        public int isofficeruser { get; set; }
        [DataMember(Name = "dashboardcode")]
        public string dashboardcode { get; set; }
        //
        [DataMember(Name = "CompNo")]
        public string CompNo { get; set; }
        [DataMember(Name = "CompName")]
        public string CompName { get; set; }
        [DataMember(Name = "title")]
        public string title { get; set; }
        [DataMember(Name = "DefectNo")]
        public string DefectNo { get; set; }
        [DataMember(Name = "DefectDetails")]
        public string DefectDetails { get; set; }
        [DataMember(Name = "Source")]
        public string Source { get; set; }
        [DataMember(Name = "SIRECode")]
        public string SIRECode { get; set; }
        [DataMember(Name = "PSCCode")]
        public string PSCCode { get; set; }
        [DataMember(Name = "DateofIssue")]
        public string DateofIssue { get; set; }
        [DataMember(Name = "DateofIssueTo")]
        public string DateofIssueTo { get; set; }
        [DataMember(Name = "Due")]
        public string Due { get; set; }
        [DataMember(Name = "DueTo")]
        public string DueTo { get; set; }
        [DataMember(Name = "JobNo")]
        public string JobNo { get; set; }
        [DataMember(Name = "WONo")]
        public string WONo { get; set; }
        [DataMember(Name = "RANo")]
        public string RANo { get; set; }
        [DataMember(Name = "ReqnNo")]
        public string ReqnNo { get; set; }
        [DataMember(Name = "StoreReqnNo")]
        public string StoreReqnNo { get; set; }
        [DataMember(Name = "ServiceReqnNo")]
        public string ServiceReqnNo { get; set; }
        [DataMember(Name = "RequestReqnNo")]
        public string RequestReqnNo { get; set; }
        [DataMember(Name = "Responsibility")]
        public string Responsibility { get; set; }
        [DataMember(Name = "statusid")]
        public string statusid { get; set; }
        [DataMember(Name = "SignificantType")]
        public string SignificantType { get; set; }
        [DataMember(Name = "DDJob")]
        public string DDJob { get; set; }
        [DataMember(Name = "CompletionDate")]
        public string CompletionDate { get; set; }
        [DataMember(Name = "CompletionDateTo")]
        public string CompletionDateTo { get; set; }
        [DataMember(Name = "Dispensation")]
        public string Dispensation { get; set; }
        [DataMember(Name = "RARequired")]
        public string RARequired { get; set; }
        [DataMember(Name = "SpareAvailable")]
        public string SpareAvailable { get; set; }
        [DataMember(Name = "StoreAvailable")]
        public string StoreAvailable { get; set; }
        [DataMember(Name = "MachineryFailure")]
        public string MachineryFailure { get; set; }
        [DataMember(Name = "AssistantRequired")]
        public string AssistantRequired { get; set; }
        [DataMember(Name = "MachineryFailureNo")]
        public string MachineryFailureNo { get; set; }
        [DataMember(Name = "ReviewRejected")]
        public string ReviewRejected { get; set; }
        [DataMember(Name = "IsNewOfficeComment")]
        public string IsNewOfficeComment { get; set; }
        [DataMember(Name = "IsNewVesselComment")]
        public string IsNewVesselComment { get; set; }

    }


    [DataContract]
    public class QuartelyReport
    {
  
            [DataMember(Name = "FLDDATE")]
            public string FLDDATE { get; set; }
            [DataMember(Name = "FLDBALLASTAVGSPEED")]
            public string FLDBALLASTAVGSPEED { get; set; }
            [DataMember(Name = "FLDLOADEDAVGSPEED")]
            public string FLDLOADEDAVGSPEED { get; set; }
            [DataMember(Name = "FLDBALLASTAVGRPM")]
            public string FLDBALLASTAVGRPM { get; set; }
            [DataMember(Name = "FLDLOADEDAVGRPM")]
            public string FLDLOADEDAVGRPM { get; set; }


            public static QuartelyReport TranslateAsAction(DataRow dr)
            {
                var item = new QuartelyReport();

                item.FLDDATE = General.GetNullableString(dr["FLDREPORTMONTHANDYEAR"].ToString());
                item.FLDBALLASTAVGSPEED = General.GetNullableString(dr["FLDBALLASTAVGSPEED"].ToString());
                item.FLDLOADEDAVGSPEED = General.GetNullableString(dr["FLDLOADEDAVGSPEED"].ToString());
                item.FLDBALLASTAVGRPM = General.GetNullableString(dr["FLDBALLASTAVGRPM"].ToString());
                item.FLDLOADEDAVGRPM = General.GetNullableString(dr["FLDLOADEDAVGRPM"].ToString());

                return item;
            }

            public static List<QuartelyReport> TranslateAsActionList(DataTable dt)
            {
                var list = new List<QuartelyReport>();
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(TranslateAsAction(dr));
                }
                return list;
            }
        }



    [DataContract]
    public class MonthlyReport
    {

        [DataMember(Name = "FLDREPORTMONTHANDYEAR")]
        public string FLDREPORTMONTHANDYEAR { get; set; }
        [DataMember(Name = "FLDTOTALSTEAMINGTIME")]
        public string FLDTOTALSTEAMINGTIME { get; set; }
        [DataMember(Name = "FLDTOTALMANOEVERINGTIME")]
        public string FLDTOTALMANOEVERINGTIME { get; set; }
        [DataMember(Name = "FLDTOTALAVGBHP")]
        public string FLDTOTALAVGBHP { get; set; }
        [DataMember(Name = "FLDTOTALDEVIATIONORDELAY")]
        public string FLDTOTALDEVIATIONORDELAY { get; set; }
        [DataMember(Name = "FLDTOTALMESTOPPAGE")]
        public string FLDTOTALMESTOPPAGE { get; set; }
        [DataMember(Name = "FLDTOTALAVGSPEED")]
        public string FLDTOTALAVGSPEED { get; set; }
        [DataMember(Name = "FLDTOTALAVGFOCONSUMPTIONPERDAY")]
        public string FLDTOTALAVGFOCONSUMPTIONPERDAY { get; set; }


        public static MonthlyReport TranslateAsAction(DataRow dr)
        {
            var item = new MonthlyReport();


            item.FLDREPORTMONTHANDYEAR = General.GetNullableString(dr["FLDREPORTMONTHANDYEAR"].ToString());
            item.FLDTOTALSTEAMINGTIME = General.GetNullableString(dr["FLDTOTALSTEAMINGTIME"].ToString());
            item.FLDTOTALMANOEVERINGTIME = General.GetNullableString(dr["FLDTOTALMANOEVERINGTIME"].ToString());
            item.FLDTOTALAVGBHP = General.GetNullableString(dr["FLDTOTALAVGBHP"].ToString());
            item.FLDTOTALDEVIATIONORDELAY = General.GetNullableString(dr["FLDTOTALDEVIATIONORDELAY"].ToString());
            item.FLDTOTALMESTOPPAGE = General.GetNullableString(dr["FLDTOTALMESTOPPAGE"].ToString());
            item.FLDTOTALAVGSPEED = General.GetNullableString(dr["FLDTOTALAVGSPEED"].ToString());
            item.FLDTOTALAVGFOCONSUMPTIONPERDAY = General.GetNullableString(dr["FLDTOTALAVGFOCONSUMPTIONPERDAY"].ToString());


            return item;
        }

        public static List<MonthlyReport> TranslateAsActionList(DataTable dt)
        {
            var list = new List<MonthlyReport>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    [DataContract]
    public class NoonReport
    {
        [DataMember(Name = "date")]
        public string date { get; set; }
        [DataMember(Name = "VoyageNo")]
        public string VoyageNo { get; set; }
        [DataMember(Name = "BL")]
        public string BL { get; set; }
        [DataMember(Name = "WindForce")]
        public string WindForce { get; set; }
        [DataMember(Name = "AtNextPort")]
        public string AtNextPort { get; set; }
        [DataMember(Name = "ETA")]
        public string ETA { get; set; }
        [DataMember(Name = "MERPM")]
        public string MERPM { get; set; }
        [DataMember(Name = "Slip")]
        public string Slip { get; set; }
        [DataMember(Name = "Speed")]
        public string Speed { get; set; }
        [DataMember(Name = "CPSpeed")]
        public string CPSpeed { get; set; }
        [DataMember(Name = "FOCons")]
        public string FOCons { get; set; }
        [DataMember(Name = "MEFOCons")]
        public string MEFOCons { get; set; }
        [DataMember(Name = "MEFOCP")]
        public string MEFOCP { get; set; }
        [DataMember(Name = "MEDOCons")]
        public string MEDOCons { get; set; }
        [DataMember(Name = "DOCP")]
        public string DOCP { get; set; }
        [DataMember(Name = "FOCatFines")]
        public string FOCatFines { get; set; }
        [DataMember(Name = "OilMajorCargo")]
        public string OilMajorCargo { get; set; }
        [DataMember(Name = "OilMajor")]
        public string OilMajor { get; set; }
        [DataMember(Name = "Overdue")]
        public string Overdue { get; set; }
        [DataMember(Name = "ReviewedBy")]
        public string ReviewedBy { get; set; }
        [DataMember(Name = "ReviewedDate")]
        public string ReviewedDate { get; set; }

        public static NoonReport TranslateAsAction(DataRow dr)
        {
            var item = new NoonReport(); 

            item.date = General.GetDateTimeToString(dr["FLDNOONREPORTDATE"].ToString());
            item.VoyageNo = General.GetNullableString(dr["FLDVOYAGENO"].ToString());
            item.BL = General.GetNullableString(dr["FLDBALLASTYESNO"].ToString());
            item.WindForce = General.GetNullableString(dr["FLDWINDFORCE"].ToString());
            item.AtNextPort = General.GetNullableString(dr["FLDATPORTNEXTPORT"].ToString());
            item.ETA = General.GetNullableString(dr["FLDETA"].ToString());
            item.MERPM = General.GetNullableString(dr["FLDMERPM"].ToString());
            item.Slip = General.GetNullableString(dr["FLDSLIP"].ToString());
            item.Speed = General.GetNullableString(dr["FLDLOGSPEED"].ToString());
            item.CPSpeed = General.GetNullableString(dr["FLDCHARTERSPEED"].ToString());
            item.FOCons = General.GetNullableString(dr["FLDHFOOILCONSUMPTIONQTY"].ToString());
            item.MEFOCons = General.GetNullableString(dr["FLDMEFOOILCONSUMPTIONQTY"].ToString());
            item.MEDOCons = General.GetNullableString(dr["FLDMDOOILCONSUMPTIONQTY"].ToString());
            item.DOCP = General.GetNullableString(dr["FLDMDOCHARTERCOUNSUMPTION"].ToString());
            item.FOCatFines = General.GetNullableString(dr["FLDFOCATFINES"].ToString());
            item.OilMajorCargo = General.GetNullableString(dr["FLDOILMAJORCARGOONBOARDYN"].ToString());
            item.OilMajor = General.GetNullableString(dr["FLDOILMAJOR"].ToString());
            item.Overdue = General.GetNullableString(dr["FLDOVERDUE"].ToString());
            item.ReviewedBy = General.GetNullableString(dr["FLDREVIEWEDBY"].ToString());
            item.ReviewedDate = General.GetDateTimeToString(dr["FLDREVIEWDDATE"].ToString());

            return item;
        }

        public static List<NoonReport> TranslateAsActionList(DataTable dt)
        {
            var list = new List<NoonReport>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }








    [DataContract]
    public class OverdueJobs
    {
        [DataMember(Name = "FLDISCRITICAL")]
        public string FLDISCRITICAL { get; set; }
        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDCOMPONENTNUMBER")]
        public string FLDCOMPONENTNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDLASTDONEDATE")]
        public string FLDLASTDONEDATE { get; set; }

        [DataMember(Name = "FLDWORKORDERSTATUS")]
        public string FLDWORKORDERSTATUS { get; set; }
        [DataMember(Name = "FLDDEFECT")]
        public string FLDDEFECT { get; set; }
        [DataMember(Name = "FLDPLANINGPRIORITY")]
        public string FLDPLANINGPRIORITY { get; set; }
        [DataMember(Name = "FLDWORKORDERGROUPNO")]
        public string FLDWORKORDERGROUPNO { get; set; }
        [DataMember(Name = "FLDFREQUENCYNAME")]
        public string FLDFREQUENCYNAME { get; set; }


        public static OverdueJobs TranslateAsAction(DataRow dr)
        {
            var item = new OverdueJobs(); 

            item.FLDISCRITICAL = General.GetNullableString(dr["FLDISCRITICAL"].ToString());
            item.FLDCOMPONENTNAME = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDCOMPONENTNUMBER = General.GetNullableString(dr["FLDCOMPONENTNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDDISCIPLINENAME = General.GetNullableString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDDUEDATE = General.GetDateTimeToString(dr["FLDDUEDATE"].ToString());
            item.FLDLASTDONEDATE = General.GetDateTimeToString(dr["FLDLASTDONEDATE"].ToString());
            item.FLDWORKORDERSTATUS = General.GetNullableString(dr["FLDWORKORDERSTATUS"].ToString());
            item.FLDDEFECT = General.GetNullableString(dr["FLDDEFECT"].ToString());
            item.FLDPLANINGPRIORITY = General.GetNullableString(dr["FLDPLANINGPRIORITY"].ToString());
            item.FLDWORKORDERGROUPNO = General.GetNullableString(dr["FLDWORKORDERGROUPNO"].ToString());
            item.FLDFREQUENCYNAME = General.GetNullableString(dr["FLDFREQUENCYNAME"].ToString());




            return item;
        }

        public static List<OverdueJobs> TranslateAsActionList(DataTable dt)
        {
            var list = new List<OverdueJobs>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }




    [DataContract]

    





    public class OverdueWorkOrder
    {
        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }
        [DataMember(Name = "FLDDURATION")]
        public string FLDDURATION { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }
        


        public static OverdueWorkOrder TranslateAsAction(DataRow dr)
        {
            var item = new OverdueWorkOrder();

            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetDateTimeToString(dr["FLDPLANNINGDUEDATE"].ToString());
            item.FLDDURATION = General.GetNullableString(dr["FLDDURATION"].ToString());
            item.FLDDISCIPLINENAME = General.GetNullableString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());
       

            return item;
        }

        public static List<OverdueWorkOrder> TranslateAsActionList(DataTable dt)
        {
            var list = new List<OverdueWorkOrder>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }




    public class CriticalOverdueJobs
    {
        [DataMember(Name = "FLDISCRITICAL")]
        public string FLDISCRITICAL { get; set; }
        [DataMember(Name = "FLDCOMPONENTNUMBER")]
        public string FLDCOMPONENTNUMBER { get; set; }
        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDFREQUENCYNAME")]
        public string FLDFREQUENCYNAME { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDLASTDONEDATE")]
        public string FLDLASTDONEDATE { get; set; }
        [DataMember(Name = "FLDWORKORDERSTATUS")]
        public string FLDWORKORDERSTATUS { get; set; }
        [DataMember(Name = "FLDDEFECT")]
        public string FLDDEFECT { get; set; }
        [DataMember(Name = "FLDPLANINGPRIORITY")]
        public string FLDPLANINGPRIORITY { get; set; }
        [DataMember(Name = "FLDWORKORDERGROUPNO")]
        public string FLDWORKORDERGROUPNO { get; set; }


        public static CriticalOverdueJobs TranslateAsAction(DataRow dr)
        {
            var item = new CriticalOverdueJobs();

            item.FLDISCRITICAL = General.GetNullableString(dr["FLDISCRITICAL"].ToString());
            item.FLDCOMPONENTNUMBER = General.GetNullableString(dr["FLDCOMPONENTNUMBER"].ToString());
            item.FLDCOMPONENTNAME = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDFREQUENCYNAME = General.GetNullableString(dr["FLDFREQUENCYNAME"].ToString());
            item.FLDDISCIPLINENAME = General.GetNullableString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDDUEDATE = General.GetDateTimeToString(dr["FLDDUEDATE"].ToString());
            item.FLDLASTDONEDATE = General.GetDateTimeToString(dr["FLDLASTDONEDATE"].ToString());
            item.FLDWORKORDERSTATUS = General.GetNullableString(dr["FLDWORKORDERSTATUS"].ToString());
            item.FLDDEFECT = General.GetNullableString(dr["FLDDEFECT"].ToString());
            item.FLDPLANINGPRIORITY = General.GetNullableString(dr["FLDPLANINGPRIORITY"].ToString());
            item.FLDWORKORDERGROUPNO = General.GetNullableString(dr["FLDWORKORDERGROUPNO"].ToString());


            return item;
        }

        public static List<CriticalOverdueJobs> TranslateAsActionList(DataTable dt)
        {
            var list = new List<CriticalOverdueJobs>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class MajorOverhauls
    {
       
        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }
        [DataMember(Name = "FLDDURATION")]
        public string FLDDURATION { get; set; }
        [DataMember(Name = "FLDSTATUSCODE")]
        public string FLDSTATUSCODE { get; set; }



        public static MajorOverhauls TranslateAsAction(DataRow dr)
        {
            var item = new MajorOverhauls();

        
            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetDateTimeToString(dr["FLDPLANNINGDUEDATE"].ToString());
            item.FLDDURATION = General.GetNullableString(dr["FLDDURATION"].ToString());
            item.FLDDISCIPLINENAME = General.GetDateTimeToString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDSTATUSCODE = General.GetDateTimeToString(dr["FLDSTATUSCODE"].ToString());



            return item;
        }

        public static List<MajorOverhauls> TranslateAsActionList(DataTable dt)
        {
            var list = new List<MajorOverhauls>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }





    public class Cat2MajorOverhauls
    {

        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }
        [DataMember(Name = "FLDDURATION")]
        public string FLDDURATION { get; set; }
        [DataMember(Name = "FLDSTATUSCODE")]
        public string FLDSTATUSCODE { get; set; }



        public static Cat2MajorOverhauls TranslateAsAction(DataRow dr)
        {
            var item = new Cat2MajorOverhauls();


            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetDateTimeToString(dr["FLDPLANNINGDUEDATE"].ToString());
            item.FLDDURATION = General.GetNullableString(dr["FLDDURATION"].ToString());
            item.FLDDISCIPLINENAME = General.GetDateTimeToString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDSTATUSCODE = General.GetDateTimeToString(dr["FLDSTATUSCODE"].ToString());



            return item;
        }

        public static List<Cat2MajorOverhauls> TranslateAsActionList(DataTable dt)
        {
            var list = new List<Cat2MajorOverhauls>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class WOverified
    {

        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDJOBNO")]
        public string FLDJOBNO { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDVESSELVERIFICATIONRANK")]
        public string FLDVESSELVERIFICATIONRANK { get; set; }
        [DataMember(Name = "FLDVESSELVERIFICATION")]
        public string FLDVESSELVERIFICATION { get; set; }
        [DataMember(Name = "FLDVESSELVERIFYREMARKS")]
        public string FLDVESSELVERIFYREMARKS { get; set; }
        [DataMember(Name = "FLDOFFICEVERIFICATION")]
        public string FLDOFFICEVERIFICATION { get; set; }
        [DataMember(Name = "FLDOFFICEVERIFYREMARKS")]
        public string FLDOFFICEVERIFYREMARKS { get; set; }

        public static WOverified TranslateAsAction(DataRow dr)
        {
            var item = new WOverified();


            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDJOBNO = General.GetNullableString(dr["FLDJOBNO"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetNullableString(dr["FLDPLANNINGDUEDATE"].ToString());
            item.FLDDISCIPLINENAME = General.GetDateTimeToString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDVESSELVERIFICATIONRANK = General.GetNullableString(dr["FLDVESSELVERIFICATIONRANK"].ToString());
            item.FLDVESSELVERIFICATION = General.GetDateTimeToString(dr["FLDVESSELVERIFICATION"].ToString());
            item.FLDVESSELVERIFYREMARKS = General.GetDateTimeToString(dr["FLDVESSELVERIFYREMARKS"].ToString());
            item.FLDOFFICEVERIFICATION = General.GetDateTimeToString(dr["FLDOFFICEVERIFICATION"].ToString());
            item.FLDOFFICEVERIFYREMARKS = General.GetDateTimeToString(dr["FLDOFFICEVERIFYREMARKS"].ToString());

            return item;
        }

        public static List<WOverified> TranslateAsActionList(DataTable dt)
        {
            var list = new List<WOverified>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }




    public class PostpondedJobs
    {

        [DataMember(Name = "FLDCOMPONENTNUMBER")]
        public string FLDCOMPONENTNUMBER { get; set; }

        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDFREQUENCYTYPE")]
        public string FLDFREQUENCYTYPE { get; set; }
        [DataMember(Name = "FLDFREQUENCYNAME")]
        public string FLDFREQUENCYNAME { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDLASTDONEDATE")]
        public string FLDLASTDONEDATE { get; set; }
        [DataMember(Name = "FLDWORKORDERGROUPNO")]
        public string FLDWORKORDERGROUPNO { get; set; }
     

        public static PostpondedJobs TranslateAsAction(DataRow dr)
        {
            var item = new PostpondedJobs();


            item.FLDCOMPONENTNUMBER = General.GetNullableString(dr["FLDCOMPONENTNUMBER"].ToString());
            item.FLDCOMPONENTNAME = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDDISCIPLINENAME = General.GetDateTimeToString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDFREQUENCYTYPE = General.GetNullableString(dr["FLDFREQUENCYTYPE"].ToString());
            item.FLDFREQUENCYNAME = General.GetDateTimeToString(dr["FLDFREQUENCYNAME"].ToString());
            item.FLDFREQUENCYNAME = General.GetDateTimeToString(dr["FLDFREQUENCYNAME"].ToString());

            item.FLDDUEDATE = General.GetDateTimeToString(dr["FLDDUEDATE"].ToString());
            item.FLDLASTDONEDATE = General.GetDateTimeToString(dr["FLDLASTDONEDATE"].ToString());
            item.FLDWORKORDERGROUPNO = General.GetDateTimeToString(dr["FLDWORKORDERGROUPNO"].ToString());

            return item;
        }

        public static List<PostpondedJobs> TranslateAsActionList(DataTable dt)
        {
            var list = new List<PostpondedJobs>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class Cat1MajorOverHaulDue60Days
    {

        [DataMember(Name = "FLDCOMPONENTNUMBER")]
        public string FLDCOMPONENTNUMBER { get; set; }

        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDFREQUENCYTYPE")]
        public string FLDFREQUENCYTYPE { get; set; }
        [DataMember(Name = "FLDFREQUENCYNAME")]
        public string FLDFREQUENCYNAME { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDLASTDONEDATE")]
        public string FLDLASTDONEDATE { get; set; }
        [DataMember(Name = "FLDWORKORDERGROUPNO")]
        public string FLDWORKORDERGROUPNO { get; set; }
        [DataMember(Name = "FLDISCRITICAL")]
        public string FLDISCRITICAL { get; set; }
        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERSTATUS")]
        public string FLDWORKORDERSTATUS { get; set; }
        [DataMember(Name = "FLDDEFECT")]
        public string FLDDEFECT { get; set; }
        [DataMember(Name = "FLDPLANINGPRIORITY")]
        public string FLDPLANINGPRIORITY { get; set; }


        public static Cat1MajorOverHaulDue60Days TranslateAsAction(DataRow dr)
        {
            var item = new Cat1MajorOverHaulDue60Days();


            item.FLDISCRITICAL        = General.GetNullableString(dr["FLDISCRITICAL"].ToString());
            item.FLDCOMPONENTNUMBER   = General.GetNullableString(dr["FLDCOMPONENTNUMBER"].ToString());
            item.FLDCOMPONENTNAME     = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDWORKORDERNUMBER   = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME     = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY       = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDFREQUENCYTYPE     = General.GetNullableString(dr["FLDFREQUENCYTYPE"].ToString());
            item.FLDFREQUENCYNAME     = General.GetNullableString(dr["FLDFREQUENCYNAME"].ToString());
            item.FLDDISCIPLINENAME    = General.GetNullableString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDLASTDONEDATE      = General.GetNullableString(dr["FLDLASTDONEDATE"].ToString());
            item.FLDDUEDATE           = General.GetNullableString(dr["FLDDUEDATE"].ToString());
            item.FLDWORKORDERSTATUS   = General.GetNullableString(dr["FLDWORKORDERSTATUS"].ToString());
            item.FLDDEFECT            = General.GetNullableString(dr["FLDDEFECT"].ToString());
            item.FLDPLANINGPRIORITY   = General.GetNullableString(dr["FLDPLANINGPRIORITY"].ToString()); 
            item.FLDWORKORDERGROUPNO  = General.GetNullableString(dr["FLDWORKORDERGROUPNO"].ToString());
            return item; 
        }

        public static List<Cat1MajorOverHaulDue60Days> TranslateAsActionList(DataTable dt)
        {
            var list = new List<Cat1MajorOverHaulDue60Days>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }




    public class Cat2MajorOverHaulDue60Days
    {

        [DataMember(Name = "FLDCOMPONENTNUMBER")]
        public string FLDCOMPONENTNUMBER { get; set; }

        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDJOBCATEGORY")]
        public string FLDJOBCATEGORY { get; set; }
        [DataMember(Name = "FLDFREQUENCYTYPE")]
        public string FLDFREQUENCYTYPE { get; set; }
        [DataMember(Name = "FLDFREQUENCYNAME")]
        public string FLDFREQUENCYNAME { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDLASTDONEDATE")]
        public string FLDLASTDONEDATE { get; set; }
        [DataMember(Name = "FLDWORKORDERGROUPNO")]
        public string FLDWORKORDERGROUPNO { get; set; }
        [DataMember(Name = "FLDISCRITICAL")]
        public string FLDISCRITICAL { get; set; }
        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERSTATUS")]
        public string FLDWORKORDERSTATUS { get; set; }
        [DataMember(Name = "FLDDEFECT")]
        public string FLDDEFECT { get; set; }
        [DataMember(Name = "FLDPLANINGPRIORITY")]
        public string FLDPLANINGPRIORITY { get; set; }


        public static Cat2MajorOverHaulDue60Days TranslateAsAction(DataRow dr)
        {
            var item = new Cat2MajorOverHaulDue60Days();


            item.FLDISCRITICAL = General.GetNullableString(dr["FLDISCRITICAL"].ToString());
            item.FLDCOMPONENTNUMBER = General.GetNullableString(dr["FLDCOMPONENTNUMBER"].ToString());
            item.FLDCOMPONENTNAME = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDJOBCATEGORY = General.GetNullableString(dr["FLDJOBCATEGORY"].ToString());
            item.FLDFREQUENCYTYPE = General.GetNullableString(dr["FLDFREQUENCYTYPE"].ToString());
            item.FLDFREQUENCYNAME = General.GetNullableString(dr["FLDFREQUENCYNAME"].ToString());
            item.FLDDISCIPLINENAME = General.GetNullableString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDLASTDONEDATE = General.GetNullableString(dr["FLDLASTDONEDATE"].ToString());
            item.FLDDUEDATE = General.GetNullableString(dr["FLDDUEDATE"].ToString());
            item.FLDWORKORDERSTATUS = General.GetNullableString(dr["FLDWORKORDERSTATUS"].ToString());
            item.FLDDEFECT = General.GetNullableString(dr["FLDDEFECT"].ToString());
            item.FLDPLANINGPRIORITY = General.GetNullableString(dr["FLDPLANINGPRIORITY"].ToString());
            item.FLDWORKORDERGROUPNO = General.GetNullableString(dr["FLDWORKORDERGROUPNO"].ToString());
            return item;
        }

        public static List<Cat2MajorOverHaulDue60Days> TranslateAsActionList(DataTable dt)
        {
            var list = new List<Cat2MajorOverHaulDue60Days>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }

    public class PurchaseForm
    {
        [DataMember(Name = "FLDVESSELNAME")]
        public string FLDVESSELNAME { get; set; }
        [DataMember(Name = "FLDFORMNO")]
        public string FLDFORMNO { get; set; }
        [DataMember(Name = "FLDTITLE")]
        public string FLDTITLE { get; set; }
        [DataMember(Name = "FLDVENDORNAME")]
        public string FLDVENDORNAME { get; set; }
        [DataMember(Name = "FLDFORMTYPENAME")]
        public string FLDFORMTYPENAME { get; set; }
        [DataMember(Name = "FLDFORMSTATUSNAME")]
        public string FLDFORMSTATUSNAME { get; set; }

        [DataMember(Name = "FLDSUBACCOUNT")]
        public string FLDSUBACCOUNT { get; set; }
        [DataMember(Name = "FLDPURCHASEAPPROVEDATE")]
        public string FLDPURCHASEAPPROVEDATE { get; set; }
        [DataMember(Name = "FLDORDEREDDATE")]
        public string FLDORDEREDDATE { get; set; }
        [DataMember(Name = "FLDVENDORDELIVERYDATE")]
        public string FLDVENDORDELIVERYDATE { get; set; }
        [DataMember(Name = "FLDCOMMITTEDUSD")]
        public string FLDCOMMITTEDUSD { get; set; }
        [DataMember(Name = "FLDSTOCKTYPE")]
        public string FLDSTOCKTYPE { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }
        [DataMember(Name = "FLDREASONFORREQUISITIONNAME")]
        public string FLDREASONFORREQUISITIONNAME { get; set; }
        [DataMember(Name = "FLDORDERREADINESSDATE")]
        public string FLDORDERREADINESSDATE { get; set; }
        [DataMember(Name = "FLDSOURCENUMBER")]
        public string FLDSOURCENUMBER { get; set; }


        public static PurchaseForm TranslateAsAction(DataRow dr)
        {
            var item = new PurchaseForm(); 



            item.FLDVESSELNAME = General.GetNullableString(dr["FLDVESSELNAME"].ToString());
            item.FLDFORMNO = General.GetNullableString(dr["FLDFORMNO"].ToString());
            item.FLDTITLE = General.GetNullableString(dr["FLDTITLE"].ToString());
            item.FLDVENDORNAME = General.GetNullableString(dr["FLDVENDORNAME"].ToString());
            item.FLDFORMSTATUSNAME = General.GetNullableString(dr["FLDFORMSTATUSNAME"].ToString());
            item.FLDSUBACCOUNT = General.GetNullableString(dr["FLDSUBACCOUNT"].ToString());
            item.FLDPURCHASEAPPROVEDATE = General.GetNullableString(dr["FLDPURCHASEAPPROVEDATE"].ToString());
            item.FLDORDEREDDATE = General.GetNullableString(dr["FLDORDEREDDATE"].ToString());
            item.FLDVENDORDELIVERYDATE = General.GetNullableString(dr["FLDVENDORDELIVERYDATE"].ToString());
            item.FLDCOMMITTEDUSD = General.GetNullableString(dr["FLDCOMMITTEDUSD"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());
            item.FLDSTOCKTYPE = General.GetNullableString(dr["FLDSTOCKTYPE"].ToString());
            item.FLDFORMTYPENAME = General.GetNullableString(dr["FLDFORMTYPENAME"].ToString());
            item.FLDREASONFORREQUISITIONNAME = General.GetNullableString(dr["FLDREASONFORREQUISITIONNAME"].ToString());
            item.FLDORDERREADINESSDATE = General.GetNullableString(dr["FLDORDERREADINESSDATE"].ToString());
            item.FLDVESSELNAME = General.GetNullableString(dr["FLDSOURCENUMBER"].ToString());


            return item;
        }

        public static List<PurchaseForm> TranslateAsActionList(DataTable dt)
        {
            var list = new List<PurchaseForm>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }




    public class ExpiredCrewDocumentList
    {
      
        [DataMember(Name = "FLDDOCUMENTNAME")]
        public string FLDDOCUMENTNAME { get; set; }
        [DataMember(Name = "FLDDOCUMENTTYPE")]
        public string FLDDOCUMENTTYPE { get; set; }
        [DataMember(Name = "FLDEXPIRYDATE")]
        public string FLDEXPIRYDATE { get; set; }
        [DataMember(Name = "FLDGROUPBY")]
        public string FLDGROUPBY { get; set; }

        public static ExpiredCrewDocumentList TranslateAsAction(DataRow dr)
        {
            var item = new ExpiredCrewDocumentList();

            item.FLDDOCUMENTNAME = General.GetNullableString(dr["FLDDOCUMENTNAME"].ToString());
            item.FLDDOCUMENTTYPE = General.GetNullableString(dr["FLDDOCUMENTTYPE"].ToString());
            item.FLDEXPIRYDATE = General.GetDateTimeToString(dr["FLDEXPIRYDATE"].ToString());
            item.FLDGROUPBY = General.GetNullableString(dr["FLDGROUPBY"].ToString());

            return item;
        }

        public static List<ExpiredCrewDocumentList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<ExpiredCrewDocumentList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class CriticalSparePurchaseFormList
    {

        [DataMember(Name = "FLDNUMBER")]
        public string FLDNUMBER { get; set; }
        [DataMember(Name = "FLDNAME")]
        public string FLDNAME { get; set; }
        [DataMember(Name = "FLDMAKER")]
        public string FLDMAKER { get; set; }
        [DataMember(Name = "FLDPREFERREDVENDOR")]
        public string FLDPREFERREDVENDOR { get; set; }
        [DataMember(Name = "FLDWANTED")]
        public string FLDWANTED { get; set; }
        [DataMember(Name = "FLDMAKERREFERENCE")]
        public string FLDMAKERREFERENCE { get; set; }
        [DataMember(Name = "FLDMAKERREFERENCEFULLDETAILS")]
        public string FLDMAKERREFERENCEFULLDETAILS { get; set; }
        [DataMember(Name = "FLDROB")]
        public string FLDROB { get; set; }


        public static CriticalSparePurchaseFormList TranslateAsAction(DataRow dr)
        {
            var item = new CriticalSparePurchaseFormList();

            item.FLDNUMBER = General.GetNullableString(dr["FLDNUMBER"].ToString());
            item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
            item.FLDMAKER = General.GetDateTimeToString(dr["FLDMAKER"].ToString());
            item.FLDROB = General.GetNullableString(dr["FLDROB"].ToString());
            item.FLDPREFERREDVENDOR = General.GetNullableString(dr["FLDPREFERREDVENDOR"].ToString());
            item.FLDWANTED = General.GetNullableString(dr["FLDWANTED"].ToString());
            item.FLDMAKERREFERENCE = General.GetNullableString(dr["FLDMAKERREFERENCE"].ToString());
            item.FLDMAKERREFERENCEFULLDETAILS = General.GetNullableString(dr["FLDMAKERREFERENCEFULLDETAILS"].ToString());

            return item;
        }

        public static List<CriticalSparePurchaseFormList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<CriticalSparePurchaseFormList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class OpenReportUnclassifiedList
    {

        [DataMember(Name = "FLDSUMMARY")]
        public string FLDSUMMARY { get; set; }
        [DataMember(Name = "FLDREPORTEDDATE")]
        public string FLDREPORTEDDATE { get; set; }
        [DataMember(Name = "FLDREVIEWCATEGORYNAME")]
        public string FLDREVIEWCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDREMARKS")]
        public string FLDREMARKS { get; set; }
        [DataMember(Name = "FLDOPENREPORTREFNO")]
        public string FLDOPENREPORTREFNO { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDASSIGNEDTO")]
        public string FLDASSIGNEDTO { get; set; }
        [DataMember(Name = "FLDEVIDENCEREQUIRED")]
        public string FLDEVIDENCEREQUIRED { get; set; }


        public static OpenReportUnclassifiedList TranslateAsAction(DataRow dr)
        {
            var item = new OpenReportUnclassifiedList();

            item.FLDSUMMARY = General.GetNullableString(dr["FLDSUMMARY"].ToString());
            item.FLDREPORTEDDATE = General.GetNullableString(dr["FLDREPORTEDDATE"].ToString());
            item.FLDREVIEWCATEGORYNAME = General.GetNullableString(dr["FLDREVIEWCATEGORYNAME"].ToString());
            item.FLDREMARKS = General.GetNullableString(dr["FLDREMARKS"].ToString());
            item.FLDOPENREPORTREFNO = General.GetNullableString(dr["FLDOPENREPORTREFNO"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());
            item.FLDDUEDATE = General.GetNullableString(dr["FLDDUEDATE"].ToString());
            item.FLDASSIGNEDTO = General.GetNullableString(dr["FLDASSIGNEDTO"].ToString());
            item.FLDEVIDENCEREQUIRED = General.GetNullableString(dr["FLDEVIDENCEREQUIRED"].ToString());


            return item;
        }

        public static List<OpenReportUnclassifiedList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<OpenReportUnclassifiedList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class CrewComplaintsOpenClosedList
    {

        [DataMember(Name = "FLDOPENREPORTREFNO")]
        public string FLDOPENREPORTREFNO { get; set; }
        [DataMember(Name = "FLDSUMMARY")]
        public string FLDSUMMARY { get; set; }
        [DataMember(Name = "FLDREPORTEDDATE")]
        public string FLDREPORTEDDATE { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }
        [DataMember(Name = "FLDREVIEWCATEGORYNAME")]
        public string FLDREVIEWCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDREMARKS")]
        public string FLDREMARKS { get; set; }
        [DataMember(Name = "FLDEVIDENCEREQUIREDYN")]
        public string FLDEVIDENCEREQUIREDYN { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }


        public static CrewComplaintsOpenClosedList TranslateAsAction(DataRow dr)
        {
            var item = new CrewComplaintsOpenClosedList();

            item.FLDOPENREPORTREFNO = General.GetNullableString(dr["FLDOPENREPORTREFNO"].ToString());
            item.FLDSUMMARY = General.GetNullableString(dr["FLDSUMMARY"].ToString());
            item.FLDREPORTEDDATE = General.GetNullableString(dr["FLDREPORTEDDATE"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());
            item.FLDREVIEWCATEGORYNAME = General.GetNullableString(dr["FLDREVIEWCATEGORYNAME"].ToString());
            item.FLDREMARKS = General.GetNullableString(dr["FLDREMARKS"].ToString());
            item.FLDEVIDENCEREQUIREDYN = General.GetNullableString(dr["FLDEVIDENCEREQUIREDYN"].ToString());
            item.FLDDUEDATE = General.GetNullableString(dr["FLDDUEDATE"].ToString());


            return item;
        }

        public static List<CrewComplaintsOpenClosedList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<CrewComplaintsOpenClosedList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class DrillList
    {

        [DataMember(Name = "FLDDRILLID")]
        public string FLDDRILLID { get; set; }
        [DataMember(Name = "FLDDRILLDUEDATE")]
        public string FLDDRILLDUEDATE { get; set; }
        [DataMember(Name = "FLDDRILLNAME")]
        public string FLDDRILLNAME { get; set; }
        [DataMember(Name = "DUEIN")]
        public string DUEIN { get; set; }
        [DataMember(Name = "FLDTYPE")]
        public string FLDTYPE { get; set; }



        public static DrillList TranslateAsAction(DataRow dr)
        {
            var item = new DrillList();

            item.FLDDRILLID = General.GetNullableString(dr["FLDDRILLID"].ToString());
            item.FLDDRILLDUEDATE = General.GetDateTimeToString(dr["FLDDRILLDUEDATE"].ToString());
            item.FLDDRILLNAME = General.GetNullableString(dr["FLDDRILLNAME"].ToString());
            item.DUEIN = General.GetNullableString(dr["DUEIN"].ToString());
            item.FLDTYPE = "Mandatory";

            return item;
        }

        public static List<DrillList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DrillList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class MOC
    {

        [DataMember(Name = "FLDMOCREFERENCENO")]
        public string FLDMOCREFERENCENO { get; set; }

        [DataMember(Name = "FLDMOCTITLE")]
        public string FLDMOCTITLE { get; set; }

        [DataMember(Name = "FLDMOCDATE")]
        public string FLDMOCDATE { get; set; }
        [DataMember(Name = "FLDCATEGORY")]
        public string FLDCATEGORY { get; set; }
        [DataMember(Name = "FLDSUBCATEGORY")]
        public string FLDSUBCATEGORY { get; set; }
        [DataMember(Name = "FLDNATUREOFCHANGE")]
        public string FLDNATUREOFCHANGE { get; set; }
        [DataMember(Name = "FLDIMPLEMENTATIONDATE")]
        public string FLDIMPLEMENTATIONDATE { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }
        [DataMember(Name = "FLDREVISIONNUMBER")]
        public string FLDREVISIONNUMBER { get; set; }
        [DataMember(Name = "FLDNEXTINTERIMDUEDATE")]
        public string FLDNEXTINTERIMDUEDATE { get; set; }
        [DataMember(Name = "FLDCOMPLETIONDATE")]
        public string FLDCOMPLETIONDATE { get; set; }


     
        public static MOC TranslateAsAction(DataRow dr)
        {
            var item = new MOC();

            item.FLDMOCREFERENCENO = General.GetNullableString(dr["FLDMOCREFERENCENO"].ToString());
            item.FLDMOCTITLE = General.GetNullableString(dr["FLDMOCTITLE"].ToString());
            item.FLDMOCDATE = General.GetDateTimeToString(dr["FLDMOCDATE"].ToString());
            item.FLDCATEGORY = General.GetNullableString(dr["FLDCATEGORY"].ToString());
            item.FLDSUBCATEGORY = General.GetNullableString(dr["FLDSUBCATEGORY"].ToString());
            item.FLDNATUREOFCHANGE = General.GetNullableString(dr["FLDNATUREOFCHANGE"].ToString());
            item.FLDIMPLEMENTATIONDATE = General.GetDateTimeToString(dr["FLDIMPLEMENTATIONDATE"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());
            item.FLDREVISIONNUMBER = General.GetNullableString(dr["FLDREVISIONNUMBER"].ToString());
            item.FLDNEXTINTERIMDUEDATE = General.GetDateTimeToString(dr["FLDNEXTINTERIMDUEDATE"].ToString());
            item.FLDCOMPLETIONDATE = General.GetDateTimeToString(dr["FLDCOMPLETIONDATE"].ToString());




            return item;
        }

        public static List<MOC> TranslateAsActionList(DataTable dt)
        {
            var list = new List<MOC>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class RA
    {

        [DataMember(Name = "FLDNUMBER")]
        public string FLDNUMBER { get; set; }
        [DataMember(Name = "FLDVESSELNAME")]
        public string FLDVESSELNAME { get; set; }
        [DataMember(Name = "FLDDATE")]
        public string FLDDATE { get; set; }
        [DataMember(Name = "FLDINTENDEDWORKDATE")]
        public string FLDINTENDEDWORKDATE { get; set; }
        [DataMember(Name = "FLDTYPE")]
        public string FLDTYPE { get; set; }
        [DataMember(Name = "FLDACTIVITYCONDITIONS")]
        public string FLDACTIVITYCONDITIONS { get; set; }
        [DataMember(Name = "FLDCOMPLETIONDATE")]
        public string FLDCOMPLETIONDATE { get; set; }
        [DataMember(Name = "FLDTASKSTATUS")]
        public string FLDTASKSTATUS { get; set; }
        [DataMember(Name = "FLDREVISIONNO")]
        public string FLDREVISIONNO { get; set; }
        [DataMember(Name = "FLDSTATUSNAME")]
        public string FLDSTATUSNAME { get; set; }




        public static RA TranslateAsAction(DataRow dr)
        {
            var item = new RA();

            item.FLDNUMBER = General.GetNullableString(dr["FLDNUMBER"].ToString());
            item.FLDVESSELNAME = General.GetNullableString(dr["FLDVESSELNAME"].ToString());
            item.FLDDATE = General.GetDateTimeToString(dr["FLDDATE"].ToString());
            item.FLDINTENDEDWORKDATE = General.GetDateTimeToString(dr["FLDINTENDEDWORKDATE"].ToString());
            item.FLDTYPE = General.GetNullableString(dr["FLDTYPE"].ToString());
            item.FLDACTIVITYCONDITIONS = General.GetNullableString(dr["FLDACTIVITYCONDITIONS"].ToString());
            item.FLDCOMPLETIONDATE = General.GetDateTimeToString(dr["FLDCOMPLETIONDATE"].ToString());
            item.FLDTASKSTATUS = General.GetNullableString(dr["FLDTASKSTATUS"].ToString());
            item.FLDREVISIONNO = General.GetNullableString(dr["FLDREVISIONNO"].ToString());
            item.FLDSTATUSNAME = General.GetNullableString(dr["FLDSTATUSNAME"].ToString());




            return item;
        }

        public static List<RA> TranslateAsActionList(DataTable dt)
        {
            var list = new List<RA>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class AccidentAndNearmissIncidentList
    {

        [DataMember(Name = "FLDINCIDENTREFNO")]
        public string FLDINCIDENTREFNO { get; set; }
        [DataMember(Name = "FLDINCIDENTTITLE")]
        public string FLDINCIDENTTITLE { get; set; }
        [DataMember(Name = "FLDINCIDENTDATE")]
        public string FLDINCIDENTDATE { get; set; }
        [DataMember(Name = "FLDREPORTEDDATE")]
        public string FLDREPORTEDDATE { get; set; }
        [DataMember(Name = "FLDSTATUSOFINCIDENTNAME")]
        public string FLDSTATUSOFINCIDENTNAME { get; set; }
        [DataMember(Name = "FLDCATEGORYNAME")]
        public string FLDCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDSUBCATEGORYNAME")]
        public string FLDSUBCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDCONSEQUENCECATEGORY")]
        public string FLDCONSEQUENCECATEGORY { get; set; }
        [DataMember(Name = "FLDINCIDENTCLASSIFICATION")]
        public string FLDINCIDENTCLASSIFICATION { get; set; }


        public static AccidentAndNearmissIncidentList TranslateAsAction(DataRow dr)
        {
            var item = new AccidentAndNearmissIncidentList();

            item.FLDINCIDENTREFNO = General.GetNullableString(dr["FLDINCIDENTREFNO"].ToString());
            item.FLDINCIDENTTITLE = General.GetNullableString(dr["FLDINCIDENTTITLE"].ToString());
            item.FLDINCIDENTDATE = General.GetNullableString(dr["FLDINCIDENTDATE"].ToString());
            item.FLDREPORTEDDATE = General.GetNullableString(dr["FLDREPORTEDDATE"].ToString());
            item.FLDSTATUSOFINCIDENTNAME = General.GetNullableString(dr["FLDSTATUSOFINCIDENTNAME"].ToString());
            item.FLDCATEGORYNAME = General.GetNullableString(dr["FLDCATEGORYNAME"].ToString());
            item.FLDSUBCATEGORYNAME = General.GetNullableString(dr["FLDSUBCATEGORYNAME"].ToString());
            item.FLDCONSEQUENCECATEGORY = General.GetNullableString(dr["FLDCONSEQUENCECATEGORY"].ToString());
            item.FLDINCIDENTCLASSIFICATION = General.GetNullableString(dr["FLDINCIDENTCLASSIFICATION"].ToString());




            return item;
        }

        public static List<AccidentAndNearmissIncidentList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<AccidentAndNearmissIncidentList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class MachineryDamageIncidentList
    {

        [DataMember(Name = "FLDREFERENCENUMBER")]
        public string FLDREFERENCENUMBER { get; set; }
        [DataMember(Name = "FLDINCIDENTDATE")]
        public string FLDINCIDENTDATE { get; set; }
        [DataMember(Name = "FLDREPORTEDDATE")]
        public string FLDREPORTEDDATE { get; set; }
        [DataMember(Name = "FLDTITLE")]
        public string FLDTITLE { get; set; }
        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDCONSEQUENCECATEGORYNAME")]
        public string FLDCONSEQUENCECATEGORYNAME { get; set; }
        [DataMember(Name = "FLDCARGONEARMISSYN")]
        public string FLDCARGONEARMISSYN { get; set; }
        [DataMember(Name = "FLDNAVIGATIONNEARMISSYN")]
        public string FLDNAVIGATIONNEARMISSYN { get; set; }
        [DataMember(Name = "FLDINCIDENTREFNO")]
        public string FLDINCIDENTREFNO { get; set; }
        [DataMember(Name = "FLDCLOSEDDATE")]
        public string FLDCLOSEDDATE { get; set; }
        [DataMember(Name = "FLDFLDSTATUSNAME")]
        public string FLDFLDSTATUSNAME { get; set; }

   

        public static MachineryDamageIncidentList TranslateAsAction(DataRow dr)
        {
            var item = new MachineryDamageIncidentList();

            item.FLDREFERENCENUMBER = General.GetNullableString(dr["FLDREFERENCENUMBER"].ToString());
            item.FLDINCIDENTDATE = General.GetDateTimeToString(dr["FLDINCIDENTDATE"].ToString());
            item.FLDREPORTEDDATE = General.GetDateTimeToString(dr["FLDREPORTEDDATE"].ToString());
            item.FLDTITLE = General.GetNullableString(dr["FLDTITLE"].ToString());
            item.FLDCOMPONENTNAME = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDCONSEQUENCECATEGORYNAME = General.GetNullableString(dr["FLDCONSEQUENCECATEGORYNAME"].ToString());
            item.FLDCARGONEARMISSYN = General.GetNullableString(dr["FLDCARGONEARMISSYN"].ToString());
            item.FLDNAVIGATIONNEARMISSYN = General.GetNullableString(dr["FLDNAVIGATIONNEARMISSYN"].ToString());
            item.FLDINCIDENTREFNO = General.GetNullableString(dr["FLDINCIDENTREFNO"].ToString());
            item.FLDCLOSEDDATE = General.GetDateTimeToString(dr["FLDCLOSEDDATE"].ToString());
            item.FLDFLDSTATUSNAME = General.GetNullableString(dr["FLDFLDSTATUSNAME"].ToString());


            return item;
        }

        public static List<MachineryDamageIncidentList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<MachineryDamageIncidentList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class unsafeActsOpenCompletedIncidentList
    {

        [DataMember(Name = "FLDINCIDENTNEARMISSREFNO")]
        public string FLDINCIDENTNEARMISSREFNO { get; set; }
        [DataMember(Name = "FLDREPORTEDDATE")]
        public string FLDREPORTEDDATE { get; set; }
        [DataMember(Name = "FLDINCIDENTDATE")]
        public string FLDINCIDENTDATE { get; set; }
        [DataMember(Name = "FLDINCIDENTTIME")]
        public string FLDINCIDENTTIME { get; set; }
        [DataMember(Name = "FLDICCATEGORYNAME")]
        public string FLDICCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDICSUBCATEGORYNAME")]
        public string FLDICSUBCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDSUMMARY")]
        public string FLDSUMMARY { get; set; }
        [DataMember(Name = "FLDLOCATION")]
        public string FLDLOCATION { get; set; }
        [DataMember(Name = "FLDCORRECTIVEACTION")]
        public string FLDCORRECTIVEACTION { get; set; }
        [DataMember(Name = "FLDSTATUSNAME")]
        public string FLDSTATUSNAME { get; set; }




        public static unsafeActsOpenCompletedIncidentList TranslateAsAction(DataRow dr)
        {
            var item = new unsafeActsOpenCompletedIncidentList();

            item.FLDINCIDENTNEARMISSREFNO = General.GetNullableString(dr["FLDINCIDENTNEARMISSREFNO"].ToString());
            item.FLDREPORTEDDATE = General.GetDateTimeToString(dr["FLDREPORTEDDATE"].ToString());
            item.FLDINCIDENTDATE = General.GetDateTimeToString(dr["FLDINCIDENTDATE"].ToString());
            item.FLDICCATEGORYNAME = General.GetNullableString(dr["FLDICCATEGORYNAME"].ToString());
            item.FLDICSUBCATEGORYNAME = General.GetNullableString(dr["FLDICSUBCATEGORYNAME"].ToString());
            item.FLDSUMMARY = General.GetNullableString(dr["FLDSUMMARY"].ToString());
            item.FLDLOCATION = General.GetNullableString(dr["FLDLOCATION"].ToString());
            item.FLDCORRECTIVEACTION = General.GetNullableString(dr["FLDCORRECTIVEACTION"].ToString());
            //item.FLDCORRECTIVEACTION = General.GetNullableString(dr["FLDCORRECTIVEACTION"].ToString()).Length > 35 ? General.GetNullableString(dr["FLDCORRECTIVEACTION"].ToString().Substring(0, 35)) : General.GetNullableString(dr["FLDCORRECTIVEACTION"].ToString());
            item.FLDSTATUSNAME = General.GetNullableString(dr["FLDSTATUSNAME"].ToString());
            item.FLDINCIDENTTIME = General.GetNullableString(dr["FLDINCIDENTTIME"].ToString());





            return item;
        }

        public static List<unsafeActsOpenCompletedIncidentList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<unsafeActsOpenCompletedIncidentList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class CrewChangesAndApprovalCrewList
    {

        [DataMember(Name = "FLDRANKCODE")]
        public string FLDRANKCODE { get; set; }
        [DataMember(Name = "FLDEMPLOYEENAME")]
        public string FLDEMPLOYEENAME { get; set; }
        [DataMember(Name = "FLDCURRENCYCODE")]
        public string FLDCURRENCYCODE { get; set; }
        [DataMember(Name = "FLDEXPECTEDJOINDATE")]
        public string FLDEXPECTEDJOINDATE { get; set; }
        [DataMember(Name = "FLDTOTALWAGES")]
        public string FLDTOTALWAGES { get; set; }
        [DataMember(Name = "FLDOFFSIGNERNAME")]
        public string FLDOFFSIGNERNAME { get; set; }
        [DataMember(Name = "FLDRELIEFDUEDATE")]
        public string FLDRELIEFDUEDATE { get; set; }
        [DataMember(Name = "FLDPROPOSEDBY")]
        public string FLDPROPOSEDBY { get; set; }
        [DataMember(Name = "FLDPROPOSALREMARKS")]
        public string FLDPROPOSALREMARKS { get; set; }
        [DataMember(Name = "FLDPDSTATUS")]
        public string FLDPDSTATUS { get; set; }
        [DataMember(Name = "FLDNEXTSTAGE")]
        public string FLDNEXTSTAGE { get; set; }

       

        public static CrewChangesAndApprovalCrewList TranslateAsAction(DataRow dr)
        {
            var item = new CrewChangesAndApprovalCrewList();

            item.FLDRANKCODE = General.GetNullableString(dr["FLDRANKCODE"].ToString());
            item.FLDEMPLOYEENAME = General.GetNullableString(dr["FLDEMPLOYEENAME"].ToString());
            item.FLDCURRENCYCODE = General.GetNullableString(dr["FLDCURRENCYCODE"].ToString());
            item.FLDEXPECTEDJOINDATE = General.GetNullableString(dr["FLDEXPECTEDJOINDATE"].ToString());
            item.FLDTOTALWAGES = General.GetNullableString(dr["FLDTOTALWAGES"].ToString());
            item.FLDOFFSIGNERNAME = General.GetNullableString(dr["FLDOFFSIGNERNAME"].ToString());
            item.FLDRELIEFDUEDATE = General.GetNullableString(dr["FLDRELIEFDUEDATE"].ToString());
            item.FLDPROPOSEDBY = General.GetNullableString(dr["FLDPROPOSEDBY"].ToString());
            item.FLDPROPOSALREMARKS = General.GetNullableString(dr["FLDPROPOSALREMARKS"].ToString());
            item.FLDPDSTATUS = General.GetNullableString(dr["FLDPDSTATUS"].ToString());
            item.FLDNEXTSTAGE = General.GetNullableString(dr["FLDNEXTSTAGE"].ToString());

            return item;
        }

        public static List<CrewChangesAndApprovalCrewList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<CrewChangesAndApprovalCrewList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class CrewChangesAndApprovalLast24hrsList
    {

        [DataMember(Name = "FLDRELIEVERID")] 
        public string FLDRELIEVERID { get; set; }
        [DataMember(Name = "FLDRELIEVERNAME")]
        public string FLDRELIEVERNAME { get; set; }
        [DataMember(Name = "FLDRELIEVERRANK")]
        public string FLDRELIEVERRANK { get; set; }
        [DataMember(Name = "FLDEXPECTEDJOINDATE")]
        public string FLDEXPECTEDJOINDATE { get; set; }
        [DataMember(Name = "FLDSEAPORTNAME")]
        public string FLDSEAPORTNAME { get; set; }
        [DataMember(Name = "FLDNEXTSTAGE")]
        public string FLDNEXTSTAGE { get; set; }
        [DataMember(Name = "FLDOFFSIGNEREVENTDETAILID")]
        public string FLDOFFSIGNEREVENTDETAILID { get; set; }
   


        [DataMember(Name = "FLDRELIEFDUEDATE")]
        public string FLDRELIEFDUEDATE { get; set; }
        [DataMember(Name = "FLDNAME")]
        public string FLDNAME { get; set; }
        [DataMember(Name = "FLDOFFSIGNERJOINDATE")]
        public string FLDOFFSIGNERJOINDATE { get; set; }
        [DataMember(Name = "FLDRANKNAME")]
        public string FLDRANKNAME { get; set; }
        [DataMember(Name = "FLDRANKID")]
        public string FLDRANKID { get; set; }
        [DataMember(Name = "FLDDAYSONBOARD")]
        public string FLDDAYSONBOARD { get; set; }
        
         [DataMember(Name = "FLDREFERENCENO")]
        public string FLDREFERENCENO { get; set; }




        public static CrewChangesAndApprovalLast24hrsList TranslateAsAction(DataRow dr)
        {
            var item = new CrewChangesAndApprovalLast24hrsList();

            item.FLDRELIEVERID = General.GetNullableString(dr["FLDRELIEVERID"].ToString());
            item.FLDRELIEVERNAME = General.GetNullableString(dr["FLDRELIEVERNAME"].ToString());
            item.FLDRELIEVERRANK = General.GetNullableString(dr["FLDRELIEVERRANK"].ToString());
            item.FLDEXPECTEDJOINDATE = General.GetDateTimeToString(dr["FLDEXPECTEDJOINDATE"].ToString());
            item.FLDSEAPORTNAME = General.GetNullableString(dr["FLDSEAPORTNAME"].ToString());
            item.FLDNEXTSTAGE = General.GetNullableString(dr["FLDNEXTSTAGE"].ToString());
            item.FLDREFERENCENO = General.GetNullableString(dr["FLDREFERENCENO"].ToString());




            item.FLDOFFSIGNEREVENTDETAILID = General.GetNullableString(dr["FLDOFFSIGNEREVENTDETAILID"].ToString());
            item.FLDDAYSONBOARD = General.GetNullableString(dr["FLDDAYSONBOARD"].ToString());
            item.FLDRANKID = General.GetNullableString(dr["FLDRANKID"].ToString());
            item.FLDRANKNAME = General.GetNullableString(dr["FLDRANKNAME"].ToString());
            item.FLDOFFSIGNERJOINDATE = General.GetDateTimeToString(dr["FLDOFFSIGNERJOINDATE"].ToString());
            item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
            item.FLDRELIEFDUEDATE = General.GetDateTimeToString(dr["FLDRELIEFDUEDATE"].ToString());


            return item;
        }

        public static List<CrewChangesAndApprovalLast24hrsList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<CrewChangesAndApprovalLast24hrsList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class NoonReportTechnicalPanel
    {

        [DataMember(Name = "FLDNOONREPORTDATE")]
        public string FLDNOONREPORTDATE { get; set; }
        [DataMember(Name = "FLDVOYAGENO")]
        public string FLDVOYAGENO { get; set; }
        [DataMember(Name = "FLDBALLASTYESNO")]
        public string FLDBALLASTYESNO { get; set; }
        [DataMember(Name = "FLDWINDFORCE")]
        public string FLDWINDFORCE { get; set; }
        [DataMember(Name = "FLDATPORTNEXTPORT")]
        public string FLDATPORTNEXTPORT { get; set; }
        [DataMember(Name = "FLDETA")]
        public string FLDETA { get; set; }
        [DataMember(Name = "FLDMERPM")]
        public string FLDMERPM { get; set; }
        [DataMember(Name = "FLDSLIP")]
        public string FLDSLIP { get; set; }
        [DataMember(Name = "FLDLOGSPEED")]
        public string FLDLOGSPEED { get; set; }

        [DataMember(Name = "FLDCHARTERSPEED")]
        public string FLDCHARTERSPEED { get; set; }
        [DataMember(Name = "FLDHFOOILCONSUMPTIONQTY")]
        public string FLDHFOOILCONSUMPTIONQTY { get; set; }
        [DataMember(Name = "FLDMEFOOILCONSUMPTIONQTY")]
        public string FLDMEFOOILCONSUMPTIONQTY { get; set; }
        [DataMember(Name = "FLDHFOCHARTERCOUNSUMPTION")]
        public string FLDHFOCHARTERCOUNSUMPTION { get; set; }
        [DataMember(Name = "FLDMDOOILCONSUMPTIONQTY")]
        public string FLDMDOOILCONSUMPTIONQTY { get; set; }

        [DataMember(Name = "FLDMDOCHARTERCOUNSUMPTION")]
        public string FLDMDOCHARTERCOUNSUMPTION { get; set; }
        [DataMember(Name = "FLDFOCATFINES")]
        public string FLDFOCATFINES { get; set; }
        [DataMember(Name = "FLDOILMAJORCARGOONBOARDYN")]
        public string FLDOILMAJORCARGOONBOARDYN { get; set; }
        [DataMember(Name = "FLDOILMAJOR")]
        public string FLDOILMAJOR { get; set; }
        [DataMember(Name = "FLDOVERDUE")]
        public string FLDOVERDUE { get; set; }
        [DataMember(Name = "FLDREVIEWEDBY")]
        public string FLDREVIEWEDBY { get; set; }
        [DataMember(Name = "FLDREVIEWDDATE")] 
        public string FLDREVIEWDDATE { get; set; }
        [DataMember(Name = "FLDVESSELNAME")]
        public string FLDVESSELNAME { get; set; }


        public static NoonReportTechnicalPanel TranslateAsAction(DataRow dr)
        {
            var item = new NoonReportTechnicalPanel();

            item.FLDNOONREPORTDATE = General.GetNullableString(dr["FLDNOONREPORTDATE"].ToString());
            item.FLDVOYAGENO = General.GetNullableString(dr["FLDVOYAGENO"].ToString());
            item.FLDBALLASTYESNO = General.GetNullableString(dr["FLDBALLASTYESNO"].ToString());
            item.FLDWINDFORCE = General.GetNullableString(dr["FLDWINDFORCE"].ToString());
            item.FLDATPORTNEXTPORT = General.GetNullableString(dr["FLDATPORTNEXTPORT"].ToString());
            item.FLDETA = General.GetNullableString(dr["FLDETA"].ToString());
            item.FLDMERPM = General.GetNullableString(dr["FLDMERPM"].ToString());
            item.FLDSLIP = General.GetNullableString(dr["FLDSLIP"].ToString());
            item.FLDLOGSPEED = General.GetNullableString(dr["FLDLOGSPEED"].ToString());
            item.FLDCHARTERSPEED = General.GetNullableString(dr["FLDCHARTERSPEED"].ToString());
            item.FLDHFOOILCONSUMPTIONQTY = General.GetNullableString(dr["FLDHFOOILCONSUMPTIONQTY"].ToString());
            item.FLDMEFOOILCONSUMPTIONQTY = General.GetNullableString(dr["FLDMEFOOILCONSUMPTIONQTY"].ToString());
            item.FLDHFOCHARTERCOUNSUMPTION = General.GetNullableString(dr["FLDHFOCHARTERCOUNSUMPTION"].ToString());
            item.FLDMDOOILCONSUMPTIONQTY = General.GetNullableString(dr["FLDMDOOILCONSUMPTIONQTY"].ToString());
            item.FLDMDOCHARTERCOUNSUMPTION = General.GetNullableString(dr["FLDMDOCHARTERCOUNSUMPTION"].ToString());
            item.FLDFOCATFINES = General.GetNullableString(dr["FLDFOCATFINES"].ToString());
            item.FLDOILMAJORCARGOONBOARDYN = General.GetNullableString(dr["FLDOILMAJORCARGOONBOARDYN"].ToString());
            item.FLDOILMAJOR = General.GetNullableString(dr["FLDOILMAJOR"].ToString());
            item.FLDOVERDUE = General.GetNullableString(dr["FLDOVERDUE"].ToString());
            item.FLDREVIEWEDBY = General.GetNullableString(dr["FLDREVIEWEDBY"].ToString());
            item.FLDREVIEWDDATE = General.GetNullableString(dr["FLDREVIEWDDATE"].ToString());
            item.FLDVESSELNAME = General.GetNullableString(dr["FLDVESSELNAME"].ToString());


            return item;
        }

        public static List<NoonReportTechnicalPanel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<NoonReportTechnicalPanel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class ArrivalReportTechnicalPanel
    {

     
        [DataMember(Name = "FLDSEAPORTNAME")]
        public string FLDSEAPORTNAME { get; set; }

        [DataMember(Name = "FLDOBSERBEDDISTANCE")]
        public string FLDOBSERBEDDISTANCE { get; set; }

        [DataMember(Name = "FLDETD")]
        public string FLDETD { get; set; }

        [DataMember(Name = "FLDDATE")]
        public string FLDDATE { get; set; }

        [DataMember(Name = "FLDETB")]
        public string FLDETB { get; set; }

    
        public static ArrivalReportTechnicalPanel TranslateAsAction(DataRow dr)
        {
            var item = new ArrivalReportTechnicalPanel();

            item.FLDSEAPORTNAME = General.GetNullableString(dr["FLDSEAPORTNAME"].ToString());
            item.FLDOBSERBEDDISTANCE = General.GetNullableString(dr["FLDOBSERBEDDISTANCE"].ToString());
            item.FLDETD = General.GetNullableString(dr["FLDETD"].ToString());
            item.FLDDATE = General.GetNullableString(dr["FLDDATE"].ToString());
            item.FLDETB = General.GetNullableString(dr["FLDETB"].ToString());




            return item;
        }

        public static List<ArrivalReportTechnicalPanel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<ArrivalReportTechnicalPanel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }






    public class DepartureReportTechnicalPanel
    {


        [DataMember(Name = "FLDSEAPORTNAME")]
        public string FLDSEAPORTNAME { get; set; }

        [DataMember(Name = "FLDVESSELDEPARTUREDATE")]
        public string FLDVESSELDEPARTUREDATE { get; set; }

        [DataMember(Name = "FLDNEXTPORTNAME")]
        public string FLDNEXTPORTNAME { get; set; }

        [DataMember(Name = "FLDETA")]
        public string FLDETA { get; set; }

        [DataMember(Name = "FLDCARGOOPERATION")]
        public string FLDCARGOOPERATION { get; set; }
        [DataMember(Name = "FLDSTSOPERATION")]
        public string FLDSTSOPERATION { get; set; }



        public static DepartureReportTechnicalPanel TranslateAsAction(DataRow dr)
        {
            var item = new DepartureReportTechnicalPanel();

            item.FLDSEAPORTNAME = General.GetNullableString(dr["FLDSEAPORTNAME"].ToString());
            item.FLDVESSELDEPARTUREDATE = General.GetNullableString(dr["FLDVESSELDEPARTUREDATE"].ToString());
            item.FLDNEXTPORTNAME = General.GetNullableString(dr["FLDNEXTPORTNAME"].ToString());
            item.FLDETA = General.GetNullableString(dr["FLDETA"].ToString());
            item.FLDCARGOOPERATION = General.GetNullableString(dr["FLDCARGOOPERATION"].ToString());
            item.FLDSTSOPERATION = General.GetNullableString(dr["FLDSTSOPERATION"].ToString());




            return item;
        }

        public static List<DepartureReportTechnicalPanel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DepartureReportTechnicalPanel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class InsPanelList
    {

        [DataMember(Name = "FLDCREATEDFROMNAME")]
        public string FLDCREATEDFROMNAME { get; set; }
        [DataMember(Name = "FLDSOURCENAME")]
        public string FLDSOURCENAME { get; set; }
        [DataMember(Name = "FLDHARDNAME")]
        public string FLDHARDNAME { get; set; }
        [DataMember(Name = "FLDDEPARTMENTNAME")]
        public string FLDDEPARTMENTNAME { get; set; }
        [DataMember(Name = "FLDITEMNAME")]
        public string FLDITEMNAME { get; set; }
        [DataMember(Name = "FLDDEFICIENCYDETAILS")]
        public string FLDDEFICIENCYDETAILS { get; set; }
        [DataMember(Name = "FLDCORRECTIVEACTIONTEXT")]
        public string FLDCORRECTIVEACTIONTEXT { get; set; }
        [DataMember(Name = "FLDTARGETDATE")]
        public string FLDTARGETDATE { get; set; }
        [DataMember(Name = "FLDSHIPBOARDSTATUS")]
        public string FLDSHIPBOARDSTATUS { get; set; }



        public static InsPanelList TranslateAsAction(DataRow dr)
        {
            var item = new InsPanelList();

            item.FLDCREATEDFROMNAME = General.GetNullableString(dr["FLDCREATEDFROMNAME"].ToString());
            item.FLDSOURCENAME = General.GetNullableString(dr["FLDSOURCENAME"].ToString());
            item.FLDHARDNAME = General.GetNullableString(dr["FLDHARDNAME"].ToString());
            item.FLDDEPARTMENTNAME = General.GetNullableString(dr["FLDDEPARTMENTNAME"].ToString());
            item.FLDITEMNAME = General.GetNullableString(dr["FLDITEMNAME"].ToString());
            item.FLDDEFICIENCYDETAILS = General.GetNullableString(dr["FLDDEFICIENCYDETAILS"].ToString());
            item.FLDCORRECTIVEACTIONTEXT = General.GetNullableString(dr["FLDCORRECTIVEACTIONTEXT"].ToString());
            item.FLDTARGETDATE = General.GetNullableString(dr["FLDTARGETDATE"].ToString());
            item.FLDSHIPBOARDSTATUS = General.GetNullableString(dr["FLDSHIPBOARDSTATUS"].ToString());


            return item;
        }

        public static List<InsPanelList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InsPanelList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }

    public class PostpondedRequestListPMSPanel
    {

        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDCOMPONENTNUMBER")]
        public string FLDCOMPONENTNUMBER { get; set; }
        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDCLASSCODE")]
        public string FLDCLASSCODE { get; set; }
        [DataMember(Name = "FLDFREQUENCYNAME")]
        public string FLDFREQUENCYNAME { get; set; }
        [DataMember(Name = "FLDPLANINGPRIORITY")]
        public string FLDPLANINGPRIORITY { get; set; }
        [DataMember(Name = "FLDDISCIPLINENAME")]
        public string FLDDISCIPLINENAME { get; set; }
        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }
        [DataMember(Name = "FLDLASTDONEDATE")]
        public string FLDLASTDONEDATE { get; set; }
        [DataMember(Name = "FLDAPPROVALBY")]
        public string FLDAPPROVALBY { get; set; }
        [DataMember(Name = "FLDEXTENSIONTYPE")]
        public string FLDEXTENSIONTYPE { get; set; }
        [DataMember(Name = "FLDRESCHEDULESTATUSNAME")]
        public string FLDRESCHEDULESTATUSNAME { get; set; }

        public static PostpondedRequestListPMSPanel TranslateAsAction(DataRow dr)
        {
            var item = new PostpondedRequestListPMSPanel();

            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDCOMPONENTNUMBER = General.GetNullableString(dr["FLDCOMPONENTNUMBER"].ToString());
            item.FLDCOMPONENTNAME = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDCLASSCODE = General.GetNullableString(dr["FLDCLASSCODE"].ToString());
            item.FLDFREQUENCYNAME = General.GetNullableString(dr["FLDFREQUENCYNAME"].ToString());
            item.FLDPLANINGPRIORITY = General.GetNullableString(dr["FLDPLANINGPRIORITY"].ToString());
            item.FLDDISCIPLINENAME = General.GetNullableString(dr["FLDDISCIPLINENAME"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetNullableString(dr["FLDPLANNINGDUEDATE"].ToString());
            item.FLDLASTDONEDATE = General.GetNullableString(dr["FLDLASTDONEDATE"].ToString());
            item.FLDAPPROVALBY = General.GetNullableString(dr["FLDAPPROVALBY"].ToString());
            item.FLDEXTENSIONTYPE = General.GetNullableString(dr["FLDEXTENSIONTYPE"].ToString());
            item.FLDRESCHEDULESTATUSNAME = General.GetNullableString(dr["FLDRESCHEDULESTATUSNAME"].ToString());

            return item;
        }

        public static List<PostpondedRequestListPMSPanel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<PostpondedRequestListPMSPanel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class AuditAndInspection60daysAndOverduePanel
    {

        [DataMember(Name = "FLDISMANUAL")]
        public string FLDISMANUAL { get; set; }
        [DataMember(Name = "FLDINSPECTIONSHORTCODE")]
        public string FLDINSPECTIONSHORTCODE { get; set; }
        [DataMember(Name = "FLDLASTDONEDATE")]
        public string FLDLASTDONEDATE { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDPLANNEDDATE")]
        public string FLDPLANNEDDATE { get; set; }
        [DataMember(Name = "FLDFROMPORT")]
        public string FLDFROMPORT { get; set; }
        [DataMember(Name = "FLDTOPORT")]
        public string FLDTOPORT { get; set; }
        [DataMember(Name = "FLDATTENDINGSUPT")]
        public string FLDATTENDINGSUPT { get; set; }
        [DataMember(Name = "FLDEXTERNALINSPECTORNAME")]
        public string FLDEXTERNALINSPECTORNAME { get; set; }
        [DataMember(Name = "FLDSTATUSNAME")]
        public string FLDSTATUSNAME { get; set; }

        public static AuditAndInspection60daysAndOverduePanel TranslateAsAction(DataRow dr)
        {
            var item = new AuditAndInspection60daysAndOverduePanel();

            item.FLDISMANUAL = General.GetNullableString(dr["FLDISMANUAL"].ToString());
            item.FLDINSPECTIONSHORTCODE = General.GetNullableString(dr["FLDINSPECTIONSHORTCODE"].ToString());
            item.FLDLASTDONEDATE = General.GetDateTimeToString(dr["FLDLASTDONEDATE"].ToString());
            item.FLDDUEDATE = General.GetDateTimeToString(dr["FLDDUEDATE"].ToString());
            item.FLDPLANNEDDATE = General.GetNullableString(dr["FLDPLANNEDDATE"].ToString());
            item.FLDFROMPORT = General.GetNullableString(dr["FLDFROMPORT"].ToString());
            item.FLDTOPORT = General.GetNullableString(dr["FLDTOPORT"].ToString());
            item.FLDATTENDINGSUPT = General.GetNullableString(dr["FLDATTENDINGSUPT"].ToString());
            item.FLDEXTERNALINSPECTORNAME = General.GetNullableString(dr["FLDEXTERNALINSPECTORNAME"].ToString());
            item.FLDSTATUSNAME = General.GetNullableString(dr["FLDSTATUSNAME"].ToString());
       

            return item;
        }

        public static List<AuditAndInspection60daysAndOverduePanel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<AuditAndInspection60daysAndOverduePanel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class InspectionDashBoardAuditRecordListPanel
    {

        [DataMember(Name = "FLDISMANUAL")]
        public string FLDISMANUAL { get; set; }
        [DataMember(Name = "FLDREFERENCENUMBER")]
        public string FLDREFERENCENUMBER { get; set; }
        [DataMember(Name = "FLDSHORTCODE")]
        public string FLDSHORTCODE { get; set; }
        [DataMember(Name = "FLDCOMPLETIONDATE")]
        public string FLDCOMPLETIONDATE { get; set; }
        [DataMember(Name = "FLDCREDITEDYN")]
        public string FLDCREDITEDYN { get; set; }

        [DataMember(Name = "FLDSTATUSNAME")]
        public string FLDSTATUSNAME { get; set; }
        [DataMember(Name = "FLDFROMPORT")]
        public string FLDFROMPORT { get; set; }
        [DataMember(Name = "FLDTOPORT")]
        public string FLDTOPORT { get; set; }
        [DataMember(Name = "FLDNAMEOFINSPECTOR")]
        public string FLDNAMEOFINSPECTOR { get; set; }
        [DataMember(Name = "FLDORGANISATION")]
        public string FLDORGANISATION { get; set; }
        [DataMember(Name = "FLDDEFICIENCYCOUNT")]
        public string FLDDEFICIENCYCOUNT { get; set; }
        [DataMember(Name = "FLDMAJORNCCOUNT")]
        public string FLDMAJORNCCOUNT { get; set; }
        [DataMember(Name = "FLDNCCOUNT")]
        public string FLDNCCOUNT { get; set; }
        [DataMember(Name = "FLDOBSCOUNT")]
        public string FLDOBSCOUNT { get; set; }



        public static InspectionDashBoardAuditRecordListPanel TranslateAsAction(DataRow dr)
        {
            var item = new InspectionDashBoardAuditRecordListPanel();

            item.FLDISMANUAL = General.GetNullableString(dr["FLDISMANUAL"].ToString());
            item.FLDREFERENCENUMBER = General.GetNullableString(dr["FLDREFERENCENUMBER"].ToString());
            item.FLDSHORTCODE = General.GetNullableString(dr["FLDSHORTCODE"].ToString());
            item.FLDCOMPLETIONDATE = General.GetDateTimeToString(dr["FLDCOMPLETIONDATE"].ToString());
            item.FLDCREDITEDYN = General.GetNullableString(dr["FLDCREDITEDYN"].ToString());
            item.FLDSTATUSNAME = General.GetNullableString(dr["FLDSTATUSNAME"].ToString());

            item.FLDFROMPORT = General.GetNullableString(dr["FLDFROMPORT"].ToString());
            item.FLDTOPORT = General.GetNullableString(dr["FLDTOPORT"].ToString());
            item.FLDNAMEOFINSPECTOR = General.GetNullableString(dr["FLDNAMEOFINSPECTOR"].ToString());
            item.FLDORGANISATION = General.GetNullableString(dr["FLDORGANISATION"].ToString());

            item.FLDDEFICIENCYCOUNT = General.GetNullableString(dr["FLDDEFICIENCYCOUNT"].ToString());
            item.FLDMAJORNCCOUNT = General.GetNullableString(dr["FLDMAJORNCCOUNT"].ToString());
            item.FLDNCCOUNT = General.GetNullableString(dr["FLDNCCOUNT"].ToString());
            item.FLDOBSCOUNT = General.GetNullableString(dr["FLDOBSCOUNT"].ToString());



            return item;
        }

        public static List<InspectionDashBoardAuditRecordListPanel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionDashBoardAuditRecordListPanel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class InspectionDashboardSIREPlannerList
    {

        [DataMember(Name = "FLDINSPECTIONSHORTCODE")]
        public string FLDINSPECTIONSHORTCODE { get; set; }
        [DataMember(Name = "FLD3RDINSPECTION")]
        public string FLD3RDINSPECTION { get; set; }
        [DataMember(Name = "FLD2NDINSPECTION")]
        public string FLD2NDINSPECTION { get; set; }
        [DataMember(Name = "FLD1STINSPECTION")]
        public string FLD1STINSPECTION { get; set; }
        [DataMember(Name = "FLDDUEDATE")]
        public string FLDDUEDATE { get; set; }
        [DataMember(Name = "FLDPLANNEDDATE")]
        public string FLDPLANNEDDATE { get; set; }
        [DataMember(Name = "FLDACTIVEYN")]
        public string FLDACTIVEYN { get; set; }
        [DataMember(Name = "FLDSCHEDULESTATUS")]
        public string FLDSCHEDULESTATUS { get; set; }

        public static InspectionDashboardSIREPlannerList TranslateAsAction(DataRow dr)
        {
            var item = new InspectionDashboardSIREPlannerList();

            item.FLDINSPECTIONSHORTCODE = General.GetNullableString(dr["FLDINSPECTIONSHORTCODE"].ToString());
            item.FLD3RDINSPECTION = General.GetNullableString(dr["FLD3RDINSPECTION"].ToString());
            item.FLD2NDINSPECTION = General.GetNullableString(dr["FLD2NDINSPECTION"].ToString());
            item.FLD1STINSPECTION = General.GetDateTimeToString(dr["FLD1STINSPECTION"].ToString());
            item.FLDDUEDATE = General.GetNullableString(dr["FLDDUEDATE"].ToString());
            item.FLDPLANNEDDATE = General.GetDateTimeToString(dr["FLDPLANNEDDATE"].ToString());
            item.FLDACTIVEYN = General.GetNullableString(dr["FLDACTIVEYN"].ToString());
            item.FLDSCHEDULESTATUS = General.GetNullableString(dr["FLDSCHEDULESTATUS"].ToString());

            return item;
        }

        public static List<InspectionDashboardSIREPlannerList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionDashboardSIREPlannerList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class InspectionDashboardScheduleMasterList
    {

        [DataMember(Name = "FLDREFERENCENUMBER")]
        public string FLDREFERENCENUMBER { get; set; }
        [DataMember(Name = "FLDINSPECTIONCATEGORY")]
        public string FLDINSPECTIONCATEGORY { get; set; }
        [DataMember(Name = "FLDINSPECTIONCOMPANYNAME")]
        public string FLDINSPECTIONCOMPANYNAME { get; set; }
        [DataMember(Name = "FLDSHORTCODE")]
        public string FLDSHORTCODE { get; set; }
        [DataMember(Name = "FLDCOMPLETIONDATE")]
        public string FLDCOMPLETIONDATE { get; set; }
        [DataMember(Name = "FLDSEAPORTNAME")]
        public string FLDSEAPORTNAME { get; set; }
        [DataMember(Name = "FLDNAMEOFINSPECTOR")]
        public string FLDNAMEOFINSPECTOR { get; set; }
        [DataMember(Name = "FLDATTENDINGSUPT")]
        public string FLDATTENDINGSUPT { get; set; }
        [DataMember(Name = "FLDSTATUSNAME")]
        public string FLDSTATUSNAME { get; set; }
        [DataMember(Name = "FLDDEFICIENCYCOUNT")]
        public string FLDDEFICIENCYCOUNT { get; set; }
        [DataMember(Name = "FLDOBSCOUNT")]
        public string FLDOBSCOUNT { get; set; }
        [DataMember(Name = "FLDHIRISKOBSCOUNT")]
        public string FLDHIRISKOBSCOUNT { get; set; }


        public static InspectionDashboardScheduleMasterList TranslateAsAction(DataRow dr)
        {
            var item = new InspectionDashboardScheduleMasterList();

            item.FLDREFERENCENUMBER = General.GetNullableString(dr["FLDREFERENCENUMBER"].ToString());
            item.FLDINSPECTIONCATEGORY = General.GetNullableString(dr["FLDINSPECTIONCATEGORY"].ToString());
            item.FLDINSPECTIONCOMPANYNAME = General.GetNullableString(dr["FLDINSPECTIONCOMPANYNAME"].ToString());
            item.FLDSHORTCODE = General.GetDateTimeToString(dr["FLDSHORTCODE"].ToString());
            item.FLDCOMPLETIONDATE = General.GetNullableString(dr["FLDCOMPLETIONDATE"].ToString());
            item.FLDSEAPORTNAME = General.GetDateTimeToString(dr["FLDSEAPORTNAME"].ToString());
            item.FLDNAMEOFINSPECTOR = General.GetNullableString(dr["FLDNAMEOFINSPECTOR"].ToString());
            item.FLDATTENDINGSUPT = General.GetNullableString(dr["FLDATTENDINGSUPT"].ToString());
            item.FLDSTATUSNAME = General.GetNullableString(dr["FLDSTATUSNAME"].ToString());
            item.FLDDEFICIENCYCOUNT = General.GetNullableString(dr["FLDDEFICIENCYCOUNT"].ToString());
            item.FLDOBSCOUNT = General.GetNullableString(dr["FLDOBSCOUNT"].ToString());
            item.FLDHIRISKOBSCOUNT = General.GetNullableString(dr["FLDHIRISKOBSCOUNT"].ToString());

   

            return item;
        }

        public static List<InspectionDashboardScheduleMasterList> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionDashboardScheduleMasterList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }

}