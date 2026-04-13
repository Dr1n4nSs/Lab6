using System;
namespace ConsoleApp4;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите параметры первого треугольника: ");
        double a = Triangle.ReadDouble();
        double b = Triangle.ReadDouble();
        double c = Triangle.ReadDouble();
        Triangle t1 = new Triangle(a, b, c);
        Console.WriteLine("Введите параметры второго треугольника: ");
        a = Triangle.ReadDouble();
        b = Triangle.ReadDouble();
        c = Triangle.ReadDouble();
        Triangle t2 = new Triangle(a, b, c);
        
        bool exists1 = (bool)t1;
        bool exists2 = (bool)t2;

        Console.WriteLine("Треугольник 1 существует: " + exists1);
        Console.WriteLine("Треугольник 2 существует: " + exists2);
        
        double area1 = -t1;
        double area2 = -t2;

        Console.WriteLine("Площадь t1: " + area1);
        Console.WriteLine("Площадь t2: " + area2);
        double areaFromImplicit = t1;
        Console.WriteLine("Площадь t1 (неявное приведение): " + areaFromImplicit);
        
        bool isLess = t1 < t2;
        bool isGreater = t1 > t2;

        Console.WriteLine("Площадь t1 < площади t2: " + isLess);
        Console.WriteLine("Площадь t1 > площади t2: " + isGreater);
    }
}