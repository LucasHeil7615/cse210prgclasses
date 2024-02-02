//FROM CHAT GBT 3.5
using System;

public static class RandomStringGenerator
{
    // Array of strings
    private static string[] stringArray = { "Apple", "Banana", "Cherry", "Orange", "Grapes" };

    // Random number generator
    private static Random random = new Random();

    // Static method to get a random string from the array
    public static string GetRandomString()
    {
        // Get a random index from the array
        int randomIndex = random.Next(0, stringArray.Length);

        // Return the string at the random index
        return stringArray[randomIndex];
    }
}
