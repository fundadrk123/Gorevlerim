using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevlerim._3.Hafta
{
    public class Faktöriyel_Hesaplama
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Faktöriyelini Almak İstediğiniz Sayıyı Giriniz.");

            int sayi=Convert.ToInt32(Console.ReadLine());
            int faktöriyel=1;

            for(int i = sayi; i>=1; i--) 
            {
                faktöriyel *= i;
                Console.WriteLine(i);
            }
            Console.WriteLine("İşlem sonucu : {0}", faktöriyel);
            Console.ReadKey();
        }
    }
}
