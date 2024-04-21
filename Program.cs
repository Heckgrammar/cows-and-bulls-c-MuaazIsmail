using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cows and Bulls Starter Framework Code
            int guesses = 0;
            bool validity = false;
            Random random = new Random();
            int targetNumber = 0;
            string targetNumberString = " ";
            char tPart1 = ' ';
            char tPart2 = ' ';
            char tPart3 = ' ';
            char tPart4 = ' ';
            while (validity == false)
            {
                targetNumber = random.Next(1023, 9877);
                targetNumberString = targetNumber.ToString();
                tPart1 = targetNumberString[0];
                tPart2 = targetNumberString[1];
                tPart3 = targetNumberString[2];
                tPart4 = targetNumberString[3];
                if (tPart1 == tPart2 | tPart1 == tPart3 | tPart1 == tPart4 | tPart2 == tPart3 | tPart2 == tPart4 | tPart3 == tPart4)
                {
                    validity = false;
                }
                else
                {
                    validity = true;
                }
            }
            int bulls = 0;
            while (bulls < 4)
            { 
                 validity = false;
                int guessNumber = 0;
                string guessNumberString = " ";
                char gPart1 = ' ';
                char gPart2 = ' ';
                char gPart3 = ' ';
                char gPart4 = ' ';
                while (validity == false)
                {
                    guessNumberString = Console.ReadLine();
                    guessNumber = Convert.ToInt32(guessNumberString);
                    if (guessNumber >= 1000 && guessNumber <= 9999)
                    {
                        gPart1 = guessNumberString[0];
                        gPart2 = guessNumberString[1];
                        gPart3 = guessNumberString[2];
                        gPart4 = guessNumberString[3];
                        if (gPart1 == gPart2 | gPart1 == gPart3 | gPart1 == gPart4 | gPart2 == gPart3 | gPart2 == gPart4 | gPart3 == gPart4)
                        {
                            validity = false;
                            Console.WriteLine("Please enter a valid number");
                        }
                        else
                        {
                            validity = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                int cows = 0;
                if (tPart1 == gPart2)
                {
                    cows++;
                }
                if (tPart1 == gPart3)
                {
                    cows++;
                }
                if (tPart1 == gPart4)
                {
                    cows++;
                }
                if (tPart2 == gPart1)
                {
                    cows++;
                }   
                if (tPart2 == gPart3)
                {
                    cows++;
                }
                if (tPart2 == gPart4)
                {
                    cows++;
                }
                if (tPart3 == gPart1)
                {
                    cows++;
                }
                if (tPart3 == gPart2)
                {
                    cows++;
                }
                if (tPart3 == gPart4)
                {
                    cows++;
                }
                if (tPart4 == gPart1)
                {
                    cows++;
                }
                if (tPart4 == gPart2)
                {
                    cows++;
                }
                if (tPart4 == gPart3)
                {
                    cows++;
                }
                Console.WriteLine("You have " + cows + " cows");
                bulls = 0;
                if (tPart1 == gPart1)
                {
                    bulls++;
                }
                if (tPart2 == gPart2)
                {
                    bulls++;
                }
                if (tPart3 == gPart3)
                {
                    bulls++;
                }
                if (tPart4 == gPart4)
                {
                    bulls++;
                }
                Console.WriteLine("You have " + bulls + " bulls");
                guesses++;
            }
            Console.WriteLine("you took " + guesses + " guesses");
            Console.WriteLine("Press enter to continue . . ."); Console.Read();
        }
    }
}
