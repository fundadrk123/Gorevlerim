using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Gorevlerim._1.Hafta
{
    public class Hesap_Makinesi
    {
      public static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            string yapilmakistenenİslem;
            Console.Write("1. Sayıyı Giriniz:  ");
            sayi1=Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz:  ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak İstediğiniz İşlemi Giriniz.");
            Console.WriteLine("Toplama için(+), Çıkarma için(-), Çarpma için(*), Bölme için (/)");

            yapilmakistenenİslem = Console.ReadLine();

            switch(yapilmakistenenİslem)
            {
                case "+":
                    Console.WriteLine("Sonucunuz:" + (sayi1 + sayi2));
                    break;
                    case "-":
                    Console.WriteLine("Sonucunuz:" + (sayi1 - sayi2));
                    break;
                    case "*":
                    Console.WriteLine("Sonucunuz:" + (sayi1 * sayi2));
                    break;
                    case "/":
                    Console.WriteLine("Sonucunuz:" + (sayi1 / sayi2));
                    break;
            }
            Console.Read();
        }
    }
}
