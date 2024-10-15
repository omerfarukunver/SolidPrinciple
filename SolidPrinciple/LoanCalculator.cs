using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    /*  burada open/close a uymuyor. hesaplamalar her bir tip için ayrı ayrı olmamalı. genel bir kuralda olmalı.
    public decimal CalculateLoanInterest(string loanType, decimal amount)
    {
        if (loanType == "Personal")
        {
            return amount * 0.1m;
        }
        else if (loanType == "Mortgage")
        {
            return amount * 0.05m;
        }
        else
        {
            throw new Exception("Geçersiz kredi türü");
        }
    }
     */

    public interface ILoan
    {
        decimal CalculateInterest(decimal amount);
    }

    public class PersonalLoan : ILoan
    {
        public decimal CalculateInterest(decimal amount)
        {
            return amount * 0.1m;
        }
    }

    public class MortgageLoan : ILoan
    {
        public decimal CalculateInterest(decimal amount)
        {
            return amount * 0.05m;
        }
    }

    // burada LoanCalculator her yeni gelen tür için değiştirilmez, LoanCalculator sabittir, yukarıda gelenlerin özellikleri değişir.
    public class LoanCalculator
    {
        public decimal CalculateLoanInterest(ILoan loan, decimal amount)
        {
            return loan.CalculateInterest(amount);
        }
    }
}
