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
            this.btnCadastrarProfissionais = new System.Windows.Forms.Button();
            this.btnAtualizarProfCargo = new System.Windows.Forms.Button();
            this.btnPesquisarProfCargo = new System.Windows.Forms.Button();
            this.btnDeletarProfCargo = new System.Windows.Forms.Button();
            this.txtidProfissionais = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblidProfissionais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnCadastrarProfissionais.TabIndex = 37;
            this.btnCadastrarProfissionais.Text = "Cadastrar";
            this.btnCadastrarProfissionais.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarProfCargo
            // 
            this.btnAtualizarProfCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarProfCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarProfCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProfCargo.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarProfCargo.Location = new System.Drawing.Point(534, 133);
            this.btnAtualizarProfCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarProfCargo.Name = "btnAtualizarProfCargo";
            this.btnAtualizarProfCargo.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarProfCargo.TabIndex = 47;
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
            this.btnPesquisarProfCargo.TabIndex = 46;
            this.btnPesquisarProfCargo.Text = "Pesquisar";
            this.btnPesquisarProfCargo.UseVisualStyleBackColor = false;
            // 
            // btnDeletarProfCargo
            // 
            this.btnDeletarProfCargo.BackColor = System.Drawing.Color.Red;
            this.btnDeletarProfCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarProfCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarProfCargo.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarProfCargo.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarProfCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarProfCargo.Name = "btnDeletarProfCargo";
            this.btnDeletarProfCargo.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarProfCargo.TabIndex = 45;
            this.btnDeletarProfCargo.Text = "Deletar";
            this.btnDeletarProfCargo.UseVisualStyleBackColor = false;
            // 
            // txtidProfissionais
            // 
            this.txtidProfissionais.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidProfissionais.ForeColor = System.Drawing.Color.Black;
            this.txtidProfissionais.Location = new System.Drawing.Point(62, 98);
            this.txtidProfissionais.Name = "txtidProfissionais";
            this.txtidProfissionais.Size = new System.Drawing.Size(64, 20);
            this.txtidProfissionais.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(151, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(234, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 50;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(63, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(307, 20);
            this.textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(62, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 20);
            this.textBox4.TabIndex = 52;
            // 
            // lblidProfissionais
            // 
            this.lblidProfissionais.AutoSize = true;
            this.lblidProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblidProfissionais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidProfissionais.ForeColor = System.Drawing.Color.White;
            this.lblidProfissionais.Location = new System.Drawing.Point(60, 79);
            this.lblidProfissionais.Name = "lblidProfissionais";
            this.lblidProfissionais.Size = new System.Drawing.Size(73, 16);
            this.lblidProfissionais.TabIndex = 53;
            this.lblidProfissionais.Text = "Id_cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "usuario_id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Id_cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Id_cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Id_cliente:";
            // 
            // PessoasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblidProfissionais);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtidProfissionais);
            this.Controls.Add(this.btnAtualizarProfCargo);
            this.Controls.Add(this.btnPesquisarProfCargo);
            this.Controls.Add(this.btnDeletarProfCargo);
            this.Controls.Add(this.btnCadastrarProfissionais);
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
        private System.Windows.Forms.Button btnCadastrarProfissionais;
        private System.Windows.Forms.Button btnAtualizarProfCargo;
        private System.Windows.Forms.Button btnPesquisarProfCargo;
        private System.Windows.Forms.Button btnDeletarProfCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.TextBox txtidProfissionais;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblidProfissionais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}