namespace Models;

public class SavingsAccount : Account
{
    public SavingsAccount(string ownerName, decimal balance) : base(ownerName, balance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Not enough balance");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdraw: {amount}");
            ShowBalance();
        }
    }
}