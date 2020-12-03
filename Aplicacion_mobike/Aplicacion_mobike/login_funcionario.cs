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
    public partial class login_funcionario : Form
    {
        public login_funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT rut, contraseña FROM funcionario WHERE rut ='" + funcionario_rut_txt.Text + "' AND contraseña ='" + funcionario_pass_txt.Text + "'", conn);

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Login exitoso", "iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Funcionario fun = new Funcionario();
                        fun.Show();
                        this.Close();
                        funcionario_pass_txt.Clear();
                        funcionario_rut_txt.Clear();
                    }
                    else if (funcionario_rut_txt.Text=="")
                    {
                        MessageBox.Show("Error en los datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Error en los datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        funcionario_pass_txt.Clear();
                        funcionario_rut_txt.Clear();
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
            if (funcionario_pass_txt.UseSystemPasswordChar== true)
            {
                funcionario_pass_txt.UseSystemPasswordChar=false;
            }
            else
            {
                funcionario_pass_txt.UseSystemPasswordChar=true;
            }
        }
    }
}
