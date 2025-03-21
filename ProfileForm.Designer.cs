namespace WildCatTickets
{
    partial class ProfileForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.tabFormPallet = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabFormPallet
            // 
            this.tabFormPallet.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.tabFormPallet.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.tabFormPallet.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.tabFormPallet.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.FormStyles.FormMain.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tabFormPallet.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.tabFormPallet.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.tabFormPallet.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tabFormPallet.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.tabFormPallet.FormStyles.FormMain.StateInactive.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.FormStyles.FormMain.StateInactive.Back.Color2 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.FormStyles.FormMain.StateInactive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tabFormPallet.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Goldenrod;
            this.tabFormPallet.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.tabFormPallet.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Boost Player PERSONAL USE ONLY", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "WildCat Tickets ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(358, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "This is the Profile Page";
            // 
            // ProfileForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(958, 633);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LocalCustomPalette = this.tabFormPallet;
            this.Name = "ProfileForm";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase tabFormPallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}