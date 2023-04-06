using Iridium.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iridium.Models {
    public class SpamKey {
        private static int Incremental = 0;


        public int ID { get; set; }
        public Keys Key { get; set; }
        public int Interval { get; set; }
        public bool Active { get; set; }

        public bool SpamRunning { get; set; }
        public SpamKey() {
            this.ID = Incremental++;
            this.Key = Keys.Escape;
            this.Interval = 1000;
            this.Active = false;
            this.SpamRunning = false;
        }

        public SpamKey(Keys key, int interval, bool active) {
            this.ID = Incremental++;
            this.Key = key;
            this.Interval = interval;
            this.Active = active;
            this.SpamRunning = false;
        }

        public SpamKey(int id, Keys key, int interval, bool active) {
            this.ID = id;
            this.Key = key;
            this.Interval = interval;
            this.Active = active;
            this.SpamRunning = false;
        }

        public SpamKey(SpamKey spamKey) {
            this.ID = spamKey.ID;
            this.Key = spamKey.Key;
            this.Interval = spamKey.Interval;
            this.Active = spamKey.Active;   
            this.SpamRunning = false;
        }

        public void SetKey(Keys key) {
            this.Key = key;
        }

        public void SetInterval(int interval) {
            this.Interval = interval;
        }

        public void SetActive(bool active) {
            this.Active = active;
        }

        public ListViewItem GetListViewItem() {
            ListViewItem item = new(Active? "Yes" : "No" );
            item.SubItems.Add(KeyMapper.GetKeyString(this.Key));
            item.SubItems.Add(this.Interval.ToString());
            item.SubItems.Add(this.ID.ToString());
            return item;
        }



        public override string ToString() {
            return string.Format("ID: {0}, Key: {1}, Interval: {2}, Active: {3}", this.ID, this.Key, this.Interval, this.Active);
        }

        public static void ResetIncremental() {
            Incremental = 0;
        }

        public static int GetIncremental() {
            return Incremental;
        }

        public static void SetIncremental(int value) {
            Incremental = value;
        }

        public System.Windows.Forms.Timer SpamTimer;
        private void SpamTimer_Tick(object sender, EventArgs e) {
            SendKeys.Send(KeyMapper.GetKey(this.Key));
        }
        public void StartSpam() {
            SpamTimer = new();
            SpamTimer.Interval = this.Interval;
            SpamTimer.Tick += SpamTimer_Tick;
            SpamTimer.Start();
            this.SpamRunning = true;
        }
        public void StopSpam() {
            SpamTimer.Stop();
            SpamTimer.Dispose();
            this.SpamRunning = false;
        }
      
    }
}
