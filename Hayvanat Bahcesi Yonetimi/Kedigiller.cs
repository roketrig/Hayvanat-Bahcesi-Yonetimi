using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahcesi_Yonetimi
{
    internal class Kedigiller : Hayvanlar
    {
        private int yas1 = 3;
        private int yas2 = 5;
        private int yas3 = 8;
        public void kediyaz()
        {
            yazdir("Şans", yas1, "Tekir", "Erkek", "Yapildi", 10);
            yazdir("Tarçın", yas2, "Kaplan", "Dişi", "Yapılmadı", 33);
            yazdir("Güneş", yas3, "Aslan", "Erkek", "Yapıldı", 11);
            yem_hesapla(yas1 , "Şans");
            yem_hesapla(yas2, "Tarçın");
            yem_hesapla(yas3, "Güneş");
            getDosage("c", 7);
        }
    }
}
