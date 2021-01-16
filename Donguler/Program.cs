using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"Kurs A" , "Kurs B","Kurs C"};
            Console.WriteLine(kurslar);
            
            for (int i = 0; i < kurslar.Length; i++)
            {
              // Console.WriteLine(kurslar[i]);
                //Console.Write(i);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
