using SouthNests.Phoenix.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Model
{


    public class DashboardTechnicalMaintenanceScreenListModel
    {

        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDDEPARTMENT")]
        public string FLDDEPARTMENT { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDDATE")]
        public string FLDDATE { get; set; }
        [DataMember(Name = "FLDESTSTARTTIME")]
        public string FLDESTSTARTTIME { get; set; }
        [DataMember(Name = "FLDSTARTTIME")]
        public string FLDSTARTTIME { get; set; }
        [DataMember(Name = "FLDDURATION")]
        public string FLDDURATION { get; set; }
        [DataMember(Name = "FLDCOMPLETEDTIME")]
        public string FLDCOMPLETEDTIME { get; set; }
        [DataMember(Name = "FLDPERSONINCHARGENAME")]
        public string FLDPERSONINCHARGENAME { get; set; }
        [DataMember(Name = "FLDOTHERMEMBERSNAME")]
        public string FLDOTHERMEMBERSNAME { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }

        public static DashboardTechnicalMaintenanceScreenListModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardTechnicalMaintenanceScreenListModel();

            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDDEPARTMENT = General.GetNullableString(dr["FLDDEPARTMENT"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDDATE = General.GetDateTimeToString(dr["FLDDATE"].ToString());
            item.FLDESTSTARTTIME = General.GetNullableString(dr["FLDESTSTARTTIME"].ToString());
            item.FLDSTARTTIME = General.GetDateTimeToString(dr["FLDSTARTTIME"].ToString());
            item.FLDDURATION = General.GetNullableString(dr["FLDDURATION"].ToString());
            item.FLDCOMPLETEDTIME = General.GetNullableString(dr["FLDCOMPLETEDTIME"].ToString());
            item.FLDPERSONINCHARGENAME = General.GetNullableString(dr["FLDPERSONINCHARGENAME"].ToString());
            item.FLDOTHERMEMBERSNAME = General.GetNullableString(dr["FLDOTHERMEMBERSNAME"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());



            return item;
        }

        public static List<DashboardTechnicalMaintenanceScreenListModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardTechnicalMaintenanceScreenListModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class DashboardTechnicalOperationScreenListModel
    {

        [DataMember(Name = "FLDELEMENTNAME")]
        public string FLDELEMENTNAME { get; set; }
        [DataMember(Name = "FLDACTIVITYNAME")]
        public string FLDACTIVITYNAME { get; set; }
        [DataMember(Name = "FLDDATE")]
        public string FLDDATE { get; set; }
        [DataMember(Name = "FLDESTSTARTTIME")]
        public string FLDESTSTARTTIME { get; set; }
        [DataMember(Name = "FLDSTARTTIME")]
        public string FLDSTARTTIME { get; set; }
        [DataMember(Name = "FLDDURATION")]
        public string FLDDURATION { get; set; }
        [DataMember(Name = "FLDCOMPLETEDTIME")]
        public string FLDCOMPLETEDTIME { get; set; }
        [DataMember(Name = "FLDOTHERMEMBERSNAME")]
        public string FLDOTHERMEMBERSNAME { get; set; }
        [DataMember(Name = "FLDOPERATIONSTATUS")]
        public string FLDOPERATIONSTATUS { get; set; }
        [DataMember(Name = "FLDRANUMBER")]
        public string FLDRANUMBER { get; set; }


        //        FLDELEMENTNAME
        //FLDACTIVITYNAME
        //FLDDATE
        //FLDESTSTARTTIME
        //FLDSTARTTIME
        //FLDDURATION
        //FLDCOMPLETEDTIME
        //FLDOTHERMEMBERSNAME
        //FLDOPERATIONSTATUS
        //FLDRANUMBER

        public static DashboardTechnicalOperationScreenListModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardTechnicalOperationScreenListModel();

            item.FLDELEMENTNAME = General.GetNullableString(dr["FLDELEMENTNAME"].ToString());
            item.FLDACTIVITYNAME = General.GetNullableString(dr["FLDACTIVITYNAME"].ToString());
            item.FLDDATE = General.GetDateTimeToString(dr["FLDDATE"].ToString());
            item.FLDESTSTARTTIME = General.GetNullableString(dr["FLDESTSTARTTIME"].ToString());
            item.FLDSTARTTIME = General.GetDateTimeToString(dr["FLDSTARTTIME"].ToString());
            item.FLDDURATION = General.GetNullableString(dr["FLDDURATION"].ToString());
            item.FLDCOMPLETEDTIME = General.GetNullableString(dr["FLDCOMPLETEDTIME"].ToString());
            item.FLDOTHERMEMBERSNAME = General.GetNullableString(dr["FLDOTHERMEMBERSNAME"].ToString());
            item.FLDOPERATIONSTATUS = General.GetNullableString(dr["FLDOPERATIONSTATUS"].ToString());
            item.FLDRANUMBER = General.GetNullableString(dr["FLDRANUMBER"].ToString());



            return item;
        }

        public static List<DashboardTechnicalOperationScreenListModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardTechnicalOperationScreenListModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class PlannedMaintenanceOrderInformationModel
    {

        [DataMember(Name = "FLDDETAIL")]
        public string FLDDETAIL { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }
        [DataMember(Name = "FLDDATE")]
        public string FLDDATE { get; set; }
        [DataMember(Name = "FLDAPPLICABLETONAME")]
        public string FLDAPPLICABLETONAME { get; set; }
       

        public static PlannedMaintenanceOrderInformationModel TranslateAsAction(DataRow dr)
        {
            var item = new PlannedMaintenanceOrderInformationModel();

            item.FLDDETAIL = General.GetNullableString(dr["FLDDETAIL"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());
            item.FLDDATE = General.GetDateTimeToString(dr["FLDDATE"].ToString());
            item.FLDAPPLICABLETONAME = General.GetNullableString(dr["FLDAPPLICABLETONAME"].ToString());
     
            return item;
        }

        public static List<PlannedMaintenanceOrderInformationModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<PlannedMaintenanceOrderInformationModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class StoresandSparesDashoardScreenListModel
    {

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
        [DataMember(Name = "FLDBUGETCODE")]
        public string FLDBUGETCODE { get; set; }
        [DataMember(Name = "FLDSTOCKTYPE")]
        public string FLDSTOCKTYPE { get; set; }
        [DataMember(Name = "FLDREASONFORREQUISITIONNAME")]
        public string FLDREASONFORREQUISITIONNAME { get; set; }
        [DataMember(Name = "FLDSOURCENUMBER")]
        public string FLDSOURCENUMBER { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; } 
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
        [DataMember(Name = "FLDDELIVERYLOCATION")]
        public string FLDDELIVERYLOCATION { get; set; }
        [DataMember(Name = "FLDORDERREADINESSDATE")]
        public string FLDORDERREADINESSDATE { get; set; }
        [DataMember(Name = "FLDINVOICESUPPLIERREFERENCE")]
        public string FLDINVOICESUPPLIERREFERENCE { get; set; }
       
        public static StoresandSparesDashoardScreenListModel TranslateAsAction(DataRow dr)
        {
            var item = new StoresandSparesDashoardScreenListModel();

            item.FLDFORMNO = General.GetNullableString(dr["FLDFORMNO"].ToString());
            item.FLDTITLE = General.GetNullableString(dr["FLDTITLE"].ToString());
            item.FLDVENDORNAME = General.GetNullableString(dr["FLDVENDORNAME"].ToString());
            item.FLDFORMTYPENAME = General.GetNullableString(dr["FLDFORMTYPENAME"].ToString());
            item.FLDFORMSTATUSNAME = General.GetNullableString(dr["FLDFORMSTATUSNAME"].ToString());
            item.FLDBUGETCODE = General.GetNullableString(dr["FLDBUGETCODE"].ToString());
            item.FLDSTOCKTYPE = General.GetNullableString(dr["FLDSTOCKTYPE"].ToString());
            item.FLDREASONFORREQUISITIONNAME = General.GetNullableString(dr["FLDREASONFORREQUISITIONNAME"].ToString());
            item.FLDSOURCENUMBER = General.GetNullableString(dr["FLDSOURCENUMBER"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());
            item.FLDSUBACCOUNT = General.GetNullableString(dr["FLDSUBACCOUNT"].ToString());
            item.FLDPURCHASEAPPROVEDATE = General.GetNullableString(dr["FLDPURCHASEAPPROVEDATE"].ToString());
            item.FLDORDEREDDATE = General.GetNullableString(dr["FLDORDEREDDATE"].ToString());
            item.FLDVENDORDELIVERYDATE = General.GetNullableString(dr["FLDVENDORDELIVERYDATE"].ToString());
           item.FLDCOMMITTEDUSD = General.GetNullableString(dr["FLDCOMMITTEDUSD"].ToString());
            item.FLDDELIVERYLOCATION = General.GetNullableString(dr["FLDDELIVERYLOCATION"].ToString());
            item.FLDORDERREADINESSDATE = General.GetNullableString(dr["FLDORDERREADINESSDATE"].ToString());
            item.FLDINVOICESUPPLIERREFERENCE = General.GetNullableString(dr["FLDINVOICESUPPLIERREFERENCE"].ToString());

            return item;
        }

        public static List<StoresandSparesDashoardScreenListModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<StoresandSparesDashoardScreenListModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class DefectsAndNonRoutineJobsListModel
    {

        [DataMember(Name = "FLDDEFECTNO")]
        public string FLDDEFECTNO { get; set; }
        [DataMember(Name = "FLDCOMPONENTNUMBER")]
        public string FLDCOMPONENTNUMBER { get; set; }
        [DataMember(Name = "FLDCOMPONENTNAME")]
        public string FLDCOMPONENTNAME { get; set; }
        [DataMember(Name = "FLDDETAILS")]
        public string FLDDETAILS { get; set; }

        [DataMember(Name = "FLDSOURCENAME")]
        public string FLDSOURCENAME { get; set; }
        [DataMember(Name = "FLDPSCCODE")]
        public string FLDPSCCODE { get; set; }
        [DataMember(Name = "FLDVIQCODE")]
        public string FLDVIQCODE { get; set; }

        [DataMember(Name = "FLDCREATEDDATE")]
        public string FLDCREATEDDATE { get; set; }
        [DataMember(Name = "FLDRESPONSIBILITY")]
        public string FLDRESPONSIBILITY { get; set; }

        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }
        [DataMember(Name = "FLDJOBNO")]
        public string FLDJOBNO { get; set; }
        [DataMember(Name = "FLDWORKGROUPNO")]
        public string FLDWORKGROUPNO { get; set; }
        [DataMember(Name = "FLDTYPENAME")]
        public string FLDTYPENAME { get; set; }

        [DataMember(Name = "FLDAFFECTNAVIGATION")]
        public string FLDAFFECTNAVIGATION { get; set; }
        [DataMember(Name = "FLDDONEDATE")]
        public string FLDDONEDATE { get; set; }
        [DataMember(Name = "FLDSTATUSNAME")]
        public string FLDSTATUSNAME { get; set; }
       
        public static DefectsAndNonRoutineJobsListModel TranslateAsAction(DataRow dr)
        {
            var item = new DefectsAndNonRoutineJobsListModel();


            item.FLDDEFECTNO = General.GetNullableString(dr["FLDDEFECTNO"].ToString());
            item.FLDCOMPONENTNUMBER = General.GetNullableString(dr["FLDCOMPONENTNUMBER"].ToString());
            item.FLDCOMPONENTNAME = General.GetNullableString(dr["FLDCOMPONENTNAME"].ToString());
            item.FLDDETAILS = General.GetNullableString(dr["FLDDETAILS"].ToString());
            item.FLDSOURCENAME = General.GetNullableString(dr["FLDSOURCENAME"].ToString());
            item.FLDPSCCODE = General.GetNullableString(dr["FLDPSCCODE"].ToString());
            item.FLDVIQCODE = General.GetNullableString(dr["FLDVIQCODE"].ToString());
            item.FLDCREATEDDATE = General.GetNullableString(dr["FLDCREATEDDATE"].ToString());
            item.FLDRESPONSIBILITY = General.GetNullableString(dr["FLDRESPONSIBILITY"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetNullableString(dr["FLDPLANNINGDUEDATE"].ToString());
            item.FLDJOBNO = General.GetNullableString(dr["FLDJOBNO"].ToString());
            item.FLDWORKGROUPNO = General.GetNullableString(dr["FLDWORKGROUPNO"].ToString());
            item.FLDTYPENAME = General.GetNullableString(dr["FLDTYPENAME"].ToString());
            item.FLDAFFECTNAVIGATION = General.GetNullableString(dr["FLDAFFECTNAVIGATION"].ToString());
            item.FLDDONEDATE = General.GetNullableString(dr["FLDDONEDATE"].ToString());
            item.FLDSTATUSNAME = General.GetNullableString(dr["FLDSTATUSNAME"].ToString());


            return item;
        }

        public static List<DefectsAndNonRoutineJobsListModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DefectsAndNonRoutineJobsListModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class ShipboardTasksInAlertAndCrewDocumentsDashboardModel
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
        [DataMember(Name = "FLDTASK")]
        public string FLDTASK { get; set; }
        [DataMember(Name = "FLDTARGETDATE")]
        public string FLDTARGETDATE { get; set; }
        [DataMember(Name = "FLDSHIPBOARDSTATUS")]
        public string FLDSHIPBOARDSTATUS { get; set; }


        public static ShipboardTasksInAlertAndCrewDocumentsDashboardModel TranslateAsAction(DataRow dr)
        {
            var item = new ShipboardTasksInAlertAndCrewDocumentsDashboardModel();

            item.FLDCREATEDFROMNAME = General.GetNullableString(dr["FLDCREATEDFROMNAME"].ToString());
            item.FLDSOURCENAME = General.GetNullableString(dr["FLDSOURCENAME"].ToString());
            item.FLDHARDNAME = General.GetNullableString(dr["FLDHARDNAME"].ToString());
            item.FLDDEPARTMENTNAME = General.GetNullableString(dr["FLDDEPARTMENTNAME"].ToString());
            item.FLDITEMNAME = General.GetNullableString(dr["FLDITEMNAME"].ToString());
            item.FLDDEFICIENCYDETAILS = General.GetNullableString(dr["FLDDEFICIENCYDETAILS"].ToString());
            item.FLDTASK = General.GetNullableString(dr["FLDTASK"].ToString());
            item.FLDTARGETDATE = General.GetNullableString(dr["FLDTARGETDATE"].ToString());
            item.FLDSHIPBOARDSTATUS = General.GetNullableString(dr["FLDSHIPBOARDSTATUS"].ToString());

            return item;
        }

        public static List<ShipboardTasksInAlertAndCrewDocumentsDashboardModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<ShipboardTasksInAlertAndCrewDocumentsDashboardModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class InspectionDrillScheduleModel
    {

        [DataMember(Name = "FLDDRILLNAME")]
        public string FLDDRILLNAME { get; set; }
        [DataMember(Name = "FLDFREQUENCY")]
        public string FLDFREQUENCY { get; set; }
        [DataMember(Name = "FLDFIXEDORVARIABLE")]
        public string FLDFIXEDORVARIABLE { get; set; }
        [DataMember(Name = "FLDTYPE")]
        public string FLDTYPE { get; set; }
        [DataMember(Name = "FLDDRILLDUEDATE")]
        public string FLDDRILLDUEDATE { get; set; }
        [DataMember(Name = "FLDDRILLLASTDONEDATE")]
        public string FLDDRILLLASTDONEDATE { get; set; }

        public static InspectionDrillScheduleModel TranslateAsAction(DataRow dr)
        {
            var item = new InspectionDrillScheduleModel();

            item.FLDDRILLNAME = General.GetNullableString(dr["FLDDRILLNAME"].ToString());
            item.FLDFREQUENCY = General.GetNullableString(dr["FLDFREQUENCY"].ToString());
            item.FLDFIXEDORVARIABLE = General.GetNullableString(dr["FLDFIXEDORVARIABLE"].ToString());
            item.FLDTYPE = General.GetNullableString(dr["FLDTYPE"].ToString());
            item.FLDDRILLDUEDATE = General.GetNullableString(dr["FLDDRILLDUEDATE"].ToString());
            item.FLDDRILLLASTDONEDATE = General.GetNullableString(dr["FLDDRILLLASTDONEDATE"].ToString());

            return item;
        }

        public static List<InspectionDrillScheduleModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionDrillScheduleModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class InspectionTrainingScheduleModule
    {

        [DataMember(Name = "FLDTRAININGNAME")]
        public string FLDTRAININGNAME { get; set; }
        [DataMember(Name = "FLDFREQUENCY")]
        public string FLDFREQUENCY { get; set; }
        [DataMember(Name = "FLDFIXEDORVARIABLE")]
        public string FLDFIXEDORVARIABLE { get; set; }
        [DataMember(Name = "FLDTYPE")]
        public string FLDTYPE { get; set; }
        [DataMember(Name = "FLDTRAININGONBOARDDUEDATE")]
        public string FLDTRAININGONBOARDDUEDATE { get; set; }
        [DataMember(Name = "FLDTRAININGONBOARDLASTDONEDATE")]
        public string FLDTRAININGONBOARDLASTDONEDATE { get; set; }
        

        public static InspectionTrainingScheduleModule TranslateAsAction(DataRow dr)
        {
            var item = new InspectionTrainingScheduleModule();

            item.FLDTRAININGNAME = General.GetNullableString(dr["FLDTRAININGNAME"].ToString());
            item.FLDFREQUENCY = General.GetNullableString(dr["FLDFREQUENCY"].ToString());
            item.FLDFIXEDORVARIABLE = General.GetNullableString(dr["FLDFIXEDORVARIABLE"].ToString());
            item.FLDTYPE = General.GetNullableString(dr["FLDTYPE"].ToString());
            item.FLDTRAININGONBOARDDUEDATE = General.GetNullableString(dr["FLDTRAININGONBOARDDUEDATE"].ToString());
            item.FLDTRAININGONBOARDLASTDONEDATE = General.GetNullableString(dr["FLDTRAININGONBOARDLASTDONEDATE"].ToString());

            return item;
        }

        public static List<InspectionTrainingScheduleModule> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionTrainingScheduleModule>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


    public class DashboardCrewExpiryDocumentDetailsModel
    {

        [DataMember(Name = "FLDDOCUMENTTYPE")]
        public string FLDDOCUMENTTYPE { get; set; }
        [DataMember(Name = "FLDDOCUMENTNAME")]
        public string FLDDOCUMENTNAME { get; set; }
        [DataMember(Name = "FLDEXPIRYDATE")]
        public string FLDEXPIRYDATE { get; set; }

        public static DashboardCrewExpiryDocumentDetailsModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardCrewExpiryDocumentDetailsModel();

            item.FLDDOCUMENTTYPE = General.GetNullableString(dr["FLDDOCUMENTTYPE"].ToString());
            item.FLDDOCUMENTNAME = General.GetNullableString(dr["FLDDOCUMENTNAME"].ToString());
            item.FLDEXPIRYDATE = General.GetNullableString(dr["FLDEXPIRYDATE"].ToString());


            return item;
        }

        public static List<DashboardCrewExpiryDocumentDetailsModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardCrewExpiryDocumentDetailsModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class InspectionDashboardSealUsageModel
    {
        [DataMember(Name = "FLDLOCATIONNAME")]
        public string FLDLOCATIONNAME { get; set; }
        [DataMember(Name = "FLDSEALPOINTNAME")]
        public string FLDSEALPOINTNAME { get; set; }
        [DataMember(Name = "FLDSEALNO")]
        public string FLDSEALNO { get; set; }
        [DataMember(Name = "FLDSEALTYPENAME")]
        public string FLDSEALTYPENAME { get; set; }
        [DataMember(Name = "FLDPERSONAFFIXINGSEAL")]
        public string FLDPERSONAFFIXINGSEAL { get; set; }
        [DataMember(Name = "FLDRANKNAME")]
        public string FLDRANKNAME { get; set; }
        [DataMember(Name = "FLDDATEAFFIXED")]
        public string FLDDATEAFFIXED { get; set; }
        [DataMember(Name = "FLDREASONNAME")]
        public string FLDREASONNAME { get; set; }
        [DataMember(Name = "FLDSEALREMOVERNAMERANK")]
        public string FLDSEALREMOVERNAMERANK { get; set; }
        [DataMember(Name = "FLDSEALREMOVERDATE")]
        public string FLDSEALREMOVERDATE { get; set; }
        [DataMember(Name = "FLDUSAGEREMARKSNAME")]
        public string FLDUSAGEREMARKSNAME { get; set; }

        public static InspectionDashboardSealUsageModel TranslateAsAction(DataRow dr)
        {
            var item = new InspectionDashboardSealUsageModel();

            item.FLDLOCATIONNAME = General.GetNullableString(dr["FLDLOCATIONNAME"].ToString());
            item.FLDSEALPOINTNAME = General.GetNullableString(dr["FLDSEALPOINTNAME"].ToString());
            item.FLDSEALNO = General.GetNullableString(dr["FLDSEALNO"].ToString());
            item.FLDSEALTYPENAME = General.GetNullableString(dr["FLDSEALTYPENAME"].ToString());
            item.FLDPERSONAFFIXINGSEAL = General.GetNullableString(dr["FLDPERSONAFFIXINGSEAL"].ToString());
            item.FLDRANKNAME = General.GetNullableString(dr["FLDRANKNAME"].ToString());
            item.FLDDATEAFFIXED = General.GetNullableString(dr["FLDDATEAFFIXED"].ToString());
            item.FLDREASONNAME = General.GetNullableString(dr["FLDREASONNAME"].ToString());
            item.FLDSEALREMOVERNAMERANK = General.GetNullableString(dr["FLDSEALREMOVERNAMERANK"].ToString());
            item.FLDSEALREMOVERDATE = General.GetNullableString(dr["FLDSEALREMOVERDATE"].ToString());
            item.FLDUSAGEREMARKSNAME = General.GetNullableString(dr["FLDUSAGEREMARKSNAME"].ToString());

            return item;
        }
        public static List<InspectionDashboardSealUsageModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionDashboardSealUsageModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class VesselAccountsEmployeeQueryDashboardModel
    {
        [DataMember(Name = "FLDFILENO")]
        public string FLDFILENO { get; set; }
        [DataMember(Name = "FLDNAME")]
        public string FLDNAME { get; set; }
        [DataMember(Name = "FLDSIGNONRANKCODE")]
        public string FLDSIGNONRANKCODE { get; set; }
        [DataMember(Name = "FLDPASSPORTNO")]
        public string FLDPASSPORTNO { get; set; }
        [DataMember(Name = "FLDSEAMANBOOKNO")]
        public string FLDSEAMANBOOKNO { get; set; }
        [DataMember(Name = "FLDRELIEFDUEDATE")]
        public string FLDRELIEFDUEDATE { get; set; }
        [DataMember(Name = "FLDSIGNONDATE")]
        public string FLDSIGNONDATE { get; set; }
       
        public static VesselAccountsEmployeeQueryDashboardModel TranslateAsAction(DataRow dr)
        {
            var item = new VesselAccountsEmployeeQueryDashboardModel();

            item.FLDFILENO = General.GetNullableString(dr["FLDFILENO"].ToString());
            item.FLDNAME = General.GetNullableString(dr["FLDNAME"].ToString());
            item.FLDSIGNONRANKCODE = General.GetNullableString(dr["FLDSIGNONRANKCODE"].ToString());
            item.FLDPASSPORTNO = General.GetNullableString(dr["FLDPASSPORTNO"].ToString());
            item.FLDSEAMANBOOKNO = General.GetNullableString(dr["FLDSEAMANBOOKNO"].ToString());
            item.FLDRELIEFDUEDATE = General.GetNullableString(dr["FLDRELIEFDUEDATE"].ToString());
            item.FLDSIGNONDATE = General.GetNullableString(dr["FLDSIGNONDATE"].ToString());

            return item;
        }
        public static List<VesselAccountsEmployeeQueryDashboardModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<VesselAccountsEmployeeQueryDashboardModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }




    public class DashboardTechnicalRAStatusModel
    {
        [DataMember(Name = "FLDRANUMBER")]
        public string FLDRANUMBER { get; set; }
        [DataMember(Name = "FLDTYPE")]
        public string FLDTYPE { get; set; }
        [DataMember(Name = "FLDDATE")]
        public string FLDDATE { get; set; }
        [DataMember(Name = "FLDINTENDEDWORKDATE")]
        public string FLDINTENDEDWORKDATE { get; set; }
        [DataMember(Name = "FLDCOMPLETIONDATE")]
        public string FLDCOMPLETIONDATE { get; set; }
        [DataMember(Name = "FLDACTIVITYCONDITIONS")]
        public string FLDACTIVITYCONDITIONS { get; set; }


        public static DashboardTechnicalRAStatusModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardTechnicalRAStatusModel();

            item.FLDRANUMBER = General.GetNullableString(dr["FLDRANUMBER"].ToString());
            item.FLDTYPE = General.GetNullableString(dr["FLDTYPE"].ToString());
            item.FLDDATE = General.GetDateTimeToString(dr["FLDDATE"].ToString());
            item.FLDINTENDEDWORKDATE = General.GetDateTimeToString(dr["FLDINTENDEDWORKDATE"].ToString());
            item.FLDCOMPLETIONDATE = General.GetDateTimeToString(dr["FLDCOMPLETIONDATE"].ToString());
            item.FLDACTIVITYCONDITIONS = General.GetNullableString(dr["FLDACTIVITYCONDITIONS"].ToString());

            return item;
        }
        public static List<DashboardTechnicalRAStatusModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardTechnicalRAStatusModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }




    public class DashboardTechnicalPTWStatusModel
    {
        [DataMember(Name = "FLDWONO")]
        public string FLDWONO { get; set; }
        [DataMember(Name = "FLDJOBNAME")]
        public string FLDJOBNAME { get; set; }
        [DataMember(Name = "FLDFORMNAME")]
        public string FLDFORMNAME { get; set; }
        [DataMember(Name = "FLDCREATEDDATE")]
        public string FLDCREATEDDATE { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }


        public static DashboardTechnicalPTWStatusModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardTechnicalPTWStatusModel();

            item.FLDWONO = General.GetNullableString(dr["FLDWONO"].ToString());
            item.FLDJOBNAME = General.GetNullableString(dr["FLDJOBNAME"].ToString());
            item.FLDFORMNAME = General.GetNullableString(dr["FLDFORMNAME"].ToString());
            item.FLDCREATEDDATE = General.GetDateTimeToString(dr["FLDCREATEDDATE"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());

            return item;
        }
        public static List<DashboardTechnicalPTWStatusModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardTechnicalPTWStatusModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }
    


    public class DashboardTechnicalDMFFormsModel
    {
        [DataMember(Name = "FLDACTIVITYNAME")]
        public string FLDACTIVITYNAME { get; set; }
        [DataMember(Name = "FLDDATE")]
        public string FLDDATE { get; set; }
        [DataMember(Name = "FLDFORMNAME")]
        public string FLDFORMNAME { get; set; }
        [DataMember(Name = "FLDUSERNAME")]
        public string FLDUSERNAME { get; set; }
        [DataMember(Name = "FLDTYPENAME")]
        public string FLDTYPENAME { get; set; }
        [DataMember(Name = "FLDSTATUS")]
        public string FLDSTATUS { get; set; }


        public static DashboardTechnicalDMFFormsModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardTechnicalDMFFormsModel();

            item.FLDACTIVITYNAME = General.GetNullableString(dr["FLDACTIVITYNAME"].ToString());
            item.FLDDATE = General.GetDateTimeToString(dr["FLDDATE"].ToString());
            item.FLDFORMNAME = General.GetNullableString(dr["FLDFORMNAME"].ToString());
            item.FLDUSERNAME = General.GetNullableString(dr["FLDUSERNAME"].ToString());
            item.FLDTYPENAME = General.GetNullableString(dr["FLDTYPENAME"].ToString());
            item.FLDSTATUS = General.GetNullableString(dr["FLDSTATUS"].ToString());

            return item;
        }
        public static List<DashboardTechnicalDMFFormsModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardTechnicalDMFFormsModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class DashboardTechnicalRAModel
    {
        [DataMember(Name = "FLDWORKORDERNUMBER")]
        public string FLDWORKORDERNUMBER { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDCOMPONENT")]
        public string FLDCOMPONENT { get; set; }
        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }



        public static DashboardTechnicalRAModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardTechnicalRAModel();

            item.FLDWORKORDERNUMBER = General.GetNullableString(dr["FLDWORKORDERNUMBER"].ToString());
            item.FLDWORKORDERNAME = General.GetNullableString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDCOMPONENT = General.GetNullableString(dr["FLDCOMPONENT"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetDateTimeToString(dr["FLDPLANNINGDUEDATE"].ToString());

            return item;
        }
        public static List<DashboardTechnicalRAModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardTechnicalRAModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }

    public class InspectionDashboardIncidentNearMissModel
    {
        [DataMember(Name = "FLDINCIDENTREFNO")]
        public string FLDINCIDENTREFNO { get; set; }
        [DataMember(Name = "FLDINCIDENTCLASSIFICATION")]
        public string FLDINCIDENTCLASSIFICATION { get; set; }
        [DataMember(Name = "FLDCATEGORYNAME")]
        public string FLDCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDSUBCATEGORYNAME")]
        public string FLDSUBCATEGORYNAME { get; set; }
        [DataMember(Name = "FLDCONSEQUENCECATEGORY")]
        public string FLDCONSEQUENCECATEGORY { get; set; }
        [DataMember(Name = "FLDINCIDENTTITLE")]
        public string FLDINCIDENTTITLE { get; set; }
        [DataMember(Name = "FLDREPORTEDDATE")]
        public string FLDREPORTEDDATE { get; set; }
        [DataMember(Name = "FLDINCIDENTDATE")]
        public string FLDINCIDENTDATE { get; set; }
        [DataMember(Name = "FLDSTATUSOFINCIDENTNAME")]
        public string FLDSTATUSOFINCIDENTNAME { get; set; }



        public static InspectionDashboardIncidentNearMissModel TranslateAsAction(DataRow dr)
        {
            var item = new InspectionDashboardIncidentNearMissModel();

            item.FLDINCIDENTREFNO = General.GetNullableString(dr["FLDINCIDENTREFNO"].ToString());
            item.FLDINCIDENTCLASSIFICATION = General.GetNullableString(dr["FLDINCIDENTCLASSIFICATION"].ToString());
            item.FLDCATEGORYNAME = General.GetNullableString(dr["FLDCATEGORYNAME"].ToString());
            item.FLDSUBCATEGORYNAME = General.GetDateTimeToString(dr["FLDSUBCATEGORYNAME"].ToString());
            item.FLDCONSEQUENCECATEGORY = General.GetDateTimeToString(dr["FLDCONSEQUENCECATEGORY"].ToString());
            item.FLDINCIDENTTITLE = General.GetDateTimeToString(dr["FLDINCIDENTTITLE"].ToString());
            item.FLDREPORTEDDATE = General.GetDateTimeToString(dr["FLDREPORTEDDATE"].ToString());
            item.FLDINCIDENTDATE = General.GetDateTimeToString(dr["FLDINCIDENTDATE"].ToString());
            item.FLDSTATUSOFINCIDENTNAME = General.GetDateTimeToString(dr["FLDSTATUSOFINCIDENTNAME"].ToString());


            return item;
        }
        public static List<InspectionDashboardIncidentNearMissModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionDashboardIncidentNearMissModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }

    public class InspectionDashboardUnsafeActsConditionsModel
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



        public static InspectionDashboardUnsafeActsConditionsModel TranslateAsAction(DataRow dr)
        {
            var item = new InspectionDashboardUnsafeActsConditionsModel();

            item.FLDINCIDENTNEARMISSREFNO = General.GetNullableString(dr["FLDINCIDENTNEARMISSREFNO"].ToString());
            item.FLDREPORTEDDATE = General.GetDateTimeToString(dr["FLDREPORTEDDATE"].ToString());
            item.FLDINCIDENTDATE = General.GetDateTimeToString(dr["FLDINCIDENTDATE"].ToString());
            item.FLDINCIDENTTIME = General.GetNullableString(dr["FLDINCIDENTTIME"].ToString());
            item.FLDICCATEGORYNAME = General.GetNullableString(dr["FLDICCATEGORYNAME"].ToString());
            item.FLDICSUBCATEGORYNAME = General.GetNullableString(dr["FLDICSUBCATEGORYNAME"].ToString());
            item.FLDSUMMARY = General.GetNullableString(dr["FLDSUMMARY"].ToString());
            item.FLDLOCATION = General.GetNullableString(dr["FLDLOCATION"].ToString());
            item.FLDCORRECTIVEACTION = General.GetNullableString(dr["FLDCORRECTIVEACTION"].ToString());
            item.FLDSTATUSNAME = General.GetNullableString(dr["FLDSTATUSNAME"].ToString());


            return item;
        }
        public static List<InspectionDashboardUnsafeActsConditionsModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<InspectionDashboardUnsafeActsConditionsModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    public class DashboardTechnicalPTWDueModel
    {
        [DataMember(Name = "FLDWORKORDERNO")]
        public string FLDWORKORDERNO { get; set; }
        [DataMember(Name = "FLDWORKORDERNAME")]
        public string FLDWORKORDERNAME { get; set; }
        [DataMember(Name = "FLDTYPENAME")]
        public string FLDTYPENAME { get; set; }
        [DataMember(Name = "FLDPLANNINGDUEDATE")]
        public string FLDPLANNINGDUEDATE { get; set; }
        [DataMember(Name = "FLDFORMNAME")]
        public string FLDFORMNAME { get; set; }
       



        public static DashboardTechnicalPTWDueModel TranslateAsAction(DataRow dr)
        {
            var item = new DashboardTechnicalPTWDueModel();

            item.FLDWORKORDERNO = General.GetNullableString(dr["FLDWORKORDERNO"].ToString());
            item.FLDWORKORDERNAME = General.GetDateTimeToString(dr["FLDWORKORDERNAME"].ToString());
            item.FLDTYPENAME = General.GetDateTimeToString(dr["FLDTYPENAME"].ToString());
            item.FLDPLANNINGDUEDATE = General.GetNullableString(dr["FLDPLANNINGDUEDATE"].ToString());
            item.FLDFORMNAME = General.GetNullableString(dr["FLDFORMNAME"].ToString());
      

            return item;
        }
        public static List<DashboardTechnicalPTWDueModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DashboardTechnicalPTWDueModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }


}