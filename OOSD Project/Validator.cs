using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOSD_Project
{
    class Validator
    {
        public static bool text(string name)
        {
            return Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$");
        }

        public static bool email(String email)
        {
            return Regex.IsMatch(email.Trim(), @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z");
        }

        public static bool fax(String fax)
        {
            return Regex.IsMatch(fax.Trim(), @"/^\+?[0 - 9]{ 6,}$/");
        }

        public static bool contactNumber(string number)
        {
            return Regex.IsMatch(number, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
        }

        public static bool nic(string nic)
        {
            return Regex.IsMatch(nic, @" ^\d{10}$[v,V]");
        }

        public static bool epf(string epf)
        {
            return true;
        }
    }
}
