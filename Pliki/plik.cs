// 4.1. Otwórz plik w ktorym zapisano 500 liczb.


// odczytanie pliku sposób 1
StreamReader sr = new StreamReader("C:\\Users\\uczen\\Desktop\\Karyna_Pomin_1-E\\przyklad.txt");
int[] T = new int[500];
for (int i = 0; i < 500; i++)
{
    //Console.WriteLine(int.Parse(sr.ReadLine()) + " ");
    T[i] = int.Parse(sr.ReadLine());
}

//for (int i = 0; i < 500; i++)
//{
//    Console.Write(T[i] + "\t");
//}

// 4.2. Podaj ile z podanych liczb są potęgami liczby 3 (czyli liczbami w postaci 3^0 = 1, 3^1 = 3, 3^2 = 9 itd.)

//WERSJA 1
//int[] P = new int[] { 1, 3, 9, 27, 81, 243, 729, 2197, 6561, 19683, 59049 };
//int ilosc = 0;
//for (int i = 0; i < 500; i++)
//{
//    for (int j = 0; j < 11; j++)
//    {
//        if (T[i] == P[j])
//        {
//            ilosc++;
//            break;
//        }
//    }
//}
//Console.WriteLine(ilosc);

//WERSJA 2

//int ilosc = 0;
//for (int i = 0; i < 500; i++)
//{
//    for (int j = 0; j < 11; j++)
//    {
//        if (T[i] == Math.Pow(3, j))
//        {
//            ilosc++;
//            break;
//        }
//    }
//}
//Console.WriteLine(ilosc);

//WERSJA 3

int x;
int ilosc = 0;
for (int i = 0; i < 500; i++)
{

   x = T[i];
   while (x > 1)
   {
      if (x % 3 == 0)
         x = x / 3;
      else break;
   }
   if (x == 1)
       ilosc++;
}
Console.WriteLine(ilosc);


// odczytanie pliku sposób 2
//while (!sr.EndOfStream)
//{
//    Console.WriteLine(sr.ReadLine() + " ");
//}
