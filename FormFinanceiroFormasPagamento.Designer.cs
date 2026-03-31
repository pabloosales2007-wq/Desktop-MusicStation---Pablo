namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormFinanceiroFormasPagamento
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
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            this.lblFormasPagamentos = new System.Windows.Forms.Label();
            this.lblid_pagamento = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtid_pagamento = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.btnCadastrarPagamentos = new System.Windows.Forms.Button();
            this.btnAtualizarPagamentos = new System.Windows.Forms.Button();
            this.btnPesquisarPagamentos = new System.Windows.Forms.Button();
            this.btnDeletarPagamentos = new System.Windows.Forms.Button();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.id_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 29;
            this.pictureBoxFundo.TabStop = false;
            // 
            // lblFormasPagamentos
            // 
            this.lblFormasPagamentos.AutoSize = true;
            this.lblFormasPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblFormasPagamentos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormasPagamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblFormasPagamentos.Location = new System.Drawing.Point(160, 25);
            this.lblFormasPagamentos.Name = "lblFormasPagamentos";
            this.lblFormasPagamentos.Size = new System.Drawing.Size(330, 37);
            this.lblFormasPagamentos.TabIndex = 31;
            this.lblFormasPagamentos.Text = "Formas Pagamentos";
            // 
            // lblid_pagamento
            // 
            this.lblid_pagamento.AutoSize = true;
            this.lblid_pagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_pagamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_pagamento.ForeColor = System.Drawing.Color.White;
            this.lblid_pagamento.Location = new System.Drawing.Point(60, 75);
            this.lblid_pagamento.Name = "lblid_pagamento";
            this.lblid_pagamento.Size = new System.Drawing.Size(102, 16);
            this.lblid_pagamento.TabIndex = 57;
            this.lblid_pagamento.Text = "id_pagamento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(60, 117);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 16);
            this.lblTipo.TabIndex = 58;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtid_pagamento
            // 
            this.txtid_pagamento.Location = new System.Drawing.Point(63, 95);
            this.txtid_pagamento.Name = "txtid_pagamento";
            this.txtid_pagamento.Size = new System.Drawing.Size(100, 20);
            this.txtid_pagamento.TabIndex = 59;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(63, 136);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 60;
            // 
            // btnCadastrarPagamentos
            // 
            this.btnCadastrarPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPagamentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarPagamentos.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarPagamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarPagamentos.Name = "btnCadastrarPagamentos";
            this.btnCadastrarPagamentos.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarPagamentos.TabIndex = 67;
            this.btnCadastrarPagamentos.Text = "Cadastrar";
            this.btnCadastrarPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarPagamentos
            // 
            this.btnAtualizarPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPagamentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarPagamentos.Location = new System.Drawing.Point(534, 136);
            this.btnAtualizarPagamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarPagamentos.Name = "btnAtualizarPagamentos";
            this.btnAtualizarPagamentos.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarPagamentos.TabIndex = 75;
            this.btnAtualizarPagamentos.Text = "Atualizar";
            this.btnAtualizarPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarPagamentos
            // 
            this.btnPesquisarPagamentos.BackColor = System.Drawing.Color.White;
            this.btnPesquisarPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPagamentos.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarPagamentos.Location = new System.Drawing.Point(534, 95);
            this.btnPesquisarPagamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarPagamentos.Name = "btnPesquisarPagamentos";
            this.btnPesquisarPagamentos.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarPagamentos.TabIndex = 74;
            this.btnPesquisarPagamentos.Text = "Pesquisar";
            this.btnPesquisarPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnDeletarPagamentos
            // 
            this.btnDeletarPagamentos.BackColor = System.Drawing.Color.Red;
            this.btnDeletarPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarPagamentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarPagamentos.Location = new System.Drawing.Point(438, 136);
            this.btnDeletarPagamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarPagamentos.Name = "btnDeletarPagamentos";
            this.btnDeletarPagamentos.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarPagamentos.TabIndex = 73;
            this.btnDeletarPagamentos.Text = "Deletar";
            this.btnDeletarPagamentos.UseVisualStyleBackColor = false;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPagamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pagamento,
            this.tipo});
            this.dgvPagamentos.Location = new System.Drawing.Point(63, 264);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.Size = new System.Drawing.Size(245, 150);
            this.dgvPagamentos.TabIndex = 76;
            // 
            // id_pagamento
            // 
            this.id_pagamento.HeaderText = "id_pagamento";
            this.id_pagamento.Name = "id_pagamento";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // FormFinanceiroFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.dgvPagamentos);
            this.Controls.Add(this.btnAtualizarPagamentos);
            this.Controls.Add(this.btnPesquisarPagamentos);
            this.Controls.Add(this.btnDeletarPagamentos);
            this.Controls.Add(this.btnCadastrarPagamentos);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtid_pagamento);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblid_pagamento);
            this.Controls.Add(this.lblFormasPagamentos);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFinanceiroFormasPagamento";
            this.Text = "FormFinanceiroFormasPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblFormasPagamentos;
        private System.Windows.Forms.Label lblid_pagamento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtid_pagamento;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Button btnCadastrarPagamentos;
        private System.Windows.Forms.Button btnAtualizarPagamentos;
        private System.Windows.Forms.Button btnPesquisarPagamentos;
        private System.Windows.Forms.Button btnDeletarPagamentos;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}