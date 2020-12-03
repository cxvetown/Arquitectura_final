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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
            trabaja_combo.Items.Add("Si");
            trabaja_combo.Items.Add("No");
            nombre_txt.MaxLength = 50;
            mail_txt.MaxLength = 60;
            Rut_txt.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pass_register_txt.UseSystemPasswordChar== true)
            {
                pass_register_txt.UseSystemPasswordChar=false;
            }
            else
            {
                pass_register_txt.UseSystemPasswordChar=true;
            }
        }

        private void Rut_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente()
            {
                Nombre_cliente = nombre_txt.Text,
                Rut_cliente = Rut_txt.Text,
                Email_cliente = mail_txt.Text,
                Direccion_cliente = direccion_txt.Text,
                Trabaja_comuna = trabaja_combo.SelectedIndex.ToString(),
                cuenta_bancaria = Cuenta_bancaria_txt.Text,
                Contraseña_cliente = pass_register_txt.Text
            };
            int num = Cliente_conexion.InsertarSQL(cli);
            if (num > 0)
                MessageBox.Show("Cliente Creado con exito", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Cliente no se pudo crear, rellene todos los datos", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cuenta_bancaria_txt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
