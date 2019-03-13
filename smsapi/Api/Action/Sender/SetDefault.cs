using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class SenderSetDefault : BaseSimple<Response.Base>
    {
        protected override string Uri() => "sender.do";

        private string _name;

        public SenderSetDefault Name(string name)
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
                {"default", _name}
            };

            return collection;
        }
    }
}