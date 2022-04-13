using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app!");
            Console.WriteLine("1 - Add new contact");
            Console.WriteLine("2 - Display contact by number");
            Console.WriteLine("3 - Display all contacts");
            Console.WriteLine("4 - Search contacts");
            Console.WriteLine("To exit insert 'x");

            string userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            while (true)
            {
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        bool numbers = true;
                        while (numbers)
                        {
                            if(number.Length == 9)
                            {
                                numbers = false;
                            }
                            else
                            {
                                Console.WriteLine("The number must consist of 9 digits");
                                Console.WriteLine("Insert number");
                                number = Console.ReadLine();
                                if(number.Length == 9)
                                {
                                    numbers = false;
                                }
                            }
                        }

                         Console.WriteLine("Insert name");
                        var name = Console.ReadLine();
                        var newContact = new Contact(name, number);
                         phoneBook.AddContact(newContact);




                        break;
                    case "2":
                        Console.WriteLine("Enter the number");
                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
           
        }
    }
}
