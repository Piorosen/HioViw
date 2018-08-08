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
            this.optionPage = new HioViw.OptionPage();
            this.downloadPage = new HioViw.DownloadPage();
            this.viewerPage = new HioViw.ViewerPage();
            this.SuspendLayout();
            // 
            // optionPage
            // 
            this.optionPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.optionPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionPage.Location = new System.Drawing.Point(0, 0);
            this.optionPage.Name = "optionPage";
            this.optionPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionPage.Size = new System.Drawing.Size(1059, 568);
            this.optionPage.Change += Page_Change;
            this.optionPage.TabIndex = 0;
            // 
            // downloadPage
            // 
            this.downloadPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.downloadPage.Location = new System.Drawing.Point(0, 0);
            this.downloadPage.Name = "downloadPage";
            this.downloadPage.Padding = new System.Windows.Forms.Padding(3);
            this.downloadPage.Size = new System.Drawing.Size(1059, 568);
            this.downloadPage.Change += Page_Change;
            this.downloadPage.TabIndex = 0;
            // 
            // viewerPage
            // 
            this.viewerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.viewerPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewerPage.Location = new System.Drawing.Point(0, 0);
            this.viewerPage.Name = "viewerPage";
            this.viewerPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewerPage.Size = new System.Drawing.Size(1059, 568);
            this.viewerPage.Change += Page_Change;
            this.viewerPage.TabIndex = 0;
            // 
            // HioView_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1059, 568);
            this.Controls.Add(this.downloadPage);
            this.Controls.Add(this.viewerPage);
            this.Controls.Add(this.optionPage);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "HioView_Form";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "HioViw 1.4.7";
            this.ResumeLayout(false);

        }
        

        #endregion

        private OptionPage optionPage;
        private DownloadPage downloadPage;
        private ViewerPage viewerPage;
    }
}

