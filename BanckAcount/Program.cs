// See https://aka.ms/new-console-template for more information

using BanckAcount;

var account1 = new MyAccount("yaser");
var account2 = new MyAccount("miral");

Console.WriteLine($"the account {account1.Number} for {account1.Name} with {account1.Balance}");
Console.WriteLine($"the account {account2.Number} for {account2.Name} with {account2.Balance}");

account1.MakeDip(1000, DateTime.Now, "salary from job");

Console.WriteLine($"your balance is: {account1.Balance}");

account1.MakeWithdrawl(200, DateTime.Now, "money for rent");

Console.WriteLine($"your balance is: {account1.Balance}");