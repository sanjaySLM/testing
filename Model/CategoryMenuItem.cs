using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{

    [DataContract]
    public class CategoryMenuItemModelFilter
    {
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "subcategoryid")]
        public int? subcategoryid { get; set; }

        [DataMember(Name = "istech")]
        public int? istech { get; set; }
        [DataMember(Name = "isoperation")]
        public int? isoperation { get; set; }
        [DataMember(Name = "ishseqa")]
        public int? ishseqa{ get; set; }
        [DataMember(Name = "iscrew")]
        public int? iscrew { get; set; }
        [DataMember(Name = "parentid")]
        public int? parentid { get; set; }
    }

    [DataContract]
    public class CategoryMenuItemModel
    {
        [DataMember(Name = "elementid")]
        public string elementid { get; set; }
        [DataMember(Name = "elementname")]
        public string elementname { get; set; }
        [DataMember(Name = "parentid")]
        public int? parentid { get; set; }

        public static CategoryMenuItemModel TranslateAsCategoryMenuItem(DataRow dr)
        {
            var item = new CategoryMenuItemModel();

            item.elementid = General.GetNullableString(dr["FLDELEMENTID"].ToString());
            item.elementname = General.GetNullableString(dr["FLDNAME"].ToString());
            item.parentid = General.GetNullableInteger(dr["FLDPARENTID"].ToString());
            return item;
        }
        public static List<CategoryMenuItemModel> TranslateAsCategoryMenuItemList(DataTable dt)
        {
            var list = new List<CategoryMenuItemModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsCategoryMenuItem(dr));
            }
            return list;
        }
    }



}