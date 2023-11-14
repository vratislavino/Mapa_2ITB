using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                selectedMapPoint.isSelected = false;
            
            selectedMapPoint = pointToSelect;
            selectedMapPoint.isSelected = true;
            Refresh();
        }
    }
}
