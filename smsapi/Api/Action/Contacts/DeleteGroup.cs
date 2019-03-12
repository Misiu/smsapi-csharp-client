using System;
using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
	public class DeleteGroup : Rest<Response.Base>
	{
		public DeleteGroup(string groupId)
        {
			GroupId = groupId;
		}

		protected override string Resource { get { return "contacts/groups/" + GroupId; } }

		protected override RequestMethod Method { get { return RequestMethod.DELETE; } }

		private string groupId;
		public string GroupId { get { return groupId; } private set { groupId = value; } }
	}
}
