// Task 1 

// class Operator
// {
//     static void Main(string[] ergs)
//     {
//         Console.WriteLine("=======Workhop 3 =======");
//         Addition();
//         Subtraction();
//         Multiplication();
//         Division();
//         OddEvenFinder(7);
//         static void Addition()
//         {
//             int a = 5;
//             int b = 10;
//             int sum = a + b;
//             Console.WriteLine($"Sum of {a} and {b} is: {sum}");
//         }
//         static void Subtraction()
//         {
//             int a = 10;
//             int b = 5;
//             int difference = a - b;
//             Console.WriteLine($"Difference of {a} and {b} is: {difference}");
//         }
//         static void Multiplication()
//         {
//             int a = 5;
//             int b = 10;
//             int product = a * b;
//             Console.WriteLine($"Product of {a} and {b} is: {product}");
//         }
//         static void Division()
//         {
//             int a = 10;
//             int b = 5;
//             int division = a / b;
//             Console.WriteLine($"Division of {a} and {b} is: {division}");
//         }
//         static void OddEvenFinder(int number)
//         {
//             string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
//             Console.WriteLine($"{number} is an {result}");
//         }
//     }
// }


// Task 2

class NullOperations
{

    static void Main(string[] args)
    {
        Console.WriteLine("=======Workhop 3 - Null Operations =======");
        PerformNullChecks();


        static void PerformNullChecks()
        {
            string username = null;

            string firstResult = (username == null) ? "Username is not available" : username;
            Console.WriteLine($"Ternary Check: {firstResult}");

            string secondResult = username ?? "Username is not available";
            Console.WriteLine($"Null-Coalescing Check: {secondResult}");

            username ??= "vivekstha99";
            Console.WriteLine($"After Null-Coalescing Assignment: {username}");
        }
    }
}


    
