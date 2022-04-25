namespace LOSTBOOK
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPowerOff = new System.Windows.Forms.Button();
            this.buttonPlusUnit = new System.Windows.Forms.Button();
            this.buttonSetTop = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-14, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 113);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonPowerOff);
            this.panel3.Controls.Add(this.buttonPlusUnit);
            this.panel3.Controls.Add(this.buttonSetTop);
            this.panel3.Location = new System.Drawing.Point(-14, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 36);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOSTBOOK";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonPowerOff
            // 
            this.buttonPowerOff.BackColor = System.Drawing.Color.Teal;
            this.buttonPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPowerOff.ForeColor = System.Drawing.Color.White;
            this.buttonPowerOff.Image = ((System.Drawing.Image)(resources.GetObject("buttonPowerOff.Image")));
            this.buttonPowerOff.Location = new System.Drawing.Point(526, 3);
            this.buttonPowerOff.Name = "buttonPowerOff";
            this.buttonPowerOff.Size = new System.Drawing.Size(30, 30);
            this.buttonPowerOff.TabIndex = 1;
            this.buttonPowerOff.UseVisualStyleBackColor = false;
            this.buttonPowerOff.Click += new System.EventHandler(this.buttonPowerOff_Click);
            // 
            // buttonPlusUnit
            // 
            this.buttonPlusUnit.BackColor = System.Drawing.Color.Teal;
            this.buttonPlusUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlusUnit.ForeColor = System.Drawing.Color.White;
            this.buttonPlusUnit.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlusUnit.Image")));
            this.buttonPlusUnit.Location = new System.Drawing.Point(455, 3);
            this.buttonPlusUnit.Name = "buttonPlusUnit";
            this.buttonPlusUnit.Size = new System.Drawing.Size(30, 30);
            this.buttonPlusUnit.TabIndex = 1;
            this.buttonPlusUnit.UseVisualStyleBackColor = false;
            this.buttonPlusUnit.Click += new System.EventHandler(this.buttonSetTop_Click);
            // 
            // buttonSetTop
            // 
            this.buttonSetTop.BackColor = System.Drawing.Color.Teal;
            this.buttonSetTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetTop.ForeColor = System.Drawing.Color.White;
            this.buttonSetTop.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetTop.Image")));
            this.buttonSetTop.Location = new System.Drawing.Point(490, 3);
            this.buttonSetTop.Name = "buttonSetTop";
            this.buttonSetTop.Size = new System.Drawing.Size(30, 30);
            this.buttonSetTop.TabIndex = 1;
            this.buttonSetTop.UseVisualStyleBackColor = false;
            this.buttonSetTop.Click += new System.EventHandler(this.buttonSetTop_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(374, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 353);
            this.button7.TabIndex = 5;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(67, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 359);
            this.panel1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Opacity = 0.72D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOSTBOOK";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSetTop;
        private System.Windows.Forms.Button buttonPowerOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlusUnit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
    }
}