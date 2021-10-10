﻿using HospitalInformationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.PL
{
    public partial class wfViewFiles_PL : Form
    {
        public static string file = "";
        public wfViewFiles_PL(string viewFile)
        {
            InitializeComponent();
            file = viewFile;
        }

        private void WfViewFiles_PL_Load(object sender, EventArgs e)
        {
            axAcroPDF.src = file;
        }
    }
}
