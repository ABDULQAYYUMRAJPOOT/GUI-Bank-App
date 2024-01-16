using CompAppWithOOPs.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompAppWithOOPs.DL
{
    public class PersonDL
    {
        private static List<Person> Persons = new List<Person>();
        public static void addPerson(Person person)
        {
            Persons.Add(person);
        }
        public static void removePerson(Person person)
        {
            Persons.Remove(person);
        }
        public static Person getPersonFromList(Person person)
        {
            foreach (Person p in Persons)
            {
                if (p.getPassowrd().Equals(person.getPassowrd()) && p.getName().Equals(person.getName()))
                {
                    return p;
                }
            }
            return null;
        }
        public static Person getPersonFromList(string name, string password)
        {
            foreach (Person p in Persons)
            {
                if (p.getPassowrd() == password && p.getName().Equals(name))
                {
                    return p;
                }
            }
            return null;
        }
        public static User getPersonFromList(string name)
        {
            foreach (Person p in Persons)
            {
                if (p.name == name && p.role == "user")
                {
                    User user = p as User;
                    return user;
                }
            }
            return null;
        }
        public static bool isPersonPresent(string name, string password)
        {
            bool flag = false;
            foreach (Person p in Persons)
            {
                if (p.name == name && p.password == password)
                {
                    return true;
                }
            }
            return flag;
        }
        public static bool isEmpPresent()
        {
            bool flag = false;
            foreach (Person p in Persons)
            {
                if(p.role == "employee")
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool isNamePresent(string name)
        {
            foreach (Person p in Persons)
            {
                if (p.getName() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Person> getPersonsList()
        {
            return Persons;
        }
        public static void writePersonInFile(string path, Char character)
        {
            StreamWriter write = new StreamWriter(path, false);
            foreach (Person p in Persons)
            {
                if (p.getRole() == "user")
                {
                    User user = p as User;
                    write.WriteLine(user.getName() + character + user.getPassowrd() + character + user.getRole() + character + user.getFeedBack());
                    write.Flush();
                }
                else
                {
                    Employee emp = p as Employee;
                    write.WriteLine(emp.getName() + character + emp.getPassowrd() + character + emp.getRole() + character + emp.getId());
                    write.Flush();
                }
            }
            write.Close();
        }
        public static void writePersonAccountInFile(string path, Char character)
        {

            StreamWriter write = new StreamWriter(path, false);
            foreach (Person p in Persons)
            {
                if (p.getRole() == "user")
                {
                    foreach (var account in p.getAccountList())
                    {
                        if (account.getType() == "saving")
                        {
                            Saving saving = account as Saving;
                            write.WriteLine(p.getName() + character + p.getPassowrd() + character + saving.getId() + character + saving.getAmount() + character + saving.getType() + character + saving.getLoan() + character + saving.getInterest());
                        }
                        else
                        {
                            Checking checking = account as Checking;
                            write.WriteLine(p.getName() + character + p.getPassowrd() + character + checking.getId() +character+ checking.getAmount() + character + checking.getType() + character + checking.getLoan() + character + checking.getAnnualInterestRate());
                        }
                    }
                }
            }
            write.Close();
        }
        public static void readPersonFromFile(string path, Char character)
        {
            StreamReader reader = new StreamReader(path, false);
            string record = "";
            if (File.Exists(path))
            {
                string name, password, role, id, feedBack;
                while ((record = reader.ReadLine()) != null)
                {
                    name = seperate(record, 1, character);
                    password = seperate(record, 2, character);
                    role = seperate(record, 3, character);
                    if (role.Equals("employee"))
                    {
                        id = seperate(record, 4, character);
                        Employee emp = new Employee(name, password, role, id);
                        PersonDL.addPerson(emp);
                    }
                    else if (role.Equals("user"))
                    {
                        feedBack = seperate(record, 4, character);
                        User user = new User(name, password, role, feedBack);
                        PersonDL.addPerson(user);
                    }
                }
            }
            reader.Close();
        }
        public static void readAccountDetailFile(string path, Char character)
        {
            StreamReader reader = new StreamReader(path, false);
            if (File.Exists(path))
            {
                string id, name, record, type, password;
                double amount, loan, interest;
                while ((record = reader.ReadLine()) != null)
                {
                    name = seperate(record, 1, character);
                    password = seperate(record, 2, character);
                    id = seperate(record, 3, character);
                    amount = double.Parse(seperate(record, 4, character));
                    type = seperate(record, 5, character);
                    loan = double.Parse(seperate(record, 6, character));
                    interest = double.Parse(seperate(record, 7, character));
                    foreach (Person p in PersonDL.getPersonsList())
                    {
                        if (p.getName().Equals(name) && p.getPassowrd().Equals(password))
                        {
                            if (type.Equals("saving"))
                            {
                                Saving saving = new Saving(id, type, interest, amount, loan);
                                p.addAccount(saving);
                            }
                            else if (type.Equals("checking"))
                            {
                                Checking checking = new Checking(id, type, interest, amount, loan);
                                p.addAccount(checking);
                            }
                        }
                    }
                }
            }
            reader.Close();
        }
        static string seperate(string record, int field, Char character)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == character)
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
    }
}
