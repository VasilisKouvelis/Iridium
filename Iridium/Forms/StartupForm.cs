using Iridium.Managers;
using Iridium.Models;
using System.Runtime.InteropServices;
using System.Text;

namespace Iridium.Forms {
    public partial class StartupForm : Form {

        public List<SpamKey> SpamKeys = new();
        public Dictionary<int, SpamKey> SpamKeysDict = new();


        private int W_Width = 311;
        private int W_Height = 238;
        private bool MiniMode = false;


        public StartupForm() {
            InitializeComponent();
        }

        public void PopulateSpamButtons() {
            SpamKeysListView.Items.Clear();
            foreach (var kp in SpamKeysDict) {
                var spamKey = kp.Value;
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
            //EditSpamKey();
            ToggleBtn_Click(sender, e);
        }
        private void button2_Click(object sender, EventArgs e) {
            EditSpamKey();
        }

        #region ADD_EDIT
        public void AddSpamKey() {
            using EditForm editForm = new(SpamKeysDict, -9999);
            editForm.ShowDialog();
            SpamKeysDict = editForm.SPAMKEYS;
            PopulateSpamButtons();
        }



        public void EditSpamKey() {
            try {
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
            catch (Exception ex) {
                StringBuilder sb = new StringBuilder();
                foreach (var item in SpamKeysDict) {
                    sb.AppendLine($"{item.Key}  {item.Value}");
                }
                MessageBox.Show($"{ex}\n\n{sb}");

            }

        }

        #endregion ADD_EDIT


        private void button1_Click(object sender, EventArgs e) {
            AddSpamKey();
        }

        private void ToggleBtn_Click(object sender, EventArgs e) {
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
            this.BackColor = (Console.CapsLock ? Color.Lime : Color.Red);
            if (Console.CapsLock) {
                spamManager.Start(SpamKeysDict);
            }
            else { spamManager.Stop(SpamKeysDict); }
        }

        private void DeleteKeyBtn_Click(object sender, EventArgs e) {
            //delete from the list the selected item
            if (SpamKeysListView.SelectedItems.Count == 0)
                return;
            var selectedItem = SpamKeysListView.SelectedItems[0];
            var spamKey = SpamKeysDict[int.Parse(selectedItem.SubItems[3].Text)];
            SpamKeysDict.Remove(spamKey.ID);
            PopulateSpamButtons();
        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void MiniModeBtn_Click_1(object sender, EventArgs e) {
            MiniMode = !MiniMode;
            this.Height = (MiniMode ? 28 : W_Height);


        }
    }
}