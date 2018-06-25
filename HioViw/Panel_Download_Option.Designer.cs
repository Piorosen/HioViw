namespace HioViw
{
    partial class Panel_Download_Option
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
            this.ChkListBox_Type = new System.Windows.Forms.CheckedListBox();
            this.ChkListBox_Language = new System.Windows.Forms.ListBox();
            this.Btn_DownloadPath = new System.Windows.Forms.Button();
            this.Text_DownloadPath = new System.Windows.Forms.TextBox();
            this.Label_PageRangeHow = new System.Windows.Forms.Label();
            this.Text_PageRange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChkListBox_Type
            // 
            this.ChkListBox_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ChkListBox_Type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkListBox_Type.CheckOnClick = true;
            this.ChkListBox_Type.ColumnWidth = 20;
            this.ChkListBox_Type.ForeColor = System.Drawing.Color.Beige;
            this.ChkListBox_Type.Items.AddRange(new object[] {
            "All",
            "Manga",
            "Doujinshi",
            "Artist CG",
            "Game CG"});
            this.ChkListBox_Type.Location = new System.Drawing.Point(470, 136);
            this.ChkListBox_Type.Name = "ChkListBox_Type";
            this.ChkListBox_Type.Size = new System.Drawing.Size(115, 80);
            this.ChkListBox_Type.TabIndex = 11;
            // 
            // ChkListBox_Language
            // 
            this.ChkListBox_Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ChkListBox_Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkListBox_Language.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkListBox_Language.ForeColor = System.Drawing.Color.Beige;
            this.ChkListBox_Language.FormattingEnabled = true;
            this.ChkListBox_Language.ItemHeight = 16;
            this.ChkListBox_Language.Items.AddRange(new object[] {
            "All",
            "Korean",
            "English",
            "Japanese",
            "Chinese"});
            this.ChkListBox_Language.Location = new System.Drawing.Point(264, 129);
            this.ChkListBox_Language.Name = "ChkListBox_Language";
            this.ChkListBox_Language.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ChkListBox_Language.Size = new System.Drawing.Size(90, 80);
            this.ChkListBox_Language.TabIndex = 16;
            // 
            // Btn_DownloadPath
            // 
            this.Btn_DownloadPath.Location = new System.Drawing.Point(345, 302);
            this.Btn_DownloadPath.Name = "Btn_DownloadPath";
            this.Btn_DownloadPath.Size = new System.Drawing.Size(119, 23);
            this.Btn_DownloadPath.TabIndex = 5;
            this.Btn_DownloadPath.Text = "Setting";
            this.Btn_DownloadPath.UseVisualStyleBackColor = true;
            // 
            // Text_DownloadPath
            // 
            this.Text_DownloadPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Text_DownloadPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_DownloadPath.ForeColor = System.Drawing.Color.LightGray;
            this.Text_DownloadPath.Location = new System.Drawing.Point(345, 275);
            this.Text_DownloadPath.Name = "Text_DownloadPath";
            this.Text_DownloadPath.ReadOnly = true;
            this.Text_DownloadPath.Size = new System.Drawing.Size(119, 21);
            this.Text_DownloadPath.TabIndex = 4;
            // 
            // Label_PageRangeHow
            // 
            this.Label_PageRangeHow.AutoSize = true;
            this.Label_PageRangeHow.ForeColor = System.Drawing.Color.LightGray;
            this.Label_PageRangeHow.Location = new System.Drawing.Point(554, 334);
            this.Label_PageRangeHow.Name = "Label_PageRangeHow";
            this.Label_PageRangeHow.Size = new System.Drawing.Size(52, 12);
            this.Label_PageRangeHow.TabIndex = 4;
            this.Label_PageRangeHow.Text = "ex) 1-10";
            // 
            // Text_PageRange
            // 
            this.Text_PageRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Text_PageRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_PageRange.ForeColor = System.Drawing.Color.LightGray;
            this.Text_PageRange.Location = new System.Drawing.Point(555, 302);
            this.Text_PageRange.Name = "Text_PageRange";
            this.Text_PageRange.Size = new System.Drawing.Size(119, 21);
            this.Text_PageRange.TabIndex = 3;
            this.Text_PageRange.Text = "{1-1}";
            // 
            // Panel_Download_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_DownloadPath);
            this.Controls.Add(this.Label_PageRangeHow);
            this.Controls.Add(this.Text_DownloadPath);
            this.Controls.Add(this.ChkListBox_Type);
            this.Controls.Add(this.Text_PageRange);
            this.Controls.Add(this.ChkListBox_Language);
            this.Name = "Panel_Download_Option";
            this.Size = new System.Drawing.Size(695, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChkListBox_Type;
        private System.Windows.Forms.ListBox ChkListBox_Language;
        private System.Windows.Forms.Button Btn_DownloadPath;
        private System.Windows.Forms.TextBox Text_DownloadPath;
        private System.Windows.Forms.Label Label_PageRangeHow;
        private System.Windows.Forms.TextBox Text_PageRange;
    }
}
