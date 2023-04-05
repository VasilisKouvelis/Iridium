using Iridium.Models;
using System.Runtime.InteropServices;

namespace Iridium.Forms {
    public partial class StartupForm : Form {

        public List<SpamKey> SpamKeys = new();
        public Dictionary<int, SpamKey> SpamKeysDict = new();

        public StartupForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.Q, 1000, true));
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.W, 1000, false));
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.E, 1000, true));
            SpamKeysDict.Add(SpamKey.GetIncremental(), new SpamKey(Keys.R, 1000, false));

            foreach (var keypair in SpamKeysDict) {
                var spamKey = keypair.Value;
                SpamKeysListView.Items.Add(spamKey.GetListViewItem());
            }
        }

        #region "Move form"
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern Boolean ReleaseCapture();
        #endregion

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
        public void AddSpamKey(SpamKey spamKey) {
            SpamKeysDict.Add(spamKey.ID, spamKey);
            SpamKeysListView.Items.Add(spamKey.GetListViewItem());
        }
       


        public void EditSpamKey() {
            //select the key from the selected item
            var selectedItem = SpamKeysListView.SelectedItems[0];
            var spamKey = SpamKeysDict[int.Parse(selectedItem.SubItems[3].Text)];
            //MessageBox.Show(spamKey.ToString());
            using EditForm editForm = new(SpamKeysDict, spamKey.ID);
            editForm.ShowDialog();

        }

        #endregion ADD_EDIT

     
    }
}