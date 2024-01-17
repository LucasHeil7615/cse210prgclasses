using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        List<int> numbers = new List<int>();
        Console.writeline("Welcome to list calculator. Please enter you list of numbers. ");
        cosole.writeline("We will give you the sum, average, and the largest number. ");
        console.writeline("When you are finished please enter 0 and your results will be displayed. ");
        do
        {
            Console.write("Enter a Number: ");
            num1 = int.Parse(Console.ReadLine());
            numbers.add(num1);
            
        } while (num1 != 0);

        Console.writeline($"The sum is: {numbers.Count}");
    } 
}
// Finished product
//          Enter a list of numbers, type 0 when finished.
//   Enter number: 18
//   Enter number: 36
//   Enter number: 2
//   Enter number: 48
//   Enter number: 6
//   Enter number: 12
//   Enter number: 9
//   Enter number: 0
//   The sum is: 131
//   The average is: 18.714285714285715
//   The largest number is: 48