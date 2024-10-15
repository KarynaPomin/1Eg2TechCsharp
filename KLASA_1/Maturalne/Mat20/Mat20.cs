using System.IO;

namespace study
{
    class Program
    {
        static void Main()
        {
            StreamWriter wynik4 = new StreamWriter(@"C:\Users\Karyna\Downloads\1Eg2TechCsharp-main\1Eg2TechCsharp-main\Zadania\Zad20\wynik4.txt");

            string[] S = System.IO.File.ReadAllLines(@"C:\Users\Karyna\Downloads\1Eg2TechCsharp-main\1Eg2TechCsharp-main\Zadania\Zad20\przyklad.txt");

            bool CzyPierwsza(int n)
            {
                for (int i = 2; i < n / 2 + 1; i++)
                    if (n % i == 0)
                        return false;
                return true;
            }

            // Zadanie 1

            string[] LINIA = new string[1];
            int[] L = new int[S.Length];
            string[] N = new string[S.Length];
            int k = 0;
            foreach (string item in S)
            {
                L[k] = int.Parse((item.Split(" "))[0]);
                N[k] = (item.Split())[1];
                k++;
            }

            ///
            wynik4.WriteLine("Zadanie 4.1");
            foreach (var item in L)
            {
                if (item % 2 == 0)
                {
                    for (int i = 2; i < item; i++)
                    {
                        if (CzyPierwsza(i))
                            if (CzyPierwsza(item - i))
                            {
                                wynik4.WriteLine($"{item} --> {i} i {item - i}");
                                break;
                            }
                    }
                }
            }

            ///
            wynik4.WriteLine();
            wynik4.WriteLine("Zadanie 4.2");

            int ilosc = 1;
            int maksi = 0;
            string maksi_string = "";
            string max_str = "";

            for (int i = 0; i < N.Length; i++)
            {
                string words = N[i];  
                string temp = N[i];
                for (int j = 0; j < words.Length; j++)
                    if (j + 1 < words.Length && words[j] == temp[j + 1])
                    {
                        ilosc++;
                        maksi_string += words[j];
                    }
                    else
                    {
                        if (ilosc > maksi)
                        {
                            maksi = ilosc;
                            max_str = maksi_string + words[j];
                        }
                        ilosc = 1;
                        maksi_string = "";
                    }
                wynik4.WriteLine($"{max_str} --> {maksi}");
                maksi = 0;
                max_str = "";
            }

            ///
            wynik4.WriteLine();
            wynik4.WriteLine("Zadanie 4.3");

            string OdwrotnyString(string a)
            {
                string s = "";
                ArrayList T = new ArrayList();
                for (int l = 0; l < a.Length; l++)
                {
                    T.Add(a[l]);
                }
                T.Sort();

                foreach (var item in T)
                {
                    s += item;
                }
                return s;
            }

            int mini = int.MaxValue;
            string mniejsza = "";

            for (int i = 0; i < N.Length; i++)
            {
                if (N[i].Length == L[i])
                {
                    wynik4.WriteLine($"{L[i]} --> {N[i]}");
                    if (mini > L[i])
                    {
                        mniejsza = L[i] + " " + N[i];
                        mini = L[i];
                    }
                    else if (mini == L[i] && OdwrotnyString(N[i]) == N[i])
                        mniejsza = L[i] + " " + N[i];
                }
            }

            wynik4.WriteLine("Mniejsza -> " + mniejsza);


            wynik4.Close();
        }
    }
}
