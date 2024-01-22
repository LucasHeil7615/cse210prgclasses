using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Target", "Front end Cashier,cart collector", 2018, 2019);
    
        Job job2 = new Job("Noble Craftmenship","Aprentice Carpenter",2021,2022);
    
        Resume Lucas = new Resume();
        Lucas. _name = "Lucas Heil"
        Lucas. _jobs. Add(job1)
        Lucas. _jobs. Add(job2)
        Lucas.Display
    }

}