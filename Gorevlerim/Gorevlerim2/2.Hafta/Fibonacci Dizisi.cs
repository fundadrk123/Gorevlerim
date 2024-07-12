using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevlerim._2.Hafta
{
    public class Fibonacci_Dizisi
    {
        static void Main(string[] args)
        {
            int B = 1;
            int I = 1;
            int T = 0;

            Console.WriteLine(B);
            Console.WriteLine(I);

            for(int i = 1;i <=50;i++)
            {
                T = B + I;
                B = I;
                I = T;
                Console.WriteLine(T);
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
