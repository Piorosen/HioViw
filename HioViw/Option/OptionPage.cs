﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
    public partial class OptionPage : UserControl
    {
        public event Change Change;

        private void OnChange(int page)
        {
            Change?.Invoke(page);
        }

        public OptionPage()
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

        private void Btn_Viewer_Click(object sender, EventArgs e)
        {
            OnChange(1);
        }

        bool ch = true;
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (ch)
            {
                Panel_Option.Size = new Size(0, Panel_Option.Size.Height);

                ch = !ch;
            }
            else
            {
                Panel_Option.Size = new Size(150, Panel_Option.Size.Height);

                ch = !ch;
            }
        }
        

        private void Btn_Preview_Click(object sender, EventArgs e)
        {
            Panel_Update.BringToFront();
            Btn_Update.BackColor = Color.FromArgb(80, 80, 80);
            Btn_Info.BackColor = Color.FromArgb(20, 20, 20);


        }

        private void Btn_Info_Click(object sender, EventArgs e)
        {
            Panel_OptionList.BringToFront();
            Btn_Update.BackColor = Color.FromArgb(20, 20, 20);
            Btn_Info.BackColor = Color.FromArgb(80, 80, 80);

        }

    }
}
