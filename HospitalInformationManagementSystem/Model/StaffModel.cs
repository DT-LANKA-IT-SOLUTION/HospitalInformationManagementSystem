using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class StaffModel
    {
        public int staff_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nic { get; set; }
        public string gender { get; set; }
        public string marital_status { get; set; }
        public DateTime birth_date { get; set; }
        public string address { get; set; }       
        public string phone { get; set; }
        public DateTime joined_date { get; set; }
        public string user_type { get; set; }
    }
}
