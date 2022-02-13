namespace ScreensTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Screen x in Screen.AllScreens)
            {
                edtMain.Text += $"{x.DeviceName}: W:{x.Bounds.Width} H:{x.Bounds.Height}";
                
            }
        }
        private int ConvertMousePointToScreenIndex(Point mousePoint)
        {
            //first get all the screens 
            System.Drawing.Rectangle ret;

            for (int i = 1; i <= Screen.AllScreens.Count(); i++)
            {
                ret = Screen.AllScreens[i - 1].Bounds;
                if (ret.Contains(mousePoint))
                    return i - 1;
            }
            return 0;
        }
        private void tmrMouse_Tick(object sender, EventArgs e)
        {
            lblX.Text = System.Windows.Forms.Cursor.Position.X.ToString();
            lblY.Text = System.Windows.Forms.Cursor.Position.Y.ToString();
        }

        private void tmrScreenGet_Tick(object sender, EventArgs e)
        {
            lblScreenNum.Text = ConvertMousePointToScreenIndex(System.Windows.Forms.Cursor.Position).ToString();
        }
    }
}