using Classes;

var Account = new BankAccount("Vinayak", 10000);
Console.WriteLine($"Account {Account.Number} was created for {Account.Owner} with initial balance {Account.Balance}");