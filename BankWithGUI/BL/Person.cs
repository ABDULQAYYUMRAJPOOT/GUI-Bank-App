
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CompAppWithOOPs.BL
{
    public class Person
    {
        protected string Name;
        protected string Password;
        protected string Role;
        public Person(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }
        public Person(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void setPassword(string password)
        {
            Password = password;
        }
        public string getPassowrd()
        {
            return Password;
        }
        public string role { get => Role; set => Role = value; }
        public string name { get => Name; set => Name = value; }
        public string password { get => Password; set => Password = value; }
        public string getRole()
        {
            return Role;
        }
        public virtual List<Account> getAccountList()
        {
            return null;
        }
        public virtual string getId()
        {
            return null;
        }
        public virtual string getFeedBack()
        {
            return "No FeedBack";
        }
        public virtual void addAccount(Account account)
        {

        }
        public virtual void showDetails()
        {

        }
        public virtual void showFeedBack()
        {

        }
    }
}
