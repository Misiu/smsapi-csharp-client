using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class SenderDelete : BaseSimple<Response.Base>
    {
        protected override string Uri() => "sender.do";

        private string _name;

        public SenderDelete Name(string name)
        {
            _name = name;
            return this;
        }

        protected override NameValueCollection Values()
        {
            var collection = new NameValueCollection
            {
                {"format", "json"},
                {"username", client.GetUsername()},
                {"password", client.GetPassword()},
                {"delete", _name}
            };

            return collection;
        }
    }
}