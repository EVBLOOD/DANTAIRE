using System;
using System.Windows.Forms;

namespace DANTAIRE
{
    public partial class ModifierPatient : Form
    {
        public ModifierPatient()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (gunaRadioButton3.Checked)
            {
                ModifierPatientnext f = new ModifierPatientnext();
                f.ShowDialog();
            }
            else
            {
                AjouterRendezVousPatient f = new AjouterRendezVousPatient();
                f.onn = "Modifier Rendez-Vous";
                f.ShowDialog();
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ModifierPatient_Load(object sender, EventArgs e)
        {
            gunaRadioButton3.Checked = true;
        }
    }
}
