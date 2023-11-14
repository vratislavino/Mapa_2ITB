namespace Mapa_2ITB
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            map1.MapPointsChanged += UpdateMapPoints;
        }

        private void UpdateMapPoints() {
            flowLayoutPanel1.Controls.Clear();

            map1.MapPoints.ForEach(mapPoint => {

                var mapPointView = new MapPointView();
                mapPointView.Setup(mapPoint);
                mapPointView.DeleteRequested += OnDeleteRequested;
                mapPointView.SelectRequested += OnSelectRequested;
                flowLayoutPanel1.Controls.Add(mapPointView);
            });
        }

        private void OnSelectRequested(MapPoint pointToSelect) {
            map1.SelectMapPoint(pointToSelect);
        }

        private void OnDeleteRequested(MapPoint pointToDelete) {
            map1.MapPoints.Remove(pointToDelete);
            UpdateMapPoints();
            Refresh();
        }
    }
}