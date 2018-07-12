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
            this.Text_DownloadPath = new System.Windows.Forms.TextBox();
            this.Text_PageRange = new System.Windows.Forms.TextBox();
            this.Panel_Language = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Lang_All = new System.Windows.Forms.Button();
            this.Btn_Lang_Korean = new System.Windows.Forms.Button();
            this.Btn_Lang_English = new System.Windows.Forms.Button();
            this.Btn_Lang_Japanese = new System.Windows.Forms.Button();
            this.Btn_Lang_Chinese = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Language.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.ChkListBox_Type.Location = new System.Drawing.Point(302, 107);
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
            this.ChkListBox_Language.Location = new System.Drawing.Point(701, 126);
            this.ChkListBox_Language.Name = "ChkListBox_Language";
            this.ChkListBox_Language.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ChkListBox_Language.Size = new System.Drawing.Size(90, 80);
            this.ChkListBox_Language.TabIndex = 16;
            // 
            // Text_DownloadPath
            // 
            this.Text_DownloadPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Text_DownloadPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_DownloadPath.ForeColor = System.Drawing.Color.LightGray;
            this.Text_DownloadPath.Location = new System.Drawing.Point(245, 325);
            this.Text_DownloadPath.Name = "Text_DownloadPath";
            this.Text_DownloadPath.ReadOnly = true;
            this.Text_DownloadPath.Size = new System.Drawing.Size(119, 21);
            this.Text_DownloadPath.TabIndex = 4;
            // 
            // Text_PageRange
            // 
            this.Text_PageRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Text_PageRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_PageRange.ForeColor = System.Drawing.Color.LightGray;
            this.Text_PageRange.Location = new System.Drawing.Point(22, 70);
            this.Text_PageRange.Name = "Text_PageRange";
            this.Text_PageRange.Size = new System.Drawing.Size(231, 21);
            this.Text_PageRange.TabIndex = 3;
            this.Text_PageRange.Text = "1-1";
            // 
            // Panel_Language
            // 
            this.Panel_Language.Controls.Add(this.Btn_Lang_All);
            this.Panel_Language.Controls.Add(this.Btn_Lang_Korean);
            this.Panel_Language.Controls.Add(this.Btn_Lang_English);
            this.Panel_Language.Controls.Add(this.Btn_Lang_Japanese);
            this.Panel_Language.Controls.Add(this.Btn_Lang_Chinese);
            this.Panel_Language.Location = new System.Drawing.Point(129, 82);
            this.Panel_Language.Name = "Panel_Language";
            this.Panel_Language.Size = new System.Drawing.Size(140, 175);
            this.Panel_Language.TabIndex = 17;
            this.Panel_Language.Tag = "all";
            // 
            // Btn_Lang_All
            // 
            this.Btn_Lang_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Lang_All.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Lang_All.FlatAppearance.BorderSize = 0;
            this.Btn_Lang_All.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Lang_All.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Lang_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Lang_All.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Lang_All.Location = new System.Drawing.Point(0, 0);
            this.Btn_Lang_All.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Lang_All.Name = "Btn_Lang_All";
            this.Btn_Lang_All.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Lang_All.Size = new System.Drawing.Size(140, 35);
            this.Btn_Lang_All.TabIndex = 0;
            this.Btn_Lang_All.Text = "ALL";
            this.Btn_Lang_All.UseVisualStyleBackColor = false;
            this.Btn_Lang_All.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Down);
            this.Btn_Lang_All.MouseEnter += new System.EventHandler(this.Btn_Lang_Enter);
            this.Btn_Lang_All.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Up);
            // 
            // Btn_Lang_Korean
            // 
            this.Btn_Lang_Korean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Lang_Korean.FlatAppearance.BorderSize = 0;
            this.Btn_Lang_Korean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Lang_Korean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Lang_Korean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Lang_Korean.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Lang_Korean.Location = new System.Drawing.Point(0, 35);
            this.Btn_Lang_Korean.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Lang_Korean.Name = "Btn_Lang_Korean";
            this.Btn_Lang_Korean.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Lang_Korean.Size = new System.Drawing.Size(140, 35);
            this.Btn_Lang_Korean.TabIndex = 1;
            this.Btn_Lang_Korean.Text = "Korean";
            this.Btn_Lang_Korean.UseVisualStyleBackColor = true;
            this.Btn_Lang_Korean.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Down);
            this.Btn_Lang_Korean.MouseEnter += new System.EventHandler(this.Btn_Lang_Enter);
            this.Btn_Lang_Korean.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Up);
            // 
            // Btn_Lang_English
            // 
            this.Btn_Lang_English.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Lang_English.FlatAppearance.BorderSize = 0;
            this.Btn_Lang_English.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Lang_English.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Lang_English.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Lang_English.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Lang_English.Location = new System.Drawing.Point(0, 70);
            this.Btn_Lang_English.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Lang_English.Name = "Btn_Lang_English";
            this.Btn_Lang_English.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Lang_English.Size = new System.Drawing.Size(140, 35);
            this.Btn_Lang_English.TabIndex = 2;
            this.Btn_Lang_English.Text = "English";
            this.Btn_Lang_English.UseVisualStyleBackColor = true;
            this.Btn_Lang_English.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Down);
            this.Btn_Lang_English.MouseEnter += new System.EventHandler(this.Btn_Lang_Enter);
            this.Btn_Lang_English.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Up);
            // 
            // Btn_Lang_Japanese
            // 
            this.Btn_Lang_Japanese.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Lang_Japanese.FlatAppearance.BorderSize = 0;
            this.Btn_Lang_Japanese.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Lang_Japanese.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Lang_Japanese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Lang_Japanese.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Lang_Japanese.Location = new System.Drawing.Point(0, 105);
            this.Btn_Lang_Japanese.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Lang_Japanese.Name = "Btn_Lang_Japanese";
            this.Btn_Lang_Japanese.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Lang_Japanese.Size = new System.Drawing.Size(140, 35);
            this.Btn_Lang_Japanese.TabIndex = 3;
            this.Btn_Lang_Japanese.Text = "Japanese";
            this.Btn_Lang_Japanese.UseVisualStyleBackColor = true;
            this.Btn_Lang_Japanese.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Down);
            this.Btn_Lang_Japanese.MouseEnter += new System.EventHandler(this.Btn_Lang_Enter);
            this.Btn_Lang_Japanese.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Up);
            // 
            // Btn_Lang_Chinese
            // 
            this.Btn_Lang_Chinese.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Lang_Chinese.FlatAppearance.BorderSize = 0;
            this.Btn_Lang_Chinese.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Lang_Chinese.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Lang_Chinese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Lang_Chinese.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Lang_Chinese.Location = new System.Drawing.Point(0, 140);
            this.Btn_Lang_Chinese.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Lang_Chinese.Name = "Btn_Lang_Chinese";
            this.Btn_Lang_Chinese.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Lang_Chinese.Size = new System.Drawing.Size(140, 35);
            this.Btn_Lang_Chinese.TabIndex = 4;
            this.Btn_Lang_Chinese.Text = "Chinese";
            this.Btn_Lang_Chinese.UseVisualStyleBackColor = true;
            this.Btn_Lang_Chinese.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Down);
            this.Btn_Lang_Chinese.MouseEnter += new System.EventHandler(this.Btn_Lang_Enter);
            this.Btn_Lang_Chinese.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Lang_Up);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Text_PageRange);
            this.panel1.Location = new System.Drawing.Point(556, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 103);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Download Range : ex) 1-100";
            // 
            // Panel_Download_Option
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Language);
            this.Controls.Add(this.Text_DownloadPath);
            this.Controls.Add(this.ChkListBox_Type);
            this.Controls.Add(this.ChkListBox_Language);
            this.Name = "Panel_Download_Option";
            this.Size = new System.Drawing.Size(840, 435);
            this.Panel_Language.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox ChkListBox_Type;
        public System.Windows.Forms.ListBox ChkListBox_Language;
        public System.Windows.Forms.TextBox Text_DownloadPath;
        public System.Windows.Forms.TextBox Text_PageRange;
        private System.Windows.Forms.Button Btn_Lang_All;
        private System.Windows.Forms.Button Btn_Lang_Korean;
        private System.Windows.Forms.Button Btn_Lang_English;
        private System.Windows.Forms.Button Btn_Lang_Japanese;
        private System.Windows.Forms.Button Btn_Lang_Chinese;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel Panel_Language;
    }
}
