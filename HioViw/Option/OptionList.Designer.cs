namespace HioViw
{
    partial class OptionList
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
            this.label1 = new System.Windows.Forms.Label();
            this.Text_DBPath = new System.Windows.Forms.TextBox();
            this.Text_DownPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_ThumbPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_ThumbExt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_DBExt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Group_DB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Info = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Group_DB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB Path : ";
            // 
            // Text_DBPath
            // 
            this.Text_DBPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_DBPath.Location = new System.Drawing.Point(100, 25);
            this.Text_DBPath.Name = "Text_DBPath";
            this.Text_DBPath.Size = new System.Drawing.Size(332, 21);
            this.Text_DBPath.TabIndex = 1;
            this.Text_DBPath.Text = "Hitomi_DB\\";
            // 
            // Text_DownPath
            // 
            this.Text_DownPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_DownPath.Location = new System.Drawing.Point(100, 105);
            this.Text_DownPath.Name = "Text_DownPath";
            this.Text_DownPath.Size = new System.Drawing.Size(332, 21);
            this.Text_DownPath.TabIndex = 3;
            this.Text_DownPath.Text = "Download\\";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Down Path : ";
            // 
            // Text_ThumbPath
            // 
            this.Text_ThumbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_ThumbPath.Location = new System.Drawing.Point(99, 27);
            this.Text_ThumbPath.Name = "Text_ThumbPath";
            this.Text_ThumbPath.Size = new System.Drawing.Size(332, 21);
            this.Text_ThumbPath.TabIndex = 5;
            this.Text_ThumbPath.Text = "Download\\Thumbnail\\";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(5, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thumb Path : ";
            // 
            // Text_ThumbExt
            // 
            this.Text_ThumbExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_ThumbExt.Location = new System.Drawing.Point(99, 67);
            this.Text_ThumbExt.Name = "Text_ThumbExt";
            this.Text_ThumbExt.Size = new System.Drawing.Size(332, 21);
            this.Text_ThumbExt.TabIndex = 7;
            this.Text_ThumbExt.Text = ".tumb";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thumb Ext : ";
            // 
            // Text_DBExt
            // 
            this.Text_DBExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_DBExt.Location = new System.Drawing.Point(99, 65);
            this.Text_DBExt.Name = "Text_DBExt";
            this.Text_DBExt.Size = new System.Drawing.Size(332, 21);
            this.Text_DBExt.TabIndex = 9;
            this.Text_DBExt.Text = ".db";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(34, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DB Ext : ";
            // 
            // Group_DB
            // 
            this.Group_DB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_DB.Controls.Add(this.Text_DBPath);
            this.Group_DB.Controls.Add(this.Text_DBExt);
            this.Group_DB.Controls.Add(this.label1);
            this.Group_DB.Controls.Add(this.label5);
            this.Group_DB.Controls.Add(this.label2);
            this.Group_DB.Controls.Add(this.Text_DownPath);
            this.Group_DB.ForeColor = System.Drawing.Color.LightGray;
            this.Group_DB.Location = new System.Drawing.Point(15, 16);
            this.Group_DB.Name = "Group_DB";
            this.Group_DB.Size = new System.Drawing.Size(442, 139);
            this.Group_DB.TabIndex = 10;
            this.Group_DB.TabStop = false;
            this.Group_DB.Text = "DB 설정";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Text_ThumbExt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Text_ThumbPath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(15, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 105);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "썸네일 설정";
            // 
            // Btn_Info
            // 
            this.Btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_Info.FlatAppearance.BorderSize = 0;
            this.Btn_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Btn_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Info.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Info.Location = new System.Drawing.Point(44, 297);
            this.Btn_Info.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Info.Name = "Btn_Info";
            this.Btn_Info.Size = new System.Drawing.Size(147, 55);
            this.Btn_Info.TabIndex = 12;
            this.Btn_Info.Tag = false;
            this.Btn_Info.Text = "저장";
            this.Btn_Info.UseVisualStyleBackColor = false;
            this.Btn_Info.Click += new System.EventHandler(this.Btn_Info_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(272, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 13;
            this.button1.Tag = false;
            this.button1.Text = "초기화";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Info);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Group_DB);
            this.Name = "OptionList";
            this.Size = new System.Drawing.Size(472, 374);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Group_DB.ResumeLayout(false);
            this.Group_DB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_DBPath;
        private System.Windows.Forms.TextBox Text_DownPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_ThumbPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_ThumbExt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Text_DBExt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Group_DB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Info;
        private System.Windows.Forms.Button button1;
    }
}
