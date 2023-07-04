using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    class Book
    {
        public static List<People> personList = new List<People>();


        public Book()
        {
            People person1 = new People { Name = "Ahmet", Surname = "Ferhat", Phone = "0215478324" };
            People person2 = new People { Name = "Ahmo", Surname = "Fero", Phone = "03562514785" };
            People person3 = new People { Name = "Fero", Surname = "Ahmo", Phone = "05321458964" };
            People person4 = new People { Name = "Ahmet", Surname = "Altuntaş", Phone = "06541258954" };
            People person5 = new People { Name = "Cemile", Surname = "Kutlu", Phone = "05321456874" };

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);
        }


    }
}
