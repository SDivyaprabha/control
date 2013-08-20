using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlsDesigns.UI;

namespace ControlsDesigns
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void navNewEntry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dwWin2.Hide();
            dwWin1.Hide();
            dwWin1.Text = "New Entry1";
            NewEntry frm = new NewEntry() { TopLevel = false };
            radPanel1.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            radPanel1.Controls.Add(frm);
            frm.Execute();
            dwWin1.Show();
        }

        private void navEditEntry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dwWin2.Hide();
            dwWin1.Hide();
            dwWin1.Text = "Registry Entry";
            VGrid frm = new VGrid() { TopLevel = false };
            radPanel1.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            radPanel1.Controls.Add(frm);
            frm.Execute();
            dwWin1.Show();
        }
    }
}
