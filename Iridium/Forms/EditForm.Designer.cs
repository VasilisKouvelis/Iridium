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
            ExitBtn = new Button();
            IsActiveBox = new CheckBox();
            ApplyBtn = new Button();
            label2 = new Label();
            IntervalBox = new TextBox();
            label1 = new Label();
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
            KeyButton.Click += SelectedKey_Click;
            KeyButton.KeyPress += KeyButton_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(IsActiveBox);
            panel1.Controls.Add(ApplyBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IntervalBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(KeyButton);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 161);
            panel1.TabIndex = 11;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatAppearance.BorderColor = Color.Red;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExitBtn.Location = new Point(134, 120);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(98, 31);
            ExitBtn.TabIndex = 16;
            ExitBtn.Text = "EXIT";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += button2_Click;
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
            // ApplyBtn
            // 
            ApplyBtn.FlatAppearance.BorderColor = Color.Lime;
            ApplyBtn.FlatStyle = FlatStyle.Flat;
            ApplyBtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ApplyBtn.ForeColor = Color.Lime;
            ApplyBtn.Location = new Point(11, 120);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(98, 31);
            ApplyBtn.TabIndex = 15;
            ApplyBtn.Text = "APPLY";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
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
            // EditForm
            // 
            AcceptButton = ApplyBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            CancelButton = ExitBtn;
            ClientSize = new Size(245, 165);
            Controls.Add(panel1);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit...";
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
        private Button ApplyBtn;
        private Button ExitBtn;
    }
}