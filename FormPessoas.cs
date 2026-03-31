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

        // Armazena a referência do formulário atualmente exibido no painel principal
        private Form formularioAtual = null;


        // Método responsável por abrir um novo formulário dentro do painel principal (MDI manual)
        private void AbrirFormulario(Form novoForm) 
        {
            // Verifica se já existe um formulário aberto e se ele ainda não foi destruído
            // Isso evita erros ao tentar fechar um formulário já descartado
            // Fecha o formulário atual se existir
            if (formularioAtual != null && !formularioAtual.IsDisposed)
            {
                formularioAtual.Close(); // Fecha o formulário anterior antes de abrir o novo
            }

            // Define o novo formulário como atual
            formularioAtual = novoForm; // Atualiza a referência para o novo formulário recebido como parâmetro
            formularioAtual.TopLevel = false; // Impede que o formulário seja tratado como uma janela independente (janela filha)
            formularioAtual.Dock = DockStyle.Fill;  // Faz o formulário ocupar todo o espaço disponível dentro do painel

            panelPrincipal.Controls.Clear(); // Remove qualquer controle anterior do painel para evitar sobreposição
            panelPrincipal.Controls.Add(formularioAtual); // Adiciona o novo formulário como controle filho do painel principal

            formularioAtual.Show(); // Exibe o formulário dentro do painel
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

        // PROFISSIONAIS CARGOS | FEITO

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasClientes());
        }

        // PROFISSIONAIS CLIENTES | FEITO

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasAdministradores());
        }

        // PROFISSIONAIS Empresa | FEITO

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PessoasEmpresa());
        }

        // QUANDO CLICAR NO SIMBOLO DE PORTA VOLTAR PARA TELA DE LOGIN

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            telalogin principal = new telalogin();
            principal.Show();
            this.Hide();
        }

        //QUANDO CLICAR NO SIMBOLO DE PORTA  VOLTAR PARA TELA DE LOGIN

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal principal = new FormMenuPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
