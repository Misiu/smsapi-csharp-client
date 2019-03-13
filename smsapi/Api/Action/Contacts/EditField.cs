using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class EditField : Rest<Response.Field>
    {
        public EditField(string fieldId)
        {
            FieldId = fieldId;
        }

        protected override string Resource => "contacts/fields/" + FieldId;

        protected override RequestMethod Method => RequestMethod.PUT;

        protected override NameValueCollection Parameters
        {
            get
            {
                var parameters = base.Parameters;
                if (Name != null) parameters.Add("name", Name);
                return parameters;
            }
        }

        private string _fieldId;

        public string FieldId
        {
            get => _fieldId;
            private set => _fieldId = value;
        }

        public string Name;

        public EditField SetName(string name)
        {
            Name = name;
            return this;
        }
    }
}