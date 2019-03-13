using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SMSApi.Api.Response
{
    [DataContract]
    public class Group : Base
    {
        private Group()
        {
        }

        [DataMember(Name = "id", IsRequired = false)]
        public readonly string Id;

        [DataMember(Name = "name", IsRequired = true)]
        public readonly string Name;

        private int _contactsCount;

        [DataMember(Name = "contacts_count", IsRequired = false)]
        public int ContactsCount
        {
            get => _contactsCount;
            private set => _contactsCount = value;
        }

        private DateTime? _dateCreated;

        [DataMember(Name = "date_created", IsRequired = false)]
        private string DateCreatedSerializationHelper
        {
            set => _dateCreated = DateTime.Parse(value);
            get => "";
        }

        public DateTime? DateCreated => _dateCreated;

        private DateTime? _dateUpdated;

        [DataMember(Name = "date_updated", IsRequired = false)]
        private string DateUpdatedSerializationHelper
        {
            set => _dateUpdated = DateTime.Parse(value);
            get => "";
        }

        public DateTime? DateUpdated => _dateUpdated;

        private string _description;

        [DataMember(Name = "description", IsRequired = false)]
        public string Description
        {
            get => _description;
            private set => _description = value;
        }

        [DataMember(Name = "created_by", IsRequired = false)]
        public readonly string CreatedBy;

        [DataMember(Name = "idx", IsRequired = false)]
        public readonly string Idx;

        [DataMember(Name = "permissions", IsRequired = false)]
        private List<GroupPermission> _permissions;

        public List<GroupPermission> Permissions => _permissions ?? (_permissions = new List<GroupPermission>());

        [Obsolete("use Description instead")]
        [DataMember(Name = "info", IsRequired = false)]
        public string Info
        {
            get => Description;
            private set => Description = value;
        }

        [Obsolete("use ContactsCount instead")]
        [DataMember(Name = "numbers_count", IsRequired = false)]
        public uint NumbersCount
        {
            get => (uint) ContactsCount;
            private set => ContactsCount = (int) value;
        }
    }
}