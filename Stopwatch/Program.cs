using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            // Start(6,0);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n-- STOPWATCH --");
            Console.WriteLine("\nS = Second => 10s = 10 seconds \nM = Minute => 1m = 1 minutes \n0 = Exit");
            Console.Write("\nHow much time do u want to count? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

            Console.WriteLine("");

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1500);

            Start(time);

        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" > COUNTDOWN <");
                Console.Write("\n--> ");
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(" -- Stopwatch finalizado --");
            Thread.Sleep(1500);
            Menu();
        }
    }
}

