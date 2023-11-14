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
        public Point point;
        public string name;
        public int rating;
        public string description;

        private const int POINT_SIZE = 15;
        private Color pointColor = Color.White;

        public void Draw(Graphics g) {
            g.DrawEllipse(new Pen(pointColor, 4f), point.X - POINT_SIZE, point.Y - POINT_SIZE, 2 * POINT_SIZE, 2 * POINT_SIZE);
        }
    }
}
