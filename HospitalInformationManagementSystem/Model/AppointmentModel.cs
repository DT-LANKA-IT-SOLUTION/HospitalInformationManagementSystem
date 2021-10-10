using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class AppointmentModel
    {
        public int app_id { get; set; }
        public int appointment_no { get; set; }
        public DateTime app_date { get; set; }
        public DateTime app_time { get; set; }
        public string patient { get; set; }
        public string symptoms { get; set; }
        public int medical_officer { get; set; }
        public string status { get; set; }
        public int user_id { get; set; }
    }
}
