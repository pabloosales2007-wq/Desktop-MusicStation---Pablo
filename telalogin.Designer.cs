namespace Telas_Desktop_MusicStation___Pablo
{
    partial class telalogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.btnEnviarLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Telas_Desktop_MusicStation___Pablo.Properties.Resources.music_station_vetorizada_1;
            this.pictureBox1.Location = new System.Drawing.Point(250, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLoginUsuario.Location = new System.Drawing.Point(250, 222);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(339, 29);
            this.txtLoginUsuario.TabIndex = 1;
            this.txtLoginUsuario.Text = "     Digite seu usuário..";
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.txtLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLoginSenha.Location = new System.Drawing.Point(250, 292);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(339, 29);
            this.txtLoginSenha.TabIndex = 2;
            this.txtLoginSenha.Text = "     Digite sua senha...";
            // 
            // btnEnviarLogin
            // 
            this.btnEnviarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnEnviarLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(96)))));
            this.btnEnviarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviarLogin.Location = new System.Drawing.Point(377, 344);
            this.btnEnviarLogin.Name = "btnEnviarLogin";
            this.btnEnviarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarLogin.TabIndex = 3;
            this.btnEnviarLogin.Text = "ENVIAR";
            this.btnEnviarLogin.UseVisualStyleBackColor = false;
            // 
            // telalogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(830, 495);
            this.Controls.Add(this.btnEnviarLogin);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telalogin";
            this.Text = "telalogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Button btnEnviarLogin;
    }
}

