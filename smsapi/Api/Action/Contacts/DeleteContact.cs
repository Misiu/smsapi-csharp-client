namespace SMSApi.Api.Action
{
    public class DeleteContact : Rest<Response.Base>
    {
        public DeleteContact(string contactId)
        {
            ContactId = contactId;
        }

        protected override string Resource => "contacts/" + ContactId;

        protected override RequestMethod Method => RequestMethod.DELETE;

        private string _contactId;

        public string ContactId
        {
            get => _contactId;
            private set => _contactId = value;
        }
    }
}