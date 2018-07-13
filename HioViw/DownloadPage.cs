using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HioViw
{
    public partial class DownloadPage : UserControl
    {
        public DownloadPage()
        {
            InitializeComponent();
            
            for (int i = 112; i <= Panel_Downloaded.Size.Height; i += 106)
            {
                Preview pre = new Preview
                {
                    Anchor = ((AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right)),
                    Location = new Point(6, i - 106),
                    Size = new Size(Panel_Downloaded.Size.Width - 12, 100)
                };
                Panel_Downloaded.Controls.Add(pre);
                Previews.Add(pre);
            }

            Menu_Button.Add(Btn_Preview);
            Menu_Button.Add(Btn_SearchResult);
            Menu_Button.Add(Btn_Option);

            StreamReader sr = new StreamReader("DB\\Tags.Info", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Tags.Add(sr.ReadLine());
            }
            sr.Close();

        }

        List<string> Tags = new List<string>();
        List<Preview> Previews = new List<Preview>();


        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control)
            {
                var panel = (sender as Control);
                var graphic = panel.CreateGraphics();
                graphic.Clear(this.BackColor);
                Rectangle r = new Rectangle(0, 0, panel.Size.Width, panel.Size.Height);
                graphic.DrawRectangle(new Pen(Color.FromArgb(120, 120, 120), 2), r);
            }
        }
        

        private void ChkListBox_Click(object sender, EventArgs e)
        {
            var list = (sender as CheckedListBox);
            int i = list.SelectedIndex;
            for (int w = 0; w < list.Items.Count; w++)
            {
                list.SetItemCheckState(w, CheckState.Unchecked);
            }
            (sender as CheckedListBox).SelectedIndex = i;
        }


        private void Preview_Add(string previewImagePath, string ID, string Title, string Uploader, string Series, string Type,
                string Language, List<string> tagList, List<string> characterList, string UploadDate)
        {


            for (int i = Previews.Count - 2; i >= 0; i--)
            {
                Previews[i].Invoke(new MethodInvoker(delegate () {

                    Previews[i + 1].Pic_Image.Image = Previews[i].Pic_Image.Image;

                    Previews[i + 1].Label_ID.Text = Previews[i].Label_ID.Text;
                    Previews[i + 1].Label_Title.Text = Previews[i].Label_Title.Text;
                    Previews[i + 1].Label_Group.Text = Previews[i].Label_Group.Text;
                    Previews[i + 1].Label_Series.Text = Previews[i].Label_Series.Text;
                    Previews[i + 1].Label_Type.Text = Previews[i].Label_Type.Text;
                    Previews[i + 1].Label_Language.Text = Previews[i].Label_Language.Text;
                    Previews[i + 1].Label_Tags.Text = Previews[i].Label_Tags.Text;
                    Previews[i + 1].Label_Character.Text = Previews[i].Label_Character.Text;
                    Previews[i + 1].Label_Date.Text = Previews[i].Label_Date.Text;

                }));
            }

            Preview preview = Previews[0];



            preview.Invoke(new MethodInvoker(delegate ()
            {
                preview.Clear();

                preview.Pic_Image.Image = Bitmap.FromFile(previewImagePath);
                preview.Label_ID.Text += ID.Split('.')[0];
                preview.Label_Title.Text += Title;
                preview.Label_Group.Text += Uploader;
                preview.Label_Series.Text += Series;
                preview.Label_Type.Text += Type;
                preview.Label_Language.Text += Language;
                for (int i = 0; i < tagList.Count - 1; i++)
                {
                    preview.Label_Tags.Text += tagList[i] + ", ";
                }
                preview.Label_Tags.Text += tagList[tagList.Count - 1];

                for (int i = 0; i < characterList.Count - 1; i++)
                {
                    preview.Label_Character.Text += characterList[i] + ", ";
                }
                preview.Label_Character.Text += characterList[characterList.Count - 1];

                preview.Label_Date.Text += UploadDate;
            }));

            Previews[0] = preview;

        }

        private void Form_ResizeEnd(object sender, EventArgs e)
        {
            List<Preview> mPreview = new List<Preview>();

            int prevCount = Previews.Count;
            int nowCount = 0;


            for (int i = 112; i <= Panel_Downloaded.Size.Height; i += 106)
            {
                nowCount++;
            }

            if (prevCount > nowCount)
            {
                for (int i = nowCount; i < prevCount; i++)
                {
                    Previews[nowCount].Dispose();
                    Previews.RemoveAt(nowCount);
                }
            }
            else if (prevCount < nowCount)
            {
                for (int i = prevCount; i < nowCount; i++)
                {
                    Preview pre = new Preview
                    {
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                        Location = new Point(6, (112 + 106 * (i)) - 106),
                        Size = new Size(Panel_Downloaded.Size.Width - 12, 100),
                        // Name = "Preview_" + i
                    };
                    Previews.Add(pre);
                    Panel_Downloaded.Controls.Add(pre);
                }
            }
            else
            {
                return;
            }
        }


        List<Control> Menu_Button = new List<Control>();
        private void Btn_Color(Control sender)
        {
            bool sen = !(bool)sender.Tag;

            foreach (var c in Menu_Button)
            {
                c.Tag = false;
                c.BackColor = Color.FromArgb(40, 40, 40);
            }

            if (sen)
            {
                sender.Tag = true;
            }
            
            if (sender.Name != "Btn_Option")
            {
                Panel_Search.Visible = false;
                Btn_Option.Tag = false;
            }
                sender.BackColor = Color.FromArgb(80, 80, 80);

        }

        private void Btn_Option_Click(object sender, EventArgs e)
        {
            Btn_Color(sender as Control);

            Panel_Search.Visible = (bool)(sender as Control).Tag;
        }
        private void Btn_Downloa_Click(object sender, EventArgs e)
        {
            Btn_Color(sender as Control);
            Panel_Downloaded.BringToFront();
        }

        private void Btn_SearchResult_Click(object sender, EventArgs e)
        {
            Btn_Color(sender as Control);
        }

        bool ch = false;
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (ch)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Panel_Download_OptionList.Size = new Size(150, Panel_Download_OptionList.Size.Height);
                }
                ch = !ch;
            }
            else
            {
                Panel_Download_OptionList.Size = new Size(0, Panel_Download_OptionList.Size.Height);
                ch = !ch;
            }
        }

        private void Panel_Download_Option_Resize(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Title_Click(object sender, EventArgs e)
        {
            Panel_Search_Title.Visible = !Panel_Search_Title.Visible;
        }

        private void Btn_Search_Tags_Click(object sender, EventArgs e)
        {
            Panel_Search_Tags.Visible = !Panel_Search_Tags.Visible;
        }

        private void Btn_Search_Series_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Language_Click(object sender, EventArgs e)
        {
            Panel_Search_Language.Visible = !Panel_Search_Language.Visible;
        }
    }
}
