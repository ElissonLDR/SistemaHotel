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

namespace PIM.View
{
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario frmCadFuncionario = new frmFuncionario();
            frmCadFuncionario.TopLevel = false;
            frmCadFuncionario.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmCadFuncionario);
            frmCadFuncionario.Show();
            Selecao.Top = btnFuncionarios.Top;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmEstoque.TopLevel = false;
            frmEstoque.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmEstoque);
            frmEstoque.Show();
            Selecao.Top = btnEstoque.Top;
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.TopLevel = false;
            frmInicio.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmInicio);
            frmInicio.Show();
            Selecao.Top = btnInicio.Top;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Hotel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Hotel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Menu = new Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.ShowDialog();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            frmDadosAdm frmDadosAdm = new frmDadosAdm();
            frmDadosAdm.TopLevel = false;
            frmDadosAdm.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmDadosAdm);
            frmDadosAdm.Show();
            Selecao.Top = btnDados.Top;
        }

        private void MenuAdm_Load(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.TopLevel = false;
            frmInicio.Dock = DockStyle.Fill;
            pCentral.Controls.Clear();
            pCentral.Controls.Add(frmInicio);
            frmInicio.Show();
            Selecao.Top = btnInicio.Top;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btFechar_Click_1(object sender, EventArgs e)
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

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btMaximizar.Visible = true;
            btRestaurar.Visible = false;
        }

        private void btMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pMover_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
