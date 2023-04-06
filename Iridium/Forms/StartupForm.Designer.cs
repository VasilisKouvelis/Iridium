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
            components = new System.ComponentModel.Container();
            KeyboardPage = new TabPage();
            MousePage = new TabPage();
            OnOffPanel = new Panel();
            ApplicationExitButton = new Button();
            WorkingLabel = new Label();
            CurrentWindowLabel = new Label();
            visualStudioTabControl2 = new Controls.VisualStudioTabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SpamKeysListView = new ListView();
            ActiveHeader = new ColumnHeader();
            KeyHeader = new ColumnHeader();
            IntervalHeader = new ColumnHeader();
            IDHeader = new ColumnHeader();
            tabPage2 = new TabPage();
            MainTimer = new System.Windows.Forms.Timer(components);
            visualStudioTabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // KeyboardPage
            // 
            KeyboardPage.BackColor = Color.Black;
            KeyboardPage.Location = new Point(4, 20);
            KeyboardPage.Name = "KeyboardPage";
            KeyboardPage.Padding = new Padding(3);
            KeyboardPage.Size = new Size(353, 223);
            KeyboardPage.TabIndex = 0;
            KeyboardPage.Text = "Keyboard";
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
            // OnOffPanel
            // 
            OnOffPanel.BackColor = Color.Red;
            OnOffPanel.Dock = DockStyle.Left;
            OnOffPanel.Location = new Point(0, 0);
            OnOffPanel.Name = "OnOffPanel";
            OnOffPanel.Size = new Size(5, 539);
            OnOffPanel.TabIndex = 5;
            // 
            // ApplicationExitButton
            // 
            ApplicationExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApplicationExitButton.FlatAppearance.BorderColor = Color.Red;
            ApplicationExitButton.FlatStyle = FlatStyle.Flat;
            ApplicationExitButton.Location = new Point(296, 0);
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
            WorkingLabel.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            WorkingLabel.ForeColor = Color.White;
            WorkingLabel.Location = new Point(3, 0);
            WorkingLabel.Name = "WorkingLabel";
            WorkingLabel.Size = new Size(99, 46);
            WorkingLabel.TabIndex = 7;
            WorkingLabel.Text = "OFF";
            // 
            // CurrentWindowLabel
            // 
            CurrentWindowLabel.AutoSize = true;
            CurrentWindowLabel.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentWindowLabel.ForeColor = Color.DimGray;
            CurrentWindowLabel.Location = new Point(13, 41);
            CurrentWindowLabel.Name = "CurrentWindowLabel";
            CurrentWindowLabel.Size = new Size(102, 13);
            CurrentWindowLabel.TabIndex = 8;
            CurrentWindowLabel.Text = "Current Window Title";
            // 
            // visualStudioTabControl2
            // 
            visualStudioTabControl2.ActiveColor = Color.Red;
            visualStudioTabControl2.AllowDrop = true;
            visualStudioTabControl2.BackTabColor = Color.Black;
            visualStudioTabControl2.BorderColor = Color.Black;
            visualStudioTabControl2.ClosingButtonColor = Color.WhiteSmoke;
            visualStudioTabControl2.ClosingMessage = null;
            visualStudioTabControl2.Controls.Add(tabPage1);
            visualStudioTabControl2.Controls.Add(tabPage2);
            visualStudioTabControl2.HeaderColor = Color.Black;
            visualStudioTabControl2.HorizontalLineColor = Color.Red;
            visualStudioTabControl2.ItemSize = new Size(240, 16);
            visualStudioTabControl2.Location = new Point(5, 67);
            visualStudioTabControl2.Name = "visualStudioTabControl2";
            visualStudioTabControl2.SelectedIndex = 0;
            visualStudioTabControl2.SelectedTextColor = Color.FromArgb(255, 255, 255);
            visualStudioTabControl2.ShowClosingButton = false;
            visualStudioTabControl2.ShowClosingMessage = false;
            visualStudioTabControl2.Size = new Size(314, 469);
            visualStudioTabControl2.TabIndex = 9;
            visualStudioTabControl2.TextColor = Color.FromArgb(255, 255, 255);
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(SpamKeysListView);
            tabPage1.Location = new Point(4, 20);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(306, 445);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Keyboard";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.SkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.SkyBlue;
            button4.Location = new Point(236, 145);
            button4.Name = "button4";
            button4.Size = new Size(65, 65);
            button4.TabIndex = 10;
            button4.Text = "Toggle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(236, 379);
            button3.Name = "button3";
            button3.Size = new Size(65, 65);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Orange;
            button2.Location = new Point(236, 74);
            button2.Name = "button2";
            button2.Size = new Size(65, 65);
            button2.TabIndex = 8;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(236, 3);
            button1.Name = "button1";
            button1.Size = new Size(65, 65);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpamKeysListView
            // 
            SpamKeysListView.BackColor = Color.Black;
            SpamKeysListView.Columns.AddRange(new ColumnHeader[] { ActiveHeader, KeyHeader, IntervalHeader, IDHeader });
            SpamKeysListView.Dock = DockStyle.Left;
            SpamKeysListView.ForeColor = Color.Red;
            SpamKeysListView.FullRowSelect = true;
            SpamKeysListView.Location = new Point(3, 3);
            SpamKeysListView.Name = "SpamKeysListView";
            SpamKeysListView.Scrollable = false;
            SpamKeysListView.ShowGroups = false;
            SpamKeysListView.Size = new Size(227, 439);
            SpamKeysListView.TabIndex = 0;
            SpamKeysListView.UseCompatibleStateImageBehavior = false;
            SpamKeysListView.View = View.Details;
            SpamKeysListView.DoubleClick += SpamkeysListView;
            // 
            // ActiveHeader
            // 
            ActiveHeader.Text = "Active";
            // 
            // KeyHeader
            // 
            KeyHeader.Text = "Key";
            KeyHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // IntervalHeader
            // 
            IntervalHeader.Text = "Interval";
            IntervalHeader.TextAlign = HorizontalAlignment.Center;
            IntervalHeader.Width = 100;
            // 
            // IDHeader
            // 
            IDHeader.Text = "ID";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Location = new Point(4, 20);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(306, 445);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mouse";
            // 
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(320, 539);
            Controls.Add(visualStudioTabControl2);
            Controls.Add(CurrentWindowLabel);
            Controls.Add(OnOffPanel);
            Controls.Add(ApplicationExitButton);
            Controls.Add(WorkingLabel);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartupForm";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += StartupForm_MouseDown;
            visualStudioTabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage KeyboardPage;
        private TabPage MousePage;
        private Panel OnOffPanel;
        private Button ApplicationExitButton;
        private Label WorkingLabel;
        private Label CurrentWindowLabel;
        private Controls.VisualStudioTabControl visualStudioTabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListView SpamKeysListView;
        private ColumnHeader ActiveHeader;
        private ColumnHeader KeyHeader;
        private ColumnHeader IntervalHeader;
        private ColumnHeader IDHeader;
        private System.Windows.Forms.Timer MainTimer;
    }
}