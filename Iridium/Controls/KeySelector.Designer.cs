namespace Iridium.Controls {
    partial class KeySelector {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Key = new Button();
            Interval = new TextBox();
            Indicator = new Button();
            SuspendLayout();
            // 
            // Key
            // 
            Key.FlatAppearance.BorderColor = Color.Red;
            Key.FlatStyle = FlatStyle.Flat;
            Key.ForeColor = Color.Red;
            Key.Location = new Point(6, 26);
            Key.Name = "Key";
            Key.Size = new Size(70, 50);
            Key.TabIndex = 1;
            Key.Text = "{KEY}";
            Key.UseVisualStyleBackColor = true;
            Key.Click += SelectKey_Click;
            Key.KeyPress += SelectKey_KeyPress;
            // 
            // Interval
            // 
            Interval.BackColor = Color.Black;
            Interval.BorderStyle = BorderStyle.FixedSingle;
            Interval.ForeColor = Color.Red;
            Interval.Location = new Point(6, 82);
            Interval.Name = "Interval";
            Interval.Size = new Size(70, 23);
            Interval.TabIndex = 3;
            Interval.Text = "1000";
            Interval.TextAlign = HorizontalAlignment.Center;
            // 
            // Indicator
            // 
            Indicator.Dock = DockStyle.Top;
            Indicator.FlatAppearance.BorderColor = Color.Red;
            Indicator.FlatAppearance.BorderSize = 11;
            Indicator.FlatStyle = FlatStyle.Flat;
            Indicator.Location = new Point(0, 0);
            Indicator.Name = "Indicator";
            Indicator.Size = new Size(82, 20);
            Indicator.TabIndex = 4;
            Indicator.UseVisualStyleBackColor = true;
            Indicator.Click += SpamToggle_Click;
            // 
            // KeySelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(Indicator);
            Controls.Add(Interval);
            Controls.Add(Key);
            ForeColor = Color.White;
            Name = "KeySelector";
            Size = new Size(82, 111);
            Load += KeySelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Key;
        private TextBox Interval;
        private Button Indicator;
    }
}
