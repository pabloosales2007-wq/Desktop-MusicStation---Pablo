namespace Telas_Desktop_MusicStation___Pablo
{
    partial class FormOperacionalServicoPedido
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
            this.lblServicoPedidos = new System.Windows.Forms.Label();
            this.lblId_item = new System.Windows.Forms.Label();
            this.lblpedido_id = new System.Windows.Forms.Label();
            this.lblservico_id = new System.Windows.Forms.Label();
            this.lblProfissional_id = new System.Windows.Forms.Label();
            this.lblValorServico = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtid_item = new System.Windows.Forms.TextBox();
            this.txtpedido_id = new System.Windows.Forms.TextBox();
            this.txtservico_id = new System.Windows.Forms.TextBox();
            this.txtprofissional_id = new System.Windows.Forms.TextBox();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnCadastrarServicosPedidos = new System.Windows.Forms.Button();
            this.btnAtualizarServicosPedidos = new System.Windows.Forms.Button();
            this.btnPesquisarServicosPedidos = new System.Windows.Forms.Button();
            this.btnDeletarServicosPedidos = new System.Windows.Forms.Button();
            this.dgvServicosPedidos = new System.Windows.Forms.DataGridView();
            this.id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosPedidos)).BeginInit();
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
            // lblServicoPedidos
            // 
            this.lblServicoPedidos.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lblServicoPedidos.AutoSize = true;
            this.lblServicoPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblServicoPedidos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicoPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblServicoPedidos.Location = new System.Drawing.Point(192, 25);
            this.lblServicoPedidos.Name = "lblServicoPedidos";
            this.lblServicoPedidos.Size = new System.Drawing.Size(283, 37);
            this.lblServicoPedidos.TabIndex = 27;
            this.lblServicoPedidos.Text = "Serviços Pedidos";
            // 
            // lblId_item
            // 
            this.lblId_item.AutoSize = true;
            this.lblId_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblId_item.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_item.ForeColor = System.Drawing.Color.White;
            this.lblId_item.Location = new System.Drawing.Point(60, 79);
            this.lblId_item.Name = "lblId_item";
            this.lblId_item.Size = new System.Drawing.Size(58, 16);
            this.lblId_item.TabIndex = 56;
            this.lblId_item.Text = "Id_item:";
            // 
            // lblpedido_id
            // 
            this.lblpedido_id.AutoSize = true;
            this.lblpedido_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblpedido_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpedido_id.ForeColor = System.Drawing.Color.White;
            this.lblpedido_id.Location = new System.Drawing.Point(152, 79);
            this.lblpedido_id.Name = "lblpedido_id";
            this.lblpedido_id.Size = new System.Drawing.Size(74, 16);
            this.lblpedido_id.TabIndex = 57;
            this.lblpedido_id.Text = "pedido_id:";
            // 
            // lblservico_id
            // 
            this.lblservico_id.AutoSize = true;
            this.lblservico_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblservico_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservico_id.ForeColor = System.Drawing.Color.White;
            this.lblservico_id.Location = new System.Drawing.Point(250, 79);
            this.lblservico_id.Name = "lblservico_id";
            this.lblservico_id.Size = new System.Drawing.Size(75, 16);
            this.lblservico_id.TabIndex = 58;
            this.lblservico_id.Text = "servico_id:";
            // 
            // lblProfissional_id
            // 
            this.lblProfissional_id.AutoSize = true;
            this.lblProfissional_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblProfissional_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissional_id.ForeColor = System.Drawing.Color.White;
            this.lblProfissional_id.Location = new System.Drawing.Point(60, 123);
            this.lblProfissional_id.Name = "lblProfissional_id";
            this.lblProfissional_id.Size = new System.Drawing.Size(104, 16);
            this.lblProfissional_id.TabIndex = 59;
            this.lblProfissional_id.Text = "Profissional_id:";
            // 
            // lblValorServico
            // 
            this.lblValorServico.AutoSize = true;
            this.lblValorServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblValorServico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorServico.ForeColor = System.Drawing.Color.White;
            this.lblValorServico.Location = new System.Drawing.Point(184, 123);
            this.lblValorServico.Name = "lblValorServico";
            this.lblValorServico.Size = new System.Drawing.Size(96, 16);
            this.lblValorServico.TabIndex = 60;
            this.lblValorServico.Text = "Valor Serviço:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblObservacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.White;
            this.lblObservacao.Location = new System.Drawing.Point(60, 165);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(86, 16);
            this.lblObservacao.TabIndex = 61;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtid_item
            // 
            this.txtid_item.Location = new System.Drawing.Point(63, 99);
            this.txtid_item.Name = "txtid_item";
            this.txtid_item.Size = new System.Drawing.Size(55, 20);
            this.txtid_item.TabIndex = 62;
            // 
            // txtpedido_id
            // 
            this.txtpedido_id.Location = new System.Drawing.Point(155, 95);
            this.txtpedido_id.Name = "txtpedido_id";
            this.txtpedido_id.Size = new System.Drawing.Size(71, 20);
            this.txtpedido_id.TabIndex = 63;
            // 
            // txtservico_id
            // 
            this.txtservico_id.Location = new System.Drawing.Point(253, 95);
            this.txtservico_id.Name = "txtservico_id";
            this.txtservico_id.Size = new System.Drawing.Size(71, 20);
            this.txtservico_id.TabIndex = 64;
            // 
            // txtprofissional_id
            // 
            this.txtprofissional_id.Location = new System.Drawing.Point(63, 142);
            this.txtprofissional_id.Name = "txtprofissional_id";
            this.txtprofissional_id.Size = new System.Drawing.Size(101, 20);
            this.txtprofissional_id.TabIndex = 65;
            // 
            // txtValorServico
            // 
            this.txtValorServico.Location = new System.Drawing.Point(187, 142);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(93, 20);
            this.txtValorServico.TabIndex = 66;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(63, 184);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(83, 20);
            this.txtObservacao.TabIndex = 67;
            // 
            // btnCadastrarServicosPedidos
            // 
            this.btnCadastrarServicosPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCadastrarServicosPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarServicosPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarServicosPedidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarServicosPedidos.Location = new System.Drawing.Point(438, 94);
            this.btnCadastrarServicosPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarServicosPedidos.Name = "btnCadastrarServicosPedidos";
            this.btnCadastrarServicosPedidos.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrarServicosPedidos.TabIndex = 68;
            this.btnCadastrarServicosPedidos.Text = "Cadastrar";
            this.btnCadastrarServicosPedidos.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarServicosPedidos
            // 
            this.btnAtualizarServicosPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(158)))), ((int)(((byte)(213)))));
            this.btnAtualizarServicosPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarServicosPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarServicosPedidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarServicosPedidos.Location = new System.Drawing.Point(534, 133);
            this.btnAtualizarServicosPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarServicosPedidos.Name = "btnAtualizarServicosPedidos";
            this.btnAtualizarServicosPedidos.Size = new System.Drawing.Size(88, 31);
            this.btnAtualizarServicosPedidos.TabIndex = 72;
            this.btnAtualizarServicosPedidos.Text = "Atualizar";
            this.btnAtualizarServicosPedidos.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarServicosPedidos
            // 
            this.btnPesquisarServicosPedidos.BackColor = System.Drawing.Color.White;
            this.btnPesquisarServicosPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarServicosPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarServicosPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarServicosPedidos.Location = new System.Drawing.Point(534, 94);
            this.btnPesquisarServicosPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarServicosPedidos.Name = "btnPesquisarServicosPedidos";
            this.btnPesquisarServicosPedidos.Size = new System.Drawing.Size(88, 33);
            this.btnPesquisarServicosPedidos.TabIndex = 71;
            this.btnPesquisarServicosPedidos.Text = "Pesquisar";
            this.btnPesquisarServicosPedidos.UseVisualStyleBackColor = false;
            // 
            // btnDeletarServicosPedidos
            // 
            this.btnDeletarServicosPedidos.BackColor = System.Drawing.Color.Red;
            this.btnDeletarServicosPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarServicosPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarServicosPedidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletarServicosPedidos.Location = new System.Drawing.Point(438, 133);
            this.btnDeletarServicosPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarServicosPedidos.Name = "btnDeletarServicosPedidos";
            this.btnDeletarServicosPedidos.Size = new System.Drawing.Size(88, 31);
            this.btnDeletarServicosPedidos.TabIndex = 70;
            this.btnDeletarServicosPedidos.Text = "Deletar";
            this.btnDeletarServicosPedidos.UseVisualStyleBackColor = false;
            // 
            // dgvServicosPedidos
            // 
            this.dgvServicosPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvServicosPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvServicosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_item,
            this.pedido_id,
            this.servico_id,
            this.profissional_id,
            this.valor_servico,
            this.observacao});
            this.dgvServicosPedidos.Location = new System.Drawing.Point(63, 264);
            this.dgvServicosPedidos.Name = "dgvServicosPedidos";
            this.dgvServicosPedidos.Size = new System.Drawing.Size(540, 150);
            this.dgvServicosPedidos.TabIndex = 73;
            // 
            // id_item
            // 
            this.id_item.HeaderText = "id_item";
            this.id_item.Name = "id_item";
            // 
            // pedido_id
            // 
            this.pedido_id.HeaderText = "pedido_id";
            this.pedido_id.Name = "pedido_id";
            // 
            // servico_id
            // 
            this.servico_id.HeaderText = "servico_id";
            this.servico_id.Name = "servico_id";
            // 
            // profissional_id
            // 
            this.profissional_id.HeaderText = "profissional_id";
            this.profissional_id.Name = "profissional_id";
            // 
            // valor_servico
            // 
            this.valor_servico.HeaderText = "valor_servico";
            this.valor_servico.Name = "valor_servico";
            // 
            // observacao
            // 
            this.observacao.HeaderText = "observacao";
            this.observacao.Name = "observacao";
            // 
            // FormOperacionalServicoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.dgvServicosPedidos);
            this.Controls.Add(this.btnAtualizarServicosPedidos);
            this.Controls.Add(this.btnPesquisarServicosPedidos);
            this.Controls.Add(this.btnDeletarServicosPedidos);
            this.Controls.Add(this.btnCadastrarServicosPedidos);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtValorServico);
            this.Controls.Add(this.txtprofissional_id);
            this.Controls.Add(this.txtservico_id);
            this.Controls.Add(this.txtpedido_id);
            this.Controls.Add(this.txtid_item);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblValorServico);
            this.Controls.Add(this.lblProfissional_id);
            this.Controls.Add(this.lblservico_id);
            this.Controls.Add(this.lblpedido_id);
            this.Controls.Add(this.lblId_item);
            this.Controls.Add(this.lblServicoPedidos);
            this.Controls.Add(this.pictureBoxFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperacionalServicoPedido";
            this.Text = "FormOperacionalServicoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.Label lblServicoPedidos;
        private System.Windows.Forms.Label lblId_item;
        private System.Windows.Forms.Label lblpedido_id;
        private System.Windows.Forms.Label lblservico_id;
        private System.Windows.Forms.Label lblProfissional_id;
        private System.Windows.Forms.Label lblValorServico;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtid_item;
        private System.Windows.Forms.TextBox txtpedido_id;
        private System.Windows.Forms.TextBox txtservico_id;
        private System.Windows.Forms.TextBox txtprofissional_id;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnCadastrarServicosPedidos;
        private System.Windows.Forms.Button btnAtualizarServicosPedidos;
        private System.Windows.Forms.Button btnPesquisarServicosPedidos;
        private System.Windows.Forms.Button btnDeletarServicosPedidos;
        private System.Windows.Forms.DataGridView dgvServicosPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissional_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
    }
}