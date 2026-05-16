namespace Ejercicio_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = { 5, 2, 8, 1, 9, 4 };
            string[] palabras = { "Sol", "Luna", "Estrella", "Cielo" };

            //Saber de si hay algún aprobado (Si existe o no) en notas.
            bool existeAprobado = Array.Exists(notas, a => a >= 5);
            Console.WriteLine($"Existe algun aprobado?: {existeAprobado}");

            //Mostrar los aprobados de notas.
            int[] aprobados = Array.FindAll(notas, a => a >= 5);
            Array.ForEach(aprobados, a => { Console.WriteLine(a); });

            // Indicar la posición en el array del último aprobado
            int posUltAprobado =Array.FindLastIndex(notas, a => a >= 5);
            Console.WriteLine($"Posicion array ultimo aprobado: {posUltAprobado}");

            //Mostrar la nota del último aprobado.
            int notaUltAprobado =Array.FindLast(notas, a => a >= 5);
            Console.WriteLine($"Nota Ultimo aprobado: {notaUltAprobado}");

            //Cuanto tienen nota par.
            int pares = notas.Count(a => a >= 5);
            Console.WriteLine($"Notas pares: {pares}");


            //Cual es la primera palabra de más de 3 caracteres.
            string longitud = Array.Find(palabras, a => a.Length > 3);
            Console.WriteLine(longitud);

            //Mostrar todas las palabras en mayúsculas.
            Array.ForEach(palabras, a => { Console.WriteLine(a.ToUpper()); });

            //Indica la posición de la primera palabra que empiece por E.
            int primeraPos = Array.FindIndex(palabras, a => a.StartsWith("E"));
            Console.WriteLine("Posicion array primera palabra letra E: " + primeraPos);
         
        }
    }
}
