namespace ConsoleApp4;

public class Triangle
{
    private double a;
    private double b;
    private double c;
    
    public Triangle(double a, double b, double c)
    {
        this.A = a;
        this.B = b;
        this.C = c;
    }
    
    public double A
    {
        get { return a; }
        set
        {
            if (value > 0)
            {
                a = value;
            }
            else
            {
                Console.WriteLine("Введённое значение не можнт быть стороной треугольника");
            }
        }
    }
    
    public double B
    {
        get { return b; }
        set
        {
            if (value > 0)
            {
                b = value;
            }
            else
            {
                Console.WriteLine("Введённое значение не можнт быть стороной треугольника");
            }
        }
    }
    
    public double C
    {
        get { return c; }
        set
        {
            if (value > 0)
            {
                c = value;
            }
            else
            {
                Console.WriteLine("Введённое значение не можнт быть стороной треугольника");
            }
        }
    }
    
    public bool Exists()
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
    
    public static double ReadDouble()
    {
        double value;
        while (!(double.TryParse(Console.ReadLine(), out value)))
        {
                Console.WriteLine("Введённые даннае не являются числом, введите число ещё раз");
        }
        return value;
    }
    
    public double GetArea()
    {
        if (!Exists())
        {
            return 0;
        }

        double p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    

    public static double operator - (Triangle triangle)
    {
        return triangle.GetArea();
    }


    // Неявное приведение к double 
    public static implicit operator double (Triangle triangle)
    {
        return triangle.GetArea();
    }
    
    // Явное приведение к bool
    public static explicit operator bool (Triangle triangle)
    {
        return triangle.Exists();
    }
    
    public static bool operator < (Triangle t1, Triangle t2)
    {
        return t1.GetArea() < t2.GetArea();
    }
    
    public static bool operator > (Triangle t1, Triangle t2)
    {
        return t1.GetArea() > t2.GetArea();
    }
}