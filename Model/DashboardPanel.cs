using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{

    [DataContract]
    public class DashboardPanelModelFilter
    {
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "subcategoryid")]
        public int? subcategoryid { get; set; }
        [DataMember(Name = "vesselid")]
        public int? vesselid { get; set; }
        [DataMember(Name = "showActioned")]
        public int? showActioned { get; set; }
        [DataMember(Name = "companyId")]
        public int? companyId { get; set; }
        [DataMember(Name = "dueinterval")]
        public int? dueinterval { get; set; }
        [DataMember(Name = "categorycode")]
        public string categorycode { get; set; }
        [DataMember(Name = "sortby")]
        public int? sortby { get; set; }
        [DataMember(Name = "sortdirection")]
        public int? sortdirection { get; set; }
        [DataMember(Name = "pagenumber")]
        public int? pagenumber { get; set; }
        [DataMember(Name = "pagesize")]
        public int? pagesize { get; set; }
        [DataMember(Name = "resultcount")]
        public int? resultcount { get; set; }
        [DataMember(Name = "totalpagecount")]
        public int? totalpagecount { get; set; }
    }

    [DataContract]
    public class DashboardPanelModelPurchase
    {
        [DataMember(Name = "FLDMEASURE")]
        public string FLDMEASURE { get; set; }
        [DataMember(Name = "FLDCOUNT")]
        public int? FLDCOUNT { get; set; }
        [DataMember(Name = "FLDPANELCOLOUR")]
        public int? FLDPANELCOLOUR { get; set; }
        [DataMember(Name = "FLDROWCOLOUR")]
        public int? FLDROWCOLOUR { get; set; }



        public static DashboardPanelModelPurchase TranslateAsDashboardPanelModelPurchase(DataRow dr)
        {
            var item = new DashboardPanelModelPurchase();

            item.FLDMEASURE = General.GetNullableString(dr["FLDMEASURE"].ToString());
            item.FLDCOUNT = General.GetNullableInteger(dr["FLDCOUNT"].ToString());
            item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
            item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());
            return item;
        }
        public static List<DashboardPanelModelPurchase> TranslateAsDashboardPanelModelPurchaseList(DataTable dt)
        {
            var list = new List<DashboardPanelModelPurchase>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsDashboardPanelModelPurchase(dr));
            }
            return list;
        }
    }



    [DataContract]
    public class DashboardPanelModelDrills
    {
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "drillname")]
        public string drillname { get; set; }
        [DataMember(Name = "drillid")]
        public string drillid { get; set; }
        [DataMember(Name = "overdue")]
        public string overdue { get; set; }
        [DataMember(Name = "type")]
        public string type { get; set; }


        public static DashboardPanelModelDrills TranslateAsDashboardPanelModelDrills(DataRow dr)
        {
            var item = new DashboardPanelModelDrills();

            item.id = General.GetNullableString(dr["ROW#"].ToString());
            item.drillname = General.GetNullableString(dr["FLDDRILLNAME"].ToString());
            item.drillid = General.GetNullableString(dr["FLDDRILLID"].ToString());
            item.overdue = General.GetNullableString(dr["FLDOVERDUE"].ToString());
            item.type = General.GetNullableString(dr["FLDTYPE"].ToString());
            return item;
        }
        public static List<DashboardPanelModelDrills> TranslateAsDashboardPanelModelDrillsList(DataTable dt)
        {
            var list = new List<DashboardPanelModelDrills>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsDashboardPanelModelDrills(dr));
            }
            return list;
        }
    }


    //public class DashboardPanelModelVesselPerformance
    //{
    //    [DataMember(Name = "id")]
    //    public string id { get; set; }
    //    [DataMember(Name = "measurename")]
    //    public string measurename { get; set; }
    //    [DataMember(Name = "overdue")]
    //    public string overdue { get; set; }
    //    [DataMember(Name = "pendingreview")]
    //    public string pendingreview { get; set; }
    //    [DataMember(Name = "FLDACTIONEDOVERDUE")]
    //    public string FLDACTIONEDOVERDUE { get; set; }
    //    [DataMember(Name = "FLDNOONREPORTOVERDUE")]
    //    public string FLDNOONREPORTOVERDUE { get; set; }
    //    [DataMember(Name = "FLDMONREPORTOVERDUE")]
    //    public string FLDMONREPORTOVERDUE { get; set; }
    //    [DataMember(Name = "FLDQTRREPORTOVERDUE")]
    //    public string FLDQTRREPORTOVERDUE { get; set; }





    //    public static DashboardPanelModelVesselPerformance TranslateAsDashboardPanelModelVesselPerformance(DataRow dr)
    //    {
    //        var item = new DashboardPanelModelVesselPerformance();
    //        DateTime d = DateTime.Parse(dr["FLDOVERDUECOUNT"].ToString());

    //        item.id = General.GetNullableString(dr["FLDROW"].ToString());
    //        item.measurename = General.GetNullableString(dr["FLDMEASURE"].ToString());
    //        item.FLDACTIONEDOVERDUE = General.GetNullableString(dr["FLDACTIONEDOVERDUE"].ToString());
    //        item.FLDNOONREPORTOVERDUE = General.GetNullableString(dr["FLDNOONREPORTOVERDUE"].ToString());
    //        item.FLDMONREPORTOVERDUE = General.GetNullableString(dr["FLDMONREPORTOVERDUE"].ToString());
    //        item.FLDQTRREPORTOVERDUE = General.GetNullableString(dr["FLDQTRREPORTOVERDUE"].ToString());
    //        item.overdue = General.GetDateTimeToString(dr["FLDOVERDUECOUNT"].ToString()) + " ( " + (DateTime.Now.Date - d).Days + " ) ";
    //        item.pendingreview = General.GetDateTimeToString(dr["FLDREVIEWCOUNT"].ToString()) ;

    //        if( General.GetDateTimeToString(dr["FLDREVIEWCOUNT"].ToString()) == null)
    //        {
    //            item.pendingreview = General.GetNullableString(dr["FLDREVIEWCOUNT"].ToString());
    //        }
    //        return item;
    //    }


    //    public static List<DashboardPanelModelVesselPerformance> TranslateAsDashboardPanelModelVesselPerformance(DataTable dt)
    //    {
    //        var list = new List<DashboardPanelModelVesselPerformance>();
    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            list.Add(TranslateAsDashboardPanelModelVesselPerformance(dr));
    //        }
    //        return list;
    //    }
    //}


    public class DashboardPanelModelVesselPerformance
    {
        [DataMember(Name = "FLDMEASURE")]
        public string FLDMEASURE { get; set; }
        [DataMember(Name = "FLDOVERDUECOUNT")]
        public string FLDOVERDUECOUNT { get; set; }
        [DataMember(Name = "FLDREVIEWCOUNT")]
        public string FLDREVIEWCOUNT { get; set; }


        public static DashboardPanelModelVesselPerformance TranslateAsDashboardPanelModelVesselPerformance(DataRow dr)
        {
            var item = new DashboardPanelModelVesselPerformance();

            item.FLDMEASURE = General.GetNullableString(dr["FLDMEASURE"].ToString());
            item.FLDOVERDUECOUNT = General.GetNullableString(dr["FLDOVERDUECOUNT"].ToString());
            item.FLDREVIEWCOUNT = General.GetNullableString(dr["FLDREVIEWCOUNT"].ToString());

            return item;
        }


        public static List<DashboardPanelModelVesselPerformance> TranslateAsDashboardPanelModelVesselPerformance(DataTable dt)
        {
            var list = new List<DashboardPanelModelVesselPerformance>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsDashboardPanelModelVesselPerformance(dr));
            }
            return list;
        }
    }

}




