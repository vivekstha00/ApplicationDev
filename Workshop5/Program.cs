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
    }
}