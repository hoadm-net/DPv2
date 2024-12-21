namespace Overview;

public class Student
{
    private string name;
    private int age;
    private string studentID;

    // Property: Cung cấp cách truy cập và cập nhật giá trị của field
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set 
        { 
            if (value > 0) // Kiểm tra tính hợp lệ
                age = value; 
        }
    }

    public string StudentID
    {
        get { return studentID; }
        set { studentID = value; }
    }

    // Method: Hành vi của class, thực hiện một hành động
    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}