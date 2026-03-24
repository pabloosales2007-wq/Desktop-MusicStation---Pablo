namespace Telas_Desktop_MusicStation___Pablo
{
    partial class PessoasProfissionais
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
            this.dgvProfissionais = new System.Windows.Forms.DataGridView();
            this.id_cargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProfissionais = new System.Windows.Forms.Label();
            this.lblidProfissionais = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtUsuario_id = new System.Windows.Forms.TextBox();
            this.txtidUsuario = new System.Windows.Forms.TextBox();
            this.btnCadastrarProfissionais = new System.Windows.Forms.Button();
            this.btnAtualizarProfissionais = new System.Windows.Forms.Button();
            this.btnPesquisarProfissionais = new System.Windows.Forms.Button();
            this.btnDeletarProfissionais = new System.Windows.Forms.Button();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfissionais
            // 
            this.dgvProfissionais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProfissionais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfissionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cargos,
            this.nome,
            this.descricao});
            this.dgvProfissionais.Location = new System.Drawing.Point(63, 264);
            this.dgvProfissionais.Name = "dgvProfissionais";
            this.dgvProfissionais.Size = new System.Drawing.Size(344, 150);
            this.dgvProfissionais.TabIndex = 20;
            // 
            // id_cargos
            // 
            this.id_cargos.HeaderText = "ID";
            this.id_cargos.Name = "id_cargos";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // lblProfissionais
            // 
            this.lblProfissionais.AutoSize = true;
            this.lblProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblProfissionais.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblProfissionais.Location = new System.Drawing.Point(222, 25);
            this.lblProfissionais.Name = "lblProfissionais";
            this.lblProfissionais.Size = new System.Drawing.Size(220, 37);
            this.lblProfissionais.TabIndex = 22;
            this.lblProfissionais.Text = "Profissionais";
            // 
            // lblidProfissionais
            // 
            this.lblidProfissionais.AutoSize = true;
            this.lblidProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblidProfissionais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidProfissionais.ForeColor = System.Drawing.Color.White;
            this.lblidProfissionais.Location = new System.Drawing.Point(59, 79);
            this.lblidProfissionais.Name = "lblidProfissionais";
            this.lblidProfissionais.Size = new System.Drawing.Size(109, 16);
            this.lblidProfissionais.TabIndex = 29;
            this.lblidProfissionais.Text = "Id_profissionais:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(59, 160);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(66, 16);
            this.lblDescricao.TabIndex = 35;
            this.lblDescricao.Text = "Telefone:";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblidUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidUsuario.ForeColor = System.Drawing.Color.White;
            this.lblidUsuario.Location = new System.Drawing.Point(59, 118);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(73, 16);
            this.lblidUsuario.TabIndex = 34;
            this.lblidUsuario.Text = "usuario_id";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.Location = new System.Drawing.Point(62, 179);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(186, 20);
            this.txtTelefone.TabIndex = 33;
            // 
            // txtUsuario_id
            // 
            this.txtUsuario_id.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario_id.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario_id.Location = new System.Drawing.Point(62, 137);
            this.txtUsuario_id.Name = "txtUsuario_id";
            this.txtUsuario_id.Size = new System.Drawing.Size(186, 20);
            this.txtUsuario_id.TabIndex = 32;
            // 
            // txtidUsuario
            // 
            this.txtidUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtidUsuario.Location = new System.Drawing.Point(62, 95);
            this.txtidUsuario.Name = "txtidUsuario";
            this.txtidUsuario.Size = new System.Drawing.Size(64, 20);
            this.txtidUsuario.TabIndex = 31;
            // 
            // btnCadastrarProfissionais
            // 
            this.btnCadastrarProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarProfissionais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProfissionais.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarProfissionais.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarProfissionais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarProfissionais.Name = "btnCadastrarProfissionais";
            this.btnCadastrarProfissionais.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarProfissionais.TabIndex = 36;
            this.btnCadastrarProfissionais.Text = "Cadastrar";
            this.btnCadastrarProfissionais.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarProfissionais
            // 
            this.btnAtualizarProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarProfissionais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProfissionais.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarProfissionais.Location = new System.Drawing.Point(534, 137);
            this.btnAtualizarProfissionais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarProfissionais.Name = "btnAtualizarProfissionais";
            this.btnAtualizarProfissionais.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarProfissionais.TabIndex = 39;
            this.btnAtualizarProfissionais.Text = "Atualizar";
            this.btnAtualizarProfissionais.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarProfissionais
            // 
            this.btnPesquisarProfissionais.BackColor = System.Drawing.Color.White;
            this.btnPesquisarProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarProfissionais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProfissionais.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarProfissionais.Location = new System.Drawing.Point(534, 95);
            this.btnPesquisarProfissionais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarProfissionais.Name = "btnPesquisarProfissionais";
            this.btnPesquisarProfissionais.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarProfissionais.TabIndex = 38;
            this.btnPesquisarProfissionais.Text = "Pesquisar";
            this.btnPesquisarProfissionais.UseVisualStyleBackColor = false;
            // 
            // btnDeletarProfissionais
            // 
            this.btnDeletarProfissionais.BackColor = System.Drawing.Color.Red;
            this.btnDeletarProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarProfissionais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarProfissionais.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarProfissionais.Location = new System.Drawing.Point(438, 137);
            this.btnDeletarProfissionais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarProfissionais.Name = "btnDeletarProfissionais";
            this.btnDeletarProfissionais.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarProfissionais.TabIndex = 37;
            this.btnDeletarProfissionais.Text = "Deletar";
            this.btnDeletarProfissionais.UseVisualStyleBackColor = false;
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 21;
            this.pictureBoxFundo.TabStop = false;
            // 
            // PessoasProfissionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.btnAtualizarProfissionais);
            this.Controls.Add(this.btnPesquisarProfissionais);
            this.Controls.Add(this.btnDeletarProfissionais);
            this.Controls.Add(this.btnCadastrarProfissionais);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblidUsuario);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtUsuario_id);
            this.Controls.Add(this.txtidUsuario);
            this.Controls.Add(this.lblidProfissionais);
            this.Controls.Add(this.lblProfissionais);
            this.Controls.Add(this.dgvProfissionais);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PessoasProfissionais";
            this.Text = "PessoasProfissionais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfissionais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblProfissionais;
        private System.Windows.Forms.Label lblidProfissionais;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtUsuario_id;
        private System.Windows.Forms.TextBox txtidUsuario;
        private System.Windows.Forms.Button btnCadastrarProfissionais;
        private System.Windows.Forms.Button btnAtualizarProfissionais;
        private System.Windows.Forms.Button btnPesquisarProfissionais;
        private System.Windows.Forms.Button btnDeletarProfissionais;
    }
}