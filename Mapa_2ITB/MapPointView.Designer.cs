namespace Mapa_2ITB
{
    partial class MapPointView
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "Název";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(17, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(321, 66);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 17);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 2;
            label2.Text = "0:0";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Location = new Point(17, 124);
            button1.Name = "button1";
            button1.Size = new Size(118, 34);
            button1.TabIndex = 3;
            button1.Text = "Najdi";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(220, 124);
            button2.Name = "button2";
            button2.Size = new Size(118, 34);
            button2.TabIndex = 4;
            button2.Text = "Odstranit";
            button2.UseVisualStyleBackColor = true;
            // 
            // MapPointView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "MapPointView";
            Size = new Size(360, 171);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
