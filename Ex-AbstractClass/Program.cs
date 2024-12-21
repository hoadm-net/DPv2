namespace Ex_AbstractClass;

class Program
{
    static void Main(string[] args)
    {
        SchoolMember teacher = new Teacher("Hòa", 31, "Design Pattern");
        SchoolMember student = new Student("Minh", 19, "second-year");
        SchoolMember admin = new AdminStaff("Yến", 31, "Training");
        
        teacher.DisplayInfo();
        teacher.DisplayRole();

        student.DisplayInfo();
        student.DisplayRole();

        admin.DisplayInfo();
        admin.DisplayRole();
    }
}