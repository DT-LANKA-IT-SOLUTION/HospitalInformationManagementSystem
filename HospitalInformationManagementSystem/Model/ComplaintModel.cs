using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class ComplaintModel
    {
        public int complaint_id { get; set; }
        public string complaint_by { get; set; }
        public string complaint_type { get; set; }
        public int phone_no { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public string action_taken { get; set; }
        public string note { get; set; }
        public int user_id { get; set; }
    }
}
