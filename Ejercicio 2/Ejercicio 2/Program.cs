using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            int x, y;
            int po = 0;
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int length;
            int l = 1;

            for (int z = 0; z < l; z++)
            {
                try
                {
                    Console.WriteLine("\nDigite la cantidad de pares de puntos a procesar.");
                    //Entrada de datos repeticion for = length.
                    length = Int32.Parse(Console.ReadLine());

                    for (int i = 1; i <= length; i++)
                    {
                        Console.WriteLine("\nPar ordenado # {0}.", i);
                        Console.WriteLine("\nDigite el punto en x.");
                        //Entrada de datos num1.
                        x = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("\nDigite el punto en y.");
                        //Entrada de datos num1.
                        y = Int32.Parse(Console.ReadLine());

                        //Punto de origen
                        if (x == 0 && y == 0)
                        {
                            Console.WriteLine($" \nEl Punto:({x},{y}). Pertenece al punto de origen.");
                            po++;
                        }
                        //Cuadrante 1
                        else if (x > 0 && y > 0)
                        {
                            Console.WriteLine($" \nEl Punto:({x},{y}). Pertenece al cuadrante I.");
                            c1++;
                        }
                        //Cuadrante 2
                        else if (x < 0 && y > 0)
                        {
                            Console.WriteLine($" \nEl Punto:({x},{y}). Pertenece al cuadrante II.");
                            c2++;
                        }
                        //Cuadrante 3
                        else if (x < 0 && y < 0)
                        {
                            Console.WriteLine($" \nEl Punto:({x},{y}). Pertenece al cuadrante III.");
                            c3++;
                        }
                        //Cuadrante 4
                        else if (x > 0 && y < 0)
                        {
                            Console.WriteLine($" \nEl Punto:({x},{y}). Pertenece al cuadrante IV.");
                            c4++;
                        }


                    }
                    Console.WriteLine($" \n\nSe han ingresado {c1} puntos en el cuadrante I.");
                    Console.WriteLine($" Se han ingresado {c2} puntos en el cuadrante II.");
                    Console.WriteLine($" Se han ingresado {c3} puntos en el cuadrante III.");
                    Console.WriteLine($" Se han ingresado {c4} puntos en el cuadrante IV.");
                    Console.WriteLine($" Se han ingresado {po} puntos en el punto de origen (0,0).");
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
