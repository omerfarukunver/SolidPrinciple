using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public abstract class AccountBase
    {
        /* Burada InterestBoost u bu şekilde kullanamayız. çünkü vadesiz hesapta faiz olmaz. Liskov Substitution Principle  a uymaz.
        public virtual void InterestBoost(decimal interestrate)
        {
            // Faiz Değiştirme İşlemi
        }
        */

        public abstract void InterestBoost(decimal interestrate);
    }

    public class FixedDepositAccount : AccountBase
    {
        public override void InterestBoost(decimal interestrate)
        {
            Console.WriteLine($"Vadeli hesabının faiz oranı {interestrate} olarak değiştirildi.");
        }
    }

    public class SavingsAccount : AccountBase
    {
        public override void InterestBoost(decimal interestrate)
        {
            Console.WriteLine("Tasarruf hesabında faiz olmaz!");
        }
    }
}
