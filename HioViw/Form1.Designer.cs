namespace HioViw
{
    partial class HioView_Form
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

        #region Windows Form 디자이너에서 생성한 코드

        private System.Windows.Forms.FolderBrowserDialog FolderBrowerDialog;
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderBrowerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.downloadPage = new HioViw.DownloadPage();
            this.SuspendLayout();
            // 
            // downloadPage
            // 
            this.downloadPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.downloadPage.Location = new System.Drawing.Point(3, 3);
            this.downloadPage.Name = "downloadPage";
            this.downloadPage.Padding = new System.Windows.Forms.Padding(3);
            this.downloadPage.Size = new System.Drawing.Size(1053, 562);
            this.downloadPage.TabIndex = 1;
            // 
            // HioView_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1059, 568);
            this.Controls.Add(this.downloadPage);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "HioView_Form";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ResumeLayout(false);

        }



        #endregion

        private HioViw.DownloadPage downloadPage;
    }
}

