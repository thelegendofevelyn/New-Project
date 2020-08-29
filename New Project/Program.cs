using System;

namespace New_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!\nPlease choose two numbers to guess between.");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int x = Convert.ToInt32(num1);
            int y = Convert.ToInt32(num2);

            Console.WriteLine("\nPlease guess a number between your two numbers.");
            Random rand = new Random();
            int r = rand.Next(x, y);
            string guess = Console.ReadLine();
            int gues = Convert.ToInt32(guess);
            bool yn = false;

            int counter = 1;
            while (yn == false)
            {
                if (gues == r)
                {
                    yn = true;
                } 
                else if(gues < r)
                {
                    Console.WriteLine("Guess higher!");
                }
                else if(gues > r)
                {
                    Console.WriteLine("Guess lower!");
                }
                counter += 1;
                Console.WriteLine("Guess Again!");
                guess = Console.ReadLine();
                gues = Convert.ToInt32(guess);

            }
            Console.WriteLine("Took " + counter + " tries");
            Console.WriteLine("Good job! The number was " + gues);
        }
    }
}