namespace Mapa_2ITB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            map1 = new Map();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // map1
            // 
            map1.BackColor = SystemColors.ButtonShadow;
            map1.BackgroundImageLayout = ImageLayout.Zoom;
            map1.BorderStyle = BorderStyle.FixedSingle;
            map1.Location = new Point(12, 12);
            map1.Name = "map1";
            map1.Size = new Size(1038, 821);
            map1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(1056, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(430, 821);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 845);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(map1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Map map1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}