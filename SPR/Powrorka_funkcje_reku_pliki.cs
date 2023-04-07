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

            // 1.2 Napisz funkcję, która zwraca odwrócony do wprowadzonego napis

            string OdwrotnyNapis(string s)
            {
                string odwrotnie = "";
                for (int i = 1; i < s.Length + 1; i++)
                {
                    odwrotnie += s[s.Length - i];
                }
                return odwrotnie;
            }

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


            /// ZADANIE 2 --> CIĄGI BELGIJSKIE

            int n = int.Parse(Console.ReadLine());

            // 2.1 Napisz rekurencyjnie n liczb: 3, 5, 7, 9, 11...

            //int reku1(int n)
            //    if (n <= 1) return 3;
            //    return reku1(n - 1) + 2;

            //for (int i = 1; i < n; i++)
            //    Console.Write(reku1(i) + " ");


            // 2.2 Napisz rekurencyjnie n liczb: 6, 12, 24, 48, 96...

            //int reku2(int n)
            //{
            //    if (n <= 1) return 6;
            //    return reku2(n - 1) * 2;             
            //}

            //for (int i = 1; i < n; i++)
            //    Console.Write(reku2(i) + " ");

            // 2.3 Napisz rekurencyjnie n liczb: 1, 1, 3, 5, 11, 21...   

            //int reku3(int n)
            //{
            //    if (n == 1 || n == 2) return 1;
            //    return 2 * reku3(n - 2) + reku3(n - 1);
            //}

            //for (int i = 1; i < n + 1; i++)
            //    Console.Write(reku3(i) + " ");

            // 2.4 Napisz rekurencyjnie n liczb: 1, 2, -1, 3, -4, 7, -11, 18... 

            //int reku4(int n)
            //{
            //    if (n == 1 ) return 1;
            //    if (n == 2) return 2;
            //    return reku4(n - 2) - reku4(n - 1);
            //}

            //for (int i = 1; i < n; i++)
            //    Console.Write(reku4(i) + " ");

            // 2.5 Napisz rekurencyjnie n liczb: 1, 2, 3, 0, 6, 3, -3, 21...

            int reku5(int n)
            {
                if (n == 1) return 1;
                if (n == 2) return 2;
                if (n == 3) return 3;
                return 3 * reku5(n - 3) - reku5(n - 1);
            }

            for (int i = 1; i < n; i++)
                Console.Write(reku5(i) + " ");
