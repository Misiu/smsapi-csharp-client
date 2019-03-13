using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class SenderList : BaseArray<Response.Sender>
    {
        protected override string Uri() => "sender.do";

        protected override NameValueCollection Values()
        {
            var collection = new NameValueCollection
            {
                {"format", "json"},
                {"username", client.GetUsername()},
                {"password", client.GetPassword()},
                {"list", "1"}
            };

            return collection;
        }
    }
}