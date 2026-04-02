namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormFinanceiroPagamentos
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
            this.lblPagamentos = new System.Windows.Forms.Label();
            this.lblid_pagamento = new System.Windows.Forms.Label();
            this.lblforma_pagamento_id = new System.Windows.Forms.Label();
            this.lblpedido_id = new System.Windows.Forms.Label();
            this.lbldata_pagamento = new System.Windows.Forms.Label();
            this.lblvalor_pago = new System.Windows.Forms.Label();
            this.lblAcompanhamento = new System.Windows.Forms.Label();
            this.btnCadastrarPagamentos = new System.Windows.Forms.Button();
            this.btnAtualizarPagamentos = new System.Windows.Forms.Button();
            this.btnPesquisarPagamentos = new System.Windows.Forms.Button();
            this.btnDeletarPagamentos = new System.Windows.Forms.Button();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.id_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pagamento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acompanhamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid_pagamento = new System.Windows.Forms.TextBox();
            this.txtforma_pagamento_id = new System.Windows.Forms.TextBox();
            this.txtpedido_id = new System.Windows.Forms.TextBox();
            this.txtdata_pagamento = new System.Windows.Forms.TextBox();
            this.txtvalor_pago = new System.Windows.Forms.TextBox();
            this.txtacompanhamento = new System.Windows.Forms.TextBox();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPagamentos
            // 
            this.lblPagamentos.AutoSize = true;
            this.lblPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblPagamentos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblPagamentos.Location = new System.Drawing.Point(232, 25);
            this.lblPagamentos.Name = "lblPagamentos";
            this.lblPagamentos.Size = new System.Drawing.Size(205, 37);
            this.lblPagamentos.TabIndex = 27;
            this.lblPagamentos.Text = "Pagamentos";
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
            this.lblid_pagamento.TabIndex = 56;
            this.lblid_pagamento.Text = "id_pagamento:";
            // 
            // lblforma_pagamento_id
            // 
            this.lblforma_pagamento_id.AutoSize = true;
            this.lblforma_pagamento_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblforma_pagamento_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforma_pagamento_id.ForeColor = System.Drawing.Color.White;
            this.lblforma_pagamento_id.Location = new System.Drawing.Point(245, 75);
            this.lblforma_pagamento_id.Name = "lblforma_pagamento_id";
            this.lblforma_pagamento_id.Size = new System.Drawing.Size(149, 16);
            this.lblforma_pagamento_id.TabIndex = 57;
            this.lblforma_pagamento_id.Text = "Forma de Pagamento:";
            // 
            // lblpedido_id
            // 
            this.lblpedido_id.AutoSize = true;
            this.lblpedido_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblpedido_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpedido_id.ForeColor = System.Drawing.Color.White;
            this.lblpedido_id.Location = new System.Drawing.Point(165, 75);
            this.lblpedido_id.Name = "lblpedido_id";
            this.lblpedido_id.Size = new System.Drawing.Size(74, 16);
            this.lblpedido_id.TabIndex = 58;
            this.lblpedido_id.Text = "pedido_id:";
            // 
            // lbldata_pagamento
            // 
            this.lbldata_pagamento.AutoSize = true;
            this.lbldata_pagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbldata_pagamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata_pagamento.ForeColor = System.Drawing.Color.White;
            this.lbldata_pagamento.Location = new System.Drawing.Point(60, 117);
            this.lbldata_pagamento.Name = "lbldata_pagamento";
            this.lbldata_pagamento.Size = new System.Drawing.Size(113, 16);
            this.lbldata_pagamento.TabIndex = 59;
            this.lbldata_pagamento.Text = "Data Pagamento";
            // 
            // lblvalor_pago
            // 
            this.lblvalor_pago.AutoSize = true;
            this.lblvalor_pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblvalor_pago.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor_pago.ForeColor = System.Drawing.Color.White;
            this.lblvalor_pago.Location = new System.Drawing.Point(179, 117);
            this.lblvalor_pago.Name = "lblvalor_pago";
            this.lblvalor_pago.Size = new System.Drawing.Size(82, 16);
            this.lblvalor_pago.TabIndex = 60;
            this.lblvalor_pago.Text = "valor_pago:";
            // 
            // lblAcompanhamento
            // 
            this.lblAcompanhamento.AutoSize = true;
            this.lblAcompanhamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAcompanhamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcompanhamento.ForeColor = System.Drawing.Color.White;
            this.lblAcompanhamento.Location = new System.Drawing.Point(60, 156);
            this.lblAcompanhamento.Name = "lblAcompanhamento";
            this.lblAcompanhamento.Size = new System.Drawing.Size(127, 16);
            this.lblAcompanhamento.TabIndex = 61;
            this.lblAcompanhamento.Text = "Acompanhamento:";
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
            this.btnCadastrarPagamentos.TabIndex = 66;
            this.btnCadastrarPagamentos.Text = "Cadastrar";
            this.btnCadastrarPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarPagamentos
            // 
            this.btnAtualizarPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPagamentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarPagamentos.Location = new System.Drawing.Point(533, 133);
            this.btnAtualizarPagamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarPagamentos.Name = "btnAtualizarPagamentos";
            this.btnAtualizarPagamentos.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarPagamentos.TabIndex = 72;
            this.btnAtualizarPagamentos.Text = "Atualizar";
            this.btnAtualizarPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarPagamentos
            // 
            this.btnPesquisarPagamentos.BackColor = System.Drawing.Color.White;
            this.btnPesquisarPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPagamentos.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarPagamentos.Location = new System.Drawing.Point(533, 94);
            this.btnPesquisarPagamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarPagamentos.Name = "btnPesquisarPagamentos";
            this.btnPesquisarPagamentos.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarPagamentos.TabIndex = 71;
            this.btnPesquisarPagamentos.Text = "Pesquisar";
            this.btnPesquisarPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnDeletarPagamentos
            // 
            this.btnDeletarPagamentos.BackColor = System.Drawing.Color.Red;
            this.btnDeletarPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarPagamentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarPagamentos.Location = new System.Drawing.Point(437, 133);
            this.btnDeletarPagamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarPagamentos.Name = "btnDeletarPagamentos";
            this.btnDeletarPagamentos.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarPagamentos.TabIndex = 70;
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
            this.pedido_id,
            this.forma_pagamento_id,
            this.data_pagamento,
            this.valor_pago,
            this.Acompanhamento});
            this.dgvPagamentos.Location = new System.Drawing.Point(63, 264);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.Size = new System.Drawing.Size(542, 150);
            this.dgvPagamentos.TabIndex = 73;
            // 
            // id_pagamento
            // 
            this.id_pagamento.HeaderText = "id_pagamento";
            this.id_pagamento.Name = "id_pagamento";
            // 
            // pedido_id
            // 
            this.pedido_id.HeaderText = "pedido_id";
            this.pedido_id.Name = "pedido_id";
            // 
            // forma_pagamento_id
            // 
            this.forma_pagamento_id.HeaderText = "Forma de Pagamento";
            this.forma_pagamento_id.Name = "forma_pagamento_id";
            // 
            // data_pagamento
            // 
            this.data_pagamento.HeaderText = "Data Pagamento";
            this.data_pagamento.Name = "data_pagamento";
            // 
            // valor_pago
            // 
            this.valor_pago.HeaderText = "Valor Pago";
            this.valor_pago.Name = "valor_pago";
            // 
            // Acompanhamento
            // 
            this.Acompanhamento.HeaderText = "Acompanhamento";
            this.Acompanhamento.Name = "Acompanhamento";
            // 
            // txtid_pagamento
            // 
            this.txtid_pagamento.Location = new System.Drawing.Point(63, 94);
            this.txtid_pagamento.Name = "txtid_pagamento";
            this.txtid_pagamento.Size = new System.Drawing.Size(99, 20);
            this.txtid_pagamento.TabIndex = 74;
            // 
            // txtforma_pagamento_id
            // 
            this.txtforma_pagamento_id.Location = new System.Drawing.Point(245, 94);
            this.txtforma_pagamento_id.Name = "txtforma_pagamento_id";
            this.txtforma_pagamento_id.Size = new System.Drawing.Size(146, 20);
            this.txtforma_pagamento_id.TabIndex = 75;
            // 
            // txtpedido_id
            // 
            this.txtpedido_id.Location = new System.Drawing.Point(168, 94);
            this.txtpedido_id.Name = "txtpedido_id";
            this.txtpedido_id.Size = new System.Drawing.Size(71, 20);
            this.txtpedido_id.TabIndex = 76;
            // 
            // txtdata_pagamento
            // 
            this.txtdata_pagamento.Location = new System.Drawing.Point(63, 133);
            this.txtdata_pagamento.Name = "txtdata_pagamento";
            this.txtdata_pagamento.Size = new System.Drawing.Size(110, 20);
            this.txtdata_pagamento.TabIndex = 77;
            // 
            // txtvalor_pago
            // 
            this.txtvalor_pago.Location = new System.Drawing.Point(182, 133);
            this.txtvalor_pago.Name = "txtvalor_pago";
            this.txtvalor_pago.Size = new System.Drawing.Size(79, 20);
            this.txtvalor_pago.TabIndex = 78;
            // 
            // txtacompanhamento
            // 
            this.txtacompanhamento.Location = new System.Drawing.Point(63, 173);
            this.txtacompanhamento.Name = "txtacompanhamento";
            this.txtacompanhamento.Size = new System.Drawing.Size(124, 20);
            this.txtacompanhamento.TabIndex = 79;
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 28;
            this.pictureBoxFundo.TabStop = false;
            // 
            // FormFinanceiroPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.txtacompanhamento);
            this.Controls.Add(this.txtvalor_pago);
            this.Controls.Add(this.txtdata_pagamento);
            this.Controls.Add(this.txtpedido_id);
            this.Controls.Add(this.txtforma_pagamento_id);
            this.Controls.Add(this.txtid_pagamento);
            this.Controls.Add(this.dgvPagamentos);
            this.Controls.Add(this.btnAtualizarPagamentos);
            this.Controls.Add(this.btnPesquisarPagamentos);
            this.Controls.Add(this.btnDeletarPagamentos);
            this.Controls.Add(this.btnCadastrarPagamentos);
            this.Controls.Add(this.lblAcompanhamento);
            this.Controls.Add(this.lblvalor_pago);
            this.Controls.Add(this.lbldata_pagamento);
            this.Controls.Add(this.lblpedido_id);
            this.Controls.Add(this.lblforma_pagamento_id);
            this.Controls.Add(this.lblid_pagamento);
            this.Controls.Add(this.lblPagamentos);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFinanceiroPagamentos";
            this.Text = "FormFinanceiroPagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagamentos;
        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblid_pagamento;
        private System.Windows.Forms.Label lblforma_pagamento_id;
        private System.Windows.Forms.Label lblpedido_id;
        private System.Windows.Forms.Label lbldata_pagamento;
        private System.Windows.Forms.Label lblvalor_pago;
        private System.Windows.Forms.Label lblAcompanhamento;
        private System.Windows.Forms.Button btnCadastrarPagamentos;
        private System.Windows.Forms.Button btnAtualizarPagamentos;
        private System.Windows.Forms.Button btnPesquisarPagamentos;
        private System.Windows.Forms.Button btnDeletarPagamentos;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.TextBox txtid_pagamento;
        private System.Windows.Forms.TextBox txtforma_pagamento_id;
        private System.Windows.Forms.TextBox txtpedido_id;
        private System.Windows.Forms.TextBox txtdata_pagamento;
        private System.Windows.Forms.TextBox txtvalor_pago;
        private System.Windows.Forms.TextBox txtacompanhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pagamento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acompanhamento;
    }
}