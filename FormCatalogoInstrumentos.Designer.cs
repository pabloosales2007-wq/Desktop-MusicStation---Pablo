namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormCatalogoInstrumentos
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
            this.lblInstrumentos = new System.Windows.Forms.Label();
            this.lblid_instrumentos = new System.Windows.Forms.Label();
            this.lblempresa_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPrecoLocacao = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.txtid_instrumento = new System.Windows.Forms.TextBox();
            this.txtempresa_id = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtpreco_locacao = new System.Windows.Forms.TextBox();
            this.txtdisponivel = new System.Windows.Forms.TextBox();
            this.dgvInstrumentos = new System.Windows.Forms.DataGridView();
            this.id_instrumentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_locacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrarInstrumentos = new System.Windows.Forms.Button();
            this.btnAtualizarInstrumentos = new System.Windows.Forms.Button();
            this.btnPesquisarInstrumentos = new System.Windows.Forms.Button();
            this.btnDeletarInstrumentos = new System.Windows.Forms.Button();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstrumentos
            // 
            this.lblInstrumentos.AutoSize = true;
            this.lblInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblInstrumentos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblInstrumentos.Location = new System.Drawing.Point(222, 26);
            this.lblInstrumentos.Name = "lblInstrumentos";
            this.lblInstrumentos.Size = new System.Drawing.Size(218, 37);
            this.lblInstrumentos.TabIndex = 25;
            this.lblInstrumentos.Text = "Instrumentos";
            // 
            // lblid_instrumentos
            // 
            this.lblid_instrumentos.AutoSize = true;
            this.lblid_instrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_instrumentos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_instrumentos.ForeColor = System.Drawing.Color.White;
            this.lblid_instrumentos.Location = new System.Drawing.Point(60, 79);
            this.lblid_instrumentos.Name = "lblid_instrumentos";
            this.lblid_instrumentos.Size = new System.Drawing.Size(111, 16);
            this.lblid_instrumentos.TabIndex = 54;
            this.lblid_instrumentos.Text = "Id_instrumentos:\r\n";
            // 
            // lblempresa_id
            // 
            this.lblempresa_id.AutoSize = true;
            this.lblempresa_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblempresa_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempresa_id.ForeColor = System.Drawing.Color.White;
            this.lblempresa_id.Location = new System.Drawing.Point(176, 79);
            this.lblempresa_id.Name = "lblempresa_id";
            this.lblempresa_id.Size = new System.Drawing.Size(85, 16);
            this.lblempresa_id.TabIndex = 55;
            this.lblempresa_id.Text = "empresa_id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(60, 126);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 16);
            this.lblDescricao.TabIndex = 57;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblPrecoLocacao
            // 
            this.lblPrecoLocacao.AutoSize = true;
            this.lblPrecoLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPrecoLocacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLocacao.ForeColor = System.Drawing.Color.White;
            this.lblPrecoLocacao.Location = new System.Drawing.Point(60, 168);
            this.lblPrecoLocacao.Name = "lblPrecoLocacao";
            this.lblPrecoLocacao.Size = new System.Drawing.Size(106, 16);
            this.lblPrecoLocacao.TabIndex = 58;
            this.lblPrecoLocacao.Text = "Preço Locação:";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDisponivel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponivel.ForeColor = System.Drawing.Color.White;
            this.lblDisponivel.Location = new System.Drawing.Point(176, 168);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(77, 16);
            this.lblDisponivel.TabIndex = 59;
            this.lblDisponivel.Text = "Disponível:";
            // 
            // txtid_instrumento
            // 
            this.txtid_instrumento.Location = new System.Drawing.Point(63, 99);
            this.txtid_instrumento.Name = "txtid_instrumento";
            this.txtid_instrumento.Size = new System.Drawing.Size(97, 20);
            this.txtid_instrumento.TabIndex = 60;
            // 
            // txtempresa_id
            // 
            this.txtempresa_id.Location = new System.Drawing.Point(179, 98);
            this.txtempresa_id.Name = "txtempresa_id";
            this.txtempresa_id.Size = new System.Drawing.Size(70, 20);
            this.txtempresa_id.TabIndex = 61;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(268, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(70, 20);
            this.txtNome.TabIndex = 62;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(63, 145);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(275, 20);
            this.txtDescricao.TabIndex = 63;
            // 
            // txtpreco_locacao
            // 
            this.txtpreco_locacao.Location = new System.Drawing.Point(63, 187);
            this.txtpreco_locacao.Name = "txtpreco_locacao";
            this.txtpreco_locacao.Size = new System.Drawing.Size(70, 20);
            this.txtpreco_locacao.TabIndex = 64;
            // 
            // txtdisponivel
            // 
            this.txtdisponivel.Location = new System.Drawing.Point(179, 187);
            this.txtdisponivel.Name = "txtdisponivel";
            this.txtdisponivel.Size = new System.Drawing.Size(70, 20);
            this.txtdisponivel.TabIndex = 65;
            // 
            // dgvInstrumentos
            // 
            this.dgvInstrumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInstrumentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_instrumentos,
            this.empresa_id,
            this.Nome,
            this.Descricao,
            this.preco_locacao,
            this.Disponivel});
            this.dgvInstrumentos.Location = new System.Drawing.Point(63, 264);
            this.dgvInstrumentos.Name = "dgvInstrumentos";
            this.dgvInstrumentos.Size = new System.Drawing.Size(543, 150);
            this.dgvInstrumentos.TabIndex = 66;
            // 
            // id_instrumentos
            // 
            this.id_instrumentos.HeaderText = "id_instrumentos";
            this.id_instrumentos.Name = "id_instrumentos";
            // 
            // empresa_id
            // 
            this.empresa_id.HeaderText = "empresa_id";
            this.empresa_id.Name = "empresa_id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // preco_locacao
            // 
            this.preco_locacao.HeaderText = "Preço Locação";
            this.preco_locacao.Name = "preco_locacao";
            // 
            // Disponivel
            // 
            this.Disponivel.HeaderText = "Disponivel";
            this.Disponivel.Name = "Disponivel";
            // 
            // btnCadastrarInstrumentos
            // 
            this.btnCadastrarInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarInstrumentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarInstrumentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarInstrumentos.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarInstrumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarInstrumentos.Name = "btnCadastrarInstrumentos";
            this.btnCadastrarInstrumentos.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarInstrumentos.TabIndex = 67;
            this.btnCadastrarInstrumentos.Text = "Cadastrar";
            this.btnCadastrarInstrumentos.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarInstrumentos
            // 
            this.btnAtualizarInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarInstrumentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarInstrumentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarInstrumentos.Location = new System.Drawing.Point(534, 134);
            this.btnAtualizarInstrumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarInstrumentos.Name = "btnAtualizarInstrumentos";
            this.btnAtualizarInstrumentos.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarInstrumentos.TabIndex = 70;
            this.btnAtualizarInstrumentos.Text = "Atualizar";
            this.btnAtualizarInstrumentos.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarInstrumentos
            // 
            this.btnPesquisarInstrumentos.BackColor = System.Drawing.Color.White;
            this.btnPesquisarInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarInstrumentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarInstrumentos.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarInstrumentos.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarInstrumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarInstrumentos.Name = "btnPesquisarInstrumentos";
            this.btnPesquisarInstrumentos.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarInstrumentos.TabIndex = 69;
            this.btnPesquisarInstrumentos.Text = "Pesquisar";
            this.btnPesquisarInstrumentos.UseVisualStyleBackColor = false;
            // 
            // btnDeletarInstrumentos
            // 
            this.btnDeletarInstrumentos.BackColor = System.Drawing.Color.Red;
            this.btnDeletarInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarInstrumentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarInstrumentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarInstrumentos.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarInstrumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarInstrumentos.Name = "btnDeletarInstrumentos";
            this.btnDeletarInstrumentos.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarInstrumentos.TabIndex = 68;
            this.btnDeletarInstrumentos.Text = "Deletar";
            this.btnDeletarInstrumentos.UseVisualStyleBackColor = false;
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
            // FormCatalogoInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.btnAtualizarInstrumentos);
            this.Controls.Add(this.btnPesquisarInstrumentos);
            this.Controls.Add(this.btnDeletarInstrumentos);
            this.Controls.Add(this.btnCadastrarInstrumentos);
            this.Controls.Add(this.dgvInstrumentos);
            this.Controls.Add(this.txtdisponivel);
            this.Controls.Add(this.txtpreco_locacao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtempresa_id);
            this.Controls.Add(this.txtid_instrumento);
            this.Controls.Add(this.lblDisponivel);
            this.Controls.Add(this.lblPrecoLocacao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblempresa_id);
            this.Controls.Add(this.lblid_instrumentos);
            this.Controls.Add(this.lblInstrumentos);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCatalogoInstrumentos";
            this.Text = "FormCatalogoInstrumentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblInstrumentos;
        private System.Windows.Forms.Label lblid_instrumentos;
        private System.Windows.Forms.Label lblempresa_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPrecoLocacao;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.TextBox txtid_instrumento;
        private System.Windows.Forms.TextBox txtempresa_id;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtpreco_locacao;
        private System.Windows.Forms.TextBox txtdisponivel;
        private System.Windows.Forms.DataGridView dgvInstrumentos;
        private System.Windows.Forms.Button btnCadastrarInstrumentos;
        private System.Windows.Forms.Button btnAtualizarInstrumentos;
        private System.Windows.Forms.Button btnPesquisarInstrumentos;
        private System.Windows.Forms.Button btnDeletarInstrumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_instrumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_locacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponivel;
    }
}