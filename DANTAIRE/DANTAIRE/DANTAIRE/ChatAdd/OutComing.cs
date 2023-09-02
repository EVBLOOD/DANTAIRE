using System;
using System.Drawing;
using System.Windows.Forms;

namespace DANTAIRE.ChatAdd
{
    public partial class OutComing : UserControl
    {
        public OutComing()
        {
            InitializeComponent();
        }
        public string Message { get { return labelMagText4.Text; } set { labelMagText4.Text = value; } }
        public Image Avatar { get; set; }
        void adjustHight()
        {
            labelMagText4.Height = TextHight.gettexthight(labelMagText4) + 18;
            PanelMsgText3.Height = labelMagText4.Top + labelMagText4.Height + PictureBoxUserMsg.Top;
            this.Height = labelMagText4.Bottom;
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void UserControl2_Resize(object sender, EventArgs e)
        {
            adjustHight();
        }
    }
}
