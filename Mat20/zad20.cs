string[] S = System.IO.File.ReadAllLines(@"C:\Users\uczen\Desktop\Mat20\przyklad.txt");

int[] L = new int[S.Length];
string[] N = new string[S.Length];

//foreach (string item in S)
//{
//    Console.WriteLine(item);
//    string[] TE = item.Split(" ");
//    Console.WriteLine(TE[1]);
//}

// L - to ma byc tablica intów
// N - to ma być tablica stringów

int k = 0;
string[] LINIA = new string[2];
foreach (string item in S)
{
    // SPOSÓB 1
    //L[k] = int.Parse((item.Split(" "))[0]);
    //N[k] = (item.Split())[1];

    // SPOSÓB 2
    LINIA = item.Split(" ");
    L[k] = int.Parse(LINIA[0]);
    N[k] = LINIA[1];

    k++;
}

bool czyPierwsza(int n)
{
    for (int i = 2; i < n; i++)
        if (n % 1 == 0)
            return false;
    return true;
}

for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 4 && L[i] % 2 == 0)
    {
        for (int j = 2; j < L[i]; j++)
        {
            if (czyPierwsza(j) && czyPierwsza(L[i] - j))
            { 
                Console.WriteLine($"{L[i]} {j} {L[i] - j}");
                break;
            }
        }
    }
}

