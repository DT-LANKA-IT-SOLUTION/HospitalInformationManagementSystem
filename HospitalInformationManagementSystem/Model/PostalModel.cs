using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class PostalModel
    {
        public int postal_id { get; set; }
        public string postal_type { get; set; }
        public string ref_no { get; set; }
        public string from_name { get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public string to_name { get; set; }
        public DateTime date { get; set; }
        public String attachment_type { get; set; }
        public string attachment_data { get; set; }
        public int user_id { get; set; }
    }
}
