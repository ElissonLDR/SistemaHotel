
namespace PIM.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barraInferior = new System.Windows.Forms.Panel();
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnAdicionais = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.Selecao = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnQuartos = new System.Windows.Forms.Button();
            this.btnFechamento = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnHospedes = new System.Windows.Forms.Button();
            this.plogo = new System.Windows.Forms.Panel();
            this.pMover = new System.Windows.Forms.Panel();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btMaximizar = new System.Windows.Forms.Button();
            this.pCentral = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.PainelMenu.SuspendLayout();
            this.pMover.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraInferior
            // 
            this.barraInferior.BackColor = System.Drawing.Color.DarkCyan;
            this.barraInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInferior.Location = new System.Drawing.Point(194, 690);
            this.barraInferior.Name = "barraInferior";
            this.barraInferior.Size = new System.Drawing.Size(1106, 10);
            this.barraInferior.TabIndex = 4;
            // 
            // PainelMenu
            // 
            this.PainelMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.PainelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PainelMenu.Controls.Add(this.btnManual);
            this.PainelMenu.Controls.Add(this.btnAdicionais);
            this.PainelMenu.Controls.Add(this.btnSair);
            this.PainelMenu.Controls.Add(this.btnCheckin);
            this.PainelMenu.Controls.Add(this.Logo);
            this.PainelMenu.Controls.Add(this.Selecao);
            this.PainelMenu.Controls.Add(this.btnInicio);
            this.PainelMenu.Controls.Add(this.btnAdmin);
            this.PainelMenu.Controls.Add(this.btnQuartos);
            this.PainelMenu.Controls.Add(this.btnFechamento);
            this.PainelMenu.Controls.Add(this.btnReserva);
            this.PainelMenu.Controls.Add(this.btnHospedes);
            this.PainelMenu.Controls.Add(this.plogo);
            this.PainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelMenu.Location = new System.Drawing.Point(0, 23);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(194, 677);
            this.PainelMenu.TabIndex = 2;
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Transparent;
            this.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.Transparent;
            this.btnManual.Image = global::PIM.Properties.Resources.manual;
            this.btnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManual.Location = new System.Drawing.Point(12, 544);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(171, 36);
            this.btnManual.TabIndex = 24;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnAdicionais
            // 
            this.btnAdicionais.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionais.FlatAppearance.BorderSize = 0;
            this.btnAdicionais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdicionais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionais.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdicionais.Image = global::PIM.Properties.Resources.estoque;
            this.btnAdicionais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionais.Location = new System.Drawing.Point(12, 369);
            this.btnAdicionais.Name = "btnAdicionais";
            this.btnAdicionais.Size = new System.Drawing.Size(171, 36);
            this.btnAdicionais.TabIndex = 23;
            this.btnAdicionais.Text = "Adicionais";
            this.btnAdicionais.UseVisualStyleBackColor = false;
            this.btnAdicionais.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(12, 628);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 37);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCheckin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckin.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckin.Image")));
            this.btnCheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckin.Location = new System.Drawing.Point(12, 237);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(171, 36);
            this.btnCheckin.TabIndex = 11;
            this.btnCheckin.Text = "Check-in";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Logo.BackgroundImage = global::PIM.Properties.Resources.Logo_Hotel;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(42, 7);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(108, 77);
            this.Logo.TabIndex = 10;
            // 
            // Selecao
            // 
            this.Selecao.BackColor = System.Drawing.Color.Transparent;
            this.Selecao.BackgroundImage = global::PIM.Properties.Resources.avanco_rapido;
            this.Selecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Selecao.Location = new System.Drawing.Point(161, 105);
            this.Selecao.Name = "Selecao";
            this.Selecao.Size = new System.Drawing.Size(36, 36);
            this.Selecao.TabIndex = 7;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Transparent;
            this.btnInicio.Image = global::PIM.Properties.Resources.home;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(12, 105);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 36);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(12, 586);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(171, 36);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnQuartos
            // 
            this.btnQuartos.BackColor = System.Drawing.Color.Transparent;
            this.btnQuartos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuartos.FlatAppearance.BorderSize = 0;
            this.btnQuartos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnQuartos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuartos.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuartos.Image = global::PIM.Properties.Resources.quarto;
            this.btnQuartos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuartos.Location = new System.Drawing.Point(12, 327);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(171, 36);
            this.btnQuartos.TabIndex = 3;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = false;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnFechamento
            // 
            this.btnFechamento.BackColor = System.Drawing.Color.Transparent;
            this.btnFechamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechamento.FlatAppearance.BorderSize = 0;
            this.btnFechamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFechamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnFechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechamento.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechamento.Image = global::PIM.Properties.Resources.pagamento;
            this.btnFechamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechamento.Location = new System.Drawing.Point(12, 279);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(171, 36);
            this.btnFechamento.TabIndex = 2;
            this.btnFechamento.Text = "Fechamento";
            this.btnFechamento.UseVisualStyleBackColor = false;
            this.btnFechamento.Click += new System.EventHandler(this.btnFechamento_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.ForeColor = System.Drawing.Color.Transparent;
            this.btnReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnReserva.Image")));
            this.btnReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserva.Location = new System.Drawing.Point(12, 195);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(171, 36);
            this.btnReserva.TabIndex = 1;
            this.btnReserva.Text = "Reservas";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnHospedes
            // 
            this.btnHospedes.BackColor = System.Drawing.Color.Transparent;
            this.btnHospedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHospedes.FlatAppearance.BorderSize = 0;
            this.btnHospedes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHospedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnHospedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedes.ForeColor = System.Drawing.Color.Transparent;
            this.btnHospedes.Image = ((System.Drawing.Image)(resources.GetObject("btnHospedes.Image")));
            this.btnHospedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospedes.Location = new System.Drawing.Point(12, 147);
            this.btnHospedes.Name = "btnHospedes";
            this.btnHospedes.Size = new System.Drawing.Size(171, 36);
            this.btnHospedes.TabIndex = 0;
            this.btnHospedes.Text = "Hospedes";
            this.btnHospedes.UseVisualStyleBackColor = false;
            this.btnHospedes.Click += new System.EventHandler(this.btnHospedes_Click);
            // 
            // plogo
            // 
            this.plogo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.plogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plogo.Location = new System.Drawing.Point(36, 3);
            this.plogo.Name = "plogo";
            this.plogo.Size = new System.Drawing.Size(121, 84);
            this.plogo.TabIndex = 11;
            // 
            // pMover
            // 
            this.pMover.BackColor = System.Drawing.Color.DarkCyan;
            this.pMover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMover.Controls.Add(this.labelNome);
            this.pMover.Controls.Add(this.btRestaurar);
            this.pMover.Controls.Add(this.btFechar);
            this.pMover.Controls.Add(this.btMinimizar);
            this.pMover.Controls.Add(this.btMaximizar);
            this.pMover.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMover.Location = new System.Drawing.Point(0, 0);
            this.pMover.Name = "pMover";
            this.pMover.Size = new System.Drawing.Size(1300, 23);
            this.pMover.TabIndex = 1;
            this.pMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMover_MouseDown);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btRestaurar.BackgroundImage = global::PIM.Properties.Resources.square;
            this.btRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestaurar.FlatAppearance.BorderSize = 0;
            this.btRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestaurar.Location = new System.Drawing.Point(1245, 8);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(16, 10);
            this.btRestaurar.TabIndex = 8;
            this.btRestaurar.UseVisualStyleBackColor = false;
            this.btRestaurar.Visible = false;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.BackColor = System.Drawing.Color.Transparent;
            this.btFechar.BackgroundImage = global::PIM.Properties.Resources.fechar;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(1267, 5);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(30, 16);
            this.btFechar.TabIndex = 4;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btMinimizar.BackgroundImage = global::PIM.Properties.Resources.minus;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(1217, 5);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(22, 16);
            this.btMinimizar.TabIndex = 7;
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btMaximizar.BackgroundImage = global::PIM.Properties.Resources.square;
            this.btMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximizar.Location = new System.Drawing.Point(1245, 4);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btMaximizar.TabIndex = 5;
            this.btMaximizar.UseVisualStyleBackColor = false;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // pCentral
            // 
            this.pCentral.BackColor = System.Drawing.Color.LightCyan;
            this.pCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCentral.Location = new System.Drawing.Point(194, 23);
            this.pCentral.Name = "pCentral";
            this.pCentral.Size = new System.Drawing.Size(1106, 667);
            this.pCentral.TabIndex = 5;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(680, 4);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(158, 16);
            this.labelNome.TabIndex = 9;
            this.labelNome.Text = "MENU FUNCIONÁRIO";
            // 
            // Menu
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pCentral);
            this.Controls.Add(this.barraInferior);
            this.Controls.Add(this.PainelMenu);
            this.Controls.Add(this.pMover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.PainelMenu.ResumeLayout(false);
            this.pMover.ResumeLayout(false);
            this.pMover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMover;
        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnHospedes;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btMaximizar;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel Selecao;
        private System.Windows.Forms.Panel barraInferior;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionais;
        private System.Windows.Forms.Panel plogo;
        private System.Windows.Forms.Panel pCentral;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label labelNome;
    }
}