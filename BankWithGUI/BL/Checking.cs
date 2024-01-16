using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CompAppWithOOPs.BL
{
    public class Checking : Account
    {
        private double AnnualInterestRate;
        public Checking(string id, string type, double annualInterestRate) : base(id, type)
        {
            AnnualInterestRate = annualInterestRate;
        }
        public Checking(string id, string type, double amount, double loan, double annualInterestRate) : base(id, type, amount, loan)
        {
            AnnualInterestRate = annualInterestRate;
        }
        public void setAnnualInterestRate(double num)
        {
            AnnualInterestRate = num;
        }
        public double getAnnualInterestRate()
        {
            return AnnualInterestRate;
        }
        public override double amountAfterInterest()
        {
            return Amount - ((AnnualInterestRate * Amount) / 12);
        }
    }
}
