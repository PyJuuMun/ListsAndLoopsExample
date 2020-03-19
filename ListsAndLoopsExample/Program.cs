using System;
using System.Collections.Generic;
namespace ListsAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Datahandler dh = new Datahandler();
            dh.FillPersonsWithTestData();
            dh.FillCompaniesWithTestData();
            dh.AddNewCompanyToList();
            dh.PrintCompanyList();
            Console.ReadKey();
            Console.Clear();
            Company company = dh.SelectCompanyFromList();
            Console.WriteLine($"Chosen {company.CompanyName}");


            //vanha koodi kommentoitu ulos 19.3

            //var dh = new Datahandler();
            //var kahvi = dh.CreateCoffee();
            //dh.coffees.Add(kahvi);

            //var tyyppi = dh.CreatePerson();
            //dh.persons.Add(tyyppi);

            //var paketti = new Coffee("Presidentti", 3.40, Coffee.Roast.light, "joku");
            //Console.WriteLine($"Paahto: {(int)paketti.roast}");

            //var paketti1 = new Coffee("Presidentti");
            //var paketti2 = new Coffee("Kulta Katriina");
            //var paketti3 = new Coffee("Brazil");
            //var paketti4 = new Coffee("Löfberg");

            //List<Coffee> coffees = new List<Coffee>();
            //coffees.Add(paketti1);
            //coffees.Add(paketti2);
            //coffees.Add(paketti3);
            //coffees.Add(paketti4);

            ////Console.WriteLine(coffees[2].brand);

            //foreach (var paketti in coffees)
            //{
            //    Console.WriteLine($"Merkki {paketti.brand}");
            //}

            //for (int i = 0; i < coffees.Count; i++)
            //{
            //    Console.WriteLine($"{i}. Merkki : {coffees[i].brand}");
            //}


            //Company -luokka, nimi, yhteishenkilö(luokkaa person), maa
            //person -luokka etunimi, sukunimi, puhelinnumero, email
            //datahandler -luokka. list<cofee>, list<person>
            //metodi joke kysyy kahvin merkin, hinnan, roast -> luo näistä instanssin Coffee -> lisäää ko. instanssin listaan.
        }

        //19.3 lisätyt ohjeet/vinkit

        //fill DataHandler persons with test dara

        //dh.fillPersonsWithTestData();
        //dh.AddPersonToList();
        //dh.PrintPersonList();
        //Console.ReadKey();

        //Console.Clear();
        //Console.WriteLine("Valitse henkilö");
        //var person = dh.SelectPersonFromList();
        //Console.WriteLine("\n\n");
        //Console.WriteLine($"Valittu : {person.firstName} {person.lastName} {person.email}");

    }


    //kahvit
    // -merkki, hinta, paahto, maahantuoja
    //constructorit ilman parametreja, pelkällä nimellä, kaikilla atribuuteilla
}
