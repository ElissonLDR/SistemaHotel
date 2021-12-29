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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }
        DateTime hoje;
        Reserva reserva;
        ctrReserva ctrReserva;
        private void frmReserva_Load(object sender, EventArgs e)
        {
            btnCPF.Checked = true;
            reserva = new Reserva();
            ctrReserva = new ctrReserva();

            dtCheckin.MinDate = DateTime.Today;
            dtCheckout.MinDate = dtCheckin.MinDate;
            hoje = DateTime.Today;

            lbHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            dtQuartos();
            ValorDiaria();
            DataGrid();
            DataGridHospedes();
        }

        public void DataGridHospedes()
        {
            DataTable dataTable = new DataTable();

            daoHospedes daoHospedes = new daoHospedes();

            dataTable = daoHospedes.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvHospedes.DataSource = dataTable;

                dgvHospedes.Columns["Email"].Visible=false;
                dgvHospedes.Columns["CEP"].Visible=false;
                dgvHospedes.Columns["Rua"].Visible=false;
                dgvHospedes.Columns["Bairro"].Visible=false;
                dgvHospedes.Columns["Cidade"].Visible=false;
                dgvHospedes.Columns["Estado"].Visible=false;
                dgvHospedes.Columns["Nascimento"].Visible=false;
            }
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }
        public void CalculoDiaria()
        {
            txtCheckin.Text = dtCheckin.Value.ToString().Substring(0,10);
            txtCheckout.Text = dtCheckout.Value.ToString().Substring(0,10);
            var checkin = new DateTime();
            var checkout = new DateTime();

            if(!DateTime.TryParse(txtCheckin.Text, out checkin))
            {
                MessageBox.Show("Data errada de inicio.");
            }
            else if(!DateTime.TryParse(txtCheckout.Text, out checkout))
            {
                MessageBox.Show("Data errada de fim.");
            }
            else
            {
                txtDiarias.Text = (checkout - checkin).ToString().Substring(0,3);
                double vd = Convert.ToDouble(txtValorDiaria.Text);
                double d = Convert.ToDouble(txtDiarias.Text.Substring(0, 2));
                double vt;
                vt = vd * d;
                txtValorTotal.Text = Convert.ToDouble(vt.ToString()).ToString("C2");
                txtValorTotal.Text = txtValorTotal.Text.Replace("R$", "").Trim();
            }
        }


        private void dtCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtCheckout.Enabled = true;
            int res = DateTime.Compare(dtCheckin.Value, hoje);
            if (res < 0)
            {
                MessageBox.Show("Data não pode ser menor que a de hoje.");
            }
            dtCheckout.MinDate = dtCheckin.Value;
        }

        private void dtCheckout_ValueChanged(object sender, EventArgs e)
        {            
            int res = DateTime.Compare(dtCheckout.Value, dtCheckin.Value);
            if (res < 0)
            {
                MessageBox.Show("Data não pode ser menor que a de entrada (Check in).");
            }
            txtEntrada.Text = "";
            txtEntrada.Enabled = true;
            CalculoDiaria();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtEntrada);
            if (string.IsNullOrWhiteSpace(txtEntrada.Text))
            {
                txtEntrada.Text = "0";
            }

            txtValorTotal.Text = txtValorTotal.Text.Replace("R$", "").Trim();

            double vtotal = Convert.ToDouble(txtValorTotal.Text);
            double entrada = Convert.ToDouble(txtEntrada.Text);
            double vfinal;
            vfinal = vtotal - entrada;
            if (vfinal < 0)
            {
                MessageBox.Show("Não é possível dar entrada maior que o valor total.");
                txtEntrada.Text = "0";
                vfinal = vtotal;
            }
            Valorfinal.Visible = true;
            txtValorFinal.Visible = true;
            txtValorFinal.Text = Double.Parse(vfinal.ToString()).ToString("C2");
        }
        public void CalculoValor()
        {
            double vtotal = Convert.ToDouble(txtValorTotal.Text);
            double entrada = Convert.ToDouble(txtEntrada.Text);
            double vfinal;
            vfinal = vtotal - entrada;
            txtValorFinal.Text = Double.Parse(vfinal.ToString()).ToString("C2");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                MessageBox.Show("Digite um CPF para pesquisar!");
            }
            else
            {
                reserva.CPF = txtCPF.Text;
                ctrReserva.ReadReserva(reserva);                

                if (reserva.CPF == "")
                {
                    reserva.CPF = txtCPF.Text;
                    ctrReserva.ReadCPF(reserva);

                    if (reserva.CPFHospede == "")
                    {

                    }
                    else
                    {
                        VerificaDispCheckin();
                        pFormulario.Visible = true;                        
                        DatagridQuarto();
                        txtCod.Enabled = true;
                        btnSalvar.Visible = true;
                        btnSalvarAlteracao.Visible = false;
                        btnAlterar.Visible = false;

                        MostrarForm();
                        txtEntrada.Clear();

                        txtValorDiaria.Text = txtValorDiaria.Text.Replace("R$", "").Trim();

                        btnSalvar.Visible = true;
                        btnSalvarAlteracao.Visible = false;
                        btnExcluir.Visible = false;
                        btnAlterar.Visible = false;

                    }
                }
                else
                {
                    MessageBox.Show("Este CPF tem uma reserva ativa.");
                    btnSalvar.Visible = false;
                    btnAlterar.Visible = true;
                    btnExcluir.Visible=false;
                }
            }
        }        

        public void dtQuartos()
        {

            try
            {
                DataTable dataTable = new DataTable();

                daoReserva daoReserva = new daoReserva();

                dataTable = daoReserva.Quartos();

                if (dataTable.Rows.Count > 0)
                {
                    txtCod.DataSource = dataTable;
                    txtCod.DisplayMember = "Codigo";                    
                }
            }
            catch
            {
                txtCod.DataSource = null;
            }
            finally
            {

            }
        }

        private void btnDetailsQuarto_Click_1(object sender, EventArgs e)
        {
            frmDetalhesQuarto detalhesQuarto = new frmDetalhesQuarto(txtCod.Text);
            detalhesQuarto.ShowDialog();            
        }

        public void MostrarForm()
        {
            btnDetailsQuarto.Visible = true;
            Codigo.Visible = true;
            txtCod.Visible = true;
            Checkin.Visible = true;
            dtCheckin.Visible = true;
            dtCheckout.Visible = true;
            Checkout.Visible = true;
            Quantidadedediarias.Visible = true;
            txtDiarias.Visible = true;
            Valortotal.Visible = true;
            txtValorTotal.Visible = true;
            Entrada.Visible = true;
            txtEntrada.Visible = true;
            txtValorDiaria.Visible = true;
            btnSalvar.Visible = true;
        }

        private void txtCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValorDiaria();
            DatagridQuarto();
            VerificaDispCheckin();
            txtEntrada.Text = "";
        }
        public void DatagridQuarto()
        {
            DataTable dtQuartos = new DataTable();

            daoReserva daoReserva = new daoReserva();

            dtQuartos = daoReserva.dtQuartos(reserva);

            if (dtQuartos.Rows.Count > 0)
            {
                dgvQuartos.DataSource = dtQuartos;
                pQuartos.Visible = true;
            }
            else
            {
                dgvQuartos.DataSource = null;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CalculoDiaria();
            

            if (txtEntrada.Text == "") 
            { 
                txtEntrada.Text = "0";
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtCPF.Text))
                {
                    MessageBox.Show("Digite um CPF para realizar a reserva.");
                }
                else
                {
                    CalculoValor();
                    NomesText();
                    ctrReserva.Create(reserva);
                    DataGrid();
                    reserva.Situacao = "Ocupado";
                    ctrReserva.UpdateQuarto(reserva);
                    pFormulario.Visible = false;
                    txtCPF.Clear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Opa, existe algum dado errado no formulário.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

            }            
        }
        public void ValorDiaria()
        {
            reserva.Quarto = txtCod.Text;
            ctrReserva.ReadQuarto(reserva);
            txtValorDiaria.Text = reserva.Diaria;            
        }

        public void NomesText()
        {
            
            reserva.CPF = txtCPF.Text;
            reserva.Quarto = txtCod.Text;
            reserva.ValorDiaria = txtValorDiaria.Text;
            reserva.Checkin = dtCheckin.Text;
            reserva.Checkout = dtCheckout.Text;
            reserva.Diarias = txtDiarias.Text;
            reserva.ValorTotal = txtValorTotal.Text;
            reserva.Entrada = txtEntrada.Text;
            reserva.ValorFinal = txtValorFinal.Text;
            reserva.situacaoCheckin = "Nao";
            reserva.situacaoCheckout = "Nao";
        }
        public void MostraText()
        {
            txtCPF.Visible = true;
            txtCod.Visible = true;
            txtValorDiaria.Visible = true;
            dtCheckin.Visible = true;
            dtCheckout.Visible = true;
            txtDiarias.Visible = true;
            txtValorTotal.Visible = true;
            txtEntrada.Visible = true;
            txtValorFinal.Visible = true;


            txtCPF.Text = reserva.CPF;
            txtCod.Text = reserva.Quarto;
            txtValorDiaria.Text= reserva.ValorDiaria;
            dtCheckin.Text = reserva.Checkin;
            dtCheckout.Text= reserva.Checkout;
            txtDiarias.Text= reserva.Diarias;
            txtValorTotal.Text= reserva.ValorTotal;
            txtEntrada.Text= reserva.Entrada;
            txtValorFinal.Text = reserva.ValorFinal;
        }
        public void EditaText()
        {
            txtCod.Enabled = true;
            dtCheckin.Visible = true;
            dtCheckout.Visible = true;
        }


        public void DataGrid()
        {
            DataTable dataTable = new DataTable();

            daoReserva daoReserva = new daoReserva();

            dataTable = daoReserva.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvReservas.DataSource = dataTable;
            }
            else
            {
                dgvReservas.DataSource = null;
            }
        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            reserva.CPF = txtCPF.Text;
            NomesText();

            ctrReserva.Update(reserva);
            
            pFormulario.Visible = false;
            txtCPF.Clear();

            DataGrid();
        }

        public void DatagridClick()
        {
            txtCod.Text = reserva.Codigo;
            txtValorDiaria.Text = reserva.ValorDiaria;
            dtCheckin.Text = reserva.Checkin;
            dtCheckin.Enabled = false;            
            dtCheckout.Text = reserva.Checkout;
            dtCheckout.Enabled = false;
            txtDiarias.Text = reserva.Diarias;
            txtValorTotal.Text = reserva.ValorTotal;
            txtEntrada.Text = reserva.Entrada;
            txtEntrada.Enabled = false;
            txtValorFinal.Text = reserva.ValorFinal;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MostrarForm();
            txtEntrada.Clear();
            txtValorDiaria.Text = txtValorDiaria.Text.Replace("R$", "").Trim();
            btnSalvarAlteracao.Visible = true;
            btnExcluir.Visible = true;
            btnAlterar.Visible = false;
            btnSalvar.Visible = false;
        }

        public void VerificaDispCheckin()
        {
            reserva.Quarto = txtCod.Text;
            ctrReserva.ReadQuarto(reserva);           

            if (reserva.Situacao == "Ocupado")
            {
                MessageBox.Show("Verifique se a data a ser selecionada já está reservada.\nReservas feitas na lista ao lado.");
                
            }

        }
        private void btnExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar esta reserva?", "Cancelamento de Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NomesText();
                reserva.Situacao = "Disponivel";
                ctrReserva.UpdateQuarto(reserva);

                reserva.CPF = txtCPF.Text;
                ctrReserva.Delete(reserva);
                DataGrid();
                pFormulario.Visible = false;
                txtCPF.Clear(); 
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "000 000 000 - 00";
        }

        private void btnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "00 000 000/0000-00";
        }

        private void dgvReservas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCPF.Mask = "";

            try
            {
                DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                txtCPF.Text = row.Cells[0].Value.ToString();
                tCod.Text = row.Cells[1].Value.ToString();
                txtValorDiaria.Text = row.Cells[2].Value.ToString();
                txtCheckin.Text = row.Cells[3].Value.ToString();
                txtCheckout.Text = row.Cells[4].Value.ToString();
                txtDiarias.Text = row.Cells[5].Value.ToString();
                txtValorTotal.Text = row.Cells[6].Value.ToString();
                tEntrada.Text = row.Cells[7].Value.ToString();
                txtValorFinal.Text = row.Cells[8].Value.ToString();

                txtValorDiaria.Text = Double.Parse(txtValorDiaria.Text).ToString("C2");
                txtValorTotal.Text = Double.Parse(txtValorTotal.Text).ToString("C2");
                tEntrada.Text = Double.Parse(tEntrada.Text).ToString("C2");

                txtCPF.Visible = true;
                tCod.Visible = true;
                txtValorDiaria.Visible = true;
                txtCheckin.Visible = true;
                txtCheckout.Visible = true;
                txtDiarias.Visible = true;
                txtValorTotal.Visible = true;
                tEntrada.Visible = true;
                txtValorFinal.Visible = true;

                dtCheckin.Visible = false;
                dtCheckout.Visible = false;
                txtEntrada.Visible = false;
                txtCod.Visible = false;

                pFormCPF.Visible = true;
                pFormulario.Visible = true;

                btnAlterar.Visible = true;
                btnSalvar.Visible = false;
                btnSalvarAlteracao.Visible = false;
                btnExcluir.Visible = false;

                
            }
            catch
            {

            }
        }

        private void dgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                txtCPF.Text = row.Cells[0].Value.ToString();
            }
            catch
            {

            }
            
        }
    }
}
