using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;
namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myString();
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
        }
    }
}
