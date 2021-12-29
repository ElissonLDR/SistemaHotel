using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.Model;
using PIM.CTR;
using PIM.DAO;

namespace PIM.View
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }
        Estoque estoque = new Estoque();
        ctrEstoque ctrEstoque = new ctrEstoque();
        private void frmEstoque_Load_1(object sender, EventArgs e)
        {
            DataGridAlimentos();
            DataGridEquipamentos();
            DataGridLavanderia();
            DataGridDiveros();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Clear();
            pFormulario.Visible = true;
            btnSalvar.Visible = true;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Visible = false;
            txtTipo.Enabled = true;
            txtNome.Enabled = true;
            txtQtd.Enabled = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha os dados corretamente!");
            }
            else
            {
                
                if (txtTipo.Text == "Alimentos")
                {
                    NomesText();
                    ctrEstoque.Create(estoque);
                    DataGridAlimentos();
                    DataGridDiveros();

                }
                else if (txtTipo.Text == "Equipamentos")
                {
                    NomesText();
                    ctrEstoque.Create(estoque);
                    DataGridEquipamentos();
                    DataGridDiveros();
                }
                else if (txtTipo.Text == "Lavanderia")
                {
                    NomesText();
                    ctrEstoque.Create(estoque);
                    DataGridLavanderia();
                    DataGridDiveros();
                }
                else
                {
                    MessageBox.Show("Escolha um tipo de estoque.");
                }

            }            
        }

        public void NomesText()
        {
            estoque.Tipo = txtTipo.Text;
            estoque.Nome = txtNome.Text;
            estoque.Quantidade = txtQtd.Text;
        }
        public void Clear()
        {
            txtTipo.Text = "Selecione o tipo";
            txtCod.Text = "---";
            txtNome.Clear();
            txtQtd.Clear();
        }
        private void dgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvAlimentos.Rows[e.RowIndex];
                txtCod.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtQtd.Text = row.Cells[2].Value.ToString();
                txtTipo.Text = row.Cells[3].Value.ToString();

                GridClick();
            }
            catch { }
                       
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvEquipamentos.Rows[e.RowIndex];
                txtCod.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtQtd.Text = row.Cells[2].Value.ToString();
                txtTipo.Text = row.Cells[3].Value.ToString();

                GridClick();
            }
            catch { }
        }      
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvLavanderia.Rows[e.RowIndex];
                txtCod.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtQtd.Text = row.Cells[2].Value.ToString();
                txtTipo.Text = row.Cells[3].Value.ToString();

                GridClick();
            }
            catch { }
            
        }
         
        public void GridClick()
        {
            txtNome.Enabled = false;
            txtQtd.Enabled = false;
            txtTipo.Enabled = false;
            pFormulario.Visible = true;
            btnAlterar.Visible = true;
            btnSalvar.Visible = false;
        }
        public void DataGridAlimentos()
        {
            DataTable dataTable = new DataTable();

            daoEstoque daoEstoque = new daoEstoque();

            dataTable = daoEstoque.DataGridAlimentos();

            if (dataTable.Rows.Count > 0)
            {
                dgvAlimentos.DataSource = dataTable;
            }
            else
            {
                dgvAlimentos.DataSource = null;
            }
        }
        public void DataGridEquipamentos()
        {
            DataTable dataTable = new DataTable();

            daoEstoque daoEstoque = new daoEstoque();

            dataTable = daoEstoque.DataGridEquipamentos();

            if (dataTable.Rows.Count > 0)
            {
                dgvEquipamentos.DataSource = dataTable;
            }
            else
            {
                dgvEquipamentos.DataSource = null;
            }
        }
        public void DataGridLavanderia()
        {
            DataTable dataTable = new DataTable();

            daoEstoque daoEstoque = new daoEstoque();

            dataTable = daoEstoque.DataGridLavanderia();

            if (dataTable.Rows.Count > 0)
            {
                dgvLavanderia.DataSource = dataTable;
            }
            else
            {
                dgvLavanderia.DataSource = null;
            }
        }
        public void DataGridDiveros()
        {
            DataTable dataTable = new DataTable();

            daoEstoque daoEstoque = new daoEstoque();

            dataTable = daoEstoque.DataGridDiveros();

            if (dataTable.Rows.Count > 0)
            {
                dgvDiversos.DataSource = dataTable;
            }
            else
            {
                dgvDiversos.DataSource = null;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = false;
            btnSalvarAlteracao.Visible = true;
            btnExcluir.Visible = true;
            txtQtd.Enabled = true;
        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            estoque.Cod = txtCod.Text;
            NomesText();
            ctrEstoque.Update(estoque);
            txtQtd.Enabled = false;
            pFormulario.Visible = false;

            btnAlterar.Visible = false;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Visible = false;

            Clear();
            DataGridAlimentos();
            DataGridEquipamentos();
            DataGridLavanderia();
            DataGridDiveros();
        }

        private void btnExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Tem certeza?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                estoque.Cod = txtCod.Text;
                ctrEstoque.Delete(estoque);
                txtQtd.Enabled = false;
                pFormulario.Visible = false;

                btnAlterar.Visible = false;
                btnSalvarAlteracao.Visible = false;
                btnExcluir.Visible = false;

                Clear();
                DataGridAlimentos();
                DataGridEquipamentos();
                DataGridLavanderia();
                DataGridDiveros();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvDiversos.Rows[e.RowIndex];
                txtCod.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtQtd.Text = row.Cells[2].Value.ToString();
                txtTipo.Text = row.Cells[3].Value.ToString();

                GridClick();
            }
            catch { }

        }
    }
}
