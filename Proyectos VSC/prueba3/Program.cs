using System;

namespace prueba3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Escribe un numero entero");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                resultado = numero * 2;
                Console.WriteLine("El resultado del numero es: " + resultado);
            }
            else
            {
                Console.WriteLine("Escribe un numero entero, el que agregaste parece no ser correcto");
            }
        }
    }
}
