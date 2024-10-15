using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Responsibility Principle (SRP) Uygulaması
            Console.WriteLine("Single Responsibility Principle (SRP) Örneği");
            Account account = new Account();
            account.Deposit(1000);
            account.Withdraw(200);

            AccountStatementPrinter printer = new AccountStatementPrinter();
            printer.PrintStatement(account);


            // Open-Closed Principle (OCP) Uygulaması
            Console.WriteLine("\nOpen-Closed Principle (OCP) Örneği");
            ILoan personalLoan = new PersonalLoan();
            ILoan mortgageLoan = new MortgageLoan();

            LoanCalculator loanCalculator = new LoanCalculator();

            decimal personalLoanInterest = loanCalculator.CalculateLoanInterest(personalLoan, 5000);
            decimal mortgageLoanInterest = loanCalculator.CalculateLoanInterest(mortgageLoan, 5000);

            Console.WriteLine($"Bireysel Kredi Faizi: {personalLoanInterest}");
            Console.WriteLine($"Konut Kredisi Faizi: {mortgageLoanInterest}");


            // Liskov Substitution Principle (LSP) Uygulaması
            Console.WriteLine("\nLiskov Substitution Principle (LSP) Örneği");
            AccountBase savingsAccount = new SavingsAccount();
            savingsAccount.InterestBoost(2);

            AccountBase fixedDepositAccount = new FixedDepositAccount();
            fixedDepositAccount.InterestBoost(2);

            // Interface Segregation Principle (ISP) Uygulaması 
            Console.WriteLine("\n=== Interface Segregation Principle (ISP) Örneği ===");
            IAccountOperations regularAccount = new RegularAccount();
            regularAccount.Deposit(800);
            regularAccount.Withdraw(300);


            // Dependency Inversion Principle (DIP) Uygulaması
            Console.WriteLine("\nDependency Inversion Principle (DIP)");
            IMessageSender emailSender = new EmailSender();
            NotificationService notificationService = new NotificationService(emailSender);
            notificationService.SendNotification("Hesabınıza 500 TL yatırıldı.");

            Console.ReadLine();
        }
    }
}
