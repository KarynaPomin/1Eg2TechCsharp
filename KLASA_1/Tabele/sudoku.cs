
//int[] T = new int[100];
//Random rand = new Random();
//int suma = 0;
//int np = 0;
//for (int i = 0; i <= 100; i++)
//{
//    T[i] = rand.Next(10, 100);
//}

//for (int i = 0; i < T.Length; i++)
//{
//    if (T[i] % 2 == 0) suma += T[i];
//    else np++;
//}

//Console.WriteLine($"Suma liczb parzystych wynosi {suma}.");
//Console.WriteLine($"Ilość nieoarzystych: {np}.");

//
//int[,] T = new int[5, 5];

//for (int i = 0; i < 5; i++)
//{
//	for (int j = 0; j < 5; j++)
//	{
//		Console.Write(T[i,j] + "\t");
//	}
//	Console.WriteLine();
//}

///// sudoku *** K
//int[,] M = new int[,] { { 1,2,3,}, {4,5,6}, {7,8,9} };
//for (int l = 0; l < 3; l++)
//{
//	for (int k = 0; k < 3; k++)
//	{
//		for (int i = 0; i < 3; i++)
//		{
//			for (int j = 0; j < 3; j++)
//			{
//				Console.Write(M[i, j] + " ");
//			}
//			Console.Write(" ");
//		}
//		Console.WriteLine();
//	}
//	Console.WriteLine();
//}

/// Zad

//int[,] M = new int[4,4];
//Random r = new Random();
//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        M[i, j] = r.Next(1, 10);
//    }
//}

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.Write(M[i, j] + "\t" );
//        Console.WriteLine();
//    }
//}

/// Zad - wypęłnić macierz 3x5 licz. dwuc. korzyst. z GetLenth()
int[,] M = new int[3, 5];
Random r = new Random();
for (int i = 0; i < M.GetLength(0); i++)
{
	for (int j = 0; j < M.GetLength(1); j++)
	{
		M[i, j] = r.Next(10, 100);
	}
}

for (int i = 0; i < M.GetLength(0); i++)
{
	for (int j = 0; j < M.GetLength(1); j++)
	{
        Console.Write(M[i, j] + "\t");

    }
	Console.WriteLine();
}

