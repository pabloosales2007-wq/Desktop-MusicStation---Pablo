using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas_Desktop_MusicStation___Pablo
{
    public partial class FormPessoas : Form
    {
        
        public FormPessoas()
        {
            InitializeComponent();
        }

        private Form formularioAtual = null;

        private void AbrirFormulario(Form novoForm) 
        {
            // Fecha o formulário atual se existir
            if (formularioAtual != null && !formularioAtual.IsDisposed)
            {
                formularioAtual.Close();
            }

            // Define o novo formulário como atual
            formularioAtual = novoForm;
            formularioAtual.TopLevel = false;
            formularioAtual.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(formularioAtual);

            formularioAtual.Show();
        }



        // USUARIOS | FEITO

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasUsuarios());
        }


        // CARGOS | FEITO
        

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasCargos());
        }


        // PROFISSIONAIS | FEITO
        
        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasProfissionais());
        }

        // PROFISSIONAIS CARGOS | FEITO

        private void btnProfissionalCargo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasProfissionalCargos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasClientes());
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasAdministradores());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasEmpresa());
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            telalogin principal = new telalogin();
            principal.Show();
            this.Hide();
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal principal = new FormMenuPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
