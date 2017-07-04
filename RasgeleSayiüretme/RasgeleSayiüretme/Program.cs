using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasgeleSayiüretme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Sayıların Başlangıç Değerini Giriniz----> ");
            int bas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayıların Bitiş Değerini Seçiniz-----> ");
            int son = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üretilmesini istediğiniz sayı adedini giriniz-----> ");
            int adet = Convert.ToInt32(Console.ReadLine());

            Random rastgelesayi = new Random();

            for(int i=0;i<adet;i++)
            {
                sayi = rastgelesayi.Next(bas,son);
                Console.Write(" " + sayi);
            }
            Console.ReadKey();


        }
    }
}
