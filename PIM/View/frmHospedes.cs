using PIM.CTR;
using PIM.DAO;
using PIM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PIM.View
{
    public partial class frmHospedes : Form
    {
        Hospedes hospedes;
        ctrHospedes ctrHospede;
        public frmHospedes()
        {
            InitializeComponent();
        }
        private void frmHospedes_Load(object sender, EventArgs e)
        {
            hospedes = new Hospedes();
            ctrHospede = new ctrHospedes();
            DataGrid();            
        }
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Digite um CPF para pesquisar!");
                LimpaTextbox();
                FormularioFalse();
            } else
            {
                hospedes.Buscar = txtBuscar.Text;
                ctrHospede.Read(hospedes);
                if (txtBuscar.Text == hospedes.CPF)
                {                    
                    MostraNomes();
                    pFormulario.Visible = true;
                    btnAlterar.Visible = true;
                    btnSalvar.Visible = false;
                    TextEnableFalse();
                    txtBuscar.Clear();
                }
                else
                {
                    FormularioFalse();
                    LimpaTextbox();
                    btnAlterar.Visible = false;
                    btnSalvarAlteracao.Visible = false;
                    btnExcluir.Visible = false;
                    TextEnableFalse();

                }

            }            
                      
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {            
            TextEnableTrue();
            pFormulario.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnSalvarAlteracao.Visible = false;
            btnSalvar.Visible = true;
            btnCPF.Checked = true;
            btnCPF.Visible = true;
            btnCNPJ.Visible = true;
            LimpaTextbox();

            
        }
            private void btnSalvar_Click(object sender, EventArgs e)
        {
            hospedes.Buscar = txtCPF.Text;
            ctrHospede.ReadCPF(hospedes);
            if (hospedes.CPF == "")
            {

            }
            else
            {
                MessageBox.Show("Esse CPF já existe.");
                FormularioFalse();
                LimpaTextbox();
                btnAlterar.Visible = false;
                btnSalvarAlteracao.Visible = false;
                btnExcluir.Visible = false;
                TextEnableFalse();
            }
            try
            {
                if ((string.IsNullOrWhiteSpace(txtNome.Text)) || (string.IsNullOrWhiteSpace(txtCPF.Text))
                || (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(txtCel.Text))
                || (string.IsNullOrWhiteSpace(txtCEP.Text)) || (string.IsNullOrWhiteSpace(txtRua.Text))
                || (string.IsNullOrWhiteSpace(txtBairro.Text)) || (string.IsNullOrWhiteSpace(txtCidade.Text))
                || (string.IsNullOrWhiteSpace(txtEstado.Text)) || (string.IsNullOrWhiteSpace(txtNascimento.Text)))
                {
                    MessageBox.Show("Preencha todas as informações corretamente");
                }
                else
                {
                    NomesText();
                    ctrHospede.Create(hospedes);
                    LimpaTextbox();
                    DataGrid();
                    txtEstado.SelectedIndex = 0;
                }
            }
            catch
            {
                MessageBox.Show("Opa, existe algum dado errado no formulário.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

            }
        }
        public void TextEnableFalse()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtNascimento.Enabled = false;
            txtEmail.Enabled = false;
            txtCel.Enabled = false;
            txtCEP.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
        }
        public void TextEnableTrue()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtNascimento.Enabled = true;
            txtEmail.Enabled = true;
            txtCel.Enabled = true;
            txtCEP.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;

        }
        public void LimpaTextbox()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtNascimento.Value = DateTime.Today;
            txtEmail.Clear();
            txtCel.Clear();
            txtCEP.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.SelectedIndex = 0;
            txtBuscar.Clear();
        }
        public void NomesText()
        {
            hospedes.Nome = txtNome.Text;
            hospedes.CPF = txtCPF.Text;
            hospedes.Nascimento = txtNascimento.Text;
            hospedes.Email = txtEmail.Text;
            hospedes.Celular = txtCel.Text;
            hospedes.CEP = txtCEP.Text;
            hospedes.Rua = txtRua.Text;
            hospedes.Bairro = txtBairro.Text;
            hospedes.Cidade = txtCidade.Text;
            hospedes.Estado = txtEstado.Text;
        }
        public void MostraNomes()
        {
            txtNome.Text = hospedes.Nome;
            txtCPF.Text = hospedes.CPF;
            txtNascimento.Text = hospedes.Nascimento;
            txtEmail.Text = hospedes.Email;
            txtCel.Text = hospedes.Celular;
            txtCEP.Text = hospedes.CEP;
            txtRua.Text = hospedes.Rua;
            txtBairro.Text = hospedes.Bairro;
            txtCidade.Text = hospedes.Cidade;
            txtEstado.Text = hospedes.Estado;

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                MessageBox.Show("Não há dados a serem alterados!");
            }else
            {
                TextEnableTrue();
                btnExcluir.Visible = true;
                btnSalvarAlteracao.Visible = true;
            }
            
        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            NomesText();
            ctrHospede.Update(hospedes);
            TextEnableFalse();
            btnExcluir.Visible = false;
            btnSalvarAlteracao.Visible = false;
            DataGrid();
        }
        public void FormularioFalse()
        {
            pFormulario.Visible = false;
        }
        private void txtBuscar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtBuscar.Clear();
        }

        private void btnExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Dados do hospede", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NomesText();
                ctrHospede.Delete(hospedes);
                LimpaTextbox();
                pFormulario.Visible = false;
                DataGrid();
            }
            
        }
        public void DataGrid()
        {
            DataTable dataTable = new DataTable();

            daoHospedes daoHospedes = new daoHospedes();

            dataTable = daoHospedes.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvHospedes.DataSource = dataTable;
            }
            else
            {
                dgvHospedes.DataSource = null;
            }
        }

        private void dgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                DataGridViewRow row = dgvHospedes.Rows[e.RowIndex];
                txtNome.Text = row.Cells[0].Value.ToString();
                txtNascimento.Text = row.Cells[1].Value.ToString();
                txtCPF.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtCel.Text = row.Cells[4].Value.ToString();
                txtCEP.Text = row.Cells[5].Value.ToString();
                txtRua.Text = row.Cells[6].Value.ToString();
                txtBairro.Text = row.Cells[7].Value.ToString();
                txtCidade.Text = row.Cells[8].Value.ToString();
                txtEstado.Text = row.Cells[9].Value.ToString();

                pFormulario.Visible = true;
                btnAlterar.Visible = true;
                btnSalvar.Visible = false;
                btnCPF.Visible = false;
                btnCNPJ.Visible = false;
                TextEnableFalse();
                txtBuscar.Clear();
                NomesText();
                hospedes.Buscar = txtCPF.Text;
            }
            catch
            {

            }
            
        }

        private void btnCPNJ_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "00 000 000/0000-00";
        }

        private void btnCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "000 000 000 - 00";
        }
    }
}
