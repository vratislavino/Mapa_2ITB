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
    public partial class NewPointDialog : Form
    {
        public MapPoint MapPoint = null;

        public NewPointDialog() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox1.Text)) {
                MessageBox.Show("Nevyplnil jsi název!");
                return;
            }

            if (string.IsNullOrEmpty(richTextBox1.Text)) {
                MessageBox.Show("Nevyplnil jsi popis!");
                return;
            }

            if (numericUpDown1.Value == 0) {
                MessageBox.Show("Nevyplnil jsi hodnocení!");
                return;
            }

            // vše ok
            MapPoint = new MapPoint() {
                name = textBox1.Text,
                rating = (int) numericUpDown1.Value,
                description = richTextBox1.Text,
            };

            this.Close();
        }
    }
}
