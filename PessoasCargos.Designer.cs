namespace Telas_Desktop_MusicStation___Pablo
{
    partial class PessoasCargos
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
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.lblCargos = new System.Windows.Forms.Label();
            this.btnAtualizarCargos = new System.Windows.Forms.Button();
            this.btnPesquisarCargos = new System.Windows.Forms.Button();
            this.btnDeletarCargos = new System.Windows.Forms.Button();
            this.btnCadastrarCargos = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.txtDescricaoCargo = new System.Windows.Forms.TextBox();
            this.txtNomeCargo = new System.Windows.Forms.TextBox();
            this.txtidCargo = new System.Windows.Forms.TextBox();
            this.id_profissionais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarios_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCargos
            // 
            this.dgvCargos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCargos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_profissionais,
            this.usuarios_id,
            this.telefone});
            this.dgvCargos.Location = new System.Drawing.Point(63, 264);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.Size = new System.Drawing.Size(344, 150);
            this.dgvCargos.TabIndex = 19;
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblCargos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblCargos.Location = new System.Drawing.Point(260, 25);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(127, 37);
            this.lblCargos.TabIndex = 20;
            this.lblCargos.Text = "Cargos";
            // 
            // btnAtualizarCargos
            // 
            this.btnAtualizarCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarCargos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarCargos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarCargos.Location = new System.Drawing.Point(534, 133);
            this.btnAtualizarCargos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarCargos.Name = "btnAtualizarCargos";
            this.btnAtualizarCargos.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarCargos.TabIndex = 24;
            this.btnAtualizarCargos.Text = "Atualizar";
            this.btnAtualizarCargos.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarCargos
            // 
            this.btnPesquisarCargos.BackColor = System.Drawing.Color.White;
            this.btnPesquisarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarCargos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCargos.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarCargos.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarCargos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarCargos.Name = "btnPesquisarCargos";
            this.btnPesquisarCargos.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarCargos.TabIndex = 23;
            this.btnPesquisarCargos.Text = "Pesquisar";
            this.btnPesquisarCargos.UseVisualStyleBackColor = false;
            // 
            // btnDeletarCargos
            // 
            this.btnDeletarCargos.BackColor = System.Drawing.Color.Red;
            this.btnDeletarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarCargos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCargos.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarCargos.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarCargos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarCargos.Name = "btnDeletarCargos";
            this.btnDeletarCargos.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarCargos.TabIndex = 22;
            this.btnDeletarCargos.Text = "Deletar";
            this.btnDeletarCargos.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarCargos
            // 
            this.btnCadastrarCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCargos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCargos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCargos.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarCargos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarCargos.Name = "btnCadastrarCargos";
            this.btnCadastrarCargos.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarCargos.TabIndex = 21;
            this.btnCadastrarCargos.Text = "Cadastrar";
            this.btnCadastrarCargos.UseVisualStyleBackColor = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(59, 163);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 16);
            this.lblDescricao.TabIndex = 30;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(59, 121);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome:";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblidUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidUsuario.ForeColor = System.Drawing.Color.White;
            this.lblidUsuario.Location = new System.Drawing.Point(59, 79);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(24, 16);
            this.lblidUsuario.TabIndex = 28;
            this.lblidUsuario.Text = "ID:";
            // 
            // txtDescricaoCargo
            // 
            this.txtDescricaoCargo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCargo.ForeColor = System.Drawing.Color.Black;
            this.txtDescricaoCargo.Location = new System.Drawing.Point(62, 182);
            this.txtDescricaoCargo.Name = "txtDescricaoCargo";
            this.txtDescricaoCargo.Size = new System.Drawing.Size(186, 20);
            this.txtDescricaoCargo.TabIndex = 27;
            // 
            // txtNomeCargo
            // 
            this.txtNomeCargo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCargo.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCargo.Location = new System.Drawing.Point(62, 140);
            this.txtNomeCargo.Name = "txtNomeCargo";
            this.txtNomeCargo.Size = new System.Drawing.Size(186, 20);
            this.txtNomeCargo.TabIndex = 26;
            // 
            // txtidCargo
            // 
            this.txtidCargo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidCargo.ForeColor = System.Drawing.Color.Black;
            this.txtidCargo.Location = new System.Drawing.Point(62, 98);
            this.txtidCargo.Name = "txtidCargo";
            this.txtidCargo.Size = new System.Drawing.Size(64, 20);
            this.txtidCargo.TabIndex = 25;
            // 
            // id_profissionais
            // 
            this.id_profissionais.HeaderText = "ID";
            this.id_profissionais.Name = "id_profissionais";
            // 
            // usuarios_id
            // 
            this.usuarios_id.HeaderText = "Nome";
            this.usuarios_id.Name = "usuarios_id";
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Descrição";
            this.telefone.Name = "telefone";
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 18;
            this.pictureBoxFundo.TabStop = false;
            // 
            // PessoasCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblidUsuario);
            this.Controls.Add(this.txtDescricaoCargo);
            this.Controls.Add(this.txtNomeCargo);
            this.Controls.Add(this.txtidCargo);
            this.Controls.Add(this.btnAtualizarCargos);
            this.Controls.Add(this.btnPesquisarCargos);
            this.Controls.Add(this.btnDeletarCargos);
            this.Controls.Add(this.btnCadastrarCargos);
            this.Controls.Add(this.lblCargos);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.pictureBoxFundo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PessoasCargos";
            this.Text = "PessoasCargos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Button btnAtualizarCargos;
        private System.Windows.Forms.Button btnPesquisarCargos;
        private System.Windows.Forms.Button btnDeletarCargos;
        private System.Windows.Forms.Button btnCadastrarCargos;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox txtDescricaoCargo;
        private System.Windows.Forms.TextBox txtNomeCargo;
        private System.Windows.Forms.TextBox txtidCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_profissionais;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarios_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    }
}