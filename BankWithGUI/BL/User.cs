
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CompAppWithOOPs.BL
{
    public class User : Person
    {
        private string FeedBack;
        private List<Account> Accounts = new List<Account>();
        public User(string name, string password, string role) : base(name, password, role)
        {

        }
        public User(string name, string password, string role, string feedback) : base(name, password, role)
        {
            this.FeedBack = feedback;
        }
        public override List<Account> getAccountList()
        {
            return Accounts;
        }
        public override void addAccount(Account account)
        {
            Accounts.Add(account);
        }
        public bool isIdPresent(string id)
        {
            foreach (Account acc in Accounts)
            {
                if (acc.getId() == id)
                {
                    return true;
                }
            }
            return false;
        }
        public Account getAccount(string id)
        {
            foreach (Account account in Accounts)
            {
                if (account.getId().Equals(id))
                {
                    return account;
                }
            }
            return null;
        }
        public void setFeedBack(string feedback)
        {
            FeedBack = feedback;
        }
        public override string getFeedBack()
        {
            return FeedBack;
        }
        public override void showFeedBack()
        {
           // UserUI.showText(FeedBack);
        }
        public override void showDetails()
        {
            //UserUI.showUserAllData(Name, Accounts);
        }
    }
}
