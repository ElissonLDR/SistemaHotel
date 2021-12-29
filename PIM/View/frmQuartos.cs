using PIM.CTR;
using PIM.Model;
using PIM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.View
{
    public partial class frmQuartos : Form
    {
        Quartos quartos;
        ctrQuartos ctrQuartos;
        MemoryStream memory;
        public frmQuartos()
        {
            InitializeComponent();
        }
        private void frmQuartos_Load(object sender, EventArgs e)
        {
            quartos = new Quartos();
            ctrQuartos = new ctrQuartos();
            memory = new MemoryStream();
            DataGrid();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            pFormulario.Visible = true;
            btnSalvar.Visible = true;
            btnSalvar.Enabled= false;
            txtNum.Enabled = true;
            cmbAndar.Enabled = true;
            cmbPredio.Enabled = true;
            btnSalvar.Visible = true;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Visible = false;
            msgInsira.Visible = true;
            pInfo.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            txtCod.Visible = true;
            txtCod.Text = cmbPredio.Text + cmbAndar.Text + txtNum.Text;

            quartos.Buscar = txtCod.Text;
            ctrQuartos.ReadCodigo(quartos);

            if (quartos.Codigo == "")
            {
                try
                {

                    if ((string.IsNullOrWhiteSpace(cmbTipo.Text)) || (string.IsNullOrWhiteSpace(cmbSituacao.Text)))
                    {
                        MessageBox.Show("Preencha as informações corretamente.\n -Tipo de quarto.\n -Situação do quarto.\n " +
                            "Descrição é opcional.\n É necessário colocar uma imagem para inserir no banco de dados.");
                    }
                    else
                    {
                        NomesText();
                        txtCod.Visible = true;
                        ctrQuartos.Create(quartos);
                        DataGrid();
                        pFormulario.Visible = false;
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
            else
            {
                MessageBox.Show("Esse codigo de quarto já existe.");
                btnAlterar.Enabled = true;
                btnSalvarAlteracao.Enabled = true;
                btnExcluir.Enabled = true;
            }            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNum.Enabled = false;
            cmbAndar.Enabled = false;
            cmbPredio.Enabled = false;
            TextBoxClear();
            ctrQuartos.Read(quartos);
            quartos.Buscar = lbCod.Text;

            if(quartos.Codigo == "")
            {

            }
            else
            {
                pFormulario.Visible = true;
                btnSalvar.Visible = false;
                btnSalvarAlteracao.Visible = true;
                btnExcluir.Visible = true;
                msgInsira.Visible = false;
                RecebeText();
            }
            
        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            txtDiaria.Text = Double.Parse(txtDiaria.Text).ToString("C2");
            txtDiaria.Text = txtDiaria.Text.Replace("R$", "").Trim();
                        
            quartos.Diaria = txtDiaria.Text;
            quartos.Tipo = cmbTipo.Text;
            quartos.Descricao = txtDescricao.Text;
            quartos.Situacao = cmbSituacao.Text;
            MemoryStream memoryStream1 = new MemoryStream(quartos.Img1);
            pn1.BackgroundImage = Image.FromStream(memoryStream1);

            ctrQuartos.Update(quartos);
            pFormulario.Visible = false;
            pInfo.Visible = false;
            DataGrid();
        }

        private void btnExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Exclusão de quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctrQuartos.Delete(quartos);
                pInfo.Visible = false;
                pFormulario.Visible = false;
                DataGrid();
            }            
        }        
        public void NomesText()
        {
            txtCod.Text = cmbPredio.Text + cmbAndar.Text + txtNum.Text;
            quartos.Codigo = txtCod.Text;
            quartos.Numero = txtNum.Text;
            quartos.Diaria = txtDiaria.Text;
            quartos.Andar = cmbAndar.Text;
            quartos.Predio = cmbPredio.Text;
            quartos.Tipo = cmbTipo.Text;
            quartos.Descricao = txtDescricao.Text;
            quartos.Situacao = cmbSituacao.Text;
            MemoryStream memoryStream1 = new MemoryStream(quartos.Img1);
            pn1.BackgroundImage = Image.FromStream(memoryStream1);
        }
       
        private void Close1_Click_1(object sender, EventArgs e)
        {
            pn1.BackgroundImage = null;
        }
        public void DataGrid()
        {
            try
            {
                DataTable dataTable = new DataTable();

                daoQuartos daoQuartos = new daoQuartos();

                dataTable = daoQuartos.DataGrid();

                if (dataTable.Rows.Count > 0)
                {
                    dgvQuartos.DataSource = dataTable;

                    dgvQuartos.Columns["Num"].Visible = false;
                    dgvQuartos.Columns["Andar"].Visible = false;
                    dgvQuartos.Columns["Predio"].Visible = false;
                    dgvQuartos.Columns["Img1"].Visible = false;
                    dgvQuartos.Columns["Descricao"].Visible = false;
                    dgvQuartos.Columns["Situacao"].Visible = false;
                }
                else
                {
                    dgvQuartos.DataSource =null;
                }
            }
            catch
            {
                dgvQuartos.DataSource = null;
            }
            finally
            {

            }            
            
        }

        private void dgvQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAlterar.Visible = true;
                pInfo.Visible = true;
                MostraLabel();
                DataGridViewRow row = dgvQuartos.Rows[e.RowIndex];
                lbCod.Text = row.Cells[0].Value.ToString();

                quartos.Buscar = lbCod.Text;
                ctrQuartos.Read(quartos);
                lbNum.Text = quartos.Numero;
                lbDiaria.Text = quartos.Diaria;
                lbAndar.Text = quartos.Andar;
                lbPredio.Text = quartos.Predio;
                lbTipo.Text = quartos.Tipo;
                lbDescricao.Text = quartos.Descricao;
                lbDescricao.ForeColor = Color.Black;
                lbDescricao.BackColor = Color.PaleTurquoise;
                lbSituacao.Text = quartos.Situacao;
                MemoryStream memoryStream1 = new MemoryStream(quartos.Img1);
                pn2.BackgroundImage = Image.FromStream(memoryStream1);

                lbDiaria.Text = Double.Parse(lbDiaria.Text).ToString("C2");
            }
            catch
            {

            }
            
        }

        public void RecebeLabel()
        {
            lbNum.Text = quartos.Numero;
            lbDiaria.Text = quartos.Diaria;
            lbAndar.Text = quartos.Andar;
            lbPredio.Text = quartos.Predio;
            lbTipo.Text = quartos.Tipo;
            lbDescricao.Text = quartos.Descricao;
            lbSituacao.Text = quartos.Situacao;
            MemoryStream memoryStream1 = new MemoryStream(quartos.Img1);
            pn1.BackgroundImage = Image.FromStream(memoryStream1);
        }
        public void RecebeText()
        {
            
            txtCod.Text = quartos.Codigo;
            txtNum.Text = quartos.Numero;
            txtDiaria.Text = quartos.Diaria;
            cmbAndar.Text = quartos.Andar;
            cmbPredio.Text = quartos.Predio;
            cmbTipo.Text = quartos.Tipo;
            txtDescricao.Text = quartos.Descricao;
            cmbSituacao.Text = quartos.Situacao;
            MemoryStream memoryStream1 = new MemoryStream(quartos.Img1);
            pn1.BackgroundImage = Image.FromStream(memoryStream1);
        }
        public void TextBoxClear()
        {
            txtNum.Clear();
            txtDiaria.Clear();
            cmbAndar.Text = "";
            cmbPredio.Text = "";
            cmbTipo.Text = "";
            txtDescricao.Clear();
            cmbSituacao.Text="";
            txtCod.Text = "---";
            pn1.BackgroundImage = null;
        }
        public void EscondeTexts()
        {
            txtCod.Enabled = false;
            txtNum.Enabled = false;
            txtDiaria.Enabled = false;
            cmbAndar.Enabled = false;
            cmbPredio.Enabled = false;
            cmbTipo.Enabled = false;
            txtDescricao.Enabled = false;
            cmbSituacao.Enabled = false;
        }
        public void MostraTexts()
        {
            txtCod.Visible = true;
            txtNum.Visible = true;
            txtDiaria.Visible = true;
            cmbAndar.Visible = true;
            cmbPredio.Visible = true;
            cmbTipo.Visible = true;
            txtDescricao.Visible = true;
            cmbSituacao.Visible = true;
        }
        public void MostraLabel()
        {
            txtCod.Visible = true;
            lbNum.Visible = true;
            lbDiaria.Visible = true;
            lbAndar.Visible = true;
            lbPredio.Visible = true;
            lbTipo.Visible = true;
            lbDescricao.Visible = true;
            lbSituacao.Visible = true;
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIMG.Enabled = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            pn1.BackgroundImage = null;
            msgInsira.Visible = true;
        }

        private void txtDiaria_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtDiaria);
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

        private void btnIMG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDiaria.Text = Double.Parse(txtDiaria.Text).ToString("C2");
            txtDiaria.Text = txtDiaria.Text.Replace("R$", "").Trim();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;
                Bitmap bmp1 = new Bitmap(nome);
                pn1.BackgroundImage = bmp1;
                bmp1.Save(memory, ImageFormat.Bmp);
                quartos.Img1 = memory.ToArray();
                btnSalvar.Enabled = true;
                msgInsira.Visible = false;
            }
        }
    }

}
