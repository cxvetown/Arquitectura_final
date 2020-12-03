using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Mobike_data;

namespace Aplicacion_mobike
{
    public partial class Arrendar : Form
    {
        public Arrendar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_usuario men = new Menu_usuario();
            this.Close();
            men.Show();
        }

        private void Arrendar_Load(object sender, EventArgs e)
        {
            codigo_txt.MaxLength = 6;
            Arrendar_codigo arrendar = new Arrendar_codigo();
            codigo_txt.Text = arrendar.Generar_codigo().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arriendo ar = new Arriendo()
            {
                Codigo_desbloqueo = codigo_txt.Text,
                rut_cliente = rut_Txt.Text
            };
            int num = Arriendo_conexion.InsertarSQL(ar);
            if (num > 0)
                MessageBox.Show("Arriendo exitoso", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Error al arrendar", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
