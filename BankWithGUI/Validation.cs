using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompAppWithOOPs
{
    public class Validation
    {
        public static bool checkdoubleInput(string str)
        {


            bool result = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 57 || str[i] < 48)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public static bool checkCharacter(string str, Char character)
        {
            bool result = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public static bool checkNullString(string password)
        {
            bool flag = false;
            if (password != null)
            {
                flag = true;
            }
            return flag;
        }
        public static bool checkPassword(string password, int size)
        {
            bool flag = false;
            
            if (password != null && password.Length >= size && password.Length <= size+8)
            {
                flag = true;
            }

            return flag;
        }
        public static bool checkPassword(string password, int size, Char character)
        {
            bool flag = false;
            if (password != null && password.Length == size)
            {
                flag = true;
            }
            foreach (Char i in password)
            {
                if (i == character)
                {
                    return flag = false;
                }
            }
            return flag;
        }
    }
}
