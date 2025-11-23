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
    }

}