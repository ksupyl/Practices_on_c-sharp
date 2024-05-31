// See https://aka.ms/new-console-template for more information
using System;

public class MainClass
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        double D = Math.Pow(b, 2) - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("Quadratic equation has no root.");
        }
        else if (D == 0)
        {
            double x0 = -b / (2 * a);
            Console.WriteLine($"Quadratic equation has one root: {x0}.");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Console.WriteLine($"Quadratic equation has two roots: {x1} and {x2}.");
        }
    }
}