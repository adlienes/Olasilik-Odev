using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkeziEgilimOlcüleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int[] dizi;

            Console.Write("n sayısını  giriniz---->");
            n = Convert.ToInt32(Console.ReadLine());

            dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ıncı elemanı giriniz ----> ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

             ortalama(dizi);
              mod(dizi);
             medyan(dizi);
             geometrikortalama(dizi);
            harmonikortalam(dizi);
            Console.ReadKey();
            
        }

        static void ortalama(int[] dizi)
        {
            float ortalama; float toplam=0; 

            for(int i=0;i<dizi.Length;i++)
            {
                toplam = dizi[i] + toplam;
            }

            ortalama = toplam / dizi.Length;

            Console.WriteLine("Verilerin Ortalaması -------------------->" + ortalama);
        }

        static void mod(int[] dizi)
        {
            int sayac = 0; int mod=0, enbüyük=0; int gecicisayac = 0;
            for(int i=0;i<dizi.Length;i++)
            {
                sayac = 0;
                for(int j=0;j<dizi.Length;j++)
                {
                    if(dizi[i]==dizi[j])
                        sayac++;

                    if (sayac > gecicisayac)
                    {
                        gecicisayac = sayac;
                        mod = dizi[i];

                    }
                }  
            }
            Console.WriteLine("Verilerin modu---------->" + mod);

        }

        static void medyan(int[] dizi)
        {
            int medyan = 0;


            if(dizi.Length%2==0)
            {
                int i = dizi.Length / 2;
                medyan = dizi[i-1];
                int medyan2 = dizi[i];

                Console.WriteLine("Verilerin Medyanı -------->" + medyan+ " ve " +medyan2+"dır");
            }
            else
            {
                int i = (dizi.Length + 1) / 2;
                medyan = dizi[i-1];

                Console.WriteLine("Verilerin Medyanı -------->" + medyan);
            }
        }

        static void geometrikortalama(int[] dizi)
        {
            float sonuc = 1; double geoortalama;

            for (int i = 0; i < dizi.Length; i++)
            {
                sonuc = sonuc * dizi[i];
            }

            geoortalama = Math.Pow(sonuc,(1.0/ dizi.Length));
            Console.WriteLine("Verilerin Geoemtrik Ortalaması----------->" + geoortalama);
        }

        static void harmonikortalam(int[] dizi)
        {
            int n = dizi.Length; double harmonik; double sonuc = 0;

            for(int i=0;i<dizi.Length;i++)
            {
                sonuc =  sonuc + (1.0 / dizi[i]);
            }

            harmonik = n / sonuc;

            Console.WriteLine("Verilerin Harmonik Ortalaması ------------->" + harmonik);
        }
    }
}