public class DashboardPanelModelCertificateSurvey
{
 
    [DataMember(Name = "FLDMEASURE")]
    public string FLDMEASURE { get; set; }
    [DataMember(Name = "FLDOVERDUECOUNT")]
    public int? FLDOVERDUECOUNT { get; set; }
    [DataMember(Name = "FLD30COUNT")]
    public int? FLD30COUNT { get; set; }
    [DataMember(Name = "FLD60COUNT")]
    public int? FLD60COUNT { get; set; }
    [DataMember(Name = "FLDACTIONEDOVERDUECOUNT")]
    public int? FLDACTIONEDOVERDUECOUNT { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }
    [DataMember(Name = "FLDELEMENTID")]
    public int? FLDELEMENTID { get; set; }


    public static DashboardPanelModelCertificateSurvey TranslateAsDashboardPanelModelCertificateSurvey(DataRow dr)
    {
        var item = new DashboardPanelModelCertificateSurvey();

        item.FLDMEASURE = General.GetNullableString(dr["FLDMEASURE"].ToString());
        item.FLDOVERDUECOUNT = General.GetNullableInteger(dr["FLDOVERDUECOUNT"].ToString());
        item.FLD30COUNT = General.GetNullableInteger(dr["FLD30COUNT"].ToString());
        item.FLD60COUNT = General.GetNullableInteger(dr["FLD60COUNT"].ToString());
        item.FLDACTIONEDOVERDUECOUNT = General.GetNullableInteger(dr["FLDACTIONEDOVERDUECOUNT"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());
        item.FLDELEMENTID = General.GetNullableInteger(dr["FLDELEMENTID"].ToString());

        return item;
    }


    public static List<DashboardPanelModelCertificateSurvey> TranslateAsDashboardPanelModelCertificateSurvey(DataTable dt)
    {
        var list = new List<DashboardPanelModelCertificateSurvey>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelCertificateSurvey(dr));
        }
        return list;
    }
}

