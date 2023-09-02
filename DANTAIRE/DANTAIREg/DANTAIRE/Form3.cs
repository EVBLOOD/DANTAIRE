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
using System.Speech; //for text to voice
using System.Speech.Synthesis;  //for text to voice


namespace DANTAIRE
{
    public partial class Form3 : Form
    {
        


        //to open a form in a panel
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelAcceuil.Controls.Add(childForm);
            PanelAcceuil.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        //it's a fonction!!!
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
        public Form3()
        {
            InitializeComponent();
            /////________________LES BORDERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //____________________
        }

        //SpeechSynthesizer Class Provides access to the functionality of an installed a speech synthesis engine.
        SpeechSynthesizer speechSynthesizerObj;

        private void Form3_Load(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Acceuil";
            PanelOption.Hide();
            PanelOption.Visible = false;
            speechSynthesizerObj = new SpeechSynthesizer(); //for text to voice
            speechSynthesizerObj.SpeakAsync("Welcome Mr SAAD");
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (Panel1Pass.Visible)
            {

                Panel1Pass.Hide();
                Panel1Pass.Visible = false;
                Panel1res.Show();
                Panel1res.Visible = true;
                Panel1Services.Show();
                Panel1Services.Visible = true;
                Panel1Payment.Show();
                Panel1Payment.Visible = true;
            }
            else
            {
                Panel1Pass.Show();
                Panel1Pass.Visible = true;
            }
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            if (Panel1res.Visible)
            {
                Panel1res.Hide();
                Panel1res.Visible = false;
                Panel1Pass.Show();
                Panel1Pass.Visible = true;
                Panel1Services.Show();
                Panel1Services.Visible = true;
                Panel1Payment.Show();
                Panel1Payment.Visible = true;
            }
            else
            {
                Panel1res.Show();
                Panel1res.Visible = true;
            }
        }

        private void gunaGradientButton12_Click(object sender, EventArgs e)
        {
            if (Panel1Services.Visible)
            {
                Panel1Services.Hide();
                Panel1Services.Visible = false;
                Panel1Pass.Show();
                Panel1Pass.Visible = true;
                Panel1res.Show();
                Panel1res.Visible = true;
                Panel1Payment.Show();
                Panel1Payment.Visible = true;
            }
            else
            {
                Panel1Services.Show();
                Panel1Services.Visible = true;
            }
        }

        private void gunaGradientButton16_Click(object sender, EventArgs e)
        {
            if (Panel1Payment.Visible)
            {
                Panel1Payment.Hide();
                Panel1Payment.Visible = false;
                Panel1Pass.Show();
                Panel1Pass.Visible = true;
                Panel1res.Show();
                Panel1res.Visible = true;
                Panel1Services.Show();
                Panel1Services.Visible = true;
            }
            else
            {
                Panel1Payment.Show();
                Panel1Payment.Visible = true;
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Patient";
            openChildFormInPanel(new Form4());
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Patient";
            openChildFormInPanel(new Form5());
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Patient";
            openChildFormInPanel(new Form6());
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Reservation";
            openChildFormInPanel(new Form7());
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Reservation";
            openChildFormInPanel(new Form8());
        }



        private void gunaGradientButton15_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Payment";
            openChildFormInPanel(new Form10());
        }

        private void gunaGradientButton14_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Payment";
            openChildFormInPanel(new Form11());

        }

        private void gunaGradientButton13_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Payment";
            openChildFormInPanel(new Form12());

        }

        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Payment";
            openChildFormInPanel(new Form13());

        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            if (PanelOption.Visible)
                PanelOption.Visible = false;
            else PanelOption.Visible = true;
        }

       

        private void gunaGradientButton9_Click_1(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Service";
            openChildFormInPanel(new Form9());
        }
    }
}
