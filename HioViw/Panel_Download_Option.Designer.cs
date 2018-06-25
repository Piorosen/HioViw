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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.ChkListBox_Type.Location = new System.Drawing.Point(517, 93);
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
            this.Text_DownloadPath.Location = new System.Drawing.Point(373, 258);
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
            this.Text_PageRange.Location = new System.Drawing.Point(555, 302);
            this.Text_PageRange.Name = "Text_PageRange";
            this.Text_PageRange.Size = new System.Drawing.Size(119, 21);
            this.Text_PageRange.TabIndex = 3;
            this.Text_PageRange.Text = "{1-1}";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 287);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "ALL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Korean";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "English";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(0, 105);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(140, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Japanese";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 140);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(140, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Chinese";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Panel_Download_Option
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Text_DownloadPath);
            this.Controls.Add(this.ChkListBox_Type);
            this.Controls.Add(this.Text_PageRange);
            this.Controls.Add(this.ChkListBox_Language);
            this.Name = "Panel_Download_Option";
            this.Size = new System.Drawing.Size(840, 435);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox ChkListBox_Type;
        public System.Windows.Forms.ListBox ChkListBox_Language;
        public System.Windows.Forms.TextBox Text_DownloadPath;
        public System.Windows.Forms.TextBox Text_PageRange;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
