using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD_Project
{
    public enum VALIDATE_TYPE
    {
        NOT_NULL = 0,
        EMAIL = 1,
        FAX = 2,
        CONTACT_NO = 3,
        NIC = 4,
        EPF = 5,
        NUMBER = 6,
        MONEY = 7,
        TEXT = 8,
        DATE_DIFF = 9,
        YEAR = 10,
        LESS_THAN_SYS_DATE = 11
    }
    public abstract class Validator
    {
        private static ErrorProvider erp_handler_not_found;
        private static ErrorProvider erp_date_time;

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

        public static bool number(string number)
        {
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
            if(totalDays >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool year(string year)
        {
            if(year.Length == 4 && number(year))
            {
                return true;
            }
            return false;
        }

        public static bool notNull(string text)
        {
            if(text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool lessThanSystemDate(DateTime date)
        {
            if (dateDiff(DateTime.Today, date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Chain of validation
        //Design pattern used : Chain of responsibility
        //Date validation cannot done by using this method

        public static bool validate(Control control, VALIDATE_TYPE  type)
        {
            if(erp_handler_not_found != null)
            {
                //Dispose existing error;
                erp_handler_not_found.Dispose();
            }

            if(control == null)
            {
                return false;
            }
            else
            {
                return text(ref control, type);
            }
        }

        public static bool validate(ref DateTimePicker control1,ref DateTimePicker control2, VALIDATE_TYPE type)
        {
            if(dateDiff(control1.Value, control2.Value))
            {
                if(erp_date_time!= null)
                {
                    //erp_date_time.Dispose();
                    return true;
                }
                return true;
            }
            else
            {
                //erp_date_time = new ErrorProvider();
                //erp_date_time.SetError(control1, "Invalid date");
                return false;
            }
        }
   
        private static bool text(ref Control control, VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.TEXT)
            {
                if (text(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return email(ref control,type);
            }
        }

        private static bool email(ref Control control,VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.EMAIL)
            {
                if (email(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return fax(ref control, type);
            }
        }

        private static bool fax(ref Control control,VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.FAX)
            {
                if (fax(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return contactNumber(ref control, type);
            }
        }

        private static bool contactNumber(ref Control control, VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.CONTACT_NO)
            {
                if (contactNumber(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return nic(ref control, type);
            }
        }

        private static bool nic(ref Control control, VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.NIC)
            {
                if (nic(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return epf(ref control, type);
            }
        }

        private static bool epf(ref Control control, VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.EPF)
            {
                if (epf(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return number(ref control, type);
            }
        }

        private static bool number(ref Control control, VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.NUMBER)
            {
                if (number(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return money(ref control, type);
            }
        }

        private static bool money(ref Control control, VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.MONEY)
            {
                if (money(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return notNull(ref control, type);      
            }
           
        }

        private static bool notNull(ref Control control, VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.NOT_NULL)
            {
                if (notNull(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return year(ref control, type);
            }
        }

        private static bool year(ref Control control,VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.YEAR)
            {
                if (year(control.Text))
                {
                    control.BackColor = Color.White;
                    return true;
                }
                else
                {
                    control.BackColor = Color.RosyBrown;
                    return false;
                }
            }
            else
            {
                return lessThanSystemDate(ref control,type);
            }
        }

        private static bool lessThanSystemDate(ref Control control,VALIDATE_TYPE type)
        {
            if(type == VALIDATE_TYPE.LESS_THAN_SYS_DATE)
            {
                if(control is DateTimePicker)
                {
                    DateTimePicker tmp = (DateTimePicker)control;
                    if (lessThanSystemDate(tmp.Value))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return defaultHandler(ref control);
            }
        }

        private static bool defaultHandler(ref Control control)
        {
            erp_handler_not_found = new ErrorProvider();
            erp_handler_not_found.SetError(control, "Validator not found");
            return false;
        }
    }
}
