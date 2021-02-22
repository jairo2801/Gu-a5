using System;

namespace Ejercicio1
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            int numero;
            Console.WriteLine("Bienvenido en esta aplicación usted podrá consultar la tabla de multiplicar del número que usted desee");
            Console.WriteLine("Por favor ingresar el número que desea consultar:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("La tabla de multiplicar del número "+numero+" es:");
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));//se dice que por cada número se hará la multiplicación del 0 al 10
            }
            Console.ReadKey();
        }
    }
}
