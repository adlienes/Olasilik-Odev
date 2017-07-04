using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistematikRastgeleÖrnekleme
{
    class Program
    {
        static void Main(string[] args)
        {
            float N, n;  int a, k;

            Console.Write("N giriniz-----> ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("n giriniz---->");
            n = Convert.ToInt32(Console.ReadLine());

            if(n<N)
            {
                k = Convert.ToInt32(Math.Ceiling(N / n));

                Random rastgelesayi = new Random();


                a = rastgelesayi.Next(0, k);

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(" " + (a + (i * k)));
                }
            }
            else
            {
                Console.Write("n sayısı N sayısından büyük olamaz");
            }
            
            Console.ReadKey();

        }
    }
}
