// 1. different 
class Printer
{
    public void Print()
    {
        Console.WriteLine("Print function without parameters");
    }

    public void Print(string message)
    {
        Console.WriteLine($"{message}");
    }

    public void Print(int number)
    {
        Console.WriteLine($"Number: {number}");
    }

    public void Print(string message, int number)
    {
        for(int i = 0; i<number; i++)
        {
            Console.WriteLine($" {message}");
        }
    }
}

class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine($"Teacher is teaching");
    }
    public virtual void SalaryInfo()
    {
        Console.WriteLine("40,000");
    }
}

class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine($"Nepali teacher is teaching");
    }
    public sealed override void SalaryInfo()
    {
        Console.WriteLine("42,000");
    }
}
class PrimaryNepaliTeacher : NepaliTeacher
{
    // public override void SalaryInfo()
    // {
    // }

}

class EnglishTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine($"English teacher is teaching");
    }
}