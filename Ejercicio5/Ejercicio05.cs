using System;

namespace Ejercicio5
{
    class Ejercicio05
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("En este programa se imprimirán en pantalla los números del 1 al 30 exceptuando el 25 \n");
            for (int i = 1; i<=30; i++)//se establece que solo se mostrarán números del 1 al 30
            {
                int numero = i;
                if (numero<25 || numero>25)//acá es donde se hace la excepción del número 25 diciendole si el número es mayo o menos a 25 que se imprima
                {
                    Console.WriteLine(numero);
                }
                
            }
            Console.ReadKey();    
        }
    }
}
