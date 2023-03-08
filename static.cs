// typ_wyniku nazwa(arg)
// {
// 	instrukcje
// 	return
// }

void przywitaj()
{
	Console.ReadLine("Cześć");
}

przywitaj();

// funkcja obliczająca sume 2 podanych liczb

int suma(int a, int b)
{
	return a + b;
}
Console.WriteLine(suma(4, 6));

// funkcja odwracająca stringa 

string odwrocStringa(string napis)
{
	char[] chars = napis.ToCharArray();
	Array.Reverse(chars);
	return new string(chars);
}
Console.WriteLine(odwrocStringa("Kot"))

// funkcja, która przyjmuje dowolną ilość elementów
// suma wszystkich argumentów (tyle ile ich jest)

int bigSuma(int[] T)
{
	int suma = 0;
	foreach(int item in T)
	{
		suma += item;
	}
	return suma;
}
Console.WriteLine(bigSuma(new int[] {4, 7, 8, 9}))

//rekurencja - uwaga, nie urochamiać!

void rekurencja()
{
	Console.WriteLine("YO");
	rekurencja();
}

// rekurencja();

void reku1(int n)
{
	if (n == 0) return;
	Console.WriteLine(n);
	reku1(n - 1);
}
reku1(5);
	
//////
	
void reku2(int n)
{
	if (n == 0) return;
	reku2(n - 1);
	Console.WriteLine(n);
}
reku2(5);

// reku(5) --> reku(4)
// reku(4) --> reku(3)
// reku(3) --> reku(2)
// reku(2) --> reku(1)
// reku(1) --> reku(0)
	
/////
	void reku2(int n)
{
	if (n == 0) return;
	Console.WriteLine(n);
	reku2(n - 1);
	Console.WriteLine(n);
}
reku2(5);