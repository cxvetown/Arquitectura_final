using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mobike_data;
using Biblioteca;
using Controlador;

namespace Aplicacion_mobike
{
    public partial class Reporte_seleccionado : Form
    {
        public Reporte_seleccionado()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Cliente cli = new Cliente()
            {
                Rut_cliente = rut_txt.Text
            };
             Cliente_conexion.eliminarSQL(cli);

            Reporte rep = new Reporte()
            {
                rut_usuario = rut_txt.Text
            };
            Reporte_conexion.eliminarSQL(rep);
            MessageBox.Show("Cliente eliminado", "Mensaje emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bloqueo_usuario bloq = new Bloqueo_usuario();
            bloq.Show();
            bloq.txt_rut_test.Text = rut_txt.Text;
            bloq.reporte_txt.Text = report_txt.Text;
        }
    }
}
