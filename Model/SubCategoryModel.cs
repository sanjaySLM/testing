using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{
    [DataContract]
    public class SubCategoryModelFilter
    {
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "categoryid")]
        public int?  categoryid { get; set; }
    }

    [DataContract]
    public class SubCategoryModel
    {

        [DataMember(Name = "subcategoryid")]
        public string subcategoryid { get; set; }
        [DataMember(Name = "categoryid")]
        public string categoryid { get; set; }
        [DataMember(Name = "subcategorycode")]
        public string subcategorycode { get; set; }
        [DataMember(Name = "subcategoryname")]
        public string subcategoryname { get; set; }
        [DataMember(Name = "subcategoryimage")]
        public string subcategoryimage { get; set; }
        [DataMember(Name = "subcategoryflag")]
        public string subcategoryflag { get; set; }

        public static SubCategoryModel TranslateAsCategory(DataRow dr)
        {
            var item = new SubCategoryModel();

            item.categoryid = General.GetNullableString(dr["FLDCATEGORYID"].ToString());
            item.subcategoryid = General.GetNullableString(dr["FLDSUBCATEGORYID"].ToString());
            item.subcategorycode = General.GetNullableString(dr["FLDSUBCATEGORYCODE"].ToString());
            item.subcategoryname = General.GetNullableString(dr["FLDSUBCATEGORYNAME"].ToString());
            SubCategoryModel.GetMapping(item);
            return item;
        }

        public static void GetMapping(SubCategoryModel item)
        {
            
            switch (item.subcategorycode) {
                case "VPS":
                    item.subcategoryimage = "/technical/VesselPerformance/VesselPerformance_";
                    item.subcategoryflag = "isVesselperformance";
                    break;
                case "CERTSURV":
                    item.subcategoryimage = "/technical/Certificates/CertsSurveys_";
                    item.subcategoryflag = "isCertsurvey";
                    break;
                case "PMS":
                    item.subcategoryimage = "/technical/PMS/PMS_";
                    item.subcategoryflag = "isPMS";
                    break;
                case "PUR":
                    item.subcategoryimage = "/technical/Purchase/Purchase_";
                    item.subcategoryflag = "isPurchase";
                    break;
                case "COP":
                    item.subcategoryimage = "/operation/Cargo/Cargo_";
                    item.subcategoryflag = "isCargooperation";
                    break;
                case "TRAWX":
                    item.subcategoryimage = "/operation/TradingArea/TradingAreaWx_";
                    item.subcategoryflag = "isTradingareawx";
                    break;
                case "PSCVET":
                    item.subcategoryimage = "/operation/PSCVetting/PSC&Vetting_";
                    item.subcategoryflag = "isPSCvetting";
                    break;
                case "OTH":
                    item.subcategoryimage = "/operation/Others/Others_";
                    item.subcategoryflag = "isOthers";
                    break;
                case "INC":
                    item.subcategoryimage = "/hseqa/Incidents/Incidents_";
                    item.subcategoryflag = "isIncidents";
                    break;
                case "MOCRA":
                    item.subcategoryimage = "/hseqa/RiskMOC/Risk&Moc_";
                    item.subcategoryflag = "isMoCRA";
                    break;
                case "DRIL":
                    item.subcategoryimage = "/hseqa/Drills/Drills_";
                    item.subcategoryflag = "isDrill";
                    break;
                case "AUDINS":
                    item.subcategoryimage = "/hseqa/AuditsInspection/AuditsandInspection_";
                    item.subcategoryflag = "isAuditInspection";
                    break;
                case "MNGDOC":
                    item.subcategoryimage = "/crew/Manning&Documents/Manning&Documents_";
                    item.subcategoryflag = "isManningDocuments";
                    break;
                case "OPNRPT":
                    item.subcategoryimage = "/crew/OpenReports&Complaints/OpenReports&Complaints_";
                    item.subcategoryflag = "isOpenreportsComplaints";
                    break;
                case "CRCHAPP":
                    item.subcategoryimage = "/crew/CrewChanges&Approval/CrewChanges&Approval_";
                    item.subcategoryflag = "isCrewChangeApproval";
                    break;
                default:
                    item.subcategoryflag = "isActionItem";
                    break;
             }
        }

        public static List<SubCategoryModel> TranslateAsSubCategoryList(DataTable dt)
        {
            var list = new List<SubCategoryModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsCategory(dr));
            }
            return list;
        }
    }
}