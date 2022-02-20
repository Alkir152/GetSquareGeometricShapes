using System;
using GetSquare;

namespace GetSquareGeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(rad);
            circle.GetSquare();

            double[] array = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Введите длину стороны {i}: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Triangle triangle = new Triangle(array[0], array[1], array[2]);
            triangle.GetSquare();
        }
    }
}
