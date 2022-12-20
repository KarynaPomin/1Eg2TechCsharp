using System;

namespace KartaPracy_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Zadanie 1\nPodaj dwie liczby, aby ich suma była parzysta.");
            Console.WriteLine("Podaj pierwszą liczbę:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            int b1 = int.Parse(Console.ReadLine());

            if ((a1+b1) % 2 == 0)
                {
                Console.WriteLine("Tak. Suma liczb jest parzysta.");
            }

            else
            {
                Console.WriteLine("Nie. Suma liczb nie jest parzysta.");
            }

            

            Console.WriteLine("Zadanie 2\nSprawdź czy średnia arytmetyczna dwóch podanych liczb jest większa od jej średniej geometrycznej.");
            Console.WriteLine("Podaj pierwszą liczbę:");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            int b2 = int.Parse(Console.ReadLine());

            if ((a2 + b2) / 2 > Math.Pow(a2 * b2, 1/2d))
            {
                Console.WriteLine("Tak, średnia aretmetyczna jest większa.");
            }
            else
            {
                Console.WriteLine("Nie, średnia geometryczna jest większa.");
            }
            
            

            Console.WriteLine("Zadanie 3\nPodaj trzy liczby. Dwie z nich muszą być sobie równe.");
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (k == l && l == m && m == k)
            {
                Console.WriteLine("Nie. Trzy podane liczby są sobie równe.");
            }
            
            else if (k == l)
            {
                Console.WriteLine("Tak. Są sobie równe dwie liczby: " + k);
            }
            
            else if (l == m)
            {
                Console.WriteLine("Tak. Są sobie równe dwie liczby: " + l);
            }
            
            else if (m == k)
            {
                Console.WriteLine("Tak. Są sobie równe dwie liczby: " + m);
            }

            else
            {
                Console.WriteLine("Nie ma równych sobie liczb.");
            }
            


            Console.WriteLine("Zadanie 4\nWprowadź 4 różne liczby całkowite.");
            int a4 = int.Parse(Console.ReadLine());
            int b4 = int.Parse(Console.ReadLine());
            int c4 = int.Parse(Console.ReadLine());
            int d4 = int.Parse(Console.ReadLine());

            if (a4 < b4 && a4 < c4 && a4 < d4) Console.WriteLine("Najmniejszą z podanych liczb jest: " + a4);
            else if (b4 < a4 && b4 < c4 && b4 < d4) Console.WriteLine("Najmniejszą z podanych liczb jest: " + b4);
            else if (c4 < a4 && c4 < b4 && c4 < d4) Console.WriteLine("Najmniejszą z podanych liczb jest: " + c4);
            else if (d4 < a4 && d4 < b4 && d4 < c4) Console.WriteLine("Najmniejszą z podanych liczb jest: " + d4);
            else Console.WriteLine("Nie ma najmniejszej liczby, poniewż przynajmniej dwie z podanych liczb są sobie równe.");

            

            Console.WriteLine("Zadanie 5\nWprowadź trzy liczby, które spełniają nierównośc trójkąta.");
            int a5 = int.Parse(Console.ReadLine());
            int b5 = int.Parse(Console.ReadLine());
            int c5 = int.Parse(Console.ReadLine());

            if (a5 < b5 + c5 && a5 > b5 - c5 && b5 < a5 + c5 && b5 > a5 - c5 && c5 < a5 + b5 && c5 > a5 - b5)
            {
                Console.WriteLine("Tak. Podane liczby spełniają nierówność trójkąta");
            }

            else
            {
                Console.WriteLine("Nie. Podane liczby nie spełniają nierówność trójkąta.");
            }
            
            
            Console.WriteLine("Zadanie 6\nPodaj trzy liczby, z których można zbudować trójkąt.");

             int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b + c || b < a + c || c < a + b)
            {
                if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                {
                    Console.WriteLine("Z podanych liczb powstanie trójkąt prostokątny.");
                }
                else if(a * a + b * b < c * c || b * b + c * c < a || a * a + c * c < b)
                {
                    Console.WriteLine("Z podanych liczb powstanie trójkąt rozwartokątny.");
                }
                else if(a * a + b * b > c * c || b * b + c * c > a || a * a + c * c > b)
                {
                    Console.WriteLine("Z podanych liczb powstanie trójkąt ostrokątny.");
                }
            }
            else
            {
                Console.WriteLine("Z podanych liczb nie powstanie prostokąt.");
            }
        }
    }
}
