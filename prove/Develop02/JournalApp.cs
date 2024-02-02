using System;
using System.IO.Enumeration;
using System.IO;

public class JournalApp
{
    static void Main()
    {
        while (true)
        {   
            console.WriteLine("Menu Options: ");
            console.WriteLine("1. Inspiration ");
            console.WriteLine("2. Write");
            console.WriteLine("3. Display");
            console.WriteLine("4. Save Entry");
            console.WriteLine("5. Load Entry");
            console.WriteLine("0. Quit");
            console.WriteLine("What would you like to do? (enter a number): ");
            int decisicon = int.Parse(console.ReadLine());

            switch (decisicon)
            {
                case 1:
                //Let get inspired!!!!
                InspirationGenerator quote = new InspirationGenerator();

                //accessing myethods
                
                quote.GetRandomQuote();
                {
                    console.WriteLine($"{InspirationArray[randomIndex]}");
                }
            }

            
        }
    }
}