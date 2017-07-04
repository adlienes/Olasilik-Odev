using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkeziDagilimOlculeri
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

            //ORTALAMA
             float ortalama; float toplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = dizi[i] + toplam;
            }

            ortalama = toplam / dizi.Length;
            //ORTALAMA

            // Varyans
            double varyans; double sonuc=0; double[] dizi2 =new double[n]; double sonuc2 = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                sonuc = ortalama - dizi[i];
                double kareal = Math.Pow(sonuc,2);
                dizi2[i] = kareal;
            }

            for(int i=0;i<dizi2.Length;i++)
            {
                 sonuc2 = sonuc2 + dizi2[i];
            }

            varyans = sonuc2 / (n-1);
            //Varyans

            //Standart Sapma
            double standartsapma = 0;  

            standartsapma = Math.Sqrt(varyans);

            //Standart Sapma

            //OMS
            double oms = 0; double[] dizi3 = new double[n]; double sonuc3 = 0; double x = 0;

            for (int i=0;i<dizi.Length;i++)
            {
                x = ortalama - dizi[i];
                double mutlak = Math.Abs(x);
                dizi3[i] = x;
            }

            for (int i = 0; i < dizi3.Length; i++)
            {
                sonuc3 = sonuc3 + dizi3[i];
            }

            oms = sonuc3 / n;

            //OMS

            //ÇARPIKLIK ÖLÇÜTÜ
            double carpıklık = 0; double y = 0; double[] dizi4 = new double[n]; double sonuc4 = 0;

            for (int i=0;i<dizi.Length;i++)
            {
                y = dizi[i] - ortalama;
                double küpal = Math.Pow(y, 3);
                dizi4[i] = küpal;

            }
            for(int i = 0; i < dizi4.Length; i++)
            {
                sonuc4 = sonuc4 + dizi4[i];
            }
            carpıklık = sonuc4 / n - 1;
            //ÇARPIKLIK ÖLÇÜTÜ

            //BASIKLIK ÖLÇÜTÜ
            double basiklik = 0; double z = 0; double[] dizi5 = new double[n]; double sonuc5 = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                z = dizi[i] - ortalama;
                double üsal = Math.Pow(z, 4);
                dizi5[i] = üsal;

            }
            for (int i = 0; i < dizi4.Length; i++)
            {
                sonuc5 = sonuc5 + dizi5[i];
            }
            basiklik = sonuc4 / n - 1;
            //BASIKLIK ÖLÇÜTÜ

            //DEĞİŞİM KATSAYISI
            double degisimkatsayisi = 0;

            degisimkatsayisi = standartsapma / ortalama;

            //DEĞİŞİM KATSAYISI

            Console.WriteLine("Verilerin Ortalaması -------------------->" + ortalama);
            // Console.WriteLine("Verilerin Varyansı------------>" + varyans);
            // Console.WriteLine("Verilerin Standart Sapması------------>" + standartsapma);
            // Console.WriteLine("Verilerin Ortalama Mutlak Sapması------------>" + oms);
            Console.WriteLine("Verilerin Çarpıklık Ölçütü------------>" + carpıklık);
            Console.WriteLine("Verilerin Basıklık Ölçütü------------>" + basiklik);
            Console.WriteLine("Verilerin Değişim Katsayısı------------>" + degisimkatsayisi);



            Console.ReadKey();

        }


        
    }
}
