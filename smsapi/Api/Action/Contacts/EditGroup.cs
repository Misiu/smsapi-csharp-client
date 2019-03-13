using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class EditGroup : Rest<Response.Group>
    {
        public EditGroup(string groupId)
        {
            GroupId = groupId;
        }

        protected override string Resource => "contacts/groups/" + GroupId;

        protected override RequestMethod Method => RequestMethod.PUT;

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

        private string _groupId;

        public string GroupId
        {
            get => _groupId;
            private set => _groupId = value;
        }

        public string Name;

        public EditGroup SetName(string name)
        {
            Name = name;
            return this;
        }

        public string Description;

        public EditGroup SetDescription(string description)
        {
            Description = description;
            return this;
        }

        public string Idx;

        public EditGroup SetIdx(string idx)
        {
            Idx = idx;
            return this;
        }
    }
}