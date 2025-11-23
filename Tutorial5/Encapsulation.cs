class BadBankAccount
{
    public string accountNumber;
    public double balance;
}

class GoodBankAccount
{
    private string accountNumber;
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
        }
        else
        {
            Console.WriteLine("Invalid amount ");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Invalid withdrawl amount");
        }
    }

    public double Balance
    {
        get {
            return balance;
        }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }

        }
    }
}