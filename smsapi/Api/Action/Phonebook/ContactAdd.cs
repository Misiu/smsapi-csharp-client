using System.Collections.Specialized;

namespace SMSApi.Api.Action
{
    public class PhonebookContactAdd : BaseSimple<Response.Contact>
    {
        protected override string Uri() => "phonebook.do";

        private string _number;
        private string _firstName;
        private string _lastName;
        private string _info;
        private int _birthday;
        private string _city;
        private string _gender;
        private string[] _groups;

        protected override NameValueCollection Values()
        {
            var collection = new NameValueCollection
            {
                {"format", "json"},
                {"username", client.GetUsername()},
                {"password", client.GetPassword()},
                {"add_contact", _number}
            };

            if (_firstName != null) collection.Add("first_name", _firstName);
            if (_lastName != null) collection.Add("last_name", _lastName);
            if (_info != null) collection.Add("info", _info);
            if (_birthday != 0) collection.Add("birthday", _birthday.ToString());
            if (_city != null) collection.Add("city", _city);
            if (_gender != null) collection.Add("gender", _gender);
            if (_groups != null) collection.Add("groups", string.Join(",", _groups));

            return collection;
        }

        public PhonebookContactAdd SetNumber(string number)
        {
            _number = number;
            return this;
        }

        public PhonebookContactAdd SetFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public PhonebookContactAdd SetLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public PhonebookContactAdd SetInfo(string info)
        {
            _info = info;
            return this;
        }

        public PhonebookContactAdd SetBirthday(int birthday)
        {
            _birthday = birthday;
            return this;
        }

        public PhonebookContactAdd SetCity(string city)
        {
            _city = city;
            return this;
        }

        public PhonebookContactAdd SetGender(string gender)
        {
            _gender = gender;
            return this;
        }

        public PhonebookContactAdd SetGroup(string group)
        {
            _groups = new[] {group};
            return this;
        }

        public PhonebookContactAdd SetGroups(string[] groups)
        {
            _groups = groups;
            return this;
        }
    }
}