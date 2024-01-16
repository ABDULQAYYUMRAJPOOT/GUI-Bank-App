using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompAppWithOOPs.BL
{
    public class Account
    {
        protected string Id;
        protected string Type;
        protected double Amount;
        protected double Loan;
        public Account(string id, string type)
        {
            Id = id;
            Type = type;
            Loan = 0;
        }
        public Account(string id, string type, double amount, double loan)
        {
            Id = id;
            Type = type;
            Loan = loan;
            Amount = amount;
        }
        public string getId()
        {
            return Id;
        }
        public double getAmount()
        {
            return Amount;
        }
        public void setAmount(double amount)
        {
            Amount = amount;
        }
        public bool depositAmount(double amount)
        {
            if (amount >= 0)
            {
                Amount += amount;
                return true;
            }
            return false;
        }
        public double getLoan()
        {
            return Loan;
        }
        public bool applyLoan(double loan)
        {
            if (loan >= 0)
            {
                Loan += loan;
                return true;
            }
            return false;
        }
        public bool subtractLoan(double loan)
        {
            if (loan >= 0 && loan <= Loan)
            {
                Loan -= loan;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool widthdrawAmount(double amount)
        {
            if (amount >= 0 && amount <= Amount)
            {
                Amount -= amount;
                return true;
            }
            return false;
        }
        public bool transferAmount(double amount)
        {
            return widthdrawAmount(amount);
        }
        public string getType()
        {
            return Type;
        }
        public virtual double amountAfterInterest()
        {
            return Amount;
        }
        public virtual double amountWithLoan()
        {
            return Amount + Loan;
        }
    }
}
