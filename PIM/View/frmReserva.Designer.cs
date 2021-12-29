
namespace PIM.View
{
    partial class frmReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pFormCPF = new System.Windows.Forms.Panel();
            this.btnCNPJ = new System.Windows.Forms.RadioButton();
            this.btnCPF = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.Label();
            this.Checkin = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.ComboBox();
            this.Checkout = new System.Windows.Forms.Label();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.Valortotal = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.Label();
            this.Quantidadedediarias = new System.Windows.Forms.Label();
            this.txtDiarias = new System.Windows.Forms.Label();
            this.txtCheckin = new System.Windows.Forms.Label();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCheckout = new System.Windows.Forms.Label();
            this.Valorfinal = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtValorFinal = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.Entrada = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.LinkLabel();
            this.btnDetailsQuarto = new System.Windows.Forms.Button();
            this.Valor = new System.Windows.Forms.Label();
            this.pFormulario = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tEntrada = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tCod = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pDGV = new System.Windows.Forms.Panel();
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pQuartos = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvHospedes = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.pFormCPF.SuspendLayout();
            this.pFormulario.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            this.panel8.SuspendLayout();
            this.pQuartos.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.Azure;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(48, 39);
            this.txtCPF.Mask = "00 000 000/0000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(199, 23);
            this.txtCPF.TabIndex = 64;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservas";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.dgvReservas);
            this.panel2.Location = new System.Drawing.Point(370, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 294);
            this.panel2.TabIndex = 51;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AllowUserToResizeColumns = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReservas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvReservas.Location = new System.Drawing.Point(0, 0);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(724, 294);
            this.dgvReservas.TabIndex = 0;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick_1);
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(924, 9);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(170, 37);
            this.lbHora.TabIndex = 54;
            this.lbHora.Text = "Hora Atual";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pFormCPF
            // 
            this.pFormCPF.BackColor = System.Drawing.Color.LightCyan;
            this.pFormCPF.Controls.Add(this.btnCNPJ);
            this.pFormCPF.Controls.Add(this.btnCPF);
            this.pFormCPF.Controls.Add(this.txtCPF);
            this.pFormCPF.Controls.Add(this.btnBuscar);
            this.pFormCPF.Location = new System.Drawing.Point(12, 103);
            this.pFormCPF.Name = "pFormCPF";
            this.pFormCPF.Size = new System.Drawing.Size(352, 74);
            this.pFormCPF.TabIndex = 72;
            // 
            // btnCNPJ
            // 
            this.btnCNPJ.AutoSize = true;
            this.btnCNPJ.Location = new System.Drawing.Point(117, 12);
            this.btnCNPJ.Name = "btnCNPJ";
            this.btnCNPJ.Size = new System.Drawing.Size(52, 17);
            this.btnCNPJ.TabIndex = 783;
            this.btnCNPJ.TabStop = true;
            this.btnCNPJ.Text = "CNPJ";
            this.btnCNPJ.UseVisualStyleBackColor = true;
            this.btnCNPJ.CheckedChanged += new System.EventHandler(this.btnCNPJ_CheckedChanged);
            // 
            // btnCPF
            // 
            this.btnCPF.AutoSize = true;
            this.btnCPF.Location = new System.Drawing.Point(48, 12);
            this.btnCPF.Name = "btnCPF";
            this.btnCPF.Size = new System.Drawing.Size(45, 17);
            this.btnCPF.TabIndex = 782;
            this.btnCPF.TabStop = true;
            this.btnCPF.Text = "CPF";
            this.btnCPF.UseVisualStyleBackColor = true;
            this.btnCPF.CheckedChanged += new System.EventHandler(this.btnCPF_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::PIM.Properties.Resources.pesquisa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(253, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 23);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(5, 40);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(123, 18);
            this.Codigo.TabIndex = 43;
            this.Codigo.Text = "Codigo do quarto";
            // 
            // Checkin
            // 
            this.Checkin.AutoSize = true;
            this.Checkin.BackColor = System.Drawing.Color.Transparent;
            this.Checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkin.Location = new System.Drawing.Point(15, 32);
            this.Checkin.Name = "Checkin";
            this.Checkin.Size = new System.Drawing.Size(67, 18);
            this.Checkin.TabIndex = 45;
            this.Checkin.Text = "Check-in";
            // 
            // txtCod
            // 
            this.txtCod.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.IntegralHeight = false;
            this.txtCod.Location = new System.Drawing.Point(8, 11);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(73, 26);
            this.txtCod.TabIndex = 46;
            this.txtCod.SelectedIndexChanged += new System.EventHandler(this.txtCod_SelectedIndexChanged);
            // 
            // Checkout
            // 
            this.Checkout.AutoSize = true;
            this.Checkout.BackColor = System.Drawing.Color.Transparent;
            this.Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkout.Location = new System.Drawing.Point(146, 32);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(77, 18);
            this.Checkout.TabIndex = 48;
            this.Checkout.Text = "Check-out";
            // 
            // dtCheckin
            // 
            this.dtCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckin.Location = new System.Drawing.Point(6, 5);
            this.dtCheckin.MinDate = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(97, 26);
            this.dtCheckin.TabIndex = 49;
            this.dtCheckin.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dtCheckin.Visible = false;
            this.dtCheckin.ValueChanged += new System.EventHandler(this.dtCheckin_ValueChanged);
            // 
            // dtCheckout
            // 
            this.dtCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtCheckout.Enabled = false;
            this.dtCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckout.Location = new System.Drawing.Point(136, 5);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(97, 26);
            this.dtCheckout.TabIndex = 50;
            this.dtCheckout.Value = new System.DateTime(2021, 11, 11, 20, 3, 32, 0);
            this.dtCheckout.Visible = false;
            this.dtCheckout.ValueChanged += new System.EventHandler(this.dtCheckout_ValueChanged);
            // 
            // Valortotal
            // 
            this.Valortotal.AutoSize = true;
            this.Valortotal.BackColor = System.Drawing.Color.Transparent;
            this.Valortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valortotal.Location = new System.Drawing.Point(16, 27);
            this.Valortotal.Name = "Valortotal";
            this.Valortotal.Size = new System.Drawing.Size(74, 18);
            this.Valortotal.TabIndex = 53;
            this.Valortotal.Text = "Valor total";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.AutoSize = true;
            this.txtValorDiaria.BackColor = System.Drawing.Color.Transparent;
            this.txtValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtValorDiaria.Location = new System.Drawing.Point(150, 19);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(35, 18);
            this.txtValorDiaria.TabIndex = 56;
            this.txtValorDiaria.Text = "180";
            this.txtValorDiaria.Visible = false;
            // 
            // Quantidadedediarias
            // 
            this.Quantidadedediarias.AutoSize = true;
            this.Quantidadedediarias.BackColor = System.Drawing.Color.Transparent;
            this.Quantidadedediarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidadedediarias.Location = new System.Drawing.Point(15, 23);
            this.Quantidadedediarias.Name = "Quantidadedediarias";
            this.Quantidadedediarias.Size = new System.Drawing.Size(150, 18);
            this.Quantidadedediarias.TabIndex = 57;
            this.Quantidadedediarias.Text = "Quantidade de diárias";
            // 
            // txtDiarias
            // 
            this.txtDiarias.AutoSize = true;
            this.txtDiarias.BackColor = System.Drawing.Color.Transparent;
            this.txtDiarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiarias.Location = new System.Drawing.Point(12, 4);
            this.txtDiarias.Name = "txtDiarias";
            this.txtDiarias.Size = new System.Drawing.Size(16, 18);
            this.txtDiarias.TabIndex = 58;
            this.txtDiarias.Text = "0";
            this.txtDiarias.Visible = false;
            // 
            // txtCheckin
            // 
            this.txtCheckin.AutoSize = true;
            this.txtCheckin.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckin.Location = new System.Drawing.Point(13, 10);
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.Size = new System.Drawing.Size(16, 18);
            this.txtCheckin.TabIndex = 59;
            this.txtCheckin.Text = "0";
            this.txtCheckin.Visible = false;
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlteracao.FlatAppearance.BorderSize = 0;
            this.btnSalvarAlteracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarAlteracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(181, 325);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(134, 31);
            this.btnSalvarAlteracao.TabIndex = 68;
            this.btnSalvarAlteracao.Text = "Salvar Alteração";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracao.Visible = false;
            this.btnSalvarAlteracao.Click += new System.EventHandler(this.btnSalvarAlteracao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(18, 325);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 31);
            this.btnSalvar.TabIndex = 68;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCheckout
            // 
            this.txtCheckout.AutoSize = true;
            this.txtCheckout.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckout.Location = new System.Drawing.Point(150, 10);
            this.txtCheckout.Name = "txtCheckout";
            this.txtCheckout.Size = new System.Drawing.Size(16, 18);
            this.txtCheckout.TabIndex = 60;
            this.txtCheckout.Text = "0";
            this.txtCheckout.Visible = false;
            // 
            // Valorfinal
            // 
            this.Valorfinal.AutoSize = true;
            this.Valorfinal.BackColor = System.Drawing.Color.Transparent;
            this.Valorfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valorfinal.Location = new System.Drawing.Point(48, 81);
            this.Valorfinal.Name = "Valorfinal";
            this.Valorfinal.Size = new System.Drawing.Size(79, 20);
            this.Valorfinal.TabIndex = 62;
            this.Valorfinal.Text = "Valor final";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(18, 362);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(116, 31);
            this.btnAlterar.TabIndex = 72;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.AutoSize = true;
            this.txtValorFinal.BackColor = System.Drawing.Color.Transparent;
            this.txtValorFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinal.Location = new System.Drawing.Point(11, 9);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(154, 31);
            this.txtValorFinal.TabIndex = 63;
            this.txtValorFinal.Text = "R$ 0000,00";
            this.txtValorFinal.Visible = false;
            // 
            // txtEntrada
            // 
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(6, 7);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 19);
            this.txtEntrada.TabIndex = 64;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntrada.Visible = false;
            this.txtEntrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Entrada
            // 
            this.Entrada.AutoSize = true;
            this.Entrada.BackColor = System.Drawing.Color.Transparent;
            this.Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrada.Location = new System.Drawing.Point(17, 27);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(59, 18);
            this.Entrada.TabIndex = 65;
            this.Entrada.Text = "Entrada";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(12, 7);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(17, 18);
            this.txtValorTotal.TabIndex = 67;
            this.txtValorTotal.Text = "0";
            this.txtValorTotal.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ActiveLinkColor = System.Drawing.Color.Blue;
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.LinkColor = System.Drawing.Color.Teal;
            this.btnExcluir.Location = new System.Drawing.Point(198, 371);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 13);
            this.btnExcluir.TabIndex = 73;
            this.btnExcluir.TabStop = true;
            this.btnExcluir.Text = "Cancelar Reserva";
            this.btnExcluir.Visible = false;
            this.btnExcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExcluir_LinkClicked);
            // 
            // btnDetailsQuarto
            // 
            this.btnDetailsQuarto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDetailsQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailsQuarto.FlatAppearance.BorderSize = 0;
            this.btnDetailsQuarto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetailsQuarto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDetailsQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsQuarto.Location = new System.Drawing.Point(87, 14);
            this.btnDetailsQuarto.Name = "btnDetailsQuarto";
            this.btnDetailsQuarto.Size = new System.Drawing.Size(57, 23);
            this.btnDetailsQuarto.TabIndex = 70;
            this.btnDetailsQuarto.Text = "Detalhes";
            this.btnDetailsQuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetailsQuarto.UseVisualStyleBackColor = true;
            this.btnDetailsQuarto.Visible = false;
            this.btnDetailsQuarto.Click += new System.EventHandler(this.btnDetailsQuarto_Click_1);
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.BackColor = System.Drawing.Color.Transparent;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(150, 40);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(42, 18);
            this.Valor.TabIndex = 71;
            this.Valor.Text = "Valor";
            // 
            // pFormulario
            // 
            this.pFormulario.BackColor = System.Drawing.Color.LightCyan;
            this.pFormulario.Controls.Add(this.panel7);
            this.pFormulario.Controls.Add(this.panel6);
            this.pFormulario.Controls.Add(this.panel5);
            this.pFormulario.Controls.Add(this.panel4);
            this.pFormulario.Controls.Add(this.panel3);
            this.pFormulario.Controls.Add(this.panel1);
            this.pFormulario.Controls.Add(this.btnExcluir);
            this.pFormulario.Controls.Add(this.btnAlterar);
            this.pFormulario.Controls.Add(this.btnSalvar);
            this.pFormulario.Controls.Add(this.btnSalvarAlteracao);
            this.pFormulario.Location = new System.Drawing.Point(12, 183);
            this.pFormulario.Name = "pFormulario";
            this.pFormulario.Size = new System.Drawing.Size(352, 408);
            this.pFormulario.TabIndex = 0;
            this.pFormulario.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel7.Controls.Add(this.txtValorTotal);
            this.panel7.Controls.Add(this.Valortotal);
            this.panel7.Location = new System.Drawing.Point(18, 194);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(113, 50);
            this.panel7.TabIndex = 77;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.Controls.Add(this.txtEntrada);
            this.panel6.Controls.Add(this.Entrada);
            this.panel6.Controls.Add(this.tEntrada);
            this.panel6.Location = new System.Drawing.Point(19, 250);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 50);
            this.panel6.TabIndex = 77;
            // 
            // tEntrada
            // 
            this.tEntrada.AutoSize = true;
            this.tEntrada.BackColor = System.Drawing.Color.Transparent;
            this.tEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEntrada.Location = new System.Drawing.Point(15, 8);
            this.tEntrada.Name = "tEntrada";
            this.tEntrada.Size = new System.Drawing.Size(16, 18);
            this.tEntrada.TabIndex = 66;
            this.tEntrada.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.Controls.Add(this.txtValorFinal);
            this.panel5.Controls.Add(this.Valorfinal);
            this.panel5.Location = new System.Drawing.Point(137, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 106);
            this.panel5.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.txtCod);
            this.panel4.Controls.Add(this.Codigo);
            this.panel4.Controls.Add(this.txtValorDiaria);
            this.panel4.Controls.Add(this.btnDetailsQuarto);
            this.panel4.Controls.Add(this.Valor);
            this.panel4.Controls.Add(this.tCod);
            this.panel4.Location = new System.Drawing.Point(19, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 67);
            this.panel4.TabIndex = 76;
            // 
            // tCod
            // 
            this.tCod.AutoSize = true;
            this.tCod.BackColor = System.Drawing.Color.Transparent;
            this.tCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCod.Location = new System.Drawing.Point(15, 15);
            this.tCod.Name = "tCod";
            this.tCod.Size = new System.Drawing.Size(16, 18);
            this.tCod.TabIndex = 72;
            this.tCod.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.txtDiarias);
            this.panel3.Controls.Add(this.Quantidadedediarias);
            this.panel3.Location = new System.Drawing.Point(18, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 46);
            this.panel3.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.dtCheckout);
            this.panel1.Controls.Add(this.dtCheckin);
            this.panel1.Controls.Add(this.Checkin);
            this.panel1.Controls.Add(this.Checkout);
            this.panel1.Controls.Add(this.txtCheckout);
            this.panel1.Controls.Add(this.txtCheckin);
            this.panel1.Location = new System.Drawing.Point(18, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 55);
            this.panel1.TabIndex = 74;
            // 
            // pDGV
            // 
            this.pDGV.BackColor = System.Drawing.Color.LightCyan;
            this.pDGV.Controls.Add(this.dgvQuartos);
            this.pDGV.Location = new System.Drawing.Point(5, 28);
            this.pDGV.Name = "pDGV";
            this.pDGV.Size = new System.Drawing.Size(378, 183);
            this.pDGV.TabIndex = 52;
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.AllowUserToAddRows = false;
            this.dgvQuartos.AllowUserToDeleteRows = false;
            this.dgvQuartos.AllowUserToResizeColumns = false;
            this.dgvQuartos.AllowUserToResizeRows = false;
            this.dgvQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuartos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuartos.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuartos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvQuartos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvQuartos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuartos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQuartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuartos.EnableHeadersVisualStyles = false;
            this.dgvQuartos.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvQuartos.Location = new System.Drawing.Point(0, 0);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.ReadOnly = true;
            this.dgvQuartos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuartos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQuartos.RowHeadersVisible = false;
            this.dgvQuartos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvQuartos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuartos.Size = new System.Drawing.Size(378, 183);
            this.dgvQuartos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Reservas feitas neste quarto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "Todas reservas";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightCyan;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(370, 325);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 30);
            this.panel8.TabIndex = 73;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(528, 340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 13);
            this.label18.TabIndex = 75;
            this.label18.Text = "Dê um clique duplo para ver os detalhes";
            // 
            // pQuartos
            // 
            this.pQuartos.BackColor = System.Drawing.Color.LightCyan;
            this.pQuartos.Controls.Add(this.label2);
            this.pQuartos.Controls.Add(this.pDGV);
            this.pQuartos.Location = new System.Drawing.Point(370, 103);
            this.pQuartos.Name = "pQuartos";
            this.pQuartos.Size = new System.Drawing.Size(388, 216);
            this.pQuartos.TabIndex = 76;
            this.pQuartos.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightCyan;
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(759, 103);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(335, 216);
            this.panel10.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Hospedes cadastrados";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightCyan;
            this.panel11.Controls.Add(this.dgvHospedes);
            this.panel11.Location = new System.Drawing.Point(5, 28);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(327, 183);
            this.panel11.TabIndex = 52;
            // 
            // dgvHospedes
            // 
            this.dgvHospedes.AllowUserToAddRows = false;
            this.dgvHospedes.AllowUserToDeleteRows = false;
            this.dgvHospedes.AllowUserToResizeColumns = false;
            this.dgvHospedes.AllowUserToResizeRows = false;
            this.dgvHospedes.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvHospedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHospedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHospedes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvHospedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHospedes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHospedes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHospedes.EnableHeadersVisualStyles = false;
            this.dgvHospedes.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvHospedes.Location = new System.Drawing.Point(0, 0);
            this.dgvHospedes.Name = "dgvHospedes";
            this.dgvHospedes.ReadOnly = true;
            this.dgvHospedes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospedes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHospedes.RowHeadersVisible = false;
            this.dgvHospedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHospedes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospedes.Size = new System.Drawing.Size(327, 183);
            this.dgvHospedes.TabIndex = 1;
            this.dgvHospedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospedes_CellContentClick);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1106, 665);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.pQuartos);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pFormCPF);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReserva";
            this.Text = "frmReserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.pFormCPF.ResumeLayout(false);
            this.pFormCPF.PerformLayout();
            this.pFormulario.ResumeLayout(false);
            this.pFormulario.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pQuartos.ResumeLayout(false);
            this.pQuartos.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pFormCPF;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Checkin;
        private System.Windows.Forms.ComboBox txtCod;
        private System.Windows.Forms.Label Checkout;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.DateTimePicker dtCheckout;
        private System.Windows.Forms.Label Valortotal;
        private System.Windows.Forms.Label txtValorDiaria;
        private System.Windows.Forms.Label Quantidadedediarias;
        private System.Windows.Forms.Label txtDiarias;
        private System.Windows.Forms.Label txtCheckin;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label txtCheckout;
        private System.Windows.Forms.Label Valorfinal;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label txtValorFinal;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label Entrada;
        private System.Windows.Forms.Label txtValorTotal;
        private System.Windows.Forms.LinkLabel btnExcluir;
        private System.Windows.Forms.Button btnDetailsQuarto;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Panel pFormulario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tCod;
        private System.Windows.Forms.Label tEntrada;
        private System.Windows.Forms.Panel pDGV;
        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton btnCNPJ;
        private System.Windows.Forms.RadioButton btnCPF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pQuartos;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvHospedes;
    }
}