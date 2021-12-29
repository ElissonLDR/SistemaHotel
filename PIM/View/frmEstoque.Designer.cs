namespace PIM.View
{
    partial class frmEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.LinkLabel();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.pFormulario = new System.Windows.Forms.Panel();
            this.txtQtd = new System.Windows.Forms.MaskedTextBox();
            this.txtCod = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAlimentos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLavanderia = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDiversos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pFormulario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLavanderia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiversos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Location = new System.Drawing.Point(13, 73);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(119, 31);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do item";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(17, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 19);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(17, 192);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 31);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(143, 192);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 31);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ActiveLinkColor = System.Drawing.Color.Blue;
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.LinkColor = System.Drawing.Color.Teal;
            this.btnExcluir.Location = new System.Drawing.Point(170, 238);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 13);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.TabStop = true;
            this.btnExcluir.Text = "Excluir dados";
            this.btnExcluir.Visible = false;
            this.btnExcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExcluir_LinkClicked);
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlteracao.FlatAppearance.BorderSize = 0;
            this.btnSalvarAlteracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarAlteracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(17, 229);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(120, 31);
            this.btnSalvarAlteracao.TabIndex = 12;
            this.btnSalvarAlteracao.Text = "Salvar Alteração";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracao.Visible = false;
            this.btnSalvarAlteracao.Click += new System.EventHandler(this.btnSalvarAlteracao_Click);
            // 
            // pFormulario
            // 
            this.pFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFormulario.BackColor = System.Drawing.Color.LightCyan;
            this.pFormulario.Controls.Add(this.txtQtd);
            this.pFormulario.Controls.Add(this.txtCod);
            this.pFormulario.Controls.Add(this.txtTipo);
            this.pFormulario.Controls.Add(this.btnSalvarAlteracao);
            this.pFormulario.Controls.Add(this.btnExcluir);
            this.pFormulario.Controls.Add(this.btnAlterar);
            this.pFormulario.Controls.Add(this.btnSalvar);
            this.pFormulario.Controls.Add(this.label3);
            this.pFormulario.Controls.Add(this.txtNome);
            this.pFormulario.Controls.Add(this.label2);
            this.pFormulario.Location = new System.Drawing.Point(13, 110);
            this.pFormulario.Name = "pFormulario";
            this.pFormulario.Size = new System.Drawing.Size(276, 272);
            this.pFormulario.TabIndex = 5;
            this.pFormulario.Visible = false;
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtQtd.Location = new System.Drawing.Point(17, 138);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(47, 17);
            this.txtQtd.TabIndex = 24;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCod
            // 
            this.txtCod.AutoSize = true;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(184, 39);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(79, 16);
            this.txtCod.TabIndex = 23;
            this.txtCod.Text = "Codigo item";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.Azure;
            this.txtTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Alimentos",
            "Equipamentos",
            "Lavanderia"});
            this.txtTipo.Location = new System.Drawing.Point(17, 34);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(120, 21);
            this.txtTipo.TabIndex = 22;
            this.txtTipo.Text = "Selecione o tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Estoque alimentos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Estoque equipamentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(831, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estoque lavanderia";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.dgvAlimentos);
            this.panel1.Location = new System.Drawing.Point(295, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 527);
            this.panel1.TabIndex = 29;
            // 
            // dgvAlimentos
            // 
            this.dgvAlimentos.AllowUserToAddRows = false;
            this.dgvAlimentos.AllowUserToDeleteRows = false;
            this.dgvAlimentos.AllowUserToOrderColumns = true;
            this.dgvAlimentos.AllowUserToResizeColumns = false;
            this.dgvAlimentos.AllowUserToResizeRows = false;
            this.dgvAlimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlimentos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvAlimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlimentos.CausesValidation = false;
            this.dgvAlimentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlimentos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvAlimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAlimentos.ColumnHeadersHeight = 30;
            this.dgvAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlimentos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAlimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlimentos.EnableHeadersVisualStyles = false;
            this.dgvAlimentos.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvAlimentos.Location = new System.Drawing.Point(0, 0);
            this.dgvAlimentos.MultiSelect = false;
            this.dgvAlimentos.Name = "dgvAlimentos";
            this.dgvAlimentos.ReadOnly = true;
            this.dgvAlimentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAlimentos.RowHeadersVisible = false;
            this.dgvAlimentos.RowHeadersWidth = 10;
            this.dgvAlimentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAlimentos.RowTemplate.Height = 20;
            this.dgvAlimentos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvAlimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlimentos.Size = new System.Drawing.Size(263, 527);
            this.dgvAlimentos.TabIndex = 0;
            this.dgvAlimentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospedes_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.dgvEquipamentos);
            this.panel2.Location = new System.Drawing.Point(564, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 527);
            this.panel2.TabIndex = 30;
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.AllowUserToAddRows = false;
            this.dgvEquipamentos.AllowUserToDeleteRows = false;
            this.dgvEquipamentos.AllowUserToOrderColumns = true;
            this.dgvEquipamentos.AllowUserToResizeColumns = false;
            this.dgvEquipamentos.AllowUserToResizeRows = false;
            this.dgvEquipamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEquipamentos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvEquipamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipamentos.CausesValidation = false;
            this.dgvEquipamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEquipamentos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvEquipamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvEquipamentos.ColumnHeadersHeight = 30;
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEquipamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipamentos.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvEquipamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquipamentos.EnableHeadersVisualStyles = false;
            this.dgvEquipamentos.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvEquipamentos.Location = new System.Drawing.Point(0, 0);
            this.dgvEquipamentos.MultiSelect = false;
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.ReadOnly = true;
            this.dgvEquipamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvEquipamentos.RowHeadersVisible = false;
            this.dgvEquipamentos.RowHeadersWidth = 10;
            this.dgvEquipamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEquipamentos.RowTemplate.Height = 20;
            this.dgvEquipamentos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvEquipamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipamentos.Size = new System.Drawing.Size(263, 527);
            this.dgvEquipamentos.TabIndex = 0;
            this.dgvEquipamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.dgvLavanderia);
            this.panel3.Location = new System.Drawing.Point(833, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 526);
            this.panel3.TabIndex = 30;
            // 
            // dgvLavanderia
            // 
            this.dgvLavanderia.AllowUserToAddRows = false;
            this.dgvLavanderia.AllowUserToDeleteRows = false;
            this.dgvLavanderia.AllowUserToOrderColumns = true;
            this.dgvLavanderia.AllowUserToResizeColumns = false;
            this.dgvLavanderia.AllowUserToResizeRows = false;
            this.dgvLavanderia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLavanderia.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvLavanderia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLavanderia.CausesValidation = false;
            this.dgvLavanderia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLavanderia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvLavanderia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLavanderia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvLavanderia.ColumnHeadersHeight = 30;
            this.dgvLavanderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLavanderia.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLavanderia.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvLavanderia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLavanderia.EnableHeadersVisualStyles = false;
            this.dgvLavanderia.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvLavanderia.Location = new System.Drawing.Point(0, 0);
            this.dgvLavanderia.MultiSelect = false;
            this.dgvLavanderia.Name = "dgvLavanderia";
            this.dgvLavanderia.ReadOnly = true;
            this.dgvLavanderia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLavanderia.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvLavanderia.RowHeadersVisible = false;
            this.dgvLavanderia.RowHeadersWidth = 10;
            this.dgvLavanderia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLavanderia.RowTemplate.Height = 20;
            this.dgvLavanderia.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvLavanderia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLavanderia.Size = new System.Drawing.Size(263, 526);
            this.dgvLavanderia.TabIndex = 0;
            this.dgvLavanderia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.dgvDiversos);
            this.panel4.Location = new System.Drawing.Point(16, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 192);
            this.panel4.TabIndex = 31;
            // 
            // dgvDiversos
            // 
            this.dgvDiversos.AllowUserToAddRows = false;
            this.dgvDiversos.AllowUserToDeleteRows = false;
            this.dgvDiversos.AllowUserToOrderColumns = true;
            this.dgvDiversos.AllowUserToResizeColumns = false;
            this.dgvDiversos.AllowUserToResizeRows = false;
            this.dgvDiversos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDiversos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvDiversos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiversos.CausesValidation = false;
            this.dgvDiversos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDiversos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDiversos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiversos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvDiversos.ColumnHeadersHeight = 30;
            this.dgvDiversos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiversos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiversos.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDiversos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiversos.EnableHeadersVisualStyles = false;
            this.dgvDiversos.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvDiversos.Location = new System.Drawing.Point(0, 0);
            this.dgvDiversos.MultiSelect = false;
            this.dgvDiversos.Name = "dgvDiversos";
            this.dgvDiversos.ReadOnly = true;
            this.dgvDiversos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiversos.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDiversos.RowHeadersVisible = false;
            this.dgvDiversos.RowHeadersWidth = 10;
            this.dgvDiversos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDiversos.RowTemplate.Height = 20;
            this.dgvDiversos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDiversos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiversos.Size = new System.Drawing.Size(273, 192);
            this.dgvDiversos.TabIndex = 0;
            this.dgvDiversos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightCyan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Estoque total";
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1110, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pFormulario);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load_1);
            this.pFormulario.ResumeLayout(false);
            this.pFormulario.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLavanderia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiversos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.LinkLabel btnExcluir;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.Panel pFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAlimentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLavanderia;
        private System.Windows.Forms.Label txtCod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDiversos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtQtd;
    }
}