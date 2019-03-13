using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class PhonebookGroupAdd : BaseSimple<Response.Group>
    {
        protected override string Uri() => "phonebook.do";

        private string _name;
        private string _info;

        protected override NameValueCollection Values()
        {
            var collection = new NameValueCollection
            {
                {"format", "json"},
                {"username", client.GetUsername()},
                {"password", client.GetPassword()},
                {"add_group", _name}
            };

            if (_info != null) collection.Add("info", _info);

            return collection;
        }

        public PhonebookGroupAdd SetName(string name)
        {
            _name = name;
            return this;
        }

        public PhonebookGroupAdd SetInfo(string info)
        {
            _info = info;
            return this;
        }
    }
}