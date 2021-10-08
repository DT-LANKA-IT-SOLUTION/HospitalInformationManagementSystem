using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.BLL
{
    class Staff_BLL
    {
        SqlDataReader dr;
        public void LoadAllStaffGridView(DataGridView dgvStaff)
        {
            try
            {
                dgvStaff.AutoGenerateColumns = false;
                dgvStaff.DataSource = Staff_DLL.GetAllStaff();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddStaff(StaffModel staffModel)
        {

            try
            {
                return Staff_DLL.AddStaff(staffModel);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int UpdateStaff(StaffModel staffModel)
        {
            try
            {
                return Staff_DLL.UpdateStaff(staffModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteStaff(bool Active, int user_id)
        {
            try
            {
                return Staff_DLL.DeleteStaff(Active, user_id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string CheckUserByUsername(StaffModel staffModel)
        {
            try
            {
                return Staff_DLL.GetUserByUsername(staffModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GetStaffPermissions(int user_id,
            CheckBox cbDashboardA, CheckBox cbDashboardC, CheckBox cbDashboardD, CheckBox cbDashboardM,
            CheckBox cbPatientA, CheckBox cbPatientC, CheckBox cbPatientD, CheckBox cbPatientM,
            CheckBox cbVisitorA, CheckBox cbVisitorC, CheckBox cbVisitorD, CheckBox cbVisitorM,
            CheckBox cbAppointmentA, CheckBox cbAppointmentC, CheckBox cbAppointmentD, CheckBox cbAppointmentM,
            CheckBox cbPostalA, CheckBox cbPostalC, CheckBox cbPostalD, CheckBox cbPostalM,
            CheckBox cbComplaintsA, CheckBox cbComplaintsC, CheckBox cbComplaintsD, CheckBox cbComplaintsM,
            CheckBox cbReportsA, CheckBox cbReportsC, CheckBox cbReportsD, CheckBox cbReportsM,
            CheckBox cbStaffA, CheckBox cbStaffC, CheckBox cbStaffD, CheckBox cbStaffM
            )
        {
            try
            {
                dr = Staff_DLL.GetStaffPermissions(user_id);

                string status = "";

                if (dr.Read())
                {
                    while(dr.Read())
                    {
                        if(Int32.Parse(dr["permision_id"].ToString()) == 1)
                        {
                            status = dr["status"].ToString();
                            Regex regex = new Regex(@"([A-Z]{0,4})");

                            Match match = regex.Match(PermisionsModel.patient);

                            if (match.Success)
                            {
                                foreach (char ch in match.Value)
                                {
                                    if (ch == 'A')
                                    {
                                        cbDashboardA.Checked = true;
                                    }
                                    else if (ch == 'C')
                                    {
                                        cbDashboardC.Checked = true;
                                    }
                                    else if (ch == 'D')
                                    {
                                        cbDashboardD.Checked = true;
                                    }
                                    else if (ch == 'M')
                                    {
                                        cbDashboardM.Checked = true;
                                    }
                                    else
                                    {
                                        cbDashboardA.Checked = false;
                                        cbDashboardC.Checked = false;
                                        cbDashboardD.Checked = false;
                                        cbDashboardM.Checked = false;
                                    }
                                }

                            }
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
