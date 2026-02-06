namespace BH_WebServicesManager
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ctlDashboard1 = new ctlDashboard();
            ctlSetting1 = new ctlSetting();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ctlDashboard1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "대시보드";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ctlSetting1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "설정";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlDashboard1
            // 
            ctlDashboard1.BackColor = SystemColors.ActiveBorder;
            ctlDashboard1.Dock = DockStyle.Fill;
            ctlDashboard1.Location = new Point(3, 3);
            ctlDashboard1.Name = "ctlDashboard1";
            ctlDashboard1.Size = new Size(786, 416);
            ctlDashboard1.TabIndex = 0;
            // 
            // ctlSetting1
            // 
            ctlSetting1.BackColor = SystemColors.ActiveCaption;
            ctlSetting1.Dock = DockStyle.Fill;
            ctlSetting1.Location = new Point(3, 3);
            ctlSetting1.Name = "ctlSetting1";
            ctlSetting1.Size = new Size(786, 416);
            ctlSetting1.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmMain";
            Text = "nginx + spring boot 3 실행 관리자";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ctlDashboard ctlDashboard1;
        private ctlSetting ctlSetting1;
    }
}
