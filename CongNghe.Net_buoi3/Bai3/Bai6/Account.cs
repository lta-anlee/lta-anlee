using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Account
    {
        private long acctNumber;
        private String name;
        private double balance;
        private double RATE = 0.035;

        public Account()
        {
            balance = 50;
        }

        public Account(long acctNumber, String name, double balance)
        {
            this.acctNumber = acctNumber;
            this.name = name;
            this.balance = balance;
        }

        public Account(long acctNumber, String name)
        {
            this.acctNumber = acctNumber;
            this.name = name;
        }

        public Boolean Them(double amount) /**tien gui*/
        {
            if (amount < 0)
            {
                throw new Exception("So tien khong du de rut. ");
            }
            else
            {
                balance += amount;
                return true;
            }
        }

        public Boolean withdraw(double amount, double fee) /**thu hoi, rut tien*/
        {
            if (amount < 0 || (amount + fee) >= balance)
                throw new Exception("Loi roi,DK rut :  amount > 0  || (amount+fee)>=balance ");

            else
            {
                balance = balance - (amount + fee);
                return true;
            }


        }

        //void transfer( Account acc2 , double amount,  double fee)/**chuyen giao*/
        //{
        //    try {
        //        this.withdraw(amount, fee);
        //    } catch (Exception e) {
        //        // TODO Auto-generated catch block
        //       Console.WriteLine("Loi: " + e.getMessage());
        //    }
        //    try {
        //        acc2.Them(amount);
        //    } catch (Exception e) {
        //        // TODO Auto-generated catch block
        //         Console.WriteLine("Loi: " + e.getMessage());
        //    }
        //}

        void addInterest()
        {
            balance = balance + (balance * RATE);
        }

        public long getAcctNumber()
        {
            return acctNumber;
        }

        public double getBalance()
        {
            return balance;
        }

        //public String toString() {

        //    NumberFormat numBerFormat = NumberFormat.getCurrencyInstance();

        //    return "Account [acctNumber=" + acctNumber + ", name=" + name
        //            + ", balance=" + numBerFormat.format(getBalance())+ ", RATE=" + RATE + "]";
        //}
    }
}
        