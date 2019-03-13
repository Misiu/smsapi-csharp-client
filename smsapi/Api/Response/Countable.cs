using System.Runtime.Serialization;

namespace SMSApi.Api.Response
{
    [DataContract]
    public class Countable /*: Base*/
    {
        protected Countable(int count = 0)
        {
            _count = count;
        }

        private int _count;

        [DataMember(Name = "count", IsRequired = false)]
        public virtual int Count
        {
            get => _count;
            private set => _count = value;
        }
    }
}