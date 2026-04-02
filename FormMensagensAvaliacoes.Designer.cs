namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormMensagensAvaliacoes
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
            this.lblAvaliacoes = new System.Windows.Forms.Label();
            this.lblid_avaliacao = new System.Windows.Forms.Label();
            this.lblservico_pedido_id = new System.Windows.Forms.Label();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.lblcliente_id = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.txtid_avaliacao = new System.Windows.Forms.TextBox();
            this.txtservico_pedido_id = new System.Windows.Forms.TextBox();
            this.txtcliente_id = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.lbldata_avaliacao = new System.Windows.Forms.Label();
            this.txtdata_avaliacao = new System.Windows.Forms.TextBox();
            this.dgvAvaliacoes = new System.Windows.Forms.DataGridView();
            this.id_avaliacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico_pedido_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_avaliacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrarAvaliacoes = new System.Windows.Forms.Button();
            this.btnAtualizarAvaliacoes = new System.Windows.Forms.Button();
            this.btnPesquisarAvaliacoes = new System.Windows.Forms.Button();
            this.btnDeletarAvaliacoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 32;
            this.pictureBoxFundo.TabStop = false;
            // 
            // lblAvaliacoes
            // 
            this.lblAvaliacoes.AutoSize = true;
            this.lblAvaliacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblAvaliacoes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblAvaliacoes.Location = new System.Drawing.Point(230, 25);
            this.lblAvaliacoes.Name = "lblAvaliacoes";
            this.lblAvaliacoes.Size = new System.Drawing.Size(185, 37);
            this.lblAvaliacoes.TabIndex = 33;
            this.lblAvaliacoes.Text = "Avaliações";
            // 
            // lblid_avaliacao
            // 
            this.lblid_avaliacao.AutoSize = true;
            this.lblid_avaliacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_avaliacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_avaliacao.ForeColor = System.Drawing.Color.White;
            this.lblid_avaliacao.Location = new System.Drawing.Point(60, 75);
            this.lblid_avaliacao.Name = "lblid_avaliacao";
            this.lblid_avaliacao.Size = new System.Drawing.Size(92, 16);
            this.lblid_avaliacao.TabIndex = 79;
            this.lblid_avaliacao.Text = "id_avaliacao:";
            // 
            // lblservico_pedido_id
            // 
            this.lblservico_pedido_id.AutoSize = true;
            this.lblservico_pedido_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblservico_pedido_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservico_pedido_id.ForeColor = System.Drawing.Color.White;
            this.lblservico_pedido_id.Location = new System.Drawing.Point(182, 75);
            this.lblservico_pedido_id.Name = "lblservico_pedido_id";
            this.lblservico_pedido_id.Size = new System.Drawing.Size(126, 16);
            this.lblservico_pedido_id.TabIndex = 80;
            this.lblservico_pedido_id.Text = "servico_pedido_id:";
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblcomentario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomentario.ForeColor = System.Drawing.Color.White;
            this.lblcomentario.Location = new System.Drawing.Point(60, 157);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(85, 16);
            this.lblcomentario.TabIndex = 81;
            this.lblcomentario.Text = "Comentario:";
            // 
            // lblcliente_id
            // 
            this.lblcliente_id.AutoSize = true;
            this.lblcliente_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblcliente_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente_id.ForeColor = System.Drawing.Color.White;
            this.lblcliente_id.Location = new System.Drawing.Point(60, 115);
            this.lblcliente_id.Name = "lblcliente_id";
            this.lblcliente_id.Size = new System.Drawing.Size(73, 16);
            this.lblcliente_id.TabIndex = 82;
            this.lblcliente_id.Text = "cliente_id:";
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblnota.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.ForeColor = System.Drawing.Color.White;
            this.lblnota.Location = new System.Drawing.Point(182, 115);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(39, 16);
            this.lblnota.TabIndex = 83;
            this.lblnota.Text = "nota:";
            // 
            // txtid_avaliacao
            // 
            this.txtid_avaliacao.Location = new System.Drawing.Point(63, 95);
            this.txtid_avaliacao.Name = "txtid_avaliacao";
            this.txtid_avaliacao.Size = new System.Drawing.Size(100, 20);
            this.txtid_avaliacao.TabIndex = 84;
            // 
            // txtservico_pedido_id
            // 
            this.txtservico_pedido_id.Location = new System.Drawing.Point(185, 95);
            this.txtservico_pedido_id.Name = "txtservico_pedido_id";
            this.txtservico_pedido_id.Size = new System.Drawing.Size(123, 20);
            this.txtservico_pedido_id.TabIndex = 85;
            // 
            // txtcliente_id
            // 
            this.txtcliente_id.Location = new System.Drawing.Point(63, 134);
            this.txtcliente_id.Name = "txtcliente_id";
            this.txtcliente_id.Size = new System.Drawing.Size(100, 20);
            this.txtcliente_id.TabIndex = 86;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(185, 134);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(36, 20);
            this.txtnota.TabIndex = 87;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(63, 176);
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(100, 20);
            this.txtcomentario.TabIndex = 88;
            // 
            // lbldata_avaliacao
            // 
            this.lbldata_avaliacao.AutoSize = true;
            this.lbldata_avaliacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbldata_avaliacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata_avaliacao.ForeColor = System.Drawing.Color.White;
            this.lbldata_avaliacao.Location = new System.Drawing.Point(182, 157);
            this.lbldata_avaliacao.Name = "lbldata_avaliacao";
            this.lbldata_avaliacao.Size = new System.Drawing.Size(107, 16);
            this.lbldata_avaliacao.TabIndex = 89;
            this.lbldata_avaliacao.Text = "Data Avaliação:";
            // 
            // txtdata_avaliacao
            // 
            this.txtdata_avaliacao.Location = new System.Drawing.Point(185, 176);
            this.txtdata_avaliacao.Name = "txtdata_avaliacao";
            this.txtdata_avaliacao.Size = new System.Drawing.Size(100, 20);
            this.txtdata_avaliacao.TabIndex = 90;
            // 
            // dgvAvaliacoes
            // 
            this.dgvAvaliacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAvaliacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvaliacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_avaliacao,
            this.servico_pedido_id,
            this.cliente_id,
            this.nota,
            this.comentario,
            this.data_avaliacao});
            this.dgvAvaliacoes.Location = new System.Drawing.Point(63, 255);
            this.dgvAvaliacoes.Name = "dgvAvaliacoes";
            this.dgvAvaliacoes.Size = new System.Drawing.Size(542, 150);
            this.dgvAvaliacoes.TabIndex = 96;
            // 
            // id_avaliacao
            // 
            this.id_avaliacao.HeaderText = "id_avaliacao";
            this.id_avaliacao.Name = "id_avaliacao";
            // 
            // servico_pedido_id
            // 
            this.servico_pedido_id.HeaderText = "servico_pedido_id";
            this.servico_pedido_id.Name = "servico_pedido_id";
            // 
            // cliente_id
            // 
            this.cliente_id.HeaderText = "cliente_id";
            this.cliente_id.Name = "cliente_id";
            // 
            // nota
            // 
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            // 
            // comentario
            // 
            this.comentario.HeaderText = "Comentario";
            this.comentario.Name = "comentario";
            // 
            // data_avaliacao
            // 
            this.data_avaliacao.HeaderText = "Data Avaliação";
            this.data_avaliacao.Name = "data_avaliacao";
            // 
            // btnCadastrarAvaliacoes
            // 
            this.btnCadastrarAvaliacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarAvaliacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarAvaliacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAvaliacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAvaliacoes.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarAvaliacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarAvaliacoes.Name = "btnCadastrarAvaliacoes";
            this.btnCadastrarAvaliacoes.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarAvaliacoes.TabIndex = 97;
            this.btnCadastrarAvaliacoes.Text = "Cadastrar";
            this.btnCadastrarAvaliacoes.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarAvaliacoes
            // 
            this.btnAtualizarAvaliacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarAvaliacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarAvaliacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarAvaliacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarAvaliacoes.Location = new System.Drawing.Point(534, 134);
            this.btnAtualizarAvaliacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarAvaliacoes.Name = "btnAtualizarAvaliacoes";
            this.btnAtualizarAvaliacoes.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarAvaliacoes.TabIndex = 100;
            this.btnAtualizarAvaliacoes.Text = "Atualizar";
            this.btnAtualizarAvaliacoes.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarAvaliacoes
            // 
            this.btnPesquisarAvaliacoes.BackColor = System.Drawing.Color.White;
            this.btnPesquisarAvaliacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarAvaliacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAvaliacoes.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarAvaliacoes.Location = new System.Drawing.Point(534, 95);
            this.btnPesquisarAvaliacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarAvaliacoes.Name = "btnPesquisarAvaliacoes";
            this.btnPesquisarAvaliacoes.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarAvaliacoes.TabIndex = 99;
            this.btnPesquisarAvaliacoes.Text = "Pesquisar";
            this.btnPesquisarAvaliacoes.UseVisualStyleBackColor = false;
            // 
            // btnDeletarAvaliacoes
            // 
            this.btnDeletarAvaliacoes.BackColor = System.Drawing.Color.Red;
            this.btnDeletarAvaliacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarAvaliacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarAvaliacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarAvaliacoes.Location = new System.Drawing.Point(438, 134);
            this.btnDeletarAvaliacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarAvaliacoes.Name = "btnDeletarAvaliacoes";
            this.btnDeletarAvaliacoes.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarAvaliacoes.TabIndex = 98;
            this.btnDeletarAvaliacoes.Text = "Deletar";
            this.btnDeletarAvaliacoes.UseVisualStyleBackColor = false;
            // 
            // FormMensagensAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.btnAtualizarAvaliacoes);
            this.Controls.Add(this.btnPesquisarAvaliacoes);
            this.Controls.Add(this.btnDeletarAvaliacoes);
            this.Controls.Add(this.btnCadastrarAvaliacoes);
            this.Controls.Add(this.dgvAvaliacoes);
            this.Controls.Add(this.txtdata_avaliacao);
            this.Controls.Add(this.lbldata_avaliacao);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtcliente_id);
            this.Controls.Add(this.txtservico_pedido_id);
            this.Controls.Add(this.txtid_avaliacao);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lblcliente_id);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.lblservico_pedido_id);
            this.Controls.Add(this.lblid_avaliacao);
            this.Controls.Add(this.lblAvaliacoes);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMensagensAvaliacoes";
            this.Text = "FormMensagensAvaliacoes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblAvaliacoes;
        private System.Windows.Forms.Label lblid_avaliacao;
        private System.Windows.Forms.Label lblservico_pedido_id;
        private System.Windows.Forms.Label lblcomentario;
        private System.Windows.Forms.Label lblcliente_id;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.TextBox txtid_avaliacao;
        private System.Windows.Forms.TextBox txtservico_pedido_id;
        private System.Windows.Forms.TextBox txtcliente_id;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label lbldata_avaliacao;
        private System.Windows.Forms.TextBox txtdata_avaliacao;
        private System.Windows.Forms.DataGridView dgvAvaliacoes;
        private System.Windows.Forms.Button btnCadastrarAvaliacoes;
        private System.Windows.Forms.Button btnAtualizarAvaliacoes;
        private System.Windows.Forms.Button btnPesquisarAvaliacoes;
        private System.Windows.Forms.Button btnDeletarAvaliacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_avaliacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico_pedido_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_avaliacao;
    }
}