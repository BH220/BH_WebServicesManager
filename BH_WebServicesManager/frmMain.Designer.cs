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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            textBox2 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRun = new Button();
            btnStop = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            panel2 = new Panel();
            grid = new DataGridView();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gitHubRepoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gitHubUrlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gitUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gitTokenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clsDataBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clsDataBindingSource).BeginInit();
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
            tabControl1.Size = new Size(950, 530);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "대시보드";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(449, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(490, 496);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.Dock = DockStyle.Fill;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(5, 35);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(480, 456);
            textBox2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnRun);
            flowLayoutPanel1.Controls.Add(btnStop);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(5, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(480, 30);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(3, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(92, 23);
            btnRun.TabIndex = 0;
            btnRun.Text = "서비스 실행";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(101, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(92, 23);
            btnStop.TabIndex = 0;
            btnStop.Text = "서비스 중지";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(199, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "서비스 추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(297, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "코드 업데이트";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(grid);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(446, 496);
            panel2.TabIndex = 2;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AutoGenerateColumns = false;
            grid.BorderStyle = BorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { serviceNameDataGridViewTextBoxColumn, displayNameDataGridViewTextBoxColumn, urlDataGridViewTextBoxColumn, gitHubRepoDataGridViewTextBoxColumn, gitHubUrlDataGridViewTextBoxColumn, gitUserDataGridViewTextBoxColumn, gitTokenDataGridViewTextBoxColumn, pathDataGridViewTextBoxColumn });
            grid.DataSource = clsDataBindingSource;
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(5, 5);
            grid.Name = "grid";
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(436, 486);
            grid.TabIndex = 0;
            grid.CellDoubleClick += grid_CellDoubleClick;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            // 
            // urlDataGridViewTextBoxColumn
            // 
            urlDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            urlDataGridViewTextBoxColumn.HeaderText = "Url";
            urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // gitHubRepoDataGridViewTextBoxColumn
            // 
            gitHubRepoDataGridViewTextBoxColumn.DataPropertyName = "GitHubRepo";
            gitHubRepoDataGridViewTextBoxColumn.HeaderText = "GitHubRepo";
            gitHubRepoDataGridViewTextBoxColumn.Name = "gitHubRepoDataGridViewTextBoxColumn";
            gitHubRepoDataGridViewTextBoxColumn.Visible = false;
            // 
            // gitHubUrlDataGridViewTextBoxColumn
            // 
            gitHubUrlDataGridViewTextBoxColumn.DataPropertyName = "GitHubUrl";
            gitHubUrlDataGridViewTextBoxColumn.HeaderText = "GitHubUrl";
            gitHubUrlDataGridViewTextBoxColumn.Name = "gitHubUrlDataGridViewTextBoxColumn";
            gitHubUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // gitUserDataGridViewTextBoxColumn
            // 
            gitUserDataGridViewTextBoxColumn.DataPropertyName = "GitUser";
            gitUserDataGridViewTextBoxColumn.HeaderText = "GitUser";
            gitUserDataGridViewTextBoxColumn.Name = "gitUserDataGridViewTextBoxColumn";
            gitUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // gitTokenDataGridViewTextBoxColumn
            // 
            gitTokenDataGridViewTextBoxColumn.DataPropertyName = "GitToken";
            gitTokenDataGridViewTextBoxColumn.HeaderText = "GitToken";
            gitTokenDataGridViewTextBoxColumn.Name = "gitTokenDataGridViewTextBoxColumn";
            gitTokenDataGridViewTextBoxColumn.Visible = false;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.HeaderText = "Path";
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.Visible = false;
            // 
            // clsDataBindingSource
            // 
            clsDataBindingSource.DataSource = typeof(clsData);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "설정";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(114, 6);
            button1.Name = "button1";
            button1.Size = new Size(54, 23);
            button1.TabIndex = 2;
            button1.Text = "Folder";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(174, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(610, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(8, 6);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Nginx 경로";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 530);
            Controls.Add(tabControl1);
            Name = "frmMain";
            Text = "nginx + spring boot 3 실행 관리자";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)clsDataBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView grid;
        private Panel panel1;
        private Button btnRun;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnStop;
        private TextBox textBox2;
        private BindingSource clsDataBindingSource;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceDisplayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitHubRepoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitHubUrlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitTokenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
    }
}
