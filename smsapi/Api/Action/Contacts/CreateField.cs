using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class CreateField : Rest<Response.Field>
    {
        protected override string Resource => "contacts/fields";

        protected override RequestMethod Method => RequestMethod.POST;

        protected override NameValueCollection Parameters
        {
            get
            {
                var parameters = base.Parameters;
                if (Name != null) parameters.Add("name", Name);
                if (Type != null) parameters.Add("type", Type);
                return parameters;
            }
        }

        public string Name;

        public CreateField SetName(string name)
        {
            Name = name;
            return this;
        }

        public string Type;

        public CreateField SetType(string type)
        {
            Type = type;
            return this;
        }
    }
}