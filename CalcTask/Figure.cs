using System;

namespace CalcTask
{
    public abstract class Figure
    {
        public abstract string FigureName();
        public abstract string Area();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {FigureName()}\n" +
                $"Площадь: {Area()}\n"
                );
            Console.WriteLine();
        }
        public class Triangle : Figure
        {
            double sideA, sideB, sideC;   // стороны 
            public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
            {
                sideA = triangleSideA;
                sideB = triangleSideB;
                sideC = triangleSideC;
            }
            // вычисление площади 
            public override string Area()
            {
                double semPer = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
            }
            //возврат названия
            public override string FigureName()
            {
                return "Треугольник";
            }
        }
        public class Circle : Figure
        {
            int radius;
            public Circle(int rad)
            {
                radius = rad;
            }
            public override string Area()
            {
                double Circuit = 2.0 * Math.PI * radius;
                return Circuit.ToString();
            }
            public override string FigureName()
            {
                return "Круг";
            }
        }
    }
}
