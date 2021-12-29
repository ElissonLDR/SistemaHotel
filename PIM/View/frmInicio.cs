using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.DAO;

namespace PIM.View
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            DataGridReservasHoje();
            DataGridReservas();
            DataGridHospedes();
            DataGridQuartos();
            lbHorario.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public void DataGridQuartos()
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
                dgvQuartos.Columns["Situacao"].Visible = false;
                dgvQuartos.Columns["Img1"].Visible = false;
                dgvQuartos.Columns["Descricao"].Visible = false;
            }
        }
        public void DataGridHospedes()
        {
            DataTable dataTable = new DataTable();

            daoHospedes daoHospedes = new daoHospedes();

            dataTable = daoHospedes.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvHospedes.DataSource = dataTable;

                dgvHospedes.Columns["CEP"].Visible = false;
                dgvHospedes.Columns["Rua"].Visible = false;
                dgvHospedes.Columns["Bairro"].Visible = false;
                dgvHospedes.Columns["Cidade"].Visible = false;
                dgvHospedes.Columns["Estado"].Visible = false;
                dgvHospedes.Columns["Nascimento"].Visible = false;
            }
        }
        public void DataGridReservas()
        {
            DataTable dataTable = new DataTable();

            daoReserva daoReserva = new daoReserva();

            dataTable = daoReserva.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvReservas.DataSource = dataTable;

                dgvReservas.Columns["Diarias"].Visible = false;
                dgvReservas.Columns["ValorTotal"].Visible = false;
                dgvReservas.Columns["Entrada"].Visible = false;
                dgvReservas.Columns["ValorFinal"].Visible = false;
            }
        }
        public void DataGridReservasHoje()
        {
            DataTable dataTable = new DataTable();
            daoCheckin daoCheckin = new daoCheckin();

            dataTable = daoCheckin.DataGrid();

            if (dataTable.Rows.Count > 0)
            {
                dgvReservasHoje.DataSource = dataTable;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHorario.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
