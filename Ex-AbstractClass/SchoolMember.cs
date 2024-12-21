namespace Ex_AbstractClass;

public abstract class SchoolMember
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public SchoolMember(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public abstract void DisplayRole();
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}