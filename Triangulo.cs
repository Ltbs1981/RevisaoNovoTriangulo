namespace RevisaoNovoTriangulo
{
    public class Triangulo
    {
        // Definindo os membros da classe
        public double lado1;
        public double lado2;
        public double lado3;

        // Método para calcular a área do triângulo
        public double CalcularArea()
        {
            double perimetro = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - lado1) * (perimetro - lado2) * (perimetro - lado3));

            return area;
        }
    }
}
