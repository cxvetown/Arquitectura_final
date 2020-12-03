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
    public partial class Bloqueo_usuario : Form
    {
        public Bloqueo_usuario()
        {
            InitializeComponent();
        }

        private void Bloqueo_usuario_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                cboMinutos.Items.Add(i);
                cboSegundos.Items.Add(i);
                if (i < 24)
                {
                    cboHoras.Items.Add(i);  
                }
            }
            cboMinutos.SelectedIndex = 0;
            cboSegundos.SelectedIndex = 0;
            cboSegundos.SelectedIndex = 0;

        }
        int horas;
        int seg;
        int min;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            horas = cboHoras.SelectedIndex;
            min = cboMinutos.SelectedIndex;
            seg = cboSegundos.SelectedIndex;

            //inserta usuario en usuarios bloqueados
            usuario_bloqueado usu = new usuario_bloqueado()
            {
                rut_bloqueado = txt_rut_test.Text
            };
            int num = usuario_bloqueado_conexion.InsertarSQL(usu);
            if (num > 0)
                MessageBox.Show("Cliente bloqueado", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Cliente no se pudo bloquear, rellene todos los datos", "Mensaje Emergente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg -= 1;

            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }

            if (min == 0 && horas> 0 && seg == 0)
            {
                seg = 60;
                horas -= 1;
                min = 59;
            }

            if(min == 0 && horas == 0 && seg == 0)
            {
                timer1.Stop();

                //elimina usuario bloqueado
                usuario_bloqueado usu = new usuario_bloqueado()
                {
                    rut_bloqueado = txt_rut_test.Text
                };
                    usuario_bloqueado_conexion.eliminarSQL(usu);

                Reporte rep = new Reporte()
                {
                    cod_usuario = reporte_txt.Text
                };
                Reporte_conexion.eliminarSQL(rep);
            }
        }
    }
}
