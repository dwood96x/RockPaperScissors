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
            /* do
            {
                fight();
            } while played == 0;
            */
        }
        public static void fight()
        {
            Console.WriteLine("Lets play rock paper scissors! Whats your choice?");
            string pChoice = Console.ReadLine();
            pChoice.ToLower();
            Random random = new Random();
            int aiChoice = random.Next(2);
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
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
        
    }
}
