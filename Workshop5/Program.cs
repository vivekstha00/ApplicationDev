// Workshop 5 Encapsulation, Inheritance, Polymorphism, Abstraction

class Program
{
    static void Main(string[] args)
    {
        // ENCAPSULATION 
        Console.WriteLine("1. ENCAPSULATION EXAMPLE:");
        Console.WriteLine("------------------------------------------");
        
        BankAccount account = new BankAccount("ACC-12345", 5000);
        
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Initial Balance: {account.Balance}");
        
        account.Deposit(2000);
        Console.WriteLine($"Balance after deposit: {account.Balance}");
        
        account.Withdraw(1500);
        Console.WriteLine($"Balance after withdrawal: {account.Balance}");
        
        Console.WriteLine($"Remaining Balance: {account.Balance}");
        
        Console.WriteLine("\nTrying invalid operations:");
        account.Deposit(-500);  // Invalid
        account.Withdraw(10000); // Invalid - exceeds balance
        
        Console.WriteLine($"Final Balance: {account.Balance}\n");

        // INHERITANCE
        Console.WriteLine("2. INHERITANCE EXAMPLE:");
        Console.WriteLine("------------------------------------------");
        
        Console.WriteLine("\nCar Object:");
        Car car = new Car();
        car.Brand = "Toyota";
        car.Speed = 180;
        car.Seats = 5;
        car.Start();
        car.DisplayInfo();
        car.Stop();
        
        Console.WriteLine("\nMotorcycle Object:");
        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Brand = "Harley Davidson";
        motorcycle.Speed = 200;
        motorcycle.HasSidecar = false;
        motorcycle.Start();
        motorcycle.DisplayInfo();
        motorcycle.Stop();
        
        Console.WriteLine();

        // POLYMORPHISM METHOD OVERLOADING
         Console.WriteLine("3. POLYMORPHISM - METHOD OVERLOADING:");
        Console.WriteLine("------------------------------------------");
        
        Printer printer = new Printer();
        
        printer.Print("Hello, Workshop!");
        printer.Print(42);
        printer.Print("Welcome", 3);
        
        Console.WriteLine();

        // POLYMORPHISM METHOD OVERRIDING
        Console.WriteLine("4. POLYMORPHISM - METHOD OVERRIDING:");
        Console.WriteLine("------------------------------------------");
        
        Console.WriteLine("\nNepali Teacher:");
        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Ram Prasad";
        nepaliTeacher.Teaching();
        nepaliTeacher.SalaryInfo();
        
        Console.WriteLine("\nEnglish Teacher:");
        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Name = "Krishna Poudel";
        englishTeacher.Teaching();  // Uses base class implementation
        englishTeacher.SalaryInfo();
        

    }
}