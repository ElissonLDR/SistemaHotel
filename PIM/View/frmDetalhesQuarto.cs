using PIM.CTR;
using PIM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.View
{
    public partial class frmDetalhesQuarto : Form
    {
        public frmDetalhesQuarto(String codigo)
        {
            InitializeComponent();
            txtCod.Text = codigo;
        }
        Reserva reserva;
        ctrReserva ctrReserva;
        frmReserva frmReserva;
        private void DetalhesQuarto_Load(object sender, EventArgs e)
        {
            reserva = new Reserva();
            frmReserva = new frmReserva();
            ctrReserva = new ctrReserva();
            reserva.Quarto = txtCod.Text;
            ctrReserva.ReadQuarto(reserva);

            txtCod.Text = reserva.Quarto;
            txtNum.Text = reserva.Numero;
            txtDiaria.Text = reserva.Diaria;
            txtAndar.Text = reserva.Andar;
            txtPredio.Text = reserva.Predio;
            txtTipo.Text = reserva.Tipo;
            txtDescricao.Text = reserva.Descricao;
            MemoryStream memoryStream1 = new MemoryStream(reserva.Img1);
            pn1.BackgroundImage = Image.FromStream(memoryStream1);
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
