namespace EMRge.UserControls
{
    partial class UCMedication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMedication));
            this.LblMedNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblMed = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblAlternateMed = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // LblMedNo
            // 
            this.LblMedNo.AllowParentOverrides = false;
            this.LblMedNo.AutoEllipsis = true;
            this.LblMedNo.CursorType = null;
            this.LblMedNo.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedNo.IsSelectionEnabled = true;
            this.LblMedNo.Location = new System.Drawing.Point(23, 20);
            this.LblMedNo.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblMedNo.Name = "LblMedNo";
            this.LblMedNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMedNo.Size = new System.Drawing.Size(10, 19);
            this.LblMedNo.TabIndex = 82;
            this.LblMedNo.Text = "1. ";
            this.LblMedNo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblMedNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblMed
            // 
            this.LblMed.AllowParentOverrides = false;
            this.LblMed.AutoEllipsis = true;
            this.LblMed.CursorType = null;
            this.LblMed.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMed.IsSelectionEnabled = true;
            this.LblMed.Location = new System.Drawing.Point(60, 5);
            this.LblMed.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblMed.Name = "LblMed";
            this.LblMed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMed.Size = new System.Drawing.Size(54, 19);
            this.LblMed.TabIndex = 83;
            this.LblMed.Text = "Med XYZ";
            this.LblMed.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblMed.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblAlternateMed
            // 
            this.LblAlternateMed.AllowParentOverrides = false;
            this.LblAlternateMed.AutoEllipsis = true;
            this.LblAlternateMed.CursorType = null;
            this.LblAlternateMed.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlternateMed.IsSelectionEnabled = true;
            this.LblAlternateMed.Location = new System.Drawing.Point(60, 34);
            this.LblAlternateMed.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblAlternateMed.Name = "LblAlternateMed";
            this.LblAlternateMed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblAlternateMed.Size = new System.Drawing.Size(146, 19);
            this.LblAlternateMed.TabIndex = 84;
            this.LblAlternateMed.Text = "(Alternative) - Med ZZZ";
            this.LblAlternateMed.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblAlternateMed.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UCMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblAlternateMed);
            this.Controls.Add(this.LblMed);
            this.Controls.Add(this.LblMedNo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCMedication";
            this.Size = new System.Drawing.Size(286, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel LblMedNo;
        private Bunifu.UI.WinForms.BunifuLabel LblMed;
        private Bunifu.UI.WinForms.BunifuLabel LblAlternateMed;
    }
}
