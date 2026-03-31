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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            FormPessoas principal = new FormPessoas ();
            principal.Show();
            this.Hide();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            FormCatalogo principal = new FormCatalogo ();
            principal.Show();
            this.Hide();
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            FormOperacional principal = new FormOperacional ();
            principal.Show();
            this.Hide();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            FormFinanceiro principal = new FormFinanceiro ();
            principal.Show();
            this.Hide();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            FormMensagens principal = new FormMensagens ();
            principal.Show();
            this.Hide();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            telalogin principal = new telalogin ();
            principal.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard principal = new FormDashboard ();
            principal.Show();
            this.Hide();
        }
    }
}
