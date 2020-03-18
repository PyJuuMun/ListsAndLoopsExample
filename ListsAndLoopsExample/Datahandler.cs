using System;
using System.Collections.Generic;
using System.Text;

namespace ListsAndLoopsExample
{
    class Datahandler
    {
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki.");
            var merkki = Console.ReadLine();
            //syötetään hinta, paahto 1-5
            //ei companyä
            Coffee toReturn = new Coffee(merkki);
            toReturn.roast = (Coffee.Roast)2;
            return toReturn;
        }

        //metodi luo persoonan

        public Person CreatePerson()
        {
            Console.WriteLine("");
        }
    }
}
