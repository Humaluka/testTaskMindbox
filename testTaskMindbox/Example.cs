using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTaskMindbox
{
    internal class Example
    {
        static void Main(string[] args)
        { 
            // Создание круга
            double circleRadius = 5;
            var circle = new Geometry.Circle(circleRadius);
            double circleArea = circle.Area(); // Вычисление площади круга
            Console.WriteLine($"Площадь круга с радиусом {circleRadius} = {circle.Area()}");

            // Создание треугольника
            double triangleSide1 = 3;
            double triangleSide2 = 4;
            double triangleSide3 = 5;
            var triangle = new Geometry.Triangle(3, 4, 5);
            double triangleArea = triangle.Area(); // Вычисление площади треугольника
            Console.WriteLine($"Площадь треугольника со сторонами {triangleSide1}, {triangleSide2} и {triangleSide3} = {triangle.Area()}");
            Console.WriteLine($"Треугольник прямоугольный? {triangle.IsRightTriangle()}");

            // Вычисление площади фигуры без знания типа фигуры в compile-time
            dynamic shape = circle;
            double area = Geometry.CalculateArea(shape); // Вычисление площади круга
            Console.WriteLine($"Площадь фигуры без знания типа в compile-time = {Geometry.CalculateArea(shape)}");

            shape = triangle;
            area = Geometry.CalculateArea(shape); // Вычисление площади треугольника
            Console.WriteLine($"Площадь фигуры без знания типа в compile-time = {Geometry.CalculateArea(shape)}");
        }
    }
}
