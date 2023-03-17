            // Zad. 1. Napisz program, który wyznaczy silnię z liczby n sposobem rekurencyjnym.
            
            // SPOSÓB 1
            
            int Factorial(int n)
            {
                int w;
                if (n == 1) return n;
                w = Factorial(n - 1);
                w *= n;
                Console.WriteLine($"{n} --> {w}");
                return w;
            }
            Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));
            
            // SPOSÓB 2

            int SilniaReku(int n)
            {
                Console.WriteLine($"({n} - 1) * {n}");
                if (n == 1)
                    return 1;
                else return SilniaReku(n - 1) * n;
            }

            Console.WriteLine(SilniaReku(5));
            
            // Zad. 2. Fibonacci
            
            int Fibo(int n)
            {
                int w;
                if (n <= 2) return 1;
                w = Fibo(n - 1);
                w += Fibo(n - 2);
                return w;
            }
            Console.Write("Wpisz: ");
            Console.WriteLine(Fibo(int.Parse(Console.ReadLine()))); 

            // Zad. 3. Eukides

            int Euklides(int a, int b)
            {
                if (b == 0) return a;
                return Euklides(b, a % b);
            }
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Euklides(a, b));
