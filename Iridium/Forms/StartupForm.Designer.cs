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
            ApplicationExitButton = new Button();
            WorkingLabel = new Label();
            CurrentWindowLabel = new Label();
            ToggleKeyBtn = new Button();
            DeleteKeyBtn = new Button();
            EditKeyBtn = new Button();
            AddKeyBtn = new Button();
            SpamKeysListView = new ListView();
            ActiveHeader = new ColumnHeader();
            KeyHeader = new ColumnHeader();
            IntervalHeader = new ColumnHeader();
            IDHeader = new ColumnHeader();
            MainTimer = new System.Windows.Forms.Timer(components);
            MainFormPanel = new Panel();
            label3 = new Label();
            MiniModeBtn = new Button();
            MainFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ApplicationExitButton
            // 
            ApplicationExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApplicationExitButton.BackColor = Color.Transparent;
            ApplicationExitButton.FlatAppearance.BorderColor = Color.Black;
            ApplicationExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            ApplicationExitButton.FlatAppearance.MouseOverBackColor = Color.Red;
            ApplicationExitButton.FlatStyle = FlatStyle.Flat;
            ApplicationExitButton.ForeColor = Color.Black;
            ApplicationExitButton.Location = new Point(282, 2);
            ApplicationExitButton.Margin = new Padding(4);
            ApplicationExitButton.Name = "ApplicationExitButton";
            ApplicationExitButton.Size = new Size(27, 25);
            ApplicationExitButton.TabIndex = 6;
            ApplicationExitButton.Text = "X";
            ApplicationExitButton.UseVisualStyleBackColor = false;
            ApplicationExitButton.Click += ApplicationExitButton_Click;
            // 
            // WorkingLabel
            // 
            WorkingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WorkingLabel.AutoSize = true;
            WorkingLabel.BackColor = Color.Transparent;
            WorkingLabel.Font = new Font("Lato", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WorkingLabel.ForeColor = Color.Black;
            WorkingLabel.Location = new Point(214, 2);
            WorkingLabel.Margin = new Padding(4, 0, 4, 0);
            WorkingLabel.Name = "WorkingLabel";
            WorkingLabel.Size = new Size(48, 24);
            WorkingLabel.TabIndex = 7;
            WorkingLabel.Text = "OFF";
            WorkingLabel.Visible = false;
            // 
            // CurrentWindowLabel
            // 
            CurrentWindowLabel.BackColor = Color.Transparent;
            CurrentWindowLabel.Dock = DockStyle.Top;
            CurrentWindowLabel.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentWindowLabel.ForeColor = Color.DimGray;
            CurrentWindowLabel.Location = new Point(0, 0);
            CurrentWindowLabel.Margin = new Padding(4, 0, 4, 0);
            CurrentWindowLabel.Name = "CurrentWindowLabel";
            CurrentWindowLabel.Size = new Size(307, 13);
            CurrentWindowLabel.TabIndex = 8;
            CurrentWindowLabel.Text = "Current Window Title";
            CurrentWindowLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToggleKeyBtn
            // 
            ToggleKeyBtn.FlatAppearance.BorderColor = Color.SkyBlue;
            ToggleKeyBtn.FlatStyle = FlatStyle.Flat;
            ToggleKeyBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ToggleKeyBtn.ForeColor = Color.SkyBlue;
            ToggleKeyBtn.Location = new Point(238, 114);
            ToggleKeyBtn.Margin = new Padding(4);
            ToggleKeyBtn.Name = "ToggleKeyBtn";
            ToggleKeyBtn.Size = new Size(63, 40);
            ToggleKeyBtn.TabIndex = 10;
            ToggleKeyBtn.Text = "Toggle";
            ToggleKeyBtn.UseVisualStyleBackColor = true;
            ToggleKeyBtn.Click += ToggleBtn_Click;
            // 
            // DeleteKeyBtn
            // 
            DeleteKeyBtn.FlatAppearance.BorderColor = Color.Red;
            DeleteKeyBtn.FlatStyle = FlatStyle.Flat;
            DeleteKeyBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteKeyBtn.ForeColor = Color.Red;
            DeleteKeyBtn.Location = new Point(238, 162);
            DeleteKeyBtn.Margin = new Padding(4);
            DeleteKeyBtn.Name = "DeleteKeyBtn";
            DeleteKeyBtn.Size = new Size(63, 40);
            DeleteKeyBtn.TabIndex = 9;
            DeleteKeyBtn.Text = "Delete";
            DeleteKeyBtn.UseVisualStyleBackColor = true;
            DeleteKeyBtn.Click += DeleteKeyBtn_Click;
            // 
            // EditKeyBtn
            // 
            EditKeyBtn.FlatAppearance.BorderColor = Color.Orange;
            EditKeyBtn.FlatStyle = FlatStyle.Flat;
            EditKeyBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            EditKeyBtn.ForeColor = Color.Orange;
            EditKeyBtn.Location = new Point(238, 66);
            EditKeyBtn.Margin = new Padding(4);
            EditKeyBtn.Name = "EditKeyBtn";
            EditKeyBtn.Size = new Size(63, 40);
            EditKeyBtn.TabIndex = 8;
            EditKeyBtn.Text = "Edit";
            EditKeyBtn.UseVisualStyleBackColor = true;
            EditKeyBtn.Click += button2_Click;
            // 
            // AddKeyBtn
            // 
            AddKeyBtn.FlatAppearance.BorderColor = Color.Lime;
            AddKeyBtn.FlatStyle = FlatStyle.Flat;
            AddKeyBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddKeyBtn.ForeColor = Color.Lime;
            AddKeyBtn.Location = new Point(238, 18);
            AddKeyBtn.Margin = new Padding(4);
            AddKeyBtn.Name = "AddKeyBtn";
            AddKeyBtn.Size = new Size(63, 40);
            AddKeyBtn.TabIndex = 7;
            AddKeyBtn.Text = "Add";
            AddKeyBtn.UseVisualStyleBackColor = true;
            AddKeyBtn.Click += button1_Click;
            // 
            // SpamKeysListView
            // 
            SpamKeysListView.BackColor = Color.Black;
            SpamKeysListView.Columns.AddRange(new ColumnHeader[] { ActiveHeader, KeyHeader, IntervalHeader, IDHeader });
            SpamKeysListView.ForeColor = Color.Red;
            SpamKeysListView.FullRowSelect = true;
            SpamKeysListView.Location = new Point(4, 18);
            SpamKeysListView.Margin = new Padding(4);
            SpamKeysListView.Name = "SpamKeysListView";
            SpamKeysListView.Scrollable = false;
            SpamKeysListView.ShowGroups = false;
            SpamKeysListView.Size = new Size(226, 184);
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
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // MainFormPanel
            // 
            MainFormPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainFormPanel.BackColor = Color.Black;
            MainFormPanel.Controls.Add(SpamKeysListView);
            MainFormPanel.Controls.Add(CurrentWindowLabel);
            MainFormPanel.Controls.Add(ToggleKeyBtn);
            MainFormPanel.Controls.Add(AddKeyBtn);
            MainFormPanel.Controls.Add(DeleteKeyBtn);
            MainFormPanel.Controls.Add(EditKeyBtn);
            MainFormPanel.Location = new Point(2, 28);
            MainFormPanel.Name = "MainFormPanel";
            MainFormPanel.Size = new Size(307, 208);
            MainFormPanel.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(4, 2);
            label3.Name = "label3";
            label3.Size = new Size(126, 24);
            label3.TabIndex = 13;
            label3.Text = "Key Smasher";
            // 
            // MiniModeBtn
            // 
            MiniModeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MiniModeBtn.BackColor = Color.Transparent;
            MiniModeBtn.FlatAppearance.BorderColor = Color.Black;
            MiniModeBtn.FlatStyle = FlatStyle.Flat;
            MiniModeBtn.ForeColor = Color.Black;
            MiniModeBtn.Location = new Point(270, 2);
            MiniModeBtn.Margin = new Padding(4);
            MiniModeBtn.Name = "MiniModeBtn";
            MiniModeBtn.Size = new Size(10, 25);
            MiniModeBtn.TabIndex = 14;
            MiniModeBtn.UseVisualStyleBackColor = false;
            MiniModeBtn.Click += MiniModeBtn_Click_1;
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(311, 238);
            Controls.Add(MiniModeBtn);
            Controls.Add(label3);
            Controls.Add(MainFormPanel);
            Controls.Add(ApplicationExitButton);
            Controls.Add(WorkingLabel);
            Font = new Font("Lato", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StartupForm";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Key Smasher";
            Load += Form1_Load;
            MouseDown += StartupForm_MouseDown;
            MainFormPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label WorkingLabel;
        private Label CurrentWindowLabel;
        private Button ApplicationExitButton;
        private Button ToggleKeyBtn;
        private Button DeleteKeyBtn;
        private Button EditKeyBtn;
        private Button AddKeyBtn;
        private ListView SpamKeysListView;
        private ColumnHeader ActiveHeader;
        private ColumnHeader KeyHeader;
        private ColumnHeader IntervalHeader;
        private ColumnHeader IDHeader;
        private System.Windows.Forms.Timer MainTimer;
        private Panel MainFormPanel;
        private Label label3;
        private Button MiniModeBtn;
    }
}