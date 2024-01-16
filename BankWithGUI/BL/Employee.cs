
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompAppWithOOPs.BL
{
    public class Employee : Person
    {
        private string Id;
        public Employee(string name, string password, string role, string id) : base(name, password, role)
        {
            Id = id;
        }
        public override string getId()
        {
            return Id;
        }
        public void setId(string id)
        {
            Id = id;
        }
        public override void showFeedBack()
        {

        }
        public override string getFeedBack()
        {
            return "No FeedBack";
        }
        public override void addAccount(Account account)
        {

        }
        public override void showDetails()
        {
           // EmployeeUI.showEmployeeAllData(Name, Id, Password, Role);
        }

        public static explicit operator Employee(Account v)
        {
            throw new NotImplementedException();
        }
    }
}
