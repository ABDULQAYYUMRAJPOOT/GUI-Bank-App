using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompAppWithOOPs.BL
{
    public class Saving : Account
    {
        private double Interest;
        public Saving(string id, string type, double interest) : base(id, type)
        {
            Interest = interest;
        }
        public Saving(string id, string type, double interest, double amount, double loan) : base(id, type, amount, loan)
        {
            Interest = interest;
        }
        public double getInterest()
        {
            return Interest;
        }
        public void setInterest(double interest)
        {
            this.Interest = interest;
        }
        public double calculateInterest()
        {
            double amount = Amount * Interest / 100;
            return amount;
        }
        public override double amountAfterInterest()
        {
            return Amount - calculateInterest();
        }
    }
}
