// Интерфейс для фигуры и определения метода, для вычисления площади.
public interface IShape
{
    double GetArea();
}

// Классы реализующие интерфейс выше.
public class Circle : IShape
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Triangle : IShape
{
    private readonly double sideA;
    private readonly double sideB;
    private readonly double sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public double GetArea()
    {
        // Используем формулу Герона для вычисления площади треугольника
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
    }

    public bool IsRightAngledTriangle()
    {
        // Проверяем, является ли треугольник прямоугольным
        double[] sides = { sideA, sideB, sideC };
        Array.Sort(sides);

        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }
}
// Класс, который будет предоставлять пользователю методы для вычисления площадей фигур без знания их типа в compile-time
public static class ShapeCalculator
{
    public static double GetArea(IShape shape)
    {
        return shape.GetArea();
    }
}

