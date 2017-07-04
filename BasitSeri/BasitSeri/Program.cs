using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitSeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int[] dizi;
            int gecicisayi;

            Console.Write("n sayısını giriniz---> ");
            n = Convert.ToInt32(Console.ReadLine());

            dizi = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.Write("{0} ıncı sayıyı giriniz ", i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(dizi[j]<dizi[i])
                    {
                        gecicisayi = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gecicisayi;
                    }
                }
            }
            */

            Array.Sort(dizi);

           for(int i=0;i<dizi.Length;i++)
            {
                Console.Write(" " + dizi[i]);
            }
                
            Console.ReadKey();


        }
    }
}
