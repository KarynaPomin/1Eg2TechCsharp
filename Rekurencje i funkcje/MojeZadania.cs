            // Zad. 1. Napisz program, który wyznaczy silnię z liczby n sposobem rekurencyjnym.

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
            
            // Zad. 2. 
