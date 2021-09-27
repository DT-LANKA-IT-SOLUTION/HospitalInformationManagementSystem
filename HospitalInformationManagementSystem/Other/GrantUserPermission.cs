using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.Model;

namespace HospitalInformationManagementSystem.Other
{
    class GrantUserPermission
    {
        
        public void GrantMenuPermission(Button dashboard, Button patient, Button visitor, Button appointment, Button postal, Button complaints, Button reports, Button staff)
        {
            try
            {
                int x = 1;
                int y = 162;

                if (PermisionsModel.dashboard == "DENIED")
                {
                    dashboard.Visible = false;
                }
                else
                {
                    dashboard.Location = new Point(x,y);
                    y += 60;
                }
                
                if (PermisionsModel.patient == "DENIED")
                {
                    patient.Visible = false;
                }
                else
                {
                    patient.Location = new Point(x, y);
                    y += 60;
                }

                if (PermisionsModel.visitor == "DENIED")
                {
                    visitor.Visible = false;
                }
                else
                {
                    visitor.Location = new Point(x, y);
                    y += 60;
                }

                if (PermisionsModel.appointment == "DENIED")
                {
                    appointment.Visible = false;
                }
                else
                {
                    appointment.Location = new Point(x, y);
                    y += 60;
                }

                if (PermisionsModel.postal == "DENIED")
                {
                    postal.Visible = false;
                }
                else
                {
                    postal.Location = new Point(x, y);
                    y += 60;
                }

                if (PermisionsModel.complaints == "DENIED")
                {
                    complaints.Visible = false;
                }
                else
                {
                    complaints.Location = new Point(x, y);
                    y += 60;
                }

                if (PermisionsModel.reports == "DENIED")
                {
                    reports.Visible = false;
                }
                else
                {
                    reports.Location = new Point(x, y);
                    y += 60;
                }

                if (PermisionsModel.staff == "DENIED")
                {
                    staff.Visible = false;
                }
                else
                {
                    staff.Location = new Point(x, y);
                    y += 60;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GrantButtonPermission(string controlerName, Button btnAdd, Button btnEdit, Button btnDelete)
        {
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            int x = 0, y = 0;

            if (controlerName == "dashboard")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");
                Match match = regex.Match(PermisionsModel.dashboard);
                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            btnAdd.Visible = true;
                        }
                        else if (ch == 'D')
                        {
                            btnDelete.Visible = true;
                        }
                        else if (ch == 'M')
                        {
                            btnEdit.Visible = true;
                        }
                    }
                    
                }
            }
            else if (controlerName == "patient")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");

                Match match = regex.Match(PermisionsModel.patient);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            x += 36;
                            y += 549;

                            btnAdd.Visible = true;
                            btnAdd.Location = new Point(x, y);
                        }
                        else if (ch == 'D')
                        {
                            x += 154;
                            btnDelete.Visible = true;
                            btnDelete.Location = new Point(x, y);
                        }
                        else if (ch == 'M')
                        {
                            x += 154;
                            btnEdit.Visible = true;
                            btnEdit.Location = new Point(x, y);
                        }
                    }

                }
            }
            else if (controlerName == "visitor")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");

                Match match = regex.Match(PermisionsModel.visitor);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            x += 36;
                            y += 549;

                            btnAdd.Visible = true;
                            btnAdd.Location = new Point(x, y);
                        }
                        else if (ch == 'D')
                        {
                            x += 154;
                            btnDelete.Visible = true;
                            btnDelete.Location = new Point(x, y);
                        }
                        else if (ch == 'M')
                        {
                            x += 154;
                            btnEdit.Visible = true;
                            btnEdit.Location = new Point(x, y);
                        }
                    }

                }
            }
            else if (controlerName == "appointment")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");

                Match match = regex.Match(PermisionsModel.appointment);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            x += 36;
                            y += 549;

                            btnAdd.Visible = true;
                            btnAdd.Location = new Point(x, y);
                        }
                        else if (ch == 'D')
                        {
                            x += 154;
                            btnDelete.Visible = true;
                            btnDelete.Location = new Point(x, y);
                        }
                        else if (ch == 'M')
                        {
                            x += 154;
                            btnEdit.Visible = true;
                            btnEdit.Location = new Point(x, y);
                        }
                    }

                }
            }
            else if (controlerName == "postal")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");

                Match match = regex.Match(PermisionsModel.postal);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            x += 36;
                            y += 549;

                            btnAdd.Visible = true;
                            btnAdd.Location = new Point(x, y);
                        }
                        else if (ch == 'D')
                        {
                            x += 154;
                            btnDelete.Visible = true;
                            btnDelete.Location = new Point(x, y);
                        }
                        else if (ch == 'M')
                        {
                            x += 154;
                            btnEdit.Visible = true;
                            btnEdit.Location = new Point(x, y);
                        }
                    }

                }
            }
            else if (controlerName == "complaints")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");

                Match match = regex.Match(PermisionsModel.complaints);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            x += 36;
                            y += 549;

                            btnAdd.Visible = true;
                            btnAdd.Location = new Point(x, y);
                        }
                        else if (ch == 'D')
                        {
                            x += 154;
                            btnDelete.Visible = true;
                            btnDelete.Location = new Point(x, y);
                        }
                        else if (ch == 'M')
                        {
                            x += 154;
                            btnEdit.Visible = true;
                            btnEdit.Location = new Point(x, y);
                        }
                    }

                }
            }
            else if (controlerName == "reports")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");

                Match match = regex.Match(PermisionsModel.reports);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            x += 36;
                            y += 549;

                            btnAdd.Visible = true;
                            btnAdd.Location = new Point(x, y);
                        }
                        else if (ch == 'D')
                        {
                            x += 154;
                            btnDelete.Visible = true;
                            btnDelete.Location = new Point(x, y);
                        }
                        else if (ch == 'M')
                        {
                            x += 154;
                            btnEdit.Visible = true;
                            btnEdit.Location = new Point(x, y);
                        }
                    }

                }
            }
            else if (controlerName == "staff")
            {
                Regex regex = new Regex(@"([A-Z]{0,4})");

                Match match = regex.Match(PermisionsModel.staff);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {

                        }
                        else if (ch == 'C')
                        {
                            x += 36;
                            y += 549;

                            btnAdd.Visible = true;
                            btnAdd.Location = new Point(x, y);
                        }
                        else if (ch == 'D')
                        {
                            x += 154;
                            btnDelete.Visible = true;
                            btnDelete.Location = new Point(x, y);
                        }
                        else if (ch == 'M')
                        {
                            x += 154;
                            btnEdit.Visible = true;
                            btnEdit.Location = new Point(x, y);
                        }
                    }

                }
            }
        }
    }
}
