namespace SMSApi.Api.Action
{
    public class GetContact : Rest<Response.Contact>
    {
        public GetContact(string contactId)
        {
            ContactId = contactId;
        }

        protected override string Resource => "contacts/" + ContactId;

        protected override RequestMethod Method => RequestMethod.GET;

        private string _contactId;

        public string ContactId
        {
            get => _contactId;
            private set => _contactId = value;
        }
    }
}