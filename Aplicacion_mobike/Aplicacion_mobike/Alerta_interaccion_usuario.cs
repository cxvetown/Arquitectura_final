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
    public partial class Alerta_interaccion_usuario : Form
    {
        public Alerta_interaccion_usuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_usuario usu = new Menu_usuario();
            usu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arrendar ar = new Arrendar();
            ar.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Devolucion dev = new Devolucion();
            dev.Show();
            this.Close();
        }
    }
}
