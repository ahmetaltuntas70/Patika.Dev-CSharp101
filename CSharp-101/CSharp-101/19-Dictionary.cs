using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101
{
    class _19_Dictionary
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "Ahmo Fero");
            kullanıcılar.Add(12, "Fero Ahmo");
            kullanıcılar.Add(18, "Ahmet Altuntaş");
            kullanıcılar.Add(20, "Özcan Coşar");
            //Dizinin elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);
            //Count;
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanıcılar.Count);
            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Ferhat Ahmet"));
            //Remove
            Console.WriteLine("***** Remove *****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item.Value);
            //Keys
            Console.WriteLine("***** Keys ******");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);
            //Values
            Console.WriteLine("***** Values *****");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);


        }
    }
}