public class DashboardPanelModelCertificateSurveyDueList
{
    [DataMember(Name = "FLDCERTIFICATENAME")]
    public string FLDCERTIFICATENAME { get; set; }
    [DataMember(Name = "FLDDATEOFISSUE")]
    public string FLDDATEOFISSUE { get; set; }
    [DataMember(Name = "FLDDATEOFEXPIRY")]
    public string FLDDATEOFEXPIRY { get; set; }
    [DataMember(Name = "FLDISSUINGAUTHORITYNAME")]
    public string FLDISSUINGAUTHORITYNAME { get; set; }
    [DataMember(Name = "FLDLASTSURVEYTYPENAME")]
    public string FLDLASTSURVEYTYPENAME { get; set; }
    [DataMember(Name = "FLDLASTSURVEYDATE")]
    public string FLDLASTSURVEYDATE { get; set; }

    [DataMember(Name = "FLDSURVEYTYPENAME")]
    public string FLDSURVEYTYPENAME { get; set; }

    [DataMember(Name = "FLDDUEDATE")]
    public string FLDDUEDATE { get; set; }

    [DataMember(Name = "FLDWINDOWPERIODBEFORE")]
    public string FLDWINDOWPERIODBEFORE { get; set; }

    [DataMember(Name = "FLDWINDOWPERIODAFTER")]
    public string FLDWINDOWPERIODAFTER { get; set; }
    [DataMember(Name = "FLDPLANDATE")]
    public string FLDPLANDATE { get; set; }
    [DataMember(Name = "FLDSEAPORTNAME")]
    public string FLDSEAPORTNAME { get; set; }


    public static DashboardPanelModelCertificateSurveyDueList TranslateAsDashboardPanelModelCertificateSurveyDueList(DataRow dr)
    {
        var item = new DashboardPanelModelCertificateSurveyDueList();

        item.FLDCERTIFICATENAME = General.GetNullableString(dr["FLDCERTIFICATENAME"].ToString());
        item.FLDDATEOFISSUE = General.GetDateTimeToString(dr["FLDDATEOFISSUE"].ToString());
        item.FLDDATEOFEXPIRY = General.GetDateTimeToString(dr["FLDDATEOFEXPIRY"].ToString());
        item.FLDISSUINGAUTHORITYNAME = General.GetNullableString(dr["FLDISSUINGAUTHORITYNAME"].ToString());


        item.FLDLASTSURVEYTYPENAME = General.GetNullableString(dr["FLDLASTSURVEYTYPENAME"].ToString());
        item.FLDLASTSURVEYDATE = General.GetDateTimeToString(dr["FLDLASTSURVEYDATE"].ToString());

        item.FLDSURVEYTYPENAME = General.GetNullableString(dr["FLDSURVEYTYPENAME"].ToString());
        item.FLDDUEDATE = General.GetDateTimeToString(dr["FLDDUEDATE"].ToString());
        item.FLDWINDOWPERIODBEFORE = General.GetDateTimeToString(dr["FLDWINDOWPERIODBEFORE"].ToString());
        item.FLDWINDOWPERIODAFTER = General.GetDateTimeToString(dr["FLDWINDOWPERIODAFTER"].ToString());

        item.FLDPLANDATE = General.GetDateTimeToString(dr["FLDPLANDATE"].ToString());
        item.FLDSEAPORTNAME = General.GetNullableString(dr["FLDSEAPORTNAME"].ToString());




        return item;
    }


