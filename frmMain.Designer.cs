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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            grid = new DataGridView();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gitUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gitTokenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clsDataBindingSource = new BindingSource(components);
            txtLog = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRun = new Button();
            btnStop = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            tabPage2 = new TabPage();
            button1 = new Button();
            txtNginxPath = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clsDataBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
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
            tabControl1.Size = new Size(1484, 729);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1476, 701);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "대시보드";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grid);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtLog);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(1470, 695);
            splitContainer1.SplitterDistance = 482;
            splitContainer1.TabIndex = 1;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AutoGenerateColumns = false;
            grid.BorderStyle = BorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { serviceNameDataGridViewTextBoxColumn, displayNameDataGridViewTextBoxColumn, urlDataGridViewTextBoxColumn, gitUserDataGridViewTextBoxColumn, gitTokenDataGridViewTextBoxColumn, pathDataGridViewTextBoxColumn });
            grid.DataSource = clsDataBindingSource;
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(0, 0);
            grid.Name = "grid";
            grid.RowHeadersVisible = false;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(482, 695);
            grid.TabIndex = 0;
            grid.CellDoubleClick += grid_CellDoubleClick;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.Width = 102;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            displayNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            displayNameDataGridViewTextBoxColumn.Width = 103;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            urlDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            urlDataGridViewTextBoxColumn.HeaderText = "Url";
            urlDataGridViewTextBoxColumn.MinimumWidth = 200;
            urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
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
            // txtLog
            // 
            txtLog.BackColor = SystemColors.ActiveCaptionText;
            txtLog.Dock = DockStyle.Fill;
            txtLog.ForeColor = SystemColors.Window;
            txtLog.Location = new Point(0, 30);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(984, 665);
            txtLog.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnRun);
            flowLayoutPanel1.Controls.Add(btnStop);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(984, 30);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txtNginxPath);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1476, 701);
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
            button1.Click += button1_Click;
            // 
            // txtNginxPath
            // 
            txtNginxPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNginxPath.Location = new Point(174, 6);
            txtNginxPath.Name = "txtNginxPath";
            txtNginxPath.Size = new Size(610, 23);
            txtNginxPath.TabIndex = 1;
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
            ClientSize = new Size(1484, 729);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "nginx + spring boot 3 실행 관리자";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)clsDataBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TextBox txtNginxPath;
        private Label label1;
        private DataGridView grid;
        private Button btnRun;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnStop;
        private TextBox txtLog;
        private BindingSource clsDataBindingSource;
        private DataGridViewTextBoxColumn serviceDisplayNameDataGridViewTextBoxColumn;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer1;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitHubRepoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitHubUrlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gitTokenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
    }
}
