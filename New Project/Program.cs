using System;

namespace New_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!\nPlease guess a number between 0 and 100.");
            Random rand = new Random();
            int x = rand.Next(1, 10);
            string guess = Console.ReadLine();
            int y = Convert.ToInt32(guess);
            bool yn = false;
            while (yn == false)
            {
                Console.WriteLine("Guess Again!");
                guess = Console.ReadLine();
                y = Convert.ToInt32(guess);
                if (x == y)
                {
                    yn = true;
                }
                
            }
            Console.WriteLine("Good job! The number was " + x);
        }
    }
}
