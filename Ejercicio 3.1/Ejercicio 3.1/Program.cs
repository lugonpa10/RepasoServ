using System.ComponentModel.Design.Serialization;

namespace Ejercicio_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread hiloMultiplos = new Thread(() => multiplos(5));
            Thread hiloPrimos = new Thread(() => primos(15));
            hiloMultiplos.Start();
            hiloPrimos.Start();
            hiloMultiplos.Join();
            hiloPrimos.Join();

        

        }

        static void multiplos(int num)
        {
            int fila = 0;

            for(int i = 0;i <= 50; i++)
            {
                int resul = num * i;
                Console.SetCursorPosition(0, fila);
                Console.WriteLine($"Multiplos:{resul}");
                fila++;
                Thread.Sleep(300);
            }
        }

        static void primos(object num)
        {
            int limite = (int)num;
            int fila = 0;
            for(int numero = 2; numero<limite; numero++)
            {
                bool esPrimo = true;
                for(int i = 2; i*i <= limite; i++)
                {
                    if(numero% i == 0)
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
            }
        }

       
        
    }
}