    public static List<DashboardPanelModelCertificateSurveyDueList> TranslateAsDashboardPanelModelCertificateSurveyDueList(DataTable dt)
    {
        var list = new List<DashboardPanelModelCertificateSurveyDueList>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelCertificateSurveyDueList(dr));
        }
        return list;
    }
}





public class DashboardPanelModelAuditAndInspectionTask
{
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }  
    [DataMember(Name = "FLDOVERDUE")]
    public int? FLDOVERDUE { get; set; }
    [DataMember(Name = "FLD15DAYS")]
    public int? FLD15DAYS { get; set; }
    [DataMember(Name = "FLDPENDINGCLOSURE")]
    public int? FLDPENDINGCLOSURE { get; set; }
    [DataMember(Name = "FLDEXTNREQ")]
    public int? FLDEXTNREQ { get; set; }
    [DataMember(Name = "FLD2PENDINGAPPROVAL")]
    public int? FLD2PENDINGAPPROVAL { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }

    public static DashboardPanelModelAuditAndInspectionTask TranslateAsDashboardPanelModelAuditAndInspectionTask(DataRow dr)
    {
        var item = new DashboardPanelModelAuditAndInspectionTask();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDOVERDUE = General.GetNullableInteger(dr["FLDOVERDUE"].ToString());
        item.FLD15DAYS = General.GetNullableInteger(dr["FLD15DAYS"].ToString());
        item.FLDPENDINGCLOSURE = General.GetNullableInteger(dr["FLDPENDINGCLOSURE"].ToString());
        item.FLDEXTNREQ = General.GetNullableInteger(dr["FLDEXTNREQ"].ToString());
        item.FLD2PENDINGAPPROVAL = General.GetNullableInteger(dr["FLD2PENDINGAPPROVAL"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }


    public static List<DashboardPanelModelAuditAndInspectionTask> TranslateAsDashboardPanelModelAuditAndInspectionTask(DataTable dt)
    {
        var list = new List<DashboardPanelModelAuditAndInspectionTask>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelAuditAndInspectionTask(dr));
        }
        return list;
    }
}



public class DashboardPanelModelAuditAndInspection
{
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLD60DAY")]
    public int? FLD60DAY { get; set; }
    [DataMember(Name = "FLDOVERDUE")]
    public int? FLDOVERDUE { get; set; }
    [DataMember(Name = "FLDCOMPLETED")]
    public int? FLDCOMPLETED { get; set; }
    [DataMember(Name = "FLDREVIEWOVERDUE")]
    public int? FLDREVIEWOVERDUE { get; set; }
    [DataMember(Name = "FLDREVIEW")]
    public int? FLDREVIEW { get; set; }
    [DataMember(Name = "FLDCLOSUREOVERDUE")]
    public int? FLDCLOSUREOVERDUE { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }


    public static DashboardPanelModelAuditAndInspection TranslateAsDashboardPanelModelAuditAndInspection(DataRow dr)
    {
        var item = new DashboardPanelModelAuditAndInspection();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLD60DAY = General.GetNullableInteger(dr["FLD60DAY"].ToString());
        item.FLDOVERDUE = General.GetNullableInteger(dr["FLDOVERDUE"].ToString());
        item.FLDCOMPLETED = General.GetNullableInteger(dr["FLDCOMPLETED"].ToString());
        item.FLDREVIEWOVERDUE = General.GetNullableInteger(dr["FLDREVIEWOVERDUE"].ToString());
        item.FLDREVIEW = General.GetNullableInteger(dr["FLDREVIEW"].ToString());
        item.FLDCLOSUREOVERDUE = General.GetNullableInteger(dr["FLDCLOSUREOVERDUE"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }

    public static List<DashboardPanelModelAuditAndInspection> TranslateAsDashboardPanelModelAuditAndInspection(DataTable dt)
    {
        var list = new List<DashboardPanelModelAuditAndInspection>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelAuditAndInspection(dr));
        }
        return list;
    }
}



public class DashboardPanelModelOpenReports
{
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDOPEN")]
    public int? FLDOPEN { get; set; }
    [DataMember(Name = "FLDCOMPLETED")]
    public int? FLDCOMPLETED { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }


