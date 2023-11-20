using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Mapa_2ITB
{
    public partial class Map : UserControl
    {
        public event Action MapPointsChanged;

        List<MapPoint> mapPoints = new List<MapPoint>();

        public List<MapPoint> MapPoints => mapPoints;

        private MapPoint selectedMapPoint = null;

        public Map() {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e) {

            BackgroundImage = Image.FromFile("images/mapa2.jpg");
            LoadPoints();
        }

        private void LoadPoints() {

            string path = "points.json";
            string readText = File.ReadAllText(path);

            mapPoints = JsonConvert.DeserializeObject<List<MapPoint>>(readText);

            if(mapPoints == null) {
                mapPoints = new List<MapPoint>();
            }

            MapPointsChanged?.Invoke();
        }

        public void SavePoints() {
            string json = JsonConvert.SerializeObject(mapPoints);

            string path = "points.json";

            File.WriteAllText(path, json);

            // Open the file to read from.
            //string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);

        }

        private void Map_MouseClick(object sender, MouseEventArgs e) {
            // vytvoření bodu na mapě
            if(e.Button == MouseButtons.Right) {

                NewPointDialog npd = new NewPointDialog();

                var res = npd.ShowDialog();

                if(npd.MapPoint == null) {
                    // cancel
                } else {
                    npd.MapPoint.point = e.Location;
                    mapPoints.Add(npd.MapPoint);

                    MapPointsChanged?.Invoke();
                }

                Refresh();
            } else if (e.Button == MouseButtons.Left) {
                foreach(var point in mapPoints) {
                    if(point.IsMouseOver(e.Location)) {
                        SelectMapPoint(point);
                        break;
                    }
                }
            }
        }

        private void Map_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var mapPoint in mapPoints) {
                mapPoint.Draw(e.Graphics);
            }
        }

        internal void SelectMapPoint(MapPoint pointToSelect) {
            if (selectedMapPoint != null)
                selectedMapPoint.IsSelected = false;
            
            selectedMapPoint = pointToSelect;
            selectedMapPoint.IsSelected = true;
            Refresh();
        }
    }
}
