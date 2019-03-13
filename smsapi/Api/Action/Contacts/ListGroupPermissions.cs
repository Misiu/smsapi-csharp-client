namespace SMSApi.Api.Action
{
    public class ListGroupPermissions : Rest<Response.GroupPermissions>
    {
        public ListGroupPermissions(string groupId)
        {
            GroupId = groupId;
        }

        protected override string Resource => "contacts/groups/" + GroupId + "/permissions";

        protected override RequestMethod Method => RequestMethod.GET;

        private string _groupId;

        public string GroupId
        {
            get => _groupId;
            private set => _groupId = value;
        }
    }
}