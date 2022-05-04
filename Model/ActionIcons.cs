using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;
using SouthNests.PhoenixMobile.Translators;
using System.Web.UI;

namespace SouthNests.PhoenixMobile.Model
{


    [DataContract]
    public class crewList
    {
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "vesselid")]
        public int vesselid { get; set; }
        [DataMember(Name = "rankid")]
        public string rankid { get; set; }
        [DataMember(Name = "ondate")]
        public string ondate { get; set; }
        [DataMember(Name = "sailonly")]
        public int sailonly { get; set; }
        [DataMember(Name = "access")]
        public int access { get; set; }
        [DataMember(Name = "familyyn")]
        public string familyyn { get; set; }
        [DataMember(Name = "sortby")]
        public string sortby { get; set; }
        [DataMember(Name = "sortdirection")]
        public string sortdirection { get; set; }
        [DataMember(Name = "pagenumber")]
        public int? pagenumber { get; set; }
        [DataMember(Name = "pagesize")]
        public int? pagesize { get; set; }
        [DataMember(Name = "resultcount")]
        public int? resultcount { get; set; }
        [DataMember(Name = "totalpagecount")]
        public int? totalpagecount { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "nationality")]
        public string nationality { get; set; }
        [DataMember(Name = "extracrew")]
        public int? extracrew { get; set; }
        [DataMember(Name = "reliefduedate")]
        public int? reliefduedate { get; set; }
    }

    public class ActionCrewList
    {
        [DataMember(Name = "employeeid")]
        public string employeeid { get; set; }
        [DataMember(Name = "employeename")]
        public string employeename { get; set; }
        [DataMember(Name = "nationalityname")]
        public string nationalityname { get; set; }
        [DataMember(Name = "rankname")]
        public string rankname { get; set; }
        [DataMember(Name = "passportno")]
        public string passportno { get; set; }
        [DataMember(Name = "dateofbirth")]
        public string dateofbirth { get; set; }
        [DataMember(Name = "reliefduedate")]
        public string reliefduedate { get; set; }
        [DataMember(Name = "signondate")]
        public string signondate { get; set; }
        [DataMember(Name = "daysonboard")]
        public string daysonboard { get; set; }


        public static ActionCrewList TranslateAsActionCrewList(DataRow dr)
        {
            var item = new ActionCrewList();

            item.employeeid = General.GetNullableString(dr["FLDEMPLOYEEID"].ToString());
            item.employeename = General.GetNullableString(dr["FLDEMPLOYEENAME"].ToString());
            item.nationalityname = General.GetNullableString(dr["FLDNATIONALITYNAME"].ToString());
            item.rankname = General.GetNullableString(dr["FLDRANKNAME"].ToString());
            item.passportno = General.GetNullableString(dr["FLDPASSPORTNO"].ToString());
            item.dateofbirth = General.GetNullableString(dr["FLDDATEOFBIRTH"].ToString());
            item.reliefduedate = General.GetNullableString(dr["FLDRELIEFDUEDATE"].ToString());
            item.signondate = General.GetNullableString(dr["FLDSIGNONDATE"].ToString());
            item.daysonboard = General.GetNullableString(dr["FLDDAYSONBOARD"].ToString());


            return item;
        }


        public static List<ActionCrewList> TranslateAsActionCrewList(DataTable dt)
        {
            var list = new List<ActionCrewList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionCrewList(dr));
            }
            return list;
        }
    }
    [DataContract]
    public class EventList
    {

        [DataMember(Name = "vesselid")]
        public int vesselid { get; set; }
        [DataMember(Name = "eventfrom")]
        public string eventfrom { get; set; }
        [DataMember(Name = "eventto")]
        public string eventto { get; set; }
        [DataMember(Name = "portid")]
        public int? portid { get; set; }
        [DataMember(Name = "status")]
        public int? status { get; set; }
        [DataMember(Name = "sortby")]
        public string sortby { get; set; }
        [DataMember(Name = "sortdirection")]
        public string sortdirection { get; set; }
        [DataMember(Name = "pagenumber")]
        public int? pagenumber { get; set; }
        [DataMember(Name = "pagesize")]
        public int? pagesize { get; set; }
        [DataMember(Name = "resultcount")]
        public int? resultcount { get; set; }
        [DataMember(Name = "totalpagecount")]
        public int? totalpagecount { get; set; }
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "dashboardyn")]
        public int dashboardyn { get; set; }
    }

    public class ActionEventList
    {
        [DataMember(Name = "referencenumber")]
        public string referencenumber { get; set; }
        [DataMember(Name = "vesselname")]
        public string vesselname { get; set; }
        [DataMember(Name = "offsingercount")]
        public string offsingercount { get; set; }
        [DataMember(Name = "onsingercount")]
        public string onsingercount { get; set; }
        [DataMember(Name = "starting")]
        public string starting { get; set; }
        [DataMember(Name = "ending")]
        public string ending { get; set; }
        [DataMember(Name = "portname")]
        public string portname { get; set; }
        [DataMember(Name = "portagent")]
        public string portagent { get; set; }
        [DataMember(Name = "airportname")]
        public string airportname { get; set; }
        [DataMember(Name = "remarks")]
        public string remarks { get; set; }
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "createdon")]
        public string createdon { get; set; }
        [DataMember(Name = "createdby")]
        public string createdby { get; set; }
        [DataMember(Name = "modifiedon")]
        public string modifiedon { get; set; }
        [DataMember(Name = "modifiedby")]
        public string modifiedby { get; set; }


        public static ActionEventList TranslateAsActionEventList(DataRow dr)
        {
            var item = new ActionEventList();

            item.referencenumber = General.GetNullableString(dr["FLDREFERENCENO"].ToString());
            item.vesselname = General.GetNullableString(dr["FLDVESSELNAME"].ToString());
            item.offsingercount = General.GetNullableString(dr["FLDOFFSIGNERCOUNT"].ToString());
            item.onsingercount = General.GetNullableString(dr["FLDONSIGNERCOUNT"].ToString());
            item.starting = General.GetDateTimeToString(dr["FLDEVENTDATE"].ToString());
            item.ending = General.GetDateTimeToString(dr["FLDEVENTTODATE"].ToString());
            item.portname = General.GetNullableString(dr["FLDPORTNAME"].ToString());
            item.portagent = General.GetNullableString(dr["FLDPORTAGENTNAME"].ToString());
            item.airportname = General.GetNullableString(dr["FLDAIRPORTNAME"].ToString());
            item.remarks = General.GetNullableString(dr["FLDREMARKS"].ToString());
            item.status = General.GetNullableString(dr["FLDSTATUS"].ToString());
            item.createdon = General.GetDateTimeToString(dr["FLDCREATEDDATE"].ToString());
            item.createdby = General.GetNullableString(dr["FLDCREATEDBYNAME"].ToString());
            item.modifiedon = General.GetDateTimeToString(dr["FLDMODIFIEDDATE"].ToString());
            item.modifiedby = General.GetNullableString(dr["FLDMODIFIEDBYNAME"].ToString());



            return item;
        }


        public static List<ActionEventList> TranslateAsActionEventList(DataTable dt)
        {
            var list = new List<ActionEventList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionEventList(dr));
            }
            return list;
        }
    }

    [DataContract]
    public class StoresAndSparesList
    {

        [DataMember(Name = "vesselid")]
        public int vesselid { get; set; }
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
    }
    public class ActionStoresAndSparesList
    {
        [DataMember(Name = "typeName")]
        public string typeName { get; set; }
        [DataMember(Name = "count")]
        public int? count { get; set; }
        [DataMember(Name = "filter")]
        public string filter { get; set; }



        public static ActionStoresAndSparesList TranslateAsActionStoresAndSparesList(DataRow dr)
        {
            var item = new ActionStoresAndSparesList();

            item.typeName = General.GetNullableString(dr["FLDTYPENAME"].ToString());
            item.count = General.GetNullableInteger(dr["FLDCOUNT"].ToString());
            item.filter = General.GetNullableString(dr["FLDFILTER"].ToString());

            return item;
        }


        public static List<ActionStoresAndSparesList> TranslateAsActionStoresAndSparesList(DataTable dt)
        {
            var list = new List<ActionStoresAndSparesList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionStoresAndSparesList(dr));
            }
            return list;
        }
    }

    public class ActionAlertsAndCrewDocumentsList
    {
        [DataMember(Name = "fldmeasure")]
        public string fldmeasure { get; set; }
        [DataMember(Name = "overdue")]
        public string overdue { get; set; }
        [DataMember(Name = "day15")]
        public string day15 { get; set; }
        [DataMember(Name = "day45")]
        public string day45 { get; set; }



        public static ActionAlertsAndCrewDocumentsList TranslateAsActionAlertsAndCrewDocumentsList(DataRow dr)
        {
            var item = new ActionAlertsAndCrewDocumentsList();

            item.fldmeasure = General.GetNullableString(dr["FLDMEASURE"].ToString());
            item.overdue = General.GetNullableString(dr["FLDOVERDUECOUNT"].ToString());
            item.day15 = General.GetNullableString(dr["FLD15COUNT"].ToString());
            item.day45 = General.GetNullableString(dr["FLD45COUNT"].ToString());


            return item;
        }


        public static List<ActionAlertsAndCrewDocumentsList> TranslateAsActionAlertsAndCrewDocumentsList(DataTable dt)
        {
            var list = new List<ActionAlertsAndCrewDocumentsList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionAlertsAndCrewDocumentsList(dr));
            }
            return list;
        }
    }


    public class ActionMaintenanceAndOperationList
    {
        [DataMember(Name = "title")]
        public string title { get; set; }
        [DataMember(Name = "maintenance")]
        public string maintainance { get; set; }
        [DataMember(Name = "operation")]
        public string operation { get; set; }



        public static ActionMaintenanceAndOperationList TranslateAsActionMaintenanceAndOperationList(DataRow dr)
        {
            var item = new ActionMaintenanceAndOperationList();

            item.title = General.GetNullableString(dr["FLDTITLE"].ToString());
            item.maintainance = General.GetNullableString(dr["FLDMAINTENANCECOUNT"].ToString());
            item.operation = General.GetNullableString(dr["FLDOPERATIONCOUNT"].ToString());


            return item;
        }


        public static List<ActionMaintenanceAndOperationList> TranslateAsActionMaintenanceAndOperationList(DataTable dt)
        {
            var list = new List<ActionMaintenanceAndOperationList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionMaintenanceAndOperationList(dr));
            }
            return list;
        }
    }
    public class ActionOrdersAndInformationList
    {
        [DataMember(Name = "FLDTYPENAME")]
        public string FLDTYPENAME { get; set; }
        [DataMember(Name = "FLDCOUNT")]
        public string FLDCOUNT { get; set; }
        [DataMember(Name = "FLDOVERDUECOUNT")]
        public string FLDOVERDUECOUNT { get; set; }


        public static ActionOrdersAndInformationList TranslateAsActionOrdersAndInformationList(DataRow dr)
        {
            var item = new ActionOrdersAndInformationList();

            item.FLDTYPENAME = General.GetNullableString(dr["FLDTYPENAME"].ToString());
            item.FLDCOUNT = General.GetNullableString(dr["FLDCOUNT"].ToString());
            item.FLDOVERDUECOUNT = General.GetNullableString(dr["FLDOVERDUECOUNT"].ToString());


            return item;
        }


        public static List<ActionOrdersAndInformationList> TranslateAsActionOrdersAndInformationList(DataTable dt)
        {
            var list = new List<ActionOrdersAndInformationList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionOrdersAndInformationList(dr));
            }
            return list;
        }
    }

    public class ActionOrdersAndInformationListB
    {
        [DataMember(Name = "count")]
        public string count { get; set; }
        [DataMember(Name = "typeName")]
        public string typeName { get; set; }




        public static ActionOrdersAndInformationListB TranslateAsActionOrdersAndInformationListB(DataRow dr)
        {
            var item = new ActionOrdersAndInformationListB();

            item.count = General.GetNullableString(dr["FLDVESSELUNREADCOUNT"].ToString());
            item.typeName = "Unread User List" ;

            return item;
        }


        public static List<ActionOrdersAndInformationListB> TranslateAsActionOrdersAndInformationListB(DataTable dt)
        {
            var list = new List<ActionOrdersAndInformationListB>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionOrdersAndInformationListB(dr));
            }
            return list;
        }
    }

    public class PMSList
    {
        [DataMember(Name = "measureCode")]
        public string measureCode { get; set; }
        [DataMember(Name = "measureName")]
        public string measureName { get; set; }
        [DataMember(Name = "count")]
        public string count { get; set; }




        public static PMSList TranslateAsActionPMSList(DataRow dr)
        {
            var item = new PMSList();

            item.measureCode = General.GetNullableString(dr["FLDMEASURECODE"].ToString());
            item.measureName = General.GetNullableString(dr["FLDMEASURE"].ToString());
            item.count = General.GetNullableString(dr["FLDCOUNT"].ToString());


            return item;
        }


        public static List<PMSList> TranslateAsActionPMSList(DataTable dt)
        {
            var list = new List<PMSList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionPMSList(dr));
            }
            return list;
        }
    }

    public class WorkAndRestHoursList
    {
        [DataMember(Name = "measureName")]
        public string measureName { get; set; }
        [DataMember(Name = "seafarercount")]
        public string seafarercount { get; set; }
        [DataMember(Name = "hodcount")]
        public string hodcount { get; set; }
        [DataMember(Name = "mastercount")]
        public string mastercount { get; set; }




        public static WorkAndRestHoursList TranslateAsActionWorkAndRestHoursList(DataRow dr)
        {
            var item = new WorkAndRestHoursList();

            item.measureName = General.GetNullableString(dr["FLDMEASURENAME"].ToString());
            item.seafarercount = General.GetNullableString(dr["FLDSEAFARERCOUNT"].ToString());
            item.hodcount = General.GetNullableString(dr["FLDHODCOUNT"].ToString());
            item.mastercount = General.GetNullableString(dr["FLDMASTERCOUNT"].ToString());



            return item;
        }


        public static List<WorkAndRestHoursList> TranslateAsActionWorkAndRestHoursList(DataTable dt)
        {
            var list = new List<WorkAndRestHoursList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionWorkAndRestHoursList(dr));
            }
            return list;
        }
    }

    public class WorkAndRestHoursListB
    {
        [DataMember(Name = "measureName")]
        public string measureName { get; set; }
        [DataMember(Name = "count")]
        public string count { get; set; }


        public static WorkAndRestHoursListB TranslateAsActionWorkAndRestHoursListB(DataRow dr)
        {
            var item = new WorkAndRestHoursListB();

            item.measureName = General.GetNullableString(dr["FLDMEASURE"].ToString());
            item.count = General.GetNullableString(dr["FLDCOUNT"].ToString());

            return item;
        }

        public static List<WorkAndRestHoursListB> TranslateAsActionWorkAndRestHoursListB(DataTable dt)
        {
            var list = new List<WorkAndRestHoursListB>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionWorkAndRestHoursListB(dr));
            }
            return list;
        }
    }

    public class DefectsAndNonRoutineList
    {
        [DataMember(Name = "FLDMEASURE")]
        public string FLDMEASURE { get; set; }
        [DataMember(Name = "FLDCOUNT")]
        public string FLDCOUNT { get; set; }


        public static DefectsAndNonRoutineList TranslateAsActionDefectsAndNonRoutineList(DataRow dr)
        {
            var item = new DefectsAndNonRoutineList();

            item.FLDMEASURE = General.GetNullableString(dr["FLDMEASURE"].ToString());
            item.FLDCOUNT = General.GetNullableString(dr["FLDCOUNT"].ToString());

            return item;
        }

        public static List<DefectsAndNonRoutineList> TranslateAsActionDefectsAndNonRoutineList(DataTable dt)
        {
            var list = new List<DefectsAndNonRoutineList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionDefectsAndNonRoutineList(dr));
            }
            return list;
        }
    }
    [DataContract]
    public class Timesheet
    {
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "vesselid")]
        public int vesselid { get; set; }
        [DataMember(Name = "fromdate")]
        public string fromdate { get; set; }
        [DataMember(Name = "todate")]
        public string todate { get; set; }
        [DataMember(Name = "operation")]
        public int? operation { get; set; }
        [DataMember(Name = "vesselstatus")]
        public int? vesselstatus { get; set; }
        [DataMember(Name = "source")]
        public string source { get; set; }
        [DataMember(Name = "enteredby")]
        public string enteredby { get; set; }
        [DataMember(Name = "sortby")]
        public string sortby { get; set; }
        [DataMember(Name = "sortdirection")]
        public string sortdirection { get; set; }
        [DataMember(Name = "pagenumber")]
        public int? pagenumber { get; set; }
        [DataMember(Name = "pagesize")]
        public int? pagesize { get; set; }
        [DataMember(Name = "resultcount")]
        public int? resultcount { get; set; }
        [DataMember(Name = "totalpagecount")]
        public int? totalpagecount { get; set; }

    }

    public class TimeSheetList
    {
        [DataMember(Name = "FLDVESSELSTATUSNAME")]
        public string FLDVESSELSTATUSNAME { get; set; }
        [DataMember(Name = "FLDOPERATION")]
        public string FLDOPERATION { get; set; }
        [DataMember(Name = "FLDDATETIME")]
        public string FLDDATETIME { get; set; }
        [DataMember(Name = "FLDDETAIL")]
        public string FLDDETAIL { get; set; }





        public static TimeSheetList TranslateAsActionTimeSheetList(DataRow dr)
        {
            var item = new TimeSheetList();

            item.FLDVESSELSTATUSNAME = General.GetNullableString(dr["FLDVESSELSTATUSNAME"].ToString());
            item.FLDOPERATION = General.GetNullableString(dr["FLDOPERATION"].ToString());
            item.FLDDATETIME = General.GetNullableString(dr["FLDDATETIME"].ToString());
            item.FLDDETAIL = General.GetNullableString(dr["FLDDETAIL"].ToString());




            return item;
        }


        public static List<TimeSheetList> TranslateAsActionTimeSheetList(DataTable dt)
        {
            var list = new List<TimeSheetList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionTimeSheetList(dr));
            }
            return list;
        }
    }


    [DataContract]
    public class PersonnelOnDutyList
    {
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "vesselid")]
        public int vesselid { get; set; }
        [DataMember(Name = "date")]
        public int date { get; set; }
        [DataMember(Name = "reportinghour")]
        public int reportinghour { get; set; }
    }


    public class ActionPersonnelOnDutyList
    {
        [DataMember(Name = "FLDMEASURENAME")]
        public string FLDMEASURENAME { get; set; }
        [DataMember(Name = "FLDSEAFARERCOUNT")]
        public string FLDSEAFARERCOUNT { get; set; }
        [DataMember(Name = "FLDHODCOUNT")]
        public string FLDHODCOUNT { get; set; }
        [DataMember(Name = "FLDMASTERCOUNT")]
        public string FLDMASTERCOUNT { get; set; }



        public static ActionPersonnelOnDutyList TranslateAsActionPersonnelOnDutyList(DataRow dr)
        {
            var item = new ActionPersonnelOnDutyList();

            item.FLDMEASURENAME = General.GetNullableString(dr["FLDMEASURENAME"].ToString());
            item.FLDSEAFARERCOUNT = General.GetNullableString(dr["FLDSEAFARERCOUNT"].ToString());
            item.FLDHODCOUNT = General.GetNullableString(dr["FLDHODCOUNT"].ToString());
            item.FLDMASTERCOUNT = General.GetNullableString(dr["FLDMASTERCOUNT"].ToString());

            return item;
        }


        public static List<ActionPersonnelOnDutyList> TranslateAsActionPersonnelOnDutyList(DataTable dt)
        {
            var list = new List<ActionPersonnelOnDutyList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsActionPersonnelOnDutyList(dr));
            }
            return list;
        }
    }


    public class NearMissList
    {
        [DataMember(Name = "unsafeactnew")]
        public string unsafeactnew { get; set; }
        [DataMember(Name = "unsafeactpending")]
        public string unsafeactpending { get; set; }
        [DataMember(Name = "nearmissnew")]
        public string nearmissnew { get; set; }
        [DataMember(Name = "nearmisspending")]
        public string nearmisspending { get; set; }
        [DataMember(Name = "accidentsnew")]
        public string accidentsnew { get; set; }
        [DataMember(Name = "accidentspending")]
        public string accidentspending { get; set; }





        public static NearMissList TranslateAsNearMissList(DataSet ds)
        {
            var item = new NearMissList();

            item.unsafeactnew = General.GetNullableString(ds.Tables[0].Rows[0]["FLDUNSAFEACTNEW"].ToString());
            item.unsafeactpending = General.GetNullableString(ds.Tables[0].Rows[0]["FLDUNSAFEACTPENDING"].ToString());
            item.nearmissnew = General.GetNullableString(ds.Tables[1].Rows[0]["FLDNEARMISSNEW"].ToString());
            item.nearmisspending = General.GetNullableString(ds.Tables[1].Rows[0]["FLDNEARMISSPENDING"].ToString());
            item.accidentsnew = General.GetNullableString(ds.Tables[1].Rows[0]["FLDACCIDENTNEW"].ToString());
            item.accidentspending = General.GetNullableString(ds.Tables[1].Rows[0]["FLDACCIDENTPENDING"].ToString());


            return item;
        }


        //public static List<NearMissList> TranslateAsNearMissList(DataTable dt)
        //{
        //    var list = new List<NearMissList>();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        list.Add(TranslateAsNearMissList(ds));
        //    }
        //    return list;
        //}

    }



    public class DashboardForm
    {

        [DataMember(Name = "measurename")]
        public string measurename { get; set; }
        [DataMember(Name = "requiredcount")]
        public string requiredcount { get; set; }
        [DataMember(Name = "requiredurl")]
        public string requiredurl { get; set; }
        [DataMember(Name = "inusecount")]
        public string inusecount { get; set; }
        [DataMember(Name = "pendingapprovalcount")]
        public string pendingapprovalcount { get; set; }
        [DataMember(Name = "pendingapprovalurl")]
        public string pendingapprovalurl { get; set; }
        [DataMember(Name = "approvedcount")]
        public string approvedcount { get; set; }
        [DataMember(Name = "approvedurl")]
        public string approvedurl { get; set; }
        [DataMember(Name = "expiredcount")]
        public string expiredcount { get; set; }
        [DataMember(Name = "expiredurl")]
        public string expiredurl { get; set; }



        public static DashboardForm TranslateAsWorkPermitsAndNonRoutineRAs(DataRow dr)
        {
            var item = new DashboardForm();

            item.measurename = General.GetNullableString(dr["FLDMEASURENAME"].ToString());
            item.requiredcount = General.GetNullableString(dr["FLDREQUIREDCOUNT"].ToString());
            item.requiredurl = General.GetNullableString(dr["FLDREQUIREDURL"].ToString());
            item.inusecount = General.GetNullableString(dr["FLDINUSECOUNT"].ToString());
            item.pendingapprovalcount = General.GetNullableString(dr["FLDPENDINGAPPROVALCOUNT"].ToString());
            item.pendingapprovalurl = General.GetNullableString(dr["FLDPENDINGAPPROVALURL"].ToString());
            item.approvedcount = General.GetNullableString(dr["FLDAPPROVEDCOUNT"].ToString());
            item.approvedurl = General.GetNullableString(dr["FLDAPPROVEDURL"].ToString());
            item.expiredcount = General.GetNullableString(dr["FLDEXPIREDCOUNT"].ToString());
            item.expiredurl = General.GetNullableString(dr["FLDEXPIREDURL"].ToString());

            return item;
        }

        public static List<DashboardForm> TranslateAsWorkPermitsAndNonRoutineRAs(DataTable dt)
        {
            var list = new List<DashboardForm>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsWorkPermitsAndNonRoutineRAs(dr));
            }
            return list;
        }
    }

    public class FormsRA
    {
        public static List<DashboardForm> GetFormsRA(StoresAndSparesList item)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FLDMEASURENAME");
            dt.Columns.Add("FLDREQUIREDCOUNT");
            dt.Columns.Add("FLDREQUIREDURL");
            dt.Columns.Add("FLDINUSECOUNT");
            dt.Columns.Add("FLDINUSEURL");
            dt.Columns.Add("FLDPENDINGAPPROVALCOUNT");
            dt.Columns.Add("FLDPENDINGAPPROVALURL");
            dt.Columns.Add("FLDAPPROVEDCOUNT");
            dt.Columns.Add("FLDAPPROVEDURL");
            dt.Columns.Add("FLDEXPIREDCOUNT");
            dt.Columns.Add("FLDEXPIREDURL");
            DataRow dr = dt.NewRow();
            dr["FLDMEASURENAME"] = "Non Routine RAs";
            int iRowCount = 0;
            int iTotalPageCount = 0;
            PhoenixMobileActionTranslator.DashboardNonRoutineRASearch(item.vesselid, DateTime.Now.AddDays(7)
                                            , string.Empty, null
                                            , 1
                                            , 10
                                            , ref iRowCount
                                            , ref iTotalPageCount);
            dr["FLDREQUIREDCOUNT"] = iRowCount;
            dr["FLDREQUIREDURL"] = "/Dashboard/DashboardTechnicalRA.aspx";
            DataTable result = PhoenixMobileActionTranslator.DashboardNonRoutineRAStatusCount(item.vesselid, DateTime.Now.AddDays(7));
            DataRow resultdr = result.Rows[0];
            dr["FLDINUSECOUNT"] = resultdr["FLDDRAFTCOUNT"].ToString();
            dr["FLDINUSEURL"] = "/Dashboard/DashboardTechnicalRAStatus.aspx?c=DRT";
            dr["FLDPENDINGAPPROVALCOUNT"] = resultdr["FLDPENDINGCOUNT"].ToString();
            dr["FLDPENDINGAPPROVALURL"] = "/Dashboard/DashboardTechnicalRAStatus.aspx?c=POC";
            dr["FLDAPPROVEDCOUNT"] = resultdr["FLDAPPROVEDCOUNT"].ToString();
            dr["FLDAPPROVEDURL"] = "/Dashboard/DashboardTechnicalRAStatus.aspx?c=AFU";
            dr["FLDEXPIREDCOUNT"] = resultdr["FLDEXPIREDCOUNT"].ToString();
            dr["FLDEXPIREDURL"] = "/Dashboard/DashboardTechnicalRAStatus.aspx?c=EXP";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["FLDMEASURENAME"] = "Work Permits";
            PhoenixMobileActionTranslator.DashboardPTWDueSearch(item.vesselid, DateTime.Now.AddDays(7)
                                            , null, null
                                            , 1
                                            , 10
                                            , ref iRowCount
                                            , ref iTotalPageCount);
            dr["FLDREQUIREDCOUNT"] = iRowCount;
            dr["FLDREQUIREDURL"] = "/Dashboard/DashboardTechnicalPTWDue.aspx";
            PhoenixMobileActionTranslator.DashboardPTWStatusSearch(item.vesselid, DateTime.Now.AddDays(7), "1,4,7"
                , null, null, 1, 10, ref iRowCount, ref iTotalPageCount);
            dr["FLDINUSECOUNT"] = iRowCount;
            dr["FLDINUSEURL"] = "/Dashboard/DashboardTechnicalPTWStatus.aspx?s=1,4,7";
            PhoenixMobileActionTranslator.DashboardPTWStatusSearch(item.vesselid, DateTime.Now.AddDays(7), "8"
               , null, null, 1, 10, ref iRowCount, ref iTotalPageCount);
            dr["FLDPENDINGAPPROVALCOUNT"] = iRowCount;
            dr["FLDPENDINGAPPROVALURL"] = "/Dashboard/DashboardTechnicalPTWStatus.aspx?s=8";
            dr["FLDAPPROVEDCOUNT"] = iRowCount;
            dr["FLDAPPROVEDURL"] = "/Dashboard/DashboardTechnicalPTWStatus.aspx?s=8";

            PhoenixMobileActionTranslator.DashboardPTWStatusSearch(item.vesselid, DateTime.Now.AddDays(7), "5"
               , null, null, 1, 10, ref iRowCount, ref iTotalPageCount);
            dr["FLDEXPIREDCOUNT"] = iRowCount;
            dr["FLDEXPIREDURL"] = "/Dashboard/DashboardTechnicalPTWStatus.aspx?s=5";

            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["FLDMEASURENAME"] = "Checklists & Forms";
            result = PhoenixMobileActionTranslator.DashboardFormCheckListDue(item.vesselid);
            dr["FLDREQUIREDCOUNT"] = result.Rows.Count;
            dr["FLDREQUIREDURL"] = "/Dashboard/DashboardTechnicalDMFForms.aspx";
            result = PhoenixMobileActionTranslator.DashboardFormCheckListStatusList(item.vesselid, "INUSE");
            dr["FLDINUSECOUNT"] = result.Rows.Count.ToString();
            dr["FLDINUSEURL"] = "/Dashboard/DashboardTechnicalDMFForms.aspx?s=INUSE";
            result = PhoenixMobileActionTranslator.DashboardFormCheckListStatusList(item.vesselid, "APPROVAL");
            dr["FLDPENDINGAPPROVALCOUNT"] = result.Rows.Count.ToString();
            dr["FLDPENDINGAPPROVALURL"] = "/Dashboard/DashboardTechnicalDMFForms.aspx?s=APPROVAL";
            dt.Rows.Add(dr);

            return DashboardForm.TranslateAsWorkPermitsAndNonRoutineRAs(dt);
        }

    }


    [DataContract]
    public class ReliefPlan
    {

        [DataMember(Name = "vesselid")]
        public string vesselid { get; set; }
        [DataMember(Name = "pagenumber")]
        public int? pagenumber { get; set; }
        [DataMember(Name = "pagesize")]
        public int? pagesize { get; set; }
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "shownotapplicable")]
        public int shownotapplicable { get; set; }
        [DataMember(Name = "days")]
        public int days { get; set; }
        [DataMember(Name = "resultcount")]
        public int? resultcount { get; set; }
        [DataMember(Name = "totalpagecount")]
        public int? totalpagecount { get; set; }
    }



    [DataContract]
    public class ReliefPLanAlertList
    {
        [DataMember(Name = "mstAndCePlanned")]
        public string mstAndCePlanned { get; set; }
        [DataMember(Name = "mstAndCoPlanned")]
        public string mstAndCoPlanned { get; set; }
        [DataMember(Name = "ceAnd2ePlanned")]
        public string ceAnd2ePlanned { get; set; }
        [DataMember(Name = "plannedDeckOfficers")]
        public string plannedDeckOfficers { get; set; }
        [DataMember(Name = "plannedEngineOfficers")]
        public string plannedEngineOfficers { get; set; }
        [DataMember(Name = "totalCrewPlanned")]
        public string totalCrewPlanned { get; set; }





        public static ReliefPLanAlertList TranslateAsReliefPLanAlertList(DataRow dr)
        {
            var item = new ReliefPLanAlertList();

            item.mstAndCePlanned = General.GetNullableString(dr["FLDMSTANDCEYN"].ToString());
            item.mstAndCoPlanned = General.GetNullableString(dr["FLDMSTANDCOYN"].ToString());
            item.ceAnd2ePlanned = General.GetNullableString(dr["FLDCEAND2EYN"].ToString());
            item.plannedDeckOfficers = General.GetNullableString(dr["FLDDECKOFFICERPLANNEDPRS"].ToString());
            item.plannedEngineOfficers = General.GetNullableString(dr["FLDENGINEOFFICEPLANNEDPRS"].ToString());
            item.totalCrewPlanned = General.GetNullableString(dr["FLDTOTALPLANEDCREWPRS"].ToString());

            return item;
        }


        public static List<ReliefPLanAlertList> TranslateAsReliefPLanAlertList(DataTable dt)
        {
            var list = new List<ReliefPLanAlertList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsReliefPLanAlertList(dr));
            }
            return list;
        }
    }




    public class ReliefPlanCurrentPlannedList
    {
        [DataMember(Name = "employeeid")]
        public string employeeid { get; set; }
        [DataMember(Name = "offsignereventrefno")]
        public string offsignereventrefno { get; set; }
        [DataMember(Name = "rankname")]
        public string rankname { get; set; }
        [DataMember(Name = "employeeename")]
        public string employeeename { get; set; }
        [DataMember(Name = "nationality")]
        public string nationality { get; set; }
        [DataMember(Name = "reliefduedate")]
        public string reliefduedate { get; set; }
        [DataMember(Name = "joindate")]
        public string joindate { get; set; }
        [DataMember(Name = "daysonboard")]
        public string daysonboard { get; set; }

        [DataMember(Name = "relivername")]
        public string relivername { get; set; }
        [DataMember(Name = "reliverid")]
        public string reliverid { get; set; }
        [DataMember(Name = "relivernationality")]
        public string relivernationality { get; set; }
        [DataMember(Name = "reliverrank")]
        public string reliverrank { get; set; }
        [DataMember(Name = "totalamount")]
        public string totalamount { get; set; }
        [DataMember(Name = "releiverexpectedjoindate")]
        public string releiverexpectedjoindate { get; set; }
        [DataMember(Name = "releiverseaportname")]
        public string releiverseaportname { get; set; }
        [DataMember(Name = "releivernextstage")]
        public string releivernextstage { get; set; }
        [DataMember(Name = "reliveremployeestatus")]
        public string reliveremployeestatus { get; set; }






        public static ReliefPlanCurrentPlannedList TranslateAsReliefPlanCurrentPlannedList(DataRow dr)
        {
            var item = new ReliefPlanCurrentPlannedList();
            item.employeeid = General.GetNullableString(dr["FLDEMPLOYEEID"].ToString());
            item.offsignereventrefno = General.GetNullableString(dr["FLDOFFSIGNEREVENTREFERENCENO"].ToString());
            item.rankname = General.GetNullableString(dr["FLDRANKNAME"].ToString());
            item.employeeename = General.GetNullableString(dr["FLDNAME"].ToString());
            item.nationality = General.GetNullableString(dr["FLDOFFSIGNERNATIONALITY"].ToString());
            item.reliefduedate = General.GetDateTimeToString(dr["FLDRELIEFDUEDATE"].ToString());
            item.joindate = General.GetDateTimeToString(dr["FLDOFFSIGNERJOINDATE"].ToString());
            item.daysonboard = General.GetNullableString(dr["FLDDAYSONBOARD"].ToString());
            item.relivername = General.GetNullableString(dr["FLDRELIEVERNAME"].ToString());
            item.reliverid = General.GetNullableString(dr["FLDRELIEVERID"].ToString());
            item.relivernationality = General.GetNullableString(dr["FLDRELIEVERNATIONALITY"].ToString());
            item.reliverrank = General.GetNullableString(dr["FLDRELIEVERRANK"].ToString());
            item.totalamount = General.GetNullableString(dr["FLDTOTALAMOUNT"].ToString());
            item.releiverexpectedjoindate = General.GetDateTimeToString(dr["FLDEXPECTEDJOINDATE"].ToString());
            item.releiverseaportname = General.GetNullableString(dr["FLDSEAPORTNAME"].ToString());
            item.releivernextstage = General.GetNullableString(dr["FLDNEXTSTAGE"].ToString());
            item.reliveremployeestatus = General.GetNullableString(dr["FLDEMPLOYEESTATUS"].ToString());


            return item;
        }


        public static List<ReliefPlanCurrentPlannedList> TranslateAsReliefPlanCurrentPlannedList(DataTable dt)
        {
            var list = new List<ReliefPlanCurrentPlannedList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsReliefPlanCurrentPlannedList(dr));
            }
            return list;
        }
    }





    public class CertificatesList
    {
        [DataMember(Name = "certificatename")]
        public string certificatename { get; set; }
        [DataMember(Name = "certificatecode")]
        public string certificatecode { get; set; }
        [DataMember(Name = "dateofissue")]
        public string dateofissue { get; set; }
        [DataMember(Name = "dateofexpiry")]
        public string dateofexpiry { get; set; }
        [DataMember(Name = "issuedby")]
        public string issuedby { get; set; }
        [DataMember(Name = "seaportname")]
        public string seaportname { get; set; }
        [DataMember(Name = "planneddate")]
        public string planneddate { get; set; }
        [DataMember(Name = "isverified")]
        public string isverified { get; set; }
        [DataMember(Name = "windowrange")]
        public string windowrange { get; set; }
        [DataMember(Name = "nextsurveydue")]
        public string nextsurveydue { get; set; }
        [DataMember(Name = "nextsurveytype")]
        public string nextsurveytype { get; set; }
        [DataMember(Name = "lastsurveytype")]
        public string lastsurveytype { get; set; }
        [DataMember(Name = "lastsurveydate")]
        public string lastsurveydate { get; set; }




        public static CertificatesList TranslateAsCertificatesList(DataRow dr)
        {
            var item = new CertificatesList();

            item.certificatename = General.GetNullableString(dr["FLDCERTIFICATENAME"].ToString());
            item.certificatecode = General.GetNullableString(dr["FLDCERTIFICATECODE"].ToString());
            item.dateofissue = General.GetDateTimeToString(dr["FLDDATEOFISSUE"].ToString());
            item.dateofexpiry = General.GetDateTimeToString(dr["FLDDATEOFEXPIRY"].ToString());
            item.issuedby = General.GetNullableString(dr["FLDISSUINGAUTHORITYNAME"].ToString());
            item.seaportname = General.GetNullableString(dr["FLDSEAPORTNAME"].ToString());
            item.planneddate = General.GetDateTimeToString(dr["FLDPLANDATE"].ToString());
            item.isverified = General.GetNullableString(dr["FLDVERIFIEDYN"].ToString());
            item.windowrange = General.GetNullableString(dr["FLDWINDOWRANGE"].ToString());
            item.nextsurveydue =  General.GetDateTimeToString(dr["FLDNEXTDUEDATE"].ToString());
            item.nextsurveytype =  General.GetDateTimeToString(dr["FLDSURVEYTYPENAME"].ToString());
            item.lastsurveytype =  General.GetDateTimeToString(dr["FLDLASTSURVEYTYPENAME"].ToString());
            item.lastsurveydate =  General.GetDateTimeToString(dr["FLDLASTSURVEYDATE"].ToString());




            return item;
        }


        public static List<CertificatesList> TranslateAsCertificatesList(DataTable dt)
        {
            var list = new List<CertificatesList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsCertificatesList(dr));
            }
            return list;
        }
    }







    public class EfillingList
    {
        [DataMember(Name = "FLDFORMID")]
        public string FLDFORMID { get; set; }
        [DataMember(Name = "FLDFORMNAME")]
        public string FLDFORMNAME { get; set; }
        [DataMember(Name = "FLDMODEL")]
        public string FLDMODEL { get; set; }
        [DataMember(Name = "FLDLASTREPORTEDDATE")]
        public string FLDLASTREPORTEDDATE { get; set; }
 

        public static EfillingList TranslateAsEfillingList(DataRow dr)
        {
            var item = new EfillingList();

            item.FLDFORMID = General.GetNullableString(dr["FLDFORMID"].ToString());
            item.FLDFORMNAME = General.GetNullableString(dr["FLDFORMNAME"].ToString());
            item.FLDMODEL = General.GetNullableString(dr["FLDMODEL"].ToString());
            item.FLDLASTREPORTEDDATE = General.GetDateTimeToString(dr["FLDLASTREPORTEDDATE"].ToString());


            return item;
        }


        public static List<EfillingList> TranslateAsEfillingList(DataTable dt)
        {
            var list = new List<EfillingList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsEfillingList(dr));
            }
            return list;
        }
    }

    [DataContract]
    public class EfillingOfficeForms
    {

        [DataMember(Name = "vesselid")]
        public string vesselid { get; set; }
        [DataMember(Name = "pagenumber")]
        public int? pagenumber { get; set; }
        [DataMember(Name = "pagesize")]
        public int? pagesize { get; set; }
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "resultcount")]
        public int? resultcount { get; set; }
        [DataMember(Name = "totalpagecount")]
        public int? totalpagecount { get; set; }
        [DataMember(Name = "companyid")]
        public string companyid { get; set; }
        [DataMember(Name = "categoryid")]
        public string categoryid { get; set; }
    }

    public class EfillingOfficeFormsList
    {
        [DataMember(Name = "FLDFORMID")]
        public string FLDFORMID { get; set; }
        [DataMember(Name = "FLDCAPTION")]
        public string FLDCAPTION { get; set; }
        [DataMember(Name = "FLDFORMNO")]
        public string FLDFORMNO { get; set; }
        [DataMember(Name = "FLDTYPE")]
        public string FLDTYPE { get; set; }
        [DataMember(Name = "FLDACTIVEYN")]
        public string FLDACTIVEYN { get; set; }


        public static EfillingOfficeFormsList TranslateAsEfillingOfficeFormsList(DataRow dr)
        {
            var item = new EfillingOfficeFormsList();

            item.FLDFORMID = General.GetNullableString(dr["FLDFORMID"].ToString());
            item.FLDCAPTION = General.GetNullableString(dr["FLDCAPTION"].ToString());
            item.FLDFORMNO = General.GetNullableString(dr["FLDFORMNO"].ToString());
            item.FLDTYPE = General.GetNullableString(dr["FLDTYPE"].ToString());
            item.FLDACTIVEYN = General.GetNullableString(dr["FLDACTIVEYN"].ToString());


            return item;
        }


        public static List<EfillingOfficeFormsList> TranslateAsEfillingOfficeFormsList(DataTable dt)
        {
            var list = new List<EfillingOfficeFormsList>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsEfillingOfficeFormsList(dr));
            }
            return list;
        }
    }

}

