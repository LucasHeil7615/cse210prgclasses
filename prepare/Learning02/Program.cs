using System;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Target", "Front end Cashier,cart collector", 2018, 2019);
    
        Job job2 = new Job("Noble Craftmenship","Aprentice Carpenter",2021,2022);
    
        Resume Lucas = new Resume();
        Lucas.name = "Lucas Heil";
        Lucas.jobs.Add(job1);
        Lucas.jobs.Add(job2);
        Lucas.Display();
    }

}