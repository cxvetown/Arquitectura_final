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
    public partial class cambio_contraseña : Form
    {
        public cambio_contraseña()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (new_pass_txt.UseSystemPasswordChar== true)
            {
                new_pass_txt.UseSystemPasswordChar=false;
            }
            else
            {
                new_pass_txt.UseSystemPasswordChar=true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (repeat_pass_Txt.UseSystemPasswordChar==true)
            {
                repeat_pass_Txt.UseSystemPasswordChar=false;
            }
            else
            {
                repeat_pass_Txt.UseSystemPasswordChar=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente
            {
                Rut_cliente = Rut_txt.Text,
                Contraseña_cliente = new_pass_txt.Text
            };
            if (new_pass_txt.Text == repeat_pass_Txt.Text)
            {
                Cliente_conexion.updateSQL(cli);
                MessageBox.Show("Contraseña cambiada con exito", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new_pass_txt.Clear();
                repeat_pass_Txt.Clear();
            }
        }
    }
}
