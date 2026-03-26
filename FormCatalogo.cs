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
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
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
    }
}
