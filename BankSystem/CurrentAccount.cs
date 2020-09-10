using System;
using AddressClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class CurrentAccount:Account
    {
        public CurrentAccount(string name, string accountId, double balance, int sex, Address address) : base(name, accountId, balance, sex, address)
        {

        }
        public void ShowDetails()
        {
            showAccountDetails();
        }
    }
}
