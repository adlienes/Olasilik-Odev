using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrekansSerisi
{
    class Program
    {
        static void Main(string[] args)
        {

            int n; int[] dizi;  int sayac = 0;

            Console.Write("n sayısını  giriniz");
            n = Convert.ToInt32(Console.ReadLine());

            dizi = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.Write("{0} ıncı elemanı giriniz ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (dizi[k] == dizi[i])
                                sayac = -1;
                        }
                        sayac++;
                    }
                }
                if (sayac != 0)
                    Console.WriteLine(dizi[i] + " -------------------> " + sayac);
                sayac = 0;
            }

            Console.ReadKey();
        }
    }
}
