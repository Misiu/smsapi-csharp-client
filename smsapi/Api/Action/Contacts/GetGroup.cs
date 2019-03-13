namespace SMSApi.Api.Action
{
    public class GetGroup : Rest<Response.Group>
    {
        public GetGroup(string groupId)
        {
            GroupId = groupId;
        }

        protected override string Resource => "contacts/groups/" + GroupId;

        protected override RequestMethod Method => RequestMethod.GET;

        private string _groupId;

        public string GroupId
        {
            get => _groupId;
            private set => _groupId = value;
        }
    }
}