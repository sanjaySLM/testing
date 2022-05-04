using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{
    [DataContract]
    public class VesselKeyDetailFilter
    {
        [DataMember(Name = "vesselid")]
        public int vesselid { get; set; }

    }
    [DataContract]
    public class VesselModelSearch
    {
        [DataMember(Name = "rowUserCode")]
        public string rowUserCode { get; set; }
        [DataMember(Name = "sortBy")]
        public string sortBy { get; set; }
        [DataMember(Name = "typeid")]
        public string typeid { get; set; }
        [DataMember(Name = "sortDirection")]
        public string sortDirection { get; set; }
        [DataMember(Name = "pageNumber")]
        public int pageNumber { get; set; }
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "pageSize")]
        public int pageSize { get; set; }
        [DataMember(Name = "resultCount")]
        public int? resultCount { get; set; }
        [DataMember(Name = "totalPageCount")]
        public int? totalPageCount { get; set; }

    }




    [DataContract]
    public class VesselKeyDetailsModel
    {
        //[DataMember(Name = "mastername")]
        //public string mastername { get; set; }
        //[DataMember(Name = "cename")]
        //public string cename { get; set; }
        //[DataMember(Name = "previousport")]
        //public string previousport { get; set; }
        //[DataMember(Name ="nextport" )]
        //public string nextport{ get; set; }
        //[DataMember(Name = "eta")]
        //public string eta { get; set; }
        //[DataMember(Name = "latitude")]
        //public string latitude { get; set; }
        //[DataMember(Name = "longitude")]
        //public string longitude { get; set; }
        //[DataMember(Name = "speed")]
        //public string speed { get; set; }
        //[DataMember(Name = "fuelcons")]
        //public string fuelcons { get; set; }
        //[DataMember(Name = "lastpscdate")]
        //public string lastpscdate { get; set; }
        //[DataMember(Name = "lastsiredate")]
        //public string lastsiredate { get; set; }
        //[DataMember(Name = "lastdrydockdate")]
        //public string lastdrydockdate { get; set; }
        //[DataMember(Name = "exportdate")]
        //public string exportdate { get; set; }
        //[DataMember(Name = "importdate")]
        //public string importdate { get; set; }
        //[DataMember(Name = "sparelifeboatcapacity")]
        //public string sparelifeboatcapacity { get; set; }
        //[DataMember(Name = "onboardcrewcount")]
        //public string onboardcrewcount  { get; set; }
        //[DataMember(Name ="exportsequence")]
        //public string exportsequence { get; set; }
        //[DataMember(Name = "importsequence")]
        //public string importsequence { get; set; }

        //
        [DataMember(Name = "FLDMASTERNAME")]
        public string FLDMASTERNAME { get; set; }
        [DataMember(Name = "FLDCENAME")]
        public string FLDCENAME { get; set; }
        [DataMember(Name = "FLDPREVIOUSPORT")]
        public string FLDPREVIOUSPORT { get; set; }
        [DataMember(Name = "FLDNEXTPORT")]
        public string FLDNEXTPORT { get; set; }
        [DataMember(Name = "FLDETA")]
        public string FLDETA { get; set; }
        [DataMember(Name = "FLDLASTREPORTEDPOSITION")]
        public string FLDLASTREPORTEDPOSITION { get; set; }
        [DataMember(Name = "FLDSPEED")]
        public string FLDSPEED { get; set; }
        [DataMember(Name = "FLDCARGOONBOARD")]
        public string FLDCARGOONBOARD { get; set; }
        [DataMember(Name = "FLDLASTPSCINSPECTION")]
        public string FLDLASTPSCINSPECTION { get; set; }
        [DataMember(Name = "FLDLASTSIREINSPECTION")]
        public string FLDLASTSIREINSPECTION { get; set; }
        [DataMember(Name = "FLDLASTDRYDOCK")]
        public string FLDLASTDRYDOCK { get; set; }
        [DataMember(Name = "FLDLASTEXPORTNOANDDATE")]
        public string FLDLASTEXPORTNOANDDATE { get; set; }
        [DataMember(Name = "FLDLASTIMPORTNOANDDATE")]
        public string FLDLASTIMPORTNOANDDATE { get; set; }
        [DataMember(Name = "FLDSPARELIFEBOATCAPACITY")]
        public string FLDSPARELIFEBOATCAPACITY { get; set; }
        [DataMember(Name = "FLDONBOARDCREWCOUNT")]
        public string FLDONBOARDCREWCOUNT { get; set; }








        public static VesselKeyDetailsModel TranslateAsVesselKeyDetailsModel(DataRow dr)
        {
            var item = new VesselKeyDetailsModel();

            //item.mastername = General.GetNullableString(dr["FLDMASTERNAME"].ToString());
            //item.cename = General.GetNullableString(dr["FLDCENAME"].ToString());
            //item.previousport = General.GetNullableString(dr["FLDPREVIOUSPORT"].ToString());
            //item.nextport = General.GetNullableString(dr["FLDNEXTPORT"].ToString());
            //item.eta = General.GetNullableString(dr["FLDETA"].ToString());
            //item.latitude = General.GetNullableString(dr["FLDLATITUDE"].ToString());
            //item.longitude = General.GetNullableString(dr["FLDLONGITUDE"].ToString());
            //item.speed = General.GetNullableString(dr["FLDSPEED"].ToString());
            //item.fuelcons = General.GetNullableString(dr["FLDFUELCONS"].ToString());
            //item.lastpscdate = General.GetNullableString(dr["FLDLASTPSCDATE"].ToString());
            //item.lastsiredate = General.GetNullableString(dr["FLDLASTSIREDATE"].ToString());
            //item.lastdrydockdate = General.GetNullableString(dr["FLDLASTDRYDOCKDATE"].ToString());
            //item.exportdate = General.GetNullableString(dr["FLDEXPORTDATE"].ToString());
            //item.importdate = General.GetNullableString(dr["FLDIMPORTDATE"].ToString());
            //item.sparelifeboatcapacity = General.GetNullableString(dr["FLDSPARELIFEBOATCAPACITY"].ToString());
            //item.onboardcrewcount = General.GetNullableString(dr["FLDONBOARDCREWCOUNT"].ToString());
            //item.exportsequence = General.GetNullableString(dr["FLDEXPORTSEQUENCE"].ToString());
            //item.importsequence = General.GetNullableString(dr["FLDIMPORTSEQUENCE"].ToString());



            //
            item.FLDMASTERNAME = General.GetNullableString(dr["FLDMASTERNAME"].ToString()); 
            item.FLDCENAME = General.GetNullableString(dr["FLDCENAME"].ToString());
            item.FLDPREVIOUSPORT = General.GetNullableString(dr["FLDPREVIOUSPORT"].ToString());
            item.FLDNEXTPORT = General.GetNullableString(dr["FLDNEXTPORT"].ToString());
            item.FLDETA = General.GetNullableString(dr["FLDETA"].ToString());
            item.FLDLASTREPORTEDPOSITION = "Lat: " + General.GetNullableString(dr["FLDLATITUDE"].ToString()) + " Long: " + General.GetNullableString(dr["FLDLONGITUDE"].ToString());
            item.FLDSPEED = General.GetNullableString(dr["FLDSPEED"].ToString());
            item.FLDCARGOONBOARD = General.GetNullableString(dr["FLDCARGOONBOARD"].ToString());
            item.FLDLASTPSCINSPECTION = dr["FLDPSCDONEBY"].ToString() + "-" + dr["FLDLASTPSCDATE"].ToString();
            item.FLDLASTSIREINSPECTION = dr["FLDSIREDONEBY"].ToString() + "-" + dr["FLDLASTSIREDATE"].ToString();
            item.FLDLASTDRYDOCK = string.Format("{0:dd/MM/yyyy}", dr["FLDDRYDOCKDATEFROMORDER"]);
            item.FLDLASTEXPORTNOANDDATE = dr["FLDEXPORTSEQUENCE"].ToString() + " - " + dr["FLDEXPORTDATE"].ToString();
            item.FLDLASTIMPORTNOANDDATE = dr["FLDIMPORTSEQUENCE"].ToString() + " - " + dr["FLDIMPORTDATE"].ToString();
            item.FLDSPARELIFEBOATCAPACITY = (General.GetNullableInteger(dr["FLDLIFEBOATCAPACITY"].ToString()) - General.GetNullableInteger(dr["FLDONBOARDCREWCOUNT"].ToString())).ToString();
            item.FLDONBOARDCREWCOUNT = dr["FLDONBOARDCREWCOUNT"].ToString() + " Crew/Passenger";



            return item;
        }
        public static List<VesselKeyDetailsModel> TranslateAsVesselKeyDetailsModelList(DataTable dt)
        {
            var list = new List<VesselKeyDetailsModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsVesselKeyDetailsModel(dr));
            }
            return list;
        }
    }




}