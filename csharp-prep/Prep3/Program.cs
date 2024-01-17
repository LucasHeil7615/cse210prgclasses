using System;

class Program
{
    static void Main(string[] args){

        //declaring variables and Generaate a random number from 1 - 100
        Random randomGenerator = new Random();
        int Magic_number = randomGenerator.Next(1,100);
        int Guess_num = 0;
        int Guess_count = 0;
        //Create a Do While loop to lop through the task until Magic number is equal to guess
        do{
            // Generaate a random number from 1 - 100
         
            // Ask the user for a guess.
            Console.Write("What is your guess? ");
            //in line parse to change readline's string into an int
            Guess_num = int.Parse(Console.ReadLine());

            Guess_count = Guess_count + 1;
            
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
                Console.Write($"You guessed {Guess_count} many times. ");
            }
            
        } while (Guess_num != Magic_number);

    }

        
    }
 



