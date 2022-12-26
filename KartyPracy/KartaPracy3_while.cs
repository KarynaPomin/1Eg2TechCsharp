// See https://aka.ms/new-console-template for more information

//for (int i = 1; i < 10; i++)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();

//int i = 1;
//while(i < 10)
//{
//    Console.WriteLine(i++ + " ");
//    //i++; // ++i
//}
//Console.WriteLine();

//int k = 1;
//do
//{
//    Console.Write(k + " ");
//    k++;
//} while (k < 10);

// pętla  nieskończona
//int n = 0;
//for (;;)
//{
//	n++;
//	Console.Write(1);
//	if (n == 100)
//	{
//		break;
//	}
//}

// napisz pętlę while, wypisującą malejąco liczby 2-cyf. niepodzielne przez 3

//int i = 99;
//while (i >= 10)
//{
//	if (i % 3 != 0)
//	{
//		Console.Write(i + " ");
//	}
//	i--;
//}

// KARTA PRACY 3 W WHILE
// Zad 1
//int i = 0;
//while (i < 10)
//{
//    Console.Write(Math.Pow(i, 3) + 3 + " ");
//    i++;
//}
// Zad 2
//int w = 100;
//while (w < 1000)
//{
//	if (w % 15 == 0) Console.Write(w);
//	w++;
//}
//Zad 3
//int n = int.Parse(Console.ReadLine());
//int p = 0;
//while (p <= n)
//{
//    if (n % p == 0)
//    {
//        Console.Write(p + " ");
//    }
//    p++;
//}
//Zad 4
//int n = 10;
//int suma = 0;
//while (n < 100)
//{
//    suma += n;
//    n++;
//}
//Console.Write(suma);
//Zad 5
//int n = int.Parse(Console.ReadLine());
//int i = 0;
//int suma = n * (n + 1) / 2;
//while (i < n - 1)
//{
//    int x = int.Parse(Console.ReadLine());
//    suma -= x;
//    i++;
//}
//Console.WriteLine(suma);
////Zad 6
//int i = 0, temp;
//int n = int.Parse(Console.ReadLine());
//int a = 0;
//int b = 1;
//while (i < n)
//{
//    temp = a;
//    a = b;
//    b += temp;
//    Console.Write(b);
//    i++;
//}

// Zad - Zadanie stricte na łajla. Oblicz sumę cyfr zadanej liczby n.
int n = int.Parse(Console.ReadLine());
int suma = 0;
while (0 < n)
{
    suma += n % 10;
    n = n / 10;
}
Console.WriteLine(suma);

