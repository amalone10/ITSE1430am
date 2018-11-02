using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Memory
{
    public class MemoryContactManager : ContactData
    {
        protected override IEnumerable<Contact> GetContacts()
        {
            return from item in _items
                select new Contact()
                {
                    Name = item.Name,
                    Email = item.Email,
                    Subject = item.Subject,
                    Body = item.Body,
                };
        }

        protected override Contact FindContact(string name)
        {
            var pairs = new Dictionary<string, Contact>();

            return (from contact in _items
                    where String.Compare(name, contact.Name, true) == 0
                    select contact).FirstOrDefault;
        }

        protected override AddContact(Contact contact) => _items.Add(contact);

        protected override void RemoveContact(string name)
        {
            var contact = FindContact(name);
            if (contact != null)
                _items.Remove(contact);
        }

        protected override void EditContact(string name, Contact contact)
        {
            RemoveContact(name);

            AddContact(contact);
        }

        private List<Contact> _items = new List<Contact>();
    }
}
