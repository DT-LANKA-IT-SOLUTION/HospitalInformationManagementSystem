using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using HospitalInformationManagementSystem.PL;

namespace HospitalInformationManagementSystem.BLL
{
    class Auth_BLL
    {
        public List<string> GetUserAuthentication(AuthModel authModel)
        {
            try
            {
                List<string> list = new List<string>();

                if (Auth_DLL.UserAuthentication(authModel) != string.Empty)
                {
                    string userid = Auth_DLL.UserAuthentication(authModel);
                    string hashPassword = Auth_DLL.GetUserPassword(authModel);

                    if (PasswordVerify(hashPassword, authModel.Password))
                    {
                        SqlDataReader sdr = Auth_DLL.GetUserData(authModel);
                        
                        while (sdr.Read())
                        {
                            PermisionsModel.user_id = sdr[0].ToString();
                            PermisionsModel.first_name = sdr[0].ToString();
                            PermisionsModel.last_name = sdr[0].ToString();
                            PermisionsModel.gender = sdr[0].ToString();
                            PermisionsModel.nic = sdr[0].ToString();
                            PermisionsModel.birth_day = sdr[0].ToString();
                            PermisionsModel.address = sdr[0].ToString();
                        }
                        PermisionsModel.islogin = true;

                        sdr = Auth_DLL.GetUserPermisions(Int32.Parse(userid));
                        
                        while (sdr.Read())
                        {
                            if (sdr[2].ToString() == "dashboard")
                            {
                                PermisionsModel.dashboard = sdr[3].ToString();
                            }
                            else if (sdr[2].ToString() == "patient")
                            {
                                PermisionsModel.patient = sdr[3].ToString();
                            }
                            else if (sdr[2].ToString() == "visitor")
                            {
                                PermisionsModel.visitor = sdr[3].ToString();
                            }
                            else if (sdr[2].ToString() == "appointment")
                            {
                                PermisionsModel.appointment = sdr[3].ToString();
                            }
                            else if (sdr[2].ToString() == "postal")
                            {
                                PermisionsModel.postal = sdr[3].ToString();
                            }
                            else if (sdr[2].ToString() == "complaints")
                            {
                                PermisionsModel.complaints = sdr[3].ToString();
                            }
                            else if (sdr[2].ToString() == "reports")
                            {
                                PermisionsModel.reports = sdr[3].ToString();
                            }
                            else if (sdr[2].ToString() == "staff")
                            {
                                PermisionsModel.staff = sdr[3].ToString();
                            }

                        }
                        list.Add("login successful");
                        list.Add("true");
                        return list;
                    }
                    else
                    {
                        list.Add("Password is invalid");
                        list.Add("false");
                        return list;
                    }
                }
                else
                {
                    list.Add("Username is invalid");
                    list.Add("false");
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool PasswordVerify(string hashPassword, string planeText)
        {
            if(planeText != EncryptionLab.DecryptText(hashPassword))
            {
                return false;
            }

            return true;
        }
    }
}
