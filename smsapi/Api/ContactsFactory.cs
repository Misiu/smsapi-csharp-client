namespace SMSApi.Api
{
    public class ContactsFactory : Factory
    {
        public ContactsFactory(Client client) : base(client)
        {
            var proxyHttp = new ProxyHTTP("http://api.smsapi.pl/");
            proxyHttp.BasicAuthentication(client);
            Proxy(proxyHttp);
        }

        public ContactsFactory(Client client, IProxy proxy) : base(client, proxy)
        {
            proxy.BasicAuthentication(client);
            Proxy(proxy);
        }

        public Action.ListContacts ListContacts()
        {
            var action = new Action.ListContacts();
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.CreateContact CreateContact()
        {
            var action = new Action.CreateContact();
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.DeleteContact DeleteContact(string contactId)
        {
            var action = new Action.DeleteContact(contactId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.GetContact GetContact(string contactId)
        {
            var action = new Action.GetContact(contactId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.EditContact EditContact(string contactId)
        {
            var action = new Action.EditContact(contactId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.ListGroups ListGroups()
        {
            var action = new Action.ListGroups();
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.CreateGroup CreateGroup()
        {
            var action = new Action.CreateGroup();
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.DeleteGroup DeleteGroup(string groupId)
        {
            var action = new Action.DeleteGroup(groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.GetGroup GetGroup(string groupId)
        {
            var action = new Action.GetGroup(groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.EditGroup EditGroup(string groupId)
        {
            var action = new Action.EditGroup(groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.ListGroupPermissions ListGroupPermissions(string groupId)
        {
            var action = new Action.ListGroupPermissions(groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.ListFields ListFields()
        {
            var action = new Action.ListFields();
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.CreateField CreateField()
        {
            var action = new Action.CreateField();
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.DeleteField DeleteField(string fieldId)
        {
            var action = new Action.DeleteField(fieldId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.EditField EditField(string fieldId)
        {
            var action = new Action.EditField(fieldId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.ListFieldOptions ListFieldOptions(string fieldId)
        {
            var action = new Action.ListFieldOptions(fieldId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.BindContactToGroup BindContactToGroup(string contactId, string groupId)
        {
            var action = new Action.BindContactToGroup(contactId, groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.UnbindContactFromGroup UnbindContactFromGroup(string contactId, string groupId)
        {
            var action = new Action.UnbindContactFromGroup(contactId, groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.ListContactGroups ListContactGroups(string contactId)
        {
            var action = new Action.ListContactGroups(contactId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.GetContactGroup GetContactGroup(string contactId, string groupId)
        {
            var action = new Action.GetContactGroup(contactId, groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.CreateGroupPermission CreateGroupPermission(string groupId)
        {
            var action = new Action.CreateGroupPermission(groupId);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.DeleteGroupPermission DeleteGroupPermission(string groupId, string username)
        {
            var action = new Action.DeleteGroupPermission(groupId, username);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.GetGroupPermission GetGroupPermission(string groupId, string username)
        {
            var action = new Action.GetGroupPermission(groupId, username);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }

        public Action.EditGroupPermission EditGroupPermission(string groupId, string username)
        {
            var action = new Action.EditGroupPermission(groupId, username);
            action.Client(client);
            action.Proxy(proxy);
            return action;
        }
    }
}