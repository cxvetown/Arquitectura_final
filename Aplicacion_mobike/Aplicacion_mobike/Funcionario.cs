using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//librerias usadas
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Aplicacion_mobike
{
    public partial class Funcionario : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        public int filaSeleccionada;
        double latinicial = -33.445999;
        double longinicial = -70.547547;

        public Funcionario()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latinicial, longinicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 13;
            gMapControl1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_reporte rep = new Generar_reporte();
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
