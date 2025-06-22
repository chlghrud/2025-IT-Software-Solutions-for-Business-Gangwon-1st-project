using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.공통구현.폰트구현
{
    public partial class FontBase : Form
    {
        public static PrivateFontCollection fontCollection = new PrivateFontCollection();

        public FontBase()
        {
            InitializeComponent();

        }
        public void ChangeFontFamilyInForm(Control parent, params Control[] DontChange)
        {
            // 실행에는 문제없지만 디자인창에서 문제가 나기때문에 이렇게 함
            string fontPath = Path.Combine(Application.StartupPath, "Resources", "NoonnuBasicGothicRegular.ttf");
            fontCollection.AddFontFile(fontPath);
            try
            {
                foreach (Control ctrl in parent.Controls)
                {
                    if (!DontChange.Contains(ctrl))
                    {
                        if (ctrl.Font != null)
                        {
                            float size = ctrl.Font.Size;
                            FontStyle style = ctrl.Font.Style;
                            ctrl.Font = new Font(fontCollection.Families[0], size, style);
                        }
                    }
                  
                }
            }
            catch
            {
            }
        }
    }
}
