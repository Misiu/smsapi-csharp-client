namespace SMSApi.Api.Action
{
    public class GetContactGroup : Rest<Response.Group>
    {
        public GetContactGroup(string contactId, string groupId)
        {
            ContactId = contactId;
            GroupId = groupId;
        }

        protected override string Resource => "contacts/" + _contactId + "/groups/" + _groupId;

        protected override RequestMethod Method => RequestMethod.GET;

        private string _contactId;

        public string ContactId
        {
            get => _contactId;
            private set => _contactId = value;
        }

        private string _groupId;

        public string GroupId
        {
            get => _groupId;
            private set => _groupId = value;
        }
    }
}