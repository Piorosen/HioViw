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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Download_OptionList = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Option = new System.Windows.Forms.Button();
            this.Panel_Download_Select = new System.Windows.Forms.Panel();
            this.Btn_Preview = new System.Windows.Forms.Button();
            this.Panel_Download_Stat = new System.Windows.Forms.Panel();
            this.Panel_DownloadBar = new System.Windows.Forms.Panel();
            this.FolderBrowerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Panel_Download_Option = new HioViw.Panel_Download_Option();
            this.Panel_Downloaded = new HioViw.Panel_Downloaded();
            this.Panel_Top_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Download_OptionList.SuspendLayout();
            this.Panel_Download_Stat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top_Option
            // 
            this.Panel_Top_Option.Controls.Add(this.pictureBox1);
            this.Panel_Top_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_Option.Location = new System.Drawing.Point(3, 3);
            this.Panel_Top_Option.Name = "Panel_Top_Option";
            this.Panel_Top_Option.Size = new System.Drawing.Size(990, 46);
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
            // Panel_Download_OptionList
            // 
            this.Panel_Download_OptionList.Controls.Add(this.button2);
            this.Panel_Download_OptionList.Controls.Add(this.button1);
            this.Panel_Download_OptionList.Controls.Add(this.Btn_Option);
            this.Panel_Download_OptionList.Controls.Add(this.Panel_Download_Select);
            this.Panel_Download_OptionList.Controls.Add(this.Btn_Preview);
            this.Panel_Download_OptionList.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Download_OptionList.Location = new System.Drawing.Point(3, 49);
            this.Panel_Download_OptionList.Name = "Panel_Download_OptionList";
            this.Panel_Download_OptionList.Size = new System.Drawing.Size(150, 484);
            this.Panel_Download_OptionList.TabIndex = 4;
            this.Panel_Download_OptionList.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
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
            this.Panel_Download_Stat.Location = new System.Drawing.Point(153, 484);
            this.Panel_Download_Stat.Name = "Panel_Download_Stat";
            this.Panel_Download_Stat.Size = new System.Drawing.Size(840, 49);
            this.Panel_Download_Stat.TabIndex = 5;
            this.Panel_Download_Stat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
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
            // Panel_Download_Option
            // 
            this.Panel_Download_Option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Download_Option.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Download_Option.Location = new System.Drawing.Point(153, 49);
            this.Panel_Download_Option.Name = "Panel_Download_Option";
            this.Panel_Download_Option.Size = new System.Drawing.Size(840, 435);
            this.Panel_Download_Option.TabIndex = 0;
            this.Panel_Download_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Downloaded
            // 
            this.Panel_Downloaded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Downloaded.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Downloaded.Location = new System.Drawing.Point(153, 49);
            this.Panel_Downloaded.Name = "Panel_Downloaded";
            this.Panel_Downloaded.Size = new System.Drawing.Size(840, 435);
            this.Panel_Downloaded.TabIndex = 6;
            this.Panel_Downloaded.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // HioView_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(996, 536);
            this.Controls.Add(this.Panel_Download_Option);
            this.Controls.Add(this.Panel_Downloaded);
            this.Controls.Add(this.Panel_Download_Stat);
            this.Controls.Add(this.Panel_Download_OptionList);
            this.Controls.Add(this.Panel_Top_Option);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HioView_Form";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "HioView";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Top_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Download_OptionList.ResumeLayout(false);
            this.Panel_Download_Stat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top_Option;
        private System.Windows.Forms.Panel Panel_Download_OptionList;
        private System.Windows.Forms.Panel Panel_Download_Stat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowerDialog;
        private System.Windows.Forms.Panel Panel_DownloadBar;
        private System.Windows.Forms.Panel Panel_Download_Select;
        private System.Windows.Forms.Button Btn_Preview;
        private System.Windows.Forms.Button Btn_Option;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Panel_Downloaded Panel_Downloaded;
        private Panel_Download_Option Panel_Download_Option;
    }
}

