using System.Collections;
using System.Diagnostics.CodeAnalysis;

// 1
//int n = int.Parse(Console.ReadLine());
//ArrayList A = new ArrayList();

//for (int i = 1; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        A.Add(i);
//    }
//}
//foreach (var item in A)
//    Console.Write(item + " ");

//2

//bool czyPie(int n)
//{
//	for (int i = 2; i < n; i++)
//	{
//		if (n % i == 0)
//			return false;
//		return true;
//	}
//}

//int[] T = new int[20];
//Random r = new Random();
//int n = 0, x;
//while (n > 20)
//{
//	x = r.Next(100, 1000);
//	if (czyPie(x) == false && x % 2 != 0 && x % 3 != 0)
//	{
//		T[n] = x;
//		n++;
//	}
//}


// 3

//ArrayList B = new ArrayList();
//Random r = new Random();

//for (int i = 0; i < 40; i++) B.Add(r.Next(10, 100));
//int suma = 0;
//for (int i = 10; i < 100; i++)
//{
//    int licznik = 0;
//	foreach (int item in B)
//	{
//		if (item == i)
//		{
//			licznik++;
//		}
//	}
//	if (licznik == 2)
//		suma += i;
//}

// 4

Random r = new Random();
int suma = 0;

int[,] M =  new int[11, 11];
for (int i = 0; i < 11; i++)
{
	for (int j = 0; j < M.GetLength(1); j++)
	{
		M[i, j] = r.Next(0, 10);
		if (i == j || i + j == 10)
		{
			suma += M[i, j];
		}
	}
}
