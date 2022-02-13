using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded Daxil Et: ");
            int a =  Convert.ToInt32(Console.ReadLine());

            int b = a;
            int c = a;

            int reqem = a % 7;
            int qaliq;

            while (reqem !=0 )
            {
                c--;
                qaliq = c % 7;
                if (qaliq == 0)
                {
                    break;
                }
            }
            while (reqem !=0)
            {
                b++;
                qaliq = b % 7;
                if (qaliq ==0)
                {
                    break;
                }
            }

            Console.WriteLine("******************");

            int ferq = a - c;
            int ferq1 = b - a;

            if (ferq>ferq1)
            {
                Console.WriteLine($"Netice: {b}");
            }
            else
            {
                Console.WriteLine($"Netice: {c}");
            }
        }
    }
}
