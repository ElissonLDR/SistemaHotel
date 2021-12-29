using PIM.CTR;
using PIM.DAO;
using PIM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.View
{
    public partial class frmCheckin : Form
    {
        public frmCheckin()
        {
            InitializeComponent();
        }
        Reserva reserva = new Reserva();
        Checkin checkin = new Checkin();
        ctrCheckin ctrCheckin = new ctrCheckin();
        ctrReserva ctrReserva = new ctrReserva();
        double vr;
        double v;
        double vt;


        private void frmCheckin_Load(object sender, EventArgs e)
        {
            txtParcela.SelectedIndex = 0;
            btnCPF.Checked = true;
            DataGrid();
            lbHora.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        public void DataGrid()
        {
            DataTable dataTable = new DataTable();
            daoCheckin daoCheckin = new daoCheckin();

            dataTable = daoCheckin.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvReservas.DataSource = dataTable;
            }
            else
            {
                dgvReservas.DataSource = null;
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValor);

            formRecibo.Visible = true;
            btnCredito.Visible = true;
            btnDebito.Visible = true;
            btnDinheiro.Visible = true;

            lbValorTotal.Text = txtValorFinal.Text;

            txtValorReserva.Text = txtValorReserva.Text.Replace("R$", "").Trim();
            txtValor.Text = txtValor.Text.Replace("R$", "").Trim();

            vr = Convert.ToDouble(txtValorReserva.Text);
            v = Convert.ToDouble(txtValor.Text);

            if (v > vr)
            {
                MessageBox.Show("Não é possível pagar um valor maior que o valor final.");
            }
            else
            {
                vt = vr - v;
            }


            if (vr == 0)
            {
                btnSalvar.Visible = true;
                btnCredito.Visible=false;
                btnDebito.Visible=false;
                btnDinheiro.Visible=false;
            }

            txtTotal.Text = Convert.ToDouble(vt.ToString()).ToString("C2");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            reserva.CPF = txtCPF.Text;
            ctrReserva.ReadReserva(reserva);
            if(reserva.situacaoCheckin == "Nao")
            {
                txtSituacaoCheckin.Text = reserva.situacaoCheckin;
                MostraText();
                pFormulario.Visible = true;
                VerificaData();
            }
            else
            {
                MessageBox.Show("Verifique se o CPF está cadastrado ou se já realizou uma reserva.");
            }

        }

        public void VerificaData()
        {
            try
            {
                DateTime chegada = DateTime.ParseExact(txtCheckin.Text, "dd/MM/yyyy", null);
                DateTime saida = DateTime.ParseExact(txtCheckout.Text, "dd/MM/yyyy", null);

                if(chegada != DateTime.Today.Date)
                {
                    txtCheckin.BackColor = Color.Coral;
                    MessageBox.Show("Essa reserva não está disponível para realizar checkin.");
                    pPagamento.Visible = false;
                }
                else
                {
                    txtCheckin.BackColor = Color.Transparent;
                    pPagamento.Visible = true;
                    txtTotal.Text = txtValorReserva.Text;
                }
            }
            catch { }           

        }
        public void MostraText()
        {
            txtCPF.Text = reserva.CPF;
            txtCod.Text = reserva.Quarto;
            txtValorDiaria.Text = reserva.ValorDiaria;
            txtCheckin.Text = reserva.Checkin;
            txtCheckout.Text = reserva.Checkout;
            txtDiarias.Text = reserva.Diarias;
            txtValorTotal.Text = reserva.ValorTotal;
            txtEntrada.Text = reserva.Entrada;
            txtValorFinal.Text = reserva.ValorFinal;
            txtValorReserva.Text = reserva.ValorFinal;
            txtSituacaoCheckin.Text = reserva.situacaoCheckin;

            txtValorReserva.Text = txtValorReserva.Text.Replace("R$", "").Trim();
            
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
                n=n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = String.Format("{0:N}", v);
                txt.SelectionStart=txt.Text.Length;

            }
            catch { }
        }
        private void btnCredito_Click(object sender, EventArgs e)
        {
            p1.Visible = true;

            if (txtParcela.Text == "")
            {
                txtParcela.Text = "1";
            }
            double p = Convert.ToDouble(txtParcela.Text);
            double v = Convert.ToDouble(txtValor.Text);
            double vt;
            vt = v/p;

            string valorparcelado = Convert.ToDouble(vt.ToString()).ToString("C2");
            string valor = Convert.ToDouble(v.ToString()).ToString("C2");

            if (MessageBox.Show("Confirme o valor " + valor + " divido em " + p + " vezes. " +
                "\n\nParcela de " + valorparcelado, "Confirmação de cartão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtTotal.Text = txtTotal.Text.Replace("R$", "").Trim();

                txtValorReserva.Text = txtTotal.Text;
                txtValor.Text = txtValorReserva.Text;

                dgvPag.Rows.Add("Crédito", valor, p, valorparcelado);
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            p1.Visible = true;
            double d = Convert.ToDouble(txtValor.Text);
            string valor = Convert.ToDouble(d.ToString()).ToString("C2");

            if(MessageBox.Show("Confirme o valor " + valor + " pago no débito.", "Confirmação de cartão", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                txtValorReserva.Text = txtTotal.Text;
                txtValor.Text = txtValorReserva.Text;

                dgvPag.Rows.Add("Débito", valor, 1, valor);
            }
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            p1.Visible = true;
            double d = Convert.ToDouble(txtValor.Text);
            string valor = Convert.ToDouble(d.ToString()).ToString("C2");
            if (MessageBox.Show("Confirme o valor " + valor + " pago em dinheiro.", "Confirmação de cartão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                txtValorReserva.Text = txtTotal.Text;
                txtValor.Text = txtValorReserva.Text;


                dgvPag.Rows.Add("Dinheiro", valor, 1, valor);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            checkin.CPF = txtCPF.Text;
            checkin.situacaoCheckin = "Realizada";

            ctrCheckin.UpdateCheckin(checkin);
            Clear();
            btnSalvar.Visible = false;
            pPagamento.Visible = false;
            formRecibo.Visible = false;
            DataGrid();
        }
        public void Clear()
        {
            txtCPF.Clear();
            txtValor.Clear();
            dgvPag.Rows.Clear();
            txtTotal.Text = "R$";
            txtValorReserva.Text = "R$";
        }

        private void btnCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "000 000 000 - 00";
        }

        private void btnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "00 000 000/0000-00";
        }

        
    }
}
