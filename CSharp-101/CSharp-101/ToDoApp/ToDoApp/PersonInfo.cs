using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class PersonInfo
    {
        public static List<Person> person = new List<Person>();

        public PersonInfo()
        {
            person.Add(new Person(1, "Ahmo Fero"));
            person.Add(new Person(2, "Fero Ahmo"));
            person.Add(new Person(3, "Ahmet Ferhat"));
            person.Add(new Person(4, "Ahmet Altuntaş"));
        }
    }
}
