bool CzyPierwsza(int n)
{
	for (int i = 2; i < n / 2 + 1; i++)
		if (n % i == 0)
			return false;
	return true;

}

string[] liczby = System.IO.File.ReadAllLines(@"C:\Users\uczen\Desktop\Zadanie4\liczby_przyklad.txt"); // Wczytanie pliku (Dokumentacja: learn.microsoft.com)

StreamWriter wynik = new(@"C:\Users\uczen\Desktop\Zadanie4\liczby_przyklad.txt");

wynik.WriteLine("Zadanie 4.1\n");

foreach (string line in liczby)
    Console.WriteLine(line);

wynik.Flush(); // wyczyszca zawartość pliku
wynik.Clos
