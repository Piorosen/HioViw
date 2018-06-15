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
            this.LIST_Download = new System.Windows.Forms.ListView();
            this.Colum_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colum_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colum_Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEXT_DownloadLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LIST_Download
            // 
            this.LIST_Download.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Colum_ID,
            this.Colum_Title,
            this.Colum_Tag});
            this.LIST_Download.Location = new System.Drawing.Point(368, 81);
            this.LIST_Download.Name = "LIST_Download";
            this.LIST_Download.Size = new System.Drawing.Size(629, 357);
            this.LIST_Download.TabIndex = 0;
            this.LIST_Download.UseCompatibleStateImageBehavior = false;
            this.LIST_Download.View = System.Windows.Forms.View.Details;
            // 
            // Colum_ID
            // 
            this.Colum_ID.Text = "ID";
            this.Colum_ID.Width = 93;
            // 
            // Colum_Title
            // 
            this.Colum_Title.Text = "Title";
            this.Colum_Title.Width = 96;
            // 
            // Colum_Tag
            // 
            this.Colum_Tag.Text = "Tag";
            // 
            // TEXT_DownloadLink
            // 
            this.TEXT_DownloadLink.Location = new System.Drawing.Point(412, 25);
            this.TEXT_DownloadLink.Name = "TEXT_DownloadLink";
            this.TEXT_DownloadLink.Size = new System.Drawing.Size(504, 21);
            this.TEXT_DownloadLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL : ";
            // 
            // BTN_Download
            // 
            this.BTN_Download.Location = new System.Drawing.Point(922, 25);
            this.BTN_Download.Name = "BTN_Download";
            this.BTN_Download.Size = new System.Drawing.Size(75, 23);
            this.BTN_Download.TabIndex = 3;
            this.BTN_Download.Text = "Download";
            this.BTN_Download.UseVisualStyleBackColor = true;
            this.BTN_Download.Click += new System.EventHandler(this.BTN_Download_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.BTN_Download);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEXT_DownloadLink);
            this.Controls.Add(this.LIST_Download);
            this.Name = "Form1";
            this.Text = "HioViw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LIST_Download;
        private System.Windows.Forms.TextBox TEXT_DownloadLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Download;
        private System.Windows.Forms.ColumnHeader Colum_ID;
        private System.Windows.Forms.ColumnHeader Colum_Title;
        private System.Windows.Forms.ColumnHeader Colum_Tag;
    }
}

