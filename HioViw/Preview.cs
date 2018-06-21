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
    public partial class Preview : UserControl
    {
        public Preview()
        {
            InitializeComponent();
        }
    
        public void Clear()
        {
            Label_Character.Text = "Character : ";
            Label_ID.Text = "ID : ";
            Label_Title.Text = "Title : ";
            Label_Series.Text = "Series : ";
            Label_Type.Text = "Type : ";
            Label_Language.Text = "Language : ";
            Label_Tags.Text = "Tags : ";
            Label_Group.Text = "Group : ";
            Label_Date.Text = "Uploaded Date : ";

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
    }
}
