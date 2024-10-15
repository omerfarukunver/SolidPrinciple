using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    /* Single Responsibility ye uymayan alan. bir class sadece 1 iş yapabilmeli
    public void Deposit(decimal amount)
    {
        // Para yatırma işlemi
    }

    public void Withdraw(decimal amount)
    {
        // Para çekme işlemi
    }

    public void PrintStatement()
    {
        // Hesap ekstresi yazdırma işlemi
    }
    */

    public class Account
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Hesaba {amount} miktarında para yatırıldı.");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Hesabtan {amount} miktarında para çekildi.");
        }
    }

    public class AccountStatementPrinter
    {
        public void PrintStatement(Account account)
        {
            // Hesap ekstresi yazdırma işlemi
        }
    }
}
