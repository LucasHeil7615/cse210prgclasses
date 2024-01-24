public class Job{

    public string company;

    public string jobTitle;
    
    public int startYear;

    public int endYear;

    public Job(string companyName, string title, int start, int end){
        company = companyName;
        jobTitle = title;
        startYear = start;
        endYear = end;
    }
    
    public void Display(){
        // Software Engineer (Miscrosoft) 2019-2022
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}

// _ tells the developer that this is a private variable