using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.로그인폼구현.로그인버튼
{
    public partial class ButtonTest : Form
    {
        public ButtonTest()
        {
            InitializeComponent();
            button1.BackColor = FormBase.Color_Browon;
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
        }
    }
}
