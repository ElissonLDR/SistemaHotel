using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.DAO;

namespace PIM.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void btnHospedes_Click(object sender, EventArgs e)
        {
            frmHospedes frmHospedes = new frmHospedes();
            frmHospedes.TopLevel = false;
            frmHospedes.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmHospedes);
            frmHospedes.Show();
            Selecao.Top = btnHospedes.Top;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Hotel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btMaximizar.Visible = false;
            btRestaurar.Visible = true;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btMaximizar.Visible = true;
            btRestaurar.Visible = false;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            frmReserva frmReserva = new frmReserva();
            frmReserva.TopLevel = false;
            frmReserva.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmReserva);
            frmReserva.Show();
            Selecao.Top = btnReserva.Top;
        }

        private void btnFechamento_Click(object sender, EventArgs e)
        {
            frmFechamento frmFechamento= new frmFechamento();
            frmFechamento.TopLevel = false;
            frmFechamento.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmFechamento);
            frmFechamento.Show();
            Selecao.Top = btnFechamento.Top;
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            frmQuartos frmQuartos = new frmQuartos();
            frmQuartos.TopLevel = false;
            frmQuartos.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmQuartos);
            frmQuartos.Show();
            Selecao.Top = btnQuartos.Top;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Closed += (s, args) => this.Close();
            frmLogin.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.TopLevel = false;
            frmInicio.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmInicio);
            frmInicio.Show();
            Selecao.Top = btnInicio.Top;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]        
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pMover_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            frmCheckin frmCheckin = new frmCheckin();
            frmCheckin.TopLevel = false;
            frmCheckin.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmCheckin);
            frmCheckin.Show();
            Selecao.Top = btnCheckin.Top;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Hotel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            frmAdicionais frmAdicionais = new frmAdicionais();
            frmAdicionais.TopLevel = false;
            frmAdicionais.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmAdicionais);
            frmAdicionais.Show();
            Selecao.Top = btnAdicionais.Top;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.TopLevel = false;
            frmInicio.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmInicio);
            frmInicio.Show();
            Selecao.Top = btnInicio.Top;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmManual frmManual = new frmManual();
            frmManual.TopLevel = false;
            frmManual.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmManual);
            frmManual.Show();
            Selecao.Top = btnManual.Top;
        }
    }
}
