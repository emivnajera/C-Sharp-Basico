using System;

namespace LeerDatosUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el lado a");
            float sideA =float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el lado b");
            float sideB =float.Parse(Console.ReadLine());

            float area = sideA * sideB;

            Console.WriteLine(area);
           
        }
    }
}
