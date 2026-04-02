namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormMensagensChats
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
            this.lblChats = new System.Windows.Forms.Label();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            this.btnCadastrarChat = new System.Windows.Forms.Button();
            this.btnAtualizarChat = new System.Windows.Forms.Button();
            this.btnPesquisarChat = new System.Windows.Forms.Button();
            this.btnDeletarChat = new System.Windows.Forms.Button();
            this.lblid_chat = new System.Windows.Forms.Label();
            this.lblusuario1_id = new System.Windows.Forms.Label();
            this.lblusuario2_id = new System.Windows.Forms.Label();
            this.lbldata_criacao = new System.Windows.Forms.Label();
            this.txtdata_criacao = new System.Windows.Forms.TextBox();
            this.txtusuario1_id = new System.Windows.Forms.TextBox();
            this.txtusuario2_id = new System.Windows.Forms.TextBox();
            this.txtdatacriacao = new System.Windows.Forms.TextBox();
            this.dgvChats = new System.Windows.Forms.DataGridView();
            this.id_chat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario1_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario2_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChats
            // 
            this.lblChats.AutoSize = true;
            this.lblChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblChats.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblChats.Location = new System.Drawing.Point(279, 25);
            this.lblChats.Name = "lblChats";
            this.lblChats.Size = new System.Drawing.Size(106, 37);
            this.lblChats.TabIndex = 28;
            this.lblChats.Text = "Chats";
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
            // btnCadastrarChat
            // 
            this.btnCadastrarChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarChat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarChat.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarChat.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarChat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarChat.Name = "btnCadastrarChat";
            this.btnCadastrarChat.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarChat.TabIndex = 67;
            this.btnCadastrarChat.Text = "Cadastrar";
            this.btnCadastrarChat.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarChat
            // 
            this.btnAtualizarChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarChat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarChat.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarChat.Location = new System.Drawing.Point(534, 133);
            this.btnAtualizarChat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarChat.Name = "btnAtualizarChat";
            this.btnAtualizarChat.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarChat.TabIndex = 75;
            this.btnAtualizarChat.Text = "Atualizar";
            this.btnAtualizarChat.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarChat
            // 
            this.btnPesquisarChat.BackColor = System.Drawing.Color.White;
            this.btnPesquisarChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarChat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarChat.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarChat.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarChat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarChat.Name = "btnPesquisarChat";
            this.btnPesquisarChat.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarChat.TabIndex = 74;
            this.btnPesquisarChat.Text = "Pesquisar";
            this.btnPesquisarChat.UseVisualStyleBackColor = false;
            // 
            // btnDeletarChat
            // 
            this.btnDeletarChat.BackColor = System.Drawing.Color.Red;
            this.btnDeletarChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarChat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarChat.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarChat.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarChat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarChat.Name = "btnDeletarChat";
            this.btnDeletarChat.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarChat.TabIndex = 73;
            this.btnDeletarChat.Text = "Deletar";
            this.btnDeletarChat.UseVisualStyleBackColor = false;
            // 
            // lblid_chat
            // 
            this.lblid_chat.AutoSize = true;
            this.lblid_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_chat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_chat.ForeColor = System.Drawing.Color.White;
            this.lblid_chat.Location = new System.Drawing.Point(60, 75);
            this.lblid_chat.Name = "lblid_chat";
            this.lblid_chat.Size = new System.Drawing.Size(57, 16);
            this.lblid_chat.TabIndex = 76;
            this.lblid_chat.Text = "id_chat:";
            // 
            // lblusuario1_id
            // 
            this.lblusuario1_id.AutoSize = true;
            this.lblusuario1_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblusuario1_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario1_id.ForeColor = System.Drawing.Color.White;
            this.lblusuario1_id.Location = new System.Drawing.Point(123, 75);
            this.lblusuario1_id.Name = "lblusuario1_id";
            this.lblusuario1_id.Size = new System.Drawing.Size(84, 16);
            this.lblusuario1_id.TabIndex = 77;
            this.lblusuario1_id.Text = "usuario1_id:";
            // 
            // lblusuario2_id
            // 
            this.lblusuario2_id.AutoSize = true;
            this.lblusuario2_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblusuario2_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario2_id.ForeColor = System.Drawing.Color.White;
            this.lblusuario2_id.Location = new System.Drawing.Point(210, 75);
            this.lblusuario2_id.Name = "lblusuario2_id";
            this.lblusuario2_id.Size = new System.Drawing.Size(84, 16);
            this.lblusuario2_id.TabIndex = 78;
            this.lblusuario2_id.Text = "usuario2_id:";
            // 
            // lbldata_criacao
            // 
            this.lbldata_criacao.AutoSize = true;
            this.lbldata_criacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbldata_criacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata_criacao.ForeColor = System.Drawing.Color.White;
            this.lbldata_criacao.Location = new System.Drawing.Point(60, 117);
            this.lbldata_criacao.Name = "lbldata_criacao";
            this.lbldata_criacao.Size = new System.Drawing.Size(93, 16);
            this.lbldata_criacao.TabIndex = 79;
            this.lbldata_criacao.Text = "Data Criação:";
            // 
            // txtdata_criacao
            // 
            this.txtdata_criacao.Location = new System.Drawing.Point(63, 94);
            this.txtdata_criacao.Name = "txtdata_criacao";
            this.txtdata_criacao.Size = new System.Drawing.Size(54, 20);
            this.txtdata_criacao.TabIndex = 80;
            // 
            // txtusuario1_id
            // 
            this.txtusuario1_id.Location = new System.Drawing.Point(123, 94);
            this.txtusuario1_id.Name = "txtusuario1_id";
            this.txtusuario1_id.Size = new System.Drawing.Size(84, 20);
            this.txtusuario1_id.TabIndex = 81;
            // 
            // txtusuario2_id
            // 
            this.txtusuario2_id.Location = new System.Drawing.Point(213, 94);
            this.txtusuario2_id.Name = "txtusuario2_id";
            this.txtusuario2_id.Size = new System.Drawing.Size(84, 20);
            this.txtusuario2_id.TabIndex = 82;
            // 
            // txtdatacriacao
            // 
            this.txtdatacriacao.Location = new System.Drawing.Point(63, 133);
            this.txtdatacriacao.Name = "txtdatacriacao";
            this.txtdatacriacao.Size = new System.Drawing.Size(84, 20);
            this.txtdatacriacao.TabIndex = 83;
            // 
            // dgvChats
            // 
            this.dgvChats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvChats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_chat,
            this.usuario1_id,
            this.usuario2_id,
            this.data_criacao});
            this.dgvChats.Location = new System.Drawing.Point(63, 255);
            this.dgvChats.Name = "dgvChats";
            this.dgvChats.Size = new System.Drawing.Size(442, 150);
            this.dgvChats.TabIndex = 84;
            // 
            // id_chat
            // 
            this.id_chat.HeaderText = "id_chat";
            this.id_chat.Name = "id_chat";
            // 
            // usuario1_id
            // 
            this.usuario1_id.HeaderText = "usuario1_id";
            this.usuario1_id.Name = "usuario1_id";
            // 
            // usuario2_id
            // 
            this.usuario2_id.HeaderText = "usuario2_id";
            this.usuario2_id.Name = "usuario2_id";
            // 
            // data_criacao
            // 
            this.data_criacao.HeaderText = "Data Criação";
            this.data_criacao.Name = "data_criacao";
            // 
            // FormMensagensChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.dgvChats);
            this.Controls.Add(this.txtdatacriacao);
            this.Controls.Add(this.txtusuario2_id);
            this.Controls.Add(this.txtusuario1_id);
            this.Controls.Add(this.txtdata_criacao);
            this.Controls.Add(this.lbldata_criacao);
            this.Controls.Add(this.lblusuario2_id);
            this.Controls.Add(this.lblusuario1_id);
            this.Controls.Add(this.lblid_chat);
            this.Controls.Add(this.btnAtualizarChat);
            this.Controls.Add(this.btnPesquisarChat);
            this.Controls.Add(this.btnDeletarChat);
            this.Controls.Add(this.btnCadastrarChat);
            this.Controls.Add(this.lblChats);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMensagensChats";
            this.Text = "FormMensagensChats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChats;
        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Button btnCadastrarChat;
        private System.Windows.Forms.Button btnAtualizarChat;
        private System.Windows.Forms.Button btnPesquisarChat;
        private System.Windows.Forms.Button btnDeletarChat;
        private System.Windows.Forms.Label lblid_chat;
        private System.Windows.Forms.Label lblusuario1_id;
        private System.Windows.Forms.Label lblusuario2_id;
        private System.Windows.Forms.Label lbldata_criacao;
        private System.Windows.Forms.TextBox txtdata_criacao;
        private System.Windows.Forms.TextBox txtusuario1_id;
        private System.Windows.Forms.TextBox txtusuario2_id;
        private System.Windows.Forms.TextBox txtdatacriacao;
        private System.Windows.Forms.DataGridView dgvChats;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_chat;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario1_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario2_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
    }
}