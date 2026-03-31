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
    public partial class FormFinanceiro : Form
    {
        public FormFinanceiro()
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

            panelConteudo.Controls.Clear();
            panelConteudo.Controls.Add(formularioAtual);


            formularioAtual.Show();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormFinanceiroPagamentos());
        }

        private void btnTransacaoesPagamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormTransacoesPagamentos());
        }

        private void btnFormaPagamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormFinanceiroFormasPagamento());
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal principal = new FormMenuPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
