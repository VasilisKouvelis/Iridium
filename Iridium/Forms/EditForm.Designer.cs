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
            SelectedKey = new Button();
            panel1 = new Panel();
            ExitBtn = new Button();
            IsActiveBox = new CheckBox();
            ApplyBtn = new Button();
            label2 = new Label();
            IntervalBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedKey
            // 
            SelectedKey.FlatAppearance.BorderColor = Color.Red;
            SelectedKey.FlatStyle = FlatStyle.Flat;
            SelectedKey.Font = new Font("Lato", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedKey.Location = new Point(107, 3);
            SelectedKey.Name = "SelectedKey";
            SelectedKey.Size = new Size(90, 34);
            SelectedKey.TabIndex = 10;
            SelectedKey.Text = "W";
            SelectedKey.UseVisualStyleBackColor = true;
            SelectedKey.Click += SelectedKey_Click;
            SelectedKey.KeyPress += KeyButton_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(IsActiveBox);
            panel1.Controls.Add(ApplyBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IntervalBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectedKey);
            panel1.Location = new Point(4, 26);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 140);
            panel1.TabIndex = 11;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatAppearance.BorderColor = Color.Red;
            ExitBtn.FlatAppearance.BorderSize = 2;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitBtn.Location = new Point(107, 103);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(90, 34);
            ExitBtn.TabIndex = 16;
            ExitBtn.Text = "EXIT";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += button2_Click;
            // 
            // IsActiveBox
            // 
            IsActiveBox.AutoSize = true;
            IsActiveBox.Font = new Font("Lato", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            IsActiveBox.Location = new Point(71, 70);
            IsActiveBox.Name = "IsActiveBox";
            IsActiveBox.Size = new Size(59, 19);
            IsActiveBox.TabIndex = 14;
            IsActiveBox.Text = "Active";
            IsActiveBox.UseVisualStyleBackColor = true;
            // 
            // ApplyBtn
            // 
            ApplyBtn.FlatAppearance.BorderColor = Color.Lime;
            ApplyBtn.FlatAppearance.BorderSize = 2;
            ApplyBtn.FlatStyle = FlatStyle.Flat;
            ApplyBtn.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApplyBtn.ForeColor = Color.Lime;
            ApplyBtn.Location = new Point(3, 103);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(90, 34);
            ApplyBtn.TabIndex = 15;
            ApplyBtn.Text = "APPLY";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 45);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 13;
            label2.Text = "Interval:";
            // 
            // IntervalBox
            // 
            IntervalBox.BackColor = Color.Black;
            IntervalBox.BorderStyle = BorderStyle.FixedSingle;
            IntervalBox.ForeColor = Color.Red;
            IntervalBox.Location = new Point(105, 43);
            IntervalBox.Name = "IntervalBox";
            IntervalBox.Size = new Size(92, 21);
            IntervalBox.TabIndex = 12;
            IntervalBox.TextChanged += IntervalBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 17);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 11;
            label1.Text = "Selected Key:";
            // 
            // label3
            // 
            label3.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(4, 2);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 12;
            label3.Text = "Edit Key";
            // 
            // EditForm
            // 
            AcceptButton = ApplyBtn;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            CancelButton = ExitBtn;
            ClientSize = new Size(208, 170);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Lato", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
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

        private Button SelectedKey;
        private Panel panel1;
        private CheckBox IsActiveBox;
        private Label label2;
        private TextBox IntervalBox;
        private Label label1;
        private Button ApplyBtn;
        private Button ExitBtn;
        private Label label3;
    }
}