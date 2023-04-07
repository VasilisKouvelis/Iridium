using Iridium.Components;
using Iridium.Managers;
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
        public Dictionary<int, SpamKey> SPAMKEYS = null;
        private int SPAMKEYID = -9999;
        private InputManager inputManager = new InputManager();
        private bool AddNewSpamKey = false;

        public EditForm(Dictionary<int, SpamKey> spamKeys, int id) {
            SPAMKEYID = id;
            InitializeComponent();
            SPAMKEYS = spamKeys;
            if (SPAMKEYID == -9999) {
                AddNewSpamKey = true;
            }

            if (AddNewSpamKey) {
                SelectedKey.Text = "NONE";
                IntervalBox.Text = "1000";
                IsActiveBox.Checked = true;
                return;
            }

            spamKey = spamKeys[SPAMKEYID];
            if (spamKey == null)
                return;
            inputManager.SetKey(spamKey.Key);
            SelectedKey.Text = KeyMapper.GetKeyString(spamKey.Key);
            IntervalBox.Text = spamKey.Interval.ToString();
            IsActiveBox.Checked = spamKey.Active;
        }


        private void ApplyBtn_Click(object sender, EventArgs e) {
            foreach (var spamKey in SPAMKEYS) {
                if (spamKey.Value.Key == inputManager.GetKey() && spamKey.Value.ID != SPAMKEYID) {
                    MessageBox.Show("Key already exists.");
                    return;
                }
            }


            // add a new spamkey if the id is -9999 else update the existing one
            if (AddNewSpamKey) {
                var key = KeyMapper.SelectKeyFromString(SelectedKey.Text);
                if ((key == Keys.None) || (!KeyMapper.IsValid(key))) {
                    MessageBox.Show("Key is invalid.");
                    return;
                }
                SPAMKEYS.Add(SpamKey.GetIncremental(), new SpamKey(inputManager.GetKey(), int.Parse(IntervalBox.Text), IsActiveBox.Checked));
            }
            else {
                spamKey.Key = inputManager.GetKey();
                spamKey.Interval = int.Parse(IntervalBox.Text);
                spamKey.Active = IsActiveBox.Checked;
            }
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void SelectedKey_Click(object sender, EventArgs e) {
            SelectedKey.ForeColor = inputManager.Toggle();
        }
        private void KeyButton_KeyPress(object sender, KeyPressEventArgs e) {
            inputManager.SetKey(KeyMapper.SelectKey(e.KeyChar));
            SelectedKey.Text = inputManager.GetKeyName();
            SelectedKey.ForeColor = inputManager.Toggle();
        }

        private void IntervalBox_TextChanged(object sender, EventArgs e) {

        }
    }
}
