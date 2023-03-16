using System;

namespace zadania
{
    class zad3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while (n > 0)
            {
                n -= i;
                i++;
            }

            if (n == 0)
            {
                Console.WriteLine("Podana liczba jest liczbą trójkątną.");
            }
            else
            {
                Console.WriteLine("Podana liczba nie jest liczbą trójkątną.");
            }

        }
    }
}
