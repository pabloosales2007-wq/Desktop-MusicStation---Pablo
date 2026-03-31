namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormMensagensNotificacoes
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
            this.lblNotificacoes = new System.Windows.Forms.Label();
            this.lblid_notificacao = new System.Windows.Forms.Label();
            this.lblusuario_id = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.lbllida = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lbldata_envio = new System.Windows.Forms.Label();
            this.txtid_notificacao = new System.Windows.Forms.TextBox();
            this.txtusuario_id = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtmensagem = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtdata_envio = new System.Windows.Forms.TextBox();
            this.txtlida = new System.Windows.Forms.TextBox();
            this.btnCadastrarNotificacoes = new System.Windows.Forms.Button();
            this.btnAtualizarNotificacoes = new System.Windows.Forms.Button();
            this.btnPesquisarNotificacoes = new System.Windows.Forms.Button();
            this.btnDeletarNotificacoes = new System.Windows.Forms.Button();
            this.dgvNotificacoes = new System.Windows.Forms.DataGridView();
            this.id_notificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 31;
            this.pictureBoxFundo.TabStop = false;
            // 
            // lblNotificacoes
            // 
            this.lblNotificacoes.AutoSize = true;
            this.lblNotificacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblNotificacoes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblNotificacoes.Location = new System.Drawing.Point(235, 23);
            this.lblNotificacoes.Name = "lblNotificacoes";
            this.lblNotificacoes.Size = new System.Drawing.Size(209, 37);
            this.lblNotificacoes.TabIndex = 32;
            this.lblNotificacoes.Text = "Notificações";
            // 
            // lblid_notificacao
            // 
            this.lblid_notificacao.AutoSize = true;
            this.lblid_notificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_notificacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_notificacao.ForeColor = System.Drawing.Color.White;
            this.lblid_notificacao.Location = new System.Drawing.Point(60, 75);
            this.lblid_notificacao.Name = "lblid_notificacao";
            this.lblid_notificacao.Size = new System.Drawing.Size(100, 16);
            this.lblid_notificacao.TabIndex = 78;
            this.lblid_notificacao.Text = "id_notificacao:";
            // 
            // lblusuario_id
            // 
            this.lblusuario_id.AutoSize = true;
            this.lblusuario_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblusuario_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario_id.ForeColor = System.Drawing.Color.White;
            this.lblusuario_id.Location = new System.Drawing.Point(169, 75);
            this.lblusuario_id.Name = "lblusuario_id";
            this.lblusuario_id.Size = new System.Drawing.Size(77, 16);
            this.lblusuario_id.TabIndex = 79;
            this.lblusuario_id.Text = "usuario_id:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbltitulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(275, 75);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(47, 16);
            this.lbltitulo.TabIndex = 80;
            this.lbltitulo.Text = "Titulo:";
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblmensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.ForeColor = System.Drawing.Color.White;
            this.lblmensagem.Location = new System.Drawing.Point(60, 118);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(80, 16);
            this.lblmensagem.TabIndex = 81;
            this.lblmensagem.Text = "Mensagem:";
            // 
            // lbllida
            // 
            this.lbllida.AutoSize = true;
            this.lbllida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbllida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllida.ForeColor = System.Drawing.Color.White;
            this.lbllida.Location = new System.Drawing.Point(60, 157);
            this.lbllida.Name = "lbllida";
            this.lbllida.Size = new System.Drawing.Size(39, 16);
            this.lbllida.TabIndex = 82;
            this.lbllida.Text = "Lida:";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbltipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.Color.White;
            this.lbltipo.Location = new System.Drawing.Point(169, 118);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(39, 16);
            this.lbltipo.TabIndex = 82;
            this.lbltipo.Text = "Tipo:";
            // 
            // lbldata_envio
            // 
            this.lbldata_envio.AutoSize = true;
            this.lbldata_envio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbldata_envio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata_envio.ForeColor = System.Drawing.Color.White;
            this.lbldata_envio.Location = new System.Drawing.Point(275, 117);
            this.lbldata_envio.Name = "lbldata_envio";
            this.lbldata_envio.Size = new System.Drawing.Size(79, 16);
            this.lbldata_envio.TabIndex = 83;
            this.lbldata_envio.Text = "Data Envio:";
            // 
            // txtid_notificacao
            // 
            this.txtid_notificacao.Location = new System.Drawing.Point(63, 95);
            this.txtid_notificacao.Name = "txtid_notificacao";
            this.txtid_notificacao.Size = new System.Drawing.Size(100, 20);
            this.txtid_notificacao.TabIndex = 84;
            // 
            // txtusuario_id
            // 
            this.txtusuario_id.Location = new System.Drawing.Point(169, 94);
            this.txtusuario_id.Name = "txtusuario_id";
            this.txtusuario_id.Size = new System.Drawing.Size(100, 20);
            this.txtusuario_id.TabIndex = 85;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(275, 94);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(100, 20);
            this.txttitulo.TabIndex = 86;
            // 
            // txtmensagem
            // 
            this.txtmensagem.Location = new System.Drawing.Point(63, 134);
            this.txtmensagem.Name = "txtmensagem";
            this.txtmensagem.Size = new System.Drawing.Size(100, 20);
            this.txtmensagem.TabIndex = 87;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(169, 134);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 88;
            // 
            // txtdata_envio
            // 
            this.txtdata_envio.Location = new System.Drawing.Point(275, 134);
            this.txtdata_envio.Name = "txtdata_envio";
            this.txtdata_envio.Size = new System.Drawing.Size(100, 20);
            this.txtdata_envio.TabIndex = 89;
            // 
            // txtlida
            // 
            this.txtlida.Location = new System.Drawing.Point(63, 176);
            this.txtlida.Name = "txtlida";
            this.txtlida.Size = new System.Drawing.Size(100, 20);
            this.txtlida.TabIndex = 90;
            // 
            // btnCadastrarNotificacoes
            // 
            this.btnCadastrarNotificacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarNotificacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNotificacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarNotificacoes.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarNotificacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarNotificacoes.Name = "btnCadastrarNotificacoes";
            this.btnCadastrarNotificacoes.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarNotificacoes.TabIndex = 91;
            this.btnCadastrarNotificacoes.Text = "Cadastrar";
            this.btnCadastrarNotificacoes.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarNotificacoes
            // 
            this.btnAtualizarNotificacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarNotificacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarNotificacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarNotificacoes.Location = new System.Drawing.Point(534, 134);
            this.btnAtualizarNotificacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarNotificacoes.Name = "btnAtualizarNotificacoes";
            this.btnAtualizarNotificacoes.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarNotificacoes.TabIndex = 94;
            this.btnAtualizarNotificacoes.Text = "Atualizar";
            this.btnAtualizarNotificacoes.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarNotificacoes
            // 
            this.btnPesquisarNotificacoes.BackColor = System.Drawing.Color.White;
            this.btnPesquisarNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarNotificacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarNotificacoes.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarNotificacoes.Location = new System.Drawing.Point(534, 95);
            this.btnPesquisarNotificacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarNotificacoes.Name = "btnPesquisarNotificacoes";
            this.btnPesquisarNotificacoes.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarNotificacoes.TabIndex = 93;
            this.btnPesquisarNotificacoes.Text = "Pesquisar";
            this.btnPesquisarNotificacoes.UseVisualStyleBackColor = false;
            // 
            // btnDeletarNotificacoes
            // 
            this.btnDeletarNotificacoes.BackColor = System.Drawing.Color.Red;
            this.btnDeletarNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarNotificacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarNotificacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarNotificacoes.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarNotificacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarNotificacoes.Name = "btnDeletarNotificacoes";
            this.btnDeletarNotificacoes.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarNotificacoes.TabIndex = 92;
            this.btnDeletarNotificacoes.Text = "Deletar";
            this.btnDeletarNotificacoes.UseVisualStyleBackColor = false;
            // 
            // dgvNotificacoes
            // 
            this.dgvNotificacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvNotificacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNotificacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_notificacao,
            this.usuario_id,
            this.titulo,
            this.mensagem,
            this.tipo,
            this.data_envio,
            this.lida});
            this.dgvNotificacoes.Location = new System.Drawing.Point(63, 255);
            this.dgvNotificacoes.Name = "dgvNotificacoes";
            this.dgvNotificacoes.Size = new System.Drawing.Size(542, 150);
            this.dgvNotificacoes.TabIndex = 95;
            // 
            // id_notificacao
            // 
            this.id_notificacao.HeaderText = "id_notificacao";
            this.id_notificacao.Name = "id_notificacao";
            // 
            // usuario_id
            // 
            this.usuario_id.HeaderText = "usuario_id";
            this.usuario_id.Name = "usuario_id";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            // 
            // mensagem
            // 
            this.mensagem.HeaderText = "Mensagem";
            this.mensagem.Name = "mensagem";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // data_envio
            // 
            this.data_envio.HeaderText = "Data Envio";
            this.data_envio.Name = "data_envio";
            // 
            // lida
            // 
            this.lida.HeaderText = "Lida";
            this.lida.Name = "lida";
            // 
            // FormMensagensNotificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.dgvNotificacoes);
            this.Controls.Add(this.btnAtualizarNotificacoes);
            this.Controls.Add(this.btnPesquisarNotificacoes);
            this.Controls.Add(this.btnDeletarNotificacoes);
            this.Controls.Add(this.btnCadastrarNotificacoes);
            this.Controls.Add(this.txtlida);
            this.Controls.Add(this.txtdata_envio);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtmensagem);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.txtusuario_id);
            this.Controls.Add(this.txtid_notificacao);
            this.Controls.Add(this.lbldata_envio);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lbllida);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblusuario_id);
            this.Controls.Add(this.lblid_notificacao);
            this.Controls.Add(this.lblNotificacoes);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMensagensNotificacoes";
            this.Text = "FormMensagensNotificacoes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblNotificacoes;
        private System.Windows.Forms.Label lblid_notificacao;
        private System.Windows.Forms.Label lblusuario_id;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Label lbllida;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lbldata_envio;
        private System.Windows.Forms.TextBox txtid_notificacao;
        private System.Windows.Forms.TextBox txtusuario_id;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtmensagem;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtdata_envio;
        private System.Windows.Forms.TextBox txtlida;
        private System.Windows.Forms.Button btnCadastrarNotificacoes;
        private System.Windows.Forms.Button btnAtualizarNotificacoes;
        private System.Windows.Forms.Button btnPesquisarNotificacoes;
        private System.Windows.Forms.Button btnDeletarNotificacoes;
        private System.Windows.Forms.DataGridView dgvNotificacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_notificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn lida;
    }
}