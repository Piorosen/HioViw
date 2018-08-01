namespace HioViw
{
    partial class DownloadLog
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
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Pic_Image = new System.Windows.Forms.PictureBox();
            this.Label_Language = new System.Windows.Forms.Label();
            this.Panel_Download = new System.Windows.Forms.Panel();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Label_Series = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Title.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Title.Location = new System.Drawing.Point(95, 27);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(41, 12);
            this.Label_Title.TabIndex = 12;
            this.Label_Title.Text = "Title : ";
            this.Label_Title.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.Label_Title.MouseLeave += new System.EventHandler(this.Detail_Leave);
            this.Label_Title.MouseHover += new System.EventHandler(this.Detail_Hover);
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ID.ForeColor = System.Drawing.Color.LightGray;
            this.Label_ID.Location = new System.Drawing.Point(96, 9);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(28, 12);
            this.Label_ID.TabIndex = 11;
            this.Label_ID.Text = "ID : ";
            this.Label_ID.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.Label_ID.MouseLeave += new System.EventHandler(this.Detail_Leave);
            this.Label_ID.MouseHover += new System.EventHandler(this.Detail_Hover);
            // 
            // Pic_Image
            // 
            this.Pic_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Image.Location = new System.Drawing.Point(3, 3);
            this.Pic_Image.Name = "Pic_Image";
            this.Pic_Image.Size = new System.Drawing.Size(88, 94);
            this.Pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Image.TabIndex = 10;
            this.Pic_Image.TabStop = false;
            this.Pic_Image.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.Pic_Image.MouseLeave += new System.EventHandler(this.Detail_Leave);
            this.Pic_Image.MouseHover += new System.EventHandler(this.Detail_Hover);
            // 
            // Label_Language
            // 
            this.Label_Language.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Language.AutoSize = true;
            this.Label_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Language.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Language.Location = new System.Drawing.Point(340, 9);
            this.Label_Language.Name = "Label_Language";
            this.Label_Language.Size = new System.Drawing.Size(73, 12);
            this.Label_Language.TabIndex = 15;
            this.Label_Language.Text = "Language : ";
            this.Label_Language.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.Label_Language.MouseLeave += new System.EventHandler(this.Detail_Leave);
            this.Label_Language.MouseHover += new System.EventHandler(this.Detail_Hover);
            // 
            // Panel_Download
            // 
            this.Panel_Download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Download.Location = new System.Drawing.Point(103, 69);
            this.Panel_Download.Name = "Panel_Download";
            this.Panel_Download.Size = new System.Drawing.Size(480, 17);
            this.Panel_Download.TabIndex = 16;
            this.Panel_Download.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel_Download.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            // 
            // Label_Type
            // 
            this.Label_Type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Type.AutoSize = true;
            this.Label_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Type.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Type.Location = new System.Drawing.Point(340, 44);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(46, 12);
            this.Label_Type.TabIndex = 16;
            this.Label_Type.Text = "Type : ";
            this.Label_Type.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.Label_Type.MouseLeave += new System.EventHandler(this.Detail_Leave);
            this.Label_Type.MouseHover += new System.EventHandler(this.Detail_Hover);
            // 
            // Label_Series
            // 
            this.Label_Series.AutoSize = true;
            this.Label_Series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Series.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Series.Location = new System.Drawing.Point(95, 44);
            this.Label_Series.Name = "Label_Series";
            this.Label_Series.Size = new System.Drawing.Size(53, 12);
            this.Label_Series.TabIndex = 15;
            this.Label_Series.Text = "Series : ";
            this.Label_Series.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.Label_Series.MouseLeave += new System.EventHandler(this.Detail_Leave);
            this.Label_Series.MouseHover += new System.EventHandler(this.Detail_Hover);
            // 
            // DownloadLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Panel_Download);
            this.Controls.Add(this.Label_Series);
            this.Controls.Add(this.Label_Language);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.Pic_Image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DownloadLog";
            this.Size = new System.Drawing.Size(598, 100);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Label_Title;
        public System.Windows.Forms.Label Label_ID;
        public System.Windows.Forms.PictureBox Pic_Image;
        public System.Windows.Forms.Label Label_Language;
        private System.Windows.Forms.Panel Panel_Download;
        public System.Windows.Forms.Label Label_Type;
        public System.Windows.Forms.Label Label_Series;
    }
}
