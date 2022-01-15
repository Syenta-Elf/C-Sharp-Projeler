using System;

namespace Ucgen_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen=new Ucgen();
            ucgen.Dik_UcgenCiz();
            ucgen.Es_Kenar_Ucgen();
        }
    }

    class Ucgen
    {
        public int num;

        public void Dik_UcgenCiz()
        {
            System.Console.Write("Bir sayi girin:");
            num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                for(int j=0;j<i;j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("------------------");
        }
        public void Es_Kenar_Ucgen()
        {
            System.Console.Write("Bir sayi girin:");
            num=Convert.ToInt32(Console.ReadLine());
            int tut=num;
            for(int i=1;i<=num;i++)
            {
                
                for(int j=tut;0<j;j--)
                {
                    System.Console.Write(" ");
                }
                tut--;
                for(int j=0;j<i;j++)
                {
                    System.Console.Write("*");
                }
                for(int j=1;j<i;j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            } 
            System.Console.WriteLine("------------------");
            
        }
    }
}
