namespace PIM.View
{
    partial class frmAdicionais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAdicionais = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pFormulario = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.LinkLabel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).BeginInit();
            this.pFormulario.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.dgvAdicionais);
            this.panel1.Location = new System.Drawing.Point(300, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 527);
            this.panel1.TabIndex = 34;
            // 
            // dgvAdicionais
            // 
            this.dgvAdicionais.AllowUserToAddRows = false;
            this.dgvAdicionais.AllowUserToDeleteRows = false;
            this.dgvAdicionais.AllowUserToOrderColumns = true;
            this.dgvAdicionais.AllowUserToResizeColumns = false;
            this.dgvAdicionais.AllowUserToResizeRows = false;
            this.dgvAdicionais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAdicionais.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvAdicionais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdicionais.CausesValidation = false;
            this.dgvAdicionais.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvAdicionais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdicionais.ColumnHeadersHeight = 30;
            this.dgvAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdicionais.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdicionais.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdicionais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdicionais.EnableHeadersVisualStyles = false;
            this.dgvAdicionais.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvAdicionais.Location = new System.Drawing.Point(0, 0);
            this.dgvAdicionais.MultiSelect = false;
            this.dgvAdicionais.Name = "dgvAdicionais";
            this.dgvAdicionais.ReadOnly = true;
            this.dgvAdicionais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAdicionais.RowHeadersVisible = false;
            this.dgvAdicionais.RowHeadersWidth = 10;
            this.dgvAdicionais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdicionais.RowTemplate.Height = 20;
            this.dgvAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAdicionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdicionais.Size = new System.Drawing.Size(286, 527);
            this.dgvAdicionais.TabIndex = 0;
            this.dgvAdicionais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdicionais_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "Adicionais";
            // 
            // pFormulario
            // 
            this.pFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFormulario.BackColor = System.Drawing.Color.LightCyan;
            this.pFormulario.Controls.Add(this.panel2);
            this.pFormulario.Controls.Add(this.txtPreco);
            this.pFormulario.Controls.Add(this.btnSalvarAlteracao);
            this.pFormulario.Controls.Add(this.btnExcluir);
            this.pFormulario.Controls.Add(this.btnAlterar);
            this.pFormulario.Controls.Add(this.btnSalvar);
            this.pFormulario.Controls.Add(this.label3);
            this.pFormulario.Controls.Add(this.txtNome);
            this.pFormulario.Controls.Add(this.label2);
            this.pFormulario.Location = new System.Drawing.Point(18, 110);
            this.pFormulario.Name = "pFormulario";
            this.pFormulario.Size = new System.Drawing.Size(276, 272);
            this.pFormulario.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCod);
            this.panel2.Location = new System.Drawing.Point(17, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 46);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Codigo item";
            // 
            // txtCod
            // 
            this.txtCod.AutoSize = true;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(36, 5);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(19, 16);
            this.txtCod.TabIndex = 23;
            this.txtCod.Text = "---";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(17, 133);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(95, 22);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
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
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(17, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 22);
            this.txtNome.TabIndex = 1;
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
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Location = new System.Drawing.Point(18, 73);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(119, 31);
            this.btnNovo.TabIndex = 30;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1090, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pFormulario);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionais";
            this.Text = "frmAdicionais";
            this.Load += new System.EventHandler(this.frmAdicionais_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).EndInit();
            this.pFormulario.ResumeLayout(false);
            this.pFormulario.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAdicionais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pFormulario;
        private System.Windows.Forms.Label txtCod;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.LinkLabel btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}