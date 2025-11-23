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
    }

}