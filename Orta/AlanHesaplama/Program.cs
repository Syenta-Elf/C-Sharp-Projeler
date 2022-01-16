using System;

namespace AlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            System.Console.WriteLine("*****************************************");
            System.Console.WriteLine("İşlem yapmak istediğiniz şekili seçin");
            System.Console.WriteLine("*****************************************");
            System.Console.WriteLine("[1]Üçgen");
            System.Console.WriteLine("[2]Kare");
            System.Console.WriteLine("[3]Dikdörtgen");
            System.Console.WriteLine("[4]Daire");
            System.Console.WriteLine("*****************************************");
            System.Console.Write("İşleminiz:");
            int islem = Convert.ToInt16(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    System.Console.Write("Kenar Uzunluğunu girin:");
                    new Ucgen(Convert.ToInt16(Console.ReadLine().ToString()));
                    break;
                case 2:
                    System.Console.Write("Kenar Uzunluğunu girin:");
                     new Kare(Convert.ToInt16(Console.ReadLine().ToString()));
                    break;
                case 3:
                    System.Console.Write("Kenar Uzunluklarını girin:");
                    System.Console.Write("Kısa kenar girin:");
                    int x = Convert.ToInt16(Console.ReadLine().ToString());
                    System.Console.Write("Uzun kenar girin:");
                    int y = Convert.ToInt16(Console.ReadLine().ToString());
                    new Dikdortgen(x,y);
                    break;
                case 4:
                    System.Console.Write("Yarıçap girin:");
                    new Daire(Convert.ToInt16(Console.ReadLine().ToString()));
                    break;
                default:
                    System.Console.WriteLine("Hatalı işlem girdiniz.");
                    break;
            }
        }
    }
}
