using System;

namespace Tipo_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1 ,lado2 ,lado3;

            Console.WriteLine("Informe o primeiro lado do triangulo");
            lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo lado do triangulo");
            lado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro lado do triangulo");
            lado3 = double.Parse(Console.ReadLine());



            if((lado1 == lado2) && (lado3 == lado1))
            {
                Console.WriteLine("Esse Triangulo é um equilátero");
            }
            else
            {
                if((lado1 == lado2) || (lado3 == lado1) || (lado3 == lado2))
                {
                    Console.WriteLine("Esse triangulo é um Isósceles");
                }
                else
                {
                    Console.WriteLine("Esse Triangulo é um Escaleno");

                }
            }


            Console.ReadLine();
        }
    }
}
