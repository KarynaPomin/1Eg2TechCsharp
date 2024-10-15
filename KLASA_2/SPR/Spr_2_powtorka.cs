using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace spr_2
{
    internal class Program
    {
        class Osoby
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            // KOLEKCJE
            // Tablice
            // List
            // ArrayList
            // Queue
            // Stack // LIFO - Last In First Out 
            // Hashtable
            // Dictionary
            // Grafy w dictionary

            void Zad_1()
            {
                // Zadanie 1
                // Stworz tablice 115 pierwszych liczb, ktore w reprezentacji binarnej koncza sie na dwie 1
                // 11, 111, 1011, 1111, 10011, 101011 ...
                // 1, 3, 7, 11, 15, 19
                Console.WriteLine("Zadanie 1");

                int[] T = new int[115];
                T[0] = 3;

                for (int i = 1; i < T.Length; i++)
                {
                    T[i] = T[i - 1] + 4;
                    //T[i] = Convert.ToString(j, 2); // zamiana na binarne
                }

                foreach (int i in T)                
                    Console.WriteLine(i);              
            }

            void Zad_2()
            {
                // Zadanie 2
                // Stworzyc plik o nazwie osoby z zawartoscia 5 osob:
                // imie, nazwisko, wiek
                // Bartosz, Nowak, 43
                // Pawel, Kowal, 21
                // Krystyna, Zrybnika, 27
                // i wstawic obiekty (struktury) typu osoba z wlasciwosciami / polami z pliku, czyli imie, nazwisko, wiek

                StreamReader sr = new StreamReader("C:\\T19\\Nowak\\spr_2\\spr_2\\osoby.txt");

                Osoby[] Osoba = new Osoby[3];
                string[] line = new string[3];
                int k = 0;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(';');
                    Osoby os = new Osoby();
                    os.Name = line[0];
                    os.LastName = line[1];
                    os.Age = int.Parse(line[2]);

                    Osoba[k++] = os;
                }
                sr.Close();

                foreach (Osoby osb in Osoba)
                {
                    Console.WriteLine($"Imię: {osb.Name}, nazwisko: {osb.LastName}, wiek: {osb.Age}");
                }
            }

            void Zad_3()
            {
                //3.Stwórz listę 6 losowych słów składających się z 3 różnych samogłosek(List, ArrayList)

                List<char> Samogloski = new List<char> {'a', 'e', 'y', 'u', 'i', 'o'};
                List<string> S = new List<string>();
                Random rand = new Random();

                for (int i = 0; i < 6; i++)
                {
                    string s = "";
                    char l = ' ';
                    // char[] Samogloska = Samogloski.ToList
                    // Samogloska.RemoveAt(number);

                    for (int j = 0; j < 3; j++)
                    {
                        l = Samogloski[rand.Next(0, Samogloski.Count)];
                        int indeks_l = s.IndexOf(l);
                        if (j != 0)
                        {
                            while (indeks_l != -1)
                            {
                                l = Samogloski[rand.Next(0, Samogloski.Count)];
                                indeks_l = s.IndexOf(l);
                            }
                        }
                        s += l;
                    }
                    S.Add(s);
                }

                foreach (var item in S)
                    Console.WriteLine(item);

            }

            void Zad_4()
            {
                //4.Stwórz kolejkę(queue) 4 losowych liczb fibonacciego < 100(mogą się powtarzać).
                //Wyświetl kolejkę, usuń z niej 2 elementy i wyświetl pozostałe 2

                int Fibonacci(int x)
                {
                    if (x == 1 || x == 2) return 1;
                    return Fibonacci(x - 1) + Fibonacci(x - 2);
                }
                List<int> Fibo = new List<int>();
                int f = 1;
                while (Fibonacci(f) < 100)
                {
                    Fibo.Add(Fibonacci(f));
                    f++;
                }

                List<int> L = new List<int>();
                Queue Q = new Queue();
                Random rand = new Random();
                int r;
                for (int i = 0; i < 4; i++)
                {
                    r = rand.Next(0, Fibo.Count);
                    L.Add(Fibo[r]);
                    Q.Enqueue(Fibo[r]);
                }

                foreach (var item in Q)                
                    Console.Write(item + " ");
                Console.WriteLine();
                foreach (var item in L)
                    Console.Write(item + " ");
                Console.WriteLine();

                // 3 5 1 21
                Q.Peek(); // wyświetlenie pierwszego elementu --> 3
                Q.Dequeue(); // usunięcie pierwszego elementu --> 5 1 21
                Q.Dequeue(); // usunięcie drugiego elementu --> 1 21
                Q.Dequeue(); // usunięcie trzeciego elementu --> 21

            }

            void Zad_5()
            {
                //5.Stwórz stos(stack) 5 kolejnych dwucyfrowych liczb pierwszych.
                //Wyświetl stos, usuń 3 wyrazy i zwów wyświetl stos.

                bool IfPrime(int x)
                {
                    for (int i = 2; i < Math.Sqrt(x); i++)
                    {
                        if (x % i == 0)
                            return false;
                    }
                    return true;
                }

                Stack S = new Stack();
                List<int> L = new List<int>();
                int ile_liczb = 5;

                for (int l = 10; l < 100; l++)
                {
                    if (IfPrime(l))
                    {
                        S.Push(l); // dodać do stacku
                        L.Add(l);
                        ile_liczb--;
                    }
                    if (ile_liczb == 0)
                        break;
                }

                foreach (var item in S)
                    Console.Write(item + " ");
                Console.WriteLine();
                foreach (var item in L)
                    Console.Write(item + " ");
                Console.WriteLine("\n\n");

                // SRACK: 23 19 17 13 11
                // LIST: 11 13 17 19 23

                S.Pop(); // usunąć pierwszy element element z listy --> 19 17 13 11
                S.Pop(); // usunąć drugi element element z listy --> 17 13 11
                S.Pop(); // usunąć trzeci element element z listy --> 13 11

                foreach (var item in S)
                    Console.Write(item + " ");                
            }

            void Zad_6()
            {
                // Zadanie 6
                // Slowniki - stworz prosty graf 1 => 2, 3; 2 => 3; 3 => 1, 2, 5; 4 => null; 5 => 3

                Dictionary<int, char> D = new Dictionary<int, char>() {
                    { 1, 'a'},
                    { 2, 'b'},
                    { 3, 'c'},
                    { 4, 'd'},
                    { 5, 'e'}
                };

                foreach (var item in D)
                    Console.WriteLine($"{item.Key} --> {item.Value}");

                Dictionary<int, List<int>> Graf = new Dictionary<int, List<int>>();

                for (int i = 1; i < 5 + 1; i++)
                    Graf.Add(i, new List<int>());

                string[] numbers;

                for (int i = 0; i < Graf.Count; i++)
                {
                    numbers = Console.ReadLine().Split();
                    int a = int.Parse(numbers[0]);
                    int b = int.Parse(numbers[1]);
                    Graf[a].Add(b);
                    Graf[b].Add(a);
                }

                foreach (KeyValuePair<int, List<int>> item in Graf)
                {
                    Console.Write($"Dla {item.Key}: ");
                    foreach (var items in item.Value)
                        Console.Write(items + " ");
                    Console.WriteLine();
                }
            }            

            Console.ReadKey();
        }
    }
}
