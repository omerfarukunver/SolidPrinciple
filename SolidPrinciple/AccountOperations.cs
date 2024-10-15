using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    /* Burada GetLoan işlemini standart bir accountta mecbur bırakıyoruz. oysaki normal bir account kredi çekememeli
        public interface IBankOperations
        {
            void Deposit(decimal amount);
            void Withdraw(decimal amount);
            void GetLoan(decimal amount);
        }

        public class RegularAccount : IBankOperations
        {
            public void Deposit(decimal amount)
            {
                // Para yatırma
            }

            public void Withdraw(decimal amount)
            {
                // Para çekme
            }

            public void GetLoan(decimal amount)
            {
                throw new NotImplementedException();
            }
        }
    */
    public interface IAccountOperations
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    public interface ILoanOperations // burada interface ayırarak Interface Segregation Principle e uygun hale getiriyoruz.
    {
        void GetLoan(decimal amount);
    }

    public class RegularAccount : IAccountOperations
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Normal hesaba {amount} TL yatırıldı.");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Normal hesaptan {amount} TL çekildi.");
        }
    }
}
