using System;

namespace Ejercicio2
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("Bienvenido, en este programa usted podrá poner una cantidad de pares (x,y) y el programa le dirá en qué cuadrante del plano cartesiano se encuentran");
            int pares;
            Console.WriteLine("Por favor ingrese la cantidad de pares que ingresará:");
            pares = int.Parse(Console.ReadLine());
            for (int i = 1; i <=pares; i++)
            {
                Double x, y;
                Console.WriteLine("Ingresar el valor de la coordenada de X");
                x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar el valor de la coordenada de Y");
                y = Double.Parse(Console.ReadLine());
                if (x>0 && y>0)//se evalúa si la coordenada queda en el cuadrante 1
                {
                    Console.WriteLine("Los puntos de la coordenata ("+x+","+y+") se ubican en el cuadrante 1");
                }
                else if (x<0 && y>0)//se evalúa si la coordenada queda en el cuadrante 2
                {
                    Console.WriteLine("Los puntos de la coordenata (" + x + "," + y + ") se ubican en el cuadrante 2");
                }
                else if (x<0 && y<0)//se evalúa si la coordenada queda en el cuadrante 3
                {
                    Console.WriteLine("Los puntos de la coordenata (" + x + "," + y + ") se ubican en el cuadrante 3");
                }
                else if (x>0 && y<0)//se evalúa si la coordenada queda en el cuadrante 4
                {
                    Console.WriteLine("Los puntos de la coordenata (" + x + "," + y + ") se ubican en el cuadrante 4");
                }
            }
            Console.ReadKey();
        }
    }
}
