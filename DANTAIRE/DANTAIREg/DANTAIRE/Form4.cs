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
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
            /////________________LES BORDERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //____________________
        }
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DateRendezvous.Format = DateTimePickerFormat.Custom;
            DateRendezvous.CustomFormat = "MM/dd/yyyy hh:mm:ss";
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
    }
}
