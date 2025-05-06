using Classes;

public class InterestEarningAccount : BankAccount{

    public override void PerformEndMonthTransaction(){
        if (Balance > 500m){
            decimal interest = Balance * 0.02m;
            MakeDeposit(interest, "added monthly interest", DateTime.Now);
        }
    }

    public InterestEarningAccount(string name, decimal initialAmount) : base(name, initialAmount){

    }
}