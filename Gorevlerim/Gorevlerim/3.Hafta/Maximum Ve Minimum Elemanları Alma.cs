using Gorevlerim._2.Hafta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevlerim._3.Hafta
{
    public class Maximum_Ve_Minimum_Elemanları_Alma
    {
        static void Main(string[] args)
        {
            int diziuzunlugu = 0;
            Console.WriteLine("Diziniz kaç Elemanlıdır.?  ");
            diziuzunlugu=Convert.ToInt32(Console.ReadLine());
            int[] dizi=new int[diziuzunlugu];

            int max = 0;
            int min = 0;

            int minİndisi = 0;
            int maxİndisi = 0;

            for(int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Dizinin " + (i + 1) + ".Elemanını Giriniz: ");
                dizi[i]=Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    max = dizi[i];
                    min = dizi[i];
                }
                if (dizi[i] > max)
                {
                    max = dizi[i];
                    maxİndisi = i;
                }
                if (dizi[i] < min)
                {
                    min = dizi[i];
                    minİndisi= i;
                }
            }
            Console.WriteLine("Dizinin En Büyük Elemanı = " + max + " İndisi İse: " + maxİndisi);
            Console.WriteLine("Dizinin En Küçük Elemanı = " + min + " İndisi İse: " + minİndisi);
            Console.ReadLine();
        }
    }
}
