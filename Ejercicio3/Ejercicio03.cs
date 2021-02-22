using System;

namespace Ejercicio3
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            int n;
            int equilatero = 0;
            int isosceles = 0;
            int escaleno = 0;
            Console.WriteLine("Bienvenido, en esste programa usted podrá ingresar la cantidad de triángulos que desee y dependiendo de sus lados, el programa los clasificará por tríangulo equilátero, isócsceles o escaleno");
            Console.WriteLine("Por favor ingrese la cantidad de triángulos:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Double l1, l2, l3;
                Console.WriteLine("Por favor digite el valor del primer lado");
                l1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite el valor del segundo lado");
                l2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite el valor del tercer lado");
                l3 = Double.Parse(Console.ReadLine());
                //Se hace la clasificación de los triángulos
                if (l1==l2 && l1==l3 && l2==l3)
                {
                    Console.WriteLine("El triángulo ingresado es un triángulo equilátero, ya que todas sus lados son iguales");
                    equilatero++;
                }
                else if (l1==l2 && l1!=l3 || l1==l3 && l1!=l2|| l2==l1 && l2!=l3|| l2==l3 && l2!=l1)
                {
                    Console.WriteLine("El triángulo ingresado es un triángulo isósceles, ya que solo 2 de sus lados son iguales");
                    isosceles++;
                }
                else if (l1!=l2 && l1!=l3 || l2!=l1 && l2!=l3 || l3!=l1 && l3!=l2)
                {
                    Console.WriteLine("El triángulo ingresado es un triángulo escaleno, ya que ninguno de sus lados son iguales");
                    escaleno++;
                }
            }
            //Se hace el conteo de tipos de triángulos
            if (escaleno>0)
            {
                Console.WriteLine("Usted ha ingresado "+escaleno+" triángulos escalenos");
            }
            if (equilatero>0)
            {
                Console.WriteLine("Usted ha ingresado "+equilatero+" triángulos equiláteros");
            }
            if (isosceles > 0)
            {
                Console.WriteLine("Usted ha ingresado "+isosceles+" triángulos isósceles");
            }
            //Se hace la evaluación de cual es el triángulo que se ha ingresado en menor cantidad
            if (equilatero<escaleno && equilatero<isosceles )
            {
                Console.WriteLine("El triángulo equilátero es el que se ha ingresado en menor cantidad");
            }
            else if (escaleno<equilatero && escaleno<isosceles)
            {
                Console.WriteLine("El triángulo escaleno es el que se ha ingresado en menor cantidad");
            }
            else if (isosceles<escaleno && isosceles<equilatero) 
            {
                Console.WriteLine("EL triángulo isósceles es el que se ha ingresado en menor cantidad");
            }
            else if (equilatero==escaleno && equilatero== isosceles)
            {
                Console.WriteLine("Todos los triángulos se ingresaron en la misma cantidad");
            }
            else if (equilatero==escaleno && equilatero<isosceles)
            {
                Console.WriteLine("Los triángulos equilátero y escaleno son los que se han ingresado en menor cantidad");
            }
            else if (equilatero==isosceles && equilatero<escaleno)
            {
                Console.WriteLine("Los triángulos equilátero e isósceles son los que se han ingresado en menor cantidad");
            }
            else if (isosceles==escaleno&& isosceles<equilatero)
            {
                Console.WriteLine("Los triángulos isóceles y escaleno son los que se han ingresado en menor cantidad");
            }
        }
    }
}
