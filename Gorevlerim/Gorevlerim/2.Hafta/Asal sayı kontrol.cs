using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevlerim._2.Hafta
{
    public class Asal_sayı_kontrol
    {
        public static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Bir sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            if(sayi==1||sayi==0)
            
            {
               Console.WriteLine("Girilen Sayı Asal Değildir.!");
            }
            else
            {
                for(int i =2;i< sayi; i++)
                {
                  if(sayi % i== 0)
                  {
                        sayac++;
                        break;
                        
                  }
                }
                if (sayac == 0)
                {
                    Console.WriteLine("{0} sayısı asal sayıdır.", sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı asal sayı değildir.!", sayi);
                }
            }
            Console.ReadKey();
        }
    }
}
