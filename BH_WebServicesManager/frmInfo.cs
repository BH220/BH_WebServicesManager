using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BH_WebServicesManager
{
    public partial class frmInfo : Form
    {
        public clsData Data = null;
        private List<clsData> list = new List<clsData>();
        public frmInfo()
        {
            InitializeComponent();
        }

        public frmInfo(List<clsData> list)
        {
            InitializeComponent();
            this.list = list;
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
                txtGitToken.Text = Data.GitToken;
                txtGitUser.Text = Data.GitUser;
                txtPath.Text = Data.Path;
                SetEditorsReadOnly(true);
                btnDelete.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                SetEditorsReadOnly(false);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Data != null)
            {
                txtGitToken.Focus();
            }
        }

        private void SetEditorsReadOnly(bool enabled)
        {
            TextBox[] controls = { txtServiceName, txtDisplayName, txtUrl, txtGitUser,
                txtGitUrl, txtGitRepo};

            foreach (var c in controls)
                c.ReadOnly = enabled;
            btnFind.Enabled = !enabled;
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

            if (list.Any(x => x.ServiceName.Equals(txtServiceName.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("이미 존재하는 ServiceName 입니다.", "중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (Data == null)
                Data = new clsData();

            Data.ServiceName = txtServiceName.Text.Trim();
            Data.DisplayName = txtDisplayName.Text.Trim();
            Data.Url = txtUrl.Text.Trim();
            Data.GitHubUrl = txtGitUrl.Text.Trim();
            Data.GitHubRepo = txtGitRepo.Text.Trim();
            Data.GitUser = txtGitUser.Text.Trim();
            Data.GitToken = txtGitToken.Text.Trim();
            Data.Path = txtPath.Text.Trim();


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
