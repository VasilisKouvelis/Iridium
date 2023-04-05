using Iridium.Components;
using Iridium.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iridium.Forms {
    public partial class EditForm : Form {
        public EditForm() {

        }
        private SpamKey spamKey = null;
        public EditForm(Dictionary<int, SpamKey> spamKeys, int id) {
            InitializeComponent();
            spamKey = spamKeys[id];
            if (spamKey == null)
                return;
            KeyButton.Text = KeyMapper.GetKeyString(spamKey.Key);
            IntervalBox.Text = spamKey.Interval.ToString();
            IsActiveBox.Checked = spamKey.Active;
        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
