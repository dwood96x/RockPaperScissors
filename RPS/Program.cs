using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
                fight();
        }
        public static void fight()
        {
            int quitGame = 0;
            do
            {
                Console.WriteLine("Lets play rock paper scissors! Whats your choice?");
                Console.WriteLine("Rock Paper Scissors or quit to exit.");
                string pChoiceOrig = Console.ReadLine();
                string pChoice = pChoiceOrig.ToLower();
                Random random = new Random();
                int aiChoice = random.Next(3);
                // 0 == rock, 1 == paper, 2 == scissors for the AI decision
                if (pChoice == "rock")
                {
                    if (aiChoice == 0)
                    {
                        Console.WriteLine("Draw! You both picked rock!");
                    }
                    else if (aiChoice == 1)
                    {
                        Console.WriteLine("You lost! Their paper beat your rock!");
                    }
                    else
                    {
                        Console.WriteLine("You won! Congradulations!");
                    }
                }
                else if (pChoice == "paper")
                {
                    if (aiChoice == 0)
                    {
                        Console.WriteLine("You won! Your paper beat their rock!");
                    }
                    else if (aiChoice == 1)
                    {
                        Console.WriteLine("Draw! You both picked paper!");
                    }
                    else
                    {
                        Console.WriteLine("You lost! Their scissors beat your rock!");
                    }
                }
                else if (pChoice == "scissors")
                {
                    if (aiChoice == 0)
                    {
                        Console.WriteLine("You lost! Their rock beat your scissors!");
                    }
                    else if (aiChoice == 1)
                    {
                        Console.WriteLine("You win! Your scissors beat their paper!");
                    }
                    else
                    {
                        Console.WriteLine("Draw! You both picked scissors!");
                    }
                }
                else if (pChoice == "quit")
                {
                    quitGame = 1;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (quitGame == 0);
        }
        public static void menu()
        {
            /*
            Console.WriteLine("Would you like to keep playing? Yes or no?");
            string menuChoice = Console.ReadLine();
            if (menuChoice == "yes")
            {
                
            }
            */
        }
        
    }
}
