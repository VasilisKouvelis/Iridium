using System.Runtime.InteropServices;

namespace Iridium.Forms {
    public partial class StartupForm : Form {
        public StartupForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

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
    }
}