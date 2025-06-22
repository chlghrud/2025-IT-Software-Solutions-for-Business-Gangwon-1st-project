using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Controll
{
    public partial class Placeholder : TextBox
    {
        private string _watermarkText = "";
        private bool _isWatermark = true;
        private Color _originalForeColor;

        public Placeholder()
        {
            InitializeComponent();
            _originalForeColor = this.ForeColor;
            GotFocus += Placeholder_GotFocus;
            LostFocus += Placeholder_LostFocus;
        }

        private void Placeholder_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                _isWatermark = true;
                this.ForeColor = Color.LightGray;
                this.Text = _watermarkText;
            }
        }

        private void Placeholder_GotFocus(object sender, EventArgs e)
        {
            if (_isWatermark)
            {
                _isWatermark = false;
                this.Text = "";
                this.ForeColor = _originalForeColor;
            }

        }

        public string WatermarkText
        {
            get { return _watermarkText; }
            set
            {
                _watermarkText = value;
                SetWatermark();
            }
        }
       
        private void SetWatermark()
        {
            if (_isWatermark)
            {
                this.ForeColor = Color.LightGray;
                this.Text = _watermarkText;
            }
            else
            {
                this.ForeColor = Color.LightGray;
            }
        }

    }
}
