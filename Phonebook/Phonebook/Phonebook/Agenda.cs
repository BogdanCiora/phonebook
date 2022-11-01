using System;
using System.Collections.Generic;

namespace Phonebook
{
    public class Agenda
    {
        public List<Contact> Contacts { get; set; }

        public int NumberOfContacts { get => Contacts.Count; }

        public void CallContact(Contact contactToCall) 
        {
            Console.WriteLine("Contact is being called...");
        }

        public void SendSMS(Contact contactToSendSMSTo)
        {
            Console.WriteLine("Insert the text message: ");

            Console.WriteLine("Text message succesfully sent!");
        }

        public void AddContact()
        {
            Console.WriteLine();
            Console.WriteLine("Add new contact:");
            Console.Write("Contact First Name = ");

            var contactFirstName = Console.ReadLine();

            Console.Write("Contact Last Name = ");

            var lastdName = Console.ReadLine();

            Console.Write("Contact Phone Number = ");

            var phoneNumber = Console.ReadLine();

            var contactToAdd = new Contact
            {
                FirstName = contactFirstName,
                LastName = lastdName,
                PhoneNumber = phoneNumber
            };

            Contacts.Add(contactToAdd);

            Console.WriteLine();
        }

        public void DisplayContacts()
        {
            Console.WriteLine();
            Console.WriteLine("####### Contacts in your agenda #######");

            var i = 1;
            foreach (var contact in Contacts)
            {
                Console.WriteLine();
                Console.WriteLine("#Contact no " + i);
                Console.WriteLine("First name: " + contact.FirstName);
                Console.WriteLine("Last name: " + contact.LastName);
                Console.WriteLine("Phone number: " + contact.PhoneNumber);
                Console.WriteLine();

                i++;
            }
        }
    }
}
