using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var item in contacts)
            {
                DisplayContactDetails(item);
            }
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if(contact == null)
            {
                Console.WriteLine("Contact invalid");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContacts()
        {
            
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
