
namespace DANTAIRE.ChatAdd
{
    partial class Incoming
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMsgText3 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelMagText4 = new System.Windows.Forms.Label();
            this.PictureBoxUserMsg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PanelMsgText3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMsgText3
            // 
            this.PanelMsgText3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMsgText3.BackColor = System.Drawing.SystemColors.Control;
            this.PanelMsgText3.BorderRadius = 15;
            this.PanelMsgText3.Controls.Add(this.labelMagText4);
            this.PanelMsgText3.FillColor = System.Drawing.SystemColors.Control;
            this.PanelMsgText3.ForeColor = System.Drawing.Color.Black;
            this.PanelMsgText3.Location = new System.Drawing.Point(47, 7);
            this.PanelMsgText3.Name = "PanelMsgText3";
            this.PanelMsgText3.ShadowDecoration.Parent = this.PanelMsgText3;
            this.PanelMsgText3.Size = new System.Drawing.Size(305, 41);
            this.PanelMsgText3.TabIndex = 21;
            // 
            // labelMagText4
            // 
            this.labelMagText4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMagText4.AutoSize = true;
            this.labelMagText4.BackColor = System.Drawing.Color.Transparent;
            this.labelMagText4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelMagText4.ForeColor = System.Drawing.Color.Black;
            this.labelMagText4.Location = new System.Drawing.Point(11, 13);
            this.labelMagText4.MaximumSize = new System.Drawing.Size(268, 0);
            this.labelMagText4.Name = "labelMagText4";
            this.labelMagText4.Size = new System.Drawing.Size(43, 13);
            this.labelMagText4.TabIndex = 12;
            this.labelMagText4.Text = "Go Go";
            this.labelMagText4.Click += new System.EventHandler(this.labelMagText4_Click);
            // 
            // PictureBoxUserMsg
            // 
            this.PictureBoxUserMsg.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxUserMsg.Image = global::DANTAIRE.Properties.Resources.usernn;
            this.PictureBoxUserMsg.Location = new System.Drawing.Point(3, 7);
            this.PictureBoxUserMsg.Name = "PictureBoxUserMsg";
            this.PictureBoxUserMsg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxUserMsg.ShadowDecoration.Parent = this.PictureBoxUserMsg;
            this.PictureBoxUserMsg.Size = new System.Drawing.Size(35, 30);
            this.PictureBoxUserMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUserMsg.TabIndex = 20;
            this.PictureBoxUserMsg.TabStop = false;
            // 
            // Incoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelMsgText3);
            this.Controls.Add(this.PictureBoxUserMsg);
            this.Name = "Incoming";
            this.Size = new System.Drawing.Size(378, 51);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Resize += new System.EventHandler(this.UserControl1_Resize);
            this.PanelMsgText3.ResumeLayout(false);
            this.PanelMsgText3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxUserMsg;
        private Guna.UI2.WinForms.Guna2Panel PanelMsgText3;
        private System.Windows.Forms.Label labelMagText4;
    }
}
