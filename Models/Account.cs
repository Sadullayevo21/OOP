namespace Models;
public abstract class Account
{
    public string OwnerName { get; set; }
    public decimal Balance { get; set; }

    public Account(string ownerName, decimal balance)
    {
        OwnerName = ownerName;
        Balance = balance;
    }

    public abstract void Withdraw(decimal amount);

    public virtual void ShowBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}");
        ShowBalance();
    }
}