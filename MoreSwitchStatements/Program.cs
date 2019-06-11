using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreSwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("What color car would you like? ");
            choice = Console.ReadLine();

            checkColor(choice);
        }
        public static void checkColor(string choice)
        {
            string carColor;
            switch (choice)
            {
                case "red":
                case "blue":
                case "yellow":
                    carColor = $"We have a {choice} car!";
                    break;
                default:
                    Console.WriteLine("Sorry, we don't have a car in this color..");
                    return;
            }
            Console.WriteLine(carColor);
        }
    }
}
