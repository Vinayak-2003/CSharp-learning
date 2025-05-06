using Classes;

public class LineOfCreditAccount : BankAccount{

    public override void PerformEndMonthTransaction(){
        if (Balance < 0){
            decimal interest = -Balance*0.07m;
            MakeWithdrawl(interest, "charge monthly interest", DateTime.Now);
        }
    }

    public LineOfCreditAccount(string name, decimal initialAmount) : base(name, initialAmount){

    }
}