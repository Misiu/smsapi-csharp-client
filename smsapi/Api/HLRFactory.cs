﻿namespace SMSApi.Api
{
    public class HLRFactory : Factory
    {
        public HLRFactory()
        {
        }

        public HLRFactory(Client client) : base(client)
        {
        }

        public HLRFactory(Client client, IProxy proxy) : base(client, proxy)
        {
        }

        public Action.HLRCheckNumber ActionCheckNumber(string number = null)
        {
            var action = new Action.HLRCheckNumber();

            action.Client(client);
            action.Proxy(proxy);

            action.SetNumber(number);

            return action;
        }
    }
}