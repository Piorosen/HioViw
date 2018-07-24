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

            {
                Panel_Search_Title.Location = new Point(-1, 165);
                Panel_Search_Tags.Location = new Point(-1, 165 + 55 * 1);
                Panel_Search_Type.Location = new Point(-1, 165 + 55 * 2);
                Panel_Search_Language.Location = new Point(-1, 165 + 55 * 3);
                Panel_Search_Series.Location = new Point(-1, 165 + 55 * 4);
                Panel_Search_Character.Location = new Point(-1, 165 + 55 * 5);
                Panel_Search_Range.Location = new Point(-1, 165 + 55 * 6);

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

            /// <summary> Add List Preivew </summary>
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

            bgw.DoWork += Bgw_DoWork;
            se.Find += Se_Find;
            bgw.WorkerSupportsCancellation = true;
        }

        int Test = 1;
        private void Se_Find(object sender, Gallerie e)
        {
            SearchResult.Add(e);
            Preview_AddReverse(e);

            if (Math.Round((double)SearchResult.Count / Previews.Count).ToString() != Label_Select_Page.Text.Split(' ')[1])
            {
                Label_Select_Page?.Invoke(new MethodInvoker(() =>
                {
                    Label_Select_Page.Text = "~ " + Math.Round((double)SearchResult.Count / Previews.Count).ToString();
                }));
            }

        }

        private void Text_Select_Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int num = 0;
                if (int.TryParse(Text_Select_Page.Text, out num))
                {
                    if (num < 1)
                    {
                        return;
                    }

                    Int_Preview_List = 0;
                    for (int i = Previews.Count * (num -1); i < Previews.Count * num; i++)
                    {
                        if (i < SearchResult.Count)
                        {
                            Preview_AddReverse(SearchResult[i]);
                        }
                    }
                }
            }
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Int_Preview_List = 0;
            SearchResult.Clear();
            se.Find_Start(sd, Panel_DownloadBar);

        }

        List<Gallerie> SearchResult = new List<Gallerie>();


        List<string> Tags = new List<string>();

        SearchEngine se = new SearchEngine();
        SearchData sd = new SearchData();
        BackgroundWorker bgw = new BackgroundWorker();

        List<string> TagsList = new List<string>();
        List<string> CharacterList = new List<string>();
        List<string> SeriesList = new List<string>();



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
        List<Preview> Previews = new List<Preview>();



        int Int_Preview_List = 0;

        private void Preview_AddReverse(Gallerie gallerie)
        {

            if (Int_Preview_List < Previews.Count)
            {
                
                Preview preview = Previews[index: Int_Preview_List];
                preview.Invoke(new MethodInvoker(() =>
                {
                    preview.Clear();
                    preview.Label_ID.Text += gallerie.ID;
                    preview.Label_Title.Text += gallerie.Title;
                    preview.Label_Group.Text += gallerie.Uploader;
                    preview.Label_Series.Text += gallerie.Series;
                    preview.Label_Type.Text += gallerie.Type;
                    preview.Label_Language.Text += gallerie.Language;

                    for (int i = 0; i < gallerie.Tags.Count - 1; i++)
                        preview.Label_Tags.Text += gallerie.Tags[i] + ", ";
                    if (gallerie.Tags.Count != 0)
                        preview.Label_Tags.Text += gallerie.Tags[gallerie.Tags.Count - 1];
                    for (int i = 0; i < gallerie.Character.Count - 1; i++)
                        preview.Label_Character.Text += gallerie.Character[i] + ", ";
                    if (gallerie.Character.Count != 0)
                        preview.Label_Character.Text += gallerie.Character[gallerie.Character.Count - 1];

                    preview.Label_Date.Text += gallerie.UploadDate;

                    preview.GetThumbnail(gallerie);
                }));

                Previews[Int_Preview_List].Invoke(new MethodInvoker(delegate () { Previews[Int_Preview_List] = preview; }));

                for (int i = 0; i < Int_Preview_List; i++)
                {
                    Previews[i].Invoke(new MethodInvoker(() => { Previews[i].Refresh(); }));
                }
                Int_Preview_List++;
            }
        }
        private void Preview_Add(Gallerie gallerie)
        {
            for (int i = Previews.Count - 2; i >= 0; i--)
            {
                Previews[i].Invoke(new MethodInvoker(delegate () {

                    
                    Previews[i + 1].Label_ID.Text = Previews[i].Label_ID.Text;
                    Previews[i + 1].Label_Title.Text = Previews[i].Label_Title.Text;
                    Previews[i + 1].Label_Group.Text = Previews[i].Label_Group.Text;
                    Previews[i + 1].Label_Series.Text = Previews[i].Label_Series.Text;
                    Previews[i + 1].Label_Type.Text = Previews[i].Label_Type.Text;
                    Previews[i + 1].Label_Language.Text = Previews[i].Label_Language.Text;
                    Previews[i + 1].Label_Tags.Text = Previews[i].Label_Tags.Text;
                    Previews[i + 1].Label_Character.Text = Previews[i].Label_Character.Text;
                    Previews[i + 1].Label_Date.Text = "Test";

                }));
            }

            Preview preview = Previews[0];
            
            preview.Invoke(new MethodInvoker(delegate ()
            {
                preview.Clear();
                preview.Label_ID.Text += gallerie.ID;
                preview.Label_Title.Text += gallerie.Title;
                preview.Label_Group.Text += gallerie.Uploader;
                preview.Label_Series.Text += gallerie.Series;
                preview.Label_Type.Text += gallerie.Type;
                preview.Label_Language.Text += gallerie.Language;


                for (int i = 0; i < gallerie.Tags.Count - 1; i++)
                {
                    preview.Label_Tags.Text += gallerie.Tags[i] + ", ";
                }
                if (gallerie.Tags.Count != 0)
                    preview.Label_Tags.Text += gallerie.Tags[gallerie.Tags.Count - 1];

                for (int i = 0; i < gallerie.Character.Count - 1; i++)
                {
                    preview.Label_Character.Text += gallerie.Character[i] + ", ";
                }

                if (gallerie.Character.Count != 0)
                    preview.Label_Character.Text += gallerie.Character[gallerie.Character.Count - 1];

                preview.Label_Date.Text += gallerie.UploadDate;
            }));

            Previews[0].Invoke(new MethodInvoker(delegate () { Previews[0] = preview; }));
            
            foreach (var pre in Previews)
            {
                pre.Invoke(new MethodInvoker(delegate ()
                {
                    pre.Refresh();
                }));
            }
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
                    bgw.CancelAsync();
                }
            }
            else
            {
                SearchEngine.Stop = false;
                bgw.RunWorkerAsync();
            }

        }
        #endregion

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

        private void Btn_DownloadStart_Click(object sender, EventArgs e)
        {

        }







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

        
    }
}
