// Week 4 Class Object Methods Constructure 
// Task 1 
class Student
{
    public string name = "";
    public int age = 0;
    public string address = "";
    public static string universityName = "ICP";
}
class Program
{
    static void Main(string[] args)
    {
        // Create two objects of Student
        Student student1 = new Student();
        Student student2 = new Student();

        student1.name = "Rohan Brd";
        student1.age = 20;
        student1.address = "Pokhara";

        student2.name = "Sita Rai";
        student2.age = 22;
        student2.address = "Kathmandu";

        System.Console.WriteLine($"Student 1 Details:");
        Console.WriteLine($"Name: {student1.name}");
        Console.WriteLine($"Age: {student1.age}");
        Console.WriteLine($"Address: {student1.address}");
        System.Console.WriteLine("==========================");
        System.Console.WriteLine($"Student 2 Details:");
        Console.WriteLine($"Name: {student2.name}");
        Console.WriteLine($"Age: {student2.age}");
        Console.WriteLine($"Address: {student2.address}");

        Console.WriteLine($"University Name: {Student.universityName}");
    }
}