using System;

namespace ConsoleApp12
{
    class Program
    {
        static void F1(double a, double b, double S)
        {
            double r;
            double w = a;
            Console.WriteLine("sin(x)/x:");
            while (w<= b) {
                r = Math.Sin(w) / w;
                Console.WriteLine($"Значение {w}:");
                Console.WriteLine(r);
                w = w + S;
            }
        }
        static void F2(double a, double b, double S, double f, double g, double h) 
        {
            double r;
            double w = a;
            Console.WriteLine("a*x^2+b*x+c");
            while (w <= b)
            {
                r = f*w*w+g*w+h;
                Console.WriteLine($"Значение {w}:");
                Console.WriteLine(r);
                w = w + S;
            }
        }
        static void F3(double a, double b, double S, double r, double t, double y)
        {
            double o;
            double w = a;
            Console.WriteLine("a*sin(2*(pi)*(f0)*x + x(phi0))");
            while (w <= b)
            {
                o = r* Math.Sin(2*(Math.PI)*t*w + w*y);
                Console.WriteLine($"Значение {w}:");
                Console.WriteLine(o);
                w = w + S;
            }
        }
        static void Main(string[] args)
        {
            double a; double b; double S;
            Console.WriteLine("Введи область:");
            Console.WriteLine("ot ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("do ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Шаг ");
            S = Convert.ToDouble(Console.ReadLine());
            F1(a, b, S);
            Console.WriteLine("a*x^2+b*x+c-Введите доп.данные а,b,c");
            double f; double g; double h;
            f = Convert.ToDouble(Console.ReadLine());
            g = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            F2(a, b, S, f, g, h);
            Console.WriteLine("a*sin(2*(pi)*(f0)*x + x(phi0))-Введите доп.данные а,f0,phi0");
            double r; double t; double y;
            r = Convert.ToDouble(Console.ReadLine());
            t = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            F3(a, b, S, r, t, y);

        }
    }
}
