using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahcesi_Yonetimi
{
    public class Atlar : Hayvanlar
    {
        private int yas1 = 11;
        private int yas2 = 12;
        private int yas3 = 1;
        public void atyaz()
        {
            yazdir("Bojack", yas1, "At", "Erkek", "Yapildi", 14);
            yazdir("Petra", yas2,"Zebra", "Dişi", "Yapılmadı", 1);
            yazdir("Molly", yas3, "Turkoman", "Erkek", "Yapıldı", 84);
            yem_hesapla(yas1,"Bojack");
            yem_hesapla(yas2, "Petra");
            yem_hesapla(yas3, "Molly");
            
        }
        
    }
}
