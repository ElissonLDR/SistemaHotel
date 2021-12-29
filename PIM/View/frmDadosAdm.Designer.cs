namespace PIM.View
{
    partial class frmDadosAdm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pFormulario = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pAdmin = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pFormulario.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pFormulario
            // 
            this.pFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFormulario.BackColor = System.Drawing.Color.LightCyan;
            this.pFormulario.Controls.Add(this.btnSalvar);
            this.pFormulario.Controls.Add(this.btnExcluir);
            this.pFormulario.Controls.Add(this.panel4);
            this.pFormulario.Controls.Add(this.panel3);
            this.pFormulario.Controls.Add(this.btnAlterar);
            this.pFormulario.Controls.Add(this.panel2);
            this.pFormulario.Controls.Add(this.panel1);
            this.pFormulario.Controls.Add(this.btnSalvarAlteracao);
            this.pFormulario.Location = new System.Drawing.Point(18, 147);
            this.pFormulario.Name = "pFormulario";
            this.pFormulario.Size = new System.Drawing.Size(349, 268);
            this.pFormulario.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(14, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 31);
            this.btnSalvar.TabIndex = 100;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ActiveLinkColor = System.Drawing.Color.Blue;
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.LinkColor = System.Drawing.Color.Teal;
            this.btnExcluir.Location = new System.Drawing.Point(263, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 13);
            this.btnExcluir.TabIndex = 99;
            this.btnExcluir.TabStop = true;
            this.btnExcluir.Text = "Excluir dados";
            this.btnExcluir.Visible = false;
            this.btnExcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExcluir_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.txtSenha);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(14, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 47);
            this.panel4.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Azure;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(6, 6);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(159, 19);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Senha";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(14, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 47);
            this.panel3.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Azure;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 19);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(14, 6);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(124, 31);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.txtCNPJ);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(14, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 47);
            this.panel2.TabIndex = 11;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.Color.Azure;
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(5, 6);
            this.txtCNPJ.Mask = "00 000 000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(160, 19);
            this.txtCNPJ.TabIndex = 2;
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CNPJ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.txtCargo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(199, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 47);
            this.panel1.TabIndex = 12;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.Azure;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Enabled = false;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(4, 6);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(124, 19);
            this.txtCargo.TabIndex = 3;
            this.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Cargo";
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlteracao.FlatAppearance.BorderSize = 0;
            this.btnSalvarAlteracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarAlteracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalvarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(207, 202);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(125, 31);
            this.btnSalvarAlteracao.TabIndex = 12;
            this.btnSalvarAlteracao.Text = "Salvar Alteração";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracao.Visible = false;
            this.btnSalvarAlteracao.Click += new System.EventHandler(this.btnSalvarAlteracao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 35);
            this.label1.TabIndex = 43;
            this.label1.Text = "Meus dados";
            // 
            // pAdmin
            // 
            this.pAdmin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pAdmin.Controls.Add(this.dgvAdmin);
            this.pAdmin.Location = new System.Drawing.Point(373, 147);
            this.pAdmin.Name = "pAdmin";
            this.pAdmin.Size = new System.Drawing.Size(423, 268);
            this.pAdmin.TabIndex = 97;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmin.EnableHeadersVisualStyles = false;
            this.dgvAdmin.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 0);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(423, 268);
            this.dgvAdmin.TabIndex = 1;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Location = new System.Drawing.Point(18, 110);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 31);
            this.btnNovo.TabIndex = 98;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmDadosAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1074, 589);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDadosAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DadosAdm";
            this.Load += new System.EventHandler(this.frmDadosAdm_Load);
            this.pFormulario.ResumeLayout(false);
            this.pFormulario.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pFormulario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pAdmin;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.LinkLabel btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}