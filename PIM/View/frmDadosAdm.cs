using PIM.CTR;
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
    public partial class frmDadosAdm : Form
    {
        Admin admin;
        ctrAdmin ctrAdmin;
        public frmDadosAdm()
        {
            InitializeComponent();
        }

        private void frmDadosAdm_Load(object sender, EventArgs e)
        {
            admin = new Admin();
            ctrAdmin = new ctrAdmin();
            DataGrid();
        }

        public void DataGrid()
        {
            DataTable dataTable = new DataTable();

            dataTable = ctrAdmin.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvAdmin.DataSource = dataTable;
            }
            else
            {
                dgvAdmin.DataSource = null;
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvarAlteracao.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = true;

            txtNome.Enabled = true;
            txtCargo.Enabled = true;
            txtSenha.Enabled = true;
        }

        public void NomesText()
        {
            admin.Nome = txtNome.Text;
            admin.Senha = txtSenha.Text;
            admin.CNPJ = txtCNPJ.Text;
            admin.Cargo = txtCargo.Text;    
        }
        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            
            NomesText();
            ctrAdmin.Update(admin);
            DataGrid();
            btnSalvarAlteracao.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = false;
            TextClear();
            txtNome.Enabled = false;
            txtCNPJ.Enabled = false;
            txtCargo.Enabled = false;
            txtSenha.Enabled = false;
        }

        public void TextBoxDisable()
        {
            txtNome.Enabled = false;
            txtCNPJ.Enabled = false;
            txtCargo.Enabled = false;
            txtSenha.Enabled = false;
        }
        
        public void TextBoxEnable()
        {
            txtNome.Enabled = true;
            txtCNPJ.Enabled = true;
            txtCargo.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Visible = true;
            TextBoxDisable();
            try
            {
                DataGridViewRow row = dgvAdmin.Rows[e.RowIndex];
                txtNome.Text = row.Cells[0].Value.ToString();
                txtCNPJ.Text = row.Cells[1].Value.ToString();
                txtCargo.Text = row.Cells[2].Value.ToString();
                txtSenha.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = true;
            btnAlterar.Visible = false;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Visible = false;
            TextClear();
            TextBoxEnable();
            DataGrid();
        }

        public void TextClear()
        {
            txtNome.Clear();
            txtCNPJ.Clear();
            txtCargo.Clear();
            txtSenha.Clear();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCNPJ.Text)||string.IsNullOrWhiteSpace(txtNome.Text)||
                string.IsNullOrWhiteSpace(txtCargo.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todas informações corretamente.");
            }
            else
            {
                if(admin.CNPJ == "")
                {
                    MessageBox.Show("Esse CNPJ já existe!");
                }
                else
                {
                    NomesText();
                    ctrAdmin.Create(admin);

                    TextClear();
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = false;
                    btnSalvarAlteracao.Visible = false;

                    DataGrid();
                }
                
            }
            
        }

        private void btnExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NomesText();
            ctrAdmin.Delete(admin);

            TextClear();
            btnSalvar.Visible = false;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Visible = false;

            DataGrid();
        }

    }
}
