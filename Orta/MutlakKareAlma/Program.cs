using System;

namespace MutlakKareAlma
{
    class Program
    {
        static int k=0,b=0;
        static void Main(string[] args)
        {
            Console.Write("Kaç sayı gireceksiniz:");
            int n= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Sayi gir:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if(sayi>67)
                    b += (int)Math.Pow((sayi-67),2);
                else
                    k+= 67-sayi;
            }

            System.Console.WriteLine(k+" , "+b);
        }
    }
}
