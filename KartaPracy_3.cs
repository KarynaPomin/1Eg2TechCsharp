using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Zad 1
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(i, 3) + 3 + " ");
            }
            */

            /*
            // Zad 2
            for (int i = 105; i < 1000; i = i + 15 )
            {
                Console.WriteLine(i + " ");
            }
            */

            /*
            // Zad 3
            int p = int.Parse(Console.ReadLine());
            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0)
                {
                    Console.WriteLine(i + " ");
                } 
            }
            */

            /*
            // Zad 4
            int suma = 0;
            for (int i = 10; i < 100; i++)
            {
                suma += 0;
            }
            Console.WriteLine(suma);
            */

            // Zad 5
            /*
            int x;
            int n = int.Parse(Console.ReadLine());
            int suma = n * (n + 1) / 2;

            for (int i = 0; i < n - 1; i++)
            {
                x = int.Parse(Console.ReadLine());
                suma = suma - x;
            }
            Console.WriteLine(suma);
            */

            // Zad 6
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
              temp = a;
              a = b;
              b = temp + b;
              Console.Write(b + " ");
            }
        }

    }
}

