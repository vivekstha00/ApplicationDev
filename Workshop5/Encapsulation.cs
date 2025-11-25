// Task 1 - Encapsulation
class BankAccount
{
    private string accountNumber;
    private double balance;

    // Constructor to initialize account number
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        // Use the property to ensure validation
        Balance = initialBalance;
    }

    // Property with only get accessor
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Property with private set and validation
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance must be positive and greater than 0");
            }
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount");
        }
    }
}