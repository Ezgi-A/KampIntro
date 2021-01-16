using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.UrununAdi = "Elma";
            Product1.Fiyati = 15;
            Product1.Aciklama = "Amasya elması";

            Product Product2 = new Product();
            Product2.UrununAdi = "Çilek";
            Product2.Fiyati = 10;
            Product2.Aciklama = "Dağ Çileği";

            Product[] Products = new Product[] {Product1, Product2};

            foreach (Product item in Products)
            {
                Console.WriteLine(item.UrununAdi + " " + item.Fiyati + " " + item.Aciklama);
            }
            Console.WriteLine("----------------------------Metotlar---------------------");
            SepetManager sepetmanager= new SepetManager();
            sepetmanager.Ekle(Product1);
            sepetmanager.Ekle(Product2);

            sepetmanager.Ekle2("Elma", "Yeşil Elma", 5); //Boş İŞ!!!!!
            sepetmanager.Ekle2("Çilek", "Dağ Çileği", 15); //Boş İŞ!!!!!


            

        }
        
    }
}
