using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class ContactDetails
    {
        public int cd_id { set; get; }
        public string perm_home_no { set; get; }
        public string perm_address { set; get; }
        public string perm_city { set; get; }
        public string perm_province { set; get; }
        public string perm_district { set; get; }
        public string perm_uc { set; get; }
        public string perm_grama { set; get; }
        public string perm_polling_division { set; get; }
        public string perm_teleophone { set; get; }
        public string perm_mobile { set; get; }
        public string perm_fax { set; get; }
        public string perm_email { set; get; }
        public string cur_home_no { set; get; }
        public string cur_address { set; get; }
        public string cur_city { set; get; }
        public string cur_province { set; get; }
        public string cur_district { set; get; }
        public string cur_uc { set; get; }
        public string cur_grama { set; get; }
        public string cur_polling_division { set; get; }
        public string cur_teleophone { set; get; }
        public string cur_mobile { set; get; }
        public string cur_fax { set; get; }
        public string cur_email { set; get; }

        public ContactDetails()
        {

        }
        public ContactDetails(string perm_home_no, string perm_address, string perm_city, string perm_province, string perm_district, string perm_uc, string perm_grama, string perm_polling_division, string perm_teleophone, string perm_mobile, string perm_fax, string perm_email, string cur_home_no, string cur_address, string cur_city, string cur_province, string cur_district, string cur_uc, string cur_grama, string cur_polling_division, string cur_teleophone, string cur_mobile, string cur_fax, string cur_email)
        {
            this.perm_home_no = perm_home_no;
            this.perm_address = perm_address;
            this.perm_city = perm_city;
            this.perm_province = perm_province;
            this.perm_district = perm_district;
            this.perm_uc = perm_uc;
            this.perm_grama = perm_grama;
            this.perm_polling_division = perm_polling_division;
            this.perm_teleophone = perm_teleophone;
            this.perm_mobile = perm_mobile;
            this.perm_fax = perm_fax;
            this.perm_email = perm_email;
            this.cur_home_no = cur_home_no;
            this.cur_address = cur_address;
            this.cur_city = cur_city;
            this.cur_province = cur_province;
            this.cur_district = cur_district;
            this.cur_uc = cur_uc;
            this.cur_grama = cur_grama;
            this.cur_polling_division = cur_polling_division;
            this.cur_teleophone = cur_teleophone;
            this.cur_mobile = cur_mobile;
            this.cur_fax = cur_fax;
            this.cur_email = cur_email;


        }
    }
}
