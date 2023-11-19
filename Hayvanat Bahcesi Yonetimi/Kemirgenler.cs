using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahcesi_Yonetimi
{
    internal class Kemirgenler : Hayvanlar
    {
        private int yas1 = 21;
        private int yas2 = 3;
        private int yas3 = 4;
        public void kemirgenyaz()
        {
            yazdir("Cherry", yas1, "Timsah", "Erkek", "Yapildi", 44);
            yazdir("Aska", yas2, "Kertenkele", "Dişi", "Yapılmadı", 6);
            yazdir("Assan", yas3, "Bukalemun", "Erkek", "Yapıldı", 12);
            yem_hesapla(yas1, "Cherry");
            yem_hesapla(yas2, "Aska");
            yem_hesapla(yas3, "Assan");
            getDosage("a", 4);
        }
    }
}
