namespace HioViw
{
    partial class OptionPage
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
            this.Panel_Setting = new System.Windows.Forms.Panel();
            this.Panel_Update = new HioViw.Option.Option_Update();
            this.Panel_Option = new System.Windows.Forms.Panel();
            this.Btn_Preview = new System.Windows.Forms.Button();
            this.Panel_Top_Option = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Viewer = new System.Windows.Forms.PictureBox();
            this.Btn_Download = new System.Windows.Forms.PictureBox();
            this.Btn_Menu = new System.Windows.Forms.PictureBox();
            this.Panel_Setting.SuspendLayout();
            this.Panel_Option.SuspendLayout();
            this.Panel_Top_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Viewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Setting
            // 
            this.Panel_Setting.Controls.Add(this.Panel_Update);
            this.Panel_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Setting.Location = new System.Drawing.Point(153, 49);
            this.Panel_Setting.Name = "Panel_Setting";
            this.Panel_Setting.Size = new System.Drawing.Size(650, 443);
            this.Panel_Setting.TabIndex = 7;
            this.Panel_Setting.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Setting.Resize += new System.EventHandler(this.Panel_Setting_Resize);
            // 
            // Panel_Update
            // 
            this.Panel_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Panel_Update.Location = new System.Drawing.Point(0, 0);
            this.Panel_Update.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Update.Name = "Panel_Update";
            this.Panel_Update.Size = new System.Drawing.Size(627, 415);
            this.Panel_Update.TabIndex = 0;
            // 
            // Panel_Option
            // 
            this.Panel_Option.Controls.Add(this.Btn_Preview);
            this.Panel_Option.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Option.Location = new System.Drawing.Point(3, 49);
            this.Panel_Option.Name = "Panel_Option";
            this.Panel_Option.Size = new System.Drawing.Size(150, 443);
            this.Panel_Option.TabIndex = 6;
            this.Panel_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Btn_Preview
            // 
            this.Btn_Preview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Preview.FlatAppearance.BorderSize = 0;
            this.Btn_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Preview.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Preview.Location = new System.Drawing.Point(1, 1);
            this.Btn_Preview.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Preview.Name = "Btn_Preview";
            this.Btn_Preview.Size = new System.Drawing.Size(148, 55);
            this.Btn_Preview.TabIndex = 10;
            this.Btn_Preview.Tag = false;
            this.Btn_Preview.Text = "업데이트";
            this.Btn_Preview.UseVisualStyleBackColor = false;
            // 
            // Panel_Top_Option
            // 
            this.Panel_Top_Option.Controls.Add(this.pictureBox1);
            this.Panel_Top_Option.Controls.Add(this.Btn_Viewer);
            this.Panel_Top_Option.Controls.Add(this.Btn_Download);
            this.Panel_Top_Option.Controls.Add(this.Btn_Menu);
            this.Panel_Top_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_Option.Location = new System.Drawing.Point(3, 3);
            this.Panel_Top_Option.Name = "Panel_Top_Option";
            this.Panel_Top_Option.Size = new System.Drawing.Size(800, 46);
            this.Panel_Top_Option.TabIndex = 5;
            this.Panel_Top_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HioViw.Properties.Resources.settings_cogwheel_button;
            this.pictureBox1.Location = new System.Drawing.Point(170, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Viewer
            // 
            this.Btn_Viewer.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Viewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Viewer.Image = global::HioViw.Properties.Resources.image;
            this.Btn_Viewer.Location = new System.Drawing.Point(120, 8);
            this.Btn_Viewer.Name = "Btn_Viewer";
            this.Btn_Viewer.Size = new System.Drawing.Size(40, 30);
            this.Btn_Viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Viewer.TabIndex = 2;
            this.Btn_Viewer.TabStop = false;
            this.Btn_Viewer.Click += new System.EventHandler(this.Btn_Viewer_Click);
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
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // OptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Panel_Setting);
            this.Controls.Add(this.Panel_Option);
            this.Controls.Add(this.Panel_Top_Option);
            this.Name = "OptionPage";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(806, 495);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Setting.ResumeLayout(false);
            this.Panel_Option.ResumeLayout(false);
            this.Panel_Top_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Viewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Setting;
        private System.Windows.Forms.Panel Panel_Option;
        private System.Windows.Forms.Panel Panel_Top_Option;
        private System.Windows.Forms.PictureBox Btn_Download;
        private System.Windows.Forms.PictureBox Btn_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Btn_Viewer;
        private System.Windows.Forms.Button Btn_Preview;
        private Option.Option_Update Panel_Update;
    }
}
