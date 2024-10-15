using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spr_kkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1
            void Zadanie_0()
            {
                Console.Write("Podaj 7 cyfr po myślniku: ");
                string[] N = Console.ReadLine().Split('-');
                int[] T = new int[7];

                for (int i = 0; i < T.Length; i++)
                    T[i] = int.Parse(N[i]); 

                bool CzyWielkomiejska = true; // rosnące
                bool CzyMałorolna = true; // malejące
                bool CzyMałomiasteczkowa = true;

                for (int i = 1; i < N.Length - 1; i++)
                {
                    if (!(T[i - 1] <= T[i] && T[i] <= T[i + 1]))
                        CzyWielkomiejska = false;
                    else if (!(T[i - 1] >= T[i] && T[i] >= T[i + 1]))
                        CzyMałorolna = false;
                    else
                        CzyMałorolna = false;
                }

                if (CzyWielkomiejska)
                    Console.WriteLine("Wielkomiejska");
                else if (CzyMałorolna)
                    Console.WriteLine("Małorolna");
                else if (CzyMałomiasteczkowa)
                    Console.WriteLine("Małomiasteczkowa");

            }

            void Zadanie_1()
            {
                int[] T = new int[10];
                Random rand = new Random();

                // Wyświetlenie całej tablicy
                for (int i = 0; i < T.Length; i++)
                {
                    T[i] = rand.Next(-9, 10);
                    Console.Write(T[i] + " ");
                }
                Console.WriteLine();

                // Element początkowy i końcowy podciągu i suma
                int najwiekszaSuma = int.MinValue;
                int poczontek = 0;
                int koniec = 0;
                int suma;

                for (int i = 1; i < T.Length - 1; i++)
                {
                    suma = T[i - 1] + T[i] + T[i + 1];

                    if (suma > najwiekszaSuma)
                    {
                        najwiekszaSuma = suma;
                        poczontek = T[i - 1];
                        koniec = T[i + 1];
                    }
                }

                Console.WriteLine($"Suma: {najwiekszaSuma} --> początek: {poczontek} i koniec: {koniec}");
            }

            void Zadanie_3()
            {
                Dictionary<int, List<int>> Graf = new Dictionary<int, List<int>>();
                Console.Write("Podaj liczbę wierzchołków: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Podaj ilość krawędzi: ");
                int k = int.Parse(Console.ReadLine());

                for (int i = 1; i < n + 1; i++)
                    Graf.Add(i, new List<int>());

                Console.WriteLine("Po spacji podaj 2 połączone wierzchołki: ");
                for (int i = 0; i < k; i++)
                {
                    string[] G = Console.ReadLine().Split();
                    int x = int.Parse(G[0]);
                    int y = int.Parse(G[1]);
                    Graf[x].Add(y);
                    Graf[y].Add(x);
                }

                Console.Write("Podaj a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Podaj b: ");
                int b = int.Parse(Console.ReadLine());

                foreach (var item_a in Graf[a])
                {
                    if (item_a == b)
                        Console.WriteLine("Wierzchołki są połączone ze sobą bezpośrednio.");
                    else
                    {
                        foreach (var item_b in Graf[b])
                        {
                            if (item_b != item_a)
                                Console.WriteLine("Nie istnieje połączenia między tymi wierzchołkami.");
                        }
                    }
                }
            }

            //Zadanie_0();
            //Zadanie_1();
            Zadanie_3();

            Console.ReadKey();
        }
    }
}
