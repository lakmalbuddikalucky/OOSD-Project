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
            return Regex.IsMatch(nic, @"^\d{9}(X|V)$");
        }

        public static bool epf(string epf)
        {
            return true;
        }

        public static bool number(string number) {
            return Regex.IsMatch(number, @"^[1-9]\d*$");
        }

        public static bool money(string money)
        {
            return Regex.IsMatch(money, @"^\d+\.\d{0,2}$") || number(money);
        }

        public static bool dateDiff(DateTime endDate, DateTime startDate)
        {
            TimeSpan ts = endDate - startDate;
            int totalDays = (int)Math.Ceiling(ts.TotalDays);
            if (ts.TotalDays < 1 && ts.TotalDays > 0)
                return false;
            else
                return true;
        }
    }
}
