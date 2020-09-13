using System;

namespace Exer2
{
    /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais.
       Fórmula da área: area = π . raio2
       Considere o valor de π = 3.14159*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do Raio:");
            double R = Double.Parse(Console.ReadLine());

            double Area = (Math.Pow(R, 2.0)) * 3.14159;
            Console.WriteLine("Área =" + Area.ToString("F4"));
        }
    }
}
