using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public class ContactData
    {
        public ContactData() : this(true)
        { }

        public ContactData(bool seed) : this(GetSeedContact(seed))
        { }

        public ContactData(Contact[] contact)
        {
            _items.AddRange(contact);
        }

        //default characters
        private static Contact[] GetSeedContact(bool seed)
        {
            if (!seed)
                return new Contact[0];

            return new Contact[] {
                new Contact()
                {
                    Name = "John Doe",
                    Email = "john.doe@my.tccd.edu",
                    Subject = "Sup Bruh!",
                    Body = "",
                },
                new Contact()
                {
                    Name = "Jane Doe",
                    Email = "jane.doe@my.tccd.edu",
                    Subject = "Free Stuff:)",
                    Body = "",
                },
            };
        }

        public Contact[] GetAll()
        {
            var count = _items.Count;

            var temp = new Contact[count];
            var index = 0;
            foreach (var contact in _items)
            {
                temp[index++] = contact;
            };

            return temp;
        }

        private Contact FindContact(string name)
        {
            var pairs = new Dictionary<string, Contact>();

            foreach (var contact in _items)
            {
                if (String.Compare(name, contact.Name, true) == 0)
                    return contact;
            };

            return null;
        }

        public void AddContact(Contact contact)
        {
            _items.Add(contact);
        }

        public void RemoveContact(string name)
        {
            var contact = FindContact(name);
            if (contact != null)
                _items.Remove(contact);
        }

        public void EditContact(string name, Contact contact)
        {
            RemoveContact(name);

            AddContact(contact);
        }

        //list of characters
        private List<Contact> _items = new List<Contact>();
    }
}
