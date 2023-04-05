namespace Iridium.Forms {
    partial class StartupForm {
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
            Managers.InputManager inputManager5 = new Managers.InputManager();
            Managers.InputManager inputManager6 = new Managers.InputManager();
            Managers.InputManager inputManager7 = new Managers.InputManager();
            Managers.InputManager inputManager8 = new Managers.InputManager();
            visualStudioTabControl1 = new Controls.VisualStudioTabControl();
            KeyboardPage = new TabPage();
            Ability4_Btn = new Controls.KeySelector();
            Ability3_Btn = new Controls.KeySelector();
            Ability2_Btn = new Controls.KeySelector();
            Ability1_Btn = new Controls.KeySelector();
            MousePage = new TabPage();
            panel1 = new Panel();
            ApplicationExitButton = new Button();
            WorkingLabel = new Label();
            CurrentWindowLabel = new Label();
            visualStudioTabControl1.SuspendLayout();
            KeyboardPage.SuspendLayout();
            SuspendLayout();
            // 
            // visualStudioTabControl1
            // 
            visualStudioTabControl1.ActiveColor = Color.Red;
            visualStudioTabControl1.AllowDrop = true;
            visualStudioTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            visualStudioTabControl1.BackTabColor = Color.Black;
            visualStudioTabControl1.BorderColor = Color.Black;
            visualStudioTabControl1.ClosingButtonColor = Color.WhiteSmoke;
            visualStudioTabControl1.ClosingMessage = null;
            visualStudioTabControl1.Controls.Add(KeyboardPage);
            visualStudioTabControl1.Controls.Add(MousePage);
            visualStudioTabControl1.HeaderColor = Color.Black;
            visualStudioTabControl1.HorizontalLineColor = Color.Red;
            visualStudioTabControl1.ItemSize = new Size(240, 16);
            visualStudioTabControl1.Location = new Point(3, 68);
            visualStudioTabControl1.Name = "visualStudioTabControl1";
            visualStudioTabControl1.SelectedIndex = 0;
            visualStudioTabControl1.SelectedTextColor = Color.FromArgb(255, 255, 255);
            visualStudioTabControl1.ShowClosingButton = false;
            visualStudioTabControl1.ShowClosingMessage = false;
            visualStudioTabControl1.Size = new Size(361, 247);
            visualStudioTabControl1.TabIndex = 4;
            visualStudioTabControl1.TextColor = Color.FromArgb(255, 255, 255);
            // 
            // KeyboardPage
            // 
            KeyboardPage.BackColor = Color.Black;
            KeyboardPage.Controls.Add(Ability4_Btn);
            KeyboardPage.Controls.Add(Ability3_Btn);
            KeyboardPage.Controls.Add(Ability2_Btn);
            KeyboardPage.Controls.Add(Ability1_Btn);
            KeyboardPage.Location = new Point(4, 20);
            KeyboardPage.Name = "KeyboardPage";
            KeyboardPage.Padding = new Padding(3);
            KeyboardPage.Size = new Size(353, 223);
            KeyboardPage.TabIndex = 0;
            KeyboardPage.Text = "Keyboard";
            // 
            // Ability4_Btn
            // 
            Ability4_Btn.Active = false;
            Ability4_Btn.BackColor = Color.Black;
            Ability4_Btn.ForeColor = Color.White;
            Ability4_Btn.KeyInterval = 0;
            inputManager5.DisabledColor = Color.Red;
            inputManager5.EnabledColor = Color.Orange;
            Ability4_Btn.KeyValue = inputManager5;
            Ability4_Btn.Location = new Point(270, 6);
            Ability4_Btn.Name = "Ability4_Btn";
            Ability4_Btn.Replaceable = false;
            Ability4_Btn.Size = new Size(82, 111);
            Ability4_Btn.TabIndex = 3;
            // 
            // Ability3_Btn
            // 
            Ability3_Btn.Active = false;
            Ability3_Btn.BackColor = Color.Black;
            Ability3_Btn.ForeColor = Color.White;
            Ability3_Btn.KeyInterval = 0;
            inputManager6.DisabledColor = Color.Red;
            inputManager6.EnabledColor = Color.Orange;
            Ability3_Btn.KeyValue = inputManager6;
            Ability3_Btn.Location = new Point(182, 6);
            Ability3_Btn.Name = "Ability3_Btn";
            Ability3_Btn.Replaceable = false;
            Ability3_Btn.Size = new Size(82, 111);
            Ability3_Btn.TabIndex = 2;
            // 
            // Ability2_Btn
            // 
            Ability2_Btn.Active = false;
            Ability2_Btn.BackColor = Color.Black;
            Ability2_Btn.ForeColor = Color.White;
            Ability2_Btn.KeyInterval = 0;
            inputManager7.DisabledColor = Color.Red;
            inputManager7.EnabledColor = Color.Orange;
            Ability2_Btn.KeyValue = inputManager7;
            Ability2_Btn.Location = new Point(94, 6);
            Ability2_Btn.Name = "Ability2_Btn";
            Ability2_Btn.Replaceable = false;
            Ability2_Btn.Size = new Size(82, 111);
            Ability2_Btn.TabIndex = 1;
            // 
            // Ability1_Btn
            // 
            Ability1_Btn.Active = false;
            Ability1_Btn.BackColor = Color.Black;
            Ability1_Btn.ForeColor = Color.White;
            Ability1_Btn.KeyInterval = 0;
            inputManager8.DisabledColor = Color.Red;
            inputManager8.EnabledColor = Color.Orange;
            Ability1_Btn.KeyValue = inputManager8;
            Ability1_Btn.Location = new Point(6, 6);
            Ability1_Btn.Name = "Ability1_Btn";
            Ability1_Btn.Replaceable = false;
            Ability1_Btn.Size = new Size(82, 111);
            Ability1_Btn.TabIndex = 0;
            // 
            // MousePage
            // 
            MousePage.BackColor = Color.Black;
            MousePage.Location = new Point(4, 20);
            MousePage.Name = "MousePage";
            MousePage.Padding = new Padding(3);
            MousePage.Size = new Size(353, 223);
            MousePage.TabIndex = 1;
            MousePage.Text = "Mouse";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 315);
            panel1.TabIndex = 5;
            // 
            // ApplicationExitButton
            // 
            ApplicationExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApplicationExitButton.FlatAppearance.BorderColor = Color.Red;
            ApplicationExitButton.FlatStyle = FlatStyle.Flat;
            ApplicationExitButton.Location = new Point(341, 0);
            ApplicationExitButton.Name = "ApplicationExitButton";
            ApplicationExitButton.Size = new Size(23, 23);
            ApplicationExitButton.TabIndex = 6;
            ApplicationExitButton.Text = "X";
            ApplicationExitButton.UseVisualStyleBackColor = true;
            ApplicationExitButton.Click += ApplicationExitButton_Click;
            // 
            // WorkingLabel
            // 
            WorkingLabel.AutoSize = true;
            WorkingLabel.BackColor = Color.Transparent;
            WorkingLabel.Font = new Font("Lato", 30F, FontStyle.Regular, GraphicsUnit.Point);
            WorkingLabel.ForeColor = Color.White;
            WorkingLabel.Location = new Point(3, 0);
            WorkingLabel.Name = "WorkingLabel";
            WorkingLabel.Size = new Size(98, 48);
            WorkingLabel.TabIndex = 7;
            WorkingLabel.Text = "OFF";
            // 
            // CurrentWindowLabel
            // 
            CurrentWindowLabel.AutoSize = true;
            CurrentWindowLabel.Font = new Font("Lato", 7F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentWindowLabel.ForeColor = Color.DimGray;
            CurrentWindowLabel.Location = new Point(13, 41);
            CurrentWindowLabel.Name = "CurrentWindowLabel";
            CurrentWindowLabel.Size = new Size(104, 12);
            CurrentWindowLabel.TabIndex = 8;
            CurrentWindowLabel.Text = "Current Window Title";
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(365, 315);
            Controls.Add(CurrentWindowLabel);
            Controls.Add(panel1);
            Controls.Add(ApplicationExitButton);
            Controls.Add(visualStudioTabControl1);
            Controls.Add(WorkingLabel);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartupForm";
            Opacity = 0.95D;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += StartupForm_MouseDown;
            visualStudioTabControl1.ResumeLayout(false);
            KeyboardPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Controls.VisualStudioTabControl visualStudioTabControl1;
        private TabPage KeyboardPage;
        private TabPage MousePage;
        private Panel panel1;
        private Controls.KeySelector Ability4_Btn;
        private Controls.KeySelector Ability3_Btn;
        private Controls.KeySelector Ability2_Btn;
        private Controls.KeySelector Ability1_Btn;
        private Button ApplicationExitButton;
        private Label WorkingLabel;
        private Label CurrentWindowLabel;
    }
}