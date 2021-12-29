using PIM.CTR;
using PIM.Model;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Funcionario funcionario = new Funcionario();
        Admin admin = new Admin();
        ctrFuncionario ctrFuncionario = new ctrFuncionario();
        ctrAdmin ctrAdmin = new ctrAdmin();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            btnFuncionario.Checked = true;
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (btnFuncionario.Checked)
            {
                if(string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Digite o usuário ou senha para entrar!");
                }
                else
                {
                    funcionario.CPF = txtUsuario.Text;
                    funcionario.SenhaFuncionario = txtSenha.Text;

                    ctrFuncionario.Read(funcionario);

                    if (funcionario.CPF == txtUsuario.Text && funcionario.SenhaFuncionario == txtSenha.Text)
                    {
                        this.Hide();
                        Menu menu = new Menu();
                        menu.Closed += (s, args) => this.Close();
                        menu.ShowDialog();
                    }


                    else
                    {
                        MessageBox.Show("O usuário ou senha está incorreto.");
                        txtUsuario.Clear();
                        txtSenha.Clear();
                    }
                }                              
            }
            
            
            
            if (btnAdministrador.Checked)
            {
                if(string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Digite o usuário ou senha para entrar!");
                }
                else
                {
                    admin.CNPJ = txtUsuario.Text;
                    admin.Senha = txtSenha.Text;

                    ctrAdmin.Read(admin);

                    if (admin.CNPJ == txtUsuario.Text && admin.Senha == txtSenha.Text)
                    {
                        this.Hide();
                        MenuAdm menuAdm = new MenuAdm();
                        menuAdm.Closed += (s, args) => this.Close();
                        menuAdm.ShowDialog();
                    }


                    else
                    {
                        MessageBox.Show("O usuário ou senha está incorreto.");
                        txtUsuario.Clear();
                        txtSenha.Clear();
                    }
                }                              
            } 
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Mask = "000 000 000 - 00";
        }

        private void btnAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Mask = "00 000 000/0000-00";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
