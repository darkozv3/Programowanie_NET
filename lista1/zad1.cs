using System;

namespace zadania
{
    class Program
    {
        static bool czyPierwsza(int liczba)
        {
            if (liczba % 2 == 0)
                return (liczba == 2);
            for (int i = 3; i <= Math.Sqrt(liczba); i += 2)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe: ");
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba {0} {1}jest pierwsza", liczba, (czyPierwsza(liczba) ? "" : "nie "));
        }
    }
}
