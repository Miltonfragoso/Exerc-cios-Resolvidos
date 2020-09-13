using System;

namespace Exerc1
{
    class Program
    {
        /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Valor 1:");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Valor 2:");
            int N2 = int.Parse(Console.ReadLine());

            int Soma = N1 + N2;
            Console.WriteLine("SOMA = "+ Soma);
        }
    }
}
