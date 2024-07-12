using System;

namespace Gorevlerim._2.Hafta
{
    public class Fibonacci_Dizisi
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Dizisi");
            Console.Write("Kaç eleman yazdırmak istiyorsunuz? ");
            int n = int.Parse(Console.ReadLine());

            int B = 1;
            int I = 1;
            int T;

            if (n >= 1) Console.WriteLine(B);
            if (n >= 2) Console.WriteLine(I);

            for (int i = 3; i <= n; i++)
            {
                T = B + I;
                B = I;
                I = T;
                Console.WriteLine(T);
            }
            Console.ReadLine();
        }
    }
}
