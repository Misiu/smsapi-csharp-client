namespace SMSApi.Api.Action
{
    public class ListFields : Rest<Response.Fields>
    {
        protected override string Resource => "contacts/fields";

        protected override RequestMethod Method => RequestMethod.GET;
    }
}