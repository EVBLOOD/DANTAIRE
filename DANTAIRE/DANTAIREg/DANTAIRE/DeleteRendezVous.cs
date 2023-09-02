using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANTAIRE
{
    public partial class DeleteRendezVous : Form
    {
        public DeleteRendezVous()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            messageboxyesno f = new messageboxyesno();
            f.gunaLabel2.Text = "Etes-vous sûr ?";
            f.ShowDialog(this);
            if (f.close == true)
            {
                MessageBox.Show("Lcode");
                f.Close();
            }
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
                guna2GroupBox15.Size = new Size(529, 196);
            else
                guna2GroupBox15.Size = new Size(529, 25);
        }

        private void DeleteRendezVous_Load(object sender, EventArgs e)
        {
            gunaCheckBox1.Checked = false;
        }
    }
}
