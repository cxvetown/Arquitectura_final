using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Biblioteca;

namespace Aplicacion_mobike
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contraseña_txt.UseSystemPasswordChar==true)
            {
                contraseña_txt.UseSystemPasswordChar= false;
            }
            else
            {
                contraseña_txt.UseSystemPasswordChar = true ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrarse reg = new Registrarse();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select rut_bloqueado from usuarios_bloqueados WHERE rut_bloqueado =@rut_bloqueado", conn);
                    command.Parameters.AddWithValue("@rut_bloqueado", rut_txt.Text);
                    SqlDataReader read = command.ExecuteReader();
                    if (read.Read())
                    {
                        txt_bloq.Text = read["rut_bloqueado"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }

            }
            if (rut_txt.Text == "")
            {
                MessageBox.Show("ingresar valores en las casillas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_bloq.Text == rut_txt.Text)
            {
                MessageBox.Show("usuario bloqueado","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                login();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Selector_administracion sel = new Selector_administracion();
            sel.Show();
        }
        public void login()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT rut, contraseña FROM usuario WHERE rut ='" + rut_txt.Text + "' AND contraseña ='" + contraseña_txt.Text + "'", conn);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Login exitoso","iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Menu_usuario usu = new Menu_usuario();
                        usu.Show();
                        rut_txt.Clear();
                        contraseña_txt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error en los datos","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rut_txt.Clear();
                        contraseña_txt.Clear();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cambio_contraseña ca = new cambio_contraseña();
            ca.Show();
        }
    }
}
