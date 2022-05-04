using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SouthNests.Phoenix.Framework;
using SouthNests.PhoenixMobile.Translators;
using SouthNests.PhoenixMobile.Model;
using WebApplication1.Translators;
using WebApplication1.Model;

namespace WebApplication1.Controller
{
    public class PhoenixController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }

        [HttpPost]
        public List<MobilePhoenixUserContext> LoginUser(MobilePhoenixUserLogin item)
        {
            return PhoenixMobileUserContextTranslator.MobileUserContext(item);
        }


        [HttpGet]
        public List<MobileUsersModel> GetUsersList()
        {
            return PhoenixMobileUserTranslator.ListMobileUsers("");
        }

        [HttpGet]
        public List<MobileModuleItem> GetModuleItemsList()
        {
            return PhoenixMobileUserTranslator.ListModuleItems("");
        }

        [HttpGet]
        public List<MobileUsersModel> GetMobileUsers([FromBody] MobileUsersModel m)
        {
            return PhoenixMobileUserTranslator.ListMobileUsers(m.Name);
        }

        [HttpGet]
        public IEnumerable<string> MoreValuesWithParam(int id)
        {
            return new string[] { "value1", "value2", "value3" };
        }

        [HttpPost]
        public HttpResponseMessage PostUser(MobileUsersModel item)
        {
            if (item == null)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);


            var response = Request.CreateResponse<MobileUsersModel>(HttpStatusCode.Created, item);
            int n = PhoenixMobileUserTranslator.InsertMobileUser(item);
            return response;
        }

        [HttpPost]
        public HttpResponseMessage LoginMobileUser(MobileUserSignup item)
        {
            if (item == null)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

            AuthenticateUser au = PhoenixMobileUserTranslator.LoginMobileUser(item);

            var response = Request.CreateResponse<AuthenticateUser>(HttpStatusCode.Created, au);

            return response;
        }

        [HttpPost]
        public HttpResponseMessage SignupMobileUser(MobileUserSignup item)
        {
            AuthenticateUser au = PhoenixMobileUserTranslator.SignupMobileUser(item);

            var response = Request.CreateResponse<AuthenticateUser>(HttpStatusCode.Created, au);

            return response;
        }

        [HttpPost]
        public HttpResponseMessage DeleteUser(MobileUsersModel item)
        {
            if (item == null)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

            item.PushToken = "Delete";
            var response = Request.CreateResponse<MobileUsersModel>(HttpStatusCode.Created, item);

            return response;
        }

        [HttpPost]
        public List<VesselModel> GetVesselList(VesselModelSearch model)
        {
            return PhoenixMobileVesselTranslator.ListMobileVessels(model);
        }

        [HttpPost]
        public List<CountListModel> UserRecordsCount(VesselModelSearch model)
        {
            return PhoenixMobileVesselTranslator.UserRecordsCountList(model);
        }


        [HttpPost]
        public List<CategoryModel> GetCategoryList(CategoryModelFilter item)
        {
            return PhoenixMobileVesselTranslator.ListCategory(item);
        }


        [HttpPost]
        public List<VesselKeyDetailsModel> GetVesselKeyDetailList(VesselKeyDetailFilter item)
        {
            return PhoenixMobileKeyDetailVesselTranslator.VesselKeyDetailsList(item);
        }


        [HttpPost]
        public List<SubCategoryModel> GetSubCategoryList(SubCategoryModelFilter item)
        {
            return PhoenixMobileVesselTranslator.ListSubCategory(item);
        }

        [HttpPost]
        public List<CategoryMenuItemModel> GetSubCategoryMenuItemList(CategoryMenuItemModelFilter item)
        {   
            return PhoenixMobileVesselTranslator.ListSubCategoryMenuItemList(item);
        }

        [HttpPost]
        public List<DashboardPanelModelPurchase> GetSubCategoryElementsPurchase(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementPurchase(item);
        }

        [HttpPost]
        public List<DashboardPanelModelDrills>GetSubCategoryElementsDrills(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementDrills(item);
        }

        [HttpPost]
        public List<DashboardPanelModelAuditAndInspectionTask> GetSubCategoryElementsAuditAndInspectionTask(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementAuditAndInspectionTask(item);
        }

        [HttpPost]
        public List<DashboardPanelModelAuditAndInspection> GetSubCategoryElementsAuditAndInspection(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementAuditAndInspection(item);
        }


        //[HttpPost]
        //public List<DashboardPanelModelVesselPerformance> GetSubCategoryElementsVesselPerformance(DashboardPanelModelFilter item)
        //{
        //    return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementVesselPerformance(item);
        //}
        [HttpPost]
        public List<DashboardPanelModelVesselPerformance> GetSubCategoryElementsVesselPerformance(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementVesselPerformance(item);
        }

        [HttpPost]
        public List<DashboardPanelModelOpenReports> GetSubCategoryElementsOpenReports(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementOpenReports(item);
        }

        [HttpPost]
        public List<DashboardPanelModelCertificateSurvey> GetSubCategoryElementsCertificateSurvey(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementCertificateSurvey(item);
        }

        [HttpPost]
        public List<DashboardPanelModelPMS> GetSubCategoryElementsPMS(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementPMS(item);
        }

        [HttpPost]
        public List<DashboardPanelModelRiskMoc> GetSubCategoryElementsRiskMoc(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementsRiskMoc(item);
        }

        [HttpPost]
        public List<DashboardPanelModelRiskRa> GetSubCategoryElementsRiskRa(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementsRiskRa(item);
        }

        [HttpPost]
        public List<DashboardPanelModelIncident> GetSubCategoryElementsIncident(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementIncident(item);
        }

        
        [HttpPost]
        public List<VesselListModel> GetSearchedData(VesselModelSearch item)
        {
            return PhoenixMobileVesselTranslator.VesselListSearching(item);
        }

        [HttpPost]
        public List<DashboardPanelModelCertificateSurveyDueList> GetSubCategoryElementsCertificateSurveyDueList(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ListSubCategoryElementCertificateSurveyDueList(item);
        }

        [HttpPost]
        public List<ActionCrewList> CrewListAction(crewList item)
        {
            return PhoenixMobileActionTranslator.crewListActionList(item);
        }
        [HttpPost]
        public List<ActionEventList> EventListAction(EventList item)
        {
            return PhoenixMobileActionTranslator.EventListActionList(item);
        }

        [HttpPost]
        public List<ActionStoresAndSparesList> StoresandSparesDashboardAction(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.sparesAndStoresActionList(item);
        }
        [HttpPost]
        public List<ActionAlertsAndCrewDocumentsList> AlertsAndCrewDocumentsDashboardAction(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.AlertsAndCrewDocumentsActionList(item);
        }
        [HttpPost]
        public List<ActionMaintenanceAndOperationList> MaintainanceAndOperationAction(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.MaintainanceAndOperationActionList(item);
        }
        [HttpPost]
        public List<ActionOrdersAndInformationList> OrdersAndInformationActionA(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.OrdersAndInformationAActionList(item);
        }
        [HttpPost]
        public List<ActionOrdersAndInformationListB> OrdersAndInformationActionB(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.OrdersAndInformationAActionListB(item);
        }
        [HttpPost]
        public List<PMSList> PMSDashboardAction(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.PMSActionList(item);
        }
        [HttpPost]
        public List<WorkAndRestHoursList> WorkAndRestHoursDashboardAction(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.WorkAndRestHoursActionList(item);
        }
        [HttpPost]
        public List<WorkAndRestHoursListB> WorkAndRestHoursDashboardActionB(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.WorkAndRestHoursActionListB(item);
        }

        [HttpPost]
        public List<DefectsAndNonRoutineList> DefectsAndNonRoutineJobs(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.DefectsAndNonRoutineJobsList(item);
        }

        [HttpPost]
        public List<TimeSheetList> TimesheetDashboardAction(Timesheet item)
        {
            return PhoenixMobileActionTranslator.TimesheetActionList(item);
        }
        [HttpPost]
        public List<ActionPersonnelOnDutyList> PersonnelOnDuty(PersonnelOnDutyList item)
        {
            return PhoenixMobileActionTranslator.PersonnelOnDutyActionList(item);
        }

        [HttpPost]
        public NearMissList  NearMissAction(StoresAndSparesList item)
        {
            return PhoenixMobileActionTranslator.NearMissListActionList(item);
        }

        [HttpPost]
        public List<DashboardForm> WorkPermitsAndNonROutineRAs(StoresAndSparesList item)
        {
            return FormsRA.GetFormsRA(item);
        }
     

        [HttpPost]
        public List<ReliefPLanAlertList> ReliefPlanAlert(ReliefPlan item)
        {
            return PhoenixMobileActionTranslator.ReliefPlanAlertList(item);
        }

        [HttpPost]
        public List<ReliefPlanCurrentPlannedList>ReliefPlanCurrentPlanned(ReliefPlan item)
        {
            return PhoenixMobileActionTranslator.CrewReliefPlanCurrentPlannedList(item);
        }

        [HttpPost]
        public List<CertificatesList> ActionCertificates(ReliefPlan item)
        {
            return PhoenixMobileActionTranslator.ActionCertificatesList(item);
        }

        [HttpPost]
        public List<EfillingList> ActionEfilingMaintainance(ReliefPlan item)
        {
            return PhoenixMobileActionTranslator.ActionEfilingList(item);
        }

        [HttpPost]
        public List<EfillingOfficeFormsList> ActionEfilingOfficeforms(EfillingOfficeForms item)
        {
            return PhoenixMobileActionTranslator.ActionEfilingOfficeList(item);
        }

        [HttpPost]
        public List<cargoOperationsList> cargoOperationsPanel(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.cargoOperationsPanelList(item);
        }


        [HttpPost]
        public List<TradingAreaList> TradingAreaOperationsPanel(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.TradingAreaOperationsPanelList(item);
        }

        [HttpPost]
        public List<OthersOperationPanelList> OthersOperationsPanel(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.OthersOperationsPanelList(item);
        }

        [HttpPost]
        public List<ManningAndDocumentsList> ManningAndDocumentsCrewPanel(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.ManningAndDocumentsPanelList(item);
        }

        [HttpPost]
        public List<CrewChangesAndApproval> GetSubCategoryCrewChangesAndApprovalCrewPanel(DashboardPanelModelFilter item)
        {
            return PhoenixMobileDashboardPanelTranslator.CrewChangesAndApprovalPanelList(item);
        }

        [HttpPost]
        public List<QuartelyReport>QuartelyReportList(PanelTech item)
        {
            return PanelTranslator.QuartelyReportList(item);
        }

        [HttpPost]
        public List<MonthlyReport> MonthlyReportList(PanelTech item)
        {
            return PanelTranslator.MonthlyReportList(item);
        }

        [HttpPost]
        public List<NoonReport> NoonReportList(PanelTech item)
        {
            return PanelTranslator.NoonReportList(item);
        }

        [HttpPost]
        public List<OverdueJobs> OverdueJobsList(PanelTech item)
        {
            return PanelTranslator.OverdueJobsList(item);
        }

        [HttpPost]
        public List<OverdueWorkOrder> OverdueWorkOrderList(PanelTech item)
        {
            return PanelTranslator.OverdueWorkOrderList(item);
        }

        [HttpPost]
        public List<CriticalOverdueJobs> CriticalOverdueJobsList(PanelTech item)
        {
            return PanelTranslator.CriticalOverdueJobsList(item);
        }

        [HttpPost]
        public List<MajorOverhauls> MajorOverhaulsAndDeffectJobsList(PanelTech item)
        {
            return PanelTranslator.MajorOverhaulsList(item);
        }


        [HttpPost]
        public List<WOverified> WOverifiedList(PanelTech item)
        {
            return PanelTranslator.WOverifiedList(item);
        }

        [HttpPost]
        public List<PostpondedJobs> PostpondedJobsList(PanelTech item)
        {
            return PanelTranslator.PostpondedJobsList(item);
        }

        [HttpPost]
        public List<Cat1MajorOverHaulDue60Days> Cat1MajorOverHaulDue60DaysList(PanelTech item)
        {
            return PanelTranslator.Cat1MajorOverHaulDue60DaysList(item);
        }

        [HttpPost]
        public List<Cat2MajorOverHaulDue60Days> Cat2MajorOverHaulDue60DaysList(PanelTech item)
        {
            return PanelTranslator.cat2MajorOverHaulDue60DaysList(item);
        }

        [HttpPost]
        public List<Cat2MajorOverhauls> Cat2MajorOverhauls(PanelTech item)
        {
            return PanelTranslator.Cat2MajorOverhaulsList(item);
        }

        [HttpPost]
        public List<PurchaseForm> PurchaseForms(PanelTech item)
        {
            return PanelTranslator.PurchaseFormsList(item);
        }

        [HttpPost]
        public List<CriticalSparePurchaseFormList> CriticalSparePurchasePanel(PanelTech item)
        {
            return PanelTranslator.CriticalSparePurchasePanelList(item);
        }

        [HttpPost]
        public List<ExpiredCrewDocumentList> ExpiredCrewDocuments(PanelTech item)
        {
            return PanelTranslator.ExpiredCrewDocumentsList(item);
        }
        [HttpPost]
        public List<OpenReportUnclassifiedList> OpenReportUnclassified(PanelTech item)
        {
            return PanelTranslator.OpenReportUnclassified(item);
        }

        [HttpPost]
        public List<CrewComplaintsOpenClosedList> CrewComplaints(PanelTech item)
        {
            return PanelTranslator.CrewComplaintsOpenClosed(item);
        }

        [HttpPost]
        public List<DrillList> DrillsPanel(PanelTech item)
        {
            return PanelTranslator.DrillsList(item);
        }


        [HttpPost]
        public List<MOC> MOCPanel(PanelTech item)
        {
            return PanelTranslator.MOCPanelList(item);
        }

        [HttpPost]
        public List<RA> RAPanel(PanelTech item)
        {
            return PanelTranslator.RAPanelList(item);
        }

        [HttpPost]
        public List<AccidentAndNearmissIncidentList> AccidentAndNearmissIncidentPanel(PanelTech item)
        {
            return PanelTranslator.AccidentAndNearmissIncidentPanelList(item);
        }

        [HttpPost]
        public List<MachineryDamageIncidentList> MachineryDamageIncidentPanel(PanelTech item)
        {
            return PanelTranslator.MachineryDamageIncidentPanelList(item);
        }

        [HttpPost]
        public List<unsafeActsOpenCompletedIncidentList> unsafeActsOpenCompletedIncidentPanel(PanelTech item)
        {
            return PanelTranslator.unsafeActsOpenCompletedIncidentPanelList(item);
        }

        [HttpPost]
        public List<CrewChangesAndApprovalCrewList>crewChangesAndApprovalCrewLists(PanelTech item)
        {
            return PanelTranslator.CrewChangesAndApprovalCrewPanelList(item);
        }
        [HttpPost]
        public List<CrewChangesAndApprovalLast24hrsList> CrewChangesAndApprovalLast24hrsLists(PanelTech item)
        {
            return PanelTranslator.CrewChangesAndApprovalLast24hoursList(item);
        }
        [HttpPost]
        public List<NoonReportTechnicalPanel> NoonReportPendingReviewTechPanel(PanelTech item)
        {
            return PanelTranslator.NoonReportTechPanelList(item);
        }

        [HttpPost]
        public List<ArrivalReportTechnicalPanel> ArrivalReportPendingReviewTechPanel(PanelTech item)
        {
            return PanelTranslator.ArrivalReportTechPanelList(item);
        }

        [HttpPost]
        public List<DepartureReportTechnicalPanel> DepartureReportPendingReviewTechPanel(PanelTech item)
        {
            return PanelTranslator.DepartureReportTechPanelList(item);
        }


        [HttpPost]
        public List<InsPanelList>InspectionPanel(PanelTech item)
        {
            return PanelTranslator.InspectionPanelList(item);
        }

        [HttpPost]
        public List<PostpondedRequestListPMSPanel> PostpondedRequestPMSPanel(PanelTech item)
        {
            return PanelTranslator.PostpondedRequestPMSList(item);
        }

        [HttpPost]
        public List<AuditAndInspection60daysAndOverduePanel> AuditAndInspection60daysAndOverdue(PanelTech item)
        {
            return PanelTranslator.AuditAndInspection60daysAndOverdueList(item);
        }

        [HttpPost]
        public List<InspectionDashBoardAuditRecordListPanel>InspectionDashBoardAuditRecordList(PanelTech item)
        {
            return PanelTranslator.InspectionDashBoardAuditRecordListPanels(item);
        }

        [HttpPost]
        public List<InspectionDashboardSIREPlannerList> InspectionDashboardSIREPlanner(PanelTech item)
        {
            return PanelTranslator.InspectionDashboardSIREPlannerPanel(item);
        }

        [HttpPost]
        public List<InspectionDashboardScheduleMasterList> InspectionDashboardScheduleMaster(PanelTech item)
        {
            return PanelTranslator.InspectionDashboardScheduleMasterPanel(item);
        }

        [HttpPost]
        public List<DashboardTechnicalMaintenanceScreenListModel> DashboardTechnicalMaintenanceScreen(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardTechnicalMaintenanceScreenList(item);
        }

        [HttpPost]
        public List<DashboardTechnicalOperationScreenListModel> DashboardTechnicalOperationScreen(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardTechnicalOperationScreenList(item);
        }

        [HttpPost]
        public List<PlannedMaintenanceOrderInformationModel> PlannedMaintenanceOrderInformation(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.PlannedMaintenanceOrderInformationList(item);
        }

        [HttpPost]
        public List<StoresandSparesDashoardScreenListModel> StoresandSparesDashoardScreenList(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.StoresandSparesDashoardList(item);
        }

        [HttpPost]
        public List<DefectsAndNonRoutineJobsListModel> DefectsAndNonRoutineJobsListScreen(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DefectsAndNonRoutineJobsList(item);
        }
        
       [HttpPost]
        public List<ShipboardTasksInAlertAndCrewDocumentsDashboardModel> ShipboardTasksInAlertAndCrewDocumentsDashboard(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.ShipboardTasksInAlertAndCrewDocumentsDashboardList(item);
        }

        [HttpPost]
        public List<InspectionDrillScheduleModel> InspectionDrillSchedule(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.InspectionDrillScheduleList(item);
        }


        [HttpPost]
        public List<InspectionTrainingScheduleModule> InspectionTrainingSchedule(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.InspectionTrainingScheduleList(item);
        }

        [HttpPost]
        public List<DashboardCrewExpiryDocumentDetailsModel> DashboardCrewExpiryDocumentDetails(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardCrewExpiryDocumentDetailsList(item);
        }

       [HttpPost]
        public List<InspectionDashboardSealUsageModel> InspectionDashboardSealUsage(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.InspectionDashboardSealUsageList(item);
        }
        //

       [HttpPost]
        public List<VesselAccountsEmployeeQueryDashboardModel> VesselAccountsEmployeeQueryDashboard(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.VesselAccountsEmployeeQueryDashboardList(item);
        }

        [HttpPost]
        public List<DashboardTechnicalRAStatusModel> DashboardTechnicalRAStatus(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardTechnicalRAStatusList(item);
        }

        [HttpPost]
        public List<DashboardTechnicalPTWStatusModel> DashboardTechnicalPTWStatus(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardTechnicalPTWStatusList(item);
        }

        [HttpPost]
        public List<DashboardTechnicalDMFFormsModel> DashboardTechnicalDMFForms(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardTechnicalDMFFormsList(item);
        }

        [HttpPost]
        public List<DashboardTechnicalRAModel> DashboardTechnicalRARequired(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardTechnicalRAList(item);
        }

        [HttpPost]
        public List<InspectionDashboardIncidentNearMissModel> InspectionDashboardIncidentNearMiss(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.InspectionDashboardIncidentNearMissList(item);
        }


        [HttpPost]
        public List<InspectionDashboardUnsafeActsConditionsModel> InspectionDashboardUnsafeActsConditions(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.InspectionDashboardUnsafeActsConditionsList(item);
        }



        [HttpPost]
        public List<DashboardTechnicalPTWDueModel> DashboardTechnicalPTWDue(PanelTech item)
        {
            return PhoenixMobileActionDashboardTranslator.DashboardTechnicalPTWDueList(item);
        }

        [HttpPost]
        public List<SetTemplateForEmailModel> SetTemplateForEmail(Email item)
        {
            return SendEmailTranslator.SetTemplateForEmailList(item);
        }


        [HttpPost]
        public List<EmailInfoForVesselModel> EmailInfoForVessel(Email item)
        {
            return SendEmailTranslator.EmailInfoForVesselList(item);
        }

        [HttpPost]
        public List<DepartmentForEmailModel> DepartmentForCreateTask(Email item)
        {
            return SendEmailTranslator.DepartmentForEmailList(item);
        }

        [HttpPost]
        public List<DesignationForCreateTaskModel> DesignationForCreateTask(Email item)
        {
            return SendEmailTranslator.DesignationForCreateTaskList(item);
        }

    }
}
