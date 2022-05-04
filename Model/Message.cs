using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SouthNests.PhoenixMobile.Model
{
    [DataContract]
    public class Message<T>
    {
        [DataMember(Name ="IsSuccess")]
        public string IsSuccess { get; set; }

        [DataMember(Name ="ReturnMessage")]
        public string ReturnMessage { get; set; }

        [DataMember(Name="Data")]
        public T Data { get; set; }

    }
}