namespace Ex_AbstractClass;

public class Student : SchoolMember
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade) 
        : base(name, age)
    {
        Grade = grade;
    }
    
    public override void DisplayRole()
    {
        Console.WriteLine($"I am a Student in {Grade}.");
    }
}