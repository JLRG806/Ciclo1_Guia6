using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            int num;
            int n = 0, p = 0, m15 = 0, np = 0,cp = 0;
            int length = 10;
            int l = 1;

            for (int z = 0; z < l; z++)
            {
                try
                {
                    
                    for (int i = 1; i <= length; i++)
                    {
                        Console.WriteLine("\nNumero {0}.", i);
                        Console.WriteLine("\nDigite el numero.");
                        //Entrada de datos num1.
                        num = Int32.Parse(Console.ReadLine());                        

                        //Exepción
                        if (num < 0)
                        {
                            Console.WriteLine(" \n\tNumero {0} Es Negativo", num);
                            n++;
                        }
                        //Equilátero ( tres lados iguales)
                         if (num >= 0)
                        {
                            Console.WriteLine(" \n\tNumero {0} Es Positivo", num);
                            p++;
                        }
                        // isósceles ( dos lados iguales)
                        if ((num % 15) == 0)
                        {
                            Console.WriteLine(" \n\tNumero {0} Es multiplo de 15", num);
                            m15++;
                        }
                        //escaleno (ningún lado igual)
                        if ((num % 2) == 0)
                        {
                            cp = cp + num;
                            Console.WriteLine(" \n\tNumero {0} Es numero par", num);
                            np++;
                        }

                    }
                    Console.WriteLine($" \n\nSe han ingresado {n} numeros negativos.");
                    Console.WriteLine($" Se han ingresado {p} numeros positivos.");
                    Console.WriteLine($" Se han ingresado {m15} numeros multiplos de 15.");
                    Console.WriteLine($" Se han ingresado {np} numeros pares.");
                    Console.WriteLine($" El valor acumulado de numeros pares es de {cp}.");



                }
                catch (Exception)
                {
                    l++;
                    Console.WriteLine($" \n\nPor favor ingrese un numero sin decimales");

                }

            }

            Console.ReadKey();
        }
    }
}
