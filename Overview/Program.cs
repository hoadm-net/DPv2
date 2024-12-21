namespace Overview;

class Program
{
    static void Main(string[] args)
    {
        // Object: Tạo thể hiện của class Student
        Student student = new Student();

        // Sử dụng property để thiết lập giá trị cho field
        student.StudentID = "11DH110005";
        student.Name = "Đinh Minh Hòa";
        student.Age = 31;

        // Gọi method để hiển thị thông tin sinh viên
        student.DisplayInfo();
    }
}