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
            this.Panel_Download_Option = new System.Windows.Forms.Panel();
            this.Panel_Download_Stat = new System.Windows.Forms.Panel();
            this.Panel_ = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Top_Option.SuspendLayout();
            this.Panel_Download_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Top_Option
            // 
            this.Panel_Top_Option.Controls.Add(this.pictureBox1);
            this.Panel_Top_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_Option.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top_Option.Name = "Panel_Top_Option";
            this.Panel_Top_Option.Size = new System.Drawing.Size(870, 46);
            this.Panel_Top_Option.TabIndex = 1;
            this.Panel_Top_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Download_Option
            // 
            this.Panel_Download_Option.Controls.Add(this.panel1);
            this.Panel_Download_Option.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Download_Option.Location = new System.Drawing.Point(0, 46);
            this.Panel_Download_Option.Name = "Panel_Download_Option";
            this.Panel_Download_Option.Size = new System.Drawing.Size(148, 588);
            this.Panel_Download_Option.TabIndex = 4;
            this.Panel_Download_Option.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_Download_Stat
            // 
            this.Panel_Download_Stat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Download_Stat.Location = new System.Drawing.Point(148, 585);
            this.Panel_Download_Stat.Name = "Panel_Download_Stat";
            this.Panel_Download_Stat.Size = new System.Drawing.Size(722, 49);
            this.Panel_Download_Stat.TabIndex = 5;
            this.Panel_Download_Stat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Panel_
            // 
            this.Panel_.AutoScroll = true;
            this.Panel_.BackColor = System.Drawing.Color.Transparent;
            this.Panel_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_.Location = new System.Drawing.Point(148, 46);
            this.Panel_.Name = "Panel_";
            this.Panel_.Size = new System.Drawing.Size(722, 539);
            this.Panel_.TabIndex = 6;
            this.Panel_.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 51);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HioViw.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(870, 634);
            this.Controls.Add(this.Panel_);
            this.Controls.Add(this.Panel_Download_Stat);
            this.Controls.Add(this.Panel_Download_Option);
            this.Controls.Add(this.Panel_Top_Option);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "HioViw";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Top_Option.ResumeLayout(false);
            this.Panel_Download_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top_Option;
        private System.Windows.Forms.Panel Panel_Download_Option;
        private System.Windows.Forms.Panel Panel_Download_Stat;
        private System.Windows.Forms.Panel Panel_;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

