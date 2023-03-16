using System;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczający pierwiastek n-tego stopnia z liczby K");

            Console.Write("Podaj wartość K: ");
            double K = double.Parse(Console.ReadLine());

            Console.Write("Podaj wartość n: ");
            int n = int.Parse(Console.ReadLine());

            double pierwiastek = Math.Pow(K, 1.0 / n);

            Console.WriteLine($"Pierwiastek {n}-tego stopnia z {K} wynosi: {pierwiastek}");
        }
    }
}
