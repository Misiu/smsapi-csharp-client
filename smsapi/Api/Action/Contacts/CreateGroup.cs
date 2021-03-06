using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class CreateGroup : Rest<Response.Group>
    {
        protected override string Resource => "contacts/groups";

        protected override RequestMethod Method => RequestMethod.POST;

        protected override NameValueCollection Parameters
        {
            get
            {
                var parameters = base.Parameters;
                if (Name != null) parameters.Add("name", Name);
                if (Description != null) parameters.Add("desciption", Description);
                if (Idx != null) parameters.Add("idx", Idx);
                return parameters;
            }
        }

        public string Name;

        public CreateGroup SetName(string name)
        {
            Name = name;
            return this;
        }

        public string Description;

        public CreateGroup SetDescription(string description)
        {
            Description = description;
            return this;
        }

        public string Idx;

        public CreateGroup SetIdx(string idx)
        {
            Idx = idx;
            return this;
        }
    }
}