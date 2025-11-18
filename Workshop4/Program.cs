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
// public class ParameterDemo
// {
//     public void Increase(ref int number)
//     {
//         number += 10;
//     }    
//     public void GetFullName(out string fullname)
//     {
//         fullname = "Bibek Shrestha";
//     }    
//     public int SumAll(params int[] numbers)
//     {
//         int sum = 0;
//         foreach (int num in numbers)
//         {
//             sum += num;
//         }
//         return sum;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         ParameterDemo demo = new ParameterDemo();
        
//         Console.WriteLine("=== Demonstrating ref Parameter ===");
//         // Call Increase method with ref parameter
//         int myNumber = 25;
//         Console.WriteLine($"Before Increase: myNumber = {myNumber}");
//         demo.Increase(ref myNumber);
//         Console.WriteLine($"After Increase: myNumber = {myNumber}");
        
//         Console.WriteLine("\n=== Demonstrating out Parameter ===");
//         // Call GetFullName method with out parameter
//         string name;
//         demo.GetFullName(out name);
//         Console.WriteLine($"Full Name: {name}");
        
//         Console.WriteLine("\n=== Demonstrating params Parameter ===");
//         // Call SumAll method with different number of arguments
//         int sum1 = demo.SumAll(5, 10, 15);
//         Console.WriteLine($"SumAll(5, 10, 15) = {sum1}");
        
//         int sum2 = demo.SumAll(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
//         Console.WriteLine($"SumAll(1, 2, 3, 4, 5, 6, 7, 8, 9, 10) = {sum2}");
        
//         int sum3 = demo.SumAll(100);
//         Console.WriteLine($"SumAll(100) = {sum3}");
        
//         int sum4 = demo.SumAll();
//         Console.WriteLine($"SumAll() with no arguments = {sum4}");
//     }
// }

// Task 4 Constructor
// Player.cs (or add this to your Program.cs file)
// public class Player
// {
//     // Instance fields
//     public string playerName = "";
//     public int level;
//     public int health;
    
//     // Default constructor
//     public Player()
//     {
//         Console.WriteLine("Default constructor has been called");
//     }
    
//     // Parameterized constructor
//     public Player(string playerName, int level, int health)
//     {
//         this.playerName = playerName;
//         this.level = level;
//         this.health = health;
//     }
// }

// // Program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create object using default constructor
//         Console.WriteLine("Creating player1 with default constructor:");
//         Player player1 = new Player();        
//         Console.WriteLine($"Player Name: {player1.playerName}");
//         Console.WriteLine($"Level: {player1.level}");
//         Console.WriteLine($"Health: {player1.health}");      
//         // Create object using parameterized constructor
//         Player player2 = new Player("Rohan", 25, 100);
        
//         Console.WriteLine($"Player Name: {player2.playerName}");
//         Console.WriteLine($"Level: {player2.level}");
//         Console.WriteLine($"Health: {player2.health}");
        
//         // Additional demonstration
//         Player player3 = new Player("Danny", 30, 85);
//         Console.WriteLine($"Player Name: {player3.playerName}");
//         Console.WriteLine($"Level: {player3.level}");
//         Console.WriteLine($"Health: {player3.health}");
//     }
// }

//Task 6 Debugging

// Program.cs - Debugging Practice
class Program
{
    static void Main(string[] args)
    {
        int marks = 0;
        int total = 0;
        
        // Input marks using TryParse
        Console.Write("Enter marks obtained: ");
        int.TryParse(Console.ReadLine(), out marks);
        
        // Input total using TryParse
        Console.Write("Enter total marks: ");
        int.TryParse(Console.ReadLine(), out total);
                
        double percentage = marks / total * 100;
                
        Console.WriteLine($"Percentage: {percentage}%");
        
        
        Console.WriteLine("\n WHY WRONG?");
        Console.WriteLine("Integer division! 85/100 = 0, then 0*100 = 0%");
    
        Console.WriteLine("\nFIX:");
        double correct = (double)marks / total * 100;
        Console.WriteLine($"Cast to double: (double)marks / total * 100 = {correct}%");
    }
}