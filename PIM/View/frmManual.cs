using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.View
{
    public partial class frmManual : Form
    {
        public frmManual()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lQuartos.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lEstoque.Visible = true;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Clear();
            lAdmin.Visible = true;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lFunc.Visible = true;
        }

        public void Clear()
        {
            lQuartos.Visible = false;
            lEstoque.Visible = false;
            lAdmin.Visible = false;
            lFunc.Visible = false;

            lHosp.Visible = false;
            lReser.Visible = false;
            lCheckin.Visible = false;
            lCheckout.Visible = false;
            lServ.Visible = false;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lHosp.Visible = true;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lReser.Visible = true;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lCheckin.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lCheckout.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lServ.Visible = true;
        }
    }
}
