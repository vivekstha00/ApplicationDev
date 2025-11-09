// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, This is a second class");


//Variables
Console.WriteLine("Variables Example:");
// <data_type> variableName = values;
byte num1 = 100;
int num2 = 25;
long num3 = 500032352353323252L;

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

string firstName = "Vivek";
string lastName = "Sthapit";
string address = "Kathmandu, Nepal";

Console.WriteLine(firstName);
Console.WriteLine(lastName);
Console.WriteLine(address);

// float (f), double (d), decimal (m)
Console.WriteLine("Floating Point Example:");

float percentage = 10.99f;
double percentage2 = 20.99;
decimal percentage3 = 30.99m;

Console.WriteLine(percentage);
Console.WriteLine(percentage2);
Console.WriteLine(percentage3);

char grade = 'A';
Console.WriteLine(grade);

//Type Conversion
// Console.WriteLine("Type Conversion Example:");
// int originalNum = 3;



//arrays 
int[] numbers = { 1, 2, 3, 4, 5 };
Array.Sort(numbers);
Array.Reverse(numbers);
int pos = Array.IndexOf(numbers, 3);
Console.WriteLine("The position of 3 is: " + pos);

//datetime
Console.WriteLine("DateTime Example:");
DateTime timeNow = DateTime.Now;
Console.WriteLine("Current it is: " + timeNow);
Console.WriteLine("Current UTC time is: " + DateTime.UtcNow);

TimeSpan timeDDifference = timeNow - DateTime.UtcNow;
Console.WriteLine("Time difference is: " + timeDDifference);

Console.WriteLine("Difference in minutes is" + timeDDifference.TotalMinutes);

// Current Asia/Kathmandu time is ...., UTC time is .. and time difference is ...

Console.WriteLine($"Current Asia/Kathmandu time is {timeNow}, utc time is {DateTime.UtcNow}, and time difference is {timeDDifference}.");

//parsing
string stringNum = "1234";
int num = int.Parse(stringNum);

int n2 = 7;
Console.WriteLine(num);

int sum = num + n2;
Console.WriteLine("The sum is: " + sum);

Console.WriteLine("Advanced arrays");
int[] numberList = { 2, 4, 6, 8 };
Console.WriteLine($"The number at first index is {numberList[0]}");
//interating each elements of array

for (int i = 0; i < numberList.Length; i++)
{
    Console.WriteLine(numberList[i]);
}
//using foreach
System.Console.WriteLine("Using foreach loop");
foreach (int number in numberList)
{
    Console.WriteLine(number);
}

// char letter = 'A';
// string letter2 = "letter2";

System.Console.WriteLine("Constnats");

const double pi = 3.14;
Console.WriteLine(pi);

double divide = 5 / 2;
Console.WriteLine(divide);