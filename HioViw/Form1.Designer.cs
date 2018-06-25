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

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Top_Option = new System.Windows.Forms.Panel();
            this.Panel_Download_Option = new System.Windows.Forms.Panel();
            this.Btn_Option = new System.Windows.Forms.Button();
            this.Panel_Download_Select = new System.Windows.Forms.Panel();
            this.Btn_Preview = new System.Windows.Forms.Button();
            this.Panel_Download_Stat = new System.Windows.Forms.Panel();
            this.Panel_DownloadBar = new System.Windows.Forms.Panel();
            this.Panel_Downloade = new System.Windows.Forms.Panel();
            this.FolderBrowerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChkListBox_Type = new System.Windows.Forms.CheckedListBox();
            this.ChkListBox_Language = new System.Windows.Forms.ListBox();
            this.Panel_DownloadPath = new System.Windows.Forms.Panel();
            this.Btn_DownloadPath = new System.Windows.Forms.Button();
            this.Text_DownloadPath = new System.Windows.Forms.TextBox();
            this.Label_DownloadPath = new System.Windows.Forms.Label();
            this.Panel_TeamName = new System.Windows.Forms.Panel();
            this.Label_TeamName = new System.Windows.Forms.Label();
            this.Panel_Language = new System.Windows.Forms.Panel();
            this.Label_Language = new System.Windows.Forms.Label();
            this.Panel_Download = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_PageRange = new System.Windows.Forms.Panel();
            this.Label_PageRangeHow = new System.Windows.Forms.Label();
            this.Text_PageRange = new System.Windows.Forms.TextBox();
            this.Label_PageRange = new System.Windows.Forms.Label();
            this.Panel_Type = new System.Windows.Forms.Panel();
            this.Label_Type = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Panel_Downloaded = new HioViw.Panel_Downloaded();
            this.Panel_Top_Option.SuspendLayout();
            this.Panel_Download_Option.SuspendLayout();
            this.Panel_Download_Stat.SuspendLayout();
            this.Panel_Downloade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_DownloadPath.SuspendLayout();
            this.Panel_TeamName.SuspendLayout();
            this.Panel_Language.SuspendLayout();
            this.Panel_Download.SuspendLayout();
            this.Panel_PageRange.SuspendLayout();
            this.Panel_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top_Option
            // 
            this.Panel_Top_Option.Controls.Add(this.button4);
            this.Panel_Top_Option.Controls.Add(this.button3);
            this.Panel_Top_Option.Controls.Add(this.pictureBox1);
            this.Panel_Top_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_Option.Location = new System.Drawing.Point(3, 3);
            this.Panel_Top_Option.Name = "Panel_Top_Option";
            this.Panel_Top_Option.Size = new System.Drawing.Size(778, 46);
            this.Panel_Top_Option.TabIndex = 1;
            this.Panel_Top_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Download_Option
            // 
            this.Panel_Download_Option.AutoScroll = true;
            this.Panel_Download_Option.Controls.Add(this.Panel_Downloade);
            this.Panel_Download_Option.Controls.Add(this.button2);
            this.Panel_Download_Option.Controls.Add(this.button1);
            this.Panel_Download_Option.Controls.Add(this.Btn_Option);
            this.Panel_Download_Option.Controls.Add(this.Panel_Download_Select);
            this.Panel_Download_Option.Controls.Add(this.Btn_Preview);
            this.Panel_Download_Option.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Download_Option.Location = new System.Drawing.Point(3, 49);
            this.Panel_Download_Option.Name = "Panel_Download_Option";
            this.Panel_Download_Option.Size = new System.Drawing.Size(150, 459);
            this.Panel_Download_Option.TabIndex = 4;
            this.Panel_Download_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Btn_Option
            // 
            this.Btn_Option.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Option.FlatAppearance.BorderSize = 0;
            this.Btn_Option.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Option.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Option.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Option.Location = new System.Drawing.Point(11, 56);
            this.Btn_Option.Name = "Btn_Option";
            this.Btn_Option.Size = new System.Drawing.Size(138, 55);
            this.Btn_Option.TabIndex = 11;
            this.Btn_Option.Text = "Option";
            this.Btn_Option.UseVisualStyleBackColor = false;
            this.Btn_Option.Click += new System.EventHandler(this.Btn_Option_Click);
            // 
            // Panel_Download_Select
            // 
            this.Panel_Download_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Panel_Download_Select.Location = new System.Drawing.Point(1, 1);
            this.Panel_Download_Select.Name = "Panel_Download_Select";
            this.Panel_Download_Select.Size = new System.Drawing.Size(10, 55);
            this.Panel_Download_Select.TabIndex = 10;
            // 
            // Btn_Preview
            // 
            this.Btn_Preview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Preview.FlatAppearance.BorderSize = 0;
            this.Btn_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Preview.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Preview.Location = new System.Drawing.Point(11, 1);
            this.Btn_Preview.Name = "Btn_Preview";
            this.Btn_Preview.Size = new System.Drawing.Size(138, 55);
            this.Btn_Preview.TabIndex = 9;
            this.Btn_Preview.Text = "Preview";
            this.Btn_Preview.UseVisualStyleBackColor = false;
            this.Btn_Preview.Click += new System.EventHandler(this.Btn_Downloa_Click);
            // 
            // Panel_Download_Stat
            // 
            this.Panel_Download_Stat.Controls.Add(this.Panel_DownloadBar);
            this.Panel_Download_Stat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Download_Stat.Location = new System.Drawing.Point(153, 459);
            this.Panel_Download_Stat.Name = "Panel_Download_Stat";
            this.Panel_Download_Stat.Size = new System.Drawing.Size(628, 49);
            this.Panel_Download_Stat.TabIndex = 5;
            this.Panel_Download_Stat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_DownloadBar
            // 
            this.Panel_DownloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DownloadBar.Location = new System.Drawing.Point(33, 15);
            this.Panel_DownloadBar.Name = "Panel_DownloadBar";
            this.Panel_DownloadBar.Size = new System.Drawing.Size(569, 20);
            this.Panel_DownloadBar.TabIndex = 0;
            this.Panel_DownloadBar.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Downloade
            // 
            this.Panel_Downloade.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Downloade.Controls.Add(this.ChkListBox_Type);
            this.Panel_Downloade.Controls.Add(this.ChkListBox_Language);
            this.Panel_Downloade.Controls.Add(this.Panel_DownloadPath);
            this.Panel_Downloade.Controls.Add(this.Panel_TeamName);
            this.Panel_Downloade.Controls.Add(this.Panel_Language);
            this.Panel_Downloade.Controls.Add(this.Panel_Download);
            this.Panel_Downloade.Controls.Add(this.Panel_PageRange);
            this.Panel_Downloade.Controls.Add(this.Panel_Type);
            this.Panel_Downloade.Location = new System.Drawing.Point(44, 303);
            this.Panel_Downloade.Name = "Panel_Downloade";
            this.Panel_Downloade.Size = new System.Drawing.Size(69, 58);
            this.Panel_Downloade.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(11, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(11, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.ChkListBox_Type.Location = new System.Drawing.Point(437, 147);
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
            this.ChkListBox_Language.Location = new System.Drawing.Point(231, 140);
            this.ChkListBox_Language.Name = "ChkListBox_Language";
            this.ChkListBox_Language.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ChkListBox_Language.Size = new System.Drawing.Size(90, 80);
            this.ChkListBox_Language.TabIndex = 16;
            // 
            // Panel_DownloadPath
            // 
            this.Panel_DownloadPath.Controls.Add(this.Btn_DownloadPath);
            this.Panel_DownloadPath.Controls.Add(this.Text_DownloadPath);
            this.Panel_DownloadPath.Controls.Add(this.Label_DownloadPath);
            this.Panel_DownloadPath.Location = new System.Drawing.Point(141, 242);
            this.Panel_DownloadPath.Name = "Panel_DownloadPath";
            this.Panel_DownloadPath.Size = new System.Drawing.Size(138, 30);
            this.Panel_DownloadPath.TabIndex = 13;
            this.Panel_DownloadPath.Tag = "3";
            // 
            // Btn_DownloadPath
            // 
            this.Btn_DownloadPath.Location = new System.Drawing.Point(11, 62);
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
            // 
            // Panel_TeamName
            // 
            this.Panel_TeamName.Controls.Add(this.Label_TeamName);
            this.Panel_TeamName.Location = new System.Drawing.Point(77, 304);
            this.Panel_TeamName.Name = "Panel_TeamName";
            this.Panel_TeamName.Size = new System.Drawing.Size(138, 30);
            this.Panel_TeamName.TabIndex = 15;
            // 
            // Label_TeamName
            // 
            this.Label_TeamName.AutoSize = true;
            this.Label_TeamName.ForeColor = System.Drawing.Color.LightGray;
            this.Label_TeamName.Location = new System.Drawing.Point(29, 9);
            this.Label_TeamName.Name = "Label_TeamName";
            this.Label_TeamName.Size = new System.Drawing.Size(81, 12);
            this.Label_TeamName.TabIndex = 8;
            this.Label_TeamName.Text = "Team. Reflex";
            this.Label_TeamName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_Language
            // 
            this.Panel_Language.Controls.Add(this.Label_Language);
            this.Panel_Language.Location = new System.Drawing.Point(163, 37);
            this.Panel_Language.Name = "Panel_Language";
            this.Panel_Language.Size = new System.Drawing.Size(138, 131);
            this.Panel_Language.TabIndex = 9;
            this.Panel_Language.Tag = "0";
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
            // 
            // Panel_Download
            // 
            this.Panel_Download.Controls.Add(this.label1);
            this.Panel_Download.Location = new System.Drawing.Point(248, 343);
            this.Panel_Download.Name = "Panel_Download";
            this.Panel_Download.Padding = new System.Windows.Forms.Padding(3);
            this.Panel_Download.Size = new System.Drawing.Size(138, 30);
            this.Panel_Download.TabIndex = 14;
            this.Panel_Download.Tag = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Download";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_PageRange
            // 
            this.Panel_PageRange.Controls.Add(this.Label_PageRangeHow);
            this.Panel_PageRange.Controls.Add(this.Text_PageRange);
            this.Panel_PageRange.Controls.Add(this.Label_PageRange);
            this.Panel_PageRange.Location = new System.Drawing.Point(336, 278);
            this.Panel_PageRange.Name = "Panel_PageRange";
            this.Panel_PageRange.Size = new System.Drawing.Size(138, 30);
            this.Panel_PageRange.TabIndex = 12;
            this.Panel_PageRange.Tag = "2";
            // 
            // Label_PageRangeHow
            // 
            this.Label_PageRangeHow.AutoSize = true;
            this.Label_PageRangeHow.ForeColor = System.Drawing.Color.LightGray;
            this.Label_PageRangeHow.Location = new System.Drawing.Point(10, 70);
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
            this.Text_PageRange.Location = new System.Drawing.Point(11, 38);
            this.Text_PageRange.Name = "Text_PageRange";
            this.Text_PageRange.Size = new System.Drawing.Size(119, 21);
            this.Text_PageRange.TabIndex = 3;
            this.Text_PageRange.Text = "{1-1}";
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
            // 
            // Panel_Type
            // 
            this.Panel_Type.Controls.Add(this.Label_Type);
            this.Panel_Type.Location = new System.Drawing.Point(264, 37);
            this.Panel_Type.Name = "Panel_Type";
            this.Panel_Type.Size = new System.Drawing.Size(138, 43);
            this.Panel_Type.TabIndex = 10;
            this.Panel_Type.Tag = "1";
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
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(735, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(694, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "_";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Panel_Downloaded
            // 
            this.Panel_Downloaded.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Downloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Downloaded.Location = new System.Drawing.Point(153, 49);
            this.Panel_Downloaded.Name = "Panel_Downloaded";
            this.Panel_Downloaded.Size = new System.Drawing.Size(628, 410);
            this.Panel_Downloaded.TabIndex = 6;
            this.Panel_Downloaded.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // HioView_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.Panel_Downloaded);
            this.Controls.Add(this.Panel_Download_Stat);
            this.Controls.Add(this.Panel_Download_Option);
            this.Controls.Add(this.Panel_Top_Option);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HioView_Form";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "HioViw";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Top_Option.ResumeLayout(false);
            this.Panel_Download_Option.ResumeLayout(false);
            this.Panel_Download_Stat.ResumeLayout(false);
            this.Panel_Downloade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_DownloadPath.ResumeLayout(false);
            this.Panel_DownloadPath.PerformLayout();
            this.Panel_TeamName.ResumeLayout(false);
            this.Panel_TeamName.PerformLayout();
            this.Panel_Language.ResumeLayout(false);
            this.Panel_Language.PerformLayout();
            this.Panel_Download.ResumeLayout(false);
            this.Panel_Download.PerformLayout();
            this.Panel_PageRange.ResumeLayout(false);
            this.Panel_PageRange.PerformLayout();
            this.Panel_Type.ResumeLayout(false);
            this.Panel_Type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top_Option;
        private System.Windows.Forms.Panel Panel_Download_Option;
        private System.Windows.Forms.Panel Panel_Download_Stat;
        private System.Windows.Forms.Panel Panel_Downloade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowerDialog;
        private System.Windows.Forms.Panel Panel_DownloadBar;
        private System.Windows.Forms.Panel Panel_Download_Select;
        private System.Windows.Forms.Button Btn_Preview;
        private System.Windows.Forms.Button Btn_Option;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox ChkListBox_Type;
        private System.Windows.Forms.ListBox ChkListBox_Language;
        private System.Windows.Forms.Panel Panel_DownloadPath;
        private System.Windows.Forms.Button Btn_DownloadPath;
        private System.Windows.Forms.TextBox Text_DownloadPath;
        private System.Windows.Forms.Label Label_DownloadPath;
        private System.Windows.Forms.Panel Panel_TeamName;
        private System.Windows.Forms.Label Label_TeamName;
        private System.Windows.Forms.Panel Panel_Language;
        private System.Windows.Forms.Label Label_Language;
        private System.Windows.Forms.Panel Panel_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_PageRange;
        private System.Windows.Forms.Label Label_PageRangeHow;
        private System.Windows.Forms.TextBox Text_PageRange;
        private System.Windows.Forms.Label Label_PageRange;
        private System.Windows.Forms.Panel Panel_Type;
        private System.Windows.Forms.Label Label_Type;
        private Panel_Downloaded Panel_Downloaded;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

