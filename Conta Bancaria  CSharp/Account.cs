using System.Globalization;

namespace Account_Banck;

class Account {

    private string _holder;
    public long Number { get; private set; }
    public int Digit { get; private set; }
    public double Balance { get; private set; }

    public Account(string holder, long number, int digit,double banlance) {
        _holder = holder;
        Number = number;
        Digit = digit;
        Balance = banlance;
    }

    public string GetOlder() {
        return _holder;
    }
    public void SetOlder(string holder) { 
        if(holder != null && holder.Length > 1) {
            this._holder = holder;
        }
    }
    override
    public string ToString() {
        return " Holder: " + _holder 
            + "\n Account number: " + Number 
            + "\n Digit: " + Digit
            + "\n Banlace R$ " + Balance.ToString("F2",CultureInfo.InvariantCulture)
            +"\n";
    }
    public void ToWithdraw(double amount) {
        this.Balance -= amount;
    }
    public void Deposit (double amount) {
        this.Balance += amount; 
    }
}