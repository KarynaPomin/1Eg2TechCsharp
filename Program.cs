using System;

namespace stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //punkty(i, j)

            //(1, 1)(1, 2)(1, 3)(1, 4)(1, 5)
            //(2, 1)(2, 2)(2, 3)(2, 4)(2, 5)
            //(3, 1)(3, 2)(3, 3)(3, 4)(3, 5)
            //(4, 1)(4, 2)(4, 3)(4, 4)(4, 5)
            //(5, 1)(5, 2)(5, 3)(5, 4)(5, 5)


            //// ZAD 1
            //Console.WriteLine("Zadanie 1\nLiczba:");
            //int n1 = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n1; i++) Console.Write("*-|");

            // ZAD 2
            //Console.WriteLine("Zadanie 2\nLiczba:");
            //string g = "*";
            //int n2 = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n2; i++)
            //{
            //    Console.Write(g + "||" + g + "*" + "--");
            //    g += "**";
            //}

            // TABLICA MNOŻENIA
            //    for (int i = 1; i < 11 ; i++)
            //    {
            //        for (int j = 0;  j < 11;  j++)
            //        {
            //            Console.Write(i*j + "\t");
            //        }
            //        Console.WriteLine();
            //    }

            ////// TR
            //Console.WriteLine("Liczba:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //// 1
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 1; j < n + 1; j++)     
            //        if (i >= j) Console.Write("*");
            //        else Console.Write(" ");
            //    Console.WriteLine();
            //}

            //Console.WriteLine();


            //// 2
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 1;  j < n + 1; j++)
            //        if (i <= n - j + 1)         Console.Write("*");
            //        else                Console.Write(" ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// 3
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 1; j < n + 1; j++)
            //        if (n - i + 1 <= j) Console.Write("*");
            //        else Console.Write(" ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// 4
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 1; j < n + 1; j++)
            //    {
            //        if (i <= j)  Console.Write("*");
            //        else        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// ZAD 3
            //Console.WriteLine("Zadanie 3\nLiczba:");
            //int n3 = int.Parse(Console.ReadLine());
            //string k = "|";
            //string l = "-";
            //for (int i = 0; i < n3; i++)
            //{
            //    Console.Write("*" + k + "*" + l + "-");
            //    k += "||";
            //    l += "--";
            //}

            // ZAD 4 ///////////////////////////////////////////////////
            Console.WriteLine("Zadanie 4\nLiczba:");
            int n = int.Parse(Console.ReadLine());

            ///////////////////////////////////////////////////////////////////

            //// ZAD 5 
            //Console.WriteLine("Zadanie 5\nLiczba:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{ 
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (n / 2 == j) Console.Write("*");
            //        else if (n / 2 == i) Console.Write("-");
            //        else    Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            ////ZAD 6
            //Console.WriteLine("Zadanie 6\nLiczba:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 1; j < n + 1; j++)
            //    {
            //        if (j == n + 1 - i) Console.Write("?");
            //        else if (i == j) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //// ZAD 7
            //Console.WriteLine("Zadanie 7\nLiczba:");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 1; j < n + 1; j++)
            //    {
            //        if ( i == n || i == 1 || j == 1 || j == n || i == n / 2  + 1 && j == n / 2 + 1) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
        }


    }
}
