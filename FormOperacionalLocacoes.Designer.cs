namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormOperacionalLocacoes
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
            this.lblLocacoes = new System.Windows.Forms.Label();
            this.lblId_locacao = new System.Windows.Forms.Label();
            this.lblcliente_id = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnCadastrarLocacoes = new System.Windows.Forms.Button();
            this.btnAtualizarLocacoes = new System.Windows.Forms.Button();
            this.btnPesquisarLocacoes = new System.Windows.Forms.Button();
            this.btnDeletarLocacoes = new System.Windows.Forms.Button();
            this.id_locacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.REtangulo;
            this.pictureBoxFundo.Location = new System.Drawing.Point(-18, -5);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 26;
            this.pictureBoxFundo.TabStop = false;
            // 
            // lblLocacoes
            // 
            this.lblLocacoes.AutoSize = true;
            this.lblLocacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblLocacoes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblLocacoes.Location = new System.Drawing.Point(252, 25);
            this.lblLocacoes.Name = "lblLocacoes";
            this.lblLocacoes.Size = new System.Drawing.Size(165, 37);
            this.lblLocacoes.TabIndex = 27;
            this.lblLocacoes.Text = "Locações";
            // 
            // lblId_locacao
            // 
            this.lblId_locacao.AutoSize = true;
            this.lblId_locacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblId_locacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_locacao.ForeColor = System.Drawing.Color.White;
            this.lblId_locacao.Location = new System.Drawing.Point(60, 79);
            this.lblId_locacao.Name = "lblId_locacao";
            this.lblId_locacao.Size = new System.Drawing.Size(80, 16);
            this.lblId_locacao.TabIndex = 56;
            this.lblId_locacao.Text = "Id_locacao:";
            // 
            // lblcliente_id
            // 
            this.lblcliente_id.AutoSize = true;
            this.lblcliente_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblcliente_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente_id.ForeColor = System.Drawing.Color.White;
            this.lblcliente_id.Location = new System.Drawing.Point(157, 79);
            this.lblcliente_id.Name = "lblcliente_id";
            this.lblcliente_id.Size = new System.Drawing.Size(73, 16);
            this.lblcliente_id.TabIndex = 57;
            this.lblcliente_id.Text = "cliente_id:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDataInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.White;
            this.lblDataInicio.Location = new System.Drawing.Point(256, 79);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(79, 16);
            this.lblDataInicio.TabIndex = 58;
            this.lblDataInicio.Text = "Data Inicio:";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDataFim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFim.ForeColor = System.Drawing.Color.White;
            this.lblDataFim.Location = new System.Drawing.Point(60, 121);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(68, 16);
            this.lblDataFim.TabIndex = 59;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblValorTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Location = new System.Drawing.Point(157, 121);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(79, 16);
            this.lblValorTotal.TabIndex = 60;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(60, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 61;
            this.lblStatus.Text = "Status:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 62;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 63;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(259, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 64;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 20);
            this.textBox4.TabIndex = 65;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(71, 20);
            this.textBox5.TabIndex = 66;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(63, 185);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 20);
            this.textBox6.TabIndex = 67;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_locacao,
            this.cliente_id,
            this.data_inicio,
            this.data_fim,
            this.valor_total,
            this.status});
            this.dgvPedidos.Location = new System.Drawing.Point(63, 264);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(542, 150);
            this.dgvPedidos.TabIndex = 71;
            // 
            // btnCadastrarLocacoes
            // 
            this.btnCadastrarLocacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarLocacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLocacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarLocacoes.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarLocacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarLocacoes.Name = "btnCadastrarLocacoes";
            this.btnCadastrarLocacoes.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarLocacoes.TabIndex = 72;
            this.btnCadastrarLocacoes.Text = "Cadastrar";
            this.btnCadastrarLocacoes.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarLocacoes
            // 
            this.btnAtualizarLocacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarLocacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarLocacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarLocacoes.Location = new System.Drawing.Point(534, 133);
            this.btnAtualizarLocacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarLocacoes.Name = "btnAtualizarLocacoes";
            this.btnAtualizarLocacoes.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarLocacoes.TabIndex = 75;
            this.btnAtualizarLocacoes.Text = "Atualizar";
            this.btnAtualizarLocacoes.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarLocacoes
            // 
            this.btnPesquisarLocacoes.BackColor = System.Drawing.Color.White;
            this.btnPesquisarLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarLocacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarLocacoes.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarLocacoes.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarLocacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarLocacoes.Name = "btnPesquisarLocacoes";
            this.btnPesquisarLocacoes.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarLocacoes.TabIndex = 74;
            this.btnPesquisarLocacoes.Text = "Pesquisar";
            this.btnPesquisarLocacoes.UseVisualStyleBackColor = false;
            // 
            // btnDeletarLocacoes
            // 
            this.btnDeletarLocacoes.BackColor = System.Drawing.Color.Red;
            this.btnDeletarLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarLocacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarLocacoes.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarLocacoes.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarLocacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarLocacoes.Name = "btnDeletarLocacoes";
            this.btnDeletarLocacoes.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarLocacoes.TabIndex = 73;
            this.btnDeletarLocacoes.Text = "Deletar";
            this.btnDeletarLocacoes.UseVisualStyleBackColor = false;
            // 
            // id_locacao
            // 
            this.id_locacao.HeaderText = "id_locacao";
            this.id_locacao.Name = "id_locacao";
            // 
            // cliente_id
            // 
            this.cliente_id.HeaderText = "cliente_id";
            this.cliente_id.Name = "cliente_id";
            // 
            // data_inicio
            // 
            this.data_inicio.HeaderText = "Data Inicio";
            this.data_inicio.Name = "data_inicio";
            // 
            // data_fim
            // 
            this.data_fim.HeaderText = "Data Fim";
            this.data_fim.Name = "data_fim";
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.Name = "valor_total";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // FormOperacionalLocacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.btnAtualizarLocacoes);
            this.Controls.Add(this.btnPesquisarLocacoes);
            this.Controls.Add(this.btnDeletarLocacoes);
            this.Controls.Add(this.btnCadastrarLocacoes);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblcliente_id);
            this.Controls.Add(this.lblId_locacao);
            this.Controls.Add(this.lblLocacoes);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperacionalLocacoes";
            this.Text = "FormOperacionalLocacoes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblLocacoes;
        private System.Windows.Forms.Label lblId_locacao;
        private System.Windows.Forms.Label lblcliente_id;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnCadastrarLocacoes;
        private System.Windows.Forms.Button btnAtualizarLocacoes;
        private System.Windows.Forms.Button btnPesquisarLocacoes;
        private System.Windows.Forms.Button btnDeletarLocacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_locacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}