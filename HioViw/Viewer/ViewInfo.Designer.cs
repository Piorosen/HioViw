namespace HioViw
{
    partial class ViewInfo
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
            this.Pic_Image = new System.Windows.Forms.PictureBox();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Label_Lang = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Series = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Image
            // 
            this.Pic_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Image.Location = new System.Drawing.Point(5, 5);
            this.Pic_Image.Name = "Pic_Image";
            this.Pic_Image.Size = new System.Drawing.Size(100, 100);
            this.Pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Image.TabIndex = 0;
            this.Pic_Image.TabStop = false;
            this.Pic_Image.DoubleClick += new System.EventHandler(this.EventDoubleClick);
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Type.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Type.Location = new System.Drawing.Point(112, 20);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(46, 12);
            this.Label_Type.TabIndex = 1;
            this.Label_Type.Text = "Type : ";
            this.Label_Type.DoubleClick += new System.EventHandler(this.EventDoubleClick);
            // 
            // Label_Lang
            // 
            this.Label_Lang.AutoSize = true;
            this.Label_Lang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Lang.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Lang.Location = new System.Drawing.Point(112, 50);
            this.Label_Lang.Name = "Label_Lang";
            this.Label_Lang.Size = new System.Drawing.Size(45, 12);
            this.Label_Lang.TabIndex = 2;
            this.Label_Lang.Text = "Lang : ";
            this.Label_Lang.DoubleClick += new System.EventHandler(this.EventDoubleClick);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Title.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Title.Location = new System.Drawing.Point(9, 123);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(41, 12);
            this.Label_Title.TabIndex = 3;
            this.Label_Title.Text = "Title : ";
            this.Label_Title.DoubleClick += new System.EventHandler(this.EventDoubleClick);
            // 
            // Label_Series
            // 
            this.Label_Series.AutoSize = true;
            this.Label_Series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Series.ForeColor = System.Drawing.Color.LightGray;
            this.Label_Series.Location = new System.Drawing.Point(112, 81);
            this.Label_Series.Name = "Label_Series";
            this.Label_Series.Size = new System.Drawing.Size(53, 12);
            this.Label_Series.TabIndex = 4;
            this.Label_Series.Text = "Series : ";
            this.Label_Series.DoubleClick += new System.EventHandler(this.EventDoubleClick);
            // 
            // ViewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Label_Series);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Label_Lang);
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Pic_Image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ViewInfo";
            this.Size = new System.Drawing.Size(250, 150);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.DoubleClick += new System.EventHandler(this.EventDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox Pic_Image;
        public System.Windows.Forms.Label Label_Type;
        public System.Windows.Forms.Label Label_Lang;
        public System.Windows.Forms.Label Label_Title;
        public System.Windows.Forms.Label Label_Series;
    }
}
