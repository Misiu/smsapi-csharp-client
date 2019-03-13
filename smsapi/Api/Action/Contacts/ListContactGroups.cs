namespace SMSApi.Api.Action
{
    public class ListContactGroups : Rest<Response.Groups>
    {
        public ListContactGroups(string contactId)
        {
            ContactId = contactId;
        }

        protected override string Resource => "contacts/" + ContactId + "/groups";

        protected override RequestMethod Method => RequestMethod.GET;

        private string _contactId;

        public string ContactId
        {
            get => _contactId;
            private set => _contactId = value;
        }
    }
}