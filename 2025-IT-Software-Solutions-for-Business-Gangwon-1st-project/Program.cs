using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.view;
using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.공통구현.트레일러;
using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.공통구현.폰트구현;
using _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.로그인폼구현.로그인버튼;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TLogin());
        }
    }
}
