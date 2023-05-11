using System; 
// Sortowania przez porównanie

// Stworzenie tablicy 10 losowych liczb <1;20>

Random r = new Random();
int n = 10;
int[] T = new int[n];
for (int i = 0; i < n; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
}

// 1. Bąbelkowe
// od prawej rosnąco

int tempik;
for (int i = n-1; i >= 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (T[j] > T[j + 1])
        {
            tempik = T[j];
            T[j] = T[j + 1];
            T[j + 1] = tempik;
        }
    }
}

// 2. Przez wybór (selection sort)
//wybieramy najmniejszy i wstawiamy na początek

int k;
int tempo;
for (int i = 0; i < n; i++)
{
    k = i;
    for (int j = i+1; j < n;  j++)
        if (T[j] < T[k]) k = j;
    tempo = T[i];
    T[i] = T[k];
    T[k] = tempo;
}

//wybieramy najmniejszy i wstawiany na koniec

int k;
int tempo;
for (int i = n-1; i > 0; i--)
{
    k = i;
    for (int j = 0; j < i; j++)
        if (T[j] < T[k]) k = j;
    tempo = T[i];
    T[i] = T[k];
    T[k] = tempo;
}

// 3. Przez wstawianie (insertion sort) -nie skończone

int j, temp;
for (int i = 1; i < n; i++)
{
    temp = T[i];
    j = i-1;
    while (j > 0 && temp < T[j])
    {
        T[j] = T[j - 1];
        j--;
    }
    T[j] = temp;
}

// MY //
for (int i = 1; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        while (T[i] < T[j])
        {
            int temp = T[i];
            T[i] = T[j];
            T[j] = temp;
        }
    }
}
////////

// Sortowania w czasie liniowym - 0(n)

 // 4. Przez zliczanie (counting sort)

int[] L = new int[20];

for (int i = 0; i < n; i++)
    L[T[i]]++;

foreach (var item in L)
    Console.Write(item + " ");

int j = 0;
for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 0)
    {
        for (int k = 0; k < L[i]; k++)
        {
            T[j] = i;
            j++;
        }
    }
}

// 5. Kubełkowe ---

// Dziel i zwyciężaj 

// 6. Przez scalanie
void scalaj(int lewy, int prawy) // 0 - 3
{
    int[] pom = new int[n]; // Tablica pomocnicza
    for (int a = 0; a < n; a++) pom[a] = T[a];
    int i, i_lewy, i_prawy;
    int srodek = (lewy + prawy) / 2;
    i = lewy; // indeks tabeli
    i_lewy = lewy;
    i_prawy = srodek;

    while (i_lewy <= srodek && i_prawy <= prawy)
    {
        if (pom[i_lewy] < pom[i_prawy])
        {
            T[i] = pom[i_lewy];
            i_lewy++;
        }
        else{
            T[i] = pom[i_prawy];
            i_prawy++;
        }
        i++;
    }
    if (i_lewy > srodek)
    {
        while (i_prawy < prawy)
        {
            T[i] = pom[i_prawy];
            i_prawy++;
            i++;
        }
    }
    else
    {
        while (i_lewy <= srodek)
        {
            T[i] = pom[lewy];
            i_lewy++;
            i++;
        }
    }
}
/// Nie dokończone do góry i na dole!!
void sortuj(int lewy,int prawy)
{
    int srodek = (lewy + prawy) / 2;
    if (lewy < prawy)
        sortuj(lewy, srodek);
    if (srodek + 1 < prawy)
        // ...
}

// 7. Quicksort Hoare

// 8. Quicksort Lomuto

// Wyświetlenie posortowanej tablicy

Console.WriteLine("\n");
for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");
