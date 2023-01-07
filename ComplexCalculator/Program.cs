using System;
using System.Numerics;

namespace ComplexCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea dos números complejos
            Complex c1 = new Complex(1, 3);
            Complex c2 = new Complex(4, 5);

            // Realiza algunas operaciones con ellos
            Complex sum = c1 + c2;
            Complex difference = c1 - c2;
            Complex product = c1 * c2;
            Complex quotient = c1 / c2;

            // Muestra los resultados
            Console.WriteLine($"{c1} + {c2} = {sum}");
            Console.WriteLine($"{c1} - {c2} = {difference}");
            Console.WriteLine($"{c1} * {c2} = {product}");
            Console.WriteLine($"{c1} / {c2} = {quotient}");
            Console.ReadLine();
        }
       
    }
}
