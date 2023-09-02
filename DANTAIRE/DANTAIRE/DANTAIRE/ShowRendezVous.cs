using System;
using System.Drawing;
using System.Windows.Forms;

namespace DANTAIRE
{
    public partial class ShowRendezVous : Form
    {
        public ShowRendezVous()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            gunaCheckBox1.Checked = true;
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
                guna2GroupBox15.Size = new Size(529, 196);
            else
                guna2GroupBox15.Size = new Size(529, 25);

        }

        private void gunaGradientButton18_Click(object sender, EventArgs e)
        {
            AjouterRendezVousPatient f = new AjouterRendezVousPatient();
            f.onn = "Modifier Rendez-Vous";
            f.ShowDialog();
        }
    }
}
