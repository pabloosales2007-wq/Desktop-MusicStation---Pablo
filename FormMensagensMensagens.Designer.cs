namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormMensagensMensagens
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
            this.lblMensagens = new System.Windows.Forms.Label();
            this.lblid_mensagem = new System.Windows.Forms.Label();
            this.txtid_mensagem = new System.Windows.Forms.TextBox();
            this.lblchat_id = new System.Windows.Forms.Label();
            this.lblremetente_id = new System.Windows.Forms.Label();
            this.txtchat_id = new System.Windows.Forms.TextBox();
            this.txtremente_id = new System.Windows.Forms.TextBox();
            this.btnCadastrarMensagem = new System.Windows.Forms.Button();
            this.btnAtualizarMensagem = new System.Windows.Forms.Button();
            this.btnPesquisarMensagem = new System.Windows.Forms.Button();
            this.btnDeletarMensagem = new System.Windows.Forms.Button();
            this.lblconteudo = new System.Windows.Forms.Label();
            this.lbldata_envio = new System.Windows.Forms.Label();
            this.lbllida = new System.Windows.Forms.Label();
            this.txtconteudo = new System.Windows.Forms.TextBox();
            this.txtdata_envio = new System.Windows.Forms.TextBox();
            this.txtLida = new System.Windows.Forms.TextBox();
            this.dgvMensagens = new System.Windows.Forms.DataGridView();
            this.id_mensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remetente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conteudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensagens)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 30;
            this.pictureBoxFundo.TabStop = false;
            // 
            // lblMensagens
            // 
            this.lblMensagens.AutoSize = true;
            this.lblMensagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblMensagens.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblMensagens.Location = new System.Drawing.Point(235, 23);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(191, 37);
            this.lblMensagens.TabIndex = 31;
            this.lblMensagens.Text = "Mensagens";
            // 
            // lblid_mensagem
            // 
            this.lblid_mensagem.AutoSize = true;
            this.lblid_mensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_mensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_mensagem.ForeColor = System.Drawing.Color.White;
            this.lblid_mensagem.Location = new System.Drawing.Point(60, 75);
            this.lblid_mensagem.Name = "lblid_mensagem";
            this.lblid_mensagem.Size = new System.Drawing.Size(100, 16);
            this.lblid_mensagem.TabIndex = 77;
            this.lblid_mensagem.Text = "id_mensagem:";
            // 
            // txtid_mensagem
            // 
            this.txtid_mensagem.Location = new System.Drawing.Point(63, 95);
            this.txtid_mensagem.Name = "txtid_mensagem";
            this.txtid_mensagem.Size = new System.Drawing.Size(97, 20);
            this.txtid_mensagem.TabIndex = 78;
            // 
            // lblchat_id
            // 
            this.lblchat_id.AutoSize = true;
            this.lblchat_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblchat_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchat_id.ForeColor = System.Drawing.Color.White;
            this.lblchat_id.Location = new System.Drawing.Point(166, 75);
            this.lblchat_id.Name = "lblchat_id";
            this.lblchat_id.Size = new System.Drawing.Size(57, 16);
            this.lblchat_id.TabIndex = 79;
            this.lblchat_id.Text = "chat_id:";
            // 
            // lblremetente_id
            // 
            this.lblremetente_id.AutoSize = true;
            this.lblremetente_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblremetente_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremetente_id.ForeColor = System.Drawing.Color.White;
            this.lblremetente_id.Location = new System.Drawing.Point(229, 75);
            this.lblremetente_id.Name = "lblremetente_id";
            this.lblremetente_id.Size = new System.Drawing.Size(95, 16);
            this.lblremetente_id.TabIndex = 80;
            this.lblremetente_id.Text = "remetente_id:";
            // 
            // txtchat_id
            // 
            this.txtchat_id.Location = new System.Drawing.Point(166, 94);
            this.txtchat_id.Name = "txtchat_id";
            this.txtchat_id.Size = new System.Drawing.Size(54, 20);
            this.txtchat_id.TabIndex = 81;
            // 
            // txtremente_id
            // 
            this.txtremente_id.Location = new System.Drawing.Point(229, 94);
            this.txtremente_id.Name = "txtremente_id";
            this.txtremente_id.Size = new System.Drawing.Size(95, 20);
            this.txtremente_id.TabIndex = 82;
            // 
            // btnCadastrarMensagem
            // 
            this.btnCadastrarMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMensagem.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarMensagem.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarMensagem.Name = "btnCadastrarMensagem";
            this.btnCadastrarMensagem.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarMensagem.TabIndex = 83;
            this.btnCadastrarMensagem.Text = "Cadastrar";
            this.btnCadastrarMensagem.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarMensagem
            // 
            this.btnAtualizarMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarMensagem.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarMensagem.Location = new System.Drawing.Point(534, 134);
            this.btnAtualizarMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarMensagem.Name = "btnAtualizarMensagem";
            this.btnAtualizarMensagem.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarMensagem.TabIndex = 86;
            this.btnAtualizarMensagem.Text = "Atualizar";
            this.btnAtualizarMensagem.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarMensagem
            // 
            this.btnPesquisarMensagem.BackColor = System.Drawing.Color.White;
            this.btnPesquisarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarMensagem.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarMensagem.Location = new System.Drawing.Point(534, 95);
            this.btnPesquisarMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarMensagem.Name = "btnPesquisarMensagem";
            this.btnPesquisarMensagem.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarMensagem.TabIndex = 85;
            this.btnPesquisarMensagem.Text = "Pesquisar";
            this.btnPesquisarMensagem.UseVisualStyleBackColor = false;
            // 
            // btnDeletarMensagem
            // 
            this.btnDeletarMensagem.BackColor = System.Drawing.Color.Red;
            this.btnDeletarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarMensagem.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarMensagem.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarMensagem.Name = "btnDeletarMensagem";
            this.btnDeletarMensagem.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarMensagem.TabIndex = 84;
            this.btnDeletarMensagem.Text = "Deletar";
            this.btnDeletarMensagem.UseVisualStyleBackColor = false;
            // 
            // lblconteudo
            // 
            this.lblconteudo.AutoSize = true;
            this.lblconteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblconteudo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconteudo.ForeColor = System.Drawing.Color.White;
            this.lblconteudo.Location = new System.Drawing.Point(60, 118);
            this.lblconteudo.Name = "lblconteudo";
            this.lblconteudo.Size = new System.Drawing.Size(72, 16);
            this.lblconteudo.TabIndex = 87;
            this.lblconteudo.Text = "Conteudo:";
            // 
            // lbldata_envio
            // 
            this.lbldata_envio.AutoSize = true;
            this.lbldata_envio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbldata_envio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata_envio.ForeColor = System.Drawing.Color.White;
            this.lbldata_envio.Location = new System.Drawing.Point(141, 118);
            this.lbldata_envio.Name = "lbldata_envio";
            this.lbldata_envio.Size = new System.Drawing.Size(79, 16);
            this.lbldata_envio.TabIndex = 88;
            this.lbldata_envio.Text = "Data Envio:";
            // 
            // lbllida
            // 
            this.lbllida.AutoSize = true;
            this.lbllida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbllida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllida.ForeColor = System.Drawing.Color.White;
            this.lbllida.Location = new System.Drawing.Point(229, 118);
            this.lbllida.Name = "lbllida";
            this.lbllida.Size = new System.Drawing.Size(39, 16);
            this.lbllida.TabIndex = 89;
            this.lbllida.Text = "Lida:";
            // 
            // txtconteudo
            // 
            this.txtconteudo.Location = new System.Drawing.Point(63, 134);
            this.txtconteudo.Name = "txtconteudo";
            this.txtconteudo.Size = new System.Drawing.Size(69, 20);
            this.txtconteudo.TabIndex = 90;
            // 
            // txtdata_envio
            // 
            this.txtdata_envio.Location = new System.Drawing.Point(144, 134);
            this.txtdata_envio.Name = "txtdata_envio";
            this.txtdata_envio.Size = new System.Drawing.Size(76, 20);
            this.txtdata_envio.TabIndex = 91;
            // 
            // txtLida
            // 
            this.txtLida.Location = new System.Drawing.Point(229, 133);
            this.txtLida.Name = "txtLida";
            this.txtLida.Size = new System.Drawing.Size(76, 20);
            this.txtLida.TabIndex = 92;
            // 
            // dgvMensagens
            // 
            this.dgvMensagens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMensagens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMensagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mensagem,
            this.chat_id,
            this.remetente_id,
            this.conteudo,
            this.data_envio,
            this.lida});
            this.dgvMensagens.Location = new System.Drawing.Point(63, 255);
            this.dgvMensagens.Name = "dgvMensagens";
            this.dgvMensagens.Size = new System.Drawing.Size(542, 150);
            this.dgvMensagens.TabIndex = 93;
            // 
            // id_mensagem
            // 
            this.id_mensagem.HeaderText = "id_mensagem";
            this.id_mensagem.Name = "id_mensagem";
            // 
            // chat_id
            // 
            this.chat_id.HeaderText = "chat_id";
            this.chat_id.Name = "chat_id";
            // 
            // remetente_id
            // 
            this.remetente_id.HeaderText = "remetente_id";
            this.remetente_id.Name = "remetente_id";
            // 
            // conteudo
            // 
            this.conteudo.HeaderText = "conteudo";
            this.conteudo.Name = "conteudo";
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
            // FormMensagensMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.dgvMensagens);
            this.Controls.Add(this.txtLida);
            this.Controls.Add(this.txtdata_envio);
            this.Controls.Add(this.txtconteudo);
            this.Controls.Add(this.lbllida);
            this.Controls.Add(this.lbldata_envio);
            this.Controls.Add(this.lblconteudo);
            this.Controls.Add(this.btnAtualizarMensagem);
            this.Controls.Add(this.btnPesquisarMensagem);
            this.Controls.Add(this.btnDeletarMensagem);
            this.Controls.Add(this.btnCadastrarMensagem);
            this.Controls.Add(this.txtremente_id);
            this.Controls.Add(this.txtchat_id);
            this.Controls.Add(this.lblremetente_id);
            this.Controls.Add(this.lblchat_id);
            this.Controls.Add(this.txtid_mensagem);
            this.Controls.Add(this.lblid_mensagem);
            this.Controls.Add(this.lblMensagens);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMensagensMensagens";
            this.Text = "FormMensagensMensagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblMensagens;
        private System.Windows.Forms.Label lblid_mensagem;
        private System.Windows.Forms.TextBox txtid_mensagem;
        private System.Windows.Forms.Label lblchat_id;
        private System.Windows.Forms.Label lblremetente_id;
        private System.Windows.Forms.TextBox txtchat_id;
        private System.Windows.Forms.TextBox txtremente_id;
        private System.Windows.Forms.Button btnCadastrarMensagem;
        private System.Windows.Forms.Button btnAtualizarMensagem;
        private System.Windows.Forms.Button btnPesquisarMensagem;
        private System.Windows.Forms.Button btnDeletarMensagem;
        private System.Windows.Forms.Label lblconteudo;
        private System.Windows.Forms.Label lbldata_envio;
        private System.Windows.Forms.Label lbllida;
        private System.Windows.Forms.TextBox txtconteudo;
        private System.Windows.Forms.TextBox txtdata_envio;
        private System.Windows.Forms.TextBox txtLida;
        private System.Windows.Forms.DataGridView dgvMensagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn chat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn remetente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn conteudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn lida;
    }
}