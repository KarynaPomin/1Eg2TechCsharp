using System;
using System.Collections.Generic;

namespace KartaPracy_6
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Zadanie 1");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            if (a1 < b1)
            {
                if (c1 - b1 == b1 - a1)
                    Console.WriteLine("Arytmetyczna: TAK");
                else
                    Console.WriteLine("Arytmetyczna: NIE");

                if (c1 / b1 == b1 / a1)
                    Console.WriteLine("Geometryczna: TAK");
                else
                    Console.WriteLine("Geometryczna: NIE");

                Console.WriteLine("Rosnąco: TAK");
                Console.WriteLine("Malejąco: NIE");
            }
            else if (a1 > b1)
            {
                if (a1 - b1 == b1 - c1)
                    Console.WriteLine("Arytmetyczna: TAK");
                else
                    Console.WriteLine("Arytmetyczna: NIE");
                if (a1 / b1 == b1 / c1)
                    Console.WriteLine("Geometryczna: TAK");
                else
                    Console.WriteLine("Geometryczna: NIE");
                Console.WriteLine("Rosnąco: NIE");
                Console.WriteLine("Malejąco: TAK");
            }

            Console.WriteLine();

            Console.WriteLine("Zadanie 2");
            int suma = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 8 == 0 && i % 16 != 0)
                {
                    Console.WriteLine(i);
                    suma += i;
                }
            }
            Console.WriteLine(suma);

            Console.WriteLine();

            Console.WriteLine("Zadanie 3");
            int ilosc3 = 0;
            int maksi = 0;
            for (int m = 10; m < 100; m++)
            {
                if (m % 7 == 0)
                    maksi = m;
            }
            Console.WriteLine($"Największa liczba dwucyfrowa podzielna przez 7 to: " + maksi);
            for (int i = 1000; i < 10000; i++)
            {
                if (i % maksi == 0)
                    ilosc3++;
            }
            Console.WriteLine($"Ilość: " + ilosc3);

            Console.WriteLine();

            Console.WriteLine("Zadanie 4");
            int ilosc4 = 0;
            for (int i = 11; i < 100; i++)
            {
                if (2 * (i % 10) < i / 10)
                    ilosc4++;
            }
            Console.WriteLine(ilosc4);

            Console.WriteLine();

            Console.WriteLine("Zadanie 5");
            int suma5 = 0;
            int ilosc5 = 0;
            for (int i = 100; i < 1000; i++)
            {
                if ((i / 100) > ((i / 10) % 10) + (i % 10))
                {
                    suma5 += i;
                    ilosc5++;
                }
            }
            Console.WriteLine($"Suma: {suma5} \nIlość: {ilosc5}");

            Console.WriteLine();

            Console.WriteLine("Zadanie 6");
            Console.Write("Ile liczb: ");
            int n6 = int.Parse(Console.ReadLine());
            int l6 = 0;
            int suma6 = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i < 100 && i % 19 == 0)
                {
                    suma6 += i;
                    l6++;
                }
                if (l6 == n6)
                    break;
            }
            Console.WriteLine($"Suma: " + suma6);

            Console.WriteLine();

            Console.WriteLine("Zadanie 7");
            int suma7 = 0;
            Console.Write("Ile liczb: ");
            int n7 = int.Parse(Console.ReadLine());
            int l7 = 0;
            for (int i = 999; i >= 100; i--)
            {
                if (i % 37 == 0)
                {
                    suma7 += i;
                    l7++;
                }
                if (l7 == n7)
                    break;
            }
            Console.WriteLine($"Suma: {suma7}");

            Console.WriteLine();

            Console.WriteLine("Zadanie 8");

            int n8 = int.Parse(Console.ReadLine());
            int suma8 = 0;
            int a8 = 2;
            for (int i = 0; i < n8; i++)
            {
                if (a8 % 2 == 0)
                    suma8 += a8;
                else
                    suma8 -= a8;
                a8 += 3;
            }
            Console.WriteLine(suma8);

            Console.WriteLine();

            Console.WriteLine("Zadanie 9");
            int n9 = int.Parse(Console.ReadLine());
            int iloczyn9 = 1;
            int p9 = 1;

            for (int i = 0; i < n9; i++)
            {
                int a9 = (int)Math.Pow(2, p9);
                if (p9 % 2 != 0)
                {
                    iloczyn9 *= a9;
                    a9 *= -1;
                    Console.Write($"({a9}) * ");
                }
                else
                {
                    iloczyn9 *= a9;
                    Console.Write(a9 + " * ");
                }
                p9++;

            }
            Console.Write(" = " + iloczyn9);

            Console.WriteLine();

            Console.WriteLine("Zadanie 10");

            int n10 = int.Parse(Console.ReadLine());
            int silnik10 = 1;
            int suma10 = 0;

            for (int i = 1; i < n10 + 1; i++)
            {
                silnik10 *= i;
                suma10 += silnik10;
            }

            Console.WriteLine(suma10);

            Console.WriteLine();

            Console.WriteLine("Zadanie 11");

            int n11 = int.Parse(Console.ReadLine());
            double suma11 = 0;
            int p11 = 1;

            for (int i = 1; i < n11 + 1; i++)
            {
                suma11 += p11 / Math.Pow(i, 2);
                Console.WriteLine($"{p11}/" + Math.Pow(i, 2) + " + ");
                p11 += 2;
            }
            Console.WriteLine(" = " + Math.Round(suma11, 2));

            Console.WriteLine();

            Console.WriteLine("Zadanie 12");

            int n12 = int.Parse(Console.ReadLine());
            int d12 = 0;
            int p12 = 0;
            for (int i = 1; i < n12 + 1; i++)
            {
                d12 += (i * 2) - 1;
                p12 += (int)Math.Pow(i, 2);
            }
            double suma12 = (double)d12 / p12;
            Console.WriteLine($"{d12}/{p12} = {Math.Round(suma12, 2)}");

            Console.WriteLine();

            Console.WriteLine("Zadanie 13");

            int n13 = int.Parse(Console.ReadLine());
            double suma13 = 0;
            int a13 = 3;
            int a = 1;
            int b = 2;
            int temp = 1;

            for (int i = 1; i < n13 + 1; i++)
            {
                suma13 += (double)(i * 2) / a13;
                Console.WriteLine($"{i * 2}/{a13}");
                a13 += 6 * temp + 1;
                temp = a + b;
                a = temp;
                b++;
            }
            Console.WriteLine(Math.Round(suma13, 2));

            Console.WriteLine();

            Console.WriteLine("Zadanie 14");

            int n14 = int.Parse(Console.ReadLine());
            double iloczyn14 = 1;
            int a14 = 1;

            for (int i = 1; i < n14 + 1; i++)
            {

                iloczyn14 *= (double)(i + 2) / a14;
                Console.WriteLine($"({i} + 2) / {a14}");
                a14 = a14 * 2 + 1;
            }
            Console.WriteLine(Math.Round(iloczyn14, 2));

            Console.WriteLine();

            Console.WriteLine("Zadanie 15");

            int n15 = int.Parse(Console.ReadLine());
            double iloczyn15 = 1;
            int temp = 0;
            int a15 = 0;
            int b15 = 1;
            int j = 1;

            for (int i = 1; i < n15 + 1; i++)
            {
                temp = a15;
                a15 = b15;
                b15 += temp;
                iloczyn15 *= (double) b15 / j;
                Console.WriteLine(b15 + "/" + j);
                j *= 2;
            }
            Console.WriteLine(Math.Round(iloczyn15, 2));
        }


    }

}