    public static DashboardPanelModelOpenReports TranslateAsDashboardPanelModelOpenReports(DataRow dr)
    {
        var item = new DashboardPanelModelOpenReports();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDOPEN = General.GetNullableInteger(dr["FLDOPEN"].ToString());
        item.FLDCOMPLETED = General.GetNullableInteger(dr["FLDCOMPLETED"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }
  
    public static List<DashboardPanelModelOpenReports> TranslateAsDashboardPanelModelOpenReports(DataTable dt)
    {
        var list = new List<DashboardPanelModelOpenReports>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelOpenReports(dr));
        }
        return list;
    }
}

[DataContract]
public class DashboardPanelModelPMS
{
 
    [DataMember(Name = "FLDMEASURE")]
    public string FLDMEASURE { get; set; }
    [DataMember(Name = "FLDCOUNT")]
    public int? FLDCOUNT { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }


    public static DashboardPanelModelPMS TranslateAsDashboardPanelModelPMS(DataRow dr)
    {
        var item = new DashboardPanelModelPMS();

        item.FLDMEASURE = General.GetNullableString(dr["FLDMEASURE"].ToString());
        item.FLDCOUNT = General.GetNullableInteger(dr["FLDCOUNT"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());


        return item;
    }
    public static List<DashboardPanelModelPMS> TranslateAsDashboardPanelModelPMSList(DataTable dt)
    {
        var list = new List<DashboardPanelModelPMS>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelPMS(dr));
        }
        return list;
    }
}

[DataContract]
public class DashboardPanelModelRiskMoc
{
  
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDCOUNT")]
    public int? FLDCOUNT { get; set; }

    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }


    public static DashboardPanelModelRiskMoc TranslateAsDashboardPanelModelRiskMoc(DataRow dr)
    {
        var item = new DashboardPanelModelRiskMoc();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDCOUNT = General.GetNullableInteger(dr["FLDCOUNT"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }
    public static List<DashboardPanelModelRiskMoc> TranslateAsDashboardPanelModelRiskMocList(DataTable dt)
    {
        var list = new List<DashboardPanelModelRiskMoc>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelRiskMoc(dr));
        }
        return list;
    }
}



[DataContract]
public class DashboardPanelModelRiskRa
{
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDPENDING")]
    public int? FLDPENDING { get; set; }
    [DataMember(Name = "FLDAPPROVED")]
    public int? FLDAPPROVED { get; set; }
    [DataMember(Name = "FLDEXPIRED")]
    public int? FLDEXPIRED { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }

//    FLDNAME
//    FLDPENDING
//FLDAPPROVED
//FLDEXPIRED

    public static DashboardPanelModelRiskRa TranslateAsDashboardPanelModelRiskRa(DataRow dr)
    {
        var item = new DashboardPanelModelRiskRa();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDPENDING = General.GetNullableInteger(dr["FLDPENDING"].ToString());
        item.FLDAPPROVED = General.GetNullableInteger(dr["FLDAPPROVED"].ToString());
        item.FLDEXPIRED = General.GetNullableInteger(dr["FLDEXPIRED"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());


        return item;
    }
    public static List<DashboardPanelModelRiskRa> TranslateAsDashboardPanelModelRiskRa(DataTable dt)
    {
        var list = new List<DashboardPanelModelRiskRa>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelRiskRa(dr));
        }
        return list;
    }
}


[DataContract]
public class DashboardPanelModelIncident
{

    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDNEW")]
    public string FLDNEW { get; set; }
    [DataMember(Name = "FLDOPEN")]
    public string FLDOPEN { get; set; }
    [DataMember(Name = "FLDREVIEW")]
    public string FLDREVIEW { get; set; }
    [DataMember(Name = "FLDCOMPLETED")]
    public string FLDCOMPLETED { get; set; }
    [DataMember(Name = "FLDPENDING")]
    public string FLDPENDING { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }

//    FLDNAME
//FLDNEW
//FLDOPEN
//FLDREVIEW
//FLDCOMPLETED
//FLDPENDING


