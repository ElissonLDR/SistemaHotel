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
    public partial class frmFechamento : Form
    {
        public frmFechamento()
        {
            InitializeComponent();
        }
        Reserva reserva;
        Checkin checkin;
        ctrCheckin ctrCheckin;
        ctrReserva ctrReserva;
        Fechamento fechamento;
        ctrFechamento ctrFechamento;
        double va = 1;
        double qt = 1;
        double vaf;
        double vt;

        private void frmFechamento_Load(object sender, EventArgs e)
        {
            btnCPF.Checked = true;
            reserva = new Reserva();
            checkin = new Checkin();
            ctrCheckin = new ctrCheckin();
            ctrReserva = new ctrReserva();
            fechamento = new Fechamento();
            ctrFechamento = new ctrFechamento();
            txtParcela.SelectedIndex = 0;
            DataGridAdicionais();
            ValorAdicional();
            DataGrid();
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

        public void ValorAdicional()
        {
            fechamento.Nome = txtItem.Text;
            ctrFechamento.ReadAdicional(fechamento);
            txtPreco.Text = fechamento.Preco;
        }
        
        public void MostraText()
        {
            txtCPF.Text = reserva.CPF;
            txtCod.Text = reserva.Quarto;
            txtValorDiaria.Text = reserva.ValorDiaria;
            txtCheckin.Text = reserva.Checkin;
            txtCheckout.Text = reserva.Checkout;
            txtDiarias.Text = reserva.Diarias;
            txtValorPago.Text = reserva.ValorTotal;
            txtSituacaoCheckin.Text = reserva.situacaoCheckin;

        }

        public void DataGridAdicionais()
        {

            try
            {
                DataTable dataTable = new DataTable();

                daoFechamento daoFechamento = new daoFechamento();

                dataTable = daoFechamento.Adicionais();

                if (dataTable.Rows.Count > 0)
                {
                    txtItem.DataSource = dataTable;
                    txtItem.DisplayMember = "Nome";
                }
            }
            catch
            {
                txtItem.DataSource = null;
            }
            finally
            {

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtItem.Enabled = true;
            txtQtd.Enabled = true;
            ValorAdicional();
            dgvItens.Visible = true;
            pDGV.Visible = true;
            btnIncluir.Enabled = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtItem.Enabled = false;
            txtQtd.Enabled = false;

            btnIncluir.Enabled = false;
            dgvItens.Rows.Add(txtItem.Text, txtQtd.Text, txtPreco.Text, txtVtAdicional.Text);

            if (txtValorRestante.Text == "0")
            {
                txtValorRestante.Text = Convert.ToDouble(vaf.ToString()).ToString("C2");
            }
            else
            {
                txtValorRestante.Text = txtValorRestante.Text.Replace("R$", "").Trim();

                double vr = Convert.ToDouble(txtValorRestante.Text);
                vaf = vaf + vr;
                txtValorRestante.Text = Convert.ToDouble(vaf.ToString()).ToString("C2");
                labelValorRestante.Text = Convert.ToDouble(vaf.ToString()).ToString("C2");
            }
            
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            
            btnIncluir.Enabled = true;
            CalculoVtAdicional();
            
        }

        public void CalculoVtAdicional()
        {
            try
            {
                if (txtQtd.Text == "")
                {
                    txtVtAdicional.Text = Convert.ToDouble(txtPreco.Text).ToString("C2");
                }
                else
                {
                    va = Convert.ToDouble(txtPreco.Text);
                    qt = Convert.ToDouble(txtQtd.Text);
                    vaf = va * qt;
                    txtVtAdicional.Text = Convert.ToDouble(vaf.ToString()).ToString("C2");
                }
            }
            catch
            {

            }                                              
        }
        private void txtItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValorAdicional();
            txtQtd.Text = "";
            txtVtAdicional.Text = "";
        }

        private void btnCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "000 000 000 - 00";
        }

        private void btnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Mask = "00 000 000/0000-00";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            checkin.CPF = txtCPF.Text;
            checkin.situacaoCheckout = "Realizada";

            ctrCheckin.UpdateCheckout(checkin);
            DataGrid();
            btnVisualizar.Visible = true;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            btnCredito.Visible = true;
            btnDebito.Visible = true;
            btnDinheiro.Visible = true;
            p1.Visible = true;

            Moeda(ref txtValor);

            txtValorRestante.Text = txtValorRestante.Text.Replace("R$", "").Trim();
            txtValor.Text = txtValor.Text.Replace("R$", "").Trim();

            double vr = Convert.ToDouble(txtValorRestante.Text);
            double v = Convert.ToDouble(txtValor.Text);

            if (v > vr)
            {
                MessageBox.Show("Não é possível pagar um valor maior que o valor final.");
                txtValor.Text = "";
            }
            else
            {
                vt = vr - v;
            }


            if (vr == 0)
            {
                btnSalvar.Visible = true;
                btnCredito.Visible = false;
                btnDebito.Visible = false;
                btnDinheiro.Visible = false;
            }

            txtTotal.Text = Convert.ToDouble(vt.ToString()).ToString("C2");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            reserva.CPF = txtCPF.Text;
            ctrReserva.ReadReserva(reserva);

            if(reserva.situacaoCheckout == "Realizada")
            {
                MessageBox.Show("Essa reserva já realizou o checkout.");
            }else
            {
                if (reserva.situacaoCheckin == "Realizada")
                {
                    MostraText();
                    pFormulario.Visible = true;
                    pTopoFormulario.Visible = true;
                    pAdicionais.Visible = true;
                    pPagamento.Visible = true;
                }
                else
                {
                    MessageBox.Show("Essa reserva não foi feito o checkin.");
                }
            }            
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {

            if(txtParcela.Text == "")
            {
                txtParcela.Text = "1";
            }
            double p = Convert.ToDouble(txtParcela.Text);
            double v = Convert.ToDouble(txtValor.Text);
            double vt;
            vt = v / p;

            string valorparcelado = Convert.ToDouble(vt.ToString()).ToString("C2");
            string valor = Convert.ToDouble(v.ToString()).ToString("C2");

            if (MessageBox.Show("Confirme o valor " + valor + " divido em " + p + " vezes. " +
                "\n\nParcela de " + valorparcelado, "Confirmação de cartão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtTotal.Text = txtTotal.Text.Replace("R$", "").Trim();

                txtValorRestante.Text = txtTotal.Text;
                txtValor.Text = txtValorRestante.Text;

                dgvPag.Rows.Add("Crédito", valor, p, valorparcelado);
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtValor.Text);
            string valor = Convert.ToDouble(d.ToString()).ToString("C2");

            if (MessageBox.Show("Confirme o valor " + valor + " pago no débito.", "Confirmação de cartão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtValorRestante.Text = txtTotal.Text;
                txtValor.Text = txtValorRestante.Text;

                dgvPag.Rows.Add("Débito", valor, 1, valor);
            }
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtValor.Text);
            string valor = Convert.ToDouble(d.ToString()).ToString("C2");
            if (MessageBox.Show("Confirme o valor " + valor + " pago em dinheiro.", "Confirmação de cartão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                txtValorRestante.Text = txtTotal.Text;
                txtValor.Text = txtValorRestante.Text;


                dgvPag.Rows.Add("Dinheiro", valor, 1, valor);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRecibo frmRecibo = new frmRecibo(txtCPF.Text, labelValorRestante.Text, txtValorPago.Text);
            frmRecibo.Show();
        }
    }
}
