using System;
using System.Globalization;

namespace Exer6
{
    /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
       mostre:
       a) a área do triângulo retângulo que tem A por base e C por altura (Base*Altura/2).
       b) a área do círculo de raio C. (pi = 3.14159)
       c) a área do trapézio que tem A e B por bases e C por altura.
       d) a área do quadrado que tem lado B.
       e) a área do retângulo que tem lados A e B.*/
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("Digite o Valor de A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor de B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor de C:");
            C = double.Parse(Console.ReadLine());


            double AreaTrianguloRetangulo = (A * C) / 2;
            double AreaCirculoRaio = Math.Pow(C, 2.0) * 3.14159;
            double AreaTrapezio = ((A + B) * (C)) / 2;
            double AreaQuadrado = B * B;
            double AreaRetangulo = A * B;


            Console.WriteLine("Área do Triangulo Retangulo = "+AreaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Circulo do Raio = "+AreaCirculoRaio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("área do Trapezio = "+AreaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Quadrado = "+AreaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Retangulo = "+AreaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
