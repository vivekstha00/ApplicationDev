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

class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    // sealed method - cannot be overridden by child classes
    public  void SalaryInfo()
    {
        Console.WriteLine("Teacher salary information is confidential");
    }
}

class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine($"{Name} teaches in Nepali");
    }
}

class EnglishTeacher : Teacher
{
    // Not overriding Teaching() method - will use base class implementation
}
