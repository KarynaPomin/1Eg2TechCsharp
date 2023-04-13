 Console.Write("Podaj liczbę: ");
 int n = int.Parse(Console.ReadLine());

 /// ZADANIE 1 --> FUNKCJE ///

 // 1.1 Napisz funkcję, która zwraca sumę cyfr podanej liczby

 int SumaCyfr(int n)
 {
     int suma = 0;
     while (n > 0)
     {
         suma += n % 10;
         n /= 10;
     }
     return suma;
 }
 Console.WriteLine($"Suma cyfr: {SumaCyfr(n)}");

 // 1.2 Napisz funkcję, która zwraca odwrócony do wprowadzonego napis

 Console.Write("String: ");
 string s = Console.ReadLine();

 string OdwrotnyNapis(string s)
 {
     string odwrotnie = "";
     for (int i = 1; i < s.Length + 1; i++)
     {
         odwrotnie += s[s.Length - i];
     }
     return odwrotnie;
 }
 Console.WriteLine($"Odwrotny zapis: {OdwrotnyNapis(s)}");

 // 1.3 Napisz funkcję, która wypisuje łańcuchy połówek wpisanej liczby, aż do 1. np. po wpisaniu 30 otrzymujemy 30-15-7-3-1. 

 string LancuchPowowek(int n)
 {
     string lancuch = "30";
     while (n > 1)
     {
         n /= 2;
         lancuch += $"-{n}";
     }
     return lancuch;
 }
 Console.WriteLine($"Łańcuch połuwek: {LancuchPowowek(n)}");

 /// ZADANIE 2 --> CIĄGI BELGIJSKIE ///


 // 2.1 Napisz rekurencyjnie n liczb: 3, 5, 7, 9, 11...

 Console.WriteLine("Zadanie 2.1");
 int reku1(int n)
 {
     if (n <= 1) return 3;
     return reku1(n - 1) + 2;
 }

 for (int i = 1; i < n; i++)
     Console.Write(reku1(i) + " ");
 Console.WriteLine();

 // 2.2 Napisz rekurencyjnie n liczb: 6, 12, 24, 48, 96...

 Console.WriteLine("Zadanie 2.2");
 int reku2(int n)
 {
     if (n <= 1) return 6;
     return reku2(n - 1) * 2;
 }

 for (int i = 1; i < n; i++)
     Console.Write(reku2(i) + " ");
 Console.WriteLine();

 // 2.3 Napisz rekurencyjnie n liczb: 1, 1, 3, 5, 11, 21...   

 Console.WriteLine("Zadanie 2.3");
 int reku3(int n)
 {
     if (n == 1 || n == 2) return 1;
     return 2 * reku3(n - 2) + reku3(n - 1);
 }

 for (int i = 1; i < n + 1; i++)
     Console.Write(reku3(i) + " ");
 Console.WriteLine();

 // 2.4 Napisz rekurencyjnie n liczb: 1, 2, -1, 3, -4, 7, -11, 18... 

 Console.WriteLine("Zadanie 2.4");
 int reku4(int n)
 {
     if (n == 1) return 1;
     if (n == 2) return 2;
     return reku4(n - 2) - reku4(n - 1);
 }

 for (int i = 1; i < n; i++)
     Console.Write(reku4(i) + " ");
 Console.WriteLine();

 // 2.5 Napisz rekurencyjnie n liczb: 1, 2, 3, 0, 6, 3, -3, 21...

 Console.WriteLine("Zadanie 2.5");
 int reku5(int n)
 {
     if (n == 1) return 1;
     if (n == 2) return 2;
     if (n == 3) return 3;
     return 3 * reku5(n - 3) - reku5(n - 1);
 }

 for (int i = 1; i < n + 1; i++)
     Console.Write(reku5(i) + " ");
 Console.WriteLine();

 /// ZADANIE 3 --> Kto gra w pliki na wyniki///

 // 3.1 Stwóż plik z dzisiejszą datą.
 string path = @"Zadanie.txt";
 DateTime today = DateTime.Now;
 StreamWriter zadanie;
 if (!File.Exists(path))
 {
     zadanie = File.CreateText(path);
     Console.WriteLine("Plik utworzony!");
 }
 else
 {
     zadanie = new StreamWriter(path, true);
     Console.WriteLine("Plik otworty!");
 }
 zadanie.WriteLine("Data: " + today);
 zadanie.WriteLine();

 // 3.2 Zapisz do pliku 10 lisowych liczb dwucyfrowych. Odczytaj ten plik i wypisz największą z liczb.

 zadanie.WriteLine("Zadanie 3.2");
 int[] dwucyfrowaLista = new int[10];
 Random ranf1 = new Random();
 for (int i = 0; i < dwucyfrowaLista.Length; i++)
     dwucyfrowaLista[i] = ranf1.Next(10, 100);
 foreach (var r in dwucyfrowaLista)
     zadanie.WriteLine(r);

 int maksi = int.MinValue;
 for (int i = 0; i < dwucyfrowaLista.Length; i++)
     if (dwucyfrowaLista[i] > maksi)
         maksi = dwucyfrowaLista[i];
 zadanie.WriteLine("Max: " + maksi);
 zadanie.WriteLine();

 // 3.3 Zapisz do pliku 100 losowych liczb trzycyfrowych. Odczytaj ten plik i wypisz wszystkie liczby-palindromy, np.272 itp.

 zadanie.WriteLine("Zadanie 3.3");
 int[] trzycyfrowaLista = new int[100];

 Random rand2 = new Random();
 for (int i = 0; i < trzycyfrowaLista.Length; i++)
     trzycyfrowaLista[i] = rand2.Next(100, 1000);
 foreach (var r in trzycyfrowaLista)
     zadanie.WriteLine(r);
 zadanie.WriteLine();

 zadanie.WriteLine("Palindromy:");
 foreach (var palindrom in trzycyfrowaLista)
     if (palindrom % 10 == palindrom / 100)
         zadanie.WriteLine(palindrom);

 zadanie.Close();
