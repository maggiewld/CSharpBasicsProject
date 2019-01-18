using System;


namespace Treehouse.SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while(keepGoing)
            {
                //Prompt the user for the minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {

                    int minutes = int.Parse(entry);
                    if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }

                    runningTotal = runningTotal + minutes;

                    //Add minutes exercised to total
                    //Display total minutes exercised to the screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes.");

                    //Repeat until the user quits
                }
                
            }
            Console.WriteLine("Goodbye");

        }
    }
}
