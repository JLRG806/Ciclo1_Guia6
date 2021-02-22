using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que capture un número desde teclado e 
            //imprima su tabla de multiplicar.
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;

            //Declaración de variables a usar.
            int num,m;

            int length = 0;
            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine("\nDigite el numero de la tabla deseada.");
                //Entrada de datos num.
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\nTabla del {0}", num);
                for (int x = 0; x < 11; x++)
                {
                    m = x * num;
                    
                    Console.WriteLine("\n{0} x {1} = {2}", x,num,m);

                }

            }

            Console.ReadKey();
        }
    }
}
