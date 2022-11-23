//see https://aka.ms/new-console-template for more information
//// tableca - zminna (kolekcja) do trzynania wielu zmiennych
//int a = 3;
//int b = 5;
//int c = 6;
//int d = 7;

//// t - tablice
//int[] t = new int[4];
//t[0] = 3;
//t[1] = 5;
//t[2] = 6;
//t[3] = 7;

//console.writeline(t[3] + " " + t[2]);

//for (int i = 0; i < t.length; i++)      // or i < 4
//{
//    console.writeline(t[i]);
//}

//    int[] K = { 2, 3, 5, 8, 13, 21, 34, 55 };
//for (int i = 0; i < K.Length; i++)
//{
//    Console.Write($"{K[i]} ");
//}

//int[] L;
//L = new int[] { 1, 3, 5 };

//for (int i = 0; i < L.Length; i++)
//{
//    Console.Write($"{L[i]}");   //Console.Write(L[i] + " ");
//}

// Zad. Znajź maksymalna wartość tablicy [4, 5, 8, 9, 7, 6]
//int[] L;
//int maks = 0;
//L = new int[] { 4, 5, 8, 9, 7, 6 };
//for (int i = 0; i < L.Length; i++)
//{
//	if (L[i] > maks)
//	{
//		maks = L[i];

//	}	
//}
//Console.WriteLine(maks);

// Zad. Znajź minimalna wartość tablicy [4, 5, 8, 9, 7, 6]

//int[] M = new int[] { 4, 5, 8, 9, 7, 6 };
//int minim = M[0];
//for (int i = 0; i < M.Length; i++)
//{
//    if (M[i] < minim)
//    {
//        minim = M[i];
//    }
//}
//Console.WriteLine(minim);

int mini = int.MinValue;
int[] L = new int[] { 4, 5, 8, 9, 7, 6 };
