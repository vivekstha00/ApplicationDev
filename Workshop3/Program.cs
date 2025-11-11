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

// class NullOperations
// {

//     static void Main(string[] args)
//     {
//         Console.WriteLine("=======Workhop 3 - Null Operations =======");
//         PerformNullChecks();


//         static void PerformNullChecks()
//         {
//             string username = null;

//             string firstResult = (username == null) ? "Username is not available" : username;
//             Console.WriteLine($"Ternary Check: {firstResult}");

//             string secondResult = username ?? "Username is not available";
//             Console.WriteLine($"Null-Coalescing Check: {secondResult}");

//             username ??= "vivekstha99";
//             Console.WriteLine($"After Null-Coalescing Assignment: {username}");
//         }
//     }
// }

// Task 3 and 4

// class ConditionalStatement
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("=======Conditional Statement =======");
//         // Age();
//         Day();
//         static void Age()
//         {
//             Console.Write("Enter your age: ");
//             int age = Convert.ToInt32(Console.ReadLine());

//             if (age < 13)
//             {
//                 Console.WriteLine("Child");
//             }
//             else if (age >= 13 && age <= 19)
//             {
//                 Console.WriteLine("Teenager");
//             }
//             else if (age >= 20)
//             {
//                 Console.WriteLine("Adult");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input.");
//             }
//         }

//         static void Day()
//         {
//             Console.Write("Enter a number (1-7) to get the corresponding day of the week: ");
//             int dayNumber = Convert.ToInt32(Console.ReadLine());

//             switch (dayNumber)
//             {
//                 case 1:
//                     Console.WriteLine("Sunday");
//                     break;
//                 case 2:
//                     Console.WriteLine("Monday");
//                     break;
//                 case 3:
//                     Console.WriteLine("Tuesday");
//                     break;
//                 case 4:
//                     Console.WriteLine("Wednesday");
//                     break;
//                 case 5:
//                     Console.WriteLine("Thursday");
//                     break;
//                 case 6:
//                     Console.WriteLine("Friday");
//                     break;
//                 case 7:
//                     Console.WriteLine("Saturday");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
//                     break;
//             }
//         }
//     }
// }

// Task 5
class Loop
{
    static void Main(String[] args)
    {
        Console.WriteLine("=======Loops =======");
        ForLoop();
        WhileLoop();
        Array();
        static void ForLoop()
        {
            Console.Write("Enter a number N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {N}: {sum}");
            Console.WriteLine();
        }
        static void WhileLoop()
        {
            int number = 1;

            while (number <= 20)
            {
                if (number == 15)
                {
                    break;
                }
                if (number % 4 == 0)
                {
                    number++;
                    continue;
                }
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine();
        }
        static void Array()
        {
            int[] numbers = { 2, 5, 8, 10, 3, 7 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Array elements: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Sum of all elements: {sum}");
        }

    }
}
    
