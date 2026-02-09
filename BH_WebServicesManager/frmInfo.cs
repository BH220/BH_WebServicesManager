using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_WebServicesManager
{
    public partial class frmInfo : Form
    {
        public clsData Data = null;
        public frmInfo()
        {
            InitializeComponent();
        }

        public frmInfo(clsData data)
        {
            InitializeComponent();
            this.Data = data;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Data != null)
            {
                txtServiceName.Text = Data.ServiceName;
                txtDisplayName.Text = Data.DisplayName;
                txtUrl.Text = Data.Url;
                txtGitUrl.Text = Data.GitHubUrl;
                txtGitRepo.Text = Data.GitHubRepo;
                txtGitToken.Text = Data.GitUser;
                txtPath.Text = Data.Path;
                SetEditorsEnabled(false);
                txtGitToken.Enabled = true;
                txtGitToken.Focus();
            }
            else
            {
                SetEditorsEnabled(true);
            }
        }

        private void SetEditorsEnabled(bool enabled)
        {
            Control[] controls = { txtServiceName, txtDisplayName, txtUrl, txtGitUrl, txtGitRepo, txtGitToken, txtPath, btnFind };

            foreach (var c in controls)
                c.Enabled = enabled;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "폴더를 선택하세요",
                UseDescriptionForTitle = true,
                ShowNewFolderButton = false
            };

            if (!string.IsNullOrWhiteSpace(txtPath.Text) && Directory.Exists(txtPath.Text))
            {
                dialog.SelectedPath = txtPath.Text;
            }

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath;
            }
        }

        private bool ValidateInputs()
        {
            var fields = new (TextBox Box, string Name)[]
            {
        (txtServiceName, "Service Name"),
        (txtDisplayName, "Display Name"),
        (txtUrl, "URL"),
        (txtGitUrl, "GitHub URL"),
        (txtGitRepo, "GitHub Repository"),
        (txtGitToken, "Git User"),
        (txtPath, "Path")
            };

            foreach (var (box, name) in fields)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    MessageBox.Show($"{name} 항목은 필수입니다.",
                        "입력 오류",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    box.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (Data == null)
                Data = new clsData();

            Data.ServiceName = txtServiceName.Text;
            Data.DisplayName = txtDisplayName.Text;
            Data.Url = txtUrl.Text;
            Data.GitHubUrl = txtGitUrl.Text;
            Data.GitHubRepo = txtGitRepo.Text;
            Data.GitUser = txtGitToken.Text;
            Data.Path = txtPath.Text;


            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("삭제 하시겠습니까?","확인", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                Close();
            }
        }
    }
}
