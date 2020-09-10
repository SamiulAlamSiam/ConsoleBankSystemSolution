using System;
using AddressClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class SavingAccount:Account
    {
        double interest;
        double previousBalance;

        public SavingAccount(string name, string accountId, double balance, int sex, double interest, Address address) : base(name, accountId, balance, sex, address)
        {
            this.interest = interest;
        }

        public SavingAccount()
        {
            interest = 0.15;
            System.Timers.Timer t = new System.Timers.Timer();
            t.Elapsed += CallTimer;
            t.Interval = 1000;
            t.Start();
            Console.WriteLine("Press q to Quit");
            while (DateTime.Now.Second != 10)
            {

            }
            t.Stop();
        }

        public double Interest
        {
            get { return this.interest; }
            set
            {
                if ((value > 0) && (value < 100))
                    this.interest = value;
                else
                    Console.WriteLine("Invalid Input");
            }
        }

        public void CallTimer(object o, EventArgs e)
        {
            previousBalance = Balance;
            Balance = Balance + (Balance * interest);
            Console.WriteLine("new balance : " + Balance);
        }

        public void ShowInfo()
        {
            showAccountDetails();
            Console.WriteLine ("Interest : " + Interest);
        }

        //public string ShowInfo()
        //{
        //    return ("Name :" + Name + "\n" + "Interest" + Interest);
        //}
    }
}
