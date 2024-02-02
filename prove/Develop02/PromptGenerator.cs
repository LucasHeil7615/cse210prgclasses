using System;
using System.IO.Enumeration;
using System.IO;
public static class PromptGenerator {
private static readonly string[] promptsArray =
{
    "What was your favorite color of the day? describe How that color stood out.",
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today what would it be?",
    "What was something that you could smell today that gave you a happy memory?",
    "Who made you smile today and why?",
    "Who helped you today and how?",
    "What invention did you think of Today?",
    "How could you have helped someone today?",
    "What is a goal that you would like to work on?",
    "Where did your thoughts drift off to today?",
    "What is a new hobby that you would like to take up?",
    "What deep thought did you have today?",
    "What is your greatest desire?"
};
// Random number generator
    private static Random random = new Random();
    //method to pull a random prompt
        public static string GetRandomPrompt()
    {
        // Get a random index from the array
        int randomIndex = random.Next(0,promptsArray.Length);

        // Return the string at the random index
        return promptsArray[randomIndex];
    }
}
