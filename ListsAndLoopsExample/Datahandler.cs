using System;
using System.Collections.Generic;
using System.Text;

namespace ListsAndLoopsExample
{
    class Datahandler
    {
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();
        public List<Company> companies = new List<Company>();

        //19.3 lisätty 2 public void FillPersonsWithTestData/FillCompaniesWithTestData

        public void FillPersonsWithTestData()
        {
            this.persons.Add(new Person("Mari", "Mikola", "050 999 888", "mikola@coffcomp.fi"));
            this.persons.Add(new Person("Mikko", "Marila", "050 777 666", "marila@coffcomp.fi"));
        }

        public void FillCompaniesWithTestData()
        {
            Person contactPerson1 = new Person("Mari", "Mikola", "050 999 888", "mikola@coffcomp.fi");
            Company testCompany = new Company("Kahavi-Tahati", contactPerson1, "HuitanKuikka");
            this.companies.Add(testCompany);
        }

        //19.3 public Coffee muokatty, lisätty ja korjattu koodia mallin mukaan, int/var lisätty
        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki.");
            var merkki = Console.ReadLine();
            //syötetään hinta, paahto 1-5
            //ei companyä
            Coffee toReturn = new Coffee(merkki);
            var paahto = Console.ReadLine();
            int luku = Int16.Parse(paahto);
            toReturn.roast = (Coffee.Roast)0;
            return toReturn;
        }

        //metodi luo persoonan
        //korjattu ja muokattu kysymään tiedot 19.3

        public Person CreatePerson()
        {
            Console.WriteLine("Fill in first name:");
            string Etunimi = Console.ReadLine();
            Console.WriteLine("Fill in last name:");
            string Sukunimi = Console.ReadLine();
            Console.WriteLine("Fill in phonenumber:");
            string Puhelin = Console.ReadLine();
            Console.WriteLine("Fill in email address:");
            string Email = Console.ReadLine();
            Person person = new Person(Etunimi, Sukunimi, Puhelin, Email);
            return person;
        }

        public void AddNewPersonToList()
        {
            Person person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Person added to the list.");
        }

        public void PrintPersonList()
        {
            for (int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {this.persons[i].Etunimi} {this.persons[i].Sukunimi}");
            }
        }

        public Person SelectPersonFromList()
        {
            PrintPersonList();
            Console.WriteLine("Fill in the desired person's number:");
            var selected = int.Parse(Console.ReadLine());
            return this.persons[selected - 1];
        }

        public Company CreateCompany()
        {
            Console.WriteLine("Fill in the name of the company:");
            string CompanyName = Console.ReadLine();
            Console.WriteLine("Fill in the nation of the company:");
            string County = Console.ReadLine();
            Console.WriteLine("Choose a contactperson from the list.");
            Person ContantPerson = SelectPersonFromList();
            Company company = new Company(CompanyName, ContantPerson, County);
            return company;
        }

        public void AddNewCompanyToList()
        {
            Company company = CreateCompany();
            this.companies.Add(company);
            Console.WriteLine("Company added to the list.");
        }

        public void PrintCompanyList()
        {
            int i = 1;
            foreach (Company company in this.companies) ;
            {
                //koodi ei toimi CompanyName:ssa ja ContactPerson:issa jos 'companies' pienellä edessä
                //jos 'company' edessä, koodi herjaa company kohdasta eikä enää CompanyName:sta tai ContactPerson:ista
                Console.WriteLine($"{i}. Name:{this.company.CompanyName}");
                Console.WriteLine($"Contant person: {company.ContactPerson.Etunimi} {company.ContactPerson.Sukunimi}");
                i++;
            }
        }

        public Company SelectCompanyFromList()
        {
            PrintCompanyList();
            Console.WriteLine("Fill in the number of the chosen company:");
            var selected = int.Parse(Console.ReadLine());
            return this.companies[selected - 1];
        }
    }
}
