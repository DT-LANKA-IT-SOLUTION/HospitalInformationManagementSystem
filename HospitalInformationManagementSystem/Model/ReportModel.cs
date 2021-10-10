using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Model
{
    class ReportModel
    {
        public DateTime AppointmentToDate { get; set; }
        public DateTime AppointmentFormDate { get; set; }
        public DateTime UserToDate { get; set; }
        public DateTime UserFormDate { get; set; }
        public DateTime PatientToDate { get; set; }
        public DateTime PatientFormDate { get; set; }
    }
}
