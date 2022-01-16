using System;

namespace IntegerIkililerinToplami
{
    class Program
    {
        static int n, m = 0;

        static void Main(string[] args)
        {

            System.Console.Write("Kaç sayi gireceksiniz (Çift girin) :");
            n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[(n / 2) + 1];

            for (int i = 0; i < arr.Length-1; i++)
            {
                System.Console.Write("Sayi gir:");
                int x = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("Sayi gir:");
                int y = Convert.ToInt16(Console.ReadLine());
                arr[i] = deneme(x, y);
            }
            if (n % 2 != 0)
            {
                System.Console.Write("Sayi gir:");
                arr[n / 2] = Convert.ToInt16(Console.ReadLine());
            }

            foreach (int item in arr)
            {
                if(item != 0)
                System.Console.Write(item + " ");
            }


            static int deneme(int k, int y)
            {
                if (k == y)
                    return (k + k) * (k + k);
                else
                    return k + y;
            }
        }
    }
}
