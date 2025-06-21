using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.view
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
            byte[] fontData = File.ReadAllBytes(Path.Combine(@"C:\Users\user\Documents\GitHub\2025-IT-Software-Solutions-for-Business-Gangwon-1st-project\2025-IT-Software-Solutions-for-Business-Gangwon-1st-project\Resources\", "NoonnuBasicGothicRegular.ttf"));
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            privateFont.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
            BackColor = Color_Yello;
            button1.Font = new Font(privateFont.Families[0], 16);
        }

    }
}
