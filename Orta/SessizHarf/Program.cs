using System;
using System.Text.RegularExpressions;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cumle girin:");
            string str = Console.ReadLine();

            String[] strArr = str.Split(" ");

            string vowels = "AaEeIıİiOoÖöUuÜü";

            for (int i = 0; i < strArr.Length; i++)
            {
                char[] test = strArr[i].ToCharArray();
                int count = 0;
                for (int j = 0; j < test.Length; j++)
                {
                    
                    if(vowels.Contains(test[j]))
                    {
                        count=0;
                    }
                    else
                        count++;

                    if(count==2)
                    {
                        System.Console.Write("True ");
                        break;
                    }

                    if(j==test.Length-1 && count<2)
                        System.Console.Write("False ");
                }
            }
        }
    }
}
