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
    public partial class Menu_usuario : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        public int filaSeleccionada;
        double latinicial = -33.445999;
        double longinicial = -70.547547;

        public Menu_usuario()
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

            //marcador

            markerOverlay = new GMapOverlay("marcador");
            marker = new GMarkerGoogle(new PointLatLng(-33.446169, -70.519925), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);

            //tooltip
            //marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicacion");


            //agregar al mapa
            gMapControl1.Overlays.Add(markerOverlay);

            //marcadores
            GMarkerGoogle marker2 = new GMarkerGoogle(new PointLatLng(-33.457057, -70.521076), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker2);

            GMarkerGoogle marker3 = new GMarkerGoogle(new PointLatLng(-33.437906, -70.518896), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker3);

            GMarkerGoogle marker4 = new GMarkerGoogle(new PointLatLng(-33.440419, -70.533693), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker4);

            GMarkerGoogle marker5 = new GMarkerGoogle(new PointLatLng(-33.458387, -70.540902), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker5);

            GMarkerGoogle marker6 = new GMarkerGoogle(new PointLatLng(-33.434610, -70.548541), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker6);

            GMarkerGoogle marker7 = new GMarkerGoogle(new PointLatLng(-33.438979, -70.556180), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker7);

            GMarkerGoogle marker8 = new GMarkerGoogle(new PointLatLng(-33.449149, -70.555665), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker8);

            GMarkerGoogle marker9 = new GMarkerGoogle(new PointLatLng(-33.438372, -70.566095), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker9);

            GMarkerGoogle marker10 = new GMarkerGoogle(new PointLatLng(-33.452367, -70.560069), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker10);

            GMarkerGoogle marker11 = new GMarkerGoogle(new PointLatLng(-33.457057, -70.521076), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker11);

            GMarkerGoogle marker12 = new GMarkerGoogle(new PointLatLng(-33.442290, -70.543442), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker12);
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Alerta_interaccion_usuario alert = new Alerta_interaccion_usuario();
            alert.Show();
            this.Close();
        }
    }
}
