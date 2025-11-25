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
        
        // Abstraction
        Console.WriteLine("5. ABSTRACTION EXAMPLE:");
        Console.WriteLine("------------------------------------------");
        
        Console.WriteLine("\nCar (Abstract):");
        CarAbstract car2 = new CarAbstract();
        car2.Display();
        car2.StartEngine();
        car2.StopEngine();
        
        Console.WriteLine("\nBike (Abstract):");
        BikeAbstract bike = new BikeAbstract();
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();
        
        Console.WriteLine();

        Console.WriteLine("6. COMPREHENSIVE OOP EXERCISE:");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Electronics Store Management System\n");
        
        // Create ElectronicsStore
        ElectronicsStore store = new ElectronicsStore();
        
        // Create devices
        Laptop laptop1 = new Laptop("Dell", 1200.00);
        Laptop laptop2 = new Laptop("HP", 950.00);
        Smartphone smartphone1 = new Smartphone("Samsung", 800.00);
        Smartphone smartphone2 = new Smartphone("iPhone", 1100.00);
        
        // Add devices to store
        Console.WriteLine("Adding devices to store:");
        store.AddDevice(laptop1);
        store.AddDevice(laptop2);
        store.AddDevice(smartphone1);
        store.AddDevice(smartphone2);
        
        // Display all devices with child-specific methods
        store.ShowAllDeviceDetails();
        
        // Remove a device
        Console.WriteLine("\nRemoving HP laptop from store:");
        store.RemoveDevice(laptop2);
        
        // Display updated inventory
        store.ShowAllDeviceDetails();

    }
}