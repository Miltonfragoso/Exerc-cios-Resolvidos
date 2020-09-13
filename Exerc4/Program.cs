using System;

namespace Exerc4
{
    /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
      hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
      decimais.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número do funcionario:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("número de Horas Trabalhadas:");
            int NHT = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor Por Horas Trabaladas:");
            double VHT = double.Parse(Console.ReadLine());

            double Salario = NHT * VHT;
            Console.WriteLine("Funcionario de Número: "+N);
            Console.WriteLine("Receberá = "+Salario.ToString("F2"));
        }
    }
}
