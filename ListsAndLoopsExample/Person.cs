using System;
using System.Collections.Generic;
using System.Text;

namespace ListsAndLoopsExample
{
    class Person
    {
        public string Etunimi;
        public string Sukunimi;
        public string Email;
        public int Puhelin;

        public Person(string Etunimi, string Sukunimi, string Email, int Puhelin)
        {
            this.Etunimi = Etunimi;
            this.Sukunimi = Sukunimi;
            this.Email = Email;
            this.Puhelin = Puhelin;
        }
    }
}
