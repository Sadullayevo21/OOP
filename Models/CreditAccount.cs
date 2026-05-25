namespace Models;

public class CreditAccount : Account
{
    public CreditAccount(string ownerName, decimal balance) : base(ownerName, balance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance - amount < -5000)
        {
            Console.WriteLine("Credit limit exceeded");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdraw: {amount}");
            ShowBalance();
        }
    }
}