using System;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cumle girin:");
            string str = Console.ReadLine();

            string[] strArr = str.Split(" ");
            string[] strArrReverese = new string[strArr.Length];
            
            
            for (int i = 0; i < strArr.Length; i++)
            {
                char[] reverse = strArr[i].ToCharArray();
                Array.Reverse(reverse);
                strArrReverese[i] =  new string(reverse);

            }

            foreach (string item in strArrReverese)
            {
                System.Console.Write(item+" ");
            }
        }
    }
}
