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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
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
