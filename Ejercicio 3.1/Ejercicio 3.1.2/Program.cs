namespace Ejercicio_3._1._2
{
    internal class Program
    {
        static bool running = true;
        static readonly object l = new();
        static void Main(string[] args)
        {
            Thread hiloMultiplos = new Thread(() => multiplos(5));
            Thread hiloPrimos = new Thread(() => primos(15));
            hiloMultiplos.Start();
            hiloPrimos.Start();

        }

        static void multiplos(int num)
        {

            int fila = 0;
            int i = 0;
            while (running)
            {
                lock (l)
                {
                    if (running)
                    {
                        i++;
                        Console.SetCursorPosition(0, fila);
                        int resul = num * i;
                        Console.WriteLine($"Multiplos:{resul}");
                        fila++;
                        Thread.Sleep(300);

                        if (i > 50)
                        {
                            running = false;
                        }


                    }

                }


            }
        }

        static void primos(object num)
        {
            int limite = (int)num;
            int fila = 0;
            int numero = 2;

            while (running)
            {
                lock (l)
                {
                    if (running)
                    {

                        bool esPrimo = true;
                        for (int i = 2; i * i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                esPrimo = false;
                            }
                        }
                        if (esPrimo)
                        {
                            fila++;
                            Console.SetCursorPosition(90, fila);
                            Console.WriteLine($"Primos:{numero}");
                            Thread.Sleep(200);

                        }
                        numero++;
                        if (numero >= limite)
                        {
                            running = false;
                        }
                    }

                }

            }


        }




    }
}