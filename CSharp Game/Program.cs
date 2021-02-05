using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);
            int attempts = 0;
            bool win = false;
            do
            {
                Console.Write("Guess a number inbetween 0 and 100: ");
                string s = Console.ReadLine();
                int num = int.Parse(s);
                if(num > winNum)
                {
                    Console.WriteLine("Too high! The number is lower.");
                }
                else if(num < winNum)
                {
                    Console.WriteLine("Too low! The number is higher.");
                }
                else if(num == winNum)
                {
                    Console.WriteLine("You guessed right! Well done!");
                    win = true;
                }
                attempts++;
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Total attempts: " + attempts);
            Console.WriteLine("Thanks for playing!");            
        }
    }
}
