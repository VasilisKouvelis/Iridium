using Iridium.Components;
using Iridium.Managers;
using System.ComponentModel;

namespace Iridium.Controls {

    public partial class KeySelector : UserControl {

        [Category("Spam"), Browsable(true), Description("Is the spam of this key active?")]
        public bool Active { get; set; }

        [Category("Spam"), Browsable(true), Description("Can replace the spamming key?")]
        public bool Replaceable { get; set; }

        [Category("Spam"), Browsable(true), Description("The Key for spam.")]
        public InputManager KeyValue { get; set; }

        [Category("Spam"), Browsable(true), Description("The Key interval between presses.")]
        public int KeyInterval { get; set; }

        public KeySelector() {
            this.Active = false;
            this.KeyValue = new InputManager();
            InitializeComponent();
        }

        private void SpamToggle_Click(object sender, EventArgs e) {
            Interval.Enabled = Key.Enabled = Active = !Active;
            Indicator.FlatAppearance.BorderColor = (Active ? Color.Lime : Color.Red);
        }

        private void SelectKey_Click(object sender, EventArgs e) {
            Key.ForeColor = KeyValue.Toggle();
        }

        private void SelectKey_KeyPress(object sender, KeyPressEventArgs e) {
            if (KeyValue.CanReplace()) {
                KeyValue.SetKey((KeyMapper.SelectKey((e.KeyChar))));
                Key.Text = KeyValue.GetKeyName();
                Key.ForeColor = KeyValue.Toggle();
            }
        }

        private void KeySelector_Load(object sender, EventArgs e) {
            Interval.Enabled = Key.Enabled = this.Active;
            Indicator.FlatAppearance.BorderColor = (Active ? Color.Lime : Color.Red);
        }
    }
}