using System;

namespace prueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int proyecto, examen,tarea;
            double promedio;

            Console.WriteLine("Escribe el nombre del alumno");
            nombre = Console.ReadLine();

            Console.WriteLine("Escribe la calificacion del proyecto");
            proyecto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe la calificacion del examen");
            examen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe la calificacion de la tarea");
            tarea = Convert.ToInt32(Console.ReadLine());

            promedio = (proyecto * 0.55) + (examen * 0.30) + (tarea * 0.15);

            Console.WriteLine("El promedio del alumno " + nombre + " es: " + promedio);
        }
    }
}
