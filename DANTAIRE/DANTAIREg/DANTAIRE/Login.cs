using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace DANTAIRE
{
    public partial class LOGINFORM : Form
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
        public LOGINFORM()
        {
            InitializeComponent();
            /////________________LES BORDERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //____________________
        }


        private void LOGINFORM_Load(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            if(!Textpassword.UseSystemPasswordChar)
            {
                gunaPictureBox5.Image = DANTAIRE.Properties.Resources.visibility;
                Textpassword.UseSystemPasswordChar = true;
            }
            else
            {
                gunaPictureBox5.Image = DANTAIRE.Properties.Resources.visibility__1_;
                
                Textpassword.UseSystemPasswordChar = false;
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            if (TextUser.Text == "Admin" && Textpassword.Text == "Admin")
            {
                AdminMenu a = new AdminMenu();
                a.Show();
                this.Hide();
            }
            else if (TextUser.Text == "User" && Textpassword.Text == "User")
            {
                MenuUser a = new MenuUser();
                a.Show();
                this.Hide();
            }
            else
            {
                messagebox f = new messagebox();
                f.gunaLabel2.Text = "Vérifier votre saisie";
                f.ShowDialog(this);
            }
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            messageboxyesno f = new messageboxyesno();
            f.gunaLabel2.Text = "Voulez vous fermer cette fenêtre ?";
            f.ShowDialog(this);
            if (f.close == true)
            {

                Application.Exit();

            }
        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