    public static DashboardPanelModelIncident TranslateAsDashboardPanelModelIncident(DataRow dr)
    {
        var item = new DashboardPanelModelIncident();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDNEW = General.GetNullableString(dr["FLDNEW"].ToString());
        item.FLDOPEN = General.GetNullableString(dr["FLDOPEN"].ToString());
        item.FLDREVIEW = General.GetNullableString(dr["FLDREVIEW"].ToString());
        item.FLDCOMPLETED = General.GetNullableString(dr["FLDCOMPLETED"].ToString());
        item.FLDPENDING = General.GetNullableString(dr["FLDPENDING"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }

    public static List<DashboardPanelModelIncident> TranslateAsDashboardPanelModelIncidentList(DataTable dt)
    {
        var list = new List<DashboardPanelModelIncident>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsDashboardPanelModelIncident(dr));
        }
        return list;
    }
}



[DataContract]
public class cargoOperationsList
{
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDISNEW")]
    public string FLDISNEW { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }


    public static cargoOperationsList TranslateAscargoOperationsList(DataRow dr)
    {
        var item = new cargoOperationsList();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDISNEW = General.GetNullableString(dr["FLDISNEW"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }
    public static List<cargoOperationsList> TranslateAscargoOperationsList(DataTable dt)
    {
        var list = new List<cargoOperationsList>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAscargoOperationsList(dr));
        }
        return list;
    }
}



[DataContract]
public class TradingAreaList
{
   
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDISNEW")]
    public string FLDISNEW { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }

    public static TradingAreaList TranslateAsTradingAreaListOperationsList(DataRow dr)
    {
        var item = new TradingAreaList();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDISNEW = General.GetNullableString(dr["FLDISNEW"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }
    public static List<TradingAreaList> TranslateAsTradingAreaListOperationsList(DataTable dt)
    {
        var list = new List<TradingAreaList>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsTradingAreaListOperationsList(dr));
        }
        return list;
    }
}


[DataContract]
public class OthersOperationPanelList
{
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDCOUNT")]
    public string FLDCOUNT { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }




    public static OthersOperationPanelList TranslateAsOthersOperationPanelList(DataRow dr)
    {
        var item = new OthersOperationPanelList();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDCOUNT = General.GetNullableString(dr["FLDCOUNT"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }
    public static List<OthersOperationPanelList> TranslateAsOthersOperationPanelList(DataTable dt)
    {
        var list = new List<OthersOperationPanelList>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsOthersOperationPanelList(dr));
        }
        return list;
    }
}



[DataContract]
public class ManningAndDocumentsList
{
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDCOUNT")]
    public string FLDCOUNT { get; set; }
    [DataMember(Name = "FLDPANELCOLOUR")]
    public int? FLDPANELCOLOUR { get; set; }
    [DataMember(Name = "FLDROWCOLOUR")]
    public int? FLDROWCOLOUR { get; set; }

    public static ManningAndDocumentsList TranslateAsManningAndDocumentsPanelList(DataRow dr)
    {
        var item = new ManningAndDocumentsList();

        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDCOUNT = General.GetNullableString(dr["FLDCOUNT"].ToString());
        item.FLDPANELCOLOUR = General.GetNullableInteger(dr["FLDPANELCOLOUR"].ToString());
        item.FLDROWCOLOUR = General.GetNullableInteger(dr["FLDROWCOLOUR"].ToString());

        return item;
    }
    public static List<ManningAndDocumentsList> TranslateAsManningAndDocumentsPanelList(DataTable dt)
    {
        var list = new List<ManningAndDocumentsList>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsManningAndDocumentsPanelList(dr));
        }
        return list;
    }
}




[DataContract]
public class CrewChangesAndApproval
{
    [DataMember(Name = "id")]
    public string id { get; set; }
    [DataMember(Name = "FLDNAME")]
    public string FLDNAME { get; set; }
    [DataMember(Name = "FLDCOUNT")]
    public string FLDACTIONED { get; set; }


    public static CrewChangesAndApproval TranslateAsCrewChangesAndApprovalPanelList(DataRow dr)
    {
        var item = new CrewChangesAndApproval();

        item.id = General.GetNullableString(dr["FLDELEMENTID"].ToString());
        item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
        item.FLDACTIONED = General.GetNullableString(dr["FLDCOUNT"].ToString());

        return item;
    }
    public static List<CrewChangesAndApproval> TranslateAsCrewChangesAndApprovalPanelList(DataTable dt)
    {
        var list = new List<CrewChangesAndApproval>();
        foreach (DataRow dr in dt.Rows)
        {
            list.Add(TranslateAsCrewChangesAndApprovalPanelList(dr));
        }
        return list;
    }
}