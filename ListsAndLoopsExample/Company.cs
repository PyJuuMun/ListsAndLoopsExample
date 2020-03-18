using System;
using System.Collections.Generic;
using System.Text;

namespace ListsAndLoopsExample
{
    class Company
    {
        public string CompanyName;
        public Person ContactPerson;
        public string Country;

        public Company(string CompanyName, Person ContactPerson, string Country)
        {
            this.CompanyName = CompanyName;
            this.ContactPerson = ContactPerson;
            this.Country = Country;
        }
    }
}
