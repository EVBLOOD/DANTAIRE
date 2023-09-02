using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace DANTAIRE
{
    public partial class AdminMenu : Form
    {
        //beging
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //end 'it's for making a form moves'
        /////________________POUR LES BORDERS
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
        public AdminMenu()
        {
            InitializeComponent();
            /////________________LES BORDERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //____________________
        }

        private void PanelAcceuil_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
               this.PanelAcceuil.DisplayRectangle);
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            Panel1Payment.Visible = false;
            Panel1res.Visible = false;
            Panel1Services.Visible = false;
            PanelCOD.Visible = false;
            PanelDOCU.Visible = false;
            PanelEMP.Visible = false;
            PanelStat.Visible = false;


        }

        private void BD_Click(object sender, EventArgs e)
        {
            if (PanelCOD.Visible == false)
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = true;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }

        }

        private void BR_Click(object sender, EventArgs e)
        {
            if (Panel1res.Visible == false)
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = true;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
        }

        private void BS_Click(object sender, EventArgs e)
        {
            if (Panel1Services.Visible == false)
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = true;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
        }

        private void BPP_Click(object sender, EventArgs e)
        {
            if (Panel1Payment.Visible == false)
            {
                Panel1Payment.Visible = true;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
        }

        private void BP_Click(object sender, EventArgs e)
        {
            if (Panel1Pass.Visible == false)
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = true;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.gunaPanel2.ClientRectangle, Color.Black, ButtonBorderStyle.Inset);
            //e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
            //               this.gunaPanel2.DisplayRectangle);
        }

        private void gunaPictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.gunaPictureBox1.ClientRectangle, Color.Black, ButtonBorderStyle.Inset);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
               this.gunaPictureBox1.DisplayRectangle);
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
            this.gunaPanel1.DisplayRectangle);
        }





        private void BE_Click(object sender, EventArgs e)
        {
            if (PanelEMP.Visible == false)
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = true;
                PanelStat.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
        }

        private void BDD_Click(object sender, EventArgs e)
        {
            if (PanelDOCU.Visible == false)
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = true;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
        }

        private void BSS_Click(object sender, EventArgs e)
        {
            if (PanelStat.Visible == false)
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = true;
            }
            else
            {
                Panel1Payment.Visible = false;
                Panel1Pass.Visible = false;
                Panel1res.Visible = false;
                Panel1Services.Visible = false;
                PanelCOD.Visible = false;
                PanelDOCU.Visible = false;
                PanelEMP.Visible = false;
                PanelStat.Visible = false;
            }
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

        private void gunaPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox4_Click_1(object sender, EventArgs e)
        {

        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            OptionParaandDisc f = new OptionParaandDisc();

            f.ShowDialog(this);
            if (f.Deco)
            {
                this.Close();
            }

        }
        bool x = false;
        private void gunaPictureBox3_Click_1(object sender, EventArgs e)
        {
            if (!x)
            {


                PanelAcceuil.Size = new Size(1200, 700);
                this.Size = new Size(1200, 700);
                CenterToParent();
                gunaLabel1.Location = new Point((gunaPanel2.Size.Width / 2) - 54, 3);
                /////________________LES BORDERS
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
                gunaPictureBox3.BackgroundImage = DANTAIRE.Properties.Resources.minimizee;
                //____
                x = true;
            }
            else
            {
                PanelAcceuil.Size = new Size(950, 522);
                this.Size = new Size(950, 522);
                CenterToParent();
                gunaLabel1.Location = new Point((gunaPanel2.Size.Width / 2) - 54, 3);
                /////________________LES BORDERS
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
                gunaPictureBox3.BackgroundImage = DANTAIRE.Properties.Resources.minimizing;
                //____
                x = false;

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

        private void gunaGradientButton9_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Service";
            openChildFormInPanel(new ShowService());
        }

        private void gunaGradientButton15_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Payment";
            openChildFormInPanel(new AddPayment());
        }
    }
}
