using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class BankException :ApplicationException
    {
        public BankException(string msg) : base(msg)
        {

        } 

    }
    
        class Bank
        {
            int money=32229;
            String acc_name="MR.RISHIKESH";
            String acc_num;
            static String bank_name = "Bank Of Maharashtra";
            static public  int updatedBalance;
            public void depositMoney()
            {
               
                    Console.WriteLine("\nEnter the amount you want to deposit in acount:");
                    int depMoney = int.Parse(Console.ReadLine());
                    
                    if (depMoney == 0)
                    {
                        Console.WriteLine("minimum deposit should be 150 ");
                    }
                    else
                    {
                        updatedBalance = money + depMoney;
                        Console.WriteLine("updated balance of " + acc_name + " after deposit is " + updatedBalance);
                    }
                
            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Welcome " + acc_name + " your accountbalance is: " + updatedBalance);
                    Console.WriteLine("\nEnter the amount you want to withdraw from account:");
                    int withdraw = int.Parse(Console.ReadLine());
                    updatedBalance = updatedBalance - withdraw;
                    if (withdraw > updatedBalance)
                    {
                        Console.WriteLine("insuffiecient balance in your account");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of  " + acc_name + " after withdrawal is " + updatedBalance);
                    }

                }catch (Exception )
                {
                    Console.WriteLine("enter balance in number not in words inputmissmatch exception ");
                }
            }
            public void Balance()
            {
                Console.WriteLine("welcome to the " + bank_name + "bank ");
                Console.WriteLine("Enter account number: ");
                acc_num = Console.ReadLine();
                Console.WriteLine("Welcome " + acc_name + " your accountbalance  is : " + money);

            }
        }
   internal class Program 
    { 
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Balance();
            bank.depositMoney();
            bank.withdrawMoney();
            Console.ReadLine();
        }
    }
}
