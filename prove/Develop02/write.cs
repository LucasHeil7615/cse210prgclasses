using System;
using System.IO;
using System.Collections.Generic;



public class Write {

    private string filename = "journallog.txt";
    private  List<string> journalEntries = new List<string>();
    public void Entry(){
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    
    Console.WriteLine("Enter your journal entry:");
    string userEntry = Console.ReadLine();

    string formattedEntry = $"{dateText}: {userEntry}";
    journalEntries.Add(formattedEntry);

    }

    public void Save()
    {
        using (StreamWriter journalLog = new StreamWriter(filename))
        {
            journalLog.WriteLine("Journal Of Lucas Heil");

            foreach (string entry in journalEntries)
            {
                journalLog.WriteLine(entry);
            }
        }
    }
    public  void Log()
    {
    
    string[] Lines = File.ReadAllLines(filename);

    foreach (string Line in Lines)
    {
        Console.WriteLine(Line);
    }
    }
}


