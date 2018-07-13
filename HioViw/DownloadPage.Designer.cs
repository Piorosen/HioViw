namespace HioViw
{
    partial class DownloadPage
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
            this.FolderBrowerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Panel_Top_Option = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Menu = new System.Windows.Forms.PictureBox();
            this.Btn_Preview = new System.Windows.Forms.Button();
            this.Btn_Option = new System.Windows.Forms.Button();
            this.Btn_Hompage = new System.Windows.Forms.Button();
            this.Btn_DownloadStart = new System.Windows.Forms.Button();
            this.Panel_Download_OptionList = new System.Windows.Forms.Panel();
            this.Btn_SearchResult = new System.Windows.Forms.Button();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Search_Range = new System.Windows.Forms.Button();
            this.Btn_Search_Series = new System.Windows.Forms.Button();
            this.Btn_Search_Tags = new System.Windows.Forms.Button();
            this.Btn_Search_Character = new System.Windows.Forms.Button();
            this.Btn_Search_Language = new System.Windows.Forms.Button();
            this.Btn_Search_Title = new System.Windows.Forms.Button();
            this.Panel_DownloadBar = new System.Windows.Forms.Panel();
            this.Panel_Download_Stat = new System.Windows.Forms.Panel();
            this.Panel_Downloaded = new System.Windows.Forms.Panel();
            this.Panel_Top_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).BeginInit();
            this.Panel_Download_OptionList.SuspendLayout();
            this.Panel_Search.SuspendLayout();
            this.Panel_Download_Stat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top_Option
            // 
            this.Panel_Top_Option.Controls.Add(this.pictureBox2);
            this.Panel_Top_Option.Controls.Add(this.pictureBox1);
            this.Panel_Top_Option.Controls.Add(this.Btn_Menu);
            this.Panel_Top_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_Option.Location = new System.Drawing.Point(3, 3);
            this.Panel_Top_Option.Name = "Panel_Top_Option";
            this.Panel_Top_Option.Size = new System.Drawing.Size(990, 46);
            this.Panel_Top_Option.TabIndex = 1;
            this.Panel_Top_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HioViw.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(124, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HioViw.Properties.Resources.download_button;
            this.pictureBox1.Location = new System.Drawing.Point(71, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Menu.Image = global::HioViw.Properties.Resources.menu;
            this.Btn_Menu.Location = new System.Drawing.Point(10, 8);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(30, 30);
            this.Btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Menu.TabIndex = 0;
            this.Btn_Menu.TabStop = false;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Btn_Preview
            // 
            this.Btn_Preview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Preview.FlatAppearance.BorderSize = 0;
            this.Btn_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Preview.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Preview.Location = new System.Drawing.Point(1, 0);
            this.Btn_Preview.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Preview.Name = "Btn_Preview";
            this.Btn_Preview.Size = new System.Drawing.Size(148, 55);
            this.Btn_Preview.TabIndex = 9;
            this.Btn_Preview.Tag = false;
            this.Btn_Preview.Text = "다운로드 된 목록";
            this.Btn_Preview.UseVisualStyleBackColor = false;
            this.Btn_Preview.Click += new System.EventHandler(this.Btn_Downloa_Click);
            // 
            // Btn_Option
            // 
            this.Btn_Option.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Option.FlatAppearance.BorderSize = 0;
            this.Btn_Option.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Option.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Option.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Option.Location = new System.Drawing.Point(1, 110);
            this.Btn_Option.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Option.Name = "Btn_Option";
            this.Btn_Option.Size = new System.Drawing.Size(148, 55);
            this.Btn_Option.TabIndex = 11;
            this.Btn_Option.Tag = false;
            this.Btn_Option.Text = "검색";
            this.Btn_Option.UseVisualStyleBackColor = false;
            this.Btn_Option.Click += new System.EventHandler(this.Btn_Option_Click);
            // 
            // Btn_Hompage
            // 
            this.Btn_Hompage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Hompage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Hompage.FlatAppearance.BorderSize = 0;
            this.Btn_Hompage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Hompage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Hompage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Hompage.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Hompage.Location = new System.Drawing.Point(1, 570);
            this.Btn_Hompage.Name = "Btn_Hompage";
            this.Btn_Hompage.Size = new System.Drawing.Size(148, 55);
            this.Btn_Hompage.TabIndex = 12;
            this.Btn_Hompage.Text = "Home Page";
            this.Btn_Hompage.UseVisualStyleBackColor = false;
            // 
            // Btn_DownloadStart
            // 
            this.Btn_DownloadStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_DownloadStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_DownloadStart.FlatAppearance.BorderSize = 0;
            this.Btn_DownloadStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_DownloadStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_DownloadStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DownloadStart.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_DownloadStart.Location = new System.Drawing.Point(1, 515);
            this.Btn_DownloadStart.Name = "Btn_DownloadStart";
            this.Btn_DownloadStart.Size = new System.Drawing.Size(148, 55);
            this.Btn_DownloadStart.TabIndex = 13;
            this.Btn_DownloadStart.Text = "다운로드 시작";
            this.Btn_DownloadStart.UseVisualStyleBackColor = false;
            // 
            // Panel_Download_OptionList
            // 
            this.Panel_Download_OptionList.Controls.Add(this.Btn_SearchResult);
            this.Panel_Download_OptionList.Controls.Add(this.Btn_Option);
            this.Panel_Download_OptionList.Controls.Add(this.Btn_Preview);
            this.Panel_Download_OptionList.Controls.Add(this.Panel_Search);
            this.Panel_Download_OptionList.Controls.Add(this.Btn_DownloadStart);
            this.Panel_Download_OptionList.Controls.Add(this.Btn_Hompage);
            this.Panel_Download_OptionList.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Download_OptionList.Location = new System.Drawing.Point(3, 49);
            this.Panel_Download_OptionList.Name = "Panel_Download_OptionList";
            this.Panel_Download_OptionList.Size = new System.Drawing.Size(150, 626);
            this.Panel_Download_OptionList.TabIndex = 4;
            this.Panel_Download_OptionList.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Btn_SearchResult
            // 
            this.Btn_SearchResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_SearchResult.FlatAppearance.BorderSize = 0;
            this.Btn_SearchResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_SearchResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_SearchResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SearchResult.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_SearchResult.Location = new System.Drawing.Point(1, 55);
            this.Btn_SearchResult.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_SearchResult.Name = "Btn_SearchResult";
            this.Btn_SearchResult.Size = new System.Drawing.Size(148, 55);
            this.Btn_SearchResult.TabIndex = 14;
            this.Btn_SearchResult.Tag = false;
            this.Btn_SearchResult.Text = "검색 결과";
            this.Btn_SearchResult.UseVisualStyleBackColor = false;
            this.Btn_SearchResult.Click += new System.EventHandler(this.Btn_SearchResult_Click);
            // 
            // Panel_Search
            // 
            this.Panel_Search.Controls.Add(this.button1);
            this.Panel_Search.Controls.Add(this.Btn_Search_Range);
            this.Panel_Search.Controls.Add(this.Btn_Search_Series);
            this.Panel_Search.Controls.Add(this.Btn_Search_Tags);
            this.Panel_Search.Controls.Add(this.Btn_Search_Character);
            this.Panel_Search.Controls.Add(this.Btn_Search_Language);
            this.Panel_Search.Controls.Add(this.Btn_Search_Title);
            this.Panel_Search.Location = new System.Drawing.Point(23, 164);
            this.Panel_Search.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(127, 387);
            this.Panel_Search.TabIndex = 21;
            this.Panel_Search.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(1, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 55);
            this.button1.TabIndex = 21;
            this.button1.Text = "범위 지정";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_Search_Range
            // 
            this.Btn_Search_Range.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Search_Range.FlatAppearance.BorderSize = 0;
            this.Btn_Search_Range.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Search_Range.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Search_Range.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search_Range.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Search_Range.Location = new System.Drawing.Point(1, 276);
            this.Btn_Search_Range.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search_Range.Name = "Btn_Search_Range";
            this.Btn_Search_Range.Size = new System.Drawing.Size(125, 55);
            this.Btn_Search_Range.TabIndex = 20;
            this.Btn_Search_Range.Text = "범위 지정";
            this.Btn_Search_Range.UseVisualStyleBackColor = false;
            // 
            // Btn_Search_Series
            // 
            this.Btn_Search_Series.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Search_Series.FlatAppearance.BorderSize = 0;
            this.Btn_Search_Series.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Search_Series.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Search_Series.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search_Series.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Search_Series.Location = new System.Drawing.Point(1, 111);
            this.Btn_Search_Series.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search_Series.Name = "Btn_Search_Series";
            this.Btn_Search_Series.Size = new System.Drawing.Size(125, 55);
            this.Btn_Search_Series.TabIndex = 17;
            this.Btn_Search_Series.Text = "종류";
            this.Btn_Search_Series.UseVisualStyleBackColor = false;
            // 
            // Btn_Search_Tags
            // 
            this.Btn_Search_Tags.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Search_Tags.FlatAppearance.BorderSize = 0;
            this.Btn_Search_Tags.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Search_Tags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Search_Tags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search_Tags.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Search_Tags.Location = new System.Drawing.Point(1, 56);
            this.Btn_Search_Tags.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search_Tags.Name = "Btn_Search_Tags";
            this.Btn_Search_Tags.Size = new System.Drawing.Size(125, 55);
            this.Btn_Search_Tags.TabIndex = 16;
            this.Btn_Search_Tags.Text = "태그";
            this.Btn_Search_Tags.UseVisualStyleBackColor = false;
            // 
            // Btn_Search_Character
            // 
            this.Btn_Search_Character.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Search_Character.FlatAppearance.BorderSize = 0;
            this.Btn_Search_Character.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Search_Character.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Search_Character.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search_Character.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Search_Character.Location = new System.Drawing.Point(1, 221);
            this.Btn_Search_Character.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search_Character.Name = "Btn_Search_Character";
            this.Btn_Search_Character.Size = new System.Drawing.Size(125, 55);
            this.Btn_Search_Character.TabIndex = 19;
            this.Btn_Search_Character.Text = "캐릭터명";
            this.Btn_Search_Character.UseVisualStyleBackColor = false;
            // 
            // Btn_Search_Language
            // 
            this.Btn_Search_Language.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Search_Language.FlatAppearance.BorderSize = 0;
            this.Btn_Search_Language.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Search_Language.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Search_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search_Language.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Search_Language.Location = new System.Drawing.Point(1, 166);
            this.Btn_Search_Language.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search_Language.Name = "Btn_Search_Language";
            this.Btn_Search_Language.Size = new System.Drawing.Size(125, 55);
            this.Btn_Search_Language.TabIndex = 18;
            this.Btn_Search_Language.Text = "언어";
            this.Btn_Search_Language.UseVisualStyleBackColor = false;
            // 
            // Btn_Search_Title
            // 
            this.Btn_Search_Title.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Search_Title.FlatAppearance.BorderSize = 0;
            this.Btn_Search_Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Search_Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Search_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search_Title.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Search_Title.Location = new System.Drawing.Point(1, 1);
            this.Btn_Search_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search_Title.Name = "Btn_Search_Title";
            this.Btn_Search_Title.Size = new System.Drawing.Size(125, 55);
            this.Btn_Search_Title.TabIndex = 15;
            this.Btn_Search_Title.Text = "제목";
            this.Btn_Search_Title.UseVisualStyleBackColor = false;
            // 
            // Panel_DownloadBar
            // 
            this.Panel_DownloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DownloadBar.Location = new System.Drawing.Point(33, 15);
            this.Panel_DownloadBar.Name = "Panel_DownloadBar";
            this.Panel_DownloadBar.Size = new System.Drawing.Size(781, 20);
            this.Panel_DownloadBar.TabIndex = 0;
            this.Panel_DownloadBar.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Download_Stat
            // 
            this.Panel_Download_Stat.Controls.Add(this.Panel_DownloadBar);
            this.Panel_Download_Stat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Download_Stat.Location = new System.Drawing.Point(153, 626);
            this.Panel_Download_Stat.Name = "Panel_Download_Stat";
            this.Panel_Download_Stat.Size = new System.Drawing.Size(840, 49);
            this.Panel_Download_Stat.TabIndex = 5;
            this.Panel_Download_Stat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Downloaded
            // 
            this.Panel_Downloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Downloaded.Location = new System.Drawing.Point(153, 49);
            this.Panel_Downloaded.Name = "Panel_Downloaded";
            this.Panel_Downloaded.Size = new System.Drawing.Size(840, 577);
            this.Panel_Downloaded.TabIndex = 6;
            // 
            // DownloadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.Panel_Downloaded);
            this.Controls.Add(this.Panel_Download_Stat);
            this.Controls.Add(this.Panel_Download_OptionList);
            this.Controls.Add(this.Panel_Top_Option);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DownloadPage";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(996, 678);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Resize += new System.EventHandler(this.Form_ResizeEnd);
            this.Panel_Top_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).EndInit();
            this.Panel_Download_OptionList.ResumeLayout(false);
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Download_Stat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog FolderBrowerDialog;
        private System.Windows.Forms.PictureBox Btn_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Panel_Top_Option;
        private System.Windows.Forms.Button Btn_Preview;
        private System.Windows.Forms.Button Btn_Option;
        private System.Windows.Forms.Button Btn_Hompage;
        private System.Windows.Forms.Button Btn_DownloadStart;
        private System.Windows.Forms.Panel Panel_Download_OptionList;
        private System.Windows.Forms.Panel Panel_DownloadBar;
        private System.Windows.Forms.Panel Panel_Download_Stat;
        private System.Windows.Forms.Panel Panel_Downloaded;
        private System.Windows.Forms.Button Btn_SearchResult;
        private System.Windows.Forms.Panel Panel_Search;
        private System.Windows.Forms.Button Btn_Search_Range;
        private System.Windows.Forms.Button Btn_Search_Series;
        private System.Windows.Forms.Button Btn_Search_Tags;
        private System.Windows.Forms.Button Btn_Search_Character;
        private System.Windows.Forms.Button Btn_Search_Language;
        private System.Windows.Forms.Button Btn_Search_Title;
        private System.Windows.Forms.Button button1;
    }
}
