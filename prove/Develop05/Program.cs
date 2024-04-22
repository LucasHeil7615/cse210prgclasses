using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the goals Planner");
        Console.WriteLine("In this program we have created a place for you to created Goals and get rewarded for accomplishing them.");
        Console.WriteLine("We also have the option to give you daily side quests to earn extra points to get extra rewards! "); 
        Console.writeline("Most of all have fun and enjoy improving your life. ");

        bool loop = true;
        while (loop)
        {
            Console.writeline("Please Select an option below: ");
            Console.Writeline("1: Create New goal");
            Console.WriteLine("2: View Goals ");
            Console.WriteLine("3: Report on Goals");
            Console.WriteLine("4: Goals Score ");
            Console.WriteLine("5: Side Quests");
            Console.WriteLine("0: Quit Program");

            int choice = int.parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //calls and runs the Goals Generator class 
                    break;
                case 2: 
                    //calls and runs the Goals List class
                    break;
                case 3: 
                    //calls and runs the Report class
                    break;
                case 4:
                    //calls and runs the Goals score class
                    break;
                case 5: 
                    //calls and runs the Side quest class
                    break;
                case 6: 
                    //Breaks the loop and dispalys an exit message
                    Console.WriteLine("Thanks for logging in today enjoy the day and keep to the grind stone. ");
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Please select an option from the menu (a number bewtween 0-6.) hint 0 will quit the program.");
            }
        }
    }
}