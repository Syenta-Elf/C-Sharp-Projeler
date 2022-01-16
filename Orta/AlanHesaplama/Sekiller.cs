using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public abstract class Sekiller
    {
        public int x;
        public double _alan ;
        public abstract void alan();
        public abstract void cevre();
        public abstract void hacim();
        public int yukseklik()
        {
            System.Console.Write("Yükseklik girin:");
            return Convert.ToInt16(Console.ReadLine().ToString());
        }
        public void menu()
        {
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("[1]Alan Hesaplama");
            System.Console.WriteLine("[2]Çevre Hesaplama");
            System.Console.WriteLine("[3]Hacim Hesaplama");
            System.Console.WriteLine("-----------------");
            System.Console.Write("İşlemi seçin:");
            int islem = Convert.ToInt16(Console.ReadLine());

            switch(islem)
            {
                case 1:
                    alan();
                    break;
                case 2:
                    cevre();
                    break;
                case 3:
                    hacim();
                    break;
                default:
                    System.Console.WriteLine("Hatalı işlem seçtiniz. Sistem kapanıyor.");
                    break;
            }
        }

    }
}