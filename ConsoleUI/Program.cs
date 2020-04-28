using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonModel person = new PersonModel();
            //person.FirstName = "Tim";

            //PersonModel secondPerson = new PersonModel();
            //secondPerson.FirstName = "Sue";

            //Console.WriteLine(person.FirstName);
            //Console.WriteLine(secondPerson.FirstName);

            //---------------------------------------------

            //List<PersonModel> people = new List<PersonModel>();

            //PersonModel person = new PersonModel();
            //person.FirstName = "Tim";
            //people.Add(person);

            //person = new PersonModel();
            //person.FirstName = "Sue";
            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.FirstName);
            //}

            //----------------------------------------------

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            do
            {
                Console.WriteLine("What is your first name? (type exit to stop):" );
                firstName = Console.ReadLine();

                Console.WriteLine("What is your last name?:");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }


            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }
            
            Console.ReadLine();
        }
    }
}
