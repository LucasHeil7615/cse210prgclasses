using System;

class Program
{
    static void Main(string[] args){
        //  Start by asking the user for the magic number.
        Console.Write("What is the magic number? ");
        int Magic_number = int.Parse(Console.ReadLine());
        // Ask the user for a guess.
        Console.Write("What is your guess? ");
        //in line parse to change readline's string into an int
        int Guess_num = int.Parse(Console.ReadLine());
        
        // Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
        if (Magic_number > Guess_num){
            Console.WriteLine("Guess Higher.");
        }
        else if (Magic_number < Guess_num){
            Console.WriteLine("Guess Lower.");
        }
        else
        {
            Console.WriteLine("Congrats you guessed the number :)");
        }
        }

        
    }
 



