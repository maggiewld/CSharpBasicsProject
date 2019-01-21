using System;


namespace Treehouse.SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningTotal = 0.0;
            
            while(true)
            {
                //Prompt the user for the minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break; //Quits program.
                }
                
                try
                {
                    var minutes = double.Parse(entry);

                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                            continue; //This resets to beginning prompt.
                        }
                        else if (minutes <= 10)
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

                        //Add minutes exercised to total
                        runningTotal += minutes; //Same as: runningTotal = runningTotal + minutes

                            
                        //Display total minutes exercised to the screen
                        Console.WriteLine("You've exercised " + runningTotal + " minutes.");

                        //Repeat until the user quits
                }
                    catch (FormatException) //Expected input error, NaN.
                {
                    Console.WriteLine("That is not valid input.");
                    continue; //Resets to input prompt.
                }

                finally //Good practice to show end of code.
                {
                    Console.WriteLine("I am fin.");
                }
                             
              
                
            }
            Console.WriteLine("Goodbye");

        }
    }
}
