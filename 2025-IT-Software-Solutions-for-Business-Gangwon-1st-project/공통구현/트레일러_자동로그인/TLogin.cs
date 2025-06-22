using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Properties;
using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.공통구현.트레일러_자동로그인;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.공통구현.트레일러
{
    public partial class TLogin : TBase
    {
        public TLogin()
        {
            InitializeComponent();
            VisibleChange(true, true);
        }
        private void VisibleChange(bool bVisible, bool bIconVisible)
        {
            Visible = bVisible;
            notifyIcon1.Visible = bIconVisible;


        }

        private void TLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true, true);
        }

        private void 잠금모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isLogin = true;
            Visible = false;
            new TMain().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                BeforeLogin = isLogin;
            }
            else
            {
                BeforeLogin = false;
            }
        }

        private void ContextMenuStrip1_Opened(object sender, EventArgs e)
        {
            잠금모드ToolStripMenuItem.Enabled = isLock;
            로그아웃ToolStripMenuItem.Enabled = isLogin;
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Help;
        }

        private void TLogin_VisibleChanged(object sender, EventArgs e)
        {

            if (isLogin)
            {
                if (isLock)
                {
                    notifyIcon1.Icon = Resources.Lock_mode_icon;
                }
                else
                {
                    notifyIcon1.Icon = Resources.icon;
                }
            }
            else
            {
                notifyIcon1.Icon = Resources.black_icon;
            }

        }
    }
}
