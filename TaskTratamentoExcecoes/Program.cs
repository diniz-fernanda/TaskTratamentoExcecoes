
using System.Globalization;
using TaskTratamentoExcecoes.Entities;
using TaskTratamentoExcecoes.Entities.Exception;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account account = new Account(number, holder, balance, withdrawLimit);

Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    account.Withdraw(amount);
    Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch(DomainException erro)
{
    Console.WriteLine("Withdraw error:" + erro.Message);
}