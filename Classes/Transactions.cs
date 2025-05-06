namespace Classes;

public class Transactions{
    public Decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transactions(Decimal amount, DateTime date, String note){
        Amount = amount;
        Date = date;
        Notes = note;
    }
}