using System.Diagnostics;

namespace HomeWork44
{
    internal class Program
    {
        static bool ShowSeries;

        static void FibonacciCicle(uint N)
        {
            if (N < 2)
            {
                if (ShowSeries)
                    Console.WriteLine($"{N,2:d} ={N,5:d}");
            }
            else
            {
                int f = 2;
                int n_1 = 1;
                int n_2 = 0;
                if (ShowSeries)
                {
                    Console.WriteLine($"{n_2,2:d} ={n_2,5:d}");
                    Console.WriteLine($"{n_1,2:d} ={n_1,5:d}");
                }
                for (int i = 1; i < N; i++)
                {
                    (f, n_2, n_1) = (n_1 + n_2, n_1, n_1 + n_2);
                    if (ShowSeries)
                        Console.WriteLine($"{i+1,2:d} ={f,5:d}");
                }
            }
        }

        static uint FibonacciRecursively(uint N, bool ToConsole)
        {
            if (N < 2)
            {
                if (ToConsole && ShowSeries)
                    Console.WriteLine($"{N,2:d} ={N,5:d}");
                return N;
            }
            uint f = FibonacciRecursively(N - 1, (true && ToConsole)) + FibonacciRecursively(N - 2, false);
            if (ToConsole && ShowSeries)
              Console.WriteLine($"{N,2:d} ={f,5:d}");
            return f;
        }

        static void Main(string[] args)
        {
            ShowSeries = true;

            for (uint i = 5; i <= 20; i = i * 2)
            //for (uint i = 20; i >= 5; i = i / 2)
            //uint i = 20;
            {
                var sw = new Stopwatch();
                sw.Start();
                if (ShowSeries)
                    Console.WriteLine($"FibonacciInCycle");
                FibonacciCicle(i);
                sw.Stop();
                var elapsed_Cycle = sw.Elapsed;

                Console.WriteLine($"");

                sw.Restart();
                if (ShowSeries)
                {
                    Console.WriteLine($"FibonacciRecursively");
                    Console.WriteLine($"{0,2:d} ={0,5:d}");
                }
                FibonacciRecursively(i, true);
                sw.Stop();
                var elapsed_Recursively = sw.Elapsed;

                Console.WriteLine($"");
                Console.WriteLine($"In Cycle {i,2:d}    ={elapsed_Cycle}");
                Console.WriteLine($"Recursively {i,2:d} ={elapsed_Recursively}");

            }
        }
    }

    /*
    Отдельно:

    In Cycle  5    =00:00:00.0004154
    Recursively  5 =00:00:00.0002393

    In Cycle 10    =00:00:00.0003860
    Recursively 10 =00:00:00.0002348

    In Cycle 20    =00:00:00.0004409
    Recursively 20 =00:00:00.0005761 
    
    
    С кешированием по возрастанию:
    
    In Cycle  5    =00:00:00.0003783
    Recursively  5 =00:00:00.0002170

    In Cycle 10    =00:00:00.0000006
    Recursively 10 =00:00:00.0000025

    In Cycle 20    =00:00:00.0000002
    Recursively 20 =00:00:00.0001450        


    С кешированием по убыванию:
    
    In Cycle 20    =00:00:00.0004164
    Recursively 20 =00:00:00.0004473

    In Cycle 10    =00:00:00.0000005
    Recursively 10 =00:00:00.0000021

    In Cycle  5    =00:00:00.0000002
    Recursively  5 =00:00:00.0000005        

    */


}
