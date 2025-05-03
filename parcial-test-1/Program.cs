using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("------MENU PRINCIPAL------");
            Console.WriteLine("1. Funcion calular Media Aritmetica y la Moda");
            Console.WriteLine("2. Salir del Programa");
            Console.WriteLine("ELIJA UNA OPCIÓN");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: calcularMediaModa(); menu(); break;
                case 2: Console.WriteLine("Usted está saliendo del programa..."); Console.ReadKey(); break;
                default: Console.WriteLine("Ingrese una opcion valida"); Console.ReadKey(); menu(); break;
            }
        }
        static void calcularMediaModa()
        {
            double num1, num2, num3, num4, num5;
            Console.WriteLine("Usted está en la función para calcular la media aritmetica y moda");
            Console.WriteLine("Ingrese cinco numeros ");
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el cuarto numero: ");
            num4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el quinto numero: ");
            num5 = Convert.ToDouble(Console.ReadLine());

            csAritmetica a = new csAritmetica(num1, num2, num3, num4, num5);
            Console.WriteLine("Los numeros ingresados son:");
            Console.WriteLine($"Primer num. : {a.getNumero1()}");
            Console.WriteLine($"Segundo num. : {a.getNumero2()}");
            Console.WriteLine($"Tercer num. : {a.getNumero3()}");
            Console.WriteLine($"Cuarto num. : {a.getNumero4()}");
            Console.WriteLine($"Quinto num. : {a.getNumero5()}");
            Console.WriteLine($"La media aritmetica es: {a.calcularMediaAritmetica()} y la moda es :{a.calcularModa()}");

            Console.ReadKey();
        }
    }
}
