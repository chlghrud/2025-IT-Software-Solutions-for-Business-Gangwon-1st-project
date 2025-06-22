using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.공통구현.트레일러_자동로그인
{
    public partial class TBase : Form
    {
        public static bool isLogin = false;
        public static bool isLock = false;
        public static bool BeforeLogin;
        public TBase()
        {
            InitializeComponent();
        }

      
        

        private void TBase_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
