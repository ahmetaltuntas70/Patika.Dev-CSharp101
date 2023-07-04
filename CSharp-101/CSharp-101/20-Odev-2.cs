using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101
{
    class _20_Odev_2
    {
        static void Main(string[] args)
        {
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            int n = 20;
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            ArrayList sayilar = new ArrayList();

            int num;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Lutfen deger giriniz: ");
                    num = int.Parse(Console.ReadLine());
                    if (num < 0)
                        throw new InvalidDataException("Lutfen negatif bir sayi gir.");
                    else
                        sayilar.Add(num);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            int flag;
            foreach (var item in sayilar)
            {
                flag = 0;
                int number = Convert.ToInt32(item);
                if (number == 1)
                    flag = 1;
                for (int i = 2; i < number; i++)
                {
                    if (number == 2)
                        break;
                    if (number % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                    asalDegil.Add(number);
                else
                    asal.Add(number);
            }

            asal.Sort();
            asalDegil.Sort();

            float asalToplam = 0;
            float asalOlmayanToplam = 0;
            Console.WriteLine("Asal olanlar: ");
            foreach (var item in asal)
            {
                Console.Write(item + ",");
                asalToplam += Convert.ToInt32(item);
            }

            Console.WriteLine("\nAsal olmayanlar: ");
            foreach (var item in asalDegil)
            {
                Console.Write(item + ",");
                asalOlmayanToplam += Convert.ToInt32(item);
            }

            Console.WriteLine("\nAsal olan sayi: " + asal.Count);
            Console.WriteLine("Asal olan toplam: " + asalToplam);
            Console.WriteLine("Asal olan ortalama: " + (asalToplam / asal.Count));

            Console.WriteLine("Asal olmayan sayi: " + asalDegil.Count);
            Console.WriteLine("Asal olmayan toplam: " + asalOlmayanToplam);
            Console.WriteLine("Asal olmayan ortalama: " + (asalOlmayanToplam / asalDegil.Count));


            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int m = 20;
            int[] list = new int[m];
            for (int i = 0; i < n; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(list);
            int n1 = list[0];
            int n2 = list[1];
            int n3 = list[2];
            int m1 = list[list.Length - 1];
            int m2 = list[list.Length - 2];
            int m3 = list[list.Length - 3];

            float minOrtalama = (float)((n1 + n2 + n3) / 3);
            float maxOrtalama = (float)((m1 + m2 + m3) / 3);

            Console.WriteLine("En kucuk 3 sayinin ortalamasi: " + minOrtalama);
            Console.WriteLine("En buyuk 3 sayinin ortalamasi: " + maxOrtalama);



            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            Console.Write("Lutfen bir cumle giriniz: ");
            string s = Console.ReadLine();
            s = s.ToLower();

            ArrayList liste = new ArrayList();
            foreach (var item in s)
            {
                if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                {
                    list.add(item);
                }
            }

            Console.WriteLine("Dizinin sesli elemanlari: ");
            foreach (var item in list)
                Console.Write(item + "-");

        }
    }
}
