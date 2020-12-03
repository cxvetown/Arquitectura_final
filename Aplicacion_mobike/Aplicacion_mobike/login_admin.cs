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
    public partial class login_admin : Form
    {
        public login_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void login()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT rut, contraseña FROM administrador WHERE rut ='" + rut_txt.Text + "' AND contraseña ='" + pass_txt.Text + "'", conn);

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Login exitoso", "iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Administrador ad = new Administrador();
                        this.Close();
                        ad.Show();
                        pass_txt.Clear();
                        rut_txt.Clear();
                    }
                    else if (rut_txt.Text=="")
                    {
                        MessageBox.Show("rellenar las casillas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Error en los datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pass_txt.Clear();
                        rut_txt.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pass_txt.UseSystemPasswordChar== true)
            {
                pass_txt.UseSystemPasswordChar= false;
            }
            else
            {
                pass_txt.UseSystemPasswordChar = true ;
            }
        }
    }
}
