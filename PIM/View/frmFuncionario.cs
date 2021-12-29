using PIM.CTR;
using PIM.DAO;
using PIM.Model;
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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        Funcionario funcionario;
        ctrFuncionario ctrFuncionario;
        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            funcionario = new Funcionario();
            ctrFuncionario = new ctrFuncionario();
            DataGrid();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            pFormulario.Visible = true;
            btnSalvar.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnSalvarAlteracao.Visible = false;
            TextBoxClear();
            TextBoxEnable();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pFormulario.Visible = true;
            btnSalvar.Visible = false;
            btnAlterar.Visible = true;
            TextBoxDisable();

            try
            {
                DataGridViewRow row = dgvFuncionario.Rows[e.RowIndex];
                txtCPF.Text = row.Cells[1].Value.ToString();
                funcionario.CPF = txtCPF.Text;
                ctrFuncionario.Read(funcionario);
                MostraText();
            }
            catch
            {

            }
                      
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text)||string.IsNullOrWhiteSpace(txtCPF.Text)||
                string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtRG.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) || string.IsNullOrWhiteSpace(txtCel.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Preencha as informações corretamente.");
            }
            else
            {
                if(funcionario.CPF == "")
                {
                    MessageBox.Show("Esse funcionário já esta cadastrado!");
                }
                else
                {
                    NomesText();
                    ctrFuncionario.Create(funcionario);
                    DataGrid();
                    pFormulario.Visible = false;
                }
                
            }            
        }

        public void NomesText()
        {
            txtSalario.Text = Double.Parse(txtSalario.Text).ToString("C2");

            funcionario.Nome = txtNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.RG = txtRG.Text;
            funcionario.Nasc = txtNasc.Text;
            funcionario.Cel = txtCel.Text;
            funcionario.DtAdmissao = txtDtAdmissao.Text;
            funcionario.Cargo = txtCargo.Text;
            funcionario.CEP = txtCEP.Text;
            funcionario.Salario = txtSalario.Text;
            funcionario.Rua = txtRua.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = txtEstado.Text;
            funcionario.SenhaFuncionario = txtSenha.Text;            
        }
        public void NomesText2()
        {
            funcionario.Nome = txtNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.RG = txtRG.Text;
            funcionario.Nasc = txtNasc.Text;
            funcionario.Cel = txtCel.Text;
            funcionario.DtAdmissao = txtDtAdmissao.Text;
            funcionario.Cargo = txtCargo.Text;
            funcionario.CEP = txtCEP.Text;
            funcionario.Salario = txtSalario.Text;
            funcionario.Rua = txtRua.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = txtEstado.Text;
            funcionario.SenhaFuncionario = txtSenha.Text;            
        }
        public void MostraText()
        {
            txtNome.Text = funcionario.Nome;
            txtCPF.Text = funcionario.CPF;
            txtRG.Text = funcionario.RG;
            txtNasc.Text= funcionario.Nasc;
            txtCel.Text = funcionario.Cel;
            txtDtAdmissao.Text = funcionario.DtAdmissao;
            txtCargo.Text = funcionario.Cargo;
            txtCEP.Text = funcionario.CEP;
            txtSalario.Text = funcionario.Salario;
            txtRua.Text = funcionario.Rua;
            txtBairro.Text = funcionario.Bairro;
            txtCidade.Text = funcionario.Cidade;
            txtEstado.Text = funcionario.Estado;
            txtSenha.Text = funcionario.SenhaFuncionario;            
        }
        public void TextBoxEnable()
        {
            txtNome.Enabled = true;
            txtRG.Enabled = true;
            txtNasc.Enabled = true;
            txtCel.Enabled = true;
            txtDtAdmissao.Enabled = true;
            txtCargo.Enabled = true;
            txtCEP.Enabled = true;
            txtSalario.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtSenha.Enabled = true;            
        }
        public void TextBoxDisable()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtRG.Enabled = false;
            txtNasc.Enabled = false;
            txtCel.Enabled = false;
            txtDtAdmissao.Enabled = false;
            txtCargo.Enabled = false;
            txtCEP.Enabled = false;
            txtSalario.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtSenha.Enabled = false;            
        }
        public void TextBoxClear()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtNasc.Value = DateTime.Today;
            txtCel.Clear();
            txtDtAdmissao.Value = DateTime.Today;
            txtCargo.Clear();
            txtCEP.Clear();
            txtSalario.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.SelectedIndex = 0;
            txtSenha.Clear();            
        }
        public void DataGrid()
        {
            DataTable dataTable = new DataTable();

            daoFuncionario daoFuncionario = new daoFuncionario();

            dataTable = daoFuncionario.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvFuncionario.DataSource = dataTable;
            }
            else
            {
                dgvFuncionario.DataSource = null;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnExcluir.Visible = true;
            btnSalvarAlteracao.Visible = true;
            TextBoxEnable();
        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            funcionario.CPF = txtCPF.Text;
            NomesText2();
            ctrFuncionario.Update(funcionario);
            DataGrid();
            pFormulario.Visible = false;
        }

        private void btnExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Hotel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionario.CPF = txtCPF.Text;
                ctrFuncionario.Delete(funcionario);
                DataGrid();
                pFormulario.Visible = false;
            }            
        }
    }
}
