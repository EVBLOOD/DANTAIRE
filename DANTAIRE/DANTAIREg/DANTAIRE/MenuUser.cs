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
    public partial class MenuUser : Form
    {

        //beging
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //end 'it's for making a form moves'
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
        public MenuUser()
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
            
            PanelDOCU.Visible = false;
            //
            //PanelOption.Visible = false;
            Panel1Payment.Visible = false;
            Panel1res.Visible = false;
            Panel1Services.Visible = false;
            //PanelCOD.Visible = false;
            //PanelDOCU.Visible = false;
            //PanelEMP.Visible = false;
            //PanelStat.Visible = false;
            //
            speechSynthesizerObj = new SpeechSynthesizer(); //for text to voice
            speechSynthesizerObj.SpeakAsync("Welcome Mr SAAD");
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (!Panel1Pass.Visible)
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = true;
                PanelDOCU.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
            }
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            if (!Panel1res.Visible)
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = true;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
            }
        }

        private void gunaGradientButton12_Click(object sender, EventArgs e)
        {
            if (!Panel1Services.Visible)
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = true;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
            }
        }

        private void gunaGradientButton16_Click(object sender, EventArgs e)
        {
            if (!Panel1Payment.Visible)
            {
                Panel1Payment.Visible = true;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Patient";
            openChildFormInPanel(new AjouterPatient());
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Patient";
            openChildFormInPanel(new ModifierPatient());
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Patient";
            openChildFormInPanel(new deletePatient());
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Rendez-Vous";
            openChildFormInPanel(new ShowRendezVous());
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Rendez-Vous";
            openChildFormInPanel(new DeleteRendezVous());
        }



        private void gunaGradientButton15_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Payment";
            openChildFormInPanel(new AddPayment());
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
            
        }

       

        private void gunaGradientButton9_Click_1(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Service";
            openChildFormInPanel(new ShowService());
        }

        
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
             this.gunaPanel1.DisplayRectangle);

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            messageboxyesno f = new messageboxyesno();
            f.gunaLabel2.Text = "Voulez vous deconnecter ?";
            f.ShowDialog(this);
            if (f.close == true)
            {
                
                LOGINFORM a = new LOGINFORM();
                a.Show();
                this.Close();
            }
            
            

        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
        }

       
        private void BDD_Click(object sender, EventArgs e)
        {
            if (!PanelDOCU.Visible)
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = true;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                Panel1Pass.Visible = false;
                PanelDOCU.Visible = false;
                
            }
        }

       

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaPictureBox8_Click(object sender, EventArgs e)
        {
            messageboxyesno f = new messageboxyesno();
            f.gunaLabel2.Text = "Voulez vous fermer cette fenêtre ?";
            f.ShowDialog(this);
            if (f.close == true)
            {

                Application.Exit();

            }
        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        bool x = false;
        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            if (!x)
            {


                this.Size = new Size(1200, 700);
                CenterToParent();
                gunaLabel1.Location = new Point((gunaPanel2.Size.Width / 2) - 54, 3);
                /////________________LES BORDERS
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
                gunaPictureBox7.BackgroundImage = DANTAIRE.Properties.Resources.minimizee;
                //____
                x = true;
            }
            else
            {
                this.Size = new Size(950, 522);
                CenterToParent();
                gunaLabel1.Location = new Point((gunaPanel2.Size.Width / 2) - 54, 3);
                /////________________LES BORDERS
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
                gunaPictureBox7.BackgroundImage = DANTAIRE.Properties.Resources.minimizing;
                //____
                x = false;

            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form15 f = new Form15();

            f.ShowDialog(this);
            if (f.Deco)
            {
                this.Close();
            }
        }

        private void gunaGradientButton27_Click(object sender, EventArgs e)
        {

        }
    }
}
