namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormOperacionalPedidos
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
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblId_pedido = new System.Windows.Forms.Label();
            this.txtd_pedido = new System.Windows.Forms.TextBox();
            this.lblcliente_id = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblAcompanhamento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtAcompanhamento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCadastrarPedidos = new System.Windows.Forms.Button();
            this.btnAtualizarPedidos = new System.Windows.Forms.Button();
            this.btnPesquisarPedidos = new System.Windows.Forms.Button();
            this.btnDeletarPedidos = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acompanhamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblPedidos.Location = new System.Drawing.Point(259, 25);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(140, 37);
            this.lblPedidos.TabIndex = 26;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblId_pedido
            // 
            this.lblId_pedido.AutoSize = true;
            this.lblId_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblId_pedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_pedido.ForeColor = System.Drawing.Color.White;
            this.lblId_pedido.Location = new System.Drawing.Point(60, 79);
            this.lblId_pedido.Name = "lblId_pedido";
            this.lblId_pedido.Size = new System.Drawing.Size(74, 16);
            this.lblId_pedido.TabIndex = 55;
            this.lblId_pedido.Text = "Id_pedido:";
            // 
            // txtd_pedido
            // 
            this.txtd_pedido.Location = new System.Drawing.Point(63, 94);
            this.txtd_pedido.Name = "txtd_pedido";
            this.txtd_pedido.Size = new System.Drawing.Size(71, 20);
            this.txtd_pedido.TabIndex = 56;
            // 
            // lblcliente_id
            // 
            this.lblcliente_id.AutoSize = true;
            this.lblcliente_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblcliente_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente_id.ForeColor = System.Drawing.Color.White;
            this.lblcliente_id.Location = new System.Drawing.Point(165, 79);
            this.lblcliente_id.Name = "lblcliente_id";
            this.lblcliente_id.Size = new System.Drawing.Size(73, 16);
            this.lblcliente_id.TabIndex = 57;
            this.lblcliente_id.Text = "cliente_id:";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDataPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPedido.ForeColor = System.Drawing.Color.White;
            this.lblDataPedido.Location = new System.Drawing.Point(278, 79);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(89, 16);
            this.lblDataPedido.TabIndex = 58;
            this.lblDataPedido.Text = "Data Pedido:";
            // 
            // lblAcompanhamento
            // 
            this.lblAcompanhamento.AutoSize = true;
            this.lblAcompanhamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAcompanhamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcompanhamento.ForeColor = System.Drawing.Color.White;
            this.lblAcompanhamento.Location = new System.Drawing.Point(60, 122);
            this.lblAcompanhamento.Name = "lblAcompanhamento";
            this.lblAcompanhamento.Size = new System.Drawing.Size(127, 16);
            this.lblAcompanhamento.TabIndex = 59;
            this.lblAcompanhamento.Text = "Acompanhamento:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(193, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "Total:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 61;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(281, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 62;
            // 
            // txtAcompanhamento
            // 
            this.txtAcompanhamento.Location = new System.Drawing.Point(63, 141);
            this.txtAcompanhamento.Name = "txtAcompanhamento";
            this.txtAcompanhamento.Size = new System.Drawing.Size(71, 20);
            this.txtAcompanhamento.TabIndex = 63;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(196, 140);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(71, 20);
            this.txtTotal.TabIndex = 64;
            // 
            // btnCadastrarPedidos
            // 
            this.btnCadastrarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPedidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarPedidos.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarPedidos.Name = "btnCadastrarPedidos";
            this.btnCadastrarPedidos.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarPedidos.TabIndex = 65;
            this.btnCadastrarPedidos.Text = "Cadastrar";
            this.btnCadastrarPedidos.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarPedidos
            // 
            this.btnAtualizarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPedidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarPedidos.Location = new System.Drawing.Point(534, 134);
            this.btnAtualizarPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarPedidos.Name = "btnAtualizarPedidos";
            this.btnAtualizarPedidos.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarPedidos.TabIndex = 69;
            this.btnAtualizarPedidos.Text = "Atualizar";
            this.btnAtualizarPedidos.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarPedidos
            // 
            this.btnPesquisarPedidos.BackColor = System.Drawing.Color.White;
            this.btnPesquisarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarPedidos.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarPedidos.Name = "btnPesquisarPedidos";
            this.btnPesquisarPedidos.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarPedidos.TabIndex = 68;
            this.btnPesquisarPedidos.Text = "Pesquisar";
            this.btnPesquisarPedidos.UseVisualStyleBackColor = false;
            // 
            // btnDeletarPedidos
            // 
            this.btnDeletarPedidos.BackColor = System.Drawing.Color.Red;
            this.btnDeletarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarPedidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarPedidos.Location = new System.Drawing.Point(438, 134);
            this.btnDeletarPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarPedidos.Name = "btnDeletarPedidos";
            this.btnDeletarPedidos.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarPedidos.TabIndex = 67;
            this.btnDeletarPedidos.Text = "Deletar";
            this.btnDeletarPedidos.UseVisualStyleBackColor = false;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.cliente_id,
            this.data_pedido,
            this.total,
            this.acompanhamento});
            this.dgvPedidos.Location = new System.Drawing.Point(63, 264);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(542, 150);
            this.dgvPedidos.TabIndex = 70;
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "id_pedido";
            this.id_pedido.Name = "id_pedido";
            // 
            // cliente_id
            // 
            this.cliente_id.HeaderText = "cliente_id ";
            this.cliente_id.Name = "cliente_id";
            // 
            // data_pedido
            // 
            this.data_pedido.HeaderText = "data_pedido ";
            this.data_pedido.Name = "data_pedido";
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // acompanhamento
            // 
            this.acompanhamento.HeaderText = "acompanhamento ";
            this.acompanhamento.Name = "acompanhamento";
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 25;
            this.pictureBoxFundo.TabStop = false;
            // 
            // FormOperacionalPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnAtualizarPedidos);
            this.Controls.Add(this.btnPesquisarPedidos);
            this.Controls.Add(this.btnDeletarPedidos);
            this.Controls.Add(this.btnCadastrarPedidos);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAcompanhamento);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAcompanhamento);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.lblcliente_id);
            this.Controls.Add(this.txtd_pedido);
            this.Controls.Add(this.lblId_pedido);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperacionalPedidos";
            this.Text = "FormOperacionalPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblId_pedido;
        private System.Windows.Forms.TextBox txtd_pedido;
        private System.Windows.Forms.Label lblcliente_id;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblAcompanhamento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtAcompanhamento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCadastrarPedidos;
        private System.Windows.Forms.Button btnAtualizarPedidos;
        private System.Windows.Forms.Button btnPesquisarPedidos;
        private System.Windows.Forms.Button btnDeletarPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn acompanhamento;
    }
}