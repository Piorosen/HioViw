namespace HioViw
{
    partial class ViewerPage
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
            this.components = new System.ComponentModel.Container();
            this.Panel_Top_Option = new System.Windows.Forms.Panel();
            this.Btn_Setting = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Download = new System.Windows.Forms.PictureBox();
            this.Btn_Menu = new System.Windows.Forms.PictureBox();
            this.Panel_Viewer = new System.Windows.Forms.Panel();
            this.Pic_Viewer = new System.Windows.Forms.PictureBox();
            this.Panel_Explorer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Select_Page = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Text_Select_Page = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Page = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Page = new System.Windows.Forms.TextBox();
            this.Panel_Top_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).BeginInit();
            this.Panel_Viewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Viewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top_Option
            // 
            this.Panel_Top_Option.Controls.Add(this.Btn_Setting);
            this.Panel_Top_Option.Controls.Add(this.pictureBox2);
            this.Panel_Top_Option.Controls.Add(this.Btn_Download);
            this.Panel_Top_Option.Controls.Add(this.Btn_Menu);
            this.Panel_Top_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_Option.Location = new System.Drawing.Point(3, 3);
            this.Panel_Top_Option.Name = "Panel_Top_Option";
            this.Panel_Top_Option.Size = new System.Drawing.Size(1014, 46);
            this.Panel_Top_Option.TabIndex = 2;
            this.Panel_Top_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Btn_Setting
            // 
            this.Btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Setting.Image = global::HioViw.Properties.Resources.settings_cogwheel_button;
            this.Btn_Setting.Location = new System.Drawing.Point(170, 8);
            this.Btn_Setting.Name = "Btn_Setting";
            this.Btn_Setting.Size = new System.Drawing.Size(40, 30);
            this.Btn_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Setting.TabIndex = 3;
            this.Btn_Setting.TabStop = false;
            this.Btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HioViw.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(120, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_Download
            // 
            this.Btn_Download.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Download.Image = global::HioViw.Properties.Resources.download_button;
            this.Btn_Download.Location = new System.Drawing.Point(70, 8);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(40, 30);
            this.Btn_Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Download.TabIndex = 1;
            this.Btn_Download.TabStop = false;
            this.Btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
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
            // 
            // Panel_Viewer
            // 
            this.Panel_Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Viewer.Controls.Add(this.Pic_Viewer);
            this.Panel_Viewer.Location = new System.Drawing.Point(252, 49);
            this.Panel_Viewer.Name = "Panel_Viewer";
            this.Panel_Viewer.Size = new System.Drawing.Size(765, 516);
            this.Panel_Viewer.TabIndex = 4;
            this.Panel_Viewer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Pic_Viewer
            // 
            this.Pic_Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Viewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Viewer.Location = new System.Drawing.Point(6, 6);
            this.Pic_Viewer.Name = "Pic_Viewer";
            this.Pic_Viewer.Size = new System.Drawing.Size(754, 504);
            this.Pic_Viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Viewer.TabIndex = 0;
            this.Pic_Viewer.TabStop = false;
            this.Pic_Viewer.Click += new System.EventHandler(this.Pic_Viewer_Click);
            // 
            // Panel_Explorer
            // 
            this.Panel_Explorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Explorer.Location = new System.Drawing.Point(3, 49);
            this.Panel_Explorer.Name = "Panel_Explorer";
            this.Panel_Explorer.Size = new System.Drawing.Size(250, 516);
            this.Panel_Explorer.TabIndex = 1;
            this.Panel_Explorer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Explorer.Resize += new System.EventHandler(this.Panel_Explorer_Resize);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.Label_Select_Page);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Text_Select_Page);
            this.panel1.Location = new System.Drawing.Point(3, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Label_Select_Page
            // 
            this.Label_Select_Page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Select_Page.AutoSize = true;
            this.Label_Select_Page.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Select_Page.Location = new System.Drawing.Point(202, 21);
            this.Label_Select_Page.Name = "Label_Select_Page";
            this.Label_Select_Page.Size = new System.Drawing.Size(24, 12);
            this.Label_Select_Page.TabIndex = 5;
            this.Label_Select_Page.Text = "~ 1";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(25, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "1 ~";
            // 
            // Text_Select_Page
            // 
            this.Text_Select_Page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Select_Page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Text_Select_Page.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Select_Page.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_Select_Page.ForeColor = System.Drawing.Color.LightGray;
            this.Text_Select_Page.Location = new System.Drawing.Point(55, 18);
            this.Text_Select_Page.Name = "Text_Select_Page";
            this.Text_Select_Page.Size = new System.Drawing.Size(141, 19);
            this.Text_Select_Page.TabIndex = 3;
            this.Text_Select_Page.TabStop = false;
            this.Text_Select_Page.Text = "1";
            this.Text_Select_Page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Select_Page.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Select_Page_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Label_Page);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Text_Page);
            this.panel2.Location = new System.Drawing.Point(253, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 54);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Label_Page
            // 
            this.Label_Page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Page.AutoSize = true;
            this.Label_Page.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Page.Location = new System.Drawing.Point(459, 21);
            this.Label_Page.Name = "Label_Page";
            this.Label_Page.Size = new System.Drawing.Size(24, 12);
            this.Label_Page.TabIndex = 5;
            this.Label_Page.Text = "~ 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(282, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "1 ~";
            // 
            // Text_Page
            // 
            this.Text_Page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Text_Page.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Page.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_Page.ForeColor = System.Drawing.Color.LightGray;
            this.Text_Page.Location = new System.Drawing.Point(312, 18);
            this.Text_Page.Name = "Text_Page";
            this.Text_Page.Size = new System.Drawing.Size(141, 19);
            this.Text_Page.TabIndex = 3;
            this.Text_Page.TabStop = false;
            this.Text_Page.Text = "1";
            this.Text_Page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Page.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Page_KeyDown);
            // 
            // ViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Explorer);
            this.Controls.Add(this.Panel_Viewer);
            this.Controls.Add(this.Panel_Top_Option);
            this.Name = "ViewerPage";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1020, 622);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Top_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).EndInit();
            this.Panel_Viewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Viewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top_Option;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Btn_Download;
        private System.Windows.Forms.PictureBox Btn_Menu;
        private System.Windows.Forms.PictureBox Btn_Setting;
        private System.Windows.Forms.Panel Panel_Viewer;
        private System.Windows.Forms.Panel Panel_Explorer;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Label_Select_Page;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox Text_Select_Page;
        private System.Windows.Forms.PictureBox Pic_Viewer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Label_Page;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Text_Page;
    }
}
