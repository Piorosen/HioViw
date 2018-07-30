using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HioViw
{
    public partial class ViewerPage : UserControl
    {
        public event Change Change;

        private void OnChange(int page)
        {
            Change?.Invoke(page);
        }

        public ViewerPage()
        {
            InitializeComponent();
        }

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

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            OnChange(0);
        }

        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            OnChange(2);
        }

        public List<Gallerie> infos = new List<Gallerie>();
        List<ViewInfo> viewInfo = new List<ViewInfo>();

        private void Text_Select_Page_KeyDown(object sender, KeyEventArgs e)
        {
            bool state = true;
            {
                int i = 0;
                if (e.Control && e.KeyCode == Keys.Left && state)
                    if (int.TryParse(Text_Select_Page.Text, out i))
                    {
                        Text_Select_Page.Text = (i - 5).ToString();
                        state = !state;
                    }
                if (e.Control && e.KeyCode == Keys.Right && state)
                    if (int.TryParse(Text_Select_Page.Text, out i))
                    {
                        Text_Select_Page.Text = (i + 5).ToString();
                        state = !state;
                    }
                if (e.Shift && e.KeyCode == Keys.Left && state)
                    if (int.TryParse(Text_Select_Page.Text, out i))
                    {
                        Text_Select_Page.Text = (i - 10).ToString();
                        state = !state;
                    }
                if (e.Shift && e.KeyCode == Keys.Right && state)
                    if (int.TryParse(Text_Select_Page.Text, out i))
                    {
                        Text_Select_Page.Text = (i + 10).ToString();
                        state = !state;
                    }
                if (e.KeyCode == Keys.Left && state)
                    if (int.TryParse(Text_Select_Page.Text, out i))
                    {
                        Text_Select_Page.Text = (i - 1).ToString();
                        state = !state;
                    }
                if (e.KeyCode == Keys.Right && state)
                    if (int.TryParse(Text_Select_Page.Text, out i))
                    {
                        Text_Select_Page.Text = (i + 1).ToString();
                        state = !state;
                    }
            }

            Explorer_Set(e);
        }
        public void Explorer_Set(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && int.TryParse(Text_Select_Page.Text, out int result))
            {
                for (int i = (result -1) * viewInfo.Count, w = 0; i < result * viewInfo.Count; i++, w++)
                {
                    if (i < infos.Count && w < viewInfo.Count)
                    {
                        viewInfo[w].Clear();
                        viewInfo[w].GetThumbnail(infos[i]);
                        viewInfo[w].Label_Type.Text += infos[i].Type;
                        viewInfo[w].Label_Lang.Text += infos[i].Language;
                        viewInfo[w].Label_Series.Text += infos[i].Series;
                        viewInfo[w].Label_Title.Text += infos[i].Title;
                        viewInfo[w].gallerie = infos[i];
                        viewInfo[w].ViewEvent += ViewerPage_ViewEvent;
                    }
                    else if (i >= infos.Count && w < viewInfo.Count)
                    {
                        viewInfo[w].Clear();
                    }
                }
            }
            if (infos.Count != 0)
                if (Math.Ceiling((double)infos.Count / viewInfo.Count).ToString() != Label_Select_Page.Text.Split(' ')[1])
                    Label_Select_Page.Text = "~ " + Math.Ceiling((double)infos.Count / viewInfo.Count).ToString();

        }

        Gallerie ViewGallerie = null;
        private void ViewerPage_ViewEvent(object sender, Gallerie e)
        {
            ViewGallerie = e;
            StreamReader sr = new StreamReader(Global.DownloadPath + e.ID + "\\info.ini");
            string page = Regex.Split(sr.ReadToEnd(), "Page : ")[1].Split('\n')[0];
            Label_Page.Text = "~ " + page.ToString();
            Text_Page.Text = "1";
            Pic_Viewer.Image = Image.FromFile(Global.DownloadPath + e.ID + "\\" + Text_Page.Text + ".jpg");
        }

        private void Panel_Explorer_Resize(object sender, EventArgs e)
        {
            int prevCount = viewInfo.Count;
            int nowCount = 0;


            for (int i = 151; i <= Panel_Explorer.Size.Height; i += 151)
            {
                nowCount++;
            }

            if (prevCount > nowCount)
            {
                for (int i = nowCount; i < prevCount; i++)
                {
                    viewInfo[nowCount].Dispose();
                    viewInfo.RemoveAt(nowCount);
                }
            }
            else if (prevCount < nowCount)
            {
                for (int i = prevCount; i < nowCount; i++)
                {
                    ViewInfo pre = new ViewInfo
                    {
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                        Location = new Point(0, 150 * i),
                        Size = new Size(250, 150),
                        // Name = "Preview_" + i
                    };
                    viewInfo.Add(pre);
                    Panel_Explorer.Controls.Add(pre);
                }
            }
            else
            {
                return;
            }

            if (infos.Count != 0)
                if (Math.Ceiling((double)infos.Count / viewInfo.Count).ToString() != Label_Select_Page.Text.Split(' ')[1])
                    Label_Select_Page.Text = "~ " + Math.Ceiling((double)infos.Count / viewInfo.Count).ToString();

            Text_Select_Page_KeyDown(null, new KeyEventArgs(Keys.Enter));

        }

        private void Text_Page_KeyDown(object sender, KeyEventArgs e)
        {

            if (int.TryParse(Text_Page.Text, out int result))
            {
                bool state = false;

                if (e.KeyCode == Keys.Left)
                {
                    result -= 1;
                    if (result < 1)
                    {
                        result = 1;
                    }
                    state = true;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    result += 1;
                    if (result > int.Parse(Label_Page.Text.Split(' ')[1]))
                    {
                        result = int.Parse(Label_Page.Text.Split(' ')[1]);
                    }
                    state = true;
                }
                Text_Page.Text = result.ToString();

                if (e.KeyCode == Keys.Enter || state)
                {
                    if (1 <= result && result <= int.Parse(Label_Page.Text.Split(' ')[1]))
                    {
                        if (ViewGallerie != null)
                            Pic_Viewer.Image = Image.FromFile(Global.DownloadPath + ViewGallerie.ID + "\\" + Text_Page.Text + ".jpg");
                    }
                }

                
            }
            


        }
    }
    
}
