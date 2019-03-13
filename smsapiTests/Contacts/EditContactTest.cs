using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMSApi.Api.Response;

namespace smsapiTests.Contacts
{
    [TestClass]
    public class EditContactTest : TestBase
    {
        Contact contact;

        [TestMethod]
        public void TestEditContact()
        {
            var editContact = contactsFactory.EditContact(contact.Id)
                                .SetFirstName("Tester")
                                .Execute();

            Assert.AreEqual(contact.Id, editContact.Id);
            Assert.AreEqual("Tester", editContact.FirstName);
        }

        [TestInitialize]
        [TestCleanup]
        public void Initialize()
        {
            var contactsResponse = contactsFactory.ListContacts().SetPhoneNumber(validTestNumber).Execute();
            if (contactsResponse.Collection.Count > 0)
            {
                contact = contactsResponse.Collection[0];
            }
            else
            {
                contact = contactsFactory.CreateContact().SetPhoneNumber(validTestNumber).Execute();
            }
        }
    }
}
