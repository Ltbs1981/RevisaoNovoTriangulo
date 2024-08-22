using System;

namespace RevisaoNovoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo primeiroTriangulo = new Triangulo();
            primeiroTriangulo.lado1 = 5.55;
            primeiroTriangulo.lado2 = 7.77;
            primeiroTriangulo.lado3 = 3.33;

            double areaPrimeiroTriangulo = primeiroTriangulo.CalcularArea();

            Triangulo segundoTriangulo = new Triangulo();
            segundoTriangulo.lado1 = 4.44;
            segundoTriangulo.lado2 = 6.66;
            segundoTriangulo.lado3 = 8.88;

            double areaSegundoTriangulo = segundoTriangulo.CalcularArea();

            Console.WriteLine($"O primeiro Triângulo tem a área de: {areaPrimeiroTriangulo}");
            Console.WriteLine($"O segundo Triângulo tem a área de: {areaSegundoTriangulo}");

            if (areaPrimeiroTriangulo > areaSegundoTriangulo)
            {
                Console.WriteLine("O primeiro triângulo é maior que o segundo.");
            }
            else if (areaPrimeiroTriangulo < areaSegundoTriangulo)
            {
                Console.WriteLine("O segundo triângulo é maior que o primeiro.");
            }
            else
            {
                Console.WriteLine("Os dois triângulos têm a mesma área.");
            }

        }
    }
}
