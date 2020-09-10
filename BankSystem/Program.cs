using System;
using AddressClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            


            Console.WriteLine("Press 1 for Saving Account & Press 2 for Current Account ");
            int check = Int32.Parse(Console.ReadLine());

            
            

            Address ad = new Address();
            Console.Write("Enter 1st Area :");
            ad.Ares = Console.ReadLine();
            Console.Write("Enter 1st City :");
            ad.City = Console.ReadLine();
            Console.Write("Enter 1st House No :");
            ad.HouseNo = Console.ReadLine();
            Console.Write("Enter 1st Road No :");
            ad.RoadNo = Int32.Parse(Console.ReadLine());

            SavingAccount sa = new SavingAccount("", "", -1, 0, 1, ad);



            Console.WriteLine("\n");


            Console.Write("Enter 1st Name :");
            string name = Console.ReadLine();

            Console.Write("Enter 1st Account Id :");
            string accountId = Console.ReadLine();

            Console.Write("Enter 1st Balance :");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter 1st Deposit  :");
            double depositAmount = double.Parse(Console.ReadLine());

            Console.Write("Enter 1st Withdraw :");
            double withdrawAmount = double.Parse(Console.ReadLine());

            Console.Write("Enter 1st Gender (1 for Male & 2 for Female):");
            int sex = Int32.Parse(Console.ReadLine());

            if (check == 1)
            {
                Console.Write("Enter 1st Interest :");
                double interest = double.Parse(Console.ReadLine());
                sa = new SavingAccount(name, accountId, balance, sex, interest, ad);


                Console.WriteLine("\n===================================\n");


                //sa.Name = name;
                //sa.AccountId = accountId;
                //sa.Balance = balance;
                sa.Deposit(depositAmount);
                Console.WriteLine("After Deposit :" + sa.Balance);
                sa.WithDraw(withdrawAmount);
                Console.WriteLine("After withdraw :" + sa.Balance);
                //sa.showAccountDetails();

                Console.WriteLine("\n");
                sa = new SavingAccount();

                sa.ShowInfo();
            }









            Console.WriteLine("\n\n================ For 2nd Person===================\n\n");



            Address ad1 = new Address();
            Console.Write("Enter 2nd Area :");
            ad1.Ares = Console.ReadLine();
            Console.Write("Enter 2nd City :");
            ad1.City = Console.ReadLine();
            Console.Write("Enter 2nd House :");
            ad1.HouseNo = Console.ReadLine();
            Console.Write("Enter 2nd Road No :");
            ad1.RoadNo = Int32.Parse(Console.ReadLine());


            SavingAccount sa1 = new SavingAccount("", "", -1, 0, 1, ad);



            Console.Write("Enter 2nd Name :");
            string name1 = Console.ReadLine();

            Console.Write("Enter 2nd Account Id :");
            string accountId1 = Console.ReadLine();

            Console.Write("Enter 2nd Balance :");
            double balance1 = double.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Deposit  :");
            double depositAmount1 = double.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Withdraw :");
            double withdrawAmount1 = double.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Gender (1 for Male & 2 for Female):");
            int sex1 = Int32.Parse(Console.ReadLine());

            if (check == 1)
            {
                Console.Write("Enter 2nd Interest :");
                double interest1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                sa1 = new SavingAccount(name1, accountId1, balance1, sex1, interest1, ad1);

                //sa1.Name = name;
                //sa1.AccountId = accountId;
                //sa1.Balance = balance;
                sa1.Deposit(depositAmount);
                Console.WriteLine("After Deposit :" + sa1.Balance);
                sa1.WithDraw(withdrawAmount);
                Console.WriteLine("After withdraw :" + sa1.Balance);
                sa1.showAccountDetails();


                sa1.ShowInfo();

                Console.WriteLine("\n");

                int check1;

                Console.Write("\n\n========== For Transfer ===============\n");

                Console.WriteLine("Press 1 if " + sa.Name + " Transfer Money To" + sa1.Name);
                Console.WriteLine("Press 2 if " + sa1.Name + " Transfer Money To" + sa.Name);

                Int32.TryParse(Console.ReadLine(), out check1);
                if (check1 == 1)
                {
                    Console.Write("Please Enter Transfer's Amount : ");
                    sa.Transfer(double.Parse(Console.ReadLine()), sa1);
                }
                else if (check1 == 2)
                {
                    Console.Write("Please Enter Transfer's Amount : ");
                    sa1.Transfer(double.Parse(Console.ReadLine()), sa);
                }
                else
                    Console.WriteLine("Please Press 1 or 2");


                if (check1 == 1)
                    Console.WriteLine("\n\n============After Transfer Taka ============" + sa.Name + " -> " + sa1.Name);
                else
                    Console.WriteLine("\n\n============After Transfer Taka ============" + sa1.Name + " -> " + sa.Name);

                Console.WriteLine("Name : " + sa.Name + ", Balance : " + sa.Balance);
                Console.WriteLine("Name : " + sa1.Name + ", Balance : " + sa1.Balance);
            }





            if (check == 2)
            {
                Console.WriteLine("\n\n============== 1st Person =================\n\n");
                CurrentAccount ca = new CurrentAccount(name, accountId, balance, sex, ad);
                ca.ShowDetails();


                Console.WriteLine("\n\n============== 2nd Person =================\n\n");


                CurrentAccount ca1 = new CurrentAccount(name1, accountId1, balance1, sex1, ad1);
                ca1.ShowDetails();
            }







        }
    }
}
