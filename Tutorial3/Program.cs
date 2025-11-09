using System.Diagnostics.Metrics;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Tutorial 3 ======");
            Console.Write("Enter the method num you want to run: ");
            Console.WriteLine("1. Unary Operator");
            Console.WriteLine("2. Binary Operator");
            Console.WriteLine("3. Ternary Operator");
            Console.WriteLine("4. Null Coalescing Operator");
            Console.WriteLine("5. Conditional Statement");
            Console.WriteLine("6. Loops");
            Console.WriteLine("7. Jump Statement");
            Console.WriteLine("8. Exception Handling");
            Console.Write("Enter your choice (1-8): ");

            string? chooseNumber = Console.ReadLine();
            Console.WriteLine();

            switch (chooseNumber)
            {
                case "1":
                    UnaryOperator();
                    break;
                case "2":
                    BinaryOperator();
                    break;
                case "3":
                    TernaryOperator();
                    break;
                case "4":
                    NullCoalescingOperator();
                    break;
                case "5":
                    ConditionalStatement();
                    break;
                case "6":
                    Loops();
                    break;
                case "7":
                    JumpStatement();
                    break;
                case "8":
                    ExceptionHandeling();
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 8.");
                    break;
            }
            
        }

        // Unary Operators: +, -, ++, --, !
        static void UnaryOperator()
        {
            Console.WriteLine("*****************Unary Operator ");
            Console.WriteLine("Post Increment(x++)");
            int x = 10;
            int y = x++;
            Console.WriteLine($"x ={x}, y ={y}");  // x = 11, y = 10

            Console.WriteLine("Pre Increment(++x)");
            int a = 10;
            int b = ++a;
            Console.WriteLine($"a ={a}, b ={b}");  // a = 11, b = 11

            Console.WriteLine("Decrement Operation");
            int m = 10;
            int n = m--;
            Console.WriteLine($"m ={m}, n ={n}");  // m = 9, n = 10

            Console.WriteLine("Logical");
            bool isRaining = false;
            Console.WriteLine($"isRaining: {isRaining}, !isRaining: {!isRaining}");
            
        }
        // Binary Operators: +, -, *, /, %, ==, !=, >, <, >=, <=, &&, ||
        static void BinaryOperator()
        {
            Console.WriteLine("********************Binary Operator ");
            int score = 100;

            Console.WriteLine($"initial value: {score}");
            score -= 10;  // score = score - 10
            Console.WriteLine($"After -10: " + score);

            score += 5;  // score = score + 5
            Console.WriteLine($"After +5: " + score);

            score *= 2;  // score = score * 2
            Console.WriteLine($"After *2: " + score);

            score /= 2;  // score = score / 2
            Console.WriteLine($"After /2: " + score);

            score %= 5;  // score = score % 5
            Console.WriteLine($"After %5: " + score);

            System.Console.WriteLine("Relational Operators:");

            int age = 25;
            Console.WriteLine($"Initial value of age is {age}");
            Console.WriteLine($"Age  == 25: {age == 25}");
            Console.WriteLine($"Age  != 25: {age != 25}");
            Console.WriteLine($"Age  > 30: {age > 30}");
            Console.WriteLine($"Age  < 30: {age < 30}");
            Console.WriteLine($"Age  >= 25: {age >= 25}");
            Console.WriteLine($"Age  <= 25: {age <= 25}");


            System.Console.WriteLine("Logical Operators:");
            bool hasLicense = true;
            int diverAge = 20;
            bool canDrive = hasLicense && diverAge > 18;
            Console.WriteLine($"Can drive: {canDrive}");
        }
        // Ternary Operator: condition ? first_expression : second_expression
        static void TernaryOperator()
        {
            System.Console.WriteLine("*************************Ternary Operator:");
            int userAge = 88;
            string ageType = userAge > 18 ? "Adult" : "Not Adult";
            Console.WriteLine($"The user is  {ageType}");

            string ageGroup = userAge < 18 ? "Minor" : (userAge > 60) ? "Senior Citizen" : "Adult";
            Console.WriteLine($"The user is  {ageGroup}");
        }
        // Null Coalescing Operator: ?? (returns the left-hand operand if it is not null; otherwise, it returns the right operand)
        static void NullCoalescingOperator()
        {
            System.Console.WriteLine("*************************Null Coalescing Operator:");
            string? studentName = null;
            Console.WriteLine(studentName ?? "Vivek");
        }
        // Conditional Statements: if, else if, else, switch
        static void ConditionalStatement()
        {
            System.Console.WriteLine("*************************Conditional Statement:");
            double temperature = 18;
            if (temperature <= 16)
            {
                Console.WriteLine($"Temperature is below 16 so avoid visiting outside.");
            }
            else if (temperature <= 20)
            {
                Console.WriteLine($"Get some warm clothes before going outside.");
            }
            else
            {
                Console.WriteLine($" You can go outside if you need.");
            }

            Console.WriteLine("Switch Statement");
            int dayNumber = 2;
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                default:
                    Console.WriteLine("YOu entered incorrect day value");
                    break;
            }
        }

        // Loops: for, while, do-while, foreach
        static void Loops()
        {
            System.Console.WriteLine("*************************Loops:");

            Console.WriteLine("While Loop:");
            int count = 1;
            int sum = 0;
            while (count <= 5)
            {
                Console.WriteLine($"Count: {count}");
                sum = sum + count; // sun += count; 
                count++;

            }
            Console.WriteLine($"Sum: {sum}");

        }
        // Jump Statements: break, continue
        static void JumpStatement()
        {
            System.Console.WriteLine("*************************Jump Statement:");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    break; // Exit the loop when i is 3
                }
                Console.WriteLine($"i: {i}");
            }
            Console.WriteLine("Using Continue Statement:");
            for (int j = 0; j <= 5; j++)
            {
                if (j == 3)
                {
                    continue; // Skip the iteration when j is 3
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine("Odd number using jump statement from 1 to 10");
            for (int j = 1; j <= 10; j++)
            {
                if (j % 2 == 0)
                {
                    continue; // Skip even numbers
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
        }

        // Exception Handeling
        static void ExceptionHandeling()
        {
            Console.WriteLine("*************************Exception Handeling");

            int a = 5;
            int b = 1;
            try
            {
                int divide = a / b;
                Console.WriteLine(divide);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tring to divide by zero ");
            }
            finally
            {
                Console.WriteLine("You have completed exception handling block");
            }
        }
    }
}