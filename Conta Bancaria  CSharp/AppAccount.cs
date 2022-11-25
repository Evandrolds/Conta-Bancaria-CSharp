using Account_Banck;
using System;
using System.Globalization;


namespace Conta_Bancaria_CSharp {
     class AppAccount {
        static void Main(string[] args) {
            Account c = new Account("Sandro", 12457L, 2, 0.0);
            Console.WriteLine(c.ToString());
            c.Deposit(500.0);
            Console.WriteLine(c);

            c.ToWithdraw(100.0);
            Console.WriteLine(c);
        }

    }
}
