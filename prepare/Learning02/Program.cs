using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1. _company = "Lego Store";
        job1. _jobTitle = "Lego Master builder / Cashier";
        job1. _startYear = 2025;
        job1. _endYear = 2026;
        job1.Display();

        Job job2 = new Job();
        job2. _company = "Lego Store";
        job2. _jobTitle = "Lego Master builder / Manager";
        job2. _startYear = 2026;
        job2. _endYear = 2027;
        job2.Display();
    }

}