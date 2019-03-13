namespace SMSApi.Api.Action
{
    public class UnbindContactFromGroup : Rest<Response.Base>
    {
        public UnbindContactFromGroup(string contactId, string groupId)
        {
            ContactId = contactId;
            GroupId = groupId;
        }

        protected override string Resource => "contacts/" + _contactId + "/groups/" + groupId;

        protected override RequestMethod Method => RequestMethod.DELETE;

        private string _contactId;

        public string ContactId
        {
            get => _contactId;
            private set => _contactId = value;
        }

        private string groupId;

        public string GroupId
        {
            get => groupId;
            private set => groupId = value;
        }
    }
}