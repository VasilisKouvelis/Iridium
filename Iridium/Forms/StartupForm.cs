using Iridium.Managers;
using Iridium.Models;
using System.Runtime.InteropServices;
using System.Text;

namespace Iridium.Forms {
    public partial class StartupForm : Form {

        public List<SpamKey> SpamKeys = new();
        public Dictionary<int, SpamKey> SpamKeysDict = new();

        public StartupForm() {
            InitializeComponent();
        }

        public void PopulateSpamButtons() {
            SpamKeysListView.Items.Clear();
            foreach (var keypair in SpamKeysDict) {
                var spamKey = keypair.Value;
                SpamKeysListView.Items.Add(spamKey.GetListViewItem());
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.Q, 1000, true));
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.W, 1000, false));
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.E, 1000, true));
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.R, 1000, false));

            PopulateSpamButtons();


        }
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        #region "Move form"
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern Boolean ReleaseCapture();
        #endregion

        #region "Get Active Windows"

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private String GetActiveWindow() {
            const int nChars = 256;
            IntPtr handle;
            StringBuilder sb = new StringBuilder(nChars);
            String ret = "Winner winner chicken dinner!";
            handle = GetForegroundWindow();
            if (GetWindowText(handle, sb, nChars) > 0) {
                ret = (sb.ToString());
            }
            sb.Clear();
            return ret;
        }

        #endregion "Get Active Windows"
        private void StartupForm_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void ApplicationExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void SpamkeysListView(object sender, EventArgs e) {
            EditSpamKey();
        }
        private void button2_Click(object sender, EventArgs e) {
            EditSpamKey();
        }

        #region ADD_EDIT
        public void AddSpamKey() {
            using EditForm editForm = new(SpamKeysDict, -9999);
            editForm.ShowDialog();

            PopulateSpamButtons();
        }



        public void EditSpamKey() {
            //select the key from the selected item
            if (SpamKeysListView.SelectedItems.Count == 0)
                return;
            var selectedItem = SpamKeysListView.SelectedItems[0];
            var spamKey = SpamKeysDict[int.Parse(selectedItem.SubItems[3].Text)];
            //MessageBox.Show(spamKey.ToString());
            using EditForm editForm = new(SpamKeysDict, spamKey.ID);
            editForm.ShowDialog();

            PopulateSpamButtons();

        }

        #endregion ADD_EDIT


        private void button1_Click(object sender, EventArgs e) {
            AddSpamKey();
        }

        private void button4_Click(object sender, EventArgs e) {
            //toggle the active state of selected 
            if (SpamKeysListView.SelectedItems.Count == 0)
                return;
            var selectedItem = SpamKeysListView.SelectedItems[0];
            var spamKey = SpamKeysDict[int.Parse(selectedItem.SubItems[3].Text)];
            spamKey.Active = !spamKey.Active;
            PopulateSpamButtons();
        }
        private SpamManager spamManager = new();
        private void MainTimer_Tick(object sender, EventArgs e) {
            CurrentWindowLabel.Text = this.Text = GetActiveWindow();
            WorkingLabel.Text = (Console.CapsLock ? "ON" : "OFF");
            OnOffPanel.BackColor = (Console.CapsLock ? Color.Lime : Color.Red);
            if (Console.CapsLock) {
                spamManager.Start(SpamKeysDict);
            }
            else { spamManager.Stop(SpamKeysDict); }
        }
    }
}