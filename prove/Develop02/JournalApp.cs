using System;
using System.IO;
using System.Collections.Generic;


public class JournalApp
{
    public void Journal()
    {
        bool loop = true;
        while (loop)
        {   
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Inspiration ");
            Console.WriteLine("2. Prompt");
            Console.WriteLine("3. Write");
            Console.WriteLine("4. Save Entry");
            Console.WriteLine("5. Display Journal");
            Console.WriteLine("0. Quit");
            Console.WriteLine("Please enter a number: ");
            int decision = int.Parse(Console.ReadLine());
    
            switch (decision)
            {
                case 1:
                    //Let get inspired!!!!
                    InspirationGenerator quote = new InspirationGenerator();
                    string Inspiration = quote.GetRandomQuote();
                    Console.WriteLine(Inspiration);
                    break;
                
                case 2:
                    //give user a prompt to write about
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string Prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(Prompt);
                    break;

                case 3:
                    //Allow user to write a prompt
                    Write Entry = new Write();
                    Entry.Entry();
                    break;
                
                case 4:
                    //Allow user to save their entry to the txt file
                    Write Save = new Write();
                    Save.Save();
                    break;

                case 5:
                    //Allow user to see the journal
                    Write load = new Write();
                    load.Log();
                    break;
        
                case 0:
                    //Break the loop and quit program
                    loop = false;
                    break;

                default:
                    Console.WriteLine("Invaild input. Select an option from the menu. ");
                    break;
            }
        }
    }
}
