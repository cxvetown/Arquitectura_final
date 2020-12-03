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
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_usuario men = new Menu_usuario();
            this.Close();
            men.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            Valor_txt.MaxLength = 4;
            Devolucion_valor dev = new Devolucion_valor();
            Valor_txt.Text = dev.Generar_total().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Devolucion_data dev = new Devolucion_data()
            {
                Rut = rut_txt.Text,
                valor_total = Valor_txt.Text
            };
            int num = Devolucion_conexion.InsertarSQL(dev);
            if (num > 0)
                MessageBox.Show("Devolucion exitosa", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Error al devolver", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
