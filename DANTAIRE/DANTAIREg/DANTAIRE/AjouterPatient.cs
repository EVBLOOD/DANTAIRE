using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //for the borders


namespace DANTAIRE
{
    public partial class AjouterPatient : Form
    {
        ///////________________POUR LES BORDERS

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);
        ////____________________
        public AjouterPatient()
        {
            InitializeComponent();
            ///////________________LES BORDERS
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ////____________________
        }
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            gunaRadioButton17.Checked = true;
            gunaRadioButton13.Checked = true;
            gunaRadioButton2.Checked = true;
            gunaRadioButton5.Checked = true;
            gunaRadioButton10.Checked = true;
            gunaCheckBox1.Checked = false;
            gunaRadioButton19.Checked = true;
            gunaRadioButton9.Checked = true;

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ComboDOC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //gunaLabel3.Text = "CNE";
        }

        private void gunaRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //gunaLabel3.Text = "Passport";
        }

        private void Acceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            
            AjouterRendezVousPatient f = new AjouterRendezVousPatient();
            f.onn = "Ajouter Rendez-Vous";
            f.ShowDialog(this);
            
        }

        private void guna2GroupBox11_Click(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
            {
                guna2GroupBox9.Size = new Size(304, 297);
            }
            else
                guna2GroupBox9.Size = new Size(304, 25);
        }

        private void gunaRadioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (gunaRadioButton5.Checked) guna2TextBox3.PlaceholderText = "CNE";
            else guna2TextBox3.PlaceholderText = "Passport";
        }
    }
}
