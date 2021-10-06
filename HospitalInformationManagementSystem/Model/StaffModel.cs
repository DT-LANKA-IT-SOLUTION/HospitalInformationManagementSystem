using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class StaffModel
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public int phone_no { get; set; }
        public string nic_no { get; set; }
        public DateTime birth_date { get; set; }
        public string address { get; set; }
        public string marital_status { get; set; }
        public string user_type { get; set; }
        public string speciality_area { get; set; }
        public string staff_id { get; set; }
        public string staff_email { get; set; }
        public DateTime join_date { get; set; }
        public Boolean IsActive { get; set; }
        public string photo_data { get; set; }

        public string DashboardValue { get; set; }
        public string PatientValue { get; set; }
        public string VistorsValue { get; set; }
        public string AppoinmentValue { get; set; }
        public string PostalValue { get; set; }
        public string ComplaintsValue { get; set; }
        public string ReportsValue { get; set; }
        public string StaffValue { get; set; }
    }
}
