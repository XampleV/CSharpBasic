using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;
using CSharpBasic;
namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            runFlowControl();
        }
        static void runFlowControl()
        {
            FlowControl.FlowControl.FCIfElse();
        }
        static void myCharacterClass()
        {
            CharacterClass bruhNinja = new CharacterClass();
            CharacterClass mediumNinja = new CharacterClass();
            CharacterClass lolNinja = new CharacterClass();

            bruhNinja.CharacterName = "ultimate bruh ninja.";
            Console.WriteLine(bruhNinja.CharacterName);

        }
        static void myString()
        {
            Console.WriteLine("Enter you age.");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name.");
            string myName = Console.ReadLine();

            Console.WriteLine($"Name: {myName} | Age : {userAge}");
            string myCoolString = "very cool indeed";
            string iAmTired = "i am going to use $ with this string.";
            Console.WriteLine("Cool bro" + myCoolString);
            Console.WriteLine($"{iAmTired}");
            // commit 2
        }
    }
}
