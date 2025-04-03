namespace HomeWork44
{
    internal class Program
    {
        static void FibonacciCicle(uint N)
        {
            if (N < 2)
            {
                Console.WriteLine($"{N,2:d} ={N,5:d}");
            }
            else
            {
                int f;
                int n_1 = 1;
                int n_2 = 0;
                Console.WriteLine($"{n_2,2:d} ={n_2,5:d}");
                Console.WriteLine($"{n_1,2:d} ={n_1,5:d}");
                for (int i = 1; i < N; i++)
                {
                    f = n_1 + n_2;
                    n_2 = n_1;
                    n_1 = f;
                    Console.WriteLine($"{i+1,2:d} ={f,5:d}");
                }
            }
        }

        static uint FibonacciRecource(uint N, bool ToConsole)
        {
            if (N < 2)
            {
                if (ToConsole)
                    Console.WriteLine($"{N,2:d} ={N,5:d}");
                return N;
            }
            uint f = FibonacciRecource(N - 1, (true && ToConsole)) + FibonacciRecource(N - 2, false);
            if (ToConsole)
              Console.WriteLine($"{N,2:d} ={f,5:d}");
            return f;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"FibonacciCicle");
            FibonacciCicle(20);
            Console.WriteLine($"");
            Console.WriteLine($"FibonacciRecource");
            Console.WriteLine($"{0,2:d} ={0,5:d}");
            FibonacciRecource(20, true);
        }
    }
}
