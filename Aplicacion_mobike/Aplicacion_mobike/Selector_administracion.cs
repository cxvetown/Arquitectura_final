using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_mobike
{
    public partial class Selector_administracion : Form
    {
        public Selector_administracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_funcionario fun = new login_funcionario();
            this.Close();
            fun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login_admin ad = new login_admin();
            this.Close();
            ad.Show();
        }
    }
}
