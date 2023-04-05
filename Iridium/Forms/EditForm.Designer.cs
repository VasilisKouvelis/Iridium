namespace Iridium.Forms {
    partial class EditForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            KeyButton = new Button();
            panel1 = new Panel();
            IsActiveBox = new CheckBox();
            label2 = new Label();
            IntervalBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // KeyButton
            // 
            KeyButton.FlatAppearance.BorderColor = Color.Red;
            KeyButton.FlatStyle = FlatStyle.Flat;
            KeyButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            KeyButton.Location = new Point(133, 14);
            KeyButton.Name = "KeyButton";
            KeyButton.Size = new Size(98, 31);
            KeyButton.TabIndex = 10;
            KeyButton.Text = "W";
            KeyButton.UseVisualStyleBackColor = true;
            KeyButton.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(IsActiveBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IntervalBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(KeyButton);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 161);
            panel1.TabIndex = 11;
            // 
            // IsActiveBox
            // 
            IsActiveBox.AutoSize = true;
            IsActiveBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsActiveBox.Location = new Point(86, 83);
            IsActiveBox.Name = "IsActiveBox";
            IsActiveBox.Size = new Size(71, 24);
            IsActiveBox.TabIndex = 14;
            IsActiveBox.Text = "Active";
            IsActiveBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 52);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 13;
            label2.Text = "Interval:";
            // 
            // IntervalBox
            // 
            IntervalBox.BackColor = Color.Black;
            IntervalBox.BorderStyle = BorderStyle.FixedSingle;
            IntervalBox.ForeColor = Color.Red;
            IntervalBox.Location = new Point(134, 51);
            IntervalBox.Name = "IntervalBox";
            IntervalBox.Size = new Size(98, 23);
            IntervalBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 11;
            label1.Text = "Selected Key:";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(11, 120);
            button1.Name = "button1";
            button1.Size = new Size(98, 31);
            button1.TabIndex = 15;
            button1.Text = "APPLY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(134, 120);
            button2.Name = "button2";
            button2.Size = new Size(98, 31);
            button2.TabIndex = 16;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(245, 165);
            Controls.Add(panel1);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditForm";
            Load += EditForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button KeyButton;
        private Panel panel1;
        private CheckBox IsActiveBox;
        private Label label2;
        private TextBox IntervalBox;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}