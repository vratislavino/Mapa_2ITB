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
        List<MapPoint> mapPoints = new List<MapPoint>();

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
                if(res == DialogResult.OK) {
                    MapPoint newPoint = new MapPoint() { point = e.Location };
                    mapPoints.Add(newPoint);
                }

                Refresh();
            }
        }

        private void Map_Paint(object sender, PaintEventArgs e) {
            foreach (var mapPoint in mapPoints) {
                mapPoint.Draw(e.Graphics);
            }
        }
    }
}
