using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Employee
    {

        public static int employee_id;


        string employee_no;
        public string getEmployee_no()
        {
            return employee_no;
        }
        public void setEmployee_no(string value)
        {
            this.employee_no = value;
        }


        string full_name;
        public string getFull_name()
        {
            return full_name;
        }
        public void setFull_name(string value)
        {
            this.full_name = value;
        }


        string img_url;
        public string getImg_url()
        {
            return img_url;
        }
        public void setImg_url(string value)
        {
            this.img_url = value;
        }



        string old_employee_no;
        public string getOld_employee_no()
        {
            return old_employee_no;
        }
        public void setOld_employee_no(string value)
        {
            this.old_employee_no = value;
        }


        string employee_type;
        public string getEmployee_type()
        {
            return employee_type;
        }
        public void setEmployee_type(string value)
        {
            this.employee_type = value;
        }


        string epf_no;
        public string getEpf_no()
        {
            return epf_no;
        }
        public void setEpf_no(string value)
        {
            this.epf_no = value;
        }


        string salutation;
        public string getSalutation()
        {
            return salutation;
        }
        public void setSalutation(string value)
        {
            this.salutation = value;
        }

        string occupation;
        public string getOccupation()
        {
            return occupation;
        }
        public void setOccupation(string value)
        {
            this.occupation = value;
        }


        string initials;
        public string getInitials()
        {
            return initials;
        }
        public void setInitials(string value)
        {
            this.initials = value;
        }


        string first_name;
        public string getFirst_name()
        {
            return first_name;
        }
        public void setFirst_name(string value)
        {
            this.first_name = value;
        }


        string last_name;
        public string getLast_name()
        {
            return last_name;
        }
        public void setLast_name(string value)
        {
            this.last_name = value;
        }


        string nic_no;
        public string getNic_no()
        {
            return nic_no;
        }
        public void setNic_no(string value)
        {
            this.nic_no = value;
        }


        string date_issued;
        public string getDate_issued()
        {
            return date_issued;
        }
        public void setDate_issued(string value)
        {
            DateTime date = Convert.ToDateTime(value);
            this.date_issued = date.ToString("yyyy-MM-dd");
        }


        string nationality;
        public string getNationality()
        {
            return nationality;
        }
        public void setNationality(string value)
        {
            this.nationality = value;
        }


        string religion;
        public string getReligion()
        {
            return religion;
        }
        public void setReligion(string value)
        {
            this.religion = value;
        }


        string date_of_birth;
        public string getDate_of_birth()
        {
            return date_of_birth;
        }
        public void setDate_of_birth(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.date_of_birth = dt.ToString("yyyy-MM-dd");
        }


        string place_of_birth;
        public string getPlace_of_birth()
        {
            return place_of_birth;
        }
        public void setPlace_of_birth(string value)
        {
            this.place_of_birth = value;
        }


        int married;
        public int getMarried()
        {
            return married;
        }
        public void setMarried(int value)
        {
            this.married = value;
        }


        string date_of_marriage;
        public string getDate_of_marriage()
        {
            return date_of_marriage;
        }
        public void setDate_of_marriage(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.date_of_marriage = dt.ToString("yyyy-MM-dd");
        }


        string action_status;
        public string getAction_status()
        {
            return action_status;
        }
        public void setAction_status(string value)
        {
            this.action_status = value;
        }


        string blood_group;
        public string getBlood_group()
        {
            return blood_group;
        }
        public void setBlood_grouph(string value)
        {
            this.blood_group = value;
        }

    }
}
