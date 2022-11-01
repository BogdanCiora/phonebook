using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Phonebook!");

            Console.WriteLine("Your phonebook contains the following contacts:");

            var agenda = new Agenda
            {
                Contacts = new List<Contact>()
            };

            do
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to see your contacts? If 'No' you are going to add a new contact");
                var answer = Console.ReadLine();

                if (answer == "yes" && agenda.NumberOfContacts == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("There are no contacts so far");
                    Console.WriteLine();
                }
                else if (answer == "yes" && agenda.NumberOfContacts > 0) 
                {
                    agenda.DisplayContacts();
                }
                else if (answer == "no")
                {
                    agenda.AddContact();
                }
            } while (true);
        }
    }
}
