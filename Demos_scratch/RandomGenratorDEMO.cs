using System;

class Program
{
    static void Main()
    {
        // Use the static class method to get a random string
        string randomString = RandomStringGenerator.GetRandomString();

        // Print the randomly selected string
        Console.WriteLine($"Randomly Selected String: {randomString}");
    }
}
