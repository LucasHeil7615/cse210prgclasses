using System;
using System.IO.Enumeration;
using System.IO;
class InspirationGenerator
{
// An array of quotes saved as strings 
private static readonly string[] inspirationArray =
{
   "Journal writing is a voyage to the interior. - Christina Baldwin",

"Journaling is like whispering to one's self and listening at the same time.  (Mina Murray Dracula: by Bram Stoker)",

"Journaling is a powerful tool for awareness and mindfulness. It turns each page into a journey of self-discovery. - Unknown",

"I can shake off everything as I write. my sorrows disappear. my courage is reborn. - Anne Frank",

"Your journal is like your best friend. You don't have to pretend with it. you can be honest and write exactly how you feel. - Bukola Ogunwale",

"Writing in a journal reminds you of your goals and of your learning in life. It offers a place where you can hold a deliberate thoughtful conversation with yourself. - Robin Sharma",

"Journaling is a profound way to slow down and appreciate the world. It`s a place to record` experiences and explore your thoughts. - Doreen Virtue",

"In the journal I do not just express myself more openly than I could to any person I create myself. - Susan Sontag",

"A personal journal is an ideal environment in which to become. It is a perfect place for you to think-feel-discover-expand-remember-and-dream. - Brad Wilcox",

"Journaling is a way to listen to yourself. To become acquainted with your own thoughts and feelings. It's a form of self-care`selfdiscovery`and self-expression. - Unknown",

"The only way to do great work is to love what you do. - Steve Jobs",

"Believe you can and you're halfway there. - Theodore Roosevelt",

"Your time is limited. Don't waste it living someone else's life. - Steve Jobs",

"The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",

"Success is not final. Failure is not fatal. It is the courage to continue that counts. - Winston Churchill",

"The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",

"Don't watch the clock. Do what it does. Keep going. - Sam Levenson",

"It's not about how hard you hit. It's about how hard you can get hit and keep moving. - Rocky Balboa",

"Success is stumbling from failure to failure with no loss of enthusiasm. - Winston S. Churchill",

"The only person you are destined to become is the person you decide to be. - Ralph Waldo Emerson",

"The best way to predict the future is to create it. - Peter Drucker",

"You are never too old to set another goal or to dream a new dream. - C.S. Lewis",

"Success is not in what you have but who you are. - Bo Bennett",

"The difference between a successful person and others is not a lack of strength ~ not a lack of knowledge ~ but rather a lack in will. - Vince Lombardi",

"The only thing standing between you and your goal is the story you keep telling yourself as to why you can`t achieve it. - Jordan Belfort",

"The way to get started is to quit talking and begin doing. - Walt Disney",

"I find that the harder I work ~ the more luck I seem to have. - Thomas Jefferson",

"Your attitude ~ not your aptitude ~ will determine your altitude. - Zig Ziglar",

"In the middle of difficulty lies opportunity. - Albert Einstein",
};
    // Random number generator
    public Random random = new Random();

    // Static method to get a random string from the array
    string quote = GetRandomQuote()
    {
        // Get a random index from the array
        int randomIndex = random.Next(0,InspirationArray.Length);

        // Return the string at the random index
        return InspirationArray[randomIndex];
    }

}