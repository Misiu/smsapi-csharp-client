namespace SMSApi.Api.Action
{
    public class DeleteGroup : Rest<Response.Base>
    {
        public DeleteGroup(string groupId)
        {
            GroupId = groupId;
        }

        protected override string Resource => "contacts/groups/" + GroupId;

        protected override RequestMethod Method => RequestMethod.DELETE;

        private string _groupId;

        public string GroupId
        {
            get => _groupId;
            private set => _groupId = value;
        }
    }
}