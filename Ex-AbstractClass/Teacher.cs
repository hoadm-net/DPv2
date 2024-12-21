namespace Ex_AbstractClass;

public class Teacher : SchoolMember
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject) 
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"I am a Teacher. I teach {Subject}.");
    }
}