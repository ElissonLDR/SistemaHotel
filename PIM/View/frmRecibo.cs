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
    public partial class frmRecibo : Form
    {
        public frmRecibo(String cpf, string vr, string vp)
        {
            InitializeComponent();
            txtCPF.Text = cpf;
            txtConsumo.Text = vr;
            txtTotalReserva.Text = vp;
        }
        ctrReserva ctrReserva;
        Reserva reserva;
        Hospedes hospedes;
        ctrHospedes ctrHospedes;
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRecibo_Load(object sender, EventArgs e)
        {
            reserva = new Reserva();
            hospedes = new Hospedes();
            ctrHospedes = new ctrHospedes();
            ctrReserva = new ctrReserva();


            reserva.CPF = txtCPF.Text;
            hospedes.Buscar = txtCPF.Text;
            ctrReserva.ReadReserva(reserva);
            ctrHospedes.Read(hospedes);

            txtHospede.Text = hospedes.Nome;
            txtQuarto.Text = reserva.Quarto;
            txtCheckin.Text = reserva.Checkin;
            txtCheckout.Text = reserva.Checkout;

        }

        private void Imprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.pRecibo.Width, this.pRecibo.Height);
            pRecibo.DrawToBitmap(objBmp, new Rectangle(0, 0, this.pRecibo.Width, this.pRecibo.Height));

            e.Graphics.DrawImage(objBmp, 200, 100);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = Imprimir;
            printPreviewDialog1.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(pRecibo.Width, pRecibo.Height))
            {
                pRecibo.DrawToBitmap(bmp, new Rectangle(0,0, bmp.Width, bmp.Height));
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "jpg";
                sfd.FileName = "Recibo"+txtHospede.Text+".jpg";
                sfd.Filter = "jpg files (*.jpg)| *.jpg";
                if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bmp.Save(sfd.FileName);
                }
                
            }
        }
    }
}
