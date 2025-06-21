using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project
{
    public partial class FormBase : Form
    {
        public static PrivateFontCollection privateFont = new PrivateFontCollection();
        public static Color Color_Yello = Color.FromArgb(255, 170, 1), Color_Browon = Color.FromArgb(58, 30, 29)
            , Color_Blue = Color.FromArgb(186, 206, 224);
        public FormBase()
        {
            InitializeComponent();

            byte[] fontData = File.ReadAllBytes(Path.Combine(@"C:\Users\user\Documents\GitHub\2025-IT-Software-Solutions-for-Business-Gangwon-1st-project\2025-IT-Software-Solutions-for-Business-Gangwon-1st-project\Resources\", "NoonnuBasicGothicRegular.ttf"));
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            privateFont.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
            
        }
        
    }
}
