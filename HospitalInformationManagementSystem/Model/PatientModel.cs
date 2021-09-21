using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class PatientModel
    {
        public string user_name { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public int phone_no { get; set; }
        public string nic_no { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string marital_status { get; set; }
        public string user_type { get; set; }
        public string blood_group { get; set; }
        public string allergies { get; set; }
    }
}
