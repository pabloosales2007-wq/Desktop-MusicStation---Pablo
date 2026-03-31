namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormCatalogoServicos
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
            this.lblServicos = new System.Windows.Forms.Label();
            this.lblid_servicos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtid_servico = new System.Windows.Forms.TextBox();
            this.txpreco = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.id_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrarServicos = new System.Windows.Forms.Button();
            this.btnAtualizarServicos = new System.Windows.Forms.Button();
            this.btnPesquisarServicos = new System.Windows.Forms.Button();
            this.btnDeletarServicos = new System.Windows.Forms.Button();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblServicos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblServicos.Location = new System.Drawing.Point(249, 25);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(151, 37);
            this.lblServicos.TabIndex = 25;
            this.lblServicos.Text = "Serviços";
            // 
            // lblid_servicos
            // 
            this.lblid_servicos.AutoSize = true;
            this.lblid_servicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_servicos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_servicos.ForeColor = System.Drawing.Color.White;
            this.lblid_servicos.Location = new System.Drawing.Point(60, 79);
            this.lblid_servicos.Name = "lblid_servicos";
            this.lblid_servicos.Size = new System.Drawing.Size(81, 16);
            this.lblid_servicos.TabIndex = 54;
            this.lblid_servicos.Text = "Id_servicos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPreco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(187, 79);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(44, 16);
            this.lblPreco.TabIndex = 55;
            this.lblPreco.Text = "Preço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(323, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 56;
            this.lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(60, 117);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 16);
            this.lblDescricao.TabIndex = 57;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtid_servico
            // 
            this.txtid_servico.Location = new System.Drawing.Point(63, 94);
            this.txtid_servico.Name = "txtid_servico";
            this.txtid_servico.Size = new System.Drawing.Size(100, 20);
            this.txtid_servico.TabIndex = 58;
            // 
            // txpreco
            // 
            this.txpreco.Location = new System.Drawing.Point(190, 94);
            this.txpreco.Name = "txpreco";
            this.txpreco.Size = new System.Drawing.Size(100, 20);
            this.txpreco.TabIndex = 59;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(326, 94);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 60;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(63, 133);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(100, 20);
            this.txtdescricao.TabIndex = 61;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_servico,
            this.nome,
            this.descricao,
            this.preco});
            this.dgvClientes.Location = new System.Drawing.Point(63, 264);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(443, 150);
            this.dgvClientes.TabIndex = 62;
            // 
            // id_servico
            // 
            this.id_servico.HeaderText = "id_servico";
            this.id_servico.Name = "id_servico";
            // 
            // nome
            // 
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "descricao";
            this.descricao.Name = "descricao";
            // 
            // preco
            // 
            this.preco.HeaderText = "preco";
            this.preco.Name = "preco";
            // 
            // btnCadastrarServicos
            // 
            this.btnCadastrarServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarServicos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarServicos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarServicos.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarServicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarServicos.Name = "btnCadastrarServicos";
            this.btnCadastrarServicos.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarServicos.TabIndex = 63;
            this.btnCadastrarServicos.Text = "Cadastrar";
            this.btnCadastrarServicos.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarServicos
            // 
            this.btnAtualizarServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarServicos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarServicos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarServicos.Location = new System.Drawing.Point(534, 133);
            this.btnAtualizarServicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarServicos.Name = "btnAtualizarServicos";
            this.btnAtualizarServicos.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarServicos.TabIndex = 66;
            this.btnAtualizarServicos.Text = "Atualizar";
            this.btnAtualizarServicos.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarServicos
            // 
            this.btnPesquisarServicos.BackColor = System.Drawing.Color.White;
            this.btnPesquisarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarServicos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarServicos.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarServicos.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarServicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarServicos.Name = "btnPesquisarServicos";
            this.btnPesquisarServicos.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarServicos.TabIndex = 65;
            this.btnPesquisarServicos.Text = "Pesquisar";
            this.btnPesquisarServicos.UseVisualStyleBackColor = false;
            // 
            // btnDeletarServicos
            // 
            this.btnDeletarServicos.BackColor = System.Drawing.Color.Red;
            this.btnDeletarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarServicos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarServicos.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarServicos.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarServicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarServicos.Name = "btnDeletarServicos";
            this.btnDeletarServicos.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarServicos.TabIndex = 64;
            this.btnDeletarServicos.Text = "Deletar";
            this.btnDeletarServicos.UseVisualStyleBackColor = false;
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 24;
            this.pictureBoxFundo.TabStop = false;
            // 
            // FormCatalogoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.btnAtualizarServicos);
            this.Controls.Add(this.btnPesquisarServicos);
            this.Controls.Add(this.btnDeletarServicos);
            this.Controls.Add(this.btnCadastrarServicos);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txpreco);
            this.Controls.Add(this.txtid_servico);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblid_servicos);
            this.Controls.Add(this.lblServicos);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCatalogoServicos";
            this.Text = "FormCatalogoServicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Label lblid_servicos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtid_servico;
        private System.Windows.Forms.TextBox txpreco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.Button btnCadastrarServicos;
        private System.Windows.Forms.Button btnAtualizarServicos;
        private System.Windows.Forms.Button btnPesquisarServicos;
        private System.Windows.Forms.Button btnDeletarServicos;
    }
}