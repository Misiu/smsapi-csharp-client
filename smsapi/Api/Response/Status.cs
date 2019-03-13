using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SMSApi.Api.Response
{
    [DataContract]
    public class Status : Countable
    {
        private Status()
        {
        }

        [DataMember(Name = "list", IsRequired = false)]
        private List<MessageStatus> _list;

        public List<MessageStatus> List => _list ?? (_list = new List<MessageStatus>());

        [DataMember(Name = "message", IsRequired = false)]
        public readonly string Message;

        [DataMember(Name = "length", IsRequired = false)]
        public readonly int? Length;

        [DataMember(Name = "parts", IsRequired = false)]
        public readonly int? Parts;
    }
}