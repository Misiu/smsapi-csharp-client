using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class SMSDelete : BaseSimple<Response.Countable>
    {
        protected override string Uri()
        {
            return "sms.do";
        }

        private string _id;

        protected override NameValueCollection Values()
        {
            var collection = new NameValueCollection
            {
                {"format", "json"},
                {"username", client.GetUsername()},
                {"password", client.GetPassword()},
                {"sch_del", _id}
            };

            return collection;
        }

        public SMSDelete Id(string id)
        {
            _id = id;
            return this;
        }
    }
}