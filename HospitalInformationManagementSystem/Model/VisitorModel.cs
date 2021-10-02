using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class VisitorModel
    {
        public int visitor_id { get; set; }
        public string purpose { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }      
        public string phone_no { get; set; }
        public string nic_no { get; set; }
        public DateTime date { get; set; }
        public DateTime in_time { get; set; }
        public DateTime out_time { get; set; }
        public string note { get; set; }
        public string attachment_type { get; set; }
        public string attachment_data { get; set; }
       // public int user_id { get; set; }
        public Boolean IsActive { get; set; }
    }
}
