using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahcesi_Yonetimi
{
    public class Hayvanlar
    {
        public string Hayvanin_adi { get; set; }
        public int Hayvanin_yasi { get; set; }
        public string Hayvanin_turu { get; set; }
        public string hayvanin_cinsiyeti { get; set; }
        public int hayvanin_asidurumu { get; set; }
        public int yem_miktarı { get; set; }
        public int x { get; set; } = 40;
        public int y { get; set; } = 30;
        public int z { get; set; } = 20;

        public void yazdir(string adi , int yas, string tur, string cinsiyet, string asidurumu, int yem)
        {
            Console.WriteLine("Hayvanin adi: " + adi +" Hayvanın Yaşı: " + yas + " Hayvanın türü: " + tur + " Hayvanın Cinsiyeti: " + cinsiyet + " Hayvanın aşı durumu: " + asidurumu + " Kalan Yem Miktarı: " + yem);
        }
        public void yem_hesapla(int hayvanyasi, string ismi)
        {
            if (hayvanin_cinsiyeti == "Erkek")
            {
                Console.WriteLine(ismi + " Hayvaninizin yaşına ve Cinsiyetine göre Yem ihtiyacı :" + hayvanyasi * 1.5 + 5);
            }
            else
            {
                Console.WriteLine(ismi+" Hayvaninizin yaşına ve Cinsiyetine göre Yem ihtiyacı : " + hayvanyasi * 1.5 );
            }
            Console.WriteLine("Yem verme zamanları: " + hayvanyasi * 4 / 2);

        }
        public void getDosage(string ilac, int miktar)
        {
            if (ilac == "a")
            {
                x -= miktar;
                Console.WriteLine("Tebrikler Doz Uygulandı Uygulanan İlaç: " + ilac + " Kalan Miktar: " + x);
            }
            if (ilac == "b")
            {
                y -= miktar;
                Console.WriteLine("Tebrikler Doz Uygulandı Uygulanan İlaç: " + ilac + " Kalan Miktar: " + y);
            }
            if (ilac == "c")
            {
                z -= miktar;
                Console.WriteLine("Tebrikler Doz Uygulandı Uygulanan İlaç: " + ilac + " Kalan Miktar: " + z);
            }
        }
    }
}
