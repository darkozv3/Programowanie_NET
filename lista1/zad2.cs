using System;

namespace zadania
{
    class zad2
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj slowo: ");
            string s = Console.ReadLine();
            if (s == Reverse(s))
            {
                Console.WriteLine($"Słowo {s} jest palindromem");
            }
            else
            {
                Console.WriteLine($"Słowo {s} nie jest palindromem");
            }
        }
    }
}
