using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{

    [DataContract]
    public class CategoryModelFilter
    {
        [DataMember(Name = "rowusercode")]
        public int rowusercode { get; set; }
        [DataMember(Name = "categoryid")]
        public int? categoryid { get; set; }
    }

    [DataContract]
    public class CategoryModel
    {
        [DataMember(Name = "categoryid")]
        public string categoryid { get; set; }
        [DataMember(Name = "categorycode")]
        public string categorycode { get; set; }
        [DataMember(Name = "categoryname")]
        public string categoryname { get; set; }


        public static CategoryModel TranslateAsCategory(DataRow dr)
        {
            var item = new CategoryModel();

            item.categoryid = General.GetNullableString(dr["FLDCATEGORYID"].ToString());
            item.categorycode = General.GetNullableString(dr["FLDCATEGORYCODE"].ToString());
            item.categoryname = General.GetNullableString(dr["FLDCATEGORYNAME"].ToString());
            return item;
        }
        public static List<CategoryModel> TranslateAsCategoryList(DataTable dt)
        {
            var list = new List<CategoryModel>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsCategory(dr));
            }
            return list;
        }
    }



}