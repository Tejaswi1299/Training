using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Accounts
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public char TransactionType;
        public int Amount;
        public int Balance = 10000;
        public char deposit = 'd';
        public char withdrawal = 'w';


        static void Main(string[] args)
        {
            Accounts bank = new Accounts(112233, "Tejaswi", "CurrentAcc");

            Console.WriteLine("Account Details");
            bank.ShowData();

            Console.WriteLine("Please enter the transaction Type (d for deposit / w for withdrawal) :");
            bank.TransactionType = Convert.ToChar(Console.ReadLine()); // "d"/ "w"

            Console.WriteLine("enter the amount : ");
            bank.Amount = Convert.ToInt32(Console.ReadLine());


            bank.Balance = bank.TransType(bank.Amount, bank.TransactionType);
            Console.WriteLine("After the Transaction the Account Details are : ");
            bank.ShowData();

            Console.ReadKey();


        }

        public Accounts(int accNo, string name, string accType)
        {
            AccountNo = accNo;
            CustomerName = name;
            AccountType = accType;
        }

        public int TransType(int amt, char transactionType)
        {
            if (transactionType == deposit)
            {
                Console.WriteLine("Amount Credited : " + amt);
                return AmtCredit(amt);
            }

            else if (transactionType == withdrawal)
            {
                Console.WriteLine("Amount Debited : " + amt);
                return AmtDebit(amt);
            }

            else
            {
                Console.WriteLine("Enter valid Transaction Type : ");
                return 0;
            }

        }

        public int AmtCredit(int amtValue)
        {
            Balance = Balance + amtValue;
            return Balance;
        }

        public int AmtDebit(int amtValue)
        {
            Balance = Balance - amtValue;
            return Balance;
        }

        public void ShowData()
        {
            Console.WriteLine("Acc No :{0}\nCustomer Name :{1}\nAcc type : {2}\nbalance : {3}", AccountNo, CustomerName, AccountType, Balance);
        }
    }
}
