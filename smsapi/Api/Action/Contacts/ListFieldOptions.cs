namespace SMSApi.Api.Action
{
    public class ListFieldOptions : Rest<Response.FieldOptions>
    {
        public ListFieldOptions(string fieldId)
        {
            _fieldId = fieldId;
        }

        protected override string Resource => "contacts/fields/" + FieldId + "/options";

        protected override RequestMethod Method => RequestMethod.GET;

        private string _fieldId;

        public string FieldId => _fieldId;
    }
}