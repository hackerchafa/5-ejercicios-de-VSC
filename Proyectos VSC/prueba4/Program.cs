using System;

namespace prueba4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0;

            Console.WriteLine("Escribe una serie distintos a 0. Para terminar escribe 0");

            while (true)
            {
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }
                
                Console.WriteLine("El numero ingresado es: " + numero);
                contador++;
            }
            
            Console.WriteLine("El total de numeros ingresados es: " + contador);
        }
    }
}