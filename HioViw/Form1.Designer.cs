namespace HioViw
{
    partial class Form1
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

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Top_Option = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Download_Option = new System.Windows.Forms.Panel();
            this.Panel_DownloadPath = new System.Windows.Forms.Panel();
            this.Btn_DownloadPath = new System.Windows.Forms.Button();
            this.Text_DownloadPath = new System.Windows.Forms.TextBox();
            this.Label_DownloadPath = new System.Windows.Forms.Label();
            this.Panel_PageRange = new System.Windows.Forms.Panel();
            this.Label_PageRangeHow = new System.Windows.Forms.Label();
            this.Text_PageRange = new System.Windows.Forms.TextBox();
            this.Label_PageRange = new System.Windows.Forms.Label();
            this.Panel_Type = new System.Windows.Forms.Panel();
            this.ChkListBox_Type = new System.Windows.Forms.CheckedListBox();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Panel_Language = new System.Windows.Forms.Panel();
            this.ChkListBox_Language = new System.Windows.Forms.CheckedListBox();
            this.Label_Language = new System.Windows.Forms.Label();
            this.Panel_Download_Stat = new System.Windows.Forms.Panel();
            this.Panel_Download = new System.Windows.Forms.Panel();
            this.FolderBrowerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Panel_Top_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Download_Option.SuspendLayout();
            this.Panel_DownloadPath.SuspendLayout();
            this.Panel_PageRange.SuspendLayout();
            this.Panel_Type.SuspendLayout();
            this.Panel_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top_Option
            // 
            this.Panel_Top_Option.Controls.Add(this.pictureBox1);
            this.Panel_Top_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_Option.Location = new System.Drawing.Point(3, 3);
            this.Panel_Top_Option.Name = "Panel_Top_Option";
            this.Panel_Top_Option.Size = new System.Drawing.Size(778, 46);
            this.Panel_Top_Option.TabIndex = 1;
            this.Panel_Top_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HioViw.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Download_Option
            // 
            this.Panel_Download_Option.Controls.Add(this.Panel_DownloadPath);
            this.Panel_Download_Option.Controls.Add(this.Panel_PageRange);
            this.Panel_Download_Option.Controls.Add(this.Panel_Type);
            this.Panel_Download_Option.Controls.Add(this.Panel_Language);
            this.Panel_Download_Option.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Download_Option.Location = new System.Drawing.Point(3, 49);
            this.Panel_Download_Option.Name = "Panel_Download_Option";
            this.Panel_Download_Option.Size = new System.Drawing.Size(150, 459);
            this.Panel_Download_Option.TabIndex = 4;
            this.Panel_Download_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_DownloadPath
            // 
            this.Panel_DownloadPath.Controls.Add(this.Btn_DownloadPath);
            this.Panel_DownloadPath.Controls.Add(this.Text_DownloadPath);
            this.Panel_DownloadPath.Controls.Add(this.Label_DownloadPath);
            this.Panel_DownloadPath.Location = new System.Drawing.Point(6, 114);
            this.Panel_DownloadPath.Name = "Panel_DownloadPath";
            this.Panel_DownloadPath.Size = new System.Drawing.Size(138, 95);
            this.Panel_DownloadPath.TabIndex = 5;
            this.Panel_DownloadPath.Tag = "3";
            this.Panel_DownloadPath.Click += new System.EventHandler(this.Panel_Activate);
            this.Panel_DownloadPath.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Btn_DownloadPath
            // 
            this.Btn_DownloadPath.Location = new System.Drawing.Point(11, 62);
            this.Btn_DownloadPath.Name = "Btn_DownloadPath";
            this.Btn_DownloadPath.Size = new System.Drawing.Size(119, 23);
            this.Btn_DownloadPath.TabIndex = 5;
            this.Btn_DownloadPath.Text = "Setting";
            this.Btn_DownloadPath.UseVisualStyleBackColor = true;
            this.Btn_DownloadPath.Click += new System.EventHandler(this.Btn_DownloadPath_Click);
            // 
            // Text_DownloadPath
            // 
            this.Text_DownloadPath.Location = new System.Drawing.Point(11, 35);
            this.Text_DownloadPath.Name = "Text_DownloadPath";
            this.Text_DownloadPath.ReadOnly = true;
            this.Text_DownloadPath.Size = new System.Drawing.Size(119, 21);
            this.Text_DownloadPath.TabIndex = 4;
            // 
            // Label_DownloadPath
            // 
            this.Label_DownloadPath.AutoSize = true;
            this.Label_DownloadPath.ForeColor = System.Drawing.Color.LightGray;
            this.Label_DownloadPath.Location = new System.Drawing.Point(22, 9);
            this.Label_DownloadPath.Name = "Label_DownloadPath";
            this.Label_DownloadPath.Size = new System.Drawing.Size(90, 12);
            this.Label_DownloadPath.TabIndex = 3;
            this.Label_DownloadPath.Text = "Download Path";
            this.Label_DownloadPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_DownloadPath.Click += new System.EventHandler(this.Panel_Activate);
            // 
            // Panel_PageRange
            // 
            this.Panel_PageRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_PageRange.Controls.Add(this.Label_PageRangeHow);
            this.Panel_PageRange.Controls.Add(this.Text_PageRange);
            this.Panel_PageRange.Controls.Add(this.Label_PageRange);
            this.Panel_PageRange.Location = new System.Drawing.Point(6, 78);
            this.Panel_PageRange.Name = "Panel_PageRange";
            this.Panel_PageRange.Size = new System.Drawing.Size(138, 30);
            this.Panel_PageRange.TabIndex = 4;
            this.Panel_PageRange.Tag = "2";
            this.Panel_PageRange.Click += new System.EventHandler(this.Panel_Activate);
            this.Panel_PageRange.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Label_PageRangeHow
            // 
            this.Label_PageRangeHow.AutoSize = true;
            this.Label_PageRangeHow.ForeColor = System.Drawing.Color.Beige;
            this.Label_PageRangeHow.Location = new System.Drawing.Point(10, 70);
            this.Label_PageRangeHow.Name = "Label_PageRangeHow";
            this.Label_PageRangeHow.Size = new System.Drawing.Size(64, 12);
            this.Label_PageRangeHow.TabIndex = 4;
            this.Label_PageRangeHow.Text = "ex) {1-10}";
            // 
            // Text_PageRange
            // 
            this.Text_PageRange.Location = new System.Drawing.Point(11, 38);
            this.Text_PageRange.Name = "Text_PageRange";
            this.Text_PageRange.Size = new System.Drawing.Size(119, 21);
            this.Text_PageRange.TabIndex = 3;
            // 
            // Label_PageRange
            // 
            this.Label_PageRange.AutoSize = true;
            this.Label_PageRange.ForeColor = System.Drawing.Color.LightGray;
            this.Label_PageRange.Location = new System.Drawing.Point(29, 9);
            this.Label_PageRange.Name = "Label_PageRange";
            this.Label_PageRange.Size = new System.Drawing.Size(74, 12);
            this.Label_PageRange.TabIndex = 2;
            this.Label_PageRange.Text = "Page Range";
            this.Label_PageRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_PageRange.Click += new System.EventHandler(this.Panel_Activate);
            // 
            // Panel_Type
            // 
            this.Panel_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Type.Controls.Add(this.ChkListBox_Type);
            this.Panel_Type.Controls.Add(this.Label_Type);
            this.Panel_Type.Location = new System.Drawing.Point(6, 42);
            this.Panel_Type.Name = "Panel_Type";
            this.Panel_Type.Size = new System.Drawing.Size(138, 30);
            this.Panel_Type.TabIndex = 1;
            this.Panel_Type.Tag = "1";
            this.Panel_Type.Click += new System.EventHandler(this.Panel_Activate);
            this.Panel_Type.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
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
            "Artist CG"});
            this.ChkListBox_Type.Location = new System.Drawing.Point(12, 34);
            this.ChkListBox_Type.Name = "ChkListBox_Type";
            this.ChkListBox_Type.Size = new System.Drawing.Size(115, 64);
            this.ChkListBox_Type.TabIndex = 3;
            this.ChkListBox_Type.Click += new System.EventHandler(this.ChkListBox_Click);
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Type.Location = new System.Drawing.Point(43, 9);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(34, 12);
            this.Label_Type.TabIndex = 2;
            this.Label_Type.Text = "Type";
            this.Label_Type.Click += new System.EventHandler(this.Panel_Activate);
            // 
            // Panel_Language
            // 
            this.Panel_Language.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Language.Controls.Add(this.ChkListBox_Language);
            this.Panel_Language.Controls.Add(this.Label_Language);
            this.Panel_Language.Location = new System.Drawing.Point(6, 6);
            this.Panel_Language.Name = "Panel_Language";
            this.Panel_Language.Size = new System.Drawing.Size(138, 30);
            this.Panel_Language.TabIndex = 0;
            this.Panel_Language.Tag = "0";
            this.Panel_Language.Click += new System.EventHandler(this.Panel_Activate);
            this.Panel_Language.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // ChkListBox_Language
            // 
            this.ChkListBox_Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ChkListBox_Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkListBox_Language.CheckOnClick = true;
            this.ChkListBox_Language.ForeColor = System.Drawing.Color.Beige;
            this.ChkListBox_Language.FormattingEnabled = true;
            this.ChkListBox_Language.Items.AddRange(new object[] {
            "All",
            "Korean",
            "English",
            "Japanese",
            "Chinese"});
            this.ChkListBox_Language.Location = new System.Drawing.Point(12, 34);
            this.ChkListBox_Language.Name = "ChkListBox_Language";
            this.ChkListBox_Language.Size = new System.Drawing.Size(115, 80);
            this.ChkListBox_Language.TabIndex = 1;
            this.ChkListBox_Language.Click += new System.EventHandler(this.ChkListBox_Click);
            // 
            // Label_Language
            // 
            this.Label_Language.AutoSize = true;
            this.Label_Language.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Language.Location = new System.Drawing.Point(10, 9);
            this.Label_Language.Name = "Label_Language";
            this.Label_Language.Size = new System.Drawing.Size(117, 12);
            this.Label_Language.TabIndex = 0;
            this.Label_Language.Text = "Lang (Korean, Eng)";
            this.Label_Language.Click += new System.EventHandler(this.Panel_Activate);
            // 
            // Panel_Download_Stat
            // 
            this.Panel_Download_Stat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Download_Stat.Location = new System.Drawing.Point(153, 459);
            this.Panel_Download_Stat.Name = "Panel_Download_Stat";
            this.Panel_Download_Stat.Size = new System.Drawing.Size(628, 49);
            this.Panel_Download_Stat.TabIndex = 5;
            this.Panel_Download_Stat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Download
            // 
            this.Panel_Download.AutoScroll = true;
            this.Panel_Download.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Download.Location = new System.Drawing.Point(153, 49);
            this.Panel_Download.Name = "Panel_Download";
            this.Panel_Download.Size = new System.Drawing.Size(628, 410);
            this.Panel_Download.TabIndex = 6;
            this.Panel_Download.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.Panel_Download);
            this.Controls.Add(this.Panel_Download_Stat);
            this.Controls.Add(this.Panel_Download_Option);
            this.Controls.Add(this.Panel_Top_Option);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "HioViw";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Top_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Download_Option.ResumeLayout(false);
            this.Panel_DownloadPath.ResumeLayout(false);
            this.Panel_DownloadPath.PerformLayout();
            this.Panel_PageRange.ResumeLayout(false);
            this.Panel_PageRange.PerformLayout();
            this.Panel_Type.ResumeLayout(false);
            this.Panel_Type.PerformLayout();
            this.Panel_Language.ResumeLayout(false);
            this.Panel_Language.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top_Option;
        private System.Windows.Forms.Panel Panel_Download_Option;
        private System.Windows.Forms.Panel Panel_Download_Stat;
        private System.Windows.Forms.Panel Panel_Download;
        private System.Windows.Forms.Panel Panel_Language;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Language;
        private System.Windows.Forms.CheckedListBox ChkListBox_Language;
        private System.Windows.Forms.Panel Panel_Type;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.CheckedListBox ChkListBox_Type;
        private System.Windows.Forms.Panel Panel_PageRange;
        private System.Windows.Forms.Label Label_PageRangeHow;
        private System.Windows.Forms.TextBox Text_PageRange;
        private System.Windows.Forms.Label Label_PageRange;
        private System.Windows.Forms.Panel Panel_DownloadPath;
        private System.Windows.Forms.Button Btn_DownloadPath;
        private System.Windows.Forms.TextBox Text_DownloadPath;
        private System.Windows.Forms.Label Label_DownloadPath;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowerDialog;
    }
}

