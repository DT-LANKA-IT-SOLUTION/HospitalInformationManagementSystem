using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
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

        StaffPermission staffPermission = new StaffPermission();
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

        public bool GetStaffPermissions(int user_id,
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
                    while (dr.Read())
                    {
                        if (Int32.Parse(dr["permision_id"].ToString()) == 1)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbDashboardA, cbDashboardC, cbDashboardD, cbDashboardM);
                        }

                        if (Int32.Parse(dr["permision_id"].ToString()) == 2)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbPatientA, cbPatientC, cbPatientD, cbPatientM);
                        }

                        if (Int32.Parse(dr["permision_id"].ToString()) == 3)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbVisitorA, cbVisitorC, cbVisitorD, cbVisitorM);
                        }

                        if (Int32.Parse(dr["permision_id"].ToString()) == 4)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbAppointmentA, cbAppointmentC, cbAppointmentD, cbAppointmentM);
                        }

                        if (Int32.Parse(dr["permision_id"].ToString()) == 5)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbPostalA, cbPostalC, cbPostalD, cbPostalM);
                        }

                        if (Int32.Parse(dr["permision_id"].ToString()) == 6)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbComplaintsA, cbComplaintsC, cbComplaintsD, cbComplaintsM);
                        }

                        if (Int32.Parse(dr["permision_id"].ToString()) == 7)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbReportsA, cbReportsC, cbReportsD, cbReportsM);
                        }

                        if (Int32.Parse(dr["permision_id"].ToString()) == 8)
                        {
                            status = dr["status"].ToString();
                            staffPermission.SetChechBoxData(status, cbStaffA, cbStaffC, cbStaffD, cbStaffM);
                        }

                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
