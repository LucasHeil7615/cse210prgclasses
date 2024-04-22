using System;

class Program
{
    // Menu for Mini Games
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mindfullness \n Please select an option:");
        
        int option = 1
        while (option != 0){

        
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Listing");
        Console.WriteLine("3. Reflection");
        Console.WriteLine("0. Quit");
        int option = int.parse(Console.readline());

        switch (option)
        {
            case 1:
            //call Breathing
            break; 

            case 2:
            //call Listing
            break;

            case 3:
            //call Reflection
            break;

            case 0:
            //quit program
            break;

            default:
            Console.WriteLine("It seems that you have chosen something outside of your options. Please select something else or quit.")
            break;
        }       
        Console.WriteLine("Thanks for playing. :) ")
    }
    }
}