using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Welcome to list calculator. Please enter your list of numbers. ");
        Console.WriteLine("We will give you the sum, average, and the largest number. ");
        Console.WriteLine("When you are finished please enter 0 and your results will be displayed. ");
        do 
        {
            numbers.Add(num1);
            Console.Write("Enter a Number: ");
            num1 = int.Parse(Console.ReadLine());
        } while (num1 != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            Console.Write(num);
        }

        Console.WriteLine(" ");
        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine("The Average is ");
        Console.WriteLine("The Largest number is ");
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