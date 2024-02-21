using System.Globalization;
using ConsoleWithdraw.Entities;
using ConsoleWithdraw.Entities.Exceptions;

Console.WriteLine("Enter account data:");
Console.Write("Number: ");
int accountNumber = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string AccountHolder = Console.ReadLine();
Console.Write("Initial balance: ");
double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account account = new Account(accountNumber, AccountHolder, initialBalance, withdrawLimit);

Console.Write("Enter amount for withdraw: ");
double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    Console.WriteLine(account.Withdraw(withdrawAmount).ToString("F2"));
}
catch(DomainException exception)
{
    Console.WriteLine(exception.Message);
}
