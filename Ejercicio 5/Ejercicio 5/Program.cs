using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            
            int length = 30;
            int l = 1;

            for (int z = 0; z < l; z++)
            {
                
                    Console.WriteLine("\nImpresion de numeros del 1 al 30.");
                    

                    for (int i = 1; i <= length; i++)
                    {
                        if (i != 25)
                        {
                            Console.WriteLine("\nNumero {0}.", i);
                        }
                        else
                        {
                            Console.WriteLine("\nNumero no permitido!!!!!!!");
                        }

                    }               

                }
                

            }

            Console.ReadKey();
        }
    }
}
