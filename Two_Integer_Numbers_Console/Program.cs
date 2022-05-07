using MvcContrib.UI.ParamBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Integer_Numbers_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gireceginiz Ikili Sayi Adedini Yaziniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[2*n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i + 1 + ".Sayiyi Giriniz:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            SayilariTopla(numbers);
            Console.ReadKey();

        }
       
        static void SayilariTopla( int[] sayilar)
        {

            
            for (int i = 0; i < sayilar.Length; i = i + 2)
            {
                if (sayilar[i] == sayilar[i + 1])
                {
                    Console.Write(Math.Pow((sayilar[i] + sayilar[i + 1]), 2)+" ");
                }

                else
                {
                    Console.Write(sayilar[i] + sayilar[i + 1]+" ");
                }
            }

        } 
    }
}
