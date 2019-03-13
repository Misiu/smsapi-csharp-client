namespace SMSApi.Api.Action
{
    public class GetGroupPermission : Rest<Response.GroupPermission>
    {
        public GetGroupPermission(string groupId, string username)
        {
            GroupId = groupId;
            Username = username;
        }

        protected override string Resource => "contacts/groups/" + GroupId + "/permissions/" + Username;

        protected override RequestMethod Method => RequestMethod.GET;

        private string _groupId;

        public string GroupId
        {
            get => _groupId;
            private set => _groupId = value;
        }

        private string _username;

        public string Username
        {
            get => _username;
            private set => _username = value;
        }
    }
}