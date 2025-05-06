using System.Globalization;

namespace Classes;

public class BankAccount{
    private static int s_accountNumber = 1234567890;
    public string Number {get;}
    public string Owner {get; set;}
    public Decimal Balance {
        get{
            decimal balance = 0;
            foreach (var item in _allTransactions){
                balance += item.Amount;
            }
            return balance;
        }
    }

    public void MakeDeposit(decimal amount, string note, DateTime date){
        if (amount <= 0){
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transactions(amount, date, note);
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawl(decimal amount, string note, DateTime date){
        if (amount <= 0){
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdraw must be positive");
        }
        if (Balance - amount < 0){
            throw new InvalidOperationException("Not sufficient balance for this transaction");
        }
        var withdraw = new Transactions(amount, date, note);
        _allTransactions.Add(withdraw);
    }

    public string GetAccountHistory(){
        var report = new System.Text.StringBuilder();
        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in _allTransactions){
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }
        return report.ToString();
    }

    // A virtual method is a method where any derived class may choose to reimplement.
    public virtual void PerformEndMonthTransaction(){

    }

    public BankAccount(string name, decimal initialAmount){
        this.Owner = name;
        Number = s_accountNumber.ToString();
        s_accountNumber++;
        MakeDeposit(initialAmount, "Initial balance", DateTime.Now);
    }

    private List<Transactions> _allTransactions = new List<Transactions>();
}