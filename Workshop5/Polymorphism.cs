// POLYMORPHISM METHOD OVERLOADING
class Printer
{
    public void Print(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    public void Print(int number)
    {
        Console.WriteLine($"Number: {number}");
    }

    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{message}");
        }
    }
}
