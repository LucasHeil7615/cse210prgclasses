public class Resume {

    public string name;

    public List<Job> jobs = new List<Job>();

    public void Display(){
        foreach (Job pizza in jobs) {
            pizza.Display();
        }
    }
}