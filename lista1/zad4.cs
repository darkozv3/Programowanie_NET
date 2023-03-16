using System;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c:");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Równanie nie ma rozwiązań.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Równanie ma jeden pierwiastek: x = {0:0.00}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Równanie ma dwa pierwiastki: x1 = {x1:0.00}, x2 = {x2:0.00}");
            }
        }
    }
}
