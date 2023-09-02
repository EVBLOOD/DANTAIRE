using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DANTAIRE
{
    public partial class FormSPLASH : Form
    {
        /////________________POUR LES BORDERS

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        //____________________


        public FormSPLASH()
        {
            InitializeComponent();
            /////________________LES BORDERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //____________________
        }
        private void FormSPLASH_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start(); //for the first apearnce of the splash

        }
        DateTime i;
        DateTime b = DateTime.Now.AddSeconds(8);
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = DateTime.Now;

            i.ToString(); //after 3s splash will be hiden and a new form will open
            if (i >= b)
            {
                timer1.Stop();
                LOGINFORM a = new LOGINFORM();
                a.Show();
                this.Hide();
            }
        }
    }
}
