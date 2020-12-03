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

namespace Aplicacion_mobike
{
    public partial class Generar_reporte : Form
    {
        public Generar_reporte()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte rep = new Reporte()
            {
                cod_usuario = cod_reporte_txt.Text,
                nombre_usu = nombre_txt.Text,
                rut_usuario = rut_txt.Text,
                descripcion = descripcion_txt.Text
            };
            int num = Reporte_conexion.InsertarSQL(rep);
            if (num > 0)
            {
                MessageBox.Show("Reporte enviado", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
                MessageBox.Show("Fallo en crear reporte", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
