namespace PIM.View
{
    partial class frmHospedes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pFormulario = new System.Windows.Forms.Panel();
            this.btnCNPJ = new System.Windows.Forms.RadioButton();
            this.btnCPF = new System.Windows.Forms.RadioButton();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.LabelMsg1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.LinkLabel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHospedes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.pFormulario.SuspendLayout();
            this.p1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário de Hospede";
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Location = new System.Drawing.Point(8, 72);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 31);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pFormulario
            // 
            this.pFormulario.BackColor = System.Drawing.Color.LightCyan;
            this.pFormulario.Controls.Add(this.btnCNPJ);
            this.pFormulario.Controls.Add(this.btnCPF);
            this.pFormulario.Controls.Add(this.btnSalvarAlteracao);
            this.pFormulario.Controls.Add(this.p1);
            this.pFormulario.Controls.Add(this.panel4);
            this.pFormulario.Controls.Add(this.btnExcluir);
            this.pFormulario.Controls.Add(this.btnAlterar);
            this.pFormulario.Controls.Add(this.panel8);
            this.pFormulario.Controls.Add(this.btnSalvar);
            this.pFormulario.Controls.Add(this.panel5);
            this.pFormulario.Controls.Add(this.panel9);
            this.pFormulario.Controls.Add(this.panel3);
            this.pFormulario.Controls.Add(this.panel7);
            this.pFormulario.Controls.Add(this.panel2);
            this.pFormulario.Controls.Add(this.panel6);
            this.pFormulario.Controls.Add(this.panel10);
            this.pFormulario.Location = new System.Drawing.Point(8, 109);
            this.pFormulario.Name = "pFormulario";
            this.pFormulario.Size = new System.Drawing.Size(375, 544);
            this.pFormulario.TabIndex = 20;
            this.pFormulario.Visible = false;
            // 
            // btnCNPJ
            // 
            this.btnCNPJ.AutoSize = true;
            this.btnCNPJ.Location = new System.Drawing.Point(87, 173);
            this.btnCNPJ.Name = "btnCNPJ";
            this.btnCNPJ.Size = new System.Drawing.Size(52, 17);
            this.btnCNPJ.TabIndex = 779;
            this.btnCNPJ.TabStop = true;
            this.btnCNPJ.Text = "CNPJ";
            this.btnCNPJ.UseVisualStyleBackColor = true;
            this.btnCNPJ.CheckedChanged += new System.EventHandler(this.btnCPNJ_CheckedChanged);
            // 
            // btnCPF
            // 
            this.btnCPF.AutoSize = true;
            this.btnCPF.Location = new System.Drawing.Point(18, 173);
            this.btnCPF.Name = "btnCPF";
            this.btnCPF.Size = new System.Drawing.Size(45, 17);
            this.btnCPF.TabIndex = 778;
            this.btnCPF.TabStop = true;
            this.btnCPF.Text = "CPF";
            this.btnCPF.UseVisualStyleBackColor = true;
            this.btnCPF.CheckedChanged += new System.EventHandler(this.btnCPF_CheckedChanged);
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlteracao.FlatAppearance.BorderSize = 0;
            this.btnSalvarAlteracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarAlteracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(238, 478);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(126, 31);
            this.btnSalvarAlteracao.TabIndex = 74;
            this.btnSalvarAlteracao.Text = "Salvar Alteração";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracao.Visible = false;
            this.btnSalvarAlteracao.Click += new System.EventHandler(this.btnSalvarAlteracao_Click);
            // 
            // p1
            // 
            this.p1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.p1.Controls.Add(this.txtNome);
            this.p1.Controls.Add(this.LabelMsg1);
            this.p1.Controls.Add(this.label2);
            this.p1.Location = new System.Drawing.Point(18, 54);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(341, 50);
            this.p1.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Azure;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(7, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 19);
            this.txtNome.TabIndex = 1;
            // 
            // LabelMsg1
            // 
            this.LabelMsg1.AutoSize = true;
            this.LabelMsg1.BackColor = System.Drawing.Color.Transparent;
            this.LabelMsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMsg1.Location = new System.Drawing.Point(7, 7);
            this.LabelMsg1.Name = "LabelMsg1";
            this.LabelMsg1.Size = new System.Drawing.Size(0, 20);
            this.LabelMsg1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.txtRua);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(18, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 50);
            this.panel4.TabIndex = 17;
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.Azure;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Black;
            this.txtRua.Location = new System.Drawing.Point(7, 10);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(326, 19);
            this.txtRua.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rua";
            // 
            // btnExcluir
            // 
            this.btnExcluir.ActiveLinkColor = System.Drawing.Color.Blue;
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.LinkColor = System.Drawing.Color.Teal;
            this.btnExcluir.Location = new System.Drawing.Point(264, 523);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 13);
            this.btnExcluir.TabIndex = 777;
            this.btnExcluir.TabStop = true;
            this.btnExcluir.Text = "Excluir dados";
            this.btnExcluir.Visible = false;
            this.btnExcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExcluir_LinkClicked);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(31, 17);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(124, 31);
            this.btnAlterar.TabIndex = 71;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel8.Controls.Add(this.txtCel);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(222, 110);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(137, 46);
            this.panel8.TabIndex = 13;
            // 
            // txtCel
            // 
            this.txtCel.BackColor = System.Drawing.Color.Azure;
            this.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.ForeColor = System.Drawing.Color.Black;
            this.txtCel.Location = new System.Drawing.Point(7, 6);
            this.txtCel.Mask = "00 0 0000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(122, 19);
            this.txtCel.TabIndex = 3;
            this.txtCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Celular";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(36, 478);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 31);
            this.btnSalvar.TabIndex = 55;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.Controls.Add(this.txtBairro);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(18, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 47);
            this.panel5.TabIndex = 18;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.Azure;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(7, 9);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(326, 19);
            this.txtBairro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bairro";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel9.Controls.Add(this.txtNascimento);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(18, 108);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(121, 50);
            this.panel9.TabIndex = 12;
            // 
            // txtNascimento
            // 
            this.txtNascimento.CalendarTitleBackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNascimento.Location = new System.Drawing.Point(7, 6);
            this.txtNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(103, 26);
            this.txtNascimento.TabIndex = 2;
            this.txtNascimento.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nascimento";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.txtCEP);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(18, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 50);
            this.panel3.TabIndex = 16;
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.Azure;
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.ForeColor = System.Drawing.Color.Black;
            this.txtCEP.Location = new System.Drawing.Point(7, 8);
            this.txtCEP.Mask = "00 000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(97, 19);
            this.txtCEP.TabIndex = 6;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CEP";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel7.Controls.Add(this.txtEstado);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(275, 427);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(84, 43);
            this.panel7.TabIndex = 20;
            // 
            // txtEstado
            // 
            this.txtEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.txtEstado.Location = new System.Drawing.Point(15, 3);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(61, 23);
            this.txtEstado.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(18, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 50);
            this.panel2.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Azure;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(7, 11);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 19);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.Controls.Add(this.txtCidade);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(18, 427);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 43);
            this.panel6.TabIndex = 19;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Azure;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(7, 7);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(232, 19);
            this.txtCidade.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cidade";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel10.Controls.Add(this.txtCPF);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(173, 161);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(186, 41);
            this.panel10.TabIndex = 14;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.Azure;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(18, 5);
            this.txtCPF.Mask = "00.000.000/0000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(152, 19);
            this.txtCPF.TabIndex = 4;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CPF";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(237, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 23);
            this.txtBuscar.TabIndex = 51;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtBuscar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBuscar_MaskInputRejected);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Azure;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(149, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Pesquise o CPF";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.dgvHospedes);
            this.panel1.Location = new System.Drawing.Point(389, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 527);
            this.panel1.TabIndex = 23;
            // 
            // dgvHospedes
            // 
            this.dgvHospedes.AllowUserToAddRows = false;
            this.dgvHospedes.AllowUserToDeleteRows = false;
            this.dgvHospedes.AllowUserToResizeColumns = false;
            this.dgvHospedes.AllowUserToResizeRows = false;
            this.dgvHospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHospedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHospedes.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvHospedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHospedes.CausesValidation = false;
            this.dgvHospedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHospedes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvHospedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHospedes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHospedes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHospedes.EnableHeadersVisualStyles = false;
            this.dgvHospedes.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvHospedes.Location = new System.Drawing.Point(0, 0);
            this.dgvHospedes.MultiSelect = false;
            this.dgvHospedes.Name = "dgvHospedes";
            this.dgvHospedes.ReadOnly = true;
            this.dgvHospedes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospedes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHospedes.RowHeadersVisible = false;
            this.dgvHospedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHospedes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospedes.Size = new System.Drawing.Size(705, 527);
            this.dgvHospedes.TabIndex = 50;
            this.dgvHospedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospedes_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::PIM.Properties.Resources.pesquisa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(447, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 22);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(389, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Dê um clique duplo para ver os detalhes";
            // 
            // frmHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1106, 665);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pFormulario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHospedes";
            this.Tag = "";
            this.Text = "frmHospedes";
            this.Load += new System.EventHandler(this.frmHospedes_Load);
            this.pFormulario.ResumeLayout(false);
            this.pFormulario.PerformLayout();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pFormulario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.LinkLabel btnExcluir;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHospedes;
        private System.Windows.Forms.DateTimePicker txtNascimento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label LabelMsg1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnCNPJ;
        private System.Windows.Forms.RadioButton btnCPF;
        private System.Windows.Forms.Label label18;
    }
}