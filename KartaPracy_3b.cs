using System;

namespace KartaPracy_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Zadanie 1");

            for (int i = 1; i < 32; i++)
            {
                Console.WriteLine(i + " listopada 2022");
            }
            

            Console.WriteLine("Zadanie 2\nLiczba:");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n2*2; i++)
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
            int n5 = int.Parse(Console.ReadLine());
            int suma5 = 0;
            for (int i = 0; i < n5; i++)
            {
                Console.WriteLine("Podaj liczbę:");
                int a5 = int.Parse(Console.ReadLine());
                suma5 += a5;
            }
            Console.WriteLine(suma5);
            
            Console.Write("Zadanie 6\nPodaj liczbę:");
            int k6 = int.Parse(Console.ReadLine());
            int suma6 = 0; 
            for (int i = 0; i < k6; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);  
                    suma6 += i;
                }
            }
            Console.WriteLine(suma6);   
            
             

            Console.Write("Zadanie 7\nPodaj dwucyfrową liczbę:");
            int m7 = int.Parse(Console.ReadLine());
            int suma7 = 0;
            for (int i = 10; m7 >= i && m7 < 100; i++)
            {
                if (i % 2 == 1)
                {
                    suma7 += i;
                }
            }
            if (m7 < 100 && m7 >= 10)
            {
                Console.WriteLine(suma7);
            }
            else
            {
                Console.WriteLine("Podana liczba nie jest dwucyfrowa.");
            }

            Console.WriteLine("Zadanie 8\nPodaj kwotę: ");
            double W = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj okres inwestycji w latach:");
            double L = double.Parse(Console.ReadLine());
            double wart = W;
            double wartM = 0;
            for (int i = 0; i < L * 12; i++)
            {
                wartM = wart * 0.06 * 1 / 12f;
                wart += wartM;
            }
            Console.WriteLine("Wartość inwestycji wynosi: " + Math.Round(wart, 2) + " zł.");

            Console.WriteLine("Zadanie 9\nPodaj liczbę:");
            int n9 = int.Parse(Console.ReadLine());
            int k9 = 21;
            int suma9 = 0;
            for (int i = 0; i < n9; i++)
            {
                Console.WriteLine(k9);
                k9 += 100;
                suma9 = k9;
            }
            Console.WriteLine(suma9);

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
