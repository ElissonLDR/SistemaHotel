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
    public partial class frmAdicionais : Form
    {
        public frmAdicionais()
        {
            InitializeComponent();
        }
        ctrAdicionais ctrAdicionais;
        Adicionais adicionais;
        private void frmAdicionais_Load(object sender, EventArgs e)
        {
            ctrAdicionais = new ctrAdicionais();
            adicionais = new Adicionais();
            DataGrid();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtPreco.Enabled = true;
            Clear();
            btnSalvar.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnSalvarAlteracao.Visible = false;
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = String.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch { }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha os dados corretamente!");
            }
            else
            {
                NomesText();
                ctrAdicionais.Create(adicionais);
                DataGrid();
                Disable();
            }
        }

        public void NomesText()
        {
            adicionais.Nome = txtNome.Text;
            adicionais.Preco = txtPreco.Text;
        }

        public void DataGrid()
        {
            DataTable dataTable = new DataTable();

            daoAdicionais daoAdicionais = new daoAdicionais();

            dataTable = daoAdicionais.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvAdicionais.DataSource = dataTable;
            }
            else
            {
                dgvAdicionais.DataSource = null;
            }
        }

        private void dgvAdicionais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvAdicionais.Rows[e.RowIndex];
                txtCod.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtPreco.Text = row.Cells[2].Value.ToString();

                Disable();
                GridClick();
            }
            catch
            {

            }
        }

        public void GridClick()
        {
            btnSalvar.Visible = false;
            btnAlterar.Visible = true;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtPreco.Enabled = true;
            btnSalvarAlteracao.Visible = true;
            btnSalvar.Visible = false;
            btnAlterar.Visible = false;
            btnExcluir.Visible = true;
        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            adicionais.Cod = txtCod.Text;
            NomesText();
            ctrAdicionais.Update(adicionais);

            btnSalvar.Visible = false;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Visible = false;
            btnAlterar.Visible = false;

            Clear();
            Disable();
            DataGrid();
        }

        public void Clear()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtCod.Text = "";
        }
        
        public void Disable()
        {
            txtNome.Enabled = false;
            txtPreco.Enabled = false;
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPreco);
        }

        private void btnExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                adicionais.Cod = txtCod.Text;
                ctrAdicionais.Delete(adicionais);

                btnAlterar.Visible = false;
                btnSalvarAlteracao.Visible = false;
                btnExcluir.Visible = false;

                Clear();
                Disable();
                DataGrid();
            }
        }
    }
    
}
