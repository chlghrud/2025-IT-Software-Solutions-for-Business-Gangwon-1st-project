
namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.view
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.placeholder2 = new _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Controll.Placeholder();
            this.placeholder1 = new _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Controll.Placeholder();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(134, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(71, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(71, 385);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "자동로그인";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.placeholder2);
            this.panel1.Controls.Add(this.placeholder1);
            this.panel1.Location = new System.Drawing.Point(71, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 63);
            this.panel1.TabIndex = 3;
            // 
            // placeholder2
            // 
            this.placeholder2.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeholder2.ForeColor = System.Drawing.Color.LightGray;
            this.placeholder2.Location = new System.Drawing.Point(0, 21);
            this.placeholder2.Name = "placeholder2";
            this.placeholder2.Size = new System.Drawing.Size(253, 21);
            this.placeholder2.TabIndex = 1;
            this.placeholder2.WatermarkText = "";
            // 
            // placeholder1
            // 
            this.placeholder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeholder1.ForeColor = System.Drawing.Color.LightGray;
            this.placeholder1.Location = new System.Drawing.Point(0, 0);
            this.placeholder1.Name = "placeholder1";
            this.placeholder1.Size = new System.Drawing.Size(253, 21);
            this.placeholder1.TabIndex = 0;
            this.placeholder1.WatermarkText = "";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(72, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 4;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(398, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Login";
            this.Text = "TelkTok-로그인";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private Controll.Placeholder placeholder2;
        private Controll.Placeholder placeholder1;
        private System.Windows.Forms.Label label1;
    }
}