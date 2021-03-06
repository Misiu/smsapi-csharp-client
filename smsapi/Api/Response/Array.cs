﻿using System.Runtime.Serialization;

namespace SMSApi.Api.Response
{
    [DataContract]
    public class Array<T> : Countable
    {
        public Array(System.Collections.Generic.List<T> list)
            : base(list.Count)
        {
            List = list;
        }

        [DataMember(Name = "list", IsRequired = true)]
        public readonly System.Collections.Generic.List<T> List;
    }
}