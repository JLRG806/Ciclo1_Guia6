using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            int l1,l2,l3;
            
            int equi = 0;
            int iso = 0;
            int esca = 0;
           
            int length;
            int l = 1;

            for (int z = 0; z < l; z++)
            {
                try
                {
                    Console.WriteLine("\nDigite la cantidad de triangulos.");
                    //Entrada de datos repeticion for = length.
                    length = Int32.Parse(Console.ReadLine());

                    for (int i = 1; i <= length; i++)
                    {
                        Console.WriteLine("\nTriangulo # {0}.", i);
                        Console.WriteLine("\nDigite el lado 1.");
                        //Entrada de datos num1.
                        l1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("\nDigite el lado 2.");
                        //Entrada de datos num1.
                        l2 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("\nDigite el lado 3.");
                        //Entrada de datos num1.
                        l3 = Int32.Parse(Console.ReadLine());

                        //Exepción
                        if (l1 <= 0 || l2 <= 0 || l3 <= 0)
                        {
                            Console.WriteLine($" \nIngrese numeros validos positivos y desde 1.");
                            i--;
                        }
                        //Equilátero ( tres lados iguales)
                        else if (l1 == l2 && l2 == l3)
                        {
                            Console.WriteLine($" \nEl triangulo #{i} es un tríangulo Equilátero ( tres lados iguales).");
                            equi++;
                        }
                        // isósceles ( dos lados iguales)
                        else if (l1 == l2 || l1== l3 || l2 == l3)
                        {
                            Console.WriteLine($" \nEl triangulo #{i} es un tríangulo Isósceles ( dos lados iguales).");
                            iso++;
                        }
                        //escaleno (ningún lado igual)
                        else if (l1 != l2 && l1 != l3 && l2 != l3)
                        {
                            Console.WriteLine($" \nEl triangulo #{i} es un tríangulo Escaleno (ningún lado igual).");
                            esca++;
                        }
                        


                    }
                    Console.WriteLine($" \n\nSe han ingresado {iso} triangulos Isósceles (dos lados iguales).");
                    Console.WriteLine($" Se han ingresado {equi} triangulos Equiláteros (tres lados iguales).");
                    Console.WriteLine($" Se han ingresado {esca} triangulos Escaleno (ningún lado igual).");

                    if (equi < iso && equi < esca)
                    {
                        Console.WriteLine($" \n\nTriangulos Equiláteros ( tres lados iguales) es la menor cantidad.");
                        
                    }
                    else
                    {
                        if (iso < esca)
                        {
                            Console.WriteLine($" \n\nTriangulos Isósceles ( dos lados iguales) es la menor cantidad.");
                        }
                        else
                        {
                            Console.WriteLine($" \n\nTriangulos Escalenos (ningún lado igual) es la menor cantidad.");
                        }
                    }
                       

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

