
// Zad 1

using System.Collections;

int n = int.Parse(Console.ReadLine());
ArrayList D = new ArrayList();

for (int i = 1; i < n + 1; i++)
    if (n % i == 0)
        D.Add(i);

foreach (int i in D)
    Console.Write(i + " ");

Console.WriteLine();

// Zad 2

int[] T = new int[20];
Random r_2 = new Random();
int temp = 0;
int tm = 0;

while (tm < 20)
{
    temp = r_2.Next(100, 1000);
    if (temp % 50 == 0)
    {
        T[tm] = temp;
        tm++;
    }
}

foreach (int i in T)
    Console.Write(i + " ");

// Zad 3

int n_3 = int.Parse(Console.ReadLine());
if (n_3 % 2 == 0)
{
    int[] P = new int[n_3];
    int P_p = 0;
    int P_l = 0;

    Random r_3 = new Random();

    for (int i = 0; i < P.Length; i++)
    {
        P[i] = r_3.Next(10, 100);
    }

    for (int i = 0; i < P.Length; i++)
    {
        if (i > P.Length / 2)
            P_l += P[i];
        else
            P_p += P[i];
    }

    Console.WriteLine($"Prawa: {P_p} i lewa {P_l}");
    if (P_l < P_p)
        Console.Write("Większa jest prawa strona.");
    else
        Console.Write("Większa jest lewa strona.");
}

else
    Console.WriteLine("Podałeś liczbę nieparzystą.");

// Zad 4 

int[,] M = new int[25, 25];
Random r_4 = new Random();

for (int i = 0; i < M.GetLength(0); i++)
{
	for (int j = 0; j < M.GetLength(1); j++)
	{
		M[i, j] = r_4.Next(100, 1000);
	}
}

foreach (var item in M)
	Console.Write(item + " ");

Console.WriteLine();

int suma_4 = 0;

foreach (var item in M)
{
	int ile = 0;
	for (int i = 0; i < M.GetLength(0); i++)
	{
		for (int j = 0; j < M.GetLength(1); j++)
		{
			if (item == M[i, j])
				ile++;
		}
	}
	if (ile > 2)
		suma_4 += item;
}

Console.WriteLine(suma_4);


