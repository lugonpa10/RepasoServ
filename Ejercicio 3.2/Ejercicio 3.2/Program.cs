namespace Ejercicio_3._2
{
    internal class Program
    {
        static bool running = true;
        static readonly object l = new();
        static int i = 0;
        static int ganador;
        static void Main(string[] args)
        {
            Thread hiloIncrementar = new Thread(incrementar);
            Thread hiloDecrementar = new Thread(decrementar);
            hiloIncrementar.Start();
            hiloDecrementar.Start();
            hiloIncrementar.Join();
            hiloDecrementar.Join();
            if (ganador == 1)
            {
                Console.WriteLine("\nEl ganador es incrementar");

            }
            else
            {
                Console.WriteLine("\nEl ganador es incrementar");

            }
        }

        static void incrementar()
        {
            while (running)
            {
                lock (l)
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{i}\t");
                    Console.ResetColor();


                    if (i >= 500)
                    {
                        running = false;
                        ganador = 1;

                    }
                }

            }

        }

        static void decrementar()
        {

            while (running)
            {
                lock (l)
                {
                    i--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{i}\t");
                    Console.ResetColor();
                    if (i <= -500)
                    {
                        running = false;
                        ganador = 2;
                    }
                }
            }
        }


    }
}
