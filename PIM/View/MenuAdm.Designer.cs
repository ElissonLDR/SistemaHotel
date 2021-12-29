namespace PIM.View
{
    partial class MenuAdm
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
            this.pCentral = new System.Windows.Forms.Panel();
            this.lbHorario = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.btnManual = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.plogo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDados = new System.Windows.Forms.Button();
            this.Selecao = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnQuartos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.pMover = new System.Windows.Forms.Panel();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btMaximizar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.pCentral.SuspendLayout();
            this.PainelMenu.SuspendLayout();
            this.pMover.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCentral
            // 
            this.pCentral.BackColor = System.Drawing.Color.Azure;
            this.pCentral.Controls.Add(this.lbHorario);
            this.pCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCentral.Location = new System.Drawing.Point(194, 23);
            this.pCentral.Name = "pCentral";
            this.pCentral.Size = new System.Drawing.Size(1090, 628);
            this.pCentral.TabIndex = 9;
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(939, 3);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(92, 39);
            this.lbHorario.TabIndex = 0;
            this.lbHorario.Text = "Hora";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(194, 651);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1090, 10);
            this.panel7.TabIndex = 8;
            // 
            // PainelMenu
            // 
            this.PainelMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.PainelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PainelMenu.Controls.Add(this.btnManual);
            this.PainelMenu.Controls.Add(this.Logo);
            this.PainelMenu.Controls.Add(this.plogo);
            this.PainelMenu.Controls.Add(this.btnSair);
            this.PainelMenu.Controls.Add(this.btnDados);
            this.PainelMenu.Controls.Add(this.Selecao);
            this.PainelMenu.Controls.Add(this.btnInicio);
            this.PainelMenu.Controls.Add(this.btnAdmin);
            this.PainelMenu.Controls.Add(this.btnQuartos);
            this.PainelMenu.Controls.Add(this.btnEstoque);
            this.PainelMenu.Controls.Add(this.btnFuncionarios);
            this.PainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelMenu.Location = new System.Drawing.Point(0, 23);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(194, 638);
            this.PainelMenu.TabIndex = 7;
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
            this.btnManual.Location = new System.Drawing.Point(12, 512);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(171, 36);
            this.btnManual.TabIndex = 25;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Logo.BackgroundImage = global::PIM.Properties.Resources.Logo_Hotel;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(42, 10);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(108, 77);
            this.Logo.TabIndex = 22;
            // 
            // plogo
            // 
            this.plogo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.plogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plogo.Location = new System.Drawing.Point(36, 6);
            this.plogo.Name = "plogo";
            this.plogo.Size = new System.Drawing.Size(121, 84);
            this.plogo.TabIndex = 23;
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
            this.btnSair.Location = new System.Drawing.Point(12, 596);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 37);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDados
            // 
            this.btnDados.BackColor = System.Drawing.Color.Transparent;
            this.btnDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDados.FlatAppearance.BorderSize = 0;
            this.btnDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDados.ForeColor = System.Drawing.Color.Transparent;
            this.btnDados.Image = global::PIM.Properties.Resources.informacoes;
            this.btnDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDados.Location = new System.Drawing.Point(12, 316);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(171, 36);
            this.btnDados.TabIndex = 12;
            this.btnDados.Text = "Meus dados";
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // Selecao
            // 
            this.Selecao.BackColor = System.Drawing.Color.Transparent;
            this.Selecao.BackgroundImage = global::PIM.Properties.Resources.avanco_rapido;
            this.Selecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Selecao.Location = new System.Drawing.Point(161, 148);
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
            this.btnInicio.Location = new System.Drawing.Point(12, 148);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 36);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
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
            this.btnAdmin.Image = global::PIM.Properties.Resources.funcionarios;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(12, 554);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(171, 36);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Funcionario";
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
            this.btnQuartos.Location = new System.Drawing.Point(12, 190);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(171, 36);
            this.btnQuartos.TabIndex = 3;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = false;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Image = global::PIM.Properties.Resources.estoque;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(12, 232);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(171, 36);
            this.btnEstoque.TabIndex = 8;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.Image = global::PIM.Properties.Resources.funcionarios;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(12, 274);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(171, 36);
            this.btnFuncionarios.TabIndex = 9;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
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
            this.pMover.Size = new System.Drawing.Size(1284, 23);
            this.pMover.TabIndex = 6;
            this.pMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMover_MouseDown_1);
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
            this.btRestaurar.Location = new System.Drawing.Point(1229, 7);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(16, 10);
            this.btRestaurar.TabIndex = 12;
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
            this.btFechar.Location = new System.Drawing.Point(1251, 4);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(30, 16);
            this.btFechar.TabIndex = 9;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click_1);
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
            this.btMinimizar.Location = new System.Drawing.Point(1201, 4);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(22, 16);
            this.btMinimizar.TabIndex = 11;
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click_1);
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
            this.btMaximizar.Location = new System.Drawing.Point(1229, 3);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btMaximizar.TabIndex = 10;
            this.btMaximizar.UseVisualStyleBackColor = false;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(698, 3);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(181, 16);
            this.labelNome.TabIndex = 13;
            this.labelNome.Text = "MENU ADMINISTRADOR";
            // 
            // MenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pCentral);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.PainelMenu);
            this.Controls.Add(this.pMover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdm";
            this.Load += new System.EventHandler(this.MenuAdm_Load);
            this.pCentral.ResumeLayout(false);
            this.pCentral.PerformLayout();
            this.PainelMenu.ResumeLayout(false);
            this.pMover.ResumeLayout(false);
            this.pMover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCentral;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Panel Selecao;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Panel pMover;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel plogo;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btMaximizar;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label labelNome;
    }
}