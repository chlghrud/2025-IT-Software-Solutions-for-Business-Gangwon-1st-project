﻿using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Model;
using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.view
{
    public partial class Login : FormBase
    {
     
        public Login()
        {
            InitializeComponent();
            button1.BackColor = Color_Browon;
            BackColor = Color_Yello;
            placeholder1.WatermarkText = "TellTok계정";
            placeholder2.WatermarkText = "비밀번호";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                button1.Text = "";
                button1.Image = Resources.login_loding;
                Thread.Sleep(1000);
                button1.Text = "로그인";
                button1.Image = null;
            });
            t.Start();
            using (telltokEntities db = new telltokEntities())
            {

            }
        }
    }
}
