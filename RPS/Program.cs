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
            do
            {
                fight();
            } while played == 0;
        }
        public static void fight()
        {
            Console.WriteLine("Lets play rock paper scissors! Whats your choice?");
            string pChoice = Console.ReadLine();
            pChoice.ToLower();
            Random random = new Random();
            int aiChoice = random.Next(2);

            if pChoice /=

        }
    }
}
