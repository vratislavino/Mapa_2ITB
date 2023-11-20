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
    public partial class MapPointView : UserControl
    {
        public event Action<MapPoint> DeleteRequested;
        public event Action<MapPoint> SelectRequested;

        MapPoint mapPoint;

        public MapPointView() {
            InitializeComponent();
        }

        public void Setup(MapPoint mapPoint) {
            this.mapPoint = mapPoint;

            mapPoint.MapPointSelected += OnMapPointSelected;

            label1.Text = mapPoint.name;
            label2.Text = mapPoint.point.X + ":" + mapPoint.point.Y;

            for (int i = 0; i < mapPoint.rating; i++) {
                var pct = new PictureBox();
                pct.BackgroundImage = Image.FromFile("images/star.png");
                pct.BackgroundImageLayout = ImageLayout.Stretch;
                pct.Size = new Size(50, 50);
                flowLayoutPanel1.Controls.Add(pct);
            }
        }

        private void OnMapPointSelected(MapPoint point, bool selected) {
            this.BackColor = selected ? Color.Yellow : Color.White;
        }

        private void button2_Click(object sender, EventArgs e) {
            DeleteRequested?.Invoke(mapPoint);
        }

        private void button1_Click(object sender, EventArgs e) {
            SelectRequested?.Invoke(mapPoint);
        }
    }
}
