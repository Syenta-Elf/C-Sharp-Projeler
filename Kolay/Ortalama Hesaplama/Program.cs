using System;

namespace Ortalama_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.getNum();
        }
    }
    class Fibonacci
    {
        public int num;
        public void getNum()
        {
            Console.Write("Please enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Average:"+trying(num));
        }

        public Fibonacci(){}

        public float trying(int num)
        {
            int[] f = new int[num+2];
            int add = 0;
            
            // 0 ve 1 formulde istisna oldugu icin onceden ekleniyor
            f[0]=0;f[1]=1;
            
            for(int i=2;i<=num;i++)
            {
                //bir sonraki sayiyi kaydetmek icin.
                f[i]=f[i-1]+f[i-2];
            }
            foreach (var item in f)
            {
                add+=item;
            }
            return (float)add/(num+2);
        }
    }
}
