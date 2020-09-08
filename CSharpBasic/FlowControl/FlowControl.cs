using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.FlowControl
{
    class FlowControl
    {
        public const int minimumAge = 13;
        public static int playerAge;
        public static void FCIfElse()
        {
            Console.WriteLine("Welcome.\nAge: ");
            playerAge = Convert.ToInt32(Console.ReadLine());
            if (playerAge < minimumAge)
            {
                Console.WriteLine("You do not meet the minimum age requirement.");
                FCElseIf();
            }


        }
        public static bool FCElseIf()
        {
            Console.WriteLine("Do you have parents permission to play?");
            string permission = Console.ReadLine().ToLower();
            if (permission == "yes" || permission == "y")
            {
                Console.WriteLine("Cool, you can play now.");
                return true;
            }
            else if (permission == "no" || permission == "n")
            {
                Console.WriteLine("lmao that sucks.");
                return false;
            }
            else
            {
                Console.WriteLine("Please enter yes or no.");
                return FCElseIf();
            }
        }
        public static void FCSwitchRoll()
        {
            Console.WriteLine("------------- GAME STARTED -------------");
            Random computerRnadomRPS = new Random();
            int computerAnswerGen = computerRnadomRPS.Next(1, 4);
            string choice;
            string userInput;
            switch (computerAnswerGen)
            {
                case 1:
                    choice = "rock";
                    break;
                case 2:
                    choice = "paper";
                    break;
                case 3:
                    choice = "scissor";
                    break;
            }
           
            

        }
    }
}