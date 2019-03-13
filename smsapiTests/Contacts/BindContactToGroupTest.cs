using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMSApi.Api.Response;

namespace smsapiTests.Contacts
{
    [TestClass]
    public class BindContactToGroupTest : TestBase
    {
        Contact contact;
        Group group;

        [TestMethod]
        public void TestBindContactToGroup()
        {
            var response = contactsFactory.BindContactToGroup(contact.Id, group.Id).Execute();

            Assert.IsFalse(response.isError());
        }

        [TestInitialize]
        public void Initialize()
        {
            var contactsResponse = contactsFactory.ListContacts().SetPhoneNumber(validTestNumber).Execute();
            if (contactsResponse.Collection.Count > 0)
                contact = contactsResponse.Collection[0];
            else
                contact = contactsFactory.CreateContact().SetPhoneNumber(validTestNumber).Execute();

            var groupsResponse = contactsFactory.ListGroups().SetName("example group").Execute();
            if (groupsResponse.Collection.Count > 0)
                group = groupsResponse.Collection[0];
            else
                group = contactsFactory.CreateGroup().SetName("example group").Execute();
        }

        [TestCleanup]
        public void Cleanup()
        {
            contactsFactory.DeleteContact(contact.Id).Execute();
            contactsFactory.DeleteGroup(group.Id).Execute();
        }
    }
}
