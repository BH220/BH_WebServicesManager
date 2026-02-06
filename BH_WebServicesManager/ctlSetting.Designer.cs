namespace BH_WebServicesManager
{
    partial class ctlSetting
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 99);
            label1.Name = "label1";
            label1.Size = new Size(490, 90);
            label1.TabIndex = 0;
            label1.Text = "nginx 경로\r\nnginx 설정 파일 편집 \r\n각 서비스 경로 (목록)\r\n을 제공해서 대시보드 탭에서 구현 가능하게 처리 \r\n\r\n서비스는 스프링 부트의 서비스를 기준으로 하고, 윈도우 서비스랑 연계 할 수 있도록 처리\r\n";
            // 
            // ctlSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label1);
            Name = "ctlSetting";
            Size = new Size(638, 360);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
