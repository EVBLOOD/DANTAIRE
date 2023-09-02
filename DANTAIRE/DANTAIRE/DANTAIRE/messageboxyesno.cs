using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DANTAIRE
{
    public partial class messageboxyesno : Form
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
        public messageboxyesno()
        {
            InitializeComponent();
            /////________________LES BORDERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //____________________
        }
        public bool close;
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            close = false;
            this.Close();
        }
    }
}
