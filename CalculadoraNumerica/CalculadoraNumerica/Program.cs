using System;

namespace CalculadoraNumerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Ingrese el primer numero");
            number1 =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2;
            Console.WriteLine(result);

        }
    }
}
