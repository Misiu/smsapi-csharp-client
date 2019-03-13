
namespace SMSApi.Api
{
    public class VMSFactory : Factory
    {
        public VMSFactory()
        {
        }

        public VMSFactory(Client client) : base(client)
        {
        }

        public VMSFactory(Client client, IProxy proxy) : base(client, proxy)
        {
        }

        public Action.VMSDelete ActionDelete(string id = null)
        {
            var action = new Action.VMSDelete();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public Action.VMSGet ActionGet(string id = null)
        {
            var action = new Action.VMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public Action.VMSGet ActionGet(string[] id)
        {
            var action = new Action.VMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Ids(id);

            return action;
        }

        public Action.VMSSend ActionSend(string to = null)
        {
            var tos = (to == null ? null : new[] {to});
            return ActionSend(tos);
        }

        public Action.VMSSend ActionSend(string[] to)
        {
            var action = new Action.VMSSend();
            action.Client(client);
            action.Proxy(proxy);
            action.SetTo(to);

            return action;
        }
    }
}