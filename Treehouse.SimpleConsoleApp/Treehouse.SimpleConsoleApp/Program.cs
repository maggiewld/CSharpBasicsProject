using System;


namespace Treehouse.SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for the minutes exercised
            Console.Write("Enter how many minutes you exercised: ");
            string entry = Console.ReadLine();


            //Add minutes exercised to total
            //Display total minutes exercised to the screen
            Console.WriteLine("You've exercised " + entry + " minutes.");

            //Repeat until the user quits
        }
    }
}
