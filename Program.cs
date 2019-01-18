using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Console.Write("Welcome to the Grand Circus Casino!. Roll the dice? (y/n) ");
            string roll = Console.ReadLine();
            int rollCounter = 1;
            if (roll == "y")
            {
                do
                {   
                    Console.Write("Enter number of sides of dice (should be greater than 0): ");

                    int numberOfSides = int.Parse(Console.ReadLine());
                    while (numberOfSides <= 0)
                    {
                        Console.Write("Please enter a number greater than 0: ");
                        numberOfSides = int.Parse(Console.ReadLine());
                    }
                    int firstRoll, secondRoll;

                    RollDice(numberOfSides, out firstRoll, out secondRoll);
                    rollCounter += 1;
                    Console.WriteLine("Roll {0}: {1}, {2}", rollCounter, firstRoll, secondRoll);

                    Console.Write("Roll again? ");
                    response = Console.ReadLine();

                } while (response == "y");
                Console.WriteLine("Thanks for playing. Goodbye!");
            }
            else
            {
                Console.WriteLine("Goodbye! Hope you play next time.");
            }
        }
        public static void RollDice(int sides, out int rollOne, out int rollTwo)
        {   
            Random random = new Random();
            rollOne = random.Next(1, sides);
            rollTwo = random.Next(1, sides);

        }
    }
}
