namespace Ex_AbstractClass;

public class AdminStaff : SchoolMember
{
    public string Department { get; set; }

    public AdminStaff(string name, int age, string department) 
        : base(name, age)
    {
        Department = department;
    }
    
    public override void DisplayRole()
    {
        Console.WriteLine($"I am an Admin Staff working in the {Department} department.");
    }
}