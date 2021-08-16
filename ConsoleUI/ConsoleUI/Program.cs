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
            PersonModel person = new PersonModel("Balboa");

            person.FirstName = "Nicko";
           // person.LastName = "Balboa";
            person.Age = 12;
            person.SSN = "123-45-6789";
            Console.WriteLine(person.SSN);
            Console.WriteLine(person.FullName);
            Console.WriteLine();

            
        }
    }
}
