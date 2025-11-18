// Week 4 Class Object Methods Constructure 
// Task 1 
// class Student
// {
//     public string name = "";
//     public int age = 0;
//     public string address = "";
//     public static string universityName = "ICP";
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create two objects of Student
//         Student student1 = new Student();
//         Student student2 = new Student();

//         student1.name = "Rohan Brd";
//         student1.age = 20;
//         student1.address = "Pokhara";

//         student2.name = "Sita Rai";
//         student2.age = 22;
//         student2.address = "Kathmandu";

//         System.Console.WriteLine($"Student 1 Details:");
//         Console.WriteLine($"Name: {student1.name}");
//         Console.WriteLine($"Age: {student1.age}");
//         Console.WriteLine($"Address: {student1.address}");
//         System.Console.WriteLine("==========================");
//         System.Console.WriteLine($"Student 2 Details:");
//         Console.WriteLine($"Name: {student2.name}");
//         Console.WriteLine($"Age: {student2.age}");
//         Console.WriteLine($"Address: {student2.address}");

//         Console.WriteLine($"University Name: {Student.universityName}");
//     }
// }

// Task 2 
// class Calculator
// {
//     public void PrintWelcome()
//     {
//         Console.WriteLine("Welcome to the Calculator");
//     }
//     public int Add(int num1, int num2)
//     {
//         return num1 + num2;
//     }    
//     public int Multiply(int num1, int num2 = 1)
//     {
//         return num1 * num2;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculator calc = new Calculator();
//         calc.PrintWelcome();
//         Console.WriteLine();
        
//         int addResult = calc.Add(10, 5);
//         Console.WriteLine($"Addition: 10 + 5 = {addResult}");
//         System.Console.WriteLine("==========================");
//         int multiplyResult1 = calc.Multiply(6, 4);
//         Console.WriteLine($"Multiplication: 6 * 4 = {multiplyResult1}");
//         System.Console.WriteLine("==========================");
//         int multiplyResult2 = calc.Multiply(7);
//         Console.WriteLine($"Multiplication: 7 * 1 (default) = {multiplyResult2}");
        
//         Console.WriteLine("\nDemonstrating different method calls:");
//         Console.WriteLine($"Add(20, 30) = {calc.Add(20, 30)}");
//         Console.WriteLine($"Multiply(5, 3) = {calc.Multiply(5, 3)}");
//         Console.WriteLine($"Multiply(9) = {calc.Multiply(9)}");
//     }
// }

// Task 3. Parameters Types
public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }    
    public void GetFullName(out string fullname)
    {
        fullname = "Bibek Shrestha";
    }    
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();
        
        Console.WriteLine("=== Demonstrating ref Parameter ===");
        // Call Increase method with ref parameter
        int myNumber = 25;
        Console.WriteLine($"Before Increase: myNumber = {myNumber}");
        demo.Increase(ref myNumber);
        Console.WriteLine($"After Increase: myNumber = {myNumber}");
        
        Console.WriteLine("\n=== Demonstrating out Parameter ===");
        // Call GetFullName method with out parameter
        string name;
        demo.GetFullName(out name);
        Console.WriteLine($"Full Name: {name}");
        
        Console.WriteLine("\n=== Demonstrating params Parameter ===");
        // Call SumAll method with different number of arguments
        int sum1 = demo.SumAll(5, 10, 15);
        Console.WriteLine($"SumAll(5, 10, 15) = {sum1}");
        
        int sum2 = demo.SumAll(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        Console.WriteLine($"SumAll(1, 2, 3, 4, 5, 6, 7, 8, 9, 10) = {sum2}");
        
        int sum3 = demo.SumAll(100);
        Console.WriteLine($"SumAll(100) = {sum3}");
        
        int sum4 = demo.SumAll();
        Console.WriteLine($"SumAll() with no arguments = {sum4}");
    }
}
