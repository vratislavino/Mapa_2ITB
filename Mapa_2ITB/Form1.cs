namespace Mapa_2ITB
{
    public partial class Form1 : Form
    {
        // Vysvìtlit Observer -> event

        public Form1() {
            InitializeComponent();
            map1.MapPointsChanged += UpdateMapPoints;
        }

        private void UpdateMapPoints() {
            flowLayoutPanel1.Controls.Clear();

            map1.MapPoints.ForEach(mapPoint => {

                var mapPointView = new MapPointView();
                mapPointView.Setup(mapPoint);
                flowLayoutPanel1.Controls.Add(mapPointView);

            });
        }
    }
}