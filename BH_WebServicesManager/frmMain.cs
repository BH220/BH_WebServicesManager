using LibGit2Sharp;
using System.Diagnostics.Eventing.Reader;
using System.Net.NetworkInformation;
using System.ServiceProcess;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BH_WebServicesManager
{
    public partial class frmMain : Form
    {
        #region 변수, 생성자
        private bool _autoScroll = true;
        public string JsonPath = Application.StartupPath + "DataList.json";
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region 초기화 오버라이드
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitGrid();
            LoadData();
            txtLog.MouseDown += txtLog_MouseDown;
            txtLog.MouseWheel += txtLog_MouseWheel;
            txtLog.KeyDown += txtLog_KeyDown;
        }
        #endregion

        #region 그리드 관련 함수
        private void InitGrid()
        {
            var chk = new DataGridViewCheckBoxColumn
            {
                Name = "colCheck",
                HeaderText = "",
                Width = 40,
                ReadOnly = false
            };

            grid.Columns.Insert(0, chk);
            CheckBox headerCheck = new CheckBox
            {
                Size = new Size(15, 15)
            };

            headerCheck.CheckedChanged += (s, e) =>
            {
                // ⭐ 현재 편집 중인 셀 강제 커밋
                grid.EndEdit();

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                        row.Cells["colCheck"].Value = headerCheck.Checked;
                }
            };

            grid.Controls.Add(headerCheck);

            grid.CellPainting += (s, e) =>
            {
                if (e.RowIndex == -1 && e.ColumnIndex == 0)
                {
                    var rect = e.CellBounds;
                    headerCheck.Location = new Point(
                        rect.Left + (rect.Width - headerCheck.Width) / 2,
                        rect.Top + (rect.Height - headerCheck.Height) / 2
                    );
                }
            };

            grid.CellContentClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == grid.Columns["colCheck"].Index)
                {
                    grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };


        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];

            if (row.DataBoundItem is not clsData data)
                return;

            using var frm = new frmInfo(data);
            var result = frm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                grid.Refresh();
                SaveData();
            }
            else if (result == DialogResult.Abort)
            {
                DeleteData(frm.Data);
            }
        }
        #endregion

        #region 기타 이벤트
        private void txtLog_MouseDown(object sender, MouseEventArgs e)
        {
            _autoScroll = false;
        }

        private void txtLog_MouseWheel(object sender, MouseEventArgs e)
        {
            _autoScroll = false;
        }

        private void txtLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 콘솔처럼 Enter 누르면 다시 맨 아래로
                _autoScroll = true;
                txtLog.SelectionStart = txtLog.TextLength;
                txtLog.ScrollToCaret();
            }
            else
            {
                _autoScroll = false;
            }
        }
        #endregion

        #region 버튼이벤트

        private void button1_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Nginx 폴더를 선택하세요",
                UseDescriptionForTitle = true,
                ShowNewFolderButton = false
            };

            if (!string.IsNullOrWhiteSpace(txtNginxPath.Text) &&
                Directory.Exists(txtNginxPath.Text))
            {
                dialog.SelectedPath = txtNginxPath.Text;
            }

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                txtNginxPath.Text = dialog.SelectedPath;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            List<clsData> selectedRows = GetCheckedRows();
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            List<clsData> selectedRows = GetCheckedRows();
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //서비스 있는지 확인하고 없으면 생성
            //서비스 재시작
            //서비스 있는지 확인해서 없으면 생성

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmInfo frm = new frmInfo())
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AddData(frm.Data);
                }
                else if (result == DialogResult.Abort)
                {
                    DeleteData(frm.Data);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<clsData> selectedRows = GetCheckedRows();
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            clsData cData = selectedRows[0];
            Log($"[{cData.DisplayName}] 코드 업데이트");
            Log($"[{cData.ServiceName}] 을 검색합니다.");
            ServiceController sv = GetServiceByName(cData.ServiceName);
            if (sv != null)
            {
                if (sv.Status != ServiceControllerStatus.Stopped &&
                    sv.Status != ServiceControllerStatus.StopPending)
                {
                    sv.Stop();
                }

                // 중지될 때까지 대기 (예: 최대 30초)
                sv.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
            }
            //cData.Path 가 깃 저장소면 넘어가고 아니면 여기에 클론
            //
            //깃에서 코드 가져와
            //빌드해
        }
        #endregion

        #region 깃 관련 

        
        #endregion

        #region 사용자 함수
        private List<clsData> GetCheckedRows()
        {
            List<clsData> result = new List<clsData>();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                bool isChecked = row.Cells["colCheck"].Value is bool b && b;

                if (isChecked && row.DataBoundItem is clsData data)
                {
                    result.Add(data);
                }
            }

            return result;
        }

        private void Log(string text)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.BeginInvoke(new Action<string>(Log), text);
                return;
            }

            txtLog.AppendText(text + Environment.NewLine);

            if (_autoScroll)
            {
                txtLog.SelectionStart = txtLog.TextLength;
                txtLog.ScrollToCaret();
            }
        }

        public ServiceController? GetServiceByName(string serviceName)
        {
            if (string.IsNullOrWhiteSpace(serviceName))
                return null;

            return ServiceController.GetServices()
                .FirstOrDefault(s =>
                    string.Equals(s.ServiceName, serviceName, StringComparison.OrdinalIgnoreCase));
        }
        #endregion

        #region 데이터 처리

        private void LoadData()
        {
            List<clsData> list = new List<clsData>();
            if (File.Exists(JsonPath) == false)
            {
                File.WriteAllText(JsonPath, "");
            }
            else
            {
                string jsonContent = File.ReadAllText(JsonPath);
                if (string.IsNullOrEmpty(jsonContent) == false)
                {
                    try
                    {
                        list = JsonSerializer.Deserialize<List<clsData>>(jsonContent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("데이터 로드 중 오류가 발생했습니다.\n" + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            clsDataBindingSource.DataSource = list;
        }

        private void AddData(clsData data)
        {
            if (clsDataBindingSource.DataSource is List<clsData> list)
            {
                list.Add(data);
                clsDataBindingSource.ResetBindings(false);
                SaveData();
                FocusRowByServiceName(data.ServiceName, true);
                btnUpdate_Click(null, null);
                btnRun_Click(null, null);
            }
        }

        private void FocusRowByServiceName(string serviceName, bool run)
        {
            if (string.IsNullOrWhiteSpace(serviceName))
                return;

            if (run)
            {
                // 1. 모든 체크박스 해제
                foreach (DataGridViewRow r in grid.Rows)
                {
                    if (!r.IsNewRow)
                        r.Cells["colCheck"].Value = false;
                }
            }

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.DataBoundItem is clsData d &&
                    string.Equals(d.ServiceName, serviceName, StringComparison.OrdinalIgnoreCase))
                {
                    grid.ClearSelection();
                    row.Selected = true;
                    grid.CurrentCell = row.Cells[grid.Columns["serviceNameDataGridViewTextBoxColumn"].Index];
                    grid.FirstDisplayedScrollingRowIndex = row.Index;

                    // 2. 해당 행만 체크
                    if (run)
                        row.Cells["colCheck"].Value = true;

                    break;
                }
            }
        }


        private void DeleteData(clsData data)
        {
            if (clsDataBindingSource.DataSource is List<clsData> list)
            {
                list.Remove(data);
                clsDataBindingSource.ResetBindings(false);
                SaveData();
            }
        }

        private void SaveData()
        {
            List<clsData> list = clsDataBindingSource.DataSource as List<clsData>;
            string jsonStr = JsonSerializer.Serialize(list);
            File.WriteAllText(JsonPath, jsonStr);
        }


        #endregion

    }
}
