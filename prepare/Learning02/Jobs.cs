public class Job{

    public string _company;

    public string _jobTitle;
    
    public int _startYear;

    public int _endYear;
    
    public void Display(){
        // Software Engineer (Miscrosoft) 2019-2022
        Console.WriteLine($"{-jobTitle} ({_company}) {startYear}-{_endYear}");
    }
}