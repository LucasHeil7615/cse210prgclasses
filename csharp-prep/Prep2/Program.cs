using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage (Ex. 98.2, 65.4, 79.89,etc.): ");
        String ValueFromUser = Console.ReadLine();

        float Percentage = float.Parse(ValueFromUser);

        if (Percentage > 93)
        {
            Console.WriteLine($"Your grade: {Percentage} recieves an Outstanding OWL. We can except great things from you.");
        }
        else if (Percentage > 85)
        {
            Console.WriteLine($"Your grade: {Percentage} recieves an Exceeds Expectations OWL. Well done.");
        }
        else if (Percentage > 70)
        {
            Console.WriteLine($"Your grade: {Percentage} recieves an Acceptable OWL congrats you've passed.");
        }
        else if (Percentage > 60)
        {
            Console.WriteLine($"Your grade: {Percentage} recieves a Poor OWL.");
        }
        else if (Percentage > 50)
        {
            Console.WriteLine($"Your grade: {Percentage} recieves a Dreadful OWL.");
        }
        else
        {
            Console.WriteLine($"Your grade: {Percentage} recieves a Troll OWL. I'd open the Howllers swiftly and get them over with. They'll explode if you don't.");
        }

        if (Percentage > 85)
        {
            Console.WriteLine("Congratulations. You have shown your quality and will be able to enter your N.E.W.T. CLasses for the upcoming year.");
        }
        else if (Percentage > 70)
        {
            Console.WriteLine("You've passed this course however the workload will be too great for me to permit you to enter my N.E.W.T. CLass. Think about taking Charms instead.");
        }
        else
        {
            Console.WriteLine("Oh dear, Oh dear. It seems that you would do well to either retake my class with inmporved effort or drop and avoid any carrears with coding in the future. I'm quite sorry. ");
        }

        Console.Write($"Your OWL examination grade is {Percentage}.");
    }
}




// Stretch Challenge
// Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

// After your logic to determine the grade letter, add another section to determine the sign. Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.

// Hint: To get the last digit, you could divide the number by 10, and get the remainder. You might refer back to the preparation material for Lesson 03 to see the operators and find the one that does division and gives you the remainder.

// At this point, don't worry about the exceptional cases of A+, F+, or F-.

// Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.

// Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.