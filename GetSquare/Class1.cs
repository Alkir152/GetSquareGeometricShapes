using System;

namespace GetSquare
{
    public class Circle
    {
        double result;
        public Circle(double rad)
        {
            if (rad <= 0)
                result = 0;
            else
                result = Math.PI * Math.Pow(rad, 2);
        }
        public void GetSquare()
        {
            Console.WriteLine(result);
        }
    }

    public class Triangle
    {
        double result;
        public Triangle(double sideA, double sideB, double sideC)
        {
            double sideAPow = Math.Pow(sideA, 2),
                sideBPow = Math.Pow(sideB, 2),
                sideCPow = Math.Pow(sideC, 2);// переменные для проверки на прямоугольный треугольник

            if (sideA <= 0 || sideB <= 0 || sideC <= 0 || sideA + sideB < sideC || sideC + sideB < sideA || sideA + sideC < sideB)
                result = 0;
            else if (sideAPow + sideBPow == sideCPow || sideCPow + sideBPow == sideAPow || sideAPow + sideCPow == sideBPow)
            {
                double[] array = { sideA, sideB, sideC };
                double temp;
                for (int i = 0; i < array.Length; i++)// отсортируем длины сторон в порядке убывания
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                result = (array[1] * array[2]) / 2;
            }
            else
            {
                double perimeter = (sideA + sideB + sideC) / 2;
                result = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
            }
        }
        public void GetSquare()
        {
            Console.WriteLine(result);
        }
    }
}
