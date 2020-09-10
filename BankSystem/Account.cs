using System;
using AddressClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    enum Gender
    {
        Male=1,
        Female
    }
    class Account
    {
        string name;
        string accountId;
        double balance;
        Gender gender;
        DateTime createDate=new DateTime();
        Address address;

        public Account(string name, string accountId, double balance,int sex,Address address)
        {
            this.name = name;
            this.accountId = accountId;
            this.balance = balance;
            createDate = DateTime.Now;
            if (sex == 1)
                gender = Gender.Male;
            else if (sex == 2)
                gender = Gender.Female;
            this.address = address;
        }

        public Account()
        {
            createDate = DateTime.Now;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!value.Equals(""))
                    this.name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
            //set { this.name = value; }
        }

        public string AccountId
        {
            get { return this.accountId; }
            set
            {
                if (!value.Equals(""))
                    this.accountId = value;
            }
            //set { this.name = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public bool WithDraw(double amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
                return false;
        }

        public bool Deposit(double amount)
        {
            if (amount>0)
            {
                balance += amount;
                return true;
            }
            else
                return false;
        }

        public void Transfer(double amount,Account receiver)
        {
            if ((this.balance > amount) && (amount > 0))
            {
                this.balance -= amount;
                receiver.balance += amount;
            }
            else
                Console.WriteLine("Invalid - Amount Transfer ");
        }

        public void showAccountDetails()
        {
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Account Id : " + this.accountId);
            Console.WriteLine("Balance : " + this.balance);
            Console.WriteLine("Create Date : " + this.createDate);
            Console.WriteLine("Gender :" + gender);
            Console.WriteLine("\nAddress :" );
            address.showAddress();

        }

    }

    
}
