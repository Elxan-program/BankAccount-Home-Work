using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Project;

namespace HelperNameSpace
{
    class Hepler
    {
        public static bool CheckPAN(string pan)
        {
            if (pan.Length == 16)
            {
                return true;
            }
            else
            {
                throw new Exception("PAN character count is not equal 16");
            }
        }

        public static bool CheckPIN(string pin)
        {
            if (pin.Length == 4)
            {
                return true;
            }
            else
            {
                throw new Exception("PIN character count is not equal 4");
            }
        }

        public static bool CheckCVC(string cvc)
        {
            if (cvc.Length == 3)
            {
                return true;
            }
            else
            {
                throw new Exception("CVC character count is not equal 3");
            }
        }

        public static bool CheckBalance(int balance)
        {
            if (balance != 0)
            {
                return true;
            }
            else
            {
                throw new Exception("In this bank card don't have any money");
            }
        }

        public static bool CheckExpireTime(DateTime expireTime)
        {
            if (expireTime != DateTime.Now)
            {
                return true;
            }
            else
            {
                throw new Exception("Expire time was finished");
            }
        }
    }
}
