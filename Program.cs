using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(100);

            bool w = false;

            do
            {
                Console.Write("Podaj liczbę: ");
                string s = Console.ReadLine();

                int l = int.Parse(s);
                
                if (l > n)
                {
                    Console.WriteLine("Za dużo!");
                }
                else if (l < n)
                {
                    Console.WriteLine("Za mało!");
                }
                else
                {
                    Console.WriteLine("Wygrałeś!");
                    w = true;
                }

            }
            while (w == false);
        }
    }
}
