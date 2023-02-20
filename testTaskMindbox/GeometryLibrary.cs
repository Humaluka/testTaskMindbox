namespace testTaskMindbox
{
    public static class Geometry
        {
            // Вычислить площадь круга по радиусу
            public static double CircleArea(double radius)
            {
                if (radius <= 0)
                {
                    throw new ArgumentException("Радиус должен быть больше 0");
                }

                return Math.PI * radius * radius;
            }

            // Вычислить площадь треугольника по трём сторонам
            public static double TriangleArea(double side1, double side2, double side3)
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new ArgumentException("Стороны должны быть больше 0");
                }

                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }

            // Проверка является ли треугольник прямоугольным
            public static bool IsRightTriangle(double side1, double side2, double side3)
            {
                double[] sides = { side1, side2, side3 };
                Array.Sort(sides);

                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
            }

            // Вычисление площади фигуры без знания типа фигуры в compile-time
            public static double CalculateArea(dynamic shape)
            {
                if (shape is Circle)
                {
                    return CircleArea(shape.Radius);
                }
                else if (shape is Triangle)
                {
                    return TriangleArea(shape.Side1, shape.Side2, shape.Side3);
                }
                else
                {
                    throw new ArgumentException("Неподдерживаемый тип фигуры.");
                }
            }

            // Легкое добавление других фигур с помощью интерфейса
            public interface IShape
            {
                public double Area();
            }

            public class Circle : IShape
            {
                public double Radius { get; set; }

                public Circle(double radius)
                {
                    Radius = radius;
                }

                public double Area()
                {
                    return CircleArea(Radius);
                }
            }

            public class Triangle : IShape
            {
                public double Side1 { get; set; }
                public double Side2 { get; set; }
                public double Side3 { get; set; }

                public Triangle(double side1, double side2, double side3)
                {
                    Side1 = side1;
                    Side2 = side2;
                    Side3 = side3;
                }

                public double Area()
                {
                    return TriangleArea(Side1, Side2, Side3);
                }

                public bool IsRightTriangle()
                {
                    return Geometry.IsRightTriangle(Side1, Side2, Side3);
                }
            }
        }

}
