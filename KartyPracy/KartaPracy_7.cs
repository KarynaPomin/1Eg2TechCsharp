            // Tablica
            int[] T = new int[40];
            Random r = new Random();

            for (int i = 0; i < T.Length; i++)
                T[i] = r.Next(10, 100);

            foreach (var item in T)
                Console.Write(item + " ");

            Console.WriteLine();

            // Zad 1
            Console.WriteLine("Zadanie 1");

            int maks_1 = 0;

            for (int i = 0; i < T.Length; i++)
                if (T[i] > maks_1) maks_1 = T[i];

            Console.WriteLine($"Maks: {maks_1}");
            Console.WriteLine();

            // Zad 2
            Console.WriteLine("Zadanie 2");

            int mini_2 = int.MaxValue;

            for (int i = 0; i < T.Length; i++)
                if (T[i] < mini_2) mini_2 = T[i];

            Console.WriteLine($"Min: {mini_2}");
            Console.WriteLine();

            // Zad 3
            Console.WriteLine("Zadanie 3");

            Console.WriteLine($"Rozpiętość tablicy: {mini_2} - {maks_1}");
            Console.WriteLine();

            // Zad 4
            Console.WriteLine("Zadanie 4");

            int vice_maksi = 0;

            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] > vice_maksi && T[i] != maks_1)
                    vice_maksi = T[i];
            }

            Console.WriteLine($"Vice-maks: {vice_maksi}");
            Console.WriteLine();

            // Zad 5
            Console.WriteLine("Zadanie 5");

            int vice_mini = int.MaxValue;

            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] < vice_mini && T[i] != mini_2)
                    vice_mini = T[i];
            }

            Console.WriteLine($"Vice-mini: {vice_mini}");
            Console.WriteLine();


            // Zad 6
            Console.WriteLine("Zadanie 6");
            int ile_maksi = 0;

            foreach (var maks in T)
                if (maks == maks_1)
                    ile_maksi++;
            
            Console.WriteLine($"Maksi występuje {ile_maksi} razy.");
            Console.WriteLine();

            // Zad 7
            Console.WriteLine("Zadanie 7");

            int ile_mini = 0;

            foreach (var mini in T)
                if (mini == mini_2) ile_mini++;

            Console.WriteLine($"Mini występuje {ile_mini} razy");
            Console.WriteLine();

            // Zad 8
            Console.WriteLine("Zadanie 8");
            Console.Write("Jaką chcesz sprawdzić liczbę: ");

            int user_num = int.Parse(Console.ReadLine());
            int ile_user_num = 0;

            foreach (var num in T)
                if (user_num == num) ile_user_num++;

            Console.WriteLine(ile_user_num);
            Console.WriteLine();

            // Zad 9
            Console.WriteLine("Zadanie 9");
            int suma_srd = 0;

            foreach (var item in T)
                suma_srd += item;

            float srednia = suma_srd / T.Length;
            Console.WriteLine($"Średnia elementów tablicy wynosi {Math.Round(srednia, 1)}");
            Console.WriteLine();

            // Zad 10
            Console.WriteLine("Zadanie 10");
            int suma_parz = 0;

            for (int i = 0; i < T.Length; i++)
                if (i % 2 == 0)
                    suma_parz += T[i];

            Console.WriteLine($"Suma parzystych: {suma_parz}");
            Console.WriteLine();

            // Zad 11
            Console.WriteLine("Zadanie 11");

            int sum_niep = 0;

            for (int i = 0; i < T.Length; i++)
            {
                if (i % 2 != 0)
                    sum_niep += T[i];
            }

            float srednie_niep = sum_niep / T.Length;
            Console.WriteLine($"Średnia elementów nieparzystych wynosi: {Math.Round(srednie_niep, 2)}");
            Console.WriteLine();

            // Zad 12
            Console.WriteLine("Zadanie 12");
            int ile_liczb_niepowtarzalnych = 0;

            for (int a = 0; a < T.Length; a++)
            {
                int ile_powtarzalnych = 0;
                for (int b = 0; b < T.Length; b++)
                {
                    if (T[a] == T[b])
                        ile_powtarzalnych++;
                }
                if (ile_powtarzalnych == 1)
                    ile_liczb_niepowtarzalnych++;
            }

            Console.WriteLine($"Liczb niepowtaralnych jest {ile_liczb_niepowtarzalnych}");
            Console.WriteLine();

            // Zad 13
            Console.WriteLine("Zadanie 13");

            for (int i = 10; i < 100; i++)
            {
                int x = 0;
                foreach (var item in T)
                {
                    if (i != item) x = 1;
                    else
                    {
                        x = 0;
                        break;
                    }
                }
                if (x == 1)
                    Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Zad 14
            Console.WriteLine("Zadanie 14");

            Console.WriteLine($"Trzeba usunąć {T.Length - ile_liczb_niepowtarzalnych}, aby pozostały tylko wartości unikalne");
            Console.WriteLine();

            // Zad 15
            Console.WriteLine("Zadanie 15");

            ArrayList C = new ArrayList();
            int ciag = 1;

            for (int i = 0; i < T.Length - 1; i++)
            {
                if (T[i] < T[i + 1])
                    ciag++;
                else
                {
                    C.Add(ciag);
                    ciag = 1;
                }
            }

            foreach (var item in C)
                Console.Write(item + " ");

            //NIE ZAKOŃCZONE ZADANIE
