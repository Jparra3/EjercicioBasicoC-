using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            int creditos;
            int sumCreditos=0;
            double cal;
            double nMateria;
            double sumMateria = 0;
            double tPromedio;
            string res;
            do {
                Console.WriteLine("Ingrese Creditos de la materia");
                creditos = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese calificacion de la materia");
                nMateria = Convert.ToDouble(Console.ReadLine());
                cal = nMateria * creditos;
                sumMateria += cal;
                sumCreditos += creditos;
                Console.WriteLine("Desea ingresar más materias S/N?");
                res = Console.ReadLine();
            } while (res=="s"|| res=="S");
            tPromedio = sumMateria/ sumCreditos;
            Console.WriteLine("la suma de creditos "+sumCreditos);
            Console.WriteLine("la suma de materias "+sumMateria);
            Console.WriteLine("El promedio ponderado "+tPromedio);
            Console.ReadKey();
        }
    }
}
