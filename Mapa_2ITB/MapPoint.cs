using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mapa_2ITB
{
    public class MapPoint
    { 
        public event Action<MapPoint, bool> MapPointSelected;

        public Point point;
        public string name;
        public int rating;
        public string description;

        private const int POINT_SIZE = 15;
        private Color pointColor = Color.White;

        [NonSerialized]
        private bool isSelected = false;

        //[NonSerialized]
        public bool IsSelected {
            get { return isSelected; }
            set {
                isSelected = value;
                MapPointSelected?.Invoke(this, isSelected);
            }
        }

        public void Draw(Graphics g) {
            if(isSelected) {
                g.FillEllipse(Brushes.Red, point.X - POINT_SIZE, point.Y - POINT_SIZE, 2 * POINT_SIZE, 2 * POINT_SIZE);
            }

            g.DrawEllipse(new Pen(pointColor, 4f), point.X - POINT_SIZE, point.Y - POINT_SIZE, 2 * POINT_SIZE, 2 * POINT_SIZE);
        }

        internal bool IsMouseOver(Point location) {
            float dx = location.X - point.X;
            float dy = location.Y - point.Y;

            return Math.Sqrt(dx * dx + dy * dy) < POINT_SIZE;
        }
    }
}
