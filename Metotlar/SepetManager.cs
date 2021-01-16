using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi:"+ product.UrununAdi);
        }
        public void Ekle2(string UrunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi:" + UrunAdi);
        }
    }
}
