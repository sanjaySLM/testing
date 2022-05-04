using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{

    [DataContract]
    public class CountListModel
    {
        [DataMember(Name = "FLDRECORD")]
        public string FLDRECORD { get; set; }

        public static CountListModel TranslateAsAction(DataRow dr)
        {
            var item = new CountListModel();
            item.FLDRECORD = General.GetNullableString(dr["FLDRECORD"].ToString());
            return item;
        }
        public static List<CountListModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<CountListModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }

    [DataContract]
    public class VesselModel
    {
        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "vesselname")]
        public string vesselname { get; set; }
        [DataMember(Name = "fromAt")]
        public string fromAt { get; set; }
        [DataMember(Name = "to")]
        public string to { get; set; }
        [DataMember(Name = "eta")]
        public string eta { get; set; }
        [DataMember(Name = "etd")]
        public string etd { get; set; }
        [DataMember(Name = "speed")]
        public string speed { get; set; }
        [DataMember(Name = "windforce")]
        public string windforce { get; set; }
        [DataMember(Name = "isVesselperformance")]
        public string isVesselperformance { get; set; }
        [DataMember(Name = "isCertsurvey")]
        public string isCertsurvey { get; set; }
        [DataMember(Name = "isPMS")]
        public string isPMS { get; set; }
        [DataMember(Name = "isPurchase")]
        public string isPurchase { get; set; }
        [DataMember(Name = "isCargooperation")]
        public string isCargooperation { get; set; }
        [DataMember(Name = "isTradingareawx")]
        public string isTradingareawx { get; set; }
        [DataMember(Name = "isPSCvetting")]
        public string isPSCvetting { get; set; }
        [DataMember(Name = "isOthers")]
        public string isOthers { get; set; }
        [DataMember(Name = "isIncidents")]
        public string isIncidents { get; set; }
        [DataMember(Name = "isMoCRA")]
        public string isMoCRA { get; set; }
        [DataMember(Name = "isDrill")]
        public string isDrill { get; set; }
        [DataMember(Name = "isAuditInspection")]
        public string isAuditInspection { get; set; }
        [DataMember(Name = "isManningDocuments")]
        public string isManningDocuments { get; set; }
        [DataMember(Name = "isOpenreportsComplaints")]
        public string isOpenreportsComplaints { get; set; }
        [DataMember(Name = "isCrewChangeApproval")]
        public string isCrewChangeApproval { get; set; }
        [DataMember(Name = "isActionItem")]
        public string isActionItem { get; set; }
        [DataMember(Name = "isNotes")]
        public string isNotes { get; set; }
        [DataMember(Name = "imonumber")]
        public string imonumber { get; set; }


        public static VesselModel TranslateAsVessel(DataRow dr)
        {
            var item = new VesselModel();

            item.id = General.GetNullableString(dr["FLDVESSELID"].ToString());
            //item.imageUrl = General.GetNullableString(dr["FLDNAME"].ToString());
            item.vesselname = General.GetNullableString(dr["FLDVESSELNAME"].ToString());
            item.fromAt = General.GetNullableString(dr["FLDFROMAT"].ToString());
            item.to = General.GetNullableString(dr["FLDTO"].ToString());
            item.eta = General.GetDateTimeToString(dr["FLDETA"].ToString());
            item.etd = General.GetDateTimeToString(dr["FLDETD"].ToString());
            item.speed = General.GetNullableString(dr["FLDSPEED"].ToString());
            item.windforce = General.GetNullableString(dr["FLDWEATHER"].ToString());
            item.isVesselperformance = General.GetNullableString(dr["FLDISVESSELPERFORMANCE"].ToString());
            item.isCertsurvey = General.GetNullableString(dr["FLDISCERTSURVEY"].ToString());
            item.isPMS = General.GetNullableString(dr["FLDISPMS"].ToString());
            item.isPurchase = General.GetNullableString(dr["FLDISPURCHASE"].ToString());
            item.isCargooperation = General.GetNullableString(dr["FLDISCARGOOPERATION"].ToString());
            item.isTradingareawx = General.GetNullableString(dr["FLDISTRADINGAREAWX"].ToString());
            item.isPSCvetting = General.GetNullableString(dr["FLDISPSCVETTING"].ToString());
            item.isOthers = General.GetNullableString(dr["FLDISOTHERS"].ToString());
            item.isIncidents = General.GetNullableString(dr["FLDISINCIDENTS"].ToString());
            item.isMoCRA = General.GetNullableString(dr["FLDISMOCRA"].ToString());
            item.isDrill = General.GetNullableString(dr["FLDISDRILL"].ToString());
            item.isAuditInspection = General.GetNullableString(dr["FLDISAUDITINSPECTION"].ToString());
            item.isManningDocuments = General.GetNullableString(dr["FLDISMANNINGDOCUMENTS"].ToString());
            item.isOpenreportsComplaints =General.GetNullableString(dr["FLDISOPENREPORTSCOMPLAINTS"].ToString());
            item.isCrewChangeApproval = General.GetNullableString(dr["FLDISCREWCHANGEAPPROVAL"].ToString());
            item.isActionItem = General.GetNullableString(dr["FLDISACTIONITEM"].ToString());
            item.isNotes = General.GetNullableString(dr["FLDISNOTES"].ToString());
            item.imonumber = General.GetNullableString(dr["FLDIMONUMBER"].ToString());


            return item;
        }
        public static List<VesselModel> TranslateAsVesselList(DataTable dt)
        {
            var list = new List<VesselModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsVessel(dr));
            }
            return list;
        }
    }




    [DataContract]
    public class VesselListModel
    {
        [DataMember(Name = "key")]
        public string key { get; set; }
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "imageUrl")]
        public string imageUrl { get; set; }
        [DataMember(Name = "vesselname")]
        public string vesselname { get; set; }
        [DataMember(Name = "fromAt")]
        public string fromAt { get; set; }
        [DataMember(Name = "to")]
        public string to { get; set; }
        [DataMember(Name = "eta")]
        public string eta { get; set; }
        [DataMember(Name = "etd")]
        public string etd { get; set; }
        [DataMember(Name = "speed")]
        public string speed { get; set; }
        [DataMember(Name = "windforce")]
        public string windforce { get; set; }
        [DataMember(Name = "isVesselperformance")]
        public string isVesselperformance { get; set; }
        [DataMember(Name = "isCertsurvey")]
        public string isCertsurvey { get; set; }
        [DataMember(Name = "isPMS")]
        public string isPMS { get; set; }
        [DataMember(Name = "isPurchase")]
        public string isPurchase { get; set; }
        [DataMember(Name = "isCargooperation")]
        public string isCargooperation { get; set; }
        [DataMember(Name = "isTradingareawx")]
        public string isTradingareawx { get; set; }
        [DataMember(Name = "isPSCvetting")]
        public string isPSCvetting { get; set; }
        [DataMember(Name = "isOthers")]
        public string isOthers { get; set; }
        [DataMember(Name = "isIncidents")]
        public string isIncidents { get; set; }
        [DataMember(Name = "isMoCRA")]
        public string isMoCRA { get; set; }
        [DataMember(Name = "isDrill")]
        public string isDrill { get; set; }
        [DataMember(Name = "isAuditInspection")]
        public string isAuditInspection { get; set; }
        [DataMember(Name = "isManningDocuments")]
        public string isManningDocuments { get; set; }
        [DataMember(Name = "isOpenreportsComplaints")]
        public string isOpenreportsComplaints { get; set; }
        [DataMember(Name = "isCrewChangeApproval")]
        public string isCrewChangeApproval { get; set; }
        [DataMember(Name = "isActionItem")]
        public string isActionItem { get; set; }
        [DataMember(Name = "isNotes")]
        public string isNotes { get; set; }
        [DataMember(Name = "imonumber")]
        public string imonumber { get; set; }


        public static VesselListModel TranslateAsVesselList(DataRow dr)
        {
            var item = new VesselListModel();

            item.id = General.GetNullableString(dr["FLDVESSELID"].ToString());
            item.imageUrl = General.GetNullableString(dr["FLDVESSELNAME"].ToString());
            item.vesselname = General.GetNullableString(dr["FLDVESSELNAME"].ToString());
            item.fromAt = General.GetNullableString(dr["FLDFROMAT"].ToString());
            item.to = General.GetNullableString(dr["FLDTO"].ToString());
            item.eta = General.GetNullableString(dr["FLDETA"].ToString());
            item.etd = General.GetNullableString(dr["FLDETD"].ToString());
            item.speed = General.GetNullableString(dr["FLDSPEED"].ToString());
            item.isVesselperformance = General.GetNullableString(dr["FLDISVESSELPERFORMANCE"].ToString());
            item.isCertsurvey = General.GetNullableString(dr["FLDISCERTSURVEY"].ToString());
            item.isPMS = General.GetNullableString(dr["FLDISPMS"].ToString());
            item.isPurchase = General.GetNullableString(dr["FLDISPURCHASE"].ToString());
            item.isCargooperation = General.GetNullableString(dr["FLDISCARGOOPERATION"].ToString());
            item.isTradingareawx = General.GetNullableString(dr["FLDISTRADINGAREAWX"].ToString());
            item.isPSCvetting = General.GetNullableString(dr["FLDISPSCVETTING"].ToString());
            item.isOthers = General.GetNullableString(dr["FLDISOTHERS"].ToString());
            item.isIncidents = General.GetNullableString(dr["FLDISINCIDENTS"].ToString());
            item.isMoCRA = General.GetNullableString(dr["FLDISMOCRA"].ToString());
            item.isDrill = General.GetNullableString(dr["FLDISDRILL"].ToString());
            item.isAuditInspection = General.GetNullableString(dr["FLDISAUDITINSPECTION"].ToString());
            item.isManningDocuments = General.GetNullableString(dr["FLDISMANNINGDOCUMENTS"].ToString());
            item.isOpenreportsComplaints = General.GetNullableString(dr["FLDISOPENREPORTSCOMPLAINTS"].ToString());
            item.isCrewChangeApproval = General.GetNullableString(dr["FLDISCREWCHANGEAPPROVAL"].ToString());
            item.isActionItem = General.GetNullableString(dr["FLDISACTIONITEM"].ToString());
            item.isNotes = General.GetNullableString(dr["FLDISNOTES"].ToString());
            item.imonumber = General.GetNullableString(dr["FLDIMONUMBER"].ToString());


            return item;
        }
        public static List<VesselListModel> TranslateAsVesselList(DataTable dt)
        {
            var list = new List<VesselListModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsVesselList(dr));
            }
            return list;
        }
    }


}