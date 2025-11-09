// TASK - 1

string userName = "Vivek";
int luckyNumber = 5;

Console.WriteLine($"Hello it's me {userName} and my luckky number is {luckyNumber}");


// TASK - 2


class Circle{
    static void Main()
    {
        const double pi = 3.14;
        double radius = 4.0;

        double area = pi * radius * radius;
        double perimeter = 2 * pi * radius;

        Console.WriteLine($"The Radius of the circle is {radius}");

        Console.WriteLine($"The Area of the circle is {area}");

        Console.WriteLine($"The Perimeters of the circle is {perimeter}");
    }

}

// TASK - 3

// byte byteNum = 25;
// short shortNum = 321;
// int intNum = 42;
// long longNum = 1290L;
// float floatNum = 50.99f;
// double doubleNum = 32.19;
// decimal decimalNum = 19.99m;
// char charNum = 'A';
// bool boolNum = true;

// int num = 42;
// string intToString = num.ToString();

// string stringNum = "3.14";
// double stringToDouble = Convert.ToDouble(stringNum);

// Console.WriteLine("=== Data Types and Type Conversion ===");
// Console.WriteLine($"byteNum (byte): {byteNum}");
// Console.WriteLine($"shortNum (short): {shortNum}");
// Console.WriteLine($"intNum (int): {intNum}");
// Console.WriteLine($"longNum (long): {longNum}");
// Console.WriteLine($"floatNum (float): {floatNum}");
// Console.WriteLine($"doubleNum (double): {doubleNum}");
// Console.WriteLine($"decimalNum (decimal): {decimalNum}");
// Console.WriteLine($"charNum (char): {charNum}");
// Console.WriteLine($"boolNum (bool): {boolNum}");
// Console.WriteLine();
// Console.WriteLine($"Converted int to string: {intToString}");
// Console.WriteLine($"Converted string to double: {stringToDouble}");


// TASK 4

// int[] favoriteNumbers = { 23, 7, 42, 15, 9 };

// Console.WriteLine("Original Array:");
// for (int i = 0; i < favoriteNumbers.Length; i++)
// {
//     Console.Write(favoriteNumbers[i] + " ");
// }

// Array.Sort(favoriteNumbers);
// Console.WriteLine("\nSorted Array (Ascending):");
// for (int i = 0; i < favoriteNumbers.Length; i++)
// {
//     Console.Write(favoriteNumbers[i] + " ");
// }

// Array.Reverse(favoriteNumbers);
// Console.WriteLine("\nReversed Array (Descending):");
// for (int i = 0; i < favoriteNumbers.Length; i++)
// {
//     Console.Write(favoriteNumbers[i] + " ");
// }

// int index = Array.IndexOf(favoriteNumbers, 15);
// Console.WriteLine($"\nNumber 15 found at index: {index}");

// TASK 5

// DateTime birthDate = new DateTime(2003, 5, 10); 
// DateTime currentDate = DateTime.Now; 

// TimeSpan ageSpan = currentDate - birthDate;
// int ageInYears = (int)(ageSpan.Days / 365.25); 

// Console.WriteLine($"Birthdate: {birthDate}");
// Console.WriteLine($"Current Date: {currentDate}");
// Console.WriteLine($"Your Age: {ageInYears} years");

// DateTime newDate = birthDate.AddDays(10);
// Console.WriteLine($"Birthdate + 10 days: {newDate}");


// TASK 6


// List<string> fruits = new List<string>() { "Apple", "Mango", "Banana" };

// fruits.Add("Orange");

// fruits.Remove("Mango");

// Console.WriteLine("=== Favorite Fruits ===");
// foreach (string fruit in fruits)
// {
//     Console.WriteLine(fruit);
// }

// Dictionary<int, string> fruitDict = new Dictionary<int, string>()
// {
//     { 1, "Apple" },
//     { 2, "Banana" },
//     { 3, "Orange" }
// };

// fruitDict.Add(4, "Pineapple");

// Console.WriteLine("\n=== Fruit Dictionary ===");
// foreach (KeyValuePair<int, string> item in fruitDict)
// {
//     Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
// }

