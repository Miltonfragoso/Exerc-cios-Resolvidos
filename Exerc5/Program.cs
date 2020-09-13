using System;
using System.Globalization;

namespace Exerc5
{
    /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
       código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Código da peça 1: ");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero  de peças 1: ");
            int QP1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada peça");
            double VP1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o Código da peça 2: ");
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero  de peças 2: ");
            int QP2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada peça");
            double VP2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double VTP1 = QP1 * VP1;
            double VTP2 = QP2 * VP2;
            double VTP = VTP1 + VTP2;
            Console.WriteLine("VALOR A PAGAR = "+VTP.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
