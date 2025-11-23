class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("This is Tutorial 5");

        System.Console.WriteLine("Encapsulation Example:");

        BadBankAccount badAccount = new BadBankAccount();
        badAccount.balance = 10000;
        badAccount.balance = -9999;
        badAccount.accountNumber = "";
        Console.WriteLine($"{badAccount.accountNumber} has balance {badAccount.balance}");

        Console.WriteLine("Good Bank Account:");

        GoodBankAccount goodBankAccount = new GoodBankAccount();
        goodBankAccount.Balance = 1000;
        Console.WriteLine($"Good account balance: {goodBankAccount.Balance}");
        goodBankAccount.Balance = -999; 
        Console.WriteLine($"Good account balance after invalid update: {goodBankAccount.Balance}");

        goodBankAccount.Deposit(500);
        goodBankAccount.Withdraw(200);
        Console.WriteLine($"{goodBankAccount.Balance}");


        System.Console.WriteLine("Inheritance Example:");
        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Speed = 170;
        car1.Seats = 4;
        car1.Start();
        car1.Stop();
        car1.DisplayInfo();

        Bike bike1 = new Bike();
        bike1.Brand = "Yamaha";
        bike1.Speed = 120;
        bike1.HasCarrier = true;
        bike1.Start();
        bike1.Stop();
        bike1.DisplayInfo();


        System.Console.WriteLine("Polymorphism Example:");
        Printer printer1 = new Printer();
        printer1.Print();
        printer1.Print("Hello, World!");
        printer1.Print(42);
        printer1.Print("Hello", 3);

        System.Console.WriteLine(" Runtime Polymorphism Example:");
        NepaliTeacher t1 = new NepaliTeacher();
        t1.Teaching();
        EnglishTeacher t2 = new EnglishTeacher();
        t2.Teaching();

        Console.WriteLine("Abstraction Example:");
        Bus bus1 = new Bus();
        bus1.Display();
        bus1.StartEngine();
        bus1.StopEngine();

        SuperBike bike2 = new SuperBike();
        bike2.Display();
        bike2.StartEngine();
        bike2.StopEngine();

    }

}