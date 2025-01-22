using System;

namespace prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            double longitud1, longitud2, longitud3, perimetro, area; 

            Console.WriteLine("Escribe la primera longitud del triangulo");
            longitud1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe la segunda longitud del triangulo");
            longitud2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe la tercera longitud del triangulo");
            longitud3 = Convert.ToDouble(Console.ReadLine());

            perimetro = ((longitud1 + longitud2 + longitud3)/2);

            area = Math.Sqrt(perimetro * (perimetro - longitud1) * (perimetro - longitud2) * (perimetro - longitud3));

            Console.WriteLine("El area del triangulo es: " + area);
        }
    }
}

