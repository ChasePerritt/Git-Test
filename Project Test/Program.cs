using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test
{
    class Program
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static void Main(string[] args)
        {
            int lowBound, upperBound;
            string entry;
            Console.WriteLine("Please enter a lower bound");
            entry = Console.ReadLine();
            lowBound = Convert.ToInt32(entry);

            Console.WriteLine("Please enter an upper bound");
            entry = Console.ReadLine();
            upperBound = Convert.ToInt32(entry);

            Console.Write("I am thinking of a number between ");
            Console.Write(lowBound);
            Console.Write(" and ");
            Console.WriteLine(upperBound);
            Program p = new Program();
            int randNum = p.RandomNumber(lowBound, upperBound);

            int tries = 1;
            int userGuess = upperBound + 1;
            string guess;

            while(userGuess != randNum)
            {
                Console.Write("Please enter a number between ");
                Console.Write(lowBound);
                Console.Write(" and ");
                Console.WriteLine(upperBound);
                guess = Console.ReadLine();
                userGuess = Convert.ToInt32(guess);

                if (userGuess == randNum)
                {
                    Console.Write("Congratulations! You took ");
                    Console.Write(tries);
                    Console.WriteLine(" tries to find the number!");
                    break;
                }
                else if (userGuess < randNum && userGuess >= 0)
                {
                    Console.WriteLine("Too Low");
                }
                else if (userGuess > randNum && userGuess <= 100)
                {
                    Console.WriteLine("Too High");
                }
                tries++;
            }
            Console.ReadKey();
        }
    }
}
