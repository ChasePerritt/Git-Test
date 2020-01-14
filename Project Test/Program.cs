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
            Console.WriteLine("I am thinking of a number between 0 and 100");
            Program p = new Program();
            int randNum = p.RandomNumber(0, 100);

            int tries = 1;
            int userGuess = 101;
            string guess;

            while(userGuess != randNum)
            {
                Console.WriteLine("Please enter a number between 0 and 100");
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
