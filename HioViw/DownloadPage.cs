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
    public delegate void Change(bool IsDownloadPage);

    public partial class DownloadPage : UserControl
    {
        public event Change Change;

        private void OnChange()
        {
            Change?.Invoke(true);
        }


        public DownloadPage()
        {
            InitializeComponent();



            {
                Panel_Search_Title.Location = new Point(Panel_Search.Size.Width + 3, 160);
                Panel_Search_Tags.Location = new Point(Panel_Search.Size.Width + 3, 160 + 55 * 1);
                Panel_Search_Type.Location = new Point(Panel_Search.Size.Width + 3, 160 + 55 * 2);
                Panel_Search_Language.Location = new Point(Panel_Search.Size.Width + 3, 160 + 55 * 3);
                Panel_Search_Series.Location = new Point(Panel_Search.Size.Width + 3, 160 + 55 * 4);
                Panel_Search_Character.Location = new Point(Panel_Search.Size.Width + 3, 160 + 55 * 5);
                Panel_Search_Range.Location = new Point(Panel_Search.Size.Width + 3, 160 + 55 * 6);

                SearchPairs[listBox_Type.Name] = listBox_Type;
                SearchPairs[listBox_AddType.Name] = listBox_AddType;

                SearchPairs[listBox_TagDelete.Name] = listBox_TagDelete;
                SearchPairs[listBox_AddTagDelete.Name] = listBox_AddTagDelete;
                SearchPairs[listBox_TagAdd.Name] = listBox_TagAdd;
                SearchPairs[listBox_AddTagAdd.Name] = listBox_AddTagAdd;

                SearchPairs[listBox_Language.Name] = listBox_Language;
                SearchPairs[listBox_AddLanguage.Name] = listBox_AddLanguage;

                SearchPairs[listBox_SeriesAdd.Name] = listBox_SeriesAdd;
                SearchPairs[listBox_AddSeriesAdd.Name] = listBox_AddSeriesAdd;

                SearchPairs[listBox_CharacterDelete.Name] = listBox_CharacterDelete;
                SearchPairs[listBox_AddCharacterDelete.Name] = listBox_AddCharacterDelete;
                SearchPairs[listBox_CharacterAdd.Name] = listBox_CharacterAdd;
                SearchPairs[listBox_AddCharacterAdd.Name] = listBox_AddCharacterAdd;
            }

            Menu_Button.Add(Btn_Preview);
            Menu_Button.Add(Btn_SearchResult);
            Menu_Button.Add(Btn_Option);

            #region Read DB
            StreamReader sr = new StreamReader("Hitomi_DB\\_Tags.txt");
            while (!sr.EndOfStream)
            {
                TagsList.Add(sr.ReadLine());
            }
            sr.Close();

            sr = new StreamReader("Hitomi_DB\\_Series.txt");
            while (!sr.EndOfStream)
            {
                SeriesList.Add(sr.ReadLine());
            }
            sr.Close();

            sr = new StreamReader("Hitomi_DB\\_Character.txt");
            while (!sr.EndOfStream)
            {
                CharacterList.Add(sr.ReadLine());
            }
            sr.Close();
            #endregion


            Panel_Download_List.Text_Select_Page.KeyDown += LText_Select_Page_KeyDown;
            Panel_Search_Download.Text_Select_Page.KeyDown += DText_Select_Page_KeyDown;

            bgw.DoWork += Bgw_DoWork;
            se.Find += Se_Find;
            bgw.WorkerSupportsCancellation = true;
        }

        private List<Gallerie> DownloadLists = new List<Gallerie>();

        private void Pre_Download(object sender, Gallerie e, float Percentage)
        {
            DownloadLists.Add(e);
            DownloadLog_Add(e, Percentage);
            Panel_Download_List.Label_Select_Page?.Invoke(new MethodInvoker(() =>
            {
                if (Math.Round((double)(DownloadLists.Count) / DownloadLogs.Count) != int.Parse(Panel_Download_List.Label_Select_Page.Text.Split(' ')[1]))
                {
                    Panel_Download_List.Label_Select_Page.Text = "~ " + Math.Round((double)DownloadLists.Count / DownloadLogs.Count).ToString();
                }
            }));
        }

        private void Se_Find(object sender, Gallerie e)
        {
            SearchResult.Add(e);

            
            try
            {
                Preview_AddReverse(e);
                Panel_Search_Download.Label_Select_Page?.Invoke(new MethodInvoker(() =>
                {
                    if (Math.Round((double)SearchResult.Count / Previews.Count) != int.Parse(Panel_Search_Download.Label_Select_Page.Text.Split(' ')[1]))
                    {
                        Panel_Search_Download.Label_Select_Page.Text = "~ " + Math.Round((double)SearchResult.Count / Previews.Count).ToString();
                    }
                }));

            }
            catch (Exception e1)
            {
                MessageBox.Show("Se_Find " + e1.ToString());
            }
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            SearchEngine.Stop = false;
            Int_Preview_List = 0;
            SearchResult.Clear();
            foreach (var data in Previews)
            {
                this.Invoke(new MethodInvoker(() => { data.Clear(); }));
            }
            se.Find_Start(sd, Panel_DownloadBar);

        }

        List<Preview> Previews = new List<Preview>();
        List<DownloadLog> DownloadLogs = new List<DownloadLog>();

        int Int_Preview_List = 0;
        private void Preview_AddReverse(Gallerie gallerie)
        {
            
            if (Int_Preview_List < Previews.Count)
            {
                

                Previews[Int_Preview_List].Clear();
                try
                {
                    Previews[Int_Preview_List].Invoke(new MethodInvoker(() =>
                    {
                        Previews[Int_Preview_List].Clear();
                        Previews[Int_Preview_List].Label_ID.Text += gallerie.ID;
                        Previews[Int_Preview_List].Label_Title.Text += gallerie.Title;
                        Previews[Int_Preview_List].Label_Group.Text += gallerie.Uploader;
                        Previews[Int_Preview_List].Label_Series.Text += gallerie.Series;
                        Previews[Int_Preview_List].Label_Type.Text += gallerie.Type;
                        Previews[Int_Preview_List].Label_Language.Text += gallerie.Language;

                        for (int i = 0; i < gallerie.Tags.Count - 1; i++)
                            Previews[Int_Preview_List].Label_Tags.Text += gallerie.Tags[i] + ", ";
                        if (gallerie.Tags.Count != 0)
                            Previews[Int_Preview_List].Label_Tags.Text += gallerie.Tags[gallerie.Tags.Count - 1];

                        for (int i = 0; i < gallerie.Character.Count - 1; i++)
                            Previews[Int_Preview_List].Label_Character.Text += gallerie.Character[i] + ", ";
                        if (gallerie.Character.Count != 0)
                            Previews[Int_Preview_List].Label_Character.Text += gallerie.Character[gallerie.Character.Count - 1];
                        
                        Previews[Int_Preview_List].GetThumbnail(gallerie);
                    }));
                }
                catch (Exception)
                {
                    // MessageBox.Show(e123.ToString() + " " + gallerie.ID + " " + gallerie.Title);
                }



                for (int i = 0; i < Int_Preview_List; i++)
                {
                    Previews[i].Invoke(new MethodInvoker(() => { Previews[i].Refresh(); }));
                }
                Int_Preview_List++;
            }
        }
        private void DownloadLog_Add(Gallerie gallerie, float percentage)
        {
            foreach (var data in DownloadLogs)
            {
                if (data.gallerie != null && data.gallerie.ID == gallerie.ID)
                {
                    data.Percentage = percentage;
                    return;
                }
            }

            for (int i = DownloadLogs.Count - 2; i >= 0; i--)
            {
                if (DownloadLogs[i].gallerie != null)
                {
                    DownloadLogs[i].Invoke(new MethodInvoker(delegate () {
                        DownloadLogs[i + 1].gallerie = DownloadLogs[i].gallerie;
                        DownloadLogs[i + 1].Percentage = DownloadLogs[i].Percentage;
                        DownloadLogs[i + 1].Label_ID.Text = DownloadLogs[i].Label_ID.Text;
                        DownloadLogs[i + 1].Label_Title.Text = DownloadLogs[i].Label_Title.Text;
                        DownloadLogs[i + 1].Label_Series.Text = DownloadLogs[i].Label_Series.Text;
                        DownloadLogs[i + 1].Label_Type.Text = DownloadLogs[i].Label_Type.Text;
                        DownloadLogs[i + 1].Label_Language.Text = DownloadLogs[i].Label_Language.Text;
                        DownloadLogs[i + 1].GetThumbnail(DownloadLogs[i + 1].gallerie);
                    }));
                }
                
            }

            DownloadLog preview = DownloadLogs[0];

            preview.Invoke(new MethodInvoker(delegate ()
            {
                preview.Clear();
                preview.gallerie = gallerie;
                preview.Label_ID.Text += gallerie.ID;
                preview.Label_Title.Text += gallerie.Title;
                preview.Label_Series.Text += gallerie.Series;
                preview.Label_Type.Text += gallerie.Type;
                preview.Label_Language.Text += gallerie.Language;
                preview.GetThumbnail(gallerie);

            }));

            DownloadLogs[0].Invoke(new MethodInvoker(delegate () { DownloadLogs[0] = preview; }));

            foreach (var pre in DownloadLogs)
            {
                pre.Invoke(new MethodInvoker(delegate ()
                {
                    pre.Refresh();
                }));
            }
        }


        private void Panel_Search_Download_Resize(object sender, EventArgs e)
        {
            int prevCount = Previews.Count;
            int nowCount = 0;


            for (int i = 112; i <= Panel_Search_Download.Panel_Downloaded.Size.Height; i += 106)
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
                        Size = new Size(Panel_Search_Download.Panel_Downloaded.Size.Width - 12, 100),
                        // Name = "Preview_" + i
                    };
                    pre.Download += Pre_Download;
                    pre.Clear();
                    Previews.Add(pre);
                    Panel_Search_Download.Panel_Downloaded.Controls.Add(pre);
                }
            }
            else
            {
                return;
            }

            if (SearchResult.Count != 0)
                if (Math.Round((double)SearchResult.Count / Previews.Count).ToString() != Panel_Search_Download.Label_Select_Page.Text.Split(' ')[1])
                    Panel_Search_Download.Label_Select_Page.Text = "~ " + Math.Round((double)SearchResult.Count / Previews.Count).ToString();

            DText_Select_Page_KeyDown(null, new KeyEventArgs(Keys.Enter));

        }

        private void Panel_Download_List_Resize(object sender, EventArgs e)
        {
            int prevCount = DownloadLogs.Count;
            int nowCount = 0;


            for (int i = 112; i <= Panel_Download_List.Panel_Downloaded.Size.Height; i += 106)
            {
                nowCount++;
            }

            if (prevCount > nowCount)
            {
                for (int i = nowCount; i < prevCount; i++)
                {
                    DownloadLogs[nowCount].Dispose();
                    DownloadLogs.RemoveAt(nowCount);
                }
            }
            else if (prevCount < nowCount)
            {
                for (int i = prevCount; i < nowCount; i++)
                {
                    DownloadLog pre = new DownloadLog
                    {
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                        Location = new Point(6, (112 + 106 * (i)) - 106),
                        Size = new Size(Panel_Search_Download.Panel_Downloaded.Size.Width - 12, 100),
                        // Name = "Preview_" + i
                    };
                    pre.Clear();
                    DownloadLogs.Add(pre);
                    Panel_Download_List.Panel_Downloaded.Controls.Add(pre);
                }
            }
            else
            {
                return;
            }

            if (DownloadLists.Count != 0)
                if (Math.Round((double)SearchResult.Count / DownloadLogs.Count).ToString() != Panel_Download_List.Label_Select_Page.Text.Split(' ')[1])
                    Panel_Search_Download.Label_Select_Page.Text = "~ " + Math.Round((double)DownloadLists.Count / DownloadLogs.Count).ToString();

            DText_Select_Page_KeyDown(null, new KeyEventArgs(Keys.Enter));
        }
        

        private void DText_Select_Page_KeyDown(object sender, KeyEventArgs e)
        {
            bool state = true;
            if (e.Control && e.KeyCode == Keys.Left && state)
                if (int.TryParse(Panel_Search_Download.Text_Select_Page.Text, out int i))
                {
                    Panel_Search_Download.Text_Select_Page.Text = (i - 5).ToString();
                    state = !state;
                }

            if (e.Control && e.KeyCode == Keys.Right && state)
                if (int.TryParse(Panel_Search_Download.Text_Select_Page.Text, out int i))
                {
                    Panel_Search_Download.Text_Select_Page.Text = (i + 5).ToString();
                    state = !state;
                }

            if (e.Shift && e.KeyCode == Keys.Left && state)
                if (int.TryParse(Panel_Search_Download.Text_Select_Page.Text, out int i))
                {
                    Panel_Search_Download.Text_Select_Page.Text = (i - 10).ToString();
                    state = !state;
                }

            if (e.Shift && e.KeyCode == Keys.Right && state)
                if (int.TryParse(Panel_Search_Download.Text_Select_Page.Text, out int i))
                {
                    Panel_Search_Download.Text_Select_Page.Text = (i + 10).ToString();
                    state = !state;
                }

            if (e.KeyCode == Keys.Left && state)
                if (int.TryParse(Panel_Search_Download.Text_Select_Page.Text, out int i))
                {
                    Panel_Search_Download.Text_Select_Page.Text = (i - 1).ToString();
                    state = !state;
                }

            if (e.KeyCode == Keys.Right && state)
                if (int.TryParse(Panel_Search_Download.Text_Select_Page.Text, out int i))
                {
                    Panel_Search_Download.Text_Select_Page.Text = (i + 1).ToString();
                    state = !state;
                }


            if (e.KeyCode == Keys.Enter || !state)
            {
                int num = 0;
                if (int.TryParse(Panel_Search_Download.Text_Select_Page.Text, out num) && SearchResult.Count != 0)
                {
                    if (num < 1)
                    {
                        return;
                    }

                    Int_Preview_List = 0;
                    for (int i = Previews.Count * (num - 1); i < Previews.Count * num; i++)
                    {

                        if (i < SearchResult.Count)
                        {
                            Preview_AddReverse(SearchResult[i]);
                        }
                    }
                }
            }
        }

        private void LText_Select_Page_KeyDown(object sender, KeyEventArgs e)
        {
            bool state = true;
            if (e.Control && e.KeyCode == Keys.Left && state)
                if (int.TryParse(Panel_Download_List.Text_Select_Page.Text, out int i))
                {
                    Panel_Download_List.Text_Select_Page.Text = (i - 5).ToString();
                    state = !state;
                }
            if (e.Control && e.KeyCode == Keys.Right && state)
                if (int.TryParse(Panel_Download_List.Text_Select_Page.Text, out int i))
                {
                    Panel_Download_List.Text_Select_Page.Text = (i + 5).ToString();
                    state = !state;
                }
            if (e.Shift && e.KeyCode == Keys.Left && state)
                if (int.TryParse(Panel_Download_List.Text_Select_Page.Text, out int i))
                {
                    Panel_Download_List.Text_Select_Page.Text = (i - 10).ToString();
                    state = !state;
                }
            if (e.Shift && e.KeyCode == Keys.Right && state)
                if (int.TryParse(Panel_Download_List.Text_Select_Page.Text, out int i))
                {
                    Panel_Download_List.Text_Select_Page.Text = (i + 10).ToString();
                    state = !state;
                }
            if (e.KeyCode == Keys.Left && state)
                if (int.TryParse(Panel_Download_List.Text_Select_Page.Text, out int i))
                {
                    Panel_Download_List.Text_Select_Page.Text = (i - 1).ToString();
                    state = !state;
                }
            if (e.KeyCode == Keys.Right && state)
                if (int.TryParse(Panel_Download_List.Text_Select_Page.Text, out int i))
                {
                    Panel_Download_List.Text_Select_Page.Text = (i + 1).ToString();
                    state = !state;
                }

            if (e.KeyCode == Keys.Enter || !state)
            {

                if (int.TryParse(Panel_Download_List.Text_Select_Page.Text, out int num) && SearchResult.Count != 0)
                {
                    if (num < 1)
                    {
                        return;
                    }

                    Int_Preview_List = 0;
                    for (int i = DownloadLists.Count - 1; i >= DownloadLogs.Count * (num - 1); i--)
                    {
                        Preview_AddReverse(DownloadLists[i]);
                    }
                }
            }
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

        #region Download Menubar Draw Color Button ( need Code : SearchResult_Click )
        List<Control> Menu_Button = new List<Control>();
        private void Btn_Color(Control sender)
        {
            bool sen = !(bool)sender.Tag;

            foreach (var c in Menu_Button)
            {
                c.Tag = false;
                c.BackColor = Color.FromArgb(20, 20, 20);
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
            DText_Select_Page_KeyDown(null, new KeyEventArgs(Keys.Enter));

            Panel_Search.Location = new Point(0, Btn_Option.Location.Y + 55);
            Btn_Color(sender as Control);
            if (Panel_Download_List.Visible != true)
                Panel_Search.Visible = !Panel_Search.Visible;
            Panel_Search_Download.Visible = true;
            Panel_Download_List.Visible = false;

            
        }


        private void Btn_Downloa_Click(object sender, EventArgs e)
        {
            Panel_Search_Download.Visible = false;
            Panel_Download_List.Visible = true;

            Btn_Color(sender as Control);
        }

        private void Btn_SearchResult_Click(object sender, EventArgs e)
        {
            

            Panel_Search_Character.Visible = false;
            Panel_Search_Language.Visible = false;
            Panel_Search_Range.Visible = false;
            Panel_Search_Series.Visible = false;
            Panel_Search_Tags.Visible = false;
            Panel_Search_Type.Visible = false;
            Panel_Search_Title.Visible = false;



            Btn_Color(sender as Control);

            sd.Title = Text_Search_Title.Text;
            sd.Tags = listBox_AddTagAdd.Items.Cast<string>().ToList();

            sd.Type = listBox_AddType.Items.Cast<string>().ToList();
            sd.Language = listBox_AddLanguage.Items.Cast<string>().ToList();

            sd.Series = listBox_AddSeriesAdd.Items.Cast<string>().ToList();
            
            sd.Character = listBox_AddCharacterAdd.Items.Cast<string>().ToList();
            sd.Character_Delete = listBox_AddCharacterDelete.Items.Cast<string>().ToList();

            sd.Tags = listBox_AddTagAdd.Items.Cast<string>().ToList();
            sd.Tags_Delete = listBox_AddTagDelete.Items.Cast<string>().ToList();

            sd.Start_Range = ulong.Parse(Text_StartRange.Text);
            sd.End_Range = ulong.Parse(Text_EndRange.Text);
            
            if (bgw.IsBusy)
            {
                if (MessageBox.Show("지금 현재 실행중입니다. 종료하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SearchEngine.Stop = true;
                }
            }
            else
            {
                bgw.RunWorkerAsync();
            }

        }
        #endregion

        #region Btn_Search_Click ( Visible != Visible )
        private void Btn_Search_Title_Click(object sender, EventArgs e)
        {
            Panel_Search_Title.Visible = !Panel_Search_Title.Visible;
            Panel_Search_Title.BringToFront();
        }

        private void Btn_Search_Tags_Click(object sender, EventArgs e)
        {
            Panel_Search_Tags.Visible = !Panel_Search_Tags.Visible;
            
            Panel_Search_Tags.BringToFront();
        }

        private void Btn_Search_Type_Click(object sender, EventArgs e)
        {
            Panel_Search_Type.Visible = !Panel_Search_Type.Visible;
           
            Panel_Search_Type.BringToFront();
        }

        private void Btn_Search_Language_Click(object sender, EventArgs e)
        {
            Panel_Search_Language.Visible = !Panel_Search_Language.Visible;
            Panel_Search_Language.BringToFront();
        }

        private void Btn_Search_Series_Click(object sender, EventArgs e)
        {
            Panel_Search_Series.Visible = !Panel_Search_Series.Visible;
            Panel_Search_Series.BringToFront();
        }

        private void Btn_Search_Character_Click(object sender, EventArgs e)
        {
            Panel_Search_Character.Visible = !Panel_Search_Character.Visible;
            Panel_Search_Series.BringToFront();
        }

        private void Btn_Search_Range_Click(object sender, EventArgs e)
        {
            Panel_Search_Range.Visible = !Panel_Search_Range.Visible;
            Panel_Search_Range.BringToFront();
        }
        #endregion

        #region Search Engine
        List<Gallerie> SearchResult = new List<Gallerie>();
        
        List<string> Tags = new List<string>();

        SearchEngine se = new SearchEngine();
        SearchData sd = new SearchData();
        BackgroundWorker bgw = new BackgroundWorker();

        List<string> TagsList = new List<string>();
        List<string> CharacterList = new List<string>();
        List<string> SeriesList = new List<string>();
        
        Dictionary<string, ListBox> SearchPairs = new Dictionary<string, ListBox>();
        private void Btn_Search_Add(object sender, EventArgs e)
        {
            var v = SearchPairs[("listBox_" + (sender as Control).Tag)];
            var p = SearchPairs[("listBox_Add" + (sender as Control).Tag)];

            if (v.SelectedItem == null)
                return;
            if (!p.Items.Contains(v.SelectedItem))
            {
                p.Items
                .Add(v.SelectedItem);
            }
        }
        private void Btn_Search_Delete(object sender, EventArgs e)
        {
            var v = SearchPairs[("listBox_Add" + (sender as Control).Tag)];
            if (v.SelectedIndex == -1)
                return;
            v.Items.RemoveAt(v.SelectedIndex);
        }
        private void Text_Search_Changed(object sender, EventArgs e)
        {
            var v = sender as Control;

            var listbox = SearchPairs["listBox_" + v.Name.Split('_')[1]];
            listbox.Items.Clear();

            switch (v.Name.Split('_')[1][0])
            {
                case 'T':
                    listbox.Items.AddRange(SearchListBox.GetListBox(TagsList, v.Text));
                    break;

                case 'S':
                    listbox.Items.AddRange(SearchListBox.GetListBox(SeriesList, v.Text));
                    break;

                case 'C':
                    listbox.Items.AddRange(SearchListBox.GetListBox(CharacterList, v.Text));
                    break;
            }


            
        }
        #endregion

        bool ch = false;
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (ch)
            {
                Panel_Download_OptionList.Size = new Size(150, Panel_Download_OptionList.Size.Height);

                Panel_Download_List.Width -= 150;
                Panel_Download_List.Location = new Point(Panel_Download_List.Location.X + 150, Panel_Download_List.Location.Y);

                Panel_Search_Download.Size = Panel_Download_List.Size;
                Panel_Search_Download.Location = Panel_Download_List.Location;

                ch = !ch;
            }
            else
            {
                Panel_Download_OptionList.Size = new Size(0, Panel_Download_OptionList.Size.Height);

                Panel_Download_List.Width += 150;
                Panel_Download_List.Location = new Point(Panel_Download_List.Location.X - 150, Panel_Download_List.Location.Y);

                Panel_Search_Download.Size = Panel_Download_List.Size;
                Panel_Search_Download.Location = Panel_Download_List.Location;

                ch = !ch;
            }
        }

        private void Btn_Viewer_Click(object sender, EventArgs e)
        {
            OnChange();
        }

    }
}
