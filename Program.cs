using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static int opcion;
        static void Main(string[] args)
        {
            bool salir = false;
            while(salir == false)
            {
                do
                {
                    Menu();
                    opcion = Leer.DatoInt();
                } while (opcion < 1 && opcion > 5);
                switch (opcion)
                {
                    case 1:
                        //sumar
                        int n1, n2;
                        Console.WriteLine("\tREALIZANDO SUMA..."); 
                        Console.Write("Ingrese el primer número: ");
                        n1 = Leer.DatoInt();
                        Console.Write("Ingrese el segundo número: ");
                        n2 = Leer.DatoInt();
                        Console.WriteLine("El resultado de la suma es: {0}", Calculadora<int, int>(n1, n2));  
                        break;
                    case 2:
                        //restar
                        int n3, n4;
                        Console.WriteLine("\tREALIZANDO RESTA...");
                        Console.Write("Ingrese el primer número: ");
                        n3 = Leer.DatoInt();
                        Console.Write("Ingrese el segundo número: ");
                        n4 = Leer.DatoInt();
                        Console.WriteLine("El resultado de la resta es: {0}", Calculadora<int, int>(n3, n4));
                        break;
                    case 3:
                        //multiplicar
                        int n5, n6;
                        Console.WriteLine("\tREALIZANDO MULTIPLICACIÓN...");
                        Console.Write("Ingrese el primer número: ");
                        n5 = Leer.DatoInt();
                        Console.Write("Ingrese el segundo número: ");
                        n6 = Leer.DatoInt();
                        Console.WriteLine("El resultado de la multiplicacion es: {0}", Calculadora<int, long>(n5, n6));
                        break;
                    case 4:
                        //dividir
                        float n7, n8;
                        Console.WriteLine("\tREALIZANDO DIVISION...");
                        Console.Write("Ingrese el primer número: ");
                        n7 = Leer.DatoInt();
                        Console.Write("Ingrese el segundo número: ");
                        n8 = Leer.DatoInt();
                        Console.WriteLine("El resultado de la division es: {0}", Calculadora<float, float>(n7, n8));
                        break;
                    case 5:
                        salir = true;
                        break;
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("\tMENU DE OPERACIONES");
            Console.WriteLine("1-> Sumar");
            Console.WriteLine("2-> Restar");
            Console.WriteLine("3-> Multiplicar");
            Console.WriteLine("4-> Dividir");
            Console.WriteLine("5-> Salir");
            Console.Write("Opción-> ");
        }
        static R Calculadora<T, R>(dynamic numero1, dynamic numero2)
        {
            if (opcion == 1)
            {
                return numero1 + numero2;
            } else if (opcion == 2)
            {
                return numero1 - numero2;
            } else if (opcion == 3)
            {
                return numero1 * numero2;
            }
            else
            {
                return numero1 / numero2;
            }
        }
    }
}
