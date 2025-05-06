using Classes;

public class GiftCardAccount : BankAccount{

    private readonly decimal _monthlyDeposit = 0m;

    public override void PerformEndMonthTransaction(){
        if (_monthlyDeposit != 0){
            MakeDeposit(_monthlyDeposit, "monthly deposit added", DateTime.Now);
        }
    }

    public GiftCardAccount(string name, decimal initialAmount, decimal monthlyDeposit = 0) : 
    base(name, initialAmount) => _monthlyDeposit = monthlyDeposit;
}