using System;

namespace study
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("KARTA PRACY 6A");

            Console.WriteLine("Zadanie 1");
            Console.Write("Podaj liczbę: ");
            int a1 = int.Parse(Console.ReadLine());
            int suma1 = 0;

            while (a1 != 0)
            {
                suma1 += a1 % 10;
                a1 = a1 / 10;
            }
            Console.WriteLine($"Suma cyfr: {suma1}.");

            Console.WriteLine();

            Console.WriteLine("Zadanie 2");

            int a2 = int.Parse(Console.ReadLine());
            string flaga = "!";

            if (a2 < 3)
                Console.WriteLine("Liczba nie jest pierwsza.");
            else
            {
                for (int i = 2; i < a2; i++)
                {
                    if (a2 % i == 0)
                    {
                        flaga = "Liczba nie jest pierwsza.";
                        break;
                    }
                    else
                        flaga = "Liczba jest pierwsza.";
                }
                Console.WriteLine(flaga);
            }

            Console.WriteLine();

            Console.WriteLine("Zadanie 3");

            int n3 = int.Parse(Console.ReadLine());
            int doskonalosc = 0;

            for (int i = 1; i < n3; i++)
            {
                if (n3 % i == 0)
                {
                    doskonalosc += i;
                }
            }
            if (doskonalosc == n3)
                Console.WriteLine("Liczba jest doskonała.");
            else
                Console.WriteLine("Liczba nie jest doskonała.");

            Console.WriteLine();

            Console.WriteLine("Zadanie 4");

            Console.Write("A: ");
            int a4 = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b4 = int.Parse(Console.ReadLine());
            while (a4 != b4)
            {
                if (a4 > b4)
                    a4 -= b4;
                if (b4 > a4)
                    b4 -= a4;
            }
            if (a4 == 1)
                Console.WriteLine("Liczby są względnie pierwsze.");
            else
                Console.WriteLine("Liczby nie są względnie siebie pierwsze.");

            Console.WriteLine();

            Console.WriteLine("Zadanie 5");

            Console.Write("A: ");
            int a5 = int.Parse(Console.ReadLine());

            for (int i = 10; i < 20; i++)
            {
                int x = a5;
                int y = i;
                while (x != y)
                {
                    if (x > y)
                        x -= y;
                    if (y > x)
                        y -= x;
                }
                if (x == 1)
                    Console.WriteLine($"Liczba {i} jest względnie pierwsza do liczby {a5}");
            }

            Console.WriteLine();

            Console.WriteLine("Zadanie 6");
            int a6 = int.Parse(Console.ReadLine());
            int b6 = int.Parse(Console.ReadLine());
            int x6 = a6;
            int y6 = b6;
            int nwd6 = 0;
            if (a6 == b6)
                Console.WriteLine($"{a6}/{b6} = 1");
            else
            {
                while (x6 != y6)
                {
                    if (x6 > y6)
                        x6 -= y6;
                    if (y6 > x6)
                        y6 -= x6;
                    nwd6 = x6;
                }
                x6 = a6 / nwd6;
                y6 = b6 / nwd6;
                Console.WriteLine($"{a6}/{b6} = {x6}/{y6}");
            }

            Console.WriteLine();

            Console.WriteLine("Zadanie 7");

            int a7 = int.Parse(Console.ReadLine());
            int b7 = int.Parse(Console.ReadLine());
            int x7 = a7;
            int y7 = b7;
            int nwd7 = 0;
            while (x7 != y7)
            {
                if (x7 > y7)
                    x7 -= y7;
                if (y7 > x7)
                    y7 -= x7;
            }
            nwd7 = x7;
            x7 = a7 / nwd7;
            y7 = b7 / nwd7;
            int d7 = x7 % y7;
            int q7 = x7 / y7;
            Console.WriteLine($"{a7}/{b7} = {q7} ({d7}/{y7})");

            Console.WriteLine();

            Console.WriteLine("Zadanie 8");





        }
    }
}


