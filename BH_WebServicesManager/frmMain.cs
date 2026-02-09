using System.Diagnostics.Eventing.Reader;
using System.Text.Json;
using System.Windows.Forms;

namespace BH_WebServicesManager
{
    public partial class frmMain : Form
    {
        #region 변수, 생성자
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
                foreach (DataGridViewRow row in grid.Rows)
                {
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
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];

            if (row.DataBoundItem is not clsData data)
                return;

            using var frm = new frmInfo(data);

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // Data는 참조로 넘어갔기 때문에
                // 여기서는 grid 새로고침만 하면 됨
                grid.Refresh();
            }
        }
        #endregion

        #region 기타 이벤트
        #endregion

        #region 버튼이벤트
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
        }
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
