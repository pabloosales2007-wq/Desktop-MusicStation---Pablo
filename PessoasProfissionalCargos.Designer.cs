namespace Telas_Desktop_MusicStation___Pablo
{
    partial class PessoasProfissionalCargos
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
            this.lblProfissionais = new System.Windows.Forms.Label();
            this.dgvProfissionalCargo = new System.Windows.Forms.DataGridView();
            this.lblidProfissionais = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.txtUsuario_id = new System.Windows.Forms.TextBox();
            this.txtidProfissionais = new System.Windows.Forms.TextBox();
            this.btnCadastrarProfCargo = new System.Windows.Forms.Button();
            this.btnAtualizarProfCargo = new System.Windows.Forms.Button();
            this.btnPesquisarProfCargo = new System.Windows.Forms.Button();
            this.btnDeletarProfCargo = new System.Windows.Forms.Button();
            this.Id_profissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionalCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 22;
            this.pictureBoxFundo.TabStop = false;
            // 
            // lblProfissionais
            // 
            this.lblProfissionais.AutoSize = true;
            this.lblProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblProfissionais.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblProfissionais.Location = new System.Drawing.Point(171, 25);
            this.lblProfissionais.Name = "lblProfissionais";
            this.lblProfissionais.Size = new System.Drawing.Size(339, 37);
            this.lblProfissionais.TabIndex = 23;
            this.lblProfissionais.Text = "Profissionais Cargos";
            // 
            // dgvProfissionalCargo
            // 
            this.dgvProfissionalCargo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProfissionalCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProfissionalCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfissionalCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_profissional,
            this.Id_cargo});
            this.dgvProfissionalCargo.Location = new System.Drawing.Point(63, 264);
            this.dgvProfissionalCargo.Name = "dgvProfissionalCargo";
            this.dgvProfissionalCargo.Size = new System.Drawing.Size(243, 150);
            this.dgvProfissionalCargo.TabIndex = 24;
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
            this.lblidProfissionais.TabIndex = 30;
            this.lblidProfissionais.Text = "Id_profissionais:";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblidUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidUsuario.ForeColor = System.Drawing.Color.White;
            this.lblidUsuario.Location = new System.Drawing.Point(59, 121);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(73, 16);
            this.lblidUsuario.TabIndex = 39;
            this.lblidUsuario.Text = "usuario_id";
            // 
            // txtUsuario_id
            // 
            this.txtUsuario_id.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario_id.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario_id.Location = new System.Drawing.Point(62, 140);
            this.txtUsuario_id.Name = "txtUsuario_id";
            this.txtUsuario_id.Size = new System.Drawing.Size(186, 20);
            this.txtUsuario_id.TabIndex = 37;
            // 
            // txtidProfissionais
            // 
            this.txtidProfissionais.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidProfissionais.ForeColor = System.Drawing.Color.Black;
            this.txtidProfissionais.Location = new System.Drawing.Point(62, 98);
            this.txtidProfissionais.Name = "txtidProfissionais";
            this.txtidProfissionais.Size = new System.Drawing.Size(64, 20);
            this.txtidProfissionais.TabIndex = 36;
            // 
            // btnCadastrarProfCargo
            // 
            this.btnCadastrarProfCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarProfCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarProfCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProfCargo.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarProfCargo.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarProfCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarProfCargo.Name = "btnCadastrarProfCargo";
            this.btnCadastrarProfCargo.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarProfCargo.TabIndex = 41;
            this.btnCadastrarProfCargo.Text = "Cadastrar";
            this.btnCadastrarProfCargo.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarProfCargo
            // 
            this.btnAtualizarProfCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarProfCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarProfCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProfCargo.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarProfCargo.Location = new System.Drawing.Point(533, 133);
            this.btnAtualizarProfCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarProfCargo.Name = "btnAtualizarProfCargo";
            this.btnAtualizarProfCargo.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarProfCargo.TabIndex = 44;
            this.btnAtualizarProfCargo.Text = "Atualizar";
            this.btnAtualizarProfCargo.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarProfCargo
            // 
            this.btnPesquisarProfCargo.BackColor = System.Drawing.Color.White;
            this.btnPesquisarProfCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarProfCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProfCargo.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarProfCargo.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarProfCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarProfCargo.Name = "btnPesquisarProfCargo";
            this.btnPesquisarProfCargo.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarProfCargo.TabIndex = 43;
            this.btnPesquisarProfCargo.Text = "Pesquisar";
            this.btnPesquisarProfCargo.UseVisualStyleBackColor = false;
            // 
            // btnDeletarProfCargo
            // 
            this.btnDeletarProfCargo.BackColor = System.Drawing.Color.Red;
            this.btnDeletarProfCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarProfCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarProfCargo.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarProfCargo.Location = new System.Drawing.Point(437, 133);
            this.btnDeletarProfCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarProfCargo.Name = "btnDeletarProfCargo";
            this.btnDeletarProfCargo.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarProfCargo.TabIndex = 42;
            this.btnDeletarProfCargo.Text = "Deletar";
            this.btnDeletarProfCargo.UseVisualStyleBackColor = false;
            // 
            // Id_profissional
            // 
            this.Id_profissional.HeaderText = "Id_profissional:";
            this.Id_profissional.Name = "Id_profissional";
            // 
            // Id_cargo
            // 
            this.Id_cargo.HeaderText = "Id_cargo:";
            this.Id_cargo.Name = "Id_cargo";
            // 
            // PessoasProfissionalCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.btnAtualizarProfCargo);
            this.Controls.Add(this.btnPesquisarProfCargo);
            this.Controls.Add(this.btnDeletarProfCargo);
            this.Controls.Add(this.btnCadastrarProfCargo);
            this.Controls.Add(this.lblidUsuario);
            this.Controls.Add(this.txtUsuario_id);
            this.Controls.Add(this.txtidProfissionais);
            this.Controls.Add(this.lblidProfissionais);
            this.Controls.Add(this.dgvProfissionalCargo);
            this.Controls.Add(this.lblProfissionais);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PessoasProfissionalCargos";
            this.Text = "PessoasProfissionalCargos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionalCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblProfissionais;
        private System.Windows.Forms.DataGridView dgvProfissionalCargo;
        private System.Windows.Forms.Label lblidProfissionais;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox txtUsuario_id;
        private System.Windows.Forms.TextBox txtidProfissionais;
        private System.Windows.Forms.Button btnCadastrarProfCargo;
        private System.Windows.Forms.Button btnAtualizarProfCargo;
        private System.Windows.Forms.Button btnPesquisarProfCargo;
        private System.Windows.Forms.Button btnDeletarProfCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_profissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cargo;
    }
}