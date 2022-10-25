using System;

namespace KartaPracy_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Zadanie 1");

            for (int i = 1; i < 32; i++)
            {
                Console.WriteLine(i + " listopada 2022");
            }
            

            Console.WriteLine("Zadanie 2\nLiczba:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n*2; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i*i);
                }
            }
            
             
            Console.WriteLine("Zadanie 3");
            for (int i = 1000; i < 10000; i++)
            {
                if(i % 379 == 0)
                { 
                    Console.WriteLine(i);
                }
                    
            }
            

            Console.WriteLine("Zadanie 4");
            for (int i = 100; i < 1000; i++)
            {
                if(i % 5 == 0 || i % 6 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 11 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("Zadanie 5\nPodaj ile chcesz podać liczb:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę:");
                int a = int.Parse(Console.ReadLine());
                suma += a;
            }
            Console.WriteLine(suma);
            
            Console.Write("Zadanie 6\nPodaj liczbę:");
            int k = int.Parse(Console.ReadLine());
            int suma = 0; 
            for (int i = 0; i < k; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);  
                    suma += i;
                }
            }
            Console.WriteLine(suma);   
            
             */

            //Console.Write("Zadanie 7\nPodaj dwucyfrową liczbę:");
            //int m = int.Parse(Console.ReadLine());
            //int suma = 0;
            //for (int i = 10; m >= i && m < 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        suma += i;
            //    }
            //}
            //if (m < 100 && m >= 10)
            //{
            //    Console.WriteLine(suma);
            //}
            //else
            //{
            //    Console.WriteLine("Podana liczba nie jest dwucyfrowa.");
            ////}

            //Console.WriteLine("Zadanie 8\nPodaj kwotę: ");
            //double W = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj okres inwestycji w latach:");
            //double L = int.Parse(Console.ReadLine());
            //double wart = W;
            //double wartM = 0;
            //for (int i = 0; i < L * 12; i++)
            //{
            //    wartM = wart * 0.06 * 1 / 12f;
            //    wart += wartM;
            //}
            //Console.WriteLine("Wartość inwestycji wynosi: " + Math.Round(wart, 2) + " zł.");

            //Console.WriteLine("Zadanie 9\nPodaj liczbę:");
            //int n9 = int.Parse(Console.ReadLine());
            //int k9 = 21;
            //int suma9 = 0;
            //for (int i = 0; i < n9; i++)
            //{
            //    Console.WriteLine(k9);
            //    k9 += 100;
            //    suma9 = k9;
            //}
            //Console.WriteLine(suma9);

            Console.WriteLine("Zadanie 10");
            for (int i = 1; i < 1000; i++)
            {
                if (i % 10 == Math.Sqrt(i))
                    {
                    Console.WriteLine(i);
                }
                else if (i % 100 == Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                }
                else if (i % 1000 == Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
