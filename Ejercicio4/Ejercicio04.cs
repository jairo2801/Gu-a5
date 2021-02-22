using System;

namespace Ejercicio4
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            int numero,multi15,division2;
            int negativo = 0;
            int positivo = 0;
            int multiplo15 = 0;
            int pares = 0;
            Console.WriteLine("Bienvenido en este programa usted tendrá que digitar 10 números, los cuales el programa los clasificará por si son números negativos o positivos, si son números pares o múltiplos de 15");
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Por favor digite un número:");
                numero = int.Parse(Console.ReadLine());
                multi15 = numero % 15;//Se hace la división entre 15 para saber si el número es múltiplo de 15
                division2 = numero % 2;//se hace la división entre 2 para saber si el núemro es par
                if (numero<0)//Se define si el número es negativo
                {
                    negativo++;
                }
                if (numero > 0)//Se define si el número es positivo
                {
                    positivo++;
                }
                if (multi15==0)//Se define si el número es múltiplo de 15
                {
                    multiplo15++;
                }
                if (division2==0)//Se define si el número es par
                {
                    pares++;
                }
            }
            Console.WriteLine("La cantidad de números positivos son: "+positivo);
            Console.WriteLine("La cantidad de números negativos son: "+negativo);
            Console.WriteLine("La cantidad de números múltiplos de 15 son: "+multiplo15);
            Console.WriteLine("La cantidadd de números pares son: "+pares);
            Console.ReadKey();
        }
    }
}
