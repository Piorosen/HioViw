namespace HioViw
{
    partial class DownloadViewer
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
            this.Panel_Search_Page = new System.Windows.Forms.Panel();
            this.Label_Select_Page = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Text_Select_Page = new System.Windows.Forms.TextBox();
            this.Panel_Downloaded = new System.Windows.Forms.Panel();
            this.Panel_Search_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Search_Page
            // 
            this.Panel_Search_Page.Controls.Add(this.Label_Select_Page);
            this.Panel_Search_Page.Controls.Add(this.label10);
            this.Panel_Search_Page.Controls.Add(this.Text_Select_Page);
            this.Panel_Search_Page.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Search_Page.Location = new System.Drawing.Point(0, 591);
            this.Panel_Search_Page.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Search_Page.Name = "Panel_Search_Page";
            this.Panel_Search_Page.Size = new System.Drawing.Size(1021, 34);
            this.Panel_Search_Page.TabIndex = 13;
            this.Panel_Search_Page.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Label_Select_Page
            // 
            this.Label_Select_Page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Select_Page.AutoSize = true;
            this.Label_Select_Page.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Select_Page.Location = new System.Drawing.Point(586, 12);
            this.Label_Select_Page.Name = "Label_Select_Page";
            this.Label_Select_Page.Size = new System.Drawing.Size(24, 12);
            this.Label_Select_Page.TabIndex = 2;
            this.Label_Select_Page.Text = "~ 1";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(409, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "1 ~";
            // 
            // Text_Select_Page
            // 
            this.Text_Select_Page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Select_Page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Text_Select_Page.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Select_Page.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_Select_Page.ForeColor = System.Drawing.Color.LightGray;
            this.Text_Select_Page.Location = new System.Drawing.Point(439, 9);
            this.Text_Select_Page.Name = "Text_Select_Page";
            this.Text_Select_Page.Size = new System.Drawing.Size(141, 19);
            this.Text_Select_Page.TabIndex = 0;
            this.Text_Select_Page.TabStop = false;
            this.Text_Select_Page.Text = "1";
            this.Text_Select_Page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel_Downloaded
            // 
            this.Panel_Downloaded.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Downloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Downloaded.Location = new System.Drawing.Point(0, 0);
            this.Panel_Downloaded.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Downloaded.Name = "Panel_Downloaded";
            this.Panel_Downloaded.Size = new System.Drawing.Size(1021, 591);
            this.Panel_Downloaded.TabIndex = 14;
            this.Panel_Downloaded.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // DownloadViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Panel_Downloaded);
            this.Controls.Add(this.Panel_Search_Page);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DownloadViewer";
            this.Size = new System.Drawing.Size(1021, 625);
            this.Panel_Search_Page.ResumeLayout(false);
            this.Panel_Search_Page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Panel Panel_Search_Page;
        public System.Windows.Forms.Panel Panel_Downloaded;
        public System.Windows.Forms.TextBox Text_Select_Page;
        public System.Windows.Forms.Label Label_Select_Page;
    }
}
