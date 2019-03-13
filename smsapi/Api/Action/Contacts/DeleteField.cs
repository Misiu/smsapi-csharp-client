namespace SMSApi.Api.Action
{
    public class DeleteField : Rest<Response.Base>
    {
        public DeleteField(string fieldId)
        {
            FieldId = fieldId;
        }

        protected override string Resource => "contacts/fields/" + FieldId;

        protected override RequestMethod Method => RequestMethod.DELETE;

        private string _fieldId;

        public string FieldId
        {
            get => _fieldId;
            private set => _fieldId = value;
        }
    }
}