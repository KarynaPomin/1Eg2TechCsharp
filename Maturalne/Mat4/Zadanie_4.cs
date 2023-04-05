using System;
using System.IO;
using System.Collections;
using System.Diagnostics.CodeAnalysis;


namespace study
{
    class Program
    {
        static void Main()
        {
            StreamReader liczby_przyklad = new StreamReader(@"liczby_przyklad.txt");
            StreamReader pierwsze_przyklad = new StreamReader(@"pierwsze_przyklad.txt");
            StreamWriter wynik1 = new StreamWriter(@"wynik4_1.txt");
            StreamWriter wynik2 = new StreamWriter(@"wynik4_2.txt");
            StreamWriter wynik3 = new StreamWriter(@"wynik4_3.txt");

            bool CzyPierwsza(int n)
            {
                for (int j = 2; j < n; j++)
                    if (n % j == 0)
                        return false;
                return true;
            }

            bool CzyPierwszaOdwrt(int n)
            {
                int temp = 0;
                while (n > 0)
                {
                    temp = temp * 10 + (n % 10);
                    n = Convert.ToInt32(n / 10);
                }
                Console.WriteLine(temp);
                if (CzyPierwsza(temp))
                    return true;
                return false;
            }

            int SumaCyfr(int n)
            {
                int w = n;
                int SumaC = 0;
                while (w >= 10)
                {
                    while (w > 0)
                    {
                        SumaC += w % 10;
                        w = w / 10;
                    }
                    Console.WriteLine(SumaC);
                    w = SumaC;
                    SumaC = 0;
                }
                return w;
            }

            while (!liczby_przyklad.EndOfStream)
            {
                int w = Convert.ToInt32(liczby_przyklad.ReadLine());
                if (CzyPierwsza(w) && w <= 5000 && w >= 100)
                    wynik1.WriteLine(w);
            }

            wynik1.Close();

            int suma_43 = 0;
            while (!pierwsze_przyklad.EndOfStream)
            {
                int w = Convert.ToInt32(pierwsze_przyklad.ReadLine());
                if (CzyPierwszaOdwrt(w))
                    wynik2.WriteLine(w);
                if (SumaCyfr(w) == 1)
                    suma_43++;
            }

            wynik2.Close();

            wynik3.WriteLine(suma_43);
            wynik3.Close();

        }
    }
}
