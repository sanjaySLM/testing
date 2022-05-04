using SouthNests.Phoenix.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SouthNests.PhoenixMobile.Model
{
    [DataContract]
    public class Email
    {
        [DataMember(Name = "elementId")]
        public int elementId { get; set; }
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "vesselId")]
        public int vesselId { get; set; }
        [DataMember(Name = "departmentid")]
        public int departmentid { get; set; }
        [DataMember(Name = "departmenttypeid")]
        public int departmenttypeid { get; set; }
    }

    [DataContract]
    public class SetTemplateForEmailModel
    {
        [DataMember(Name = "FLDTEMPLATEID")]
        public string FLDTEMPLATEID { get; set; }
        [DataMember(Name = "FLDTEMPLATENAME")]
        public string FLDTEMPLATENAME { get; set; }
        [DataMember(Name = "FLDTOEMAIL")]
        public string FLDTOEMAIL { get; set; }
        [DataMember(Name = "FLDSUBJECT")]
        public string FLDSUBJECT { get; set; }
        [DataMember(Name = "FLDMAILBODY")]
        public string FLDMAILBODY { get; set; }
        [DataMember(Name = "FLDISACTIVE")]
        public string FLDISACTIVE { get; set; }



        public static SetTemplateForEmailModel TranslateAsAction(DataRow dr)
        {
            var item = new SetTemplateForEmailModel();

            item.FLDTEMPLATEID = General.GetNullableString(dr["FLDTEMPLATEID"].ToString());
            item.FLDTEMPLATENAME = General.GetNullableString(dr["FLDTEMPLATENAME"].ToString());
            item.FLDTOEMAIL = General.GetNullableString(dr["FLDTOEMAIL"].ToString());
            item.FLDSUBJECT = General.GetNullableString(dr["FLDSUBJECT"].ToString());
            item.FLDMAILBODY = General.GetNullableString(dr["FLDMAILBODY"].ToString());
            item.FLDISACTIVE = General.GetNullableString(dr["FLDISACTIVE"].ToString());

            return item;
        }
        public static List<SetTemplateForEmailModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<SetTemplateForEmailModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }


    }

        [DataContract]
        public class EmailInfoForVesselModel
        {
            [DataMember(Name = "FLDTOMAIL")]
            public string FLDTOMAIL { get; set; }
            [DataMember(Name = "FLDCCMAIL")]
            public string FLDCCMAIL { get; set; }
            [DataMember(Name = "FLDOWNERMAIL")]
            public string FLDOWNERMAIL { get; set; }


            public static EmailInfoForVesselModel TranslateAsAction(DataRow dr)
            {
                var item = new EmailInfoForVesselModel();

                item.FLDTOMAIL = General.GetNullableString(dr["FLDTOMAIL"].ToString());
                item.FLDCCMAIL = General.GetNullableString(dr["FLDCCMAIL"].ToString());
                item.FLDOWNERMAIL = General.GetNullableString(dr["FLDOWNERMAIL"].ToString());

                return item;
            }
            public static List<EmailInfoForVesselModel> TranslateAsActionList(DataTable dt)
            {
                var list = new List<EmailInfoForVesselModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(TranslateAsAction(dr));
                }
                return list;
            }
        }

    [DataContract]
    public class DepartmentForEmailModel
    {
        [DataMember(Name = "FLDDEPARTMENTID")]
        public string FLDDEPARTMENTID { get; set; }
        [DataMember(Name = "FLDDEPARTMENTCODE")]
        public string FLDDEPARTMENTCODE { get; set; }
        [DataMember(Name = "FLDDEPARTMENTNAME")]
        public string FLDDEPARTMENTNAME { get; set; }
        [DataMember(Name = "FLDDEPARTMENTTYPEID")]
        public string FLDDEPARTMENTTYPEID { get; set; }

        public static DepartmentForEmailModel TranslateAsAction(DataRow dr)
        {
            var item = new DepartmentForEmailModel();

            item.FLDDEPARTMENTID = General.GetNullableString(dr["FLDDEPARTMENTID"].ToString());
            item.FLDDEPARTMENTCODE = General.GetNullableString(dr["FLDDEPARTMENTCODE"].ToString());
            item.FLDDEPARTMENTNAME = General.GetNullableString(dr["FLDDEPARTMENTNAME"].ToString());
            item.FLDDEPARTMENTTYPEID = General.GetNullableString(dr["FLDDEPARTMENTTYPEID"].ToString());

            return item;
        }
        public static List<DepartmentForEmailModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DepartmentForEmailModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



    [DataContract]
    public class DesignationForCreateTaskModel
    {
        [DataMember(Name = "FLDDESIGNATIONID")]
        public string FLDDESIGNATIONID { get; set; }
        [DataMember(Name = "FLDDESIGNATIONCODE")]
        public string FLDDESIGNATIONCODE { get; set; }
        [DataMember(Name = "FLDDESIGNATIONNAME")]
        public string FLDDESIGNATIONNAME { get; set; }


        public static DesignationForCreateTaskModel TranslateAsAction(DataRow dr)
        {
            var item = new DesignationForCreateTaskModel();

            item.FLDDESIGNATIONID = General.GetNullableString(dr["FLDDESIGNATIONID"].ToString());
            item.FLDDESIGNATIONCODE = General.GetNullableString(dr["FLDDESIGNATIONCODE"].ToString());
            item.FLDDESIGNATIONNAME = General.GetNullableString(dr["FLDDESIGNATIONNAME"].ToString());

            return item;
        }
        public static List<DesignationForCreateTaskModel> TranslateAsActionList(DataTable dt)
        {
            var list = new List<DesignationForCreateTaskModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsAction(dr));
            }
            return list;
        }
    }



}