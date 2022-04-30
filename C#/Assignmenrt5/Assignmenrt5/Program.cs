using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Bank
    {
        int money = 32229;
        String name = "MR.RISHIKESH";
        String account_Number;
        static String name_Of_Bank = "Bank of Maharashtra";
        public int updatedBalance;

        public void deposit()
        {
            Console.WriteLine("\nEnter the amount you want to deposit:");
            int depMoney = int.Parse(Console.ReadLine());
            updatedBalance = money + depMoney;
            if (depMoney == 0)
            {
                Console.WriteLine("Minimum deposit of 150 ");
            }
            else
            {
                Console.WriteLine("Updated balance of  after deposit : " + updatedBalance);
            }

        }
        public void withdraw()
        {
            try
            {
                Console.WriteLine("Your account balance: " + updatedBalance);
                Console.WriteLine("\nEnter the amount you want to withdraw:");
                int withdraw = int.Parse(Console.ReadLine());
                updatedBalance = updatedBalance - withdraw;
                if (withdraw > updatedBalance)
                {
                    Console.WriteLine("Insuffiecient balance");
                }
                else
                {
                    Console.WriteLine("Your account updated balance after withdrawal : " + updatedBalance);
                }

            }
            catch (Exception )
            {
                Console.WriteLine("Enter balance in number not in words input missmatch ");
            }
        }

        public void Balance()
        {
            Console.WriteLine("Welcome to the " + name_Of_Bank);
            Console.WriteLine("Enter account number: ");
            account_Number = Console.ReadLine();

            Console.WriteLine("Hello " + name + " your savings account balance: " + money);

        }


        public static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Balance();
            bank.deposit();
            bank.withdraw();


            Console.ReadLine();
        }
    }
}