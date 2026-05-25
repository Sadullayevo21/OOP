using Models;

SavingsAccount savings = new SavingsAccount("Ali", 1000);

savings.ShowBalance();
Console.WriteLine();

savings.Deposit(500);
Console.WriteLine();

savings.Withdraw(300);
Console.WriteLine();

savings.Withdraw(2000);
Console.WriteLine();

CreditAccount credit = new CreditAccount("Vali", 0);

credit.Withdraw(6000);