public abstract class Animal {
    
    public string name;

    public string sound;

//protcted says only a child of a class can call this
    protected Animal(string name, string sound) {
        this.name = name;
        this.sound = sound;
    }
    public virtual void MakeSound(){
    Console.WriteLine("***Ominous Silence***");
    }

}