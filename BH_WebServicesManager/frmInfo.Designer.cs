namespace BH_WebServicesManager
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            label1 = new Label();
            txtServiceName = new TextBox();
            label2 = new Label();
            txtDisplayName = new TextBox();
            label3 = new Label();
            txtUrl = new TextBox();
            label4 = new Label();
            txtGitUrl = new TextBox();
            label5 = new Label();
            txtGitRepo = new TextBox();
            label8 = new Label();
            txtGitUser = new TextBox();
            label9 = new Label();
            txtGitToken = new TextBox();
            label10 = new Label();
            txtPath = new TextBox();
            btnFind = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 19);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "서비스 이름";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(118, 19);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(319, 23);
            txtServiceName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(12, 64);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "서비스 표시이름";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(118, 64);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(319, 23);
            txtDisplayName.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(12, 109);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "URL";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(118, 109);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(319, 23);
            txtUrl.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(12, 154);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            label4.Text = "깃헙주소";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGitUrl
            // 
            txtGitUrl.Location = new Point(118, 154);
            txtGitUrl.Name = "txtGitUrl";
            txtGitUrl.Size = new Size(319, 23);
            txtGitUrl.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(12, 199);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 8;
            label5.Text = "대상 리파지토리";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGitRepo
            // 
            txtGitRepo.Location = new Point(118, 199);
            txtGitRepo.Name = "txtGitRepo";
            txtGitRepo.Size = new Size(319, 23);
            txtGitRepo.TabIndex = 9;
            // 
            // label8
            // 
            label8.Location = new Point(12, 245);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 10;
            label8.Text = "깃 유저";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGitUser
            // 
            txtGitUser.Location = new Point(118, 245);
            txtGitUser.Name = "txtGitUser";
            txtGitUser.Size = new Size(319, 23);
            txtGitUser.TabIndex = 11;
            // 
            // label9
            // 
            label9.Location = new Point(12, 290);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 12;
            label9.Text = "깃 토큰";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGitToken
            // 
            txtGitToken.Location = new Point(118, 290);
            txtGitToken.Name = "txtGitToken";
            txtGitToken.Size = new Size(319, 23);
            txtGitToken.TabIndex = 13;
            // 
            // label10
            // 
            label10.Location = new Point(12, 335);
            label10.Margin = new Padding(3);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 14;
            label10.Text = "소스 경로";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(151, 336);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(286, 23);
            txtPath.TabIndex = 16;
            // 
            // btnFind
            // 
            btnFind.Enabled = false;
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.Location = new Point(118, 334);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(27, 27);
            btnFind.TabIndex = 15;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Controls.Add(btnDelete);
            flowLayoutPanel2.Controls.Add(btnCancel);
            flowLayoutPanel2.Location = new Point(118, 380);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(249, 39);
            flowLayoutPanel2.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "저장";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(84, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(165, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 495);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(btnFind);
            Controls.Add(txtPath);
            Controls.Add(label10);
            Controls.Add(txtGitToken);
            Controls.Add(label9);
            Controls.Add(txtGitUser);
            Controls.Add(label8);
            Controls.Add(txtGitRepo);
            Controls.Add(label5);
            Controls.Add(txtGitUrl);
            Controls.Add(label4);
            Controls.Add(txtUrl);
            Controls.Add(label3);
            Controls.Add(txtDisplayName);
            Controls.Add(label2);
            Controls.Add(txtServiceName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "서비스 정보 관리";
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServiceName;
        private Label label2;
        private TextBox txtDisplayName;
        private Label label3;
        private TextBox txtUrl;
        private Label label4;
        private TextBox txtGitUrl;
        private Label label5;
        private TextBox txtGitRepo;
        private Label label8;
        private TextBox txtGitUser;
        private Label label9;
        private TextBox txtGitToken;
        private Label label10;
        private TextBox txtPath;
        private Button btnFind;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnCancel;
    }
}