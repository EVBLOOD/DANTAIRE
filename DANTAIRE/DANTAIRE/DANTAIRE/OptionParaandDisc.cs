using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace DANTAIRE
{
    public partial class OptionParaandDisc : Form
    {
        //beging
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //end 'it's for making a form moves'
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
        public OptionParaandDisc()
        {
            InitializeComponent();
            /////________________LES BORDERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //____________________
        }
        public bool Deco = false;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            messageboxyesno f = new messageboxyesno();
            f.gunaLabel2.Text = "Voulez vous deconnecter ?";
            f.ShowDialog(this);
            if (f.close == true)
            {
                Deco = true;
                LOGINFORM a = new LOGINFORM();
                a.Show();
                this.Close();

            }


        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
            this.gunaPanel4.DisplayRectangle);
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelOption_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
