namespace Conta_Bancaria;

class Conta {

    private string _holder;
    public long Number { get; private set; }
    public int Digit { get; private set; }

    public Conta(string holder, long number, int digit) {
        _holder = holder;
        Number = number;
        Digit = digit;
    }

    public string GetOlder() {
        return _holder;
    }
    public void SetOlder(string holder) { 
        if(holder != null & holder.Length > 1) {
            this._holder = holder;
        }
    }
}