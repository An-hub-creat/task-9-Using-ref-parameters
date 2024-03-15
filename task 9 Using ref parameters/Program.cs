using System;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");
            Console.Write("Enter a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            c = double.Parse(Console.ReadLine());

            double x1, x2;

            if (SolveQuadraticEquation(a, b, c, out x1, out x2))
            {
                Console.WriteLine($"Roots: x1 = {x1}, x2 = {x2}");
            }
            else
            {
                Console.WriteLine("No real roots exist for the given coefficients.");
            }
        }

        static bool SolveQuadraticEquation(double a, double b, double c, out double x1, out double x2)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                x1 = x2 = double.NaN; // Set roots to NaN (Not a Number) if they are imaginary
                return false;
            }
            else if (discriminant == 0)
            {
                x1 = x2 = -b / (2 * a); // Equal roots
                return true;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return true;
            }
        }
    }
}