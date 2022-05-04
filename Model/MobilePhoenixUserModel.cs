using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using SouthNests.Phoenix.Framework;

namespace SouthNests.PhoenixMobile.Model
{

    public class MobilePhoenixUserLogin
    {
        [DataMember(Name = "username")]
        public string username { get; set; }

        [DataMember(Name = "password")]
        public string password { get; set; }
    }

    [DataContract]
    public class MobilePhoenixUserContext
    {
        [DataMember(Name = "FLDUSERNAME")]
        public string FLDUSERNAME { get; set; }

        [DataMember(Name = "FLDUSERCODE")]
        public int? FLDUSERCODE { get; set; }
        [DataMember(Name = "FLDREGISTEREDCOMPANYID")]
        public int? FLDREGISTEREDCOMPANYID { get; set; }
        [DataMember(Name = "FLDDEFAULTCOMPANYID")]
        public int? FLDDEFAULTCOMPANYID { get; set; }


        public static MobilePhoenixUserContext TranslateAsUserContext(DataRow dr)
        {
            var item = new MobilePhoenixUserContext();
            

            item.FLDUSERCODE = General.GetNullableInteger(dr["FLDUSERCODE"].ToString());
            item.FLDUSERNAME = General.GetNullableString(dr["FLDUSERNAME"].ToString());
            item.FLDREGISTEREDCOMPANYID = General.GetNullableInteger(dr["FLDREGISTEREDCOMPANYID"].ToString());
            item.FLDDEFAULTCOMPANYID = General.GetNullableInteger(dr["FLDDEFAULTCOMPANYID"].ToString());

            return item;
        }
        public static List<MobilePhoenixUserContext> TranslateAsUserContextList(DataTable dt)
        {
            var list = new List<MobilePhoenixUserContext>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(TranslateAsUserContext(dr));
            }
            return list;
        }
    }

}
    