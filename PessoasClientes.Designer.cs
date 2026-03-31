namespace Telas_Desktop_MusicStation___Pablo
{
    partial class PessoasClientes
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.btnAtualizarClientes = new System.Windows.Forms.Button();
            this.btnPesquisarClientes = new System.Windows.Forms.Button();
            this.btnDeletarClientes = new System.Windows.Forms.Button();
            this.txtId_cliente = new System.Windows.Forms.TextBox();
            this.txtUsuario_id = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblid_cliente = new System.Windows.Forms.Label();
            this.lblUsuario_id = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 23;
            this.pictureBoxFundo.TabStop = false;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblClientes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblClientes.Location = new System.Drawing.Point(269, 25);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(144, 37);
            this.lblClientes.TabIndex = 24;
            this.lblClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.usuario_id,
            this.telefone,
            this.rua,
            this.numero});
            this.dgvClientes.Location = new System.Drawing.Point(63, 264);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(543, 150);
            this.dgvClientes.TabIndex = 25;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // usuario_id
            // 
            this.usuario_id.HeaderText = "usuario_id";
            this.usuario_id.Name = "usuario_id";
            // 
            // telefone
            // 
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            // 
            // rua
            // 
            this.rua.HeaderText = "rua";
            this.rua.Name = "rua";
            // 
            // numero
            // 
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarClientes.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarClientes.TabIndex = 37;
            this.btnCadastrarClientes.Text = "Cadastrar";
            this.btnCadastrarClientes.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarClientes
            // 
            this.btnAtualizarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarClientes.Location = new System.Drawing.Point(534, 133);
            this.btnAtualizarClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarClientes.Name = "btnAtualizarClientes";
            this.btnAtualizarClientes.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarClientes.TabIndex = 47;
            this.btnAtualizarClientes.Text = "Atualizar";
            this.btnAtualizarClientes.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarClientes
            // 
            this.btnPesquisarClientes.BackColor = System.Drawing.Color.White;
            this.btnPesquisarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarClientes.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarClientes.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarClientes.Name = "btnPesquisarClientes";
            this.btnPesquisarClientes.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarClientes.TabIndex = 46;
            this.btnPesquisarClientes.Text = "Pesquisar";
            this.btnPesquisarClientes.UseVisualStyleBackColor = false;
            // 
            // btnDeletarClientes
            // 
            this.btnDeletarClientes.BackColor = System.Drawing.Color.Red;
            this.btnDeletarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarClientes.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarClientes.Name = "btnDeletarClientes";
            this.btnDeletarClientes.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarClientes.TabIndex = 45;
            this.btnDeletarClientes.Text = "Deletar";
            this.btnDeletarClientes.UseVisualStyleBackColor = false;
            // 
            // txtId_cliente
            // 
            this.txtId_cliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_cliente.ForeColor = System.Drawing.Color.Black;
            this.txtId_cliente.Location = new System.Drawing.Point(62, 98);
            this.txtId_cliente.Name = "txtId_cliente";
            this.txtId_cliente.Size = new System.Drawing.Size(64, 20);
            this.txtId_cliente.TabIndex = 48;
            // 
            // txtUsuario_id
            // 
            this.txtUsuario_id.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario_id.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario_id.Location = new System.Drawing.Point(151, 98);
            this.txtUsuario_id.Name = "txtUsuario_id";
            this.txtUsuario_id.Size = new System.Drawing.Size(64, 20);
            this.txtUsuario_id.TabIndex = 49;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.Location = new System.Drawing.Point(234, 98);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(136, 20);
            this.txtTelefone.TabIndex = 50;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Black;
            this.txtRua.Location = new System.Drawing.Point(63, 140);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(307, 20);
            this.txtRua.TabIndex = 51;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(62, 180);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(89, 20);
            this.txtNumero.TabIndex = 52;
            // 
            // lblid_cliente
            // 
            this.lblid_cliente.AutoSize = true;
            this.lblid_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblid_cliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_cliente.ForeColor = System.Drawing.Color.White;
            this.lblid_cliente.Location = new System.Drawing.Point(60, 79);
            this.lblid_cliente.Name = "lblid_cliente";
            this.lblid_cliente.Size = new System.Drawing.Size(73, 16);
            this.lblid_cliente.TabIndex = 53;
            this.lblid_cliente.Text = "Id_cliente:";
            // 
            // lblUsuario_id
            // 
            this.lblUsuario_id.AutoSize = true;
            this.lblUsuario_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblUsuario_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_id.ForeColor = System.Drawing.Color.White;
            this.lblUsuario_id.Location = new System.Drawing.Point(148, 79);
            this.lblUsuario_id.Name = "lblUsuario_id";
            this.lblUsuario_id.Size = new System.Drawing.Size(77, 16);
            this.lblUsuario_id.TabIndex = 54;
            this.lblUsuario_id.Text = "usuario_id:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(231, 79);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(63, 16);
            this.lblTelefone.TabIndex = 55;
            this.lblTelefone.Text = "telefone:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(60, 121);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 16);
            this.lblRua.TabIndex = 56;
            this.lblRua.Text = "Rua:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(59, 162);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(56, 16);
            this.lblNumero.TabIndex = 57;
            this.lblNumero.Text = "numero";
            // 
            // PessoasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblUsuario_id);
            this.Controls.Add(this.lblid_cliente);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtUsuario_id);
            this.Controls.Add(this.txtId_cliente);
            this.Controls.Add(this.btnAtualizarClientes);
            this.Controls.Add(this.btnPesquisarClientes);
            this.Controls.Add(this.btnDeletarClientes);
            this.Controls.Add(this.btnCadastrarClientes);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PessoasClientes";
            this.Text = "PessoasClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnCadastrarClientes;
        private System.Windows.Forms.Button btnAtualizarClientes;
        private System.Windows.Forms.Button btnPesquisarClientes;
        private System.Windows.Forms.Button btnDeletarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.TextBox txtId_cliente;
        private System.Windows.Forms.TextBox txtUsuario_id;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblid_cliente;
        private System.Windows.Forms.Label lblUsuario_id;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNumero;
    }
}