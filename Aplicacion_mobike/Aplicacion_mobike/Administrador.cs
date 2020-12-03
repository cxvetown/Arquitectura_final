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
    public partial class Administrador : Form
    {

        public Administrador()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del sistema", "Administracion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mobikeDataSet1.reportes' Puede moverla o quitarla según sea necesario.
            this.reportesTableAdapter.Fill(this.mobikeDataSet1.reportes);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Reporte_seleccionado rep = new Reporte_seleccionado();
            rep.Show();
            rep.rut_txt.Text = dataGridView1.CurrentCell.Value.ToString();
            rep.textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rep.report_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }
    }
}
