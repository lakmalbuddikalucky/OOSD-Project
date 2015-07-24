using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class DependentDetails
    {
        

        public string salutation { set; get; }
        public string full_name { set; get; }
        public string relation { set; get; }

        
        string date_of_post;
        public void setDate_of_post(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.date_of_post = dt.ToString("yyyy-MM-dd");
        }
        public string getDate_of_post() {
            return date_of_post;
        }


        public string nic_no { set; get; }
        public string personal_tp { set; get; }
        public string office_tp { set; get; }
        public string personal_address { set; get; }
        public string official_address { set; get; }
        public string education { set; get; }
        public string status { set; get; }
        public string note { set; get; }
        public string birth_certificate { set; get; }
        public string marriage_certificate { set; get; }
        public bool deathade { set; get; }
        public bool doctor { set; get; }

        public DependentDetails()
        {

        }
        public DependentDetails(string salutation, string full_name, string relation, string date_of_post, string nic_no, string personal_tp, string office_tp, string personal_address, string official_address, string education, string status, string note, string birth_certificate, string marriage_certificate, bool deathade, bool doctor)
        {
            this.salutation = salutation;
            this.full_name = full_name;
            this.relation = relation;
            this.date_of_post = date_of_post;
            this.nic_no = nic_no;
            this.personal_tp = personal_tp;
            this.office_tp = office_tp;
            this.personal_address = personal_address;
            this.official_address = official_address;
            this.education = education;
            this.status = status;
            this.note = note;
            this.birth_certificate = birth_certificate;
            this.marriage_certificate = marriage_certificate;
            this.deathade = deathade;
            this.doctor = doctor;
        }
    }
}
