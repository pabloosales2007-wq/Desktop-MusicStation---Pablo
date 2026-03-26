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
    }
}
