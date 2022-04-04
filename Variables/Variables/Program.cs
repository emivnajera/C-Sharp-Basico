using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola " + nombre);
        }
    }
}
